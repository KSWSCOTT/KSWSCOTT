using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex0710
{
    class Program
    {
        static void Main(string[] args)
        {
            //char[] NO_tower = new char []{'*','b'};


            Console.WriteLine("1~5사이의 숫자를 입력하세요. 이 숫자가 클수록 당신의 머리는 아파지게 됩니다.");
            string prob_size;
            prob_size = Console.ReadLine();
            int prob_size_int_tmp = Convert.ToInt32(prob_size);
            int prob_size_int = prob_size_int_tmp + 4;

            string NO_tower = "            |            ";
            string tower_1 = "           *|*           ";
            string tower_2 = "          **|**          ";
            string tower_3 = "         ***|***         ";
            string tower_4 = "        ****|****        ";
            string tower_5 = "       *****|*****       ";
            string tower_6 = "      ******|******      ";
            string tower_7 = "     *******|*******     ";
            string tower_8 = "    ********|********    ";
            string[] TOWER = new string[9];
            TOWER[0] = NO_tower;
            TOWER[1] = tower_1;
            TOWER[2] = tower_2;
            TOWER[3] = tower_3;
            TOWER[4] = tower_4;
            TOWER[5] = tower_5;
            TOWER[6] = tower_6;
            TOWER[7] = tower_7;
            TOWER[8] = tower_8;

            string[] Tower_A = new string[prob_size_int];
            string[] Tower_B = new string[prob_size_int];
            string[] Tower_C = new string[prob_size_int];

            //////////////////////////////////
            //  Initial Tower Value
            for (int a = 0; a < prob_size_int; a++)
            {
                Tower_A[a] = TOWER[a];
            }

            for (int a = 0; a < prob_size_int; a++)
            {
                Tower_B[a] = TOWER[0];
            }

            for (int a = 0; a < prob_size_int; a++)
            {
                Tower_C[a] = TOWER[0];
            }

            for (int i = 0; i < prob_size_int; i++)
            {
                Console.Write(Tower_A[i]);
                Console.Write(Tower_B[i]);
                Console.WriteLine(Tower_C[i]);
            }
            //////////////////////////////////

            string input_key;

            while (true)
            {
                Console.WriteLine("당신이 지금 보고있는 것은 하노이 탑입니다.");
                Console.WriteLine("왼쪽부터 1,2,3번 타워이고 두 숫자를 공백없이 입력하게 되면 첫 번째 숫자의 타워의 링이 두 번째 숫자의 타워에 들어가게 됩니다.");
                Console.Write("입력");
                input_key = Console.ReadLine();
                int errorval = 0;
                if (input_key == "12")
                {
                    // 각 타워 어느 부분에 고리를 넣을지 정하는 부분
                    int firstval;
                    for (firstval = 0; firstval < prob_size_int; firstval++)
                    {
                        if (Tower_A[firstval] != NO_tower)
                        {
                            break;
                        }
                    }
                    int secondval;
                    int error_assist;
                    error_assist = 0;
                    for (secondval = 0; secondval < prob_size_int; secondval++)
                    {
                        if (Tower_B[secondval] != NO_tower)
                        {
                            break;
                        }
                    }
                    if (secondval == prob_size_int)
                    {
                        error_assist = 1;
                    }
                    //  errors
                    if (firstval == prob_size_int)
                    {
                        errorval = 1;
                        goto _escape;
                    }
                    //  
                    int iiF;
                    int iiS;
                    iiF = 0;
                    iiS = 0;
                    for (int ii = 0; ii < prob_size_int; ii++)
                    {
                        if (Tower_A[firstval] == TOWER[ii])
                        {
                            iiF = ii;
                        }
                        if (error_assist == 1)
                        {
                            goto _escape2;
                        }
                        if (Tower_B[secondval] == TOWER[ii])
                        {
                            iiS = ii;
                        }
                    }
                    _escape2:
                    if (iiS == 0)
                    {
                        goto _escape1;
                    }
                    if (iiF > iiS)
                    {
                        errorval = 1;
                        goto _escape;
                    }
                    _escape1:

                    string _temp;
                    _temp = Tower_A[firstval];
                    Tower_A[firstval] = Tower_B[secondval - 1];
                    Tower_B[secondval - 1] = _temp;

                    Console.Clear();

                    for (int i = 0; i < prob_size_int; i++)
                    {
                        Console.Write(Tower_A[i]);
                        Console.Write(Tower_B[i]);
                        Console.WriteLine(Tower_C[i]);
                    }
                }
                else if (input_key == "13")
                {
                    // 각 타워 어느 부분에 고리를 넣을지 정하는 부분
                    int firstval;
                    for (firstval = 0; firstval < prob_size_int; firstval++)
                    {
                        if (Tower_A[firstval] != NO_tower)
                        {
                            break;
                        }
                    }
                    int secondval;
                    int error_assist;
                    error_assist = 0;
                    for (secondval = 0; secondval < prob_size_int; secondval++)
                    {
                        if (Tower_C[secondval] != NO_tower)
                        {
                            break;
                        }
                    }
                    if (secondval == prob_size_int)
                    {
                        error_assist = 1;
                    }
                    //  errors
                    if (firstval == prob_size_int)
                    {
                        errorval = 1;
                        goto _escape;
                    }
                    //  
                    int iiF;
                    int iiS;
                    iiF = 0;
                    iiS = 0;
                    for (int ii = 0; ii < prob_size_int; ii++)
                    {
                        if (Tower_A[firstval] == TOWER[ii])
                        {
                            iiF = ii;
                        }
                        if (error_assist == 1)
                        {
                            goto _escape2;
                        }
                        if (Tower_C[secondval] == TOWER[ii])
                        {
                            iiS = ii;
                        }
                    }
                    _escape2:
                    if (iiS == 0)
                    {
                        goto _escape1;
                    }
                    if (iiF > iiS)
                    {
                        errorval = 1;
                        goto _escape;
                    }
                    _escape1:

                    string _temp;
                    _temp = Tower_A[firstval];
                    Tower_A[firstval] = Tower_C[secondval - 1];
                    Tower_C[secondval - 1] = _temp;

                    Console.Clear();

                    for (int i = 0; i < prob_size_int; i++)
                    {
                        Console.Write(Tower_A[i]);
                        Console.Write(Tower_B[i]);
                        Console.WriteLine(Tower_C[i]);
                    }
                }

                else if (input_key == "23")
                {
                    // 각 타워 어느 부분에 고리를 넣을지 정하는 부분
                    int firstval;
                    for (firstval = 0; firstval < prob_size_int; firstval++)
                    {
                        if (Tower_B[firstval] != NO_tower)
                        {
                            break;
                        }
                    }
                    int secondval;
                    int error_assist;
                    error_assist = 0;
                    for (secondval = 0; secondval < prob_size_int; secondval++)
                    {
                        if (Tower_C[secondval] != NO_tower)
                        {
                            break;
                        }
                    }
                    if (secondval == prob_size_int)
                    {
                        error_assist = 1;
                    }
                    //  errors
                    if (firstval == prob_size_int)
                    {
                        errorval = 1;
                        goto _escape;
                    }
                    //  
                    int iiF;
                    int iiS;
                    iiF = 0;
                    iiS = 0;
                    for (int ii = 0; ii < prob_size_int; ii++)
                    {
                        if (Tower_B[firstval] == TOWER[ii])
                        {
                            iiF = ii;
                        }
                        if (error_assist == 1)
                        {
                            goto _escape2;
                        }
                        if (Tower_C[secondval] == TOWER[ii])
                        {
                            iiS = ii;
                        }
                    }
                    _escape2:
                    if (iiS == 0)
                    {
                        goto _escape1;
                    }
                    if (iiF > iiS)
                    {
                        errorval = 1;
                        goto _escape;
                    }
                    _escape1:

                    string _temp;
                    _temp = Tower_B[firstval];
                    Tower_B[firstval] = Tower_C[secondval - 1];
                    Tower_C[secondval - 1] = _temp;

                    Console.Clear();

                    for (int i = 0; i < prob_size_int; i++)
                    {
                        Console.Write(Tower_A[i]);
                        Console.Write(Tower_B[i]);
                        Console.WriteLine(Tower_C[i]);
                    }
                }

                else if (input_key == "21")
                {
                    // 각 타워 어느 부분에 고리를 넣을지 정하는 부분
                    int firstval;
                    for (firstval = 0; firstval < prob_size_int; firstval++)
                    {
                        if (Tower_B[firstval] != NO_tower)
                        {
                            break;
                        }
                    }
                    int secondval;
                    int error_assist;
                    error_assist = 0;
                    for (secondval = 0; secondval < prob_size_int; secondval++)
                    {
                        if (Tower_A[secondval] != NO_tower)
                        {
                            break;
                        }
                    }
                    if (secondval == prob_size_int)
                    {
                        error_assist = 1;
                    }
                    //  errors
                    if (firstval == prob_size_int)
                    {
                        errorval = 1;
                        goto _escape;
                    }
                    //  
                    int iiF;
                    int iiS;
                    iiF = 0;
                    iiS = 0;
                    for (int ii = 0; ii < prob_size_int; ii++)
                    {
                        if (Tower_B[firstval] == TOWER[ii])
                        {
                            iiF = ii;
                        }
                        if (error_assist == 1)
                        {
                            goto _escape2;
                        }
                        if (Tower_A[secondval] == TOWER[ii])
                        {
                            iiS = ii;
                        }
                    }
                    _escape2:
                    if (iiS == 0)
                    {
                        goto _escape1;
                    }
                    if (iiF > iiS)
                    {
                        errorval = 1;
                        goto _escape;
                    }
                    _escape1:

                    string _temp;
                    _temp = Tower_B[firstval];
                    Tower_B[firstval] = Tower_A[secondval - 1];
                    Tower_A[secondval - 1] = _temp;

                    Console.Clear();

                    for (int i = 0; i < prob_size_int; i++)
                    {
                        Console.Write(Tower_A[i]);
                        Console.Write(Tower_B[i]);
                        Console.WriteLine(Tower_C[i]);
                    }
                }

                else if (input_key == "31")
                {
                    // 각 타워 어느 부분에 고리를 넣을지 정하는 부분
                    int firstval;
                    for (firstval = 0; firstval < prob_size_int; firstval++)
                    {
                        if (Tower_C[firstval] != NO_tower)
                        {
                            break;
                        }
                    }
                    int secondval;
                    int error_assist;
                    error_assist = 0;
                    for (secondval = 0; secondval < prob_size_int; secondval++)
                    {
                        if (Tower_A[secondval] != NO_tower)
                        {
                            break;
                        }
                    }
                    if (secondval == prob_size_int)
                    {
                        error_assist = 1;
                    }
                    //  errors
                    if (firstval == prob_size_int)
                    {
                        errorval = 1;
                        goto _escape;
                    }
                    //  
                    int iiF;
                    int iiS;
                    iiF = 0;
                    iiS = 0;
                    for (int ii = 0; ii < prob_size_int; ii++)
                    {
                        if (Tower_C[firstval] == TOWER[ii])
                        {
                            iiF = ii;
                        }
                        if (error_assist == 1)
                        {
                            goto _escape2;
                        }
                        if (Tower_A[secondval] == TOWER[ii])
                        {
                            iiS = ii;
                        }
                    }
                    _escape2:
                    if (iiS == 0)
                    {
                        goto _escape1;
                    }
                    if (iiF > iiS)
                    {
                        errorval = 1;
                        goto _escape;
                    }
                    _escape1:

                    string _temp;
                    _temp = Tower_C[firstval];
                    Tower_C[firstval] = Tower_A[secondval - 1];
                    Tower_A[secondval - 1] = _temp;

                    Console.Clear();

                    for (int i = 0; i < prob_size_int; i++)
                    {
                        Console.Write(Tower_A[i]);
                        Console.Write(Tower_B[i]);
                        Console.WriteLine(Tower_C[i]);
                    }
                }

                else if (input_key == "32")
                {
                    // 각 타워 어느 부분에 고리를 넣을지 정하는 부분
                    int firstval;
                    for (firstval = 0; firstval < prob_size_int; firstval++)
                    {
                        if (Tower_C[firstval] != NO_tower)
                        {
                            break;
                        }
                    }
                    int secondval;
                    int error_assist;
                    error_assist = 0;
                    for (secondval = 0; secondval < prob_size_int; secondval++)
                    {
                        if (Tower_B[secondval] != NO_tower)
                        {
                            break;
                        }
                    }
                    if (secondval == prob_size_int)
                    {
                        error_assist = 1;
                    }
                    //  errors
                    if (firstval == prob_size_int)
                    {
                        errorval = 1;
                        goto _escape;
                    }
                    //  
                    int iiF;
                    int iiS;
                    iiF = 0;
                    iiS = 0;
                    for (int ii = 0; ii < prob_size_int; ii++)
                    {
                        if (Tower_C[firstval] == TOWER[ii])
                        {
                            iiF = ii;
                        }
                        if (error_assist == 1)
                        {
                            goto _escape2;
                        }
                        if (Tower_B[secondval] == TOWER[ii])
                        {
                            iiS = ii;
                        }
                    }
                    _escape2:
                    if (iiS == 0)
                    {
                        goto _escape1;
                    }
                    if (iiF > iiS)
                    {
                        errorval = 1;
                        goto _escape;
                    }
                    _escape1:

                    string _temp;
                    _temp = Tower_C[firstval];
                    Tower_C[firstval] = Tower_B[secondval - 1];
                    Tower_B[secondval - 1] = _temp;

                    Console.Clear();

                    for (int i = 0; i < prob_size_int; i++)
                    {
                        Console.Write(Tower_A[i]);
                        Console.Write(Tower_B[i]);
                        Console.WriteLine(Tower_C[i]);
                    }
                }
                //else if(input_key == "11" || input_key == "22" || input_key == "33")
                //{
                //    goto _escape;
                //}
                else
                {
                    errorval = 1;
                    goto _escape;
                }

                _escape:
                if (errorval == 1)
                {
                    errorval = 0;
                    Console.Clear();
                    Console.WriteLine("올바른 값을 입력하세요.");
                    for (int i = 0; i < prob_size_int; i++)
                    {
                        Console.Write(Tower_A[i]);
                        Console.Write(Tower_B[i]);
                        Console.WriteLine(Tower_C[i]);
                    }
                }

            }
        }
    }
}