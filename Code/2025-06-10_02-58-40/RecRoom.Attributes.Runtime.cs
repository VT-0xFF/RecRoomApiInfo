using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class FDKJACDCPPI : DGHDPMNMPGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string JEHCGDDFJMK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C830", Offset = "0x7A7BA30", VA = "0x187A7C830")]
	public FDKJACDCPPI(string LJHODHAIELH, string JEHCGDDFJMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class CKPFOJOACME : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string EDFCMNILCDA;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C6F0", Offset = "0x7A7B8F0", VA = "0x187A7C6F0")]
	public CKPFOJOACME(string EDFCMNILCDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CFJMFGLCHFI
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
public class GBCGIPBAICF : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C950", Offset = "0x7A7BB50", VA = "0x187A7C950")]
	public GBCGIPBAICF(CFJMFGLCHFI GDHKDBJPDLG = CFJMFGLCHFI.Self, bool IJCMLEPAPOO = false, bool CONPFDCAIOL = false, bool DDGBDBLDBPI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CGDMEAEFEAF : GBCGIPBAICF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type KELFONKIBPH;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C680", Offset = "0x7A7B880", VA = "0x187A7C680")]
	public CGDMEAEFEAF(Type IPJHHEJNJFM, CFJMFGLCHFI GDHKDBJPDLG = CFJMFGLCHFI.Self, bool IJCMLEPAPOO = false, bool CONPFDCAIOL = false, bool DDGBDBLDBPI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class GOJJDCGGJEB : GBCGIPBAICF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C950", Offset = "0x7A7BB50", VA = "0x187A7C950")]
	public GOJJDCGGJEB(CFJMFGLCHFI GDHKDBJPDLG = CFJMFGLCHFI.Self, bool IJCMLEPAPOO = false, bool CONPFDCAIOL = false, bool DDGBDBLDBPI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class MJKKFDKJPDJ : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum KMFFJLFHOKI
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
	public readonly string LIHGFEBAGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly KMFFJLFHOKI GDHKDBJPDLG;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C9A0", Offset = "0x7A7BBA0", VA = "0x187A7C9A0")]
	public MJKKFDKJPDJ(string LIHGFEBAGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6E77680", Offset = "0x6E76880", VA = "0x186E77680")]
	public MJKKFDKJPDJ(string LIHGFEBAGDO, KMFFJLFHOKI GDHKDBJPDLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DGHDPMNMPGC : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string LJHODHAIELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool CLFHBLCDCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] FAPOJLHEIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool LADLJEOFNHA;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C730", Offset = "0x7A7B930", VA = "0x187A7C730")]
	public DGHDPMNMPGC(string LJHODHAIELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C540", Offset = "0x7A7B740", VA = "0x187A7C540")]
	public DGHDPMNMPGC(string LJHODHAIELH, object IKDPOBNMIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C620", Offset = "0x7A7B820", VA = "0x187A7C620")]
	public DGHDPMNMPGC(string LJHODHAIELH, params object[] FAPOJLHEIMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class CCEPFAPNLDB : DGHDPMNMPGC
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C540", Offset = "0x7A7B740", VA = "0x187A7C540")]
	public CCEPFAPNLDB(string LJHODHAIELH, object IKDPOBNMIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C620", Offset = "0x7A7B820", VA = "0x187A7C620")]
	public CCEPFAPNLDB(string LJHODHAIELH, params object[] FAPOJLHEIMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PDPHFEDPDDO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool BJDLNNJMGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string FDHFLAFMDEO;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C9E0", Offset = "0x7A7BBE0", VA = "0x187A7C9E0")]
	public PDPHFEDPDDO(string OFCNCLIAIEM, bool FNMJAMNEIMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class JKBJHFIMJKP : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2189610", Offset = "0x2188810", VA = "0x182189610")]
	public JKBJHFIMJKP()
	{
	}
}
namespace RecRoom.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2189610", Offset = "0x2188810", VA = "0x182189610")]
		public ReadOnlyFieldAttribute()
		{
		}
	}
}
namespace Cpp2IlInjected
{
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
}
