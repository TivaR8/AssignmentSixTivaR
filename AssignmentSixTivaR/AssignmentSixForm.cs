using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
/*
 * Created by: Tiva Rait
 * Created on: May-21-2018
 * Created for: ICS3U Programming
 * Assignment 6b A Better Game of 21
 * This program is a better game of 21 that the user can play against the computer 
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

        // User's Total
        int userTotal;

        // Computer's Total
        int computerTotal;

        // To place the picture boxes in the correct places 
        int userLastPictureBoxX = 136;
        int userLastPictureBoxY = 295;
        int computerLastPictureBoxX = 136;
        int computerLastPictureBoxY = 94;

        // Number of picture boxes that have been created
        int numOfPicBoxes;


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
            this.ResetAll();
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

            // Clear card deck
            cardDeck.Clear();

            // Add all of the Cards to the cardDeck 
            cardDeck.Add("A H");
            cardDeck.Add("A D");
            cardDeck.Add("A C");
            cardDeck.Add("A S");

            cardDeck.Add("2 H");
            cardDeck.Add("2 D");
            cardDeck.Add("2 C");
            cardDeck.Add("2 S");

            cardDeck.Add("3 H");
            cardDeck.Add("3 D");
            cardDeck.Add("3 C");
            cardDeck.Add("3 S");

            cardDeck.Add("4 H");
            cardDeck.Add("4 D");
            cardDeck.Add("4 C");
            cardDeck.Add("4 S");

            cardDeck.Add("5 H");
            cardDeck.Add("5 D");
            cardDeck.Add("5 C");
            cardDeck.Add("5 S");

            cardDeck.Add("6 H");
            cardDeck.Add("6 D");
            cardDeck.Add("6 C");
            cardDeck.Add("6 S");

            cardDeck.Add("7 H");
            cardDeck.Add("7 D");
            cardDeck.Add("7 C");
            cardDeck.Add("7 S");

            cardDeck.Add("8 H");
            cardDeck.Add("8 D");
            cardDeck.Add("8 C");
            cardDeck.Add("8 S");

            cardDeck.Add("9 H");
            cardDeck.Add("9 D");
            cardDeck.Add("9 C");
            cardDeck.Add("9 S");

            cardDeck.Add("10 H");
            cardDeck.Add("10 D");
            cardDeck.Add("10 C");
            cardDeck.Add("10 S");

            cardDeck.Add("J H");
            cardDeck.Add("J D");
            cardDeck.Add("J C");
            cardDeck.Add("J S");

            cardDeck.Add("Q H");
            cardDeck.Add("Q D");
            cardDeck.Add("Q C");
            cardDeck.Add("Q S");

            cardDeck.Add("K H");
            cardDeck.Add("K D");
            cardDeck.Add("K C");
            cardDeck.Add("K S");

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
            // Update all of the text
            lblUserOverallScore.Text = ("Your Score: " + userOverallScore);
            lblComputerOverallScore.Text = ("Your Score: " + computerOverallScore);
            lblRounds.Text = ("Round " + roundsPlayed);
            lblUserCardTotal.Text = ("Card Total = 0");
            lblCompCardTotal.Text = ("Card Total = 0");

            // Set computers turn to be false just to be safe
            computerTurn = false;

            // Remove items from userHand and computerHand
            userHand.Clear();
            computerHand.Clear();

            // set totals to 0
            computerTotal = 0;
            userTotal = 0;

            ///////////////////////////////////////////////////////
            //Need to Delete picture boxes and everything from previous rounds
            ///////////////////////////////////////////////////////

            // Let the user take action
            grbUserAction.Enabled = true;

            // Make sure ace and eleven are hidden 
            grbAceElevenOrOne.Hide();
            // Remove generated picture boxes
            RemoveGeneratedPictureBoxes();

            // Set the values back to the original amounts for their locations
            userLastPictureBoxX = 136;
            userLastPictureBoxY = 295;
            computerLastPictureBoxX = 136;
            computerLastPictureBoxY = 94;

            if (cardDeck.Count() <= 8)
            {
                MessageBox.Show("Sorry we ran out of cards. Let's start over again.", "Dealer");
                
                this.ResetAll();
            }
            else
            {
                // Loop that will make sure the User is dealt at least two cards
                for (int counter = 0; counter < 2; counter++)
                {
                    this.DealUserNewCard();
                }
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


            // Debugging
            Console.WriteLine("randomUserCard = " + randomUserCard);
            Console.WriteLine("Number of Cards in cardDeck =" + cardDeck.Count());

            // Minus one for the randomUserCard
            randomUserCard = randomUserCard - 1;
            Console.WriteLine("randomUserCard = " + randomUserCard);

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
        // Input: cardValue
        // Output: void
        // Description: Calculate the users cards 
        private void CalculateUserCards (string cardValue)
        {
            if (cardValue == "A H" || cardValue == "A D" || cardValue == "A C" || cardValue == "A S")
            {
                grbAceElevenOrOne.Show();
                grbUserAction.Enabled = false;
            }
            else if (cardValue == "2 H" || cardValue == "2 D" || cardValue == "2 C" || cardValue == "2 S")
            {
                userTotal = (userTotal + 2);
            }
            else if (cardValue == "3 H" || cardValue == "3 D" || cardValue == "3 C" || cardValue == "3 S")
            {
                userTotal = (userTotal + 3);
            }
            else if (cardValue == "4 H" || cardValue == "4 D" || cardValue == "4 C" || cardValue == "4 S")
            {
                userTotal = (userTotal + 4);
            }
            else if (cardValue == "5 H" || cardValue == "5 D" || cardValue == "5 C" || cardValue == "5 S")
            {
                userTotal = (userTotal + 5);
            }
            else if (cardValue == "6 H" || cardValue == "6 D" || cardValue == "6 C" || cardValue == "6 S")
            {
                userTotal = (userTotal + 6);
            }
            else if (cardValue == "7 H" || cardValue == "7 D" || cardValue == "7 C" || cardValue == "7 S")
            {
                userTotal = (userTotal + 7);
            }
            else if (cardValue == "8 H" || cardValue == "8 D" || cardValue == "8 C" || cardValue == "8 S")
            {
                userTotal = (userTotal + 8);
            }
            else if (cardValue == "9 H" || cardValue == "9 D" || cardValue == "9 C" || cardValue == "9 S")
            {
                userTotal = (userTotal + 9);
            }
            else
            {
                userTotal = (userTotal + 10);
            }

            lblUserCardTotal.Text = ("Card Total = " + userTotal);

            if (userTotal > 15)
            {
                MessageBox.Show("The odds are not in your favour, " +
                    "you should probably press stay", "Warning");
            }

            if (userTotal > BLACKJACK)
            {
                FindWinner();
            }
        }

        // Function: DisplayCard
        // Input: newCard
        // Output: void
        // Description: To display the correct cards in the right places.
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

            numOfPicBoxes = numOfPicBoxes + 1;
        }

        // Function: GeneratePictureBox
        // Input: int x, int y, string newCard
        // Output: void
        // Description:
        private void GeneratePictureBox(int x, int y, string newCard)
        {
            // Dynamically generate a new picture box and a new point at the given location
            PictureBox tmpPicCard = new PictureBox();
            Point pntPic = new System.Drawing.Point(x, y);

            // Set the location of the picturebox
            tmpPicCard.Location = pntPic;

            // Assign the image to the pictureBox 
            if (newCard == "A H")
            {
                tmpPicCard.Image = Properties.Resources.AH;
            }
            else if (newCard == "A D")
            {
                tmpPicCard.Image = Properties.Resources.AD;
            }
            else if (newCard == "A C")
            {
                tmpPicCard.Image = Properties.Resources.AC;
            }
            else if (newCard == "A S")
            {
                tmpPicCard.Image = Properties.Resources.AS;
            }
            else if (newCard == "2 H")
            {
                tmpPicCard.Image = Properties.Resources._2H;
            }
            else if (newCard == "2 D")
            {
                tmpPicCard.Image = Properties.Resources._2D;
            }
            else if (newCard == "2 C")
            {
                tmpPicCard.Image = Properties.Resources._2C;
            }
            else if (newCard == "2 S")
            {
                tmpPicCard.Image = Properties.Resources._2S;
            }
            else if (newCard == "3 H")
            {
                tmpPicCard.Image = Properties.Resources._3H;
            }
            else if (newCard == "3 D")
            {
                tmpPicCard.Image = Properties.Resources._3D;
            }
            else if (newCard == "3 C")
            {
                tmpPicCard.Image = Properties.Resources._3C;
            }
            else if (newCard == "3 S")
            {
                tmpPicCard.Image = Properties.Resources._3S;
            }
            else if (newCard == "4 H")
            {
                tmpPicCard.Image = Properties.Resources._4H;
            }
            else if (newCard == "4 D")
            {
                tmpPicCard.Image = Properties.Resources._4D;
            }
            else if (newCard == "4 C")
            {
                tmpPicCard.Image = Properties.Resources._4C;
            }
            else if (newCard == "4 S")
            {
                tmpPicCard.Image = Properties.Resources._4S;
            }
            else if (newCard == "5 H")
            {
                tmpPicCard.Image = Properties.Resources._5H;
            }
            else if (newCard == "5 D")
            {
                tmpPicCard.Image = Properties.Resources._5D;
            }
            else if (newCard == "5 C")
            {
                tmpPicCard.Image = Properties.Resources._5C;
            }
            else if (newCard == "5 S")
            {
                tmpPicCard.Image = Properties.Resources._5S;
            }
            else if (newCard == "6 H")
            {
                tmpPicCard.Image = Properties.Resources._6H;
            }
            else if (newCard == "6 D")
            {
                tmpPicCard.Image = Properties.Resources._6D;
            }
            else if (newCard == "6 C")
            {
                tmpPicCard.Image = Properties.Resources._6C;
            }
            else if (newCard == "6 S")
            {
                tmpPicCard.Image = Properties.Resources._6S;
            }
            else if (newCard == "7 H")
            {
                tmpPicCard.Image = Properties.Resources._7H;
            }
            else if (newCard == "7 D")
            {
                tmpPicCard.Image = Properties.Resources._7D;
            }
            else if (newCard == "7 C")
            {
                tmpPicCard.Image = Properties.Resources._7C;
            }
            else if (newCard == "7 S")
            {
                tmpPicCard.Image = Properties.Resources._7S;
            }
            else if (newCard == "8 H")
            {
                tmpPicCard.Image = Properties.Resources._8H;
            }
            else if (newCard == "8 D")
            {
                tmpPicCard.Image = Properties.Resources._8D;
            }
            else if (newCard == "8 C")
            {
                tmpPicCard.Image = Properties.Resources._8C;
            }
            else if (newCard == "8 S")
            {
                tmpPicCard.Image = Properties.Resources._8S;
            }
            else if (newCard == "9 H")
            {
                tmpPicCard.Image = Properties.Resources._9H;
            }
            else if (newCard == "9 D")
            {
                tmpPicCard.Image = Properties.Resources._9D;
            }
            else if (newCard == "9 C")
            {
                tmpPicCard.Image = Properties.Resources._9C;
            }
            else if (newCard == "9 S")
            {
                tmpPicCard.Image = Properties.Resources._9S;
            }
            else if (newCard == "10 H")
            {
                tmpPicCard.Image = Properties.Resources._10H;
            }
            else if (newCard == "10 D")
            {
                tmpPicCard.Image = Properties.Resources._10D;
            }
            else if (newCard == "10 C")
            {
                tmpPicCard.Image = Properties.Resources._10C;
            }
            else if (newCard == "10 S")
            {
                tmpPicCard.Image = Properties.Resources._10S;
            }
            else if (newCard == "J H")
            {
                tmpPicCard.Image = Properties.Resources.JH;
            }
            else if (newCard == "J D")
            {
                tmpPicCard.Image = Properties.Resources.JD;
            }
            else if (newCard == "J C")
            {
                tmpPicCard.Image = Properties.Resources.JC;
            }
            else if (newCard == "J S")
            {
                tmpPicCard.Image = Properties.Resources.JS;
            }
            else if (newCard == "Q H")
            {
                tmpPicCard.Image = Properties.Resources.QH;
            }
            else if (newCard == "Q D")
            {
                tmpPicCard.Image = Properties.Resources.QD;
            }
            else if (newCard == "Q C")
            {
                tmpPicCard.Image = Properties.Resources.QC;
            }
            else if (newCard == "Q S")
            {
                tmpPicCard.Image = Properties.Resources.QS;
            }
            else if (newCard == "K H")
            {
                tmpPicCard.Image = Properties.Resources.KH;
            }
            else if (newCard == "K D")
            {
                tmpPicCard.Image = Properties.Resources.KD;
            }
            else if (newCard == "K C")
            {
                tmpPicCard.Image = Properties.Resources.JC;
            }
            else if (newCard == "K S")
            {
                tmpPicCard.Image = Properties.Resources.KS;
            }
            else
            {
                tmpPicCard.Image = Properties.Resources.Front;
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
            for (int counter = 1; counter <= numOfPicBoxes; counter++)
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

        private void btnAceOne_Click(object sender, EventArgs e)
        {

            userTotal = (userTotal + 1);

            grbUserAction.Enabled = true;

            grbAceElevenOrOne.Hide();
        }

        private void btnAceEleven_Click(object sender, EventArgs e)
        {

            userTotal = (userTotal + 11);

            grbUserAction.Enabled = true;

            grbAceElevenOrOne.Hide();
        }

        // Function: DealComputerNewCard
        // Input: None
        // Output: newComputerCard
        // Description: Selects the computer's new cards
        private void DealComputerNewCard()
        {
            // To stop the user from taking any more actions
            grbUserAction.Enabled = false;

            // Local variables
            int randomComputerCard;
            string newComputerCard;

            // Set the max num to be equal to how many cards are left in the deck
            maxNum = cardDeck.Count();

            // Randomly generate the index Number
            randomComputerCard = randomNumberGenerator.Next(MIN_NUM, maxNum + 1);

            // Debugging
            Console.WriteLine("randomComputerCard = " + randomComputerCard);
            Console.WriteLine("Number of Cards in cardDeck =" + cardDeck.Count());

            // Minus one for the randomUserCard
            randomComputerCard = randomComputerCard - 1;
            Console.WriteLine("randomComputerCard = " + randomComputerCard);

            // Add the card from cardDeck to userHand 
            newComputerCard = cardDeck[randomComputerCard];

            computerHand.Add(newComputerCard);

            // Delete the card from cardDeck
            cardDeck.RemoveAt(randomComputerCard);

            // Calculate the user's cards together
            this.CalculateComputerCards(newComputerCard);

            // Display the card
            // First Set the computer turn bool to be true
            computerTurn = true;
            this.DisplayCard(newComputerCard);

        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            DealComputerNewCard();
        }

        // Function: CalculateComputerCards
        // Input: computerValue
        // Output: void
        // Description: Calculate the computer cards 
        private void CalculateComputerCards(string cardValue)
        {
            if (cardValue == "A H" || cardValue == "A D" || cardValue == "A C" || cardValue == "A S")
            {
                if (computerTotal <= 9)
                {
                    computerTotal = (computerTotal + 11);
                }
                else
                {
                    computerTotal = (computerTotal + 1);
                }
            }
            else if (cardValue == "2 H" || cardValue == "2 D" || cardValue == "2 C" || cardValue == "2 S")
            {
                computerTotal = (computerTotal + 2);
            }
            else if (cardValue == "3 H" || cardValue == "3 D" || cardValue == "3 C" || cardValue == "3 S")
            {
                computerTotal = (computerTotal + 3);
            }
            else if (cardValue == "4 H" || cardValue == "4 D" || cardValue == "4 C" || cardValue == "4 S")
            {
                computerTotal = (computerTotal + 4);
            }
            else if (cardValue == "5 H" || cardValue == "5 D" || cardValue == "5 C" || cardValue == "5 S")
            {
                computerTotal = (computerTotal + 5);
            }
            else if (cardValue == "6 H" || cardValue == "6 D" || cardValue == "6 C" || cardValue == "6 S")
            {
                computerTotal = (computerTotal + 6);
            }
            else if (cardValue == "7 H" || cardValue == "7 D" || cardValue == "7 C" || cardValue == "7 S")
            {
                computerTotal = (computerTotal + 7);
            }
            else if (cardValue == "8 H" || cardValue == "8 D" || cardValue == "8 C" || cardValue == "8 S")
            {
                computerTotal = (computerTotal + 8);
            }
            else if (cardValue == "9 H" || cardValue == "9 D" || cardValue == "9 C" || cardValue == "9 S")
            {
                computerTotal = (computerTotal + 9);
            }
            else
            {
                computerTotal = (computerTotal + 10);
            }

            lblCompCardTotal.Text = ("Card Total = " + computerTotal);

            if (computerTotal > 14)
            {
                FindWinner();
            }
            else
            {
                DealComputerNewCard();
            }

        }

        // FindWinner
        public void FindWinner()
        {
            // Set computer turn to be false
            computerTurn = false;

            // To slow the game down and give the user time to process what is happening

            // Find the winner
            if (userTotal > BLACKJACK && computerTotal < BLACKJACK)
            {
                computerOverallScore = (computerOverallScore + 1);

                MessageBox.Show("You lost " +
                    "select New Game to continue", "Results");
                roundsPlayed = (roundsPlayed + 1);
            }
            else if (computerTotal > BLACKJACK && userTotal < BLACKJACK)
            {
                userOverallScore = (userOverallScore + 1);
                MessageBox.Show("You won " +
                    "select New Game to continue", "Results");
                roundsPlayed = (roundsPlayed + 1);
            }
            else if (computerTotal > BLACKJACK && userTotal > BLACKJACK)
            {
                MessageBox.Show("It's a tie " +
                    "select New Game to continue", "Results");
                roundsPlayed = (roundsPlayed + 1);
            }
            else if (computerTotal == BLACKJACK && userTotal == BLACKJACK)
            {
                MessageBox.Show("It's a tie " +
                    "select New Game to continue", "Results");
                roundsPlayed = (roundsPlayed + 1);
            }
            else if (computerTotal == BLACKJACK)
            {
                computerOverallScore = (computerOverallScore + 1);

                MessageBox.Show("You lost to a blackjack " +
                    "select New Game to continue", "Results");
                roundsPlayed = (roundsPlayed + 1);
            }
            else if (userTotal == BLACKJACK)
            {
                userOverallScore = (userOverallScore + 1);
                MessageBox.Show("You won with a blackjack " +
                    "select New Game to continue", "Results");
                roundsPlayed = (roundsPlayed + 1);
            }
            else if (computerTotal == BLACKJACK && computerHand.Count() == 2)
            {
                computerOverallScore = (computerOverallScore + 2);

                MessageBox.Show("You lost to a special blackjack " +
                    "select New Game to continue", "Results");
                roundsPlayed = (roundsPlayed + 1);
            }
            else if (userTotal == BLACKJACK && userHand.Count() == 2)
            {
                userOverallScore = (userOverallScore + 2);
                MessageBox.Show("You won with a special blackjack " +
                    "select New Game to continue", "Results");
                roundsPlayed = (roundsPlayed + 1);
            }
            else if (computerTotal > userTotal)
            {
                computerOverallScore = (computerOverallScore + 1);
                MessageBox.Show("You lost " +
                    "select New Game to continue", "Results");
                roundsPlayed = (roundsPlayed + 1);
            }
            else if (computerTotal < userTotal)
            {
                userOverallScore = (userOverallScore + 1);
                MessageBox.Show("You won " +
                    "select New Game to continue", "Results");
                roundsPlayed = (roundsPlayed + 1);
            }
            else
            {
                MessageBox.Show("It's a tie " +
                    "select New Game to continue", "Results");
                roundsPlayed = (roundsPlayed + 1);
            }

            grbUserAction.Enabled = false;
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            DealUserNewCard();
        }

        private void mniNewGame_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }
    }
}
