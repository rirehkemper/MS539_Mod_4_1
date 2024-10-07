/* 10/6/24 Estimated time to show password when the box is checked about 15 minutes
 * Actual time was about 10 minutes, I quickly found the information online, credit given
 * below.
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            Form1 form1 = new Form1(username);
            form1.Show();
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //hard-coding the username and password for testing
                string username = "Allen";
                string password = "1234";
                if (textBox1.Text.Equals(username) && textBox2.Text.Equals(password))
                {
                    Form1 schedulePage = new Form1(username);
                    schedulePage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("wrong username or password, please try again");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("an error has occurred, you will be returned to the login page");
                Form2 form2 = new Form2();
                form2.Show();
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //This will toggle the checkBox1 on Form 2 to display or hide the password
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //I had to look up the code to show the characters, specifically the
                //'/0' aspect.  I've learned that it represents null.  
                //How do I reset a PasswordChar? (n.d.). Stack Overflow.
                //https://stackoverflow.com/questions/17871910/how-do-i-reset-a-passwordchar
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
