using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class MOEEOODINIC : CPAPECLLIGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string CIPHIDADOKD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6160440", Offset = "0x615F440", VA = "0x186160440")]
	public MOEEOODINIC(string NIOPCEKIAKL, string CIPHIDADOKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class DKDJOBIBMGE : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string KGIAIPEGFDB;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7CFD40", Offset = "0x7CED40", VA = "0x1807CFD40")]
	public DKDJOBIBMGE(string KGIAIPEGFDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum PHHCCEMPGEN
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
public class KDKBJHCHPNA : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6160380", Offset = "0x615F380", VA = "0x186160380")]
	public KDKBJHCHPNA(PHHCCEMPGEN KBCNAJKPHNL = PHHCCEMPGEN.Self, bool IGGFBNPGPHL = false, bool BANGMIGKBAO = false, bool CKNIMJDADNO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MIAKGOBAIMH : KDKBJHCHPNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type NAGBCOGLBKK;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x61603D0", Offset = "0x615F3D0", VA = "0x1861603D0")]
	public MIAKGOBAIMH(Type PDCPDIBEKHL, PHHCCEMPGEN KBCNAJKPHNL = PHHCCEMPGEN.Self, bool IGGFBNPGPHL = false, bool BANGMIGKBAO = false, bool CKNIMJDADNO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class IELENNDBCLM : KDKBJHCHPNA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6160380", Offset = "0x615F380", VA = "0x186160380")]
	public IELENNDBCLM(PHHCCEMPGEN KBCNAJKPHNL = PHHCCEMPGEN.Self, bool IGGFBNPGPHL = false, bool BANGMIGKBAO = false, bool CKNIMJDADNO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class DINFAACLJBN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum PEANPMKBBGO
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
	public readonly string BGKEOPLCBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly PEANPMKBBGO KBCNAJKPHNL;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x61602F0", Offset = "0x615F2F0", VA = "0x1861602F0")]
	public DINFAACLJBN(string BGKEOPLCBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x571C3B0", Offset = "0x571B3B0", VA = "0x18571C3B0")]
	public DINFAACLJBN(string BGKEOPLCBJN, PEANPMKBBGO KBCNAJKPHNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class CPAPECLLIGO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string NIOPCEKIAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool HLBBCMPAIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] NOFBGFJGCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool DGNDKIIJGMN;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6160110", Offset = "0x615F110", VA = "0x186160110")]
	public CPAPECLLIGO(string NIOPCEKIAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6160210", Offset = "0x615F210", VA = "0x186160210")]
	public CPAPECLLIGO(string NIOPCEKIAKL, object DGAPPLOJDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x61600B0", Offset = "0x615F0B0", VA = "0x1861600B0")]
	public CPAPECLLIGO(string NIOPCEKIAKL, params object[] NOFBGFJGCCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class MNLAMNJHMAL : CPAPECLLIGO
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6160210", Offset = "0x615F210", VA = "0x186160210")]
	public MNLAMNJHMAL(string NIOPCEKIAKL, object DGAPPLOJDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x61600B0", Offset = "0x615F0B0", VA = "0x1861600B0")]
	public MNLAMNJHMAL(string NIOPCEKIAKL, params object[] NOFBGFJGCCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class GECPFIGIBMN : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool PEOLOLPMHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string DGPAHCKAPNI;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6160330", Offset = "0x615F330", VA = "0x186160330")]
	public GECPFIGIBMN(string LCIBJMIMIID, bool AEAGJFOBMCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KGOLBBMHGLJ : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7D00C0", Offset = "0x7CF0C0", VA = "0x1807D00C0")]
	public KGOLBBMHGLJ()
	{
	}
}
namespace RecRoom.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7D00C0", Offset = "0x7CF0C0", VA = "0x1807D00C0")]
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
