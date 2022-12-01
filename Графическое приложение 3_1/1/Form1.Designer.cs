
namespace _1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.A_textBox = new System.Windows.Forms.TextBox();
            this.B_textBox = new System.Windows.Forms.TextBox();
            this.c_textBox = new System.Windows.Forms.TextBox();
            this.res_Button = new System.Windows.Forms.Button();
            this.res_TextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите a: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите b: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(40, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Введите c: ";
            // 
            // A_textBox
            // 
            this.A_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A_textBox.Location = new System.Drawing.Point(176, 38);
            this.A_textBox.Name = "A_textBox";
            this.A_textBox.Size = new System.Drawing.Size(169, 30);
            this.A_textBox.TabIndex = 4;
            // 
            // B_textBox
            // 
            this.B_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_textBox.Location = new System.Drawing.Point(176, 99);
            this.B_textBox.Name = "B_textBox";
            this.B_textBox.Size = new System.Drawing.Size(169, 30);
            this.B_textBox.TabIndex = 5;
            // 
            // c_textBox
            // 
            this.c_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c_textBox.Location = new System.Drawing.Point(176, 158);
            this.c_textBox.Name = "c_textBox";
            this.c_textBox.Size = new System.Drawing.Size(169, 30);
            this.c_textBox.TabIndex = 6;
            // 
            // res_Button
            // 
            this.res_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res_Button.Location = new System.Drawing.Point(400, 89);
            this.res_Button.Name = "res_Button";
            this.res_Button.Size = new System.Drawing.Size(138, 51);
            this.res_Button.TabIndex = 7;
            this.res_Button.Text = "Вычислить";
            this.res_Button.UseVisualStyleBackColor = true;
            this.res_Button.Click += new System.EventHandler(this.res_Button_Click);
            // 
            // res_TextBox
            // 
            this.res_TextBox.Location = new System.Drawing.Point(45, 217);
            this.res_TextBox.Name = "res_TextBox";
            this.res_TextBox.Size = new System.Drawing.Size(493, 96);
            this.res_TextBox.TabIndex = 8;
            this.res_TextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 362);
            this.Controls.Add(this.res_TextBox);
            this.Controls.Add(this.res_Button);
            this.Controls.Add(this.c_textBox);
            this.Controls.Add(this.B_textBox);
            this.Controls.Add(this.A_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Простейшая задача";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox A_textBox;
        private System.Windows.Forms.TextBox B_textBox;
        private System.Windows.Forms.TextBox c_textBox;
        private System.Windows.Forms.Button res_Button;
        private System.Windows.Forms.RichTextBox res_TextBox;
    }
}

