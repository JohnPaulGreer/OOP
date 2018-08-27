using System;

namespace OOPprinciples
{
    public class Car : Automobile //This is an example of inheritance
    {
        //This is an example of polymophism
        public Car(string model)
        {
            SetModel(model);
        }
        public new void setNumberOfTires(int tires)
        {
            if (tires > 5)
            {
                numOfTires = 4;
            }
            numOfTires = tires;
        }
        //this is an example of encapsulation
        public string honk()
        {
            return Reply();
        }
        private string Reply()
        {
            string model = GetModel();
            int tires = GetNumberOfTires();
            return "This is a " + model + ". It has " + tires + " tires";
        }
    }
}
