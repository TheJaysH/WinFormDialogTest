﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDialogTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_Icon.SelectedIndex = 0;
            comboBox_Buttons.SelectedIndex = 0;
        }

        private void button_Show_Click(object sender, EventArgs e)
        {
            var title = textBox_Title.Text;
            var message = textBox_Message.Text;

            var buttons = GetButtons(comboBox_Buttons.SelectedItem.ToString());
            var icon = GetIcon(comboBox_Icon.SelectedItem.ToString());

            ShowMessageBox(title, message, buttons, icon);
        }

        /// <summary>
        /// Show the MessageBox with the specified values
        /// 
        /// INFO: Application ExitCode will be DialogResult if ran from command-line.
        /// </summary>
        /// <param name="title">Title of the MessageBox</param>
        /// <param name="message">Message within the MessageBox</param>
        /// <param name="buttons">Buttons to use with MessageBox</param>
        /// <param name="icon">Icon to be displayed</param>
        public static void ShowMessageBox(string title, string message, MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.None, bool commandLine = false)
        {
            var result = MessageBox.Show(message, title, buttons, icon);            
            if (commandLine)
                Environment.Exit((int)result);
        }

        public static MessageBoxButtons GetButtons(string value)
        {
            return Enum.TryParse(value, out MessageBoxButtons buttons) ? buttons : MessageBoxButtons.OK;
        }

        public static MessageBoxIcon GetIcon(string value)
        {
            return Enum.TryParse(value, out MessageBoxIcon icon) ? icon : MessageBoxIcon.None;
        }

    }
}
