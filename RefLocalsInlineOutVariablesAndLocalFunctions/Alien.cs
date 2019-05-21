using System;

namespace RefLocalsInlineOutVariablesAndLocalFunctions
{
    public class Alien
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int HealthPoints { get; set; }

        public void Move()
        {

        }

        public void Attack()
        {

        }
        public void Defend()
        {

        }

        public void Run()
        {

        }

        public void Decide()
        {
            // engage or flee? 
            Random r = new Random();
            int num = r.Next(1, 10);
            if (num % 2 == 0)
            {
                // engage
                num = r.Next(1, 10);
                if (num % 2 == 0)
                {
                    Attack();
                }
                else
                {
                    Defend();
                }
            }
            else
            {
                // run 
            }
        }

        public void DecideWithLocalFunction()
        {
            Random r = new Random();
            int num = r.Next(1, 10);
            if (isEven(num))
            {
                // engage
                num = r.Next(1, 10);
                if (isEven(num))
                {
                    Attack();
                }
                else
                {
                    Defend();
                }
            }
            else
            {
                // run 
                Run(); 
            }
        }

        bool isEven(int value)
        {
            return (value % 2 == 0);
        }


    }
}