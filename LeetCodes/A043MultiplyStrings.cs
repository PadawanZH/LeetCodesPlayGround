using System.Text;

namespace LeetCodes
{
    public class A043MultiplyStrings
    {
        public string Multiply(string num1, string num2) {
            int[] numberic = new int[num1.Length + num2.Length];
            for (int i = 0; i < numberic.Length; i++)
            {
                numberic[i] = 0;
            }

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                for (int j = num2.Length - 1; j >= 0; j--)
                {
                    int p1 = i + j, p2 = i + j + 1;
                    int sum = (num1[i] - '0') * (num2[j] - '0') + numberic[p2];

                    numberic[p2] = sum % 10;
                    numberic[p1] += sum / 10; //This += is important
                }
            }
            
            StringBuilder sb = new StringBuilder();
            foreach (var num in numberic)
            {
                if (sb.Length != 0 || num != 0) sb.Append(num.ToString());
            }

            return sb.Length == 0 ? "0" : sb.ToString();
        }
    }
}