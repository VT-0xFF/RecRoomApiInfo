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
		[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x606DB30", Offset = "0x606C530", VA = "0x18606DB30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D2560", Offset = "0x7D0F60", VA = "0x1807D2560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D25A0", Offset = "0x7D0FA0", VA = "0x1807D25A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class KADOKHFKKHK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	protected KADOKHFKKHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class EFPIIEDMBDG<T> : KADOKHFKKHK
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct OPGAIGAJKHP
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum CFOLGCOLGFK
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
		public CFOLGCOLGFK ADAMDPHPFAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T MCLCEMNNOFC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int GABEJNCELOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool MMCELDMNEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool KBONKPJBKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? MFFFNBMOHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<OPGAIGAJKHP>? HKJLKBMNOOO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool BALEFKMEOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3210070", Offset = "0x320EA70", VA = "0x183210070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3210490", Offset = "0x320EE90", VA = "0x183210490")]
	protected EFPIIEDMBDG(bool KBONKPJBKKI, bool MMCELDMNEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x32103F0", Offset = "0x320EDF0", VA = "0x1832103F0")]
	protected bool PHFHPOMAFMC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x320FD90", Offset = "0x320E790", VA = "0x18320FD90")]
	protected void DHNLNFPFOPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x320FBB0", Offset = "0x320E5B0", VA = "0x18320FBB0")]
	protected void BHKKLLJLHNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x223F8C0", Offset = "0x223E2C0", VA = "0x18223F8C0")]
	private static void CGGPKCFFGFD<U>(List<U>? EPNEAFACLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x320FE90", Offset = "0x320E890", VA = "0x18320FE90", Slot = "4")]
	public void FLOHBAGDPJC(T MCLCEMNNOFC, bool BBNHGDKLLEC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x32100C0", Offset = "0x320EAC0", VA = "0x1832100C0", Slot = "5")]
	public void NJHEJNEGCKN(T MCLCEMNNOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3210270", Offset = "0x320EC70", VA = "0x183210270")]
	public void NJLBNDAIMDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OBKMCFLFOCN
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLOHBAGDPJC(Action MCLCEMNNOFC, bool BBNHGDKLLEC = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJHEJNEGCKN(Action MCLCEMNNOFC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class KKEEGFAPLDK : EFPIIEDMBDG<Action>, OBKMCFLFOCN
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x606BDD0", Offset = "0x606A7D0", VA = "0x18606BDD0")]
	public KKEEGFAPLDK(bool KBONKPJBKKI = false, bool MMCELDMNEIG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x606BB70", Offset = "0x606A570", VA = "0x18606BB70")]
	public void HEMLICAMOIG()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x606BD70", Offset = "0x606A770", VA = "0x18606BD70")]
	public static KKEEGFAPLDK KILOAEIJEKO(KKEEGFAPLDK EFBBNAJCOID, Action MCLCEMNNOFC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x606BB10", Offset = "0x606A510", VA = "0x18606BB10")]
	public static KKEEGFAPLDK DEAFAHIGGBI(KKEEGFAPLDK EFBBNAJCOID, Action MCLCEMNNOFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DIAOINMDBPG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLOHBAGDPJC(Action<T> MCLCEMNNOFC, bool BBNHGDKLLEC = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJHEJNEGCKN(Action<T> MCLCEMNNOFC);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class PFEKNBHDJHH<T> : EFPIIEDMBDG<Action<T>>, DIAOINMDBPG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x372BFC0", Offset = "0x372A9C0", VA = "0x18372BFC0")]
	public PFEKNBHDJHH(bool KBONKPJBKKI = false, bool MMCELDMNEIG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3FD74D0", Offset = "0x3FD5ED0", VA = "0x183FD74D0")]
	public void HEMLICAMOIG(T FENMDPNPDJP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x372BF30", Offset = "0x372A930", VA = "0x18372BF30")]
	public static PFEKNBHDJHH<T> KILOAEIJEKO(PFEKNBHDJHH<T> EFBBNAJCOID, Action<T> MCLCEMNNOFC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3728090", Offset = "0x3726A90", VA = "0x183728090")]
	public static PFEKNBHDJHH<T> DEAFAHIGGBI(PFEKNBHDJHH<T> EFBBNAJCOID, Action<T> MCLCEMNNOFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KBNIPMCDCMP<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class APBBKGHGNMG<T, U> : EFPIIEDMBDG<Action<T, U>>, KBNIPMCDCMP<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x372BFC0", Offset = "0x372A9C0", VA = "0x18372BFC0")]
	public APBBKGHGNMG(bool KBONKPJBKKI = false, bool MMCELDMNEIG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x372B130", Offset = "0x3729B30", VA = "0x18372B130")]
	public void HEMLICAMOIG(T FENMDPNPDJP, U GCBKFJHNBKG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x372BF30", Offset = "0x372A930", VA = "0x18372BF30")]
	public static APBBKGHGNMG<T, U> KILOAEIJEKO(APBBKGHGNMG<T, U> EFBBNAJCOID, Action<T, U> MCLCEMNNOFC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3728090", Offset = "0x3726A90", VA = "0x183728090")]
	public static APBBKGHGNMG<T, U> DEAFAHIGGBI(APBBKGHGNMG<T, U> EFBBNAJCOID, Action<T, U> MCLCEMNNOFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class IKPPCOONOBI<T, U, V> : EFPIIEDMBDG<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x372BFC0", Offset = "0x372A9C0", VA = "0x18372BFC0")]
	public IKPPCOONOBI(bool KBONKPJBKKI = false, bool MMCELDMNEIG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x37FAD60", Offset = "0x37F9760", VA = "0x1837FAD60")]
	public void HEMLICAMOIG(T FENMDPNPDJP, U GCBKFJHNBKG, V MHNPONMPDCG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x372BF30", Offset = "0x372A930", VA = "0x18372BF30")]
	public static IKPPCOONOBI<T, U, V> KILOAEIJEKO(IKPPCOONOBI<T, U, V> EFBBNAJCOID, Action<T, U, V> MCLCEMNNOFC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3728090", Offset = "0x3726A90", VA = "0x183728090")]
	public static IKPPCOONOBI<T, U, V> DEAFAHIGGBI(IKPPCOONOBI<T, U, V> EFBBNAJCOID, Action<T, U, V> MCLCEMNNOFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GLAJJENFHLJ<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class NNLPCOMBHPP<T, U, V, W> : EFPIIEDMBDG<Action<T, U, V, W>>, GLAJJENFHLJ<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x372BFC0", Offset = "0x372A9C0", VA = "0x18372BFC0")]
	public NNLPCOMBHPP(bool KBONKPJBKKI = false, bool MMCELDMNEIG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3E47CD0", Offset = "0x3E466D0", VA = "0x183E47CD0")]
	public void HEMLICAMOIG(T FENMDPNPDJP, U GCBKFJHNBKG, V MHNPONMPDCG, W LKDONMJJPCN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x372BF30", Offset = "0x372A930", VA = "0x18372BF30")]
	public static NNLPCOMBHPP<T, U, V, W> KILOAEIJEKO(NNLPCOMBHPP<T, U, V, W> EFBBNAJCOID, Action<T, U, V, W> MCLCEMNNOFC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3728090", Offset = "0x3726A90", VA = "0x183728090")]
	public static NNLPCOMBHPP<T, U, V, W> DEAFAHIGGBI(NNLPCOMBHPP<T, U, V, W> EFBBNAJCOID, Action<T, U, V, W> MCLCEMNNOFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class NDHGGGMOPFH<T, U, V, W, X> : EFPIIEDMBDG<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x372BFC0", Offset = "0x372A9C0", VA = "0x18372BFC0")]
	public NDHGGGMOPFH(bool KBONKPJBKKI = false, bool MMCELDMNEIG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3E2FA10", Offset = "0x3E2E410", VA = "0x183E2FA10")]
	public void HEMLICAMOIG(T FENMDPNPDJP, U GCBKFJHNBKG, V MHNPONMPDCG, W LKDONMJJPCN, X LGHEBJJLAGD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x372BF30", Offset = "0x372A930", VA = "0x18372BF30")]
	public static NDHGGGMOPFH<T, U, V, W, X> KILOAEIJEKO(NDHGGGMOPFH<T, U, V, W, X> EFBBNAJCOID, Action<T, U, V, W, X> MCLCEMNNOFC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3728090", Offset = "0x3726A90", VA = "0x183728090")]
	public static NDHGGGMOPFH<T, U, V, W, X> DEAFAHIGGBI(NDHGGGMOPFH<T, U, V, W, X> EFBBNAJCOID, Action<T, U, V, W, X> MCLCEMNNOFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class BHJOJMJBMBG<T, U, V, W, X, Y> : EFPIIEDMBDG<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x372BFC0", Offset = "0x372A9C0", VA = "0x18372BFC0")]
	public BHJOJMJBMBG(bool KBONKPJBKKI = false, bool MMCELDMNEIG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x463BE20", Offset = "0x463A820", VA = "0x18463BE20")]
	public void HEMLICAMOIG(T FENMDPNPDJP, U GCBKFJHNBKG, V MHNPONMPDCG, W LKDONMJJPCN, X LGHEBJJLAGD, Y FGIFEPPMILE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x372BF30", Offset = "0x372A930", VA = "0x18372BF30")]
	public static BHJOJMJBMBG<T, U, V, W, X, Y> KILOAEIJEKO(BHJOJMJBMBG<T, U, V, W, X, Y> EFBBNAJCOID, Action<T, U, V, W, X, Y> MCLCEMNNOFC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3728090", Offset = "0x3726A90", VA = "0x183728090")]
	public static BHJOJMJBMBG<T, U, V, W, X, Y> DEAFAHIGGBI(BHJOJMJBMBG<T, U, V, W, X, Y> EFBBNAJCOID, Action<T, U, V, W, X, Y> MCLCEMNNOFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NMNDOPJHNGE<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly MJLLEPHHJHI<TKey, TVal> BEMPGJDEKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> CNONAMCJGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly int OCEJLAPIBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly MJLLEPHHJHI<TKey, TVal>.PPEICCCLIIN? KGEHLPHHEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int GOIIECFDOHN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int JCNCHEMNGCI
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3E46560", Offset = "0x3E44F60", VA = "0x183E46560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int GNOKEDLFEFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8C30C0", Offset = "0x8C1AC0", VA = "0x1808C30C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3E46BA0", Offset = "0x3E455A0", VA = "0x183E46BA0")]
	public NMNDOPJHNGE(int OCEJLAPIBJB, [Optional] MJLLEPHHJHI<TKey, TVal>.PPEICCCLIIN? KGEHLPHHEIL, [Optional] IEqualityComparer<TKey>? FJBNIHOMMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3E46390", Offset = "0x3E44D90", VA = "0x183E46390")]
	public void BBPLDEELCBF(TKey KCGLPAPOILB, TVal FDFHGIHHGHO, bool DJLLKAFPCPP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3E465B0", Offset = "0x3E44FB0", VA = "0x183E465B0")]
	public bool EDHCABCMHIK(TKey KCGLPAPOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3E46AC0", Offset = "0x3E454C0", VA = "0x183E46AC0")]
	public bool MFCFPLHBNLD(TKey JLHAOFBOAMO, [Out] TVal FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3E46710", Offset = "0x3E45110", VA = "0x183E46710")]
	private void GLHFDLMBPNK(TKey KCGLPAPOILB, TVal FDFHGIHHGHO, int BFFGCOIILMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3E46930", Offset = "0x3E45330", VA = "0x183E46930")]
	public bool LGMHHCNNEOD(TKey KCGLPAPOILB, TVal FDFHGIHHGHO, bool DJLLKAFPCPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3E46650", Offset = "0x3E45050", VA = "0x183E46650")]
	private bool FAEMGLFNKGH(TKey KCGLPAPOILB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IKCHCEMKDEK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Action HAMKLIIFHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool DPEKFEGDLJG;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
	public IKCHCEMKDEK(Action NJNIBIJAKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x606B8A0", Offset = "0x606A2A0", VA = "0x18606B8A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2536550", Offset = "0x2534F50", VA = "0x182536550")]
	public static DKOAJFJKKBO<T> NDFPICIGPEG<T>(T FDFHGIHHGHO, Action NJNIBIJAKOK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class DKOAJFJKKBO<T> : IKCHCEMKDEK where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T NAJOFLHMBPO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4F1C3F0", Offset = "0x4F1ADF0", VA = "0x184F1C3F0")]
	public DKOAJFJKKBO(T FDFHGIHHGHO, Action NJNIBIJAKOK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct JFHNBCMMCBM : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct GNPEOHHFLMH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0")]
		public static GNPEOHHFLMH JKJFENIAMEL()
		{
			return default(GNPEOHHFLMH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0")]
	public static JFHNBCMMCBM OGHELNAPKFG(Type ADAMDPHPFAA, [Optional] string? DHMELDCIENN, [Optional] string? BPKHIODBLAG, bool OBALHMCJMLE = false)
	{
		return default(JFHNBCMMCBM);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0")]
	public static JFHNBCMMCBM OGHELNAPKFG<T>([Optional] string? DHMELDCIENN, [Optional] string? BPKHIODBLAG, bool OBALHMCJMLE = false)
	{
		return default(JFHNBCMMCBM);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct NJECMKJCHLN
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool ALNDINNGDFF(string MOFHKLOIPKE, NJECMKJCHLN DOEAANFMIPN);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public int EPPCBJOAABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public string FMHOOBGDDNM;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x606CD20", Offset = "0x606B720", VA = "0x18606CD20")]
	public static Dictionary<string, NJECMKJCHLN> GIONMCBMGJF(Type BEDHMHDFJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x606D050", Offset = "0x606BA50", VA = "0x18606D050")]
	public static Dictionary<string, NJECMKJCHLN> ODIDOILMHAH(Type BEDHMHDFJHM, ALNDINNGDFF IFENPEIBPKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x606CB60", Offset = "0x606B560", VA = "0x18606CB60")]
	public static Dictionary<int, string> GDDEJPFIPIK(Dictionary<string, NJECMKJCHLN> JIBNFGIMNPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class NOJMEPFJKIM : PKFDKDKJAIE
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static bool NBIMBBOGCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly string? JKDCHODMOKI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual PKFDKDKJAIE? DMFDDPGAOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7A8380", Offset = "0x7A6D80", VA = "0x1807A8380", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x606DAC0", Offset = "0x606C4C0", VA = "0x18606DAC0")]
	protected NOJMEPFJKIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string GMMJBFEOGBG();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x606DA40", Offset = "0x606C440", VA = "0x18606DA40", Slot = "8")]
	public virtual string NMNGFLDOGJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x606D790", Offset = "0x606C190", VA = "0x18606D790", Slot = "9")]
	public void NMBHEJLHMCA(StringBuilder JCBFBOIDMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x606D4B0", Offset = "0x606BEB0", VA = "0x18606D4B0", Slot = "10")]
	public void GACDJLNCILB(StringBuilder JCBFBOIDMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x606D510", Offset = "0x606BF10", VA = "0x18606D510", Slot = "11")]
	public void GJBIODMIKJM(StringBuilder JCBFBOIDMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x606D630", Offset = "0x606C030", VA = "0x18606D630", Slot = "12")]
	public void LHLGPDNIGNH(StringBuilder JCBFBOIDMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x606D410", Offset = "0x606BE10", VA = "0x18606D410")]
	public static void CKDKDALJJOO(StringBuilder JCBFBOIDMHE, string OIOEICOLCFK, string ICNDOBMEEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x52F1350", Offset = "0x52EFD50", VA = "0x1852F1350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class OOEPIKBKNCM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x606DBB0", Offset = "0x606C5B0", VA = "0x18606DBB0")]
	public OOEPIKBKNCM(string DCKDMGKGDFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EHDKIPJCGGG<TErr> : OOEPIKBKNCM where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly TErr FIFMAKOIIAI;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3211110", Offset = "0x320FB10", VA = "0x183211110")]
	private EHDKIPJCGGG([In] TErr CMFELDDODDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3211040", Offset = "0x320FA40", VA = "0x183211040")]
	public static EHDKIPJCGGG<TErr> JKJFENIAMEL([In] TErr CMFELDDODDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface PKFDKDKJAIE
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NMNGFLDOGJA();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string GMMJBFEOGBG();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface GDGKCKFKOJJ<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TOptions NAJOFLHMBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface FCDLODPBFED
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string IKMDIGIALIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GNEEMLMGKHI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x606B7F0", Offset = "0x606A1F0", VA = "0x18606B7F0")]
	public GNEEMLMGKHI(string DCKDMGKGDFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class LNPJJHNIIGJ<TOk> : GNEEMLMGKHI where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly TOk KFDAIKAACAG;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3BA4F90", Offset = "0x3BA3990", VA = "0x183BA4F90")]
	private LNPJJHNIIGJ([In] TOk HBOAKAKCPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x37C4220", Offset = "0x37C2C20", VA = "0x1837C4220")]
	public static LNPJJHNIIGJ<TOk> JKJFENIAMEL([In] TOk HBOAKAKCPDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct KKHLNMGODKL<TOk, TErr> : IEquatable<KKHLNMGODKL<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static readonly EqualityComparer<TErr> PNPMBDCAIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly TErr FIFMAKOIIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly TOk KFDAIKAACAG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool OHACJECCFBB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x3AAEF60", Offset = "0x3AAD960", VA = "0x183AAEF60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool GDAENDGNNIF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3AAE230", Offset = "0x3AACC30", VA = "0x183AAE230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1D50", Offset = "0x3AB0750", VA = "0x183AB1D50")]
	internal KKHLNMGODKL([In] TErr CMFELDDODDF, [In] TOk HBOAKAKCPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3AAA550", Offset = "0x3AA8F50", VA = "0x183AAA550")]
	public static KKHLNMGODKL<TOk, TErr> BFJPNPEHDIL([In] TErr CMFELDDODDF)
	{
		return default(KKHLNMGODKL<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3AAE8C0", Offset = "0x3AAD2C0", VA = "0x183AAE8C0")]
	public static KKHLNMGODKL<TOk, TErr> KDGOIKIJBMM([In] TOk HBOAKAKCPDP)
	{
		return default(KKHLNMGODKL<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x25BCA30", Offset = "0x25BB430", VA = "0x1825BCA30")]
	public KKHLNMGODKL<TOk?, UErr?> GKDILODOHMM<UErr>()
	{
		return default(KKHLNMGODKL<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2508380", Offset = "0x2506D80", VA = "0x182508380")]
	public KKHLNMGODKL<UOk?, TErr?> JCPCIFNNELI<UOk>()
	{
		return default(KKHLNMGODKL<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2508120", Offset = "0x2506B20", VA = "0x182508120")]
	public KKHLNMGODKL<UOk?, TErr?> FDJKEAILLFG<UOk>()
	{
		return default(KKHLNMGODKL<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x25BD680", Offset = "0x25BC080", VA = "0x1825BD680")]
	public KKHLNMGODKL<TOk?, UErr?> KODOALIFPNN<UErr>()
	{
		return default(KKHLNMGODKL<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3AAACC0", Offset = "0x3AA96C0", VA = "0x183AAACC0")]
	public KKHLNMGODKL<PJHBHBBODGG, TErr> ELLEMAPEEPB()
	{
		return default(KKHLNMGODKL<PJHBHBBODGG, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3AAD050", Offset = "0x3AABA50", VA = "0x183AAD050")]
	public static bool FFFIMEBHMPG([In] KKHLNMGODKL<TOk, TErr> JIKBDKDLPCA, [In] KKHLNMGODKL<TOk, TErr> DOFNKPFHEKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3AAB290", Offset = "0x3AA9C90", VA = "0x183AAB290", Slot = "4")]
	public bool Equals(KKHLNMGODKL<TOk, TErr> AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3AAB980", Offset = "0x3AAA380", VA = "0x183AAB980", Slot = "0")]
	public override bool Equals(object AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3AAD530", Offset = "0x3AABF30", VA = "0x183AAD530", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1170", Offset = "0x3AAFB70", VA = "0x183AB1170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class GLDHEKPHIFL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct HKMPGCFICIK<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Task<KKHLNMGODKL<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<KKHLNMGODKL<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x37316E0", Offset = "0x37300E0", VA = "0x1837316E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3731D20", Offset = "0x3730720", VA = "0x183731D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2691AB0", Offset = "0x26904B0", VA = "0x182691AB0")]
	public static KKHLNMGODKL<TOk?, TErr?> KFDAIKAACAG<TOk, TErr>([In] this KKHLNMGODKL<TOk, TErr> NHHBAHIFHJK, [In] TOk HBOAKAKCPDP)
	{
		return default(KKHLNMGODKL<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x26938D0", Offset = "0x26922D0", VA = "0x1826938D0")]
	public static KKHLNMGODKL<PJHBHBBODGG, TErr?> KFDAIKAACAG<TErr>([In] this KKHLNMGODKL<PJHBHBBODGG, TErr> NHHBAHIFHJK)
	{
		return default(KKHLNMGODKL<PJHBHBBODGG, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2691AB0", Offset = "0x26904B0", VA = "0x182691AB0")]
	public static KKHLNMGODKL<TOk?, TErr?> FIFMAKOIIAI<TOk, TErr>([In] this KKHLNMGODKL<TOk, TErr> NHHBAHIFHJK, [In] TErr CMFELDDODDF)
	{
		return default(KKHLNMGODKL<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2693240", Offset = "0x2691C40", VA = "0x182693240")]
	public static TOk? HGLHDNKOEGO<TOk, TErr>([In] this KKHLNMGODKL<TOk, TErr> NHHBAHIFHJK)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2692C10", Offset = "0x2691610", VA = "0x182692C10")]
	[AsyncStateMachine(typeof(HKMPGCFICIK<, >))]
	public static Task<TOk?>? GLBEDFPFBGG<TOk, TErr>(this Task<KKHLNMGODKL<TOk, TErr>> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2693510", Offset = "0x2691F10", VA = "0x182693510")]
	public static TErr? IDADJOLNKBH<TErr, TOk>([In] this KKHLNMGODKL<TOk, TErr> NHHBAHIFHJK)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2691BC0", Offset = "0x26905C0", VA = "0x182691BC0")]
	public static bool GGEALMNHJMO<TOk, TErr, UErr, UOk>([In] this KKHLNMGODKL<TOk, TErr> NHHBAHIFHJK, [Out] KKHLNMGODKL<UOk, UErr> MIDPPLABCKI) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2694070", Offset = "0x2692A70", VA = "0x182694070")]
	public static bool LIDJCJGKACK<TOk, TErr>([In] this KKHLNMGODKL<TOk, TErr> NHHBAHIFHJK, [Out][NotNullWhen(true)] TOk HBOAKAKCPDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x26919F0", Offset = "0x26903F0", VA = "0x1826919F0")]
	public static bool EFCBPCCMCHE<TOk, TErr>([In] this KKHLNMGODKL<TOk, TErr> NHHBAHIFHJK, [Out][NotNullWhen(true)] TErr CMFELDDODDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x26940E0", Offset = "0x2692AE0", VA = "0x1826940E0")]
	public static bool OIAAFCPEJHN<TOk, TErr>([In] this KKHLNMGODKL<TOk, TErr> NHHBAHIFHJK, [Out][NotNullWhen(true)] TOk HBOAKAKCPDP, [Out][NotNullWhen(false)] TErr CMFELDDODDF) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x26937D0", Offset = "0x26921D0", VA = "0x1826937D0")]
	public static bool JNFNPLPBEBM<TOk, TErr>([In] this KKHLNMGODKL<TOk, TErr> NHHBAHIFHJK, [Out][NotNullWhen(true)] TOk HBOAKAKCPDP, [Out] KKHLNMGODKL<TOk, TErr> MIDPPLABCKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2691DF0", Offset = "0x26907F0", VA = "0x182691DF0")]
	public static bool GGEALMNHJMO<TOk, TErr, UErr, UOk>([In] this KKHLNMGODKL<TOk, TErr> NHHBAHIFHJK, [Out][NotNullWhen(true)] TOk HBOAKAKCPDP, [Out] KKHLNMGODKL<UOk, UErr> MIDPPLABCKI) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2693D10", Offset = "0x2692710", VA = "0x182693D10")]
	public static bool LGLCMCEEHEO<TOk, TErr>([In] this KKHLNMGODKL<TOk, TErr> NHHBAHIFHJK, [Out][NotNullWhen(true)] TOk HBOAKAKCPDP, [Out] KKHLNMGODKL<PJHBHBBODGG, TErr> MIDPPLABCKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2691660", Offset = "0x2690060", VA = "0x182691660")]
	public static KKHLNMGODKL<UOk, UErr> DBDGOCLNIHO<UOk, UErr, TOk, TErr>([In] this KKHLNMGODKL<TOk, TErr> NHHBAHIFHJK, [In] KKHLNMGODKL<UOk, UErr> JHEMNDMHNOB) where TOk : UOk where TErr : UErr
	{
		return default(KKHLNMGODKL<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2693900", Offset = "0x2692300", VA = "0x182693900")]
	public static KKHLNMGODKL<TOk?[]?, TErr?> LAFIGOHDHEP<TOk, TErr>(this IEnumerable<KKHLNMGODKL<TOk, TErr>> NHHBAHIFHJK)
	{
		return default(KKHLNMGODKL<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class FDLPBEPKMKP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x223FC30", Offset = "0x223E630", VA = "0x18223FC30")]
	public static KKHLNMGODKL<TOk, T> KFDAIKAACAG<TOk>([In] TOk HBOAKAKCPDP) where TOk : notnull
	{
		return default(KKHLNMGODKL<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x35A1E40", Offset = "0x35A0840", VA = "0x1835A1E40")]
	public static KKHLNMGODKL<PJHBHBBODGG, T> KFDAIKAACAG()
	{
		return default(KKHLNMGODKL<PJHBHBBODGG, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x223FC30", Offset = "0x223E630", VA = "0x18223FC30")]
	public static KKHLNMGODKL<T, TErr> FIFMAKOIIAI<TErr>([In] TErr CMFELDDODDF) where TErr : notnull
	{
		return default(KKHLNMGODKL<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public sealed class IAGMEJPGGLG<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private readonly struct HHHILCEKNCN : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly IAGMEJPGGLG<T> FADHFJMFNKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly int DCLCGMJAAIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly bool OEIIBBIMCDL;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1C7DEB0", Offset = "0x1C7C8B0", VA = "0x181C7DEB0")]
		public HHHILCEKNCN(IAGMEJPGGLG<T> CEBGEIIIEAM, int IAIMCNINKBB, bool PGNFLNLCAJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x370B200", Offset = "0x3709C00", VA = "0x18370B200")]
		public IAGMEJPGGLG<T>.DPAFKDKLFDE MFONJKCHJIL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x370B2F0", Offset = "0x3709CF0", VA = "0x18370B2F0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x370B2F0", Offset = "0x3709CF0", VA = "0x18370B2F0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class DPAFKDKLFDE : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly IAGMEJPGGLG<T> FADHFJMFNKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly int HDCMGFOEGED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int GJJACCEHJNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly bool OEIIBBIMCDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool EHOOOIGPALP;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T FPOHGHGPMEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x4F2C430", Offset = "0x4F2AE30", VA = "0x184F2C430")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x4F2C5A0", Offset = "0x4F2AFA0", VA = "0x184F2C5A0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x4F2C6C0", Offset = "0x4F2B0C0", VA = "0x184F2C6C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4F2CCB0", Offset = "0x4F2B6B0", VA = "0x184F2CCB0")]
		public DPAFKDKLFDE(IAGMEJPGGLG<T> CEBGEIIIEAM, int IAIMCNINKBB, bool PGNFLNLCAJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4F2C4F0", Offset = "0x4F2AEF0", VA = "0x184F2C4F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4F2C580", Offset = "0x4F2AF80", VA = "0x184F2C580", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class MPCANHCKJKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public MPCANHCKJKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3C30", Offset = "0x3DD2630", VA = "0x183DD3C30")]
		internal T GOCEDAKMJLI(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly T[] BILENEANONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int GJJACCEHJNF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int NJMBCBIIFBD
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x37C4840", Offset = "0x37C3240", VA = "0x1837C4840")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T FPOHGHGPMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x35975D0", Offset = "0x3595FD0", VA = "0x1835975D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T OBADPIAFNKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x37C4810", Offset = "0x37C3210", VA = "0x1837C4810")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T BFKPGKFLJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x37C47B0", Offset = "0x37C31B0", VA = "0x1837C47B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int NDHLDPJEOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1637E10", Offset = "0x1636810", VA = "0x181637E10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xF36570", Offset = "0xF34F70", VA = "0x180F36570")]
	private static int MIIMNLFBFLM(int OJANCMLFDOJ, int CBKFAHCFHJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x37C4B40", Offset = "0x37C3540", VA = "0x1837C4B40")]
	public IAGMEJPGGLG(int BFFGCOIILMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x37C4920", Offset = "0x37C3320", VA = "0x1837C4920")]
	public IAGMEJPGGLG(int BFFGCOIILMK, Func<T> AHOMMOMFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x37C4D90", Offset = "0x37C3790", VA = "0x1837C4D90")]
	public IAGMEJPGGLG(T[] NBBGPGGFMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x37C4690", Offset = "0x37C3090", VA = "0x1837C4690")]
	public void FEEPLGJILOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x37C45D0", Offset = "0x37C2FD0", VA = "0x1837C45D0")]
	public IEnumerable<T> AKEBJOHCODB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x37C4890", Offset = "0x37C3290", VA = "0x1837C4890")]
	public IAGMEJPGGLG<T>.DPAFKDKLFDE MFONJKCHJIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x32063D0", Offset = "0x3204DD0", VA = "0x1832063D0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x32063D0", Offset = "0x3204DD0", VA = "0x1832063D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class EPIFGGBFNJG
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2563B80", Offset = "0x2562580", VA = "0x182563B80")]
	public static IAGMEJPGGLG<T> JKJFENIAMEL<T>(int BFFGCOIILMK, Func<T> AHOMMOMFKHL) where T : notnull
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
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float kEpsilon = 1E-05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1D66390", Offset = "0x1D64D90", VA = "0x181D66390")]
		public RRColor(float FEDGKNJBNJN, float MFNGJNAICAH, float LFCFPOEDJCH, float MAGGDEMNFDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x606DC80", Offset = "0x606C680", VA = "0x18606DC80", Slot = "4")]
		public bool Equals(RRColor AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x606DD00", Offset = "0x606C700", VA = "0x18606DD00", Slot = "0")]
		public override bool Equals(object AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x606DE00", Offset = "0x606C800", VA = "0x18606DE00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x606DE80", Offset = "0x606C880", VA = "0x18606DE80", Slot = "5")]
		public string ToString(string CLNBNIFIABA, IFormatProvider CFLJBPEPIHC)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class PPHKGMCHEIH<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public readonly struct PFEBKAMHPIK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly PPHKGMCHEIH<T> LLDFFBKKKMF;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public T NAJOFLHMBPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x3FD5CE0", Offset = "0x3FD46E0", VA = "0x183FD5CE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3FD5CB0", Offset = "0x3FD46B0", VA = "0x183FD5CB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8C6B40", Offset = "0x8C5540", VA = "0x1808C6B40")]
		public PFEBKAMHPIK(PPHKGMCHEIH<T> LLDFFBKKKMF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct FENCFIKIDKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<PFEBKAMHPIK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public PPHKGMCHEIH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x35A5F80", Offset = "0x35A4980", VA = "0x1835A5F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x302C500", Offset = "0x302AF00", VA = "0x18302C500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly SemaphoreSlim FFIKGPDKLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private T EDAECHJGCPN;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4026F10", Offset = "0x4025910", VA = "0x184026F10")]
	public PPHKGMCHEIH([In] T EDAECHJGCPN, int IGJOMFKAPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4026FB0", Offset = "0x40259B0", VA = "0x184026FB0")]
	public PPHKGMCHEIH([In] T EDAECHJGCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4026E90", Offset = "0x4025890", VA = "0x184026E90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4026ED0", Offset = "0x40258D0", VA = "0x184026ED0")]
	public PFEBKAMHPIK JGFPJHGGHNM()
	{
		return default(PFEBKAMHPIK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4026D70", Offset = "0x4025770", VA = "0x184026D70")]
	[AsyncStateMachine(typeof(PPHKGMCHEIH<>.FENCFIKIDKM))]
	public Task<PPHKGMCHEIH<T>.PFEBKAMHPIK> BHDBCONKGOD(CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4026EB0", Offset = "0x40258B0", VA = "0x184026EB0")]
	public void HFBBMBGILNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class PODFKOLNMDE
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x606DC10", Offset = "0x606C610", VA = "0x18606DC10")]
	public static PPHKGMCHEIH<PJHBHBBODGG> JKJFENIAMEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2730430", Offset = "0x272EE30", VA = "0x182730430")]
	public static PPHKGMCHEIH<T> JKJFENIAMEL<T>([In] T EDAECHJGCPN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class PAPBDLFBJGK<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct MFKMADJMJOO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly PAPBDLFBJGK<T> NOHCKNOFBEJ;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T NAJOFLHMBPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x3D943C0", Offset = "0x3D92DC0", VA = "0x183D943C0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3D942A0", Offset = "0x3D92CA0", VA = "0x183D942A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8C6B40", Offset = "0x8C5540", VA = "0x1808C6B40")]
		internal MFKMADJMJOO(PAPBDLFBJGK<T> LLDFFBKKKMF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct BLNPIIBOOKM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly PAPBDLFBJGK<T> NOHCKNOFBEJ;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T NAJOFLHMBPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x3D943C0", Offset = "0x3D92DC0", VA = "0x183D943C0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x4666E50", Offset = "0x4665850", VA = "0x184666E50", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8C6B40", Offset = "0x8C5540", VA = "0x1808C6B40")]
		internal BLNPIIBOOKM(PAPBDLFBJGK<T> LLDFFBKKKMF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct OMDHBBCPDGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<BLNPIIBOOKM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public PAPBDLFBJGK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private PPHKGMCHEIH<PJHBHBBODGG>.PFEBKAMHPIK <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<PPHKGMCHEIH<PJHBHBBODGG>.PFEBKAMHPIK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3F31470", Offset = "0x3F2FE70", VA = "0x183F31470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x302C500", Offset = "0x302AF00", VA = "0x18302C500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly PPHKGMCHEIH<int> KGALJIBINHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly PPHKGMCHEIH<PJHBHBBODGG> KGCLOBDNKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly PPHKGMCHEIH<PJHBHBBODGG> EFDLILIDFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private T ABIAOLKOEAH;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3FBC510", Offset = "0x3FBAF10", VA = "0x183FBC510")]
	internal PAPBDLFBJGK(PPHKGMCHEIH<int> BPDGJKBHFDM, PPHKGMCHEIH<PJHBHBBODGG> AHGAJAILFKI, PPHKGMCHEIH<PJHBHBBODGG> DBPOKJNNNND, [In] T EDAECHJGCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3FBB7F0", Offset = "0x3FBA1F0", VA = "0x183FBB7F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3FBB8F0", Offset = "0x3FBA2F0", VA = "0x183FBB8F0")]
	public MFKMADJMJOO MBGBGOCHAHN()
	{
		return default(MFKMADJMJOO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3FBC3A0", Offset = "0x3FBADA0", VA = "0x183FBC3A0")]
	public BLNPIIBOOKM POJMGPDPHDM()
	{
		return default(BLNPIIBOOKM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3FBC090", Offset = "0x3FBAA90", VA = "0x183FBC090")]
	[AsyncStateMachine(typeof(PAPBDLFBJGK<>.OMDHBBCPDGF))]
	public Task<PAPBDLFBJGK<T>.BLNPIIBOOKM> OIFOAMINDBG(CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class NELAIEJIDPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x606CA90", Offset = "0x606B490", VA = "0x18606CA90")]
	public static PAPBDLFBJGK<PJHBHBBODGG> JKJFENIAMEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x27BE1E0", Offset = "0x27BCBE0", VA = "0x1827BE1E0")]
	public static PAPBDLFBJGK<T> JKJFENIAMEL<T>([In] T EDAECHJGCPN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class KFOFMIDIMKC<TData> : NOJMEPFJKIM where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly string FEMPLJOMNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly TData IHMOEAABGNA;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "7")]
	public override string GMMJBFEOGBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3A94220", Offset = "0x3A92C20", VA = "0x183A94220")]
	internal KFOFMIDIMKC(string DCKDMGKGDFN, [In] TData MFNOAEFOKBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class DEBDHNPNGFN
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x606B370", Offset = "0x6069D70", VA = "0x18606B370")]
	public static KFOFMIDIMKC<PJHBHBBODGG> JKJFENIAMEL(string DCKDMGKGDFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2536550", Offset = "0x2534F50", VA = "0x182536550")]
	public static KFOFMIDIMKC<TData> JKJFENIAMEL<TData>(string DCKDMGKGDFN, [In] TData MFNOAEFOKBK) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class LECIONMHFPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly Dictionary<object, float> PBLEFJPDFNN;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float HBKCHJFHKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8C63A0", Offset = "0x8C4DA0", VA = "0x1808C63A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8C6440", Offset = "0x8C4E40", VA = "0x1808C6440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x606BF60", Offset = "0x606A960", VA = "0x18606BF60")]
	public void JCJIKHJCHHK(float FDFHGIHHGHO, object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x606BFD0", Offset = "0x606A9D0", VA = "0x18606BFD0")]
	public void KFIFCFIPLDK(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x606BE30", Offset = "0x606A830", VA = "0x18606BE30")]
	private void GFHAEDEBADM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x606C040", Offset = "0x606AA40", VA = "0x18606C040")]
	public LECIONMHFPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class FGEOBMDKMFP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class AANJEFDFFHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public AANJEFDFFHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x365A1C0", Offset = "0x3658BC0", VA = "0x18365A1C0")]
		internal int PJNBJBDKOAM(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private HashSet<T>? ALPAAFNCDOB;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<T> LNNDAGHEIDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x35A7A60", Offset = "0x35A6460", VA = "0x1835A7A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool GKEEJKBHGEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x35A78B0", Offset = "0x35A62B0", VA = "0x1835A78B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int OICIIFDIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7B0920", Offset = "0x7AF320", VA = "0x1807B0920")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7B1070", Offset = "0x7AFA70", VA = "0x1807B1070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x35A78F0", Offset = "0x35A62F0", VA = "0x1835A78F0")]
	public bool FLOHBAGDPJC(T FACMOGNGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x35A7AD0", Offset = "0x35A64D0", VA = "0x1835A7AD0")]
	public bool NJHEJNEGCKN(T FACMOGNGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x35A7A90", Offset = "0x35A6490", VA = "0x1835A7A90")]
	public bool NBEEIKJCOIK(T FACMOGNGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x35A7BF0", Offset = "0x35A65F0", VA = "0x1835A7BF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public FGEOBMDKMFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class ICDJEGFNKHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly string PKNHHJOMLDP;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
	public ICDJEGFNKHF(string PKNHHJOMLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x606B850", Offset = "0x606A250", VA = "0x18606B850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class CIADAKDIJIG
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class CFHEOMDFENA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public CFHEOMDFENA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x606AE20", Offset = "0x6069820", VA = "0x18606AE20")]
		internal int PJNBJBDKOAM(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private HashSet<object>? ALPAAFNCDOB;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IReadOnlyCollection<object> LNNDAGHEIDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x606B030", Offset = "0x6069A30", VA = "0x18606B030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool GKEEJKBHGEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x606AF40", Offset = "0x6069940", VA = "0x18606AF40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int OICIIFDIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7B0920", Offset = "0x7AF320", VA = "0x1807B0920")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7B1070", Offset = "0x7AFA70", VA = "0x1807B1070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x606AF50", Offset = "0x6069950", VA = "0x18606AF50")]
	public bool FLOHBAGDPJC(object FACMOGNGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x606B120", Offset = "0x6069B20", VA = "0x18606B120")]
	public bool NJHEJNEGCKN(object FACMOGNGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x606B0C0", Offset = "0x6069AC0", VA = "0x18606B0C0")]
	public bool NBEEIKJCOIK(object FACMOGNGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x606AED0", Offset = "0x60698D0", VA = "0x18606AED0")]
	public void AIINLGMCLCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x606B1C0", Offset = "0x6069BC0", VA = "0x18606B1C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public CIADAKDIJIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class IGLHFMCOLGL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private struct CDHAFMINFEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float GGACJIFFJPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public T NAJOFLHMBPO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly Dictionary<object, CDHAFMINFEA> PBLEFJPDFNN;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public virtual T BBNINFLHLFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xE56B50", Offset = "0xE55550", VA = "0x180E56B50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xE55550", Offset = "0xE53F50", VA = "0x180E55550", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public object? GKOLABDKGEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7A9100", Offset = "0x7A7B00", VA = "0x1807A9100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7AC280", Offset = "0x7AAC80", VA = "0x1807AC280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool GFBKHLIEAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x37D88D0", Offset = "0x37D72D0", VA = "0x1837D88D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x37D8210", Offset = "0x37D6C10", VA = "0x1837D8210")]
	public bool JCJIKHJCHHK(T FDFHGIHHGHO, object FACMOGNGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3716C90", Offset = "0x3715690", VA = "0x183716C90")]
	public bool KFIFCFIPLDK(object FACMOGNGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x37D88A0", Offset = "0x37D72A0", VA = "0x1837D88A0")]
	public void NJLBNDAIMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x37D85A0", Offset = "0x37D6FA0", VA = "0x1837D85A0")]
	public bool MFCFPLHBNLD(object FACMOGNGACN, [Out] T FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x37D66F0", Offset = "0x37D50F0", VA = "0x1837D66F0")]
	[FANKNDILCGJ("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool FHLDKHHAFIF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x37D8920", Offset = "0x37D7320", VA = "0x1837D8920")]
	public IGLHFMCOLGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface EGKEAENJJOD
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event DCAEKOCLCGM HLOOKCONAHB;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class MAADCOBIKJK : EGKEAENJJOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public readonly struct FIHAGGBJBAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public readonly float KDHLPBFNFLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public readonly float GJADLDCIGOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		internal readonly bool LIEFAHOJBOO;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float DPKBEHGMNCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x606B520", Offset = "0x6069F20", VA = "0x18606B520")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x606B690", Offset = "0x606A090", VA = "0x18606B690")]
		public FIHAGGBJBAC(float AJOMPGHNEBN, float HPBGGHHMELE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x606B530", Offset = "0x6069F30", VA = "0x18606B530", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class MBFDFFHPKCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public MAADCOBIKJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public MBFDFFHPKCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x606C9F0", Offset = "0x606B3F0", VA = "0x18606C9F0")]
		internal void CNDEADIMGJG(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly int NOOJMJOLDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private int PBBHPMNOFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly EGKEAENJJOD[] INAMJJBODMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly DCAEKOCLCGM[] CBKELGPMNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly FIHAGGBJBAC[] CPBDCLIHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private FIHAGGBJBAC MHLBLANIIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly INCDONFPCLI MHIMIIIPHAE;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event DCAEKOCLCGM HLOOKCONAHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x606C2A0", Offset = "0x606ACA0", VA = "0x18606C2A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x606C0D0", Offset = "0x606AAD0", VA = "0x18606C0D0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x606C860", Offset = "0x606B260", VA = "0x18606C860")]
	public MAADCOBIKJK(int NOOJMJOLDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x606C360", Offset = "0x606AD60", VA = "0x18606C360")]
	public INCDONFPCLI LLIKOEOMCOJ(FIHAGGBJBAC DNGHAFFBABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x606C3F0", Offset = "0x606ADF0", VA = "0x18606C3F0")]
	public void NOLFJJEBEJA(EGKEAENJJOD FCEKELPBNBM, [Optional] FIHAGGBJBAC JOPGGPBKNLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x606C190", Offset = "0x606AB90", VA = "0x18606C190", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public delegate void DCAEKOCLCGM(float GFGPAAAJMHA);
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class EPCKCHJNDOE
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private class BKIBAIBPDKG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly EGKEAENJJOD OKNCJBDPMLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly DCAEKOCLCGM DBIEPHLOFKD;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x606AD90", Offset = "0x6069790", VA = "0x18606AD90")]
		public BKIBAIBPDKG(EGKEAENJJOD OKNCJBDPMLE, DCAEKOCLCGM DBIEPHLOFKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x606AD40", Offset = "0x6069740", VA = "0x18606AD40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x606B4B0", Offset = "0x6069EB0", VA = "0x18606B4B0")]
	internal static bool OGLKKLEEOFI(float MAGGDEMNFDG, float LFCFPOEDJCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x605F410", Offset = "0x605DE10", VA = "0x18605F410")]
	internal static float MACAPJAECCG(float MAGGDEMNFDG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x606B3F0", Offset = "0x6069DF0", VA = "0x18606B3F0")]
	public static IDisposable KNLLGAEFNFP(this EGKEAENJJOD OKNCJBDPMLE, DCAEKOCLCGM DBIEPHLOFKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class INCDONFPCLI : EGKEAENJJOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private float GFGPAAAJMHA;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float AGCLJMPJOJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x606B980", Offset = "0x606A380", VA = "0x18606B980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event DCAEKOCLCGM? HLOOKCONAHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x606BA70", Offset = "0x606A470", VA = "0x18606BA70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x606B8E0", Offset = "0x606A2E0", VA = "0x18606B8E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public INCDONFPCLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class DAIAEPPEIAB : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5B56070", Offset = "0x5B54A70", VA = "0x185B56070")]
	public DAIAEPPEIAB(string DCKDMGKGDFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[DefaultMember("Item")]
public class CCFIPONGHOF<TKey, TValue> : DKPBAPHLFEE<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, CEFMKOMPDMH where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class BLFOGJOFPJJ : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public CCFIPONGHOF<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xE56B50", Offset = "0xE55550", VA = "0x180E56B50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x46634B0", Offset = "0x4661EB0", VA = "0x1846634B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
		[DebuggerHidden]
		public BLFOGJOFPJJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x34BE200", Offset = "0x34BCC00", VA = "0x1834BE200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x4662FE0", Offset = "0x46619E0", VA = "0x184662FE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x46626A0", Offset = "0x46610A0", VA = "0x1846626A0")]
		private void DHKGKCPFHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x46627E0", Offset = "0x46611E0", VA = "0x1846627E0")]
		private void GPHLLGKPILI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x4663460", Offset = "0x4661E60", VA = "0x184663460", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly DKPBAPHLFEE<TKey, TValue> EFJPJEKBCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly IDictionary<TKey, TValue> NOMCGCIBJBH;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int OICIIFDIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4859110", Offset = "0x4857B10", VA = "0x184859110", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool OAMNHFOMJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public TValue BFKPGKFLJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x48592E0", Offset = "0x4857CE0", VA = "0x1848592E0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4859540", Offset = "0x4857F40", VA = "0x184859540", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public ICollection<TKey> PHNAAMFGMLC
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4859320", Offset = "0x4857D20", VA = "0x184859320", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public ICollection<TValue> GIBFJBENMIN
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x4859430", Offset = "0x4857E30", VA = "0x184859430", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4858F90", Offset = "0x4857990", VA = "0x184858F90")]
	public CCFIPONGHOF(DKPBAPHLFEE<TKey, TValue> EFJPJEKBCBN, [Optional] IDictionary<TKey, TValue>? NOMCGCIBJBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4856C10", Offset = "0x4855610", VA = "0x184856C10", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x48574C0", Offset = "0x4855EC0", VA = "0x1848574C0")]
	public void DIPLPBAFIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4856370", Offset = "0x4854D70", VA = "0x184856370", Slot = "9")]
	public void Add(TKey KCGLPAPOILB, TValue FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4857830", Offset = "0x4856230", VA = "0x184857830")]
	public void KPIABGOFHIK(TKey KCGLPAPOILB, TValue FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4857AB0", Offset = "0x48564B0", VA = "0x184857AB0")]
	public void LGCDOAFMFIJ(TKey KCGLPAPOILB, TValue FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x4858100", Offset = "0x4856B00", VA = "0x184858100")]
	public void OOJKDGKDIKK(TKey KCGLPAPOILB, TValue FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4857CF0", Offset = "0x48566F0", VA = "0x184857CF0")]
	public void LKALFPFIHNL(TKey KCGLPAPOILB, TValue FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x48585D0", Offset = "0x4856FD0", VA = "0x1848585D0", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> ELCFHMHMPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x48587B0", Offset = "0x48571B0", VA = "0x1848587B0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> ELCFHMHMPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x4858970", Offset = "0x4857370", VA = "0x184858970", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> ELCFHMHMPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x4856C80", Offset = "0x4855680", VA = "0x184856C80", Slot = "8")]
	public bool ContainsKey(TKey KCGLPAPOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x4856890", Offset = "0x4855290", VA = "0x184856890")]
	public bool BOHJCNJKLMI(TKey KCGLPAPOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x4857630", Offset = "0x4856030", VA = "0x184857630")]
	public bool ICMGCLKFMJN(TKey KCGLPAPOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x4858340", Offset = "0x4856D40", VA = "0x184858340", Slot = "10")]
	public bool Remove(TKey KCGLPAPOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x4858D00", Offset = "0x4857700", VA = "0x184858D00", Slot = "11")]
	public bool TryGetValue(TKey KCGLPAPOILB, [Out] TValue FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4856DD0", Offset = "0x48557D0", VA = "0x184856DD0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] NIKMHLBDDHG, int HHFBBAINCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4858CD0", Offset = "0x48576D0", VA = "0x184858CD0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4857510", Offset = "0x4855F10", VA = "0x184857510", Slot = "19")]
	[IteratorStateMachine(typeof(CCFIPONGHOF<, >.BLFOGJOFPJJ))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4857DE0", Offset = "0x48567E0", VA = "0x184857DE0", Slot = "21")]
	public bool OBNDHDJALHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4856B10", Offset = "0x4855510", VA = "0x184856B10")]
	private TValue CEKONABIKIC(TKey KCGLPAPOILB)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface CEFMKOMPDMH
{
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OBNDHDJALHM();
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface DKPBAPHLFEE<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, CEFMKOMPDMH
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DefaultMember("Item")]
public sealed class MJLLEPHHJHI<TKey, TVal> : DKPBAPHLFEE<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, CEFMKOMPDMH where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public delegate int PPEICCCLIIN(TKey KCGLPAPOILB, TVal FDFHGIHHGHO);

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class ANHGFGMDIAF
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public TKey JFBDDAMOHDF
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xB644E0", Offset = "0xB62EE0", VA = "0x180B644E0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public TVal NAJOFLHMBPO
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x8C30C0", Offset = "0x8C1AC0", VA = "0x1808C30C0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x8C30D0", Offset = "0x8C1AD0", VA = "0x1808C30D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int DPKBEHGMNCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x7E68F0", Offset = "0x7E52F0", VA = "0x1807E68F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x7E6410", Offset = "0x7E4E10", VA = "0x1807E6410")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public DateTimeOffset OJGKNKOMDMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0xA29FF0", Offset = "0xA289F0", VA = "0x180A29FF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x1258390", Offset = "0x1256D90", VA = "0x181258390")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3721B40", Offset = "0x3720540", VA = "0x183721B40")]
		public ANHGFGMDIAF(TKey KCGLPAPOILB, TVal HHFKHHNHDLP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class AHKHAFHGIAM : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public MJLLEPHHJHI<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private LinkedList<ANHGFGMDIAF>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xE56B50", Offset = "0xE55550", VA = "0x180E56B50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x3680270", Offset = "0x367EC70", VA = "0x183680270", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
		[DebuggerHidden]
		public AHKHAFHGIAM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x34BA360", Offset = "0x34B8D60", VA = "0x1834BA360", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x367E6F0", Offset = "0x367D0F0", VA = "0x18367E6F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x367D930", Offset = "0x367C330", VA = "0x18367D930")]
		private void DHKGKCPFHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x367FFF0", Offset = "0x367E9F0", VA = "0x18367FFF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public const int KJCGGBEDEJN = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly Dictionary<TKey, LinkedListNode<ANHGFGMDIAF>> KBIEHEANPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly LinkedList<ANHGFGMDIAF> HDHLGFFPMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly PPEICCCLIIN? KGEHLPHHEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly TimeSpan ADGNMGBOHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly POIPBNPALLD LICENKOBCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private bool ODCLMHMKEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly List<TKey> DOFNDAJGDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly List<TVal> KEOBMCEINNH;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int GNOKEDLFEFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7C5410", Offset = "0x7C3E10", VA = "0x1807C5410")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	internal int JCNCHEMNGCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7C5420", Offset = "0x7C3E20", VA = "0x1807C5420")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xE4F010", Offset = "0xE4DA10", VA = "0x180E4F010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int OICIIFDIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x3DB88A0", Offset = "0x3DB72A0", VA = "0x183DB88A0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	internal int GIIBMGHCPFN
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3A99BB0", Offset = "0x3A985B0", VA = "0x183A99BB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public ICollection<TVal> GIBFJBENMIN
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x3DB89D0", Offset = "0x3DB73D0", VA = "0x183DB89D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	ICollection<TKey> IDictionary<TKey, TVal>.FIJEHJGNBGK
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x3DB50D0", Offset = "0x3DB3AD0", VA = "0x183DB50D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool OAMNHFOMJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public TVal BFKPGKFLJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x3DB8900", Offset = "0x3DB7300", VA = "0x183DB8900", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3DB8A60", Offset = "0x3DB7460", VA = "0x183DB8A60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3DB4340", Offset = "0x3DB2D40", VA = "0x183DB4340")]
	private bool PICIMKIPILE(int NOOJMJOLDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3DB1580", Offset = "0x3DAFF80", VA = "0x183DB1580")]
	private void GKKENCLOGAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3DB5E20", Offset = "0x3DB4820", VA = "0x183DB5E20")]
	public MJLLEPHHJHI(int NOOJMJOLDPD, [Optional] PPEICCCLIIN? KGEHLPHHEIL, [Optional] IEqualityComparer<TKey>? FJBNIHOMMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3DB60A0", Offset = "0x3DB4AA0", VA = "0x183DB60A0")]
	public MJLLEPHHJHI(TimeSpan ADGNMGBOHNA, [Optional] IEqualityComparer<TKey>? FJBNIHOMMJI, [Optional] POIPBNPALLD? LICENKOBCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3DB5FA0", Offset = "0x3DB49A0", VA = "0x183DB5FA0")]
	public MJLLEPHHJHI(int NOOJMJOLDPD, TimeSpan ADGNMGBOHNA, [Optional] IEqualityComparer<TKey>? FJBNIHOMMJI, [Optional] POIPBNPALLD? LICENKOBCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3DB7320", Offset = "0x3DB5D20", VA = "0x183DB7320")]
	public MJLLEPHHJHI(int NOOJMJOLDPD, PPEICCCLIIN? KGEHLPHHEIL, TimeSpan ADGNMGBOHNA, [Optional] IEqualityComparer<TKey>? FJBNIHOMMJI, [Optional] POIPBNPALLD? LICENKOBCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3DB42D0", Offset = "0x3DB2CD0", VA = "0x183DB42D0", Slot = "21")]
	public bool OBNDHDJALHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3DB2110", Offset = "0x3DB0B10", VA = "0x183DB2110", Slot = "22")]
	public bool HHIKCDPOOFP(int BFFGCOIILMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3DA9AD0", Offset = "0x3DA84D0", VA = "0x183DA9AD0")]
	private bool AJDLKIKFEFE(int BFFGCOIILMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3DAB320", Offset = "0x3DA9D20", VA = "0x183DAB320")]
	public void BDBEANEDBLI(TKey KCGLPAPOILB, TVal FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3DAA9A0", Offset = "0x3DA93A0", VA = "0x183DAA9A0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> ELCFHMHMPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3DAACD0", Offset = "0x3DA96D0", VA = "0x183DAACD0", Slot = "9")]
	public void Add(TKey KCGLPAPOILB, TVal FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3DAC8D0", Offset = "0x3DAB2D0", VA = "0x183DAC8D0", Slot = "8")]
	public bool ContainsKey(TKey KCGLPAPOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3DB4650", Offset = "0x3DB3050", VA = "0x183DB4650", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> ELCFHMHMPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3DB4400", Offset = "0x3DB2E00", VA = "0x183DB4400", Slot = "10")]
	public bool Remove(TKey KCGLPAPOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3DB4D60", Offset = "0x3DB3760", VA = "0x183DB4D60", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> ELCFHMHMPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3DA95A0", Offset = "0x3DA7FA0", VA = "0x183DA95A0")]
	private bool AADKCBDLBJK(TKey KCGLPAPOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3DB3FF0", Offset = "0x3DB29F0", VA = "0x183DB3FF0")]
	private TVal JNDPLHMHPON(TKey JLHAOFBOAMO)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3DB5840", Offset = "0x3DB4240", VA = "0x183DB5840", Slot = "11")]
	public bool TryGetValue(TKey JLHAOFBOAMO, [Out] TVal FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3DAC7A0", Offset = "0x3DAB1A0", VA = "0x183DAC7A0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3DADDD0", Offset = "0x3DAC7D0", VA = "0x183DADDD0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] NIKMHLBDDHG, int HHFBBAINCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x3DB0B00", Offset = "0x3DAF500", VA = "0x183DB0B00")]
	private bool EGDEIKFHJDG(ANHGFGMDIAF LFFHAICKOJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3DAE7B0", Offset = "0x3DAD1B0", VA = "0x183DAE7B0")]
	private void EBJFHKGJJBB(LinkedListNode<ANHGFGMDIAF> KOHJGJBKPIF, TVal AIIPFNKEHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3DB2C60", Offset = "0x3DB1660", VA = "0x183DB2C60")]
	private void JCJIKHJCHHK(TKey KCGLPAPOILB, TVal FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3DAC200", Offset = "0x3DAAC00", VA = "0x183DAC200")]
	private void BHJGGAGKGAG(ANHGFGMDIAF LFFHAICKOJM, TVal AIIPFNKEHOL, int FFHOJDHOGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3DB1A60", Offset = "0x3DB0460", VA = "0x183DB1A60", Slot = "19")]
	[IteratorStateMachine(typeof(MJLLEPHHJHI<, >.AHKHAFHGIAM))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3DB5100", Offset = "0x3DB3B00", VA = "0x183DB5100", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class BLIICMKNCDA<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class BJEAKCMLBNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public BLIICMKNCDA<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public BJEAKCMLBNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x464DE80", Offset = "0x464C880", VA = "0x18464DE80")]
		internal Task<TResource> MBGNNGIBCNN(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct AIHAIAGNOBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3684B00", Offset = "0x3683500", VA = "0x183684B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3684EE0", Offset = "0x36838E0", VA = "0x183684EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct FCAKMHHOOCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Action<TResource> cleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x35A0240", Offset = "0x359EC40", VA = "0x1835A0240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x35A0700", Offset = "0x359F100", VA = "0x1835A0700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly KLNFOPBEMME<TId, Task<TResource>> MLMOPCBIHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> HFMECHOJFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? OKOGJPMAIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Action<TResource>? FOIEOEEAEFG;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x4665200", Offset = "0x4663C00", VA = "0x184665200")]
	public BLIICMKNCDA(int GJODBLAILPJ = 0, [Optional] IEqualityComparer<TId>? CLDGIOLDPBJ, [Optional] Func<TId, CancellationToken, Task<TResource>>? ACHLACIFFGN, [Optional] Action<TResource>? BPIHDLJOLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x4664640", Offset = "0x4663040", VA = "0x184664640")]
	public DKOAJFJKKBO<Task<TResource>> CHLPPFFEBAE(TId PDDHPPHOJPD, [Optional] Func<TId, CancellationToken, Task<TResource>>? ACHLACIFFGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x4664E10", Offset = "0x4663810", VA = "0x184664E10")]
	private void OILCGOGDJGI(Task<TResource> CKAKCFLCDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x4664CD0", Offset = "0x46636D0", VA = "0x184664CD0")]
	public void MMNBAHCLFKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x4664BF0", Offset = "0x46635F0", VA = "0x184664BF0")]
	public KLNFOPBEMME<TId, Task<TResource>>.MIICNLNGJIG MFONJKCHJIL()
	{
		return default(KLNFOPBEMME<TId, Task<TResource>>.MIICNLNGJIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x46650D0", Offset = "0x4663AD0", VA = "0x1846650D0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x46650D0", Offset = "0x4663AD0", VA = "0x1846650D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x4664920", Offset = "0x4663320", VA = "0x184664920")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(BLIICMKNCDA<, >.AIHAIAGNOBM))]
	internal static Task FNIKEGKGNFJ(Task<TResource> CKAKCFLCDJK, CancellationTokenSource MDMFFOLEAMP, Dictionary<Task<TResource>, CancellationTokenSource> ALBJJABJKGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x46640C0", Offset = "0x4662AC0", VA = "0x1846640C0")]
	[AsyncStateMachine(typeof(BLIICMKNCDA<, >.FCAKMHHOOCC))]
	[CompilerGenerated]
	internal static Task BNKCMNADABB(Task<TResource> CKAKCFLCDJK, Action<TResource> NKPJBBBDDPM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class KLNFOPBEMME<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private sealed class OPNHEAJGAOB : IEquatable<OPNHEAJGAOB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public readonly TValue NAJOFLHMBPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int OFLNCFGJKJB;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x1BDF370", Offset = "0x1BDDD70", VA = "0x181BDF370")]
		public OPNHEAJGAOB(TValue FDFHGIHHGHO, int PNJDIDJFDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3F38450", Offset = "0x3F36E50", VA = "0x183F38450", Slot = "4")]
		public bool Equals(OPNHEAJGAOB? AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3F384E0", Offset = "0x3F36EE0", VA = "0x183F384E0", Slot = "0")]
		public override bool Equals(object? MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3F38610", Offset = "0x3F37010", VA = "0x183F38610", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct MIICNLNGJIG : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private Dictionary<TKey, OPNHEAJGAOB>.Enumerator ECGFDGFLICA;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x3D9E980", Offset = "0x3D9D380", VA = "0x183D9E980", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public (TKey Key, TValue Value, int RefCount) FPOHGHGPMEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x3D9ED20", Offset = "0x3D9D720", VA = "0x183D9ED20", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3D9EAD0", Offset = "0x3D9D4D0", VA = "0x183D9EAD0")]
		public MIICNLNGJIG(KLNFOPBEMME<TKey, TValue> PBLEFJPDFNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E5D0", Offset = "0x3D9CFD0", VA = "0x183D9E5D0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E650", Offset = "0x3D9D050", VA = "0x183D9E650", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E780", Offset = "0x3D9D180", VA = "0x183D9E780", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class PGEMNMEMJAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public KLNFOPBEMME<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public OPNHEAJGAOB refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public PGEMNMEMJAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3FDC980", Offset = "0x3FDB380", VA = "0x183FDC980")]
		internal void MBGNNGIBCNN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<TKey, OPNHEAJGAOB> KOJBKBMPOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Func<TKey, TValue>? IOAOOPLKBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly Action<TValue>? BDCJFFKPDAA;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3AC4410", Offset = "0x3AC2E10", VA = "0x183AC4410")]
	public KLNFOPBEMME(int GJODBLAILPJ = 0, [Optional] IEqualityComparer<TKey>? FJBNIHOMMJI, [Optional] Func<TKey, TValue>? EFLMEFDEHPC, [Optional] Action<TValue>? HOJJAHGBEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3AC3360", Offset = "0x3AC1D60", VA = "0x183AC3360")]
	public DKOAJFJKKBO<TValue> CHLPPFFEBAE(TKey KCGLPAPOILB, [Optional] Func<TKey, TValue>? JIFPACEMJBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3AC3AD0", Offset = "0x3AC24D0", VA = "0x183AC3AD0")]
	private void FLLAKBFBGHI(TKey KCGLPAPOILB, OPNHEAJGAOB FAPEJKPMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3AC3C90", Offset = "0x3AC2690", VA = "0x183AC3C90")]
	public void MMNBAHCLFKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3AC3C50", Offset = "0x3AC2650", VA = "0x183AC3C50")]
	public MIICNLNGJIG MFONJKCHJIL()
	{
		return default(MIICNLNGJIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3AC4240", Offset = "0x3AC2C40", VA = "0x183AC4240", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3AC4240", Offset = "0x3AC2C40", VA = "0x183AC4240", Slot = "5")]
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
