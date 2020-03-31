namespace TrafficLight.Domain.States
{
    public class YellowRedCompositeState : TrafficLightState
    {   
        public override string StateName { get => "YellowRedComposite"; }
        public override enmLightState LightState { get => enmLightState.YellowRed; }
       
        public YellowRedCompositeState(ITrafficLight trafficLight, int MinTimeDuration, int MaxTimeDuration)
            : base(trafficLight, MinTimeDuration, MaxTimeDuration)
        {   
        }
        
        public override enmLightState GetNextState()
        {
            return enmLightState.Green;
        }
                
    }
}
