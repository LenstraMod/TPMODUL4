using TP_MODUL4_103022400008;

Console.WriteLine("Cari kode pos mu");

Console.Write("Masukkan kelurahan: ");

String kelurahan = Console.ReadLine().ToUpper();

KodePos.Kelurahan chosePlace = (KodePos.Kelurahan)Enum.Parse(typeof(KodePos.Kelurahan), kelurahan);

int res = KodePos.getKodePos(chosePlace);

Console.WriteLine("Kelurahan " + kelurahan + " memiliki kode " + res.ToString());
