using System;

namespace Laba_6
{
    public class Poem : Book
    {
        private string _addresses;
        private string _genre;
        private bool _isRhyme;

        public Poem(string title, uint pageCount,string genre , bool isRhyme, string addresses="Unknown") : base(title, pageCount)
        {
            Addresses = addresses;
            Genre = genre;
            IsRhyme = isRhyme;
        }
        /// <summary>
        /// return ArgumentNullException - if value null or empty string 
        /// </summary>
        private string Addresses
        {
            get => _addresses;
            set
            {
                _addresses = !string.IsNullOrEmpty(value) ? value.Trim() :
                    throw new ArgumentNullException("Field Addresses cannot be empty or null");
            }
        }
        /// <summary>
        /// return ArgumentNullException - if value null or empty string 
        /// </summary>
        private string Genre
        {
            get => _genre;
            set
            {
                _genre = !string.IsNullOrEmpty(value) ? value.Trim() :
                    throw new ArgumentNullException("Field Genre cannot be empty or null");
            }
        }
        private bool IsRhyme
        {
            get => _isRhyme;
            set => _isRhyme = value;
        }
        public override string ToString()
        {
            string isRhyme = IsRhyme ? "" : "no";
            return base.ToString()+$"\n'Poem' has '{isRhyme} rhyme' ,was addresse:'{Addresses}' \nGenre:'{Genre}'";
        }
    }
}
