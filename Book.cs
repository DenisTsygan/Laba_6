using System;

namespace Laba_6
{
    public abstract class Book:IBook
    {
        private readonly uint MAX_COUNT_PAGE = 21451;
        private readonly string _title;
        private bool _isOpen = false;
        private readonly uint _pageCount;

        protected Book(string title,uint pageCount)
        {
            Title = title;
            PageCount = pageCount;
        }
        /// <summary>
        /// return ArgumentNullException - if value null or empty string 
        /// </summary>
        private string Title
        {
            get => _title;
            init
            {
                _title = !string.IsNullOrEmpty(value) ? value.Trim() :
                    throw new ArgumentNullException("Field Title cannot be empty or null");
            }
        }
        private bool IsOpen
        {
            get => _isOpen;
            set => _isOpen = value;
        }
        /// <summary>
        /// return ArgumentOutOfRangeException - if value more then MAX_COUNT_PAGE
        /// </summary>
        private uint PageCount
        {
            get => _pageCount;
            init
            {
                _pageCount = value < MAX_COUNT_PAGE ? value :
                throw new ArgumentOutOfRangeException($"Field PageCount cannot be more" +
                $" then MAX_COUNT_PAGE({MAX_COUNT_PAGE})");
            }
        }
        /// <summary>
        /// changes field _isOpen on false
        /// </summary>
        public void CloseBook()
        {
            if (IsOpen)
            {
                IsOpen = false;
            }
        }
        /// <summary>
        /// changes field _isOpen on true
        /// </summary>
        public void OpenBook()
        {
            if (!IsOpen)
            {
                IsOpen = true;
            }
        }

        public override string ToString()
        {
            string statusBook = IsOpen ? "open" : "close";
            return  $"Title :'{Title}'\nPage count :'{PageCount}'\nStatus  :'{statusBook}'";
        }
    }
}
