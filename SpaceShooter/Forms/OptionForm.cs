using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooter.Forms
{
    public partial class OptionForm : Form
    {

        private readonly AudioManager _audio;
        private bool _loading = false;

        public OptionForm(AudioManager audio)
        {
            InitializeComponent();
            _audio = audio;
            this.Load += OptionForm_Load;
        }

        private void OptionForm_Load(object sender, EventArgs e)
        {
            _loading = true;

            comboBox1.Items.Clear();
            foreach (var track in AudioSettings.Tracks)
                comboBox1.Items.Add(track.Name);

            if (AudioSettings.SelectedTrackIndex >= 0 &
                AudioSettings.SelectedTrackIndex < comboBox1.Items.Count)
                    comboBox1.SelectedIndex = AudioSettings.SelectedTrackIndex;

            checkBox1.Checked = AudioSettings.MusicMuted;
            checkBox2.Checked = AudioSettings.SfxMuted;

            _loading = false;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _audio.Dispose();
        }

        private void PlayClickSound()
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.resources_audio_menu_click);
            player.Play();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PlayClickSound();
            this.Close();
            _audio.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (_loading) return;

            AudioSettings.MusicMuted = checkBox1.Checked;
            _audio?.SetMusicMuted(AudioSettings.MusicMuted);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (_loading) return;

            AudioSettings.SfxMuted = checkBox2.Checked;
            _audio?.SetSfxMuted(AudioSettings.SfxMuted);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_loading) return;

            int idx = comboBox1.SelectedIndex;
            if (idx < 0 || idx >= AudioSettings.Tracks.Count) return;

            AudioSettings.SelectedTrackIndex = idx;
            string fullPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                AudioSettings.Tracks[idx].Path);
            _audio?.SwitchTrack(fullPath);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
