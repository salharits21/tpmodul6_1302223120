using tpmodul6_1302223120;
public class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video = null;

        // Design Contract
        try
        {
            // Prekondisi
            video = new SayaTubeVideo("Tutorial Design By Contract - Faishal Harits Al Fajri");
            for (int i = 0; i < 10000000; i++)
            {
                video.IncreasePlayCount(1);
            }
        }
        // tes Exception
        catch (Exception tes)
        {
            Console.WriteLine("Error: " + tes.Message);
        }
        finally
        {
            // printoutput jika tidak terdeteksi error
            if (video != null)
            {
                video.PrintVideoDetails();
            }
        }
    }
}