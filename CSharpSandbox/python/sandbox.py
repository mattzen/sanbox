def addTwoNumbers(someNumber : int) -> None:
    print(f'Adding two numbers : {someNumber}')

def SumOfDigits(num : int) -> int:
    num = str(num)
    if len(num) == 1:
        return int(num)
    return int(num[0]) + SumOfDigits(int(num[1:]))
    
def SumofDigitsIterative(num : int) -> int:
    holder = 0
    strNum = str(num)
    for element in strNum:
        holder += int(element)
    return holder
         
    
if __name__ == "__main__":
    print(SumOfDigits(123456767))
    print(SumofDigitsIterative(123456767))