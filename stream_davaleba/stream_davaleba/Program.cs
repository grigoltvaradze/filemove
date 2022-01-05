namespace pathHomework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var from = @"C:\Users\ASUS\Desktop\from";
            var to = @"C:\Users\ASUS\Desktop\to";
            DateTime lastChangeTime = new DateTime(2022, 01, 04);
            if (Directory.GetFiles(from).Length > 0)
            {
                var files = Directory.GetFiles(from);
                foreach (var file in files)
                {
                    if(Directory.GetLastAccessTime(file) > lastChangeTime)
                    {
                        var fileName = Path.GetFileName(file);
                        var destination = Path.Combine(to, fileName);
                        File.Move(file, destination);
                    }
                    else
                    {
                        Console.WriteLine("you don't need this files");
                    }
                }
            }
            else
            {
                Console.WriteLine("Folder is empty");
            }
        }
    }
}
