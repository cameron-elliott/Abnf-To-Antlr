﻿/*

    Copyright 2020 Robert Pinchbeck
  
    This file is part of AbnfToAntlr.

    AbnfToAntlr is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    AbnfToAntlr is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with AbnfToAntlr.  If not, see <http://www.gnu.org/licenses/>.

*/

using Antlr.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbnfToAntlr.Common
{
    public class TranslationException : Exception
    {
        public List<RecognitionException> ParserRecognitionExceptions = new List<RecognitionException>();
        public List<RecognitionException> LexerRecognitionExceptions = new List<RecognitionException>();

        public TranslationException(string message, List<RecognitionException> parserRecognitionExceptions, List<RecognitionException> lexerRecognitionExceptions)
            : base(message)
        {
            ParserRecognitionExceptions = parserRecognitionExceptions;
            LexerRecognitionExceptions = lexerRecognitionExceptions;
        }
    }
}
