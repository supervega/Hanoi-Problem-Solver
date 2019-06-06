using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Hanoi_Stack
{
    public partial class Form1 : Form
    {
        struct Info
        {
            public int Num;
            public Color C;
        }
        Dictionary<char, Stack<Info>> Data;
        Stack<Info> A = new Stack<Info>();
        Stack<Info> B = new Stack<Info>();
        Stack<Info> C = new Stack<Info>();
        public int ElementCount = 0;
        public Graphics G;
        public Pen DrawPen;
        public int Recwidth = 170, RecHeight = 40;
        public Point Coordinate;
        public int ScaleAmount = 0;
        public int Degree = 20;
        public string[] Colors = new string[] { "red", "green", "yellow", "blue", "gray", "brown", "orange","violet","tomato","silver","salamon" };
        int BreakTime = 1;

        public Form1()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            Data = new Dictionary<char, Stack<Info>>();
            A.Clear();
            B.Clear();
            C.Clear();
            Coordinate = new Point(50, 300 - RecHeight);
            for (int i = (int)NUDDisks.Value; i > 0; i--)
            {
                Info IN = new Info();
                IN.Num = i;
                IN.C = Color.FromName(Colors[(int)NUDDisks.Value - i]);
                A.Push(IN);                
            }
            ElementCount = (int)NUDDisks.Value;
            Data.Add('a', A);
            Data.Add('b', B);
            Data.Add('c', C);
            Draw();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            G = PBDraw.CreateGraphics();
            Coordinate = new Point();
            DrawPen = new Pen(Color.White);            
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            bool Inverse = false;
            Initialize();
            while (Data['c'].Count != ElementCount)
            {
                if (!Inverse)
                {
                    Data['b'].Push(Data['a'].Pop());
                    Thread.Sleep(BreakTime*1000);
                    Draw();
                    Thread.Sleep(BreakTime * 1000);
                    Data['c'].Push(Data['a'].Pop());
                    Draw();
                    Thread.Sleep(BreakTime * 1000);
                    Data['c'].Push(Data['b'].Pop());
                    Draw();
                    Thread.Sleep(BreakTime * 1000);
                    if (Data['a'].Count != 0)
                    {
                        Data['b'].Push(Data['a'].Pop());
                        Draw();
                        Thread.Sleep(BreakTime * 1000);
                    }
                    else
                        if (Data['b'].Count != 0)
                        {
                            Data['a'].Push(Data['b'].Pop());
                            Draw();
                            Thread.Sleep(BreakTime * 1000);
                        }
                    Inverse = true;
                }
                else
                {
                    Data['b'].Push(Data['c'].Pop());
                    Draw();
                    Thread.Sleep(BreakTime * 1000);
                    Data['a'].Push(Data['c'].Pop());
                    Draw();
                    Thread.Sleep(BreakTime * 1000);
                    Data['a'].Push(Data['b'].Pop());
                    Draw();
                    Thread.Sleep(BreakTime * 1000);
                    if (Data['c'].Count == 0)
                    {
                        Data['c'].Push(Data['b'].Pop());
                        Draw();
                        Thread.Sleep(BreakTime * 1000);
                    }
                    else
                        if (Data['b'].Count != 0 && ((Info)Data['b'].Peek()).Num < ((Info)Data['c'].Peek()).Num)
                        {
                            Data['c'].Push(Data['b'].Pop());
                            Draw();
                            Thread.Sleep(BreakTime * 1000);
                        }
                        else
                        {
                            Data['b'].Push(Data['c'].Pop());
                            Draw();
                            Thread.Sleep(BreakTime * 1000);
                        }
                    Inverse = false;
                }
            }
            groupBox1.Enabled = true;
        }

        public void Draw()
        {
            G.Clear(Color.Black);
            DrawPen.Color=Color.White;
            G.DrawLine(DrawPen, new Point(0, 300), new Point(732, 300));

            G.DrawLine(DrawPen, new Point(135, 300), new Point(135, 0));
            G.DrawLine(DrawPen, new Point(385, 300), new Point(385, 0));
            G.DrawLine(DrawPen, new Point(625, 300), new Point(625, 0));
             ScaleAmount = 0;
             Coordinate = new Point(50, 300 - RecHeight);
             List<Info> Temp = new List<Info>();
            int Counter = Data['a'].Count;
            int TempIndex = 0;
            TempIndex = Data['a'].Count;
            for (int i = 0; i < TempIndex; i++)
            {
                Temp.Add(Data['a'].Pop());
            }
            for (int i = Counter; i > 0; i--)
                {
                    Info TT=Temp[i-1];
                    DrawPen.Color = TT.C;
                    G.FillRectangle(DrawPen.Brush, Coordinate.X + ScaleAmount / 2, Coordinate.Y - (Counter - i) * RecHeight, Recwidth - ScaleAmount, RecHeight);
                    ScaleAmount += Degree;
                }
            for (int i = 0; i < TempIndex; i++)
            {
                Data['a'].Push(Temp[TempIndex-i-1]);
            }
            Temp.Clear();
                ScaleAmount = 0;
                Coordinate = new Point(300, 300 - RecHeight);
                Counter = Data['b'].Count;
                TempIndex = Data['b'].Count;
                for (int i = 0; i < TempIndex; i++)
                {
                    Temp.Add(Data['b'].Pop());
                }
                for (int i = TempIndex; i > 0; i--)
                {
                    Info TT = Temp[i-1];
                    DrawPen.Color = TT.C;
                    G.FillRectangle(DrawPen.Brush, Coordinate.X + ScaleAmount / 2, Coordinate.Y - (Counter - i) * RecHeight, Recwidth - ScaleAmount, RecHeight);
                    ScaleAmount += Degree;
                }
                for (int i = 0; i < TempIndex; i++)
                {
                    Data['b'].Push(Temp[TempIndex - i - 1]);
                }
                Temp.Clear();
                ScaleAmount = 0;
                Coordinate = new Point(540, 300 - RecHeight);
                Counter = Data['c'].Count;
                TempIndex = Data['c'].Count;
                for (int i = 0; i < TempIndex; i++)
                {
                    Temp.Add(Data['c'].Pop());
                }
                for (int i = TempIndex; i > 0; i--)
                {
                    Info TT = Temp[i-1];
                    DrawPen.Color = TT.C;
                    G.FillRectangle(DrawPen.Brush, Coordinate.X + ScaleAmount / 2, Coordinate.Y - (Counter - i) * RecHeight, Recwidth - ScaleAmount, RecHeight);
                    ScaleAmount += Degree;
                }
                for (int i = 0; i < TempIndex; i++)
                {
                    Data['c'].Push(Temp[TempIndex - i - 1]);
                }
                Temp.Clear();
        }

        private void NUDDishHeight_ValueChanged(object sender, EventArgs e)
        {
            RecHeight = (int)NUDDishHeight.Value;
        }

        private void NUDBreakTime_ValueChanged(object sender, EventArgs e)
        {
            BreakTime = (int)NUDBreakTime.Value;
        }


    }
}
