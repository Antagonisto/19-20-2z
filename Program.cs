using static System.Convert;
using static System.Console;

namespace array
{
    class Program
    {
        // ����� ����� � ���������
        static void Main(string[] args)
        {
            // �������� ������
            Write("������� ����������� ���������: ");
            string s = ReadLine();
            Write("������� ������: ");
            char x = ToChar(ReadLine());
            string p = "������� �� ����� ������� ������������� �� �������� ������ {0}: {1}";
            // ������� �� ��������� ��� �����, ������� ������������� �� �������� ������
            string[] div = s.Split(' ', ',', '.', '-', '!', '?');
            for (int i = 0; i < div.Length; i++)
            {
                if (div[i].EndsWith(x.ToString()))
                {
                    WriteLine(p, x, div[i]);
                }
            }
            ReadKey();
        }
    }
}