using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gradecalculator
{
    public partial class averagecal : Form
    {
        public averagecal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            //Prompt User to enter grades
            decimal classOne = Convert.ToDecimal(txtClassOne.Text);
            decimal classTwo = Convert.ToDecimal(txtClassTwo.Text);
            decimal classThree = Convert.ToDecimal(txtClassThree.Text);
            decimal classFour = Convert.ToDecimal(txtClassFour.Text);
            decimal classFive = Convert.ToDecimal(txtClassFive.Text);
            decimal classSix = Convert.ToDecimal(txtClassSix.Text);


            ///Input Grades 1 to 7


            //Calculate (all input grades / 7 = Output with letter)

            decimal finalCal = (classOne + classTwo + classThree + classFour + classFive + classSix) / 7;
            lblCal.Text = Convert.ToString(finalCal);



            //Output Class 1 Grade with Letter

            if (classOne > 90 ) 
            {
                lblClassOne.Text = "A";
            }

           if (classTwo > 80)
            {
                lblClassTwo.Text = "B"; 
            }
        
            if (classThree > 70)
            {
                lblClassThree.Text = "C";
            }


        }

    }
           
            }



      

