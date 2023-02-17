int [] CreateArray (int size){
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i<array.Length; i++ ){
        array[i] = rnd.Next ();
    }
    return array;
}
void PrintArray (int[] array)  {
    Console.Write("[");
    for (int i = 0; i<array.Length; i++ ){
    if (i < array.Length - 1) Console.Write ($"{array[i]}, ");
    else Console.Write ($"{array[i]}");
    }
    Console.Write("]->");
}
int ArrayNumberedSum (int[] array){
    int sum = 0;
    for (int i = 0; i<array.Length; i++){
        if (i %2 != 0) sum +=array[i];
    }
    return sum;
}
int[] arr = CreateArray (4);
PrintArray (arr);
int Summ = ArrayNumberedSum (arr);
Console.WriteLine ($"{Summ}");
