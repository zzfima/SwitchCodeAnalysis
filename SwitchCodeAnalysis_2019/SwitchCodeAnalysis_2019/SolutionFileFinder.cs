using System.IO;
using System.Linq;

namespace SwitchCodeAnalysis_2019
{
    public class SolutionFileFinder
    {
        public static string FindClosestSolution()
        {
            var directory = new DirectoryInfo(Directory.GetCurrentDirectory());
            while (directory != null && !directory.GetFiles("*.sln").Any())
            {
                directory = directory.Parent;
            }

            var fileInfos = directory.GetFiles("*.sln");

            if (fileInfos != null && fileInfos.Length > 0)
                return fileInfos[0].FullName;

            return null;
        }
    }
}
