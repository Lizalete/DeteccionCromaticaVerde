namespace DetecciónCromática
{
    unsafe public partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_RGB = new System.Windows.Forms.Button();
            this.BTN_YUV = new System.Windows.Forms.Button();
            this.BTN_HSV = new System.Windows.Forms.Button();
            this.LBL_STATUSRGB = new System.Windows.Forms.Label();
            this.LBL_STATUSYUV = new System.Windows.Forms.Label();
            this.LBL_STATUSHSV = new System.Windows.Forms.Label();
            this.LBL_200 = new System.Windows.Forms.Label();
            this.LBL_200YUV = new System.Windows.Forms.Label();
            this.LBL_200HSV = new System.Windows.Forms.Label();
            this.LBL_IMAGES = new System.Windows.Forms.Label();
            this.LBL_IMAGERGB = new System.Windows.Forms.Label();
            this.LBL_IMAGEYUV = new System.Windows.Forms.Label();
            this.LBL_IMAGEHSV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_RGB
            // 
            this.BTN_RGB.Location = new System.Drawing.Point(12, 29);
            this.BTN_RGB.Name = "BTN_RGB";
            this.BTN_RGB.Size = new System.Drawing.Size(75, 23);
            this.BTN_RGB.TabIndex = 0;
            this.BTN_RGB.Text = "RGB";
            this.BTN_RGB.UseVisualStyleBackColor = true;
            this.BTN_RGB.Click += new System.EventHandler(this.BTN_RGB_Click);
            // 
            // BTN_YUV
            // 
            this.BTN_YUV.Location = new System.Drawing.Point(12, 69);
            this.BTN_YUV.Name = "BTN_YUV";
            this.BTN_YUV.Size = new System.Drawing.Size(75, 23);
            this.BTN_YUV.TabIndex = 1;
            this.BTN_YUV.Text = "YUV";
            this.BTN_YUV.UseVisualStyleBackColor = true;
            this.BTN_YUV.Click += new System.EventHandler(this.BTN_YUV_Click);
            // 
            // BTN_HSV
            // 
            this.BTN_HSV.Location = new System.Drawing.Point(12, 108);
            this.BTN_HSV.Name = "BTN_HSV";
            this.BTN_HSV.Size = new System.Drawing.Size(75, 23);
            this.BTN_HSV.TabIndex = 16;
            this.BTN_HSV.Text = "HSV";
            this.BTN_HSV.UseVisualStyleBackColor = true;
            this.BTN_HSV.Click += new System.EventHandler(this.BTN_HSV_Click);
            // 
            // LBL_STATUSRGB
            // 
            this.LBL_STATUSRGB.AutoSize = true;
            this.LBL_STATUSRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_STATUSRGB.Location = new System.Drawing.Point(93, 32);
            this.LBL_STATUSRGB.Name = "LBL_STATUSRGB";
            this.LBL_STATUSRGB.Size = new System.Drawing.Size(69, 17);
            this.LBL_STATUSRGB.TabIndex = 17;
            this.LBL_STATUSRGB.Text = "STATUS";
            // 
            // LBL_STATUSYUV
            // 
            this.LBL_STATUSYUV.AutoSize = true;
            this.LBL_STATUSYUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_STATUSYUV.Location = new System.Drawing.Point(95, 72);
            this.LBL_STATUSYUV.Name = "LBL_STATUSYUV";
            this.LBL_STATUSYUV.Size = new System.Drawing.Size(69, 17);
            this.LBL_STATUSYUV.TabIndex = 18;
            this.LBL_STATUSYUV.Text = "STATUS";
            // 
            // LBL_STATUSHSV
            // 
            this.LBL_STATUSHSV.AutoSize = true;
            this.LBL_STATUSHSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_STATUSHSV.Location = new System.Drawing.Point(95, 111);
            this.LBL_STATUSHSV.Name = "LBL_STATUSHSV";
            this.LBL_STATUSHSV.Size = new System.Drawing.Size(69, 17);
            this.LBL_STATUSHSV.TabIndex = 19;
            this.LBL_STATUSHSV.Text = "STATUS";
            // 
            // LBL_200
            // 
            this.LBL_200.AutoSize = true;
            this.LBL_200.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_200.Location = new System.Drawing.Point(249, 35);
            this.LBL_200.Name = "LBL_200";
            this.LBL_200.Size = new System.Drawing.Size(40, 17);
            this.LBL_200.TabIndex = 20;
            this.LBL_200.Text = "/200";
            // 
            // LBL_200YUV
            // 
            this.LBL_200YUV.AutoSize = true;
            this.LBL_200YUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_200YUV.Location = new System.Drawing.Point(249, 72);
            this.LBL_200YUV.Name = "LBL_200YUV";
            this.LBL_200YUV.Size = new System.Drawing.Size(40, 17);
            this.LBL_200YUV.TabIndex = 21;
            this.LBL_200YUV.Text = "/200";
            // 
            // LBL_200HSV
            // 
            this.LBL_200HSV.AutoSize = true;
            this.LBL_200HSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_200HSV.Location = new System.Drawing.Point(249, 111);
            this.LBL_200HSV.Name = "LBL_200HSV";
            this.LBL_200HSV.Size = new System.Drawing.Size(40, 17);
            this.LBL_200HSV.TabIndex = 22;
            this.LBL_200HSV.Text = "/200";
            // 
            // LBL_IMAGES
            // 
            this.LBL_IMAGES.AutoSize = true;
            this.LBL_IMAGES.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_IMAGES.Location = new System.Drawing.Point(217, 9);
            this.LBL_IMAGES.Name = "LBL_IMAGES";
            this.LBL_IMAGES.Size = new System.Drawing.Size(66, 17);
            this.LBL_IMAGES.TabIndex = 23;
            this.LBL_IMAGES.Text = "IMAGES";
            // 
            // LBL_IMAGERGB
            // 
            this.LBL_IMAGERGB.AutoSize = true;
            this.LBL_IMAGERGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_IMAGERGB.Location = new System.Drawing.Point(217, 35);
            this.LBL_IMAGERGB.Name = "LBL_IMAGERGB";
            this.LBL_IMAGERGB.Size = new System.Drawing.Size(17, 17);
            this.LBL_IMAGERGB.TabIndex = 24;
            this.LBL_IMAGERGB.Text = "0";
            // 
            // LBL_IMAGEYUV
            // 
            this.LBL_IMAGEYUV.AutoSize = true;
            this.LBL_IMAGEYUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_IMAGEYUV.Location = new System.Drawing.Point(217, 72);
            this.LBL_IMAGEYUV.Name = "LBL_IMAGEYUV";
            this.LBL_IMAGEYUV.Size = new System.Drawing.Size(17, 17);
            this.LBL_IMAGEYUV.TabIndex = 25;
            this.LBL_IMAGEYUV.Text = "0";
            // 
            // LBL_IMAGEHSV
            // 
            this.LBL_IMAGEHSV.AutoSize = true;
            this.LBL_IMAGEHSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_IMAGEHSV.Location = new System.Drawing.Point(218, 111);
            this.LBL_IMAGEHSV.Name = "LBL_IMAGEHSV";
            this.LBL_IMAGEHSV.Size = new System.Drawing.Size(17, 17);
            this.LBL_IMAGEHSV.TabIndex = 26;
            this.LBL_IMAGEHSV.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 159);
            this.Controls.Add(this.LBL_IMAGEHSV);
            this.Controls.Add(this.LBL_IMAGEYUV);
            this.Controls.Add(this.LBL_IMAGERGB);
            this.Controls.Add(this.LBL_IMAGES);
            this.Controls.Add(this.LBL_200HSV);
            this.Controls.Add(this.LBL_200YUV);
            this.Controls.Add(this.LBL_200);
            this.Controls.Add(this.LBL_STATUSHSV);
            this.Controls.Add(this.LBL_STATUSYUV);
            this.Controls.Add(this.LBL_STATUSRGB);
            this.Controls.Add(this.BTN_HSV);
            this.Controls.Add(this.BTN_YUV);
            this.Controls.Add(this.BTN_RGB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_RGB;
        private System.Windows.Forms.Button BTN_YUV;
        private System.Windows.Forms.Button BTN_HSV;
        private System.Windows.Forms.Label LBL_STATUSRGB;
        private System.Windows.Forms.Label LBL_STATUSYUV;
        private System.Windows.Forms.Label LBL_STATUSHSV;
        private System.Windows.Forms.Label LBL_200;
        private System.Windows.Forms.Label LBL_200YUV;
        private System.Windows.Forms.Label LBL_200HSV;
        private System.Windows.Forms.Label LBL_IMAGES;
        private System.Windows.Forms.Label LBL_IMAGERGB;
        private System.Windows.Forms.Label LBL_IMAGEYUV;
        private System.Windows.Forms.Label LBL_IMAGEHSV;
    }
}

