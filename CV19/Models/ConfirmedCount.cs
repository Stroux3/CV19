namespace CV19.Models
{
    internal struct ConfirmedCount(DateTime date, int count)
    {
        public DateTime Date { get; set; } = date;
        public int Count { get; set; } = count;
    }
}
