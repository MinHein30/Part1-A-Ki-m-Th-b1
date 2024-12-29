// See https://aka.ms/new-console-template for more information
using System;

Console.Write("Type the value of n (or Enter to close): ");
int n;
if (!int.TryParse(Console.ReadLine(), out n)) return;

Console.Write("Enter machine-calculated value for S1: ");
double S1_machine = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter machine-calculated value for S2: ");
double S2_machine = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter machine-calculated value for S5: ");
double S5_machine = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter machine-calculated value for S6: ");
double S6_machine = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter machine-calculated value for S7: ");
double S7_machine = Convert.ToDouble(Console.ReadLine());

Console.Write("\nEnter manually calculated value for S1: ");
double S1_manual = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter manually calculated value for S2: ");
double S2_manual = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter manually calculated value for S5: ");
double S5_manual = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter manually calculated value for S6: ");
double S6_manual = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter manually calculated value for S7: ");
double S7_manual = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"\nResults for n = {n}");
Console.WriteLine($" Metric   | Machine Value   |  Manual Value   | Status   ");
Console.WriteLine($"----------+-----------------+------------------+----------");
Console.WriteLine($" S1       | {S1_machine,-15} | {S1_manual,-15} | {(S1_machine == S1_manual ? "Passed" : "Failed"),-8} ");
Console.WriteLine($" S2       | {S2_machine,-15} | {S2_manual,-15} | {(S2_machine == S2_manual ? "Passed" : "Failed"),-8} ");
Console.WriteLine($" S5       | {S5_machine,-15} | {S5_manual,-15} | {(S5_machine == S5_manual ? "Passed" : "Failed"),-8} ");
Console.WriteLine($" S6       | {S6_machine,-15} | {S6_manual,-15} | {(S6_machine == S6_manual ? "Passed" : "Failed"),-8} ");
Console.WriteLine($" S7       | {S7_machine,-15} | {S7_manual,-15} | {(S7_machine == S7_manual ? "Passed" : "Failed"),-8} ");

Console.WriteLine();
Console.ReadKey();
