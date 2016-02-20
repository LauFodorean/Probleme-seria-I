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

        public enum Direction { up, down, left, right}

        public pointCoordinates move(pointCoordinates point, Direction direction)
        {
            switch (direction)
            {
                case Direction.up:
                    point.y = point.y + 3;
                    break;
                case Direction.down:
                    point.y = point.y - 3;
                    break;
                case Direction.left:
                    point.x = point.x - 3;
                    break;
                case Direction.right:
                    point.x = point.x + 3;
                    break;
            }
            return point;
        }

        [TestMethod]
        public void TestMethodForMoveFunctionUp()
        {
            pointCoordinates origin = new pointCoordinates { x = 0, y = 0 };
            Assert.AreEqual(new pointCoordinates { x = 0, y = 3 }, move(origin, Direction.up));
        }

        [TestMethod]
        public void TestMethodForMoveFunctionDown()
        {
            pointCoordinates origin = new pointCoordinates { x = 0, y = 0 };
            Assert.AreEqual(new pointCoordinates { x = 0, y = -3 }, move(origin, Direction.down));
        }

        [TestMethod]
        public void TestMethodForMoveFunctionRight()
        {
            pointCoordinates origin = new pointCoordinates { x = 0, y = 0 };
            Assert.AreEqual(new pointCoordinates { x = 3, y = 0 }, move(origin, Direction.right));
        }

        [TestMethod]
        public void TestMethodForMoveFunctionLeft()
        {
            pointCoordinates origin = new pointCoordinates { x = 0, y = 0 };
            Assert.AreEqual(new pointCoordinates { x = -3, y = 0 }, move(origin, Direction.left));
        }

        [TestMethod]
        public void TestMethodWithOneIntersection()
        {
            pointCoordinates origin = new pointCoordinates { x = 0, y = 0 };
            Direction[] listOfDirections = new Direction[] { Direction.up, Direction.right, Direction.right, Direction.up, Direction.left, Direction.down };
            Assert.AreEqual(new pointCoordinates { x = 3, y = 3 }, GetFirstIntersection(origin, listOfDirections));
        }

        [TestMethod]
        public void TestMethodWithTwoIntersections()
        {
            pointCoordinates origin = new pointCoordinates { x = 0, y = 0 };
            Direction[] listOfDirections = new Direction[] { Direction.up, Direction.right, Direction.right, Direction.up, Direction.left, Direction.down, Direction.down, Direction.right, Direction.up };
            Assert.AreEqual(new pointCoordinates { x = 3, y = 3 }, GetFirstIntersection(origin, listOfDirections));
        }

        [TestMethod]
        public void TestMethodWhereFirstIntersectionIsPointOfOrigin()
        {
            pointCoordinates origin = new pointCoordinates { x = 0, y = 0 };
            Direction[] listOfDirections = new Direction[] { Direction.up, Direction.right, Direction.down, Direction.left};
            Assert.AreEqual(new pointCoordinates { x = 0, y = 0 }, GetFirstIntersection(origin, listOfDirections));
        }

        [TestMethod]
        public void TestMethodWhereWeGoBackwards()
        {
            pointCoordinates origin = new pointCoordinates { x = 0, y = 0 };
            Direction[] listOfDirections = new Direction[] { Direction.up, Direction.down };
            Assert.AreEqual(new pointCoordinates { x = 0, y = 3 }, GetFirstIntersection(origin, listOfDirections));
        }

        [TestMethod]
        public void TestMethodWhereWeGoBackwardsOnFourthMove()
        {
            pointCoordinates origin = new pointCoordinates { x = 0, y = 0 };
            Direction[] listOfDirections = new Direction[] { Direction.up, Direction.right, Direction.up, Direction.down };
            Assert.AreEqual(new pointCoordinates { x = 3, y = 6 }, GetFirstIntersection(origin, listOfDirections));
        }

        //[TestMethod]
        //public void TestMethodWhereWeHaveNoIntersection()
        //{
        //    pointCoordinates origin = new pointCoordinates { x = 0, y = 0 };
        //    Direction[] listOfDirections = new Direction[] { Direction.up, Direction.right, Direction.up};
        //    Assert.AreEqual("There is no intersection", GetFirstIntersection(origin, listOfDirections));
        //}

        public pointCoordinates GetFirstIntersection(pointCoordinates origin, Direction[] listOfMoves)
        {
            pointCoordinates[] jointPoints = new pointCoordinates[listOfMoves.Length+1];
            pointCoordinates intersectionPoint = new pointCoordinates { x = origin.x, y = origin.y };
            jointPoints[0].x = origin.x;
            jointPoints[0].y = origin.y;
            int i = 1;
            bool firstIntersectionPoint = false;
            while (i <= listOfMoves.Length && firstIntersectionPoint == false)
            {
                jointPoints[i].x = jointPoints[i - 1].x + move(origin,listOfMoves[i - 1]).x;
                jointPoints[i].y = jointPoints[i - 1].y + move(origin,listOfMoves[i - 1]).y;
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
            if (intersectionPoint.x == jointPoints[i - 3].x && intersectionPoint.y == jointPoints[i - 3].y)
            {
                intersectionPoint.x = jointPoints[i - 2].x;
                intersectionPoint.y = jointPoints[i - 2].y;
                firstIntersectionPoint = true;
            }
            else
                firstIntersectionPoint = false;

            //if (firstIntersectionPoint == false)
            //    return string "There is no intersection";
            
            return intersectionPoint;
        }


    }
}
