/* Estimated Time:  2 hours
 * Actual Time: 3.5 hours. The increase from estimated to actual is the result of two different factors. One being that I 
 * had to start and stop multiple times. Each time I had to find my footing. The other reason was searching for how to add 
 * dialog to the combobox... which I found was incredibly easy.  Look at all of the options on the Design Tool!  */
/*10/6/24 I estimate that the process of decluttering the form and autopoulating will take
 * an hour and a half. I hope to transfer user data from the registration page to this form.
 * Actual time was about an hour and fifteen minutes.  It's because I realized that it may be a better idea to take this
 * in a different direction.  As of next project I'll be trying to organize my data into a spreadsheet, allowing certain
 * user data to be placed in certain cells for easier organization and to be able to pull specific data points whenever needed.
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        //initialize the form
        public Form1(string username)
        {
            InitializeComponent();       
                label2.Text = "Welcome " + username;
                //load the form

        }
        //load the form
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //lable one, no actions on click
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //button 1 is the submit button. Presents a message box to the end user based on sex chosen
        private void button1_Click(object sender, EventArgs e)
        {
            //String firstName = textBox1.Text;
            //String lastName = textBox2.Text;
            //Boolean male = radioButton1.Checked;
            //Boolean female = radioButton2.Checked;
            //Boolean nonBinary = radioButton3.Checked;

            //if (male)
            //{
            //    String M = "Mr.";
            //    MessageBox.Show("Thank you for Submitting your Interest, " + M + " " + firstName + " " + lastName + ". Someone will Reach out to you soon.");
            //}
            //else if (female)
            //{
            //    String F = "Mrs.";
            //    MessageBox.Show("Thank you for Submitting your Interest, " + F + " " + firstName + " " + lastName + ". Someone will Reach out to you soon.");
            //}
            //else
            //{
            //    String U = "";
            //    MessageBox.Show("Thank you for Submitting your Interest, " + U + " " + firstName + " " + lastName + ". Someone will Reach out to you soon.");
            //}

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //When checkboxes are selected, images associated with that checkbox will apprear.
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            String path;
            if (checkBox4.Checked)
            {
                path = Directory.GetCurrentDirectory();
                string imagePath = Path.Combine(path, "Driving.jpg");
                pictureBox4.ImageLocation = imagePath;
                pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;

                pictureBox4.Show();
            }
            else
            {
                pictureBox4.Hide();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            String path;
            if (checkBox3.Checked)
            {
                path = Directory.GetCurrentDirectory();
                string imagePath = Path.Combine(path, "Video games.jpg");
                pictureBox3.ImageLocation = imagePath;
                pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;

                pictureBox3.Show();
            }
            else
            {
                pictureBox3.Hide();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            String path;
            if (checkBox2.Checked)
            {
                path = Directory.GetCurrentDirectory();
                string imagePath = Path.Combine(path, "volleyball.jpg");
                pictureBox2.ImageLocation = imagePath;
                pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;

                pictureBox2.Show();
            }
            else
            {
                pictureBox2.Hide();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            String path;
            if (checkBox1.Checked)
            {
                path = Directory.GetCurrentDirectory();
                string imagePath = Path.Combine(path, "paddleboarding.jpg");
                pictureBox1.ImageLocation = imagePath;
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

                pictureBox1.Show();
            }
            else
            {
                pictureBox1.Hide();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        //Combox conditions can be updated in the design form
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                Form2 form2 = new Form2();
                form2.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error has occurred: {ex.Message}");
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
