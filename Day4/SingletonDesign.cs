using System;
public class Program {
   public static void Main(String[] args) {
      ReadOnlyBox Box = ReadOnlyBox.getInstance();
      Box.ViewBox();
   }
}
class ReadOnlyBox {
   private static ReadOnlyBox Box = new ReadOnlyBox();
   private static String BoxContent = "Hello";
   private ReadOnlyBox(){}
   public static ReadOnlyBox getInstance(){
      return Box;
   }
   public void ViewBox(){
      Console.WriteLine("Box Opened");
      Console.WriteLine(BoxContent);
   }
}
