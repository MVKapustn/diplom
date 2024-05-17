namespace AdditionalLibrary.Classes
{
    public static class BaseTestHelper
    {
        private static bool[] lowDifficult = new bool[5];
        private static bool[] medDifficult = new bool[7];
        private static bool[] highDifficult = new bool[10];        

        public static void SaveAnswer(PagesHelper.Skill questionDifficult, int questionNumber, bool answer)
        {
            questionNumber--;
            switch (questionDifficult)
            {
                case PagesHelper.Skill.Low:
                    lowDifficult[questionNumber] = answer;
                    break;
                case PagesHelper.Skill.Medium:
                    medDifficult[questionNumber] = answer;
                    break;
                case PagesHelper.Skill.High:
                    highDifficult[questionNumber] = answer;
                    break;
            }
        }
        public static (int, int) GetResults(PagesHelper.Skill difficult)
        {
            int totalQuestionsCount = default;
            int correctQuestionsCount = default;
            switch (difficult)
            {
                case PagesHelper.Skill.Low:
                    totalQuestionsCount = lowDifficult.Length;
                    correctQuestionsCount = lowDifficult.Where(x => x == true).Count();
                    break;
                case PagesHelper.Skill.Medium:
                    totalQuestionsCount = medDifficult.Length;
                    correctQuestionsCount = medDifficult.Where(x => x == true).Count();
                    break;
                case PagesHelper.Skill.High:
                    totalQuestionsCount = highDifficult.Length;
                    correctQuestionsCount = highDifficult.Where(x => x == true).Count();
                    break;
            }

            return (correctQuestionsCount, totalQuestionsCount);
        }
    }
}
