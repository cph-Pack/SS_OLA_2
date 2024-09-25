namespace SS_OLA2_BACKEND.Data
{
    public class Warehouse
    {
        public int Id { get; private set; }

        public Warehouse(int id)
        {
            if (id < 1 || id > 5)
            {
                throw new ArgumentException("Id must be between 1 and 5.");
            }
            Id = id;
        }
    }
}