class Test
{
  public Test() 
  {
    System.out.println("Public");
  }      
  protected Test(int x) 
  {
    System.out.println("protected");
  }
}
 
public class Demo extends Test 
{       
  private Demo(int x) 
  {
    super(x);
    System.out.println("private");
  } 
  private Demo(String x)
  {
      super();
      System.out.println("private to public");
  }
  public static void main(String args[])
  {
     Demo d1 = new Demo(1000);
     Demo d2 = new Demo("ABC");
  }
}