using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Components;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PKIHCAEICPK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(PrimitiveShapeType, ObjectPrefabType)> KELACJHABOH();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class)]
public class GIBPJECIGLA : FPJMLFDHOCI
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x973F80", Offset = "0x973380", VA = "0x180973F80")]
	public GIBPJECIGLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KLDFDPAKAME
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BEAOADIAEFG(ObjectPrefabType MKAEEINGAAI, FMEPOLAGPHJ OKEPJGFDKDB);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(ObjectPrefabType, ComponentTypeList, CBECJMPBDBI)> KEEGGKBCPDM(PKIHCAEICPK OIJCAFALHBO);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void CBECJMPBDBI(ObjectPrefabType MKAEEINGAAI, FMEPOLAGPHJ OKEPJGFDKDB);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct FMEPOLAGPHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity HHCOBCONNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager CLFAKBGHDNF;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x83C9F0", Offset = "0x83BDF0", VA = "0x18083C9F0")]
	public FMEPOLAGPHJ(Entity HHCOBCONNMJ, EntityManager CLFAKBGHDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2FC34C0", Offset = "0x2FC28C0", VA = "0x182FC34C0")]
	public void BCHEBCENJDG<T>(T EOEKGHMNIDN) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2FC35A0", Offset = "0x2FC29A0", VA = "0x182FC35A0")]
	public void CFHGANKBNJA<T>(T EOEKGHMNIDN) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7630", Offset = "0x6FD6A30", VA = "0x186FD7630")]
	public void BPFLDMCIDAO()
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
