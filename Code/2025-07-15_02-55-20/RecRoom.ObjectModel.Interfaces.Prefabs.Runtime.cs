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
public class ABALAPDOPBL : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x230C7E0", Offset = "0x230B3E0", VA = "0x18230C7E0")]
	public ABALAPDOPBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CJDAFHMOBLC
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IEAJHOEMDPD(RRObjectPrefabData JBGFIFPOODI, OKMKGBMPEPM AOLOAOCMIFA);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(Guid, IBLPJFKLOID, ComponentTypeList, HKDOBNJGKIJ)> EJLIBLECPDH(NativeArray<(LDLEEKNJJFJ primitiveType, IBLPJFKLOID prefabType)> HINMBLJHMNM);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void HKDOBNJGKIJ(IBLPJFKLOID JBGFIFPOODI, OKMKGBMPEPM AOLOAOCMIFA);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct OKMKGBMPEPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity CGLPEGHHGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager HFPCKBDCDBJ;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2FAD810", Offset = "0x2FAC410", VA = "0x182FAD810")]
	public OKMKGBMPEPM(Entity CGLPEGHHGMM, EntityManager HFPCKBDCDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3E02B30", Offset = "0x3E01730", VA = "0x183E02B30")]
	public void IEFFBEILLPC<T>(T BKMPCFIAHIG) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3E02D50", Offset = "0x3E01950", VA = "0x183E02D50")]
	public void OPCELHLAHIC<T>(T BKMPCFIAHIG) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x82C4070", Offset = "0x82C2C70", VA = "0x1882C4070")]
	public void KGPEHJOFLFD()
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
