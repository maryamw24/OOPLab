using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BL
{
    class GameObject
    {
        public char[,] Shape;
        public Point StartingPoint;
        public Boundary Premisis;
        public string Direction;
        public string c_direction;
        public int Count;
        public GameObject()
        {
            Shape = new char[,] { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };
            Point StartingPoint = new Point();
            Boundary Premisis = new Boundary();
            Direction = "LeftToRight";
        }
        public GameObject(char[,] Shape, Point StartingPoint)
        {
            this.Shape = Shape;
            this.StartingPoint = StartingPoint;
            Boundary Premisis = new Boundary();
            Direction = "LeftToRight";
        }
        public GameObject(char[,] Shape, Point StartingPoint, Boundary Premisis, string Direction)
        {
            this.Shape = Shape;
            this.StartingPoint = StartingPoint;
            this.Premisis = Premisis;
            this.Direction = Direction;
        }
        public GameObject(char[,] Shape, Point StartingPoint, Boundary Premisis, string Direction, string c_direction)
        {
            this.Shape = Shape;
            this.StartingPoint = StartingPoint;
            this.Premisis = Premisis;
            this.Direction = Direction;
            this.c_direction = c_direction;
        }
        public void move()
        {
            if (c_direction == "patrol")
            {
                if (Direction == "LeftToRight")
                {
                    if (StartingPoint.X != Premisis.TopRight.X)
                    {
                        StartingPoint.SetXY(StartingPoint.X + 1, StartingPoint.Y);
                    }
                    else
                    {
                        Direction = "RightToLeft";
                    }
                }
                if (Direction == "RightToLeft")
                {
                    if (StartingPoint.X != Premisis.TopLeft.X)
                    {
                        StartingPoint.SetXY(StartingPoint.X - 1, StartingPoint.Y);
                    }
                    else
                    {
                        Direction = "LeftToRight";
                    }
                }
            }
            else if (c_direction == "pro")
            {
                if (Count <= 5 && StartingPoint.X != Premisis.TopRight.X && StartingPoint.Y != Premisis.TopRight.Y)
                {
                    StartingPoint.SetXY(StartingPoint.X + 1, StartingPoint.Y - 1);
                    Count++;
                }
                if (Count > 5 && Count <= 9 && StartingPoint.X != Premisis.TopRight.X)
                {
                    StartingPoint.SetXY(StartingPoint.X + 1, StartingPoint.Y);
                    Count++;
                }
                
                if (Count > 9 && Count <= 13 && StartingPoint.X != Premisis.TopRight.X && StartingPoint.Y != Premisis.BottomRight.Y && StartingPoint.Y != Premisis.BottomRight.Y)
                {
                    StartingPoint.SetXY(StartingPoint.X + 1, StartingPoint.Y + 1);
                    Count++;
                }
            }
            
            else if(Direction == "LeftToRight")
            {
                if (StartingPoint.X != Premisis.TopRight.X)
                {
                    StartingPoint.SetXY(StartingPoint.X + 1, StartingPoint.Y);
                }
                
            }
           else  if (Direction == "RightToLeft")
            {
                if (StartingPoint.X != Premisis.TopLeft.X)
                {
                    StartingPoint.SetXY(StartingPoint.X - 1, StartingPoint.Y);
                }
               
            }

        }
        public void EraseShape()
        {
            int x = StartingPoint.X;
            int y = StartingPoint.Y;
            for(int i = 0; i < 3;i++)
            {
                Console.SetCursorPosition(x, y);
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(" ");
                }
                y++;
            }
        }
        public void DrawShape()
        {
            int x = StartingPoint.X;
            int y = StartingPoint.Y;
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(x, y);
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Shape[i,j]);
                }
                y++;
            }
        }
    }
    
}
