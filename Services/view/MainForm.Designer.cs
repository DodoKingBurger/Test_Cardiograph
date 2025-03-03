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
      groupBox_InputFile = new GroupBox();
      MainPanel = new Panel();
      tableLayoutPanel1 = new TableLayoutPanel();
      button_Sum_CTSCSEDB = new Button();
      button_Sum_GetECGsourcefromfile = new Button();
      ((System.ComponentModel.ISupportInitialize)splitContainer_Main).BeginInit();
      splitContainer_Main.Panel1.SuspendLayout();
      splitContainer_Main.Panel2.SuspendLayout();
      splitContainer_Main.SuspendLayout();
      groupBox_InputFile.SuspendLayout();
      MainPanel.SuspendLayout();
      SuspendLayout();
      // 
      // splitContainer_Main
      // 
      splitContainer_Main.Dock = DockStyle.Fill;
      splitContainer_Main.Location = new Point(0, 0);
      splitContainer_Main.Name = "splitContainer_Main";
      // 
      // splitContainer_Main.Panel1
      // 
      splitContainer_Main.Panel1.Controls.Add(groupBox_InputFile);
      splitContainer_Main.Panel1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
      // 
      // splitContainer_Main.Panel2
      // 
      splitContainer_Main.Panel2.Controls.Add(tableLayoutPanel1);
      splitContainer_Main.Size = new Size(834, 361);
      splitContainer_Main.SplitterDistance = 181;
      splitContainer_Main.TabIndex = 2;
      // 
      // groupBox_InputFile
      // 
      groupBox_InputFile.Controls.Add(button_Sum_GetECGsourcefromfile);
      groupBox_InputFile.Controls.Add(button_Sum_CTSCSEDB);
      groupBox_InputFile.Dock = DockStyle.Top;
      groupBox_InputFile.Location = new Point(0, 0);
      groupBox_InputFile.Name = "groupBox_InputFile";
      groupBox_InputFile.Size = new Size(181, 76);
      groupBox_InputFile.TabIndex = 0;
      groupBox_InputFile.TabStop = false;
      groupBox_InputFile.Text = "Input File";
      // 
      // MainPanel
      // 
      MainPanel.Controls.Add(splitContainer_Main);
      MainPanel.Dock = DockStyle.Fill;
      MainPanel.Location = new Point(0, 0);
      MainPanel.Name = "MainPanel";
      MainPanel.Size = new Size(834, 361);
      MainPanel.TabIndex = 0;
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
      tableLayoutPanel1.Size = new Size(649, 361);
      tableLayoutPanel1.TabIndex = 0;
      // 
      // button_Sum_CTSCSEDB
      // 
      button_Sum_CTSCSEDB.Dock = DockStyle.Top;
      button_Sum_CTSCSEDB.Location = new Point(3, 22);
      button_Sum_CTSCSEDB.Name = "button_Sum_CTSCSEDB";
      button_Sum_CTSCSEDB.Size = new Size(175, 23);
      button_Sum_CTSCSEDB.TabIndex = 0;
      button_Sum_CTSCSEDB.Text = "CTS/CSE DataBase";
      button_Sum_CTSCSEDB.UseVisualStyleBackColor = true;
      // 
      // button_Sum_GetECGsourcefromfile
      // 
      button_Sum_GetECGsourcefromfile.Dock = DockStyle.Top;
      button_Sum_GetECGsourcefromfile.Location = new Point(3, 45);
      button_Sum_GetECGsourcefromfile.Name = "button_Sum_GetECGsourcefromfile";
      button_Sum_GetECGsourcefromfile.Size = new Size(175, 23);
      button_Sum_GetECGsourcefromfile.TabIndex = 0;
      button_Sum_GetECGsourcefromfile.Text = "Get ECG source from file";
      button_Sum_GetECGsourcefromfile.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(834, 361);
      Controls.Add(MainPanel);
      Icon = (Icon)resources.GetObject("$this.Icon");
      Name = "MainForm";
      Text = "Тест кардиограф";
      splitContainer_Main.Panel1.ResumeLayout(false);
      splitContainer_Main.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)splitContainer_Main).EndInit();
      splitContainer_Main.ResumeLayout(false);
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
  }
}
