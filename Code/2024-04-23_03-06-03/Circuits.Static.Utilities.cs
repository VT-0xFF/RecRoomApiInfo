using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class KJLJMOPMJJM<TData> : AKCFNDEBMDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string LLOICNKPPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData IKNEHLGBAHD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "7")]
	public override string MGJEJBNDCKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3D8CDF0", Offset = "0x3D8BDF0", VA = "0x183D8CDF0")]
	internal KJLJMOPMJJM(string JJJNODJJIFK, [In] TData GPKMLHOONCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class OGADNKDEEGH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1E9AC80", Offset = "0x1E99C80", VA = "0x181E9AC80")]
	public static KJLJMOPMJJM<KLKJPNNICPF> MGIIAIMPALM(string JJJNODJJIFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2717F40", Offset = "0x2716F40", VA = "0x182717F40")]
	public static KJLJMOPMJJM<TData> MGIIAIMPALM<TData>(string JJJNODJJIFK, [In] TData GPKMLHOONCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FABIFMLBNGI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x28A41F0", Offset = "0x28A31F0", VA = "0x1828A41F0")]
	public static PGLGENBDGKP<TOk, AABLFGLHLFL> MCHPCFHLNEP<TOk>([In] this PGLGENBDGKP<TOk, AABLFGLHLFL> HFLBADIEKAM, string JJJNODJJIFK)
	{
		return default(PGLGENBDGKP<TOk, AABLFGLHLFL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class AKCFNDEBMDK : HBNEILLBGHD, AABLFGLHLFL, HHPFBBGIKCL
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1E5F7B0", Offset = "0x1E5E7B0", VA = "0x181E5F7B0")]
	protected AKCFNDEBMDK()
	{
	}
}
namespace Cpp2IlInjected;

internal class AddressAttribute : Attribute
{
	public string RVA;

	public string Offset;

	public string VA;

	public string Slot;
}
internal class FieldOffsetAttribute : Attribute
{
	public string Offset;
}
internal class AttributeAttribute : Attribute
{
	public string Name;

	public string RVA;

	public string Offset;
}
internal class MetadataOffsetAttribute : Attribute
{
	public string Offset;
}
internal class TokenAttribute : Attribute
{
	public string Token;
}
internal class AnalysisFailedException : Exception
{
	public AnalysisFailedException(string message)
		: base(message)
	{
	}
}
