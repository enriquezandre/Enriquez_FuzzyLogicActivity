namespace EnriquezFuzzyLogic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tempChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.heatChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ONButton = new System.Windows.Forms.Button();
            this.waterLevelLabel = new System.Windows.Forms.Label();
            this.OFFButton = new System.Windows.Forms.Button();
            this.RESETButton = new System.Windows.Forms.Button();
            this.waterlevelTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.heatknobDataLabel = new System.Windows.Forms.Label();
            this.tempDataLabel = new System.Windows.Forms.Label();
            this.waterlevelDataLabel = new System.Windows.Forms.Label();
            this.fuzzyLogicLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tempChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tempChart
            // 
            chartArea1.Name = "ChartArea1";
            this.tempChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.tempChart.Legends.Add(legend1);
            this.tempChart.Location = new System.Drawing.Point(0, 0);
            this.tempChart.Name = "tempChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.tempChart.Series.Add(series1);
            this.tempChart.Size = new System.Drawing.Size(397, 300);
            this.tempChart.TabIndex = 0;
            this.tempChart.Text = "chart1";
            // 
            // heatChart
            // 
            chartArea2.Name = "ChartArea1";
            this.heatChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.heatChart.Legends.Add(legend2);
            this.heatChart.Location = new System.Drawing.Point(436, 0);
            this.heatChart.Name = "heatChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.heatChart.Series.Add(series2);
            this.heatChart.Size = new System.Drawing.Size(397, 300);
            this.heatChart.TabIndex = 1;
            this.heatChart.Text = "chart2";
            // 
            // ONButton
            // 
            this.ONButton.Enabled = false;
            this.ONButton.Location = new System.Drawing.Point(262, 343);
            this.ONButton.Name = "ONButton";
            this.ONButton.Size = new System.Drawing.Size(75, 23);
            this.ONButton.TabIndex = 4;
            this.ONButton.Text = "ON";
            this.ONButton.UseVisualStyleBackColor = true;
            this.ONButton.Click += new System.EventHandler(this.ONButton_Click);
            // 
            // waterLevelLabel
            // 
            this.waterLevelLabel.AutoSize = true;
            this.waterLevelLabel.Location = new System.Drawing.Point(37, 345);
            this.waterLevelLabel.Name = "waterLevelLabel";
            this.waterLevelLabel.Size = new System.Drawing.Size(68, 13);
            this.waterLevelLabel.TabIndex = 3;
            this.waterLevelLabel.Text = "Water Level:";
            // 
            // OFFButton
            // 
            this.OFFButton.Enabled = false;
            this.OFFButton.Location = new System.Drawing.Point(343, 345);
            this.OFFButton.Name = "OFFButton";
            this.OFFButton.Size = new System.Drawing.Size(75, 23);
            this.OFFButton.TabIndex = 5;
            this.OFFButton.Text = "OFF";
            this.OFFButton.UseVisualStyleBackColor = true;
            this.OFFButton.Click += new System.EventHandler(this.OFFButton_Click);
            // 
            // RESETButton
            // 
            this.RESETButton.Location = new System.Drawing.Point(424, 345);
            this.RESETButton.Name = "RESETButton";
            this.RESETButton.Size = new System.Drawing.Size(75, 23);
            this.RESETButton.TabIndex = 5;
            this.RESETButton.Text = "RESET";
            this.RESETButton.UseVisualStyleBackColor = true;
            this.RESETButton.Click += new System.EventHandler(this.RESETButton_Click);
            // 
            // waterlevelTextBox
            // 
            this.waterlevelTextBox.Location = new System.Drawing.Point(157, 345);
            this.waterlevelTextBox.Name = "waterlevelTextBox";
            this.waterlevelTextBox.Size = new System.Drawing.Size(99, 20);
            this.waterlevelTextBox.TabIndex = 2;
            this.waterlevelTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.waterlevelTextBox_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(749, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 8);
            this.panel1.TabIndex = 1;
            // 
            // heatknobDataLabel
            // 
            this.heatknobDataLabel.AutoSize = true;
            this.heatknobDataLabel.Location = new System.Drawing.Point(333, 391);
            this.heatknobDataLabel.Name = "heatknobDataLabel";
            this.heatknobDataLabel.Size = new System.Drawing.Size(61, 13);
            this.heatknobDataLabel.TabIndex = 0;
            this.heatknobDataLabel.Text = "Heat Knob:";
            // 
            // tempDataLabel
            // 
            this.tempDataLabel.AutoSize = true;
            this.tempDataLabel.Location = new System.Drawing.Point(529, 391);
            this.tempDataLabel.Name = "tempDataLabel";
            this.tempDataLabel.Size = new System.Drawing.Size(70, 13);
            this.tempDataLabel.TabIndex = 0;
            this.tempDataLabel.Text = "Temperature:";
            // 
            // waterlevelDataLabel
            // 
            this.waterlevelDataLabel.AutoSize = true;
            this.waterlevelDataLabel.Location = new System.Drawing.Point(154, 391);
            this.waterlevelDataLabel.Name = "waterlevelDataLabel";
            this.waterlevelDataLabel.Size = new System.Drawing.Size(36, 13);
            this.waterlevelDataLabel.TabIndex = 0;
            this.waterlevelDataLabel.Text = "Level:";
            // 
            // fuzzyLogicLabel
            // 
            this.fuzzyLogicLabel.AutoSize = true;
            this.fuzzyLogicLabel.Location = new System.Drawing.Point(37, 391);
            this.fuzzyLogicLabel.Name = "fuzzyLogicLabel";
            this.fuzzyLogicLabel.Size = new System.Drawing.Size(92, 13);
            this.fuzzyLogicLabel.TabIndex = 0;
            this.fuzzyLogicLabel.Text = "Fuzzy Logic Data:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 456);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tempDataLabel);
            this.Controls.Add(this.heatknobDataLabel);
            this.Controls.Add(this.waterlevelDataLabel);
            this.Controls.Add(this.RESETButton);
            this.Controls.Add(this.fuzzyLogicLabel);
            this.Controls.Add(this.waterlevelTextBox);
            this.Controls.Add(this.OFFButton);
            this.Controls.Add(this.ONButton);
            this.Controls.Add(this.heatChart);
            this.Controls.Add(this.tempChart);
            this.Controls.Add(this.waterLevelLabel);
            this.Name = "Form1";
            this.Text = "Enriquez Fuzzy Logic Activity";
            ((System.ComponentModel.ISupportInitialize)(this.tempChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart tempChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart heatChart;
        private System.Windows.Forms.Button ONButton;
        private System.Windows.Forms.Label waterLevelLabel;
        private System.Windows.Forms.Button OFFButton;
        private System.Windows.Forms.Button RESETButton;
        private System.Windows.Forms.TextBox waterlevelTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label heatknobDataLabel;
        private System.Windows.Forms.Label tempDataLabel;
        private System.Windows.Forms.Label waterlevelDataLabel;
        private System.Windows.Forms.Label fuzzyLogicLabel;
    }
}

