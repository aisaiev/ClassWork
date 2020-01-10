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
        public static RoutedCommand CoreCommand { get; set; }

        static CustomCommands()
        {
            CoreCommand = new RoutedCommand(nameof(CoreCommand), typeof(Window));
        }
    }
}
