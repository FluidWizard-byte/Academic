# function to convert to binary
# this is first step that just gives 0 and 1
def binary_conversion(conversion_number):
    bit=[]
    while conversion_number!=0:
        # if the input is not zeoo
        # perform n%2 which gives 0 or 1 as remainder
        # add the 0 or 1 to the list
        # perform n//2 which gives the nearest whole number of quotient
        # i.e if 19//2 then it gives 9
        remainder=conversion_number%2
        bit.append(remainder)
        conversion_number=conversion_number//2
    return bit


    
