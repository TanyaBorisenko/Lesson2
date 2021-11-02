using System.Collections.Generic;

namespace Lesson2.Generator
{
    public interface IReportGenerator
    {
        public void SortUsers<T>(ref List<T> entities) where T : User;
    }
}