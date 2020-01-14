public class Main 
{ 
	public static void main(String[] args) 
	{ 
		Restraunt R = new Restraunt();
		System.out.println("Restraunt opened");
        R.restrauntOpen();
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
        System.out.println("Taking Order");
    }
}
class Cook extends Person{
    public void cookingFood(){
        System.out.println("Cooking ordered food");
    }
}
class Cashier extends Person{
    public void billingCustomer(){
        System.out.println("Billing customer");
    }
}
class Restraunt{
    private Waiter w = new Waiter();
    private Cook c = new Cook();
    private Cashier cs = new Cashier();
    
    public void restrauntOpen(){
        w.takingOrder();
        c.cookingFood();
        w.servingFood();
        cs.billingCustomer();
    }
}
