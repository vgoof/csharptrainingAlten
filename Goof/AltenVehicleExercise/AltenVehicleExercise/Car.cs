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
        private Speedometer m_speedometer;

        public Car(string brandName, string modelName )
        {
            m_brandName = brandName;
            m_modelName = modelName;
            m_engine = new Engine("dummy", 0, 0);
        }

        public Car(string brandName, string modelName,string petrol, double power, double torque) {
            m_brandName = brandName;
            m_modelName = modelName;
            m_engine = new Engine(petrol, power, torque);
        }

        public string BrandName { get => m_brandName; }
        public string ModelName { get => m_modelName; }
        public Engine GetEngine { get => m_engine; }

    }
}
