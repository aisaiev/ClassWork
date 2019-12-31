using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPF_ClassWork_28_12_Task_2
{
    public static class MyCommand
    {
        public static RoutedCommand Show { get; set; }

        static MyCommand()
        {
            Show = new RoutedCommand(nameof(Show), typeof(Window));
        }
    }
}
