using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Basic_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scope 범위 : 공간 ~ 공간 표현
            // 범위가 누구의 범위인가?

            int number = 30;
            Console.WriteLine(number);

            number = ScopeFunc(number, 50);
            Console.WriteLine(number);
            // 배열
            // 자료형 복수로 표현하는 방법이 없을까?

            int[] numbers = new int[5];

            // 5명 성적의 더한 값을 구하는 기능을 만들고 싶다.
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            int result = numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4];

            // 0번 부터 배열의 크기 - 1 [변수] 

            float[] times = new float[5];

            times[0] = 1.0f;
            times[1] = 2.0f;

            // 별피하기 게임, 별 1개만 떨어지죠.
            // Ex, Ey 배열로 표현할려면 어떻게 해야하는가?

            int[] Ex = new int[20];
            int[] Ey = new int[20];

            Ex[2] = 3;
            Ey[2] = 3;

            // 3번째 별의 Ex의 값 Ey의 값을 배열로 출력해보세요.

            Console.WriteLine(result);

            // for 반복문
            LoopFor();
            // while 반복문
            LoopWhile();


        }

        private static int ScopeFunc(int number, int modify)
        {            
             //int number = 20;                // number int 데이터형 변수 선언 20 대입한다.
             number = number + modify;         // number변수를 찾아서 그 변수에 20을 대입한다.

            return number;
        }

        private static void LoopFor()
        {
            int[] numbers = {1,2,3,4,5};
            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }

            Console.WriteLine($"for반복문 결과 : {result}");
        }

        private static void LoopWhile()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int result = 0;
            int i = 0;

            while (true)
            {
                result += numbers[i];
                i++;


                if( i >= numbers.Length)
                {
                    break;
                }
            }
            Console.WriteLine($"while반복문 결과 : {result}");
        }

    }
}
