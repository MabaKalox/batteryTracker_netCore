using System;

namespace BatteryTracker
{
    public static class BatteryInfo
    {
        public static float rate()
        {
            var voltagePair = "cat /sys/class/power_supply/BAT0/voltage_now".Bash();
            var currentPair = "cat /sys/class/power_supply/BAT0/current_now".Bash();
            if (string.IsNullOrEmpty(voltagePair.Item1) && string.IsNullOrEmpty(currentPair.Item1))
            {
                var voltage = float.Parse(voltagePair.Item2);
                var current = float.Parse(currentPair.Item2);
                return voltage * current * (float)Math.Pow(10, -12);
            }
            else
            {
                return 0.0f;
            }
        }
    }
}