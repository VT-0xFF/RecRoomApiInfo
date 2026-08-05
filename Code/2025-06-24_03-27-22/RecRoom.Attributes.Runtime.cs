using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class CKCIHAEEJLD : IGPOEKCGNGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string JABKPBMEPOI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7BED300", Offset = "0x7BEBF00", VA = "0x187BED300")]
	public CKCIHAEEJLD(string LGDBBKFPKKC, string JABKPBMEPOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class AKCAEGLPEAM : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string MENKBJLFGGB;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7BED2C0", Offset = "0x7BEBEC0", VA = "0x187BED2C0")]
	public AKCAEGLPEAM(string MENKBJLFGGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum EBAHNMNBCJP
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
public class GHKDIKFNBMM : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7BED460", Offset = "0x7BEC060", VA = "0x187BED460")]
	public GHKDIKFNBMM(EBAHNMNBCJP OPOPAMPKKGD = EBAHNMNBCJP.Self, bool FCOELPLOBCJ = false, bool CNLMEEODANA = false, bool OCJBMKEHACE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OHFJAKPEPFI : GHKDIKFNBMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type DLPIONMLBAJ;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7BED740", Offset = "0x7BEC340", VA = "0x187BED740")]
	public OHFJAKPEPFI(Type FKPNBPIOPHC, EBAHNMNBCJP OPOPAMPKKGD = EBAHNMNBCJP.Self, bool FCOELPLOBCJ = false, bool CNLMEEODANA = false, bool OCJBMKEHACE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class MHLPBMEFLGC : GHKDIKFNBMM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7BED460", Offset = "0x7BEC060", VA = "0x187BED460")]
	public MHLPBMEFLGC(EBAHNMNBCJP OPOPAMPKKGD = EBAHNMNBCJP.Self, bool FCOELPLOBCJ = false, bool CNLMEEODANA = false, bool OCJBMKEHACE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class EKFIFOOJEFD : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum ABBHPHJMOKF
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
	public readonly string NCOBNPEFMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly ABBHPHJMOKF OPOPAMPKKGD;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7BED420", Offset = "0x7BEC020", VA = "0x187BED420")]
	public EKFIFOOJEFD(string NCOBNPEFMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6FD9320", Offset = "0x6FD7F20", VA = "0x186FD9320")]
	public EKFIFOOJEFD(string NCOBNPEFMCH, ABBHPHJMOKF OPOPAMPKKGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class IGPOEKCGNGE : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string LGDBBKFPKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool EDDKDGOJAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] ILCMGLKNDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool OKOLCIDBAEN;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7BED590", Offset = "0x7BEC190", VA = "0x187BED590")]
	public IGPOEKCGNGE(string LGDBBKFPKKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7BED4B0", Offset = "0x7BEC0B0", VA = "0x187BED4B0")]
	public IGPOEKCGNGE(string LGDBBKFPKKC, object PHNGGMMDPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7BED690", Offset = "0x7BEC290", VA = "0x187BED690")]
	public IGPOEKCGNGE(string LGDBBKFPKKC, params object[] ILCMGLKNDHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class PJPNKCNLIBH : IGPOEKCGNGE
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7BED4B0", Offset = "0x7BEC0B0", VA = "0x187BED4B0")]
	public PJPNKCNLIBH(string LGDBBKFPKKC, object PHNGGMMDPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7BED690", Offset = "0x7BEC290", VA = "0x187BED690")]
	public PJPNKCNLIBH(string LGDBBKFPKKC, params object[] ILCMGLKNDHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class IPIHMFGEFJP : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool KPOLPIJBLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string PKJPOPEFAGG;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7BED6F0", Offset = "0x7BEC2F0", VA = "0x187BED6F0")]
	public IPIHMFGEFJP(string JNHDHCGACNL, bool OIJPCKKKEFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class CKPJCEFJLJF : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x220C420", Offset = "0x220B020", VA = "0x18220C420")]
	public CKPJCEFJLJF()
	{
	}
}
namespace RecRoom.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x220C420", Offset = "0x220B020", VA = "0x18220C420")]
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
