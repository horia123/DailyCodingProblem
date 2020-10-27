
namespace Days.Day5
{
    public class Pair<T>
    {
        public T First { get; set; }
        public T Last { get; set; }

        public Pair(T first, T last)
        {
            First = first;
            Last = last;
        }

        public static T Car(Pair<T> p)
        {
            return p.First;
        }

        public static T Cdr(Pair<T> p)
        {
            return p.Last;
        }
    }
}
