using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Transformers
{
    class Transformers
    {
        internal byte wheel;
        internal int maxSpeed;
      


       

        internal  virtual void Run(Environment env = Environment.Robot)
        {
            switch (env)
            {
                case Environment.Road:
                    CAR car = new CAR(200, 200);
                    car.Run();
                    break;
                case Environment.Air:
                    JET jet = new JET(100, 100);               
                    break;
                case Environment.Water:
                    BOAT boat = new BOAT(0, 200);                  
                    break;
              default:
                    AnimationRobot(robot);
                    break;
            }
        }




        internal  void Animation(string[] array, int animationSpeed=200, int outerLimit=0)
        {
            Console.CursorVisible = false;
            for (int i = 0; i < array.Length; i++)
            {
                
                    Console.Clear();
                    Console.SetCursorPosition(100, 10);
                    Console.Write(array[i]);
                
                    Thread.Sleep(animationSpeed);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                    if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }



            }
            Console.CursorVisible = true;
        }




        internal void AnimationRobot(string[] array, int animationSpeed = 200, int outerLimit = 5)
        {
            Console.CursorVisible = false;

            for (int j = 0; j < outerLimit; j++)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Clear();
                    Console.SetCursorPosition(100, 10);
                    Console.Write(array[i]);
                    Thread.Sleep(animationSpeed);

                    
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            }
            Console.CursorVisible = true;
        }

        string[] robot =
        {
                                        @"
                                                    _  |@@|
                                                    / \ \--/ __
                                                    ) O|----|  |   __
                                                    / / \ }{ /\ )_ / _\
                                                    )/  /\__/\ \__O (__
                                                |/  (--/\--)    \__/
                                                /   _)(  )(_
                                                    `---''---`
            ",
                                                @"
                                                        __
                                                _(\    |@@|
                                            (__/\__ \--/ __
                                                \___|----|  |   __
                                                    \ }{ /\ )_ / _\
                                                    /\__/\ \__O (__
                                                    (--/\--)    \__/
                                                    _)(  )(_
                                                    `---''---`
             "

        };



        
    }
}
