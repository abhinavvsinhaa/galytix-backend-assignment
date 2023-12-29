using System;
namespace Galytix.Services
{
	public interface ICSVService
	{
        public IEnumerable<T> ReadCSV<T>();
    }
}

