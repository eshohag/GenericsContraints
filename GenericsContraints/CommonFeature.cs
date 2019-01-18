namespace GenericsContraints
{
    class CommonFeature<T> where T : class, new()
    {
        public T GetById(int id)
        {
            //Your operation
            return new T();
        }

        public T DeleteById(int id)
        {
            //Your Operation
            return new T();
        }

        public T GetInstance<T>() where T : class, new()
        {
            //Your Operation
            return new T();
        }
    }
}