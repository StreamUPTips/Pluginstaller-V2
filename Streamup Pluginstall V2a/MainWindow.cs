using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.IO.Compression;
using System.Security.Principal;
using HttpClientProgress;
using System.Net;
using System.Drawing.Text;

namespace Streamup_Pluginstall_V2 {
    public partial class MainWindow : Form {

        Dictionary<int, Plugin> recommendedPlugins = new Dictionary<int, Plugin>();
        Dictionary<int, Plugin> requiredPlugins = new Dictionary<int, Plugin>();
        Dictionary<int, Plugin> recommendedAndRequiredPlugins = new Dictionary<int, Plugin>();
        Dictionary<int, Plugin> allPlugins = new Dictionary<int, Plugin>();
        JObject parsedJson;
        string buttonDownloadDefaultText;
        string outOfDateOBSPlugins = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "StreamUP-OutdatedPluginsList.txt");
        readonly string appFolder = AppDomain.CurrentDomain.BaseDirectory;
        string currentVersion = "2.0.0";

        public MainWindow() {
            InitializeComponent();
        }

        private void LoadSettings() {
            checkBoxExtract.Checked = Convert.ToBoolean(Properties.Settings.Default["unzipFiles"]);

            string filePath = Properties.Settings.Default["saveLocation"].ToString() ?? "";
            _ = (!string.IsNullOrEmpty(filePath)) ? textBoxSaveLocation.Text = filePath : textBoxSaveLocation.Text = appFolder;

            if (filePath.Contains(Environment.ExpandEnvironmentVariables("%ProgramW6432%"))) {
                SetElevation(filePath);
            } else if (filePath.Contains(Environment.ExpandEnvironmentVariables("%SystemRoot%"))) {
                textBoxSaveLocation.Text = appFolder;
                Properties.Settings.Default.Save();
            }

            SetOBSSettings();
        }

        private void ClearSettings() {
            Properties.Settings.Default["saveLocation"] = null;
        }

        private void SetOBSSettings() {
            if (textBoxSaveLocation.Text.ToLower().Contains("obs-studio")) {
                labelWarning1.Visible = true;
                checkBoxExtract.Enabled = false;
                checkBoxExtract.Checked = true;
            } else {
                labelWarning1.Visible = false;
            }
        }

        private async void CheckForUpdates() {

            int.TryParse(currentVersion.Replace(".", ""), out int currentVersionNumber);

            using HttpClient client = new HttpClient();
            var result = await client.GetAsync("https://gist.githubusercontent.com/itsSilverlink/960e49255a3aebbd63c44f55d5fcf9eb/raw/pluginstaller.txt");
            var onlineVersion = await result.Content.ReadAsStringAsync();
            int.TryParse(onlineVersion.Replace(".", ""), out int onlineVersionNumbers);

            if (onlineVersionNumbers > currentVersionNumber) {
                labelVersion.Text = $"NEW VERSION AVAILABLE! {onlineVersion} - {currentVersion}";
            }
        }


