using System;
using System.Collections.Generic;

namespace unityTestEx.Src.Ex2
{
    public class BreakPhraseIntoLinesAccordingToColumnLimit
    {
        private string Phrase;
        private List<string> ParsedPhrase = new List<string>();
        private int ColumnLimit;

        public BreakPhraseIntoLinesAccordingToColumnLimit(string _Phrase, int _ColumnLimit)
        {
            Phrase = _Phrase;
            ColumnLimit = _ColumnLimit;

            BrakePhrase();
        }

        public string GetBrokePhrase ()
        {
            return String.Join("", ParsedPhrase);
        }

        private void BrakePhrase()
        {         
            if(Phrase.Length <= ColumnLimit)
            {
                ParsedPhrase.Add(Phrase);
            }
            else
            {
                BreakLines();
            }
        }

        private void BreakLines()
        {
            char[] PhraseArray = Phrase.ToCharArray();
            int PhraseSize = PhraseArray.Length;
            int Count = 0;
            int DynamicColumnLimit = ColumnLimit;
            string TempString = "";
            int Index = 0;

            while (Count <= PhraseSize)
            {
                TempString = "";

                for (int i = 0; i < DynamicColumnLimit; i++)
                {
                    if 
                    (
                        i == DynamicColumnLimit 
                        && 
                        PhraseArray[i + Index].ToString() != " " 
                    )
                    {
                        DynamicColumnLimit = DynamicColumnLimit + 1;
                    }

                    TempString = TempString + PhraseArray[i + Index].ToString();
                    Count = Count + 1;
                    
                }

                Index = Count;

                ParsedPhrase.Add(TempString + "\n");
            }
        }
    }
}