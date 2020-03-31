namespace TrafficLight.Domain.States
{
    public class RedState : TrafficLightState
    {
        public override string StateName { get => "Red"; }
        public override enmLightState LightState { get => enmLightState.Red; }
        
        public RedState(ITrafficLight trafficLight, int MinTimeDuration, int MaxTimeDuration)
            : base(trafficLight, MinTimeDuration, MaxTimeDuration)
        {   
        }
        public override enmLightState GetNextState()
        {
            return enmLightState.YellowRed;
        }
       
    }
}
