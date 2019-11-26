using MvvmCross.ViewModels;
using QuadraticEquiations.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquiations.Core.ViewModels
{
    public class EquiationViewModel : MvxViewModel
    {
        public readonly ICalculatorService _calculatorService;
        private double _valueA;
        private double _valueB;
        private double _valueC;
        private double _resultX1;
        private double _resultX2;

        public EquiationViewModel(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        public double ValueA
        {
            get => _valueA;
            set
            {
                _valueA = value;
                RaisePropertyChanged(() => ValueA);
                Calculate();
            }
        }

        public double ValueB
        {
            get => _valueB;
            set
            {
                _valueB = value;
                RaisePropertyChanged(() => ValueB);
                Calculate();
            }
        }

        public double ValueC
        {
            get => _valueC;
            set
            {
                _valueC = value;
                RaisePropertyChanged(() => ValueC);
                Calculate();
            }
        }

        public double ResultX1
        {
            get => _resultX1;
            set
            {
                _resultX1 = value;
                RaisePropertyChanged(() => ResultX1);
            }
        }

        public double ResultX2
        {
            get => _resultX2;
            set
            {
                _resultX2 = value;
                RaisePropertyChanged(() => ResultX2);
            }
        }

        public async override Task Initialize()
        {
            await base.Initialize();

            _valueA = 2;
            _valueB = 8;
            _valueC = 3;

            Calculate();
        }

        private void Calculate()
        {
            List<double> result = _calculatorService.CalculateEquation(ValueA, ValueB, ValueC);

            ResultX1 = result.FirstOrDefault();
            ResultX2 = result.LastOrDefault();
        }
    }
}
