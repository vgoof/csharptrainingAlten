using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltenVehicleExercise
{
    class Car
    {
        private string m_brandName;
        private string m_modelName;
        private Engine m_engine;

        public Car(string brandName, string modelName, Engine engine) {
            m_brandName = brandName;
            m_modelName = modelName;
            m_engine = engine;
        }

        public string BrandName { get => m_brandName; }
        public string ModelName { get => m_modelName; }
    }
}
