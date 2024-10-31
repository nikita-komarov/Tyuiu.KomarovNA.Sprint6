namespace Tyuiu.KomarovNA.Sprint6.Task1.V12;
            
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
        groupBox3 = new GroupBox();
        resultBox = new TextBox();
        groupBox2 = new GroupBox();
        label1 = new Label();
        end_input = new TextBox();
        label2 = new Label();
        start_input = new TextBox();
        groupBox1 = new GroupBox();
        pictureBox1 = new PictureBox();
        doButton = new Button();
        FAQButton = new Button();
        groupBox3.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(resultBox);
        groupBox3.Location = new Point(545, 18);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(243, 420);
        groupBox3.TabIndex = 6;
        groupBox3.TabStop = false;
        groupBox3.Text = "Вывод данных";
        // 
        // resultBox
        // 
        resultBox.Location = new Point(6, 22);
        resultBox.Multiline = true;
        resultBox.Name = "resultBox";
        resultBox.RightToLeft = RightToLeft.No;
        resultBox.ScrollBars = ScrollBars.Vertical;
        resultBox.Size = new Size(231, 392);
        resultBox.TabIndex = 0;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(label1);
        groupBox2.Controls.Add(end_input);
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(start_input);
        groupBox2.Location = new Point(12, 343);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(243, 95);
        groupBox2.TabIndex = 5;
        groupBox2.TabStop = false;
        groupBox2.Text = "Ввод данных";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(130, 33);
        label1.Name = "label1";
        label1.Size = new Size(75, 15);
        label1.TabIndex = 3;
        label1.Text = "Конец шага:";
        // 
        // end_input
        // 
        end_input.Location = new Point(129, 51);
        end_input.Name = "end_input";
        end_input.Size = new Size(100, 23);
        end_input.TabIndex = 2;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(16, 33);
        label2.Name = "label2";
        label2.Size = new Size(72, 15);
        label2.TabIndex = 1;
        label2.Text = "Старт шага:";
        label2.Click += label2_Click;
        // 
        // start_input
        // 
        start_input.Location = new Point(15, 51);
        start_input.Name = "start_input";
        start_input.Size = new Size(100, 23);
        start_input.TabIndex = 0;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(pictureBox1);
        groupBox1.Location = new Point(12, 18);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(527, 319);
        groupBox1.TabIndex = 4;
        groupBox1.TabStop = false;
        groupBox1.Text = "Условие";
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(6, 22);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(509, 200);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        // 
        // doButton
        // 
        doButton.BackColor = Color.CornflowerBlue;
        doButton.FlatStyle = FlatStyle.Flat;
        doButton.Location = new Point(389, 394);
        doButton.Name = "doButton";
        doButton.Size = new Size(138, 44);
        doButton.TabIndex = 8;
        doButton.Text = "Выполнить";
        doButton.UseVisualStyleBackColor = false;
        doButton.Click += doButton_Click;
        // 
        // FAQButton
        // 
        FAQButton.BackColor = Color.Gold;
        FAQButton.FlatStyle = FlatStyle.Flat;
        FAQButton.Location = new Point(319, 394);
        FAQButton.Name = "FAQButton";
        FAQButton.Size = new Size(64, 44);
        FAQButton.TabIndex = 9;
        FAQButton.Text = "Справка";
        FAQButton.UseVisualStyleBackColor = false;
        FAQButton.Click += FAQButton_Click;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(FAQButton);
        Controls.Add(doButton);
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Name = "FormMain";
        Text = "Form1";
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private GroupBox groupBox3;
    private GroupBox groupBox2;
    private Label label2;
    private TextBox start_input;
    private GroupBox groupBox1;
    private PictureBox pictureBox1;
    private Label label1;
    private TextBox end_input;
    private Button doButton;
    private Button FAQButton;
    private TextBox resultBox;
}