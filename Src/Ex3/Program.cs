﻿using System;
using System.Collections.Generic;
using gpp.src;
using gpp.src.qanda;
using gpp.src.quizactions;

namespace gpp
{
    class Program
    {   
        /*
        static LoadFilePathFromConfigurationFile ConfigurationFileData = new LoadFilePathFromConfigurationFile();
        static string QuestionsFilePath = ConfigurationFileData.GetFilePath();

        static RetrieveQandAFromFile RetrieveData = new RetrieveQandAFromFile(QuestionsFilePath);
        static List<string> RawFileData = RetrieveData.GetRawFileData();

        static ProcessQuestions Questions = new ProcessQuestions(RawFileData);
        static ProcessAnswers Answers = new ProcessAnswers(RawFileData);
        static ProcessRightAnswer RightAnswers = new ProcessRightAnswer(RawFileData);


        static void Main(string[] args)
        {
            while(true)
            {
                int NumberOfQuestions = Questions.GetQuestions().Count;

                Quiz Quiz = new Quiz(Questions, Answers, RightAnswers);
                var CorrectAnswers = Quiz.GetCorrectAnswers();

                Percentage Percentage = new Percentage();
                int _Percentage = Percentage.CalculatePercentage(CorrectAnswers, NumberOfQuestions);

                QuizResults QuizResults = new QuizResults(_Percentage, CorrectAnswers.Count, NumberOfQuestions);
                
                Console.WriteLine(QuizResults.DisplayNumberOfQuestions());
                Console.WriteLine(QuizResults.DisplayNumberOfCorrectAnswers());
                Console.WriteLine(QuizResults.DisplayNumberOfErrors());
                Console.WriteLine(QuizResults.DisplayPercentage());
                Console.ReadLine();
            }
        } */
    }
}