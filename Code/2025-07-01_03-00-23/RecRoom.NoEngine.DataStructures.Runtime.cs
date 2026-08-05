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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0x8112D60", Offset = "0x8111360", VA = "0x188112D60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA705D0", Offset = "0xA6EBD0", VA = "0x180A705D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA70610", Offset = "0xA6EC10", VA = "0x180A70610")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class BOAHDINNDOB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	protected BOAHDINNDOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class DOMNOINLHEA<T> : BOAHDINNDOB
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct NJJPMFPHIMB
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum HFHEGMBLEBK
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
		public HFHEGMBLEBK JLPANLJHHFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T CJDOILFHDJI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int ILCNJCCHGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool IGHOMICJIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool APNLKJMLHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? DJONDAHINFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<NJJPMFPHIMB>? ELEOECGBMHJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool EKJMJKJLGHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6D3AA60", Offset = "0x6D39060", VA = "0x186D3AA60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6D3AFC0", Offset = "0x6D395C0", VA = "0x186D3AFC0")]
	protected DOMNOINLHEA(bool APNLKJMLHFF, bool IGHOMICJIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6D3AF20", Offset = "0x6D39520", VA = "0x186D3AF20")]
	protected bool KAAHGLEFKOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6D3AAB0", Offset = "0x6D390B0", VA = "0x186D3AAB0")]
	protected void GNOECJCCGJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6D3A880", Offset = "0x6D38E80", VA = "0x186D3A880")]
	protected void EPCBJKMKOFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3D8D980", Offset = "0x3D8BF80", VA = "0x183D8D980")]
	private static void EFOJIPLENFA<U>(List<U>? BGGFBGFNIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6D3AD40", Offset = "0x6D39340", VA = "0x186D3AD40", Slot = "4")]
	public void JDPCENHCAFL(T CJDOILFHDJI, bool CGMPNMELEAO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6D3A6C0", Offset = "0x6D38CC0", VA = "0x186D3A6C0", Slot = "5")]
	public void BAFGFGCDOJB(T CJDOILFHDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6D3ABC0", Offset = "0x6D391C0", VA = "0x186D3ABC0")]
	public void HHCEOPNNHLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class LGEBFGGIOJB : DOMNOINLHEA<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8112C50", Offset = "0x8111250", VA = "0x188112C50")]
	public LGEBFGGIOJB(bool APNLKJMLHFF = false, bool IGHOMICJIMI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x81129F0", Offset = "0x8110FF0", VA = "0x1881129F0")]
	public void GHDKDALNEMC()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8112BF0", Offset = "0x81111F0", VA = "0x188112BF0")]
	public static LGEBFGGIOJB PEDIBFNHHHB(LGEBFGGIOJB HBHNBNCHAIB, Action CJDOILFHDJI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8112990", Offset = "0x8110F90", VA = "0x188112990")]
	public static LGEBFGGIOJB AKGOCEBIOIO(LGEBFGGIOJB HBHNBNCHAIB, Action CJDOILFHDJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GHHKMLKIEMC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JDPCENHCAFL(Action<T> CJDOILFHDJI, bool CGMPNMELEAO = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BAFGFGCDOJB(Action<T> CJDOILFHDJI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class IAJLDMLJHLB<T> : DOMNOINLHEA<Action<T>>, GHHKMLKIEMC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x479B090", Offset = "0x4799690", VA = "0x18479B090")]
	public IAJLDMLJHLB(bool APNLKJMLHFF = false, bool IGHOMICJIMI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4F41BC0", Offset = "0x4F401C0", VA = "0x184F41BC0")]
	public void GHDKDALNEMC(T MMMCFFENLAH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4EA04E0", Offset = "0x4E9EAE0", VA = "0x184EA04E0")]
	public static IAJLDMLJHLB<T> PEDIBFNHHHB(IAJLDMLJHLB<T> HBHNBNCHAIB, Action<T> CJDOILFHDJI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4E9DE80", Offset = "0x4E9C480", VA = "0x184E9DE80")]
	public static IAJLDMLJHLB<T> AKGOCEBIOIO(IAJLDMLJHLB<T> HBHNBNCHAIB, Action<T> CJDOILFHDJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PPKAELAFDIN<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JDPCENHCAFL(Action<T, U> CJDOILFHDJI, bool CGMPNMELEAO = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BAFGFGCDOJB(Action<T, U> CJDOILFHDJI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class BGABPBLPFLC<T, U> : DOMNOINLHEA<Action<T, U>>, PPKAELAFDIN<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x479B090", Offset = "0x4799690", VA = "0x18479B090")]
	public BGABPBLPFLC(bool APNLKJMLHFF = false, bool IGHOMICJIMI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6154680", Offset = "0x6152C80", VA = "0x186154680")]
	public void GHDKDALNEMC(T MMMCFFENLAH, U BBNHOGHNOPE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4EA04E0", Offset = "0x4E9EAE0", VA = "0x184EA04E0")]
	public static BGABPBLPFLC<T, U> PEDIBFNHHHB(BGABPBLPFLC<T, U> HBHNBNCHAIB, Action<T, U> CJDOILFHDJI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4E9DE80", Offset = "0x4E9C480", VA = "0x184E9DE80")]
	public static BGABPBLPFLC<T, U> AKGOCEBIOIO(BGABPBLPFLC<T, U> HBHNBNCHAIB, Action<T, U> CJDOILFHDJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class LLJMDKOFNID<T, U, V> : DOMNOINLHEA<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x479B090", Offset = "0x4799690", VA = "0x18479B090")]
	public LLJMDKOFNID(bool APNLKJMLHFF = false, bool IGHOMICJIMI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x542D1D0", Offset = "0x542B7D0", VA = "0x18542D1D0")]
	public void GHDKDALNEMC(T MMMCFFENLAH, U BBNHOGHNOPE, V JIJNMCDLDDE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4EA04E0", Offset = "0x4E9EAE0", VA = "0x184EA04E0")]
	public static LLJMDKOFNID<T, U, V> PEDIBFNHHHB(LLJMDKOFNID<T, U, V> HBHNBNCHAIB, Action<T, U, V> CJDOILFHDJI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4E9DE80", Offset = "0x4E9C480", VA = "0x184E9DE80")]
	public static LLJMDKOFNID<T, U, V> AKGOCEBIOIO(LLJMDKOFNID<T, U, V> HBHNBNCHAIB, Action<T, U, V> CJDOILFHDJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BEGACHONNJI<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class HPMOCPNHEND<T, U, V, W> : DOMNOINLHEA<Action<T, U, V, W>>, BEGACHONNJI<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x479B090", Offset = "0x4799690", VA = "0x18479B090")]
	public HPMOCPNHEND(bool APNLKJMLHFF = false, bool IGHOMICJIMI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E2B0", Offset = "0x4E9C8B0", VA = "0x184E9E2B0")]
	public void GHDKDALNEMC(T MMMCFFENLAH, U BBNHOGHNOPE, V JIJNMCDLDDE, W DOHMFBHGBFB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4EA04E0", Offset = "0x4E9EAE0", VA = "0x184EA04E0")]
	public static HPMOCPNHEND<T, U, V, W> PEDIBFNHHHB(HPMOCPNHEND<T, U, V, W> HBHNBNCHAIB, Action<T, U, V, W> CJDOILFHDJI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4E9DE80", Offset = "0x4E9C480", VA = "0x184E9DE80")]
	public static HPMOCPNHEND<T, U, V, W> AKGOCEBIOIO(HPMOCPNHEND<T, U, V, W> HBHNBNCHAIB, Action<T, U, V, W> CJDOILFHDJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class JDKOHAODNFC<T, U, V, W, X> : DOMNOINLHEA<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x479B090", Offset = "0x4799690", VA = "0x18479B090")]
	public JDKOHAODNFC(bool APNLKJMLHFF = false, bool IGHOMICJIMI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5188E70", Offset = "0x5187470", VA = "0x185188E70")]
	public void GHDKDALNEMC(T MMMCFFENLAH, U BBNHOGHNOPE, V JIJNMCDLDDE, W DOHMFBHGBFB, X POMHCCBBBGD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4EA04E0", Offset = "0x4E9EAE0", VA = "0x184EA04E0")]
	public static JDKOHAODNFC<T, U, V, W, X> PEDIBFNHHHB(JDKOHAODNFC<T, U, V, W, X> HBHNBNCHAIB, Action<T, U, V, W, X> CJDOILFHDJI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4E9DE80", Offset = "0x4E9C480", VA = "0x184E9DE80")]
	public static JDKOHAODNFC<T, U, V, W, X> AKGOCEBIOIO(JDKOHAODNFC<T, U, V, W, X> HBHNBNCHAIB, Action<T, U, V, W, X> CJDOILFHDJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class CFPANKJNNDH<T, U, V, W, X, Y> : DOMNOINLHEA<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x479B090", Offset = "0x4799690", VA = "0x18479B090")]
	public CFPANKJNNDH(bool APNLKJMLHFF = false, bool IGHOMICJIMI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x679B950", Offset = "0x6799F50", VA = "0x18679B950")]
	public void GHDKDALNEMC(T MMMCFFENLAH, U BBNHOGHNOPE, V JIJNMCDLDDE, W DOHMFBHGBFB, X POMHCCBBBGD, Y JKKMGDMGNFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4EA04E0", Offset = "0x4E9EAE0", VA = "0x184EA04E0")]
	public static CFPANKJNNDH<T, U, V, W, X, Y> PEDIBFNHHHB(CFPANKJNNDH<T, U, V, W, X, Y> HBHNBNCHAIB, Action<T, U, V, W, X, Y> CJDOILFHDJI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4E9DE80", Offset = "0x4E9C480", VA = "0x184E9DE80")]
	public static CFPANKJNNDH<T, U, V, W, X, Y> AKGOCEBIOIO(CFPANKJNNDH<T, U, V, W, X, Y> HBHNBNCHAIB, Action<T, U, V, W, X, Y> CJDOILFHDJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class LIDOBLBBCJH<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly GMAPHMCBPAK<TKey, TVal> LFDBLHPFANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> EFEFCAKNIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly GMAPHMCBPAK<TKey, TVal>.GCGDIHLOLMJ? KIBPLDEABEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int FAAKFBKAKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly GMAPHMCBPAK<TKey, TVal>.NGBCNHKHKPC? EMKAOHJBAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int JHFFNNIDHLF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int EILHGDCFEHG
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x53909D0", Offset = "0x538EFD0", VA = "0x1853909D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int JPIBFMDDODB
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA451A0", Offset = "0xA437A0", VA = "0x180A451A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5390D60", Offset = "0x538F360", VA = "0x185390D60")]
	public LIDOBLBBCJH(int FAAKFBKAKLN, [Optional] GMAPHMCBPAK<TKey, TVal>.NGBCNHKHKPC? EMKAOHJBAIL, [Optional] IEqualityComparer<TKey>? IONKDIAAPCK, [Optional] GMAPHMCBPAK<TKey, TVal>.GCGDIHLOLMJ? KIBPLDEABEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5390800", Offset = "0x538EE00", VA = "0x185390800")]
	public void OAGAFFFGMKO(TKey BLIBAMJKLIA, TVal KKGBKLFKCPO, bool MIDPDACEJPA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5390C30", Offset = "0x538F230", VA = "0x185390C30")]
	public bool OOEFGDHJDOG(TKey BLIBAMJKLIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5390B50", Offset = "0x538F150", VA = "0x185390B50")]
	public bool OMCPIMBCGII(TKey BIPFMGFLODL, [Out] TVal KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x538FCD0", Offset = "0x538E2D0", VA = "0x18538FCD0")]
	private void BHIADFCFGGA(TKey BLIBAMJKLIA, TVal KKGBKLFKCPO, int GPNBMIDFKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5390580", Offset = "0x538EB80", VA = "0x185390580")]
	public bool JFBAKFHMHOM(TKey BLIBAMJKLIA, TVal KKGBKLFKCPO, bool MIDPDACEJPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5390440", Offset = "0x538EA40", VA = "0x185390440")]
	public void HHCEOPNNHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x538FF30", Offset = "0x538E530", VA = "0x18538FF30")]
	private void EJHPAHLFINI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5390710", Offset = "0x538ED10", VA = "0x185390710")]
	private bool MFMCIMFBGCD(TKey BLIBAMJKLIA, ECJDFOIJEFN CIOGCOOPLBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x53904A0", Offset = "0x538EAA0", VA = "0x1853904A0")]
	private void HNHPHMLHPMP(TKey BLIBAMJKLIA, TVal KKGBKLFKCPO, ECJDFOIJEFN CIOGCOOPLBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5390A20", Offset = "0x538F020", VA = "0x185390A20")]
	private void OJJNADNHOPA(TKey BLIBAMJKLIA, TVal FADBOFNILPL, ECJDFOIJEFN CIOGCOOPLBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FIDHALMHLIP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action PPGFFLPCJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool DLGDKMKGABI;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xA4B570", Offset = "0xA49B70", VA = "0x180A4B570")]
	public FIDHALMHLIP(Action LJIEFCNIMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8111570", Offset = "0x810FB70", VA = "0x188111570", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x30ACE80", Offset = "0x30AB480", VA = "0x1830ACE80")]
	public static PGDJPLOBHJM<T> MMBKOMPANAO<T>(T KKGBKLFKCPO, Action LJIEFCNIMHE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class PGDJPLOBHJM<T> : FIDHALMHLIP where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T IBMJNNAJGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x58D52B0", Offset = "0x58D38B0", VA = "0x1858D52B0")]
	public PGDJPLOBHJM(T KKGBKLFKCPO, Action LJIEFCNIMHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class PNMLKMLDIBB<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly FEIODMAFEAA<T>? DDNECIIENPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> APBOFAOIMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool DLGDKMKGABI;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly PNMLKMLDIBB<T> PBMJKPJDLCC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> EENJMOOLKFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x58FE6E0", Offset = "0x58FCCE0", VA = "0x1858FE6E0")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long GMOIMINMBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x58FE7E0", Offset = "0x58FCDE0", VA = "0x1858FE7E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool NGPOKKIJIOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x58FEA20", Offset = "0x58FD020", VA = "0x1858FEA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x58FF410", Offset = "0x58FDA10", VA = "0x1858FF410")]
	public PNMLKMLDIBB(FEIODMAFEAA<T> IHEBOHBLHIF, FEIODMAFEAA<T> POCDPHGKGKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x58FEC20", Offset = "0x58FD220", VA = "0x1858FEC20")]
	public PNMLKMLDIBB(FEIODMAFEAA<T> IHEBOHBLHIF, int IGHNHCKLCCN, FEIODMAFEAA<T> POCDPHGKGKD, int OKAGIFCCMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x58FF360", Offset = "0x58FD960", VA = "0x1858FF360")]
	private PNMLKMLDIBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x58FE540", Offset = "0x58FCB40", VA = "0x1858FE540", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x58FE400", Offset = "0x58FCA00", VA = "0x1858FE400")]
	public T[] DCHHGDINECP()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x58FE5C0", Offset = "0x58FCBC0", VA = "0x1858FE5C0")]
	public static ReadOnlySequence<T> EIMKEBEILPD(PNMLKMLDIBB<T>? JMCJBHCJINO)
	{
		return default(ReadOnlySequence<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct BGGNOGIGJIF<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly IDisposable MPFPEEAEPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public T IBMJNNAJGNM;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x615C760", Offset = "0x615AD60", VA = "0x18615C760")]
	public BGGNOGIGJIF(IDisposable FMBOIKGHIFL, [In] T KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3C90AB0", Offset = "0x3C8F0B0", VA = "0x183C90AB0")]
	public static BGGNOGIGJIF<U> MCJGPLDDMEL<U>([In] BGGNOGIGJIF<T> FMBOIKGHIFL, [In] U KKGBKLFKCPO) where U : notnull
	{
		return default(BGGNOGIGJIF<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x615C5A0", Offset = "0x615ABA0", VA = "0x18615C5A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class AABKLBGFFAB
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x30AAA40", Offset = "0x30A9040", VA = "0x1830AAA40")]
	public static BGGNOGIGJIF<T> BFOPDLPDKBM<T>(IDisposable FMBOIKGHIFL, [In] T KKGBKLFKCPO) where T : notnull
	{
		return default(BGGNOGIGJIF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x30AAAA0", Offset = "0x30A90A0", VA = "0x1830AAAA0")]
	public static BGGNOGIGJIF<T> DIGHGDEOJJO<T>([In] this BGGNOGIGJIF<T> PIKMBNLEPPK, [Out] T KKGBKLFKCPO) where T : notnull
	{
		return default(BGGNOGIGJIF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x30AAB00", Offset = "0x30A9100", VA = "0x1830AAB00")]
	public static BGGNOGIGJIF<U?> MCJGPLDDMEL<U, T>([In] BGGNOGIGJIF<T> JKFOINEBEAI, [In] U KKGBKLFKCPO)
	{
		return default(BGGNOGIGJIF<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct DALACCGALDC : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct JABNNAJNPLK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450")]
		public static JABNNAJNPLK BFOPDLPDKBM()
		{
			return default(JABNNAJNPLK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8111260", Offset = "0x810F860", VA = "0x188111260")]
	public static string IHNFBDNLEMB(Type JLPANLJHHFI, [Optional] string? PMAJEAHKPAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x398DC40", Offset = "0x398C240", VA = "0x18398DC40")]
	public static string? IHNFBDNLEMB<T>([Optional] string? PMAJEAHKPAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x398DBC0", Offset = "0x398C1C0", VA = "0x18398DBC0")]
	public static string? GAJPCEJIKAF<T>([Optional] string? MOBCHKKPINO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450")]
	public static DALACCGALDC APGCMCCAODE(string PMAJEAHKPAO, string? MOBCHKKPINO)
	{
		return default(DALACCGALDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct KBDCAGEFFAP
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate bool PICLBJBCIFP(string INJIHJMAJJN, KBDCAGEFFAP IFCLJFFGBME);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class BIAOPONBIGH<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public BIAOPONBIGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x61F9C80", Offset = "0x61F8280", VA = "0x1861F9C80")]
		internal void ANEKFGGDAKD(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public int DANMPOCKLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public string ENBJCKJPNAC;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8112170", Offset = "0x8110770", VA = "0x188112170")]
	public static Dictionary<string, KBDCAGEFFAP> EPNJBALEIPE(Type PFLBLPBNFJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8B90", Offset = "0x3BC7190", VA = "0x183BC8B90")]
	public static Dictionary<string, KBDCAGEFFAP> EPNJBALEIPE<T>(Type PFLBLPBNFJC, IReadOnlyDictionary<T, string> PGLJDGOLDJK) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3BC93D0", Offset = "0x3BC79D0", VA = "0x183BC93D0")]
	public static Dictionary<string, KBDCAGEFFAP> LBPPIJJDOAC<T>(List<T> EPDIOKFLFKL) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x81124A0", Offset = "0x8110AA0", VA = "0x1881124A0")]
	public static Dictionary<string, KBDCAGEFFAP> IMKDMGHIMCI(Type PFLBLPBNFJC, PICLBJBCIFP LDIBFKPBCIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8111FB0", Offset = "0x81105B0", VA = "0x188111FB0")]
	public static Dictionary<int, string> BJPODGICONA(Dictionary<string, KBDCAGEFFAP> INCFEGIJJJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class PELIOLHOEHA : KNIOCFDMLBC
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool HFHEBFPIPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly string? NDNOKLANNAK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual KNIOCFDMLBC? LNBEJIPNNCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8113940", Offset = "0x8111F40", VA = "0x188113940")]
	protected PELIOLHOEHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string GNDOFJNNOIF();

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8113290", Offset = "0x8111890", VA = "0x188113290", Slot = "8")]
	public virtual string HOHDAFGLACF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8113430", Offset = "0x8111A30", VA = "0x188113430", Slot = "9")]
	public void JELEJCMPPFG(StringBuilder LEHFIIJIJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8113840", Offset = "0x8111E40", VA = "0x188113840", Slot = "10")]
	public void MMKEOKLFPPE(StringBuilder LEHFIIJIJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8113310", Offset = "0x8111910", VA = "0x188113310", Slot = "11")]
	public void IIMAICLBMCC(StringBuilder LEHFIIJIJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x81136E0", Offset = "0x8111CE0", VA = "0x1881136E0", Slot = "12")]
	public void KPJCIOBJEPM(StringBuilder LEHFIIJIJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x81138A0", Offset = "0x8111EA0", VA = "0x1881138A0")]
	public static void NHKHKGGAKII(StringBuilder LEHFIIJIJKH, string CHFIPBCCMBD, string PBEFIFMBIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x703DE70", Offset = "0x703C470", VA = "0x18703DE70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class PIFFADABGDP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8113BE0", Offset = "0x81121E0", VA = "0x188113BE0")]
	public PIFFADABGDP(string CJIMOMNMAGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class AIPGCLCPGNN<TErr> : PIFFADABGDP where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly TErr KOONDBEIOEK;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4E6FD50", Offset = "0x4E6E350", VA = "0x184E6FD50")]
	private AIPGCLCPGNN([In] TErr BJGNNJEFLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4E6FC80", Offset = "0x4E6E280", VA = "0x184E6FC80")]
	public static AIPGCLCPGNN<TErr> BFOPDLPDKBM([In] TErr BJGNNJEFLOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class ONAAMKCNFMB : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashAlgorithm BOMCKOICKAF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool HIOJKAADBLO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool EFNKAJCCHNK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool CBINGBOCNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long GMOIMINMBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8113130", Offset = "0x8111730", VA = "0x188113130", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long DGHMAMNELGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x81131A0", Offset = "0x81117A0", VA = "0x1881131A0", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8113210", Offset = "0x8111810", VA = "0x188113210", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x81130C0", Offset = "0x81116C0", VA = "0x1881130C0")]
	public ONAAMKCNFMB(HashAlgorithm BOMCKOICKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8112EE0", Offset = "0x81114E0", VA = "0x188112EE0", Slot = "35")]
	public override int Read(byte[] LBNJMEGEAHB, int MOBKDJHFHDL, int FOAMCIPOLAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8113090", Offset = "0x8111690", VA = "0x188113090", Slot = "38")]
	public override void Write(byte[] LBNJMEGEAHB, int MOBKDJHFHDL, int FOAMCIPOLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8112F80", Offset = "0x8111580", VA = "0x188112F80", Slot = "33")]
	public override long Seek(long MOBKDJHFHDL, SeekOrigin HOPJCEGNGCM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8113010", Offset = "0x8111610", VA = "0x188113010", Slot = "34")]
	public override void SetLength(long KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8112E00", Offset = "0x8111400", VA = "0x188112E00")]
	public byte[] ECHILGPGPHJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface KNIOCFDMLBC
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string HOHDAFGLACF();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string GNDOFJNNOIF();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface FJDHHPBBPOJ<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions IBMJNNAJGNM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface FPIGJPFBPJN
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string HFNKDGGAKJM
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class FEIODMAFEAA<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static FEIODMAFEAA<T>? MMMMGEIADNJ;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static object BJPDJDFLACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private IMemoryOwner<T>? HNEKMFKHFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool DLGDKMKGABI;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool FLBBOPEIKLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xD68CE0", Offset = "0xD672E0", VA = "0x180D68CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4C00450", Offset = "0x4BFEA50", VA = "0x184C00450")]
	private static FEIODMAFEAA<T> BGBIPPAHJNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4C01110", Offset = "0x4BFF710", VA = "0x184C01110")]
	private static void ELOLCMDFGOO(FEIODMAFEAA<T> OPOKDPDIKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4BF2250", Offset = "0x4BF0850", VA = "0x184BF2250")]
	private FEIODMAFEAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4C01B90", Offset = "0x4C00190", VA = "0x184C01B90")]
	public static FEIODMAFEAA<T> MMBKOMPANAO(ReadOnlyMemory<T> GAGIPKOCKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4C017D0", Offset = "0x4BFFDD0", VA = "0x184C017D0")]
	public static FEIODMAFEAA<T> MMBKOMPANAO(IMemoryOwner<T> CHGALIJDIFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4C016B0", Offset = "0x4BFFCB0", VA = "0x184C016B0")]
	public static void FLEKGOLPKAE(FEIODMAFEAA<T> IHEBOHBLHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4C00EE0", Offset = "0x4BFF4E0", VA = "0x184C00EE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4C00BE0", Offset = "0x4BFF1E0", VA = "0x184C00BE0")]
	public FEIODMAFEAA<T> DJMKPHJGGIE(IMemoryOwner<T> CHGALIJDIFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4C00AF0", Offset = "0x4BFF0F0", VA = "0x184C00AF0")]
	private void DEMPHDCFPOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4C008F0", Offset = "0x4BFEEF0", VA = "0x184C008F0")]
	private FEIODMAFEAA<T> BHLEDEGGNJN(FEIODMAFEAA<T> OPOKDPDIKFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class IKEFPADAFPO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8111F50", Offset = "0x8110550", VA = "0x188111F50")]
	public IKEFPADAFPO(string CJIMOMNMAGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class PFEPGMHJJOF<TOk> : IKEFPADAFPO where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TOk PLHNOJAOKMC;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x58B94B0", Offset = "0x58B7AB0", VA = "0x1858B94B0")]
	private PFEPGMHJJOF([In] TOk BPKKPHCGAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x52D9CA0", Offset = "0x52D82A0", VA = "0x1852D9CA0")]
	public static PFEPGMHJJOF<TOk> BFOPDLPDKBM([In] TOk BPKKPHCGAME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct FANMKCKHALG<TOk, TErr> : IEquatable<FANMKCKHALG<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly EqualityComparer<TErr> EBLDEAKPIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal readonly TErr KOONDBEIOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal readonly TOk PLHNOJAOKMC;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool MLHECCMJHDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4BE6B70", Offset = "0x4BE5170", VA = "0x184BE6B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool OGDFCHOBAIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4BEB4C0", Offset = "0x4BE9AC0", VA = "0x184BEB4C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4BF12F0", Offset = "0x4BEF8F0", VA = "0x184BF12F0")]
	internal FANMKCKHALG([In] TErr BJGNNJEFLOC, [In] TOk BPKKPHCGAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4BE8200", Offset = "0x4BE6800", VA = "0x184BE8200")]
	public static FANMKCKHALG<TOk, TErr> EIBDDKFDEPL([In] TErr BJGNNJEFLOC)
	{
		return default(FANMKCKHALG<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4BE77F0", Offset = "0x4BE5DF0", VA = "0x184BE77F0")]
	public static FANMKCKHALG<TOk, TErr> DHFDDJFPLMO([In] TOk BPKKPHCGAME)
	{
		return default(FANMKCKHALG<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3F246F0", Offset = "0x3F22CF0", VA = "0x183F246F0")]
	public FANMKCKHALG<TOk?, UErr?> LPBGJJJDOLP<UErr>()
	{
		return default(FANMKCKHALG<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3F244D0", Offset = "0x3F22AD0", VA = "0x183F244D0")]
	public FANMKCKHALG<UOk?, TErr?> KPPDPHHPBLM<UOk>()
	{
		return default(FANMKCKHALG<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3F254D0", Offset = "0x3F23AD0", VA = "0x183F254D0")]
	public FANMKCKHALG<UOk?, TErr?> OOJAJIKINOG<UOk>()
	{
		return default(FANMKCKHALG<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3F24F80", Offset = "0x3F23580", VA = "0x183F24F80")]
	public FANMKCKHALG<TOk?, UErr?> MKDMLHGPGOG<UErr>()
	{
		return default(FANMKCKHALG<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4BED110", Offset = "0x4BEB710", VA = "0x184BED110")]
	public FANMKCKHALG<DICNEKFFPEP, TErr> ONFKLAEMHKI()
	{
		return default(FANMKCKHALG<DICNEKFFPEP, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4BEBB80", Offset = "0x4BEA180", VA = "0x184BEBB80")]
	public static bool JKIBMILPCGE([In] FANMKCKHALG<TOk, TErr> DBDIOGELIIH, [In] FANMKCKHALG<TOk, TErr> LHANOGJMGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4BE8D90", Offset = "0x4BE7390", VA = "0x184BE8D90", Slot = "4")]
	public bool Equals(FANMKCKHALG<TOk, TErr> HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4BE8A60", Offset = "0x4BE7060", VA = "0x184BE8A60", Slot = "0")]
	public override bool Equals(object HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4BEAB10", Offset = "0x4BE9110", VA = "0x184BEAB10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4BEF410", Offset = "0x4BEDA10", VA = "0x184BEF410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class EKGJGJHAKLC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct JEPFJCPMKDM<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Task<FANMKCKHALG<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<FANMKCKHALG<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5197F90", Offset = "0x5196590", VA = "0x185197F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x51988F0", Offset = "0x5196EF0", VA = "0x1851988F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x39CA740", Offset = "0x39C8D40", VA = "0x1839CA740")]
	public static FANMKCKHALG<TOk?, TErr?> PLHNOJAOKMC<TOk, TErr>([In] this FANMKCKHALG<TOk, TErr> PIKMBNLEPPK, [In] TOk BPKKPHCGAME)
	{
		return default(FANMKCKHALG<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x39CBB70", Offset = "0x39CA170", VA = "0x1839CBB70")]
	public static FANMKCKHALG<DICNEKFFPEP, TErr?> PLHNOJAOKMC<TErr>([In] this FANMKCKHALG<DICNEKFFPEP, TErr> PIKMBNLEPPK)
	{
		return default(FANMKCKHALG<DICNEKFFPEP, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x39CA740", Offset = "0x39C8D40", VA = "0x1839CA740")]
	public static FANMKCKHALG<TOk?, TErr?> KOONDBEIOEK<TOk, TErr>([In] this FANMKCKHALG<TOk, TErr> PIKMBNLEPPK, [In] TErr BJGNNJEFLOC)
	{
		return default(FANMKCKHALG<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x39C8340", Offset = "0x39C6940", VA = "0x1839C8340")]
	public static TOk? BOBIILMDKPL<TOk, TErr>([In] this FANMKCKHALG<TOk, TErr> PIKMBNLEPPK)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x39CAB90", Offset = "0x39C9190", VA = "0x1839CAB90")]
	[AsyncStateMachine(typeof(JEPFJCPMKDM<, >))]
	public static Task<TOk?>? MMLHBHECPNI<TOk, TErr>(this Task<FANMKCKHALG<TOk, TErr>> PIKMBNLEPPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x39CBA10", Offset = "0x39CA010", VA = "0x1839CBA10")]
	public static TErr? OLIALHNKEMD<TErr, TOk>([In] this FANMKCKHALG<TOk, TErr> PIKMBNLEPPK)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x39C87F0", Offset = "0x39C6DF0", VA = "0x1839C87F0")]
	public static bool EMOEFLGCEHP<TOk, TErr, UErr, UOk>([In] this FANMKCKHALG<TOk, TErr> PIKMBNLEPPK, [Out] FANMKCKHALG<UOk, UErr> MKEFFDKHNPI) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x39CA4B0", Offset = "0x39C8AB0", VA = "0x1839CA4B0")]
	public static bool JOJGELGOJGN<TOk, TErr>([In] this FANMKCKHALG<TOk, TErr> PIKMBNLEPPK, [Out] TOk BPKKPHCGAME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x39C9FA0", Offset = "0x39C85A0", VA = "0x1839C9FA0")]
	public static bool FPMDJFCLHCA<TOk, TErr>([In] this FANMKCKHALG<TOk, TErr> PIKMBNLEPPK, [Out][NotNullWhen(true)] TErr BJGNNJEFLOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x39C85F0", Offset = "0x39C6BF0", VA = "0x1839C85F0")]
	public static bool DKFPMHLNPEI<TOk, TErr>([In] this FANMKCKHALG<TOk, TErr> PIKMBNLEPPK, [Out][NotNullWhen(true)] TOk BPKKPHCGAME, [Out][NotNullWhen(false)] TErr BJGNNJEFLOC) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x39CB650", Offset = "0x39C9C50", VA = "0x1839CB650")]
	public static bool NPJHPJCGMHC<TOk, TErr>([In] this FANMKCKHALG<TOk, TErr> PIKMBNLEPPK, [Out][NotNullWhen(true)] TOk BPKKPHCGAME, [Out] FANMKCKHALG<TOk, TErr> MKEFFDKHNPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x39C8B40", Offset = "0x39C7140", VA = "0x1839C8B40")]
	public static bool EMOEFLGCEHP<TOk, TErr, UErr, UOk>([In] this FANMKCKHALG<TOk, TErr> PIKMBNLEPPK, [Out][NotNullWhen(true)] TOk BPKKPHCGAME, [Out] FANMKCKHALG<UOk, UErr> MKEFFDKHNPI) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x39CA150", Offset = "0x39C8750", VA = "0x1839CA150")]
	public static bool IDLHKAPDJKA<TOk, TErr>([In] this FANMKCKHALG<TOk, TErr> PIKMBNLEPPK, [Out][NotNullWhen(true)] TOk BPKKPHCGAME, [Out] FANMKCKHALG<DICNEKFFPEP, TErr> MKEFFDKHNPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x39CB0A0", Offset = "0x39C96A0", VA = "0x1839CB0A0")]
	public static FANMKCKHALG<UOk, UErr> MPFOJBIOMDA<UOk, UErr, TOk, TErr>([In] this FANMKCKHALG<TOk, TErr> PIKMBNLEPPK, [In] FANMKCKHALG<UOk, UErr> HKKDKDDKEBF) where TOk : UOk where TErr : UErr
	{
		return default(FANMKCKHALG<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x39C7AD0", Offset = "0x39C60D0", VA = "0x1839C7AD0")]
	public static FANMKCKHALG<TOk?[]?, TErr?> BGJCOPCDGCK<TOk, TErr>(this IEnumerable<FANMKCKHALG<TOk, TErr>> PIKMBNLEPPK)
	{
		return default(FANMKCKHALG<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x39C9D00", Offset = "0x39C8300", VA = "0x1839C9D00")]
	public static FANMKCKHALG<UOk?, TErr?> EPIOCFCNAPF<UOk, TErr, TOk>([In] this FANMKCKHALG<TOk, TErr> PIKMBNLEPPK, Func<TOk, UOk> FGPFIKOKFNN)
	{
		return default(FANMKCKHALG<UOk, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class EHNIOLAHAPG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3D90850", Offset = "0x3D8EE50", VA = "0x183D90850")]
	public static FANMKCKHALG<TOk, T> PLHNOJAOKMC<TOk>([In] TOk BPKKPHCGAME) where TOk : notnull
	{
		return default(FANMKCKHALG<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x478B380", Offset = "0x4789980", VA = "0x18478B380")]
	public static FANMKCKHALG<DICNEKFFPEP, T> PLHNOJAOKMC()
	{
		return default(FANMKCKHALG<DICNEKFFPEP, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3D90850", Offset = "0x3D8EE50", VA = "0x183D90850")]
	public static FANMKCKHALG<T, TErr> KOONDBEIOEK<TErr>([In] TErr BJGNNJEFLOC) where TErr : notnull
	{
		return default(FANMKCKHALG<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct DPLMBDGJEEM<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly BIEJHLBKJLF FPJBGAJBALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly Dictionary<TKey, TValue> PNGCMLBPNFM;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5381590", Offset = "0x537FB90", VA = "0x185381590")]
	public static DPLMBDGJEEM<TKey, TValue> BFOPDLPDKBM(string HILCMKALFIH)
	{
		return default(DPLMBDGJEEM<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5381760", Offset = "0x537FD60", VA = "0x185381760")]
	internal DPLMBDGJEEM(Dictionary<TKey, TValue> KKGBKLFKCPO, BIEJHLBKJLF NCBANOLCNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x53816B0", Offset = "0x537FCB0", VA = "0x1853816B0")]
	public CKDIEDCEKMJ<TKey, TValue> JEJGONKBJMN([Out] Dictionary<TKey, TValue> KKGBKLFKCPO)
	{
		return default(CKDIEDCEKMJ<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct CKDIEDCEKMJ<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TValue> PNGCMLBPNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly OAHPJMDCJGO BGPGAMMMANM;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE790", Offset = "0x2BBCD90", VA = "0x182BBE790")]
	internal CKDIEDCEKMJ(Dictionary<TKey, TValue> KKGBKLFKCPO, OAHPJMDCJGO IIADFIMJHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x56A3A30", Offset = "0x56A2030", VA = "0x1856A3A30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct MIDDKCMEGBC<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly BIEJHLBKJLF FPJBGAJBALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly HashSet<T> PNGCMLBPNFM;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5381590", Offset = "0x537FB90", VA = "0x185381590")]
	public static MIDDKCMEGBC<T> BFOPDLPDKBM(string HILCMKALFIH)
	{
		return default(MIDDKCMEGBC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5381760", Offset = "0x537FD60", VA = "0x185381760")]
	internal MIDDKCMEGBC(HashSet<T> KKGBKLFKCPO, BIEJHLBKJLF NCBANOLCNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x53816B0", Offset = "0x537FCB0", VA = "0x1853816B0")]
	public CCGOJCMDDMG<T> JEJGONKBJMN([Out] HashSet<T> KKGBKLFKCPO)
	{
		return default(CCGOJCMDDMG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct CCGOJCMDDMG<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HashSet<T> PNGCMLBPNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly OAHPJMDCJGO BGPGAMMMANM;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE790", Offset = "0x2BBCD90", VA = "0x182BBE790")]
	internal CCGOJCMDDMG(HashSet<T> KKGBKLFKCPO, OAHPJMDCJGO IIADFIMJHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x56A3A30", Offset = "0x56A2030", VA = "0x1856A3A30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct LEABIPNDANB<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly BIEJHLBKJLF FPJBGAJBALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Stack<T> PNGCMLBPNFM;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5381590", Offset = "0x537FB90", VA = "0x185381590")]
	public static LEABIPNDANB<T> BFOPDLPDKBM(string HILCMKALFIH)
	{
		return default(LEABIPNDANB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5381760", Offset = "0x537FD60", VA = "0x185381760")]
	internal LEABIPNDANB(Stack<T> KKGBKLFKCPO, BIEJHLBKJLF NCBANOLCNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x53816B0", Offset = "0x537FCB0", VA = "0x1853816B0")]
	public NOAKILLJFPP<T> JEJGONKBJMN([Out] Stack<T> KKGBKLFKCPO)
	{
		return default(NOAKILLJFPP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct NOAKILLJFPP<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Stack<T> PNGCMLBPNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly OAHPJMDCJGO BGPGAMMMANM;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE790", Offset = "0x2BBCD90", VA = "0x182BBE790")]
	internal NOAKILLJFPP(Stack<T> KKGBKLFKCPO, OAHPJMDCJGO IIADFIMJHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x56A3A30", Offset = "0x56A2030", VA = "0x1856A3A30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DefaultMember("Item")]
public sealed class LHDALOEPOHE<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct AOELAPGPKLA : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly LHDALOEPOHE<T> DKGPKIAHGJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly int DOFJBDEHIPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly bool HOKCHGDIMIL;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2842E50", Offset = "0x2841450", VA = "0x182842E50")]
		public AOELAPGPKLA(LHDALOEPOHE<T> FIAONBPCJJK, int EKLJEBOHKKH, bool MKIKEEPMGNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x4F96EE0", Offset = "0x4F954E0", VA = "0x184F96EE0")]
		public LHDALOEPOHE<T>.BDBEDIBJEBK DHKFMABLBKB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4F96FD0", Offset = "0x4F955D0", VA = "0x184F96FD0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4F96FD0", Offset = "0x4F955D0", VA = "0x184F96FD0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public sealed class BDBEDIBJEBK : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly LHDALOEPOHE<T> DKGPKIAHGJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly int EFGFLOHNMIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int CBDMAKNJLPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly bool HOKCHGDIMIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private bool GGFGDMOKKJG;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T CGHPBCAOGAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6140BC0", Offset = "0x613F1C0", VA = "0x186140BC0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x6140CF0", Offset = "0x613F2F0", VA = "0x186140CF0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6140F70", Offset = "0x613F570", VA = "0x186140F70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6141300", Offset = "0x613F900", VA = "0x186141300")]
		public BDBEDIBJEBK(LHDALOEPOHE<T> FIAONBPCJJK, int EKLJEBOHKKH, bool MKIKEEPMGNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6140C40", Offset = "0x613F240", VA = "0x186140C40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6140CD0", Offset = "0x613F2D0", VA = "0x186140CD0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class HCFDOGKFOMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public HCFDOGKFOMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4DDB4E0", Offset = "0x4DD9AE0", VA = "0x184DDB4E0")]
		internal T NFGNFMIJEJA(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly T[] MEGELAPIMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private int CBDMAKNJLPF;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int DICMFNAPLEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x538B250", Offset = "0x5389850", VA = "0x18538B250")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T CGHPBCAOGAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4BDCBB0", Offset = "0x4BDB1B0", VA = "0x184BDCBB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T KCBIGOIHHPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x538B2A0", Offset = "0x53898A0", VA = "0x18538B2A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x538B430", Offset = "0x5389A30", VA = "0x18538B430")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int GMOIMINMBLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x27ACC80", Offset = "0x27AB280", VA = "0x1827ACC80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1C30D80", Offset = "0x1C2F380", VA = "0x181C30D80")]
	private static int KDCCAPHMMIO(int KHMHPNKMLMD, int PHABMFMJBEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x538B720", Offset = "0x5389D20", VA = "0x18538B720")]
	public LHDALOEPOHE(int GPNBMIDFKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x538B5A0", Offset = "0x5389BA0", VA = "0x18538B5A0")]
	public LHDALOEPOHE(int GPNBMIDFKMK, Func<T> AOIMKDPBOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x538BAB0", Offset = "0x538A0B0", VA = "0x18538BAB0")]
	public LHDALOEPOHE(T[] LKKBHMIMCBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x538B360", Offset = "0x5389960", VA = "0x18538B360")]
	public void EKGPOHGMNJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x538B4E0", Offset = "0x5389AE0", VA = "0x18538B4E0")]
	public IEnumerable<T> KLNLOKNDNFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x538B2D0", Offset = "0x53898D0", VA = "0x18538B2D0")]
	public LHDALOEPOHE<T>.BDBEDIBJEBK DHKFMABLBKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4D14EF0", Offset = "0x4D134F0", VA = "0x184D14EF0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4D14EF0", Offset = "0x4D134F0", VA = "0x184D14EF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class OABHIPKCIDA
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5740", Offset = "0x3CE3D40", VA = "0x183CE5740")]
	public static LHDALOEPOHE<T> BFOPDLPDKBM<T>(int GPNBMIDFKMK, Func<T> AOIMKDPBOFC) where T : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x8114760", Offset = "0x8112D60", VA = "0x188114760")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x8114720", Offset = "0x8112D20", VA = "0x188114720")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x8114740", Offset = "0x8112D40", VA = "0x188114740")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x8114780", Offset = "0x8112D80", VA = "0x188114780")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8114700", Offset = "0x8112D00", VA = "0x188114700")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2975E20", Offset = "0x2974420", VA = "0x182975E20")]
		public RRColor(float GBHEJJJMLLO, float HIGNMJCHGEJ, float OKKFDNDPGLP, float DLGEPLKGJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7F931A0", Offset = "0x7F917A0", VA = "0x187F931A0", Slot = "4")]
		public bool Equals(RRColor HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8114350", Offset = "0x8112950", VA = "0x188114350", Slot = "0")]
		public override bool Equals(object HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8114450", Offset = "0x8112A50", VA = "0x188114450", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x81144D0", Offset = "0x8112AD0", VA = "0x1881144D0", Slot = "5")]
		public string ToString(string MCLEKLAABMK, IFormatProvider OMMCDLFFHEA)
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
			[Cpp2IlInjected.Address(RVA = "0x81142F0", Offset = "0x81128F0", VA = "0x1881142F0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8114290", Offset = "0x8112890", VA = "0x188114290")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x81142C0", Offset = "0x81128C0", VA = "0x1881142C0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8114320", Offset = "0x8112920", VA = "0x188114320")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8114260", Offset = "0x8112860", VA = "0x188114260")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5F46420", Offset = "0x5F44A20", VA = "0x185F46420")]
		public RRColor32(byte GBHEJJJMLLO, byte HIGNMJCHGEJ, byte OKKFDNDPGLP, byte DLGEPLKGJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x234F3A0", Offset = "0x234D9A0", VA = "0x18234F3A0", Slot = "4")]
		public bool Equals(RRColor32 HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8113F80", Offset = "0x8112580", VA = "0x188113F80", Slot = "0")]
		public override bool Equals(object HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x147DE10", Offset = "0x147C410", VA = "0x18147DE10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8113DC0", Offset = "0x81123C0", VA = "0x188113DC0")]
		public static RRColor32 EIMKEBEILPD(RRColor HJGAGGHDFHM)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8113F10", Offset = "0x8112510", VA = "0x188113F10")]
		public static RRColor EIMKEBEILPD(RRColor32 HJGAGGHDFHM)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8114000", Offset = "0x8112600", VA = "0x188114000", Slot = "5")]
		public string ToString(string MCLEKLAABMK, IFormatProvider OMMCDLFFHEA)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class EPCAOALFIEO<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct IPPHFLDPIOG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly EPCAOALFIEO<T> CNKNKELOJKI;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T IBMJNNAJGNM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x4FA40D0", Offset = "0x4FA26D0", VA = "0x184FA40D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4FA40A0", Offset = "0x4FA26A0", VA = "0x184FA40A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A40", Offset = "0xDE7040", VA = "0x180DE8A40")]
		public IPPHFLDPIOG(EPCAOALFIEO<T> CNKNKELOJKI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct OBFHEBNDNBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<IPPHFLDPIOG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public EPCAOALFIEO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x57A7BC0", Offset = "0x57A61C0", VA = "0x1857A7BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4C03840", Offset = "0x4C01E40", VA = "0x184C03840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly SemaphoreSlim HKOIGNLOLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private T JGGFCLCGOGI;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x479C670", Offset = "0x479AC70", VA = "0x18479C670")]
	public EPCAOALFIEO([In] T JGGFCLCGOGI, int JOEICJHDIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x479C5B0", Offset = "0x479ABB0", VA = "0x18479C5B0")]
	public EPCAOALFIEO([In] T JGGFCLCGOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x479C510", Offset = "0x479AB10", VA = "0x18479C510", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x479C570", Offset = "0x479AB70", VA = "0x18479C570")]
	public IPPHFLDPIOG HJEIIMIOPOG()
	{
		return default(IPPHFLDPIOG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x479C090", Offset = "0x479A690", VA = "0x18479C090")]
	[AsyncStateMachine(typeof(EPCAOALFIEO<>.OBFHEBNDNBD))]
	public Task<EPCAOALFIEO<T>.IPPHFLDPIOG> DNMBJLGECEK(CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x479C550", Offset = "0x479AB50", VA = "0x18479C550")]
	public void GMBPPOKLJAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class GICFFBDPOOE
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x8111D40", Offset = "0x8110340", VA = "0x188111D40")]
	public static EPCAOALFIEO<DICNEKFFPEP> BFOPDLPDKBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x39504A0", Offset = "0x394EAA0", VA = "0x1839504A0")]
	public static EPCAOALFIEO<T> BFOPDLPDKBM<T>([In] T JGGFCLCGOGI) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class HGNJCNLKLPH<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public readonly struct LDAKBOLNKCJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly HGNJCNLKLPH<T> NPJMNCCDCHD;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T IBMJNNAJGNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x4F83A50", Offset = "0x4F82050", VA = "0x184F83A50")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x537A740", Offset = "0x5378D40", VA = "0x18537A740", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A40", Offset = "0xDE7040", VA = "0x180DE8A40")]
		internal LDAKBOLNKCJ(HGNJCNLKLPH<T> CNKNKELOJKI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public readonly struct AJKGLCKOPIP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly HGNJCNLKLPH<T> NPJMNCCDCHD;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T IBMJNNAJGNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x4F83A50", Offset = "0x4F82050", VA = "0x184F83A50")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4F83A00", Offset = "0x4F82000", VA = "0x184F83A00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A40", Offset = "0xDE7040", VA = "0x180DE8A40")]
		internal AJKGLCKOPIP(HGNJCNLKLPH<T> CNKNKELOJKI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct DOIBJIGNIJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AsyncTaskMethodBuilder<AJKGLCKOPIP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public HGNJCNLKLPH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private EPCAOALFIEO<DICNEKFFPEP>.IPPHFLDPIOG <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter<EPCAOALFIEO<DICNEKFFPEP>.IPPHFLDPIOG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6D39B80", Offset = "0x6D38180", VA = "0x186D39B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4C03840", Offset = "0x4C01E40", VA = "0x184C03840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly EPCAOALFIEO<int> CPHBPOJKKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly EPCAOALFIEO<DICNEKFFPEP> CCIAFIIEOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly EPCAOALFIEO<DICNEKFFPEP> FBPFIDPDEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private T NPLMMJNKANL;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4DF5B80", Offset = "0x4DF4180", VA = "0x184DF5B80")]
	internal HGNJCNLKLPH(EPCAOALFIEO<int> PDGADEMACML, EPCAOALFIEO<DICNEKFFPEP> IPGIFEAMCJG, EPCAOALFIEO<DICNEKFFPEP> HMOLFPICMDB, [In] T JGGFCLCGOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4DF5720", Offset = "0x4DF3D20", VA = "0x184DF5720", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4DF5320", Offset = "0x4DF3920", VA = "0x184DF5320")]
	public LDAKBOLNKCJ CLPAOECJHKG()
	{
		return default(LDAKBOLNKCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4DF5820", Offset = "0x4DF3E20", VA = "0x184DF5820")]
	public AJKGLCKOPIP JEEPEEKFONJ()
	{
		return default(AJKGLCKOPIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4DF5030", Offset = "0x4DF3630", VA = "0x184DF5030")]
	[AsyncStateMachine(typeof(HGNJCNLKLPH<>.DOIBJIGNIJK))]
	public Task<HGNJCNLKLPH<T>.AJKGLCKOPIP> CEBOEDPKKLL(CancellationToken KMHHNOGHBLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class AHPLGKOOGMK
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8110D10", Offset = "0x810F310", VA = "0x188110D10")]
	public static HGNJCNLKLPH<DICNEKFFPEP> BFOPDLPDKBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x30B45F0", Offset = "0x30B2BF0", VA = "0x1830B45F0")]
	public static HGNJCNLKLPH<T> BFOPDLPDKBM<T>([In] T JGGFCLCGOGI) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class JPDJMBGFCJM<TData> : PELIOLHOEHA where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly string FMPMDNIMCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly TData IKFGCCPLOBI;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
	public override string GNDOFJNNOIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x51E1880", Offset = "0x51DFE80", VA = "0x1851E1880")]
	internal JPDJMBGFCJM(string CJIMOMNMAGD, [In] TData ACJFHCNBBBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class ABEICCLDGED
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8110370", Offset = "0x810E970", VA = "0x188110370")]
	public static JPDJMBGFCJM<DICNEKFFPEP> BFOPDLPDKBM(string CJIMOMNMAGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x30ACE80", Offset = "0x30AB480", VA = "0x1830ACE80")]
	public static JPDJMBGFCJM<TData> BFOPDLPDKBM<TData>(string CJIMOMNMAGD, [In] TData ACJFHCNBBBO) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class BIEJHLBKJLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	internal bool KBMAFCOIDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly string HGFNCNPJODM;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xEE9190", Offset = "0xEE7790", VA = "0x180EE9190")]
	private BIEJHLBKJLF(bool JANOEGEOKHB, string AEOHFOEEIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x8110ED0", Offset = "0x810F4D0", VA = "0x188110ED0")]
	public static BIEJHLBKJLF BFOPDLPDKBM(string AEOHFOEEIKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x8110F40", Offset = "0x810F540", VA = "0x188110F40")]
	public OAHPJMDCJGO JEJGONKBJMN()
	{
		return default(OAHPJMDCJGO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct OAHPJMDCJGO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly BIEJHLBKJLF MANAKHCFGEG;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xDE8A40", Offset = "0xDE7040", VA = "0x180DE8A40")]
	internal OAHPJMDCJGO(BIEJHLBKJLF HILCMKALFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8112DE0", Offset = "0x81113E0", VA = "0x188112DE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class JPGKOPPAOOG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class GDBJFCDFHNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public GDBJFCDFHNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x4D2B340", Offset = "0x4D29940", VA = "0x184D2B340")]
		internal int JCPIMAGPOFF(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private HashSet<T>? KLAIICOMDAA;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IReadOnlyCollection<T> LKGDJIBFCKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x51E20B0", Offset = "0x51E06B0", VA = "0x1851E20B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool HCMPKIANCOG
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x479CAE0", Offset = "0x479B0E0", VA = "0x18479CAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int DFHEGHDHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED00", Offset = "0xA4D300", VA = "0x180A4ED00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x51E20E0", Offset = "0x51E06E0", VA = "0x1851E20E0")]
	public bool JDPCENHCAFL(T DKFMAIJGPFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x51E1F90", Offset = "0x51E0590", VA = "0x1851E1F90")]
	public bool BAFGFGCDOJB(T DKFMAIJGPFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x51E2250", Offset = "0x51E0850", VA = "0x1851E2250")]
	public bool JEFAFDBINCI(T DKFMAIJGPFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x51E2290", Offset = "0x51E0890", VA = "0x1851E2290")]
	public void MFDLCKADFLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x51E2320", Offset = "0x51E0920", VA = "0x1851E2320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public JPGKOPPAOOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class GAEGCDCBFLB
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class LKAEFHPJMAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public LKAEFHPJMAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8112CB0", Offset = "0x81112B0", VA = "0x188112CB0")]
		internal int JCPIMAGPOFF(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private HashSet<object>? KLAIICOMDAA;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyCollection<object> LKGDJIBFCKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8111650", Offset = "0x810FC50", VA = "0x188111650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool HCMPKIANCOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x81116E0", Offset = "0x810FCE0", VA = "0x1881116E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int DFHEGHDHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED00", Offset = "0xA4D300", VA = "0x180A4ED00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x81116F0", Offset = "0x810FCF0", VA = "0x1881116F0")]
	public bool JDPCENHCAFL(object DKFMAIJGPFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x81115B0", Offset = "0x810FBB0", VA = "0x1881115B0")]
	public bool BAFGFGCDOJB(object DKFMAIJGPFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x81117D0", Offset = "0x810FDD0", VA = "0x1881117D0")]
	public bool JEFAFDBINCI(object DKFMAIJGPFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x8111830", Offset = "0x810FE30", VA = "0x188111830")]
	public void MFDLCKADFLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x81118A0", Offset = "0x810FEA0", VA = "0x1881118A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public GAEGCDCBFLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class MAGBICPAAPJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private struct GJBGLMPKJDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float FBPGPNOLBIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public T IBMJNNAJGNM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<object, GJBGLMPKJDK> JJAIEIEJJFM;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public virtual T DIKOLMDCEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x118AFC0", Offset = "0x11895C0", VA = "0x18118AFC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1B22190", Offset = "0x1B20790", VA = "0x181B22190", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public object? DKMMAOPOMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool LDLDDGMKCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x55F1630", Offset = "0x55EFC30", VA = "0x1855F1630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x55F18F0", Offset = "0x55EFEF0", VA = "0x1855F18F0")]
	public bool MOIPAGPLCIG(T KKGBKLFKCPO, object DKFMAIJGPFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x55F1680", Offset = "0x55EFC80", VA = "0x1855F1680")]
	public bool LHGDLAOELLI(object DKFMAIJGPFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x55F1600", Offset = "0x55EFC00", VA = "0x1855F1600")]
	public void HHCEOPNNHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x55F1EF0", Offset = "0x55F04F0", VA = "0x1855F1EF0")]
	public bool OMCPIMBCGII(object DKFMAIJGPFL, [Out] T KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x55F2280", Offset = "0x55F0880", VA = "0x1855F2280")]
	[OAODFBDCNNK("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool POFMPFMBLIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x55F3940", Offset = "0x55F1F40", VA = "0x1855F3940")]
	public MAGBICPAAPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class CNLFNDCNGIC : EPFIDCNKKBC<ANCHKNHFGEI>
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	internal class PPPLHHKINNE : IEqualityComparer<ANCHKNHFGEI>
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		internal static readonly PPPLHHKINNE FNIBPMLJKFE;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8113D20", Offset = "0x8112320", VA = "0x188113D20", Slot = "4")]
		public bool Equals(ANCHKNHFGEI POMHCCBBBGD, ANCHKNHFGEI JKKMGDMGNFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7227CF0", Offset = "0x72262F0", VA = "0x187227CF0", Slot = "5")]
		public int GetHashCode(ANCHKNHFGEI ODCICEDDLMB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public PPPLHHKINNE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x81111F0", Offset = "0x810F7F0", VA = "0x1881111F0")]
	public CNLFNDCNGIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x81110B0", Offset = "0x810F6B0", VA = "0x1881110B0", Slot = "4")]
	public override bool JDPCENHCAFL(ANCHKNHFGEI DKFMAIJGPFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8111000", Offset = "0x810F600", VA = "0x188111000", Slot = "5")]
	public override bool BAFGFGCDOJB(ANCHKNHFGEI DKFMAIJGPFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8111160", Offset = "0x810F760", VA = "0x188111160")]
	private static void KGALHOOICEC(ANCHKNHFGEI DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x1A1DFF0", Offset = "0x1A1C5F0", VA = "0x181A1DFF0", Slot = "6")]
	protected override string TokenToString(ANCHKNHFGEI DKFMAIJGPFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class ANCHKNHFGEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly string EAIABOADAEG;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0xA4B570", Offset = "0xA49B70", VA = "0x180A4B570")]
	public ANCHKNHFGEI(string EAIABOADAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x8110DE0", Offset = "0x810F3E0", VA = "0x188110DE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public abstract class EPFIDCNKKBC<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly IEqualityComparer<T> NJKFJEICBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private HashSet<T>? KLAIICOMDAA;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public IReadOnlyCollection<T> LKGDJIBFCKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x479CAB0", Offset = "0x479B0B0", VA = "0x18479CAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool HCMPKIANCOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x479CAE0", Offset = "0x479B0E0", VA = "0x18479CAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int DFHEGHDHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xAB1080", Offset = "0xAAF680", VA = "0x180AB1080")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xD36F90", Offset = "0xD35590", VA = "0x180D36F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x479D4A0", Offset = "0x479BAA0", VA = "0x18479D4A0")]
	public EPFIDCNKKBC(IEqualityComparer<T> NJKFJEICBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x479CB20", Offset = "0x479B120", VA = "0x18479CB20", Slot = "4")]
	public virtual bool JDPCENHCAFL(T DKFMAIJGPFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x479C860", Offset = "0x479AE60", VA = "0x18479C860", Slot = "5")]
	public virtual bool BAFGFGCDOJB(T DKFMAIJGPFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x479CE30", Offset = "0x479B430", VA = "0x18479CE30")]
	public void MFDLCKADFLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x479D1A0", Offset = "0x479B7A0", VA = "0x18479D1A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class BCMOPEBHIIA<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private List<WeakReference<T>>? KLAIICOMDAA;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool HCMPKIANCOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x61400B0", Offset = "0x613E6B0", VA = "0x1861400B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int DFHEGHDHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x613FF50", Offset = "0x613E550", VA = "0x18613FF50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x61401B0", Offset = "0x613E7B0", VA = "0x1861401B0")]
	public void JDPCENHCAFL(T DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x613FDF0", Offset = "0x613E3F0", VA = "0x18613FDF0")]
	public void BAFGFGCDOJB(T DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x61403D0", Offset = "0x613E9D0", VA = "0x1861403D0")]
	public bool JEFAFDBINCI(T DKFMAIJGPFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x61404F0", Offset = "0x613EAF0", VA = "0x1861404F0")]
	public void MFDLCKADFLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6140510", Offset = "0x613EB10", VA = "0x186140510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public BCMOPEBHIIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal static class HNIMKLMBCJP
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3B67890", Offset = "0x3B65E90", VA = "0x183B67890")]
	public static void EDPAJEFJMAB<T>(this List<T> BGGFBGFNIID, int KHMHPNKMLMD) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class NMJCGMHFGJL<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct CNLFBBOMGCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public float FBPGPNOLBIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T IBMJNNAJGNM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Dictionary<ANCHKNHFGEI, CNLFBBOMGCK> JJAIEIEJJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly EqualityComparer<T> PBHKDMAHCGF;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public virtual T DIKOLMDCEPK
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA50EA0", Offset = "0xA4F4A0", VA = "0x180A50EA0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA50E40", Offset = "0xA4F440", VA = "0x180A50E40", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private ANCHKNHFGEI? DKMMAOPOMDF
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool LDLDDGMKCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x55F1630", Offset = "0x55EFC30", VA = "0x1855F1630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x569FE80", Offset = "0x569E480", VA = "0x18569FE80")]
	public bool MOIPAGPLCIG(T KKGBKLFKCPO, ANCHKNHFGEI DKFMAIJGPFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x55F1680", Offset = "0x55EFC80", VA = "0x1855F1680")]
	public bool LHGDLAOELLI(ANCHKNHFGEI DKFMAIJGPFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x55F1600", Offset = "0x55EFC00", VA = "0x1855F1600")]
	public void HHCEOPNNHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x55F2010", Offset = "0x55F0610", VA = "0x1855F2010")]
	public bool OMCPIMBCGII(ANCHKNHFGEI DKFMAIJGPFL, [Out] T KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x56A0240", Offset = "0x569E840", VA = "0x1856A0240")]
	[OAODFBDCNNK("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool POFMPFMBLIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x56A0600", Offset = "0x569EC00", VA = "0x1856A0600")]
	public NMJCGMHFGJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class GBMGCPLFIEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Dictionary<object, float> JJAIEIEJJFM;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float PNHJCBACFBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xAA7CA0", Offset = "0xAA62A0", VA = "0x180AA7CA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x12D2820", Offset = "0x12D0E20", VA = "0x1812D2820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x8111C40", Offset = "0x8110240", VA = "0x188111C40")]
	public void MOIPAGPLCIG(float KKGBKLFKCPO, object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x8111BD0", Offset = "0x81101D0", VA = "0x188111BD0")]
	public void LHGDLAOELLI(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x8111B80", Offset = "0x8110180", VA = "0x188111B80")]
	public void HHCEOPNNHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x8111A50", Offset = "0x8110050", VA = "0x188111A50")]
	private void BGNEBOELILA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8111CB0", Offset = "0x81102B0", VA = "0x188111CB0")]
	public GBMGCPLFIEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface CDFFLGJDJOC
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event CNAAIHJLCGH DECFFNKCHGD;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class AFLGFKBHKAI : CDFFLGJDJOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public readonly struct EKINLKHDPGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly float BNJPFDALMCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly float JKOBIMNAGJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal readonly bool LAPKEHOOABF;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float GBKBNOBKILL
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x81112A0", Offset = "0x810F8A0", VA = "0x1881112A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8111410", Offset = "0x810FA10", VA = "0x188111410")]
		public EKINLKHDPGO(float BKJCDJJKAFA, float KNOCDJABJLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x81112B0", Offset = "0x810F8B0", VA = "0x1881112B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class APHKDMEJBFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AFLGFKBHKAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public APHKDMEJBFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8110E30", Offset = "0x810F430", VA = "0x188110E30")]
		internal void KINGIMEBOBE(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int BJPLKLLFDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int KKNHHEBLBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly CDFFLGJDJOC[] NMDFNNKODBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CNAAIHJLCGH[] ACIHABPADPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly EKINLKHDPGO[] LILMDMMLJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private EKINLKHDPGO IMKKNAIIODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly PFPFHKOPDKJ DOFPOIFHOIH;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event CNAAIHJLCGH DECFFNKCHGD
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x81103F0", Offset = "0x810E9F0", VA = "0x1881103F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8110AC0", Offset = "0x810F0C0", VA = "0x188110AC0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8110B80", Offset = "0x810F180", VA = "0x188110B80")]
	public AFLGFKBHKAI(int BJPLKLLFDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x81105C0", Offset = "0x810EBC0", VA = "0x1881105C0")]
	public PFPFHKOPDKJ FMOLDGFBDON(EKINLKHDPGO EHECCAJFJLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x8110650", Offset = "0x810EC50", VA = "0x188110650")]
	public void IKCMEHAPFIB(CDFFLGJDJOC COJFJHBILKD, [Optional] EKINLKHDPGO GGKHEMCJMBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x81104B0", Offset = "0x810EAB0", VA = "0x1881104B0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate void CNAAIHJLCGH(float JHIEFLJEGFB);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class KLLJPPPPKIN
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class PPEIAAONMLG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly CDFFLGJDJOC NNDCIGAFNFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly CNAAIHJLCGH BNOBGIHHJGL;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8113C90", Offset = "0x8112290", VA = "0x188113C90")]
		public PPEIAAONMLG(CDFFLGJDJOC NNDCIGAFNFB, CNAAIHJLCGH BNOBGIHHJGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8113C40", Offset = "0x8112240", VA = "0x188113C40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x8112920", Offset = "0x8110F20", VA = "0x188112920")]
	internal static bool ONMFHJIGJKC(float DLGEPLKGJOC, float OKKFDNDPGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x80FDD20", Offset = "0x80FC320", VA = "0x1880FDD20")]
	internal static float CHKJNEIDKCL(float DLGEPLKGJOC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x8112860", Offset = "0x8110E60", VA = "0x188112860")]
	public static IDisposable BEBMIJKJMJI(this CDFFLGJDJOC NNDCIGAFNFB, CNAAIHJLCGH BNOBGIHHJGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class PFPFHKOPDKJ : CDFFLGJDJOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float JHIEFLJEGFB;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public float CBNCBHGGJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x81139B0", Offset = "0x8111FB0", VA = "0x1881139B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event CNAAIHJLCGH? DECFFNKCHGD
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8113AA0", Offset = "0x81120A0", VA = "0x188113AA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8113B40", Offset = "0x8112140", VA = "0x188113B40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public PFPFHKOPDKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface OFJDLOEAMCE<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NHNOBABIOMF<T> PMCFFHGKNGL([Out] T KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HHCEOPNNHLH();
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class FDMGGFGGDAP<T> : OFJDLOEAMCE<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly ConcurrentStack<T> KAEGLEOFKEO;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x4BF6B40", Offset = "0x4BF5140", VA = "0x184BF6B40", Slot = "4")]
	public NHNOBABIOMF<T> PMCFFHGKNGL([Out] T KKGBKLFKCPO)
	{
		return default(NHNOBABIOMF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x4BF6AE0", Offset = "0x4BF50E0", VA = "0x184BF6AE0")]
	public void MFOHPABGFFE(T ANCHFIBNNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x4BF2490", Offset = "0x4BF0A90", VA = "0x184BF2490", Slot = "5")]
	public void HHCEOPNNHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "6")]
	protected virtual void PKFKCHPNAME(T LGIDABAFAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x4BF6A50", Offset = "0x4BF5050", VA = "0x184BF6A50")]
	private T KBGIPADPFGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x4BF6BD0", Offset = "0x4BF51D0", VA = "0x184BF6BD0")]
	public FDMGGFGGDAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct NHNOBABIOMF<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly T ANCHFIBNNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly FDMGGFGGDAP<T> GEKOKKIKPJO;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0xB8E8F0", Offset = "0xB8CEF0", VA = "0x180B8E8F0")]
	internal NHNOBABIOMF(T KKGBKLFKCPO, FDMGGFGGDAP<T> GEKOKKIKPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5692BF0", Offset = "0x56911F0", VA = "0x185692BF0", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class IGFHNGPDMEE : FDMGGFGGDAP<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static readonly IGFHNGPDMEE FNIBPMLJKFE;

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x8111DB0", Offset = "0x81103B0", VA = "0x188111DB0")]
	public static NHNOBABIOMF<StringBuilder> KBGIPADPFGF([Out] StringBuilder KKGBKLFKCPO)
	{
		return default(NHNOBABIOMF<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x8111E50", Offset = "0x8110450", VA = "0x188111E50", Slot = "6")]
	protected override void PKFKCHPNAME(StringBuilder LGIDABAFAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x8111F10", Offset = "0x8110510", VA = "0x188111F10")]
	public IGFHNGPDMEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class KMOMDLGJGOP : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x798A590", Offset = "0x7988B90", VA = "0x18798A590")]
	public KMOMDLGJGOP(string CJIMOMNMAGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DefaultMember("Item")]
public class PLDPJPIGHOD<TKey, TValue> : DGLJKAIJCNM<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, HJPHGNHDNLD where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class HFHHPHBPANP : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public PLDPJPIGHOD<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x118AFC0", Offset = "0x11895C0", VA = "0x18118AFC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4CDC4D0", Offset = "0x4CDAAD0", VA = "0x184CDC4D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
		[DebuggerHidden]
		public HFHHPHBPANP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4CDC6E0", Offset = "0x4CDACE0", VA = "0x184CDC6E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4DEFD90", Offset = "0x4DEE390", VA = "0x184DEFD90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4DEFCF0", Offset = "0x4DEE2F0", VA = "0x184DEFCF0")]
		private void APENNGMAANK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4DF0A80", Offset = "0x4DEF080", VA = "0x184DF0A80")]
		private void NECCDOCMECN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4DF0B70", Offset = "0x4DEF170", VA = "0x184DF0B70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly DGLJKAIJCNM<TKey, TValue> MKBJKDMGGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IDictionary<TKey, TValue> JKIMEAOPDGP;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int DFHEGHDHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x58EB3B0", Offset = "0x58E99B0", VA = "0x1858EB3B0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool KJKCBDBHHDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public TValue FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x58EB580", Offset = "0x58E9B80", VA = "0x1858EB580", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x58EB7E0", Offset = "0x58E9DE0", VA = "0x1858EB7E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICollection<TKey> BGEMCKDNFCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x58EB5C0", Offset = "0x58E9BC0", VA = "0x1858EB5C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public ICollection<TValue> NAOPAJFMJFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x58EB6D0", Offset = "0x58E9CD0", VA = "0x1858EB6D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x58EB230", Offset = "0x58E9830", VA = "0x1858EB230")]
	public PLDPJPIGHOD(DGLJKAIJCNM<TKey, TValue> MKBJKDMGGCD, [Optional] IDictionary<TKey, TValue>? JKIMEAOPDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x58E8B70", Offset = "0x58E7170", VA = "0x1858E8B70", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x58E9420", Offset = "0x58E7A20", VA = "0x1858E9420")]
	public void FBLKFOBHLON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x58E86C0", Offset = "0x58E6CC0", VA = "0x1858E86C0", Slot = "9")]
	public void Add(TKey BLIBAMJKLIA, TValue KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x58E9470", Offset = "0x58E7A70", VA = "0x1858E9470")]
	public void FJLDNGIDNGF(TKey BLIBAMJKLIA, TValue KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x58E96D0", Offset = "0x58E7CD0", VA = "0x1858E96D0")]
	public void GDNDDLEEPCB(TKey BLIBAMJKLIA, TValue KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x58EA2D0", Offset = "0x58E88D0", VA = "0x1858EA2D0")]
	public void MNKEMABLLEB(TKey BLIBAMJKLIA, TValue KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x58E9EC0", Offset = "0x58E84C0", VA = "0x1858E9EC0")]
	public void LCOJOFDNMLE(TKey BLIBAMJKLIA, TValue KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x58EA890", Offset = "0x58E8E90", VA = "0x1858EA890", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> GANFJJCKLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x58EA8F0", Offset = "0x58E8EF0", VA = "0x1858EA8F0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x58EADF0", Offset = "0x58E93F0", VA = "0x1858EADF0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x58E8C80", Offset = "0x58E7280", VA = "0x1858E8C80", Slot = "8")]
	public bool ContainsKey(TKey BLIBAMJKLIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x58EA560", Offset = "0x58E8B60", VA = "0x1858EA560")]
	public bool NLFLIPKFJFE(TKey BLIBAMJKLIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x58E9AB0", Offset = "0x58E80B0", VA = "0x1858E9AB0")]
	public bool KGDMGJNLMOJ(TKey BLIBAMJKLIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x58EA6F0", Offset = "0x58E8CF0", VA = "0x1858EA6F0", Slot = "10")]
	public bool Remove(TKey BLIBAMJKLIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x58EB090", Offset = "0x58E9690", VA = "0x1858EB090", Slot = "11")]
	public bool TryGetValue(TKey BLIBAMJKLIA, [Out] TValue KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x58E8F80", Offset = "0x58E7580", VA = "0x1858E8F80", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] DDENONPPKCL, int FKFIMLILJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x5269950", Offset = "0x5267F50", VA = "0x185269950", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x58E9930", Offset = "0x58E7F30", VA = "0x1858E9930", Slot = "19")]
	[IteratorStateMachine(typeof(PLDPJPIGHOD<, >.HFHHPHBPANP))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x58EA000", Offset = "0x58E8600", VA = "0x1858EA000", Slot = "21")]
	public bool MABPHBKHEFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x58E9D30", Offset = "0x58E8330", VA = "0x1858E9D30")]
	private TValue KIMBJEMAAIO(TKey BLIBAMJKLIA)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface FKCAPMJPMEO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string NLLNKFCFEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface HJPHGNHDNLD
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MABPHBKHEFP();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface DGLJKAIJCNM<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, HJPHGNHDNLD
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[DefaultMember("Item")]
public sealed class GMAPHMCBPAK<TKey, TVal> : DGLJKAIJCNM<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, HJPHGNHDNLD where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public delegate int NGBCNHKHKPC(TKey BLIBAMJKLIA, TVal KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate void GCGDIHLOLMJ(TKey BLIBAMJKLIA, TVal KKGBKLFKCPO, ECJDFOIJEFN CIOGCOOPLBM);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class KLGDIDDOGDI
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public TKey MBLBFBKCCDA
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xDF7680", Offset = "0xDF5C80", VA = "0x180DF7680")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public TVal IBMJNNAJGNM
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xAB1080", Offset = "0xAAF680", VA = "0x180AB1080")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xD36F90", Offset = "0xD35590", VA = "0x180D36F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public int GBKBNOBKILL
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xAB10B0", Offset = "0xAAF6B0", VA = "0x180AB10B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xFA8E10", Offset = "0xFA7410", VA = "0x180FA8E10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public DateTimeOffset AGPMAIALPPO
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x131A980", Offset = "0x1318F80", VA = "0x18131A980")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x142C6E0", Offset = "0x142ACE0", VA = "0x18142C6E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x52DBF50", Offset = "0x52DA550", VA = "0x1852DBF50")]
		public KLGDIDDOGDI(TKey BLIBAMJKLIA, TVal FADBOFNILPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class AOMJNHLCPCH : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public GMAPHMCBPAK<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private LinkedList<KLGDIDDOGDI>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x118AFC0", Offset = "0x11895C0", VA = "0x18118AFC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F9C7A0", Offset = "0x4F9ADA0", VA = "0x184F9C7A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
		[DebuggerHidden]
		public AOMJNHLCPCH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x4CD68B0", Offset = "0x4CD4EB0", VA = "0x184CD68B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4F9A020", Offset = "0x4F98620", VA = "0x184F9A020", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4F99FE0", Offset = "0x4F985E0", VA = "0x184F99FE0")]
		private void APENNGMAANK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4F9C610", Offset = "0x4F9AC10", VA = "0x184F9C610", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public const int ODFGKDJPJLH = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly Dictionary<TKey, LinkedListNode<KLGDIDDOGDI>> DKAGBKDJJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly LinkedList<KLGDIDDOGDI> HAOOFJGOONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly NGBCNHKHKPC? EMKAOHJBAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly TimeSpan LIOLOBPHGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly GCGDIHLOLMJ? KIBPLDEABEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly HAADHJPIIJM LJHIDKFDADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool EHMFDAMNOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly List<TKey> NAFAKEHCFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly List<TVal> MJAADCHCGOJ;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int JPIBFMDDODB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xCA6390", Offset = "0xCA4990", VA = "0x180CA6390")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	internal int EILHGDCFEHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xDED9B0", Offset = "0xDEBFB0", VA = "0x180DED9B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xF2C2C0", Offset = "0xF2A8C0", VA = "0x180F2C2C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int DFHEGHDHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x4D7F790", Offset = "0x4D7DD90", VA = "0x184D7F790", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	internal int FLKJBOCGOCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4D6D170", Offset = "0x4D6B770", VA = "0x184D6D170")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public ICollection<TVal> NAOPAJFMJFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x4D7F8C0", Offset = "0x4D7DEC0", VA = "0x184D7F8C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	ICollection<TKey> IDictionary<TKey, TVal>.NEIELBGHOCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x4D7B570", Offset = "0x4D79B70", VA = "0x184D7B570", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool KJKCBDBHHDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public TVal FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x4D7F870", Offset = "0x4D7DE70", VA = "0x184D7F870", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x4D7F8F0", Offset = "0x4D7DEF0", VA = "0x184D7F8F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4D6CEE0", Offset = "0x4D6B4E0", VA = "0x184D6CEE0")]
	private bool ENNLHKEIHKA(int BJPLKLLFDMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4D792E0", Offset = "0x4D778E0", VA = "0x184D792E0")]
	private void NPMMEFAIPKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4D7C310", Offset = "0x4D7A910", VA = "0x184D7C310")]
	public GMAPHMCBPAK(int BJPLKLLFDMG, [Optional] NGBCNHKHKPC? EMKAOHJBAIL, [Optional] IEqualityComparer<TKey>? IONKDIAAPCK, [Optional] GCGDIHLOLMJ? KIBPLDEABEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4D7C490", Offset = "0x4D7AA90", VA = "0x184D7C490")]
	public GMAPHMCBPAK(TimeSpan LIOLOBPHGOE, [Optional] IEqualityComparer<TKey>? IONKDIAAPCK, [Optional] GCGDIHLOLMJ? KIBPLDEABEJ, [Optional] HAADHJPIIJM? LJHIDKFDADN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4D7C200", Offset = "0x4D7A800", VA = "0x184D7C200")]
	public GMAPHMCBPAK(int BJPLKLLFDMG, TimeSpan LIOLOBPHGOE, [Optional] IEqualityComparer<TKey>? IONKDIAAPCK, [Optional] GCGDIHLOLMJ? KIBPLDEABEJ, [Optional] HAADHJPIIJM? LJHIDKFDADN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x4D7D000", Offset = "0x4D7B600", VA = "0x184D7D000")]
	public GMAPHMCBPAK(int BJPLKLLFDMG, NGBCNHKHKPC? EMKAOHJBAIL, TimeSpan LIOLOBPHGOE, [Optional] IEqualityComparer<TKey>? IONKDIAAPCK, [Optional] GCGDIHLOLMJ? KIBPLDEABEJ, [Optional] HAADHJPIIJM? LJHIDKFDADN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x4D72D70", Offset = "0x4D71370", VA = "0x184D72D70", Slot = "21")]
	public bool MABPHBKHEFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x4D70F10", Offset = "0x4D6F510", VA = "0x184D70F10", Slot = "22")]
	public bool JPDMIGMMFBF(int GPNBMIDFKMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x4D6D1B0", Offset = "0x4D6B7B0", VA = "0x184D6D1B0")]
	private bool HLPDBGBMHGM(int GPNBMIDFKMK, ECJDFOIJEFN CIOGCOOPLBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x4D6A3A0", Offset = "0x4D689A0", VA = "0x184D6A3A0")]
	public void BNAKHNGOEHD(TKey BLIBAMJKLIA, TVal KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x4D68FE0", Offset = "0x4D675E0", VA = "0x184D68FE0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> GANFJJCKLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x4D68AD0", Offset = "0x4D670D0", VA = "0x184D68AD0", Slot = "9")]
	public void Add(TKey BLIBAMJKLIA, TVal KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x4D6AA60", Offset = "0x4D69060", VA = "0x184D6AA60", Slot = "8")]
	public bool ContainsKey(TKey BLIBAMJKLIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x4D7AC90", Offset = "0x4D79290", VA = "0x184D7AC90", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4D7A660", Offset = "0x4D78C60", VA = "0x184D7A660", Slot = "10")]
	public bool Remove(TKey BLIBAMJKLIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x4D7B0F0", Offset = "0x4D796F0", VA = "0x184D7B0F0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4D69290", Offset = "0x4D67890", VA = "0x184D69290")]
	private bool BALFHJENLLH(TKey BLIBAMJKLIA, [Out] TVal KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x4D71AB0", Offset = "0x4D700B0", VA = "0x184D71AB0")]
	private TVal KBGIPADPFGF(TKey BIPFMGFLODL)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x4D7BCC0", Offset = "0x4D7A2C0", VA = "0x184D7BCC0", Slot = "11")]
	public bool TryGetValue(TKey BIPFMGFLODL, [Out] TVal KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4D6A820", Offset = "0x4D68E20", VA = "0x184D6A820", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x4D6AE00", Offset = "0x4D69400", VA = "0x184D6AE00", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] DDENONPPKCL, int FKFIMLILJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x4D79730", Offset = "0x4D77D30", VA = "0x184D79730")]
	private void OJJNADNHOPA(TKey BLIBAMJKLIA, TVal FADBOFNILPL, ECJDFOIJEFN CIOGCOOPLBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x4D71DA0", Offset = "0x4D703A0", VA = "0x184D71DA0")]
	private bool LDGEHGONJOM(KLGDIDDOGDI FOBOJKOJPBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x4D72DE0", Offset = "0x4D713E0", VA = "0x184D72DE0")]
	private void MGLLAKBKAME(LinkedListNode<KLGDIDDOGDI> EFJNDNKLKIO, TVal FHKIBFJAKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x4D78000", Offset = "0x4D76600", VA = "0x184D78000")]
	private void MOIPAGPLCIG(TKey BLIBAMJKLIA, TVal KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x4D765C0", Offset = "0x4D74BC0", VA = "0x184D765C0")]
	private void MIOAHJFFIKL(KLGDIDDOGDI FOBOJKOJPBJ, TVal FHKIBFJAKOF, int AOAPAPHIJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4D6CFC0", Offset = "0x4D6B5C0", VA = "0x184D6CFC0", Slot = "19")]
	[IteratorStateMachine(typeof(GMAPHMCBPAK<, >.AOMJNHLCPCH))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4D7B5A0", Offset = "0x4D79BA0", VA = "0x184D7B5A0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public enum ECJDFOIJEFN : byte
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
public class PLMFAFONMAK<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly TKey KNMDDADFMJP;

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x58F2A80", Offset = "0x58F1080", VA = "0x1858F2A80")]
	public PLMFAFONMAK(TKey FLILOGCHLIH, Exception OGLKKFPLOGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class GDPNFOOMCOJ : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x71C15E0", Offset = "0x71BFBE0", VA = "0x1871C15E0")]
	public GDPNFOOMCOJ(string CJIMOMNMAGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class DBPOMMLFDMH<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class BAONJFAELHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public DBPOMMLFDMH<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public BAONJFAELHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x613C460", Offset = "0x613AA60", VA = "0x18613C460")]
		internal Task<TResource> MKHBFOFCBFL(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct KAMGCFKEOLE : IAsyncStateMachine
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
		public DBPOMMLFDMH<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x528E280", Offset = "0x528C880", VA = "0x18528E280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x528EEE0", Offset = "0x528D4E0", VA = "0x18528EEE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct BNIEHKBAHJC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x62F4F80", Offset = "0x62F3580", VA = "0x1862F4F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x62F5D20", Offset = "0x62F4320", VA = "0x1862F5D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly FCNHJGNMNIP<TId, Task<TResource>> AGFIPAOOPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> HHLCANMNEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? CAADHFKHIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Action<TResource>? KJCDLMLLBAD;

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6CBADB0", Offset = "0x6CB93B0", VA = "0x186CBADB0")]
	public DBPOMMLFDMH(int AHOJNIBNPCF = 0, [Optional] IEqualityComparer<TId>? LGAOLIIOJIG, [Optional] Func<TId, CancellationToken, Task<TResource>>? EKAOBFNKFLN, [Optional] Action<TResource>? BBGDKBJDMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA260", Offset = "0x6CB8860", VA = "0x186CBA260")]
	public PGDJPLOBHJM<Task<TResource>> EFGLLEDOIBC(TId HLIPPIOIAJK, [Optional] Func<TId, CancellationToken, Task<TResource>>? EKAOBFNKFLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6CBAAD0", Offset = "0x6CB90D0", VA = "0x186CBAAD0")]
	private void LGNABDJFKGF(Task<TResource> NPLKHMALANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9C60", Offset = "0x6CB8260", VA = "0x186CB9C60")]
	[AsyncStateMachine(typeof(DBPOMMLFDMH<, >.KAMGCFKEOLE))]
	private Task DEFLCEDILJD(Task<TResource> NPLKHMALANM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA770", Offset = "0x6CB8D70", VA = "0x186CBA770")]
	public void HOFEHCFMDCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9F60", Offset = "0x6CB8560", VA = "0x186CB9F60")]
	public FCNHJGNMNIP<TId, Task<TResource>>.BGGLENIMNDF DHKFMABLBKB()
	{
		return default(FCNHJGNMNIP<TId, Task<TResource>>.BGGLENIMNDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6CBAD10", Offset = "0x6CB9310", VA = "0x186CBAD10", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6CBAD10", Offset = "0x6CB9310", VA = "0x186CBAD10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6CB96A0", Offset = "0x6CB7CA0", VA = "0x186CB96A0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(DBPOMMLFDMH<, >.BNIEHKBAHJC))]
	internal static Task DBNDMCAIJBH(Task<TResource> NPLKHMALANM, CancellationTokenSource OLINDFJIJKJ, Dictionary<Task<TResource>, CancellationTokenSource> GKJEDEKFCAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class FCNHJGNMNIP<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class LLINMMDLOEN : IEquatable<LLINMMDLOEN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public readonly TValue IBMJNNAJGNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int NAIMFAPIPLH;

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x12879E0", Offset = "0x1285FE0", VA = "0x1812879E0")]
		public LLINMMDLOEN(TValue KKGBKLFKCPO, int GDBPOLBGEDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x5429F50", Offset = "0x5428550", VA = "0x185429F50", Slot = "4")]
		public bool Equals(LLINMMDLOEN? HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x5429FE0", Offset = "0x54285E0", VA = "0x185429FE0", Slot = "0")]
		public override bool Equals(object? ODCICEDDLMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x542A110", Offset = "0x5428710", VA = "0x18542A110", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public struct BGGLENIMNDF : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Dictionary<TKey, LLINMMDLOEN>.Enumerator JDEHPHJHIJP;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x615BEF0", Offset = "0x615A4F0", VA = "0x18615BEF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public (TKey Key, TValue Value, int RefCount) CGHPBCAOGAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x615C310", Offset = "0x615A910", VA = "0x18615C310", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x615BF90", Offset = "0x615A590", VA = "0x18615BF90")]
		public BGGLENIMNDF(FCNHJGNMNIP<TKey, TValue> JJAIEIEJJFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x615B9E0", Offset = "0x6159FE0", VA = "0x18615B9E0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x615BA60", Offset = "0x615A060", VA = "0x18615BA60", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x615BC40", Offset = "0x615A240", VA = "0x18615BC40", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class MBFOGFDMLJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public FCNHJGNMNIP<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public LLINMMDLOEN refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public MBFOGFDMLJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x55F9900", Offset = "0x55F7F00", VA = "0x1855F9900")]
		internal void MKHBFOFCBFL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<TKey, LLINMMDLOEN> PIDKGCPMJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Func<TKey, TValue>? JPPEPIIAOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TValue>? GAPIBIPHIIK;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x4BF58A0", Offset = "0x4BF3EA0", VA = "0x184BF58A0")]
	public FCNHJGNMNIP(int AHOJNIBNPCF = 0, [Optional] IEqualityComparer<TKey>? IONKDIAAPCK, [Optional] Func<TKey, TValue>? AHNBKNDPCAO, [Optional] Action<TValue>? OOFAHFDDIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4BF5240", Offset = "0x4BF3840", VA = "0x184BF5240")]
	public PGDJPLOBHJM<TValue> EFGLLEDOIBC(TKey BLIBAMJKLIA, [Optional] Func<TKey, TValue>? HEENHLCGNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x4BF5700", Offset = "0x4BF3D00", VA = "0x184BF5700")]
	private void MFOHPABGFFE(TKey BLIBAMJKLIA, LLINMMDLOEN KIKPPBPPPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x4BF5510", Offset = "0x4BF3B10", VA = "0x184BF5510")]
	public void HOFEHCFMDCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4BF5200", Offset = "0x4BF3800", VA = "0x184BF5200")]
	public BGGLENIMNDF DHKFMABLBKB()
	{
		return default(BGGLENIMNDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x4BF5800", Offset = "0x4BF3E00", VA = "0x184BF5800", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4BF5800", Offset = "0x4BF3E00", VA = "0x184BF5800", Slot = "5")]
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
