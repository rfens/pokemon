using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using AudioSwitcher.AudioApi.CoreAudio;
using System.Diagnostics;

namespace MonsterBattle
{
    public partial class BattleForm : Form
    {
        Random randomGenerator;
        bool enemyDead;
        Boolean pokemonChosen = false;
        Boolean enemyChosen = false;

        public BattleForm()
        {
            InitializeComponent();
            randomGenerator = new Random();
        }

        //aanvalsset 1

        //attackbutton explosion
        private void attackButton_Click(object sender, EventArgs e)
        {
            if (!enemyDead && pokemonChosen && enemyChosen == true)
            {
                Random random = new Random();
                int randomNumber = random.Next(15, 40);
                CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
                Debug.WriteLine("Current Volume:" + defaultPlaybackDevice.Volume);
                defaultPlaybackDevice.Volume = randomNumber;
                SoundPlayer audio = new SoundPlayer(MonsterBattle.Properties.Resources.boem);
                audio.Play();

                enemyPictureBox.Tag = enemyPictureBox.Image;
                enemyPictureBox.Image = Properties.Resources.giphy;

                attackButton.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;

                attackTimer.Start();

                screenShakeTimer.Start();
                gif_timer.Start();
            }
            else
            {
                MessageBox.Show("You can not strike the enemy whilst he is already down. Or you haven't chosen a Feckermon/enemy yet.");
            }
        }
        //attackbutton Gass attack
        private void button3_Click(object sender, EventArgs e)
        {
            if (!enemyDead && pokemonChosen && enemyChosen == true)
            {
                Random random = new Random();
                int randomNumber = random.Next(15, 40);
                CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
                Debug.WriteLine("Current Volume:" + defaultPlaybackDevice.Volume);
                defaultPlaybackDevice.Volume = randomNumber;
                SoundPlayer audio = new SoundPlayer(MonsterBattle.Properties.Resources.hentai);
                audio.Play();

                enemyPictureBox.Tag = enemyPictureBox.Image;
                enemyPictureBox.Image = Properties.Resources.hidden_attack;

                attackButton.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                attackTimer.Start();

                screenShakeTimer.Start();
                gif_timer.Start();

            }
            else
            {
                MessageBox.Show("You can not strike the enemy whilst he is already down. Or you haven't chosen a Feckermon/enemy yet.");
            }
        }

        //attackbutton sniper shot
        private void button2_Click(object sender, EventArgs e)
        {
            if (!enemyDead && pokemonChosen && enemyChosen == true)
            {
                Random random = new Random();
                int randomNumber = random.Next(15, 40);
                CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
                Debug.WriteLine("Current Volume:" + defaultPlaybackDevice.Volume);
                defaultPlaybackDevice.Volume = randomNumber;
                SoundPlayer audio = new SoundPlayer(MonsterBattle.Properties.Resources.yeet);
                audio.Play();
                enemyPictureBox.Tag = enemyPictureBox.Image;
                enemyPictureBox.Image = Properties.Resources.gun;

                attackButton.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                attackTimer.Start();

                screenShakeTimer.Start();
                gif_timer.Start();
            }
            else
            {
                MessageBox.Show("You can not strike the enemy whilst he is already down. Or you haven't chosen a Feckermon/enemy yet.");
            }
        }

        //attackbutton rocket launch
        private void button1_Click(object sender, EventArgs e)
        {
            if (!enemyDead && pokemonChosen && enemyChosen == true)
            {
                Random random = new Random();
                int randomNumber = random.Next(15, 40);
                CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
                Debug.WriteLine("Current Volume:" + defaultPlaybackDevice.Volume);
                defaultPlaybackDevice.Volume = randomNumber;
                SoundPlayer audio = new SoundPlayer(MonsterBattle.Properties.Resources.r2d2);
                audio.Play();

                enemyPictureBox.Tag = enemyPictureBox.Image;
                enemyPictureBox.Image = Properties.Resources.tank_attack;

                attackButton.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                attackTimer.Start();

                screenShakeTimer.Start();
                gif_timer.Start();
            }
            else
            {
                MessageBox.Show("You can not strike the enemy whilst he is already down. Or you haven't chosen a Feckermon/enemy yet.");
            }
        }

