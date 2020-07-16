using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab9_4
{   class Program
    {
        static void Main(string[] args)
        {
            StringBuilder htmlText = new StringBuilder();
            string headerOpen = "<h1>";
            string headerClose = "</h1>";
            string bodyOpen = "<body>";
            string bodyClose = "</body>";
            string pOpen = "<p>";
            string pClose = "</p>";
            string listOpen = "<list>";
            string listClose = "</list>";
            string lineOpen = "<li>";
            string lineClose = "</li>";

            Console.WriteLine("Enter some text you want to put as your header.");
            string dynamicHeader = Console.ReadLine(); 
            Console.WriteLine("Enter some text you want to put on your web page.");
            string dynamicHTML = Console.ReadLine();
            Console.WriteLine("Enter some text for list 1/3.");
            string dynamicUL1 = Console.ReadLine(); 
            Console.WriteLine("Enter some text for list 2/3.");
            string dynamicUL2 = Console.ReadLine(); 
            Console.WriteLine("Enter some text for list 3/3.");
            string dynamicUL3 = Console.ReadLine();

            htmlText.Append(headerOpen);
            htmlText.Append(dynamicHeader);
            htmlText.Append(headerClose);
            htmlText.Append(bodyOpen);
            htmlText.Append(pOpen);
            htmlText.Append(dynamicHTML);
            htmlText.Append(listOpen);
            htmlText.Append(lineOpen);
            htmlText.Append(dynamicUL1);
            htmlText.Append(lineClose);
            htmlText.Append(lineOpen);
            htmlText.Append(dynamicUL2);
            htmlText.Append(lineClose);
            htmlText.Append(lineOpen);
            htmlText.Append(dynamicUL3);
            htmlText.Append(lineClose);
            htmlText.Append(listClose);
            htmlText.Append(pClose);
            htmlText.Append(bodyClose);

            string fileName = "C:\\Users\\ACT-Student\\source\\repos\\filewriter\\Lab.html";
            File.AppendAllText(fileName, htmlText.ToString());
            
        }
    }
}
