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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D7A720", Offset = "0x7D78D20", VA = "0x187D7A720")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA154F0", Offset = "0xA13AF0", VA = "0x180A154F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA15530", Offset = "0xA13B30", VA = "0x180A15530")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class JFHDDOPKNCA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	protected JFHDDOPKNCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HEGMOBKPOIK<T> : JFHDDOPKNCA
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct EFAMHFJOPLM
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum OKDOJDLDCNE
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
		public OKDOJDLDCNE MLCOGCMJLBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T BDCLNIJAFBF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int HMICDCMMGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool EPCOADLJBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool GBDKBBOCIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? NCGJKAINIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<EFAMHFJOPLM>? GHBKIIDLIBB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool BNPOHGOKMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4B09C70", Offset = "0x4B08270", VA = "0x184B09C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4B09CD0", Offset = "0x4B082D0", VA = "0x184B09CD0")]
	protected HEGMOBKPOIK(bool GBDKBBOCIEP, bool EPCOADLJBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4B09BD0", Offset = "0x4B081D0", VA = "0x184B09BD0")]
	protected bool OIALEDAJPOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4B092B0", Offset = "0x4B078B0", VA = "0x184B092B0")]
	protected void BCBLPKEFPEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4B09960", Offset = "0x4B07F60", VA = "0x184B09960")]
	protected void NFGGBJAOIAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3CB5A10", Offset = "0x3CB4010", VA = "0x183CB5A10")]
	private static void GMKMJFDBJAG<U>(List<U>? OLEDHEBBJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4B095A0", Offset = "0x4B07BA0", VA = "0x184B095A0", Slot = "4")]
	public void IIGLPCDPOEE(T BDCLNIJAFBF, bool IDMJGPAKIGN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4B093D0", Offset = "0x4B079D0", VA = "0x184B093D0", Slot = "5")]
	public void GNAALOCCJEL(T BDCLNIJAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4B097B0", Offset = "0x4B07DB0", VA = "0x184B097B0")]
	public void INBDHNEFJBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class GCADBNOOJOM : HEGMOBKPOIK<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7D78CB0", Offset = "0x7D772B0", VA = "0x187D78CB0")]
	public GCADBNOOJOM(bool GBDKBBOCIEP = false, bool EPCOADLJBNM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7D789F0", Offset = "0x7D76FF0", VA = "0x187D789F0")]
	public void CIBKKMOJDEC()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7D78C50", Offset = "0x7D77250", VA = "0x187D78C50")]
	public static GCADBNOOJOM MBKCEPDOHAP(GCADBNOOJOM KILBJIGPBMG, Action BDCLNIJAFBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7D78BF0", Offset = "0x7D771F0", VA = "0x187D78BF0")]
	public static GCADBNOOJOM KGEEBEJGEIG(GCADBNOOJOM KILBJIGPBMG, Action BDCLNIJAFBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KLMHCJNNIPO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIGLPCDPOEE(Action<T> BDCLNIJAFBF, bool IDMJGPAKIGN = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GNAALOCCJEL(Action<T> BDCLNIJAFBF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class NPNKPOOAOFG<T> : HEGMOBKPOIK<Action<T>>, KLMHCJNNIPO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4526E80", Offset = "0x4525480", VA = "0x184526E80")]
	public NPNKPOOAOFG(bool GBDKBBOCIEP = false, bool EPCOADLJBNM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5426A20", Offset = "0x5425020", VA = "0x185426A20")]
	public void CIBKKMOJDEC(T LEMBKBGMCDG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4B528A0", Offset = "0x4B50EA0", VA = "0x184B528A0")]
	public static NPNKPOOAOFG<T> MBKCEPDOHAP(NPNKPOOAOFG<T> KILBJIGPBMG, Action<T> BDCLNIJAFBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4B52800", Offset = "0x4B50E00", VA = "0x184B52800")]
	public static NPNKPOOAOFG<T> KGEEBEJGEIG(NPNKPOOAOFG<T> KILBJIGPBMG, Action<T> BDCLNIJAFBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DAGLKFFOOFC<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIGLPCDPOEE(Action<T, U> BDCLNIJAFBF, bool IDMJGPAKIGN = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GNAALOCCJEL(Action<T, U> BDCLNIJAFBF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class KICNHCAEGMA<T, U> : HEGMOBKPOIK<Action<T, U>>, DAGLKFFOOFC<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4526E80", Offset = "0x4525480", VA = "0x184526E80")]
	public KICNHCAEGMA(bool GBDKBBOCIEP = false, bool EPCOADLJBNM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x500B550", Offset = "0x5009B50", VA = "0x18500B550")]
	public void CIBKKMOJDEC(T LEMBKBGMCDG, U LHJOAJGMHHO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4B528A0", Offset = "0x4B50EA0", VA = "0x184B528A0")]
	public static KICNHCAEGMA<T, U> MBKCEPDOHAP(KICNHCAEGMA<T, U> KILBJIGPBMG, Action<T, U> BDCLNIJAFBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4B52800", Offset = "0x4B50E00", VA = "0x184B52800")]
	public static KICNHCAEGMA<T, U> KGEEBEJGEIG(KICNHCAEGMA<T, U> KILBJIGPBMG, Action<T, U> BDCLNIJAFBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class MOHJIJKGENJ<T, U, V> : HEGMOBKPOIK<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4526E80", Offset = "0x4525480", VA = "0x184526E80")]
	public MOHJIJKGENJ(bool GBDKBBOCIEP = false, bool EPCOADLJBNM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x537E120", Offset = "0x537C720", VA = "0x18537E120")]
	public void CIBKKMOJDEC(T LEMBKBGMCDG, U LHJOAJGMHHO, V IINHKHEMEHJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4B528A0", Offset = "0x4B50EA0", VA = "0x184B528A0")]
	public static MOHJIJKGENJ<T, U, V> MBKCEPDOHAP(MOHJIJKGENJ<T, U, V> KILBJIGPBMG, Action<T, U, V> BDCLNIJAFBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4B52800", Offset = "0x4B50E00", VA = "0x184B52800")]
	public static MOHJIJKGENJ<T, U, V> KGEEBEJGEIG(MOHJIJKGENJ<T, U, V> KILBJIGPBMG, Action<T, U, V> BDCLNIJAFBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BGMFNFBPHPN<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class HLMBLDJFCGB<T, U, V, W> : HEGMOBKPOIK<Action<T, U, V, W>>, BGMFNFBPHPN<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4526E80", Offset = "0x4525480", VA = "0x184526E80")]
	public HLMBLDJFCGB(bool GBDKBBOCIEP = false, bool EPCOADLJBNM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4B603D0", Offset = "0x4B5E9D0", VA = "0x184B603D0")]
	public void CIBKKMOJDEC(T LEMBKBGMCDG, U LHJOAJGMHHO, V IINHKHEMEHJ, W NJMPEFLBAHN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4B528A0", Offset = "0x4B50EA0", VA = "0x184B528A0")]
	public static HLMBLDJFCGB<T, U, V, W> MBKCEPDOHAP(HLMBLDJFCGB<T, U, V, W> KILBJIGPBMG, Action<T, U, V, W> BDCLNIJAFBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4B52800", Offset = "0x4B50E00", VA = "0x184B52800")]
	public static HLMBLDJFCGB<T, U, V, W> KGEEBEJGEIG(HLMBLDJFCGB<T, U, V, W> KILBJIGPBMG, Action<T, U, V, W> BDCLNIJAFBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class MKICKDDDNKK<T, U, V, W, X> : HEGMOBKPOIK<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4526E80", Offset = "0x4525480", VA = "0x184526E80")]
	public MKICKDDDNKK(bool GBDKBBOCIEP = false, bool EPCOADLJBNM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5362DF0", Offset = "0x53613F0", VA = "0x185362DF0")]
	public void CIBKKMOJDEC(T LEMBKBGMCDG, U LHJOAJGMHHO, V IINHKHEMEHJ, W NJMPEFLBAHN, X CEJAAIDLEPA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4B528A0", Offset = "0x4B50EA0", VA = "0x184B528A0")]
	public static MKICKDDDNKK<T, U, V, W, X> MBKCEPDOHAP(MKICKDDDNKK<T, U, V, W, X> KILBJIGPBMG, Action<T, U, V, W, X> BDCLNIJAFBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4B52800", Offset = "0x4B50E00", VA = "0x184B52800")]
	public static MKICKDDDNKK<T, U, V, W, X> KGEEBEJGEIG(MKICKDDDNKK<T, U, V, W, X> KILBJIGPBMG, Action<T, U, V, W, X> BDCLNIJAFBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class HIILDAAMMBI<T, U, V, W, X, Y> : HEGMOBKPOIK<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4526E80", Offset = "0x4525480", VA = "0x184526E80")]
	public HIILDAAMMBI(bool GBDKBBOCIEP = false, bool EPCOADLJBNM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4B52070", Offset = "0x4B50670", VA = "0x184B52070")]
	public void CIBKKMOJDEC(T LEMBKBGMCDG, U LHJOAJGMHHO, V IINHKHEMEHJ, W NJMPEFLBAHN, X CEJAAIDLEPA, Y IMNDAJIDDFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4B528A0", Offset = "0x4B50EA0", VA = "0x184B528A0")]
	public static HIILDAAMMBI<T, U, V, W, X, Y> MBKCEPDOHAP(HIILDAAMMBI<T, U, V, W, X, Y> KILBJIGPBMG, Action<T, U, V, W, X, Y> BDCLNIJAFBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4B52800", Offset = "0x4B50E00", VA = "0x184B52800")]
	public static HIILDAAMMBI<T, U, V, W, X, Y> KGEEBEJGEIG(HIILDAAMMBI<T, U, V, W, X, Y> KILBJIGPBMG, Action<T, U, V, W, X, Y> BDCLNIJAFBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class OJBCGPDKLFC<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly FAKLKHOBCAF<TKey, TVal> GHJGKIPJDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> GKPKHDGCNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly FAKLKHOBCAF<TKey, TVal>.JCNIAMJACJF? AJBEMMOIIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int AIFBGODJJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly FAKLKHOBCAF<TKey, TVal>.KLHIIMGJNAN? NEIBHEBGDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int NMMMMLEDBKP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int OHDAOPOFPHC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x553FDF0", Offset = "0x553E3F0", VA = "0x18553FDF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int EFJAAKPECFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9EAC90", Offset = "0x9E9290", VA = "0x1809EAC90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x55400A0", Offset = "0x553E6A0", VA = "0x1855400A0")]
	public OJBCGPDKLFC(int AIFBGODJJLK, [Optional] FAKLKHOBCAF<TKey, TVal>.KLHIIMGJNAN? NEIBHEBGDCA, [Optional] IEqualityComparer<TKey>? FHGJDKOPHBN, [Optional] FAKLKHOBCAF<TKey, TVal>.JCNIAMJACJF? AJBEMMOIIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x553F910", Offset = "0x553DF10", VA = "0x18553F910")]
	public void LBJDJBEFMLC(TKey OEHHKNIGGMI, TVal OHLIHBDBKCE, bool JBBLDBKEMGA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x553F700", Offset = "0x553DD00", VA = "0x18553F700")]
	public bool IKMEICODLOF(TKey OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x553FB40", Offset = "0x553E140", VA = "0x18553FB40")]
	public bool LKMKPGKLGLC(TKey KBMOAEOFKJM, [Out] TVal OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x553EDB0", Offset = "0x553D3B0", VA = "0x18553EDB0")]
	private void ECJNKKFALMD(TKey OEHHKNIGGMI, TVal OHLIHBDBKCE, int CFNMLMNHCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x553FC40", Offset = "0x553E240", VA = "0x18553FC40")]
	public bool OCDGKMPDGED(TKey OEHHKNIGGMI, TVal OHLIHBDBKCE, bool JBBLDBKEMGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x553F860", Offset = "0x553DE60", VA = "0x18553F860")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x553F1A0", Offset = "0x553D7A0", VA = "0x18553F1A0")]
	private void HFBJGNADKGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x553FF60", Offset = "0x553E560", VA = "0x18553FF60")]
	private bool PMGBCNDKKAC(TKey OEHHKNIGGMI, AKOFMBHIPNP DKBCGBFNIGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x553FE40", Offset = "0x553E440", VA = "0x18553FE40")]
	private void PJLIGHBCKMB(TKey OEHHKNIGGMI, TVal OHLIHBDBKCE, AKOFMBHIPNP DKBCGBFNIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x553F070", Offset = "0x553D670", VA = "0x18553F070")]
	private void FKAKKEJCDGG(TKey OEHHKNIGGMI, TVal GCDAJLDGOIF, AKOFMBHIPNP DKBCGBFNIGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FDIIDDCLBHF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action EJKMLLMKNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool EFFCLIFCPEK;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	public FDIIDDCLBHF(Action AAMIKNLELJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7D789B0", Offset = "0x7D76FB0", VA = "0x187D789B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x37041B0", Offset = "0x37027B0", VA = "0x1837041B0")]
	public static CLCFAKNAJCK<T> FLLMCNLHKNL<T>(T OHLIHBDBKCE, Action AAMIKNLELJB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class CLCFAKNAJCK<T> : FDIIDDCLBHF where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x67D4460", Offset = "0x67D2A60", VA = "0x1867D4460")]
	public CLCFAKNAJCK(T OHLIHBDBKCE, Action AAMIKNLELJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class MKFFIMPEBDB<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly MJBGFHIEDKK<T>? HDCGOOAKBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> LNGMBMDPJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool EFFCLIFCPEK;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly MKFFIMPEBDB<T> KKKNNENCOAG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> GHONMMDKFFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5361FE0", Offset = "0x53605E0", VA = "0x185361FE0")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long JPLLFCIDPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5361EA0", Offset = "0x53604A0", VA = "0x185361EA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool NOJJAOAIMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5362240", Offset = "0x5360840", VA = "0x185362240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x53624E0", Offset = "0x5360AE0", VA = "0x1853624E0")]
	public MKFFIMPEBDB(MJBGFHIEDKK<T> NONNEFPCKAH, MJBGFHIEDKK<T> LPLGOCAEONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x53625D0", Offset = "0x5360BD0", VA = "0x1853625D0")]
	public MKFFIMPEBDB(MJBGFHIEDKK<T> NONNEFPCKAH, int NGFMNKONPKM, MJBGFHIEDKK<T> LPLGOCAEONJ, int AHEINAHGGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5362440", Offset = "0x5360A40", VA = "0x185362440")]
	private MKFFIMPEBDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5361BF0", Offset = "0x53601F0", VA = "0x185361BF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5361D30", Offset = "0x5360330", VA = "0x185361D30")]
	public T[] HGAAFLBNLDD()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5362060", Offset = "0x5360660", VA = "0x185362060")]
	public static ReadOnlySequence<T> OIFHDJNIHDL(MKFFIMPEBDB<T>? NFKNDNEHMAF)
	{
		return default(ReadOnlySequence<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JHGAEEHEAGF<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly IDisposable LIFEMEGPEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public T FPGFCMMHMJG;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4E7E320", Offset = "0x4E7C920", VA = "0x184E7E320")]
	public JHGAEEHEAGF(IDisposable AMICCGMJHBK, [In] T OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3DFAD90", Offset = "0x3DF9390", VA = "0x183DFAD90")]
	public static JHGAEEHEAGF<U> FOPBGEEEGFF<U>([In] JHGAEEHEAGF<T> AMICCGMJHBK, [In] U OHLIHBDBKCE) where U : notnull
	{
		return default(JHGAEEHEAGF<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4E7E1A0", Offset = "0x4E7C7A0", VA = "0x184E7E1A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class KLPMJEMCNIL
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x39110B0", Offset = "0x390F6B0", VA = "0x1839110B0")]
	public static JHGAEEHEAGF<T> ACADPGMDEBE<T>(IDisposable AMICCGMJHBK, [In] T OHLIHBDBKCE) where T : notnull
	{
		return default(JHGAEEHEAGF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3911110", Offset = "0x390F710", VA = "0x183911110")]
	public static JHGAEEHEAGF<T> ILKKFEDAJIM<T>([In] this JHGAEEHEAGF<T> OCACDKEJIIB, [Out] T OHLIHBDBKCE) where T : notnull
	{
		return default(JHGAEEHEAGF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x38641B0", Offset = "0x38627B0", VA = "0x1838641B0")]
	public static JHGAEEHEAGF<U?> FOPBGEEEGFF<U, T>([In] JHGAEEHEAGF<T> HEEGIENOAML, [In] U OHLIHBDBKCE)
	{
		return default(JHGAEEHEAGF<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct JMJECAHGFJF : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct OOEEFBGALEM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0")]
		public static OOEEFBGALEM ACADPGMDEBE()
		{
			return default(OOEEFBGALEM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A3B0", Offset = "0x7D789B0", VA = "0x187D7A3B0")]
	public static string NKGFJDCBDOP(Type MLCOGCMJLBB, [Optional] string? LIICCBEIELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x38D2C80", Offset = "0x38D1280", VA = "0x1838D2C80")]
	public static string? NKGFJDCBDOP<T>([Optional] string? LIICCBEIELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x38D2C00", Offset = "0x38D1200", VA = "0x1838D2C00")]
	public static string? FFAACAIGAAI<T>([Optional] string? HEKGBLOGOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0")]
	public static JMJECAHGFJF ECGNHAOMACM(string LIICCBEIELN, string? HEKGBLOGOAJ)
	{
		return default(JMJECAHGFJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FDEEMEDLPLM
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate bool NKAFBHPOBJG(string BCGNBDHPFAB, FDEEMEDLPLM KHJOHHNPGEF);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class PPLBEDLCPHL<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public PPLBEDLCPHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x563DAD0", Offset = "0x563C0D0", VA = "0x18563DAD0")]
		internal void AKAEMFDNHEA(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public int PCHMHBNEGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public string LAADEINHGNK;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7D78680", Offset = "0x7D76C80", VA = "0x187D78680")]
	public static Dictionary<string, FDEEMEDLPLM> PECHGHAKADN(Type NNODEEMKOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x38597F0", Offset = "0x3857DF0", VA = "0x1838597F0")]
	public static Dictionary<string, FDEEMEDLPLM> PECHGHAKADN<T>(Type NNODEEMKOHL, IReadOnlyDictionary<T, string> FDLMALDJBJC) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3859070", Offset = "0x3857670", VA = "0x183859070")]
	public static Dictionary<string, FDEEMEDLPLM> PEAIEMIPFCO<T>(List<T> DCOMGCLLLJH) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7D78110", Offset = "0x7D76710", VA = "0x187D78110")]
	public static Dictionary<string, FDEEMEDLPLM> ADEIBIBOBJO(Type NNODEEMKOHL, NKAFBHPOBJG JCDOOGJLMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7D784C0", Offset = "0x7D76AC0", VA = "0x187D784C0")]
	public static Dictionary<int, string> MPEDEGPAHNM(Dictionary<string, FDEEMEDLPLM> NEKLMLONNIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class OGMCLKGLBPG : HIKDGBNCNDJ
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool DMICDGLJIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly string? KIEGCLLKGDI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual HIKDGBNCNDJ? GCEONJBMONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7D7AE40", Offset = "0x7D79440", VA = "0x187D7AE40")]
	protected OGMCLKGLBPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string JJNMHFCAPPI();

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7D7AD60", Offset = "0x7D79360", VA = "0x187D7AD60", Slot = "8")]
	public virtual string LAFICHOHNKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A8C0", Offset = "0x7D78EC0", VA = "0x187D7A8C0", Slot = "9")]
	public void FFGOBIKMION(StringBuilder ALFALFBMDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7D7ADE0", Offset = "0x7D793E0", VA = "0x187D7ADE0", Slot = "10")]
	public void PIODEBNCGLK(StringBuilder ALFALFBMDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A7A0", Offset = "0x7D78DA0", VA = "0x187D7A7A0", Slot = "11")]
	public void EPFIIKONCKM(StringBuilder ALFALFBMDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7D7AB60", Offset = "0x7D79160", VA = "0x187D7AB60", Slot = "12")]
	public void JNFCACILNFO(StringBuilder ALFALFBMDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7D7ACC0", Offset = "0x7D792C0", VA = "0x187D7ACC0")]
	public static void KPHNFFIJJJG(StringBuilder ALFALFBMDFN, string PAGMGOCFAHK, string HIDHHAGFBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6D19C90", Offset = "0x6D18290", VA = "0x186D19C90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KPDHCCFLFIE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A3F0", Offset = "0x7D789F0", VA = "0x187D7A3F0")]
	public KPDHCCFLFIE(string NAAMEAFIHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NPPCJGJKOCK<TErr> : KPDHCCFLFIE where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly TErr OBCANBDNECG;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5429680", Offset = "0x5427C80", VA = "0x185429680")]
	private NPPCJGJKOCK([In] TErr AOGJMPFJDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x54295B0", Offset = "0x5427BB0", VA = "0x1854295B0")]
	public static NPPCJGJKOCK<TErr> ACADPGMDEBE([In] TErr AOGJMPFJDNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class IKPLMGJILOL : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashAlgorithm EIPAPECJLEB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool NCIPIFCEDNM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool ICGOFMOJEOP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool KHGELGKDEHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long JPLLFCIDPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7D79BC0", Offset = "0x7D781C0", VA = "0x187D79BC0", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long MJJFMHOFJKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7D79C30", Offset = "0x7D78230", VA = "0x187D79C30", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7D79CA0", Offset = "0x7D782A0", VA = "0x187D79CA0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7D79B50", Offset = "0x7D78150", VA = "0x187D79B50")]
	public IKPLMGJILOL(HashAlgorithm EIPAPECJLEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7D79980", Offset = "0x7D77F80", VA = "0x187D79980", Slot = "35")]
	public override int Read(byte[] IIGKBHIENFB, int LLPAIMMACAP, int JAALIADHHOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7D79B20", Offset = "0x7D78120", VA = "0x187D79B20", Slot = "38")]
	public override void Write(byte[] IIGKBHIENFB, int LLPAIMMACAP, int JAALIADHHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7D79A20", Offset = "0x7D78020", VA = "0x187D79A20", Slot = "33")]
	public override long Seek(long LLPAIMMACAP, SeekOrigin CKOFKNABLLG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7D79AB0", Offset = "0x7D780B0", VA = "0x187D79AB0", Slot = "34")]
	public override void SetLength(long OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7D798B0", Offset = "0x7D77EB0", VA = "0x187D798B0")]
	public byte[] KLJNHBBKJDH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface HIKDGBNCNDJ
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LAFICHOHNKA();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string JJNMHFCAPPI();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface ILKBOCNMCLO<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface OENMMKCDPOM
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string PLILPCAPEHL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class MJBGFHIEDKK<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static MJBGFHIEDKK<T>? JDAKPBFJMEK;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static object KCEKFIELLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private IMemoryOwner<T>? NPCCDIGOBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool EFFCLIFCPEK;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool NAKOJHKEHHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xD81E20", Offset = "0xD80420", VA = "0x180D81E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x535F440", Offset = "0x535DA40", VA = "0x18535F440")]
	private static MJBGFHIEDKK<T> EBAFJGJIHPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x535E850", Offset = "0x535CE50", VA = "0x18535E850")]
	private static void BPLFDIAOGPN(MJBGFHIEDKK<T> BPNOFBAMPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4520960", Offset = "0x451EF60", VA = "0x184520960")]
	private MJBGFHIEDKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x535FB00", Offset = "0x535E100", VA = "0x18535FB00")]
	public static MJBGFHIEDKK<T> FLLMCNLHKNL(ReadOnlyMemory<T> OAEJJMIBANF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x535F8F0", Offset = "0x535DEF0", VA = "0x18535F8F0")]
	public static MJBGFHIEDKK<T> FLLMCNLHKNL(IMemoryOwner<T> GAHFIFKEICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x535EE00", Offset = "0x535D400", VA = "0x18535EE00")]
	public static void COLGLDDMJEE(MJBGFHIEDKK<T> NONNEFPCKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x535EF40", Offset = "0x535D540", VA = "0x18535EF40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x535FEA0", Offset = "0x535E4A0", VA = "0x18535FEA0")]
	public MJBGFHIEDKK<T> FMLNAEFDMPJ(IMemoryOwner<T> GAHFIFKEICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5360200", Offset = "0x535E800", VA = "0x185360200")]
	private void PAIAEEJDMAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x535FFB0", Offset = "0x535E5B0", VA = "0x18535FFB0")]
	private MJBGFHIEDKK<T> IDAJACLFNNI(MJBGFHIEDKK<T> BPNOFBAMPIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class PIAPGKAGFDI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7D7B4D0", Offset = "0x7D79AD0", VA = "0x187D7B4D0")]
	public PIAPGKAGFDI(string NAAMEAFIHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class PMGDGEJFJKC<TOk> : PIAPGKAGFDI where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TOk IIJKJPIHGDF;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5633B20", Offset = "0x5632120", VA = "0x185633B20")]
	private PMGDGEJFJKC([In] TOk FHBBHJHMBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4ACF740", Offset = "0x4ACDD40", VA = "0x184ACF740")]
	public static PMGDGEJFJKC<TOk> ACADPGMDEBE([In] TOk FHBBHJHMBGK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct HHHCCNLMPJL<TOk, TErr> : IEquatable<HHHCCNLMPJL<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly EqualityComparer<TErr> DBFKNAFIDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal readonly TErr OBCANBDNECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal readonly TOk IIJKJPIHGDF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool OMIAEGIJGIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4B1C570", Offset = "0x4B1AB70", VA = "0x184B1C570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool JKFIBANKCFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4B16A60", Offset = "0x4B15060", VA = "0x184B16A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4B20500", Offset = "0x4B1EB00", VA = "0x184B20500")]
	internal HHHCCNLMPJL([In] TErr AOGJMPFJDNP, [In] TOk FHBBHJHMBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4B1A010", Offset = "0x4B18610", VA = "0x184B1A010")]
	public static HHHCCNLMPJL<TOk, TErr> KEIFJFJMJIE([In] TErr AOGJMPFJDNP)
	{
		return default(HHHCCNLMPJL<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4B1A6B0", Offset = "0x4B18CB0", VA = "0x184B1A6B0")]
	public static HHHCCNLMPJL<TOk, TErr> LINFIGFALEL([In] TOk FHBBHJHMBGK)
	{
		return default(HHHCCNLMPJL<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6BE0", Offset = "0x3CB51E0", VA = "0x183CB6BE0")]
	public HHHCCNLMPJL<TOk?, UErr?> JDPJDCNLBBK<UErr>()
	{
		return default(HHHCCNLMPJL<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3CB64C0", Offset = "0x3CB4AC0", VA = "0x183CB64C0")]
	public HHHCCNLMPJL<UOk?, TErr?> CJGEPMFLCHI<UOk>()
	{
		return default(HHHCCNLMPJL<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3CB7230", Offset = "0x3CB5830", VA = "0x183CB7230")]
	public HHHCCNLMPJL<UOk?, TErr?> LAGDIGIFDGK<UOk>()
	{
		return default(HHHCCNLMPJL<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3CB65E0", Offset = "0x3CB4BE0", VA = "0x183CB65E0")]
	public HHHCCNLMPJL<TOk?, UErr?> FPCHJGBHMGD<UErr>()
	{
		return default(HHHCCNLMPJL<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4B18060", Offset = "0x4B16660", VA = "0x184B18060")]
	public HHHCCNLMPJL<BONGKMFJEJA, TErr> GBKLLMPNPJF()
	{
		return default(HHHCCNLMPJL<BONGKMFJEJA, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4B1B610", Offset = "0x4B19C10", VA = "0x184B1B610")]
	public static bool MMJMCICIDNJ([In] HHHCCNLMPJL<TOk, TErr> JOOBCOFNIAM, [In] HHHCCNLMPJL<TOk, TErr> MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4B17240", Offset = "0x4B15840", VA = "0x184B17240", Slot = "4")]
	public bool Equals(HHHCCNLMPJL<TOk, TErr> MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4B17630", Offset = "0x4B15C30", VA = "0x184B17630", Slot = "0")]
	public override bool Equals(object MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4B19670", Offset = "0x4B17C70", VA = "0x184B19670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4B1CD90", Offset = "0x4B1B390", VA = "0x184B1CD90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class KLCAENAAGHK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct EFCHMAGPDMO<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Task<HHHCCNLMPJL<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<HHHCCNLMPJL<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4501400", Offset = "0x44FFA00", VA = "0x184501400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4501720", Offset = "0x44FFD20", VA = "0x184501720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x390F790", Offset = "0x390DD90", VA = "0x18390F790")]
	public static HHHCCNLMPJL<TOk?, TErr?> IIJKJPIHGDF<TOk, TErr>([In] this HHHCCNLMPJL<TOk, TErr> OCACDKEJIIB, [In] TOk FHBBHJHMBGK)
	{
		return default(HHHCCNLMPJL<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x390F7E0", Offset = "0x390DDE0", VA = "0x18390F7E0")]
	public static HHHCCNLMPJL<BONGKMFJEJA, TErr?> IIJKJPIHGDF<TErr>([In] this HHHCCNLMPJL<BONGKMFJEJA, TErr> OCACDKEJIIB)
	{
		return default(HHHCCNLMPJL<BONGKMFJEJA, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x390F790", Offset = "0x390DD90", VA = "0x18390F790")]
	public static HHHCCNLMPJL<TOk?, TErr?> OBCANBDNECG<TOk, TErr>([In] this HHHCCNLMPJL<TOk, TErr> OCACDKEJIIB, [In] TErr AOGJMPFJDNP)
	{
		return default(HHHCCNLMPJL<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x390EFA0", Offset = "0x390D5A0", VA = "0x18390EFA0")]
	public static TOk? GNJBMCDFEPE<TOk, TErr>([In] this HHHCCNLMPJL<TOk, TErr> OCACDKEJIIB)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3910B90", Offset = "0x390F190", VA = "0x183910B90")]
	[AsyncStateMachine(typeof(EFCHMAGPDMO<, >))]
	public static Task<TOk?>? NDEKBDGLALP<TOk, TErr>(this Task<HHHCCNLMPJL<TOk, TErr>> OCACDKEJIIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x39105B0", Offset = "0x390EBB0", VA = "0x1839105B0")]
	public static TErr? LNFJNNEAMLC<TErr, TOk>([In] this HHHCCNLMPJL<TOk, TErr> OCACDKEJIIB)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x390D000", Offset = "0x390B600", VA = "0x18390D000")]
	public static bool AMJMHFCFGDN<TOk, TErr, UErr, UOk>([In] this HHHCCNLMPJL<TOk, TErr> OCACDKEJIIB, [Out] HHHCCNLMPJL<UOk, UErr> KEGPEOFCCOA) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x390E310", Offset = "0x390C910", VA = "0x18390E310")]
	public static bool BFFKDMHOKPK<TOk, TErr>([In] this HHHCCNLMPJL<TOk, TErr> OCACDKEJIIB, [Out] TOk FHBBHJHMBGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x39108D0", Offset = "0x390EED0", VA = "0x1839108D0")]
	public static bool LNKNCHPIBKH<TOk, TErr>([In] this HHHCCNLMPJL<TOk, TErr> OCACDKEJIIB, [Out][NotNullWhen(true)] TErr AOGJMPFJDNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x390F4A0", Offset = "0x390DAA0", VA = "0x18390F4A0")]
	public static bool IHPOOKDPHMA<TOk, TErr>([In] this HHHCCNLMPJL<TOk, TErr> OCACDKEJIIB, [Out][NotNullWhen(true)] TOk FHBBHJHMBGK, [Out][NotNullWhen(false)] TErr AOGJMPFJDNP) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3910E60", Offset = "0x390F460", VA = "0x183910E60")]
	public static bool OIOAGHPJMMB<TOk, TErr>([In] this HHHCCNLMPJL<TOk, TErr> OCACDKEJIIB, [Out][NotNullWhen(true)] TOk FHBBHJHMBGK, [Out] HHHCCNLMPJL<TOk, TErr> KEGPEOFCCOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x390D260", Offset = "0x390B860", VA = "0x18390D260")]
	public static bool AMJMHFCFGDN<TOk, TErr, UErr, UOk>([In] this HHHCCNLMPJL<TOk, TErr> OCACDKEJIIB, [Out][NotNullWhen(true)] TOk FHBBHJHMBGK, [Out] HHHCCNLMPJL<UOk, UErr> KEGPEOFCCOA) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x390FA80", Offset = "0x390E080", VA = "0x18390FA80")]
	public static bool LFEMIHHLODE<TOk, TErr>([In] this HHHCCNLMPJL<TOk, TErr> OCACDKEJIIB, [Out][NotNullWhen(true)] TOk FHBBHJHMBGK, [Out] HHHCCNLMPJL<BONGKMFJEJA, TErr> KEGPEOFCCOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x390E770", Offset = "0x390CD70", VA = "0x18390E770")]
	public static HHHCCNLMPJL<UOk, UErr> GANMBCDALGG<UOk, UErr, TOk, TErr>([In] this HHHCCNLMPJL<TOk, TErr> OCACDKEJIIB, [In] HHHCCNLMPJL<UOk, UErr> COFBNOFIHKI) where TOk : UOk where TErr : UErr
	{
		return default(HHHCCNLMPJL<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x390FE30", Offset = "0x390E430", VA = "0x18390FE30")]
	public static HHHCCNLMPJL<TOk?[]?, TErr?> LFGJCHPCMEH<TOk, TErr>(this IEnumerable<HHHCCNLMPJL<TOk, TErr>> OCACDKEJIIB)
	{
		return default(HHHCCNLMPJL<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x39101A0", Offset = "0x390E7A0", VA = "0x1839101A0")]
	public static HHHCCNLMPJL<UOk?, TErr?> LLJPNEEKOIC<UOk, TErr, TOk>([In] this HHHCCNLMPJL<TOk, TErr> OCACDKEJIIB, Func<TOk, UOk> OKNCOOAFLJH)
	{
		return default(HHHCCNLMPJL<UOk, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class IHEHLAHANEB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3DFA840", Offset = "0x3DF8E40", VA = "0x183DFA840")]
	public static HHHCCNLMPJL<TOk, T> IIJKJPIHGDF<TOk>([In] TOk FHBBHJHMBGK) where TOk : notnull
	{
		return default(HHHCCNLMPJL<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4C39F00", Offset = "0x4C38500", VA = "0x184C39F00")]
	public static HHHCCNLMPJL<BONGKMFJEJA, T> IIJKJPIHGDF()
	{
		return default(HHHCCNLMPJL<BONGKMFJEJA, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3DFA8E0", Offset = "0x3DF8EE0", VA = "0x183DFA8E0")]
	public static HHHCCNLMPJL<T, TErr> OBCANBDNECG<TErr>([In] TErr AOGJMPFJDNP) where TErr : notnull
	{
		return default(HHHCCNLMPJL<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct BIHKDCPPJCH<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly IKOMJAOIFBO AODABAFDAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly Dictionary<TKey, TValue> CDMFIODGJCE;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4A9DF20", Offset = "0x4A9C520", VA = "0x184A9DF20")]
	public static BIHKDCPPJCH<TKey, TValue> ACADPGMDEBE(string INLEBAAACKH)
	{
		return default(BIHKDCPPJCH<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4A9E0E0", Offset = "0x4A9C6E0", VA = "0x184A9E0E0")]
	internal BIHKDCPPJCH(Dictionary<TKey, TValue> OHLIHBDBKCE, IKOMJAOIFBO DIMHCLMLGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4A9E040", Offset = "0x4A9C640", VA = "0x184A9E040")]
	public OAPPEFFLDGP<TKey, TValue> PNEMLBOPKAD([Out] Dictionary<TKey, TValue> OHLIHBDBKCE)
	{
		return default(OAPPEFFLDGP<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct OAPPEFFLDGP<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TValue> CDMFIODGJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly JIAPKFDFLEC OFAOHELMMEO;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x297FAE0", Offset = "0x297E0E0", VA = "0x18297FAE0")]
	internal OAPPEFFLDGP(Dictionary<TKey, TValue> OHLIHBDBKCE, JIAPKFDFLEC OMMMLKJGIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4C3C7E0", Offset = "0x4C3ADE0", VA = "0x184C3C7E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct GAPAOOCELJG<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly IKOMJAOIFBO AODABAFDAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly HashSet<T> CDMFIODGJCE;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4A9DF20", Offset = "0x4A9C520", VA = "0x184A9DF20")]
	public static GAPAOOCELJG<T> ACADPGMDEBE(string INLEBAAACKH)
	{
		return default(GAPAOOCELJG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4A9E0E0", Offset = "0x4A9C6E0", VA = "0x184A9E0E0")]
	internal GAPAOOCELJG(HashSet<T> OHLIHBDBKCE, IKOMJAOIFBO DIMHCLMLGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4A9E040", Offset = "0x4A9C640", VA = "0x184A9E040")]
	public IIMIMOANPEJ<T> PNEMLBOPKAD([Out] HashSet<T> OHLIHBDBKCE)
	{
		return default(IIMIMOANPEJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct IIMIMOANPEJ<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HashSet<T> CDMFIODGJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly JIAPKFDFLEC OFAOHELMMEO;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x297FAE0", Offset = "0x297E0E0", VA = "0x18297FAE0")]
	internal IIMIMOANPEJ(HashSet<T> OHLIHBDBKCE, JIAPKFDFLEC OMMMLKJGIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4C3C7E0", Offset = "0x4C3ADE0", VA = "0x184C3C7E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct JMPAPBHIDAD<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IKOMJAOIFBO AODABAFDAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Stack<T> CDMFIODGJCE;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4A9DF20", Offset = "0x4A9C520", VA = "0x184A9DF20")]
	public static JMPAPBHIDAD<T> ACADPGMDEBE(string INLEBAAACKH)
	{
		return default(JMPAPBHIDAD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4A9E0E0", Offset = "0x4A9C6E0", VA = "0x184A9E0E0")]
	internal JMPAPBHIDAD(Stack<T> OHLIHBDBKCE, IKOMJAOIFBO DIMHCLMLGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4A9E040", Offset = "0x4A9C640", VA = "0x184A9E040")]
	public APFEKAJNBOL<T> PNEMLBOPKAD([Out] Stack<T> OHLIHBDBKCE)
	{
		return default(APFEKAJNBOL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct APFEKAJNBOL<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Stack<T> CDMFIODGJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly JIAPKFDFLEC OFAOHELMMEO;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x297FAE0", Offset = "0x297E0E0", VA = "0x18297FAE0")]
	internal APFEKAJNBOL(Stack<T> OHLIHBDBKCE, JIAPKFDFLEC OMMMLKJGIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4C3C7E0", Offset = "0x4C3ADE0", VA = "0x184C3C7E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DefaultMember("Item")]
public sealed class IBMPPKILLBB<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct CENFIMPKKJI : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly IBMPPKILLBB<T> PCAAKKAJNLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly int PLKHFOOACGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly bool KANOGHEBNFD;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x265B9C0", Offset = "0x2659FC0", VA = "0x18265B9C0")]
		public CENFIMPKKJI(IBMPPKILLBB<T> HCAMONPFOJM, int BGFIHDMALOM, bool OFIDGHFDCCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x67A96D0", Offset = "0x67A7CD0", VA = "0x1867A96D0")]
		public IBMPPKILLBB<T>.DEPAMLLMAFP OMLAPONJPHN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x67A97C0", Offset = "0x67A7DC0", VA = "0x1867A97C0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x67A97C0", Offset = "0x67A7DC0", VA = "0x1867A97C0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public sealed class DEPAMLLMAFP : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly IBMPPKILLBB<T> PCAAKKAJNLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly int DFKPILONHGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int PHHGAGPDGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly bool KANOGHEBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private bool LHEEFHMMAEG;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T FFKIBMLIABP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6A39650", Offset = "0x6A37C50", VA = "0x186A39650")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x6A39800", Offset = "0x6A37E00", VA = "0x186A39800", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6A39A70", Offset = "0x6A38070", VA = "0x186A39A70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6A3A010", Offset = "0x6A38610", VA = "0x186A3A010")]
		public DEPAMLLMAFP(IBMPPKILLBB<T> HCAMONPFOJM, int BGFIHDMALOM, bool OFIDGHFDCCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6A39710", Offset = "0x6A37D10", VA = "0x186A39710", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6A397A0", Offset = "0x6A37DA0", VA = "0x186A397A0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class IGJBGKMFBLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public IGJBGKMFBLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4C345D0", Offset = "0x4C32BD0", VA = "0x184C345D0")]
		internal T GOAGLAFDPGD(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly T[] DFDKFLKALLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private int PHHGAGPDGEG;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int BGHIFIPHPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4C21B70", Offset = "0x4C20170", VA = "0x184C21B70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T FFKIBMLIABP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4965040", Offset = "0x4963640", VA = "0x184965040")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T ACAGEKDEDPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4C21C00", Offset = "0x4C20200", VA = "0x184C21C00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4C21A40", Offset = "0x4C20040", VA = "0x184C21A40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int JPLLFCIDPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2581AF0", Offset = "0x25800F0", VA = "0x182581AF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1A742A0", Offset = "0x1A728A0", VA = "0x181A742A0")]
	private static int KOMODOIIBMM(int OHHMJGCBCKD, int DDGBDMFPMAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4C21CE0", Offset = "0x4C202E0", VA = "0x184C21CE0")]
	public IBMPPKILLBB(int CFNMLMNHCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4C21D60", Offset = "0x4C20360", VA = "0x184C21D60")]
	public IBMPPKILLBB(int CFNMLMNHCMF, Func<T> NNLDCALBAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4C22060", Offset = "0x4C20660", VA = "0x184C22060")]
	public IBMPPKILLBB(T[] OLCBBPLHPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4C21BD0", Offset = "0x4C201D0", VA = "0x184C21BD0")]
	public void JPOBIPJMCLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4C21AB0", Offset = "0x4C200B0", VA = "0x184C21AB0")]
	public IEnumerable<T> FFMJJEEAJEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4C21C40", Offset = "0x4C20240", VA = "0x184C21C40")]
	public IBMPPKILLBB<T>.DEPAMLLMAFP OMLAPONJPHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x49ACDC0", Offset = "0x49AB3C0", VA = "0x1849ACDC0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x49ACDC0", Offset = "0x49AB3C0", VA = "0x1849ACDC0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class OKKOOPCLDFO
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x39F4990", Offset = "0x39F2F90", VA = "0x1839F4990")]
	public static IBMPPKILLBB<T> ACADPGMDEBE<T>(int CFNMLMNHCMF, Func<T> NNLDCALBAID) where T : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x7D7BED0", Offset = "0x7D7A4D0", VA = "0x187D7BED0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x7D7BE90", Offset = "0x7D7A490", VA = "0x187D7BE90")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x7D7BEB0", Offset = "0x7D7A4B0", VA = "0x187D7BEB0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7D7BEF0", Offset = "0x7D7A4F0", VA = "0x187D7BEF0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x7D7BE70", Offset = "0x7D7A470", VA = "0x187D7BE70")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2783D50", Offset = "0x2782350", VA = "0x182783D50")]
		public RRColor(float NFFBJCCKPJF, float NBMDAEPHDMM, float CNIMJCCKEDM, float FDJHCIBLFFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A290", Offset = "0x7C18890", VA = "0x187C1A290", Slot = "4")]
		public bool Equals(RRColor MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7D7BAC0", Offset = "0x7D7A0C0", VA = "0x187D7BAC0", Slot = "0")]
		public override bool Equals(object MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7D7BBC0", Offset = "0x7D7A1C0", VA = "0x187D7BBC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7D7BC40", Offset = "0x7D7A240", VA = "0x187D7BC40", Slot = "5")]
		public string ToString(string CKHLMMECGLE, IFormatProvider AMMODFLNLEK)
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
			[Cpp2IlInjected.Address(RVA = "0x7D7BA60", Offset = "0x7D7A060", VA = "0x187D7BA60")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7D7BA00", Offset = "0x7D7A000", VA = "0x187D7BA00")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7D7BA30", Offset = "0x7D7A030", VA = "0x187D7BA30")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7D7BA90", Offset = "0x7D7A090", VA = "0x187D7BA90")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x7D7B9D0", Offset = "0x7D79FD0", VA = "0x187D7B9D0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5C92E40", Offset = "0x5C91440", VA = "0x185C92E40")]
		public RRColor32(byte NFFBJCCKPJF, byte NBMDAEPHDMM, byte CNIMJCCKEDM, byte FDJHCIBLFFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2151FC0", Offset = "0x21505C0", VA = "0x182151FC0", Slot = "4")]
		public bool Equals(RRColor32 MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B530", Offset = "0x7D79B30", VA = "0x187D7B530", Slot = "0")]
		public override bool Equals(object MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x12CE620", Offset = "0x12CCC20", VA = "0x1812CE620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B620", Offset = "0x7D79C20", VA = "0x187D7B620")]
		public static RRColor32 OIFHDJNIHDL(RRColor JKIBOICMIDJ)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B5B0", Offset = "0x7D79BB0", VA = "0x187D7B5B0")]
		public static RRColor OIFHDJNIHDL(RRColor32 JKIBOICMIDJ)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B770", Offset = "0x7D79D70", VA = "0x187D7B770", Slot = "5")]
		public string ToString(string CKHLMMECGLE, IFormatProvider AMMODFLNLEK)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class CDFGKJPNDEB<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct KPMEOJKKMFM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly CDFGKJPNDEB<T> HKMHKAFJGJP;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T FPGFCMMHMJG
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x505BDC0", Offset = "0x505A3C0", VA = "0x18505BDC0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x505BDE0", Offset = "0x505A3E0", VA = "0x18505BDE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xD2EEF0", Offset = "0xD2D4F0", VA = "0x180D2EEF0")]
		public KPMEOJKKMFM(CDFGKJPNDEB<T> HKMHKAFJGJP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct NKHADFCBGCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<KPMEOJKKMFM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CDFGKJPNDEB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x540C700", Offset = "0x540AD00", VA = "0x18540C700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x49CB8F0", Offset = "0x49C9EF0", VA = "0x1849CB8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly SemaphoreSlim ACKDLIJPIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private T LJEENFPIGIA;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x67A0490", Offset = "0x679EA90", VA = "0x1867A0490")]
	public CDFGKJPNDEB([In] T LJEENFPIGIA, int BOOHLFKJKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x67A0530", Offset = "0x679EB30", VA = "0x1867A0530")]
	public CDFGKJPNDEB([In] T LJEENFPIGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x679FE20", Offset = "0x679E420", VA = "0x18679FE20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x679FE80", Offset = "0x679E480", VA = "0x18679FE80")]
	public KPMEOJKKMFM HEDCIKIEJKN()
	{
		return default(KPMEOJKKMFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x67A0220", Offset = "0x679E820", VA = "0x1867A0220")]
	[AsyncStateMachine(typeof(CDFGKJPNDEB<>.NKHADFCBGCC))]
	public Task<CDFGKJPNDEB<T>.KPMEOJKKMFM> MOLPCGDJDLH(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x679FE60", Offset = "0x679E460", VA = "0x18679FE60")]
	public void HBMPBEFNNCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class DLFHKKDNIFG
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7D77DD0", Offset = "0x7D763D0", VA = "0x187D77DD0")]
	public static CDFGKJPNDEB<BONGKMFJEJA> ACADPGMDEBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x36C4FE0", Offset = "0x36C35E0", VA = "0x1836C4FE0")]
	public static CDFGKJPNDEB<T> ACADPGMDEBE<T>([In] T LJEENFPIGIA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class IHAOANGCKIP<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public readonly struct NPMPGHICDJA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly IHAOANGCKIP<T> GHJHLELBCEA;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T FPGFCMMHMJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x409AC70", Offset = "0x4099270", VA = "0x18409AC70")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x54266C0", Offset = "0x5424CC0", VA = "0x1854266C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xD2EEF0", Offset = "0xD2D4F0", VA = "0x180D2EEF0")]
		internal NPMPGHICDJA(IHAOANGCKIP<T> HKMHKAFJGJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public readonly struct DONPNPEBIPE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly IHAOANGCKIP<T> GHJHLELBCEA;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T FPGFCMMHMJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x409AC70", Offset = "0x4099270", VA = "0x18409AC70")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x409ACE0", Offset = "0x40992E0", VA = "0x18409ACE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xD2EEF0", Offset = "0xD2D4F0", VA = "0x180D2EEF0")]
		internal DONPNPEBIPE(IHAOANGCKIP<T> HKMHKAFJGJP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct JPMOGOPBGEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AsyncTaskMethodBuilder<DONPNPEBIPE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public IHAOANGCKIP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private CDFGKJPNDEB<BONGKMFJEJA>.KPMEOJKKMFM <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter<CDFGKJPNDEB<BONGKMFJEJA>.KPMEOJKKMFM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4ED23A0", Offset = "0x4ED09A0", VA = "0x184ED23A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x49CB8F0", Offset = "0x49C9EF0", VA = "0x1849CB8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly CDFGKJPNDEB<int> FCBPGICOMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CDFGKJPNDEB<BONGKMFJEJA> OBHOFBEBNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly CDFGKJPNDEB<BONGKMFJEJA> GOANIPKJECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private T HHFHEIMGHGP;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4C39A70", Offset = "0x4C38070", VA = "0x184C39A70")]
	internal IHAOANGCKIP(CDFGKJPNDEB<int> EIMPBDDCPCK, CDFGKJPNDEB<BONGKMFJEJA> IJNDFJKJBHC, CDFGKJPNDEB<BONGKMFJEJA> AJMAGCOAPOG, [In] T LJEENFPIGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4C38D00", Offset = "0x4C37300", VA = "0x184C38D00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4C39310", Offset = "0x4C37910", VA = "0x184C39310")]
	public NPMPGHICDJA NPNJAONMOHB()
	{
		return default(NPMPGHICDJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4C38F70", Offset = "0x4C37570", VA = "0x184C38F70")]
	public DONPNPEBIPE FOKICFNDJFF()
	{
		return default(DONPNPEBIPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4C39690", Offset = "0x4C37C90", VA = "0x184C39690")]
	[AsyncStateMachine(typeof(IHAOANGCKIP<>.JPMOGOPBGEE))]
	public Task<IHAOANGCKIP<T>.DONPNPEBIPE> OLAOPJBABKD(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class IBLLDCHLEAH
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7D796B0", Offset = "0x7D77CB0", VA = "0x187D796B0")]
	public static IHAOANGCKIP<BONGKMFJEJA> ACADPGMDEBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3899C10", Offset = "0x3898210", VA = "0x183899C10")]
	public static IHAOANGCKIP<T> ACADPGMDEBE<T>([In] T LJEENFPIGIA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class KHNHKAGGAAA<TData> : OGMCLKGLBPG where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly string LNILHMKIEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly TData HCNIDPKECHH;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
	public override string JJNMHFCAPPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5009560", Offset = "0x5007B60", VA = "0x185009560")]
	internal KHNHKAGGAAA(string NAAMEAFIHJI, [In] TData APDBNIMCPID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class HDGFKEPBFNA
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7D78D10", Offset = "0x7D77310", VA = "0x187D78D10")]
	public static KHNHKAGGAAA<BONGKMFJEJA> ACADPGMDEBE(string NAAMEAFIHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x37041B0", Offset = "0x37027B0", VA = "0x1837041B0")]
	public static KHNHKAGGAAA<TData> ACADPGMDEBE<TData>(string NAAMEAFIHJI, [In] TData APDBNIMCPID) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class IKOMJAOIFBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	internal bool DIAGLAMEIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly string JIBDIFKMODN;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xE18270", Offset = "0xE16870", VA = "0x180E18270")]
	private IKOMJAOIFBO(bool HHCLFFGGMOM, string OFAJEGKFDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7D79780", Offset = "0x7D77D80", VA = "0x187D79780")]
	public static IKOMJAOIFBO ACADPGMDEBE(string OFAJEGKFDLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7D797F0", Offset = "0x7D77DF0", VA = "0x187D797F0")]
	public JIAPKFDFLEC PNEMLBOPKAD()
	{
		return default(JIAPKFDFLEC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct JIAPKFDFLEC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly IKOMJAOIFBO JILCBMCCCCI;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xD2EEF0", Offset = "0xD2D4F0", VA = "0x180D2EEF0")]
	internal JIAPKFDFLEC(IKOMJAOIFBO INLEBAAACKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A390", Offset = "0x7D78990", VA = "0x187D7A390", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class OJAGPBLHCJG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class ICMCGLDCCFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public ICMCGLDCCFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x4C25D50", Offset = "0x4C24350", VA = "0x184C25D50")]
		internal int BKBAEDABKBJ(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private HashSet<T>? KKADDLCCCFJ;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IReadOnlyCollection<T> HGHCCAKDLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x553EAF0", Offset = "0x553D0F0", VA = "0x18553EAF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool PCICPEBGFHH
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x553E720", Offset = "0x553CD20", VA = "0x18553E720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9ED290", Offset = "0x9EB890", VA = "0x1809ED290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x553E930", Offset = "0x553CF30", VA = "0x18553E930")]
	public bool IIGLPCDPOEE(T EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x553E7C0", Offset = "0x553CDC0", VA = "0x18553E7C0")]
	public bool GNAALOCCJEL(T EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x553E770", Offset = "0x553CD70", VA = "0x18553E770")]
	public bool DGAEJOHLCDJ(T EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x553E640", Offset = "0x553CC40", VA = "0x18553E640")]
	public void APMCNHFNGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x553EB30", Offset = "0x553D130", VA = "0x18553EB30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public OJAGPBLHCJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class PHIGNGELHED
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class NKGDJFBMEGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public NKGDJFBMEGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7D7A670", Offset = "0x7D78C70", VA = "0x187D7A670")]
		internal int BKBAEDABKBJ(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private HashSet<object>? KKADDLCCCFJ;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyCollection<object> HGHCCAKDLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B290", Offset = "0x7D79890", VA = "0x187D7B290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool PCICPEBGFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B0A0", Offset = "0x7D796A0", VA = "0x187D7B0A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9ED290", Offset = "0x9EB890", VA = "0x1809ED290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7D7B1B0", Offset = "0x7D797B0", VA = "0x187D7B1B0")]
	public bool IIGLPCDPOEE(object EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7D7B110", Offset = "0x7D79710", VA = "0x187D7B110")]
	public bool GNAALOCCJEL(object EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7D7B0B0", Offset = "0x7D796B0", VA = "0x187D7B0B0")]
	public bool DGAEJOHLCDJ(object EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7D7B030", Offset = "0x7D79630", VA = "0x187D7B030")]
	public void APMCNHFNGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7D7B320", Offset = "0x7D79920", VA = "0x187D7B320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public PHIGNGELHED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class GCBGOACHPCG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private struct GMNEBAHJIAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float IOJHJCADCHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public T FPGFCMMHMJG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<object, GMNEBAHJIAE> BCFIBNCLPAG;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public virtual T GHJEAJCFOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x195C1D0", Offset = "0x195A7D0", VA = "0x18195C1D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x195A7B0", Offset = "0x1958DB0", VA = "0x18195A7B0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public object? BCBOBODMLAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HJEIAMHJLEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x4A9C6D0", Offset = "0x4A9ACD0", VA = "0x184A9C6D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x4AA1980", Offset = "0x4A9FF80", VA = "0x184AA1980")]
	public bool KEOHOAAEDBA(T OHLIHBDBKCE, object EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4A9C630", Offset = "0x4A9AC30", VA = "0x184A9C630")]
	public bool BLDIAILIAMJ(object EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x496C280", Offset = "0x496A880", VA = "0x18496C280")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x4AA1E70", Offset = "0x4AA0470", VA = "0x184AA1E70")]
	public bool LKMKPGKLGLC(object EJJDDFFADPC, [Out] T OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x4AA0750", Offset = "0x4A9ED50", VA = "0x184AA0750")]
	[MAKNJFCMNJF("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool JJIOGHKNFOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x4AA2150", Offset = "0x4AA0750", VA = "0x184AA2150")]
	public GCBGOACHPCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class JDAIBCKBDGJ : MNBEOGMBAED<BDMLCHKFOFH>
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	internal class MEAPILPCFGH : IEqualityComparer<BDMLCHKFOFH>
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		internal static readonly MEAPILPCFGH MLIJHBGBMKP;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7D7A450", Offset = "0x7D78A50", VA = "0x187D7A450", Slot = "4")]
		public bool Equals(BDMLCHKFOFH CEJAAIDLEPA, BDMLCHKFOFH IMNDAJIDDFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6F01580", Offset = "0x6EFFB80", VA = "0x186F01580", Slot = "5")]
		public int GetHashCode(BDMLCHKFOFH BOMDCGFKGKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public MEAPILPCFGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A030", Offset = "0x7D78630", VA = "0x187D7A030")]
	public JDAIBCKBDGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7D79EF0", Offset = "0x7D784F0", VA = "0x187D79EF0", Slot = "4")]
	public override bool IIGLPCDPOEE(BDMLCHKFOFH EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7D79E40", Offset = "0x7D78440", VA = "0x187D79E40", Slot = "5")]
	public override bool GNAALOCCJEL(BDMLCHKFOFH EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7D79FA0", Offset = "0x7D785A0", VA = "0x187D79FA0")]
	private static void MBGACHMHAHF(BDMLCHKFOFH EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x1872350", Offset = "0x1870950", VA = "0x181872350", Slot = "6")]
	protected override string TokenToString(BDMLCHKFOFH EJJDDFFADPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class BDMLCHKFOFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly string BMELCPJFNEC;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	public BDMLCHKFOFH(string BMELCPJFNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7D77D80", Offset = "0x7D76380", VA = "0x187D77D80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public abstract class MNBEOGMBAED<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly IEqualityComparer<T> EFGNCEEFOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private HashSet<T>? KKADDLCCCFJ;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool PCICPEBGFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5374690", Offset = "0x5372C90", VA = "0x185374690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xBF5280", Offset = "0xBF3880", VA = "0x180BF5280")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xC8FD50", Offset = "0xC8E350", VA = "0x180C8FD50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5375340", Offset = "0x5373940", VA = "0x185375340")]
	public MNBEOGMBAED(IEqualityComparer<T> EFGNCEEFOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5374B80", Offset = "0x5373180", VA = "0x185374B80", Slot = "4")]
	public virtual bool IIGLPCDPOEE(T EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5374840", Offset = "0x5372E40", VA = "0x185374840", Slot = "5")]
	public virtual bool GNAALOCCJEL(T EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x53745B0", Offset = "0x5372BB0", VA = "0x1853745B0")]
	public void APMCNHFNGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5375040", Offset = "0x5373640", VA = "0x185375040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class LMNICFCCFJG<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private List<WeakReference<T>>? KKADDLCCCFJ;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool PCICPEBGFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5155A20", Offset = "0x5154020", VA = "0x185155A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5155F50", Offset = "0x5154550", VA = "0x185155F50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5155CE0", Offset = "0x51542E0", VA = "0x185155CE0")]
	public void IIGLPCDPOEE(T EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5155B40", Offset = "0x5154140", VA = "0x185155B40")]
	public void GNAALOCCJEL(T EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x51559E0", Offset = "0x5153FE0", VA = "0x1851559E0")]
	public void APMCNHFNGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x51560F0", Offset = "0x51546F0", VA = "0x1851560F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public LMNICFCCFJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal static class AECHBLHKOGP
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x36491A0", Offset = "0x36477A0", VA = "0x1836491A0")]
	public static void FMOLGLEKKMF<T>(this List<T> OLEDHEBBJPH, int OHHMJGCBCKD) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class GAHFMPEKOIE<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct NLFHIMLFEMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public float IOJHJCADCHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T FPGFCMMHMJG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Dictionary<BDMLCHKFOFH, NLFHIMLFEMD> BCFIBNCLPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly EqualityComparer<T> IPPEFIAKPDE;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public virtual T GHJEAJCFOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x9EB560", Offset = "0x9E9B60", VA = "0x1809EB560", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x9EB530", Offset = "0x9E9B30", VA = "0x1809EB530", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private BDMLCHKFOFH? BCBOBODMLAE
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool HJEIAMHJLEL
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x4A9C6D0", Offset = "0x4A9ACD0", VA = "0x184A9C6D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4A9CCD0", Offset = "0x4A9B2D0", VA = "0x184A9CCD0")]
	public bool KEOHOAAEDBA(T OHLIHBDBKCE, BDMLCHKFOFH EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4A9C630", Offset = "0x4A9AC30", VA = "0x184A9C630")]
	public bool BLDIAILIAMJ(BDMLCHKFOFH EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x496C280", Offset = "0x496A880", VA = "0x18496C280")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4A9CF80", Offset = "0x4A9B580", VA = "0x184A9CF80")]
	public bool LKMKPGKLGLC(BDMLCHKFOFH EJJDDFFADPC, [Out] T OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x4A9C730", Offset = "0x4A9AD30", VA = "0x184A9C730")]
	[MAKNJFCMNJF("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool JJIOGHKNFOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x4A9D010", Offset = "0x4A9B610", VA = "0x184A9D010")]
	public GAHFMPEKOIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class JEAJAHJCLOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Dictionary<object, float> BCFIBNCLPAG;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float AKIJPGKGPJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xEDF1A0", Offset = "0xEDD7A0", VA = "0x180EDF1A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xEDF1B0", Offset = "0xEDD7B0", VA = "0x180EDF1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A290", Offset = "0x7D78890", VA = "0x187D7A290")]
	public void KEOHOAAEDBA(float OHLIHBDBKCE, object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A1D0", Offset = "0x7D787D0", VA = "0x187D7A1D0")]
	public void BLDIAILIAMJ(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A240", Offset = "0x7D78840", VA = "0x187D7A240")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A0A0", Offset = "0x7D786A0", VA = "0x187D7A0A0")]
	private void BLCDACINCOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A300", Offset = "0x7D78900", VA = "0x187D7A300")]
	public JEAJAHJCLOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface AEAIFIOMDPM
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event BFAMDEMJIGI GIDLGFMCOMO;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class HKMALGKDFBG : AEAIFIOMDPM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public readonly struct EILJMFGIJBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly float JDIKNMDACEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly float DCICOKIGPEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal readonly bool LKIDIFGHMGH;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float EOMGDLMNCFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x7D77E40", Offset = "0x7D76440", VA = "0x187D77E40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7D77FB0", Offset = "0x7D765B0", VA = "0x187D77FB0")]
		public EILJMFGIJBO(float IPAELMFFKOA, float LLDMNGOPBOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7D77E50", Offset = "0x7D76450", VA = "0x187D77E50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class OHMBIEBEOBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public HKMALGKDFBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public OHMBIEBEOBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7D7AEB0", Offset = "0x7D794B0", VA = "0x187D7AEB0")]
		internal void NHEKGNGAEAP(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int GDBMBEIFFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int AJEEDJCCIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly AEAIFIOMDPM[] GIGINGDGBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly BFAMDEMJIGI[] DHJEDIPMPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly EILJMFGIJBO[] NPCCCFOBCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private EILJMFGIJBO LMJHJMNFFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly BAKGMMHDEOL DADJCKNLEBC;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event BFAMDEMJIGI GIDLGFMCOMO
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7D78F60", Offset = "0x7D77560", VA = "0x187D78F60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7D78D90", Offset = "0x7D77390", VA = "0x187D78D90", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7D79520", Offset = "0x7D77B20", VA = "0x187D79520")]
	public HKMALGKDFBG(int GDBMBEIFFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7D79490", Offset = "0x7D77A90", VA = "0x187D79490")]
	public BAKGMMHDEOL NENEAGDPGIP(EILJMFGIJBO OOGHBEFHNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7D79020", Offset = "0x7D77620", VA = "0x187D79020")]
	public void JNBLAKPOPPE(AEAIFIOMDPM NLLBBIJADDJ, [Optional] EILJMFGIJBO FLDKJLNEOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7D78E50", Offset = "0x7D77450", VA = "0x187D78E50", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate void BFAMDEMJIGI(float NHDJKKLKHBP);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class IPPGICFCFLI
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class PBEODNNBAMB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly AEAIFIOMDPM CMOPECAAOEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly BFAMDEMJIGI COLEJLDPDCO;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7D7AFA0", Offset = "0x7D795A0", VA = "0x187D7AFA0")]
		public PBEODNNBAMB(AEAIFIOMDPM CMOPECAAOEJ, BFAMDEMJIGI COLEJLDPDCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7D7AF50", Offset = "0x7D79550", VA = "0x187D7AF50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7D79D10", Offset = "0x7D78310", VA = "0x187D79D10")]
	internal static bool GDMCOJJAPEB(float FDJHCIBLFFB, float CNIMJCCKEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7D66C70", Offset = "0x7D65270", VA = "0x187D66C70")]
	internal static float GKLDJAMPMPM(float FDJHCIBLFFB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7D79D80", Offset = "0x7D78380", VA = "0x187D79D80")]
	public static IDisposable PFAELLDPAGL(this AEAIFIOMDPM CMOPECAAOEJ, BFAMDEMJIGI COLEJLDPDCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class BAKGMMHDEOL : AEAIFIOMDPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float NHDJKKLKHBP;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float HPDONMNCHDD
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7D77C90", Offset = "0x7D76290", VA = "0x187D77C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event BFAMDEMJIGI? GIDLGFMCOMO
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7D77BF0", Offset = "0x7D761F0", VA = "0x187D77BF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7D77B50", Offset = "0x7D76150", VA = "0x187D77B50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public BAKGMMHDEOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface HJJLLGOMIMK<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CLMBDIOJEPP<T> CILCEMKBDAL([Out] T OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INBDHNEFJBE();
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class PAILFHFIMIL<T> : HJJLLGOMIMK<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly ConcurrentStack<T> HCLNIFBCCMJ;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5606880", Offset = "0x5604E80", VA = "0x185606880", Slot = "4")]
	public CLMBDIOJEPP<T> CILCEMKBDAL([Out] T OHLIHBDBKCE)
	{
		return default(CLMBDIOJEPP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5606920", Offset = "0x5604F20", VA = "0x185606920")]
	public void KKIPOBFIFOD(T HPHFCNFHHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x4AC68F0", Offset = "0x4AC4EF0", VA = "0x184AC68F0", Slot = "5")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "6")]
	protected virtual void AFNGOEBMCCG(T LNLDMEGOIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x56069A0", Offset = "0x5604FA0", VA = "0x1856069A0")]
	private T PHDCGNDDLGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5606A40", Offset = "0x5605040", VA = "0x185606A40")]
	public PAILFHFIMIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct CLMBDIOJEPP<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly T HPHFCNFHHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly PAILFHFIMIL<T> CNODPANFMJB;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0xABB7D0", Offset = "0xAB9DD0", VA = "0x180ABB7D0")]
	internal CLMBDIOJEPP(T OHLIHBDBKCE, PAILFHFIMIL<T> CNODPANFMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x67D44A0", Offset = "0x67D2AA0", VA = "0x1867D44A0", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class NAJAMDAFNEO : PAILFHFIMIL<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static readonly NAJAMDAFNEO MLIJHBGBMKP;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A500", Offset = "0x7D78B00", VA = "0x187D7A500")]
	public static CLMBDIOJEPP<StringBuilder> PHDCGNDDLGA([Out] StringBuilder OHLIHBDBKCE)
	{
		return default(CLMBDIOJEPP<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A4E0", Offset = "0x7D78AE0", VA = "0x187D7A4E0", Slot = "6")]
	protected override void AFNGOEBMCCG(StringBuilder LNLDMEGOIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A630", Offset = "0x7D78C30", VA = "0x187D7A630")]
	public NAJAMDAFNEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class PIPFJMHCGBB : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x7645FC0", Offset = "0x76445C0", VA = "0x187645FC0")]
	public PIPFJMHCGBB(string NAAMEAFIHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DefaultMember("Item")]
public class CJPADBAAHLA<TKey, TValue> : OCCLPCKCBCG<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, BKLADMDPEGM where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class NOOMAGMIMLP : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public CJPADBAAHLA<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x195C1D0", Offset = "0x195A7D0", VA = "0x18195C1D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x49FEDF0", Offset = "0x49FD3F0", VA = "0x1849FEDF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
		[DebuggerHidden]
		public NOOMAGMIMLP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x49FEF10", Offset = "0x49FD510", VA = "0x1849FEF10", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x541E6B0", Offset = "0x541CCB0", VA = "0x18541E6B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x541DEB0", Offset = "0x541C4B0", VA = "0x18541DEB0")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x541EA90", Offset = "0x541D090", VA = "0x18541EA90")]
		private void PJDCPOGKKBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x541EB80", Offset = "0x541D180", VA = "0x18541EB80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly OCCLPCKCBCG<TKey, TValue> LIAHGDFAGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IDictionary<TKey, TValue> ABODHAAGEAK;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x67D20E0", Offset = "0x67D06E0", VA = "0x1867D20E0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool DJCGEFIJFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public TValue OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x67D21B0", Offset = "0x67D07B0", VA = "0x1867D21B0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x67D2480", Offset = "0x67D0A80", VA = "0x1867D2480", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public ICollection<TKey> JABHKAJJCDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x67D2240", Offset = "0x67D0840", VA = "0x1867D2240", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICollection<TValue> CLOMIHCLDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x67D2360", Offset = "0x67D0960", VA = "0x1867D2360", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x67D1E80", Offset = "0x67D0480", VA = "0x1867D1E80")]
	public CJPADBAAHLA(OCCLPCKCBCG<TKey, TValue> LIAHGDFAGBG, [Optional] IDictionary<TKey, TValue>? ABODHAAGEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x67CF7A0", Offset = "0x67CDDA0", VA = "0x1867CF7A0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x67D0510", Offset = "0x67CEB10", VA = "0x1867D0510")]
	public void FMFABMFMKMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x67CF210", Offset = "0x67CD810", VA = "0x1867CF210", Slot = "9")]
	public void Add(TKey OEHHKNIGGMI, TValue OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x67D0630", Offset = "0x67CEC30", VA = "0x1867D0630")]
	public void FODMEGOOLPJ(TKey OEHHKNIGGMI, TValue OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x67D10D0", Offset = "0x67CF6D0", VA = "0x1867D10D0")]
	public void PPMIMHNBPNL(TKey OEHHKNIGGMI, TValue OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x67D0B60", Offset = "0x67CF160", VA = "0x1867D0B60")]
	public void OGFCFHDNDAJ(TKey OEHHKNIGGMI, TValue OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x67D0060", Offset = "0x67CE660", VA = "0x1867D0060")]
	public void DMMKIMJDHFL(TKey OEHHKNIGGMI, TValue OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x67D14C0", Offset = "0x67CFAC0", VA = "0x1867D14C0", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> HOJKNIMMINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x67D1550", Offset = "0x67CFB50", VA = "0x1867D1550", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x67D18B0", Offset = "0x67CFEB0", VA = "0x1867D18B0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x67CF8E0", Offset = "0x67CDEE0", VA = "0x1867CF8E0", Slot = "8")]
	public bool ContainsKey(TKey OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x67D0AA0", Offset = "0x67CF0A0", VA = "0x1867D0AA0")]
	public bool OFEMHGMMPGE(TKey OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x67D0980", Offset = "0x67CEF80", VA = "0x1867D0980")]
	public bool IOIFGPOAECE(TKey OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x67D1320", Offset = "0x67CF920", VA = "0x1867D1320", Slot = "10")]
	public bool Remove(TKey OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x67D1C10", Offset = "0x67D0210", VA = "0x1867D1C10", Slot = "11")]
	public bool TryGetValue(TKey OEHHKNIGGMI, [Out] TValue OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x67CFBE0", Offset = "0x67CE1E0", VA = "0x1867CFBE0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] NBBLCIBNPBK, int DDFLLHIGBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x4F6A080", Offset = "0x4F68680", VA = "0x184F6A080", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x67D0870", Offset = "0x67CEE70", VA = "0x1867D0870", Slot = "19")]
	[IteratorStateMachine(typeof(CJPADBAAHLA<, >.NOOMAGMIMLP))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x67CF700", Offset = "0x67CDD00", VA = "0x1867CF700", Slot = "21")]
	public bool CBBCAAJLNNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x67D0400", Offset = "0x67CEA00", VA = "0x1867D0400")]
	private TValue DNKIIKLDKKL(TKey OEHHKNIGGMI)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface JGODANCIHHF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string OGADDFNLPCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface BKLADMDPEGM
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CBBCAAJLNNJ();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface OCCLPCKCBCG<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, BKLADMDPEGM
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[DefaultMember("Item")]
public sealed class FAKLKHOBCAF<TKey, TVal> : OCCLPCKCBCG<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, BKLADMDPEGM where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public delegate int KLHIIMGJNAN(TKey OEHHKNIGGMI, TVal OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate void JCNIAMJACJF(TKey OEHHKNIGGMI, TVal OHLIHBDBKCE, AKOFMBHIPNP DKBCGBFNIGO);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class NEMNBEPDNDH
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public TKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xF8C400", Offset = "0xF8AA00", VA = "0x180F8C400")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public TVal FPGFCMMHMJG
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xBF5280", Offset = "0xBF3880", VA = "0x180BF5280")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xC8FD50", Offset = "0xC8E350", VA = "0x180C8FD50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public int EOMGDLMNCFL
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xD2BF30", Offset = "0xD2A530", VA = "0x180D2BF30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xF1E020", Offset = "0xF1C620", VA = "0x180F1E020")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public DateTimeOffset OLNIMJCMBIN
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x12A0680", Offset = "0x129EC80", VA = "0x1812A0680")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x12A0670", Offset = "0x129EC70", VA = "0x1812A0670")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x53D9C40", Offset = "0x53D8240", VA = "0x1853D9C40")]
		public NEMNBEPDNDH(TKey OEHHKNIGGMI, TVal GCDAJLDGOIF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class JNEGMHPBHMB : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public FAKLKHOBCAF<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private LinkedList<NEMNBEPDNDH>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x195C1D0", Offset = "0x195A7D0", VA = "0x18195C1D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x4EA99F0", Offset = "0x4EA7FF0", VA = "0x184EA99F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
		[DebuggerHidden]
		public JNEGMHPBHMB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x49F97D0", Offset = "0x49F7DD0", VA = "0x1849F97D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x4EA73E0", Offset = "0x4EA59E0", VA = "0x184EA73E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x4EA6D80", Offset = "0x4EA5380", VA = "0x184EA6D80")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4EA9770", Offset = "0x4EA7D70", VA = "0x184EA9770", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public const int EDANJLOMEGH = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly Dictionary<TKey, LinkedListNode<NEMNBEPDNDH>> OHFFBCEMMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly LinkedList<NEMNBEPDNDH> LIOAHNNFOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly KLHIIMGJNAN? NEIBHEBGDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly TimeSpan GLKALOKLFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly JCNIAMJACJF? AJBEMMOIIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly HGAOMCLAJHP GGEOBOOOEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool CKODCHFAMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly List<TKey> FIPBJPFOGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly List<TVal> PECJGEGKENO;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int EFJAAKPECFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xBF3530", Offset = "0xBF1B30", VA = "0x180BF3530")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	internal int OHDAOPOFPHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xD31700", Offset = "0xD2FD00", VA = "0x180D31700")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xE58D80", Offset = "0xE57380", VA = "0x180E58D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x497F660", Offset = "0x497DC60", VA = "0x18497F660", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	internal int AFEICHCHJAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x496C280", Offset = "0x496A880", VA = "0x18496C280")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public ICollection<TVal> CLOMIHCLDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x497F7E0", Offset = "0x497DDE0", VA = "0x18497F7E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	ICollection<TKey> IDictionary<TKey, TVal>.HAHEFDEMFIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x497B9A0", Offset = "0x4979FA0", VA = "0x18497B9A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool DJCGEFIJFFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public TVal OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x497F790", Offset = "0x497DD90", VA = "0x18497F790", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x497F8D0", Offset = "0x497DED0", VA = "0x18497F8D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x496A8D0", Offset = "0x4968ED0", VA = "0x18496A8D0")]
	private bool BEMCBPGPIOI(int GDBMBEIFFOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4978BF0", Offset = "0x49771F0", VA = "0x184978BF0")]
	private void OLFBLCMDKBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x497EF60", Offset = "0x497D560", VA = "0x18497EF60")]
	public FAKLKHOBCAF(int GDBMBEIFFOO, [Optional] KLHIIMGJNAN? NEIBHEBGDCA, [Optional] IEqualityComparer<TKey>? FHGJDKOPHBN, [Optional] JCNIAMJACJF? AJBEMMOIIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x497CBF0", Offset = "0x497B1F0", VA = "0x18497CBF0")]
	public FAKLKHOBCAF(TimeSpan GLKALOKLFGM, [Optional] IEqualityComparer<TKey>? FHGJDKOPHBN, [Optional] JCNIAMJACJF? AJBEMMOIIJP, [Optional] HGAOMCLAJHP? GGEOBOOOEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x497C630", Offset = "0x497AC30", VA = "0x18497C630")]
	public FAKLKHOBCAF(int GDBMBEIFFOO, TimeSpan GLKALOKLFGM, [Optional] IEqualityComparer<TKey>? FHGJDKOPHBN, [Optional] JCNIAMJACJF? AJBEMMOIIJP, [Optional] HGAOMCLAJHP? GGEOBOOOEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x497E240", Offset = "0x497C840", VA = "0x18497E240")]
	public FAKLKHOBCAF(int GDBMBEIFFOO, KLHIIMGJNAN? NEIBHEBGDCA, TimeSpan GLKALOKLFGM, [Optional] IEqualityComparer<TKey>? FHGJDKOPHBN, [Optional] JCNIAMJACJF? AJBEMMOIIJP, [Optional] HGAOMCLAJHP? GGEOBOOOEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x496A920", Offset = "0x4968F20", VA = "0x18496A920", Slot = "21")]
	public bool CBBCAAJLNNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x496C070", Offset = "0x496A670", VA = "0x18496C070", Slot = "22")]
	public bool CFHLGKLFNEA(int CFNMLMNHCMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x496F820", Offset = "0x496DE20", VA = "0x18496F820")]
	private bool DIEKDCIABIJ(int CFNMLMNHCMF, AKOFMBHIPNP DKBCGBFNIGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x496E990", Offset = "0x496CF90", VA = "0x18496E990")]
	public void DGBNDJBCMEF(TKey OEHHKNIGGMI, TVal OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x4969AE0", Offset = "0x49680E0", VA = "0x184969AE0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> HOJKNIMMINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x496A760", Offset = "0x4968D60", VA = "0x18496A760", Slot = "9")]
	public void Add(TKey OEHHKNIGGMI, TVal OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x496C5C0", Offset = "0x496ABC0", VA = "0x18496C5C0", Slot = "8")]
	public bool ContainsKey(TKey OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x497B210", Offset = "0x4979810", VA = "0x18497B210", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x497AD70", Offset = "0x4979370", VA = "0x18497AD70", Slot = "10")]
	public bool Remove(TKey OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x497B5F0", Offset = "0x4979BF0", VA = "0x18497B5F0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4979D90", Offset = "0x4978390", VA = "0x184979D90")]
	private bool PGAFKNEHGID(TKey OEHHKNIGGMI, [Out] TVal OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x497A630", Offset = "0x4978C30", VA = "0x18497A630")]
	private TVal PHDCGNDDLGA(TKey KBMOAEOFKJM)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x497BE20", Offset = "0x497A420", VA = "0x18497BE20", Slot = "11")]
	public bool TryGetValue(TKey KBMOAEOFKJM, [Out] TVal OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x496C2D0", Offset = "0x496A8D0", VA = "0x18496C2D0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x496D3B0", Offset = "0x496B9B0", VA = "0x18496D3B0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] NBBLCIBNPBK, int DDFLLHIGBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4975740", Offset = "0x4973D40", VA = "0x184975740")]
	private void FKAKKEJCDGG(TKey OEHHKNIGGMI, TVal GCDAJLDGOIF, AKOFMBHIPNP DKBCGBFNIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x49767C0", Offset = "0x4974DC0", VA = "0x1849767C0")]
	private bool ICMEFLHHPNM(NEMNBEPDNDH NEGDNCJNBAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x4974770", Offset = "0x4972D70", VA = "0x184974770")]
	private void EMJICAOGPJD(LinkedListNode<NEMNBEPDNDH> KFIMPLBHNNM, TVal DAIGGDIKJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x4977EA0", Offset = "0x49764A0", VA = "0x184977EA0")]
	private void KEOHOAAEDBA(TKey OEHHKNIGGMI, TVal OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x496B200", Offset = "0x4969800", VA = "0x18496B200")]
	private void CCNAGEFKGNM(NEMNBEPDNDH NEGDNCJNBAH, TVal DAIGGDIKJOJ, int IPMBIEKIIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x4975F40", Offset = "0x4974540", VA = "0x184975F40", Slot = "19")]
	[IteratorStateMachine(typeof(FAKLKHOBCAF<, >.JNEGMHPBHMB))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x497B9F0", Offset = "0x4979FF0", VA = "0x18497B9F0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public enum AKOFMBHIPNP : byte
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
public class PDLEACCAFIO<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly TKey FBPDAJEOIKF;

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x560C6D0", Offset = "0x560ACD0", VA = "0x18560C6D0")]
	public PDLEACCAFIO(TKey FDFHAKBKBHC, Exception HBNIOKPNOCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class IPNJCDGFAOB : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6E9D610", Offset = "0x6E9BC10", VA = "0x186E9D610")]
	public IPNJCDGFAOB(string NAAMEAFIHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class DCMNDOHINLE<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class BIGCEJPHBGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public DCMNDOHINLE<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public BIGCEJPHBGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x633A5F0", Offset = "0x6338BF0", VA = "0x18633A5F0")]
		internal Task<TResource> ODHAIPGEKKC(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct KADIOGLBAHP : IAsyncStateMachine
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
		public DCMNDOHINLE<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x4F90920", Offset = "0x4F8EF20", VA = "0x184F90920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x4F90EE0", Offset = "0x4F8F4E0", VA = "0x184F90EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct CMGLAGLNIEC : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x67D63A0", Offset = "0x67D49A0", VA = "0x1867D63A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x67D7020", Offset = "0x67D5620", VA = "0x1867D7020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly OFHFIGEMBPB<TId, Task<TResource>> PLDGMLEMENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> MNHGFOKAOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? CNCNIKKDHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Action<TResource>? NMGIABCLOEC;

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6A34D90", Offset = "0x6A33390", VA = "0x186A34D90")]
	public DCMNDOHINLE(int HNDEALABJHB = 0, [Optional] IEqualityComparer<TId>? NCCENAFDELI, [Optional] Func<TId, CancellationToken, Task<TResource>>? CBBEBIHJHCE, [Optional] Action<TResource>? HCNJDGNNCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6A335A0", Offset = "0x6A31BA0", VA = "0x186A335A0")]
	public CLCFAKNAJCK<Task<TResource>> DJBJOAFCKAH(TId HJPLNJNIFLL, [Optional] Func<TId, CancellationToken, Task<TResource>>? CBBEBIHJHCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6A34810", Offset = "0x6A32E10", VA = "0x186A34810")]
	private void OAEBBEFCKCM(Task<TResource> BGKKDAHMDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6A33D10", Offset = "0x6A32310", VA = "0x186A33D10")]
	[AsyncStateMachine(typeof(DCMNDOHINLE<, >.KADIOGLBAHP))]
	private Task FBBIBNAGOJG(Task<TResource> BGKKDAHMDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x67DC910", Offset = "0x67DAF10", VA = "0x1867DC910")]
	public void FENMDCKDFIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6A34A50", Offset = "0x6A33050", VA = "0x186A34A50")]
	public OFHFIGEMBPB<TId, Task<TResource>>.MJPBKMHHPEJ OMLAPONJPHN()
	{
		return default(OFHFIGEMBPB<TId, Task<TResource>>.MJPBKMHHPEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6A34C50", Offset = "0x6A33250", VA = "0x186A34C50", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6A34C50", Offset = "0x6A33250", VA = "0x186A34C50", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6A34370", Offset = "0x6A32970", VA = "0x186A34370")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(DCMNDOHINLE<, >.CMGLAGLNIEC))]
	internal static Task NEIACFHDFIK(Task<TResource> BGKKDAHMDLM, CancellationTokenSource HELAMEEKEEM, Dictionary<Task<TResource>, CancellationTokenSource> BIINMLCHMEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class OFHFIGEMBPB<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class BILPAFNGAAN : IEquatable<BILPAFNGAAN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public readonly TValue FPGFCMMHMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int DPOJKCPEKAH;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x11B2D80", Offset = "0x11B1380", VA = "0x1811B2D80")]
		public BILPAFNGAAN(TValue OHLIHBDBKCE, int ICBCBEKDOON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x633AAD0", Offset = "0x63390D0", VA = "0x18633AAD0", Slot = "4")]
		public bool Equals(BILPAFNGAAN? MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x633AA30", Offset = "0x6339030", VA = "0x18633AA30", Slot = "0")]
		public override bool Equals(object? BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x633AC80", Offset = "0x6339280", VA = "0x18633AC80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public struct MJPBKMHHPEJ : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Dictionary<TKey, BILPAFNGAAN>.Enumerator OKLIBDLOGKI;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x5360D90", Offset = "0x535F390", VA = "0x185360D90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public (TKey Key, TValue Value, int RefCount) FFKIBMLIABP
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x5361140", Offset = "0x535F740", VA = "0x185361140", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x5360ED0", Offset = "0x535F4D0", VA = "0x185360ED0")]
		public MJPBKMHHPEJ(OFHFIGEMBPB<TKey, TValue> BCFIBNCLPAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x5360940", Offset = "0x535EF40", VA = "0x185360940", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x5360A00", Offset = "0x535F000", VA = "0x185360A00", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x5360A40", Offset = "0x535F040", VA = "0x185360A40", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class DNEHKCFEFKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public OFHFIGEMBPB<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public BILPAFNGAAN refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public DNEHKCFEFKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x6A4C670", Offset = "0x6A4AC70", VA = "0x186A4C670")]
		internal void ODHAIPGEKKC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<TKey, BILPAFNGAAN> CFHABHJHHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Func<TKey, TValue>? AEGONKOHIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TValue>? HGDHPKNBGEK;

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x552AFC0", Offset = "0x55295C0", VA = "0x18552AFC0")]
	public OFHFIGEMBPB(int HNDEALABJHB = 0, [Optional] IEqualityComparer<TKey>? FHGJDKOPHBN, [Optional] Func<TKey, TValue>? EGFCHFKNJIB, [Optional] Action<TValue>? MGPHFAIGLKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x55299D0", Offset = "0x5527FD0", VA = "0x1855299D0")]
	public CLCFAKNAJCK<TValue> DJBJOAFCKAH(TKey OEHHKNIGGMI, [Optional] Func<TKey, TValue>? IALHFIIBJNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x552A990", Offset = "0x5528F90", VA = "0x18552A990")]
	private void KKIPOBFIFOD(TKey OEHHKNIGGMI, BILPAFNGAAN AKNJDJEBNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x552A530", Offset = "0x5528B30", VA = "0x18552A530")]
	public void FENMDCKDFIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x552AD70", Offset = "0x5529370", VA = "0x18552AD70")]
	public MJPBKMHHPEJ OMLAPONJPHN()
	{
		return default(MJPBKMHHPEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x552AE80", Offset = "0x5529480", VA = "0x18552AE80", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x552AE80", Offset = "0x5529480", VA = "0x18552AE80", Slot = "5")]
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
