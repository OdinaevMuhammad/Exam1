public class Minimum
{
    public int a;
    public int b;
    public int c;
    public int d;


    public int FindMinimum(int a, int b, int c, int d)
    {
        if(a < b && a < c && a < d)
        {
            return a;
        }
         if(b < a && b < c && b < d)
        {
            return b;
        }
         if(c < a && c < b && c < d)
        {
            return c;
        }
         if(d < a && d < b && d < c)
        {
            return d;
        }
        
    }
}