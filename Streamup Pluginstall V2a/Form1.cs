using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.ComponentModel;
using System.Net.Mime;
using System.IO;
using System.Net.Http.Headers;
using static System.Net.Mime.MediaTypeNames;
using System.IO.Compression;
using System.Diagnostics.CodeAnalysis;
using System.Security.Policy;

namespace Streamup_Pluginstall_V2 {
    public partial class MainWindow : Form {

        Dictionary<int, Plugin> recommendedPlugins = new Dictionary<int, Plugin>();
        Dictionary<int, Plugin> suggestedPlugins = new Dictionary<int, Plugin>();
        Dictionary<int, Plugin> recommendedAndSuggestedPlugins = new Dictionary<int, Plugin>();
        Dictionary<int, Plugin> allPlugins = new Dictionary<int, Plugin>();
        JObject parsedJson;
        string buttonDownloadDefaultText;
        string outOfDateOBSPlugins = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "StreamUP-OutdatedPluginsList.txt");

        public MainWindow() {
            InitializeComponent();
        }

        private void LoadSettings() {
            checkBoxUnzip.Checked = Convert.ToBoolean(Properties.Settings.Default["unzipFiles"]);

            _ = (!string.IsNullOrEmpty(Properties.Settings.Default["saveLocation"].ToString())) ? textBoxSaveLocation.Text = Properties.Settings.Default["saveLocation"].ToString() : textBoxSaveLocation.Text = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void ClearSettings() {
            Properties.Settings.Default["saveLocation"] = null;
        }

        private async void Form1_Load(object sender, EventArgs e) {

            LoadSettings();

            buttonDownloadDefaultText = buttonDownload.Text;
            var client = new HttpClient();

            SetLoggingText("Checking if Download Directory exists", false, true);
            var directoryPath = Path.Combine(textBoxSaveLocation.Text, "Downloads");

            if (!Directory.Exists(directoryPath)) {
                SetLoggingText("Download Directory does not exist. Creating!", true, true);
                Directory.CreateDirectory(directoryPath);
            }

            SetLoggingText("Trying to connect to StreamUP API", false, true);
            var result = await client.GetAsync($"https://api.streamup.tips/plugins");
            if (!result.IsSuccessStatusCode) {
                MessageBox.Show("Could not retrieve plugin list", "Error retrieving Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SetLoggingText("Connected! Parsing Data", false, true);
            var content = await result.Content.ReadAsStringAsync();
            parsedJson = JObject.Parse(content);

            JArray? plugins = parsedJson["plugins"] as JArray;

            int i = 0;
            int iRecommended = 0;
            int iSuggested = 0;
            int iRecommendedAndSuggested = 0;

            foreach (var plugin in plugins) {

                if (plugin["name"].ToString().ToLower().Contains("inno")) { continue; }
                if (!Convert.ToBoolean(plugin["platforms"]["windows"])) { continue; }

                allPlugins.Add(i, SetPluginData(plugin));

                bool isRecommended = Convert.ToBoolean(plugin["recommended"].ToString());
                bool isSuggested = Convert.ToBoolean(plugin["suggested"].ToString());

                if (isRecommended) {
                    recommendedPlugins.Add(iRecommended, SetPluginData(plugin));
                    iRecommended++;
                }

                if (isSuggested) {
                    suggestedPlugins.Add(iSuggested, SetPluginData(plugin));
                    iSuggested++;
                }

                if (isRecommended || isSuggested) {
                    recommendedAndSuggestedPlugins.Add(iRecommendedAndSuggested, SetPluginData(plugin));
                    iRecommendedAndSuggested++;
                }
                i++;
            }

            SetLoggingText($"Found {allPlugins.Count} plugins! Adding to list", false, true);

            foreach (var item in allPlugins) {
                checkedListBoxPlugins.Items.Add(item.Value.Name);
            }
            SetLoggingText($"Selecting recommended plugins", false, true);
            int itemIndex = 0;
            foreach (var item in recommendedPlugins) {
                itemIndex = checkedListBoxPlugins.Items.Cast<string>().ToList().IndexOf(item.Value.Name);
                if (itemIndex > -1) {
                    checkedListBoxPlugins.SetItemCheckState(itemIndex, CheckState.Checked);
                }
            }

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
            if (radioButtonRecommended.Checked) {
                for (int i = 0; i < checkedListBoxPlugins.Items.Count; i++) {
                    checkedListBoxPlugins.SetItemCheckState(i, CheckState.Unchecked);
                }

                int itemIndex = 0;
                foreach (var item in recommendedPlugins) {
                    itemIndex = checkedListBoxPlugins.Items.Cast<string>().ToList().IndexOf(item.Value.Name);
                    if (itemIndex > -1) {
                        checkedListBoxPlugins.SetItemCheckState(itemIndex, CheckState.Checked);
                    }
                }
            }
        }

        private void radioButtonSuggested_CheckedChanged(object sender, EventArgs e) {
            for (int i = 0; i < checkedListBoxPlugins.Items.Count; i++) {
                checkedListBoxPlugins.SetItemCheckState(i, CheckState.Unchecked);
            }

            int itemIndex = 0;
            foreach (var item in suggestedPlugins) {
                itemIndex = checkedListBoxPlugins.Items.Cast<string>().ToList().IndexOf(item.Value.Name);
                if (itemIndex > -1) {
                    checkedListBoxPlugins.SetItemCheckState(itemIndex, CheckState.Checked);
                }
            }
        }

        private void radioButtonRecommendedSuggested_CheckedChanged(object sender, EventArgs e) {
            for (int i = 0; i < checkedListBoxPlugins.Items.Count; i++) {
                checkedListBoxPlugins.SetItemCheckState(i, CheckState.Unchecked);
            }

            int itemIndex = 0;
            foreach (var item in recommendedAndSuggestedPlugins) {
                itemIndex = checkedListBoxPlugins.Items.Cast<string>().ToList().IndexOf(item.Value.Name);
                if (itemIndex > -1) {
                    checkedListBoxPlugins.SetItemCheckState(itemIndex, CheckState.Checked);
                }
            }

        }

        private void radioButtonCustom_CheckedChanged(object sender, EventArgs e) {
            for (int i = 0; i < checkedListBoxPlugins.Items.Count; i++) {
                checkedListBoxPlugins.SetItemCheckState(i, CheckState.Unchecked);
            }

            if (radioButtonCustom.Checked) {
                checkedListBoxPlugins.SelectionMode = SelectionMode.One;
            } else {
                checkedListBoxPlugins.SelectionMode = SelectionMode.None;
            }
        }

        private void radioButtonOutdated_CheckedChanged(object sender, EventArgs e) {
            for (int i = 0; i < checkedListBoxPlugins.Items.Count; i++) {
                checkedListBoxPlugins.SetItemCheckState(i, CheckState.Unchecked);
            }
            var outOfDateOBSPluginsList = File.ReadAllLines(outOfDateOBSPlugins);
            int itemIndex = 0;
            foreach (var item in outOfDateOBSPluginsList) {
                itemIndex = checkedListBoxPlugins.Items.Cast<string>().ToList().IndexOf(item);
                if (itemIndex > -1) {
                    checkedListBoxPlugins.SetItemCheckState(itemIndex, CheckState.Checked);
                }
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

            DialogResult result = folderDialogResult.ShowDialog();
            if (result != DialogResult.OK) {
                return;
            }

            textBoxSaveLocation.Text = folderDialogResult.SelectedPath.ToString();
            Properties.Settings.Default["saveLocation"] = folderDialogResult.SelectedPath.ToString();

        }

        private async void buttonDownload_Click(object sender, EventArgs e) {
            if (checkBoxOpenUrlsOnly.Checked) {
                var openURLs = MessageBox.Show($"Are you sure you want to open {checkedListBoxPlugins.CheckedItems.Count} links in your default browser??", $"Open Links in Browser", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                foreach (var item in checkedListBoxPlugins.CheckedItems) {
                    var searchItem = (parsedJson.SelectToken($"$.plugins[?(@.name=='{item}')]"));
                    string URL = (searchItem != null) ? searchItem["url"].ToString() : "";
                    if (string.IsNullOrEmpty(URL)) {
                        SetLoggingText($"No URL found for {item}! Go bother Andi to fix his shit!", false, true);
                        continue;
                    }
                    try {
                        System.Diagnostics.Process.Start(new ProcessStartInfo(URL) { UseShellExecute = true });
                    } catch (System.ComponentModel.Win32Exception noBrowser) {
                        if (noBrowser.ErrorCode == -2147467259) {
                            SetLoggingText(noBrowser.Message, false, true);
                        }
                    } catch (System.Exception other) {
                        SetLoggingText(other.Message, false, true);
                    }
                }
                return;
            }

            SetLoggingText("Checking if Download Directory exists", true, true);
            var directoryPath = Path.Combine(textBoxSaveLocation.Text, "Downloads");

            if (!Directory.Exists(directoryPath)) {
                SetLoggingText("Download Directory does not exist. Creating!", true, true);
                Directory.CreateDirectory(directoryPath);
            }

            SetLoggingText("Checking for Content in Download Directory", true, true);
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
            var files = directoryInfo.GetFiles();
            if (files.Length > 0) {
                SetLoggingText("Files found, Deleting!", false, true);
                foreach (FileInfo file in files) {
                    file.Delete();
                }
            }

            var directories = directoryInfo.GetDirectories();
            if (directories.Length > 0) {
                SetLoggingText("Folders found. Deleting!", false, true);
                foreach (DirectoryInfo directory in directories) {
                    directory.Delete(true);
                }
            }

            HttpClient downloadClient = new HttpClient();
            foreach (var item in checkedListBoxPlugins.CheckedItems) {
                SetLoggingText($"Please wait!\r\nDownloading: {item}", true, true);
                var searchItem = parsedJson.SelectToken($"$.plugins[?(@.name=='{item}')]");
                string fileURL = searchItem["downloads"]["windows"].ToString();

                if (string.IsNullOrEmpty(fileURL)) {
                    SetLoggingText($"No download URL found for {item}! Go bother Andi to fix it!");
                    continue;
                }

                var downloadURL = new System.Uri(fileURL);

                HttpResponseMessage downloadResponse = await downloadClient.GetAsync(downloadURL);

                if (!downloadResponse.IsSuccessStatusCode) {
                    return;
                }

                HttpContent downloadContent = downloadResponse.Content;

                string fileName = fileURL.Split(@"/").Last().ToString();

                if (!(fileName.Contains(".zip"))) {
                    if (downloadContent.Headers.ContentDisposition != null && downloadContent.Headers.ContentDisposition.FileName != null) {
                        fileName = downloadContent.Headers.ContentDisposition.FileName.Trim(new char[] { '"' });
                    } else {
                        MessageBox.Show($"Cannot download {item}. Please make a screenshot of this and post it in the StreamUP Discord");
                        continue;
                    }
                }
                var downloadContentStream = await downloadContent.ReadAsStreamAsync();
                var filePath = Path.Combine(directoryPath, fileName);
                using var downloadFile = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
                downloadContentStream.CopyTo(downloadFile);
                downloadFile.Close();
            }

            if (checkBoxUnzip.Checked) {
                UnzipFiles(directoryPath);
            } else {
                buttonUnZIP.Enabled = true;
            }

            SetLoggingText("Done!", true, true);

            string finalText = @"---------------
All plugins should be downloaded and extracted.
You can click the button 'Open download folder' to open the directory with the proper files in it.
The folder that has been created is called 'obs-studio' and you can OVERWRITE your own obs-studio folder.
This will make sure that you have the latest plugins installed in your obs-studio folder.

If there are any other files in the downloads folder like 7z, EXE or MSI files you need to install or extract those yourself to your 'obs-studio' folder.

Thank you for using the Pluginstaller by StreamUP";

            SetLoggingText(finalText, false, true);
        }

        private void SetLabelStatus(string statusText, bool visible = true) {
            if (statusText != null) {
                labelStatus.Text = statusText;
            }
            labelStatus.Visible = visible;
            return;
        }

        private void buttonExpand_Click(object sender, EventArgs e) {
            ClearSettings();
        }

        private void SetLoggingText(string text, bool label = false, bool textbox = false) {
            if (label) {
                SetLabelStatus(text);
            }

            if (textbox) {
                string textboxText = text.Replace("Please wait!\r\n", "");
                SetTextboxLogging(textboxText);
            }

            return;
        }

        private void SetTextboxLogging(string text) {
            textBoxLogging.AppendText($"{text}\r\n");
            return;
        }

        private void checkBoxOpenUrlsOnly_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxOpenUrlsOnly.Checked) {
                checkBoxUnzip.Checked = false;
                checkBoxUnzip.Enabled = false;
                buttonDownload.Text = $"Open URLs";
            } else {
                checkBoxUnzip.Enabled = true;
                buttonDownload.Text = buttonDownloadDefaultText;
            }
            return;
        }

        private void UnzipFiles(string directoryPath) {
            SetLoggingText($"Unzipping files in {directoryPath}", false, true);

            var zipFiles = Directory.GetFiles(directoryPath, "*.zip");
            string extractPath = directoryPath;

            foreach (var zipFile in zipFiles) {
                string zipFileName = zipFile.Split(@"\").Last();
                SetLoggingText($"Extracting {zipFileName}", false, true);
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
                    SetLoggingText($"Moving {fileName} to plugin folder", false, true);
                    var filesAndFolders = Directory.GetFiles(extractPath);
                    foreach (var item in filesAndFolders) {
                        fileName = item.Split(@"\").Last();
                        File.Move(item, Path.Combine(directoryPath, fileName));
                    }
                    Directory.Delete(extractPath, true);
                } else if (extractPath.Contains("obs-text-slideshow") || extractPath.Contains("obs-toolbar")) {
                    var filesAndFolders = Directory.GetFiles(extractPath);
                    SetLoggingText($"Moving {fileName} to plugin folder", false, true);
                    foreach (var item in filesAndFolders) {
                        fileName = item.Split(@"\").Last();
                        string obsPluginsFolder = Path.Combine(extractOBSPath, @"obs-plugins\64bit");
                        File.Move(item, Path.Combine(obsPluginsFolder, fileName));
                    }
                    Directory.Delete(extractPath, true);
                } else if (extractPath.Contains("obs-gstreamer")) {
                    var filesAndFolders = Directory.GetFiles(extractPath, "*", SearchOption.AllDirectories);
                    SetLoggingText($"Moving {fileName} to plugin folder", false, true);
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
                    SetLoggingText($"Moving {fileName} to plugin folder", false, true);
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
            try {
                System.Diagnostics.Process.Start("explorer.exe", Path.Combine(textBoxSaveLocation.Text, "Downloads"));
            } catch (System.Exception other) {
                SetLoggingText(other.Message, false, true);
            }
        }

        private void checkBoxUnzip_CheckedChanged(object sender, EventArgs e) {
            Properties.Settings.Default["unzipFiles"] = checkBoxUnzip.Checked;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.Save();
        }

        private void buttonUnZIP_Click(object sender, EventArgs e) {
            var directoryPath = Path.Combine(textBoxSaveLocation.Text, "Downloads");
            UnzipFiles(directoryPath);
        }
    }

    class Plugin {
        public string? Name { get; set; }
        public string? Uri { get; set; }
        public string? version { get; set; }
    }
}

