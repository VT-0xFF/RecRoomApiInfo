using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface AKFIHBAHOBH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EAFHNKHMEDP();

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FBJEIBHECPO();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LBBFPKMOMEF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x72F2BF0", Offset = "0x72F1DF0", VA = "0x1872F2BF0")]
	public static void BOEIFBKJFPA(this IList<AKFIHBAHOBH> GHAPLHOCKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x72F2DA0", Offset = "0x72F1FA0", VA = "0x1872F2DA0")]
	public static void EFJBGAHPIKE(this IList<AKFIHBAHOBH> GHAPLHOCKIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface IAGJLFEFIKH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int PFGOMFDAGOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool OBMKEHCENKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IDictionary<object, object> NHGIEHOIJEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string PHHEBPPLEBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int EHFMPAKCPHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NHOMAIFPKHC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DAIEOJJKKMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly string CENGMHLLADG;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	public DAIEOJJKKMF([Optional] string CENGMHLLADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x72F2BA0", Offset = "0x72F1DA0", VA = "0x1872F2BA0", Slot = "3")]
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
