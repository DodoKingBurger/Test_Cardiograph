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
      groupBox_Other_Functions = new GroupBox();
      splitContainer_Other_functions = new SplitContainer();
      label_Text_Other_functions_Amplitude = new Label();
      label_Text_Other_functions_Frequency = new Label();
      domainUpDown1 = new DomainUpDown();
      domainUpDown_Frequency = new DomainUpDown();
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
      groupBox_InputFile = new GroupBox();
      button_Sum_GetECGsourcefromfile = new Button();
      button_Sum_CTSCSEDB = new Button();
      tableLayoutPanel1 = new TableLayoutPanel();
      MainPanel = new Panel();
      ((System.ComponentModel.ISupportInitialize)splitContainer_Main).BeginInit();
      splitContainer_Main.Panel1.SuspendLayout();
      splitContainer_Main.Panel2.SuspendLayout();
      splitContainer_Main.SuspendLayout();
      groupBox_Other_Functions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer_Other_functions).BeginInit();
      splitContainer_Other_functions.Panel1.SuspendLayout();
      splitContainer_Other_functions.Panel2.SuspendLayout();
      splitContainer_Other_functions.SuspendLayout();
      groupBox_Output.SuspendLayout();
      tableLayoutPanel_Buttons.SuspendLayout();
      groupBox_PC_Display_Parameters.SuspendLayout();
      panel_Text_PC_Display_Parameters.SuspendLayout();
      panel_Value_PC_Display_Parameters.SuspendLayout();
      groupBox_InputFile.SuspendLayout();
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
      splitContainer_Main.Panel1.Controls.Add(groupBox_Other_Functions);
      splitContainer_Main.Panel1.Controls.Add(groupBox_Output);
      splitContainer_Main.Panel1.Controls.Add(groupBox_PC_Display_Parameters);
      splitContainer_Main.Panel1.Controls.Add(groupBox_InputFile);
      splitContainer_Main.Panel1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
      // 
      // splitContainer_Main.Panel2
      // 
      splitContainer_Main.Panel2.Controls.Add(tableLayoutPanel1);
      splitContainer_Main.Size = new Size(834, 515);
      splitContainer_Main.SplitterDistance = 181;
      splitContainer_Main.TabIndex = 2;
      // 
      // groupBox_Other_Functions
      // 
      groupBox_Other_Functions.Controls.Add(splitContainer_Other_functions);
      groupBox_Other_Functions.Controls.Add(button_Other_Functions_Load);
      groupBox_Other_Functions.Controls.Add(radioButton_Square);
      groupBox_Other_Functions.Controls.Add(radioButton_Triangle);
      groupBox_Other_Functions.Controls.Add(radioButton_Sine);
      groupBox_Other_Functions.Dock = DockStyle.Top;
      groupBox_Other_Functions.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
      groupBox_Other_Functions.Location = new Point(0, 348);
      groupBox_Other_Functions.Name = "groupBox_Other_Functions";
      groupBox_Other_Functions.Size = new Size(181, 144);
      groupBox_Other_Functions.TabIndex = 1;
      groupBox_Other_Functions.TabStop = false;
      groupBox_Other_Functions.Text = "Other functions";
      // 
      // splitContainer_Other_functions
      // 
      splitContainer_Other_functions.Dock = DockStyle.Fill;
      splitContainer_Other_functions.Location = new Point(3, 97);
      splitContainer_Other_functions.Name = "splitContainer_Other_functions";
      // 
      // splitContainer_Other_functions.Panel1
      // 
      splitContainer_Other_functions.Panel1.Controls.Add(label_Text_Other_functions_Amplitude);
      splitContainer_Other_functions.Panel1.Controls.Add(label_Text_Other_functions_Frequency);
      // 
      // splitContainer_Other_functions.Panel2
      // 
      splitContainer_Other_functions.Panel2.Controls.Add(domainUpDown1);
      splitContainer_Other_functions.Panel2.Controls.Add(domainUpDown_Frequency);
      splitContainer_Other_functions.Size = new Size(175, 44);
      splitContainer_Other_functions.SplitterDistance = 89;
      splitContainer_Other_functions.TabIndex = 3;
      // 
      // label_Text_Other_functions_Amplitude
      // 
      label_Text_Other_functions_Amplitude.AutoSize = true;
      label_Text_Other_functions_Amplitude.Location = new Point(12, 23);
      label_Text_Other_functions_Amplitude.Name = "label_Text_Other_functions_Amplitude";
      label_Text_Other_functions_Amplitude.Size = new Size(62, 15);
      label_Text_Other_functions_Amplitude.TabIndex = 2;
      label_Text_Other_functions_Amplitude.Text = "Amplitude:";
      // 
      // label_Text_Other_functions_Frequency
      // 
      label_Text_Other_functions_Frequency.AutoSize = true;
      label_Text_Other_functions_Frequency.Location = new Point(12, 2);
      label_Text_Other_functions_Frequency.Name = "label_Text_Other_functions_Frequency";
      label_Text_Other_functions_Frequency.Size = new Size(61, 15);
      label_Text_Other_functions_Frequency.TabIndex = 1;
      label_Text_Other_functions_Frequency.Text = "Frequency:";
      // 
      // domainUpDown1
      // 
      domainUpDown1.Dock = DockStyle.Top;
      domainUpDown1.Location = new Point(0, 21);
      domainUpDown1.Name = "domainUpDown1";
      domainUpDown1.RightToLeft = RightToLeft.Yes;
      domainUpDown1.Size = new Size(82, 21);
      domainUpDown1.TabIndex = 1;
      domainUpDown1.Text = "1,000";
      // 
      // domainUpDown_Frequency
      // 
      domainUpDown_Frequency.Dock = DockStyle.Top;
      domainUpDown_Frequency.Location = new Point(0, 0);
      domainUpDown_Frequency.Name = "domainUpDown_Frequency";
      domainUpDown_Frequency.RightToLeft = RightToLeft.Yes;
      domainUpDown_Frequency.Size = new Size(82, 21);
      domainUpDown_Frequency.TabIndex = 0;
      domainUpDown_Frequency.Text = "1,00";
      // 
      // button_Other_Functions_Load
      // 
      button_Other_Functions_Load.Dock = DockStyle.Top;
      button_Other_Functions_Load.Location = new Point(3, 74);
      button_Other_Functions_Load.Name = "button_Other_Functions_Load";
      button_Other_Functions_Load.Size = new Size(175, 23);
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
      radioButton_Square.Size = new Size(175, 19);
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
      radioButton_Triangle.Size = new Size(175, 19);
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
      radioButton_Sine.Size = new Size(175, 19);
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
      groupBox_Output.Location = new Point(0, 184);
      groupBox_Output.Name = "groupBox_Output";
      groupBox_Output.Size = new Size(181, 164);
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
      tableLayoutPanel_Buttons.RowStyles.Add(new RowStyle(SizeType.Percent, 46.0317459F));
      tableLayoutPanel_Buttons.RowStyles.Add(new RowStyle(SizeType.Percent, 53.9682541F));
      tableLayoutPanel_Buttons.Size = new Size(175, 64);
      tableLayoutPanel_Buttons.TabIndex = 0;
      // 
      // button_Output_Stop
      // 
      button_Output_Stop.Dock = DockStyle.Fill;
      button_Output_Stop.Location = new Point(90, 3);
      button_Output_Stop.Name = "button_Output_Stop";
      button_Output_Stop.Size = new Size(82, 23);
      button_Output_Stop.TabIndex = 1;
      button_Output_Stop.Text = "Stop";
      button_Output_Stop.UseVisualStyleBackColor = true;
      // 
      // button_Output_Play
      // 
      button_Output_Play.Dock = DockStyle.Fill;
      button_Output_Play.Location = new Point(3, 3);
      button_Output_Play.Name = "button_Output_Play";
      button_Output_Play.Size = new Size(81, 23);
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
      groupBox_PC_Display_Parameters.Location = new Point(0, 76);
      groupBox_PC_Display_Parameters.Name = "groupBox_PC_Display_Parameters";
      groupBox_PC_Display_Parameters.Size = new Size(181, 108);
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
      panel_Value_PC_Display_Parameters.Location = new Point(126, 17);
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
      // groupBox_InputFile
      // 
      groupBox_InputFile.Controls.Add(button_Sum_GetECGsourcefromfile);
      groupBox_InputFile.Controls.Add(button_Sum_CTSCSEDB);
      groupBox_InputFile.Dock = DockStyle.Top;
      groupBox_InputFile.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
      groupBox_InputFile.Location = new Point(0, 0);
      groupBox_InputFile.Name = "groupBox_InputFile";
      groupBox_InputFile.Size = new Size(181, 76);
      groupBox_InputFile.TabIndex = 0;
      groupBox_InputFile.TabStop = false;
      groupBox_InputFile.Text = "Input File";
      // 
      // button_Sum_GetECGsourcefromfile
      // 
      button_Sum_GetECGsourcefromfile.Dock = DockStyle.Top;
      button_Sum_GetECGsourcefromfile.Location = new Point(3, 40);
      button_Sum_GetECGsourcefromfile.Name = "button_Sum_GetECGsourcefromfile";
      button_Sum_GetECGsourcefromfile.Size = new Size(175, 23);
      button_Sum_GetECGsourcefromfile.TabIndex = 0;
      button_Sum_GetECGsourcefromfile.Text = "Get ECG source from file";
      button_Sum_GetECGsourcefromfile.UseVisualStyleBackColor = true;
      // 
      // button_Sum_CTSCSEDB
      // 
      button_Sum_CTSCSEDB.Dock = DockStyle.Top;
      button_Sum_CTSCSEDB.Location = new Point(3, 17);
      button_Sum_CTSCSEDB.Name = "button_Sum_CTSCSEDB";
      button_Sum_CTSCSEDB.Size = new Size(175, 23);
      button_Sum_CTSCSEDB.TabIndex = 0;
      button_Sum_CTSCSEDB.Text = "CTS/CSE DataBase";
      button_Sum_CTSCSEDB.UseVisualStyleBackColor = true;
      button_Sum_CTSCSEDB.Click += button_Sum_CTSCSEDB_Click;
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.ColumnCount = 2;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      tableLayoutPanel1.Dock = DockStyle.Fill;
      tableLayoutPanel1.Location = new Point(0, 0);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 2;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      tableLayoutPanel1.Size = new Size(649, 515);
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
      groupBox_Other_Functions.ResumeLayout(false);
      groupBox_Other_Functions.PerformLayout();
      splitContainer_Other_functions.Panel1.ResumeLayout(false);
      splitContainer_Other_functions.Panel1.PerformLayout();
      splitContainer_Other_functions.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)splitContainer_Other_functions).EndInit();
      splitContainer_Other_functions.ResumeLayout(false);
      groupBox_Output.ResumeLayout(false);
      tableLayoutPanel_Buttons.ResumeLayout(false);
      groupBox_PC_Display_Parameters.ResumeLayout(false);
      panel_Text_PC_Display_Parameters.ResumeLayout(false);
      panel_Text_PC_Display_Parameters.PerformLayout();
      panel_Value_PC_Display_Parameters.ResumeLayout(false);
      groupBox_InputFile.ResumeLayout(false);
      MainPanel.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private SplitContainer splitContainer_Main;
    private GroupBox groupBox_InputFile;
    private Button button_Sum_GetECGsourcefromfile;
    private Button button_Sum_CTSCSEDB;
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
    private SplitContainer splitContainer_Other_functions;
    private Button button_Other_Functions_Load;
    private RadioButton radioButton_Square;
    private RadioButton radioButton_Triangle;
    private RadioButton radioButton_Sine;
    private Label label_Text_Other_functions_Amplitude;
    private Label label_Text_Other_functions_Frequency;
    private DomainUpDown domainUpDown1;
    private DomainUpDown domainUpDown_Frequency;
  }
}
