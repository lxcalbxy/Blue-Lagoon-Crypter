namespace Blue_Lagoon_Crypter__Windowed_
{
    partial class Output_Name_Text_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Output_Name_Text_Form));
            this.label_Output_Name_Text_Box = new System.Windows.Forms.Label();
            this.Enter_Output_Name_Text_Box = new System.Windows.Forms.TextBox();
            this.button_Output_Name_Text_Box = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.windowName = new System.Windows.Forms.Label();
            this.blueLagoonCryptHighlight = new System.Windows.Forms.Panel();
            this.exit_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Output_Name_Text_Box
            // 
            this.label_Output_Name_Text_Box.AutoSize = true;
            this.label_Output_Name_Text_Box.Font = new System.Drawing.Font("Anita  Semi-square", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Output_Name_Text_Box.ForeColor = System.Drawing.Color.White;
            this.label_Output_Name_Text_Box.Location = new System.Drawing.Point(123, 62);
            this.label_Output_Name_Text_Box.Name = "label_Output_Name_Text_Box";
            this.label_Output_Name_Text_Box.Size = new System.Drawing.Size(109, 27);
            this.label_Output_Name_Text_Box.TabIndex = 6;
            this.label_Output_Name_Text_Box.Text = "Name :";
            // 
            // Enter_Output_Name_Text_Box
            // 
            this.Enter_Output_Name_Text_Box.Font = new System.Drawing.Font("Anita  Semi-square", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_Output_Name_Text_Box.Location = new System.Drawing.Point(248, 62);
            this.Enter_Output_Name_Text_Box.Name = "Enter_Output_Name_Text_Box";
            this.Enter_Output_Name_Text_Box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Enter_Output_Name_Text_Box.Size = new System.Drawing.Size(380, 25);
            this.Enter_Output_Name_Text_Box.TabIndex = 5;
            this.Enter_Output_Name_Text_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Enter_Output_Name_Text_Box.WordWrap = false;
            this.Enter_Output_Name_Text_Box.TextChanged += new System.EventHandler(this.Enter_Output_Name_Text_Box_TextChanged);
            // 
            // button_Output_Name_Text_Box
            // 
            this.button_Output_Name_Text_Box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Output_Name_Text_Box.Font = new System.Drawing.Font("Anita  Semi-square", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Output_Name_Text_Box.ForeColor = System.Drawing.Color.White;
            this.button_Output_Name_Text_Box.Location = new System.Drawing.Point(248, 93);
            this.button_Output_Name_Text_Box.Name = "button_Output_Name_Text_Box";
            this.button_Output_Name_Text_Box.Size = new System.Drawing.Size(380, 33);
            this.button_Output_Name_Text_Box.TabIndex = 4;
            this.button_Output_Name_Text_Box.Text = "Save Output Name";
            this.button_Output_Name_Text_Box.UseVisualStyleBackColor = true;
            this.button_Output_Name_Text_Box.Click += new System.EventHandler(this.button_Output_Name_Text_Box_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.windowName);
            this.panel1.Controls.Add(this.blueLagoonCryptHighlight);
            this.panel1.Controls.Add(this.exit_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 41);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
            // 
            // windowName
            // 
            this.windowName.AutoSize = true;
            this.windowName.BackColor = System.Drawing.Color.Transparent;
            this.windowName.Font = new System.Drawing.Font("Blade 2", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowName.ForeColor = System.Drawing.Color.Black;
            this.windowName.Location = new System.Drawing.Point(3, 0);
            this.windowName.Name = "windowName";
            this.windowName.Size = new System.Drawing.Size(491, 49);
            this.windowName.TabIndex = 19;
            this.windowName.Text = "Blue Lagoon Crypt (WIP)";
            // 
            // blueLagoonCryptHighlight
            // 
            this.blueLagoonCryptHighlight.BackColor = System.Drawing.Color.Black;
            this.blueLagoonCryptHighlight.Location = new System.Drawing.Point(7, 45);
            this.blueLagoonCryptHighlight.Name = "blueLagoonCryptHighlight";
            this.blueLagoonCryptHighlight.Size = new System.Drawing.Size(497, 5);
            this.blueLagoonCryptHighlight.TabIndex = 20;
            // 
            // exit_button
            // 
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Crafter", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(735, 7);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(39, 31);
            this.exit_button.TabIndex = 12;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.ColseWindow);
            // 
            // Output_Name_Text_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(777, 150);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_Output_Name_Text_Box);
            this.Controls.Add(this.Enter_Output_Name_Text_Box);
            this.Controls.Add(this.button_Output_Name_Text_Box);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Output_Name_Text_Form";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blue Lagoon Crypt (Name Select) [by lxcalbxy]";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Output_Name_Text_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Output_Name_Text_Box;
        private System.Windows.Forms.TextBox Enter_Output_Name_Text_Box;
        private System.Windows.Forms.Button button_Output_Name_Text_Box;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label windowName;
        private System.Windows.Forms.Panel blueLagoonCryptHighlight;
    }
}