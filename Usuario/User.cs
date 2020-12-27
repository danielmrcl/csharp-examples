
namespace Aplicacao.Usuario
{
    public struct User
    {
        private string name;
        
        private int age;

        public User (string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString ()
        {
            return $"\tnome: {this.Name}\n\tidade: {this.Age}\n";
        }
    }
}
