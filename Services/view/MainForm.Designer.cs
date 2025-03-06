namespace Test_Cardiograph
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      splitContainer_Main = new SplitContainer();
      groupBox_CreateTest = new GroupBox();
      splitContainer_Create_Test = new SplitContainer();
      button2 = new Button();
      button1 = new Button();
      checkBox_Pneumogram = new CheckBox();
      checkBox_Heart_Rate_Control = new CheckBox();
      button_Choice_ECG_Header = new Button();
      tableLayoutPanel_Pneumogram = new TableLayoutPanel();
      comboBox_del_R = new ComboBox();
      comboBox_Omega_R = new ComboBox();
      label_Text_del_R = new Label();
      label_Text_Omega_R = new Label();
      numericUpDown_Heart_Rate_Control = new NumericUpDown();
      label_Text_Name_Selected_ECG_Header = new Label();
      groupBox_Other_Functions = new GroupBox();
      button_Other_Functions_Load = new Button();
      radioButton_Square = new RadioButton();
      radioButton_Triangle = new RadioButton();
      radioButton_Sine = new RadioButton();
      groupBox_Output = new GroupBox();
      tableLayoutPanel_Buttons = new TableLayoutPanel();
      button_Output_Stop = new Button();
      button_Output_Play = new Button();
      groupBox_PC_Display_Parameters = new GroupBox();
      panel_Text_PC_Display_Parameters = new Panel();
      label_Text_PC_Display_Parameters_Waveforms = new Label();
      label_Text_PC_Display_Parameters_Duration = new Label();
      label_Text_PC_Display_Parameters_Amplitude = new Label();
      label_Text_PC_Display_Parameters_Graph_Start = new Label();
      panel_Value_PC_Display_Parameters = new Panel();
      comboBox_PC_Display_Parameters_Waveforms = new ComboBox();
      domainUpDown_PC_Display_Parameters_Duration = new DomainUpDown();
      domainUpDown_PC_Display_Parameters_Graph_Start = new DomainUpDown();
      domainUpDown_PC_Display_Parameters_Amplitude = new DomainUpDown();
      tableLayoutPanel1 = new TableLayoutPanel();
      MainPanel = new Panel();
      ((System.ComponentModel.ISupportInitialize)splitContainer_Main).BeginInit();
      splitContainer_Main.Panel1.SuspendLayout();
      splitContainer_Main.Panel2.SuspendLayout();
      splitContainer_Main.SuspendLayout();
      groupBox_CreateTest.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer_Create_Test).BeginInit();
      splitContainer_Create_Test.Panel1.SuspendLayout();
      splitContainer_Create_Test.Panel2.SuspendLayout();
      splitContainer_Create_Test.SuspendLayout();
      tableLayoutPanel_Pneumogram.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)numericUpDown_Heart_Rate_Control).BeginInit();
      groupBox_Other_Functions.SuspendLayout();
      groupBox_Output.SuspendLayout();
      tableLayoutPanel_Buttons.SuspendLayout();
      groupBox_PC_Display_Parameters.SuspendLayout();
      panel_Text_PC_Display_Parameters.SuspendLayout();
      panel_Value_PC_Display_Parameters.SuspendLayout();
      MainPanel.SuspendLayout();
      SuspendLayout();
      // 
      // splitContainer_Main
      // 
      splitContainer_Main.Dock = DockStyle.Fill;
      splitContainer_Main.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
      splitContainer_Main.Location = new Point(0, 0);
      splitContainer_Main.Name = "splitContainer_Main";
      // 
      // splitContainer_Main.Panel1
      // 
      splitContainer_Main.Panel1.AutoScroll = true;
      splitContainer_Main.Panel1.AutoScrollMinSize = new Size(150, 350);
      splitContainer_Main.Panel1.Controls.Add(groupBox_CreateTest);
      splitContainer_Main.Panel1.Controls.Add(groupBox_Other_Functions);
      splitContainer_Main.Panel1.Controls.Add(groupBox_Output);
      splitContainer_Main.Panel1.Controls.Add(groupBox_PC_Display_Parameters);
      splitContainer_Main.Panel1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
      // 
      // splitContainer_Main.Panel2
      // 
      splitContainer_Main.Panel2.Controls.Add(tableLayoutPanel1);
      splitContainer_Main.Size = new Size(834, 515);
      splitContainer_Main.SplitterDistance = 277;
      splitContainer_Main.TabIndex = 2;
      // 
      // groupBox_CreateTest
      // 
      groupBox_CreateTest.Controls.Add(splitContainer_Create_Test);
      groupBox_CreateTest.Dock = DockStyle.Top;
      groupBox_CreateTest.Location = new Point(0, 172);
      groupBox_CreateTest.Name = "groupBox_CreateTest";
      groupBox_CreateTest.Size = new Size(260, 147);
      groupBox_CreateTest.TabIndex = 1;
      groupBox_CreateTest.TabStop = false;
      groupBox_CreateTest.Text = "Меню создания теста";
      // 
      // splitContainer_Create_Test
      // 
      splitContainer_Create_Test.Dock = DockStyle.Fill;
      splitContainer_Create_Test.Location = new Point(3, 22);
      splitContainer_Create_Test.Name = "splitContainer_Create_Test";
      // 
      // splitContainer_Create_Test.Panel1
      // 
      splitContainer_Create_Test.Panel1.Controls.Add(button2);
      splitContainer_Create_Test.Panel1.Controls.Add(button1);
      splitContainer_Create_Test.Panel1.Controls.Add(checkBox_Pneumogram);
      splitContainer_Create_Test.Panel1.Controls.Add(checkBox_Heart_Rate_Control);
      splitContainer_Create_Test.Panel1.Controls.Add(button_Choice_ECG_Header);
      // 
      // splitContainer_Create_Test.Panel2
      // 
      splitContainer_Create_Test.Panel2.Controls.Add(tableLayoutPanel_Pneumogram);
      splitContainer_Create_Test.Panel2.Controls.Add(numericUpDown_Heart_Rate_Control);
      splitContainer_Create_Test.Panel2.Controls.Add(label_Text_Name_Selected_ECG_Header);
      splitContainer_Create_Test.Size = new Size(254, 122);
      splitContainer_Create_Test.SplitterDistance = 118;
      splitContainer_Create_Test.TabIndex = 0;
      // 
      // button2
      // 
      button2.Dock = DockStyle.Top;
      button2.Location = new Point(0, 95);
      button2.Name = "button2";
      button2.Size = new Size(118, 25);
      button2.TabIndex = 4;
      button2.Text = "Загрузить";
      button2.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      button1.Dock = DockStyle.Top;
      button1.Location = new Point(0, 70);
      button1.Name = "button1";
      button1.Size = new Size(118, 25);
      button1.TabIndex = 3;
      button1.Text = "Сохранить";
      button1.UseVisualStyleBackColor = true;
      // 
      // checkBox_Pneumogram
      // 
      checkBox_Pneumogram.AutoSize = true;
      checkBox_Pneumogram.Dock = DockStyle.Top;
      checkBox_Pneumogram.Location = new Point(0, 47);
      checkBox_Pneumogram.Name = "checkBox_Pneumogram";
      checkBox_Pneumogram.Size = new Size(118, 23);
      checkBox_Pneumogram.TabIndex = 2;
      checkBox_Pneumogram.Text = "Пневмограмма";
      checkBox_Pneumogram.UseVisualStyleBackColor = true;
      checkBox_Pneumogram.CheckedChanged += checkBox_Pneumogram_CheckedChanged;
      // 
      // checkBox_Heart_Rate_Control
      // 
      checkBox_Heart_Rate_Control.AutoSize = true;
      checkBox_Heart_Rate_Control.Dock = DockStyle.Top;
      checkBox_Heart_Rate_Control.Location = new Point(0, 24);
      checkBox_Heart_Rate_Control.Name = "checkBox_Heart_Rate_Control";
      checkBox_Heart_Rate_Control.Size = new Size(118, 23);
      checkBox_Heart_Rate_Control.TabIndex = 1;
      checkBox_Heart_Rate_Control.Text = "КонтрольЧСС";
      checkBox_Heart_Rate_Control.UseVisualStyleBackColor = true;
      checkBox_Heart_Rate_Control.CheckedChanged += checkBox_Heart_Rate_Control_CheckedChanged;
      // 
      // button_Choice_ECG_Header
      // 
      button_Choice_ECG_Header.Dock = DockStyle.Top;
      button_Choice_ECG_Header.Location = new Point(0, 0);
      button_Choice_ECG_Header.Name = "button_Choice_ECG_Header";
      button_Choice_ECG_Header.Size = new Size(118, 24);
      button_Choice_ECG_Header.TabIndex = 0;
      button_Choice_ECG_Header.Text = "Выбор ЭКГ";
      button_Choice_ECG_Header.UseVisualStyleBackColor = true;
      button_Choice_ECG_Header.Click += button_Choice_ECG_Header_Click;
      // 
      // tableLayoutPanel_Pneumogram
      // 
      tableLayoutPanel_Pneumogram.ColumnCount = 2;
      tableLayoutPanel_Pneumogram.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.90071F));
      tableLayoutPanel_Pneumogram.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.09929F));
      tableLayoutPanel_Pneumogram.Controls.Add(comboBox_del_R, 1, 0);
      tableLayoutPanel_Pneumogram.Controls.Add(comboBox_Omega_R, 1, 1);
      tableLayoutPanel_Pneumogram.Controls.Add(label_Text_del_R, 0, 0);
      tableLayoutPanel_Pneumogram.Controls.Add(label_Text_Omega_R, 0, 1);
      tableLayoutPanel_Pneumogram.Dock = DockStyle.Top;
      tableLayoutPanel_Pneumogram.Location = new Point(0, 45);
      tableLayoutPanel_Pneumogram.Name = "tableLayoutPanel_Pneumogram";
      tableLayoutPanel_Pneumogram.RowCount = 2;
      tableLayoutPanel_Pneumogram.RowStyles.Add(new RowStyle(SizeType.Percent, 46.6666679F));
      tableLayoutPanel_Pneumogram.RowStyles.Add(new RowStyle(SizeType.Percent, 53.3333321F));
      tableLayoutPanel_Pneumogram.Size = new Size(132, 59);
      tableLayoutPanel_Pneumogram.TabIndex = 2;
      // 
      // comboBox_del_R
      // 
      comboBox_del_R.Dock = DockStyle.Top;
      comboBox_del_R.Font = new Font("Times New Roman", 9F);
      comboBox_del_R.FormattingEnabled = true;
      comboBox_del_R.Location = new Point(74, 3);
      comboBox_del_R.Name = "comboBox_del_R";
      comboBox_del_R.Size = new Size(55, 23);
      comboBox_del_R.TabIndex = 0;
      // 
      // comboBox_Omega_R
      // 
      comboBox_Omega_R.Dock = DockStyle.Top;
      comboBox_Omega_R.Font = new Font("Times New Roman", 9F);
      comboBox_Omega_R.FormattingEnabled = true;
      comboBox_Omega_R.Location = new Point(74, 30);
      comboBox_Omega_R.Name = "comboBox_Omega_R";
      comboBox_Omega_R.Size = new Size(55, 23);
      comboBox_Omega_R.TabIndex = 1;
      // 
      // label_Text_del_R
      // 
      label_Text_del_R.AutoSize = true;
      label_Text_del_R.Dock = DockStyle.Top;
      label_Text_del_R.Location = new Point(3, 0);
      label_Text_del_R.Name = "label_Text_del_R";
      label_Text_del_R.Size = new Size(65, 19);
      label_Text_del_R.TabIndex = 0;
      label_Text_del_R.Text = "ΔR";
      // 
      // label_Text_Omega_R
      // 
      label_Text_Omega_R.AutoSize = true;
      label_Text_Omega_R.Dock = DockStyle.Top;
      label_Text_Omega_R.Font = new Font("Times New Roman", 12F);
      label_Text_Omega_R.Location = new Point(3, 27);
      label_Text_Omega_R.Name = "label_Text_Omega_R";
      label_Text_Omega_R.Size = new Size(65, 19);
      label_Text_Omega_R.TabIndex = 1;
      label_Text_Omega_R.Text = "Омега R";
      // 
      // numericUpDown_Heart_Rate_Control
      // 
      numericUpDown_Heart_Rate_Control.Dock = DockStyle.Top;
      numericUpDown_Heart_Rate_Control.Location = new Point(0, 19);
      numericUpDown_Heart_Rate_Control.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
      numericUpDown_Heart_Rate_Control.Name = "numericUpDown_Heart_Rate_Control";
      numericUpDown_Heart_Rate_Control.RightToLeft = RightToLeft.Yes;
      numericUpDown_Heart_Rate_Control.Size = new Size(132, 26);
      numericUpDown_Heart_Rate_Control.TabIndex = 3;
      // 
      // label_Text_Name_Selected_ECG_Header
      // 
      label_Text_Name_Selected_ECG_Header.AutoSize = true;
      label_Text_Name_Selected_ECG_Header.Dock = DockStyle.Top;
      label_Text_Name_Selected_ECG_Header.Font = new Font("Times New Roman", 12F);
      label_Text_Name_Selected_ECG_Header.Location = new Point(0, 0);
      label_Text_Name_Selected_ECG_Header.Name = "label_Text_Name_Selected_ECG_Header";
      label_Text_Name_Selected_ECG_Header.Size = new Size(109, 19);
      label_Text_Name_Selected_ECG_Header.TabIndex = 0;
      label_Text_Name_Selected_ECG_Header.Text = ".........................";
      // 
      // groupBox_Other_Functions
      // 
      groupBox_Other_Functions.Controls.Add(button_Other_Functions_Load);
      groupBox_Other_Functions.Controls.Add(radioButton_Square);
      groupBox_Other_Functions.Controls.Add(radioButton_Triangle);
      groupBox_Other_Functions.Controls.Add(radioButton_Sine);
      groupBox_Other_Functions.Dock = DockStyle.Bottom;
      groupBox_Other_Functions.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
      groupBox_Other_Functions.Location = new Point(0, 350);
      groupBox_Other_Functions.Name = "groupBox_Other_Functions";
      groupBox_Other_Functions.Size = new Size(260, 190);
      groupBox_Other_Functions.TabIndex = 1;
      groupBox_Other_Functions.TabStop = false;
      groupBox_Other_Functions.Text = "Other functions";
      // 
      // button_Other_Functions_Load
      // 
      button_Other_Functions_Load.Dock = DockStyle.Top;
      button_Other_Functions_Load.Location = new Point(3, 74);
      button_Other_Functions_Load.Name = "button_Other_Functions_Load";
      button_Other_Functions_Load.Size = new Size(254, 23);
      button_Other_Functions_Load.TabIndex = 0;
      button_Other_Functions_Load.Text = "Load";
      button_Other_Functions_Load.UseVisualStyleBackColor = true;
      // 
      // radioButton_Square
      // 
      radioButton_Square.AutoSize = true;
      radioButton_Square.Dock = DockStyle.Top;
      radioButton_Square.Location = new Point(3, 55);
      radioButton_Square.Name = "radioButton_Square";
      radioButton_Square.Size = new Size(254, 19);
      radioButton_Square.TabIndex = 2;
      radioButton_Square.TabStop = true;
      radioButton_Square.Text = "Square";
      radioButton_Square.UseVisualStyleBackColor = true;
      // 
      // radioButton_Triangle
      // 
      radioButton_Triangle.AutoSize = true;
      radioButton_Triangle.Dock = DockStyle.Top;
      radioButton_Triangle.Location = new Point(3, 36);
      radioButton_Triangle.Name = "radioButton_Triangle";
      radioButton_Triangle.Size = new Size(254, 19);
      radioButton_Triangle.TabIndex = 1;
      radioButton_Triangle.TabStop = true;
      radioButton_Triangle.Text = "Triangle";
      radioButton_Triangle.UseVisualStyleBackColor = true;
      // 
      // radioButton_Sine
      // 
      radioButton_Sine.AutoSize = true;
      radioButton_Sine.Dock = DockStyle.Top;
      radioButton_Sine.Location = new Point(3, 17);
      radioButton_Sine.Name = "radioButton_Sine";
      radioButton_Sine.Size = new Size(254, 19);
      radioButton_Sine.TabIndex = 0;
      radioButton_Sine.TabStop = true;
      radioButton_Sine.Text = "Sine";
      radioButton_Sine.UseVisualStyleBackColor = true;
      // 
      // groupBox_Output
      // 
      groupBox_Output.Controls.Add(tableLayoutPanel_Buttons);
      groupBox_Output.Dock = DockStyle.Top;
      groupBox_Output.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
      groupBox_Output.Location = new Point(0, 108);
      groupBox_Output.Name = "groupBox_Output";
      groupBox_Output.Size = new Size(260, 64);
      groupBox_Output.TabIndex = 0;
      groupBox_Output.TabStop = false;
      groupBox_Output.Text = "Output";
      // 
      // tableLayoutPanel_Buttons
      // 
      tableLayoutPanel_Buttons.ColumnCount = 2;
      tableLayoutPanel_Buttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      tableLayoutPanel_Buttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      tableLayoutPanel_Buttons.Controls.Add(button_Output_Stop, 1, 0);
      tableLayoutPanel_Buttons.Controls.Add(button_Output_Play, 0, 0);
      tableLayoutPanel_Buttons.Dock = DockStyle.Top;
      tableLayoutPanel_Buttons.Location = new Point(3, 17);
      tableLayoutPanel_Buttons.Name = "tableLayoutPanel_Buttons";
      tableLayoutPanel_Buttons.RowCount = 2;
      tableLayoutPanel_Buttons.RowStyles.Add(new RowStyle(SizeType.Percent, 70.7317047F));
      tableLayoutPanel_Buttons.RowStyles.Add(new RowStyle(SizeType.Percent, 29.2682934F));
      tableLayoutPanel_Buttons.Size = new Size(254, 41);
      tableLayoutPanel_Buttons.TabIndex = 0;
      // 
      // button_Output_Stop
      // 
      button_Output_Stop.Dock = DockStyle.Fill;
      button_Output_Stop.Location = new Point(130, 3);
      button_Output_Stop.Name = "button_Output_Stop";
      button_Output_Stop.Size = new Size(121, 23);
      button_Output_Stop.TabIndex = 1;
      button_Output_Stop.Text = "Stop";
      button_Output_Stop.UseVisualStyleBackColor = true;
      // 
      // button_Output_Play
      // 
      button_Output_Play.Dock = DockStyle.Fill;
      button_Output_Play.Location = new Point(3, 3);
      button_Output_Play.Name = "button_Output_Play";
      button_Output_Play.Size = new Size(121, 23);
      button_Output_Play.TabIndex = 0;
      button_Output_Play.Text = "Play";
      button_Output_Play.UseVisualStyleBackColor = true;
      // 
      // groupBox_PC_Display_Parameters
      // 
      groupBox_PC_Display_Parameters.Controls.Add(panel_Text_PC_Display_Parameters);
      groupBox_PC_Display_Parameters.Controls.Add(panel_Value_PC_Display_Parameters);
      groupBox_PC_Display_Parameters.Dock = DockStyle.Top;
      groupBox_PC_Display_Parameters.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
      groupBox_PC_Display_Parameters.Location = new Point(0, 0);
      groupBox_PC_Display_Parameters.Name = "groupBox_PC_Display_Parameters";
      groupBox_PC_Display_Parameters.Size = new Size(260, 108);
      groupBox_PC_Display_Parameters.TabIndex = 0;
      groupBox_PC_Display_Parameters.TabStop = false;
      groupBox_PC_Display_Parameters.Text = "PC Display Parameters";
      // 
      // panel_Text_PC_Display_Parameters
      // 
      panel_Text_PC_Display_Parameters.Controls.Add(label_Text_PC_Display_Parameters_Waveforms);
      panel_Text_PC_Display_Parameters.Controls.Add(label_Text_PC_Display_Parameters_Duration);
      panel_Text_PC_Display_Parameters.Controls.Add(label_Text_PC_Display_Parameters_Amplitude);
      panel_Text_PC_Display_Parameters.Controls.Add(label_Text_PC_Display_Parameters_Graph_Start);
      panel_Text_PC_Display_Parameters.Dock = DockStyle.Left;
      panel_Text_PC_Display_Parameters.Location = new Point(3, 17);
      panel_Text_PC_Display_Parameters.Name = "panel_Text_PC_Display_Parameters";
      panel_Text_PC_Display_Parameters.Size = new Size(117, 88);
      panel_Text_PC_Display_Parameters.TabIndex = 0;
      // 
      // label_Text_PC_Display_Parameters_Waveforms
      // 
      label_Text_PC_Display_Parameters_Waveforms.AutoSize = true;
      label_Text_PC_Display_Parameters_Waveforms.Location = new Point(9, 66);
      label_Text_PC_Display_Parameters_Waveforms.Name = "label_Text_PC_Display_Parameters_Waveforms";
      label_Text_PC_Display_Parameters_Waveforms.Size = new Size(64, 15);
      label_Text_PC_Display_Parameters_Waveforms.TabIndex = 7;
      label_Text_PC_Display_Parameters_Waveforms.Text = "Waveforms:";
      // 
      // label_Text_PC_Display_Parameters_Duration
      // 
      label_Text_PC_Display_Parameters_Duration.AutoSize = true;
      label_Text_PC_Display_Parameters_Duration.Location = new Point(9, 44);
      label_Text_PC_Display_Parameters_Duration.Name = "label_Text_PC_Display_Parameters_Duration";
      label_Text_PC_Display_Parameters_Duration.Size = new Size(69, 15);
      label_Text_PC_Display_Parameters_Duration.TabIndex = 6;
      label_Text_PC_Display_Parameters_Duration.Text = "Duration (s):";
      // 
      // label_Text_PC_Display_Parameters_Amplitude
      // 
      label_Text_PC_Display_Parameters_Amplitude.AutoSize = true;
      label_Text_PC_Display_Parameters_Amplitude.Location = new Point(3, 2);
      label_Text_PC_Display_Parameters_Amplitude.Name = "label_Text_PC_Display_Parameters_Amplitude";
      label_Text_PC_Display_Parameters_Amplitude.Size = new Size(90, 15);
      label_Text_PC_Display_Parameters_Amplitude.TabIndex = 0;
      label_Text_PC_Display_Parameters_Amplitude.Text = "Amplitude (mV):";
      // 
      // label_Text_PC_Display_Parameters_Graph_Start
      // 
      label_Text_PC_Display_Parameters_Graph_Start.AutoSize = true;
      label_Text_PC_Display_Parameters_Graph_Start.Location = new Point(3, 23);
      label_Text_PC_Display_Parameters_Graph_Start.Margin = new Padding(3, 5, 3, 5);
      label_Text_PC_Display_Parameters_Graph_Start.Name = "label_Text_PC_Display_Parameters_Graph_Start";
      label_Text_PC_Display_Parameters_Graph_Start.Size = new Size(83, 15);
      label_Text_PC_Display_Parameters_Graph_Start.TabIndex = 5;
      label_Text_PC_Display_Parameters_Graph_Start.Text = "Graph Start (s):";
      // 
      // panel_Value_PC_Display_Parameters
      // 
      panel_Value_PC_Display_Parameters.Controls.Add(comboBox_PC_Display_Parameters_Waveforms);
      panel_Value_PC_Display_Parameters.Controls.Add(domainUpDown_PC_Display_Parameters_Duration);
      panel_Value_PC_Display_Parameters.Controls.Add(domainUpDown_PC_Display_Parameters_Graph_Start);
      panel_Value_PC_Display_Parameters.Controls.Add(domainUpDown_PC_Display_Parameters_Amplitude);
      panel_Value_PC_Display_Parameters.Dock = DockStyle.Right;
      panel_Value_PC_Display_Parameters.Location = new Point(205, 17);
      panel_Value_PC_Display_Parameters.Margin = new Padding(15);
      panel_Value_PC_Display_Parameters.Name = "panel_Value_PC_Display_Parameters";
      panel_Value_PC_Display_Parameters.Size = new Size(52, 88);
      panel_Value_PC_Display_Parameters.TabIndex = 0;
      // 
      // comboBox_PC_Display_Parameters_Waveforms
      // 
      comboBox_PC_Display_Parameters_Waveforms.Dock = DockStyle.Top;
      comboBox_PC_Display_Parameters_Waveforms.FormattingEnabled = true;
      comboBox_PC_Display_Parameters_Waveforms.Items.AddRange(new object[] { "1", "3", "6", "12" });
      comboBox_PC_Display_Parameters_Waveforms.Location = new Point(0, 63);
      comboBox_PC_Display_Parameters_Waveforms.Name = "comboBox_PC_Display_Parameters_Waveforms";
      comboBox_PC_Display_Parameters_Waveforms.RightToLeft = RightToLeft.Yes;
      comboBox_PC_Display_Parameters_Waveforms.Size = new Size(52, 23);
      comboBox_PC_Display_Parameters_Waveforms.TabIndex = 0;
      comboBox_PC_Display_Parameters_Waveforms.Text = "12";
      // 
      // domainUpDown_PC_Display_Parameters_Duration
      // 
      domainUpDown_PC_Display_Parameters_Duration.Dock = DockStyle.Top;
      domainUpDown_PC_Display_Parameters_Duration.Location = new Point(0, 42);
      domainUpDown_PC_Display_Parameters_Duration.Name = "domainUpDown_PC_Display_Parameters_Duration";
      domainUpDown_PC_Display_Parameters_Duration.RightToLeft = RightToLeft.Yes;
      domainUpDown_PC_Display_Parameters_Duration.Size = new Size(52, 21);
      domainUpDown_PC_Display_Parameters_Duration.TabIndex = 3;
      domainUpDown_PC_Display_Parameters_Duration.Text = "5";
      // 
      // domainUpDown_PC_Display_Parameters_Graph_Start
      // 
      domainUpDown_PC_Display_Parameters_Graph_Start.Dock = DockStyle.Top;
      domainUpDown_PC_Display_Parameters_Graph_Start.Location = new Point(0, 21);
      domainUpDown_PC_Display_Parameters_Graph_Start.Name = "domainUpDown_PC_Display_Parameters_Graph_Start";
      domainUpDown_PC_Display_Parameters_Graph_Start.RightToLeft = RightToLeft.Yes;
      domainUpDown_PC_Display_Parameters_Graph_Start.Size = new Size(52, 21);
      domainUpDown_PC_Display_Parameters_Graph_Start.TabIndex = 1;
      domainUpDown_PC_Display_Parameters_Graph_Start.Text = "2,00";
      // 
      // domainUpDown_PC_Display_Parameters_Amplitude
      // 
      domainUpDown_PC_Display_Parameters_Amplitude.Dock = DockStyle.Top;
      domainUpDown_PC_Display_Parameters_Amplitude.Location = new Point(0, 0);
      domainUpDown_PC_Display_Parameters_Amplitude.Name = "domainUpDown_PC_Display_Parameters_Amplitude";
      domainUpDown_PC_Display_Parameters_Amplitude.RightToLeft = RightToLeft.Yes;
      domainUpDown_PC_Display_Parameters_Amplitude.Size = new Size(52, 21);
      domainUpDown_PC_Display_Parameters_Amplitude.TabIndex = 2;
      domainUpDown_PC_Display_Parameters_Amplitude.Text = "0";
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.ColumnCount = 2;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      tableLayoutPanel1.Location = new Point(451, 135);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 2;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      tableLayoutPanel1.Size = new Size(198, 380);
      tableLayoutPanel1.TabIndex = 0;
      // 
      // MainPanel
      // 
      MainPanel.Controls.Add(splitContainer_Main);
      MainPanel.Dock = DockStyle.Fill;
      MainPanel.Location = new Point(0, 0);
      MainPanel.Name = "MainPanel";
      MainPanel.Size = new Size(834, 515);
      MainPanel.TabIndex = 0;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(834, 515);
      Controls.Add(MainPanel);
      Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
      Icon = (Icon)resources.GetObject("$this.Icon");
      Name = "MainForm";
      Text = "Тест кардиограф";
      Load += MainForm_Load;
      splitContainer_Main.Panel1.ResumeLayout(false);
      splitContainer_Main.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)splitContainer_Main).EndInit();
      splitContainer_Main.ResumeLayout(false);
      groupBox_CreateTest.ResumeLayout(false);
      splitContainer_Create_Test.Panel1.ResumeLayout(false);
      splitContainer_Create_Test.Panel1.PerformLayout();
      splitContainer_Create_Test.Panel2.ResumeLayout(false);
      splitContainer_Create_Test.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer_Create_Test).EndInit();
      splitContainer_Create_Test.ResumeLayout(false);
      tableLayoutPanel_Pneumogram.ResumeLayout(false);
      tableLayoutPanel_Pneumogram.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)numericUpDown_Heart_Rate_Control).EndInit();
      groupBox_Other_Functions.ResumeLayout(false);
      groupBox_Other_Functions.PerformLayout();
      groupBox_Output.ResumeLayout(false);
      tableLayoutPanel_Buttons.ResumeLayout(false);
      groupBox_PC_Display_Parameters.ResumeLayout(false);
      panel_Text_PC_Display_Parameters.ResumeLayout(false);
      panel_Text_PC_Display_Parameters.PerformLayout();
      panel_Value_PC_Display_Parameters.ResumeLayout(false);
      MainPanel.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private SplitContainer splitContainer_Main;
    private TableLayoutPanel tableLayoutPanel1;
    private Panel MainPanel;
    private GroupBox groupBox_PC_Display_Parameters;
    private GroupBox groupBox_Output;
    private Label label_Text_PC_Display_Parameters_Waveforms;
    private Label label_Text_PC_Display_Parameters_Duration;
    private Label label_Text_PC_Display_Parameters_Graph_Start;
    private Label label_Text_PC_Display_Parameters_Amplitude;
    private DomainUpDown domainUpDown_PC_Display_Parameters_Duration;
    private DomainUpDown domainUpDown_PC_Display_Parameters_Amplitude;
    private DomainUpDown domainUpDown_PC_Display_Parameters_Graph_Start;
    private ComboBox comboBox_PC_Display_Parameters_Waveforms;
    private Button button_Output_Play;
    private Panel panel_Text_PC_Display_Parameters;
    private Panel panel_Value_PC_Display_Parameters;
    private TableLayoutPanel tableLayoutPanel_Buttons;
    private Button button_Output_Stop;
    private GroupBox groupBox_Other_Functions;
    private Button button_Other_Functions_Load;
    private RadioButton radioButton_Square;
    private RadioButton radioButton_Triangle;
    private RadioButton radioButton_Sine;
    private GroupBox groupBox_CreateTest;
    private SplitContainer splitContainer_Create_Test;
    private CheckBox checkBox_Heart_Rate_Control;
    private Button button_Choice_ECG_Header;
    private Label label_Text_Name_Selected_ECG_Header;
    private CheckBox checkBox_Pneumogram;
    private Label label_Text_Omega_R;
    private Label label_Text_del_R;
    private ComboBox comboBox_Omega_R;
    private ComboBox comboBox_del_R;
    private TableLayoutPanel tableLayoutPanel_Pneumogram;
    private NumericUpDown numericUpDown_Heart_Rate_Control;
    private Button button2;
    private Button button1;
  }
}
