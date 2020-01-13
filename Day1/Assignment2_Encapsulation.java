public class ImplementEncapsulation{
  public static void main(String[] args){
    Employee Emp = new Employee("MR. A D",26);
    System.out.println("Done");
  }
}


class Employee{
  private String employeeName;
  private int employeeAge;
  
  public Employee(String Name, int Age){
    this.employeeName = Name;
    this.employeeAge = Age;
    System.out.println("initialised");
  }
  
  public String getEmployeeName(){
    return employeeName;
  }
  public void setEmployeeName(String Name){
    this.employeeName = Name;
  }
  public int getEmployeeAge(){
    return employeeAge;
  }
  public void setEmployeeAge(int Age){
    this.employeeAge= Age;
  }
}
