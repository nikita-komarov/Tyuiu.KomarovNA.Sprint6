namespace Tyuiu.KomarovNA.Sprint6.Task0.V26;
            
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
        groupBox1 = new GroupBox();
        label1 = new Label();
        pictureBox1 = new PictureBox();
        groupBox2 = new GroupBox();
        label2 = new Label();
        x_input = new TextBox();
        groupBox3 = new GroupBox();
        label3 = new Label();
        ResultBox = new TextBox();
        ButtonSubmit = new Button();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(pictureBox1);
        groupBox1.Location = new Point(12, 24);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(776, 270);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Условие";
        groupBox1.Enter += groupBox1_Enter;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(6, 36);
        label1.Name = "label1";
        label1.Size = new Size(455, 45);
        label1.TabIndex = 0;
        label1.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox.\r\nОкруглить до трёх знаков после запятой.\r\nГрафический интерфейс оформить по шаблону из лекции.\r\n";
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(192, 84);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(422, 186);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        pictureBox1.Click += pictureBox1_Click;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(x_input);
        groupBox2.Location = new Point(12, 300);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(461, 95);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Ввод данных";
        groupBox2.Enter += groupBox2_Enter;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(16, 33);
        label2.Name = "label2";
        label2.Size = new Size(89, 15);
        label2.TabIndex = 1;
        label2.Text = "Переменная X:";
        // 
        // x_input
        // 
        x_input.Location = new Point(15, 51);
        x_input.Name = "x_input";
        x_input.Size = new Size(100, 23);
        x_input.TabIndex = 0;
        x_input.TextChanged += textBox1_TextChanged;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(label3);
        groupBox3.Controls.Add(ResultBox);
        groupBox3.Location = new Point(485, 300);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(303, 95);
        groupBox3.TabIndex = 2;
        groupBox3.TabStop = false;
        groupBox3.Text = "Вывод данных";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(16, 33);
        label3.Name = "label3";
        label3.Size = new Size(63, 15);
        label3.TabIndex = 3;
        label3.Text = "Результат:";
        // 
        // ResultBox
        // 
        ResultBox.Location = new Point(16, 51);
        ResultBox.Name = "ResultBox";
        ResultBox.Size = new Size(274, 23);
        ResultBox.TabIndex = 2;
        ResultBox.TextChanged += textBox2_TextChanged;
        // 
        // ButtonSubmit
        // 
        ButtonSubmit.AccessibleName = "";
        ButtonSubmit.Location = new Point(666, 401);
        ButtonSubmit.Name = "ButtonSubmit";
        ButtonSubmit.Size = new Size(108, 37);
        ButtonSubmit.TabIndex = 3;
        ButtonSubmit.Text = "Выполнить";
        ButtonSubmit.UseVisualStyleBackColor = true;
        ButtonSubmit.Click += ButtonSubmit_Click;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(ButtonSubmit);
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Name = "FormMain";
        Text = "Спринт 6 | Таск 0 | Вариант 0 | Комаров Н. А.";
        Load += FormMain_Load_1;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private Label label1;
    private PictureBox pictureBox1;
    private GroupBox groupBox2;
    private GroupBox groupBox3;
    private Label label2;
    private TextBox x_input;
    private Label label3;
    private TextBox ResultBox;
    private Button ButtonSubmit;
}