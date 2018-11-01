﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delaunay.Model3D
{
    class Drawing_Service
    {
        public static Bitmap DrawAxis(Graphics graphics, Bitmap bitmap, PointF start)
        {

            graphics.DrawLine(new Pen(Color.Red), start, new PointF(start.X + 100, start.Y));
            graphics.DrawLine(new Pen(Color.Blue), start, new PointF(start.X, start.Y - 100));
            graphics.DrawLine(new Pen(Color.Green), start, new PointF(120, 250));

            return bitmap;
        }

        public static List<Vector3D> randomPoints(Bitmap bitmap, Graphics graphics, PictureBox pictureBox, int numberOfPoints, int width, int height, int depth)
        {
            List<Vector3D> list = new List<Vector3D>();
            Random random = new Random();

            //finds coordinates of all points
            for (int i = 0; i < numberOfPoints; i++)
            {
                int x = random.Next(0, width);
                int y = random.Next(0, height);
                int z = random.Next(0, depth);
                list.Add(new Vector3D(x, y, z));

                //graphics.DrawRectangle(new Pen(Color.Black), x, y, 3, 3);
            }
            //pictureBox.Image = bitmap;

            //return list of poitns
            return list;
        }

        public static Bitmap drawingCube(Cube cube, Graphics graphics, Bitmap bitmap)
        {
            Pen pen = new Pen(Color.Black);

            //front
            graphics.DrawLines(pen, cube.front.tops2d);
            graphics.DrawLine(pen, cube.front.tops2d[3], cube.front.tops2d[0]);

            //back
            graphics.DrawLines(pen, cube.back.tops2d);
            graphics.DrawLine(pen, cube.back.tops2d[3], cube.back.tops2d[0]);

            //left
            graphics.DrawLines(pen, cube.left.tops2d);
            graphics.DrawLine(pen, cube.left.tops2d[3], cube.left.tops2d[0]);

            //right
            graphics.DrawLines(pen, cube.right.tops2d);
            graphics.DrawLine(pen, cube.right.tops2d[3], cube.right.tops2d[0]);

            //top
            graphics.DrawLines(pen, cube.top.tops2d);
            graphics.DrawLine(pen, cube.top.tops2d[3], cube.top.tops2d[0]);

            //bottom
            graphics.DrawLines(pen, cube.bottom.tops2d);
            graphics.DrawLine(pen, cube.bottom.tops2d[3], cube.bottom.tops2d[0]);

            return bitmap;
        }
    }
}
