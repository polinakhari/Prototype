namespace Animals
{
    public class Dog : Mammal
    {
        /// <summary>
        /// порода собаки
        /// </summary>
        public string Breed { get; set; }

        public Dog() { }

        public Dog(Dog other) : base(other)
        {
            Breed = other.Breed;
        }

        public override Dog MyClone()
        {
            return new Dog(this);
        }

        public override object Clone()
        {
            return MyClone();
        }
    }

}
