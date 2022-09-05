namespace Iterators
{
    interface IInhabitants
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public string ToString();
    }
    class Akula : IInhabitants
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public Akula()
        {
            Type = "Akula";
            Description = "a superorder of cartilaginous fish belonging to the subclass of " +
                "elasmobranchs and having the following distinctive features: an elongated " +
                "body of a more or less torpedo shape, a large heterocercal caudal fin, usually many sharp teeth on each jaw";
        }
        public override string ToString()
        {
            return $"{Type} description: {Description}\n";
        }
    }
    class Skat : IInhabitants
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public Skat()
        {
            Type = "Skat";
            Description = "a row of cartilaginous ribs. Dovzhina up to 5 - 9 m, width up to 6 m, vaga up to 500 kg.";
        }
        public override string ToString()
        {
            return $"{Type} description: {Description}\n";
        }
    }
    class Oceanarium
    {
        public List<IInhabitants> inhabitants = new List<IInhabitants>()
        {
            new Akula(), new Skat(),
        };
        public IEnumerator<IInhabitants> GetEnumerator()
        {
            for (int i = 0; i < inhabitants.Count; i++)
                yield return inhabitants[i];
        }
    }
}