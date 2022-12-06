
namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResultLabel = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SubBtn = new System.Windows.Forms.Button();
            this.MultBtn = new System.Windows.Forms.Button();
            this.DivBtn = new System.Windows.Forms.Button();
            this.EqualsBtn = new System.Windows.Forms.Button();
            this.number2Label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Num2Btn = new System.Windows.Forms.Button();
            this.Num3Btn = new System.Windows.Forms.Button();
            this.Num1Btn = new System.Windows.Forms.Button();
            this.Num4Btn = new System.Windows.Forms.Button();
            this.Num6Btn = new System.Windows.Forms.Button();
            this.Num5Btn = new System.Windows.Forms.Button();
            this.Num7Btn = new System.Windows.Forms.Button();
            this.Num9Btn = new System.Windows.Forms.Button();
            this.Num8Btn = new System.Windows.Forms.Button();
            this.Num0Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(12, 49);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(31, 33);
            this.ResultLabel.TabIndex = 3;
            this.ResultLabel.Text = "0";
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(248, 152);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(134, 69);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.TabStop = false;
            this.AddBtn.Text = "+";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            this.AddBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // SubBtn
            // 
            this.SubBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.SubBtn.Location = new System.Drawing.Point(248, 227);
            this.SubBtn.Name = "SubBtn";
            this.SubBtn.Size = new System.Drawing.Size(134, 69);
            this.SubBtn.TabIndex = 2;
            this.SubBtn.TabStop = false;
            this.SubBtn.Text = "-";
            this.SubBtn.UseVisualStyleBackColor = true;
            this.SubBtn.Click += new System.EventHandler(this.SubBtn_Click);
            this.SubBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // MultBtn
            // 
            this.MultBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.MultBtn.Location = new System.Drawing.Point(248, 302);
            this.MultBtn.Name = "MultBtn";
            this.MultBtn.Size = new System.Drawing.Size(134, 69);
            this.MultBtn.TabIndex = 3;
            this.MultBtn.TabStop = false;
            this.MultBtn.Text = "*";
            this.MultBtn.UseVisualStyleBackColor = true;
            this.MultBtn.Click += new System.EventHandler(this.MultBtn_Click);
            this.MultBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // DivBtn
            // 
            this.DivBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.DivBtn.Location = new System.Drawing.Point(248, 377);
            this.DivBtn.Name = "DivBtn";
            this.DivBtn.Size = new System.Drawing.Size(134, 69);
            this.DivBtn.TabIndex = 4;
            this.DivBtn.TabStop = false;
            this.DivBtn.Text = "/";
            this.DivBtn.UseVisualStyleBackColor = true;
            this.DivBtn.Click += new System.EventHandler(this.DivBtn_Click);
            this.DivBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // EqualsBtn
            // 
            this.EqualsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.EqualsBtn.Location = new System.Drawing.Point(248, 452);
            this.EqualsBtn.Name = "EqualsBtn";
            this.EqualsBtn.Size = new System.Drawing.Size(134, 69);
            this.EqualsBtn.TabIndex = 5;
            this.EqualsBtn.TabStop = false;
            this.EqualsBtn.Text = "=";
            this.EqualsBtn.UseVisualStyleBackColor = true;
            this.EqualsBtn.Click += new System.EventHandler(this.EqualsBtn_Click);
            this.EqualsBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            // 
            // number2Label
            // 
            this.number2Label.AutoSize = true;
            this.number2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number2Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.number2Label.Location = new System.Drawing.Point(64, 9);
            this.number2Label.Name = "number2Label";
            this.number2Label.Size = new System.Drawing.Size(0, 25);
            this.number2Label.TabIndex = 6;
            // 
            // Num2Btn
            // 
            this.Num2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Num2Btn.Location = new System.Drawing.Point(92, 152);
            this.Num2Btn.Name = "Num2Btn";
            this.Num2Btn.Size = new System.Drawing.Size(68, 69);
            this.Num2Btn.TabIndex = 7;
            this.Num2Btn.TabStop = false;
            this.Num2Btn.Text = "2";
            this.Num2Btn.UseVisualStyleBackColor = true;
            this.Num2Btn.Click += new System.EventHandler(this.Num2Btn_Click);
            // 
            // Num3Btn
            // 
            this.Num3Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Num3Btn.Location = new System.Drawing.Point(166, 152);
            this.Num3Btn.Name = "Num3Btn";
            this.Num3Btn.Size = new System.Drawing.Size(68, 69);
            this.Num3Btn.TabIndex = 8;
            this.Num3Btn.TabStop = false;
            this.Num3Btn.Text = "3";
            this.Num3Btn.UseVisualStyleBackColor = true;
            this.Num3Btn.Click += new System.EventHandler(this.Num3Btn_Click);
            // 
            // Num1Btn
            // 
            this.Num1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Num1Btn.Location = new System.Drawing.Point(18, 152);
            this.Num1Btn.Name = "Num1Btn";
            this.Num1Btn.Size = new System.Drawing.Size(68, 69);
            this.Num1Btn.TabIndex = 9;
            this.Num1Btn.TabStop = false;
            this.Num1Btn.Text = "1";
            this.Num1Btn.UseVisualStyleBackColor = true;
            this.Num1Btn.Click += new System.EventHandler(this.Num1Btn_Click);
            // 
            // Num4Btn
            // 
            this.Num4Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Num4Btn.Location = new System.Drawing.Point(18, 227);
            this.Num4Btn.Name = "Num4Btn";
            this.Num4Btn.Size = new System.Drawing.Size(68, 69);
            this.Num4Btn.TabIndex = 12;
            this.Num4Btn.TabStop = false;
            this.Num4Btn.Text = "4";
            this.Num4Btn.UseVisualStyleBackColor = true;
            this.Num4Btn.Click += new System.EventHandler(this.Num4Btn_Click);
            // 
            // Num6Btn
            // 
            this.Num6Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Num6Btn.Location = new System.Drawing.Point(166, 227);
            this.Num6Btn.Name = "Num6Btn";
            this.Num6Btn.Size = new System.Drawing.Size(68, 69);
            this.Num6Btn.TabIndex = 11;
            this.Num6Btn.TabStop = false;
            this.Num6Btn.Text = "6";
            this.Num6Btn.UseVisualStyleBackColor = true;
            this.Num6Btn.Click += new System.EventHandler(this.Num6Btn_Click);
            // 
            // Num5Btn
            // 
            this.Num5Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Num5Btn.Location = new System.Drawing.Point(92, 227);
            this.Num5Btn.Name = "Num5Btn";
            this.Num5Btn.Size = new System.Drawing.Size(68, 69);
            this.Num5Btn.TabIndex = 10;
            this.Num5Btn.TabStop = false;
            this.Num5Btn.Text = "5";
            this.Num5Btn.UseVisualStyleBackColor = true;
            this.Num5Btn.Click += new System.EventHandler(this.Num5Btn_Click);
            // 
            // Num7Btn
            // 
            this.Num7Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Num7Btn.Location = new System.Drawing.Point(18, 302);
            this.Num7Btn.Name = "Num7Btn";
            this.Num7Btn.Size = new System.Drawing.Size(68, 69);
            this.Num7Btn.TabIndex = 15;
            this.Num7Btn.TabStop = false;
            this.Num7Btn.Text = "7";
            this.Num7Btn.UseVisualStyleBackColor = true;
            this.Num7Btn.Click += new System.EventHandler(this.Num7Btn_Click);
            // 
            // Num9Btn
            // 
            this.Num9Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Num9Btn.Location = new System.Drawing.Point(166, 302);
            this.Num9Btn.Name = "Num9Btn";
            this.Num9Btn.Size = new System.Drawing.Size(68, 69);
            this.Num9Btn.TabIndex = 14;
            this.Num9Btn.TabStop = false;
            this.Num9Btn.Text = "9";
            this.Num9Btn.UseVisualStyleBackColor = true;
            this.Num9Btn.Click += new System.EventHandler(this.Num9Btn_Click);
            // 
            // Num8Btn
            // 
            this.Num8Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Num8Btn.Location = new System.Drawing.Point(92, 302);
            this.Num8Btn.Name = "Num8Btn";
            this.Num8Btn.Size = new System.Drawing.Size(68, 69);
            this.Num8Btn.TabIndex = 13;
            this.Num8Btn.TabStop = false;
            this.Num8Btn.Text = "8";
            this.Num8Btn.UseVisualStyleBackColor = true;
            this.Num8Btn.Click += new System.EventHandler(this.Num8Btn_Click);
            // 
            // Num0Btn
            // 
            this.Num0Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Num0Btn.Location = new System.Drawing.Point(92, 377);
            this.Num0Btn.Name = "Num0Btn";
            this.Num0Btn.Size = new System.Drawing.Size(68, 69);
            this.Num0Btn.TabIndex = 16;
            this.Num0Btn.TabStop = false;
            this.Num0Btn.Text = "0";
            this.Num0Btn.UseVisualStyleBackColor = true;
            this.Num0Btn.Click += new System.EventHandler(this.Num0Btn_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 525);
            this.Controls.Add(this.Num0Btn);
            this.Controls.Add(this.Num7Btn);
            this.Controls.Add(this.Num9Btn);
            this.Controls.Add(this.Num8Btn);
            this.Controls.Add(this.Num4Btn);
            this.Controls.Add(this.Num6Btn);
            this.Controls.Add(this.Num5Btn);
            this.Controls.Add(this.Num1Btn);
            this.Controls.Add(this.Num3Btn);
            this.Controls.Add(this.Num2Btn);
            this.Controls.Add(this.number2Label);
            this.Controls.Add(this.EqualsBtn);
            this.Controls.Add(this.DivBtn);
            this.Controls.Add(this.MultBtn);
            this.Controls.Add(this.SubBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ResultLabel);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button SubBtn;
        private System.Windows.Forms.Button MultBtn;
        private System.Windows.Forms.Button DivBtn;
        private System.Windows.Forms.Button EqualsBtn;
        private System.Windows.Forms.Label number2Label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Num2Btn;
        private System.Windows.Forms.Button Num3Btn;
        private System.Windows.Forms.Button Num1Btn;
        private System.Windows.Forms.Button Num4Btn;
        private System.Windows.Forms.Button Num6Btn;
        private System.Windows.Forms.Button Num5Btn;
        private System.Windows.Forms.Button Num7Btn;
        private System.Windows.Forms.Button Num9Btn;
        private System.Windows.Forms.Button Num8Btn;
        private System.Windows.Forms.Button Num0Btn;
    }
}

