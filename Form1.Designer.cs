namespace randomnumber
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
            components = new System.ComponentModel.Container();
            ededAxtarisiGrp = new GroupBox();
            yoxlaBtn = new Button();
            axtarilanEdedTxt = new TextBox();
            axtarilanEdedLbl = new Label();
            neticeTxt = new TextBox();
            yenioyunBtn = new Button();
            errorProvider = new ErrorProvider(components);
            ededAxtarisiGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // ededAxtarisiGrp
            // 
            ededAxtarisiGrp.Controls.Add(yoxlaBtn);
            ededAxtarisiGrp.Controls.Add(axtarilanEdedTxt);
            ededAxtarisiGrp.Controls.Add(axtarilanEdedLbl);
            ededAxtarisiGrp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ededAxtarisiGrp.ForeColor = Color.White;
            ededAxtarisiGrp.Location = new Point(46, 62);
            ededAxtarisiGrp.Name = "ededAxtarisiGrp";
            ededAxtarisiGrp.Size = new Size(357, 355);
            ededAxtarisiGrp.TabIndex = 0;
            ededAxtarisiGrp.TabStop = false;
            ededAxtarisiGrp.Text = "Ədəd axtarışı";
            // 
            // yoxlaBtn
            // 
            yoxlaBtn.ForeColor = Color.Black;
            yoxlaBtn.Location = new Point(50, 261);
            yoxlaBtn.Name = "yoxlaBtn";
            yoxlaBtn.Size = new Size(252, 54);
            yoxlaBtn.TabIndex = 2;
            yoxlaBtn.Text = "Yoxla";
            yoxlaBtn.UseVisualStyleBackColor = true;
            yoxlaBtn.Click += yoxlaBtn_Click;
            // 
            // axtarilanEdedTxt
            // 
            axtarilanEdedTxt.Location = new Point(50, 144);
            axtarilanEdedTxt.Name = "axtarilanEdedTxt";
            axtarilanEdedTxt.Size = new Size(222, 34);
            axtarilanEdedTxt.TabIndex = 1;
            // 
            // axtarilanEdedLbl
            // 
            axtarilanEdedLbl.AutoSize = true;
            axtarilanEdedLbl.Font = new Font("Segoe UI", 11F);
            axtarilanEdedLbl.Location = new Point(50, 99);
            axtarilanEdedLbl.Name = "axtarilanEdedLbl";
            axtarilanEdedLbl.Size = new Size(134, 25);
            axtarilanEdedLbl.TabIndex = 0;
            axtarilanEdedLbl.Text = "Axtarılan ədəd";
            // 
            // neticeTxt
            // 
            neticeTxt.Location = new Point(446, 62);
            neticeTxt.Multiline = true;
            neticeTxt.Name = "neticeTxt";
            neticeTxt.Size = new Size(327, 269);
            neticeTxt.TabIndex = 1;
            neticeTxt.TextChanged += textBox2_TextChanged;
            // 
            // yenioyunBtn
            // 
            yenioyunBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yenioyunBtn.ForeColor = Color.Black;
            yenioyunBtn.Location = new Point(446, 363);
            yenioyunBtn.Name = "yenioyunBtn";
            yenioyunBtn.Size = new Size(327, 54);
            yenioyunBtn.TabIndex = 3;
            yenioyunBtn.Text = "Yeni oyun";
            yenioyunBtn.UseVisualStyleBackColor = true;
            yenioyunBtn.Click += yenioyunBtn_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(yenioyunBtn);
            Controls.Add(neticeTxt);
            Controls.Add(ededAxtarisiGrp);
            Name = "Form1";
            Text = "Form1";
            ededAxtarisiGrp.ResumeLayout(false);
            ededAxtarisiGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox ededAxtarisiGrp;
        private Button yoxlaBtn;
        private TextBox axtarilanEdedTxt;
        private Label axtarilanEdedLbl;
        private TextBox neticeTxt;
        private Button yenioyunBtn;
        private ErrorProvider errorProvider;
    }
}
