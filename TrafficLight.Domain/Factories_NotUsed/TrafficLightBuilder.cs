using System.Collections.Generic;
using TrafficLight.Domain.States;

namespace TrafficLight.Domain
{
     /// <summary>
     /// This class is not used in the code.
     /// </summary>
    public class TrafficLightBuilder : ITrafficLightBuilder<ITrafficLight>
    {   
        public ITrafficLight CreateDefaultTrafficLight(int DefaultDuration)
        {
            IDictionary<enmLightState, StateDuration> DicStateDurations = new Dictionary<enmLightState, StateDuration>();
            var DefaultStateDuration = new StateDuration(DefaultDuration, DefaultDuration);
            DicStateDurations.Add(enmLightState.Green, DefaultStateDuration);
            DicStateDurations.Add(enmLightState.Red, DefaultStateDuration);
            DicStateDurations.Add(enmLightState.Yellow, DefaultStateDuration);
            DicStateDurations.Add(enmLightState.YellowRed, DefaultStateDuration);

            return new TrafficLight(DicStateDurations);
        }

        public ITrafficLight CreateTrafficLight(TrafficLightState state, IDictionary<enmLightState, StateDuration> DicDurations)
        {   
            return new TrafficLight(state, DicDurations);
        }
    }
}