        private async void MainWindow_Load(object sender, EventArgs e) {
            CheckForUpdates();
            LoadSettings();

            labelVersion.Text = currentVersion;

            buttonDownloadDefaultText = buttonDownload.Text;

            FileSystemWatcher outDatedPluginList = new FileSystemWatcher();
            outDatedPluginList.Path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            outDatedPluginList.Filter = "StreamUP-OutdatedPluginsList.txt";
            outDatedPluginList.Created += PluginListCheck;
            outDatedPluginList.Deleted += PluginListCheck;
            outDatedPluginList.EnableRaisingEvents = true;

            int maxRetries = 5;
            int currentRetry = 0;
            string pluginList = "";

            while (currentRetry < maxRetries) {
                try {
                    AddTextToLog($"Trying to connect to StreamUP API (Attempt {currentRetry + 1} of {maxRetries})");
                    using HttpClient client = new HttpClient();
                    HttpResponseMessage response = await client.GetAsync(@"https://api.streamup.tips/plugins");
                    response.EnsureSuccessStatusCode();
                    pluginList = await response.Content.ReadAsStringAsync();
                    break;
                } catch (HttpRequestException error) {
                    AddTextToLog(error.Message);
                } catch (Exception error) {
                    AddTextToLog(error.Message);
                }
                currentRetry++;
                await Task.Delay(2000);
            }

            if (currentRetry == maxRetries) {
                MessageBox.Show("Cannot connect to StreamUP API, Make sure you are connected to the internet", "Uh oh", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Environment.Exit(1);
            }
            
            parsedJson = JObject.Parse(pluginList);

            JArray? plugins = parsedJson["plugins"] as JArray;

            int i = 0;
            int iRecommended = 0;
            int iRequired = 0;
            int iRecommendedAndRequired = 0;

            foreach (var plugin in plugins) {

                if (plugin["name"].ToString().ToLower().Contains("inno")) { continue; }
                if (!Convert.ToBoolean(plugin["platforms"]["windows"])) { continue; }

                allPlugins.Add(i, SetPluginData(plugin));

                bool isRecommended = Convert.ToBoolean(plugin["recommended"].ToString());
                bool isRequired = Convert.ToBoolean(plugin["required"].ToString());

                if (isRecommended) {
                    recommendedPlugins.Add(iRecommended, SetPluginData(plugin));
                    iRecommended++;
                }

                if (isRequired) {
                    requiredPlugins.Add(iRequired, SetPluginData(plugin));
                    iRequired++;
                }

                if (isRecommended || isRequired) {
                    recommendedAndRequiredPlugins.Add(iRecommendedAndRequired, SetPluginData(plugin));
                    iRecommendedAndRequired++;
                }
                i++;
            }

            AddTextToLog($"Found {allPlugins.Count} plugins! Adding to list");

            foreach (var item in allPlugins) {
                checkedListBoxPlugins.Items.Add(item.Value.Name);
            }
            AddTextToLog($"Selecting required plugins");
            SetCheckedPlugins(requiredPlugins);

            if (File.Exists(outOfDateOBSPlugins)) {
                radioButtonOutdated.Visible = true;
            }
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonAll.Checked) {
                for (int i = 0; i < checkedListBoxPlugins.Items.Count; i++) {
                    checkedListBoxPlugins.SetItemCheckState(i, CheckState.Checked);
                }
            }
        }

        private void radioButtonRecommended_CheckedChanged(object sender, EventArgs e) {
            SetCheckedPlugins(recommendedPlugins);
        }

        private void radioButtonRequired_CheckedChanged(object sender, EventArgs e) {
            SetCheckedPlugins(requiredPlugins);
        }

        private void radioButtonRequiredRecommended_CheckedChanged(object sender, EventArgs e) {
            SetCheckedPlugins(recommendedAndRequiredPlugins);
        }

        private void radioButtonCustom_CheckedChanged(object sender, EventArgs e) {

        }

