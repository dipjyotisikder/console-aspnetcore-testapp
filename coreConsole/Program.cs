using System;

namespace coreConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            IBingRepo repo = new BingRepo();

            string a = repo.GiveEmail(3);

            Console.WriteLine(a);
            Console.ReadLine();
        }
    }


    public class MajorBing
    {
        public MajorBing(string email, string name)
        {

        }
        public int Indentity { get; set; }
        public string Name { get; set; }
    }


    public class Bing : MajorBing
    {
        public Bing(string email, int id, string name) : base(email, name)
        {
            this.Email = email;
            base.Name = name;
            base.Indentity = id;

        }
        public string Email { get; set; }

    }





    public interface IBingRepo
    {
        void make();
        string GiveEmail(int id);
    }

    public class BingRepo : IBingRepo
    {
        public string GiveEmail(int id)
        {
            string mail = "dipjyoti@gmaul.com";
            int ID = id;
            string name = "dipjyoti";


            Bing bing = new Bing(mail, ID, name);
            string email = bing.Email;

            return email;
        }

        public void make()
        {
            throw new NotImplementedException();
        }
    }

}
