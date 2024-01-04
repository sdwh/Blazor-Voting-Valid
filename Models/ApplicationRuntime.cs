namespace Blazor_Voting_Valid.Models
{
    public class ApplicationRuntime
    {
        public Question? CurrentQuestion { get; set; }
        public int CorrectCount { get; set; }
        public int FalseCount { get; set; }

        public bool Answer { get; set; } = false;
        public bool ThisRoundCorrect { get; set; } = false;

        public List<Question> Questinos { get; set; } = new List<Question>();

        public void NextQuestion()
        {
            var index = new Random().Next(Questinos.Count);
            CurrentQuestion = Questinos[index];
            Questinos.RemoveAt(index);
            Answer = false;
        }
    }
}
