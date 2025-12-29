namespace MyNameIs
{
    internal class Dog : IAnimal
    {
        public int Color { get; set; } = 0;
        public virtual void Speak()
        {
            Console.Write("Vuf");
        }
    }
}
