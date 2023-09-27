namespace Alphabets
{
    public class Program
    {
        public static void Main()
        {
            
            Console.WriteLine("=====================================================");
            Console.WriteLine("Program Menentukan Jumlah Konsonan, Vocal, dan Spasi");

            Console.WriteLine("Inputkan Text: ");
            string setring = Console.ReadLine();

            int jumlah_vokal = VocalCount(setring);
            int jumlah_konsonan = ConsonantCount(setring);
            int jumlah_space = SpaceCount(setring);
            int jumlah_angka = NumberCount(setring);
            
            Console.WriteLine("Jumlah Vokal: "+jumlah_vokal);
            Console.WriteLine("Jumlah Konsonan: "+jumlah_konsonan);
            Console.WriteLine("Jumlah Spasi: "+jumlah_space);
            Console.WriteLine("Jumlah Angka: "+jumlah_angka);
        }

        static int VocalCount(string input)
        {
            string vocalAlphabets = "aeiuo";
            int counting = 0;

            foreach (char chara in input.ToLower())
            {
                if (vocalAlphabets.Contains(chara))
                {
                    counting++;
                }
            }

            return counting;
        }
        static int ConsonantCount(string input)
        {
            string consonantAlphabets = "BCDFGHJKLMNPQRSTVWXYZ";
            string conslow = consonantAlphabets.ToLower();
            int i = 0;

            foreach (char chara in input.ToLower())
            {
                if (conslow.Contains(chara))
                {
                    i++;
                }
            }
            return i;
        }
        static int SpaceCount(string input)
        {
            string space = " ";
            int i = 0;

            foreach (char chara in input.ToLower())
            {
                if (space.Contains(chara))
                {
                    i++;
                }
            }
            return i;
        }
        static int NumberCount(string input)
        {
            int i = 0;
            foreach (char chara in input.ToLower())
            {
                if (Char.IsDigit(chara))
                {
                    i++;
                }
            }

            return i;
        }
    }
}