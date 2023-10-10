using System;

namespace Laba_6
{
    public class Storytelling : Book
    {
        private readonly DateTime _dateOfStory;
        private string _mainCharacter;
        private bool _isRealStory;
        public Storytelling(string title, uint pageCount,DateTime dateOfStory,bool isRealStory, string mainCharacter = "Unknown") : base(title, pageCount)
        {
            DateOfStory = dateOfStory;
            MainCharacter = mainCharacter;
            IsRealStory = isRealStory;
        }
        /// <summary>
        /// return ArgumentException - if date(value) less than current date 
        /// </summary>
        private DateTime DateOfStory
        {
            get => _dateOfStory;
            init
            {
                DateTime dateTimeNow = DateTime.Now;
                if (value < DateTime.Now)
                {
                    _dateOfStory = value;
                }
                else
                {
                    throw new ArgumentException($"Date:'{value}' cannot be more then Date Now:'{dateTimeNow}'");
                }

            }

        }
        /// <summary> 
        /// return ArgumentNullException - if value null or empty string 
        /// </summary>
        private string MainCharacter
        {
            get => _mainCharacter;
            set
            {
                _mainCharacter = !string.IsNullOrEmpty(value) ? value.Trim() :
                    throw new ArgumentNullException("Field MainCharacter cannot be empty or null");
            }
        }
        private bool IsRealStory
        {
            get => _isRealStory;
            set => _isRealStory = value;
        }
        public override string ToString()
        {
            string isRealStory = IsRealStory ? "Real" : "Fake";
            return base.ToString() + $"\n'Storytelling'\n'{isRealStory}' story was:'{DateOfStory}' by '{MainCharacter}' ";
        }
    }
}
