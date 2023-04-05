using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
	public class MyQueue<T>
	{
		private List<T> _items = new List<T>();

		public int Count
		{
			get { return _items.Count; }
		}

		public T GetItem(int pos)
		{
			return _items[pos];
		}

		public List<T> Enqueue(T item)
		{
			_items.Add(item);
			return _items;
		}
		// 1, 2, 3, n

		public T Dequeue()
		{
			if (_items.Count == 0)
			{
				return new T();
			}

			var i = _items[0];
			_items.RemoveAt(0);
			return i;
		}
	}
}
