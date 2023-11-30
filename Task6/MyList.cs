using System;
namespace Task6
{
	public class MyList<T>
	{
		internal T[] data;
		internal int size = 0;
		private int capacity;

		public MyList(int initialCapacity = 8)
		{
			if (initialCapacity < 1) initialCapacity = 1;
			this.capacity = initialCapacity;
			data = new T[initialCapacity];
		}
		
		public int Count
		{
			get { return size; }
		}
		
		public bool isEmpty
		{
			get { return size == 0; }
		}

		private void Resize()
		{
			T[] resized = new T[capacity * 2];
			for (int i = 0; i < capacity; i++)
			{
				resized[i] = data[i];
			}

			data = resized;
			capacity = capacity * 2;
		}

		public void Add(T newElement)
		{
			if (size == capacity)
			{
				Resize();
			}

			data[size] = newElement;
			size++;
		}

		public bool Contains(T value)
		{
			for (int i = 0; i < size; i++)
			{
				T currentValue = data[i];
				if (currentValue.Equals(value))
				{
					return true;
				}
			}
			return false;
		}

		public int IndexOf(T value)
		{
			for (int i = 0; i < size; i++)
			{
				T currentValue = data[i];
				var index = i;
				if (currentValue.Equals(value))
				{
					return index;
					
				}
			}

			return -1;
		}

		public void Remove(T value)
		{
			for (int i = 0; i < size; i++)
			{
				T currentValue = data[i];
				var index = i;
				if (currentValue.Equals(value))
				{
					RemoveAt(index);
				}
			}
		}

		public void RemoveAt(int index)
		{
			ThrowIfIndexOutOfRange(index);
			for (int i = index; i < size - 1; i++)
			{
				data[i] = data[i + 1];
			}

			data[size - 1] = default(T);
			size--;
		}

		public T GetAt(int index)
		{
			ThrowIfIndexOutOfRange(index);
			return data[index];
		}

		public void Clear()
		{
			data = new T[capacity];
			size = 0;
		}



		private void ThrowIfIndexOutOfRange(int index)
		{
			if (index > size - 1 || index < 0)
			{
				throw new ArgumentOutOfRangeException(string.Format("The current size of the array is {0}", size));
			} 
		}
		
	}
}

