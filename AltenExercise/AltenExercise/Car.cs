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

        public Car(string brandName, string modelName, Engine engine)
        {
            BrandName = brandName;
            ModelName = modelName;
            _engine = engine;
        }

        public void StartEngine()
        {
            _engine.Start();
        }
    }
}
