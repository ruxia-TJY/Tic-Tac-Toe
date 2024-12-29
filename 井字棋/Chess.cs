using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace 井字棋
{
    
    internal class Chess
    {
        // 3种状态
        // 1   一号选手
        // 2   二号选手
        // 0    未下
        private int[,] arr;

        public Chess()
        {
            // 初始化棋盘
            arr = new int[3, 3];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = 0;
                }
            }
        }

        /// <summary>
        /// 判断棋局结果
        /// </summary>
        /// <returns>
        /// 返回1 一号选手胜利
        /// 返回2 二号选手胜利
        /// 返回3 平局
        /// 返回0 无人胜利
        /// </returns>
        public int checkWin()
        {
            // 判断横竖斜的乘积
            // 如果是1 说明1*1*1 1号获胜
            // 如果是8 说明2*2*2 2号获胜
            for (int i = 0;i < arr.GetLength(0); i++)
            {
                if (arr[i,0] * arr[i,1] * arr[i,2] ==  1)
                {
                    return 1;
                }
                if (arr[i, 0] * arr[i, 1] * arr[i, 2] == 8)
                {
                    return 2;
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[0, i] * arr[1, i] * arr[2, i] == 1)
                {
                    return 1;
                }
                if (arr[0, i] * arr[1, i] * arr[2, i] == 8)
                {
                    return 2;
                }
            }
            if (arr[0,0] * arr[1,1] * arr[2,2] == 1)
            {
                return 1;
            }
            if (arr[0, 0] * arr[1, 1] * arr[2, 2] == 8)
            {
                return 2;
            }

            if (arr[0,2] * arr[1,1] * arr[2,0] == 1)
            {
                return 1;
            }
            if (arr[0, 2] * arr[1, 1] * arr[2, 0] == 8)
            {
                return 2;
            }

            // 判断棋盘是不是下满了
            bool isFull=true;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (arr[i,j] == 0)
                    {
                         isFull = false;
                    }
                }
            }
            if (isFull) return 3;
            
            return 0;
        }

        /// <summary>
        /// 进行一部
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="user"></param>
        /// <returns>当前位置是否能下</returns>
        public bool play(int x,int y,int user)
        {
            if (arr[x,y] != 0)
            {
                return false;
            }
            arr[x, y] = user;

            return true;
        }


        /// <summary>
        /// 数组转图形
        /// </summary>
        public Image display()
        {
            Pen pen = new Pen(Color.Black);
            pen.Width = 10;
            Bitmap bitmap = new Bitmap(900, 900);

            // 绘制叉号
            Bitmap bitmap1 = new Bitmap(100, 100);
            Graphics g1 = Graphics.FromImage(bitmap1);
            g1.Clear(Color.White);
            g1.DrawLine(pen, new Point(10, 10), new Point(90, 90));
            g1.DrawLine(pen, new Point(10, 90), new Point(90, 10));

            // 绘制圆形
            Bitmap bitmap2 = new Bitmap(100, 100);
            Graphics g2 = Graphics.FromImage(bitmap2);
            g2.Clear(Color.White);
            g2.DrawEllipse(pen, 10, 10, 80, 80);

            // 空
            Bitmap bitmap0 = new Bitmap(100, 100);
            Graphics g0 = Graphics.FromImage(bitmap0);
            g0.Clear(Color.White);

            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.Gray);

            for (int i = 0;i < 3; i++)
            {
                for (int j = 0;j < 3 ; j++)
                {
                    if(arr[i,j] == 1)
                    {
                        g.DrawImage(bitmap1, j * 100, i * 100,100,100);
                    }
                    else if (arr[i, j] == 2)
                    {
                        g.DrawImage(bitmap2, j * 100, i * 100, 100, 100);
                    }
                    else
                    {
                        g.DrawImage(bitmap0, j * 100, i * 100, 100, 100);
                    }
                }

            }

            pen.Width = 4;
            pen.Color = Color.RosyBrown;
            g.DrawLine(pen, 100, 0, 100, 300);
            g.DrawLine(pen, 200, 0, 200, 300);
            g.DrawLine(pen, 0, 100, 300, 100);
            g.DrawLine(pen, 0, 200, 300, 200);

            pen.Color = Color.RosyBrown;
            pen.Width = 8;
            g.DrawLine(pen, 0, 0, 300, 0);
            g.DrawLine(pen, 0, 300, 300, 300);
            g.DrawLine(pen, 0, 0, 0, 300);
            g.DrawLine(pen, 300, 0, 300, 300);
            return bitmap;
        }

    }
}
