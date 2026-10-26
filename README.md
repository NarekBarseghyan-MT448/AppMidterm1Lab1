# Լաբորատոր Աշխատանքներ - Solution 'MidTerm1Lab1'

### 1. **Matrix**
**Խնդրի դրվածքը:**
* Ստեղծել Կլասս որը կպարունակի NxN չափերով մատրիցա
* Կլասսում պահել private դաշտեր N, A և B, ամբողջ թվերի համար, և նրանց համար ապահովել {set get} մեթոդները կարճ գրելաձևով,
* Ստեղծել private FillMatrix անունեով մեթոդ, որը կլրացնի մատրիցայի արժեքները [A, B] միջակայքից պատական թվերով
* Ստեղծել public ShowMatrix մեթոդը, որը ցույց կարտածի մատրիցայի պարունակությունը
* Ստեղծել մեթոդ որը կվերադարձնի մատրիցայի կենտ թվերի քանակաը
* Պարամետրիզացված Կոնստրուկտորով տեղադրել N, A և B դաշտերի արժեքները որից հետո կանչել FillMatrix մեթոդը
* Ցույց տալ կլասսի ֆունկիոնալությունը Main() մեթոդում

**Կատարած առաջադրանքը:**
```csharp
// Matrix/CreateMatrix.cs
using System;

namespace MatrixProgram
{
    public class CreateMatrix
    {
        private int[,] matrix;

        public int N { get; set; }
        public int A { get; set; }
        public int B { get; set; }

        public CreateMatrix(int n, int a, int b)
        {
            N = n;
            A = a;
            B = b;
            matrix = new int[N, N];
            FillMatrix();
        }

        private void FillMatrix()
        {
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = rand.Next(A, B + 1);
                }
            }
        }

        public void ShowMatrix()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public int GetOddNumbersCount()
        {
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] % 2 != 0) count++;
                }
            }
            return count;
        }
    }
}
```

---

### 2. **Overloading**
**Խնդրի դրվածքը:**
* Ստեղծել static ToMultiplicate մեթոդը, 3 օրինակով, որը կնդունի x, N փոփոխականները
* N-ը կունենեա ըստ լռելյայն (default) արժեք 2, կլինի int տիպի
* Իսկ x-ը կլինի երեք տարբերակով int, double և string
* Ֆունկցիան պիտի վերադարձնի N հատ x-երի գումարը, հատուկ սենց գրեցի որ string-ի դեպքն էլ հասկանալի լինի
* Թեստավորել overloading-ի աշխատանքը Main() մեթոդում

**Կատարած առաջադրանքը:**
```csharp
// Overloading/Program.cs
using System;

namespace Overloading
{
    internal class Program
    {
        public static int ToMultiplicate(int x, int N = 2) => x * N;
        public static double ToMultiplicate(double x, int N = 2) => x * N;
        public static string ToMultiplicate(string x, int N = 2)
        {
            string result = "";
            for (int i = 0; i < N; i++) result += x;
            return result;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write(ToMultiplicate(2, 3) + "\n");
            Console.WriteLine(ToMultiplicate(3.2, 4) + "\n");
            Console.WriteLine(ToMultiplicate("A", 3));
        }
    }
}
```

---

### 3. **Formatting**
**Խնդրի դրվածքը:**
* Ստեղծել Movie.cs կլասսը որը կպարունակի [ֆիլմի համարը, ֆիլմի անունը, տարեթիվը, ֆիլմի ժանրը, դիտումների քանակը, լայքերի քանակը]
* Ֆիլմի ժանրի համար ստեղծել enum 5 տարբերակ պարունակող, ըստ ձեր հայեցողությամբ
* Մուրտքագրումը կատարել Console-ից ReadLine() մեթոդով, ժանրը գրել որպես 1 ից 5 թիվ, որից հետո ինֆորմացիան տարանջատել (split) և տեղավորել կլասսի դաշտերում.
* Ստեղծել նաև մեթոդ որը կհաշվի ֆիլմի ռեյտինգը հետևյալ բանաձևով SQRT(Likes ^ 2 / Views) կլինի double տիպի;
* Movie.cs կլասսի համար override անել ToString() մեթոդը որը ցույց կտա կլասսի պարունակությունը հետևյալ կերպ
  - Ֆիլմի համարը, {4 տառաչափ, կցել աջ}
  - Ֆիլմի անունը, {15 տառաչափ, կցել ձախ}
  - Տարեթիվը, {8 տառաչափ, կցել ձախ և փակագծերի մեջ օր․"(2011)"}
  - Ֆիլմի ժանրը, {12 տառաչափ, տեքստային, կցել ձախ}
  - Ռեյտինգը {8 տառաչափ, ստրոակետրից հետո 1000-րդական ճշտությամբ, անպայման ցույց տա նաև եթե զրոներ են}
