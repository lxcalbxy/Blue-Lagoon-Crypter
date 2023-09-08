namespace Blue_Lagoon_Crypter__Windowed_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_select_server = new System.Windows.Forms.Button();
            this.server_path = new System.Windows.Forms.TextBox();
            this.button_select_icon = new System.Windows.Forms.Button();
            this.icon_path = new System.Windows.Forms.TextBox();
            this.windowPanel = new System.Windows.Forms.Panel();
            this.help_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.windowName = new System.Windows.Forms.Label();
            this.server_path_label = new System.Windows.Forms.Label();
            this.icon_path_label = new System.Windows.Forms.Label();
            this.button_build = new System.Windows.Forms.Button();
            this.key_gen_label = new System.Windows.Forms.Label();
            this.keyGenBox = new System.Windows.Forms.TextBox();
            this.genKey = new System.Windows.Forms.Button();
            this.IV_gen_label = new System.Windows.Forms.Label();
            this.genIvBox = new System.Windows.Forms.TextBox();
            this.genIV = new System.Windows.Forms.Button();
            this.buildHighlight = new System.Windows.Forms.Panel();
            this.windowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_select_server
            // 
            this.button_select_server.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_select_server.Font = new System.Drawing.Font("Anita  Semi-square", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_select_server.ForeColor = System.Drawing.Color.White;
            this.button_select_server.Location = new System.Drawing.Point(459, 83);
            this.button_select_server.Name = "button_select_server";
            this.button_select_server.Size = new System.Drawing.Size(146, 33);
            this.button_select_server.TabIndex = 0;
            this.button_select_server.Text = "Select";
            this.button_select_server.UseVisualStyleBackColor = true;
            this.button_select_server.Click += new System.EventHandler(this.button_select_server_Click);
            this.button_select_server.MouseEnter += new System.EventHandler(this.mouseEnterPayload);
            this.button_select_server.MouseLeave += new System.EventHandler(this.mouseLeaverPayload);
            // 
            // server_path
            // 
            this.server_path.Font = new System.Drawing.Font("Anita  Semi-square", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server_path.Location = new System.Drawing.Point(200, 83);
            this.server_path.MinimumSize = new System.Drawing.Size(4, 33);
            this.server_path.Name = "server_path";
            this.server_path.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.server_path.Size = new System.Drawing.Size(225, 25);
            this.server_path.TabIndex = 1;
            this.server_path.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.server_path.WordWrap = false;
            this.server_path.TextChanged += new System.EventHandler(this.server_path_TextChanged);
            // 
            // button_select_icon
            // 
            this.button_select_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_select_icon.Font = new System.Drawing.Font("Anita  Semi-square", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_select_icon.ForeColor = System.Drawing.Color.White;
            this.button_select_icon.Location = new System.Drawing.Point(459, 147);
            this.button_select_icon.Name = "button_select_icon";
            this.button_select_icon.Size = new System.Drawing.Size(146, 33);
            this.button_select_icon.TabIndex = 0;
            this.button_select_icon.Text = "Select";
            this.button_select_icon.UseVisualStyleBackColor = true;
            this.button_select_icon.Click += new System.EventHandler(this.button_select_icon_Click);
            this.button_select_icon.MouseEnter += new System.EventHandler(this.mouseEnterIcon);
            this.button_select_icon.MouseLeave += new System.EventHandler(this.mouseLeaveIcon);
            // 
            // icon_path
            // 
            this.icon_path.Font = new System.Drawing.Font("Anita  Semi-square", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icon_path.Location = new System.Drawing.Point(200, 147);
            this.icon_path.MinimumSize = new System.Drawing.Size(4, 33);
            this.icon_path.Name = "icon_path";
            this.icon_path.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.icon_path.Size = new System.Drawing.Size(225, 25);
            this.icon_path.TabIndex = 1;
            this.icon_path.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // windowPanel
            // 
            this.windowPanel.BackColor = System.Drawing.Color.Aqua;
            this.windowPanel.Controls.Add(this.help_button);
            this.windowPanel.Controls.Add(this.exit_button);
            this.windowPanel.Controls.Add(this.windowName);
            this.windowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowPanel.Location = new System.Drawing.Point(0, 0);
            this.windowPanel.Name = "windowPanel";
            this.windowPanel.Size = new System.Drawing.Size(761, 41);
            this.windowPanel.TabIndex = 2;
            this.windowPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            // 
            // help_button
            // 
            this.help_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_button.Font = new System.Drawing.Font("Crafter", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_button.ForeColor = System.Drawing.Color.Black;
            this.help_button.Location = new System.Drawing.Point(672, 5);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(39, 31);
            this.help_button.TabIndex = 11;
            this.help_button.Text = "?";
            this.help_button.UseVisualStyleBackColor = true;
            this.help_button.Click += new System.EventHandler(this.mouseClickHelp);
            this.help_button.MouseEnter += new System.EventHandler(this.mouseEnterHelp);
            this.help_button.MouseLeave += new System.EventHandler(this.mouseLeaveHelp);
            // 
            // exit_button
            // 
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Crafter", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(717, 5);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(39, 31);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.button1_Click);
            this.exit_button.MouseEnter += new System.EventHandler(this.mouseEnterExit);
            this.exit_button.MouseLeave += new System.EventHandler(this.mouseLeaveExit);
            // 
            // windowName
            // 
            this.windowName.AutoSize = true;
            this.windowName.BackColor = System.Drawing.Color.Transparent;
            this.windowName.Font = new System.Drawing.Font("Blade 2", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowName.ForeColor = System.Drawing.Color.Black;
            this.windowName.Location = new System.Drawing.Point(-4, -3);
            this.windowName.Name = "windowName";
            this.windowName.Size = new System.Drawing.Size(491, 49);
            this.windowName.TabIndex = 3;
            this.windowName.Text = "Blue Lagoon Crypt (WIP)";
            this.windowName.Click += new System.EventHandler(this.label3_Click);
            // 
            // server_path_label
            // 
            this.server_path_label.AutoSize = true;
            this.server_path_label.Font = new System.Drawing.Font("Anita  Semi-square", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server_path_label.ForeColor = System.Drawing.Color.White;
            this.server_path_label.Location = new System.Drawing.Point(27, 84);
            this.server_path_label.Name = "server_path_label";
            this.server_path_label.Size = new System.Drawing.Size(144, 27);
            this.server_path_label.TabIndex = 3;
            this.server_path_label.Text = "Payload :";
            this.server_path_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // icon_path_label
            // 
            this.icon_path_label.AutoSize = true;
            this.icon_path_label.Font = new System.Drawing.Font("Anita  Semi-square", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icon_path_label.ForeColor = System.Drawing.Color.White;
            this.icon_path_label.Location = new System.Drawing.Point(78, 148);
            this.icon_path_label.Name = "icon_path_label";
            this.icon_path_label.Size = new System.Drawing.Size(93, 27);
            this.icon_path_label.TabIndex = 3;
            this.icon_path_label.Text = "Icon :";
            this.icon_path_label.Click += new System.EventHandler(this.icon_path_label_Click);
            // 
            // button_build
            // 
            this.button_build.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_build.Font = new System.Drawing.Font("Anita  Semi-square", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_build.ForeColor = System.Drawing.Color.White;
            this.button_build.Location = new System.Drawing.Point(200, 335);
            this.button_build.Name = "button_build";
            this.button_build.Size = new System.Drawing.Size(405, 33);
            this.button_build.TabIndex = 0;
            this.button_build.Text = "Build";
            this.button_build.UseVisualStyleBackColor = true;
            this.button_build.Click += new System.EventHandler(this.button_build_Click);
            this.button_build.MouseEnter += new System.EventHandler(this.mouseEnterBuild);
            this.button_build.MouseLeave += new System.EventHandler(this.mouseLeaveBuild);
            // 
            // key_gen_label
            // 
            this.key_gen_label.AutoSize = true;
            this.key_gen_label.Font = new System.Drawing.Font("Anita  Semi-square", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key_gen_label.ForeColor = System.Drawing.Color.White;
            this.key_gen_label.Location = new System.Drawing.Point(84, 211);
            this.key_gen_label.Name = "key_gen_label";
            this.key_gen_label.Size = new System.Drawing.Size(87, 27);
            this.key_gen_label.TabIndex = 6;
            this.key_gen_label.Text = "Key :";
            // 
            // keyGenBox
            // 
            this.keyGenBox.Font = new System.Drawing.Font("Anita  Semi-square", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyGenBox.Location = new System.Drawing.Point(200, 210);
            this.keyGenBox.MinimumSize = new System.Drawing.Size(4, 33);
            this.keyGenBox.Name = "keyGenBox";
            this.keyGenBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.keyGenBox.Size = new System.Drawing.Size(225, 25);
            this.keyGenBox.TabIndex = 5;
            this.keyGenBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // genKey
            // 
            this.genKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genKey.Font = new System.Drawing.Font("Anita  Semi-square", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genKey.ForeColor = System.Drawing.Color.White;
            this.genKey.Location = new System.Drawing.Point(459, 210);
            this.genKey.Name = "genKey";
            this.genKey.Size = new System.Drawing.Size(146, 33);
            this.genKey.TabIndex = 4;
            this.genKey.Text = "Generate";
            this.genKey.UseVisualStyleBackColor = true;
            this.genKey.Click += new System.EventHandler(this.genKey_Click);
            this.genKey.MouseEnter += new System.EventHandler(this.mouseEnterGenKey);
            this.genKey.MouseLeave += new System.EventHandler(this.mouseLeaveGenKey);
            // 
            // IV_gen_label
            // 
            this.IV_gen_label.AutoSize = true;
            this.IV_gen_label.Font = new System.Drawing.Font("Anita  Semi-square", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IV_gen_label.ForeColor = System.Drawing.Color.White;
            this.IV_gen_label.Location = new System.Drawing.Point(108, 273);
            this.IV_gen_label.Name = "IV_gen_label";
            this.IV_gen_label.Size = new System.Drawing.Size(63, 27);
            this.IV_gen_label.TabIndex = 9;
            this.IV_gen_label.Text = "IV :";
            // 
            // genIvBox
            // 
            this.genIvBox.Font = new System.Drawing.Font("Anita  Semi-square", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genIvBox.Location = new System.Drawing.Point(200, 273);
            this.genIvBox.MinimumSize = new System.Drawing.Size(4, 33);
            this.genIvBox.Name = "genIvBox";
            this.genIvBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.genIvBox.Size = new System.Drawing.Size(225, 25);
            this.genIvBox.TabIndex = 8;
            this.genIvBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // genIV
            // 
            this.genIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genIV.Font = new System.Drawing.Font("Anita  Semi-square", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genIV.ForeColor = System.Drawing.Color.White;
            this.genIV.Location = new System.Drawing.Point(459, 273);
            this.genIV.Name = "genIV";
            this.genIV.Size = new System.Drawing.Size(146, 33);
            this.genIV.TabIndex = 7;
            this.genIV.Text = "Generate";
            this.genIV.UseVisualStyleBackColor = true;
            this.genIV.Click += new System.EventHandler(this.genIV_Click);
            this.genIV.MouseEnter += new System.EventHandler(this.mouseEnterIV);
            this.genIV.MouseLeave += new System.EventHandler(this.mouseLeaveIV);
            // 
            // buildHighlight
            // 
            this.buildHighlight.BackColor = System.Drawing.Color.Black;
            this.buildHighlight.Location = new System.Drawing.Point(206, 367);
            this.buildHighlight.Name = "buildHighlight";
            this.buildHighlight.Size = new System.Drawing.Size(392, 5);
            this.buildHighlight.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(761, 411);
            this.Controls.Add(this.IV_gen_label);
            this.Controls.Add(this.genIvBox);
            this.Controls.Add(this.genIV);
            this.Controls.Add(this.key_gen_label);
            this.Controls.Add(this.keyGenBox);
            this.Controls.Add(this.genKey);
            this.Controls.Add(this.icon_path_label);
            this.Controls.Add(this.server_path_label);
            this.Controls.Add(this.windowPanel);
            this.Controls.Add(this.icon_path);
            this.Controls.Add(this.server_path);
            this.Controls.Add(this.button_select_icon);
            this.Controls.Add(this.button_build);
            this.Controls.Add(this.button_select_server);
            this.Controls.Add(this.buildHighlight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(0, 35);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.windowPanel.ResumeLayout(false);
            this.windowPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_select_server;
        private System.Windows.Forms.TextBox server_path;
        private System.Windows.Forms.Button button_select_icon;
        private System.Windows.Forms.TextBox icon_path;
        private System.Windows.Forms.Panel windowPanel;
        private System.Windows.Forms.Label server_path_label;
        private System.Windows.Forms.Label icon_path_label;
        private System.Windows.Forms.Label windowName;
        private System.Windows.Forms.Button button_build;
        private System.Windows.Forms.Label key_gen_label;
        private System.Windows.Forms.TextBox keyGenBox;
        private System.Windows.Forms.Button genKey;
        private System.Windows.Forms.Label IV_gen_label;
        private System.Windows.Forms.TextBox genIvBox;
        private System.Windows.Forms.Button genIV;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Panel buildHighlight;
        private System.Windows.Forms.Button help_button;
    }
}

