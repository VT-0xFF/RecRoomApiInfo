using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class FCOCPHEELKL : ICONPNPMJHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string DAPGDHBMFDC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x60B1900", Offset = "0x60B0700", VA = "0x1860B1900")]
	public FCOCPHEELKL(string MJOFHPHPKNF, string DAPGDHBMFDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class BKJAKGFOAKM : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string BBBPDDJMNFM;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7BEEC0", Offset = "0x7BDCC0", VA = "0x1807BEEC0")]
	public BKJAKGFOAKM(string BBBPDDJMNFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum KLKJAELFHOF
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
public class FHFEFOGEDAO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60B1A20", Offset = "0x60B0820", VA = "0x1860B1A20")]
	public FHFEFOGEDAO(KLKJAELFHOF DDEINLAGLLL = KLKJAELFHOF.Self, bool IKEAHNDDMNM = false, bool PKPFMOCCMDG = false, bool ALCKMJMCIBI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DIBKNKMGEAM : FHFEFOGEDAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type GJKFGBPIEJE;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60B1890", Offset = "0x60B0690", VA = "0x1860B1890")]
	public DIBKNKMGEAM(Type EKIKNKDHPAH, KLKJAELFHOF DDEINLAGLLL = KLKJAELFHOF.Self, bool IKEAHNDDMNM = false, bool PKPFMOCCMDG = false, bool ALCKMJMCIBI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class IMNLDENHNLG : FHFEFOGEDAO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60B1A20", Offset = "0x60B0820", VA = "0x1860B1A20")]
	public IMNLDENHNLG(KLKJAELFHOF DDEINLAGLLL = KLKJAELFHOF.Self, bool IKEAHNDDMNM = false, bool PKPFMOCCMDG = false, bool ALCKMJMCIBI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class IPKPBFLEAJM : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum IFLHHIEMCPF
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
	public readonly string BMOLPLMLBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly IFLHHIEMCPF DDEINLAGLLL;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60B1D00", Offset = "0x60B0B00", VA = "0x1860B1D00")]
	public IPKPBFLEAJM(string BMOLPLMLBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5678450", Offset = "0x5677250", VA = "0x185678450")]
	public IPKPBFLEAJM(string BMOLPLMLBGE, IFLHHIEMCPF DDEINLAGLLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class ICONPNPMJHG : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string MJOFHPHPKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool GGPCNPILODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] HGNJGBICDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool LEBFEGHHLMA;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60B1A70", Offset = "0x60B0870", VA = "0x1860B1A70")]
	public ICONPNPMJHG(string MJOFHPHPKNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x60B1B70", Offset = "0x60B0970", VA = "0x1860B1B70")]
	public ICONPNPMJHG(string MJOFHPHPKNF, object ECHEFOGEMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x60B1C50", Offset = "0x60B0A50", VA = "0x1860B1C50")]
	public ICONPNPMJHG(string MJOFHPHPKNF, params object[] HGNJGBICDIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class PEOPAEHDMNK : ICONPNPMJHG
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x60B1B70", Offset = "0x60B0970", VA = "0x1860B1B70")]
	public PEOPAEHDMNK(string MJOFHPHPKNF, object ECHEFOGEMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x60B1C50", Offset = "0x60B0A50", VA = "0x1860B1C50")]
	public PEOPAEHDMNK(string MJOFHPHPKNF, params object[] HGNJGBICDIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class IKJCHEOJGKG : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool JOGCMIHPCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string FAELHGJNEEH;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x60B1CB0", Offset = "0x60B0AB0", VA = "0x1860B1CB0")]
	public IKJCHEOJGKG(string BCEKBOBKMEO, bool CECKBIAALHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class DNKDDGHJLNC : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7BF230", Offset = "0x7BE030", VA = "0x1807BF230")]
	public DNKDDGHJLNC()
	{
	}
}
namespace RecRoom.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7BF230", Offset = "0x7BE030", VA = "0x1807BF230")]
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