        private void attackTimer_Tick(object sender, EventArgs e)
        {
            screenShakeTimer.Stop();
            attackTimer.Stop();
        }

        private void screenShakeTimer_Tick(object sender, EventArgs e)
        {
            this.Top += randomGenerator.Next(-5, 6);
            this.Left += randomGenerator.Next(-5, 6);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gif_timer.Stop();
            enemyAttack();
        }

        //---------Friendlies----------//
        //Feckermon: hitler
        private void Feckermon1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Feckermon1RadioButton.Checked == true)
            {
                pokemonChosen = true;
                friendlyPictureBox.Image = Properties.Resources.hitler_removebg;
                pictureBox1.Width = 150;
                Feckermonnamelabel.Text = "Adolf Hitler";
            }
        }

        //Feckermon: tachanka
        private void Feckermon2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Feckermon2RadioButton.Checked == true)
            {
                pokemonChosen = true;
                friendlyPictureBox.Image = Properties.Resources.tachanka;
                pictureBox1.Width = 150;
                Feckermonnamelabel.Text = "Tachanka";
            }
        }

        //Feckermon: sanic
        private void Feckermon3RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Feckermon3RadioButton.Checked == true)
            {
                pokemonChosen = true;
                friendlyPictureBox.Image = Properties.Resources.Sanic;
                pictureBox1.Width = 150;
                Feckermonnamelabel.Text = "Sanic";
            }
        }

        //Feckermon: ghost
        private void Feckermon4RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Feckermon4RadioButton.Checked == true)
            {
                pokemonChosen = true;
                friendlyPictureBox.Image = Properties.Resources.ghost;
                pictureBox1.Width = 150;
                Feckermonnamelabel.Text = "Simon Ghost Riley";
            }
        }

        //Feckermon: master chief
        private void Feckermon5RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Feckermon5RadioButton.Checked == true)
            {
                pokemonChosen = true;
                friendlyPictureBox.Image =
                Properties.Resources.chief_removebg;
                pictureBox1.Width = 150;
                Feckermonnamelabel.Text = "Master Chief";
            }
        }


        //Feckermon: kirby
        private void Feckermon6RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Feckermon6RadioButton.Checked == true)
            {
                pokemonChosen = true;
                friendlyPictureBox.Image = Properties.Resources.kirby;
                pictureBox1.Width = 150;
                Feckermonnamelabel.Text = "Kirby";
            }
        }

        //deck2

        //eeyeore
        private void Feckermon2_1radbuttn_CheckedChanged(object sender, EventArgs e)
        {
            if (Feckermon2_1radbuttn.Checked == true)
            {
                pokemonChosen = true;
                friendlyPictureBox.Image = Properties.Resources.eeyore;
                friendlyPictureBox.Width = 150;
                Feckermonnamelabel.Text = "Eeyore";
            }
        }

        //perry
        private void feckermon2_2radbuttn_CheckedChanged(object sender, EventArgs e)
        {
            if (feckermon2_2radbuttn.Checked == true)
            {
                pokemonChosen = true;
                friendlyPictureBox.Image = Properties.Resources.perry;
                friendlyPictureBox.Width = 150;
                Feckermonnamelabel.Text = "Perry";
            }
        }

        //jerry
        private void feckermon2_3radbuttn_CheckedChanged(object sender, EventArgs e)
        {
            if (feckermon2_3radbuttn.Checked == true)
            {
                pokemonChosen = true;
                friendlyPictureBox.Image = Properties.Resources.jerry;
                friendlyPictureBox.Width = 150;
                Feckermonnamelabel.Text = "Jerry";
            }
        }

        //knuckles
        private void feckermon2_4radbuttn_CheckedChanged(object sender, EventArgs e)
        {
            if (feckermon2_4radbuttn.Checked == true)
            {
                pokemonChosen = true;
                friendlyPictureBox.Image = Properties.Resources.knukles;
                friendlyPictureBox.Width = 150;
                Feckermonnamelabel.Text = "Knuckles";
            }
        }

        //spongebob
        private void feckermon2_5radbuttn_CheckedChanged(object sender, EventArgs e)
        {
            if (feckermon2_5radbuttn.Checked == true)
            {
                pokemonChosen = true;
                friendlyPictureBox.Image = Properties.Resources.spongebob;
                friendlyPictureBox.Width = 150;
                Feckermonnamelabel.Text = "Spongebob";
            }
        }

        //cleaner
        private void feckermon2_6radbuttn_CheckedChanged(object sender, EventArgs e)
        {
            if (feckermon2_6radbuttn.Checked == true)
            {
                pokemonChosen = true;
                friendlyPictureBox.Image = Properties.Resources.Cleaner;
                friendlyPictureBox.Width = 150;
                Feckermonnamelabel.Text = "Cleaner";
            }
        }

        //deck 3//

        //Deadpool
        private void feckermon1Button_CheckedChanged(object sender, EventArgs e)
        {
            if (feckermon1Button.Checked == true)
            {
                pokemonChosen = true;
                friendlyPictureBox.Image = Properties.Resources.deadpool;
                friendlyPictureBox.Width = 150;
                Feckermonnamelabel.Text = "Deadpool";
            }
        }

        //Toad
        private void feckermon2Button_CheckedChanged(object sender, EventArgs e)
        {
            if (feckermon2Button.Checked == true)
            {
                pokemonChosen = true;
                friendlyPictureBox.Image = Properties.Resources.toad;
                friendlyPictureBox.Width = 150;
                Feckermonnamelabel.Text = "Toad";
            }
        }

        //hitler cat
        private void feckermon3Button_CheckedChanged(object sender, EventArgs e)
        {
            if (feckermon3Button.Checked == true)
            {
                pokemonChosen = true;
                friendlyPictureBox.Image = Properties.Resources.cat;
                friendlyPictureBox.Width = 150;
                Feckermonnamelabel.Text = "Hitler Cat";
            }
        }

        //Bob Ross
        private void feckermon4Button_CheckedChanged(object sender, EventArgs e)
        {
            if (feckermon4Button.Checked == true)
            {
                pokemonChosen = true;
                friendlyPictureBox.Image = Properties.Resources.bobross;
                friendlyPictureBox.Width = 150;
                Feckermonnamelabel.Text = "Bob Ross";
            }
        }

        //Iron Man
        private void feckermon5Button_CheckedChanged(object sender, EventArgs e)
        {
            if (feckermon5Button.Checked == true)
            {
                pokemonChosen = true;
                friendlyPictureBox.Image = Properties.Resources.ironman;
                friendlyPictureBox.Width = 150;
                Feckermonnamelabel.Text = "Iron Man";
            }
        }


        private void feckermon6Button_CheckedChanged(object sender, EventArgs e)
        {
            if (feckermon6Button.Checked == true)
            {
                pokemonChosen = true;
                friendlyPictureBox.Image = Properties.Resources.bartje;
                friendlyPictureBox.Width = 150;
                Feckermonnamelabel.Text = "Cult leider Bart";
            }
        }

        //deck 4

        //Baby Yoda
        private void Deck4R1_CheckedChanged(object sender, EventArgs e)
        {
            if (deck4R1.Checked == true)
            {
                pokemonChosen = true;
                friendlyPictureBox.Image = Properties.Resources.baby_yoda_meme_300x225_removebg_preview_removebg_preview;
                friendlyPictureBox.Width = 150;
                Feckermonnamelabel.Text = "Baby Yoda";
            }
        }

        //Spyro

        private void Deck4R2_CheckedChanged(object sender, EventArgs e)
        {
            if (deck4R2.Checked == true)
            {
                pokemonChosen = true;
                friendlyPictureBox.Image = Properties.Resources.hqdefault_removebg_preview;
                friendlyPictureBox.Width = 150;
                Feckermonnamelabel.Text = "Spyro";
            }
        }
        //Patrick

        private void Deck4R3_CheckedChanged(object sender, EventArgs e)
        {
            if (deck4R3.Checked == true)
            {
                pokemonChosen = true;
                friendlyPictureBox.Image = Properties.Resources.Surprised_Patrick_Masterpiece_Meme3_1024x1024_removebg_preview;
                friendlyPictureBox.Width = 150;
                Feckermonnamelabel.Text = "Patrick";
            }
        }
        //Nemo
        private void Deck4R4_CheckedChanged(object sender, EventArgs e)
        {
            if (deck4R4.Checked == true)
            {
                pokemonChosen = true;
                friendlyPictureBox.Image = Properties.Resources._363e2738af6e7ff65c7ed7d87eaace88_removebg_preview;
                friendlyPictureBox.Width = 150;
                Feckermonnamelabel.Text = "Nemo";
            }
        }
        //Olaf

        private void Deck4R5_CheckedChanged(object sender, EventArgs e)
        {
            if (deck4R5.Checked == true)
            {
                pokemonChosen = true;
                friendlyPictureBox.Image = Properties.Resources._705x397xFrozen_P202_P20__P20Olaf_P20Samantha_removebg_preview;
                friendlyPictureBox.Width = 150;
                Feckermonnamelabel.Text = "Olaf";
            }

        }

        //Kaos

        private void Deck4R6_CheckedChanged(object sender, EventArgs e)
        {
            if (deck4R6.Checked == true)
            {
                pokemonChosen = true;
                friendlyPictureBox.Image = Properties.Resources.Skylanders_imaginators_removebg_preview;
                friendlyPictureBox.Width = 150;
                Feckermonnamelabel.Text = "Kaos";
            }
        }


        //---------------enemies---------------------//

        //enemy: dipsy
        private void attacker1radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            if (attacker1radiobutton.Checked == true)
            {
                enemyChosen = true;
                enemyPictureBox.Image = Properties.Resources.dipsy;
                enemyHealthPictureBox.Width = 150;
                enemynamelabel.Text = "Dipsy";
            }
        }

        //enemy: minecraft chicken
        private void attacker2radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            if (attacker2radiobutton.Checked == true)
            {
                enemyChosen = true;
                enemyPictureBox.Image = Properties.Resources.Chicken;
                enemyHealthPictureBox.Width = 150;
                enemynamelabel.Text = "Minecraft Chicken";
            }
        }

        //enemy: t-14 tank
        private void attacker3radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            if (attacker3radiobutton.Checked == true)
            {
                enemyChosen = true;
                enemyPictureBox.Image = Properties.Resources.tank;
                enemyHealthPictureBox.Width = 150;
                enemynamelabel.Text = "T-14 tank";
            }
        }

        //enemy: goomba
        private void attacker4radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            if (attacker4radiobutton.Checked == true)
            {
                enemyChosen = true;
                enemyPictureBox.Image = Properties.Resources.goomba;
                enemyHealthPictureBox.Width = 150;
                enemynamelabel.Text = "Goomba";
            }
        }

        //enemy: link zelda
        private void attacker5radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            if (attacker5radiobutton.Checked == true)
            {
                enemyChosen = true;
                enemyPictureBox.Image = Properties.Resources.link;
                enemyHealthPictureBox.Width = 150;
                enemynamelabel.Text = "Link";
            }
        }

        //enemy: wall-e
        private void attacker6radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            if (attacker6radiobutton.Checked == true)
            {
                enemyChosen = true;
                enemyPictureBox.Image = Properties.Resources.walle;
                enemyHealthPictureBox.Width = 150;
                enemynamelabel.Text = "Wall-e";
            }
        }

        //attack enemy
        private void enemyAttack()
        {
            enemyPictureBox.Image = (Image)enemyPictureBox.Tag;
            int randomAttack = randomGenerator.Next(1, 30);
            enemyHealthPictureBox.Width -= randomAttack;

            if (enemyHealthPictureBox.Width == 0 || enemyHealthPictureBox.Width < 0)
            {
                MessageBox.Show("the enemy has fainted!");
                MessageBox.Show("please reset the game in the menu bar.");
                enemyDead = true;
                enemyPictureBox.Image = null;
            }

            //attack
            int randomAttack1 = randomGenerator.Next(1, 30);
            pictureBox1.Width -= randomAttack1;
            MessageBox.Show("The enemy has dealt " + randomAttack1.ToString() + " Damage to you." + " You have dealt" + randomAttack.ToString() + " damage");
            attackButton.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            if (pictureBox1.Width == 0 || pictureBox1.Width < 0)
            {
                MessageBox.Show("you have fainted.");
                MessageBox.Show("please reset the game in the menu bar.");
                friendlyPictureBox.Image = null;
            }
        }

        //resets all characters 
        private void resetGame()
        {
            pictureBox1.Width = 150;
            enemyHealthPictureBox.Width = 150;
            pokemonChosen = false;
            enemyChosen = false;
            friendlyPictureBox.Image = null;
            enemyPictureBox.Image = null;
            Feckermonnamelabel.Text = "";
            enemynamelabel.Text = "";

            //deck 1
            Feckermon1RadioButton.Checked = false;
            Feckermon2RadioButton.Checked = false;
            Feckermon3RadioButton.Checked = false;
            Feckermon4RadioButton.Checked = false;
            Feckermon5RadioButton.Checked = false;
            Feckermon6RadioButton.Checked = false;
            //deck 2
            Feckermon2_1radbuttn.Checked = false;
            feckermon2_2radbuttn.Checked = false;
            feckermon2_3radbuttn.Checked = false;
            feckermon2_4radbuttn.Checked = false;
            feckermon2_5radbuttn.Checked = false;
            feckermon2_6radbuttn.Checked = false;
            //deck 3
            feckermon1Button.Checked = false;
            feckermon2Button.Checked = false;
            feckermon3Button.Checked = false;
            feckermon4Button.Checked = false;
            feckermon5Button.Checked = false;
            feckermon6Button.Checked = false;
            //deck 4
            deck4R1.Checked = false;
            deck4R2.Checked = false;
            deck4R3.Checked = false;
            deck4R4.Checked = false;
            deck4R5.Checked = false;
            deck4R6.Checked = false;

            //enemy deck
            attacker1radiobutton.Checked = false;
            attacker2radiobutton.Checked = false;
            attacker3radiobutton.Checked = false;
            attacker4radiobutton.Checked = false;
            attacker5radiobutton.Checked = false;
            attacker6radiobutton.Checked = false;
        }

        //dropdown menu with button to reset the game
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        //dropdown menu with button to close game
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //dropdown menu deck 1
        private void deck1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Feckermongroupbox.Visible = true;
            feckermon2groupbox.Visible = false;
            feckermon3groupbox.Visible = false;
            groupBoxDeck4.Visible = false;
        }

        //dropdown menu deck 2
        private void deck2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            feckermon2groupbox.Visible = true;
            Feckermongroupbox.Visible = false;
            feckermon3groupbox.Visible = false;
            groupBoxDeck4.Visible = false;
        }

        //dropdown menu deck 3
        private void deck3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            feckermon3groupbox.Visible = true;
            Feckermongroupbox.Visible = false;
            feckermon2groupbox.Visible = false;
            groupBoxDeck4.Visible = false;
        }
        //dropdown menu deck 4

        private void Deck4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxDeck4.Visible = true;
            feckermon3groupbox.Visible = false;
            Feckermongroupbox.Visible = false;
            feckermon2groupbox.Visible = false;
        }

        private void AttackSet2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            attackSet1GroupBox.Visible = false;
            attackSet2GroupBox.Visible = true; 
        }

        private void AttackSet1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            attackSet1GroupBox.Visible = true;
            attackSet2GroupBox.Visible = false;
        }
    }
}