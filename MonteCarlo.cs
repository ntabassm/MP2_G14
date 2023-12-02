
public class MonteCarloSimulation
{
    /// <summary>
    /// Estimates and returns the percolation probability using the Monte Carlo method
    /// </summary>
    /// <param name="dimension">the grid dimension (each sides of a square two-dimensional grid)</param>
    /// <param name="probability">probability of vacancy</param>
    /// <param name="numOfTrials">number of simulation/trials</param>
    /// <returns>the estimated percolation probability</returns>
    public static double Estimate(int dimension, double probability, int numOfTrials)
    {
        int numOfPerco = 0;
        static int opensites(bool[,] randomGrid)
        {
            int opencount = 0;
            int dimension = randomGrid.Length;

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    if (randomGrid[i, j])
                    {
                        opencount++;
                    }
                }
            }
            return opencount;
        }

        for (int i = 0; i < numOfTrials; i++)
        {
            bool[,] randomGrid = RandomGridGenerator.Generate(dimension, probability);
            int open = opensites(randomGrid);
            if (Percolation.IsPercolating(randomGrid))
            {
                numOfPerco++;
            }
        }
        double estimate = (double)numOfPerco / numOfTrials;
        return estimate;
    }
}
