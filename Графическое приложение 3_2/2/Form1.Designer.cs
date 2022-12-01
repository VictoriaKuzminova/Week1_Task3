
namespace _2
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
            this.label3 = new System.Windows.Forms.Label();
            this.start_TextBox = new System.Windows.Forms.TextBox();
            this.finish_TextBox = new System.Windows.Forms.TextBox();
            this.H_TextBox = new System.Windows.Forms.TextBox();
            this.res_Button = new System.Windows.Forms.Button();
            this.res_TextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начальная точка диапазона: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(43, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Конечная точка диапазона: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(43, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Шаг: ";
            // 
            // start_TextBox
            // 
            this.start_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_TextBox.Location = new System.Drawing.Point(357, 42);
            this.start_TextBox.Name = "start_TextBox";
            this.start_TextBox.Size = new System.Drawing.Size(156, 30);
            this.start_TextBox.TabIndex = 3;
            // 
            // finish_TextBox
            // 
            this.finish_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finish_TextBox.Location = new System.Drawing.Point(357, 102);
            this.finish_TextBox.Name = "finish_TextBox";
            this.finish_TextBox.Size = new System.Drawing.Size(156, 30);
            this.finish_TextBox.TabIndex = 4;
            // 
            // H_TextBox
            // 
            this.H_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.H_TextBox.Location = new System.Drawing.Point(121, 160);
            this.H_TextBox.Name = "H_TextBox";
            this.H_TextBox.Size = new System.Drawing.Size(156, 30);
            this.H_TextBox.TabIndex = 5;
            // 
            // res_Button
            // 
            this.res_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res_Button.Location = new System.Drawing.Point(341, 151);
            this.res_Button.Name = "res_Button";
            this.res_Button.Size = new System.Drawing.Size(172, 39);
            this.res_Button.TabIndex = 6;
            this.res_Button.Text = "Вывести";
            this.res_Button.UseVisualStyleBackColor = true;
            this.res_Button.Click += new System.EventHandler(this.res_Button_Click);
            // 
            // res_TextBox
            // 
            this.res_TextBox.Location = new System.Drawing.Point(48, 205);
            this.res_TextBox.Name = "res_TextBox";
            this.res_TextBox.Size = new System.Drawing.Size(465, 221);
            this.res_TextBox.TabIndex = 7;
            this.res_TextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.res_TextBox);
            this.Controls.Add(this.res_Button);
            this.Controls.Add(this.H_TextBox);
            this.Controls.Add(this.finish_TextBox);
            this.Controls.Add(this.start_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Таблица значений";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox start_TextBox;
        private System.Windows.Forms.TextBox finish_TextBox;
        private System.Windows.Forms.TextBox H_TextBox;
        private System.Windows.Forms.Button res_Button;
        private System.Windows.Forms.RichTextBox res_TextBox;
    }
}

