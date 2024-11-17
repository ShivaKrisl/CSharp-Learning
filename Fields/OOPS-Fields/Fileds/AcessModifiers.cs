using Public_Class_Demo_ClassLibraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Fileds
{
    public class AcessModifiers
    {
        /*
         * Access Modifiers of a Filed => specifies the accessbilitu or visibility of that filed
         * In general we have 5 locations
         * 1. In the same class
         * 2. In the child classes in the same assembly(project) (.dl or .exe file)
         * 3. In the other classes in the same assembly
         * 4. Child classes at other assembly
         * 5. Other classes at other assembly
         * 
         *  NOTE: Accessbility here means whether we can read/write value to that field or not. It is not about whether we can able to create obj having that filed because obj with that field is created but we cannot access field.
         */

        /*
         * 1. Private -> accessible with in the same class only (ony 1) -- from above locations
         * 2. Protected -> accessible in 
         *      ** In the same class
         *      ** In the child classes of same assembly
         *      ** In the child classes at other assembly
         * 3. Private Proteced -> accessible in
         *      ** In the same class
         *      ** In the child classes of same assembly
         * 4. Internal -> accessible in
         *      ** In the same class
         *      ** In the child classes of same assembly
         *      ** In the other classes of same assembly
         * 5. Protected Internal -> accessible in
         *      ** In the same class
         *      ** In the child classes of same assembly
         *      ** In the child classes of other assembly
         *      ** In the Other classes of Same Assembly
         * 6. Public -> accessible in all the 5 locations
         */


        public void ModifiersMainMethod()
        {
            // Protected filed with in child class of different assembly
            DomesticProduct domobj = new DomesticProduct();
            // Since Id is protected, you can't directly set it here
            // Solution: Use a method or property in DomesticProducts to set it and here write a method by passing object and value
            SetProtectedFieldValue(domobj, 10);
            domobj.getProtectedField();

            InternationProducts inobj = new InternationProducts();
            SetProtectedFieldValueOtherAssembly(inobj, 11);
            inobj.getProtectedFieldInOtherAssembly();

            // Private Protected
            domobj.setPrivateProtectedFiledId(100);

            // Internal 
            domobj.setInternalFiledId(20); // child class of same assembly
            IndependentClass1 obj1 = new IndependentClass1(); // other class of same assembly
            obj1.setFieldValues();

            // Protected Internal
            domobj.setProtectedInternalFiledId(211); // child class of same assembly
            obj1.setFieldValues(); // other class of same assembly
            inobj.setProtectedInternalFieldId(21); // child class at other assembly
        }

        public void SetProtectedFieldValue(DomesticProduct product, int id)
        {
            product.setProtectedFieldId(id);
        }

        public void SetProtectedFieldValueOtherAssembly(InternationProducts prd, int id)
        {
            prd.setProtectedFieldInOtherAssembly(id);
        }


    }

    public class InternationProducts : ProductsFields  // child class at Other assembly
    {

        public void setProtectedFieldInOtherAssembly(int id)
        {
            this.protectedFieldId = id;
        }

        public void getProtectedFieldInOtherAssembly()
        {
            
            Console.WriteLine("Protected Field Value in Child class in different Assembly = "+this.protectedFieldId);
        }

        public void setProtectedInternalFieldId(int id)
        {
            this.protectedInternalFieldId = id;
            Console.WriteLine("Protected Field Value in Child class in different Assembly = " + this.protectedInternalFieldId);
        }
    }

    public class IndependentClass2  // Other class at other assembly
    {
        public void SetFieldValues()
        {
            //DomesticProduct prd = new DomesticProduct();
            // prd.protectedFieldId = 11;  // you cannot access as it is protected Filed
            // Console.WriteLine(prd.protectedFieldId);  // you cannot access as it is protected Filed

            // prd.privateProtectedFieldId = 101;  // you cannot access as it is private protected Filed
        }
    }
}
