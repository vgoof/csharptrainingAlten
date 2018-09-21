using System;
using System.Collections.Generic;
using System.Text;

namespace AltenExercise
{
    class Car : IVehicleWithEngine
    class Car : IVehicleWithEngine, IDisposable
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
