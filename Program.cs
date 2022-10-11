void ShowArr(string[] arr)
{

    Console.Write("[");
    for(int i=0; i<arr.Length;i++)
        if(i==arr.Length-1)
            Console.Write($"{arr[i]} ]");
        else
            Console.Write($"{arr[i]}, ");
    Console.WriteLine();
}

int CountStrings(string[] arr, int maxLen)
{
    int cnt=0;
    for( int i = 0; i < arr.Length; i++)
        if(arr[i].Length<=3)
            cnt++;
    return cnt;
}


int maxLen = 3;
string [] inArr= new string[] {"hello","2","world",":-)"};

int cnt = CountStrings(inArr, maxLen);

string [] resArr= new string[cnt];
int j = 0;

for( int i = 0; i < inArr.Length; i++)
{
    if(inArr[i].Length<=3)
    {
        resArr[j] = inArr[i];
        j++;
    }
}

ShowArr(resArr);