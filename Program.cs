// Task 1

// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// int maxx = int.MinValue;

// for(int i=0; i<n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// for(int i = 0; i<n; i++)
// {
//     if(maxx < arr[i])
//     {
//         maxx= arr[i];
//     }
// }
// System.Console.WriteLine("Max: "+maxx);



// Task 2
// double sum = 0;

// int a = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());

// for(int i =0; i<=n; i++)
// {
//     sum+=Math.Pow(a,i);
// }
// System.Console.WriteLine("Sum: "+sum);


// Task 3
// int[] arr = new int[1000];

// int sum = 0;

// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());

//     if (arr[i] == 0 && i > 0 && arr[i - 1] == 0)
//     {
//         break;
//     }

//     sum += arr[i];
// }

// System.Console.WriteLine(sum);


// Task 4
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for(int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// if(arr[arr.Length - 1] > 0 && arr[arr.Length - 2] > 0 ||
//    arr[arr.Length - 1] < 0 && arr[arr.Length - 2] < 0)
// {
//     System.Console.WriteLine("YES");
// }
// else
// {
//     Console.WriteLine("NO");
// }


// Task 5
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for(int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// for(int i = 0; i < n; i++)
// {
//     for(int j = i + 1; j < n; j++)
//     {
//         if(arr[i] == arr[j])
//         {
//             Console.Write(arr[i] + " ");
//             Console.Write(arr[j] + " ");
//             break;
//         }
//     }
// }


// Task 6
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for(int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// int min = arr[0];

// for(int i = 0; i < n; i++)
// {
//     if(min > arr[i])
//     {
//         min = arr[i];
//     }
// }

// System.Console.WriteLine(min);


// Task 7
// int n;
// int sum = 0;
// int count = 0;

// while (true)
// {
//     Console.Write("Give a number: ");
//     n = Convert.ToInt32(Console.ReadLine());

//     if (n == 0)
//     {
//         break;
//     }

//     sum += n;
//     count++;
// }

// Console.WriteLine("Sum of numbers: " + sum);
// Console.WriteLine("Count of numbers: " + count);


// Task 8
// int n = Convert.ToInt32(Console.ReadLine());

// int sum = 0;
// int mult = 1;

// for (; n > 0; n /= 10)
// {
//     int digit = n % 10;

//     sum += digit;
//     mult *= digit;
// }

// Console.WriteLine("Sum: " + sum);
// Console.WriteLine("Zarb: " + mult);


// Task 9
// int n = Convert.ToInt32(Console.ReadLine());

// for (; n > 0; n /= 10)
// {
//     int a = n % 10;
//     Console.Write(a);
// }



// Hometask 2
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for(int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// int mult = 1;

// for(int i = 0; i < n; i++)
// {
//     mult *= arr[i];
// }

// for(int i = 0; i < n; i++)
// {
//     Console.Write(arr[i]);

//     if(i < n - 1)
//     {
//         Console.Write("*");
//     }
// }

// Console.WriteLine(" = " + mult);



// hometask 4
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for(int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// for(int i = 0; i < n; i++)
// {
//     int count = 0;

//     for(int j = 0; j < n; j++)
//     {
//         if(arr[i] == arr[j])
//         {
//             count++;
//         }
//     }

//     if(count == 1)
//     {
//         Console.Write(arr[i] + " ");
//     }
// }



// hometask 8
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for(int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// for(int i = 0; i < n; i++)
// {
//     if(arr[i] % 2 != 0)
//     {
//         Console.Write(i + " ");
//     }
// }


// hometask 9
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for(int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// for(int i = a; i <= b; i++)
// {
//     if(arr[i] % 2 != 0)
//     {
//         Console.Write(arr[i] + " ");
//     }
// }


// hometask 10
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for(int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// for(int i = 0; i < n; i++)
// {
//     if(arr[i] % 2 != 0)
//     {
//         Console.Write(arr[i] * arr[i] + " ");
//     }
// }


// hometask3
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

for(int i=0;i<n;i++);
System.Console.WriteLine(n-1);