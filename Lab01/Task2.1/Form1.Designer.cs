namespace Task2._1
{
    partial class Task2_1
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
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.label_Key = new System.Windows.Forms.Label();
            this.textBox_Message = new System.Windows.Forms.TextBox();
            this.label_Message = new System.Windows.Forms.Label();
            this.label_Result = new System.Windows.Forms.Label();
            this.button_Decrypt = new System.Windows.Forms.Button();
            this.button_Encrypt = new System.Windows.Forms.Button();
            this.label_Tittle = new System.Windows.Forms.Label();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Key
            // 
            this.textBox_Key.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Key.ForeColor = System.Drawing.Color.DarkOrange;
            this.textBox_Key.Location = new System.Drawing.Point(200, 360);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(297, 34);
            this.textBox_Key.TabIndex = 7;
            this.textBox_Key.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Key_KeyPress);
            // 
            // label_Key
            // 
            this.label_Key.AutoSize = true;
            this.label_Key.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_Key.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Key.ForeColor = System.Drawing.Color.Peru;
            this.label_Key.Location = new System.Drawing.Point(66, 362);
            this.label_Key.Name = "label_Key";
            this.label_Key.Size = new System.Drawing.Size(62, 27);
            this.label_Key.TabIndex = 6;
            this.label_Key.Text = "Key";
            // 
            // textBox_Message
            // 
            this.textBox_Message.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Message.ForeColor = System.Drawing.Color.DarkOrange;
            this.textBox_Message.Location = new System.Drawing.Point(200, 135);
            this.textBox_Message.Multiline = true;
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Message.Size = new System.Drawing.Size(297, 183);
            this.textBox_Message.TabIndex = 5;
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_Message.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Message.ForeColor = System.Drawing.Color.Peru;
            this.label_Message.Location = new System.Drawing.Point(66, 137);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(128, 27);
            this.label_Message.TabIndex = 4;
            this.label_Message.Text = "Message";
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_Result.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Result.ForeColor = System.Drawing.Color.Peru;
            this.label_Result.Location = new System.Drawing.Point(540, 139);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(102, 27);
            this.label_Result.TabIndex = 8;
            this.label_Result.Text = "Result";
            // 
            // button_Decrypt
            // 
            this.button_Decrypt.AutoSize = true;
            this.button_Decrypt.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_Decrypt.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.button_Decrypt.FlatAppearance.BorderSize = 3;
            this.button_Decrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.button_Decrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button_Decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Decrypt.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Decrypt.ForeColor = System.Drawing.Color.Peru;
            this.button_Decrypt.Location = new System.Drawing.Point(354, 448);
            this.button_Decrypt.Name = "button_Decrypt";
            this.button_Decrypt.Size = new System.Drawing.Size(143, 43);
            this.button_Decrypt.TabIndex = 32;
            this.button_Decrypt.Text = "Decrypt";
            this.button_Decrypt.UseVisualStyleBackColor = false;
            // 
            // button_Encrypt
            // 
            this.button_Encrypt.AutoSize = true;
            this.button_Encrypt.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_Encrypt.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.button_Encrypt.FlatAppearance.BorderSize = 3;
            this.button_Encrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.button_Encrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button_Encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Encrypt.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Encrypt.ForeColor = System.Drawing.Color.Peru;
            this.button_Encrypt.Location = new System.Drawing.Point(71, 448);
            this.button_Encrypt.Name = "button_Encrypt";
            this.button_Encrypt.Size = new System.Drawing.Size(143, 43);
            this.button_Encrypt.TabIndex = 31;
            this.button_Encrypt.Text = "Encrypt";
            this.button_Encrypt.UseVisualStyleBackColor = false;
            // 
            // label_Tittle
            // 
            this.label_Tittle.AutoSize = true;
            this.label_Tittle.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_Tittle.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tittle.ForeColor = System.Drawing.Color.Peru;
            this.label_Tittle.Location = new System.Drawing.Point(186, 24);
            this.label_Tittle.Name = "label_Tittle";
            this.label_Tittle.Size = new System.Drawing.Size(652, 81);
            this.label_Tittle.TabIndex = 33;
            this.label_Tittle.Text = "Cearsar Cipher";
            // 
            // textBox_Result
            // 
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Result.ForeColor = System.Drawing.Color.DarkOrange;
            this.textBox_Result.Location = new System.Drawing.Point(648, 135);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Result.Size = new System.Drawing.Size(297, 183);
            this.textBox_Result.TabIndex = 9;
            // 
            // Task2_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1007, 555);
            this.Controls.Add(this.label_Tittle);
            this.Controls.Add(this.button_Decrypt);
            this.Controls.Add(this.button_Encrypt);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.textBox_Key);
            this.Controls.Add(this.label_Key);
            this.Controls.Add(this.textBox_Message);
            this.Controls.Add(this.label_Message);
            this.Name = "Task2_1";
            this.Text = "Task2.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.Label label_Key;
        private System.Windows.Forms.TextBox textBox_Message;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Button button_Decrypt;
        private System.Windows.Forms.Button button_Encrypt;
        private System.Windows.Forms.Label label_Tittle;
        private System.Windows.Forms.TextBox textBox_Result;
    }
}

