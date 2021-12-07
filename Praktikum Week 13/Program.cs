using System;

public class Program
{
    public static void Main()
    {
        int dataOrang = 99999;
        int statusProgram = 0;
        string[,] DaftarData = new string[dataOrang, 7];
        dataOrang = 0;
        while (statusProgram == 0)
        {
            Console.Write("Berapa Data = ");
            int inputData = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            dataOrang = dataOrang + inputData;
            for (int inputTerus = dataOrang - inputData + 1; inputTerus <= dataOrang; inputTerus++)
            {
                Console.WriteLine("Data ke-" + inputTerus);

                Console.Write("NIM \t\t: ");
                DaftarData[inputTerus - 1, 0] = Console.ReadLine();
                for (int cekNIM = 0; cekNIM <= inputTerus; cekNIM++)
                {
                    if (inputTerus - 1 != cekNIM)
                    {
                        while (DaftarData[inputTerus - 1, 0] == DaftarData[cekNIM, 0])
                        {
                            Console.WriteLine("NIM SUDAH ADA, MASUKKAN NIM LAIN !!!");
                            Console.Write("NIM \t\t: ");
                            DaftarData[inputTerus - 1, 0] = Console.ReadLine();
                        }
                    }
                }

                Console.Write("NAMA \t\t: ");
                DaftarData[inputTerus - 1, 1] = Console.ReadLine();

                Console.Write("JENIS KELAMIN \t: ");
                DaftarData[inputTerus - 1, 2] = Console.ReadLine();

                Console.Write("TAHUN MASUK \t: ");
                DaftarData[inputTerus - 1, 3] = Console.ReadLine();

                Console.Write("PROGRAM STUDI \t: ");
                DaftarData[inputTerus - 1, 4] = Console.ReadLine();

                Console.Write("KELAS \t\t: ");
                DaftarData[inputTerus - 1, 5] = Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine("PRINT HASIL? (y/n) . . . ");
            string input = Console.ReadLine();
            while (input != "y" && input != "n")
            {
                Console.WriteLine("PRINT HASIL? (y/n) . . . ");
                string print = Console.ReadLine();
                input = print;
            }

            if (input == "y")
            {
                Console.Clear();
                Console.WriteLine(String.Format("{0,-5} {1, -10} {2,-25} {3, -15} {4,-15} {5, -15} {6, -15}", "NO", "NIM", "NAMA", "JENIS KELAMIN", "TAHUN MASUK", "PROGRAM STUDI", "KELAS"));
                for (int TambahInput = 0; TambahInput < dataOrang; TambahInput++)
                {
                    Console.WriteLine(String.Format("{0,-5} {1, -10} {2,-25} {3, -15} {4,-15} {5, -15} {6, -15}", (TambahInput + 1), DaftarData[TambahInput, 0], DaftarData[TambahInput, 1].ToUpper(), DaftarData[TambahInput, 2].ToUpper(), DaftarData[TambahInput, 3], DaftarData[TambahInput, 4].ToUpper(), DaftarData[TambahInput, 5].ToUpper()));
                }
                Console.WriteLine();
            }
            else
            {
                statusProgram = 1;
            }

            Console.Write("Tambah Data? (y/n) ...");
            string inputBaru = Console.ReadLine();
            while (inputBaru != "y" && inputBaru != "n")
            {
                Console.WriteLine("Tambah Data? (y/n) . . . ");
                string inputUlang = Console.ReadLine();
                inputBaru = inputUlang;
            }

            if (inputBaru == "y")
            {
                statusProgram = 0;
                Console.Clear();
            }
            else
            {
                statusProgram = 1;
            }
        }
    }
}
