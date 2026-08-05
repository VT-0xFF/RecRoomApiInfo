using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DHFNMJKMPFO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	EMHINGNNCEH GDHFEKHHPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	EMHINGNNCEH ILMLNGKMLGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	EMHINGNNCEH ELECIGJBKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LHPHOOMKOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool JCFJEGOEOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EIDNADAHLNE
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	LBAOFFOBDIC.MEBFJMMLIOC JOKCNJKAKCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float JDOLJMGJGHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ENAPBBMFIDB();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ODKMMLPKJPA
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EIDNADAHLNE HJIMMAIHLLI(LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EIDNADAHLNE ACEIPFCCLNN(float GHMCIHBEFMJ, LBAOFFOBDIC.MEBFJMMLIOC JKFOFAFPGIB = LBAOFFOBDIC.MEBFJMMLIOC.Update);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EIDNADAHLNE FEAGBKAMHBB(Func<bool> FHMCKHFCCEA);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CBCAOMNIMGK
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool JCFJEGOEOFA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CGNOFOAADKJ Run(IEnumerator<EIDNADAHLNE> IHDKHDDPKLC);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CGNOFOAADKJ Run(Behaviour NJEMLNPONME, IEnumerator<EIDNADAHLNE> IHDKHDDPKLC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CGNOFOAADKJ : HFJGPNNFFKA, OJNMJAKAOEK, IEnumerator, EIDNADAHLNE, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DNLNADNGJFN
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float LKGGGDFEKMB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float AHBMLFHEIJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double KBBPOEOHCJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LBAOFFOBDIC
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[HOMNMJPPHPG]
	public enum MEBFJMMLIOC
	{
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		PreRender,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		EndOfFrame
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class DBLKMDJAFMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public OJNMJAKAOEK promise;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
		public DBLKMDJAFMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3D97600", Offset = "0x3D96000", VA = "0x183D97600")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static ODKMMLPKJPA OLCPNMFNOEL;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Stack<ODKMMLPKJPA> LHHOOBMAMPP;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static DNLNADNGJFN GNAFFECNMHK;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly Stack<DNLNADNGJFN> FJNPBKGJJGB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static ODKMMLPKJPA POCGMMOMHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3D985A0", Offset = "0x3D96FA0", VA = "0x183D985A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static DNLNADNGJFN HLNBIADJMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3D98480", Offset = "0x3D96E80", VA = "0x183D98480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static EIDNADAHLNE HJIMMAIHLLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3D98540", Offset = "0x3D96F40", VA = "0x183D98540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3D98360", Offset = "0x3D96D60", VA = "0x183D98360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static EIDNADAHLNE CDNOPEBOKHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3D98270", Offset = "0x3D96C70", VA = "0x183D98270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3D984E0", Offset = "0x3D96EE0", VA = "0x183D984E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static EIDNADAHLNE EEJLENPLLMP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3D981B0", Offset = "0x3D96BB0", VA = "0x183D981B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3D983C0", Offset = "0x3D96DC0", VA = "0x183D983C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static EIDNADAHLNE EIMHMJBBEPA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3D98420", Offset = "0x3D96E20", VA = "0x183D98420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3D97E60", Offset = "0x3D96860", VA = "0x183D97E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static EIDNADAHLNE LOBDPOLFKBO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3D98210", Offset = "0x3D96C10", VA = "0x183D98210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3D97D70", Offset = "0x3D96770", VA = "0x183D97D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3D982D0", Offset = "0x3D96CD0", VA = "0x183D982D0")]
	public static void IDPPEDPALHN(ODKMMLPKJPA KCHEONDNPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3D97DD0", Offset = "0x3D967D0", VA = "0x183D97DD0")]
	public static void EAEOAIEMLPK(DNLNADNGJFN JPGKNGGLNME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3D97780", Offset = "0x3D96180", VA = "0x183D97780")]
	private static void BOLNCLPHGAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3D976B0", Offset = "0x3D960B0", VA = "0x183D976B0")]
	public static EIDNADAHLNE ACEIPFCCLNN(float GHMCIHBEFMJ, MEBFJMMLIOC JKFOFAFPGIB = MEBFJMMLIOC.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3D98600", Offset = "0x3D97000", VA = "0x183D98600")]
	public static EIDNADAHLNE OIBJGMKNPJJ(float GHMCIHBEFMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3D97EC0", Offset = "0x3D968C0", VA = "0x183D97EC0")]
	public static EIDNADAHLNE FEAGBKAMHBB(Func<bool> FHMCKHFCCEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3D97FF0", Offset = "0x3D969F0", VA = "0x183D97FF0")]
	public static EIDNADAHLNE GBHBIHLJLCN(OJNMJAKAOEK JHPNEFHMIMF)
	{
		return null;
	}
}
namespace Cpp2IlInjected;

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
