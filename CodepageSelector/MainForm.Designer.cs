namespace CodepageSelector;

partial class MainForm {
  /// <summary>
  ///  Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  ///  Clean up any resources being used.
  /// </summary>
  /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
  protected override void Dispose(bool disposing) {
    if (disposing && (components != null)) {
      components.Dispose();
    }
    base.Dispose(disposing);
  }

  #region Windows Form Designer generated code

  /// <summary>
  ///  Required method for Designer support - do not modify
  ///  the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
      System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      System.Windows.Forms.Label label1;
      System.Windows.Forms.Label label2;
      System.Windows.Forms.Label label3;
      System.Windows.Forms.Label label4;
      System.Windows.Forms.Label label5;
      System.Windows.Forms.Label label6;
      System.Windows.Forms.Label label7;
      System.Windows.Forms.Label label8;
      System.Windows.Forms.Label label9;
      System.Windows.Forms.Label label10;
      System.Windows.Forms.Label label11;
      System.Windows.Forms.Label label12;
      System.Windows.Forms.Label label13;
      System.Windows.Forms.Label label14;
      System.Windows.Forms.Label label15;
      System.Windows.Forms.Label label16;
      System.Windows.Forms.Label label17;
      System.Windows.Forms.Label label18;
      System.Windows.Forms.Label label19;
      System.Windows.Forms.Label label20;
      System.Windows.Forms.Label label21;
      System.Windows.Forms.Label label22;
      System.Windows.Forms.Label label23;
      System.Windows.Forms.Label label24;
      System.Windows.Forms.Label label25;
      System.Windows.Forms.Label label26;
      System.Windows.Forms.Label label27;
      System.Windows.Forms.Label label28;
      System.Windows.Forms.Label label29;
      System.Windows.Forms.Label label30;
      System.Windows.Forms.Label label31;
      System.Windows.Forms.Label label32;
      System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
      this.nudCurrentPage = new System.Windows.Forms.NumericUpDown();
      this.tlpCharacters = new System.Windows.Forms.TableLayoutPanel();
      this.lCodepageName = new System.Windows.Forms.Label();
      this.ttHelp = new System.Windows.Forms.ToolTip(this.components);
      this.btBack = new System.Windows.Forms.Button();
      this.lCodepageError = new System.Windows.Forms.Label();
      this.lCodepageSuccess = new System.Windows.Forms.Label();
      this.btForward = new System.Windows.Forms.Button();
      this.lCodepageLoading = new System.Windows.Forms.Label();
      this.bError = new System.Windows.Forms.Button();
      this.bWhiteSpace = new System.Windows.Forms.Button();
      this.bControl = new System.Windows.Forms.Button();
      this.bPunctuation = new System.Windows.Forms.Button();
      this.bLower = new System.Windows.Forms.Button();
      this.bUpper = new System.Windows.Forms.Button();
      this.bLetter = new System.Windows.Forms.Button();
      this.bDigit = new System.Windows.Forms.Button();
      this.bNumber = new System.Windows.Forms.Button();
      this.bOther = new System.Windows.Forms.Button();
      flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      label1 = new System.Windows.Forms.Label();
      label2 = new System.Windows.Forms.Label();
      label3 = new System.Windows.Forms.Label();
      label4 = new System.Windows.Forms.Label();
      label5 = new System.Windows.Forms.Label();
      label6 = new System.Windows.Forms.Label();
      label7 = new System.Windows.Forms.Label();
      label8 = new System.Windows.Forms.Label();
      label9 = new System.Windows.Forms.Label();
      label10 = new System.Windows.Forms.Label();
      label11 = new System.Windows.Forms.Label();
      label12 = new System.Windows.Forms.Label();
      label13 = new System.Windows.Forms.Label();
      label14 = new System.Windows.Forms.Label();
      label15 = new System.Windows.Forms.Label();
      label16 = new System.Windows.Forms.Label();
      label17 = new System.Windows.Forms.Label();
      label18 = new System.Windows.Forms.Label();
      label19 = new System.Windows.Forms.Label();
      label20 = new System.Windows.Forms.Label();
      label21 = new System.Windows.Forms.Label();
      label22 = new System.Windows.Forms.Label();
      label23 = new System.Windows.Forms.Label();
      label24 = new System.Windows.Forms.Label();
      label25 = new System.Windows.Forms.Label();
      label26 = new System.Windows.Forms.Label();
      label27 = new System.Windows.Forms.Label();
      label28 = new System.Windows.Forms.Label();
      label29 = new System.Windows.Forms.Label();
      label30 = new System.Windows.Forms.Label();
      label31 = new System.Windows.Forms.Label();
      label32 = new System.Windows.Forms.Label();
      flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
      flowLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudCurrentPage)).BeginInit();
      tableLayoutPanel1.SuspendLayout();
      this.tlpCharacters.SuspendLayout();
      flowLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // flowLayoutPanel1
      // 
      flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
      flowLayoutPanel1.AutoSize = true;
      flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      flowLayoutPanel1.Controls.Add(this.btBack);
      flowLayoutPanel1.Controls.Add(this.nudCurrentPage);
      flowLayoutPanel1.Controls.Add(this.lCodepageError);
      flowLayoutPanel1.Controls.Add(this.lCodepageSuccess);
      flowLayoutPanel1.Controls.Add(this.lCodepageLoading);
      flowLayoutPanel1.Controls.Add(this.btForward);
      flowLayoutPanel1.Location = new System.Drawing.Point(187, 0);
      flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
      flowLayoutPanel1.Name = "flowLayoutPanel1";
      flowLayoutPanel1.Size = new System.Drawing.Size(210, 32);
      flowLayoutPanel1.TabIndex = 0;
      // 
      // nudCurrentPage
      // 
      this.nudCurrentPage.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.nudCurrentPage.AutoSize = true;
      this.nudCurrentPage.Location = new System.Drawing.Point(35, 6);
      this.nudCurrentPage.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
      this.nudCurrentPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nudCurrentPage.Name = "nudCurrentPage";
      this.nudCurrentPage.Size = new System.Drawing.Size(53, 20);
      this.nudCurrentPage.TabIndex = 1;
      this.nudCurrentPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.ttHelp.SetToolTip(this.nudCurrentPage, "Enter Codepage and Press TAB");
      this.nudCurrentPage.Value = new decimal(new int[] {
            55555,
            0,
            0,
            0});
      this.nudCurrentPage.ValueChanged += new System.EventHandler(this.nudCurrentPage_ValueChanged);
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.ColumnCount = 1;
      tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
      tableLayoutPanel1.Controls.Add(this.tlpCharacters, 0, 3);
      tableLayoutPanel1.Controls.Add(this.lCodepageName, 0, 1);
      tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 2);
      tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 4;
      tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      tableLayoutPanel1.Size = new System.Drawing.Size(584, 587);
      tableLayoutPanel1.TabIndex = 1;
      // 
      // tlpCharacters
      // 
      this.tlpCharacters.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.tlpCharacters.AutoSize = true;
      this.tlpCharacters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.tlpCharacters.ColumnCount = 17;
      this.tlpCharacters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tlpCharacters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tlpCharacters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tlpCharacters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tlpCharacters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tlpCharacters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tlpCharacters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tlpCharacters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tlpCharacters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tlpCharacters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tlpCharacters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tlpCharacters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tlpCharacters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tlpCharacters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tlpCharacters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tlpCharacters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tlpCharacters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tlpCharacters.Controls.Add(label1, 1, 0);
      this.tlpCharacters.Controls.Add(label2, 2, 0);
      this.tlpCharacters.Controls.Add(label3, 3, 0);
      this.tlpCharacters.Controls.Add(label4, 4, 0);
      this.tlpCharacters.Controls.Add(label5, 5, 0);
      this.tlpCharacters.Controls.Add(label6, 6, 0);
      this.tlpCharacters.Controls.Add(label7, 7, 0);
      this.tlpCharacters.Controls.Add(label8, 8, 0);
      this.tlpCharacters.Controls.Add(label9, 9, 0);
      this.tlpCharacters.Controls.Add(label10, 10, 0);
      this.tlpCharacters.Controls.Add(label11, 11, 0);
      this.tlpCharacters.Controls.Add(label12, 12, 0);
      this.tlpCharacters.Controls.Add(label13, 13, 0);
      this.tlpCharacters.Controls.Add(label14, 14, 0);
      this.tlpCharacters.Controls.Add(label15, 15, 0);
      this.tlpCharacters.Controls.Add(label16, 16, 0);
      this.tlpCharacters.Controls.Add(label17, 0, 1);
      this.tlpCharacters.Controls.Add(label18, 0, 2);
      this.tlpCharacters.Controls.Add(label19, 0, 3);
      this.tlpCharacters.Controls.Add(label20, 0, 4);
      this.tlpCharacters.Controls.Add(label21, 0, 5);
      this.tlpCharacters.Controls.Add(label22, 0, 6);
      this.tlpCharacters.Controls.Add(label23, 0, 7);
      this.tlpCharacters.Controls.Add(label24, 0, 8);
      this.tlpCharacters.Controls.Add(label25, 0, 9);
      this.tlpCharacters.Controls.Add(label26, 0, 10);
      this.tlpCharacters.Controls.Add(label27, 0, 11);
      this.tlpCharacters.Controls.Add(label28, 0, 12);
      this.tlpCharacters.Controls.Add(label29, 0, 13);
      this.tlpCharacters.Controls.Add(label30, 0, 14);
      this.tlpCharacters.Controls.Add(label31, 0, 15);
      this.tlpCharacters.Controls.Add(label32, 0, 16);
      this.tlpCharacters.Location = new System.Drawing.Point(62, 100);
      this.tlpCharacters.Name = "tlpCharacters";
      this.tlpCharacters.RowCount = 17;
      this.tlpCharacters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.tlpCharacters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.tlpCharacters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.tlpCharacters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.tlpCharacters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.tlpCharacters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.tlpCharacters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.tlpCharacters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.tlpCharacters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.tlpCharacters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.tlpCharacters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.tlpCharacters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.tlpCharacters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.tlpCharacters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.tlpCharacters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.tlpCharacters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.tlpCharacters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.tlpCharacters.Size = new System.Drawing.Size(459, 476);
      this.tlpCharacters.TabIndex = 1;
      // 
      // label1
      // 
      label1.Anchor = System.Windows.Forms.AnchorStyles.None;
      label1.AutoSize = true;
      label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label1.Location = new System.Drawing.Point(31, 7);
      label1.Name = "label1";
      label1.Size = new System.Drawing.Size(18, 13);
      label1.TabIndex = 0;
      label1.Text = ".0";
      // 
      // label2
      // 
      label2.Anchor = System.Windows.Forms.AnchorStyles.None;
      label2.AutoSize = true;
      label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label2.Location = new System.Drawing.Point(58, 7);
      label2.Name = "label2";
      label2.Size = new System.Drawing.Size(18, 13);
      label2.TabIndex = 0;
      label2.Text = ".1";
      // 
      // label3
      // 
      label3.Anchor = System.Windows.Forms.AnchorStyles.None;
      label3.AutoSize = true;
      label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label3.Location = new System.Drawing.Point(85, 7);
      label3.Name = "label3";
      label3.Size = new System.Drawing.Size(18, 13);
      label3.TabIndex = 0;
      label3.Text = ".2";
      // 
      // label4
      // 
      label4.Anchor = System.Windows.Forms.AnchorStyles.None;
      label4.AutoSize = true;
      label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label4.Location = new System.Drawing.Point(112, 7);
      label4.Name = "label4";
      label4.Size = new System.Drawing.Size(18, 13);
      label4.TabIndex = 0;
      label4.Text = ".3";
      // 
      // label5
      // 
      label5.Anchor = System.Windows.Forms.AnchorStyles.None;
      label5.AutoSize = true;
      label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label5.Location = new System.Drawing.Point(139, 7);
      label5.Name = "label5";
      label5.Size = new System.Drawing.Size(18, 13);
      label5.TabIndex = 0;
      label5.Text = ".4";
      // 
      // label6
      // 
      label6.Anchor = System.Windows.Forms.AnchorStyles.None;
      label6.AutoSize = true;
      label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label6.Location = new System.Drawing.Point(166, 7);
      label6.Name = "label6";
      label6.Size = new System.Drawing.Size(18, 13);
      label6.TabIndex = 0;
      label6.Text = ".5";
      // 
      // label7
      // 
      label7.Anchor = System.Windows.Forms.AnchorStyles.None;
      label7.AutoSize = true;
      label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label7.Location = new System.Drawing.Point(193, 7);
      label7.Name = "label7";
      label7.Size = new System.Drawing.Size(18, 13);
      label7.TabIndex = 0;
      label7.Text = ".6";
      // 
      // label8
      // 
      label8.Anchor = System.Windows.Forms.AnchorStyles.None;
      label8.AutoSize = true;
      label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label8.Location = new System.Drawing.Point(220, 7);
      label8.Name = "label8";
      label8.Size = new System.Drawing.Size(18, 13);
      label8.TabIndex = 0;
      label8.Text = ".7";
      // 
      // label9
      // 
      label9.Anchor = System.Windows.Forms.AnchorStyles.None;
      label9.AutoSize = true;
      label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label9.Location = new System.Drawing.Point(247, 7);
      label9.Name = "label9";
      label9.Size = new System.Drawing.Size(18, 13);
      label9.TabIndex = 0;
      label9.Text = ".8";
      // 
      // label10
      // 
      label10.Anchor = System.Windows.Forms.AnchorStyles.None;
      label10.AutoSize = true;
      label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label10.Location = new System.Drawing.Point(274, 7);
      label10.Name = "label10";
      label10.Size = new System.Drawing.Size(18, 13);
      label10.TabIndex = 0;
      label10.Text = ".9";
      // 
      // label11
      // 
      label11.Anchor = System.Windows.Forms.AnchorStyles.None;
      label11.AutoSize = true;
      label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label11.Location = new System.Drawing.Point(301, 7);
      label11.Name = "label11";
      label11.Size = new System.Drawing.Size(19, 13);
      label11.TabIndex = 0;
      label11.Text = ".A";
      // 
      // label12
      // 
      label12.Anchor = System.Windows.Forms.AnchorStyles.None;
      label12.AutoSize = true;
      label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label12.Location = new System.Drawing.Point(328, 7);
      label12.Name = "label12";
      label12.Size = new System.Drawing.Size(19, 13);
      label12.TabIndex = 0;
      label12.Text = ".B";
      // 
      // label13
      // 
      label13.Anchor = System.Windows.Forms.AnchorStyles.None;
      label13.AutoSize = true;
      label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label13.Location = new System.Drawing.Point(355, 7);
      label13.Name = "label13";
      label13.Size = new System.Drawing.Size(19, 13);
      label13.TabIndex = 0;
      label13.Text = ".C";
      // 
      // label14
      // 
      label14.Anchor = System.Windows.Forms.AnchorStyles.None;
      label14.AutoSize = true;
      label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label14.Location = new System.Drawing.Point(381, 7);
      label14.Name = "label14";
      label14.Size = new System.Drawing.Size(20, 13);
      label14.TabIndex = 0;
      label14.Text = ".D";
      // 
      // label15
      // 
      label15.Anchor = System.Windows.Forms.AnchorStyles.None;
      label15.AutoSize = true;
      label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label15.Location = new System.Drawing.Point(409, 7);
      label15.Name = "label15";
      label15.Size = new System.Drawing.Size(19, 13);
      label15.TabIndex = 0;
      label15.Text = ".E";
      // 
      // label16
      // 
      label16.Anchor = System.Windows.Forms.AnchorStyles.None;
      label16.AutoSize = true;
      label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label16.Location = new System.Drawing.Point(436, 7);
      label16.Name = "label16";
      label16.Size = new System.Drawing.Size(18, 13);
      label16.TabIndex = 0;
      label16.Text = ".F";
      // 
      // label17
      // 
      label17.Anchor = System.Windows.Forms.AnchorStyles.None;
      label17.AutoSize = true;
      label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label17.Location = new System.Drawing.Point(4, 35);
      label17.Name = "label17";
      label17.Size = new System.Drawing.Size(18, 13);
      label17.TabIndex = 0;
      label17.Text = "0.";
      // 
      // label18
      // 
      label18.Anchor = System.Windows.Forms.AnchorStyles.None;
      label18.AutoSize = true;
      label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label18.Location = new System.Drawing.Point(4, 63);
      label18.Name = "label18";
      label18.Size = new System.Drawing.Size(18, 13);
      label18.TabIndex = 0;
      label18.Text = "1.";
      // 
      // label19
      // 
      label19.Anchor = System.Windows.Forms.AnchorStyles.None;
      label19.AutoSize = true;
      label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label19.Location = new System.Drawing.Point(4, 91);
      label19.Name = "label19";
      label19.Size = new System.Drawing.Size(18, 13);
      label19.TabIndex = 0;
      label19.Text = "2.";
      // 
      // label20
      // 
      label20.Anchor = System.Windows.Forms.AnchorStyles.None;
      label20.AutoSize = true;
      label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label20.Location = new System.Drawing.Point(4, 119);
      label20.Name = "label20";
      label20.Size = new System.Drawing.Size(18, 13);
      label20.TabIndex = 0;
      label20.Text = "3.";
      // 
      // label21
      // 
      label21.Anchor = System.Windows.Forms.AnchorStyles.None;
      label21.AutoSize = true;
      label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label21.Location = new System.Drawing.Point(4, 147);
      label21.Name = "label21";
      label21.Size = new System.Drawing.Size(18, 13);
      label21.TabIndex = 0;
      label21.Text = "4.";
      // 
      // label22
      // 
      label22.Anchor = System.Windows.Forms.AnchorStyles.None;
      label22.AutoSize = true;
      label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label22.Location = new System.Drawing.Point(4, 175);
      label22.Name = "label22";
      label22.Size = new System.Drawing.Size(18, 13);
      label22.TabIndex = 0;
      label22.Text = "5.";
      // 
      // label23
      // 
      label23.Anchor = System.Windows.Forms.AnchorStyles.None;
      label23.AutoSize = true;
      label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label23.Location = new System.Drawing.Point(4, 203);
      label23.Name = "label23";
      label23.Size = new System.Drawing.Size(18, 13);
      label23.TabIndex = 0;
      label23.Text = "6.";
      // 
      // label24
      // 
      label24.Anchor = System.Windows.Forms.AnchorStyles.None;
      label24.AutoSize = true;
      label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label24.Location = new System.Drawing.Point(4, 231);
      label24.Name = "label24";
      label24.Size = new System.Drawing.Size(18, 13);
      label24.TabIndex = 0;
      label24.Text = "7.";
      // 
      // label25
      // 
      label25.Anchor = System.Windows.Forms.AnchorStyles.None;
      label25.AutoSize = true;
      label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label25.Location = new System.Drawing.Point(4, 259);
      label25.Name = "label25";
      label25.Size = new System.Drawing.Size(18, 13);
      label25.TabIndex = 0;
      label25.Text = "8.";
      // 
      // label26
      // 
      label26.Anchor = System.Windows.Forms.AnchorStyles.None;
      label26.AutoSize = true;
      label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label26.Location = new System.Drawing.Point(4, 287);
      label26.Name = "label26";
      label26.Size = new System.Drawing.Size(18, 13);
      label26.TabIndex = 0;
      label26.Text = "9.";
      // 
      // label27
      // 
      label27.Anchor = System.Windows.Forms.AnchorStyles.None;
      label27.AutoSize = true;
      label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label27.Location = new System.Drawing.Point(4, 315);
      label27.Name = "label27";
      label27.Size = new System.Drawing.Size(19, 13);
      label27.TabIndex = 0;
      label27.Text = "A.";
      // 
      // label28
      // 
      label28.Anchor = System.Windows.Forms.AnchorStyles.None;
      label28.AutoSize = true;
      label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label28.Location = new System.Drawing.Point(4, 343);
      label28.Name = "label28";
      label28.Size = new System.Drawing.Size(19, 13);
      label28.TabIndex = 0;
      label28.Text = "B.";
      // 
      // label29
      // 
      label29.Anchor = System.Windows.Forms.AnchorStyles.None;
      label29.AutoSize = true;
      label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label29.Location = new System.Drawing.Point(4, 371);
      label29.Name = "label29";
      label29.Size = new System.Drawing.Size(19, 13);
      label29.TabIndex = 0;
      label29.Text = "C.";
      // 
      // label30
      // 
      label30.Anchor = System.Windows.Forms.AnchorStyles.None;
      label30.AutoSize = true;
      label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label30.Location = new System.Drawing.Point(3, 399);
      label30.Name = "label30";
      label30.Size = new System.Drawing.Size(20, 13);
      label30.TabIndex = 0;
      label30.Text = "D.";
      // 
      // label31
      // 
      label31.Anchor = System.Windows.Forms.AnchorStyles.None;
      label31.AutoSize = true;
      label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label31.Location = new System.Drawing.Point(4, 427);
      label31.Name = "label31";
      label31.Size = new System.Drawing.Size(19, 13);
      label31.TabIndex = 0;
      label31.Text = "E.";
      // 
      // label32
      // 
      label32.Anchor = System.Windows.Forms.AnchorStyles.None;
      label32.AutoSize = true;
      label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label32.Location = new System.Drawing.Point(4, 455);
      label32.Name = "label32";
      label32.Size = new System.Drawing.Size(18, 13);
      label32.TabIndex = 0;
      label32.Text = "F.";
      // 
      // lCodepageName
      // 
      this.lCodepageName.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lCodepageName.AutoSize = true;
      this.lCodepageName.Location = new System.Drawing.Point(274, 40);
      this.lCodepageName.Margin = new System.Windows.Forms.Padding(8);
      this.lCodepageName.Name = "lCodepageName";
      this.lCodepageName.Size = new System.Drawing.Size(35, 13);
      this.lCodepageName.TabIndex = 2;
      this.lCodepageName.Text = "Name";
      // 
      // btBack
      // 
      this.btBack.AutoSize = true;
      this.btBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.btBack.Image = global::CodepageSelector.Properties.Resources.AutoRewind;
      this.btBack.Location = new System.Drawing.Point(3, 3);
      this.btBack.Name = "btBack";
      this.btBack.Size = new System.Drawing.Size(26, 26);
      this.btBack.TabIndex = 0;
      this.btBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.ttHelp.SetToolTip(this.btBack, "Backward");
      this.btBack.UseVisualStyleBackColor = true;
      this.btBack.Click += new System.EventHandler(this.btBack_Click);
      // 
      // lCodepageError
      // 
      this.lCodepageError.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lCodepageError.Image = global::CodepageSelector.Properties.Resources.Error;
      this.lCodepageError.Location = new System.Drawing.Point(94, 4);
      this.lCodepageError.Name = "lCodepageError";
      this.lCodepageError.Size = new System.Drawing.Size(23, 23);
      this.lCodepageError.TabIndex = 2;
      this.ttHelp.SetToolTip(this.lCodepageError, "Codepage unsupported on this system");
      this.lCodepageError.Visible = false;
      // 
      // lCodepageSuccess
      // 
      this.lCodepageSuccess.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lCodepageSuccess.Image = global::CodepageSelector.Properties.Resources.Success;
      this.lCodepageSuccess.Location = new System.Drawing.Point(123, 4);
      this.lCodepageSuccess.Name = "lCodepageSuccess";
      this.lCodepageSuccess.Size = new System.Drawing.Size(23, 23);
      this.lCodepageSuccess.TabIndex = 3;
      this.ttHelp.SetToolTip(this.lCodepageSuccess, "Codepage loaded");
      this.lCodepageSuccess.Visible = false;
      // 
      // btForward
      // 
      this.btForward.AutoSize = true;
      this.btForward.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.btForward.Image = global::CodepageSelector.Properties.Resources.AutoForward;
      this.btForward.Location = new System.Drawing.Point(181, 3);
      this.btForward.Name = "btForward";
      this.btForward.Size = new System.Drawing.Size(26, 26);
      this.btForward.TabIndex = 2;
      this.btForward.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
      this.ttHelp.SetToolTip(this.btForward, "Forward");
      this.btForward.UseVisualStyleBackColor = true;
      this.btForward.Click += new System.EventHandler(this.btForward_Click);
      // 
      // lCodepageLoading
      // 
      this.lCodepageLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lCodepageLoading.Image = global::CodepageSelector.Properties.Resources._16x11_Loading_Animation;
      this.lCodepageLoading.Location = new System.Drawing.Point(152, 4);
      this.lCodepageLoading.Name = "lCodepageLoading";
      this.lCodepageLoading.Size = new System.Drawing.Size(23, 23);
      this.lCodepageLoading.TabIndex = 4;
      this.ttHelp.SetToolTip(this.lCodepageLoading, "Codepage loading...");
      this.lCodepageLoading.Visible = false;
      // 
      // bError
      // 
      this.bError.AutoSize = true;
      this.bError.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.bError.ForeColor = System.Drawing.Color.White;
      this.bError.Location = new System.Drawing.Point(3, 3);
      this.bError.Name = "bError";
      this.bError.Size = new System.Drawing.Size(39, 23);
      this.bError.TabIndex = 0;
      this.bError.Text = "Error";
      this.bError.UseVisualStyleBackColor = true;
      this.bError.Click += new System.EventHandler(this.bError_Click);
      // 
      // bWhiteSpace
      // 
      this.bWhiteSpace.AutoSize = true;
      this.bWhiteSpace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.bWhiteSpace.Location = new System.Drawing.Point(442, 3);
      this.bWhiteSpace.Name = "bWhiteSpace";
      this.bWhiteSpace.Size = new System.Drawing.Size(76, 23);
      this.bWhiteSpace.TabIndex = 0;
      this.bWhiteSpace.Text = "WhiteSpace";
      this.bWhiteSpace.UseVisualStyleBackColor = true;
      this.bWhiteSpace.Click += new System.EventHandler(this.bWhiteSpace_Click);
      // 
      // bControl
      // 
      this.bControl.AutoSize = true;
      this.bControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.bControl.Location = new System.Drawing.Point(48, 3);
      this.bControl.Name = "bControl";
      this.bControl.Size = new System.Drawing.Size(50, 23);
      this.bControl.TabIndex = 0;
      this.bControl.Text = "Control";
      this.bControl.UseVisualStyleBackColor = true;
      this.bControl.Click += new System.EventHandler(this.bControl_Click);
      // 
      // bPunctuation
      // 
      this.bPunctuation.AutoSize = true;
      this.bPunctuation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.bPunctuation.Location = new System.Drawing.Point(104, 3);
      this.bPunctuation.Name = "bPunctuation";
      this.bPunctuation.Size = new System.Drawing.Size(74, 23);
      this.bPunctuation.TabIndex = 0;
      this.bPunctuation.Text = "Punctuation";
      this.bPunctuation.UseVisualStyleBackColor = true;
      this.bPunctuation.Click += new System.EventHandler(this.bPunctuation_Click);
      // 
      // bLower
      // 
      this.bLower.AutoSize = true;
      this.bLower.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.bLower.Location = new System.Drawing.Point(184, 3);
      this.bLower.Name = "bLower";
      this.bLower.Size = new System.Drawing.Size(46, 23);
      this.bLower.TabIndex = 0;
      this.bLower.Text = "Lower";
      this.bLower.UseVisualStyleBackColor = true;
      this.bLower.Click += new System.EventHandler(this.bLower_Click);
      // 
      // bUpper
      // 
      this.bUpper.AutoSize = true;
      this.bUpper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.bUpper.Location = new System.Drawing.Point(236, 3);
      this.bUpper.Name = "bUpper";
      this.bUpper.Size = new System.Drawing.Size(46, 23);
      this.bUpper.TabIndex = 0;
      this.bUpper.Text = "Upper";
      this.bUpper.UseVisualStyleBackColor = true;
      this.bUpper.Click += new System.EventHandler(this.bUpper_Click);
      // 
      // bLetter
      // 
      this.bLetter.AutoSize = true;
      this.bLetter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.bLetter.Location = new System.Drawing.Point(288, 3);
      this.bLetter.Name = "bLetter";
      this.bLetter.Size = new System.Drawing.Size(44, 23);
      this.bLetter.TabIndex = 0;
      this.bLetter.Text = "Letter";
      this.bLetter.UseVisualStyleBackColor = true;
      this.bLetter.Click += new System.EventHandler(this.bLetter_Click);
      // 
      // bDigit
      // 
      this.bDigit.AutoSize = true;
      this.bDigit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.bDigit.Location = new System.Drawing.Point(338, 3);
      this.bDigit.Name = "bDigit";
      this.bDigit.Size = new System.Drawing.Size(38, 23);
      this.bDigit.TabIndex = 0;
      this.bDigit.Text = "Digit";
      this.bDigit.UseVisualStyleBackColor = true;
      this.bDigit.Click += new System.EventHandler(this.bDigit_Click);
      // 
      // bNumber
      // 
      this.bNumber.AutoSize = true;
      this.bNumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.bNumber.Location = new System.Drawing.Point(382, 3);
      this.bNumber.Name = "bNumber";
      this.bNumber.Size = new System.Drawing.Size(54, 23);
      this.bNumber.TabIndex = 0;
      this.bNumber.Text = "Number";
      this.bNumber.UseVisualStyleBackColor = true;
      this.bNumber.Click += new System.EventHandler(this.bNumber_Click);
      // 
      // bOther
      // 
      this.bOther.AutoSize = true;
      this.bOther.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.bOther.Location = new System.Drawing.Point(524, 3);
      this.bOther.Name = "bOther";
      this.bOther.Size = new System.Drawing.Size(43, 23);
      this.bOther.TabIndex = 0;
      this.bOther.Text = "Other";
      this.bOther.UseVisualStyleBackColor = true;
      this.bOther.Click += new System.EventHandler(this.bOther_Click);
      // 
      // flowLayoutPanel2
      // 
      flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
      flowLayoutPanel2.AutoSize = true;
      flowLayoutPanel2.Controls.Add(this.bError);
      flowLayoutPanel2.Controls.Add(this.bControl);
      flowLayoutPanel2.Controls.Add(this.bPunctuation);
      flowLayoutPanel2.Controls.Add(this.bLower);
      flowLayoutPanel2.Controls.Add(this.bUpper);
      flowLayoutPanel2.Controls.Add(this.bLetter);
      flowLayoutPanel2.Controls.Add(this.bDigit);
      flowLayoutPanel2.Controls.Add(this.bNumber);
      flowLayoutPanel2.Controls.Add(this.bWhiteSpace);
      flowLayoutPanel2.Controls.Add(this.bOther);
      flowLayoutPanel2.Location = new System.Drawing.Point(7, 61);
      flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      flowLayoutPanel2.Name = "flowLayoutPanel2";
      flowLayoutPanel2.Size = new System.Drawing.Size(570, 29);
      flowLayoutPanel2.TabIndex = 4;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(584, 587);
      this.Controls.Add(tableLayoutPanel1);
      this.Name = "MainForm";
      this.Text = "CodepageSelector";
      flowLayoutPanel1.ResumeLayout(false);
      flowLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudCurrentPage)).EndInit();
      tableLayoutPanel1.ResumeLayout(false);
      tableLayoutPanel1.PerformLayout();
      this.tlpCharacters.ResumeLayout(false);
      this.tlpCharacters.PerformLayout();
      flowLayoutPanel2.ResumeLayout(false);
      flowLayoutPanel2.PerformLayout();
      this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btBack;
  private System.Windows.Forms.NumericUpDown nudCurrentPage;
  private System.Windows.Forms.Button btForward;
  private System.Windows.Forms.TableLayoutPanel tlpCharacters;
  private System.Windows.Forms.Label lCodepageName;
  private System.Windows.Forms.ToolTip ttHelp;
  private System.Windows.Forms.Label lCodepageError;
  private System.Windows.Forms.Label lCodepageSuccess;
  private System.Windows.Forms.Label lCodepageLoading;
  private System.Windows.Forms.Button bError;
  private System.Windows.Forms.Button bControl;
  private System.Windows.Forms.Button bPunctuation;
  private System.Windows.Forms.Button bLower;
  private System.Windows.Forms.Button bUpper;
  private System.Windows.Forms.Button bLetter;
  private System.Windows.Forms.Button bDigit;
  private System.Windows.Forms.Button bNumber;
  private System.Windows.Forms.Button bWhiteSpace;
  private System.Windows.Forms.Button bOther;
}
