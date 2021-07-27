# CodilityBinaryGap

## Codility Binary Gap
### For example, number 9 has binary representation 1001 and contains a binary gap of length 2. The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3. The number 20 has binary representation 10100 and contains one binary gap of length 1. The number 15 has binary representation 1111 and has no binary gaps. The number 32 has binary representation 100000 and has no binary gaps.

```csharp
public static int Do(int N)
{
    var bit = Convert.ToString
    var count = 0;
    var biggest = 0;
    var tempCount
    for (int i = 0; i < bit.Length; i++)
    {
        if (bit[i] == '0')
        {
            count++;
  
        if (count > biggest) biggest =
        if (bit[i] == '1')
        {
            if (biggest > tempCounter)
                tempCounter = biggest;
            count = 0;
  

    return tempCounter;
}
