namespace TP_MODUL4_103022400008 
{
    public class DoorMachine
    {
        public enum State {TERKUNCI,TERBUKA}

        public static void Start()
        {
            State currentState = State.TERKUNCI;
            string[] conditionName = {"TERKUNCI","TERBUKA"};

            Console.WriteLine("Kondisi awal: " + conditionName[(int) currentState]);

            Console.Write("Masukkan kondisi(BukaPintu/KunciPintu): ");
            string getInputCondition = Console.ReadLine().ToUpper();

            while (getInputCondition != "")
            {
                switch (currentState)
                {
                    case State.TERKUNCI:
                        if (getInputCondition == "BUKAPINTU")
                        {
                            currentState = State.TERBUKA;
                        }
                        else
                        {
                            currentState = State.TERKUNCI;
                        }
                        break;
                    case State.TERBUKA:
                        if (getInputCondition == "KUNCIPINTU")
                        {
                            currentState = State.TERKUNCI;
                        }
                        else
                        {
                            currentState = State.TERBUKA;
                        }
                        break;
                }

                Console.WriteLine("Kondisi pintu sekarang: " + conditionName[(int) currentState]);

                Console.Write("Masukkan kondisi(BukaPintu/KunciPintu): ");
                getInputCondition = Console.ReadLine().ToUpper();
            }
        }
    }
}