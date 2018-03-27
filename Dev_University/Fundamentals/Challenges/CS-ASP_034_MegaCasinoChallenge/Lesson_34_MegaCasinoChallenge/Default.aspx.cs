using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lesson_34_MegaCasinoChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Image1.ImageUrl = "plum.png";
                Image2.ImageUrl = "clover.png";
                Image3.ImageUrl = "Horseshoe.png";
                moneyLabel.Text = 100.ToString();
            }
        }

        protected void leverButton_Click(object sender, EventArgs e)
        {
            int bet = Convert.ToInt32(betTextBox.Text);
            int userMoney = Convert.ToInt32(moneyLabel.Text);
            // Subtract bet from user's money.
            userMoney -= bet;

            // Pull the lever and randomize images.

          
            string image1 = spinReel();
            string image2 = spinReel();
            string image3 = spinReel();
           

            /*
            string image1 = "Seven";
            string image2 = "Seven";
            string image3 = "Seven";
            */

            image1 = image1 + ".png";
            image2 = image2 + ".png";
            image3 = image3 + ".png";

            Image1.ImageUrl = image1;
            Image2.ImageUrl = image2;
            Image3.ImageUrl = image3;

            string[] selectedImageArray = { image1, image2, image3 };

            string outputMessage = processImages(selectedImageArray);

            userMoney = processOutputMessage(outputMessage, bet, userMoney);
            moneyLabel.Text = userMoney.ToString();
        }

        Random random = new Random();

        private string spinReel()
        {
            string[] images = new string[] { "Strawberry", "Bar", "Lemon", "Bell", "Clover", "Cherry", "Diamond", "Orange", "Seven", "HorseShoe", "Plum", "Watermelon" };
            return images[random.Next(11)];
        }

        private string processImages(string[] imageArray)
        {
            int sevenCounter = 0;
            int cherryCounter = 0;

            for (int i = 0; i < imageArray.Length; i++)
            {
                if (imageArray[i] == "Bar.png")
                {
                    return "bar";
                }
                else if (imageArray[i] == "Seven.png")
                {
                    sevenCounter++;

                    if (sevenCounter == 3)
                    {
                        return "seven";
                    }
                }
                else if (imageArray[i] == "Cherry.png")
                {
                    cherryCounter++;
                }
            }

            if (cherryCounter == 1) return "cherry1";
            if (cherryCounter == 2) return "cherry2";
            if (cherryCounter == 3) return "cherry3";

            return "none";
        }

        private int processOutputMessage(string outputMessage, int bet, int userMoney)
        {
            if (outputMessage == "bar")
            {
                resultLabel.Text = String.Format("Sorry, you lost {0:C}.  Better luck next time!", bet);
            }
            else if (outputMessage == "seven")
            {
                int winnings = 100 * bet;
                userMoney += winnings;
                moneyLabel.Text = userMoney.ToString();
                resultLabel.Text = String.Format("You bet {0:C} and won {1:C}!", bet, winnings);

            }
            else if (outputMessage == "cherry1")
            {
                int winnings = 2 * bet;
                userMoney += winnings;
                moneyLabel.Text = (userMoney + winnings).ToString();
                resultLabel.Text = String.Format("You bet {0:C} and won {1:C}!", bet, winnings);
            }
            else if (outputMessage == "cherry2")
            {
                int winnings = 3 * bet;
                userMoney += winnings;
                moneyLabel.Text = (userMoney + winnings).ToString();
                resultLabel.Text = String.Format("You bet {0:C} and won {1:C}!", bet, winnings);
            }
            else if (outputMessage == "cherry3")
            {
                int winnings = 4 * bet;
                userMoney += winnings;
                moneyLabel.Text = (userMoney + winnings).ToString();
                resultLabel.Text = String.Format("You bet {0:C} and won {1:C}!", bet, winnings);
            }
            else
            {
                resultLabel.Text = String.Format("Sorry, you lost {0:C}.  Better luck next time!", bet);
            }

            return userMoney;

        }
    }
}