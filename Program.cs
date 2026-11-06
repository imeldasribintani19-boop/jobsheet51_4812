const int biayaAdmin =  2000;

Console.Write("Masukkan namaPelanggan: ");
string namaPelanggan = Console.ReadLine();

Console.Write("Masukkan jumlahHalaman: ");
int jumlahHalaman = int.Parse(Console.ReadLine());

Console.Write("Masukkan hargaPerHalaman: ");
int hargaPerHalaman = int.Parse(Console.ReadLine());

int subtotal = jumlahHalaman * hargaPerHalaman;
int totalBayar = subtotal + biayaAdmin;

Console.WriteLine("=== RINCIAN PENCETAKAN ===");
Console.WriteLine($"Nama Pelanggan: {namaPelanggan}");
Console.WriteLine($"Jumlah Halaman: {jumlahHalaman}");
Console.WriteLine($"Harga Per Halaman: {hargaPerHalaman}");
Console.WriteLine($"Subtotal: {subtotal}");
Console.WriteLine($"Biaya Admin: {biayaAdmin}");
Console.WriteLine($"Total Bayar: {totalBayar}");