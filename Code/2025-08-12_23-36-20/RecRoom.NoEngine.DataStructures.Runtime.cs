using System;
using System.Buffers;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x84F4320", Offset = "0x84F3120", VA = "0x1884F4320")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xABFA60", Offset = "0xABE860", VA = "0x180ABFA60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class GIAFJNFMPOI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	protected GIAFJNFMPOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class CFLOJLKONNK<T> : GIAFJNFMPOI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct KPDAMDIFNAO
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum BDKFPCFINIO
		{
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public BDKFPCFINIO ADGMECOLKNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T IJBAPONMLAP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int IMPOKNNCJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool EKLOOBIFIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool KIHDJGNLJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? NOKPDCNEFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<KPDAMDIFNAO>? OHNFHIAAPBO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool DHGPDALKOLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6C65920", Offset = "0x6C64720", VA = "0x186C65920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C65CE0", Offset = "0x6C64AE0", VA = "0x186C65CE0")]
	protected CFLOJLKONNK(bool KIHDJGNLJBN, bool EKLOOBIFIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C65A80", Offset = "0x6C64880", VA = "0x186C65A80")]
	protected bool MCIOBGGNMAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6C65970", Offset = "0x6C64770", VA = "0x186C65970")]
	protected void LKFCEBPNCFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6C653E0", Offset = "0x6C641E0", VA = "0x186C653E0")]
	protected void CFMMFCAPFIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x419F3B0", Offset = "0x419E1B0", VA = "0x18419F3B0")]
	private static void DMFBBPMDPLM<U>(List<U>? NGGCNGNMEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6C655C0", Offset = "0x6C643C0", VA = "0x186C655C0", Slot = "4")]
	public void DPHJBDIDPOG(T IJBAPONMLAP, bool MELLEMHIDOP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6C65B20", Offset = "0x6C64920", VA = "0x186C65B20", Slot = "5")]
	public void MDNHCHGJFLC(T IJBAPONMLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6C657A0", Offset = "0x6C645A0", VA = "0x186C657A0")]
	public void FMJEOCFJDAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class MKAEDPHCCBC : CFLOJLKONNK<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x84F3A50", Offset = "0x84F2850", VA = "0x1884F3A50")]
	public MKAEDPHCCBC(bool KIHDJGNLJBN = false, bool EKLOOBIFIHE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x84F3790", Offset = "0x84F2590", VA = "0x1884F3790")]
	public void AHMKNKCPDKI()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x84F3990", Offset = "0x84F2790", VA = "0x1884F3990")]
	public static MKAEDPHCCBC BONCLONNKDN(MKAEDPHCCBC KNODBFGEFIN, Action IJBAPONMLAP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x84F39F0", Offset = "0x84F27F0", VA = "0x1884F39F0")]
	public static MKAEDPHCCBC HLNNJEBOMBL(MKAEDPHCCBC KNODBFGEFIN, Action IJBAPONMLAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EBMABBBKOFI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPHJBDIDPOG(Action<T> IJBAPONMLAP, bool MELLEMHIDOP = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MDNHCHGJFLC(Action<T> IJBAPONMLAP);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class GBCEOPMAPJH<T> : CFLOJLKONNK<Action<T>>, EBMABBBKOFI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4540BE0", Offset = "0x453F9E0", VA = "0x184540BE0")]
	public GBCEOPMAPJH(bool KIHDJGNLJBN = false, bool EKLOOBIFIHE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4FCA780", Offset = "0x4FC9580", VA = "0x184FCA780")]
	public void AHMKNKCPDKI(T DDCPKPIHIOM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x45559E0", Offset = "0x45547E0", VA = "0x1845559E0")]
	public static GBCEOPMAPJH<T> BONCLONNKDN(GBCEOPMAPJH<T> KNODBFGEFIN, Action<T> IJBAPONMLAP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4555A70", Offset = "0x4554870", VA = "0x184555A70")]
	public static GBCEOPMAPJH<T> HLNNJEBOMBL(GBCEOPMAPJH<T> KNODBFGEFIN, Action<T> IJBAPONMLAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IMFGHOLLHFL<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPHJBDIDPOG(Action<T, U> IJBAPONMLAP, bool MELLEMHIDOP = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MDNHCHGJFLC(Action<T, U> IJBAPONMLAP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class FLNBPEKPFIH<T, U> : CFLOJLKONNK<Action<T, U>>, IMFGHOLLHFL<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4540BE0", Offset = "0x453F9E0", VA = "0x184540BE0")]
	public FLNBPEKPFIH(bool KIHDJGNLJBN = false, bool EKLOOBIFIHE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4F25C50", Offset = "0x4F24A50", VA = "0x184F25C50")]
	public void AHMKNKCPDKI(T DDCPKPIHIOM, U GNGAGNDCMFN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x45559E0", Offset = "0x45547E0", VA = "0x1845559E0")]
	public static FLNBPEKPFIH<T, U> BONCLONNKDN(FLNBPEKPFIH<T, U> KNODBFGEFIN, Action<T, U> IJBAPONMLAP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4555A70", Offset = "0x4554870", VA = "0x184555A70")]
	public static FLNBPEKPFIH<T, U> HLNNJEBOMBL(FLNBPEKPFIH<T, U> KNODBFGEFIN, Action<T, U> IJBAPONMLAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class PMFLBKNAJDA<T, U, V> : CFLOJLKONNK<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4540BE0", Offset = "0x453F9E0", VA = "0x184540BE0")]
	public PMFLBKNAJDA(bool KIHDJGNLJBN = false, bool EKLOOBIFIHE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5C0D1A0", Offset = "0x5C0BFA0", VA = "0x185C0D1A0")]
	public void AHMKNKCPDKI(T DDCPKPIHIOM, U GNGAGNDCMFN, V MHBJBKNNPOK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x45559E0", Offset = "0x45547E0", VA = "0x1845559E0")]
	public static PMFLBKNAJDA<T, U, V> BONCLONNKDN(PMFLBKNAJDA<T, U, V> KNODBFGEFIN, Action<T, U, V> IJBAPONMLAP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4555A70", Offset = "0x4554870", VA = "0x184555A70")]
	public static PMFLBKNAJDA<T, U, V> HLNNJEBOMBL(PMFLBKNAJDA<T, U, V> KNODBFGEFIN, Action<T, U, V> IJBAPONMLAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KDAGCFKCIAC<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class DJFLFCNEIPG<T, U, V, W> : CFLOJLKONNK<Action<T, U, V, W>>, KDAGCFKCIAC<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4540BE0", Offset = "0x453F9E0", VA = "0x184540BE0")]
	public DJFLFCNEIPG(bool KIHDJGNLJBN = false, bool EKLOOBIFIHE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4555270", Offset = "0x4554070", VA = "0x184555270")]
	public void AHMKNKCPDKI(T DDCPKPIHIOM, U GNGAGNDCMFN, V MHBJBKNNPOK, W GFOPEPPIPGD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x45559E0", Offset = "0x45547E0", VA = "0x1845559E0")]
	public static DJFLFCNEIPG<T, U, V, W> BONCLONNKDN(DJFLFCNEIPG<T, U, V, W> KNODBFGEFIN, Action<T, U, V, W> IJBAPONMLAP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4555A70", Offset = "0x4554870", VA = "0x184555A70")]
	public static DJFLFCNEIPG<T, U, V, W> HLNNJEBOMBL(DJFLFCNEIPG<T, U, V, W> KNODBFGEFIN, Action<T, U, V, W> IJBAPONMLAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class EBEBHODLABP<T, U, V, W, X> : CFLOJLKONNK<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4540BE0", Offset = "0x453F9E0", VA = "0x184540BE0")]
	public EBEBHODLABP(bool KIHDJGNLJBN = false, bool EKLOOBIFIHE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4A3ACE0", Offset = "0x4A39AE0", VA = "0x184A3ACE0")]
	public void AHMKNKCPDKI(T DDCPKPIHIOM, U GNGAGNDCMFN, V MHBJBKNNPOK, W GFOPEPPIPGD, X DBBMOEGPNPP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x45559E0", Offset = "0x45547E0", VA = "0x1845559E0")]
	public static EBEBHODLABP<T, U, V, W, X> BONCLONNKDN(EBEBHODLABP<T, U, V, W, X> KNODBFGEFIN, Action<T, U, V, W, X> IJBAPONMLAP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4555A70", Offset = "0x4554870", VA = "0x184555A70")]
	public static EBEBHODLABP<T, U, V, W, X> HLNNJEBOMBL(EBEBHODLABP<T, U, V, W, X> KNODBFGEFIN, Action<T, U, V, W, X> IJBAPONMLAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class CLMGPECKAHB<T, U, V, W, X, Y> : CFLOJLKONNK<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4540BE0", Offset = "0x453F9E0", VA = "0x184540BE0")]
	public CLMGPECKAHB(bool KIHDJGNLJBN = false, bool EKLOOBIFIHE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6C74990", Offset = "0x6C73790", VA = "0x186C74990")]
	public void AHMKNKCPDKI(T DDCPKPIHIOM, U GNGAGNDCMFN, V MHBJBKNNPOK, W GFOPEPPIPGD, X DBBMOEGPNPP, Y COFKGIHGCOO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x45559E0", Offset = "0x45547E0", VA = "0x1845559E0")]
	public static CLMGPECKAHB<T, U, V, W, X, Y> BONCLONNKDN(CLMGPECKAHB<T, U, V, W, X, Y> KNODBFGEFIN, Action<T, U, V, W, X, Y> IJBAPONMLAP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4555A70", Offset = "0x4554870", VA = "0x184555A70")]
	public static CLMGPECKAHB<T, U, V, W, X, Y> HLNNJEBOMBL(CLMGPECKAHB<T, U, V, W, X, Y> KNODBFGEFIN, Action<T, U, V, W, X, Y> IJBAPONMLAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class CFNKFDDPBOB<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly JHCBDKPEMLJ<TKey, TVal> AAJPHCGJDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> LPEHPNBIHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly JHCBDKPEMLJ<TKey, TVal>.OCOMILOGKOG? LHLCDJMBDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int JKAFELDFAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly JHCBDKPEMLJ<TKey, TVal>.KCPIANEABHH? KJIBONJLGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int MPNBBNOHEHD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int EJCNLGIFONI
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6C66110", Offset = "0x6C64F10", VA = "0x186C66110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int APDEGNKEIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA94B30", Offset = "0xA93930", VA = "0x180A94B30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C66DB0", Offset = "0x6C65BB0", VA = "0x186C66DB0")]
	public CFNKFDDPBOB(int JKAFELDFAMJ, [Optional] JHCBDKPEMLJ<TKey, TVal>.KCPIANEABHH? KJIBONJLGAA, [Optional] IEqualityComparer<TKey>? BIFFKAEIANA, [Optional] JHCBDKPEMLJ<TKey, TVal>.OCOMILOGKOG? LHLCDJMBDAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C65D20", Offset = "0x6C64B20", VA = "0x186C65D20")]
	public void BOAPGEHPFJO(TKey OPGJHIOADCK, TVal HGMAIPELJHM, bool CJKEMHJFFAG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6C669C0", Offset = "0x6C657C0", VA = "0x186C669C0")]
	public bool MNHIIJGBMPO(TKey OPGJHIOADCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C65EF0", Offset = "0x6C64CF0", VA = "0x186C65EF0")]
	public bool CFOKPIKBEGL(TKey LKKMNPAKFAL, [Out] TVal HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C66250", Offset = "0x6C65050", VA = "0x186C66250")]
	private void IAIPMHNNIHP(TKey OPGJHIOADCK, TVal HGMAIPELJHM, int BCMFMCHGEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6C66AF0", Offset = "0x6C658F0", VA = "0x186C66AF0")]
	public bool PAFPPFJEDLA(TKey OPGJHIOADCK, TVal HGMAIPELJHM, bool CJKEMHJFFAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6C660B0", Offset = "0x6C64EB0", VA = "0x186C660B0")]
	public void FMJEOCFJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6C664B0", Offset = "0x6C652B0", VA = "0x186C664B0")]
	private void JHELBAFGJNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6C66160", Offset = "0x6C64F60", VA = "0x186C66160")]
	private bool HLKHCFIIJPF(TKey OPGJHIOADCK, GGMLKDFONEF BCDABHDFJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6C65FD0", Offset = "0x6C64DD0", VA = "0x186C65FD0")]
	private void FJIOODKFGDP(TKey OPGJHIOADCK, TVal HGMAIPELJHM, GGMLKDFONEF BCDABHDFJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C66C80", Offset = "0x6C65A80", VA = "0x186C66C80")]
	private void PNEPHMIDPFP(TKey OPGJHIOADCK, TVal DOMECMGKIBN, GGMLKDFONEF BCDABHDFJPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MAPCDLFLDAF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action DBCEACOLHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool KMAEIODOBDK;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
	public MAPCDLFLDAF(Action GAOPJHAPCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x84F3750", Offset = "0x84F2550", VA = "0x1884F3750", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3B53E10", Offset = "0x3B52C10", VA = "0x183B53E10")]
	public static JAFFBBCIDNI<T> INIHOJCCLPM<T>(T HGMAIPELJHM, Action GAOPJHAPCMF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class JAFFBBCIDNI<T> : MAPCDLFLDAF where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T DDHBFJGPDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5458C80", Offset = "0x5457A80", VA = "0x185458C80")]
	public JAFFBBCIDNI(T HGMAIPELJHM, Action GAOPJHAPCMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class HMEAPBNKFME<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly FFLKDOLGILO<T>? DEKFDLLKPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> MMKGAPFAEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool KMAEIODOBDK;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly HMEAPBNKFME<T> FBGBKFBLNFL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> GPJIMHCNILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x50C9E30", Offset = "0x50C8C30", VA = "0x1850C9E30")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long PJDGOCCOECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x50C9AD0", Offset = "0x50C88D0", VA = "0x1850C9AD0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool MJLOMDJHNBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x50C9CB0", Offset = "0x50C8AB0", VA = "0x1850C9CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x50CA410", Offset = "0x50C9210", VA = "0x1850CA410")]
	public HMEAPBNKFME(FFLKDOLGILO<T> GACENANNKLL, FFLKDOLGILO<T> LFGFMCOKILA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x50CA070", Offset = "0x50C8E70", VA = "0x1850CA070")]
	public HMEAPBNKFME(FFLKDOLGILO<T> GACENANNKLL, int DOCKBMMINED, FFLKDOLGILO<T> LFGFMCOKILA, int AOHJJOBFDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x50CA4E0", Offset = "0x50C92E0", VA = "0x1850CA4E0")]
	private HMEAPBNKFME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x50C9850", Offset = "0x50C8650", VA = "0x1850C9850", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x50C98D0", Offset = "0x50C86D0", VA = "0x1850C98D0")]
	public T[] EKFIPPAFKPM()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x50C9B90", Offset = "0x50C8990", VA = "0x1850C9B90")]
	public static ReadOnlySequence<T> MIDAFINGFAP(HMEAPBNKFME<T>? DLHHDNJKOCF)
	{
		return default(ReadOnlySequence<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct AOFIAGMEFLD<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly IDisposable LKEPGLHDENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public T DDHBFJGPDAJ;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5486F80", Offset = "0x5485D80", VA = "0x185486F80")]
	public AOFIAGMEFLD(IDisposable KINIEEOGPPI, [In] T HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x32236B0", Offset = "0x32224B0", VA = "0x1832236B0")]
	public static AOFIAGMEFLD<U> EGAHEMADDOP<U>([In] AOFIAGMEFLD<T> KINIEEOGPPI, [In] U HGMAIPELJHM) where U : notnull
	{
		return default(AOFIAGMEFLD<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5486E70", Offset = "0x5485C70", VA = "0x185486E70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class LLFNAMIHFCO
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3DDAFE0", Offset = "0x3DD9DE0", VA = "0x183DDAFE0")]
	public static AOFIAGMEFLD<T> ELDPFIHNJDG<T>(IDisposable KINIEEOGPPI, [In] T HGMAIPELJHM) where T : notnull
	{
		return default(AOFIAGMEFLD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3DDB010", Offset = "0x3DD9E10", VA = "0x183DDB010")]
	public static AOFIAGMEFLD<T> GKOMPDEKKOH<T>([In] this AOFIAGMEFLD<T> DBBEADIHLKO, [Out] T HGMAIPELJHM) where T : notnull
	{
		return default(AOFIAGMEFLD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3DDAF80", Offset = "0x3DD9D80", VA = "0x183DDAF80")]
	public static AOFIAGMEFLD<U?> EGAHEMADDOP<U, T>([In] AOFIAGMEFLD<T> GKNCMIFNHIH, [In] U HGMAIPELJHM)
	{
		return default(AOFIAGMEFLD<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct KNMKMPHCMCP : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct CKFOFNGBBGP : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0")]
		public static CKFOFNGBBGP ELDPFIHNJDG()
		{
			return default(CKFOFNGBBGP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x84F3040", Offset = "0x84F1E40", VA = "0x1884F3040")]
	public static string NDEKOLAAPKN(Type ADGMECOLKNH, [Optional] string? KAJONNFJKDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3DB73D0", Offset = "0x3DB61D0", VA = "0x183DB73D0")]
	public static string? NDEKOLAAPKN<T>([Optional] string? KAJONNFJKDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3DB7450", Offset = "0x3DB6250", VA = "0x183DB7450")]
	public static string? NHLGNNEJJPJ<T>([Optional] string? FDKONHHLMBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0")]
	public static KNMKMPHCMCP BADAHKFBFDJ(string KAJONNFJKDI, string? FDKONHHLMBE)
	{
		return default(KNMKMPHCMCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct ELPCOELKDGJ
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate bool CEMHIAOMFNO(string JPDIEJLOCKI, ELPCOELKDGJ GGJGPDELIGH);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class FBBNDBLKCHD<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public FBBNDBLKCHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4EECCD0", Offset = "0x4EEBAD0", VA = "0x184EECCD0")]
		internal void LOLBCLJHEEC(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public int AGNBPCKNDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public string HLNDOAJKLDD;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x84F23C0", Offset = "0x84F11C0", VA = "0x1884F23C0")]
	public static Dictionary<string, ELPCOELKDGJ> IFNMMIDJLAE(Type JCNMFMNCKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3B83780", Offset = "0x3B82580", VA = "0x183B83780")]
	public static Dictionary<string, ELPCOELKDGJ> IFNMMIDJLAE<T>(Type JCNMFMNCKBP, IReadOnlyDictionary<T, string> FGENJCDAPHA) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3B83FB0", Offset = "0x3B82DB0", VA = "0x183B83FB0")]
	public static Dictionary<string, ELPCOELKDGJ> JHBDIIPKDJG<T>(List<T> MBOAFDMJLMC) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x84F1E40", Offset = "0x84F0C40", VA = "0x1884F1E40")]
	public static Dictionary<string, ELPCOELKDGJ> EJJNKBJDLND(Type JCNMFMNCKBP, CEMHIAOMFNO LMAFKJLFJCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x84F2200", Offset = "0x84F1000", VA = "0x1884F2200")]
	public static Dictionary<int, string> EOEBPAIHADA(Dictionary<string, ELPCOELKDGJ> MKPEOGPFEFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class NILBFGOPNAM : FHNKPFADLOA
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool OPEGIDANJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly string? IONPLFNGJKM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual FHNKPFADLOA? MLKKPNDAKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x84F41C0", Offset = "0x84F2FC0", VA = "0x1884F41C0")]
	protected NILBFGOPNAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string PGDOAEFAHEB();

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x84F3FE0", Offset = "0x84F2DE0", VA = "0x1884F3FE0", Slot = "8")]
	public virtual string ONBFHBACAJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x84F3B10", Offset = "0x84F2910", VA = "0x1884F3B10", Slot = "9")]
	public void AHCOENEENFI(StringBuilder EFKMFCCPNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x84F3DC0", Offset = "0x84F2BC0", VA = "0x1884F3DC0", Slot = "10")]
	public void AMFAAGBIDGG(StringBuilder EFKMFCCPNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x84F3E20", Offset = "0x84F2C20", VA = "0x1884F3E20", Slot = "11")]
	public void BNHLBDNJLLC(StringBuilder EFKMFCCPNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x84F4060", Offset = "0x84F2E60", VA = "0x1884F4060", Slot = "12")]
	public void OPBKFCGGMKN(StringBuilder EFKMFCCPNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x84F3F40", Offset = "0x84F2D40", VA = "0x1884F3F40")]
	public static void DKLNDBDDCLA(StringBuilder EFKMFCCPNCB, string GBBEGJGJHAK, string LKHDKIIMCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x73E0220", Offset = "0x73DF020", VA = "0x1873E0220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class MOBPJDKKNIF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x84F3AB0", Offset = "0x84F28B0", VA = "0x1884F3AB0")]
	public MOBPJDKKNIF(string JDFCBBCKOGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PBMMFGAIECI<TErr> : MOBPJDKKNIF where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly TErr ONNKDLNNKLK;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5BEEE50", Offset = "0x5BEDC50", VA = "0x185BEEE50")]
	private PBMMFGAIECI([In] TErr EDGLLONCGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5BEED80", Offset = "0x5BEDB80", VA = "0x185BEED80")]
	public static PBMMFGAIECI<TErr> ELDPFIHNJDG([In] TErr EDGLLONCGOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class EHGFGKPCMKN : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashAlgorithm OGJKCKCGMOA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool PBGMMPKCNOH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool LBDFNBPINNN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool PJLLEGINDMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long PJDGOCCOECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x84F1CF0", Offset = "0x84F0AF0", VA = "0x1884F1CF0", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long FEDKKAIHHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x84F1D60", Offset = "0x84F0B60", VA = "0x1884F1D60", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x84F1DD0", Offset = "0x84F0BD0", VA = "0x1884F1DD0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x84F1C80", Offset = "0x84F0A80", VA = "0x1884F1C80")]
	public EHGFGKPCMKN(HashAlgorithm OGJKCKCGMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x84F1AB0", Offset = "0x84F08B0", VA = "0x1884F1AB0", Slot = "35")]
	public override int Read(byte[] ALPKAMHLIAF, int IBOFMHFOKKF, int FFKCBONKOOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x84F1C50", Offset = "0x84F0A50", VA = "0x1884F1C50", Slot = "38")]
	public override void Write(byte[] ALPKAMHLIAF, int IBOFMHFOKKF, int FFKCBONKOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x84F1B50", Offset = "0x84F0950", VA = "0x1884F1B50", Slot = "33")]
	public override long Seek(long IBOFMHFOKKF, SeekOrigin BPPDJECPPGM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x84F1BE0", Offset = "0x84F09E0", VA = "0x1884F1BE0", Slot = "34")]
	public override void SetLength(long HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x84F19E0", Offset = "0x84F07E0", VA = "0x1884F19E0")]
	public byte[] MLOMKNFOFNC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface FHNKPFADLOA
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string ONBFHBACAJJ();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string PGDOAEFAHEB();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface DLJMDABIBDF<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions DDHBFJGPDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface KAKABGFKBDO
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string MMFCCDMLCFI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class FFLKDOLGILO<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static FFLKDOLGILO<T>? DCOILGOHNPN;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static object LBMJFKPJFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private IMemoryOwner<T>? NPFJEABONAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool KMAEIODOBDK;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool KFLGDPOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xAEFA50", Offset = "0xAEE850", VA = "0x180AEFA50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4F05B20", Offset = "0x4F04920", VA = "0x184F05B20")]
	private static FFLKDOLGILO<T> EPHLKJKLEMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4F060D0", Offset = "0x4F04ED0", VA = "0x184F060D0")]
	private static void HCEHPDCOKIM(FFLKDOLGILO<T> BGMOBGFDNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4F07070", Offset = "0x4F05E70", VA = "0x184F07070")]
	private FFLKDOLGILO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4F06860", Offset = "0x4F05660", VA = "0x184F06860")]
	public static FFLKDOLGILO<T> INIHOJCCLPM(ReadOnlyMemory<T> CNLAJIDIBGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4F06650", Offset = "0x4F05450", VA = "0x184F06650")]
	public static FFLKDOLGILO<T> INIHOJCCLPM(IMemoryOwner<T> NHILNMMKDPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4F06CB0", Offset = "0x4F05AB0", VA = "0x184F06CB0")]
	public static void JKLPEDIKGGA(FFLKDOLGILO<T> GACENANNKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4F058F0", Offset = "0x4F046F0", VA = "0x184F058F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4F06BE0", Offset = "0x4F059E0", VA = "0x184F06BE0")]
	public FFLKDOLGILO<T> JFDMEJOLLOJ(IMemoryOwner<T> NHILNMMKDPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4F054E0", Offset = "0x4F042E0", VA = "0x184F054E0")]
	private void CPEOFGHLPDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4F05FC0", Offset = "0x4F04DC0", VA = "0x184F05FC0")]
	private FFLKDOLGILO<T> FJDIFMJNHII(FFLKDOLGILO<T> BGMOBGFDNIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class ODGLKKIFBFK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x84F43C0", Offset = "0x84F31C0", VA = "0x1884F43C0")]
	public ODGLKKIFBFK(string JDFCBBCKOGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class JDCMEEJJPBN<TOk> : ODGLKKIFBFK where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TOk DODKDNIAPPH;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x545CC30", Offset = "0x545BA30", VA = "0x18545CC30")]
	private JDCMEEJJPBN([In] TOk EJNDCOMCFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x545CAA0", Offset = "0x545B8A0", VA = "0x18545CAA0")]
	public static JDCMEEJJPBN<TOk> ELDPFIHNJDG([In] TOk EJNDCOMCFCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct GECIHKBMECG<TOk, TErr> : IEquatable<GECIHKBMECG<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly EqualityComparer<TErr> LCMAJCJMFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal readonly TErr ONNKDLNNKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal readonly TOk DODKDNIAPPH;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool ECCJKBMJJGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4FD3C50", Offset = "0x4FD2A50", VA = "0x184FD3C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool JHBMPCFGLDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4FD3860", Offset = "0x4FD2660", VA = "0x184FD3860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4FD7590", Offset = "0x4FD6390", VA = "0x184FD7590")]
	internal GECIHKBMECG([In] TErr EDGLLONCGOD, [In] TOk EJNDCOMCFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4FCEAC0", Offset = "0x4FCD8C0", VA = "0x184FCEAC0")]
	public static GECIHKBMECG<TOk, TErr> CNBACIEOCIE([In] TErr EDGLLONCGOD)
	{
		return default(GECIHKBMECG<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4FD2080", Offset = "0x4FD0E80", VA = "0x184FD2080")]
	public static GECIHKBMECG<TOk, TErr> HEMLGKCLKPA([In] TOk EJNDCOMCFCB)
	{
		return default(GECIHKBMECG<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x44843A0", Offset = "0x44831A0", VA = "0x1844843A0")]
	public GECIHKBMECG<TOk?, UErr?> JGNDPHMELML<UErr>()
	{
		return default(GECIHKBMECG<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x44856E0", Offset = "0x44844E0", VA = "0x1844856E0")]
	public GECIHKBMECG<UOk?, TErr?> PGFKOPAKBON<UOk>()
	{
		return default(GECIHKBMECG<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4483D80", Offset = "0x4482B80", VA = "0x184483D80")]
	public GECIHKBMECG<UOk?, TErr?> FCCFMAPDKIK<UOk>()
	{
		return default(GECIHKBMECG<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4484B20", Offset = "0x4483920", VA = "0x184484B20")]
	public GECIHKBMECG<TOk?, UErr?> OLEPKFLGKMB<UErr>()
	{
		return default(GECIHKBMECG<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4FCE2A0", Offset = "0x4FCD0A0", VA = "0x184FCE2A0")]
	public GECIHKBMECG<GFJAPJIFDGB, TErr> CAMDBHEJEJC()
	{
		return default(GECIHKBMECG<GFJAPJIFDGB, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4FD2640", Offset = "0x4FD1440", VA = "0x184FD2640")]
	public static bool IKIADGFKNFC([In] GECIHKBMECG<TOk, TErr> NNEMEIEKIAF, [In] GECIHKBMECG<TOk, TErr> JOGLOLMOJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4FCF2F0", Offset = "0x4FCE0F0", VA = "0x184FCF2F0", Slot = "4")]
	public bool Equals(GECIHKBMECG<TOk, TErr> FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4FCF540", Offset = "0x4FCE340", VA = "0x184FCF540", Slot = "0")]
	public override bool Equals(object FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4FD1730", Offset = "0x4FD0530", VA = "0x184FD1730", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4FD4BC0", Offset = "0x4FD39C0", VA = "0x184FD4BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class HGBBFHFDBLI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct NGDKDFHJFOE<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Task<GECIHKBMECG<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<GECIHKBMECG<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x597D060", Offset = "0x597BE60", VA = "0x18597D060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5699DC0", Offset = "0x5698BC0", VA = "0x185699DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct DLALFHCGFJB<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<GECIHKBMECG<GFJAPJIFDGB, TErr>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Task<GECIHKBMECG<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<GECIHKBMECG<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x4574BB0", Offset = "0x45739B0", VA = "0x184574BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x4574F00", Offset = "0x4573D00", VA = "0x184574F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct LAGLHPAFMMI<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Task<GECIHKBMECG<TOk, TErr>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<GECIHKBMECG<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x5670270", Offset = "0x566F070", VA = "0x185670270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x56707F0", Offset = "0x566F5F0", VA = "0x1856707F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3D16490", Offset = "0x3D15290", VA = "0x183D16490")]
	public static GECIHKBMECG<TOk?, TErr?> DODKDNIAPPH<TOk, TErr>([In] this GECIHKBMECG<TOk, TErr> DBBEADIHLKO, [In] TOk EJNDCOMCFCB)
	{
		return default(GECIHKBMECG<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3D16570", Offset = "0x3D15370", VA = "0x183D16570")]
	public static GECIHKBMECG<GFJAPJIFDGB, TErr?> DODKDNIAPPH<TErr>([In] this GECIHKBMECG<GFJAPJIFDGB, TErr> DBBEADIHLKO)
	{
		return default(GECIHKBMECG<GFJAPJIFDGB, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3D16490", Offset = "0x3D15290", VA = "0x183D16490")]
	public static GECIHKBMECG<TOk?, TErr?> ONNKDLNNKLK<TOk, TErr>([In] this GECIHKBMECG<TOk, TErr> DBBEADIHLKO, [In] TErr EDGLLONCGOD)
	{
		return default(GECIHKBMECG<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3D16BE0", Offset = "0x3D159E0", VA = "0x183D16BE0")]
	public static TOk? ENDPKAAEEFP<TOk, TErr>([In] this GECIHKBMECG<TOk, TErr> DBBEADIHLKO)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3D19330", Offset = "0x3D18130", VA = "0x183D19330")]
	[AsyncStateMachine(typeof(NGDKDFHJFOE<, >))]
	public static Task<TOk?>? KEBJBJEDFMK<TOk, TErr>(this Task<GECIHKBMECG<TOk, TErr>> DBBEADIHLKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3D176E0", Offset = "0x3D164E0", VA = "0x183D176E0")]
	public static TErr? GJJKLLACEPG<TErr, TOk>([In] this GECIHKBMECG<TOk, TErr> DBBEADIHLKO)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3D17C90", Offset = "0x3D16A90", VA = "0x183D17C90")]
	public static bool INPICBAMBFE<TOk, TErr, UErr, UOk>([In] this GECIHKBMECG<TOk, TErr> DBBEADIHLKO, [Out] GECIHKBMECG<UOk, UErr> NCJLDBCONMG) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3D1A130", Offset = "0x3D18F30", VA = "0x183D1A130")]
	public static bool NKGFALKNHNH<TOk, TErr>([In] this GECIHKBMECG<TOk, TErr> DBBEADIHLKO, [Out] TOk EJNDCOMCFCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3D16F10", Offset = "0x3D15D10", VA = "0x183D16F10")]
	public static bool FCPHGJLJPML<TOk, TErr>([In] this GECIHKBMECG<TOk, TErr> DBBEADIHLKO, [Out][NotNullWhen(true)] TErr EDGLLONCGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3D16250", Offset = "0x3D15050", VA = "0x183D16250")]
	public static bool CDCANHMIKND<TOk, TErr>([In] this GECIHKBMECG<TOk, TErr> DBBEADIHLKO, [Out][NotNullWhen(true)] TOk EJNDCOMCFCB, [Out][NotNullWhen(false)] TErr EDGLLONCGOD) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3D1A030", Offset = "0x3D18E30", VA = "0x183D1A030")]
	public static bool MOAJNONGIIE<TOk, TErr>([In] this GECIHKBMECG<TOk, TErr> DBBEADIHLKO, [Out][NotNullWhen(true)] TOk EJNDCOMCFCB, [Out] GECIHKBMECG<TOk, TErr> NCJLDBCONMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3D18010", Offset = "0x3D16E10", VA = "0x183D18010")]
	public static bool INPICBAMBFE<TOk, TErr, UErr, UOk>([In] this GECIHKBMECG<TOk, TErr> DBBEADIHLKO, [Out][NotNullWhen(true)] TOk EJNDCOMCFCB, [Out] GECIHKBMECG<UOk, UErr> NCJLDBCONMG) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3D170C0", Offset = "0x3D15EC0", VA = "0x183D170C0")]
	public static bool GINKEMLIMDK<TOk, TErr>([In] this GECIHKBMECG<TOk, TErr> DBBEADIHLKO, [Out][NotNullWhen(true)] TOk EJNDCOMCFCB, [Out] GECIHKBMECG<GFJAPJIFDGB, TErr> NCJLDBCONMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3D19720", Offset = "0x3D18520", VA = "0x183D19720")]
	public static GECIHKBMECG<UOk, UErr> LCEGJOKPBMG<UOk, UErr, TOk, TErr>([In] this GECIHKBMECG<TOk, TErr> DBBEADIHLKO, [In] GECIHKBMECG<UOk, UErr> OGPILIPEPKA) where TOk : UOk where TErr : UErr
	{
		return default(GECIHKBMECG<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3D17840", Offset = "0x3D16640", VA = "0x183D17840")]
	public static GECIHKBMECG<TOk?[]?, TErr?> IDFFCANLNIK<TOk, TErr>(this IEnumerable<GECIHKBMECG<TOk, TErr>> DBBEADIHLKO)
	{
		return default(GECIHKBMECG<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3D19DF0", Offset = "0x3D18BF0", VA = "0x183D19DF0")]
	public static GECIHKBMECG<UOk?, TErr?> LMIOGFGFMDJ<UOk, TErr, TOk>([In] this GECIHKBMECG<TOk, TErr> DBBEADIHLKO, Func<TOk, UOk> AAHFPNBFPHE)
	{
		return default(GECIHKBMECG<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3D16000", Offset = "0x3D14E00", VA = "0x183D16000")]
	[AsyncStateMachine(typeof(DLALFHCGFJB<, >))]
	public static Task<GECIHKBMECG<GFJAPJIFDGB, TErr?>>? ADOAJBFCFMF<TErr, TOk>(this Task<GECIHKBMECG<TOk, TErr>> DBBEADIHLKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3D16670", Offset = "0x3D15470", VA = "0x183D16670")]
	[AsyncStateMachine(typeof(LAGLHPAFMMI<, >))]
	public static Task<bool>? ECCJKBMJJGL<TOk, TErr>(this Task<GECIHKBMECG<TOk, TErr>> MGEGHBBNKMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class GHBMPCLGCEF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4485F00", Offset = "0x4484D00", VA = "0x184485F00")]
	public static GECIHKBMECG<TOk, T> DODKDNIAPPH<TOk>([In] TOk EJNDCOMCFCB) where TOk : notnull
	{
		return default(GECIHKBMECG<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4FE56A0", Offset = "0x4FE44A0", VA = "0x184FE56A0")]
	public static GECIHKBMECG<GFJAPJIFDGB, T> DODKDNIAPPH()
	{
		return default(GECIHKBMECG<GFJAPJIFDGB, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4485F00", Offset = "0x4484D00", VA = "0x184485F00")]
	public static GECIHKBMECG<T, TErr> ONNKDLNNKLK<TErr>([In] TErr EDGLLONCGOD) where TErr : notnull
	{
		return default(GECIHKBMECG<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct EILNAHHEBAK<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly DEOEKAJPIAG EBOPGIBHJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Dictionary<TKey, TValue> PMNHFDHGLNK;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4A61110", Offset = "0x4A5FF10", VA = "0x184A61110")]
	public static EILNAHHEBAK<TKey, TValue> ELDPFIHNJDG(string KKBNGKDBMPF)
	{
		return default(EILNAHHEBAK<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4A612E0", Offset = "0x4A600E0", VA = "0x184A612E0")]
	internal EILNAHHEBAK(Dictionary<TKey, TValue> HGMAIPELJHM, DEOEKAJPIAG BPJILCDFJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4A61230", Offset = "0x4A60030", VA = "0x184A61230")]
	public BPGKNIJKFHD<TKey, TValue> IAANDOPFMGB([Out] Dictionary<TKey, TValue> HGMAIPELJHM)
	{
		return default(BPGKNIJKFHD<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct BPGKNIJKFHD<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Dictionary<TKey, TValue> PMNHFDHGLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly OBHBFCMCBOC DBNELAOIKLF;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2D314D0", Offset = "0x2D302D0", VA = "0x182D314D0")]
	internal BPGKNIJKFHD(Dictionary<TKey, TValue> HGMAIPELJHM, OBHBFCMCBOC EAGPJIMALOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x548C7A0", Offset = "0x548B5A0", VA = "0x18548C7A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct LHEFHMLNMJC<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly DEOEKAJPIAG EBOPGIBHJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<T> PMNHFDHGLNK;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4A61110", Offset = "0x4A5FF10", VA = "0x184A61110")]
	public static LHEFHMLNMJC<T> ELDPFIHNJDG(string KKBNGKDBMPF)
	{
		return default(LHEFHMLNMJC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4A612E0", Offset = "0x4A600E0", VA = "0x184A612E0")]
	internal LHEFHMLNMJC(HashSet<T> HGMAIPELJHM, DEOEKAJPIAG BPJILCDFJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4A61230", Offset = "0x4A60030", VA = "0x184A61230")]
	public OGHIIJGNKAC<T> IAANDOPFMGB([Out] HashSet<T> HGMAIPELJHM)
	{
		return default(OGHIIJGNKAC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct OGHIIJGNKAC<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<T> PMNHFDHGLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly OBHBFCMCBOC DBNELAOIKLF;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2D314D0", Offset = "0x2D302D0", VA = "0x182D314D0")]
	internal OGHIIJGNKAC(HashSet<T> HGMAIPELJHM, OBHBFCMCBOC EAGPJIMALOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x548C7A0", Offset = "0x548B5A0", VA = "0x18548C7A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct HIMIOAIFPDP<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly DEOEKAJPIAG EBOPGIBHJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly Stack<T> PMNHFDHGLNK;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4A61110", Offset = "0x4A5FF10", VA = "0x184A61110")]
	public static HIMIOAIFPDP<T> ELDPFIHNJDG(string KKBNGKDBMPF)
	{
		return default(HIMIOAIFPDP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4A612E0", Offset = "0x4A600E0", VA = "0x184A612E0")]
	internal HIMIOAIFPDP(Stack<T> HGMAIPELJHM, DEOEKAJPIAG BPJILCDFJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4A61230", Offset = "0x4A60030", VA = "0x184A61230")]
	public APJFCIBCKPC<T> IAANDOPFMGB([Out] Stack<T> HGMAIPELJHM)
	{
		return default(APJFCIBCKPC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public readonly struct APJFCIBCKPC<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly Stack<T> PMNHFDHGLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly OBHBFCMCBOC DBNELAOIKLF;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2D314D0", Offset = "0x2D302D0", VA = "0x182D314D0")]
	internal APJFCIBCKPC(Stack<T> HGMAIPELJHM, OBHBFCMCBOC EAGPJIMALOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x548C7A0", Offset = "0x548B5A0", VA = "0x18548C7A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[DefaultMember("Item")]
public sealed class GBEMJNDKAPI<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct JCIIJPPANPO : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly GBEMJNDKAPI<T> CNJHCCDKGNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly int JPCHOJDFMPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly bool CPKCIPIJAFP;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2956E90", Offset = "0x2955C90", VA = "0x182956E90")]
		public JCIIJPPANPO(GBEMJNDKAPI<T> ICNBLBLHJLK, int OLAPGONODJJ, bool GANDOGGFBGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x545B490", Offset = "0x545A290", VA = "0x18545B490")]
		public GBEMJNDKAPI<T>.CIMHPMCDCAE OLGNAIIDMLF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x545B580", Offset = "0x545A380", VA = "0x18545B580", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x545B580", Offset = "0x545A380", VA = "0x18545B580", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public sealed class CIMHPMCDCAE : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly GBEMJNDKAPI<T> CNJHCCDKGNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly int GBJMKNCIHGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int OELCJBJLMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly bool CPKCIPIJAFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool HNMEBFOGBBP;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T BONNGALDEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x6C6CEE0", Offset = "0x6C6BCE0", VA = "0x186C6CEE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6C6D010", Offset = "0x6C6BE10", VA = "0x186C6D010", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6C6D1E0", Offset = "0x6C6BFE0", VA = "0x186C6D1E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D5E0", Offset = "0x6C6C3E0", VA = "0x186C6D5E0")]
		public CIMHPMCDCAE(GBEMJNDKAPI<T> ICNBLBLHJLK, int OLAPGONODJJ, bool GANDOGGFBGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6C6CF20", Offset = "0x6C6BD20", VA = "0x186C6CF20", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6C6CFB0", Offset = "0x6C6BDB0", VA = "0x186C6CFB0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class BOIANDDLKAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public BOIANDDLKAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x68CDD20", Offset = "0x68CCB20", VA = "0x1868CDD20")]
		internal T LHBPIFBKPOF(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly T[] KIPPBAIJDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int OELCJBJLMBI;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int OGBAECCNNAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4FCC2D0", Offset = "0x4FCB0D0", VA = "0x184FCC2D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T BONNGALDEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4EDE930", Offset = "0x4EDD730", VA = "0x184EDE930")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T PNHGDBJBEGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4FCC470", Offset = "0x4FCB270", VA = "0x184FCC470")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4FCC180", Offset = "0x4FCAF80", VA = "0x184FCC180")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int PJDGOCCOECF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x290F670", Offset = "0x290E470", VA = "0x18290F670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1D72BC0", Offset = "0x1D719C0", VA = "0x181D72BC0")]
	private static int APLNMIJLNML(int JJJJBEGKNIN, int MCJGICKIGFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4FCC720", Offset = "0x4FCB520", VA = "0x184FCC720")]
	public GBEMJNDKAPI(int BCMFMCHGEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4FCC5A0", Offset = "0x4FCB3A0", VA = "0x184FCC5A0")]
	public GBEMJNDKAPI(int BCMFMCHGEKF, Func<T> DNGGOADANOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4FCC500", Offset = "0x4FCB300", VA = "0x184FCC500")]
	public GBEMJNDKAPI(T[] LJHCADEPBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4FCC4A0", Offset = "0x4FCB2A0", VA = "0x184FCC4A0")]
	public void PIIKFFMPCDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4FCC320", Offset = "0x4FCB120", VA = "0x184FCC320")]
	public IEnumerable<T> NOLBECHNBDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4FCC3E0", Offset = "0x4FCB1E0", VA = "0x184FCC3E0")]
	public GBEMJNDKAPI<T>.CIMHPMCDCAE OLGNAIIDMLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4FCC4D0", Offset = "0x4FCB2D0", VA = "0x184FCC4D0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4FCC4D0", Offset = "0x4FCB2D0", VA = "0x184FCC4D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class PLMKBIENCHI
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3EFBD80", Offset = "0x3EFAB80", VA = "0x183EFBD80")]
	public static GBEMJNDKAPI<T> ELDPFIHNJDG<T>(int BCMFMCHGEKF, Func<T> DNGGOADANOE) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static RRColor White
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x70C75E0", Offset = "0x70C63E0", VA = "0x1870C75E0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x84F4FE0", Offset = "0x84F3DE0", VA = "0x1884F4FE0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x84F5000", Offset = "0x84F3E00", VA = "0x1884F5000")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x84F5020", Offset = "0x84F3E20", VA = "0x1884F5020")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x84F4FC0", Offset = "0x84F3DC0", VA = "0x1884F4FC0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0280", Offset = "0x2ABF080", VA = "0x182AC0280")]
		public RRColor(float BIHPDMNFJGD, float OLHLMPHEMHN, float KMNEIBIPMKI, float GENJGFGGINA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x83711B0", Offset = "0x836FFB0", VA = "0x1883711B0", Slot = "4")]
		public bool Equals(RRColor FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x84F4C10", Offset = "0x84F3A10", VA = "0x1884F4C10", Slot = "0")]
		public override bool Equals(object FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x84F4D10", Offset = "0x84F3B10", VA = "0x1884F4D10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x84F4D90", Offset = "0x84F3B90", VA = "0x1884F4D90", Slot = "5")]
		public string ToString(string DILPKDIDKCM, IFormatProvider AGBEIDMJODJ)
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct RRColor32 : IEquatable<RRColor32>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int rgba;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public byte r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public byte g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public byte b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public byte a;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static RRColor32 White
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x84F4BB0", Offset = "0x84F39B0", VA = "0x1884F4BB0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x84F4B50", Offset = "0x84F3950", VA = "0x1884F4B50")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x84F4B80", Offset = "0x84F3980", VA = "0x1884F4B80")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x84F4BE0", Offset = "0x84F39E0", VA = "0x1884F4BE0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x84F4B20", Offset = "0x84F3920", VA = "0x1884F4B20")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x628FA50", Offset = "0x628E850", VA = "0x18628FA50")]
		public RRColor32(byte BIHPDMNFJGD, byte OLHLMPHEMHN, byte KMNEIBIPMKI, byte GENJGFGGINA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x24B4C10", Offset = "0x24B3A10", VA = "0x1824B4C10", Slot = "4")]
		public bool Equals(RRColor32 FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x84F4680", Offset = "0x84F3480", VA = "0x1884F4680", Slot = "0")]
		public override bool Equals(object FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x15A02B0", Offset = "0x159F0B0", VA = "0x1815A02B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x84F4770", Offset = "0x84F3570", VA = "0x1884F4770")]
		public static RRColor32 MIDAFINGFAP(RRColor JMOOEAFLFLP)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x84F4700", Offset = "0x84F3500", VA = "0x1884F4700")]
		public static RRColor MIDAFINGFAP(RRColor32 JMOOEAFLFLP)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x84F48C0", Offset = "0x84F36C0", VA = "0x1884F48C0", Slot = "5")]
		public string ToString(string DILPKDIDKCM, IFormatProvider AGBEIDMJODJ)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class GPMMJOCOKJM<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public readonly struct PJKPCGIJHKP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly GPMMJOCOKJM<T> HJHJMPNMAEF;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T DDHBFJGPDAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x5C026A0", Offset = "0x5C014A0", VA = "0x185C026A0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5C02670", Offset = "0x5C01470", VA = "0x185C02670", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xEA8530", Offset = "0xEA7330", VA = "0x180EA8530")]
		public PJKPCGIJHKP(GPMMJOCOKJM<T> HJHJMPNMAEF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct EFFDPBMKJHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AsyncTaskMethodBuilder<PJKPCGIJHKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public GPMMJOCOKJM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4A52D00", Offset = "0x4A51B00", VA = "0x184A52D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4A52F70", Offset = "0x4A51D70", VA = "0x184A52F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly SemaphoreSlim BPBGIPLBJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private T KJDCMLLLKLE;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5014BC0", Offset = "0x50139C0", VA = "0x185014BC0")]
	public GPMMJOCOKJM([In] T KJDCMLLLKLE, int HNLBGFOAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5014BA0", Offset = "0x50139A0", VA = "0x185014BA0")]
	public GPMMJOCOKJM([In] T KJDCMLLLKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x50149C0", Offset = "0x50137C0", VA = "0x1850149C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5014A20", Offset = "0x5013820", VA = "0x185014A20")]
	public PJKPCGIJHKP KKJMELBMGHL()
	{
		return default(PJKPCGIJHKP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x50148A0", Offset = "0x50136A0", VA = "0x1850148A0")]
	[AsyncStateMachine(typeof(GPMMJOCOKJM<>.EFFDPBMKJHB))]
	public Task<GPMMJOCOKJM<T>.PJKPCGIJHKP> CFGJCDICOHL(CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5014A00", Offset = "0x5013800", VA = "0x185014A00")]
	public void FKNGNIFONDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class EEEMIFHECEH
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x84F1970", Offset = "0x84F0770", VA = "0x1884F1970")]
	public static GPMMJOCOKJM<GFJAPJIFDGB> ELDPFIHNJDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3AA5C50", Offset = "0x3AA4A50", VA = "0x183AA5C50")]
	public static GPMMJOCOKJM<T> ELDPFIHNJDG<T>([In] T KJDCMLLLKLE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public sealed class INFNFBOBJHH<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public readonly struct EAJLJFPKIPE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly INFNFBOBJHH<T> HBBPGNDCPCJ;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T DDHBFJGPDAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x4A33EE0", Offset = "0x4A32CE0", VA = "0x184A33EE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4A33B80", Offset = "0x4A32980", VA = "0x184A33B80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xEA8530", Offset = "0xEA7330", VA = "0x180EA8530")]
		internal EAJLJFPKIPE(INFNFBOBJHH<T> HJHJMPNMAEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public readonly struct PLGFBGKPNLH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly INFNFBOBJHH<T> HBBPGNDCPCJ;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T DDHBFJGPDAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x4A33EE0", Offset = "0x4A32CE0", VA = "0x184A33EE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5C09FF0", Offset = "0x5C08DF0", VA = "0x185C09FF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xEA8530", Offset = "0xEA7330", VA = "0x180EA8530")]
		internal PLGFBGKPNLH(INFNFBOBJHH<T> HJHJMPNMAEF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct OOPDFLBKDOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public AsyncTaskMethodBuilder<PLGFBGKPNLH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public INFNFBOBJHH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private GPMMJOCOKJM<GFJAPJIFDGB>.PJKPCGIJHKP <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private TaskAwaiter<GPMMJOCOKJM<GFJAPJIFDGB>.PJKPCGIJHKP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5B2D740", Offset = "0x5B2C540", VA = "0x185B2D740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4A52F70", Offset = "0x4A51D70", VA = "0x184A52F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly GPMMJOCOKJM<int> CFKBODOLOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly GPMMJOCOKJM<GFJAPJIFDGB> PGPIFGHENCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly GPMMJOCOKJM<GFJAPJIFDGB> MMNCAAOIAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private T DEEDJFLGJNG;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x522ED40", Offset = "0x522DB40", VA = "0x18522ED40")]
	internal INFNFBOBJHH(GPMMJOCOKJM<int> EKEHFCCPIBO, GPMMJOCOKJM<GFJAPJIFDGB> DBNABKLFKNA, GPMMJOCOKJM<GFJAPJIFDGB> PODKJDJBIMC, [In] T KJDCMLLLKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x522DFA0", Offset = "0x522CDA0", VA = "0x18522DFA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x522E120", Offset = "0x522CF20", VA = "0x18522E120")]
	public EAJLJFPKIPE HKFLJHHOJDB()
	{
		return default(EAJLJFPKIPE);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x522E9F0", Offset = "0x522D7F0", VA = "0x18522E9F0")]
	public PLGFBGKPNLH JKBMBEKOIPJ()
	{
		return default(PLGFBGKPNLH);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x522E660", Offset = "0x522D460", VA = "0x18522E660")]
	[AsyncStateMachine(typeof(INFNFBOBJHH<>.OOPDFLBKDOC))]
	public Task<INFNFBOBJHH<T>.PLGFBGKPNLH> ILHBIKOMGFH(CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class HNHCDDOHBLG
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x84F2820", Offset = "0x84F1620", VA = "0x1884F2820")]
	public static INFNFBOBJHH<GFJAPJIFDGB> ELDPFIHNJDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3D2D6A0", Offset = "0x3D2C4A0", VA = "0x183D2D6A0")]
	public static INFNFBOBJHH<T> ELDPFIHNJDG<T>([In] T KJDCMLLLKLE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class ENGOFMNMOBM<TData> : NILBFGOPNAM where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly string KFFFDCFEBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly TData CFOLCKLFPKO;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
	public override string PGDOAEFAHEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4A79000", Offset = "0x4A77E00", VA = "0x184A79000")]
	internal ENGOFMNMOBM(string JDFCBBCKOGJ, [In] TData KANAIIDGHCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class GLHKLMEIBPA
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x84F27A0", Offset = "0x84F15A0", VA = "0x1884F27A0")]
	public static ENGOFMNMOBM<GFJAPJIFDGB> ELDPFIHNJDG(string JDFCBBCKOGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3B53E10", Offset = "0x3B52C10", VA = "0x183B53E10")]
	public static ENGOFMNMOBM<TData> ELDPFIHNJDG<TData>(string JDFCBBCKOGJ, [In] TData KANAIIDGHCH) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class DEOEKAJPIAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal bool ACPPHNNJOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly string MHBNFKGNPOA;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xF8DAE0", Offset = "0xF8C8E0", VA = "0x180F8DAE0")]
	private DEOEKAJPIAG(bool HHMACMMGFJJ, string ELIGAIBOFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x84F1840", Offset = "0x84F0640", VA = "0x1884F1840")]
	public static DEOEKAJPIAG ELDPFIHNJDG(string ELIGAIBOFBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x84F18B0", Offset = "0x84F06B0", VA = "0x1884F18B0")]
	public OBHBFCMCBOC IAANDOPFMGB()
	{
		return default(OBHBFCMCBOC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct OBHBFCMCBOC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly DEOEKAJPIAG GPOHMLEHCKP;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0xEA8530", Offset = "0xEA7330", VA = "0x180EA8530")]
	internal OBHBFCMCBOC(DEOEKAJPIAG KKBNGKDBMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x84F43A0", Offset = "0x84F31A0", VA = "0x1884F43A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class ODNCNEIBGFI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class MHMKBNDHLLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public MHMKBNDHLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x58B5D60", Offset = "0x58B4B60", VA = "0x1858B5D60")]
		internal int JKMIFLIIKOI(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private HashSet<T>? PAHNAIGGFFP;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IReadOnlyCollection<T> FHAKHDMMAFE
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5ABB1A0", Offset = "0x5AB9FA0", VA = "0x185ABB1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool ACHEFJFHKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x52AD290", Offset = "0x52AC090", VA = "0x1852AD290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB210", Offset = "0x5ABA010", VA = "0x185ABB210")]
	public bool DPHJBDIDPOG(T OBGCPOCPFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB380", Offset = "0x5ABA180", VA = "0x185ABB380")]
	public bool MDNHCHGJFLC(T OBGCPOCPFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB1D0", Offset = "0x5AB9FD0", VA = "0x185ABB1D0")]
	public bool DHFLKPINICF(T OBGCPOCPFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB4A0", Offset = "0x5ABA2A0", VA = "0x185ABB4A0")]
	public void MPMLKHKIFLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB530", Offset = "0x5ABA330", VA = "0x185ABB530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public ODNCNEIBGFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class LKAPBLPAEMI
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class GDKBJCHNDJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public GDKBJCHNDJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x84F26F0", Offset = "0x84F14F0", VA = "0x1884F26F0")]
		internal int JKMIFLIIKOI(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private HashSet<object>? PAHNAIGGFFP;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyCollection<object> FHAKHDMMAFE
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x84F32B0", Offset = "0x84F20B0", VA = "0x1884F32B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool ACHEFJFHKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x84F3480", Offset = "0x84F2280", VA = "0x1884F3480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x84F33A0", Offset = "0x84F21A0", VA = "0x1884F33A0")]
	public bool DPHJBDIDPOG(object OBGCPOCPFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x84F3490", Offset = "0x84F2290", VA = "0x1884F3490")]
	public bool MDNHCHGJFLC(object OBGCPOCPFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x84F3340", Offset = "0x84F2140", VA = "0x1884F3340")]
	public bool DHFLKPINICF(object OBGCPOCPFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x84F3530", Offset = "0x84F2330", VA = "0x1884F3530")]
	public void MPMLKHKIFLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x84F35A0", Offset = "0x84F23A0", VA = "0x1884F35A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public LKAPBLPAEMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class AKJJENAIBLI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private struct IJJAKHJFKCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public float OJANKLJLDKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public T DDHBFJGPDAJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly Dictionary<object, IJJAKHJFKCK> IMNNEOMDPNB;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public virtual T IPEPFKPCFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x128D640", Offset = "0x128C440", VA = "0x18128D640", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1C4D200", Offset = "0x1C4C000", VA = "0x181C4D200", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public object? LHMMDLEDJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool ICFJMGAAFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x4F36030", Offset = "0x4F34E30", VA = "0x184F36030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x54711F0", Offset = "0x546FFF0", VA = "0x1854711F0")]
	public bool ACMJDELJLOF(T HGMAIPELJHM, object OBGCPOCPFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x4F36080", Offset = "0x4F34E80", VA = "0x184F36080")]
	public bool KMCKMJIAHCE(object OBGCPOCPFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x4F36000", Offset = "0x4F34E00", VA = "0x184F36000")]
	public void FMJEOCFJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5471670", Offset = "0x5470470", VA = "0x185471670")]
	public bool CFOKPIKBEGL(object OBGCPOCPFIJ, [Out] T HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5471790", Offset = "0x5470590", VA = "0x185471790")]
	[CPEHMMDJBME("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool MBNHHGNAIOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5472E50", Offset = "0x5471C50", VA = "0x185472E50")]
	public AKJJENAIBLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class PJGOEGFNGHE : AICOBKDFOEE<NLFFFLJOFLP>
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	internal class CAMGGBMLIEB : IEqualityComparer<NLFFFLJOFLP>
	{
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		internal static readonly CAMGGBMLIEB MOIOIMEFPHA;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x84F15A0", Offset = "0x84F03A0", VA = "0x1884F15A0", Slot = "4")]
		public bool Equals(NLFFFLJOFLP DBBMOEGPNPP, NLFFFLJOFLP COFKGIHGCOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x75C89B0", Offset = "0x75C77B0", VA = "0x1875C89B0", Slot = "5")]
		public int GetHashCode(NLFFFLJOFLP ALGAKMGCCLO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public CAMGGBMLIEB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x84F4610", Offset = "0x84F3410", VA = "0x1884F4610")]
	public PJGOEGFNGHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x84F44B0", Offset = "0x84F32B0", VA = "0x1884F44B0", Slot = "4")]
	public override bool DPHJBDIDPOG(NLFFFLJOFLP OBGCPOCPFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x84F4560", Offset = "0x84F3360", VA = "0x1884F4560", Slot = "5")]
	public override bool MDNHCHGJFLC(NLFFFLJOFLP OBGCPOCPFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x84F4420", Offset = "0x84F3220", VA = "0x1884F4420")]
	private static void CIEBBKMLFPA(NLFFFLJOFLP OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0xAF9F50", Offset = "0xAF8D50", VA = "0x180AF9F50", Slot = "6")]
	protected override string TokenToString(NLFFFLJOFLP OBGCPOCPFIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class NLFFFLJOFLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly string LCPJIAGKGJH;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
	public NLFFFLJOFLP(string LCPJIAGKGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x84F42D0", Offset = "0x84F30D0", VA = "0x1884F42D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class AICOBKDFOEE<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly IEqualityComparer<T> IFGHMFNGBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private HashSet<T>? PAHNAIGGFFP;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public IReadOnlyCollection<T> FHAKHDMMAFE
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x52ACF50", Offset = "0x52ABD50", VA = "0x1852ACF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool ACHEFJFHKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x52AD290", Offset = "0x52AC090", VA = "0x1852AD290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xAE69E0", Offset = "0xAE57E0", VA = "0x180AE69E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x52ADB90", Offset = "0x52AC990", VA = "0x1852ADB90")]
	public AICOBKDFOEE(IEqualityComparer<T> IFGHMFNGBPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x52ACF80", Offset = "0x52ABD80", VA = "0x1852ACF80", Slot = "4")]
	public virtual bool DPHJBDIDPOG(T OBGCPOCPFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x52AD3F0", Offset = "0x52AC1F0", VA = "0x1852AD3F0", Slot = "5")]
	public virtual bool MDNHCHGJFLC(T OBGCPOCPFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x52AD520", Offset = "0x52AC320", VA = "0x1852AD520")]
	public void MPMLKHKIFLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x52AD5B0", Offset = "0x52AC3B0", VA = "0x1852AD5B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public sealed class JCLHMFJHPPF<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<WeakReference<T>>? PAHNAIGGFFP;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool ACHEFJFHKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x545C5D0", Offset = "0x545B3D0", VA = "0x18545C5D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x545C470", Offset = "0x545B270", VA = "0x18545C470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x545C250", Offset = "0x545B050", VA = "0x18545C250")]
	public void DPHJBDIDPOG(T OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x545C6D0", Offset = "0x545B4D0", VA = "0x18545C6D0")]
	public void MDNHCHGJFLC(T OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x545C130", Offset = "0x545AF30", VA = "0x18545C130")]
	public bool DHFLKPINICF(T OBGCPOCPFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x545C830", Offset = "0x545B630", VA = "0x18545C830")]
	public void MPMLKHKIFLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x545C850", Offset = "0x545B650", VA = "0x18545C850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public JCLHMFJHPPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal static class CFDNAKEJOPO
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3B01250", Offset = "0x3B00050", VA = "0x183B01250")]
	public static void IEHBKJDDIBO<T>(this List<T> NGGCNGNMEBF, int JJJJBEGKNIN) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class FPNHLLCMAJL<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private struct CBECBCKNALL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float OJANKLJLDKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public T DDHBFJGPDAJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly Dictionary<NLFFFLJOFLP, CBECBCKNALL> IMNNEOMDPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly EqualityComparer<T> JGFBOIDNCPB;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public virtual T IPEPFKPCFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA98D20", Offset = "0xA97B20", VA = "0x180A98D20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA98C40", Offset = "0xA97A40", VA = "0x180A98C40", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private NLFFFLJOFLP? LHMMDLEDJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool ICFJMGAAFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x4F36030", Offset = "0x4F34E30", VA = "0x184F36030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x4F35E30", Offset = "0x4F34C30", VA = "0x184F35E30")]
	public bool ACMJDELJLOF(T HGMAIPELJHM, NLFFFLJOFLP OBGCPOCPFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x4F36080", Offset = "0x4F34E80", VA = "0x184F36080")]
	public bool KMCKMJIAHCE(NLFFFLJOFLP OBGCPOCPFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x4F36000", Offset = "0x4F34E00", VA = "0x184F36000")]
	public void FMJEOCFJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x4F35F10", Offset = "0x4F34D10", VA = "0x184F35F10")]
	public bool CFOKPIKBEGL(NLFFFLJOFLP OBGCPOCPFIJ, [Out] T HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x4F360F0", Offset = "0x4F34EF0", VA = "0x184F360F0")]
	[CPEHMMDJBME("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool MBNHHGNAIOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x4F36790", Offset = "0x4F35590", VA = "0x184F36790")]
	public FPNHLLCMAJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class JDPCOJKHHAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Dictionary<object, float> IMNNEOMDPNB;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float KDPNLGMOGGE
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xAE7AE0", Offset = "0xAE68E0", VA = "0x180AE7AE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x13D0900", Offset = "0x13CF700", VA = "0x1813D0900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x84F28F0", Offset = "0x84F16F0", VA = "0x1884F28F0")]
	public void ACMJDELJLOF(float HGMAIPELJHM, object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x84F2AE0", Offset = "0x84F18E0", VA = "0x1884F2AE0")]
	public void KMCKMJIAHCE(object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x84F2A90", Offset = "0x84F1890", VA = "0x1884F2A90")]
	public void FMJEOCFJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x84F2960", Offset = "0x84F1760", VA = "0x1884F2960")]
	private void ADNFEAEEOEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x84F2B50", Offset = "0x84F1950", VA = "0x1884F2B50")]
	public JDPCOJKHHAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface BHPGFHAPOHB
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event PDCLDPIMMNG POIGHBCIFAE;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class BFHAMNHOGPE : BHPGFHAPOHB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public readonly struct JPBOFDONBAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public readonly float DGOFKDGOMGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public readonly float OKAPFDDJAJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		internal readonly bool HCIMLNOEIII;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float JODCAOMDJAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x84F2BE0", Offset = "0x84F19E0", VA = "0x1884F2BE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x84F2D50", Offset = "0x84F1B50", VA = "0x1884F2D50")]
		public JPBOFDONBAB(float NBLNCONJINM, float MLFFNDAMMCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x84F2BF0", Offset = "0x84F19F0", VA = "0x1884F2BF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class NJMPEFONAFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public BFHAMNHOGPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public NJMPEFONAFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x84F4230", Offset = "0x84F3030", VA = "0x1884F4230")]
		internal void FPDNNOAGLAO(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly int FIBLEJKLMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private int JNKPDNOONBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly BHPGFHAPOHB[] BKDCCLMJFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly PDCLDPIMMNG[] OLPMMDDOCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly JPBOFDONBAB[] HLEPMKGCBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private JPBOFDONBAB BFNDCCBGBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly LJLABGKKKJJ EDBNPDPNIAD;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event PDCLDPIMMNG POIGHBCIFAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x84F0D90", Offset = "0x84EFB90", VA = "0x1884F0D90", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x84F12C0", Offset = "0x84F00C0", VA = "0x1884F12C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x84F1410", Offset = "0x84F0210", VA = "0x1884F1410")]
	public BFHAMNHOGPE(int FIBLEJKLMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x84F1380", Offset = "0x84F0180", VA = "0x1884F1380")]
	public LJLABGKKKJJ OKLILDJCEDJ(JPBOFDONBAB JBEBIIPBGHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x84F0E50", Offset = "0x84EFC50", VA = "0x1884F0E50")]
	public void KIAJEDBOMCE(BHPGFHAPOHB NDAHDPBEPLC, [Optional] JPBOFDONBAB EOMNLDEBJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x84F0C80", Offset = "0x84EFA80", VA = "0x1884F0C80", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public delegate void PDCLDPIMMNG(float JKBCNBCAOIC);
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class DEIOIKAOMCG
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private class CGLGLKBGGNE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly BHPGFHAPOHB MPFJACAONNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly PDCLDPIMMNG LBJMJKFNAPH;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x84F1680", Offset = "0x84F0480", VA = "0x1884F1680")]
		public CGLGLKBGGNE(BHPGFHAPOHB MPFJACAONNN, PDCLDPIMMNG LBJMJKFNAPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x84F1630", Offset = "0x84F0430", VA = "0x1884F1630", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x84F17D0", Offset = "0x84F05D0", VA = "0x1884F17D0")]
	internal static bool EKPPIGLGNHD(float GENJGFGGINA, float KMNEIBIPMKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x84DE380", Offset = "0x84DD180", VA = "0x1884DE380")]
	internal static float BODHKODIBKN(float GENJGFGGINA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x84F1710", Offset = "0x84F0510", VA = "0x1884F1710")]
	public static IDisposable CFEMECOEEME(this BHPGFHAPOHB MPFJACAONNN, PDCLDPIMMNG LBJMJKFNAPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class LJLABGKKKJJ : BHPGFHAPOHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private float JKBCNBCAOIC;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public float HJLNCFNCDBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x84F3120", Offset = "0x84F1F20", VA = "0x1884F3120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event PDCLDPIMMNG? POIGHBCIFAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x84F3080", Offset = "0x84F1E80", VA = "0x1884F3080", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x84F3210", Offset = "0x84F2010", VA = "0x1884F3210", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public LJLABGKKKJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface LLFPOGEDKNK<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CKALINJENEI<T> HIGNFNKNAEG([Out] T HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FMJEOCFJDAJ();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class PHDGMONNNGL<T> : LLFPOGEDKNK<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly ConcurrentStack<T> EDOLDMEJGJO;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5BFB0D0", Offset = "0x5BF9ED0", VA = "0x185BFB0D0", Slot = "4")]
	public CKALINJENEI<T> HIGNFNKNAEG([Out] T HGMAIPELJHM)
	{
		return default(CKALINJENEI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5BFB160", Offset = "0x5BF9F60", VA = "0x185BFB160")]
	public void OJNCHOHBCNI(T BFIHBNLKKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x55D9D40", Offset = "0x55D8B40", VA = "0x1855D9D40", Slot = "5")]
	public void FMJEOCFJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "6")]
	protected virtual void NJCIIEIMNGG(T GNKALKJJCPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5BFB040", Offset = "0x5BF9E40", VA = "0x185BFB040")]
	private T DPMBHNJHJDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5BFB1C0", Offset = "0x5BF9FC0", VA = "0x185BFB1C0")]
	public PHDGMONNNGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct CKALINJENEI<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly T BFIHBNLKKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly PHDGMONNNGL<T> NMIHGIEBNBF;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0xC55370", Offset = "0xC54170", VA = "0x180C55370")]
	internal CKALINJENEI(T HGMAIPELJHM, PHDGMONNNGL<T> NMIHGIEBNBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6C73960", Offset = "0x6C72760", VA = "0x186C73960", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class KIFJFPBLOPG : PHDGMONNNGL<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public static readonly KIFJFPBLOPG MOIOIMEFPHA;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x84F2EB0", Offset = "0x84F1CB0", VA = "0x1884F2EB0")]
	public static CKALINJENEI<StringBuilder> DPMBHNJHJDJ([Out] StringBuilder HGMAIPELJHM)
	{
		return default(CKALINJENEI<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x84F2F50", Offset = "0x84F1D50", VA = "0x1884F2F50", Slot = "6")]
	protected override void NJCIIEIMNGG(StringBuilder GNKALKJJCPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x84F3000", Offset = "0x84F1E00", VA = "0x1884F3000")]
	public KIFJFPBLOPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class NEMNCIPPFGM : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7D39830", Offset = "0x7D38630", VA = "0x187D39830")]
	public NEMNCIPPFGM(string JDFCBBCKOGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[DefaultMember("Item")]
public class BIAJFDDGDAC<TKey, TValue> : GFHJOCCEIAE<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, OIOKAIJCAKP where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class OLBLJNIOCOB : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public BIAJFDDGDAC<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x128D640", Offset = "0x128C440", VA = "0x18128D640", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x4F77990", Offset = "0x4F76790", VA = "0x184F77990", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
		[DebuggerHidden]
		public OLBLJNIOCOB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4F779E0", Offset = "0x4F767E0", VA = "0x184F779E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x5AD7890", Offset = "0x5AD6690", VA = "0x185AD7890", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x5AD83D0", Offset = "0x5AD71D0", VA = "0x185AD83D0")]
		private void POCLDLCLENG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x5AD77A0", Offset = "0x5AD65A0", VA = "0x185AD77A0")]
		private void DFGOGGAACMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x5AD8510", Offset = "0x5AD7310", VA = "0x185AD8510", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly GFHJOCCEIAE<TKey, TValue> ALIACOKKGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly IDictionary<TKey, TValue> OGGGAFOFKKN;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x66EF040", Offset = "0x66EDE40", VA = "0x1866EF040", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool MCPDIAGDFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public TValue ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x66EF210", Offset = "0x66EE010", VA = "0x1866EF210", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x66EF470", Offset = "0x66EE270", VA = "0x1866EF470", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICollection<TKey> JDFHDDCJEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x66EF250", Offset = "0x66EE050", VA = "0x1866EF250", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public ICollection<TValue> BPHFEJAHHNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x66EF360", Offset = "0x66EE160", VA = "0x1866EF360", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x66EEEC0", Offset = "0x66EDCC0", VA = "0x1866EEEC0")]
	public BIAJFDDGDAC(GFHJOCCEIAE<TKey, TValue> ALIACOKKGIB, [Optional] IDictionary<TKey, TValue>? OGGGAFOFKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x66ECD80", Offset = "0x66EBB80", VA = "0x1866ECD80", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x66EE160", Offset = "0x66ECF60", VA = "0x1866EE160")]
	public void NDGNKFFCMEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x66ECB40", Offset = "0x66EB940", VA = "0x1866ECB40", Slot = "9")]
	public void Add(TKey OPGJHIOADCK, TValue HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x66EDD30", Offset = "0x66ECB30", VA = "0x1866EDD30")]
	public void JDDIFGLINLP(TKey OPGJHIOADCK, TValue HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x66EDFB0", Offset = "0x66ECDB0", VA = "0x1866EDFB0")]
	public void JKCNGNFEOAN(TKey OPGJHIOADCK, TValue HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x66EC550", Offset = "0x66EB350", VA = "0x1866EC550")]
	public void AGABJJLBPGP(TKey OPGJHIOADCK, TValue HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x66EDBC0", Offset = "0x66EC9C0", VA = "0x1866EDBC0")]
	public void HIENLBBDNLG(TKey OPGJHIOADCK, TValue HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x66EE530", Offset = "0x66ED330", VA = "0x1866EE530", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> IIHDHELGAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x66EE570", Offset = "0x66ED370", VA = "0x1866EE570", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x66EE8D0", Offset = "0x66ED6D0", VA = "0x1866EE8D0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x66ECE90", Offset = "0x66EBC90", VA = "0x1866ECE90", Slot = "8")]
	public bool ContainsKey(TKey OPGJHIOADCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x66EC7F0", Offset = "0x66EB5F0", VA = "0x1866EC7F0")]
	public bool AJHAPGGJPJA(TKey OPGJHIOADCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x66ED940", Offset = "0x66EC740", VA = "0x1866ED940")]
	public bool FFMDGDMJHAC(TKey OPGJHIOADCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x66EE2A0", Offset = "0x66ED0A0", VA = "0x1866EE2A0", Slot = "10")]
	public bool Remove(TKey OPGJHIOADCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x66EED10", Offset = "0x66EDB10", VA = "0x1866EED10", Slot = "11")]
	public bool TryGetValue(TKey OPGJHIOADCK, [Out] TValue HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x66ECF40", Offset = "0x66EBD40", VA = "0x1866ECF40", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] ELLFIONNNHC, int JIAHMCCMBBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x553B0B0", Offset = "0x5539EB0", VA = "0x18553B0B0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x66EDA10", Offset = "0x66EC810", VA = "0x1866EDA10", Slot = "19")]
	[IteratorStateMachine(typeof(BIAJFDDGDAC<, >.OLBLJNIOCOB))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x66EE250", Offset = "0x66ED050", VA = "0x1866EE250", Slot = "21")]
	public bool NGDHKDIILBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x66ED7E0", Offset = "0x66EC5E0", VA = "0x1866ED7E0")]
	private TValue DAJOLLIOAOL(TKey OPGJHIOADCK)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface JLFFIJIGLKM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string HANFHFEOCGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface OIOKAIJCAKP
{
	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NGDHKDIILBN();
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface GFHJOCCEIAE<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, OIOKAIJCAKP
{
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[DefaultMember("Item")]
public sealed class JHCBDKPEMLJ<TKey, TVal> : GFHJOCCEIAE<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, OIOKAIJCAKP where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public delegate int KCPIANEABHH(TKey OPGJHIOADCK, TVal HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public delegate void OCOMILOGKOG(TKey OPGJHIOADCK, TVal HGMAIPELJHM, GGMLKDFONEF BCDABHDFJPD);

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private class JLEJCJGJPAI
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public TKey DIHMBOJAPGN
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xEAB020", Offset = "0xEA9E20", VA = "0x180EAB020")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public TVal DDHBFJGPDAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xAE69E0", Offset = "0xAE57E0", VA = "0x180AE69E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public int JODCAOMDJAF
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xC38810", Offset = "0xC37610", VA = "0x180C38810")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x107E820", Offset = "0x107D620", VA = "0x18107E820")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public DateTimeOffset NMEODJKILCA
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x141B2F0", Offset = "0x141A0F0", VA = "0x18141B2F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x1553FB0", Offset = "0x1552DB0", VA = "0x181553FB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x54B54A0", Offset = "0x54B42A0", VA = "0x1854B54A0")]
		public JLEJCJGJPAI(TKey OPGJHIOADCK, TVal DOMECMGKIBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class IBMDEAIBCAI : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public JHCBDKPEMLJ<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private LinkedList<JLEJCJGJPAI>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x128D640", Offset = "0x128C440", VA = "0x18128D640", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x5208FD0", Offset = "0x5207DD0", VA = "0x185208FD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
		[DebuggerHidden]
		public IBMDEAIBCAI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x4A44230", Offset = "0x4A43030", VA = "0x184A44230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x5208190", Offset = "0x5206F90", VA = "0x185208190", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5208D40", Offset = "0x5207B40", VA = "0x185208D40")]
		private void POCLDLCLENG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5208EE0", Offset = "0x5207CE0", VA = "0x185208EE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public const int OBKANLEGOAO = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly Dictionary<TKey, LinkedListNode<JLEJCJGJPAI>> AGHOPMGILAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly LinkedList<JLEJCJGJPAI> OLPGOLFKKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly KCPIANEABHH? KJIBONJLGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly TimeSpan NGIGMACIOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly OCOMILOGKOG? LHLCDJMBDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly BKDMPJHFGEA IIDGIEIPLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private bool EFGFBNLLPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly List<TKey> PIHPDONIGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly List<TVal> EHGDIAECNFF;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int APDEGNKEIMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xB16A90", Offset = "0xB15890", VA = "0x180B16A90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	internal int EJCNLGIFONI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xEA0FC0", Offset = "0xE9FDC0", VA = "0x180EA0FC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xFD2960", Offset = "0xFD1760", VA = "0x180FD2960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x546FC00", Offset = "0x546EA00", VA = "0x18546FC00", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	internal int HHFNNCLDCPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x54695D0", Offset = "0x54683D0", VA = "0x1854695D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public ICollection<TVal> BPHFEJAHHNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x546FD00", Offset = "0x546EB00", VA = "0x18546FD00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	ICollection<TKey> IDictionary<TKey, TVal>.GMEDDDMEEDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x546E730", Offset = "0x546D530", VA = "0x18546E730", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool MCPDIAGDFHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public TVal ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x546FC60", Offset = "0x546EA60", VA = "0x18546FC60", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x546FD70", Offset = "0x546EB70", VA = "0x18546FD70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x546CB50", Offset = "0x546B950", VA = "0x18546CB50")]
	private bool HFMPBKHKMOP(int FIBLEJKLMBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x546AA40", Offset = "0x5469840", VA = "0x18546AA40")]
	private void EDDJHPOOOFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x546F260", Offset = "0x546E060", VA = "0x18546F260")]
	public JHCBDKPEMLJ(int FIBLEJKLMBM, [Optional] KCPIANEABHH? KJIBONJLGAA, [Optional] IEqualityComparer<TKey>? BIFFKAEIANA, [Optional] OCOMILOGKOG? LHLCDJMBDAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x546ECF0", Offset = "0x546DAF0", VA = "0x18546ECF0")]
	public JHCBDKPEMLJ(TimeSpan NGIGMACIOOM, [Optional] IEqualityComparer<TKey>? BIFFKAEIANA, [Optional] OCOMILOGKOG? LHLCDJMBDAA, [Optional] BKDMPJHFGEA? IIDGIEIPLGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x546F150", Offset = "0x546DF50", VA = "0x18546F150")]
	public JHCBDKPEMLJ(int FIBLEJKLMBM, TimeSpan NGIGMACIOOM, [Optional] IEqualityComparer<TKey>? BIFFKAEIANA, [Optional] OCOMILOGKOG? LHLCDJMBDAA, [Optional] BKDMPJHFGEA? IIDGIEIPLGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x546ED40", Offset = "0x546DB40", VA = "0x18546ED40")]
	public JHCBDKPEMLJ(int FIBLEJKLMBM, KCPIANEABHH? KJIBONJLGAA, TimeSpan NGIGMACIOOM, [Optional] IEqualityComparer<TKey>? BIFFKAEIANA, [Optional] OCOMILOGKOG? LHLCDJMBDAA, [Optional] BKDMPJHFGEA? IIDGIEIPLGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x546CD80", Offset = "0x546BB80", VA = "0x18546CD80", Slot = "21")]
	public bool NGDHKDIILBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x546CBA0", Offset = "0x546B9A0", VA = "0x18546CBA0", Slot = "22")]
	public bool HHAGINAGIJA(int BCMFMCHGEKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x546C5F0", Offset = "0x546B3F0", VA = "0x18546C5F0")]
	private bool HBCOFEDACGN(int BCMFMCHGEKF, GGMLKDFONEF BCDABHDFJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x54692F0", Offset = "0x54680F0", VA = "0x1854692F0")]
	public void BNFJAIPBEBA(TKey OPGJHIOADCK, TVal HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5468FD0", Offset = "0x5467DD0", VA = "0x185468FD0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> IIHDHELGAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5469050", Offset = "0x5467E50", VA = "0x185469050", Slot = "9")]
	public void Add(TKey OPGJHIOADCK, TVal HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5469770", Offset = "0x5468570", VA = "0x185469770", Slot = "8")]
	public bool ContainsKey(TKey OPGJHIOADCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x546E240", Offset = "0x546D040", VA = "0x18546E240", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x546DFB0", Offset = "0x546CDB0", VA = "0x18546DFB0", Slot = "10")]
	public bool Remove(TKey OPGJHIOADCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x546E600", Offset = "0x546D400", VA = "0x18546E600", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x546B310", Offset = "0x546A110", VA = "0x18546B310")]
	private bool ENMCGJLCNCL(TKey OPGJHIOADCK, [Out] TVal HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x546A730", Offset = "0x5469530", VA = "0x18546A730")]
	private TVal DPMBHNJHJDJ(TKey LKKMNPAKFAL)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x546E790", Offset = "0x546D590", VA = "0x18546E790", Slot = "11")]
	public bool TryGetValue(TKey LKKMNPAKFAL, [Out] TVal HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5469610", Offset = "0x5468410", VA = "0x185469610", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5469B20", Offset = "0x5468920", VA = "0x185469B20", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] ELLFIONNNHC, int JIAHMCCMBBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x546D090", Offset = "0x546BE90", VA = "0x18546D090")]
	private void PNEPHMIDPFP(TKey OPGJHIOADCK, TVal DOMECMGKIBN, GGMLKDFONEF BCDABHDFJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x546B6C0", Offset = "0x546A4C0", VA = "0x18546B6C0")]
	private bool FGMFCMBKIFJ(JLEJCJGJPAI BOBKLCPELDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x546D660", Offset = "0x546C460", VA = "0x18546D660")]
	private void PPLDFLCCOKP(LinkedListNode<JLEJCJGJPAI> EFPNIBOKJAJ, TVal GNOMIJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x54685C0", Offset = "0x54673C0", VA = "0x1854685C0")]
	private void ACMJDELJLOF(TKey OPGJHIOADCK, TVal HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x546A1C0", Offset = "0x5468FC0", VA = "0x18546A1C0")]
	private void DDNHNGLLDEO(JLEJCJGJPAI BOBKLCPELDF, TVal GNOMIJMEGAG, int EENPPNCKGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x546B9C0", Offset = "0x546A7C0", VA = "0x18546B9C0", Slot = "19")]
	[IteratorStateMachine(typeof(JHCBDKPEMLJ<, >.IBMDEAIBCAI))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x546E760", Offset = "0x546D560", VA = "0x18546E760", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public enum GGMLKDFONEF : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class GHEHFMLNIPB<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly TKey EDMKDLLKELP;

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x4FE5FE0", Offset = "0x4FE4DE0", VA = "0x184FE5FE0")]
	public GHEHFMLNIPB(TKey ADKPELGKACD, Exception HDEBIKIKFKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class JMJBKKEIBFK : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x755C800", Offset = "0x755B600", VA = "0x18755C800")]
	public JMJBKKEIBFK(string JDFCBBCKOGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class IJBKKOGNFGH<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class PGNPJPLJIEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public IJBKKOGNFGH<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public PGNPJPLJIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5BF9EC0", Offset = "0x5BF8CC0", VA = "0x185BF9EC0")]
		internal Task<TResource> HHOOKLBFGAH(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct BECGLAGFGGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public IJBKKOGNFGH<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x6602F50", Offset = "0x6601D50", VA = "0x186602F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6603880", Offset = "0x6602680", VA = "0x186603880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct CHNKGJOMGDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6C6B360", Offset = "0x6C6A160", VA = "0x186C6B360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6C6BAC0", Offset = "0x6C6A8C0", VA = "0x186C6BAC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly DKGBGLDFCKF<TId, Task<TResource>> ILGAPHGFBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> OFILJDENDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? ELCIOFBLKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly Action<TResource>? HAOGKEEDLII;

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x521D030", Offset = "0x521BE30", VA = "0x18521D030")]
	public IJBKKOGNFGH(int LABFPKGJNOB = 0, [Optional] IEqualityComparer<TId>? DDEIJIECEIJ, [Optional] Func<TId, CancellationToken, Task<TResource>>? KIBBCONFMFD, [Optional] Action<TResource>? HNCIBABEBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x521BF10", Offset = "0x521AD10", VA = "0x18521BF10")]
	public JAFFBBCIDNI<Task<TResource>> HNALGEGIBAF(TId FMFDAFLDAAK, [Optional] Func<TId, CancellationToken, Task<TResource>>? KIBBCONFMFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x521B920", Offset = "0x521A720", VA = "0x18521B920")]
	private void EEMDJEPOHOI(Task<TResource> MGEGHBBNKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x521C620", Offset = "0x521B420", VA = "0x18521C620")]
	[AsyncStateMachine(typeof(IJBKKOGNFGH<, >.BECGLAGFGGP))]
	private Task JEDDNIPLNPM(Task<TResource> MGEGHBBNKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x521C820", Offset = "0x521B620", VA = "0x18521C820")]
	public void OFEJMMBCIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x521CD80", Offset = "0x521BB80", VA = "0x18521CD80")]
	public DKGBGLDFCKF<TId, Task<TResource>>.NFCPKEFLLBF OLGNAIIDMLF()
	{
		return default(DKGBGLDFCKF<TId, Task<TResource>>.NFCPKEFLLBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x521CF00", Offset = "0x521BD00", VA = "0x18521CF00", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x521CF00", Offset = "0x521BD00", VA = "0x18521CF00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x521CAB0", Offset = "0x521B8B0", VA = "0x18521CAB0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(IJBKKOGNFGH<, >.CHNKGJOMGDH))]
	internal static Task OJDHELPGLEH(Task<TResource> MGEGHBBNKMN, CancellationTokenSource OBNLICOECJC, Dictionary<Task<TResource>, CancellationTokenSource> EIMLFOKMGAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class DKGBGLDFCKF<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class KBJPAHLGEKJ : IEquatable<KBJPAHLGEKJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public readonly TValue DDHBFJGPDAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int MNJOMBCNLOE;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x10058E0", Offset = "0x10046E0", VA = "0x1810058E0")]
		public KBJPAHLGEKJ(TValue HGMAIPELJHM, int MODNKLDFCDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x5566790", Offset = "0x5565590", VA = "0x185566790", Slot = "4")]
		public bool Equals(KBJPAHLGEKJ? FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x55666F0", Offset = "0x55654F0", VA = "0x1855666F0", Slot = "0")]
		public override bool Equals(object? ALGAKMGCCLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x55668B0", Offset = "0x55656B0", VA = "0x1855668B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public struct NFCPKEFLLBF : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private Dictionary<TKey, KBJPAHLGEKJ>.Enumerator OJJHPLICCIB;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x5968CA0", Offset = "0x5967AA0", VA = "0x185968CA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public (TKey Key, TValue Value, int RefCount) BONNGALDEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x5968F90", Offset = "0x5967D90", VA = "0x185968F90", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x5968ED0", Offset = "0x5967CD0", VA = "0x185968ED0")]
		public NFCPKEFLLBF(DKGBGLDFCKF<TKey, TValue> IMNNEOMDPNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x5968790", Offset = "0x5967590", VA = "0x185968790", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x59687D0", Offset = "0x59675D0", VA = "0x1859687D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x5968890", Offset = "0x5967690", VA = "0x185968890", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class KJHNKJPBODN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public DKGBGLDFCKF<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public KBJPAHLGEKJ refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public KJHNKJPBODN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x55EB700", Offset = "0x55EA500", VA = "0x1855EB700")]
		internal void HHOOKLBFGAH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly Dictionary<TKey, KBJPAHLGEKJ> HDPALEDNGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Func<TKey, TValue>? OMGDAMLOLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly Action<TValue>? OLACFGBPKKA;

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x45720E0", Offset = "0x4570EE0", VA = "0x1845720E0")]
	public DKGBGLDFCKF(int LABFPKGJNOB = 0, [Optional] IEqualityComparer<TKey>? BIFFKAEIANA, [Optional] Func<TKey, TValue>? HODANBINOIO, [Optional] Action<TValue>? AAAADKJAKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x45712B0", Offset = "0x45700B0", VA = "0x1845712B0")]
	public JAFFBBCIDNI<TValue> HNALGEGIBAF(TKey OPGJHIOADCK, [Optional] Func<TKey, TValue>? OGLMMGAMJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x4571B60", Offset = "0x4570960", VA = "0x184571B60")]
	private void OJNCHOHBCNI(TKey OPGJHIOADCK, KBJPAHLGEKJ FCBOHKNIALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x4571970", Offset = "0x4570770", VA = "0x184571970")]
	public void OFEJMMBCIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x4571E50", Offset = "0x4570C50", VA = "0x184571E50")]
	public NFCPKEFLLBF OLGNAIIDMLF()
	{
		return default(NFCPKEFLLBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x4571F10", Offset = "0x4570D10", VA = "0x184571F10", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x4571F10", Offset = "0x4570D10", VA = "0x184571F10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
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
