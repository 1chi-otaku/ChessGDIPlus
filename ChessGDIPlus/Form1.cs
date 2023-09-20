using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGDIPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                SolidBrush white_brush = new SolidBrush(Color.White);
                SolidBrush black_brush = new SolidBrush(Color.Black);


                int x = 0;
                int y = 0;

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (j != 0) x += 107;
                        if(i % 2 == 0)
                        {
                            g.FillRectangle(white_brush, x, y, 108, 108);
                            x += 107;
                            g.FillRectangle(black_brush, x, y, 108, 108);
                        }
                        else
                        {
                            g.FillRectangle(black_brush, x, y, 108, 108);
                            x += 107;
                            g.FillRectangle(white_brush, x, y, 108, 108);
                        }        
                    }
                    y += 107;
                    x = 0;
                }
                x = 0;
                Image redPawn = Image.FromFile("red_pawn.png");
                Image redBishop = Image.FromFile("red_bishop.png");
                Image redHorse = Image.FromFile("red_horse.png");
                Image redKing = Image.FromFile("red_king.png");
                Image redQueen = Image.FromFile("red_queen.png");
                Image redRook = Image.FromFile("red_rook.png");

                Image bluePawn = Image.FromFile("blue_pawn.png");
                Image blueBishop = Image.FromFile("blue_bishop.png");
                Image blueHorse = Image.FromFile("blue_horse.png");
                Image blueKing = Image.FromFile("blue_king.png");
                Image blueQueen = Image.FromFile("blue_queen.png");
                Image blueRook = Image.FromFile("blue_rook.png");


                for (int i = 0; i < 8; i++, x+= 107)
                {
                    e.Graphics.DrawImage(redPawn, new Point(x, 107));
                    e.Graphics.DrawImage(bluePawn, new Point(x, 642));
                }

                e.Graphics.DrawImage(redRook, new Point(0, 0));
                e.Graphics.DrawImage(redRook, new Point(747, 0));
                e.Graphics.DrawImage(blueRook, new Point(0, 747));
                e.Graphics.DrawImage(blueRook, new Point(747, 747));

                e.Graphics.DrawImage(redHorse, new Point(107,-3));
                e.Graphics.DrawImage(redHorse, new Point(642, -3));
                e.Graphics.DrawImage(blueHorse, new Point(107, 753));
                e.Graphics.DrawImage(blueHorse, new Point(642, 753));

                e.Graphics.DrawImage(redBishop, new Point(214, -4));
                e.Graphics.DrawImage(redBishop, new Point(534, -4));
                e.Graphics.DrawImage(blueBishop, new Point(214, 747));
                e.Graphics.DrawImage(blueBishop, new Point(534, 747));

                e.Graphics.DrawImage(redQueen, new Point(321, -2));
                e.Graphics.DrawImage(blueKing, new Point(321, 749));

                e.Graphics.DrawImage(redKing, new Point(428, 2));
                e.Graphics.DrawImage(blueQueen, new Point(428, 749));

                white_brush.Dispose();
                black_brush.Dispose();

                redPawn.Dispose();
                redBishop.Dispose();
                redHorse.Dispose();
                redKing.Dispose();
                redQueen.Dispose();
                redRook.Dispose();

                bluePawn.Dispose();
                blueBishop.Dispose();
                blueHorse.Dispose();
                blueKing.Dispose();
                blueQueen.Dispose();
                blueRook.Dispose();
            }
        }
    }
}
