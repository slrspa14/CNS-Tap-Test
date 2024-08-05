namespace CNS_Tap_Test
{
    partial class Graph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ctDaily = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ctDaily)).BeginInit();
            this.SuspendLayout();
            // 
            // ctDaily
            // 
            chartArea2.Name = "ChartArea1";
            this.ctDaily.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ctDaily.Legends.Add(legend2);
            this.ctDaily.Location = new System.Drawing.Point(12, 99);
            this.ctDaily.Name = "ctDaily";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ctDaily.Series.Add(series2);
            this.ctDaily.Size = new System.Drawing.Size(348, 339);
            this.ctDaily.TabIndex = 0;
            this.ctDaily.Text = "chart1";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(536, 134);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 247);
            this.textBox1.TabIndex = 1;
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ctDaily);
            this.Name = "Graph";
            this.Text = "Graph";
            ((System.ComponentModel.ISupportInitialize)(this.ctDaily)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ctDaily;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.TextBox textBox1;
    }
}