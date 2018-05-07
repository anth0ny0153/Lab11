using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Movie
    {
        #region data members
        private string categories;
        private string title;
        #endregion
        #region properties
        public string Categories
        {
            get
            {
                return categories;
            }
            set
            {
                categories = value;
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
#endregion
        public Movie()
        {
            Categories = "a";
            Title = "b";
        }
        public Movie(string cat, string name)
        {
            Categories = cat;
            Title = name;
        }
        public void PrintInfo()
        {
            Console.WriteLine(Title);
        }
    }
}
