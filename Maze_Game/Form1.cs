using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            start_point();
        }

        
        private void barrier_touch(object sender, EventArgs e)
        {
            System.Media.SoundPlayer touch_sound = new System.Media.SoundPlayer(@"C:\Windows\Media\Windows Ding.wav");
            touch_sound.Play();
            start_point();
        }

        private void start_point()
        {
            Point start_p = panel1.Location;
            Cursor.Position = PointToScreen(start_p);
        }

      

        private void label33_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer finish_sound = new System.Media.SoundPlayer(@"C:\Windows\Media\tada.wav");
            finish_sound.Play();
            MessageBox.Show("Waoo!!,You reached me", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
