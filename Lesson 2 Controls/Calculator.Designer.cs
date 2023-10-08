namespace Lesson_2_Controls
{
    partial class Calculator
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
            sifir = new Button();
            noqte = new Button();
            dord = new Button();
            bir = new Button();
            iki = new Button();
            yeddi = new Button();
            uc = new Button();
            beraber = new Button();
            plus = new Button();
            bol = new Button();
            minus = new Button();
            vur = new Button();
            alti = new Button();
            doqquz = new Button();
            sekkiz = new Button();
            bes = new Button();
            textBox1 = new TextBox();
            C = new Button();
            SuspendLayout();
            // 
            // sifir
            // 
            sifir.BackColor = Color.White;
            sifir.Location = new Point(12, 380);
            sifir.Name = "sifir";
            sifir.Size = new Size(146, 70);
            sifir.TabIndex = 0;
            sifir.Text = "0";
            sifir.UseVisualStyleBackColor = false;
            sifir.Click += sifir_Click;
            sifir.MouseLeave += sifir_MouseLeave;
            sifir.MouseHover += sifir_MouseHover;
            // 
            // noqte
            // 
            noqte.Location = new Point(164, 380);
            noqte.Name = "noqte";
            noqte.Size = new Size(70, 70);
            noqte.TabIndex = 1;
            noqte.Text = ".";
            noqte.UseVisualStyleBackColor = true;
            noqte.Click += noqte_Click;
            noqte.MouseLeave += noqte_MouseLeave;
            noqte.MouseHover += noqte_MouseHover;
            // 
            // dord
            // 
            dord.Location = new Point(12, 228);
            dord.Name = "dord";
            dord.Size = new Size(70, 70);
            dord.TabIndex = 2;
            dord.Text = "4";
            dord.UseVisualStyleBackColor = true;
            dord.Click += dord_Click;
            dord.MouseLeave += dord_MouseLeave;
            dord.MouseHover += dord_MouseHover;
            // 
            // bir
            // 
            bir.Location = new Point(12, 304);
            bir.Name = "bir";
            bir.Size = new Size(70, 70);
            bir.TabIndex = 3;
            bir.Text = "1";
            bir.UseVisualStyleBackColor = true;
            bir.Click += bir_Click;
            bir.MouseLeave += bir_MouseLeave;
            bir.MouseHover += bir_MouseHover;
            // 
            // iki
            // 
            iki.Location = new Point(88, 304);
            iki.Name = "iki";
            iki.Size = new Size(70, 70);
            iki.TabIndex = 4;
            iki.Text = "2";
            iki.UseVisualStyleBackColor = true;
            iki.Click += iki_Click;
            iki.MouseLeave += iki_MouseLeave;
            iki.MouseHover += iki_MouseHover;
            // 
            // yeddi
            // 
            yeddi.Location = new Point(12, 152);
            yeddi.Name = "yeddi";
            yeddi.Size = new Size(70, 70);
            yeddi.TabIndex = 5;
            yeddi.Text = "7";
            yeddi.UseVisualStyleBackColor = true;
            yeddi.Click += yeddi_Click;
            yeddi.MouseLeave += yeddi_MouseLeave;
            yeddi.MouseHover += yeddi_MouseHover;
            // 
            // uc
            // 
            uc.Location = new Point(164, 304);
            uc.Name = "uc";
            uc.Size = new Size(70, 70);
            uc.TabIndex = 6;
            uc.Text = "3";
            uc.UseVisualStyleBackColor = true;
            uc.Click += uc_Click;
            uc.MouseLeave += uc_MouseLeave;
            uc.MouseHover += uc_MouseHover;
            // 
            // beraber
            // 
            beraber.BackColor = Color.MediumTurquoise;
            beraber.Location = new Point(316, 304);
            beraber.Name = "beraber";
            beraber.Size = new Size(70, 146);
            beraber.TabIndex = 7;
            beraber.Text = "=";
            beraber.UseVisualStyleBackColor = false;
            beraber.Click += beraber_Click;
            beraber.MouseLeave += beraber_MouseLeave;
            beraber.MouseHover += beraber_MouseHover;
            // 
            // plus
            // 
            plus.Location = new Point(240, 380);
            plus.Name = "plus";
            plus.Size = new Size(70, 70);
            plus.TabIndex = 8;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            plus.MouseLeave += plus_MouseLeave;
            plus.MouseHover += plus_MouseHover;
            // 
            // bol
            // 
            bol.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bol.ForeColor = SystemColors.ActiveCaptionText;
            bol.Location = new Point(240, 152);
            bol.Name = "bol";
            bol.Size = new Size(70, 70);
            bol.TabIndex = 9;
            bol.Text = "/";
            bol.UseVisualStyleBackColor = true;
            bol.Click += bol_Click;
            bol.MouseLeave += bol_MouseLeave;
            bol.MouseHover += bol_MouseHover;
            // 
            // minus
            // 
            minus.Location = new Point(240, 304);
            minus.Name = "minus";
            minus.Size = new Size(70, 70);
            minus.TabIndex = 10;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_Click;
            minus.MouseLeave += minus_MouseLeave;
            minus.MouseHover += minus_MouseHover;
            // 
            // vur
            // 
            vur.Location = new Point(240, 228);
            vur.Name = "vur";
            vur.Size = new Size(70, 70);
            vur.TabIndex = 11;
            vur.Text = "*";
            vur.UseVisualStyleBackColor = true;
            vur.Click += vur_Click;
            vur.MouseLeave += vur_MouseLeave;
            vur.MouseHover += vur_MouseHover;
            // 
            // alti
            // 
            alti.Location = new Point(164, 228);
            alti.Name = "alti";
            alti.Size = new Size(70, 70);
            alti.TabIndex = 12;
            alti.Text = "6";
            alti.UseVisualStyleBackColor = true;
            alti.Click += alti_Click;
            alti.MouseLeave += alti_MouseLeave;
            alti.MouseHover += alti_MouseHover;
            // 
            // doqquz
            // 
            doqquz.Location = new Point(164, 152);
            doqquz.Name = "doqquz";
            doqquz.Size = new Size(70, 70);
            doqquz.TabIndex = 13;
            doqquz.Text = "9";
            doqquz.UseVisualStyleBackColor = true;
            doqquz.Click += doqquz_Click;
            doqquz.MouseLeave += doqquz_MouseLeave;
            doqquz.MouseHover += doqquz_MouseHover;
            // 
            // sekkiz
            // 
            sekkiz.Location = new Point(88, 152);
            sekkiz.Name = "sekkiz";
            sekkiz.Size = new Size(70, 70);
            sekkiz.TabIndex = 14;
            sekkiz.Text = "8";
            sekkiz.UseVisualStyleBackColor = true;
            sekkiz.Click += sekkiz_Click;
            sekkiz.MouseLeave += sekkiz_MouseLeave;
            sekkiz.MouseHover += sekkiz_MouseHover;
            // 
            // bes
            // 
            bes.Location = new Point(88, 228);
            bes.Name = "bes";
            bes.Size = new Size(70, 70);
            bes.TabIndex = 15;
            bes.Text = "5";
            bes.UseVisualStyleBackColor = true;
            bes.Click += bes_Click;
            bes.MouseLeave += bes_MouseLeave;
            bes.MouseHover += bes_MouseHover;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.PaleTurquoise;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("A1-Lat", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 105);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(374, 41);
            textBox1.TabIndex = 16;
            textBox1.Text = "0";
            // 
            // C
            // 
            C.BackColor = Color.MediumTurquoise;
            C.Location = new Point(316, 228);
            C.Name = "C";
            C.Size = new Size(70, 70);
            C.TabIndex = 17;
            C.Text = "C";
            C.UseVisualStyleBackColor = false;
            C.Click += C_Click;
            C.MouseLeave += C_MouseLeave;
            C.MouseHover += C_MouseHover;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(398, 456);
            Controls.Add(C);
            Controls.Add(textBox1);
            Controls.Add(bes);
            Controls.Add(sekkiz);
            Controls.Add(doqquz);
            Controls.Add(alti);
            Controls.Add(vur);
            Controls.Add(minus);
            Controls.Add(bol);
            Controls.Add(plus);
            Controls.Add(beraber);
            Controls.Add(uc);
            Controls.Add(yeddi);
            Controls.Add(iki);
            Controls.Add(bir);
            Controls.Add(dord);
            Controls.Add(noqte);
            Controls.Add(sifir);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sifir;
        private Button noqte;
        private Button dord;
        private Button bir;
        private Button iki;
        private Button yeddi;
        private Button uc;
        private Button beraber;
        private Button plus;
        private Button bol;
        private Button minus;
        private Button vur;
        private Button alti;
        private Button doqquz;
        private Button sekkiz;
        private Button bes;
        private TextBox textBox1;
        private Button C;
    }
}