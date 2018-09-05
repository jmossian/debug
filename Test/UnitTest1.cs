using System;
using Xunit;
using Persona;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            const String nombre = "John Doe";
            Person john = new Person("John Doe", "1.234.567-8");
            Person jane = new Person("Jane Doe", "8.765.432-1");
            Person julieta = new Person("Julieta", "4.887.975-2");
            Assert.Equal(nombre, john.name);
            
        }
    }
}
