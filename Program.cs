using System;

class Program
{
    static void Main(string[] args)
    {
        
        KodeBuah kb = new KodeBuah();
        Console.WriteLine("Kode Buah Apel: " + kb.getKodeBuah("Apel"));

       
        PosisiKarakterGame karakter = new PosisiKarakterGame();

        karakter.tekanTombol("S");
        karakter.tekanTombol("S");
        karakter.tekanTombol("W");
        karakter.tekanTombol("W");
        karakter.tekanTombol("W");
        karakter.tekanTombol("S");
    }
}