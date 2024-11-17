using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Public_Class_Demo_ClassLibraries
{
    public class ProductsFields
    {
        // these are Fields of class
        public int productId;

        public string productName;

        public double productCost;

        public int productStock;

        private int privateFieldId;

        protected int protectedFieldId;

        private protected int privateProtectedFieldId;

        internal int internalFieldId;

        protected internal int protectedInternalFieldId;
    }

    
    public class DomesticProduct : ProductsFields  // child class of in the same assembly
    {

        public void getPrivateFiled()
        {
            //Console.WriteLine(this.privateFieldId); // gives error because filed is private
        }

        // Since Id is protected, you can't directly set it in other assembly
        // Solution: Use a method or property in DomesticProducts to set it
        public void setProtectedFieldId(int id)
        {
            this.protectedFieldId = id;
        }

        public void getProtectedField()
        {
            Console.WriteLine("Protected Field Id value in the child class of same assembly = "+this.protectedFieldId);  // accessible with in child class of same assembly
        }

        public void setPrivateProtectedFiledId(int id)
        {
            this.privateProtectedFieldId = id;
            Console.WriteLine("Private Protected Field Id in the child class of same assembly = " + this.privateProtectedFieldId);
        }

        public void setInternalFiledId(int id)
        {
            this.internalFieldId = id;
            Console.WriteLine("Internal Field Id in child class of same assembly= " + this.internalFieldId);
        }

        public void setProtectedInternalFiledId(int id)
        {
            this.protectedInternalFieldId = id;
            Console.WriteLine("Protected Internal Field Id in child class of same assembly= " + this.internalFieldId);
        }
    }

    public class IndependentClass1 // Other class of in the same assembly
    {
        public void setFieldValues()
        {
            //DomesticProduct prd = new DomesticProduct();
            //prd.protecedFieldId = 10;  // you cannot access as it is protected Filed
            //Console.WriteLine(prd.protectedFieldId); // you cannot access as it is protected Filed

            // prd.privateProtectedFieldId = 101;  / you cannot access as it is private protected Filed

            // Other class of same assembly --  internal is accessible
            ProductsFields prd = new ProductsFields();
            prd.internalFieldId = 201;
            Console.WriteLine("Internal Filed Id in other class of same assembly= " + prd.internalFieldId);

            prd.protectedInternalFieldId = 201;
            Console.WriteLine("Proteced Internal Field Id in other class of same assembly= " + prd.internalFieldId);
        }
    }
    
}
