namespace Robot
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRobot = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabRobot = new System.Windows.Forms.TabControl();
            this.pagePrincipal = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.btnAlgoritmoA = new System.Windows.Forms.Button();
            this.btnHeuristica = new System.Windows.Forms.Button();
            this.pageAleatorio = new System.Windows.Forms.TabPage();
            this.pbBateria = new System.Windows.Forms.PictureBox();
            this.pbAleatorio = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblObjetivosAleatorio = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pageAlgoritmoA = new System.Windows.Forms.TabPage();
            this.pbBateriaA = new System.Windows.Forms.PictureBox();
            this.pbAlgoritmoA = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblObjetivosA = new System.Windows.Forms.Label();
            this.btnIniciarA = new System.Windows.Forms.Button();
            this.btnRegresarAlgoritmoA = new System.Windows.Forms.Button();
            this.pageHeuristica = new System.Windows.Forms.TabPage();
            this.pbHeuristica = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnIniciarHeuristica = new System.Windows.Forms.Button();
            this.btnRegresarHeuristica = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabRobot.SuspendLayout();
            this.pagePrincipal.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pageAleatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBateria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAleatorio)).BeginInit();
            this.panel3.SuspendLayout();
            this.pageAlgoritmoA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBateriaA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlgoritmoA)).BeginInit();
            this.panel4.SuspendLayout();
            this.pageHeuristica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeuristica)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblRobot);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(800, 78);
            this.panel1.TabIndex = 0;
            // 
            // lblRobot
            // 
            this.lblRobot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRobot.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRobot.Location = new System.Drawing.Point(10, 10);
            this.lblRobot.Name = "lblRobot";
            this.lblRobot.Size = new System.Drawing.Size(780, 58);
            this.lblRobot.TabIndex = 0;
            this.lblRobot.Text = "Robot";
            this.lblRobot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabRobot);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 431);
            this.panel2.TabIndex = 1;
            // 
            // tabRobot
            // 
            this.tabRobot.Controls.Add(this.pagePrincipal);
            this.tabRobot.Controls.Add(this.pageAleatorio);
            this.tabRobot.Controls.Add(this.pageAlgoritmoA);
            this.tabRobot.Controls.Add(this.pageHeuristica);
            this.tabRobot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabRobot.Location = new System.Drawing.Point(0, 0);
            this.tabRobot.Name = "tabRobot";
            this.tabRobot.SelectedIndex = 0;
            this.tabRobot.Size = new System.Drawing.Size(800, 431);
            this.tabRobot.TabIndex = 0;
            this.tabRobot.SelectedIndexChanged += new System.EventHandler(this.tabRobot_SelectedIndexChanged);
            // 
            // pagePrincipal
            // 
            this.pagePrincipal.Controls.Add(this.tableLayoutPanel1);
            this.pagePrincipal.Location = new System.Drawing.Point(4, 22);
            this.pagePrincipal.Name = "pagePrincipal";
            this.pagePrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.pagePrincipal.Size = new System.Drawing.Size(792, 405);
            this.pagePrincipal.TabIndex = 0;
            this.pagePrincipal.Text = "Menú principal";
            this.pagePrincipal.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnAleatorio, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAlgoritmoA, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnHeuristica, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 399);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.BackColor = System.Drawing.Color.DimGray;
            this.btnAleatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAleatorio.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAleatorio.ForeColor = System.Drawing.Color.White;
            this.btnAleatorio.Location = new System.Drawing.Point(72, 94);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(210, 210);
            this.btnAleatorio.TabIndex = 0;
            this.btnAleatorio.Text = "Movimientos al azar";
            this.btnAleatorio.UseVisualStyleBackColor = false;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // btnAlgoritmoA
            // 
            this.btnAlgoritmoA.BackColor = System.Drawing.Color.DimGray;
            this.btnAlgoritmoA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlgoritmoA.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlgoritmoA.ForeColor = System.Drawing.Color.White;
            this.btnAlgoritmoA.Location = new System.Drawing.Point(288, 94);
            this.btnAlgoritmoA.Name = "btnAlgoritmoA";
            this.btnAlgoritmoA.Size = new System.Drawing.Size(210, 210);
            this.btnAlgoritmoA.TabIndex = 1;
            this.btnAlgoritmoA.Text = "Algoritmo A*";
            this.btnAlgoritmoA.UseVisualStyleBackColor = false;
            this.btnAlgoritmoA.Click += new System.EventHandler(this.btnAlgoritmoA_Click);
            // 
            // btnHeuristica
            // 
            this.btnHeuristica.BackColor = System.Drawing.Color.DimGray;
            this.btnHeuristica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeuristica.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeuristica.ForeColor = System.Drawing.Color.White;
            this.btnHeuristica.Location = new System.Drawing.Point(504, 94);
            this.btnHeuristica.Name = "btnHeuristica";
            this.btnHeuristica.Size = new System.Drawing.Size(210, 210);
            this.btnHeuristica.TabIndex = 2;
            this.btnHeuristica.Text = "Algoritmo con heurística";
            this.btnHeuristica.UseVisualStyleBackColor = false;
            this.btnHeuristica.Click += new System.EventHandler(this.btnHeuristica_Click);
            // 
            // pageAleatorio
            // 
            this.pageAleatorio.Controls.Add(this.pbBateria);
            this.pageAleatorio.Controls.Add(this.pbAleatorio);
            this.pageAleatorio.Controls.Add(this.panel3);
            this.pageAleatorio.Location = new System.Drawing.Point(4, 22);
            this.pageAleatorio.Name = "pageAleatorio";
            this.pageAleatorio.Padding = new System.Windows.Forms.Padding(3);
            this.pageAleatorio.Size = new System.Drawing.Size(792, 405);
            this.pageAleatorio.TabIndex = 1;
            this.pageAleatorio.Text = "Aleatorio";
            this.pageAleatorio.UseVisualStyleBackColor = true;
            // 
            // pbBateria
            // 
            this.pbBateria.Image = global::Robot.Properties.Resources.bateria_completa;
            this.pbBateria.Location = new System.Drawing.Point(730, 361);
            this.pbBateria.Name = "pbBateria";
            this.pbBateria.Size = new System.Drawing.Size(54, 36);
            this.pbBateria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBateria.TabIndex = 2;
            this.pbBateria.TabStop = false;
            // 
            // pbAleatorio
            // 
            this.pbAleatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAleatorio.Location = new System.Drawing.Point(3, 50);
            this.pbAleatorio.Name = "pbAleatorio";
            this.pbAleatorio.Size = new System.Drawing.Size(786, 352);
            this.pbAleatorio.TabIndex = 1;
            this.pbAleatorio.TabStop = false;
            this.pbAleatorio.Paint += new System.Windows.Forms.PaintEventHandler(this.pbAleatorio_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblObjetivosAleatorio);
            this.panel3.Controls.Add(this.btnIniciar);
            this.panel3.Controls.Add(this.btnRegresar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(786, 47);
            this.panel3.TabIndex = 0;
            // 
            // lblObjetivosAleatorio
            // 
            this.lblObjetivosAleatorio.AutoSize = true;
            this.lblObjetivosAleatorio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjetivosAleatorio.Location = new System.Drawing.Point(326, 12);
            this.lblObjetivosAleatorio.Name = "lblObjetivosAleatorio";
            this.lblObjetivosAleatorio.Size = new System.Drawing.Size(109, 19);
            this.lblObjetivosAleatorio.TabIndex = 2;
            this.lblObjetivosAleatorio.Text = "Objetivos: 10";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(695, 12);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(11, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // pageAlgoritmoA
            // 
            this.pageAlgoritmoA.Controls.Add(this.pbBateriaA);
            this.pageAlgoritmoA.Controls.Add(this.pbAlgoritmoA);
            this.pageAlgoritmoA.Controls.Add(this.panel4);
            this.pageAlgoritmoA.Location = new System.Drawing.Point(4, 22);
            this.pageAlgoritmoA.Name = "pageAlgoritmoA";
            this.pageAlgoritmoA.Padding = new System.Windows.Forms.Padding(3);
            this.pageAlgoritmoA.Size = new System.Drawing.Size(792, 405);
            this.pageAlgoritmoA.TabIndex = 2;
            this.pageAlgoritmoA.Text = "Algoritmo A*";
            this.pageAlgoritmoA.UseVisualStyleBackColor = true;
            // 
            // pbBateriaA
            // 
            this.pbBateriaA.Image = global::Robot.Properties.Resources.bateria_completa;
            this.pbBateriaA.Location = new System.Drawing.Point(735, 366);
            this.pbBateriaA.Name = "pbBateriaA";
            this.pbBateriaA.Size = new System.Drawing.Size(54, 36);
            this.pbBateriaA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBateriaA.TabIndex = 3;
            this.pbBateriaA.TabStop = false;
            // 
            // pbAlgoritmoA
            // 
            this.pbAlgoritmoA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAlgoritmoA.Location = new System.Drawing.Point(3, 50);
            this.pbAlgoritmoA.Name = "pbAlgoritmoA";
            this.pbAlgoritmoA.Size = new System.Drawing.Size(786, 352);
            this.pbAlgoritmoA.TabIndex = 2;
            this.pbAlgoritmoA.TabStop = false;
            this.pbAlgoritmoA.Paint += new System.Windows.Forms.PaintEventHandler(this.pbAlgoritmoA_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblObjetivosA);
            this.panel4.Controls.Add(this.btnIniciarA);
            this.panel4.Controls.Add(this.btnRegresarAlgoritmoA);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(786, 47);
            this.panel4.TabIndex = 1;
            // 
            // lblObjetivosA
            // 
            this.lblObjetivosA.AutoSize = true;
            this.lblObjetivosA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjetivosA.Location = new System.Drawing.Point(343, 13);
            this.lblObjetivosA.Name = "lblObjetivosA";
            this.lblObjetivosA.Size = new System.Drawing.Size(109, 19);
            this.lblObjetivosA.TabIndex = 3;
            this.lblObjetivosA.Text = "Objetivos: 10";
            // 
            // btnIniciarA
            // 
            this.btnIniciarA.Location = new System.Drawing.Point(695, 12);
            this.btnIniciarA.Name = "btnIniciarA";
            this.btnIniciarA.Size = new System.Drawing.Size(75, 23);
            this.btnIniciarA.TabIndex = 2;
            this.btnIniciarA.Text = "Iniciar";
            this.btnIniciarA.UseVisualStyleBackColor = true;
            this.btnIniciarA.Click += new System.EventHandler(this.btnIniciarA_Click);
            // 
            // btnRegresarAlgoritmoA
            // 
            this.btnRegresarAlgoritmoA.Location = new System.Drawing.Point(11, 12);
            this.btnRegresarAlgoritmoA.Name = "btnRegresarAlgoritmoA";
            this.btnRegresarAlgoritmoA.Size = new System.Drawing.Size(75, 23);
            this.btnRegresarAlgoritmoA.TabIndex = 0;
            this.btnRegresarAlgoritmoA.Text = "Regresar";
            this.btnRegresarAlgoritmoA.UseVisualStyleBackColor = true;
            this.btnRegresarAlgoritmoA.Click += new System.EventHandler(this.btnRegresarAlgoritmoA_Click);
            // 
            // pageHeuristica
            // 
            this.pageHeuristica.Controls.Add(this.pbHeuristica);
            this.pageHeuristica.Controls.Add(this.panel5);
            this.pageHeuristica.Location = new System.Drawing.Point(4, 22);
            this.pageHeuristica.Name = "pageHeuristica";
            this.pageHeuristica.Padding = new System.Windows.Forms.Padding(3);
            this.pageHeuristica.Size = new System.Drawing.Size(792, 405);
            this.pageHeuristica.TabIndex = 3;
            this.pageHeuristica.Text = "Heuristica";
            this.pageHeuristica.UseVisualStyleBackColor = true;
            // 
            // pbHeuristica
            // 
            this.pbHeuristica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbHeuristica.Location = new System.Drawing.Point(3, 50);
            this.pbHeuristica.Name = "pbHeuristica";
            this.pbHeuristica.Size = new System.Drawing.Size(786, 352);
            this.pbHeuristica.TabIndex = 2;
            this.pbHeuristica.TabStop = false;
            this.pbHeuristica.Paint += new System.Windows.Forms.PaintEventHandler(this.pbHeuristica_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnIniciarHeuristica);
            this.panel5.Controls.Add(this.btnRegresarHeuristica);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(786, 47);
            this.panel5.TabIndex = 1;
            // 
            // btnIniciarHeuristica
            // 
            this.btnIniciarHeuristica.Location = new System.Drawing.Point(694, 12);
            this.btnIniciarHeuristica.Name = "btnIniciarHeuristica";
            this.btnIniciarHeuristica.Size = new System.Drawing.Size(75, 23);
            this.btnIniciarHeuristica.TabIndex = 2;
            this.btnIniciarHeuristica.Text = "Iniciar";
            this.btnIniciarHeuristica.UseVisualStyleBackColor = true;
            this.btnIniciarHeuristica.Click += new System.EventHandler(this.btnIniciarHeuristica_Click);
            // 
            // btnRegresarHeuristica
            // 
            this.btnRegresarHeuristica.Location = new System.Drawing.Point(11, 12);
            this.btnRegresarHeuristica.Name = "btnRegresarHeuristica";
            this.btnRegresarHeuristica.Size = new System.Drawing.Size(75, 23);
            this.btnRegresarHeuristica.TabIndex = 0;
            this.btnRegresarHeuristica.Text = "Regresar";
            this.btnRegresarHeuristica.UseVisualStyleBackColor = true;
            this.btnRegresarHeuristica.Click += new System.EventHandler(this.btnRegresarHeuristica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(816, 548);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabRobot.ResumeLayout(false);
            this.pagePrincipal.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pageAleatorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBateria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAleatorio)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pageAlgoritmoA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBateriaA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlgoritmoA)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pageHeuristica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeuristica)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRobot;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabRobot;
        private System.Windows.Forms.TabPage pagePrincipal;
        private System.Windows.Forms.TabPage pageAleatorio;
        private System.Windows.Forms.TabPage pageAlgoritmoA;
        private System.Windows.Forms.TabPage pageHeuristica;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAleatorio;
        private System.Windows.Forms.Button btnAlgoritmoA;
        private System.Windows.Forms.Button btnHeuristica;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRegresarAlgoritmoA;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnRegresarHeuristica;
        private System.Windows.Forms.PictureBox pbAleatorio;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox pbBateria;
        private System.Windows.Forms.PictureBox pbAlgoritmoA;
        private System.Windows.Forms.PictureBox pbHeuristica;
        private System.Windows.Forms.Button btnIniciarHeuristica;
        private System.Windows.Forms.Button btnIniciarA;
        private System.Windows.Forms.PictureBox pbBateriaA;
        private System.Windows.Forms.Label lblObjetivosAleatorio;
        private System.Windows.Forms.Label lblObjetivosA;
    }
}

