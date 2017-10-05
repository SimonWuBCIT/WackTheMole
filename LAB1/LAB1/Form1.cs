using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;
using System.Media;

namespace LAB1
{
    public partial class Form1 : Form
    {
        ConcurrentQueue<int> dataQueue = new ConcurrentQueue<int>();
        Queue<int> xQueue = new Queue<int>(100);
        Queue<int> yQueue = new Queue<int>(100);
        Queue<int> zQueue = new Queue<int>(100);

        int xacceleration;
        int yacceleration;
        int zacceleration;

        double xavg;
        double yavg;
        double zavg;

        int countqueue = 0;
        int count1 = 0;
        int count2 = 0;
        int count3 = 0;
        int count4 = 0;

        bool gowestunlock = false;
        bool gowestunlockalt = true;

        bool frisbeeunlock1 = false;
        bool frisbeeunlock2 = false;
        bool frisbeeunlockalt = true;

        bool waveunlock1 = false;
        bool waveunlock2 = false;
        bool waveunlock3 = false;

        //Game Stuff
        PictureBox hand = new PictureBox();

        PictureBox roach1 = new PictureBox();
        PictureBox roach2 = new PictureBox();
        PictureBox roach3 = new PictureBox();

        int gamemovecounter = 0;
        
        int[] horizontalposition = {1, 4, 7};
        int[] verticalposition = { 1, 4, 7 };
        int horizontal;
        int vertical;
        Random randomnum = new Random();

        int killcounter = 0;
        int misscounter = 0;

        bool gamestart = false;
        int gametimer = 0;
        int gamecounter = 0;

