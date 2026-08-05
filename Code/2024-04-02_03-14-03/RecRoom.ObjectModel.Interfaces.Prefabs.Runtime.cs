using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BGDHFBDGPHP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FMLGLPACJHJ(JDMDNBNFCKO HKKADAMFOHP, MBKIOKKJCAE AONBEGIIJII);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(JDMDNBNFCKO, ComponentTypeList, IGDNMGIPLDE)> IEOKKBOBFNG(AJGOOALBDGF FHEBBJPBOBK);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void IGDNMGIPLDE(JDMDNBNFCKO HKKADAMFOHP, MBKIOKKJCAE AONBEGIIJII);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct MBKIOKKJCAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity CMFPBPOIOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager DIINGHOOBHL;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x22D17D0", Offset = "0x22D03D0", VA = "0x1822D17D0")]
	public MBKIOKKJCAE(Entity CMFPBPOIOPE, EntityManager DIINGHOOBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2893AE0", Offset = "0x28926E0", VA = "0x182893AE0")]
	public void FNEEIDKMODG<T>(T BLKAHBIJBJO) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2893D00", Offset = "0x2892900", VA = "0x182893D00")]
	public void NGGMHHJIEKI<T>(T BLKAHBIJBJO) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x61E84E0", Offset = "0x61E70E0", VA = "0x1861E84E0")]
	public void BMNBCJAOLMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface AJGOOALBDGF
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(EBFEJIDFJIN, JDMDNBNFCKO)> LKPKDNKECMG();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class KLHLDIEOEIC : OGOPLFOLLPL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C0100", Offset = "0x7BED00", VA = "0x1807C0100")]
	public KLHLDIEOEIC()
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
