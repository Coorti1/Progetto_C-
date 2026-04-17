namespace Progetto_C_
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            lblProcedimento = new Label();
            lblIngredienti = new Label();
            lblNome = new Label();
            SuspendLayout();
            // 
            // lblProcedimento
            // 
            lblProcedimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProcedimento.Location = new Point(264, 172);
            lblProcedimento.Name = "lblProcedimento";
            lblProcedimento.RightToLeft = RightToLeft.No;
            lblProcedimento.Size = new Size(1179, 251);
            lblProcedimento.TabIndex = 10;
            lblProcedimento.Text = resources.GetString("lblProcedimento.Text");
            // 
            // lblIngredienti
            // 
            lblIngredienti.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIngredienti.Location = new Point(3, 172);
            lblIngredienti.Name = "lblIngredienti";
            lblIngredienti.RightToLeft = RightToLeft.No;
            lblIngredienti.Size = new Size(229, 208);
            lblIngredienti.TabIndex = 9;
            lblIngredienti.Text = "INGREDIENTI (7-8 persone):\r\n\r\n\r\n- Mascarpone (500g)\r\n- Savoiardi (300-400g)\r\n- 4-5 Uova\r\n- Zucchero (120g)\r\n- Caffè (300-400ml)\r\n- Cacao in polvere\r\n";
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(3, 28);
            lblNome.Name = "lblNome";
            lblNome.RightToLeft = RightToLeft.No;
            lblNome.Size = new Size(597, 124);
            lblNome.TabIndex = 8;
            lblNome.Text = "RICETTA FRITTELLA";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 450);
            Controls.Add(lblProcedimento);
            Controls.Add(lblIngredienti);
            Controls.Add(lblNome);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
        }

        #endregion

        private Label lblProcedimento;
        private Label lblIngredienti;
        private Label lblNome;
    }
}