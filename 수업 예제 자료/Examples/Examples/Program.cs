using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
           //메서드 
        //콘솔창에 출력
        void print(String []args)
        {
            System.Console.WriteLine("Hello world");
        }

        //많이 쓰는 자료형
        void dataType()
        {
            byte b1 = 0;
            byte b2 = 255;
            short s1 = -32768;
            short s2 = 32767;
            int i1 = -2147483648;
            int i2 = 2147483647;
            long l1 = -922337203685477508;
            long l2 = 922337203685477507;
            // 큰 값을 담을 수 있는 자료형 대신 더 적은 값을 담을 수 있는 자료형을 더 많이 쓰는 이유: 비트 크기를 줄여 속도를 올리기 위해서

            float f1 = -3.402823e38f;
            float f2 = 3.402823e38f;
            double d1 = -1.7976931348623157E+308;
            double d2 = 1.7976931348623157E+308;
            // 기본적으로 실수는 double형이며 뒤에 f를 붙혀주어야 float형이 됨

            bool bool1 = true;
            bool bool2 = false;
            // boolean

            char c1 = 'i';
            char c2 = '#';
            char c3 = '0';
            // 한 글자

            string str1 = "Hello";
            string str2 = "C#";
            string str3 = "Hello C#";
            // char의 집합

            int? num1 = 0;
            num1 = null;
            // nullable           
        }

        //배열
        void array()
        {
            int[] arr1 = { 0, 1, 2, 3, 4, 5 };
            arr1[0] = 1;
            arr1[5] = 4;
            // foreach
            foreach(int i in arr1)
            {
                System.Console.WriteLine(i);
            }
        }

        //리스트
        void list()
        {
            List<int> list1 = new List<int>();
            list1.Add(1);   // 1 추가 
            list1.Insert(1, 10);    // 1번째 인덱스에 10을 넣음
            list1.RemoveAt(1);  // 1번째 인덱스 값 삭제
            list1.Sort();   //내림차순으로 리스트 정리 
                
        }

        //딕셔너리
        void dictionary()
        {
            // 키와 값으로 이루어져 있으며 타입은 초기화 시에 결
함.
            Dictionary<string, int> nums = new Dictionary<string, int>();
            nums["첫번째 값은 무엇일까요"] = 0;
            nums["두번째 값은 무엇일까요"] = 1;   
        }

        //기초적인 문법
        void syntax()
        {
            int a = 5;
            int b = 7;

            // if else 
            if (a > b)
            {
                System.Console.WriteLine("a가 b보다 큽니다");
            }else if(a == b) {
                System.Console.WriteLine("a와 b는 같습니다");
            }else{
                System.Console.WriteLine("b가 a보다 큽니다");
            }

            // switch case
            switch (a)
            {
                case 4:
                    System.Console.WriteLine("a = 4");
                    break;
                case 5:
                    System.Console.WriteLine("a = 5");
                    break;
                case 6:
                    System.Console.WriteLine("a = 6");
                    break;
            }

            // for 
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine(i);
            }

            // while
            int j = 0;
            while (j < 5)
            {
                if (j == 5)
                {
                    break;
                }
                j++;
                System.Console.WriteLine(j);

            }

        }

        void fileWriterReader()
        {
            //File 생성법
            FileInfo file = new FileInfo("Users/jejeongmin/desktop/b.txt"); //설정한 경로 파일 객체 생성 
            if (!file.Exists)
            {
                file.Create(); //설정한 경로에 파일이 없다면 생성 
            }

            //StreamWriter
            StreamWriter writer = new StreamWriter("Users/jejeongmin/desktop/b.txt"); //파일에 쓰기 작업을 하기위한 writer 객체 생성
            writer.Write("Hello");
            writer.WriteLine("World");
            writer.Write("Hello World");
            writer.Close();

            //StreamReader
            StreamReader reader = new StreamReader("Users/jejeongmin/desktop/b.txt"); //파일을 읽기 작업을 하기위한 reader 객체 생성
            while (reader.Peek() >= 0)
            {
                Console.WriteLine(reader.ReadLine()); //1번째 줄 : HelloWorld 2번째 줄 : Hello World
            }
            reader.Close();


        }
        }
    }
}
