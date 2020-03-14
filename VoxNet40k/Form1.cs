using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoxNet40k
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Greetings, In the Omnissia's name, How may I serve?");

        }

        private void voxContactBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.voxContactBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.voxNetDB_DataSet);

        }

        private void voxContactBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.voxContactBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.voxNetDB_DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'voxNetDB_DataSet.VoxContact' table. You can move, or remove it, as needed.
            this.voxContactTableAdapter.Fill(this.voxNetDB_DataSet.VoxContact);

        }
    }
}
