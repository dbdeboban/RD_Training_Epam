public class Main 
{ 
	public static void main(String[] args) 
	{ 
		PayingGuest Empp = new PayingGuest(10000,"Lakshmi pg",2000); 
		
		Hotel Emph = new Hotel(3000,"Novotel 5-star",200,10); 
		
		
		System.out.println(Empp.calculateTotal()); 
		System.out.println(Emph.calculateTotal()); 
	} 
} 

class Accommodation{
    private int Rent;
    private String Name;
    private int foodCost;
    
    public Accommodation(int Rent, String Name,int foodCost){
        this.Rent = Rent;
        this.Name = Name;
        this.foodCost = foodCost;
    }
    public int getRent(){
        return Rent;
    }
    public int getfoodCost(){
        return foodCost;
    }
}
class PayingGuest extends Accommodation{
    public PayingGuest(int Rent, String Name, int foodCost){
        super(Rent,Name,foodCost);
    }
    public int calculateTotal(){
        return super.getRent()+super.getfoodCost();
    }
}
class Hotel extends Accommodation{
    private int totalDays;
    public Hotel(int Rent, String Name, int foodCost, int totalDays ){
        super(Rent,Name,foodCost);
        this.totalDays = totalDays;
    }
    public int calculateTotal(){
        return(super.getRent()+super.getfoodCost())*totalDays;
    }
}
