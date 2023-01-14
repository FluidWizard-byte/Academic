def half_adder(a, b):
    # half adder has 2 inputs
    # in half adder sum=(A XOR B)
    # ^ is logical xor in python
    # carry out=(A AND B)
    sum = a ^ b
    carry = a and b
    return carry,sum

def full_adder(carry_in, a, b):
    # full hader can add 3 bits (carry in)
    # sum=(A XOR (B XOR C))
    # carry out= C(A XOR B) +A AND B
    carry1,sum1=half_adder(carry_in,a)
    carry2,sum = half_adder(sum1,b)
    carry= carry1 or carry2
    return carry,sum

def binary_adder(a,b):
   
    
    # converting string  into list of integers
    a_list=list(int(x,2)for x in list(a))
    b_list=list(int(x,2)for x in list(b))
   
    #print (a_list)
    #print (b_list)
    
    result=[]
    carry=0
    final_sum=""
    # full adder is called as we go through the list of 0s and 1s
    for i in range(len(a_list)-1,-1,-1):
        carry,sum = full_adder(carry,a_list[i],b_list[i])
        result.insert(0,sum)
        #print (result)
    # making sure only 8-bit result is obtained
    if len(result)<8:
        result.insert(0,carry)
       
    
    final_sum= ''.join(str(x) for x in result)
    return final_sum

   
   
