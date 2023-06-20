string[] words = { "the", "quick", "brown", "fox", "jumps" };  

  

IEnumerable<string> query = from word in words  

                            orderby word.Substring(0, 1) descending  

                            select word;  

  

foreach (string str in query)  

    Console.WriteLine(str);  

  

/* This code produces the following output:  

  

    the  

    quick  

    jumps  

    fox  

    brown  

*/
