namespace ObjectGroup
{
    partial class MainWindow
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
            this._picView = new System.Windows.Forms.PictureBox();
            this._btnRandom = new System.Windows.Forms.Button();
            this._btnSolve = new System.Windows.Forms.Button();
            this._btnVisualSolve = new System.Windows.Forms.Button();
            this._tmrSolve = new System.Windows.Forms.Timer(this.components);
            this._lblSolving = new System.Windows.Forms.Label();
            this._nudSpeed = new System.Windows.Forms.NumericUpDown();
            this._btnStop = new System.Windows.Forms.Button();
            this._nudGroups = new System.Windows.Forms.NumericUpDown();
            this._lblGroups = new System.Windows.Forms.Label();
            this._nudSize = new System.Windows.Forms.NumericUpDown();
            this._lblSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._picView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudSize)).BeginInit();
            this.SuspendLayout();
            // 
            // _picView
            // 
            this._picView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._picView.Location = new System.Drawing.Point(12, 12);
            this._picView.Name = "_picView";
            this._picView.Size = new System.Drawing.Size(482, 482);
            this._picView.TabIndex = 0;
            this._picView.TabStop = false;
            // 
            // _btnRandom
            // 
            this._btnRandom.Location = new System.Drawing.Point(500, 95);
            this._btnRandom.Name = "_btnRandom";
            this._btnRandom.Size = new System.Drawing.Size(126, 32);
            this._btnRandom.TabIndex = 1;
            this._btnRandom.Text = "Randomize";
            this._btnRandom.UseVisualStyleBackColor = true;
            this._btnRandom.Click += new System.EventHandler(this._btnRandom_Click);
            // 
            // _btnSolve
            // 
            this._btnSolve.Location = new System.Drawing.Point(500, 133);
            this._btnSolve.Name = "_btnSolve";
            this._btnSolve.Size = new System.Drawing.Size(126, 32);
            this._btnSolve.TabIndex = 2;
            this._btnSolve.Text = "Fast Solve";
            this._btnSolve.UseVisualStyleBackColor = true;
            this._btnSolve.Click += new System.EventHandler(this._btnSolve_Click);
            // 
            // _btnVisualSolve
            // 
            this._btnVisualSolve.Location = new System.Drawing.Point(500, 171);
            this._btnVisualSolve.Name = "_btnVisualSolve";
            this._btnVisualSolve.Size = new System.Drawing.Size(126, 32);
            this._btnVisualSolve.TabIndex = 3;
            this._btnVisualSolve.Text = "Visual Solve";
            this._btnVisualSolve.UseVisualStyleBackColor = true;
            this._btnVisualSolve.Click += new System.EventHandler(this._btnVisualSolve_Click);
            // 
            // _tmrSolve
            // 
            this._tmrSolve.Tick += new System.EventHandler(this._tmrSolve_Tick);
            // 
            // _lblSolving
            // 
            this._lblSolving.AutoSize = true;
            this._lblSolving.Location = new System.Drawing.Point(503, 14);
            this._lblSolving.Name = "_lblSolving";
            this._lblSolving.Size = new System.Drawing.Size(79, 13);
            this._lblSolving.TabIndex = 4;
            this._lblSolving.Text = "Solving Speed:";
            // 
            // _nudSpeed
            // 
            this._nudSpeed.Location = new System.Drawing.Point(588, 12);
            this._nudSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._nudSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nudSpeed.Name = "_nudSpeed";
            this._nudSpeed.Size = new System.Drawing.Size(38, 20);
            this._nudSpeed.TabIndex = 5;
            this._nudSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nudSpeed.ValueChanged += new System.EventHandler(this._nudSpeed_ValueChanged);
            // 
            // _btnStop
            // 
            this._btnStop.Enabled = false;
            this._btnStop.Location = new System.Drawing.Point(500, 209);
            this._btnStop.Name = "_btnStop";
            this._btnStop.Size = new System.Drawing.Size(126, 32);
            this._btnStop.TabIndex = 6;
            this._btnStop.Text = "Stop";
            this._btnStop.UseVisualStyleBackColor = true;
            this._btnStop.Click += new System.EventHandler(this._btnStop_Click);
            // 
            // _nudGroups
            // 
            this._nudGroups.Location = new System.Drawing.Point(588, 38);
            this._nudGroups.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this._nudGroups.Name = "_nudGroups";
            this._nudGroups.Size = new System.Drawing.Size(38, 20);
            this._nudGroups.TabIndex = 8;
            this._nudGroups.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // _lblGroups
            // 
            this._lblGroups.AutoSize = true;
            this._lblGroups.Location = new System.Drawing.Point(538, 40);
            this._lblGroups.Name = "_lblGroups";
            this._lblGroups.Size = new System.Drawing.Size(44, 13);
            this._lblGroups.TabIndex = 7;
            this._lblGroups.Text = "Groups:";
            // 
            // _nudSize
            // 
            this._nudSize.Location = new System.Drawing.Point(588, 64);
            this._nudSize.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this._nudSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this._nudSize.Name = "_nudSize";
            this._nudSize.Size = new System.Drawing.Size(38, 20);
            this._nudSize.TabIndex = 10;
            this._nudSize.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // _lblSize
            // 
            this._lblSize.AutoSize = true;
            this._lblSize.Location = new System.Drawing.Point(552, 66);
            this._lblSize.Name = "_lblSize";
            this._lblSize.Size = new System.Drawing.Size(30, 13);
            this._lblSize.TabIndex = 9;
            this._lblSize.Text = "Size:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 504);
            this.Controls.Add(this._nudSize);
            this.Controls.Add(this._lblSize);
            this.Controls.Add(this._nudGroups);
            this.Controls.Add(this._lblGroups);
            this.Controls.Add(this._btnStop);
            this.Controls.Add(this._nudSpeed);
            this.Controls.Add(this._lblSolving);
            this.Controls.Add(this._btnVisualSolve);
            this.Controls.Add(this._btnSolve);
            this.Controls.Add(this._btnRandom);
            this.Controls.Add(this._picView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ObjectGroup";
            ((System.ComponentModel.ISupportInitialize)(this._picView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _picView;
        private System.Windows.Forms.Button _btnRandom;
        private System.Windows.Forms.Button _btnSolve;
        private System.Windows.Forms.Button _btnVisualSolve;
        private System.Windows.Forms.Timer _tmrSolve;
        private System.Windows.Forms.Label _lblSolving;
        private System.Windows.Forms.NumericUpDown _nudSpeed;
        private System.Windows.Forms.Button _btnStop;
        private System.Windows.Forms.NumericUpDown _nudGroups;
        private System.Windows.Forms.Label _lblGroups;
        private System.Windows.Forms.NumericUpDown _nudSize;
        private System.Windows.Forms.Label _lblSize;
    }
}

