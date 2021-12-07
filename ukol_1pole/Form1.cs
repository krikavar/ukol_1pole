using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol_1pole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_vypoc_Click(object sender, EventArgs e)
        {
            try { 
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            int[] poleA;
            Random random = new Random();
            int vsthod = int.Parse(textBox_vstuphod.Text);
            poleA = new int[vsthod];
            for (int i = 0; i < poleA.Length; i++)
            {
                int rng = random.Next(1, 51);
                poleA[i] = rng;
                listBox1.Items.Add(rng);
            }
            if (radioButton_dolu.Checked == true)
            {
                Array.Sort(poleA);
                foreach(int s in poleA)
                {
                    listBox2.Items.Add(s);
                }
            }
            if (radioButton_nahoru.Checked == true)
            {
                Array.Sort(poleA);
                Array.Reverse(poleA);
                foreach (int s in poleA )
                {
                    listBox2.Items.Add(s);
                }
            }
            }
            catch { MessageBox.Show("hej, co zkoušíš -_-"); }
        }
    }
}
