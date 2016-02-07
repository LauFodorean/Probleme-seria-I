using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Intersection
{
    [TestClass]
    public class UnitTest1
    {
        public struct pointCoordinates
        {
            public int x;
            public int y;
            pointCoordinates(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        [TestMethod]
        public void TestMethodWithOneIntersection()
        {
            pointCoordinates origin = new pointCoordinates { x = 0, y = 0 };
            pointCoordinates upSegment = new pointCoordinates { x = 0, y = 3 };
            pointCoordinates downSegment = new pointCoordinates { x = 0, y = -3 };
            pointCoordinates leftSegment = new pointCoordinates { x = -3, y = 0 };
            pointCoordinates rightSegment = new pointCoordinates { x = 3, y = 0 };
            pointCoordinates[] segmentConstruction = new pointCoordinates[] { origin, upSegment, rightSegment, rightSegment, upSegment, leftSegment, downSegment };
            Assert.AreEqual(new pointCoordinates { x = 3, y = 3 }, GetFirstIntersection(segmentConstruction));

        }

        [TestMethod]
        public void TestMethodWithTwoIntersections()
        {
            pointCoordinates origin = new pointCoordinates { x = 0, y = 0 };
            pointCoordinates upSegment = new pointCoordinates { x = 0, y = 3 };
            pointCoordinates downSegment = new pointCoordinates { x = 0, y = -3 };
            pointCoordinates leftSegment = new pointCoordinates { x = -3, y = 0 };
            pointCoordinates rightSegment = new pointCoordinates { x = 3, y = 0 };
            pointCoordinates[] segmentConstruction = new pointCoordinates[] { origin, upSegment, rightSegment, rightSegment, upSegment, leftSegment, downSegment, downSegment, rightSegment, upSegment };
            Assert.AreEqual(new pointCoordinates { x = 3, y = 3 }, GetFirstIntersection(segmentConstruction));

        }

        [TestMethod]
        public void TestMethodWhereFirstIntersectionIsPointOfOrigin()
        {
            pointCoordinates origin = new pointCoordinates { x = 0, y = 0 };
            pointCoordinates upSegment = new pointCoordinates { x = 0, y = 3 };
            pointCoordinates downSegment = new pointCoordinates { x = 0, y = -3 };
            pointCoordinates leftSegment = new pointCoordinates { x = -3, y = 0 };
            pointCoordinates rightSegment = new pointCoordinates { x = 3, y = 0 };
            pointCoordinates[] segmentConstruction = new pointCoordinates[] { origin, upSegment, rightSegment, downSegment, leftSegment };
            Assert.AreEqual(new pointCoordinates { x = 0, y = 0 }, GetFirstIntersection(segmentConstruction));

        }
        
        public pointCoordinates GetFirstIntersection(pointCoordinates[] listOfSegments)
        {
            pointCoordinates[] jointPoints = new pointCoordinates[listOfSegments.Length];
            pointCoordinates intersectionPoint = new pointCoordinates { x = 0, y = 0 };
            jointPoints[0].x = listOfSegments[0].x;
            jointPoints[0].y = listOfSegments[0].y;
            int i = 1;
            bool firstIntersectionPoint = false;
            while (i < listOfSegments.Length && firstIntersectionPoint == false)
            {
                jointPoints[i].x = jointPoints[i - 1].x + listOfSegments[i].x;
                jointPoints[i].y = jointPoints[i - 1].y + listOfSegments[i].y;
                int j = i - 1;
                while (j >= 0)
                {
                    if (jointPoints[i].x == jointPoints[j].x && jointPoints[i].y == jointPoints[j].y)
                    {
                        intersectionPoint.x = jointPoints[i].x;
                        intersectionPoint.y = jointPoints[i].y;
                        firstIntersectionPoint = true;
                    }
                    j--;
                }
                i++;
            }

            return intersectionPoint;

        }


    }
}
