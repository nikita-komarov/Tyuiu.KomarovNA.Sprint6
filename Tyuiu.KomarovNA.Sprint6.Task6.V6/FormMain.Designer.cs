namespace Tyuiu.KomarovNA.Sprint6.Task6.V6;
            
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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
        groupBox1 = new GroupBox();
        label1 = new Label();
        groupBoxOutPutData = new GroupBox();
        textBoxInput = new TextBox();
        groupBox3 = new GroupBox();
        textBoxPrint = new TextBox();
        buttonHelp = new Button();
        buttonRun = new Button();
        buttonOpenFile = new Button();
        openFileDialogTask = new OpenFileDialog();
        toolTip = new ToolTip(components);
        groupBox1.SuspendLayout();
        groupBoxOutPutData.SuspendLayout();
        groupBox3.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(12, 87);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(1053, 74);
        groupBox1.TabIndex = 6;
        groupBox1.TabStop = false;
        groupBox1.Text = "Условие";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 10F);
        label1.Location = new Point(6, 14);
        label1.Name = "label1";
        label1.Size = new Size(844, 57);
        label1.TabIndex = 0;
        label1.Text = resources.GetString("label1.Text");
        // 
        // groupBoxOutPutData
        // 
        groupBoxOutPutData.Controls.Add(textBoxInput);
        groupBoxOutPutData.Location = new Point(12, 161);
        groupBoxOutPutData.Name = "groupBoxOutPutData";
        groupBoxOutPutData.Size = new Size(452, 420);
        groupBoxOutPutData.TabIndex = 7;
        groupBoxOutPutData.TabStop = false;
        groupBoxOutPutData.Text = "Ввод";
        // 
        // textBoxInput
        // 
        textBoxInput.Location = new Point(33, 62);
        textBoxInput.Multiline = true;
        textBoxInput.Name = "textBoxInput";
        textBoxInput.ScrollBars = ScrollBars.Vertical;
        textBoxInput.Size = new Size(419, 349);
        textBoxInput.TabIndex = 0;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(textBoxPrint);
        groupBox3.Location = new Point(470, 161);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(595, 420);
        groupBox3.TabIndex = 8;
        groupBox3.TabStop = false;
        groupBox3.Text = "Вывод";
        // 
        // textBoxPrint
        // 
        textBoxPrint.Location = new Point(33, 62);
        textBoxPrint.Multiline = true;
        textBoxPrint.Name = "textBoxPrint";
        textBoxPrint.ScrollBars = ScrollBars.Vertical;
        textBoxPrint.Size = new Size(562, 349);
        textBoxPrint.TabIndex = 1;
        // 
        // buttonHelp
        // 
        buttonHelp.Image = Properties.Resources.curriculum_vitae_paper_document_icon_219537;
        buttonHelp.Location = new Point(954, 12);
        buttonHelp.Name = "buttonHelp";
        buttonHelp.Size = new Size(111, 69);
        buttonHelp.TabIndex = 11;
        toolTip.SetToolTip(buttonHelp, "Информация о создателе приложения");
        buttonHelp.UseVisualStyleBackColor = true;
        // 
        // buttonRun
        // 
        buttonRun.Enabled = false;
        buttonRun.Image = Properties.Resources.clipboard_paper_file_correct_done_list_document_icon_219518;
        buttonRun.Location = new Point(123, 12);
        buttonRun.Name = "buttonRun";
        buttonRun.Size = new Size(111, 69);
        buttonRun.TabIndex = 10;
        toolTip.SetToolTip(buttonRun, "Запустить программу");
        buttonRun.UseVisualStyleBackColor = true;
        // 
        // buttonOpenFile
        // 
        buttonOpenFile.Image = Properties.Resources.download_folder_file_icon_219533;
        buttonOpenFile.Location = new Point(12, 12);
        buttonOpenFile.Name = "buttonOpenFile";
        buttonOpenFile.Size = new Size(105, 69);
        buttonOpenFile.TabIndex = 9;
        toolTip.SetToolTip(buttonOpenFile, "Открыть файл\r\nВыберите нужный файл для обработки");
        buttonOpenFile.UseVisualStyleBackColor = true;
        buttonOpenFile.Click += buttonOpenFile_Click;
        // 
        // toolTip
        // 
        toolTip.ToolTipIcon = ToolTipIcon.Info;
        toolTip.ToolTipTitle = "Подсказка";
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1077, 584);
        Controls.Add(groupBox1);
        Controls.Add(groupBoxOutPutData);
        Controls.Add(groupBox3);
        Controls.Add(buttonHelp);
        Controls.Add(buttonRun);
        Controls.Add(buttonOpenFile);
        Name = "FormMain";
        Text = "Form1";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBoxOutPutData.ResumeLayout(false);
        groupBoxOutPutData.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private Label label1;
    private GroupBox groupBoxOutPutData;
    private TextBox textBoxInput;
    private GroupBox groupBox3;
    private TextBox textBoxPrint;
    private Button buttonHelp;
    private ToolTip toolTip;
    private Button buttonRun;
    private Button buttonOpenFile;
    private OpenFileDialog openFileDialogTask;
}