using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class MBKFLHBLOPM : ADFPPDOJCKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string MCAGIGFFHDC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xD1B030", Offset = "0xD19830", VA = "0x180D1B030")]
	public MBKFLHBLOPM(string NGPNJFEBLFH, string MCAGIGFFHDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
public class EKIGKEJLIKA : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly Type PEPABBHGCLO;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xD1AF40", Offset = "0xD19740", VA = "0x180D1AF40")]
	public EKIGKEJLIKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x662790", Offset = "0x660F90", VA = "0x180662790")]
	public EKIGKEJLIKA(Type LMAOOKMELBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Field)]
public class MILMBKGAPML : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x521480", Offset = "0x51FC80", VA = "0x180521480")]
	public MILMBKGAPML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Field)]
public class JFLPKANDPLP : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly string DKCHEEPPPEO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xD1B000", Offset = "0xD19800", VA = "0x180D1B000")]
	public JFLPKANDPLP(string DKCHEEPPPEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum PCCPJPANDII
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Self,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Parent,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Children,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	SelfAndParent,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	SelfAndChildren,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	NestedParent
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class LBKCPHKKGJL : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xD1AEF0", Offset = "0xD196F0", VA = "0x180D1AEF0")]
	public LBKCPHKKGJL(PCCPJPANDII MIDEMNGPEAG = PCCPJPANDII.Self, bool IEHFDGNBINM = false, bool DDKNKNJPGJF = false, bool OCELLDBHIIB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class BMAOOHGMHGA : LBKCPHKKGJL
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xD1AEF0", Offset = "0xD196F0", VA = "0x180D1AEF0")]
	public BMAOOHGMHGA(PCCPJPANDII MIDEMNGPEAG = PCCPJPANDII.Self, bool IEHFDGNBINM = false, bool DDKNKNJPGJF = false, bool OCELLDBHIIB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Field)]
public class HGBPACNDMPD : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum BBOIMBFFCKL
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
	public readonly string OALIHJGHCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly BBOIMBFFCKL MIDEMNGPEAG;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xD1AF70", Offset = "0xD19770", VA = "0x180D1AF70")]
	public HGBPACNDMPD(string OALIHJGHCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xD1AFB0", Offset = "0xD197B0", VA = "0x180D1AFB0")]
	public HGBPACNDMPD(string OALIHJGHCAG, BBOIMBFFCKL MIDEMNGPEAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ADFPPDOJCKM : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string NGPNJFEBLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool AOEGAPPGLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] HBHBEEMIKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool PFGKBAJFNNB;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xD1AD90", Offset = "0xD19590", VA = "0x180D1AD90")]
	public ADFPPDOJCKM(string NGPNJFEBLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xD1ACB0", Offset = "0xD194B0", VA = "0x180D1ACB0")]
	public ADFPPDOJCKM(string NGPNJFEBLFH, object DHPPIOAHBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xD1AE90", Offset = "0xD19690", VA = "0x180D1AE90")]
	public ADFPPDOJCKM(string NGPNJFEBLFH, params object[] HBHBEEMIKEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class DIBODHADKFP : ADFPPDOJCKM
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xD1ACB0", Offset = "0xD194B0", VA = "0x180D1ACB0")]
	public DIBODHADKFP(string NGPNJFEBLFH, object DHPPIOAHBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xD1AE90", Offset = "0xD19690", VA = "0x180D1AE90")]
	public DIBODHADKFP(string NGPNJFEBLFH, params object[] HBHBEEMIKEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GBJKFFPEFMD : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6853A0", Offset = "0x683BA0", VA = "0x1806853A0")]
	public GBJKFFPEFMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class BGEBFJLHIKH : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6853A0", Offset = "0x683BA0", VA = "0x1806853A0")]
	public BGEBFJLHIKH()
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
