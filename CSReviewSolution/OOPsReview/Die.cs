using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    public class Die
    {
        //use the System.Random class for my random number generator
        //the instance will be static so all instances of Die will use
        //     the same generator
        //the instance of Random will be created when the first instance
        //     of Die is created and be destoryed when the last instance
        //     of Die is destoryed
        public static Random _rnd = new Random();

        //Data Members
        // this is the physical storage area for data values
        // these are usually private

        private int _Sides;
        private string _Color;
        

        //Properties
        // Properties are public
        // is used as an interface for the class user to access
        //     a data member
        // accessing a data member can included a get and set
        // a get returns the value of the data member to the user
        // a set accepts a value and assigns the value
        //    to the data member
        // a property returns a specific datatype
        // a property does NOT have a parameter list

        //Fully Implemented Property
        public int Sides
        {
            get
            {
                //returns the current value of the data member
                return _Sides;
            }
            set
            {
                //can be private
                //it accepts a value and assign it to the data member
                //the value is stored in a key word: value
                //the datatype of value is the return datatype of the property
                //validation can be done on the value
                if (value >= 6 && value <=20)
                {
                    _Sides = value;
                    Roll();
                }
                else
                {
                    throw new Exception("Die cannot have " + value.ToString() + " sides. Die can have 6 to 20 sides.");
                }
                
            }
        }


        //Auto Implemented Property
        //there is no defined data member for this type of property
        //instead, the system creates an internal storage area of the
        //    property datatype and manages the area for your code.
        //typically this type of property is commonly used when no
        //    validation is required for the data
        public int FaceValue { get; private set; }

        public string Color
        {
            get
            {
                return _Color;
            }
            set
            {
                //value.Trim() == "" test? empty string
                //value == null  test? no string exists
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new  Exception("Color is invalid. You must have a color.");
                }
                else
                {
                    _Color = value;
                }
            }
        }

        //Constructors
        //optionally
        //if you do not include a constructor for your class then when an
        //     instance of the class is created, the system will assign
        //     the normal defualt values of that datatype to the appropriate
        //     data member.

        //if you declare a constructor within your class definition, then,
        //     you are responsible for all constructors for the class.
        //constructor are NOT called directly by the user of the class
        //the constructor will be called when you ask the system to create
        //     an instance of the class

        //syntax public classname([list of parameters]) { coding body }

        //default constructor
        //this is similar to having a system constructor
        //it has no parameters
        public Die()
        {
            //typically this contructor will have no code, that is, use
            //    the system defaults

            //you could assign your own defualts
            _Sides = 6;
            Color = "White";
            Roll();
        }

        //greedy constructor
        //takes in values for each of your data members/ auto properties
        //this allows the outside "user" wants to specify values at time
        //      of creation for the instance
        public Die(int sides, string color)
        {
            Sides = sides;
            Color = color;
            Roll();
        }

        //Behaviours (methods)
        //a method will allow the user to 
        //a) manipulate the data of the instance
        //b) use the data of the instance to generate some other information

        public void Roll()
        {
            //will generate a random value for FaceValue
            FaceValue = _rnd.Next(1, Sides + 1);
        }
    }
}
