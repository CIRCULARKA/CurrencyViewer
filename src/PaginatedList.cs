using System;
using System.Linq;
using System.Collections.Generic;

namespace CryptocurrenciesViewer
{
	public class PaginatedList<T> : List<T>
	{
		public PaginatedList(List<T> list, int pageIndex, int pageSize)
		{
			CurrentPageIndex = pageIndex;
			TotalPages = (int)Math.Ceiling(list.Count / (double)pageSize);

			AddRange(list);
		}

		public int CurrentPageIndex { get; private set; }

		public int TotalPages { get; private set; }

		public bool IsPrevPageAvailable =>
			CurrentPageIndex > 1;

		public bool IsNextPageAvailable =>
			CurrentPageIndex < TotalPages;

		public PaginatedList<T> Create(IQueryable<T> source, int pageIndex, int pageSize) =>
			new PaginatedList<T>(
				source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList(),
				pageIndex,
				pageSize
			);
	}
}