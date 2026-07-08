using SpaceShooter.Managers.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooter.Forms
{
    public partial class MainMenuForm : Form


    {
        private SoundPlayer ClickPlayer;
        private AudioManager audioManager;

        private Label lblCoins;
        private Label lblHighScore;

        public MainMenuForm(AudioManager audioManager)
        {
            InitializeComponent();
            InitializeCustomControls();
            this.audioManager = audioManager;
            ClickPlayer = new SoundPlayer(Properties.Resources.resources_audio_menu_click);
            LoadPlayerStats();
        }

        private void InitializeCustomControls()
        {
            lblCoins = new Label
            {
                Location = new Point(20, 20),
                AutoSize = true,
                Font = new Font("Segoe UI Emoji", 12),
                AccessibleName = "Coins"
            };

            lblHighScore = new Label
            {
                Location = new Point(20, 50),
                AutoSize = true,
                Font = new Font("Segoe UI Emoji", 12),
                AccessibleName = "High Score"
            };

            this.Controls.Add(lblCoins);
            this.Controls.Add(lblHighScore);
        }

        private void LoadPlayerStats()
        {
            var playerData = PlayerRepository.GetPlayerData();
            if (playerData != null)
            {
                lblCoins.Text = $"💰 {playerData.TotalCoins}";
                lblHighScore.Text = $"🏆 {playerData.HighScore}";
            }
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
            {
                LoadPlayerStats();
            }
        }

        private void PlayClickSound()
        {
            ClickPlayer.Play();
        }

        private void PlayClickSoundSync()
        {
            ClickPlayer.PlaySync();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            PlayClickSound();

            this.Hide();
            GameForm gameform = new GameForm();
            gameform.ShowDialog();

            this.Show();
        }

        private void btn_Shop_Click(object sender, EventArgs e)
        {
            PlayClickSound();
            this.Hide();
            ShopForm shopform = new ShopForm();
            shopform.ShowDialog();
            this.Show();
        }

        private void btn_Option_Click(object sender, EventArgs e)
        {
            PlayClickSound();
            this.Hide();
            OptionForm optionform = new OptionForm(audioManager);
            optionform.ShowDialog();
            this.Show();
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            PlayClickSound();
            this.Hide();
            AboutForm aboutform = new AboutForm();
            aboutform.ShowDialog();
            this.Show();
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            PlayClickSoundSync();
            Application.Exit();
        }
    }
}
