using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface LJJOJPHMCAG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCMKJFFLEPD(MLDAFHLMJPK HLCODDJIAJC, PPEJNODGFMI BKNOMMNPHGO);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(MLDAFHLMJPK, ComponentTypeList, DIDOKCPJOKL)> FGNKACCBLME(FGBMEEKCDHG HBFPCHBLCMH);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void DIDOKCPJOKL(MLDAFHLMJPK HLCODDJIAJC, PPEJNODGFMI BKNOMMNPHGO);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct PPEJNODGFMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity JIPIEBFBEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager FHNEBBCLKID;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x24BD8F0", Offset = "0x24BC0F0", VA = "0x1824BD8F0")]
	public PPEJNODGFMI(Entity JIPIEBFBEML, EntityManager FHNEBBCLKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C430", Offset = "0x2C6AC30", VA = "0x182C6C430")]
	public void KAMKODPJIMO<T>(T IPHHABIKCHD) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C650", Offset = "0x2C6AE50", VA = "0x182C6C650")]
	public void ODAJFFGCDFN<T>(T IPHHABIKCHD) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6940B00", Offset = "0x693F300", VA = "0x186940B00")]
	public void LFLDNAJFNDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FGBMEEKCDHG
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(DOAIKOFFLKL, MLDAFHLMJPK)> NLJGJPAEMIC();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class LLDEGPNFDFK : NBLDFFPFCFK
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1483A10", Offset = "0x1482210", VA = "0x181483A10")]
	public LLDEGPNFDFK()
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
