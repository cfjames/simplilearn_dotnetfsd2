using System;

namespace Phase1Section6._6
{
    public interface LEDTV
    {
        void SwitchOn();
        void SwitchOff();
        void SetChannel(int channelNumber);
    }

    public class SamsungLedTv : LEDTV
    {
        public void SwitchOn()
        {
            Console.WriteLine("Turning ON : Samsung TV");
        }
        public void SwitchOff()
        {
            Console.WriteLine("Turning OFF : Samsung TV");
        }
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine("Setting channel Number " + channelNumber + " on Samsung TV");
        }
    }

    public class SonyLedTv : LEDTV
    {
        public void SwitchOn()
        {
            Console.WriteLine("Turning ON : Sony TV");
        }
        public void SwitchOff()
        {
            Console.WriteLine("Turning OFF : Sony TV");
        }
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine("Setting channel Number " + channelNumber + " on Sony TV");
        }
    }

    public class PanasonicLedTv : LEDTV
    {
        public void SwitchOn()
        {
            Console.WriteLine("Turning ON : Panasonic TV");
        }
        public void SwitchOff()
        {
            Console.WriteLine("Turning OFF : Panasonic TV");
        }
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine("Setting channel Number " + channelNumber + " on Panasonic TV");
        }
    }

    public class UniversalLEDRemoteControl
    {
        protected LEDTV ledTv;
        public UniversalLEDRemoteControl(LEDTV ledTv)
        {
            this.ledTv = ledTv;
        }
        public void PressOnButton()
        {
            ledTv.SwitchOn();
        }        
        public void PressOffButton()
        {
            ledTv.SwitchOff();
        }
        public void SetChannel(int channelNumber)
        {
            ledTv.SetChannel(channelNumber);
        }
    }
}
