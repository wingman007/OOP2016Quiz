﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kursovProekt.Models
{
    public class Choice
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public bool IsAnswer { get; set; }
        private Question _question = new Question();
        public bool IsSelected { get; set; }

        public Question Question
        {
            get { return _question; }
            set { _question = value; }
        }

    }
}