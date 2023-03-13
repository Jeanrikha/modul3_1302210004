using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302210004
{
    internal class KodeBuah
    {
        private Dictionary<string, string> kodebuah = new Dictionary<string, string>()
        {
            {"Apel","A00"},
            {"Aprikot","B00"},
            {"Alpukat","C00"},
            {"Pisang","D00"},
            {"Paprika","E00"},
            {"Blackberry","F00"},
            {"Ceri","H00"},
            {"Kelapa","I00"},
            {"Jagung","J00"},
            {"Kurma","K00"},
            {"Durian","L00"},
            {"Anggur","M00"},
            {"Melon","N00"},
            {"Semangka" ,"O00"},
        };

        public string getKodeBuah(string namaBuah)
        {
            if (kodebuah.ContainsKey(namaBuah))
            {
                return kodebuah[namaBuah];
            }
            else
            {
                return "Kode Buah Tidak ditemukan!";
            }
        }
    }
}
