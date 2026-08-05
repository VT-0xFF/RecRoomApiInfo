using System;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface CFECEMPMKBL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MKNOKEDKPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::HJGKGDDIAPD<Texture2D> ODLEMOEBGPH(NativeArray<byte> CHKFKLOCJFC, bool MLEPFNFKJLH = false);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class DPLCIPLEIFH : CFECEMPMKBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool MKNOKEDKPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x64DD00", Offset = "0x64CD00", VA = "0x18064DD00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E4BEE0", Offset = "0x5E4AEE0", VA = "0x185E4BEE0")]
	[FBDCEBOAGGK(ABMKJHLOOPK.None)]
	private static void PBMNJAAGLPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	[Preserve]
	public DPLCIPLEIFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5E4BE90", Offset = "0x5E4AE90", VA = "0x185E4BE90", Slot = "5")]
	public global::HJGKGDDIAPD<Texture2D> ODLEMOEBGPH(NativeArray<byte> CHKFKLOCJFC, bool MLEPFNFKJLH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "6")]
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
