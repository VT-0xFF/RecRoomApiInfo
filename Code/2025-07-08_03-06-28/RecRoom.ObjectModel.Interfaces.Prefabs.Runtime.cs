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
public class JIPIFJIHEON : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x22D54F0", Offset = "0x22D42F0", VA = "0x1822D54F0")]
	public JIPIFJIHEON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NMOMFBIDOHC
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MPIKCCLNDPP(RRObjectPrefabData OBELFNBLHMI, FLKAGOFPECO IJELEHGMFBL);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(Guid, IJNJABIEEEO, ComponentTypeList, NMNHJPKDHHA)> BFLGLACMNAI(NativeArray<(FHBADAKFFGA primitiveType, IJNJABIEEEO prefabType)> GCFAJLDPKLN);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void NMNHJPKDHHA(IJNJABIEEEO OBELFNBLHMI, FLKAGOFPECO IJELEHGMFBL);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FLKAGOFPECO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity ALBBAEBLONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager BIBOOAGIPAC;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x30BFEB0", Offset = "0x30BECB0", VA = "0x1830BFEB0")]
	public FLKAGOFPECO(Entity ALBBAEBLONH, EntityManager BIBOOAGIPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3B69180", Offset = "0x3B67F80", VA = "0x183B69180")]
	public void LAGAMOKKAFA<T>(T BNECONOIKOE) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3B690F0", Offset = "0x3B67EF0", VA = "0x183B690F0")]
	public void CMLFCNBJLIF<T>(T BNECONOIKOE) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x827FD50", Offset = "0x827EB50", VA = "0x18827FD50")]
	public void CKBHJFMEGMB()
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
