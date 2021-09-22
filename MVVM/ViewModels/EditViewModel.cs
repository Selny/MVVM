using MVVM.Command;
using MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM.ViewModels
{
    public class EditViewModel
    {
        public Car Car { get; set; }
        public RelayCommand CloseCommand { get; set; }
        public EditViewModel()
        {
            CloseCommand = new RelayCommand(
                action =>
                {
                    if (action is Window window)
                    {
                        window.Close();
                    }
                });
        }
    }
}
