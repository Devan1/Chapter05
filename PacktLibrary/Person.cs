using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shared
{
    public class Person: Object
    {
        //fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();
    }
}
