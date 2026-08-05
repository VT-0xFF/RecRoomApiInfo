using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class BPDJOKCLMCP : AEDBOPBHPPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string FPCGDBMHIPC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6071860", Offset = "0x6070C60", VA = "0x186071860")]
	public BPDJOKCLMCP(string LNJIOJAKOAO, string FPCGDBMHIPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class OIDNNNPHLFL : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string NNONNOLHPBB;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7CCD80", Offset = "0x7CC180", VA = "0x1807CCD80")]
	public OIDNNNPHLFL(string NNONNOLHPBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum FMDIPNBCKBB
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Self,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Parent,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Children,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	SelfAndParent,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	SelfAndChildren,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NestedParent
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GIMHEFLPFNM : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6071810", Offset = "0x6070C10", VA = "0x186071810")]
	public GIMHEFLPFNM(FMDIPNBCKBB NBMJAHOKHAI = FMDIPNBCKBB.Self, bool NLCFDOFHADC = false, bool JPINHBJLBJN = false, bool DBMKJOHIMLJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JAGIFIAPIIA : GIMHEFLPFNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type PNMJBGIANPG;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60719C0", Offset = "0x6070DC0", VA = "0x1860719C0")]
	public JAGIFIAPIIA(Type AKAAHGBAOJJ, FMDIPNBCKBB NBMJAHOKHAI = FMDIPNBCKBB.Self, bool NLCFDOFHADC = false, bool JPINHBJLBJN = false, bool DBMKJOHIMLJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class APNJDFGDCGH : GIMHEFLPFNM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6071810", Offset = "0x6070C10", VA = "0x186071810")]
	public APNJDFGDCGH(FMDIPNBCKBB NBMJAHOKHAI = FMDIPNBCKBB.Self, bool NLCFDOFHADC = false, bool JPINHBJLBJN = false, bool DBMKJOHIMLJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class DANCHJPBCFC : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum BHHPGOHMHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		Info,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		Error
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly string EAEHBBGACLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly BHHPGOHMHDJ NBMJAHOKHAI;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6071980", Offset = "0x6070D80", VA = "0x186071980")]
	public DANCHJPBCFC(string EAEHBBGACLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5635900", Offset = "0x5634D00", VA = "0x185635900")]
	public DANCHJPBCFC(string EAEHBBGACLB, BHHPGOHMHDJ NBMJAHOKHAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class AEDBOPBHPPO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string LNJIOJAKOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool ENEOLKDNNIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] HAFIGKODAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool CJFLNOCBKOP;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6071580", Offset = "0x6070980", VA = "0x186071580")]
	public AEDBOPBHPPO(string LNJIOJAKOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6071680", Offset = "0x6070A80", VA = "0x186071680")]
	public AEDBOPBHPPO(string LNJIOJAKOAO, object GDFFNIIAFOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6071760", Offset = "0x6070B60", VA = "0x186071760")]
	public AEDBOPBHPPO(string LNJIOJAKOAO, params object[] HAFIGKODAMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class MMFAKPHGBCM : AEDBOPBHPPO
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6071680", Offset = "0x6070A80", VA = "0x186071680")]
	public MMFAKPHGBCM(string LNJIOJAKOAO, object GDFFNIIAFOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6071760", Offset = "0x6070B60", VA = "0x186071760")]
	public MMFAKPHGBCM(string LNJIOJAKOAO, params object[] HAFIGKODAMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class AOPOBEKJEIL : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool IPMIMIKLNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string BGFJNKEGGEE;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x60717C0", Offset = "0x6070BC0", VA = "0x1860717C0")]
	public AOPOBEKJEIL(string EPOPAGFMGKA, bool GLGMJDHIGPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class BBGIKDJILDK : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7CD100", Offset = "0x7CC500", VA = "0x1807CD100")]
	public BBGIKDJILDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IPAIEPBNPDL : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7CD100", Offset = "0x7CC500", VA = "0x1807CD100")]
	public IPAIEPBNPDL()
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
