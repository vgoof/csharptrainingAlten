using System;
using System.Collections.Generic;
using System.Text;

namespace AltenExercise
{
    static class VehicleFactory
    {

        public static IVehicle CreateVehicle(VehicleType vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleType.VolksWagenUp:
                    return new CarBuilder()
                    .CreateCarWithBrandName("Volkswagen")
                    .WithModelName("Up!")
                    .InstallEngine(new Engine(59, 95, EngineType.Petrol))
                    .AddWheels(new Wheels(12))
                    .InstallSpeedometer(new SpeedoMeter())
                    .Build();
                case VehicleType.Peugeot308:
                    return new CarBuilder()
                    .CreateCarWithBrandName("Peugeot")
                    .WithModelName("308")
                    .InstallEngine(new Engine(128, 225, EngineType.Petrol))
                    .AddWheels(new Wheels(11))
                    .InstallSpeedometer(new SpeedoMeter())
                    .Build();
                case VehicleType.FordFocus:
                   return new CarBuilder()
                    .CreateCarWithBrandName("Ford")
                    .WithModelName("Focus")
                    .InstallEngine(new Engine(123, 201, EngineType.Diesel))
                    .AddWheels(new Wheels(13))
                    .InstallSpeedometer(new SpeedoMeter())
                    .Build();
                case VehicleType.HondaCivic:
                   return new CarBuilder()
                   .CreateCarWithBrandName("Honda")
                   .WithModelName("Civic")
                   .InstallEngine(new Engine(90, 130, EngineType.Hybrid))
                   .AddWheels(new Wheels(14))
                   .InstallSpeedometer(new SpeedoMeter())
                   .Build();
                case VehicleType.LexusCT200h:
                    return new CarBuilder()
                    .CreateCarWithBrandName("Lexus")
                    .WithModelName("CT200h")
                    .InstallEngine(new Engine(125, 210, EngineType.Hybrid))
                    .AddWheels(new Wheels(15))
                    .InstallSpeedometer(new SpeedoMeter())
                    .Build();
                default:
                    return new CarBuilder()
                        .Build();
            }
        }
    }

    enum VehicleType
    {
        VolksWagenUp,
        Peugeot308,
        FordFocus,
        HondaCivic,
        LexusCT200h
    }


}
