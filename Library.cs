using System;
using System.Text;

namespace Laba_6
{
    public class Library
    {
        private Book[] _elements;
        /// <summary>
        /// if the elements is null , initialize array _elements with zero length
        /// </summary>
        /// <param name="elements">elements successor to the Book class</param>
        public Library(params Book[] elements)
        {
            if (elements is not null)
            {
                _elements = elements;
            }
            else
            {
                _elements = new Book[0];
            }
        }
        /// <summary>
        /// adding the element to the end of the array _elements
        /// </summary>
        /// <param name="element">successor to the Book class</param>
        public void AddElement(Book element)
        {
            Array.Resize(ref _elements, _elements.Length + 1);
            _elements[_elements.Length - 1] = element;
        }
        /// <summary>
        /// removing an element from  array _elements by index(
        /// return ArgumentOutOfRangeException-if index is out of array)
        /// </summary>
        /// <param name="indexRemove">index of the element to be removed</param>
 
        public void RemoveElementByIndex(uint indexRemove)
        {
            if (indexRemove < _elements.Length)
            {
                Book[] newElements = new Book[_elements.Length - 1];
                for (int i = 0, j = 0; i < _elements.Length; i++)
                {
                    if (i != indexRemove)
                    {
                        newElements[j] = _elements[i];
                        j++;
                    }
                }
                _elements = newElements;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Index is out of array ");
            }

        }
        /// <summary>
        /// Update element by index (
        /// return ArgumentOutOfRangeException-if index is out of array)
        /// </summary>
        /// <param name="element"> updated element</param>
        /// <param name="indexUpdate">index updated element</param>
        public void UpdateElementByIndex(Book element, uint indexUpdate)
        {
            if (indexUpdate < _elements.Length)
            {
                _elements[indexUpdate] = element;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Index is out of array ");
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            foreach (Book element in _elements)
            {
                str.Append(element + "\n\n");
            }
            return str.ToString();
        }

    }
}
