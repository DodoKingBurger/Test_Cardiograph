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
      flowLayoutPanel2 = new FlowLayoutPanel();
      label_Text_Search = new Label();
      textBox_SearchName = new TextBox();
      flowLayoutPanel1 = new FlowLayoutPanel();
      button_Load_hea_File = new Button();
      comboBox_List_DB = new ComboBox();
      button_Load_Waveform = new Button();
      tableLayoutPanel_NoisePanel = new TableLayoutPanel();
      label_Text_NoisePanel = new Label();
      ((System.ComponentModel.ISupportInitialize)splitContainer_MainForm).BeginInit();
      splitContainer_MainForm.Panel1.SuspendLayout();
      splitContainer_MainForm.Panel2.SuspendLayout();
      splitContainer_MainForm.SuspendLayout();
      tableLayoutPanel_Menu_Panel.SuspendLayout();
      groupBox_Menu.SuspendLayout();
      flowLayoutPanel2.SuspendLayout();
      flowLayoutPanel1.SuspendLayout();
      tableLayoutPanel_NoisePanel.SuspendLayout();
      SuspendLayout();
      // 
      // checkedListBox_Database
      // 
      checkedListBox_Database.CheckOnClick = true;
      checkedListBox_Database.ColumnWidth = 100;
      checkedListBox_Database.Dock = DockStyle.Fill;
      checkedListBox_Database.Font = new Font("Times New Roman", 12F);
      checkedListBox_Database.FormattingEnabled = true;
      checkedListBox_Database.Location = new Point(0, 0);
      checkedListBox_Database.MultiColumn = true;
      checkedListBox_Database.Name = "checkedListBox_Database";
      checkedListBox_Database.ScrollAlwaysVisible = true;
      checkedListBox_Database.Size = new Size(402, 433);
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
      checkedListBox_DB_Noise.Size = new Size(191, 239);
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
      splitContainer_MainForm.Panel2.Controls.Add(checkedListBox_Database);
      splitContainer_MainForm.Size = new Size(609, 433);
      splitContainer_MainForm.SplitterDistance = 203;
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
      tableLayoutPanel_Menu_Panel.Size = new Size(203, 433);
      tableLayoutPanel_Menu_Panel.TabIndex = 0;
      // 
      // groupBox_Menu
      // 
      groupBox_Menu.Controls.Add(flowLayoutPanel2);
      groupBox_Menu.Controls.Add(flowLayoutPanel1);
      groupBox_Menu.Dock = DockStyle.Top;
      groupBox_Menu.Location = new Point(3, 3);
      groupBox_Menu.Name = "groupBox_Menu";
      groupBox_Menu.Size = new Size(197, 158);
      groupBox_Menu.TabIndex = 1;
      groupBox_Menu.TabStop = false;
      groupBox_Menu.Text = "Меню";
      // 
      // flowLayoutPanel2
      // 
      flowLayoutPanel2.Controls.Add(label_Text_Search);
      flowLayoutPanel2.Controls.Add(textBox_SearchName);
      flowLayoutPanel2.Dock = DockStyle.Fill;
      flowLayoutPanel2.Location = new Point(3, 105);
      flowLayoutPanel2.Name = "flowLayoutPanel2";
      flowLayoutPanel2.Size = new Size(191, 50);
      flowLayoutPanel2.TabIndex = 5;
      // 
      // label_Text_Search
      // 
      label_Text_Search.AutoSize = true;
      label_Text_Search.Location = new Point(3, 0);
      label_Text_Search.Name = "label_Text_Search";
      label_Text_Search.Size = new Size(105, 15);
      label_Text_Search.TabIndex = 3;
      label_Text_Search.Text = "Пойск по названию";
      // 
      // textBox_SearchName
      // 
      textBox_SearchName.Location = new Point(3, 18);
      textBox_SearchName.Name = "textBox_SearchName";
      textBox_SearchName.Size = new Size(183, 21);
      textBox_SearchName.TabIndex = 2;
      textBox_SearchName.TextChanged += textBox_SearchName_TextChanged;
      // 
      // flowLayoutPanel1
      // 
      flowLayoutPanel1.Controls.Add(button_Load_hea_File);
      flowLayoutPanel1.Controls.Add(comboBox_List_DB);
      flowLayoutPanel1.Controls.Add(button_Load_Waveform);
      flowLayoutPanel1.Dock = DockStyle.Top;
      flowLayoutPanel1.Location = new Point(3, 17);
      flowLayoutPanel1.Name = "flowLayoutPanel1";
      flowLayoutPanel1.Size = new Size(191, 88);
      flowLayoutPanel1.TabIndex = 4;
      // 
      // button_Load_hea_File
      // 
      button_Load_hea_File.Dock = DockStyle.Top;
      button_Load_hea_File.Location = new Point(3, 3);
      button_Load_hea_File.Name = "button_Load_hea_File";
      button_Load_hea_File.Size = new Size(183, 23);
      button_Load_hea_File.TabIndex = 0;
      button_Load_hea_File.Text = "Загрузить (*hea)";
      button_Load_hea_File.UseVisualStyleBackColor = true;
      button_Load_hea_File.Click += button_Load_hea_File_Click;
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
      // button_Load_Waveform
      // 
      button_Load_Waveform.Dock = DockStyle.Top;
      button_Load_Waveform.Location = new Point(3, 61);
      button_Load_Waveform.Name = "button_Load_Waveform";
      button_Load_Waveform.Size = new Size(183, 23);
      button_Load_Waveform.TabIndex = 2;
      button_Load_Waveform.Text = "Выбрать ЭКГ";
      button_Load_Waveform.UseVisualStyleBackColor = true;
      button_Load_Waveform.Click += button_Load_Waveform_Click;
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
      tableLayoutPanel_NoisePanel.Size = new Size(197, 263);
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
      // DB_CTSCSE_DBForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(609, 433);
      Controls.Add(splitContainer_MainForm);
      Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
      Icon = (Icon)resources.GetObject("$this.Icon");
      Name = "DB_CTSCSE_DBForm";
      Text = "DB_CTSCSE_DB";
      Load += DB_CTSCSE_DB_Load;
      splitContainer_MainForm.Panel1.ResumeLayout(false);
      splitContainer_MainForm.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)splitContainer_MainForm).EndInit();
      splitContainer_MainForm.ResumeLayout(false);
      tableLayoutPanel_Menu_Panel.ResumeLayout(false);
      groupBox_Menu.ResumeLayout(false);
      flowLayoutPanel2.ResumeLayout(false);
      flowLayoutPanel2.PerformLayout();
      flowLayoutPanel1.ResumeLayout(false);
      tableLayoutPanel_NoisePanel.ResumeLayout(false);
      tableLayoutPanel_NoisePanel.PerformLayout();
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
    private Button button_Load_hea_File;
    private SplitContainer splitContainer_MainForm;
    private TableLayoutPanel tableLayoutPanel_Menu_Panel;
    private Label label_Text_Search;
    private TextBox textBox_SearchName;
    private ComboBox comboBox_List_DB;
    private GroupBox groupBox_Menu;
    private FlowLayoutPanel flowLayoutPanel1;
    private FlowLayoutPanel flowLayoutPanel2;
    private Button button_Load_Waveform;
    private TableLayoutPanel tableLayoutPanel_NoisePanel;
    private Label label_Text_NoisePanel;
  }
}