﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delaunay
{
    class Delaunay_Service
    {
        //algorithm of Bowyer-Watson to make Delaunay triangulation
        public static List<Triangle> BowyerWatsonAlgorithm(List<PointF> list)
        {
            //list of triangles
            List<Triangle> triangleList = new List<Triangle>();

            //find super triangle and add it to list
            Triangle superTriangle = Geometry_Service.superTriangle(list);
            triangleList.Add(superTriangle);

            //checking each point in list
            for (int i = 0; i < list.Count; i++)
            {
                //list to store all edges of triangles
                List<Edge> edgeList = new List<Edge>();

                //check if point is inside the circumscribed circle on given triangle
                for (int j = 0; j < triangleList.Count; j++)
                {
                    if (Geometry_Service.isInsideCircle(list[i], triangleList[j]) == true)
                    {

                    }
                }
            }

            return triangleList;
        }
    }
}