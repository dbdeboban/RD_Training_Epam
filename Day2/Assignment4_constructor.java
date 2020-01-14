class TestConstructor
{
  public TestConstructor() 
  {
    System.out.println("Public");
  }      
  protected TestConstructor(int x) 
  {
    System.out.println("protected");
  }
}
 
public class Testing extends TestConstructor 
{       
  private Testing(int x) 
  {
    super(x);
    System.out.println("private to protected");
  } 
  private Testing(String x)
  {
      super();
      System.out.println("private to public");
  }
  public static void main(String args[])
  {
     Testing t1 = new Testing(1000);
     Testing t2 = new Testing("ABC");
  }
}