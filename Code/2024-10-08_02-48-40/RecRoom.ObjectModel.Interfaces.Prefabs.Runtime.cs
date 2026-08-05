using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface NCHLKAEHMGK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LFPPPAODEBE(INFHPJINHKD GFOIKJGPAHB, JFHHBBAOJFM EJMPALKKLNP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(INFHPJINHKD, ComponentTypeList, CILIIHEPONK)> BFBIIMCKINA(HKMGLDLHGCK HIBLPJDPNNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void CILIIHEPONK(INFHPJINHKD GFOIKJGPAHB, JFHHBBAOJFM EJMPALKKLNP);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct JFHHBBAOJFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity NCLCOHLPCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager FFFGHCELNHC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x27DF730", Offset = "0x27DE930", VA = "0x1827DF730")]
	public JFHHBBAOJFM(Entity NCLCOHLPCDH, EntityManager FFFGHCELNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2E739E0", Offset = "0x2E72BE0", VA = "0x182E739E0")]
	public void HPDIHAPBFNP<T>(T JECHHBGMFLN) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2E73960", Offset = "0x2E72B60", VA = "0x182E73960")]
	public void DOPABCIDHPN<T>(T JECHHBGMFLN) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6D76720", Offset = "0x6D75920", VA = "0x186D76720")]
	public void BIPJKANEGCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HKMGLDLHGCK
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(JKPCMEPKCKH, INFHPJINHKD)> BJANDPKPJIO();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class NJABPBDJLJJ : OKIICLHPAHL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1966710", Offset = "0x1965910", VA = "0x181966710")]
	public NJABPBDJLJJ()
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
