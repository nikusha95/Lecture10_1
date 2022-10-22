namespace Generics;

public class GenericArray<T> //where T : class T can only be class type
{
    private T[] _array;
    private int _size;

    public GenericArray(int size)
    {
        _size = size;
        _array = new T[size];
    }

    /// <summary>
    /// get element in array
    /// </summary>
    /// <param name="index">element to find</param>
    /// <returns>element at index, if index was ouf of boundaries should return -1</returns>
    public T GetElement(int index)
    {
        if (index != _size)
        {
            return _array[index];
        }

        return _array[_size - 1];
    }

    public void AddElement(T element, int index)
    {
        if (index != _size)
        {
            _array[index] = element;
        }
    }
}