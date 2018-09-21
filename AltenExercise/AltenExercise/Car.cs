using System;
using System.Collections.Generic;
using System.Text;

namespace AltenExercise
{
    class Car : IVehicleWithEngine
    {

        public string BrandName { get; }
        public string ModelName { get; }
        public double CurrentSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private Engine _engine;
        private Wheels _wheels;
        private SpeedoMeter _speedometer;

        public Car(string brandName, string modelName, Engine engine, Wheels wheels, SpeedoMeter speedometer)
        {
            BrandName = brandName;
            ModelName = modelName;
            _engine = engine;
            _wheels = wheels;
            _speedometer = speedometer;
        }

        public void StartEngine()
        {
            _engine.Start();
        }
    }
}
