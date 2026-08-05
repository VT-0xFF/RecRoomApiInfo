using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E6F560", Offset = "0x5E6E360", VA = "0x185E6F560")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x799B60", Offset = "0x798960", VA = "0x180799B60")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x799BA0", Offset = "0x7989A0", VA = "0x180799BA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class JLCBOFEGJGL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	protected JLCBOFEGJGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class NJEOBLJCENA<T> : JLCBOFEGJGL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct CDEHCOCKOFG
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum EPFPIMDBCKE
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
		public EPFPIMDBCKE AOPDMLJGEMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T CBNAIFNPGEI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int LPCBKGOOCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool CDOONDCNPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool GMCDBIJPHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? CKBGDPHNFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<CDEHCOCKOFG>? CNFNMOELONJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool FJKIKBHDCEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3D1DF30", Offset = "0x3D1CD30", VA = "0x183D1DF30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3D1E380", Offset = "0x3D1D180", VA = "0x183D1E380")]
	protected NJEOBLJCENA(bool GMCDBIJPHDN, bool CDOONDCNPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3D1E2E0", Offset = "0x3D1D0E0", VA = "0x183D1E2E0")]
	protected bool PMGNMFHJCKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3D1DE30", Offset = "0x3D1CC30", VA = "0x183D1DE30")]
	protected void BGCPKPMHFEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3D1DAA0", Offset = "0x3D1C8A0", VA = "0x183D1DAA0")]
	protected void APGAPHKMKOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2421730", Offset = "0x2420530", VA = "0x182421730")]
	private static void KFAEDKFGLDE<U>(List<U>? LCPNBOPPGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3D1DF80", Offset = "0x3D1CD80", VA = "0x183D1DF80", Slot = "4")]
	public void JHPNFEHLKNP(T CBNAIFNPGEI, bool BIPNEBGMPBC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3D1DC80", Offset = "0x3D1CA80", VA = "0x183D1DC80", Slot = "5")]
	public void BFKGBCINJJC(T CBNAIFNPGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3D1E160", Offset = "0x3D1CF60", VA = "0x183D1E160")]
	public void LPNBJONBLDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BILONFDDMPK
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JHPNFEHLKNP(Action CBNAIFNPGEI, bool BIPNEBGMPBC = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFKGBCINJJC(Action CBNAIFNPGEI);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class INNFNKFCEKE : NJEOBLJCENA<Action>, BILONFDDMPK
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DE00", Offset = "0x5E6CC00", VA = "0x185E6DE00")]
	public INNFNKFCEKE(bool GMCDBIJPHDN = false, bool CDOONDCNPNK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DC00", Offset = "0x5E6CA00", VA = "0x185E6DC00")]
	public void NBFCHEKFDKC()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DB40", Offset = "0x5E6C940", VA = "0x185E6DB40")]
	public static INNFNKFCEKE EHKMKKDONHB(INNFNKFCEKE BLDCLPAIBMJ, Action CBNAIFNPGEI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DBA0", Offset = "0x5E6C9A0", VA = "0x185E6DBA0")]
	public static INNFNKFCEKE HKDKKKLFCAD(INNFNKFCEKE BLDCLPAIBMJ, Action CBNAIFNPGEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GPEMFFPJIDO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JHPNFEHLKNP(Action<T> CBNAIFNPGEI, bool BIPNEBGMPBC = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFKGBCINJJC(Action<T> CBNAIFNPGEI);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class BJPKLEOBMLD<T> : NJEOBLJCENA<Action<T>>, GPEMFFPJIDO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x30D9270", Offset = "0x30D8070", VA = "0x1830D9270")]
	public BJPKLEOBMLD(bool GMCDBIJPHDN = false, bool CDOONDCNPNK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x45F3FA0", Offset = "0x45F2DA0", VA = "0x1845F3FA0")]
	public void NBFCHEKFDKC(T KMHHCKOIFKM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x30D5340", Offset = "0x30D4140", VA = "0x1830D5340")]
	public static BJPKLEOBMLD<T> EHKMKKDONHB(BJPKLEOBMLD<T> BLDCLPAIBMJ, Action<T> CBNAIFNPGEI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x30D53D0", Offset = "0x30D41D0", VA = "0x1830D53D0")]
	public static BJPKLEOBMLD<T> HKDKKKLFCAD(BJPKLEOBMLD<T> BLDCLPAIBMJ, Action<T> CBNAIFNPGEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GDHJDOOHBMA<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class EEDIFKNBKON<T, U> : NJEOBLJCENA<Action<T, U>>, GDHJDOOHBMA<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x30D9270", Offset = "0x30D8070", VA = "0x1830D9270")]
	public EEDIFKNBKON(bool GMCDBIJPHDN = false, bool CDOONDCNPNK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x30D6C50", Offset = "0x30D5A50", VA = "0x1830D6C50")]
	public void NBFCHEKFDKC(T KMHHCKOIFKM, U DJBHFFIBLKG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x30D5340", Offset = "0x30D4140", VA = "0x1830D5340")]
	public static EEDIFKNBKON<T, U> EHKMKKDONHB(EEDIFKNBKON<T, U> BLDCLPAIBMJ, Action<T, U> CBNAIFNPGEI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x30D53D0", Offset = "0x30D41D0", VA = "0x1830D53D0")]
	public static EEDIFKNBKON<T, U> HKDKKKLFCAD(EEDIFKNBKON<T, U> BLDCLPAIBMJ, Action<T, U> CBNAIFNPGEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class FACEJLMNJPM<T, U, V> : NJEOBLJCENA<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x30D9270", Offset = "0x30D8070", VA = "0x1830D9270")]
	public FACEJLMNJPM(bool GMCDBIJPHDN = false, bool CDOONDCNPNK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3426310", Offset = "0x3425110", VA = "0x183426310")]
	public void NBFCHEKFDKC(T KMHHCKOIFKM, U DJBHFFIBLKG, V IKEAKMDIHGH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x30D5340", Offset = "0x30D4140", VA = "0x1830D5340")]
	public static FACEJLMNJPM<T, U, V> EHKMKKDONHB(FACEJLMNJPM<T, U, V> BLDCLPAIBMJ, Action<T, U, V> CBNAIFNPGEI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x30D53D0", Offset = "0x30D41D0", VA = "0x1830D53D0")]
	public static FACEJLMNJPM<T, U, V> HKDKKKLFCAD(FACEJLMNJPM<T, U, V> BLDCLPAIBMJ, Action<T, U, V> CBNAIFNPGEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LFDLLDLDDBL<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class FDCBAMGIKAD<T, U, V, W> : NJEOBLJCENA<Action<T, U, V, W>>, LFDLLDLDDBL<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x30D9270", Offset = "0x30D8070", VA = "0x1830D9270")]
	public FDCBAMGIKAD(bool GMCDBIJPHDN = false, bool CDOONDCNPNK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3431560", Offset = "0x3430360", VA = "0x183431560")]
	public void NBFCHEKFDKC(T KMHHCKOIFKM, U DJBHFFIBLKG, V IKEAKMDIHGH, W KHMJGMFIADM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x30D5340", Offset = "0x30D4140", VA = "0x1830D5340")]
	public static FDCBAMGIKAD<T, U, V, W> EHKMKKDONHB(FDCBAMGIKAD<T, U, V, W> BLDCLPAIBMJ, Action<T, U, V, W> CBNAIFNPGEI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x30D53D0", Offset = "0x30D41D0", VA = "0x1830D53D0")]
	public static FDCBAMGIKAD<T, U, V, W> HKDKKKLFCAD(FDCBAMGIKAD<T, U, V, W> BLDCLPAIBMJ, Action<T, U, V, W> CBNAIFNPGEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class FIGLBMNGDJB<T, U, V, W, X> : NJEOBLJCENA<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x30D9270", Offset = "0x30D8070", VA = "0x1830D9270")]
	public FIGLBMNGDJB(bool GMCDBIJPHDN = false, bool CDOONDCNPNK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3453A60", Offset = "0x3452860", VA = "0x183453A60")]
	public void NBFCHEKFDKC(T KMHHCKOIFKM, U DJBHFFIBLKG, V IKEAKMDIHGH, W KHMJGMFIADM, X GPMOHKANAAB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x30D5340", Offset = "0x30D4140", VA = "0x1830D5340")]
	public static FIGLBMNGDJB<T, U, V, W, X> EHKMKKDONHB(FIGLBMNGDJB<T, U, V, W, X> BLDCLPAIBMJ, Action<T, U, V, W, X> CBNAIFNPGEI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x30D53D0", Offset = "0x30D41D0", VA = "0x1830D53D0")]
	public static FIGLBMNGDJB<T, U, V, W, X> HKDKKKLFCAD(FIGLBMNGDJB<T, U, V, W, X> BLDCLPAIBMJ, Action<T, U, V, W, X> CBNAIFNPGEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class LOFJGCKPBKN<T, U, V, W, X, Y> : NJEOBLJCENA<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x30D9270", Offset = "0x30D8070", VA = "0x1830D9270")]
	public LOFJGCKPBKN(bool GMCDBIJPHDN = false, bool CDOONDCNPNK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3ACE8B0", Offset = "0x3ACD6B0", VA = "0x183ACE8B0")]
	public void NBFCHEKFDKC(T KMHHCKOIFKM, U DJBHFFIBLKG, V IKEAKMDIHGH, W KHMJGMFIADM, X GPMOHKANAAB, Y GGKPCMCCKDN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x30D5340", Offset = "0x30D4140", VA = "0x1830D5340")]
	public static LOFJGCKPBKN<T, U, V, W, X, Y> EHKMKKDONHB(LOFJGCKPBKN<T, U, V, W, X, Y> BLDCLPAIBMJ, Action<T, U, V, W, X, Y> CBNAIFNPGEI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x30D53D0", Offset = "0x30D41D0", VA = "0x1830D53D0")]
	public static LOFJGCKPBKN<T, U, V, W, X, Y> HKDKKKLFCAD(LOFJGCKPBKN<T, U, V, W, X, Y> BLDCLPAIBMJ, Action<T, U, V, W, X, Y> CBNAIFNPGEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CODCPJMCGKL<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly AADDLOICHHF<TKey, TVal> HDEACPCEMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> BJMNAONANGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly int MOKHMOAEDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly AADDLOICHHF<TKey, TVal>.FHDOKAKACNB? CJFPOGJMBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int MLGJBKOOAGI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int FNILGMBEJDH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4A87FE0", Offset = "0x4A86DE0", VA = "0x184A87FE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int GHOKKJEEBJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x863AD0", Offset = "0x8628D0", VA = "0x180863AD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4A885A0", Offset = "0x4A873A0", VA = "0x184A885A0")]
	public CODCPJMCGKL(int MOKHMOAEDOD, [Optional] AADDLOICHHF<TKey, TVal>.FHDOKAKACNB? CJFPOGJMBGM, [Optional] IEqualityComparer<TKey>? KDAPDDHBDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4A88030", Offset = "0x4A86E30", VA = "0x184A88030")]
	public void FCNKFFGAOOE(TKey GAMCILOFBAF, TVal PHPDIJICBJO, bool CINMJGFPLDH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4A88200", Offset = "0x4A87000", VA = "0x184A88200")]
	public bool IPBENBAHBNF(TKey GAMCILOFBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4A884C0", Offset = "0x4A872C0", VA = "0x184A884C0")]
	public bool OLBECDHEMJL(TKey DHHKOIOOJGO, [Out] TVal PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4A882A0", Offset = "0x4A870A0", VA = "0x184A882A0")]
	private void KAHCCLBFMKI(TKey GAMCILOFBAF, TVal PHPDIJICBJO, int ICPPKLAMHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4A87E50", Offset = "0x4A86C50", VA = "0x184A87E50")]
	public bool DIIJFAFLOID(TKey GAMCILOFBAF, TVal PHPDIJICBJO, bool CINMJGFPLDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4A87D90", Offset = "0x4A86B90", VA = "0x184A87D90")]
	private bool DGJOKNIIMHI(TKey GAMCILOFBAF)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct BGIGGGBPADJ : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public readonly struct NONLCHNJIAG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0")]
		public static NONLCHNJIAG FMIHPEHEFKO()
		{
			return default(NONLCHNJIAG);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0")]
	public static BGIGGGBPADJ PPDHGDKBBKF(Type AOPDMLJGEMB, [Optional] string? EHGMLHMPCHK, [Optional] string? CGFEHECPGGJ, bool EPDPCLJKNBJ = false)
	{
		return default(BGIGGGBPADJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0")]
	public static BGIGGGBPADJ PPDHGDKBBKF<T>([Optional] string? EHGMLHMPCHK, [Optional] string? CGFEHECPGGJ, bool EPDPCLJKNBJ = false)
	{
		return default(BGIGGGBPADJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct LLMJAGHJFMC
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate bool MKGMJFEIDHG(string NFCPIGACFKF, LLMJAGHJFMC DHBFFFMIAFK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public int AONAOKPLIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public string OFOFIJPAFGN;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E840", Offset = "0x5E6D640", VA = "0x185E6E840")]
	public static Dictionary<string, LLMJAGHJFMC> KOJMCNPIABC(Type NDICMDDBLLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E190", Offset = "0x5E6CF90", VA = "0x185E6E190")]
	public static Dictionary<string, LLMJAGHJFMC> CAMJADBODOB(Type NDICMDDBLLC, MKGMJFEIDHG ELDJOHCIEGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E680", Offset = "0x5E6D480", VA = "0x185E6E680")]
	public static Dictionary<int, string> FKKGLNMNHHB(Dictionary<string, LLMJAGHJFMC> KFIJLJLHGLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[AttributeUsage(AttributeTargets.Enum)]
public abstract class DIAJFDCKHAL : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string DDDJIDOKCLB(string DCOGCCKNMPA);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x77F100", Offset = "0x77DF00", VA = "0x18077F100")]
	protected DIAJFDCKHAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class MEPLDCOBOII : PILBJIJHFMF
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static bool FAMJJOFDIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string? GAMLHEGGEAO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public virtual PILBJIJHFMF? EMINOOOMAKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E010", VA = "0x18076F210", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F220", Offset = "0x5E6E020", VA = "0x185E6F220")]
	protected MEPLDCOBOII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string BCJNMAHEGJF();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F1A0", Offset = "0x5E6DFA0", VA = "0x185E6F1A0", Slot = "8")]
	public virtual string JPPMAOODPPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EC70", Offset = "0x5E6DA70", VA = "0x185E6EC70", Slot = "9")]
	public void HGAEJEPPNLC(StringBuilder FEAOBCJBFAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EB70", Offset = "0x5E6D970", VA = "0x185E6EB70", Slot = "10")]
	public void DDLMECEIEGK(StringBuilder FEAOBCJBFAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F080", Offset = "0x5E6DE80", VA = "0x185E6F080", Slot = "11")]
	public void IAIOCIIMJMM(StringBuilder FEAOBCJBFAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EF20", Offset = "0x5E6DD20", VA = "0x185E6EF20", Slot = "12")]
	public void HNGFLFBIMGB(StringBuilder FEAOBCJBFAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EBD0", Offset = "0x5E6D9D0", VA = "0x185E6EBD0")]
	public static void GHAEHFPPIOM(StringBuilder FEAOBCJBFAE, string BKPKODIPKOP, string FGEIDBDKDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x51B5390", Offset = "0x51B4190", VA = "0x1851B5390", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class HIEJBBMHFMC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DAE0", Offset = "0x5E6C8E0", VA = "0x185E6DAE0")]
	public HIEJBBMHFMC(string KHIFMDJDLEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FHPKNKMAMAO<TErr> : HIEJBBMHFMC where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly TErr DPKAEKCOEJO;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3452860", Offset = "0x3451660", VA = "0x183452860")]
	private FHPKNKMAMAO([In] TErr JBBGLNFLCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3452790", Offset = "0x3451590", VA = "0x183452790")]
	public static FHPKNKMAMAO<TErr> FMIHPEHEFKO([In] TErr JBBGLNFLCCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface PILBJIJHFMF
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JPPMAOODPPC();

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string BCJNMAHEGJF();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FMENBEFEHCP<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	TOptions DHGNDNJJJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface HFNFHFDFDNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string FJMMOGDDAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class JEAIKCFKAOO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DE60", Offset = "0x5E6CC60", VA = "0x185E6DE60")]
	public JEAIKCFKAOO(string KHIFMDJDLEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GIKKJKIMKOA<TOk> : JEAIKCFKAOO where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly TOk OKNFKJEABBN;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x35D3D60", Offset = "0x35D2B60", VA = "0x1835D3D60")]
	private GIKKJKIMKOA([In] TOk IPEDAKBHPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x342E650", Offset = "0x342D450", VA = "0x18342E650")]
	public static GIKKJKIMKOA<TOk> FMIHPEHEFKO([In] TOk IPEDAKBHPME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct EFFPFBGFCJB<TOk, TErr> : IEquatable<EFFPFBGFCJB<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly EqualityComparer<TErr> KIMEODJDCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly TErr DPKAEKCOEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal readonly TOk OKNFKJEABBN;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool JBIEDEKGFIO
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x30DE2F0", Offset = "0x30DD0F0", VA = "0x1830DE2F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool BNLBALDAJOE
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x30DBF10", Offset = "0x30DAD10", VA = "0x1830DBF10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x30E1790", Offset = "0x30E0590", VA = "0x1830E1790")]
	internal EFFPFBGFCJB([In] TErr JBBGLNFLCCC, [In] TOk IPEDAKBHPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x30DB940", Offset = "0x30DA740", VA = "0x1830DB940")]
	public static EFFPFBGFCJB<TOk, TErr> FILGGCOHPPF([In] TErr JBBGLNFLCCC)
	{
		return default(EFFPFBGFCJB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x30DEE30", Offset = "0x30DDC30", VA = "0x1830DEE30")]
	public static EFFPFBGFCJB<TOk, TErr> LOBKLJNMPJA([In] TOk IPEDAKBHPME)
	{
		return default(EFFPFBGFCJB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2E0AB00", Offset = "0x2E09900", VA = "0x182E0AB00")]
	public EFFPFBGFCJB<TOk?, UErr?> OBHHLPLPBDC<UErr>()
	{
		return default(EFFPFBGFCJB<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2E0A5A0", Offset = "0x2E093A0", VA = "0x182E0A5A0")]
	public EFFPFBGFCJB<UOk?, TErr?> FONFGBEPEOL<UOk>()
	{
		return default(EFFPFBGFCJB<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2E0B6C0", Offset = "0x2E0A4C0", VA = "0x182E0B6C0")]
	public EFFPFBGFCJB<UOk?, TErr?> OCCEFJKPNKL<UOk>()
	{
		return default(EFFPFBGFCJB<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2E0A160", Offset = "0x2E08F60", VA = "0x182E0A160")]
	public EFFPFBGFCJB<TOk?, UErr?> CDEIKECFCNN<UErr>()
	{
		return default(EFFPFBGFCJB<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x30DE810", Offset = "0x30DD610", VA = "0x1830DE810")]
	public EFFPFBGFCJB<CJPHMHJPNKO, TErr> KOHGKEDNBBK()
	{
		return default(EFFPFBGFCJB<CJPHMHJPNKO, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x30DD460", Offset = "0x30DC260", VA = "0x1830DD460")]
	public static bool HIHGGPGGFPN([In] EFFPFBGFCJB<TOk, TErr> CJNLLBDPPAC, [In] EFFPFBGFCJB<TOk, TErr> CCDAOMDJCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x30DAB30", Offset = "0x30D9930", VA = "0x1830DAB30", Slot = "4")]
	public bool Equals(EFFPFBGFCJB<TOk, TErr> LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x30DAC00", Offset = "0x30D9A00", VA = "0x1830DAC00", Slot = "0")]
	public override bool Equals(object LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x30DC830", Offset = "0x30DB630", VA = "0x1830DC830", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x30DF600", Offset = "0x30DE400", VA = "0x1830DF600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class GCJKEEAJFMN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct LFGCMGEJKGH<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Task<EFFPFBGFCJB<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<EFFPFBGFCJB<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3AADB80", Offset = "0x3AAC980", VA = "0x183AADB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3AAE1C0", Offset = "0x3AACFC0", VA = "0x183AAE1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class LNIMFJOJIJD<TOk, TErr> : IEnumerable<TOk>, IEnumerable, IEnumerator<TOk>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TOk <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private IEnumerable<EFFPFBGFCJB<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public IEnumerable<EFFPFBGFCJB<TOk, TErr>> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private IEnumerator<EFFPFBGFCJB<TOk, TErr>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TOk? IEnumerator<TOk>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (TOk?)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4CB0", Offset = "0x8C3AB0", VA = "0x1808C4CB0")]
		[DebuggerHidden]
		public LNIMFJOJIJD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x30FEF00", Offset = "0x30FDD00", VA = "0x1830FEF00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3ACD130", Offset = "0x3ACBF30", VA = "0x183ACD130", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3ACD0E0", Offset = "0x3ACBEE0", VA = "0x183ACD0E0")]
		private void FKICEAEIDMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3ACD520", Offset = "0x3ACC320", VA = "0x183ACD520", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3ACD460", Offset = "0x3ACC260", VA = "0x183ACD460", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TOk?>? IEnumerable<TOk>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x33BBF00", Offset = "0x33BAD00", VA = "0x1833BBF00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator? IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x24EFE20", Offset = "0x24EEC20", VA = "0x1824EFE20")]
	public static EFFPFBGFCJB<TOk?, TErr?> OKNFKJEABBN<TOk, TErr>([In] this EFFPFBGFCJB<TOk, TErr> HLCOOGAGOEK, [In] TOk IPEDAKBHPME)
	{
		return default(EFFPFBGFCJB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x24F14B0", Offset = "0x24F02B0", VA = "0x1824F14B0")]
	public static EFFPFBGFCJB<CJPHMHJPNKO, TErr?> OKNFKJEABBN<TErr>([In] this EFFPFBGFCJB<CJPHMHJPNKO, TErr> HLCOOGAGOEK)
	{
		return default(EFFPFBGFCJB<CJPHMHJPNKO, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x24EFE20", Offset = "0x24EEC20", VA = "0x1824EFE20")]
	public static EFFPFBGFCJB<TOk?, TErr?> DPKAEKCOEJO<TOk, TErr>([In] this EFFPFBGFCJB<TOk, TErr> HLCOOGAGOEK, [In] TErr JBBGLNFLCCC)
	{
		return default(EFFPFBGFCJB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x24F1290", Offset = "0x24F0090", VA = "0x1824F1290")]
	public static TOk? OKAJCMFIHHL<TOk, TErr>([In] this EFFPFBGFCJB<TOk, TErr> HLCOOGAGOEK)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x24F07E0", Offset = "0x24EF5E0", VA = "0x1824F07E0")]
	[AsyncStateMachine(typeof(LFGCMGEJKGH<, >))]
	public static Task<TOk?>? LDEIPFCNNLN<TOk, TErr>(this Task<EFFPFBGFCJB<TOk, TErr>> HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x24F00C0", Offset = "0x24EEEC0", VA = "0x1824F00C0")]
	public static TErr? FDJIKGIPHPC<TErr, TOk>([In] this EFFPFBGFCJB<TOk, TErr> HLCOOGAGOEK)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x24F14E0", Offset = "0x24F02E0", VA = "0x1824F14E0")]
	public static bool OLGCGBMBCBF<TOk, TErr, UErr, UOk>([In] this EFFPFBGFCJB<TOk, TErr> HLCOOGAGOEK, [Out] EFFPFBGFCJB<UOk, UErr> LOCDLLMBLMJ) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x24F0770", Offset = "0x24EF570", VA = "0x1824F0770")]
	public static bool HJIDJBBIJHI<TOk, TErr>([In] this EFFPFBGFCJB<TOk, TErr> HLCOOGAGOEK, [Out][NotNullWhen(true)] TOk IPEDAKBHPME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x24F0BF0", Offset = "0x24EF9F0", VA = "0x1824F0BF0")]
	public static bool NAMCOAJMFPL<TOk, TErr>([In] this EFFPFBGFCJB<TOk, TErr> HLCOOGAGOEK, [Out][NotNullWhen(true)] TErr JBBGLNFLCCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x24F02D0", Offset = "0x24EF0D0", VA = "0x1824F02D0")]
	public static bool FMCCHMOFFMF<TOk, TErr>([In] this EFFPFBGFCJB<TOk, TErr> HLCOOGAGOEK, [Out][NotNullWhen(true)] TOk IPEDAKBHPME, [Out][NotNullWhen(false)] TErr JBBGLNFLCCC) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x24F0A80", Offset = "0x24EF880", VA = "0x1824F0A80")]
	public static bool MHGDPBGLLOK<TOk, TErr>([In] this EFFPFBGFCJB<TOk, TErr> HLCOOGAGOEK, [Out][NotNullWhen(true)] TOk IPEDAKBHPME, [Out] EFFPFBGFCJB<TOk, TErr> LOCDLLMBLMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x24F1710", Offset = "0x24F0510", VA = "0x1824F1710")]
	public static bool OLGCGBMBCBF<TOk, TErr, UErr, UOk>([In] this EFFPFBGFCJB<TOk, TErr> HLCOOGAGOEK, [Out][NotNullWhen(true)] TOk IPEDAKBHPME, [Out] EFFPFBGFCJB<UOk, UErr> LOCDLLMBLMJ) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x24F0D30", Offset = "0x24EFB30", VA = "0x1824F0D30")]
	public static bool NGLJECNOPIE<TOk, TErr>([In] this EFFPFBGFCJB<TOk, TErr> HLCOOGAGOEK, [Out][NotNullWhen(true)] TOk IPEDAKBHPME, [Out] EFFPFBGFCJB<CJPHMHJPNKO, TErr> LOCDLLMBLMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x24EFA60", Offset = "0x24EE860", VA = "0x1824EFA60")]
	public static EFFPFBGFCJB<UOk, UErr> DDGBCAGIFNC<UOk, UErr, TOk, TErr>([In] this EFFPFBGFCJB<TOk, TErr> HLCOOGAGOEK, [In] EFFPFBGFCJB<UOk, UErr> ANLNKNAJGIA) where TOk : UOk where TErr : UErr
	{
		return default(EFFPFBGFCJB<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x24F03C0", Offset = "0x24EF1C0", VA = "0x1824F03C0")]
	public static EFFPFBGFCJB<TOk?[]?, TErr?> FMPMJOCAPNC<TOk, TErr>(this IEnumerable<EFFPFBGFCJB<TOk, TErr>> HLCOOGAGOEK)
	{
		return default(EFFPFBGFCJB<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x22B1D60", Offset = "0x22B0B60", VA = "0x1822B1D60")]
	[IteratorStateMachine(typeof(LNIMFJOJIJD<, >))]
	public static IEnumerable<TOk?>? KAKLKFGFPOL<TOk, TErr>(this IEnumerable<EFFPFBGFCJB<TOk, TErr>> HLCOOGAGOEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class ABLKGAJBFMM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x20CBB50", Offset = "0x20CA950", VA = "0x1820CBB50")]
	public static EFFPFBGFCJB<TOk, T> OKNFKJEABBN<TOk>([In] TOk IPEDAKBHPME) where TOk : notnull
	{
		return default(EFFPFBGFCJB<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x379C330", Offset = "0x379B130", VA = "0x18379C330")]
	public static EFFPFBGFCJB<CJPHMHJPNKO, T> OKNFKJEABBN()
	{
		return default(EFFPFBGFCJB<CJPHMHJPNKO, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x20CBB50", Offset = "0x20CA950", VA = "0x1820CBB50")]
	public static EFFPFBGFCJB<T, TErr> DPKAEKCOEJO<TErr>([In] TErr JBBGLNFLCCC) where TErr : notnull
	{
		return default(EFFPFBGFCJB<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public sealed class JNDOBBJIIAJ<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private readonly struct CLOCPDEBLDP : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly JNDOBBJIIAJ<T> LGOPGNLDMMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly int BDENBLIPEHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly bool ANAHCMFKFDG;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1BD16F0", Offset = "0x1BD04F0", VA = "0x181BD16F0")]
		public CLOCPDEBLDP(JNDOBBJIIAJ<T> DDAGOAKHODP, int GNKOCPOMMKB, bool BEGLEGBGPKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x49C0790", Offset = "0x49BF590", VA = "0x1849C0790")]
		public JNDOBBJIIAJ<T>.LLJHIFGCLGP NABGDMMLCNI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x49C0880", Offset = "0x49BF680", VA = "0x1849C0880", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x49C0880", Offset = "0x49BF680", VA = "0x1849C0880", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class LLJHIFGCLGP : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly JNDOBBJIIAJ<T> LGOPGNLDMMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly int COEGPKCLPJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int EEKCLOABPFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly bool ANAHCMFKFDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool MPOFIAHDLAP;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public T POOLCAAKLKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x3AC9B20", Offset = "0x3AC8920", VA = "0x183AC9B20")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x3AC9C10", Offset = "0x3AC8A10", VA = "0x183AC9C10", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x3AC9D30", Offset = "0x3AC8B30", VA = "0x183AC9D30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3ACA320", Offset = "0x3AC9120", VA = "0x183ACA320")]
		public LLJHIFGCLGP(JNDOBBJIIAJ<T> DDAGOAKHODP, int GNKOCPOMMKB, bool BEGLEGBGPKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3AC9B60", Offset = "0x3AC8960", VA = "0x183AC9B60", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3AC9BF0", Offset = "0x3AC89F0", VA = "0x183AC9BF0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class LELNACMAHIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public LELNACMAHIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3AACD90", Offset = "0x3AABB90", VA = "0x183AACD90")]
		internal T JLHJDNENLDA(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly T[] LOBAFBMDDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private int EEKCLOABPFK;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int IAGECBFNLPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x39C9710", Offset = "0x39C8510", VA = "0x1839C9710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T POOLCAAKLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3423F50", Offset = "0x3422D50", VA = "0x183423F50")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T PFPABELFGLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x39C96E0", Offset = "0x39C84E0", VA = "0x1839C96E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public T LNGAKLGPPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x39C98E0", Offset = "0x39C86E0", VA = "0x1839C98E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int DLGHEHGPEHA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x15A3900", Offset = "0x15A2700", VA = "0x1815A3900")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xE83C40", Offset = "0xE82A40", VA = "0x180E83C40")]
	private static int NFPIHBFHJEB(int NGIPPLLBEKC, int ELGJIDFGJJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x39C9AD0", Offset = "0x39C88D0", VA = "0x1839C9AD0")]
	public JNDOBBJIIAJ(int ICPPKLAMHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x39C9BE0", Offset = "0x39C89E0", VA = "0x1839C9BE0")]
	public JNDOBBJIIAJ(int ICPPKLAMHFE, Func<T> MLIGKAKFLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x39C9D60", Offset = "0x39C8B60", VA = "0x1839C9D60")]
	public JNDOBBJIIAJ(T[] BLKANEONNOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x39C9940", Offset = "0x39C8740", VA = "0x1839C9940")]
	public void ONAIEJEIIDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x39C9970", Offset = "0x39C8770", VA = "0x1839C9970")]
	public IEnumerable<T> OOKPJMNECKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x39C9760", Offset = "0x39C8560", VA = "0x1839C9760")]
	public JNDOBBJIIAJ<T>.LLJHIFGCLGP NABGDMMLCNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x34E44F0", Offset = "0x34E32F0", VA = "0x1834E44F0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x34E44F0", Offset = "0x34E32F0", VA = "0x1834E44F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class KJHCIKMEJLK
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2553E40", Offset = "0x2552C40", VA = "0x182553E40")]
	public static JNDOBBJIIAJ<T> FMIHPEHEFKO<T>(int ICPPKLAMHFE, Func<T> MLIGKAKFLIM) where T : notnull
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
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const float kEpsilon = 1E-05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3C70", Offset = "0x1CB2A70", VA = "0x181CB3C70")]
		public RRColor(float OLDPDBPDEBC, float GOJBJPHNJNC, float DCODMCLNKEM, float ALNGIEPPLJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F710", Offset = "0x5E6E510", VA = "0x185E6F710", Slot = "4")]
		public bool Equals(RRColor LCIDHBCOPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F790", Offset = "0x5E6E590", VA = "0x185E6F790", Slot = "0")]
		public override bool Equals(object LCIDHBCOPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F890", Offset = "0x5E6E690", VA = "0x185E6F890", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F910", Offset = "0x5E6E710", VA = "0x185E6F910", Slot = "5")]
		public string ToString(string NFCLHEIIJBK, IFormatProvider NJOKMGAKNLM)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class OHIKLKJGGKK<TData> : MEPLDCOBOII where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly string GOIENPJADHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly TData AEDKPPANMLD;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "7")]
	public override string BCJNMAHEGJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5AF0", Offset = "0x3DE48F0", VA = "0x183DE5AF0")]
	internal OHIKLKJGGKK(string KHIFMDJDLEG, [In] TData KNAIEKIJLBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class OOCBHNOAHIK
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F5E0", Offset = "0x5E6E3E0", VA = "0x185E6F5E0")]
	public static OHIKLKJGGKK<CJPHMHJPNKO> FMIHPEHEFKO(string KHIFMDJDLEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x22A0BB0", Offset = "0x229F9B0", VA = "0x1822A0BB0")]
	public static OHIKLKJGGKK<TData> FMIHPEHEFKO<TData>(string KHIFMDJDLEG, [In] TData KNAIEKIJLBC) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class EKFDLEJGKKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Dictionary<object, float> OOCFAHFELIB;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float EOFHNDPNBGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x83BB90", Offset = "0x83A990", VA = "0x18083BB90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x83BC30", Offset = "0x83AA30", VA = "0x18083BC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D2E0", Offset = "0x5E6C0E0", VA = "0x185E6D2E0")]
	public void LGBBGBJPJPF(float PHPDIJICBJO, object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D140", Offset = "0x5E6BF40", VA = "0x185E6D140")]
	public void AKIGHCHOBPD(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D1B0", Offset = "0x5E6BFB0", VA = "0x185E6D1B0")]
	private void CHGDHNCBEJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D350", Offset = "0x5E6C150", VA = "0x185E6D350")]
	public EKFDLEJGKKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class LGOCCBOIBDC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class NPHHNFPILCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public NPHHNFPILCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D38C30", Offset = "0x3D37A30", VA = "0x183D38C30")]
		internal int EFIFCDIPMHO(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private HashSet<T>? GJMFMHJDGBM;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public IReadOnlyCollection<T> AONDLAEOGDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x3AB4100", Offset = "0x3AB2F00", VA = "0x183AB4100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool GPNAEKJBFBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3AB40C0", Offset = "0x3AB2EC0", VA = "0x183AB40C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int BMGCAELLGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x774610", Offset = "0x773410", VA = "0x180774610")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x777760", Offset = "0x776560", VA = "0x180777760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3AB4130", Offset = "0x3AB2F30", VA = "0x183AB4130")]
	public bool JHPNFEHLKNP(T HOBAPMCPFML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3AB3FA0", Offset = "0x3AB2DA0", VA = "0x183AB3FA0")]
	public bool BFKGBCINJJC(T HOBAPMCPFML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3AB42A0", Offset = "0x3AB30A0", VA = "0x183AB42A0")]
	public bool ONHABPEFGAG(T HOBAPMCPFML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3AB42E0", Offset = "0x3AB30E0", VA = "0x183AB42E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public LGOCCBOIBDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class GMLJCNLKEBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly string PDPIPIIFJOF;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x770FF0", Offset = "0x76FDF0", VA = "0x180770FF0")]
	public GMLJCNLKEBM(string PDPIPIIFJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DA90", Offset = "0x5E6C890", VA = "0x185E6DA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class FMCHKOLFDCF
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class PGBGLLCCCPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public PGBGLLCCCPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F660", Offset = "0x5E6E460", VA = "0x185E6F660")]
		internal int EFIFCDIPMHO(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private HashSet<object>? GJMFMHJDGBM;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IReadOnlyCollection<object> AONDLAEOGDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D570", Offset = "0x5E6C370", VA = "0x185E6D570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool GPNAEKJBFBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D560", Offset = "0x5E6C360", VA = "0x185E6D560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int BMGCAELLGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x774610", Offset = "0x773410", VA = "0x180774610")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x777760", Offset = "0x776560", VA = "0x180777760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D600", Offset = "0x5E6C400", VA = "0x185E6D600")]
	public bool JHPNFEHLKNP(object HOBAPMCPFML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D4C0", Offset = "0x5E6C2C0", VA = "0x185E6D4C0")]
	public bool BFKGBCINJJC(object HOBAPMCPFML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D750", Offset = "0x5E6C550", VA = "0x185E6D750")]
	public bool ONHABPEFGAG(object HOBAPMCPFML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D6E0", Offset = "0x5E6C4E0", VA = "0x185E6D6E0")]
	public void OIIJLOGMAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D7B0", Offset = "0x5E6C5B0", VA = "0x185E6D7B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public FMCHKOLFDCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class PHEOKLNJGFL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct MLPAIOHJBNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public float CKEIKCNNFIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public T DHGNDNJJJIH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly Dictionary<object, MLPAIOHJBNN> OOCFAHFELIB;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public virtual T OJGAFKFKBDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xDC2600", Offset = "0xDC1400", VA = "0x180DC2600", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xDC1BD0", Offset = "0xDC09D0", VA = "0x180DC1BD0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public object? MKCOIFAIJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x772C00", Offset = "0x771A00", VA = "0x180772C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x777020", Offset = "0x775E20", VA = "0x180777020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool BDDFEPNGHJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3EF26B0", Offset = "0x3EF14B0", VA = "0x183EF26B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3EF3F00", Offset = "0x3EF2D00", VA = "0x183EF3F00")]
	public bool LGBBGBJPJPF(T PHPDIJICBJO, object HOBAPMCPFML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7D60", Offset = "0x3DD6B60", VA = "0x183DD7D60")]
	public bool AKIGHCHOBPD(object HOBAPMCPFML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3EF4500", Offset = "0x3EF3300", VA = "0x183EF4500")]
	public void LPNBJONBLDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3EF46A0", Offset = "0x3EF34A0", VA = "0x183EF46A0")]
	public bool OLBECDHEMJL(object HOBAPMCPFML, [Out] T PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3EF2980", Offset = "0x3EF1780", VA = "0x183EF2980")]
	[JGLJCKHOFCF("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool JJLCOBODHAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3EF48C0", Offset = "0x3EF36C0", VA = "0x183EF48C0")]
	public PHEOKLNJGFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface IDHLLJFPINO
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event IOJPABNADAA NBCKMIBPPCM;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class CPGOOABFMPM : IDHLLJFPINO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct LGFPNNLBPOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly float FKBNENBLEJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly float KIEPBNIPFMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal readonly bool ACDJDJBKPCD;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float BMGCJGPBFOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x5E6DEC0", Offset = "0x5E6CCC0", VA = "0x185E6DEC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5E6E030", Offset = "0x5E6CE30", VA = "0x185E6E030")]
		public LGFPNNLBPOH(float EIJIJLGPLFO, float GNLJFNAGDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E6DED0", Offset = "0x5E6CCD0", VA = "0x185E6DED0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class NCDCDNNEAKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public CPGOOABFMPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public NCDCDNNEAKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F290", Offset = "0x5E6E090", VA = "0x185E6F290")]
		internal void FKNJKKLCEFN(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly int FNJNELBIPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private int IEIPHGCEKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly IDHLLJFPINO[] LNNFEBKCOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly IOJPABNADAA[] GPBKPNHGBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly LGFPNNLBPOH[] ENHFFPAJELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private LGFPNNLBPOH FBEJMDILHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly NEKOLDJCPJF CGAJJOEJEOD;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event IOJPABNADAA NBCKMIBPPCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C820", Offset = "0x5E6B620", VA = "0x185E6C820", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C9F0", Offset = "0x5E6B7F0", VA = "0x185E6C9F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CFB0", Offset = "0x5E6BDB0", VA = "0x185E6CFB0")]
	public CPGOOABFMPM(int FNJNELBIPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CAB0", Offset = "0x5E6B8B0", VA = "0x185E6CAB0")]
	public NEKOLDJCPJF JPEGKNGFGPM(LGFPNNLBPOH DMPANOBEEED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CB40", Offset = "0x5E6B940", VA = "0x185E6CB40")]
	public void LAGDIFEJHLC(IDHLLJFPINO PMEAOAJNHJA, [Optional] LGFPNNLBPOH DIMICLPMPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C8E0", Offset = "0x5E6B6E0", VA = "0x185E6C8E0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public delegate void IOJPABNADAA(float IAOPKDFPKMC);
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class FOOLOMNILMJ
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private class FKCLLJICNKO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly IDHLLJFPINO PALDHOFNCNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private readonly IOJPABNADAA PJJEKPONKPF;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D430", Offset = "0x5E6C230", VA = "0x185E6D430")]
		public FKCLLJICNKO(IDHLLJFPINO PALDHOFNCNE, IOJPABNADAA PJJEKPONKPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D3E0", Offset = "0x5E6C1E0", VA = "0x185E6D3E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D960", Offset = "0x5E6C760", VA = "0x185E6D960")]
	internal static bool AJJNBLKADJC(float ALNGIEPPLJJ, float DCODMCLNKEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E63030", Offset = "0x5E61E30", VA = "0x185E63030")]
	internal static float CBJIAPHEDHG(float ALNGIEPPLJJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D9D0", Offset = "0x5E6C7D0", VA = "0x185E6D9D0")]
	public static IDisposable FJDKBFBAOFF(this IDHLLJFPINO PALDHOFNCNE, IOJPABNADAA PJJEKPONKPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class NEKOLDJCPJF : IDHLLJFPINO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private float IAOPKDFPKMC;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public float OJJECADIEKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F330", Offset = "0x5E6E130", VA = "0x185E6F330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event IOJPABNADAA? NBCKMIBPPCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F420", Offset = "0x5E6E220", VA = "0x185E6F420", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F4C0", Offset = "0x5E6E2C0", VA = "0x185E6F4C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public NEKOLDJCPJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class NEBBKGMOEBO : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x59E7E20", Offset = "0x59E6C20", VA = "0x1859E7E20")]
	public NEBBKGMOEBO(string KHIFMDJDLEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DefaultMember("Item")]
public class ADHCIOBKIJC<TKey, TValue> : BPFMFFAFGAD<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, CNILANFDMKK where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class DPBFPCGEEPN : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public ADHCIOBKIJC<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xDC2600", Offset = "0xDC1400", VA = "0x180DC2600", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x4DCF640", Offset = "0x4DCE440", VA = "0x184DCF640", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x77AE60", Offset = "0x779C60", VA = "0x18077AE60")]
		[DebuggerHidden]
		public DPBFPCGEEPN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x33BC6B0", Offset = "0x33BB4B0", VA = "0x1833BC6B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4DCEDC0", Offset = "0x4DCDBC0", VA = "0x184DCEDC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4DCE970", Offset = "0x4DCD770", VA = "0x184DCE970")]
		private void FKICEAEIDMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4DCE880", Offset = "0x4DCD680", VA = "0x184DCE880")]
		private void CEJKOOJCMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4DCF5F0", Offset = "0x4DCE3F0", VA = "0x184DCF5F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly BPFMFFAFGAD<TKey, TValue> NCFIDAOLHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly IDictionary<TKey, TValue> COMEINLJHNF;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int BMGCAELLGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x37A1350", Offset = "0x37A0150", VA = "0x1837A1350", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool FDJGALFBLIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TValue LNGAKLGPPKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x37A15F0", Offset = "0x37A03F0", VA = "0x1837A15F0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x37A1870", Offset = "0x37A0670", VA = "0x1837A1870", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public ICollection<TKey> LJNPJAKIEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x37A1630", Offset = "0x37A0430", VA = "0x1837A1630", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public ICollection<TValue> NMKAJDCHPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x37A1740", Offset = "0x37A0540", VA = "0x1837A1740", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x37A12A0", Offset = "0x37A00A0", VA = "0x1837A12A0")]
	public ADHCIOBKIJC(BPFMFFAFGAD<TKey, TValue> NCFIDAOLHLE, [Optional] IDictionary<TKey, TValue>? COMEINLJHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x379EDB0", Offset = "0x379DBB0", VA = "0x18379EDB0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x379EC30", Offset = "0x379DA30", VA = "0x18379EC30")]
	public void BGONAMNKEPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x379E900", Offset = "0x379D700", VA = "0x18379E900", Slot = "9")]
	public void Add(TKey GAMCILOFBAF, TValue PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x37A00F0", Offset = "0x379EEF0", VA = "0x1837A00F0")]
	public void HGKPBBPFJML(TKey GAMCILOFBAF, TValue PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x37A0370", Offset = "0x379F170", VA = "0x1837A0370")]
	public void IDEBPLEOFKK(TKey GAMCILOFBAF, TValue PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x379FB90", Offset = "0x379E990", VA = "0x18379FB90")]
	public void FOJPMDBAMGC(TKey GAMCILOFBAF, TValue PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x379FDD0", Offset = "0x379EBD0", VA = "0x18379FDD0")]
	public void FPLJILBMLEO(TKey GAMCILOFBAF, TValue PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x37A08C0", Offset = "0x379F6C0", VA = "0x1837A08C0", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> DAPKCDOOBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x37A0920", Offset = "0x379F720", VA = "0x1837A0920", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> DAPKCDOOBFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x37A0E20", Offset = "0x379FC20", VA = "0x1837A0E20", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> DAPKCDOOBFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x379EE20", Offset = "0x379DC20", VA = "0x18379EE20", Slot = "8")]
	public bool ContainsKey(TKey GAMCILOFBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x37A0580", Offset = "0x379F380", VA = "0x1837A0580")]
	public bool KDDEKBHOCLC(TKey GAMCILOFBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x379ECE0", Offset = "0x379DAE0", VA = "0x18379ECE0")]
	public bool CDBEBGEOPNK(TKey GAMCILOFBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x37A0710", Offset = "0x379F510", VA = "0x1837A0710", Slot = "10")]
	public bool Remove(TKey GAMCILOFBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x37A10F0", Offset = "0x379FEF0", VA = "0x1837A10F0", Slot = "11")]
	public bool TryGetValue(TKey GAMCILOFBAF, [Out] TValue PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x379F410", Offset = "0x379E210", VA = "0x18379F410", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] LPMIAHOCPLL, int LKGKKAPFOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x37A0FE0", Offset = "0x379FDE0", VA = "0x1837A0FE0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x379FF90", Offset = "0x379ED90", VA = "0x18379FF90", Slot = "19")]
	[IteratorStateMachine(typeof(ADHCIOBKIJC<, >.DPBFPCGEEPN))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x379EBE0", Offset = "0x379D9E0", VA = "0x18379EBE0", Slot = "21")]
	public bool BDIMMCJJKGL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x379F810", Offset = "0x379E610", VA = "0x18379F810")]
	private TValue DAHLOJIHCEH(TKey GAMCILOFBAF)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface CNILANFDMKK
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BDIMMCJJKGL();
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface BPFMFFAFGAD<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, CNILANFDMKK
{
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[DefaultMember("Item")]
public sealed class AADDLOICHHF<TKey, TVal> : BPFMFFAFGAD<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, CNILANFDMKK where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate int FHDOKAKACNB(TKey GAMCILOFBAF, TVal PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private class KKPNCHLPFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public TKey OLNAGICFANI
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xAFA210", Offset = "0xAF9010", VA = "0x180AFA210")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public TVal DHGNDNJJJIH
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x863AD0", Offset = "0x8628D0", VA = "0x180863AD0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x863AB0", Offset = "0x8628B0", VA = "0x180863AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int BMGCJGPBFOP
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x7AFF60", Offset = "0x7AED60", VA = "0x1807AFF60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x7AF560", Offset = "0x7AE360", VA = "0x1807AF560")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public DateTimeOffset MFBEIIGAAGC
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x9C9610", Offset = "0x9C8410", VA = "0x1809C9610")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x11EE1E0", Offset = "0x11ECFE0", VA = "0x1811EE1E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3A40730", Offset = "0x3A3F530", VA = "0x183A40730")]
		public KKPNCHLPFOJ(TKey GAMCILOFBAF, TVal DEEINHGIBAA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class AILLDJJDCMI : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AADDLOICHHF<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private LinkedList<KKPNCHLPFOJ>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xDC2600", Offset = "0xDC1400", VA = "0x180DC2600", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x37B2100", Offset = "0x37B0F00", VA = "0x1837B2100", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x77AE60", Offset = "0x779C60", VA = "0x18077AE60")]
		[DebuggerHidden]
		public AILLDJJDCMI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x30FEF00", Offset = "0x30FDD00", VA = "0x1830FEF00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x37B1610", Offset = "0x37B0410", VA = "0x1837B1610", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x37AF7F0", Offset = "0x37AE5F0", VA = "0x1837AF7F0")]
		private void FKICEAEIDMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x37B1EA0", Offset = "0x37B0CA0", VA = "0x1837B1EA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public const int MOAMJPHNDHO = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly Dictionary<TKey, LinkedListNode<KKPNCHLPFOJ>> MCLBLHJMAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly LinkedList<KKPNCHLPFOJ> LKJCONLEMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly FHDOKAKACNB? CJFPOGJMBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly TimeSpan BPKDGKNELJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly LPIODFHGMMJ IBJOGMAGKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool IDCLFDOPGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly List<TKey> PLKPEOCKANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly List<TVal> EFGMIHICNIE;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int GHOKKJEEBJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x78D2D0", Offset = "0x78C0D0", VA = "0x18078D2D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	internal int FNILGMBEJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x78D2E0", Offset = "0x78C0E0", VA = "0x18078D2E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xDB44F0", Offset = "0xDB32F0", VA = "0x180DB44F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int BMGCAELLGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3501700", Offset = "0x3500500", VA = "0x183501700", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	internal int FLGNEKANBOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3453140", Offset = "0x3451F40", VA = "0x183453140")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public ICollection<TVal> NMKAJDCHPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3501830", Offset = "0x3500630", VA = "0x183501830", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	ICollection<TKey> IDictionary<TKey, TVal>.OKKLABMNCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x34FF0D0", Offset = "0x34FDED0", VA = "0x1834FF0D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool FDJGALFBLIP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public TVal LNGAKLGPPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x3501760", Offset = "0x3500560", VA = "0x183501760", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x3501860", Offset = "0x3500660", VA = "0x183501860", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x34F84B0", Offset = "0x34F72B0", VA = "0x1834F84B0")]
	private bool CODFBIBKJOJ(int FNJNELBIPIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x34FC8F0", Offset = "0x34FB6F0", VA = "0x1834FC8F0")]
	private void NHJENEAHAOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3501640", Offset = "0x3500440", VA = "0x183501640")]
	public AADDLOICHHF(int FNJNELBIPIL, [Optional] FHDOKAKACNB? CJFPOGJMBGM, [Optional] IEqualityComparer<TKey>? KDAPDDHBDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x34FFB00", Offset = "0x34FE900", VA = "0x1834FFB00")]
	public AADDLOICHHF(TimeSpan BPKDGKNELJI, [Optional] IEqualityComparer<TKey>? KDAPDDHBDKB, [Optional] LPIODFHGMMJ? IBJOGMAGKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x34FFA00", Offset = "0x34FE800", VA = "0x1834FFA00")]
	public AADDLOICHHF(int FNJNELBIPIL, TimeSpan BPKDGKNELJI, [Optional] IEqualityComparer<TKey>? KDAPDDHBDKB, [Optional] LPIODFHGMMJ? IBJOGMAGKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3500000", Offset = "0x34FEE00", VA = "0x183500000")]
	public AADDLOICHHF(int FNJNELBIPIL, FHDOKAKACNB? CJFPOGJMBGM, TimeSpan BPKDGKNELJI, [Optional] IEqualityComparer<TKey>? KDAPDDHBDKB, [Optional] LPIODFHGMMJ? IBJOGMAGKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x34F7460", Offset = "0x34F6260", VA = "0x1834F7460", Slot = "21")]
	public bool BDIMMCJJKGL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x34FCE80", Offset = "0x34FBC80", VA = "0x1834FCE80", Slot = "22")]
	public bool PAPBHJEHEKD(int ICPPKLAMHFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x34FBD90", Offset = "0x34FAB90", VA = "0x1834FBD90")]
	private bool NCOJODCJIEL(int ICPPKLAMHFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x34F7880", Offset = "0x34F6680", VA = "0x1834F7880")]
	public void CCOBHHAAMMF(TKey GAMCILOFBAF, TVal PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x34F7040", Offset = "0x34F5E40", VA = "0x1834F7040", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> DAPKCDOOBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x34F6D30", Offset = "0x34F5B30", VA = "0x1834F6D30", Slot = "9")]
	public void Add(TKey GAMCILOFBAF, TVal PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x34F8690", Offset = "0x34F7490", VA = "0x1834F8690", Slot = "8")]
	public bool ContainsKey(TKey GAMCILOFBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x34FEA80", Offset = "0x34FD880", VA = "0x1834FEA80", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> DAPKCDOOBFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x34FE6A0", Offset = "0x34FD4A0", VA = "0x1834FE6A0", Slot = "10")]
	public bool Remove(TKey GAMCILOFBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x34FEC30", Offset = "0x34FDA30", VA = "0x1834FEC30", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> DAPKCDOOBFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x34FA330", Offset = "0x34F9130", VA = "0x1834FA330")]
	private bool IMFCOMMJIAF(TKey GAMCILOFBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x34FA230", Offset = "0x34F9030", VA = "0x1834FA230")]
	private TVal HFNEOIKDHBA(TKey DHHKOIOOJGO)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x34FF840", Offset = "0x34FE640", VA = "0x1834FF840", Slot = "11")]
	public bool TryGetValue(TKey DHHKOIOOJGO, [Out] TVal PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x34F8500", Offset = "0x34F7300", VA = "0x1834F8500", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x34F9140", Offset = "0x34F7F40", VA = "0x1834F9140", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] LPMIAHOCPLL, int LKGKKAPFOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x34FC170", Offset = "0x34FAF70", VA = "0x1834FC170")]
	private bool NHFKJONNLEP(KKPNCHLPFOJ DGDLHPDNKKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x34FE300", Offset = "0x34FD100", VA = "0x1834FE300")]
	private void PMFENGOFMDL(LinkedListNode<KKPNCHLPFOJ> MDNCMOCHIJF, TVal IBLOAPAOIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x34FAB20", Offset = "0x34F9920", VA = "0x1834FAB20")]
	private void LGBBGBJPJPF(TKey GAMCILOFBAF, TVal PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x34F7970", Offset = "0x34F6770", VA = "0x1834F7970")]
	private void CECLCKDKIEM(KKPNCHLPFOJ DGDLHPDNKKE, TVal IBLOAPAOIFJ, int JHFHHOIEMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x34F9B00", Offset = "0x34F8900", VA = "0x1834F9B00", Slot = "19")]
	[IteratorStateMachine(typeof(AADDLOICHHF<, >.AILLDJJDCMI))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x34FF100", Offset = "0x34FDF00", VA = "0x1834FF100", Slot = "20")]
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
