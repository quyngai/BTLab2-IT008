using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BTTH2_TranQuangDat_24520290
{
    public class Bai2
    {
        public static void DuongDan()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhap duong dan: ");
            string path = Console.ReadLine();

            if (!Directory.Exists(path))
            {
                Console.WriteLine("Duong dan khong ton tai");
                return;
            }

            DriveInfo drive = new DriveInfo(Path.GetPathRoot(path));

                Console.WriteLine($"\nVolume in drive {drive.Name.Replace("\\", "")} is {drive.VolumeLabel}");
                Console.WriteLine($"Volume Serial Number is {drive.DriveFormat}\n");

            Console.WriteLine($"Directory of {path}");
            long FileSize = 0;
            int FileCount = 0;
            string[] Dir = Directory.GetDirectories(path);
            
            foreach (string dir in Dir)
            {
                DirectoryInfo Info = new DirectoryInfo(dir);
                try
                {
                    Console.WriteLine($"{Info.LastWriteTime.ToString("dd/MM/yyyy HH:mm:ss"),20}        <DIR>        {Info.Name}");
                    string[] file = Directory.GetFiles(dir);
                    foreach (string f in file)
                    {
                        FileInfo fInfo = new FileInfo(f);
                        FileSize += fInfo.Length;
                        FileCount++;
                        Console.WriteLine($"{fInfo.LastWriteTime.ToString("dd/MM/yyyy HH:mm:ss"),20}        {fInfo.Length.ToString("N0"),10}    {fInfo.Name}");
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("                     Permission denied");
                }
        }                
            
            Console.WriteLine($"        {FileCount} Files   {FileSize.ToString("N0")}");
            Console.WriteLine($"        {Dir.Length} Dirs   {drive.TotalFreeSpace:N0} bytes free");
        }
    }
}
