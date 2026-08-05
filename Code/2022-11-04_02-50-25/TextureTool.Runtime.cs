using System;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BPKKFHJONIN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MMLKPMGJDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::OMJFONEECHD<Texture2D> JFMKAJGMNLF(NativeArray<byte> AFHIHCILCBE, bool OAOCNOBDOEP = false);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GKOFMIDBJOO : BPKKFHJONIN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool MMLKPMGJDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x670D00", Offset = "0x670100", VA = "0x180670D00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60135A0", Offset = "0x60129A0", VA = "0x1860135A0")]
	[AMOLIILEGPJ(OPIFOMJNBJD.None)]
	private static void IFHPELFOHHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	[Preserve]
	public GKOFMIDBJOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60136A0", Offset = "0x6012AA0", VA = "0x1860136A0", Slot = "5")]
	public global::OMJFONEECHD<Texture2D> JFMKAJGMNLF(NativeArray<byte> AFHIHCILCBE, bool OAOCNOBDOEP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "6")]
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
