def addTwoNumbers(someNumber : int) -> None:
    print(f'Adding two numbers : {someNumber}')

def SumOfDigits(num : int) -> int:
    num = str(num)
    if len(num) == 1:
        return int(num)
    else:
        return int(num[0]) + SumOfDigits(int(num[1:]))
    
 
    
if __name__ == "__main__":
    print(SumOfDigits(123456767))