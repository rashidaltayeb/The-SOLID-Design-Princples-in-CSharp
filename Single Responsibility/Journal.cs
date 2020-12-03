using System.Collections.Generic;

namespace Single_Responsibility
{
    public class Journal
    {
        private readonly List<string> _entries = new List<string>();
        // just a counter for total numbers of entries
        private static int _counter ;
        
        public void AddEntry(string text)
        {
            _entries.Add($"{++_counter}:{text}");
        }
        public void RemoveEntry(int index)
        {
            _entries.RemoveAt(index);
        }
    }
}