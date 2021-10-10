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

        private void TextEditorControl_Load(object sender, EventArgs e)
        {

        }
    }
}
