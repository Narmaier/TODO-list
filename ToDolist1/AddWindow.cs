﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDolist1
{
    public partial class AddWindow : Form
    {   
        private int UserID;
        public AddWindow(int UserID)
        {
            this.UserID = UserID;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task task = new Task();

            task.Title = textBox1.Text;
            task.Description = richTextBox1.Text;
            task.Deadline = dateTimePicker1.Value.ToString();

            task.AddTask(this.UserID, task);

            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}