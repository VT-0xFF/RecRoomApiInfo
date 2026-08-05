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
public class PIFGLDCMLBH : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x21777B0", Offset = "0x2175FB0", VA = "0x1821777B0")]
	public PIFGLDCMLBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HLOLIAADJKE
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GLNFMKFKNGF(RRObjectPrefabData HIGIPMBNHHD, DGDIHLACLMP BIGNAJOAKMM);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(Guid, OMOMKAHPFJK, ComponentTypeList, FNKMLKLGIEI)> HKIGGMJIDHN(NativeArray<(HBIFHMNPGDK primitiveType, OMOMKAHPFJK prefabType)> KBLHBPALFJG);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void FNKMLKLGIEI(OMOMKAHPFJK HIGIPMBNHHD, DGDIHLACLMP BIGNAJOAKMM);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct DGDIHLACLMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity JAOKKIIOCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager FAIGBHOGMGE;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2F3D7E0", Offset = "0x2F3BFE0", VA = "0x182F3D7E0")]
	public DGDIHLACLMP(Entity JAOKKIIOCBD, EntityManager FAIGBHOGMGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x37F95E0", Offset = "0x37F7DE0", VA = "0x1837F95E0")]
	public void NNLOAAEAPBJ<T>(T MGONBEDEDON) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x37F9550", Offset = "0x37F7D50", VA = "0x1837F9550")]
	public void NHOAOIEPCCC<T>(T MGONBEDEDON) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x815F730", Offset = "0x815DF30", VA = "0x18815F730")]
	public void OMHBPINLECI()
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
