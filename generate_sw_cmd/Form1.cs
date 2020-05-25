using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Globalization;

namespace generate_sw_cmd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 自訂義變數
        private List<string> wwpn_list = new List<string>();
        private Dictionary<string, List<string>> alias_members =
            new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> zone_members =
            new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> config_members =
            new Dictionary<string, List<string>>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void source_file_btn_Click(object sender, EventArgs e)
        {
            show_wwpn_list.Items.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "請選擇你的World Wild Port Name 來源檔案";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                var sr = new StreamReader(ofd.FileName);

                // 建立要比對的模式
                string mystr;
                Regex pattern = new Regex(@"(?:[0-9a-fA-F]:?){16}",
                         RegexOptions.Compiled | RegexOptions.IgnoreCase);
                // 建立除外的模式
                Regex exclude_pattern = new Regex("switchWwn", RegexOptions.Compiled);
                while ((mystr = sr.ReadLine()) != null)
                {
                    if (! exclude_pattern.IsMatch(mystr))
                    {
                        MatchCollection matches = pattern.Matches(mystr);
                        foreach (Match match in matches)
                        {
                            wwpn_list.Add(match.Value);
                        }
                    }
                }
                // 將比對後的wwpn寫入清單
                foreach (string line in wwpn_list)
                {
                    show_wwpn_list.Items.Add(line);
                }
            }
        }

        private void alias_create_btn_Click(object sender, EventArgs e)
        {
            alias_member_list.Items.Clear();
            // 判斷是否在alias comboBox已有相同的值存在, 若有不重覆
            bool isInList = false;
            foreach (var i in alias_comboBox.Items)
            {
                if (alias_textBox.Text == i.ToString())
                {
                    isInList = true;
                }
                else
                {
                    isInList = false;
                }
            }
            if ( ! isInList & ! string.IsNullOrEmpty(alias_textBox.Text))
            {
                alias_comboBox.Items.Add(alias_textBox.Text);
                alias_comboBox.Text = alias_textBox.Text;
                alias_comboBox.Visible = true;
                alias_member_add_btn.Visible = true;
                alias_member_del_btn.Visible = true;
                alias_member_list.Visible = true;
            }
        }

        private void alias_member_add_btn_Click(object sender, EventArgs e)
        {
            if (show_wwpn_list.SelectedIndex > -1)
            {
                alias_member_list.Items.Add(show_wwpn_list.SelectedItem);
                show_wwpn_list.Items.Remove(show_wwpn_list.SelectedItem);
            }
            if (! string.IsNullOrEmpty(alias_comboBox.Text))
            {
                List<string> values = new List<string> { };
                foreach (string item in alias_member_list.Items)
                {
                    values.Add(item); 
                }
                alias_members.Remove(alias_comboBox.Text);
                if ( ! alias_members.ContainsKey(alias_comboBox.Text))
                {
                    alias_members.Add(alias_comboBox.Text, values);
                }
            }
        }

        private void alias_member_del_btn_Click(object sender, EventArgs e)
        {
            if(alias_member_list.SelectedIndex > -1)
            {
                show_wwpn_list.Items.Add(alias_member_list.SelectedItem);
                alias_member_list.Items.Remove(alias_member_list.SelectedItem);
            }
            if (!string.IsNullOrEmpty(alias_comboBox.Text))
            {
                List<string> values = new List<string> { };
                foreach (string item in alias_member_list.Items)
                {
                    values.Add(item);
                }
                alias_members.Remove(alias_comboBox.Text);
                if (!alias_members.ContainsKey(alias_comboBox.Text))
                {
                    alias_members.Add(alias_comboBox.Text, values);
                }
            }

        }

        private void alias_select_change(object sender, EventArgs e)
        {
            // 若alias_members已有該值, 將它顯示在alias_member_list上
            if (alias_members.ContainsKey(alias_comboBox.Text))
            {
                alias_member_list.Items.Clear();
                foreach (string item in alias_members[alias_comboBox.Text])
                {
                    alias_member_list.Items.Add(item);
                }
            }
            else
            {
                alias_member_list.Items.Clear();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                show_alias_list.Items.Clear();
                foreach(KeyValuePair<string, List<string>> item in alias_members)
                {
                    show_alias_list.Items.Add(item.Key);
                }
            }
            if (tabControl1.SelectedIndex == 2)
            {
                show_zone_list.Items.Clear();
                foreach (KeyValuePair<string, List<string>> item in zone_members)
                {
                    show_zone_list.Items.Add(item.Key);
                }
            }
        }

        private void zone_create_btn_Click(object sender, EventArgs e)
        {
            zone_member_list.Items.Clear();
            show_alias_list.Items.Clear();
            // 判斷是否在zone comboBox已有相同的值存在, 若有不重覆
            bool isInList = false;
            foreach (var i in zone_comboBox.Items)
            {
                if (zone_textBox.Text == i.ToString())
                {
                    isInList = true;
                }
                else
                {
                    isInList = false;
                }
            }
            if (!isInList & !string.IsNullOrEmpty(zone_textBox.Text))
            {
                zone_comboBox.Items.Add(zone_textBox.Text);
                zone_comboBox.Text = zone_textBox.Text;
                zone_comboBox.Visible = true;
                zone_member_add_btn.Visible = true;
                zone_member_del_btn.Visible = true;
                zone_member_list.Visible = true;
            }
        }

        private void zone_member_add_btn_Click(object sender, EventArgs e)
        {
            if (show_alias_list.SelectedIndex > -1)
            {
                zone_member_list.Items.Add(show_alias_list.SelectedItem);
                show_alias_list.Items.Remove(show_alias_list.SelectedItem);
            }
            if (!string.IsNullOrEmpty(zone_comboBox.Text))
            {
                List<string> values = new List<string> { };
                foreach (string item in zone_member_list.Items)
                {
                    values.Add(item);
                }
                zone_members.Remove(zone_comboBox.Text);
                if (!zone_members.ContainsKey(zone_comboBox.Text))
                {
                    zone_members.Add(zone_comboBox.Text, values);
                }
            }
        }

        private void zone_member_del_btn_Click(object sender, EventArgs e)
        {
            if (zone_member_list.SelectedIndex > -1)
            {
                show_alias_list.Items.Add(zone_member_list.SelectedItem);
                zone_member_list.Items.Remove(zone_member_list.SelectedItem);
            }
            if (!string.IsNullOrEmpty(zone_comboBox.Text))
            {
                List<string> values = new List<string> { };
                foreach (string item in zone_member_list.Items)
                {
                    values.Add(item);
                }
                zone_members.Remove(zone_comboBox.Text);
                zone_members.Add(zone_comboBox.Text, values);
            }
        }

        private void zone_select_change(object sender, EventArgs e)
        {
            // 若zone_members已有該值, 將它顯示在zone_member_list上
            zone_member_list.Items.Clear();
            show_alias_list.Items.Clear();
            foreach (KeyValuePair<string, List<string>> item in alias_members)
            {
                show_alias_list.Items.Add(item.Key);
            }
            if (zone_members.ContainsKey(zone_comboBox.Text))
            {
                foreach (string item in zone_members[zone_comboBox.Text])
                {
                    zone_member_list.Items.Add(item);
                    show_alias_list.Items.Remove(item);
                }
            }
        }

        private void config_create_btn_Click(object sender, EventArgs e)
        {
            config_member_list.Items.Clear();
            show_zone_list.Items.Clear();
            // 判斷是否在config comboBox已有相同的值存在, 若有不重覆
            bool isInList = false;
            foreach (var i in config_comboBox.Items)
            {
                if (config_textBox.Text == i.ToString())
                {
                    isInList = true;
                }
                else
                {
                    isInList = false;
                }
            }
            if (!isInList & !string.IsNullOrEmpty(config_textBox.Text))
            {
                config_comboBox.Items.Add(config_textBox.Text);
                config_comboBox.Text = config_textBox.Text;
                config_comboBox.Visible = true;
                config_member_add_btn.Visible = true;
                config_member_del_btn.Visible = true;
                config_member_list.Visible = true;
            }
        }

        private void config_select_change(object sender, EventArgs e)
        {
            // 若config_members已有該值, 將它顯示在config_member_list上
            config_member_list.Items.Clear();
            show_zone_list.Items.Clear();
            foreach (KeyValuePair<string, List<string>> item in zone_members)
            {
                show_zone_list.Items.Add(item.Key);
            }
            if (config_members.ContainsKey(config_comboBox.Text))
            {
                foreach (string item in config_members[config_comboBox.Text])
                {
                    config_member_list.Items.Add(item);
                    show_zone_list.Items.Remove(item);
                }
            }
        }

        private void config_member_add_btn_Click(object sender, EventArgs e)
        {
            if (show_zone_list.SelectedIndex > -1)
            {
                config_member_list.Items.Add(show_zone_list.SelectedItem);
                show_zone_list.Items.Remove(show_zone_list.SelectedItem);
            }
            if (!string.IsNullOrEmpty(config_comboBox.Text))
            {
                List<string> values = new List<string> { };
                foreach (string item in config_member_list.Items)
                {
                    values.Add(item);
                }
                config_members.Remove(config_comboBox.Text);
                if (!config_members.ContainsKey(config_comboBox.Text))
                {
                    config_members.Add(config_comboBox.Text, values);
                }
            }
        }

        private void config_member_del_btn_Click(object sender, EventArgs e)
        {
            if (config_member_list.SelectedIndex > -1)
            {
                show_zone_list.Items.Add(config_member_list.SelectedItem);
                config_member_list.Items.Remove(config_member_list.SelectedItem);
            }
            if (!string.IsNullOrEmpty(config_comboBox.Text))
            {
                List<string> values = new List<string> { };
                foreach (string item in config_member_list.Items)
                {
                    values.Add(item);
                }
                config_members.Remove(config_comboBox.Text);
                config_members.Add(config_comboBox.Text, values);
            }
        }

        private void generate_cmd_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.Title = "請選擇你要存檔位置";
            sfd.FileName = "generate_cmd";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
               using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    // 取出alias的key, value並產生switch 的command
                    foreach (KeyValuePair<string, List<string>> item in alias_members)
                    {
                        string member = "";
                        string sw_cmd = "";
                        foreach(string i in item.Value)
                        {
                            member += i + ";";
                        }
                        sw_cmd = $"alicreate \"{item.Key}\", \"{member.Trim(';')}\"";
                        sw.WriteLineAsync(sw_cmd + "\n");
                    }
                    // 取出zone的key, value並產生switch 的command
                    foreach (KeyValuePair<string, List<string>> item in zone_members)
                    {
                        string member = "";
                        string sw_cmd = "";
                        foreach (string i in item.Value)
                        {
                            member += i + ";";
                        }
                        sw_cmd = $"zonecreate \"{item.Key}\", \"{member.Trim(';')}\"";
                        sw.WriteLineAsync(sw_cmd + "\n");
                    }
                    // 取出config的key, value並產生switch 的command
                    foreach (KeyValuePair<string, List<string>> item in config_members)
                    {
                        string member = "";
                        string sw_cmd = "";
                        foreach (string i in item.Value)
                        {
                            member += i + ";";
                        }
                        sw_cmd = $"cfgcreate \"{item.Key}\", \"{member.Trim(';')}\"";
                        sw.WriteLineAsync(sw_cmd + "\n");
                    }
                    sw.Close();     
                }            
            }

        }
    }
}
