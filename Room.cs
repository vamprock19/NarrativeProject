namespace NarrativeProject
{
    internal abstract class Room
    {
        // abstract is intended only to be a base class of other classes)
        // it applies to a class and methods
        internal abstract string CreateDescription();
        internal abstract void ReceiveChoice(string choice);
    }
}
