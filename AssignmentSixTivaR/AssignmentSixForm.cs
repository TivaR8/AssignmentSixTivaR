using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: May-21-2018
 * Created for: ICS3U Programming
 * Assignment 6b A Better Game of 21
 * This program is a better game of 21 that the user can play against the computer 
*/


    // Tiva's Notes!!!!!!
    /*
     * Generate cards is not finished
     * Calculate Users cards are not finished 
     * Test the generating of the Picture Boxes
     */
namespace AssignmentSixTivaR
{
    public partial class frmAssignmentSix : Form
    {
        // Declare constant public variables
        const int BLACKJACK = 21;
        const int MIN_NUM = 1;
        const int DIFF_BETWEEN_CARDS = 136;

        // Declare global variables
        int userOverallScore = 0;
        int computerOverallScore = 0;
        int roundsPlayed = 0;
        bool computerTurn = false;
        int maxNum;

        // To place the picture boxes in the correct places 
        int userLastPictureBoxX = 136;
        int userLastPictureBoxY = 295;
        int computerLastPictureBoxX = 136;
        int computerLastPictureBoxY = 94;


        // To make the random number generator
        Random randomNumberGenerator = new Random();

        // Create the Card Deck list that will be used
        List<String> cardDeck = new List<String>();

        // Create the users hand and the computers hand
        List<String> userHand = new List<String>();

        List<String> computerHand = new List<String>();



        public frmAssignmentSix()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Function: ResetAll
        // Input: None
        // Output: void
        // Description: This resets ALL of the data and scores in the game
        public void ResetAll()
        {
            // Set all of the global variables back to original status
            userOverallScore = 0;
            lblUserOverallScore.Text = ("Your Score: " + userOverallScore);
            computerOverallScore = 0;
            lblComputerOverallScore.Text = ("Your Score: " + computerOverallScore);
            roundsPlayed = 0;
            lblRounds.Text = ("Round " + roundsPlayed);


            // Add all of the Cards to the cardDeck 
            cardDeck.Add("AH");
            cardDeck.Add("AD");
            cardDeck.Add("AC");
            cardDeck.Add("AS");

            cardDeck.Add("2H");
            cardDeck.Add("2D");
            cardDeck.Add("2C");
            cardDeck.Add("2S");

            cardDeck.Add("3H");
            cardDeck.Add("3D");
            cardDeck.Add("3C");
            cardDeck.Add("3S");

            cardDeck.Add("4H");
            cardDeck.Add("4D");
            cardDeck.Add("4C");
            cardDeck.Add("4S");

            cardDeck.Add("5H");
            cardDeck.Add("5D");
            cardDeck.Add("5C");
            cardDeck.Add("5S");

            cardDeck.Add("6H");
            cardDeck.Add("6D");
            cardDeck.Add("6C");
            cardDeck.Add("6S");

            cardDeck.Add("7H");
            cardDeck.Add("7D");
            cardDeck.Add("7C");
            cardDeck.Add("7S");

            cardDeck.Add("8H");
            cardDeck.Add("8D");
            cardDeck.Add("8C");
            cardDeck.Add("8S");

            cardDeck.Add("9H");
            cardDeck.Add("9D");
            cardDeck.Add("9C");
            cardDeck.Add("9S");

            cardDeck.Add("10H");
            cardDeck.Add("10D");
            cardDeck.Add("10C");
            cardDeck.Add("10S");

            cardDeck.Add("JH");
            cardDeck.Add("JD");
            cardDeck.Add("JC");
            cardDeck.Add("JS");

            cardDeck.Add("QH");
            cardDeck.Add("QD");
            cardDeck.Add("QC");
            cardDeck.Add("QS");

            cardDeck.Add("KH");
            cardDeck.Add("KD");
            cardDeck.Add("KC");
            cardDeck.Add("KS");

            // Acess the Start New Game Function
            this.StartNewGame();
        }

