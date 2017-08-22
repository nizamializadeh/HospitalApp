using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp
{
    public partial class Sobeler : Form
    {
        public Sobeler()
        {
            InitializeComponent();
        }

        private void Sobeler_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sobeler.ActiveForm.Hide();
            Form2 fr2 = new Form2();
            fr2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        
           
            listBox2.Items.Add(listBox1.SelectedItem + "\t" +textBox1.Text);

            //Sobeler.ActiveForm.Hide();
            //hekimadd fr4 = new hekimadd();
            //fr4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }
    }
}
