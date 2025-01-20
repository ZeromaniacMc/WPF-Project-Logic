using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Project_Logic.Cards.Common
{
    internal class Note {

        /// <summary>
        /// <param name="noteTitle"> The title of the note as string. </param>
        /// </summary>
        private string noteTitle;
        /// <summary>
        /// <param name="noteContent"> The content of the note as string. </param>
        /// </summary>
        private string noteContent;


        public string Title
        {
            get { return noteTitle; }
            set { noteTitle = value; }
        }

        public string Content
        {
            get { return noteContent; }
            set { noteContent = value; }
        }

        /// <summary>
        /// Constructor for the Note class
        /// </summary>
        /// <param name="title"> The title of the note as string. </param>
        /// <param name="content"> The content of the note as string. </param>
        public Note(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}
