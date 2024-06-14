namespace Bowling_tql3;

internal class Program {
    static void Main(string[] args) {
       
        List<int> scores = new List<int>();

        // capture all the frame scores
        for(int frame = 1; frame <= 10; frame++) {

            Console.Write($"Enter score for frame {frame} : ");
            var response = Console.ReadLine();
            var frameScore = Convert.ToInt32(response);
            scores.Add(frameScore);

        }

        var sum = 0;
        foreach(var score in scores ) {
            sum += score;
        }
        // sum = scores.Sum();

        Console.WriteLine($"Game score is {sum}");

    }
}
