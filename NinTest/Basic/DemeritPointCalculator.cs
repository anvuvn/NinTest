using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinTest.Basic
{
    public class DemeritPointCalculator
    {
        private const int SpeedLimit = 65;
        private const int MaxSpeedLimit = 300;
        private const int KmPerSpeedLimit = 5;
        //
        public int CalculateDemeritPoint(int speed)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(speed);
            ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(speed, MaxSpeedLimit);
            //
            if (speed < SpeedLimit) { return 0; }  
            return (speed - SpeedLimit) / KmPerSpeedLimit; 
        }        
    }
}

