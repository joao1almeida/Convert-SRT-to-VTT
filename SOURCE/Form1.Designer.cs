namespace Convert_SRT_to_VTT
{
    partial class Main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.button_clean_monitor = new System.Windows.Forms.Button();
            this.button_help = new System.Windows.Forms.Button();
            this.checkCloseAtComplete = new System.Windows.Forms.CheckBox();
            this.button_convert = new System.Windows.Forms.Button();
            this.button_output = new System.Windows.Forms.Button();
            this.button_input = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboSource = new System.Windows.Forms.ComboBox();
            this.outputPathBox = new System.Windows.Forms.TextBox();
            this.inputPathBox = new System.Windows.Forms.TextBox();
            this.monitorTextBox = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.button_clean_monitor);
            this.mainPanel.Controls.Add(this.button_help);
            this.mainPanel.Controls.Add(this.checkCloseAtComplete);
            this.mainPanel.Controls.Add(this.button_convert);
            this.mainPanel.Controls.Add(this.button_output);
            this.mainPanel.Controls.Add(this.button_input);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.comboSource);
            this.mainPanel.Controls.Add(this.outputPathBox);
            this.mainPanel.Controls.Add(this.inputPathBox);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(749, 155);
            this.mainPanel.TabIndex = 0;
            // 
            // button_clean_monitor
            // 
            this.button_clean_monitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clean_monitor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button_clean_monitor.Location = new System.Drawing.Point(65, 115);
            this.button_clean_monitor.Name = "button_clean_monitor";
            this.button_clean_monitor.Size = new System.Drawing.Size(126, 23);
            this.button_clean_monitor.TabIndex = 11;
            this.button_clean_monitor.Text = "Clear monitor";
            this.button_clean_monitor.UseVisualStyleBackColor = true;
            this.button_clean_monitor.Click += new System.EventHandler(this.button_clean_monitor_Click);
            // 
            // button_help
            // 
            this.button_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_help.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button_help.Location = new System.Drawing.Point(662, 10);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(75, 23);
            this.button_help.TabIndex = 10;
            this.button_help.Text = "Help";
            this.button_help.UseVisualStyleBackColor = true;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // checkCloseAtComplete
            // 
            this.checkCloseAtComplete.AutoSize = true;
            this.checkCloseAtComplete.Checked = true;
            this.checkCloseAtComplete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCloseAtComplete.Location = new System.Drawing.Point(65, 92);
            this.checkCloseAtComplete.Name = "checkCloseAtComplete";
            this.checkCloseAtComplete.Size = new System.Drawing.Size(127, 17);
            this.checkCloseAtComplete.TabIndex = 9;
            this.checkCloseAtComplete.Text = "Close when complete";
            this.checkCloseAtComplete.UseVisualStyleBackColor = true;
            this.checkCloseAtComplete.CheckedChanged += new System.EventHandler(this.checkCloseAtComplete_CheckedChanged);
            // 
            // button_convert
            // 
            this.button_convert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_convert.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button_convert.Location = new System.Drawing.Point(536, 115);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(126, 23);
            this.button_convert.TabIndex = 8;
            this.button_convert.Text = "Convert to VTT";
            this.button_convert.UseVisualStyleBackColor = true;
            this.button_convert.Click += new System.EventHandler(this.button_convert_Click);
            // 
            // button_output
            // 
            this.button_output.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button_output.Location = new System.Drawing.Point(536, 63);
            this.button_output.Name = "button_output";
            this.button_output.Size = new System.Drawing.Size(75, 23);
            this.button_output.TabIndex = 7;
            this.button_output.Text = "...";
            this.button_output.UseVisualStyleBackColor = true;
            this.button_output.Click += new System.EventHandler(this.button_output_Click);
            // 
            // button_input
            // 
            this.button_input.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button_input.Location = new System.Drawing.Point(536, 37);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(75, 23);
            this.button_input.TabIndex = 6;
            this.button_input.Text = "...";
            this.button_input.UseVisualStyleBackColor = true;
            this.button_input.Click += new System.EventHandler(this.button_input_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Output:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Convert:";
            // 
            // comboSource
            // 
            this.comboSource.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSource.FormattingEnabled = true;
            this.comboSource.Items.AddRange(new object[] {
            "File",
            "Folder"});
            this.comboSource.Location = new System.Drawing.Point(65, 12);
            this.comboSource.Name = "comboSource";
            this.comboSource.Size = new System.Drawing.Size(121, 21);
            this.comboSource.TabIndex = 2;
            this.comboSource.SelectedIndexChanged += new System.EventHandler(this.comboSource_SelectedIndexChanged);
            // 
            // outputPathBox
            // 
            this.outputPathBox.Location = new System.Drawing.Point(65, 65);
            this.outputPathBox.Name = "outputPathBox";
            this.outputPathBox.ReadOnly = true;
            this.outputPathBox.Size = new System.Drawing.Size(465, 20);
            this.outputPathBox.TabIndex = 1;
            // 
            // inputPathBox
            // 
            this.inputPathBox.Location = new System.Drawing.Point(65, 39);
            this.inputPathBox.Name = "inputPathBox";
            this.inputPathBox.ReadOnly = true;
            this.inputPathBox.Size = new System.Drawing.Size(465, 20);
            this.inputPathBox.TabIndex = 0;
            // 
            // monitorTextBox
            // 
            this.monitorTextBox.BackColor = System.Drawing.Color.Black;
            this.monitorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.monitorTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.monitorTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitorTextBox.ForeColor = System.Drawing.Color.White;
            this.monitorTextBox.Location = new System.Drawing.Point(0, 161);
            this.monitorTextBox.Multiline = true;
            this.monitorTextBox.Name = "monitorTextBox";
            this.monitorTextBox.ReadOnly = true;
            this.monitorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.monitorTextBox.Size = new System.Drawing.Size(749, 314);
            this.monitorTextBox.TabIndex = 1;
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 475);
            this.Controls.Add(this.monitorTextBox);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert SRT to VTT";
            this.Load += new System.EventHandler(this.Main_form_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button button_convert;
        private System.Windows.Forms.Button button_output;
        private System.Windows.Forms.Button button_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSource;
        private System.Windows.Forms.TextBox outputPathBox;
        private System.Windows.Forms.TextBox inputPathBox;
        private System.Windows.Forms.TextBox monitorTextBox;
        private System.Windows.Forms.CheckBox checkCloseAtComplete;
        private System.Windows.Forms.Button button_clean_monitor;
        private System.Windows.Forms.Button button_help;
    }
}

