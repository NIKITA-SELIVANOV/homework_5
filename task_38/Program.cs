float [] CreateArray (int size){
    float [] array = new float[size];
    Random rnd = new Random();
    for (int i = 0; i<array.Length; i++ ){
        array[i] = rnd.Next ();
    }
    return array;
}
void PrintArray (float [] array)  {
    Console.Write("[");
    for (int i = 0; i<array.Length; i++ ){
    if (i < array.Length - 1) Console.Write ($"{array[i]}, ");
    else Console.Write ($"{array[i]}");
    }
    Console.Write("]->");
}
float Arraymin (float [] array){
    var min = array[0];
    for (int i = 0; i<array.Length-1; i++){
        float min = array[i];
        if (array[i]<min ) array[i] = min;
    }
    return min;
}
float Arraymax (float [] array){
    var max = array[0];
    for (int i = 0; i<array.Length-1; i++){
        float max = array[i];
        if (array[i]>max) array[i] = max;
    }
    return max;
}
float [] arr = CreateArray (5);
PrintArray (arr);
float Summ = Arraymax (arr)-Arraymin (arr);
Console.WriteLine ($"{Summ}");
