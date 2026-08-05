using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface CCFHNOEHJDA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BAFPMBOLLIF(GPKGCNFDJCC LEGGGLNIAOM, EKKBBNGOMKG MPGHLPJKHCL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(GPKGCNFDJCC, ComponentTypeList, GHGNJELMMHP)> EFIDHNMIEEG(CCPNBGLJBDC LLOAICEJOAD);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void GHGNJELMMHP(GPKGCNFDJCC LEGGGLNIAOM, EKKBBNGOMKG MPGHLPJKHCL);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct EKKBBNGOMKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity HHHGBIJCKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager GMDAKDJOHKE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2029A50", Offset = "0x2028850", VA = "0x182029A50")]
	public EKKBBNGOMKG(Entity HHHGBIJCKBC, EntityManager GMDAKDJOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x224C5A0", Offset = "0x224B3A0", VA = "0x18224C5A0")]
	public void MFACMGCFCOL<T>(T POACLGOFKAJ) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x224C520", Offset = "0x224B320", VA = "0x18224C520")]
	public void FCCBDBNOEGB<T>(T POACLGOFKAJ) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E9E0", Offset = "0x5D4D7E0", VA = "0x185D4E9E0")]
	public void HPGIBEDBDLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CCPNBGLJBDC
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(JFBOGCJIFLL, GPKGCNFDJCC)> MAHNOIGMGPM();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class LJCDINFCCEK : ANIFJPLLIHB
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x76E100", Offset = "0x76CF00", VA = "0x18076E100")]
	public LJCDINFCCEK()
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
