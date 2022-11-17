using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune.Utils.SpinValues
{
    /// <summary>
    /// Wheel class that is the wheel object, this will hold on wheel values.
    /// </summary>
    public class Wheel
    {
        private static readonly SpinValue[] WheelMoney = new SpinValue[]
            {
                new FiveHund(),
                new EightHund(),
                new FiveHund(),
                new SixFifty(),
                new FiveHund(),
                new NineHund(),
                new bankRupt(),
                new OneThous(),
                new FiveHund(),
                new SixHund(),
                new SevenHund(),
                new SixHund(),
                new SixFifty(),
                new FiveHund(),
                new SevenHund(),
                new FiveHund(),
                new SixHund(),
                new FiveFifty(),
                new FiveHund(),
                new SixHund(),
                new bankRupt(),
                new SixFifty(),
                new SixHund(),
                new SevenHund(),
            };
        private static Random rand = new Random();

        /// <summary>
        /// Generates a random number of degree's the wheel will spin
        /// </summary>
        /// <returns></returns>
        public static int Spin()
        {
            return rand.Next(360, 1080);
        }   
        
        /// <summary>
        /// Get's the value of the spin.
        /// </summary>
        /// <param name="spin"></param>
        /// <returns></returns>
        public static SpinValue getSpinValue(int spin)
        {
            double spinVal = spin / (1080.00 / 72.00);
            spin = Convert.ToInt32(Math.Floor(spinVal)) - 24;
            return WheelMoney[spin];
        }

    }



    /// <summary>
    /// BankRupt object for the wheel. Is a child of spinvalue so we can tell what the users spin landed on.
    /// </summary>
    public class bankRupt : SpinValue
    {
        public override int money { get; set; } = 0;
        public override bool isBankrupt { get; set; } = true;
    }

    /// <summary>
    /// Five Hundred object for the wheel. Is a child of spinvalue so we can tell what the users spin landed on.
    /// </summary>
    public class FiveHund : SpinValue
    {
        public override int money { get; set; } = 500;
        public override bool isBankrupt { get; set; } = false;
    }

    /// <summary>
    /// Eight Hundred object for the wheel. Is a child of spinvalue so we can tell what the users spin landed on.
    /// </summary>
    public class EightHund : SpinValue
    {
        public override int money { get; set; } = 800;
        public override bool isBankrupt { get; set; } = false;
    }

    /// <summary>
    /// Six Hundred and fifty object for the wheel. Is a child of spinvalue so we can tell what the users spin landed on.
    /// </summary>
    public class SixFifty : SpinValue
    {
        public override int money { get; set; } = 650;
        public override bool isBankrupt { get; set; } = false;
    }

    /// <summary>
    /// Nine Hundred object for the wheel. Is a child of spinvalue so we can tell what the users spin landed on.
    /// </summary>
    public class NineHund : SpinValue
    {
        public override int money { get; set; } = 900;
        public override bool isBankrupt { get; set; } = false;
    }

    /// <summary>
    /// One Thousand object for the wheel. Is a child of spinvalue so we can tell what the users spin landed on.
    /// </summary>
    public class OneThous : SpinValue
    {
        public override int money { get; set; } = 1000;
        public override bool isBankrupt { get; set; } = false;
    }

    /// <summary>
    /// Six Hundred object for the wheel. Is a child of spinvalue so we can tell what the users spin landed on.
    /// </summary>
    public class SixHund : SpinValue
    {
        public override int money { get; set; } = 600;
        public override bool isBankrupt { get; set; } = false;
    }

    /// <summary>
    /// Seven Hundred object for the wheel. Is a child of spinvalue so we can tell what the users spin landed on.
    /// </summary>
    public class SevenHund : SpinValue
    {
        public override int money { get; set; } = 700;
        public override bool isBankrupt { get; set; } = false;
    }

    /// <summary>
    /// Five Hundred and fifty object for the wheel. Is a child of spinvalue so we can tell what the users spin landed on.
    /// </summary>
    public class FiveFifty : SpinValue
    {
        public override int money { get; set; } = 550;
        public override bool isBankrupt { get; set; } = false;
    }

}
