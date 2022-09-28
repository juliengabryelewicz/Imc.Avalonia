using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace Imc.Avalonia.ViewModels
{

    public class MainWindowViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private double _Height;

        public double Height
        {
            get 
            {
                return _Height; 
            }
            set
            {
                if (_Height != value)
                {
                    _Height = value;
                }
            }
        }

        private double _Weight;

        public double Weight
        {
            get 
            {
                return _Weight; 
            }
            set
            {
                if (_Weight != value)
                {
                    _Weight = value;
                }
            }
        }

        private string _Result = "";

        public string Result
        {
            get 
            {
                return _Result; 
            }
            set
            {
                if (_Result != value)
                {
                    _Result = value;
                    RaisePropertyChanged();
                }
            }
        }

        public void CalculateImc()
        {
            double Imc = Weight / Math.Pow(Height/100, 2);
            if(Imc < 18.5){
                Result = "Maigreur";
            } else if(Imc >= 18.5 && Imc <= 25){
                Result = "Corpulence normale";
            } else if(Imc > 25 && Imc <= 30){
                Result = "Surpoids";
            } else if(Imc > 30 && Imc <= 35){
                Result = "Obésité modérée";
            } else if(Imc > 35 && Imc <= 40){
                Result = "Obésité sévère";
            } else if(Imc > 40){
                Result = "Obésité morbide";
            }
        }
    }
}
