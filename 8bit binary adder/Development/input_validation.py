#Creating a function, this function will check the user input
def input_check(message):
    while True:
        try:
            value=int(input(message))
        except ValueError:
            # checking exception so only integer is allowed
            print("Oops! invalid input found, please try again.")
            print()
            continue
        if(value<0):
            # checking validity of the integer
            print("Please enter an integer >= 0")
            print()
        elif(value>255):
            # checking validity of the integer
            print("Please enter an integer <= 255")
            print()
        else:
            break
    return value

                    
            
            
        
        
