# Importing functions to check input, convert to binary
# and perofrm addition
import input_validation
import binary_conversion_1
import binary_conversion_final
import binary_adder


continue_looping=True
while continue_looping==True:
    
    # Taking input from user
    # calling input_check to check the validity of user input
    
    number1=input_validation.input_check("Enter first number: ")
    number2=input_validation.input_check("Enter second number: ")
    
    #case for 9-bit operation
    if((number1+number2)>255):
        print()
        print("-------You are attempting a 9-bit operation-------")
        print("---Keep in mind only 8-bit results will be displayed---")
        print()
    # part one of binary conversion
    # further explained in module binary_conversion_part
    binary1=binary_conversion_1.binary_conversion(number1)
    binary2=binary_conversion_1.binary_conversion(number2)
    
    # in this process, the digits obtained in previous step are reversed
    # further explained in module binary_conversion_final
    binary1_final=binary_conversion_final.final_binary(binary1)
    binary2_final=binary_conversion_final.final_binary(binary2)
    
    # binary addition is performed
    # further explained in module binary_adder
    sum=binary_adder.binary_adder(binary1_final,binary2_final)
   
    
    print("The result of binary addition is:",sum)
    print()
    
    # taking conformation from user to quit program
    quit=input("Press q to quit the program, anything else will continue the program: ")
    if quit=="q" or quit=="Q":
        print()
        print("Thank you for using the program")
        break
    
    
    
    
