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
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6369ED0", Offset = "0x6368ED0", VA = "0x186369ED0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EB340", Offset = "0x7EA340", VA = "0x1807EB340")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EB380", Offset = "0x7EA380", VA = "0x1807EB380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class KLKAFCCPEEK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	protected KLKAFCCPEEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class CAOPAAGBDGF<T> : KLKAFCCPEEK
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct PIMEMBGLAEO
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum GPLABGJKNIO
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
		public GPLABGJKNIO KBCNAJKPHNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T LNMJHEPMAAO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int KJCIMBPCPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool KIOBDIGPHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool AKCIFDCOJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? MNHDPKHEDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<PIMEMBGLAEO>? FMKEHPBLKAH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MLOHBLMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4BDC400", Offset = "0x4BDB400", VA = "0x184BDC400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4BDCB00", Offset = "0x4BDBB00", VA = "0x184BDCB00")]
	protected CAOPAAGBDGF(bool AKCIFDCOJDF, bool KIOBDIGPHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4BDC7B0", Offset = "0x4BDB7B0", VA = "0x184BDC7B0")]
	protected bool MEHHHJGCMBF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4BDC850", Offset = "0x4BDB850", VA = "0x184BDC850")]
	protected void MHNOGMIKMCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4BDC5D0", Offset = "0x4BDB5D0", VA = "0x184BDC5D0")]
	protected void MANNCJFOFMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x26AE5F0", Offset = "0x26AD5F0", VA = "0x1826AE5F0")]
	private static void MIGODMFHLDL<U>(List<U>? FKIBLLNGEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4BDC220", Offset = "0x4BDB220", VA = "0x184BDC220", Slot = "4")]
	public void BGLDHBEBEIE(T LNMJHEPMAAO, bool KEOCHIKFNHB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4BDC950", Offset = "0x4BDB950", VA = "0x184BDC950", Slot = "5")]
	public void NCLCGNJGAKA(T LNMJHEPMAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4BDC450", Offset = "0x4BDB450", VA = "0x184BDC450")]
	public void HCLIMFMHPCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MJCOEDAIADH
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGLDHBEBEIE(Action LNMJHEPMAAO, bool KEOCHIKFNHB = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NCLCGNJGAKA(Action LNMJHEPMAAO);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class ONDMBBPPJJI : CAOPAAGBDGF<Action>, MJCOEDAIADH
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x636A270", Offset = "0x6369270", VA = "0x18636A270")]
	public ONDMBBPPJJI(bool AKCIFDCOJDF = false, bool KIOBDIGPHNA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x636A010", Offset = "0x6369010", VA = "0x18636A010")]
	public void HEGHDPNDHOB()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x636A210", Offset = "0x6369210", VA = "0x18636A210")]
	public static ONDMBBPPJJI JICKFCFOKMA(ONDMBBPPJJI MFOMODIFCDK, Action LNMJHEPMAAO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6369FB0", Offset = "0x6368FB0", VA = "0x186369FB0")]
	public static ONDMBBPPJJI DFHEKEBHCDI(ONDMBBPPJJI MFOMODIFCDK, Action LNMJHEPMAAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DNLBDEFEDLC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGLDHBEBEIE(Action<T> LNMJHEPMAAO, bool KEOCHIKFNHB = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NCLCGNJGAKA(Action<T> LNMJHEPMAAO);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class MIADACEFMCK<T> : CAOPAAGBDGF<Action<T>>, DNLBDEFEDLC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x350A000", Offset = "0x3509000", VA = "0x18350A000")]
	public MIADACEFMCK(bool AKCIFDCOJDF = false, bool KIOBDIGPHNA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x403F140", Offset = "0x403E140", VA = "0x18403F140")]
	public void HEGHDPNDHOB(T DCCCOAOAGBH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3509F70", Offset = "0x3508F70", VA = "0x183509F70")]
	public static MIADACEFMCK<T> JICKFCFOKMA(MIADACEFMCK<T> MFOMODIFCDK, Action<T> LNMJHEPMAAO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x35060D0", Offset = "0x35050D0", VA = "0x1835060D0")]
	public static MIADACEFMCK<T> DFHEKEBHCDI(MIADACEFMCK<T> MFOMODIFCDK, Action<T> LNMJHEPMAAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JKHLKBDALOG<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class EFKALDPIAIL<T, U> : CAOPAAGBDGF<Action<T, U>>, JKHLKBDALOG<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x350A000", Offset = "0x3509000", VA = "0x18350A000")]
	public EFKALDPIAIL(bool AKCIFDCOJDF = false, bool KIOBDIGPHNA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3507590", Offset = "0x3506590", VA = "0x183507590")]
	public void HEGHDPNDHOB(T DCCCOAOAGBH, U NOECACKDCHI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3509F70", Offset = "0x3508F70", VA = "0x183509F70")]
	public static EFKALDPIAIL<T, U> JICKFCFOKMA(EFKALDPIAIL<T, U> MFOMODIFCDK, Action<T, U> LNMJHEPMAAO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x35060D0", Offset = "0x35050D0", VA = "0x1835060D0")]
	public static EFKALDPIAIL<T, U> DFHEKEBHCDI(EFKALDPIAIL<T, U> MFOMODIFCDK, Action<T, U> LNMJHEPMAAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class FBOECCOHABO<T, U, V> : CAOPAAGBDGF<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x350A000", Offset = "0x3509000", VA = "0x18350A000")]
	public FBOECCOHABO(bool AKCIFDCOJDF = false, bool KIOBDIGPHNA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3883290", Offset = "0x3882290", VA = "0x183883290")]
	public void HEGHDPNDHOB(T DCCCOAOAGBH, U NOECACKDCHI, V JFNFFLEPNAC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3509F70", Offset = "0x3508F70", VA = "0x183509F70")]
	public static FBOECCOHABO<T, U, V> JICKFCFOKMA(FBOECCOHABO<T, U, V> MFOMODIFCDK, Action<T, U, V> LNMJHEPMAAO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x35060D0", Offset = "0x35050D0", VA = "0x1835060D0")]
	public static FBOECCOHABO<T, U, V> DFHEKEBHCDI(FBOECCOHABO<T, U, V> MFOMODIFCDK, Action<T, U, V> LNMJHEPMAAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PALCAIGFFAH<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class GIPGBDCDALA<T, U, V, W> : CAOPAAGBDGF<Action<T, U, V, W>>, PALCAIGFFAH<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x350A000", Offset = "0x3509000", VA = "0x18350A000")]
	public GIPGBDCDALA(bool AKCIFDCOJDF = false, bool KIOBDIGPHNA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x39A51F0", Offset = "0x39A41F0", VA = "0x1839A51F0")]
	public void HEGHDPNDHOB(T DCCCOAOAGBH, U NOECACKDCHI, V JFNFFLEPNAC, W PKFDHNAJKPJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3509F70", Offset = "0x3508F70", VA = "0x183509F70")]
	public static GIPGBDCDALA<T, U, V, W> JICKFCFOKMA(GIPGBDCDALA<T, U, V, W> MFOMODIFCDK, Action<T, U, V, W> LNMJHEPMAAO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x35060D0", Offset = "0x35050D0", VA = "0x1835060D0")]
	public static GIPGBDCDALA<T, U, V, W> DFHEKEBHCDI(GIPGBDCDALA<T, U, V, W> MFOMODIFCDK, Action<T, U, V, W> LNMJHEPMAAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class GFGBGNAFOJB<T, U, V, W, X> : CAOPAAGBDGF<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x350A000", Offset = "0x3509000", VA = "0x18350A000")]
	public GFGBGNAFOJB(bool AKCIFDCOJDF = false, bool KIOBDIGPHNA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x399D680", Offset = "0x399C680", VA = "0x18399D680")]
	public void HEGHDPNDHOB(T DCCCOAOAGBH, U NOECACKDCHI, V JFNFFLEPNAC, W PKFDHNAJKPJ, X DLGLHFDHDLB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3509F70", Offset = "0x3508F70", VA = "0x183509F70")]
	public static GFGBGNAFOJB<T, U, V, W, X> JICKFCFOKMA(GFGBGNAFOJB<T, U, V, W, X> MFOMODIFCDK, Action<T, U, V, W, X> LNMJHEPMAAO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x35060D0", Offset = "0x35050D0", VA = "0x1835060D0")]
	public static GFGBGNAFOJB<T, U, V, W, X> DFHEKEBHCDI(GFGBGNAFOJB<T, U, V, W, X> MFOMODIFCDK, Action<T, U, V, W, X> LNMJHEPMAAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class DADDAKGPAIL<T, U, V, W, X, Y> : CAOPAAGBDGF<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x350A000", Offset = "0x3509000", VA = "0x18350A000")]
	public DADDAKGPAIL(bool AKCIFDCOJDF = false, bool KIOBDIGPHNA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x51DED40", Offset = "0x51DDD40", VA = "0x1851DED40")]
	public void HEGHDPNDHOB(T DCCCOAOAGBH, U NOECACKDCHI, V JFNFFLEPNAC, W PKFDHNAJKPJ, X DLGLHFDHDLB, Y ANLBKHHFCFE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3509F70", Offset = "0x3508F70", VA = "0x183509F70")]
	public static DADDAKGPAIL<T, U, V, W, X, Y> JICKFCFOKMA(DADDAKGPAIL<T, U, V, W, X, Y> MFOMODIFCDK, Action<T, U, V, W, X, Y> LNMJHEPMAAO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x35060D0", Offset = "0x35050D0", VA = "0x1835060D0")]
	public static DADDAKGPAIL<T, U, V, W, X, Y> DFHEKEBHCDI(DADDAKGPAIL<T, U, V, W, X, Y> MFOMODIFCDK, Action<T, U, V, W, X, Y> LNMJHEPMAAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KFPBGMPGFBC<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly EAOCBIJBBIG<TKey, TVal> OJBDJBAJOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> POGGMAJKEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly EAOCBIJBBIG<TKey, TVal>.BDOOEDFDCFK? BNNDPAIMEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int HOLIPJJKGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly EAOCBIJBBIG<TKey, TVal>.CHJFHDMLHJP? JFDECDJNIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int HNIKOIPPIDC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int FNCMMEDCBLH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3D6DE70", Offset = "0x3D6CE70", VA = "0x183D6DE70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int DFONNJMCPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D80", Offset = "0x7C1D80", VA = "0x1807C2D80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3D6EAB0", Offset = "0x3D6DAB0", VA = "0x183D6EAB0")]
	public KFPBGMPGFBC(int HOLIPJJKGPJ, [Optional] EAOCBIJBBIG<TKey, TVal>.CHJFHDMLHJP? JFDECDJNIMA, [Optional] IEqualityComparer<TKey>? BDMBCFNHNFA, [Optional] EAOCBIJBBIG<TKey, TVal>.BDOOEDFDCFK? BNNDPAIMEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3D6DBC0", Offset = "0x3D6CBC0", VA = "0x183D6DBC0")]
	public void DIEFIOMGHFL(TKey OHNEPKBBADL, TVal LDGMLLMKHLF, bool DAMGFNAAEGM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3D6E0F0", Offset = "0x3D6D0F0", VA = "0x183D6E0F0")]
	public bool NAGHFFHHIMI(TKey OHNEPKBBADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3D6DD90", Offset = "0x3D6CD90", VA = "0x183D6DD90")]
	public bool DKPMPOAPJNG(TKey IMFAKCHHMPL, [Out] TVal LDGMLLMKHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3D6E350", Offset = "0x3D6D350", VA = "0x183D6E350")]
	private void OAOCDHGACFE(TKey OHNEPKBBADL, TVal LDGMLLMKHLF, int GFFAGBDKDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3D6DA30", Offset = "0x3D6CA30", VA = "0x183D6DA30")]
	public bool BHMJIEFCADB(TKey OHNEPKBBADL, TVal LDGMLLMKHLF, bool DAMGFNAAEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3D6DFA0", Offset = "0x3D6CFA0", VA = "0x183D6DFA0")]
	public void HCLIMFMHPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3D6E5B0", Offset = "0x3D6D5B0", VA = "0x183D6E5B0")]
	private void PLALOGIFENO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3D6E000", Offset = "0x3D6D000", VA = "0x183D6E000")]
	private bool JKDLICJJJDB(TKey OHNEPKBBADL, LILFJBGIPJG KDLIPBNGNPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3D6DEC0", Offset = "0x3D6CEC0", VA = "0x183D6DEC0")]
	private void EGMAKGCCGNC(TKey OHNEPKBBADL, TVal LDGMLLMKHLF, LILFJBGIPJG KDLIPBNGNPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3D6E220", Offset = "0x3D6D220", VA = "0x183D6E220")]
	private void NHMEOBHLLIJ(TKey OHNEPKBBADL, TVal PAFHPJKJPEL, LILFJBGIPJG KDLIPBNGNPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FOEKLOLHPAK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action PEBAIOKACLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool KBPDDNADGAJ;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C50", Offset = "0x7C8C50", VA = "0x1807C9C50")]
	public FOEKLOLHPAK(Action PNPLLJEEJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6368040", Offset = "0x6367040", VA = "0x186368040", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2717F40", Offset = "0x2716F40", VA = "0x182717F40")]
	public static IDLDPOIKMNH<T> EOFBBDOECDH<T>(T LDGMLLMKHLF, Action PNPLLJEEJKD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class IDLDPOIKMNH<T> : FOEKLOLHPAK where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T DMDNAKDAMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8CE0", Offset = "0x3AE7CE0", VA = "0x183AE8CE0")]
	public IDLDPOIKMNH(T LDGMLLMKHLF, Action PNPLLJEEJKD)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct LGMKGIJNBAN : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct AFGMIBGGIOM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00")]
		public static AFGMIBGGIOM MGIIAIMPALM()
		{
			return default(AFGMIBGGIOM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x295F340", Offset = "0x295E340", VA = "0x18295F340")]
	public static string? AIIFMCNMOCO<T>([Optional] string? GDCCIAHKKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x295F3C0", Offset = "0x295E3C0", VA = "0x18295F3C0")]
	public static string? FHIILGBLIBC<T>([Optional] string? EBBEFDBJJIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00")]
	public static LGMKGIJNBAN EJAHKPICHNP(string GDCCIAHKKAN, string? EBBEFDBJJIL)
	{
		return default(LGMKGIJNBAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct LLKBFGNAECE
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool LCNIEIALKOL(string APAIOOHBLEO, LLKBFGNAECE GGPHADCHOIO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public int PAFEMMFOAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public string OKCMEJKHLNC;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6369610", Offset = "0x6368610", VA = "0x186369610")]
	public static Dictionary<string, LLKBFGNAECE> CADLCKCDDJN(Type APGGJNBDPOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6369950", Offset = "0x6368950", VA = "0x186369950")]
	public static Dictionary<string, LLKBFGNAECE> ILKHDCJBOHL(Type APGGJNBDPOE, LCNIEIALKOL OPPMPHPJELG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6369D10", Offset = "0x6368D10", VA = "0x186369D10")]
	public static Dictionary<int, string> KHEKMMNDNNO(Dictionary<string, LLKBFGNAECE> KEHDHCINJMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class HBNEILLBGHD : HHPFBBGIKCL
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool AHIGBPDDCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string? MGEAHJIDLGA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual HHPFBBGIKCL? GGNNAKNKJOI
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6368810", Offset = "0x6367810", VA = "0x186368810")]
	protected HBNEILLBGHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string MGJEJBNDCKI();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6368790", Offset = "0x6367790", VA = "0x186368790", Slot = "8")]
	public virtual string LINNALEOOPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x63682E0", Offset = "0x63672E0", VA = "0x1863682E0", Slot = "9")]
	public void EGHHBILEELG(StringBuilder IIJHFHKKAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6368160", Offset = "0x6367160", VA = "0x186368160", Slot = "10")]
	public void CPHJFLLMOFJ(StringBuilder IIJHFHKKAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x63681C0", Offset = "0x63671C0", VA = "0x1863681C0", Slot = "11")]
	public void DELHABCCLEC(StringBuilder IIJHFHKKAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6368590", Offset = "0x6367590", VA = "0x186368590", Slot = "12")]
	public void ELEGFCMHDJB(StringBuilder IIJHFHKKAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x63686F0", Offset = "0x63676F0", VA = "0x1863686F0")]
	public static void IFGGFPPCLJE(StringBuilder IIJHFHKKAOH, string DEPBJLGCOBB, string HMJFKFFKKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x55BA520", Offset = "0x55B9520", VA = "0x1855BA520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BLDBLIAEBDO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6367710", Offset = "0x6366710", VA = "0x186367710")]
	public BLDBLIAEBDO(string JJJNODJJIFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class PHKDMKBOKMD<TErr> : BLDBLIAEBDO where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly TErr DCEJHCAOBHL;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x42931B0", Offset = "0x42921B0", VA = "0x1842931B0")]
	private PHKDMKBOKMD([In] TErr LDEICBENOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x42930E0", Offset = "0x42920E0", VA = "0x1842930E0")]
	public static PHKDMKBOKMD<TErr> MGIIAIMPALM([In] TErr LDEICBENOHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface HHPFBBGIKCL
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LINNALEOOPP();

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string MGJEJBNDCKI();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface BKGJCPMAIEM<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TOptions DMDNAKDAMMG
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface AHPMCFCLCAI
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string EPPHKAHLPCN
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OBPEKFOBLML : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6369F50", Offset = "0x6368F50", VA = "0x186369F50")]
	public OBPEKFOBLML(string JJJNODJJIFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class LBJJIFGAMKA<TOk> : OBPEKFOBLML where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly TOk JNINOENKHDJ;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3E16F90", Offset = "0x3E15F90", VA = "0x183E16F90")]
	private LBJJIFGAMKA([In] TOk EKPEOGILMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3E16EC0", Offset = "0x3E15EC0", VA = "0x183E16EC0")]
	public static LBJJIFGAMKA<TOk> MGIIAIMPALM([In] TOk EKPEOGILMIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct PGLGENBDGKP<TOk, TErr> : IEquatable<PGLGENBDGKP<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static readonly EqualityComparer<TErr> CHBGJCPEEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly TErr DCEJHCAOBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal readonly TOk JNINOENKHDJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool KJGEHKNMAIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x428D1E0", Offset = "0x428C1E0", VA = "0x18428D1E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool FCMEADNEBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4288870", Offset = "0x4287870", VA = "0x184288870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4290640", Offset = "0x428F640", VA = "0x184290640")]
	internal PGLGENBDGKP([In] TErr LDEICBENOHG, [In] TOk EKPEOGILMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x428BA20", Offset = "0x428AA20", VA = "0x18428BA20")]
	public static PGLGENBDGKP<TOk, TErr> JPFDMHFADFH([In] TErr LDEICBENOHG)
	{
		return default(PGLGENBDGKP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x42892D0", Offset = "0x42882D0", VA = "0x1842892D0")]
	public static PGLGENBDGKP<TOk, TErr> BAGGOAPPACF([In] TOk EKPEOGILMIH)
	{
		return default(PGLGENBDGKP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2888590", Offset = "0x2887590", VA = "0x182888590")]
	public PGLGENBDGKP<TOk?, UErr?> MBGPGLDEEDC<UErr>()
	{
		return default(PGLGENBDGKP<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2888EA0", Offset = "0x2887EA0", VA = "0x182888EA0")]
	public PGLGENBDGKP<UOk?, TErr?> NIPHNMOAOIJ<UOk>()
	{
		return default(PGLGENBDGKP<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2887930", Offset = "0x2886930", VA = "0x182887930")]
	public PGLGENBDGKP<UOk?, TErr?> APMDBHEHDNA<UOk>()
	{
		return default(PGLGENBDGKP<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2888A60", Offset = "0x2887A60", VA = "0x182888A60")]
	public PGLGENBDGKP<TOk?, UErr?> MIKBEMMGMCA<UErr>()
	{
		return default(PGLGENBDGKP<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x428D8D0", Offset = "0x428C8D0", VA = "0x18428D8D0")]
	public PGLGENBDGKP<KLKJPNNICPF, TErr> MJJEFCPKKOH()
	{
		return default(PGLGENBDGKP<KLKJPNNICPF, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x428C8E0", Offset = "0x428B8E0", VA = "0x18428C8E0")]
	public static bool JPKEALLKLNK([In] PGLGENBDGKP<TOk, TErr> LHPJOLLNMHI, [In] PGLGENBDGKP<TOk, TErr> MGIFPMANJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4289980", Offset = "0x4288980", VA = "0x184289980", Slot = "4")]
	public bool Equals(PGLGENBDGKP<TOk, TErr> JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4289650", Offset = "0x4288650", VA = "0x184289650", Slot = "0")]
	public override bool Equals(object JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x428B450", Offset = "0x428A450", VA = "0x18428B450", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x428EE70", Offset = "0x428DE70", VA = "0x18428EE70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class MHFJNACMIEC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct JMGPOHIHAJM<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public Task<PGLGENBDGKP<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<PGLGENBDGKP<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3D15660", Offset = "0x3D14660", VA = "0x183D15660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3D15CA0", Offset = "0x3D14CA0", VA = "0x183D15CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x29840D0", Offset = "0x29830D0", VA = "0x1829840D0")]
	public static PGLGENBDGKP<TOk?, TErr?> JNINOENKHDJ<TOk, TErr>([In] this PGLGENBDGKP<TOk, TErr> HFLBADIEKAM, [In] TOk EKPEOGILMIH)
	{
		return default(PGLGENBDGKP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2984410", Offset = "0x2983410", VA = "0x182984410")]
	public static PGLGENBDGKP<KLKJPNNICPF, TErr?> JNINOENKHDJ<TErr>([In] this PGLGENBDGKP<KLKJPNNICPF, TErr> HFLBADIEKAM)
	{
		return default(PGLGENBDGKP<KLKJPNNICPF, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x29840D0", Offset = "0x29830D0", VA = "0x1829840D0")]
	public static PGLGENBDGKP<TOk?, TErr?> DCEJHCAOBHL<TOk, TErr>([In] this PGLGENBDGKP<TOk, TErr> HFLBADIEKAM, [In] TErr LDEICBENOHG)
	{
		return default(PGLGENBDGKP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2984E10", Offset = "0x2983E10", VA = "0x182984E10")]
	public static TOk? MKGDMDICLPD<TOk, TErr>([In] this PGLGENBDGKP<TOk, TErr> HFLBADIEKAM)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x29851A0", Offset = "0x29841A0", VA = "0x1829851A0")]
	[AsyncStateMachine(typeof(JMGPOHIHAJM<, >))]
	public static Task<TOk?>? NKBNMOENJML<TOk, TErr>(this Task<PGLGENBDGKP<TOk, TErr>> HFLBADIEKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2983D10", Offset = "0x2982D10", VA = "0x182983D10")]
	public static TErr? CHGGBNLFLDD<TErr, TOk>([In] this PGLGENBDGKP<TOk, TErr> HFLBADIEKAM)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2985440", Offset = "0x2984440", VA = "0x182985440")]
	public static bool PBKIPDAKJMP<TOk, TErr, UErr, UOk>([In] this PGLGENBDGKP<TOk, TErr> HFLBADIEKAM, [Out] PGLGENBDGKP<UOk, UErr> IFNBGFOIMGL) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2983BF0", Offset = "0x2982BF0", VA = "0x182983BF0")]
	public static bool CEKGLDEEHHA<TOk, TErr>([In] this PGLGENBDGKP<TOk, TErr> HFLBADIEKAM, [Out][NotNullWhen(true)] TOk EKPEOGILMIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2984250", Offset = "0x2983250", VA = "0x182984250")]
	public static bool HMIMFLENBJO<TOk, TErr>([In] this PGLGENBDGKP<TOk, TErr> HFLBADIEKAM, [Out][NotNullWhen(true)] TErr LDEICBENOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2984320", Offset = "0x2983320", VA = "0x182984320")]
	public static bool IACFHCLLABN<TOk, TErr>([In] this PGLGENBDGKP<TOk, TErr> HFLBADIEKAM, [Out][NotNullWhen(true)] TOk EKPEOGILMIH, [Out][NotNullWhen(false)] TErr LDEICBENOHG) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2986490", Offset = "0x2985490", VA = "0x182986490")]
	public static bool PIFOHFHBEKF<TOk, TErr>([In] this PGLGENBDGKP<TOk, TErr> HFLBADIEKAM, [Out][NotNullWhen(true)] TOk EKPEOGILMIH, [Out] PGLGENBDGKP<TOk, TErr> IFNBGFOIMGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2985550", Offset = "0x2984550", VA = "0x182985550")]
	public static bool PBKIPDAKJMP<TOk, TErr, UErr, UOk>([In] this PGLGENBDGKP<TOk, TErr> HFLBADIEKAM, [Out][NotNullWhen(true)] TOk EKPEOGILMIH, [Out] PGLGENBDGKP<UOk, UErr> IFNBGFOIMGL) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2984890", Offset = "0x2983890", VA = "0x182984890")]
	public static bool MJLLHECFNJD<TOk, TErr>([In] this PGLGENBDGKP<TOk, TErr> HFLBADIEKAM, [Out][NotNullWhen(true)] TOk EKPEOGILMIH, [Out] PGLGENBDGKP<KLKJPNNICPF, TErr> IFNBGFOIMGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x29837A0", Offset = "0x29827A0", VA = "0x1829837A0")]
	public static PGLGENBDGKP<UOk, UErr> BENLKNOAEEJ<UOk, UErr, TOk, TErr>([In] this PGLGENBDGKP<TOk, TErr> HFLBADIEKAM, [In] PGLGENBDGKP<UOk, UErr> GEJMEMCGHEN) where TOk : UOk where TErr : UErr
	{
		return default(PGLGENBDGKP<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2984480", Offset = "0x2983480", VA = "0x182984480")]
	public static PGLGENBDGKP<TOk?[]?, TErr?> LPGNDCPOFOL<TOk, TErr>(this IEnumerable<PGLGENBDGKP<TOk, TErr>> HFLBADIEKAM)
	{
		return default(PGLGENBDGKP<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class MHEPDLODDCA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x27EE160", Offset = "0x27ED160", VA = "0x1827EE160")]
	public static PGLGENBDGKP<TOk, T> JNINOENKHDJ<TOk>([In] TOk EKPEOGILMIH) where TOk : notnull
	{
		return default(PGLGENBDGKP<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4034120", Offset = "0x4033120", VA = "0x184034120")]
	public static PGLGENBDGKP<KLKJPNNICPF, T> JNINOENKHDJ()
	{
		return default(PGLGENBDGKP<KLKJPNNICPF, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x27EE0E0", Offset = "0x27ED0E0", VA = "0x1827EE0E0")]
	public static PGLGENBDGKP<T, TErr> DCEJHCAOBHL<TErr>([In] TErr LDEICBENOHG) where TErr : notnull
	{
		return default(PGLGENBDGKP<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public sealed class ABOPGOPGKMN<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private readonly struct KDHLKPNGNGD : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly ABOPGOPGKMN<T> BIHKANIIDAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly int BHKMJIFCBNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly bool HPFFDBJJPOP;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1D46630", Offset = "0x1D45630", VA = "0x181D46630")]
		public KDHLKPNGNGD(ABOPGOPGKMN<T> OFFMGNOKEOO, int PKJMGHGANFH, bool KNBKAHKENAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3D61710", Offset = "0x3D60710", VA = "0x183D61710")]
		public ABOPGOPGKMN<T>.LNLHAPHJPNA IEKFBOGGJFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3D61800", Offset = "0x3D60800", VA = "0x183D61800", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3D61800", Offset = "0x3D60800", VA = "0x183D61800", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class LNLHAPHJPNA : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly ABOPGOPGKMN<T> BIHKANIIDAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly int IMNEPPMAEDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int GGKMDJIPGHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly bool HPFFDBJJPOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private bool BNHAFGNKIAE;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T DGGBFKFKJBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x3E54C50", Offset = "0x3E53C50", VA = "0x183E54C50")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x3E54D80", Offset = "0x3E53D80", VA = "0x183E54D80", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x3E54E60", Offset = "0x3E53E60", VA = "0x183E54E60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3E55250", Offset = "0x3E54250", VA = "0x183E55250")]
		public LNLHAPHJPNA(ABOPGOPGKMN<T> OFFMGNOKEOO, int PKJMGHGANFH, bool KNBKAHKENAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3E54C90", Offset = "0x3E53C90", VA = "0x183E54C90", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x3E54D20", Offset = "0x3E53D20", VA = "0x183E54D20", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class GLNDLCLDLMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public GLNDLCLDLMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x39BD260", Offset = "0x39BC260", VA = "0x1839BD260")]
		internal T EECIPEGFNGI(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly T[] KGNPBHOJHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int GGKMDJIPGHP;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int HDGKOKMNBFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3948940", Offset = "0x3947940", VA = "0x183948940")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T DGGBFKFKJBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x38720F0", Offset = "0x38710F0", VA = "0x1838720F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T IINBOPDCMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3948910", Offset = "0x3947910", VA = "0x183948910")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T EAGDGAFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3948BB0", Offset = "0x3947BB0", VA = "0x183948BB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int GBPKIPDCGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x173EAF0", Offset = "0x173DAF0", VA = "0x18173EAF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xFEDFB0", Offset = "0xFECFB0", VA = "0x180FEDFB0")]
	private static int DIPEJLFDPHF(int GPEHCABDGEJ, int GOKGFKKLOOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3948C60", Offset = "0x3947C60", VA = "0x183948C60")]
	public ABOPGOPGKMN(int GFFAGBDKDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3948CD0", Offset = "0x3947CD0", VA = "0x183948CD0")]
	public ABOPGOPGKMN(int GFFAGBDKDAI, Func<T> JDHMFAOLIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3949030", Offset = "0x3948030", VA = "0x183949030")]
	public ABOPGOPGKMN(T[] DCGPAEFOGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3948AE0", Offset = "0x3947AE0", VA = "0x183948AE0")]
	public void JNBDBMPNNII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3948990", Offset = "0x3947990", VA = "0x183948990")]
	public IEnumerable<T> FCANHPBDDGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3948A50", Offset = "0x3947A50", VA = "0x183948A50")]
	public ABOPGOPGKMN<T>.LNLHAPHJPNA IEKFBOGGJFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x392AE40", Offset = "0x3929E40", VA = "0x18392AE40", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x392AE40", Offset = "0x3929E40", VA = "0x18392AE40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class DIPOIIHONBP
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2743EA0", Offset = "0x2742EA0", VA = "0x182743EA0")]
	public static ABOPGOPGKMN<T> MGIIAIMPALM<T>(int GFFAGBDKDAI, Func<T> JDHMFAOLIBJ) where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x1E35C20", Offset = "0x1E34C20", VA = "0x181E35C20")]
		public RRColor(float HOBDDCFEELG, float DJEHEMEHOBH, float ABLGCHAEIGE, float AAOIMEIMECG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x636A450", Offset = "0x6369450", VA = "0x18636A450", Slot = "4")]
		public bool Equals(RRColor JNHFAFOIKEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x636A4D0", Offset = "0x63694D0", VA = "0x18636A4D0", Slot = "0")]
		public override bool Equals(object JNHFAFOIKEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x636A5D0", Offset = "0x63695D0", VA = "0x18636A5D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x636A650", Offset = "0x6369650", VA = "0x18636A650", Slot = "5")]
		public string ToString(string GCJDIJFGBBE, IFormatProvider NHFFBKFDILO)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class CFLBPEGDJCK<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public readonly struct KONEJIDOKNO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly CFLBPEGDJCK<T> PHICGEGJKHD;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public T DMDNAKDAMMG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x3DA3420", Offset = "0x3DA2420", VA = "0x183DA3420")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3DA33F0", Offset = "0x3DA23F0", VA = "0x183DA33F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x94ABA0", Offset = "0x949BA0", VA = "0x18094ABA0")]
		public KONEJIDOKNO(CFLBPEGDJCK<T> PHICGEGJKHD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct DIIKKIAPOHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<KONEJIDOKNO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public CFLBPEGDJCK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x51FB110", Offset = "0x51FA110", VA = "0x1851FB110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x328F640", Offset = "0x328E640", VA = "0x18328F640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly SemaphoreSlim MILIOCBKIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T JLNHCAFDNEE;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4BE88B0", Offset = "0x4BE78B0", VA = "0x184BE88B0")]
	public CFLBPEGDJCK([In] T JLNHCAFDNEE, int DDPOOFLPANF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4BE8890", Offset = "0x4BE7890", VA = "0x184BE8890")]
	public CFLBPEGDJCK([In] T JLNHCAFDNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4BE81C0", Offset = "0x4BE71C0", VA = "0x184BE81C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4BE8180", Offset = "0x4BE7180", VA = "0x184BE8180")]
	public KONEJIDOKNO BDIOEAEDIDP()
	{
		return default(KONEJIDOKNO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4BE8200", Offset = "0x4BE7200", VA = "0x184BE8200")]
	[AsyncStateMachine(typeof(CFLBPEGDJCK<>.DIIKKIAPOHM))]
	public Task<CFLBPEGDJCK<T>.KONEJIDOKNO> HOAEHNBBMIN(CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4BE8680", Offset = "0x4BE7680", VA = "0x184BE8680")]
	public void MELAHDCDJJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class EGDDGHEDAPI
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6367CB0", Offset = "0x6366CB0", VA = "0x186367CB0")]
	public static CFLBPEGDJCK<KLKJPNNICPF> MGIIAIMPALM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2774FA0", Offset = "0x2773FA0", VA = "0x182774FA0")]
	public static CFLBPEGDJCK<T> MGIIAIMPALM<T>([In] T JLNHCAFDNEE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class OAAJCAIIFEB<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct CGIGMEEIMGI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly OAAJCAIIFEB<T> BCGFBNIFFOL;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T DMDNAKDAMMG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x40B9120", Offset = "0x40B8120", VA = "0x1840B9120")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4CA9680", Offset = "0x4CA8680", VA = "0x184CA9680", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x94ABA0", Offset = "0x949BA0", VA = "0x18094ABA0")]
		internal CGIGMEEIMGI(OAAJCAIIFEB<T> PHICGEGJKHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct NFOAMBGFALD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly OAAJCAIIFEB<T> BCGFBNIFFOL;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T DMDNAKDAMMG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x40B9120", Offset = "0x40B8120", VA = "0x1840B9120")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x40B9030", Offset = "0x40B8030", VA = "0x1840B9030", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x94ABA0", Offset = "0x949BA0", VA = "0x18094ABA0")]
		internal NFOAMBGFALD(OAAJCAIIFEB<T> PHICGEGJKHD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct PLKKNEHIBJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder<NFOAMBGFALD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public OAAJCAIIFEB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private CFLBPEGDJCK<KLKJPNNICPF>.KONEJIDOKNO <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter<CFLBPEGDJCK<KLKJPNNICPF>.KONEJIDOKNO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4296A80", Offset = "0x4295A80", VA = "0x184296A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x328F640", Offset = "0x328E640", VA = "0x18328F640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CFLBPEGDJCK<int> FCNCKCPFADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly CFLBPEGDJCK<KLKJPNNICPF> NFLHPGICLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly CFLBPEGDJCK<KLKJPNNICPF> IEPBLHBGDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private T EFNFMAPANDN;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4176800", Offset = "0x4175800", VA = "0x184176800")]
	internal OAAJCAIIFEB(CFLBPEGDJCK<int> ILJJFOCBFKD, CFLBPEGDJCK<KLKJPNNICPF> JDFBLMNLKJO, CFLBPEGDJCK<KLKJPNNICPF> GLFIDJIBMPL, [In] T JLNHCAFDNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x41764B0", Offset = "0x41754B0", VA = "0x1841764B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4175AE0", Offset = "0x4174AE0", VA = "0x184175AE0")]
	public CGIGMEEIMGI CDGJENMFNJM()
	{
		return default(CGIGMEEIMGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4176530", Offset = "0x4175530", VA = "0x184176530")]
	public NFOAMBGFALD JBODEMHGHEN()
	{
		return default(NFOAMBGFALD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4176280", Offset = "0x4175280", VA = "0x184176280")]
	[AsyncStateMachine(typeof(OAAJCAIIFEB<>.PLKKNEHIBJD))]
	public Task<OAAJCAIIFEB<T>.NFOAMBGFALD> DPJNAACEIHF(CancellationToken GHLJDIEPICD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class IHEEGIKDPMF
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x63691B0", Offset = "0x63681B0", VA = "0x1863691B0")]
	public static OAAJCAIIFEB<KLKJPNNICPF> MGIIAIMPALM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x28FF870", Offset = "0x28FE870", VA = "0x1828FF870")]
	public static OAAJCAIIFEB<T> MGIIAIMPALM<T>([In] T JLNHCAFDNEE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class BFODJLCDNNC<TData> : HBNEILLBGHD where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly string LLOICNKPPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly TData IKNEHLGBAHD;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "7")]
	public override string MGJEJBNDCKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x48F5600", Offset = "0x48F4600", VA = "0x1848F5600")]
	internal BFODJLCDNNC(string JJJNODJJIFK, [In] TData GPKMLHOONCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class FCDGCJJIJOP
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6367D20", Offset = "0x6366D20", VA = "0x186367D20")]
	public static BFODJLCDNNC<KLKJPNNICPF> MGIIAIMPALM(string JJJNODJJIFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2717F40", Offset = "0x2716F40", VA = "0x182717F40")]
	public static BFODJLCDNNC<TData> MGIIAIMPALM<TData>(string JJJNODJJIFK, [In] TData GPKMLHOONCL) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class FCLONPBDDAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly Dictionary<object, float> AMCBEDPOHMD;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float JMAAKMEONBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9471F0", Offset = "0x9461F0", VA = "0x1809471F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x947290", Offset = "0x946290", VA = "0x180947290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6367F40", Offset = "0x6366F40", VA = "0x186367F40")]
	public void MKPEGPHPFHD(float LDGMLLMKHLF, object KONODCHOCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6367ED0", Offset = "0x6366ED0", VA = "0x186367ED0")]
	public void DBJOBDAELPE(object KONODCHOCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6367DA0", Offset = "0x6366DA0", VA = "0x186367DA0")]
	private void ALLGDKBALFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6367FB0", Offset = "0x6366FB0", VA = "0x186367FB0")]
	public FCLONPBDDAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class OKIOPNEJKGE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class ECLFPJBHCBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public ECLFPJBHCBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x34E3A50", Offset = "0x34E2A50", VA = "0x1834E3A50")]
		internal int AHCEKDLMADO(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private HashSet<T>? LBKFCOMLMHO;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<T> GKMCCOKLDII
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x41E4AD0", Offset = "0x41E3AD0", VA = "0x1841E4AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool PONJCDMLDMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x41E4B00", Offset = "0x41E3B00", VA = "0x1841E4B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int JFLFCJGPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7C5830", Offset = "0x7C4830", VA = "0x1807C5830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7C5850", Offset = "0x7C4850", VA = "0x1807C5850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x41E4960", Offset = "0x41E3960", VA = "0x1841E4960")]
	public bool BGLDHBEBEIE(T KONODCHOCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x41E4B80", Offset = "0x41E3B80", VA = "0x1841E4B80")]
	public bool NCLCGNJGAKA(T KONODCHOCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x41E4B40", Offset = "0x41E3B40", VA = "0x1841E4B40")]
	public bool LFLBPCGHIFM(T KONODCHOCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x41E4CA0", Offset = "0x41E3CA0", VA = "0x1841E4CA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public OKIOPNEJKGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class PIOKGJKNCFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly string FPPOJEAMDDK;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C50", Offset = "0x7C8C50", VA = "0x1807C9C50")]
	public PIOKGJKNCFA(string FPPOJEAMDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x636A400", Offset = "0x6369400", VA = "0x18636A400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class EEABDCAPAGK
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class LCJECFIHINL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public LCJECFIHINL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6369560", Offset = "0x6368560", VA = "0x186369560")]
		internal int AHCEKDLMADO(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private HashSet<object>? LBKFCOMLMHO;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IReadOnlyCollection<object> GKMCCOKLDII
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6367960", Offset = "0x6366960", VA = "0x186367960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool PONJCDMLDMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x63679F0", Offset = "0x63669F0", VA = "0x1863679F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int JFLFCJGPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C5830", Offset = "0x7C4830", VA = "0x1807C5830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7C5850", Offset = "0x7C4850", VA = "0x1807C5850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6367880", Offset = "0x6366880", VA = "0x186367880")]
	public bool BGLDHBEBEIE(object KONODCHOCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6367A60", Offset = "0x6366A60", VA = "0x186367A60")]
	public bool NCLCGNJGAKA(object KONODCHOCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6367A00", Offset = "0x6366A00", VA = "0x186367A00")]
	public bool LFLBPCGHIFM(object KONODCHOCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6367810", Offset = "0x6366810", VA = "0x186367810")]
	public void AGFILCCOPAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6367B00", Offset = "0x6366B00", VA = "0x186367B00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public EEABDCAPAGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class GFHPGBHCKKB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private struct OKEJDAMMDON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float AHGFBGLJHGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public T DMDNAKDAMMG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Dictionary<object, OKEJDAMMDON> AMCBEDPOHMD;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public virtual T IDNKINKNNOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xF223A0", Offset = "0xF213A0", VA = "0x180F223A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xF21970", Offset = "0xF20970", VA = "0x180F21970", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public object? KAINNMABIAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7C5860", Offset = "0x7C4860", VA = "0x1807C5860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7C5840", Offset = "0x7C4840", VA = "0x1807C5840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool JOEGNPKCEFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x399E2F0", Offset = "0x399D2F0", VA = "0x18399E2F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x399E640", Offset = "0x399D640", VA = "0x18399E640")]
	public bool MKPEGPHPFHD(T LDGMLLMKHLF, object KONODCHOCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x399DEC0", Offset = "0x399CEC0", VA = "0x18399DEC0")]
	public bool DBJOBDAELPE(object KONODCHOCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x399E2C0", Offset = "0x399D2C0", VA = "0x18399E2C0")]
	public void HCLIMFMHPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x399E220", Offset = "0x399D220", VA = "0x18399E220")]
	public bool DKPMPOAPJNG(object KONODCHOCOG, [Out] T LDGMLLMKHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x399EE60", Offset = "0x399DE60", VA = "0x18399EE60")]
	[MPBPOPFFKPJ("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool MPBEPHKHBNP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x39A0140", Offset = "0x399F140", VA = "0x1839A0140")]
	public GFHPGBHCKKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface DBEEHEKLCBO
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event LLFLHEDIPMN BLGPCMFEJPM;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class HDMJGNJENFH : DBEEHEKLCBO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public readonly struct JLNGPPFMIAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public readonly float MLLCENNIMJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public readonly float FKKJHBGFFND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		internal readonly bool JAKHALGPHHN;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float BMODBHJLIOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x6369280", Offset = "0x6368280", VA = "0x186369280")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6369400", Offset = "0x6368400", VA = "0x186369400")]
		public JLNGPPFMIAN(float GGOAAGPAMNC, float FPNFHKNNNHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6369290", Offset = "0x6368290", VA = "0x186369290", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class DIEJHJLAFGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public HDMJGNJENFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public DIEJHJLAFGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6367770", Offset = "0x6366770", VA = "0x186367770")]
		internal void JNBAPKCPJIK(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly int AFDLPCPCHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int HJDGOLFCAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly DBEEHEKLCBO[] CJPIIIFDCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly LLFLHEDIPMN[] AKJKFGAFELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly JLNGPPFMIAN[] INGINKEPAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private JLNGPPFMIAN EBBGAHBPKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly BEIPFBBPOOO JLCCLCPLGHI;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event LLFLHEDIPMN BLGPCMFEJPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6368990", Offset = "0x6367990", VA = "0x186368990", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6368AE0", Offset = "0x6367AE0", VA = "0x186368AE0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6369020", Offset = "0x6368020", VA = "0x186369020")]
	public HDMJGNJENFH(int AFDLPCPCHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6368A50", Offset = "0x6367A50", VA = "0x186368A50")]
	public BEIPFBBPOOO IEEECPJDNCB(JLNGPPFMIAN NLMFOKILPIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6368BA0", Offset = "0x6367BA0", VA = "0x186368BA0")]
	public void OABGJPDCIOC(DBEEHEKLCBO PGGAAMHNDHI, [Optional] JLNGPPFMIAN JDBMJDMMHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6368880", Offset = "0x6367880", VA = "0x186368880", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public delegate void LLFLHEDIPMN(float GPCKHFHOCME);
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class PGOIJFIJNIG
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private class GOBALKLIMEA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly DBEEHEKLCBO NGCOAGNEANL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly LLFLHEDIPMN HLFIKKGGCCK;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x63680D0", Offset = "0x63670D0", VA = "0x1863680D0")]
		public GOBALKLIMEA(DBEEHEKLCBO NGCOAGNEANL, LLFLHEDIPMN HLFIKKGGCCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6368080", Offset = "0x6367080", VA = "0x186368080", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x636A2D0", Offset = "0x63692D0", VA = "0x18636A2D0")]
	internal static bool ICDBHMPJPPJ(float AAOIMEIMECG, float ABLGCHAEIGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6359FC0", Offset = "0x6358FC0", VA = "0x186359FC0")]
	internal static float GEHIHIGCFIP(float AAOIMEIMECG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x636A340", Offset = "0x6369340", VA = "0x18636A340")]
	public static IDisposable ICLFDLLPOEN(this DBEEHEKLCBO NGCOAGNEANL, LLFLHEDIPMN HLFIKKGGCCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class BEIPFBBPOOO : DBEEHEKLCBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float GPCKHFHOCME;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float CENFLAEBBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x63674E0", Offset = "0x63664E0", VA = "0x1863674E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event LLFLHEDIPMN? BLGPCMFEJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x63675D0", Offset = "0x63665D0", VA = "0x1863675D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6367670", Offset = "0x6366670", VA = "0x186367670", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public BEIPFBBPOOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class IFJGCIDKDNE : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5E36E00", Offset = "0x5E35E00", VA = "0x185E36E00")]
	public IFJGCIDKDNE(string JJJNODJJIFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[DefaultMember("Item")]
public class PMLPANBALEE<TKey, TValue> : EIMBLJNKILL<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, DIOKEGFIHCK where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class HBPJCDHAFKK : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public PMLPANBALEE<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xF223A0", Offset = "0xF213A0", VA = "0x180F223A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A04010", Offset = "0x3A03010", VA = "0x183A04010", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C1AC0", VA = "0x1807C2AC0")]
		[DebuggerHidden]
		public HBPJCDHAFKK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x37E17B0", Offset = "0x37E07B0", VA = "0x1837E17B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x3A03790", Offset = "0x3A02790", VA = "0x183A03790", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3A03340", Offset = "0x3A02340", VA = "0x183A03340")]
		private void HPAIKACEAJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3A032A0", Offset = "0x3A022A0", VA = "0x183A032A0")]
		private void DGKIMGJJCCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3A03F70", Offset = "0x3A02F70", VA = "0x183A03F70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly EIMBLJNKILL<TKey, TValue> PMFLGLOFKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly IDictionary<TKey, TValue> CDLBKNGKJPJ;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int JFLFCJGPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x429A770", Offset = "0x4299770", VA = "0x18429A770", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool CNGKFBOLNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public TValue EAGDGAFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x429A870", Offset = "0x4299870", VA = "0x18429A870", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x429AAD0", Offset = "0x4299AD0", VA = "0x18429AAD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public ICollection<TKey> DKCBCEDMAAI
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x429A8B0", Offset = "0x42998B0", VA = "0x18429A8B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public ICollection<TValue> DIPPIPHGCOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x429A9C0", Offset = "0x42999C0", VA = "0x18429A9C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x429A520", Offset = "0x4299520", VA = "0x18429A520")]
	public PMLPANBALEE(EIMBLJNKILL<TKey, TValue> PMFLGLOFKNN, [Optional] IDictionary<TKey, TValue>? CDLBKNGKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x4297DC0", Offset = "0x4296DC0", VA = "0x184297DC0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4299750", Offset = "0x4298750", VA = "0x184299750")]
	public void ODOFMAMHMGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x4297900", Offset = "0x4296900", VA = "0x184297900", Slot = "9")]
	public void Add(TKey OHNEPKBBADL, TValue LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x42994D0", Offset = "0x42984D0", VA = "0x1842994D0")]
	public void NLAECGIGPCJ(TKey OHNEPKBBADL, TValue LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x4298740", Offset = "0x4297740", VA = "0x184298740")]
	public void DGMJPHNDALN(TKey OHNEPKBBADL, TValue LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x4299160", Offset = "0x4298160", VA = "0x184299160")]
	public void NKONKDFGHGG(TKey OHNEPKBBADL, TValue LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x4298CC0", Offset = "0x4297CC0", VA = "0x184298CC0")]
	public void KMJKJOLIJKA(TKey OHNEPKBBADL, TValue LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x4299B40", Offset = "0x4298B40", VA = "0x184299B40", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> LLMAIFIKIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x4299D40", Offset = "0x4298D40", VA = "0x184299D40", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> LLMAIFIKIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x429A0A0", Offset = "0x42990A0", VA = "0x18429A0A0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> LLMAIFIKIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4297ED0", Offset = "0x4296ED0", VA = "0x184297ED0", Slot = "8")]
	public bool ContainsKey(TKey OHNEPKBBADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x42997A0", Offset = "0x42987A0", VA = "0x1842997A0")]
	public bool PJEIPBLGNEI(TKey OHNEPKBBADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4298B60", Offset = "0x4297B60", VA = "0x184298B60")]
	public bool KGNALLCAIBJ(TKey OHNEPKBBADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x42998D0", Offset = "0x42988D0", VA = "0x1842998D0", Slot = "10")]
	public bool Remove(TKey OHNEPKBBADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x429A370", Offset = "0x4299370", VA = "0x18429A370", Slot = "11")]
	public bool TryGetValue(TKey OHNEPKBBADL, [Out] TValue LDGMLLMKHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4298420", Offset = "0x4297420", VA = "0x184298420", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] PAFIMPMPKHD, int PKIBMLHJLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x429A260", Offset = "0x4299260", VA = "0x18429A260", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x42988F0", Offset = "0x42978F0", VA = "0x1842988F0", Slot = "19")]
	[IteratorStateMachine(typeof(PMLPANBALEE<, >.HBPJCDHAFKK))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4298A60", Offset = "0x4297A60", VA = "0x184298A60", Slot = "21")]
	public bool IFMPLKDHCNP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4298D60", Offset = "0x4297D60", VA = "0x184298D60")]
	private TValue NBIHKEDJLDI(TKey OHNEPKBBADL)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface DIOKEGFIHCK
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IFMPLKDHCNP();
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface EIMBLJNKILL<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, DIOKEGFIHCK
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DefaultMember("Item")]
public sealed class EAOCBIJBBIG<TKey, TVal> : EIMBLJNKILL<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, DIOKEGFIHCK where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public delegate int CHJFHDMLHJP(TKey OHNEPKBBADL, TVal LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public delegate void BDOOEDFDCFK(TKey OHNEPKBBADL, TVal LDGMLLMKHLF, LILFJBGIPJG KDLIPBNGNPF);

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class BAMEKDCCJJL
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public TKey KFDLNEFCHIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x85B1E0", Offset = "0x85A1E0", VA = "0x18085B1E0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public TVal DMDNAKDAMMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x96ECB0", Offset = "0x96DCB0", VA = "0x18096ECB0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x96ECA0", Offset = "0x96DCA0", VA = "0x18096ECA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int BMODBHJLIOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x7FFEA0", Offset = "0x7FEEA0", VA = "0x1807FFEA0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x7FFB10", Offset = "0x7FEB10", VA = "0x1807FFB10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public DateTimeOffset LJMKJCBEHAB
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0xAE6B20", Offset = "0xAE5B20", VA = "0x180AE6B20")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x137B740", Offset = "0x137A740", VA = "0x18137B740")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x48DACE0", Offset = "0x48D9CE0", VA = "0x1848DACE0")]
		public BAMEKDCCJJL(TKey OHNEPKBBADL, TVal PAFHPJKJPEL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class GJPMIDJHKDM : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public EAOCBIJBBIG<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private LinkedList<BAMEKDCCJJL>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xF223A0", Offset = "0xF213A0", VA = "0x180F223A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x37E4BF0", Offset = "0x37E3BF0", VA = "0x1837E4BF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C1AC0", VA = "0x1807C2AC0")]
		[DebuggerHidden]
		public GJPMIDJHKDM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x368B020", Offset = "0x368A020", VA = "0x18368B020", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x39B1E30", Offset = "0x39B0E30", VA = "0x1839B1E30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x39B1190", Offset = "0x39B0190", VA = "0x1839B1190")]
		private void HPAIKACEAJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x39B3BA0", Offset = "0x39B2BA0", VA = "0x1839B3BA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const int DKMNKADKINH = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<TKey, LinkedListNode<BAMEKDCCJJL>> JOAFEKPEMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly LinkedList<BAMEKDCCJJL> BGMKFMONBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly CHJFHDMLHJP? JFDECDJNIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly TimeSpan MIBPLLMHCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly BDOOEDFDCFK? BNNDPAIMEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly PHHLODGHAPM EOFLODGPPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool OMLICMCNIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly List<TKey> KIKCOAEGIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly List<TVal> CMDPMKMAIEE;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int DFONNJMCPIL
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7D00D0", Offset = "0x7CF0D0", VA = "0x1807D00D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	internal int FNCMMEDCBLH
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9CAFA0", Offset = "0x9C9FA0", VA = "0x1809CAFA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9CAAD0", Offset = "0x9C9AD0", VA = "0x1809CAAD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int JFLFCJGPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x34B5860", Offset = "0x34B4860", VA = "0x1834B5860", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	internal int BGELJKEPEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x34AE4E0", Offset = "0x34AD4E0", VA = "0x1834AE4E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public ICollection<TVal> DIPPIPHGCOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x34B5960", Offset = "0x34B4960", VA = "0x1834B5960", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	ICollection<TKey> IDictionary<TKey, TVal>.HHPPCDIJGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x34B4390", Offset = "0x34B3390", VA = "0x1834B4390", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool CNGKFBOLNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public TVal EAGDGAFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x34B58C0", Offset = "0x34B48C0", VA = "0x1834B58C0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x34B5990", Offset = "0x34B4990", VA = "0x1834B5990", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x34B2E00", Offset = "0x34B1E00", VA = "0x1834B2E00")]
	private bool OOJIOJFCIKN(int AFDLPCPCHIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x34B0CC0", Offset = "0x34AFCC0", VA = "0x1834B0CC0")]
	private void DLLHGKBGPOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x34B4E00", Offset = "0x34B3E00", VA = "0x1834B4E00")]
	public EAOCBIJBBIG(int AFDLPCPCHIJ, [Optional] CHJFHDMLHJP? JFDECDJNIMA, [Optional] IEqualityComparer<TKey>? BDMBCFNHNFA, [Optional] BDOOEDFDCFK? BNNDPAIMEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x34B4DB0", Offset = "0x34B3DB0", VA = "0x1834B4DB0")]
	public EAOCBIJBBIG(TimeSpan MIBPLLMHCPK, [Optional] IEqualityComparer<TKey>? BDMBCFNHNFA, [Optional] BDOOEDFDCFK? BNNDPAIMEHC, [Optional] PHHLODGHAPM? EOFLODGPPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x34B4950", Offset = "0x34B3950", VA = "0x1834B4950")]
	public EAOCBIJBBIG(int AFDLPCPCHIJ, TimeSpan MIBPLLMHCPK, [Optional] IEqualityComparer<TKey>? BDMBCFNHNFA, [Optional] BDOOEDFDCFK? BNNDPAIMEHC, [Optional] PHHLODGHAPM? EOFLODGPPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x34B4EC0", Offset = "0x34B3EC0", VA = "0x1834B4EC0")]
	public EAOCBIJBBIG(int AFDLPCPCHIJ, CHJFHDMLHJP? JFDECDJNIMA, TimeSpan MIBPLLMHCPK, [Optional] IEqualityComparer<TKey>? BDMBCFNHNFA, [Optional] BDOOEDFDCFK? BNNDPAIMEHC, [Optional] PHHLODGHAPM? EOFLODGPPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x34B1BA0", Offset = "0x34B0BA0", VA = "0x1834B1BA0", Slot = "21")]
	public bool IFMPLKDHCNP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x34B1630", Offset = "0x34B0630", VA = "0x1834B1630", Slot = "22")]
	public bool EKLBBOFEFEN(int GFFAGBDKDAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x34AEBE0", Offset = "0x34ADBE0", VA = "0x1834AEBE0")]
	private bool ALDAIABALJL(int GFFAGBDKDAI, LILFJBGIPJG KDLIPBNGNPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x34B3040", Offset = "0x34B2040", VA = "0x1834B3040")]
	public void PGLEONAELKI(TKey OHNEPKBBADL, TVal LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x34AFC90", Offset = "0x34AEC90", VA = "0x1834AFC90", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> LLMAIFIKIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x34AFE70", Offset = "0x34AEE70", VA = "0x1834AFE70", Slot = "9")]
	public void Add(TKey OHNEPKBBADL, TVal LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x34B01C0", Offset = "0x34AF1C0", VA = "0x1834B01C0", Slot = "8")]
	public bool ContainsKey(TKey OHNEPKBBADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x34B4050", Offset = "0x34B3050", VA = "0x1834B4050", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> LLMAIFIKIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x34B3CE0", Offset = "0x34B2CE0", VA = "0x1834B3CE0", Slot = "10")]
	public bool Remove(TKey OHNEPKBBADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x34B4260", Offset = "0x34B3260", VA = "0x1834B4260", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> LLMAIFIKIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x34AE9B0", Offset = "0x34AD9B0", VA = "0x1834AE9B0")]
	private bool AAMKDMIEKPG(TKey OHNEPKBBADL, [Out] TVal LDGMLLMKHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x34B1890", Offset = "0x34B0890", VA = "0x1834B1890")]
	private TVal HBEPMKJLJFA(TKey IMFAKCHHMPL)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x34B43F0", Offset = "0x34B33F0", VA = "0x1834B43F0", Slot = "11")]
	public bool TryGetValue(TKey IMFAKCHHMPL, [Out] TVal LDGMLLMKHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x34B0110", Offset = "0x34AF110", VA = "0x1834B0110", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x34B02C0", Offset = "0x34AF2C0", VA = "0x1834B02C0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] PAFIMPMPKHD, int PKIBMLHJLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x34B2CC0", Offset = "0x34B1CC0", VA = "0x1834B2CC0")]
	private void NHMEOBHLLIJ(TKey OHNEPKBBADL, TVal PAFHPJKJPEL, LILFJBGIPJG KDLIPBNGNPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x34B1410", Offset = "0x34B0410", VA = "0x1834B1410")]
	private bool EAGKCDCILIN(BAMEKDCCJJL NJIJEPPEMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x34B34D0", Offset = "0x34B24D0", VA = "0x1834B34D0")]
	private void PGLOEFIMFBP(LinkedListNode<BAMEKDCCJJL> EEJOOOBACMO, TVal HDNPJBAOJAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x34B1C10", Offset = "0x34B0C10", VA = "0x1834B1C10")]
	private void MKPEGPHPFHD(TKey OHNEPKBBADL, TVal LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x34B2660", Offset = "0x34B1660", VA = "0x1834B2660")]
	private void NCBFMBNBKDG(BAMEKDCCJJL NJIJEPPEMIN, TVal HDNPJBAOJAB, int KPCMEOJHBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x34B1770", Offset = "0x34B0770", VA = "0x1834B1770", Slot = "19")]
	[IteratorStateMachine(typeof(EAOCBIJBBIG<, >.GJPMIDJHKDM))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x34B43C0", Offset = "0x34B33C0", VA = "0x1834B43C0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public enum LILFJBGIPJG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	RemovedViaClear
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class BOELGPGFKOL<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly TKey JAOBAEIHFCL;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x4924F80", Offset = "0x4923F80", VA = "0x184924F80")]
	public BOELGPGFKOL(TKey MEMMBEEIFEA, Exception KKEANEMMJJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class BGIMFDOBFKC : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5727570", Offset = "0x5726570", VA = "0x185727570")]
	public BGIMFDOBFKC(string JJJNODJJIFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class JDGBBLNCKLH<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class KJGJOJGHLNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public JDGBBLNCKLH<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public KJGJOJGHLNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3D8CA40", Offset = "0x3D8BA40", VA = "0x183D8CA40")]
		internal Task<TResource> JMBJIFLKOCA(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct KCACEIILOEA : IAsyncStateMachine
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
		public JDGBBLNCKLH<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3D5B7D0", Offset = "0x3D5A7D0", VA = "0x183D5B7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3D5BB60", Offset = "0x3D5AB60", VA = "0x183D5BB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct IEPOBBAFLJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3AF1870", Offset = "0x3AF0870", VA = "0x183AF1870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3AF1B90", Offset = "0x3AF0B90", VA = "0x183AF1B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly EIMFAAOIDJN<TId, Task<TResource>> MICADBJILCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> NMFMBAAGDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? NEIHIJPNHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly Action<TResource>? NGJJHDJFJFJ;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3CC71F0", Offset = "0x3CC61F0", VA = "0x183CC71F0")]
	public JDGBBLNCKLH(int HAMFJGMCCNA = 0, [Optional] IEqualityComparer<TId>? KKLCOCACKME, [Optional] Func<TId, CancellationToken, Task<TResource>>? NLDGEALOEIC, [Optional] Action<TResource>? AKGDCIMECFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6330", Offset = "0x3CC5330", VA = "0x183CC6330")]
	public IDLDPOIKMNH<Task<TResource>> COHCDBGGCNH(TId JKEKANKKCCC, [Optional] Func<TId, CancellationToken, Task<TResource>>? NLDGEALOEIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6AD0", Offset = "0x3CC5AD0", VA = "0x183CC6AD0")]
	private void JMIGDEBPOAC(Task<TResource> BKJCIFOIBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6CF0", Offset = "0x3CC5CF0", VA = "0x183CC6CF0")]
	[AsyncStateMachine(typeof(JDGBBLNCKLH<, >.KCACEIILOEA))]
	private Task JOHEDKNFLMP(Task<TResource> BKJCIFOIBEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6FF0", Offset = "0x3CC5FF0", VA = "0x183CC6FF0")]
	public void KCMKJICGNGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6950", Offset = "0x3CC5950", VA = "0x183CC6950")]
	public EIMFAAOIDJN<TId, Task<TResource>>.JBHOLLDOOOL IEKFBOGGJFJ()
	{
		return default(EIMFAAOIDJN<TId, Task<TResource>>.JBHOLLDOOOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3CC70C0", Offset = "0x3CC60C0", VA = "0x183CC70C0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3CC70C0", Offset = "0x3CC60C0", VA = "0x183CC70C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3CC64E0", Offset = "0x3CC54E0", VA = "0x183CC64E0")]
	[AsyncStateMachine(typeof(JDGBBLNCKLH<, >.IEPOBBAFLJE))]
	[CompilerGenerated]
	internal static Task HOOEMELAOJK(Task<TResource> BKJCIFOIBEF, CancellationTokenSource EILJALFJLPN, Dictionary<Task<TResource>, CancellationTokenSource> DGJOLJDFNHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class EIMFAAOIDJN<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private sealed class FENPHGEGADC : IEquatable<FENPHGEGADC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TValue DMDNAKDAMMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int JEGHHLPINAP;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x1CFFB70", Offset = "0x1CFEB70", VA = "0x181CFFB70")]
		public FENPHGEGADC(TValue LDGMLLMKHLF, int FABJPMIGABI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3888EF0", Offset = "0x3887EF0", VA = "0x183888EF0", Slot = "4")]
		public bool Equals(FENPHGEGADC? JNHFAFOIKEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3888F80", Offset = "0x3887F80", VA = "0x183888F80", Slot = "0")]
		public override bool Equals(object? KDEEPMDJGFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3889140", Offset = "0x3888140", VA = "0x183889140", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct JBHOLLDOOOL : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private Dictionary<TKey, FENPHGEGADC>.Enumerator FDCEMPDAPGO;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x3CC4A00", Offset = "0x3CC3A00", VA = "0x183CC4A00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public (TKey Key, TValue Value, int RefCount) DGGBFKFKJBG
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x3CC5060", Offset = "0x3CC4060", VA = "0x183CC5060", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4CC0", Offset = "0x3CC3CC0", VA = "0x183CC4CC0")]
		public JBHOLLDOOOL(EIMFAAOIDJN<TKey, TValue> AMCBEDPOHMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3CC46F0", Offset = "0x3CC36F0", VA = "0x183CC46F0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4770", Offset = "0x3CC3770", VA = "0x183CC4770", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4950", Offset = "0x3CC3950", VA = "0x183CC4950", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class PAIMADJEGBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public EIMFAAOIDJN<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public FENPHGEGADC refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public PAIMADJEGBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x4273AB0", Offset = "0x4272AB0", VA = "0x184273AB0")]
		internal void JMBJIFLKOCA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<TKey, FENPHGEGADC> JHOFNLFJDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly Func<TKey, TValue>? IIHEHFPPGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly Action<TValue>? IJKEHJDPPLM;

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3512EB0", Offset = "0x3511EB0", VA = "0x183512EB0")]
	public EIMFAAOIDJN(int HAMFJGMCCNA = 0, [Optional] IEqualityComparer<TKey>? BDMBCFNHNFA, [Optional] Func<TKey, TValue>? GJDEBDKAPLN, [Optional] Action<TValue>? JPCCACCEKAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3511DB0", Offset = "0x3510DB0", VA = "0x183511DB0")]
	public IDLDPOIKMNH<TValue> COHCDBGGCNH(TKey OHNEPKBBADL, [Optional] Func<TKey, TValue>? DBMGBGLCDFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3512BE0", Offset = "0x3511BE0", VA = "0x183512BE0")]
	private void OMHEABKHJKG(TKey OHNEPKBBADL, FENPHGEGADC BNMDEMJFCNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x3512630", Offset = "0x3511630", VA = "0x183512630")]
	public void KCMKJICGNGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x35123C0", Offset = "0x35113C0", VA = "0x1835123C0")]
	public JBHOLLDOOOL IEKFBOGGJFJ()
	{
		return default(JBHOLLDOOOL);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3512CE0", Offset = "0x3511CE0", VA = "0x183512CE0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3512CE0", Offset = "0x3511CE0", VA = "0x183512CE0", Slot = "5")]
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
