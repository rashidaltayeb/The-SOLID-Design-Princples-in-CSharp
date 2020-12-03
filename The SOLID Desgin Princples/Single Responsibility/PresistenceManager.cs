
using System.IO;

namespace Single_Responsibility
{
    public class PresistenceManager
    {
        public void SaveToFile(Journal journal, string fileName, bool overWrite = false)
        {
            if (overWrite || !File.Exists(fileName))
            {
                File.WriteAllText(fileName,journal.ToString());
            }
        }
    }
}