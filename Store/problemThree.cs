using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//შექმენით კლასი MyClass და სტრუქტურა MyStruct, რომლებიც შეიცავენ public string change ცვლადს.
//მთავარ კლასში შექმენით ორი მეთოდი
//* static void ClassTaker(MyClass myClass), რომელიც მიანიჭებს myClass-ის ველ change-ს მნიშვნელობას "Changed"
//* static void StructTaker(MyStruct myStruct), რომელიც მიანიჭებს myStruct-ის ველ change-ს მნიშვნელობას "Changed"
//შექმენით ორივე კლასის ობიექტი, გამოიძახეთ ეს მეთოდები ამ  ობიექტების გადაცემით და დაბეჭდეთ მონაცემები მეთოდების მუშაობის შემდეგ, გააანალიზეთ მიღებული შედეგი.
namespace Store
{
    public class MyClass
    {
        public string change;
    }
    public struct MyStruct
    {
        public string change;
    }
    public class problemThree
    {
        public static void Main1()
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();
            ClassTaker(myClass);
            StructTaker(myStruct);
            Console.WriteLine("Class parameter: " + myClass.change);
            Console.WriteLine("Struct parameter: " + myStruct.change);
        }
        static void ClassTaker(MyClass myClass)
        { 
            myClass.change = "changed";
        }
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "changed";
        }
    }
}
