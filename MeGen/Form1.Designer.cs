namespace MeGen
{
    partial class Form_main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_copyright = new TextBox();
            label_license = new Label();
            label_copyright = new Label();
            textBox_sizeX = new TextBox();
            textBox_sizeY = new TextBox();
            label_sizeX = new Label();
            label_sizeY = new Label();
            label_size = new Label();
            button_generate = new Button();
            label_attention = new Label();
            label_version = new Label();
            textBox_version = new TextBox();
            comboBox_license = new ComboBox();
            listBox_selectedFiles = new ListBox();
            button_selectFiles = new Button();
            SuspendLayout();
            // 
            // textBox_copyright
            // 
            textBox_copyright.Location = new Point(127, 116);
            textBox_copyright.Name = "textBox_copyright";
            textBox_copyright.Size = new Size(131, 23);
            textBox_copyright.TabIndex = 1;
            // 
            // label_license
            // 
            label_license.AutoSize = true;
            label_license.Location = new Point(44, 80);
            label_license.Name = "label_license";
            label_license.Size = new Size(47, 15);
            label_license.TabIndex = 2;
            label_license.Text = "Licence";
            // 
            // label_copyright
            // 
            label_copyright.AutoSize = true;
            label_copyright.Location = new Point(44, 119);
            label_copyright.Name = "label_copyright";
            label_copyright.Size = new Size(60, 15);
            label_copyright.TabIndex = 3;
            label_copyright.Text = "Copyright";
            // 
            // textBox_sizeX
            // 
            textBox_sizeX.Location = new Point(148, 155);
            textBox_sizeX.Name = "textBox_sizeX";
            textBox_sizeX.Size = new Size(30, 23);
            textBox_sizeX.TabIndex = 4;
            // 
            // textBox_sizeY
            // 
            textBox_sizeY.Location = new Point(204, 155);
            textBox_sizeY.Name = "textBox_sizeY";
            textBox_sizeY.Size = new Size(30, 23);
            textBox_sizeY.TabIndex = 5;
            // 
            // label_sizeX
            // 
            label_sizeX.AutoSize = true;
            label_sizeX.Location = new Point(127, 158);
            label_sizeX.Name = "label_sizeX";
            label_sizeX.Size = new Size(14, 15);
            label_sizeX.TabIndex = 6;
            label_sizeX.Text = "X";
            // 
            // label_sizeY
            // 
            label_sizeY.AutoSize = true;
            label_sizeY.Location = new Point(184, 158);
            label_sizeY.Name = "label_sizeY";
            label_sizeY.Size = new Size(14, 15);
            label_sizeY.TabIndex = 7;
            label_sizeY.Text = "Y";
            // 
            // label_size
            // 
            label_size.AutoSize = true;
            label_size.Location = new Point(44, 158);
            label_size.Name = "label_size";
            label_size.Size = new Size(27, 15);
            label_size.TabIndex = 8;
            label_size.Text = "Size";
            // 
            // button_generate
            // 
            button_generate.Location = new Point(127, 196);
            button_generate.Name = "button_generate";
            button_generate.Size = new Size(107, 23);
            button_generate.TabIndex = 9;
            button_generate.Text = "Generate";
            button_generate.UseVisualStyleBackColor = true;
            button_generate.Click += button_generate_Click;
            // 
            // label_attention
            // 
            label_attention.AutoSize = true;
            label_attention.Location = new Point(121, 228);
            label_attention.Name = "label_attention";
            label_attention.Size = new Size(0, 15);
            label_attention.TabIndex = 10;
            // 
            // label_version
            // 
            label_version.AutoSize = true;
            label_version.Location = new Point(44, 46);
            label_version.Name = "label_version";
            label_version.Size = new Size(45, 15);
            label_version.TabIndex = 11;
            label_version.Text = "Version";
            // 
            // textBox_version
            // 
            textBox_version.Location = new Point(127, 38);
            textBox_version.Name = "textBox_version";
            textBox_version.Size = new Size(131, 23);
            textBox_version.TabIndex = 12;
            textBox_version.Text = "1";
            // 
            // comboBox_license
            // 
            comboBox_license.FormattingEnabled = true;
            comboBox_license.Items.AddRange(new object[] { "CC BY-SA 3.0", "CC BY-NC-SA 3.0", "CC0 1.0" });
            comboBox_license.Location = new Point(127, 77);
            comboBox_license.Name = "comboBox_license";
            comboBox_license.Size = new Size(131, 23);
            comboBox_license.TabIndex = 13;
            // 
            // listBox_selectedFiles
            // 
            listBox_selectedFiles.FormattingEnabled = true;
            listBox_selectedFiles.ItemHeight = 15;
            listBox_selectedFiles.Location = new Point(12, 259);
            listBox_selectedFiles.Name = "listBox_selectedFiles";
            listBox_selectedFiles.Size = new Size(279, 79);
            listBox_selectedFiles.TabIndex = 14;
            // 
            // button_selectFiles
            // 
            button_selectFiles.Location = new Point(103, 346);
            button_selectFiles.Name = "button_selectFiles";
            button_selectFiles.Size = new Size(107, 23);
            button_selectFiles.TabIndex = 15;
            button_selectFiles.Text = "Select files";
            button_selectFiles.UseVisualStyleBackColor = true;
            button_selectFiles.Click += button_selectFiles_Click;
            // 
            // Form_main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 381);
            Controls.Add(button_selectFiles);
            Controls.Add(listBox_selectedFiles);
            Controls.Add(comboBox_license);
            Controls.Add(textBox_version);
            Controls.Add(label_version);
            Controls.Add(label_attention);
            Controls.Add(button_generate);
            Controls.Add(label_size);
            Controls.Add(label_sizeY);
            Controls.Add(label_sizeX);
            Controls.Add(textBox_sizeY);
            Controls.Add(textBox_sizeX);
            Controls.Add(label_copyright);
            Controls.Add(label_license);
            Controls.Add(textBox_copyright);
            Name = "Form_main";
            Text = "MeGen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox_copyright;
        private Label label_license;
        private Label label_copyright;
        private TextBox textBox_sizeX;
        private TextBox textBox_sizeY;
        private Label label_sizeX;
        private Label label_sizeY;
        private Label label_size;
        private Button button_generate;
        private Label label_attention;
        private Label label_version;
        private TextBox textBox_version;
        private ComboBox comboBox_license;
        private ListBox listBox_selectedFiles;
        private Button button_selectFiles;
    }
}
