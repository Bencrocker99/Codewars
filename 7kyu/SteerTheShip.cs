//You're a pirate. Arrr!

//Your task is to steer the pirate ship to the designated location.

//Return the direction (left / right) and the angle of how much the ship needs to be turned (in degrees).

//More Info:

//The ship will always start at Cartesian Coordinate (0,0) facing North.
//If the angle is 0 or 180, the direction does NOT matter
//Round the result to 2 decimal places if necessary
//Examples:

//Steer(1, 1)   => "R: 45"  // turn right for 45 degrees
//Steer(1, 0)   => "R: 90"  // turn right for 90 degrees
//Steer(-1, -1) => "L: 135" // turn left for 135 degrees


//My Solution

namespace SteerTheShip
{
    public static class SteerTheShipProblem
    {
        public static string Steer(double x, double y)
        {
            String direction = "";
            if (x < 0)
            {
                direction = "L: ";
            }
            else direction = "R: ";
            double radians = Math.Atan2(x, y);
            if (radians < 0)
            {
                radians = radians * -1;
            }
            double degrees = radians * (180 / Math.PI);
            degrees = Math.Round(degrees, 2);
            direction = direction + degrees.ToString();
            return direction;
        }
    }
}