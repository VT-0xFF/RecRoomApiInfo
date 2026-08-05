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
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75BF910", Offset = "0x75BE510", VA = "0x1875BF910")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9836D0", Offset = "0x9822D0", VA = "0x1809836D0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x983710", Offset = "0x982310", VA = "0x180983710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class CJNMGIOIMHH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	protected CJNMGIOIMHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class NLNKFFOHOHH<T> : CJNMGIOIMHH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct CGLJFDILGED
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum KACJAPPJEJB
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
		public KACJAPPJEJB ADFFEBFOCBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T OAGMINHECCA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int NLODLIEGOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool JHDKOGLCELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool KNFBIDBPEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? MBLHEHBMBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<CGLJFDILGED>? LGHBBLFJJFI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MABPICMPNML
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4E5E200", Offset = "0x4E5CE00", VA = "0x184E5E200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4E5E800", Offset = "0x4E5D400", VA = "0x184E5E800")]
	protected NLNKFFOHOHH(bool KNFBIDBPEJM, bool JHDKOGLCELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4E5DD60", Offset = "0x4E5C960", VA = "0x184E5DD60")]
	protected bool AJMPPBCBCNF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4E5E6D0", Offset = "0x4E5D2D0", VA = "0x184E5E6D0")]
	protected void OJDDDLLPMFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4E5E270", Offset = "0x4E5CE70", VA = "0x184E5E270")]
	protected void LLDGAHHMNMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x37F2B00", Offset = "0x37F1700", VA = "0x1837F2B00")]
	private static void AEIAMGHKPAE<U>(List<U>? DGHHCPPFODF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4E5DFE0", Offset = "0x4E5CBE0", VA = "0x184E5DFE0", Slot = "4")]
	public void GFCJDEIJPEO(T OAGMINHECCA, bool MDLFFEOHDFN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4E5DE00", Offset = "0x4E5CA00", VA = "0x184E5DE00", Slot = "5")]
	public void BLAPNJAELFA(T OAGMINHECCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4E5E510", Offset = "0x4E5D110", VA = "0x184E5E510")]
	public void NGMONOEHMBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class NCEKLMPIJLO : NLNKFFOHOHH<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x75BF8B0", Offset = "0x75BE4B0", VA = "0x1875BF8B0")]
	public NCEKLMPIJLO(bool KNFBIDBPEJM = false, bool JHDKOGLCELP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x75BF5F0", Offset = "0x75BE1F0", VA = "0x1875BF5F0")]
	public void AOKANKCOAFH()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x75BF850", Offset = "0x75BE450", VA = "0x1875BF850")]
	public static NCEKLMPIJLO OMKCABOBHEN(NCEKLMPIJLO DGABKNOGMCF, Action OAGMINHECCA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x75BF7F0", Offset = "0x75BE3F0", VA = "0x1875BF7F0")]
	public static NCEKLMPIJLO DKLAMPGKIHJ(NCEKLMPIJLO DGABKNOGMCF, Action OAGMINHECCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AJDFNKPFMCF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFCJDEIJPEO(Action<T> OAGMINHECCA, bool MDLFFEOHDFN = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BLAPNJAELFA(Action<T> OAGMINHECCA);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class ONIGKBMFFEH<T> : NLNKFFOHOHH<Action<T>>, AJDFNKPFMCF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4498400", Offset = "0x4497000", VA = "0x184498400")]
	public ONIGKBMFFEH(bool KNFBIDBPEJM = false, bool JHDKOGLCELP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4F97B50", Offset = "0x4F96750", VA = "0x184F97B50")]
	public void AOKANKCOAFH(T LDIBCOFKEDC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4A85260", Offset = "0x4A83E60", VA = "0x184A85260")]
	public static ONIGKBMFFEH<T> OMKCABOBHEN(ONIGKBMFFEH<T> DGABKNOGMCF, Action<T> OAGMINHECCA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4A851C0", Offset = "0x4A83DC0", VA = "0x184A851C0")]
	public static ONIGKBMFFEH<T> DKLAMPGKIHJ(ONIGKBMFFEH<T> DGABKNOGMCF, Action<T> OAGMINHECCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ODFKPJBJNGD<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFCJDEIJPEO(Action<T, U> OAGMINHECCA, bool MDLFFEOHDFN = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BLAPNJAELFA(Action<T, U> OAGMINHECCA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class NFIBJPEHBKM<T, U> : NLNKFFOHOHH<Action<T, U>>, ODFKPJBJNGD<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4498400", Offset = "0x4497000", VA = "0x184498400")]
	public NFIBJPEHBKM(bool KNFBIDBPEJM = false, bool JHDKOGLCELP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4DF5A20", Offset = "0x4DF4620", VA = "0x184DF5A20")]
	public void AOKANKCOAFH(T LDIBCOFKEDC, U OMBNEFEMFLL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4A85260", Offset = "0x4A83E60", VA = "0x184A85260")]
	public static NFIBJPEHBKM<T, U> OMKCABOBHEN(NFIBJPEHBKM<T, U> DGABKNOGMCF, Action<T, U> OAGMINHECCA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4A851C0", Offset = "0x4A83DC0", VA = "0x184A851C0")]
	public static NFIBJPEHBKM<T, U> DKLAMPGKIHJ(NFIBJPEHBKM<T, U> DGABKNOGMCF, Action<T, U> OAGMINHECCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class MJGEHAGLALK<T, U, V> : NLNKFFOHOHH<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4498400", Offset = "0x4497000", VA = "0x184498400")]
	public MJGEHAGLALK(bool KNFBIDBPEJM = false, bool JHDKOGLCELP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4D75780", Offset = "0x4D74380", VA = "0x184D75780")]
	public void AOKANKCOAFH(T LDIBCOFKEDC, U OMBNEFEMFLL, V FABNDDIHAPL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4A85260", Offset = "0x4A83E60", VA = "0x184A85260")]
	public static MJGEHAGLALK<T, U, V> OMKCABOBHEN(MJGEHAGLALK<T, U, V> DGABKNOGMCF, Action<T, U, V> OAGMINHECCA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4A851C0", Offset = "0x4A83DC0", VA = "0x184A851C0")]
	public static MJGEHAGLALK<T, U, V> DKLAMPGKIHJ(MJGEHAGLALK<T, U, V> DGABKNOGMCF, Action<T, U, V> OAGMINHECCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JANELPPLEDO<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class OFENBOMJAPG<T, U, V, W> : NLNKFFOHOHH<Action<T, U, V, W>>, JANELPPLEDO<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4498400", Offset = "0x4497000", VA = "0x184498400")]
	public OFENBOMJAPG(bool KNFBIDBPEJM = false, bool JHDKOGLCELP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4F769E0", Offset = "0x4F755E0", VA = "0x184F769E0")]
	public void AOKANKCOAFH(T LDIBCOFKEDC, U OMBNEFEMFLL, V FABNDDIHAPL, W NMGALFAJFCN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4A85260", Offset = "0x4A83E60", VA = "0x184A85260")]
	public static OFENBOMJAPG<T, U, V, W> OMKCABOBHEN(OFENBOMJAPG<T, U, V, W> DGABKNOGMCF, Action<T, U, V, W> OAGMINHECCA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4A851C0", Offset = "0x4A83DC0", VA = "0x184A851C0")]
	public static OFENBOMJAPG<T, U, V, W> DKLAMPGKIHJ(OFENBOMJAPG<T, U, V, W> DGABKNOGMCF, Action<T, U, V, W> OAGMINHECCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class KOIHDMINGHM<T, U, V, W, X> : NLNKFFOHOHH<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4498400", Offset = "0x4497000", VA = "0x184498400")]
	public KOIHDMINGHM(bool KNFBIDBPEJM = false, bool JHDKOGLCELP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4A84A30", Offset = "0x4A83630", VA = "0x184A84A30")]
	public void AOKANKCOAFH(T LDIBCOFKEDC, U OMBNEFEMFLL, V FABNDDIHAPL, W NMGALFAJFCN, X MDFKHKOGFDI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4A85260", Offset = "0x4A83E60", VA = "0x184A85260")]
	public static KOIHDMINGHM<T, U, V, W, X> OMKCABOBHEN(KOIHDMINGHM<T, U, V, W, X> DGABKNOGMCF, Action<T, U, V, W, X> OAGMINHECCA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4A851C0", Offset = "0x4A83DC0", VA = "0x184A851C0")]
	public static KOIHDMINGHM<T, U, V, W, X> DKLAMPGKIHJ(KOIHDMINGHM<T, U, V, W, X> DGABKNOGMCF, Action<T, U, V, W, X> OAGMINHECCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class DCPOFOFPCHN<T, U, V, W, X, Y> : NLNKFFOHOHH<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4498400", Offset = "0x4497000", VA = "0x184498400")]
	public DCPOFOFPCHN(bool KNFBIDBPEJM = false, bool JHDKOGLCELP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x62F8210", Offset = "0x62F6E10", VA = "0x1862F8210")]
	public void AOKANKCOAFH(T LDIBCOFKEDC, U OMBNEFEMFLL, V FABNDDIHAPL, W NMGALFAJFCN, X MDFKHKOGFDI, Y ELJEANFLEPB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4A85260", Offset = "0x4A83E60", VA = "0x184A85260")]
	public static DCPOFOFPCHN<T, U, V, W, X, Y> OMKCABOBHEN(DCPOFOFPCHN<T, U, V, W, X, Y> DGABKNOGMCF, Action<T, U, V, W, X, Y> OAGMINHECCA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4A851C0", Offset = "0x4A83DC0", VA = "0x184A851C0")]
	public static DCPOFOFPCHN<T, U, V, W, X, Y> DKLAMPGKIHJ(DCPOFOFPCHN<T, U, V, W, X, Y> DGABKNOGMCF, Action<T, U, V, W, X, Y> OAGMINHECCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GCOJFPDACPP<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly MJFHCEFLNCG<TKey, TVal> FNCNLKBNKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> JABBGDJAPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly MJFHCEFLNCG<TKey, TVal>.FMMEFPIMJJP? JBOOMNDADPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int IHLPKAFNHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MJFHCEFLNCG<TKey, TVal>.CBEJAIEGICM? CMHHGPNFEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int PCMKEKADEOL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int NNBJBDMDAHF
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x44BD1B0", Offset = "0x44BBDB0", VA = "0x1844BD1B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int ACBNPOKAKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x95B840", Offset = "0x95A440", VA = "0x18095B840")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x44BE430", Offset = "0x44BD030", VA = "0x1844BE430")]
	public GCOJFPDACPP(int IHLPKAFNHKJ, [Optional] MJFHCEFLNCG<TKey, TVal>.CBEJAIEGICM? CMHHGPNFEKI, [Optional] IEqualityComparer<TKey>? FMNEKIDPBFC, [Optional] MJFHCEFLNCG<TKey, TVal>.FMMEFPIMJJP? JBOOMNDADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x44BD510", Offset = "0x44BC110", VA = "0x1844BD510")]
	public void FHGFEIKOHLF(TKey NKANGPLHEGE, TVal MPDLOLIOGJL, bool CGCPELJKAOE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x44BE2C0", Offset = "0x44BCEC0", VA = "0x1844BE2C0")]
	public bool PDCEOBKHEGI(TKey NKANGPLHEGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x44BE110", Offset = "0x44BCD10", VA = "0x1844BE110")]
	public bool JLHCCLDIOMP(TKey OJEMGKJCJDB, [Out] TVal MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x44BDE30", Offset = "0x44BCA30", VA = "0x1844BDE30")]
	private void IEINMLFNEJO(TKey NKANGPLHEGE, TVal MPDLOLIOGJL, int FJJGAGKDECJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x44BD340", Offset = "0x44BBF40", VA = "0x1844BD340")]
	public bool FAMIDBFGAMK(TKey NKANGPLHEGE, TVal MPDLOLIOGJL, bool CGCPELJKAOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x44BE210", Offset = "0x44BCE10", VA = "0x1844BE210")]
	public void NGMONOEHMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x44BD890", Offset = "0x44BC490", VA = "0x1844BD890")]
	private void HIIACMJJFJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x44BD060", Offset = "0x44BBC60", VA = "0x1844BD060")]
	private bool BGLJPKOLBEN(TKey NKANGPLHEGE, EBMFEFMGONK NCKCEGPNPKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x44BD210", Offset = "0x44BBE10", VA = "0x1844BD210")]
	private void DOBFLBNGPAP(TKey NKANGPLHEGE, TVal MPDLOLIOGJL, EBMFEFMGONK NCKCEGPNPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x44BD760", Offset = "0x44BC360", VA = "0x1844BD760")]
	private void FPIDGAKFOON(TKey NKANGPLHEGE, TVal ODFJOPDFEGP, EBMFEFMGONK NCKCEGPNPKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class OKMNIMNLNAD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action DEIPKCACFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool LHMDIBMGEPK;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	public OKMNIMNLNAD(Action IMIFPEHACLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x75BF990", Offset = "0x75BE590", VA = "0x1875BF990", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x30E9000", Offset = "0x30E7C00", VA = "0x1830E9000")]
	public static PAGNEAPPJJN<T> EPPBBCFCJMI<T>(T MPDLOLIOGJL, Action IMIFPEHACLF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class PAGNEAPPJJN<T> : OKMNIMNLNAD where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T GNLOKINMAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5031DC0", Offset = "0x50309C0", VA = "0x185031DC0")]
	public PAGNEAPPJJN(T MPDLOLIOGJL, Action IMIFPEHACLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class FDIOKGMPAOD<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly NFPCBEPIHKK<T>? IHBPJIICOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> IDDDMCHGCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool LHMDIBMGEPK;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly FDIOKGMPAOD<T> PCKMBPNMICK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> LOAAAOINGCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x438E320", Offset = "0x438CF20", VA = "0x18438E320")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long FMELMONACEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x438E820", Offset = "0x438D420", VA = "0x18438E820")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool OIEJENPKAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x438E9A0", Offset = "0x438D5A0", VA = "0x18438E9A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x438EC60", Offset = "0x438D860", VA = "0x18438EC60")]
	public FDIOKGMPAOD(NFPCBEPIHKK<T> EHDGFKOKBBC, NFPCBEPIHKK<T> KPHEOEPBCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x438ED60", Offset = "0x438D960", VA = "0x18438ED60")]
	public FDIOKGMPAOD(NFPCBEPIHKK<T> EHDGFKOKBBC, int PKAJCFBDMNB, NFPCBEPIHKK<T> KPHEOEPBCMH, int CHBFPOHEPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x438EBB0", Offset = "0x438D7B0", VA = "0x18438EBB0")]
	private FDIOKGMPAOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x438E5A0", Offset = "0x438D1A0", VA = "0x18438E5A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x438E420", Offset = "0x438D020", VA = "0x18438E420")]
	public T[] DLCEHOIGCOP()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x438E630", Offset = "0x438D230", VA = "0x18438E630")]
	public static ReadOnlySequence<T> NIBCGLOMJGK(FDIOKGMPAOD<T>? FJOBJOGFMDF)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct AEHCGFGPDIG : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct OJEMKKFOICH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50")]
		public static OJEMKKFOICH JPHABLICNHB()
		{
			return default(OJEMKKFOICH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x75BC1D0", Offset = "0x75BADD0", VA = "0x1875BC1D0")]
	public static string MPLKNPNPADM(Type ADFFEBFOCBD, [Optional] string? HAKKGDBKAEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB3C0", Offset = "0x3AB9FC0", VA = "0x183ABB3C0")]
	public static string? MPLKNPNPADM<T>([Optional] string? HAKKGDBKAEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB440", Offset = "0x3ABA040", VA = "0x183ABB440")]
	public static string? PICIPNFHJID<T>([Optional] string? BPJPONLDPFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50")]
	public static AEHCGFGPDIG HOIGFCMABAE(string HAKKGDBKAEL, string? BPJPONLDPFN)
	{
		return default(AEHCGFGPDIG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct JJHGKOMIDDI
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool PKGAPPJBDDE(string FKJLMLDBNCF, JJHGKOMIDDI JDNKEHJDKLG);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class KBOHPPCOKED<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public KBOHPPCOKED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4A06620", Offset = "0x4A05220", VA = "0x184A06620")]
		internal void BEJOHOFGLEJ(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int HLFIFJFGNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string FELBGJKBFNI;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x75BDCC0", Offset = "0x75BC8C0", VA = "0x1875BDCC0")]
	public static Dictionary<string, JJHGKOMIDDI> JKNKJGEKKIF(Type APCFGFMDKAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x33FC290", Offset = "0x33FAE90", VA = "0x1833FC290")]
	public static Dictionary<string, JJHGKOMIDDI> JKNKJGEKKIF<T>(Type APCFGFMDKAP, IReadOnlyDictionary<T, string> CHJGDIMCLNL) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x33FBB10", Offset = "0x33FA710", VA = "0x1833FBB10")]
	public static Dictionary<string, JJHGKOMIDDI> DFEBOPBHOEA<T>(List<T> PPPGJPILGDI) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x75BD900", Offset = "0x75BC500", VA = "0x1875BD900")]
	public static Dictionary<string, JJHGKOMIDDI> JKHENHDOBKL(Type APCFGFMDKAP, PKGAPPJBDDE FIDALFMCOLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x75BDFF0", Offset = "0x75BCBF0", VA = "0x1875BDFF0")]
	public static Dictionary<int, string> LPOOMNGLCGN(Dictionary<string, JJHGKOMIDDI> BIKFHOMEEFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class KLJHHNJNNDG : PKJJHJMDMCJ
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool PCBCLOPMOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? PLHKCCEHOGG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual PKJJHJMDMCJ? ACBMIEHDCHK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x75BEAB0", Offset = "0x75BD6B0", VA = "0x1875BEAB0")]
	protected KLJHHNJNNDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string CNPDCBKGCII();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x75BE410", Offset = "0x75BD010", VA = "0x1875BE410", Slot = "8")]
	public virtual string EBCGLFPNDKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x75BE6B0", Offset = "0x75BD2B0", VA = "0x1875BE6B0", Slot = "9")]
	public void PGJIOMEEKFA(StringBuilder EJJJGIHKAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x75BE5B0", Offset = "0x75BD1B0", VA = "0x1875BE5B0", Slot = "10")]
	public void MPOGBDIJJOO(StringBuilder EJJJGIHKAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x75BE490", Offset = "0x75BD090", VA = "0x1875BE490", Slot = "11")]
	public void GHCJHJNBHAN(StringBuilder EJJJGIHKAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x75BE950", Offset = "0x75BD550", VA = "0x1875BE950", Slot = "12")]
	public void PMCLHJMEJMN(StringBuilder EJJJGIHKAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x75BE610", Offset = "0x75BD210", VA = "0x1875BE610")]
	public static void OGMLJLBGHFF(StringBuilder EJJJGIHKAMI, string EOKNCNFEICP, string EKDLPCLAOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x66AB570", Offset = "0x66AA170", VA = "0x1866AB570", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ECACGANHFNF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x75BCD50", Offset = "0x75BB950", VA = "0x1875BCD50")]
	public ECACGANHFNF(string KBPDEFFIKOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PEEHCHBHNFD<TErr> : ECACGANHFNF where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr IPOKKICBHFM;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x503F8F0", Offset = "0x503E4F0", VA = "0x18503F8F0")]
	private PEEHCHBHNFD([In] TErr HPKHNOHBLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x503F810", Offset = "0x503E410", VA = "0x18503F810")]
	public static PEEHCHBHNFD<TErr> JPHABLICNHB([In] TErr HPKHNOHBLEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FBEPNCGCPKH : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm BBGGHBMPHCG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool LJHJLIAKMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool DHHGCJEOOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool KJAOOIDJINC
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long FMELMONACEH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x75BD190", Offset = "0x75BBD90", VA = "0x1875BD190", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long JCCKFLFINHG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x75BD200", Offset = "0x75BBE00", VA = "0x1875BD200", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x75BD270", Offset = "0x75BBE70", VA = "0x1875BD270", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x75BD120", Offset = "0x75BBD20", VA = "0x1875BD120")]
	public FBEPNCGCPKH(HashAlgorithm BBGGHBMPHCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x75BCF50", Offset = "0x75BBB50", VA = "0x1875BCF50", Slot = "35")]
	public override int Read(byte[] IOKDPJEDBMO, int KKHFKGIPICC, int EBDKDADIOBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x75BD0F0", Offset = "0x75BBCF0", VA = "0x1875BD0F0", Slot = "38")]
	public override void Write(byte[] IOKDPJEDBMO, int KKHFKGIPICC, int EBDKDADIOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x75BCFF0", Offset = "0x75BBBF0", VA = "0x1875BCFF0", Slot = "33")]
	public override long Seek(long KKHFKGIPICC, SeekOrigin FIJLHFKGIID)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x75BD080", Offset = "0x75BBC80", VA = "0x1875BD080", Slot = "34")]
	public override void SetLength(long MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x75BCE80", Offset = "0x75BBA80", VA = "0x1875BCE80")]
	public byte[] NLKLAGANLON()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface PKJJHJMDMCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string EBCGLFPNDKC();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string CNPDCBKGCII();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DPCFKGHKDMH<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions GNLOKINMAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface FBDCJPOMEAM
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string OABFIBKHBPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class NFPCBEPIHKK<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static NFPCBEPIHKK<T>? NOPLIGAFJBP;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object EHNOAKHMBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? BCBLOJOGOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool LHMDIBMGEPK;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool LIANHAMAEMH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xC22580", Offset = "0xC21180", VA = "0x180C22580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4DFBC30", Offset = "0x4DFA830", VA = "0x184DFBC30")]
	private static NFPCBEPIHKK<T> KOHKIBPPIFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4DFAF10", Offset = "0x4DF9B10", VA = "0x184DFAF10")]
	private static void EBCNMPFCMBG(NFPCBEPIHKK<T> PBMECKPMDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x471FD80", Offset = "0x471E980", VA = "0x18471FD80")]
	private NFPCBEPIHKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4DFB730", Offset = "0x4DFA330", VA = "0x184DFB730")]
	public static NFPCBEPIHKK<T> EPPBBCFCJMI(ReadOnlyMemory<T> HHGIEJIAPGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4DFB510", Offset = "0x4DFA110", VA = "0x184DFB510")]
	public static NFPCBEPIHKK<T> EPPBBCFCJMI(IMemoryOwner<T> AAJBOEGGILN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4DFBAF0", Offset = "0x4DFA6F0", VA = "0x184DFBAF0")]
	public static void JMMCJLPDLMJ(NFPCBEPIHKK<T> EHDGFKOKBBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4DFA9F0", Offset = "0x4DF95F0", VA = "0x184DFA9F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4DFC110", Offset = "0x4DFAD10", VA = "0x184DFC110")]
	public NFPCBEPIHKK<T> LCFOPMOMLEC(IMemoryOwner<T> AAJBOEGGILN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4DFC330", Offset = "0x4DFAF30", VA = "0x184DFC330")]
	private void PFLHNKBPEJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4DFA890", Offset = "0x4DF9490", VA = "0x184DFA890")]
	private NFPCBEPIHKK<T> DNJAANCMGBP(NFPCBEPIHKK<T> PBMECKPMDAI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class NCDFAGLLIJN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x75BF590", Offset = "0x75BE190", VA = "0x1875BF590")]
	public NCDFAGLLIJN(string KBPDEFFIKOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class MNBCLPALLIA<TOk> : NCDFAGLLIJN where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk MDIOOLKKNEH;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4D8BB80", Offset = "0x4D8A780", VA = "0x184D8BB80")]
	private MNBCLPALLIA([In] TOk CAHOCEGPEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x44BEA30", Offset = "0x44BD630", VA = "0x1844BEA30")]
	public static MNBCLPALLIA<TOk> JPHABLICNHB([In] TOk CAHOCEGPEMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct PNJEPLMEKHI<TOk, TErr> : IEquatable<PNJEPLMEKHI<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly EqualityComparer<TErr> LFNHPPJGEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal readonly TErr IPOKKICBHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal readonly TOk MDIOOLKKNEH;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool PNCNEOMIDEN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5080690", Offset = "0x507F290", VA = "0x185080690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool EMIOGIPBDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5080A00", Offset = "0x507F600", VA = "0x185080A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5082CA0", Offset = "0x50818A0", VA = "0x185082CA0")]
	internal PNJEPLMEKHI([In] TErr HPKHNOHBLEL, [In] TOk CAHOCEGPEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x507FA50", Offset = "0x507E650", VA = "0x18507FA50")]
	public static PNJEPLMEKHI<TOk, TErr> LPICLDKKAGI([In] TErr HPKHNOHBLEL)
	{
		return default(PNJEPLMEKHI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x507FF80", Offset = "0x507EB80", VA = "0x18507FF80")]
	public static PNJEPLMEKHI<TOk, TErr> NCHLJNFIGML([In] TOk CAHOCEGPEMJ)
	{
		return default(PNJEPLMEKHI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3964E60", Offset = "0x3963A60", VA = "0x183964E60")]
	public PNJEPLMEKHI<TOk?, UErr?> KKNDEMJGBAF<UErr>()
	{
		return default(PNJEPLMEKHI<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3965DE0", Offset = "0x39649E0", VA = "0x183965DE0")]
	public PNJEPLMEKHI<UOk?, TErr?> MHGEMEDNFOE<UOk>()
	{
		return default(PNJEPLMEKHI<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3963DF0", Offset = "0x39629F0", VA = "0x183963DF0")]
	public PNJEPLMEKHI<UOk?, TErr?> JPKILNHNEFA<UOk>()
	{
		return default(PNJEPLMEKHI<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3963AB0", Offset = "0x39626B0", VA = "0x183963AB0")]
	public PNJEPLMEKHI<TOk?, UErr?> EHLHPGDPEIF<UErr>()
	{
		return default(PNJEPLMEKHI<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x507D580", Offset = "0x507C180", VA = "0x18507D580")]
	public PNJEPLMEKHI<BODKGJBCKHC, TErr> FAHPOOKBNBM()
	{
		return default(PNJEPLMEKHI<BODKGJBCKHC, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x507EE70", Offset = "0x507DA70", VA = "0x18507EE70")]
	public static bool LBLECGDECIN([In] PNJEPLMEKHI<TOk, TErr> NFOAKNOEKCL, [In] PNJEPLMEKHI<TOk, TErr> AFFPJGJMKFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x507C850", Offset = "0x507B450", VA = "0x18507C850", Slot = "4")]
	public bool Equals(PNJEPLMEKHI<TOk, TErr> PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x507CE40", Offset = "0x507BA40", VA = "0x18507CE40", Slot = "0")]
	public override bool Equals(object PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x507D9A0", Offset = "0x507C5A0", VA = "0x18507D9A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5080DF0", Offset = "0x507F9F0", VA = "0x185080DF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class JMONJAEHBOB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct FIOPEIKFMDA<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Task<PNJEPLMEKHI<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<PNJEPLMEKHI<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4410F30", Offset = "0x440FB30", VA = "0x184410F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x4411270", Offset = "0x440FE70", VA = "0x184411270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x34039B0", Offset = "0x34025B0", VA = "0x1834039B0")]
	public static PNJEPLMEKHI<TOk?, TErr?> MDIOOLKKNEH<TOk, TErr>([In] this PNJEPLMEKHI<TOk, TErr> DKGDAEBOJKO, [In] TOk CAHOCEGPEMJ)
	{
		return default(PNJEPLMEKHI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x34041C0", Offset = "0x3402DC0", VA = "0x1834041C0")]
	public static PNJEPLMEKHI<BODKGJBCKHC, TErr?> MDIOOLKKNEH<TErr>([In] this PNJEPLMEKHI<BODKGJBCKHC, TErr> DKGDAEBOJKO)
	{
		return default(PNJEPLMEKHI<BODKGJBCKHC, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x34039B0", Offset = "0x34025B0", VA = "0x1834039B0")]
	public static PNJEPLMEKHI<TOk?, TErr?> IPOKKICBHFM<TOk, TErr>([In] this PNJEPLMEKHI<TOk, TErr> DKGDAEBOJKO, [In] TErr HPKHNOHBLEL)
	{
		return default(PNJEPLMEKHI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3401110", Offset = "0x33FFD10", VA = "0x183401110")]
	public static TOk? DEPCKPJGBPO<TOk, TErr>([In] this PNJEPLMEKHI<TOk, TErr> DKGDAEBOJKO)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3403EF0", Offset = "0x3402AF0", VA = "0x183403EF0")]
	[AsyncStateMachine(typeof(FIOPEIKFMDA<, >))]
	public static Task<TOk?>? LEEMPFOLJBN<TOk, TErr>(this Task<PNJEPLMEKHI<TOk, TErr>> DKGDAEBOJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3400E50", Offset = "0x33FFA50", VA = "0x183400E50")]
	public static TErr? BLBMMGHJMAE<TErr, TOk>([In] this PNJEPLMEKHI<TOk, TErr> DKGDAEBOJKO)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x34017A0", Offset = "0x34003A0", VA = "0x1834017A0")]
	public static bool FEIKPHLHNGD<TOk, TErr, UErr, UOk>([In] this PNJEPLMEKHI<TOk, TErr> DKGDAEBOJKO, [Out] PNJEPLMEKHI<UOk, UErr> LKMMGOJKEDM) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3402840", Offset = "0x3401440", VA = "0x183402840")]
	public static bool GDENMCNAEID<TOk, TErr>([In] this PNJEPLMEKHI<TOk, TErr> DKGDAEBOJKO, [Out] TOk CAHOCEGPEMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3404260", Offset = "0x3402E60", VA = "0x183404260")]
	public static bool PECACKKOAAK<TOk, TErr>([In] this PNJEPLMEKHI<TOk, TErr> DKGDAEBOJKO, [Out][NotNullWhen(true)] TErr HPKHNOHBLEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3400B10", Offset = "0x33FF710", VA = "0x183400B10")]
	public static bool AOFKFHPKGAF<TOk, TErr>([In] this PNJEPLMEKHI<TOk, TErr> DKGDAEBOJKO, [Out][NotNullWhen(true)] TOk CAHOCEGPEMJ, [Out][NotNullWhen(false)] TErr HPKHNOHBLEL) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3401560", Offset = "0x3400160", VA = "0x183401560")]
	public static bool FABGAHPFEJE<TOk, TErr>([In] this PNJEPLMEKHI<TOk, TErr> DKGDAEBOJKO, [Out][NotNullWhen(true)] TOk CAHOCEGPEMJ, [Out] PNJEPLMEKHI<TOk, TErr> LKMMGOJKEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3401A00", Offset = "0x3400600", VA = "0x183401A00")]
	public static bool FEIKPHLHNGD<TOk, TErr, UErr, UOk>([In] this PNJEPLMEKHI<TOk, TErr> DKGDAEBOJKO, [Out][NotNullWhen(true)] TOk CAHOCEGPEMJ, [Out] PNJEPLMEKHI<UOk, UErr> LKMMGOJKEDM) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3402E00", Offset = "0x3401A00", VA = "0x183402E00")]
	public static bool IBALAAFEJKH<TOk, TErr>([In] this PNJEPLMEKHI<TOk, TErr> DKGDAEBOJKO, [Out][NotNullWhen(true)] TOk CAHOCEGPEMJ, [Out] PNJEPLMEKHI<BODKGJBCKHC, TErr> LKMMGOJKEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3403510", Offset = "0x3402110", VA = "0x183403510")]
	public static PNJEPLMEKHI<UOk, UErr> IBKKFNIEEMA<UOk, UErr, TOk, TErr>([In] this PNJEPLMEKHI<TOk, TErr> DKGDAEBOJKO, [In] PNJEPLMEKHI<UOk, UErr> LOJMCGAMMAK) where TOk : UOk where TErr : UErr
	{
		return default(PNJEPLMEKHI<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3403B80", Offset = "0x3402780", VA = "0x183403B80")]
	public static PNJEPLMEKHI<TOk?[]?, TErr?> JGGEPKHJPOL<TOk, TErr>(this IEnumerable<PNJEPLMEKHI<TOk, TErr>> DKGDAEBOJKO)
	{
		return default(PNJEPLMEKHI<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3402A70", Offset = "0x3401670", VA = "0x183402A70")]
	public static PNJEPLMEKHI<UOk?, TErr?> HGGHDJJAMJK<UOk, TErr, TOk>([In] this PNJEPLMEKHI<TOk, TErr> DKGDAEBOJKO, Func<TOk, UOk> KFKIPPCCCCE)
	{
		return default(PNJEPLMEKHI<UOk, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class MABKBPAGOAG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x33D5B20", Offset = "0x33D4720", VA = "0x1833D5B20")]
	public static PNJEPLMEKHI<TOk, T> MDIOOLKKNEH<TOk>([In] TOk CAHOCEGPEMJ) where TOk : notnull
	{
		return default(PNJEPLMEKHI<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4D22930", Offset = "0x4D21530", VA = "0x184D22930")]
	public static PNJEPLMEKHI<BODKGJBCKHC, T> MDIOOLKKNEH()
	{
		return default(PNJEPLMEKHI<BODKGJBCKHC, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x33D5B20", Offset = "0x33D4720", VA = "0x1833D5B20")]
	public static PNJEPLMEKHI<T, TErr> IPOKKICBHFM<TErr>([In] TErr HPKHNOHBLEL) where TErr : notnull
	{
		return default(PNJEPLMEKHI<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct CBDNAANANLM<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly PPIEIEBPEMI HNEEHBKLLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<TKey, TValue> IEHLPCCPKPK;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4541A60", Offset = "0x4540660", VA = "0x184541A60")]
	public static CBDNAANANLM<TKey, TValue> JPHABLICNHB(string HJIAOGEIAJO)
	{
		return default(CBDNAANANLM<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4541B90", Offset = "0x4540790", VA = "0x184541B90")]
	internal CBDNAANANLM(Dictionary<TKey, TValue> MPDLOLIOGJL, PPIEIEBPEMI KPIOJJCGOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x45419B0", Offset = "0x45405B0", VA = "0x1845419B0")]
	public KIAFKOLCFPP<TKey, TValue> IGNMLJMGPJD([Out] Dictionary<TKey, TValue> MPDLOLIOGJL)
	{
		return default(KIAFKOLCFPP<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct KIAFKOLCFPP<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TValue> IEHLPCCPKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly LLGEGFIGKMI EDBJKKBCLNC;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2718060", Offset = "0x2716C60", VA = "0x182718060")]
	internal KIAFKOLCFPP(Dictionary<TKey, TValue> MPDLOLIOGJL, LLGEGFIGKMI MELPMFMBDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x46FDBE0", Offset = "0x46FC7E0", VA = "0x1846FDBE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct ACGHDDAHMBN<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly PPIEIEBPEMI HNEEHBKLLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly HashSet<T> IEHLPCCPKPK;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4541A60", Offset = "0x4540660", VA = "0x184541A60")]
	public static ACGHDDAHMBN<T> JPHABLICNHB(string HJIAOGEIAJO)
	{
		return default(ACGHDDAHMBN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4541B90", Offset = "0x4540790", VA = "0x184541B90")]
	internal ACGHDDAHMBN(HashSet<T> MPDLOLIOGJL, PPIEIEBPEMI KPIOJJCGOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x45419B0", Offset = "0x45405B0", VA = "0x1845419B0")]
	public JAFCEAJLJJP<T> IGNMLJMGPJD([Out] HashSet<T> MPDLOLIOGJL)
	{
		return default(JAFCEAJLJJP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct JAFCEAJLJJP<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HashSet<T> IEHLPCCPKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly LLGEGFIGKMI EDBJKKBCLNC;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2718060", Offset = "0x2716C60", VA = "0x182718060")]
	internal JAFCEAJLJJP(HashSet<T> MPDLOLIOGJL, LLGEGFIGKMI MELPMFMBDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x46FDBE0", Offset = "0x46FC7E0", VA = "0x1846FDBE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct ABOAJLIMHFN<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly PPIEIEBPEMI HNEEHBKLLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Stack<T> IEHLPCCPKPK;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4541A60", Offset = "0x4540660", VA = "0x184541A60")]
	public static ABOAJLIMHFN<T> JPHABLICNHB(string HJIAOGEIAJO)
	{
		return default(ABOAJLIMHFN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4541B90", Offset = "0x4540790", VA = "0x184541B90")]
	internal ABOAJLIMHFN(Stack<T> MPDLOLIOGJL, PPIEIEBPEMI KPIOJJCGOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x45419B0", Offset = "0x45405B0", VA = "0x1845419B0")]
	public IHHKLCNEFNJ<T> IGNMLJMGPJD([Out] Stack<T> MPDLOLIOGJL)
	{
		return default(IHHKLCNEFNJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct IHHKLCNEFNJ<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Stack<T> IEHLPCCPKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly LLGEGFIGKMI EDBJKKBCLNC;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2718060", Offset = "0x2716C60", VA = "0x182718060")]
	internal IHHKLCNEFNJ(Stack<T> MPDLOLIOGJL, LLGEGFIGKMI MELPMFMBDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x46FDBE0", Offset = "0x46FC7E0", VA = "0x1846FDBE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public sealed class LAFPKBLCCHA<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct IMCANABNKKI : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly LAFPKBLCCHA<T> KKNEOBDIJPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int GKGABDHNMOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly bool AOGIBPODKCH;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x24248B0", Offset = "0x24234B0", VA = "0x1824248B0")]
		public IMCANABNKKI(LAFPKBLCCHA<T> FOBBPKHANPP, int JHBGDKFCGAL, bool ANGIGLHDINH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x470D040", Offset = "0x470BC40", VA = "0x18470D040")]
		public LAFPKBLCCHA<T>.NDLOMKGKDNG HCMJLOGCBCL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x470D140", Offset = "0x470BD40", VA = "0x18470D140", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x470D140", Offset = "0x470BD40", VA = "0x18470D140", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class NDLOMKGKDNG : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly LAFPKBLCCHA<T> KKNEOBDIJPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly int OGADKCFJDCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int NKJMOPPJCFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly bool AOGIBPODKCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool NKKLCNNNODE;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T OAKKBGDNIKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x4DF1740", Offset = "0x4DF0340", VA = "0x184DF1740")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x4DF1840", Offset = "0x4DF0440", VA = "0x184DF1840", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x4DF1990", Offset = "0x4DF0590", VA = "0x184DF1990", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4DF2010", Offset = "0x4DF0C10", VA = "0x184DF2010")]
		public NDLOMKGKDNG(LAFPKBLCCHA<T> FOBBPKHANPP, int JHBGDKFCGAL, bool ANGIGLHDINH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4DF1780", Offset = "0x4DF0380", VA = "0x184DF1780", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4DF1820", Offset = "0x4DF0420", VA = "0x184DF1820", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class IIFFBOGCOHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public IIFFBOGCOHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x4705360", Offset = "0x4703F60", VA = "0x184705360")]
		internal T IAJIPBONKMF(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly T[] KEELMCDJFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int NKJMOPPJCFN;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int EFDJMPEOCOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4B101B0", Offset = "0x4B0EDB0", VA = "0x184B101B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T OAKKBGDNIKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4384FE0", Offset = "0x4383BE0", VA = "0x184384FE0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T CHADECDLCFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4B0FF10", Offset = "0x4B0EB10", VA = "0x184B0FF10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T MPDHFMNHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4B0FFF0", Offset = "0x4B0EBF0", VA = "0x184B0FFF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int FMELMONACEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x228A7D0", Offset = "0x22893D0", VA = "0x18228A7D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x182F520", Offset = "0x182E120", VA = "0x18182F520")]
	private static int PFNHNAGBAMA(int BIEEMEKMINN, int OKLDJMDCMFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4B103E0", Offset = "0x4B0EFE0", VA = "0x184B103E0")]
	public LAFPKBLCCHA(int FJJGAGKDECJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4B10210", Offset = "0x4B0EE10", VA = "0x184B10210")]
	public LAFPKBLCCHA(int FJJGAGKDECJ, Func<T> HHIEHKEJMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4B10650", Offset = "0x4B0F250", VA = "0x184B10650")]
	public LAFPKBLCCHA(T[] BIGGBEIOJHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4B0FE10", Offset = "0x4B0EA10", VA = "0x184B0FE10")]
	public void ABIACPJHHAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4B0FE40", Offset = "0x4B0EA40", VA = "0x184B0FE40")]
	public IEnumerable<T> CJCDMKEHLJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4B0FF50", Offset = "0x4B0EB50", VA = "0x184B0FF50")]
	public LAFPKBLCCHA<T>.NDLOMKGKDNG HCMJLOGCBCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4491350", Offset = "0x448FF50", VA = "0x184491350", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4491350", Offset = "0x448FF50", VA = "0x184491350", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class GBAOONMHNLE
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x336F3A0", Offset = "0x336DFA0", VA = "0x18336F3A0")]
	public static LAFPKBLCCHA<T> JPHABLICNHB<T>(int FJJGAGKDECJ, Func<T> HHIEHKEJMAE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class EKEJAPGAKBB<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct AGJHBIEFGJL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly EKEJAPGAKBB<T> JIMCKGHOMLF;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T GNLOKINMAMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x46657D0", Offset = "0x46643D0", VA = "0x1846657D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x46657F0", Offset = "0x46643F0", VA = "0x1846657F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xBDB470", Offset = "0xBDA070", VA = "0x180BDB470")]
		public AGJHBIEFGJL(EKEJAPGAKBB<T> JIMCKGHOMLF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct NJFKMJKJAIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder<AGJHBIEFGJL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public EKEJAPGAKBB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4E06EC0", Offset = "0x4E05AC0", VA = "0x184E06EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4635B30", Offset = "0x4634730", VA = "0x184635B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly SemaphoreSlim DJLLKFIBDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private T AAHFBBEIMOH;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3FDAED0", Offset = "0x3FD9AD0", VA = "0x183FDAED0")]
	public EKEJAPGAKBB([In] T AAHFBBEIMOH, int ODFBGKKKHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3FDADF0", Offset = "0x3FD99F0", VA = "0x183FDADF0")]
	public EKEJAPGAKBB([In] T AAHFBBEIMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3FDA820", Offset = "0x3FD9420", VA = "0x183FDA820", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3FDA7E0", Offset = "0x3FD93E0", VA = "0x183FDA7E0")]
	public AGJHBIEFGJL CJANGDLECDJ()
	{
		return default(AGJHBIEFGJL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3FDA990", Offset = "0x3FD9590", VA = "0x183FDA990")]
	[AsyncStateMachine(typeof(EKEJAPGAKBB<>.NJFKMJKJAIA))]
	public Task<EKEJAPGAKBB<T>.AGJHBIEFGJL> HDBGEGPNBHF(CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3FDAD20", Offset = "0x3FD9920", VA = "0x183FDAD20")]
	public void LNGAFKADHNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class HBDAJFENCAC
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x75BD5B0", Offset = "0x75BC1B0", VA = "0x1875BD5B0")]
	public static EKEJAPGAKBB<BODKGJBCKHC> JPHABLICNHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x30E8390", Offset = "0x30E6F90", VA = "0x1830E8390")]
	public static EKEJAPGAKBB<T> JPHABLICNHB<T>([In] T AAHFBBEIMOH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class LOOGLLJGBGI<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct NNCMEANDLKM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly LOOGLLJGBGI<T> HIAMLHNMALK;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public T GNLOKINMAMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x3FD14B0", Offset = "0x3FD00B0", VA = "0x183FD14B0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4E5FE50", Offset = "0x4E5EA50", VA = "0x184E5FE50", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xBDB470", Offset = "0xBDA070", VA = "0x180BDB470")]
		internal NNCMEANDLKM(LOOGLLJGBGI<T> JIMCKGHOMLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct EIAKHEAODKC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly LOOGLLJGBGI<T> HIAMLHNMALK;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T GNLOKINMAMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x3FD14B0", Offset = "0x3FD00B0", VA = "0x183FD14B0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3FD1530", Offset = "0x3FD0130", VA = "0x183FD1530", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xBDB470", Offset = "0xBDA070", VA = "0x180BDB470")]
		internal EIAKHEAODKC(LOOGLLJGBGI<T> JIMCKGHOMLF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct NJJLBGJJMCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<EIAKHEAODKC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public LOOGLLJGBGI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private EKEJAPGAKBB<BODKGJBCKHC>.AGJHBIEFGJL <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<EKEJAPGAKBB<BODKGJBCKHC>.AGJHBIEFGJL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4E08BE0", Offset = "0x4E077E0", VA = "0x184E08BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4635B30", Offset = "0x4634730", VA = "0x184635B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly EKEJAPGAKBB<int> OIDPPPDGLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly EKEJAPGAKBB<BODKGJBCKHC> DNADPJIFKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly EKEJAPGAKBB<BODKGJBCKHC> FJDGPJGPCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private T NDCELFEJNCL;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4B4EAE0", Offset = "0x4B4D6E0", VA = "0x184B4EAE0")]
	internal LOOGLLJGBGI(EKEJAPGAKBB<int> HMLEDEOBEEC, EKEJAPGAKBB<BODKGJBCKHC> LAMGCCGKPID, EKEJAPGAKBB<BODKGJBCKHC> IIEOIPPCJNF, [In] T AAHFBBEIMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4B4E930", Offset = "0x4B4D530", VA = "0x184B4E930", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4B4E680", Offset = "0x4B4D280", VA = "0x184B4E680")]
	public NNCMEANDLKM ANJKJKJGEOM()
	{
		return default(NNCMEANDLKM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4B4E840", Offset = "0x4B4D440", VA = "0x184B4E840")]
	public EIAKHEAODKC DHAOIKNHENB()
	{
		return default(EIAKHEAODKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4B4E9B0", Offset = "0x4B4D5B0", VA = "0x184B4E9B0")]
	[AsyncStateMachine(typeof(LOOGLLJGBGI<>.NJJLBGJJMCJ))]
	public Task<LOOGLLJGBGI<T>.EIAKHEAODKC> POKLIEIEAJD(CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class ENECBHBBGFA
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x75BCDB0", Offset = "0x75BB9B0", VA = "0x1875BCDB0")]
	public static LOOGLLJGBGI<BODKGJBCKHC> JPHABLICNHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x32058F0", Offset = "0x32044F0", VA = "0x1832058F0")]
	public static LOOGLLJGBGI<T> JPHABLICNHB<T>([In] T AAHFBBEIMOH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class EOOPJDAPPNP<TData> : KLJHHNJNNDG where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly string JMJNOKCIMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly TData JBDHCGELIFD;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
	public override string CNPDCBKGCII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x400A8B0", Offset = "0x40094B0", VA = "0x18400A8B0")]
	internal EOOPJDAPPNP(string KBPDEFFIKOJ, [In] TData LLDJIJICLJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class BECDKCPIJAO
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x75BC3A0", Offset = "0x75BAFA0", VA = "0x1875BC3A0")]
	public static EOOPJDAPPNP<BODKGJBCKHC> JPHABLICNHB(string KBPDEFFIKOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x30E9000", Offset = "0x30E7C00", VA = "0x1830E9000")]
	public static EOOPJDAPPNP<TData> JPHABLICNHB<TData>(string KBPDEFFIKOJ, [In] TData LLDJIJICLJF) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class PPIEIEBPEMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal bool PNKFDIBGOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly string ONGAGGFIDEB;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xCA81A0", Offset = "0xCA6DA0", VA = "0x180CA81A0")]
	private PPIEIEBPEMI(bool CEOAFFJGCOL, string DAJAIGPAHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x75BFB20", Offset = "0x75BE720", VA = "0x1875BFB20")]
	public static PPIEIEBPEMI JPHABLICNHB(string DAJAIGPAHFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x75BFA60", Offset = "0x75BE660", VA = "0x1875BFA60")]
	public LLGEGFIGKMI IGNMLJMGPJD()
	{
		return default(LLGEGFIGKMI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct LLGEGFIGKMI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly PPIEIEBPEMI OLHLKPCGDCH;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0xBDB470", Offset = "0xBDA070", VA = "0x180BDB470")]
	internal LLGEGFIGKMI(PPIEIEBPEMI HJIAOGEIAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x75BEBD0", Offset = "0x75BD7D0", VA = "0x1875BEBD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class BCBFFNLMKNB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class FHEOEEALJFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public FHEOEEALJFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4394D70", Offset = "0x4393970", VA = "0x184394D70")]
		internal int KAJAFGHNKFB(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private HashSet<T>? NJEIOJGOMAD;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public IReadOnlyCollection<T> AHFEEELOIGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x57F8000", Offset = "0x57F6C00", VA = "0x1857F8000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool NPECIAMPJID
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x57F8180", Offset = "0x57F6D80", VA = "0x1857F8180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int PHJGKILIPGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x95B870", Offset = "0x95A470", VA = "0x18095B870")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x95B860", Offset = "0x95A460", VA = "0x18095B860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x57F7E20", Offset = "0x57F6A20", VA = "0x1857F7E20")]
	public bool GFCJDEIJPEO(T IKLHDHMJFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x57F7CA0", Offset = "0x57F68A0", VA = "0x1857F7CA0")]
	public bool BLAPNJAELFA(T IKLHDHMJFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x57F8040", Offset = "0x57F6C40", VA = "0x1857F8040")]
	public bool IKPHFMNIAIK(T IKLHDHMJFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x57F8090", Offset = "0x57F6C90", VA = "0x1857F8090")]
	public void JBIPDHNLODB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x57F81D0", Offset = "0x57F6DD0", VA = "0x1857F81D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public BCBFFNLMKNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class MKEMIGJFLFM
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class LGKDMGLLPFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public LGKDMGLLPFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x75BEB20", Offset = "0x75BD720", VA = "0x1875BEB20")]
		internal int KAJAFGHNKFB(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private HashSet<object>? NJEIOJGOMAD;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyCollection<object> AHFEEELOIGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x75BEE50", Offset = "0x75BDA50", VA = "0x1875BEE50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool NPECIAMPJID
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x75BEFB0", Offset = "0x75BDBB0", VA = "0x1875BEFB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int PHJGKILIPGP
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x95B870", Offset = "0x95A470", VA = "0x18095B870")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x95B860", Offset = "0x95A460", VA = "0x18095B860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x75BED70", Offset = "0x75BD970", VA = "0x1875BED70")]
	public bool GFCJDEIJPEO(object IKLHDHMJFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x75BECD0", Offset = "0x75BD8D0", VA = "0x1875BECD0")]
	public bool BLAPNJAELFA(object IKLHDHMJFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x75BEEE0", Offset = "0x75BDAE0", VA = "0x1875BEEE0")]
	public bool IKPHFMNIAIK(object IKLHDHMJFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x75BEF40", Offset = "0x75BDB40", VA = "0x1875BEF40")]
	public void JBIPDHNLODB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x75BEFC0", Offset = "0x75BDBC0", VA = "0x1875BEFC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public MKEMIGJFLFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class NICJALOBGIF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private struct DBAKFMAKBGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float DNCPGALHJHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public T GNLOKINMAMH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, DBAKFMAKBGG> FLHCIALOJPM;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public virtual T MFPBJIDFDPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x16FA070", Offset = "0x16F8C70", VA = "0x1816FA070", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x16F9550", Offset = "0x16F8150", VA = "0x1816F9550", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public object? FMPLPFLKNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x9574D0", Offset = "0x9560D0", VA = "0x1809574D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9574E0", Offset = "0x9560E0", VA = "0x1809574E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool GPAPHLJCFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x462CCE0", Offset = "0x462B8E0", VA = "0x18462CCE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4E01880", Offset = "0x4E00480", VA = "0x184E01880")]
	public bool GPELINLBKLH(T MPDLOLIOGJL, object IKLHDHMJFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x462D0A0", Offset = "0x462BCA0", VA = "0x18462D0A0")]
	public bool KFMHBEHFAMB(object IKLHDHMJFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x462D720", Offset = "0x462C320", VA = "0x18462D720")]
	public void NGMONOEHMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4E02370", Offset = "0x4E00F70", VA = "0x184E02370")]
	public bool JLHCCLDIOMP(object IKLHDHMJFFL, [Out] T MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4E03670", Offset = "0x4E02270", VA = "0x184E03670")]
	[ANKPNCJPHAA("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool LICBGCFECMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4933B40", Offset = "0x4932740", VA = "0x184933B40")]
	public NICJALOBGIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class KEFAMGOBHIH : GBHGLFGKICP<ABCMEDAMFNA>
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	internal class PIGFIFAPHBI : IEqualityComparer<ABCMEDAMFNA>
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal static readonly PIGFIFAPHBI FFLNCJPMHOJ;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x75BF9D0", Offset = "0x75BE5D0", VA = "0x1875BF9D0", Slot = "4")]
		public bool Equals(ABCMEDAMFNA MDFKHKOGFDI, ABCMEDAMFNA ELJEANFLEPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6896CA0", Offset = "0x68958A0", VA = "0x186896CA0", Slot = "5")]
		public int GetHashCode(ABCMEDAMFNA CFMCKCBBBKK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public PIGFIFAPHBI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x75BE3A0", Offset = "0x75BCFA0", VA = "0x1875BE3A0")]
	public KEFAMGOBHIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x75BE260", Offset = "0x75BCE60", VA = "0x1875BE260", Slot = "4")]
	public override bool GFCJDEIJPEO(ABCMEDAMFNA IKLHDHMJFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x75BE1B0", Offset = "0x75BCDB0", VA = "0x1875BE1B0", Slot = "5")]
	public override bool BLAPNJAELFA(ABCMEDAMFNA IKLHDHMJFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x75BE310", Offset = "0x75BCF10", VA = "0x1875BE310")]
	private static void LOAMBFBPMND(ABCMEDAMFNA IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x15FC230", Offset = "0x15FAE30", VA = "0x1815FC230", Slot = "6")]
	protected override string MIGCPGAJDLP(ABCMEDAMFNA IKLHDHMJFFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class ABCMEDAMFNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly string AIOCCDGAGID;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	public ABCMEDAMFNA(string AIOCCDGAGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x75BC180", Offset = "0x75BAD80", VA = "0x1875BC180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class GBHGLFGKICP<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly IEqualityComparer<T> CFOLKBKPHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private HashSet<T>? NJEIOJGOMAD;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool NPECIAMPJID
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x44BA8B0", Offset = "0x44B94B0", VA = "0x1844BA8B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int PHJGKILIPGP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA90E00", Offset = "0xA8FA00", VA = "0x180A90E00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xB42EE0", Offset = "0xB41AE0", VA = "0x180B42EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x44BAC00", Offset = "0x44B9800", VA = "0x1844BAC00")]
	internal GBHGLFGKICP(IEqualityComparer<T> CFOLKBKPHDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x44BA5E0", Offset = "0x44B91E0", VA = "0x1844BA5E0", Slot = "4")]
	public virtual bool GFCJDEIJPEO(T IKLHDHMJFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x44BA460", Offset = "0x44B9060", VA = "0x1844BA460", Slot = "5")]
	public virtual bool BLAPNJAELFA(T IKLHDHMJFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x44BA7C0", Offset = "0x44B93C0", VA = "0x1844BA7C0")]
	public void JBIPDHNLODB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string MIGCPGAJDLP(T IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x44BA900", Offset = "0x44B9500", VA = "0x1844BA900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class IPFNKJJLGJL<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private List<WeakReference<T>>? NJEIOJGOMAD;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool NPECIAMPJID
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x471A140", Offset = "0x4718D40", VA = "0x18471A140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int PHJGKILIPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x4719CB0", Offset = "0x47188B0", VA = "0x184719CB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4719E60", Offset = "0x4718A60", VA = "0x184719E60")]
	public void GFCJDEIJPEO(T IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x4719B00", Offset = "0x4718700", VA = "0x184719B00")]
	public void BLAPNJAELFA(T IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x471A0F0", Offset = "0x4718CF0", VA = "0x18471A0F0")]
	public void JBIPDHNLODB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x471A270", Offset = "0x4718E70", VA = "0x18471A270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public IPFNKJJLGJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal static class FPGJBBEIHAK
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3369B10", Offset = "0x3368710", VA = "0x183369B10")]
	public static void LAFEPAJHHKI<T>(this List<T> DGHHCPPFODF, int BIEEMEKMINN) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class HJMHLEPKHMD<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct MNDLNMCAFPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public float DNCPGALHJHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public T GNLOKINMAMH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<ABCMEDAMFNA, MNDLNMCAFPL> FLHCIALOJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly EqualityComparer<T> DBNLGLIFMGK;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public virtual T MFPBJIDFDPL
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x95D150", Offset = "0x95BD50", VA = "0x18095D150", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x95CF00", Offset = "0x95BB00", VA = "0x18095CF00", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private ABCMEDAMFNA? FMPLPFLKNMD
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x957540", Offset = "0x956140", VA = "0x180957540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool GPAPHLJCFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x462CCE0", Offset = "0x462B8E0", VA = "0x18462CCE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x462CE70", Offset = "0x462BA70", VA = "0x18462CE70")]
	public bool GPELINLBKLH(T MPDLOLIOGJL, ABCMEDAMFNA IKLHDHMJFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x462D0A0", Offset = "0x462BCA0", VA = "0x18462D0A0")]
	public bool KFMHBEHFAMB(ABCMEDAMFNA IKLHDHMJFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x462D720", Offset = "0x462C320", VA = "0x18462D720")]
	public void NGMONOEHMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x462CF80", Offset = "0x462BB80", VA = "0x18462CF80")]
	public bool JLHCCLDIOMP(ABCMEDAMFNA IKLHDHMJFFL, [Out] T MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x462D450", Offset = "0x462C050", VA = "0x18462D450")]
	[ANKPNCJPHAA("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool LICBGCFECMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x462D8D0", Offset = "0x462C4D0", VA = "0x18462D8D0")]
	public HJMHLEPKHMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class NBGGBHGBLHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Dictionary<object, float> FLHCIALOJPM;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public float LMBKBKPONMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xD69C10", Offset = "0xD68810", VA = "0x180D69C10")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xD699D0", Offset = "0xD685D0", VA = "0x180D699D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x75BF2A0", Offset = "0x75BDEA0", VA = "0x1875BF2A0")]
	public void GPELINLBKLH(float MPDLOLIOGJL, object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x75BF440", Offset = "0x75BE040", VA = "0x1875BF440")]
	public void KFMHBEHFAMB(object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x75BF4B0", Offset = "0x75BE0B0", VA = "0x1875BF4B0")]
	public void NGMONOEHMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x75BF310", Offset = "0x75BDF10", VA = "0x1875BF310")]
	private void KEOPEDGPBFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x75BF500", Offset = "0x75BE100", VA = "0x1875BF500")]
	public NBGGBHGBLHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface OOCBOHNBEIH
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event KHHDCNPGNJA HOGNFFHBGGF;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class DMMAGACMAGB : OOCBOHNBEIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public readonly struct INGJNONBBII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly float MEKDGOPFPIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly float NLIPOCPBNPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		internal readonly bool KBPDDCJKJDD;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float BNJMONPHFGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x75BD620", Offset = "0x75BC220", VA = "0x1875BD620")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x75BD7A0", Offset = "0x75BC3A0", VA = "0x1875BD7A0")]
		public INGJNONBBII(float BICIFKAHIKL, float AIHKABICJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x75BD630", Offset = "0x75BC230", VA = "0x1875BD630", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class FDCFOIIKIJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public DMMAGACMAGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public FDCFOIIKIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x75BD2E0", Offset = "0x75BBEE0", VA = "0x1875BD2E0")]
		internal void IIJINAFLGHG(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly int MFFEHHIHGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private int OPOGFINMMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly OOCBOHNBEIH[] CHGIFIKANDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly KHHDCNPGNJA[] JOHAHHCBBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly INGJNONBBII[] HCGAFMMDJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private INGJNONBBII DHIJMBMCJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly FFAGHJPHLLH EALBDGEFILG;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event KHHDCNPGNJA HOGNFFHBGGF
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x75BCB00", Offset = "0x75BB700", VA = "0x1875BCB00", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x75BCA40", Offset = "0x75BB640", VA = "0x1875BCA40", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x75BCBC0", Offset = "0x75BB7C0", VA = "0x1875BCBC0")]
	public DMMAGACMAGB(int MFFEHHIHGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x75BC530", Offset = "0x75BB130", VA = "0x1875BC530")]
	public FFAGHJPHLLH FGLDEMOLOBN(INGJNONBBII OKCFDJGMALL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x75BC5C0", Offset = "0x75BB1C0", VA = "0x1875BC5C0")]
	public void MHIMBGDBMCC(OOCBOHNBEIH BCLJMBHHNAI, [Optional] INGJNONBBII JMMFCANIHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x75BC420", Offset = "0x75BB020", VA = "0x1875BC420", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public delegate void KHHDCNPGNJA(float FBHIHMHGJOE);
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class MLKEIBPDDCP
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class LNOOCHMJFAH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly OOCBOHNBEIH PCOPINCGKHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly KHHDCNPGNJA DKDPAFJDNNF;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x75BEC40", Offset = "0x75BD840", VA = "0x1875BEC40")]
		public LNOOCHMJFAH(OOCBOHNBEIH PCOPINCGKHH, KHHDCNPGNJA DKDPAFJDNNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x75BEBF0", Offset = "0x75BD7F0", VA = "0x1875BEBF0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x75BF230", Offset = "0x75BDE30", VA = "0x1875BF230")]
	internal static bool KKJHIHOHLHD(float CEDOOEEEDCO, float LJEHMGANCNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x75AA360", Offset = "0x75A8F60", VA = "0x1875AA360")]
	internal static float NBFDHEGLINE(float CEDOOEEEDCO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x75BF170", Offset = "0x75BDD70", VA = "0x1875BF170")]
	public static IDisposable FBMKFJNJEHP(this OOCBOHNBEIH PCOPINCGKHH, KHHDCNPGNJA DKDPAFJDNNF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class FFAGHJPHLLH : OOCBOHNBEIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private float FBHIHMHGJOE;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public float LAEBIIKBKKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x75BD380", Offset = "0x75BBF80", VA = "0x1875BD380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event KHHDCNPGNJA? HOGNFFHBGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x75BD510", Offset = "0x75BC110", VA = "0x1875BD510", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x75BD470", Offset = "0x75BC070", VA = "0x1875BD470", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public FFAGHJPHLLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface BKLECNCGDJG<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ODKMKJKEOCN<T> FDMJAGPJNJE([Out] T MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NGMONOEHMBH();
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class MLBBADEGLIP<T> : BKLECNCGDJG<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly ConcurrentStack<T> HJHOKJHHLDP;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x4D835F0", Offset = "0x4D821F0", VA = "0x184D835F0", Slot = "4")]
	public ODKMKJKEOCN<T> FDMJAGPJNJE([Out] T MPDLOLIOGJL)
	{
		return default(ODKMKJKEOCN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x4D83690", Offset = "0x4D82290", VA = "0x184D83690")]
	public void GFEMBPJJFIN(T HDCAGPLOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x4B6CE30", Offset = "0x4B6BA30", VA = "0x184B6CE30", Slot = "5")]
	public void NGMONOEHMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "6")]
	protected virtual void BLJFAIPJEBJ(T KAPFOFFLLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x4D83710", Offset = "0x4D82310", VA = "0x184D83710")]
	private T IMOGIGFHIEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x4D837C0", Offset = "0x4D823C0", VA = "0x184D837C0")]
	public MLBBADEGLIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct ODKMKJKEOCN<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly T HDCAGPLOJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly MLBBADEGLIP<T> NGCIGINBCBE;

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x9DD890", Offset = "0x9DC490", VA = "0x1809DD890")]
	internal ODKMKJKEOCN(T MPDLOLIOGJL, MLBBADEGLIP<T> NGCIGINBCBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x4F70FB0", Offset = "0x4F6FBB0", VA = "0x184F70FB0", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class APCKLEACCAG : MLBBADEGLIP<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public static readonly APCKLEACCAG FFLNCJPMHOJ;

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x75BC230", Offset = "0x75BAE30", VA = "0x1875BC230")]
	public static ODKMKJKEOCN<StringBuilder> IMOGIGFHIEP([Out] StringBuilder MPDLOLIOGJL)
	{
		return default(ODKMKJKEOCN<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x75BC210", Offset = "0x75BAE10", VA = "0x1875BC210", Slot = "6")]
	protected override void BLJFAIPJEBJ(StringBuilder KAPFOFFLLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x75BC360", Offset = "0x75BAF60", VA = "0x1875BC360")]
	public APCKLEACCAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class MNOPGEFLNPD : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6F75AE0", Offset = "0x6F746E0", VA = "0x186F75AE0")]
	public MNOPGEFLNPD(string KBPDEFFIKOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DefaultMember("Item")]
public class DIEHBDNCCLJ<TKey, TValue> : OFFKAFEIOLK<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, JLFGPGHPKCL where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class MFNOBIPKBAO : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public DIEHBDNCCLJ<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x16FA070", Offset = "0x16F8C70", VA = "0x1816FA070", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x4D42C30", Offset = "0x4D41830", VA = "0x184D42C30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
		[DebuggerHidden]
		public MFNOBIPKBAO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x4456370", Offset = "0x4454F70", VA = "0x184456370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4D42390", Offset = "0x4D40F90", VA = "0x184D42390", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x4D41E40", Offset = "0x4D40A40", VA = "0x184D41E40")]
		private void AOMOFJGADBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x4D41F30", Offset = "0x4D40B30", VA = "0x184D41F30")]
		private void BENEFBJOBNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x4D42BE0", Offset = "0x4D417E0", VA = "0x184D42BE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly OFFKAFEIOLK<TKey, TValue> ALKLJBMJPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly IDictionary<TKey, TValue> FEMGPJPHGIE;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int PHJGKILIPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6312500", Offset = "0x6311100", VA = "0x186312500", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool EDFBHKBNGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public TValue MPDHFMNHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x63126A0", Offset = "0x63112A0", VA = "0x1863126A0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x6312990", Offset = "0x6311590", VA = "0x186312990", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public ICollection<TKey> NMPNIMOKCIA
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6312730", Offset = "0x6311330", VA = "0x186312730", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public ICollection<TValue> MLGCHFNMEPM
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6312860", Offset = "0x6311460", VA = "0x186312860", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6312360", Offset = "0x6310F60", VA = "0x186312360")]
	public DIEHBDNCCLJ(OFFKAFEIOLK<TKey, TValue> ALKLJBMJPPC, [Optional] IDictionary<TKey, TValue>? FEMGPJPHGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x630FA80", Offset = "0x630E680", VA = "0x18630FA80", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6310FA0", Offset = "0x630FBA0", VA = "0x186310FA0")]
	public void LIHMAKOJCPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x630F840", Offset = "0x630E440", VA = "0x18630F840", Slot = "9")]
	public void Add(TKey NKANGPLHEGE, TValue MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x63110C0", Offset = "0x630FCC0", VA = "0x1863110C0")]
	public void MEJFCLNMEGJ(TKey NKANGPLHEGE, TValue MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6311430", Offset = "0x6310030", VA = "0x186311430")]
	public void NMFGGFPFOND(TKey NKANGPLHEGE, TValue MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x63104B0", Offset = "0x630F0B0", VA = "0x1863104B0")]
	public void FIKIJPKEALI(TKey NKANGPLHEGE, TValue MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6310EA0", Offset = "0x630FAA0", VA = "0x186310EA0")]
	public void KPMPLACCOOD(TKey NKANGPLHEGE, TValue MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6311970", Offset = "0x6310570", VA = "0x186311970", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> HLGDOFMLIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6311BB0", Offset = "0x63107B0", VA = "0x186311BB0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> HLGDOFMLIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6311D70", Offset = "0x6310970", VA = "0x186311D70", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> HLGDOFMLIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x630FB10", Offset = "0x630E710", VA = "0x18630FB10", Slot = "8")]
	public bool ContainsKey(TKey NKANGPLHEGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6311640", Offset = "0x6310240", VA = "0x186311640")]
	public bool OCEFKLBNHHO(TKey NKANGPLHEGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x63103E0", Offset = "0x630EFE0", VA = "0x1863103E0")]
	public bool EKLHKGIHOFL(TKey NKANGPLHEGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6311710", Offset = "0x6310310", VA = "0x186311710", Slot = "10")]
	public bool Remove(TKey NKANGPLHEGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x63121B0", Offset = "0x6310DB0", VA = "0x1863121B0", Slot = "11")]
	public bool TryGetValue(TKey NKANGPLHEGE, [Out] TValue MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x630FEE0", Offset = "0x630EAE0", VA = "0x18630FEE0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] CPOMPIIIEGC, int LECIFCCAAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x49DD780", Offset = "0x49DC380", VA = "0x1849DD780", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6310A20", Offset = "0x630F620", VA = "0x186310A20", Slot = "19")]
	[IteratorStateMachine(typeof(DIEHBDNCCLJ<, >.MFNOBIPKBAO))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6311310", Offset = "0x630FF10", VA = "0x186311310", Slot = "21")]
	public bool NDMEKNAFHPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6310AD0", Offset = "0x630F6D0", VA = "0x186310AD0")]
	private TValue JHFDCMLFOAM(TKey NKANGPLHEGE)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface JLFGPGHPKCL
{
	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NDMEKNAFHPM();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface OFFKAFEIOLK<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, JLFGPGHPKCL
{
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DefaultMember("Item")]
public sealed class MJFHCEFLNCG<TKey, TVal> : OFFKAFEIOLK<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, JLFGPGHPKCL where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public delegate int CBEJAIEGICM(TKey NKANGPLHEGE, TVal MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public delegate void FMMEFPIMJJP(TKey NKANGPLHEGE, TVal MPDLOLIOGJL, EBMFEFMGONK NCKCEGPNPKI);

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private class OPCLNHJIDMF
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public TKey JFPNHMHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xAD8DC0", Offset = "0xAD79C0", VA = "0x180AD8DC0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public TVal GNLOKINMAMH
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0xA90E00", Offset = "0xA8FA00", VA = "0x180A90E00")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xB42EE0", Offset = "0xB41AE0", VA = "0x180B42EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int BNJMONPHFGF
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x9994B0", Offset = "0x9980B0", VA = "0x1809994B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x998AA0", Offset = "0x9976A0", VA = "0x180998AA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public DateTimeOffset LMHNGGJAFGE
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x1095A60", Offset = "0x1094660", VA = "0x181095A60")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x1095020", Offset = "0x1093C20", VA = "0x181095020")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x4F9BAE0", Offset = "0x4F9A6E0", VA = "0x184F9BAE0")]
		public OPCLNHJIDMF(TKey NKANGPLHEGE, TVal ODFJOPDFEGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class JEJIEIGPMBE : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public MJFHCEFLNCG<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private LinkedList<OPCLNHJIDMF>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x16FA070", Offset = "0x16F8C70", VA = "0x1816FA070", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x4928A10", Offset = "0x4927610", VA = "0x184928A10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
		[DebuggerHidden]
		public JEJIEIGPMBE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4451930", Offset = "0x4450530", VA = "0x184451930", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x4927F60", Offset = "0x4926B60", VA = "0x184927F60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x4927F20", Offset = "0x4926B20", VA = "0x184927F20")]
		private void AOMOFJGADBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4928970", Offset = "0x4927570", VA = "0x184928970", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public const int MOFCHAGMCLI = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly Dictionary<TKey, LinkedListNode<OPCLNHJIDMF>> LJOKIBCMLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly LinkedList<OPCLNHJIDMF> ECNKAJIPBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CBEJAIEGICM? CMHHGPNFEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly TimeSpan AFFFOHMECDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly FMMEFPIMJJP? JBOOMNDADPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly AFOKPECFOGN ENABJOOHJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool NOCFAKODCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly List<TKey> FAPEHGNBDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly List<TVal> JPAABJLMGPA;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int ACBNPOKAKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x968110", Offset = "0x966D10", VA = "0x180968110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int NNBJBDMDAHF
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA862F0", Offset = "0xA84EF0", VA = "0x180A862F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA862D0", Offset = "0xA84ED0", VA = "0x180A862D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int PHJGKILIPGP
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4D53C20", Offset = "0x4D52820", VA = "0x184D53C20", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	internal int ECOMBKOENNF
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x462D720", Offset = "0x462C320", VA = "0x18462D720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public ICollection<TVal> MLGCHFNMEPM
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4D53D20", Offset = "0x4D52920", VA = "0x184D53D20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	ICollection<TKey> IDictionary<TKey, TVal>.LIIEPPLBFEG
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x4D52BA0", Offset = "0x4D517A0", VA = "0x184D52BA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool EDFBHKBNGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public TVal MPDHFMNHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4D53CC0", Offset = "0x4D528C0", VA = "0x184D53CC0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x4D53D70", Offset = "0x4D52970", VA = "0x184D53D70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4D4EDD0", Offset = "0x4D4D9D0", VA = "0x184D4EDD0")]
	private bool EFDPLIFNGOO(int MFFEHHIHGMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x4D512B0", Offset = "0x4D4FEB0", VA = "0x184D512B0")]
	private void NJDILFIGCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x4D53560", Offset = "0x4D52160", VA = "0x184D53560")]
	public MJFHCEFLNCG(int MFFEHHIHGMB, [Optional] CBEJAIEGICM? CMHHGPNFEKI, [Optional] IEqualityComparer<TKey>? FMNEKIDPBFC, [Optional] FMMEFPIMJJP? JBOOMNDADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x4D534E0", Offset = "0x4D520E0", VA = "0x184D534E0")]
	public MJFHCEFLNCG(TimeSpan AFFFOHMECDP, [Optional] IEqualityComparer<TKey>? FMNEKIDPBFC, [Optional] FMMEFPIMJJP? JBOOMNDADPC, [Optional] AFOKPECFOGN? ENABJOOHJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x4D53720", Offset = "0x4D52320", VA = "0x184D53720")]
	public MJFHCEFLNCG(int MFFEHHIHGMB, TimeSpan AFFFOHMECDP, [Optional] IEqualityComparer<TKey>? FMNEKIDPBFC, [Optional] FMMEFPIMJJP? JBOOMNDADPC, [Optional] AFOKPECFOGN? ENABJOOHJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x4D537A0", Offset = "0x4D523A0", VA = "0x184D537A0")]
	public MJFHCEFLNCG(int MFFEHHIHGMB, CBEJAIEGICM? CMHHGPNFEKI, TimeSpan AFFFOHMECDP, [Optional] IEqualityComparer<TKey>? FMNEKIDPBFC, [Optional] FMMEFPIMJJP? JBOOMNDADPC, [Optional] AFOKPECFOGN? ENABJOOHJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x4D51200", Offset = "0x4D4FE00", VA = "0x184D51200", Slot = "21")]
	public bool NDMEKNAFHPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x4D510A0", Offset = "0x4D4FCA0", VA = "0x184D510A0", Slot = "22")]
	public bool LOCMHEAGOIP(int FJJGAGKDECJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x4D4FDF0", Offset = "0x4D4E9F0", VA = "0x184D4FDF0")]
	private bool HNLOBPMBMPL(int FJJGAGKDECJ, EBMFEFMGONK NCKCEGPNPKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x4D4E270", Offset = "0x4D4CE70", VA = "0x184D4E270")]
	public void BGCBAJHAPLO(TKey NKANGPLHEGE, TVal MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x4D4DF20", Offset = "0x4D4CB20", VA = "0x184D4DF20", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> HLGDOFMLIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x4D4DF70", Offset = "0x4D4CB70", VA = "0x184D4DF70", Slot = "9")]
	public void Add(TKey NKANGPLHEGE, TVal MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x4D4E690", Offset = "0x4D4D290", VA = "0x184D4E690", Slot = "8")]
	public bool ContainsKey(TKey NKANGPLHEGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x4D52880", Offset = "0x4D51480", VA = "0x184D52880", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> HLGDOFMLIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x4D52770", Offset = "0x4D51370", VA = "0x184D52770", Slot = "10")]
	public bool Remove(TKey NKANGPLHEGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x4D52A60", Offset = "0x4D51660", VA = "0x184D52A60", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> HLGDOFMLIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x4D4FB30", Offset = "0x4D4E730", VA = "0x184D4FB30")]
	private bool HGPPGOFCOIB(TKey NKANGPLHEGE, [Out] TVal MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x4D50B50", Offset = "0x4D4F750", VA = "0x184D50B50")]
	private TVal IMOGIGFHIEP(TKey OJEMGKJCJDB)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x4D52C30", Offset = "0x4D51830", VA = "0x184D52C30", Slot = "11")]
	public bool TryGetValue(TKey OJEMGKJCJDB, [Out] TVal MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x4D4E4F0", Offset = "0x4D4D0F0", VA = "0x184D4E4F0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x4D4E700", Offset = "0x4D4D300", VA = "0x184D4E700", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] CPOMPIIIEGC, int LECIFCCAAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x4D4EE20", Offset = "0x4D4DA20", VA = "0x184D4EE20")]
	private void FPIDGAKFOON(TKey NKANGPLHEGE, TVal ODFJOPDFEGP, EBMFEFMGONK NCKCEGPNPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4D51940", Offset = "0x4D50540", VA = "0x184D51940")]
	private bool OLIKMMGOEFM(OPCLNHJIDMF DFCMCBFICLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x4D51AD0", Offset = "0x4D506D0", VA = "0x184D51AD0")]
	private void PNMDLCBIOGL(LinkedListNode<OPCLNHJIDMF> FFKCLDAMDKI, TVal PLAOPLEFGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x4D4F440", Offset = "0x4D4E040", VA = "0x184D4F440")]
	private void GPELINLBKLH(TKey NKANGPLHEGE, TVal MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x4D50E80", Offset = "0x4D4FA80", VA = "0x184D50E80")]
	private void KFFDGCFAIEB(OPCLNHJIDMF DFCMCBFICLM, TVal PLAOPLEFGKN, int JEHKPKCIHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x4D4F7C0", Offset = "0x4D4E3C0", VA = "0x184D4F7C0", Slot = "19")]
	[IteratorStateMachine(typeof(MJFHCEFLNCG<, >.JEJIEIGPMBE))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4D52BF0", Offset = "0x4D517F0", VA = "0x184D52BF0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public enum EBMFEFMGONK : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class MGDNDOLFBGM<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly TKey CJKPBDCDHLK;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x4D439A0", Offset = "0x4D425A0", VA = "0x184D439A0")]
	public MGDNDOLFBGM(TKey JEIDJECONOE, Exception HPLHIDGGGDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class JNLPDBIPKMJ : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6821BF0", Offset = "0x68207F0", VA = "0x186821BF0")]
	public JNLPDBIPKMJ(string KBPDEFFIKOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class NIDMLILKNFO<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class PIGEJOIBAOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public NIDMLILKNFO<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public PIGEJOIBAOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5047BC0", Offset = "0x50467C0", VA = "0x185047BC0")]
		internal Task<TResource> NIEGGPDAIGG(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct CCOGCFMLIBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public NIDMLILKNFO<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x59B9990", Offset = "0x59B8590", VA = "0x1859B9990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x59BA0B0", Offset = "0x59B8CB0", VA = "0x1859BA0B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct HPLLMCHKFGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x463F180", Offset = "0x463DD80", VA = "0x18463F180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x463FE80", Offset = "0x463EA80", VA = "0x18463FE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly MAHBLKOPOLL<TId, Task<TResource>> AOCHDLCPKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> AKJCDBIMLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? PLJHIEOFAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly Action<TResource>? KGBFHGPHMOB;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x4E05730", Offset = "0x4E04330", VA = "0x184E05730")]
	public NIDMLILKNFO(int OKJDDIBBPHA = 0, [Optional] IEqualityComparer<TId>? AJMKDANJFOH, [Optional] Func<TId, CancellationToken, Task<TResource>>? FONIJMEKCDD, [Optional] Action<TResource>? GLFHAJHHKHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x4E04070", Offset = "0x4E02C70", VA = "0x184E04070")]
	public PAGNEAPPJJN<Task<TResource>> DFDDPHPBNNL(TId HGEMPDBGGBJ, [Optional] Func<TId, CancellationToken, Task<TResource>>? FONIJMEKCDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x4E04BC0", Offset = "0x4E037C0", VA = "0x184E04BC0")]
	private void LDPKOMCCOKH(Task<TResource> LFJIOJDNNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x4E04940", Offset = "0x4E03540", VA = "0x184E04940")]
	[AsyncStateMachine(typeof(NIDMLILKNFO<, >.CCOGCFMLIBM))]
	private Task GNPJBJLJPIJ(Task<TResource> LFJIOJDNNEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4D7F550", Offset = "0x4D7E150", VA = "0x184D7F550")]
	public void COPJFCALJGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4E04A40", Offset = "0x4E03640", VA = "0x184E04A40")]
	public MAHBLKOPOLL<TId, Task<TResource>>.ANGONNLJHFL HCMJLOGCBCL()
	{
		return default(MAHBLKOPOLL<TId, Task<TResource>>.ANGONNLJHFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4E05690", Offset = "0x4E04290", VA = "0x184E05690", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4E05690", Offset = "0x4E04290", VA = "0x184E05690", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4E05410", Offset = "0x4E04010", VA = "0x184E05410")]
	[AsyncStateMachine(typeof(NIDMLILKNFO<, >.HPLLMCHKFGI))]
	[CompilerGenerated]
	internal static Task NNOMKIJGHIL(Task<TResource> LFJIOJDNNEN, CancellationTokenSource LJCFPGNHBKK, Dictionary<Task<TResource>, CancellationTokenSource> DLFEFBOFBJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class MAHBLKOPOLL<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private sealed class AGFHHHDOFOB : IEquatable<AGFHHHDOFOB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public readonly TValue GNLOKINMAMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int KBNCNKGIDHK;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xF8D040", Offset = "0xF8BC40", VA = "0x180F8D040")]
		public AGFHHHDOFOB(TValue MPDLOLIOGJL, int IGLMNELFHHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x4665450", Offset = "0x4664050", VA = "0x184665450", Slot = "4")]
		public bool Equals(AGFHHHDOFOB? PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x46654E0", Offset = "0x46640E0", VA = "0x1846654E0", Slot = "0")]
		public override bool Equals(object? CFMCKCBBBKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4665590", Offset = "0x4664190", VA = "0x184665590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public struct ANGONNLJHFL : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private Dictionary<TKey, AGFHHHDOFOB>.Enumerator FAEEGBCNGBB;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x4775280", Offset = "0x4773E80", VA = "0x184775280", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public (TKey Key, TValue Value, int RefCount) OAKKBGDNIKI
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x4775910", Offset = "0x4774510", VA = "0x184775910", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4775550", Offset = "0x4774150", VA = "0x184775550")]
		public ANGONNLJHFL(MAHBLKOPOLL<TKey, TValue> FLHCIALOJPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4774EC0", Offset = "0x4773AC0", VA = "0x184774EC0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x4774F00", Offset = "0x4773B00", VA = "0x184774F00", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x4774FC0", Offset = "0x4773BC0", VA = "0x184774FC0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class CAIEKBPCCGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public MAHBLKOPOLL<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public AGFHHHDOFOB refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public CAIEKBPCCGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x59B5EF0", Offset = "0x59B4AF0", VA = "0x1859B5EF0")]
		internal void NIEGGPDAIGG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly Dictionary<TKey, AGFHHHDOFOB> OOLPABMHBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly Func<TKey, TValue>? KNHBEIKOCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly Action<TValue>? LBHOFMOOMHF;

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x4D259D0", Offset = "0x4D245D0", VA = "0x184D259D0")]
	public MAHBLKOPOLL(int OKJDDIBBPHA = 0, [Optional] IEqualityComparer<TKey>? FMNEKIDPBFC, [Optional] Func<TKey, TValue>? BOFPNMIKCHN, [Optional] Action<TValue>? CIFJGLBNNEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x4D249A0", Offset = "0x4D235A0", VA = "0x184D249A0")]
	public PAGNEAPPJJN<TValue> DFDDPHPBNNL(TKey NKANGPLHEGE, [Optional] Func<TKey, TValue>? BINHCLHDMEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x4D25350", Offset = "0x4D23F50", VA = "0x184D25350")]
	private void GFEMBPJJFIN(TKey NKANGPLHEGE, AGFHHHDOFOB PJBKGONKHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x4D23FD0", Offset = "0x4D22BD0", VA = "0x184D23FD0")]
	public void COPJFCALJGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x4D25720", Offset = "0x4D24320", VA = "0x184D25720")]
	public ANGONNLJHFL HCMJLOGCBCL()
	{
		return default(ANGONNLJHFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x4D257E0", Offset = "0x4D243E0", VA = "0x184D257E0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x4D257E0", Offset = "0x4D243E0", VA = "0x184D257E0", Slot = "5")]
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
