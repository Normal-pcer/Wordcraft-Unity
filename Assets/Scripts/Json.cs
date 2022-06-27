using System.Collections;
using System.Collections.Generic;

public class Json<T>
{
    public static Dictionary<string, string> decode_one_floor(string json)
    {
        Dictionary<string, string> result;
        Stack<string> st;
        for (int i = 0; i < json.Length; i += 1)
        {
            char c = json[i];
            if (c == '{')
            {
                if (st.Count == 0)
                    st.Push("dict");
                else if (st.Peek() == "value")
                { }
                else
                    throw new System.Exception("Invalid JSON");
            }
            else if (c == '}')
            {
                if (st.Peek() == "value" || st.Peek() == "dict")
                    st.Pop();
                else
                    throw new System.Exception("Invalid JSON");
            }
            else if (c == ',')
            {
                if (st.Peek() == "value")
                    st.Pop();
                else
                    throw new System.Exception("Invalid JSON");
            }
            else if (c == ':')
            {
                if (st.Peek() == "dict")
                    st.Push("value");
                else
                    throw new System.Exception("Invalid JSON");
            }
            else if (c == '"')
            {
                if (st.Peek() == "value")
                    st.Pop();
                else
                    throw new System.Exception("Invalid JSON");
            }
        }
    }
}