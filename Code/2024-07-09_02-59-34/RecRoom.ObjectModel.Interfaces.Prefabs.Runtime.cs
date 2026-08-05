using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface EOGPFEAPMFC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KBGMEHPLKHI(EBKFNFACOLI OEBDHGNIACG, JHIBEAMAOFG BKLCLBMCJAN);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(EBKFNFACOLI, ComponentTypeList, LIFCNNBENEE)> ANNJCLKCGNO(EHEOPCMLBPB JAMOMHOPJMD);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void LIFCNNBENEE(EBKFNFACOLI OEBDHGNIACG, JHIBEAMAOFG BKLCLBMCJAN);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct JHIBEAMAOFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity AOPPIDPOGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager LHOMFPBLGHH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x257EA90", Offset = "0x257D690", VA = "0x18257EA90")]
	public JHIBEAMAOFG(Entity AOPPIDPOGKL, EntityManager LHOMFPBLGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B9DC50", Offset = "0x2B9C850", VA = "0x182B9DC50")]
	public void IJGOPKKNHAN<T>(T IIPLJLPCLBC) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2B9DE70", Offset = "0x2B9CA70", VA = "0x182B9DE70")]
	public void JCBIFKDAFDN<T>(T IIPLJLPCLBC) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6AC2AE0", Offset = "0x6AC16E0", VA = "0x186AC2AE0")]
	public void DBNGAPMAIJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EHEOPCMLBPB
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(PPNDJOMCIKD, EBKFNFACOLI)> MNACLAGGNMK();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class LGDACCHPBOF : KOIKNKLCNMD
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x14EC7A0", Offset = "0x14EB3A0", VA = "0x1814EC7A0")]
	public LGDACCHPBOF()
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
