using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    public class Die
    {
        //Data Members
        // this is the physical storage area for data values
        // these are usually private

        private int _Sides;
        private string _Color;
        private int _FaceValue;

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
        public int Side
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
                }
                else
                {
                    throw new Exception("Die cannot have " + value.ToString() + " sides. Die can have 6 to 20 sides.");
                }
                
            }
        }


        //Auto Implemented Property
    }
}
