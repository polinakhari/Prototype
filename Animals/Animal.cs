using Animals.Interfaces;

namespace Animals
{
    public class Animal : IMyCloneable<Animal>, ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal() { }

        public Animal(Animal other)
        {
            Name = other.Name;
            Age = other.Age;
        }

        public virtual Animal MyClone()
        {
            return new Animal(this);
        }

        public virtual object Clone()
        {
            return MyClone();
        }
    }
}
