// See https://aka.ms/new-console-template for more information

namespace TPMODUL4_1302210036
{
    class Mainprog
    {
        public static void Main(string[] args)
        {
            KodePos TKP = new KodePos();
            DoorMachine pintu = new DoorMachine();
            Console.WriteLine("Kode Pos semua daerah");
            TKP.getAllPosCode();
            Console.WriteLine("\n");

            Console.WriteLine("Door Status");

            pintu.key();
        }
    }
    class KodePos
    {
        Dictionary<string, int> dic_code_daerah = new Dictionary<string, int>()
        {
            {"Batununggal", 40266 },
            {"Kujangsari", 40287 },
            {"Mengger", 40267 },
            {"Wates", 40256 },
            {"Cijaura", 40287 },
            {"Jatisari", 40286 },
            {"Margasari", 40286 },
            {"Sekajati", 40286 },
            {"Kebonwaru", 40272 },
            {"Mleer", 40274 },
            {"Samoja", 40273 },
        };

        public void getkodepos(string kode)
        {
            if (dic_code_daerah.ContainsKey(kode))
            {
                Console.WriteLine(kode + " : " + dic_code_daerah[kode]);
            }
            else
            {
                Console.WriteLine(kode + "Kode tidak terdaftar");
            }
        }
        public void getAllPosCode()
        {
            foreach (KeyValuePair<string, int> i in dic_code_daerah)
            {
                Console.WriteLine(i.Key + " : " + i.Value);
            }
        }
    }
    class DoorMachine
    {
        enum State { Locked, Unlocked, Exit };

        public void key()
        {
            State state = State.Locked;

            string[] door_stat = { "Locked", "Unlocked", "Exit Program" };
            do
            {
                Console.WriteLine("Door " + door_stat[(int)state]);
                Console.WriteLine("1. Buka Pintu");
                Console.WriteLine("2. Kunci Pintu");
                Console.WriteLine("3. Keluar");
                Console.WriteLine("Pilihan: ");
                string command = Console.ReadLine();
                switch (state)
                {
                    case State.Locked:
                        if (command == "1")
                        {
                            state = State.Unlocked;
                        }
                        break;
                    case State.Unlocked:
                        if (command == "2")
                        {
                            state = State.Locked;
                        }
                        break;
                    case State.Exit:
                        break;
                }
                if (command == "3")
                {
                    state = State.Exit;
                }
                   
            } while (state != State.Exit);
        }
    }
}




    