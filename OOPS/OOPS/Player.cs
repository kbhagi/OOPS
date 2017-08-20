using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Player
    {
        public string Name { get; } = "Anonymous";
        public Player(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            Name = name;

        }
        public Player()
            : this("Anonymous")
        { }
        string name;
        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        if (value == null)
        //            throw new ArgumentNullException(nameof(value));
        //        if (string.IsNullOrWhiteSpace(value))
        //            throw new ArgumentException("Invalid name", nameof(value));
        //        name = value;

        //    }
        //}







    }

}