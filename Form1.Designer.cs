namespace CodigoQR
{
    partial class QR
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
            ImgQr = new PictureBox();
            label1 = new Label();
            txtValor = new TextBox();
            btnGuardar = new Button();
            btnGenerar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)ImgQr).BeginInit();
            SuspendLayout();
            // 
            // ImgQr
            // 
            ImgQr.Location = new Point(12, 12);
            ImgQr.Name = "ImgQr";
            ImgQr.Size = new Size(200, 200);
            ImgQr.TabIndex = 0;
            ImgQr.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(56, 218);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 1;
            label1.Text = "URL / TEXTO ";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(12, 244);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(200, 23);
            txtValor.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.Enabled = false;
            btnGuardar.Font = new Font("Segoe Script", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(12, 273);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(70, 23);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Font = new Font("Segoe Script", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerar.Location = new Point(88, 274);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(65, 23);
            btnGenerar.TabIndex = 4;
            btnGenerar.Text = "QR";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(159, 274);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(53, 23);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Exit";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // QR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 309);
            Controls.Add(btnSalir);
            Controls.Add(btnGenerar);
            Controls.Add(btnGuardar);
            Controls.Add(txtValor);
            Controls.Add(label1);
            Controls.Add(ImgQr);
            Name = "QR";
            Text = "QR";
            ((System.ComponentModel.ISupportInitialize)ImgQr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ImgQr;
        private Label label1;
        private TextBox txtValor;
        private Button btnGuardar;
        private Button btnGenerar;
        private Button btnSalir;
    }
}