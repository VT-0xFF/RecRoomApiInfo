using System;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JGBFIFGKLDB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MKEICJMMAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::GGPPGKDIKHO<Texture2D> MNHAFFHJGHI(NativeArray<byte> HJMGIENPKCG, bool MNHEHPNMFBL = false);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GCCGGPJIIJN : JGBFIFGKLDB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool MKEICJMMAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679900", VA = "0x18067AD00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x609A970", Offset = "0x6099570", VA = "0x18609A970")]
	[IIBELCEICEH(INPGEEFAPCN.None)]
	private static void HFGCFLBPFBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	[Preserve]
	public GCCGGPJIIJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x609AA70", Offset = "0x6099670", VA = "0x18609AA70", Slot = "5")]
	public global::GGPPGKDIKHO<Texture2D> MNHAFFHJGHI(NativeArray<byte> HJMGIENPKCG, bool MNHEHPNMFBL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "6")]
	public void Dispose()
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
