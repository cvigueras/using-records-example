namespace Records.Example.App.Test
{
    public class PersonShould
    {
        [Test]
        public void BeEqualsPerson1AndPerson2()
        {
            var person1 = new Person("Pepito", "Grillo", "Avenida del Mojón Nº3", 33, "Poco");
            var person2 = new Person("Pepito", "Grillo", "Avenida del Mojón Nº3", 33, "Poco");

            Assert.IsTrue(person1.Equals(person2));
        }
    }
}