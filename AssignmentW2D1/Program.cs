﻿using System;
using System.Collections;

namespace AssignmentW2D1
{
    class Program
    {

        class JSONBuilder
        {
            private string html;

            public JSONBuilder()
            {
                this.html = "";
            }
            public JSONBuilder beginBracket(string value)
            {
                this.html += "{\"" + value + "\":" ;
                return this;
            }
            public JSONBuilder setContent(string value)
            {
                this.html += "\"" + value;
                return this;
            }
            public JSONBuilder endBracket()
            {
                this.html += "\"}";
                return this;
            }
            public string getHTML()
            {
                return this.html;
            }
        }


        public static bool isMatched(string numbers)
        {
            int len = numbers.Length;

            Stack stk = new Stack();

            char tmp;

            if(numbers.Length % 2 == 0)
            {

                for (int i = 0; i < numbers.Length; i++)
                {

                    stk.Push(numbers[i]);
                    tmp = (char)stk.Peek();

                    if (tmp == numbers[i])
                    {
                        stk.Pop();
                    }
                    else if (numbers[i] != tmp)
                    {
                        stk.Push(numbers[i]);
                    }
                    
                }


                Console.WriteLine("ANS: " + stk.Count); 
                if (stk.Count == 0) { return true; }
                else { return false; }
            }
            else
            {
                return false;
            }

        }






        static void Main(string[] args)
        {
            JSONBuilder obj = new JSONBuilder();
            obj.beginBracket("name").setContent("Mohammed").endBracket();
            string res = obj.getHTML();
            Console.WriteLine(res);

            //=========

            string numbers = "12345678";
            string numbers2 = "123321";
            string numbers3 = "14667741";
            Console.WriteLine(numbers + "\t" + isMatched(numbers)); ;
            Console.WriteLine(numbers2 + "\t" + isMatched(numbers)); ;
            Console.WriteLine(numbers3 + "\t" + isMatched(numbers)); ;


        }
    }
}
