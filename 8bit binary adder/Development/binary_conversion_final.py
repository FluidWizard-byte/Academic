# function that gives the actual binary value
# this is second part of binary conversion
def final_binary(binary_value):
    final=""
    count=len(binary_value)
    while count!=8:
        # making sure that each input will be of the same size at the end
        binary_value.append(0)
        count=count+1
    for i in range(count-1,-1,-1):
        # range(start_value, end_value, step)
        # we start at count-1 i.e from RHS 
        # end value is actually 0 therefore -1 end value
        # we need to move back the list so -1 step
        final=final+str(binary_value[i])
    return final

  
