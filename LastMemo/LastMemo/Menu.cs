using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastMemo
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 nums = new Form1();
            nums.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fruits = new Form2();
            fruits.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 animals = new Form3();
            animals.ShowDialog();
        }
    }
}
