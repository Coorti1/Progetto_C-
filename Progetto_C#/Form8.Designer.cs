namespace Progetto_C_
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            lblProcedimento = new Label();
            lblIngredienti = new Label();
            lblNome = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // lblProcedimento
            // 
            lblProcedimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProcedimento.Location = new Point(269, 172);
            lblProcedimento.Name = "lblProcedimento";
            lblProcedimento.RightToLeft = RightToLeft.No;
            lblProcedimento.Size = new Size(1179, 306);
            lblProcedimento.TabIndex = 10;
            lblProcedimento.Text = resources.GetString("lblProcedimento.Text");
            // 
            // lblIngredienti
            // 
            lblIngredienti.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIngredienti.Location = new Point(8, 172);
            lblIngredienti.Name = "lblIngredienti";
            lblIngredienti.RightToLeft = RightToLeft.No;
            lblIngredienti.Size = new Size(229, 208);
            lblIngredienti.TabIndex = 9;
            lblIngredienti.Text = "INGREDIENTI:";
            lblIngredienti.Click += lblIngredienti_Click;
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(8, 28);
            lblNome.Name = "lblNome";
            lblNome.RightToLeft = RightToLeft.No;
            lblNome.Size = new Size(597, 124);
            lblNome.TabIndex = 8;
            lblNome.Text = "RICETTA BISCOTTI";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Farina 00", "Burro freddo", "Zucchero a velo", "Tuorli d'uovo", "Estratto di vaniglia", "Scorza di limone", "Sale" });
            listBox1.Location = new Point(8, 208);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(118, 124);
            listBox1.TabIndex = 11;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1457, 496);
            Controls.Add(listBox1);
            Controls.Add(lblProcedimento);
            Controls.Add(lblIngredienti);
            Controls.Add(lblNome);
            Name = "Form8";
            Text = "Form8";
            ResumeLayout(false);
        }

        #endregion

        private Label lblProcedimento;
        private Label lblIngredienti;
        private Label lblNome;
        private ListBox listBox1;
    }
}