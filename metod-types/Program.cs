//type 0 - 0
void Method1(){
    Console.WriteLine("hello world");
}

Method1();

//type 1 - 0
void Method2(string textA){
    Console.WriteLine(textA);
}

string a = "hello world";
Method2(a);

//type 0 - 1
string Method3(){
    string b = "hello world";
    return b;
}

Console.WriteLine(Method3());

//type 1 - 1;
string Method4(string textC1){
   string textC2 = textC1;
   return textC2;
}


Console.WriteLine(Method4("hello world"));