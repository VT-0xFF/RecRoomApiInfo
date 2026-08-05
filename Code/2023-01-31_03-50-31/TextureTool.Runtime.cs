using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;
using Unity.Collections;
using UnityEngine;

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
		[Cpp2IlInjected.Address(RVA = "0x6B1E00", Offset = "0x6B0C00", VA = "0x1806B1E00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2275C00", Offset = "0x2274A00", VA = "0x182275C00")]
	[EJICMPGFCBP(CIKEJIGJNLD.None)]
	private static void MCFDGBFIIAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	[Preserve]
	public LIEMGKDBGJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2275D00", Offset = "0x2274B00", VA = "0x182275D00", Slot = "5")]
	public global::AMIHAOIHCDH<Texture2D> OKJEAPHHKKK(NativeArray<byte> HNEMDOJHCAC, bool DMANDFNEGHF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "6")]
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
