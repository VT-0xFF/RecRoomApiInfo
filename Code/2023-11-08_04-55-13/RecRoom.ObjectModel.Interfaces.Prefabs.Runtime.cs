using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KHACNIPJLNO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CLANCBFJPNO(POLLAGMGKIL HPJEHGNFPGN, LNOBPPAIAAC KMAIPCBOHIJ);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(POLLAGMGKIL, ComponentTypeList, FMHGEKDHIKJ)> DGFGOPMLJHP(MPOBNPAABAA IGKHOKFEEGN);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void FMHGEKDHIKJ(POLLAGMGKIL HPJEHGNFPGN, LNOBPPAIAAC KMAIPCBOHIJ);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LNOBPPAIAAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity OEEKGABNFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager FOMHILNOHEE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x20ACE40", Offset = "0x20ABC40", VA = "0x1820ACE40")]
	public LNOBPPAIAAC(Entity OEEKGABNFEP, EntityManager FOMHILNOHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2568610", Offset = "0x2567410", VA = "0x182568610")]
	public void CCOBHHAAMMF<T>(T PHPDIJICBJO) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2568590", Offset = "0x2567390", VA = "0x182568590")]
	public void CCMKBKKFDKD<T>(T PHPDIJICBJO) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5EC12E0", Offset = "0x5EC00E0", VA = "0x185EC12E0")]
	public void OJLBEMENDOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MPOBNPAABAA
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(DCKPNNMCENH, POLLAGMGKIL)> MENBEIBAEIF();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class BCCBEELBNCN : AKHEGHBFDGH
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x77F100", Offset = "0x77DF00", VA = "0x18077F100")]
	public BCCBEELBNCN()
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
