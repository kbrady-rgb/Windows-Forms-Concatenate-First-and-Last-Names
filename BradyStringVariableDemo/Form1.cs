using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************
* Name        : String Variable Demo
* Author      : Kabrina Brady
* Created     : 9/7/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work
* Description : User types first and last name into TextBoxes and Submit button prints them in lblOutput with the first letters of the first and last names capitalized
*               Input:  First name, last name
*               Output: First name, space, and last name
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/

namespace BradyStringVariableDemo
{
    public partial class StringVariableDemoForm : Form
    {
        public StringVariableDemoForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void LblOutput_Click(object sender, EventArgs e)
        {
            lblOutput.Text = ""; //Sets the text of lblOutput to nothing
        }
        
        //Exit button terminates program
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //When Submit button clicked, concatenates txtFirstName and txtLastName and displays in lblOutput and puts a space between the words
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string varFirstName = txtFirstName.Text; //asigns user input to variable
            string varLastName = txtLastName.Text; //asigns user input to variable
            lblOutput.Text = char.ToUpper(varFirstName[0]) + varFirstName.Substring(1) + " " + 
            char.ToUpper(varLastName[0]) + varLastName.Substring(1); //displays the user input and uppercases the first letters
            //of the first and last names
        }

        private void TxtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
