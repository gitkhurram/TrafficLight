using System.Collections.Generic;
using TrafficLight.Domain.States;

namespace TrafficLight.Domain
{
    public interface ITrafficLightBuilder<T> where T : ITrafficLight
    {
        T CreateDefaultTrafficLight(int DefaultDuration);
        T CreateTrafficLight(TrafficLightState state, IDictionary<enmLightState, StateDuration> DicDurations);
    }
}
