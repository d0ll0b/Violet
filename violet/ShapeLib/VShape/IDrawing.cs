﻿using ShapeLib.VShape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib.VShape
{
    interface IDrawing
    {
        void DrawShape(gView  gv ,gPath data,Boolean bfirst );
        void DisplayControlPoints(gView gv, gPath data);


    }
}
