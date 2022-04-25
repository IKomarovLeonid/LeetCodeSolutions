namespace Easy.Solutions.Solutions
{
    public class MaximizeDistanceToClosestPerson_849
    {
                /*
                In a row of seats, 1 represents a person sitting in that seat, and 0 represents that the seat is empty. 
                There is at least one empty seat, and at least one person sitting.
                Alex wants to sit in the seat such that the distance between him and the closest person to him is maximized. 
                Return that maximum distance to closest person.
                */

        public int MaxDistToClosest(int[] seats)
        {
            int maxDistance = 0;
            for (int index = 0; index < seats.Length; index++)
            {
                if (seats[index] == 0)
                {
                    maxDistance++;
                }
                else
                {
                    int k = index + 1;
                    int leftIndex = index;
                    while (k < seats.Length && seats[k] != 1)
                    {
                        k++;
                        if (k == seats.Length)
                        {
                            int resultDistance = (k - 1 - leftIndex);
                            if (resultDistance > maxDistance) return resultDistance;
                        }
                    }

                    int distance = (k - index) / 2;
                    if (distance > maxDistance)
                    {
                        maxDistance = distance;
                    }

                    index = k - 1;
                }
            }

            return maxDistance;

        }
    }
}
