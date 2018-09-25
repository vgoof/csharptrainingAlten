using AltenExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AltenExercise
{
    class CarBuilder
    {
        private string _brandName;
        private string _modelName;
        private ICarEngine _engine;
        private Wheels _wheels;
        private SpeedoMeter _speedometer;
        

        public CarBuilder CreateCarWithBrandName(string brandname)
        {
            _brandName = brandname;
            return this;
        }

        public CarBuilder WithModelName(string modelname)
        {
            _modelName = modelname;
            return this;
        }

        public CarBuilder InstallEngine(ICarEngine engine)
        {
            _engine = engine;
            return this;
        }

        public CarBuilder AddWheels(Wheels wheels)
        {
            _wheels = wheels;
            return this;
        }

        public CarBuilder InstallSpeedometer(SpeedoMeter speedometer)
        {
            _speedometer = speedometer;
            return this;
        }

        public Car Build()
        {
            return new Car(_brandName, _modelName, _engine, _wheels, _speedometer);
        }

    }
}
