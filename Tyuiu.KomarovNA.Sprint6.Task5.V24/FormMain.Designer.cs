namespace Tyuiu.KomarovNA.Sprint6.Task5.V24;
            
partial class FormMain
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        groupBox1 = new GroupBox();
        pictureBox1 = new PictureBox();
        groupBox4 = new GroupBox();
        outputGrid = new DataGridView();
        first = new DataGridViewTextBoxColumn();
        second = new DataGridViewTextBoxColumn();
        Column2 = new DataGridViewTextBoxColumn();
        Column3 = new DataGridViewTextBoxColumn();
        Column4 = new DataGridViewTextBoxColumn();
        buttonSave = new Button();
        FAQButton = new Button();
        doButton = new Button();
        backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        groupBox4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)outputGrid).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(pictureBox1);
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(388, 164);
        groupBox1.TabIndex = 27;
        groupBox1.TabStop = false;
        groupBox1.Text = "Условие";
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(6, 22);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(376, 136);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(outputGrid);
        groupBox4.Location = new Point(406, 12);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new Size(159, 334);
        groupBox4.TabIndex = 28;
        groupBox4.TabStop = false;
        groupBox4.Text = "Вывод";
        // 
        // outputGrid
        // 
        outputGrid.AllowUserToAddRows = false;
        outputGrid.AllowUserToDeleteRows = false;
        outputGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        outputGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        outputGrid.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
        outputGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        outputGrid.ColumnHeadersVisible = false;
        outputGrid.Columns.AddRange(new DataGridViewColumn[] { first, second, Column2, Column3, Column4 });
        outputGrid.Location = new Point(6, 14);
        outputGrid.Name = "outputGrid";
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = SystemColors.Control;
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle1.Padding = new Padding(10);
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        outputGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
        outputGrid.RowHeadersVisible = false;
        outputGrid.RowHeadersWidth = 40;
        outputGrid.Size = new Size(153, 314);
        outputGrid.TabIndex = 16;
        // 
        // first
        // 
        first.HeaderText = "Column2";
        first.Name = "first";
        first.Width = 5;
        // 
        // second
        // 
        second.HeaderText = "Column2";
        second.Name = "second";
        second.Width = 5;
        // 
        // Column2
        // 
        Column2.HeaderText = "Column2";
        Column2.Name = "Column2";
        Column2.Width = 5;
        // 
        // Column3
        // 
        Column3.HeaderText = "Column3";
        Column3.Name = "Column3";
        Column3.Width = 5;
        // 
        // Column4
        // 
        Column4.HeaderText = "Column4";
        Column4.Name = "Column4";
        Column4.Width = 5;
        // 
        // buttonSave
        // 
        buttonSave.BackColor = Color.GreenYellow;
        buttonSave.FlatStyle = FlatStyle.Flat;
        buttonSave.Location = new Point(162, 182);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(78, 44);
        buttonSave.TabIndex = 31;
        buttonSave.Text = "Открыть файл";
        buttonSave.UseVisualStyleBackColor = false;
        buttonSave.Click += buttonSave_Click;
        // 
        // FAQButton
        // 
        FAQButton.BackColor = Color.Gold;
        FAQButton.FlatStyle = FlatStyle.Flat;
        FAQButton.Location = new Point(330, 300);
        FAQButton.Name = "FAQButton";
        FAQButton.Size = new Size(64, 44);
        FAQButton.TabIndex = 30;
        FAQButton.Text = "Справка";
        FAQButton.UseVisualStyleBackColor = false;
        FAQButton.Click += FAQButton_Click;
        // 
        // doButton
        // 
        doButton.BackColor = Color.CornflowerBlue;
        doButton.FlatStyle = FlatStyle.Flat;
        doButton.Location = new Point(18, 182);
        doButton.Name = "doButton";
        doButton.Size = new Size(138, 44);
        doButton.TabIndex = 29;
        doButton.Text = "Выполнить";
        doButton.UseVisualStyleBackColor = false;
        doButton.Click += doButton_Click;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(576, 356);
        Controls.Add(groupBox1);
        Controls.Add(groupBox4);
        Controls.Add(buttonSave);
        Controls.Add(FAQButton);
        Controls.Add(doButton);
        Name = "FormMain";
        Text = "Form1";
        groupBox1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        groupBox4.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)outputGrid).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private PictureBox pictureBox1;
    private GroupBox groupBox4;
    private Button buttonSave;
    private Button FAQButton;
    private Button doButton;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private DataGridView outputGrid;
    private DataGridViewTextBoxColumn first;
    private DataGridViewTextBoxColumn second;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column4;
}