using ShapeLib.VShape;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ShapeLib.VShape
{
    public class ShapeCircle : ShapeObj
    {


        public override System.Collections.ArrayList getMenuItem()
        {

            ArrayList ret = new ArrayList();

            shapeUI ui = new shapeUI();
            ui.label = "Cylinder";

            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream myStream = myAssembly.GetManifestResourceStream("ShapeLib.icons.Cylinder.png");
            ui.image = new System.Drawing.Bitmap(myStream);



            ui.belong = "Shapes";
            ui.click = this.btn_Click;
            ret.Add(ui);

            return ret;
            //throw new NotImplementedException();
        }


        public override void DrawShape(gView gv, gPath data, Boolean bfirst)
        {
            if (bfirst)
            {
                shapeLib.Data.Status = "rest";
                shapeLib.Data.bfirst = false;

                //二個直線
                Line myLine1 = new Line();
                myLine1.Stroke = new SolidColorBrush(Color.FromRgb(data.state.colorR, data.state.colorG, data.state.colorB));//

                myLine1.X1 = data.controlBtn1.X;
                myLine1.Y1 = data.controlBtn1.Y;
                myLine1.X2 = data.controlBtn1.X;
                myLine1.Y2 = data.controlBtn4.Y;
                //myLine1.X1 = 100;
                //myLine1.Y1 = 100;
                //myLine1.X2 = 100;
                //myLine1.Y2 = 500;
                myLine1.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                myLine1.VerticalAlignment = VerticalAlignment.Center;
                myLine1.StrokeThickness = shapeLib.Data.strokeT;//
                myLine1.MouseLeftButtonDown += data.myLine_MouseLeftButtonDown;
                myLine1.MouseEnter += data.myLine_MouseEnter;
                myLine1.MouseLeave += data.myLine_MouseLeave;
                shapeLib.Data.mygrid.Children.Add(myLine1);
                gv.baseShape.Add(myLine1);
                // currPath.setDrawShape( myLine);


                Line myLine2 = new Line();
                myLine2.Stroke = myLine1.Stroke;

                myLine2.X1 = data.controlBtn4.X;
                myLine2.Y1 = data.controlBtn1.Y;
                myLine2.X2 = data.controlBtn4.X;
                myLine2.Y2 = data.controlBtn4.Y;
                //myLine2.X1 = 500;
                //myLine2.Y1 = 100;
                //myLine2.X2 = 500;
                //myLine2.Y2 = 500;
                myLine2.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                myLine2.VerticalAlignment = VerticalAlignment.Center;
                myLine2.StrokeThickness = myLine1.StrokeThickness;//
                myLine2.MouseLeftButtonDown += data.myLine_MouseLeftButtonDown;
                myLine2.MouseEnter += data.myLine_MouseEnter;
                myLine2.MouseLeave += data.myLine_MouseLeave;
                shapeLib.Data.mygrid.Children.Add(myLine2);
                gv.baseShape1.Add(myLine2);
                // currPath.setDrawShape( myLine);

                double i = (data.controlBtn4.Y - data.controlBtn1.Y) / 5;


                //二個橢圓
                Ellipse myEllipse = new Ellipse();
                // Create a SolidColorBrush with a red color to fill the 
                // Ellipse with.

                myEllipse.Stroke = new SolidColorBrush(Color.FromRgb(data.state.colorR, data.state.colorG, data.state.colorB));
                // Set the width and height of the Ellipse.
                myEllipse.Width = Math.Abs(data.controlBtn4.X - data.controlBtn1.X);
                myEllipse.Height = Math.Abs((data.controlBtn1.Y+i) - (data.controlBtn1.Y-i));/*h*/
                //myEllipse.Width = Math.Abs(500 - 100);
                //myEllipse.Height = Math.Abs(150 - 50);/*h*/
                myEllipse.Margin = new Thickness(data.controlBtn1.X, data.controlBtn1.Y-i, 0, 0);
                                                        /// <summary>
                                                        ///繪製橢圓起始位置
                                                        /// </summary>
                myEllipse.StrokeThickness = shapeLib.Data.strokeT;
                myEllipse.MouseLeftButtonDown += data.myLine_MouseLeftButtonDown;
                myEllipse.MouseEnter += data.myLine_MouseEnter;
                myEllipse.MouseLeave += data.myLine_MouseLeave;
                shapeLib.Data.mygrid.Children.Add(myEllipse);
                gv.baseShape2.Add(myEllipse);


                Ellipse myEllipse2 = new Ellipse();

                myEllipse2.Stroke = new SolidColorBrush(Color.FromRgb(data.state.colorR, data.state.colorG, data.state.colorB));
                myEllipse2.Width = Math.Abs(data.controlBtn4.X - data.controlBtn1.X);
                myEllipse2.Height = Math.Abs((data.controlBtn4.Y + i) - (data.controlBtn4.Y - i));/*h*/
                //myEllipse2.Margin = new Thickness(data.controlBtn1.X, (data.controlBtn1.Y - 2), 0, 0);/*h*/
                //myEllipse2.Width = Math.Abs(500 - 100);
                //myEllipse2.Height = Math.Abs(450 - 550);/*h*/
                myEllipse2.Margin = new Thickness(data.controlBtn1.X, data.controlBtn4.Y-i, 0, 0);/*h*/
                myEllipse2.StrokeThickness = shapeLib.Data.strokeT;
                myEllipse2.MouseLeftButtonDown += data.myLine_MouseLeftButtonDown;
                myEllipse2.MouseEnter += data.myLine_MouseEnter;
                myEllipse2.MouseLeave += data.myLine_MouseLeave;
                shapeLib.Data.mygrid.Children.Add(myEllipse2);
                gv.baseShape3.Add(myEllipse2);

            }
            else
            {
                double i = (data.controlBtn4.Y - data.controlBtn1.Y) / 5;

                //二個橢圓
                Ellipse myEllipse = (Ellipse)gv.baseShape2[0];
                myEllipse.Width = Math.Abs(data.controlBtn4.X - data.controlBtn1.X);
                myEllipse.Height = Math.Abs((data.controlBtn1.Y + i) - (data.controlBtn1.Y - i));/*h*/
                myEllipse.Margin = new Thickness(data.controlBtn1.X, data.controlBtn1.Y - i, 0, 0);
                //myEllipse.Width = Math.Abs(500 - 100);
                //myEllipse.Height = Math.Abs(150 - 50);/*h*/
                //myEllipse.Margin = new Thickness(100, 50, 0, 0);

                Ellipse myEllipse2 = (Ellipse)gv.baseShape3[0];
                myEllipse2.Width = Math.Abs(data.controlBtn4.X - data.controlBtn1.X);
                myEllipse2.Height = Math.Abs((data.controlBtn4.Y + i) - (data.controlBtn4.Y - i));/*h*/
                myEllipse2.Margin = new Thickness(data.controlBtn1.X, data.controlBtn4.Y - i, 0, 0);/*h*/
                //myEllipse2.Width = Math.Abs(500 - 100);
                //myEllipse2.Height = Math.Abs(450 - 550);/*h*/


                //二個直線
                Line myLine1 = (Line)gv.baseShape[0]; // =(Line)currPath.getDrawShape();
                myLine1.X1 = data.controlBtn1.X;
                myLine1.Y1 = data.controlBtn1.Y;
                myLine1.X2 = data.controlBtn1.X;
                myLine1.Y2 = data.controlBtn4.Y;
                //myLine1.X2 = 100;
                //myLine1.Y2 = 500;

                Line myLine2 = (Line)gv.baseShape1[0];// =(Line) currPath.getDrawShape();
                myLine2.X1 = data.controlBtn4.X;
                myLine2.Y1 = data.controlBtn1.Y;
                myLine2.X2 = data.controlBtn4.X;
                myLine2.Y2 = data.controlBtn4.Y;
                //myLine2.X2 = 500;
                //myLine2.Y2 = 500;
            }
        }

        /*public virtual void DisplayControlPoints(gView gv, gPath data)//一條線
        {
            if (gv.controlShape.Count == 0)
            {
                Line myLine1 = new Line();
                myLine1.Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 255, 0));
                myLine1.X1 = data.controlBtn1.X;
                myLine1.Y1 = data.controlBtn1.Y;
                myLine1.X2 = data.controlBtn4.X;
                myLine1.Y2 = data.controlBtn4.Y;
                myLine1.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                myLine1.VerticalAlignment = VerticalAlignment.Center;
                myLine1.StrokeThickness = shapeLib.Data.strokeT;
                myLine1.MouseLeftButtonDown += data.myLine_MouseLeftButtonDown;
                myLine1.MouseEnter += data.myLine_MouseEnter;
                myLine1.MouseLeave += data.myLine_MouseLeave;
                shapeLib.Data.mygrid.Children.Add(myLine1);
                gv.controlShape.Add(myLine1);

                Line myLine2 = new Line();
                myLine2.Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 255, 0));
                myLine2.X1 = data.controlBtn1.X;
                myLine2.Y1 = data.controlBtn1.Y;
                myLine2.X2 = data.controlBtn4.X;
                myLine2.Y2 = data.controlBtn4.Y;
                myLine2.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                myLine2.VerticalAlignment = VerticalAlignment.Center;
                myLine2.StrokeThickness = shapeLib.Data.strokeT;
                myLine2.MouseLeftButtonDown += data.myLine_MouseLeftButtonDown;
                myLine2.MouseEnter += data.myLine_MouseEnter;
                myLine2.MouseLeave += data.myLine_MouseLeave;
                shapeLib.Data.mygrid.Children.Add(myLine2);
                gv.controlShape.Add(myLine2);
            }
            else
            {
                Line myLine = (Line)gv.controlShape[0];// =(Line) currPath.getDrawShape();

                myLine.X1 = data.controlBtn1.X;
                myLine.Y1 = data.controlBtn1.Y;
                myLine.X2 = data.controlBtn4.X;
                myLine.Y2 = data.controlBtn4.Y;

            }


            // throw new NotImplementedException();
        }*/
    }
}



