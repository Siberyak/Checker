using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Checker
{
    public partial class Form1 : Form
    {
        private Color _backColor;

        public Form1()
        {
            InitializeComponent();

            _timer.Enabled = false;
            _timer.Tick += (sender, args) => UpdateLog();

            _backColor = _logTextBox.BackColor;
        }

        private async Task UpdateLog()
        {
            await UpdateState();
            await Update(_logCommandTextBox, _logTextBox, StartStopTimer);
            _logTextBox.BackColor = _timer.Enabled ? Color.LightGoldenrodYellow : _backColor;
        }

        private void StartStopTimer(string content)
        {
            var state = _stateTextBox.Text;
            _timer.Enabled = state == "Planning";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await UpdateControls();
        }

        private async Task UpdateControls()
        {
            await Update
                (
                    _c1,
                    _r1,
                    x =>
                    {
                        var ena = false;
                        ena = bool.TryParse(x, out ena) && ena;
                        button5.Enabled = ena;
                        button3.Enabled = ena;
                        button2.Enabled = ena;
                    }
                );
            await Update
                (
                    _c2,
                    _r2,
                    x =>
                    {
                        var ena = false;
                        button4.Enabled = bool.TryParse(x, out ena) && ena;
                        button2.Enabled = button2.Enabled || ena;
                    }
                );

            await UpdateState();

            await UpdateLog();
        }

        private async Task UpdateState()
        {
            await Update
                (
                    _c3, _stateTextBox,
                    x =>
                    {
                        var oldState = _stateTextBox.Tag as string;
                        var ena = x == "Planned" || x == "Created";
                        button6.Enabled = ena;
                        button7.Enabled = ena;
                        _stateTextBox.Tag = x;


                        if (oldState != x && oldState == "Planning")
                        {
                            _refreshButton.PerformClick();
                        }
                    }
                );
        }

        async Task Update(TextBox c, TextBox r, Action<string> action = null)
        {
            var result = await Check(_baseAddressEdit.Text, c.Text, _projectIdEdit.Text);

            Action a = () =>
            {
                r.Text = result;
                action?.Invoke(result);
            };

            if (InvokeRequired)
                Invoke(a);
            else
                a();
        }

        static async Task<string> Check(string baseAddress, object method, object projectId)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseAddress);

            try
            {
                var response = await client.GetAsync($"{method}?projectId={projectId}");
                if (response.StatusCode != HttpStatusCode.OK)
                    return "error";

                var content = await response.Content.ReadAsStringAsync();
                return content;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        private async void Cli(object sender, EventArgs e)
        {
            var c = ((Button) sender).Text;

            await Check(_baseAddressEdit.Text, c, _projectIdEdit.Text);

            await UpdateControls();
        }
    }
}
