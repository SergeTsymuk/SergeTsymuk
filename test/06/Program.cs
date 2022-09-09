
Stack<char> st = new Stack<char>();
int i = 0;
string entered = "azxxzy";

while (i < entered.Length)
{
    if (st.Count == 0 || (st.Count != 0 && entered[i] != st.Peek()))
    {
        st.Push((entered[i]));
        i++;
    }
    else
    {
        if (st.Count != 0)
            st.Pop();
        i++;
    }
}

foreach (var item in st)
{
    Console.Write(item);
}
