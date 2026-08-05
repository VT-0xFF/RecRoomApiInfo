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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F2EBD0", Offset = "0x7F2D7D0", VA = "0x187F2EBD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA48850", Offset = "0xA47450", VA = "0x180A48850")]
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
		[Cpp2IlInjected.Address(RVA = "0xA48890", Offset = "0xA47490", VA = "0x180A48890")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class EICIDHPLHKB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	protected EICIDHPLHKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class GAFPOBLEMNJ<T> : EICIDHPLHKB
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct ABHHAKOOGBO
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum BMKNLJMKKOK
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
		public BMKNLJMKKOK OPOPAMPKKGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T IFDCDCHOGGB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int IJFDDOFGNBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool CGAEHOOOIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool KIDJPLHAOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? BIFEONIAJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<ABHHAKOOGBO>? CEHIFMGBMON;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GIGIBANFFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4CFB5B0", Offset = "0x4CFA1B0", VA = "0x184CFB5B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4CFBB40", Offset = "0x4CFA740", VA = "0x184CFBB40")]
	protected GAFPOBLEMNJ(bool KIDJPLHAOHG, bool CGAEHOOOIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4CFB600", Offset = "0x4CFA200", VA = "0x184CFB600")]
	protected bool NIDHLLMIJFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4CFB870", Offset = "0x4CFA470", VA = "0x184CFB870")]
	protected void NMMAMMPLIHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4CFB970", Offset = "0x4CFA570", VA = "0x184CFB970")]
	protected void OACALHGLFNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3D23320", Offset = "0x3D21F20", VA = "0x183D23320")]
	private static void CPPPHDFJLGL<U>(List<U>? DNNGKIFFAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4CFB6A0", Offset = "0x4CFA2A0", VA = "0x184CFB6A0", Slot = "4")]
	public void NKAMMCABBBC(T IFDCDCHOGGB, bool MDLAEMOMFBL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4CFB290", Offset = "0x4CF9E90", VA = "0x184CFB290", Slot = "5")]
	public void HMCNGGMNMHK(T IFDCDCHOGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4CFB440", Offset = "0x4CFA040", VA = "0x184CFB440")]
	public void ILJKHADAMOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class HBAAEHCBNNO : GAFPOBLEMNJ<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D950", Offset = "0x7F2C550", VA = "0x187F2D950")]
	public HBAAEHCBNNO(bool KIDJPLHAOHG = false, bool CGAEHOOOIAO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D750", Offset = "0x7F2C350", VA = "0x187F2D750")]
	public void JMCDHFFLEOJ()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D690", Offset = "0x7F2C290", VA = "0x187F2D690")]
	public static HBAAEHCBNNO EEHLCDOICDL(HBAAEHCBNNO GDOBEPMOGAK, Action IFDCDCHOGGB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D6F0", Offset = "0x7F2C2F0", VA = "0x187F2D6F0")]
	public static HBAAEHCBNNO HJGKBAEELNB(HBAAEHCBNNO GDOBEPMOGAK, Action IFDCDCHOGGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AMACGKOIIHA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NKAMMCABBBC(Action<T> IFDCDCHOGGB, bool MDLAEMOMFBL = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMCNGGMNMHK(Action<T> IFDCDCHOGGB);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class PJAJEBBNNBK<T> : GAFPOBLEMNJ<Action<T>>, AMACGKOIIHA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x474F580", Offset = "0x474E180", VA = "0x18474F580")]
	public PJAJEBBNNBK(bool KIDJPLHAOHG = false, bool CGAEHOOOIAO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x57D5130", Offset = "0x57D3D30", VA = "0x1857D5130")]
	public void JMCDHFFLEOJ(T LPCHKKFEGJO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x50FD190", Offset = "0x50FBD90", VA = "0x1850FD190")]
	public static PJAJEBBNNBK<T> EEHLCDOICDL(PJAJEBBNNBK<T> GDOBEPMOGAK, Action<T> IFDCDCHOGGB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x50FD220", Offset = "0x50FBE20", VA = "0x1850FD220")]
	public static PJAJEBBNNBK<T> HJGKBAEELNB(PJAJEBBNNBK<T> GDOBEPMOGAK, Action<T> IFDCDCHOGGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JAJMDJOHNPD<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NKAMMCABBBC(Action<T, U> IFDCDCHOGGB, bool MDLAEMOMFBL = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMCNGGMNMHK(Action<T, U> IFDCDCHOGGB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class BICCMPNJHAK<T, U> : GAFPOBLEMNJ<Action<T, U>>, JAJMDJOHNPD<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x474F580", Offset = "0x474E180", VA = "0x18474F580")]
	public BICCMPNJHAK(bool KIDJPLHAOHG = false, bool CGAEHOOOIAO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x646F490", Offset = "0x646E090", VA = "0x18646F490")]
	public void JMCDHFFLEOJ(T LPCHKKFEGJO, U ELOMPBMKOHM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x50FD190", Offset = "0x50FBD90", VA = "0x1850FD190")]
	public static BICCMPNJHAK<T, U> EEHLCDOICDL(BICCMPNJHAK<T, U> GDOBEPMOGAK, Action<T, U> IFDCDCHOGGB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x50FD220", Offset = "0x50FBE20", VA = "0x1850FD220")]
	public static BICCMPNJHAK<T, U> HJGKBAEELNB(BICCMPNJHAK<T, U> GDOBEPMOGAK, Action<T, U> IFDCDCHOGGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class LPMMAPNCNDE<T, U, V> : GAFPOBLEMNJ<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x474F580", Offset = "0x474E180", VA = "0x18474F580")]
	public LPMMAPNCNDE(bool KIDJPLHAOHG = false, bool CGAEHOOOIAO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x52DBC30", Offset = "0x52DA830", VA = "0x1852DBC30")]
	public void JMCDHFFLEOJ(T LPCHKKFEGJO, U ELOMPBMKOHM, V GCKEIIMJEBO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x50FD190", Offset = "0x50FBD90", VA = "0x1850FD190")]
	public static LPMMAPNCNDE<T, U, V> EEHLCDOICDL(LPMMAPNCNDE<T, U, V> GDOBEPMOGAK, Action<T, U, V> IFDCDCHOGGB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x50FD220", Offset = "0x50FBE20", VA = "0x1850FD220")]
	public static LPMMAPNCNDE<T, U, V> HJGKBAEELNB(LPMMAPNCNDE<T, U, V> GDOBEPMOGAK, Action<T, U, V> IFDCDCHOGGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JMDIAJNJMIL<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class JJGCEELPLNH<T, U, V, W> : GAFPOBLEMNJ<Action<T, U, V, W>>, JMDIAJNJMIL<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x474F580", Offset = "0x474E180", VA = "0x18474F580")]
	public JJGCEELPLNH(bool KIDJPLHAOHG = false, bool CGAEHOOOIAO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x50FE8B0", Offset = "0x50FD4B0", VA = "0x1850FE8B0")]
	public void JMCDHFFLEOJ(T LPCHKKFEGJO, U ELOMPBMKOHM, V GCKEIIMJEBO, W GPNALACCLJE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x50FD190", Offset = "0x50FBD90", VA = "0x1850FD190")]
	public static JJGCEELPLNH<T, U, V, W> EEHLCDOICDL(JJGCEELPLNH<T, U, V, W> GDOBEPMOGAK, Action<T, U, V, W> IFDCDCHOGGB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x50FD220", Offset = "0x50FBE20", VA = "0x1850FD220")]
	public static JJGCEELPLNH<T, U, V, W> HJGKBAEELNB(JJGCEELPLNH<T, U, V, W> GDOBEPMOGAK, Action<T, U, V, W> IFDCDCHOGGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class DDHENOJLKLA<T, U, V, W, X> : GAFPOBLEMNJ<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x474F580", Offset = "0x474E180", VA = "0x18474F580")]
	public DDHENOJLKLA(bool KIDJPLHAOHG = false, bool CGAEHOOOIAO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6B87600", Offset = "0x6B86200", VA = "0x186B87600")]
	public void JMCDHFFLEOJ(T LPCHKKFEGJO, U ELOMPBMKOHM, V GCKEIIMJEBO, W GPNALACCLJE, X KFGAJBKADFK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x50FD190", Offset = "0x50FBD90", VA = "0x1850FD190")]
	public static DDHENOJLKLA<T, U, V, W, X> EEHLCDOICDL(DDHENOJLKLA<T, U, V, W, X> GDOBEPMOGAK, Action<T, U, V, W, X> IFDCDCHOGGB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x50FD220", Offset = "0x50FBE20", VA = "0x1850FD220")]
	public static DDHENOJLKLA<T, U, V, W, X> HJGKBAEELNB(DDHENOJLKLA<T, U, V, W, X> GDOBEPMOGAK, Action<T, U, V, W, X> IFDCDCHOGGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class NLNPODJODIE<T, U, V, W, X, Y> : GAFPOBLEMNJ<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x474F580", Offset = "0x474E180", VA = "0x18474F580")]
	public NLNPODJODIE(bool KIDJPLHAOHG = false, bool CGAEHOOOIAO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5533B80", Offset = "0x5532780", VA = "0x185533B80")]
	public void JMCDHFFLEOJ(T LPCHKKFEGJO, U ELOMPBMKOHM, V GCKEIIMJEBO, W GPNALACCLJE, X KFGAJBKADFK, Y FEABMDLFEMA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x50FD190", Offset = "0x50FBD90", VA = "0x1850FD190")]
	public static NLNPODJODIE<T, U, V, W, X, Y> EEHLCDOICDL(NLNPODJODIE<T, U, V, W, X, Y> GDOBEPMOGAK, Action<T, U, V, W, X, Y> IFDCDCHOGGB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x50FD220", Offset = "0x50FBE20", VA = "0x1850FD220")]
	public static NLNPODJODIE<T, U, V, W, X, Y> HJGKBAEELNB(NLNPODJODIE<T, U, V, W, X, Y> GDOBEPMOGAK, Action<T, U, V, W, X, Y> IFDCDCHOGGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class CKNABECGHKF<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly BFMIMIINNAC<TKey, TVal> NJNKKNLAOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> LLILGGKIMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly BFMIMIINNAC<TKey, TVal>.NJCJDIJOIAI? MGMBDDFMAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int FGPDGJADBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly BFMIMIINNAC<TKey, TVal>.OGCAKOBGIFN? KMCDBNCMOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int GBANKONGMDM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int HEKLIKMNBDD
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x69892B0", Offset = "0x6987EB0", VA = "0x1869892B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int HFMPIJBIBOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA20E70", Offset = "0xA1FA70", VA = "0x180A20E70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6989640", Offset = "0x6988240", VA = "0x186989640")]
	public CKNABECGHKF(int FGPDGJADBFL, [Optional] BFMIMIINNAC<TKey, TVal>.OGCAKOBGIFN? KMCDBNCMOOI, [Optional] IEqualityComparer<TKey>? PBJDFIPJAEK, [Optional] BFMIMIINNAC<TKey, TVal>.NJCJDIJOIAI? MGMBDDFMAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6988C40", Offset = "0x6987840", VA = "0x186988C40")]
	public void LEOBKCCAMOH(TKey MEPFFFGIFGB, TVal OOHGFGHCOAJ, bool PANPHENCKPJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x69886D0", Offset = "0x69872D0", VA = "0x1869886D0")]
	public bool ACODHOPMBKD(TKey MEPFFFGIFGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x69889A0", Offset = "0x69875A0", VA = "0x1869889A0")]
	public bool GFPOIIGIKGC(TKey DBGCCCIOHHI, [Out] TVal OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6989410", Offset = "0x6988010", VA = "0x186989410")]
	private void PGEIDFCKGIL(TKey MEPFFFGIFGB, TVal OOHGFGHCOAJ, int DKFJGBGJGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6988A70", Offset = "0x6987670", VA = "0x186988A70")]
	public bool GOCHFGEKCIA(TKey MEPFFFGIFGB, TVal OOHGFGHCOAJ, bool PANPHENCKPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6988BE0", Offset = "0x69877E0", VA = "0x186988BE0")]
	public void ILJKHADAMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6988DF0", Offset = "0x69879F0", VA = "0x186988DF0")]
	private void LGKDKPOALOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x69888C0", Offset = "0x69874C0", VA = "0x1869888C0")]
	private bool GCENMBMNMKL(TKey MEPFFFGIFGB, LDIGKLBOEIG HGJBCNEJGLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x69887F0", Offset = "0x69873F0", VA = "0x1869887F0")]
	private void FPHJFFMIKOA(TKey MEPFFFGIFGB, TVal OOHGFGHCOAJ, LDIGKLBOEIG HGJBCNEJGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x69892F0", Offset = "0x6987EF0", VA = "0x1869892F0")]
	private void MNIMNLEOBFK(TKey MEPFFFGIFGB, TVal AGKJLFOJIKC, LDIGKLBOEIG HGJBCNEJGLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class BFJEGLGLGBP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action BEMBLMCHHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool OPMDAHGEIHA;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
	public BFJEGLGLGBP(Action MCMBPBIMNPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7F2C340", Offset = "0x7F2AF40", VA = "0x187F2C340", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3834080", Offset = "0x3832C80", VA = "0x183834080")]
	public static BDNPFNHIMPF<T> GLOMJONEBBE<T>(T OOHGFGHCOAJ, Action MCMBPBIMNPF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class BDNPFNHIMPF<T> : BFJEGLGLGBP where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T IOOEMCNJEAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x62B0580", Offset = "0x62AF180", VA = "0x1862B0580")]
	public BDNPFNHIMPF(T OOHGFGHCOAJ, Action MCMBPBIMNPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class IDLMNAGBLIG<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly GKNFCILODEB<T>? ODNBGNPABOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> ABLOFFMHMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool OPMDAHGEIHA;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly IDLMNAGBLIG<T> LELJIFADAHI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> FOIGKPPDLBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4E66BE0", Offset = "0x4E657E0", VA = "0x184E66BE0")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long COFHLHAAMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4E66E20", Offset = "0x4E65A20", VA = "0x184E66E20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool PNOGDJAFBNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4E66FF0", Offset = "0x4E65BF0", VA = "0x184E66FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4E67A60", Offset = "0x4E66660", VA = "0x184E67A60")]
	public IDLMNAGBLIG(GKNFCILODEB<T> MFDEAHJIAMB, GKNFCILODEB<T> DNELJPGOJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4E676D0", Offset = "0x4E662D0", VA = "0x184E676D0")]
	public IDLMNAGBLIG(GKNFCILODEB<T> MFDEAHJIAMB, int DPCFFPEBOPM, GKNFCILODEB<T> DNELJPGOJLL, int AELGPLKDFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4E672A0", Offset = "0x4E65EA0", VA = "0x184E672A0")]
	private IDLMNAGBLIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4E66CE0", Offset = "0x4E658E0", VA = "0x184E66CE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4E66AA0", Offset = "0x4E656A0", VA = "0x184E66AA0")]
	public T[] DCHGJGHKDIF()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4E66EE0", Offset = "0x4E65AE0", VA = "0x184E66EE0")]
	public static ReadOnlySequence<T> GHOKLFELACP(IDLMNAGBLIG<T>? HOAJPHOCGDM)
	{
		return default(ReadOnlySequence<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct AEGONMJFPDD<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly IDisposable ODNPAACGFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public T IOOEMCNJEAH;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4D5CB50", Offset = "0x4D5B750", VA = "0x184D5CB50")]
	public AEGONMJFPDD(IDisposable IJNCJOKBAFO, [In] T OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x30255B0", Offset = "0x30241B0", VA = "0x1830255B0")]
	public static AEGONMJFPDD<U> ELEAEHMMBOK<U>([In] AEGONMJFPDD<T> IJNCJOKBAFO, [In] U OOHGFGHCOAJ) where U : notnull
	{
		return default(AEGONMJFPDD<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4D5CA70", Offset = "0x4D5B670", VA = "0x184D5CA70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class CDMBPAINNOB
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3896680", Offset = "0x3895280", VA = "0x183896680")]
	public static AEGONMJFPDD<T> JHMOIFLKJAD<T>(IDisposable IJNCJOKBAFO, [In] T OOHGFGHCOAJ) where T : notnull
	{
		return default(AEGONMJFPDD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x38966E0", Offset = "0x38952E0", VA = "0x1838966E0")]
	public static AEGONMJFPDD<T> KCJEKOHENMB<T>([In] this AEGONMJFPDD<T> LAAPKLDJLPE, [Out] T OOHGFGHCOAJ) where T : notnull
	{
		return default(AEGONMJFPDD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3896650", Offset = "0x3895250", VA = "0x183896650")]
	public static AEGONMJFPDD<U?> ELEAEHMMBOK<U, T>([In] AEGONMJFPDD<T> PHGFANFGDPA, [In] U OOHGFGHCOAJ)
	{
		return default(AEGONMJFPDD<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct IOPBNOLGHPI : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct JPGODFCLGMJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0")]
		public static JPGODFCLGMJ JHMOIFLKJAD()
		{
			return default(JPGODFCLGMJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7F2DB70", Offset = "0x7F2C770", VA = "0x187F2DB70")]
	public static string ACNHBPCEDJO(Type OPOPAMPKKGD, [Optional] string? EENFGGEHNKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3B08DF0", Offset = "0x3B079F0", VA = "0x183B08DF0")]
	public static string? ACNHBPCEDJO<T>([Optional] string? EENFGGEHNKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3B08E70", Offset = "0x3B07A70", VA = "0x183B08E70")]
	public static string? GJDOIHNIJCN<T>([Optional] string? HAPFDCMECPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0")]
	public static IOPBNOLGHPI AFAOJPNNAAP(string EENFGGEHNKK, string? HAPFDCMECPF)
	{
		return default(IOPBNOLGHPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct PDAOBOECEPN
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate bool PHLBFDFOAPI(string BHPHIOHMCMD, PDAOBOECEPN AIIBGJGCLKI);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class HEPACCAOLJG<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public HEPACCAOLJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4D91280", Offset = "0x4D8FE80", VA = "0x184D91280")]
		internal void HMBAMNCOJPO(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public int NBOMHMDCNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public string CIDLPMHGPMD;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7F2F930", Offset = "0x7F2E530", VA = "0x187F2F930")]
	public static Dictionary<string, PDAOBOECEPN> PBJGNFJFMPN(Type MJLAGNNHJKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3C806F0", Offset = "0x3C7F2F0", VA = "0x183C806F0")]
	public static Dictionary<string, PDAOBOECEPN> PBJGNFJFMPN<T>(Type MJLAGNNHJKJ, IReadOnlyDictionary<T, string> DGCPCNNDJLC) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3C80030", Offset = "0x3C7EC30", VA = "0x183C80030")]
	public static Dictionary<string, PDAOBOECEPN> ECNADGPODLM<T>(List<T> BMLKNGCONNO) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7F2F3C0", Offset = "0x7F2DFC0", VA = "0x187F2F3C0")]
	public static Dictionary<string, PDAOBOECEPN> GAAHJKJCOMJ(Type MJLAGNNHJKJ, PHLBFDFOAPI MPMPACHBMMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7F2F770", Offset = "0x7F2E370", VA = "0x187F2F770")]
	public static Dictionary<int, string> GMOONNGPACN(Dictionary<string, PDAOBOECEPN> GBEGHJIHKEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class OGEAAGEPEFJ : EFKBKOGFPPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool IOAFGJGPJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly string? ELCCCKLHOHP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual EFKBKOGFPPJ? CADMEKABKEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7F2F350", Offset = "0x7F2DF50", VA = "0x187F2F350")]
	protected OGEAAGEPEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string NEEGIDJCGEP();

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7F2F0D0", Offset = "0x7F2DCD0", VA = "0x187F2F0D0", Slot = "8")]
	public virtual string LEKIEBOICOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7F2ED10", Offset = "0x7F2D910", VA = "0x187F2ED10", Slot = "9")]
	public void HLJNGPCFKDG(StringBuilder GLHJIBKKKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7F2ECB0", Offset = "0x7F2D8B0", VA = "0x187F2ECB0", Slot = "10")]
	public void EFAJCGCGNBH(StringBuilder GLHJIBKKKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7F2EFB0", Offset = "0x7F2DBB0", VA = "0x187F2EFB0", Slot = "11")]
	public void JDIGFGOFMND(StringBuilder GLHJIBKKKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7F2F1F0", Offset = "0x7F2DDF0", VA = "0x187F2F1F0", Slot = "12")]
	public void PEPJMAEEBLC(StringBuilder GLHJIBKKKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7F2F150", Offset = "0x7F2DD50", VA = "0x187F2F150")]
	public static void MOEPOGEEPGN(StringBuilder GLHJIBKKKPM, string CBBHDDJIAGB, string PDFNHKKBJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6E6DE30", Offset = "0x6E6CA30", VA = "0x186E6DE30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ODMIBIPPNBP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7F2EC50", Offset = "0x7F2D850", VA = "0x187F2EC50")]
	public ODMIBIPPNBP(string FNFIPKNHEOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class CGHLDNDHHBB<TErr> : ODMIBIPPNBP where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly TErr FCLKKPACLMH;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x693C2E0", Offset = "0x693AEE0", VA = "0x18693C2E0")]
	private CGHLDNDHHBB([In] TErr EMNJHHPPEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x693C220", Offset = "0x693AE20", VA = "0x18693C220")]
	public static CGHLDNDHHBB<TErr> JHMOIFLKJAD([In] TErr EMNJHHPPEFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GMGMKEALKGL : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashAlgorithm HHMPBAMLNCM;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool AENOMINDILC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool OOBKBOEDHFA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool KAFCGPNPAJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long COFHLHAAMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7F2D460", Offset = "0x7F2C060", VA = "0x187F2D460", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long AIFJIFCFPDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7F2D4D0", Offset = "0x7F2C0D0", VA = "0x187F2D4D0", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7F2D540", Offset = "0x7F2C140", VA = "0x187F2D540", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D3F0", Offset = "0x7F2BFF0", VA = "0x187F2D3F0")]
	public GMGMKEALKGL(HashAlgorithm HHMPBAMLNCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D220", Offset = "0x7F2BE20", VA = "0x187F2D220", Slot = "35")]
	public override int Read(byte[] DPMBBHPEMOM, int KPHEINADMCH, int DPOOEAFKIHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D3C0", Offset = "0x7F2BFC0", VA = "0x187F2D3C0", Slot = "38")]
	public override void Write(byte[] DPMBBHPEMOM, int KPHEINADMCH, int DPOOEAFKIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D2C0", Offset = "0x7F2BEC0", VA = "0x187F2D2C0", Slot = "33")]
	public override long Seek(long KPHEINADMCH, SeekOrigin NFEAKPLEKJO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D350", Offset = "0x7F2BF50", VA = "0x187F2D350", Slot = "34")]
	public override void SetLength(long OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D150", Offset = "0x7F2BD50", VA = "0x187F2D150")]
	public byte[] KNIBOKHELAP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface EFKBKOGFPPJ
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LEKIEBOICOI();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string NEEGIDJCGEP();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface HMBBJPLHOBO<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions IOOEMCNJEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface CIDPEAABOFD
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string HLOKCDNDOKN
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class GKNFCILODEB<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static GKNFCILODEB<T>? JNFCMKLNDIJ;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static object OOCCOLMJHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private IMemoryOwner<T>? CBCMONDIKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool OPMDAHGEIHA;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool PHEIOPHLIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA7B230", Offset = "0xA79E30", VA = "0x180A7B230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4D1E230", Offset = "0x4D1CE30", VA = "0x184D1E230")]
	private static GKNFCILODEB<T> JNEEJOMHNMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4D1E690", Offset = "0x4D1D290", VA = "0x184D1E690")]
	private static void LBGLNFDNMBG(GKNFCILODEB<T> OACPAFBLHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x47034F0", Offset = "0x47020F0", VA = "0x1847034F0")]
	private GKNFCILODEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4D1DED0", Offset = "0x4D1CAD0", VA = "0x184D1DED0")]
	public static GKNFCILODEB<T> GLOMJONEBBE(ReadOnlyMemory<T> JCOAOOCLABB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4D1DCE0", Offset = "0x4D1C8E0", VA = "0x184D1DCE0")]
	public static GKNFCILODEB<T> GLOMJONEBBE(IMemoryOwner<T> NJOPJFKIKCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4D1EBD0", Offset = "0x4D1D7D0", VA = "0x184D1EBD0")]
	public static void MOEEKCBLABA(GKNFCILODEB<T> MFDEAHJIAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4D1D910", Offset = "0x4D1C510", VA = "0x184D1D910", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4D1DB20", Offset = "0x4D1C720", VA = "0x184D1DB20")]
	public GKNFCILODEB<T> EJMCHEMJKKP(IMemoryOwner<T> NJOPJFKIKCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4D1ECE0", Offset = "0x4D1D8E0", VA = "0x184D1ECE0")]
	private void NLHCLLLOPHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4D1DBE0", Offset = "0x4D1C7E0", VA = "0x184D1DBE0")]
	private GKNFCILODEB<T> FGAENBBKLOJ(GKNFCILODEB<T> OACPAFBLHJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class CGABJICPIGJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7F2C380", Offset = "0x7F2AF80", VA = "0x187F2C380")]
	public CGABJICPIGJ(string FNFIPKNHEOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class PJKOKDOPNGJ<TOk> : CGABJICPIGJ where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TOk PMOHBAPDELF;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x57DFD60", Offset = "0x57DE960", VA = "0x1857DFD60")]
	private PJKOKDOPNGJ([In] TOk DGPHADOMKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x42D1710", Offset = "0x42D0310", VA = "0x1842D1710")]
	public static PJKOKDOPNGJ<TOk> JHMOIFLKJAD([In] TOk DGPHADOMKNE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct MDDPJNIIBBI<TOk, TErr> : IEquatable<MDDPJNIIBBI<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly EqualityComparer<TErr> BOIGDIKLFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal readonly TErr FCLKKPACLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal readonly TOk PMOHBAPDELF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool HBKHGANEACO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x54A94C0", Offset = "0x54A80C0", VA = "0x1854A94C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool OFHPAIONEBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x54A9910", Offset = "0x54A8510", VA = "0x1854A9910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x54ADC70", Offset = "0x54AC870", VA = "0x1854ADC70")]
	internal MDDPJNIIBBI([In] TErr EMNJHHPPEFM, [In] TOk DGPHADOMKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x54A3BE0", Offset = "0x54A27E0", VA = "0x1854A3BE0")]
	public static MDDPJNIIBBI<TOk, TErr> AJKKHEAHGBL([In] TErr EMNJHHPPEFM)
	{
		return default(MDDPJNIIBBI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x54A8B80", Offset = "0x54A7780", VA = "0x1854A8B80")]
	public static MDDPJNIIBBI<TOk, TErr> LNDPGEPBJGG([In] TOk DGPHADOMKNE)
	{
		return default(MDDPJNIIBBI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x41E65E0", Offset = "0x41E51E0", VA = "0x1841E65E0")]
	public MDDPJNIIBBI<TOk?, UErr?> OJAFNBOCINF<UErr>()
	{
		return default(MDDPJNIIBBI<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x41E61A0", Offset = "0x41E4DA0", VA = "0x1841E61A0")]
	public MDDPJNIIBBI<UOk?, TErr?> HMLHACEGAEN<UOk>()
	{
		return default(MDDPJNIIBBI<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x41E48E0", Offset = "0x41E34E0", VA = "0x1841E48E0")]
	public MDDPJNIIBBI<UOk?, TErr?> BBPBFAGBKBL<UOk>()
	{
		return default(MDDPJNIIBBI<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x41E63C0", Offset = "0x41E4FC0", VA = "0x1841E63C0")]
	public MDDPJNIIBBI<TOk?, UErr?> JGEHIMHCPHI<UErr>()
	{
		return default(MDDPJNIIBBI<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x54A5490", Offset = "0x54A4090", VA = "0x1854A5490")]
	public MDDPJNIIBBI<BOFEABKGBFC, TErr> FDMFFGAHOEE()
	{
		return default(MDDPJNIIBBI<BOFEABKGBFC, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x54A6FB0", Offset = "0x54A5BB0", VA = "0x1854A6FB0")]
	public static bool JOHLOKGLNML([In] MDDPJNIIBBI<TOk, TErr> NAHMIIJKKEL, [In] MDDPJNIIBBI<TOk, TErr> IJNKBHOINCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x54A42B0", Offset = "0x54A2EB0", VA = "0x1854A42B0", Slot = "4")]
	public bool Equals(MDDPJNIIBBI<TOk, TErr> GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x54A4370", Offset = "0x54A2F70", VA = "0x1854A4370", Slot = "0")]
	public override bool Equals(object GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x54A6C00", Offset = "0x54A5800", VA = "0x1854A6C00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x54ABBE0", Offset = "0x54AA7E0", VA = "0x1854ABBE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class NHJFBJACGFP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct PAOMAFJMKMI<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Task<MDDPJNIIBBI<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<MDDPJNIIBBI<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x57B4E30", Offset = "0x57B3A30", VA = "0x1857B4E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x57B5130", Offset = "0x57B3D30", VA = "0x1857B5130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3C3D1F0", Offset = "0x3C3BDF0", VA = "0x183C3D1F0")]
	public static MDDPJNIIBBI<TOk?, TErr?> PMOHBAPDELF<TOk, TErr>([In] this MDDPJNIIBBI<TOk, TErr> LAAPKLDJLPE, [In] TOk DGPHADOMKNE)
	{
		return default(MDDPJNIIBBI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3C3EA10", Offset = "0x3C3D610", VA = "0x183C3EA10")]
	public static MDDPJNIIBBI<BOFEABKGBFC, TErr?> PMOHBAPDELF<TErr>([In] this MDDPJNIIBBI<BOFEABKGBFC, TErr> LAAPKLDJLPE)
	{
		return default(MDDPJNIIBBI<BOFEABKGBFC, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3C3D1F0", Offset = "0x3C3BDF0", VA = "0x183C3D1F0")]
	public static MDDPJNIIBBI<TOk?, TErr?> FCLKKPACLMH<TOk, TErr>([In] this MDDPJNIIBBI<TOk, TErr> LAAPKLDJLPE, [In] TErr EMNJHHPPEFM)
	{
		return default(MDDPJNIIBBI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3C3CE90", Offset = "0x3C3BA90", VA = "0x183C3CE90")]
	public static TOk? EIPPDAEBBMK<TOk, TErr>([In] this MDDPJNIIBBI<TOk, TErr> LAAPKLDJLPE)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3C3E850", Offset = "0x3C3D450", VA = "0x183C3E850")]
	[AsyncStateMachine(typeof(PAOMAFJMKMI<, >))]
	public static Task<TOk?>? PLCANGODNJG<TOk, TErr>(this Task<MDDPJNIIBBI<TOk, TErr>> LAAPKLDJLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3C3D6D0", Offset = "0x3C3C2D0", VA = "0x183C3D6D0")]
	public static TErr? GIOAHLEIDMK<TErr, TOk>([In] this MDDPJNIIBBI<TOk, TErr> LAAPKLDJLPE)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3C3B5F0", Offset = "0x3C3A1F0", VA = "0x183C3B5F0")]
	public static bool DIJKECNNPKG<TOk, TErr, UErr, UOk>([In] this MDDPJNIIBBI<TOk, TErr> LAAPKLDJLPE, [Out] MDDPJNIIBBI<UOk, UErr> JFBGMMNBJOC) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3C3B360", Offset = "0x3C39F60", VA = "0x183C3B360")]
	public static bool CFFMAMHOLDP<TOk, TErr>([In] this MDDPJNIIBBI<TOk, TErr> LAAPKLDJLPE, [Out] TOk DGPHADOMKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3C3E540", Offset = "0x3C3D140", VA = "0x183C3E540")]
	public static bool OLPJFPAFOFO<TOk, TErr>([In] this MDDPJNIIBBI<TOk, TErr> LAAPKLDJLPE, [Out][NotNullWhen(true)] TErr EMNJHHPPEFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3C3D830", Offset = "0x3C3C430", VA = "0x183C3D830")]
	public static bool JPLMFHAEFLO<TOk, TErr>([In] this MDDPJNIIBBI<TOk, TErr> LAAPKLDJLPE, [Out][NotNullWhen(true)] TOk DGPHADOMKNE, [Out][NotNullWhen(false)] TErr EMNJHHPPEFM) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3C3D310", Offset = "0x3C3BF10", VA = "0x183C3D310")]
	public static bool FNACNKFIFBG<TOk, TErr>([In] this MDDPJNIIBBI<TOk, TErr> LAAPKLDJLPE, [Out][NotNullWhen(true)] TOk DGPHADOMKNE, [Out] MDDPJNIIBBI<TOk, TErr> JFBGMMNBJOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3C3BA60", Offset = "0x3C3A660", VA = "0x183C3BA60")]
	public static bool DIJKECNNPKG<TOk, TErr, UErr, UOk>([In] this MDDPJNIIBBI<TOk, TErr> LAAPKLDJLPE, [Out][NotNullWhen(true)] TOk DGPHADOMKNE, [Out] MDDPJNIIBBI<UOk, UErr> JFBGMMNBJOC) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3C3DED0", Offset = "0x3C3CAD0", VA = "0x183C3DED0")]
	public static bool LEGKNALMPDF<TOk, TErr>([In] this MDDPJNIIBBI<TOk, TErr> LAAPKLDJLPE, [Out][NotNullWhen(true)] TOk DGPHADOMKNE, [Out] MDDPJNIIBBI<BOFEABKGBFC, TErr> JFBGMMNBJOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3C3AA60", Offset = "0x3C39660", VA = "0x183C3AA60")]
	public static MDDPJNIIBBI<UOk, UErr> BBBOCILBMEB<UOk, UErr, TOk, TErr>([In] this MDDPJNIIBBI<TOk, TErr> LAAPKLDJLPE, [In] MDDPJNIIBBI<UOk, UErr> NGGJJFKLDLG) where TOk : UOk where TErr : UErr
	{
		return default(MDDPJNIIBBI<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3C3DAC0", Offset = "0x3C3C6C0", VA = "0x183C3DAC0")]
	public static MDDPJNIIBBI<TOk?[]?, TErr?> KBPIDKAEHNC<TOk, TErr>(this IEnumerable<MDDPJNIIBBI<TOk, TErr>> LAAPKLDJLPE)
	{
		return default(MDDPJNIIBBI<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3C3E230", Offset = "0x3C3CE30", VA = "0x183C3E230")]
	public static MDDPJNIIBBI<UOk?, TErr?> LJKHFOFMFJM<UOk, TErr, TOk>([In] this MDDPJNIIBBI<TOk, TErr> LAAPKLDJLPE, Func<TOk, UOk> JONOJDCFIND)
	{
		return default(MDDPJNIIBBI<UOk, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class CGMBDDDGLGB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3C1C370", Offset = "0x3C1AF70", VA = "0x183C1C370")]
	public static MDDPJNIIBBI<TOk, T> PMOHBAPDELF<TOk>([In] TOk DGPHADOMKNE) where TOk : notnull
	{
		return default(MDDPJNIIBBI<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x69471A0", Offset = "0x6945DA0", VA = "0x1869471A0")]
	public static MDDPJNIIBBI<BOFEABKGBFC, T> PMOHBAPDELF()
	{
		return default(MDDPJNIIBBI<BOFEABKGBFC, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3C1C370", Offset = "0x3C1AF70", VA = "0x183C1C370")]
	public static MDDPJNIIBBI<T, TErr> FCLKKPACLMH<TErr>([In] TErr EMNJHHPPEFM) where TErr : notnull
	{
		return default(MDDPJNIIBBI<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct LGNLAPLCNCN<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly IEGGCNFIJCN LJDJFFIAIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly Dictionary<TKey, TValue> ODNFHFLAFOB;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x50AF520", Offset = "0x50AE120", VA = "0x1850AF520")]
	public static LGNLAPLCNCN<TKey, TValue> JHMOIFLKJAD(string CBLPKFIJGLH)
	{
		return default(LGNLAPLCNCN<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x50AF630", Offset = "0x50AE230", VA = "0x1850AF630")]
	internal LGNLAPLCNCN(Dictionary<TKey, TValue> OOHGFGHCOAJ, IEGGCNFIJCN EOAOIEACNLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x50AF480", Offset = "0x50AE080", VA = "0x1850AF480")]
	public POOBDGFNCED<TKey, TValue> IHDNCFODHOF([Out] Dictionary<TKey, TValue> OOHGFGHCOAJ)
	{
		return default(POOBDGFNCED<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct POOBDGFNCED<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TValue> ODNFHFLAFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly GJBBNLLHHMB IHOIOKCIIKM;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2B581F0", Offset = "0x2B56DF0", VA = "0x182B581F0")]
	internal POOBDGFNCED(Dictionary<TKey, TValue> OOHGFGHCOAJ, GJBBNLLHHMB LNGNNIEEPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4721680", Offset = "0x4720280", VA = "0x184721680", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct MGPGJCPFHNG<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly IEGGCNFIJCN LJDJFFIAIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly HashSet<T> ODNFHFLAFOB;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x50AF520", Offset = "0x50AE120", VA = "0x1850AF520")]
	public static MGPGJCPFHNG<T> JHMOIFLKJAD(string CBLPKFIJGLH)
	{
		return default(MGPGJCPFHNG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x50AF630", Offset = "0x50AE230", VA = "0x1850AF630")]
	internal MGPGJCPFHNG(HashSet<T> OOHGFGHCOAJ, IEGGCNFIJCN EOAOIEACNLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x50AF480", Offset = "0x50AE080", VA = "0x1850AF480")]
	public HCKCNHJHEBO<T> IHDNCFODHOF([Out] HashSet<T> OOHGFGHCOAJ)
	{
		return default(HCKCNHJHEBO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct HCKCNHJHEBO<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HashSet<T> ODNFHFLAFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly GJBBNLLHHMB IHOIOKCIIKM;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2B581F0", Offset = "0x2B56DF0", VA = "0x182B581F0")]
	internal HCKCNHJHEBO(HashSet<T> OOHGFGHCOAJ, GJBBNLLHHMB LNGNNIEEPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4721680", Offset = "0x4720280", VA = "0x184721680", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct JBKLCDAPFOC<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IEGGCNFIJCN LJDJFFIAIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Stack<T> ODNFHFLAFOB;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x50AF520", Offset = "0x50AE120", VA = "0x1850AF520")]
	public static JBKLCDAPFOC<T> JHMOIFLKJAD(string CBLPKFIJGLH)
	{
		return default(JBKLCDAPFOC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x50AF630", Offset = "0x50AE230", VA = "0x1850AF630")]
	internal JBKLCDAPFOC(Stack<T> OOHGFGHCOAJ, IEGGCNFIJCN EOAOIEACNLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x50AF480", Offset = "0x50AE080", VA = "0x1850AF480")]
	public EGHJMPJEAMN<T> IHDNCFODHOF([Out] Stack<T> OOHGFGHCOAJ)
	{
		return default(EGHJMPJEAMN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct EGHJMPJEAMN<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Stack<T> ODNFHFLAFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly GJBBNLLHHMB IHOIOKCIIKM;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2B581F0", Offset = "0x2B56DF0", VA = "0x182B581F0")]
	internal EGHJMPJEAMN(Stack<T> OOHGFGHCOAJ, GJBBNLLHHMB LNGNNIEEPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4721680", Offset = "0x4720280", VA = "0x184721680", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DefaultMember("Item")]
public sealed class BNCPDDAOLKO<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct LLPLLMJHLDP : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly BNCPDDAOLKO<T> BIDLIDINMLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly int LDFDMILMLKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly bool OHMHDLPNICE;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x27E43C0", Offset = "0x27E2FC0", VA = "0x1827E43C0")]
		public LLPLLMJHLDP(BNCPDDAOLKO<T> JCPBJCFMJCO, int IOLKBDNGKPC, bool FCFFHIKPKAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x52C4C30", Offset = "0x52C3830", VA = "0x1852C4C30")]
		public BNCPDDAOLKO<T>.LFKKJGFFLJA MEEEBEDBKAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x52C4D10", Offset = "0x52C3910", VA = "0x1852C4D10", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x52C4D10", Offset = "0x52C3910", VA = "0x1852C4D10", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public sealed class LFKKJGFFLJA : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly BNCPDDAOLKO<T> BIDLIDINMLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly int BPLMCAMIGOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int DLNMMIFPDDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly bool OHMHDLPNICE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private bool CPNECPJHADC;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T FGILBCMPPDP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x52B6B00", Offset = "0x52B5700", VA = "0x1852B6B00")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x52B6C90", Offset = "0x52B5890", VA = "0x1852B6C90", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x52B6E20", Offset = "0x52B5A20", VA = "0x1852B6E20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x52B7100", Offset = "0x52B5D00", VA = "0x1852B7100")]
		public LFKKJGFFLJA(BNCPDDAOLKO<T> JCPBJCFMJCO, int IOLKBDNGKPC, bool FCFFHIKPKAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x52B6BC0", Offset = "0x52B57C0", VA = "0x1852B6BC0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x52B6C40", Offset = "0x52B5840", VA = "0x1852B6C40", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class OOMJMIOJODL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public OOMJMIOJODL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5699590", Offset = "0x5698190", VA = "0x185699590")]
		internal T LGBCCJOCEAA(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly T[] KDBDBPJCEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private int DLNMMIFPDDM;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int EPJHBOCDCHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x655B3B0", Offset = "0x6559FB0", VA = "0x18655B3B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T FGILBCMPPDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4B768C0", Offset = "0x4B754C0", VA = "0x184B768C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T FOKPOJPOLHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x655B4B0", Offset = "0x655A0B0", VA = "0x18655B4B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x655B580", Offset = "0x655A180", VA = "0x18655B580")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int COFHLHAAMAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x276D1E0", Offset = "0x276BDE0", VA = "0x18276D1E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1BFE7C0", Offset = "0x1BFD3C0", VA = "0x181BFE7C0")]
	private static int NNIHMNLPNJA(int EMMACFPOKFB, int FMOIHNPEKPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x655B6B0", Offset = "0x655A2B0", VA = "0x18655B6B0")]
	public BNCPDDAOLKO(int DKFJGBGJGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x655B9A0", Offset = "0x655A5A0", VA = "0x18655B9A0")]
	public BNCPDDAOLKO(int DKFJGBGJGBG, Func<T> ODDCGNAKCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x655BBA0", Offset = "0x655A7A0", VA = "0x18655BBA0")]
	public BNCPDDAOLKO(T[] OGLPOFDOMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x655B380", Offset = "0x6559F80", VA = "0x18655B380")]
	public void BBKHPJGKAHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x655B3F0", Offset = "0x6559FF0", VA = "0x18655B3F0")]
	public IEnumerable<T> FEFBJMCBIGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x655B630", Offset = "0x655A230", VA = "0x18655B630")]
	public BNCPDDAOLKO<T>.LFKKJGFFLJA MEEEBEDBKAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x429E9C0", Offset = "0x429D5C0", VA = "0x18429E9C0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x429E9C0", Offset = "0x429D5C0", VA = "0x18429E9C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class NNLMFIMLCBJ
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3C44C60", Offset = "0x3C43860", VA = "0x183C44C60")]
	public static BNCPDDAOLKO<T> JHMOIFLKJAD<T>(int DKFJGBGJGBG, Func<T> ODDCGNAKCJK) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static RRColor White
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x7F30670", Offset = "0x7F2F270", VA = "0x187F30670")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x7F30630", Offset = "0x7F2F230", VA = "0x187F30630")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x7F30650", Offset = "0x7F2F250", VA = "0x187F30650")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7F30690", Offset = "0x7F2F290", VA = "0x187F30690")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x7F30610", Offset = "0x7F2F210", VA = "0x187F30610")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x29151E0", Offset = "0x2913DE0", VA = "0x1829151E0")]
		public RRColor(float DGCKGHIBLHO, float DCOGAJOPHKB, float KLKIJPOLHDE, float ABBBJFPFEKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0BE0", Offset = "0x7DAF7E0", VA = "0x187DB0BE0", Slot = "4")]
		public bool Equals(RRColor GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7F30260", Offset = "0x7F2EE60", VA = "0x187F30260", Slot = "0")]
		public override bool Equals(object GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7F30360", Offset = "0x7F2EF60", VA = "0x187F30360", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7F303E0", Offset = "0x7F2EFE0", VA = "0x187F303E0", Slot = "5")]
		public string ToString(string GFCBDNDPEDI, IFormatProvider ELLKPMONHDB)
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct RRColor32 : IEquatable<RRColor32>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int rgba;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public byte r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public byte g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public byte b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public byte a;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static RRColor32 White
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x7F30200", Offset = "0x7F2EE00", VA = "0x187F30200")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7F301A0", Offset = "0x7F2EDA0", VA = "0x187F301A0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7F301D0", Offset = "0x7F2EDD0", VA = "0x187F301D0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7F30230", Offset = "0x7F2EE30", VA = "0x187F30230")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x7F30170", Offset = "0x7F2ED70", VA = "0x187F30170")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E13150", Offset = "0x5E11D50", VA = "0x185E13150")]
		public RRColor32(byte DGCKGHIBLHO, byte DCOGAJOPHKB, byte KLKIJPOLHDE, byte ABBBJFPFEKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x230B2D0", Offset = "0x2309ED0", VA = "0x18230B2D0", Slot = "4")]
		public bool Equals(RRColor32 GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7F2FCD0", Offset = "0x7F2E8D0", VA = "0x187F2FCD0", Slot = "0")]
		public override bool Equals(object GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x14235B0", Offset = "0x14221B0", VA = "0x1814235B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7F2FDC0", Offset = "0x7F2E9C0", VA = "0x187F2FDC0")]
		public static RRColor32 GHOKLFELACP(RRColor OFHHGNENJGM)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7F2FD50", Offset = "0x7F2E950", VA = "0x187F2FD50")]
		public static RRColor GHOKLFELACP(RRColor32 OFHHGNENJGM)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7F2FF10", Offset = "0x7F2EB10", VA = "0x187F2FF10", Slot = "5")]
		public string ToString(string GFCBDNDPEDI, IFormatProvider ELLKPMONHDB)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class EKDDCBEIJMI<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct EPNIIFCKFCI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly EKDDCBEIJMI<T> FLABMFPJDJI;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T IOOEMCNJEAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x474F5D0", Offset = "0x474E1D0", VA = "0x18474F5D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x474F5A0", Offset = "0x474E1A0", VA = "0x18474F5A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xDCEEA0", Offset = "0xDCDAA0", VA = "0x180DCEEA0")]
		public EPNIIFCKFCI(EKDDCBEIJMI<T> FLABMFPJDJI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct BGONBJFLGIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<EPNIIFCKFCI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public EKDDCBEIJMI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x63A4370", Offset = "0x63A2F70", VA = "0x1863A4370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4B84150", Offset = "0x4B82D50", VA = "0x184B84150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly SemaphoreSlim HIOPJINPKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private T MFBFDGPNIHD;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4738A10", Offset = "0x4737610", VA = "0x184738A10")]
	public EKDDCBEIJMI([In] T MFBFDGPNIHD, int HOONFHLICPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4738AB0", Offset = "0x47376B0", VA = "0x184738AB0")]
	public EKDDCBEIJMI([In] T MFBFDGPNIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4738530", Offset = "0x4737130", VA = "0x184738530", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4738570", Offset = "0x4737170", VA = "0x184738570")]
	public EPNIIFCKFCI HEJBJAOJIBE()
	{
		return default(EPNIIFCKFCI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x47387F0", Offset = "0x47373F0", VA = "0x1847387F0")]
	[AsyncStateMachine(typeof(EKDDCBEIJMI<>.BGONBJFLGIN))]
	public Task<EKDDCBEIJMI<T>.EPNIIFCKFCI> OAGLGIHOBLE(CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x47385B0", Offset = "0x47371B0", VA = "0x1847385B0")]
	public void LDHFGAMPMHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class PLDDKDGMEMO
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7F2FC60", Offset = "0x7F2E860", VA = "0x187F2FC60")]
	public static EKDDCBEIJMI<BOFEABKGBFC> JHMOIFLKJAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3834190", Offset = "0x3832D90", VA = "0x183834190")]
	public static EKDDCBEIJMI<T> JHMOIFLKJAD<T>([In] T MFBFDGPNIHD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class IGEDNDFKELL<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public readonly struct PDIHGADAMMH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly IGEDNDFKELL<T> CEAEDMIKLJG;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T IOOEMCNJEAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x565F460", Offset = "0x565E060", VA = "0x18565F460")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x57C1F80", Offset = "0x57C0B80", VA = "0x1857C1F80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xDCEEA0", Offset = "0xDCDAA0", VA = "0x180DCEEA0")]
		internal PDIHGADAMMH(IGEDNDFKELL<T> FLABMFPJDJI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public readonly struct OFCJEECPDDA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly IGEDNDFKELL<T> CEAEDMIKLJG;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T IOOEMCNJEAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x565F460", Offset = "0x565E060", VA = "0x18565F460")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x565F370", Offset = "0x565DF70", VA = "0x18565F370", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xDCEEA0", Offset = "0xDCDAA0", VA = "0x180DCEEA0")]
		internal OFCJEECPDDA(IGEDNDFKELL<T> FLABMFPJDJI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct FBCPHMPPDDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AsyncTaskMethodBuilder<OFCJEECPDDA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public IGEDNDFKELL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private EKDDCBEIJMI<BOFEABKGBFC>.EPNIIFCKFCI <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter<EKDDCBEIJMI<BOFEABKGBFC>.EPNIIFCKFCI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4B83C30", Offset = "0x4B82830", VA = "0x184B83C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4B84150", Offset = "0x4B82D50", VA = "0x184B84150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly EKDDCBEIJMI<int> DMOMFKKGFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly EKDDCBEIJMI<BOFEABKGBFC> HONLABBLIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly EKDDCBEIJMI<BOFEABKGBFC> PPJBCKKICLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private T GPDLKDOPKJK;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4E75B30", Offset = "0x4E74730", VA = "0x184E75B30")]
	internal IGEDNDFKELL(EKDDCBEIJMI<int> OIDDCMKNCNK, EKDDCBEIJMI<BOFEABKGBFC> ELPFMDGIHLE, EKDDCBEIJMI<BOFEABKGBFC> OOLJALKFEFK, [In] T MFBFDGPNIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4E74E30", Offset = "0x4E73A30", VA = "0x184E74E30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4E752B0", Offset = "0x4E73EB0", VA = "0x184E752B0")]
	public PDIHGADAMMH JBMIJPIPMMA()
	{
		return default(PDIHGADAMMH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4E757D0", Offset = "0x4E743D0", VA = "0x184E757D0")]
	public OFCJEECPDDA MOPDAHIFEJI()
	{
		return default(OFCJEECPDDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4E756B0", Offset = "0x4E742B0", VA = "0x184E756B0")]
	[AsyncStateMachine(typeof(IGEDNDFKELL<>.FBCPHMPPDDD))]
	public Task<IGEDNDFKELL<T>.OFCJEECPDDA> LCIPJOBBPNB(CancellationToken DKKNFNCKCEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class LLHOCAEBICE
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7F2E660", Offset = "0x7F2D260", VA = "0x187F2E660")]
	public static IGEDNDFKELL<BOFEABKGBFC> JHMOIFLKJAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3B97800", Offset = "0x3B96400", VA = "0x183B97800")]
	public static IGEDNDFKELL<T> JHMOIFLKJAD<T>([In] T MFBFDGPNIHD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class LPLMBEAJACA<TData> : OGEAAGEPEFJ where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly string MEEMMPNFCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly TData PBCJADGOGBF;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
	public override string NEEGIDJCGEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x52D8EA0", Offset = "0x52D7AA0", VA = "0x1852D8EA0")]
	internal LPLMBEAJACA(string FNFIPKNHEOF, [In] TData PEDMEJIDLNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class EMIDFEJOHLO
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7F2C530", Offset = "0x7F2B130", VA = "0x187F2C530")]
	public static LPLMBEAJACA<BOFEABKGBFC> JHMOIFLKJAD(string FNFIPKNHEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3834080", Offset = "0x3832C80", VA = "0x183834080")]
	public static LPLMBEAJACA<TData> JHMOIFLKJAD<TData>(string FNFIPKNHEOF, [In] TData PEDMEJIDLNB) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class IEGGCNFIJCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	internal bool IFCBBEDEBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly string AOBEBIODMPJ;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xED8C90", Offset = "0xED7890", VA = "0x180ED8C90")]
	private IEGGCNFIJCN(bool MFGBCOKEFEA, string CJFPMPGBBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7F2DB00", Offset = "0x7F2C700", VA = "0x187F2DB00")]
	public static IEGGCNFIJCN JHMOIFLKJAD(string CJFPMPGBBEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7F2DA40", Offset = "0x7F2C640", VA = "0x187F2DA40")]
	public GJBBNLLHHMB IHDNCFODHOF()
	{
		return default(GJBBNLLHHMB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct GJBBNLLHHMB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly IEGGCNFIJCN PJEDOJBGBKP;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xDCEEA0", Offset = "0xDCDAA0", VA = "0x180DCEEA0")]
	internal GJBBNLLHHMB(IEGGCNFIJCN CBLPKFIJGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D130", Offset = "0x7F2BD30", VA = "0x187F2D130", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class NMPDAGDOIOA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class BPJEGCHEBCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public BPJEGCHEBCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x66250E0", Offset = "0x6623CE0", VA = "0x1866250E0")]
		internal int FAMFOGMNALH(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private HashSet<T>? ODHEMJNDBGD;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IReadOnlyCollection<T> IEFJDLGHPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x55365E0", Offset = "0x55351E0", VA = "0x1855365E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool GDGEOICOELD
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x55363E0", Offset = "0x5534FE0", VA = "0x1855363E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int OJAJOFHLGMI
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA217D0", Offset = "0xA203D0", VA = "0x180A217D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA21F20", Offset = "0xA20B20", VA = "0x180A21F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5536610", Offset = "0x5535210", VA = "0x185536610")]
	public bool NKAMMCABBBC(T HEDGIMBCGHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5536450", Offset = "0x5535050", VA = "0x185536450")]
	public bool HMCNGGMNMHK(T HEDGIMBCGHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5536410", Offset = "0x5535010", VA = "0x185536410")]
	public bool FHKFJOGHNEN(T HEDGIMBCGHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5536560", Offset = "0x5535160", VA = "0x185536560")]
	public void IJKNENALGIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5536760", Offset = "0x5535360", VA = "0x185536760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public NMPDAGDOIOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class MAHLEDFAIAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class EAMELFBEKGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public EAMELFBEKGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7F2C480", Offset = "0x7F2B080", VA = "0x187F2C480")]
		internal int FAMFOGMNALH(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private HashSet<object>? ODHEMJNDBGD;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyCollection<object> IEFJDLGHPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7F2E8B0", Offset = "0x7F2D4B0", VA = "0x187F2E8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool GDGEOICOELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7F2E730", Offset = "0x7F2D330", VA = "0x187F2E730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int OJAJOFHLGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA217D0", Offset = "0xA203D0", VA = "0x180A217D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA21F20", Offset = "0xA20B20", VA = "0x180A21F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7F2E940", Offset = "0x7F2D540", VA = "0x187F2E940")]
	public bool NKAMMCABBBC(object HEDGIMBCGHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7F2E7A0", Offset = "0x7F2D3A0", VA = "0x187F2E7A0")]
	public bool HMCNGGMNMHK(object HEDGIMBCGHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7F2E740", Offset = "0x7F2D340", VA = "0x187F2E740")]
	public bool FHKFJOGHNEN(object HEDGIMBCGHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7F2E840", Offset = "0x7F2D440", VA = "0x187F2E840")]
	public void IJKNENALGIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7F2EA20", Offset = "0x7F2D620", VA = "0x187F2EA20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public MAHLEDFAIAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class ANHMNNEGMOL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private struct IHFKFDBAKGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float AMFDDLCPOOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public T IOOEMCNJEAH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<object, IHFKFDBAKGE> NJHNNBNFCIE;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public virtual T NBAJEEHPNEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x115C290", Offset = "0x115AE90", VA = "0x18115C290", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1AE2930", Offset = "0x1AE1530", VA = "0x181AE2930", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public object? BBOLCJIAKJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA21F10", Offset = "0xA20B10", VA = "0x180A21F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA217E0", Offset = "0xA203E0", VA = "0x180A217E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool MMGKOLPFCLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x42D3570", Offset = "0x42D2170", VA = "0x1842D3570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x506CAD0", Offset = "0x506B6D0", VA = "0x18506CAD0")]
	public bool BIOPACEHAJG(T OOHGFGHCOAJ, object HEDGIMBCGHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x42D34E0", Offset = "0x42D20E0", VA = "0x1842D34E0")]
	public bool HELGMGPDIFN(object HEDGIMBCGHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x42D3540", Offset = "0x42D2140", VA = "0x1842D3540")]
	public void ILJKHADAMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x506E770", Offset = "0x506D370", VA = "0x18506E770")]
	public bool GFPOIIGIKGC(object HEDGIMBCGHA, [Out] T OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x506CFB0", Offset = "0x506BBB0", VA = "0x18506CFB0")]
	[PBCDFBCKEKM("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool CHDBAODMJFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x506E830", Offset = "0x506D430", VA = "0x18506E830")]
	public ANHMNNEGMOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class GBFAAIHLHHB : BINLKNCDJEL<ADHEHODAAFN>
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	internal class HMEKEHMJMGA : IEqualityComparer<ADHEHODAAFN>
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		internal static readonly HMEKEHMJMGA LBPNLDGACAA;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7F2D9B0", Offset = "0x7F2C5B0", VA = "0x187F2D9B0", Slot = "4")]
		public bool Equals(ADHEHODAAFN KFGAJBKADFK, ADHEHODAAFN FEABMDLFEMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7056810", Offset = "0x7055410", VA = "0x187056810", Slot = "5")]
		public int GetHashCode(ADHEHODAAFN KDKJDFFGNJJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public HMEKEHMJMGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D0C0", Offset = "0x7F2BCC0", VA = "0x187F2D0C0")]
	public GBFAAIHLHHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D010", Offset = "0x7F2BC10", VA = "0x187F2D010", Slot = "4")]
	public override bool NKAMMCABBBC(ADHEHODAAFN HEDGIMBCGHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7F2CED0", Offset = "0x7F2BAD0", VA = "0x187F2CED0", Slot = "5")]
	public override bool HMCNGGMNMHK(ADHEHODAAFN HEDGIMBCGHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7F2CF80", Offset = "0x7F2BB80", VA = "0x187F2CF80")]
	private static void KDMAOFFHCGA(ADHEHODAAFN HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0xA84220", Offset = "0xA82E20", VA = "0x180A84220", Slot = "6")]
	protected override string TokenToString(ADHEHODAAFN HEDGIMBCGHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class ADHEHODAAFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly string EFBNOPEDAII;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
	public ADHEHODAAFN(string EFBNOPEDAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7F2C2F0", Offset = "0x7F2AEF0", VA = "0x187F2C2F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public abstract class BINLKNCDJEL<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly IEqualityComparer<T> DIMPLJBNCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private HashSet<T>? ODHEMJNDBGD;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public IReadOnlyCollection<T> IEFJDLGHPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x64753A0", Offset = "0x6473FA0", VA = "0x1864753A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool GDGEOICOELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x55363E0", Offset = "0x5534FE0", VA = "0x1855363E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int OJAJOFHLGMI
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA768B0", Offset = "0xA754B0", VA = "0x180A768B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xA76890", Offset = "0xA75490", VA = "0x180A76890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6475C40", Offset = "0x6474840", VA = "0x186475C40")]
	public BINLKNCDJEL(IEqualityComparer<T> DIMPLJBNCJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x64753D0", Offset = "0x6473FD0", VA = "0x1864753D0", Slot = "4")]
	public virtual bool NKAMMCABBBC(T HEDGIMBCGHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6475100", Offset = "0x6473D00", VA = "0x186475100", Slot = "5")]
	public virtual bool HMCNGGMNMHK(T HEDGIMBCGHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6475320", Offset = "0x6473F20", VA = "0x186475320")]
	public void IJKNENALGIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x64756A0", Offset = "0x64742A0", VA = "0x1864756A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class OOMLIBALPOA<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private List<WeakReference<T>>? ODHEMJNDBGD;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool GDGEOICOELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x56996A0", Offset = "0x56982A0", VA = "0x1856996A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int OJAJOFHLGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5699A00", Offset = "0x5698600", VA = "0x185699A00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5699B40", Offset = "0x5698740", VA = "0x185699B40")]
	public void NKAMMCABBBC(T HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x56998A0", Offset = "0x56984A0", VA = "0x1856998A0")]
	public void HMCNGGMNMHK(T HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5699790", Offset = "0x5698390", VA = "0x185699790")]
	public bool FHKFJOGHNEN(T HEDGIMBCGHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x56999E0", Offset = "0x56985E0", VA = "0x1856999E0")]
	public void IJKNENALGIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5699D40", Offset = "0x5698940", VA = "0x185699D40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public OOMLIBALPOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal static class KEKLHHFBFIE
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x38A5390", Offset = "0x38A3F90", VA = "0x1838A5390")]
	public static void ACCOGIPAHCG<T>(this List<T> DNNGKIFFAHG, int EMMACFPOKFB) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class DOIKPGGODFC<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct OFAENJMACHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public float AMFDDLCPOOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T IOOEMCNJEAH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Dictionary<ADHEHODAAFN, OFAENJMACHM> NJHNNBNFCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly EqualityComparer<T> KGEDPIKGNGD;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public virtual T NBAJEEHPNEI
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA247B0", Offset = "0xA233B0", VA = "0x180A247B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA24660", Offset = "0xA23260", VA = "0x180A24660", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private ADHEHODAAFN? BBOLCJIAKJL
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA27D40", Offset = "0xA26940", VA = "0x180A27D40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool MMGKOLPFCLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x42D3570", Offset = "0x42D2170", VA = "0x1842D3570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x42D2DD0", Offset = "0x42D19D0", VA = "0x1842D2DD0")]
	public bool BIOPACEHAJG(T OOHGFGHCOAJ, ADHEHODAAFN HEDGIMBCGHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x42D34E0", Offset = "0x42D20E0", VA = "0x1842D34E0")]
	public bool HELGMGPDIFN(ADHEHODAAFN HEDGIMBCGHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x42D3540", Offset = "0x42D2140", VA = "0x1842D3540")]
	public void ILJKHADAMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x42D3470", Offset = "0x42D2070", VA = "0x1842D3470")]
	public bool GFPOIIGIKGC(ADHEHODAAFN HEDGIMBCGHA, [Out] T OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x42D2EB0", Offset = "0x42D1AB0", VA = "0x1842D2EB0")]
	[PBCDFBCKEKM("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool CHDBAODMJFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x42D35B0", Offset = "0x42D21B0", VA = "0x1842D35B0")]
	public DOIKPGGODFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class KKPMPBJELJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Dictionary<object, float> NJHNNBNFCIE;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float FHGIIEJKPOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA70670", Offset = "0xA6F270", VA = "0x180A70670")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x12A06A0", Offset = "0x129F2A0", VA = "0x1812A06A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7F2E370", Offset = "0x7F2CF70", VA = "0x187F2E370")]
	public void BIOPACEHAJG(float OOHGFGHCOAJ, object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7F2E3E0", Offset = "0x7F2CFE0", VA = "0x187F2E3E0")]
	public void HELGMGPDIFN(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7F2E450", Offset = "0x7F2D050", VA = "0x187F2E450")]
	public void ILJKHADAMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7F2E4A0", Offset = "0x7F2D0A0", VA = "0x187F2E4A0")]
	private void LEFHPMEMEEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7F2E5D0", Offset = "0x7F2D1D0", VA = "0x187F2E5D0")]
	public KKPMPBJELJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface PAJJIFDECGF
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event ADPJAAAHAMD MNKFJJJOAKC;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class FGLHPFEEAKO : PAJJIFDECGF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public readonly struct JGMHFIOLGHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly float KDHJHGHKFGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly float GEEOJDFCKDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal readonly bool JICHDGIBAGD;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float LEKJCANHPNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x7F2DF10", Offset = "0x7F2CB10", VA = "0x187F2DF10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7F2E080", Offset = "0x7F2CC80", VA = "0x187F2E080")]
		public JGMHFIOLGHM(float EILAIOEPAPK, float NHCGLFAFCAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7F2DF20", Offset = "0x7F2CB20", VA = "0x187F2DF20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class CNOGEEDMDAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public FGLHPFEEAKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public CNOGEEDMDAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7F2C3E0", Offset = "0x7F2AFE0", VA = "0x187F2C3E0")]
		internal void MLDGPIBMKOK(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int PDJAEHLNOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int BCAHJFDPCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly PAJJIFDECGF[] POOIIIFFBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly ADPJAAAHAMD[] ECPFHMDENEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly JGMHFIOLGHM[] BCLDMFNBJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private JGMHFIOLGHM CCNAEFFOPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly JAEEODMGAEH GDCFPFDKNJG;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event ADPJAAAHAMD MNKFJJJOAKC
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7F2C5B0", Offset = "0x7F2B1B0", VA = "0x187F2C5B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CC80", Offset = "0x7F2B880", VA = "0x187F2CC80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7F2CD40", Offset = "0x7F2B940", VA = "0x187F2CD40")]
	public FGLHPFEEAKO(int PDJAEHLNOAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7F2C780", Offset = "0x7F2B380", VA = "0x187F2C780")]
	public JAEEODMGAEH IFHJLLOOKPI(JGMHFIOLGHM BNCKDCNKIDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7F2C810", Offset = "0x7F2B410", VA = "0x187F2C810")]
	public void JOAMJBJNBPN(PAJJIFDECGF PBGAIMLAFKE, [Optional] JGMHFIOLGHM OCNBNMOPBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7F2C670", Offset = "0x7F2B270", VA = "0x187F2C670", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate void ADPJAAAHAMD(float LKKJBKDJEBD);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class JFLDKMGOHGF
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class GPGDNMOHCGG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly PAJJIFDECGF GENHEGDKKGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly ADPJAAAHAMD LKGGIMHKLEG;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7F2D600", Offset = "0x7F2C200", VA = "0x187F2D600")]
		public GPGDNMOHCGG(PAJJIFDECGF GENHEGDKKGM, ADPJAAAHAMD LKGGIMHKLEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7F2D5B0", Offset = "0x7F2C1B0", VA = "0x187F2D5B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7F2DDE0", Offset = "0x7F2C9E0", VA = "0x187F2DDE0")]
	internal static bool EAICOLOLOFH(float ABBBJFPFEKP, float KLKIJPOLHDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7F1EA70", Offset = "0x7F1D670", VA = "0x187F1EA70")]
	internal static float DDJDJOAIGLN(float ABBBJFPFEKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7F2DE50", Offset = "0x7F2CA50", VA = "0x187F2DE50")]
	public static IDisposable KHGOICMAEOJ(this PAJJIFDECGF GENHEGDKKGM, ADPJAAAHAMD LKGGIMHKLEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class JAEEODMGAEH : PAJJIFDECGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float LKKJBKDJEBD;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public float GDPADHPNPLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7F2DC50", Offset = "0x7F2C850", VA = "0x187F2DC50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event ADPJAAAHAMD? MNKFJJJOAKC
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7F2DBB0", Offset = "0x7F2C7B0", VA = "0x187F2DBB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7F2DD40", Offset = "0x7F2C940", VA = "0x187F2DD40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public JAEEODMGAEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface LMMCHLJJDNI<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ECLCBBHPFMF<T> JOCLKIICIAK([Out] T OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ILJKHADAMOK();
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class BELKPHLHPBO<T> : LMMCHLJJDNI<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly ConcurrentStack<T> FFBKKKJENHA;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x62B2320", Offset = "0x62B0F20", VA = "0x1862B2320", Slot = "4")]
	public ECLCBBHPFMF<T> JOCLKIICIAK([Out] T OOHGFGHCOAJ)
	{
		return default(ECLCBBHPFMF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x62B22C0", Offset = "0x62B0EC0", VA = "0x1862B22C0")]
	public void FLLBKAADJOO(T MNHIHNPEMOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x62B1D60", Offset = "0x62B0960", VA = "0x1862B1D60", Slot = "5")]
	public void ILJKHADAMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "6")]
	protected virtual void ABJKHPIGJOM(T OOBHMHBKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x62B23B0", Offset = "0x62B0FB0", VA = "0x1862B23B0")]
	private T LBDBFELEJGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x62B2430", Offset = "0x62B1030", VA = "0x1862B2430")]
	public BELKPHLHPBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct ECLCBBHPFMF<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly T MNHIHNPEMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly BELKPHLHPBO<T> CDMBMKNDFHF;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0xB5F450", Offset = "0xB5E050", VA = "0x180B5F450")]
	internal ECLCBBHPFMF(T OOHGFGHCOAJ, BELKPHLHPBO<T> CDMBMKNDFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x471A280", Offset = "0x4718E80", VA = "0x18471A280", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class JHENMADAKFJ : BELKPHLHPBO<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static readonly JHENMADAKFJ LBPNLDGACAA;

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7F2E200", Offset = "0x7F2CE00", VA = "0x187F2E200")]
	public static ECLCBBHPFMF<StringBuilder> LBDBFELEJGA([Out] StringBuilder OOHGFGHCOAJ)
	{
		return default(ECLCBBHPFMF<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x7F2E1E0", Offset = "0x7F2CDE0", VA = "0x187F2E1E0", Slot = "6")]
	protected override void ABJKHPIGJOM(StringBuilder OOBHMHBKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x7F2E330", Offset = "0x7F2CF30", VA = "0x187F2E330")]
	public JHENMADAKFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class HEKLBHGMFNF : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x77B0790", Offset = "0x77AF390", VA = "0x1877B0790")]
	public HEKLBHGMFNF(string FNFIPKNHEOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DefaultMember("Item")]
public class LCJKNPINEJJ<TKey, TValue> : MMLCCKPIBLK<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, AOIGIJAMLGP where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class LDBLJCCCHEO : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public LCJKNPINEJJ<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x115C290", Offset = "0x115AE90", VA = "0x18115C290", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x4C9E630", Offset = "0x4C9D230", VA = "0x184C9E630", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		[DebuggerHidden]
		public LDBLJCCCHEO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4C9E7D0", Offset = "0x4C9D3D0", VA = "0x184C9E7D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5282940", Offset = "0x5281540", VA = "0x185282940", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x52823C0", Offset = "0x5280FC0", VA = "0x1852823C0")]
		private void HOIHHFKDFKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x52824B0", Offset = "0x52810B0", VA = "0x1852824B0")]
		private void JKFKJAKKDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x5283100", Offset = "0x5281D00", VA = "0x185283100", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly MMLCCKPIBLK<TKey, TValue> KJAMCFPKMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IDictionary<TKey, TValue> KBBNOINCAHN;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int OJAJOFHLGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x52811F0", Offset = "0x527FDF0", VA = "0x1852811F0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool KKNAEFNJMGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public TValue HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x5281480", Offset = "0x5280080", VA = "0x185281480", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x52816C0", Offset = "0x52802C0", VA = "0x1852816C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICollection<TKey> PJAGCIOFNKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x52814C0", Offset = "0x52800C0", VA = "0x1852814C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public ICollection<TValue> LJCBAOPLEFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x52815C0", Offset = "0x52801C0", VA = "0x1852815C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x5281140", Offset = "0x527FD40", VA = "0x185281140")]
	public LCJKNPINEJJ(MMLCCKPIBLK<TKey, TValue> KJAMCFPKMBC, [Optional] IDictionary<TKey, TValue>? KBBNOINCAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x527EB80", Offset = "0x527D780", VA = "0x18527EB80", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x5280420", Offset = "0x527F020", VA = "0x185280420")]
	public void PLFOONIHAHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x527E6E0", Offset = "0x527D2E0", VA = "0x18527E6E0", Slot = "9")]
	public void Add(TKey MEPFFFGIFGB, TValue OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x527F6C0", Offset = "0x527E2C0", VA = "0x18527F6C0")]
	public void IGIEHHCHEHF(TKey MEPFFFGIFGB, TValue OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x52800A0", Offset = "0x527ECA0", VA = "0x1852800A0")]
	public void KCLBOEMKECJ(TKey MEPFFFGIFGB, TValue OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x527FD30", Offset = "0x527E930", VA = "0x18527FD30")]
	public void JCPLNBOCIJG(TKey MEPFFFGIFGB, TValue OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x527F8D0", Offset = "0x527E4D0", VA = "0x18527F8D0")]
	public void IHEKPLNPNPO(TKey MEPFFFGIFGB, TValue OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x52807C0", Offset = "0x527F3C0", VA = "0x1852807C0", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> ONKLOOMCJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5280810", Offset = "0x527F410", VA = "0x185280810", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x5280B70", Offset = "0x527F770", VA = "0x185280B70", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x527EBF0", Offset = "0x527D7F0", VA = "0x18527EBF0", Slot = "8")]
	public bool ContainsKey(TKey MEPFFFGIFGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x527F410", Offset = "0x527E010", VA = "0x18527F410")]
	public bool EMPGBBIOHDF(TKey MEPFFFGIFGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5280360", Offset = "0x527EF60", VA = "0x185280360")]
	public bool KGENCLJKELE(TKey MEPFFFGIFGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x5280560", Offset = "0x527F160", VA = "0x185280560", Slot = "10")]
	public bool Remove(TKey MEPFFFGIFGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5280FA0", Offset = "0x527FBA0", VA = "0x185280FA0", Slot = "11")]
	public bool TryGetValue(TKey MEPFFFGIFGB, [Out] TValue OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x527EF50", Offset = "0x527DB50", VA = "0x18527EF50", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] IKALPCJBCLK, int CEPNAODLCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x51A2640", Offset = "0x51A1240", VA = "0x1851A2640", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x527F4D0", Offset = "0x527E0D0", VA = "0x18527F4D0", Slot = "19")]
	[IteratorStateMachine(typeof(LCJKNPINEJJ<, >.LDBLJCCCHEO))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5280510", Offset = "0x527F110", VA = "0x185280510", Slot = "21")]
	public bool POHLMLONMPN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x527F970", Offset = "0x527E570", VA = "0x18527F970")]
	private TValue JAMBCAAAKCG(TKey MEPFFFGIFGB)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface KJJPICKHKDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string OBNBKHPGKME
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface AOIGIJAMLGP
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool POHLMLONMPN();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface MMLCCKPIBLK<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, AOIGIJAMLGP
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[DefaultMember("Item")]
public sealed class BFMIMIINNAC<TKey, TVal> : MMLCCKPIBLK<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, AOIGIJAMLGP where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public delegate int OGCAKOBGIFN(TKey MEPFFFGIFGB, TVal OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate void NJCJDIJOIAI(TKey MEPFFFGIFGB, TVal OOHGFGHCOAJ, LDIGKLBOEIG HGJBCNEJGLD);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class GCHKGCMPABH
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public TKey JOMDPKHKCFP
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xDDC970", Offset = "0xDDB570", VA = "0x180DDC970")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public TVal IOOEMCNJEAH
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xA768B0", Offset = "0xA754B0", VA = "0x180A768B0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xA76890", Offset = "0xA75490", VA = "0x180A76890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public int LEKJCANHPNN
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xBDFF80", Offset = "0xBDEB80", VA = "0x180BDFF80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xF7D730", Offset = "0xF7C330", VA = "0x180F7D730")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public DateTimeOffset EJJFIDBDDKI
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x12E9310", Offset = "0x12E7F10", VA = "0x1812E9310")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x13F4850", Offset = "0x13F3450", VA = "0x1813F4850")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x4D06CD0", Offset = "0x4D058D0", VA = "0x184D06CD0")]
		public GCHKGCMPABH(TKey MEPFFFGIFGB, TVal AGKJLFOJIKC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class CHBAMJDFNOF : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public BFMIMIINNAC<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private LinkedList<GCHKGCMPABH>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x115C290", Offset = "0x115AE90", VA = "0x18115C290", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x694A350", Offset = "0x6948F50", VA = "0x18694A350", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		[DebuggerHidden]
		public CHBAMJDFNOF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x42C4100", Offset = "0x42C2D00", VA = "0x1842C4100", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6947CD0", Offset = "0x69468D0", VA = "0x186947CD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x69479C0", Offset = "0x69465C0", VA = "0x1869479C0")]
		private void HOIHHFKDFKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x694A030", Offset = "0x6948C30", VA = "0x18694A030", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public const int JIIHMOCJFCI = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly Dictionary<TKey, LinkedListNode<GCHKGCMPABH>> FMKHJBPIGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly LinkedList<GCHKGCMPABH> LMJCAIBHGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly OGCAKOBGIFN? KMCDBNCMOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly TimeSpan LJCIIFBLAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly NJCJDIJOIAI? MGMBDDFMAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly KDAAJHGJFCF GMFACOHDAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool EJIGIPMHFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly List<TKey> AONDBNOFBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly List<TVal> GCIAOIBHHLG;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int HFMPIJBIBOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xC96C30", Offset = "0xC95830", VA = "0x180C96C30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	internal int HEKLIKMNBDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xDD35B0", Offset = "0xDD21B0", VA = "0x180DD35B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xF0E2C0", Offset = "0xF0CEC0", VA = "0x180F0E2C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int OJAJOFHLGMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x62C53A0", Offset = "0x62C3FA0", VA = "0x1862C53A0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	internal int PFMBHBDLKCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4B88870", Offset = "0x4B87470", VA = "0x184B88870")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public ICollection<TVal> LJCBAOPLEFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x62C5480", Offset = "0x62C4080", VA = "0x1862C5480", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	ICollection<TKey> IDictionary<TKey, TVal>.AOBHKPHKFDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x62C1EE0", Offset = "0x62C0AE0", VA = "0x1862C1EE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool KKNAEFNJMGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public TVal HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x62C53F0", Offset = "0x62C3FF0", VA = "0x1862C53F0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x62C54B0", Offset = "0x62C40B0", VA = "0x1862C54B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x62BA1F0", Offset = "0x62B8DF0", VA = "0x1862BA1F0")]
	private bool FKOJCAEMLDK(int PDJAEHLNOAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x62B67E0", Offset = "0x62B53E0", VA = "0x1862B67E0")]
	private void BFENELNDOOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x62C2920", Offset = "0x62C1520", VA = "0x1862C2920")]
	public BFMIMIINNAC(int PDJAEHLNOAH, [Optional] OGCAKOBGIFN? KMCDBNCMOOI, [Optional] IEqualityComparer<TKey>? PBJDFIPJAEK, [Optional] NJCJDIJOIAI? MGMBDDFMAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x62C2DD0", Offset = "0x62C19D0", VA = "0x1862C2DD0")]
	public BFMIMIINNAC(TimeSpan LJCIIFBLAAP, [Optional] IEqualityComparer<TKey>? PBJDFIPJAEK, [Optional] NJCJDIJOIAI? MGMBDDFMAOO, [Optional] KDAAJHGJFCF? GMFACOHDAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x62C28D0", Offset = "0x62C14D0", VA = "0x1862C28D0")]
	public BFMIMIINNAC(int PDJAEHLNOAH, TimeSpan LJCIIFBLAAP, [Optional] IEqualityComparer<TKey>? PBJDFIPJAEK, [Optional] NJCJDIJOIAI? MGMBDDFMAOO, [Optional] KDAAJHGJFCF? GMFACOHDAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x62C4590", Offset = "0x62C3190", VA = "0x1862C4590")]
	public BFMIMIINNAC(int PDJAEHLNOAH, OGCAKOBGIFN? KMCDBNCMOOI, TimeSpan LJCIIFBLAAP, [Optional] IEqualityComparer<TKey>? PBJDFIPJAEK, [Optional] NJCJDIJOIAI? MGMBDDFMAOO, [Optional] KDAAJHGJFCF? GMFACOHDAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x62C1100", Offset = "0x62BFD00", VA = "0x1862C1100", Slot = "21")]
	public bool POHLMLONMPN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x62BA630", Offset = "0x62B9230", VA = "0x1862BA630", Slot = "22")]
	public bool HNBPPKAOGPC(int DKFJGBGJGBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x62B51E0", Offset = "0x62B3DE0", VA = "0x1862B51E0")]
	private bool AGIKNKDNFFM(int DKFJGBGJGBG, LDIGKLBOEIG HGJBCNEJGLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x62C00B0", Offset = "0x62BECB0", VA = "0x1862C00B0")]
	public void PEPEIECOOBP(TKey MEPFFFGIFGB, TVal OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x62B66A0", Offset = "0x62B52A0", VA = "0x1862B66A0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> ONKLOOMCJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x62B6560", Offset = "0x62B5160", VA = "0x1862B6560", Slot = "9")]
	public void Add(TKey MEPFFFGIFGB, TVal OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x62B8400", Offset = "0x62B7000", VA = "0x1862B8400", Slot = "8")]
	public bool ContainsKey(TKey MEPFFFGIFGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x62C19A0", Offset = "0x62C05A0", VA = "0x1862C19A0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x62C1520", Offset = "0x62C0120", VA = "0x1862C1520", Slot = "10")]
	public bool Remove(TKey MEPFFFGIFGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x62C1B70", Offset = "0x62C0770", VA = "0x1862C1B70", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x62C0B20", Offset = "0x62BF720", VA = "0x1862C0B20")]
	private bool PMIGKCFKJGL(TKey MEPFFFGIFGB, [Out] TVal OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x62BD060", Offset = "0x62BBC60", VA = "0x1862BD060")]
	private TVal LBDBFELEJGA(TKey DBGCCCIOHHI)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x62C1F40", Offset = "0x62C0B40", VA = "0x1862C1F40", Slot = "11")]
	public bool TryGetValue(TKey DBGCCCIOHHI, [Out] TVal OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x62B82C0", Offset = "0x62B6EC0", VA = "0x1862B82C0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x62B9870", Offset = "0x62B8470", VA = "0x1862B9870", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] IKALPCJBCLK, int CEPNAODLCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x62BEBE0", Offset = "0x62BD7E0", VA = "0x1862BEBE0")]
	private void MNIMNLEOBFK(TKey MEPFFFGIFGB, TVal AGKJLFOJIKC, LDIGKLBOEIG HGJBCNEJGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x62BE350", Offset = "0x62BCF50", VA = "0x1862BE350")]
	private bool LJGPEEACGOC(GCHKGCMPABH IDECMBHDEKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x62BCB20", Offset = "0x62BB720", VA = "0x1862BCB20")]
	private void IMNEKDLFEGN(LinkedListNode<GCHKGCMPABH> NMDDLMACBEF, TVal LFLPFMMDGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x62B6BD0", Offset = "0x62B57D0", VA = "0x1862B6BD0")]
	private void BIOPACEHAJG(TKey MEPFFFGIFGB, TVal OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x62BF150", Offset = "0x62BDD50", VA = "0x1862BF150")]
	private void NMGMNMDILJK(GCHKGCMPABH IDECMBHDEKM, TVal LFLPFMMDGLM, int ICICAMAEDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x62BA240", Offset = "0x62B8E40", VA = "0x1862BA240", Slot = "19")]
	[IteratorStateMachine(typeof(BFMIMIINNAC<, >.CHBAMJDFNOF))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x62C1F10", Offset = "0x62C0B10", VA = "0x1862C1F10", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public enum LDIGKLBOEIG : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class BOGBOKPOHDK<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly TKey NFNPKENJGNL;

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x661EF10", Offset = "0x661DB10", VA = "0x18661EF10")]
	public BOGBOKPOHDK(TKey ONAMLLHJKJL, Exception HADEDFDJMNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class IBKNEICDLFA : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9EC0", Offset = "0x6FE8AC0", VA = "0x186FE9EC0")]
	public IBKNEICDLFA(string FNFIPKNHEOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class BPCCLLICIFH<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class CLAFICFEDMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public BPCCLLICIFH<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public CLAFICFEDMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x69899C0", Offset = "0x69885C0", VA = "0x1869899C0")]
		internal Task<TResource> EELEDHDMFAN(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct KDMPJAHKMGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public BPCCLLICIFH<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x51D2820", Offset = "0x51D1420", VA = "0x1851D2820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x51D3380", Offset = "0x51D1F80", VA = "0x1851D3380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct MLCNBGLKBDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x54C6480", Offset = "0x54C5080", VA = "0x1854C6480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x54C6850", Offset = "0x54C5450", VA = "0x1854C6850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly INIDJOGDLOF<TId, Task<TResource>> KDGFPHGBLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> BBGHAAKBLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? NGHCAEFEBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Action<TResource>? LOFEJACHDOF;

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6622400", Offset = "0x6621000", VA = "0x186622400")]
	public BPCCLLICIFH(int NAFCJAHNOKE = 0, [Optional] IEqualityComparer<TId>? MHNKPGKJHLP, [Optional] Func<TId, CancellationToken, Task<TResource>>? JIJMBHEPKMI, [Optional] Action<TResource>? PALBPAJNDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6621570", Offset = "0x6620170", VA = "0x186621570")]
	public BDNPFNHIMPF<Task<TResource>> HEBIJECOELL(TId ALPNKEJICNA, [Optional] Func<TId, CancellationToken, Task<TResource>>? JIJMBHEPKMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6621A40", Offset = "0x6620640", VA = "0x186621A40")]
	private void NKHLLJLLELB(Task<TResource> NKDMFOKACBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6622140", Offset = "0x6620D40", VA = "0x186622140")]
	[AsyncStateMachine(typeof(BPCCLLICIFH<, >.KDMPJAHKMGN))]
	private Task OBFDIAIAKGE(Task<TResource> NKDMFOKACBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x66218C0", Offset = "0x66204C0", VA = "0x1866218C0")]
	public void HIKFPKHNMOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6621960", Offset = "0x6620560", VA = "0x186621960")]
	public INIDJOGDLOF<TId, Task<TResource>>.AJBEMANGMIP MEEEBEDBKAB()
	{
		return default(INIDJOGDLOF<TId, Task<TResource>>.AJBEMANGMIP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6622370", Offset = "0x6620F70", VA = "0x186622370", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6622370", Offset = "0x6620F70", VA = "0x186622370", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6620FE0", Offset = "0x661FBE0", VA = "0x186620FE0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(BPCCLLICIFH<, >.MLCNBGLKBDN))]
	internal static Task CLMLBALMEDM(Task<TResource> NKDMFOKACBI, CancellationTokenSource CMAEPNBICHI, Dictionary<Task<TResource>, CancellationTokenSource> LCEPPHNOADD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class INIDJOGDLOF<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class GGGDFEHDEKG : IEquatable<GGGDFEHDEKG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public readonly TValue IOOEMCNJEAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int IBKPKMPLLDL;

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x124AD70", Offset = "0x1249970", VA = "0x18124AD70")]
		public GGGDFEHDEKG(TValue OOHGFGHCOAJ, int CLHFIIMJCLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x4D0F180", Offset = "0x4D0DD80", VA = "0x184D0F180", Slot = "4")]
		public bool Equals(GGGDFEHDEKG? GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x4D0F0F0", Offset = "0x4D0DCF0", VA = "0x184D0F0F0", Slot = "0")]
		public override bool Equals(object? KDKJDFFGNJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4D0F300", Offset = "0x4D0DF00", VA = "0x184D0F300", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public struct AJBEMANGMIP : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Dictionary<TKey, GGGDFEHDEKG>.Enumerator ICIIAGFODKB;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x4F77360", Offset = "0x4F75F60", VA = "0x184F77360", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public (TKey Key, TValue Value, int RefCount) FGILBCMPPDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x4F77640", Offset = "0x4F76240", VA = "0x184F77640", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x4F77400", Offset = "0x4F76000", VA = "0x184F77400")]
		public AJBEMANGMIP(INIDJOGDLOF<TKey, TValue> NJHNNBNFCIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x4F76E70", Offset = "0x4F75A70", VA = "0x184F76E70", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x4F76EB0", Offset = "0x4F75AB0", VA = "0x184F76EB0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x4F770C0", Offset = "0x4F75CC0", VA = "0x184F770C0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class KOLLBAPAMFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public INIDJOGDLOF<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public GGGDFEHDEKG refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public KOLLBAPAMFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x52038B0", Offset = "0x52024B0", VA = "0x1852038B0")]
		internal void EELEDHDMFAN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<TKey, GGGDFEHDEKG> ODPDAJEMIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Func<TKey, TValue>? OHGFLFBBBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TValue>? JIBMCJLONJM;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x4E844E0", Offset = "0x4E830E0", VA = "0x184E844E0")]
	public INIDJOGDLOF(int NAFCJAHNOKE = 0, [Optional] IEqualityComparer<TKey>? PBJDFIPJAEK, [Optional] Func<TKey, TValue>? NHKJCNDCHGG, [Optional] Action<TValue>? BBOALBMIPGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4E834C0", Offset = "0x4E820C0", VA = "0x184E834C0")]
	public BDNPFNHIMPF<TValue> HEBIJECOELL(TKey MEPFFFGIFGB, [Optional] Func<TKey, TValue>? LALINCNCCIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x4E82F30", Offset = "0x4E81B30", VA = "0x184E82F30")]
	private void FLLBKAADJOO(TKey MEPFFFGIFGB, GGGDFEHDEKG AOKKFBBNMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x4E83EA0", Offset = "0x4E82AA0", VA = "0x184E83EA0")]
	public void HIKFPKHNMOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4E842A0", Offset = "0x4E82EA0", VA = "0x184E842A0")]
	public AJBEMANGMIP MEEEBEDBKAB()
	{
		return default(AJBEMANGMIP);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x4E84320", Offset = "0x4E82F20", VA = "0x184E84320", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4E84320", Offset = "0x4E82F20", VA = "0x184E84320", Slot = "5")]
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
