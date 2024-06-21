using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace xlrs
{
    public partial class Form1 : Form
    {
        int b = 0;

        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label3.Text = "Правильно";
                b = b + 1;
            }
            else label3.Text = "Неправильно";
            button1.Visible = false;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (radioButton6.Checked == true)
            {
                label5.Text = "Правильно";
                b = b + 1;
            }
            else label5.Text = "Неправильно";
            button2.Visible = false;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                label7.Text = "Правильно";
                b = b + 1;
            }
            else label7.Text = "Неправильно";
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                label9.Text = "Правильно";
                b = b + 1;
            }
            else label9.Text = "Неправильно";
            button4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton19.Checked == true)
            {
                label11.Text = "Правильно";
                b = b + 1;
            }
            else label11.Text = "Неправильно";
            button5.Visible = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton24.Checked == true)
            {
                label12.Text = "Правильно";
                b = b + 1;
            }
            else label12.Text = "Неправильно";
            button6.Visible = false;
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (radioButton27.Checked == true)
            {
                label14.Text = "Правильно";
                b = b + 1;
            }
            else label14.Text = "Неправильно";
            button7.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton29.Checked == true)
            {
                label16.Text = "Правильно";
                b = b + 1;
            }
            else label16.Text = "Неправильно";
            button8.Visible = false;
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton36.Checked == true)
            {
                label18.Text = "Правильно";
                b = b + 1;
            }
            else label18.Text = "Неправильно";
            button9.Visible = false;
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (radioButton38.Checked == true)
            {
                label20.Text = "Правильно";
                b = b + 1;
            }
            else label20.Text = "Неправильно";
            button10.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (radioButton43.Checked == true)
            {
                label22.Text = "Правильно";
                b = b + 1;
            }
            else label22.Text = "Неправильно";
            button11.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (radioButton48.Checked == true)
            {
                label24.Text = "Правильно";
                b = b + 1;
            }
            else label24.Text = "Неправильно";
            button12.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (radioButton51.Checked == true)
            {
                label26.Text = "Правильно";
                b = b + 1;
            }
            else label26.Text = "Неправильно";
            button13.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (radioButton53.Checked == true)
            {
                label28.Text = "Правильно";
                b = b + 1;
            }
            else label28.Text = "Неправильно";
            button14.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (radioButton59.Checked == true)
            {
                label30.Text = "Правильно";
                b = b + 1;
            }
            else label30.Text = "Неправильно";
            button15.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (radioButton61.Checked == true)
            {
                label32.Text = "Правильно";
                b = b + 1;
            }
            else label32.Text = "Неправильно";
            button16.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (radioButton68.Checked == true)
            {
                label34.Text = "Правильно";
                b = b + 1;
            }
            else label34.Text = "Неправильно";
            button17.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (radioButton71.Checked == true)
            {
                label36.Text = "Правильно";
                b = b + 1;
            }
            else label36.Text = "Неправильно";
            button18.Visible = false;
        }

        private void tabPage19_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void groupBox18_Enter(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (radioButton74.Checked == true)
            {
                label38.Text = "Правильно";
                b = b + 1;
            }
            else label38.Text = "Неправильно";
            button19.Visible = false;
        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (radioButton79.Checked == true)
            {
                label40.Text = "Правильно";
                b = b + 1;
            }
            else label40.Text = "Неправильно";
            button20.Visible = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (radioButton82.Checked == true)
            {
                label42.Text = "Правильно";
                b = b + 1;
            }
            else label42.Text = "Неправильно";
            button21.Visible = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (radioButton86.Checked == true)
            {
                label44.Text = "Правильно";
                b = b + 1;
            }
            else label44.Text = "Неправильно";
            button22.Visible = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (radioButton92.Checked == true)
            {
                label46.Text = "Правильно";
                b = b + 1;
            }
            else label46.Text = "Неправильно";
            button23.Visible = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (radioButton96.Checked == true)
            {
                label48.Text = "Правильно";
                b = b + 1;
            }
            else label48.Text = "Неправильно";
            button24.Visible = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (radioButton97.Checked == true)
            {
                label50.Text = "Правильно";
                b = b + 1;
            }
            else label50.Text = "Неправильно";
            button25.Visible = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (radioButton103.Checked == true)
            {
                label52.Text = "Правильно";
                b = b + 1;
            }
            else label52.Text = "Неправильно";
            button26.Visible = false;
        }

        private void groupBox27_Enter(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (radioButton108.Checked == true)
            {
                label54.Text = "Правильно";
                b = b + 1;
            }
            else label54.Text = "Неправильно";
            button27.Visible = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (radioButton112.Checked == true)
            {
                label56.Text = "Правильно";
                b = b + 1;
            }
            else label56.Text = "Неправильно";
            button28.Visible = false;

        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (radioButton115.Checked == true)
            {
                label58.Text = "Правильно";
                b = b + 1;
            }
            else label58.Text = "Неправильно";
            button29.Visible = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (radioButton119.Checked == true)
            {
                label60.Text = "Правильно";
                b = b + 1;
            }
            else label60.Text = "Неправильно";
            button30.Visible = false;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            label64.Text = Convert.ToString(b); ;
            if (b == 30 || b == 29 || b == 28 || b == 27) label65.Text = "Оценка 5 (отлично)";
            if (b == 26 || b == 25 || b == 24 || b == 23 || b == 22 || b == 21
                || b == 20 || b == 19 || b == 18) label65.Text = "Оценка 4(хорошо)";
            if (b == 17 || b == 16 || b == 15 || b == 14 || b == 13 || b == 12
                || b == 11 || b == 10) label65.Text = "Оценка 3(удовлетворительно)";
            if (b == 9 || b == 8 || b == 7 || b == 6 || b == 5) label65.Text = "Оценка 2(плохо)";
            if (b == 4 || b == 3 || b == 2 || b == 1) label65.Text = "Оценка 1(все ужасно)";
        }

        private void button32_Click(object sender, EventArgs e)
        {
        }
          
    }
}
