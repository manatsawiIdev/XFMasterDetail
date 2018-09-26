using System;
using System.Collections.Generic;
using System.Text;
using XFMasterDetail.Models;
using System.Collections.ObjectModel;
using XFMasterDetail.Views;
using XFMasterDetail.Views.MenuItemViews;

namespace XFMasterDetail.ViewModels
{
    public class MenuItemViewModel : BaseViewModel
    {

        public ObservableCollection<MainViewMenuItem> MenuItems { get; set; }
        public MenuItemViewModel() : base()
        {
            LoadMenuItems();
        }

        public void LoadMenuItems()
        {

            MenuItems = new ObservableCollection<MainViewMenuItem>(new[]
            {
                    new MainViewMenuItem { Id = 0, Title = "Home", Icon = "ic_house.png", TargetType = typeof(View1)},
                    new MainViewMenuItem { Id = 1, Title = "Airpot", Icon = "ic_airpot.png",TargetType = typeof(View2)},
                    new MainViewMenuItem { Id = 2, Title = "Car", Icon = "ic_car.png",TargetType = typeof(View3)},
                    new MainViewMenuItem { Id = 3, Title = "Restaurant", Icon = "ic_flok.png",TargetType = typeof(View4)},
                    new MainViewMenuItem { Id = 4, Title = "Logout", Icon = "ic_gear.png"},
            });
        }
    }
}
