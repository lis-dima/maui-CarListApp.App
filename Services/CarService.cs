using maui_CarListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maui_CarListApp.Services
{
    public class CarService
    {
        public List<Car> GetCars()
        {
            return new List<Car>()
            {
                new Car{ Id = 1, Make = "Honda", Model = "Fit", Vin = "111" },
                new Car{ Id = 2, Make = "Tooyota", Model = "Fit1", Vin = "222" },
                new Car{ Id = 3, Make = "M2", Model = "Fit2", Vin = "333" },
                new Car{ Id = 4, Make = "M3", Model = "Fit3", Vin = "14411" },
                new Car{ Id = 5, Make = "M4", Model = "Fit4", Vin = "55" },
            };
        }
    }
}
