using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        //Create Global Variables of string type Array to save titles or name of traks and path of the track
        String[] paths, files;
        private void button1_Click(object sender, EventArgs e)
        {
            // Code to Select the Songs
            OpenFileDialog ofd = new OpenFileDialog();
            
            //Code to select Multiple files
            ofd.Multiselect = true;
            
            //if file is selected or not
            if (ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //Save the names of the track in files array
                paths = ofd.FileNames;   //Save the paths of the tracks in path array
                
                //Display the music titles in listbox
                for(int i=0; i<files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]); //Display Songs in ListBox
                }
            }
            
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Write a code to play Music
            axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
        }
          
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            // Code to close the App
            this.Close();
        }
    }
}
