namespace CharCounter
{
    partial class CharCounter
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.input_text_box = new System.Windows.Forms.RichTextBox();
            this.button_count = new System.Windows.Forms.Button();
            this.output_text_box = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // input_text_box
            // 
            this.input_text_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_text_box.Location = new System.Drawing.Point(12, 12);
            this.input_text_box.Name = "input_text_box";
            this.input_text_box.Size = new System.Drawing.Size(776, 229);
            this.input_text_box.TabIndex = 0;
            this.input_text_box.Text = "";
            // 
            // button_count
            // 
            this.button_count.Location = new System.Drawing.Point(12, 247);
            this.button_count.Name = "button_count";
            this.button_count.Size = new System.Drawing.Size(776, 63);
            this.button_count.TabIndex = 1;
            this.button_count.Text = "Count!";
            this.button_count.UseVisualStyleBackColor = true;
            this.button_count.Click += new System.EventHandler(this.Button_count_Click);
            // 
            // output_text_box
            // 
            this.output_text_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_text_box.Location = new System.Drawing.Point(13, 316);
            this.output_text_box.Name = "output_text_box";
            this.output_text_box.Size = new System.Drawing.Size(775, 320);
            this.output_text_box.TabIndex = 2;
            this.output_text_box.Text = "";
            // 
            // CharCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.Controls.Add(this.output_text_box);
            this.Controls.Add(this.button_count);
            this.Controls.Add(this.input_text_box);
            this.Name = "CharCounter";
            this.Text = "CharCounter by Philipp Buthmann";
            this.Load += new System.EventHandler(this.CharCounter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox input_text_box;
        private System.Windows.Forms.Button button_count;
        private System.Windows.Forms.RichTextBox output_text_box;
    }
}

