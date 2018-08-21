namespace HelloWorld
{


    public class Message
    {
        // Attribut basique
        public string Hello = "Bonjour";

        // Attribut + getter/setter
        private string _Bonjour = "Hello";

        public string Bonjour
        {
            get
            {
                return _Bonjour;
            }
            set
            {
                _Bonjour = value;
            }
        }

        // Propiété par default
        public string World
        { get; set; } // = Default value

        // Prop
        public string Name
        {
            get { return Hello + ' ' + Bonjour; } // Propriété calculé
            set { Name = value; }
        }

        public Message(string newMsg) => Msg = newMsg;

        public string Msg
        { get; set; }
    }
}


