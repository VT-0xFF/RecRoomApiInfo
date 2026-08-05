using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DJFBMPPJMIN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PKHMBBBFMGI(BKBMPOCGEPN AAFKJACPDJA, HKPLBFDJFEH CDAPMGFDBBG);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(BKBMPOCGEPN, ComponentTypeList, ENOJHHKJMBP)> GLEBMCNIKHJ(LLNEMMDMCJH CGPCFMHKHAL);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void ENOJHHKJMBP(BKBMPOCGEPN AAFKJACPDJA, HKPLBFDJFEH CDAPMGFDBBG);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct HKPLBFDJFEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity DPHKAEKJOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager MOHAGLEGECH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x294EB10", Offset = "0x294D310", VA = "0x18294EB10")]
	public HKPLBFDJFEH(Entity DPHKAEKJOIN, EntityManager MOHAGLEGECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x308A780", Offset = "0x3088F80", VA = "0x18308A780")]
	public void KLHHFEENEBM<T>(T INDENPJBLHO) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x308A9A0", Offset = "0x30891A0", VA = "0x18308A9A0")]
	public void KNJOMNHNENP<T>(T INDENPJBLHO) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7098250", Offset = "0x7096A50", VA = "0x187098250")]
	public void MAFGNMHBDMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LLNEMMDMCJH
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(KCDIPBECKHL, BKBMPOCGEPN)> GOGOMGGDCNI();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class OLHGIPHBPOG : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1A1FEA0", Offset = "0x1A1E6A0", VA = "0x181A1FEA0")]
	public OLHGIPHBPOG()
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
