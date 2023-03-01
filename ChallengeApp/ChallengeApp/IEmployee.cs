namespace ChallengeApp
{
    public interface IEmployee

    {
        string Name { get; }
        string Surname { get; }
        string Position { get; }

        Statistics GetStatistics();
        void AddGrade(float grade);
        void AddGrade(string grade);
        void AddGrade(char grade);
    }
}
