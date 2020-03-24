using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_Roullete
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        main Rolletemain = new main();//caling the main class
        Random loadspin = new Random();//caling the random class
       
        private void button1_Click(object sender, EventArgs e)
        {
            gifplay.Image = Russian_Roullete.Properties.Resources.load ;//plays the gif


            Load_btn.Enabled = false;

            Spin_btn.Enabled = true;//disable the load button and enables the spin button
        }

        private void Spin_btn_Click(object sender, EventArgs e)
        {
            gifplay.Image = Russian_Roullete.Properties.Resources.spin;

            Rolletemain.LOadSpin = loadspin.Next(1, 6);//chosses a random number from 1 to 6

            Shoot_btn.Enabled = true;//disable the spin button and enables the shoot and shootaway button
            ShootAway_btn.Enabled = true;
            Spin_btn.Enabled = false;
        }

        private void Shoot_btn_Click(object sender, EventArgs e)
        {
            gifplay.Image = Russian_Roullete.Properties.Resources.shoot;
            System.IO.Stream str = Russian_Roullete.Properties.Resources.Shotgun;//this plays the sound
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();


            if (Rolletemain.TotalShoot > 0 && Rolletemain.LOadSpin == 1)
            {


                MessageBox.Show("Bullet Shot you loose");//this displays the message

                Load_btn.Enabled = false;
                Shoot_btn.Enabled = false;
                Spin_btn.Enabled = false;
                ShootAway_btn.Enabled = false;



            }
            else if (Rolletemain.TotalShoot > 0 && Rolletemain.LOadSpin != 1)
            {
                Rolletemain.TotalShoot = Rolletemain.TotalShoot - 1;
                if (Rolletemain.LOadSpin == 6)
                {
                    Rolletemain.LOadSpin = 1;
                }
                else
                {
                    Rolletemain.LOadSpin++;
                }

                MessageBox.Show("Saved Bullete not shot");//this displays the message

            }
        }

        private void ShootAway_btn_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Russian_Roullete.Properties.Resources.Shotgun;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            int score = Rolletemain.gunloadshoot();

            if (score == 10)
            {
                MessageBox.Show("Shootaway You win score =1000");//this displays the message
                Load_btn.Enabled = false;
                Shoot_btn.Enabled = false;//diable all the button after the games is completed
                Spin_btn.Enabled = false;
                ShootAway_btn.Enabled = false;

            }
            if (score == 5)
            {
                MessageBox.Show("Shootaway You win score =1000");//this displays the message
                Load_btn.Enabled = false;

                Shoot_btn.Enabled = false;
                Spin_btn.Enabled = false;//diable all the button after the games is completed
                ShootAway_btn.Enabled = false;
            }
            if (score == 0)
            {

                MessageBox.Show("missed");


            }
            if (Rolletemain.TotalShoot == 0)
            {

                MessageBox.Show("You loose");
                Load_btn.Enabled = false;
                Shoot_btn.Enabled = false;//diable all the button after the games is completed
                Spin_btn.Enabled = false;
                ShootAway_btn.Enabled = false;


            }
        }

        private void PlayAgain_btn_Click(object sender, EventArgs e)
        {
            (new Game()).Show();
            this.Hide();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            Shoot_btn.Enabled = false;
            Spin_btn.Enabled = false;
            ShootAway_btn.Enabled = false;
        }
    }
}
