using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 井字棋
{
    public partial class Form1 : Form
    {
        private Chess chess;
        // 当前轮到哪个用户
        private int curUser = 0;
        // 棋局状态，true:正在运行 false:未开始
        private bool isStart = false;
        public Form1()
        {
            InitializeComponent();
            // 初始化棋盘大小
            pB_ChessBoard.Width = 300;
            pB_ChessBoard.Height = 300;

            SoundPlayer sp = new SoundPlayer("./bg.wav");
            sp.PlayLooping();
        }
        
        private void btn_start_Click(object sender, EventArgs e)
        {
            // 点击开始按钮
            // 默认第一个用户开始
            curUser = 1;
            lbl_cur_user.Text = curUser.ToString();

            chess = new Chess();
            isStart = true;

            pB_ChessBoard.Image = chess.display();
        }

        private void pB_ChessBoard_MouseClick(Object sender, MouseEventArgs e)
        {
            // 如果不是棋局进行状态，
            if (isStart == false)
            {
                return;
            }

            // 根据鼠标在棋盘的位置，判断是哪一个棋子
            // 除以100因为每个棋子宽度为100
            int x = (int)(e.X / 100);
            int y = (int)(e.Y / 100);

            // 如果下在正确的地方
            if(chess.play(y,x, curUser))
            {
                // 更换用户
                if (curUser == 1) { curUser = 2; }
                else { curUser = 1; }
                lbl_cur_user.Text = curUser.ToString() ;

                // 更新棋盘
                pB_ChessBoard.Image = chess.display();

                // 检查胜利
                switch(chess.checkWin())
                {
                    case 1:
                        MessageBox.Show("恭喜选手1获胜！！", "恭喜");
                        isStart = false;
                        break;
                    case 2:
                        MessageBox.Show("恭喜选手2获胜！！", "恭喜");
                        isStart=false;
                        break;
                    case 3:
                        MessageBox.Show("平局！！", "平局");
                        isStart = false;
                        break;
                }
            }
        }
    }
}
