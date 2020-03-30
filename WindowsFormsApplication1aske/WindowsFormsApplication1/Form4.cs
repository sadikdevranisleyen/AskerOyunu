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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = listBox2.Items.Count;
            if (6 > a & a > 4)
            {
                if (listBox2.Items[0].ToString() == "başla")
                {
                    if (listBox2.Items[1].ToString() == "sola ilerle")
                    {
                        if (listBox2.Items[2].ToString() == "yukarı ilerle")
                        {
                            if (listBox2.Items[3].ToString() == "sağa ateş et")
                            {
                                if (listBox2.Items[4].ToString() == "bitir")
                                {
                                    pictureBox5.Visible = true;
                                    timer1.Start();
                                }
                                else
                                { label4.Text = "sonda bitir yazmalısın"; }
                            }
                            else
                            { label4.Text = "sağa ateş etmeyi unuttun"; }
                        }
                        else
                        { label4.Text = "askeri yukarı ilertmen lazım"; }
                    }
                    else
                    { label4.Text = "asker sağa ilertmen lazım"; }
                }
                else
                { label4.Text = "program başla ile başlar"; }
            }
            else
            { label4.Text = "Program beş adımdan oluşmakta"; }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Point nokta = new Point(e.X, e.Y);
            int sira = listBox1.IndexFromPoint(nokta);
            if (e.Button == MouseButtons.Left)
            {
                listBox1.DoDragDrop(listBox1.Items[sira], DragDropEffects.All);
            }
        }

        private void listBox2_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
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
            pictureBox2.Left = pictureBox2.Left - 60;
            pictureBox4.Left = pictureBox4.Left - 60;
            pictureBox5.Top = pictureBox5.Top + 17;
            timer1.Stop();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left = pictureBox2.Left - 60;
            pictureBox4.Left = pictureBox4.Left - 60;
            timer2.Stop();
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left = pictureBox2.Left - 60;
            pictureBox4.Left = pictureBox4.Left - 60;
            timer3.Stop();
            timer4.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox2.Top = pictureBox2.Top - 60;
            pictureBox4.Top = pictureBox4.Top - 60;
            pictureBox5.Top = pictureBox5.Top + 17;
            timer4.Stop();
            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox2.Top = pictureBox2.Top - 60;
            pictureBox4.Top = pictureBox4.Top - 60;
            timer5.Stop();
            timer6.Start();

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            pictureBox2.Top = pictureBox2.Top - 60;
            pictureBox4.Top = pictureBox4.Top - 60;
            timer6.Stop();
            timer7.Start();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox4.Left = pictureBox4.Left + 60;
            pictureBox5.Top = pictureBox5.Top + 17;

            timer7.Stop();
            timer8.Start();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            pictureBox4.Left = pictureBox4.Left + 60;
            timer8.Stop();
            timer9.Start();
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            pictureBox4.Left = pictureBox4.Left + 60;
            pictureBox5.Top = pictureBox5.Top + 13;
            timer9.Stop();
            Form5 frm = new Form5();
            this.Hide();
            frm.Show();
        }
    }
}
