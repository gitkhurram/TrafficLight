namespace TrafficLight.Domain.States
{
    public class YellowState : TrafficLightState
    {
        public override string StateName { get => "Yellow"; }
        public override enmLightState LightState { get => enmLightState.Yellow; }
        
        public YellowState(ITrafficLight trafficLight, int MinTimeDuration, int MaxTimeDuration)
            : base(trafficLight, MinTimeDuration, MaxTimeDuration)
        {   
        }

        public override enmLightState GetNextState()
        {
            return enmLightState.Red;
        }
    }
}
