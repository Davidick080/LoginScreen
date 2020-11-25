using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        //global variables
        string username;
        int pin;

        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                username = userInput.Text;
                pin = Convert.ToInt32(pinInput.Text);

                outputLabel.Text = $"Welcome {username}. PIN is {pin}";
            }
            catch 
            {
                outputLabel.Text = "PIN must be numbers only";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = userInput.Text;
            pin = Convert.ToInt32(pinInput.Text);
            outputLabel.Text = $"Welcome {username}. PIN is {pin}";
        }
    }
}
