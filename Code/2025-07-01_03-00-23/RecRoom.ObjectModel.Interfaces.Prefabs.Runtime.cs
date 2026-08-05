using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.DataLayer;
using Unity.Collections;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[AttributeUsage(AttributeTargets.Class)]
public class LIDJJPCHLKK : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2253320", Offset = "0x2251920", VA = "0x182253320")]
	public LIDJJPCHLKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KAMFKCBMJGN
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCKEEMKFMKF(RRObjectPrefabData CANHKFFPDPD, ADLPPIIOFFK ACPAABKDECC);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(Guid, NIKILNIOMDI, ComponentTypeList, FIDEJFJIMPC)> HGNNEOCEOOF(NativeArray<(NKGGCFMEFLF primitiveType, NIKILNIOMDI prefabType)> IFJDILAECFE);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void FIDEJFJIMPC(NIKILNIOMDI CANHKFFPDPD, ADLPPIIOFFK ACPAABKDECC);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct ADLPPIIOFFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity DFPJIKCEODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager MAHCJNEKFMD;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x30811E0", Offset = "0x307F7E0", VA = "0x1830811E0")]
	public ADLPPIIOFFK(Entity DFPJIKCEODG, EntityManager MAHCJNEKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x30AF040", Offset = "0x30AD640", VA = "0x1830AF040")]
	public void BNAKHNGOEHD<T>(T KKGBKLFKCPO) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x30AF260", Offset = "0x30AD860", VA = "0x1830AF260")]
	public void MHDDCKBNABA<T>(T KKGBKLFKCPO) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x816DE10", Offset = "0x816C410", VA = "0x18816DE10")]
	public void GFJEPNBIAIF()
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
