namespace Test_Cardiograph.Services.view
{
  partial class DB_CTSCSE_DBForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DB_CTSCSE_DBForm));
      checkedListBox_Database = new CheckedListBox();
      checkedListBox_DB_Noise = new CheckedListBox();
      splitContainer_MainForm = new SplitContainer();
      tableLayoutPanel_Menu_Panel = new TableLayoutPanel();
      groupBox_Menu = new GroupBox();
      splitContainer_Other_Parametrs = new SplitContainer();
      label_Text_Other_functions_Amplitude = new Label();
      label_Text_Other_functions_Frequency = new Label();
      numericUpDown_Amplitude = new NumericUpDown();
      numericUpDown_Frequency = new NumericUpDown();
      flowLayoutPanel1 = new FlowLayoutPanel();
      button_Load_File = new Button();
      comboBox_List_DB = new ComboBox();
      button_Choise_ECG = new Button();
      tableLayoutPanel_NoisePanel = new TableLayoutPanel();
      label_Text_NoisePanel = new Label();
      panel1 = new Panel();
      textBox_SearchName = new TextBox();
      openFileDialog = new OpenFileDialog();
      ((System.ComponentModel.ISupportInitialize)splitContainer_MainForm).BeginInit();
      splitContainer_MainForm.Panel1.SuspendLayout();
      splitContainer_MainForm.Panel2.SuspendLayout();
      splitContainer_MainForm.SuspendLayout();
      tableLayoutPanel_Menu_Panel.SuspendLayout();
      groupBox_Menu.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer_Other_Parametrs).BeginInit();
      splitContainer_Other_Parametrs.Panel1.SuspendLayout();
      splitContainer_Other_Parametrs.Panel2.SuspendLayout();
      splitContainer_Other_Parametrs.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)numericUpDown_Amplitude).BeginInit();
      ((System.ComponentModel.ISupportInitialize)numericUpDown_Frequency).BeginInit();
      flowLayoutPanel1.SuspendLayout();
      tableLayoutPanel_NoisePanel.SuspendLayout();
      panel1.SuspendLayout();
      SuspendLayout();
      // 
      // checkedListBox_Database
      // 
      checkedListBox_Database.CheckOnClick = true;
      checkedListBox_Database.ColumnWidth = 150;
      checkedListBox_Database.Dock = DockStyle.Fill;
      checkedListBox_Database.Font = new Font("Times New Roman", 12F);
      checkedListBox_Database.FormattingEnabled = true;
      checkedListBox_Database.Location = new Point(0, 0);
      checkedListBox_Database.Name = "checkedListBox_Database";
      checkedListBox_Database.ScrollAlwaysVisible = true;
      checkedListBox_Database.Size = new Size(228, 412);
      checkedListBox_Database.TabIndex = 0;
      checkedListBox_Database.ItemCheck += checkedListBox_ItemCheck;
      // 
      // checkedListBox_DB_Noise
      // 
      checkedListBox_DB_Noise.CheckOnClick = true;
      checkedListBox_DB_Noise.Dock = DockStyle.Fill;
      checkedListBox_DB_Noise.FormattingEnabled = true;
      checkedListBox_DB_Noise.Location = new Point(3, 21);
      checkedListBox_DB_Noise.Name = "checkedListBox_DB_Noise";
      checkedListBox_DB_Noise.Size = new Size(190, 239);
      checkedListBox_DB_Noise.TabIndex = 0;
      checkedListBox_DB_Noise.ItemCheck += checkedListBox_ItemCheck;
      // 
      // splitContainer_MainForm
      // 
      splitContainer_MainForm.Dock = DockStyle.Fill;
      splitContainer_MainForm.Location = new Point(0, 0);
      splitContainer_MainForm.Name = "splitContainer_MainForm";
      // 
      // splitContainer_MainForm.Panel1
      // 
      splitContainer_MainForm.Panel1.Controls.Add(tableLayoutPanel_Menu_Panel);
      // 
      // splitContainer_MainForm.Panel2
      // 
      splitContainer_MainForm.Panel2.Controls.Add(panel1);
      splitContainer_MainForm.Panel2.Controls.Add(textBox_SearchName);
      splitContainer_MainForm.Size = new Size(434, 433);
      splitContainer_MainForm.SplitterDistance = 202;
      splitContainer_MainForm.TabIndex = 3;
      // 
      // tableLayoutPanel_Menu_Panel
      // 
      tableLayoutPanel_Menu_Panel.ColumnCount = 1;
      tableLayoutPanel_Menu_Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      tableLayoutPanel_Menu_Panel.Controls.Add(groupBox_Menu, 0, 0);
      tableLayoutPanel_Menu_Panel.Controls.Add(tableLayoutPanel_NoisePanel, 0, 1);
      tableLayoutPanel_Menu_Panel.Dock = DockStyle.Fill;
      tableLayoutPanel_Menu_Panel.Location = new Point(0, 0);
      tableLayoutPanel_Menu_Panel.Name = "tableLayoutPanel_Menu_Panel";
      tableLayoutPanel_Menu_Panel.RowCount = 2;
      tableLayoutPanel_Menu_Panel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      tableLayoutPanel_Menu_Panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 269F));
      tableLayoutPanel_Menu_Panel.Size = new Size(202, 433);
      tableLayoutPanel_Menu_Panel.TabIndex = 0;
      // 
      // groupBox_Menu
      // 
      groupBox_Menu.Controls.Add(splitContainer_Other_Parametrs);
      groupBox_Menu.Controls.Add(flowLayoutPanel1);
      groupBox_Menu.Dock = DockStyle.Top;
      groupBox_Menu.Location = new Point(3, 3);
      groupBox_Menu.Name = "groupBox_Menu";
      groupBox_Menu.Size = new Size(196, 158);
      groupBox_Menu.TabIndex = 1;
      groupBox_Menu.TabStop = false;
      groupBox_Menu.Text = "Меню";
      // 
      // splitContainer_Other_Parametrs
      // 
      splitContainer_Other_Parametrs.Dock = DockStyle.Fill;
      splitContainer_Other_Parametrs.Location = new Point(3, 105);
      splitContainer_Other_Parametrs.Name = "splitContainer_Other_Parametrs";
      // 
      // splitContainer_Other_Parametrs.Panel1
      // 
      splitContainer_Other_Parametrs.Panel1.Controls.Add(label_Text_Other_functions_Amplitude);
      splitContainer_Other_Parametrs.Panel1.Controls.Add(label_Text_Other_functions_Frequency);
      // 
      // splitContainer_Other_Parametrs.Panel2
      // 
      splitContainer_Other_Parametrs.Panel2.Controls.Add(numericUpDown_Amplitude);
      splitContainer_Other_Parametrs.Panel2.Controls.Add(numericUpDown_Frequency);
      splitContainer_Other_Parametrs.Size = new Size(190, 50);
      splitContainer_Other_Parametrs.SplitterDistance = 95;
      splitContainer_Other_Parametrs.TabIndex = 5;
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
      // numericUpDown_Amplitude
      // 
      numericUpDown_Amplitude.Dock = DockStyle.Top;
      numericUpDown_Amplitude.Location = new Point(0, 21);
      numericUpDown_Amplitude.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
      numericUpDown_Amplitude.Minimum = new decimal(new int[] { 500, 0, 0, int.MinValue });
      numericUpDown_Amplitude.Name = "numericUpDown_Amplitude";
      numericUpDown_Amplitude.Size = new Size(91, 21);
      numericUpDown_Amplitude.TabIndex = 1;
      // 
      // numericUpDown_Frequency
      // 
      numericUpDown_Frequency.Dock = DockStyle.Top;
      numericUpDown_Frequency.Location = new Point(0, 0);
      numericUpDown_Frequency.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
      numericUpDown_Frequency.Minimum = new decimal(new int[] { 500, 0, 0, int.MinValue });
      numericUpDown_Frequency.Name = "numericUpDown_Frequency";
      numericUpDown_Frequency.Size = new Size(91, 21);
      numericUpDown_Frequency.TabIndex = 0;
      // 
      // flowLayoutPanel1
      // 
      flowLayoutPanel1.Controls.Add(button_Load_File);
      flowLayoutPanel1.Controls.Add(comboBox_List_DB);
      flowLayoutPanel1.Controls.Add(button_Choise_ECG);
      flowLayoutPanel1.Dock = DockStyle.Top;
      flowLayoutPanel1.Location = new Point(3, 17);
      flowLayoutPanel1.Name = "flowLayoutPanel1";
      flowLayoutPanel1.Size = new Size(190, 88);
      flowLayoutPanel1.TabIndex = 4;
      // 
      // button_Load_File
      // 
      button_Load_File.Dock = DockStyle.Top;
      button_Load_File.Location = new Point(3, 3);
      button_Load_File.Name = "button_Load_File";
      button_Load_File.Size = new Size(183, 23);
      button_Load_File.TabIndex = 0;
      button_Load_File.Text = "Загрузить (*hea)";
      button_Load_File.UseVisualStyleBackColor = true;
      button_Load_File.Click += button_Load_File_Click;
      // 
      // comboBox_List_DB
      // 
      comboBox_List_DB.Dock = DockStyle.Top;
      comboBox_List_DB.DropDownStyle = ComboBoxStyle.DropDownList;
      comboBox_List_DB.FormattingEnabled = true;
      comboBox_List_DB.Location = new Point(3, 32);
      comboBox_List_DB.Name = "comboBox_List_DB";
      comboBox_List_DB.Size = new Size(183, 23);
      comboBox_List_DB.TabIndex = 1;
      comboBox_List_DB.SelectedIndexChanged += comboBox_List_DB_SelectedIndexChanged;
      // 
      // button_Choise_ECG
      // 
      button_Choise_ECG.Dock = DockStyle.Top;
      button_Choise_ECG.Location = new Point(3, 61);
      button_Choise_ECG.Name = "button_Choise_ECG";
      button_Choise_ECG.Size = new Size(183, 23);
      button_Choise_ECG.TabIndex = 2;
      button_Choise_ECG.Text = "Выбрать ЭКГ";
      button_Choise_ECG.UseVisualStyleBackColor = true;
      button_Choise_ECG.Click += button_Choise_ECG_Click;
      // 
      // tableLayoutPanel_NoisePanel
      // 
      tableLayoutPanel_NoisePanel.ColumnCount = 1;
      tableLayoutPanel_NoisePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      tableLayoutPanel_NoisePanel.Controls.Add(checkedListBox_DB_Noise, 0, 1);
      tableLayoutPanel_NoisePanel.Controls.Add(label_Text_NoisePanel, 0, 0);
      tableLayoutPanel_NoisePanel.Dock = DockStyle.Top;
      tableLayoutPanel_NoisePanel.Location = new Point(3, 167);
      tableLayoutPanel_NoisePanel.Name = "tableLayoutPanel_NoisePanel";
      tableLayoutPanel_NoisePanel.RowCount = 2;
      tableLayoutPanel_NoisePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.84410667F));
      tableLayoutPanel_NoisePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 93.15589F));
      tableLayoutPanel_NoisePanel.Size = new Size(196, 263);
      tableLayoutPanel_NoisePanel.TabIndex = 2;
      // 
      // label_Text_NoisePanel
      // 
      label_Text_NoisePanel.AutoSize = true;
      label_Text_NoisePanel.Font = new Font("Times New Roman", 12F);
      label_Text_NoisePanel.Location = new Point(3, 0);
      label_Text_NoisePanel.Name = "label_Text_NoisePanel";
      label_Text_NoisePanel.Size = new Size(119, 18);
      label_Text_NoisePanel.TabIndex = 1;
      label_Text_NoisePanel.Text = "Фильтры шумов";
      // 
      // panel1
      // 
      panel1.Controls.Add(checkedListBox_Database);
      panel1.Dock = DockStyle.Fill;
      panel1.Location = new Point(0, 21);
      panel1.Name = "panel1";
      panel1.Size = new Size(228, 412);
      panel1.TabIndex = 3;
      // 
      // textBox_SearchName
      // 
      textBox_SearchName.Dock = DockStyle.Top;
      textBox_SearchName.Location = new Point(0, 0);
      textBox_SearchName.Name = "textBox_SearchName";
      textBox_SearchName.Size = new Size(228, 21);
      textBox_SearchName.TabIndex = 2;
      textBox_SearchName.TextChanged += textBox_SearchName_TextChanged;
      // 
      // openFileDialog
      // 
      openFileDialog.FileName = "openFileDialog";
      // 
      // DB_CTSCSE_DBForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(434, 433);
      Controls.Add(splitContainer_MainForm);
      Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
      Icon = (Icon)resources.GetObject("$this.Icon");
      Name = "DB_CTSCSE_DBForm";
      Text = "DB_CTSCSE_DB";
      FormClosing += DB_CTSCSE_DBForm_FormClosing;
      Load += DB_CTSCSE_DB_Load;
      splitContainer_MainForm.Panel1.ResumeLayout(false);
      splitContainer_MainForm.Panel2.ResumeLayout(false);
      splitContainer_MainForm.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer_MainForm).EndInit();
      splitContainer_MainForm.ResumeLayout(false);
      tableLayoutPanel_Menu_Panel.ResumeLayout(false);
      groupBox_Menu.ResumeLayout(false);
      splitContainer_Other_Parametrs.Panel1.ResumeLayout(false);
      splitContainer_Other_Parametrs.Panel1.PerformLayout();
      splitContainer_Other_Parametrs.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)splitContainer_Other_Parametrs).EndInit();
      splitContainer_Other_Parametrs.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)numericUpDown_Amplitude).EndInit();
      ((System.ComponentModel.ISupportInitialize)numericUpDown_Frequency).EndInit();
      flowLayoutPanel1.ResumeLayout(false);
      tableLayoutPanel_NoisePanel.ResumeLayout(false);
      tableLayoutPanel_NoisePanel.PerformLayout();
      panel1.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion
    private Label label_Text_CTS_Atlas;
    private CheckedListBox checkedListBox_Database;
    private CheckedListBox checkedListBox_DB_Noise;
    private Panel panel2;
    private Label label2;
    private Label label_Text_Noice;
    private Label label_Text_CSE;
    private Button button_Load_File;
    private SplitContainer splitContainer_MainForm;
    private TableLayoutPanel tableLayoutPanel_Menu_Panel;
    private TextBox textBox_SearchName;
    private ComboBox comboBox_List_DB;
    private GroupBox groupBox_Menu;
    private FlowLayoutPanel flowLayoutPanel1;
    private Button button_Choise_ECG;
    private TableLayoutPanel tableLayoutPanel_NoisePanel;
    private Label label_Text_NoisePanel;
    private Panel panel1;
    private SplitContainer splitContainer_Other_Parametrs;
    private Label label_Text_Other_functions_Amplitude;
    private Label label_Text_Other_functions_Frequency;
    private NumericUpDown numericUpDown_Amplitude;
    private NumericUpDown numericUpDown_Frequency;
    private OpenFileDialog openFileDialog;
  }
}