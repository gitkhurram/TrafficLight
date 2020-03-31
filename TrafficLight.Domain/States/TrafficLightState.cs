using System.Threading;
using System.Threading.Tasks;

namespace TrafficLight.Domain.States
{
    public abstract class TrafficLightState : ITrafficLightState
    {
        protected ITrafficLight _TrafficLight;
        protected int _TimeDuration;
        protected int _MinTimeDuration;
        protected int _MaxTimeDuration;
        protected bool _IsHastenState = false;

        public abstract string StateName { get; }
        public abstract enmLightState LightState { get; }
        public int TimeDuration
        {
            get => this._TimeDuration;
            set
            {
                if (value < MinTimeDuration)
                    _TimeDuration = MinTimeDuration;
                else if (value > MaxTimeDuration)
                    _TimeDuration = MaxTimeDuration;
                else
                    _TimeDuration = value;
            }
        }

        public int MinTimeDuration 
        { 
            get => _MinTimeDuration;
            set 
            { 
                _MinTimeDuration = value;

                if (this._TimeDuration < value)
                    this._TimeDuration = value;
            }
        }

        public int MaxTimeDuration
        {
            get => _MaxTimeDuration;
            set
            {
                _MaxTimeDuration = value;

                if (this._TimeDuration > value)
                    this._TimeDuration = value;
            }
        }

        public object IsHastenStateLock = new object();
        public bool IsHastenState 
        { 
            get => this._IsHastenState; 
            set 
            {    
                this._IsHastenState = value;
                this.TimeDuration = (TimeDuration + 30) <= this.MaxTimeDuration ? this.TimeDuration + 30 : MaxTimeDuration;                
            } 
        }

        public TrafficLightState(ITrafficLight TrafficLight, int MinTimeDuration, int MaxTimeDuration)
        {
            _TrafficLight = TrafficLight;            
            this.MinTimeDuration = MinTimeDuration;
            this.MaxTimeDuration = MaxTimeDuration;
        }

        public async virtual Task TransitAsync()
        {   
            await this._TrafficLight.ChangeStateAsync(this.GetNextState());
        }

        //public async Task WaitForDurationAsync()
        //{
        //    var WaitedTime = this.TimeDuration;

        //    Thread.Sleep(WaitedTime * 1000);

        //    while(this.IsHastenState)
        //    {
        //        object x = this.IsHastenState;
        //        lock(x)
        //        {
        //            this.IsHastenState = false;
        //        }
        //        var WaitTime = (WaitedTime + 10) <= this.MaxTimeDuration ? 10 : WaitedTime + 10 - MaxTimeDuration;                
        //        Thread.Sleep(WaitTime * 1000);
        //        WaitedTime += WaitTime;         
        //    }
        //}

        public async Task WaitForDurationAsync()
        {
            var WaitedTime = this.TimeDuration;

            Thread.Sleep(WaitedTime * 1000);

            while (this.IsHastenState)
            {   
                lock (IsHastenStateLock)
                {
                    this.IsHastenState = false;
                }
                var WaitTime = (WaitedTime + 30) <= this.MaxTimeDuration ? 30 : WaitedTime + 30 - MaxTimeDuration;
                Thread.Sleep(WaitTime * 1000);
                WaitedTime += WaitTime;
            }
        }

        public abstract enmLightState GetNextState();        
    }
}
