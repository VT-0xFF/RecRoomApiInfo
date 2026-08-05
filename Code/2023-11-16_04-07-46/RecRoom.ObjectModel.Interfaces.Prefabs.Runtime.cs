using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface LJIMMDKKIGF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFCCCIJCAAM(LBHIBFADKLF MMIOCMIOHFJ, HEAAOJHMDCG NBELFLBMGPG);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(LBHIBFADKLF, ComponentTypeList, GADCJBODHOA)> GBCCHOIBFNJ(AGCCMHJCCND HKJNODMOELK);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void GADCJBODHOA(LBHIBFADKLF MMIOCMIOHFJ, HEAAOJHMDCG NBELFLBMGPG);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct HEAAOJHMDCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity CFNJODNKJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager OHEFKBDAJBH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x20A1F00", Offset = "0x20A0F00", VA = "0x1820A1F00")]
	public HEAAOJHMDCG(Entity CFNJODNKJAM, EntityManager OHEFKBDAJBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x24FAD40", Offset = "0x24F9D40", VA = "0x1824FAD40")]
	public void GBPMDEJOJHE<T>(T APPJEOKOGAK) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x24FACC0", Offset = "0x24F9CC0", VA = "0x1824FACC0")]
	public void BGLEBMHICEO<T>(T APPJEOKOGAK) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7E10", Offset = "0x5EC6E10", VA = "0x185EC7E10")]
	public void MHBEIGODIGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface AGCCMHJCCND
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(EPBBLHAHLDD, LBHIBFADKLF)> ACBMIBADJMD();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class BHJCFCIEFOF : GBHCDPMMINH
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x780100", Offset = "0x77F100", VA = "0x180780100")]
	public BHJCFCIEFOF()
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
