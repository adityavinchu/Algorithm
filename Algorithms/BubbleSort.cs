namespace Algorithms
{
    public class BubbleSort
    {
        public void Sort(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                bool pass = false;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i].CompareTo(array[j]) > 0)
                    {
                        pass = true;
                        string temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
                if (!pass) return;
            }
        }
    }
}