namespace CustomDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person_c person1 = new Person_c(20, "이순신");
            Person_c person2 = new Person_c(30, "BBB");

            Console.WriteLine($"person1 나이 : {person1.Age}, 이름 : {person1.Name}");
            Console.WriteLine($"person2 나이 : {person2.Age}, 이름 : {person2.Name}");

            Person_c perons = new Person_c();

            Person_s per_s = new Person_s(40, "CCC");
            Console.WriteLine($"per_s 나이 : {per_s.age}, 이름 : {per_s.name}");

            MakePersonVerClass(person2, 40, "DDD");
            per_s = MakePersonVerStruct(per_s, 50, "EEE");
            Console.WriteLine($"person2 나이 : {person2.Age}, 이름 : {person2.Name}");
            Console.WriteLine($"per_s 나이 : {per_s.age}, 이름 : {per_s.name}");
        }

        static void MakePersonVerClass(Person_c person, int age, string name)
        {
            person.Age = age;
            person.Name = name;
        }

        static Person_s MakePersonVerStruct(Person_s person, int age, string name)
        {
            person.age = age;
            person.name = name;

            return person;
        }

    }
}
