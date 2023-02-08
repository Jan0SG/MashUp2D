namespace Pt2pt
{
    partial class MyForm
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
            this.components = new System.ComponentModel.Container();
            this.PNL_HEADER = new System.Windows.Forms.Panel();
            this.PNL_BOTTOM = new System.Windows.Forms.Panel();
            this.LBL_STATUS = new System.Windows.Forms.Label();
            this.PCT_CANVAS = new System.Windows.Forms.PictureBox();
            this.PNL_LEFT = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CHK_TRANSLATE = new System.Windows.Forms.CheckBox();
            this.BTN_EXE = new System.Windows.Forms.Button();
            this.TREE = new System.Windows.Forms.TreeView();
            this.PNL_RIGHT = new System.Windows.Forms.Panel();
            this.PCT_SLIDEER_Y = new System.Windows.Forms.PictureBox();
            this.PCT_SLIDEER_X = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.PNL_BOTTOM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            this.PNL_LEFT.SuspendLayout();
            this.PNL_RIGHT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_SLIDEER_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_SLIDEER_X)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_HEADER
            // 
            this.PNL_HEADER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PNL_HEADER.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_HEADER.Location = new System.Drawing.Point(0, 0);
            this.PNL_HEADER.Margin = new System.Windows.Forms.Padding(4);
            this.PNL_HEADER.Name = "PNL_HEADER";
            this.PNL_HEADER.Size = new System.Drawing.Size(1924, 64);
            this.PNL_HEADER.TabIndex = 0;
            // 
            // PNL_BOTTOM
            // 
            this.PNL_BOTTOM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PNL_BOTTOM.Controls.Add(this.LBL_STATUS);
            this.PNL_BOTTOM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PNL_BOTTOM.Location = new System.Drawing.Point(0, 835);
            this.PNL_BOTTOM.Margin = new System.Windows.Forms.Padding(4);
            this.PNL_BOTTOM.Name = "PNL_BOTTOM";
            this.PNL_BOTTOM.Size = new System.Drawing.Size(1924, 36);
            this.PNL_BOTTOM.TabIndex = 1;
            // 
            // LBL_STATUS
            // 
            this.LBL_STATUS.AutoSize = true;
            this.LBL_STATUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_STATUS.ForeColor = System.Drawing.Color.Gray;
            this.LBL_STATUS.Location = new System.Drawing.Point(9, 6);
            this.LBL_STATUS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_STATUS.Name = "LBL_STATUS";
            this.LBL_STATUS.Size = new System.Drawing.Size(117, 25);
            this.LBL_STATUS.TabIndex = 0;
            this.LBL_STATUS.Text = "WELCOME";
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PCT_CANVAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PCT_CANVAS.Location = new System.Drawing.Point(211, 124);
            this.PCT_CANVAS.Margin = new System.Windows.Forms.Padding(4);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(1533, 652);
            this.PCT_CANVAS.TabIndex = 2;
            this.PCT_CANVAS.TabStop = false;
            this.PCT_CANVAS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseClick);
            this.PCT_CANVAS.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseDoubleClick);
            this.PCT_CANVAS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseDown);
            this.PCT_CANVAS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseMove);
            this.PCT_CANVAS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseUp);
            // 
            // PNL_LEFT
            // 
            this.PNL_LEFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PNL_LEFT.Controls.Add(this.button2);
            this.PNL_LEFT.Controls.Add(this.button1);
            this.PNL_LEFT.Controls.Add(this.checkBox1);
            this.PNL_LEFT.Controls.Add(this.CHK_TRANSLATE);
            this.PNL_LEFT.Controls.Add(this.BTN_EXE);
            this.PNL_LEFT.Controls.Add(this.TREE);
            this.PNL_LEFT.Dock = System.Windows.Forms.DockStyle.Left;
            this.PNL_LEFT.Location = new System.Drawing.Point(0, 64);
            this.PNL_LEFT.Margin = new System.Windows.Forms.Padding(4);
            this.PNL_LEFT.Name = "PNL_LEFT";
            this.PNL_LEFT.Size = new System.Drawing.Size(200, 771);
            this.PNL_LEFT.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(16, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "GRABAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(25, 686);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 20);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Todas";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CHK_TRANSLATE
            // 
            this.CHK_TRANSLATE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CHK_TRANSLATE.AutoSize = true;
            this.CHK_TRANSLATE.FlatAppearance.BorderSize = 0;
            this.CHK_TRANSLATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHK_TRANSLATE.Location = new System.Drawing.Point(25, 729);
            this.CHK_TRANSLATE.Margin = new System.Windows.Forms.Padding(4);
            this.CHK_TRANSLATE.Name = "CHK_TRANSLATE";
            this.CHK_TRANSLATE.Size = new System.Drawing.Size(96, 20);
            this.CHK_TRANSLATE.TabIndex = 2;
            this.CHK_TRANSLATE.Text = "TRASLATE";
            this.CHK_TRANSLATE.UseVisualStyleBackColor = true;
            // 
            // BTN_EXE
            // 
            this.BTN_EXE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_EXE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.BTN_EXE.FlatAppearance.BorderSize = 0;
            this.BTN_EXE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EXE.ForeColor = System.Drawing.Color.Snow;
            this.BTN_EXE.Location = new System.Drawing.Point(16, 506);
            this.BTN_EXE.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_EXE.Name = "BTN_EXE";
            this.BTN_EXE.Size = new System.Drawing.Size(164, 33);
            this.BTN_EXE.TabIndex = 1;
            this.BTN_EXE.Text = "ADD FIG n";
            this.BTN_EXE.UseVisualStyleBackColor = false;
            this.BTN_EXE.Click += new System.EventHandler(this.BTN_EXE_Click);
            // 
            // TREE
            // 
            this.TREE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TREE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TREE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TREE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TREE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TREE.Location = new System.Drawing.Point(0, 0);
            this.TREE.Margin = new System.Windows.Forms.Padding(4);
            this.TREE.Name = "TREE";
            this.TREE.Size = new System.Drawing.Size(192, 474);
            this.TREE.TabIndex = 0;
            this.TREE.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TREE_AfterSelect);
            this.TREE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TREE_KeyPress);
            // 
            // PNL_RIGHT
            // 
            this.PNL_RIGHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PNL_RIGHT.Controls.Add(this.PCT_SLIDEER_Y);
            this.PNL_RIGHT.Dock = System.Windows.Forms.DockStyle.Right;
            this.PNL_RIGHT.Location = new System.Drawing.Point(1724, 64);
            this.PNL_RIGHT.Margin = new System.Windows.Forms.Padding(4);
            this.PNL_RIGHT.Name = "PNL_RIGHT";
            this.PNL_RIGHT.Size = new System.Drawing.Size(200, 771);
            this.PNL_RIGHT.TabIndex = 4;
            // 
            // PCT_SLIDEER_Y
            // 
            this.PCT_SLIDEER_Y.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PCT_SLIDEER_Y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PCT_SLIDEER_Y.Location = new System.Drawing.Point(25, 59);
            this.PCT_SLIDEER_Y.Margin = new System.Windows.Forms.Padding(4);
            this.PCT_SLIDEER_Y.Name = "PCT_SLIDEER_Y";
            this.PCT_SLIDEER_Y.Size = new System.Drawing.Size(20, 704);
            this.PCT_SLIDEER_Y.TabIndex = 6;
            this.PCT_SLIDEER_Y.TabStop = false;
            this.PCT_SLIDEER_Y.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PCT_SLIDEER_Y_MouseDown);
            this.PCT_SLIDEER_Y.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PCT_SLIDEER_Y_MouseMove);
            this.PCT_SLIDEER_Y.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PCT_SLIDEER_Y_MouseUp);
            // 
            // PCT_SLIDEER_X
            // 
            this.PCT_SLIDEER_X.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PCT_SLIDEER_X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PCT_SLIDEER_X.Location = new System.Drawing.Point(19, 14);
            this.PCT_SLIDEER_X.Margin = new System.Windows.Forms.Padding(4);
            this.PCT_SLIDEER_X.Name = "PCT_SLIDEER_X";
            this.PCT_SLIDEER_X.Size = new System.Drawing.Size(1492, 18);
            this.PCT_SLIDEER_X.TabIndex = 5;
            this.PCT_SLIDEER_X.TabStop = false;
            this.PCT_SLIDEER_X.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PCT_SLIDEER_X_MouseDown);
            this.PCT_SLIDEER_X.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PCT_SLIDEER_X_MouseMove);
            this.PCT_SLIDEER_X.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PCT_SLIDEER_X_MouseUp);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel3.Controls.Add(this.PCT_SLIDEER_X);
            this.panel3.Location = new System.Drawing.Point(211, 782);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1531, 47);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel4.Controls.Add(this.trackBar1);
            this.panel4.Location = new System.Drawing.Point(213, 71);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1531, 47);
            this.panel4.TabIndex = 7;
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.Location = new System.Drawing.Point(0, 0);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(1531, 47);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // TIMER
            // 
            this.TIMER.Enabled = true;
            this.TIMER.Interval = 40;
            this.TIMER.Tick += new System.EventHandler(this.TIMER_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(16, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "PLAY";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1924, 871);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PNL_RIGHT);
            this.Controls.Add(this.PNL_LEFT);
            this.Controls.Add(this.PCT_CANVAS);
            this.Controls.Add(this.PNL_BOTTOM);
            this.Controls.Add(this.PNL_HEADER);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyForm";
            this.Text = "MyForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.MyForm_Resize);
            this.PNL_BOTTOM.ResumeLayout(false);
            this.PNL_BOTTOM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            this.PNL_LEFT.ResumeLayout(false);
            this.PNL_LEFT.PerformLayout();
            this.PNL_RIGHT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_SLIDEER_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_SLIDEER_X)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_HEADER;
        private System.Windows.Forms.Panel PNL_BOTTOM;
        private System.Windows.Forms.PictureBox PCT_CANVAS;
        private System.Windows.Forms.Label LBL_STATUS;
        private System.Windows.Forms.Panel PNL_LEFT;
        private System.Windows.Forms.Panel PNL_RIGHT;
        private System.Windows.Forms.PictureBox PCT_SLIDEER_X;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TreeView TREE;
        private System.Windows.Forms.Button BTN_EXE;
        private System.Windows.Forms.Timer TIMER;
        private System.Windows.Forms.PictureBox PCT_SLIDEER_Y;
        private System.Windows.Forms.CheckBox CHK_TRANSLATE;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}