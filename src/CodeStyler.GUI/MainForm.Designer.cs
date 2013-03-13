namespace CodeStyler.GUI
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.browseLanguageButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.templateComboBox = new System.Windows.Forms.ComboBox();
            this.browseTemplateButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.normalTabPage = new System.Windows.Forms.TabPage();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.previewTabPage = new System.Windows.Forms.TabPage();
            this.previewBrowser = new System.Windows.Forms.WebBrowser();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.formatButton = new System.Windows.Forms.Button();
            this.v35Checkbox = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.normalTabPage.SuspendLayout();
            this.previewTabPage.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Language:";
            // 
            // languageComboBox
            // 
            this.languageComboBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Location = new System.Drawing.Point(77, 10);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(396, 21);
            this.languageComboBox.TabIndex = 2;
            // 
            // browseLanguageButton
            // 
            this.browseLanguageButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseLanguageButton.Location = new System.Drawing.Point(479, 8);
            this.browseLanguageButton.Name = "browseLanguageButton";
            this.browseLanguageButton.Size = new System.Drawing.Size(59, 23);
            this.browseLanguageButton.TabIndex = 3;
            this.browseLanguageButton.Text = "Browse";
            this.browseLanguageButton.UseVisualStyleBackColor = true;
            this.browseLanguageButton.Click += new System.EventHandler(this.browseLanguageButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Template:";
            // 
            // templateComboBox
            // 
            this.templateComboBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.templateComboBox.FormattingEnabled = true;
            this.templateComboBox.Location = new System.Drawing.Point(77, 38);
            this.templateComboBox.Name = "templateComboBox";
            this.templateComboBox.Size = new System.Drawing.Size(396, 21);
            this.templateComboBox.TabIndex = 6;
            // 
            // browseTemplateButton
            // 
            this.browseTemplateButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseTemplateButton.Location = new System.Drawing.Point(479, 36);
            this.browseTemplateButton.Name = "browseTemplateButton";
            this.browseTemplateButton.Size = new System.Drawing.Size(59, 23);
            this.browseTemplateButton.TabIndex = 7;
            this.browseTemplateButton.Text = "Browse";
            this.browseTemplateButton.UseVisualStyleBackColor = true;
            this.browseTemplateButton.Click += new System.EventHandler(this.browseTemplateButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.AcceptsTab = true;
            this.inputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inputTextBox.Location = new System.Drawing.Point(0, 0);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(596, 154);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.Text = "";
            this.inputTextBox.WordWrap = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.normalTabPage);
            this.tabControl1.Controls.Add(this.previewTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(596, 208);
            this.tabControl1.TabIndex = 0;
            // 
            // normalTabPage
            // 
            this.normalTabPage.Controls.Add(this.outputTextBox);
            this.normalTabPage.Location = new System.Drawing.Point(4, 22);
            this.normalTabPage.Name = "normalTabPage";
            this.normalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.normalTabPage.Size = new System.Drawing.Size(588, 182);
            this.normalTabPage.TabIndex = 0;
            this.normalTabPage.Text = "Normal";
            this.normalTabPage.UseVisualStyleBackColor = true;
            // 
            // outputTextBox
            // 
            this.outputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.outputTextBox.Location = new System.Drawing.Point(3, 3);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(582, 176);
            this.outputTextBox.TabIndex = 0;
            this.outputTextBox.Text = "";
            this.outputTextBox.WordWrap = false;
            this.outputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.outputTextBox_KeyDown);
            this.outputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.outputTextBox_KeyPress);
            // 
            // previewTabPage
            // 
            this.previewTabPage.Controls.Add(this.previewBrowser);
            this.previewTabPage.Location = new System.Drawing.Point(4, 22);
            this.previewTabPage.Name = "previewTabPage";
            this.previewTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.previewTabPage.Size = new System.Drawing.Size(588, 182);
            this.previewTabPage.TabIndex = 1;
            this.previewTabPage.Text = "Preview";
            this.previewTabPage.UseVisualStyleBackColor = true;
            // 
            // previewBrowser
            // 
            this.previewBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewBrowser.Location = new System.Drawing.Point(3, 3);
            this.previewBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.previewBrowser.Name = "previewBrowser";
            this.previewBrowser.Size = new System.Drawing.Size(582, 176);
            this.previewBrowser.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(16, 65);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.inputTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(596, 367);
            this.splitContainer1.SplitterDistance = 154;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Language rules (*.rule)|*.rule|Template (*.template)|*.template|All files (*.*)|*" +
                ".*";
            // 
            // formatButton
            // 
            this.formatButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.formatButton.Location = new System.Drawing.Point(544, 36);
            this.formatButton.Name = "formatButton";
            this.formatButton.Size = new System.Drawing.Size(68, 23);
            this.formatButton.TabIndex = 8;
            this.formatButton.Text = "&Format";
            this.formatButton.UseVisualStyleBackColor = true;
            this.formatButton.Click += new System.EventHandler(this.formatButton_Click);
            // 
            // v35Checkbox
            // 
            this.v35Checkbox.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.v35Checkbox.AutoSize = true;
            this.v35Checkbox.Checked = true;
            this.v35Checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.v35Checkbox.Location = new System.Drawing.Point(544, 12);
            this.v35Checkbox.Name = "v35Checkbox";
            this.v35Checkbox.Size = new System.Drawing.Size(47, 17);
            this.v35Checkbox.TabIndex = 4;
            this.v35Checkbox.Text = "v3.5";
            this.v35Checkbox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 444);
            this.Controls.Add(this.v35Checkbox);
            this.Controls.Add(this.formatButton);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.browseTemplateButton);
            this.Controls.Add(this.browseLanguageButton);
            this.Controls.Add(this.templateComboBox);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(320, 240);
            this.Name = "MainForm";
            this.Text = "Cavingdeep Code Styler";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.normalTabPage.ResumeLayout(false);
            this.previewTabPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Button browseLanguageButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox templateComboBox;
        private System.Windows.Forms.Button browseTemplateButton;
        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage normalTabPage;
        private System.Windows.Forms.TabPage previewTabPage;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.WebBrowser previewBrowser;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button formatButton;
        private System.Windows.Forms.CheckBox v35Checkbox;
    }
}

