using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface AINOIDIFHHL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPKLFPOFPBL(PNGKBGHFHCL FLJFEHFLDDN, KHFBPNDFMPI FFGPADGOLLK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(PNGKBGHFHCL, ComponentTypeList, LEBINPAANEK)> LHICDEJNPPI(GGLAJHIGOIP LNBIIKNIDGD);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void LEBINPAANEK(PNGKBGHFHCL FLJFEHFLDDN, KHFBPNDFMPI FFGPADGOLLK);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct KHFBPNDFMPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity CHIBHEBBKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager IACEDLKPNGM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2285370", Offset = "0x2284570", VA = "0x182285370")]
	public KHFBPNDFMPI(Entity CHIBHEBBKEE, EntityManager IACEDLKPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x280C770", Offset = "0x280B970", VA = "0x18280C770")]
	public void FMPOAGCCLEO<T>(T AFCGKMGKPEF) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x280C990", Offset = "0x280BB90", VA = "0x18280C990")]
	public void IIPINOMMICG<T>(T AFCGKMGKPEF) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6211380", Offset = "0x6210580", VA = "0x186211380")]
	public void LEIGCHOLFKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GGLAJHIGOIP
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(ICFLEJACACG, PNGKBGHFHCL)> FICMCPKPMHE();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class EPKOLLODJOL : NBPFAHNIHDK
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB100", Offset = "0x7CA300", VA = "0x1807CB100")]
	public EPKOLLODJOL()
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
