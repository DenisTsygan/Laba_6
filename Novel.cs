using System;

namespace Laba_6
{
    public class Novel : Book
    {
        private readonly uint MAX_COUNT_CHAPTERS = 100;
        private string _comment;
        private uint _countChapters;
        private bool _isReleased;

        public Novel(string title, uint pageCount,uint countChapters,bool isReleased, string comment="Not comment is here") : base(title, pageCount)
        {
            Comment = comment;
            CountChapters = countChapters;
            IsReleased = isReleased;
        }
        /// <summary>
        /// return ArgumentNullException - if value null or empty string 
        /// </summary>
        private string Comment
        {
            get => _comment;
            set
            {
                _comment = !string.IsNullOrEmpty(value) ? value.Trim() :
                    throw new ArgumentNullException("Field Comment cannot be empty or null");
            }
        }
        /// <summary>
        /// return ArgumentOutOfRangeException - if value more then MAX_COUNT_CHAPTERS
        /// </summary>
        private uint CountChapters
        {
            get => _countChapters;
            set
            {
                _countChapters = value < MAX_COUNT_CHAPTERS ? value :
                throw new ArgumentOutOfRangeException($"Field CountChapters cannot be more" +
                $" then MAX_COUNT_CHAPTERS({MAX_COUNT_CHAPTERS})");
            }
        }
        private bool IsReleased
        {
            get => _isReleased;
            set => _isReleased = value;
        }
        public override string ToString()
        {
            string isReleased = IsReleased ? "" : "not ";
            return base.ToString()+ $"\n'Novel' was'{isReleased}realesed\nComment:'{Comment}'\nCount of chapters:'{CountChapters}' " ;
        }
    }
}
