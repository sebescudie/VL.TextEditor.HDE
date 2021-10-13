
namespace VL.TextEditor
{
    partial class TextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.TextEditorControl = new ICSharpCode.TextEditor.TextEditorControl();
            this.CopyToIOBoxButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.SyntaxHighlightDropdown = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextEditorControl
            // 
            resources.ApplyResources(this.TextEditorControl, "TextEditorControl");
            this.TextEditorControl.Highlighting = "XML";
            this.TextEditorControl.Name = "TextEditorControl";
            this.TextEditorControl.Load += new System.EventHandler(this.TextEditorControl_Load);
            // 
            // CopyToIOBoxButton
            // 
            resources.ApplyResources(this.CopyToIOBoxButton, "CopyToIOBoxButton");
            this.CopyToIOBoxButton.Name = "CopyToIOBoxButton";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToIOBoxButton,
            this.toolStripSeparator1});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStrip2
            // 
            resources.ApplyResources(this.toolStrip2, "toolStrip2");
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SyntaxHighlightDropdown,
            this.toolStripLabel1});
            this.toolStrip2.Name = "toolStrip2";
            // 
            // SyntaxHighlightDropdown
            // 
            this.SyntaxHighlightDropdown.Name = "SyntaxHighlightDropdown";
            resources.ApplyResources(this.SyntaxHighlightDropdown, "SyntaxHighlightDropdown");
            this.SyntaxHighlightDropdown.TextChanged += new System.EventHandler(this.SyntaxHighlightDropdown_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // TextEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextEditorControl);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TextEditor";
            this.Load += new System.EventHandler(this.TextEditor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ICSharpCode.TextEditor.TextEditorControl TextEditorControl;
        private System.Windows.Forms.ToolStripButton CopyToIOBoxButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripComboBox SyntaxHighlightDropdown;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

