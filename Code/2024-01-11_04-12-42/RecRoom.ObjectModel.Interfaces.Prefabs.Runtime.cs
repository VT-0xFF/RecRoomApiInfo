using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface CAIIOPKMJHG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJNEMNAICLP(BPNENPIPGEM NEHEFLNJNAI, INLGBKEIBOP KNLIDAPCCKE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(BPNENPIPGEM, ComponentTypeList, PJFPINAIDPO)> LGOKPBBBMFK(IICIOHDGCDP AOBLAMJEEPO);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void PJFPINAIDPO(BPNENPIPGEM NEHEFLNJNAI, INLGBKEIBOP KNLIDAPCCKE);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct INLGBKEIBOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity MJDHOBNEHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager DIKBBLNPABK;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x217DAF0", Offset = "0x217C4F0", VA = "0x18217DAF0")]
	public INLGBKEIBOP(Entity MJDHOBNEHKO, EntityManager DIKBBLNPABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2639070", Offset = "0x2637A70", VA = "0x182639070")]
	public void OGNHOBPFCBA<T>(T BEEGCHJLJFC) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2638FF0", Offset = "0x26379F0", VA = "0x182638FF0")]
	public void JGLMMMEJOPH<T>(T BEEGCHJLJFC) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60B06B0", Offset = "0x60AF0B0", VA = "0x1860B06B0")]
	public void KGHNKDMIIHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IICIOHDGCDP
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(FJBOEPNNDLB, BPNENPIPGEM)> BPGNCPEOMPI();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class FHIBGIFNIAO : MOEKHOCKEJK
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x79F100", Offset = "0x79DB00", VA = "0x18079F100")]
	public FHIBGIFNIAO()
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
