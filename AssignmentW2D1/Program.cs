using System;

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
            public string getHTML(string value)
            {
                return this.html;
            }
        }






        static void Main(string[] args)
        {
            JSONBuilder obj = new JSONBuilder();
            obj.beginBracket("name").setContent("Mohammed").endBracket();
            string res = obj.getHTML("FI");
            Console.WriteLine(res);
        }
    }
}
