using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	// 用Enumerable.Range() 建立一個序列, 值介於 [10, 15] 請利用迴圈列出每一個項目值,確認無誤
	internal class Program
	{
		static void Main(string[] args)
		{
			var items = Enumerable.Range(10, 6);

			foreach (var item in items) { Console.WriteLine(item); }
		}
	}
}
