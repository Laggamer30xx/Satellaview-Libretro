using System;
using System.Windows.Forms;

namespace Satellaview server
{
    public partial class EventEditorForm : Form
    {
        public NPCEvent CurrentEvent { get; set; }
        
        public EventEditorForm()
        {
            InitializeComponent();
        }
        
        public EventEditorForm(NPCEvent npcEvent) : this()
        {
            CurrentEvent = npcEvent;
            UpdateUI();
        }
        
        private void UpdateUI()
        {
            // TODO: Implement UI update logic
        }
        
        private void saveButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement save logic
        }
        
        private void scriptEditorButton_Click(object sender, EventArgs e)
        {
            // TODO: Open script editor
        }
    }
}
