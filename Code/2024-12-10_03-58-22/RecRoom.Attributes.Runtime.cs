using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class MNBLJAPHOEI : ELBALDKMPMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string DCGIKHBEKNB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6A93E50", Offset = "0x6A92A50", VA = "0x186A93E50")]
	public MNBLJAPHOEI(string JHBKMLGOEGH, string DCGIKHBEKNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class LNIAJCDMOMF : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string OMKPHEFJBFI;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A93E10", Offset = "0x6A92A10", VA = "0x186A93E10")]
	public LNIAJCDMOMF(string OMKPHEFJBFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum KOFDDAAAPEO
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
public class GBPOFPPCAAP : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A93DC0", Offset = "0x6A929C0", VA = "0x186A93DC0")]
	public GBPOFPPCAAP(KOFDDAAAPEO FIFJJNIIAPF = KOFDDAAAPEO.Self, bool AGMOPGJFOHN = false, bool HBBPNFBGEIB = false, bool FAKEAFLIOBD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PNLKJBPBOKJ : GBPOFPPCAAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type DNIEAPAJMLP;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6A93FB0", Offset = "0x6A92BB0", VA = "0x186A93FB0")]
	public PNLKJBPBOKJ(Type MMLDLGEIDBN, KOFDDAAAPEO FIFJJNIIAPF = KOFDDAAAPEO.Self, bool AGMOPGJFOHN = false, bool HBBPNFBGEIB = false, bool FAKEAFLIOBD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class KMGHLJENBIC : GBPOFPPCAAP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A93DC0", Offset = "0x6A929C0", VA = "0x186A93DC0")]
	public KMGHLJENBIC(KOFDDAAAPEO FIFJJNIIAPF = KOFDDAAAPEO.Self, bool AGMOPGJFOHN = false, bool HBBPNFBGEIB = false, bool FAKEAFLIOBD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class NNIMJJNGKBI : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum EGCHFKMDAOJ
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
	public readonly string NMFCIBCONKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly EGCHFKMDAOJ FIFJJNIIAPF;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6A93F70", Offset = "0x6A92B70", VA = "0x186A93F70")]
	public NNIMJJNGKBI(string NMFCIBCONKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5FEA2A0", Offset = "0x5FE8EA0", VA = "0x185FEA2A0")]
	public NNIMJJNGKBI(string NMFCIBCONKC, EGCHFKMDAOJ FIFJJNIIAPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class ELBALDKMPMI : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string JHBKMLGOEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool DEGAFIMFCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] OLHCMOHCHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool OABALILGKNO;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A93B80", Offset = "0x6A92780", VA = "0x186A93B80")]
	public ELBALDKMPMI(string JHBKMLGOEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6A93C80", Offset = "0x6A92880", VA = "0x186A93C80")]
	public ELBALDKMPMI(string JHBKMLGOEGH, object ODCLFEFEHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6A93D60", Offset = "0x6A92960", VA = "0x186A93D60")]
	public ELBALDKMPMI(string JHBKMLGOEGH, params object[] OLHCMOHCHDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class PANFMJOGECB : ELBALDKMPMI
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6A93C80", Offset = "0x6A92880", VA = "0x186A93C80")]
	public PANFMJOGECB(string JHBKMLGOEGH, object ODCLFEFEHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6A93D60", Offset = "0x6A92960", VA = "0x186A93D60")]
	public PANFMJOGECB(string JHBKMLGOEGH, params object[] OLHCMOHCHDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class EAIOMPLMIIP : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool HNMLJMJBMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string FMCOFIOAGHE;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6A93B30", Offset = "0x6A92730", VA = "0x186A93B30")]
	public EAIOMPLMIIP(string JHHNKEFNDHO, bool GIEKACLGJAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OKAAHINNKMM : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1738690", Offset = "0x1737290", VA = "0x181738690")]
	public OKAAHINNKMM()
	{
	}
}
namespace RecRoom.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1738690", Offset = "0x1737290", VA = "0x181738690")]
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
