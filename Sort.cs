using System;
/// <summary>
/// 排序方法集
/// </summary>
public class Sort {
    /// <summary>
    /// 插入排序
    /// </summary>
    /// <typeparam name="T">数组类型</typeparam>
    /// <param name="n">待排序数组</param>
    /// <returns>排序好的数组</returns>
    public static T[] Insertion_Sort<T>(T[] n) where T : IComparable {
        for(int i = 1;i < n.Length;i++) {
            T temp = n[i];
            int j = i - 1;
            while(j >= 0 && temp.CompareTo(n[j]) <= 0) {
                n[j + 1] = n[j];
                j = j - 1;
            }
            n[j + 1] = temp;
        }
        return n;
    }
}
