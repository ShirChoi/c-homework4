using System;

namespace Problem2 {
    class Program {
        static void Main(string[] args) {
            DrawRect();
            System.Console.WriteLine(new string('-', 20));
            DrawRightTriangle();
            System.Console.WriteLine(new string('-', 20));
            DrawIsoscelesTriangle();
            System.Console.WriteLine(new string('-', 20));
            DrawRhombus();
        }

        static void DrawRect() {
            int w = 10;
            int h = 6;

            string rect = new string('*', w) + '\n';
            for(int i = 0; i < h - 2; i++) {
                rect += '*' + new string(' ', w - 2) + '*' + '\n'; 
            }
            rect += new string('*', w);

            System.Console.WriteLine(rect);
        }
    
        static void DrawRightTriangle() {
            string tri = "";
            int w = 6;

            for(int i = 0; i < w - 1; i++) {
                for(int j = 0; j < w; j++) 
                    tri += j == 0 || i == j ? '*' : ' ';
                tri += '\n';
            }
            
            tri += new string('*', 6);

            System.Console.WriteLine(tri);
        }

        static void DrawIsoscelesTriangle() {
            string tri = "";
            int w = 11;
            int h = 6;
            int offset = 0;

            for(int i = 0; i < h - 1; i++) {
                for(int j = 0; j < w; j++) 
                    tri += Math.Abs(j - w / 2) == offset ? '*' : ' ';
                
                tri += '\n';
                offset++;
            }

            tri += new string('*', w);
            System.Console.WriteLine(tri);
        }

        static void DrawRhombus() {
            string rhomb = "";
            int w = 11;
            int h = 11;
            int offset = 0;

            for(int i = 0; i < h; i++) {
                for(int j = 0; j < w; j++) 
                    rhomb += Math.Abs(j - w / 2) == offset ? '*' : ' ';
                
                rhomb += '\n';
                offset += i < h / 2 ? 1 : -1;
            }

            System.Console.WriteLine(rhomb);
        }
    }
}
