using System;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface NCBBCMOFPGA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ELDGKCPPANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::FCDBOEHACAC<Texture2D> GBALOKOCHBE(NativeArray<byte> HAGMPMHAJNM, bool AONNPOAFBKN = false);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class FGECCPEMEBF : NCBBCMOFPGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool ELDGKCPPANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x58DEC0", Offset = "0x58CEC0", VA = "0x18058DEC0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xDDDF30", Offset = "0xDDCF30", VA = "0x180DDDF30")]
	[LPDKEEGEILI]
	private static void DPOIAANJAJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	[Preserve]
	public FGECCPEMEBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xDDE090", Offset = "0xDDD090", VA = "0x180DDE090", Slot = "5")]
	public global::FCDBOEHACAC<Texture2D> GBALOKOCHBE(NativeArray<byte> HAGMPMHAJNM, bool AONNPOAFBKN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "6")]
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
