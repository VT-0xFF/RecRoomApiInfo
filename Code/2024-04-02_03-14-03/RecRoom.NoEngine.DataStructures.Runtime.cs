using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x61CE870", Offset = "0x61CD470", VA = "0x1861CE870")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DB530", Offset = "0x7DA130", VA = "0x1807DB530")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DB570", Offset = "0x7DA170", VA = "0x1807DB570")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class ODNICIGAFHF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	protected ODNICIGAFHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class JCBALJNBEJJ<T> : ODNICIGAFHF
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct CEMHBOPGLOE
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum JLACGHEAJFB
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
		public JLACGHEAJFB CJEAJMFMNNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T ODKDNEPMNIA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int BEOJOCGBDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool GEKHENLLBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool LPGNJCDEAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? FOAIOJHFGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<CEMHBOPGLOE>? HHHGFGBPIIO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool KBFMDOMEEFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3AEA6E0", Offset = "0x3AE92E0", VA = "0x183AEA6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3AEADE0", Offset = "0x3AE99E0", VA = "0x183AEADE0")]
	protected JCBALJNBEJJ(bool LPGNJCDEAAL, bool GEKHENLLBJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3AEAD40", Offset = "0x3AE9940", VA = "0x183AEAD40")]
	protected bool JKIHOAHNONF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3AEAAC0", Offset = "0x3AE96C0", VA = "0x183AEAAC0")]
	protected void GCANENGPNFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3AEA500", Offset = "0x3AE9100", VA = "0x183AEA500")]
	protected void AEADEBKFAPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x25A4040", Offset = "0x25A2C40", VA = "0x1825A4040")]
	private static void KJGHNIPACFJ<U>(List<U>? GPOHBJENHCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3AEA730", Offset = "0x3AE9330", VA = "0x183AEA730", Slot = "4")]
	public void BGJHDHHBMPP(T ODKDNEPMNIA, bool ALNGFHLDKLE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3AEA910", Offset = "0x3AE9510", VA = "0x183AEA910", Slot = "5")]
	public void DMBJGENFJDP(T ODKDNEPMNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3AEABC0", Offset = "0x3AE97C0", VA = "0x183AEABC0")]
	public void GEDHBEKABPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CLHJAHOCHKG
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGJHDHHBMPP(Action ODKDNEPMNIA, bool ALNGFHLDKLE = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMBJGENFJDP(Action ODKDNEPMNIA);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class GPEAFMNAGCL : JCBALJNBEJJ<Action>, CLHJAHOCHKG
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x61CD1B0", Offset = "0x61CBDB0", VA = "0x1861CD1B0")]
	public GPEAFMNAGCL(bool LPGNJCDEAAL = false, bool GEKHENLLBJE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x61CCF50", Offset = "0x61CBB50", VA = "0x1861CCF50")]
	public void EMODIMFPKPL()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x61CCEF0", Offset = "0x61CBAF0", VA = "0x1861CCEF0")]
	public static GPEAFMNAGCL DBLKOCIAKKD(GPEAFMNAGCL FBECLAJCFAB, Action ODKDNEPMNIA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x61CD150", Offset = "0x61CBD50", VA = "0x1861CD150")]
	public static GPEAFMNAGCL GIGILBKKNHF(GPEAFMNAGCL FBECLAJCFAB, Action ODKDNEPMNIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface FCNAIFBJBDA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGJHDHHBMPP(Action<T> ODKDNEPMNIA, bool ALNGFHLDKLE = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMBJGENFJDP(Action<T> ODKDNEPMNIA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class CGCFLAHJDPK<T> : JCBALJNBEJJ<Action<T>>, FCNAIFBJBDA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3686700", Offset = "0x3685300", VA = "0x183686700")]
	public CGCFLAHJDPK(bool LPGNJCDEAAL = false, bool GEKHENLLBJE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4BB0000", Offset = "0x4BAEC00", VA = "0x184BB0000")]
	public void EMODIMFPKPL(T JIGADAOLAJF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3C35470", Offset = "0x3C34070", VA = "0x183C35470")]
	public static CGCFLAHJDPK<T> DBLKOCIAKKD(CGCFLAHJDPK<T> FBECLAJCFAB, Action<T> ODKDNEPMNIA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3C35D20", Offset = "0x3C34920", VA = "0x183C35D20")]
	public static CGCFLAHJDPK<T> GIGILBKKNHF(CGCFLAHJDPK<T> FBECLAJCFAB, Action<T> ODKDNEPMNIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LOALEPOILIB<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class MICCGNDBPKA<T, U> : JCBALJNBEJJ<Action<T, U>>, LOALEPOILIB<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3686700", Offset = "0x3685300", VA = "0x183686700")]
	public MICCGNDBPKA(bool LPGNJCDEAAL = false, bool GEKHENLLBJE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3E35C60", Offset = "0x3E34860", VA = "0x183E35C60")]
	public void EMODIMFPKPL(T JIGADAOLAJF, U OIHOENPAIEA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3C35470", Offset = "0x3C34070", VA = "0x183C35470")]
	public static MICCGNDBPKA<T, U> DBLKOCIAKKD(MICCGNDBPKA<T, U> FBECLAJCFAB, Action<T, U> ODKDNEPMNIA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3C35D20", Offset = "0x3C34920", VA = "0x183C35D20")]
	public static MICCGNDBPKA<T, U> GIGILBKKNHF(MICCGNDBPKA<T, U> FBECLAJCFAB, Action<T, U> ODKDNEPMNIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class BFGGANIGMAO<T, U, V> : JCBALJNBEJJ<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3686700", Offset = "0x3685300", VA = "0x183686700")]
	public BFGGANIGMAO(bool LPGNJCDEAAL = false, bool GEKHENLLBJE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x47845C0", Offset = "0x47831C0", VA = "0x1847845C0")]
	public void EMODIMFPKPL(T JIGADAOLAJF, U OIHOENPAIEA, V MKPKMCNPNND)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3C35470", Offset = "0x3C34070", VA = "0x183C35470")]
	public static BFGGANIGMAO<T, U, V> DBLKOCIAKKD(BFGGANIGMAO<T, U, V> FBECLAJCFAB, Action<T, U, V> ODKDNEPMNIA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3C35D20", Offset = "0x3C34920", VA = "0x183C35D20")]
	public static BFGGANIGMAO<T, U, V> GIGILBKKNHF(BFGGANIGMAO<T, U, V> FBECLAJCFAB, Action<T, U, V> ODKDNEPMNIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KNEMLNBALGM<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class NPLOKGOGCCK<T, U, V, W> : JCBALJNBEJJ<Action<T, U, V, W>>, KNEMLNBALGM<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3686700", Offset = "0x3685300", VA = "0x183686700")]
	public NPLOKGOGCCK(bool LPGNJCDEAAL = false, bool GEKHENLLBJE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3F55070", Offset = "0x3F53C70", VA = "0x183F55070")]
	public void EMODIMFPKPL(T JIGADAOLAJF, U OIHOENPAIEA, V MKPKMCNPNND, W PCBNIKDPPAI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3C35470", Offset = "0x3C34070", VA = "0x183C35470")]
	public static NPLOKGOGCCK<T, U, V, W> DBLKOCIAKKD(NPLOKGOGCCK<T, U, V, W> FBECLAJCFAB, Action<T, U, V, W> ODKDNEPMNIA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3C35D20", Offset = "0x3C34920", VA = "0x183C35D20")]
	public static NPLOKGOGCCK<T, U, V, W> GIGILBKKNHF(NPLOKGOGCCK<T, U, V, W> FBECLAJCFAB, Action<T, U, V, W> ODKDNEPMNIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class LMMLEJLHAEB<T, U, V, W, X> : JCBALJNBEJJ<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3686700", Offset = "0x3685300", VA = "0x183686700")]
	public LMMLEJLHAEB(bool LPGNJCDEAAL = false, bool GEKHENLLBJE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3C35500", Offset = "0x3C34100", VA = "0x183C35500")]
	public void EMODIMFPKPL(T JIGADAOLAJF, U OIHOENPAIEA, V MKPKMCNPNND, W PCBNIKDPPAI, X KLNIMOGOBLK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3C35470", Offset = "0x3C34070", VA = "0x183C35470")]
	public static LMMLEJLHAEB<T, U, V, W, X> DBLKOCIAKKD(LMMLEJLHAEB<T, U, V, W, X> FBECLAJCFAB, Action<T, U, V, W, X> ODKDNEPMNIA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3C35D20", Offset = "0x3C34920", VA = "0x183C35D20")]
	public static LMMLEJLHAEB<T, U, V, W, X> GIGILBKKNHF(LMMLEJLHAEB<T, U, V, W, X> FBECLAJCFAB, Action<T, U, V, W, X> ODKDNEPMNIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class CJCAFFILLOK<T, U, V, W, X, Y> : JCBALJNBEJJ<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3686700", Offset = "0x3685300", VA = "0x183686700")]
	public CJCAFFILLOK(bool LPGNJCDEAAL = false, bool GEKHENLLBJE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4BC26F0", Offset = "0x4BC12F0", VA = "0x184BC26F0")]
	public void EMODIMFPKPL(T JIGADAOLAJF, U OIHOENPAIEA, V MKPKMCNPNND, W PCBNIKDPPAI, X KLNIMOGOBLK, Y EGCIDIGPDPB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3C35470", Offset = "0x3C34070", VA = "0x183C35470")]
	public static CJCAFFILLOK<T, U, V, W, X, Y> DBLKOCIAKKD(CJCAFFILLOK<T, U, V, W, X, Y> FBECLAJCFAB, Action<T, U, V, W, X, Y> ODKDNEPMNIA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3C35D20", Offset = "0x3C34920", VA = "0x183C35D20")]
	public static CJCAFFILLOK<T, U, V, W, X, Y> GIGILBKKNHF(CJCAFFILLOK<T, U, V, W, X, Y> FBECLAJCFAB, Action<T, U, V, W, X, Y> ODKDNEPMNIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class JLHOBFGDPBJ<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly OPKNNDEGFGB<TKey, TVal> FCAJEOGLKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> DDCKKBFJKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly OPKNNDEGFGB<TKey, TVal>.JACLPINLKMG? GDGBJFJNNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int MNLPJMFDMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly OPKNNDEGFGB<TKey, TVal>.KEAOFJFBPOK? BCCNBGDJENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int NPPKFBBBIEI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int EEALMMOAFND
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3B0D7A0", Offset = "0x3B0C3A0", VA = "0x183B0D7A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int JGLABEBKLCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7B6CC0", Offset = "0x7B58C0", VA = "0x1807B6CC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3B0D8D0", Offset = "0x3B0C4D0", VA = "0x183B0D8D0")]
	public JLHOBFGDPBJ(int MNLPJMFDMAN, [Optional] OPKNNDEGFGB<TKey, TVal>.KEAOFJFBPOK? BCCNBGDJENL, [Optional] IEqualityComparer<TKey>? FFKMLIHEDON, [Optional] OPKNNDEGFGB<TKey, TVal>.JACLPINLKMG? GDGBJFJNNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3B0CEC0", Offset = "0x3B0BAC0", VA = "0x183B0CEC0")]
	public void JNJCDJPEKCM(TKey CGGNJKGENIH, TVal BLKAHBIJBJO, bool CCHKEJDEACH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3B0D670", Offset = "0x3B0C270", VA = "0x183B0D670")]
	public bool OGHIKOAPLCD(TKey CGGNJKGENIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3B0D7F0", Offset = "0x3B0C3F0", VA = "0x183B0D7F0")]
	public bool PODAMIMAFNE(TKey OGHBIBDHMBM, [Out] TVal BLKAHBIJBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3B0C850", Offset = "0x3B0B450", VA = "0x183B0C850")]
	private void AEIHNDFLFPO(TKey CGGNJKGENIH, TVal BLKAHBIJBJO, int JKNAAACFMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3B0CD30", Offset = "0x3B0B930", VA = "0x183B0CD30")]
	public bool IFOLLDBGAPH(TKey CGGNJKGENIH, TVal BLKAHBIJBJO, bool CCHKEJDEACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3B0CCD0", Offset = "0x3B0B8D0", VA = "0x183B0CCD0")]
	public void GEDHBEKABPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3B0D170", Offset = "0x3B0BD70", VA = "0x183B0D170")]
	private void NCCLAPBNOMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3B0CBE0", Offset = "0x3B0B7E0", VA = "0x183B0CBE0")]
	private bool FCKOKEGNIOB(TKey CGGNJKGENIH, DNLNLBKHCHJ PBFMPJEICKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3B0D090", Offset = "0x3B0BC90", VA = "0x183B0D090")]
	private void MBCPJBICBNL(TKey CGGNJKGENIH, TVal BLKAHBIJBJO, DNLNLBKHCHJ PBFMPJEICKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3B0CAB0", Offset = "0x3B0B6B0", VA = "0x183B0CAB0")]
	private void DLOMDNDEDLJ(TKey CGGNJKGENIH, TVal NOPNOIONIBO, DNLNLBKHCHJ PBFMPJEICKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JKALJPKFLFD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action PKCBFBJLDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool PFCPLKCDMOD;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	public JKALJPKFLFD(Action MGMKJDDACCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x61CDF60", Offset = "0x61CCB60", VA = "0x1861CDF60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x27C7530", Offset = "0x27C6130", VA = "0x1827C7530")]
	public static LENMHFABFBO<T> JOBBHNKGDPO<T>(T BLKAHBIJBJO, Action MGMKJDDACCK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class LENMHFABFBO<T> : JKALJPKFLFD where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T BLAEOCKJGCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3C06CB0", Offset = "0x3C058B0", VA = "0x183C06CB0")]
	public LENMHFABFBO(T BLKAHBIJBJO, Action MGMKJDDACCK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct PMKDBMIPKGM : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct DGPMKCFMCOA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30")]
		public static DGPMKCFMCOA CIGBOGDFGOD()
		{
			return default(DGPMKCFMCOA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x295A3E0", Offset = "0x2958FE0", VA = "0x18295A3E0")]
	public static string? AMNONGMDJKJ<T>([Optional] string? GPHGOLBFPIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x295A460", Offset = "0x2959060", VA = "0x18295A460")]
	public static string? NFPFDLEOBBO<T>([Optional] string? HLODPKPJENO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30")]
	public static PMKDBMIPKGM APADDLNAEBN(string GPHGOLBFPIG, string? HLODPKPJENO)
	{
		return default(PMKDBMIPKGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct IOCOBFNPIHJ
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool HDBIINPFEMD(string KACJPGKGBNL, IOCOBFNPIHJ DKAIDGFDEFO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public int DIOIMJEHEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public string LCCLJKCJMKF;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x61CDC30", Offset = "0x61CC830", VA = "0x1861CDC30")]
	public static Dictionary<string, IOCOBFNPIHJ> OJLCLPLJKIA(Type EJFEGDJAPKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x61CD6B0", Offset = "0x61CC2B0", VA = "0x1861CD6B0")]
	public static Dictionary<string, IOCOBFNPIHJ> HLODMMMKODE(Type EJFEGDJAPKH, HDBIINPFEMD GEIDPJBAMCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x61CDA70", Offset = "0x61CC670", VA = "0x1861CDA70")]
	public static Dictionary<int, string> IAKJHKPCPFA(Dictionary<string, IOCOBFNPIHJ> KNENCIBJOEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class PHFFNBEEJOM : JIEDJHBPKDD
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool IHJNLFDMELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string? OENGEDDJOAH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual JIEDJHBPKDD? EFLMLDGMNHI
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x61CF050", Offset = "0x61CDC50", VA = "0x1861CF050")]
	protected PHFFNBEEJOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string HJJFPLKFILC();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x61CEFD0", Offset = "0x61CDBD0", VA = "0x1861CEFD0", Slot = "8")]
	public virtual string MDHPMLMEDGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x61CE9A0", Offset = "0x61CD5A0", VA = "0x1861CE9A0", Slot = "9")]
	public void CJEDPPLLDLH(StringBuilder AJCELLDIDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x61CEDB0", Offset = "0x61CD9B0", VA = "0x1861CEDB0", Slot = "10")]
	public void IIAILHHBGLP(StringBuilder AJCELLDIDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x61CEE10", Offset = "0x61CDA10", VA = "0x1861CEE10", Slot = "11")]
	public void LFOBCELGHJH(StringBuilder AJCELLDIDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x61CEC50", Offset = "0x61CD850", VA = "0x1861CEC50", Slot = "12")]
	public void EPOHLNKJFGE(StringBuilder AJCELLDIDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x61CEF30", Offset = "0x61CDB30", VA = "0x1861CEF30")]
	public static void LPAMDFLHINO(StringBuilder AJCELLDIDGO, string KFDGIPLKIBK, string FOECMBCIHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x543E000", Offset = "0x543CC00", VA = "0x18543E000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FAPEFBCACFB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x61CCD00", Offset = "0x61CB900", VA = "0x1861CCD00")]
	public FAPEFBCACFB(string COECLHOAJJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class HGGLDOBNJAB<TErr> : FAPEFBCACFB where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly TErr JKKMDCCKJPO;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x386A990", Offset = "0x3869590", VA = "0x18386A990")]
	private HGGLDOBNJAB([In] TErr KIAIHANJDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x386A8C0", Offset = "0x38694C0", VA = "0x18386A8C0")]
	public static HGGLDOBNJAB<TErr> CIGBOGDFGOD([In] TErr KIAIHANJDNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface JIEDJHBPKDD
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string MDHPMLMEDGO();

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string HJJFPLKFILC();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface AKPBPIKHFBD<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TOptions BLAEOCKJGCA
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface NCCJBKMMGBD
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string IHIOMBIJJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class ALECDOHOAPG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x61CC180", Offset = "0x61CAD80", VA = "0x1861CC180")]
	public ALECDOHOAPG(string COECLHOAJJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class AMBMBKLDHIF<TOk> : ALECDOHOAPG where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly TOk APOKBFOLMFN;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x38DB040", Offset = "0x38D9C40", VA = "0x1838DB040")]
	private AMBMBKLDHIF([In] TOk MLKCBJFILIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x37B4B80", Offset = "0x37B3780", VA = "0x1837B4B80")]
	public static AMBMBKLDHIF<TOk> CIGBOGDFGOD([In] TOk MLKCBJFILIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct DGKNLHNBBJB<TOk, TErr> : IEquatable<DGKNLHNBBJB<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static readonly EqualityComparer<TErr> ELBPDEOFPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly TErr JKKMDCCKJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal readonly TOk APOKBFOLMFN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool DPIHKFFFEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5046A50", Offset = "0x5045650", VA = "0x185046A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JGEBGHLKDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x50477A0", Offset = "0x50463A0", VA = "0x1850477A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5048EF0", Offset = "0x5047AF0", VA = "0x185048EF0")]
	internal DGKNLHNBBJB([In] TErr KIAIHANJDNP, [In] TOk MLKCBJFILIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5047270", Offset = "0x5045E70", VA = "0x185047270")]
	public static DGKNLHNBBJB<TOk, TErr> IGDBJCIMACJ([In] TErr KIAIHANJDNP)
	{
		return default(DGKNLHNBBJB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5047410", Offset = "0x5046010", VA = "0x185047410")]
	public static DGKNLHNBBJB<TOk, TErr> IOHKAGHBEJA([In] TOk MLKCBJFILIK)
	{
		return default(DGKNLHNBBJB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x24CE180", Offset = "0x24CCD80", VA = "0x1824CE180")]
	public DGKNLHNBBJB<TOk?, UErr?> ODHJMPKHBGA<UErr>()
	{
		return default(DGKNLHNBBJB<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x24CCF20", Offset = "0x24CBB20", VA = "0x1824CCF20")]
	public DGKNLHNBBJB<UOk?, TErr?> GEMBBKNPGGG<UOk>()
	{
		return default(DGKNLHNBBJB<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x24CDB60", Offset = "0x24CC760", VA = "0x1824CDB60")]
	public DGKNLHNBBJB<UOk?, TErr?> MDAEGBJFNFM<UOk>()
	{
		return default(DGKNLHNBBJB<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x24CD250", Offset = "0x24CBE50", VA = "0x1824CD250")]
	public DGKNLHNBBJB<TOk?, UErr?> IDPFIGJOOEB<UErr>()
	{
		return default(DGKNLHNBBJB<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x50444A0", Offset = "0x50430A0", VA = "0x1850444A0")]
	public DGKNLHNBBJB<BABPIFEMKHH, TErr> ENCNONKBCGE()
	{
		return default(DGKNLHNBBJB<BABPIFEMKHH, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5046120", Offset = "0x5044D20", VA = "0x185046120")]
	public static bool FKDJFADGJBA([In] DGKNLHNBBJB<TOk, TErr> GDDMOGHGPAF, [In] DGKNLHNBBJB<TOk, TErr> GHPICIIHMOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5044B50", Offset = "0x5043750", VA = "0x185044B50", Slot = "4")]
	public bool Equals(DGKNLHNBBJB<TOk, TErr> NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5044830", Offset = "0x5043430", VA = "0x185044830", Slot = "0")]
	public override bool Equals(object NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x50468A0", Offset = "0x50454A0", VA = "0x1850468A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5048040", Offset = "0x5046C40", VA = "0x185048040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class GACAEMKDHBF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct DMMGFHEKCID<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public Task<DGKNLHNBBJB<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<DGKNLHNBBJB<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5061D80", Offset = "0x5060980", VA = "0x185061D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x50620A0", Offset = "0x5060CA0", VA = "0x1850620A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x27CF0A0", Offset = "0x27CDCA0", VA = "0x1827CF0A0")]
	public static DGKNLHNBBJB<TOk?, TErr?> APOKBFOLMFN<TOk, TErr>([In] this DGKNLHNBBJB<TOk, TErr> NOLNJDLEMAA, [In] TOk MLKCBJFILIK)
	{
		return default(DGKNLHNBBJB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x27CF170", Offset = "0x27CDD70", VA = "0x1827CF170")]
	public static DGKNLHNBBJB<BABPIFEMKHH, TErr?> APOKBFOLMFN<TErr>([In] this DGKNLHNBBJB<BABPIFEMKHH, TErr> NOLNJDLEMAA)
	{
		return default(DGKNLHNBBJB<BABPIFEMKHH, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x27CF0A0", Offset = "0x27CDCA0", VA = "0x1827CF0A0")]
	public static DGKNLHNBBJB<TOk?, TErr?> JKKMDCCKJPO<TOk, TErr>([In] this DGKNLHNBBJB<TOk, TErr> NOLNJDLEMAA, [In] TErr KIAIHANJDNP)
	{
		return default(DGKNLHNBBJB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x27D1C70", Offset = "0x27D0870", VA = "0x1827D1C70")]
	public static TOk? PJBKDFHFNIO<TOk, TErr>([In] this DGKNLHNBBJB<TOk, TErr> NOLNJDLEMAA)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x27D1130", Offset = "0x27CFD30", VA = "0x1827D1130")]
	[AsyncStateMachine(typeof(DMMGFHEKCID<, >))]
	public static Task<TOk?>? MCHMODDFFON<TOk, TErr>(this Task<DGKNLHNBBJB<TOk, TErr>> NOLNJDLEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x27D0E20", Offset = "0x27CFA20", VA = "0x1827D0E20")]
	public static TErr? JGAEHEEBHAM<TErr, TOk>([In] this DGKNLHNBBJB<TOk, TErr> NOLNJDLEMAA)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x27CF880", Offset = "0x27CE480", VA = "0x1827CF880")]
	public static bool GJFPFGKNAOO<TOk, TErr, UErr, UOk>([In] this DGKNLHNBBJB<TOk, TErr> NOLNJDLEMAA, [Out] DGKNLHNBBJB<UOk, UErr> NOBIJBBEOMD) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x27CF030", Offset = "0x27CDC30", VA = "0x1827CF030")]
	public static bool AGJIOODIHNG<TOk, TErr>([In] this DGKNLHNBBJB<TOk, TErr> NOLNJDLEMAA, [Out][NotNullWhen(true)] TOk MLKCBJFILIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x27D1800", Offset = "0x27D0400", VA = "0x1827D1800")]
	public static bool PCIBFFOACIC<TOk, TErr>([In] this DGKNLHNBBJB<TOk, TErr> NOLNJDLEMAA, [Out][NotNullWhen(true)] TErr KIAIHANJDNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x27CF790", Offset = "0x27CE390", VA = "0x1827CF790")]
	public static bool GJDCHLBEJPB<TOk, TErr>([In] this DGKNLHNBBJB<TOk, TErr> NOLNJDLEMAA, [Out][NotNullWhen(true)] TOk MLKCBJFILIK, [Out][NotNullWhen(false)] TErr KIAIHANJDNP) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x27D1030", Offset = "0x27CFC30", VA = "0x1827D1030")]
	public static bool LIAGBEHMADI<TOk, TErr>([In] this DGKNLHNBBJB<TOk, TErr> NOLNJDLEMAA, [Out][NotNullWhen(true)] TOk MLKCBJFILIK, [Out] DGKNLHNBBJB<TOk, TErr> NOBIJBBEOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x27CFBD0", Offset = "0x27CE7D0", VA = "0x1827CFBD0")]
	public static bool GJFPFGKNAOO<TOk, TErr, UErr, UOk>([In] this DGKNLHNBBJB<TOk, TErr> NOLNJDLEMAA, [Out][NotNullWhen(true)] TOk MLKCBJFILIK, [Out] DGKNLHNBBJB<UOk, UErr> NOBIJBBEOMD) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x27D14A0", Offset = "0x27D00A0", VA = "0x1827D14A0")]
	public static bool MHPIIIDPDID<TOk, TErr>([In] this DGKNLHNBBJB<TOk, TErr> NOLNJDLEMAA, [Out][NotNullWhen(true)] TOk MLKCBJFILIK, [Out] DGKNLHNBBJB<BABPIFEMKHH, TErr> NOBIJBBEOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x27CF580", Offset = "0x27CE180", VA = "0x1827CF580")]
	public static DGKNLHNBBJB<UOk, UErr> ELOLLAJHGBD<UOk, UErr, TOk, TErr>([In] this DGKNLHNBBJB<TOk, TErr> NOLNJDLEMAA, [In] DGKNLHNBBJB<UOk, UErr> BGBHFDMLCDN) where TOk : UOk where TErr : UErr
	{
		return default(DGKNLHNBBJB<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x27D08D0", Offset = "0x27CF4D0", VA = "0x1827D08D0")]
	public static DGKNLHNBBJB<TOk?[]?, TErr?> HHPDJHBHGBM<TOk, TErr>(this IEnumerable<DGKNLHNBBJB<TOk, TErr>> NOLNJDLEMAA)
	{
		return default(DGKNLHNBBJB<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class NAAFEOFFMCN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2724770", Offset = "0x2723370", VA = "0x182724770")]
	public static DGKNLHNBBJB<TOk, T> APOKBFOLMFN<TOk>([In] TOk MLKCBJFILIK) where TOk : notnull
	{
		return default(DGKNLHNBBJB<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3EDC8F0", Offset = "0x3EDB4F0", VA = "0x183EDC8F0")]
	public static DGKNLHNBBJB<BABPIFEMKHH, T> APOKBFOLMFN()
	{
		return default(DGKNLHNBBJB<BABPIFEMKHH, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2724770", Offset = "0x2723370", VA = "0x182724770")]
	public static DGKNLHNBBJB<T, TErr> JKKMDCCKJPO<TErr>([In] TErr KIAIHANJDNP) where TErr : notnull
	{
		return default(DGKNLHNBBJB<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public sealed class HMLCBAKHNFG<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private readonly struct NMHJHMHCDAA : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly HMLCBAKHNFG<T> BDGBEOEBCPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly int EMDOCCPOEHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly bool JMLLCKMEFCO;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1CFDDB0", Offset = "0x1CFC9B0", VA = "0x181CFDDB0")]
		public NMHJHMHCDAA(HMLCBAKHNFG<T> GAFLMOIGPJD, int MCFKHKIGIAJ, bool DLDCCEEAGPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3F4BC90", Offset = "0x3F4A890", VA = "0x183F4BC90")]
		public HMLCBAKHNFG<T>.NMCPIILGCOM EABNIEGMBCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3F4BD80", Offset = "0x3F4A980", VA = "0x183F4BD80", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3F4BD80", Offset = "0x3F4A980", VA = "0x183F4BD80", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class NMCPIILGCOM : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly HMLCBAKHNFG<T> BDGBEOEBCPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly int IDOAEKHOBGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int APJJOHKPBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly bool JMLLCKMEFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private bool FFGBODGFPHA;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T DDCJPGOIIOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x3F49FF0", Offset = "0x3F48BF0", VA = "0x183F49FF0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x3F4A0D0", Offset = "0x3F48CD0", VA = "0x183F4A0D0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x3F4A2A0", Offset = "0x3F48EA0", VA = "0x183F4A2A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3F4A8A0", Offset = "0x3F494A0", VA = "0x183F4A8A0")]
		public NMCPIILGCOM(HMLCBAKHNFG<T> GAFLMOIGPJD, int MCFKHKIGIAJ, bool DLDCCEEAGPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3F49EE0", Offset = "0x3F48AE0", VA = "0x183F49EE0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x3F4A070", Offset = "0x3F48C70", VA = "0x183F4A070", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class BOPGPGAGLOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public BOPGPGAGLOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x47FF3A0", Offset = "0x47FDFA0", VA = "0x1847FF3A0")]
		internal T HILAGMEKOAE(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly T[] DJKPIIOJEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int APJJOHKPBPB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int HMJKGAEEFJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x38872F0", Offset = "0x3885EF0", VA = "0x1838872F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T DDCJPGOIIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x36753B0", Offset = "0x3673FB0", VA = "0x1836753B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T DEPMFFDMOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3887140", Offset = "0x3885D40", VA = "0x183887140")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T JHFKALHEADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x38873E0", Offset = "0x3885FE0", VA = "0x1838873E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int AMCFPGDCENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1713D10", Offset = "0x1712910", VA = "0x181713D10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xFE09A0", Offset = "0xFDF5A0", VA = "0x180FE09A0")]
	private static int BLCGPNHGJDD(int PMIDLPOCCEE, int GFICJHOBPLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x38877F0", Offset = "0x38863F0", VA = "0x1838877F0")]
	public HMLCBAKHNFG(int JKNAAACFMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3887530", Offset = "0x3886130", VA = "0x183887530")]
	public HMLCBAKHNFG(int JKNAAACFMKJ, Func<T> NNOIPOBPPNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x38879A0", Offset = "0x38865A0", VA = "0x1838879A0")]
	public HMLCBAKHNFG(T[] MDLHOCLDHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3887170", Offset = "0x3885D70", VA = "0x183887170")]
	public void CLNNEKMOCIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3887230", Offset = "0x3885E30", VA = "0x183887230")]
	public IEnumerable<T> IAGJGMHPPGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x38871A0", Offset = "0x3885DA0", VA = "0x1838871A0")]
	public HMLCBAKHNFG<T>.NMCPIILGCOM EABNIEGMBCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x370E760", Offset = "0x370D360", VA = "0x18370E760", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x370E760", Offset = "0x370D360", VA = "0x18370E760", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class MDOIKCBCBNA
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2895DF0", Offset = "0x28949F0", VA = "0x182895DF0")]
	public static HMLCBAKHNFG<T> CIGBOGDFGOD<T>(int JKNAAACFMKJ, Func<T> NNOIPOBPPNH) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const float kEpsilon = 1E-05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1DE9440", Offset = "0x1DE8040", VA = "0x181DE9440")]
		public RRColor(float GOHLFLJBMIB, float MCBNFMPMPMG, float ECIMPLOCMKE, float PKCAMDKHNLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x61CF0C0", Offset = "0x61CDCC0", VA = "0x1861CF0C0", Slot = "4")]
		public bool Equals(RRColor NAFFCAIMPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x61CF140", Offset = "0x61CDD40", VA = "0x1861CF140", Slot = "0")]
		public override bool Equals(object NAFFCAIMPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x61CF240", Offset = "0x61CDE40", VA = "0x1861CF240", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x61CF2C0", Offset = "0x61CDEC0", VA = "0x1861CF2C0", Slot = "5")]
		public string ToString(string AHKBHJGDBJA, IFormatProvider LIHPKIKHANA)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class PAIEIBDEIDL<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public readonly struct DCDFIDAGLGJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly PAIEIBDEIDL<T> BMLCLMBPGNJ;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public T BLAEOCKJGCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x434CCE0", Offset = "0x434B8E0", VA = "0x18434CCE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5032B80", Offset = "0x5031780", VA = "0x185032B80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x93C290", Offset = "0x93AE90", VA = "0x18093C290")]
		public DCDFIDAGLGJ(PAIEIBDEIDL<T> BMLCLMBPGNJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct BCNAPLPBLFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<DCDFIDAGLGJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public PAIEIBDEIDL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4763670", Offset = "0x4762270", VA = "0x184763670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x312B010", Offset = "0x3129C10", VA = "0x18312B010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly SemaphoreSlim IIMMLFKJNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T GOOLKBKNFJP;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x40F48D0", Offset = "0x40F34D0", VA = "0x1840F48D0")]
	public PAIEIBDEIDL([In] T GOOLKBKNFJP, int DGCJFAFPEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x40F4970", Offset = "0x40F3570", VA = "0x1840F4970")]
	public PAIEIBDEIDL([In] T GOOLKBKNFJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x40F43B0", Offset = "0x40F2FB0", VA = "0x1840F43B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x40F4870", Offset = "0x40F3470", VA = "0x1840F4870")]
	public DCDFIDAGLGJ HBIFEKLLKNG()
	{
		return default(DCDFIDAGLGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x40F4510", Offset = "0x40F3110", VA = "0x1840F4510")]
	[AsyncStateMachine(typeof(PAIEIBDEIDL<>.BCNAPLPBLFA))]
	public Task<PAIEIBDEIDL<T>.DCDFIDAGLGJ> GLMFPMBJAEA(CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x40F48B0", Offset = "0x40F34B0", VA = "0x1840F48B0")]
	public void KLMGEPELJNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class FJPLEGPAFNK
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x61CCE00", Offset = "0x61CBA00", VA = "0x1861CCE00")]
	public static PAIEIBDEIDL<BABPIFEMKHH> CIGBOGDFGOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2690E60", Offset = "0x268FA60", VA = "0x182690E60")]
	public static PAIEIBDEIDL<T> CIGBOGDFGOD<T>([In] T GOOLKBKNFJP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class PEPOAKBILAI<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct BJGEAHHNOMI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly PEPOAKBILAI<T> MKDMLOFJOKA;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T BLAEOCKJGCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x4791DC0", Offset = "0x47909C0", VA = "0x184791DC0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4791A60", Offset = "0x4790660", VA = "0x184791A60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x93C290", Offset = "0x93AE90", VA = "0x18093C290")]
		internal BJGEAHHNOMI(PEPOAKBILAI<T> BMLCLMBPGNJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct BLLLIIPNJCK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly PEPOAKBILAI<T> MKDMLOFJOKA;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T BLAEOCKJGCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x4791DC0", Offset = "0x47909C0", VA = "0x184791DC0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x47F1110", Offset = "0x47EFD10", VA = "0x1847F1110", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x93C290", Offset = "0x93AE90", VA = "0x18093C290")]
		internal BLLLIIPNJCK(PEPOAKBILAI<T> BMLCLMBPGNJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct LJJHLJNOBAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder<BLLLIIPNJCK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public PEPOAKBILAI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private PAIEIBDEIDL<BABPIFEMKHH>.DCDFIDAGLGJ <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter<PAIEIBDEIDL<BABPIFEMKHH>.DCDFIDAGLGJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3C2DFD0", Offset = "0x3C2CBD0", VA = "0x183C2DFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x312B010", Offset = "0x3129C10", VA = "0x18312B010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly PAIEIBDEIDL<int> ADJNHNPOICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly PAIEIBDEIDL<BABPIFEMKHH> LOFPAINIHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly PAIEIBDEIDL<BABPIFEMKHH> GILEOOJMCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private T PGEKPIPKKNF;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4100090", Offset = "0x40FEC90", VA = "0x184100090")]
	internal PEPOAKBILAI(PAIEIBDEIDL<int> ECLBGHKKDPL, PAIEIBDEIDL<BABPIFEMKHH> LMCCDNGKFMB, PAIEIBDEIDL<BABPIFEMKHH> FHADOIOOJDA, [In] T GOOLKBKNFJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x40FF510", Offset = "0x40FE110", VA = "0x1840FF510", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x40FF910", Offset = "0x40FE510", VA = "0x1840FF910")]
	public BJGEAHHNOMI KDGBPINGNFE()
	{
		return default(BJGEAHHNOMI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x40FF7D0", Offset = "0x40FE3D0", VA = "0x1840FF7D0")]
	public BLLLIIPNJCK FGOOLPMNHAA()
	{
		return default(BLLLIIPNJCK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x40FFEE0", Offset = "0x40FEAE0", VA = "0x1840FFEE0")]
	[AsyncStateMachine(typeof(PEPOAKBILAI<>.LJJHLJNOBAJ))]
	public Task<PEPOAKBILAI<T>.BLLLIIPNJCK> PFABAKKJPDN(CancellationToken EJGJLLMBDIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class CECMEHIOKPK
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x61CC310", Offset = "0x61CAF10", VA = "0x1861CC310")]
	public static PEPOAKBILAI<BABPIFEMKHH> CIGBOGDFGOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x26159E0", Offset = "0x26145E0", VA = "0x1826159E0")]
	public static PEPOAKBILAI<T> CIGBOGDFGOD<T>([In] T GOOLKBKNFJP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class OHBGBOLIMBE<TData> : PHFFNBEEJOM where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly string NAFGJKMOKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly TData EIIIJBECKHI;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "7")]
	public override string HJJFPLKFILC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x400D610", Offset = "0x400C210", VA = "0x18400D610")]
	internal OHBGBOLIMBE(string COECLHOAJJF, [In] TData KOMCCCIEHEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class GEFFFCMNCKG
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x61CCE70", Offset = "0x61CBA70", VA = "0x1861CCE70")]
	public static OHBGBOLIMBE<BABPIFEMKHH> CIGBOGDFGOD(string COECLHOAJJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x27C7530", Offset = "0x27C6130", VA = "0x1827C7530")]
	public static OHBGBOLIMBE<TData> CIGBOGDFGOD<TData>(string COECLHOAJJF, [In] TData KOMCCCIEHEA) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class MPJJOINEKJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly Dictionary<object, float> MCNKNEKLJEK;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float NNHFLNKIOLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x93A5F0", Offset = "0x9391F0", VA = "0x18093A5F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x93A690", Offset = "0x939290", VA = "0x18093A690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x61CE540", Offset = "0x61CD140", VA = "0x1861CE540")]
	public void KMCELLHAPCK(float BLKAHBIJBJO, object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x61CE4D0", Offset = "0x61CD0D0", VA = "0x1861CE4D0")]
	public void GJCMIPAODGB(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x61CE3A0", Offset = "0x61CCFA0", VA = "0x1861CE3A0")]
	private void DDANLPALFNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x61CE5B0", Offset = "0x61CD1B0", VA = "0x1861CE5B0")]
	public MPJJOINEKJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class NLAOINFHHNN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class PIBEJGPJDAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public PIBEJGPJDAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x4108B10", Offset = "0x4107710", VA = "0x184108B10")]
		internal int PHNALDABMAO(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private HashSet<T>? PMCBPCFOCEB;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<T> NBBJHINDEEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3F34420", Offset = "0x3F33020", VA = "0x183F34420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool CHNJBEEMNBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3F343E0", Offset = "0x3F32FE0", VA = "0x183F343E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int LOHCAPLAMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7B1560", Offset = "0x7B0160", VA = "0x1807B1560")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7B6580", Offset = "0x7B5180", VA = "0x1807B6580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3F34110", Offset = "0x3F32D10", VA = "0x183F34110")]
	public bool BGJHDHHBMPP(T DGPOLLDAHJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3F34280", Offset = "0x3F32E80", VA = "0x183F34280")]
	public bool DMBJGENFJDP(T DGPOLLDAHJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3F343A0", Offset = "0x3F32FA0", VA = "0x183F343A0")]
	public bool FLAHJEGFLKH(T DGPOLLDAHJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3F34450", Offset = "0x3F33050", VA = "0x183F34450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public NLAOINFHHNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class CAPELAHPHJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly string OGEGBJKLHLP;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	public CAPELAHPHJP(string OGEGBJKLHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x61CC2C0", Offset = "0x61CAEC0", VA = "0x1861CC2C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class IDAAIAHGGDM
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class PBOBOHKILFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public PBOBOHKILFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x61CE8F0", Offset = "0x61CD4F0", VA = "0x1861CE8F0")]
		internal int PHNALDABMAO(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private HashSet<object>? PMCBPCFOCEB;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IReadOnlyCollection<object> NBBJHINDEEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x61CD470", Offset = "0x61CC070", VA = "0x1861CD470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool CHNJBEEMNBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x61CD3F0", Offset = "0x61CBFF0", VA = "0x1861CD3F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int LOHCAPLAMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7B1560", Offset = "0x7B0160", VA = "0x1807B1560")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7B6580", Offset = "0x7B5180", VA = "0x1807B6580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x61CD210", Offset = "0x61CBE10", VA = "0x1861CD210")]
	public bool BGJHDHHBMPP(object DGPOLLDAHJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x61CD2F0", Offset = "0x61CBEF0", VA = "0x1861CD2F0")]
	public bool DMBJGENFJDP(object DGPOLLDAHJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x61CD390", Offset = "0x61CBF90", VA = "0x1861CD390")]
	public bool FLAHJEGFLKH(object DGPOLLDAHJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x61CD400", Offset = "0x61CC000", VA = "0x1861CD400")]
	public void MFPIFOMBLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x61CD500", Offset = "0x61CC100", VA = "0x1861CD500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public IDAAIAHGGDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class FOJIKLJMAHO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private struct IFHFJAGDLGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float FNMPHHCELPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public T BLAEOCKJGCA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Dictionary<object, IFHFJAGDLGD> MCNKNEKLJEK;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public virtual T HNJAFPEACMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xEE3B70", Offset = "0xEE2770", VA = "0x180EE3B70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xEE3140", Offset = "0xEE1D40", VA = "0x180EE3140", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public object? HMADMCNJHEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7B5350", Offset = "0x7B3F50", VA = "0x1807B5350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool PBAODPJKGDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x369FF90", Offset = "0x369EB90", VA = "0x18369FF90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x369FB90", Offset = "0x369E790", VA = "0x18369FB90")]
	public bool KMCELLHAPCK(T BLKAHBIJBJO, object DGPOLLDAHJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x369F720", Offset = "0x369E320", VA = "0x18369F720")]
	public bool GJCMIPAODGB(object DGPOLLDAHJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x369F6F0", Offset = "0x369E2F0", VA = "0x18369F6F0")]
	public void GEDHBEKABPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x36A0090", Offset = "0x369EC90", VA = "0x1836A0090")]
	public bool PODAMIMAFNE(object DGPOLLDAHJK, [Out] T BLKAHBIJBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x369E420", Offset = "0x369D020", VA = "0x18369E420")]
	[DNJCBAHKMJF("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool BBBPHPEHGPB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x36A0390", Offset = "0x369EF90", VA = "0x1836A0390")]
	public FOJIKLJMAHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface AMNFJMOMPJL
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event FPDJLJEPFPL FLJFAGEPIMF;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class EMAPDACIFNI : AMNFJMOMPJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public readonly struct MMABFBNLJJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public readonly float GJNOBIEAGDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public readonly float CAMOLGCILAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		internal readonly bool CBDMCJHEAKH;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float EDIMMLFINLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x61CE0D0", Offset = "0x61CCCD0", VA = "0x1861CE0D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x61CE240", Offset = "0x61CCE40", VA = "0x1861CE240")]
		public MMABFBNLJJE(float ILKNGPHCOGM, float FFMMBPDGBBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x61CE0E0", Offset = "0x61CCCE0", VA = "0x1861CE0E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class FCJGHAPPPIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public EMAPDACIFNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public FCJGHAPPPIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x61CCD60", Offset = "0x61CB960", VA = "0x1861CCD60")]
		internal void IHMABDJJJHA(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly int LLHBDBHCNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int PLNGHLJLEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly AMNFJMOMPJL[] CKDBBAFMMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly FPDJLJEPFPL[] FOHLLAJCPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly MMABFBNLJJE[] FMOFHPBBJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private MMABFBNLJJE KHGJOMJCOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly NDDFDGFOGCA MPLKNGOGMNP;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event FPDJLJEPFPL FLJFAGEPIMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x61CCAB0", Offset = "0x61CB6B0", VA = "0x1861CCAB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x61CC4F0", Offset = "0x61CB0F0", VA = "0x1861CC4F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x61CCB70", Offset = "0x61CB770", VA = "0x1861CCB70")]
	public EMAPDACIFNI(int LLHBDBHCNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x61CCA20", Offset = "0x61CB620", VA = "0x1861CCA20")]
	public NDDFDGFOGCA NFNLNLDGIDI(MMABFBNLJJE CMKIHOMHGJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x61CC5B0", Offset = "0x61CB1B0", VA = "0x1861CC5B0")]
	public void KLKDMCCCLCK(AMNFJMOMPJL PDEJCOCGBDD, [Optional] MMABFBNLJJE LJLGIDDCKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x61CC3E0", Offset = "0x61CAFE0", VA = "0x1861CC3E0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public delegate void FPDJLJEPFPL(float MKBLEIDLDAF);
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class MJFOLDPCLEG
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private class AMILACCOCBO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly AMNFJMOMPJL PJAOMFFFCCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly FPDJLJEPFPL NLOLPKLGIBB;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x61CC230", Offset = "0x61CAE30", VA = "0x1861CC230")]
		public AMILACCOCBO(AMNFJMOMPJL PJAOMFFFCCM, FPDJLJEPFPL NLOLPKLGIBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x61CC1E0", Offset = "0x61CADE0", VA = "0x1861CC1E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x61CE060", Offset = "0x61CCC60", VA = "0x1861CE060")]
	internal static bool LKGLBPKOMHA(float PKCAMDKHNLN, float ECIMPLOCMKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x61BED50", Offset = "0x61BD950", VA = "0x1861BED50")]
	internal static float MBLLMODMCFA(float PKCAMDKHNLN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x61CDFA0", Offset = "0x61CCBA0", VA = "0x1861CDFA0")]
	public static IDisposable FHGPINICAGF(this AMNFJMOMPJL PJAOMFFFCCM, FPDJLJEPFPL NLOLPKLGIBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class NDDFDGFOGCA : AMNFJMOMPJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float MKBLEIDLDAF;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float GIPFCBAEDJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x61CE6E0", Offset = "0x61CD2E0", VA = "0x1861CE6E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event FPDJLJEPFPL? FLJFAGEPIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x61CE7D0", Offset = "0x61CD3D0", VA = "0x1861CE7D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x61CE640", Offset = "0x61CD240", VA = "0x1861CE640", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public NDDFDGFOGCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class DJDFPJHCMKO : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5CB4380", Offset = "0x5CB2F80", VA = "0x185CB4380")]
	public DJDFPJHCMKO(string COECLHOAJJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[DefaultMember("Item")]
public class BMFDFABDEAE<TKey, TValue> : DFNDGNCEDMI<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, DNLGJEOFJCH where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class LLOLDJJDKAN : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public BMFDFABDEAE<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xEE3B70", Offset = "0xEE2770", VA = "0x180EE3B70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x3C35270", Offset = "0x3C33E70", VA = "0x183C35270", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
		[DebuggerHidden]
		public LLOLDJJDKAN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x36B01E0", Offset = "0x36AEDE0", VA = "0x1836B01E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x3C34DA0", Offset = "0x3C339A0", VA = "0x183C34DA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3C34460", Offset = "0x3C33060", VA = "0x183C34460")]
		private void DPHAFEJOOLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3C345A0", Offset = "0x3C331A0", VA = "0x183C345A0")]
		private void KFBCLBKCPOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3C35180", Offset = "0x3C33D80", VA = "0x183C35180", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly DFNDGNCEDMI<TKey, TValue> NECECNCKHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly IDictionary<TKey, TValue> CFEIGBLCAAF;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int LOHCAPLAMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x47F5440", Offset = "0x47F4040", VA = "0x1847F5440", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool FHOMOFINOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public TValue JHFKALHEADE
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x47F5540", Offset = "0x47F4140", VA = "0x1847F5540", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x47F57A0", Offset = "0x47F43A0", VA = "0x1847F57A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public ICollection<TKey> AHNOPBBGNLK
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x47F5580", Offset = "0x47F4180", VA = "0x1847F5580", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public ICollection<TValue> DNMECDMKCOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x47F5690", Offset = "0x47F4290", VA = "0x1847F5690", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x47F51F0", Offset = "0x47F3DF0", VA = "0x1847F51F0")]
	public BMFDFABDEAE(DFNDGNCEDMI<TKey, TValue> NECECNCKHAK, [Optional] IDictionary<TKey, TValue>? CFEIGBLCAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x47F2D40", Offset = "0x47F1940", VA = "0x1847F2D40", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x47F41A0", Offset = "0x47F2DA0", VA = "0x1847F41A0")]
	public void NNCMFOAGAJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x47F25D0", Offset = "0x47F11D0", VA = "0x1847F25D0", Slot = "9")]
	public void Add(TKey CGGNJKGENIH, TValue BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x47F43F0", Offset = "0x47F2FF0", VA = "0x1847F43F0")]
	public void OOOGOCLGLKK(TKey CGGNJKGENIH, TValue BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x47F3A00", Offset = "0x47F2600", VA = "0x1847F3A00")]
	public void HMJCAEDGINM(TKey CGGNJKGENIH, TValue BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x47F3F60", Offset = "0x47F2B60", VA = "0x1847F3F60")]
	public void NJEEJCCPBFL(TKey CGGNJKGENIH, TValue BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x47F3BB0", Offset = "0x47F27B0", VA = "0x1847F3BB0")]
	public void INBDKFLJLIF(TKey CGGNJKGENIH, TValue BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x47F4830", Offset = "0x47F3430", VA = "0x1847F4830", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> ILDOLMKGCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x47F4A10", Offset = "0x47F3610", VA = "0x1847F4A10", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> ILDOLMKGCCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x47F4D70", Offset = "0x47F3970", VA = "0x1847F4D70", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> ILDOLMKGCCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x47F2DB0", Offset = "0x47F19B0", VA = "0x1847F2DB0", Slot = "8")]
	public bool ContainsKey(TKey CGGNJKGENIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x47F4250", Offset = "0x47F2E50", VA = "0x1847F4250")]
	public bool OHMPHKNMGKD(TKey CGGNJKGENIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x47F3650", Offset = "0x47F2250", VA = "0x1847F3650")]
	public bool FHKILGNPPMI(TKey CGGNJKGENIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x47F4660", Offset = "0x47F3260", VA = "0x1847F4660", Slot = "10")]
	public bool Remove(TKey CGGNJKGENIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x47F5040", Offset = "0x47F3C40", VA = "0x1847F5040", Slot = "11")]
	public bool TryGetValue(TKey CGGNJKGENIH, [Out] TValue BLKAHBIJBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x47F2F00", Offset = "0x47F1B00", VA = "0x1847F2F00", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] GBCEGNLFFAN, int CLNFPIKMFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x47F4F30", Offset = "0x47F3B30", VA = "0x1847F4F30", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x47F38A0", Offset = "0x47F24A0", VA = "0x1847F38A0", Slot = "19")]
	[IteratorStateMachine(typeof(BMFDFABDEAE<, >.LLOLDJJDKAN))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x47F3720", Offset = "0x47F2320", VA = "0x1847F3720", Slot = "21")]
	public bool GLBILFGDACD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x47F2B80", Offset = "0x47F1780", VA = "0x1847F2B80")]
	private TValue BBJFIAAEMEB(TKey CGGNJKGENIH)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface DNLGJEOFJCH
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GLBILFGDACD();
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface DFNDGNCEDMI<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, DNLGJEOFJCH
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DefaultMember("Item")]
public sealed class OPKNNDEGFGB<TKey, TVal> : DFNDGNCEDMI<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, DNLGJEOFJCH where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public delegate int KEAOFJFBPOK(TKey CGGNJKGENIH, TVal BLKAHBIJBJO);

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public delegate void JACLPINLKMG(TKey CGGNJKGENIH, TVal BLKAHBIJBJO, DNLNLBKHCHJ PBFMPJEICKM);

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class AEFFHLMKMGF
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public TKey BKEHFHLBEND
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x84DD40", Offset = "0x84C940", VA = "0x18084DD40")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public TVal BLAEOCKJGCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x961750", Offset = "0x960350", VA = "0x180961750")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x961700", Offset = "0x960300", VA = "0x180961700")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int EDIMMLFINLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x7EFCF0", Offset = "0x7EE8F0", VA = "0x1807EFCF0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x7EF920", Offset = "0x7EE520", VA = "0x1807EF920")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public DateTimeOffset NDCANJNMBJH
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0xADE5F0", Offset = "0xADD1F0", VA = "0x180ADE5F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x1338600", Offset = "0x1337200", VA = "0x181338600")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3737CA0", Offset = "0x37368A0", VA = "0x183737CA0")]
		public AEFFHLMKMGF(TKey CGGNJKGENIH, TVal NOPNOIONIBO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class PEDNNIEAMGD : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public OPKNNDEGFGB<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private LinkedList<AEFFHLMKMGF>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xEE3B70", Offset = "0xEE2770", VA = "0x180EE3B70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x40FE1F0", Offset = "0x40FCDF0", VA = "0x1840FE1F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
		[DebuggerHidden]
		public PEDNNIEAMGD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3587500", Offset = "0x3586100", VA = "0x183587500", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x40FD720", Offset = "0x40FC320", VA = "0x1840FD720", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x40FB4E0", Offset = "0x40FA0E0", VA = "0x1840FB4E0")]
		private void DPHAFEJOOLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x40FE1A0", Offset = "0x40FCDA0", VA = "0x1840FE1A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const int CJIJBJDPGAD = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<TKey, LinkedListNode<AEFFHLMKMGF>> BDKIBFHFCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly LinkedList<AEFFHLMKMGF> PDMGONJONPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly KEAOFJFBPOK? BCCNBGDJENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly TimeSpan FOBBAPAAFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly JACLPINLKMG? GDGBJFJNNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly IKBLBFDJDPI CDEMHFMLFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool HCNLPDFMCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly List<TKey> OCNEJACCJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly List<TVal> HDICCGLMLBG;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int JGLABEBKLCG
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7C01C0", Offset = "0x7BEDC0", VA = "0x1807C01C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	internal int EEALMMOAFND
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9ADB70", Offset = "0x9AC770", VA = "0x1809ADB70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9AD4F0", Offset = "0x9AC0F0", VA = "0x1809AD4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int LOHCAPLAMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x405D5B0", Offset = "0x405C1B0", VA = "0x18405D5B0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	internal int CJJGENDNJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x334C710", Offset = "0x334B310", VA = "0x18334C710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public ICollection<TVal> DNMECDMKCOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x405D770", Offset = "0x405C370", VA = "0x18405D770", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	ICollection<TKey> IDictionary<TKey, TVal>.NHIPJHHICFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x4057C70", Offset = "0x4056870", VA = "0x184057C70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool FHOMOFINOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public TVal JHFKALHEADE
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x405D610", Offset = "0x405C210", VA = "0x18405D610", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x405D7C0", Offset = "0x405C3C0", VA = "0x18405D7C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x40532C0", Offset = "0x4051EC0", VA = "0x1840532C0")]
	private bool MNDADLHKKKB(int LLHBDBHCNGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4045440", Offset = "0x4044040", VA = "0x184045440")]
	private void DNALMNIEBGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x405C3F0", Offset = "0x405AFF0", VA = "0x18405C3F0")]
	public OPKNNDEGFGB(int LLHBDBHCNGJ, [Optional] KEAOFJFBPOK? BCCNBGDJENL, [Optional] IEqualityComparer<TKey>? FFKMLIHEDON, [Optional] JACLPINLKMG? GDGBJFJNNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x4059960", Offset = "0x4058560", VA = "0x184059960")]
	public OPKNNDEGFGB(TimeSpan FOBBAPAAFIF, [Optional] IEqualityComparer<TKey>? FFKMLIHEDON, [Optional] JACLPINLKMG? GDGBJFJNNGM, [Optional] IKBLBFDJDPI? CDEMHFMLFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x40590F0", Offset = "0x4057CF0", VA = "0x1840590F0")]
	public OPKNNDEGFGB(int LLHBDBHCNGJ, TimeSpan FOBBAPAAFIF, [Optional] IEqualityComparer<TKey>? FFKMLIHEDON, [Optional] JACLPINLKMG? GDGBJFJNNGM, [Optional] IKBLBFDJDPI? CDEMHFMLFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x4059DC0", Offset = "0x40589C0", VA = "0x184059DC0")]
	public OPKNNDEGFGB(int LLHBDBHCNGJ, KEAOFJFBPOK? BCCNBGDJENL, TimeSpan FOBBAPAAFIF, [Optional] IEqualityComparer<TKey>? FFKMLIHEDON, [Optional] JACLPINLKMG? GDGBJFJNNGM, [Optional] IKBLBFDJDPI? CDEMHFMLFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x40505F0", Offset = "0x404F1F0", VA = "0x1840505F0", Slot = "21")]
	public bool GLBILFGDACD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x404AEC0", Offset = "0x4049AC0", VA = "0x18404AEC0", Slot = "22")]
	public bool FNGGNLKLBCL(int JKNAAACFMKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x4050090", Offset = "0x404EC90", VA = "0x184050090")]
	private bool GGHHJOBNEJD(int JKNAAACFMKJ, DNLNLBKHCHJ PBFMPJEICKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x404AAB0", Offset = "0x40496B0", VA = "0x18404AAB0")]
	public void FNEEIDKMODG(TKey CGGNJKGENIH, TVal BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x403FCE0", Offset = "0x403E8E0", VA = "0x18403FCE0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> ILDOLMKGCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x403F310", Offset = "0x403DF10", VA = "0x18403F310", Slot = "9")]
	public void Add(TKey CGGNJKGENIH, TVal BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x4040D80", Offset = "0x403F980", VA = "0x184040D80", Slot = "8")]
	public bool ContainsKey(TKey CGGNJKGENIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x4056D70", Offset = "0x4055970", VA = "0x184056D70", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> ILDOLMKGCCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x40568B0", Offset = "0x40554B0", VA = "0x1840568B0", Slot = "10")]
	public bool Remove(TKey CGGNJKGENIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x40574F0", Offset = "0x40560F0", VA = "0x1840574F0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> ILDOLMKGCCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x4046350", Offset = "0x4044F50", VA = "0x184046350")]
	private bool FDDPJCOMCGJ(TKey CGGNJKGENIH, [Out] TVal BLKAHBIJBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x40409E0", Offset = "0x403F5E0", VA = "0x1840409E0")]
	private TVal CPPPHMALPOD(TKey OGHBIBDHMBM)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x4058230", Offset = "0x4056E30", VA = "0x184058230", Slot = "11")]
	public bool TryGetValue(TKey OGHBIBDHMBM, [Out] TVal BLKAHBIJBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x4040BF0", Offset = "0x403F7F0", VA = "0x184040BF0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x40412D0", Offset = "0x403FED0", VA = "0x1840412D0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] GBCEGNLFFAN, int CLNFPIKMFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x4044140", Offset = "0x4042D40", VA = "0x184044140")]
	private void DLOMDNDEDLJ(TKey CGGNJKGENIH, TVal NOPNOIONIBO, DNLNLBKHCHJ PBFMPJEICKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x40553B0", Offset = "0x4053FB0", VA = "0x1840553B0")]
	private bool OAFNLCMDFIN(AEFFHLMKMGF JAAKJAFJEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x4049850", Offset = "0x4048450", VA = "0x184049850")]
	private void FHIDEHDLBNF(LinkedListNode<AEFFHLMKMGF> CNNKHAOKOLP, TVal OHHNBBKEKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x4051CF0", Offset = "0x40508F0", VA = "0x184051CF0")]
	private void KMCELLHAPCK(TKey CGGNJKGENIH, TVal BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x40538B0", Offset = "0x40524B0", VA = "0x1840538B0")]
	private void MPNDPBNKHGM(AEFFHLMKMGF JAAKJAFJEEO, TVal OHHNBBKEKIA, int GACFHCOMJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x40506F0", Offset = "0x404F2F0", VA = "0x1840506F0", Slot = "19")]
	[IteratorStateMachine(typeof(OPKNNDEGFGB<, >.PEDNNIEAMGD))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x4057CA0", Offset = "0x40568A0", VA = "0x184057CA0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public enum DNLNLBKHCHJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	RemovedViaClear
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class EGDNCFFKDPL<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly TKey MLKKIEECBOK;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3324430", Offset = "0x3323030", VA = "0x183324430")]
	public EGDNCFFKDPL(TKey AGCOGNPKIFG, Exception PFLAIKMDCHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class GMGIDDHFPGI : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x55B4250", Offset = "0x55B2E50", VA = "0x1855B4250")]
	public GMGIDDHFPGI(string COECLHOAJJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class MKEFBMKCECP<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class DKDLPPPPBCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public MKEFBMKCECP<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public DKDLPPPPBCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x505B470", Offset = "0x505A070", VA = "0x18505B470")]
		internal Task<TResource> HGEKKECEAGC(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct BIKCBONLPDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x478F7A0", Offset = "0x478E3A0", VA = "0x18478F7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x478FE40", Offset = "0x478EA40", VA = "0x18478FE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct GINGANGNBKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Action<TResource> cleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3789B40", Offset = "0x3788740", VA = "0x183789B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x378A000", Offset = "0x3788C00", VA = "0x18378A000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly PNJGPMOACGG<TId, Task<TResource>> NHNMHEFJKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> LFODADNGGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? IGPGJDLABIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly Action<TResource>? JAOIINKPFFC;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3E5B6B0", Offset = "0x3E5A2B0", VA = "0x183E5B6B0")]
	public MKEFBMKCECP(int NFKAENFANAP = 0, [Optional] IEqualityComparer<TId>? CCEILHKEFGF, [Optional] Func<TId, CancellationToken, Task<TResource>>? FOCGNMDBGMP, [Optional] Action<TResource>? MBHMMMPKONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A5B0", Offset = "0x3E591B0", VA = "0x183E5A5B0")]
	public LENMHFABFBO<Task<TResource>> EJMKGPJAODM(TId JPCJHDLLDBJ, [Optional] Func<TId, CancellationToken, Task<TResource>>? FOCGNMDBGMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3E5B3D0", Offset = "0x3E59FD0", VA = "0x183E5B3D0")]
	private void MCLAOJBLPMN(Task<TResource> BKPEJJIHAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3E5AE50", Offset = "0x3E59A50", VA = "0x183E5AE50")]
	public void LHPGNJKPMMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A540", Offset = "0x3E59140", VA = "0x183E5A540")]
	public PNJGPMOACGG<TId, Task<TResource>>.DBJAJIPPHMJ EABNIEGMBCK()
	{
		return default(PNJGPMOACGG<TId, Task<TResource>>.DBJAJIPPHMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3E5B4E0", Offset = "0x3E5A0E0", VA = "0x183E5B4E0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3E5B4E0", Offset = "0x3E5A0E0", VA = "0x183E5B4E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3E5ABF0", Offset = "0x3E597F0", VA = "0x183E5ABF0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(MKEFBMKCECP<, >.BIKCBONLPDP))]
	internal static Task GCCDKHNHDMJ(Task<TResource> BKPEJJIHAHC, CancellationTokenSource ENBIBICEOBA, Dictionary<Task<TResource>, CancellationTokenSource> EAAPOBFCOJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3E5AE80", Offset = "0x3E59A80", VA = "0x183E5AE80")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(MKEFBMKCECP<, >.GINGANGNBKI))]
	internal static Task LODAOEAFDEN(Task<TResource> BKPEJJIHAHC, Action<TResource> DBPJBELDNBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class PNJGPMOACGG<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private sealed class CAEMEIDMEJK : IEquatable<CAEMEIDMEJK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TValue BLAEOCKJGCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int EIINLBNLBJF;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x1CB7E70", Offset = "0x1CB6A70", VA = "0x181CB7E70")]
		public CAEMEIDMEJK(TValue BLKAHBIJBJO, int MCIHGGKJFHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x4ADA030", Offset = "0x4AD8C30", VA = "0x184ADA030", Slot = "4")]
		public bool Equals(CAEMEIDMEJK? NAFFCAIMPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x4AD9F90", Offset = "0x4AD8B90", VA = "0x184AD9F90", Slot = "0")]
		public override bool Equals(object? OGGNGHKHHGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x4ADA0C0", Offset = "0x4AD8CC0", VA = "0x184ADA0C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct DBJAJIPPHMJ : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private Dictionary<TKey, CAEMEIDMEJK>.Enumerator IJCCEPLBNAO;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x5032010", Offset = "0x5030C10", VA = "0x185032010", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public (TKey Key, TValue Value, int RefCount) DDCJPGOIIOH
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x50324A0", Offset = "0x50310A0", VA = "0x1850324A0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5032230", Offset = "0x5030E30", VA = "0x185032230")]
		public DBJAJIPPHMJ(PNJGPMOACGG<TKey, TValue> MCNKNEKLJEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5031C60", Offset = "0x5030860", VA = "0x185031C60", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5031CE0", Offset = "0x50308E0", VA = "0x185031CE0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5031EC0", Offset = "0x5030AC0", VA = "0x185031EC0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class NKCBDKOKHNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public PNJGPMOACGG<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CAEMEIDMEJK refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public NKCBDKOKHNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3F33F40", Offset = "0x3F32B40", VA = "0x183F33F40")]
		internal void HGEKKECEAGC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<TKey, CAEMEIDMEJK> FLPILLLJJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly Func<TKey, TValue>? IHIACGKHEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly Action<TValue>? PFODPOPAKGD;

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x412F190", Offset = "0x412DD90", VA = "0x18412F190")]
	public PNJGPMOACGG(int NFKAENFANAP = 0, [Optional] IEqualityComparer<TKey>? FFKMLIHEDON, [Optional] Func<TKey, TValue>? FOLNFDBDNJP, [Optional] Action<TValue>? GOGCMAJIFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x412E190", Offset = "0x412CD90", VA = "0x18412E190")]
	public LENMHFABFBO<TValue> EJMKGPJAODM(TKey CGGNJKGENIH, [Optional] Func<TKey, TValue>? BGFEDHEGPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x412DEF0", Offset = "0x412CAF0", VA = "0x18412DEF0")]
	private void CAHHFGLKLDH(TKey CGGNJKGENIH, CAEMEIDMEJK EKGEAAIDOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x412EA10", Offset = "0x412D610", VA = "0x18412EA10")]
	public void LHPGNJKPMMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x412E150", Offset = "0x412CD50", VA = "0x18412E150")]
	public DBJAJIPPHMJ EABNIEGMBCK()
	{
		return default(DBJAJIPPHMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x412F0F0", Offset = "0x412DCF0", VA = "0x18412F0F0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x412F0F0", Offset = "0x412DCF0", VA = "0x18412F0F0", Slot = "5")]
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