        SoundPlayer killsound = new SoundPlayer(@"C:\Users\simon\Box Sync\UBC\Courses\MECH 423\Lab\Lab 1\Lab 1 Simon\LAB1\Game\Slap-SoundMaster13-49669815.wav");
        SoundPlayer misssound = new SoundPlayer(@"C:\Users\simon\Box Sync\UBC\Courses\MECH 423\Lab\Lab 1\Lab 1 Simon\LAB1\Game\Swoosh 3-SoundBible.com-1573211927.wav");
        SoundPlayer timesup = new SoundPlayer(@"C:\Users\simon\Box Sync\UBC\Courses\MECH 423\Lab\Lab 1\Lab 1 Simon\LAB1\Game\Triangle Dinner Bell-SoundBible.com-220988408.wav");

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if(comboBoxPortSelect.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a serial port!");
            }
            else
            {
                if (serialPort1.IsOpen == false)
                {
                    string selectedPort = comboBoxPortSelect.SelectedItem.ToString();
                    serialPort1.PortName = selectedPort.ToString();
                    serialPort1.Open();
                    timer1.Enabled = true;
                    buttonConnect.Text = "Disconnect";
                    comboBoxPortSelect.Enabled = false;
                }
                else
                {
                    serialPort1.Close();
                    buttonConnect.Text = "Connect";
                    comboBoxPortSelect.Enabled = true;
                }
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            serialPort1.BaudRate = 128000;

            while(serialPort1.IsOpen == true && serialPort1.BytesToRead != 0)
            {
                try
                {
                    dataQueue.Enqueue(serialPort1.ReadByte());
                }
                catch
                {

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int measure;

            while(dataQueue.Count > 4)
            {
                dataQueue.TryDequeue(out measure);

                if(measure == 255)
                {
                    dataQueue.TryDequeue(out xacceleration);
                    dataQueue.TryDequeue(out yacceleration);
                    dataQueue.TryDequeue(out zacceleration);

                    xQueue.Enqueue(xacceleration);
                    yQueue.Enqueue(yacceleration);
                    zQueue.Enqueue(zacceleration);
                    countqueue++;

                    textBoxXAcc.Text = xacceleration.ToString();
                    textBoxYAcc.Text = yacceleration.ToString();
                    textBoxZAcc.Text = zacceleration.ToString();
                }

                if(countqueue >= 100)
                {

                    xavg = xQueue.Average();
                    yavg = yQueue.Average();
                    zavg = zQueue.Average();

                    textBoxXAvg.Text = xavg.ToString();
                    textBoxYAvg.Text = yavg.ToString();
                    textBoxZAvg.Text = zavg.ToString();

                    textBoxXMax.Text = xQueue.Max().ToString();
                    textBoxYMax.Text = yQueue.Max().ToString();
                    textBoxZMax.Text = zQueue.Max().ToString();

                    xQueue.Clear();
                    yQueue.Clear();
                    zQueue.Clear();

                    if(zavg > 155)
                    {
                        pictureBoxOrientation.Image = new Bitmap(@"C:\Users\Jennifer\Box Sync\UBC\Courses\MECH 423\Lab\Lab 1\Lab 1 Simon\LAB1\Orientation\Top.png");
                    }
                    else if(zavg < 100)
                    {
                        pictureBoxOrientation.Image = new Bitmap(@"C:\Users\Jennifer\Box Sync\UBC\Courses\MECH 423\Lab\Lab 1\Lab 1 Simon\LAB1\Orientation\Bottom.png");
                    }
                    else if(yavg > 155)
                    { 
                        pictureBoxOrientation.Image = new Bitmap(@"C:\Users\Jennifer\Box Sync\UBC\Courses\MECH 423\Lab\Lab 1\Lab 1 Simon\LAB1\Orientation\Left.png");
                    }
                    else if(yavg < 100)
                    {
                        pictureBoxOrientation.Image = new Bitmap(@"C:\Users\Jennifer\Box Sync\UBC\Courses\MECH 423\Lab\Lab 1\Lab 1 Simon\LAB1\Orientation\Right.png");
                    }
                    else if(xavg > 155)
                    {
                        pictureBoxOrientation.Image = new Bitmap(@"C:\Users\Jennifer\Box Sync\UBC\Courses\MECH 423\Lab\Lab 1\Lab 1 Simon\LAB1\Orientation\Front.png");
                    }
                    else if(xavg < 90)
                    {
                        pictureBoxOrientation.Image = new Bitmap(@"C:\Users\Jennifer\Box Sync\UBC\Courses\MECH 423\Lab\Lab 1\Lab 1 Simon\LAB1\Orientation\Back.png");
                    }

                    countqueue = 0;
                }

                //Motion
                if(true)
                {
                    if ((yacceleration > 180 || gowestunlock == true) && gowestunlockalt == true)
                    {
                        gowestunlock = true;
                        textBoxAction.Text = "Go west, young man!";

                        //Wait one second then clear box
                        count1++;
                        if (count1 >= 10)
                        {
                            textBoxAction.Clear();
                            count1 = 0;
                            gowestunlock = false;
                        }
                    }
                    else if ((xacceleration > 180 || frisbeeunlock1 == true) && frisbeeunlockalt == true)
                    {
                        frisbeeunlock1 = true;
                        gowestunlockalt = false;
                        count2++;
                        if (count2 <= 10 && yacceleration > 180 || frisbeeunlock2 == true)
                        {
                            frisbeeunlock2 = true;
                            textBoxAction.Text = "Frisbee.";
                            count2 = 0;

                            //Wait one second then clear box
                            count1++;
                            if (count1 >= 10)
                            {
                                textBoxAction.Clear();
                                count1 = 0;
                                gowestunlockalt = true;
                                frisbeeunlock1 = false;
                                frisbeeunlock2 = false;
                            }
                        }
                        else if (count2 > 10)
                        {
                            count2 = 0;
                            gowestunlockalt = true;
                            frisbeeunlock1 = false;
                            frisbeeunlock2 = false;
                        }
                    }
                    else if (zacceleration > 180 || waveunlock1 == true)
                    {
                        gowestunlockalt = false;
                        frisbeeunlockalt = false;
                        waveunlock1 = true;
                        count3++;
                        if (count3 <= 10 && yacceleration > 150 || waveunlock2 == true)
                        {
                            waveunlock2 = true;
                            count4++;
                            if (count4 <= 10 && yacceleration < 100 || waveunlock3 == true)
                            {
                                waveunlock3 = true;
                                textBoxAction.Text = "Wave~";
                                count3 = 0;
                                count4 = 0;

                                //Wait one second then clear box
                                count1++;
                                if (count1 >= 10)
                                {
                                    textBoxAction.Clear();
                                    count1 = 0;
                                    gowestunlockalt = true;
                                    frisbeeunlockalt = true;
                                    waveunlock1 = false;
                                    waveunlock2 = false;
                                    waveunlock3 = false;
                                }
                            }
                            else if (count4 > 10)
                            {
                                count3 = 0;
                                count4 = 0;
                                gowestunlockalt = true;
                                frisbeeunlockalt = true;
                                waveunlock1 = false;
                                waveunlock2 = false;
                                waveunlock3 = false;
                            }
                        }
                        else if (count3 > 10)
                        {
                            count3 = 0;
                            count4 = 0;
                            gowestunlockalt = true;
                            frisbeeunlockalt = true;
                            waveunlock1 = false;
                            waveunlock2 = false;
                            waveunlock3 = false;
                        }
                    }
                }

                //GAME
                if (gamestart == true) //if startbutton is clicked
                {
                    gametimer++;
                    if(gametimer >= 600)
                    {
                        gamestart = false;
                        buttonStart.Text = "Start";
                        timesup.Play();
                        MessageBox.Show("Times Up!\nKilled: "+killcounter.ToString()+"\nMissed: "+misscounter.ToString()+"\nScore: "+(killcounter-misscounter).ToString());
                    }

                    progressBarTimeLeft.Maximum = 600;
                    progressBarTimeLeft.Value = gametimer;

                    //GAME SETUP
                    
                    if(pictureBoxGameBackground.Controls.Contains(roach1) == false)
                    {
                        //generate random number
                        horizontal = horizontalposition[randomnum.Next(0, 3)];
                        vertical = verticalposition[randomnum.Next(0, 3)];

                        pictureBoxGameBackground.Controls.Add(roach1);
                        roach1.Height = 40;
                        roach1.Width = 40;

                        roach1.Top = 45*vertical; //times 1, 4, or 7
                        roach1.Left = 45*horizontal;
                        roach1.Image = Image.FromFile(@"C:\Users\Jennifer\Box Sync\UBC\Courses\MECH 423\Lab\Lab 1\Lab 1 Simon\LAB1\Game\roach.gif");
                        roach1.SizeMode = PictureBoxSizeMode.StretchImage;
                        roach1.BackColor = Color.Transparent;
                    }
                    if (pictureBoxGameBackground.Controls.Contains(roach2) == false)
                    {
                        //generate random number
                        horizontal = horizontalposition[randomnum.Next(0, 3)];
                        vertical = verticalposition[randomnum.Next(0, 3)];

                        pictureBoxGameBackground.Controls.Add(roach2);
                        roach2.Height = 40;
                        roach2.Width = 40;

                        roach2.Top = 45*vertical; //times 1, 4, or 7
                        roach2.Left = 45*horizontal;
                        roach2.Image = Image.FromFile(@"C:\Users\Jennifer\Box Sync\UBC\Courses\MECH 423\Lab\Lab 1\Lab 1 Simon\LAB1\Game\roach.gif");
                        roach2.SizeMode = PictureBoxSizeMode.StretchImage;
                        roach2.BackColor = Color.Transparent;
                    }
                    if (pictureBoxGameBackground.Controls.Contains(roach3) == false)
                    {
                        //generate random number
                        horizontal = horizontalposition[randomnum.Next(0, 3)];
                        vertical = verticalposition[randomnum.Next(0, 3)];

                        pictureBoxGameBackground.Controls.Add(roach3);
                        roach3.Height = 40;
                        roach3.Width = 40;

                        roach3.Top = 45*vertical; //times 1, 4, or 7
                        roach3.Left = 45*horizontal;
                        roach3.Image = Image.FromFile(@"C:\Users\Jennifer\Box Sync\UBC\Courses\MECH 423\Lab\Lab 1\Lab 1 Simon\LAB1\Game\roach.gif");
                        roach3.SizeMode = PictureBoxSizeMode.StretchImage;
                        roach3.BackColor = Color.Transparent;
                    }

                    //Game Movement
                    gamemovecounter--;
                    if(gamemovecounter <= 0)
                    {
                        gamemovecounter = 0;
                    }

                    if(xacceleration < 90 && gamemovecounter == 0)
                    {
                        if(hand.Top > 45)
                        {
                            hand.Top = hand.Top - 45 * 3;
                        }
                        gamemovecounter = 5;
                    }
                    else if (xacceleration > 180 && gamemovecounter == 0)
                    {
                        if (hand.Top < 45*7)
                        {
                            hand.Top = hand.Top + 45 * 3;
                        }
                        gamemovecounter = 5;
                    }
                    else if (yacceleration < 90 && gamemovecounter == 0)
                    {
                        if(hand.Left > 45)
                        {
                            hand.Left = hand.Left - 45 * 3;
                        }
                        gamemovecounter = 5;
                    }
                    else if (yacceleration > 180 && gamemovecounter == 0)
                    {
                        if(hand.Left < 45*7)
                        {
                            hand.Left = hand.Left + 45 * 3;
                        }
                        gamemovecounter = 5;
                    }

                    //Kill roach criteria
                    gamecounter--;
                    if(gamecounter <= 0)
                    {
                        gamecounter = 0;
                    }

                    if(zacceleration < 130 && gamemovecounter == 0)
                    {
                        if(hand.Bounds.IntersectsWith(roach1.Bounds))
                        {
                            pictureBoxGameBackground.Controls.Remove(roach1);
                            killcounter++;
                            textBoxKilled.Text = killcounter.ToString();
                            killsound.Play();
                        }
                        else if(hand.Bounds.IntersectsWith(roach2.Bounds))
                        {
                            pictureBoxGameBackground.Controls.Remove(roach2);
                            killcounter++;
                            textBoxKilled.Text = killcounter.ToString();
                            killsound.Play();
                        }
                        else if(hand.Bounds.IntersectsWith(roach3.Bounds))
                        {
                            pictureBoxGameBackground.Controls.Remove(roach3);
                            killcounter++;
                            textBoxKilled.Text = killcounter.ToString();
                            killsound.Play();
                        }
                        else
                        {
                            misscounter++;
                            textBoxMissed.Text = misscounter.ToString();
                            misssound.Play();
                        }
                        gamemovecounter = 5;
                    }
                    //add game stuffs
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }

        private void comboBoxPortSelect_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxPortSelect.Items.Clear();
            string[] portname = System.IO.Ports.SerialPort.GetPortNames().ToArray();
            comboBoxPortSelect.Items.AddRange(portname);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxGameBackground.BackgroundImage = new Bitmap(@"C:\Users\Jennifer\Box Sync\UBC\Courses\MECH 423\Lab\Lab 1\Lab 1 Simon\LAB1\Game\Tilesedit.jpg");
            
            pictureBoxGameBackground.Controls.Add(hand);
            hand.Height = 40;
            hand.Width = 40;
            hand.Top = 45*4;
            hand.Left = 45*4;
            hand.Image = Image.FromFile(@"C:\Users\Jennifer\Box Sync\UBC\Courses\MECH 423\Lab\Lab 1\Lab 1 Simon\LAB1\Game\hand.png");
            hand.SizeMode = PictureBoxSizeMode.StretchImage;
            hand.BackColor = Color.Transparent;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if(gamestart == false)
            {
                if(gametimer >= 600)
                {
                    gametimer = 0;
                }
                gamestart = true;
                buttonStart.Text = "Pause";
            }
            else if(gamestart == true)
            {
                gamestart = false;
                buttonStart.Text = "Resume";
            }
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            gamestart = true;
            buttonStart.Text = "Pause";
            gametimer = 0;
            killcounter = 0;
            misscounter = 0;

            textBoxKilled.Text = killcounter.ToString();
            textBoxMissed.Text = misscounter.ToString();
        }

    }//public close
}
