namespace InterfacesExample.Sample2
{
    public interface ICommand
    {
         // We can model what happens when
        // a button is pressed for example
        // a power button. By breaking
        // everything down we can add
        // an infinite amount of flexibility
        void Execute();
        void Undo();
    }
}