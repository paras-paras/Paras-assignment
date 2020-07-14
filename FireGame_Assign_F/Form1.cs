using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireGame_Assign_F
{
    public partial class Form1 : Form
    {
        OptionGame instance = new OptionGame();

        Random rd = new Random();
        int trigger = 0, triggerShoot = 0;
        int ctShoot = 0, ctShootAway = 0;
        public Form1()
        {
            InitializeComponent();

            load1.Enabled = false;
            spin1.Enabled = false;
            shoot1.Enabled = false;
            shoot_away.Enabled = false;
            exit_now.Enabled = false;
            trigger = rd.Next(1, 5);
            triggerShoot= rd.Next(1, 3);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            //if we want to play the game then we must need to click on the start button
            pictureBox1.Image = FireGame_Assign_F.Properties.Resources.start1;
            instance.firstOption(Start, load1);

        }

        private void load1_Click(object sender, EventArgs e)
        {
            //when we click on the load button then bullets are load on the gun and spin will be ready 
            pictureBox1.Image = FireGame_Assign_F.Properties.Resources.load1;
            instance.secndOption(load1,spin1);


        }

        private void shoot1_Click(object sender, EventArgs e)
        {
            //when we click on the shoot button if we click on 4 times then the button disable 
            pictureBox1.Image = FireGame_Assign_F.Properties.Resources.shoot1;
            instance.Shoot();
            ctShoot++;
            if (ctShoot == trigger)
            {
                MessageBox.Show("Opps ! you die ");
                shoot1.Enabled = false;
                shoot_away.Enabled = false;
                exit_now.Enabled = true;
            }
            else {
                if (ctShoot < 4)
                {
                    MessageBox.Show("Hurry ! You are alive ");
                }
                else {
                    shoot1.Enabled = false;
                    exit_now.Enabled = true;
                }   
            }

        }

        private void exit_now_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void shoot_away_Click(object sender, EventArgs e)
        {
            //click on the shootaway button 
            pictureBox1.Image = FireGame_Assign_F.Properties.Resources.shootaway1;
            instance.ShootAway();
            ctShootAway++;
            if (ctShootAway == triggerShoot)
            {
                MessageBox.Show("Opps! You die ");
                shoot_away.Enabled = false;
                exit_now.Enabled = true;
            }
            else {
                MessageBox.Show("You are alive ");
            }


            if (ctShootAway==2) {
                shoot_away.Enabled = false;
                
                exit_now.Enabled = true;
            }
        }

        private void spin1_Click(object sender, EventArgs e)
        {
            //this option is used to spin the gun and ready to shoot 
            pictureBox1.Image = FireGame_Assign_F.Properties.Resources.spin1;
            instance.ThirdOption( spin1,shoot1,shoot_away);
        }

    }
}
