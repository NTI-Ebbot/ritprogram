
namespace ritboken
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
            this.pxbPaper = new System.Windows.Forms.PictureBox();
            this.grbCurrentTool = new System.Windows.Forms.GroupBox();
            this.lblWeigth = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.pbxCurrentColor = new System.Windows.Forms.PictureBox();
            this.nupLineWeigth = new System.Windows.Forms.NumericUpDown();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.grbShapes = new System.Windows.Forms.GroupBox();
            this.btnElipse = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.grbOther = new System.Windows.Forms.GroupBox();
            this.chkFilled = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pxbPaper)).BeginInit();
            this.grbCurrentTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCurrentColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupLineWeigth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.grbShapes.SuspendLayout();
            this.grbOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // pxbPaper
            // 
            this.pxbPaper.Location = new System.Drawing.Point(222, 12);
            this.pxbPaper.Name = "pxbPaper";
            this.pxbPaper.Size = new System.Drawing.Size(679, 426);
            this.pxbPaper.TabIndex = 0;
            this.pxbPaper.TabStop = false;
            this.pxbPaper.Paint += new System.Windows.Forms.PaintEventHandler(this.pxbPaper_Paint);
            this.pxbPaper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pxbPaper_MouseDown);
            this.pxbPaper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pxbPaper_MouseMove);
            this.pxbPaper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pxbPaper_MouseUp);
            // 
            // grbCurrentTool
            // 
            this.grbCurrentTool.Controls.Add(this.lblWeigth);
            this.grbCurrentTool.Controls.Add(this.lblColor);
            this.grbCurrentTool.Controls.Add(this.pbxCurrentColor);
            this.grbCurrentTool.Controls.Add(this.nupLineWeigth);
            this.grbCurrentTool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grbCurrentTool.Location = new System.Drawing.Point(13, 94);
            this.grbCurrentTool.Name = "grbCurrentTool";
            this.grbCurrentTool.Size = new System.Drawing.Size(190, 98);
            this.grbCurrentTool.TabIndex = 1;
            this.grbCurrentTool.TabStop = false;
            this.grbCurrentTool.Text = "Verktygsinställningar";
            // 
            // lblWeigth
            // 
            this.lblWeigth.AutoSize = true;
            this.lblWeigth.Location = new System.Drawing.Point(113, 57);
            this.lblWeigth.Name = "lblWeigth";
            this.lblWeigth.Size = new System.Drawing.Size(57, 15);
            this.lblWeigth.TabIndex = 3;
            this.lblWeigth.Text = "Tjocklek";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(7, 57);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 15);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Färg";
            // 
            // pbxCurrentColor
            // 
            this.pbxCurrentColor.BackColor = System.Drawing.SystemColors.Control;
            this.pbxCurrentColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCurrentColor.Location = new System.Drawing.Point(7, 22);
            this.pbxCurrentColor.Name = "pbxCurrentColor";
            this.pbxCurrentColor.Size = new System.Drawing.Size(37, 32);
            this.pbxCurrentColor.TabIndex = 1;
            this.pbxCurrentColor.TabStop = false;
            this.pbxCurrentColor.Click += new System.EventHandler(this.pbxCurrentColor_Click);
            // 
            // nupLineWeigth
            // 
            this.nupLineWeigth.Location = new System.Drawing.Point(118, 22);
            this.nupLineWeigth.Name = "nupLineWeigth";
            this.nupLineWeigth.Size = new System.Drawing.Size(53, 23);
            this.nupLineWeigth.TabIndex = 0;
            this.nupLineWeigth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackgroundImage = global::ritboken.Properties.Resources.logo;
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxLogo.Location = new System.Drawing.Point(14, 13);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(189, 75);
            this.pbxLogo.TabIndex = 3;
            this.pbxLogo.TabStop = false;
            // 
            // grbShapes
            // 
            this.grbShapes.Controls.Add(this.chkFilled);
            this.grbShapes.Controls.Add(this.btnElipse);
            this.grbShapes.Controls.Add(this.btnRectangle);
            this.grbShapes.Controls.Add(this.btnLine);
            this.grbShapes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grbShapes.Location = new System.Drawing.Point(13, 198);
            this.grbShapes.Name = "grbShapes";
            this.grbShapes.Size = new System.Drawing.Size(190, 156);
            this.grbShapes.TabIndex = 4;
            this.grbShapes.TabStop = false;
            this.grbShapes.Text = "Former";
            // 
            // btnElipse
            // 
            this.btnElipse.BackColor = System.Drawing.Color.White;
            this.btnElipse.Location = new System.Drawing.Point(9, 114);
            this.btnElipse.Name = "btnElipse";
            this.btnElipse.Size = new System.Drawing.Size(86, 23);
            this.btnElipse.TabIndex = 2;
            this.btnElipse.Text = "Elips";
            this.btnElipse.UseVisualStyleBackColor = false;
            this.btnElipse.Click += new System.EventHandler(this.btnElipse_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.White;
            this.btnRectangle.Location = new System.Drawing.Point(9, 76);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(86, 23);
            this.btnRectangle.TabIndex = 1;
            this.btnRectangle.Text = "Rektangel";
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.LightBlue;
            this.btnLine.Location = new System.Drawing.Point(8, 23);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(86, 23);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "Linje";
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.White;
            this.btnUndo.Location = new System.Drawing.Point(8, 22);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(86, 23);
            this.btnUndo.TabIndex = 5;
            this.btnUndo.Text = "Ångra";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // grbOther
            // 
            this.grbOther.Controls.Add(this.btnUndo);
            this.grbOther.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grbOther.Location = new System.Drawing.Point(14, 360);
            this.grbOther.Name = "grbOther";
            this.grbOther.Size = new System.Drawing.Size(189, 78);
            this.grbOther.TabIndex = 6;
            this.grbOther.TabStop = false;
            this.grbOther.Text = "Annat";
            // 
            // chkFilled
            // 
            this.chkFilled.AutoSize = true;
            this.chkFilled.Location = new System.Drawing.Point(112, 79);
            this.chkFilled.Name = "chkFilled";
            this.chkFilled.Size = new System.Drawing.Size(58, 19);
            this.chkFilled.TabIndex = 3;
            this.chkFilled.Text = "Ifylld";
            this.chkFilled.UseVisualStyleBackColor = true;
            this.chkFilled.CheckedChanged += new System.EventHandler(this.chkFilled_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.grbOther);
            this.Controls.Add(this.grbShapes);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.grbCurrentTool);
            this.Controls.Add(this.pxbPaper);
            this.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Chill Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pxbPaper)).EndInit();
            this.grbCurrentTool.ResumeLayout(false);
            this.grbCurrentTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCurrentColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupLineWeigth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.grbShapes.ResumeLayout(false);
            this.grbShapes.PerformLayout();
            this.grbOther.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pxbPaper;
        private System.Windows.Forms.GroupBox grbCurrentTool;
        private System.Windows.Forms.NumericUpDown nupLineWeigth;
        private System.Windows.Forms.PictureBox pbxCurrentColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblWeigth;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.GroupBox grbShapes;
        private System.Windows.Forms.Button btnElipse;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.GroupBox grbOther;
        private System.Windows.Forms.CheckBox chkFilled;
    }
}

