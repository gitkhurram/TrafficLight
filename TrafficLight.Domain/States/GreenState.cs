namespace TrafficLight.Domain.States
{
    public class GreenState : TrafficLightState
    {   
        public override string StateName { get => "Green"; }
        public override enmLightState LightState { get => enmLightState.Green; }

        public GreenState(ITrafficLight TrafficLight, int MinTimeDuration, int MaxTimeDuration)
            :base(TrafficLight, MinTimeDuration, MaxTimeDuration)
        {   
        }

        public override enmLightState GetNextState()
        {
            return enmLightState.Yellow;
        }
    }
}
