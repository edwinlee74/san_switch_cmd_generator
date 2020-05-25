namespace generate_sw_cmd
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.source_file_btn = new System.Windows.Forms.Button();
            this.generate_cmd_btn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.alias_Page1 = new System.Windows.Forms.TabPage();
            this.alias_comboBox = new System.Windows.Forms.ComboBox();
            this.alias_member_del_btn = new System.Windows.Forms.Button();
            this.alias_member_add_btn = new System.Windows.Forms.Button();
            this.alias_create_btn = new System.Windows.Forms.Button();
            this.alias_textBox = new System.Windows.Forms.TextBox();
            this.alias_member_list = new System.Windows.Forms.ListBox();
            this.show_wwpn_list = new System.Windows.Forms.ListBox();
            this.zone_Page = new System.Windows.Forms.TabPage();
            this.zone_comboBox = new System.Windows.Forms.ComboBox();
            this.zone_member_del_btn = new System.Windows.Forms.Button();
            this.zone_member_add_btn = new System.Windows.Forms.Button();
            this.zone_create_btn = new System.Windows.Forms.Button();
            this.zone_textBox = new System.Windows.Forms.TextBox();
            this.zone_member_list = new System.Windows.Forms.ListBox();
            this.show_alias_list = new System.Windows.Forms.ListBox();
            this.config_Page = new System.Windows.Forms.TabPage();
            this.config_comboBox = new System.Windows.Forms.ComboBox();
            this.config_member_del_btn = new System.Windows.Forms.Button();
            this.config_member_add_btn = new System.Windows.Forms.Button();
            this.config_create_btn = new System.Windows.Forms.Button();
            this.config_textBox = new System.Windows.Forms.TextBox();
            this.config_member_list = new System.Windows.Forms.ListBox();
            this.show_zone_list = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.alias_Page1.SuspendLayout();
            this.zone_Page.SuspendLayout();
            this.config_Page.SuspendLayout();
            this.SuspendLayout();
            // 
            // source_file_btn
            // 
            this.source_file_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.source_file_btn.Location = new System.Drawing.Point(28, 684);
            this.source_file_btn.Name = "source_file_btn";
            this.source_file_btn.Size = new System.Drawing.Size(153, 57);
            this.source_file_btn.TabIndex = 1;
            this.source_file_btn.Text = "選擇來源檔案";
            this.source_file_btn.UseVisualStyleBackColor = false;
            this.source_file_btn.Click += new System.EventHandler(this.source_file_btn_Click);
            // 
            // generate_cmd_btn
            // 
            this.generate_cmd_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.generate_cmd_btn.Location = new System.Drawing.Point(221, 684);
            this.generate_cmd_btn.Name = "generate_cmd_btn";
            this.generate_cmd_btn.Size = new System.Drawing.Size(153, 57);
            this.generate_cmd_btn.TabIndex = 2;
            this.generate_cmd_btn.Text = "命令檔生成";
            this.generate_cmd_btn.UseVisualStyleBackColor = false;
            this.generate_cmd_btn.Click += new System.EventHandler(this.generate_cmd_btn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.alias_Page1);
            this.tabControl1.Controls.Add(this.zone_Page);
            this.tabControl1.Controls.Add(this.config_Page);
            this.tabControl1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1384, 663);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // alias_Page1
            // 
            this.alias_Page1.BackColor = System.Drawing.Color.DarkGray;
            this.alias_Page1.Controls.Add(this.alias_comboBox);
            this.alias_Page1.Controls.Add(this.alias_member_del_btn);
            this.alias_Page1.Controls.Add(this.alias_member_add_btn);
            this.alias_Page1.Controls.Add(this.alias_create_btn);
            this.alias_Page1.Controls.Add(this.alias_textBox);
            this.alias_Page1.Controls.Add(this.alias_member_list);
            this.alias_Page1.Controls.Add(this.show_wwpn_list);
            this.alias_Page1.ForeColor = System.Drawing.Color.Black;
            this.alias_Page1.Location = new System.Drawing.Point(4, 38);
            this.alias_Page1.Name = "alias_Page1";
            this.alias_Page1.Padding = new System.Windows.Forms.Padding(3);
            this.alias_Page1.Size = new System.Drawing.Size(1376, 621);
            this.alias_Page1.TabIndex = 0;
            this.alias_Page1.Text = "alias";
            // 
            // alias_comboBox
            // 
            this.alias_comboBox.BackColor = System.Drawing.SystemColors.Info;
            this.alias_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alias_comboBox.FormattingEnabled = true;
            this.alias_comboBox.Location = new System.Drawing.Point(681, 24);
            this.alias_comboBox.Name = "alias_comboBox";
            this.alias_comboBox.Size = new System.Drawing.Size(379, 36);
            this.alias_comboBox.TabIndex = 11;
            this.alias_comboBox.Tag = "";
            this.alias_comboBox.Visible = false;
            this.alias_comboBox.SelectedIndexChanged += new System.EventHandler(this.alias_select_change);
            // 
            // alias_member_del_btn
            // 
            this.alias_member_del_btn.BackColor = System.Drawing.Color.LightCoral;
            this.alias_member_del_btn.Location = new System.Drawing.Point(406, 325);
            this.alias_member_del_btn.Name = "alias_member_del_btn";
            this.alias_member_del_btn.Size = new System.Drawing.Size(252, 70);
            this.alias_member_del_btn.TabIndex = 10;
            this.alias_member_del_btn.Text = "<=成員退出";
            this.alias_member_del_btn.UseVisualStyleBackColor = false;
            this.alias_member_del_btn.Visible = false;
            this.alias_member_del_btn.Click += new System.EventHandler(this.alias_member_del_btn_Click);
            // 
            // alias_member_add_btn
            // 
            this.alias_member_add_btn.BackColor = System.Drawing.Color.LightCoral;
            this.alias_member_add_btn.Location = new System.Drawing.Point(406, 213);
            this.alias_member_add_btn.Name = "alias_member_add_btn";
            this.alias_member_add_btn.Size = new System.Drawing.Size(252, 70);
            this.alias_member_add_btn.TabIndex = 9;
            this.alias_member_add_btn.Text = "成員選取=>";
            this.alias_member_add_btn.UseVisualStyleBackColor = false;
            this.alias_member_add_btn.Visible = false;
            this.alias_member_add_btn.Click += new System.EventHandler(this.alias_member_add_btn_Click);
            // 
            // alias_create_btn
            // 
            this.alias_create_btn.BackColor = System.Drawing.Color.MistyRose;
            this.alias_create_btn.Location = new System.Drawing.Point(422, 6);
            this.alias_create_btn.Name = "alias_create_btn";
            this.alias_create_btn.Size = new System.Drawing.Size(209, 54);
            this.alias_create_btn.TabIndex = 8;
            this.alias_create_btn.Text = "alias名稱建立";
            this.alias_create_btn.UseVisualStyleBackColor = false;
            this.alias_create_btn.Click += new System.EventHandler(this.alias_create_btn_Click);
            // 
            // alias_textBox
            // 
            this.alias_textBox.Location = new System.Drawing.Point(6, 19);
            this.alias_textBox.Name = "alias_textBox";
            this.alias_textBox.Size = new System.Drawing.Size(410, 41);
            this.alias_textBox.TabIndex = 7;
            // 
            // alias_member_list
            // 
            this.alias_member_list.FormattingEnabled = true;
            this.alias_member_list.ItemHeight = 28;
            this.alias_member_list.Location = new System.Drawing.Point(681, 79);
            this.alias_member_list.Name = "alias_member_list";
            this.alias_member_list.Size = new System.Drawing.Size(379, 536);
            this.alias_member_list.TabIndex = 6;
            this.alias_member_list.Visible = false;
            // 
            // show_wwpn_list
            // 
            this.show_wwpn_list.FormattingEnabled = true;
            this.show_wwpn_list.ItemHeight = 28;
            this.show_wwpn_list.Location = new System.Drawing.Point(6, 79);
            this.show_wwpn_list.Name = "show_wwpn_list";
            this.show_wwpn_list.Size = new System.Drawing.Size(379, 536);
            this.show_wwpn_list.TabIndex = 5;
            // 
            // zone_Page
            // 
            this.zone_Page.BackColor = System.Drawing.Color.DarkGray;
            this.zone_Page.Controls.Add(this.zone_comboBox);
            this.zone_Page.Controls.Add(this.zone_member_del_btn);
            this.zone_Page.Controls.Add(this.zone_member_add_btn);
            this.zone_Page.Controls.Add(this.zone_create_btn);
            this.zone_Page.Controls.Add(this.zone_textBox);
            this.zone_Page.Controls.Add(this.zone_member_list);
            this.zone_Page.Controls.Add(this.show_alias_list);
            this.zone_Page.ForeColor = System.Drawing.Color.Black;
            this.zone_Page.Location = new System.Drawing.Point(4, 38);
            this.zone_Page.Name = "zone_Page";
            this.zone_Page.Padding = new System.Windows.Forms.Padding(3);
            this.zone_Page.Size = new System.Drawing.Size(1376, 621);
            this.zone_Page.TabIndex = 1;
            this.zone_Page.Text = "zone";
            // 
            // zone_comboBox
            // 
            this.zone_comboBox.BackColor = System.Drawing.SystemColors.Info;
            this.zone_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zone_comboBox.FormattingEnabled = true;
            this.zone_comboBox.Location = new System.Drawing.Point(683, 24);
            this.zone_comboBox.Name = "zone_comboBox";
            this.zone_comboBox.Size = new System.Drawing.Size(379, 36);
            this.zone_comboBox.TabIndex = 18;
            this.zone_comboBox.Tag = "";
            this.zone_comboBox.Visible = false;
            this.zone_comboBox.SelectedIndexChanged += new System.EventHandler(this.zone_select_change);
            // 
            // zone_member_del_btn
            // 
            this.zone_member_del_btn.BackColor = System.Drawing.Color.LightCoral;
            this.zone_member_del_btn.Location = new System.Drawing.Point(408, 325);
            this.zone_member_del_btn.Name = "zone_member_del_btn";
            this.zone_member_del_btn.Size = new System.Drawing.Size(252, 70);
            this.zone_member_del_btn.TabIndex = 17;
            this.zone_member_del_btn.Text = "<=成員退出";
            this.zone_member_del_btn.UseVisualStyleBackColor = false;
            this.zone_member_del_btn.Visible = false;
            this.zone_member_del_btn.Click += new System.EventHandler(this.zone_member_del_btn_Click);
            // 
            // zone_member_add_btn
            // 
            this.zone_member_add_btn.BackColor = System.Drawing.Color.LightCoral;
            this.zone_member_add_btn.Location = new System.Drawing.Point(408, 213);
            this.zone_member_add_btn.Name = "zone_member_add_btn";
            this.zone_member_add_btn.Size = new System.Drawing.Size(252, 70);
            this.zone_member_add_btn.TabIndex = 16;
            this.zone_member_add_btn.Text = "成員選取=>";
            this.zone_member_add_btn.UseVisualStyleBackColor = false;
            this.zone_member_add_btn.Visible = false;
            this.zone_member_add_btn.Click += new System.EventHandler(this.zone_member_add_btn_Click);
            // 
            // zone_create_btn
            // 
            this.zone_create_btn.BackColor = System.Drawing.Color.MistyRose;
            this.zone_create_btn.Location = new System.Drawing.Point(422, 6);
            this.zone_create_btn.Name = "zone_create_btn";
            this.zone_create_btn.Size = new System.Drawing.Size(209, 54);
            this.zone_create_btn.TabIndex = 15;
            this.zone_create_btn.Text = "zone名稱建立";
            this.zone_create_btn.UseVisualStyleBackColor = false;
            this.zone_create_btn.Click += new System.EventHandler(this.zone_create_btn_Click);
            // 
            // zone_textBox
            // 
            this.zone_textBox.Location = new System.Drawing.Point(6, 19);
            this.zone_textBox.Name = "zone_textBox";
            this.zone_textBox.Size = new System.Drawing.Size(410, 41);
            this.zone_textBox.TabIndex = 14;
            // 
            // zone_member_list
            // 
            this.zone_member_list.FormattingEnabled = true;
            this.zone_member_list.ItemHeight = 28;
            this.zone_member_list.Location = new System.Drawing.Point(683, 79);
            this.zone_member_list.Name = "zone_member_list";
            this.zone_member_list.Size = new System.Drawing.Size(379, 536);
            this.zone_member_list.TabIndex = 13;
            this.zone_member_list.Visible = false;
            // 
            // show_alias_list
            // 
            this.show_alias_list.FormattingEnabled = true;
            this.show_alias_list.ItemHeight = 28;
            this.show_alias_list.Location = new System.Drawing.Point(6, 79);
            this.show_alias_list.Name = "show_alias_list";
            this.show_alias_list.Size = new System.Drawing.Size(379, 536);
            this.show_alias_list.TabIndex = 12;
            // 
            // config_Page
            // 
            this.config_Page.BackColor = System.Drawing.Color.DarkGray;
            this.config_Page.Controls.Add(this.config_comboBox);
            this.config_Page.Controls.Add(this.config_member_del_btn);
            this.config_Page.Controls.Add(this.config_member_add_btn);
            this.config_Page.Controls.Add(this.config_create_btn);
            this.config_Page.Controls.Add(this.config_textBox);
            this.config_Page.Controls.Add(this.config_member_list);
            this.config_Page.Controls.Add(this.show_zone_list);
            this.config_Page.ForeColor = System.Drawing.Color.Black;
            this.config_Page.Location = new System.Drawing.Point(4, 38);
            this.config_Page.Name = "config_Page";
            this.config_Page.Padding = new System.Windows.Forms.Padding(3);
            this.config_Page.Size = new System.Drawing.Size(1376, 621);
            this.config_Page.TabIndex = 2;
            this.config_Page.Text = "config";
            // 
            // config_comboBox
            // 
            this.config_comboBox.BackColor = System.Drawing.SystemColors.Info;
            this.config_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.config_comboBox.FormattingEnabled = true;
            this.config_comboBox.Location = new System.Drawing.Point(681, 24);
            this.config_comboBox.Name = "config_comboBox";
            this.config_comboBox.Size = new System.Drawing.Size(379, 36);
            this.config_comboBox.TabIndex = 18;
            this.config_comboBox.Tag = "";
            this.config_comboBox.Visible = false;
            this.config_comboBox.SelectedIndexChanged += new System.EventHandler(this.config_select_change);
            // 
            // config_member_del_btn
            // 
            this.config_member_del_btn.BackColor = System.Drawing.Color.LightCoral;
            this.config_member_del_btn.Location = new System.Drawing.Point(406, 325);
            this.config_member_del_btn.Name = "config_member_del_btn";
            this.config_member_del_btn.Size = new System.Drawing.Size(252, 70);
            this.config_member_del_btn.TabIndex = 17;
            this.config_member_del_btn.Text = "<=成員退出";
            this.config_member_del_btn.UseVisualStyleBackColor = false;
            this.config_member_del_btn.Visible = false;
            this.config_member_del_btn.Click += new System.EventHandler(this.config_member_del_btn_Click);
            // 
            // config_member_add_btn
            // 
            this.config_member_add_btn.BackColor = System.Drawing.Color.LightCoral;
            this.config_member_add_btn.Location = new System.Drawing.Point(406, 213);
            this.config_member_add_btn.Name = "config_member_add_btn";
            this.config_member_add_btn.Size = new System.Drawing.Size(252, 70);
            this.config_member_add_btn.TabIndex = 16;
            this.config_member_add_btn.Text = "成員選取=>";
            this.config_member_add_btn.UseVisualStyleBackColor = false;
            this.config_member_add_btn.Visible = false;
            this.config_member_add_btn.Click += new System.EventHandler(this.config_member_add_btn_Click);
            // 
            // config_create_btn
            // 
            this.config_create_btn.BackColor = System.Drawing.Color.MistyRose;
            this.config_create_btn.Location = new System.Drawing.Point(422, 6);
            this.config_create_btn.Name = "config_create_btn";
            this.config_create_btn.Size = new System.Drawing.Size(225, 54);
            this.config_create_btn.TabIndex = 15;
            this.config_create_btn.Text = "config名稱建立";
            this.config_create_btn.UseVisualStyleBackColor = false;
            this.config_create_btn.Click += new System.EventHandler(this.config_create_btn_Click);
            // 
            // config_textBox
            // 
            this.config_textBox.Location = new System.Drawing.Point(6, 19);
            this.config_textBox.Name = "config_textBox";
            this.config_textBox.Size = new System.Drawing.Size(410, 41);
            this.config_textBox.TabIndex = 14;
            // 
            // config_member_list
            // 
            this.config_member_list.FormattingEnabled = true;
            this.config_member_list.ItemHeight = 28;
            this.config_member_list.Location = new System.Drawing.Point(681, 79);
            this.config_member_list.Name = "config_member_list";
            this.config_member_list.Size = new System.Drawing.Size(379, 536);
            this.config_member_list.TabIndex = 13;
            this.config_member_list.Visible = false;
            // 
            // show_zone_list
            // 
            this.show_zone_list.FormattingEnabled = true;
            this.show_zone_list.ItemHeight = 28;
            this.show_zone_list.Location = new System.Drawing.Point(6, 79);
            this.show_zone_list.Name = "show_zone_list";
            this.show_zone_list.Size = new System.Drawing.Size(379, 536);
            this.show_zone_list.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1378, 753);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.generate_cmd_btn);
            this.Controls.Add(this.source_file_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.alias_Page1.ResumeLayout(false);
            this.alias_Page1.PerformLayout();
            this.zone_Page.ResumeLayout(false);
            this.zone_Page.PerformLayout();
            this.config_Page.ResumeLayout(false);
            this.config_Page.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button source_file_btn;
        private System.Windows.Forms.Button generate_cmd_btn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage alias_Page1;
        private System.Windows.Forms.TabPage zone_Page;
        private System.Windows.Forms.TabPage config_Page;
        private System.Windows.Forms.ListBox alias_member_list;
        private System.Windows.Forms.ListBox show_wwpn_list;
        private System.Windows.Forms.Button alias_create_btn;
        private System.Windows.Forms.TextBox alias_textBox;
        private System.Windows.Forms.ComboBox alias_comboBox;
        private System.Windows.Forms.Button alias_member_del_btn;
        private System.Windows.Forms.Button alias_member_add_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox zone_comboBox;
        private System.Windows.Forms.Button zone_member_del_btn;
        private System.Windows.Forms.Button zone_member_add_btn;
        private System.Windows.Forms.Button zone_create_btn;
        private System.Windows.Forms.TextBox zone_textBox;
        private System.Windows.Forms.ListBox zone_member_list;
        private System.Windows.Forms.ListBox show_alias_list;
        private System.Windows.Forms.ComboBox config_comboBox;
        private System.Windows.Forms.Button config_member_del_btn;
        private System.Windows.Forms.Button config_member_add_btn;
        private System.Windows.Forms.Button config_create_btn;
        private System.Windows.Forms.TextBox config_textBox;
        private System.Windows.Forms.ListBox config_member_list;
        private System.Windows.Forms.ListBox show_zone_list;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

