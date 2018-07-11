using System;
using System.Collections.Generic;
using System.ServiceModel.Dispatcher;

namespace TestService
{
    class MyService : IMyService
    {
        public string GetData()
        {
            return "this is the returnstring";
        }

        public string GetMessage(string Name)
        {
            return "Hallo " +Name;
        }

        public string GetResult(int Sid, string SName, int M1, int M2, int M3)
        {
            double Avg = (M1+M2+M3)/3.0;
            if (Avg < 35)
                return "Fail";
            else
            {
                return "Pass";
            }
        }

        public string GetResultS(Student S)
        {
            double Avg = (S.M1 + S.M2 + S.M3) / 3.0;
            if (Avg < 35)
                return "Fail";
            else
            {
                return "Pass";
            }
        }
        public double GetResultA(Student S)
        {
            double Avg = (S.M1 + S.M2 + S.M3) / 3.0;
            
                return Avg;
            
        }

        public int GetMax(int[] ar)
        {
            int Max = ar[0];
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > Max)
                {
                    Max = ar[i];
                }
            }

            return Max;
        }

        public int[] GetSorted(int[] ar)
        {
           Array.Sort(ar)  ;
            return ar;
        }

        public Student GetTopper(List<Student> LS)
        {
            double Temp, Maxi = 0.0;
            Student topper=null;
            foreach (var stuut in LS)
            {
                Temp=GetResultA(stuut);
                if (Temp> Maxi)
                {
                    Maxi = Temp;
                    topper = stuut;
                }
            }

            return topper;
        }
    }
}
