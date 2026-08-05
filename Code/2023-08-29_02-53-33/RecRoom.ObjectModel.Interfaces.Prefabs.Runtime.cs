using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BPCGJMMPFKK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(EHKHPDFBEJD, LENINMGJJHF)> EMGAEMHEJJJ();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class)]
public class FEPKIPICHPI : IFPCMOOGJCE
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xD17B50", Offset = "0xD16F50", VA = "0x180D17B50")]
	public FEPKIPICHPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface AKNPKFGMABO
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FMDIAJMLNDN(LENINMGJJHF MNOKFAHHNHH, PLPHKOOLAAO DNOMLLFMCIP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(LENINMGJJHF, ComponentTypeList, KPBCDGJDDHN)> PECFPJDPION(BPCGJMMPFKK EDNPFADAINI);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void KPBCDGJDDHN(LENINMGJJHF MNOKFAHHNHH, PLPHKOOLAAO DNOMLLFMCIP);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct PLPHKOOLAAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity FKNFFDFGNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager GLPCEPPDPLB;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x16CEC80", Offset = "0x16CE080", VA = "0x1816CEC80")]
	public PLPHKOOLAAO(Entity FKNFFDFGNMN, EntityManager GLPCEPPDPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x35BE990", Offset = "0x35BDD90", VA = "0x1835BE990")]
	public void DADPJLGDIHI<T>(T KKIAKNLLHIO) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x35BEA70", Offset = "0x35BDE70", VA = "0x1835BEA70")]
	public void NIANKFNPHPE<T>(T KKIAKNLLHIO) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD130", Offset = "0x6FAC530", VA = "0x186FAD130")]
	public void OJBJNGDPNPD()
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
