namespace Visitor
{
    public interface Visitor
    {
        void VisitAnimal(Animal a);
        void VisitBird(Bird b);
    }
}