/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ShapeLib.VShape
{
    public class ShapeCircle : ShapeObj
    {


        public override System.Collections.ArrayList getMenuItem()
        {

            ArrayList ret = new ArrayList();

            shapeUI ui = new shapeUI();
            ui.label = "Circle";

            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream myStream = myAssembly.GetManifestResourceStream("ShapeLib.icons.circle.png");
            ui.image = new System.Drawing.Bitmap(myStream);


          
            ui.belong = "Shapes";
            ui.click = this.btn_Click;
            ret.Add(ui);

            return ret;
            //throw new NotImplementedException();
        }


        public override void DrawShape(gView gv, gPath data, Boolean bfirst)
        {
            if (bfirst)
            {
                shapeLib.Data.Status = "rest";
                shapeLib.Data.bfirst = false;
                Ellipse  myEllipse = new Ellipse();
                // Create a SolidColorBrush with a red color to fill the 
                // Ellipse with.
              
                myEllipse.Stroke = new SolidColorBrush(Color.FromRgb(data.state.colorR, data.state.colorG, data.state.colorB));
                // Set the width and height of the Ellipse.
                myEllipse.Width = Math.Abs(data.controlBtn4.X - data.controlBtn1.X);
                myEllipse.Height = Math.Abs(data.controlBtn4.Y- data.controlBtn1.Y);
                myEllipse.Margin = new Thickness(data.controlBtn1.X, data.controlBtn1.Y, 0, 0);
                myEllipse.StrokeThickness = shapeLib.Data.strokeT;
                myEllipse.MouseLeftButtonDown += data.myLine_MouseLeftButtonDown;
                myEllipse.MouseEnter += data.myLine_MouseEnter;
                myEllipse.MouseLeave += data.myLine_MouseLeave; 
                shapeLib.Data.mygrid.Children.Add(myEllipse);
                gv.baseShape.Add(myEllipse);
            }
            else
            {
                Ellipse myEllipse = (Ellipse)gv.baseShape[0];
                myEllipse.Width = Math.Abs(data.controlBtn4.X - data.controlBtn1.X);
                myEllipse.Height = Math.Abs(data.controlBtn4.Y - data.controlBtn1.Y);
                myEllipse.Margin = new Thickness(data.controlBtn1.X, data.controlBtn1.Y, 0, 0);
            }
        }

        
    }
}*/
