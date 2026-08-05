using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;
using Unity.Collections;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BFFNNABCLIO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IIELNGFIMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::EHAOBGIILCF<Texture2D> PDOKABONNGK(NativeArray<byte> FBNMPILPCEH, bool KDLGCBIEIBI = false);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class KMCPDMMOPIK : BFFNNABCLIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool IIELNGFIMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x64B3760", Offset = "0x64B2160", VA = "0x1864B3760")]
	[CJJNALDLMHL(HFKENCJEONK.None)]
	private static void GNBPIFAPGJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	[Preserve]
	public KMCPDMMOPIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x64B3860", Offset = "0x64B2260", VA = "0x1864B3860", Slot = "5")]
	public global::EHAOBGIILCF<Texture2D> PDOKABONNGK(NativeArray<byte> FBNMPILPCEH, bool KDLGCBIEIBI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "6")]
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
