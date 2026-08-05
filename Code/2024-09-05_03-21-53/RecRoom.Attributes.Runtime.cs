using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class KFPOFLLJDEO : BENIALBDKBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string JCLNBEPBGDM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6A299F0", Offset = "0x6A283F0", VA = "0x186A299F0")]
	public KFPOFLLJDEO(string DMDAIKDMHNC, string JCLNBEPBGDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class MKFJHAEEAOE : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string HCBFKCNPKIG;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A29BC0", Offset = "0x6A285C0", VA = "0x186A29BC0")]
	public MKFJHAEEAOE(string HCBFKCNPKIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum BILCJMODHFE
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
public class EHNJJNMEJEA : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A29950", Offset = "0x6A28350", VA = "0x186A29950")]
	public EHNJJNMEJEA(BILCJMODHFE NNCMOPPBEEE = BILCJMODHFE.Self, bool AEPHBCDKIDN = false, bool KJPPPIPPLCM = false, bool BCICNBBHHLM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LCOGLBLDGNB : EHNJJNMEJEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type HDGLHAJJHPE;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6A29B10", Offset = "0x6A28510", VA = "0x186A29B10")]
	public LCOGLBLDGNB(Type KPKCHGIJJOH, BILCJMODHFE NNCMOPPBEEE = BILCJMODHFE.Self, bool AEPHBCDKIDN = false, bool KJPPPIPPLCM = false, bool BCICNBBHHLM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HIPIAIBDPPP : EHNJJNMEJEA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A29950", Offset = "0x6A28350", VA = "0x186A29950")]
	public HIPIAIBDPPP(BILCJMODHFE NNCMOPPBEEE = BILCJMODHFE.Self, bool AEPHBCDKIDN = false, bool KJPPPIPPLCM = false, bool BCICNBBHHLM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class MEFBILKFKGP : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum BEGHGAELFMA
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
	public readonly string KGHGMFKOBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly BEGHGAELFMA NNCMOPPBEEE;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6A29B80", Offset = "0x6A28580", VA = "0x186A29B80")]
	public MEFBILKFKGP(string KGHGMFKOBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5FAB940", Offset = "0x5FAA340", VA = "0x185FAB940")]
	public MEFBILKFKGP(string KGHGMFKOBOF, BEGHGAELFMA NNCMOPPBEEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class BENIALBDKBI : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string DMDAIKDMHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool LPGEHLFHIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] NIDBPJCEPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool GIAEKMOGMOJ;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A29850", Offset = "0x6A28250", VA = "0x186A29850")]
	public BENIALBDKBI(string DMDAIKDMHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6A29770", Offset = "0x6A28170", VA = "0x186A29770")]
	public BENIALBDKBI(string DMDAIKDMHNC, object CNBFMNBANAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6A29710", Offset = "0x6A28110", VA = "0x186A29710")]
	public BENIALBDKBI(string DMDAIKDMHNC, params object[] NIDBPJCEPIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LFEOIFAFOOC : BENIALBDKBI
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6A29770", Offset = "0x6A28170", VA = "0x186A29770")]
	public LFEOIFAFOOC(string DMDAIKDMHNC, object CNBFMNBANAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6A29710", Offset = "0x6A28110", VA = "0x186A29710")]
	public LFEOIFAFOOC(string DMDAIKDMHNC, params object[] NIDBPJCEPIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class HLDKNDMJNAA : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool NKINHBPLJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string LGCNFBGBHHJ;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6A299A0", Offset = "0x6A283A0", VA = "0x186A299A0")]
	public HLDKNDMJNAA(string DBEINCJBMNO, bool LKIPPNAPNMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class INPKCJGJBAA : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x16FBD20", Offset = "0x16FA720", VA = "0x1816FBD20")]
	public INPKCJGJBAA()
	{
	}
}
namespace RecRoom.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x16FBD20", Offset = "0x16FA720", VA = "0x1816FBD20")]
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
