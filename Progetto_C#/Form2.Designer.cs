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
            lblProcedimento = new Label();
            listBox1 = new ListBox();
            label1 = new Label();
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
            // lblProcedimento
            // 
            lblProcedimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProcedimento.Location = new Point(273, 143);
            lblProcedimento.Name = "lblProcedimento";
            lblProcedimento.RightToLeft = RightToLeft.No;
            lblProcedimento.Size = new Size(1179, 251);
            lblProcedimento.TabIndex = 7;
            lblProcedimento.Text = resources.GetString("lblProcedimento.Text");
            lblProcedimento.Click += lblProcedimento_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Mascarpone (500g)", "Savoiardi (300-400g)", "4-5 Uova", "Zucchero (120g)", "Caffè (300-400ml)", "Cacao in polvere" });
            listBox1.Location = new Point(25, 179);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(143, 109);
            listBox1.TabIndex = 21;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 143);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(229, 208);
            label1.TabIndex = 20;
            label1.Text = "INGREDIENTI:";
            label1.Click += label1_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1489, 450);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(lblProcedimento);
            Controls.Add(lblNome);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion
        private Label lblNome;
        private Label lblProcedimento;
        private ListBox listBox1;
        private Label label1;
    }
}