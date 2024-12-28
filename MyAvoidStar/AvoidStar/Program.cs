using AvoidStar;

namespace KDH
{
    class Program
    {
        static void Main(string[] args)
        {
            // 다음은 콘솔 창에 Hello World를 뛰우는 코드입니다.
            // Console.WriteLine("Hello, World!");
            Study.MyProgram.Play();

            // 게임 시작
            // 타이틀 변경
            //Console.Title = "별 피하기";
            // 콘솔 크기를 변경
            //Console.SetWindowSize(30, 30);
            // 콘솔창의 가장 아래에 중앙에 O 그려줘
            // -> 콘솔의 X좌표 14, Y좌표 28에 그려줘
            //Console.SetCursorPosition(14, 28);
            //Console.Write("●");
            // 콘솔 커서를 안보이게 해줘 
            //Console.CursorVisible = false;

            //Console.ReadKey();
        }
    }
}

namespace Study
{
    class MyProgram
    {
        public static void Play()
        {
            // 게임 시작
            // 타이틀 변경
            Console.Title = "별 피하기";
            // 콘솔 크기를 변경
            Console.SetWindowSize(30, 30);
            // 콘솔창의 가장 아래에 중앙에 O 그려줘
            // -> 콘솔의 X좌표 14, Y좌표 28에 그려줘
            Console.SetCursorPosition(14, 28);
            Console.Write("●");
            // 콘솔 커서를 안보이게 해줘 
            Console.CursorVisible = false;

            // 몬스터의 수
            int enemyCount = 30;

            int x = 14, y = 28; // 플레이어의 시작 위치
            bool playerDead = false;
            // 별의 속성 값( 어디에 위치하는가, 살아 있는가?)
            EnemyStar[] enemyStar = new EnemyStar[enemyCount];
            for(int i=0; i<enemyCount; i++)
            {
                enemyStar[i] = new EnemyStar();
            }

            Random random = new Random();

            while(true)
            {
                Console.Clear();
                Console.SetCursorPosition(x, y);
                // 플레이어의 위치를 그린다.
                Console.Write("●");

                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    Console.SetCursorPosition(x, y);
                    Console.Write("  ");
                    // 플레이어의 좌표를 변경한다.
                    if(key == ConsoleKey.UpArrow)
                    {
                        y--;
                        if (y < 0) y = 0;
                    }

                    // 아래 이동
                    if (key == ConsoleKey.DownArrow)
                    {
                        y++;
                        if (y > 28) y = 28;
                    }
                    // 왼쪽 이동

                    if(key == ConsoleKey.LeftArrow)
                    {
                        x--;
                        if (x < 0) x = 0;
                    }

                    if(key == ConsoleKey.RightArrow)
                    {
                        x++;
                        if (x > 28) x = 28;
                    }

                    // 오른쪽 이동
                }

                // 몬스터를 한번에 관리하는 코드
                for(int i =0; i < enemyCount; i++)
                {
                    if (!enemyStar[i].isAlive)
                    {
                        // 어떤 enemy true 만들까

                        enemyStar[i].isAlive = true;
                        enemyStar[i].posY = 0;
                        enemyStar[i].posX = random.Next(0, 28);
                    }
                    Console.SetCursorPosition(enemyStar[i].posX, enemyStar[i].posY);
                    Console.Write("★");

                    if (enemyStar[i].isAlive)
                    {
                        enemyStar[i].posY = enemyStar[i].posY + 1; // 
                    }

                    // 조건
                    // 플레이어가 언제 죽나요?
                    // 별이랑 충돌했을 때 죽습니다.
                    // ex,x ey,y 동일할 때
                    if (x == enemyStar[i].posX && y == enemyStar[i].posY)
                    {
                        playerDead = true;
                    }

                    if (enemyStar[i].posY >= 28)
                    {
                        enemyStar[i].isAlive = false;
                        enemyStar[i].posY = 0;
                        enemyStar[i].posX = random.Next(0, 28);
                    }
                }

                if(playerDead == true)
                {
                    Console.SetCursorPosition(0, 15);
                    Console.WriteLine("아무 키를 입력하면 게임이 재시작됩니다.");

                    Console.ReadKey();
                    Play();
                    break;
                }

                Thread.Sleep(100);
            }

           

        }
    }
}
