using Newtonsoft.Json.Linq;
using System.Linq;

namespace Streamup_Pluginstall_V2a {
    public partial class MainWindow : Form {

        Dictionary<int, Plugin> recommendedPlugins = new Dictionary<int, Plugin>();
        Dictionary<int, Plugin> requiredPlugins = new Dictionary<int, Plugin>();
        Dictionary<int, Plugin> recommendedAndRequiredPlugins = new Dictionary<int, Plugin>();
        Dictionary<int, Plugin> allPlugins = new Dictionary<int, Plugin>();

        public MainWindow() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            var client = new HttpClient();

            var result = client.GetAsync($"https://api.streamup.tips/plugins").Result;
            if (result.IsSuccessStatusCode) {
                var content = result.Content.ReadAsStringAsync().Result;
                JObject parsedJson = JObject.Parse(content);

                JArray plugins = (JArray)parsedJson["plugins"];

                int i = 0;
                int iRecommended = 0;
                int iRequired = 0;
                int iRecommendedAndRequired = 0;

                foreach (var plugin in plugins) {

                    if (plugin["name"].ToString().ToLower().Contains("inno")) { continue; }

                    allPlugins.Add(i, SetPluginData(plugin));

                    bool isRecommended = Convert.ToBoolean(plugin["recommended"].ToString());
                    bool isRequired = false; //Convert.ToBoolean(plugin["recommended"].ToString());

                    if (isRecommended && !isRequired) {
                        recommendedPlugins.Add(iRecommended, SetPluginData(plugin));
                        iRecommended++;
                    } else if (isRequired && !isRecommended) {
                        requiredPlugins.Add(iRequired, SetPluginData(plugin));
                        iRequired++;
                    } else if (isRecommended && isRequired) {
                        recommendedAndRequiredPlugins.Add(iRecommendedAndRequired, SetPluginData(plugin));
                        iRecommendedAndRequired++;
                    }
                    i++;
                }
            }

            foreach (var item in allPlugins) {
                checkedListBoxPlugins.Items.Add(item.Value.Name);
            }

            int itemIndex = 0;
            foreach (var item in recommendedPlugins) {
                itemIndex = checkedListBoxPlugins.Items.Cast<string>().ToList().IndexOf(item.Value.Name);
                if (itemIndex > -1) {
                    checkedListBoxPlugins.SetItemCheckState(itemIndex, CheckState.Checked);
                }
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

        private void radioButtonCustom_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonCustom.Checked) {
                checkedListBoxPlugins.SelectionMode = SelectionMode.One;
            } else {
                checkedListBoxPlugins.SelectionMode = SelectionMode.None;
            }
        }

        Plugin SetPluginData(JToken pluginObject) {

            Plugin plugin = new Plugin();

            plugin.Name = pluginObject["name"].ToString();
            plugin.Uri = pluginObject["downloads"]["windows"].ToString();
            plugin.version = pluginObject["version"].ToString();

            return plugin;
        }
    }

    class Plugin {
        public string Name { get; set; }
        public string Uri { get; set; }
        public string version { get; set; }
    }
}

