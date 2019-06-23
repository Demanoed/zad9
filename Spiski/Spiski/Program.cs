﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemanT_Library;

namespace Spiski
{
    class Program
    {
        private static Head MadeHead(int N)
        {
            Head list = new Head();
            Head beg = new Head();
            beg = list;
            Console.Clear();
            for (int i = 0; i < N; i++)
            {
                ColorMess.Yellow("\n Введите " + (i+1) + " число: ");
                beg.Info = Input.Check(int.MinValue, int.MaxValue);
                beg.Next = new Head();
                beg = beg.Next;
                Console.Clear();
            }
            return list;
        }
        private static void MadeLists(Head head)
        {
            Point Pos = new Point();
            Point PosBeg = new Point();
            PosBeg = Pos;
            Point Neg = new Point();
            Point NegBeg = new Point();
            NegBeg = Neg;
            Head beg = new Head();
            beg = head;
            while (beg != null)
            {
                if (beg.Info > 0)
                {
                    PosBeg.Info = beg;
                    PosBeg.Next = new Point();
                    PosBeg = PosBeg.Next;
                }
                if (beg.Info < 0)
                {
                    NegBeg.Info = beg;
                    NegBeg.Next = new Point();
                    NegBeg = NegBeg.Next;
                }
                beg = beg.Next;
            }
            ColorMess.Magenta("\n Положительный список: ");
            WriteList(Pos);
            ColorMess.Magenta("\n Отрицательный список: ");
            WriteList(Neg);
        }
        private static void WriteList(Point list)
        {
            if (list.Info != null)
            {
                Point beg = new Point();
                beg = list;
                while (beg.Next != null)
                {
                    ColorMess.Yellow(""+beg.Info);
                    if (beg.Next.Next != null) ColorMess.Magenta(" -> ");
                    beg = beg.Next;
                }
                Console.WriteLine();
            }
            else ColorMess.Red("Список пустой");
        }
        static void Main()
        {
            ColorMess.Yellow("\n Введите колличество элементов: ");
            int N = Input.Check(2, int.MaxValue);
            Head head = new Head();
            head = MadeHead(N);
            MadeLists(head);
            Message.GoToBack();
        }
    }
}