        private void mniReset_Click(object sender, EventArgs e)
        {
            this.ResetAll();
        }

        // Function: StartNewGame
        // Input: None
        // Output: void
        // Description: Starts a new round or "New game"
        private void StartNewGame()
        {
            // Set computers turn to be false just to be safe
            computerTurn = false;

            // Remove items from userHand and computerHand
            userHand.Clear();
            computerHand.Clear();

            ///////////////////////////////////////////////////////
            //Need to Delete picture boxes and everything from previous rounds
            ///////////////////////////////////////////////////////

            // Remove generated picture boxes
            this.RemoveGeneratedPictureBoxes();

            // Set the values back to the original amounts for their locations
            userLastPictureBoxX = 136;
            userLastPictureBoxY = 295;
            computerLastPictureBoxX = 136;
            computerLastPictureBoxY = 94;

            // Loop that will make sure the User is dealt at least two cards
            for (int counter = 0; counter <= 2; counter++)
            {
                this.DealUserNewCard();
            }

        }

        // Function: DealUserNewCard
        // Input: None
        // Output: newUserCard
        // Description: Selects the users new cards
        private void DealUserNewCard()
        {
            // Local variables
            int randomUserCard;
            string newUserCard;

            // Set the max num to be equal to how many cards are left in the deck
            maxNum = cardDeck.Count();

            // Randomly generate the index Number
            randomUserCard = randomNumberGenerator.Next(MIN_NUM, maxNum + 1);

            // Add the card from cardDeck to userHand 
            newUserCard = cardDeck[randomUserCard];

            userHand.Add(newUserCard);

            // Delete the card from cardDeck
            cardDeck.RemoveAt(randomUserCard);

            // Calculate the user's cards together
            this.CalculateUserCards(newUserCard);

            // Display the card
            this.DisplayCard(newUserCard);

        }

        // Function: CalculateUserCards
        // Input: 
        // Output:
        // Description:
        private void CalculateUserCards (string cardValue)
        {

        }

        // Function: 
        // Input:
        // Output:
        // Description:
        private void DisplayCard(string newCard)
        {
            // Set the appropriate places for the picture boxes and change the y value
            if (computerTurn == true)
            {
                computerLastPictureBoxX = computerLastPictureBoxX + 121;
                GeneratePictureBox(computerLastPictureBoxX, computerLastPictureBoxY, newCard);
            }
            else
            {
                userLastPictureBoxX = userLastPictureBoxX + 121;
                GeneratePictureBox(userLastPictureBoxX, userLastPictureBoxY, newCard);
            }


        }

        // Function: 
        // Input:
        // Output:
        // Description:
        private void GeneratePictureBox(int x, int y, string newCard)
        {
            // Dynamically generate a new picture box and a new point at the given location
            PictureBox tmpPicCard = new PictureBox();
            Point pntPic = new System.Drawing.Point(x, y);

            // Set the location of the picturebox
            tmpPicCard.Location = pntPic;

            // Assign the image to the pictureBox 
            if (newCard == "AH")
            {
                if (computerTurn == true)
                {
                    tmpPicCard.Image = Properties.Resources.AH;
                }
                else
                {
                    tmpPicCard.Image = Properties.Resources.AH;
                }
            }

            // stretch the image to the size of the picture box
            tmpPicCard.SizeMode = PictureBoxSizeMode.StretchImage;

            // Set the picture box size
            tmpPicCard.ClientSize = new Size(115, 130);

            // Add the picture box to the form
            this.Controls.Add(tmpPicCard);
        }

        // Function: RemoveGeneratedPictureBoxes 
        // Input:
        // Output:
        // Description:
        private void RemoveGeneratedPictureBoxes ()
        {
            foreach (Control control in this.Controls)
            {
                PictureBox picture = control as PictureBox;
                if (picture != null)
                {
                    this.Controls.Remove(picture);
                }
            }
            
        }
    }
}
