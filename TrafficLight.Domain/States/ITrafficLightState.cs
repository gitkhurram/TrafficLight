using System.Threading.Tasks;

namespace TrafficLight.Domain.States
{
    public enum enmLightState
    { 
        Green = 0,
        Yellow = 1,
        Red = 2,
        YellowRed = 3
    }

    public struct StateDuration
    {
        public StateDuration(int MinDuration, int MaxDuration)
        {
            this.MinDuration = MinDuration;
            this.MaxDuration = MaxDuration;
        }

        public int MinDuration;
        public int MaxDuration;
    }


    public interface ITrafficLightState
    {
        enmLightState LightState { get; }
        string StateName { get; } 
        int TimeDuration { get; set; }
        int MinTimeDuration { get; set; }
        int MaxTimeDuration { get; set; }
        bool IsHastenState { get; set; }
        Task TransitAsync();
        enmLightState GetNextState();
        Task WaitForDurationAsync();
    }
}
