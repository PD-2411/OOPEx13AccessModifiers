using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOperation
{
    internal class Car
    {
        //Details on the operation of a Car
        //Let abstract or hide away these details from other classes
        #region [Private Methods]
        private void InjectFuel() { }

        private void Ignition()
        {

        }

        private void IncreaseAirIntake() { }

        private void DecreaseAirIntake() { }

        private void IncreaseFuelIntake() { }

        private void DecreaseFuelIntake() { }

        private void IncreaseBrakelinePressure() { }
        private void DecreaseBrakelinePressure() { }
        #endregion


        #region [Public Methods]

        public void StartEngine()
        {
            this.InjectFuel();
            this.IncreaseAirIntake();
            this.Ignition();
        }

        public void SpeedUp()
        {
            this.IncreaseAirIntake();
            this.IncreaseFuelIntake();
        }

        public void SlowDown()
        {
            this.DecreaseAirIntake();
            this.DecreaseFuelIntake();
        }

        public void ApplyBrake()
        {
            SlowDown();
            this.IncreaseBrakelinePressure();
        }

        public void Stop()
        {
            ApplyBrake();
            HoldBlake();
        }

        public void HoldBlake() { }
        #endregion
    }
}
