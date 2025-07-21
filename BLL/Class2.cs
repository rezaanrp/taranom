namespace BLL
{
    public  class Class2
    {
        public string testwebservice()
        {

            ServiceReferenceTest.FirstWebServiceClient ss = new ServiceReferenceTest.FirstWebServiceClient();
            return ss.Message();
        }
    }
}
