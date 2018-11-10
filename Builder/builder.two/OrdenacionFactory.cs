namespace builder.two
{
    public class OrdenacionFactory
    {
        public OrdenacionBuilder GetOrdenacionBuilder(string _string)
        {
            OrdenacionBuilder builder = null;
            if (_string.Equals("QS"))
            {
                builder = new OrdenacionQuickSort();
            }
            return builder;
        }
    }
}
