/**
 * @author Bijay Bharati
 * @version 0.01
 */
public class StaffHire {
    private int vacancyNumber;
    private String designation;
    private String jobType;

    // Creating constructor. Constructor is also a type of method.
    
    public StaffHire(int vacancyNumber, String designation, String jobType) {
        this.vacancyNumber = vacancyNumber;
        this.designation = designation;
        this.jobType = jobType;
    }
    
    // Accessor and Mutator (get and set) methods for different values.

    public int getVacancyNumber() {
        return this.vacancyNumber;
    }

    public void setVacancyNumber(int vacancyNumber) {
        this.vacancyNumber = vacancyNumber;
    }

    public String getDesignation() {
        return this.designation;
    }

    public void setDesignation(String designation) {
        this.designation = designation;
    }

    public String getJobType() {
        return this.jobType;
    }

    public void setJobType(String jobType) {
        this.jobType = jobType;
    }

    // Method to display information collected from user.
    
    public void displayInfo() {
        System.out.println("\n"+"The vacancy number for the job is: " + getVacancyNumber());
        System.out.println("The designation for the job is: " + getDesignation());
        System.out.println("The job type is: " + getJobType());
    }
}
