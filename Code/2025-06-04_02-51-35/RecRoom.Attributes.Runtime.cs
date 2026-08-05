using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class HIENMNNODBM : IKNPDEEBCLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string POAOOMHJGGA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8EB0", Offset = "0x7DC76B0", VA = "0x187DC8EB0")]
	public HIENMNNODBM(string KAICJACLIFJ, string POAOOMHJGGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class PIOPOLHPHDL : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string FENNLOAPDNN;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7DC9110", Offset = "0x7DC7910", VA = "0x187DC9110")]
	public PIOPOLHPHDL(string FENNLOAPDNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CGAFHOMJNOP
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
public class GKBMICLOBGF : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8E10", Offset = "0x7DC7610", VA = "0x187DC8E10")]
	public GKBMICLOBGF(CGAFHOMJNOP CEPGAJKBPDM = CGAFHOMJNOP.Self, bool JEJLLNGFIHM = false, bool GIKJGFPEMDE = false, bool PGPBMHENEHI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PLKFMNAADIG : GKBMICLOBGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type COGGILNGNMC;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7DC9150", Offset = "0x7DC7950", VA = "0x187DC9150")]
	public PLKFMNAADIG(Type DHBKKIIHMHJ, CGAFHOMJNOP CEPGAJKBPDM = CGAFHOMJNOP.Self, bool JEJLLNGFIHM = false, bool GIKJGFPEMDE = false, bool PGPBMHENEHI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class GFEALGLPKIM : GKBMICLOBGF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8E10", Offset = "0x7DC7610", VA = "0x187DC8E10")]
	public GFEALGLPKIM(CGAFHOMJNOP CEPGAJKBPDM = CGAFHOMJNOP.Self, bool JEJLLNGFIHM = false, bool GIKJGFPEMDE = false, bool PGPBMHENEHI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class PICPJOFKIIE : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum PJMDNJKEMBH
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
	public readonly string HFGOALBMNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly PJMDNJKEMBH CEPGAJKBPDM;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7DC90D0", Offset = "0x7DC78D0", VA = "0x187DC90D0")]
	public PICPJOFKIIE(string HFGOALBMNDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x71E7200", Offset = "0x71E5A00", VA = "0x1871E7200")]
	public PICPJOFKIIE(string HFGOALBMNDM, PJMDNJKEMBH CEPGAJKBPDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class IKNPDEEBCLA : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string KAICJACLIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool CGCFLNNBNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] PFKMJFBIFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool BPCOFJILFJC;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8FD0", Offset = "0x7DC77D0", VA = "0x187DC8FD0")]
	public IKNPDEEBCLA(string KAICJACLIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8CD0", Offset = "0x7DC74D0", VA = "0x187DC8CD0")]
	public IKNPDEEBCLA(string KAICJACLIFJ, object GGMEBIAHAGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8DB0", Offset = "0x7DC75B0", VA = "0x187DC8DB0")]
	public IKNPDEEBCLA(string KAICJACLIFJ, params object[] PFKMJFBIFNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class EGLKJGOHKNC : IKNPDEEBCLA
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8CD0", Offset = "0x7DC74D0", VA = "0x187DC8CD0")]
	public EGLKJGOHKNC(string KAICJACLIFJ, object GGMEBIAHAGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8DB0", Offset = "0x7DC75B0", VA = "0x187DC8DB0")]
	public EGLKJGOHKNC(string KAICJACLIFJ, params object[] PFKMJFBIFNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class GGKANFOAMJL : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool ILGNEGALNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string CMOGHCNABIJ;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8E60", Offset = "0x7DC7660", VA = "0x187DC8E60")]
	public GGKANFOAMJL(string HBNKGHLPDMN, bool KPCONIECCEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GNLKKCJEBLF : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x21777B0", Offset = "0x2175FB0", VA = "0x1821777B0")]
	public GNLKKCJEBLF()
	{
	}
}
namespace RecRoom.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x21777B0", Offset = "0x2175FB0", VA = "0x1821777B0")]
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
