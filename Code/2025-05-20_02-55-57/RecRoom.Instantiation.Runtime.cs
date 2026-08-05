using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Foundation;
using RecRoom.Networking;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class KPFBBJDLKAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid HNIJMNKOLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string BNEPAKPDFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int ICANBPHBAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid NPCAIJNAHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly NPBKHGDHPBE CABMDKMDEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 PHGICKGLDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion JPIDPNKLHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 MKNJDDMDEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool GOHEGKDAAGA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7CD5EB0", Offset = "0x7CD50B0", VA = "0x187CD5EB0")]
	public KPFBBJDLKAE(string PGFEGIPOLEF, Guid GOAAMMIIOJA, int NPOFKPDHEHH, Guid PGKMPKPKBOJ, NPBKHGDHPBE IKPFHMFHFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7CD5D00", Offset = "0x7CD4F00", VA = "0x187CD5D00")]
	public ANAGNMGLHIF BFMIIABLBFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7CD5DB0", Offset = "0x7CD4FB0", VA = "0x187CD5DB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PAGBGOELDAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7CD6150", Offset = "0x7CD5350", VA = "0x187CD6150")]
	public static bool ODFAEOKIIFA(this RRNetworkView DMGGONLOPJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4EA2620", Offset = "0x4EA1820", VA = "0x184EA2620")]
	public static object[] MGJNEAKPPDD(this RRNetworkView DMGGONLOPJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7CD6080", Offset = "0x7CD5280", VA = "0x187CD6080")]
	public static ViewId KFHJKOHEPDM(this RRNetworkView DMGGONLOPJG)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7CD5FD0", Offset = "0x7CD51D0", VA = "0x187CD5FD0")]
	public static NPBKHGDHPBE JLAKLLHBAEH(this RRNetworkView DMGGONLOPJG)
	{
		return default(NPBKHGDHPBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7CD6120", Offset = "0x7CD5320", VA = "0x187CD6120")]
	public static NPBKHGDHPBE MNPGGABFJDB(this GMFHHFBCIEG MGEECOGALOB)
	{
		return default(NPBKHGDHPBE);
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
