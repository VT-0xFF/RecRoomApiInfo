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
		[Cpp2IlInjected.Address(RVA = "0x6681B0", Offset = "0x666FB0", VA = "0x1806681B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5EC2CC0", Offset = "0x5EC1AC0", VA = "0x185EC2CC0")]
	[IIBELCEICEH(INPGEEFAPCN.None)]
	private static void HFGCFLBPFBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	[Preserve]
	public GCCGGPJIIJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5EC2DC0", Offset = "0x5EC1BC0", VA = "0x185EC2DC0", Slot = "5")]
	public global::GGPPGKDIKHO<Texture2D> MNHAFFHJGHI(NativeArray<byte> HJMGIENPKCG, bool MNHEHPNMFBL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "6")]
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
