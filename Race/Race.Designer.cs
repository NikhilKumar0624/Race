namespace RacetrackSimulator
{
    partial class GOrun
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
            this.gamble = new System.Windows.Forms.GroupBox();
            this.Go_button = new System.Windows.Forms.Button();
            this.kateLB = new System.Windows.Forms.Label();
            this.TroyLB = new System.Windows.Forms.Label();
            this.JhonLB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Driver = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.NumericUpDown();
            this.PlaceBet = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.kateRB = new System.Windows.Forms.RadioButton();
            this.troyRB = new System.Windows.Forms.RadioButton();
            this.JhonRB = new System.Windows.Forms.RadioButton();
            this.carrun1 = new System.Windows.Forms.Timer(this.components);
            this.PBbicycle4 = new System.Windows.Forms.PictureBox();
            this.PBbicycle3 = new System.Windows.Forms.PictureBox();
            this.PBbicycle2 = new System.Windows.Forms.PictureBox();
            this.PBbicycle1 = new System.Windows.Forms.PictureBox();
            this.racetrack = new System.Windows.Forms.PictureBox();
            this.gamble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Driver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.money)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBbicycle4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBbicycle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBbicycle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBbicycle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            this.SuspendLayout();
            // 
            // gamble
            // 
            this.gamble.Controls.Add(this.Go_button);
            this.gamble.Controls.Add(this.kateLB);
            this.gamble.Controls.Add(this.TroyLB);
            this.gamble.Controls.Add(this.JhonLB);
            this.gamble.Controls.Add(this.label3);
            this.gamble.Controls.Add(this.Driver);
            this.gamble.Controls.Add(this.label2);
            this.gamble.Controls.Add(this.money);
            this.gamble.Controls.Add(this.PlaceBet);
            this.gamble.Controls.Add(this.NameLabel);
            this.gamble.Controls.Add(this.kateRB);
            this.gamble.Controls.Add(this.troyRB);
            this.gamble.Controls.Add(this.JhonRB);
            this.gamble.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamble.Location = new System.Drawing.Point(11, 461);
            this.gamble.Margin = new System.Windows.Forms.Padding(2);
            this.gamble.Name = "gamble";
            this.gamble.Padding = new System.Windows.Forms.Padding(2);
            this.gamble.Size = new System.Drawing.Size(1155, 277);
            this.gamble.TabIndex = 0;
            this.gamble.TabStop = false;
            this.gamble.Enter += new System.EventHandler(this.troy_Enter);
            // 
            // Go_button
            // 
            this.Go_button.Font = new System.Drawing.Font("Ink Free", 34F);
            this.Go_button.Location = new System.Drawing.Point(332, 36);
            this.Go_button.Margin = new System.Windows.Forms.Padding(2);
            this.Go_button.Name = "Go_button";
            this.Go_button.Size = new System.Drawing.Size(242, 98);
            this.Go_button.TabIndex = 13;
            this.Go_button.Text = "Race";
            this.Go_button.UseVisualStyleBackColor = true;
            this.Go_button.Click += new System.EventHandler(this.go_Click);
            // 
            // kateLB
            // 
            this.kateLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kateLB.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kateLB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kateLB.Location = new System.Drawing.Point(642, 159);
            this.kateLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kateLB.Name = "kateLB";
            this.kateLB.Size = new System.Drawing.Size(371, 33);
            this.kateLB.TabIndex = 12;
            this.kateLB.Text = "Kate";
            // 
            // TroyLB
            // 
            this.TroyLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TroyLB.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TroyLB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TroyLB.Location = new System.Drawing.Point(642, 99);
            this.TroyLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TroyLB.Name = "TroyLB";
            this.TroyLB.Size = new System.Drawing.Size(371, 32);
            this.TroyLB.TabIndex = 11;
            this.TroyLB.Text = "Troy";
            this.TroyLB.Click += new System.EventHandler(this.kate_Click);
            // 
            // JhonLB
            // 
            this.JhonLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JhonLB.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JhonLB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.JhonLB.Location = new System.Drawing.Point(642, 36);
            this.JhonLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.JhonLB.Name = "JhonLB";
            this.JhonLB.Size = new System.Drawing.Size(371, 32);
            this.JhonLB.TabIndex = 10;
            this.JhonLB.Text = "Jhon";
            this.JhonLB.Click += new System.EventHandler(this.Jhon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 9;
            // 
            // Driver
            // 
            this.Driver.Location = new System.Drawing.Point(578, 169);
            this.Driver.Margin = new System.Windows.Forms.Padding(2);
            this.Driver.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.Driver.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Driver.Name = "Driver";
            this.Driver.Size = new System.Drawing.Size(38, 23);
            this.Driver.TabIndex = 8;
            this.Driver.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 18F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(433, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "$ on Driver";
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(361, 168);
            this.money.Margin = new System.Windows.Forms.Padding(2);
            this.money.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(47, 23);
            this.money.TabIndex = 6;
            this.money.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // PlaceBet
            // 
            this.PlaceBet.Font = new System.Drawing.Font("Ink Free", 18F);
            this.PlaceBet.Location = new System.Drawing.Point(249, 155);
            this.PlaceBet.Margin = new System.Windows.Forms.Padding(2);
            this.PlaceBet.Name = "PlaceBet";
            this.PlaceBet.Size = new System.Drawing.Size(83, 44);
            this.PlaceBet.TabIndex = 5;
            this.PlaceBet.Text = "Bets";
            this.PlaceBet.UseVisualStyleBackColor = true;
            this.PlaceBet.Click += new System.EventHandler(this.Bet_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(170, 162);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(75, 30);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Player";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // kateRB
            // 
            this.kateRB.AutoSize = true;
            this.kateRB.Font = new System.Drawing.Font("Ink Free", 18F);
            this.kateRB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kateRB.Location = new System.Drawing.Point(15, 138);
            this.kateRB.Margin = new System.Windows.Forms.Padding(2);
            this.kateRB.Name = "kateRB";
            this.kateRB.Size = new System.Drawing.Size(129, 34);
            this.kateRB.TabIndex = 3;
            this.kateRB.TabStop = true;
            this.kateRB.Text = "SamRadio";
            this.kateRB.UseVisualStyleBackColor = true;
            this.kateRB.CheckedChanged += new System.EventHandler(this.kateRadioButton_CheckedChanged);
            // 
            // troyRB
            // 
            this.troyRB.AutoSize = true;
            this.troyRB.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.troyRB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.troyRB.Location = new System.Drawing.Point(15, 84);
            this.troyRB.Margin = new System.Windows.Forms.Padding(2);
            this.troyRB.Name = "troyRB";
            this.troyRB.Size = new System.Drawing.Size(132, 34);
            this.troyRB.TabIndex = 2;
            this.troyRB.TabStop = true;
            this.troyRB.Text = "TroyRadio";
            this.troyRB.UseVisualStyleBackColor = true;
            this.troyRB.CheckedChanged += new System.EventHandler(this.troyRadioButton_CheckedChanged);
            // 
            // JhonRB
            // 
            this.JhonRB.AutoSize = true;
            this.JhonRB.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JhonRB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.JhonRB.Location = new System.Drawing.Point(15, 32);
            this.JhonRB.Margin = new System.Windows.Forms.Padding(2);
            this.JhonRB.Name = "JhonRB";
            this.JhonRB.Size = new System.Drawing.Size(133, 34);
            this.JhonRB.TabIndex = 1;
            this.JhonRB.TabStop = true;
            this.JhonRB.Text = "JhonRadio";
            this.JhonRB.UseVisualStyleBackColor = true;
            this.JhonRB.CheckedChanged += new System.EventHandler(this.jhonRadioButton_CheckedChanged);
            // 
            // carrun1
            // 
            this.carrun1.Tick += new System.EventHandler(this.carrun_Tick);
            // 
            // PBbicycle4
            // 
            this.PBbicycle4.Image = global::Race.Properties.Resources.source;
            this.PBbicycle4.Location = new System.Drawing.Point(11, 328);
            this.PBbicycle4.Margin = new System.Windows.Forms.Padding(2);
            this.PBbicycle4.Name = "PBbicycle4";
            this.PBbicycle4.Size = new System.Drawing.Size(131, 99);
            this.PBbicycle4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBbicycle4.TabIndex = 5;
            this.PBbicycle4.TabStop = false;
            // 
            // PBbicycle3
            // 
            this.PBbicycle3.Image = global::Race.Properties.Resources.carrr;
            this.PBbicycle3.Location = new System.Drawing.Point(11, 231);
            this.PBbicycle3.Margin = new System.Windows.Forms.Padding(2);
            this.PBbicycle3.Name = "PBbicycle3";
            this.PBbicycle3.Size = new System.Drawing.Size(131, 93);
            this.PBbicycle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBbicycle3.TabIndex = 4;
            this.PBbicycle3.TabStop = false;
            // 
            // PBbicycle2
            // 
            this.PBbicycle2.Image = global::Race.Properties.Resources.car_body;
            this.PBbicycle2.Location = new System.Drawing.Point(11, 133);
            this.PBbicycle2.Margin = new System.Windows.Forms.Padding(2);
            this.PBbicycle2.Name = "PBbicycle2";
            this.PBbicycle2.Size = new System.Drawing.Size(131, 94);
            this.PBbicycle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBbicycle2.TabIndex = 3;
            this.PBbicycle2.TabStop = false;
            // 
            // PBbicycle1
            // 
            this.PBbicycle1.Image = global::Race.Properties.Resources._9540acd8d44f2b768a2de171cc62a7e5;
            this.PBbicycle1.Location = new System.Drawing.Point(11, 31);
            this.PBbicycle1.Margin = new System.Windows.Forms.Padding(2);
            this.PBbicycle1.Name = "PBbicycle1";
            this.PBbicycle1.Size = new System.Drawing.Size(131, 98);
            this.PBbicycle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBbicycle1.TabIndex = 2;
            this.PBbicycle1.TabStop = false;
            // 
            // racetrack
            // 
            this.racetrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.racetrack.Image = global::Race.Properties.Resources.three_lane_autosport_racing_track_motorsport_background_vector_flat_illustration_start_finish_line_three_lane_autosport_race_132771488;
            this.racetrack.Location = new System.Drawing.Point(1, 11);
            this.racetrack.Margin = new System.Windows.Forms.Padding(2);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(1211, 446);
            this.racetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrack.TabIndex = 1;
            this.racetrack.TabStop = false;
            // 
            // GOrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1200, 668);
            this.Controls.Add(this.PBbicycle4);
            this.Controls.Add(this.PBbicycle3);
            this.Controls.Add(this.PBbicycle2);
            this.Controls.Add(this.PBbicycle1);
            this.Controls.Add(this.gamble);
            this.Controls.Add(this.racetrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GOrun";
            this.Text = "Race";
            this.gamble.ResumeLayout(false);
            this.gamble.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Driver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.money)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBbicycle4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBbicycle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBbicycle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBbicycle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gamble;
        private System.Windows.Forms.PictureBox PBbicycle1;
        private System.Windows.Forms.PictureBox PBbicycle2;
        private System.Windows.Forms.PictureBox PBbicycle3;
        private System.Windows.Forms.PictureBox PBbicycle4;
        private System.Windows.Forms.Button Go_button;
        private System.Windows.Forms.Label kateLB;
        private System.Windows.Forms.Label TroyLB;
        private System.Windows.Forms.Label JhonLB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Driver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown money;
        private System.Windows.Forms.Button PlaceBet;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.RadioButton kateRB;
        private System.Windows.Forms.RadioButton troyRB;
        private System.Windows.Forms.RadioButton JhonRB;
        private System.Windows.Forms.Timer carrun1;
        private System.Windows.Forms.PictureBox racetrack;
    }
}

