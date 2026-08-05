using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;
using Unity.Collections;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GMJNDIAIHGB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MKOELGCFOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::BPGHEFONOCE<Texture2D> LGPHNAMDLGP(NativeArray<byte> MBFFCFCIILB, bool IGAHMOAJCOK = false);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class IDIJJJBHALF : GMJNDIAIHGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool MKOELGCFOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD00", Offset = "0x6C9F00", VA = "0x1806CAD00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x64A9230", Offset = "0x64A8430", VA = "0x1864A9230")]
	[ELNMOMKNGKB(LBAHANGFDMJ.None)]
	private static void HBBPIOBOEHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	[Preserve]
	public IDIJJJBHALF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x64A9330", Offset = "0x64A8530", VA = "0x1864A9330", Slot = "5")]
	public global::BPGHEFONOCE<Texture2D> LGPHNAMDLGP(NativeArray<byte> MBFFCFCIILB, bool IGAHMOAJCOK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "6")]
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
