using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class PMHIBBLBAAN : LEOLDNKHGOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string GJOIJNIHHFK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7952A30", Offset = "0x7951230", VA = "0x187952A30")]
	public PMHIBBLBAAN(string HFJNENKHHJL, string GJOIJNIHHFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class KOJCJLHGOJD : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string AGHOKINBNIL;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x79528F0", Offset = "0x79510F0", VA = "0x1879528F0")]
	public KOJCJLHGOJD(string AGHOKINBNIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum HNCMILCNFNF
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
public class DAFFCFHPHBO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7952710", Offset = "0x7950F10", VA = "0x187952710")]
	public DAFFCFHPHBO(HNCMILCNFNF PIJHKCJDAHO = HNCMILCNFNF.Self, bool NAOEKPNMNHI = false, bool BAGDEIFNCEA = false, bool FELLLEJKDPF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BACECJCPMAG : DAFFCFHPHBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type JEICNNOLJKI;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x79526A0", Offset = "0x7950EA0", VA = "0x1879526A0")]
	public BACECJCPMAG(Type JNPPIODJKPI, HNCMILCNFNF PIJHKCJDAHO = HNCMILCNFNF.Self, bool NAOEKPNMNHI = false, bool BAGDEIFNCEA = false, bool FELLLEJKDPF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class FCBJLJFBGGB : DAFFCFHPHBO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7952710", Offset = "0x7950F10", VA = "0x187952710")]
	public FCBJLJFBGGB(HNCMILCNFNF PIJHKCJDAHO = HNCMILCNFNF.Self, bool NAOEKPNMNHI = false, bool BAGDEIFNCEA = false, bool FELLLEJKDPF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class AHEDOMAEHEG : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum KDAALAGBOKB
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
	public readonly string ANNJHMKGNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly KDAALAGBOKB PIJHKCJDAHO;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7952660", Offset = "0x7950E60", VA = "0x187952660")]
	public AHEDOMAEHEG(string ANNJHMKGNBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6D8D260", Offset = "0x6D8BA60", VA = "0x186D8D260")]
	public AHEDOMAEHEG(string ANNJHMKGNBM, KDAALAGBOKB PIJHKCJDAHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class LEOLDNKHGOB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string HFJNENKHHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool DOHPNOCFKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] OBBEHICNDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool BBGBHAJAPGF;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7952930", Offset = "0x7951130", VA = "0x187952930")]
	public LEOLDNKHGOB(string HFJNENKHHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7952810", Offset = "0x7951010", VA = "0x187952810")]
	public LEOLDNKHGOB(string HFJNENKHHJL, object LHDOODBJEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x79527B0", Offset = "0x7950FB0", VA = "0x1879527B0")]
	public LEOLDNKHGOB(string HFJNENKHHJL, params object[] OBBEHICNDMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class GEILLEEPHOI : LEOLDNKHGOB
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7952810", Offset = "0x7951010", VA = "0x187952810")]
	public GEILLEEPHOI(string HFJNENKHHJL, object LHDOODBJEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x79527B0", Offset = "0x7950FB0", VA = "0x1879527B0")]
	public GEILLEEPHOI(string HFJNENKHHJL, params object[] OBBEHICNDMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class DHCMDFCEMFG : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool CPMJPGGHHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string LHLKANIELAO;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7952760", Offset = "0x7950F60", VA = "0x187952760")]
	public DHCMDFCEMFG(string IKOHLJIAOKE, bool IMLBCLKOMBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class JOBIDOJEEHI : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x20278A0", Offset = "0x20260A0", VA = "0x1820278A0")]
	public JOBIDOJEEHI()
	{
	}
}
namespace RecRoom.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x20278A0", Offset = "0x20260A0", VA = "0x1820278A0")]
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
