namespace mnk {
  partial class Form1 {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent() {
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.checkBox2 = new System.Windows.Forms.CheckBox();
      this.checkBox3 = new System.Windows.Forms.CheckBox();
      this.button1 = new System.Windows.Forms.Button();
      this.labelLinear = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.labelParabol = new System.Windows.Forms.Label();
      this.labelParam = new System.Windows.Forms.Label();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.button5 = new System.Windows.Forms.Button();
      this.left = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.right = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.countPoints = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.textBoxLinearX = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.labelLinearRes = new System.Windows.Forms.Label();
      this.labelParabolRes = new System.Windows.Forms.Label();
      this.textBoxParabolX = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.labelParamRes = new System.Windows.Forms.Label();
      this.textBoxParamX = new System.Windows.Forms.TextBox();
      this.label15 = new System.Windows.Forms.Label();
      this.label16 = new System.Windows.Forms.Label();
      this.panel4 = new System.Windows.Forms.Panel();
      this.panel5 = new System.Windows.Forms.Panel();
      this.panel6 = new System.Windows.Forms.Panel();
      this.buttonOpenFile = new System.Windows.Forms.Button();
      this.fileNameExcel = new System.Windows.Forms.TextBox();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.rangeExcel = new System.Windows.Forms.TextBox();
      this.readFileExcel = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.panel3.SuspendLayout();
      this.panel4.SuspendLayout();
      this.panel5.SuspendLayout();
      this.panel6.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
      this.dataGridView1.Location = new System.Drawing.Point(62, 37);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersWidth = 51;
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.Size = new System.Drawing.Size(153, 390);
      this.dataGridView1.TabIndex = 0;
      // 
      // Column1
      // 
      this.Column1.HeaderText = "x";
      this.Column1.MinimumWidth = 6;
      this.Column1.Name = "Column1";
      this.Column1.Width = 50;
      // 
      // Column2
      // 
      this.Column2.HeaderText = "y";
      this.Column2.MinimumWidth = 6;
      this.Column2.Name = "Column2";
      this.Column2.Width = 50;
      // 
      // chart1
      // 
      chartArea2.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea2);
      legend2.Alignment = System.Drawing.StringAlignment.Center;
      legend2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
      legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
      legend2.Name = "Legend1";
      this.chart1.Legends.Add(legend2);
      this.chart1.Location = new System.Drawing.Point(642, 36);
      this.chart1.Name = "chart1";
      series5.BorderWidth = 4;
      series5.ChartArea = "ChartArea1";
      series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series5.Legend = "Legend1";
      series5.LegendText = "Линейная регрессия";
      series5.MarkerBorderWidth = 5;
      series5.Name = "Series1";
      series6.BorderWidth = 4;
      series6.ChartArea = "ChartArea1";
      series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series6.Legend = "Legend1";
      series6.LegendText = "Параболическая регрессия";
      series6.Name = "Series2";
      series7.BorderWidth = 4;
      series7.ChartArea = "ChartArea1";
      series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series7.Legend = "Legend1";
      series7.LegendText = "Показательная регрессия";
      series7.Name = "Series3";
      series8.BorderWidth = 4;
      series8.ChartArea = "ChartArea1";
      series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
      series8.IsVisibleInLegend = false;
      series8.Legend = "Legend1";
      series8.Name = "Series4";
      this.chart1.Series.Add(series5);
      this.chart1.Series.Add(series6);
      this.chart1.Series.Add(series7);
      this.chart1.Series.Add(series8);
      this.chart1.Size = new System.Drawing.Size(761, 390);
      this.chart1.TabIndex = 1;
      this.chart1.Text = "chart1";
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(251, 37);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(163, 20);
      this.checkBox1.TabIndex = 2;
      this.checkBox1.Text = "Линейная регрессия";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // checkBox2
      // 
      this.checkBox2.AutoSize = true;
      this.checkBox2.Location = new System.Drawing.Point(251, 90);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new System.Drawing.Size(210, 20);
      this.checkBox2.TabIndex = 3;
      this.checkBox2.Text = "Параболическая регрессия";
      this.checkBox2.UseVisualStyleBackColor = true;
      // 
      // checkBox3
      // 
      this.checkBox3.AutoSize = true;
      this.checkBox3.Location = new System.Drawing.Point(251, 149);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Size = new System.Drawing.Size(225, 20);
      this.checkBox3.TabIndex = 4;
      this.checkBox3.Text = "Экспоненциальная регрессия";
      this.checkBox3.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(251, 376);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(210, 50);
      this.button1.TabIndex = 5;
      this.button1.Text = "Найти параметры выбранных регрессий";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // labelLinear
      // 
      this.labelLinear.AutoSize = true;
      this.labelLinear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelLinear.Location = new System.Drawing.Point(55, 462);
      this.labelLinear.Name = "labelLinear";
      this.labelLinear.Size = new System.Drawing.Size(103, 39);
      this.labelLinear.TabIndex = 6;
      this.labelLinear.Text = "f(x) = ";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(48, 524);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(224, 48);
      this.button2.TabIndex = 7;
      this.button2.Text = "Посчитать значение найденной функции";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // labelParabol
      // 
      this.labelParabol.AutoSize = true;
      this.labelParabol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelParabol.Location = new System.Drawing.Point(500, 462);
      this.labelParabol.Name = "labelParabol";
      this.labelParabol.Size = new System.Drawing.Size(103, 39);
      this.labelParabol.TabIndex = 8;
      this.labelParabol.Text = "f(x) = ";
      // 
      // labelParam
      // 
      this.labelParam.AutoSize = true;
      this.labelParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelParam.Location = new System.Drawing.Point(17, 14);
      this.labelParam.Name = "labelParam";
      this.labelParam.Size = new System.Drawing.Size(103, 39);
      this.labelParam.TabIndex = 9;
      this.labelParam.Text = "f(x) = ";
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(493, 524);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(220, 48);
      this.button3.TabIndex = 10;
      this.button3.Text = "Посчитать значение найденной функции";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(933, 527);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(204, 45);
      this.button4.TabIndex = 11;
      this.button4.Text = "Посчитать значение найденной функции";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(248, 218);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(44, 16);
      this.label4.TabIndex = 15;
      this.label4.Text = "label4";
      // 
      // panel1
      // 
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Location = new System.Drawing.Point(48, 448);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(413, 70);
      this.panel1.TabIndex = 16;
      // 
      // panel2
      // 
      this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel2.Location = new System.Drawing.Point(493, 448);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(413, 70);
      this.panel2.TabIndex = 17;
      // 
      // panel3
      // 
      this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel3.Controls.Add(this.labelParam);
      this.panel3.Location = new System.Drawing.Point(933, 448);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(413, 70);
      this.panel3.TabIndex = 18;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(269, 60);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(62, 16);
      this.label1.TabIndex = 19;
      this.label1.Text = "y = ax + b";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(269, 113);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(102, 16);
      this.label2.TabIndex = 20;
      this.label2.Text = "y = ax^2 + bx + c";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(269, 172);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(83, 16);
      this.label3.TabIndex = 21;
      this.label3.Text = "y = a * e^(bx)";
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(48, 597);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(212, 60);
      this.button5.TabIndex = 22;
      this.button5.Text = "Заполнить таблицу случайными значениями";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // left
      // 
      this.left.Location = new System.Drawing.Point(329, 597);
      this.left.Name = "left";
      this.left.Size = new System.Drawing.Size(79, 22);
      this.left.TabIndex = 23;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(286, 600);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(26, 16);
      this.label5.TabIndex = 24;
      this.label5.Text = "ОТ";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(286, 641);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(26, 16);
      this.label6.TabIndex = 25;
      this.label6.Text = "ДО";
      // 
      // right
      // 
      this.right.Location = new System.Drawing.Point(329, 635);
      this.right.Name = "right";
      this.right.Size = new System.Drawing.Size(79, 22);
      this.right.TabIndex = 26;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(434, 603);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(129, 16);
      this.label7.TabIndex = 27;
      this.label7.Text = "Количество точек:";
      // 
      // countPoints
      // 
      this.countPoints.Location = new System.Drawing.Point(437, 635);
      this.countPoints.Name = "countPoints";
      this.countPoints.Size = new System.Drawing.Size(126, 22);
      this.countPoints.TabIndex = 28;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label8.Location = new System.Drawing.Point(284, 533);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(25, 26);
      this.label8.TabIndex = 29;
      this.label8.Text = "f(";
      // 
      // textBoxLinearX
      // 
      this.textBoxLinearX.Location = new System.Drawing.Point(301, 537);
      this.textBoxLinearX.Name = "textBoxLinearX";
      this.textBoxLinearX.Size = new System.Drawing.Size(30, 22);
      this.textBoxLinearX.TabIndex = 30;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label9.Location = new System.Drawing.Point(324, 533);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(44, 26);
      this.label9.TabIndex = 31;
      this.label9.Text = ") = ";
      // 
      // labelLinearRes
      // 
      this.labelLinearRes.AutoSize = true;
      this.labelLinearRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelLinearRes.Location = new System.Drawing.Point(3, 6);
      this.labelLinearRes.Name = "labelLinearRes";
      this.labelLinearRes.Size = new System.Drawing.Size(42, 26);
      this.labelLinearRes.TabIndex = 32;
      this.labelLinearRes.Text = "res";
      // 
      // labelParabolRes
      // 
      this.labelParabolRes.AutoSize = true;
      this.labelParabolRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelParabolRes.Location = new System.Drawing.Point(3, 6);
      this.labelParabolRes.Name = "labelParabolRes";
      this.labelParabolRes.Size = new System.Drawing.Size(42, 26);
      this.labelParabolRes.TabIndex = 36;
      this.labelParabolRes.Text = "res";
      // 
      // textBoxParabolX
      // 
      this.textBoxParabolX.Location = new System.Drawing.Point(748, 537);
      this.textBoxParabolX.Name = "textBoxParabolX";
      this.textBoxParabolX.Size = new System.Drawing.Size(30, 22);
      this.textBoxParabolX.TabIndex = 34;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label12.Location = new System.Drawing.Point(771, 533);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(44, 26);
      this.label12.TabIndex = 35;
      this.label12.Text = ") = ";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label13.Location = new System.Drawing.Point(731, 533);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(25, 26);
      this.label13.TabIndex = 33;
      this.label13.Text = "f(";
      // 
      // labelParamRes
      // 
      this.labelParamRes.AutoSize = true;
      this.labelParamRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelParamRes.Location = new System.Drawing.Point(3, 6);
      this.labelParamRes.Name = "labelParamRes";
      this.labelParamRes.Size = new System.Drawing.Size(42, 26);
      this.labelParamRes.TabIndex = 40;
      this.labelParamRes.Text = "res";
      // 
      // textBoxParamX
      // 
      this.textBoxParamX.Location = new System.Drawing.Point(1177, 541);
      this.textBoxParamX.Name = "textBoxParamX";
      this.textBoxParamX.Size = new System.Drawing.Size(30, 22);
      this.textBoxParamX.TabIndex = 38;
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label15.Location = new System.Drawing.Point(1200, 537);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(44, 26);
      this.label15.TabIndex = 39;
      this.label15.Text = ") = ";
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label16.Location = new System.Drawing.Point(1160, 537);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(25, 26);
      this.label16.TabIndex = 37;
      this.label16.Text = "f(";
      // 
      // panel4
      // 
      this.panel4.AutoScroll = true;
      this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel4.Controls.Add(this.labelLinearRes);
      this.panel4.Location = new System.Drawing.Point(374, 527);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(87, 45);
      this.panel4.TabIndex = 17;
      // 
      // panel5
      // 
      this.panel5.AutoScroll = true;
      this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel5.Controls.Add(this.labelParabolRes);
      this.panel5.Location = new System.Drawing.Point(821, 527);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(85, 45);
      this.panel5.TabIndex = 33;
      // 
      // panel6
      // 
      this.panel6.AutoScroll = true;
      this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel6.Controls.Add(this.labelParamRes);
      this.panel6.Location = new System.Drawing.Point(1250, 527);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(96, 45);
      this.panel6.TabIndex = 41;
      // 
      // buttonOpenFile
      // 
      this.buttonOpenFile.Location = new System.Drawing.Point(812, 597);
      this.buttonOpenFile.Name = "buttonOpenFile";
      this.buttonOpenFile.Size = new System.Drawing.Size(31, 30);
      this.buttonOpenFile.TabIndex = 42;
      this.buttonOpenFile.Text = "...";
      this.buttonOpenFile.UseVisualStyleBackColor = true;
      this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
      // 
      // fileNameExcel
      // 
      this.fileNameExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.fileNameExcel.Location = new System.Drawing.Point(849, 597);
      this.fileNameExcel.Name = "fileNameExcel";
      this.fileNameExcel.Size = new System.Drawing.Size(266, 30);
      this.fileNameExcel.TabIndex = 43;
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // rangeExcel
      // 
      this.rangeExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.rangeExcel.Location = new System.Drawing.Point(812, 641);
      this.rangeExcel.Name = "rangeExcel";
      this.rangeExcel.Size = new System.Drawing.Size(81, 30);
      this.rangeExcel.TabIndex = 44;
      // 
      // readFileExcel
      // 
      this.readFileExcel.Location = new System.Drawing.Point(933, 641);
      this.readFileExcel.Name = "readFileExcel";
      this.readFileExcel.Size = new System.Drawing.Size(182, 30);
      this.readFileExcel.TabIndex = 45;
      this.readFileExcel.Text = "Считать";
      this.readFileExcel.UseVisualStyleBackColor = true;
      this.readFileExcel.Click += new System.EventHandler(this.readFileExcel_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1447, 690);
      this.Controls.Add(this.readFileExcel);
      this.Controls.Add(this.rangeExcel);
      this.Controls.Add(this.fileNameExcel);
      this.Controls.Add(this.buttonOpenFile);
      this.Controls.Add(this.textBoxParamX);
      this.Controls.Add(this.label15);
      this.Controls.Add(this.label16);
      this.Controls.Add(this.textBoxParabolX);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.label13);
      this.Controls.Add(this.textBoxLinearX);
      this.Controls.Add(this.countPoints);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.right);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.left);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.labelParabol);
      this.Controls.Add(this.labelLinear);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.checkBox3);
      this.Controls.Add(this.checkBox2);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.panel4);
      this.Controls.Add(this.panel5);
      this.Controls.Add(this.panel6);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.panel5.ResumeLayout(false);
      this.panel5.PerformLayout();
      this.panel6.ResumeLayout(false);
      this.panel6.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.CheckBox checkBox3;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label labelLinear;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label labelParabol;
    private System.Windows.Forms.Label labelParam;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.TextBox left;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox right;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox countPoints;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox textBoxLinearX;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label labelLinearRes;
    private System.Windows.Forms.Label labelParabolRes;
    private System.Windows.Forms.TextBox textBoxParabolX;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label labelParamRes;
    private System.Windows.Forms.TextBox textBoxParamX;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.Panel panel6;
    private System.Windows.Forms.Button buttonOpenFile;
    private System.Windows.Forms.TextBox fileNameExcel;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.TextBox rangeExcel;
    private System.Windows.Forms.Button readFileExcel;
  }
}

