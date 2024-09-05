namespace Animals
{
    /// <summary>
    /// млекопитающее
    /// </summary>
    public class Mammal : Animal 
    {
        public int Legs { get; set; }

        public Mammal() { }

        public Mammal(Mammal other) : base(other)
        {
            Legs = other.Legs;
        }

        public override Mammal MyClone()
        {
            return new Mammal(this);
        }

        public override object Clone()
        {
            return MyClone();
        }
    }

}
