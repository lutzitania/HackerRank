using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text; //Add this to allow us to use StringBuilders.

class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        //Through runtime, we manipulate this dictionary, which has an int for a key and a StringBuilder for a value.
        Dictionary<int, StringBuilder> result = new Dictionary<int, StringBuilder>();
        string answer = "";

        for(int a0 = 0; a0 < n; a0++){
            string[] tokens_x = Console.ReadLine().Split(' ');
            int x = Convert.ToInt32(tokens_x[0]);

            //Create the string in memory and insert a dash if it's in the first half of the input array.
            //Append spaces here to store in memory and save performance.
            string s = "";
            if(a0 < n/2){s = "- ";} else{s = (tokens_x[1] + " ");}
            
            //If the dictionary doesn't have the key, add it. If it does, append the new string using the StringBuilder.
            if(!result.ContainsKey(x)){
                result.Add(x, new StringBuilder(s));
            } else {
                result[x].Append(s);
            }
        }
        
        //Jump into a linked list so we can easily sort.
        var list = result.Keys.ToList();
        list.Sort();
        
        foreach(var key in list){
            answer += result[key];
        }
        
        System.Console.WriteLine(answer);
    }
}
