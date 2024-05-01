namespace ToolboxH1
{


    internal class Datatypes: IComparer<Biler>
    {
         private SortBy sortBy;

        public Datatypes()
        {
        }

        public Datatypes(SortBy sortBy)
        {
            this.sortBy = sortBy;
        }

        public int Compare(Biler? x, Biler? y)
        {
            switch (sortBy)
            {
                case SortBy.COLOR:
                    return x.Color.CompareTo(y.Color);
                case SortBy.RPM:
                    return x.RPM.CompareTo(y.RPM);
                case SortBy.NAME:
                    return x.Name.CompareTo(y.Name);
                case SortBy.SPEED:
                    return x.Speed.CompareTo(y.Speed);
                default:
            throw new ArgumentException();                  
            }
        }

        //public int CompareTo(Biler obj)
        //{
        //    int tal = new Biler().Color.CompareTo(((Biler)obj).Color);
        //    return tal;
        //}
    }
}
