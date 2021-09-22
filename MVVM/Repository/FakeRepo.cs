using MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Repository
{
    public class FakeRepo
    {
        public ObservableCollection<Car> Cars { get; set; }
        public FakeRepo()
        {
            Cars = new ObservableCollection<Car>
            {
                new Car
                {
                    Id=1,
                    Vendor="BMW",
                    Model="X1",
                    Year = 2001
                },
                new Car
                {
                    Id=2,
                    Vendor="Alfa Romeo",
                    Model="Y2",
                    Year = 2005
                },
                new Car
                {
                    Id=3,
                    Vendor="Embavud",
                    Model="X7",
                    Year = 2006
                },
                new Car
                {
                    Id=4,
                    Vendor="Ferrari",
                    Model="X4",
                    Year = 2008
                },
                new Car
                {
                    Id=5,
                    Vendor="Lego",
                    Model="X5",
                    Year = 2012
                }
            };
        }
    }
}
