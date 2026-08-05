using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class BMPLMOCAEPN<TData> : JNABADLMAMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string IBHMBHJJPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData GAMKDEPHLKE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "7")]
	public override string GBCPGMBELKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3EA0", Offset = "0x4EA32A0", VA = "0x184EA3EA0")]
	internal BMPLMOCAEPN(string PBDOHNMILPN, [In] TData LDNEPNAGEGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class IPCEGAIBDHD
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2059FB0", Offset = "0x20593B0", VA = "0x182059FB0")]
	public static BMPLMOCAEPN<AEFODLADDHH> DDEJLDFANAB(string PBDOHNMILPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2993FE0", Offset = "0x29933E0", VA = "0x182993FE0")]
	public static BMPLMOCAEPN<TData> DDEJLDFANAB<TData>(string PBDOHNMILPN, [In] TData LDNEPNAGEGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NPHAFPIDHFO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2CF3180", Offset = "0x2CF2580", VA = "0x182CF3180")]
	public static NNKIHJJJOOI<TOk, FAGGAEGFGFH> PLIOPGONIDJ<TOk>([In] this NNKIHJJJOOI<TOk, FAGGAEGFGFH> ABPJKOBADEP, string PBDOHNMILPN)
	{
		return default(NNKIHJJJOOI<TOk, FAGGAEGFGFH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class JNABADLMAMC : NDGMACBFDAM, FAGGAEGFGFH, EHALGCGAKNL
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2019060", Offset = "0x2018460", VA = "0x182019060")]
	protected JNABADLMAMC()
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
