namespace AssignmentSession05OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01

            /*
             a) What happens when you assign one object variable to another object variable?

            ans => Changes to the fields will be reflected in both, because they both point to the same object.

            b) Does assigning one object to another create a new object? Explain.

            ans => No. It makes both variables point to the same object;
            a modification through one variable will be reflected when accessing the object through the other.

            c) What is the difference between copying an object and copying its reference?

            ans => Copying an object means creating a new object on the heap and copying the data into it;
            modifications to one do not affect the other. However, 
            copying its reference results in the new reference pointing to the same object,
            so modifications to one are reflected in the other.

             */

            #endregion

            #region Question02

            /*
              a) What is a Shallow Copy?

            ans => It creates a new object and copies the values of all fields. 
            For value-type fields, the value itself is copied; for reference-type fields,
            the reference is copied, so both objects point to the same referenced object.

            b) What is a Deep Copy?

            ans => It copies the object's internal value-type data,
            but for internal references—such as nested objects—it creates a new object on the heap.

            c) What happens to reference-type members when a Shallow Copy is created?

            ans => It copies the address and points to the same object—except for strings, because they are immutable.

            d) What happens to reference-type members when a Deep Copy is created?

            ans => It creates a new object for this reference, making it independent of the original one.

            e) Give one situation where Deep Copy would be safer than Shallow Copy

            ans => When two objects need to be modified independently, 
            Deep Copy is safer because changes made to one object will not affect the other.

             */

            #endregion
        }
    }
}
