﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Typist.StageControls
{
    /// <summary>
    /// Interaction logic for IntroductionControl.xaml
    /// </summary>
    public partial class IntroductionControl : UserControl
    {
        public IntroductionControl(string username)
        {
            InitializeComponent();
            if (username != null)
                WelcomeTB.Text = "Dear " + username + ", welcome!";
            else
                WelcomeTB.Text = "Dear user, welcome!";
        }
    }
}
