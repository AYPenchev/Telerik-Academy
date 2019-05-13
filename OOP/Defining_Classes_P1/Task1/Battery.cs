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

        public override string ToString()
        {
            return string.Format("\n    1.Battery model:  {0} \n    2.Idle hours:  {1}  \n    3.Talk hours:  {2} \n    4.Battery type:  {3} \n"
                                , this.Model, this.IdleHours, this.TalkHours, this.BatteryType);
        }
    }

    public enum BatteryType
    {
        Li_lon,
        NiMH,
        NiCd,
        Li_pol
    }
}
