﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AltenExercise
{
    class Car
    {

        public string BrandName { get; }
        public string ModelName { get; }


        private Engine _engine;

        public Car(string brandName, string modelName, Engine engine)
        {
            BrandName = brandName;
            ModelName = modelName;
            _engine = engine;
        }
        

        
    }
}
