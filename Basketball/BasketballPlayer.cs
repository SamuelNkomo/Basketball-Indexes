using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball
{
    public class BasketballPlayer
    {
        private int JerseyNumber;
        private string Position, FirstName, LastName;
        private double PointsPerGame;

        public BasketballPlayer(int jerseyNumber, string position, string firstName, string lastName, double pointsPerGame)
        {
            JerseyNumber = jerseyNumber;
            Position = position;
            FirstName = firstName;
            LastName = lastName;
            PointsPerGame = pointsPerGame;
        }

        public object this[int index]
        {
            get
            {
                return index switch
                {
                    0 => JerseyNumber,
                    1 => Position,
                    2 => FirstName,
                    3 => LastName,
                    4 => PointsPerGame,
                    _ => throw new IndexOutOfRangeException("Invalid index")
                };
            }
            set
            {
                switch (index)
                {
                    case 0:
                        JerseyNumber = (int)value;
                        break;
                    case 1:
                        Position = (string)value;
                        break;
                    case 2:
                        FirstName = (string)value;
                        break;
                    case 3:
                        LastName = (string)value;
                        break;
                    case 4:
                        PointsPerGame = (double)value;
                        break;
                    default:
                        throw new IndexOutOfRangeException("Invalid index");
                }
            }
        }

        public object this[string attrName]
        {
            get
            {
                return attrName.ToLower() switch
                {
                    "jerseynumber" => JerseyNumber,
                    "position" => Position,
                    "firstname" => FirstName,
                    "lastname" => LastName,
                    "pointspergame" => PointsPerGame,
                    _ => throw new ArgumentException("Invalid attribute name")
                };
            }
            set
            {
                switch (attrName.ToLower())
                {
                    case "jerseynumber":
                        JerseyNumber = (int)value;
                        break;
                    case "position":
                        Position = (string)value;
                        break;
                    case "firstname":
                        FirstName = (string)value;
                        break;
                    case "lastname":
                        LastName = (string)value;
                        break;
                    case "pointspergame":
                        PointsPerGame = (double)value;
                        break;
                    default:
                        throw new ArgumentException("Invalid attribute name");
                }
            }
        }
    }
}
