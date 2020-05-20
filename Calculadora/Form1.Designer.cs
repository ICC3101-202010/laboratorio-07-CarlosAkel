namespace Calculadora
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
            this.UserInput = new System.Windows.Forms.TextBox();
            this.Resultado_Calculadora = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.B7 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.B9 = new System.Windows.Forms.Button();
            this.DEL = new System.Windows.Forms.Button();
            this.AC = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.x = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.Mas = new System.Windows.Forms.Button();
            this.Menos = new System.Windows.Forms.Button();
            this.B0 = new System.Windows.Forms.Button();
            this.Punto = new System.Windows.Forms.Button();
            this.Historial = new System.Windows.Forms.Button();
            this.Ans = new System.Windows.Forms.Button();
            this.Igual = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Show_Historial = new System.Windows.Forms.Panel();
            this.Histo = new System.Windows.Forms.Label();
            this.Borrar_Histo = new System.Windows.Forms.Button();
            this.ButtonsPanel.SuspendLayout();
            this.Show_Historial.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInput
            // 
            this.UserInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInput.Location = new System.Drawing.Point(34, 29);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(312, 22);
            this.UserInput.TabIndex = 0;
            // 
            // Resultado_Calculadora
            // 
            this.Resultado_Calculadora.Location = new System.Drawing.Point(34, 63);
            this.Resultado_Calculadora.Name = "Resultado_Calculadora";
            this.Resultado_Calculadora.Size = new System.Drawing.Size(604, 27);
            this.Resultado_Calculadora.TabIndex = 1;
            this.Resultado_Calculadora.Text = "Enter the Ecuation\r\n";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPanel.ColumnCount = 5;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.Controls.Add(this.B7, 0, 0);
            this.ButtonsPanel.Controls.Add(this.B8, 1, 0);
            this.ButtonsPanel.Controls.Add(this.B9, 2, 0);
            this.ButtonsPanel.Controls.Add(this.DEL, 3, 0);
            this.ButtonsPanel.Controls.Add(this.AC, 4, 0);
            this.ButtonsPanel.Controls.Add(this.B4, 0, 1);
            this.ButtonsPanel.Controls.Add(this.B5, 1, 1);
            this.ButtonsPanel.Controls.Add(this.B6, 2, 1);
            this.ButtonsPanel.Controls.Add(this.x, 3, 1);
            this.ButtonsPanel.Controls.Add(this.Div, 4, 1);
            this.ButtonsPanel.Controls.Add(this.B1, 0, 2);
            this.ButtonsPanel.Controls.Add(this.B2, 1, 2);
            this.ButtonsPanel.Controls.Add(this.B3, 2, 2);
            this.ButtonsPanel.Controls.Add(this.Mas, 3, 2);
            this.ButtonsPanel.Controls.Add(this.Menos, 4, 2);
            this.ButtonsPanel.Controls.Add(this.B0, 0, 3);
            this.ButtonsPanel.Controls.Add(this.Punto, 1, 3);
            this.ButtonsPanel.Controls.Add(this.Historial, 2, 3);
            this.ButtonsPanel.Controls.Add(this.Ans, 3, 3);
            this.ButtonsPanel.Controls.Add(this.Igual, 4, 3);
            this.ButtonsPanel.Location = new System.Drawing.Point(12, 108);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 4;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonsPanel.Size = new System.Drawing.Size(358, 335);
            this.ButtonsPanel.TabIndex = 2;
            // 
            // B7
            // 
            this.B7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B7.Location = new System.Drawing.Point(3, 3);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(65, 77);
            this.B7.TabIndex = 0;
            this.B7.Text = "7";
            this.B7.UseVisualStyleBackColor = true;
            this.B7.Click += new System.EventHandler(this.B7_Click);
            // 
            // B8
            // 
            this.B8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B8.Location = new System.Drawing.Point(74, 3);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(65, 77);
            this.B8.TabIndex = 1;
            this.B8.Text = "8";
            this.B8.UseVisualStyleBackColor = true;
            this.B8.Click += new System.EventHandler(this.B8_Click);
            // 
            // B9
            // 
            this.B9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B9.Location = new System.Drawing.Point(145, 3);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(65, 77);
            this.B9.TabIndex = 2;
            this.B9.Text = "9";
            this.B9.UseVisualStyleBackColor = true;
            this.B9.Click += new System.EventHandler(this.B9_Click);
            // 
            // DEL
            // 
            this.DEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DEL.Location = new System.Drawing.Point(216, 3);
            this.DEL.Name = "DEL";
            this.DEL.Size = new System.Drawing.Size(65, 77);
            this.DEL.TabIndex = 3;
            this.DEL.Text = "DEL";
            this.DEL.UseVisualStyleBackColor = true;
            this.DEL.Click += new System.EventHandler(this.DEL_Click);
            // 
            // AC
            // 
            this.AC.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AC.Location = new System.Drawing.Point(287, 3);
            this.AC.Name = "AC";
            this.AC.Size = new System.Drawing.Size(68, 77);
            this.AC.TabIndex = 4;
            this.AC.Text = "AC";
            this.AC.UseVisualStyleBackColor = true;
            this.AC.Click += new System.EventHandler(this.AC_Click);
            // 
            // B4
            // 
            this.B4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B4.Location = new System.Drawing.Point(3, 86);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(65, 77);
            this.B4.TabIndex = 5;
            this.B4.Text = "4";
            this.B4.UseVisualStyleBackColor = true;
            this.B4.Click += new System.EventHandler(this.B4_Click);
            // 
            // B5
            // 
            this.B5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B5.Location = new System.Drawing.Point(74, 86);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(65, 77);
            this.B5.TabIndex = 6;
            this.B5.Text = "5";
            this.B5.UseVisualStyleBackColor = true;
            this.B5.Click += new System.EventHandler(this.B5_Click);
            // 
            // B6
            // 
            this.B6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B6.Location = new System.Drawing.Point(145, 86);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(65, 77);
            this.B6.TabIndex = 7;
            this.B6.Text = "6";
            this.B6.UseVisualStyleBackColor = true;
            this.B6.Click += new System.EventHandler(this.B6_Click);
            // 
            // x
            // 
            this.x.Dock = System.Windows.Forms.DockStyle.Fill;
            this.x.Location = new System.Drawing.Point(216, 86);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(65, 77);
            this.x.TabIndex = 8;
            this.x.Text = "x";
            this.x.UseVisualStyleBackColor = true;
            this.x.Click += new System.EventHandler(this.x_Click);
            // 
            // Div
            // 
            this.Div.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Div.Location = new System.Drawing.Point(287, 86);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(68, 77);
            this.Div.TabIndex = 9;
            this.Div.Text = "%";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // B1
            // 
            this.B1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B1.Location = new System.Drawing.Point(3, 169);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(65, 77);
            this.B1.TabIndex = 10;
            this.B1.Text = "1";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // B2
            // 
            this.B2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B2.Location = new System.Drawing.Point(74, 169);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(65, 77);
            this.B2.TabIndex = 11;
            this.B2.Text = "2";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // B3
            // 
            this.B3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B3.Location = new System.Drawing.Point(145, 169);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(65, 77);
            this.B3.TabIndex = 12;
            this.B3.Text = "3";
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // Mas
            // 
            this.Mas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mas.Location = new System.Drawing.Point(216, 169);
            this.Mas.Name = "Mas";
            this.Mas.Size = new System.Drawing.Size(65, 77);
            this.Mas.TabIndex = 13;
            this.Mas.Text = "+";
            this.Mas.UseVisualStyleBackColor = true;
            this.Mas.Click += new System.EventHandler(this.Mas_Click);
            // 
            // Menos
            // 
            this.Menos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menos.Location = new System.Drawing.Point(287, 169);
            this.Menos.Name = "Menos";
            this.Menos.Size = new System.Drawing.Size(68, 77);
            this.Menos.TabIndex = 14;
            this.Menos.Text = "-";
            this.Menos.UseVisualStyleBackColor = true;
            this.Menos.Click += new System.EventHandler(this.Menos_Click);
            // 
            // B0
            // 
            this.B0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B0.Location = new System.Drawing.Point(3, 252);
            this.B0.Name = "B0";
            this.B0.Size = new System.Drawing.Size(65, 80);
            this.B0.TabIndex = 15;
            this.B0.Text = "0";
            this.B0.UseVisualStyleBackColor = true;
            this.B0.Click += new System.EventHandler(this.B0_Click);
            // 
            // Punto
            // 
            this.Punto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Punto.Location = new System.Drawing.Point(74, 252);
            this.Punto.Name = "Punto";
            this.Punto.Size = new System.Drawing.Size(65, 80);
            this.Punto.TabIndex = 16;
            this.Punto.Text = ".";
            this.Punto.UseVisualStyleBackColor = true;
            this.Punto.Click += new System.EventHandler(this.Punto_Click);
            // 
            // Historial
            // 
            this.Historial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Historial.Location = new System.Drawing.Point(145, 252);
            this.Historial.Name = "Historial";
            this.Historial.Size = new System.Drawing.Size(65, 80);
            this.Historial.TabIndex = 17;
            this.Historial.Text = "Hist";
            this.Historial.UseVisualStyleBackColor = true;
            this.Historial.Click += new System.EventHandler(this.button18_Click);
            // 
            // Ans
            // 
            this.Ans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ans.Location = new System.Drawing.Point(216, 252);
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(65, 80);
            this.Ans.TabIndex = 18;
            this.Ans.Text = "Ans";
            this.Ans.UseVisualStyleBackColor = true;
            this.Ans.Click += new System.EventHandler(this.Ans_Click);
            // 
            // Igual
            // 
            this.Igual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Igual.Location = new System.Drawing.Point(287, 252);
            this.Igual.Name = "Igual";
            this.Igual.Size = new System.Drawing.Size(68, 80);
            this.Igual.TabIndex = 19;
            this.Igual.Text = "=";
            this.Igual.UseVisualStyleBackColor = true;
            this.Igual.Click += new System.EventHandler(this.Igual_Click);
            // 
            // Show_Historial
            // 
            this.Show_Historial.Controls.Add(this.Borrar_Histo);
            this.Show_Historial.Controls.Add(this.Histo);
            this.Show_Historial.Location = new System.Drawing.Point(15, 9);
            this.Show_Historial.Name = "Show_Historial";
            this.Show_Historial.Size = new System.Drawing.Size(355, 431);
            this.Show_Historial.TabIndex = 3;
            this.Show_Historial.Visible = false;
            this.Show_Historial.Click += new System.EventHandler(this.Show_Historial_Click);
            this.Show_Historial.Paint += new System.Windows.Forms.PaintEventHandler(this.Show_Historial_Paint);
            // 
            // Histo
            // 
            this.Histo.AutoSize = true;
            this.Histo.Location = new System.Drawing.Point(27, 28);
            this.Histo.Name = "Histo";
            this.Histo.Size = new System.Drawing.Size(40, 17);
            this.Histo.TabIndex = 0;
            this.Histo.Text = "Histo";
            this.Histo.Click += new System.EventHandler(this.Histo_Click);
            // 
            // Borrar_Histo
            // 
            this.Borrar_Histo.Location = new System.Drawing.Point(222, 402);
            this.Borrar_Histo.Name = "Borrar_Histo";
            this.Borrar_Histo.Size = new System.Drawing.Size(130, 26);
            this.Borrar_Histo.TabIndex = 1;
            this.Borrar_Histo.Text = "Borrar_Historial";
            this.Borrar_Histo.UseVisualStyleBackColor = true;
            this.Borrar_Histo.Click += new System.EventHandler(this.Borrar_Histo_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Igual;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.AC;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.Show_Historial);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.Resultado_Calculadora);
            this.Controls.Add(this.UserInput);
            this.MinimumSize = new System.Drawing.Size(400, 480);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ButtonsPanel.ResumeLayout(false);
            this.Show_Historial.ResumeLayout(false);
            this.Show_Historial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.Label Resultado_Calculadora;
        private System.Windows.Forms.TableLayoutPanel ButtonsPanel;
        private System.Windows.Forms.Button B7;
        private System.Windows.Forms.Button B8;
        private System.Windows.Forms.Button B9;
        private System.Windows.Forms.Button DEL;
        private System.Windows.Forms.Button AC;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Button B6;
        private System.Windows.Forms.Button x;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button Mas;
        private System.Windows.Forms.Button Menos;
        private System.Windows.Forms.Button B0;
        private System.Windows.Forms.Button Punto;
        private System.Windows.Forms.Button Historial;
        private System.Windows.Forms.Button Ans;
        private System.Windows.Forms.Button Igual;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel Show_Historial;
        private System.Windows.Forms.Label Histo;
        private System.Windows.Forms.Button Borrar_Histo;
    }
}

