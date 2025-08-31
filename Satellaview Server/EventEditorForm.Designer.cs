namespace Satellaview_server
{
    partial class EventEditorForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button scriptEditorButton;
        private System.Windows.Forms.ListBox commandsListBox;
        private System.Windows.Forms.Button addCommandButton;
        private System.Windows.Forms.Button removeCommandButton;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.NumericUpDown xPositionNumeric;
        private System.Windows.Forms.NumericUpDown yPositionNumeric;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.saveButton = new System.Windows.Forms.Button();
            this.scriptEditorButton = new System.Windows.Forms.Button();
            this.commandsListBox = new System.Windows.Forms.ListBox();
            this.addCommandButton = new System.Windows.Forms.Button();
            this.removeCommandButton = new System.Windows.Forms.Button();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.xPositionNumeric = new System.Windows.Forms.NumericUpDown();
            this.yPositionNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.xPositionNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPositionNumeric)).BeginInit();
            this.SuspendLayout();
            
            // Basic UI layout would go here
            
            ((System.ComponentModel.ISupportInitialize)(this.xPositionNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPositionNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
