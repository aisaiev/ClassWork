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

namespace ClassWork_21_12_Task_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //DataContex with primitives
            //string firstName = "Anton";
            //string lastName = "Isaiev";
            //bool isMasterDegree = true;
            //this.FirstNameTextBox.DataContext = firstName;
            //this.LastNameTextBox.DataContext = lastName;
            //this.IsMasterDegreeCheckBox.DataContext = isMasterDegree;

            //DataContext with custom class
            //Person person = new Person()
            //{
            //    FirstName = "Anton",
            //    LastName = "Isaiev",
            //    IsMasterDegree = true
            //};
            //this.DataContext = person;

            //Static resource with primitives
        }
    }
}
