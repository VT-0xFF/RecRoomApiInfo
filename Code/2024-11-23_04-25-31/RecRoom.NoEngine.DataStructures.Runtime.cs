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
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8DD0", Offset = "0x6EE77D0", VA = "0x186EE8DD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D7890", Offset = "0x8D6290", VA = "0x1808D7890")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8D78D0", Offset = "0x8D62D0", VA = "0x1808D78D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class JPGOIHNLIKO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	protected JPGOIHNLIKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class FPOJALAAGLO<T> : JPGOIHNLIKO
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct FKIKLPDIFJB
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum FKOGOFEIJLP
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
		public FKOGOFEIJLP BKKHBFLPOHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T EFFBNJEBEKP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int GPEIDDMGLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool LIGDMGFCIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool LHHEFEIHCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? EBHDGHGBAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<FKIKLPDIFJB>? BHJAPOGMLKK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool OHOIPAHJOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x403A2F0", Offset = "0x4038CF0", VA = "0x18403A2F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x403A890", Offset = "0x4039290", VA = "0x18403A890")]
	protected FPOJALAAGLO(bool LHHEFEIHCAA, bool LIGDMGFCIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4039FB0", Offset = "0x40389B0", VA = "0x184039FB0")]
	protected bool DNAIECOCMDI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x403A360", Offset = "0x4038D60", VA = "0x18403A360")]
	protected void MEIHBBAJMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x403A050", Offset = "0x4038A50", VA = "0x18403A050")]
	protected void GOILDOODDLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2E1EFD0", Offset = "0x2E1D9D0", VA = "0x182E1EFD0")]
	private static void NCKKAFMNNHE<U>(List<U>? HIOONLIPGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x403A490", Offset = "0x4038E90", VA = "0x18403A490", Slot = "4")]
	public void NOEGDDICEDP(T EFFBNJEBEKP, bool FOAEHIJAELO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x403A6B0", Offset = "0x40390B0", VA = "0x18403A6B0", Slot = "5")]
	public void PJOABDGMIKH(T EFFBNJEBEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4039DF0", Offset = "0x40387F0", VA = "0x184039DF0")]
	public void CFGGIHGKNGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class APNHDGDPKOI : FPOJALAAGLO<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6FE0", Offset = "0x6EE59E0", VA = "0x186EE6FE0")]
	public APNHDGDPKOI(bool LHHEFEIHCAA = false, bool LIGDMGFCIDH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6D20", Offset = "0x6EE5720", VA = "0x186EE6D20")]
	public void GHJBKJMLHEK()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6F80", Offset = "0x6EE5980", VA = "0x186EE6F80")]
	public static APNHDGDPKOI OGAJIJOBEEF(APNHDGDPKOI MNINCPENHLD, Action EFFBNJEBEKP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6F20", Offset = "0x6EE5920", VA = "0x186EE6F20")]
	public static APNHDGDPKOI ODAAIPMOAKM(APNHDGDPKOI MNINCPENHLD, Action EFFBNJEBEKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DHPLOJPHLPI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NOEGDDICEDP(Action<T> EFFBNJEBEKP, bool FOAEHIJAELO = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PJOABDGMIKH(Action<T> EFFBNJEBEKP);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class ABIBNEMCANM<T> : FPOJALAAGLO<Action<T>>, DHPLOJPHLPI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3FB70D0", Offset = "0x3FB5AD0", VA = "0x183FB70D0")]
	public ABIBNEMCANM(bool LHHEFEIHCAA = false, bool LIGDMGFCIDH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4097C60", Offset = "0x4096660", VA = "0x184097C60")]
	public void GHJBKJMLHEK(T FOFGABNNIOJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x40983C0", Offset = "0x4096DC0", VA = "0x1840983C0")]
	public static ABIBNEMCANM<T> OGAJIJOBEEF(ABIBNEMCANM<T> MNINCPENHLD, Action<T> EFFBNJEBEKP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4098320", Offset = "0x4096D20", VA = "0x184098320")]
	public static ABIBNEMCANM<T> ODAAIPMOAKM(ABIBNEMCANM<T> MNINCPENHLD, Action<T> EFFBNJEBEKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ECDJEKNBHFC<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class KECBCJGCBNA<T, U> : FPOJALAAGLO<Action<T, U>>, ECDJEKNBHFC<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3FB70D0", Offset = "0x3FB5AD0", VA = "0x183FB70D0")]
	public KECBCJGCBNA(bool LHHEFEIHCAA = false, bool LIGDMGFCIDH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x45210B0", Offset = "0x451FAB0", VA = "0x1845210B0")]
	public void GHJBKJMLHEK(T FOFGABNNIOJ, U LKDPJJDODJM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x40983C0", Offset = "0x4096DC0", VA = "0x1840983C0")]
	public static KECBCJGCBNA<T, U> OGAJIJOBEEF(KECBCJGCBNA<T, U> MNINCPENHLD, Action<T, U> EFFBNJEBEKP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4098320", Offset = "0x4096D20", VA = "0x184098320")]
	public static KECBCJGCBNA<T, U> ODAAIPMOAKM(KECBCJGCBNA<T, U> MNINCPENHLD, Action<T, U> EFFBNJEBEKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class GKHPECILONI<T, U, V> : FPOJALAAGLO<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3FB70D0", Offset = "0x3FB5AD0", VA = "0x183FB70D0")]
	public GKHPECILONI(bool LHHEFEIHCAA = false, bool LIGDMGFCIDH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4113380", Offset = "0x4111D80", VA = "0x184113380")]
	public void GHJBKJMLHEK(T FOFGABNNIOJ, U LKDPJJDODJM, V KGHNFJGNNEO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x40983C0", Offset = "0x4096DC0", VA = "0x1840983C0")]
	public static GKHPECILONI<T, U, V> OGAJIJOBEEF(GKHPECILONI<T, U, V> MNINCPENHLD, Action<T, U, V> EFFBNJEBEKP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4098320", Offset = "0x4096D20", VA = "0x184098320")]
	public static GKHPECILONI<T, U, V> ODAAIPMOAKM(GKHPECILONI<T, U, V> MNINCPENHLD, Action<T, U, V> EFFBNJEBEKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface POBHLAGIOFL<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class NALOEMMDDOH<T, U, V, W> : FPOJALAAGLO<Action<T, U, V, W>>, POBHLAGIOFL<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3FB70D0", Offset = "0x3FB5AD0", VA = "0x183FB70D0")]
	public NALOEMMDDOH(bool LHHEFEIHCAA = false, bool LIGDMGFCIDH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x49082F0", Offset = "0x4906CF0", VA = "0x1849082F0")]
	public void GHJBKJMLHEK(T FOFGABNNIOJ, U LKDPJJDODJM, V KGHNFJGNNEO, W KJGNJHANGFM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x40983C0", Offset = "0x4096DC0", VA = "0x1840983C0")]
	public static NALOEMMDDOH<T, U, V, W> OGAJIJOBEEF(NALOEMMDDOH<T, U, V, W> MNINCPENHLD, Action<T, U, V, W> EFFBNJEBEKP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4098320", Offset = "0x4096D20", VA = "0x184098320")]
	public static NALOEMMDDOH<T, U, V, W> ODAAIPMOAKM(NALOEMMDDOH<T, U, V, W> MNINCPENHLD, Action<T, U, V, W> EFFBNJEBEKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class PPNOBGPKCPM<T, U, V, W, X> : FPOJALAAGLO<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3FB70D0", Offset = "0x3FB5AD0", VA = "0x183FB70D0")]
	public PPNOBGPKCPM(bool LHHEFEIHCAA = false, bool LIGDMGFCIDH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4B91880", Offset = "0x4B90280", VA = "0x184B91880")]
	public void GHJBKJMLHEK(T FOFGABNNIOJ, U LKDPJJDODJM, V KGHNFJGNNEO, W KJGNJHANGFM, X PMBJFHIMJKC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x40983C0", Offset = "0x4096DC0", VA = "0x1840983C0")]
	public static PPNOBGPKCPM<T, U, V, W, X> OGAJIJOBEEF(PPNOBGPKCPM<T, U, V, W, X> MNINCPENHLD, Action<T, U, V, W, X> EFFBNJEBEKP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4098320", Offset = "0x4096D20", VA = "0x184098320")]
	public static PPNOBGPKCPM<T, U, V, W, X> ODAAIPMOAKM(PPNOBGPKCPM<T, U, V, W, X> MNINCPENHLD, Action<T, U, V, W, X> EFFBNJEBEKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class BNKGEMLKJNP<T, U, V, W, X, Y> : FPOJALAAGLO<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3FB70D0", Offset = "0x3FB5AD0", VA = "0x183FB70D0")]
	public BNKGEMLKJNP(bool LHHEFEIHCAA = false, bool LIGDMGFCIDH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x52A05E0", Offset = "0x529EFE0", VA = "0x1852A05E0")]
	public void GHJBKJMLHEK(T FOFGABNNIOJ, U LKDPJJDODJM, V KGHNFJGNNEO, W KJGNJHANGFM, X PMBJFHIMJKC, Y HBABDGBANAP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x40983C0", Offset = "0x4096DC0", VA = "0x1840983C0")]
	public static BNKGEMLKJNP<T, U, V, W, X, Y> OGAJIJOBEEF(BNKGEMLKJNP<T, U, V, W, X, Y> MNINCPENHLD, Action<T, U, V, W, X, Y> EFFBNJEBEKP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4098320", Offset = "0x4096D20", VA = "0x184098320")]
	public static BNKGEMLKJNP<T, U, V, W, X, Y> ODAAIPMOAKM(BNKGEMLKJNP<T, U, V, W, X, Y> MNINCPENHLD, Action<T, U, V, W, X, Y> EFFBNJEBEKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class FMEHDDNDNDC<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CHLDBCECJHG<TKey, TVal> POONNDKIPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> MDOCEPBDIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly CHLDBCECJHG<TKey, TVal>.GJLAIFLCIJF? OIBEKBFKJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int ELIABPLEIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly CHLDBCECJHG<TKey, TVal>.JEGAEJMCKLP? KDFNHDGALJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int NJLGGIBCLHA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int IIIEBCIFEFF
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4031D40", Offset = "0x4030740", VA = "0x184031D40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int EMJDCOOGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8AF7D0", Offset = "0x8AE1D0", VA = "0x1808AF7D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4031ED0", Offset = "0x40308D0", VA = "0x184031ED0")]
	public FMEHDDNDNDC(int ELIABPLEIGM, [Optional] CHLDBCECJHG<TKey, TVal>.JEGAEJMCKLP? KDFNHDGALJL, [Optional] IEqualityComparer<TKey>? FJHEBFJGGEP, [Optional] CHLDBCECJHG<TKey, TVal>.GJLAIFLCIJF? OIBEKBFKJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4030DE0", Offset = "0x402F7E0", VA = "0x184030DE0")]
	public void CDBHCCFEJFK(TKey PNABAFEIDND, TVal PKCLPFEIPFH, bool BBLEHJECAIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x40310E0", Offset = "0x402FAE0", VA = "0x1840310E0")]
	public bool EDMPDAJPJKB(TKey PNABAFEIDND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4031380", Offset = "0x402FD80", VA = "0x184031380")]
	public bool HPCEHODMPGB(TKey OMLHPAPCOIC, [Out] TVal PKCLPFEIPFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4030B00", Offset = "0x402F500", VA = "0x184030B00")]
	private void BPFIHKLMKOO(TKey PNABAFEIDND, TVal PKCLPFEIPFH, int LEGDMNLNDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x40315D0", Offset = "0x402FFD0", VA = "0x1840315D0")]
	public bool LLCOLOLFKJO(TKey PNABAFEIDND, TVal PKCLPFEIPFH, bool BBLEHJECAIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4031030", Offset = "0x402FA30", VA = "0x184031030")]
	public void CFGGIHGKNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x40317A0", Offset = "0x40301A0", VA = "0x1840317A0")]
	private void MGOGPMDHJCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4031480", Offset = "0x402FE80", VA = "0x184031480")]
	private bool IADJCPPJCMJ(TKey PNABAFEIDND, JEHPJBBBPEM OMJKCNAHEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4031250", Offset = "0x402FC50", VA = "0x184031250")]
	private void GMHGAIAHFNO(TKey PNABAFEIDND, TVal PKCLPFEIPFH, JEHPJBBBPEM OMJKCNAHEJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4031DA0", Offset = "0x40307A0", VA = "0x184031DA0")]
	private void PPAFKIMJKMF(TKey PNABAFEIDND, TVal JBKDPHAINMM, JEHPJBBBPEM OMJKCNAHEJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DECJNEGMJNC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action JCHIJAIHCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool NGFDONLINAA;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
	public DECJNEGMJNC(Action FKEFGHMOLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6EE71E0", Offset = "0x6EE5BE0", VA = "0x186EE71E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2CE98F0", Offset = "0x2CE82F0", VA = "0x182CE98F0")]
	public static CCFPOCKCODD<T> LNCAGMGJJFK<T>(T PKCLPFEIPFH, Action FKEFGHMOLDJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class CCFPOCKCODD<T> : DECJNEGMJNC where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T IPHIEALFCML
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5319B20", Offset = "0x5318520", VA = "0x185319B20")]
	public CCFPOCKCODD(T PKCLPFEIPFH, Action FKEFGHMOLDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class EOKBOKJPBNK<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly KJPPPEPGABM<T>? ALLBNLAHOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> EILADGMOHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool NGFDONLINAA;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly EOKBOKJPBNK<T> BDDJBNJILLK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> CKMAILMFIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3B92040", Offset = "0x3B90A40", VA = "0x183B92040")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long EKAJMJBAGEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3B91E70", Offset = "0x3B90870", VA = "0x183B91E70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool EFLKLBKLPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3B91CF0", Offset = "0x3B906F0", VA = "0x183B91CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3B924C0", Offset = "0x3B90EC0", VA = "0x183B924C0")]
	public EOKBOKJPBNK(KJPPPEPGABM<T> HMMNEGPBKBL, KJPPPEPGABM<T> JBJBIIHIELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3B92A40", Offset = "0x3B91440", VA = "0x183B92A40")]
	public EOKBOKJPBNK(KJPPPEPGABM<T> HMMNEGPBKBL, int FMCLGEDFPEP, KJPPPEPGABM<T> JBJBIIHIELE, int GDEMOKEEMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3B92990", Offset = "0x3B91390", VA = "0x183B92990")]
	private EOKBOKJPBNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3B91F30", Offset = "0x3B90930", VA = "0x183B91F30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3B920C0", Offset = "0x3B90AC0", VA = "0x183B920C0")]
	public T[] KLJILCNGCPK()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3B92240", Offset = "0x3B90C40", VA = "0x183B92240")]
	public static ReadOnlySequence<T> OLKJPEKNNFN(EOKBOKJPBNK<T>? BGDACOFHFBK)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct EEJADCHMHJL : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct IEIKBJHKOOG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0")]
		public static IEIKBJHKOOG AELHPDENENI()
		{
			return default(IEIKBJHKOOG);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7350", Offset = "0x6EE5D50", VA = "0x186EE7350")]
	public static string PMBMLFBLNND(Type BKKHBFLPOHJ, [Optional] string? IJPGJELHPIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2D44520", Offset = "0x2D42F20", VA = "0x182D44520")]
	public static string? PMBMLFBLNND<T>([Optional] string? IJPGJELHPIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2D444A0", Offset = "0x2D42EA0", VA = "0x182D444A0")]
	public static string? JAIDLBKKKJE<T>([Optional] string? MPADMPFMDJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0")]
	public static EEJADCHMHJL NEICLLJACJM(string IJPGJELHPIF, string? MPADMPFMDJM)
	{
		return default(EEJADCHMHJL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct PHCGGPIMKIC
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool IBOKMEFNOFJ(string PMCMAFJEJGJ, PHCGGPIMKIC GNACLLFAHPO);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class LLMIGCCHJEP<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public LLMIGCCHJEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x467CF00", Offset = "0x467B900", VA = "0x18467CF00")]
		internal void HIJKOBAHGBM(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int COJJJGIBKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string NBPNAMFAHAB;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9F40", Offset = "0x6EE8940", VA = "0x186EE9F40")]
	public static Dictionary<string, PHCGGPIMKIC> CJHINPCMLDP(Type CPBMHPAAFPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x308E4C0", Offset = "0x308CEC0", VA = "0x18308E4C0")]
	public static Dictionary<string, PHCGGPIMKIC> CJHINPCMLDP<T>(Type CPBMHPAAFPI, IReadOnlyDictionary<T, string> AKHPAIBCIDO) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x308ECF0", Offset = "0x308D6F0", VA = "0x18308ECF0")]
	public static Dictionary<string, PHCGGPIMKIC> IPPAKBBLILF<T>(List<T> DEDBFKAAOBH) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9B80", Offset = "0x6EE8580", VA = "0x186EE9B80")]
	public static Dictionary<string, PHCGGPIMKIC> ANOCKJNLMAK(Type CPBMHPAAFPI, IBOKMEFNOFJ LNJDKCFLKJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6EEA270", Offset = "0x6EE8C70", VA = "0x186EEA270")]
	public static Dictionary<int, string> JLMDGGNKHJC(Dictionary<string, PHCGGPIMKIC> NEELBFFPDOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class JMDMKJMGBCA : FMGMBNHPFJE
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool FOJHAGGBCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? JHLHJFMLFOL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual FMGMBNHPFJE? GECGMIHIOEE
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8C10", Offset = "0x6EE7610", VA = "0x186EE8C10")]
	protected JMDMKJMGBCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string BGELNEMCJAG();

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8560", Offset = "0x6EE6F60", VA = "0x186EE8560", Slot = "8")]
	public virtual string AJJGACDOLAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6EE85E0", Offset = "0x6EE6FE0", VA = "0x186EE85E0", Slot = "9")]
	public void APMIJPIFCGB(StringBuilder CMPAJIEOKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8A90", Offset = "0x6EE7490", VA = "0x186EE8A90", Slot = "10")]
	public void PAANCBHDGOA(StringBuilder CMPAJIEOKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8AF0", Offset = "0x6EE74F0", VA = "0x186EE8AF0", Slot = "11")]
	public void PDFEDLKGHHO(StringBuilder CMPAJIEOKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8930", Offset = "0x6EE7330", VA = "0x186EE8930", Slot = "12")]
	public void MBPGFMOJMFL(StringBuilder CMPAJIEOKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8890", Offset = "0x6EE7290", VA = "0x186EE8890")]
	public static void IEAHHODJKMG(StringBuilder CMPAJIEOKLM, string PIBOCEJLMMM, string BPIHDHFFFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x604AA00", Offset = "0x6049400", VA = "0x18604AA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class IEMJFOGJDON : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8060", Offset = "0x6EE6A60", VA = "0x186EE8060")]
	public IEMJFOGJDON(string FCMDIEEAPHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ADLKPPEMCDM<TErr> : IEMJFOGJDON where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr LNIBNMNCFIL;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x40A43A0", Offset = "0x40A2DA0", VA = "0x1840A43A0")]
	private ADLKPPEMCDM([In] TErr LEGMANAKFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x40A42C0", Offset = "0x40A2CC0", VA = "0x1840A42C0")]
	public static ADLKPPEMCDM<TErr> AELHPDENENI([In] TErr LEGMANAKFDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FDFFGICEEIH : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm AIDLPMJKMFN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool MJHCCKGGEMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool PAOCFPMEHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool JEKIOPJDBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long EKAJMJBAGEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7A10", Offset = "0x6EE6410", VA = "0x186EE7A10", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long CNDDIEKMION
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7A80", Offset = "0x6EE6480", VA = "0x186EE7A80", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7AF0", Offset = "0x6EE64F0", VA = "0x186EE7AF0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6EE79A0", Offset = "0x6EE63A0", VA = "0x186EE79A0")]
	public FDFFGICEEIH(HashAlgorithm AIDLPMJKMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6EE77D0", Offset = "0x6EE61D0", VA = "0x186EE77D0", Slot = "35")]
	public override int Read(byte[] GNKEDFJBDMM, int FDHHGENAMHL, int FPDJICFHLGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7970", Offset = "0x6EE6370", VA = "0x186EE7970", Slot = "38")]
	public override void Write(byte[] GNKEDFJBDMM, int FDHHGENAMHL, int FPDJICFHLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7870", Offset = "0x6EE6270", VA = "0x186EE7870", Slot = "33")]
	public override long Seek(long FDHHGENAMHL, SeekOrigin GFPIMNGNHHE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7900", Offset = "0x6EE6300", VA = "0x186EE7900", Slot = "34")]
	public override void SetLength(long PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7700", Offset = "0x6EE6100", VA = "0x186EE7700")]
	public byte[] EEAKDHELBKJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface FMGMBNHPFJE
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string AJJGACDOLAP();

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string BGELNEMCJAG();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface PLCEPPOHCLE<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions IPHIEALFCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface NBOAEDJHKAG
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string FGAFLPPBPKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class KJPPPEPGABM<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static KJPPPEPGABM<T>? PLEMKEONMNG;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object IEGELEMAKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? MCLJAPEFBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool NGFDONLINAA;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool EHENKOHBJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x98A810", Offset = "0x989210", VA = "0x18098A810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x455FE40", Offset = "0x455E840", VA = "0x18455FE40")]
	private static KJPPPEPGABM<T> KHFIBEBIOHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x455EFE0", Offset = "0x455D9E0", VA = "0x18455EFE0")]
	private static void CDPHAOKEOMD(KJPPPEPGABM<T> INCCADBLEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x426C0B0", Offset = "0x426AAB0", VA = "0x18426C0B0")]
	private KJPPPEPGABM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4560720", Offset = "0x455F120", VA = "0x184560720")]
	public static KJPPPEPGABM<T> LNCAGMGJJFK(ReadOnlyMemory<T> EKFBBBNELIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4560500", Offset = "0x455EF00", VA = "0x184560500")]
	public static KJPPPEPGABM<T> LNCAGMGJJFK(IMemoryOwner<T> AKAEIEGBNMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x455F7E0", Offset = "0x455E1E0", VA = "0x18455F7E0")]
	public static void CKKBADHPBIJ(KJPPPEPGABM<T> HMMNEGPBKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x455FBB0", Offset = "0x455E5B0", VA = "0x18455FBB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4560A60", Offset = "0x455F460", VA = "0x184560A60")]
	public KJPPPEPGABM<T> NEACFIBGNKO(IMemoryOwner<T> AKAEIEGBNMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x455F6E0", Offset = "0x455E0E0", VA = "0x18455F6E0")]
	private void CELPAAFKAAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4560900", Offset = "0x455F300", VA = "0x184560900")]
	private KJPPPEPGABM<T> NAMPGNIFGLE(KJPPPEPGABM<T> INCCADBLEFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class DAFFHHEMDOE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6EE70B0", Offset = "0x6EE5AB0", VA = "0x186EE70B0")]
	public DAFFHHEMDOE(string FCMDIEEAPHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class HDOBBIIABHI<TOk> : DAFFHHEMDOE where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk OJAKCDDHFAC;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4176F50", Offset = "0x4175950", VA = "0x184176F50")]
	private HDOBBIIABHI([In] TOk BAMGJEIJEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4173AE0", Offset = "0x41724E0", VA = "0x184173AE0")]
	public static HDOBBIIABHI<TOk> AELHPDENENI([In] TOk BAMGJEIJEJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct OKPKCEBGDLD<TOk, TErr> : IEquatable<OKPKCEBGDLD<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly EqualityComparer<TErr> ALAPABCKGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal readonly TErr LNIBNMNCFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal readonly TOk OJAKCDDHFAC;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool NPMBABKKHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x4AB2C00", Offset = "0x4AB1600", VA = "0x184AB2C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool BCIIEEJBALO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4AB59C0", Offset = "0x4AB43C0", VA = "0x184AB59C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4AB8600", Offset = "0x4AB7000", VA = "0x184AB8600")]
	internal OKPKCEBGDLD([In] TErr LEGMANAKFDN, [In] TOk BAMGJEIJEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4AB51C0", Offset = "0x4AB3BC0", VA = "0x184AB51C0")]
	public static OKPKCEBGDLD<TOk, TErr> MLBDLIANHCF([In] TErr LEGMANAKFDN)
	{
		return default(OKPKCEBGDLD<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4AB3380", Offset = "0x4AB1D80", VA = "0x184AB3380")]
	public static OKPKCEBGDLD<TOk, TErr> FMMNIHEDGIO([In] TOk BAMGJEIJEJL)
	{
		return default(OKPKCEBGDLD<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3242F50", Offset = "0x3241950", VA = "0x183242F50")]
	public OKPKCEBGDLD<TOk?, UErr?> EGIFHPKKJIM<UErr>()
	{
		return default(OKPKCEBGDLD<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3244F20", Offset = "0x3243920", VA = "0x183244F20")]
	public OKPKCEBGDLD<UOk?, TErr?> LOBDLCJLDLB<UOk>()
	{
		return default(OKPKCEBGDLD<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3244290", Offset = "0x3242C90", VA = "0x183244290")]
	public OKPKCEBGDLD<UOk?, TErr?> ICAAGEOFEFJ<UOk>()
	{
		return default(OKPKCEBGDLD<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x32453A0", Offset = "0x3243DA0", VA = "0x1832453A0")]
	public OKPKCEBGDLD<TOk?, UErr?> MONCKKJLEIM<UErr>()
	{
		return default(OKPKCEBGDLD<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4AB4D40", Offset = "0x4AB3740", VA = "0x184AB4D40")]
	public OKPKCEBGDLD<NEDLODCHJKB, TErr> HLDLJAANCJL()
	{
		return default(OKPKCEBGDLD<NEDLODCHJKB, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4AB1210", Offset = "0x4AAFC10", VA = "0x184AB1210")]
	public static bool EKIKFCPHGPG([In] OKPKCEBGDLD<TOk, TErr> FCKNABCAAPB, [In] OKPKCEBGDLD<TOk, TErr> JGIIKLPFBFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4AB1C80", Offset = "0x4AB0680", VA = "0x184AB1C80", Slot = "4")]
	public bool Equals(OKPKCEBGDLD<TOk, TErr> GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4AB1FD0", Offset = "0x4AB09D0", VA = "0x184AB1FD0", Slot = "0")]
	public override bool Equals(object GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4AB40C0", Offset = "0x4AB2AC0", VA = "0x184AB40C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4AB5E40", Offset = "0x4AB4840", VA = "0x184AB5E40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class EPEFKIFOMOI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct KCLHCBKFCBJ<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Task<OKPKCEBGDLD<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<OKPKCEBGDLD<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4518F30", Offset = "0x4517930", VA = "0x184518F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x45195B0", Offset = "0x4517FB0", VA = "0x1845195B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2D6F260", Offset = "0x2D6DC60", VA = "0x182D6F260")]
	public static OKPKCEBGDLD<TOk?, TErr?> OJAKCDDHFAC<TOk, TErr>([In] this OKPKCEBGDLD<TOk, TErr> PCBICLOONMH, [In] TOk BAMGJEIJEJL)
	{
		return default(OKPKCEBGDLD<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2D6F430", Offset = "0x2D6DE30", VA = "0x182D6F430")]
	public static OKPKCEBGDLD<NEDLODCHJKB, TErr?> OJAKCDDHFAC<TErr>([In] this OKPKCEBGDLD<NEDLODCHJKB, TErr> PCBICLOONMH)
	{
		return default(OKPKCEBGDLD<NEDLODCHJKB, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2D6F260", Offset = "0x2D6DC60", VA = "0x182D6F260")]
	public static OKPKCEBGDLD<TOk?, TErr?> LNIBNMNCFIL<TOk, TErr>([In] this OKPKCEBGDLD<TOk, TErr> PCBICLOONMH, [In] TErr LEGMANAKFDN)
	{
		return default(OKPKCEBGDLD<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2D6CCB0", Offset = "0x2D6B6B0", VA = "0x182D6CCB0")]
	public static TOk? EMGADAAGGOK<TOk, TErr>([In] this OKPKCEBGDLD<TOk, TErr> PCBICLOONMH)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2D6C510", Offset = "0x2D6AF10", VA = "0x182D6C510")]
	[AsyncStateMachine(typeof(KCLHCBKFCBJ<, >))]
	public static Task<TOk?>? CPJIMCNJIEE<TOk, TErr>(this Task<OKPKCEBGDLD<TOk, TErr>> PCBICLOONMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2D6E650", Offset = "0x2D6D050", VA = "0x182D6E650")]
	public static TErr? IFEANNLLEPE<TErr, TOk>([In] this OKPKCEBGDLD<TOk, TErr> PCBICLOONMH)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2D6D1B0", Offset = "0x2D6BBB0", VA = "0x182D6D1B0")]
	public static bool HIFAGCHLOAP<TOk, TErr, UErr, UOk>([In] this OKPKCEBGDLD<TOk, TErr> PCBICLOONMH, [Out] OKPKCEBGDLD<UOk, UErr> ODCDMGCFMDI) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2D6EC40", Offset = "0x2D6D640", VA = "0x182D6EC40")]
	public static bool ILPBILOLENP<TOk, TErr>([In] this OKPKCEBGDLD<TOk, TErr> PCBICLOONMH, [Out][NotNullWhen(true)] TOk BAMGJEIJEJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2D6F090", Offset = "0x2D6DA90", VA = "0x182D6F090")]
	public static bool JGOHKEJIINJ<TOk, TErr>([In] this OKPKCEBGDLD<TOk, TErr> PCBICLOONMH, [Out][NotNullWhen(true)] TErr LEGMANAKFDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2D6EFA0", Offset = "0x2D6D9A0", VA = "0x182D6EFA0")]
	public static bool JAEIDBPBJOB<TOk, TErr>([In] this OKPKCEBGDLD<TOk, TErr> PCBICLOONMH, [Out][NotNullWhen(true)] TOk BAMGJEIJEJL, [Out][NotNullWhen(false)] TErr LEGMANAKFDN) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2D6F160", Offset = "0x2D6DB60", VA = "0x182D6F160")]
	public static bool KFMBEODPHPA<TOk, TErr>([In] this OKPKCEBGDLD<TOk, TErr> PCBICLOONMH, [Out][NotNullWhen(true)] TOk BAMGJEIJEJL, [Out] OKPKCEBGDLD<TOk, TErr> ODCDMGCFMDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2D6D420", Offset = "0x2D6BE20", VA = "0x182D6D420")]
	public static bool HIFAGCHLOAP<TOk, TErr, UErr, UOk>([In] this OKPKCEBGDLD<TOk, TErr> PCBICLOONMH, [Out][NotNullWhen(true)] TOk BAMGJEIJEJL, [Out] OKPKCEBGDLD<UOk, UErr> ODCDMGCFMDI) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2D6E890", Offset = "0x2D6D290", VA = "0x182D6E890")]
	public static bool IIIMJDBMGHG<TOk, TErr>([In] this OKPKCEBGDLD<TOk, TErr> PCBICLOONMH, [Out][NotNullWhen(true)] TOk BAMGJEIJEJL, [Out] OKPKCEBGDLD<NEDLODCHJKB, TErr> ODCDMGCFMDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2D6F820", Offset = "0x2D6E220", VA = "0x182D6F820")]
	public static OKPKCEBGDLD<UOk, UErr> PHMMEPHMIIN<UOk, UErr, TOk, TErr>([In] this OKPKCEBGDLD<TOk, TErr> PCBICLOONMH, [In] OKPKCEBGDLD<UOk, UErr> HBABIBCNPCH) where TOk : UOk where TErr : UErr
	{
		return default(OKPKCEBGDLD<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2D6C7E0", Offset = "0x2D6B1E0", VA = "0x182D6C7E0")]
	public static OKPKCEBGDLD<TOk?[]?, TErr?> DPAGOAELEAD<TOk, TErr>(this IEnumerable<OKPKCEBGDLD<TOk, TErr>> PCBICLOONMH)
	{
		return default(OKPKCEBGDLD<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class EIGPFFJENJB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D9E0", Offset = "0x2E1C3E0", VA = "0x182E1D9E0")]
	public static OKPKCEBGDLD<TOk, T> OJAKCDDHFAC<TOk>([In] TOk BAMGJEIJEJL) where TOk : notnull
	{
		return default(OKPKCEBGDLD<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3B7D560", Offset = "0x3B7BF60", VA = "0x183B7D560")]
	public static OKPKCEBGDLD<NEDLODCHJKB, T> OJAKCDDHFAC()
	{
		return default(OKPKCEBGDLD<NEDLODCHJKB, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D9E0", Offset = "0x2E1C3E0", VA = "0x182E1D9E0")]
	public static OKPKCEBGDLD<T, TErr> LNIBNMNCFIL<TErr>([In] TErr LEGMANAKFDN) where TErr : notnull
	{
		return default(OKPKCEBGDLD<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct HOGCOCEDMFO<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly OCEMENEBPKL CEPJBDEMFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<TKey, TValue> IIBBMNFFMKP;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4199E90", Offset = "0x4198890", VA = "0x184199E90")]
	public static HOGCOCEDMFO<TKey, TValue> AELHPDENENI(string KMDNOIPDFGB)
	{
		return default(HOGCOCEDMFO<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x419A070", Offset = "0x4198A70", VA = "0x18419A070")]
	internal HOGCOCEDMFO(Dictionary<TKey, TValue> PKCLPFEIPFH, OCEMENEBPKL AILOLLNCHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4199FC0", Offset = "0x41989C0", VA = "0x184199FC0")]
	public OBMODFKJPJH<TKey, TValue> KEDJFLGHDPL([Out] Dictionary<TKey, TValue> PKCLPFEIPFH)
	{
		return default(OBMODFKJPJH<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct OBMODFKJPJH<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TValue> IIBBMNFFMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly KPKGBMOCFDH OJEJNNNFFEH;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x245A8F0", Offset = "0x24592F0", VA = "0x18245A8F0")]
	internal OBMODFKJPJH(Dictionary<TKey, TValue> PKCLPFEIPFH, KPKGBMOCFDH AGGFGLGCLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4A4ED20", Offset = "0x4A4D720", VA = "0x184A4ED20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct APHNFCNGDFG<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly OCEMENEBPKL CEPJBDEMFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly HashSet<T> IIBBMNFFMKP;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4199E90", Offset = "0x4198890", VA = "0x184199E90")]
	public static APHNFCNGDFG<T> AELHPDENENI(string KMDNOIPDFGB)
	{
		return default(APHNFCNGDFG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x419A070", Offset = "0x4198A70", VA = "0x18419A070")]
	internal APHNFCNGDFG(HashSet<T> PKCLPFEIPFH, OCEMENEBPKL AILOLLNCHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4199FC0", Offset = "0x41989C0", VA = "0x184199FC0")]
	public OBNIPGAGNOK<T> KEDJFLGHDPL([Out] HashSet<T> PKCLPFEIPFH)
	{
		return default(OBNIPGAGNOK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct OBNIPGAGNOK<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HashSet<T> IIBBMNFFMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly KPKGBMOCFDH OJEJNNNFFEH;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x245A8F0", Offset = "0x24592F0", VA = "0x18245A8F0")]
	internal OBNIPGAGNOK(HashSet<T> PKCLPFEIPFH, KPKGBMOCFDH AGGFGLGCLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4A4ED20", Offset = "0x4A4D720", VA = "0x184A4ED20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct JEDPKLKHBAI<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly OCEMENEBPKL CEPJBDEMFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Stack<T> IIBBMNFFMKP;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4199E90", Offset = "0x4198890", VA = "0x184199E90")]
	public static JEDPKLKHBAI<T> AELHPDENENI(string KMDNOIPDFGB)
	{
		return default(JEDPKLKHBAI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x419A070", Offset = "0x4198A70", VA = "0x18419A070")]
	internal JEDPKLKHBAI(Stack<T> PKCLPFEIPFH, OCEMENEBPKL AILOLLNCHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4199FC0", Offset = "0x41989C0", VA = "0x184199FC0")]
	public DNMPCFCMIGJ<T> KEDJFLGHDPL([Out] Stack<T> PKCLPFEIPFH)
	{
		return default(DNMPCFCMIGJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct DNMPCFCMIGJ<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Stack<T> IIBBMNFFMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly KPKGBMOCFDH OJEJNNNFFEH;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x245A8F0", Offset = "0x24592F0", VA = "0x18245A8F0")]
	internal DNMPCFCMIGJ(Stack<T> PKCLPFEIPFH, KPKGBMOCFDH AGGFGLGCLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4A4ED20", Offset = "0x4A4D720", VA = "0x184A4ED20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public sealed class IICGMKNFHBE<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct LPIABHCCLDA : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly IICGMKNFHBE<T> DLOAANIEKCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int IONDMJAJDGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly bool AELMKIDBBIE;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x217A2D0", Offset = "0x2178CD0", VA = "0x18217A2D0")]
		public LPIABHCCLDA(IICGMKNFHBE<T> OAAFMJBAJGL, int POBGLANCEKI, bool GACIHFCHLPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x468A250", Offset = "0x4688C50", VA = "0x18468A250")]
		public IICGMKNFHBE<T>.ANADDLKOKKG CBLJDKEPCGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x468A350", Offset = "0x4688D50", VA = "0x18468A350", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x468A350", Offset = "0x4688D50", VA = "0x18468A350", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class ANADDLKOKKG : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly IICGMKNFHBE<T> DLOAANIEKCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly int EANKEMJOGJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int PCJALMBJCOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly bool AELMKIDBBIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool NOCEMIBDIOI;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T MKGDHLFFCEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x4160B90", Offset = "0x415F590", VA = "0x184160B90")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x4160D10", Offset = "0x415F710", VA = "0x184160D10", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x4160F60", Offset = "0x415F960", VA = "0x184160F60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x41614D0", Offset = "0x415FED0", VA = "0x1841614D0")]
		public ANADDLKOKKG(IICGMKNFHBE<T> OAAFMJBAJGL, int POBGLANCEKI, bool GACIHFCHLPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x4160C50", Offset = "0x415F650", VA = "0x184160C50", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4160CF0", Offset = "0x415F6F0", VA = "0x184160CF0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class FJBPDEKKLPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public FJBPDEKKLPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3FB3BD0", Offset = "0x3FB25D0", VA = "0x183FB3BD0")]
		internal T LNCAOAEDEDK(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly T[] JALGGEDIIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int PCJALMBJCOP;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int EHALCHNJLEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x424CD50", Offset = "0x424B750", VA = "0x18424CD50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T MKGDHLFFCEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3F05FA0", Offset = "0x3F049A0", VA = "0x183F05FA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T CKLAOGMBBLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x424CD10", Offset = "0x424B710", VA = "0x18424CD10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T CEHHCMJMIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x424CBA0", Offset = "0x424B5A0", VA = "0x18424CBA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int EKAJMJBAGEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1DDE470", Offset = "0x1DDCE70", VA = "0x181DDE470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x14DD000", Offset = "0x14DBA00", VA = "0x1814DD000")]
	private static int AAKMCPMBEBP(int GCBONJOGHCD, int JGKAMGBGMHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x424CDB0", Offset = "0x424B7B0", VA = "0x18424CDB0")]
	public IICGMKNFHBE(int LEGDMNLNDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x424CEE0", Offset = "0x424B8E0", VA = "0x18424CEE0")]
	public IICGMKNFHBE(int LEGDMNLNDAK, Func<T> FKFDCPPKIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x424D1F0", Offset = "0x424BBF0", VA = "0x18424D1F0")]
	public IICGMKNFHBE(T[] FAPCKKJDJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x424CC10", Offset = "0x424B610", VA = "0x18424CC10")]
	public void IGCNEEAFAPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x424CC40", Offset = "0x424B640", VA = "0x18424CC40")]
	public IEnumerable<T> LAEFLHDGDPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x424C9B0", Offset = "0x424B3B0", VA = "0x18424C9B0")]
	public IICGMKNFHBE<T>.ANADDLKOKKG CBLJDKEPCGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4070890", Offset = "0x406F290", VA = "0x184070890", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4070890", Offset = "0x406F290", VA = "0x184070890", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class NGDDIIBFGOA
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x304B010", Offset = "0x3049A10", VA = "0x18304B010")]
	public static IICGMKNFHBE<T> AELHPDENENI<T>(int LEGDMNLNDAK, Func<T> FKFDCPPKIGL) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class CGICODIFBKP<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct IJOGDOMHNNA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly CGICODIFBKP<T> JDOADBLPBCD;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T IPHIEALFCML
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x42531D0", Offset = "0x4251BD0", VA = "0x1842531D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x42531A0", Offset = "0x4251BA0", VA = "0x1842531A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x957790", Offset = "0x956190", VA = "0x180957790")]
		public IJOGDOMHNNA(CGICODIFBKP<T> JDOADBLPBCD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct FBELHCPOGAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder<IJOGDOMHNNA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CGICODIFBKP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3F121C0", Offset = "0x3F10BC0", VA = "0x183F121C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3B75760", Offset = "0x3B74160", VA = "0x183B75760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly SemaphoreSlim OBLJJFBKDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private T CMNJBOIHGOI;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5410790", Offset = "0x540F190", VA = "0x185410790")]
	public CGICODIFBKP([In] T CMNJBOIHGOI, int DODOHDCPDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x54106B0", Offset = "0x540F0B0", VA = "0x1854106B0")]
	public CGICODIFBKP([In] T CMNJBOIHGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5410150", Offset = "0x540EB50", VA = "0x185410150", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5410650", Offset = "0x540F050", VA = "0x185410650")]
	public IJOGDOMHNNA MBODOFNDLBD()
	{
		return default(IJOGDOMHNNA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5410190", Offset = "0x540EB90", VA = "0x185410190")]
	[AsyncStateMachine(typeof(CGICODIFBKP<>.FBELHCPOGAE))]
	public Task<CGICODIFBKP<T>.IJOGDOMHNNA> KFLEHIEFOMB(CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5410690", Offset = "0x540F090", VA = "0x185410690")]
	public void PIKHLPLLANA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class CGGEAJAOMBC
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7040", Offset = "0x6EE5A40", VA = "0x186EE7040")]
	public static CGICODIFBKP<NEDLODCHJKB> AELHPDENENI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9660", Offset = "0x2CE8060", VA = "0x182CE9660")]
	public static CGICODIFBKP<T> AELHPDENENI<T>([In] T CMNJBOIHGOI) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class MKHGMOMHMCF<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct LBNOJACNHEK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly MKHGMOMHMCF<T> MGLKMEOLBKO;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public T IPHIEALFCML
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x40C11D0", Offset = "0x40BFBD0", VA = "0x1840C11D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x464DD70", Offset = "0x464C770", VA = "0x18464DD70", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x957790", Offset = "0x956190", VA = "0x180957790")]
		internal LBNOJACNHEK(MKHGMOMHMCF<T> JDOADBLPBCD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct AHFLIPBBAFA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly MKHGMOMHMCF<T> MGLKMEOLBKO;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T IPHIEALFCML
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x40C11D0", Offset = "0x40BFBD0", VA = "0x1840C11D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x40C10E0", Offset = "0x40BFAE0", VA = "0x1840C10E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x957790", Offset = "0x956190", VA = "0x180957790")]
		internal AHFLIPBBAFA(MKHGMOMHMCF<T> JDOADBLPBCD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct EEECMIPCBJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<AHFLIPBBAFA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public MKHGMOMHMCF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private CGICODIFBKP<NEDLODCHJKB>.IJOGDOMHNNA <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<CGICODIFBKP<NEDLODCHJKB>.IJOGDOMHNNA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3B75220", Offset = "0x3B73C20", VA = "0x183B75220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3B75760", Offset = "0x3B74160", VA = "0x183B75760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly CGICODIFBKP<int> DIFCFHKNOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly CGICODIFBKP<NEDLODCHJKB> POCEBFCDCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly CGICODIFBKP<NEDLODCHJKB> NENGNOMOOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private T IPIDKLKPLJF;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x48C3E30", Offset = "0x48C2830", VA = "0x1848C3E30")]
	internal MKHGMOMHMCF(CGICODIFBKP<int> CODGDHGNEEO, CGICODIFBKP<NEDLODCHJKB> CDOAFLHPOEG, CGICODIFBKP<NEDLODCHJKB> PPMKPAKHHAA, [In] T CMNJBOIHGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x48C35D0", Offset = "0x48C1FD0", VA = "0x1848C35D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x48C3250", Offset = "0x48C1C50", VA = "0x1848C3250")]
	public LBNOJACNHEK BBLIDPIOLCP()
	{
		return default(LBNOJACNHEK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x48C3750", Offset = "0x48C2150", VA = "0x1848C3750")]
	public AHFLIPBBAFA GGHBGBAFMCN()
	{
		return default(AHFLIPBBAFA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x48C3A20", Offset = "0x48C2420", VA = "0x1848C3A20")]
	[AsyncStateMachine(typeof(MKHGMOMHMCF<>.EEECMIPCBJF))]
	public Task<MKHGMOMHMCF<T>.AHFLIPBBAFA> PPGCNJIJIKL(CancellationToken PPLDCJFFMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class DCPOAJLDKOB
{
	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7110", Offset = "0x6EE5B10", VA = "0x186EE7110")]
	public static MKHGMOMHMCF<NEDLODCHJKB> AELHPDENENI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2D1DB60", Offset = "0x2D1C560", VA = "0x182D1DB60")]
	public static MKHGMOMHMCF<T> AELHPDENENI<T>([In] T CMNJBOIHGOI) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class GLFMNJFBJNJ<TData> : JMDMKJMGBCA where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly string DGDPHPLNONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly TData DKIFFIMODLG;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
	public override string BGELNEMCJAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x41170C0", Offset = "0x4115AC0", VA = "0x1841170C0")]
	internal GLFMNJFBJNJ(string FCMDIEEAPHD, [In] TData GGEMPJLCHFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class OEIEPPCIIAF
{
	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6EE91E0", Offset = "0x6EE7BE0", VA = "0x186EE91E0")]
	public static GLFMNJFBJNJ<NEDLODCHJKB> AELHPDENENI(string FCMDIEEAPHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2CE98F0", Offset = "0x2CE82F0", VA = "0x182CE98F0")]
	public static GLFMNJFBJNJ<TData> AELHPDENENI<TData>(string FCMDIEEAPHD, [In] TData GGEMPJLCHFC) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class OCEMENEBPKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal bool JBEBFOOEFHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly string IPJFKDDEDDP;

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x9BB170", Offset = "0x9B9B70", VA = "0x1809BB170")]
	private OCEMENEBPKL(bool MJMPPLCDHBL, string ODPEIFMEDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6EE90B0", Offset = "0x6EE7AB0", VA = "0x186EE90B0")]
	public static OCEMENEBPKL AELHPDENENI(string ODPEIFMEDCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9120", Offset = "0x6EE7B20", VA = "0x186EE9120")]
	public KPKGBMOCFDH KEDJFLGHDPL()
	{
		return default(KPKGBMOCFDH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct KPKGBMOCFDH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly OCEMENEBPKL EJJDFGBLIBE;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x957790", Offset = "0x956190", VA = "0x180957790")]
	internal KPKGBMOCFDH(OCEMENEBPKL KMDNOIPDFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8C80", Offset = "0x6EE7680", VA = "0x186EE8C80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class IBMAJHCBBDP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class KMINJAHJAKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public KMINJAHJAKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4565310", Offset = "0x4563D10", VA = "0x184565310")]
		internal int FEOAEELCHCG(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private HashSet<T>? AOMPANBGLLL;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public IReadOnlyCollection<T> FICKEICKKAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x42408E0", Offset = "0x423F2E0", VA = "0x1842408E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool CMFBBPLAEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4240920", Offset = "0x423F320", VA = "0x184240920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int HMLBKDIMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D20", Offset = "0x8B3720", VA = "0x1808B4D20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D40", Offset = "0x8B3740", VA = "0x1808B4D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4240970", Offset = "0x423F370", VA = "0x184240970")]
	public bool NOEGDDICEDP(T AICEIDIHFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4240BA0", Offset = "0x423F5A0", VA = "0x184240BA0")]
	public bool PJOABDGMIKH(T AICEIDIHFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4240B50", Offset = "0x423F550", VA = "0x184240B50")]
	public bool OIBNNKGDJBI(T AICEIDIHFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x42407F0", Offset = "0x423F1F0", VA = "0x1842407F0")]
	public void DGDNAOHEJMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4240D20", Offset = "0x423F720", VA = "0x184240D20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public IBMAJHCBBDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class JKLEGNGEMOG
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class GPGKPIOLMIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public GPGKPIOLMIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7FB0", Offset = "0x6EE69B0", VA = "0x186EE7FB0")]
		internal int FEOAEELCHCG(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private HashSet<object>? AOMPANBGLLL;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyCollection<object> FICKEICKKAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8130", Offset = "0x6EE6B30", VA = "0x186EE8130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool CMFBBPLAEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6EE81C0", Offset = "0x6EE6BC0", VA = "0x186EE81C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int HMLBKDIMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D20", Offset = "0x8B3720", VA = "0x1808B4D20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D40", Offset = "0x8B3740", VA = "0x1808B4D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6EE81D0", Offset = "0x6EE6BD0", VA = "0x186EE81D0")]
	public bool NOEGDDICEDP(object AICEIDIHFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8310", Offset = "0x6EE6D10", VA = "0x186EE8310")]
	public bool PJOABDGMIKH(object AICEIDIHFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6EE82B0", Offset = "0x6EE6CB0", VA = "0x186EE82B0")]
	public bool OIBNNKGDJBI(object AICEIDIHFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6EE80C0", Offset = "0x6EE6AC0", VA = "0x186EE80C0")]
	public void DGDNAOHEJMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6EE83B0", Offset = "0x6EE6DB0", VA = "0x186EE83B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public JKLEGNGEMOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class CJMINKLKFDO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private struct EEJOJPAKHBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float GNMHNBCLFIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public T IPHIEALFCML;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, EEJOJPAKHBJ> ANMHHNMKHFE;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public virtual T NJHKDCNKOIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x13CC320", Offset = "0x13CAD20", VA = "0x1813CC320", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x13CB910", Offset = "0x13CA310", VA = "0x1813CB910", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public object? LKIPKHAEANJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8B00E0", Offset = "0x8AEAE0", VA = "0x1808B00E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D30", Offset = "0x8B3730", VA = "0x1808B4D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool ACLKAEHDFMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5605060", Offset = "0x5603A60", VA = "0x185605060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5605600", Offset = "0x5604000", VA = "0x185605600")]
	public bool IMKENKPFHBD(T PKCLPFEIPFH, object AICEIDIHFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x52A12E0", Offset = "0x529FCE0", VA = "0x1852A12E0")]
	public bool FMABBGOMMKF(object AICEIDIHFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4AADE00", Offset = "0x4AAC800", VA = "0x184AADE00")]
	public void CFGGIHGKNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x56051E0", Offset = "0x5603BE0", VA = "0x1856051E0")]
	public bool HPCEHODMPGB(object AICEIDIHFDO, [Out] T PKCLPFEIPFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x56065C0", Offset = "0x5604FC0", VA = "0x1856065C0")]
	[NDHJFHFMOBL("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool JAIMCEGPNAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x52A1BC0", Offset = "0x52A05C0", VA = "0x1852A1BC0")]
	public CJMINKLKFDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class OACBODOIEBE : LOAENIJKJOI<LLKIGIOJMJI>
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	internal class GCNAJNONGEJ : IEqualityComparer<LLKIGIOJMJI>
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal static readonly GCNAJNONGEJ JOLICDCBKGF;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7D90", Offset = "0x6EE6790", VA = "0x186EE7D90", Slot = "4")]
		public bool Equals(LLKIGIOJMJI PMBJFHIMJKC, LLKIGIOJMJI HBABDGBANAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x62331B0", Offset = "0x6231BB0", VA = "0x1862331B0", Slot = "5")]
		public int GetHashCode(LLKIGIOJMJI BBNKFKDCOLP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public GCNAJNONGEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9040", Offset = "0x6EE7A40", VA = "0x186EE9040")]
	public OACBODOIEBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8EE0", Offset = "0x6EE78E0", VA = "0x186EE8EE0", Slot = "4")]
	public override bool NOEGDDICEDP(LLKIGIOJMJI AICEIDIHFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8F90", Offset = "0x6EE7990", VA = "0x186EE8F90", Slot = "5")]
	public override bool PJOABDGMIKH(LLKIGIOJMJI AICEIDIHFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8E50", Offset = "0x6EE7850", VA = "0x186EE8E50")]
	private static void LHFBIDJIOML(LLKIGIOJMJI AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x12D3900", Offset = "0x12D2300", VA = "0x1812D3900", Slot = "6")]
	protected override string MFDGNKOEOJG(LLKIGIOJMJI AICEIDIHFDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class LLKIGIOJMJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly string CPMOKMCKDBC;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
	public LLKIGIOJMJI(string CPMOKMCKDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8CA0", Offset = "0x6EE76A0", VA = "0x186EE8CA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class LOAENIJKJOI<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly IEqualityComparer<T> FNBJNOCPAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private HashSet<T>? AOMPANBGLLL;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool CMFBBPLAEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x46817A0", Offset = "0x46801A0", VA = "0x1846817A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int HMLBKDIMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9826F0", Offset = "0x9810F0", VA = "0x1809826F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE210", Offset = "0xAACC10", VA = "0x180AAE210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4681E40", Offset = "0x4680840", VA = "0x184681E40")]
	internal LOAENIJKJOI(IEqualityComparer<T> FNBJNOCPAIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x46817F0", Offset = "0x46801F0", VA = "0x1846817F0", Slot = "4")]
	public virtual bool NOEGDDICEDP(T AICEIDIHFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x46819D0", Offset = "0x46803D0", VA = "0x1846819D0", Slot = "5")]
	public virtual bool PJOABDGMIKH(T AICEIDIHFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string MFDGNKOEOJG(T AICEIDIHFDO);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4681B50", Offset = "0x4680550", VA = "0x184681B50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class COBNIIGNPJH<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private List<WeakReference<T>>? AOMPANBGLLL;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool CMFBBPLAEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x56F9AA0", Offset = "0x56F84A0", VA = "0x1856F9AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int HMLBKDIMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x56F98F0", Offset = "0x56F82F0", VA = "0x1856F98F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x56F9BD0", Offset = "0x56F85D0", VA = "0x1856F9BD0")]
	public void NOEGDDICEDP(T AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x56F9E60", Offset = "0x56F8860", VA = "0x1856F9E60")]
	public void PJOABDGMIKH(T AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x56F98A0", Offset = "0x56F82A0", VA = "0x1856F98A0")]
	public void DGDNAOHEJMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x56FA010", Offset = "0x56F8A10", VA = "0x1856FA010", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public COBNIIGNPJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal static class EONKDMDOLIH
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2D24200", Offset = "0x2D22C00", VA = "0x182D24200")]
	public static void LEMEGBCKHAN<T>(this List<T> HIOONLIPGID, int GCBONJOGHCD) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class APGFILNPHHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<object, float> ANMHHNMKHFE;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float JPLJLECIEEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xAA37C0", Offset = "0xAA21C0", VA = "0x180AA37C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xAA31E0", Offset = "0xAA1BE0", VA = "0x180AA31E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6AF0", Offset = "0x6EE54F0", VA = "0x186EE6AF0")]
	public void IMKENKPFHBD(float PKCLPFEIPFH, object AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6A80", Offset = "0x6EE5480", VA = "0x186EE6A80")]
	public void FMABBGOMMKF(object AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6A30", Offset = "0x6EE5430", VA = "0x186EE6A30")]
	public void CFGGIHGKNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6B60", Offset = "0x6EE5560", VA = "0x186EE6B60")]
	private void PHIBNBEFNJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6C90", Offset = "0x6EE5690", VA = "0x186EE6C90")]
	public APGFILNPHHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface EGIGOEOGAJB
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event BANMMHGDGON KBEOBJHGGKM;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class PECEMKMFHAP : EGIGOEOGAJB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public readonly struct ENJJLEPLGBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly float PMHKFLKJGHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly float DFFPFFBGDNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		internal readonly bool MCOKBKCIBJP;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float HOGPONPHGBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x6EE7430", Offset = "0x6EE5E30", VA = "0x186EE7430")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6EE75A0", Offset = "0x6EE5FA0", VA = "0x186EE75A0")]
		public ENJJLEPLGBA(float CIFAFIDMMAE, float DINGIDMLMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7440", Offset = "0x6EE5E40", VA = "0x186EE7440", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class EGIBIOJOAII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public PECEMKMFHAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public EGIBIOJOAII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7390", Offset = "0x6EE5D90", VA = "0x186EE7390")]
		internal void LFFICPHIEIC(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly int LFENHKJMLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private int DBHFIDOOJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly EGIGOEOGAJB[] LAMJKCGFEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly BANMMHGDGON[] LPMHKEAJABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly ENJJLEPLGBA[] JLIIJKFJGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private ENJJLEPLGBA GJEDACMAPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly FJEHGFKNFIJ PCGPMJCAIIB;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event BANMMHGDGON KBEOBJHGGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6EE98A0", Offset = "0x6EE82A0", VA = "0x186EE98A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6EE96D0", Offset = "0x6EE80D0", VA = "0x186EE96D0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6EE99F0", Offset = "0x6EE83F0", VA = "0x186EE99F0")]
	public PECEMKMFHAP(int LFENHKJMLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9960", Offset = "0x6EE8360", VA = "0x186EE9960")]
	public FJEHGFKNFIJ PBBMOFOCDAD(ENJJLEPLGBA MLLPFLJHOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9260", Offset = "0x6EE7C60", VA = "0x186EE9260")]
	public void AOGMLKCABKC(EGIGOEOGAJB IBMBPDBGLPB, [Optional] ENJJLEPLGBA FFPPGLMGJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9790", Offset = "0x6EE8190", VA = "0x186EE9790", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate void BANMMHGDGON(float JFMNBPDMIIF);
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class EAJHCBLPBOI
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class MNOCMPPMJPJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly EGIGOEOGAJB KFJEACBBFGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly BANMMHGDGON HFJNADOBPEL;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D40", Offset = "0x6EE7740", VA = "0x186EE8D40")]
		public MNOCMPPMJPJ(EGIGOEOGAJB KFJEACBBFGL, BANMMHGDGON HFJNADOBPEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8CF0", Offset = "0x6EE76F0", VA = "0x186EE8CF0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6EE72E0", Offset = "0x6EE5CE0", VA = "0x186EE72E0")]
	internal static bool IGFFPPPIHNB(float PEMPEACEHBG, float FDDPOELCNDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6EDA6E0", Offset = "0x6ED90E0", VA = "0x186EDA6E0")]
	internal static float BCEIMHLMMOB(float PEMPEACEHBG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7220", Offset = "0x6EE5C20", VA = "0x186EE7220")]
	public static IDisposable GHFDAPNGGGP(this EGIGOEOGAJB KFJEACBBFGL, BANMMHGDGON HFJNADOBPEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class FJEHGFKNFIJ : EGIGOEOGAJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private float JFMNBPDMIIF;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float PFMBMCCDFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7C00", Offset = "0x6EE6600", VA = "0x186EE7C00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event BANMMHGDGON? KBEOBJHGGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7CF0", Offset = "0x6EE66F0", VA = "0x186EE7CF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7B60", Offset = "0x6EE6560", VA = "0x186EE7B60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public FJEHGFKNFIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface AOKKNOCLLPN<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PBFOEPKKDPH<T> MCHGAPKLKOF([Out] T PKCLPFEIPFH);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CFGGIHGKNGN();
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class EHFPOAMDDFO<T> : AOKKNOCLLPN<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly ConcurrentStack<T> APNMNIPMGAB;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3B78AB0", Offset = "0x3B774B0", VA = "0x183B78AB0", Slot = "4")]
	public PBFOEPKKDPH<T> MCHGAPKLKOF([Out] T PKCLPFEIPFH)
	{
		return default(PBFOEPKKDPH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3B78B50", Offset = "0x3B77550", VA = "0x183B78B50")]
	public void MMBLFJNKGED(T FLCKLJMKMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3B789A0", Offset = "0x3B773A0", VA = "0x183B789A0", Slot = "5")]
	public void CFGGIHGKNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "6")]
	protected virtual void MLJBMMNHGIL(T MINGOPHAPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3B78A00", Offset = "0x3B77400", VA = "0x183B78A00")]
	private T KJCABELIABF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3B78BD0", Offset = "0x3B775D0", VA = "0x183B78BD0")]
	public EHFPOAMDDFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct PBFOEPKKDPH<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly T FLCKLJMKMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly EHFPOAMDDFO<T> POHKLOIJGGN;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0xE07750", Offset = "0xE06150", VA = "0x180E07750")]
	internal PBFOEPKKDPH(T PKCLPFEIPFH, EHFPOAMDDFO<T> POHKLOIJGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x4B51700", Offset = "0x4B50100", VA = "0x184B51700", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class GNGHANNGGNP : EHFPOAMDDFO<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public static readonly GNGHANNGGNP JOLICDCBKGF;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7E20", Offset = "0x6EE6820", VA = "0x186EE7E20")]
	public static PBFOEPKKDPH<StringBuilder> KJCABELIABF([Out] StringBuilder PKCLPFEIPFH)
	{
		return default(PBFOEPKKDPH<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7EC0", Offset = "0x6EE68C0", VA = "0x186EE7EC0", Slot = "6")]
	protected override void MLJBMMNHGIL(StringBuilder MINGOPHAPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7F70", Offset = "0x6EE6970", VA = "0x186EE7F70")]
	public GNGHANNGGNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class HICLEACEJBB : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x68F6B70", Offset = "0x68F5570", VA = "0x1868F6B70")]
	public HICLEACEJBB(string FCMDIEEAPHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[DefaultMember("Item")]
public class LKMCGMAMNEK<TKey, TValue> : FBGAEHNCFBC<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IBEDCJEPEMP where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class KOHBPOOEMIK : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public LKMCGMAMNEK<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x13CC320", Offset = "0x13CAD20", VA = "0x1813CC320", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x45D72F0", Offset = "0x45D5CF0", VA = "0x1845D72F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
		[DebuggerHidden]
		public KOHBPOOEMIK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3DF1FF0", Offset = "0x3DF09F0", VA = "0x183DF1FF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x45D6960", Offset = "0x45D5360", VA = "0x1845D6960", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x45D6500", Offset = "0x45D4F00", VA = "0x1845D6500")]
		private void BFPHAGOPJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x45D7110", Offset = "0x45D5B10", VA = "0x1845D7110")]
		private void OKCPBNJHCGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x45D7250", Offset = "0x45D5C50", VA = "0x1845D7250", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly FBGAEHNCFBC<TKey, TValue> BCMDJJLBFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly IDictionary<TKey, TValue> IAHCEMANCPC;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int HMLBKDIMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x4679800", Offset = "0x4678200", VA = "0x184679800", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool HICONDDLJMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public TValue CEHHCMJMIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4679910", Offset = "0x4678310", VA = "0x184679910", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x4679BC0", Offset = "0x46785C0", VA = "0x184679BC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public ICollection<TKey> AFBAEIKCDOA
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4679960", Offset = "0x4678360", VA = "0x184679960", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public ICollection<TValue> BINFFJONHPE
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4679A90", Offset = "0x4678490", VA = "0x184679A90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x4679590", Offset = "0x4677F90", VA = "0x184679590")]
	public LKMCGMAMNEK(FBGAEHNCFBC<TKey, TValue> BCMDJJLBFAH, [Optional] IDictionary<TKey, TValue>? IAHCEMANCPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x4676CA0", Offset = "0x46756A0", VA = "0x184676CA0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x46776D0", Offset = "0x46760D0", VA = "0x1846776D0")]
	public void GMOOPLJLCGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x4676910", Offset = "0x4675310", VA = "0x184676910", Slot = "9")]
	public void Add(TKey PNABAFEIDND, TValue PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x46784A0", Offset = "0x4676EA0", VA = "0x1846784A0")]
	public void NHDDDCAMJHA(TKey PNABAFEIDND, TValue PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4677A70", Offset = "0x4676470", VA = "0x184677A70")]
	public void JIKHGPBPDGG(TKey PNABAFEIDND, TValue PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x4677CF0", Offset = "0x46766F0", VA = "0x184677CF0")]
	public void KMKHEJPDLIO(TKey PNABAFEIDND, TValue PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x4677880", Offset = "0x4676280", VA = "0x184677880")]
	public void HEOKNNEDFJA(TKey PNABAFEIDND, TValue PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x4678BF0", Offset = "0x46775F0", VA = "0x184678BF0", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> GNDKBENMBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x4678DE0", Offset = "0x46777E0", VA = "0x184678DE0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> GNDKBENMBLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x4678FA0", Offset = "0x46779A0", VA = "0x184678FA0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> GNDKBENMBLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4676DE0", Offset = "0x46757E0", VA = "0x184676DE0", Slot = "8")]
	public bool ContainsKey(TKey PNABAFEIDND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4677600", Offset = "0x4676000", VA = "0x184677600")]
	public bool FJHJDBFMMDN(TKey PNABAFEIDND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x46782A0", Offset = "0x4676CA0", VA = "0x1846782A0")]
	public bool MDIAEBGFEPD(TKey PNABAFEIDND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x4678930", Offset = "0x4677330", VA = "0x184678930", Slot = "10")]
	public bool Remove(TKey PNABAFEIDND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x46793E0", Offset = "0x4677DE0", VA = "0x1846793E0", Slot = "11")]
	public bool TryGetValue(TKey PNABAFEIDND, [Out] TValue PKCLPFEIPFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x4677100", Offset = "0x4675B00", VA = "0x184677100", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] LOCJOHPCANM, int FBPHGCDJPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x44BE690", Offset = "0x44BD090", VA = "0x1844BE690", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x46777D0", Offset = "0x46761D0", VA = "0x1846777D0", Slot = "19")]
	[IteratorStateMachine(typeof(LKMCGMAMNEK<, >.KOHBPOOEMIK))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x4678250", Offset = "0x4676C50", VA = "0x184678250", Slot = "21")]
	public bool LKOMHFNCMHA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x4678750", Offset = "0x4677150", VA = "0x184678750")]
	private TValue OEKEBFGBJMA(TKey PNABAFEIDND)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface IBEDCJEPEMP
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LKOMHFNCMHA();
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface FBGAEHNCFBC<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IBEDCJEPEMP
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public sealed class CHLDBCECJHG<TKey, TVal> : FBGAEHNCFBC<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IBEDCJEPEMP where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate int JEGAEJMCKLP(TKey PNABAFEIDND, TVal PKCLPFEIPFH);

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public delegate void GJLAIFLCIJF(TKey PNABAFEIDND, TVal PKCLPFEIPFH, JEHPJBBBPEM OMJKCNAHEJC);

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	private class GJJBOCPOGLF
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public TKey HPAJNDJICEN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xAEA840", Offset = "0xAE9240", VA = "0x180AEA840")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public TVal IPHIEALFCML
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x9826F0", Offset = "0x9810F0", VA = "0x1809826F0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xAAE210", Offset = "0xAACC10", VA = "0x180AAE210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int HOGPONPHGBN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x8ED140", Offset = "0x8EBB40", VA = "0x1808ED140")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x8ECDB0", Offset = "0x8EB7B0", VA = "0x1808ECDB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public DateTimeOffset CFICJNJIAFM
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xF9A440", Offset = "0xF98E40", VA = "0x180F9A440")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x1982880", Offset = "0x1981280", VA = "0x181982880")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x410C7F0", Offset = "0x410B1F0", VA = "0x18410C7F0")]
		public GJJBOCPOGLF(TKey PNABAFEIDND, TVal JBKDPHAINMM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class CHKLDCFPIFB : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public CHLDBCECJHG<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private LinkedList<GJJBOCPOGLF>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x13CC320", Offset = "0x13CAD20", VA = "0x1813CC320", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x54FDB10", Offset = "0x54FC510", VA = "0x1854FDB10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
		[DebuggerHidden]
		public CHKLDCFPIFB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3B65B90", Offset = "0x3B64590", VA = "0x183B65B90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x54FD2E0", Offset = "0x54FBCE0", VA = "0x1854FD2E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x54FAD00", Offset = "0x54F9700", VA = "0x1854FAD00")]
		private void BFPHAGOPJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x54FD840", Offset = "0x54FC240", VA = "0x1854FD840", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public const int NAKLJBPFMED = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Dictionary<TKey, LinkedListNode<GJJBOCPOGLF>> DPGLAAFLNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly LinkedList<GJJBOCPOGLF> FMKELBHJNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly JEGAEJMCKLP? KDFNHDGALJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly TimeSpan ADHKFEEBKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly GJLAIFLCIJF? OIBEKBFKJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly PLNKBKLAEPP OPLBDIKHJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool FHJHEEKEMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly List<TKey> AEMGAGDHJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly List<TVal> LPFKIHCPLOA;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int EMJDCOOGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8BBFB0", Offset = "0x8BA9B0", VA = "0x1808BBFB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	internal int IIIEBCIFEFF
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA14640", Offset = "0xA13040", VA = "0x180A14640")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA146D0", Offset = "0xA130D0", VA = "0x180A146D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int HMLBKDIMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x551A380", Offset = "0x5518D80", VA = "0x18551A380", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal int EBFHEPPHFLH
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4AADE00", Offset = "0x4AAC800", VA = "0x184AADE00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public ICollection<TVal> BINFFJONHPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x551A4F0", Offset = "0x5518EF0", VA = "0x18551A4F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	ICollection<TKey> IDictionary<TKey, TVal>.KGDAGEDPHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5515620", Offset = "0x5514020", VA = "0x185515620", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool HICONDDLJMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public TVal CEHHCMJMIPC
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x551A420", Offset = "0x5518E20", VA = "0x18551A420", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x551A5E0", Offset = "0x5518FE0", VA = "0x18551A5E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x55045F0", Offset = "0x5502FF0", VA = "0x1855045F0")]
	private bool CDJPMPCIAGA(int LFENHKJMLMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x550B7D0", Offset = "0x550A1D0", VA = "0x18550B7D0")]
	private void HBDCFAEBBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x5517FA0", Offset = "0x55169A0", VA = "0x185517FA0")]
	public CHLDBCECJHG(int LFENHKJMLMG, [Optional] JEGAEJMCKLP? KDFNHDGALJL, [Optional] IEqualityComparer<TKey>? FJHEBFJGGEP, [Optional] GJLAIFLCIJF? OIBEKBFKJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5517460", Offset = "0x5515E60", VA = "0x185517460")]
	public CHLDBCECJHG(TimeSpan ADHKFEEBKCH, [Optional] IEqualityComparer<TKey>? FJHEBFJGGEP, [Optional] GJLAIFLCIJF? OIBEKBFKJPD, [Optional] PLNKBKLAEPP? OPLBDIKHJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5516760", Offset = "0x5515160", VA = "0x185516760")]
	public CHLDBCECJHG(int LFENHKJMLMG, TimeSpan ADHKFEEBKCH, [Optional] IEqualityComparer<TKey>? FJHEBFJGGEP, [Optional] GJLAIFLCIJF? OIBEKBFKJPD, [Optional] PLNKBKLAEPP? OPLBDIKHJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x5516FE0", Offset = "0x55159E0", VA = "0x185516FE0")]
	public CHLDBCECJHG(int LFENHKJMLMG, JEGAEJMCKLP? KDFNHDGALJL, TimeSpan ADHKFEEBKCH, [Optional] IEqualityComparer<TKey>? FJHEBFJGGEP, [Optional] GJLAIFLCIJF? OIBEKBFKJPD, [Optional] PLNKBKLAEPP? OPLBDIKHJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x55131A0", Offset = "0x5511BA0", VA = "0x1855131A0", Slot = "21")]
	public bool LKOMHFNCMHA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x55046F0", Offset = "0x55030F0", VA = "0x1855046F0", Slot = "22")]
	public bool CKEAEBLKNED(int LEGDMNLNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x5511910", Offset = "0x5510310", VA = "0x185511910")]
	private bool LJGEPHOODNO(int LEGDMNLNDAK, JEHPJBBBPEM OMJKCNAHEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5504230", Offset = "0x5502C30", VA = "0x185504230")]
	public void CADIEIMFLMA(TKey PNABAFEIDND, TVal PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5502BF0", Offset = "0x55015F0", VA = "0x185502BF0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> GNDKBENMBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5503790", Offset = "0x5502190", VA = "0x185503790", Slot = "9")]
	public void Add(TKey PNABAFEIDND, TVal PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x5506860", Offset = "0x5505260", VA = "0x185506860", Slot = "8")]
	public bool ContainsKey(TKey PNABAFEIDND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x5514C60", Offset = "0x5513660", VA = "0x185514C60", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> GNDKBENMBLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x5514780", Offset = "0x5513180", VA = "0x185514780", Slot = "10")]
	public bool Remove(TKey PNABAFEIDND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x55154D0", Offset = "0x5513ED0", VA = "0x1855154D0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> GNDKBENMBLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x5509E80", Offset = "0x5508880", VA = "0x185509E80")]
	private bool ENJDOMGEIDK(TKey PNABAFEIDND, [Out] TVal PKCLPFEIPFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x550EB10", Offset = "0x550D510", VA = "0x18550EB10")]
	private TVal KJCABELIABF(TKey OMLHPAPCOIC)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5516340", Offset = "0x5514D40", VA = "0x185516340", Slot = "11")]
	public bool TryGetValue(TKey OMLHPAPCOIC, [Out] TVal PKCLPFEIPFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x5506530", Offset = "0x5504F30", VA = "0x185506530", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x55068D0", Offset = "0x55052D0", VA = "0x1855068D0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] LOCJOHPCANM, int FBPHGCDJPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5513600", Offset = "0x5512000", VA = "0x185513600")]
	private void PPAFKIMJKMF(TKey PNABAFEIDND, TVal JBKDPHAINMM, JEHPJBBBPEM OMJKCNAHEJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x550B1F0", Offset = "0x5509BF0", VA = "0x18550B1F0")]
	private bool GBBGFDFPKID(GJJBOCPOGLF FFHNGEDMFCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x54FEAF0", Offset = "0x54FD4F0", VA = "0x1854FEAF0")]
	private void AKLHHCGPANP(LinkedListNode<GJJBOCPOGLF> JADMLDIJLFH, TVal IBFLAGMGMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x550DF50", Offset = "0x550C950", VA = "0x18550DF50")]
	private void IMKENKPFHBD(TKey PNABAFEIDND, TVal PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5506310", Offset = "0x5504D10", VA = "0x185506310")]
	private void COKBPPOHKPJ(GJJBOCPOGLF FFHNGEDMFCA, TVal IBFLAGMGMLI, int HJKFPLCCIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x550B5C0", Offset = "0x5509FC0", VA = "0x18550B5C0", Slot = "19")]
	[IteratorStateMachine(typeof(CHLDBCECJHG<, >.CHKLDCFPIFB))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x5515670", Offset = "0x5514070", VA = "0x185515670", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public enum JEHPJBBBPEM : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class IPNOFJPJIDN<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly TKey BGNJONLHEPF;

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x4267D50", Offset = "0x4266750", VA = "0x184267D50")]
	public IPNOFJPJIDN(TKey EFOAODMNDNF, Exception DMCKMBGEFEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class BMDNAFBOBGL : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x61BF7F0", Offset = "0x61BE1F0", VA = "0x1861BF7F0")]
	public BMDNAFBOBGL(string FCMDIEEAPHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class CKEFNLJAEID<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class AAOGDKBLCCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public CKEFNLJAEID<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public AAOGDKBLCCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x407A140", Offset = "0x4078B40", VA = "0x18407A140")]
		internal Task<TResource> NIBIKKDBHCH(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct JDBIIJNLDGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public CKEFNLJAEID<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4410EE0", Offset = "0x440F8E0", VA = "0x184410EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4411900", Offset = "0x4410300", VA = "0x184411900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct CEKIDJNHIOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x540C240", Offset = "0x540AC40", VA = "0x18540C240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x540CD20", Offset = "0x540B720", VA = "0x18540CD20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly PJJKNIHOECK<TId, Task<TResource>> LBJJMDDKAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> DJDKBHGCJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? CEDIFPAIKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly Action<TResource>? CGOAEPHDNDA;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x560E2F0", Offset = "0x560CCF0", VA = "0x18560E2F0")]
	public CKEFNLJAEID(int JGMFCNKHDLA = 0, [Optional] IEqualityComparer<TId>? JDHLLDOEHIE, [Optional] Func<TId, CancellationToken, Task<TResource>>? KIDHEKMHEGH, [Optional] Action<TResource>? JMMCKJJGKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x560D670", Offset = "0x560C070", VA = "0x18560D670")]
	public CCFPOCKCODD<Task<TResource>> KHJALKMMMOP(TId CMEADPACGME, [Optional] Func<TId, CancellationToken, Task<TResource>>? KIDHEKMHEGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x560D100", Offset = "0x560BB00", VA = "0x18560D100")]
	private void HNMKLBOBHKN(Task<TResource> LPAAFOGOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x560CAF0", Offset = "0x560B4F0", VA = "0x18560CAF0")]
	[AsyncStateMachine(typeof(CKEFNLJAEID<, >.JDBIIJNLDGC))]
	private Task BNEFOHJPFCG(Task<TResource> LPAAFOGOHKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x560CF70", Offset = "0x560B970", VA = "0x18560CF70")]
	public void GKPNBIGCHCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x560CDF0", Offset = "0x560B7F0", VA = "0x18560CDF0")]
	public PJJKNIHOECK<TId, Task<TResource>>.KHJJCJLIGKK CBLJDKEPCGL()
	{
		return default(PJJKNIHOECK<TId, Task<TResource>>.KHJJCJLIGKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x560E100", Offset = "0x560CB00", VA = "0x18560E100", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x560E100", Offset = "0x560CB00", VA = "0x18560E100", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x560DFD0", Offset = "0x560C9D0", VA = "0x18560DFD0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(CKEFNLJAEID<, >.CEKIDJNHIOA))]
	internal static Task PJEEFJNEKIC(Task<TResource> LPAAFOGOHKE, CancellationTokenSource INCCMPGMEPP, Dictionary<Task<TResource>, CancellationTokenSource> DKIHEJELCBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class PJJKNIHOECK<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class PLFDJEKPHFG : IEquatable<PLFDJEKPHFG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public readonly TValue IPHIEALFCML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int ANIACBHEDDB;

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xCA93B0", Offset = "0xCA7DB0", VA = "0x180CA93B0")]
		public PLFDJEKPHFG(TValue PKCLPFEIPFH, int HGKFMKIEEMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x4B82420", Offset = "0x4B80E20", VA = "0x184B82420", Slot = "4")]
		public bool Equals(PLFDJEKPHFG? GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x4B82370", Offset = "0x4B80D70", VA = "0x184B82370", Slot = "0")]
		public override bool Equals(object? BBNKFKDCOLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x4B824B0", Offset = "0x4B80EB0", VA = "0x184B824B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public struct KHJJCJLIGKK : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Dictionary<TKey, PLFDJEKPHFG>.Enumerator MAKGBGALLFJ;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x4553B20", Offset = "0x4552520", VA = "0x184553B20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public (TKey Key, TValue Value, int RefCount) MKGDHLFFCEG
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x4553F70", Offset = "0x4552970", VA = "0x184553F70", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x4553BC0", Offset = "0x45525C0", VA = "0x184553BC0")]
		public KHJJCJLIGKK(PJJKNIHOECK<TKey, TValue> ANMHHNMKHFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x4553610", Offset = "0x4552010", VA = "0x184553610", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x4553690", Offset = "0x4552090", VA = "0x184553690", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x45537C0", Offset = "0x45521C0", VA = "0x1845537C0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class DCFBPHNFIJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public PJJKNIHOECK<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public PLFDJEKPHFG refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public DCFBPHNFIJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x5C75360", Offset = "0x5C73D60", VA = "0x185C75360")]
		internal void NIBIKKDBHCH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly Dictionary<TKey, PLFDJEKPHFG> BHCLKLAENGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Func<TKey, TValue>? KGOAPCEPGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly Action<TValue>? MDANBJAAAGC;

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x4B74F20", Offset = "0x4B73920", VA = "0x184B74F20")]
	public PJJKNIHOECK(int JGMFCNKHDLA = 0, [Optional] IEqualityComparer<TKey>? FJHEBFJGGEP, [Optional] Func<TKey, TValue>? PCLOHIOGDLK, [Optional] Action<TValue>? JFHNJCBHILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x4B73CA0", Offset = "0x4B726A0", VA = "0x184B73CA0")]
	public CCFPOCKCODD<TValue> KHJALKMMMOP(TKey PNABAFEIDND, [Optional] Func<TKey, TValue>? CGOHEABBDJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x4B74960", Offset = "0x4B73360", VA = "0x184B74960")]
	private void MMBLFJNKGED(TKey PNABAFEIDND, PLFDJEKPHFG JGEIMCIDPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4B73830", Offset = "0x4B72230", VA = "0x184B73830")]
	public void GKPNBIGCHCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4B73520", Offset = "0x4B71F20", VA = "0x184B73520")]
	public KHJJCJLIGKK CBLJDKEPCGL()
	{
		return default(KHJJCJLIGKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4B74D30", Offset = "0x4B73730", VA = "0x184B74D30", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4B74D30", Offset = "0x4B73730", VA = "0x184B74D30", Slot = "5")]
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
