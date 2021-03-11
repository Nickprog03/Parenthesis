using System;
using System.Collections.Generic;
using System.Linq;

namespace Parenthesis
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сбалансированность скобок: " + IsBalanced("((1+3)()(4+(3-5)))"));
        }

        public static bool IsBalanced(string input)
        {
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>() {
            { '(', ')' }
        };

            Stack<char> brackets = new Stack<char>();

            try
            {
                // Итерация каждого символа строки
                foreach (char c in input)
                {
                    // проверить является ли символ открывающей скобкой
                    if (bracketPairs.Keys.Contains(c))
                    {
                        // если да, то добавить в стэк
                        brackets.Push(c);
                    }
                    else
                        // проверить является ли символ закрывающей скобкой
                        if (bracketPairs.Values.Contains(c))
                    {
                        // check if the closing bracket matches the 'latest' 'opening' bracket
                        // проверить подходит ли закрывающая скобка в пару 'последней' 'открывающей' скобкой
                        //if (c == bracketPairs[brackets.First()])
                        if (c == bracketPairs['('])
                        {
                            // удалить из стэка
                            brackets.Pop();
                        }
                        else
                            // если нет, то это несбалансированная строка
                            return false;
                    }
                    else
                        // продолжить проверку
                        continue;
                }
            }
            catch
            {
                // исключение в случае, если закрывающая скобка найдена раньше открывающей
                // это означает, что скобки несбалансированны. Возвращает false
                return false;
            }
            
            // проверка, что все скобки закрыты
            return brackets.Count() == 0 ? true : false;
        }
    }
}
