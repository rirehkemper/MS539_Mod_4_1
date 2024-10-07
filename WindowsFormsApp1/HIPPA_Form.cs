using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class HIPPA_Form : Form
    {
        public HIPPA_Form()
        {
            InitializeComponent();
        }

        //This function will return the HIPPA_COMP.txt file to be displayed as a rich text. https://stackoverflow.com/questions/27823789/creating-text-file-in-c-sharp
        //and https://stackoverflow.com/questions/51178219/file-readalltext-cant-read
        public void HIPPATxtFile(string filepath)
        {
            try
            {
                //if the file does exist, it should return the filepath we specify. In this case, our HIPPA_COMP.txt file
                if (File.Exists(filepath))
                {
                    //setting the file path to the HIPPA_TXT
                    string HIPPA_TXT = File.ReadAllText(filepath);
                    richTextBox1.Text = HIPPA_TXT;
                }
                else
                {
                    MessageBox.Show("Sorry, the file was not Found");
                }
            }
            catch (Exception ) 
            {
                MessageBox.Show("The page you want to display is currently offline");
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
