using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GALKPEJAGLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IENMGKKGCBL(LFJMPPMLIHF KCLAFPDDNOC, HGNCCMHJPNO EHACJCOECBP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(LFJMPPMLIHF, ComponentTypeList, GLGEDDKGNOD)> FIAMDCIPECG(LOLKNDDBPMJ BCMHMCIFKME);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void GLGEDDKGNOD(LFJMPPMLIHF KCLAFPDDNOC, HGNCCMHJPNO EHACJCOECBP);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct HGNCCMHJPNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity FOJNONDDGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager CAODHPOMABB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2433DA0", Offset = "0x2432FA0", VA = "0x182433DA0")]
	public HGNCCMHJPNO(Entity FOJNONDDGDN, EntityManager CAODHPOMABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x29BC130", Offset = "0x29BB330", VA = "0x1829BC130")]
	public void HNJFJKPNHAB<T>(T HLCKBKFCMPI) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x29BC0B0", Offset = "0x29BB2B0", VA = "0x1829BC0B0")]
	public void HELJBEHLKPI<T>(T HLCKBKFCMPI) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x64D2C90", Offset = "0x64D1E90", VA = "0x1864D2C90")]
	public void HGDAMGFMKCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LOLKNDDBPMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(MEENIEMELIG, LFJMPPMLIHF)> NAOHLBMOCHB();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class DMJMCHEOHGL : EACJPAMHPBE
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1409650", Offset = "0x1408850", VA = "0x181409650")]
	public DMJMCHEOHGL()
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
