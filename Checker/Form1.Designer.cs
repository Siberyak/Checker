namespace Checker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._refreshButton = new System.Windows.Forms.Button();
            this._baseAddressEdit = new System.Windows.Forms.TextBox();
            this._c1 = new System.Windows.Forms.TextBox();
            this._r1 = new System.Windows.Forms.TextBox();
            this._projectIdEdit = new System.Windows.Forms.TextBox();
            this._r2 = new System.Windows.Forms.TextBox();
            this._c2 = new System.Windows.Forms.TextBox();
            this._stateTextBox = new System.Windows.Forms.TextBox();
            this._c3 = new System.Windows.Forms.TextBox();
            this._logTextBox = new System.Windows.Forms.TextBox();
            this._logCommandTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // _refreshButton
            // 
            this._refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._refreshButton.Location = new System.Drawing.Point(552, 10);
            this._refreshButton.Name = "_refreshButton";
            this._refreshButton.Size = new System.Drawing.Size(116, 100);
            this._refreshButton.TabIndex = 0;
            this._refreshButton.Text = "Refresh";
            this._refreshButton.UseVisualStyleBackColor = true;
            this._refreshButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // _baseAddressEdit
            // 
            this._baseAddressEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._baseAddressEdit.Enabled = false;
            this._baseAddressEdit.Location = new System.Drawing.Point(12, 12);
            this._baseAddressEdit.Name = "_baseAddressEdit";
            this._baseAddressEdit.Size = new System.Drawing.Size(432, 20);
            this._baseAddressEdit.TabIndex = 1;
            this._baseAddressEdit.Text = "http://localhost:8564/prediction/";
            // 
            // _c1
            // 
            this._c1.Enabled = false;
            this._c1.Location = new System.Drawing.Point(12, 38);
            this._c1.Name = "_c1";
            this._c1.Size = new System.Drawing.Size(96, 20);
            this._c1.TabIndex = 2;
            this._c1.Text = "canapply";
            // 
            // _r1
            // 
            this._r1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._r1.Location = new System.Drawing.Point(114, 38);
            this._r1.Name = "_r1";
            this._r1.Size = new System.Drawing.Size(432, 20);
            this._r1.TabIndex = 3;
            // 
            // _projectIdEdit
            // 
            this._projectIdEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._projectIdEdit.Location = new System.Drawing.Point(450, 12);
            this._projectIdEdit.Name = "_projectIdEdit";
            this._projectIdEdit.Size = new System.Drawing.Size(96, 20);
            this._projectIdEdit.TabIndex = 4;
            this._projectIdEdit.Text = "7001";
            this._projectIdEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _r2
            // 
            this._r2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._r2.Location = new System.Drawing.Point(114, 64);
            this._r2.Name = "_r2";
            this._r2.Size = new System.Drawing.Size(432, 20);
            this._r2.TabIndex = 6;
            // 
            // _c2
            // 
            this._c2.Enabled = false;
            this._c2.Location = new System.Drawing.Point(12, 64);
            this._c2.Name = "_c2";
            this._c2.Size = new System.Drawing.Size(96, 20);
            this._c2.TabIndex = 5;
            this._c2.Text = "cancreate";
            // 
            // _stateTextBox
            // 
            this._stateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._stateTextBox.Location = new System.Drawing.Point(114, 90);
            this._stateTextBox.Name = "_stateTextBox";
            this._stateTextBox.Size = new System.Drawing.Size(432, 20);
            this._stateTextBox.TabIndex = 8;
            // 
            // _c3
            // 
            this._c3.Enabled = false;
            this._c3.Location = new System.Drawing.Point(12, 90);
            this._c3.Name = "_c3";
            this._c3.Size = new System.Drawing.Size(96, 20);
            this._c3.TabIndex = 7;
            this._c3.Text = "state";
            // 
            // _logTextBox
            // 
            this._logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._logTextBox.Location = new System.Drawing.Point(114, 116);
            this._logTextBox.Multiline = true;
            this._logTextBox.Name = "_logTextBox";
            this._logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._logTextBox.Size = new System.Drawing.Size(554, 218);
            this._logTextBox.TabIndex = 10;
            // 
            // _logCommandTextBox
            // 
            this._logCommandTextBox.Enabled = false;
            this._logCommandTextBox.Location = new System.Drawing.Point(12, 116);
            this._logCommandTextBox.Name = "_logCommandTextBox";
            this._logCommandTextBox.Size = new System.Drawing.Size(96, 20);
            this._logCommandTextBox.TabIndex = 9;
            this._logCommandTextBox.Text = "log";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(12, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Cli);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(12, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Cli);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(12, 252);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Start";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Cli);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(12, 223);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Apply";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Cli);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(12, 167);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "SetPlanning";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Cli);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(12, 196);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "SetOrdering";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Cli);
            // 
            // _timer
            // 
            this._timer.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 346);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this._logTextBox);
            this.Controls.Add(this._logCommandTextBox);
            this.Controls.Add(this._stateTextBox);
            this.Controls.Add(this._c3);
            this.Controls.Add(this._r2);
            this.Controls.Add(this._c2);
            this.Controls.Add(this._projectIdEdit);
            this.Controls.Add(this._r1);
            this.Controls.Add(this._c1);
            this.Controls.Add(this._baseAddressEdit);
            this.Controls.Add(this._refreshButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _refreshButton;
        private System.Windows.Forms.TextBox _baseAddressEdit;
        private System.Windows.Forms.TextBox _c1;
        private System.Windows.Forms.TextBox _r1;
        private System.Windows.Forms.TextBox _projectIdEdit;
        private System.Windows.Forms.TextBox _r2;
        private System.Windows.Forms.TextBox _c2;
        private System.Windows.Forms.TextBox _stateTextBox;
        private System.Windows.Forms.TextBox _c3;
        private System.Windows.Forms.TextBox _logTextBox;
        private System.Windows.Forms.TextBox _logCommandTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Timer _timer;
    }
}

