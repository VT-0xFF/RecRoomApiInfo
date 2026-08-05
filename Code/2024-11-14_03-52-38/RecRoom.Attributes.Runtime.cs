using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class OAJPENABABE : OMMNAOOCBKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string MIHMHBFPOBJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6BBA810", Offset = "0x6BB9C10", VA = "0x186BBA810")]
	public OAJPENABABE(string GOOFMPBOHHP, string MIHMHBFPOBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class PONPEBAFNFL : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string JCHMCBNODFE;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6BBAA30", Offset = "0x6BB9E30", VA = "0x186BBAA30")]
	public PONPEBAFNFL(string JCHMCBNODFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum AHBKOCJDDCB
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
public class PCIEPDMGHOH : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6BBA580", Offset = "0x6BB9980", VA = "0x186BBA580")]
	public PCIEPDMGHOH(AHBKOCJDDCB EKNPHEPNHJD = AHBKOCJDDCB.Self, bool LDFEMKJHKGO = false, bool FKPHKPGOOFE = false, bool LNACJEFCMDD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NPDKFMGDACO : PCIEPDMGHOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type LOEAGHNHLDP;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6BBA7A0", Offset = "0x6BB9BA0", VA = "0x186BBA7A0")]
	public NPDKFMGDACO(Type IBIOMPDEFKL, AHBKOCJDDCB EKNPHEPNHJD = AHBKOCJDDCB.Self, bool LDFEMKJHKGO = false, bool FKPHKPGOOFE = false, bool LNACJEFCMDD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class BLMMAJBEPMF : PCIEPDMGHOH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6BBA580", Offset = "0x6BB9980", VA = "0x186BBA580")]
	public BLMMAJBEPMF(AHBKOCJDDCB EKNPHEPNHJD = AHBKOCJDDCB.Self, bool LDFEMKJHKGO = false, bool FKPHKPGOOFE = false, bool LNACJEFCMDD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class CILHNCBGOPK : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum LKKIDOAIMJJ
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
	public readonly string KJNFHDLCDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly LKKIDOAIMJJ EKNPHEPNHJD;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6BBA5D0", Offset = "0x6BB99D0", VA = "0x186BBA5D0")]
	public CILHNCBGOPK(string KJNFHDLCDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x611C5A0", Offset = "0x611B9A0", VA = "0x18611C5A0")]
	public CILHNCBGOPK(string KJNFHDLCDNH, LKKIDOAIMJJ EKNPHEPNHJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class OMMNAOOCBKL : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string GOOFMPBOHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool LDEEPHCJOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] IJHMJPFOCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool ACONEAMNCPF;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6BBA930", Offset = "0x6BB9D30", VA = "0x186BBA930")]
	public OMMNAOOCBKL(string GOOFMPBOHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6BBA6C0", Offset = "0x6BB9AC0", VA = "0x186BBA6C0")]
	public OMMNAOOCBKL(string GOOFMPBOHHP, object GIJMPJHDKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6BBA660", Offset = "0x6BB9A60", VA = "0x186BBA660")]
	public OMMNAOOCBKL(string GOOFMPBOHHP, params object[] IJHMJPFOCLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class MKMFCEIDCBA : OMMNAOOCBKL
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6BBA6C0", Offset = "0x6BB9AC0", VA = "0x186BBA6C0")]
	public MKMFCEIDCBA(string GOOFMPBOHHP, object GIJMPJHDKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6BBA660", Offset = "0x6BB9A60", VA = "0x186BBA660")]
	public MKMFCEIDCBA(string GOOFMPBOHHP, params object[] IJHMJPFOCLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MHLJBAJDPKK : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool FDHAGBHJBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string DEBIECLLFMJ;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6BBA610", Offset = "0x6BB9A10", VA = "0x186BBA610")]
	public MHLJBAJDPKK(string KPOGLGNAOBM, bool EIICKGNAGOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GHJGPMPCJPG : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1970D50", Offset = "0x1970150", VA = "0x181970D50")]
	public GHJGPMPCJPG()
	{
	}
}
namespace RecRoom.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1970D50", Offset = "0x1970150", VA = "0x181970D50")]
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
