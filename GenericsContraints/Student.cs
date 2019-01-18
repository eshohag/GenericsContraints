namespace GenericsContraints
{
    class Student : CommonFeature<Student>
    {
        public int Id { get; set; }
        public string StudentFullName { get; set; }
    }
}