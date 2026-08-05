using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;
using Unity.Collections;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface AAACGAJJANP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GNKCPPFDPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::LEPCGNJFAKI<Texture2D> MCFDLGLEOOB(NativeArray<byte> ICDPCPGNGGB, bool MPLDGPEPJDJ = false);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class MJNPNFPNOEG : AAACGAJJANP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GNKCPPFDPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x64F8D80", Offset = "0x64F8180", VA = "0x1864F8D80")]
	[KPHLIICFIPJ(OEKFJILJDLM.None)]
	private static void NBKPOCLHNMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	[Preserve]
	public MJNPNFPNOEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x64F8D30", Offset = "0x64F8130", VA = "0x1864F8D30", Slot = "5")]
	public global::LEPCGNJFAKI<Texture2D> MCFDLGLEOOB(NativeArray<byte> ICDPCPGNGGB, bool MPLDGPEPJDJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "6")]
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
