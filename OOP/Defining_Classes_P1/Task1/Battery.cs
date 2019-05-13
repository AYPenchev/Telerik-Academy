namespace Task1
{
    using System;

    class Battery
    {
        public Battery()
        {
            this.Model = string.Empty;
            this.IdleHours = null;
            this.TalkHours = null;
        }
        public Battery(string model = null, double? idleHours = null, double? talkHours = null, BatteryType? batteryType = null)
        {
            this.Model = model;
            this.IdleHours = idleHours;
            this.TalkHours = talkHours;
            this.BatteryType = batteryType;
        }

        public string Model { get; private set; }
        public double? IdleHours { get; private set; }
        public double? TalkHours { get; private set; }      
        public BatteryType? BatteryType { get; private set; }
    }

    public enum BatteryType
    {
        Li_lon,
        NiMH,
        NiCd,
        Li_pol
    }
}
