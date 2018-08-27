using System;
namespace OOPprinciples
{
    public class Car
    {
        //this is an example of abstraction

        public int numOfTires;
        public string Model;

        public void setNumberOfTires(int tires)
        {
            numOfTires = tires;
        }
        public int GetNumberOfTires()
        {
            return numOfTires;
        }
        public void SetModel(string model)
        {
            if (String.IsNullOrWhiteSpace(model))
            {
                Model = "F-250";
            }
            Model = model;
        }
        public string GetModel()
        {
            return Model;
        }
    }
}
