using System;
using System.Collections.Generic;
using static modul3_1302210004.KodeBuah;
using static modul3_1302210004.PosisiKarakterGame;



class program
{
    static void Main(string[] args)
    {
        modul3_1302210004.KodeBuah kodebuah = new modul3_1302210004.KodeBuah();
        Console.WriteLine("Kode Buah Alpukat adalah: " + kodebuah.getKodeBuah("Alpukat"));

        modul3_1302210004.PosisiKarakterGame posisi = new modul3_1302210004.PosisiKarakterGame();
        posisi.TombolS();
        posisi.TombolW();
        posisi.TombolS();
        posisi.TombolS();
    }
}