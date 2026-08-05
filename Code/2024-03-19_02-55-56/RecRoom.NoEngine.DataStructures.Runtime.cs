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
		[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6236CF0", Offset = "0x6235CF0", VA = "0x186236CF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E62B0", Offset = "0x7E52B0", VA = "0x1807E62B0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7E62F0", Offset = "0x7E52F0", VA = "0x1807E62F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class FMDFGANEAFD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	protected FMDFGANEAFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class IMNCGPOLPJI<T> : FMDFGANEAFD
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct OBADLIBNFHO
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum NDAIHPIBNKA
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
		public NDAIHPIBNKA IKHOLAJCJOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T DFHNKDINOMO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int GAEAINGENLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool NGDHOBNNKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool KHLGIFBJAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? AKNJANHILKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<OBADLIBNFHO>? LFONIENNLJJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool NICEEONODBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3964E20", Offset = "0x3963E20", VA = "0x183964E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x39654E0", Offset = "0x39644E0", VA = "0x1839654E0")]
	protected IMNCGPOLPJI(bool KHLGIFBJAAA, bool NGDHOBNNKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3964D80", Offset = "0x3963D80", VA = "0x183964D80")]
	protected bool CIKNCOPOLLI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3965230", Offset = "0x3964230", VA = "0x183965230")]
	protected void GEAADPAEGAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3964E70", Offset = "0x3963E70", VA = "0x183964E70")]
	protected void DOGECJMHMKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x22D84D0", Offset = "0x22D74D0", VA = "0x1822D84D0")]
	private static void GAGGOIPLNCJ<U>(List<U>? JOAHCODCDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3965050", Offset = "0x3964050", VA = "0x183965050", Slot = "4")]
	public void EMJMPPLJJNE(T DFHNKDINOMO, bool KDHOFPKPFAM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3965330", Offset = "0x3964330", VA = "0x183965330", Slot = "5")]
	public void JOBFLKKFIPF(T DFHNKDINOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3964C00", Offset = "0x3963C00", VA = "0x183964C00")]
	public void BGPDDONPEEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JHIMKIBOPMP
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EMJMPPLJJNE(Action DFHNKDINOMO, bool KDHOFPKPFAM = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JOBFLKKFIPF(Action DFHNKDINOMO);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class LHMMLLGDOFK : IMNCGPOLPJI<Action>, JHIMKIBOPMP
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6236800", Offset = "0x6235800", VA = "0x186236800")]
	public LHMMLLGDOFK(bool KHLGIFBJAAA = false, bool NGDHOBNNKNG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x62365A0", Offset = "0x62355A0", VA = "0x1862365A0")]
	public void MLJKNHMHONE()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6236540", Offset = "0x6235540", VA = "0x186236540")]
	public static LHMMLLGDOFK BGAMHHCLDBC(LHMMLLGDOFK PJEBMPONJMD, Action DFHNKDINOMO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x62367A0", Offset = "0x62357A0", VA = "0x1862367A0")]
	public static LHMMLLGDOFK NFCDBIJILIM(LHMMLLGDOFK PJEBMPONJMD, Action DFHNKDINOMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PNBMNJNEMBF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EMJMPPLJJNE(Action<T> DFHNKDINOMO, bool KDHOFPKPFAM = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JOBFLKKFIPF(Action<T> DFHNKDINOMO);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class MDKLHFICKPP<T> : IMNCGPOLPJI<Action<T>>, PNBMNJNEMBF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3698290", Offset = "0x3697290", VA = "0x183698290")]
	public MDKLHFICKPP(bool KHLGIFBJAAA = false, bool NGDHOBNNKNG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3EC2630", Offset = "0x3EC1630", VA = "0x183EC2630")]
	public void MLJKNHMHONE(T MPLEEKHPBJH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x37A1BF0", Offset = "0x37A0BF0", VA = "0x1837A1BF0")]
	public static MDKLHFICKPP<T> BGAMHHCLDBC(MDKLHFICKPP<T> PJEBMPONJMD, Action<T> DFHNKDINOMO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x37A2880", Offset = "0x37A1880", VA = "0x1837A2880")]
	public static MDKLHFICKPP<T> NFCDBIJILIM(MDKLHFICKPP<T> PJEBMPONJMD, Action<T> DFHNKDINOMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OIBCHPNGLEB<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class ILKJIPKENIK<T, U> : IMNCGPOLPJI<Action<T, U>>, OIBCHPNGLEB<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3698290", Offset = "0x3697290", VA = "0x183698290")]
	public ILKJIPKENIK(bool KHLGIFBJAAA = false, bool NGDHOBNNKNG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x39601A0", Offset = "0x395F1A0", VA = "0x1839601A0")]
	public void MLJKNHMHONE(T MPLEEKHPBJH, U FIMAJCHHEIP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x37A1BF0", Offset = "0x37A0BF0", VA = "0x1837A1BF0")]
	public static ILKJIPKENIK<T, U> BGAMHHCLDBC(ILKJIPKENIK<T, U> PJEBMPONJMD, Action<T, U> DFHNKDINOMO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x37A2880", Offset = "0x37A1880", VA = "0x1837A2880")]
	public static ILKJIPKENIK<T, U> NFCDBIJILIM(ILKJIPKENIK<T, U> PJEBMPONJMD, Action<T, U> DFHNKDINOMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class OOEBNDBPJGI<T, U, V> : IMNCGPOLPJI<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3698290", Offset = "0x3697290", VA = "0x183698290")]
	public OOEBNDBPJGI(bool KHLGIFBJAAA = false, bool NGDHOBNNKNG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x408D900", Offset = "0x408C900", VA = "0x18408D900")]
	public void MLJKNHMHONE(T MPLEEKHPBJH, U FIMAJCHHEIP, V IFEDOEKJDOP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x37A1BF0", Offset = "0x37A0BF0", VA = "0x1837A1BF0")]
	public static OOEBNDBPJGI<T, U, V> BGAMHHCLDBC(OOEBNDBPJGI<T, U, V> PJEBMPONJMD, Action<T, U, V> DFHNKDINOMO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x37A2880", Offset = "0x37A1880", VA = "0x1837A2880")]
	public static OOEBNDBPJGI<T, U, V> NFCDBIJILIM(OOEBNDBPJGI<T, U, V> PJEBMPONJMD, Action<T, U, V> DFHNKDINOMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EMBJKPEMIKF<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class HDGNDMPJFLF<T, U, V, W> : IMNCGPOLPJI<Action<T, U, V, W>>, EMBJKPEMIKF<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3698290", Offset = "0x3697290", VA = "0x183698290")]
	public HDGNDMPJFLF(bool KHLGIFBJAAA = false, bool NGDHOBNNKNG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x37BB5D0", Offset = "0x37BA5D0", VA = "0x1837BB5D0")]
	public void MLJKNHMHONE(T MPLEEKHPBJH, U FIMAJCHHEIP, V IFEDOEKJDOP, W HCFPNEAOOMC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x37A1BF0", Offset = "0x37A0BF0", VA = "0x1837A1BF0")]
	public static HDGNDMPJFLF<T, U, V, W> BGAMHHCLDBC(HDGNDMPJFLF<T, U, V, W> PJEBMPONJMD, Action<T, U, V, W> DFHNKDINOMO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x37A2880", Offset = "0x37A1880", VA = "0x1837A2880")]
	public static HDGNDMPJFLF<T, U, V, W> NFCDBIJILIM(HDGNDMPJFLF<T, U, V, W> PJEBMPONJMD, Action<T, U, V, W> DFHNKDINOMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class KENKOIPLDHP<T, U, V, W, X> : IMNCGPOLPJI<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3698290", Offset = "0x3697290", VA = "0x183698290")]
	public KENKOIPLDHP(bool KHLGIFBJAAA = false, bool NGDHOBNNKNG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3C15430", Offset = "0x3C14430", VA = "0x183C15430")]
	public void MLJKNHMHONE(T MPLEEKHPBJH, U FIMAJCHHEIP, V IFEDOEKJDOP, W HCFPNEAOOMC, X GDALFMOOMGE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x37A1BF0", Offset = "0x37A0BF0", VA = "0x1837A1BF0")]
	public static KENKOIPLDHP<T, U, V, W, X> BGAMHHCLDBC(KENKOIPLDHP<T, U, V, W, X> PJEBMPONJMD, Action<T, U, V, W, X> DFHNKDINOMO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x37A2880", Offset = "0x37A1880", VA = "0x1837A2880")]
	public static KENKOIPLDHP<T, U, V, W, X> NFCDBIJILIM(KENKOIPLDHP<T, U, V, W, X> PJEBMPONJMD, Action<T, U, V, W, X> DFHNKDINOMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class AGIFELNEABA<T, U, V, W, X, Y> : IMNCGPOLPJI<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3698290", Offset = "0x3697290", VA = "0x183698290")]
	public AGIFELNEABA(bool KHLGIFBJAAA = false, bool NGDHOBNNKNG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x37A1C80", Offset = "0x37A0C80", VA = "0x1837A1C80")]
	public void MLJKNHMHONE(T MPLEEKHPBJH, U FIMAJCHHEIP, V IFEDOEKJDOP, W HCFPNEAOOMC, X GDALFMOOMGE, Y CPFDGDKGJBM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x37A1BF0", Offset = "0x37A0BF0", VA = "0x1837A1BF0")]
	public static AGIFELNEABA<T, U, V, W, X, Y> BGAMHHCLDBC(AGIFELNEABA<T, U, V, W, X, Y> PJEBMPONJMD, Action<T, U, V, W, X, Y> DFHNKDINOMO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x37A2880", Offset = "0x37A1880", VA = "0x1837A2880")]
	public static AGIFELNEABA<T, U, V, W, X, Y> NFCDBIJILIM(AGIFELNEABA<T, U, V, W, X, Y> PJEBMPONJMD, Action<T, U, V, W, X, Y> DFHNKDINOMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MEONIEJMOIM<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly KEHHDPFBENA<TKey, TVal> CDGOMPKIGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> LKPMDOLDAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly KEHHDPFBENA<TKey, TVal>.GKPHBOIDIPJ? FPPAJLAIMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int PEFGFDAGMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly KEHHDPFBENA<TKey, TVal>.LDFAIEBEBMC? DFHMIOHGMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int ADMBBNHBMKA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int COHNALKANFH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3ECB100", Offset = "0x3ECA100", VA = "0x183ECB100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int HGGNFGJEBJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7BD950", Offset = "0x7BC950", VA = "0x1807BD950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3ECB450", Offset = "0x3ECA450", VA = "0x183ECB450")]
	public MEONIEJMOIM(int PEFGFDAGMOI, [Optional] KEHHDPFBENA<TKey, TVal>.LDFAIEBEBMC? DFHMIOHGMHM, [Optional] IEqualityComparer<TKey>? BLOFPFPDNNF, [Optional] KEHHDPFBENA<TKey, TVal>.GKPHBOIDIPJ? FPPAJLAIMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3ECACD0", Offset = "0x3EC9CD0", VA = "0x183ECACD0")]
	public void ILHCLFGKLCB(TKey IPAJBJLLPIJ, TVal CFJDHAGGAJO, bool JBEPGMIMCDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3ECB150", Offset = "0x3ECA150", VA = "0x183ECB150")]
	public bool NHLGKAMAGID(TKey IPAJBJLLPIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3ECABF0", Offset = "0x3EC9BF0", VA = "0x183ECABF0")]
	public bool IJFOADKACJF(TKey DGGCIGEBIBO, [Out] TVal CFJDHAGGAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3ECAEA0", Offset = "0x3EC9EA0", VA = "0x183ECAEA0")]
	private void IMOBBPHBLMA(TKey IPAJBJLLPIJ, TVal CFJDHAGGAJO, int BEELDCKKFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3ECA560", Offset = "0x3EC9560", VA = "0x183ECA560")]
	public bool HHGEPDDFGNE(TKey IPAJBJLLPIJ, TVal CFJDHAGGAJO, bool JBEPGMIMCDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3ECA3D0", Offset = "0x3EC93D0", VA = "0x183ECA3D0")]
	public void BGPDDONPEEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3ECA6F0", Offset = "0x3EC96F0", VA = "0x183ECA6F0")]
	private void HKDEEGIGFDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3ECB280", Offset = "0x3ECA280", VA = "0x183ECB280")]
	private bool ONGLDHGHCHM(TKey IPAJBJLLPIJ, LBKCBDEIAKK CPHMIDDIJGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3ECB370", Offset = "0x3ECA370", VA = "0x183ECB370")]
	private void OPEFDEKHFDA(TKey IPAJBJLLPIJ, TVal CFJDHAGGAJO, LBKCBDEIAKK CPHMIDDIJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3ECA430", Offset = "0x3EC9430", VA = "0x183ECA430")]
	private void CKBPBLKOMKO(TKey IPAJBJLLPIJ, TVal GKDIIMKFCMD, LBKCBDEIAKK CPHMIDDIJGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NDGKOPECIDD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action NLKJFMAHJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool MMGADIFCBMJ;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	public NDGKOPECIDD(Action FMANKJNMHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6236CB0", Offset = "0x6235CB0", VA = "0x186236CB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2635A30", Offset = "0x2634A30", VA = "0x182635A30")]
	public static ACLFJKPGHAP<T> OOGKEDOOOJC<T>(T CFJDHAGGAJO, Action FMANKJNMHLO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class ACLFJKPGHAP<T> : NDGKOPECIDD where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T ADACBBLDADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1F0", Offset = "0x7BC1F0", VA = "0x1807BD1F0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3793980", Offset = "0x3792980", VA = "0x183793980")]
	public ACLFJKPGHAP(T CFJDHAGGAJO, Action FMANKJNMHLO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct CNDMELHGHNJ : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct NCFJKDHHCCA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0")]
		public static NCFJKDHHCCA NAJBLLJFKKI()
		{
			return default(NCFJKDHHCCA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0")]
	public static CNDMELHGHNJ AAHLBGJBNOI(Type IKHOLAJCJOG, [Optional] string? KFHPOOEGOLH, [Optional] string? FEODEJDIJLA, bool BGLKHGMBLLD = false)
	{
		return default(CNDMELHGHNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0")]
	public static CNDMELHGHNJ AAHLBGJBNOI<T>([Optional] string? KFHPOOEGOLH, [Optional] string? FEODEJDIJLA, bool BGLKHGMBLLD = false)
	{
		return default(CNDMELHGHNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct JHHJCHFLMID
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool HPOMHPDBIKI(string CKFGPBJLCIA, JHHJCHFLMID MBHHOIACAKO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public int PDPILKIDIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public string HNEOHNAGPCC;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6235870", Offset = "0x6234870", VA = "0x186235870")]
	public static Dictionary<string, JHHJCHFLMID> KJKPGDBIODB(Type ILHAEFBIFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x62352F0", Offset = "0x62342F0", VA = "0x1862352F0")]
	public static Dictionary<string, JHHJCHFLMID> AGNEFGABEMP(Type ILHAEFBIFKK, HPOMHPDBIKI BPEALMBOLAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x62356B0", Offset = "0x62346B0", VA = "0x1862356B0")]
	public static Dictionary<int, string> CBFDEAEHPNC(Dictionary<string, JHHJCHFLMID> HLPKKPNOMHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class HMMHOLFLIGF : BOFJPOKAPAE
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool NCPEDINGHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string? PBAPFOBOIFN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual BOFJPOKAPAE? EOLLGLJEDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7BB290", Offset = "0x7BA290", VA = "0x1807BB290", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6234F70", Offset = "0x6233F70", VA = "0x186234F70")]
	protected HMMHOLFLIGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string OJGKBMCMILI();

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x62349E0", Offset = "0x62339E0", VA = "0x1862349E0", Slot = "8")]
	public virtual string BMIINCGCGCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6234AC0", Offset = "0x6233AC0", VA = "0x186234AC0", Slot = "9")]
	public void EHNPBOGFJDJ(StringBuilder CKFPFJILKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6234A60", Offset = "0x6233A60", VA = "0x186234A60", Slot = "10")]
	public void BMNJNLOLFHF(StringBuilder CKFPFJILKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x62348C0", Offset = "0x62338C0", VA = "0x1862348C0", Slot = "11")]
	public void AKDBCELMKMH(StringBuilder CKFPFJILKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6234D70", Offset = "0x6233D70", VA = "0x186234D70", Slot = "12")]
	public void OPCBLPFFOJO(StringBuilder CKFPFJILKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6234ED0", Offset = "0x6233ED0", VA = "0x186234ED0")]
	public static void PDDMJNDEDNE(StringBuilder CKFPFJILKGN, string JMPKJEPGMKE, string BOGGBLGIEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5497740", Offset = "0x5496740", VA = "0x185497740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class APFBIJBHAFM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x62340F0", Offset = "0x62330F0", VA = "0x1862340F0")]
	public APFBIJBHAFM(string DFJKCKBFLAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FMNIKHMDFFB<TErr> : APFBIJBHAFM where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly TErr FMLAMJFDBHO;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3683A50", Offset = "0x3682A50", VA = "0x183683A50")]
	private FMNIKHMDFFB([In] TErr MBGIFPBJICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3683980", Offset = "0x3682980", VA = "0x183683980")]
	public static FMNIKHMDFFB<TErr> NAJBLLJFKKI([In] TErr MBGIFPBJICB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface BOFJPOKAPAE
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string BMIINCGCGCA();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string OJGKBMCMILI();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface DPGDFDJBIEK<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TOptions ADACBBLDADO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface JNCFMBCHKAC
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string DNKONCAEBCN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OGFBDNCOFAA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6236D70", Offset = "0x6235D70", VA = "0x186236D70")]
	public OGFBDNCOFAA(string DFJKCKBFLAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class CNKHLDGACHN<TOk> : OGFBDNCOFAA where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly TOk HOGDCKLGPNO;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4D6F040", Offset = "0x4D6E040", VA = "0x184D6F040")]
	private CNKHLDGACHN([In] TOk BOOPPKMMGEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x33193D0", Offset = "0x33183D0", VA = "0x1833193D0")]
	public static CNKHLDGACHN<TOk> NAJBLLJFKKI([In] TOk BOOPPKMMGEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct PBAOJGOHCMJ<TOk, TErr> : IEquatable<PBAOJGOHCMJ<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static readonly EqualityComparer<TErr> JBCFFHEBBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly TErr FMLAMJFDBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal readonly TOk HOGDCKLGPNO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool BPMIHFGJDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x411E160", Offset = "0x411D160", VA = "0x18411E160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool MBNLAMFHPNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x411E4B0", Offset = "0x411D4B0", VA = "0x18411E4B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x411ED50", Offset = "0x411DD50", VA = "0x18411ED50")]
	internal PBAOJGOHCMJ([In] TErr MBGIFPBJICB, [In] TOk BOOPPKMMGEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x411E380", Offset = "0x411D380", VA = "0x18411E380")]
	public static PBAOJGOHCMJ<TOk, TErr> NFMEMBKJGGP([In] TErr MBGIFPBJICB)
	{
		return default(PBAOJGOHCMJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x411DFF0", Offset = "0x411CFF0", VA = "0x18411DFF0")]
	public static PBAOJGOHCMJ<TOk, TErr> KCHHKANDJAM([In] TOk BOOPPKMMGEL)
	{
		return default(PBAOJGOHCMJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x26F30C0", Offset = "0x26F20C0", VA = "0x1826F30C0")]
	public PBAOJGOHCMJ<TOk?, UErr?> GFIABKNHBOL<UErr>()
	{
		return default(PBAOJGOHCMJ<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x26F3C80", Offset = "0x26F2C80", VA = "0x1826F3C80")]
	public PBAOJGOHCMJ<UOk?, TErr?> KFCPEMMNAKC<UOk>()
	{
		return default(PBAOJGOHCMJ<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x26F2A20", Offset = "0x26F1A20", VA = "0x1826F2A20")]
	public PBAOJGOHCMJ<UOk?, TErr?> EBBFHDMGPID<UOk>()
	{
		return default(PBAOJGOHCMJ<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x26F3FB0", Offset = "0x26F2FB0", VA = "0x1826F3FB0")]
	public PBAOJGOHCMJ<TOk?, UErr?> MGCMMGMMDJP<UErr>()
	{
		return default(PBAOJGOHCMJ<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x411E220", Offset = "0x411D220", VA = "0x18411E220")]
	public PBAOJGOHCMJ<EMBFKEMHPML, TErr> MEAAOKDEDPB()
	{
		return default(PBAOJGOHCMJ<EMBFKEMHPML, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x411D8F0", Offset = "0x411C8F0", VA = "0x18411D8F0")]
	public static bool INAKJEGDKIC([In] PBAOJGOHCMJ<TOk, TErr> FKOPFOECIGH, [In] PBAOJGOHCMJ<TOk, TErr> DGKDEKELGHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x411CE60", Offset = "0x411BE60", VA = "0x18411CE60", Slot = "4")]
	public bool Equals(PBAOJGOHCMJ<TOk, TErr> PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x411D0C0", Offset = "0x411C0C0", VA = "0x18411D0C0", Slot = "0")]
	public override bool Equals(object PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x411D6C0", Offset = "0x411C6C0", VA = "0x18411D6C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x411EA00", Offset = "0x411DA00", VA = "0x18411EA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class KOKDKHCINLI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct AGODJDLNBPO<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public Task<PBAOJGOHCMJ<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<PBAOJGOHCMJ<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x37A37E0", Offset = "0x37A27E0", VA = "0x1837A37E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x37A4140", Offset = "0x37A3140", VA = "0x1837A4140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2832EF0", Offset = "0x2831EF0", VA = "0x182832EF0")]
	public static PBAOJGOHCMJ<TOk?, TErr?> HOGDCKLGPNO<TOk, TErr>([In] this PBAOJGOHCMJ<TOk, TErr> AOFEPADBPDL, [In] TOk BOOPPKMMGEL)
	{
		return default(PBAOJGOHCMJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2834170", Offset = "0x2833170", VA = "0x182834170")]
	public static PBAOJGOHCMJ<EMBFKEMHPML, TErr?> HOGDCKLGPNO<TErr>([In] this PBAOJGOHCMJ<EMBFKEMHPML, TErr> AOFEPADBPDL)
	{
		return default(PBAOJGOHCMJ<EMBFKEMHPML, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2832EF0", Offset = "0x2831EF0", VA = "0x182832EF0")]
	public static PBAOJGOHCMJ<TOk?, TErr?> FMLAMJFDBHO<TOk, TErr>([In] this PBAOJGOHCMJ<TOk, TErr> AOFEPADBPDL, [In] TErr MBGIFPBJICB)
	{
		return default(PBAOJGOHCMJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2833A60", Offset = "0x2832A60", VA = "0x182833A60")]
	public static TOk? GNIAEINKMDJ<TOk, TErr>([In] this PBAOJGOHCMJ<TOk, TErr> AOFEPADBPDL)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2833050", Offset = "0x2832050", VA = "0x182833050")]
	[AsyncStateMachine(typeof(AGODJDLNBPO<, >))]
	public static Task<TOk?>? GALDJPDOPCK<TOk, TErr>(this Task<PBAOJGOHCMJ<TOk, TErr>> AOFEPADBPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2833D50", Offset = "0x2832D50", VA = "0x182833D50")]
	public static TErr? HHFPEKNPDFH<TErr, TOk>([In] this PBAOJGOHCMJ<TOk, TErr> AOFEPADBPDL)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2834810", Offset = "0x2833810", VA = "0x182834810")]
	public static bool NGOAMJNKHPK<TOk, TErr, UErr, UOk>([In] this PBAOJGOHCMJ<TOk, TErr> AOFEPADBPDL, [Out] PBAOJGOHCMJ<UOk, UErr> PNBIBJEJBJM) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2832950", Offset = "0x2831950", VA = "0x182832950")]
	public static bool CGNFFAEHKGM<TOk, TErr>([In] this PBAOJGOHCMJ<TOk, TErr> AOFEPADBPDL, [Out][NotNullWhen(true)] TOk BOOPPKMMGEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2835620", Offset = "0x2834620", VA = "0x182835620")]
	public static bool OFDCNPNANOB<TOk, TErr>([In] this PBAOJGOHCMJ<TOk, TErr> AOFEPADBPDL, [Out][NotNullWhen(true)] TErr MBGIFPBJICB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2832E00", Offset = "0x2831E00", VA = "0x182832E00")]
	public static bool FMGMEKEHEDJ<TOk, TErr>([In] this PBAOJGOHCMJ<TOk, TErr> AOFEPADBPDL, [Out][NotNullWhen(true)] TOk BOOPPKMMGEL, [Out][NotNullWhen(false)] TErr MBGIFPBJICB) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x28329C0", Offset = "0x28319C0", VA = "0x1828329C0")]
	public static bool CJPLIMLPMGN<TOk, TErr>([In] this PBAOJGOHCMJ<TOk, TErr> AOFEPADBPDL, [Out][NotNullWhen(true)] TOk BOOPPKMMGEL, [Out] PBAOJGOHCMJ<TOk, TErr> PNBIBJEJBJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x28345D0", Offset = "0x28335D0", VA = "0x1828345D0")]
	public static bool NGOAMJNKHPK<TOk, TErr, UErr, UOk>([In] this PBAOJGOHCMJ<TOk, TErr> AOFEPADBPDL, [Out][NotNullWhen(true)] TOk BOOPPKMMGEL, [Out] PBAOJGOHCMJ<UOk, UErr> PNBIBJEJBJM) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2834270", Offset = "0x2833270", VA = "0x182834270")]
	public static bool IOHKMNCDNDL<TOk, TErr>([In] this PBAOJGOHCMJ<TOk, TErr> AOFEPADBPDL, [Out][NotNullWhen(true)] TOk BOOPPKMMGEL, [Out] PBAOJGOHCMJ<EMBFKEMHPML, TErr> PNBIBJEJBJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x28332F0", Offset = "0x28322F0", VA = "0x1828332F0")]
	public static PBAOJGOHCMJ<UOk, UErr> GLOPKODKFFB<UOk, UErr, TOk, TErr>([In] this PBAOJGOHCMJ<TOk, TErr> AOFEPADBPDL, [In] PBAOJGOHCMJ<UOk, UErr> IEHPEJEDEKI) where TOk : UOk where TErr : UErr
	{
		return default(PBAOJGOHCMJ<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2832AC0", Offset = "0x2831AC0", VA = "0x182832AC0")]
	public static PBAOJGOHCMJ<TOk?[]?, TErr?> FADHEFBLEAC<TOk, TErr>(this IEnumerable<PBAOJGOHCMJ<TOk, TErr>> AOFEPADBPDL)
	{
		return default(PBAOJGOHCMJ<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class CDIGJNMNPOO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x22CF180", Offset = "0x22CE180", VA = "0x1822CF180")]
	public static PBAOJGOHCMJ<TOk, T> HOGDCKLGPNO<TOk>([In] TOk BOOPPKMMGEL) where TOk : notnull
	{
		return default(PBAOJGOHCMJ<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4C8BED0", Offset = "0x4C8AED0", VA = "0x184C8BED0")]
	public static PBAOJGOHCMJ<EMBFKEMHPML, T> HOGDCKLGPNO()
	{
		return default(PBAOJGOHCMJ<EMBFKEMHPML, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x22CF180", Offset = "0x22CE180", VA = "0x1822CF180")]
	public static PBAOJGOHCMJ<T, TErr> FMLAMJFDBHO<TErr>([In] TErr MBGIFPBJICB) where TErr : notnull
	{
		return default(PBAOJGOHCMJ<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public sealed class EDLDEPFFGGK<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private readonly struct NMKGGNMGMLL : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly EDLDEPFFGGK<T> MGOJFBHMJOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly int HJGIGDPKEAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly bool NNPAIDKMHIA;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1CE02F0", Offset = "0x1CDF2F0", VA = "0x181CE02F0")]
		public NMKGGNMGMLL(EDLDEPFFGGK<T> GINEIDDJABE, int EJDNFMGAFCO, bool EJFPLACBLDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3F90C80", Offset = "0x3F8FC80", VA = "0x183F90C80")]
		public EDLDEPFFGGK<T>.DGBNJDABOJA CJGNNJFLGEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3F90D70", Offset = "0x3F8FD70", VA = "0x183F90D70", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3F90D70", Offset = "0x3F8FD70", VA = "0x183F90D70", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class DGBNJDABOJA : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly EDLDEPFFGGK<T> MGOJFBHMJOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly int EFNKEHOACDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int EAOMBAPGLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly bool NNPAIDKMHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private bool KODKGNBPGBM;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T FKHNLELEDDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x50C5780", Offset = "0x50C4780", VA = "0x1850C5780")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x50C5930", Offset = "0x50C4930", VA = "0x1850C5930", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x50C5A80", Offset = "0x50C4A80", VA = "0x1850C5A80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x50C5F00", Offset = "0x50C4F00", VA = "0x1850C5F00")]
		public DGBNJDABOJA(EDLDEPFFGGK<T> GINEIDDJABE, int EJDNFMGAFCO, bool EJFPLACBLDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x50C5840", Offset = "0x50C4840", VA = "0x1850C5840", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x50C58D0", Offset = "0x50C48D0", VA = "0x1850C58D0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class JPCFHKIMGOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public JPCFHKIMGOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3B5C5D0", Offset = "0x3B5B5D0", VA = "0x183B5C5D0")]
		internal T GJOCKLAPALG(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly T[] EHNGBMMGBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int EAOMBAPGLID;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int JOLKLHENKFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3311230", Offset = "0x3310230", VA = "0x183311230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T FKHNLELEDDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3311140", Offset = "0x3310140", VA = "0x183311140")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T GMLEKMDNCFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x33113D0", Offset = "0x33103D0", VA = "0x1833113D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T EIFMNNJBIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3311370", Offset = "0x3310370", VA = "0x183311370")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int HOCNAFCFDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1700370", Offset = "0x16FF370", VA = "0x181700370")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xFD4000", Offset = "0xFD3000", VA = "0x180FD4000")]
	private static int GDNFINECJNC(int GCDIELAOHNA, int NAHHNFGPNAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x33114F0", Offset = "0x33104F0", VA = "0x1833114F0")]
	public EDLDEPFFGGK(int BEELDCKKFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3311560", Offset = "0x3310560", VA = "0x183311560")]
	public EDLDEPFFGGK(int BEELDCKKFJL, Func<T> MLPPKCEGKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x33118C0", Offset = "0x33108C0", VA = "0x1833118C0")]
	public EDLDEPFFGGK(T[] OAAIPIKOOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3311200", Offset = "0x3310200", VA = "0x183311200")]
	public void HFJNNGJFEGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3311400", Offset = "0x3310400", VA = "0x183311400")]
	public IEnumerable<T> PKPNLHLLKBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3311170", Offset = "0x3310170", VA = "0x183311170")]
	public EDLDEPFFGGK<T>.DGBNJDABOJA CJGNNJFLGEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x33114C0", Offset = "0x33104C0", VA = "0x1833114C0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x33114C0", Offset = "0x33104C0", VA = "0x1833114C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class LICANLJNECF
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x283D0D0", Offset = "0x283C0D0", VA = "0x18283D0D0")]
	public static EDLDEPFFGGK<T> NAJBLLJFKKI<T>(int BEELDCKKFJL, Func<T> MLPPKCEGKJK) where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9A40", Offset = "0x1DC8A40", VA = "0x181DC9A40")]
		public RRColor(float HKCCAHKOPDN, float LBMPNBFLHOG, float AMHEHNHOGFM, float ABLMDKMDGNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6236FE0", Offset = "0x6235FE0", VA = "0x186236FE0", Slot = "4")]
		public bool Equals(RRColor PJNBIAFGNNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6237060", Offset = "0x6236060", VA = "0x186237060", Slot = "0")]
		public override bool Equals(object PJNBIAFGNNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6237160", Offset = "0x6236160", VA = "0x186237160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x62371E0", Offset = "0x62361E0", VA = "0x1862371E0", Slot = "5")]
		public string ToString(string LKAHAANPPAP, IFormatProvider ANLDPDNHLEH)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class LCFNDPNNGDN<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public readonly struct KDBHKKJIOIH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly LCFNDPNNGDN<T> IHNIIIEODLP;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public T ADACBBLDADO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x3BEF670", Offset = "0x3BEE670", VA = "0x183BEF670")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3BEF640", Offset = "0x3BEE640", VA = "0x183BEF640", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9452D0", Offset = "0x9442D0", VA = "0x1809452D0")]
		public KDBHKKJIOIH(LCFNDPNNGDN<T> IHNIIIEODLP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct JPCDFFFACEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<KDBHKKJIOIH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public LCFNDPNNGDN<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3B5C0B0", Offset = "0x3B5B0B0", VA = "0x183B5C0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3100B20", Offset = "0x30FFB20", VA = "0x183100B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly SemaphoreSlim CGCDJDOPKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T MPGBAKEBMPN;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3CE23F0", Offset = "0x3CE13F0", VA = "0x183CE23F0")]
	public LCFNDPNNGDN([In] T MPGBAKEBMPN, int EIOELNOMCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3CE23D0", Offset = "0x3CE13D0", VA = "0x183CE23D0")]
	public LCFNDPNNGDN([In] T MPGBAKEBMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3CE2110", Offset = "0x3CE1110", VA = "0x183CE2110", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3CE2150", Offset = "0x3CE1150", VA = "0x183CE2150")]
	public KDBHKKJIOIH JKGCGKHGMED()
	{
		return default(KDBHKKJIOIH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3CE22B0", Offset = "0x3CE12B0", VA = "0x183CE22B0")]
	[AsyncStateMachine(typeof(LCFNDPNNGDN<>.JPCDFFFACEH))]
	public Task<LCFNDPNNGDN<T>.KDBHKKJIOIH> JMBHFKLEFMK(CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3CE20F0", Offset = "0x3CE10F0", VA = "0x183CE20F0")]
	public void DNGFPHOEKPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class IFGCAAHKMFC
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6235280", Offset = "0x6234280", VA = "0x186235280")]
	public static LCFNDPNNGDN<EMBFKEMHPML> NAJBLLJFKKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2583BC0", Offset = "0x2582BC0", VA = "0x182583BC0")]
	public static LCFNDPNNGDN<T> NAJBLLJFKKI<T>([In] T MPGBAKEBMPN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class HCJAKJEMDNF<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct FOEPFHPPIFH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly HCJAKJEMDNF<T> HOJPAKNNHDN;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T ADACBBLDADO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x369AB60", Offset = "0x3699B60", VA = "0x18369AB60")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x369A800", Offset = "0x3699800", VA = "0x18369A800", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9452D0", Offset = "0x9442D0", VA = "0x1809452D0")]
		internal FOEPFHPPIFH(HCJAKJEMDNF<T> IHNIIIEODLP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct NDMPIPKMAFG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly HCJAKJEMDNF<T> HOJPAKNNHDN;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T ADACBBLDADO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x369AB60", Offset = "0x3699B60", VA = "0x18369AB60")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3F43650", Offset = "0x3F42650", VA = "0x183F43650", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9452D0", Offset = "0x9442D0", VA = "0x1809452D0")]
		internal NDMPIPKMAFG(HCJAKJEMDNF<T> IHNIIIEODLP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct KPNOIFCIPAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder<NDMPIPKMAFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public HCJAKJEMDNF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private LCFNDPNNGDN<EMBFKEMHPML>.KDBHKKJIOIH <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter<LCFNDPNNGDN<EMBFKEMHPML>.KDBHKKJIOIH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3C51FC0", Offset = "0x3C50FC0", VA = "0x183C51FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3100B20", Offset = "0x30FFB20", VA = "0x183100B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly LCFNDPNNGDN<int> JNPLAAJACKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly LCFNDPNNGDN<EMBFKEMHPML> PKFPGONOFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly LCFNDPNNGDN<EMBFKEMHPML> JBCEMDOLMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private T HDBLCIDMJHN;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x37B9FA0", Offset = "0x37B8FA0", VA = "0x1837B9FA0")]
	internal HCJAKJEMDNF(LCFNDPNNGDN<int> KLMPKHNMNID, LCFNDPNNGDN<EMBFKEMHPML> KDJLDAEDMMC, LCFNDPNNGDN<EMBFKEMHPML> HBCGEDFMKGD, [In] T MPGBAKEBMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x37B9F20", Offset = "0x37B8F20", VA = "0x1837B9F20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x37B98E0", Offset = "0x37B88E0", VA = "0x1837B98E0")]
	public FOEPFHPPIFH DIBLOGPPEBD()
	{
		return default(FOEPFHPPIFH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x37B9280", Offset = "0x37B8280", VA = "0x1837B9280")]
	public NDMPIPKMAFG CCBGBBLBEMM()
	{
		return default(NDMPIPKMAFG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x37B9550", Offset = "0x37B8550", VA = "0x1837B9550")]
	[AsyncStateMachine(typeof(HCJAKJEMDNF<>.KPNOIFCIPAH))]
	public Task<HCJAKJEMDNF<T>.NDMPIPKMAFG> CEIIMHBPOJO(CancellationToken JMJKFNJJBHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class MIAHOOCNNFE
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6236BE0", Offset = "0x6235BE0", VA = "0x186236BE0")]
	public static HCJAKJEMDNF<EMBFKEMHPML> NAJBLLJFKKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x287EB40", Offset = "0x287DB40", VA = "0x18287EB40")]
	public static HCJAKJEMDNF<T> NAJBLLJFKKI<T>([In] T MPGBAKEBMPN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class FGGILMBKFGK<TData> : HMMHOLFLIGF where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly string FBJBIEBEAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly TData GCOMEMFCJKB;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "7")]
	public override string OJGKBMCMILI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3670420", Offset = "0x366F420", VA = "0x183670420")]
	internal FGGILMBKFGK(string DFJKCKBFLAD, [In] TData ELANMAGHLLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class KNPOCDGIEPI
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6235BA0", Offset = "0x6234BA0", VA = "0x186235BA0")]
	public static FGGILMBKFGK<EMBFKEMHPML> NAJBLLJFKKI(string DFJKCKBFLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2635A30", Offset = "0x2634A30", VA = "0x182635A30")]
	public static FGGILMBKFGK<TData> NAJBLLJFKKI<TData>(string DFJKCKBFLAD, [In] TData ELANMAGHLLI) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class IEPFJFLOLPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly Dictionary<object, float> MBMBPCDJPPA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float GEFJKODIFNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x942690", Offset = "0x941690", VA = "0x180942690")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x942730", Offset = "0x941730", VA = "0x180942730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6234FE0", Offset = "0x6233FE0", VA = "0x186234FE0")]
	public void DEHFHPLHDND(float CFJDHAGGAJO, object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6235180", Offset = "0x6234180", VA = "0x186235180")]
	public void FPCJCHDGKKD(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6235050", Offset = "0x6234050", VA = "0x186235050")]
	private void FAEGELHNHJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x62351F0", Offset = "0x62341F0", VA = "0x1862351F0")]
	public IEPFJFLOLPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class GJMCMAGIDOF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class DEIJABPEKBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public DEIJABPEKBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x50B8EC0", Offset = "0x50B7EC0", VA = "0x1850B8EC0")]
		internal int DCOAFALNIIK(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private HashSet<T>? EKICAHOOLOL;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<T> KFPBOAKFELH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x375AB70", Offset = "0x3759B70", VA = "0x18375AB70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool NJOJLDFNBLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x375A9D0", Offset = "0x37599D0", VA = "0x18375A9D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int BIBAPHNHGKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1E0", Offset = "0x7BC1E0", VA = "0x1807BD1E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7BD960", Offset = "0x7BC960", VA = "0x1807BD960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x375A860", Offset = "0x3759860", VA = "0x18375A860")]
	public bool EMJMPPLJJNE(T OGACLNNOKDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x375AA10", Offset = "0x3759A10", VA = "0x18375AA10")]
	public bool JOBFLKKFIPF(T OGACLNNOKDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x375AB30", Offset = "0x3759B30", VA = "0x18375AB30")]
	public bool NNJMGGGBMOM(T OGACLNNOKDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x375ABA0", Offset = "0x3759BA0", VA = "0x18375ABA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public GJMCMAGIDOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class ABJADLEEAMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly string KGHBGEBOPJF;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	public ABJADLEEAMP(string KGHBGEBOPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x62340A0", Offset = "0x62330A0", VA = "0x1862340A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class FCANMKLMDOK
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class MGKGHAOLNCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public MGKGHAOLNCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6236B30", Offset = "0x6235B30", VA = "0x186236B30")]
		internal int DCOAFALNIIK(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private HashSet<object>? EKICAHOOLOL;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IReadOnlyCollection<object> KFPBOAKFELH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6234680", Offset = "0x6233680", VA = "0x186234680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool NJOJLDFNBLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6234570", Offset = "0x6233570", VA = "0x186234570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int BIBAPHNHGKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1E0", Offset = "0x7BC1E0", VA = "0x1807BD1E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7BD960", Offset = "0x7BC960", VA = "0x1807BD960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6234420", Offset = "0x6233420", VA = "0x186234420")]
	public bool EMJMPPLJJNE(object OGACLNNOKDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6234580", Offset = "0x6233580", VA = "0x186234580")]
	public bool JOBFLKKFIPF(object OGACLNNOKDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6234620", Offset = "0x6233620", VA = "0x186234620")]
	public bool NNJMGGGBMOM(object OGACLNNOKDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6234500", Offset = "0x6233500", VA = "0x186234500")]
	public void GNABJIFNICG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6234710", Offset = "0x6233710", VA = "0x186234710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public FCANMKLMDOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class LAEIHEGEAJO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private struct CMBAHFKEOLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float NCHKEBDJFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public T ADACBBLDADO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Dictionary<object, CMBAHFKEOLI> MBMBPCDJPPA;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public virtual T NGPPAJFBGAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xEDBD20", Offset = "0xEDAD20", VA = "0x180EDBD20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xEDB300", Offset = "0xEDA300", VA = "0x180EDB300", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public object? PFPLAMGFKAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7BD940", Offset = "0x7BC940", VA = "0x1807BD940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool NBOGOOLPGIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3CD46A0", Offset = "0x3CD36A0", VA = "0x183CD46A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3CD3B10", Offset = "0x3CD2B10", VA = "0x183CD3B10")]
	public bool DEHFHPLHDND(T CFJDHAGGAJO, object OGACLNNOKDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x38860F0", Offset = "0x38850F0", VA = "0x1838860F0")]
	public bool FPCJCHDGKKD(object OGACLNNOKDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3CD24E0", Offset = "0x3CD14E0", VA = "0x183CD24E0")]
	public void BGPDDONPEEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4580", Offset = "0x3CD3580", VA = "0x183CD4580")]
	public bool IJFOADKACJF(object OGACLNNOKDA, [Out] T CFJDHAGGAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3CD2860", Offset = "0x3CD1860", VA = "0x183CD2860")]
	[CNNMBJEBBDE("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool CHPFKDDDCNL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3CD46F0", Offset = "0x3CD36F0", VA = "0x183CD46F0")]
	public LAEIHEGEAJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface ONCKGMJPNMF
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event MFDHAMNIEAL DBBMEJBBKON;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class LGECKPAHDHD : ONCKGMJPNMF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public readonly struct LMCNJDMKFII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public readonly float EBEKMFPLELC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public readonly float NIKCELCOIAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		internal readonly bool CJEPHDFADJG;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float DAPBPFEGNDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x6236860", Offset = "0x6235860", VA = "0x186236860")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x62369D0", Offset = "0x62359D0", VA = "0x1862369D0")]
		public LMCNJDMKFII(float CGJCOMADABC, float KOKNIBHCDLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6236870", Offset = "0x6235870", VA = "0x186236870", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class CKMKGABIHOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public LGECKPAHDHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public CKMKGABIHOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6234150", Offset = "0x6233150", VA = "0x186234150")]
		internal void EBKEMCFMAJI(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly int CCPFDJOINBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int FAEBPDPMEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly ONCKGMJPNMF[] MIJDINHJNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly MFDHAMNIEAL[] HLIOAAOLCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly LMCNJDMKFII[] AJHGONEJBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private LMCNJDMKFII IAHKIICEKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly DNGNPLIDLFJ IPKPMLCBAJC;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event MFDHAMNIEAL DBBMEJBBKON
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6236260", Offset = "0x6235260", VA = "0x186236260", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6235C20", Offset = "0x6234C20", VA = "0x186235C20", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x62363B0", Offset = "0x62353B0", VA = "0x1862363B0")]
	public LGECKPAHDHD(int CCPFDJOINBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6236320", Offset = "0x6235320", VA = "0x186236320")]
	public DNGNPLIDLFJ PIHBBCOIDBF(LMCNJDMKFII NNCOHBPELIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6235DF0", Offset = "0x6234DF0", VA = "0x186235DF0")]
	public void FMJLDNFHLFA(ONCKGMJPNMF CJKOJKENIGJ, [Optional] LMCNJDMKFII AMGHKKOACBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6235CE0", Offset = "0x6234CE0", VA = "0x186235CE0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public delegate void MFDHAMNIEAL(float NJANOFHHIBC);
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class PDKKPAANNHN
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private class PFOBKAOPGHC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly ONCKGMJPNMF HCKMEJECEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly MFDHAMNIEAL ADABDJONAPD;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6236F50", Offset = "0x6235F50", VA = "0x186236F50")]
		public PFOBKAOPGHC(ONCKGMJPNMF HCKMEJECEAJ, MFDHAMNIEAL ADABDJONAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6236F00", Offset = "0x6235F00", VA = "0x186236F00", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6236E90", Offset = "0x6235E90", VA = "0x186236E90")]
	internal static bool NABEFJOOPFI(float ABLMDKMDGNE, float AMHEHNHOGFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6229980", Offset = "0x6228980", VA = "0x186229980")]
	internal static float PMMMPADEEPO(float ABLMDKMDGNE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6236DD0", Offset = "0x6235DD0", VA = "0x186236DD0")]
	public static IDisposable CCIBEBIHPPO(this ONCKGMJPNMF HCKMEJECEAJ, MFDHAMNIEAL ADABDJONAPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class DNGNPLIDLFJ : ONCKGMJPNMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float NJANOFHHIBC;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float KKFACHBNOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6234290", Offset = "0x6233290", VA = "0x186234290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event MFDHAMNIEAL? DBBMEJBBKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6234380", Offset = "0x6233380", VA = "0x186234380", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x62341F0", Offset = "0x62331F0", VA = "0x1862341F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public DNGNPLIDLFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class APNCLJDGFFP : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E080", Offset = "0x5D1D080", VA = "0x185D1E080")]
	public APNCLJDGFFP(string DFJKCKBFLAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[DefaultMember("Item")]
public class MPCKNCEOEJP<TKey, TValue> : LIDDPMCPHEH<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, GKGLLLJHGMC where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class ANGMNCDBCDG : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public MPCKNCEOEJP<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xEDBD20", Offset = "0xEDAD20", VA = "0x180EDBD20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x38DC5C0", Offset = "0x38DB5C0", VA = "0x1838DC5C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
		[DebuggerHidden]
		public ANGMNCDBCDG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x368A190", Offset = "0x3689190", VA = "0x18368A190", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x38DC0F0", Offset = "0x38DB0F0", VA = "0x1838DC0F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x38DB8A0", Offset = "0x38DA8A0", VA = "0x1838DB8A0")]
		private void GFMFCNEFFMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x38DB850", Offset = "0x38DA850", VA = "0x1838DB850")]
		private void FIEDEKGMCFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x38DC520", Offset = "0x38DB520", VA = "0x1838DC520", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly LIDDPMCPHEH<TKey, TValue> DHDDPKCEHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly IDictionary<TKey, TValue> PHHCHIMJDLP;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int BIBAPHNHGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3EE1300", Offset = "0x3EE0300", VA = "0x183EE1300", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool LMHDAJNCEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public TValue EIFMNNJBIIL
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3EE14A0", Offset = "0x3EE04A0", VA = "0x183EE14A0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3EE1730", Offset = "0x3EE0730", VA = "0x183EE1730", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public ICollection<TKey> OHDALKNMOFC
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x3EE1510", Offset = "0x3EE0510", VA = "0x183EE1510", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public ICollection<TValue> HJJJENCHCKE
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x3EE1620", Offset = "0x3EE0620", VA = "0x183EE1620", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3EE1180", Offset = "0x3EE0180", VA = "0x183EE1180")]
	public MPCKNCEOEJP(LIDDPMCPHEH<TKey, TValue> DHDDPKCEHMF, [Optional] IDictionary<TKey, TValue>? PHHCHIMJDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3EDEE50", Offset = "0x3EDDE50", VA = "0x183EDEE50", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3EDEE00", Offset = "0x3EDDE00", VA = "0x183EDEE00")]
	public void BOFHDJJCNDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3EDEA90", Offset = "0x3EDDA90", VA = "0x183EDEA90", Slot = "9")]
	public void Add(TKey IPAJBJLLPIJ, TValue CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3EDE660", Offset = "0x3EDD660", VA = "0x183EDE660")]
	public void ABHPNOLINDO(TKey IPAJBJLLPIJ, TValue CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3EDFDD0", Offset = "0x3EDEDD0", VA = "0x183EDFDD0")]
	public void HJJMBMHADKF(TKey IPAJBJLLPIJ, TValue CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3EDFA40", Offset = "0x3EDEA40", VA = "0x183EDFA40")]
	public void HJBOHGHEFJI(TKey IPAJBJLLPIJ, TValue CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0430", Offset = "0x3EDF430", VA = "0x183EE0430")]
	public void OJCJFJHJNEI(TKey IPAJBJLLPIJ, TValue CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3EE07F0", Offset = "0x3EDF7F0", VA = "0x183EE07F0", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> OBBILAKFCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3EE09D0", Offset = "0x3EDF9D0", VA = "0x183EE09D0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> OBBILAKFCOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0D30", Offset = "0x3EDFD30", VA = "0x183EE0D30", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> OBBILAKFCOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3EDEF60", Offset = "0x3EDDF60", VA = "0x183EDEF60", Slot = "8")]
	public bool ContainsKey(TKey IPAJBJLLPIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3EDED30", Offset = "0x3EDDD30", VA = "0x183EDED30")]
	public bool BEEIAFKBANA(TKey IPAJBJLLPIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0360", Offset = "0x3EDF360", VA = "0x183EE0360")]
	public bool NBPCBCOKDOJ(TKey IPAJBJLLPIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0620", Offset = "0x3EDF620", VA = "0x183EE0620", Slot = "10")]
	public bool Remove(TKey IPAJBJLLPIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0EF0", Offset = "0x3EDFEF0", VA = "0x183EE0EF0", Slot = "11")]
	public bool TryGetValue(TKey IPAJBJLLPIJ, [Out] TValue CFJDHAGGAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3EDF260", Offset = "0x3EDE260", VA = "0x183EDF260", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] IJPOMPNGBEF, int HEBNJPJHHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA550", Offset = "0x3BC9550", VA = "0x183BCA550", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3EDF7F0", Offset = "0x3EDE7F0", VA = "0x183EDF7F0", Slot = "19")]
	[IteratorStateMachine(typeof(MPCKNCEOEJP<, >.ANGMNCDBCDG))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3EDF7A0", Offset = "0x3EDE7A0", VA = "0x183EDF7A0", Slot = "21")]
	public bool DJKFPCLCGHA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0050", Offset = "0x3EDF050", VA = "0x183EE0050")]
	private TValue LBPDKHJAPCD(TKey IPAJBJLLPIJ)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface GKGLLLJHGMC
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DJKFPCLCGHA();
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface LIDDPMCPHEH<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, GKGLLLJHGMC
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DefaultMember("Item")]
public sealed class KEHHDPFBENA<TKey, TVal> : LIDDPMCPHEH<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, GKGLLLJHGMC where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public delegate int LDFAIEBEBMC(TKey IPAJBJLLPIJ, TVal CFJDHAGGAJO);

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public delegate void GKPHBOIDIPJ(TKey IPAJBJLLPIJ, TVal CFJDHAGGAJO, LBKCBDEIAKK CPHMIDDIJGK);

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class KONCNFOOPHK
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public TKey KHCGDDAFALB
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x844EC0", Offset = "0x843EC0", VA = "0x180844EC0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public TVal ADACBBLDADO
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x967480", Offset = "0x966480", VA = "0x180967480")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x9674A0", Offset = "0x9664A0", VA = "0x1809674A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int DAPBPFEGNDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x7FABC0", Offset = "0x7F9BC0", VA = "0x1807FABC0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x7FA1C0", Offset = "0x7F91C0", VA = "0x1807FA1C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public DateTimeOffset FFIOENKJOBE
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0xAE3DE0", Offset = "0xAE2DE0", VA = "0x180AE3DE0")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x1325AF0", Offset = "0x1324AF0", VA = "0x181325AF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3C4A560", Offset = "0x3C49560", VA = "0x183C4A560")]
		public KONCNFOOPHK(TKey IPAJBJLLPIJ, TVal GKDIIMKFCMD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class OOEJBBHGLKB : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public KEHHDPFBENA<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private LinkedList<KONCNFOOPHK>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xEDBD20", Offset = "0xEDAD20", VA = "0x180EDBD20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x408FBE0", Offset = "0x408EBE0", VA = "0x18408FBE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
		[DebuggerHidden]
		public OOEJBBHGLKB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3685110", Offset = "0x3684110", VA = "0x183685110", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x408E160", Offset = "0x408D160", VA = "0x18408E160", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x408E0E0", Offset = "0x408D0E0", VA = "0x18408E0E0")]
		private void GFMFCNEFFMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x408FB40", Offset = "0x408EB40", VA = "0x18408FB40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const int HCFFAKEBNLC = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<TKey, LinkedListNode<KONCNFOOPHK>> KMMAPHCLJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly LinkedList<KONCNFOOPHK> LPEMBPPODIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly LDFAIEBEBMC? DFHMIOHGMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly TimeSpan FCBCACLGBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly GKPHBOIDIPJ? FPPAJLAIMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly MJFHKAKOPCC IKNIOKCKMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool OHHLBABENCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly List<TKey> OBLMMAAIDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly List<TVal> KJBMCPOLBFK;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int HGGNFGJEBJA
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1C0", Offset = "0x7CA1C0", VA = "0x1807CB1C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	internal int COHNALKANFH
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9BE230", Offset = "0x9BD230", VA = "0x1809BE230")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9BDD50", Offset = "0x9BCD50", VA = "0x1809BDD50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int BIBAPHNHGKH
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x3C0B830", Offset = "0x3C0A830", VA = "0x183C0B830", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	internal int OKDFGJFGJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x376D880", Offset = "0x376C880", VA = "0x18376D880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public ICollection<TVal> HJJJENCHCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3C0B960", Offset = "0x3C0A960", VA = "0x183C0B960", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	ICollection<TKey> IDictionary<TKey, TVal>.FNHCHIOGOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x3C06F80", Offset = "0x3C05F80", VA = "0x183C06F80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool LMHDAJNCEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public TVal EIFMNNJBIIL
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3C0B8C0", Offset = "0x3C0A8C0", VA = "0x183C0B8C0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3C0B9B0", Offset = "0x3C0A9B0", VA = "0x183C0B9B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3C00B50", Offset = "0x3BFFB50", VA = "0x183C00B50")]
	private bool LNAGMJNLIIM(int CCPFDJOINBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3BFAA40", Offset = "0x3BF9A40", VA = "0x183BFAA40")]
	private void GBADIDCHJCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3C090F0", Offset = "0x3C080F0", VA = "0x183C090F0")]
	public KEHHDPFBENA(int CCPFDJOINBO, [Optional] LDFAIEBEBMC? DFHMIOHGMHM, [Optional] IEqualityComparer<TKey>? BLOFPFPDNNF, [Optional] GKPHBOIDIPJ? FPPAJLAIMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3C082F0", Offset = "0x3C072F0", VA = "0x183C082F0")]
	public KEHHDPFBENA(TimeSpan FCBCACLGBJH, [Optional] IEqualityComparer<TKey>? BLOFPFPDNNF, [Optional] GKPHBOIDIPJ? FPPAJLAIMKI, [Optional] MJFHKAKOPCC? IKNIOKCKMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3C07E90", Offset = "0x3C06E90", VA = "0x183C07E90")]
	public KEHHDPFBENA(int CCPFDJOINBO, TimeSpan FCBCACLGBJH, [Optional] IEqualityComparer<TKey>? BLOFPFPDNNF, [Optional] GKPHBOIDIPJ? FPPAJLAIMKI, [Optional] MJFHKAKOPCC? IKNIOKCKMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3C0A320", Offset = "0x3C09320", VA = "0x183C0A320")]
	public KEHHDPFBENA(int CCPFDJOINBO, LDFAIEBEBMC? DFHMIOHGMHM, TimeSpan FCBCACLGBJH, [Optional] IEqualityComparer<TKey>? BLOFPFPDNNF, [Optional] GKPHBOIDIPJ? FPPAJLAIMKI, [Optional] MJFHKAKOPCC? IKNIOKCKMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3BFA9D0", Offset = "0x3BF99D0", VA = "0x183BFA9D0", Slot = "21")]
	public bool DJKFPCLCGHA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3C00830", Offset = "0x3BFF830", VA = "0x183C00830", Slot = "22")]
	public bool LDDGAHILJAL(int BEELDCKKFJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3C02C40", Offset = "0x3C01C40", VA = "0x183C02C40")]
	private bool NONNNAPBHAH(int BEELDCKKFJL, LBKCBDEIAKK CPHMIDDIJGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3C058A0", Offset = "0x3C048A0", VA = "0x183C058A0")]
	public void PCMENIKJJKG(TKey IPAJBJLLPIJ, TVal CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3BF3D10", Offset = "0x3BF2D10", VA = "0x183BF3D10", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> OBBILAKFCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3BF3AA0", Offset = "0x3BF2AA0", VA = "0x183BF3AA0", Slot = "9")]
	public void Add(TKey IPAJBJLLPIJ, TVal CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3BF5FA0", Offset = "0x3BF4FA0", VA = "0x183BF5FA0", Slot = "8")]
	public bool ContainsKey(TKey IPAJBJLLPIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3C064F0", Offset = "0x3C054F0", VA = "0x183C064F0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> OBBILAKFCOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3C06290", Offset = "0x3C05290", VA = "0x183C06290", Slot = "10")]
	public bool Remove(TKey IPAJBJLLPIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3C06C00", Offset = "0x3C05C00", VA = "0x183C06C00", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> OBBILAKFCOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3BFF480", Offset = "0x3BFE480", VA = "0x183BFF480")]
	private bool KCFKKKNNEBA(TKey IPAJBJLLPIJ, [Out] TVal CFJDHAGGAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x3C00D80", Offset = "0x3BFFD80", VA = "0x183C00D80")]
	private TVal LNKEGHLMDOM(TKey DGGCIGEBIBO)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3C07520", Offset = "0x3C06520", VA = "0x183C07520", Slot = "11")]
	public bool TryGetValue(TKey DGGCIGEBIBO, [Out] TVal CFJDHAGGAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3BF5EF0", Offset = "0x3BF4EF0", VA = "0x183BF5EF0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3BF8620", Offset = "0x3BF7620", VA = "0x183BF8620", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] IJPOMPNGBEF, int HEBNJPJHHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3BF5650", Offset = "0x3BF4650", VA = "0x183BF5650")]
	private void CKBPBLKOMKO(TKey IPAJBJLLPIJ, TVal GKDIIMKFCMD, LBKCBDEIAKK CPHMIDDIJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3BF4A70", Offset = "0x3BF3A70", VA = "0x183BF4A70")]
	private bool BEJJLGNKDDL(KONCNFOOPHK LJDHIDEDFCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3BFC080", Offset = "0x3BFB080", VA = "0x183BFC080")]
	private void GLOGJJKCAMM(LinkedListNode<KONCNFOOPHK> BJFEKOCOBFH, TVal NGHGKHJGNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3BF9180", Offset = "0x3BF8180", VA = "0x183BF9180")]
	private void DEHFHPLHDND(TKey IPAJBJLLPIJ, TVal CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3BFE360", Offset = "0x3BFD360", VA = "0x183BFE360")]
	private void HEOKJAJJAIJ(KONCNFOOPHK LJDHIDEDFCC, TVal NGHGKHJGNGG, int HNBEOBKGOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3BFDA30", Offset = "0x3BFCA30", VA = "0x183BFDA30", Slot = "19")]
	[IteratorStateMachine(typeof(KEHHDPFBENA<, >.OOEJBBHGLKB))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3C06FB0", Offset = "0x3C05FB0", VA = "0x183C06FB0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public enum LBKCBDEIAKK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	RemovedViaClear
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class CJMFLAMEMAB<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly TKey GFDJPPFMGAH;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x4C97B10", Offset = "0x4C96B10", VA = "0x184C97B10")]
	public CJMFLAMEMAB(TKey INKCNAFLDGB, Exception OHPABOEDNNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class ABPJEOJJNMH : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5615AE0", Offset = "0x5614AE0", VA = "0x185615AE0")]
	public ABPJEOJJNMH(string DFJKCKBFLAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class LOOBOOGNOAC<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class OBGMIPLIJAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public LOOBOOGNOAC<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public OBGMIPLIJAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x4062EE0", Offset = "0x4061EE0", VA = "0x184062EE0")]
		internal Task<TResource> NMLGKAMLACB(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct JPHCMKNGOEA : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3B60E20", Offset = "0x3B5FE20", VA = "0x183B60E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3B617E0", Offset = "0x3B607E0", VA = "0x183B617E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct LGELIKNBJMB : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3CE86B0", Offset = "0x3CE76B0", VA = "0x183CE86B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3CE8E90", Offset = "0x3CE7E90", VA = "0x183CE8E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly HEDHFNKIKGP<TId, Task<TResource>> KEJIJONKLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> NCGGHPFNBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? IAMDPEMOCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly Action<TResource>? GAGBPMEPEJJ;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3D09470", Offset = "0x3D08470", VA = "0x183D09470")]
	public LOOBOOGNOAC(int JMKLOAGBDEE = 0, [Optional] IEqualityComparer<TId>? DIELKLFDFDA, [Optional] Func<TId, CancellationToken, Task<TResource>>? DMOHHOJLADE, [Optional] Action<TResource>? ICJFPODIBPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3D08A00", Offset = "0x3D07A00", VA = "0x183D08A00")]
	public ACLFJKPGHAP<Task<TResource>> KFEHOFHILDH(TId IJKMNFNHLGO, [Optional] Func<TId, CancellationToken, Task<TResource>>? DMOHHOJLADE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3D08440", Offset = "0x3D07440", VA = "0x183D08440")]
	private void BCPMFLCKAME(Task<TResource> JCGMNOGFGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3D086A0", Offset = "0x3D076A0", VA = "0x183D086A0")]
	public void FHDPCBELMCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3D085C0", Offset = "0x3D075C0", VA = "0x183D085C0")]
	public HEDHFNKIKGP<TId, Task<TResource>>.GEKNOPDKEJO CJGNNJFLGEE()
	{
		return default(HEDHFNKIKGP<TId, Task<TResource>>.GEKNOPDKEJO);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3D092A0", Offset = "0x3D082A0", VA = "0x183D092A0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3D092A0", Offset = "0x3D082A0", VA = "0x183D092A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3D09170", Offset = "0x3D08170", VA = "0x183D09170")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(LOOBOOGNOAC<, >.JPHCMKNGOEA))]
	internal static Task NNHOPBPMJDN(Task<TResource> JCGMNOGFGHB, CancellationTokenSource DDBIGIBPEHI, Dictionary<Task<TResource>, CancellationTokenSource> PMIGCMPOGOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3D087E0", Offset = "0x3D077E0", VA = "0x183D087E0")]
	[AsyncStateMachine(typeof(LOOBOOGNOAC<, >.LGELIKNBJMB))]
	[CompilerGenerated]
	internal static Task HHJFIDBCOIF(Task<TResource> JCGMNOGFGHB, Action<TResource> DANLHJGDCGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class HEDHFNKIKGP<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private sealed class EDAKEJDELGA : IEquatable<EDAKEJDELGA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TValue ADACBBLDADO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int ADIMOGJDEMC;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x1CA55B0", Offset = "0x1CA45B0", VA = "0x181CA55B0")]
		public EDAKEJDELGA(TValue CFJDHAGGAJO, int GIOLBPCLIDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x330CC40", Offset = "0x330BC40", VA = "0x18330CC40", Slot = "4")]
		public bool Equals(EDAKEJDELGA? PJNBIAFGNNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x330CBA0", Offset = "0x330BBA0", VA = "0x18330CBA0", Slot = "0")]
		public override bool Equals(object? FGOCJODIEMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x330CDF0", Offset = "0x330BDF0", VA = "0x18330CDF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct GEKNOPDKEJO : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private Dictionary<TKey, EDAKEJDELGA>.Enumerator KDAAPJBIDKH;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x3741D50", Offset = "0x3740D50", VA = "0x183741D50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public (TKey Key, TValue Value, int RefCount) FKHNLELEDDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x3742190", Offset = "0x3741190", VA = "0x183742190", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3742000", Offset = "0x3741000", VA = "0x183742000")]
		public GEKNOPDKEJO(HEDHFNKIKGP<TKey, TValue> MBMBPCDJPPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3741A40", Offset = "0x3740A40", VA = "0x183741A40", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3741A80", Offset = "0x3740A80", VA = "0x183741A80", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3741BF0", Offset = "0x3740BF0", VA = "0x183741BF0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class EAOJNDDDLFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public HEDHFNKIKGP<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public EDAKEJDELGA refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public EAOJNDDDLFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3309E00", Offset = "0x3308E00", VA = "0x183309E00")]
		internal void NMLGKAMLACB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<TKey, EDAKEJDELGA> NNMFCBLINAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly Func<TKey, TValue>? NOADEEFNKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly Action<TValue>? LBNNCGMKKOK;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x37BDD30", Offset = "0x37BCD30", VA = "0x1837BDD30")]
	public HEDHFNKIKGP(int JMKLOAGBDEE = 0, [Optional] IEqualityComparer<TKey>? BLOFPFPDNNF, [Optional] Func<TKey, TValue>? HDFKFKNDFCB, [Optional] Action<TValue>? MINOFABIILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x37BCFF0", Offset = "0x37BBFF0", VA = "0x1837BCFF0")]
	public ACLFJKPGHAP<TValue> KFEHOFHILDH(TKey IPAJBJLLPIJ, [Optional] Func<TKey, TValue>? PJACHMFBJBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x37BD870", Offset = "0x37BC870", VA = "0x1837BD870")]
	private void PJJDMGCOONE(TKey IPAJBJLLPIJ, EDAKEJDELGA OOCFHNLLGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x37BCA40", Offset = "0x37BBA40", VA = "0x1837BCA40")]
	public void FHDPCBELMCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x37BC9C0", Offset = "0x37BB9C0", VA = "0x1837BC9C0")]
	public GEKNOPDKEJO CJGNNJFLGEE()
	{
		return default(GEKNOPDKEJO);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x37BDC90", Offset = "0x37BCC90", VA = "0x1837BDC90", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x37BDC90", Offset = "0x37BCC90", VA = "0x1837BDC90", Slot = "5")]
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
