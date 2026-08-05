using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class BDMAOABACOO : FKOECLOBFCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string IOALDLBLECF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7339130", Offset = "0x7337730", VA = "0x187339130")]
	public BDMAOABACOO(string PPFMKAFKACL, string IOALDLBLECF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class NGAEAKECLAC : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string IMCKKNIIFCP;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7339590", Offset = "0x7337B90", VA = "0x187339590")]
	public NGAEAKECLAC(string IMCKKNIIFCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum KCNGGJNCENB
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
public class ALEFAIIJNEI : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x73390E0", Offset = "0x73376E0", VA = "0x1873390E0")]
	public ALEFAIIJNEI(KCNGGJNCENB BMIPLDLMPCD = KCNGGJNCENB.Self, bool LKJGJPOGLDI = false, bool DKJJCJHBAGA = false, bool DNLCNECFKEG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MFCECJKPDOE : ALEFAIIJNEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type CHABGOLFHMB;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7339520", Offset = "0x7337B20", VA = "0x187339520")]
	public MFCECJKPDOE(Type MJMKJDODDFE, KCNGGJNCENB BMIPLDLMPCD = KCNGGJNCENB.Self, bool LKJGJPOGLDI = false, bool DKJJCJHBAGA = false, bool DNLCNECFKEG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class AICMCMODPDA : ALEFAIIJNEI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x73390E0", Offset = "0x73376E0", VA = "0x1873390E0")]
	public AICMCMODPDA(KCNGGJNCENB BMIPLDLMPCD = KCNGGJNCENB.Self, bool LKJGJPOGLDI = false, bool DKJJCJHBAGA = false, bool DNLCNECFKEG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class MDEDNPMFNHN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum PFIOCKJKHMO
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
	public readonly string JGKKKNKIGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly PFIOCKJKHMO BMIPLDLMPCD;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x73394E0", Offset = "0x7337AE0", VA = "0x1873394E0")]
	public MDEDNPMFNHN(string JGKKKNKIGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x67F80C0", Offset = "0x67F66C0", VA = "0x1867F80C0")]
	public MDEDNPMFNHN(string JGKKKNKIGEG, PFIOCKJKHMO BMIPLDLMPCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FKOECLOBFCN : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string PPFMKAFKACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool JBIBOCPAIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] KOLNMJCGFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool GPJCABKLDHA;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7339330", Offset = "0x7337930", VA = "0x187339330")]
	public FKOECLOBFCN(string PPFMKAFKACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7339250", Offset = "0x7337850", VA = "0x187339250")]
	public FKOECLOBFCN(string PPFMKAFKACL, object MKJDPFAMIKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7339430", Offset = "0x7337A30", VA = "0x187339430")]
	public FKOECLOBFCN(string PPFMKAFKACL, params object[] KOLNMJCGFGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class KHNFPPIAMPM : FKOECLOBFCN
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7339250", Offset = "0x7337850", VA = "0x187339250")]
	public KHNFPPIAMPM(string PPFMKAFKACL, object MKJDPFAMIKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7339430", Offset = "0x7337A30", VA = "0x187339430")]
	public KHNFPPIAMPM(string PPFMKAFKACL, params object[] KOLNMJCGFGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class JEDHGJFJKOB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool PJMIGPPJHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string KKKEANFJAOL;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7339490", Offset = "0x7337A90", VA = "0x187339490")]
	public JEDHGJFJKOB(string FGJEOOJDINN, bool KIPAHLGBOAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class NKGDJOKDBBA : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1E0FC40", Offset = "0x1E0E240", VA = "0x181E0FC40")]
	public NKGDJOKDBBA()
	{
	}
}
namespace RecRoom.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1E0FC40", Offset = "0x1E0E240", VA = "0x181E0FC40")]
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
