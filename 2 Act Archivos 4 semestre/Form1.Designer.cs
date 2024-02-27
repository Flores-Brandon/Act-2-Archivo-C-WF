namespace _2_Act_Archivos_4_semestre
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAbrirIndexado = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxSecuenciales = new System.Windows.Forms.ListBox();
            this.btnSecuencial = new System.Windows.Forms.Button();
            this.btnCerrarSecuencial = new System.Windows.Forms.Button();
            this.btnAbrirSecuencial = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxIndexado = new System.Windows.Forms.ListBox();
            this.btnIndexado = new System.Windows.Forms.Button();
            this.btnCerrarIndexado = new System.Windows.Forms.Button();
            this.btnAbrirInedxado = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBoxDirecto = new System.Windows.Forms.ListBox();
            this.btnDirecto = new System.Windows.Forms.Button();
            this.btnCerrarDirecto = new System.Windows.Forms.Button();
            this.btnAbrirDirecto = new System.Windows.Forms.Button();
            this.btnAbrirIndexado.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbrirIndexado
            // 
            this.btnAbrirIndexado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrirIndexado.Controls.Add(this.tabPage1);
            this.btnAbrirIndexado.Controls.Add(this.tabPage2);
            this.btnAbrirIndexado.Controls.Add(this.tabPage3);
            this.btnAbrirIndexado.Location = new System.Drawing.Point(9, 10);
            this.btnAbrirIndexado.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbrirIndexado.Name = "btnAbrirIndexado";
            this.btnAbrirIndexado.SelectedIndex = 0;
            this.btnAbrirIndexado.Size = new System.Drawing.Size(814, 379);
            this.btnAbrirIndexado.TabIndex = 0;
            this.btnAbrirIndexado.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxSecuenciales);
            this.tabPage1.Controls.Add(this.btnSecuencial);
            this.tabPage1.Controls.Add(this.btnCerrarSecuencial);
            this.tabPage1.Controls.Add(this.btnAbrirSecuencial);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(806, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "archivos secuenciales.";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxSecuenciales
            // 
            this.listBoxSecuenciales.FormattingEnabled = true;
            this.listBoxSecuenciales.Location = new System.Drawing.Point(23, 53);
            this.listBoxSecuenciales.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSecuenciales.Name = "listBoxSecuenciales";
            this.listBoxSecuenciales.Size = new System.Drawing.Size(364, 264);
            this.listBoxSecuenciales.TabIndex = 8;
            // 
            // btnSecuencial
            // 
            this.btnSecuencial.Location = new System.Drawing.Point(496, 150);
            this.btnSecuencial.Margin = new System.Windows.Forms.Padding(2);
            this.btnSecuencial.Name = "btnSecuencial";
            this.btnSecuencial.Size = new System.Drawing.Size(107, 41);
            this.btnSecuencial.TabIndex = 3;
            this.btnSecuencial.Text = "Motrar Archivo";
            this.btnSecuencial.UseVisualStyleBackColor = true;
            this.btnSecuencial.Click += new System.EventHandler(this.btnSecuencial_Click);
            // 
            // btnCerrarSecuencial
            // 
            this.btnCerrarSecuencial.Location = new System.Drawing.Point(496, 195);
            this.btnCerrarSecuencial.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarSecuencial.Name = "btnCerrarSecuencial";
            this.btnCerrarSecuencial.Size = new System.Drawing.Size(107, 41);
            this.btnCerrarSecuencial.TabIndex = 2;
            this.btnCerrarSecuencial.Text = "Cerrar Archivo";
            this.btnCerrarSecuencial.UseVisualStyleBackColor = true;
            this.btnCerrarSecuencial.Click += new System.EventHandler(this.btnCerrarArchivo_Click);
            // 
            // btnAbrirSecuencial
            // 
            this.btnAbrirSecuencial.Location = new System.Drawing.Point(496, 105);
            this.btnAbrirSecuencial.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbrirSecuencial.Name = "btnAbrirSecuencial";
            this.btnAbrirSecuencial.Size = new System.Drawing.Size(107, 41);
            this.btnAbrirSecuencial.TabIndex = 1;
            this.btnAbrirSecuencial.Text = "Abrir Archivo";
            this.btnAbrirSecuencial.UseVisualStyleBackColor = true;
            this.btnAbrirSecuencial.Click += new System.EventHandler(this.btnAbrirArchivo_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxIndexado);
            this.tabPage2.Controls.Add(this.btnIndexado);
            this.tabPage2.Controls.Add(this.btnCerrarIndexado);
            this.tabPage2.Controls.Add(this.btnAbrirInedxado);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(806, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "archivos secuenciales indexados.";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxIndexado
            // 
            this.listBoxIndexado.FormattingEnabled = true;
            this.listBoxIndexado.Location = new System.Drawing.Point(113, 44);
            this.listBoxIndexado.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxIndexado.Name = "listBoxIndexado";
            this.listBoxIndexado.Size = new System.Drawing.Size(364, 264);
            this.listBoxIndexado.TabIndex = 12;
            // 
            // btnIndexado
            // 
            this.btnIndexado.Location = new System.Drawing.Point(586, 141);
            this.btnIndexado.Margin = new System.Windows.Forms.Padding(2);
            this.btnIndexado.Name = "btnIndexado";
            this.btnIndexado.Size = new System.Drawing.Size(107, 41);
            this.btnIndexado.TabIndex = 11;
            this.btnIndexado.Text = "Motrar Archivo";
            this.btnIndexado.UseVisualStyleBackColor = true;
            this.btnIndexado.Click += new System.EventHandler(this.btnIndexado_Click);
            // 
            // btnCerrarIndexado
            // 
            this.btnCerrarIndexado.Location = new System.Drawing.Point(586, 186);
            this.btnCerrarIndexado.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarIndexado.Name = "btnCerrarIndexado";
            this.btnCerrarIndexado.Size = new System.Drawing.Size(107, 41);
            this.btnCerrarIndexado.TabIndex = 10;
            this.btnCerrarIndexado.Text = "Cerrar Archivo";
            this.btnCerrarIndexado.UseVisualStyleBackColor = true;
            this.btnCerrarIndexado.Click += new System.EventHandler(this.btnCerrarIndexado_Click);
            // 
            // btnAbrirInedxado
            // 
            this.btnAbrirInedxado.Location = new System.Drawing.Point(586, 96);
            this.btnAbrirInedxado.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbrirInedxado.Name = "btnAbrirInedxado";
            this.btnAbrirInedxado.Size = new System.Drawing.Size(107, 41);
            this.btnAbrirInedxado.TabIndex = 9;
            this.btnAbrirInedxado.Text = "Abrir Archivo";
            this.btnAbrirInedxado.UseVisualStyleBackColor = true;
            this.btnAbrirInedxado.Click += new System.EventHandler(this.btnAbrirIndexado_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBoxDirecto);
            this.tabPage3.Controls.Add(this.btnDirecto);
            this.tabPage3.Controls.Add(this.btnCerrarDirecto);
            this.tabPage3.Controls.Add(this.btnAbrirDirecto);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(806, 353);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "archivos de acceso directo.";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBoxDirecto
            // 
            this.listBoxDirecto.FormattingEnabled = true;
            this.listBoxDirecto.Location = new System.Drawing.Point(113, 44);
            this.listBoxDirecto.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxDirecto.Name = "listBoxDirecto";
            this.listBoxDirecto.Size = new System.Drawing.Size(364, 264);
            this.listBoxDirecto.TabIndex = 16;
            // 
            // btnDirecto
            // 
            this.btnDirecto.Location = new System.Drawing.Point(586, 141);
            this.btnDirecto.Margin = new System.Windows.Forms.Padding(2);
            this.btnDirecto.Name = "btnDirecto";
            this.btnDirecto.Size = new System.Drawing.Size(107, 41);
            this.btnDirecto.TabIndex = 15;
            this.btnDirecto.Text = "Motrar Archivo";
            this.btnDirecto.UseVisualStyleBackColor = true;
            this.btnDirecto.Click += new System.EventHandler(this.btnDirecto_Click);
            // 
            // btnCerrarDirecto
            // 
            this.btnCerrarDirecto.Location = new System.Drawing.Point(586, 186);
            this.btnCerrarDirecto.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarDirecto.Name = "btnCerrarDirecto";
            this.btnCerrarDirecto.Size = new System.Drawing.Size(107, 41);
            this.btnCerrarDirecto.TabIndex = 14;
            this.btnCerrarDirecto.Text = "Cerrar Archivo";
            this.btnCerrarDirecto.UseVisualStyleBackColor = true;
            this.btnCerrarDirecto.Click += new System.EventHandler(this.btnCerrarDirecto_Click);
            // 
            // btnAbrirDirecto
            // 
            this.btnAbrirDirecto.Location = new System.Drawing.Point(586, 96);
            this.btnAbrirDirecto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbrirDirecto.Name = "btnAbrirDirecto";
            this.btnAbrirDirecto.Size = new System.Drawing.Size(107, 41);
            this.btnAbrirDirecto.TabIndex = 13;
            this.btnAbrirDirecto.Text = "Abrir Archivo";
            this.btnAbrirDirecto.UseVisualStyleBackColor = true;
            this.btnAbrirDirecto.Click += new System.EventHandler(this.btnAbrirDirecto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 398);
            this.Controls.Add(this.btnAbrirIndexado);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.btnAbrirIndexado.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl btnAbrirIndexado;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSecuencial;
        private System.Windows.Forms.Button btnCerrarSecuencial;
        private System.Windows.Forms.Button btnAbrirSecuencial;
        private System.Windows.Forms.ListBox listBoxSecuenciales;
        private System.Windows.Forms.ListBox listBoxIndexado;
        private System.Windows.Forms.Button btnIndexado;
        private System.Windows.Forms.Button btnCerrarIndexado;
        private System.Windows.Forms.Button btnAbrirInedxado;
        private System.Windows.Forms.ListBox listBoxDirecto;
        private System.Windows.Forms.Button btnDirecto;
        private System.Windows.Forms.Button btnCerrarDirecto;
        private System.Windows.Forms.Button btnAbrirDirecto;
    }
}

