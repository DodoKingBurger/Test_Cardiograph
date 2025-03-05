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
      splitContainer_CTSCSE_DB = new SplitContainer();
      checkedListBox_Database = new CheckedListBox();
      checkedListBox_DB_Noise = new CheckedListBox();
      ((System.ComponentModel.ISupportInitialize)splitContainer_CTSCSE_DB).BeginInit();
      splitContainer_CTSCSE_DB.Panel1.SuspendLayout();
      splitContainer_CTSCSE_DB.Panel2.SuspendLayout();
      splitContainer_CTSCSE_DB.SuspendLayout();
      SuspendLayout();
      // 
      // splitContainer_CTSCSE_DB
      // 
      splitContainer_CTSCSE_DB.Location = new Point(81, 207);
      splitContainer_CTSCSE_DB.Name = "splitContainer_CTSCSE_DB";
      // 
      // splitContainer_CTSCSE_DB.Panel1
      // 
      splitContainer_CTSCSE_DB.Panel1.Controls.Add(checkedListBox_Database);
      // 
      // splitContainer_CTSCSE_DB.Panel2
      // 
      splitContainer_CTSCSE_DB.Panel2.Controls.Add(checkedListBox_DB_Noise);
      splitContainer_CTSCSE_DB.Size = new Size(225, 165);
      splitContainer_CTSCSE_DB.SplitterDistance = 109;
      splitContainer_CTSCSE_DB.TabIndex = 2;
      // 
      // checkedListBox_Database
      // 
      checkedListBox_Database.CheckOnClick = true;
      checkedListBox_Database.ColumnWidth = 100;
      checkedListBox_Database.FormattingEnabled = true;
      checkedListBox_Database.Location = new Point(19, 12);
      checkedListBox_Database.MultiColumn = true;
      checkedListBox_Database.Name = "checkedListBox_Database";
      checkedListBox_Database.ScrollAlwaysVisible = true;
      checkedListBox_Database.Size = new Size(133, 84);
      checkedListBox_Database.TabIndex = 0;
      checkedListBox_Database.ItemCheck += checkedListBox_ItemCheck;
      // 
      // checkedListBox_DB_Noise
      // 
      checkedListBox_DB_Noise.CheckOnClick = true;
      checkedListBox_DB_Noise.Dock = DockStyle.Fill;
      checkedListBox_DB_Noise.FormattingEnabled = true;
      checkedListBox_DB_Noise.Location = new Point(0, 0);
      checkedListBox_DB_Noise.Name = "checkedListBox_DB_Noise";
      checkedListBox_DB_Noise.Size = new Size(112, 165);
      checkedListBox_DB_Noise.TabIndex = 0;
      checkedListBox_DB_Noise.ItemCheck += checkedListBox_ItemCheck;
      // 
      // DB_CTSCSE_DBForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(855, 472);
      Controls.Add(splitContainer_CTSCSE_DB);
      Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
      FormBorderStyle = FormBorderStyle.FixedDialog;
      Icon = (Icon)resources.GetObject("$this.Icon");
      Name = "DB_CTSCSE_DBForm";
      Text = "DB_CTSCSE_DB";
      Load += DB_CTSCSE_DB_Load;
      splitContainer_CTSCSE_DB.Panel1.ResumeLayout(false);
      splitContainer_CTSCSE_DB.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)splitContainer_CTSCSE_DB).EndInit();
      splitContainer_CTSCSE_DB.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion
    private Panel panel1;
    private Label label_Text_CTS_Atlas;
    private SplitContainer splitContainer_CTSCSE_DB;
    private CheckedListBox checkedListBox_Database;
    private CheckedListBox checkedListBox_DB_Noise;
    private Panel panel2;
    private Label label2;
    private Button button_Load_Waveform;
    private Label label_Text_Noice;
    private Label label_Text_CSE;
    private Button button1;
  }
}