        private void radioButtonOutdated_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonOutdated.Checked) {
                var outOfDateOBSPluginsList = File.ReadAllLines(outOfDateOBSPlugins);
                SetCheckedPlugins(outOfDateOBSPluginsList);
            }            
        }

        Plugin SetPluginData(JToken pluginObject) {

            Plugin plugin = new Plugin();

            plugin.Name = pluginObject["name"].ToString();
            plugin.Uri = pluginObject["downloads"]["windows"].ToString();
            plugin.version = pluginObject["version"].ToString();

            return plugin;
        }

        private void buttonSaveFolder_Click(object sender, EventArgs e) {
            var folderDialogResult = new FolderBrowserDialog();

            folderDialogResult.SelectedPath = textBoxSaveLocation.Text;
            DialogResult result = folderDialogResult.ShowDialog();
            if (result != DialogResult.OK) {
                textBoxSaveLocation.Text = appFolder;
                SetOBSSettings();
                return;
            }

            string selectedPath = folderDialogResult.SelectedPath.ToString();

            textBoxSaveLocation.Text = selectedPath;
            Properties.Settings.Default["saveLocation"] = selectedPath;
            Properties.Settings.Default.Save();
            SetOBSSettings();
            if (selectedPath.Contains(Environment.ExpandEnvironmentVariables("%ProgramW6432%")) && selectedPath.ToLower().Contains("obs-studio")) {
                if (!SetElevation(selectedPath)) return;
            } else if (selectedPath.Contains(Environment.ExpandEnvironmentVariables("%ProgramW6432%"))) {
                MessageBox.Show($"Sorry selecting a location within {Environment.ExpandEnvironmentVariables("%ProgramW6432%")} is not allowed UNLESS it is in the obs-studio folder!", $"OBS-Studio folder not Selected in {Environment.ExpandEnvironmentVariables("%ProgramW6432%")}", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBoxSaveLocation.Text = appFolder;
                Properties.Settings.Default["saveLocation"] = appFolder;
            } else if (selectedPath.Contains(Environment.ExpandEnvironmentVariables("%SystemRoot%"))) {
                MessageBox.Show($"Sorry selecting a location within {Environment.ExpandEnvironmentVariables("%SystemRoot%")} is not allowed!", $"{Environment.ExpandEnvironmentVariables("%SystemRoot%")} is not allowed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBoxSaveLocation.Text = appFolder;
                Properties.Settings.Default["saveLocation"] = appFolder;
            }

            if (selectedPath.ToLower().Contains("obs-studio")) {
                checkBoxExtract.Enabled = false;
                checkBoxExtract.Checked = true;

                var extractToOBSFolder = MessageBox.Show("You selected an OBS-Studio directory. Are you sure you want to use that?", "WARNING: OBS-STUDIO FOLDER SELECTED", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (extractToOBSFolder == DialogResult.No) {
                    buttonSaveFolder_Click(sender, e);
                }
            } else {
                checkBoxExtract.Enabled = true;
            }

        }

        private async Task GetPlugins(string tempFolder) {

            void ProgressChanged(object sender, float progress) {

                int progressInt = (int)Math.Round(progress);

                progressBarDownload.Value = progressInt;
            }

            if (!Directory.Exists(tempFolder)) {
                AddTextToLog("No temp folder found, creating one.");
                Directory.CreateDirectory(tempFolder);
            } else {
                AddTextToLog("Cleaning up temp folder");
                DirectoryInfo directoryInfo = new DirectoryInfo(tempFolder);

                var files = directoryInfo.GetFiles();
                if (files.Length > 0) {
                    foreach (FileInfo file in files) {
                        file.Delete();
                    }
                }

                var directories = directoryInfo.GetDirectories();
                if (directories.Length > 0) {
                    foreach (DirectoryInfo directory in directories) {
                        directory.Delete(true);
                    }
                }
            }

            progressBarDownload.Visible = true;
            var totalPluginsToDownload = checkedListBoxPlugins.CheckedItems.Count;
            int i = 0;
            using HttpClient downloadClient = new HttpClient();
            foreach (var item in checkedListBoxPlugins.CheckedItems) {
                i++;
                progressBarDownload.CustomText = @$"{i}/{totalPluginsToDownload}";
                AddTextToLog($"Downloading: {item}");
                var searchItem = parsedJson.SelectToken($"$.plugins[?(@.name=='{item}')]");
                string fileURL = searchItem["downloads"]["windows"].ToString();

                if (string.IsNullOrEmpty(fileURL)) {
                    AddTextToLog($"No download URL found for {item}! Go bother Andi to fix it!");
                    continue;
                }

                var downloadURL = new System.Uri(fileURL);

                var progress = new Progress<float>();
                progress.ProgressChanged += ProgressChanged;

                HttpResponseMessage headersResponse = await downloadClient.SendAsync(new HttpRequestMessage(HttpMethod.Head, fileURL));
                ContentDispositionHeaderValue contentDisposition = headersResponse.Content.Headers.ContentDisposition;
                string fileName = fileURL.Split(@"/").Last().ToString();

                if (!(fileName.Contains(".zip"))) {
                    if (contentDisposition != null && contentDisposition.FileName != null) {
                        fileName = contentDisposition.FileName.Trim(new char[] { '"' });
                    } else {
                        MessageBox.Show($"Cannot download {item}. Please make a screenshot of this and post it in the StreamUP Discord");
                        continue;
                    }
                }

                using (var file = new FileStream(Path.Combine(tempFolder, fileName), FileMode.Create, FileAccess.Write, FileShare.None)) {
                    await downloadClient.DownloadDataAsync(fileURL, file, progress);
                }
            }
            progressBarDownload.Visible = false;
        }

        private async void buttonDownload_Click(object sender, EventArgs e) {
            if (checkBoxOpenUrlsOnly.Checked) {
                var openURLs = MessageBox.Show($"Are you sure you want to open {checkedListBoxPlugins.CheckedItems.Count} links in your default browser??", $"Open Links in Browser", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                foreach (var item in checkedListBoxPlugins.CheckedItems) {
                    var searchItem = (parsedJson.SelectToken($"$.plugins[?(@.name=='{item}')]"));
                    string URL = (searchItem != null) ? searchItem["url"].ToString() : "";
                    if (string.IsNullOrEmpty(URL)) {
                        AddTextToLog($"No URL found for {item}! Go bother Andi to fix his shit!");
                        continue;
                    }
                    try {
                        System.Diagnostics.Process.Start(new ProcessStartInfo(URL) { UseShellExecute = true });
                    } catch (System.ComponentModel.Win32Exception noBrowser) {
                        if (noBrowser.ErrorCode == -2147467259) {
                            AddTextToLog(noBrowser.Message);
                        }
                    } catch (System.Exception other) {
                        AddTextToLog(other.Message);
                    }
                }
                return;
            }

            string tempFolder = Path.Combine(appFolder, "temp");
            string remainingFilesFolder = Path.Combine(appFolder, "Remaining Files");
            string destinationFolder = textBoxSaveLocation.Text;
            bool containsOBSStudioFolder = destinationFolder.ToLower().Contains("obs-studio");
            bool extractFiles = checkBoxExtract.Checked;

            if (containsOBSStudioFolder && extractFiles) {
                bool canContinue = GetOBSProcesses(destinationFolder);
                if (!canContinue) {
                    AddTextToLog("User cancelled or couldn't close OBS-Studio");
                    return;
                }
                AddTextToLog("Making backup of OBS-Studio Folder");
                AddTextToLog("Please wait, this may take a while!");
                long totalFolderSize = GetFolderSize(textBoxSaveLocation.Text, true);
                double totalFolderSizeInMB = ConvertToMegaBytes(totalFolderSize);
                AddTextToLog($"OBS-Studio Folder size: {totalFolderSizeInMB} MB");
                long backupSize = await BackupOBSStudioFolder(destinationFolder);
                double backupSizeInMB = ConvertToMegaBytes(backupSize);
                AddTextToLog($"Backup size: {backupSizeInMB} MB");
                AddTextToLog("Backup done!");
            }

            await GetPlugins(tempFolder);

            if (!extractFiles) {
                AddTextToLog("----------");
                AddTextToLog(@"Automatically Extract is unticked, not extracting files");
                AddTextToLog(@"Moving the files to a directory called 'Downloaded Files' in your selected directory");
                CopyFolder(tempFolder, Path.Combine(destinationFolder, "Downloaded Files"));
                Directory.Delete(tempFolder, true);
                AddTextToLog(@$"Done downloading! You can find the files in:");
                AddTextToLog($@"""File://{Path.Combine(destinationFolder, "Downloaded Files")}""");
                return;
            }

            ExpandFiles(tempFolder);

            string tempOBSFolder = Path.Combine(tempFolder, "obs-studio");

            if (!containsOBSStudioFolder) {
                destinationFolder = Path.Combine(destinationFolder, "obs-studio");
            }

            // Copy complete obs-studio folder to destination
            AddTextToLog("Copying files to destination folder!");
            CopyFolder(tempOBSFolder, destinationFolder);
            AddTextToLog("Done with copying");

            // Delete the TEMP OBS-Studio Folder
            Directory.Delete(tempOBSFolder, true);

            // Checking if there are files remaining and after that copying them to the AppFolder\Remaining Files
            if (Directory.GetFiles(tempFolder).Length > 0) {
                AddTextToLog(@"Remaining files found, copying these to the AppFolder\Remaining Files\r\nThese files need to be installed manually");
                CopyFolder(tempFolder, remainingFilesFolder);
            }

            // Deleting the temp folder!
            Directory.Delete(tempFolder, true);

            if (containsOBSStudioFolder) {
                AddTextToLog("Files have been copied / written to your OBS-Studio Folder!\r\nIf there are any issues please restore a backup.");
            }
            AddTextToLog("DONE!");

            /* string finalText = @"---------------
All plugins should be downloaded and extracted.
You can click the button 'Open download folder' to open the directory with the proper files in it.
The folder that has been created is called 'obs-studio' and you can OVERWRITE your own obs-studio folder.
This will make sure that you have the latest plugins installed in your obs-studio folder.

If there are any other files in the downloads folder like 7z, EXE or MSI files you need to install or extract those yourself to your 'obs-studio' folder.

Thank you for using the Pluginstaller by StreamUP";

            AddTextToLog(finalText); */
        }

        private async Task<long> BackupOBSStudioFolder(string obsPath) {
            string currentDateTime = DateTime.Now.ToString("yyyyMMddhhmm");
            string backupFileName = $"{currentDateTime} - Backup OBS Studio.zip";
            string backupPath = Path.Combine(appFolder, "backup");

            if (!File.Exists(backupPath)) {
                Directory.CreateDirectory(backupPath);
            }

            string backupPathComplete = Path.Combine(backupPath, backupFileName);
            var backupTask = Task.Run(() => {
                ZipFile.CreateFromDirectory(obsPath, backupPathComplete);
            });
            
            AddTextToLog(@"Creating backup!");
            while (!backupTask.IsCompleted) {
                try {
                    FileInfo currentBackupSize = new FileInfo(backupPathComplete);
                    var currentBackupSizeInMB = ConvertToMegaBytes(currentBackupSize.Length);
                    AddTextToLog($"Current Backup Size: {currentBackupSizeInMB} MB");
                    await Task.Delay(1000);
                } catch (Exception) {
                    continue;
                }               
            }

            FileInfo fileInfo = new FileInfo(backupPathComplete);
            return fileInfo.Length;
        }

        private bool GetOBSProcesses(string destinationFolder) {

            AddTextToLog($"Checking for running OBS instances in {destinationFolder}");
            List<Process> obsProcesses = new List<Process>();

            Process[] processCollection = Process.GetProcesses();
            foreach (Process process in processCollection) {
                if (process.ProcessName.Contains("obs64")) {
                    if (process.MainModule.FileName.Contains(textBoxSaveLocation.Text)) {
                        obsProcesses.Add(process);
                    }
                }
            }

            if (obsProcesses.Count <= 0) { AddTextToLog($"No running OBS Instances found!"); return true; }
            AddTextToLog("Running OBS Found!");

            CloseOBSMessageBox closeOBSMessageBox = new CloseOBSMessageBox();
            DialogResult closeOBS = closeOBSMessageBox.ShowDialog();

            if (closeOBS == DialogResult.No) return false;
            foreach (Process process in obsProcesses) {
                process.Kill();
                process.Dispose();
            }
            return true;
        }

        private async void buttonExpand_Click(object sender, EventArgs e) {
            
        }

        private void CopyFolder(string sourceFolder, string destinationFolder) {
            if (!Directory.Exists(sourceFolder)) {
                throw new DirectoryNotFoundException($"Source folder '{sourceFolder}' not found.");
            }

            // Create the destination folder if it doesn't exist
            if (!Directory.Exists(destinationFolder)) {
                Directory.CreateDirectory(destinationFolder);
            }

            // Get the files in the source folder and copy them to the destination folder
            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files) {
                string destinationFilePath = Path.Combine(destinationFolder, Path.GetFileName(file));
                File.Copy(file, destinationFilePath, true); // Set overwrite to true to allow overwriting existing files
            }

            // Get the subdirectories and recursively copy them
            string[] subdirectories = Directory.GetDirectories(sourceFolder);
            foreach (string subdirectory in subdirectories) {
                string destinationSubdirectory = Path.Combine(destinationFolder, Path.GetFileName(subdirectory));
                CopyFolder(subdirectory, destinationSubdirectory);
            }
        }

        private void AddTextToLog(string text) {
            richTextBoxLog.AppendText($"{text}\r\n");
        }

        private void checkBoxOpenUrlsOnly_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxOpenUrlsOnly.Checked) {
                checkBoxExtract.Checked = false;
                checkBoxExtract.Enabled = false;
                buttonDownload.Text = $"Open URLs";
            } else {
                checkBoxExtract.Enabled = true;
                buttonDownload.Text = buttonDownloadDefaultText;
            }
            return;
        }

        private void ExpandFiles(string directoryPath) {
            AddTextToLog($"Unzipping files in {directoryPath}");

            var zipFiles = Directory.GetFiles(directoryPath, "*.zip");
            string extractPath = directoryPath;

            foreach (var zipFile in zipFiles) {
                string zipFileName = zipFile.Split(@"\").Last();
                AddTextToLog($"Extracting {zipFileName}");
                string fileName = zipFileName.Substring(0, zipFileName.Length - 4);
                string extractOBSPath = Path.Combine(directoryPath, "obs-studio");

                switch (fileName) {
                    case string fn when fn.Contains("blur-filter-obs-plugin"): {
                            extractPath = Path.Combine(directoryPath, "blur-filter-obs-plugin");
                            break;
                        }
                    case string fn when fn.Contains("windows_libraries"): {
                            extractPath = Path.Combine(directoryPath, "obs-text-slideshow");
                            break;
                        }
                    case string fn when fn.Contains("obs-gstreamer") || fn.Contains("obs-teleport") || fn.Contains("obs-toolbar"): {
                            extractPath = Path.Combine(directoryPath, fileName);
                            break;
                        }
                    default: {
                            extractPath = extractOBSPath;
                            break;
                        }
                }

                ZipFile.ExtractToDirectory(zipFile, extractPath);
                File.Delete(zipFile);

                if (extractPath.Contains("blur-filter-obs-plugin")) {
                    AddTextToLog($"Moving {fileName} to plugin folder");
                    var filesAndFolders = Directory.GetFiles(extractPath);
                    foreach (var item in filesAndFolders) {
                        fileName = item.Split(@"\").Last();
                        File.Move(item, Path.Combine(directoryPath, fileName));
                    }
                    Directory.Delete(extractPath, true);
                } else if (extractPath.Contains("obs-text-slideshow") || extractPath.Contains("obs-toolbar")) {
                    var filesAndFolders = Directory.GetFiles(extractPath);
                    AddTextToLog($"Moving {fileName} to plugin folder");
                    foreach (var item in filesAndFolders) {
                        fileName = item.Split(@"\").Last();
                        string obsPluginsFolder = Path.Combine(extractOBSPath, @"obs-plugins\64bit");
                        File.Move(item, Path.Combine(obsPluginsFolder, fileName));
                    }
                    Directory.Delete(extractPath, true);
                } else if (extractPath.Contains("obs-gstreamer")) {
                    var filesAndFolders = Directory.GetFiles(extractPath, "*", SearchOption.AllDirectories);
                    AddTextToLog($"Moving {fileName} to plugin folder");
                    foreach (var item in filesAndFolders) {
                        if (item.Contains(@"obs-gstreamer\windows")) {
                            if (item.Contains(".exe") || item.Contains(".msi")) { continue; }
                            fileName = item.Split(@"\").Last();
                            string obsPluginsFolder = Path.Combine(extractOBSPath, @"obs-plugins\64bit");
                            File.Move(item, Path.Combine(obsPluginsFolder, fileName));
                        }
                    }
                    Directory.Delete(extractPath, true);
                } else if (extractPath.Contains("obs-teleport")) {
                    var filesAndFolders = Directory.GetFiles(extractPath, "*", SearchOption.AllDirectories);
                    AddTextToLog($"Moving {fileName} to plugin folder");
                    foreach (var item in filesAndFolders) {
                        if (item.Contains(@"windows-x86_64")) {
                            if (item.Contains(".exe") || item.Contains(".msi")) { continue; }
                            fileName = item.Split(@"\").Last();
                            string obsPluginsFolder = Path.Combine(extractOBSPath, @"obs-plugins\64bit");
                            File.Move(item, Path.Combine(obsPluginsFolder, fileName));
                        }
                    }
                    Directory.Delete(extractPath, true);
                }
            }
        }

        private void buttonOpenFolder_Click(object sender, EventArgs e) {

            string downloadPath = textBoxSaveLocation.Text;

            if (!downloadPath.Contains("obs-studio")) {
                if (Directory.Exists(Path.Combine(downloadPath, "Downloads"))) {
                    downloadPath = Path.Combine(downloadPath, "Downloads");
                }
            }

            try {
                System.Diagnostics.Process.Start("explorer.exe", downloadPath);
            } catch (System.Exception other) {
                AddTextToLog(other.Message);
            }
        }

        private void checkBoxUnzip_CheckedChanged(object sender, EventArgs e) {
            Properties.Settings.Default["unzipFiles"] = checkBoxExtract.Checked;
            Properties.Settings.Default.Save();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.Save();
        }

        private void buttonUnZIP_Click(object sender, EventArgs e) {
            var directoryPath = Path.Combine(textBoxSaveLocation.Text, "Downloads");
            ExpandFiles(directoryPath);
        }

        private bool SetElevation(string selectedPath) {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);

            bool isElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);

            if (isElevated) { labelWarning2.Visible = true; return true; }

            string elevateMessage = @"Download location set in the Program Files directory!
The StreamUP Pluginstaller needs elevated rights to extract files in the Program Files Directory.

Do you want to start the StreamUP Pluginstaller with Elevated Rights?

If you click No you can select a different location where you can download the OBS-Studio Plugins and if you click Yes StreamUP cannot be held responsible for any mishaps or broken stuff in your OBS-Studio Instance.";

            var elevate = MessageBox.Show(elevateMessage, "Program Files detected!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (elevate == DialogResult.Yes) {
                var proc = new ProcessStartInfo();
                proc.UseShellExecute = true;
                proc.WorkingDirectory = appFolder;
                proc.FileName = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
                proc.Verb = "runas";

                Debug.WriteLine(proc);

                try {
                    Process.Start(proc);
                } catch (Exception) {
                    Debug.WriteLine("Failed to elevate.");
                    return false;
                }

                System.Windows.Forms.Application.Exit();
            } else {
                var folderDialogResult = new FolderBrowserDialog();

                folderDialogResult.SelectedPath = textBoxSaveLocation.Text;
                DialogResult result = folderDialogResult.ShowDialog();

                if (result != DialogResult.OK) {
                    textBoxSaveLocation.Text = appFolder;
                    Properties.Settings.Default["saveLocation"] = appFolder;
                    SetOBSSettings();
                    return false;
                }

                selectedPath = folderDialogResult.SelectedPath.ToString();
                textBoxSaveLocation.Text = selectedPath;
                Properties.Settings.Default["saveLocation"] = selectedPath;
                if (selectedPath.Contains(Environment.ExpandEnvironmentVariables("%ProgramW6432%"))) {
                    SetElevation(selectedPath);
                }
            }

            return true;
        }

        private void SetCheckedPlugins(dynamic pluginsToEnable, bool uncheckAll = true) {

            if (uncheckAll) {
                for (int i = 0; i < checkedListBoxPlugins.Items.Count; i++) {
                    checkedListBoxPlugins.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            foreach (var item in pluginsToEnable) {

                string itemName;

                Type valueType = item.GetType();
                itemName = (valueType.IsGenericType) ? item.Value.Name : item;

                int itemIndex = checkedListBoxPlugins.Items.Cast<string>().ToList().IndexOf(itemName);
                if (itemIndex > -1) {
                    checkedListBoxPlugins.SetItemCheckState(itemIndex, CheckState.Checked);
                }
            }
        }

        private void richTextBoxLog_LinkClicked(object sender, LinkClickedEventArgs e) {
            Debug.WriteLine(e.LinkText);
            try {
                System.Diagnostics.Process.Start(new ProcessStartInfo(e.LinkText) { UseShellExecute = true });
            } catch (Exception) {
                return;
            }
        }

        private void checkedListBoxPlugins_MouseClick(object sender, MouseEventArgs e) {
            radioButtonCustom.Checked = true;
        }

        static long GetFolderSize (string directoryPath, bool includeSubDirectories) {
            long totalSize;
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);

            totalSize = directoryInfo.EnumerateFiles().Sum((file) =>  file.Length);
            if (includeSubDirectories) {
                totalSize += directoryInfo.EnumerateDirectories().Sum((directory) => GetFolderSize(directory.FullName, true));
            }
            return totalSize;
        }

        static double ConvertToMegaBytes (long size) {
            return Math.Ceiling(((double)size) / (1024 * 1024) * 100) / 100;
        }

        private void PluginListCheck(object sender, FileSystemEventArgs e) {
            if (e.ChangeType == WatcherChangeTypes.Created) {
                Invoke(new Action(() => {
                    radioButtonOutdated.Visible = true;
                }));
            } else if (e.ChangeType == WatcherChangeTypes.Deleted) {
                Invoke(new Action(() => {
                    radioButtonOutdated.Visible = false;
                    radioButtonRequired.Select();
                }));
            }
        }

    }

    class Plugin {
        public string? Name { get; set; }
        public string? Uri { get; set; }
        public string? version { get; set; }
    }
}

