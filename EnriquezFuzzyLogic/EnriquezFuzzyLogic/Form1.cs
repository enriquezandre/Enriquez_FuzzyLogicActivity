using DotFuzzy;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace EnriquezFuzzyLogic
{
    public partial class Form1 : Form
    {
        FuzzyEngine fe;
        MembershipFunctionCollection waterlevel, temp, heatknob;
        LinguisticVariable mywaterlevel, mytemp, myheatknob;
        FuzzyRuleCollection myrules;

        double water, heat, temperature;
        double targetTemperature = 100;
        bool exit = false;

        public Form1()
        {
            InitializeComponent();
            setMembers();
            setRules();
            setFuzzyEngine();
            setCharts();
        }

        public void setMembers()
        {
            waterlevel = new MembershipFunctionCollection();
            waterlevel.Add(new MembershipFunction("LOW", 1.0, 2.0, 2.0, 4.0));
            waterlevel.Add(new MembershipFunction("OK", 3.5, 5.5, 5.5, 7.0));
            waterlevel.Add(new MembershipFunction("HIGH", 6.5, 8.0, 8.0, 9.5));
            mywaterlevel = new LinguisticVariable("WATER_LEVEL", waterlevel);

            temp = new MembershipFunctionCollection();
            temp.Add(new MembershipFunction("VLOW", -1.0, 10.5, 10.5, 20.0));
            temp.Add(new MembershipFunction("LOW", 10.5, 25.5, 25.5, 40.0));
            temp.Add(new MembershipFunction("OK", 30.0, 50.5, 50.5, 80.0));
            temp.Add(new MembershipFunction("HIGH", 60.0, 85.0, 85.0, 95.5));
            mytemp = new LinguisticVariable("TEMPERATURE", temp);

            
            heatknob = new MembershipFunctionCollection();
            heatknob.Add(new MembershipFunction("V_LITTLE", -1.0, 1.0, 1.0, 2.0));
            heatknob.Add(new MembershipFunction("A_LITTLE", 1.5, 2.5, 2.5, 4.0));
            heatknob.Add(new MembershipFunction("A_GOOD_AMT", 3.5, 5.0, 5.0, 7.0));
            heatknob.Add(new MembershipFunction("A_LOT", 6.5, 7.0, 7.0, 8.5));
            heatknob.Add(new MembershipFunction("A_WHOLE_LOT", 7.5, 9.5, 9.5, 11.5));
            myheatknob = new LinguisticVariable("HEAT_KNOB", heatknob);
        }

        public void setRules()
        {
            myrules = new FuzzyRuleCollection();

            // LOW
            myrules.Add(new FuzzyRule("IF (WATER_LEVEL IS LOW) AND (TEMPERATURE IS VLOW) THEN HEAT_KNOB IS A_LOT"));
            myrules.Add(new FuzzyRule("IF (WATER_LEVEL IS LOW) AND (TEMPERATURE IS LOW) THEN HEAT_KNOB IS A_GOOD_AMT"));
            myrules.Add(new FuzzyRule("IF (WATER_LEVEL IS LOW) AND (TEMPERATURE IS OK) THEN HEAT_KNOB IS V_LITTLE"));
            myrules.Add(new FuzzyRule("IF (WATER_LEVEL IS LOW) AND (TEMPERATURE IS HIGH) THEN HEAT_KNOB IS V_LITTLE"));

            // OK
            myrules.Add(new FuzzyRule("IF (WATER_LEVEL IS OK) AND (TEMPERATURE IS VLOW) THEN HEAT_KNOB IS A_WHOLE_LOT"));
            myrules.Add(new FuzzyRule("IF (WATER_LEVEL IS OK) AND (TEMPERATURE IS LOW) THEN HEAT_KNOB IS A_LOT"));
            myrules.Add(new FuzzyRule("IF (WATER_LEVEL IS OK) AND (TEMPERATURE IS OK) THEN HEAT_KNOB IS A_GOOD_AMT"));
            myrules.Add(new FuzzyRule("IF (WATER_LEVEL IS OK) AND (TEMPERATURE IS HIGH) THEN HEAT_KNOB IS V_LITTLE"));

            // HIGH
            myrules.Add(new FuzzyRule("IF (WATER_LEVEL IS HIGH) AND (TEMPERATURE IS VLOW) THEN HEAT_KNOB IS A_WHOLE_LOT"));
            myrules.Add(new FuzzyRule("IF (WATER_LEVEL IS HIGH) AND (TEMPERATURE IS LOW) THEN HEAT_KNOB IS A_LOT"));
            myrules.Add(new FuzzyRule("IF (WATER_LEVEL IS HIGH) AND (TEMPERATURE IS OK) THEN HEAT_KNOB IS A_LOT"));
            myrules.Add(new FuzzyRule("IF (WATER_LEVEL IS HIGH) AND (TEMPERATURE IS HIGH) THEN HEAT_KNOB IS A_LITTLE"));
        }

        public void setFuzzyEngine()
        {
            fe = new FuzzyEngine();
            fe.LinguisticVariableCollection.Add(mywaterlevel);
            fe.LinguisticVariableCollection.Add(mytemp);
            fe.LinguisticVariableCollection.Add(myheatknob);
            fe.FuzzyRuleCollection = myrules;
        }

        public void setCharts()
        {
            //FOR TEMPERATURE
            tempChart.Series[0].Name = "Temperature";
            tempChart.Series[0].Color = Color.BlueViolet;
            tempChart.Series[0].ChartType = SeriesChartType.Line;
            tempChart.Series[0].Points.AddY(temperature);
            tempChart.ChartAreas[0].AxisY.Minimum = 0;
            tempChart.ChartAreas[0].AxisY.Maximum = 125;

            //FOR HEAT
            heatChart.Series[0].Name = "Heat";
            heatChart.Series[0].Color = Color.OrangeRed;
            heatChart.Series[0].ChartType = SeriesChartType.Line;
            heatChart.Series[0].Points.AddY(heat);
            heatChart.ChartAreas[0].AxisY.Minimum = 0;
            heatChart.ChartAreas[0].AxisY.Maximum = 10;
        }

        private void ONButton_Click(object sender, EventArgs e)
        {
            waterlevelTextBox.Enabled = false;
            ONButton.Enabled = false;
            OFFButton.Enabled = true;
            try
            {
                new Thread(() =>
                {
                    while (!exit)
                    {
                        if (!ONButton.Enabled)
                        {
                            fuzzifyvalues();
                        }
                        defuzzifyWaterLevel();
                        defuzzifyTemp();
                        defuzzifyHeatKnob();
                        updateChart();
                        Thread.Sleep(500);
                    }
                }).Start();
            }
            finally
            {
                exit = false;
            }
        }

        private void OFFButton_Click(object sender, EventArgs e)
        {
            ONButton.Enabled = true;
            OFFButton.Enabled = false;
        }

        public void fuzzifyvalues()
        {
            //FOR WATER LEVEL
            water = double.Parse(waterlevelTextBox.Text);
            mywaterlevel.InputValue = water;
            mywaterlevel.Fuzzify("LOW");

            //FOR TEMPERATURE
            mytemp.InputValue = temperature;
            mytemp.Fuzzify("VLOW");

            //FOR HEAT KNOB
            myheatknob.InputValue = heat;
            myheatknob.Fuzzify("V_LITTLE");
        }

        public void defuzzifyWaterLevel()
        {
            waterlevelDataLabel.Invoke((MethodInvoker)(() =>
            {
                waterlevelDataLabel.Text = "Level: \n" + water.ToString("f2");
            }));
        }

        public void defuzzifyTemp()
        {
            if (!ONButton.Enabled)
            {
                if (temperature < targetTemperature) temperature += heat;
                else temperature -= heat;
            }

            if (!OFFButton.Enabled)
            {
                temperature -= 5;
                if (temperature < 0) temperature = 0;
            }

            tempDataLabel.Invoke((MethodInvoker)(() =>
            {
                tempDataLabel.Text = "Temperature: \n" + temperature.ToString("f2") + " °C";
            }));
        }

        private void waterlevelTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (double.Parse(waterlevelTextBox.Text) < 0 || double.Parse(waterlevelTextBox.Text) > 10)
            {
                MessageBox.Show("INPUT MUST RANGE WITHIN 0 TO 10");
                waterlevelTextBox.Text = "";
                ONButton.Enabled = false;
                return;
            }
            ONButton.Enabled = true;
        }

        public void defuzzifyHeatKnob()
        {
            if (!ONButton.Enabled)
            {
                fe.Consequent = "HEAT_KNOB";
                heat = fe.Defuzzify();
            }
            if (!OFFButton.Enabled)
            {
                heat--;
                if (heat < 0) heat = 0;
            }

            heatknobDataLabel.Invoke((MethodInvoker)(() =>
            {
                heatknobDataLabel.Text = "Heat Knob: \n" + heat.ToString("f2") + " kW";
            }));
        }

        public void updateChart()
        {
            tempChart.Invoke((MethodInvoker)(() =>
            {
                if (tempChart.Series[0].Points.Count > 25) tempChart.Series[0].Points.RemoveAt(0);
                tempChart.Series[0].Points.AddY(temperature);
                tempChart.ChartAreas[0].AxisX.Minimum = tempChart.Series[0].Points[0].XValue;
                tempChart.ChartAreas[0].AxisX.Maximum = 25;
            }));

            heatChart.Invoke((MethodInvoker)(() =>
            {
                if (heatChart.Series[0].Points.Count > 25) heatChart.Series[0].Points.RemoveAt(0);
                heatChart.Series[0].Points.AddY(heat);
                heatChart.ChartAreas[0].AxisX.Minimum = tempChart.Series[0].Points[0].XValue;
                heatChart.ChartAreas[0].AxisX.Maximum = 25;
            }));
        }
        private void RESETButton_Click(object sender, EventArgs e)
        {
            exit = true;
            ONButton.Enabled = true;
            OFFButton.Enabled = false;
            waterlevelTextBox.Enabled = true;
            waterlevelTextBox.Text = "0";
            temperature = 0;
            heat = 0;
            tempChart.Series[0].Points.Clear();
            heatChart.Series[0].Points.Clear();
            setCharts();
        }
    }
}
