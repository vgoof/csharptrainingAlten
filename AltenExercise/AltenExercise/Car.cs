using AltenExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AltenExercise
{
    class Car : IVehicleWithEngine, IDisposable
    {
        public class CarBuilder
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

        public string BrandName { get; }
        public string ModelName { get; }
        public EngineStatus EngineStatus
        {
            get { return _engine?.EngineStatus ?? EngineStatus.Missing; }
        }
        public double CurrentSpeed
        {
            get { return _speedometer?.GetCurrentSpeed() ?? -1; }
        }

        private ICarEngine _engine;
        private Wheels _wheels;
        private SpeedoMeter _speedometer;

        private Car(string brandName, string modelName, ICarEngine engine, Wheels wheels, SpeedoMeter speedometer)
        {
            BrandName = brandName;
            ModelName = modelName;
            _engine = engine;
            _wheels = wheels;
            _speedometer = speedometer;
        }

        public void StartEngine()
        {
            _engine?.Start();
        }

        public void StopEngine()
        {
            _engine?.Stop();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    _engine = null;
                    _wheels = null;
                    _speedometer = null;
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Car() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

    }
}
