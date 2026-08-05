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
public class POFBDFJDFPC : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x21EE890", Offset = "0x21ED290", VA = "0x1821EE890")]
	public POFBDFJDFPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HBDEHHFLKJN
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DJODPCHDEHJ(RRObjectPrefabData JKDPGJIAJNJ, HFFMOBIFBDD LOOIBDJHCJC);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(Guid, PJPJEACNBPH, ComponentTypeList, GELIEPGGDCG)> DODDFLBPFFL(NativeArray<(AMKAGOPDJAP primitiveType, PJPJEACNBPH prefabType)> HAHMLNCEPFG);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void GELIEPGGDCG(PJPJEACNBPH JKDPGJIAJNJ, HFFMOBIFBDD LOOIBDJHCJC);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct HFFMOBIFBDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity FCFDGFFMMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager CBHCEEBBPPJ;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2FDA7B0", Offset = "0x2FD91B0", VA = "0x182FDA7B0")]
	public HFFMOBIFBDD(Entity FCFDGFFMMDF, EntityManager CBHCEEBBPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3A7D4A0", Offset = "0x3A7BEA0", VA = "0x183A7D4A0")]
	public void DGDFODDEBEH<T>(T PCDAHJCDHHF) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3A7D6C0", Offset = "0x3A7C0C0", VA = "0x183A7D6C0")]
	public void JFMAGGBHAJL<T>(T PCDAHJCDHHF) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7F0A400", Offset = "0x7F08E00", VA = "0x187F0A400")]
	public void FBGNOHLJKEE()
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
