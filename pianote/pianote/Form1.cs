using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pianote
{
    public partial class Form1 : Form
    {

        int press = 0, between = 0;
        int[] note1 = { 1, 2, 3, 4, 5, 6, 7, 8,7,6,5,4,3,2,1 };
        int[] note2 = { 1,5,7,9,4,6,3,2,1,7};
        int[] noteRec = new int[100];
        int recP = 0;
        bool isRec = false;

        Color pressC = Color.DarkMagenta;
        Color defaultC = Color.WhiteSmoke;
        Color default_Sh_C = Color.Black;

        public Form1()
        {
            InitializeComponent();
            for (int n = 1; n < 14; n++)
            {
                blink(n);
            }
            press = 100; between = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int i =0; i < note1.Length; i++)
            {
                blink(note1[i]);
            }
            

        }
        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < note2.Length; i++)
            {
                blink(note2[i]);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (isRec)
            {
                isRec = false;
                pictureBox9.BackColor = Color.DarkGray;
                Application.DoEvents();
            }
            else
            {
                pictureBox9.BackColor = Color.Red;
                Application.DoEvents();
                noteRec = new int[100];
                recP = 0;
                isRec = true;
            }
              
        }
        private void button12_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < noteRec.Length; i++)
            {
                if (noteRec[i] != 0)
                    blink(noteRec[i]);
            }
        }

        private void click_on_key(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Z: DoClick(null, null); break;
                case Keys.X: ReClick(null, null); break;
                case Keys.C: MiClick(null, null); break;
                case Keys.V: FaClick(null, null); break;
                case Keys.B: SolClick(null, null); break;
                case Keys.N: LaClick(null, null); break;
                case Keys.M: SiClick(null, null); break;
                case Keys.Oemcomma: Do_2Click(null, null); break;
                case Keys.S: DoShClick(null, null); break;
                case Keys.D: ReShClick(null, null); break;
                case Keys.G: FaShClick(null, null); break;
                case Keys.H: SolShClick(null, null); break;
                case Keys.J: LaShClick(null, null); break;

            }


        }
        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            click_on_key(e);
        }
        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            click_on_key(e);
        }
        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            click_on_key(e);
        }
        private void button12_KeyDown(object sender, KeyEventArgs e)
        {
            click_on_key(e);
        }

        private void KeyChoose(int n, Color C)
        {
            switch (n)
            {
                case 1: pictureBox1.BackColor = C; break;
                case 2: pictureBox2.BackColor = C; break;
                case 3: pictureBox3.BackColor = C; break;
                case 4: pictureBox4.BackColor = C; break;
                case 5: pictureBox5.BackColor = C; break;
                case 6: pictureBox6.BackColor = C; break;
                case 7: pictureBox7.BackColor = C; break;
                case 8: pictureBox8.BackColor = C; break;
                case 9: pictureBox10.BackColor = C; break;
                case 10: pictureBox11.BackColor = C; break;
                case 11: pictureBox12.BackColor = C; break;
                case 12: pictureBox13.BackColor = C; break;
                case 13: pictureBox14.BackColor = C; break;



            }
        }
        private void blink(int n)
        {
            KeyChoose(n, pressC);
            Application.DoEvents();
            System.Threading.Thread.Sleep(press);

            if (n>8 && n<14)
                KeyChoose(n, default_Sh_C);
            else
                KeyChoose(n, defaultC);
            Application.DoEvents();
            System.Threading.Thread.Sleep(between);
        }
        private void DoClick(object sender, EventArgs e)
        {
            blink(1);
            if (isRec)
            {
                noteRec[recP] = 1;
                recP++;
            }

        }
        private void ReClick(object sender, EventArgs e)
        {
            blink(2);
            if (isRec)
            {
                noteRec[recP] = 2;
                recP++;
            }
        }
        private void MiClick(object sender, EventArgs e)
        {
            blink(3);
            if (isRec)
            {
                noteRec[recP] = 3;
                recP++;
            }
        }
        private void FaClick(object sender, EventArgs e)
        {
            blink(4);
            if (isRec)
            {
                noteRec[recP] = 4;
                recP++;
            }
        }
        private void SolClick(object sender, EventArgs e)
        {
            blink(5);
            if (isRec)
            {
                noteRec[recP] = 5;
                recP++;
            }
        }
        private void LaClick(object sender, EventArgs e)
        {
            blink(6);
            if (isRec)
            {
                noteRec[recP] = 6;
                recP++;
            }
        }
        private void SiClick(object sender, EventArgs e)
        {
            blink(7);
            if (isRec)
            {
                noteRec[recP] = 7;
                recP++;
            }
        }
        private void Do_2Click(object sender, EventArgs e)
        {
            blink(8);
            if (isRec)
            {
                noteRec[recP] = 8;
                recP++;
            }
        }
        private void DoShClick(object sender, EventArgs e)
        {
            blink(9);
            if (isRec)
            {
                noteRec[recP] = 9;
                recP++;
            }

        }
        private void ReShClick(object sender, EventArgs e)
        {
            blink(10);
            if (isRec)
            {
                noteRec[recP] = 10;
                recP++;
            }

        }
        private void FaShClick(object sender, EventArgs e)
        {
            blink(11);
            if (isRec)
            {
                noteRec[recP] = 11;
                recP++;
            }

        }
        private void SolShClick(object sender, EventArgs e)
        {
            blink(12);
            if (isRec)
            {
                noteRec[recP] = 12;
                recP++;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LaShClick(object sender, EventArgs e)
        {
            blink(13);
            if (isRec)
            {
                noteRec[recP] = 13;
                recP++;
            }

        }
    }
}
