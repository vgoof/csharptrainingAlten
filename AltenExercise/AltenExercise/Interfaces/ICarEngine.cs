using System;
using System.Collections.Generic;
using System.Text;

namespace AltenExercise.Interfaces
{
    interface ICarEngine : IEngine
    {
        EngineStatus EngineStatus { get; }
    }
}
