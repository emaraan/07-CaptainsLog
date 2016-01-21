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
using System.Windows.Shapes;

namespace CaptainsLog
{
    /// <summary>
    /// Interaction logic for ViewEntry.xaml
    /// </summary>
    public partial class ViewEntry : Window
    {
        public ViewEntry()
        {
            InitializeComponent();
        }

        public void viewEntryInfo()
        {
            textBlockShowTitle.Text = MainWindow.logEntries[MainWindow.viewValue].Title;
            textBlockShowText.Text = MainWindow.logEntries[MainWindow.viewValue].Text;
        }
    }
}
