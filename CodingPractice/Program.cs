using System;
using System.Collections.Generic;


class codPrac
{
    static void Main()
    {
        //Prac_1();
        //Prac_2();
        //Prac_3();
        //Prac_4();
        //Prac_5();
        //Prac_6();
        //Prac_7();
        //Prac_8();
        //Prac_9();
        Prac_10();
    }

    static void Prac_1()
    {
        string s1 = "hello";
        string s2 = "hello";
        string s3 = new string("hello".ToCharArray());

        Console.WriteLine(s1 == s2);
        Console.WriteLine(s1 == s3);
        Console.WriteLine(object.ReferenceEquals(s1,s2));
        Console.WriteLine(object.ReferenceEquals(s1, s3));
    }
    static void Prac_2()
    {
        Player p1 = new Player("용사", 1);
        Player p2 = new Player("용사", 1);
        Player p3 = p1;
        Console.WriteLine($"p1 == p2: {p1 == p2}");
        Console.WriteLine($"p1 == p2: {p1 == p3}");
        Console.WriteLine($"p1.Equals(p2): {p1.Equals(p2)}");
        Console.WriteLine($"p1.Equals(p3): {p1.Equals(p3)}");

    }
    static void Prac_3()
    {
        Position pos1 = new Position(10, 20);
        Position pos2 = new Position(10, 20);
        Position pos3 = new Position(30, 40);

        Console.WriteLine($"pos1.Equals(pos2): {pos1.Equals(pos2)}");
        Console.WriteLine($"pos1.Equals(pos3): {pos1.Equals(pos3)}");
    }
    static void Prac_4()
    {
        Item item1 = new Item("Sword",1);
        Item item2 = new Item("Sword", 1);
        Item item3 = new Item("Shield", 2);

        Console.WriteLine($"item1.Equals(item2): {item1.Equals(item2)}");
        Console.WriteLine($"item1.Equals(item3): {item1.Equals(item3)}");

        HashSet<Item> inventory = new HashSet<Item>();
        inventory.Add(item1);
        Console.WriteLine($"inventory.Contains(item2): {inventory.Contains(item2)}");

    }
    static void Prac_5()
    {
        BadItem b1 = new BadItem("Potion");
        BadItem b2 = new BadItem("Potion");

        Console.WriteLine($"b1.Equals(b2): {b1.Equals(b2)}");
        Dictionary<BadItem, int> stock = new Dictionary<BadItem, int>();
        stock[b1] = 10;
        Console.WriteLine($"stock.ContainsKey(b2): {stock.ContainsKey(b2)}");
    }
    static void Prac_6()
    {
        List<Monster> monsters = new List<Monster>
        {
            new Monster("Goblin", 30),
            new Monster("Dragon", 100),
            new Monster("Slime", 10),
            new Monster("Orc", 50)
        };
        Console.WriteLine("정렬 전");
        foreach(Monster m in monsters)
        {
            Console.WriteLine($" {m}");
        }
        monsters.Sort();
        Console.WriteLine("정렬 후:");
        foreach (Monster m in monsters)
        {
            Console.WriteLine($" {m}");
        }
    }
    static void Prac_7()
    {
        List<Student> students = new List<Student>
        {
            new Student("김철수", 2, 85),
            new Student("이영희", 1, 92),
            new Student("박민수", 2, 85),
            new Student("정수진", 1, 88),
            new Student("최동훈", 2, 90)
        };

        students.Sort();
        Console.WriteLine("정렬 결과: ");
        foreach(Student student in students)
        {
            Console.WriteLine($" {student}");
        }

    }
    static void Prac_8()
    {
        Customer c1 = new Customer("Kim", "Cheolsu");
        Customer c2 = new Customer("Kim", "Cheolsu");

        Dictionary<Customer, string> dict1 = new Dictionary<Customer, string>();
        dict1[c1] = "VIP";
        Console.WriteLine($"기본 Dictionary - c2 검색: {dict1.ContainsKey(c2)}");

        Dictionary<Customer, string> dict2 = new Dictionary<Customer, string>(new CustomerNameComparer());
        dict2[c1] = "VIP";
        Console.WriteLine($"커스텀 Dictionary - c2 검색: {dict2.ContainsKey(c2)}");

    }
    static void Prac_9()
    {
        Dictionary<string, int> caseInsensitive = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        caseInsensitive["Apple"] = 100;
        caseInsensitive["BANANA"] = 200;

        Console.WriteLine($"aplle 검색 : {caseInsensitive["Apple"]}");
        Console.WriteLine($"aplle 검색 : {caseInsensitive["Banana"]}");


        Dictionary<string, int> caseSensitive = new Dictionary<string, int>();
        caseSensitive["Apple"] = 100;

        Console.WriteLine($"\n일반 Dictionary에서 'apple' 존재 여부: {caseSensitive.ContainsKey("apple")}");
    }
    static void Prac_10()
    {
        List<Quest> quests = new List<Quest>
        {
            new Quest("드래곤 처치", 1, 10000),
            new Quest("약초 수집", 3, 100),
            new Quest("마을 방어", 2, 500),
            new Quest("보물 찾기", 2, 3000)
        };

        Console.WriteLine("우선순위 기준 정렬:");
        quests.Sort(new QuestPriorityComparer());
        foreach (Quest q in quests)
        {
            Console.WriteLine($"  {q}");
        }

        Console.WriteLine("\n보상 기준 정렬 (내림차순):");
        quests.Sort(new QuestRewardComparer());
        foreach (Quest q in quests)
        {
            Console.WriteLine($"  {q}");
        }
    }
    static void Prac_11()
    {

    }
    static void Prac_12()
    {

    }
    static void Prac_13()
    {

    }
    static void Prac_14()
    {

    }
    static void Prac_15()
    {

    }

}