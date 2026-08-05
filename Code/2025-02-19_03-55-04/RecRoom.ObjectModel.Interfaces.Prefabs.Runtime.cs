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
public class OCFCJCCEJGM : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1DE31B0", Offset = "0x1DE1DB0", VA = "0x181DE31B0")]
	public OCFCJCCEJGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FFPKIDPPGBI
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ALDGCJFMAGD(RRObjectPrefabData FDCILKKFHHF, PPMJLHMOGJN JKNLFOGOHCB);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(Guid, MCEIIDDCFHJ, ComponentTypeList, EKNDCLMHNJJ)> AHBGHGBEAML(NativeArray<(PKHCDPIAIHH primitiveType, MCEIIDDCFHJ prefabType)> HGHCNKKGBGK);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void EKNDCLMHNJJ(MCEIIDDCFHJ FDCILKKFHHF, PPMJLHMOGJN JKNLFOGOHCB);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct PPMJLHMOGJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity CANLONBNOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager BJAJJLPDBMA;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B71B40", Offset = "0x2B70740", VA = "0x182B71B40")]
	public PPMJLHMOGJN(Entity CANLONBNOKL, EntityManager BJAJJLPDBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x35627D0", Offset = "0x35613D0", VA = "0x1835627D0")]
	public void BGCBAJHAPLO<T>(T MPDLOLIOGJL) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x35629F0", Offset = "0x35615F0", VA = "0x1835629F0")]
	public void NMHEEGINAKD<T>(T MPDLOLIOGJL) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x760A000", Offset = "0x7608C00", VA = "0x18760A000")]
	public void ONEDENNHFNL()
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
