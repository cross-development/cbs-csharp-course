﻿namespace HW_8_Task_4;

partial class Form1
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
        radioButton1 = new RadioButton();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        textBox3 = new TextBox();
        radioButton2 = new RadioButton();
        radioButton3 = new RadioButton();
        radioButton4 = new RadioButton();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        button1 = new Button();
        SuspendLayout();
        // 
        // radioButton1
        // 
        radioButton1.AutoSize = true;
        radioButton1.Location = new Point(132, 188);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new Size(182, 29);
        radioButton1.TabIndex = 0;
        radioButton1.TabStop = true;
        radioButton1.Text = "Modulo operation";
        radioButton1.UseVisualStyleBackColor = true;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(112, 116);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(150, 31);
        textBox1.TabIndex = 1;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(311, 116);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(150, 31);
        textBox2.TabIndex = 2;
        // 
        // textBox3
        // 
        textBox3.Location = new Point(498, 116);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(150, 31);
        textBox3.TabIndex = 3;
        // 
        // radioButton2
        // 
        radioButton2.AutoSize = true;
        radioButton2.Location = new Point(448, 188);
        radioButton2.Name = "radioButton2";
        radioButton2.Size = new Size(167, 29);
        radioButton2.TabIndex = 4;
        radioButton2.TabStop = true;
        radioButton2.Text = "Power operation";
        radioButton2.UseVisualStyleBackColor = true;
        // 
        // radioButton3
        // 
        radioButton3.AutoSize = true;
        radioButton3.Location = new Point(132, 260);
        radioButton3.Name = "radioButton3";
        radioButton3.Size = new Size(233, 29);
        radioButton3.TabIndex = 5;
        radioButton3.TabStop = true;
        radioButton3.Text = "Concatenation operation";
        radioButton3.UseVisualStyleBackColor = true;
        // 
        // radioButton4
        // 
        radioButton4.AutoSize = true;
        radioButton4.Location = new Point(448, 260);
        radioButton4.Name = "radioButton4";
        radioButton4.Size = new Size(182, 29);
        radioButton4.TabIndex = 6;
        radioButton4.TabStop = true;
        radioButton4.Text = "Division operation";
        radioButton4.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(112, 88);
        label1.Name = "label1";
        label1.Size = new Size(69, 25);
        label1.TabIndex = 7;
        label1.Text = "Input 1";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(311, 88);
        label2.Name = "label2";
        label2.Size = new Size(69, 25);
        label2.TabIndex = 8;
        label2.Text = "Input 2";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(498, 88);
        label3.Name = "label3";
        label3.Size = new Size(59, 25);
        label3.TabIndex = 9;
        label3.Text = "Result";
        // 
        // button1
        // 
        button1.Location = new Point(331, 354);
        button1.Name = "button1";
        button1.Size = new Size(112, 34);
        button1.TabIndex = 10;
        button1.Text = "Calculate";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(button1);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(radioButton4);
        Controls.Add(radioButton3);
        Controls.Add(radioButton2);
        Controls.Add(textBox3);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(radioButton1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private RadioButton radioButton1;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private RadioButton radioButton2;
    private RadioButton radioButton3;
    private RadioButton radioButton4;
    private Label label1;
    private Label label2;
    private Label label3;
    private Button button1;
}
