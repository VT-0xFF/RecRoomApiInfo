using System;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface OBBALKCJBND
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GHDFFAFBIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::MOMENDBJNKG<Texture2D> HDLJAPAFEMO(NativeArray<byte> JICKIJDNGGF, bool GJFGKOHJIGP = false);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class AIDDHIPOPID : OBBALKCJBND, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GHDFFAFBIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x69D720", Offset = "0x69C120", VA = "0x18069D720", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6071040", Offset = "0x606FA40", VA = "0x186071040")]
	[PBIPNKEGBNL(MIDPNFMDJEE.None)]
	private static void LLBCFMIOPFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	[Preserve]
	public AIDDHIPOPID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6070FF0", Offset = "0x606F9F0", VA = "0x186070FF0", Slot = "5")]
	public global::MOMENDBJNKG<Texture2D> HDLJAPAFEMO(NativeArray<byte> JICKIJDNGGF, bool GJFGKOHJIGP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "6")]
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
