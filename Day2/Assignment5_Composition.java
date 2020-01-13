public class Main 
{ 
	public static void main(String[] args) 
	{ 
		Restraunt R = new Restraunt();
		System.out.println("Works");
	} 
} 
class Person{
    private String name;
    private int age;

}
class Waiter extends Person{
    public void servingFood(){
        System.out.println("Serving food");
    }
    public void takingOrder(){
        System.out.println("Serving food");
    }
}
class Cook extends Person{
    public void cookingFood(){
        System.out.println("Serving food");
    }
}
class Cashier extends Person{
    public void billingCustomer(){
        System.out.println("Serving food");
    }
}
class Restraunt{
    private Waiter w[] = new Waiter[10];
    private Cook c[] = new Cook[3];
    private Cashier cs = new Cashier();
    
}
