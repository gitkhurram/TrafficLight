using System;
using Xunit;
using TrafficLight.Domain.States;
using TrafficLight.Domain;
using System.Collections.Generic;
using System.Collections;

namespace TrafficLight.Tests
{
    public class TrafficLightTest
    {
        IDictionary<enmLightState, StateDuration> dictionary;
        public TrafficLightTest()
        {
            dictionary = new Dictionary<enmLightState, StateDuration>();
            dictionary.Add(enmLightState.Green, new StateDuration() { MinDuration = 10, MaxDuration = 60 });
            dictionary.Add(enmLightState.Red, new StateDuration() { MinDuration = 10, MaxDuration = 10 });
            dictionary.Add(enmLightState.Yellow, new StateDuration() { MinDuration = 5, MaxDuration = 5 });
            dictionary.Add(enmLightState.YellowRed, new StateDuration() { MinDuration = 5, MaxDuration = 5 });
        }

        [Fact]
        public void InitialStateIsRed()
        {
            TrafficLight.Domain.TrafficLight tl = new Domain.TrafficLight(this.dictionary);
            Assert.True(enmLightState.Red == tl.CurrentState);
        }

        [Fact]        
        public async void HastenHasNoEffectOnRed()
        {
            TrafficLight.Domain.TrafficLight tl = new Domain.TrafficLight(this.dictionary);
            var CurrentStateDuration = await tl.GetCurrentStateDurationAsync();
            var CurrentState = tl.CurrentState;
            await tl.HastenAsync();

            Assert.Equal(CurrentState, tl.CurrentState);
            Assert.Equal(CurrentStateDuration, await tl.GetCurrentStateDurationAsync());
        }

        [Fact]
        public async void HastenHasEffectOnGreen()
        {
            this.dictionary[enmLightState.Green] = new StateDuration(10, 60);
            TrafficLight.Domain.TrafficLight tl = new Domain.TrafficLight(this.dictionary);
            await tl.ChangeStateAsync(enmLightState.Green);
            var CurrentState = tl.CurrentState;
            var CurrentStateDuration = await tl.GetCurrentStateDurationAsync();
            Assert.Equal(enmLightState.Green, CurrentState);
            Assert.True(await tl.GetCurrentStateDurationAsync() + 30 <= this.dictionary[enmLightState.Green].MaxDuration);
            await tl.HastenAsync();
            Assert.Equal(enmLightState.Green, tl.CurrentState);                        
            Assert.Equal(CurrentStateDuration += 30, await tl.GetCurrentStateDurationAsync());
        }
    } //end of test class
    
}
