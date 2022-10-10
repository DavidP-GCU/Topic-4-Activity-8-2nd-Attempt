using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_8__2nd_Attempt_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Method used to calculate calories from fat grams. Method's name: "FatCalories()". 
        private double FatCalories(double gramsofFat)
        {
            return gramsofFat * 9;
        }

        //Method used to calculate calories from carbohydrate grams. Method's name: "CarbCalories()".
        private double CarbCalories(double gramsOfCarbs)
        {
            return gramsOfCarbs * 4;
        }

        //Method used to clear the user input (grams of fat and carbs) Method's name: "ClearAll()"
        private void ClearAll()
        {
            fatTextBox.Text = "";
            carbTextBox.Text = "";
            fatCaloriesLabel.Text = "";
            carbCaloriesLabel.Text = "";
            fatTextBox.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e) //Event handler for Exit button. This button exits the windows from. 
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e) //Event handler for Calculate Button. 
        {
            //Create double variables. 
            double fatGrams = 0;
            double carbGrams = 0;
            double caloriesFromFat = 0;
            double caloriesFromCarbs = 0;
            

            //Validate the users input (beginning of exception handler). 
            try
            {
                //Get the number of fat grams
                fatGrams = double.Parse(fatTextBox.Text);

                //Get the number of carb grams
                carbGrams = double.Parse(carbTextBox.Text);

                //Calculate the number of calories from fat grams
                caloriesFromFat = FatCalories(fatGrams);

                //Calculate the number of calories from carb grams. 
                caloriesFromCarbs = CarbCalories(carbGrams);

                //Display the number of calories from fat grams
                fatCaloriesLabel.Text = "Your number of calories from fat grams is: " + caloriesFromFat.ToString();

                //Display the number of calories from carb grams. 
                carbCaloriesLabel.Text = "Your number of calories from carb grams is: " + caloriesFromCarbs.ToString();

                //Clear the input from the user. 
                clearButton.Focus();


              //If the user entered invalid input (the end of the exception handler). 
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearAll(); //This clears the user's input by jumping to method named "ClearAll()". 
            }
        }

        private void clearButton_Click(object sender, EventArgs e) //Event handler for Clear Button. 
        {
            ClearAll(); //This button clears the all information on windows form. 
        }
    }


}
