namespace Access_Specifier
{
    // access specifier
    public class Program
    {

        static void Main(string[] args)
        {
            Base B = new Base();
        }

    }

    public class Base {

        int i;// default access specifier to the
              // any membre of the class is private

        public int PUBLIC;
        private int PRIVATE;
        protected int PROTECTED;
        internal int INTERNAL;
        protected internal int PROTECTEDiNTERNAL;
        private protected int PRIVATEPRTECTED;

        // public: Access Anywhere;
        // private: within the class;
        // protected: Access within and derived class;
        // internal: Access same class, same assembly(same project);
        // protected internal: Accesss same class, derived class,same assembly;
        // private protected: same class, derived class, that is the same assembly;
    }


}
