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
public class CMGMACNDKDB : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1E0FC40", Offset = "0x1E0E240", VA = "0x181E0FC40")]
	public CMGMACNDKDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FCAKBKBLFBN
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NBDMCDALFNE(RRObjectPrefabData GHJDJHIELJH, PGCFGFFDLLL LDHEODIBLPB);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(Guid, LBJDMFOKJAE, ComponentTypeList, MHAPMIAJNKI)> DFLPHEPHGEF(NativeArray<(OFHIFDOIEMG primitiveType, LBJDMFOKJAE prefabType)> KADGKKNOFPN);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void MHAPMIAJNKI(LBJDMFOKJAE GHJDJHIELJH, PGCFGFFDLLL LDHEODIBLPB);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct PGCFGFFDLLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity FCJGDHPNMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager IDCNJMKKJFI;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2BCE740", Offset = "0x2BCCD40", VA = "0x182BCE740")]
	public PGCFGFFDLLL(Entity FCJGDHPNMHF, EntityManager IDCNJMKKJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3606FC0", Offset = "0x36055C0", VA = "0x183606FC0")]
	public void ECFLGDLFBIO<T>(T KBGCCIOIGBD) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x36071E0", Offset = "0x36057E0", VA = "0x1836071E0")]
	public void EOJEENGKDLI<T>(T KBGCCIOIGBD) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7671740", Offset = "0x766FD40", VA = "0x187671740")]
	public void HGGAHLDFBAC()
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
