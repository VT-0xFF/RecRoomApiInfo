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
		[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x605C260", Offset = "0x605AC60", VA = "0x18605C260")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BA560", Offset = "0x7B8F60", VA = "0x1807BA560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BA5A0", Offset = "0x7B8FA0", VA = "0x1807BA5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class DLBEIIOFLGC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	protected DLBEIIOFLGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class AGAILBKNKEC<T> : DLBEIIOFLGC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct EGDBGPFABOE
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum MOHLFDDNHNG
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
		public MOHLFDDNHNG AKDFFJNHJJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T GMHPLHJININ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int MDKMFNGGLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool AANBPJLALCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool IJIGEELHPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? ONKMILEDLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<EGDBGPFABOE>? IKHOHBKLNIN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool OLKEEOEFCLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x36763A0", Offset = "0x3674DA0", VA = "0x1836763A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x36765D0", Offset = "0x3674FD0", VA = "0x1836765D0")]
	protected AGAILBKNKEC(bool IJIGEELHPKN, bool AANBPJLALCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3676300", Offset = "0x3674D00", VA = "0x183676300")]
	protected bool MHJAPJABEGD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3676080", Offset = "0x3674A80", VA = "0x183676080")]
	protected void GDOLIKPNGDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x36763F0", Offset = "0x3674DF0", VA = "0x1836763F0")]
	protected void PLNFIHGPJEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2194D20", Offset = "0x2193720", VA = "0x182194D20")]
	private static void AJCKAHAPCOI<U>(List<U>? BPDJICGMKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3675EA0", Offset = "0x36748A0", VA = "0x183675EA0", Slot = "4")]
	public void DGLLAPEBOKO(T GMHPLHJININ, bool ONFNMAENFAH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3675CF0", Offset = "0x36746F0", VA = "0x183675CF0", Slot = "5")]
	public void BPOFHEGLDCM(T GMHPLHJININ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3676180", Offset = "0x3674B80", VA = "0x183676180")]
	public void JOBLGFAFDNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NAOOHBNKKFF
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DGLLAPEBOKO(Action GMHPLHJININ, bool ONFNMAENFAH = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BPOFHEGLDCM(Action GMHPLHJININ);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class BCNLEBGHOIF : AGAILBKNKEC<Action>, NAOOHBNKKFF
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x605A310", Offset = "0x6058D10", VA = "0x18605A310")]
	public BCNLEBGHOIF(bool IJIGEELHPKN = false, bool AANBPJLALCK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x605A050", Offset = "0x6058A50", VA = "0x18605A050")]
	public void EFFMPGPADHJ()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x605A250", Offset = "0x6058C50", VA = "0x18605A250")]
	public static BCNLEBGHOIF NGPNDCIKIJI(BCNLEBGHOIF IEECMNOIJBP, Action GMHPLHJININ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x605A2B0", Offset = "0x6058CB0", VA = "0x18605A2B0")]
	public static BCNLEBGHOIF NMOKAJJFOKB(BCNLEBGHOIF IEECMNOIJBP, Action GMHPLHJININ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MFADDDPFHFA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DGLLAPEBOKO(Action<T> GMHPLHJININ, bool ONFNMAENFAH = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BPOFHEGLDCM(Action<T> GMHPLHJININ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class BFONFBJGKIG<T> : AGAILBKNKEC<Action<T>>, MFADDDPFHFA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3231EA0", Offset = "0x32308A0", VA = "0x183231EA0")]
	public BFONFBJGKIG(bool IJIGEELHPKN = false, bool AANBPJLALCK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4720840", Offset = "0x471F240", VA = "0x184720840")]
	public void EFFMPGPADHJ(T FIGFLJOONIE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3231D80", Offset = "0x3230780", VA = "0x183231D80")]
	public static BFONFBJGKIG<T> NGPNDCIKIJI(BFONFBJGKIG<T> IEECMNOIJBP, Action<T> GMHPLHJININ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3231E10", Offset = "0x3230810", VA = "0x183231E10")]
	public static BFONFBJGKIG<T> NMOKAJJFOKB(BFONFBJGKIG<T> IEECMNOIJBP, Action<T> GMHPLHJININ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BEPAGOJFFGH<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class AJPBOEJFMGB<T, U> : AGAILBKNKEC<Action<T, U>>, BEPAGOJFFGH<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3231EA0", Offset = "0x32308A0", VA = "0x183231EA0")]
	public AJPBOEJFMGB(bool IJIGEELHPKN = false, bool AANBPJLALCK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x376B990", Offset = "0x376A390", VA = "0x18376B990")]
	public void EFFMPGPADHJ(T FIGFLJOONIE, U HNJDJNMKFBE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3231D80", Offset = "0x3230780", VA = "0x183231D80")]
	public static AJPBOEJFMGB<T, U> NGPNDCIKIJI(AJPBOEJFMGB<T, U> IEECMNOIJBP, Action<T, U> GMHPLHJININ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3231E10", Offset = "0x3230810", VA = "0x183231E10")]
	public static AJPBOEJFMGB<T, U> NMOKAJJFOKB(AJPBOEJFMGB<T, U> IEECMNOIJBP, Action<T, U> GMHPLHJININ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class FMCPAMIJMNN<T, U, V> : AGAILBKNKEC<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3231EA0", Offset = "0x32308A0", VA = "0x183231EA0")]
	public FMCPAMIJMNN(bool IJIGEELHPKN = false, bool AANBPJLALCK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x35CD850", Offset = "0x35CC250", VA = "0x1835CD850")]
	public void EFFMPGPADHJ(T FIGFLJOONIE, U HNJDJNMKFBE, V DNGEIAEKKBO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3231D80", Offset = "0x3230780", VA = "0x183231D80")]
	public static FMCPAMIJMNN<T, U, V> NGPNDCIKIJI(FMCPAMIJMNN<T, U, V> IEECMNOIJBP, Action<T, U, V> GMHPLHJININ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3231E10", Offset = "0x3230810", VA = "0x183231E10")]
	public static FMCPAMIJMNN<T, U, V> NMOKAJJFOKB(FMCPAMIJMNN<T, U, V> IEECMNOIJBP, Action<T, U, V> GMHPLHJININ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CAEGJIBCAHH<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class ECAFBDLDPLL<T, U, V, W> : AGAILBKNKEC<Action<T, U, V, W>>, CAEGJIBCAHH<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3231EA0", Offset = "0x32308A0", VA = "0x183231EA0")]
	public ECAFBDLDPLL(bool IJIGEELHPKN = false, bool AANBPJLALCK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x322FF40", Offset = "0x322E940", VA = "0x18322FF40")]
	public void EFFMPGPADHJ(T FIGFLJOONIE, U HNJDJNMKFBE, V DNGEIAEKKBO, W JNEGICJFFGC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3231D80", Offset = "0x3230780", VA = "0x183231D80")]
	public static ECAFBDLDPLL<T, U, V, W> NGPNDCIKIJI(ECAFBDLDPLL<T, U, V, W> IEECMNOIJBP, Action<T, U, V, W> GMHPLHJININ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3231E10", Offset = "0x3230810", VA = "0x183231E10")]
	public static ECAFBDLDPLL<T, U, V, W> NMOKAJJFOKB(ECAFBDLDPLL<T, U, V, W> IEECMNOIJBP, Action<T, U, V, W> GMHPLHJININ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class OMBMIOHKCMA<T, U, V, W, X> : AGAILBKNKEC<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3231EA0", Offset = "0x32308A0", VA = "0x183231EA0")]
	public OMBMIOHKCMA(bool IJIGEELHPKN = false, bool AANBPJLALCK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3FC4840", Offset = "0x3FC3240", VA = "0x183FC4840")]
	public void EFFMPGPADHJ(T FIGFLJOONIE, U HNJDJNMKFBE, V DNGEIAEKKBO, W JNEGICJFFGC, X MGCANBJCGMI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3231D80", Offset = "0x3230780", VA = "0x183231D80")]
	public static OMBMIOHKCMA<T, U, V, W, X> NGPNDCIKIJI(OMBMIOHKCMA<T, U, V, W, X> IEECMNOIJBP, Action<T, U, V, W, X> GMHPLHJININ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3231E10", Offset = "0x3230810", VA = "0x183231E10")]
	public static OMBMIOHKCMA<T, U, V, W, X> NMOKAJJFOKB(OMBMIOHKCMA<T, U, V, W, X> IEECMNOIJBP, Action<T, U, V, W, X> GMHPLHJININ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class PKLCNACNNEC<T, U, V, W, X, Y> : AGAILBKNKEC<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3231EA0", Offset = "0x32308A0", VA = "0x183231EA0")]
	public PKLCNACNNEC(bool IJIGEELHPKN = false, bool AANBPJLALCK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x409CCA0", Offset = "0x409B6A0", VA = "0x18409CCA0")]
	public void EFFMPGPADHJ(T FIGFLJOONIE, U HNJDJNMKFBE, V DNGEIAEKKBO, W JNEGICJFFGC, X MGCANBJCGMI, Y MMANNCDCEPB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3231D80", Offset = "0x3230780", VA = "0x183231D80")]
	public static PKLCNACNNEC<T, U, V, W, X, Y> NGPNDCIKIJI(PKLCNACNNEC<T, U, V, W, X, Y> IEECMNOIJBP, Action<T, U, V, W, X, Y> GMHPLHJININ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3231E10", Offset = "0x3230810", VA = "0x183231E10")]
	public static PKLCNACNNEC<T, U, V, W, X, Y> NMOKAJJFOKB(PKLCNACNNEC<T, U, V, W, X, Y> IEECMNOIJBP, Action<T, U, V, W, X, Y> GMHPLHJININ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CFGJCJKADAM<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly NMMDAMNPPLK<TKey, TVal> HACHKEIDCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> NEDLCHPDMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly int GJHIMMHIIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly NMMDAMNPPLK<TKey, TVal>.KGGPJBMIGAJ? BMPNMPNDABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int BGBLMMFNNFI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int CIOKMDGLOOE
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4AFC450", Offset = "0x4AFAE50", VA = "0x184AFC450")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int PEBBFHGIMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8C1570", Offset = "0x8BFF70", VA = "0x1808C1570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4AFCAD0", Offset = "0x4AFB4D0", VA = "0x184AFCAD0")]
	public CFGJCJKADAM(int GJHIMMHIIAE, [Optional] NMMDAMNPPLK<TKey, TVal>.KGGPJBMIGAJ? BMPNMPNDABA, [Optional] IEqualityComparer<TKey>? BOALFOFGJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4AFC900", Offset = "0x4AFB300", VA = "0x184AFC900")]
	public void PMCPLOGDEHC(TKey FHLJKJHFEEK, TVal BEEGCHJLJFC, bool OKPOIPOILML = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4AFC4A0", Offset = "0x4AFAEA0", VA = "0x184AFC4A0")]
	public bool CKNJHLJMBDO(TKey FHLJKJHFEEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4AFC820", Offset = "0x4AFB220", VA = "0x184AFC820")]
	public bool GFGJHMKHGPD(TKey COLMIMPDLFA, [Out] TVal BEEGCHJLJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4AFC600", Offset = "0x4AFB000", VA = "0x184AFC600")]
	private void FOHNKMBLGJP(TKey FHLJKJHFEEK, TVal BEEGCHJLJFC, int DDIMFHFNGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4AFC2C0", Offset = "0x4AFACC0", VA = "0x184AFC2C0")]
	public bool BMMBMNKBCBG(TKey FHLJKJHFEEK, TVal BEEGCHJLJFC, bool OKPOIPOILML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4AFC540", Offset = "0x4AFAF40", VA = "0x184AFC540")]
	private bool FLKFKOMLBFH(TKey FHLJKJHFEEK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DPEEMNPCLOB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Action BOEDDBEDOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool JIPDFPGDIFP;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7904D0", Offset = "0x78EED0", VA = "0x1807904D0")]
	public DPEEMNPCLOB(Action NLIMNMBLDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x605A610", Offset = "0x6059010", VA = "0x18605A610", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x244FEB0", Offset = "0x244E8B0", VA = "0x18244FEB0")]
	public static OGDBMBLCOHC<T> CMMJGECCMDN<T>(T BEEGCHJLJFC, Action NLIMNMBLDIO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class OGDBMBLCOHC<T> : DPEEMNPCLOB where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T BMLGNHJJEIP
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x793B40", Offset = "0x792540", VA = "0x180793B40")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3F7CA50", Offset = "0x3F7B450", VA = "0x183F7CA50")]
	public OGDBMBLCOHC(T BEEGCHJLJFC, Action NLIMNMBLDIO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct FDBPKJCCENB : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct NDKGHINCDBB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550")]
		public static NDKGHINCDBB KBFODEGLBLG()
		{
			return default(NDKGHINCDBB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550")]
	public static FDBPKJCCENB AHCJGBODPNJ(Type AKDFFJNHJJN, [Optional] string? NHMBAAOOKFK, [Optional] string? KIEEALHDKMG, bool JHAMFAOLINH = false)
	{
		return default(FDBPKJCCENB);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550")]
	public static FDBPKJCCENB AHCJGBODPNJ<T>([Optional] string? NHMBAAOOKFK, [Optional] string? KIEEALHDKMG, bool JHAMFAOLINH = false)
	{
		return default(FDBPKJCCENB);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct MKDPDOBCPKB
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool FGPLPLDFEIE(string OPFJHFMDLEN, MKDPDOBCPKB IMIDLOMPFIK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public int IPDIFFOOAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public string EEEHMJNMPFA;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x605B390", Offset = "0x6059D90", VA = "0x18605B390")]
	public static Dictionary<string, MKDPDOBCPKB> DJDEJBHDICC(Type MLIDIJEPAMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x605B880", Offset = "0x605A280", VA = "0x18605B880")]
	public static Dictionary<string, MKDPDOBCPKB> MFEBJMLCNCI(Type MLIDIJEPAMH, FGPLPLDFEIE MJLCLDNAJDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x605B6C0", Offset = "0x605A0C0", VA = "0x18605B6C0")]
	public static Dictionary<int, string> HFEMMCJKHML(Dictionary<string, MKDPDOBCPKB> DMOGDONOGKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[AttributeUsage(AttributeTargets.Enum)]
public abstract class NNOBCICEKOF : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string POMDKIGIFKL(string NEMNDLOFKLJ);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x79F100", Offset = "0x79DB00", VA = "0x18079F100")]
	protected NNOBCICEKOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class FPFCLMBFIMG : AJOFEFECHPF
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static bool NFBHAEBGJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly string? IPGNDCCOIBE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual AJOFEFECHPF? KJBPEKOOOFG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x78F220", Offset = "0x78DC20", VA = "0x18078F220", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x605AD00", Offset = "0x6059700", VA = "0x18605AD00")]
	protected FPFCLMBFIMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string IIILAEFIJID();

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x605AAC0", Offset = "0x60594C0", VA = "0x18605AAC0", Slot = "8")]
	public virtual string NLNKINJHHLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x605A810", Offset = "0x6059210", VA = "0x18605A810", Slot = "9")]
	public void MCILNIBPILL(StringBuilder ICAJAMAALEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x605A650", Offset = "0x6059050", VA = "0x18605A650", Slot = "10")]
	public void BLFCDGAODLP(StringBuilder ICAJAMAALEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x605ABE0", Offset = "0x60595E0", VA = "0x18605ABE0", Slot = "11")]
	public void PGEIPMMPCCB(StringBuilder ICAJAMAALEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x605A6B0", Offset = "0x60590B0", VA = "0x18605A6B0", Slot = "12")]
	public void DFDBFDIPNIN(StringBuilder ICAJAMAALEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x605AB40", Offset = "0x6059540", VA = "0x18605AB40")]
	public static void PFPCGJKMOIF(StringBuilder ICAJAMAALEK, string CHDNDPFNNGK, string FBENFHBMILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x532DE10", Offset = "0x532C810", VA = "0x18532DE10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class PKHFOKEPJGL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x605C600", Offset = "0x605B000", VA = "0x18605C600")]
	public PKHFOKEPJGL(string BKNCBJIACBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GBAGOHOGNJA<TErr> : PKHFOKEPJGL where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly TErr GNIJILIJNLM;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3699790", Offset = "0x3698190", VA = "0x183699790")]
	private GBAGOHOGNJA([In] TErr CLHOEBMEANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x36996C0", Offset = "0x36980C0", VA = "0x1836996C0")]
	public static GBAGOHOGNJA<TErr> KBFODEGLBLG([In] TErr CLHOEBMEANO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface AJOFEFECHPF
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NLNKINJHHLC();

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string IIILAEFIJID();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface LPEIBOOEBLM<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TOptions BMLGNHJJEIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface BHAGHAMEOPG
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string BPJEFLNLLLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class PIFHCIFFBKF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x605C5A0", Offset = "0x605AFA0", VA = "0x18605C5A0")]
	public PIFHCIFFBKF(string BKNCBJIACBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class NFHENPAJFPD<TOk> : PIFHCIFFBKF where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly TOk OPECOGHKKCC;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3E4E6F0", Offset = "0x3E4D0F0", VA = "0x183E4E6F0")]
	private NFHENPAJFPD([In] TOk BMFABIFILGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x378A4F0", Offset = "0x3788EF0", VA = "0x18378A4F0")]
	public static NFHENPAJFPD<TOk> KBFODEGLBLG([In] TOk BMFABIFILGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct GAFDMEJHKLE<TOk, TErr> : IEquatable<GAFDMEJHKLE<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static readonly EqualityComparer<TErr> CMEDADHPHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly TErr GNIJILIJNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly TOk OPECOGHKKCC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool JKCIFDMJHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3694080", Offset = "0x3692A80", VA = "0x183694080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool FKAOMJNBNHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x3692D40", Offset = "0x3691740", VA = "0x183692D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3696700", Offset = "0x3695100", VA = "0x183696700")]
	internal GAFDMEJHKLE([In] TErr CLHOEBMEANO, [In] TOk BMFABIFILGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3692CE0", Offset = "0x36916E0", VA = "0x183692CE0")]
	public static GAFDMEJHKLE<TOk, TErr> IJNNOCFABAD([In] TErr CLHOEBMEANO)
	{
		return default(GAFDMEJHKLE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x36914D0", Offset = "0x368FED0", VA = "0x1836914D0")]
	public static GAFDMEJHKLE<TOk, TErr> GOMMPOBDHEI([In] TOk BMFABIFILGP)
	{
		return default(GAFDMEJHKLE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2F1BDB0", Offset = "0x2F1A7B0", VA = "0x182F1BDB0")]
	public GAFDMEJHKLE<TOk?, UErr?> DFKDNKPDFEG<UErr>()
	{
		return default(GAFDMEJHKLE<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2F1CBA0", Offset = "0x2F1B5A0", VA = "0x182F1CBA0")]
	public GAFDMEJHKLE<UOk?, TErr?> EDJDOOMFEOG<UOk>()
	{
		return default(GAFDMEJHKLE<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2F1D9C0", Offset = "0x2F1C3C0", VA = "0x182F1D9C0")]
	public GAFDMEJHKLE<UOk?, TErr?> IJPCGGCKJLA<UOk>()
	{
		return default(GAFDMEJHKLE<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2F1CED0", Offset = "0x2F1B8D0", VA = "0x182F1CED0")]
	public GAFDMEJHKLE<TOk?, UErr?> HBLFBOPPBAK<UErr>()
	{
		return default(GAFDMEJHKLE<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3692350", Offset = "0x3690D50", VA = "0x183692350")]
	public GAFDMEJHKLE<NBACEGLOLCA, TErr> IECOPCELAHN()
	{
		return default(GAFDMEJHKLE<NBACEGLOLCA, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3693A30", Offset = "0x3692430", VA = "0x183693A30")]
	public static bool JGKBBKJJNFA([In] GAFDMEJHKLE<TOk, TErr> GHGBJDGFDKJ, [In] GAFDMEJHKLE<TOk, TErr> PHPPILHFFME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3690500", Offset = "0x368EF00", VA = "0x183690500", Slot = "4")]
	public bool Equals(GAFDMEJHKLE<TOk, TErr> CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3690820", Offset = "0x368F220", VA = "0x183690820", Slot = "0")]
	public override bool Equals(object CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x36922A0", Offset = "0x3690CA0", VA = "0x1836922A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3694CE0", Offset = "0x36936E0", VA = "0x183694CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class ADINEDEPJNK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct JKBJAMDFBAA<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Task<GAFDMEJHKLE<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<GAFDMEJHKLE<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3A34970", Offset = "0x3A33370", VA = "0x183A34970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3A34FB0", Offset = "0x3A339B0", VA = "0x183A34FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2C30190", Offset = "0x2C2EB90", VA = "0x182C30190")]
	public static GAFDMEJHKLE<TOk?, TErr?> OPECOGHKKCC<TOk, TErr>([In] this GAFDMEJHKLE<TOk, TErr> JFFAAHPEFOB, [In] TOk BMFABIFILGP)
	{
		return default(GAFDMEJHKLE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2C318D0", Offset = "0x2C302D0", VA = "0x182C318D0")]
	public static GAFDMEJHKLE<NBACEGLOLCA, TErr?> OPECOGHKKCC<TErr>([In] this GAFDMEJHKLE<NBACEGLOLCA, TErr> JFFAAHPEFOB)
	{
		return default(GAFDMEJHKLE<NBACEGLOLCA, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2C30190", Offset = "0x2C2EB90", VA = "0x182C30190")]
	public static GAFDMEJHKLE<TOk?, TErr?> GNIJILIJNLM<TOk, TErr>([In] this GAFDMEJHKLE<TOk, TErr> JFFAAHPEFOB, [In] TErr CLHOEBMEANO)
	{
		return default(GAFDMEJHKLE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2C2F9C0", Offset = "0x2C2E3C0", VA = "0x182C2F9C0")]
	public static TOk? EEBBJPAGMCI<TOk, TErr>([In] this GAFDMEJHKLE<TOk, TErr> JFFAAHPEFOB)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2C31E60", Offset = "0x2C30860", VA = "0x182C31E60")]
	[AsyncStateMachine(typeof(JKBJAMDFBAA<, >))]
	public static Task<TOk?>? PLBIIGHLLNP<TOk, TErr>(this Task<GAFDMEJHKLE<TOk, TErr>> JFFAAHPEFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2C309F0", Offset = "0x2C2F3F0", VA = "0x182C309F0")]
	public static TErr? MNFJHNPKOFP<TErr, TOk>([In] this GAFDMEJHKLE<TOk, TErr> JFFAAHPEFOB)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2C30C00", Offset = "0x2C2F600", VA = "0x182C30C00")]
	public static bool ODHPHIDIGGO<TOk, TErr, UErr, UOk>([In] this GAFDMEJHKLE<TOk, TErr> JFFAAHPEFOB, [Out] GAFDMEJHKLE<UOk, UErr> HEDGGDJCGNN) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2C2F7F0", Offset = "0x2C2E1F0", VA = "0x182C2F7F0")]
	public static bool CLBGBOONAFM<TOk, TErr>([In] this GAFDMEJHKLE<TOk, TErr> JFFAAHPEFOB, [Out][NotNullWhen(true)] TOk BMFABIFILGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2C303B0", Offset = "0x2C2EDB0", VA = "0x182C303B0")]
	public static bool KMAMHLENBEM<TOk, TErr>([In] this GAFDMEJHKLE<TOk, TErr> JFFAAHPEFOB, [Out][NotNullWhen(true)] TErr CLHOEBMEANO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2C2FD60", Offset = "0x2C2E760", VA = "0x182C2FD60")]
	public static bool FJDFOAONOFM<TOk, TErr>([In] this GAFDMEJHKLE<TOk, TErr> JFFAAHPEFOB, [Out][NotNullWhen(true)] TOk BMFABIFILGP, [Out][NotNullWhen(false)] TErr CLHOEBMEANO) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2C302B0", Offset = "0x2C2ECB0", VA = "0x182C302B0")]
	public static bool ICDAHLPCJCE<TOk, TErr>([In] this GAFDMEJHKLE<TOk, TErr> JFFAAHPEFOB, [Out][NotNullWhen(true)] TOk BMFABIFILGP, [Out] GAFDMEJHKLE<TOk, TErr> HEDGGDJCGNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2C30D10", Offset = "0x2C2F710", VA = "0x182C30D10")]
	public static bool ODHPHIDIGGO<TOk, TErr, UErr, UOk>([In] this GAFDMEJHKLE<TOk, TErr> JFFAAHPEFOB, [Out][NotNullWhen(true)] TOk BMFABIFILGP, [Out] GAFDMEJHKLE<UOk, UErr> HEDGGDJCGNN) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2C30560", Offset = "0x2C2EF60", VA = "0x182C30560")]
	public static bool MKKHIEOJDBP<TOk, TErr>([In] this GAFDMEJHKLE<TOk, TErr> JFFAAHPEFOB, [Out][NotNullWhen(true)] TOk BMFABIFILGP, [Out] GAFDMEJHKLE<NBACEGLOLCA, TErr> HEDGGDJCGNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2C31B40", Offset = "0x2C30540", VA = "0x182C31B40")]
	public static GAFDMEJHKLE<UOk, UErr> PIMIJAKMHJC<UOk, UErr, TOk, TErr>([In] this GAFDMEJHKLE<TOk, TErr> JFFAAHPEFOB, [In] GAFDMEJHKLE<UOk, UErr> HNGEGNONPGJ) where TOk : UOk where TErr : UErr
	{
		return default(GAFDMEJHKLE<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2C2FE50", Offset = "0x2C2E850", VA = "0x182C2FE50")]
	public static GAFDMEJHKLE<TOk?[]?, TErr?> GGCMCAFPNDF<TOk, TErr>(this IEnumerable<GAFDMEJHKLE<TOk, TErr>> JFFAAHPEFOB)
	{
		return default(GAFDMEJHKLE<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class IOMNDIMNCCN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x21B8140", Offset = "0x21B6B40", VA = "0x1821B8140")]
	public static GAFDMEJHKLE<TOk, T> OPECOGHKKCC<TOk>([In] TOk BMFABIFILGP) where TOk : notnull
	{
		return default(GAFDMEJHKLE<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3853010", Offset = "0x3851A10", VA = "0x183853010")]
	public static GAFDMEJHKLE<NBACEGLOLCA, T> OPECOGHKKCC()
	{
		return default(GAFDMEJHKLE<NBACEGLOLCA, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x21B8140", Offset = "0x21B6B40", VA = "0x1821B8140")]
	public static GAFDMEJHKLE<T, TErr> GNIJILIJNLM<TErr>([In] TErr CLHOEBMEANO) where TErr : notnull
	{
		return default(GAFDMEJHKLE<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public sealed class AAIALJFPHLB<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private readonly struct PPNDKEEAOAH : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly AAIALJFPHLB<T> IJIBBIFNOGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly int MPCIEDBIMBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly bool LLEPILELDKH;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1C2AF00", Offset = "0x1C29900", VA = "0x181C2AF00")]
		public PPNDKEEAOAH(AAIALJFPHLB<T> DPFABJBBFIB, int GOFOHDMBICH, bool NLLBDADLCPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x40A9C40", Offset = "0x40A8640", VA = "0x1840A9C40")]
		public AAIALJFPHLB<T>.LJBLIKJFCOL DHCNIOBIIDB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x40A9D30", Offset = "0x40A8730", VA = "0x1840A9D30", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x40A9D30", Offset = "0x40A8730", VA = "0x1840A9D30", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class LJBLIKJFCOL : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly AAIALJFPHLB<T> IJIBBIFNOGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly int JBJNFBNPMAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int GMBDMPPMAHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly bool LLEPILELDKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool BENDLPKLMJK;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T POOCAABBIHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x3BED3D0", Offset = "0x3BEBDD0", VA = "0x183BED3D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x3BED580", Offset = "0x3BEBF80", VA = "0x183BED580", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x3BED660", Offset = "0x3BEC060", VA = "0x183BED660", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3BEDA50", Offset = "0x3BEC450", VA = "0x183BEDA50")]
		public LJBLIKJFCOL(AAIALJFPHLB<T> DPFABJBBFIB, int GOFOHDMBICH, bool NLLBDADLCPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3BED490", Offset = "0x3BEBE90", VA = "0x183BED490", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3BED520", Offset = "0x3BEBF20", VA = "0x183BED520", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class CGEOBLLPKFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public CGEOBLLPKFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x4BC5FC0", Offset = "0x4BC49C0", VA = "0x184BC5FC0")]
		internal T EJBGCBEILGG(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly T[] DIDPCNIILEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int GMBDMPPMAHN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int KNFFFGNPKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x363E230", Offset = "0x363CC30", VA = "0x18363E230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T POOCAABBIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x359E040", Offset = "0x359CA40", VA = "0x18359E040")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T JDJFMHPKACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x363E2B0", Offset = "0x363CCB0", VA = "0x18363E2B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T OBNEKGFINAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x363E380", Offset = "0x363CD80", VA = "0x18363E380")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int PPDKOADJGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x16309F0", Offset = "0x162F3F0", VA = "0x1816309F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xF19250", Offset = "0xF17C50", VA = "0x180F19250")]
	private static int IGKJGJAJAPN(int BNALCEABILL, int FJADIACPEIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x363E620", Offset = "0x363D020", VA = "0x18363E620")]
	public AAIALJFPHLB(int DDIMFHFNGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x363E690", Offset = "0x363D090", VA = "0x18363E690")]
	public AAIALJFPHLB(int DDIMFHFNGHG, Func<T> FJLPAAHEMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x363E8B0", Offset = "0x363D2B0", VA = "0x18363E8B0")]
	public AAIALJFPHLB(T[] KGDPBJHHKON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x363E280", Offset = "0x363CC80", VA = "0x18363E280")]
	public void CNAIFIPDEGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x363E4C0", Offset = "0x363CEC0", VA = "0x18363E4C0")]
	public IEnumerable<T> NHMOLKHNKKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x363E430", Offset = "0x363CE30", VA = "0x18363E430")]
	public AAIALJFPHLB<T>.LJBLIKJFCOL DHCNIOBIIDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x35E2840", Offset = "0x35E1240", VA = "0x1835E2840", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x35E2840", Offset = "0x35E1240", VA = "0x1835E2840", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class HBFKMINJNCA
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2613F80", Offset = "0x2612980", VA = "0x182613F80")]
	public static AAIALJFPHLB<T> KBFODEGLBLG<T>(int DDIMFHFNGHG, Func<T> FJLPAAHEMHB) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
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

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1D0D740", Offset = "0x1D0C140", VA = "0x181D0D740")]
		public RRColor(float HJICGNIAELL, float JFKFIJFHHFN, float OIKFNBPLIOK, float PJHMDOOMOBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x605C660", Offset = "0x605B060", VA = "0x18605C660", Slot = "4")]
		public bool Equals(RRColor CGDFJMJIABO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x605C6E0", Offset = "0x605B0E0", VA = "0x18605C6E0", Slot = "0")]
		public override bool Equals(object CGDFJMJIABO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x605C7E0", Offset = "0x605B1E0", VA = "0x18605C7E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x605C860", Offset = "0x605B260", VA = "0x18605C860", Slot = "5")]
		public string ToString(string MPEIKHEGNLM, IFormatProvider FAKCLJDCBDO)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class GGDLBNBBOIN<TData> : FPFCLMBFIMG where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly string LBHIFPJKNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly TData KGACILCCGND;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "7")]
	public override string IIILAEFIJID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x36A1D60", Offset = "0x36A0760", VA = "0x1836A1D60")]
	internal GGDLBNBBOIN(string BKNCBJIACBJ, [In] TData OBAHLGOPPIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class IKEJILBLDBI
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x605AD70", Offset = "0x6059770", VA = "0x18605AD70")]
	public static GGDLBNBBOIN<NBACEGLOLCA> KBFODEGLBLG(string BKNCBJIACBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x244FEB0", Offset = "0x244E8B0", VA = "0x18244FEB0")]
	public static GGDLBNBBOIN<TData> KBFODEGLBLG<TData>(string BKNCBJIACBJ, [In] TData OBAHLGOPPIK) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class BJGCNFFFFJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<object, float> FFHAGOKFHAL;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float BHBNKHNPJJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x89F540", Offset = "0x89DF40", VA = "0x18089F540")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x89F5E0", Offset = "0x89DFE0", VA = "0x18089F5E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x605A370", Offset = "0x6058D70", VA = "0x18605A370")]
	public void FMFEHDPAEEC(float BEEGCHJLJFC, object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x605A510", Offset = "0x6058F10", VA = "0x18605A510")]
	public void PFNDOGOFMHK(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x605A3E0", Offset = "0x6058DE0", VA = "0x18605A3E0")]
	private void NCILCFJHDJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x605A580", Offset = "0x6058F80", VA = "0x18605A580")]
	public BJGCNFFFFJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class ILJHMLMFCJO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class KOJHDNIOLBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public KOJHDNIOLBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3B46560", Offset = "0x3B44F60", VA = "0x183B46560")]
		internal int LEPDHPOJIFB(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private HashSet<T>? LIIMAGANKFB;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public IReadOnlyCollection<T> JAOAIGHFGDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x38471A0", Offset = "0x3845BA0", VA = "0x1838471A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool OPCLEABBEEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3847160", Offset = "0x3845B60", VA = "0x183847160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int MDLNLAAIONI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7977F0", Offset = "0x7961F0", VA = "0x1807977F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x79A7C0", Offset = "0x7991C0", VA = "0x18079A7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3846FB0", Offset = "0x38459B0", VA = "0x183846FB0")]
	public bool DGLLAPEBOKO(T BDAPLOBBPIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3846E90", Offset = "0x3845890", VA = "0x183846E90")]
	public bool BPOFHEGLDCM(T BDAPLOBBPIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3847120", Offset = "0x3845B20", VA = "0x183847120")]
	public bool EODOHENOEFA(T BDAPLOBBPIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x38471D0", Offset = "0x3845BD0", VA = "0x1838471D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public ILJHMLMFCJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class NHJONPEIDPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly string CNGDBDLODCN;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7904D0", Offset = "0x78EED0", VA = "0x1807904D0")]
	public NHJONPEIDPI(string CNGDBDLODCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x605C210", Offset = "0x605AC10", VA = "0x18605C210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class NFHAIGOLJDB
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class PCNBBJOFPEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public PCNBBJOFPEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x605C4F0", Offset = "0x605AEF0", VA = "0x18605C4F0")]
		internal int LEPDHPOJIFB(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private HashSet<object>? LIIMAGANKFB;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<object> JAOAIGHFGDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x605BFD0", Offset = "0x605A9D0", VA = "0x18605BFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool OPCLEABBEEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x605BF50", Offset = "0x605A950", VA = "0x18605BF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int MDLNLAAIONI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7977F0", Offset = "0x7961F0", VA = "0x1807977F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x79A7C0", Offset = "0x7991C0", VA = "0x18079A7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x605BE10", Offset = "0x605A810", VA = "0x18605BE10")]
	public bool DGLLAPEBOKO(object BDAPLOBBPIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x605BD70", Offset = "0x605A770", VA = "0x18605BD70")]
	public bool BPOFHEGLDCM(object BDAPLOBBPIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x605BEF0", Offset = "0x605A8F0", VA = "0x18605BEF0")]
	public bool EODOHENOEFA(object BDAPLOBBPIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x605BF60", Offset = "0x605A960", VA = "0x18605BF60")]
	public void KIBIGADLHBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x605C060", Offset = "0x605AA60", VA = "0x18605C060", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public NFHAIGOLJDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class MPDAHJGADKA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private struct OIEGNJPHBFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public float FDMJPJGHNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public T BMLGNHJJEIP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly Dictionary<object, OIEGNJPHBFC> FFHAGOKFHAL;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public virtual T FJKAHFECGBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xE36470", Offset = "0xE34E70", VA = "0x180E36470", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xE35A50", Offset = "0xE34450", VA = "0x180E35A50", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public object? PGLMIAJCDPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x799000", Offset = "0x797A00", VA = "0x180799000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x79A7B0", Offset = "0x7991B0", VA = "0x18079A7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool DECOLGLKDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3DF9650", Offset = "0x3DF8050", VA = "0x183DF9650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3DF9CB0", Offset = "0x3DF86B0", VA = "0x183DF9CB0")]
	public bool FMFEHDPAEEC(T BEEGCHJLJFC, object BDAPLOBBPIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3DFB860", Offset = "0x3DFA260", VA = "0x183DFB860")]
	public bool PFNDOGOFMHK(object BDAPLOBBPIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3DFB830", Offset = "0x3DFA230", VA = "0x183DFB830")]
	public void JOBLGFAFDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3DFA010", Offset = "0x3DF8A10", VA = "0x183DFA010")]
	public bool GFGJHMKHGPD(object BDAPLOBBPIE, [Out] T BEEGCHJLJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3DFA230", Offset = "0x3DF8C30", VA = "0x183DFA230")]
	[CONGGIJALNK("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool HGPPGCPHOBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3DFB8D0", Offset = "0x3DFA2D0", VA = "0x183DFB8D0")]
	public MPDAHJGADKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface HIHCAKICDFL
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event ODMKDLDFNHM MLOBLDGJIMO;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class ACELFEOAHPF : HIHCAKICDFL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct MCCPDFONFGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly float NGCMLJIFGEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly float JJJCOCMBCDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal readonly bool DAJJFGPBCLH;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float DGFKKGBDDGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x605B0C0", Offset = "0x6059AC0", VA = "0x18605B0C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x605B230", Offset = "0x6059C30", VA = "0x18605B230")]
		public MCCPDFONFGK(float OHBFODPGDGE, float BFAIICDOEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x605B0D0", Offset = "0x6059AD0", VA = "0x18605B0D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class JCNGKIIPEIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public ACELFEOAHPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public JCNGKIIPEIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x605ADF0", Offset = "0x60597F0", VA = "0x18605ADF0")]
		internal void EFOFLILFDHM(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly int HCAPAJGPPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int EIMAEDEHMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly HIHCAKICDFL[] FHFOIJCOFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ODMKDLDFNHM[] OHKJJALONEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly MCCPDFONFGK[] GIDNEKLNHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private MCCPDFONFGK ILPCHBGLJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly KLIINDNHDNO FDBCNLAFINK;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event ODMKDLDFNHM MLOBLDGJIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x60598D0", Offset = "0x60582D0", VA = "0x1860598D0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6059E00", Offset = "0x6058800", VA = "0x186059E00", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6059EC0", Offset = "0x60588C0", VA = "0x186059EC0")]
	public ACELFEOAHPF(int HCAPAJGPPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6059840", Offset = "0x6058240", VA = "0x186059840")]
	public KLIINDNHDNO KEPPBPILAEM(MCCPDFONFGK JIDMDIPLJHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6059990", Offset = "0x6058390", VA = "0x186059990")]
	public void MCFFHEBNFPB(HIHCAKICDFL FFCPGFNCAPM, [Optional] MCCPDFONFGK JEOLELBONNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6059730", Offset = "0x6058130", VA = "0x186059730", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public delegate void ODMKDLDFNHM(float BLPAGNELGPD);
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class OMJIMAJDOMP
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private class PAEOKGNDJJE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly HIHCAKICDFL NKHKBBOKHDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly ODMKDLDFNHM MKEOIOPNPIL;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x605C460", Offset = "0x605AE60", VA = "0x18605C460")]
		public PAEOKGNDJJE(HIHCAKICDFL NKHKBBOKHDA, ODMKDLDFNHM MKEOIOPNPIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x605C410", Offset = "0x605AE10", VA = "0x18605C410", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x605C3A0", Offset = "0x605ADA0", VA = "0x18605C3A0")]
	internal static bool HCCGGAGJGHL(float PJHMDOOMOBI, float OIKFNBPLIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x604E890", Offset = "0x604D290", VA = "0x18604E890")]
	internal static float JFEINEGAGAP(float PJHMDOOMOBI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x605C2E0", Offset = "0x605ACE0", VA = "0x18605C2E0")]
	public static IDisposable GJPOIOKAHAM(this HIHCAKICDFL NKHKBBOKHDA, ODMKDLDFNHM MKEOIOPNPIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class KLIINDNHDNO : HIHCAKICDFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float BLPAGNELGPD;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public float EJBEAIFKAIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x605AE90", Offset = "0x6059890", VA = "0x18605AE90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event ODMKDLDFNHM? MLOBLDGJIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x605AF80", Offset = "0x6059980", VA = "0x18605AF80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x605B020", Offset = "0x6059A20", VA = "0x18605B020", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public KLIINDNHDNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class KGFNCBLOGCD : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5B81CF0", Offset = "0x5B806F0", VA = "0x185B81CF0")]
	public KGFNCBLOGCD(string BKNCBJIACBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[DefaultMember("Item")]
public class PLHDEOEDBPE<TKey, TValue> : FIPIOLDDIKM<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, NGLNIDDFAKA where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class OJGEBALALLC : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public PLHDEOEDBPE<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xE36470", Offset = "0xE34E70", VA = "0x180E36470", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x3F8C120", Offset = "0x3F8AB20", VA = "0x183F8C120", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
		[DebuggerHidden]
		public OJGEBALALLC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x34A9110", Offset = "0x34A7B10", VA = "0x1834A9110", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B7B0", Offset = "0x3F8A1B0", VA = "0x183F8B7B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3F8BF40", Offset = "0x3F8A940", VA = "0x183F8BF40")]
		private void OEKMCAOJCOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B310", Offset = "0x3F89D10", VA = "0x183F8B310")]
		private void ILPGDGAIKKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3F8C030", Offset = "0x3F8AA30", VA = "0x183F8C030", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly FIPIOLDDIKM<TKey, TValue> BPANEEPPPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly IDictionary<TKey, TValue> FFKHLKBBIKC;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int MDLNLAAIONI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x40A1850", Offset = "0x40A0250", VA = "0x1840A1850", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool KNBLDDIDMLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TValue OBNEKGFINAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x40A1A20", Offset = "0x40A0420", VA = "0x1840A1A20", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x40A1C80", Offset = "0x40A0680", VA = "0x1840A1C80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ICollection<TKey> MFKCEJAEENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x40A1A60", Offset = "0x40A0460", VA = "0x1840A1A60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public ICollection<TValue> FLAFNEAGBDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x40A1B70", Offset = "0x40A0570", VA = "0x1840A1B70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x40A16D0", Offset = "0x40A00D0", VA = "0x1840A16D0")]
	public PLHDEOEDBPE(FIPIOLDDIKM<TKey, TValue> BPANEEPPPJC, [Optional] IDictionary<TKey, TValue>? FFKHLKBBIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x409F470", Offset = "0x409DE70", VA = "0x18409F470", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x40A0690", Offset = "0x409F090", VA = "0x1840A0690")]
	public void NKKPOOCDEKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x409EFB0", Offset = "0x409D9B0", VA = "0x18409EFB0", Slot = "9")]
	public void Add(TKey FHLJKJHFEEK, TValue BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x409EB80", Offset = "0x409D580", VA = "0x18409EB80")]
	public void AHIODFPCDIO(TKey FHLJKJHFEEK, TValue BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x409F2C0", Offset = "0x409DCC0", VA = "0x18409F2C0")]
	public void COBACFKCDMN(TKey FHLJKJHFEEK, TValue BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x409FFA0", Offset = "0x409E9A0", VA = "0x18409FFA0")]
	public void EDGFLDPLNJK(TKey FHLJKJHFEEK, TValue BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x40A0430", Offset = "0x409EE30", VA = "0x1840A0430")]
	public void JNONKPKMAIJ(TKey FHLJKJHFEEK, TValue BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x40A0D10", Offset = "0x409F710", VA = "0x1840A0D10", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> PPIDKPHGGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x40A0D50", Offset = "0x409F750", VA = "0x1840A0D50", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> PPIDKPHGGGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x40A1250", Offset = "0x409FC50", VA = "0x1840A1250", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> PPIDKPHGGGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x409F580", Offset = "0x409DF80", VA = "0x18409F580", Slot = "8")]
	public bool ContainsKey(TKey FHLJKJHFEEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x40A0560", Offset = "0x409EF60", VA = "0x1840A0560")]
	public bool KFIDHDPEONO(TKey FHLJKJHFEEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x409FD20", Offset = "0x409E720", VA = "0x18409FD20")]
	public bool DLAJDMIIMLH(TKey FHLJKJHFEEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x40A0A80", Offset = "0x409F480", VA = "0x1840A0A80", Slot = "10")]
	public bool Remove(TKey FHLJKJHFEEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x40A1440", Offset = "0x409FE40", VA = "0x1840A1440", Slot = "11")]
	public bool TryGetValue(TKey FHLJKJHFEEK, [Out] TValue BEEGCHJLJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x409F630", Offset = "0x409E030", VA = "0x18409F630", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] BHNHFMPCKPL, int DOMAOCHEEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x40A1410", Offset = "0x409FE10", VA = "0x1840A1410", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x40A03A0", Offset = "0x409EDA0", VA = "0x1840A03A0", Slot = "19")]
	[IteratorStateMachine(typeof(PLHDEOEDBPE<, >.OJGEBALALLC))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x40A0990", Offset = "0x409F390", VA = "0x1840A0990", Slot = "21")]
	public bool PADIEBKIENO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x40A06E0", Offset = "0x409F0E0", VA = "0x1840A06E0")]
	private TValue OPCNOFNGJCI(TKey FHLJKJHFEEK)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface NGLNIDDFAKA
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PADIEBKIENO();
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface FIPIOLDDIKM<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, NGLNIDDFAKA
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[DefaultMember("Item")]
public sealed class NMMDAMNPPLK<TKey, TVal> : FIPIOLDDIKM<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, NGLNIDDFAKA where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public delegate int KGGPJBMIGAJ(TKey FHLJKJHFEEK, TVal BEEGCHJLJFC);

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private class EIKIDAIFCFG
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public TKey MEIMJOBMJKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xB51900", Offset = "0xB50300", VA = "0x180B51900")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public TVal BMLGNHJJEIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8C1570", Offset = "0x8BFF70", VA = "0x1808C1570")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8C15A0", Offset = "0x8BFFA0", VA = "0x1808C15A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public int DGFKKGBDDGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7CEA20", Offset = "0x7CD420", VA = "0x1807CEA20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x7CE080", Offset = "0x7CCA80", VA = "0x1807CE080")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public DateTimeOffset IMLKFKDODGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xA30D90", Offset = "0xA2F790", VA = "0x180A30D90")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x128D650", Offset = "0x128C050", VA = "0x18128D650")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x324F260", Offset = "0x324DC60", VA = "0x18324F260")]
		public EIKIDAIFCFG(TKey FHLJKJHFEEK, TVal FJNMPOJLNAH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class ELNLCPPFCBD : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NMMDAMNPPLK<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private LinkedList<EIKIDAIFCFG>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xE36470", Offset = "0xE34E70", VA = "0x180E36470", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x3268EF0", Offset = "0x32678F0", VA = "0x183268EF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
		[DebuggerHidden]
		public ELNLCPPFCBD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x3269050", Offset = "0x3267A50", VA = "0x183269050", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x3267450", Offset = "0x3265E50", VA = "0x183267450", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x32689A0", Offset = "0x32673A0", VA = "0x1832689A0")]
		private void OEKMCAOJCOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3268B40", Offset = "0x3267540", VA = "0x183268B40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public const int GGJKKPLMGLK = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<TKey, LinkedListNode<EIKIDAIFCFG>> JHNOPOPGNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly LinkedList<EIKIDAIFCFG> EIJJJMGMMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly KGGPJBMIGAJ? BMPNMPNDABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly TimeSpan KKDLJKDKCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly PMBJACNGGOC NEOJEHKDBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool JJKCPLLMJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly List<TKey> ICFPODFMBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<TVal> GJCKMKBJIHP;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public int PEBBFHGIMPM
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7ADB00", Offset = "0x7AC500", VA = "0x1807ADB00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	internal int CIOKMDGLOOE
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7ADB10", Offset = "0x7AC510", VA = "0x1807ADB10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xE2A070", Offset = "0xE28A70", VA = "0x180E2A070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int MDLNLAAIONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3EB25A0", Offset = "0x3EB0FA0", VA = "0x183EB25A0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	internal int LJFBGACENKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x38B0870", Offset = "0x38AF270", VA = "0x1838B0870")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public ICollection<TVal> FLAFNEAGBDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3EB2740", Offset = "0x3EB1140", VA = "0x183EB2740", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	ICollection<TKey> IDictionary<TKey, TVal>.NJAJKKFAMPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x3EAD250", Offset = "0x3EABC50", VA = "0x183EAD250", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool KNBLDDIDMLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public TVal OBNEKGFINAA
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x3EB2680", Offset = "0x3EB1080", VA = "0x183EB2680", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x3EB2790", Offset = "0x3EB1190", VA = "0x183EB2790", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3EA09A0", Offset = "0x3E9F3A0", VA = "0x183EA09A0")]
	private bool DINHELDPKOE(int HCAPAJGPPGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3EA5B10", Offset = "0x3EA4510", VA = "0x183EA5B10")]
	private void KCBLGHBFLOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3EAF620", Offset = "0x3EAE020", VA = "0x183EAF620")]
	public NMMDAMNPPLK(int HCAPAJGPPGD, [Optional] KGGPJBMIGAJ? BMPNMPNDABA, [Optional] IEqualityComparer<TKey>? BOALFOFGJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3EAF520", Offset = "0x3EADF20", VA = "0x183EAF520")]
	public NMMDAMNPPLK(TimeSpan KKDLJKDKCNK, [Optional] IEqualityComparer<TKey>? BOALFOFGJGA, [Optional] PMBJACNGGOC? NEOJEHKDBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3EAF0E0", Offset = "0x3EADAE0", VA = "0x183EAF0E0")]
	public NMMDAMNPPLK(int HCAPAJGPPGD, TimeSpan KKDLJKDKCNK, [Optional] IEqualityComparer<TKey>? BOALFOFGJGA, [Optional] PMBJACNGGOC? NEOJEHKDBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3EB1DA0", Offset = "0x3EB07A0", VA = "0x183EB1DA0")]
	public NMMDAMNPPLK(int HCAPAJGPPGD, KGGPJBMIGAJ? BMPNMPNDABA, TimeSpan KKDLJKDKCNK, [Optional] IEqualityComparer<TKey>? BOALFOFGJGA, [Optional] PMBJACNGGOC? NEOJEHKDBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3EAB7F0", Offset = "0x3EAA1F0", VA = "0x183EAB7F0", Slot = "21")]
	public bool PADIEBKIENO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3EABCC0", Offset = "0x3EAA6C0", VA = "0x183EABCC0", Slot = "22")]
	public bool PHNJCENNKAH(int DDIMFHFNGHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3E9D5A0", Offset = "0x3E9BFA0", VA = "0x183E9D5A0")]
	private bool BGDANOAMDCF(int DDIMFHFNGHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3EA7EE0", Offset = "0x3EA68E0", VA = "0x183EA7EE0")]
	public void OGNHOBPFCBA(TKey FHLJKJHFEEK, TVal BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3E9B910", Offset = "0x3E9A310", VA = "0x183E9B910", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> PPIDKPHGGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C760", Offset = "0x3E9B160", VA = "0x183E9C760", Slot = "9")]
	public void Add(TKey FHLJKJHFEEK, TVal BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3E9DA50", Offset = "0x3E9C450", VA = "0x183E9DA50", Slot = "8")]
	public bool ContainsKey(TKey FHLJKJHFEEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3EAC540", Offset = "0x3EAAF40", VA = "0x183EAC540", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> PPIDKPHGGGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3EAC250", Offset = "0x3EAAC50", VA = "0x183EAC250", Slot = "10")]
	public bool Remove(TKey FHLJKJHFEEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3EACC50", Offset = "0x3EAB650", VA = "0x183EACC50", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> PPIDKPHGGGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3EA7600", Offset = "0x3EA6000", VA = "0x183EA7600")]
	private bool OBDEGALKEFO(TKey FHLJKJHFEEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3EA0CA0", Offset = "0x3E9F6A0", VA = "0x183EA0CA0")]
	private TVal DKMKPEOPLDE(TKey COLMIMPDLFA)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3EAD650", Offset = "0x3EAC050", VA = "0x183EAD650", Slot = "11")]
	public bool TryGetValue(TKey COLMIMPDLFA, [Out] TVal BEEGCHJLJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3E9D800", Offset = "0x3E9C200", VA = "0x183E9D800", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3E9F5C0", Offset = "0x3E9DFC0", VA = "0x183E9F5C0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] BHNHFMPCKPL, int DOMAOCHEEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3EA69E0", Offset = "0x3EA53E0", VA = "0x183EA69E0")]
	private bool KDOJEDGBNEC(EIKIDAIFCFG DCLHAIFBKNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3EA9EA0", Offset = "0x3EA88A0", VA = "0x183EA9EA0")]
	private void OLACNEMJPJK(LinkedListNode<EIKIDAIFCFG> AHKMKMBAELB, TVal HHMPICIBECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3EA3010", Offset = "0x3EA1A10", VA = "0x183EA3010")]
	private void FMFEHDPAEEC(TKey FHLJKJHFEEK, TVal BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3EA4490", Offset = "0x3EA2E90", VA = "0x183EA4490")]
	private void INCPJFJKMCA(EIKIDAIFCFG DCLHAIFBKNO, TVal HHMPICIBECI, int CNMCHNAHALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3EA3E90", Offset = "0x3EA2890", VA = "0x183EA3E90", Slot = "19")]
	[IteratorStateMachine(typeof(NMMDAMNPPLK<, >.ELNLCPPFCBD))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3EAD280", Offset = "0x3EABC80", VA = "0x183EAD280", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class AFAMBGCFEKM<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class GAEDBHECJGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AFAMBGCFEKM<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public GAEDBHECJGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x368FC60", Offset = "0x368E660", VA = "0x18368FC60")]
		internal Task<TResource> GMPCKCMOCKH(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct CGMPKHEJBNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x4BC89C0", Offset = "0x4BC73C0", VA = "0x184BC89C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x4BC9320", Offset = "0x4BC7D20", VA = "0x184BC9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct NFCPLBMHGAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Action<TResource> cleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3E4C600", Offset = "0x3E4B000", VA = "0x183E4C600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3E4CAC0", Offset = "0x3E4B4C0", VA = "0x183E4CAC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly JBNHFIMENLJ<TId, Task<TResource>> GAOENABHOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> DBKHCLOCNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? OCALKGAENNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Action<TResource>? AHFDMPLCHOK;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x36699E0", Offset = "0x36683E0", VA = "0x1836699E0")]
	public AFAMBGCFEKM(int DKJNPDECMHC = 0, [Optional] IEqualityComparer<TId>? JEFEDDBMDPA, [Optional] Func<TId, CancellationToken, Task<TResource>>? GFLONFHJKDG, [Optional] Action<TResource>? BEAMBMFOBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3668950", Offset = "0x3667350", VA = "0x183668950")]
	public OGDBMBLCOHC<Task<TResource>> AEPBGAAHILM(TId KABOEEEDCAB, [Optional] Func<TId, CancellationToken, Task<TResource>>? GFLONFHJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3668EC0", Offset = "0x36678C0", VA = "0x183668EC0")]
	private void BCPFFKDHKBH(Task<TResource> HGLNIMPGIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3669120", Offset = "0x3667B20", VA = "0x183669120")]
	public void FMNGMEKFFJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x36690B0", Offset = "0x3667AB0", VA = "0x1836690B0")]
	public JBNHFIMENLJ<TId, Task<TResource>>.AJKPOABGANN DHCNIOBIIDB()
	{
		return default(JBNHFIMENLJ<TId, Task<TResource>>.AJKPOABGANN);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3669940", Offset = "0x3668340", VA = "0x183669940", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3669940", Offset = "0x3668340", VA = "0x183669940", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x36695B0", Offset = "0x3667FB0", VA = "0x1836695B0")]
	[AsyncStateMachine(typeof(AFAMBGCFEKM<, >.CGMPKHEJBNP))]
	[CompilerGenerated]
	internal static Task NPELMKLKKJN(Task<TResource> HGLNIMPGIKP, CancellationTokenSource GDCBHPOAGGM, Dictionary<Task<TResource>, CancellationTokenSource> GJLMHGEFFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3669370", Offset = "0x3667D70", VA = "0x183669370")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(AFAMBGCFEKM<, >.NFCPLBMHGAE))]
	internal static Task JGMMCCPLDEL(Task<TResource> HGLNIMPGIKP, Action<TResource> KFBFHPCFMOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class JBNHFIMENLJ<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class HGFLNBGCKDC : IEquatable<HGFLNBGCKDC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TValue BMLGNHJJEIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int JLOCHDOMHKP;

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x1BAE600", Offset = "0x1BAD000", VA = "0x181BAE600")]
		public HGFLNBGCKDC(TValue BEEGCHJLJFC, int GNDICOBIJFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x36F3E10", Offset = "0x36F2810", VA = "0x1836F3E10", Slot = "4")]
		public bool Equals(HGFLNBGCKDC? CGDFJMJIABO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x36F3D70", Offset = "0x36F2770", VA = "0x1836F3D70", Slot = "0")]
		public override bool Equals(object? GKNPKJAGNGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x36F3EA0", Offset = "0x36F28A0", VA = "0x1836F3EA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct AJKPOABGANN : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private Dictionary<TKey, HGFLNBGCKDC>.Enumerator AELIGHNGCIJ;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x37666C0", Offset = "0x37650C0", VA = "0x1837666C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public (TKey Key, TValue Value, int RefCount) POOCAABBIHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x3766B00", Offset = "0x3765500", VA = "0x183766B00", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3766A40", Offset = "0x3765440", VA = "0x183766A40")]
		public AJKPOABGANN(JBNHFIMENLJ<TKey, TValue> FFHAGOKFHAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x37663B0", Offset = "0x3764DB0", VA = "0x1837663B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3766430", Offset = "0x3764E30", VA = "0x183766430", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3766560", Offset = "0x3764F60", VA = "0x183766560", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class LFIDNOMJPPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public JBNHFIMENLJ<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public HGFLNBGCKDC refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public LFIDNOMJPPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3BCBE40", Offset = "0x3BCA840", VA = "0x183BCBE40")]
		internal void GMPCKCMOCKH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Dictionary<TKey, HGFLNBGCKDC> FAGIELIEEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Func<TKey, TValue>? AIHLHAJANBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly Action<TValue>? JNFCMKAJENG;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x39F02D0", Offset = "0x39EECD0", VA = "0x1839F02D0")]
	public JBNHFIMENLJ(int DKJNPDECMHC = 0, [Optional] IEqualityComparer<TKey>? BOALFOFGJGA, [Optional] Func<TKey, TValue>? KBFPCMJCJFJ, [Optional] Action<TValue>? EGPMJFAKKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x39EEF20", Offset = "0x39ED920", VA = "0x1839EEF20")]
	public OGDBMBLCOHC<TValue> AEPBGAAHILM(TKey FHLJKJHFEEK, [Optional] Func<TKey, TValue>? JJGPGMEKBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x39EFF20", Offset = "0x39EE920", VA = "0x1839EFF20")]
	private void KHFIPNFMONP(TKey FHLJKJHFEEK, HGFLNBGCKDC DFDLKILKAGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x39EFA40", Offset = "0x39EE440", VA = "0x1839EFA40")]
	public void FMNGMEKFFJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x39EF7A0", Offset = "0x39EE1A0", VA = "0x1839EF7A0")]
	public AJKPOABGANN DHCNIOBIIDB()
	{
		return default(AJKPOABGANN);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x39F0190", Offset = "0x39EEB90", VA = "0x1839F0190", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x39F0190", Offset = "0x39EEB90", VA = "0x1839F0190", Slot = "5")]
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
