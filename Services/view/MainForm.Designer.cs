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
      MainPanel = new Panel();
      tableLayoutPanel_Main = new TableLayoutPanel();
      groupBox_Output = new GroupBox();
      tableLayoutPanel_Buttons = new TableLayoutPanel();
      button_Output_Stop = new Button();
      button_Output_Play = new Button();
      splitContainer1 = new SplitContainer();
      checkedListBox_List_Stage = new CheckedListBox();
      groupBox_Create_Stage = new GroupBox();
      tableLayoutPanel1 = new TableLayoutPanel();
      groupBox_Notifications_Confirmation = new GroupBox();
      textBox2 = new TextBox();
      groupBox_Create_Notifications = new GroupBox();
      textBox_Create_Notifications = new TextBox();
      splitContainer_Text_Name_Stage = new SplitContainer();
      label1 = new Label();
      textBox_Name_Stage = new TextBox();
      checkedListBox_List_Checks = new CheckedListBox();
      groupBox_Command_for_Stage = new GroupBox();
      tableLayoutPanel2 = new TableLayoutPanel();
      button_Save_Selected_Stage = new Button();
      button_Up = new Button();
      button_Down = new Button();
      comboBox_Type_Command_View = new ComboBox();
      groupBox_CreateTest.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer_Create_Test).BeginInit();
      splitContainer_Create_Test.Panel1.SuspendLayout();
      splitContainer_Create_Test.Panel2.SuspendLayout();
      splitContainer_Create_Test.SuspendLayout();
      tableLayoutPanel_Pneumogram.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)numericUpDown_Heart_Rate_Control).BeginInit();
      MainPanel.SuspendLayout();
      tableLayoutPanel_Main.SuspendLayout();
      groupBox_Output.SuspendLayout();
      tableLayoutPanel_Buttons.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
      splitContainer1.Panel1.SuspendLayout();
      splitContainer1.Panel2.SuspendLayout();
      splitContainer1.SuspendLayout();
      groupBox_Create_Stage.SuspendLayout();
      tableLayoutPanel1.SuspendLayout();
      groupBox_Notifications_Confirmation.SuspendLayout();
      groupBox_Create_Notifications.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer_Text_Name_Stage).BeginInit();
      splitContainer_Text_Name_Stage.Panel1.SuspendLayout();
      splitContainer_Text_Name_Stage.Panel2.SuspendLayout();
      splitContainer_Text_Name_Stage.SuspendLayout();
      groupBox_Command_for_Stage.SuspendLayout();
      tableLayoutPanel2.SuspendLayout();
      SuspendLayout();
      // 
      // groupBox_CreateTest
      // 
      groupBox_CreateTest.Controls.Add(splitContainer_Create_Test);
      groupBox_CreateTest.Dock = DockStyle.Fill;
      groupBox_CreateTest.Font = new Font("Times New Roman", 16F);
      groupBox_CreateTest.Location = new Point(4, 41);
      groupBox_CreateTest.Margin = new Padding(4);
      groupBox_CreateTest.Name = "groupBox_CreateTest";
      groupBox_CreateTest.Padding = new Padding(4);
      groupBox_CreateTest.Size = new Size(415, 247);
      groupBox_CreateTest.TabIndex = 1;
      groupBox_CreateTest.TabStop = false;
      groupBox_CreateTest.Text = "Команда";
      // 
      // splitContainer_Create_Test
      // 
      splitContainer_Create_Test.Dock = DockStyle.Fill;
      splitContainer_Create_Test.Location = new Point(4, 29);
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
      splitContainer_Create_Test.Size = new Size(407, 214);
      splitContainer_Create_Test.SplitterDistance = 187;
      splitContainer_Create_Test.TabIndex = 0;
      // 
      // button2
      // 
      button2.Dock = DockStyle.Top;
      button2.Location = new Point(0, 122);
      button2.Name = "button2";
      button2.Size = new Size(187, 35);
      button2.TabIndex = 4;
      button2.Text = "Загрузить";
      button2.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      button1.Dock = DockStyle.Top;
      button1.Location = new Point(0, 89);
      button1.Name = "button1";
      button1.Size = new Size(187, 33);
      button1.TabIndex = 3;
      button1.Text = "Сохранить";
      button1.UseVisualStyleBackColor = true;
      // 
      // checkBox_Pneumogram
      // 
      checkBox_Pneumogram.AutoSize = true;
      checkBox_Pneumogram.Dock = DockStyle.Top;
      checkBox_Pneumogram.Location = new Point(0, 60);
      checkBox_Pneumogram.Name = "checkBox_Pneumogram";
      checkBox_Pneumogram.Size = new Size(187, 29);
      checkBox_Pneumogram.TabIndex = 2;
      checkBox_Pneumogram.Text = "Пневмограмма";
      checkBox_Pneumogram.UseVisualStyleBackColor = true;
      checkBox_Pneumogram.CheckedChanged += checkBox_Pneumogram_CheckedChanged;
      // 
      // checkBox_Heart_Rate_Control
      // 
      checkBox_Heart_Rate_Control.AutoSize = true;
      checkBox_Heart_Rate_Control.Dock = DockStyle.Top;
      checkBox_Heart_Rate_Control.Location = new Point(0, 31);
      checkBox_Heart_Rate_Control.Name = "checkBox_Heart_Rate_Control";
      checkBox_Heart_Rate_Control.Size = new Size(187, 29);
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
      button_Choice_ECG_Header.Size = new Size(187, 31);
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
      tableLayoutPanel_Pneumogram.Location = new Point(0, 57);
      tableLayoutPanel_Pneumogram.Name = "tableLayoutPanel_Pneumogram";
      tableLayoutPanel_Pneumogram.RowCount = 2;
      tableLayoutPanel_Pneumogram.RowStyles.Add(new RowStyle(SizeType.Percent, 46.6666679F));
      tableLayoutPanel_Pneumogram.RowStyles.Add(new RowStyle(SizeType.Percent, 53.3333321F));
      tableLayoutPanel_Pneumogram.Size = new Size(216, 71);
      tableLayoutPanel_Pneumogram.TabIndex = 2;
      // 
      // comboBox_del_R
      // 
      comboBox_del_R.Dock = DockStyle.Top;
      comboBox_del_R.Font = new Font("Times New Roman", 16F);
      comboBox_del_R.FormattingEnabled = true;
      comboBox_del_R.Location = new Point(119, 3);
      comboBox_del_R.Name = "comboBox_del_R";
      comboBox_del_R.Size = new Size(94, 31);
      comboBox_del_R.TabIndex = 0;
      // 
      // comboBox_Omega_R
      // 
      comboBox_Omega_R.Dock = DockStyle.Top;
      comboBox_Omega_R.Font = new Font("Times New Roman", 16F);
      comboBox_Omega_R.FormattingEnabled = true;
      comboBox_Omega_R.Location = new Point(119, 36);
      comboBox_Omega_R.Name = "comboBox_Omega_R";
      comboBox_Omega_R.Size = new Size(94, 31);
      comboBox_Omega_R.TabIndex = 1;
      // 
      // label_Text_del_R
      // 
      label_Text_del_R.AutoSize = true;
      label_Text_del_R.Dock = DockStyle.Top;
      label_Text_del_R.Font = new Font("Times New Roman", 16F);
      label_Text_del_R.Location = new Point(3, 0);
      label_Text_del_R.Name = "label_Text_del_R";
      label_Text_del_R.Size = new Size(110, 25);
      label_Text_del_R.TabIndex = 0;
      label_Text_del_R.Text = "ΔR";
      // 
      // label_Text_Omega_R
      // 
      label_Text_Omega_R.AutoSize = true;
      label_Text_Omega_R.Dock = DockStyle.Top;
      label_Text_Omega_R.Font = new Font("Times New Roman", 16F);
      label_Text_Omega_R.Location = new Point(3, 33);
      label_Text_Omega_R.Name = "label_Text_Omega_R";
      label_Text_Omega_R.Size = new Size(110, 25);
      label_Text_Omega_R.TabIndex = 1;
      label_Text_Omega_R.Text = "Омега R";
      // 
      // numericUpDown_Heart_Rate_Control
      // 
      numericUpDown_Heart_Rate_Control.Dock = DockStyle.Top;
      numericUpDown_Heart_Rate_Control.Location = new Point(0, 25);
      numericUpDown_Heart_Rate_Control.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
      numericUpDown_Heart_Rate_Control.Name = "numericUpDown_Heart_Rate_Control";
      numericUpDown_Heart_Rate_Control.RightToLeft = RightToLeft.Yes;
      numericUpDown_Heart_Rate_Control.Size = new Size(216, 32);
      numericUpDown_Heart_Rate_Control.TabIndex = 3;
      // 
      // label_Text_Name_Selected_ECG_Header
      // 
      label_Text_Name_Selected_ECG_Header.AutoSize = true;
      label_Text_Name_Selected_ECG_Header.Dock = DockStyle.Top;
      label_Text_Name_Selected_ECG_Header.Font = new Font("Times New Roman", 16F);
      label_Text_Name_Selected_ECG_Header.Location = new Point(0, 0);
      label_Text_Name_Selected_ECG_Header.Name = "label_Text_Name_Selected_ECG_Header";
      label_Text_Name_Selected_ECG_Header.Size = new Size(162, 25);
      label_Text_Name_Selected_ECG_Header.TabIndex = 0;
      label_Text_Name_Selected_ECG_Header.Text = ".........................";
      // 
      // MainPanel
      // 
      MainPanel.Controls.Add(tableLayoutPanel_Main);
      MainPanel.Dock = DockStyle.Fill;
      MainPanel.Location = new Point(0, 0);
      MainPanel.Margin = new Padding(4);
      MainPanel.Name = "MainPanel";
      MainPanel.Size = new Size(1264, 985);
      MainPanel.TabIndex = 0;
      // 
      // tableLayoutPanel_Main
      // 
      tableLayoutPanel_Main.ColumnCount = 2;
      tableLayoutPanel_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.079113F));
      tableLayoutPanel_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.92088F));
      tableLayoutPanel_Main.Controls.Add(groupBox_Output, 0, 1);
      tableLayoutPanel_Main.Controls.Add(splitContainer1, 1, 0);
      tableLayoutPanel_Main.Controls.Add(checkedListBox_List_Checks, 0, 0);
      tableLayoutPanel_Main.Controls.Add(groupBox_Command_for_Stage, 1, 1);
      tableLayoutPanel_Main.Dock = DockStyle.Fill;
      tableLayoutPanel_Main.Font = new Font("Times New Roman", 12F);
      tableLayoutPanel_Main.Location = new Point(0, 0);
      tableLayoutPanel_Main.Margin = new Padding(4);
      tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
      tableLayoutPanel_Main.RowCount = 2;
      tableLayoutPanel_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 90.55837F));
      tableLayoutPanel_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 9.441625F));
      tableLayoutPanel_Main.Size = new Size(1264, 985);
      tableLayoutPanel_Main.TabIndex = 3;
      // 
      // groupBox_Output
      // 
      groupBox_Output.Controls.Add(tableLayoutPanel_Buttons);
      groupBox_Output.Dock = DockStyle.Fill;
      groupBox_Output.Font = new Font("Times New Roman", 16F);
      groupBox_Output.Location = new Point(4, 896);
      groupBox_Output.Margin = new Padding(4);
      groupBox_Output.Name = "groupBox_Output";
      groupBox_Output.Padding = new Padding(4);
      groupBox_Output.Size = new Size(308, 85);
      groupBox_Output.TabIndex = 3;
      groupBox_Output.TabStop = false;
      groupBox_Output.Text = "Управление тестированием";
      // 
      // tableLayoutPanel_Buttons
      // 
      tableLayoutPanel_Buttons.ColumnCount = 2;
      tableLayoutPanel_Buttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      tableLayoutPanel_Buttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      tableLayoutPanel_Buttons.Controls.Add(button_Output_Stop, 1, 0);
      tableLayoutPanel_Buttons.Controls.Add(button_Output_Play, 0, 0);
      tableLayoutPanel_Buttons.Dock = DockStyle.Fill;
      tableLayoutPanel_Buttons.Location = new Point(4, 29);
      tableLayoutPanel_Buttons.Margin = new Padding(4);
      tableLayoutPanel_Buttons.Name = "tableLayoutPanel_Buttons";
      tableLayoutPanel_Buttons.RowCount = 1;
      tableLayoutPanel_Buttons.RowStyles.Add(new RowStyle(SizeType.Percent, 70.7317047F));
      tableLayoutPanel_Buttons.Size = new Size(300, 52);
      tableLayoutPanel_Buttons.TabIndex = 0;
      // 
      // button_Output_Stop
      // 
      button_Output_Stop.Dock = DockStyle.Fill;
      button_Output_Stop.Location = new Point(154, 4);
      button_Output_Stop.Margin = new Padding(4);
      button_Output_Stop.Name = "button_Output_Stop";
      button_Output_Stop.Size = new Size(142, 44);
      button_Output_Stop.TabIndex = 1;
      button_Output_Stop.Text = "Стоп";
      button_Output_Stop.UseVisualStyleBackColor = true;
      // 
      // button_Output_Play
      // 
      button_Output_Play.Dock = DockStyle.Fill;
      button_Output_Play.Location = new Point(4, 4);
      button_Output_Play.Margin = new Padding(4);
      button_Output_Play.Name = "button_Output_Play";
      button_Output_Play.Size = new Size(142, 44);
      button_Output_Play.TabIndex = 0;
      button_Output_Play.Text = "Старт";
      button_Output_Play.UseVisualStyleBackColor = true;
      // 
      // splitContainer1
      // 
      splitContainer1.Dock = DockStyle.Fill;
      splitContainer1.Location = new Point(319, 3);
      splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      splitContainer1.Panel1.Controls.Add(checkedListBox_List_Stage);
      // 
      // splitContainer1.Panel2
      // 
      splitContainer1.Panel2.Controls.Add(groupBox_Create_Stage);
      splitContainer1.Size = new Size(942, 886);
      splitContainer1.SplitterDistance = 509;
      splitContainer1.TabIndex = 2;
      // 
      // checkedListBox_List_Stage
      // 
      checkedListBox_List_Stage.Dock = DockStyle.Fill;
      checkedListBox_List_Stage.FormattingEnabled = true;
      checkedListBox_List_Stage.Location = new Point(0, 0);
      checkedListBox_List_Stage.Name = "checkedListBox_List_Stage";
      checkedListBox_List_Stage.Size = new Size(509, 886);
      checkedListBox_List_Stage.TabIndex = 0;
      // 
      // groupBox_Create_Stage
      // 
      groupBox_Create_Stage.Controls.Add(tableLayoutPanel1);
      groupBox_Create_Stage.Dock = DockStyle.Fill;
      groupBox_Create_Stage.Font = new Font("Times New Roman", 16F);
      groupBox_Create_Stage.Location = new Point(0, 0);
      groupBox_Create_Stage.Name = "groupBox_Create_Stage";
      groupBox_Create_Stage.Size = new Size(429, 886);
      groupBox_Create_Stage.TabIndex = 3;
      groupBox_Create_Stage.TabStop = false;
      groupBox_Create_Stage.Text = "Меню создания этапа";
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.ColumnCount = 1;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      tableLayoutPanel1.Controls.Add(groupBox_Notifications_Confirmation, 0, 3);
      tableLayoutPanel1.Controls.Add(groupBox_Create_Notifications, 0, 2);
      tableLayoutPanel1.Controls.Add(groupBox_CreateTest, 0, 1);
      tableLayoutPanel1.Controls.Add(splitContainer_Text_Name_Stage, 0, 0);
      tableLayoutPanel1.Dock = DockStyle.Fill;
      tableLayoutPanel1.Location = new Point(3, 28);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 4;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.6712332F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.3287659F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 275F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 287F));
      tableLayoutPanel1.Size = new Size(423, 855);
      tableLayoutPanel1.TabIndex = 3;
      // 
      // groupBox_Notifications_Confirmation
      // 
      groupBox_Notifications_Confirmation.Controls.Add(textBox2);
      groupBox_Notifications_Confirmation.Dock = DockStyle.Fill;
      groupBox_Notifications_Confirmation.Location = new Point(3, 570);
      groupBox_Notifications_Confirmation.Name = "groupBox_Notifications_Confirmation";
      groupBox_Notifications_Confirmation.Size = new Size(417, 282);
      groupBox_Notifications_Confirmation.TabIndex = 3;
      groupBox_Notifications_Confirmation.TabStop = false;
      groupBox_Notifications_Confirmation.Text = "Уведомление с подтверждением";
      // 
      // textBox2
      // 
      textBox2.Dock = DockStyle.Fill;
      textBox2.Location = new Point(3, 28);
      textBox2.Multiline = true;
      textBox2.Name = "textBox2";
      textBox2.Size = new Size(411, 251);
      textBox2.TabIndex = 0;
      // 
      // groupBox_Create_Notifications
      // 
      groupBox_Create_Notifications.Controls.Add(textBox_Create_Notifications);
      groupBox_Create_Notifications.Dock = DockStyle.Fill;
      groupBox_Create_Notifications.Location = new Point(3, 295);
      groupBox_Create_Notifications.Name = "groupBox_Create_Notifications";
      groupBox_Create_Notifications.Size = new Size(417, 269);
      groupBox_Create_Notifications.TabIndex = 2;
      groupBox_Create_Notifications.TabStop = false;
      groupBox_Create_Notifications.Text = "Уведомление пользователя";
      // 
      // textBox_Create_Notifications
      // 
      textBox_Create_Notifications.Dock = DockStyle.Fill;
      textBox_Create_Notifications.Location = new Point(3, 28);
      textBox_Create_Notifications.Multiline = true;
      textBox_Create_Notifications.Name = "textBox_Create_Notifications";
      textBox_Create_Notifications.Size = new Size(411, 238);
      textBox_Create_Notifications.TabIndex = 0;
      // 
      // splitContainer_Text_Name_Stage
      // 
      splitContainer_Text_Name_Stage.Dock = DockStyle.Fill;
      splitContainer_Text_Name_Stage.Location = new Point(3, 3);
      splitContainer_Text_Name_Stage.Name = "splitContainer_Text_Name_Stage";
      // 
      // splitContainer_Text_Name_Stage.Panel1
      // 
      splitContainer_Text_Name_Stage.Panel1.Controls.Add(label1);
      // 
      // splitContainer_Text_Name_Stage.Panel2
      // 
      splitContainer_Text_Name_Stage.Panel2.Controls.Add(textBox_Name_Stage);
      splitContainer_Text_Name_Stage.Size = new Size(417, 31);
      splitContainer_Text_Name_Stage.SplitterDistance = 170;
      splitContainer_Text_Name_Stage.TabIndex = 4;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Dock = DockStyle.Fill;
      label1.Location = new Point(0, 0);
      label1.Name = "label1";
      label1.Size = new Size(163, 25);
      label1.TabIndex = 0;
      label1.Text = "Название Этапа";
      // 
      // textBox_Name_Stage
      // 
      textBox_Name_Stage.Dock = DockStyle.Fill;
      textBox_Name_Stage.Location = new Point(0, 0);
      textBox_Name_Stage.Name = "textBox_Name_Stage";
      textBox_Name_Stage.Size = new Size(243, 32);
      textBox_Name_Stage.TabIndex = 0;
      // 
      // checkedListBox_List_Checks
      // 
      checkedListBox_List_Checks.Dock = DockStyle.Fill;
      checkedListBox_List_Checks.Font = new Font("Times New Roman", 16F);
      checkedListBox_List_Checks.FormattingEnabled = true;
      checkedListBox_List_Checks.Location = new Point(3, 3);
      checkedListBox_List_Checks.Name = "checkedListBox_List_Checks";
      checkedListBox_List_Checks.Size = new Size(310, 886);
      checkedListBox_List_Checks.TabIndex = 4;
      // 
      // groupBox_Command_for_Stage
      // 
      groupBox_Command_for_Stage.Controls.Add(tableLayoutPanel2);
      groupBox_Command_for_Stage.Dock = DockStyle.Fill;
      groupBox_Command_for_Stage.Font = new Font("Times New Roman", 16F);
      groupBox_Command_for_Stage.Location = new Point(319, 895);
      groupBox_Command_for_Stage.Name = "groupBox_Command_for_Stage";
      groupBox_Command_for_Stage.Size = new Size(942, 87);
      groupBox_Command_for_Stage.TabIndex = 5;
      groupBox_Command_for_Stage.TabStop = false;
      groupBox_Command_for_Stage.Text = "Команды для работы со списком этапов";
      // 
      // tableLayoutPanel2
      // 
      tableLayoutPanel2.ColumnCount = 5;
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.97959F));
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.02041F));
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 169F));
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 318F));
      tableLayoutPanel2.Controls.Add(button_Save_Selected_Stage, 3, 0);
      tableLayoutPanel2.Controls.Add(button_Up, 0, 0);
      tableLayoutPanel2.Controls.Add(button_Down, 1, 0);
      tableLayoutPanel2.Controls.Add(comboBox_Type_Command_View, 4, 0);
      tableLayoutPanel2.Dock = DockStyle.Fill;
      tableLayoutPanel2.Location = new Point(3, 28);
      tableLayoutPanel2.Name = "tableLayoutPanel2";
      tableLayoutPanel2.RowCount = 1;
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      tableLayoutPanel2.Size = new Size(936, 56);
      tableLayoutPanel2.TabIndex = 4;
      // 
      // button_Save_Selected_Stage
      // 
      button_Save_Selected_Stage.Dock = DockStyle.Fill;
      button_Save_Selected_Stage.Location = new Point(420, 3);
      button_Save_Selected_Stage.Name = "button_Save_Selected_Stage";
      button_Save_Selected_Stage.Size = new Size(194, 50);
      button_Save_Selected_Stage.TabIndex = 1;
      button_Save_Selected_Stage.Text = "Сохранить Этап";
      button_Save_Selected_Stage.UseVisualStyleBackColor = true;
      // 
      // button_Up
      // 
      button_Up.Dock = DockStyle.Fill;
      button_Up.Location = new Point(3, 3);
      button_Up.Name = "button_Up";
      button_Up.Size = new Size(115, 50);
      button_Up.TabIndex = 2;
      button_Up.Text = "Вверх";
      button_Up.UseVisualStyleBackColor = true;
      // 
      // button_Down
      // 
      button_Down.Dock = DockStyle.Fill;
      button_Down.Location = new Point(124, 3);
      button_Down.Name = "button_Down";
      button_Down.Size = new Size(121, 50);
      button_Down.TabIndex = 3;
      button_Down.Text = "Вниз";
      button_Down.UseVisualStyleBackColor = true;
      // 
      // comboBox_Type_Command_View
      // 
      comboBox_Type_Command_View.Dock = DockStyle.Fill;
      comboBox_Type_Command_View.DropDownStyle = ComboBoxStyle.DropDownList;
      comboBox_Type_Command_View.FlatStyle = FlatStyle.Flat;
      comboBox_Type_Command_View.FormattingEnabled = true;
      comboBox_Type_Command_View.Location = new Point(620, 3);
      comboBox_Type_Command_View.Name = "comboBox_Type_Command_View";
      comboBox_Type_Command_View.Size = new Size(313, 31);
      comboBox_Type_Command_View.TabIndex = 0;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(9F, 19F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1264, 985);
      Controls.Add(MainPanel);
      Font = new Font("Times New Roman", 12F);
      Icon = (Icon)resources.GetObject("$this.Icon");
      Margin = new Padding(4);
      Name = "MainForm";
      Text = "Тест кардиограф";
      Load += MainForm_Load;
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
      MainPanel.ResumeLayout(false);
      tableLayoutPanel_Main.ResumeLayout(false);
      groupBox_Output.ResumeLayout(false);
      tableLayoutPanel_Buttons.ResumeLayout(false);
      splitContainer1.Panel1.ResumeLayout(false);
      splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
      splitContainer1.ResumeLayout(false);
      groupBox_Create_Stage.ResumeLayout(false);
      tableLayoutPanel1.ResumeLayout(false);
      groupBox_Notifications_Confirmation.ResumeLayout(false);
      groupBox_Notifications_Confirmation.PerformLayout();
      groupBox_Create_Notifications.ResumeLayout(false);
      groupBox_Create_Notifications.PerformLayout();
      splitContainer_Text_Name_Stage.Panel1.ResumeLayout(false);
      splitContainer_Text_Name_Stage.Panel1.PerformLayout();
      splitContainer_Text_Name_Stage.Panel2.ResumeLayout(false);
      splitContainer_Text_Name_Stage.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer_Text_Name_Stage).EndInit();
      splitContainer_Text_Name_Stage.ResumeLayout(false);
      groupBox_Command_for_Stage.ResumeLayout(false);
      tableLayoutPanel2.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion
    private Panel MainPanel;
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
    private TableLayoutPanel tableLayoutPanel_Main;
    private GroupBox groupBox_Output;
    private TableLayoutPanel tableLayoutPanel_Buttons;
    private Button button_Output_Stop;
    private Button button_Output_Play;
    private SplitContainer splitContainer1;
    private CheckedListBox checkedListBox_List_Stage;
    private CheckedListBox checkedListBox_List_Checks;
    private GroupBox groupBox_Create_Stage;
    private GroupBox groupBox_Create_Notifications;
    private TableLayoutPanel tableLayoutPanel1;
    private GroupBox groupBox_Notifications_Confirmation;
    private TextBox textBox2;
    private TextBox textBox_Create_Notifications;
    private SplitContainer splitContainer_Text_Name_Stage;
    private Label label1;
    private TextBox textBox_Name_Stage;
    private GroupBox groupBox_Command_for_Stage;
    private Button button_Down;
    private Button button_Up;
    private Button button_Save_Selected_Stage;
    private ComboBox comboBox_Type_Command_View;
    private TableLayoutPanel tableLayoutPanel2;
  }
}
