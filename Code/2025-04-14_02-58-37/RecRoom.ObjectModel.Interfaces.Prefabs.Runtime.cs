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
public class HOACBELFNAH : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1F816B0", Offset = "0x1F800B0", VA = "0x181F816B0")]
	public HOACBELFNAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IPPBEFALFCB
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BJDBHGCALMM(RRObjectPrefabData NPLOBGMFJFK, ADKFICOKLKA HNKGMJGLANC);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(Guid, KPBBJPOJBPM, ComponentTypeList, ICICAMEOEOF)> MPFDHLFABMG(NativeArray<(AHBNMJGLFPD primitiveType, KPBBJPOJBPM prefabType)> OOIKMNANBGP);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void ICICAMEOEOF(KPBBJPOJBPM NPLOBGMFJFK, ADKFICOKLKA HNKGMJGLANC);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct ADKFICOKLKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity CGNAGBGLBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager IOCALHHKFGN;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2CF4BE0", Offset = "0x2CF35E0", VA = "0x182CF4BE0")]
	public ADKFICOKLKA(Entity CGNAGBGLBDK, EntityManager IOCALHHKFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3DA6B90", Offset = "0x3DA5590", VA = "0x183DA6B90")]
	public void PMHEFKOCJCJ<T>(T PPJFMHBDGNA) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3DA6B00", Offset = "0x3DA5500", VA = "0x183DA6B00")]
	public void NEJDGKBDHJF<T>(T PPJFMHBDGNA) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7A7F120", Offset = "0x7A7DB20", VA = "0x187A7F120")]
	public void KMOIMNIKGAE()
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
