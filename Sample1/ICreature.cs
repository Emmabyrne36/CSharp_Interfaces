namespace InterfacesExample.Sample1
{
    public interface ICreature
    {
        int StartDistance { get; set; }
        void Walk();
        void Shout();
    }
}