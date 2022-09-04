using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace task3
{
    public partial class Input : Form
    {
        IDevice Divace;
        public Input()
        {
            InitializeComponent();
        }

        private void Input_Load(object sender, EventArgs e)
        {

        }

        public void input()
        {
            string brand = BrandTextBox.Text;
            string diaf = DiafTextBox.Text;
            int zoom = Int32.Parse(ZoomTextBox.Text);
            int memory = Int32.Parse(MemoryTextBox.Text);
            int volume = Int32.Parse(VolumeTextBox.Text);
            Divace = new DigitalCamera(brand, diaf, zoom, memory, volume);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            input();
            MainForm main = this.Owner as MainForm;
            main.Add(Divace);
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}
