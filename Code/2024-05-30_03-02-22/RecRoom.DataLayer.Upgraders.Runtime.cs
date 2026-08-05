using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::CMMDACFJAJJ(typeof(ContainerFlagsData))]
public static class JEEGHIJOBJP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x63C3B50", Offset = "0x63C2D50", VA = "0x1863C3B50")]
	[global::CJPCAGBFNLC(1)]
	public static void DIGPNAAECLA([global::KPANOAMPJIO(1)] ACJBFNFLLFC PPPMODKHACE, [Out][global::KPANOAMPJIO(1)] ACJBFNFLLFC ICKAEEABOGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::CMMDACFJAJJ(typeof(ObjectPolicyData))]
public static class CHHOBJFJJPF
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x63C3B30", Offset = "0x63C2D30", VA = "0x1863C3B30")]
	[global::CJPCAGBFNLC(2)]
	public static void OBBJAEOMEKN([global::KPANOAMPJIO(3)] bool GOLJDBDNBMH, [Out][global::KPANOAMPJIO(3)] BPFEAHFPDEI HOFNLGPBEHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::CMMDACFJAJJ(typeof(PersistentUserTagData))]
public static class HDJMNFJGILB
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x63C3B40", Offset = "0x63C2D40", VA = "0x1863C3B40")]
	[global::CJPCAGBFNLC(1)]
	public static void DENOFHMOHAN([global::KPANOAMPJIO(1)] FixedList32Bytes<int> IHLALKIMHCE, [Out][global::KPANOAMPJIO(2)] bool OPGNGMFMFII)
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
