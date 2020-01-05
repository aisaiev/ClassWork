using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Author_Task
{
    public static class CustomCommands
    {
        public static RoutedCommand Change { get; set; }

        static CustomCommands()
        {
            Change = new RoutedCommand(nameof(Change), typeof(Window));
        }
    }
}
