using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class BJIIGLMKKNF : CGOLJFLDDGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string NCOKJEODALD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7065080", Offset = "0x7064280", VA = "0x187065080")]
	public BJIIGLMKKNF(string JMJKLGIHBKP, string NCOKJEODALD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class LEFGAENJNOE : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string OIHJHCKLDAI;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7065530", Offset = "0x7064730", VA = "0x187065530")]
	public LEFGAENJNOE(string OIHJHCKLDAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum FFILGMALDDB
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
public class PJAPKCLJNLP : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x70654E0", Offset = "0x70646E0", VA = "0x1870654E0")]
	public PJAPKCLJNLP(FFILGMALDDB MDOOANEGCAH = FFILGMALDDB.Self, bool BCALKGMPEDP = false, bool MLFFNKHPPMO = false, bool CDPAINKCHHO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DFJIMPNCADC : PJAPKCLJNLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type CGLDPMPGJPA;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7065430", Offset = "0x7064630", VA = "0x187065430")]
	public DFJIMPNCADC(Type CCPDCKADPME, FFILGMALDDB MDOOANEGCAH = FFILGMALDDB.Self, bool BCALKGMPEDP = false, bool MLFFNKHPPMO = false, bool CDPAINKCHHO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HMLBDBMBBPE : PJAPKCLJNLP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x70654E0", Offset = "0x70646E0", VA = "0x1870654E0")]
	public HMLBDBMBBPE(FFILGMALDDB MDOOANEGCAH = FFILGMALDDB.Self, bool BCALKGMPEDP = false, bool MLFFNKHPPMO = false, bool CDPAINKCHHO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class DOCGPFCJDCE : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum FGEEHANPMKA
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
	public readonly string MMICDODOBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly FGEEHANPMKA MDOOANEGCAH;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x70654A0", Offset = "0x70646A0", VA = "0x1870654A0")]
	public DOCGPFCJDCE(string MMICDODOBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x65913B0", Offset = "0x65905B0", VA = "0x1865913B0")]
	public DOCGPFCJDCE(string MMICDODOBLD, FGEEHANPMKA MDOOANEGCAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class CGOLJFLDDGE : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string JMJKLGIHBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool DHNBFHEHFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] MJCMOLDPIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool KGGJPGLFHCJ;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7065280", Offset = "0x7064480", VA = "0x187065280")]
	public CGOLJFLDDGE(string JMJKLGIHBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x70651A0", Offset = "0x70643A0", VA = "0x1870651A0")]
	public CGOLJFLDDGE(string JMJKLGIHBKP, object GPHPICGBLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7065380", Offset = "0x7064580", VA = "0x187065380")]
	public CGOLJFLDDGE(string JMJKLGIHBKP, params object[] MJCMOLDPIMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class PFEKCLMFDNF : CGOLJFLDDGE
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x70651A0", Offset = "0x70643A0", VA = "0x1870651A0")]
	public PFEKCLMFDNF(string JMJKLGIHBKP, object GPHPICGBLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7065380", Offset = "0x7064580", VA = "0x187065380")]
	public PFEKCLMFDNF(string JMJKLGIHBKP, params object[] MJCMOLDPIMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class DEEOGCDHHBN : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool HLNFHIJPGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string PIABEGJKFCG;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x70653E0", Offset = "0x70645E0", VA = "0x1870653E0")]
	public DEEOGCDHHBN(string LBIDKKNCBKN, bool DFKEBBHMBBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class ELPONOJKHIA : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7970", Offset = "0x1DC6B70", VA = "0x181DC7970")]
	public ELPONOJKHIA()
	{
	}
}
namespace RecRoom.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7970", Offset = "0x1DC6B70", VA = "0x181DC7970")]
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
