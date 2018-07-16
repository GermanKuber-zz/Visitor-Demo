using System;

namespace Visitor.Core
{
    public class Engine : IVisit<IEngineVisitor>
    {

        private float _power;
        private float _cylinderVolume;

        private const float WorkingTemperatureC = 90.0F;
        private float _temperatureC = 20.0F;

        public Engine(float power, float cylinderVolume)
        {
            _power = power;
            _cylinderVolume = cylinderVolume;
        }

   

        public void Run(TimeSpan time)
        {
            
            var heatingTime = GetHeatingTime();

            if (time > heatingTime)
            {
                _temperatureC = WorkingTemperatureC;
            }
            else
            {
                double temperatureDelta = WorkingTemperatureC - _temperatureC;
                var timeRatio = time.TotalMinutes / heatingTime.TotalMinutes;
                _temperatureC += (float)(temperatureDelta * timeRatio);
            }

        }

        private TimeSpan GetHeatingTime()
        {

            var meanPower = 180.0;
            var nominalHeatingTimeSec = 300.0;

            var seconds = (int)(nominalHeatingTimeSec * meanPower / _power);

            return new TimeSpan(0, 0, seconds);

        }

        public void Visit(IEngineVisitor visitor)
        {
            visitor.Visit(_power, _cylinderVolume);
        }
    }
}
