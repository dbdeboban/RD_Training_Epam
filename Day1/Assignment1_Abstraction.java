public class Main 
{ 
	public static void main(String[] args) 
	{ 
		Employee EmpC = new ParttimeEmployee("abc", 10,200); 
		
		Employee EmpF = new FulltimeEmployee("bcd", 20, 400); 
		
		
		System.out.println(EmpC.displayInfo()); 
		System.out.println(EmpF.displayInfo()); 
	} 
} 

abstract class Employee 
{ 
	String name; 
	int salaryPerHour;
	
	abstract double CalculateSalary(); 
	public abstract String displayInfo(); 
	
	public Employee(String name, int salaryPerHour) { 
		System.out.println("Employee Instance created"); 
		this.name = name;
		this.salaryPerHour = salaryPerHour;
	} 
	public String getName() { 
		return name; 
	}
	public int getSalaryPerHour(){
	    System.out.println(salaryPerHour);
	    return salaryPerHour;
	}
} 

class ParttimeEmployee extends Employee 
{ 
	int hoursWorked; 
	
	public ParttimeEmployee(String name,int salaryPerHour,int hoursWorked ) { 
		super(name,salaryPerHour); 
		System.out.println("Part Time Employee Created"); 
		this.hoursWorked = hoursWorked; 
	} 
	double CalculateSalary() { 
		return hoursWorked*getSalaryPerHour();
	} 
	public String displayInfo() { 
		return "Part Time Employee name is " + super.name + 
					" and salary is : " + CalculateSalary(); 
	} 
	
} 
class FulltimeEmployee extends Employee{ 

	int hoursWorked = 8;
	int extraHours;
	
	public FulltimeEmployee(String name,int extraHours, int salaryPerHour) { 
		super(name,salaryPerHour); 
		System.out.println("Fulltime Emloyee Created"); 
		this.extraHours = extraHours; 
	} 

	double CalculateSalary() { 
		return (hoursWorked+extraHours)*getSalaryPerHour();
	}
	public String displayInfo() { 
		return "Full time Employee name is " + super.name + 
						" and salary is : " + CalculateSalary(); 
	} 

} 

