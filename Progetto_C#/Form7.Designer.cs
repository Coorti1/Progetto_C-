namespace Progetto_C_
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            lblProcedimento = new Label();
            lblNome = new Label();
            listBox1 = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblProcedimento
            // 
            lblProcedimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProcedimento.Location = new Point(277, 172);
            lblProcedimento.Name = "lblProcedimento";
            lblProcedimento.RightToLeft = RightToLeft.No;
            lblProcedimento.Size = new Size(1179, 322);
            lblProcedimento.TabIndex = 10;
            lblProcedimento.Text = resources.GetString("lblProcedimento.Text");
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(16, 28);
            lblNome.Name = "lblNome";
            lblNome.RightToLeft = RightToLeft.No;
            lblNome.Size = new Size(597, 124);
            lblNome.TabIndex = 8;
            lblNome.Text = "RICETTA CROSTATA";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Farina 00", "Burro freddo", "Zucchero", "Uova", "Marmellata", "Scorza di limone grattugiata", "Sale" });
            listBox1.Location = new Point(16, 208);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(118, 124);
            listBox1.TabIndex = 13;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 172);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(229, 208);
            label1.TabIndex = 12;
            label1.Text = "INGREDIENTI:";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 513);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(lblProcedimento);
            Controls.Add(lblNome);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
        }

        #endregion

        private Label lblProcedimento;
        private Label lblNome;
        private ListBox listBox1;
        private Label label1;
    }
}