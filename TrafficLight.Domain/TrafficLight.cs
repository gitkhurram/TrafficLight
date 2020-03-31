using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TrafficLight.Domain.States;

namespace TrafficLight.Domain
{
    public class TrafficLight : ITrafficLight
    {
        #region Attributes
        protected ITrafficLightState _CurrentState;
        protected IDictionary<enmLightState, StateDuration> _DicStateDurations;
        #endregion

        #region Properties
        public enmLightState CurrentState { get => this._CurrentState.LightState; }
        #endregion

        #region Events
        public event StateChangeEventHandler OnStateChanged;
        #endregion

        #region Constructors
        public TrafficLight(IDictionary<enmLightState, StateDuration> DicStateDurations)
        {   
            _DicStateDurations = DicStateDurations;            
            _CurrentState = new RedState(this, _DicStateDurations[enmLightState.Red].MinDuration, _DicStateDurations[enmLightState.Red].MaxDuration); ;
        }
        
        public TrafficLight(TrafficLightState InitialState, IDictionary<enmLightState, StateDuration> DicStateDurations)
        {
            _DicStateDurations = DicStateDurations;
            _CurrentState = InitialState;
        }
        #endregion

        #region Methods
        public async Task StartWorkAsync(CancellationToken ct)
        {
            await _CurrentState.WaitForDurationAsync();

            while(true)
            {
                if (ct.IsCancellationRequested)
                    break;

                await this.ChangeStateAsync(_CurrentState.GetNextState());
            }
        }

        public async Task ChangeStateAsync(enmLightState enmLightState)
        {
            switch (enmLightState)
            {
                case enmLightState.Red:
                    _CurrentState = new RedState(this, _DicStateDurations[enmLightState.Red].MinDuration, _DicStateDurations[enmLightState.Red].MaxDuration); ;
                    break;
                case enmLightState.Yellow:
                    _CurrentState = new YellowState(this, _DicStateDurations[enmLightState.Yellow].MinDuration, _DicStateDurations[enmLightState.Yellow].MaxDuration); ;
                    break;
                case enmLightState.Green:
                    _CurrentState = new GreenState(this, _DicStateDurations[enmLightState.Green].MinDuration, _DicStateDurations[enmLightState.Green].MaxDuration); ;
                    break;
                case enmLightState.YellowRed:
                    _CurrentState = new YellowRedCompositeState(this, _DicStateDurations[enmLightState.YellowRed].MinDuration, _DicStateDurations[enmLightState.YellowRed].MaxDuration);
                    break;
            }
            this.OnStateChanged?.Invoke(this, new StateChangedEventArgs(_CurrentState.LightState));            
            await _CurrentState.WaitForDurationAsync();
        }

        public async Task HastenAsync()
        {
            if(this._CurrentState.LightState == enmLightState.Green)
                this._CurrentState.IsHastenState = true;
        }

        public async Task SetStateDurationAsync(enmLightState state, StateDuration stateDuration)
        {
            await Task.Factory.StartNew(() => {this._DicStateDurations[state] = stateDuration; }).ConfigureAwait(false);
        }

        public async Task<int> GetCurrentStateDurationAsync()
        {   
            return this._CurrentState.TimeDuration;         
        }
        #endregion
    }
}
