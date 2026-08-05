using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class JFMCGLIHJKL : KJBPBAHEFKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string KIJEIINIEHJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2FB0", Offset = "0x7BC1DB0", VA = "0x187BC2FB0")]
	public JFMCGLIHJKL(string JEICEDPHPDO, string KIJEIINIEHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class OAMNFBDGECP : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string MPIHMNBKNFP;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7BC31D0", Offset = "0x7BC1FD0", VA = "0x187BC31D0")]
	public OAMNFBDGECP(string MPIHMNBKNFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CBEHFHOOABN
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
public class DBPOJNFABNN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2D70", Offset = "0x7BC1B70", VA = "0x187BC2D70")]
	public DBPOJNFABNN(CBEHFHOOABN AAFMBEEMJAC = CBEHFHOOABN.Self, bool OGMMFBMLHOL = false, bool OOENLCJGIIN = false, bool AFINAADIFLN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GBCCLNCCBFD : DBPOJNFABNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type HLOKGAPDFGA;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2DC0", Offset = "0x7BC1BC0", VA = "0x187BC2DC0")]
	public GBCCLNCCBFD(Type JGIGMJPCKDE, CBEHFHOOABN AAFMBEEMJAC = CBEHFHOOABN.Self, bool OGMMFBMLHOL = false, bool OOENLCJGIIN = false, bool AFINAADIFLN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HIEDJMGIPME : DBPOJNFABNN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2D70", Offset = "0x7BC1B70", VA = "0x187BC2D70")]
	public HIEDJMGIPME(CBEHFHOOABN AAFMBEEMJAC = CBEHFHOOABN.Self, bool OGMMFBMLHOL = false, bool OOENLCJGIIN = false, bool AFINAADIFLN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class JAANJEHBAHB : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum ELEPCFDHIBN
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
	public readonly string KMIPFFIBFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly ELEPCFDHIBN AAFMBEEMJAC;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2E30", Offset = "0x7BC1C30", VA = "0x187BC2E30")]
	public JAANJEHBAHB(string KMIPFFIBFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3C30", Offset = "0x6FD2A30", VA = "0x186FD3C30")]
	public JAANJEHBAHB(string KMIPFFIBFDN, ELEPCFDHIBN AAFMBEEMJAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class KJBPBAHEFKJ : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string JEICEDPHPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool FMHMFFGPOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] ACEALAJGOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool HFAHHGLFCMK;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7BC30D0", Offset = "0x7BC1ED0", VA = "0x187BC30D0")]
	public KJBPBAHEFKJ(string JEICEDPHPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2E70", Offset = "0x7BC1C70", VA = "0x187BC2E70")]
	public KJBPBAHEFKJ(string JEICEDPHPDO, object GBBADJHGJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2F50", Offset = "0x7BC1D50", VA = "0x187BC2F50")]
	public KJBPBAHEFKJ(string JEICEDPHPDO, params object[] ACEALAJGOND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class JACCDEMFOIC : KJBPBAHEFKJ
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2E70", Offset = "0x7BC1C70", VA = "0x187BC2E70")]
	public JACCDEMFOIC(string JEICEDPHPDO, object GBBADJHGJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2F50", Offset = "0x7BC1D50", VA = "0x187BC2F50")]
	public JACCDEMFOIC(string JEICEDPHPDO, params object[] ACEALAJGOND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class CAGKGHOMIKP : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool LNGOJCPGNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string MMCEMAFMBAH;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2D20", Offset = "0x7BC1B20", VA = "0x187BC2D20")]
	public CAGKGHOMIKP(string CBKJNGBKNPM, bool FLELANELHPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class ICKMBNNAEAO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x20D9420", Offset = "0x20D8220", VA = "0x1820D9420")]
	public ICKMBNNAEAO()
	{
	}
}
namespace RecRoom.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x20D9420", Offset = "0x20D8220", VA = "0x1820D9420")]
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
