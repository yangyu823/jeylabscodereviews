using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
// using System.Runtime.InteropServices;

namespace CodePuzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Pen - setup border color
        Pen red = new Pen(Color.Red, 2);
        Pen green = new Pen(Color.Green, 2);
        Pen blue = new Pen(Color.Blue, 2);
        Pen orange = new Pen(Color.OrangeRed, 2);

        //  Brush setup
        //System.Drawing.SolidBrush fillRed = new System.Drawing.SolidBrush(Color.Red);
        //System.Drawing.SolidBrush fillBlue = new System.Drawing.SolidBrush(Color.Blue);

        private double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("****************Welcome to CodePuzzle 2.1 - Drawing!!!**************");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("   Limited 50 time attemps, you can reopen the program to try more.");
            Console.WriteLine("      If you wanna clean up all shapes, try to type 'Clean'!");
            Console.WriteLine("       If you wanna stop this programe, try to type 'End'!");
            Console.WriteLine("           If you need some helps, try to type 'Guide'!");

            Console.WriteLine("--------------------------------------------------------------------");


            //  Console.WriteLine(value1);
            //  Console.WriteLine(value2);

            Graphics g = e.Graphics;

            int i = 1;

            while (i<50)
            {
                //  Requirement for user input in console.
                Console.WriteLine();
                Console.WriteLine("Please specify what to draw using natural language.");

                //  Generate data from user input
                string test = Console.ReadLine();

                int width = 0;
                int height = 0;
                int sidelength = 0;
                int sidelength2 = 0;
                int sidelength3 = 0;
                int radius = 0;
                int pos0 = 0;
                int pos1 = 0;
                int pos2 = 0;
                int pos3 = 0;

                pos0 = test.ToLower().IndexOf("width");
                pos1 = test.ToLower().IndexOf("height");
                pos2 = test.Replace(" ","").ToLower().IndexOf("sidelength");
                pos3 = test.ToLower().IndexOf("radius");

                //  Console.WriteLine(pos0);
                //  Console.WriteLine(pos1);
                //  Console.WriteLine(pos2);
                //  Console.WriteLine(pos3;
                //  int[] pos = new int[4] { pos0, pos1, pos2, pos3 };


                //  dumb condition method, shame on it. Seeking for alternative  :( //
                if (pos3 == -1)
                {
                    if(pos2 == -1)
                    {
                        if(pos1< pos0)
                        {
                            Match match = Regex.Match(test, @"\d+");
                            if (match.Success)
                            {
                                height = Int32.Parse(match.Value);
                            }

                            match = match.NextMatch();
                            if (match.Success)
                            {
                                width = Int32.Parse(match.Value);
                            }

                        }
                        else
                        {
                            Match match = Regex.Match(test, @"\d+");
                            if (match.Success)
                            {
                                width = Int32.Parse(match.Value);
                            }

                            match = match.NextMatch();
                            if (match.Success)
                            {
                                height = Int32.Parse(match.Value);
                            }
                        }
                    }
                    else
                    {
                        if(pos0 == -1 || pos1 == -1)
                        {
                            Match match = Regex.Match(test, @"\d+");
                            if (match.Success)
                            {
                                sidelength = Int32.Parse(match.Value);
                            }

                            match = match.NextMatch();
                            if (match.Success)
                            {
                                sidelength2 = Int32.Parse(match.Value);
                            }

                            match = match.NextMatch();
                            if (match.Success)
                            {
                                sidelength3 = Int32.Parse(match.Value);
                            }
                        }
                        else
                        {
                            if(pos0<pos1 && pos0 < pos2)
                            {
                                Match match = Regex.Match(test, @"\d+");
                                if (match.Success)
                                {
                                    width = Int32.Parse(match.Value);
                                }
                                if (pos1 < pos2)
                                { 
                                    match = match.NextMatch();
                                    if (match.Success)
                                    {
                                        height = Int32.Parse(match.Value);
                                    }
                                    match = match.NextMatch();
                                    if (match.Success)
                                    {
                                        sidelength = Int32.Parse(match.Value);
                                    }
                                }
                                else
                                {
                                    match = match.NextMatch();
                                    if (match.Success)
                                    {
                                        sidelength = Int32.Parse(match.Value);
                                    }
                                    match = match.NextMatch();
                                    if (match.Success)
                                    {
                                        height = Int32.Parse(match.Value);
                                    }
                                }
                            }
                            else if (pos1 < pos0 && pos1 < pos2)
                            {
                                Match match = Regex.Match(test, @"\d+");
                                if (match.Success)
                                {
                                    height = Int32.Parse(match.Value);
                                }
                                if (pos0 < pos2)
                                {
                                    match = match.NextMatch();
                                    if (match.Success)
                                    {
                                        width = Int32.Parse(match.Value);
                                    }
                                    match = match.NextMatch();
                                    if (match.Success)
                                    {
                                        sidelength = Int32.Parse(match.Value);
                                    }
                                }
                                else
                                {
                                    match = match.NextMatch();
                                    if (match.Success)
                                    {
                                        sidelength = Int32.Parse(match.Value);
                                    }
                                    match = match.NextMatch();
                                    if (match.Success)
                                    {
                                        width = Int32.Parse(match.Value);
                                    }
                                }
                            }
                            else
                            {
                                Match match = Regex.Match(test, @"\d+");
                                if (match.Success)
                                {
                                    sidelength = Int32.Parse(match.Value);
                                }
                                if (pos0 < pos1)
                                {
                                    match = match.NextMatch();
                                    if (match.Success)
                                    {
                                        width = Int32.Parse(match.Value);
                                    }
                                    match = match.NextMatch();
                                    if (match.Success)
                                    {
                                        height = Int32.Parse(match.Value);
                                    }
                                }
                                else
                                {
                                    match = match.NextMatch();
                                    if (match.Success)
                                    {
                                        height = Int32.Parse(match.Value);
                                    }
                                    match = match.NextMatch();
                                    if (match.Success)
                                    {
                                        width = Int32.Parse(match.Value);
                                    }
                                }
                            }
                        }
                    }

                }
                else
                {
                    Match match = Regex.Match(test, @"\d+");
                    if (match.Success)
                    {
                        radius = Int32.Parse(match.Value);
                    }
                }

                //-------------------------------------------Case by case------------------------------------//
                //---------1st. triangle (Isosceles,Equilateral,Scalene)
                // Isosceles Triangle case
                if (test.ToLower().Contains("isosceles triangle"))
                {
                    if (width != 0 && height != 0)
                    {
                        //  Pointer array define
                        Point[] pnt = new Point[3];
                        //  value1 = height;
                        //  value2 = width
                        pnt[0].X = 50 + width / 2;
                        pnt[0].Y = 50;

                        pnt[1].X = 50;
                        pnt[1].Y = 50 + height;

                        pnt[2].X = 50 + width;
                        pnt[2].Y = 50 + height;

                        g.DrawPolygon(orange, pnt);

                        Console.WriteLine("***No.{0} , Great! Isosceles triangle has been drawn on windows form!", i);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Please enter the requirement in correct format!");
                        Console.WriteLine("(E.g: provide the parameter for height and width in correct order to get Isosceles Triangle!!)");
                    }
                }

                // Equilateral Triangle case
                else if (test.ToLower().Contains("equilateral triangle"))
                {
                    if (sidelength != 0 || width != 0)
                    {
                        if (test.ToLower().Contains("height"))
                        {
                            //  Pointer array define
                            Point[] pnt = new Point[3];
                            //  value1 = height;

                            pnt[0].X = 50 + Convert.ToInt32(height / Math.Sqrt(3));
                            pnt[0].Y = 50;

                            pnt[1].X = 50;
                            pnt[1].Y = 50 + height;

                            pnt[2].X = 50 + Convert.ToInt32(2 * (height / Math.Sqrt(3)));
                            pnt[2].Y = 50 + height;
                            //  Console.WriteLine(pnt[2].X);

                            g.DrawPolygon(orange, pnt);
                            Console.WriteLine("***No.{0} , Great! Isosceles triangle has been drawn on windows form!", i);
                            Console.WriteLine();

                        }
                        else if (test.ToLower().Contains("width"))
                        {
                            //  Pointer array define
                            Point[] pnt = new Point[3];

                            pnt[0].X = width / 2;
                            pnt[0].Y = 0;

                            pnt[1].X = 0;
                            pnt[1].Y = Convert.ToInt32(width / 2 * Math.Sqrt(3));

                            pnt[2].X = width;
                            pnt[2].Y = Convert.ToInt32(width / 2 * Math.Sqrt(3));

                            g.DrawPolygon(orange, pnt);
                            Console.WriteLine("***No.{0} , Great! Isosceles triangle has been drawn on windows form!", i);
                            Console.WriteLine();

                        }
                        else if (test.ToLower().Contains("side length"))
                        {
                            //  Pointer array define
                            Point[] pnt = new Point[3];

                            pnt[0].X = sidelength / 2;
                            pnt[0].Y = 0;

                            pnt[1].X = 0;
                            pnt[1].Y = Convert.ToInt32(sidelength / 2 * Math.Sqrt(3));

                            pnt[2].X = sidelength;
                            pnt[2].Y = Convert.ToInt32(sidelength / 2 * Math.Sqrt(3));

                            g.DrawPolygon(orange, pnt);
                            Console.WriteLine("***No.{0} , Great! Isosceles triangle has been drawn on windows form!", i);
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Please enter the requirement in correct format!");
                            Console.WriteLine("(E.g: provide the width or height or side length for equilateral triangle!!)");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Warning !!! Please enter correct parameter for Equilateral Triangle !");

                    }
                }

                //  Scalene Triangle case
                else if (test.ToLower().Contains("scalene triangle"))
                {
                    if (sidelength != 0 && sidelength2 != 0 && sidelength3 != 0 && ((sidelength + sidelength2) > sidelength3) && ((sidelength + sidelength3) > sidelength2) && ((sidelength2 + sidelength3) > sidelength))
                    {
                        //  Pointer array define
                        Point[] pnt = new Point[3];
                        //  value1 = m;
                        //  value2 = n;
                        //  value3 = x+y;  Assume value3 is the max side length;
                        //  P =（m + n + ( x + y ))/2; This is the total length/2
                        int p = (sidelength + sidelength2 + sidelength3) / 2;
                        //  S = SQRT[P * ( P - m ) * ( P - n ) * ( P - x - y )]; This is area
                        //  S = 1/2( x + y )h;  This is area
                        //  h = {SQRT[P * ( P - m ) * ( P - n ) * ( P - x - y )]} * 2/( x + y ); This is height

                        //  Find the max and mix side length in case of Height out side of the triangle!.
                        int[] array = { sidelength, sidelength2, sidelength3 };
                        int valueMax = array.Max();
                        int valueMin = array.Min();

                        //  Get the height for lengh(Max);
                        int h = Convert.ToInt32(Math.Sqrt(p * (p - sidelength) * (p - sidelength2) * (p - sidelength3)) * 2 / valueMax);
                        //  Console.WriteLine(h);

                        pnt[0].X = 50 + Convert.ToInt32(Math.Sqrt(Math.Pow(valueMin, 2) - Math.Pow(h, 2)));
                        pnt[0].Y = 50;

                        pnt[1].X = 50;
                        pnt[1].Y = 50 + h;

                        pnt[2].X = 50 + valueMax;
                        pnt[2].Y = 50 + h;

                        g.DrawPolygon(orange, pnt);

                        Console.WriteLine("***No.{0} , Great! Scalene Triangle has been drawn on windows form!", i);
                        Console.WriteLine();

                    }
                    else
                    {
                        Console.WriteLine("Warning !!! Please enter correct parameter for Scalene Triangle !");
                    }
                }

                //---------2nd. Square (Square, Parallelogram,Rectangle)
                //  Square case
                else if (test.ToLower().Contains("square"))
                {
                    if (sidelength != 0)
                    {
                        Rectangle square = new Rectangle(450, 50, sidelength, sidelength);
                        g.DrawRectangle(red, square);
                        Console.WriteLine("***No.{0} , Great! Square has been drawn on windows form!", i);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Warning !!! Please enter correct parameter for Square !");
                    }
                }

                //  Parallelogram case
                else if (test.ToLower().Contains("parallelogram"))
                {
                    if (sidelength != 0 && width != 0 && height != 0 && ((sidelength + height) > width) && ((sidelength + width) > height) && ((height + width) > sidelength))
                    {
                        //  Pointer array define
                        Point[] pnt = new Point[4];
                        int part = Convert.ToInt32(Math.Sqrt((Math.Pow(sidelength, 2) - Math.Pow(height, 2))));

                        pnt[0].X = 450 + part;
                        pnt[0].Y = 50;

                        pnt[1].X = 450 + part + width;
                        pnt[1].Y = 50;

                        pnt[2].X = 450 + width;
                        pnt[2].Y = 50 + height;

                        pnt[3].X = 450;
                        pnt[3].Y = 50 + height;

                        g.DrawPolygon(red, pnt);

                        Console.WriteLine("***No.{0} , Great! Parallelogram has been drawn on windows form!", i);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Warning !!! Please enter correct parameter for Parallelogram !");
                    }
                }

                //  Rectangle case
                else if (test.ToLower().Contains("rectangle"))
                {
                    if (width != 0 && height != 0)
                    {
                        Rectangle square = new Rectangle(450, 50, width, height);
                        g.DrawRectangle(red, square);
                        Console.WriteLine("***No.{0} , Great! Rectangle has been drawn on windows form!", i);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Warning !!! Please enter correct parameter for rectangle !");
                    }
                }

                //---------3rd. Polygon (Pentagon,Hexagon,Heptagon,Octagon)
                //  Pentagon
                else if (test.ToLower().Contains("pentagon"))
                {
                    if (sidelength != 0)
                    {
                        //  Pointer array define
                        Point[] pnt = new Point[5];
                        int h = Convert.ToInt32(sidelength * Math.Sqrt(5 + 2 * Math.Sqrt(5)) / 2);
                        int w = Convert.ToInt32(sidelength * (1 + Math.Sqrt(5)) / 2);
                        int h2 = Convert.ToInt32(Math.Sqrt(Math.Pow(sidelength, 2) - Math.Pow(w / 2, 2)));

                        pnt[0].X = 50;
                        pnt[0].Y = 450 + h2;

                        pnt[1].X = 50 + w / 2;
                        pnt[1].Y = 450;

                        pnt[2].X = 50 + w;
                        pnt[2].Y = 450 + h2;

                        pnt[3].X = 50 + w - (w - sidelength) / 2;
                        pnt[3].Y = 450 + h;

                        pnt[4].X = 50 + (w - sidelength) / 2;
                        pnt[4].Y = 450 + h;


                        g.DrawPolygon(green, pnt);

                        Console.WriteLine("***No.{0} , Great! Pentagon has been drawn on windows form!", i);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Warning !!! Please enter correct parameter for Pentagon !");
                    }
                }
                //  Hexagon
                else if (test.ToLower().Contains("hexagon"))
                {
                    if (sidelength != 0)
                    {
                        //  Pointer array define
                        Point[] pnt = new Point[6];
                        int h = Convert.ToInt32(Math.Sqrt(3) * sidelength);
                        int w = 2 * sidelength;

                        pnt[0].X = 50;
                        pnt[0].Y = 450 + h / 2;

                        pnt[1].X = 50 + sidelength / 2;
                        pnt[1].Y = 450;

                        pnt[2].X = Convert.ToInt32(50 + (sidelength * 1.5));
                        pnt[2].Y = 450;

                        pnt[3].X = 50 + w;
                        pnt[3].Y = 450 + h / 2;

                        pnt[4].X = Convert.ToInt32(50 + (sidelength * 1.5));
                        pnt[4].Y = 450 + h;

                        pnt[5].X = 50 + sidelength / 2;
                        pnt[5].Y = 450 + h;

                        g.DrawPolygon(green, pnt);

                        Console.WriteLine("***No.{0} , Great! Hexagon has been drawn on windows form!", i);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Warning !!! Please enter correct parameter for Hexagon !");
                    }
                }
                //  Heptagon
                else if (test.ToLower().Contains("heptagon"))
                {
                    if (sidelength != 0)
                    {
                        //  Pointer array define
                        Point[] pnt = new Point[7];
                        //  h = a(sin C);
                        //  C = 900/14;
                        //  h = sidelength* sin(900/14)
                        int r = Convert.ToInt32(sidelength / (2 * Math.Sin(DegreeToRadian(360 / 14))));
                        int h = Convert.ToInt32(Math.Sqrt(Math.Pow(r, 2) - Math.Pow(sidelength / 2, 2)));
                        //  Law of cosines:  c^{2}=a^{2}+b^{2}-2ab\cos(C);
                        int maxW = Convert.ToInt32(Math.Sqrt(Math.Pow(r, 2) * (2 - 2 * Math.Cos(DegreeToRadian(1080 / 7)))));
                        int minW = Convert.ToInt32(Math.Sqrt(Math.Pow(r, 2) * (2 - 2 * Math.Cos(DegreeToRadian(720 / 7)))));
                        int extraW = Convert.ToInt32(sidelength * Math.Cos(DegreeToRadian(180 - 900 / 7)));

                        //  Mid Height and Min Height
                        int h2 = Convert.ToInt32((Math.Pow(r, 2) / minW) * Math.Sin(DegreeToRadian(720 / 7)));
                        int h3 = Convert.ToInt32((Math.Pow(r, 2) / maxW) * Math.Sin(DegreeToRadian(1080 / 7)));
                        /*
                        Console.WriteLine(h);
                        Console.WriteLine(r);
                        Console.WriteLine(h2);
                        Console.WriteLine(h3);
                        Console.WriteLine(maxW);
                        Console.WriteLine(minW);
                        */

                        pnt[0].X = 50;
                        pnt[0].Y = 450 + r + h3;

                        pnt[1].X = 50 + (maxW - minW) / 2;
                        pnt[1].Y = 450 + r - h2;

                        pnt[2].X = 50 + maxW / 2;
                        pnt[2].Y = 450;

                        pnt[3].X = 50 + maxW - (maxW - minW) / 2;
                        pnt[3].Y = 450 + r - h2;

                        pnt[4].X = 50 + maxW;
                        pnt[4].Y = 450 + r + h3;

                        pnt[5].X = 50 + sidelength + extraW;
                        pnt[5].Y = 450 + r + h;

                        pnt[6].X = 50 + extraW;
                        pnt[6].Y = 450 + r + h;

                        g.DrawPolygon(green, pnt);

                        Console.WriteLine("***No.{0} , Great! Heptagon has been drawn on windows form!", i);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Warning !!! Please enter correct parameter for Heptagon !");
                    }
                }
                //  Octagon
                else if (test.ToLower().Contains("octagon"))
                {
                    if (sidelength != 0)
                    {
                        //  Pointer array define
                        Point[] pnt = new Point[8];
                        //  r = a/2(sin C);
                        //  C = 360/16;
                        //  r = sidelength/(2* sin(360/16))
                        int r = Convert.ToInt32(sidelength / (2 * Math.Sin(DegreeToRadian(360 / 16))));
                        //  Law of cosines:  c^{2}=a^{2}+b^{2}-2ab\cos(C);
                        int maxW = Convert.ToInt32(r * 2 * Math.Cos(DegreeToRadian(45 / 2)));
                        int minW = Convert.ToInt32(Math.Sqrt(2 * Math.Pow(r, 2)));
                        int extraW = Convert.ToInt32((Math.Sin(DegreeToRadian(45 / 2))) * sidelength);

                        /*
                        Console.WriteLine(Math.Sin(DegreeToRadian(360 / 16)));
                        Console.WriteLine(r);
                        Console.WriteLine(maxW);
                        Console.WriteLine(minW);
                        Console.WriteLine(extraW);
                        */

                        pnt[0].X = 50;
                        pnt[0].Y = 450 + r;

                        pnt[1].X = 50 + extraW;
                        pnt[1].Y = 450 + extraW;

                        pnt[2].X = 50 + r;
                        pnt[2].Y = 450;

                        pnt[3].X = 50 + 2 * r - extraW;
                        pnt[3].Y = 450 + extraW;

                        pnt[4].X = 50 + 2 * r;
                        pnt[4].Y = 450 + r;

                        pnt[5].X = 50 + 2 * r - extraW;
                        pnt[5].Y = 450 + 2 * r - extraW;

                        pnt[6].X = 50 + r;
                        pnt[6].Y = 450 + 2 * r;

                        pnt[7].X = 50 + extraW;
                        pnt[7].Y = 450 + 2 * r - extraW;

                        g.DrawPolygon(green, pnt);

                        Console.WriteLine("***No.{0} , Great! Octagon has been drawn on windows form!", i);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Warning !!! Please enter correct parameter for Octagon !");
                    }
                }

                //---------4th. Circle (Oval,Circle)
                //  Oval Case
                else if (test.ToLower().Contains("oval"))
                {
                    if (width != 0 && height != 0)
                    {
                        Rectangle oval = new Rectangle(450, 450, width, height);
                        g.DrawEllipse(blue, oval);
                        Console.WriteLine("***No.{0} , Great! Oval has been drawn on windows form!", i);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Warning !!! Please enter correct parameter for Oval !");
                    }
                }
                //  Circle case
                else if (test.ToLower().Contains("circle"))
                {
                    if (radius != 0)
                    {
                        Rectangle circle = new Rectangle(450, 450, radius, radius);
                        g.DrawEllipse(blue, circle);
                        Console.WriteLine("***No.{0} , Great! Circle has been drawn on windows form!", i);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Warning !!! Please enter correct parameter for Circle !");
                    }
                }


                //  Stop program
                else if (test.ToLower().Contains("end"))
                {
                    Environment.Exit(0);
                }
                //  Clean program
                else if (test.ToLower().Contains("clean"))
                {
                    e.Graphics.Clear(Color.White);
                    Console.WriteLine("***No.{0} , all shapes has been cleaned up!!", i);
                }
                //  Instructions
                else if (test.ToLower().Contains("guide"))
                {
                    Console.WriteLine();
                    Console.WriteLine("Syntax: Draw a(n) <shape> with a(n) <measurement> of <amount> (and a(n) <measurement> of <amount>)");
                    Console.WriteLine();
                    Console.WriteLine("Here are some examples:  ");
                    Console.WriteLine("Draw a circle with a radius of 100 ");
                    Console.WriteLine("Draw a square with a side length of 200");
                    Console.WriteLine("Draw a rectangle with a width of 250 and a height of 400");
                    Console.WriteLine("Draw an octagon with a side length of 200");
                    Console.WriteLine("Draw an isosceles triangle with a height of 200 and a width of 100");


                }
                //  Invalid Data!
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("***No.{0} , You should enter a correct value!", i);
                }

                i++;
            }


        }
    }
}
