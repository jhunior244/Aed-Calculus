namespace AED_Calculus
{
    partial class frmCalculus
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
            this.button1 = new System.Windows.Forms.Button();
            this.textVolume = new System.Windows.Forms.TextBox();
            this.textFundo = new System.Windows.Forms.TextBox();
            this.textLado = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.labelArea = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.drawPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.textLado);
            this.panel1.Controls.Add(this.textFundo);
            this.panel1.Controls.Add(this.textVolume);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(797, 0);
            this.panel1.Size = new System.Drawing.Size(219, 469);
            this.panel1.Controls.SetChildIndex(this.button1, 0);
            this.panel1.Controls.SetChildIndex(this.textVolume, 0);
            this.panel1.Controls.SetChildIndex(this.textFundo, 0);
            this.panel1.Controls.SetChildIndex(this.textLado, 0);
            this.panel1.Controls.SetChildIndex(this.btnLimpar, 0);
            // 
            // drawPanel
            // 
            this.drawPanel.Controls.Add(this.labelArea);
            this.drawPanel.Controls.Add(this.button3);
            this.drawPanel.Controls.Add(this.txtY);
            this.drawPanel.Controls.Add(this.txtX);
            this.drawPanel.Controls.Add(this.button2);
            this.drawPanel.Controls.Add(this.richTextBox1);
            this.drawPanel.Size = new System.Drawing.Size(797, 469);
            this.drawPanel.Controls.SetChildIndex(this.richTextBox1, 0);
            this.drawPanel.Controls.SetChildIndex(this.button2, 0);
            this.drawPanel.Controls.SetChildIndex(this.txtX, 0);
            this.drawPanel.Controls.SetChildIndex(this.txtY, 0);
            this.drawPanel.Controls.SetChildIndex(this.button3, 0);
            this.drawPanel.Controls.SetChildIndex(this.labelArea, 0);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(20, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "GERAR GRAFICO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textVolume
            // 
            this.textVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVolume.Location = new System.Drawing.Point(22, 144);
            this.textVolume.Name = "textVolume";
            this.textVolume.Size = new System.Drawing.Size(180, 31);
            this.textVolume.TabIndex = 7;
            this.textVolume.Text = "VOLUME";
            this.textVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textVolume.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textVolume_MouseClick);
            // 
            // textFundo
            // 
            this.textFundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFundo.Location = new System.Drawing.Point(22, 181);
            this.textFundo.Name = "textFundo";
            this.textFundo.Size = new System.Drawing.Size(180, 31);
            this.textFundo.TabIndex = 9;
            this.textFundo.Text = "FUNDO";
            this.textFundo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textFundo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textFundo_MouseClick);
            // 
            // textLado
            // 
            this.textLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLado.Location = new System.Drawing.Point(22, 218);
            this.textLado.Name = "textLado";
            this.textLado.Size = new System.Drawing.Size(180, 31);
            this.textLado.TabIndex = 11;
            this.textLado.Tag = "Foram enviados total de 124 e-mails para a lista R-006406 - BAIXAS 19/10/2018, co" +
    "nforme validação e autorização de envio do requisitante.";
            this.textLado.Text = "LARGURA";
            this.textLado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textLado_MouseClick);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Black;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpar.Location = new System.Drawing.Point(22, 255);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(182, 38);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(163, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(204, 406);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(163, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "LIMPAR HISTORICO";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(12, 62);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 13;
            this.txtX.Text = "X";
            this.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtX_MouseClick);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(12, 92);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 14;
            this.txtY.Text = "F(X)";
            this.txtY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtY.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtY_MouseClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(12, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 33);
            this.button3.TabIndex = 13;
            this.button3.Text = "CALCULAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.BackColor = System.Drawing.Color.Transparent;
            this.labelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArea.ForeColor = System.Drawing.Color.Red;
            this.labelArea.Location = new System.Drawing.Point(13, 45);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(0, 16);
            this.labelArea.TabIndex = 15;
            // 
            // frmCalculus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1016, 469);
            this.Name = "frmCalculus";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.drawPanel.ResumeLayout(false);
            this.drawPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textFundo;
        private System.Windows.Forms.TextBox textVolume;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textLado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label labelArea;
    }
}
