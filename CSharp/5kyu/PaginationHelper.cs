using System.Linq;
using System;
using System.Collections.Generic;

namespace CSharp._5kyu
{
    public class PagnationHelper<T>
    {
        private readonly int _itemsPerPage;
        private readonly int _itemCount;
        private readonly int _pageCount;

        /// <summary>
        /// Constructor, takes in a list of items and the number of items that fit within a single page
        /// </summary>
        /// <param name="collection">A list of items</param>
        /// <param name="itemsPerPage">The number of items that fit within a single page</param>
        public PagnationHelper(IList<T> collection, int itemsPerPage)
        {
            _itemsPerPage = itemsPerPage;
            if (collection == null || collection.Count() == 0 || itemsPerPage <= 0)
            {
                _itemCount = 0;
                _pageCount = 0;
            }
            else
            {
                _itemCount = collection.Count();

                int partialPage = 0;
                if ((_itemCount % itemsPerPage != 0)) partialPage = 1;

                _pageCount = _itemCount / itemsPerPage + partialPage;
            }
        }

        /// <summary>
        /// The number of items within the collection
        /// </summary>
        public int ItemCount
        {
            get
            {
                return _itemCount;
            }
        }

        /// <summary>
        /// The number of pages
        /// </summary>
        public int PageCount
        {
            get
            {
                return _pageCount;
            }
        }

        /// <summary>
        /// Returns the number of items in the page at the given page index 
        /// </summary>
        /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
        /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
        public int PageItemCount(int pageIndex)
        {
            if (pageIndex < 0 || pageIndex >= PageCount) return -1;

            if (pageIndex == PageCount - 1) return ItemCount - (_itemsPerPage * pageIndex);

            return _itemsPerPage;
        }

        /// <summary>
        /// Returns the page index of the page containing the item at the given item index.
        /// </summary>
        /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
        /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
        public int PageIndex(int itemIndex)
        {
            if (itemIndex < 0 || itemIndex >= ItemCount) return -1;

            var result = itemIndex / _itemsPerPage;

            return result;
        }
    }
}