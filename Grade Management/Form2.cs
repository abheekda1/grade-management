﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_Management
{
    public partial class InfoForm : Form
    {
        Form opener;
        public InfoForm(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }
/*
        int SchoolName = 0;

            try
            {
                if (SchoolSelectCBox.Text == "East Lyme High School")
                {
                    SchoolName = 1;
                }
            }
            catch
            {

            }
        */
    }
}
