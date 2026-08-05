using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class FJAFJLIMCIH : EDIEJGINKKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string MOPIOLEAGGF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x69EBC40", Offset = "0x69EA240", VA = "0x1869EBC40")]
	public FJAFJLIMCIH(string CAONIDNAKLI, string MOPIOLEAGGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class NGPLOAPCPBG : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string EPBBLNFKIKN;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x69EBE40", Offset = "0x69EA440", VA = "0x1869EBE40")]
	public NGPLOAPCPBG(string EPBBLNFKIKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum LPFNGFMJOGK
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
public class JLEDHNACBFM : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69EBD60", Offset = "0x69EA360", VA = "0x1869EBD60")]
	public JLEDHNACBFM(LPFNGFMJOGK JLAAKHANEHC = LPFNGFMJOGK.Self, bool HDKFMKDPMFI = false, bool KHNMDBGHDFL = false, bool LIHJOOHKODH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DMLHKFHLAJN : JLEDHNACBFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type ODCCIEHODJK;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69EB990", Offset = "0x69E9F90", VA = "0x1869EB990")]
	public DMLHKFHLAJN(Type BKABOACLAIH, LPFNGFMJOGK JLAAKHANEHC = LPFNGFMJOGK.Self, bool HDKFMKDPMFI = false, bool KHNMDBGHDFL = false, bool LIHJOOHKODH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HELBAACNMJG : JLEDHNACBFM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69EBD60", Offset = "0x69EA360", VA = "0x1869EBD60")]
	public HELBAACNMJG(LPFNGFMJOGK JLAAKHANEHC = LPFNGFMJOGK.Self, bool HDKFMKDPMFI = false, bool KHNMDBGHDFL = false, bool LIHJOOHKODH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class LLGJFJDKLBI : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum HOFICLIIJOM
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
	public readonly string FDDGJBJOOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly HOFICLIIJOM JLAAKHANEHC;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x69EBE00", Offset = "0x69EA400", VA = "0x1869EBE00")]
	public LLGJFJDKLBI(string FDDGJBJOOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5F75BD0", Offset = "0x5F741D0", VA = "0x185F75BD0")]
	public LLGJFJDKLBI(string FDDGJBJOOPA, HOFICLIIJOM JLAAKHANEHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class EDIEJGINKKE : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string CAONIDNAKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool MIOLBHEBJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] IBGGGAHLGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool NBIFMNJCHID;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x69EBA60", Offset = "0x69EA060", VA = "0x1869EBA60")]
	public EDIEJGINKKE(string CAONIDNAKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x69EBB60", Offset = "0x69EA160", VA = "0x1869EBB60")]
	public EDIEJGINKKE(string CAONIDNAKLI, object NJBPFEDKGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x69EBA00", Offset = "0x69EA000", VA = "0x1869EBA00")]
	public EDIEJGINKKE(string CAONIDNAKLI, params object[] IBGGGAHLGLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HFMKMEIGOCI : EDIEJGINKKE
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x69EBB60", Offset = "0x69EA160", VA = "0x1869EBB60")]
	public HFMKMEIGOCI(string CAONIDNAKLI, object NJBPFEDKGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x69EBA00", Offset = "0x69EA000", VA = "0x1869EBA00")]
	public HFMKMEIGOCI(string CAONIDNAKLI, params object[] IBGGGAHLGLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class IFCIJDKMDFD : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool DBDBKCLHADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string GIFEPHJDHFJ;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x69EBDB0", Offset = "0x69EA3B0", VA = "0x1869EBDB0")]
	public IFCIJDKMDFD(string IBEEJFNFPJO, bool DILHPIBEHCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class JIIDCMOFLHE : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x16E4740", Offset = "0x16E2D40", VA = "0x1816E4740")]
	public JIIDCMOFLHE()
	{
	}
}
namespace RecRoom.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x16E4740", Offset = "0x16E2D40", VA = "0x1816E4740")]
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
