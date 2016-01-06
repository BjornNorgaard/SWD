﻿

using System;

namespace State
{
    public class Radio
    {
        // Get or Set the _power
        private PowerState _power;
        private VolumeState _volume;

        public VolumeState Volume
        {
            get { return _volume; }
            set
            {
                _volume = value;
                _volume.OnEnter(this);
            }
        }

        public PowerState Power
        {
            get { return _power; }
            set
            {
                _power = value;
                _power.OnEnter(this);
            }
        }

        // Constructor
        public Radio()
        {
            Power = new Off();
            //Volume = new LowVolume();
        }

        // Change _power
        public void ClickPWR()
        {
            Power.PowerButton(this);
        }

        public void ClickMODE()
        {
            Power.ModeButton(this);
        }

        public void ClickVOLUME()
        {
            Volume.VolumeBotton(this);
        }

        public void Action_OFF()
        {
            Console.WriteLine("I is OFF");
        }

        public void Action_FM()
        {
            Console.WriteLine("I is FM");
        }

        public void Action_DAB()
        {
            Console.WriteLine("I is DAB");
        }

        public void Action_LOUD()
        {
            Console.WriteLine("I is LOUD");
        }

        public void Action_QUIET()
        {
            Console.WriteLine("I is QUIET");
        }
    }
}