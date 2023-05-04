namespace ReactorDemo
{
    public class MeltdownEventArgs
    {
        private string v;

        public MeltdownEventArgs(string v)
        {
            this.v = v;
        }

        public bool Message { get; internal set; }
    }
}