using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

Compute(new Pinnable().Pin = 1);

unsafe void Compute(object instance)
{
    fixed (ulong* ptr = &Unsafe.As<Pinnable>(instance).Pin)
    {
        Console.WriteLine(*ptr);
    }
}

[StructLayout(LayoutKind.Sequential)]
internal sealed class Pinnable
{
    public ulong Pin;
}
