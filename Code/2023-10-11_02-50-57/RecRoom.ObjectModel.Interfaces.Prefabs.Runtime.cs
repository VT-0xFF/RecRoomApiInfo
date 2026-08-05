using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MEHAHPMDPEP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LCODJCIOJOJ(FMJMJJHCMAN CMNEDOHOKIA, JGJKIMKLDPL AHPJJNGOIJO);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(FMJMJJHCMAN, ComponentTypeList, HKCAMDPDJCF)> LKGBDLKBGPK(NADKLGCBGPO IPGJNLBLKJO);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void HKCAMDPDJCF(FMJMJJHCMAN CMNEDOHOKIA, JGJKIMKLDPL AHPJJNGOIJO);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct JGJKIMKLDPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity CCHOHIEEHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager FMCNCDMBJDH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA270", Offset = "0x1FE9070", VA = "0x181FEA270")]
	public JGJKIMKLDPL(Entity CCHOHIEEHEH, EntityManager FMCNCDMBJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x23BF550", Offset = "0x23BE350", VA = "0x1823BF550")]
	public void KLJMIKDFPBF<T>(T GNLEHBFFNFG) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x23BF4D0", Offset = "0x23BE2D0", VA = "0x1823BF4D0")]
	public void ENJMMIOMOGN<T>(T GNLEHBFFNFG) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5DA5090", Offset = "0x5DA3E90", VA = "0x185DA5090")]
	public void KNJENDFNPGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NADKLGCBGPO
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(NJGEKDIELMJ, FMJMJJHCMAN)> DLBCJGGIHAG();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class GMEJAKANLFL : FIEEDLLEKHJ
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x772100", Offset = "0x770F00", VA = "0x180772100")]
	public GMEJAKANLFL()
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
