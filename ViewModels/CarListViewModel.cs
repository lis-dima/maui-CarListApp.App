using CommunityToolkit.Mvvm.Input;
using maui_CarListApp.Models;
using maui_CarListApp.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace maui_CarListApp.ViewModels
{
    public partial class CarListViewModel : BaseViewModel
    {
        private readonly CarService carService;
        public ObservableCollection<Car> Cars { get; set; } = new ObservableCollection<Car>();
        public CarListViewModel(CarService carService)
        {
            Title = "Car list";
            this.carService = carService;
        }

        [RelayCommand]
        async Task GetCarList()
        {
            if (IsLoading) return;
            try
            {
                IsLoading = true;
                if (Cars.Any()) Cars.Clear();
                var cars = carService.GetCars();
                foreach (var car in cars) Cars.Add(car);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to get cars: {ex.Message}");
                await Shell.Current.DisplayAlert("Error", "Filed to retriwe list of cars", "Ok");
                throw;
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
}
