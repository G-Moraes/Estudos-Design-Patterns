namespace Exercises._2___Structural.Section_9___Decorator
{
    /*
    The following code scenario shows a Dragon which is both a Bird and a Lizard. 

    Complete the Dragon's interface (there's no need to extract IBird or ILizard). Take special care when implementing the Age property!
    */

    public class Bird
    {
        public int Age { get; set; }

        public string Fly()
        {
            return (Age < 10) ? "flying" : "too old";
        }
    }

    public class Lizard
    {
        public int Age { get; set; }

        public string Crawl()
        {
            return (Age > 1) ? "crawling" : "too young";
        }
    }

    public class Dragon // no need for interfaces
    {
        private Bird bird       = new Bird();
        private Lizard lizard   = new Lizard();
        private int age;

        public int Age
        {
            get { return age; }
            set { age = bird.Age = lizard.Age = value; }
        }

        public Dragon()
        {
            
        }

        public string Fly()
        {
            return bird.Fly();
        }

        public string Crawl()
        {
            return lizard.Crawl();                
        }
    }
}
