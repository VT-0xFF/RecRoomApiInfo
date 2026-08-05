using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
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
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69A4710", Offset = "0x69A3310", VA = "0x1869A4710")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86E660", Offset = "0x86D260", VA = "0x18086E660")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E6A0", Offset = "0x86D2A0", VA = "0x18086E6A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class FMCLFABDPGC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	protected FMCLFABDPGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class JBHFDILGNDC<T> : FMCLFABDPGC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct CPJGKDBDPOK
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum EMGGPKFMAAF
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
		public EMGGPKFMAAF NCNNODEFPOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T FIPNCHEIGMJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int OALPNKPGGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool BLBGELIAEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool MOKCJKPEFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? FLGIKDBJHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<CPJGKDBDPOK>? DECEMKIOEOO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool HACPMGCOFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x400FFC0", Offset = "0x400EBC0", VA = "0x18400FFC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x40109A0", Offset = "0x400F5A0", VA = "0x1840109A0")]
	protected JBHFDILGNDC(bool MOKCJKPEFHM, bool BLBGELIAEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x40102F0", Offset = "0x400EEF0", VA = "0x1840102F0")]
	protected bool KMIBKLINLHE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4010020", Offset = "0x400EC20", VA = "0x184010020")]
	protected void HMDIFGOBLNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4010390", Offset = "0x400EF90", VA = "0x184010390")]
	protected void MLKBFFPCPCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2815B40", Offset = "0x2814740", VA = "0x182815B40")]
	private static void PGMKPACKIDE<U>(List<U>? KNDOIJDCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4010600", Offset = "0x400F200", VA = "0x184010600", Slot = "4")]
	public void MPFJKDGCCNN(T FIPNCHEIGMJ, bool MLJMAMNDBLF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4010130", Offset = "0x400ED30", VA = "0x184010130", Slot = "5")]
	public void IFPALOLJLCH(T FIPNCHEIGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4010800", Offset = "0x400F400", VA = "0x184010800")]
	public void ONDHHAABKMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class DEHOLECDIJP : JBHFDILGNDC<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x69A22C0", Offset = "0x69A0EC0", VA = "0x1869A22C0")]
	public DEHOLECDIJP(bool MOKCJKPEFHM = false, bool BLBGELIAEPE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x69A2060", Offset = "0x69A0C60", VA = "0x1869A2060")]
	public void DOBCDLDNJAI()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x69A2000", Offset = "0x69A0C00", VA = "0x1869A2000")]
	public static DEHOLECDIJP DGBGNIFIBBK(DEHOLECDIJP HKEPKOHJGKN, Action FIPNCHEIGMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69A2260", Offset = "0x69A0E60", VA = "0x1869A2260")]
	public static DEHOLECDIJP HHHBBILIKNK(DEHOLECDIJP HKEPKOHJGKN, Action FIPNCHEIGMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FNPDMGOHFHB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MPFJKDGCCNN(Action<T> FIPNCHEIGMJ, bool MLJMAMNDBLF = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IFPALOLJLCH(Action<T> FIPNCHEIGMJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class JFCBGCCGGGE<T> : JBHFDILGNDC<Action<T>>, FNPDMGOHFHB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C980", Offset = "0x3B9B580", VA = "0x183B9C980")]
	public JFCBGCCGGGE(bool MOKCJKPEFHM = false, bool BLBGELIAEPE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4026B90", Offset = "0x4025790", VA = "0x184026B90")]
	public void DOBCDLDNJAI(T NEAJEANMBOG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3B98CA0", Offset = "0x3B978A0", VA = "0x183B98CA0")]
	public static JFCBGCCGGGE<T> DGBGNIFIBBK(JFCBGCCGGGE<T> HKEPKOHJGKN, Action<T> FIPNCHEIGMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C8E0", Offset = "0x3B9B4E0", VA = "0x183B9C8E0")]
	public static JFCBGCCGGGE<T> HHHBBILIKNK(JFCBGCCGGGE<T> HKEPKOHJGKN, Action<T> FIPNCHEIGMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ANIAPGGFLGJ<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class FFKNAOPGKON<T, U> : JBHFDILGNDC<Action<T, U>>, ANIAPGGFLGJ<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C980", Offset = "0x3B9B580", VA = "0x183B9C980")]
	public FFKNAOPGKON(bool MOKCJKPEFHM = false, bool BLBGELIAEPE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3B9BF80", Offset = "0x3B9AB80", VA = "0x183B9BF80")]
	public void DOBCDLDNJAI(T NEAJEANMBOG, U IEPMADKDKFA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3B98CA0", Offset = "0x3B978A0", VA = "0x183B98CA0")]
	public static FFKNAOPGKON<T, U> DGBGNIFIBBK(FFKNAOPGKON<T, U> HKEPKOHJGKN, Action<T, U> FIPNCHEIGMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C8E0", Offset = "0x3B9B4E0", VA = "0x183B9C8E0")]
	public static FFKNAOPGKON<T, U> HHHBBILIKNK(FFKNAOPGKON<T, U> HKEPKOHJGKN, Action<T, U> FIPNCHEIGMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class FLLHEFAEBCL<T, U, V> : JBHFDILGNDC<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C980", Offset = "0x3B9B580", VA = "0x183B9C980")]
	public FLLHEFAEBCL(bool MOKCJKPEFHM = false, bool BLBGELIAEPE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3BAEC20", Offset = "0x3BAD820", VA = "0x183BAEC20")]
	public void DOBCDLDNJAI(T NEAJEANMBOG, U IEPMADKDKFA, V BGNEHGMDHMD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3B98CA0", Offset = "0x3B978A0", VA = "0x183B98CA0")]
	public static FLLHEFAEBCL<T, U, V> DGBGNIFIBBK(FLLHEFAEBCL<T, U, V> HKEPKOHJGKN, Action<T, U, V> FIPNCHEIGMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C8E0", Offset = "0x3B9B4E0", VA = "0x183B9C8E0")]
	public static FLLHEFAEBCL<T, U, V> HHHBBILIKNK(FLLHEFAEBCL<T, U, V> HKEPKOHJGKN, Action<T, U, V> FIPNCHEIGMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OKNJEIBELGC<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class KNPAFANKGEH<T, U, V, W> : JBHFDILGNDC<Action<T, U, V, W>>, OKNJEIBELGC<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C980", Offset = "0x3B9B580", VA = "0x183B9C980")]
	public KNPAFANKGEH(bool MOKCJKPEFHM = false, bool BLBGELIAEPE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x41656F0", Offset = "0x41642F0", VA = "0x1841656F0")]
	public void DOBCDLDNJAI(T NEAJEANMBOG, U IEPMADKDKFA, V BGNEHGMDHMD, W NLPLEHNHDEH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3B98CA0", Offset = "0x3B978A0", VA = "0x183B98CA0")]
	public static KNPAFANKGEH<T, U, V, W> DGBGNIFIBBK(KNPAFANKGEH<T, U, V, W> HKEPKOHJGKN, Action<T, U, V, W> FIPNCHEIGMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C8E0", Offset = "0x3B9B4E0", VA = "0x183B9C8E0")]
	public static KNPAFANKGEH<T, U, V, W> HHHBBILIKNK(KNPAFANKGEH<T, U, V, W> HKEPKOHJGKN, Action<T, U, V, W> FIPNCHEIGMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class JPFAMHNHGPE<T, U, V, W, X> : JBHFDILGNDC<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C980", Offset = "0x3B9B580", VA = "0x183B9C980")]
	public JPFAMHNHGPE(bool MOKCJKPEFHM = false, bool BLBGELIAEPE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x40792F0", Offset = "0x4077EF0", VA = "0x1840792F0")]
	public void DOBCDLDNJAI(T NEAJEANMBOG, U IEPMADKDKFA, V BGNEHGMDHMD, W NLPLEHNHDEH, X KNFDPFPHEON)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3B98CA0", Offset = "0x3B978A0", VA = "0x183B98CA0")]
	public static JPFAMHNHGPE<T, U, V, W, X> DGBGNIFIBBK(JPFAMHNHGPE<T, U, V, W, X> HKEPKOHJGKN, Action<T, U, V, W, X> FIPNCHEIGMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C8E0", Offset = "0x3B9B4E0", VA = "0x183B9C8E0")]
	public static JPFAMHNHGPE<T, U, V, W, X> HHHBBILIKNK(JPFAMHNHGPE<T, U, V, W, X> HKEPKOHJGKN, Action<T, U, V, W, X> FIPNCHEIGMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class ONBGHNIGOPN<T, U, V, W, X, Y> : JBHFDILGNDC<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C980", Offset = "0x3B9B580", VA = "0x183B9C980")]
	public ONBGHNIGOPN(bool MOKCJKPEFHM = false, bool BLBGELIAEPE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x46459E0", Offset = "0x46445E0", VA = "0x1846459E0")]
	public void DOBCDLDNJAI(T NEAJEANMBOG, U IEPMADKDKFA, V BGNEHGMDHMD, W NLPLEHNHDEH, X KNFDPFPHEON, Y EFBKAEHLBOM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3B98CA0", Offset = "0x3B978A0", VA = "0x183B98CA0")]
	public static ONBGHNIGOPN<T, U, V, W, X, Y> DGBGNIFIBBK(ONBGHNIGOPN<T, U, V, W, X, Y> HKEPKOHJGKN, Action<T, U, V, W, X, Y> FIPNCHEIGMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C8E0", Offset = "0x3B9B4E0", VA = "0x183B9C8E0")]
	public static ONBGHNIGOPN<T, U, V, W, X, Y> HHHBBILIKNK(ONBGHNIGOPN<T, U, V, W, X, Y> HKEPKOHJGKN, Action<T, U, V, W, X, Y> FIPNCHEIGMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class BFIEKCIKFPP<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly JGOEDLBJKBP<TKey, TVal> POFFJCKGBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> NIHBNIHIPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly JGOEDLBJKBP<TKey, TVal>.FPELHGPOLLL? LOEICABGIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int NDPKCBPDBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly JGOEDLBJKBP<TKey, TVal>.JDBFJGHHGLE? ABHGJJFDLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int JNCMLEMLINE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int JLEPBNOPBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4E591E0", Offset = "0x4E57DE0", VA = "0x184E591E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int HHEOBNINOII
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x844560", Offset = "0x843160", VA = "0x180844560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4E596F0", Offset = "0x4E582F0", VA = "0x184E596F0")]
	public BFIEKCIKFPP(int NDPKCBPDBMM, [Optional] JGOEDLBJKBP<TKey, TVal>.JDBFJGHHGLE? ABHGJJFDLDK, [Optional] IEqualityComparer<TKey>? NJBIKOFAJOP, [Optional] JGOEDLBJKBP<TKey, TVal>.FPELHGPOLLL? LOEICABGIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4E58CF0", Offset = "0x4E578F0", VA = "0x184E58CF0")]
	public void HPOGJLHPBHG(TKey DPHIOKCFMFC, TVal GLMEMJNJKAN, bool JBFJJAIJFML = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4E58B90", Offset = "0x4E57790", VA = "0x184E58B90")]
	public bool HIICJGCHPPL(TKey DPHIOKCFMFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4E58400", Offset = "0x4E57000", VA = "0x184E58400")]
	public bool CMBHFEACNLN(TKey KGJLOOCNEOA, [Out] TVal GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4E58F20", Offset = "0x4E57B20", VA = "0x184E58F20")]
	private void IKOPMBFPEIN(TKey DPHIOKCFMFC, TVal GLMEMJNJKAN, int AEOJMEBJNPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4E59230", Offset = "0x4E57E30", VA = "0x184E59230")]
	public bool KIJKMEIFMLF(TKey DPHIOKCFMFC, TVal GLMEMJNJKAN, bool JBFJJAIJFML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4E59640", Offset = "0x4E58240", VA = "0x184E59640")]
	public void ONDHHAABKMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4E58630", Offset = "0x4E57230", VA = "0x184E58630")]
	private void FHNABGGJPCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4E593E0", Offset = "0x4E57FE0", VA = "0x184E593E0")]
	private bool LPOGAACDFOP(TKey DPHIOKCFMFC, BCIMEPIJAPP BGLFCJCCBPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4E59520", Offset = "0x4E58120", VA = "0x184E59520")]
	private void NOOFPJCAJLH(TKey DPHIOKCFMFC, TVal GLMEMJNJKAN, BCIMEPIJAPP BGLFCJCCBPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4E58500", Offset = "0x4E57100", VA = "0x184E58500")]
	private void EAIIFDNGBFM(TKey DPHIOKCFMFC, TVal CLJFFIBMODC, BCIMEPIJAPP BGLFCJCCBPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NCJJJOCHLKN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action KFIPJKHLHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool GLAMNLHLNDN;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	public NCJJJOCHLKN(Action OJBPIBKEGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x69A46D0", Offset = "0x69A32D0", VA = "0x1869A46D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x288AB30", Offset = "0x2889730", VA = "0x18288AB30")]
	public static BLPMMPOKDIJ<T> GADNMLFOLLL<T>(T GLMEMJNJKAN, Action OJBPIBKEGDN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class BLPMMPOKDIJ<T> : NCJJJOCHLKN where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T EPAONLOANJK
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4E64240", Offset = "0x4E62E40", VA = "0x184E64240")]
	public BLPMMPOKDIJ(T GLMEMJNJKAN, Action OJBPIBKEGDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class DCEHBPFHLKH<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly HBFEJLFHDAA<T>? GADFLEDJMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> BIONOLNOGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool GLAMNLHLNDN;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly DCEHBPFHLKH<T> BBCAMDNMADI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> CHJFLNKMJCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x57C44B0", Offset = "0x57C30B0", VA = "0x1857C44B0")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long CJOHGCFPKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x57C4870", Offset = "0x57C3470", VA = "0x1857C4870")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool IHNECOIEJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x57C42E0", Offset = "0x57C2EE0", VA = "0x1857C42E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x57C4EE0", Offset = "0x57C3AE0", VA = "0x1857C4EE0")]
	public DCEHBPFHLKH(HBFEJLFHDAA<T> NLHDOEJCEOG, HBFEJLFHDAA<T> EJPMPNPNLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x57C4A80", Offset = "0x57C3680", VA = "0x1857C4A80")]
	public DCEHBPFHLKH(HBFEJLFHDAA<T> NLHDOEJCEOG, int PAGNMFPMINA, HBFEJLFHDAA<T> EJPMPNPNLFE, int DEBHHNDJNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x57C4E30", Offset = "0x57C3A30", VA = "0x1857C4E30")]
	private DCEHBPFHLKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x57C43A0", Offset = "0x57C2FA0", VA = "0x1857C43A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x57C4530", Offset = "0x57C3130", VA = "0x1857C4530")]
	public T[] KFDCBPFLHKE()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x57C4690", Offset = "0x57C3290", VA = "0x1857C4690")]
	public static ReadOnlySequence<T> NBHHLKKAPBL(DCEHBPFHLKH<T>? DKDOBLCBHIB)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct DEAGKENLJKN : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct GNJIHBNGMDO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10")]
		public static GNJIHBNGMDO PPOPBMPFEOP()
		{
			return default(GNJIHBNGMDO);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x292D870", Offset = "0x292C470", VA = "0x18292D870")]
	public static string? INKGOKCKMLK<T>([Optional] string? CHBJGMBDMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x292D7F0", Offset = "0x292C3F0", VA = "0x18292D7F0")]
	public static string? DBNKOBLHLOG<T>([Optional] string? LBDIFNKIEPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10")]
	public static DEAGKENLJKN EBEAKPKNDNN(string CHBJGMBDMHA, string? LBDIFNKIEPN)
	{
		return default(DEAGKENLJKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct EJFDDCNOMKE
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool MOOGELPOBDN(string FGNNEKAJCCE, EJFDDCNOMKE EAIPIFCPCKE);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class ICMAMOBBHFK<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public ICMAMOBBHFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3E22730", Offset = "0x3E21330", VA = "0x183E22730")]
		internal void LLCKOGBEHGJ(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int APNFGFBFBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string LDBEENCEHMN;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x69A2FB0", Offset = "0x69A1BB0", VA = "0x1869A2FB0")]
	public static Dictionary<string, EJFDDCNOMKE> ANNELEOODND(Type CALAKHKEMGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2977150", Offset = "0x2975D50", VA = "0x182977150")]
	public static Dictionary<string, EJFDDCNOMKE> ANNELEOODND<T>(Type CALAKHKEMGK, IReadOnlyDictionary<T, string> MEMLKGAJOFM) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x29769D0", Offset = "0x29755D0", VA = "0x1829769D0")]
	public static Dictionary<string, EJFDDCNOMKE> ALIFJDKGCHI<T>(List<T> CKLPIIMDJLC) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x69A32E0", Offset = "0x69A1EE0", VA = "0x1869A32E0")]
	public static Dictionary<string, EJFDDCNOMKE> GGEPGDDHICE(Type CALAKHKEMGK, MOOGELPOBDN CIHDPABFECL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x69A36A0", Offset = "0x69A22A0", VA = "0x1869A36A0")]
	public static Dictionary<int, string> KFHBBFDNBMH(Dictionary<string, EJFDDCNOMKE> OGOLDJHPDFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class DICIKJENGEG : NKGCJHELBDN
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool DGDCAFONHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? ANGEMCPJJMB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual NKGCJHELBDN? CFFCMBCDKBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x69A29C0", Offset = "0x69A15C0", VA = "0x1869A29C0")]
	protected DICIKJENGEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string BKHNKMBHNFM();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x69A2940", Offset = "0x69A1540", VA = "0x1869A2940", Slot = "8")]
	public virtual string PBKMNEELKIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69A26A0", Offset = "0x69A12A0", VA = "0x1869A26A0", Slot = "9")]
	public void OCNIJDELMEE(StringBuilder NBPCAOJAPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69A2640", Offset = "0x69A1240", VA = "0x1869A2640", Slot = "10")]
	public void NFBEFFHHLLP(StringBuilder NBPCAOJAPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x69A2520", Offset = "0x69A1120", VA = "0x1869A2520", Slot = "11")]
	public void KNDOPFIBEMP(StringBuilder NBPCAOJAPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x69A2320", Offset = "0x69A0F20", VA = "0x1869A2320", Slot = "12")]
	public void ACJEMBHFKGJ(StringBuilder NBPCAOJAPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x69A2480", Offset = "0x69A1080", VA = "0x1869A2480")]
	public static void FGDDEFBDNIN(StringBuilder NBPCAOJAPOF, string EFAACKBEEPG, string HPEBLJANFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5B9EA10", Offset = "0x5B9D610", VA = "0x185B9EA10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class MBFIEPMBMJL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x69A4670", Offset = "0x69A3270", VA = "0x1869A4670")]
	public MBFIEPMBMJL(string JIMAFLGJGFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class KGOOGPJLCBJ<TErr> : MBFIEPMBMJL where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr ALAJMPHGIIK;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x414CBF0", Offset = "0x414B7F0", VA = "0x18414CBF0")]
	private KGOOGPJLCBJ([In] TErr KCIOAPFOCNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x414CB20", Offset = "0x414B720", VA = "0x18414CB20")]
	public static KGOOGPJLCBJ<TErr> PPOPBMPFEOP([In] TErr KCIOAPFOCNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface NKGCJHELBDN
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PBKMNEELKIG();

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string BKHNKMBHNFM();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface PCPICBCKBHA<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	TOptions EPAONLOANJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface HAEHJPKOFHL
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string DEHKGNBGNHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class HBFEJLFHDAA<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static HBFEJLFHDAA<T>? HLOIEFEALID;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static object DLANEIKDEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private IMemoryOwner<T>? MDKMMKHMGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private bool GLAMNLHLNDN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool INNHKJOMFBL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9D7F40", Offset = "0x9D6B40", VA = "0x1809D7F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3D17100", Offset = "0x3D15D00", VA = "0x183D17100")]
	private static HBFEJLFHDAA<T> KEPJPAOPJEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3D15F90", Offset = "0x3D14B90", VA = "0x183D15F90")]
	private static void BPEGLFPPBKA(HBFEJLFHDAA<T> ADMAGDGHCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3BAC2B0", Offset = "0x3BAAEB0", VA = "0x183BAC2B0")]
	private HBFEJLFHDAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3D16D20", Offset = "0x3D15920", VA = "0x183D16D20")]
	public static HBFEJLFHDAA<T> GADNMLFOLLL(ReadOnlyMemory<T> PMHOFICJGNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3D16EF0", Offset = "0x3D15AF0", VA = "0x183D16EF0")]
	public static HBFEJLFHDAA<T> GADNMLFOLLL(IMemoryOwner<T> GOJKOJKFIHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3D15E50", Offset = "0x3D14A50", VA = "0x183D15E50")]
	public static void AEBOJNBFOIB(HBFEJLFHDAA<T> NLHDOEJCEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3D16650", Offset = "0x3D15250", VA = "0x183D16650", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3D16540", Offset = "0x3D15140", VA = "0x183D16540")]
	public HBFEJLFHDAA<T> DCNHNFPJNMN(IMemoryOwner<T> GOJKOJKFIHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3D176F0", Offset = "0x3D162F0", VA = "0x183D176F0")]
	private void NCAHHPHGJML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3D175A0", Offset = "0x3D161A0", VA = "0x183D175A0")]
	private HBFEJLFHDAA<T> KIADPJCGHNI(HBFEJLFHDAA<T> ADMAGDGHCAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class PKBOKIJMDJN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x69A5670", Offset = "0x69A4270", VA = "0x1869A5670")]
	public PKBOKIJMDJN(string JIMAFLGJGFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class OPNLHFJHDJC<TOk> : PKBOKIJMDJN where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly TOk IJKAHGEFGOL;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x46561C0", Offset = "0x4654DC0", VA = "0x1846561C0")]
	private OPNLHFJHDJC([In] TOk HLGICJHNDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A400", Offset = "0x3D39000", VA = "0x183D3A400")]
	public static OPNLHFJHDJC<TOk> PPOPBMPFEOP([In] TOk HLGICJHNDOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class PFENPOLBPPL : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly ReadOnlySequence<byte> BIONOLNOGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private SequencePosition AJACNKLCLPC;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override bool ECGEIHINGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override bool GIJNANHNMGN
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override bool JGNHOFKMCIF
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public override long CJOHGCFPKAM
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x69A5400", Offset = "0x69A4000", VA = "0x1869A5400", Slot = "11")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public override long KJEIHCPEBJE
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x69A5460", Offset = "0x69A4060", VA = "0x1869A5460", Slot = "12")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x69A5530", Offset = "0x69A4130", VA = "0x1869A5530", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x69A5330", Offset = "0x69A3F30", VA = "0x1869A5330")]
	public PFENPOLBPPL(ReadOnlySequence<byte> DKDOBLCBHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x69A4EE0", Offset = "0x69A3AE0", VA = "0x1869A4EE0", Slot = "32")]
	public override long Seek(long MANKJHLJMBO, SeekOrigin JJNNAHKJEAK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x69A4A40", Offset = "0x69A3640", VA = "0x1869A4A40", Slot = "34")]
	public override int Read(byte[] BKHGNPANPPB, int MANKJHLJMBO, int HDFABDCMCAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "22")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x69A5270", Offset = "0x69A3E70", VA = "0x1869A5270", Slot = "33")]
	public override void SetLength(long GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x69A52D0", Offset = "0x69A3ED0", VA = "0x1869A52D0", Slot = "37")]
	public override void Write(byte[] BKHGNPANPPB, int MANKJHLJMBO, int HDFABDCMCAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct GFFELLBKJIA<TOk, TErr> : IEquatable<GFFELLBKJIA<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly EqualityComparer<TErr> CKEOGDEFNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal readonly TErr ALAJMPHGIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal readonly TOk IJKAHGEFGOL;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool NKFCDDHOOIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3C92D80", Offset = "0x3C91980", VA = "0x183C92D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool FMPDPAMPEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3C94A40", Offset = "0x3C93640", VA = "0x183C94A40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3C97C70", Offset = "0x3C96870", VA = "0x183C97C70")]
	internal GFFELLBKJIA([In] TErr KCIOAPFOCNC, [In] TOk HLGICJHNDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3C92650", Offset = "0x3C91250", VA = "0x183C92650")]
	public static GFFELLBKJIA<TOk, TErr> KDABFEKDMHL([In] TErr KCIOAPFOCNC)
	{
		return default(GFFELLBKJIA<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3C91F50", Offset = "0x3C90B50", VA = "0x183C91F50")]
	public static GFFELLBKJIA<TOk, TErr> HABGFKKMOGG([In] TOk HLGICJHNDOH)
	{
		return default(GFFELLBKJIA<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x26DBE00", Offset = "0x26DAA00", VA = "0x1826DBE00")]
	public GFFELLBKJIA<TOk?, UErr?> NKDHFJEKNHI<UErr>()
	{
		return default(GFFELLBKJIA<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x26DB980", Offset = "0x26DA580", VA = "0x1826DB980")]
	public GFFELLBKJIA<UOk?, TErr?> HMNOMJKLMDN<UOk>()
	{
		return default(GFFELLBKJIA<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x26DAF30", Offset = "0x26D9B30", VA = "0x1826DAF30")]
	public GFFELLBKJIA<UOk?, TErr?> FAEPKMPONPA<UOk>()
	{
		return default(GFFELLBKJIA<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x26DBBC0", Offset = "0x26DA7C0", VA = "0x1826DBBC0")]
	public GFFELLBKJIA<TOk?, UErr?> LMKMAMIEBNK<UErr>()
	{
		return default(GFFELLBKJIA<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3C8F700", Offset = "0x3C8E300", VA = "0x183C8F700")]
	public GFFELLBKJIA<LOGIJBPEHJN, TErr> CCOMKHDEKKK()
	{
		return default(GFFELLBKJIA<LOGIJBPEHJN, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3C944D0", Offset = "0x3C930D0", VA = "0x183C944D0")]
	public static bool NBAHCGFACIA([In] GFFELLBKJIA<TOk, TErr> HOGIDEMINCM, [In] GFFELLBKJIA<TOk, TErr> FKJHDCOBNND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3C8FF60", Offset = "0x3C8EB60", VA = "0x183C8FF60", Slot = "4")]
	public bool Equals(GFFELLBKJIA<TOk, TErr> OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3C8FB70", Offset = "0x3C8E770", VA = "0x183C8FB70", Slot = "0")]
	public override bool Equals(object OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3C90EF0", Offset = "0x3C8FAF0", VA = "0x183C90EF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3C954C0", Offset = "0x3C940C0", VA = "0x183C954C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class DPCCKHNDPND
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct GLPPFBCAHBI<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Task<GFFELLBKJIA<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<GFFELLBKJIA<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3CE4040", Offset = "0x3CE2C40", VA = "0x183CE4040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3CE4680", Offset = "0x3CE3280", VA = "0x183CE4680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2957040", Offset = "0x2955C40", VA = "0x182957040")]
	public static GFFELLBKJIA<TOk?, TErr?> IJKAHGEFGOL<TOk, TErr>([In] this GFFELLBKJIA<TOk, TErr> HNFMOHFACKF, [In] TOk HLGICJHNDOH)
	{
		return default(GFFELLBKJIA<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2957780", Offset = "0x2956380", VA = "0x182957780")]
	public static GFFELLBKJIA<LOGIJBPEHJN, TErr?> IJKAHGEFGOL<TErr>([In] this GFFELLBKJIA<LOGIJBPEHJN, TErr> HNFMOHFACKF)
	{
		return default(GFFELLBKJIA<LOGIJBPEHJN, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2957040", Offset = "0x2955C40", VA = "0x182957040")]
	public static GFFELLBKJIA<TOk?, TErr?> ALAJMPHGIIK<TOk, TErr>([In] this GFFELLBKJIA<TOk, TErr> HNFMOHFACKF, [In] TErr KCIOAPFOCNC)
	{
		return default(GFFELLBKJIA<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2958470", Offset = "0x2957070", VA = "0x182958470")]
	public static TOk? MGPEGBCBNGO<TOk, TErr>([In] this GFFELLBKJIA<TOk, TErr> HNFMOHFACKF)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2957820", Offset = "0x2956420", VA = "0x182957820")]
	[AsyncStateMachine(typeof(GLPPFBCAHBI<, >))]
	public static Task<TOk?>? JLJGDFLIJCC<TOk, TErr>(this Task<GFFELLBKJIA<TOk, TErr>> HNFMOHFACKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2957200", Offset = "0x2955E00", VA = "0x182957200")]
	public static TErr? DJHHLGGOIFA<TErr, TOk>([In] this GFFELLBKJIA<TOk, TErr> HNFMOHFACKF)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2958E30", Offset = "0x2957A30", VA = "0x182958E30")]
	public static bool OPNMFEDOFMK<TOk, TErr, UErr, UOk>([In] this GFFELLBKJIA<TOk, TErr> HNFMOHFACKF, [Out] GFFELLBKJIA<UOk, UErr> KGKDOGEDCNJ) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2958D40", Offset = "0x2957940", VA = "0x182958D40")]
	public static bool OKEKKFFGOFP<TOk, TErr>([In] this GFFELLBKJIA<TOk, TErr> HNFMOHFACKF, [Out][NotNullWhen(true)] TOk HLGICJHNDOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2958230", Offset = "0x2956E30", VA = "0x182958230")]
	public static bool MGNACFKHGFP<TOk, TErr>([In] this GFFELLBKJIA<TOk, TErr> HNFMOHFACKF, [Out][NotNullWhen(true)] TErr KCIOAPFOCNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2957600", Offset = "0x2956200", VA = "0x182957600")]
	public static bool IHGODEDHJCN<TOk, TErr>([In] this GFFELLBKJIA<TOk, TErr> HNFMOHFACKF, [Out][NotNullWhen(true)] TOk HLGICJHNDOH, [Out][NotNullWhen(false)] TErr KCIOAPFOCNC) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2956E80", Offset = "0x2955A80", VA = "0x182956E80")]
	public static bool AJHALCALMAF<TOk, TErr>([In] this GFFELLBKJIA<TOk, TErr> HNFMOHFACKF, [Out][NotNullWhen(true)] TOk HLGICJHNDOH, [Out] GFFELLBKJIA<TOk, TErr> KGKDOGEDCNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2958F60", Offset = "0x2957B60", VA = "0x182958F60")]
	public static bool OPNMFEDOFMK<TOk, TErr, UErr, UOk>([In] this GFFELLBKJIA<TOk, TErr> HNFMOHFACKF, [Out][NotNullWhen(true)] TOk HLGICJHNDOH, [Out] GFFELLBKJIA<UOk, UErr> KGKDOGEDCNJ) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2958990", Offset = "0x2957590", VA = "0x182958990")]
	public static bool MJBLJMONLOA<TOk, TErr>([In] this GFFELLBKJIA<TOk, TErr> HNFMOHFACKF, [Out][NotNullWhen(true)] TOk HLGICJHNDOH, [Out] GFFELLBKJIA<LOGIJBPEHJN, TErr> KGKDOGEDCNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2957C10", Offset = "0x2956810", VA = "0x182957C10")]
	public static GFFELLBKJIA<UOk, UErr> LJCMKLPBHJC<UOk, UErr, TOk, TErr>([In] this GFFELLBKJIA<TOk, TErr> HNFMOHFACKF, [In] GFFELLBKJIA<UOk, UErr> KGECOLOELOJ) where TOk : UOk where TErr : UErr
	{
		return default(GFFELLBKJIA<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x295A010", Offset = "0x2958C10", VA = "0x18295A010")]
	public static GFFELLBKJIA<TOk?[]?, TErr?> PKGNBFLEIMA<TOk, TErr>(this IEnumerable<GFFELLBKJIA<TOk, TErr>> HNFMOHFACKF)
	{
		return default(GFFELLBKJIA<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class DAFJHFCGFEO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x26D2E10", Offset = "0x26D1A10", VA = "0x1826D2E10")]
	public static GFFELLBKJIA<TOk, T> IJKAHGEFGOL<TOk>([In] TOk HLGICJHNDOH) where TOk : notnull
	{
		return default(GFFELLBKJIA<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x57B4F70", Offset = "0x57B3B70", VA = "0x1857B4F70")]
	public static GFFELLBKJIA<LOGIJBPEHJN, T> IJKAHGEFGOL()
	{
		return default(GFFELLBKJIA<LOGIJBPEHJN, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x26D2FB0", Offset = "0x26D1BB0", VA = "0x1826D2FB0")]
	public static GFFELLBKJIA<T, TErr> ALAJMPHGIIK<TErr>([In] TErr KCIOAPFOCNC) where TErr : notnull
	{
		return default(GFFELLBKJIA<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
public sealed class DJEFHBAKJHJ<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private readonly struct IKGDGIAIIAJ : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly DJEFHBAKJHJ<T> DFDBHJFKEDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly int FPCBGOHEMOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly bool DGDAEHKOHOB;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x1E7E7A0", Offset = "0x1E7D3A0", VA = "0x181E7E7A0")]
		public IKGDGIAIIAJ(DJEFHBAKJHJ<T> NHLLCDFJMEP, int GHAFFJJANMA, bool CPPDBFEAEPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3E6C920", Offset = "0x3E6B520", VA = "0x183E6C920")]
		public DJEFHBAKJHJ<T>.EPEKBJEMKNK NDANHGBCNEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3E6CA10", Offset = "0x3E6B610", VA = "0x183E6CA10", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3E6CA10", Offset = "0x3E6B610", VA = "0x183E6CA10", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public sealed class EPEKBJEMKNK : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly DJEFHBAKJHJ<T> DFDBHJFKEDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly int DEKMEIHFPKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private int JBOGEJBCKLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly bool DGDAEHKOHOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private bool OGAEGOHJPEM;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T KDHPDJIABMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x3820A40", Offset = "0x381F640", VA = "0x183820A40")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x3820C00", Offset = "0x381F800", VA = "0x183820C00", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x3820E80", Offset = "0x381FA80", VA = "0x183820E80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x38213A0", Offset = "0x381FFA0", VA = "0x1838213A0")]
		public EPEKBJEMKNK(DJEFHBAKJHJ<T> NHLLCDFJMEP, int GHAFFJJANMA, bool CPPDBFEAEPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x38209B0", Offset = "0x381F5B0", VA = "0x1838209B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3820B40", Offset = "0x381F740", VA = "0x183820B40", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class OCDBFDLCJPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public OCDBFDLCJPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4571EA0", Offset = "0x4570AA0", VA = "0x184571EA0")]
		internal T JLPMHPFODPE(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly T[] LCBHOKAENOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int JBOGEJBCKLG;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int PGDIDHPGHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x57DC5A0", Offset = "0x57DB1A0", VA = "0x1857DC5A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T KDHPDJIABMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3B6D890", Offset = "0x3B6C490", VA = "0x183B6D890")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T FKLDIJDCIAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x57DC630", Offset = "0x57DB230", VA = "0x1857DC630")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T ENBJMEPMEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x57DC750", Offset = "0x57DB350", VA = "0x1857DC750")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int CJOHGCFPKAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x18FA190", Offset = "0x18F8D90", VA = "0x1818FA190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x114A600", Offset = "0x1149200", VA = "0x18114A600")]
	private static int IFGFAFPIDAP(int OPDMGNJCACB, int JKBHNDINMGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x57DC990", Offset = "0x57DB590", VA = "0x1857DC990")]
	public DJEFHBAKJHJ(int AEOJMEBJNPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x57DCA10", Offset = "0x57DB610", VA = "0x1857DCA10")]
	public DJEFHBAKJHJ(int AEOJMEBJNPD, Func<T> NIIMMNOGLKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x57DCE50", Offset = "0x57DBA50", VA = "0x1857DCE50")]
	public DJEFHBAKJHJ(T[] PLHBCCDAKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x57DC600", Offset = "0x57DB200", VA = "0x1857DC600")]
	public void DCJHCNLJBJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x57DC8D0", Offset = "0x57DB4D0", VA = "0x1857DC8D0")]
	public IEnumerable<T> PDKOFKCJGIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x57DC830", Offset = "0x57DB430", VA = "0x1857DC830")]
	public DJEFHBAKJHJ<T>.EPEKBJEMKNK NDANHGBCNEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3809330", Offset = "0x3807F30", VA = "0x183809330", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3809330", Offset = "0x3807F30", VA = "0x183809330", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class ADMABOBLHML
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x31D7F70", Offset = "0x31D6B70", VA = "0x1831D7F70")]
	public static DJEFHBAKJHJ<T> PPOPBMPFEOP<T>(int AEOJMEBJNPD, Func<T> NIIMMNOGLKA) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const float kEpsilon = 1E-05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x1F83910", Offset = "0x1F82510", VA = "0x181F83910")]
		public RRColor(float AAELGECAEGP, float GFCDAAFNEPM, float EIKHFLMLKJH, float NABHBOMGBNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x69A56D0", Offset = "0x69A42D0", VA = "0x1869A56D0", Slot = "4")]
		public bool Equals(RRColor OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x69A5750", Offset = "0x69A4350", VA = "0x1869A5750", Slot = "0")]
		public override bool Equals(object OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x69A5850", Offset = "0x69A4450", VA = "0x1869A5850", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x69A58D0", Offset = "0x69A44D0", VA = "0x1869A58D0", Slot = "5")]
		public string ToString(string KKEJAEKDBIN, IFormatProvider PKMNIFOIMPB)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class FLMINEGFIAP<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public readonly struct CBNIAHDBIMP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly FLMINEGFIAP<T> EJOIHFEGBOC;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T EPAONLOANJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x49D4080", Offset = "0x49D2C80", VA = "0x1849D4080")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x50C2DC0", Offset = "0x50C19C0", VA = "0x1850C2DC0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9295C0", Offset = "0x9281C0", VA = "0x1809295C0")]
		public CBNIAHDBIMP(FLMINEGFIAP<T> EJOIHFEGBOC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct KDGDDNHEGGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder<CBNIAHDBIMP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public FLMINEGFIAP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4136750", Offset = "0x4135350", VA = "0x184136750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3C9FEB0", Offset = "0x3C9EAB0", VA = "0x183C9FEB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly SemaphoreSlim PGIDENDGPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private T JAKEDICJBKP;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3BB0430", Offset = "0x3BAF030", VA = "0x183BB0430")]
	public FLMINEGFIAP([In] T JAKEDICJBKP, int EHPKKILMINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3BB02A0", Offset = "0x3BAEEA0", VA = "0x183BB02A0")]
	public FLMINEGFIAP([In] T JAKEDICJBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3BAFCE0", Offset = "0x3BAE8E0", VA = "0x183BAFCE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3BAFD20", Offset = "0x3BAE920", VA = "0x183BAFD20")]
	public CBNIAHDBIMP IGFPNFIMACA()
	{
		return default(CBNIAHDBIMP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3BAFFA0", Offset = "0x3BAEBA0", VA = "0x183BAFFA0")]
	[AsyncStateMachine(typeof(FLMINEGFIAP<>.KDGDDNHEGGI))]
	public Task<FLMINEGFIAP<T>.CBNIAHDBIMP> JLJJOBCHAHB(CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3BB01E0", Offset = "0x3BAEDE0", VA = "0x183BB01E0")]
	public void ODHJHPMBPHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class LFKHFKHPGOA
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x69A4600", Offset = "0x69A3200", VA = "0x1869A4600")]
	public static FLMINEGFIAP<LOGIJBPEHJN> PPOPBMPFEOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x292BA60", Offset = "0x292A660", VA = "0x18292BA60")]
	public static FLMINEGFIAP<T> PPOPBMPFEOP<T>([In] T JAKEDICJBKP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class EBLFAMDKPBA<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct CBLGNMHENNA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly EBLFAMDKPBA<T> ANFLNAPEBJO;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public T EPAONLOANJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x44A05F0", Offset = "0x449F1F0", VA = "0x1844A05F0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x50C2A00", Offset = "0x50C1600", VA = "0x1850C2A00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9295C0", Offset = "0x9281C0", VA = "0x1809295C0")]
		internal CBLGNMHENNA(EBLFAMDKPBA<T> EJOIHFEGBOC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct NNHEKBPFLED : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly EBLFAMDKPBA<T> ANFLNAPEBJO;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T EPAONLOANJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x44A05F0", Offset = "0x449F1F0", VA = "0x1844A05F0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x44A0660", Offset = "0x449F260", VA = "0x1844A0660", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9295C0", Offset = "0x9281C0", VA = "0x1809295C0")]
		internal NNHEKBPFLED(EBLFAMDKPBA<T> EJOIHFEGBOC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct BHLLBBNKPLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder<NNHEKBPFLED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EBLFAMDKPBA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private FLMINEGFIAP<LOGIJBPEHJN>.CBNIAHDBIMP <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<FLMINEGFIAP<LOGIJBPEHJN>.CBNIAHDBIMP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4E5BD70", Offset = "0x4E5A970", VA = "0x184E5BD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3C9FEB0", Offset = "0x3C9EAB0", VA = "0x183C9FEB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly FLMINEGFIAP<int> CPOMJEGMBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly FLMINEGFIAP<LOGIJBPEHJN> MOJDBHLPFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly FLMINEGFIAP<LOGIJBPEHJN> GMPHHBHOKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private T NKEPKJIGEMM;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x37AD010", Offset = "0x37ABC10", VA = "0x1837AD010")]
	internal EBLFAMDKPBA(FLMINEGFIAP<int> EEKGNFKNJFA, FLMINEGFIAP<LOGIJBPEHJN> CEHPMBKDPAC, FLMINEGFIAP<LOGIJBPEHJN> FDKMCNCGBCH, [In] T JAKEDICJBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x37AC420", Offset = "0x37AB020", VA = "0x1837AC420", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x37AC820", Offset = "0x37AB420", VA = "0x1837AC820")]
	public CBLGNMHENNA JDCHHNFHGNC()
	{
		return default(CBLGNMHENNA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x37ACBC0", Offset = "0x37AB7C0", VA = "0x1837ACBC0")]
	public NNHEKBPFLED LLMINMLBJFM()
	{
		return default(NNHEKBPFLED);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x37ACEF0", Offset = "0x37ABAF0", VA = "0x1837ACEF0")]
	[AsyncStateMachine(typeof(EBLFAMDKPBA<>.BHLLBBNKPLM))]
	public Task<EBLFAMDKPBA<T>.NNHEKBPFLED> NBAGLDKEINC(CancellationToken MPLCHGMFENA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class CBOOAPNDLND
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x69A1F30", Offset = "0x69A0B30", VA = "0x1869A1F30")]
	public static EBLFAMDKPBA<LOGIJBPEHJN> PPOPBMPFEOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x28E26D0", Offset = "0x28E12D0", VA = "0x1828E26D0")]
	public static EBLFAMDKPBA<T> PPOPBMPFEOP<T>([In] T JAKEDICJBKP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class ALFLEFIPKNP<TData> : DICIKJENGEG where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly string LFPIMPJLAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly TData JLODENNJHEB;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "7")]
	public override string BKHNKMBHNFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3DEBEA0", Offset = "0x3DEAAA0", VA = "0x183DEBEA0")]
	internal ALFLEFIPKNP(string JIMAFLGJGFB, [In] TData IMCLGJBJJKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class ONDGPDAGHFN
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x69A49C0", Offset = "0x69A35C0", VA = "0x1869A49C0")]
	public static ALFLEFIPKNP<LOGIJBPEHJN> PPOPBMPFEOP(string JIMAFLGJGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x288AB30", Offset = "0x2889730", VA = "0x18288AB30")]
	public static ALFLEFIPKNP<TData> PPOPBMPFEOP<TData>(string JIMAFLGJGFB, [In] TData IMCLGJBJJKP) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class GCLCJKALFIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Dictionary<object, float> JBCLENIHHPE;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public float GIEAPMMEBCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8B3230", Offset = "0x8B1E30", VA = "0x1808B3230")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA90130", Offset = "0xA8ED30", VA = "0x180A90130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x69A4310", Offset = "0x69A2F10", VA = "0x1869A4310")]
	public void ALBFOOANFLI(float GLMEMJNJKAN, object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x69A4380", Offset = "0x69A2F80", VA = "0x1869A4380")]
	public void FGLGFDGEHMO(object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x69A43F0", Offset = "0x69A2FF0", VA = "0x1869A43F0")]
	public void ONDHHAABKMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x69A41E0", Offset = "0x69A2DE0", VA = "0x1869A41E0")]
	private void ACHPIGPCBGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x69A4440", Offset = "0x69A3040", VA = "0x1869A4440")]
	public GCLCJKALFIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class OLELBGNANAB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class MCJHHNHPPIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public MCJHHNHPPIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x43E6700", Offset = "0x43E5300", VA = "0x1843E6700")]
		internal int GICAOKKPCHP(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<T>? BFKEHHLKCHA;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public IReadOnlyCollection<T> JEIMLGHPCGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x45BF550", Offset = "0x45BE150", VA = "0x1845BF550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool OHCEOJALELD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x45BF590", Offset = "0x45BE190", VA = "0x1845BF590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int FPIENNPNDKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x84DDF0", Offset = "0x84C9F0", VA = "0x18084DDF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x84DE00", Offset = "0x84CA00", VA = "0x18084DE00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x45BF5E0", Offset = "0x45BE1E0", VA = "0x1845BF5E0")]
	public bool MPFJKDGCCNN(T FGIAGALCIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x45BF3E0", Offset = "0x45BDFE0", VA = "0x1845BF3E0")]
	public bool IFPALOLJLCH(T FGIAGALCIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x45BF390", Offset = "0x45BDF90", VA = "0x1845BF390")]
	public bool CPCALDGNEHE(T FGIAGALCIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x45BF7A0", Offset = "0x45BE3A0", VA = "0x1845BF7A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public OLELBGNANAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class FNLKKHGONOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly string BFJJNIJKGNP;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	public FNLKKHGONOA(string BFJJNIJKGNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x69A4190", Offset = "0x69A2D90", VA = "0x1869A4190", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public sealed class EFNEIMDDKAG
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class BMLJDLPEIEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public BMLJDLPEIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x69A1E80", Offset = "0x69A0A80", VA = "0x1869A1E80")]
		internal int GICAOKKPCHP(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private HashSet<object>? BFKEHHLKCHA;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IReadOnlyCollection<object> JEIMLGHPCGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x69A2BA0", Offset = "0x69A17A0", VA = "0x1869A2BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool OHCEOJALELD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x69A2C30", Offset = "0x69A1830", VA = "0x1869A2C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int FPIENNPNDKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x84DDF0", Offset = "0x84C9F0", VA = "0x18084DDF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x84DE00", Offset = "0x84CA00", VA = "0x18084DE00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x69A2C40", Offset = "0x69A1840", VA = "0x1869A2C40")]
	public bool MPFJKDGCCNN(object FGIAGALCIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x69A2B00", Offset = "0x69A1700", VA = "0x1869A2B00")]
	public bool IFPALOLJLCH(object FGIAGALCIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x69A2AA0", Offset = "0x69A16A0", VA = "0x1869A2AA0")]
	public bool CPCALDGNEHE(object FGIAGALCIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x69A2A30", Offset = "0x69A1630", VA = "0x1869A2A30")]
	public void BMGCALIOGEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x69A2D20", Offset = "0x69A1920", VA = "0x1869A2D20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public EFNEIMDDKAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class IKLOBMHBPKB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private struct FGNEMMFOHAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public float MPBCDLPLLLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public T EPAONLOANJK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Dictionary<object, FGNEMMFOHAG> JBCLENIHHPE;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public virtual T HHBIMELFEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x10571F0", Offset = "0x1055DF0", VA = "0x1810571F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x10567C0", Offset = "0x10553C0", VA = "0x1810567C0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public object? GLGIPJHGIKM
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x847820", Offset = "0x846420", VA = "0x180847820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool HOIODALFKJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x3E6D8C0", Offset = "0x3E6C4C0", VA = "0x183E6D8C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3E6CCA0", Offset = "0x3E6B8A0", VA = "0x183E6CCA0")]
	public bool ALBFOOANFLI(T GLMEMJNJKAN, object FGIAGALCIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3E6D920", Offset = "0x3E6C520", VA = "0x183E6D920")]
	public bool FGLGFDGEHMO(object FGIAGALCIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3821DA0", Offset = "0x38209A0", VA = "0x183821DA0")]
	public void ONDHHAABKMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3E6D680", Offset = "0x3E6C280", VA = "0x183E6D680")]
	public bool CMBHFEACNLN(object FGIAGALCIAP, [Out] T GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3E6D9E0", Offset = "0x3E6C5E0", VA = "0x183E6D9E0")]
	[DAGNLHKDNMD("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool IELGFFOMKBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3E6F120", Offset = "0x3E6DD20", VA = "0x183E6F120")]
	public IKLOBMHBPKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class KHKCCGLBIJE<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private List<WeakReference<T>>? BFKEHHLKCHA;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool OHCEOJALELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x414D3F0", Offset = "0x414BFF0", VA = "0x18414D3F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int FPIENNPNDKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x414D780", Offset = "0x414C380", VA = "0x18414D780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x414D510", Offset = "0x414C110", VA = "0x18414D510")]
	public void MPFJKDGCCNN(T FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x414D250", Offset = "0x414BE50", VA = "0x18414D250")]
	public void IFPALOLJLCH(T FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x414D210", Offset = "0x414BE10", VA = "0x18414D210")]
	public void BMGCALIOGEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x414D920", Offset = "0x414C520", VA = "0x18414D920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public KHKCCGLBIJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal static class EMPNNMGMFIH
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x297A3D0", Offset = "0x2978FD0", VA = "0x18297A3D0")]
	public static void KGMNEGBCDBA<T>(this List<T> KNDOIJDCKAF, int OPDMGNJCACB) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface BLBECLBEDNO
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event LFPDMHJFFCL DIEMGCJLJHL;
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class FFDHPHIIHCF : BLBECLBEDNO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public readonly struct AFPEBPBOLPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly float NBMNJOJAEEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly float KEOKFEIEIKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		internal readonly bool GKFNCCNFNCH;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float LBOCLAHFPED
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x69A1B00", Offset = "0x69A0700", VA = "0x1869A1B00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x69A1C80", Offset = "0x69A0880", VA = "0x1869A1C80")]
		public AFPEBPBOLPF(float BGCAJHMJIFE, float JPLEPBDKKLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x69A1B10", Offset = "0x69A0710", VA = "0x1869A1B10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class BAFGPDLDKGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public FFDHPHIIHCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public BAFGPDLDKGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x69A1DE0", Offset = "0x69A09E0", VA = "0x1869A1DE0")]
		internal void NLGJBOMIKMH(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly int ECCOECALPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int LLCIINKLJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly BLBECLBEDNO[] AIEHGCGOPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly LFPDMHJFFCL[] KHAIJLCNIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly AFPEBPBOLPF[] IKMAKPHDOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private AFPEBPBOLPF FNJEBOIJFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly OEPEJKPKKLA FMEEFAPPNEL;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event LFPDMHJFFCL DIEMGCJLJHL
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x69A3F40", Offset = "0x69A2B40", VA = "0x1869A3F40", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x69A3DF0", Offset = "0x69A29F0", VA = "0x1869A3DF0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x69A4000", Offset = "0x69A2C00", VA = "0x1869A4000")]
	public FFDHPHIIHCF(int ECCOECALPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x69A3EB0", Offset = "0x69A2AB0", VA = "0x1869A3EB0")]
	public OEPEJKPKKLA MFBDIFPANBL(AFPEBPBOLPF LEHJIFCLPNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x69A3860", Offset = "0x69A2460", VA = "0x1869A3860")]
	public void DJFAGJNCCDC(BLBECLBEDNO PHKPBIJKEOH, [Optional] AFPEBPBOLPF ANOCLIBECAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x69A3CE0", Offset = "0x69A28E0", VA = "0x1869A3CE0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public delegate void LFPDMHJFFCL(float PGLOENKNCGK);
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class GEGHDDOILEK
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class EHKDDIHHNGE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly BLBECLBEDNO JCECIDBOHDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly LFPDMHJFFCL LHMNAJJOJLL;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x69A2F20", Offset = "0x69A1B20", VA = "0x1869A2F20")]
		public EHKDDIHHNGE(BLBECLBEDNO JCECIDBOHDM, LFPDMHJFFCL LHMNAJJOJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x69A2ED0", Offset = "0x69A1AD0", VA = "0x1869A2ED0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x69A4590", Offset = "0x69A3190", VA = "0x1869A4590")]
	internal static bool LAMIKENPOBL(float NABHBOMGBNH, float EIKHFLMLKJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6993DA0", Offset = "0x69929A0", VA = "0x186993DA0")]
	internal static float DNEHPOHGMHF(float NABHBOMGBNH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x69A44D0", Offset = "0x69A30D0", VA = "0x1869A44D0")]
	public static IDisposable BBFJPBMNEJO(this BLBECLBEDNO JCECIDBOHDM, LFPDMHJFFCL LHMNAJJOJLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class OEPEJKPKKLA : BLBECLBEDNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private float PGLOENKNCGK;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float EINHIHPAHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x69A4830", Offset = "0x69A3430", VA = "0x1869A4830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event LFPDMHJFFCL? DIEMGCJLJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x69A4920", Offset = "0x69A3520", VA = "0x1869A4920", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x69A4790", Offset = "0x69A3390", VA = "0x1869A4790", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public OEPEJKPKKLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class LMGCMBNNPAP : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6428EA0", Offset = "0x6427AA0", VA = "0x186428EA0")]
	public LMGCMBNNPAP(string JIMAFLGJGFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[DefaultMember("Item")]
public class ABLAFPIHFCM<TKey, TValue> : FOHMGKIKHGB<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, NJFPHEMBJNI where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class LBLLLEKIKKK : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public ABLAFPIHFCM<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x10571F0", Offset = "0x1055DF0", VA = "0x1810571F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x41EE390", Offset = "0x41ECF90", VA = "0x1841EE390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
		[DebuggerHidden]
		public LBLLLEKIKKK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3A563B0", Offset = "0x3A54FB0", VA = "0x183A563B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x41EDEC0", Offset = "0x41ECAC0", VA = "0x1841EDEC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x41ED710", Offset = "0x41EC310", VA = "0x1841ED710")]
		private void FMFBFJNMNDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x41ED580", Offset = "0x41EC180", VA = "0x1841ED580")]
		private void CJOPDLOOCAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x41EE340", Offset = "0x41ECF40", VA = "0x1841EE340", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly FOHMGKIKHGB<TKey, TValue> HJGNKCMGPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly IDictionary<TKey, TValue> CLCAKFDKOLF;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int FPIENNPNDKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0BB0", Offset = "0x3CBF7B0", VA = "0x183CC0BB0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool LJENBABOAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public TValue ENBJMEPMEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0E60", Offset = "0x3CBFA60", VA = "0x183CC0E60", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3CC1130", Offset = "0x3CBFD30", VA = "0x183CC1130", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public ICollection<TKey> LHBMEDHPNHA
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0EB0", Offset = "0x3CBFAB0", VA = "0x183CC0EB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public ICollection<TValue> AAKCJJGLPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0FD0", Offset = "0x3CBFBD0", VA = "0x183CC0FD0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0AF0", Offset = "0x3CBF6F0", VA = "0x183CC0AF0")]
	public ABLAFPIHFCM(FOHMGKIKHGB<TKey, TValue> HJGNKCMGPHH, [Optional] IDictionary<TKey, TValue>? CLCAKFDKOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3CBE2E0", Offset = "0x3CBCEE0", VA = "0x183CBE2E0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3CBEE80", Offset = "0x3CBDA80", VA = "0x183CBEE80")]
	public void GEGJKLCKDPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3CBE0B0", Offset = "0x3CBCCB0", VA = "0x183CBE0B0", Slot = "9")]
	public void Add(TKey DPHIOKCFMFC, TValue GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3CBFAA0", Offset = "0x3CBE6A0", VA = "0x183CBFAA0")]
	public void NHHCJPENIKP(TKey DPHIOKCFMFC, TValue GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3CBFC30", Offset = "0x3CBE830", VA = "0x183CBFC30")]
	public void PLDNOBCKEIB(TKey DPHIOKCFMFC, TValue GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF7A0", Offset = "0x3CBE3A0", VA = "0x183CBF7A0")]
	public void MDNADOACKEM(TKey DPHIOKCFMFC, TValue GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF120", Offset = "0x3CBDD20", VA = "0x183CBF120")]
	public void IPLJKJGIKEH(TKey DPHIOKCFMFC, TValue GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3CC00F0", Offset = "0x3CBECF0", VA = "0x183CC00F0", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> LBACBPHHKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0320", Offset = "0x3CBEF20", VA = "0x183CC0320", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> LBACBPHHKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0680", Offset = "0x3CBF280", VA = "0x183CC0680", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> LBACBPHHKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3CBE420", Offset = "0x3CBD020", VA = "0x183CBE420", Slot = "8")]
	public bool ContainsKey(TKey DPHIOKCFMFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF350", Offset = "0x3CBDF50", VA = "0x183CBF350")]
	public bool JEFEEFPNKCD(TKey DPHIOKCFMFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF410", Offset = "0x3CBE010", VA = "0x183CBF410")]
	public bool LMEFCNDDIEJ(TKey DPHIOKCFMFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3CBFE90", Offset = "0x3CBEA90", VA = "0x183CBFE90", Slot = "10")]
	public bool Remove(TKey DPHIOKCFMFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0950", Offset = "0x3CBF550", VA = "0x183CC0950", Slot = "11")]
	public bool TryGetValue(TKey DPHIOKCFMFC, [Out] TValue GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3CBE4E0", Offset = "0x3CBD0E0", VA = "0x183CBE4E0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] CHPEIOMPEEH, int JNGLDMDNOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0840", Offset = "0x3CBF440", VA = "0x183CC0840", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3CBEF80", Offset = "0x3CBDB80", VA = "0x183CBEF80", Slot = "19")]
	[IteratorStateMachine(typeof(ABLAFPIHFCM<, >.LBLLLEKIKKK))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3CBF0D0", Offset = "0x3CBDCD0", VA = "0x183CBF0D0", Slot = "21")]
	public bool HJGLEOAACAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3CBEC70", Offset = "0x3CBD870", VA = "0x183CBEC70")]
	private TValue EIDPBPFANOP(TKey DPHIOKCFMFC)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface NJFPHEMBJNI
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HJGLEOAACAD();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface FOHMGKIKHGB<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, NJFPHEMBJNI
{
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[DefaultMember("Item")]
public sealed class JGOEDLBJKBP<TKey, TVal> : FOHMGKIKHGB<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, NJFPHEMBJNI where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public delegate int JDBFJGHHGLE(TKey DPHIOKCFMFC, TVal GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public delegate void FPELHGPOLLL(TKey DPHIOKCFMFC, TVal GLMEMJNJKAN, BCIMEPIJAPP BGLFCJCCBPJ);

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class GNGJLJGFBEE
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public TKey NEMDOAJKGDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x8B92D0", Offset = "0x8B7ED0", VA = "0x1808B92D0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public TVal EPAONLOANJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8BAEF0", Offset = "0x8B9AF0", VA = "0x1808BAEF0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8BA9C0", Offset = "0x8B95C0", VA = "0x1808BA9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int LBOCLAHFPED
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x8832B0", Offset = "0x881EB0", VA = "0x1808832B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x882E60", Offset = "0x881A60", VA = "0x180882E60")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTimeOffset ILFFCLAJNAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xC22620", Offset = "0xC21220", VA = "0x180C22620")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x14DF1B0", Offset = "0x14DDDB0", VA = "0x1814DF1B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3CE4970", Offset = "0x3CE3570", VA = "0x183CE4970")]
		public GNGJLJGFBEE(TKey DPHIOKCFMFC, TVal CLJFFIBMODC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class BFEPMGEHNIN : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public JGOEDLBJKBP<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private LinkedList<GNGJLJGFBEE>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x10571F0", Offset = "0x1055DF0", VA = "0x1810571F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x3A598B0", Offset = "0x3A584B0", VA = "0x183A598B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
		[DebuggerHidden]
		public BFEPMGEHNIN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3A51170", Offset = "0x3A4FD70", VA = "0x183A51170", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4E57870", Offset = "0x4E56470", VA = "0x184E57870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x4E555B0", Offset = "0x4E541B0", VA = "0x184E555B0")]
		private void FMFBFJNMNDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4E581E0", Offset = "0x4E56DE0", VA = "0x184E581E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public const int BBGKHEGLLLF = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly Dictionary<TKey, LinkedListNode<GNGJLJGFBEE>> GIAMHHNHDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly LinkedList<GNGJLJGFBEE> PHHIBAEDIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly JDBFJGHHGLE? ABHGJJFDLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly TimeSpan KKKIECICDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly FPELHGPOLLL? LOEICABGIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly KGCFEMNHHJL GJDGANBKEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private bool OAOEGNHOOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly List<TKey> JOCFMLLMDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly List<TVal> JOBLAIJGEJM;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int HHEOBNINOII
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x853470", Offset = "0x852070", VA = "0x180853470")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	internal int JLEPBNOPBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xAEDB50", Offset = "0xAEC750", VA = "0x180AEDB50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xAED4D0", Offset = "0xAEC0D0", VA = "0x180AED4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int FPIENNPNDKO
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x4044F10", Offset = "0x4043B10", VA = "0x184044F10", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	internal int APPGNBDLJJM
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3821DA0", Offset = "0x38209A0", VA = "0x183821DA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public ICollection<TVal> AAKCJJGLPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x4044FF0", Offset = "0x4043BF0", VA = "0x184044FF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	ICollection<TKey> IDictionary<TKey, TVal>.NLOFGFBGLJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x4043F00", Offset = "0x4042B00", VA = "0x184043F00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool LJENBABOAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public TVal ENBJMEPMEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x4044FA0", Offset = "0x4043BA0", VA = "0x184044FA0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4045040", Offset = "0x4043C40", VA = "0x184045040", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x4043530", Offset = "0x4042130", VA = "0x184043530")]
	private bool NCNDLEOEDPN(int ECCOECALPKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x4040D00", Offset = "0x403F900", VA = "0x184040D00")]
	private void DHDAONADBEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x4044420", Offset = "0x4043020", VA = "0x184044420")]
	public JGOEDLBJKBP(int ECCOECALPKO, [Optional] JDBFJGHHGLE? ABHGJJFDLDK, [Optional] IEqualityComparer<TKey>? NJBIKOFAJOP, [Optional] FPELHGPOLLL? LOEICABGIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x4044960", Offset = "0x4043560", VA = "0x184044960")]
	public JGOEDLBJKBP(TimeSpan KKKIECICDHM, [Optional] IEqualityComparer<TKey>? NJBIKOFAJOP, [Optional] FPELHGPOLLL? LOEICABGIAL, [Optional] KGCFEMNHHJL? GJDGANBKEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x40443A0", Offset = "0x4042FA0", VA = "0x1840443A0")]
	public JGOEDLBJKBP(int ECCOECALPKO, TimeSpan KKKIECICDHM, [Optional] IEqualityComparer<TKey>? NJBIKOFAJOP, [Optional] FPELHGPOLLL? LOEICABGIAL, [Optional] KGCFEMNHHJL? GJDGANBKEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x4044AB0", Offset = "0x40436B0", VA = "0x184044AB0")]
	public JGOEDLBJKBP(int ECCOECALPKO, JDBFJGHHGLE? ABHGJJFDLDK, TimeSpan KKKIECICDHM, [Optional] IEqualityComparer<TKey>? NJBIKOFAJOP, [Optional] FPELHGPOLLL? LOEICABGIAL, [Optional] KGCFEMNHHJL? GJDGANBKEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x4042830", Offset = "0x4041430", VA = "0x184042830", Slot = "21")]
	public bool HJGLEOAACAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x4043480", Offset = "0x4042080", VA = "0x184043480", Slot = "22")]
	public bool MDNPJCOFIFA(int AEOJMEBJNPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x4041990", Offset = "0x4040590", VA = "0x184041990")]
	private bool FIMAMCGINBE(int AEOJMEBJNPD, BCIMEPIJAPP BGLFCJCCBPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x403FEB0", Offset = "0x403EAB0", VA = "0x18403FEB0")]
	public void CBGDEMCKLAL(TKey DPHIOKCFMFC, TVal GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x403FB80", Offset = "0x403E780", VA = "0x18403FB80", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> LBACBPHHKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x403FD40", Offset = "0x403E940", VA = "0x18403FD40", Slot = "9")]
	public void Add(TKey DPHIOKCFMFC, TVal GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x40405D0", Offset = "0x403F1D0", VA = "0x1840405D0", Slot = "8")]
	public bool ContainsKey(TKey DPHIOKCFMFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x4043CD0", Offset = "0x40428D0", VA = "0x184043CD0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> LBACBPHHKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x40439C0", Offset = "0x40425C0", VA = "0x1840439C0", Slot = "10")]
	public bool Remove(TKey DPHIOKCFMFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x4043DC0", Offset = "0x40429C0", VA = "0x184043DC0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> LBACBPHHKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x4041450", Offset = "0x4040050", VA = "0x184041450")]
	private bool FGHCBLLEHPO(TKey DPHIOKCFMFC, [Out] TVal GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x4042610", Offset = "0x4041210", VA = "0x184042610")]
	private TVal HCNFCFFAFEI(TKey KGJLOOCNEOA)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x40441A0", Offset = "0x4042DA0", VA = "0x1840441A0", Slot = "11")]
	public bool TryGetValue(TKey KGJLOOCNEOA, [Out] TVal GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4040450", Offset = "0x403F050", VA = "0x184040450", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x4040630", Offset = "0x403F230", VA = "0x184040630", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] CHPEIOMPEEH, int JNGLDMDNOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x40411D0", Offset = "0x403FDD0", VA = "0x1840411D0")]
	private void EAIIFDNGBFM(TKey DPHIOKCFMFC, TVal CLJFFIBMODC, BCIMEPIJAPP BGLFCJCCBPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x40402C0", Offset = "0x403EEC0", VA = "0x1840402C0")]
	private bool CLMBJHEEMLH(GNGJLJGFBEE MGLFCFEPGGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x4042E50", Offset = "0x4041A50", VA = "0x184042E50")]
	private void HNBBIAIODOK(LinkedListNode<GNGJLJGFBEE> NCGHJOHBBBN, TVal CAGOIFBMMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x403F7D0", Offset = "0x403E3D0", VA = "0x18403F7D0")]
	private void ALBFOOANFLI(TKey DPHIOKCFMFC, TVal GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x40437A0", Offset = "0x40423A0", VA = "0x1840437A0")]
	private void OBBMPMNEHDH(GNGJLJGFBEE MGLFCFEPGGG, TVal CAGOIFBMMMG, int DKJJICELCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x4042560", Offset = "0x4041160", VA = "0x184042560", Slot = "19")]
	[IteratorStateMachine(typeof(JGOEDLBJKBP<, >.BFEPMGEHNIN))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x4043F50", Offset = "0x4042B50", VA = "0x184043F50", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public enum BCIMEPIJAPP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class JFDHOAOLPME<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly TKey POFHBDFOOFL;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4028FF0", Offset = "0x4027BF0", VA = "0x184028FF0")]
	public JFDHOAOLPME(TKey EJLFMOJGCGE, Exception OPBDCLKCGHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class OLFMCOECJDO : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x5D23570", Offset = "0x5D22170", VA = "0x185D23570")]
	public OLFMCOECJDO(string JIMAFLGJGFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class CACHKFGGKGF<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class EDPNAAAJHIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CACHKFGGKGF<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public EDPNAAAJHIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x37B2420", Offset = "0x37B1020", VA = "0x1837B2420")]
		internal Task<TResource> HOJAEFAHHNI(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct CFDIMKOEMFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public CACHKFGGKGF<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x51AA970", Offset = "0x51A9570", VA = "0x1851AA970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x51AB4F0", Offset = "0x51AA0F0", VA = "0x1851AB4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct CIOLAJEJGMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x5298900", Offset = "0x5297500", VA = "0x185298900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x52995E0", Offset = "0x52981E0", VA = "0x1852995E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly PBGFBFHBHIK<TId, Task<TResource>> CCIKJLFFAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> HECMDGMKHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? AHBIFAJICAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly Action<TResource>? BNBNPIOJLAE;

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x50C0400", Offset = "0x50BF000", VA = "0x1850C0400")]
	public CACHKFGGKGF(int PGIFPPFBGCN = 0, [Optional] IEqualityComparer<TId>? LAADMJGAMDP, [Optional] Func<TId, CancellationToken, Task<TResource>>? LEDFPAMHEIF, [Optional] Action<TResource>? DAHDOEMGHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x50BF6D0", Offset = "0x50BE2D0", VA = "0x1850BF6D0")]
	public BLPMMPOKDIJ<Task<TResource>> ENOIPAMOKHG(TId EPKGPGILADI, [Optional] Func<TId, CancellationToken, Task<TResource>>? LEDFPAMHEIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x50BECD0", Offset = "0x50BD8D0", VA = "0x1850BECD0")]
	private void BHGHIILGJPG(Task<TResource> HPIAAAJAFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x50BFC60", Offset = "0x50BE860", VA = "0x1850BFC60")]
	[AsyncStateMachine(typeof(CACHKFGGKGF<, >.CFDIMKOEMFC))]
	private Task HLKMJEIJOJP(Task<TResource> HPIAAAJAFJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x50C0060", Offset = "0x50BEC60", VA = "0x1850C0060")]
	public void IKDAJPLCHNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x50C00C0", Offset = "0x50BECC0", VA = "0x1850C00C0")]
	public PBGFBFHBHIK<TId, Task<TResource>>.ACACGOKCKNK NDANHGBCNEI()
	{
		return default(PBGFBFHBHIK<TId, Task<TResource>>.ACACGOKCKNK);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x50C0230", Offset = "0x50BEE30", VA = "0x1850C0230", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x50C0230", Offset = "0x50BEE30", VA = "0x1850C0230", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x50BF290", Offset = "0x50BDE90", VA = "0x1850BF290")]
	[AsyncStateMachine(typeof(CACHKFGGKGF<, >.CIOLAJEJGMO))]
	[CompilerGenerated]
	internal static Task CJINBPPJPBC(Task<TResource> HPIAAAJAFJD, CancellationTokenSource GIFGFNMIIDL, Dictionary<Task<TResource>, CancellationTokenSource> EIJJMLONLLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class PBGFBFHBHIK<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private sealed class OBIFAOIJHMG : IEquatable<OBIFAOIJHMG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public readonly TValue EPAONLOANJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int KPJOIADFHEC;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x945D40", Offset = "0x944940", VA = "0x180945D40")]
		public OBIFAOIJHMG(TValue GLMEMJNJKAN, int ONJKDAFPOFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4571A40", Offset = "0x4570640", VA = "0x184571A40", Slot = "4")]
		public bool Equals(OBIFAOIJHMG? OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x45719A0", Offset = "0x45705A0", VA = "0x1845719A0", Slot = "0")]
		public override bool Equals(object? HAHECKLGOJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4571AD0", Offset = "0x45706D0", VA = "0x184571AD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct ACACGOKCKNK : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private Dictionary<TKey, OBIFAOIJHMG>.Enumerator LGIEOGLECBO;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x3CC1520", Offset = "0x3CC0120", VA = "0x183CC1520", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public (TKey Key, TValue Value, int RefCount) KDHPDJIABMO
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x3CC1AA0", Offset = "0x3CC06A0", VA = "0x183CC1AA0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3CC1710", Offset = "0x3CC0310", VA = "0x183CC1710")]
		public ACACGOKCKNK(PBGFBFHBHIK<TKey, TValue> JBCLENIHHPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3CC1180", Offset = "0x3CBFD80", VA = "0x183CC1180", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3CC1200", Offset = "0x3CBFE00", VA = "0x183CC1200", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3CC1280", Offset = "0x3CBFE80", VA = "0x183CC1280", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class PKKJHDPAEDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public PBGFBFHBHIK<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public OBIFAOIJHMG refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public PKKJHDPAEDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4779DF0", Offset = "0x47789F0", VA = "0x184779DF0")]
		internal void HOJAEFAHHNI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly Dictionary<TKey, OBIFAOIJHMG> GDGCEJAAACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly Func<TKey, TValue>? MPJFFECCNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly Action<TValue>? JNLMKGMBOLP;

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x46E7620", Offset = "0x46E6220", VA = "0x1846E7620")]
	public PBGFBFHBHIK(int PGIFPPFBGCN = 0, [Optional] IEqualityComparer<TKey>? NJBIKOFAJOP, [Optional] Func<TKey, TValue>? DAIKDDOBOHA, [Optional] Action<TValue>? FOJBNEBFOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x46E5D60", Offset = "0x46E4960", VA = "0x1846E5D60")]
	public BLPMMPOKDIJ<TValue> ENOIPAMOKHG(TKey DPHIOKCFMFC, [Optional] Func<TKey, TValue>? GCIEPOGGOBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x46E69B0", Offset = "0x46E55B0", VA = "0x1846E69B0")]
	private void FDHMEOLOKLG(TKey DPHIOKCFMFC, OBIFAOIJHMG BHEDGEEAHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x46E6D50", Offset = "0x46E5950", VA = "0x1846E6D50")]
	public void IKDAJPLCHNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x46E7390", Offset = "0x46E5F90", VA = "0x1846E7390")]
	public ACACGOKCKNK NDANHGBCNEI()
	{
		return default(ACACGOKCKNK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x46E74E0", Offset = "0x46E60E0", VA = "0x1846E74E0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x46E74E0", Offset = "0x46E60E0", VA = "0x1846E74E0", Slot = "5")]
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
