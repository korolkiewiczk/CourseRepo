namespace Course27032017
{
    class Document
    {
        public string Text { get; }
        public int Id { get; }
        private static int _id = 1;

        public Document(string text)
        {
            Text = text;
            Id = _id++;
        }



    }
}
