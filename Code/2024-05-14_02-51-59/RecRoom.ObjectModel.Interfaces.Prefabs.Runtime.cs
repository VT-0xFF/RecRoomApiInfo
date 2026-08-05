using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface ILANFIDDPHI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JBFACMGEKAC(GAPHNGPGADD BHKMCAKMPKO, EOHEGDMKLKN JHFCOCOAEFH);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(GAPHNGPGADD, ComponentTypeList, PICKAOMPDGK)> JPBFONACLKG(FODBGLNIFFA DOOODGNJBEI);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void PICKAOMPDGK(GAPHNGPGADD BHKMCAKMPKO, EOHEGDMKLKN JHFCOCOAEFH);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct EOHEGDMKLKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity DFBELOGKKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager KBFJIBCFALI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x23E9F70", Offset = "0x23E8970", VA = "0x1823E9F70")]
	public EOHEGDMKLKN(Entity DFBELOGKKCC, EntityManager KBFJIBCFALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x280EB10", Offset = "0x280D510", VA = "0x18280EB10")]
	public void NPHNBOIFMNI<T>(T AEJBOLFACJC) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x280EA90", Offset = "0x280D490", VA = "0x18280EA90")]
	public void KKLKOMOKHMA<T>(T AEJBOLFACJC) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x64115F0", Offset = "0x640FFF0", VA = "0x1864115F0")]
	public void MAIPPCJDJGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FODBGLNIFFA
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(IMOOPIBCBLJ, GAPHNGPGADD)> ONGCJEKJEOA();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class HLEGELFPABD : NJIIJAHIOAA
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x137BD10", Offset = "0x137A710", VA = "0x18137BD10")]
	public HLEGELFPABD()
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
