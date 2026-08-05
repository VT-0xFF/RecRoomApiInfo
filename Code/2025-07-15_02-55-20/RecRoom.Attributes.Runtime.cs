using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class NOMFMKCPHLC : CIFBDHOOBHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string LJHHBJBHMKD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7F13C40", Offset = "0x7F12840", VA = "0x187F13C40")]
	public NOMFMKCPHLC(string GIACFJKKOEO, string LJHHBJBHMKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
public class EAAPGLCNECL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
	public EAAPGLCNECL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class JBAEFGAOAOM : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string FKGJLNAAKPL;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7F13BB0", Offset = "0x7F127B0", VA = "0x187F13BB0")]
	public JBAEFGAOAOM(string FKGJLNAAKPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum AFILHNGOOLF
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
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IODJOKMKDII : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7F13B60", Offset = "0x7F12760", VA = "0x187F13B60")]
	public IODJOKMKDII(AFILHNGOOLF MDCDODCGNEK = AFILHNGOOLF.Self, bool GCCHOKBJMJN = false, bool GHOLDPGEBFL = false, bool FOGPMMFNEFA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class ADDKBCDKDFB : IODJOKMKDII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type PCDIGEEFNDI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7F13870", Offset = "0x7F12470", VA = "0x187F13870")]
	public ADDKBCDKDFB(Type CDOKKLBAKCG, AFILHNGOOLF MDCDODCGNEK = AFILHNGOOLF.Self, bool GCCHOKBJMJN = false, bool GHOLDPGEBFL = false, bool FOGPMMFNEFA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class FBGDLCLCGKH : IODJOKMKDII
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7F13B60", Offset = "0x7F12760", VA = "0x187F13B60")]
	public FBGDLCLCGKH(AFILHNGOOLF MDCDODCGNEK = AFILHNGOOLF.Self, bool GCCHOKBJMJN = false, bool GHOLDPGEBFL = false, bool FOGPMMFNEFA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class BOJLALHEMGN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum NDLLOKGDBNI
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
	public readonly string BCBLEPPKJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly NDLLOKGDBNI MDCDODCGNEK;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7F138E0", Offset = "0x7F124E0", VA = "0x187F138E0")]
	public BOJLALHEMGN(string BCBLEPPKJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x72CF570", Offset = "0x72CE170", VA = "0x1872CF570")]
	public BOJLALHEMGN(string BCBLEPPKJPP, NDLLOKGDBNI MDCDODCGNEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class CIFBDHOOBHM : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string GIACFJKKOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool LJAONJHMMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] FHBDHLIGENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool FHNCIPJPIPK;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7F13A00", Offset = "0x7F12600", VA = "0x187F13A00")]
	public CIFBDHOOBHM(string GIACFJKKOEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7F13920", Offset = "0x7F12520", VA = "0x187F13920")]
	public CIFBDHOOBHM(string GIACFJKKOEO, object AHCJBCFKFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7F13B00", Offset = "0x7F12700", VA = "0x187F13B00")]
	public CIFBDHOOBHM(string GIACFJKKOEO, params object[] FHBDHLIGENO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PHMPACJICCI : CIFBDHOOBHM
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7F13920", Offset = "0x7F12520", VA = "0x187F13920")]
	public PHMPACJICCI(string GIACFJKKOEO, object AHCJBCFKFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7F13B00", Offset = "0x7F12700", VA = "0x187F13B00")]
	public PHMPACJICCI(string GIACFJKKOEO, params object[] FHBDHLIGENO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KFNNPBAOBFL : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool LBBNPMPAEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string DOEEGEAJGEO;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7F13BF0", Offset = "0x7F127F0", VA = "0x187F13BF0")]
	public KFNNPBAOBFL(string HIGFJJMOIKL, bool MNOKIOLOFFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class COPCFJKDPDB : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x230C7E0", Offset = "0x230B3E0", VA = "0x18230C7E0")]
	public COPCFJKDPDB()
	{
	}
}
namespace RecRoom.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x230C7E0", Offset = "0x230B3E0", VA = "0x18230C7E0")]
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
