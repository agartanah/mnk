using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mnk {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    List<double> xValues = new List<double>();
    List<double> yValues = new List<double>();
    string[] func = new string[3];
    double[] deters = new double[3];

    private void Form1_Load(object sender, EventArgs e) {
      dataGridView1.RowHeadersVisible = false;

      labelLinear.BringToFront();
      labelParabol.BringToFront();
      labelParam.BringToFront();
      labelLinearRes.BringToFront();
      labelParabolRes.BringToFront();
      labelParamRes.BringToFront();
      labelParabol.Location = new System.Drawing.Point(10, 10);
      labelParam.Location = new System.Drawing.Point(10, 10);
      labelLinear.Location = new System.Drawing.Point(10, 10);

      panel1.SendToBack();
      panel1.AutoScroll = true;
      panel2.SendToBack();
      panel2.AutoScroll = true;
      panel3.SendToBack();
      panel3.AutoScroll = true;
      panel4.SendToBack();
      panel4.AutoScroll = true;
      panel5.SendToBack();
      panel5.AutoScroll = true;
      panel6.SendToBack();
      panel6.AutoScroll = true;
      panel1.Controls.Add(labelLinear);
      panel2.Controls.Add(labelParabol);
      panel3.Controls.Add(labelParam);
      panel4.Controls.Add(labelLinearRes);
      panel5.Controls.Add(labelParabolRes);
      panel6.Controls.Add(labelParamRes);

      MnkMethods.idsNames = new string[] { "x", "e", "pi" };
      MnkMethods.idsValues = new double[] { default, Math.E, Math.PI };

      label4.Text = string.Empty;

      openFileDialog1.Filter = "Excel File|*.xlsx;*.xls";
      openFileDialog1.DefaultExt = ".xls";
    }

    private void button1_Click(object sender, EventArgs e) {
      xValues.Clear();
      yValues.Clear();
      chart1.Series[3].Points.Clear();

      try {
        ReadDataGrid();
      } catch(Exception ex) {
        label4.Text = ex.Message;

        return;
      }

      for (int index = 0; index < xValues.Count; ++index) {
        chart1.Series[3].Points.AddXY(xValues[index], yValues[index]);
      }

      if (checkBox1.Checked) {
        double[] linearParams = MnkMethods.LinearRegression(xValues, yValues);

        labelLinear.Text = $"f(x) = ";
        func[0] = $"{linearParams[0]}*x";

        if (linearParams[1] < 0) {
          func[0] += $" - {Math.Abs(linearParams[1])}";
        } else {
          func[0] += $" + {linearParams[1]}";
        }

        labelLinear.Text += func[0];

        deters[0] = MnkMethods.ErrorEstimation(xValues, yValues, func[0]);

        PrintFunc(chart1.Series[0], func[0]);
      }

      if (checkBox2.Checked) {
        double[] parabolParams = MnkMethods.ParabolRegression(xValues, yValues);

        labelParabol.Text = $"f(x) = ";
        func[1] = $"{parabolParams[2]}*(x^2)";

        if (parabolParams[1] < 0) {
          func[1] += $" - {Math.Abs(parabolParams[1])}*x";
        } else {
          func[1] += $" + {parabolParams[1]}*x";
        }

        if (parabolParams[0] < 0) {
          func[1] += $" - {Math.Abs(parabolParams[0])}";
        } else {
          func[1] += $" + {parabolParams[0]}";
        }

        labelParabol.Text += func[1];

        deters[1] = MnkMethods.ErrorEstimation(xValues, yValues, func[1]);

        PrintFunc(chart1.Series[1], func[1]);
      }

      if (checkBox3.Checked) {
        double[] paramParams;

        try {
          paramParams = MnkMethods.ParamRegression(xValues, yValues);
        } catch (Exception ex) {
          label4.Text = ex.Message;
          return;
        }

        labelParam.Text = $"f(x) = ";
        func[2] = $"{paramParams[0]} * e^({paramParams[1]} * x)";

        labelParam.Text += func[2];

        deters[2] = MnkMethods.ErrorEstimation(xValues, yValues, func[2]);

        PrintFunc(chart1.Series[2], func[2]);
      }

      label4.Text = $"Оценка погрешности: \n" +
        $"Линейная = {deters[0]}\nПараболическая = {deters[1]}\nПараметрическая = {deters[2]}\n\n";

      double maxDet = deters.Min();

      if ((decimal)deters[0] == (decimal)maxDet) {
        label4.Text += "Следовательно, ближе всех Линейная регрессия";
      } else if ((decimal)deters[1] == (decimal)maxDet) {
        label4.Text += "Следовательно, ближе всех Параболическая регрессия";
      } else {
        label4.Text += "Следовательно, ближе всех Параметрическая регрессия";
      }
    }

    private void PrintFunc(System.Windows.Forms.DataVisualization.Charting.Series series, string textFunc) {
      chart1.ChartAreas[0].AxisX.Crossing = 0;

      series.Points.Clear();

      try {
        MnkMethods.TextFunction = textFunc;
      } catch (Exception ex) { 
        label4.Text = ex.Message;
      }

      double a = xValues.Min();
      double b = xValues.Max();

      if (a - b == 0) {
        a = -10;
        b = 10;
      }

      double x = a - 10;


      while (x <= b + 10) {
        double y = MnkMethods.Fun(x);

        series.Points.AddXY(x, y);
        x += 0.001;
      }
    }

    private void ReadDataGrid() {
      dataGridView1.AllowUserToAddRows = false;

      if (dataGridView1.Contains(null)) {
        throw new Exception("В некоторых ячейках отсутствует значение !!!");
      }

      for (int indexRow = 0; indexRow < dataGridView1.RowCount; ++indexRow) {
        xValues.Add(double.Parse(dataGridView1[0, indexRow].Value.ToString()));
      }

      for (int indexRow = 0; indexRow < dataGridView1.RowCount; ++indexRow) {
        yValues.Add(double.Parse(dataGridView1[1, indexRow].Value.ToString()));
      }

      dataGridView1.AllowUserToAddRows = true;
    }

    private void button5_Click(object sender, EventArgs e) {
      int leftVal = int.Parse(left.Text);
      int rightVal = int.Parse(right.Text);
      int count = int.Parse(countPoints.Text);

      Random random = new Random(Guid.NewGuid().GetHashCode());

      xValues.Clear();
      yValues.Clear();

      for (int indexElement = 0; indexElement < count; ++indexElement) {
        xValues.Add(random.Next(leftVal, rightVal) + random.NextDouble());
      }

      for (int indexElement = 0; indexElement < count; ++indexElement) {
        yValues.Add(random.Next(leftVal, rightVal) + random.NextDouble());
      }

      WriteToGrid(dataGridView1, xValues.Count);
    }

    private void WriteToGrid(DataGridView dataGrid, int count) {
      dataGrid.Rows.Clear();
      dataGrid.Refresh();

      for (int indexRow = 0; indexRow < count; ++indexRow) {
        dataGrid.Rows.Add();
      }

      
      for (int indexRow = 0; indexRow < count; ++indexRow) {
        dataGrid[0, indexRow].Value = xValues[indexRow].ToString();
        dataGrid[1, indexRow].Value = yValues[indexRow].ToString();
      }
    }

    private void button2_Click(object sender, EventArgs e) {
      double x = double.Parse(textBoxLinearX.Text);

      MnkMethods.TextFunction = func[0];

      labelLinearRes.Text = MnkMethods.Fun(x).ToString();
    }

    private void button3_Click(object sender, EventArgs e) {
      double x = double.Parse(textBoxParabolX.Text);

      MnkMethods.TextFunction = func[1];

      labelParabolRes.Text = MnkMethods.Fun(x).ToString();
    }

    private void button4_Click(object sender, EventArgs e) {
      double x = double.Parse(textBoxParamX.Text);

      MnkMethods.TextFunction = func[2];

      labelParamRes.Text = MnkMethods.Fun(x).ToString();
    }

    private void buttonOpenFile_Click(object sender, EventArgs e) {
      DialogResult result = openFileDialog1.ShowDialog();

      if (result == DialogResult.OK) {
        string fileName = openFileDialog1.FileName;

        if (!Regex.IsMatch(fileName, @"\S+((\.xlsx)|(\.xls))")) {
          DialogResult messageBox = MessageBox.Show(
            "Неправильный формат файла !!!",
            "Ошибка",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
        } else {
          fileNameExcel.Text = fileName;
        }
      }
    }

    private void readFileExcel_Click(object sender, EventArgs e) {
      Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

      Workbook workbook;

      try {
        workbook = excel.Workbooks.Open(fileNameExcel.Text);
      } catch {
        label1.Text = "Неверный путь к Excel файлу !!!";

        return;
      }

      Worksheet worksheet = workbook.Worksheets[1];

      Range cells = worksheet.Range[rangeExcel.Text];

      for (int indexRow = 1; indexRow < cells.Columns.Count + 1; ++indexRow) {
        try {
          xValues.Add(cells[indexRow, 1].Value);
          yValues.Add(cells[indexRow, 2].Value);
        } catch {
          label1.Text = $"Неверный формат данных в ячейке [{indexRow}, {indexRow}]";
        }
      }

      workbook.Close();

      WriteToGrid(dataGridView1, xValues.Count());
    }
  }
}
