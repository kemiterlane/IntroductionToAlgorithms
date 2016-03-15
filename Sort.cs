using System;
public class Sort {
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
