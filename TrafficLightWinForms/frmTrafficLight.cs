using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafficLight.Domain;
using TrafficLight.Domain.States;

namespace TrafficLightWinForms
{
    public partial class frmTrafficLight : Form
    {
        ITrafficLight trafficLight;
        Task trafficLightWorker;
        CancellationTokenSource CTS;

        public frmTrafficLight()
        {
            InitializeComponent();            
        }

        public async Task InitiateTrafficLightAsync()
        {
            IDictionary<enmLightState, StateDuration> DicStateDurations = new Dictionary<enmLightState, StateDuration>();
            DicStateDurations.Add(enmLightState.Green, new StateDuration() { MinDuration = int.Parse(this.txtGreenMinDuration.Text), MaxDuration = int.Parse(this.txtGreenMaxDuration.Text) });
            DicStateDurations.Add(enmLightState.Red, new StateDuration() { MinDuration = int.Parse(this.txtRedMinDuration.Text), MaxDuration = int.Parse(this.txtRedMaxDuration.Text) });
            DicStateDurations.Add(enmLightState.Yellow, new StateDuration() { MinDuration = int.Parse(this.txtYellowMinDuration.Text), MaxDuration = int.Parse(this.txtYellowMaxDuration.Text) });
            DicStateDurations.Add(enmLightState.YellowRed, new StateDuration() { MinDuration = 5, MaxDuration = 5 });

            this.trafficLight = new TrafficLight.Domain.TrafficLight(DicStateDurations);
            this.trafficLight.OnStateChanged += TrafficLight_OnStateChanged;

            RefreshState(this.trafficLight.CurrentState);
        }

        private async Task StartWorkAsync()
        {
            try
            {   
                CTS = new CancellationTokenSource();
                var token = CTS.Token;

                if (this.trafficLight == null)
                    await this.InitiateTrafficLightAsync();

                trafficLightWorker = Task.Factory.StartNew(() => trafficLight.StartWorkAsync(token));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StopWork()
        {
            CTS.Cancel();
        }


        private void RefreshState(enmLightState state)
        {
            this.RefreshStateImage(state);
            this.RefreshDurationLabels(state);
        }

        private async void RefreshStateImage(enmLightState state)
        {
            if (this.trafficLight == null)
                return;

            switch (state)
            {
                case enmLightState.Green:
                    this.imgTrafficLight.ImageLocation = @"TrafficLightImages\Green.png";
                    break;
                case enmLightState.Red:
                    this.imgTrafficLight.ImageLocation = @"TrafficLightImages\Red.png";
                    break;
                case enmLightState.Yellow:
                    this.imgTrafficLight.ImageLocation = @"TrafficLightImages\Yellow.png";
                    break;
                case enmLightState.YellowRed:
                    this.imgTrafficLight.ImageLocation = @"TrafficLightImages\YellowRed.png";
                    break;
            }
        }

        private async void RefreshDurationLabels(enmLightState state)
        {
            var duration = await this.trafficLight.GetCurrentStateDurationAsync();

            switch (state)
            {
                case enmLightState.Green:
                    this.lblGreenDuration.Text = duration.ToString();
                    break;
                case enmLightState.Red:
                    this.lblRedDuration.Text = duration.ToString();
                    break;
                case enmLightState.Yellow:
                    this.lblYellowDuration.Text = duration.ToString();
                    break;
                case enmLightState.YellowRed:
                    this.lblYellowDuration.Text = duration.ToString();
                    break;
            }
        }

        private void TrafficLight_OnStateChanged(object source, StateChangedEventArgs args)
        {
            RefreshState(args.NewState);
        }

        private void btnStopWork_Click(object sender, EventArgs e)
        {
            this.StopWork();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            this.StartWorkAsync();
        }

        private void txtRedMinDuration_TextChanged(object sender, EventArgs e)
        {
            if(this.trafficLight != null)
                this.trafficLight.SetStateDurationAsync(enmLightState.Red, new StateDuration(int.Parse(this.txtRedMinDuration.Text), int.Parse(this.txtRedMaxDuration.Text)));
        }

        private void txtRedMaxDuration_TextChanged(object sender, EventArgs e)
        {
            if (this.trafficLight != null)
                this.trafficLight.SetStateDurationAsync(enmLightState.Red, new StateDuration(int.Parse(this.txtRedMinDuration.Text), int.Parse(this.txtRedMaxDuration.Text)));
        }

        private void txtYellowMinDuration_TextChanged(object sender, EventArgs e)
        {
            if (this.trafficLight != null)
                this.trafficLight.SetStateDurationAsync(enmLightState.Yellow, new StateDuration(int.Parse(this.txtYellowMinDuration.Text), int.Parse(this.txtYellowMaxDuration.Text)));
        }

        private void txtYellowMaxDuration_TextChanged(object sender, EventArgs e)
        {
            if (this.trafficLight != null)
                this.trafficLight.SetStateDurationAsync(enmLightState.Yellow, new StateDuration(int.Parse(this.txtYellowMinDuration.Text), int.Parse(this.txtYellowMaxDuration.Text)));
        }

        private void txtGreenMinDuration_TextChanged(object sender, EventArgs e)
        {
            if (this.trafficLight != null)
                this.trafficLight.SetStateDurationAsync(enmLightState.Green, new StateDuration(int.Parse(this.txtGreenMinDuration.Text), int.Parse(this.txtYellowMaxDuration.Text)));
        }

        private void txtGreenMaxDuration_TextChanged(object sender, EventArgs e)
        {
            if (this.trafficLight != null)
                this.trafficLight.SetStateDurationAsync(enmLightState.Green, new StateDuration(int.Parse(this.txtGreenMinDuration.Text), int.Parse(this.txtYellowMaxDuration.Text)));
        }

        private async void btnHasten_Click(object sender, EventArgs e)
        {
            if (this.trafficLight != null)
            {
                await this.trafficLight.HastenAsync();
                this.RefreshState(this.trafficLight.CurrentState);
            }
        }
    }
}
