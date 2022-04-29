using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section6._8
{
    abstract class TransportTemplate
    {
        public abstract string StartEngine();
        public abstract string MoveForward();
        public abstract string StopEngine();

        public string Travel()
        {
            string val = "";
            val += StartEngine();
            val += "\n";
            val += MoveForward();
            val += "\n";
            val += StopEngine();
            val += "\n";

            return val;
        }
    }

    class Car : TransportTemplate
    {
        public override string StartEngine()
        {
            return "Turn key in ignition";
        }
        public override string MoveForward()
        {
            return "Put in gear and accelerate";
        }
        public override string StopEngine()
        {
            return "Put gear in neutral and turn off ignition";
        }
    }

    class Plane : TransportTemplate
    {
        public override string StartEngine()
        {
            return "Start Engines";
        }
        public override string MoveForward()
        {
            return "Pull yoke back and thrust engines to take off";
        }
        public override string StopEngine()
        {
            return "Put flaps down and wheels down and land plane and turn off engines";
        }
    }

}
