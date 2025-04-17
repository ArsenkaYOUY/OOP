using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PluginSelectionForm: Form
    {
        public string SelectedShape { get; private set; }

        public PluginSelectionForm(List<string> possibleShapes)
        {
            InitializeComponent();

            listBoxPlugins.Items.AddRange(possibleShapes.ToArray());
        }

        private void bttnAddPlugin_Click_1(object sender, EventArgs e)
        {
            if (listBoxPlugins.SelectedItem != null)
            {
                SelectedShape = listBoxPlugins.SelectedItem.ToString(); 
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
