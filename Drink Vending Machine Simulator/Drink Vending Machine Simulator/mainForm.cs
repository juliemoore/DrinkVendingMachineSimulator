using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Program:     Drink Vending Machine Simulator
// Date:        April 27, 2017
// Purpose:     The purpose of this program is to simulate a drink vending machine. The
//              user may click on a picture of 5 different drinks. The program will
//              then decrement the count and display the total sale price. When there
//              are zero drinks left, a message will display informing the user that
//              drink is out. This program contains a class named Drink and an array
//              to store data for each soft drink.

namespace Drink_Vending_Machine_Simulator
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }


        private void mainForm_Load(object sender, EventArgs e)
        {
            int count = 20;
            decimal zeroSales = 0m;
            colaLabel.Text = count.ToString();
            rootBeerLabel.Text = count.ToString();
            lemonLimeLabel.Text = count.ToString();
            grapeSodaLabel.Text = count.ToString();
            creamSodaLabel.Text = count.ToString();
            totalLabel.Text = zeroSales.ToString("c");
        }

        // Declare variables
        decimal sales;          // To hold a sales amount
        decimal total = 0m;    // accumulator for total sales
        int totalColaCount = 20;    // accumulator for total sold
        int totalRootBeerCount = 20;    // accumulator for total sold
        int totalLemonLimeCount = 20;    // accumulator for total sold
        int totalGrapeSodaCount = 20;    // accumulator for total sold
        int totalCreamSodaCount = 20;    // accumulator for total sold

        // Create an array
        object[,] softDrink = new object[,]
                {
                    {"Cola", 1.0m, 20 },
                    {"Root Beer", 1.0m, 20 },
                    {"Lemon Lime", 1.0m, 20 },
                    { "Grape Soda", 1.50m, 20 },
                    { "Cream Soda", 1.50m, 20 },
                    };

        private void colaPictureBox_Click(object sender, EventArgs e)
        {
            // Declare variables
            int count;              // To hold the drink count

            // Create a Drink object
            Drink cola = new Drink();
      
	        // Set the objects's Name property
            cola.Name = (string)softDrink[0, 0];
            cola.Cost = (decimal)softDrink[0, 1];
            cola.Amount = (int)softDrink[0, 2];

            if (totalColaCount > 0)
            {
                cola.Amount = (int)softDrink[0, 2];

                count = cola.Amount - 1;

                // Get a new count
                totalColaCount = count;

                // Change cola amount
                softDrink[0, 2] = totalColaCount;

                // Get a sales amount
                sales = cola.Cost;

                // Add the sales amount to total
                total += sales;

                // Display the drinks left  
                colaLabel.Text = totalColaCount.ToString();

                // Display the total sales
                totalLabel.Text = total.ToString("c");
                }
                else
                {
                    MessageBox.Show("Sorry, " + cola.Name + " is sold out.");
                } // end else 
        }

        private void rootBeerPictureBox_Click(object sender, EventArgs e)
        {
            // Declare variables
            int count;              // To hold the drink count

            // Create a Drink object
            Drink rootBeer = new Drink();

            // Set the objects's Name property
            rootBeer.Name = (string)softDrink[1, 0];
            rootBeer.Cost = (decimal)softDrink[1, 1];
            rootBeer.Amount = (int)softDrink[1, 2];

            if (totalRootBeerCount > 0)
            {
                rootBeer.Amount = (int)softDrink[1, 2];

                count = rootBeer.Amount - 1;

                // Get a new count
                totalRootBeerCount = count;

                // Change root beer amount
                softDrink[1, 2] = totalRootBeerCount;

                // Get a sales amount
                sales = rootBeer.Cost;

                // Add the sales amount to total
                total += sales;

                // Display the drinks left  
                rootBeerLabel.Text = totalRootBeerCount.ToString();

                // Display the total sales
                totalLabel.Text = total.ToString("c");
            }
            else
            {
                MessageBox.Show("Sorry, " + rootBeer.Name + " is sold out.");
            } // end else
        }

        private void lemonLimePictureBox_Click(object sender, EventArgs e)
        {
            // Declare variables
            int count;              // To hold the drink count

            // Create a Drink object
            Drink lemonLime = new Drink();

            // Set the objects's Name property
            lemonLime.Name = (string)softDrink[2, 0];
            lemonLime.Cost = (decimal)softDrink[2, 1];
            lemonLime.Amount = (int)softDrink[2, 2];

            if (totalLemonLimeCount > 0)
            {
                lemonLime.Amount = (int)softDrink[2, 2];

                count = lemonLime.Amount - 1;

                // Get a new count
                totalLemonLimeCount = count;

                // Change lemon lime amount
                softDrink[2, 2] = totalLemonLimeCount;

                // Get a sales amount
                sales = lemonLime.Cost;

                // Add the sales amount to total
                total += sales;

                // Display the drinks left  
                lemonLimeLabel.Text = totalLemonLimeCount.ToString();

                // Display the total sales
                totalLabel.Text = total.ToString("c");
            }
            else
            {
                MessageBox.Show("Sorry, " + lemonLime.Name + " is sold out.");
            }
        }

        private void grapeSodaPictureBox_Click(object sender, EventArgs e)
        {
            // Declare variables
            int count;              // To hold the drink count

            // Create a Drink object
            Drink grapeSoda = new Drink();

            // Set the objects's Name property
            grapeSoda.Name = (string)softDrink[3, 0];
            grapeSoda.Cost = (decimal)softDrink[3, 1];
            grapeSoda.Amount = (int)softDrink[3, 2];

            if (totalGrapeSodaCount > 0)
            {
                grapeSoda.Amount = (int)softDrink[3, 2];

                count = grapeSoda.Amount - 1;

                // Get a new count
                totalGrapeSodaCount = count;

                // Change lemon lime amount
                softDrink[3, 2] = totalGrapeSodaCount;

                // Get a sales amount
                sales = grapeSoda.Cost;

                // Add the sales amount to total
                total += sales;

                // Display the drinks left  
                grapeSodaLabel.Text = totalGrapeSodaCount.ToString();

                // Display the total sales
                totalLabel.Text = total.ToString("c");
            }
            else
            {
                MessageBox.Show("Sorry, " + grapeSoda.Name + " is sold out.");
            } // end else 
        }

        private void creamSodaPictureBox_Click(object sender, EventArgs e)
        {
            // Declare variables
            int count;              // To hold the drink count

            // Create a Drink object
            Drink creamSoda = new Drink();

            // Set the objects's Name property
            creamSoda.Name = (string)softDrink[4, 0];
            creamSoda.Cost = (decimal)softDrink[4, 1];
            creamSoda.Amount = (int)softDrink[4, 2];

            if (totalCreamSodaCount > 0)
            {
                creamSoda.Amount = (int)softDrink[4, 2];

                count = creamSoda.Amount - 1;

                // Get a new count
                totalCreamSodaCount = count;

                // Change cream soda amount
                softDrink[4, 2] = totalCreamSodaCount;

                // Get a sales amount
                sales = creamSoda.Cost;

                // Add the sales amount to total
                total += sales;

                // Display the drinks left  
                creamSodaLabel.Text = totalCreamSodaCount.ToString();

                // Display the total sales
                totalLabel.Text = total.ToString("c");
            }
            else
            {
                MessageBox.Show("Sorry, " + creamSoda.Name + " is sold out.");
            } // end else 
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
