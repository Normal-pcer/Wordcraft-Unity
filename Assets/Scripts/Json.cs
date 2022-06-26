using System.Collections;
using System.Collections.Generic;

public class Json
{
    public static Dictionary<string, string> decode(string json)
    {
        Dictionary<string, string> result;
        Stack<string> st;
        for (int i = 0; i < json.Length; i += 1)
        {
            char c = json[i];
            switch (c)
            {
                case '"':  // string begin/end
                    if (st.Peek == "string")
                    {
                        st.Pop();
                    }
                    else
                    {
                        st.Push("string");
                    }
                    break;
                case ':':
            }
        }
    }
}