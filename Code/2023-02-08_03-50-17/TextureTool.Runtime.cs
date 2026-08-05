using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;
using Unity.Collections;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IGFCPPAHEPM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DPIFAAKKNFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::OGCIFLDFEID<Texture2D> IBHGJJNLBPG(NativeArray<byte> CBCFCNJJPDP, bool NOHMKPBJLFN = false);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class IANCNKGEGJI : IGFCPPAHEPM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool DPIFAAKKNFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6E5BE0", Offset = "0x6E49E0", VA = "0x1806E5BE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x21E5480", Offset = "0x21E4280", VA = "0x1821E5480")]
	[HPAMKJCLFIM(BFFNGLOENLB.None)]
	private static void BMLCOLABDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	[Preserve]
	public IANCNKGEGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x21E5580", Offset = "0x21E4380", VA = "0x1821E5580", Slot = "5")]
	public global::OGCIFLDFEID<Texture2D> IBHGJJNLBPG(NativeArray<byte> CBCFCNJJPDP, bool NOHMKPBJLFN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "6")]
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
