using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe {

    public enum Color {
        Black, Red
    }

    public struct Coordinates {
        public int X;
        public int Y;
    }


    public class Checker {
        public Color Color { get; private set; }

        public bool King { get; set; }

        public Coordinates Coords;
       

        public Checker(Color color, int x, int y, bool king=false) {
            this.Color = color;
            this.Coords = new Coordinates();
            this.Coords.X = x;
            this.Coords.Y = y;
            this.King = king;
        }

    }
}
