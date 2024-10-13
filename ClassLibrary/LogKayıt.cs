using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ClassLibrary
{
    internal class LogKayıt
    {
        public static void LogKayit(String HataMesaji)
        {
            string dosya_yolu = @"C:\Users\cengi\Desktop\Emlak_App\emlak\LogKayıt.txt";
            if (!File.Exists(dosya_yolu))
            {
                File.Create(dosya_yolu);
                Console.WriteLine("Log Dosyası Oluşturuldu");
            }
            else {
                FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(HataMesaji);
                sw.Close();
                fs.Close();
            }
        }
    }
}
