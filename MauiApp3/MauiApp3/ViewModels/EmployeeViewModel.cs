using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiApp3.ViewModels
{
    public class EmployeeViewModel: BaseViewModel
    {
        private int age;
        public int Age
        {
            get => age;
            set
            {
                age = value;
                OnPropertyChanged(nameof(Age));
            }
        }

        private string name;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private int counter;
        public int Counter
        {
            get
            {
                return counter;
            }
            set
            {
                counter = value;
                OnPropertyChanged(nameof(Counter));
            }
        }

        public ICommand ClickCommand { get; }


        public EmployeeViewModel()
        {
            ClickCommand = new RelayCommand(IncreamentCounter);
        }


        public void IncreamentCounter()
        {
            Counter++;

        }
    }
}


