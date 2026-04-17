namespace Progetto_C_
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            lblNome = new Label();
            lblIngredienti = new Label();
            lblProcedimento = new Label();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(12, -1);
            lblNome.Name = "lblNome";
            lblNome.RightToLeft = RightToLeft.No;
            lblNome.Size = new Size(597, 124);
            lblNome.TabIndex = 3;
            lblNome.Text = "RICETTA TIRAMISU'";
            lblNome.Click += label1_Click;
            // 
            // lblIngredienti
            // 
            lblIngredienti.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIngredienti.Location = new Point(12, 143);
            lblIngredienti.Name = "lblIngredienti";
            lblIngredienti.RightToLeft = RightToLeft.No;
            lblIngredienti.Size = new Size(229, 208);
            lblIngredienti.TabIndex = 6;
            lblIngredienti.Text = "INGREDIENTI (7-8 persone):\r\n\r\n\r\n- Mascarpone (500g)\r\n- Savoiardi (300-400g)\r\n- 4-5 Uova\r\n- Zucchero (120g)\r\n- Caffè (300-400ml)\r\n- Cacao in polvere\r\n";
            lblIngredienti.Click += label2_Click;
            // 
            // lblProcedimento
            // 
            lblProcedimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProcedimento.Location = new Point(273, 143);
            lblProcedimento.Name = "lblProcedimento";
            lblProcedimento.RightToLeft = RightToLeft.No;
            lblProcedimento.Size = new Size(1179, 251);
            lblProcedimento.TabIndex = 7;
            lblProcedimento.Text = resources.GetString("lblProcedimento.Text");
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1489, 450);
            Controls.Add(lblProcedimento);
            Controls.Add(lblIngredienti);
            Controls.Add(lblNome);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion
        private Label lblNome;
        private Label lblIngredienti;
        private Label lblProcedimento;
    }
}