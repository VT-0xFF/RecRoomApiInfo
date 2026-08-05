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
public class MFNMEOKJLDH : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x20278A0", Offset = "0x20260A0", VA = "0x1820278A0")]
	public MFNMEOKJLDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MIAEEGNJCEO
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HLLKOLICGGO(RRObjectPrefabData FGKCPBHGPJL, NDNDAAIKEHP ELEDGPNNOOP);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(Guid, CNKLPFBBNAN, ComponentTypeList, OOJNPNBCDHD)> DGCJDOFHNCF(NativeArray<(INNMCPGDHCO primitiveType, CNKLPFBBNAN prefabType)> OFACOOGGJPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void OOJNPNBCDHD(CNKLPFBBNAN FGKCPBHGPJL, NDNDAAIKEHP ELEDGPNNOOP);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct NDNDAAIKEHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity EAALLGNPDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager MIJJPMGKBJK;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2DC3380", Offset = "0x2DC1B80", VA = "0x182DC3380")]
	public NDNDAAIKEHP(Entity EAALLGNPDMK, EntityManager MIJJPMGKBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3925AD0", Offset = "0x39242D0", VA = "0x183925AD0")]
	public void AFOHMCJECDO<T>(T OPMIAMEJKDH) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3925CF0", Offset = "0x39244F0", VA = "0x183925CF0")]
	public void LMLOICIPAKH<T>(T OPMIAMEJKDH) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2F30", Offset = "0x7CA1730", VA = "0x187CA2F30")]
	public void HJKBGEPJHPD()
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
