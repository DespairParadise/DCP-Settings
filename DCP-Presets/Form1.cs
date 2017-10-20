﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DCP_Presets
{


    public partial class DCPPresets : Form
    {

        private void applyPreset(string regName)
        {
            try
            {
                string currentPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                string path = "\"" + currentPath + "\\" + regName + ".reg" + "\"";
                var process = Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = "/c regedit /s " + path,
                    Verb = "runas",
                    UseShellExecute = true,
                });
                process.WaitForExit();
                MessageBox.Show("The changes have been applied. \nYou can restart the Player.", 
                    "Preset Applied");
            }
            catch (Exception)
            {
                MessageBox.Show("The operation has been canceled by the user. Please check that you are Administrator. \nNo change has been applied", 
                    "Error: Denied UAC");
            }
            Application.Exit();
        }
        
        public DCPPresets()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Preset Low
            applyPreset("DCPmadVR_LowSettings");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Preset Medium
            applyPreset("DCPmadVR_MediumSettings");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Preset High
            applyPreset("DCPmadVR_HighSettings");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // Preset Ultra
            applyPreset("DCPmadVR_UltraSettings");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Preset Xtrem
            applyPreset("DCPmadVR_XtremSettings");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            // Reset MPC-BE
            applyPreset("mpc-be-settings");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Exit Button
            System.Environment.Exit(0);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
