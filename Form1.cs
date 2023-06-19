using LiveCharts.Wpf;
using LiveCharts;
using LiveCharts.Wpf.Charts.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using LiveCharts.WinForms;
using LiveCharts.Definitions.Charts;

namespace Kryptonite_UI___17._6._23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create a new panel control
            Panel panel3 = new Panel();
            panel3.Dock = DockStyle.Fill;

            // Add the panel control to your form
            this.Controls.Add(panel3);

            // Set the Location and Size properties of the chart control
            chart.Location = new Point(0, 0);
            chart.Size = new Size(784, 431);

            // Add the chart control to panel3
            chart.Parent = panel3;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\temp";
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string directoryPath = Path.GetDirectoryName(filePath);
                string fileName = Path.GetFileName(filePath);

                FileSystemWatcher watcher = new FileSystemWatcher();
                watcher.Path = directoryPath;
                watcher.Filter = fileName;
                watcher.Changed += new FileSystemEventHandler(OnChanged);
                watcher.EnableRaisingEvents = true;
            }
        }
        private void UpdateChartAndPieChart(string filePath)
        {
            // Read the data from the file
            string[] lines = File.ReadAllLines(filePath);

            // Create a DataTable to store the data
            DataTable table = new DataTable();
            table.Columns.Add("X", typeof(int));
            table.Columns.Add("Y", typeof(double));

            // Populate the DataTable with the data from the file
            for (int i = 0; i < lines.Length; i++)
            {
                table.Rows.Add(i + 1, double.Parse(lines[i]));
            }

            // Create a series for the Chart control
            chart.Series.Clear();
            chart.Series.Add("Series1");
            chart.Series["Series1"].ChartType = SeriesChartType.Line;
            chart.Series["Series1"].XValueMember = "X";
            chart.Series["Series1"].YValueMembers = "Y";

            // Bind the DataTable to the Chart control
            chart.DataSource = table;
            chart.DataBind();

            // Set the title for the X axis of the Chart control
            chart.ChartAreas[0].AxisX.Title = "Nth Value";

            // Set the title for the Y axis of the Chart control
            chart.ChartAreas[0].AxisY.Title = "Time";
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            this.Invoke(new Action(() => UpdateChartAndPieChart(e.FullPath)));
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            chart.Visible = true;
            chart.Location = new Point(10, 10);
            chart.Size = new Size(300, 300);

        }

        private void elementHost1_ChildChanged_1(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
