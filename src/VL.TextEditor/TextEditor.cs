using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VL.TextEditor
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
        }

        public Form GetForm()
        {
            return this;
        }

        public ICSharpCode.TextEditor.TextEditorControl GetTextEditorControl()
        {
            return this.TextEditorControl;
        }

        public ToolStripButton GetCopyToIOBoxButton()
        {
            return this.CopyToIOBoxButton;
        }

        private void TextEditorControl_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void TextEditor_Load(object sender, EventArgs e)
        { 
            foreach(var key in ICSharpCode.TextEditor.Document.HighlightingManager.Manager.HighlightingDefinitions.Keys)
            {
                SyntaxHighlightDropdown.Items.Add(key.ToString());
            }
        }

        private void SyntaxHighlightDropdown_TextChanged(object sender, EventArgs e)
        {
            TextEditorControl.SetHighlighting(SyntaxHighlightDropdown.Text);
        }
    }
}
