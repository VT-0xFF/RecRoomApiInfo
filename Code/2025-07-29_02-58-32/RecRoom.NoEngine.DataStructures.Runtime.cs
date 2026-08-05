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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8471220", Offset = "0x846FC20", VA = "0x188471220")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
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
		[Cpp2IlInjected.Address(RVA = "0xAB0150", Offset = "0xAAEB50", VA = "0x180AB0150")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class FHDNCLIGCFP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	protected FHDNCLIGCFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class GKLGEPEEABJ<T> : FHDNCLIGCFP
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct LIIAADMPLLF
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum MFMHPFPCJAP
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
		public MFMHPFPCJAP AEOGKDPPBBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T FOAIPBIEILM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int NGLCCPBLMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool HKECCEBKKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool CJMOKGPCNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? ENNKKMKJGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<LIIAADMPLLF>? LKNCBNJNJGG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool EHBFKIJNFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4FAF870", Offset = "0x4FAE270", VA = "0x184FAF870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4FAF8C0", Offset = "0x4FAE2C0", VA = "0x184FAF8C0")]
	protected GKLGEPEEABJ(bool CJMOKGPCNFD, bool HKECCEBKKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4FAF300", Offset = "0x4FADD00", VA = "0x184FAF300")]
	protected bool KODCANIBBMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4FAF760", Offset = "0x4FAE160", VA = "0x184FAF760")]
	protected void OCGJHBIKHHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4FAF3A0", Offset = "0x4FADDA0", VA = "0x184FAF3A0")]
	protected void LNBCOPOLFFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x43FAA60", Offset = "0x43F9460", VA = "0x1843FAA60")]
	private static void KEJMJCINGIP<U>(List<U>? CKDFPBCCFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4FAF580", Offset = "0x4FADF80", VA = "0x184FAF580", Slot = "4")]
	public void MJGPLOFFIKO(T FOAIPBIEILM, bool JPDCKPIAIOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4FAEFC0", Offset = "0x4FAD9C0", VA = "0x184FAEFC0", Slot = "5")]
	public void BBOPECIHIDA(T FOAIPBIEILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4FAF180", Offset = "0x4FADB80", VA = "0x184FAF180")]
	public void CHLOADNGFGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class HPDJJKCNBLF : GKLGEPEEABJ<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x846F820", Offset = "0x846E220", VA = "0x18846F820")]
	public HPDJJKCNBLF(bool CJMOKGPCNFD = false, bool HKECCEBKKKE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x846F560", Offset = "0x846DF60", VA = "0x18846F560")]
	public void ELEPNCJAFML()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x846F760", Offset = "0x846E160", VA = "0x18846F760")]
	public static HPDJJKCNBLF LCKFBKBKBME(HPDJJKCNBLF IGKECFNMFOC, Action FOAIPBIEILM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x846F7C0", Offset = "0x846E1C0", VA = "0x18846F7C0")]
	public static HPDJJKCNBLF OPFALCACKAA(HPDJJKCNBLF IGKECFNMFOC, Action FOAIPBIEILM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DACKGJKPOID<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJGPLOFFIKO(Action<T> FOAIPBIEILM, bool JPDCKPIAIOD = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BBOPECIHIDA(Action<T> FOAIPBIEILM);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class ECMKKKEPCGP<T> : GKLGEPEEABJ<Action<T>>, DACKGJKPOID<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x491B8A0", Offset = "0x491A2A0", VA = "0x18491B8A0")]
	public ECMKKKEPCGP(bool CJMOKGPCNFD = false, bool HKECCEBKKKE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x491B0D0", Offset = "0x4919AD0", VA = "0x18491B0D0")]
	public void ELEPNCJAFML(T JCAFCJGCHAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x491B780", Offset = "0x491A180", VA = "0x18491B780")]
	public static ECMKKKEPCGP<T> LCKFBKBKBME(ECMKKKEPCGP<T> IGKECFNMFOC, Action<T> FOAIPBIEILM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x491B810", Offset = "0x491A210", VA = "0x18491B810")]
	public static ECMKKKEPCGP<T> OPFALCACKAA(ECMKKKEPCGP<T> IGKECFNMFOC, Action<T> FOAIPBIEILM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HGOHLKJEKIF<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJGPLOFFIKO(Action<T, U> FOAIPBIEILM, bool JPDCKPIAIOD = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BBOPECIHIDA(Action<T, U> FOAIPBIEILM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class NCMMNGPOLDF<T, U> : GKLGEPEEABJ<Action<T, U>>, HGOHLKJEKIF<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x491B8A0", Offset = "0x491A2A0", VA = "0x18491B8A0")]
	public NCMMNGPOLDF(bool CJMOKGPCNFD = false, bool HKECCEBKKKE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x58AB180", Offset = "0x58A9B80", VA = "0x1858AB180")]
	public void ELEPNCJAFML(T JCAFCJGCHAJ, U GBONDAEMBAB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x491B780", Offset = "0x491A180", VA = "0x18491B780")]
	public static NCMMNGPOLDF<T, U> LCKFBKBKBME(NCMMNGPOLDF<T, U> IGKECFNMFOC, Action<T, U> FOAIPBIEILM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x491B810", Offset = "0x491A210", VA = "0x18491B810")]
	public static NCMMNGPOLDF<T, U> OPFALCACKAA(NCMMNGPOLDF<T, U> IGKECFNMFOC, Action<T, U> FOAIPBIEILM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class BNGHPJPHPGN<T, U, V> : GKLGEPEEABJ<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x491B8A0", Offset = "0x491A2A0", VA = "0x18491B8A0")]
	public BNGHPJPHPGN(bool CJMOKGPCNFD = false, bool HKECCEBKKKE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x65AEB10", Offset = "0x65AD510", VA = "0x1865AEB10")]
	public void ELEPNCJAFML(T JCAFCJGCHAJ, U GBONDAEMBAB, V ELPCBPJLJEF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x491B780", Offset = "0x491A180", VA = "0x18491B780")]
	public static BNGHPJPHPGN<T, U, V> LCKFBKBKBME(BNGHPJPHPGN<T, U, V> IGKECFNMFOC, Action<T, U, V> FOAIPBIEILM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x491B810", Offset = "0x491A210", VA = "0x18491B810")]
	public static BNGHPJPHPGN<T, U, V> OPFALCACKAA(BNGHPJPHPGN<T, U, V> IGKECFNMFOC, Action<T, U, V> FOAIPBIEILM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HLHINIMDNHI<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class CPJCDBHIPOP<T, U, V, W> : GKLGEPEEABJ<Action<T, U, V, W>>, HLHINIMDNHI<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x491B8A0", Offset = "0x491A2A0", VA = "0x18491B8A0")]
	public CPJCDBHIPOP(bool CJMOKGPCNFD = false, bool HKECCEBKKKE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6A51630", Offset = "0x6A50030", VA = "0x186A51630")]
	public void ELEPNCJAFML(T JCAFCJGCHAJ, U GBONDAEMBAB, V ELPCBPJLJEF, W CINPCLDHBLP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x491B780", Offset = "0x491A180", VA = "0x18491B780")]
	public static CPJCDBHIPOP<T, U, V, W> LCKFBKBKBME(CPJCDBHIPOP<T, U, V, W> IGKECFNMFOC, Action<T, U, V, W> FOAIPBIEILM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x491B810", Offset = "0x491A210", VA = "0x18491B810")]
	public static CPJCDBHIPOP<T, U, V, W> OPFALCACKAA(CPJCDBHIPOP<T, U, V, W> IGKECFNMFOC, Action<T, U, V, W> FOAIPBIEILM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class LOLLGNPFGLA<T, U, V, W, X> : GKLGEPEEABJ<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x491B8A0", Offset = "0x491A2A0", VA = "0x18491B8A0")]
	public LOLLGNPFGLA(bool CJMOKGPCNFD = false, bool HKECCEBKKKE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5624800", Offset = "0x5623200", VA = "0x185624800")]
	public void ELEPNCJAFML(T JCAFCJGCHAJ, U GBONDAEMBAB, V ELPCBPJLJEF, W CINPCLDHBLP, X IECENJOJFJH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x491B780", Offset = "0x491A180", VA = "0x18491B780")]
	public static LOLLGNPFGLA<T, U, V, W, X> LCKFBKBKBME(LOLLGNPFGLA<T, U, V, W, X> IGKECFNMFOC, Action<T, U, V, W, X> FOAIPBIEILM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x491B810", Offset = "0x491A210", VA = "0x18491B810")]
	public static LOLLGNPFGLA<T, U, V, W, X> OPFALCACKAA(LOLLGNPFGLA<T, U, V, W, X> IGKECFNMFOC, Action<T, U, V, W, X> FOAIPBIEILM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class BOEMFHMECPI<T, U, V, W, X, Y> : GKLGEPEEABJ<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x491B8A0", Offset = "0x491A2A0", VA = "0x18491B8A0")]
	public BOEMFHMECPI(bool CJMOKGPCNFD = false, bool HKECCEBKKKE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x65B0CD0", Offset = "0x65AF6D0", VA = "0x1865B0CD0")]
	public void ELEPNCJAFML(T JCAFCJGCHAJ, U GBONDAEMBAB, V ELPCBPJLJEF, W CINPCLDHBLP, X IECENJOJFJH, Y OFOCBNJJIJE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x491B780", Offset = "0x491A180", VA = "0x18491B780")]
	public static BOEMFHMECPI<T, U, V, W, X, Y> LCKFBKBKBME(BOEMFHMECPI<T, U, V, W, X, Y> IGKECFNMFOC, Action<T, U, V, W, X, Y> FOAIPBIEILM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x491B810", Offset = "0x491A210", VA = "0x18491B810")]
	public static BOEMFHMECPI<T, U, V, W, X, Y> OPFALCACKAA(BOEMFHMECPI<T, U, V, W, X, Y> IGKECFNMFOC, Action<T, U, V, W, X, Y> FOAIPBIEILM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class EMDMJBCFPJM<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly JNGKBOCCLBG<TKey, TVal> MBAKHKJCOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> ALOEMDCEMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly JNGKBOCCLBG<TKey, TVal>.OOBHJFNFCMN? BGCAFDFCBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int HDFGBFADFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly JNGKBOCCLBG<TKey, TVal>.JPBMKGALLEE? ICNCLEPGMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int FPPDCHEBKGL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int KINDFLGNOIN
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x49463E0", Offset = "0x4944DE0", VA = "0x1849463E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int PCFFJHIKDDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5B0", Offset = "0xA8CFB0", VA = "0x180A8E5B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4946A20", Offset = "0x4945420", VA = "0x184946A20")]
	public EMDMJBCFPJM(int HDFGBFADFDN, [Optional] JNGKBOCCLBG<TKey, TVal>.JPBMKGALLEE? ICNCLEPGMHO, [Optional] IEqualityComparer<TKey>? KJPAEDCKHPB, [Optional] JNGKBOCCLBG<TKey, TVal>.OOBHJFNFCMN? BGCAFDFCBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4946120", Offset = "0x4944B20", VA = "0x184946120")]
	public void GEJIBPHJFFC(TKey LNBCHJPEENA, TVal PDKJBMPOMNC, bool GNGDCEBJBCB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4945C00", Offset = "0x4944600", VA = "0x184945C00")]
	public bool CHIDKKOIBPL(TKey LNBCHJPEENA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4946940", Offset = "0x4945340", VA = "0x184946940")]
	public bool PKNEHCKDABA(TKey DPMAHEFJMND, [Out] TVal PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4945EC0", Offset = "0x49448C0", VA = "0x184945EC0")]
	private void GDAHBAOBFBE(TKey LNBCHJPEENA, TVal PDKJBMPOMNC, int CGAAPEOHPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4945A70", Offset = "0x4944470", VA = "0x184945A70")]
	public bool BCKOLEIONFK(TKey LNBCHJPEENA, TVal PDKJBMPOMNC, bool GNGDCEBJBCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4945D30", Offset = "0x4944730", VA = "0x184945D30")]
	public void CHLOADNGFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4946430", Offset = "0x4944E30", VA = "0x184946430")]
	private void NCFOKENHOPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x49462F0", Offset = "0x4944CF0", VA = "0x1849462F0")]
	private bool IKPGJIELAMN(TKey LNBCHJPEENA, JACODOEMHHC HDDLNGLMMKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4945990", Offset = "0x4944390", VA = "0x184945990")]
	private void BBPEEKKPFDI(TKey LNBCHJPEENA, TVal PDKJBMPOMNC, JACODOEMHHC HDDLNGLMMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4945D90", Offset = "0x4944790", VA = "0x184945D90")]
	private void FPDDJEHNEGJ(TKey LNBCHJPEENA, TVal BEAEDIJJJJI, JACODOEMHHC HDDLNGLMMKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NMMECKBBFHN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action KIEJMFMAFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool AIEKNMJDMDD;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	public NMMECKBBFHN(Action KBMFALAJOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x84711E0", Offset = "0x846FBE0", VA = "0x1884711E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3AD8CA0", Offset = "0x3AD76A0", VA = "0x183AD8CA0")]
	public static GBIBCLBHEOL<T> OIDBKGGJJLH<T>(T PDKJBMPOMNC, Action KBMFALAJOBF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class GBIBCLBHEOL<T> : NMMECKBBFHN where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T BHKLFFIKDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4F41CB0", Offset = "0x4F406B0", VA = "0x184F41CB0")]
	public GBIBCLBHEOL(T PDKJBMPOMNC, Action KBMFALAJOBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class GEPIOHPHLLO<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly MCOMNFANJAF<T>? LAHGMFOBFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> CJDNDCFKLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool AIEKNMJDMDD;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly GEPIOHPHLLO<T> MFNPHNGAJMG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> ALGKJDLLLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4F55930", Offset = "0x4F54330", VA = "0x184F55930")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long NOMMIDHMEJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4F55AD0", Offset = "0x4F544D0", VA = "0x184F55AD0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool OFLDDHIICNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4F55630", Offset = "0x4F54030", VA = "0x184F55630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4F55D90", Offset = "0x4F54790", VA = "0x184F55D90")]
	public GEPIOHPHLLO(MCOMNFANJAF<T> CICPHFBNLIH, MCOMNFANJAF<T> DDLIAKABKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4F55E60", Offset = "0x4F54860", VA = "0x184F55E60")]
	public GEPIOHPHLLO(MCOMNFANJAF<T> CICPHFBNLIH, int EMMDOKDGNJD, MCOMNFANJAF<T> DDLIAKABKPK, int LDBMCCHNJKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4F56200", Offset = "0x4F54C00", VA = "0x184F56200")]
	private GEPIOHPHLLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4F55830", Offset = "0x4F54230", VA = "0x184F55830", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4F556F0", Offset = "0x4F540F0", VA = "0x184F556F0")]
	public T[] DGBABFIBOIC()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4F559B0", Offset = "0x4F543B0", VA = "0x184F559B0")]
	public static ReadOnlySequence<T> LHJBCIIELME(GEPIOHPHLLO<T>? ELPPHIEIIDB)
	{
		return default(ReadOnlySequence<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct EGHGEHPPJAF<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly IDisposable IIMGDAGJIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public T BHKLFFIKDPE;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4933E30", Offset = "0x4932830", VA = "0x184933E30")]
	public EGHGEHPPJAF(IDisposable ICBGFNPAHKN, [In] T PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x42AFE50", Offset = "0x42AE850", VA = "0x1842AFE50")]
	public static EGHGEHPPJAF<U> NANJOBDKNHF<U>([In] EGHGEHPPJAF<T> ICBGFNPAHKN, [In] U PDKJBMPOMNC) where U : notnull
	{
		return default(EGHGEHPPJAF<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4933D90", Offset = "0x4932790", VA = "0x184933D90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class OPMPNEBFFAG
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3E516F0", Offset = "0x3E500F0", VA = "0x183E516F0")]
	public static EGHGEHPPJAF<T> MDDJOGPLAFO<T>(IDisposable ICBGFNPAHKN, [In] T PDKJBMPOMNC) where T : notnull
	{
		return default(EGHGEHPPJAF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3E51690", Offset = "0x3E50090", VA = "0x183E51690")]
	public static EGHGEHPPJAF<T> DHNOEHPMOKP<T>([In] this EGHGEHPPJAF<T> NLDLHIJAJBO, [Out] T PDKJBMPOMNC) where T : notnull
	{
		return default(EGHGEHPPJAF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3CF5D50", Offset = "0x3CF4750", VA = "0x183CF5D50")]
	public static EGHGEHPPJAF<U?> NANJOBDKNHF<U, T>([In] EGHGEHPPJAF<T> KCMNKNOFKEF, [In] U PDKJBMPOMNC)
	{
		return default(EGHGEHPPJAF<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct HGNCEMOPDGA : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct PAGEGAMLPEE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480")]
		public static PAGEGAMLPEE MDDJOGPLAFO()
		{
			return default(PAGEGAMLPEE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x846F520", Offset = "0x846DF20", VA = "0x18846F520")]
	public static string ENIIJCEEGDK(Type AEOGKDPPBBE, [Optional] string? ANJPINKLHAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3C813C0", Offset = "0x3C7FDC0", VA = "0x183C813C0")]
	public static string? ENIIJCEEGDK<T>([Optional] string? ANJPINKLHAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3C81340", Offset = "0x3C7FD40", VA = "0x183C81340")]
	public static string? CIKNMJPEPMH<T>([Optional] string? OJBJGNPGMFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480")]
	public static HGNCEMOPDGA DIKKIOCKMLC(string ANJPINKLHAP, string? OJBJGNPGMFG)
	{
		return default(HGNCEMOPDGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct IGHHDAKNEEA
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate bool NEMFLOMFCIB(string DCPJNADFNLD, IGHHDAKNEEA IJAFHFFLKOB);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class KKFJOFMKGNG<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public KKFJOFMKGNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x54F90A0", Offset = "0x54F7AA0", VA = "0x1854F90A0")]
		internal void NMPIIAAFFLI(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public int IGABBOEDEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public string JIPOFOKLOJJ;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x846FC40", Offset = "0x846E640", VA = "0x18846FC40")]
	public static Dictionary<string, IGHHDAKNEEA> AMEPKHPAGII(Type OMAGHKKMDBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3CB0B70", Offset = "0x3CAF570", VA = "0x183CB0B70")]
	public static Dictionary<string, IGHHDAKNEEA> AMEPKHPAGII<T>(Type OMAGHKKMDBN, IReadOnlyDictionary<T, string> GIONHBDCMBI) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3CB13A0", Offset = "0x3CAFDA0", VA = "0x183CB13A0")]
	public static Dictionary<string, IGHHDAKNEEA> DENACMIEFCC<T>(List<T> JALBAOPNMCK) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x846F880", Offset = "0x846E280", VA = "0x18846F880")]
	public static Dictionary<string, IGHHDAKNEEA> ADLBDBOGJEJ(Type OMAGHKKMDBN, NEMFLOMFCIB HFMFMELNHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x846FF70", Offset = "0x846E970", VA = "0x18846FF70")]
	public static Dictionary<int, string> PBCFODJPIKC(Dictionary<string, IGHHDAKNEEA> PEIDNFHKHFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class OGOHDADDIPM : NHMKHEEENDM
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool EIMKKKNEJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly string? AINLINEHCLF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual NHMKHEEENDM? ABKABENKDNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8471940", Offset = "0x8470340", VA = "0x188471940")]
	protected OGOHDADDIPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string GIDIGOEEAJA();

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8471700", Offset = "0x8470100", VA = "0x188471700", Slot = "8")]
	public virtual string IBCCEPEBFIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8471460", Offset = "0x846FE60", VA = "0x188471460", Slot = "9")]
	public void HIJNLBPOKCD(StringBuilder AHDCFMKAOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8471400", Offset = "0x846FE00", VA = "0x188471400", Slot = "10")]
	public void EDPBOHCEIGO(StringBuilder AHDCFMKAOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8471820", Offset = "0x8470220", VA = "0x188471820", Slot = "11")]
	public void POODJKGLKLF(StringBuilder AHDCFMKAOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x84712A0", Offset = "0x846FCA0", VA = "0x1884712A0", Slot = "12")]
	public void AMCDJJLPBGC(StringBuilder AHDCFMKAOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8471780", Offset = "0x8470180", VA = "0x188471780")]
	public static void IDJFMBOCENE(StringBuilder AHDCFMKAOPA, string KAGDIKHFOCM, string BLGFCIEMMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x73564E0", Offset = "0x7354EE0", VA = "0x1873564E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HCJEBGFOLJP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x846F4C0", Offset = "0x846DEC0", VA = "0x18846F4C0")]
	public HCJEBGFOLJP(string ONGDPODJNBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class EMGEPDGBOKO<TErr> : HCJEBGFOLJP where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly TErr NMCKAHBIKKP;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x49472E0", Offset = "0x4945CE0", VA = "0x1849472E0")]
	private EMGEPDGBOKO([In] TErr HNDICJAPCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4947210", Offset = "0x4945C10", VA = "0x184947210")]
	public static EMGEPDGBOKO<TErr> MDDJOGPLAFO([In] TErr HNDICJAPCAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class PCFGMABODBA : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashAlgorithm CAJDKGHPEJO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool LIDECCKEJFI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool KHNAPDDBMPB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool CAJGNJNOBIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long NOMMIDHMEJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8471D80", Offset = "0x8470780", VA = "0x188471D80", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long FLMJNMGJKCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8471DF0", Offset = "0x84707F0", VA = "0x188471DF0", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8471E60", Offset = "0x8470860", VA = "0x188471E60", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8471D10", Offset = "0x8470710", VA = "0x188471D10")]
	public PCFGMABODBA(HashAlgorithm CAJDKGHPEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8471B30", Offset = "0x8470530", VA = "0x188471B30", Slot = "35")]
	public override int Read(byte[] AEJOONCILAD, int KIOPHNHDMKE, int CDCPIGCEABM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8471CE0", Offset = "0x84706E0", VA = "0x188471CE0", Slot = "38")]
	public override void Write(byte[] AEJOONCILAD, int KIOPHNHDMKE, int CDCPIGCEABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8471BD0", Offset = "0x84705D0", VA = "0x188471BD0", Slot = "33")]
	public override long Seek(long KIOPHNHDMKE, SeekOrigin ENKAPPCINPK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8471C60", Offset = "0x8470660", VA = "0x188471C60", Slot = "34")]
	public override void SetLength(long PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8471A50", Offset = "0x8470450", VA = "0x188471A50")]
	public byte[] JDIHCNBBCGI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface NHMKHEEENDM
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IBCCEPEBFIN();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string GIDIGOEEAJA();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface NEGJJIMNMJB<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions BHKLFFIKDPE
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface OPAFBDPGLHE
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string INLFNNGFCFP
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class MCOMNFANJAF<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static MCOMNFANJAF<T>? KIFNMPGFDPD;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static object BLCBOOHJLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private IMemoryOwner<T>? MPNKAPGJLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool AIEKNMJDMDD;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool HCIBKCBAOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xAE6140", Offset = "0xAE4B40", VA = "0x180AE6140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x580F410", Offset = "0x580DE10", VA = "0x18580F410")]
	private static MCOMNFANJAF<T> NGDEJBNNMAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x580EC90", Offset = "0x580D690", VA = "0x18580EC90")]
	private static void LDBCLGCNHCE(MCOMNFANJAF<T> AAMLMMLMPMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x492DEC0", Offset = "0x492C8C0", VA = "0x18492DEC0")]
	private MCOMNFANJAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x580FB90", Offset = "0x580E590", VA = "0x18580FB90")]
	public static MCOMNFANJAF<T> OIDBKGGJJLH(ReadOnlyMemory<T> DAHCIIGJBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x580F980", Offset = "0x580E380", VA = "0x18580F980")]
	public static MCOMNFANJAF<T> OIDBKGGJJLH(IMemoryOwner<T> NMBHEMNHGDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x580EA60", Offset = "0x580D460", VA = "0x18580EA60")]
	public static void HJGAAMCAJKE(MCOMNFANJAF<T> CICPHFBNLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x580E830", Offset = "0x580D230", VA = "0x18580E830", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x580F8B0", Offset = "0x580E2B0", VA = "0x18580F8B0")]
	public MCOMNFANJAF<T> OHHBGINEBFD(IMemoryOwner<T> NMBHEMNHGDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x580F230", Offset = "0x580DC30", VA = "0x18580F230")]
	private void MOGFGMLNADO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x580EB80", Offset = "0x580D580", VA = "0x18580EB80")]
	private MCOMNFANJAF<T> JHDPJCGDNPG(MCOMNFANJAF<T> AAMLMMLMPMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class BBBNABHPNEK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x846E4A0", Offset = "0x846CEA0", VA = "0x18846E4A0")]
	public BBBNABHPNEK(string ONGDPODJNBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class BLDEJNGJBIJ<TOk> : BBBNABHPNEK where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TOk MNNJGGODCAN;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x65A45B0", Offset = "0x65A2FB0", VA = "0x1865A45B0")]
	private BLDEJNGJBIJ([In] TOk LAGJNCKHOAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x506F9B0", Offset = "0x506E3B0", VA = "0x18506F9B0")]
	public static BLDEJNGJBIJ<TOk> MDDJOGPLAFO([In] TOk LAGJNCKHOAI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct DOHEMIFBILP<TOk, TErr> : IEquatable<DOHEMIFBILP<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly EqualityComparer<TErr> FMHHDFLEEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal readonly TErr NMCKAHBIKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal readonly TOk MNNJGGODCAN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool GAEOJCHDPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4495F30", Offset = "0x4494930", VA = "0x184495F30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool DDIPGNCHCMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x44961D0", Offset = "0x4494BD0", VA = "0x1844961D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x44977C0", Offset = "0x44961C0", VA = "0x1844977C0")]
	internal DOHEMIFBILP([In] TErr HNDICJAPCAA, [In] TOk LAGJNCKHOAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4493FC0", Offset = "0x44929C0", VA = "0x184493FC0")]
	public static DOHEMIFBILP<TOk, TErr> EIONJOMOLOP([In] TErr HNDICJAPCAA)
	{
		return default(DOHEMIFBILP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4495DB0", Offset = "0x44947B0", VA = "0x184495DB0")]
	public static DOHEMIFBILP<TOk, TErr> JOLHFNOGCIA([In] TOk LAGJNCKHOAI)
	{
		return default(DOHEMIFBILP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x42AD1F0", Offset = "0x42ABBF0", VA = "0x1842AD1F0")]
	public DOHEMIFBILP<TOk?, UErr?> MBKCHLEHBJB<UErr>()
	{
		return default(DOHEMIFBILP<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x42ACC10", Offset = "0x42AB610", VA = "0x1842ACC10")]
	public DOHEMIFBILP<UOk?, TErr?> KMEEEICFDKL<UOk>()
	{
		return default(DOHEMIFBILP<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x42AB170", Offset = "0x42A9B70", VA = "0x1842AB170")]
	public DOHEMIFBILP<UOk?, TErr?> FMBEEMDGLIG<UOk>()
	{
		return default(DOHEMIFBILP<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x42AC160", Offset = "0x42AAB60", VA = "0x1842AC160")]
	public DOHEMIFBILP<TOk?, UErr?> JKAGHOOJNEM<UErr>()
	{
		return default(DOHEMIFBILP<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4493BC0", Offset = "0x44925C0", VA = "0x184493BC0")]
	public DOHEMIFBILP<FAIGCFGAAKD, TErr> BIGNLBJFFIA()
	{
		return default(DOHEMIFBILP<FAIGCFGAAKD, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4495770", Offset = "0x4494170", VA = "0x184495770")]
	public static bool JJNADAGGMDE([In] DOHEMIFBILP<TOk, TErr> OKDCNKNEMHO, [In] DOHEMIFBILP<TOk, TErr> AAJFLFEAFBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4494390", Offset = "0x4492D90", VA = "0x184494390", Slot = "4")]
	public bool Equals(DOHEMIFBILP<TOk, TErr> EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4494200", Offset = "0x4492C00", VA = "0x184494200", Slot = "0")]
	public override bool Equals(object EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4494910", Offset = "0x4493310", VA = "0x184494910", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7045F80", Offset = "0x7044980", VA = "0x187045F80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class JEKJAANOBNB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct NEOEJAECBFG<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Task<DOHEMIFBILP<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<DOHEMIFBILP<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x58B0760", Offset = "0x58AF160", VA = "0x1858B0760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5042390", Offset = "0x5040D90", VA = "0x185042390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct FGDELFKFLCN<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<DOHEMIFBILP<FAIGCFGAAKD, TErr>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Task<DOHEMIFBILP<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<DOHEMIFBILP<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x4DFC170", Offset = "0x4DFAB70", VA = "0x184DFC170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x4DFC4C0", Offset = "0x4DFAEC0", VA = "0x184DFC4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3CF8C10", Offset = "0x3CF7610", VA = "0x183CF8C10")]
	public static DOHEMIFBILP<TOk?, TErr?> MNNJGGODCAN<TOk, TErr>([In] this DOHEMIFBILP<TOk, TErr> NLDLHIJAJBO, [In] TOk LAGJNCKHOAI)
	{
		return default(DOHEMIFBILP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3CF8C50", Offset = "0x3CF7650", VA = "0x183CF8C50")]
	public static DOHEMIFBILP<FAIGCFGAAKD, TErr?> MNNJGGODCAN<TErr>([In] this DOHEMIFBILP<FAIGCFGAAKD, TErr> NLDLHIJAJBO)
	{
		return default(DOHEMIFBILP<FAIGCFGAAKD, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3CF8C10", Offset = "0x3CF7610", VA = "0x183CF8C10")]
	public static DOHEMIFBILP<TOk?, TErr?> NMCKAHBIKKP<TOk, TErr>([In] this DOHEMIFBILP<TOk, TErr> NLDLHIJAJBO, [In] TErr HNDICJAPCAA)
	{
		return default(DOHEMIFBILP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3CF7990", Offset = "0x3CF6390", VA = "0x183CF7990")]
	public static TOk? JJEAJLNBCGL<TOk, TErr>([In] this DOHEMIFBILP<TOk, TErr> NLDLHIJAJBO)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3CF7140", Offset = "0x3CF5B40", VA = "0x183CF7140")]
	[AsyncStateMachine(typeof(NEOEJAECBFG<, >))]
	public static Task<TOk?>? GECBBNLKBME<TOk, TErr>(this Task<DOHEMIFBILP<TOk, TErr>> NLDLHIJAJBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3CF7620", Offset = "0x3CF6020", VA = "0x183CF7620")]
	public static TErr? JHOJOPHDHBB<TErr, TOk>([In] this DOHEMIFBILP<TOk, TErr> NLDLHIJAJBO)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3CF9130", Offset = "0x3CF7B30", VA = "0x183CF9130")]
	public static bool PGPEHBGBGIO<TOk, TErr, UErr, UOk>([In] this DOHEMIFBILP<TOk, TErr> NLDLHIJAJBO, [Out] DOHEMIFBILP<UOk, UErr> BLBDGDFNKKJ) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3CF8180", Offset = "0x3CF6B80", VA = "0x183CF8180")]
	public static bool KKJIKABIDOO<TOk, TErr>([In] this DOHEMIFBILP<TOk, TErr> NLDLHIJAJBO, [Out] TOk LAGJNCKHOAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3CF69D0", Offset = "0x3CF53D0", VA = "0x183CF69D0")]
	public static bool CJDIHGJMNFE<TOk, TErr>([In] this DOHEMIFBILP<TOk, TErr> NLDLHIJAJBO, [Out][NotNullWhen(true)] TErr HNDICJAPCAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3CF6E60", Offset = "0x3CF5860", VA = "0x183CF6E60")]
	public static bool EIOKDBNKEFM<TOk, TErr>([In] this DOHEMIFBILP<TOk, TErr> NLDLHIJAJBO, [Out][NotNullWhen(true)] TOk LAGJNCKHOAI, [Out][NotNullWhen(false)] TErr HNDICJAPCAA) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3CF6CD0", Offset = "0x3CF56D0", VA = "0x183CF6CD0")]
	public static bool DGLMGPHPNAL<TOk, TErr>([In] this DOHEMIFBILP<TOk, TErr> NLDLHIJAJBO, [Out][NotNullWhen(true)] TOk LAGJNCKHOAI, [Out] DOHEMIFBILP<TOk, TErr> BLBDGDFNKKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3CF9010", Offset = "0x3CF7A10", VA = "0x183CF9010")]
	public static bool PGPEHBGBGIO<TOk, TErr, UErr, UOk>([In] this DOHEMIFBILP<TOk, TErr> NLDLHIJAJBO, [Out][NotNullWhen(true)] TOk LAGJNCKHOAI, [Out] DOHEMIFBILP<UOk, UErr> BLBDGDFNKKJ) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3CF8820", Offset = "0x3CF7220", VA = "0x183CF8820")]
	public static bool LPKINFFBGAG<TOk, TErr>([In] this DOHEMIFBILP<TOk, TErr> NLDLHIJAJBO, [Out][NotNullWhen(true)] TOk LAGJNCKHOAI, [Out] DOHEMIFBILP<FAIGCFGAAKD, TErr> BLBDGDFNKKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3CF61F0", Offset = "0x3CF4BF0", VA = "0x183CF61F0")]
	public static DOHEMIFBILP<UOk, UErr> AAMNPIEEEBG<UOk, UErr, TOk, TErr>([In] this DOHEMIFBILP<TOk, TErr> NLDLHIJAJBO, [In] DOHEMIFBILP<UOk, UErr> GIGDEGEMDAC) where TOk : UOk where TErr : UErr
	{
		return default(DOHEMIFBILP<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3CF8410", Offset = "0x3CF6E10", VA = "0x183CF8410")]
	public static DOHEMIFBILP<TOk?[]?, TErr?> LDLPOIHHMJC<TOk, TErr>(this IEnumerable<DOHEMIFBILP<TOk, TErr>> NLDLHIJAJBO)
	{
		return default(DOHEMIFBILP<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3CF7F40", Offset = "0x3CF6940", VA = "0x183CF7F40")]
	public static DOHEMIFBILP<UOk?, TErr?> KJFEDBCFOHO<UOk, TErr, TOk>([In] this DOHEMIFBILP<TOk, TErr> NLDLHIJAJBO, Func<TOk, UOk> KBGNMCGLNHC)
	{
		return default(DOHEMIFBILP<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3CF6B10", Offset = "0x3CF5510", VA = "0x183CF6B10")]
	[AsyncStateMachine(typeof(FGDELFKFLCN<, >))]
	public static Task<DOHEMIFBILP<FAIGCFGAAKD, TErr?>>? DBAKOEBJODA<TErr, TOk>(this Task<DOHEMIFBILP<TOk, TErr>> NLDLHIJAJBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class GHFFPPCJDGG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x43FA740", Offset = "0x43F9140", VA = "0x1843FA740")]
	public static DOHEMIFBILP<TOk, T> MNNJGGODCAN<TOk>([In] TOk LAGJNCKHOAI) where TOk : notnull
	{
		return default(DOHEMIFBILP<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4F5C480", Offset = "0x4F5AE80", VA = "0x184F5C480")]
	public static DOHEMIFBILP<FAIGCFGAAKD, T> MNNJGGODCAN()
	{
		return default(DOHEMIFBILP<FAIGCFGAAKD, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x43FA740", Offset = "0x43F9140", VA = "0x1843FA740")]
	public static DOHEMIFBILP<T, TErr> NMCKAHBIKKP<TErr>([In] TErr HNDICJAPCAA) where TErr : notnull
	{
		return default(DOHEMIFBILP<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct DMFDFOCHHLB<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly LFLMNHGAKNA JONOPHDCKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<TKey, TValue> HHJPIBDFLDK;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5166CE0", Offset = "0x51656E0", VA = "0x185166CE0")]
	public static DMFDFOCHHLB<TKey, TValue> MDDJOGPLAFO(string HCLPHJDKMCA)
	{
		return default(DMFDFOCHHLB<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5166E00", Offset = "0x5165800", VA = "0x185166E00")]
	internal DMFDFOCHHLB(Dictionary<TKey, TValue> PDKJBMPOMNC, LFLMNHGAKNA GCHJLMBOALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5166C30", Offset = "0x5165630", VA = "0x185166C30")]
	public KFPHGMFFPGE<TKey, TValue> ICCFNPENPEO([Out] Dictionary<TKey, TValue> PDKJBMPOMNC)
	{
		return default(KFPHGMFFPGE<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct KFPHGMFFPGE<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TKey, TValue> HHJPIBDFLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly KBJIOHMAAIE CFICHGAMAHP;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2CCC950", Offset = "0x2CCB350", VA = "0x182CCC950")]
	internal KFPHGMFFPGE(Dictionary<TKey, TValue> PDKJBMPOMNC, KBJIOHMAAIE JGFKLIGFGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x54F02B0", Offset = "0x54EECB0", VA = "0x1854F02B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct IKOJBLLCMIO<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly LFLMNHGAKNA JONOPHDCKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly HashSet<T> HHJPIBDFLDK;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5166CE0", Offset = "0x51656E0", VA = "0x185166CE0")]
	public static IKOJBLLCMIO<T> MDDJOGPLAFO(string HCLPHJDKMCA)
	{
		return default(IKOJBLLCMIO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5166E00", Offset = "0x5165800", VA = "0x185166E00")]
	internal IKOJBLLCMIO(HashSet<T> PDKJBMPOMNC, LFLMNHGAKNA GCHJLMBOALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5166C30", Offset = "0x5165630", VA = "0x185166C30")]
	public LEHAEKFPIFH<T> ICCFNPENPEO([Out] HashSet<T> PDKJBMPOMNC)
	{
		return default(LEHAEKFPIFH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct LEHAEKFPIFH<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly HashSet<T> HHJPIBDFLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly KBJIOHMAAIE CFICHGAMAHP;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2CCC950", Offset = "0x2CCB350", VA = "0x182CCC950")]
	internal LEHAEKFPIFH(HashSet<T> PDKJBMPOMNC, KBJIOHMAAIE JGFKLIGFGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x54F02B0", Offset = "0x54EECB0", VA = "0x1854F02B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct PDDGFNANLBK<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly LFLMNHGAKNA JONOPHDCKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly Stack<T> HHJPIBDFLDK;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5166CE0", Offset = "0x51656E0", VA = "0x185166CE0")]
	public static PDDGFNANLBK<T> MDDJOGPLAFO(string HCLPHJDKMCA)
	{
		return default(PDDGFNANLBK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5166E00", Offset = "0x5165800", VA = "0x185166E00")]
	internal PDDGFNANLBK(Stack<T> PDKJBMPOMNC, LFLMNHGAKNA GCHJLMBOALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5166C30", Offset = "0x5165630", VA = "0x185166C30")]
	public LJOLDIKNPKE<T> ICCFNPENPEO([Out] Stack<T> PDKJBMPOMNC)
	{
		return default(LJOLDIKNPKE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct LJOLDIKNPKE<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly Stack<T> HHJPIBDFLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly KBJIOHMAAIE CFICHGAMAHP;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2CCC950", Offset = "0x2CCB350", VA = "0x182CCC950")]
	internal LJOLDIKNPKE(Stack<T> PDKJBMPOMNC, KBJIOHMAAIE JGFKLIGFGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x54F02B0", Offset = "0x54EECB0", VA = "0x1854F02B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[DefaultMember("Item")]
public sealed class IJGGIDLOHJH<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct KBEKMMNABGO : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly IJGGIDLOHJH<T> BEIIPNIOBFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly int DLKCDLKDGLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly bool OKPDMCEJGKG;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x291C9A0", Offset = "0x291B3A0", VA = "0x18291C9A0")]
		public KBEKMMNABGO(IJGGIDLOHJH<T> JDFAIEBLNPJ, int HDIOBJHGBIF, bool PANKGBKDPKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x54DCBB0", Offset = "0x54DB5B0", VA = "0x1854DCBB0")]
		public IJGGIDLOHJH<T>.HEMOKFIPCEH IBBMHAHFLHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x54DCCA0", Offset = "0x54DB6A0", VA = "0x1854DCCA0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x54DCCA0", Offset = "0x54DB6A0", VA = "0x1854DCCA0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class HEMOKFIPCEH : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly IJGGIDLOHJH<T> BEIIPNIOBFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly int DKFCJFIDGOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private int KAODNFDGHKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly bool OKPDMCEJGKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private bool LNGCHKMJJNA;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T CEKGODBONJL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x50394D0", Offset = "0x5037ED0", VA = "0x1850394D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x5039680", Offset = "0x5038080", VA = "0x185039680", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x5039890", Offset = "0x5038290", VA = "0x185039890", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5039D10", Offset = "0x5038710", VA = "0x185039D10")]
		public HEMOKFIPCEH(IJGGIDLOHJH<T> JDFAIEBLNPJ, int HDIOBJHGBIF, bool PANKGBKDPKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5039590", Offset = "0x5037F90", VA = "0x185039590", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5039620", Offset = "0x5038020", VA = "0x185039620", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class MPGCEAAAGAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public MPGCEAAAGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x584DA80", Offset = "0x584C480", VA = "0x18584DA80")]
		internal T OKDDNCMJJLP(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly T[] LBMCMJEJKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int KAODNFDGHKF;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int ODJPDMKKKFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5160380", Offset = "0x515ED80", VA = "0x185160380")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T CEKGODBONJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4DE49A0", Offset = "0x4DE33A0", VA = "0x184DE49A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T EILPADPNPDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5160140", Offset = "0x515EB40", VA = "0x185160140")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x51602D0", Offset = "0x515ECD0", VA = "0x1851602D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int NOMMIDHMEJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x28C64B0", Offset = "0x28C4EB0", VA = "0x1828C64B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1D216B0", Offset = "0x1D200B0", VA = "0x181D216B0")]
	private static int PHAFKMIFCNM(int FILGHJLFKAL, int KLLLBPFLPCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x51603D0", Offset = "0x515EDD0", VA = "0x1851603D0")]
	public IJGGIDLOHJH(int CGAAPEOHPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x51604E0", Offset = "0x515EEE0", VA = "0x1851604E0")]
	public IJGGIDLOHJH(int CGAAPEOHPIP, Func<T> HPEPFAAODOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5160440", Offset = "0x515EE40", VA = "0x185160440")]
	public IJGGIDLOHJH(T[] AKIPGEFJGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5160200", Offset = "0x515EC00", VA = "0x185160200")]
	public void IDIDGBGJBNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5160080", Offset = "0x515EA80", VA = "0x185160080")]
	public IEnumerable<T> GLJGNLGPOMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5160170", Offset = "0x515EB70", VA = "0x185160170")]
	public IJGGIDLOHJH<T>.HEMOKFIPCEH IBBMHAHFLHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5011C30", Offset = "0x5010630", VA = "0x185011C30", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5011C30", Offset = "0x5010630", VA = "0x185011C30", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class DLICAPEIIKB
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3AC0E30", Offset = "0x3ABF830", VA = "0x183AC0E30")]
	public static IJGGIDLOHJH<T> MDDJOGPLAFO<T>(int CGAAPEOHPIP, Func<T> HPEPFAAODOA) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static RRColor White
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7060080", Offset = "0x705EA80", VA = "0x187060080")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8472840", Offset = "0x8471240", VA = "0x188472840")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8472860", Offset = "0x8471260", VA = "0x188472860")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x8472880", Offset = "0x8471280", VA = "0x188472880")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x8472820", Offset = "0x8471220", VA = "0x188472820")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2A56D80", Offset = "0x2A55780", VA = "0x182A56D80")]
		public RRColor(float PENFKHFIGID, float FIKNLIIDFCF, float ABNAHAKPDNC, float MLLJGIHINDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x82EC1E0", Offset = "0x82EABE0", VA = "0x1882EC1E0", Slot = "4")]
		public bool Equals(RRColor EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8472470", Offset = "0x8470E70", VA = "0x188472470", Slot = "0")]
		public override bool Equals(object EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8472570", Offset = "0x8470F70", VA = "0x188472570", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x84725F0", Offset = "0x8470FF0", VA = "0x1884725F0", Slot = "5")]
		public string ToString(string NANAIMNHOFH, IFormatProvider JKJEFKEHAOK)
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct RRColor32 : IEquatable<RRColor32>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int rgba;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public byte r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public byte g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public byte b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public byte a;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static RRColor32 White
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8472410", Offset = "0x8470E10", VA = "0x188472410")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x84723B0", Offset = "0x8470DB0", VA = "0x1884723B0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x84723E0", Offset = "0x8470DE0", VA = "0x1884723E0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8472440", Offset = "0x8470E40", VA = "0x188472440")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x8472380", Offset = "0x8470D80", VA = "0x188472380")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x61CC6C0", Offset = "0x61CB0C0", VA = "0x1861CC6C0")]
		public RRColor32(byte PENFKHFIGID, byte FIKNLIIDFCF, byte ABNAHAKPDNC, byte MLLJGIHINDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x245F210", Offset = "0x245DC10", VA = "0x18245F210", Slot = "4")]
		public bool Equals(RRColor32 EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8471EE0", Offset = "0x84708E0", VA = "0x188471EE0", Slot = "0")]
		public override bool Equals(object EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x15654F0", Offset = "0x1563EF0", VA = "0x1815654F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8471F60", Offset = "0x8470960", VA = "0x188471F60")]
		public static RRColor32 LHJBCIIELME(RRColor HFDMMDBJNBG)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x84720B0", Offset = "0x8470AB0", VA = "0x1884720B0")]
		public static RRColor LHJBCIIELME(RRColor32 HFDMMDBJNBG)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8472120", Offset = "0x8470B20", VA = "0x188472120", Slot = "5")]
		public string ToString(string NANAIMNHOFH, IFormatProvider JKJEFKEHAOK)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class BNDONBLPNDK<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct CNNHDANMMJD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly BNDONBLPNDK<T> EAIHMDHBDON;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T BHKLFFIKDPE
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x5DFF700", Offset = "0x5DFE100", VA = "0x185DFF700")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6A4D920", Offset = "0x6A4C320", VA = "0x186A4D920", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xE76700", Offset = "0xE75100", VA = "0x180E76700")]
		public CNNHDANMMJD(BNDONBLPNDK<T> EAIHMDHBDON)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct LMCBNNJDEEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<CNNHDANMMJD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public BNDONBLPNDK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x561C460", Offset = "0x561AE60", VA = "0x18561C460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4E09AB0", Offset = "0x4E084B0", VA = "0x184E09AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly SemaphoreSlim DDIDAAPPJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private T AJDKAFGCBHO;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x65AB8F0", Offset = "0x65AA2F0", VA = "0x1865AB8F0")]
	public BNDONBLPNDK([In] T AJDKAFGCBHO, int DGPMGJGMMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x65AB8D0", Offset = "0x65AA2D0", VA = "0x1865AB8D0")]
	public BNDONBLPNDK([In] T AJDKAFGCBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x65AB3B0", Offset = "0x65A9DB0", VA = "0x1865AB3B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x65AB870", Offset = "0x65AA270", VA = "0x1865AB870")]
	public CNNHDANMMJD MGDFPKMCHBM()
	{
		return default(CNNHDANMMJD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x65AB750", Offset = "0x65AA150", VA = "0x1865AB750")]
	[AsyncStateMachine(typeof(BNDONBLPNDK<>.LMCBNNJDEEP))]
	public Task<BNDONBLPNDK<T>.CNNHDANMMJD> ILGFFFNLIOF(CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x65AB8B0", Offset = "0x65AA2B0", VA = "0x1865AB8B0")]
	public void MKLCFLNJOJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class GMPNGHCKHIO
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x846F450", Offset = "0x846DE50", VA = "0x18846F450")]
	public static BNDONBLPNDK<FAIGCFGAAKD> MDDJOGPLAFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3C75FA0", Offset = "0x3C749A0", VA = "0x183C75FA0")]
	public static BNDONBLPNDK<T> MDDJOGPLAFO<T>([In] T AJDKAFGCBHO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class IMAPFBBPLCK<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public readonly struct OGOLLKDMMFP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly IMAPFBBPLCK<T> EANHGNGMHLJ;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T BHKLFFIKDPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x492B970", Offset = "0x492A370", VA = "0x18492B970")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5A03740", Offset = "0x5A02140", VA = "0x185A03740", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xE76700", Offset = "0xE75100", VA = "0x180E76700")]
		internal OGOLLKDMMFP(IMAPFBBPLCK<T> EAIHMDHBDON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public readonly struct EEHCDEECILM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly IMAPFBBPLCK<T> EANHGNGMHLJ;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T BHKLFFIKDPE
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x492B970", Offset = "0x492A370", VA = "0x18492B970")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x492BA30", Offset = "0x492A430", VA = "0x18492BA30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xE76700", Offset = "0xE75100", VA = "0x180E76700")]
		internal EEHCDEECILM(IMAPFBBPLCK<T> EAIHMDHBDON)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct DFPNNIMLOFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder<EEHCDEECILM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public IMAPFBBPLCK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private BNDONBLPNDK<FAIGCFGAAKD>.CNNHDANMMJD <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<BNDONBLPNDK<FAIGCFGAAKD>.CNNHDANMMJD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6FF9E50", Offset = "0x6FF8850", VA = "0x186FF9E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4E09AB0", Offset = "0x4E084B0", VA = "0x184E09AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly BNDONBLPNDK<int> EIEFIGEJFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly BNDONBLPNDK<FAIGCFGAAKD> IGIMMHNICCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly BNDONBLPNDK<FAIGCFGAAKD> IBMPHGOCENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private T HHJGNNILLAL;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x516CEB0", Offset = "0x516B8B0", VA = "0x18516CEB0")]
	internal IMAPFBBPLCK(BNDONBLPNDK<int> FHBKIFDMIKJ, BNDONBLPNDK<FAIGCFGAAKD> DPLAPCIONNE, BNDONBLPNDK<FAIGCFGAAKD> JGFFEIJLHHJ, [In] T AJDKAFGCBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x516C110", Offset = "0x516AB10", VA = "0x18516C110", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x516C620", Offset = "0x516B020", VA = "0x18516C620")]
	public OGOLLKDMMFP KBLLOONDKCE()
	{
		return default(OGOLLKDMMFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x516CB60", Offset = "0x516B560", VA = "0x18516CB60")]
	public EEHCDEECILM PHAKNALBEIB()
	{
		return default(EEHCDEECILM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x516C290", Offset = "0x516AC90", VA = "0x18516C290")]
	[AsyncStateMachine(typeof(IMAPFBBPLCK<>.DFPNNIMLOFI))]
	public Task<IMAPFBBPLCK<T>.EEHCDEECILM> HKIFNLLIDMC(CancellationToken OMJKEHOJJFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class KFEGGBPIFMK
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8470DC0", Offset = "0x846F7C0", VA = "0x188470DC0")]
	public static IMAPFBBPLCK<FAIGCFGAAKD> MDDJOGPLAFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3D2A400", Offset = "0x3D28E00", VA = "0x183D2A400")]
	public static IMAPFBBPLCK<T> MDDJOGPLAFO<T>([In] T AJDKAFGCBHO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class AMOFKAFEDJG<TData> : OGOHDADDIPM where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly string IGNKIAJJGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly TData AKBOOJDMDHH;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
	public override string GIDIGOEEAJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5317030", Offset = "0x5315A30", VA = "0x185317030")]
	internal AMOFKAFEDJG(string ONGDPODJNBL, [In] TData GPCDCFCPGFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class JFGJACFBMBH
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x8470A50", Offset = "0x846F450", VA = "0x188470A50")]
	public static AMOFKAFEDJG<FAIGCFGAAKD> MDDJOGPLAFO(string ONGDPODJNBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3AD8CA0", Offset = "0x3AD76A0", VA = "0x183AD8CA0")]
	public static AMOFKAFEDJG<TData> MDDJOGPLAFO<TData>(string ONGDPODJNBL, [In] TData GPCDCFCPGFK) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class LFLMNHGAKNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal bool ENFHNMEAGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly string AHGJGAJHNIH;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xF6CFB0", Offset = "0xF6B9B0", VA = "0x180F6CFB0")]
	private LFLMNHGAKNA(bool OBPIBBAEBFO, string NCDPHEDPILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8471120", Offset = "0x846FB20", VA = "0x188471120")]
	public static LFLMNHGAKNA MDDJOGPLAFO(string NCDPHEDPILE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8471060", Offset = "0x846FA60", VA = "0x188471060")]
	public KBJIOHMAAIE ICCFNPENPEO()
	{
		return default(KBJIOHMAAIE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct KBJIOHMAAIE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly LFLMNHGAKNA ALGKMHPMAFL;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xE76700", Offset = "0xE75100", VA = "0x180E76700")]
	internal KBJIOHMAAIE(LFLMNHGAKNA HCLPHJDKMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x8470DA0", Offset = "0x846F7A0", VA = "0x188470DA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class IBNFBKHJPEM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class DAIIKKGAPJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public DAIIKKGAPJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA030", Offset = "0x6FE8A30", VA = "0x186FEA030")]
		internal int INFFKIEFJHO(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private HashSet<T>? OLEEPHKIGOF;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IReadOnlyCollection<T> IFANFBONAML
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x511A750", Offset = "0x5119150", VA = "0x18511A750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool CKKAHAFPMLA
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x511A9C0", Offset = "0x51193C0", VA = "0x18511A9C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int NEOIHEKIHEL
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5D0", Offset = "0xA8CFD0", VA = "0x180A8E5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x511A850", Offset = "0x5119250", VA = "0x18511A850")]
	public bool MJGPLOFFIKO(T DHNMCOFINFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x511A630", Offset = "0x5119030", VA = "0x18511A630")]
	public bool BBOPECIHIDA(T DHNMCOFINFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x511A810", Offset = "0x5119210", VA = "0x18511A810")]
	public bool JBFDGOBACLK(T DHNMCOFINFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x511A780", Offset = "0x5119180", VA = "0x18511A780")]
	public void IINCPOHCLEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x511AA00", Offset = "0x5119400", VA = "0x18511AA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public IBNFBKHJPEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public sealed class CNFJHBAFEIK
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class BFILJGKBENA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public BFILJGKBENA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x846E500", Offset = "0x846CF00", VA = "0x18846E500")]
		internal int INFFKIEFJHO(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private HashSet<object>? OLEEPHKIGOF;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyCollection<object> IFANFBONAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x846E650", Offset = "0x846D050", VA = "0x18846E650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool CKKAHAFPMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x846E890", Offset = "0x846D290", VA = "0x18846E890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int NEOIHEKIHEL
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5D0", Offset = "0xA8CFD0", VA = "0x180A8E5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x846E7B0", Offset = "0x846D1B0", VA = "0x18846E7B0")]
	public bool MJGPLOFFIKO(object DHNMCOFINFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x846E5B0", Offset = "0x846CFB0", VA = "0x18846E5B0")]
	public bool BBOPECIHIDA(object DHNMCOFINFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x846E750", Offset = "0x846D150", VA = "0x18846E750")]
	public bool JBFDGOBACLK(object DHNMCOFINFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x846E6E0", Offset = "0x846D0E0", VA = "0x18846E6E0")]
	public void IINCPOHCLEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x846E8A0", Offset = "0x846D2A0", VA = "0x18846E8A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public CNFJHBAFEIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class FPJAFDMBCOF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private struct IPCBDKKGOJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public float JBBDGNLPDDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public T BHKLFFIKDPE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<object, IPCBDKKGOJD> JAGEKIFCALJ;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public virtual T KIBADCDEBFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x125C600", Offset = "0x125B000", VA = "0x18125C600", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x1C06300", Offset = "0x1C04D00", VA = "0x181C06300", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public object? ALEMFGEFPNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HGKJCJCLKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x4917640", Offset = "0x4916040", VA = "0x184917640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x4E52760", Offset = "0x4E51160", VA = "0x184E52760")]
	public bool AOFFLNBKOEM(T PDKJBMPOMNC, object DHNMCOFINFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x4917050", Offset = "0x4915A50", VA = "0x184917050")]
	public bool DMGCHJPPPFG(object DHNMCOFINFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x4917020", Offset = "0x4915A20", VA = "0x184917020")]
	public void CHLOADNGFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x4E53FF0", Offset = "0x4E529F0", VA = "0x184E53FF0")]
	public bool PKNEHCKDABA(object DHNMCOFINFM, [Out] T PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x4E53200", Offset = "0x4E51C00", VA = "0x184E53200")]
	[JEPLGDCHKCB("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool KCLHBDMGPPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x4942E80", Offset = "0x4941880", VA = "0x184942E80")]
	public FPJAFDMBCOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public sealed class DKHEFBJMACG : BLDJJILFHAB<NJLNMLEFFEL>
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal class LECEGLJNDDD : IEqualityComparer<NJLNMLEFFEL>
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		internal static readonly LECEGLJNDDD NDAIDGNOFDA;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8470E90", Offset = "0x846F890", VA = "0x188470E90", Slot = "4")]
		public bool Equals(NJLNMLEFFEL IECENJOJFJH, NJLNMLEFFEL OFOCBNJJIJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7540690", Offset = "0x753F090", VA = "0x187540690", Slot = "5")]
		public int GetHashCode(NJLNMLEFFEL CEFJEHJNIAP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public LECEGLJNDDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x846EDE0", Offset = "0x846D7E0", VA = "0x18846EDE0")]
	public DKHEFBJMACG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x846ED30", Offset = "0x846D730", VA = "0x18846ED30", Slot = "4")]
	public override bool MJGPLOFFIKO(NJLNMLEFFEL DHNMCOFINFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x846EBF0", Offset = "0x846D5F0", VA = "0x18846EBF0", Slot = "5")]
	public override bool BBOPECIHIDA(NJLNMLEFFEL DHNMCOFINFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x846ECA0", Offset = "0x846D6A0", VA = "0x18846ECA0")]
	private static void IHCDKDKOLMK(NJLNMLEFFEL DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0xAEE9A0", Offset = "0xAED3A0", VA = "0x180AEE9A0", Slot = "6")]
	protected override string TokenToString(NJLNMLEFFEL DHNMCOFINFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class NJLNMLEFFEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly string CIKHOEANENF;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	public NJLNMLEFFEL(string CIKHOEANENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x8471190", Offset = "0x846FB90", VA = "0x188471190", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class BLDJJILFHAB<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly IEqualityComparer<T> MJKIOFPPIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private HashSet<T>? OLEEPHKIGOF;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public IReadOnlyCollection<T> IFANFBONAML
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x65A4920", Offset = "0x65A3320", VA = "0x1865A4920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool CKKAHAFPMLA
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x511A9C0", Offset = "0x51193C0", VA = "0x18511A9C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int NEOIHEKIHEL
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xAE0120", Offset = "0xADEB20", VA = "0x180AE0120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xAE0110", Offset = "0xADEB10", VA = "0x180AE0110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x65A5370", Offset = "0x65A3D70", VA = "0x1865A5370")]
	public BLDJJILFHAB(IEqualityComparer<T> MJKIOFPPIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x65A4B60", Offset = "0x65A3560", VA = "0x1865A4B60", Slot = "4")]
	public virtual bool MJGPLOFFIKO(T DHNMCOFINFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x65A46D0", Offset = "0x65A30D0", VA = "0x1865A46D0", Slot = "5")]
	public virtual bool BBOPECIHIDA(T DHNMCOFINFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x65A4950", Offset = "0x65A3350", VA = "0x1865A4950")]
	public void IINCPOHCLEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x65A4FD0", Offset = "0x65A39D0", VA = "0x1865A4FD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class NFKBPOBIBGG<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<WeakReference<T>>? OLEEPHKIGOF;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool CKKAHAFPMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x58B3E30", Offset = "0x58B2830", VA = "0x1858B3E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int NEOIHEKIHEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x58B3970", Offset = "0x58B2370", VA = "0x1858B3970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x58B3C10", Offset = "0x58B2610", VA = "0x1858B3C10")]
	public void MJGPLOFFIKO(T DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x58B3810", Offset = "0x58B2210", VA = "0x1858B3810")]
	public void BBOPECIHIDA(T DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x58B3AF0", Offset = "0x58B24F0", VA = "0x1858B3AF0")]
	public bool JBFDGOBACLK(T DHNMCOFINFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x58B3AD0", Offset = "0x58B24D0", VA = "0x1858B3AD0")]
	public void IINCPOHCLEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x58B3F30", Offset = "0x58B2930", VA = "0x1858B3F30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public NFKBPOBIBGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class BNNMNCAEBIG
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3A0A5B0", Offset = "0x3A08FB0", VA = "0x183A0A5B0")]
	public static void PLNHHEMACDC<T>(this List<T> CKDFPBCCFHO, int FILGHJLFKAL) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class EBLCLHKCAON<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private struct GAHFPLDNDKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public float JBBDGNLPDDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public T BHKLFFIKDPE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly Dictionary<NJLNMLEFFEL, GAHFPLDNDKO> JAGEKIFCALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly EqualityComparer<T> JFGJGBKBJEK;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public virtual T KIBADCDEBFF
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA88540", Offset = "0xA86F40", VA = "0x180A88540", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA88520", Offset = "0xA86F20", VA = "0x180A88520", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private NJLNMLEFFEL? ALEMFGEFPNE
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool HGKJCJCLKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x4917640", Offset = "0x4916040", VA = "0x184917640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x4916F40", Offset = "0x4915940", VA = "0x184916F40")]
	public bool AOFFLNBKOEM(T PDKJBMPOMNC, NJLNMLEFFEL DHNMCOFINFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x4917050", Offset = "0x4915A50", VA = "0x184917050")]
	public bool DMGCHJPPPFG(NJLNMLEFFEL DHNMCOFINFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x4917020", Offset = "0x4915A20", VA = "0x184917020")]
	public void CHLOADNGFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x4917690", Offset = "0x4916090", VA = "0x184917690")]
	public bool PKNEHCKDABA(NJLNMLEFFEL DHNMCOFINFM, [Out] T PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x49170C0", Offset = "0x4915AC0", VA = "0x1849170C0")]
	[JEPLGDCHKCB("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool KCLHBDMGPPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x49178A0", Offset = "0x49162A0", VA = "0x1849178A0")]
	public EBLCLHKCAON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class GLPOPDDKEPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Dictionary<object, float> JAGEKIFCALJ;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float MCLCCBBPGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xADE030", Offset = "0xADCA30", VA = "0x180ADE030")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x1376300", Offset = "0x1374D00", VA = "0x181376300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x846F160", Offset = "0x846DB60", VA = "0x18846F160")]
	public void AOFFLNBKOEM(float PDKJBMPOMNC, object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x846F220", Offset = "0x846DC20", VA = "0x18846F220")]
	public void DMGCHJPPPFG(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x846F1D0", Offset = "0x846DBD0", VA = "0x18846F1D0")]
	public void CHLOADNGFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x846F290", Offset = "0x846DC90", VA = "0x18846F290")]
	private void GCFCMNMJEIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x846F3C0", Offset = "0x846DDC0", VA = "0x18846F3C0")]
	public GLPOPDDKEPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface BPLKMOAGFGN
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event KOCNCIFIKJM EFCJNAENKFP;
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class IOBDEMMLBCL : BPLKMOAGFGN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public readonly struct JOJAPIHJKGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public readonly float GMHPCBOPLJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public readonly float LCNCPIGDBHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		internal readonly bool DKCDJFPCHCL;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float LKGECEPPJPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x8470AD0", Offset = "0x846F4D0", VA = "0x188470AD0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8470C40", Offset = "0x846F640", VA = "0x188470C40")]
		public JOJAPIHJKGM(float PAEPPOFDFDK, float GFFPHFAAMLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8470AE0", Offset = "0x846F4E0", VA = "0x188470AE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class PBEFFJALEIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public IOBDEMMLBCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public PBEFFJALEIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x84719B0", Offset = "0x84703B0", VA = "0x1884719B0")]
		internal void KGFIIFFCGBP(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly int MOCOCCPAPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int EMCFDJHNDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly BPLKMOAGFGN[] HAFMDLBFGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly KOCNCIFIKJM[] JDNAAPNIDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly JOJAPIHJKGM[] FBOAKBJIBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private JOJAPIHJKGM DDFHNCAFDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly EHPANNKFGMM OMKMJKONLOM;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event KOCNCIFIKJM EFCJNAENKFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8470800", Offset = "0x846F200", VA = "0x188470800", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8470130", Offset = "0x846EB30", VA = "0x188470130", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x84708C0", Offset = "0x846F2C0", VA = "0x1884708C0")]
	public IOBDEMMLBCL(int MOCOCCPAPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8470770", Offset = "0x846F170", VA = "0x188470770")]
	public EHPANNKFGMM HEJDLFOOKLI(JOJAPIHJKGM OPPACCCPKCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x84701F0", Offset = "0x846EBF0", VA = "0x1884701F0")]
	public void BEDKBDNGDKH(BPLKMOAGFGN KFMDMKJBPFI, [Optional] JOJAPIHJKGM FIABPECAFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x8470660", Offset = "0x846F060", VA = "0x188470660", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public delegate void KOCNCIFIKJM(float LEHODIGOOEA);
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class LEEJMNMGJNO
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	private class EMEGACKNNGH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly BPLKMOAGFGN EBMJNGFKGAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly KOCNCIFIKJM EMBEDGKMMHB;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x846F0D0", Offset = "0x846DAD0", VA = "0x18846F0D0")]
		public EMEGACKNNGH(BPLKMOAGFGN EBMJNGFKGAH, KOCNCIFIKJM EMBEDGKMMHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x846F080", Offset = "0x846DA80", VA = "0x18846F080", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x8470FF0", Offset = "0x846F9F0", VA = "0x188470FF0")]
	internal static bool GJNLMAAPKPA(float MLLJGIHINDJ, float ABNAHAKPDNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x845AB90", Offset = "0x8459590", VA = "0x18845AB90")]
	internal static float DHGANCAKBHL(float MLLJGIHINDJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x8470F30", Offset = "0x846F930", VA = "0x188470F30")]
	public static IDisposable FMILKDHLNFP(this BPLKMOAGFGN EBMJNGFKGAH, KOCNCIFIKJM EMBEDGKMMHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class EHPANNKFGMM : BPLKMOAGFGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private float LEHODIGOOEA;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public float PHFLOHEHEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x846EEF0", Offset = "0x846D8F0", VA = "0x18846EEF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event KOCNCIFIKJM? EFCJNAENKFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x846EFE0", Offset = "0x846D9E0", VA = "0x18846EFE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x846EE50", Offset = "0x846D850", VA = "0x18846EE50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public EHPANNKFGMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface GIBNPJOJLCN<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PLCOAGOGGNJ<T> PKPFHCOKDBD([Out] T PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CHLOADNGFGM();
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class FEBAGACENJI<T> : GIBNPJOJLCN<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ConcurrentStack<T> LOLDNPHKKAM;

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x4DF4820", Offset = "0x4DF3220", VA = "0x184DF4820", Slot = "4")]
	public PLCOAGOGGNJ<T> PKPFHCOKDBD([Out] T PDKJBMPOMNC)
	{
		return default(PLCOAGOGGNJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x4DF47C0", Offset = "0x4DF31C0", VA = "0x184DF47C0")]
	public void OEENGNANBPH(T KLDJFGHJNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x4DF4700", Offset = "0x4DF3100", VA = "0x184DF4700", Slot = "5")]
	public void CHLOADNGFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "6")]
	protected virtual void OGJIHANJJNG(T GDPIFKHMGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x4DF4730", Offset = "0x4DF3130", VA = "0x184DF4730")]
	private T DHBICMHDGKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x4DF48B0", Offset = "0x4DF32B0", VA = "0x184DF48B0")]
	public FEBAGACENJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct PLCOAGOGGNJ<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly T KLDJFGHJNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly FEBAGACENJI<T> FOHPIGBHJBP;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0xC12020", Offset = "0xC10A20", VA = "0x180C12020")]
	internal PLCOAGOGGNJ(T PDKJBMPOMNC, FEBAGACENJI<T> FOHPIGBHJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5B51900", Offset = "0x5B50300", VA = "0x185B51900", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class DJCMGEAHOBA : FEBAGACENJI<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public static readonly DJCMGEAHOBA NDAIDGNOFDA;

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x846EA50", Offset = "0x846D450", VA = "0x18846EA50")]
	public static PLCOAGOGGNJ<StringBuilder> DHBICMHDGKM([Out] StringBuilder PDKJBMPOMNC)
	{
		return default(PLCOAGOGGNJ<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x846EAF0", Offset = "0x846D4F0", VA = "0x18846EAF0", Slot = "6")]
	protected override void OGJIHANJJNG(StringBuilder GDPIFKHMGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x846EBB0", Offset = "0x846D5B0", VA = "0x18846EBB0")]
	public DJCMGEAHOBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class MNKHKFIOMME : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA340", Offset = "0x7CB8D40", VA = "0x187CBA340")]
	public MNKHKFIOMME(string ONGDPODJNBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[DefaultMember("Item")]
public class GJAMDFHCOEO<TKey, TValue> : OBCEAOPNLNC<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, AHEILKMLIHO where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class PAKBOKELHCH : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GJAMDFHCOEO<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x125C600", Offset = "0x125B000", VA = "0x18125C600", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x4EA0470", Offset = "0x4E9EE70", VA = "0x184EA0470", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
		[DebuggerHidden]
		public PAKBOKELHCH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4EA0580", Offset = "0x4E9EF80", VA = "0x184EA0580", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5AEA010", Offset = "0x5AE8A10", VA = "0x185AEA010", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x5AE97C0", Offset = "0x5AE81C0", VA = "0x185AE97C0")]
		private void ALLLMJKJJCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x5AEA490", Offset = "0x5AE8E90", VA = "0x185AEA490")]
		private void NADPDCNBFDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x5AEA530", Offset = "0x5AE8F30", VA = "0x185AEA530", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly OBCEAOPNLNC<TKey, TValue> DLBIIIFCJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly IDictionary<TKey, TValue> JIJBPLAGLJE;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int NEOIHEKIHEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x4F761E0", Offset = "0x4F74BE0", VA = "0x184F761E0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool CLDNKONDKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public TValue EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x4F76450", Offset = "0x4F74E50", VA = "0x184F76450", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4F76700", Offset = "0x4F75100", VA = "0x184F76700", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICollection<TKey> IMDDKDHGJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x4F764C0", Offset = "0x4F74EC0", VA = "0x184F764C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public ICollection<TValue> MFALEKJCBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4F765D0", Offset = "0x4F74FD0", VA = "0x184F765D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4F76130", Offset = "0x4F74B30", VA = "0x184F76130")]
	public GJAMDFHCOEO(OBCEAOPNLNC<TKey, TValue> DLBIIIFCJJH, [Optional] IDictionary<TKey, TValue>? JIJBPLAGLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x4F73EB0", Offset = "0x4F728B0", VA = "0x184F73EB0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x4F74B10", Offset = "0x4F73510", VA = "0x184F74B10")]
	public void FFCFOONCKBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x4F738C0", Offset = "0x4F722C0", VA = "0x184F738C0", Slot = "9")]
	public void Add(TKey LNBCHJPEENA, TValue PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x4F74890", Offset = "0x4F73290", VA = "0x184F74890")]
	public void FENPHFFCPGC(TKey LNBCHJPEENA, TValue PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x4F75210", Offset = "0x4F73C10", VA = "0x184F75210")]
	public void LMPFPBFDJLM(TKey LNBCHJPEENA, TValue PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x4F74C80", Offset = "0x4F73680", VA = "0x184F74C80")]
	public void LILPOJIMJGE(TKey LNBCHJPEENA, TValue PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x4F73D80", Offset = "0x4F72780", VA = "0x184F73D80")]
	public void CCNOFMHEOLI(TKey LNBCHJPEENA, TValue PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x4F75750", Offset = "0x4F74150", VA = "0x184F75750", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> HNLFGCKBFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x4F757B0", Offset = "0x4F741B0", VA = "0x184F757B0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x4F75CB0", Offset = "0x4F746B0", VA = "0x184F75CB0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x4F73FC0", Offset = "0x4F729C0", VA = "0x184F73FC0", Slot = "8")]
	public bool ContainsKey(TKey LNBCHJPEENA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x4F75420", Offset = "0x4F73E20", VA = "0x184F75420")]
	public bool NIACIJNDGHM(TKey LNBCHJPEENA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x4F747C0", Offset = "0x4F731C0", VA = "0x184F747C0")]
	public bool DDHLMDDOACP(TKey LNBCHJPEENA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x4F755B0", Offset = "0x4F73FB0", VA = "0x184F755B0", Slot = "10")]
	public bool Remove(TKey LNBCHJPEENA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x4F75F80", Offset = "0x4F74980", VA = "0x184F75F80", Slot = "11")]
	public bool TryGetValue(TKey LNBCHJPEENA, [Out] TValue PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x4F74070", Offset = "0x4F72A70", VA = "0x184F74070", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] JCEJMKLBKKB, int MDMGHHNAEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x4F75E70", Offset = "0x4F74870", VA = "0x184F75E70", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x4F74BF0", Offset = "0x4F735F0", VA = "0x184F74BF0", Slot = "19")]
	[IteratorStateMachine(typeof(GJAMDFHCOEO<, >.PAKBOKELHCH))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x4F73570", Offset = "0x4F71F70", VA = "0x184F73570", Slot = "21")]
	public bool AJJHEFBBBMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x4F73610", Offset = "0x4F72010", VA = "0x184F73610")]
	private TValue ALAAJIDIFNG(TKey LNBCHJPEENA)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface HMDEIHDFAPG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string NLGDGMOLHEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface AHEILKMLIHO
{
	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AJJHEFBBBMB();
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface OBCEAOPNLNC<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, AHEILKMLIHO
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[DefaultMember("Item")]
public sealed class JNGKBOCCLBG<TKey, TVal> : OBCEAOPNLNC<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, AHEILKMLIHO where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate int JPBMKGALLEE(TKey LNBCHJPEENA, TVal PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public delegate void OOBHJFNFCMN(TKey LNBCHJPEENA, TVal PDKJBMPOMNC, JACODOEMHHC HDDLNGLMMKN);

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private class FFICLHLOOPD
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public TKey OFFMBGPIJFM
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xE823D0", Offset = "0xE80DD0", VA = "0x180E823D0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public TVal BHKLFFIKDPE
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xAE0120", Offset = "0xADEB20", VA = "0x180AE0120")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0xAE0110", Offset = "0xADEB10", VA = "0x180AE0110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public int LKGECEPPJPM
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xC33060", Offset = "0xC31A60", VA = "0x180C33060")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x1058A60", Offset = "0x1057460", VA = "0x181058A60")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public DateTimeOffset IMLOKHMBDOC
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x13D5B70", Offset = "0x13D4570", VA = "0x1813D5B70")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x1514FE0", Offset = "0x15139E0", VA = "0x181514FE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x4DF9E40", Offset = "0x4DF8840", VA = "0x184DF9E40")]
		public FFICLHLOOPD(TKey LNBCHJPEENA, TVal BEAEDIJJJJI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class AADLGBAAAML : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public JNGKBOCCLBG<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private LinkedList<FFICLHLOOPD>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x125C600", Offset = "0x125B000", VA = "0x18125C600", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x5136790", Offset = "0x5135190", VA = "0x185136790", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
		[DebuggerHidden]
		public AADLGBAAAML(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4E9BC70", Offset = "0x4E9A670", VA = "0x184E9BC70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x5135A00", Offset = "0x5134400", VA = "0x185135A00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5133C80", Offset = "0x5132680", VA = "0x185133C80")]
		private void ALLLMJKJJCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x5136510", Offset = "0x5134F10", VA = "0x185136510", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public const int MKFHADPCHCM = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Dictionary<TKey, LinkedListNode<FFICLHLOOPD>> HKGFPNNJDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly LinkedList<FFICLHLOOPD> HJPJKLAAMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly JPBMKGALLEE? ICNCLEPGMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly TimeSpan OGPJNJCNGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly OOBHJFNFCMN? BGCAFDFCBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly HNGFBLOEPPO HIDMMKCMKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private bool FINDHDNEFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly List<TKey> BEPAJPDPJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly List<TVal> EDHJBCDPCJL;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int PCFFJHIKDDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xAF1310", Offset = "0xAEFD10", VA = "0x180AF1310")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	internal int KINDFLGNOIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xE7ADA0", Offset = "0xE797A0", VA = "0x180E7ADA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xFACD50", Offset = "0xFAB750", VA = "0x180FACD50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int NEOIHEKIHEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x541C680", Offset = "0x541B080", VA = "0x18541C680", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	internal int OBPBFDIPACO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x4FFCE40", Offset = "0x4FFB840", VA = "0x184FFCE40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public ICollection<TVal> MFALEKJCBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x541C780", Offset = "0x541B180", VA = "0x18541C780", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	ICollection<TKey> IDictionary<TKey, TVal>.MGJGGDDJGLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x5419640", Offset = "0x5418040", VA = "0x185419640", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool CLDNKONDKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public TVal EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x541C730", Offset = "0x541B130", VA = "0x18541C730", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x541C810", Offset = "0x541B210", VA = "0x18541C810", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5410D10", Offset = "0x540F710", VA = "0x185410D10")]
	private bool DFKPEMPLONL(int MOCOCCPAPIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5416F20", Offset = "0x5415920", VA = "0x185416F20")]
	private void GBLLKOKONGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x541A950", Offset = "0x5419350", VA = "0x18541A950")]
	public JNGKBOCCLBG(int MOCOCCPAPIH, [Optional] JPBMKGALLEE? ICNCLEPGMHO, [Optional] IEqualityComparer<TKey>? KJPAEDCKHPB, [Optional] OOBHJFNFCMN? BGCAFDFCBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x541AEE0", Offset = "0x54198E0", VA = "0x18541AEE0")]
	public JNGKBOCCLBG(TimeSpan OGPJNJCNGBF, [Optional] IEqualityComparer<TKey>? KJPAEDCKHPB, [Optional] OOBHJFNFCMN? BGCAFDFCBMJ, [Optional] HNGFBLOEPPO? HIDMMKCMKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x541A900", Offset = "0x5419300", VA = "0x18541A900")]
	public JNGKBOCCLBG(int MOCOCCPAPIH, TimeSpan OGPJNJCNGBF, [Optional] IEqualityComparer<TKey>? KJPAEDCKHPB, [Optional] OOBHJFNFCMN? BGCAFDFCBMJ, [Optional] HNGFBLOEPPO? HIDMMKCMKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x541B810", Offset = "0x541A210", VA = "0x18541B810")]
	public JNGKBOCCLBG(int MOCOCCPAPIH, JPBMKGALLEE? ICNCLEPGMHO, TimeSpan OGPJNJCNGBF, [Optional] IEqualityComparer<TKey>? KJPAEDCKHPB, [Optional] OOBHJFNFCMN? BGCAFDFCBMJ, [Optional] HNGFBLOEPPO? HIDMMKCMKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x540C400", Offset = "0x540AE00", VA = "0x18540C400", Slot = "21")]
	public bool AJJHEFBBBMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x54183A0", Offset = "0x5416DA0", VA = "0x1854183A0", Slot = "22")]
	public bool KLAPPMAIBLF(int CGAAPEOHPIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5412B30", Offset = "0x5411530", VA = "0x185412B30")]
	private bool DMCKFOAABMK(int CGAAPEOHPIP, JACODOEMHHC HDDLNGLMMKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x54188E0", Offset = "0x54172E0", VA = "0x1854188E0")]
	public void MAAIKGLMNNO(TKey LNBCHJPEENA, TVal PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x540DAA0", Offset = "0x540C4A0", VA = "0x18540DAA0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> HNLFGCKBFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x540E470", Offset = "0x540CE70", VA = "0x18540E470", Slot = "9")]
	public void Add(TKey LNBCHJPEENA, TVal PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x540F1C0", Offset = "0x540DBC0", VA = "0x18540F1C0", Slot = "8")]
	public bool ContainsKey(TKey LNBCHJPEENA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x54191F0", Offset = "0x5417BF0", VA = "0x1854191F0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5418E00", Offset = "0x5417800", VA = "0x185418E00", Slot = "10")]
	public bool Remove(TKey LNBCHJPEENA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5419400", Offset = "0x5417E00", VA = "0x185419400", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x540EC70", Offset = "0x540D670", VA = "0x18540EC70")]
	private bool CNCFPMENFMD(TKey LNBCHJPEENA, [Out] TVal PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5411270", Offset = "0x540FC70", VA = "0x185411270")]
	private TVal DHBICMHDGKM(TKey DPMAHEFJMND)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5419BD0", Offset = "0x54185D0", VA = "0x185419BD0", Slot = "11")]
	public bool TryGetValue(TKey DPMAHEFJMND, [Out] TVal PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x540F0C0", Offset = "0x540DAC0", VA = "0x18540F0C0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x540F300", Offset = "0x540DD00", VA = "0x18540F300", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] JCEJMKLBKKB, int MDMGHHNAEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5416B60", Offset = "0x5415560", VA = "0x185416B60")]
	private void FPDDJEHNEGJ(TKey LNBCHJPEENA, TVal BEAEDIJJJJI, JACODOEMHHC HDDLNGLMMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x54176A0", Offset = "0x54160A0", VA = "0x1854176A0")]
	private bool IJFOAJLMFBC(FFICLHLOOPD BLDMLKECENO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5414060", Offset = "0x5412A60", VA = "0x185414060")]
	private void FMCKNHDGNCH(LinkedListNode<FFICLHLOOPD> DGFJEOKMIHN, TVal OIKPBCOOHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x540CFA0", Offset = "0x540B9A0", VA = "0x18540CFA0")]
	private void AOFFLNBKOEM(TKey LNBCHJPEENA, TVal PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x540B8C0", Offset = "0x540A2C0", VA = "0x18540B8C0")]
	private void AHKHAOCEJNA(FFICLHLOOPD BLDMLKECENO, TVal OIKPBCOOHJG, int MIHPKDHPDIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5417400", Offset = "0x5415E00", VA = "0x185417400", Slot = "19")]
	[IteratorStateMachine(typeof(JNGKBOCCLBG<, >.AADLGBAAAML))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5419670", Offset = "0x5418070", VA = "0x185419670", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public enum JACODOEMHHC : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class ALIFNHCEIGK<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly TKey EJJOMHGAIGE;

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x53148A0", Offset = "0x53132A0", VA = "0x1853148A0")]
	public ALIFNHCEIGK(TKey GLIKOAKICNC, Exception GNHHAMPPHJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class PABBHEFOJAF : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x74DD6D0", Offset = "0x74DC0D0", VA = "0x1874DD6D0")]
	public PABBHEFOJAF(string ONGDPODJNBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class JEIBALHAAGC<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class HGJEAOEPJGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public JEIBALHAAGC<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public HGJEAOEPJGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x5042E10", Offset = "0x5041810", VA = "0x185042E10")]
		internal Task<TResource> GCMIELPMODH(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct HIGHOIAKPNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public JEIBALHAAGC<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x5045160", Offset = "0x5043B60", VA = "0x185045160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x5045D60", Offset = "0x5044760", VA = "0x185045D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct BMEIIGPLMKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x65A9890", Offset = "0x65A8290", VA = "0x1865A9890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x65AA5D0", Offset = "0x65A8FD0", VA = "0x1865AA5D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly DBHHBHBLBHP<TId, Task<TResource>> DFACLCDOAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> CEJFIPCKBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? AAAKGLKNICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly Action<TResource>? FFCFIJLALII;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x53CF440", Offset = "0x53CDE40", VA = "0x1853CF440")]
	public JEIBALHAAGC(int DPLIGPEBLKP = 0, [Optional] IEqualityComparer<TId>? PMNJEFBOPMO, [Optional] Func<TId, CancellationToken, Task<TResource>>? HHLILKEEEPL, [Optional] Action<TResource>? HPGFLABKNCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x53CE640", Offset = "0x53CD040", VA = "0x1853CE640")]
	public GBIBCLBHEOL<Task<TResource>> GIIOOEECEFJ(TId EGJGKBPPPFG, [Optional] Func<TId, CancellationToken, Task<TResource>>? HHLILKEEEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x53CEF10", Offset = "0x53CD910", VA = "0x1853CEF10")]
	private void IGPGEBAEPBE(Task<TResource> AIPCFMDLKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x53CDD30", Offset = "0x53CC730", VA = "0x1853CDD30")]
	[AsyncStateMachine(typeof(JEIBALHAAGC<, >.HIGHOIAKPNG))]
	private Task ENNODDFOOGH(Task<TResource> AIPCFMDLKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x53CF240", Offset = "0x53CDC40", VA = "0x1853CF240")]
	public void IPDOGILKIKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x53CED20", Offset = "0x53CD720", VA = "0x1853CED20")]
	public DBHHBHBLBHP<TId, Task<TResource>>.DKPEAFEGOKE IBBMHAHFLHH()
	{
		return default(DBHHBHBLBHP<TId, Task<TResource>>.DKPEAFEGOKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x53CF310", Offset = "0x53CDD10", VA = "0x1853CF310", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x53CF310", Offset = "0x53CDD10", VA = "0x1853CF310", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x53CE920", Offset = "0x53CD320", VA = "0x1853CE920")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(JEIBALHAAGC<, >.BMEIIGPLMKD))]
	internal static Task HDALEGIADFP(Task<TResource> AIPCFMDLKCK, CancellationTokenSource HMOHFAGJPNL, Dictionary<Task<TResource>, CancellationTokenSource> OBELJHIBBOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class DBHHBHBLBHP<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class GIABEMBGFNP : IEquatable<GIABEMBGFNP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public readonly TValue BHKLFFIKDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int AGCGKHPGGOB;

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xFE9BC0", Offset = "0xFE85C0", VA = "0x180FE9BC0")]
		public GIABEMBGFNP(TValue PDKJBMPOMNC, int HKIPHPAOJPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x4F70E70", Offset = "0x4F6F870", VA = "0x184F70E70", Slot = "4")]
		public bool Equals(GIABEMBGFNP? EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x4F70DD0", Offset = "0x4F6F7D0", VA = "0x184F70DD0", Slot = "0")]
		public override bool Equals(object? CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x4F71020", Offset = "0x4F6FA20", VA = "0x184F71020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public struct DKPEAFEGOKE : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private Dictionary<TKey, GIABEMBGFNP>.Enumerator BGFJOGBDGIN;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x703BB30", Offset = "0x703A530", VA = "0x18703BB30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public (TKey Key, TValue Value, int RefCount) CEKGODBONJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x703BED0", Offset = "0x703A8D0", VA = "0x18703BED0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x703BC80", Offset = "0x703A680", VA = "0x18703BC80")]
		public DKPEAFEGOKE(DBHHBHBLBHP<TKey, TValue> JAGEKIFCALJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x703B6D0", Offset = "0x703A0D0", VA = "0x18703B6D0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x703B710", Offset = "0x703A110", VA = "0x18703B710", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x703B7D0", Offset = "0x703A1D0", VA = "0x18703B7D0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class OJIKGKBCFPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public DBHHBHBLBHP<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public GIABEMBGFNP refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public OJIKGKBCFPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x5A25160", Offset = "0x5A23B60", VA = "0x185A25160")]
		internal void GCMIELPMODH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Dictionary<TKey, GIABEMBGFNP> DMKILOOGBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly Func<TKey, TValue>? NCFHMNFHLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly Action<TValue>? IJINKNBGKLA;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC6A0", Offset = "0x6FEB0A0", VA = "0x186FEC6A0")]
	public DBHHBHBLBHP(int DPLIGPEBLKP = 0, [Optional] IEqualityComparer<TKey>? KJPAEDCKHPB, [Optional] Func<TKey, TValue>? LIPGJEDKKFE, [Optional] Action<TValue>? OEOPGIAKFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB870", Offset = "0x6FEA270", VA = "0x186FEB870")]
	public GBIBCLBHEOL<TValue> GIIOOEECEFJ(TKey LNBCHJPEENA, [Optional] Func<TKey, TValue>? PEGPBFHOENM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC3D0", Offset = "0x6FEADD0", VA = "0x186FEC3D0")]
	private void OEENGNANBPH(TKey LNBCHJPEENA, GIABEMBGFNP MIOBDGPDKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBC00", Offset = "0x6FEA600", VA = "0x186FEBC00")]
	public void IPDOGILKIKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBB40", Offset = "0x6FEA540", VA = "0x186FEBB40")]
	public DKPEAFEGOKE IBBMHAHFLHH()
	{
		return default(DKPEAFEGOKE);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC570", Offset = "0x6FEAF70", VA = "0x186FEC570", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC570", Offset = "0x6FEAF70", VA = "0x186FEC570", Slot = "5")]
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
