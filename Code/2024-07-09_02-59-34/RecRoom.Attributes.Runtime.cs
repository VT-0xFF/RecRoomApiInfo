using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class MNIIBJJGNFO : MIPPFGOLFDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string GEIJFLEBBHJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6853EA0", Offset = "0x6852AA0", VA = "0x186853EA0")]
	public MNIIBJJGNFO(string HOIDABLGAOJ, string GEIJFLEBBHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class NABKMONKIPO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string EFNBGNLKFDL;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6853FC0", Offset = "0x6852BC0", VA = "0x186853FC0")]
	public NABKMONKIPO(string EFNBGNLKFDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum OBLJNCJJPID
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
public class KJNKIIMENHL : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6853CE0", Offset = "0x68528E0", VA = "0x186853CE0")]
	public KJNKIIMENHL(OBLJNCJJPID HGPIKDLKBHO = OBLJNCJJPID.Self, bool JFEJBJBPODA = false, bool MFGNGKINKFB = false, bool EMDGJJPMNEP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KFOLOPEPONL : KJNKIIMENHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type KHCDCNEMEKF;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6853D30", Offset = "0x6852930", VA = "0x186853D30")]
	public KFOLOPEPONL(Type JLNJMCJLDIB, OBLJNCJJPID HGPIKDLKBHO = OBLJNCJJPID.Self, bool JFEJBJBPODA = false, bool MFGNGKINKFB = false, bool EMDGJJPMNEP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class JIPFFEAJEBK : KJNKIIMENHL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6853CE0", Offset = "0x68528E0", VA = "0x186853CE0")]
	public JIPFFEAJEBK(OBLJNCJJPID HGPIKDLKBHO = OBLJNCJJPID.Self, bool JFEJBJBPODA = false, bool MFGNGKINKFB = false, bool EMDGJJPMNEP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class HEOEJENLPDI : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum JBKLOAPOJHB
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
	public readonly string GFDNJEBNLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly JBKLOAPOJHB HGPIKDLKBHO;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6853CA0", Offset = "0x68528A0", VA = "0x186853CA0")]
	public HEOEJENLPDI(string GFDNJEBNLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA4D0", Offset = "0x5DD90D0", VA = "0x185DDA4D0")]
	public HEOEJENLPDI(string GFDNJEBNLIG, JBKLOAPOJHB HGPIKDLKBHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class MIPPFGOLFDM : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string HOIDABLGAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool KDOBNBOCFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] KKDEINKMLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool EDONOCNDPMA;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6853DA0", Offset = "0x68529A0", VA = "0x186853DA0")]
	public MIPPFGOLFDM(string HOIDABLGAOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6853B10", Offset = "0x6852710", VA = "0x186853B10")]
	public MIPPFGOLFDM(string HOIDABLGAOJ, object KGNKEAFNHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6853BF0", Offset = "0x68527F0", VA = "0x186853BF0")]
	public MIPPFGOLFDM(string HOIDABLGAOJ, params object[] KKDEINKMLFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class DJEOLDCNGLO : MIPPFGOLFDM
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6853B10", Offset = "0x6852710", VA = "0x186853B10")]
	public DJEOLDCNGLO(string HOIDABLGAOJ, object KGNKEAFNHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6853BF0", Offset = "0x68527F0", VA = "0x186853BF0")]
	public DJEOLDCNGLO(string HOIDABLGAOJ, params object[] KKDEINKMLFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class DOCEHAKOGMI : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool LJNINICIMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string INDNMOOGILB;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6853C50", Offset = "0x6852850", VA = "0x186853C50")]
	public DOCEHAKOGMI(string BODMMDDOHAA, bool MPPICPMJJPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class CKEDEJJOINC : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x14EC7A0", Offset = "0x14EB3A0", VA = "0x1814EC7A0")]
	public CKEDEJJOINC()
	{
	}
}
namespace RecRoom.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x14EC7A0", Offset = "0x14EB3A0", VA = "0x1814EC7A0")]
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
