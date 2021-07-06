namespace WindowsFormsAppProj
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.codeCourseLabel = new System.Windows.Forms.Label();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.codeCourseTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // codeCourseLabel
            // 
            this.codeCourseLabel.AutoSize = true;
            this.codeCourseLabel.Location = new System.Drawing.Point(13, 31);
            this.codeCourseLabel.Name = "codeCourseLabel";
            this.codeCourseLabel.Size = new System.Drawing.Size(84, 13);
            this.codeCourseLabel.TabIndex = 88;
            this.codeCourseLabel.Text = "Código do curso";
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Location = new System.Drawing.Point(12, 109);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(0, 13);
            this.courseNameLabel.TabIndex = 99;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(12, 73);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(180, 23);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Validar";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.showCourseNameButton_Click);
            this.submitButton.Click += new System.EventHandler(this.showMsgBox);
            // 
            // codeCourseTextBox
            // 
            this.codeCourseTextBox.Location = new System.Drawing.Point(12, 47);
            this.codeCourseTextBox.Name = "codeCourseTextBox";
            this.codeCourseTextBox.Size = new System.Drawing.Size(180, 20);
            this.codeCourseTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 146);
            this.Controls.Add(this.codeCourseTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.courseNameLabel);
            this.Controls.Add(this.codeCourseLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codeCourseLabel;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox codeCourseTextBox;
    }
}

