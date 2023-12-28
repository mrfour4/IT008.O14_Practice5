namespace practice_5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnCalcSum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDoSomthing = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateFile.Location = new System.Drawing.Point(119, 195);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(147, 81);
            this.btnCreateFile.TabIndex = 0;
            this.btnCreateFile.Text = "Tạo file";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnCalcSum
            // 
            this.btnCalcSum.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcSum.Location = new System.Drawing.Point(510, 195);
            this.btnCalcSum.Name = "btnCalcSum";
            this.btnCalcSum.Size = new System.Drawing.Size(140, 78);
            this.btnCalcSum.TabIndex = 1;
            this.btnCalcSum.Text = "Đọc file và tính tổng";
            this.btnCalcSum.UseVisualStyleBackColor = true;
            this.btnCalcSum.Click += new System.EventHandler(this.btnCalcSum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.label1.Location = new System.Drawing.Point(199, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng = ";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.txtResult.Location = new System.Drawing.Point(307, 344);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(256, 39);
            this.txtResult.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(625, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đọc file và tính tổng với Multi Thread";
            // 
            // btnDoSomthing
            // 
            this.btnDoSomthing.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoSomthing.Location = new System.Drawing.Point(307, 484);
            this.btnDoSomthing.Name = "btnDoSomthing";
            this.btnDoSomthing.Size = new System.Drawing.Size(167, 56);
            this.btnDoSomthing.TabIndex = 5;
            this.btnDoSomthing.Text = "Đổi màu nền";
            this.btnDoSomthing.UseVisualStyleBackColor = true;
            this.btnDoSomthing.Click += new System.EventHandler(this.btnDoSomthing_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(163, 406);
            this.label3.MaximumSize = new System.Drawing.Size(500, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10);
            this.label3.Size = new System.Drawing.Size(496, 64);
            this.label3.TabIndex = 6;
            this.label3.Text = "Khi dùng multi thread, ta có thể làm việc khác khi đang tính tổng, ví dụ đổi màu " +
    "nền...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDoSomthing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcSum);
            this.Controls.Add(this.btnCreateFile);
            this.Name = "Form1";
            this.Text = "Multi Thread";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnCalcSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDoSomthing;
        private System.Windows.Forms.Label label3;
    }
}

