using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {

        
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = listBox2.Items.Count;
            if (6> a  &   a > 4)
            {
                if (listBox2.Items[0].ToString() == "başla")
                {
                    if (listBox2.Items[1].ToString() == "bi adım ilerle")
                    {
                        if (listBox2.Items[2].ToString() == "bi adım ilerle")
                        {
                            if (listBox2.Items[3].ToString() == "sağa ilerle")
                            {
                                if (listBox2.Items[4].ToString() == "bitir")
                                {
                                    pictureBox4.Visible = true;
                                    timer1.Start();
                                }
                                else
                                { label4.Text = "sonda bitir yazmalısın"; }
                            }
                            else
                            { label4.Text = "sağa dönmeyi unuttun"; }
                        }
                        else
                        { label4.Text = "askeri iki adım ilertmen lazım"; }
                    }
                    else
                    { label4.Text = "asker ilertmen lazım"; }
                }
                else
                { label4.Text = "program başla ile başlar"; }
            }
            else
            { label4.Text = "Program beş adımdan oluşmakta"; }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Point nokta = new Point(e.X,e.Y);
            int sira = listBox1.IndexFromPoint(nokta);
            if (e.Button == MouseButtons.Left)
            {
                listBox1.DoDragDrop(listBox1.Items[sira],DragDropEffects.All);
            }

        }

        private void listBox2_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState==1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            listBox2.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Top = pictureBox2.Top - 60;
            pictureBox4.Top = pictureBox4.Top + 17;
            timer1.Stop();
            timer2.Start();
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox2.Top = pictureBox2.Top - 60;
            pictureBox4.Top = pictureBox4.Top + 17;
            timer2.Stop();
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left = pictureBox2.Left + 60;
            pictureBox4.Top = pictureBox4.Top + 17;
            timer3.Stop();
            timer4.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left = pictureBox2.Left + 60;
            timer4.Stop();
            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left = pictureBox2.Left + 60;
            pictureBox4.Top = pictureBox4.Top + 17;
            timer5.Stop();
            Form3 frm = new Form3();
            this.Hide();
            frm.Show();
        }
    }
}
