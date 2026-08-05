using System;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface AHJJBCHLGAM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FHGELIEPNCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::AMIHAOIHCDH<Texture2D> OKJEAPHHKKK(NativeArray<byte> HNEMDOJHCAC, bool DMANDFNEGHF = false);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class LIEMGKDBGJO : AHJJBCHLGAM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool FHGELIEPNCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x681D00", Offset = "0x680D00", VA = "0x180681D00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6125C50", Offset = "0x6124C50", VA = "0x186125C50")]
	[EJICMPGFCBP(CIKEJIGJNLD.None)]
	private static void MCFDGBFIIAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	[Preserve]
	public LIEMGKDBGJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6125D50", Offset = "0x6124D50", VA = "0x186125D50", Slot = "5")]
	public global::AMIHAOIHCDH<Texture2D> OKJEAPHHKKK(NativeArray<byte> HNEMDOJHCAC, bool DMANDFNEGHF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "6")]
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
