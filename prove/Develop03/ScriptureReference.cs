using System;
using System.Collections.Generic;

namespace classes
{
    class ScriptureReference
    {
        public string Book { get; private set; }
        public int Chapter { get; private set; }
        public int VerseStart { get; private set; }
        public int VerseEnd { get; private set; }

        public ScriptureReference(string reference)
        {
            string[] parts = reference.Split(' ');
            Book = parts[0];
            Chapter = int.Parse(parts[1]);
            if (parts.Length == 3)
            {
                VerseStart = int.Parse(parts[2]);
                VerseEnd = VerseStart;
            }
            else
            {
                string[] verseParts = parts[2].Split('-');
                VerseStart = int.Parse(verseParts[0]);
                VerseEnd = int.Parse(verseParts[1]);
            }
        }
    }
}
