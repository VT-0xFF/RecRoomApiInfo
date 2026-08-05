using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GEFFMDOHFKM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GEHKDBEENCP();

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IGFBOCALDGD();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BHAMJIBEDKD
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6EB1410", Offset = "0x6EAFE10", VA = "0x186EB1410")]
	public static void BDFAKBHFPGJ(this IList<GEFFMDOHFKM> MJBODFHEJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6EB15C0", Offset = "0x6EAFFC0", VA = "0x186EB15C0")]
	public static void CMPDJIGPGHK(this IList<GEFFMDOHFKM> MJBODFHEJMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OGOAPNICIIH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int NNBOHMBLDDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool CLFCKEAEKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IDictionary<object, object> JBNHJDHCDNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string DPKHILCDFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int LPDIBIGDKEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KIONCBIEAPB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KBEJLAHBIDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly string JLKDCFFCCCH;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
	public KBEJLAHBIDN([Optional] string JLKDCFFCCCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6EB1770", Offset = "0x6EB0170", VA = "0x186EB1770", Slot = "3")]
	public override string ToString()
	{
		return null;
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
