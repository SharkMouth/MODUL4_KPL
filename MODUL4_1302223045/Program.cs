// See https://aka.ms/new-console-template for more information
public class kodeBuah
{
    public enum Buah {Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka }

    public static string getKode(Buah buah)
    {
        string[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "G00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };

        return kodeBuah[(int)buah];
    }

    public class posisiKarakterGame
    {
        public enum gameState { Berdiri, Jongkok, Terbang, Tengkurap }

        static void Main(string[] args)
        {
            posisiKarakterGame.gameState kondisi = posisiKarakterGame.gameState.Berdiri;
            Console.WriteLine("Masukkan Aksi : ");
            string input = Console.ReadLine();
            while (input != "udahan")
            {
                switch (kondisi)
                {
                    case gameState.Berdiri:
                        if (input == "S")
                        {
                            Console.WriteLine("Tombol arah bawah ditekan");
                            kondisi = gameState.Jongkok;
                        }
                        else if (input == "W")
                        {
                            Console.WriteLine("Tombol arah atas ditekan");
                            kondisi = gameState.Terbang;
                        }
                        break;
                    case gameState.Jongkok:
                        if (input == "S")
                        {
                            Console.WriteLine("Tombol arah bawah ditekan");
                            kondisi = gameState.Tengkurap;
                        }
                        else if (input == "W")
                        {
                            Console.WriteLine("Tombol arah atas ditekan");
                            kondisi = gameState.Berdiri;
                        }
                        break;
                    case gameState.Terbang:
                        if (input == "S")
                        {
                            Console.WriteLine("Tombol arah bawah ditekan");
                            kondisi = gameState.Berdiri;
                        }
                        else if (input == "X")
                        {
                            kondisi = gameState.Jongkok;
                        }
                        break;
                    case gameState.Tengkurap:
                        if (input == "W")
                        {
                            Console.WriteLine("Tombol arah atas ditekan");
                            kondisi = gameState.Jongkok;
                        }
                        break;
                }
                Console.WriteLine("Masukkan Aksi : ");
                input = Console.ReadLine();
            }

            Buah buah = new Buah();
            Console.WriteLine("Nama Buah : " + Buah.Apel);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Apel));
            Console.WriteLine(" ");
            Console.WriteLine("Nama Buah : " + Buah.Aprikot);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Aprikot));
            Console.WriteLine(" ");
            Console.WriteLine("Nama Buah : " + Buah.Alpukat);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Alpukat));
            Console.WriteLine(" ");
            Console.WriteLine("Nama Buah : " + Buah.Pisang);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Pisang));
            Console.WriteLine(" ");
            Console.WriteLine("Nama Buah : " + Buah.Paprika);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Paprika));
            Console.WriteLine(" ");
            Console.WriteLine("Nama Buah : " + Buah.Blackberry);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Blackberry));
            Console.WriteLine(" ");
            Console.WriteLine("Nama Buah : " + Buah.Ceri);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Ceri));
            Console.WriteLine(" ");
            Console.WriteLine("Nama Buah : " + Buah.Kelapa);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Kelapa));
            Console.WriteLine(" ");
            Console.WriteLine("Nama Buah : " + Buah.Jagung);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Jagung));
            Console.WriteLine(" ");
            Console.WriteLine("Nama Buah : " + Buah.Kurma);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Kurma));
            Console.WriteLine(" ");
            Console.WriteLine("Nama Buah : " + Buah.Durian);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Durian));
            Console.WriteLine(" ");
            Console.WriteLine("Nama Buah : " + Buah.Anggur);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Anggur));
            Console.WriteLine(" ");
            Console.WriteLine("Nama Buah : " + Buah.Melon);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Melon));
            Console.WriteLine(" ");
            Console.WriteLine("Nama Buah : " + Buah.Semangka);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Semangka));
        }
    }
}