//              0  1  2  3  4 5  6  7  8
int[] array = {11,61,31,41,15,61,17,18,19};
int count = 0;
int max = array[0];
while(count < array.Length)
{
    if(array[count] > max) max = array[count];
    count ++;
}
 Console.WriteLine(max);