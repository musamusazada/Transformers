using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformers
{
    class SYSTEM
    {
        public void Start()
        {


            RunMainMenu();






        }

        private void RunMainMenu()
        {
            Transformers t1 = new Transformers();

            string prompt = @"
              _______ _____            _   _  _____ ______ ____  _____  __  __ ______ _____   _____ 
             |__   __|  __ \     /\   | \ | |/ ____|  ____/ __ \|  __ \|  \/  |  ____|  __ \ / ____|
                | |  | |__) |   /  \  |  \| | (___ | |__ | |  | | |__) | \  / | |__  | |__) | (___  
                | |  |  _  /   / /\ \ | . ` |\___ \|  __|| |  | |  _  /| |\/| |  __| |  _  / \___ \ 
                | |  | | \ \  / ____ \| |\  |____) | |   | |__| | | \ \| |  | | |____| | \ \ ____) |
                |_|  |_|  \_\/_/    \_\_| \_|_____/|_|    \____/|_|  \_\_|  |_|______|_|  \_\_____/ 
                                                                                        
                                                                                ";
            string[] options = { "Robot", "Car", "Jet", "Boat", "Exit" };

            Menu transformers_menu = new Menu(prompt, options);
            int selectedIndex = transformers_menu.Run();


            switch (selectedIndex)
            {
                case 0:
                    t1.Run();
                    
                    RunMainMenu();
                    break;
                case 1:
                    t1.Run(Environment.Road);
                   
                    RunMainMenu();
                    break;
                case 2:
                    t1.Run(Environment.Air);
                   
                    RunMainMenu();
                    break;
                case 3:
                    t1.Run(Environment.Water);
                    
                    RunMainMenu();
                    break;
                case 4:
                    Console.Clear();
                    
                    Console.WriteLine("Program terminated");
                    Console.ReadKey(true);
                    break;

            }
        }
    }
}

