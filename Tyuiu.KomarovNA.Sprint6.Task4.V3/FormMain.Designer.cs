namespace Tyuiu.KomarovNA.Sprint6.Task4.V3;
            
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
        pictureBox1 = new PictureBox();
        groupBox4 = new GroupBox();
        textBoxResult = new TextBox();
        FAQButton = new Button();
        doButton = new Button();
        buttonSave = new Button();
        groupBox2 = new GroupBox();
        label1 = new Label();
        end_input = new TextBox();
        label2 = new Label();
        start_input = new TextBox();
        backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        groupBox4.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(pictureBox1);
        groupBox1.Location = new Point(12, 15);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(388, 164);
        groupBox1.TabIndex = 20;
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
        groupBox4.Controls.Add(textBoxResult);
        groupBox4.Location = new Point(406, 15);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new Size(159, 199);
        groupBox4.TabIndex = 22;
        groupBox4.TabStop = false;
        groupBox4.Text = "Вывод";
        // 
        // textBoxResult
        // 
        textBoxResult.Location = new Point(6, 22);
        textBoxResult.Multiline = true;
        textBoxResult.Name = "textBoxResult";
        textBoxResult.ScrollBars = ScrollBars.Vertical;
        textBoxResult.Size = new Size(147, 171);
        textBoxResult.TabIndex = 0;
        // 
        // FAQButton
        // 
        FAQButton.BackColor = Color.Gold;
        FAQButton.FlatStyle = FlatStyle.Flat;
        FAQButton.Location = new Point(256, 268);
        FAQButton.Name = "FAQButton";
        FAQButton.Size = new Size(64, 44);
        FAQButton.TabIndex = 24;
        FAQButton.Text = "Справка";
        FAQButton.UseVisualStyleBackColor = false;
        FAQButton.Click += FAQButton_Click;
        // 
        // doButton
        // 
        doButton.BackColor = Color.CornflowerBlue;
        doButton.FlatStyle = FlatStyle.Flat;
        doButton.Location = new Point(177, 218);
        doButton.Name = "doButton";
        doButton.Size = new Size(138, 44);
        doButton.TabIndex = 23;
        doButton.Text = "Выполнить";
        doButton.UseVisualStyleBackColor = false;
        doButton.Click += doButton_Click;
        // 
        // buttonSave
        // 
        buttonSave.BackColor = Color.GreenYellow;
        buttonSave.FlatStyle = FlatStyle.Flat;
        buttonSave.Location = new Point(172, 268);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(78, 44);
        buttonSave.TabIndex = 25;
        buttonSave.Text = "Сохранить";
        buttonSave.UseVisualStyleBackColor = false;
        buttonSave.Click += buttonSaveClick;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(label1);
        groupBox2.Controls.Add(end_input);
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(start_input);
        groupBox2.Location = new Point(12, 185);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(145, 164);
        groupBox2.TabIndex = 26;
        groupBox2.TabStop = false;
        groupBox2.Text = "Ввод данных";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(16, 96);
        label1.Name = "label1";
        label1.Size = new Size(75, 15);
        label1.TabIndex = 3;
        label1.Text = "Конец шага:";
        // 
        // end_input
        // 
        end_input.Location = new Point(15, 114);
        end_input.Name = "end_input";
        end_input.Size = new Size(117, 23);
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
        // 
        // start_input
        // 
        start_input.Location = new Point(15, 51);
        start_input.Name = "start_input";
        start_input.Size = new Size(117, 23);
        start_input.TabIndex = 0;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(579, 425);
        Controls.Add(groupBox2);
        Controls.Add(buttonSave);
        Controls.Add(groupBox1);
        Controls.Add(groupBox4);
        Controls.Add(FAQButton);
        Controls.Add(doButton);
        Name = "FormMain";
        Text = "Form1";
        groupBox1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        groupBox4.ResumeLayout(false);
        groupBox4.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private GroupBox groupBox1;
    private GroupBox groupBox4;
    private Button FAQButton;
    private Button doButton;
    private PictureBox pictureBox1;
    private Button buttonSave;
    private GroupBox groupBox2;
    private Label label1;
    private TextBox end_input;
    private Label label2;
    private TextBox start_input;
    private TextBox textBoxResult;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
}