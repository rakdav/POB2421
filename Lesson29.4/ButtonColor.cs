using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson29._4
{
    internal class ButtonColor
    {
        public Color GetColor()
        {
            Random random = new Random();
            return Color.FromArgb(random.Next(0, 256),
                random.Next(0, 256),
                random.Next(0, 256));
        }
    }
}
