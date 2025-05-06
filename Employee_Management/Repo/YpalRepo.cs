using Employee_Management.Models;

namespace Employee_Management.Repo
{
    public class YpalRepo : IYpal
    {
        private List<Ypal> ypals;

        public YpalRepo()
        {
            ypals = new() { new Ypal { YpalID = "first", YpalName = "Test", YpalEmail = "test@gmal.com" } };
        }

        public void CreateYpal(Ypal ypal)
        {
            ypals.Add(ypal);
        }

        public IEnumerable<Ypal> GetAllYpal()
        {
            return ypals;
        }

        public Ypal GetYpal(string id)
        {
            var yp = ypals.Where(x=> x.YpalID == id).SingleOrDefault();
            return yp;
        }
    }
}
