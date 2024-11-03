namespace Tyuiu.KomarovNA.Sprint6.Task3.V15;
            
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
        groupBox3 = new GroupBox();
        resultBox = new DataGridView();
        Column1 = new DataGridViewTextBoxColumn();
        groupBox1 = new GroupBox();
        label3 = new Label();
        FAQButton = new Button();
        doButton = new Button();
        groupBox4 = new GroupBox();
        inputGrid = new DataGridView();
        first = new DataGridViewTextBoxColumn();
        second = new DataGridViewTextBoxColumn();
        Column2 = new DataGridViewTextBoxColumn();
        Column3 = new DataGridViewTextBoxColumn();
        Column4 = new DataGridViewTextBoxColumn();
        groupBox3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)resultBox).BeginInit();
        groupBox1.SuspendLayout();
        groupBox4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)inputGrid).BeginInit();
        SuspendLayout();
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(resultBox);
        groupBox3.Location = new Point(545, 15);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(243, 420);
        groupBox3.TabIndex = 17;
        groupBox3.TabStop = false;
        groupBox3.Text = "Вывод данных";
        // 
        // resultBox
        // 
        resultBox.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        resultBox.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        resultBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        resultBox.ColumnHeadersVisible = false;
        resultBox.Columns.AddRange(new DataGridViewColumn[] { Column1 });
        resultBox.Location = new Point(6, 22);
        resultBox.Name = "resultBox";
        resultBox.RowHeadersVisible = false;
        resultBox.Size = new Size(231, 392);
        resultBox.TabIndex = 15;
        // 
        // Column1
        // 
        Column1.HeaderText = "F(X)";
        Column1.Name = "Column1";
        Column1.Width = 21;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label3);
        groupBox1.Location = new Point(12, 15);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(350, 319);
        groupBox1.TabIndex = 15;
        groupBox1.TabStop = false;
        groupBox1.Text = "Условие";
        groupBox1.Enter += groupBox1_Enter;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(14, 34);
        label3.Name = "label3";
        label3.Size = new Size(336, 180);
        label3.TabIndex = 0;
        label3.Text = resources.GetString("label3.Text");
        // 
        // FAQButton
        // 
        FAQButton.BackColor = Color.Gold;
        FAQButton.FlatStyle = FlatStyle.Flat;
        FAQButton.Location = new Point(319, 391);
        FAQButton.Name = "FAQButton";
        FAQButton.Size = new Size(64, 44);
        FAQButton.TabIndex = 19;
        FAQButton.Text = "Справка";
        FAQButton.UseVisualStyleBackColor = false;
        FAQButton.Click += FAQButton_Click;
        // 
        // doButton
        // 
        doButton.BackColor = Color.CornflowerBlue;
        doButton.FlatStyle = FlatStyle.Flat;
        doButton.Location = new Point(389, 391);
        doButton.Name = "doButton";
        doButton.Size = new Size(138, 44);
        doButton.TabIndex = 18;
        doButton.Text = "Выполнить";
        doButton.UseVisualStyleBackColor = false;
        doButton.Click += doButton_Click;
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(inputGrid);
        groupBox4.Location = new Point(368, 15);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new Size(159, 319);
        groupBox4.TabIndex = 18;
        groupBox4.TabStop = false;
        groupBox4.Enter += groupBox4_Enter;
        // 
        // inputGrid
        // 
        inputGrid.AllowUserToAddRows = false;
        inputGrid.AllowUserToDeleteRows = false;
        inputGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        inputGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        inputGrid.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
        inputGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        inputGrid.ColumnHeadersVisible = false;
        inputGrid.Columns.AddRange(new DataGridViewColumn[] { first, second, Column2, Column3, Column4 });
        inputGrid.Location = new Point(6, 14);
        inputGrid.Name = "inputGrid";
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = SystemColors.Control;
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle1.Padding = new Padding(10);
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        inputGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
        inputGrid.RowHeadersVisible = false;
        inputGrid.RowHeadersWidth = 40;
        inputGrid.Size = new Size(153, 200);
        inputGrid.TabIndex = 15;
        inputGrid.CellContentClick += dataGridView1_CellContentClick;
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
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(groupBox4);
        Controls.Add(groupBox3);
        Controls.Add(groupBox1);
        Controls.Add(FAQButton);
        Controls.Add(doButton);
        Name = "FormMain";
        Text = "Form1";
        groupBox3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)resultBox).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox4.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)inputGrid).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox3;
    private DataGridView resultBox;
    private DataGridViewTextBoxColumn Column1;
    private GroupBox groupBox1;
    private Label label3;
    private Button FAQButton;
    private Button doButton;
    private GroupBox groupBox4;
    private DataGridView inputGrid;
    private DataGridViewTextBoxColumn first;
    private DataGridViewTextBoxColumn second;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column4;
}