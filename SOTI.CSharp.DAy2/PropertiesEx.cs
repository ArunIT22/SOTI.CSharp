using System;

namespace SOTI.CSharp.DAy2
{
    public class Category
    {
        private int _categoryId;
        //private string _categoryName;
        private string _data;
        public int CategoryId
        {
            get
            {
                return _categoryId;
            }
            set
            {
                if (value >= 0)
                {
                    _categoryId = value;
                }
            }
        }

        //readonly Property
        public string Data
        {
            get { return _data; }
            private set { }
        }

        //public string CategoryName
        //{
        //    get { return _categoryName; }
        //    set { _categoryName = value; }
        //}

        //Auto-Implemented Property
        public string CategoryName { get; set; }
        public DateTime AddedDate { get; set; }

        //read-only property
        public string Genre { get; } = "Horror";

        public Category()
        {

            Data = "My Data";
            Genre = "Romance";
        }

        public void Display()
        {
            Console.WriteLine($"Category Id :{CategoryId}\tCategory Name :{CategoryName}\tAdded Date :{AddedDate}");
        }

        static void Main1(string[] args)
        {
            Category c1 = new Category();
            c1.CategoryId = -100;
            c1.CategoryName = "Books";
            c1.AddedDate = DateTime.Now;
            //setting read-only property
            //c1.Data = "My Data";
            //c1.Genre = "Horror";
            Console.WriteLine($"Genre :{c1.Genre}");
            c1.Display();
        }
    }
}
