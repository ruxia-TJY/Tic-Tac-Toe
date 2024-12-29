namespace 井字棋
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pB_ChessBoard = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_cur_user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pB_ChessBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // pB_ChessBoard
            // 
            this.pB_ChessBoard.Location = new System.Drawing.Point(126, 1);
            this.pB_ChessBoard.Name = "pB_ChessBoard";
            this.pB_ChessBoard.Size = new System.Drawing.Size(600, 600);
            this.pB_ChessBoard.TabIndex = 0;
            this.pB_ChessBoard.TabStop = false;
            this.pB_ChessBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pB_ChessBoard_MouseClick);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(13, 31);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(107, 58);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "开始";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lbl_cur_user
            // 
            this.lbl_cur_user.AutoSize = true;
            this.lbl_cur_user.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_cur_user.Location = new System.Drawing.Point(51, 493);
            this.lbl_cur_user.Name = "lbl_cur_user";
            this.lbl_cur_user.Size = new System.Drawing.Size(50, 54);
            this.lbl_cur_user.TabIndex = 2;
            this.lbl_cur_user.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "当前:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 631);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_cur_user);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.pB_ChessBoard);
            this.Name = "Form1";
            this.Text = "井字棋";
            ((System.ComponentModel.ISupportInitialize)(this.pB_ChessBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pB_ChessBoard;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_cur_user;
        private System.Windows.Forms.Label label1;
    }
}

