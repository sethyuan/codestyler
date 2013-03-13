using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Cavingdeep.CodeStyler;
using Cavingdeep.Dcg.At;

namespace CodeStyler.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<KeyValuePair<string, RuleSet>> languages = new List<KeyValuePair<string, RuleSet>>()
            {
                new KeyValuePair<string, RuleSet>("C#", RuleSets.CSharp),
                new KeyValuePair<string, RuleSet>("Css", RuleSets.Css),
                new KeyValuePair<string, RuleSet>("JavaScript", RuleSets.JavaScript),
                new KeyValuePair<string, RuleSet>("Xml", RuleSets.Xml),
                new KeyValuePair<string, RuleSet>("Html", RuleSets.Html),
                new KeyValuePair<string, RuleSet>("Dcg AT", RuleSets.At),
                new KeyValuePair<string, RuleSet>("Python", RuleSets.Python),
            };

            this.languageComboBox.DisplayMember = "Key";
            this.languageComboBox.ValueMember = "Value";
            this.languageComboBox.DataSource = languages;

            List<KeyValuePair<string, IAtTemplate>> templates = new List<KeyValuePair<string, IAtTemplate>>()
            {
                new KeyValuePair<string, IAtTemplate>("C# - Html", DefaultStyles.CSharpHtml),
                new KeyValuePair<string, IAtTemplate>("C# - Html with line count", DefaultStyles.CSharpHtmlLine),
                new KeyValuePair<string, IAtTemplate>("Css - Html", DefaultStyles.CssHtml),
                new KeyValuePair<string, IAtTemplate>("Css - Html with line count", DefaultStyles.CssHtmlLine),
                new KeyValuePair<string, IAtTemplate>("JavaScript - Html", DefaultStyles.JavaScriptHtml),
                new KeyValuePair<string, IAtTemplate>("JavaScript - Html with line count", DefaultStyles.JavaScriptHtmlLine),
                new KeyValuePair<string, IAtTemplate>("Xml - Html", DefaultStyles.XmlHtml),
                new KeyValuePair<string, IAtTemplate>("Xml - Html with line count", DefaultStyles.XmlHtmlLine),
                new KeyValuePair<string, IAtTemplate>("Html - Html", DefaultStyles.HtmlHtml),
                new KeyValuePair<string, IAtTemplate>("Html - Html with line count", DefaultStyles.HtmlHtmlLine),
                new KeyValuePair<string, IAtTemplate>("Dcg AT - Html", DefaultStyles.AtHtml),
                new KeyValuePair<string, IAtTemplate>("Dcg AT - Html with line count", DefaultStyles.AtHtmlLine),
                new KeyValuePair<string, IAtTemplate>("Python - Html", DefaultStyles.PythonHtml),
                new KeyValuePair<string, IAtTemplate>("Python - Html with line count", DefaultStyles.PythonHtmlLine),
            };

            this.templateComboBox.DisplayMember = "Key";
            this.templateComboBox.ValueMember = "Value";
            this.templateComboBox.DataSource = templates;
        }

        private void outputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back || e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void outputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void browseLanguageButton_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.languageComboBox.Text = this.openFileDialog.FileName;
            }
        }

        private void browseTemplateButton_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.templateComboBox.Text = this.openFileDialog.FileName;
            }
        }

        private void formatButton_Click(object sender, EventArgs e)
        {
            RuleSet ruleSet;
            if (((KeyValuePair<string, RuleSet>) this.languageComboBox.SelectedItem).Key != this.languageComboBox.Text)
            {
                ruleSet = RuleSet.LoadFromFile(this.languageComboBox.Text);
            }
            else
            {
                ruleSet = this.languageComboBox.SelectedValue as RuleSet;
            }

            IAtTemplate template;
            if (((KeyValuePair<string, IAtTemplate>) this.templateComboBox.SelectedItem).Key != this.templateComboBox.Text)
            {
                template = new AtTemplateProxy(
                    this.templateComboBox.Text,
                    Encoding.UTF8,
                    this.v35Checkbox.Checked ? "v3.5" : "v2.0");
            }
            else
            {
                template = this.templateComboBox.SelectedValue as IAtTemplate;
            }

            string formattedCode = FormatCode(ruleSet, template, inputTextBox.Text);

            this.outputTextBox.Text = formattedCode;

            this.previewBrowser.DocumentText = formattedCode;
        }

        private string FormatCode(RuleSet ruleSet, IAtTemplate template, string code)
        {
            Styler styler = new Styler()
            {
                RuleSet = ruleSet,
                StyleTemplate = template
            };

            return styler.StyleCode(code);
        }
    }
}
