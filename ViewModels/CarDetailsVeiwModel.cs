using CommunityToolkit.Mvvm.ComponentModel;
using maui_CarListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maui_CarListApp.ViewModels
{
    [QueryProperty(nameof(Car), "Car")]
    public partial class CarDetailsVeiwModel : BaseViewModel
    {
        [ObservableProperty]
        Car car;

    }
}
