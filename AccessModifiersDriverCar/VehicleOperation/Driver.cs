using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOperation
{
    public class Driver
    {
        public void OperateCar()
        {
            Car car = new Car();
            OpenDoor();
            SitDown();
            GetKeyOutOfPocket();

            car.ApplyBrake();
            car.HoldBlake();
            car.SpeedUp();
            car.StartEngine();
        }

        private void OpenDoor() { }
        private void SitDown() { }
        private void GetKeyOutOfPocket() { }
    
    
    
    }
}
