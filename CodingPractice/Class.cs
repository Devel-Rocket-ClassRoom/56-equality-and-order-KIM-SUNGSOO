using System;
using System.Collections.Generic;
using System.Text;

class Player
{
    string Name;
    int Level;

    public Player(string name, int level)
    {
        Name = name;
        Level = level;
    }

}

struct Position
{
    public int X;
    public int Y;


    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }
}

class Item : IEquatable<Item>
{
    public string Name;
    public int Id;

    public Item(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public bool Equals(Item other)
    {
        if (other == null)
        {
            return false;
        }
        return Id == other.Id && Name == other.Name;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as Item);
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Id);
    }

}


class BadItem 
{
    public string Name;

    public BadItem(string name)
    {
        Name= name;
    }

    public override bool Equals(object obj)
    {
        BadItem other = obj as BadItem;
        if (other == null)
        {
            return false;
        }
        return Name == other.Name;
    }

}

class Monster : IComparable<Monster>
{
    public string Name;
    public int Power;

    public Monster(string name, int power)
    {
        Name = name;
        Power = power;
    }

    public int CompareTo(Monster other)
    {
        if (other == null)
        {
            return 1;

        }
        return Power.CompareTo(other.Power);
    }
    public override string ToString()
    {
        return $"{Name}(전투력:{Power})";
    }

}

class Student : IComparable<Student>
{
    public string Name;
    public int Grade;
    public int Score;

    public Student(string name, int grade, int score)
    {
        Name=name;
        Grade =grade;
        Score =score;
    }

    public int CompareTo(Student other)
    {
        if (other == null)
        {
            return 1;

        }
        int result = Grade.CompareTo(other.Grade);
        if (result != 0)
        {
            return result;
        }

        result = other.Score.CompareTo(other.Score);
        if (result != 0)
        {
            return result;
        }
        return Name.CompareTo(other.Name);
    }

        public override string ToString()
        {
        return $"{Grade}학년 {Name} ({Score})";
        }
}

class Customer
{
    public string LastName;
    public string FirstName;

    public Customer(string lastName, string firstName)
    {
        LastName = lastName;
        FirstName = firstName;
    }

    public override string ToString()
    {
        return $"{LastName} {FirstName}";
    }
}

class CustomerNameComparer : EqualityComparer<Customer>
{
    public override bool Equals(Customer x, Customer y)
    {
        if (x == null && y == null)
        {
            return true;
        }
        if (x == null || y == null)
        {
            return false;
        }
        return x.LastName == y.LastName && x.FirstName == y.FirstName;
    }

    public override int GetHashCode(Customer obj)
    {
        if (obj == null)
        {
            return 0;
        }
        return HashCode.Combine(obj.LastName, obj.FirstName);
    }
}

class Quest
{
    public string Name;
    public int Priority;     
    public int RewardGold;

    public Quest(string name, int priority, int rewardGold)
    {
        Name = name;
        Priority = priority;
        RewardGold = rewardGold;
    }


    public override string ToString()
    {
        return $"[우선순위{Priority}] {Name} (보상: {RewardGold}골드)";
    }
}

class QuestPriorityComparer : Comparer<Quest>
{
    public override int Compare(Quest x, Quest y)
    {
        if (x == null && y == null)
        {
            return 0;
        }
        if (x == null)
        {
            return -1;
        }
        if (y == null)
        {
            return 1;
        }
        return x.Priority.CompareTo(y.Priority);
    }

}
class QuestRewardComparer : Comparer<Quest>
{
    public override int Compare(Quest x, Quest y)
    {
        if (x == null && y == null)
        {
            return 0;
        }
        if (x == null)
        {
            return -1;
        }
        if (y == null)
        {
            return 1;
        }
        // 내림차순: y와 x의 순서를 바꿈
        return y.RewardGold.CompareTo(x.RewardGold);
    }
}
