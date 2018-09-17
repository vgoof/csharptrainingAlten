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

        public Car(string brandName, string modelName) {
            BrandName = brandName;
            m_modelName = modelName;
        }

        public string BrandName { get => m_brandName; set => m_brandName = value; }

    }
}
