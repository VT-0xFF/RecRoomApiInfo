using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Foundation;
using RecRoom.Networking;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class BIIFDOPFNJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid LBPLLOCMDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string INNDOKKJPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int NGCCBDJOCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid NCMKEBKDODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly APNNOCBGIPF CHFFBFDCFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 EOALAOOGNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion FAABMGBBECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 HDBDMJCJIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool GNLNGGLNEHM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2500", Offset = "0x7FE0D00", VA = "0x187FE2500")]
	public BIIFDOPFNJN(string PFNNEAHDLNK, Guid HIBPAHDMGOI, int PJEFOGAGMPA, Guid CNLMHNDILAN, APNNOCBGIPF EOCDKEOGCNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2350", Offset = "0x7FE0B50", VA = "0x187FE2350")]
	public KFGMHEKKOBA OHCCBILCIHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2400", Offset = "0x7FE0C00", VA = "0x187FE2400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DPPAFDMIHED
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7FE27A0", Offset = "0x7FE0FA0", VA = "0x187FE27A0")]
	public static bool HIMEJJMEOAP(this RRNetworkView KBMPEIPJGHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x46B44E0", Offset = "0x46B2CE0", VA = "0x1846B44E0")]
	public static object[] CHLJHAPAIHO(this RRNetworkView KBMPEIPJGHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2700", Offset = "0x7FE0F00", VA = "0x187FE2700")]
	public static ViewId HBFLEEAKMLM(this RRNetworkView KBMPEIPJGHK)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2620", Offset = "0x7FE0E20", VA = "0x187FE2620")]
	public static APNNOCBGIPF DIKOJEOCGGE(this RRNetworkView KBMPEIPJGHK)
	{
		return default(APNNOCBGIPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7FE26D0", Offset = "0x7FE0ED0", VA = "0x187FE26D0")]
	public static APNNOCBGIPF FEEEMKEIIMN(this OFLLMOPNOGH JCPNJLMMOLN)
	{
		return default(APNNOCBGIPF);
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
