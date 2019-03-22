using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtamedesEditor2
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void SAIEdit_Click(object p_Sender, EventArgs p_Event)
        {
            SAIEdit l_SAIEdit = new SAIEdit();
            l_SAIEdit.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Waypoints l_Waypoints = new Waypoints();
            l_Waypoints.ShowDialog();
        }
    }
}
