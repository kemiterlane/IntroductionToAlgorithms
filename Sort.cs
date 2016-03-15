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
    public static void Insertion_Sort<T>(T[] n) where T : IComparable {
        for(int i = 1;i < n.Length;i++) {
            T temp = n[i];
            int j = i - 1;
            while(j >= 0 && temp.CompareTo(n[j]) <= 0) {
                n[j + 1] = n[j];
                j = j - 1;
            }
            n[j + 1] = temp;
        }
    }
    /// <summary>
    /// 分治法排序（归并排序）
    /// </summary>
    /// <typeparam name="T">数组类型</typeparam>
    /// <param name="n">待排序的数组</param>
    /// <param name="p">数组的起始下标</param>
    /// <param name="r">数组的结束下标</param>
    public static void Merge_Sort<T>(T[] n,int p,int r) where T : IComparable {
        if(p < r) {
            int q = (p + r) / 2;
            Merge_Sort(n,p,q);
            Merge_Sort(n,q + 1,r);
            Merge(n,p,q,r);
        }
    }
    /// <summary>
    /// 合并数组
    /// </summary>
    /// <typeparam name="T">数组类型</typeparam>
    /// <param name="n">待排序的数组</param>
    /// <param name="p">数组1的起始下标</param>
    /// <param name="q">数组1的结束下标</param>
    /// <param name="r">数组2的结束下标</param>
    private static void Merge<T>(T[] n,int p,int q,int r) where T : IComparable {
        T[] Left = new T[q - p + 1];
        T[] Right = new T[r - q];
        for(int i = 0;i < Left.Length;i++) {
            Left[i] = n[p + i];
        }
        for(int j = 0;j < Right.Length;j++) {
            Right[j] = n[q + j + 1];
        }
        int a = 0, b = 0;
        for(int k = p;k <= r;k++) {
            if(a == Left.Length) {
                n[k] = Right[b];
                b = b + 1;
            }
            else if(b == Right.Length) {
                n[k] = Left[a];
                a = a + 1;
            }
            else if(Left[a].CompareTo(Right[b]) <= 0) {
                n[k] = Left[a];
                a = a + 1;
            }
            else {
                n[k] = Right[b];
                b = b + 1;
            }
        }
    }
}
