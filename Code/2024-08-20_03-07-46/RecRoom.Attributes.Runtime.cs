using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class AAICHNBLKGE : OENGNDNIGIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string IDNNKJNHJGN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x67FC240", Offset = "0x67FB240", VA = "0x1867FC240")]
	public AAICHNBLKGE(string NOLOHHPCHOE, string IDNNKJNHJGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class HLGFOKAGIHL : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string CMIAHNJKOCO;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x67FC470", Offset = "0x67FB470", VA = "0x1867FC470")]
	public HLGFOKAGIHL(string CMIAHNJKOCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum JFBJMOOHBCL
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
public class IDHMMACJAGM : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x67FC3D0", Offset = "0x67FB3D0", VA = "0x1867FC3D0")]
	public IDHMMACJAGM(JFBJMOOHBCL HNGLFCFOHLI = JFBJMOOHBCL.Self, bool BHLBLCPPIOP = false, bool DJFGFDKCJLI = false, bool FMNCHCPNKHO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BPPNBBAIPAE : IDHMMACJAGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type GEJJGDNKKPB;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x67FC360", Offset = "0x67FB360", VA = "0x1867FC360")]
	public BPPNBBAIPAE(Type DLANCAABCFL, JFBJMOOHBCL HNGLFCFOHLI = JFBJMOOHBCL.Self, bool BHLBLCPPIOP = false, bool DJFGFDKCJLI = false, bool FMNCHCPNKHO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class FIHOJOMCNEF : IDHMMACJAGM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x67FC3D0", Offset = "0x67FB3D0", VA = "0x1867FC3D0")]
	public FIHOJOMCNEF(JFBJMOOHBCL HNGLFCFOHLI = JFBJMOOHBCL.Self, bool BHLBLCPPIOP = false, bool DJFGFDKCJLI = false, bool FMNCHCPNKHO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class JNDDIDOOEIG : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum NNOCLIHBKCB
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
	public readonly string GJILLLIMLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly NNOCLIHBKCB HNGLFCFOHLI;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x67FC4B0", Offset = "0x67FB4B0", VA = "0x1867FC4B0")]
	public JNDDIDOOEIG(string GJILLLIMLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5D75E20", Offset = "0x5D74E20", VA = "0x185D75E20")]
	public JNDDIDOOEIG(string GJILLLIMLII, NNOCLIHBKCB HNGLFCFOHLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class OENGNDNIGIJ : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string NOLOHHPCHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool FMBPMCAPMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] PPBGPMMKDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool IPKIMNOMOJI;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x67FC630", Offset = "0x67FB630", VA = "0x1867FC630")]
	public OENGNDNIGIJ(string NOLOHHPCHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x67FC550", Offset = "0x67FB550", VA = "0x1867FC550")]
	public OENGNDNIGIJ(string NOLOHHPCHOE, object NJBFMNJCMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x67FC4F0", Offset = "0x67FB4F0", VA = "0x1867FC4F0")]
	public OENGNDNIGIJ(string NOLOHHPCHOE, params object[] PPBGPMMKDMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class OHEBGOFBLLL : OENGNDNIGIJ
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x67FC550", Offset = "0x67FB550", VA = "0x1867FC550")]
	public OHEBGOFBLLL(string NOLOHHPCHOE, object NJBFMNJCMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x67FC4F0", Offset = "0x67FB4F0", VA = "0x1867FC4F0")]
	public OHEBGOFBLLL(string NOLOHHPCHOE, params object[] PPBGPMMKDMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class GENOLDIODKA : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool DGLEOLBCLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string CFFMLCJGHAB;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x67FC420", Offset = "0x67FB420", VA = "0x1867FC420")]
	public GENOLDIODKA(string GJCEJFFKDLI, bool HEBODNMNBAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class NNGCCAHDNJE : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x15C3B30", Offset = "0x15C2B30", VA = "0x1815C3B30")]
	public NNGCCAHDNJE()
	{
	}
}
namespace RecRoom.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x15C3B30", Offset = "0x15C2B30", VA = "0x1815C3B30")]
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
