using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class MDELCNGBAGL : HDIPNKIBINK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string KGEFEBDLHFE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x72EE460", Offset = "0x72ED060", VA = "0x1872EE460")]
	public MDELCNGBAGL(string MGLGDIIIAGD, string KGEFEBDLHFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class INLMFDOGCKN : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string LAOKPPNMPJL;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x72EE3D0", Offset = "0x72ECFD0", VA = "0x1872EE3D0")]
	public INLMFDOGCKN(string LAOKPPNMPJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum EGFPEOBPDHA
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
public class NEHJBMHDGNH : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x72EE210", Offset = "0x72ECE10", VA = "0x1872EE210")]
	public NEHJBMHDGNH(EGFPEOBPDHA ADFFEBFOCBD = EGFPEOBPDHA.Self, bool AFCPGGCNAFG = false, bool GCCFMAJPCMH = false, bool OLPMCIFLBOB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GGOAOEBFELG : NEHJBMHDGNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type EDHNOJLHMFN;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x72EE260", Offset = "0x72ECE60", VA = "0x1872EE260")]
	public GGOAOEBFELG(Type FGNNOJANBJA, EGFPEOBPDHA ADFFEBFOCBD = EGFPEOBPDHA.Self, bool AFCPGGCNAFG = false, bool GCCFMAJPCMH = false, bool OLPMCIFLBOB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class FKADGLKHFBM : NEHJBMHDGNH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x72EE210", Offset = "0x72ECE10", VA = "0x1872EE210")]
	public FKADGLKHFBM(EGFPEOBPDHA ADFFEBFOCBD = EGFPEOBPDHA.Self, bool AFCPGGCNAFG = false, bool GCCFMAJPCMH = false, bool OLPMCIFLBOB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class DFGPHEPDOHA : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum MOLAOMCLFMM
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
	public readonly string OFIIGLBDPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly MOLAOMCLFMM ADFFEBFOCBD;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x72EE1D0", Offset = "0x72ECDD0", VA = "0x1872EE1D0")]
	public DFGPHEPDOHA(string OFIIGLBDPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68116D0", Offset = "0x68102D0", VA = "0x1868116D0")]
	public DFGPHEPDOHA(string OFIIGLBDPPI, MOLAOMCLFMM ADFFEBFOCBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HDIPNKIBINK : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string MGLGDIIIAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool IGJKJGIJJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] BHGCAHNCKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool NCMPANNEKLD;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x72EE2D0", Offset = "0x72ECED0", VA = "0x1872EE2D0")]
	public HDIPNKIBINK(string MGLGDIIIAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x72EE090", Offset = "0x72ECC90", VA = "0x1872EE090")]
	public HDIPNKIBINK(string MGLGDIIIAGD, object NKLAHGGMJGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x72EE170", Offset = "0x72ECD70", VA = "0x1872EE170")]
	public HDIPNKIBINK(string MGLGDIIIAGD, params object[] BHGCAHNCKMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class CCNKOPFIMJH : HDIPNKIBINK
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x72EE090", Offset = "0x72ECC90", VA = "0x1872EE090")]
	public CCNKOPFIMJH(string MGLGDIIIAGD, object NKLAHGGMJGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x72EE170", Offset = "0x72ECD70", VA = "0x1872EE170")]
	public CCNKOPFIMJH(string MGLGDIIIAGD, params object[] BHGCAHNCKMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class JNHDDGHLINK : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool GDGKJPLNKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string LMABMPGLDEG;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x72EE410", Offset = "0x72ED010", VA = "0x1872EE410")]
	public JNHDDGHLINK(string DKFLHCCDHEG, bool CBNGFDDMAML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class IGAFPDABIIB : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1DE31B0", Offset = "0x1DE1DB0", VA = "0x181DE31B0")]
	public IGAFPDABIIB()
	{
	}
}
namespace RecRoom.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1DE31B0", Offset = "0x1DE1DB0", VA = "0x181DE31B0")]
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
