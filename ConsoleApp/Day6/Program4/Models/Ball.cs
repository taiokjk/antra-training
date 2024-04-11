using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Day6.Program4.Models
{
    internal class Ball
    {
        private int Size {  get; set; }
        private int ThrowCount {  get; set; }
        private Color Color { get; set; }

        public Ball(int size, Color color)
        {
            Size = size;
            ThrowCount = 0;
            Color = color;
        }

        public void Pop()
        {
            Size = 0;
        }

        public void Throw()
        {
            if (Size != 0)
                ThrowCount++;
        }

        public int NumberOfThrown()
        {
            return ThrowCount;
        }
    }
}
