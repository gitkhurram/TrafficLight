using System;
using System.Threading;
using System.Threading.Tasks;
using TrafficLight.Domain.States;

namespace TrafficLight.Domain
{

    public class StateChangedEventArgs : EventArgs
    {
        public StateChangedEventArgs(enmLightState enmLightState)
        {
            this.NewState = enmLightState;
        }

        public enmLightState NewState { get; }
    }

    public delegate void StateChangeEventHandler(object source, StateChangedEventArgs args);

    public interface ITrafficLight
    {
        enmLightState CurrentState { get;}
        event StateChangeEventHandler OnStateChanged;
        Task ChangeStateAsync(enmLightState enmLightState);
        Task StartWorkAsync(CancellationToken ct);
        Task HastenAsync();           
        Task SetStateDurationAsync(enmLightState state, StateDuration stateDuration);
        Task<int> GetCurrentStateDurationAsync();
    }
}
