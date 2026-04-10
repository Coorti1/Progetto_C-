namespace Progetto_C_
{
    partial class Form1
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
            button1 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(668, 390);
            button1.Name = "button1";
            button1.Size = new Size(107, 48);
            button1.TabIndex = 0;
            button1.Text = "Lista della Spesa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "\t", "", "\t\tTiramisù", "\t\tBrioche", "\t\tFrittella", "\t\tCheesecake", "\t\tPlumcake", "\t\tCrostata", "\t\tBiscotti", "\t\tPandoro", "\t\tCiccioCake" });
            listBox1.Location = new Point(266, 146);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(283, 197);
            listBox1.TabIndex = 1;
            listBox1.UseWaitCursor = true;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(301, 19);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(224, 124);
            label1.TabIndex = 2;
            label1.Text = "MENU";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Label label1;
    }
}
