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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x761C850", Offset = "0x761AE50", VA = "0x18761C850")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x97C6E0", Offset = "0x97ACE0", VA = "0x18097C6E0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x97C720", Offset = "0x97AD20", VA = "0x18097C720")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class NOLKIACAAIO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	protected NOLKIACAAIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class OKDNIJHAHKC<T> : NOLKIACAAIO
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct JBADDBGJHFB
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum EKPCPAPCBIC
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
		public EKPCPAPCBIC BMIPLDLMPCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T PJDAFKMDDCG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int FOFLLCFMELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool LMOLHGOGEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool BHKCGGKKMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? NGDMOJIGCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<JBADDBGJHFB>? IJGKFNNJKHE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool BAFGBJACBHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5019070", Offset = "0x5017670", VA = "0x185019070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x50190D0", Offset = "0x50176D0", VA = "0x1850190D0")]
	protected OKDNIJHAHKC(bool BHKCGGKKMEL, bool LMOLHGOGEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5018920", Offset = "0x5016F20", VA = "0x185018920")]
	protected bool GPDPPOIBMCM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5018BD0", Offset = "0x50171D0", VA = "0x185018BD0")]
	protected void KBKEMJDJBFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x50186B0", Offset = "0x5016CB0", VA = "0x1850186B0")]
	protected void DJGPGFNOCHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x39C8900", Offset = "0x39C6F00", VA = "0x1839C8900")]
	private static void MNMIEIBDNLO<U>(List<U>? BHMKCPLLJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x50189C0", Offset = "0x5016FC0", VA = "0x1850189C0", Slot = "4")]
	public void HBHDBABAKDP(T PJDAFKMDDCG, bool ACAMEFINNAO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5018EA0", Offset = "0x50174A0", VA = "0x185018EA0", Slot = "5")]
	public void OCDDHDAHAOD(T PJDAFKMDDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5018CF0", Offset = "0x50172F0", VA = "0x185018CF0")]
	public void KKIOKOIHHPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class FKDOIPNGGAF : OKDNIJHAHKC<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x761B0D0", Offset = "0x76196D0", VA = "0x18761B0D0")]
	public FKDOIPNGGAF(bool BHKCGGKKMEL = false, bool LMOLHGOGEOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x761AE10", Offset = "0x7619410", VA = "0x18761AE10")]
	public void CNDNDIPPKBE()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x761B010", Offset = "0x7619610", VA = "0x18761B010")]
	public static FKDOIPNGGAF FHOKCPBBLGF(FKDOIPNGGAF PBIGHEIFGJE, Action PJDAFKMDDCG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x761B070", Offset = "0x7619670", VA = "0x18761B070")]
	public static FKDOIPNGGAF NDOPAHAKCFH(FKDOIPNGGAF PBIGHEIFGJE, Action PJDAFKMDDCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CMCJOFJKMPA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBHDBABAKDP(Action<T> PJDAFKMDDCG, bool ACAMEFINNAO = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OCDDHDAHAOD(Action<T> PJDAFKMDDCG);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class JKOOBLENGDB<T> : OKDNIJHAHKC<Action<T>>, CMCJOFJKMPA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4066120", Offset = "0x4064720", VA = "0x184066120")]
	public JKOOBLENGDB(bool BHKCGGKKMEL = false, bool LMOLHGOGEOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x49D1C80", Offset = "0x49D0280", VA = "0x1849D1C80")]
	public void CNDNDIPPKBE(T CHBEBLKFDBC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x442FC60", Offset = "0x442E260", VA = "0x18442FC60")]
	public static JKOOBLENGDB<T> FHOKCPBBLGF(JKOOBLENGDB<T> PBIGHEIFGJE, Action<T> PJDAFKMDDCG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x442FD00", Offset = "0x442E300", VA = "0x18442FD00")]
	public static JKOOBLENGDB<T> NDOPAHAKCFH(JKOOBLENGDB<T> PBIGHEIFGJE, Action<T> PJDAFKMDDCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BFNOGGKBHMI<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBHDBABAKDP(Action<T, U> PJDAFKMDDCG, bool ACAMEFINNAO = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OCDDHDAHAOD(Action<T, U> PJDAFKMDDCG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class FLEKKBCEDJE<T, U> : OKDNIJHAHKC<Action<T, U>>, BFNOGGKBHMI<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4066120", Offset = "0x4064720", VA = "0x184066120")]
	public FLEKKBCEDJE(bool BHKCGGKKMEL = false, bool LMOLHGOGEOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x442D3F0", Offset = "0x442B9F0", VA = "0x18442D3F0")]
	public void CNDNDIPPKBE(T CHBEBLKFDBC, U IBMIGPFMPIN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x442FC60", Offset = "0x442E260", VA = "0x18442FC60")]
	public static FLEKKBCEDJE<T, U> FHOKCPBBLGF(FLEKKBCEDJE<T, U> PBIGHEIFGJE, Action<T, U> PJDAFKMDDCG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x442FD00", Offset = "0x442E300", VA = "0x18442FD00")]
	public static FLEKKBCEDJE<T, U> NDOPAHAKCFH(FLEKKBCEDJE<T, U> PBIGHEIFGJE, Action<T, U> PJDAFKMDDCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class BEABIOOFOBA<T, U, V> : OKDNIJHAHKC<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4066120", Offset = "0x4064720", VA = "0x184066120")]
	public BEABIOOFOBA(bool BHKCGGKKMEL = false, bool LMOLHGOGEOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x589D460", Offset = "0x589BA60", VA = "0x18589D460")]
	public void CNDNDIPPKBE(T CHBEBLKFDBC, U IBMIGPFMPIN, V EFDAGALIIFI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x442FC60", Offset = "0x442E260", VA = "0x18442FC60")]
	public static BEABIOOFOBA<T, U, V> FHOKCPBBLGF(BEABIOOFOBA<T, U, V> PBIGHEIFGJE, Action<T, U, V> PJDAFKMDDCG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x442FD00", Offset = "0x442E300", VA = "0x18442FD00")]
	public static BEABIOOFOBA<T, U, V> NDOPAHAKCFH(BEABIOOFOBA<T, U, V> PBIGHEIFGJE, Action<T, U, V> PJDAFKMDDCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KHABFLKDKGF<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class MLLHJCGKFFC<T, U, V, W> : OKDNIJHAHKC<Action<T, U, V, W>>, KHABFLKDKGF<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4066120", Offset = "0x4064720", VA = "0x184066120")]
	public MLLHJCGKFFC(bool BHKCGGKKMEL = false, bool LMOLHGOGEOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4E125E0", Offset = "0x4E10BE0", VA = "0x184E125E0")]
	public void CNDNDIPPKBE(T CHBEBLKFDBC, U IBMIGPFMPIN, V EFDAGALIIFI, W KDEAIPINGAN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x442FC60", Offset = "0x442E260", VA = "0x18442FC60")]
	public static MLLHJCGKFFC<T, U, V, W> FHOKCPBBLGF(MLLHJCGKFFC<T, U, V, W> PBIGHEIFGJE, Action<T, U, V, W> PJDAFKMDDCG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x442FD00", Offset = "0x442E300", VA = "0x18442FD00")]
	public static MLLHJCGKFFC<T, U, V, W> NDOPAHAKCFH(MLLHJCGKFFC<T, U, V, W> PBIGHEIFGJE, Action<T, U, V, W> PJDAFKMDDCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class ALDIKDJKADD<T, U, V, W, X> : OKDNIJHAHKC<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4066120", Offset = "0x4064720", VA = "0x184066120")]
	public ALDIKDJKADD(bool BHKCGGKKMEL = false, bool LMOLHGOGEOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x48BED00", Offset = "0x48BD300", VA = "0x1848BED00")]
	public void CNDNDIPPKBE(T CHBEBLKFDBC, U IBMIGPFMPIN, V EFDAGALIIFI, W KDEAIPINGAN, X IKAEODCKAIP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x442FC60", Offset = "0x442E260", VA = "0x18442FC60")]
	public static ALDIKDJKADD<T, U, V, W, X> FHOKCPBBLGF(ALDIKDJKADD<T, U, V, W, X> PBIGHEIFGJE, Action<T, U, V, W, X> PJDAFKMDDCG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x442FD00", Offset = "0x442E300", VA = "0x18442FD00")]
	public static ALDIKDJKADD<T, U, V, W, X> NDOPAHAKCFH(ALDIKDJKADD<T, U, V, W, X> PBIGHEIFGJE, Action<T, U, V, W, X> PJDAFKMDDCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class IJBLMEFEJGB<T, U, V, W, X, Y> : OKDNIJHAHKC<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4066120", Offset = "0x4064720", VA = "0x184066120")]
	public IJBLMEFEJGB(bool BHKCGGKKMEL = false, bool LMOLHGOGEOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x477A870", Offset = "0x4778E70", VA = "0x18477A870")]
	public void CNDNDIPPKBE(T CHBEBLKFDBC, U IBMIGPFMPIN, V EFDAGALIIFI, W KDEAIPINGAN, X IKAEODCKAIP, Y ACCJFOPIMAB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x442FC60", Offset = "0x442E260", VA = "0x18442FC60")]
	public static IJBLMEFEJGB<T, U, V, W, X, Y> FHOKCPBBLGF(IJBLMEFEJGB<T, U, V, W, X, Y> PBIGHEIFGJE, Action<T, U, V, W, X, Y> PJDAFKMDDCG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x442FD00", Offset = "0x442E300", VA = "0x18442FD00")]
	public static IJBLMEFEJGB<T, U, V, W, X, Y> NDOPAHAKCFH(IJBLMEFEJGB<T, U, V, W, X, Y> PBIGHEIFGJE, Action<T, U, V, W, X, Y> PJDAFKMDDCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class BJPHJHJBNAD<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly HNFGOLPBJLN<TKey, TVal> KPDCOKPEBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> GCHKMJNEPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly HNFGOLPBJLN<TKey, TVal>.KGEALBHDJCD? ICBKKFJOOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int AIOPAOGKJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly HNFGOLPBJLN<TKey, TVal>.KAMLOIPNHBD? FHBIANPBGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int LEJPNNEAAMN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int PFKJFKMCCPL
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x58ABA10", Offset = "0x58AA010", VA = "0x1858ABA10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int JLPIJPCEGAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x954460", Offset = "0x952A60", VA = "0x180954460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x58AC430", Offset = "0x58AAA30", VA = "0x1858AC430")]
	public BJPHJHJBNAD(int AIOPAOGKJFL, [Optional] HNFGOLPBJLN<TKey, TVal>.KAMLOIPNHBD? FHBIANPBGPB, [Optional] IEqualityComparer<TKey>? OLLCJFOMGIM, [Optional] HNFGOLPBJLN<TKey, TVal>.KGEALBHDJCD? ICBKKFJOOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x58AB6B0", Offset = "0x58A9CB0", VA = "0x1858AB6B0")]
	public void IONEAPKBBFI(TKey LKMGECEEGEE, TVal KBGCCIOIGBD, bool EECKCCHGJIB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x58AC190", Offset = "0x58AA790", VA = "0x1858AC190")]
	public bool PEIECAELMKB(TKey LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x58AB2F0", Offset = "0x58A98F0", VA = "0x1858AB2F0")]
	public bool GMJNAAAPBAP(TKey MHOMJGNFGGL, [Out] TVal KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x58AB3F0", Offset = "0x58A99F0", VA = "0x1858AB3F0")]
	private void IGMJCNIAIMB(TKey LKMGECEEGEE, TVal KBGCCIOIGBD, int IBMHAIHIDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x58AB140", Offset = "0x58A9740", VA = "0x1858AB140")]
	public bool DIOGKAFPEHP(TKey LKMGECEEGEE, TVal KBGCCIOIGBD, bool EECKCCHGJIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x58ABA60", Offset = "0x58AA060", VA = "0x1858ABA60")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x58ABB10", Offset = "0x58AA110", VA = "0x1858ABB10")]
	private void KMLDCOIGHGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x58AC2F0", Offset = "0x58AA8F0", VA = "0x1858AC2F0")]
	private bool POIOBMEJEDO(TKey LKMGECEEGEE, IAIFEKOPBMN CEGFAIJENKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x58AC070", Offset = "0x58AA670", VA = "0x1858AC070")]
	private void LILIJALFMLI(TKey LKMGECEEGEE, TVal KBGCCIOIGBD, IAIFEKOPBMN CEGFAIJENKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x58AB8E0", Offset = "0x58A9EE0", VA = "0x1858AB8E0")]
	private void JGAFKEPOLMB(TKey LKMGECEEGEE, TVal DGOEGFOLJJL, IAIFEKOPBMN CEGFAIJENKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class AJMGOIICDMM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action HEANOJFNKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool LGCEODGIMMC;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
	public AJMGOIICDMM(Action BKAIFAJPEJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x761A000", Offset = "0x7618600", VA = "0x18761A000", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x31891A0", Offset = "0x31877A0", VA = "0x1831891A0")]
	public static KFDDALGMHJI<T> OILMBKHFGKP<T>(T KBGCCIOIGBD, Action BKAIFAJPEJC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class KFDDALGMHJI<T> : AJMGOIICDMM where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T DEDOPNLMLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4AA8A60", Offset = "0x4AA7060", VA = "0x184AA8A60")]
	public KFDDALGMHJI(T KBGCCIOIGBD, Action BKAIFAJPEJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class KPPCCEIEBJK<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly FLPGHFAEKPL<T>? MAJOEGPMIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> DJKLHPILKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool LGCEODGIMMC;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly KPPCCEIEBJK<T> DGEEMDAPOEK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> FDLBDIBCDBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4B3D390", Offset = "0x4B3B990", VA = "0x184B3D390")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long AFNDGLAJDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4B3D6B0", Offset = "0x4B3BCB0", VA = "0x184B3D6B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool PMLNJMJFBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4B3D120", Offset = "0x4B3B720", VA = "0x184B3D120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4B3DD20", Offset = "0x4B3C320", VA = "0x184B3DD20")]
	public KPPCCEIEBJK(FLPGHFAEKPL<T> AJPMKOKJPLK, FLPGHFAEKPL<T> KNHCHOOEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4B3D8C0", Offset = "0x4B3BEC0", VA = "0x184B3D8C0")]
	public KPPCCEIEBJK(FLPGHFAEKPL<T> AJPMKOKJPLK, int EKDINNHMJFC, FLPGHFAEKPL<T> KNHCHOOEDON, int PHHAFJOKPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4B3DC70", Offset = "0x4B3C270", VA = "0x184B3DC70")]
	private KPPCCEIEBJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4B3D1E0", Offset = "0x4B3B7E0", VA = "0x184B3D1E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4B3D490", Offset = "0x4B3BA90", VA = "0x184B3D490")]
	public T[] OMBEABDDNID()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4B3D270", Offset = "0x4B3B870", VA = "0x184B3D270")]
	public static ReadOnlySequence<T> HEGJABMHLEC(KPPCCEIEBJK<T>? GGELOCEMMGP)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct ANEFDAMIPJL : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct DDJIBKGDJKD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0")]
		public static DDJIBKGDJKD FEOBEKOIKMG()
		{
			return default(DDJIBKGDJKD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x761A040", Offset = "0x7618640", VA = "0x18761A040")]
	public static string PECIFCLOODO(Type BMIPLDLMPCD, [Optional] string? LEDDGHAPBHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3B76BC0", Offset = "0x3B751C0", VA = "0x183B76BC0")]
	public static string? PECIFCLOODO<T>([Optional] string? LEDDGHAPBHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3B76B40", Offset = "0x3B75140", VA = "0x183B76B40")]
	public static string? JFFJDACPDHD<T>([Optional] string? LPIPFPOBKGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0")]
	public static ANEFDAMIPJL BIBMBKHCCLP(string LEDDGHAPBHK, string? LPIPFPOBKGH)
	{
		return default(ANEFDAMIPJL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OEKJFHFPCFG
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool ICOCONPPIFP(string JKIEFOEKODD, OEKJFHFPCFG HAJOADCICKK);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class NJJCKIOBCJP<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public NJJCKIOBCJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4EDAFB0", Offset = "0x4ED95B0", VA = "0x184EDAFB0")]
		internal void JMHDAPJABEA(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int JJFHAAOAACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string NFOJIANGPCG;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x761C8D0", Offset = "0x761AED0", VA = "0x18761C8D0")]
	public static Dictionary<string, OEKJFHFPCFG> DPFDLDMELDD(Type IEJJAFNKCLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x35EC110", Offset = "0x35EA710", VA = "0x1835EC110")]
	public static Dictionary<string, OEKJFHFPCFG> DPFDLDMELDD<T>(Type IEJJAFNKCLI, IReadOnlyDictionary<T, string> KGFHFDOAJCH) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x35EC940", Offset = "0x35EAF40", VA = "0x1835EC940")]
	public static Dictionary<string, OEKJFHFPCFG> OOCAGHLCNOA<T>(List<T> MEPENPIKOFM) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x761CDC0", Offset = "0x761B3C0", VA = "0x18761CDC0")]
	public static Dictionary<string, OEKJFHFPCFG> LGGDPILHKGK(Type IEJJAFNKCLI, ICOCONPPIFP AMLLLOEHOPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x761CC00", Offset = "0x761B200", VA = "0x18761CC00")]
	public static Dictionary<int, string> GGCGEONBMJL(Dictionary<string, OEKJFHFPCFG> MBDLAJMBAIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class PGAGFEIEKID : EAPODONBJNH
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool JJNMMBBEFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? FBIJPLNCAGA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual EAPODONBJNH? AFMGOADBMPF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x761D920", Offset = "0x761BF20", VA = "0x18761D920")]
	protected PGAGFEIEKID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string BBCHEHFFEBG();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x761D800", Offset = "0x761BE00", VA = "0x18761D800", Slot = "8")]
	public virtual string OMBHCHDNCGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x761D560", Offset = "0x761BB60", VA = "0x18761D560", Slot = "9")]
	public void KMBGPGBKKNJ(StringBuilder GLHMABGINLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x761D500", Offset = "0x761BB00", VA = "0x18761D500", Slot = "10")]
	public void EJIDEJFAJAA(StringBuilder GLHMABGINLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x761D280", Offset = "0x761B880", VA = "0x18761D280", Slot = "11")]
	public void BNNABBGBGAN(StringBuilder GLHMABGINLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x761D3A0", Offset = "0x761B9A0", VA = "0x18761D3A0", Slot = "12")]
	public void BNNNAAFAJEJ(StringBuilder GLHMABGINLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x761D880", Offset = "0x761BE80", VA = "0x18761D880")]
	public static void OPMCMHCAMBF(StringBuilder GLHMABGINLA, string HJLOFBIEILC, string HEDPNICLHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x668E670", Offset = "0x668CC70", VA = "0x18668E670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OMPJBHAAOOD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x761D200", Offset = "0x761B800", VA = "0x18761D200")]
	public OMPJBHAAOOD(string MIALAMIFNLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FFGKBNPLHNJ<TErr> : OMPJBHAAOOD where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr BIOOMJJMHFI;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x441D170", Offset = "0x441B770", VA = "0x18441D170")]
	private FFGKBNPLHNJ([In] TErr AKKACNNBJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x441D0A0", Offset = "0x441B6A0", VA = "0x18441D0A0")]
	public static FFGKBNPLHNJ<TErr> FEOBEKOIKMG([In] TErr AKKACNNBJFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FGKPCFBIPPO : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm EAICOEKICHP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool PHHCBEPNNBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool JINMOLLFOJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool LFCDANKCEAM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long AFNDGLAJDJM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x761ACB0", Offset = "0x76192B0", VA = "0x18761ACB0", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long NAMOIOBECGF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x761AD20", Offset = "0x7619320", VA = "0x18761AD20", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x761AD90", Offset = "0x7619390", VA = "0x18761AD90", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x761AC40", Offset = "0x7619240", VA = "0x18761AC40")]
	public FGKPCFBIPPO(HashAlgorithm EAICOEKICHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x761AA60", Offset = "0x7619060", VA = "0x18761AA60", Slot = "35")]
	public override int Read(byte[] DEEIKCMDENK, int FDJGEFDKBBO, int BBEJNKBNMID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x761AC10", Offset = "0x7619210", VA = "0x18761AC10", Slot = "38")]
	public override void Write(byte[] DEEIKCMDENK, int FDJGEFDKBBO, int BBEJNKBNMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x761AB00", Offset = "0x7619100", VA = "0x18761AB00", Slot = "33")]
	public override long Seek(long FDJGEFDKBBO, SeekOrigin IGFMIOBPFAL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x761AB90", Offset = "0x7619190", VA = "0x18761AB90", Slot = "34")]
	public override void SetLength(long KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x761A980", Offset = "0x7618F80", VA = "0x18761A980")]
	public byte[] HOMLBPOJOGN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface EAPODONBJNH
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string OMBHCHDNCGF();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string BBCHEHFFEBG();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface BCCJIGCFKHM<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions DEDOPNLMLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface LJPIKOPCNAM
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string DHGMAENOCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class FLPGHFAEKPL<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static FLPGHFAEKPL<T>? FEIPMACFIFM;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object JBMGLEPPBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? COJAENPLFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool LGCEODGIMMC;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool MOBPININNFE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xC1B7C0", Offset = "0xC19DC0", VA = "0x180C1B7C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4434F60", Offset = "0x4433560", VA = "0x184434F60")]
	private static FLPGHFAEKPL<T> PCMFHPOLEOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4433950", Offset = "0x4431F50", VA = "0x184433950")]
	private static void BGLIIJJLFBE(FLPGHFAEKPL<T> FOCJIGDCLCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x44356C0", Offset = "0x4433CC0", VA = "0x1844356C0")]
	private FLPGHFAEKPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4434BC0", Offset = "0x44331C0", VA = "0x184434BC0")]
	public static FLPGHFAEKPL<T> OILMBKHFGKP(ReadOnlyMemory<T> EEFIHHOPAFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x44349B0", Offset = "0x4432FB0", VA = "0x1844349B0")]
	public static FLPGHFAEKPL<T> OILMBKHFGKP(IMemoryOwner<T> DPLGOGMKOHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4434720", Offset = "0x4432D20", VA = "0x184434720")]
	public static void GKDGDJIDFBA(FLPGHFAEKPL<T> AJPMKOKJPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x44344A0", Offset = "0x4432AA0", VA = "0x1844344A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4434110", Offset = "0x4432710", VA = "0x184434110")]
	public FLPGHFAEKPL<T> CGDLHICEKJD(IMemoryOwner<T> DPLGOGMKOHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4433F10", Offset = "0x4432510", VA = "0x184433F10")]
	private void BMJKGDBKDCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4434860", Offset = "0x4432E60", VA = "0x184434860")]
	private FLPGHFAEKPL<T> OHANMAEMDNB(FLPGHFAEKPL<T> FOCJIGDCLCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class KPMECFAFOHI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x761BAA0", Offset = "0x761A0A0", VA = "0x18761BAA0")]
	public KPMECFAFOHI(string MIALAMIFNLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class CCLKNLGOPLJ<TOk> : KPMECFAFOHI where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk MHEEBIIDDPF;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5A6AC60", Offset = "0x5A69260", VA = "0x185A6AC60")]
	private CCLKNLGOPLJ([In] TOk GDEOOLPKMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4797DA0", Offset = "0x47963A0", VA = "0x184797DA0")]
	public static CCLKNLGOPLJ<TOk> FEOBEKOIKMG([In] TOk GDEOOLPKMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct JOFBNNGKBOO<TOk, TErr> : IEquatable<JOFBNNGKBOO<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly EqualityComparer<TErr> AMBJOLLANGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal readonly TErr BIOOMJJMHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal readonly TOk MHEEBIIDDPF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool FJLDNKJIJHM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x49DFFF0", Offset = "0x49DE5F0", VA = "0x1849DFFF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool INIBGAHJAEL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x49E0750", Offset = "0x49DED50", VA = "0x1849E0750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x49E57C0", Offset = "0x49E3DC0", VA = "0x1849E57C0")]
	internal JOFBNNGKBOO([In] TErr AKKACNNBJFA, [In] TOk GDEOOLPKMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x49E14E0", Offset = "0x49DFAE0", VA = "0x1849E14E0")]
	public static JOFBNNGKBOO<TOk, TErr> NNNKFDKOBLF([In] TErr AKKACNNBJFA)
	{
		return default(JOFBNNGKBOO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x49E2030", Offset = "0x49E0630", VA = "0x1849E2030")]
	public static JOFBNNGKBOO<TOk, TErr> OGGMMIPJEAO([In] TOk GDEOOLPKMEP)
	{
		return default(JOFBNNGKBOO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x358F650", Offset = "0x358DC50", VA = "0x18358F650")]
	public JOFBNNGKBOO<TOk?, UErr?> FKAOBLMEMHF<UErr>()
	{
		return default(JOFBNNGKBOO<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x358F410", Offset = "0x358DA10", VA = "0x18358F410")]
	public JOFBNNGKBOO<UOk?, TErr?> CGCHBMGPIKF<UOk>()
	{
		return default(JOFBNNGKBOO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3590420", Offset = "0x358EA20", VA = "0x183590420")]
	public JOFBNNGKBOO<UOk?, TErr?> GFFNKFPGMMK<UOk>()
	{
		return default(JOFBNNGKBOO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3591130", Offset = "0x358F730", VA = "0x183591130")]
	public JOFBNNGKBOO<TOk?, UErr?> IHJFECBENHN<UErr>()
	{
		return default(JOFBNNGKBOO<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x49E0D00", Offset = "0x49DF300", VA = "0x1849E0D00")]
	public JOFBNNGKBOO<IDMEFNAINAN, TErr> LFIPIKBNHGK()
	{
		return default(JOFBNNGKBOO<IDMEFNAINAN, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x49DDA40", Offset = "0x49DC040", VA = "0x1849DDA40")]
	public static bool BFIJCNNIIMH([In] JOFBNNGKBOO<TOk, TErr> HJGDMEAJFEI, [In] JOFBNNGKBOO<TOk, TErr> OHAJMMPIMHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x49DDD00", Offset = "0x49DC300", VA = "0x1849DDD00", Slot = "4")]
	public bool Equals(JOFBNNGKBOO<TOk, TErr> OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x49DE2B0", Offset = "0x49DC8B0", VA = "0x1849DE2B0", Slot = "0")]
	public override bool Equals(object OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x49DF530", Offset = "0x49DDB30", VA = "0x1849DF530", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x49E4880", Offset = "0x49E2E80", VA = "0x1849E4880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class PLEEEJEMONM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct ECJBNFBLLJG<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Task<JOFBNNGKBOO<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<JOFBNNGKBOO<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4049D90", Offset = "0x4048390", VA = "0x184049D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x404A3D0", Offset = "0x40489D0", VA = "0x18404A3D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x360D000", Offset = "0x360B600", VA = "0x18360D000")]
	public static JOFBNNGKBOO<TOk?, TErr?> MHEEBIIDDPF<TOk, TErr>([In] this JOFBNNGKBOO<TOk, TErr> JDCFMPOHCEA, [In] TOk GDEOOLPKMEP)
	{
		return default(JOFBNNGKBOO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x360F390", Offset = "0x360D990", VA = "0x18360F390")]
	public static JOFBNNGKBOO<IDMEFNAINAN, TErr?> MHEEBIIDDPF<TErr>([In] this JOFBNNGKBOO<IDMEFNAINAN, TErr> JDCFMPOHCEA)
	{
		return default(JOFBNNGKBOO<IDMEFNAINAN, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x360D000", Offset = "0x360B600", VA = "0x18360D000")]
	public static JOFBNNGKBOO<TOk?, TErr?> BIOOMJJMHFI<TOk, TErr>([In] this JOFBNNGKBOO<TOk, TErr> JDCFMPOHCEA, [In] TErr AKKACNNBJFA)
	{
		return default(JOFBNNGKBOO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x360EDE0", Offset = "0x360D3E0", VA = "0x18360EDE0")]
	public static TOk? MFEAOMGHBJI<TOk, TErr>([In] this JOFBNNGKBOO<TOk, TErr> JDCFMPOHCEA)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x360FD00", Offset = "0x360E300", VA = "0x18360FD00")]
	[AsyncStateMachine(typeof(ECJBNFBLLJG<, >))]
	public static Task<TOk?>? PLJJOOJEKIE<TOk, TErr>(this Task<JOFBNNGKBOO<TOk, TErr>> JDCFMPOHCEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x360D480", Offset = "0x360BA80", VA = "0x18360D480")]
	public static TErr? BPJIAEBFIDB<TErr, TOk>([In] this JOFBNNGKBOO<TOk, TErr> JDCFMPOHCEA)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x360DE70", Offset = "0x360C470", VA = "0x18360DE70")]
	public static bool IHEGKFLKMDA<TOk, TErr, UErr, UOk>([In] this JOFBNNGKBOO<TOk, TErr> JDCFMPOHCEA, [Out] JOFBNNGKBOO<UOk, UErr> PNDMAMKJKEH) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x360CCD0", Offset = "0x360B2D0", VA = "0x18360CCD0")]
	public static bool AKFJDPMBBAA<TOk, TErr>([In] this JOFBNNGKBOO<TOk, TErr> JDCFMPOHCEA, [Out] TOk GDEOOLPKMEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x360D8A0", Offset = "0x360BEA0", VA = "0x18360D8A0")]
	public static bool ENPFMMACOFC<TOk, TErr>([In] this JOFBNNGKBOO<TOk, TErr> JDCFMPOHCEA, [Out][NotNullWhen(true)] TErr AKKACNNBJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x360DB80", Offset = "0x360C180", VA = "0x18360DB80")]
	public static bool GJFGFKAIEBF<TOk, TErr>([In] this JOFBNNGKBOO<TOk, TErr> JDCFMPOHCEA, [Out][NotNullWhen(true)] TOk GDEOOLPKMEP, [Out][NotNullWhen(false)] TErr AKKACNNBJFA) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x360CF00", Offset = "0x360B500", VA = "0x18360CF00")]
	public static bool BGJCBIKMFNK<TOk, TErr>([In] this JOFBNNGKBOO<TOk, TErr> JDCFMPOHCEA, [Out][NotNullWhen(true)] TOk GDEOOLPKMEP, [Out] JOFBNNGKBOO<TOk, TErr> PNDMAMKJKEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x360DC00", Offset = "0x360C200", VA = "0x18360DC00")]
	public static bool IHEGKFLKMDA<TOk, TErr, UErr, UOk>([In] this JOFBNNGKBOO<TOk, TErr> JDCFMPOHCEA, [Out][NotNullWhen(true)] TOk GDEOOLPKMEP, [Out] JOFBNNGKBOO<UOk, UErr> PNDMAMKJKEH) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x360F510", Offset = "0x360DB10", VA = "0x18360F510")]
	public static bool MIMNILCJEOL<TOk, TErr>([In] this JOFBNNGKBOO<TOk, TErr> JDCFMPOHCEA, [Out][NotNullWhen(true)] TOk GDEOOLPKMEP, [Out] JOFBNNGKBOO<IDMEFNAINAN, TErr> PNDMAMKJKEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x360C4D0", Offset = "0x360AAD0", VA = "0x18360C4D0")]
	public static JOFBNNGKBOO<UOk, UErr> AAOOPLLBCEO<UOk, UErr, TOk, TErr>([In] this JOFBNNGKBOO<TOk, TErr> JDCFMPOHCEA, [In] JOFBNNGKBOO<UOk, UErr> MEBAFDHEDIN) where TOk : UOk where TErr : UErr
	{
		return default(JOFBNNGKBOO<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x360F8C0", Offset = "0x360DEC0", VA = "0x18360F8C0")]
	public static JOFBNNGKBOO<TOk?[]?, TErr?> MPCANEAFNAE<TOk, TErr>(this IEnumerable<JOFBNNGKBOO<TOk, TErr>> JDCFMPOHCEA)
	{
		return default(JOFBNNGKBOO<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x360D1D0", Offset = "0x360B7D0", VA = "0x18360D1D0")]
	public static JOFBNNGKBOO<UOk?, TErr?> BMBDKKIJGOB<UOk, TErr, TOk>([In] this JOFBNNGKBOO<TOk, TErr> JDCFMPOHCEA, Func<TOk, UOk> KJEGPMHGGJD)
	{
		return default(JOFBNNGKBOO<UOk, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class PKHOHICPHJG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x39CC940", Offset = "0x39CAF40", VA = "0x1839CC940")]
	public static JOFBNNGKBOO<TOk, T> MHEEBIIDDPF<TOk>([In] TOk GDEOOLPKMEP) where TOk : notnull
	{
		return default(JOFBNNGKBOO<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5109110", Offset = "0x5107710", VA = "0x185109110")]
	public static JOFBNNGKBOO<IDMEFNAINAN, T> MHEEBIIDDPF()
	{
		return default(JOFBNNGKBOO<IDMEFNAINAN, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x39CC9E0", Offset = "0x39CAFE0", VA = "0x1839CC9E0")]
	public static JOFBNNGKBOO<T, TErr> BIOOMJJMHFI<TErr>([In] TErr AKKACNNBJFA) where TErr : notnull
	{
		return default(JOFBNNGKBOO<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct GFLLPPOBLJO<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly CDPICKGDCBJ KKOKJFFFCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<TKey, TValue> LBFGIHNCMOP;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x454E9A0", Offset = "0x454CFA0", VA = "0x18454E9A0")]
	public static GFLLPPOBLJO<TKey, TValue> FEOBEKOIKMG(string BPPCEJGCMKA)
	{
		return default(GFLLPPOBLJO<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x454EB60", Offset = "0x454D160", VA = "0x18454EB60")]
	internal GFLLPPOBLJO(Dictionary<TKey, TValue> KBGCCIOIGBD, CDPICKGDCBJ IJKHLFDGEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x454EAC0", Offset = "0x454D0C0", VA = "0x18454EAC0")]
	public LLHFDIFLCJD<TKey, TValue> KNHJGNNBIDJ([Out] Dictionary<TKey, TValue> KBGCCIOIGBD)
	{
		return default(LLHFDIFLCJD<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct LLHFDIFLCJD<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TValue> LBFGIHNCMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly PDJIAGLJBDA OBCADAPAOGL;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x276FA30", Offset = "0x276E030", VA = "0x18276FA30")]
	internal LLHFDIFLCJD(Dictionary<TKey, TValue> KBGCCIOIGBD, PDJIAGLJBDA NBDLEKHCPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4AB6790", Offset = "0x4AB4D90", VA = "0x184AB6790", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct AKNJELNHKNO<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly CDPICKGDCBJ KKOKJFFFCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly HashSet<T> LBFGIHNCMOP;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x454E9A0", Offset = "0x454CFA0", VA = "0x18454E9A0")]
	public static AKNJELNHKNO<T> FEOBEKOIKMG(string BPPCEJGCMKA)
	{
		return default(AKNJELNHKNO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x454EB60", Offset = "0x454D160", VA = "0x18454EB60")]
	internal AKNJELNHKNO(HashSet<T> KBGCCIOIGBD, CDPICKGDCBJ IJKHLFDGEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x454EAC0", Offset = "0x454D0C0", VA = "0x18454EAC0")]
	public OOBMAIJJEEH<T> KNHJGNNBIDJ([Out] HashSet<T> KBGCCIOIGBD)
	{
		return default(OOBMAIJJEEH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct OOBMAIJJEEH<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HashSet<T> LBFGIHNCMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly PDJIAGLJBDA OBCADAPAOGL;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x276FA30", Offset = "0x276E030", VA = "0x18276FA30")]
	internal OOBMAIJJEEH(HashSet<T> KBGCCIOIGBD, PDJIAGLJBDA NBDLEKHCPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4AB6790", Offset = "0x4AB4D90", VA = "0x184AB6790", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct BKGFCDJEEFP<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CDPICKGDCBJ KKOKJFFFCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Stack<T> LBFGIHNCMOP;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x454E9A0", Offset = "0x454CFA0", VA = "0x18454E9A0")]
	public static BKGFCDJEEFP<T> FEOBEKOIKMG(string BPPCEJGCMKA)
	{
		return default(BKGFCDJEEFP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x454EB60", Offset = "0x454D160", VA = "0x18454EB60")]
	internal BKGFCDJEEFP(Stack<T> KBGCCIOIGBD, CDPICKGDCBJ IJKHLFDGEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x454EAC0", Offset = "0x454D0C0", VA = "0x18454EAC0")]
	public KIDLOOCDLAG<T> KNHJGNNBIDJ([Out] Stack<T> KBGCCIOIGBD)
	{
		return default(KIDLOOCDLAG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct KIDLOOCDLAG<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Stack<T> LBFGIHNCMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly PDJIAGLJBDA OBCADAPAOGL;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x276FA30", Offset = "0x276E030", VA = "0x18276FA30")]
	internal KIDLOOCDLAG(Stack<T> KBGCCIOIGBD, PDJIAGLJBDA NBDLEKHCPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4AB6790", Offset = "0x4AB4D90", VA = "0x184AB6790", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public sealed class DIKMIHOBJDI<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct GLOGNLDMOJP : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly DIKMIHOBJDI<T> PJBCGMNPFFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int LPOKFIMDBFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly bool BMDNJNNNFBP;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2473A40", Offset = "0x2472040", VA = "0x182473A40")]
		public GLOGNLDMOJP(DIKMIHOBJDI<T> AAMBBOLAGCO, int KJINOKGIMIH, bool KCOFOLKLMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4565D50", Offset = "0x4564350", VA = "0x184565D50")]
		public DIKMIHOBJDI<T>.JLFLMKCAMOD BNIMLGJMJBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4565E40", Offset = "0x4564440", VA = "0x184565E40", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4565E40", Offset = "0x4564440", VA = "0x184565E40", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class JLFLMKCAMOD : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly DIKMIHOBJDI<T> PJBCGMNPFFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly int IJAODACGJHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int AGMGMPEADMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly bool BMDNJNNNFBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool JDODMFGIFLJ;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T FJMLFGNPDDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x49D7EE0", Offset = "0x49D64E0", VA = "0x1849D7EE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x49D7FD0", Offset = "0x49D65D0", VA = "0x1849D7FD0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x49D8080", Offset = "0x49D6680", VA = "0x1849D8080", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x49D8520", Offset = "0x49D6B20", VA = "0x1849D8520")]
		public JLFLMKCAMOD(DIKMIHOBJDI<T> AAMBBOLAGCO, int KJINOKGIMIH, bool KCOFOLKLMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x49D7F20", Offset = "0x49D6520", VA = "0x1849D7F20", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x49D7FB0", Offset = "0x49D65B0", VA = "0x1849D7FB0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class PEHEFELEDOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public PEHEFELEDOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x50DEF90", Offset = "0x50DD590", VA = "0x1850DEF90")]
		internal T MMFIKBIHOOK(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly T[] ODOEKJBPNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int AGMGMPEADMJ;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int NDHHIGJLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6316F80", Offset = "0x6315580", VA = "0x186316F80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T FJMLFGNPDDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x43F9D90", Offset = "0x43F8390", VA = "0x1843F9D90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T ELELLAAAAFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6317260", Offset = "0x6315860", VA = "0x186317260")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6317130", Offset = "0x6315730", VA = "0x186317130")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int AFNDGLAJDJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xFB70A0", Offset = "0xFB56A0", VA = "0x180FB70A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1849800", Offset = "0x1847E00", VA = "0x181849800")]
	private static int MJGCPNEONAH(int EAHKFAJBNDN, int GIGAFKHMOHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x63175A0", Offset = "0x6315BA0", VA = "0x1863175A0")]
	public DIKMIHOBJDI(int IBMHAIHIDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x63172A0", Offset = "0x63158A0", VA = "0x1863172A0")]
	public DIKMIHOBJDI(int IBMHAIHIDJJ, Func<T> JHOFCDDHONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6317760", Offset = "0x6315D60", VA = "0x186317760")]
	public DIKMIHOBJDI(T[] FDMJAFAEFBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6316F50", Offset = "0x6315550", VA = "0x186316F50")]
	public void EGPFEFPPHFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x63171A0", Offset = "0x63157A0", VA = "0x1863171A0")]
	public IEnumerable<T> LFFJENBFKPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6316EB0", Offset = "0x63154B0", VA = "0x186316EB0")]
	public DIKMIHOBJDI<T>.JLFLMKCAMOD BNIMLGJMJBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x44B1980", Offset = "0x44AFF80", VA = "0x1844B1980", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x44B1980", Offset = "0x44AFF80", VA = "0x1844B1980", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class IGDCGLCOHBA
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3406170", Offset = "0x3404770", VA = "0x183406170")]
	public static DIKMIHOBJDI<T> FEOBEKOIKMG<T>(int IBMHAIHIDJJ, Func<T> JHOFCDDHONH) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static RRColor White
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x761E360", Offset = "0x761C960", VA = "0x18761E360")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x761E320", Offset = "0x761C920", VA = "0x18761E320")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x761E340", Offset = "0x761C940", VA = "0x18761E340")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x761E380", Offset = "0x761C980", VA = "0x18761E380")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x761E300", Offset = "0x761C900", VA = "0x18761E300")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x257E6E0", Offset = "0x257CCE0", VA = "0x18257E6E0")]
		public RRColor(float FBIKENCMLKN, float OOGGGDHAHHD, float PPCFCAEIJMM, float AMGCKABOOPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x74EDC90", Offset = "0x74EC290", VA = "0x1874EDC90", Slot = "4")]
		public bool Equals(RRColor OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x761DF40", Offset = "0x761C540", VA = "0x18761DF40", Slot = "0")]
		public override bool Equals(object OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x761E040", Offset = "0x761C640", VA = "0x18761E040", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x761E0C0", Offset = "0x761C6C0", VA = "0x18761E0C0", Slot = "5")]
		public string ToString(string HGFLLJFOAAE, IFormatProvider FFBJJPHCNIA)
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct RRColor32 : IEquatable<RRColor32>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int rgba;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public byte r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public byte g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public byte b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public byte a;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static RRColor32 White
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x761DEE0", Offset = "0x761C4E0", VA = "0x18761DEE0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x761DE80", Offset = "0x761C480", VA = "0x18761DE80")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x761DEB0", Offset = "0x761C4B0", VA = "0x18761DEB0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x761DF10", Offset = "0x761C510", VA = "0x18761DF10")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x761DE50", Offset = "0x761C450", VA = "0x18761DE50")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x56DDB10", Offset = "0x56DC110", VA = "0x1856DDB10")]
		public RRColor32(byte FBIKENCMLKN, byte OOGGGDHAHHD, byte PPCFCAEIJMM, byte AMGCKABOOPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1EF9B00", Offset = "0x1EF8100", VA = "0x181EF9B00", Slot = "4")]
		public bool Equals(RRColor32 OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x761D990", Offset = "0x761BF90", VA = "0x18761D990", Slot = "0")]
		public override bool Equals(object OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x110C3A0", Offset = "0x110A9A0", VA = "0x18110C3A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x761DA90", Offset = "0x761C090", VA = "0x18761DA90")]
		public static RRColor32 HEGJABMHLEC(RRColor OPLPABIPAJI)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x761DA20", Offset = "0x761C020", VA = "0x18761DA20")]
		public static RRColor HEGJABMHLEC(RRColor32 OPLPABIPAJI)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x761DBE0", Offset = "0x761C1E0", VA = "0x18761DBE0", Slot = "5")]
		public string ToString(string HGFLLJFOAAE, IFormatProvider FFBJJPHCNIA)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class CDPFHKGDHIF<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct EFJPJDEJIDP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly CDPFHKGDHIF<T> ABFMKBNBGKG;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T DEDOPNLMLPL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x4050850", Offset = "0x404EE50", VA = "0x184050850")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4050820", Offset = "0x404EE20", VA = "0x184050820", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xBD5420", Offset = "0xBD3A20", VA = "0x180BD5420")]
		public EFJPJDEJIDP(CDPFHKGDHIF<T> ABFMKBNBGKG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct HLKNBDAMKIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<EFJPJDEJIDP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public CDPFHKGDHIF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4695490", Offset = "0x4693A90", VA = "0x184695490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x407A320", Offset = "0x4078920", VA = "0x18407A320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly SemaphoreSlim KOJIGIGCEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private T GINGHILKALC;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5A73830", Offset = "0x5A71E30", VA = "0x185A73830")]
	public CDPFHKGDHIF([In] T GINGHILKALC, int CAAIDOKNPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5A736A0", Offset = "0x5A71CA0", VA = "0x185A736A0")]
	public CDPFHKGDHIF([In] T GINGHILKALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5A73560", Offset = "0x5A71B60", VA = "0x185A73560", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5A735A0", Offset = "0x5A71BA0", VA = "0x185A735A0")]
	public EFJPJDEJIDP FIJKFMLOJAJ()
	{
		return default(EFJPJDEJIDP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5A73320", Offset = "0x5A71920", VA = "0x185A73320")]
	[AsyncStateMachine(typeof(CDPFHKGDHIF<>.HLKNBDAMKIP))]
	public Task<CDPFHKGDHIF<T>.EFJPJDEJIDP> DOLLKHPEHLP(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5A735E0", Offset = "0x5A71BE0", VA = "0x185A735E0")]
	public void PINMHAJAJEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class ELFCONLKLEG
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x761A7E0", Offset = "0x7618DE0", VA = "0x18761A7E0")]
	public static CDPFHKGDHIF<IDMEFNAINAN> FEOBEKOIKMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3199380", Offset = "0x3197980", VA = "0x183199380")]
	public static CDPFHKGDHIF<T> FEOBEKOIKMG<T>([In] T GINGHILKALC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class EBNLIGPPPHL<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public readonly struct OIJNKPCEEJE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly EBNLIGPPPHL<T> DGMAIMCBBEO;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T DEDOPNLMLPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x477B540", Offset = "0x4779B40", VA = "0x18477B540")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x500BAC0", Offset = "0x500A0C0", VA = "0x18500BAC0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xBD5420", Offset = "0xBD3A20", VA = "0x180BD5420")]
		internal OIJNKPCEEJE(EBNLIGPPPHL<T> ABFMKBNBGKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct IJGGMPFBFGE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly EBNLIGPPPHL<T> DGMAIMCBBEO;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T DEDOPNLMLPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x477B540", Offset = "0x4779B40", VA = "0x18477B540")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x477B450", Offset = "0x4779A50", VA = "0x18477B450", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xBD5420", Offset = "0xBD3A20", VA = "0x180BD5420")]
		internal IJGGMPFBFGE(EBNLIGPPPHL<T> ABFMKBNBGKG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct KCBNGIDBLHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder<IJGGMPFBFGE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public EBNLIGPPPHL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private CDPFHKGDHIF<IDMEFNAINAN>.EFJPJDEJIDP <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<CDPFHKGDHIF<IDMEFNAINAN>.EFJPJDEJIDP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4A9A130", Offset = "0x4A98730", VA = "0x184A9A130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x407A320", Offset = "0x4078920", VA = "0x18407A320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly CDPFHKGDHIF<int> AGIGEAMKGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly CDPFHKGDHIF<IDMEFNAINAN> MGDAOKEPEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly CDPFHKGDHIF<IDMEFNAINAN> NKFGKEOKPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private T DLLKKBMIKKD;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x40497D0", Offset = "0x4047DD0", VA = "0x1840497D0")]
	internal EBNLIGPPPHL(CDPFHKGDHIF<int> MKCBPPBNBLJ, CDPFHKGDHIF<IDMEFNAINAN> FHGOGIIPIDD, CDPFHKGDHIF<IDMEFNAINAN> GONMONPLHLP, [In] T GINGHILKALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4048A50", Offset = "0x4047050", VA = "0x184048A50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4048ED0", Offset = "0x40474D0", VA = "0x184048ED0")]
	public OIJNKPCEEJE ECCIGIDPGHK()
	{
		return default(OIJNKPCEEJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x40495D0", Offset = "0x4047BD0", VA = "0x1840495D0")]
	public IJGGMPFBFGE KAOFGLNGLFA()
	{
		return default(IJGGMPFBFGE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x40492D0", Offset = "0x40478D0", VA = "0x1840492D0")]
	[AsyncStateMachine(typeof(EBNLIGPPPHL<>.KCBNGIDBLHC))]
	public Task<EBNLIGPPPHL<T>.IJGGMPFBFGE> ECNFIIKGDBP(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class AJLJGAPNGAM
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7619F30", Offset = "0x7618530", VA = "0x187619F30")]
	public static EBNLIGPPPHL<IDMEFNAINAN> FEOBEKOIKMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3B75400", Offset = "0x3B73A00", VA = "0x183B75400")]
	public static EBNLIGPPPHL<T> FEOBEKOIKMG<T>([In] T GINGHILKALC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class JCAFAJJIGLP<TData> : PGAGFEIEKID where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public readonly string MADHOOEDLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly TData FENODPMPHEB;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
	public override string BBCHEHFFEBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x49B6880", Offset = "0x49B4E80", VA = "0x1849B6880")]
	internal JCAFAJJIGLP(string MIALAMIFNLM, [In] TData GIDGOODJFLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class OGOJENGNMJK
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x761D180", Offset = "0x761B780", VA = "0x18761D180")]
	public static JCAFAJJIGLP<IDMEFNAINAN> FEOBEKOIKMG(string MIALAMIFNLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x31891A0", Offset = "0x31877A0", VA = "0x1831891A0")]
	public static JCAFAJJIGLP<TData> FEOBEKOIKMG<TData>(string MIALAMIFNLM, [In] TData GIDGOODJFLJ) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class CDPICKGDCBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	internal bool NDMPNDGNNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly string FLANHAMHPOO;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xCBD830", Offset = "0xCBBE30", VA = "0x180CBD830")]
	private CDPICKGDCBJ(bool BKOLBDFINND, string OKLKBKFNLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x761A2E0", Offset = "0x76188E0", VA = "0x18761A2E0")]
	public static CDPICKGDCBJ FEOBEKOIKMG(string OKLKBKFNLMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x761A350", Offset = "0x7618950", VA = "0x18761A350")]
	public PDJIAGLJBDA KNHJGNNBIDJ()
	{
		return default(PDJIAGLJBDA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct PDJIAGLJBDA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly CDPICKGDCBJ JNODIAOFOAP;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xBD5420", Offset = "0xBD3A20", VA = "0x180BD5420")]
	internal PDJIAGLJBDA(CDPICKGDCBJ BPPCEJGCMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x761D260", Offset = "0x761B860", VA = "0x18761D260", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class LBFAPAIPAGC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class FKIMABAKLCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public FKIMABAKLCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x4428CD0", Offset = "0x44272D0", VA = "0x184428CD0")]
		internal int AOGBFGKFMMM(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private HashSet<T>? JLFJOPCBJPM;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IReadOnlyCollection<T> PAOKMBGFNDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4BA4D90", Offset = "0x4BA3390", VA = "0x184BA4D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool BEENACDECBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4BA49C0", Offset = "0x4BA2FC0", VA = "0x184BA49C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x954480", Offset = "0x952A80", VA = "0x180954480")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x954450", Offset = "0x952A50", VA = "0x180954450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4BA4A10", Offset = "0x4BA3010", VA = "0x184BA4A10")]
	public bool HBHDBABAKDP(T LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4BA4C20", Offset = "0x4BA3220", VA = "0x184BA4C20")]
	public bool OCDDHDAHAOD(T LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4BA4BD0", Offset = "0x4BA31D0", VA = "0x184BA4BD0")]
	public bool HBIAGPPOPJF(T LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4BA48E0", Offset = "0x4BA2EE0", VA = "0x184BA48E0")]
	public void CBKJNIKMAPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4BA4DD0", Offset = "0x4BA33D0", VA = "0x184BA4DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public LBFAPAIPAGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class IFFCOANOBGF
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class GLDIEAEPCID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public GLDIEAEPCID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x761B130", Offset = "0x7619730", VA = "0x18761B130")]
		internal int AOGBFGKFMMM(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private HashSet<object>? JLFJOPCBJPM;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyCollection<object> PAOKMBGFNDE
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x761B4E0", Offset = "0x7619AE0", VA = "0x18761B4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool BEENACDECBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x761B2F0", Offset = "0x76198F0", VA = "0x18761B2F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x954480", Offset = "0x952A80", VA = "0x180954480")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x954450", Offset = "0x952A50", VA = "0x180954450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x761B300", Offset = "0x7619900", VA = "0x18761B300")]
	public bool HBHDBABAKDP(object LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x761B440", Offset = "0x7619A40", VA = "0x18761B440")]
	public bool OCDDHDAHAOD(object LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x761B3E0", Offset = "0x76199E0", VA = "0x18761B3E0")]
	public bool HBIAGPPOPJF(object LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x761B280", Offset = "0x7619880", VA = "0x18761B280")]
	public void CBKJNIKMAPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x761B570", Offset = "0x7619B70", VA = "0x18761B570", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public IFFCOANOBGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class JLDABEMCGKB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private struct ENKDFMIKIGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float MPAJGOMHHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public T DEDOPNLMLPL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly Dictionary<object, ENKDFMIKIGI> EIEEOCBNIGD;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public virtual T IJOKMEENCFD
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x17146C0", Offset = "0x1712CC0", VA = "0x1817146C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1713240", Offset = "0x1711840", VA = "0x181713240", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public object? INGPMOMHGFN
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x954BC0", Offset = "0x9531C0", VA = "0x180954BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x954470", Offset = "0x952A70", VA = "0x180954470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool EBCBNNJAAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x4431780", Offset = "0x442FD80", VA = "0x184431780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x49D4B00", Offset = "0x49D3100", VA = "0x1849D4B00")]
	public bool FJAEOODAFCM(T KBGCCIOIGBD, object LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x44317E0", Offset = "0x442FDE0", VA = "0x1844317E0")]
	public bool OANKGFLJIAB(object LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4431190", Offset = "0x442F790", VA = "0x184431190")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x49D4F00", Offset = "0x49D3500", VA = "0x1849D4F00")]
	public bool GMJNAAAPBAP(object LAAJFAFNFCN, [Out] T KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x49D54C0", Offset = "0x49D3AC0", VA = "0x1849D54C0")]
	[OPICOFBLENP("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool MFBCGPJFHLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x49D6950", Offset = "0x49D4F50", VA = "0x1849D6950")]
	public JLDABEMCGKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class BOGJHKLDLEM : IPJCPJBLOAM<FDINGGDGHDL>
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal class JNJHPIHDEND : IEqualityComparer<FDINGGDGHDL>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		internal static readonly JNJHPIHDEND IMFIEPMCPDC;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x761BA00", Offset = "0x761A000", VA = "0x18761BA00", Slot = "4")]
		public bool Equals(FDINGGDGHDL IKAEODCKAIP, FDINGGDGHDL ACCJFOPIMAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x687E910", Offset = "0x687CF10", VA = "0x18687E910", Slot = "5")]
		public int GetHashCode(FDINGGDGHDL GMFKPONAANG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public JNJHPIHDEND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x761A270", Offset = "0x7618870", VA = "0x18761A270")]
	public BOGJHKLDLEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x761A080", Offset = "0x7618680", VA = "0x18761A080", Slot = "4")]
	public override bool HBHDBABAKDP(FDINGGDGHDL LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x761A1C0", Offset = "0x76187C0", VA = "0x18761A1C0", Slot = "5")]
	public override bool OCDDHDAHAOD(FDINGGDGHDL LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x761A130", Offset = "0x7618730", VA = "0x18761A130")]
	private static void IAFNBNDMFPE(FDINGGDGHDL LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x1614D50", Offset = "0x1613350", VA = "0x181614D50", Slot = "6")]
	protected override string TokenToString(FDINGGDGHDL LAAJFAFNFCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class FDINGGDGHDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly string FEHAOBOMBFK;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
	public FDINGGDGHDL(string FEHAOBOMBFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x761A850", Offset = "0x7618E50", VA = "0x18761A850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class IPJCPJBLOAM<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly IEqualityComparer<T> BLMEGMHOING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private HashSet<T>? JLFJOPCBJPM;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool BEENACDECBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x4799D80", Offset = "0x4798380", VA = "0x184799D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA8B580", Offset = "0xA89B80", VA = "0x180A8B580")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xB44CD0", Offset = "0xB432D0", VA = "0x180B44CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x479AA30", Offset = "0x4799030", VA = "0x18479AA30")]
	public IPJCPJBLOAM(IEqualityComparer<T> BLMEGMHOING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x4799DC0", Offset = "0x47983C0", VA = "0x184799DC0", Slot = "4")]
	public virtual bool HBHDBABAKDP(T LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x479A2D0", Offset = "0x47988D0", VA = "0x18479A2D0", Slot = "5")]
	public virtual bool OCDDHDAHAOD(T LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x4799CA0", Offset = "0x47982A0", VA = "0x184799CA0")]
	public void CBKJNIKMAPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x479A730", Offset = "0x4798D30", VA = "0x18479A730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class GAHHCHCOBKJ<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private List<WeakReference<T>>? JLFJOPCBJPM;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool BEENACDECBP
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x44C56B0", Offset = "0x44C3CB0", VA = "0x1844C56B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x44C5BE0", Offset = "0x44C41E0", VA = "0x1844C5BE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x44C57D0", Offset = "0x44C3DD0", VA = "0x1844C57D0")]
	public void HBHDBABAKDP(T LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x44C5A40", Offset = "0x44C4040", VA = "0x1844C5A40")]
	public void OCDDHDAHAOD(T LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x44C5670", Offset = "0x44C3C70", VA = "0x1844C5670")]
	public void CBKJNIKMAPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x44C5D80", Offset = "0x44C4380", VA = "0x1844C5D80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public GAHHCHCOBKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal static class OMDNPHOHPAC
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x33D5110", Offset = "0x33D3710", VA = "0x1833D5110")]
	public static void JFBBKNCFILH<T>(this List<T> BHMKCPLLJPF, int EAHKFAJBNDN) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class FLLLOHHLPAP<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct KBHONIOFBPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public float MPAJGOMHHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public T DEDOPNLMLPL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly Dictionary<FDINGGDGHDL, KBHONIOFBPC> EIEEOCBNIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly EqualityComparer<T> NIIKEIGHEDB;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public virtual T IJOKMEENCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x956CE0", Offset = "0x9552E0", VA = "0x180956CE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x956CA0", Offset = "0x9552A0", VA = "0x180956CA0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private FDINGGDGHDL? INGPMOMHGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9527E0", Offset = "0x950DE0", VA = "0x1809527E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool EBCBNNJAAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x4431780", Offset = "0x442FD80", VA = "0x184431780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x4430E50", Offset = "0x442F450", VA = "0x184430E50")]
	public bool FJAEOODAFCM(T KBGCCIOIGBD, FDINGGDGHDL LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x44317E0", Offset = "0x442FDE0", VA = "0x1844317E0")]
	public bool OANKGFLJIAB(FDINGGDGHDL LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x4431190", Offset = "0x442F790", VA = "0x184431190")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4431100", Offset = "0x442F700", VA = "0x184431100")]
	public bool GMJNAAAPBAP(FDINGGDGHDL LAAJFAFNFCN, [Out] T KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x44311E0", Offset = "0x442F7E0", VA = "0x1844311E0")]
	[OPICOFBLENP("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool MFBCGPJFHLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x44319D0", Offset = "0x442FFD0", VA = "0x1844319D0")]
	public FLLLOHHLPAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class MJEPMMAIKGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly Dictionary<object, float> EIEEOCBNIGD;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float FCOFKBLEKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xD791D0", Offset = "0xD777D0", VA = "0x180D791D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xD79A50", Offset = "0xD78050", VA = "0x180D79A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x761BB00", Offset = "0x761A100", VA = "0x18761BB00")]
	public void FJAEOODAFCM(float KBGCCIOIGBD, object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x761BBC0", Offset = "0x761A1C0", VA = "0x18761BBC0")]
	public void OANKGFLJIAB(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x761BB70", Offset = "0x761A170", VA = "0x18761BB70")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x761BC30", Offset = "0x761A230", VA = "0x18761BC30")]
	private void PCKFJCOCGDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x761BD60", Offset = "0x761A360", VA = "0x18761BD60")]
	public MJEPMMAIKGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface JEEDOKEHIEI
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event LLLEILNOHAD DKGAKCAMIEP;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class MNIAMPGIDNC : JEEDOKEHIEI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public readonly struct IKDNCBCEBHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly float EKFPEOGCKKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly float BMHADMIFCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		internal readonly bool DLCFPDABHIK;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float NGPEAGCEMCO
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x761B720", Offset = "0x7619D20", VA = "0x18761B720")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x761B8A0", Offset = "0x7619EA0", VA = "0x18761B8A0")]
		public IKDNCBCEBHI(float HHIGALLBHNK, float PDNKBEEOLID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x761B730", Offset = "0x7619D30", VA = "0x18761B730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class HPDDBIMNPCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public MNIAMPGIDNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public HPDDBIMNPCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x761B1E0", Offset = "0x76197E0", VA = "0x18761B1E0")]
		internal void JFIPKBEAHLN(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly int CCAKDDNOMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private int FEDCGLBHKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly JEEDOKEHIEI[] DCNAGEKOPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly LLLEILNOHAD[] MOKEOOADLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly IKDNCBCEBHI[] KBEKBDHLLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private IKDNCBCEBHI KDHDHIPMOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly DFIENIKFOMH AAPLLHEMPKD;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event LLLEILNOHAD DKGAKCAMIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x761C4D0", Offset = "0x761AAD0", VA = "0x18761C4D0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x761C410", Offset = "0x761AA10", VA = "0x18761C410", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x761C590", Offset = "0x761AB90", VA = "0x18761C590")]
	public MNIAMPGIDNC(int CCAKDDNOMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x761BDF0", Offset = "0x761A3F0", VA = "0x18761BDF0")]
	public DFIENIKFOMH BAFFFEOJFBC(IKDNCBCEBHI OLCJMBGBODB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x761BF90", Offset = "0x761A590", VA = "0x18761BF90")]
	public void GBJMEHKCHEN(JEEDOKEHIEI AJKAEBNDKFG, [Optional] IKDNCBCEBHI GOHDBGECHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x761BE80", Offset = "0x761A480", VA = "0x18761BE80", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public delegate void LLLEILNOHAD(float KBBMEHINNKF);
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class NCJDACIJFEB
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private class FDPJOFLKHOD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly JEEDOKEHIEI IPPJKGMAIAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly LLLEILNOHAD IJCKFHFIADK;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x761A8F0", Offset = "0x7618EF0", VA = "0x18761A8F0")]
		public FDPJOFLKHOD(JEEDOKEHIEI IPPJKGMAIAE, LLLEILNOHAD IJCKFHFIADK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x761A8A0", Offset = "0x7618EA0", VA = "0x18761A8A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x761C720", Offset = "0x761AD20", VA = "0x18761C720")]
	internal static bool APIEBFBLHDC(float AMGCKABOOPF, float PPCFCAEIJMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7609E30", Offset = "0x7608430", VA = "0x187609E30")]
	internal static float NKEHNGGGMBL(float AMGCKABOOPF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x761C790", Offset = "0x761AD90", VA = "0x18761C790")]
	public static IDisposable GNODFFMLMCB(this JEEDOKEHIEI IPPJKGMAIAE, LLLEILNOHAD IJCKFHFIADK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class DFIENIKFOMH : JEEDOKEHIEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private float KBBMEHINNKF;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float NGJKGBJBAEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x761A5B0", Offset = "0x7618BB0", VA = "0x18761A5B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event LLLEILNOHAD? DKGAKCAMIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x761A740", Offset = "0x7618D40", VA = "0x18761A740", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x761A6A0", Offset = "0x7618CA0", VA = "0x18761A6A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public DFIENIKFOMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface PJGCEFOBDBN<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MDLPAKNCEDC<T> OCHIEBOHGDJ([Out] T KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KKIOKOIHHPE();
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class FDNBKMNPJID<T> : PJGCEFOBDBN<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly ConcurrentStack<T> LALIDOKBDNF;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x4419B90", Offset = "0x4418190", VA = "0x184419B90", Slot = "4")]
	public MDLPAKNCEDC<T> OCHIEBOHGDJ([Out] T KBGCCIOIGBD)
	{
		return default(MDLPAKNCEDC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x4419A70", Offset = "0x4418070", VA = "0x184419A70")]
	public void BHDLIGCHPAN(T PJIOMIKBOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x4069210", Offset = "0x4067810", VA = "0x184069210", Slot = "5")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "6")]
	protected virtual void OAKMKNDHCHG(T CICNDJICHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x4419AF0", Offset = "0x44180F0", VA = "0x184419AF0")]
	private T NPPDIJEBOHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x4419C30", Offset = "0x4418230", VA = "0x184419C30")]
	public FDNBKMNPJID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct MDLPAKNCEDC<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly T PJIOMIKBOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly FDNBKMNPJID<T> DFPGJPGNKBI;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x9B2EC0", Offset = "0x9B14C0", VA = "0x1809B2EC0")]
	internal MDLPAKNCEDC(T KBGCCIOIGBD, FDNBKMNPJID<T> DFPGJPGNKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x4DC7110", Offset = "0x4DC5710", VA = "0x184DC7110", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class CLKMALCFIJJ : FDNBKMNPJID<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly CLKMALCFIJJ IMFIEPMCPDC;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x761A410", Offset = "0x7618A10", VA = "0x18761A410")]
	public static MDLPAKNCEDC<StringBuilder> NPPDIJEBOHO([Out] StringBuilder KBGCCIOIGBD)
	{
		return default(MDLPAKNCEDC<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x761A4B0", Offset = "0x7618AB0", VA = "0x18761A4B0", Slot = "6")]
	protected override void OAKMKNDHCHG(StringBuilder CICNDJICHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x761A570", Offset = "0x7618B70", VA = "0x18761A570")]
	public CLKMALCFIJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class IJGAGAHGILF : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6F88270", Offset = "0x6F86870", VA = "0x186F88270")]
	public IJGAGAHGILF(string MIALAMIFNLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public class OLBDCLPAILH<TKey, TValue> : PHIFDNOECFI<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, CGACJJLGHFE where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class LJFJOINEIPF : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public OLBDCLPAILH<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x17146C0", Offset = "0x1712CC0", VA = "0x1817146C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x4BC1170", Offset = "0x4BBF770", VA = "0x184BC1170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
		[DebuggerHidden]
		public LJFJOINEIPF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x447FD90", Offset = "0x447E390", VA = "0x18447FD90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x4BC0CA0", Offset = "0x4BBF2A0", VA = "0x184BC0CA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4BC0400", Offset = "0x4BBEA00", VA = "0x184BC0400")]
		private void ACIHHJJLKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4BC04A0", Offset = "0x4BBEAA0", VA = "0x184BC04A0")]
		private void CHJIKJDKKOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4BC1120", Offset = "0x4BBF720", VA = "0x184BC1120", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly PHIFDNOECFI<TKey, TValue> NAHHEEILNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly IDictionary<TKey, TValue> JMAJJMFNCOB;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x501DE70", Offset = "0x501C470", VA = "0x18501DE70", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool NJEEMOHCODN
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public TValue NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x501E120", Offset = "0x501C720", VA = "0x18501E120", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x501E3F0", Offset = "0x501C9F0", VA = "0x18501E3F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public ICollection<TKey> OLFFBNADHCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x501E170", Offset = "0x501C770", VA = "0x18501E170", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICollection<TValue> JKLIKDPGFIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x501E290", Offset = "0x501C890", VA = "0x18501E290", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x501DDB0", Offset = "0x501C3B0", VA = "0x18501DDB0")]
	public OLBDCLPAILH(PHIFDNOECFI<TKey, TValue> NAHHEEILNGL, [Optional] IDictionary<TKey, TValue>? JMAJJMFNCOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x501B5E0", Offset = "0x5019BE0", VA = "0x18501B5E0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x501C690", Offset = "0x501AC90", VA = "0x18501C690")]
	public void JGGBNMCDDIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x501B270", Offset = "0x5019870", VA = "0x18501B270", Slot = "9")]
	public void Add(TKey LKMGECEEGEE, TValue KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x501C430", Offset = "0x501AA30", VA = "0x18501C430")]
	public void HGFBJLAOBNG(TKey LKMGECEEGEE, TValue KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x501C1D0", Offset = "0x501A7D0", VA = "0x18501C1D0")]
	public void HAOCEOAKEMA(TKey LKMGECEEGEE, TValue KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x501C950", Offset = "0x501AF50", VA = "0x18501C950")]
	public void KCCPGCIKIFG(TKey LKMGECEEGEE, TValue KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x501BF80", Offset = "0x501A580", VA = "0x18501BF80")]
	public void GLACIFMBEPN(TKey LKMGECEEGEE, TValue KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x501D430", Offset = "0x501BA30", VA = "0x18501D430", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> MBDDOPABDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x501D480", Offset = "0x501BA80", VA = "0x18501D480", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> MBDDOPABDGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x501D7E0", Offset = "0x501BDE0", VA = "0x18501D7E0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> MBDDOPABDGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x501B720", Offset = "0x5019D20", VA = "0x18501B720", Slot = "8")]
	public bool ContainsKey(TKey LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x501CDF0", Offset = "0x501B3F0", VA = "0x18501CDF0")]
	public bool LPNICKAODBC(TKey LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x501CCD0", Offset = "0x501B2D0", VA = "0x18501CCD0")]
	public bool LIAJBFOMLNA(TKey LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x501D250", Offset = "0x501B850", VA = "0x18501D250", Slot = "10")]
	public bool Remove(TKey LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x501DC10", Offset = "0x501C210", VA = "0x18501DC10", Slot = "11")]
	public bool TryGetValue(TKey LKMGECEEGEE, [Out] TValue KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x501B7E0", Offset = "0x5019DE0", VA = "0x18501B7E0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] CJFOOLJEHLK, int BJJLGILDBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x4A698E0", Offset = "0x4A67EE0", VA = "0x184A698E0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x501C120", Offset = "0x501A720", VA = "0x18501C120", Slot = "19")]
	[IteratorStateMachine(typeof(OLBDCLPAILH<, >.LJFJOINEIPF))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x501CB80", Offset = "0x501B180", VA = "0x18501CB80", Slot = "21")]
	public bool KKIDAKGCFDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x501CEB0", Offset = "0x501B4B0", VA = "0x18501CEB0")]
	private TValue NDJEMIMHDNK(TKey LKMGECEEGEE)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface CGACJJLGHFE
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KKIDAKGCFDM();
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface PHIFDNOECFI<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, CGACJJLGHFE
{
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[DefaultMember("Item")]
public sealed class HNFGOLPBJLN<TKey, TVal> : PHIFDNOECFI<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, CGACJJLGHFE where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public delegate int KAMLOIPNHBD(TKey LKMGECEEGEE, TVal KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public delegate void KGEALBHDJCD(TKey LKMGECEEGEE, TVal KBGCCIOIGBD, IAIFEKOPBMN CEGFAIJENKH);

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private class JDBAONNDAOK
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public TKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xAD38D0", Offset = "0xAD1ED0", VA = "0x180AD38D0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public TVal DEDOPNLMLPL
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xA8B580", Offset = "0xA89B80", VA = "0x180A8B580")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xB44CD0", Offset = "0xB432D0", VA = "0x180B44CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public int NGPEAGCEMCO
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x991F60", Offset = "0x990560", VA = "0x180991F60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x9915B0", Offset = "0x98FBB0", VA = "0x1809915B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public DateTimeOffset NBAAFIKECCK
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xD98C40", Offset = "0xD97240", VA = "0x180D98C40")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xD98C30", Offset = "0xD97230", VA = "0x180D98C30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x49C5930", Offset = "0x49C3F30", VA = "0x1849C5930")]
		public JDBAONNDAOK(TKey LKMGECEEGEE, TVal DGOEGFOLJJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class HHDNPMGPILH : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public HNFGOLPBJLN<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private LinkedList<JDBAONNDAOK>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x17146C0", Offset = "0x1712CC0", VA = "0x1817146C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x466E620", Offset = "0x466CC20", VA = "0x18466E620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
		[DebuggerHidden]
		public HHDNPMGPILH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x441D6D0", Offset = "0x441BCD0", VA = "0x18441D6D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x466E0E0", Offset = "0x466C6E0", VA = "0x18466E0E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x466D430", Offset = "0x466BA30", VA = "0x18466D430")]
		private void ACIHHJJLKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x466E440", Offset = "0x466CA40", VA = "0x18466E440", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public const int JPLECHNEKJE = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<TKey, LinkedListNode<JDBAONNDAOK>> PONOKBBDBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly LinkedList<JDBAONNDAOK> NIPIFLKFBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly KAMLOIPNHBD? FHBIANPBGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly TimeSpan OPNOBDGJKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly KGEALBHDJCD? ICBKKFJOOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly POJBELOMCGC FPGFCJBNBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private bool FOFBLMCIFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly List<TKey> IFELHBDFLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly List<TVal> HBGFEFHPPHN;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int JLPIJPCEGAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x9612B0", Offset = "0x95F8B0", VA = "0x1809612B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	internal int PFKJFKMCCPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA708D0", Offset = "0xA6EED0", VA = "0x180A708D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA708E0", Offset = "0xA6EEE0", VA = "0x180A708E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x46BEAF0", Offset = "0x46BD0F0", VA = "0x1846BEAF0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	internal int OIJEIDCFJHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4431190", Offset = "0x442F790", VA = "0x184431190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public ICollection<TVal> JKLIKDPGFIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x46BEC70", Offset = "0x46BD270", VA = "0x1846BEC70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	ICollection<TKey> IDictionary<TKey, TVal>.GCKOEKMKIAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x46B88D0", Offset = "0x46B6ED0", VA = "0x1846B88D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool NJEEMOHCODN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public TVal NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x46BEBC0", Offset = "0x46BD1C0", VA = "0x1846BEBC0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x46BED60", Offset = "0x46BD360", VA = "0x1846BED60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x46B71A0", Offset = "0x46B57A0", VA = "0x1846B71A0")]
	private bool OEMGDIJNMJN(int CCAKDDNOMFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x469DE30", Offset = "0x469C430", VA = "0x18469DE30")]
	private void BNFNMGHOBCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x46BC1D0", Offset = "0x46BA7D0", VA = "0x1846BC1D0")]
	public HNFGOLPBJLN(int CCAKDDNOMFJ, [Optional] KAMLOIPNHBD? FHBIANPBGPB, [Optional] IEqualityComparer<TKey>? OLLCJFOMGIM, [Optional] KGEALBHDJCD? ICBKKFJOOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x46BA1E0", Offset = "0x46B87E0", VA = "0x1846BA1E0")]
	public HNFGOLPBJLN(TimeSpan OPNOBDGJKJA, [Optional] IEqualityComparer<TKey>? OLLCJFOMGIM, [Optional] KGEALBHDJCD? ICBKKFJOOIE, [Optional] POJBELOMCGC? FPGFCJBNBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x46BA080", Offset = "0x46B8680", VA = "0x1846BA080")]
	public HNFGOLPBJLN(int CCAKDDNOMFJ, TimeSpan OPNOBDGJKJA, [Optional] IEqualityComparer<TKey>? OLLCJFOMGIM, [Optional] KGEALBHDJCD? ICBKKFJOOIE, [Optional] POJBELOMCGC? FPGFCJBNBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x46BE4D0", Offset = "0x46BCAD0", VA = "0x1846BE4D0")]
	public HNFGOLPBJLN(int CCAKDDNOMFJ, KAMLOIPNHBD? FHBIANPBGPB, TimeSpan OPNOBDGJKJA, [Optional] IEqualityComparer<TKey>? OLLCJFOMGIM, [Optional] KGEALBHDJCD? ICBKKFJOOIE, [Optional] POJBELOMCGC? FPGFCJBNBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x46AA1D0", Offset = "0x46A87D0", VA = "0x1846AA1D0", Slot = "21")]
	public bool KKIDAKGCFDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x469C1F0", Offset = "0x469A7F0", VA = "0x18469C1F0", Slot = "22")]
	public bool AEHHMDNPNKH(int IBMHAIHIDJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x46AF450", Offset = "0x46ADA50", VA = "0x1846AF450")]
	private bool LHNAIMMBIIE(int IBMHAIHIDJJ, IAIFEKOPBMN CEGFAIJENKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x46A1F50", Offset = "0x46A0550", VA = "0x1846A1F50")]
	public void ECFLGDLFBIO(TKey LKMGECEEGEE, TVal KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x469D930", Offset = "0x469BF30", VA = "0x18469D930", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> MBDDOPABDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x469D520", Offset = "0x469BB20", VA = "0x18469D520", Slot = "9")]
	public void Add(TKey LKMGECEEGEE, TVal KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x469E540", Offset = "0x469CB40", VA = "0x18469E540", Slot = "8")]
	public bool ContainsKey(TKey LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x46B7D90", Offset = "0x46B6390", VA = "0x1846B7D90", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> MBDDOPABDGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x46B78D0", Offset = "0x46B5ED0", VA = "0x1846B78D0", Slot = "10")]
	public bool Remove(TKey LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x46B8520", Offset = "0x46B6B20", VA = "0x1846B8520", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> MBDDOPABDGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x46AAF20", Offset = "0x46A9520", VA = "0x1846AAF20")]
	private bool LFGMPFNBDCL(TKey LKMGECEEGEE, [Out] TVal KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x46B6FA0", Offset = "0x46B55A0", VA = "0x1846B6FA0")]
	private TVal NPPDIJEBOHO(TKey MHOMJGNFGGL)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x46B9940", Offset = "0x46B7F40", VA = "0x1846B9940", Slot = "11")]
	public bool TryGetValue(TKey MHOMJGNFGGL, [Out] TVal KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x469E300", Offset = "0x469C900", VA = "0x18469E300", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x469EA10", Offset = "0x469D010", VA = "0x18469EA10", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] CJFOOLJEHLK, int BJJLGILDBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x46A9BB0", Offset = "0x46A81B0", VA = "0x1846A9BB0")]
	private void JGAFKEPOLMB(TKey LKMGECEEGEE, TVal DGOEGFOLJJL, IAIFEKOPBMN CEGFAIJENKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x46A7D00", Offset = "0x46A6300", VA = "0x1846A7D00")]
	private bool IAPJMDPJNEN(JDBAONNDAOK AIJONMGJNLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x46B31D0", Offset = "0x46B17D0", VA = "0x1846B31D0")]
	private void LKEHHHFJALP(LinkedListNode<JDBAONNDAOK> IGEPGONCPND, TVal IOCKBOOECEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x46A57E0", Offset = "0x46A3DE0", VA = "0x1846A57E0")]
	private void FJAEOODAFCM(TKey LKMGECEEGEE, TVal KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x46A2AB0", Offset = "0x46A10B0", VA = "0x1846A2AB0")]
	private void FFCCMEJFINM(JDBAONNDAOK AIJONMGJNLE, TVal IOCKBOOECEL, int FGICKOMPDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x46A7590", Offset = "0x46A5B90", VA = "0x1846A7590", Slot = "19")]
	[IteratorStateMachine(typeof(HNFGOLPBJLN<, >.HHDNPMGPILH))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x46B8920", Offset = "0x46B6F20", VA = "0x1846B8920", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public enum IAIFEKOPBMN : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class BHMEGLMMBNI<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly TKey MBLMBFANAAL;

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x58A06E0", Offset = "0x589ECE0", VA = "0x1858A06E0")]
	public BHMEGLMMBNI(TKey PPGILBEKLCH, Exception DIHKEEPHEOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class JCINOCDFICC : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x680C510", Offset = "0x680AB10", VA = "0x18680C510")]
	public JCINOCDFICC(string MIALAMIFNLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class KDGGAAKPFMI<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class IHEKKLHBCBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public KDGGAAKPFMI<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public IHEKKLHBCBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x4779D00", Offset = "0x4778300", VA = "0x184779D00")]
		internal Task<TResource> FHAJDNKOKLM(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct KOHPLOLCAKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public KDGGAAKPFMI<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x4B35B90", Offset = "0x4B34190", VA = "0x184B35B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x4B36710", Offset = "0x4B34D10", VA = "0x184B36710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct LLNCFLGAFJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x4BC4400", Offset = "0x4BC2A00", VA = "0x184BC4400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x4BC5140", Offset = "0x4BC3740", VA = "0x184BC5140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly LOCFIGMEMFO<TId, Task<TResource>> PINCCKDLBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> ICMNDJPABII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? NJAHCDIHGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Action<TResource>? KCOMDDIPFEF;

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x4A9FDE0", Offset = "0x4A9E3E0", VA = "0x184A9FDE0")]
	public KDGGAAKPFMI(int ALOJAOINMGK = 0, [Optional] IEqualityComparer<TId>? FNJGAFDGLBB, [Optional] Func<TId, CancellationToken, Task<TResource>>? MKJPDHHACCF, [Optional] Action<TResource>? ODILGOKBKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x4A9F570", Offset = "0x4A9DB70", VA = "0x184A9F570")]
	public KFDDALGMHJI<Task<TResource>> EIABKLCIIAG(TId KGHCKLKGJKM, [Optional] Func<TId, CancellationToken, Task<TResource>>? MKJPDHHACCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x4A9EB60", Offset = "0x4A9D160", VA = "0x184A9EB60")]
	private void DHGLNKNCHGP(Task<TResource> CBPINBDBDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x4A9E8F0", Offset = "0x4A9CEF0", VA = "0x184A9E8F0")]
	[AsyncStateMachine(typeof(KDGGAAKPFMI<, >.KOHPLOLCAKJ))]
	private Task ACFDHBCDBGM(Task<TResource> CBPINBDBDCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x44E3BB0", Offset = "0x44E21B0", VA = "0x1844E3BB0")]
	public void NFGPLPPJJIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x4A9E9F0", Offset = "0x4A9CFF0", VA = "0x184A9E9F0")]
	public LOCFIGMEMFO<TId, Task<TResource>>.CEPDBEGPIGE BNIMLGJMJBK()
	{
		return default(LOCFIGMEMFO<TId, Task<TResource>>.CEPDBEGPIGE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x4A9FD40", Offset = "0x4A9E340", VA = "0x184A9FD40", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x4A9FD40", Offset = "0x4A9E340", VA = "0x184A9FD40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x4A9F9B0", Offset = "0x4A9DFB0", VA = "0x184A9F9B0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(KDGGAAKPFMI<, >.LLNCFLGAFJI))]
	internal static Task IMPLKFDPJIE(Task<TResource> CBPINBDBDCO, CancellationTokenSource GCEKMPIANPC, Dictionary<Task<TResource>, CancellationTokenSource> MAJPHHMJILC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class LOCFIGMEMFO<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class INMNHDPGCPJ : IEquatable<INMNHDPGCPJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public readonly TValue DEDOPNLMLPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int HDFJNEDIEMH;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xFA4FB0", Offset = "0xFA35B0", VA = "0x180FA4FB0")]
		public INMNHDPGCPJ(TValue KBGCCIOIGBD, int AMKCELBMEDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x4791690", Offset = "0x478FC90", VA = "0x184791690", Slot = "4")]
		public bool Equals(INMNHDPGCPJ? OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x47915F0", Offset = "0x478FBF0", VA = "0x1847915F0", Slot = "0")]
		public override bool Equals(object? GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x47918D0", Offset = "0x478FED0", VA = "0x1847918D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public struct CEPDBEGPIGE : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private Dictionary<TKey, INMNHDPGCPJ>.Enumerator CBGJBIFAPIK;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x5A75C80", Offset = "0x5A74280", VA = "0x185A75C80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public (TKey Key, TValue Value, int RefCount) FJMLFGNPDDN
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x5A76240", Offset = "0x5A74840", VA = "0x185A76240", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5A75DC0", Offset = "0x5A743C0", VA = "0x185A75DC0")]
		public CEPDBEGPIGE(LOCFIGMEMFO<TKey, TValue> EIEEOCBNIGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x5A75830", Offset = "0x5A73E30", VA = "0x185A75830", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x5A758B0", Offset = "0x5A73EB0", VA = "0x185A758B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x5A759D0", Offset = "0x5A73FD0", VA = "0x185A759D0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class EKMEPIGONIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public LOCFIGMEMFO<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public INMNHDPGCPJ refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public EKMEPIGONIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x4069C70", Offset = "0x4068270", VA = "0x184069C70")]
		internal void FHAJDNKOKLM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly Dictionary<TKey, INMNHDPGCPJ> HFPBJAIELKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly Func<TKey, TValue>? BNNLELLBOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Action<TValue>? FODEKMGPLAG;

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x4BCAF80", Offset = "0x4BC9580", VA = "0x184BCAF80")]
	public LOCFIGMEMFO(int ALOJAOINMGK = 0, [Optional] IEqualityComparer<TKey>? OLLCJFOMGIM, [Optional] Func<TKey, TValue>? LACFGOJOABD, [Optional] Action<TValue>? PDEPNDOHCDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x4BC9AE0", Offset = "0x4BC80E0", VA = "0x184BC9AE0")]
	public KFDDALGMHJI<TValue> EIABKLCIIAG(TKey LKMGECEEGEE, [Optional] Func<TKey, TValue>? BALLJEKNFFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x4BC9680", Offset = "0x4BC7C80", VA = "0x184BC9680")]
	private void BHDLIGCHPAN(TKey LKMGECEEGEE, INMNHDPGCPJ JLCJMJCAGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x4BCA730", Offset = "0x4BC8D30", VA = "0x184BCA730")]
	public void NFGPLPPJJIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x4BC9A20", Offset = "0x4BC8020", VA = "0x184BC9A20")]
	public CEPDBEGPIGE BNIMLGJMJBK()
	{
		return default(CEPDBEGPIGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x4BCADB0", Offset = "0x4BC93B0", VA = "0x184BCADB0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x4BCADB0", Offset = "0x4BC93B0", VA = "0x184BCADB0", Slot = "5")]
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
