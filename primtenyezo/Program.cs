using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primtenyezo {
    class Program {
        static void Main(string[] args) {
            while (true) {
                try {
                    int n = int.Parse(Console.ReadLine());
                    int p = 2;
                    int c = n;
                    List<int> prim = new List<int>();
                    List<int> osztas = new List<int>();
                    bool k = true;
                    while (k) {
                        if (c % p == 0) {
                            prim.Add(p);
                            osztas.Add(c / p);
                            c /= p;
                        } else {
                            bool m = true;
                            while (m) {
                                p++;
                                m = false;
                                for (int j = 2; j <= Math.Sqrt(p); j++) {
                                    if (p % j == 0) {
                                        m = true;
                                    }
                                }
                            }
                        }
                        k = false;
                        for (int j = 2; j <= Math.Sqrt(c); j++) {
                            if (c % j == 0) {
                                k = true;
                            }
                        }
                    }
                    if (osztas.Count != 0) {
                        for (int j = 0; j < n.ToString().Length + osztas[osztas.Count - 1].ToString().Length; j++) {
                            Console.Write('-');
                        }
                        Console.WriteLine("");
                        Console.WriteLine(n + "|" + prim[0]);
                        prim.RemoveAt(0);
                        for (int i = 0; i < osztas.Count - 1; i++) {
                            for (int j = 0; j < n.ToString().Length - osztas[i].ToString().Length; j++) {
                                Console.Write(' ');
                            }
                            Console.WriteLine(osztas[i] + "|" + prim[i]);
                        }
                        for (int j = 0; j < n.ToString().Length -
                            osztas[osztas.Count - 1].ToString().Length; j++) {

                            Console.Write(' ');
                        }
                        Console.WriteLine(osztas[osztas.Count - 1] + "|");
                        for (int j = 0; j < n.ToString().Length + osztas[osztas.Count - 1].ToString().Length; j++) {
                            Console.Write('-');
                        }
                    } else {
                        for (int j = 0; j < n.ToString().Length + 1.ToString().Length; j++) {
                            Console.Write('-');
                        }
                        Console.WriteLine("");
                        Console.WriteLine(n + "|");
                        for (int j = 0; j < n.ToString().Length + 1.ToString().Length; j++) {
                            Console.Write('-');
                        }
                    }
                    Console.WriteLine("");
                } catch (Exception) {
                    Console.WriteLine("hiba");
                }

            }
        }
    }
}
