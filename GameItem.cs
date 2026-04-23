using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TrésorExpress
{
    abstract class GameItem
    {
        public Point Position; 

        public abstract void Draw(Canvas canvas);  
    }
}