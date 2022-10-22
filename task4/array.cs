public class Dif
{
    public int a;
     public int n;
    public int b;
    public int c;
    public int d;


    public void different()
    {
        var cnt = 0;
        if(a != b && a != c && a != d )
        {
            cnt++;
        }
          if(b != a && b != c && b != d )
        {
            cnt++;
        }
          if(c != b && c != a && c != d )
        {
            cnt++;
        }
          if(d != b && d != c && d != a )
        {
            cnt++;
        }
     
    }
}