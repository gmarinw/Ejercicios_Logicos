int limit = 15;
int n1  = 0;
int n2 = 1;
Console.WriteLine(n1);//imprimo n1
Console.WriteLine(n2);//imprimo n2

int res = n1 + n2; //1

while (res < limit)
{
    Console.WriteLine(res);//imprimo la suma
    n1 = n2;
    n2 = res;
    res = n1 + n2; //
}