* Ցույց տալ կլասսի ֆունկիոնալությունը Main() մեթոդում, ծրագիրը սկզբում կընդհունի քանակը օրինակ 7 և հետո ցիկլով կնդունի 7 հատ ֆիլմի տվյալներ, այնուհետև ցիկլով ցույց կտա ֆորմատավորված տեսքով։
* Որպեսզի ավելորդ չբարդացնեք բոլոր մեմբերները և մեթոդները ստեղծել public

**Կատարած առաջադրանքը:**
```csharp
// Formatting/Movie.cs
using System;

namespace Movie
{
    public class Movie
    {
        public enum MovieGenre { Action = 1, Comedy, Drama, Horror, SciFi }

        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public MovieGenre Genre { get; set; }
        public int Views { get; set; }
        public int Likes { get; set; }

        public Movie(int id, string title, int year, MovieGenre genre, int views, int likes)
        {
            Id = id; Title = title; Year = year; Genre = genre; Views = views; Likes = likes;
        }

        public double GetRating() => Views == 0 ? 0 : Math.Sqrt((double)(Likes * Likes) / Views);

        public override string ToString()
        {
            string yearInBrackets = \$"({Year})";
            return \$"{Id,4} {Title,-15} {yearInBrackets,-8} {Genre,-12} {GetRating(),8:F3}";
        }
    }
}
```

```csharp
// Formatting/Program.cs
using System;
using System.Collections.Generic;

namespace Movie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Movie> movieList = new List<Movie>();

            movieList.Add(new Movie(1, "Inception", 2010, Movie.MovieGenre.SciFi, 100000, 85000));
            movieList.Add(new Movie(2, "Shrek", 2001, Movie.MovieGenre.Comedy, 50000, 45000));
            movieList.Add(new Movie(3, "The Dark Knight", 2008, Movie.MovieGenre.Action, 150000, 140000));

            Console.WriteLine(new string('-', 55));
            Console.WriteLine(\$"{"Համար", 4} {"Անվանում", -15} {"Տարի", -8} {"Ժանր", -12} {"Ռեյտինգ", 8}");
            Console.WriteLine(new string('-', 55));

            foreach (var movie in movieList)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine(new string('-', 55));
        }
    }
}
```

---

### 4. **InOutRef**
**Խնդրի դրվածքը:**
* Ստեղծել static A(), B(), C() մեթոդները, համապատասխանաբար in, out, ref, մոդֆիկատորները փորձարկելու համար
* Ստեղծել նաև SumValues(params … ) մեթոդը որը կգումարի մուտքում եկած ամբողջ թվերը, թվերի քանակը ֆիքսված չէ
* Ցույց տալ թե ինչպես են աշխատում այս մեթոդները, Main() մեթոդում

**Կատարած առաջադրանքը:**
```csharp
// InOutRef/Program.cs
using System;

namespace ModifiersProgram
{
    internal class Program
    {
        public static void A(in int number) => Console.WriteLine(\$"in: {number}");
        public static void B(out int result) => result = 100;
        public static void C(ref int number) => number *= 2;
        
        public static int SumValues(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers) sum += num;
            return sum;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int valIn = 25; A(valIn);
            int valOut; B(out valOut);
            int valRef = 10; C(ref valRef);

            Console.WriteLine(\$"SumValues(1,2,3) -> {SumValues(1, 2, 3)}");
        }
    }
}
```
