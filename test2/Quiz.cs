using System;
namespace test2
{
    public class Quiz
    {
        //TODO: Refactoring (rename)
        private Random _r;
        private int machineAnswer;
        public string question;

        public Quiz()
        {
            _r = new Random();
            question = Start();
        }

        public string Start()
        {

            int b = _r.Next(10);
            int c = _r.Next(3);
            int d = _r.Next(1, 5);

            if (d == 1)
            {

                machineAnswer = b + c;
                return (b + " + " + c);
            }

            if (d == 2)
            {
                machineAnswer = b - c;
                return (b + " - " + c);
            }

            if (d == 3)
            {
                machineAnswer = b * c;
                return (b + " * " + c);
            }

            if (d == 4)
            {
                machineAnswer = int.Parse(Math.Pow(b, c).ToString());
                return (b + " ^ " + c);

            }

            machineAnswer = 0;
            return ("error, smth went wrong");

        }

        public bool Check(int humanAnswer)
        {
            if (machineAnswer == humanAnswer)
                return true;
            else
                return false;
        }

    }
}
