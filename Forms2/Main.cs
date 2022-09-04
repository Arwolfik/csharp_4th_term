using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public List<Televisions> Televisions = new List<Televisions>(); 
        public List<TV> TV = new List<TV>();

        private void WithCountrycheckbtn_CheckedChanged(object sender, EventArgs e) 
        {
            if (withCountrycheckbtn.Checked)
            {
                MessageBox.Show("Вы можете ввести страну в соответствующий TextBox");
                CountrytextBox.Enabled = true;
            }
        }

        private void WithoutCountrycheckbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (withoutCountrycheckbtn.Checked)
            {
                CountrytextBox.Enabled = false;
            }
        }


        private void InputButton_Click(object sender, EventArgs e) 
        {
            Televisions.Add(new Televisions(FirmtextBox.Text, Int32.Parse(DiagonaltextBox.Text), Int32.Parse(SoundPowtextBox.Text)));
            if (withCountrycheckbtn.Checked)
            {
                TV.Add(new TV(FirmtextBox.Text, Int32.Parse(DiagonaltextBox.Text), Int32.Parse(SoundPowtextBox.Text), CountrytextBox.Text));
            }
        }

        private void OutputButton_Click(object sender, EventArgs e) 
        {
            FirstClasslistBox.Items.Clear();
            int count = Televisions.Count;
            for (int i = 0; i < count; i++)
            {
                FirstClasslistBox.Items.Add((i + 1).ToString() + ". " + Televisions[i].MakeStr() + ", Качество объекта: " + Televisions[i].QualityOfTV());
            }
            SecondClasslistBox.Items.Clear();
            int count_2 = TV.Count;
            for (int i = 0; i < count_2; i++)
            {
                SecondClasslistBox.Items.Add((i + 1).ToString() + ". " + TV[i].MakeStr() + ", Качество объекта: " + TV[i].QualityOfTV());
            }
        }
    }
}
