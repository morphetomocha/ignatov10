using System;
using System.Collections.Generic;
using System.Text;

namespace ignatov10.Modeli
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Author(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Author(string name)
        {
            Id = -1;
            Name = name;
        }

        public void SetId(int id)
        {
            this.Id = id;
        }

        public string WriteMusic(string musicName)
        {
            return $"Автор {Name} написал новый трэк: {musicName}";
        }

        public override string ToString()
        {
            return $"Author[{Id}] Name: {Name}";
        }
    }
}
