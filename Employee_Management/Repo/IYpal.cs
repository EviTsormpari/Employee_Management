using Employee_Management.Models;

namespace Employee_Management.Repo
{
    public interface IYpal
    {
        public IEnumerable<Ypal> GetAllYpal();
        public Ypal GetYpal(String id);

        public void CreateYpal(Ypal ypal);
    }
}
