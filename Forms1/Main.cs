using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace task1
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

        Disc Listtr = new Disc();

        private void OutputButton_Click(object sender, EventArgs e) 
        {
            listBox.Items.Clear();
            int count = Listtr.tracklist.Count;
            for (int i = 0; i < count; i++)
            {
                listBox.Items.Add((i + 1).ToString() + ". " + Listtr.tracklist[i].MakeStr());
            }
        }

        private void DisclenButton_Click(object sender, EventArgs e) 
        {
            LengthBox.Clear();
            LengthBox.Text += Listtr.DiscLength();
        }


        public bool Check(string str) 
        {
            int i = 0;
            Regex r = new Regex(@"[\d.,]");
            Match m = r.Match(str);
            while (m.Success)
            {
                i++;
                m = m.NextMatch();
            }
            if (i!=str.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            ResTextBox.Clear();
            if (BeginTextBox.Text != "" && EndTextBox.Text != "" && Check(BeginTextBox.Text) && Check(EndTextBox.Text))
            {
                double first = double.Parse(BeginTextBox.Text.Replace('.', ','));
                double last = double.Parse(EndTextBox.Text.Replace(".", ","));
                string str = Listtr.FindByRange(first, last);
                if (str == "")
                {
                    ResTextBox.Text += "Нет треков в заданном диапазоне";
                }
                else
                {
                    ResTextBox.Text += str;
                }
            }
            else
            {
                MessageBox.Show("Вам нужно ввести начало и конец диапазона в соответствующие TextBox, можно вводить только числа с точкой или запятой");
            }
        }

        private void SortButton_Click(object sender, EventArgs e) 
        {
            string input_style = StyletextBox.Text;
            if (Enum.IsDefined(typeof(Styles), input_style))
            {
                listBox.Items.Clear();
                int count = Listtr.tracklist.Count;
                var sortlist = Listtr.SortByStyles((Styles)Enum.Parse(typeof(Styles), input_style));
                for (int i = 0; i < count; i++)
                    listBox.Items.Add((i + 1).ToString() + ". " + sortlist[i].MakeStr());
            }
            else
            {
                MessageBox.Show("Такого стиля нет");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EndTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BeginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
