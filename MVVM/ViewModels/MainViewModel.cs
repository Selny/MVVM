using MVVM.Command;
using MVVM.Models;
using MVVM.Repository;
using MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM.ViewModels
{
    public class MainViewModel
    {
        public Car Car { get; set; }
        public ObservableCollection<Car> Cars {  get; set; }
        public RelayCommand ShowCommand { get; set; }
        public RelayCommand EditCommand { get; set; }

        public EditViewModel EditViewModel { get; set; }



        public MainViewModel()
        {

            Car = new Car
            {
                Id = 1,
                Vendor = "BMW",
                Model = "X7",
                Year = 2021
            };

            Cars = new FakeRepo().Cars;

            ShowCommand = new RelayCommand(
                e => { MessageBox.Show($"{Car.Vendor}-{Car.Model}-{Car.Year}"); },
                p => true);

            EditCommand = new RelayCommand(
                action =>
                {
                    EditViewModel = new EditViewModel();
                    EditViewModel.Car = Car;

                    var editView = new EditView();
                    editView.DataContext = EditViewModel;
                    editView.ShowDialog();
                });
        }
    }
}
