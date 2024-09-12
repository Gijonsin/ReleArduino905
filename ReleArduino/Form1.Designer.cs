namespace ReleArduino
{
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
            btnRelevador = new Button();
            SuspendLayout();
            // 
            // btnRelevador
            // 
            btnRelevador.BackColor = Color.IndianRed;
            btnRelevador.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelevador.Location = new Point(266, 151);
            btnRelevador.Name = "btnRelevador";
            btnRelevador.Size = new Size(138, 58);
            btnRelevador.TabIndex = 0;
            btnRelevador.Text = "Relevador";
            btnRelevador.UseVisualStyleBackColor = false;
            btnRelevador.Click += btnRelevador_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRelevador);
            Name = "Form1";
            Text = "Control Relevador Arduino";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRelevador;
    }
}
