using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune.Utils
{
    /// <summary>
    /// Parent SpinValue. This is an object for the wheel so we know what the value is.
    /// </summary>
    public abstract class SpinValue
    {
        public abstract int money{ get;set;} // the amount of money in this SpinValue
        public abstract bool isBankrupt { get; set; } //Tells us if the value is a bankrupt value
    }
}
