using System;

namespace interface_segregation
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("\t car:");
            Car car = new Car();
            car.Drive(50);
            car.LaunchRocket();

            Console.WriteLine("\n \t flying car 1:");
            FlyingCar flyingCar = new FlyingCar();
            flyingCar.Drive(200);
            flyingCar.LaunchRocket();

            Console.WriteLine("\n \t flying car 2:");
            FlyingCar flyingCar2 = new FlyingCar();
            flyingCar2.LaunchRocket();
            flyingCar2.Drive(200);

            Console.WriteLine("\n \t space ship 1:");
            SpaceShip spaceShip = new SpaceShip();
            spaceShip.Drive(3000);
            spaceShip.LaunchRocket();

            Console.WriteLine("\n \t space ship 2:");
            SpaceShip spaceShip2 = new SpaceShip();
            spaceShip2.LaunchRocket();
            spaceShip2.Drive(3000);
        }
	}
    interface IDrivable
    {
        void Drive(long miles);
    }

 

    class Car : IDrivable
    {
        public void Drive(long miles)
        {
            Console.WriteLine("I am driven to {0} miles away ...", miles);
        }

        public void LaunchRocket()
        {
            Console.WriteLine("I don't have any rocket to launch ...");
        }
    }

    class FlyingCar : IDrivable
    {
        private bool _isRocketLaunched;

        public void Drive(long miles)
        {
            if (!_isRocketLaunched)
            {
                Console.WriteLine("Launch the rocket first or this flying car can not get driven.");
            }
            else
            {
                Console.WriteLine("I am flying to {0} miles away ...", miles);
            }
        }

        public void LaunchRocket()
        {
            _isRocketLaunched = true;
        }
    }

    class SpaceShip : IDrivable
    {
        private bool _isRocketLaunched;

        public void Drive(long miles)
        {
            if (!_isRocketLaunched)
            {
                Console.WriteLine("Spaceship can't leave Earth if its rocket is not launched !");
            }
            else
            {
                Console.WriteLine("The spaceship is going {0} miles away", miles);
            }
        }

        public void LaunchRocket()
        {
            _isRocketLaunched = true;
        }
    }
    }
