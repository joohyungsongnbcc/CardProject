using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BOLayer;

namespace MyCardGame
{
    public partial class Form1 : Form
    {
        private Deck aDeck;
        /*private Hand hand1;
        private Hand hand2;*/
        private int playerTotal = 0;
        

        public Form1()
        {
            InitializeComponent();
        }


        private void SetUp()
        {
            try
            {
                Panel21.Controls.Clear();
                Card aCard;
                string imgPath = @"images\cardback.gif";

                PictureBox pic = new PictureBox()
                {
                    Image = Image.FromFile(imgPath),
                    Width = 70,
                    Height = 100,
                    Left = 75
                };
                Panel21.Controls.Add(pic);

                ShowCard(Panel22, GenerateCard());

                /*                string faceName = aCard.FaceValue.ToString();
                                string suitName = aCard.Suit.ToString();
                */
                /*string imgPath2 = $@"images\{aCard.FaceValue}{aCard.Suit}.jpg";

                PictureBox pic2 = new PictureBox()
                {
                    Image = Image.FromFile(imgPath),
                    Width = 70,
                    Height = 100,
                    Left = 75
                };*/
                /*try
                {
                    Hand hand2 = aDeck.DealHand(1);
                    ShowHand(Panel2, hand2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }*/
               
                aDeck = new Deck();
                aDeck.Shuffle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetUp();
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            try
            {
                Hand aHand = aDeck.DealHand(2);
                ShowHand(Panel1, aHand);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private Card GenerateCard()
        {
            Random myRandom = new Random();

            //The random min value is INCLUSIVE, and the max value is EXCLUSIVE
            Suit suit = (Suit)myRandom.Next(0, 4);
            FaceValue face = (FaceValue)myRandom.Next(0, 13);

            return new Card(suit, face);
        }

        private void ShowCard(Panel thePanel, Card theCard)
        {
      /*     thePanel.Controls.Clear();
*/
            string faceName = theCard.FaceValue.ToString();
            string suitName = theCard.Suit.ToString();

            string imgPath = $@"images\{faceName}{suitName}.jpg";

            PictureBox pic = new PictureBox()
            {
                Image = Image.FromFile(imgPath),
                Width = 70,
                Height = 100,
                Left = 10
            };

            thePanel.Controls.Add(pic);
        }
        private void ShowHand(Panel thePanel, Hand theHand)
        {
            thePanel.Controls.Clear();

            Card aCard;
            PictureBox aPic;

            for (int i = 0; i < theHand.Count; i++)
            {
                aCard = theHand[i];
                string path = $@"images\{aCard.FaceValue}{aCard.Suit}.jpg";

                /*aPic = new PictureBox();
                aPic.Image = Image.FromFile(path);*/
                aPic = new PictureBox()
                {
                    Image = Image.FromFile(path),
                    Text = aCard.FaceValue.ToString(),
                    Width = 71,
                    Height = 100,
                    Left = 75 * i
                };

                thePanel.Controls.Add(aPic);

            }
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            try
            {
                Hand aHand = aDeck.DealHand(1);
                ShowHand(Panel1, aHand);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}