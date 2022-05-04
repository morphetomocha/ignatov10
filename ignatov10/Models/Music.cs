using System;

namespace ignatov10.Models
{
    public class Music
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Text { get; set; }

        public Music(int id, string name, DateTime date)
        {
            Id = id;
            Name = name;
            ReleaseDate = date;
        }

        public Music(int id, string name)
        {
            Id = id;
            Name =name;
            ReleaseDate = DateTime.Now;
        }

        public string GetText()
        {
            return $"Композиция: {Name}({ReleaseDate})\n" + Text;
        }

        public void UpdateText(string newText)
        {
            Text = newText;
        }
    }
}
