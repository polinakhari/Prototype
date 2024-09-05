namespace Animals
{
    public class Cat : Mammal
    {
        /// <summary>
        /// раскрас шерсти
        /// </summary>
        public string FurColor { get; set; }

        public Cat() { }

        public Cat(Cat other) : base(other)
        {
            FurColor = other.FurColor;
        }

        public override Cat MyClone()
        {
            return new Cat(this);
        }

        public override object Clone()
        {
            return MyClone();
        }
    }

}
