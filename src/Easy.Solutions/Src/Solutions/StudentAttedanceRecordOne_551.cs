namespace Easy.Solutions.Src.Solutions
{
    public class StudentAttedanceRecordOne_551
    {
        /*
         * 
         * You are given a string s representing an attendance record for a student where each character signifies whether the student was absent, late, or present on that day. The record only contains the following three characters:

          'A': Absent.
          'L': Late.
          'P': Present.
          The student is eligible for an attendance award if they meet both of the following criteria:

          The student was absent ('A') for strictly fewer than 2 days total.
          The student was never late ('L') for 3 or more consecutive days.
          Return true if the student is eligible for an attendance award, or false otherwise.
         * 
         * 
         */


        public bool CheckRecord(string s)
        {
            var lateCount = 0;
            var absentCount = 0;
            for (var i = 0; i < s.Length; i++)
            {
                if (lateCount == 2 && s[i] == 'L') return false;
                if (absentCount == 1 && s[i] == 'A') return false;
                if (s[i] == 'A')
                {
                    absentCount++;
                    lateCount = 0;
                }
                if (s[i] == 'L') lateCount++;
                if (s[i] == 'P') lateCount = 0;
            }
            return true;
        }
    }
}
