// See https://aka.ms/new-console-template for more information

namespace TPMODUL4_1302210036
{
    class Mainprog
    {
        public static void Main(string[] args)
        {
            KodePos TKP = new KodePos();
            Console.WriteLine("Kode Pos semua daerah");
            TKP.getAllPosCode();
            Console.WriteLine("\n");
        }
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

    public void getKodePos(string kode)
    {
        if (dic_code_daerah.ContainsKey(kode))
        {
            Console.WriteLine(kode + " : " + dic_code_daerah[kode]);
        }
        else
        {
            Console.WriteLine(kode + "Kode tidak ditemukan");
        };
    }

    public void getAllPosCode()
    {
        foreach (KeyValuePair<string, int> i in dic_code_daerah)
        {
            Console.WriteLine(i.Key + " : " + i.Value);
        }
    }
}


