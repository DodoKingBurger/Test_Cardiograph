namespace Test_Cardiograph.Services.view
{
  partial class DB_CTSCSE_DB
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DB_CTSCSE_DB));
      panel1 = new Panel();
      label_Text_Noice = new Label();
      label_Text_CSE = new Label();
      label_Text_CTS_Atlas = new Label();
      splitContainer_CTSCSE_DB = new SplitContainer();
      checkedListBox_CTSCSE_Database = new CheckedListBox();
      checkedListBox_DB_Noise = new CheckedListBox();
      panel2 = new Panel();
      label2 = new Label();
      button_Load_Waveform = new Button();
      panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer_CTSCSE_DB).BeginInit();
      splitContainer_CTSCSE_DB.Panel1.SuspendLayout();
      splitContainer_CTSCSE_DB.Panel2.SuspendLayout();
      splitContainer_CTSCSE_DB.SuspendLayout();
      panel2.SuspendLayout();
      SuspendLayout();
      // 
      // panel1
      // 
      panel1.Controls.Add(label_Text_Noice);
      panel1.Controls.Add(label_Text_CSE);
      panel1.Controls.Add(label_Text_CTS_Atlas);
      panel1.Dock = DockStyle.Top;
      panel1.Location = new Point(0, 0);
      panel1.Name = "panel1";
      panel1.Size = new Size(619, 24);
      panel1.TabIndex = 1;
      // 
      // label_Text_Noice
      // 
      label_Text_Noice.AutoSize = true;
      label_Text_Noice.Location = new Point(510, 6);
      label_Text_Noice.Name = "label_Text_Noice";
      label_Text_Noice.Size = new Size(35, 15);
      label_Text_Noice.TabIndex = 3;
      label_Text_Noice.Text = "Noice";
      // 
      // label_Text_CSE
      // 
      label_Text_CSE.AutoSize = true;
      label_Text_CSE.Location = new Point(159, 6);
      label_Text_CSE.Name = "label_Text_CSE";
      label_Text_CSE.Size = new Size(246, 15);
      label_Text_CSE.TabIndex = 2;
      label_Text_CSE.Text = "Biological ECGs from CSE measurement database";
      // 
      // label_Text_CTS_Atlas
      // 
      label_Text_CTS_Atlas.AutoSize = true;
      label_Text_CTS_Atlas.Location = new Point(38, 6);
      label_Text_CTS_Atlas.Name = "label_Text_CTS_Atlas";
      label_Text_CTS_Atlas.Size = new Size(61, 15);
      label_Text_CTS_Atlas.TabIndex = 1;
      label_Text_CTS_Atlas.Text = "CTS_Atlas";
      // 
      // splitContainer_CTSCSE_DB
      // 
      splitContainer_CTSCSE_DB.Dock = DockStyle.Top;
      splitContainer_CTSCSE_DB.Location = new Point(0, 24);
      splitContainer_CTSCSE_DB.Name = "splitContainer_CTSCSE_DB";
      // 
      // splitContainer_CTSCSE_DB.Panel1
      // 
      splitContainer_CTSCSE_DB.Panel1.Controls.Add(checkedListBox_CTSCSE_Database);
      // 
      // splitContainer_CTSCSE_DB.Panel2
      // 
      splitContainer_CTSCSE_DB.Panel2.Controls.Add(checkedListBox_DB_Noise);
      splitContainer_CTSCSE_DB.Size = new Size(619, 240);
      splitContainer_CTSCSE_DB.SplitterDistance = 430;
      splitContainer_CTSCSE_DB.TabIndex = 2;
      // 
      // checkedListBox_CTSCSE_Database
      // 
      checkedListBox_CTSCSE_Database.CheckOnClick = true;
      checkedListBox_CTSCSE_Database.Dock = DockStyle.Fill;
      checkedListBox_CTSCSE_Database.FormattingEnabled = true;
      checkedListBox_CTSCSE_Database.Location = new Point(0, 0);
      checkedListBox_CTSCSE_Database.MultiColumn = true;
      checkedListBox_CTSCSE_Database.Name = "checkedListBox_CTSCSE_Database";
      checkedListBox_CTSCSE_Database.ScrollAlwaysVisible = true;
      checkedListBox_CTSCSE_Database.Size = new Size(430, 240);
      checkedListBox_CTSCSE_Database.TabIndex = 0;
      checkedListBox_CTSCSE_Database.ItemCheck += checkedListBox_ItemCheck;
      // 
      // checkedListBox_DB_Noise
      // 
      checkedListBox_DB_Noise.CheckOnClick = true;
      checkedListBox_DB_Noise.Dock = DockStyle.Fill;
      checkedListBox_DB_Noise.FormattingEnabled = true;
      checkedListBox_DB_Noise.Location = new Point(0, 0);
      checkedListBox_DB_Noise.Name = "checkedListBox_DB_Noise";
      checkedListBox_DB_Noise.Size = new Size(185, 240);
      checkedListBox_DB_Noise.TabIndex = 0;
      checkedListBox_DB_Noise.ItemCheck += checkedListBox_ItemCheck;
      // 
      // panel2
      // 
      panel2.Controls.Add(label2);
      panel2.Controls.Add(button_Load_Waveform);
      panel2.Dock = DockStyle.Top;
      panel2.Location = new Point(0, 264);
      panel2.Name = "panel2";
      panel2.Size = new Size(619, 24);
      panel2.TabIndex = 3;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Dock = DockStyle.Right;
      label2.Location = new Point(62, 0);
      label2.Name = "label2";
      label2.Size = new Size(465, 15);
      label2.TabIndex = 1;
      label2.Text = "Choose from the above waveforms (adding in noise if needed), then press the \"Load Waveform\"";
      // 
      // button_Load_Waveform
      // 
      button_Load_Waveform.Dock = DockStyle.Right;
      button_Load_Waveform.Location = new Point(527, 0);
      button_Load_Waveform.Name = "button_Load_Waveform";
      button_Load_Waveform.Size = new Size(92, 24);
      button_Load_Waveform.TabIndex = 0;
      button_Load_Waveform.Text = "Load Waveform";
      button_Load_Waveform.UseVisualStyleBackColor = true;
      button_Load_Waveform.Click += button_Load_Waveform_Click;
      // 
      // DB_CTSCSE_DB
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(619, 291);
      Controls.Add(panel2);
      Controls.Add(splitContainer_CTSCSE_DB);
      Controls.Add(panel1);
      Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
      FormBorderStyle = FormBorderStyle.FixedDialog;
      Icon = (Icon)resources.GetObject("$this.Icon");
      Name = "DB_CTSCSE_DB";
      Text = "DB_CTSCSE_DB";
      Load += DB_CTSCSE_DB_Load;
      panel1.ResumeLayout(false);
      panel1.PerformLayout();
      splitContainer_CTSCSE_DB.Panel1.ResumeLayout(false);
      splitContainer_CTSCSE_DB.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)splitContainer_CTSCSE_DB).EndInit();
      splitContainer_CTSCSE_DB.ResumeLayout(false);
      panel2.ResumeLayout(false);
      panel2.PerformLayout();
      ResumeLayout(false);
    }

    #endregion
    private Panel panel1;
    private Label label_Text_CTS_Atlas;
    private SplitContainer splitContainer_CTSCSE_DB;
    private CheckedListBox checkedListBox_CTSCSE_Database;
    private CheckedListBox checkedListBox_DB_Noise;
    private Panel panel2;
    private Label label2;
    private Button button_Load_Waveform;
    private Label label_Text_Noice;
    private Label label_Text_CSE;
    private Button button1;
  }
}