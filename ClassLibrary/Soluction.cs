namespace ClassLibrary;

public class Solution
{
    public int solution(int[] A)
    {
        int N = A.Length;
        if (N < 3) return 0;

        List<int> peaks = new List<int>();
        for (int i = 1; i < N - 1; i++)
        {
            if (A[i] > A[i - 1] && A[i] > A[i + 1])
            {
                peaks.Add(i);
            }
        }
        if(peaks.Count==0) return 0;
        int maxFlag=1;
        int totalFlag=peaks.Count;
        for (int k = 2; k <=totalFlag; k++)
        {
            int usedFlag=1;
            int lastPosition=peaks[0];
            for (int i = 1; i < totalFlag; i++)
            {
                if(peaks[i]-lastPosition>=k){
                    usedFlag++;
                    lastPosition=peaks[i];
                    if(usedFlag==k) break;
                }
            }
            if(usedFlag>=k){
                maxFlag=k;
            }else{
                break;
            }
        }
        return maxFlag;
    }
}
