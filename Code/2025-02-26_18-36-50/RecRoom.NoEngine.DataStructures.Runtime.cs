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
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x757E2C0", Offset = "0x757D6C0", VA = "0x18757E2C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x975680", Offset = "0x974A80", VA = "0x180975680")]
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
		[Cpp2IlInjected.Address(RVA = "0x9756C0", Offset = "0x974AC0", VA = "0x1809756C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class NOLKIACAAIO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4FBA590", Offset = "0x4FB9990", VA = "0x184FBA590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4FBA5F0", Offset = "0x4FB99F0", VA = "0x184FBA5F0")]
	protected OKDNIJHAHKC(bool BHKCGGKKMEL, bool LMOLHGOGEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4FB9E40", Offset = "0x4FB9240", VA = "0x184FB9E40")]
	protected bool GPDPPOIBMCM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4FBA0F0", Offset = "0x4FB94F0", VA = "0x184FBA0F0")]
	protected void KBKEMJDJBFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4FB9BD0", Offset = "0x4FB8FD0", VA = "0x184FB9BD0")]
	protected void DJGPGFNOCHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3990520", Offset = "0x398F920", VA = "0x183990520")]
	private static void MNMIEIBDNLO<U>(List<U>? BHMKCPLLJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4FB9EE0", Offset = "0x4FB92E0", VA = "0x184FB9EE0", Slot = "4")]
	public void HBHDBABAKDP(T PJDAFKMDDCG, bool ACAMEFINNAO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4FBA3C0", Offset = "0x4FB97C0", VA = "0x184FBA3C0", Slot = "5")]
	public void OCDDHDAHAOD(T PJDAFKMDDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4FBA210", Offset = "0x4FB9610", VA = "0x184FBA210")]
	public void KKIOKOIHHPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class FKDOIPNGGAF : OKDNIJHAHKC<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x757CB40", Offset = "0x757BF40", VA = "0x18757CB40")]
	public FKDOIPNGGAF(bool BHKCGGKKMEL = false, bool LMOLHGOGEOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x757C880", Offset = "0x757BC80", VA = "0x18757C880")]
	public void CNDNDIPPKBE()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x757CA80", Offset = "0x757BE80", VA = "0x18757CA80")]
	public static FKDOIPNGGAF FHOKCPBBLGF(FKDOIPNGGAF PBIGHEIFGJE, Action PJDAFKMDDCG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x757CAE0", Offset = "0x757BEE0", VA = "0x18757CAE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x40173C0", Offset = "0x40167C0", VA = "0x1840173C0")]
	public JKOOBLENGDB(bool BHKCGGKKMEL = false, bool LMOLHGOGEOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4976280", Offset = "0x4975680", VA = "0x184976280")]
	public void CNDNDIPPKBE(T CHBEBLKFDBC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x43D3FC0", Offset = "0x43D33C0", VA = "0x1843D3FC0")]
	public static JKOOBLENGDB<T> FHOKCPBBLGF(JKOOBLENGDB<T> PBIGHEIFGJE, Action<T> PJDAFKMDDCG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x43D4060", Offset = "0x43D3460", VA = "0x1843D4060")]
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
	[Cpp2IlInjected.Address(RVA = "0x40173C0", Offset = "0x40167C0", VA = "0x1840173C0")]
	public FLEKKBCEDJE(bool BHKCGGKKMEL = false, bool LMOLHGOGEOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x43D26F0", Offset = "0x43D1AF0", VA = "0x1843D26F0")]
	public void CNDNDIPPKBE(T CHBEBLKFDBC, U IBMIGPFMPIN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x43D3FC0", Offset = "0x43D33C0", VA = "0x1843D3FC0")]
	public static FLEKKBCEDJE<T, U> FHOKCPBBLGF(FLEKKBCEDJE<T, U> PBIGHEIFGJE, Action<T, U> PJDAFKMDDCG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x43D4060", Offset = "0x43D3460", VA = "0x1843D4060")]
	public static FLEKKBCEDJE<T, U> NDOPAHAKCFH(FLEKKBCEDJE<T, U> PBIGHEIFGJE, Action<T, U> PJDAFKMDDCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class BEABIOOFOBA<T, U, V> : OKDNIJHAHKC<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x40173C0", Offset = "0x40167C0", VA = "0x1840173C0")]
	public BEABIOOFOBA(bool BHKCGGKKMEL = false, bool LMOLHGOGEOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5839B70", Offset = "0x5838F70", VA = "0x185839B70")]
	public void CNDNDIPPKBE(T CHBEBLKFDBC, U IBMIGPFMPIN, V EFDAGALIIFI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x43D3FC0", Offset = "0x43D33C0", VA = "0x1843D3FC0")]
	public static BEABIOOFOBA<T, U, V> FHOKCPBBLGF(BEABIOOFOBA<T, U, V> PBIGHEIFGJE, Action<T, U, V> PJDAFKMDDCG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x43D4060", Offset = "0x43D3460", VA = "0x1843D4060")]
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
	[Cpp2IlInjected.Address(RVA = "0x40173C0", Offset = "0x40167C0", VA = "0x1840173C0")]
	public MLLHJCGKFFC(bool BHKCGGKKMEL = false, bool LMOLHGOGEOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4DB4A30", Offset = "0x4DB3E30", VA = "0x184DB4A30")]
	public void CNDNDIPPKBE(T CHBEBLKFDBC, U IBMIGPFMPIN, V EFDAGALIIFI, W KDEAIPINGAN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x43D3FC0", Offset = "0x43D33C0", VA = "0x1843D3FC0")]
	public static MLLHJCGKFFC<T, U, V, W> FHOKCPBBLGF(MLLHJCGKFFC<T, U, V, W> PBIGHEIFGJE, Action<T, U, V, W> PJDAFKMDDCG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x43D4060", Offset = "0x43D3460", VA = "0x1843D4060")]
	public static MLLHJCGKFFC<T, U, V, W> NDOPAHAKCFH(MLLHJCGKFFC<T, U, V, W> PBIGHEIFGJE, Action<T, U, V, W> PJDAFKMDDCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class ALDIKDJKADD<T, U, V, W, X> : OKDNIJHAHKC<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x40173C0", Offset = "0x40167C0", VA = "0x1840173C0")]
	public ALDIKDJKADD(bool BHKCGGKKMEL = false, bool LMOLHGOGEOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x487D860", Offset = "0x487CC60", VA = "0x18487D860")]
	public void CNDNDIPPKBE(T CHBEBLKFDBC, U IBMIGPFMPIN, V EFDAGALIIFI, W KDEAIPINGAN, X IKAEODCKAIP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x43D3FC0", Offset = "0x43D33C0", VA = "0x1843D3FC0")]
	public static ALDIKDJKADD<T, U, V, W, X> FHOKCPBBLGF(ALDIKDJKADD<T, U, V, W, X> PBIGHEIFGJE, Action<T, U, V, W, X> PJDAFKMDDCG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x43D4060", Offset = "0x43D3460", VA = "0x1843D4060")]
	public static ALDIKDJKADD<T, U, V, W, X> NDOPAHAKCFH(ALDIKDJKADD<T, U, V, W, X> PBIGHEIFGJE, Action<T, U, V, W, X> PJDAFKMDDCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class IJBLMEFEJGB<T, U, V, W, X, Y> : OKDNIJHAHKC<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x40173C0", Offset = "0x40167C0", VA = "0x1840173C0")]
	public IJBLMEFEJGB(bool BHKCGGKKMEL = false, bool LMOLHGOGEOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x47214C0", Offset = "0x47208C0", VA = "0x1847214C0")]
	public void CNDNDIPPKBE(T CHBEBLKFDBC, U IBMIGPFMPIN, V EFDAGALIIFI, W KDEAIPINGAN, X IKAEODCKAIP, Y ACCJFOPIMAB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x43D3FC0", Offset = "0x43D33C0", VA = "0x1843D3FC0")]
	public static IJBLMEFEJGB<T, U, V, W, X, Y> FHOKCPBBLGF(IJBLMEFEJGB<T, U, V, W, X, Y> PBIGHEIFGJE, Action<T, U, V, W, X, Y> PJDAFKMDDCG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x43D4060", Offset = "0x43D3460", VA = "0x1843D4060")]
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
		[Cpp2IlInjected.Address(RVA = "0x5848120", Offset = "0x5847520", VA = "0x185848120")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int JLPIJPCEGAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x94D460", Offset = "0x94C860", VA = "0x18094D460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5848B40", Offset = "0x5847F40", VA = "0x185848B40")]
	public BJPHJHJBNAD(int AIOPAOGKJFL, [Optional] HNFGOLPBJLN<TKey, TVal>.KAMLOIPNHBD? FHBIANPBGPB, [Optional] IEqualityComparer<TKey>? OLLCJFOMGIM, [Optional] HNFGOLPBJLN<TKey, TVal>.KGEALBHDJCD? ICBKKFJOOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5847DC0", Offset = "0x58471C0", VA = "0x185847DC0")]
	public void IONEAPKBBFI(TKey LKMGECEEGEE, TVal KBGCCIOIGBD, bool EECKCCHGJIB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x58488A0", Offset = "0x5847CA0", VA = "0x1858488A0")]
	public bool PEIECAELMKB(TKey LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5847A00", Offset = "0x5846E00", VA = "0x185847A00")]
	public bool GMJNAAAPBAP(TKey MHOMJGNFGGL, [Out] TVal KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5847B00", Offset = "0x5846F00", VA = "0x185847B00")]
	private void IGMJCNIAIMB(TKey LKMGECEEGEE, TVal KBGCCIOIGBD, int IBMHAIHIDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5847850", Offset = "0x5846C50", VA = "0x185847850")]
	public bool DIOGKAFPEHP(TKey LKMGECEEGEE, TVal KBGCCIOIGBD, bool EECKCCHGJIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5848170", Offset = "0x5847570", VA = "0x185848170")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5848220", Offset = "0x5847620", VA = "0x185848220")]
	private void KMLDCOIGHGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5848A00", Offset = "0x5847E00", VA = "0x185848A00")]
	private bool POIOBMEJEDO(TKey LKMGECEEGEE, IAIFEKOPBMN CEGFAIJENKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5848780", Offset = "0x5847B80", VA = "0x185848780")]
	private void LILIJALFMLI(TKey LKMGECEEGEE, TVal KBGCCIOIGBD, IAIFEKOPBMN CEGFAIJENKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5847FF0", Offset = "0x58473F0", VA = "0x185847FF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
	public AJMGOIICDMM(Action BKAIFAJPEJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x757BA70", Offset = "0x757AE70", VA = "0x18757BA70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x31423A0", Offset = "0x31417A0", VA = "0x1831423A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4A4B6D0", Offset = "0x4A4AAD0", VA = "0x184A4B6D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4AE11B0", Offset = "0x4AE05B0", VA = "0x184AE11B0")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long AFNDGLAJDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4AE14D0", Offset = "0x4AE08D0", VA = "0x184AE14D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool PMLNJMJFBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4AE0F40", Offset = "0x4AE0340", VA = "0x184AE0F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4AE1B40", Offset = "0x4AE0F40", VA = "0x184AE1B40")]
	public KPPCCEIEBJK(FLPGHFAEKPL<T> AJPMKOKJPLK, FLPGHFAEKPL<T> KNHCHOOEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4AE16E0", Offset = "0x4AE0AE0", VA = "0x184AE16E0")]
	public KPPCCEIEBJK(FLPGHFAEKPL<T> AJPMKOKJPLK, int EKDINNHMJFC, FLPGHFAEKPL<T> KNHCHOOEDON, int PHHAFJOKPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4AE1A90", Offset = "0x4AE0E90", VA = "0x184AE1A90")]
	private KPPCCEIEBJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4AE1000", Offset = "0x4AE0400", VA = "0x184AE1000", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4AE12B0", Offset = "0x4AE06B0", VA = "0x184AE12B0")]
	public T[] OMBEABDDNID()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4AE1090", Offset = "0x4AE0490", VA = "0x184AE1090")]
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
		[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0")]
		public static DDJIBKGDJKD FEOBEKOIKMG()
		{
			return default(DDJIBKGDJKD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x757BAB0", Offset = "0x757AEB0", VA = "0x18757BAB0")]
	public static string PECIFCLOODO(Type BMIPLDLMPCD, [Optional] string? LEDDGHAPBHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3B2BFB0", Offset = "0x3B2B3B0", VA = "0x183B2BFB0")]
	public static string? PECIFCLOODO<T>([Optional] string? LEDDGHAPBHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3B2BF30", Offset = "0x3B2B330", VA = "0x183B2BF30")]
	public static string? JFFJDACPDHD<T>([Optional] string? LPIPFPOBKGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0")]
	public static ANEFDAMIPJL BIBMBKHCCLP(string LEDDGHAPBHK, string? LPIPFPOBKGH)
	{
		return default(ANEFDAMIPJL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public NJJCKIOBCJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4E7C9C0", Offset = "0x4E7BDC0", VA = "0x184E7C9C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x757E340", Offset = "0x757D740", VA = "0x18757E340")]
	public static Dictionary<string, OEKJFHFPCFG> DPFDLDMELDD(Type IEJJAFNKCLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x35A7C90", Offset = "0x35A7090", VA = "0x1835A7C90")]
	public static Dictionary<string, OEKJFHFPCFG> DPFDLDMELDD<T>(Type IEJJAFNKCLI, IReadOnlyDictionary<T, string> KGFHFDOAJCH) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x35A84C0", Offset = "0x35A78C0", VA = "0x1835A84C0")]
	public static Dictionary<string, OEKJFHFPCFG> OOCAGHLCNOA<T>(List<T> MEPENPIKOFM) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x757E830", Offset = "0x757DC30", VA = "0x18757E830")]
	public static Dictionary<string, OEKJFHFPCFG> LGGDPILHKGK(Type IEJJAFNKCLI, ICOCONPPIFP AMLLLOEHOPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x757E670", Offset = "0x757DA70", VA = "0x18757E670")]
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
		[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x757F390", Offset = "0x757E790", VA = "0x18757F390")]
	protected PGAGFEIEKID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string BBCHEHFFEBG();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x757F270", Offset = "0x757E670", VA = "0x18757F270", Slot = "8")]
	public virtual string OMBHCHDNCGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x757EFD0", Offset = "0x757E3D0", VA = "0x18757EFD0", Slot = "9")]
	public void KMBGPGBKKNJ(StringBuilder GLHMABGINLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x757EF70", Offset = "0x757E370", VA = "0x18757EF70", Slot = "10")]
	public void EJIDEJFAJAA(StringBuilder GLHMABGINLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x757ECF0", Offset = "0x757E0F0", VA = "0x18757ECF0", Slot = "11")]
	public void BNNABBGBGAN(StringBuilder GLHMABGINLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x757EE10", Offset = "0x757E210", VA = "0x18757EE10", Slot = "12")]
	public void BNNNAAFAJEJ(StringBuilder GLHMABGINLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x757F2F0", Offset = "0x757E6F0", VA = "0x18757F2F0")]
	public static void OPMCMHCAMBF(StringBuilder GLHMABGINLA, string HJLOFBIEILC, string HEDPNICLHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x66294B0", Offset = "0x66288B0", VA = "0x1866294B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OMPJBHAAOOD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x757EC70", Offset = "0x757E070", VA = "0x18757EC70")]
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
	[Cpp2IlInjected.Address(RVA = "0x43C3D80", Offset = "0x43C3180", VA = "0x1843C3D80")]
	private FFGKBNPLHNJ([In] TErr AKKACNNBJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x43C3CB0", Offset = "0x43C30B0", VA = "0x1843C3CB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool JINMOLLFOJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool LFCDANKCEAM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long AFNDGLAJDJM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x757C720", Offset = "0x757BB20", VA = "0x18757C720", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long NAMOIOBECGF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x757C790", Offset = "0x757BB90", VA = "0x18757C790", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x757C800", Offset = "0x757BC00", VA = "0x18757C800", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x757C6B0", Offset = "0x757BAB0", VA = "0x18757C6B0")]
	public FGKPCFBIPPO(HashAlgorithm EAICOEKICHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x757C4D0", Offset = "0x757B8D0", VA = "0x18757C4D0", Slot = "35")]
	public override int Read(byte[] DEEIKCMDENK, int FDJGEFDKBBO, int BBEJNKBNMID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x757C680", Offset = "0x757BA80", VA = "0x18757C680", Slot = "38")]
	public override void Write(byte[] DEEIKCMDENK, int FDJGEFDKBBO, int BBEJNKBNMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x757C570", Offset = "0x757B970", VA = "0x18757C570", Slot = "33")]
	public override long Seek(long FDJGEFDKBBO, SeekOrigin IGFMIOBPFAL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x757C600", Offset = "0x757BA00", VA = "0x18757C600", Slot = "34")]
	public override void SetLength(long KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x757C3F0", Offset = "0x757B7F0", VA = "0x18757C3F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xC14E20", Offset = "0xC14220", VA = "0x180C14E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x43DB380", Offset = "0x43DA780", VA = "0x1843DB380")]
	private static FLPGHFAEKPL<T> PCMFHPOLEOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x43D9D70", Offset = "0x43D9170", VA = "0x1843D9D70")]
	private static void BGLIIJJLFBE(FLPGHFAEKPL<T> FOCJIGDCLCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x43DBAE0", Offset = "0x43DAEE0", VA = "0x1843DBAE0")]
	private FLPGHFAEKPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x43DAFE0", Offset = "0x43DA3E0", VA = "0x1843DAFE0")]
	public static FLPGHFAEKPL<T> OILMBKHFGKP(ReadOnlyMemory<T> EEFIHHOPAFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x43DADD0", Offset = "0x43DA1D0", VA = "0x1843DADD0")]
	public static FLPGHFAEKPL<T> OILMBKHFGKP(IMemoryOwner<T> DPLGOGMKOHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x43DAB40", Offset = "0x43D9F40", VA = "0x1843DAB40")]
	public static void GKDGDJIDFBA(FLPGHFAEKPL<T> AJPMKOKJPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x43DA8C0", Offset = "0x43D9CC0", VA = "0x1843DA8C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x43DA530", Offset = "0x43D9930", VA = "0x1843DA530")]
	public FLPGHFAEKPL<T> CGDLHICEKJD(IMemoryOwner<T> DPLGOGMKOHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x43DA330", Offset = "0x43D9730", VA = "0x1843DA330")]
	private void BMJKGDBKDCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x43DAC80", Offset = "0x43DA080", VA = "0x1843DAC80")]
	private FLPGHFAEKPL<T> OHANMAEMDNB(FLPGHFAEKPL<T> FOCJIGDCLCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class KPMECFAFOHI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x757D510", Offset = "0x757C910", VA = "0x18757D510")]
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
	[Cpp2IlInjected.Address(RVA = "0x5A31FE0", Offset = "0x5A313E0", VA = "0x185A31FE0")]
	private CCLKNLGOPLJ([In] TOk GDEOOLPKMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x473E940", Offset = "0x473DD40", VA = "0x18473E940")]
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
		[Cpp2IlInjected.Address(RVA = "0x4984620", Offset = "0x4983A20", VA = "0x184984620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool INIBGAHJAEL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4984D80", Offset = "0x4984180", VA = "0x184984D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4989DF0", Offset = "0x49891F0", VA = "0x184989DF0")]
	internal JOFBNNGKBOO([In] TErr AKKACNNBJFA, [In] TOk GDEOOLPKMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4985B10", Offset = "0x4984F10", VA = "0x184985B10")]
	public static JOFBNNGKBOO<TOk, TErr> NNNKFDKOBLF([In] TErr AKKACNNBJFA)
	{
		return default(JOFBNNGKBOO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4986660", Offset = "0x4985A60", VA = "0x184986660")]
	public static JOFBNNGKBOO<TOk, TErr> OGGMMIPJEAO([In] TOk GDEOOLPKMEP)
	{
		return default(JOFBNNGKBOO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3559730", Offset = "0x3558B30", VA = "0x183559730")]
	public JOFBNNGKBOO<TOk?, UErr?> FKAOBLMEMHF<UErr>()
	{
		return default(JOFBNNGKBOO<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x35594F0", Offset = "0x35588F0", VA = "0x1835594F0")]
	public JOFBNNGKBOO<UOk?, TErr?> CGCHBMGPIKF<UOk>()
	{
		return default(JOFBNNGKBOO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x355A500", Offset = "0x3559900", VA = "0x18355A500")]
	public JOFBNNGKBOO<UOk?, TErr?> GFFNKFPGMMK<UOk>()
	{
		return default(JOFBNNGKBOO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x355B210", Offset = "0x355A610", VA = "0x18355B210")]
	public JOFBNNGKBOO<TOk?, UErr?> IHJFECBENHN<UErr>()
	{
		return default(JOFBNNGKBOO<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4985330", Offset = "0x4984730", VA = "0x184985330")]
	public JOFBNNGKBOO<IDMEFNAINAN, TErr> LFIPIKBNHGK()
	{
		return default(JOFBNNGKBOO<IDMEFNAINAN, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4982070", Offset = "0x4981470", VA = "0x184982070")]
	public static bool BFIJCNNIIMH([In] JOFBNNGKBOO<TOk, TErr> HJGDMEAJFEI, [In] JOFBNNGKBOO<TOk, TErr> OHAJMMPIMHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4982330", Offset = "0x4981730", VA = "0x184982330", Slot = "4")]
	public bool Equals(JOFBNNGKBOO<TOk, TErr> OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x49828E0", Offset = "0x4981CE0", VA = "0x1849828E0", Slot = "0")]
	public override bool Equals(object OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4983B60", Offset = "0x4982F60", VA = "0x184983B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4988EB0", Offset = "0x49882B0", VA = "0x184988EB0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FF7490", Offset = "0x3FF6890", VA = "0x183FF7490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3FF7AD0", Offset = "0x3FF6ED0", VA = "0x183FF7AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x35C93A0", Offset = "0x35C87A0", VA = "0x1835C93A0")]
	public static JOFBNNGKBOO<TOk?, TErr?> MHEEBIIDDPF<TOk, TErr>([In] this JOFBNNGKBOO<TOk, TErr> JDCFMPOHCEA, [In] TOk GDEOOLPKMEP)
	{
		return default(JOFBNNGKBOO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x35CB730", Offset = "0x35CAB30", VA = "0x1835CB730")]
	public static JOFBNNGKBOO<IDMEFNAINAN, TErr?> MHEEBIIDDPF<TErr>([In] this JOFBNNGKBOO<IDMEFNAINAN, TErr> JDCFMPOHCEA)
	{
		return default(JOFBNNGKBOO<IDMEFNAINAN, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x35C93A0", Offset = "0x35C87A0", VA = "0x1835C93A0")]
	public static JOFBNNGKBOO<TOk?, TErr?> BIOOMJJMHFI<TOk, TErr>([In] this JOFBNNGKBOO<TOk, TErr> JDCFMPOHCEA, [In] TErr AKKACNNBJFA)
	{
		return default(JOFBNNGKBOO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x35CB180", Offset = "0x35CA580", VA = "0x1835CB180")]
	public static TOk? MFEAOMGHBJI<TOk, TErr>([In] this JOFBNNGKBOO<TOk, TErr> JDCFMPOHCEA)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x35CC030", Offset = "0x35CB430", VA = "0x1835CC030")]
	[AsyncStateMachine(typeof(ECJBNFBLLJG<, >))]
	public static Task<TOk?>? PLJJOOJEKIE<TOk, TErr>(this Task<JOFBNNGKBOO<TOk, TErr>> JDCFMPOHCEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x35C9820", Offset = "0x35C8C20", VA = "0x1835C9820")]
	public static TErr? BPJIAEBFIDB<TErr, TOk>([In] this JOFBNNGKBOO<TOk, TErr> JDCFMPOHCEA)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x35CA210", Offset = "0x35C9610", VA = "0x1835CA210")]
	public static bool IHEGKFLKMDA<TOk, TErr, UErr, UOk>([In] this JOFBNNGKBOO<TOk, TErr> JDCFMPOHCEA, [Out] JOFBNNGKBOO<UOk, UErr> PNDMAMKJKEH) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x35C9070", Offset = "0x35C8470", VA = "0x1835C9070")]
	public static bool AKFJDPMBBAA<TOk, TErr>([In] this JOFBNNGKBOO<TOk, TErr> JDCFMPOHCEA, [Out] TOk GDEOOLPKMEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x35C9C40", Offset = "0x35C9040", VA = "0x1835C9C40")]
	public static bool ENPFMMACOFC<TOk, TErr>([In] this JOFBNNGKBOO<TOk, TErr> JDCFMPOHCEA, [Out][NotNullWhen(true)] TErr AKKACNNBJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x35C9F20", Offset = "0x35C9320", VA = "0x1835C9F20")]
	public static bool GJFGFKAIEBF<TOk, TErr>([In] this JOFBNNGKBOO<TOk, TErr> JDCFMPOHCEA, [Out][NotNullWhen(true)] TOk GDEOOLPKMEP, [Out][NotNullWhen(false)] TErr AKKACNNBJFA) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x35C92A0", Offset = "0x35C86A0", VA = "0x1835C92A0")]
	public static bool BGJCBIKMFNK<TOk, TErr>([In] this JOFBNNGKBOO<TOk, TErr> JDCFMPOHCEA, [Out][NotNullWhen(true)] TOk GDEOOLPKMEP, [Out] JOFBNNGKBOO<TOk, TErr> PNDMAMKJKEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x35C9FA0", Offset = "0x35C93A0", VA = "0x1835C9FA0")]
	public static bool IHEGKFLKMDA<TOk, TErr, UErr, UOk>([In] this JOFBNNGKBOO<TOk, TErr> JDCFMPOHCEA, [Out][NotNullWhen(true)] TOk GDEOOLPKMEP, [Out] JOFBNNGKBOO<UOk, UErr> PNDMAMKJKEH) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x35CB8B0", Offset = "0x35CACB0", VA = "0x1835CB8B0")]
	public static bool MIMNILCJEOL<TOk, TErr>([In] this JOFBNNGKBOO<TOk, TErr> JDCFMPOHCEA, [Out][NotNullWhen(true)] TOk GDEOOLPKMEP, [Out] JOFBNNGKBOO<IDMEFNAINAN, TErr> PNDMAMKJKEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x35C8870", Offset = "0x35C7C70", VA = "0x1835C8870")]
	public static JOFBNNGKBOO<UOk, UErr> AAOOPLLBCEO<UOk, UErr, TOk, TErr>([In] this JOFBNNGKBOO<TOk, TErr> JDCFMPOHCEA, [In] JOFBNNGKBOO<UOk, UErr> MEBAFDHEDIN) where TOk : UOk where TErr : UErr
	{
		return default(JOFBNNGKBOO<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x35CBC60", Offset = "0x35CB060", VA = "0x1835CBC60")]
	public static JOFBNNGKBOO<TOk?[]?, TErr?> MPCANEAFNAE<TOk, TErr>(this IEnumerable<JOFBNNGKBOO<TOk, TErr>> JDCFMPOHCEA)
	{
		return default(JOFBNNGKBOO<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x35C9570", Offset = "0x35C8970", VA = "0x1835C9570")]
	public static JOFBNNGKBOO<UOk?, TErr?> BMBDKKIJGOB<UOk, TErr, TOk>([In] this JOFBNNGKBOO<TOk, TErr> JDCFMPOHCEA, Func<TOk, UOk> KJEGPMHGGJD)
	{
		return default(JOFBNNGKBOO<UOk, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class PKHOHICPHJG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3994560", Offset = "0x3993960", VA = "0x183994560")]
	public static JOFBNNGKBOO<TOk, T> MHEEBIIDDPF<TOk>([In] TOk GDEOOLPKMEP) where TOk : notnull
	{
		return default(JOFBNNGKBOO<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x50AAB00", Offset = "0x50A9F00", VA = "0x1850AAB00")]
	public static JOFBNNGKBOO<IDMEFNAINAN, T> MHEEBIIDDPF()
	{
		return default(JOFBNNGKBOO<IDMEFNAINAN, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3994600", Offset = "0x3993A00", VA = "0x183994600")]
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
	[Cpp2IlInjected.Address(RVA = "0x44F5320", Offset = "0x44F4720", VA = "0x1844F5320")]
	public static GFLLPPOBLJO<TKey, TValue> FEOBEKOIKMG(string BPPCEJGCMKA)
	{
		return default(GFLLPPOBLJO<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x44F54E0", Offset = "0x44F48E0", VA = "0x1844F54E0")]
	internal GFLLPPOBLJO(Dictionary<TKey, TValue> KBGCCIOIGBD, CDPICKGDCBJ IJKHLFDGEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x44F5440", Offset = "0x44F4840", VA = "0x1844F5440")]
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
	[Cpp2IlInjected.Address(RVA = "0x273BDD0", Offset = "0x273B1D0", VA = "0x18273BDD0")]
	internal LLHFDIFLCJD(Dictionary<TKey, TValue> KBGCCIOIGBD, PDJIAGLJBDA NBDLEKHCPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4A5A5C0", Offset = "0x4A599C0", VA = "0x184A5A5C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x44F5320", Offset = "0x44F4720", VA = "0x1844F5320")]
	public static AKNJELNHKNO<T> FEOBEKOIKMG(string BPPCEJGCMKA)
	{
		return default(AKNJELNHKNO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x44F54E0", Offset = "0x44F48E0", VA = "0x1844F54E0")]
	internal AKNJELNHKNO(HashSet<T> KBGCCIOIGBD, CDPICKGDCBJ IJKHLFDGEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x44F5440", Offset = "0x44F4840", VA = "0x1844F5440")]
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
	[Cpp2IlInjected.Address(RVA = "0x273BDD0", Offset = "0x273B1D0", VA = "0x18273BDD0")]
	internal OOBMAIJJEEH(HashSet<T> KBGCCIOIGBD, PDJIAGLJBDA NBDLEKHCPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4A5A5C0", Offset = "0x4A599C0", VA = "0x184A5A5C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x44F5320", Offset = "0x44F4720", VA = "0x1844F5320")]
	public static BKGFCDJEEFP<T> FEOBEKOIKMG(string BPPCEJGCMKA)
	{
		return default(BKGFCDJEEFP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x44F54E0", Offset = "0x44F48E0", VA = "0x1844F54E0")]
	internal BKGFCDJEEFP(Stack<T> KBGCCIOIGBD, CDPICKGDCBJ IJKHLFDGEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x44F5440", Offset = "0x44F4840", VA = "0x1844F5440")]
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
	[Cpp2IlInjected.Address(RVA = "0x273BDD0", Offset = "0x273B1D0", VA = "0x18273BDD0")]
	internal KIDLOOCDLAG(Stack<T> KBGCCIOIGBD, PDJIAGLJBDA NBDLEKHCPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4A5A5C0", Offset = "0x4A599C0", VA = "0x184A5A5C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2440CC0", Offset = "0x24400C0", VA = "0x182440CC0")]
		public GLOGNLDMOJP(DIKMIHOBJDI<T> AAMBBOLAGCO, int KJINOKGIMIH, bool KCOFOLKLMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x450C6D0", Offset = "0x450BAD0", VA = "0x18450C6D0")]
		public DIKMIHOBJDI<T>.JLFLMKCAMOD BNIMLGJMJBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x450C7C0", Offset = "0x450BBC0", VA = "0x18450C7C0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x450C7C0", Offset = "0x450BBC0", VA = "0x18450C7C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x497C4B0", Offset = "0x497B8B0", VA = "0x18497C4B0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x497C5A0", Offset = "0x497B9A0", VA = "0x18497C5A0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x497C650", Offset = "0x497BA50", VA = "0x18497C650", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x497CAF0", Offset = "0x497BEF0", VA = "0x18497CAF0")]
		public JLFLMKCAMOD(DIKMIHOBJDI<T> AAMBBOLAGCO, int KJINOKGIMIH, bool KCOFOLKLMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x497C4F0", Offset = "0x497B8F0", VA = "0x18497C4F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x497C580", Offset = "0x497B980", VA = "0x18497C580", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public PEHEFELEDOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x50808E0", Offset = "0x507FCE0", VA = "0x1850808E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x62AEDB0", Offset = "0x62AE1B0", VA = "0x1862AEDB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T FJMLFGNPDDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x43A08E0", Offset = "0x439FCE0", VA = "0x1843A08E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T ELELLAAAAFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x62AF090", Offset = "0x62AE490", VA = "0x1862AF090")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x62AEF60", Offset = "0x62AE360", VA = "0x1862AEF60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int AFNDGLAJDJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x22AEEB0", Offset = "0x22AE2B0", VA = "0x1822AEEB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x18307D0", Offset = "0x182FBD0", VA = "0x1818307D0")]
	private static int MJGCPNEONAH(int EAHKFAJBNDN, int GIGAFKHMOHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x62AF3D0", Offset = "0x62AE7D0", VA = "0x1862AF3D0")]
	public DIKMIHOBJDI(int IBMHAIHIDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x62AF0D0", Offset = "0x62AE4D0", VA = "0x1862AF0D0")]
	public DIKMIHOBJDI(int IBMHAIHIDJJ, Func<T> JHOFCDDHONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x62AF590", Offset = "0x62AE990", VA = "0x1862AF590")]
	public DIKMIHOBJDI(T[] FDMJAFAEFBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x62AED80", Offset = "0x62AE180", VA = "0x1862AED80")]
	public void EGPFEFPPHFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x62AEFD0", Offset = "0x62AE3D0", VA = "0x1862AEFD0")]
	public IEnumerable<T> LFFJENBFKPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x62AECE0", Offset = "0x62AE0E0", VA = "0x1862AECE0")]
	public DIKMIHOBJDI<T>.JLFLMKCAMOD BNIMLGJMJBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4457DB0", Offset = "0x44571B0", VA = "0x184457DB0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4457DB0", Offset = "0x44571B0", VA = "0x184457DB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class IGDCGLCOHBA
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x33C1380", Offset = "0x33C0780", VA = "0x1833C1380")]
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
			[Cpp2IlInjected.Address(RVA = "0x757FDD0", Offset = "0x757F1D0", VA = "0x18757FDD0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x757FD90", Offset = "0x757F190", VA = "0x18757FD90")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x757FDB0", Offset = "0x757F1B0", VA = "0x18757FDB0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x757FDF0", Offset = "0x757F1F0", VA = "0x18757FDF0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x757FD70", Offset = "0x757F170", VA = "0x18757FD70")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x254B960", Offset = "0x254AD60", VA = "0x18254B960")]
		public RRColor(float FBIKENCMLKN, float OOGGGDHAHHD, float PPCFCAEIJMM, float AMGCKABOOPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x744F9B0", Offset = "0x744EDB0", VA = "0x18744F9B0", Slot = "4")]
		public bool Equals(RRColor OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x757F9B0", Offset = "0x757EDB0", VA = "0x18757F9B0", Slot = "0")]
		public override bool Equals(object OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x757FAB0", Offset = "0x757EEB0", VA = "0x18757FAB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x757FB30", Offset = "0x757EF30", VA = "0x18757FB30", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x757F950", Offset = "0x757ED50", VA = "0x18757F950")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x757F8F0", Offset = "0x757ECF0", VA = "0x18757F8F0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x757F920", Offset = "0x757ED20", VA = "0x18757F920")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x757F980", Offset = "0x757ED80", VA = "0x18757F980")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x757F8C0", Offset = "0x757ECC0", VA = "0x18757F8C0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5681930", Offset = "0x5680D30", VA = "0x185681930")]
		public RRColor32(byte FBIKENCMLKN, byte OOGGGDHAHHD, byte PPCFCAEIJMM, byte AMGCKABOOPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1ED92D0", Offset = "0x1ED86D0", VA = "0x181ED92D0", Slot = "4")]
		public bool Equals(RRColor32 OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x757F400", Offset = "0x757E800", VA = "0x18757F400", Slot = "0")]
		public override bool Equals(object OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x10DA510", Offset = "0x10D9910", VA = "0x1810DA510", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x757F500", Offset = "0x757E900", VA = "0x18757F500")]
		public static RRColor32 HEGJABMHLEC(RRColor OPLPABIPAJI)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x757F490", Offset = "0x757E890", VA = "0x18757F490")]
		public static RRColor HEGJABMHLEC(RRColor32 OPLPABIPAJI)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x757F650", Offset = "0x757EA50", VA = "0x18757F650", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3FFDBD0", Offset = "0x3FFCFD0", VA = "0x183FFDBD0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3FFDBA0", Offset = "0x3FFCFA0", VA = "0x183FFDBA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xBCD900", Offset = "0xBCCD00", VA = "0x180BCD900")]
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
		[Cpp2IlInjected.Address(RVA = "0x462B910", Offset = "0x462AD10", VA = "0x18462B910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x40276A0", Offset = "0x4026AA0", VA = "0x1840276A0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5A3ABB0", Offset = "0x5A39FB0", VA = "0x185A3ABB0")]
	public CDPFHKGDHIF([In] T GINGHILKALC, int CAAIDOKNPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5A3AA20", Offset = "0x5A39E20", VA = "0x185A3AA20")]
	public CDPFHKGDHIF([In] T GINGHILKALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5A3A8E0", Offset = "0x5A39CE0", VA = "0x185A3A8E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5A3A920", Offset = "0x5A39D20", VA = "0x185A3A920")]
	public EFJPJDEJIDP FIJKFMLOJAJ()
	{
		return default(EFJPJDEJIDP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5A3A6A0", Offset = "0x5A39AA0", VA = "0x185A3A6A0")]
	[AsyncStateMachine(typeof(CDPFHKGDHIF<>.HLKNBDAMKIP))]
	public Task<CDPFHKGDHIF<T>.EFJPJDEJIDP> DOLLKHPEHLP(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5A3A960", Offset = "0x5A39D60", VA = "0x185A3A960")]
	public void PINMHAJAJEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class ELFCONLKLEG
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x757C250", Offset = "0x757B650", VA = "0x18757C250")]
	public static CDPFHKGDHIF<IDMEFNAINAN> FEOBEKOIKMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3152A20", Offset = "0x3151E20", VA = "0x183152A20")]
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
			[Cpp2IlInjected.Address(RVA = "0x4722190", Offset = "0x4721590", VA = "0x184722190")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4FAD040", Offset = "0x4FAC440", VA = "0x184FAD040", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xBCD900", Offset = "0xBCCD00", VA = "0x180BCD900")]
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
			[Cpp2IlInjected.Address(RVA = "0x4722190", Offset = "0x4721590", VA = "0x184722190")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x47220A0", Offset = "0x47214A0", VA = "0x1847220A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xBCD900", Offset = "0xBCCD00", VA = "0x180BCD900")]
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
		[Cpp2IlInjected.Address(RVA = "0x4A3CDF0", Offset = "0x4A3C1F0", VA = "0x184A3CDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x40276A0", Offset = "0x4026AA0", VA = "0x1840276A0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3FF6ED0", Offset = "0x3FF62D0", VA = "0x183FF6ED0")]
	internal EBNLIGPPPHL(CDPFHKGDHIF<int> MKCBPPBNBLJ, CDPFHKGDHIF<IDMEFNAINAN> FHGOGIIPIDD, CDPFHKGDHIF<IDMEFNAINAN> GONMONPLHLP, [In] T GINGHILKALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3FF5FD0", Offset = "0x3FF53D0", VA = "0x183FF5FD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3FF6510", Offset = "0x3FF5910", VA = "0x183FF6510")]
	public OIJNKPCEEJE ECCIGIDPGHK()
	{
		return default(OIJNKPCEEJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3FF6CB0", Offset = "0x3FF60B0", VA = "0x183FF6CB0")]
	public IJGGMPFBFGE KAOFGLNGLFA()
	{
		return default(IJGGMPFBFGE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3FF6970", Offset = "0x3FF5D70", VA = "0x183FF6970")]
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
	[Cpp2IlInjected.Address(RVA = "0x757B9A0", Offset = "0x757ADA0", VA = "0x18757B9A0")]
	public static EBNLIGPPPHL<IDMEFNAINAN> FEOBEKOIKMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3B2A7F0", Offset = "0x3B29BF0", VA = "0x183B2A7F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
	public override string BBCHEHFFEBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4946290", Offset = "0x4945690", VA = "0x184946290")]
	internal JCAFAJJIGLP(string MIALAMIFNLM, [In] TData GIDGOODJFLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class OGOJENGNMJK
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x757EBF0", Offset = "0x757DFF0", VA = "0x18757EBF0")]
	public static JCAFAJJIGLP<IDMEFNAINAN> FEOBEKOIKMG(string MIALAMIFNLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x31423A0", Offset = "0x31417A0", VA = "0x1831423A0")]
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
	[Cpp2IlInjected.Address(RVA = "0xCA40C0", Offset = "0xCA34C0", VA = "0x180CA40C0")]
	private CDPICKGDCBJ(bool BKOLBDFINND, string OKLKBKFNLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x757BD50", Offset = "0x757B150", VA = "0x18757BD50")]
	public static CDPICKGDCBJ FEOBEKOIKMG(string OKLKBKFNLMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x757BDC0", Offset = "0x757B1C0", VA = "0x18757BDC0")]
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
	[Cpp2IlInjected.Address(RVA = "0xBCD900", Offset = "0xBCCD00", VA = "0x180BCD900")]
	internal PDJIAGLJBDA(CDPICKGDCBJ BPPCEJGCMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x757ECD0", Offset = "0x757E0D0", VA = "0x18757ECD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public FKIMABAKLCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x43CEFB0", Offset = "0x43CE3B0", VA = "0x1843CEFB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4B47FC0", Offset = "0x4B473C0", VA = "0x184B47FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool BEENACDECBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4B47BF0", Offset = "0x4B46FF0", VA = "0x184B47BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x94D480", Offset = "0x94C880", VA = "0x18094D480")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x94D450", Offset = "0x94C850", VA = "0x18094D450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4B47C40", Offset = "0x4B47040", VA = "0x184B47C40")]
	public bool HBHDBABAKDP(T LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4B47E50", Offset = "0x4B47250", VA = "0x184B47E50")]
	public bool OCDDHDAHAOD(T LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4B47E00", Offset = "0x4B47200", VA = "0x184B47E00")]
	public bool HBIAGPPOPJF(T LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4B47B10", Offset = "0x4B46F10", VA = "0x184B47B10")]
	public void CBKJNIKMAPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4B48000", Offset = "0x4B47400", VA = "0x184B48000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public GLDIEAEPCID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x757CBA0", Offset = "0x757BFA0", VA = "0x18757CBA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x757CF50", Offset = "0x757C350", VA = "0x18757CF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool BEENACDECBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x757CD60", Offset = "0x757C160", VA = "0x18757CD60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x94D480", Offset = "0x94C880", VA = "0x18094D480")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x94D450", Offset = "0x94C850", VA = "0x18094D450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x757CD70", Offset = "0x757C170", VA = "0x18757CD70")]
	public bool HBHDBABAKDP(object LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x757CEB0", Offset = "0x757C2B0", VA = "0x18757CEB0")]
	public bool OCDDHDAHAOD(object LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x757CE50", Offset = "0x757C250", VA = "0x18757CE50")]
	public bool HBIAGPPOPJF(object LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x757CCF0", Offset = "0x757C0F0", VA = "0x18757CCF0")]
	public void CBKJNIKMAPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x757CFE0", Offset = "0x757C3E0", VA = "0x18757CFE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x16FB170", Offset = "0x16FA570", VA = "0x1816FB170", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x16F9CF0", Offset = "0x16F90F0", VA = "0x1816F9CF0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public object? INGPMOMHGFN
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x94DBC0", Offset = "0x94CFC0", VA = "0x18094DBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x94D470", Offset = "0x94C870", VA = "0x18094D470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool EBCBNNJAAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x43D7BA0", Offset = "0x43D6FA0", VA = "0x1843D7BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x49790A0", Offset = "0x49784A0", VA = "0x1849790A0")]
	public bool FJAEOODAFCM(T KBGCCIOIGBD, object LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x43D7C00", Offset = "0x43D7000", VA = "0x1843D7C00")]
	public bool OANKGFLJIAB(object LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x43D75B0", Offset = "0x43D69B0", VA = "0x1843D75B0")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x49794A0", Offset = "0x49788A0", VA = "0x1849794A0")]
	public bool GMJNAAAPBAP(object LAAJFAFNFCN, [Out] T KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4979A60", Offset = "0x4978E60", VA = "0x184979A60")]
	[OPICOFBLENP("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool MFBCGPJFHLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x497AEF0", Offset = "0x497A2F0", VA = "0x18497AEF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x757D470", Offset = "0x757C870", VA = "0x18757D470", Slot = "4")]
		public bool Equals(FDINGGDGHDL IKAEODCKAIP, FDINGGDGHDL ACCJFOPIMAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6819300", Offset = "0x6818700", VA = "0x186819300", Slot = "5")]
		public int GetHashCode(FDINGGDGHDL GMFKPONAANG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public JNJHPIHDEND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x757BCE0", Offset = "0x757B0E0", VA = "0x18757BCE0")]
	public BOGJHKLDLEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x757BAF0", Offset = "0x757AEF0", VA = "0x18757BAF0", Slot = "4")]
	public override bool HBHDBABAKDP(FDINGGDGHDL LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x757BC30", Offset = "0x757B030", VA = "0x18757BC30", Slot = "5")]
	public override bool OCDDHDAHAOD(FDINGGDGHDL LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x757BBA0", Offset = "0x757AFA0", VA = "0x18757BBA0")]
	private static void IAFNBNDMFPE(FDINGGDGHDL LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x15FC100", Offset = "0x15FB500", VA = "0x1815FC100", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
	public FDINGGDGHDL(string FEHAOBOMBFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x757C2C0", Offset = "0x757B6C0", VA = "0x18757C2C0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x4740920", Offset = "0x473FD20", VA = "0x184740920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA836D0", Offset = "0xA82AD0", VA = "0x180A836D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xB39280", Offset = "0xB38680", VA = "0x180B39280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x47415D0", Offset = "0x47409D0", VA = "0x1847415D0")]
	public IPJCPJBLOAM(IEqualityComparer<T> BLMEGMHOING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x4740960", Offset = "0x473FD60", VA = "0x184740960", Slot = "4")]
	public virtual bool HBHDBABAKDP(T LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x4740E70", Offset = "0x4740270", VA = "0x184740E70", Slot = "5")]
	public virtual bool OCDDHDAHAOD(T LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x4740840", Offset = "0x473FC40", VA = "0x184740840")]
	public void CBKJNIKMAPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x47412D0", Offset = "0x47406D0", VA = "0x1847412D0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x446C0D0", Offset = "0x446B4D0", VA = "0x18446C0D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x446C600", Offset = "0x446BA00", VA = "0x18446C600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x446C1F0", Offset = "0x446B5F0", VA = "0x18446C1F0")]
	public void HBHDBABAKDP(T LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x446C460", Offset = "0x446B860", VA = "0x18446C460")]
	public void OCDDHDAHAOD(T LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x446C090", Offset = "0x446B490", VA = "0x18446C090")]
	public void CBKJNIKMAPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x446C7A0", Offset = "0x446BBA0", VA = "0x18446C7A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public GAHHCHCOBKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal static class OMDNPHOHPAC
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x33909F0", Offset = "0x338FDF0", VA = "0x1833909F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x94FCE0", Offset = "0x94F0E0", VA = "0x18094FCE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x94FCA0", Offset = "0x94F0A0", VA = "0x18094FCA0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private FDINGGDGHDL? INGPMOMHGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x94B7E0", Offset = "0x94ABE0", VA = "0x18094B7E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool EBCBNNJAAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x43D7BA0", Offset = "0x43D6FA0", VA = "0x1843D7BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x43D7270", Offset = "0x43D6670", VA = "0x1843D7270")]
	public bool FJAEOODAFCM(T KBGCCIOIGBD, FDINGGDGHDL LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x43D7C00", Offset = "0x43D7000", VA = "0x1843D7C00")]
	public bool OANKGFLJIAB(FDINGGDGHDL LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x43D75B0", Offset = "0x43D69B0", VA = "0x1843D75B0")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x43D7520", Offset = "0x43D6920", VA = "0x1843D7520")]
	public bool GMJNAAAPBAP(FDINGGDGHDL LAAJFAFNFCN, [Out] T KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x43D7600", Offset = "0x43D6A00", VA = "0x1843D7600")]
	[OPICOFBLENP("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool MFBCGPJFHLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x43D7DF0", Offset = "0x43D71F0", VA = "0x1843D7DF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD6B510", Offset = "0xD6A910", VA = "0x180D6B510")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xD6BD90", Offset = "0xD6B190", VA = "0x180D6BD90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x757D570", Offset = "0x757C970", VA = "0x18757D570")]
	public void FJAEOODAFCM(float KBGCCIOIGBD, object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x757D630", Offset = "0x757CA30", VA = "0x18757D630")]
	public void OANKGFLJIAB(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x757D5E0", Offset = "0x757C9E0", VA = "0x18757D5E0")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x757D6A0", Offset = "0x757CAA0", VA = "0x18757D6A0")]
	private void PCKFJCOCGDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x757D7D0", Offset = "0x757CBD0", VA = "0x18757D7D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x757D190", Offset = "0x757C590", VA = "0x18757D190")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x757D310", Offset = "0x757C710", VA = "0x18757D310")]
		public IKDNCBCEBHI(float HHIGALLBHNK, float PDNKBEEOLID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x757D1A0", Offset = "0x757C5A0", VA = "0x18757D1A0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public HPDDBIMNPCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x757CC50", Offset = "0x757C050", VA = "0x18757CC50")]
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
		[Cpp2IlInjected.Address(RVA = "0x757DF40", Offset = "0x757D340", VA = "0x18757DF40", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x757DE80", Offset = "0x757D280", VA = "0x18757DE80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x757E000", Offset = "0x757D400", VA = "0x18757E000")]
	public MNIAMPGIDNC(int CCAKDDNOMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x757D860", Offset = "0x757CC60", VA = "0x18757D860")]
	public DFIENIKFOMH BAFFFEOJFBC(IKDNCBCEBHI OLCJMBGBODB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x757DA00", Offset = "0x757CE00", VA = "0x18757DA00")]
	public void GBJMEHKCHEN(JEEDOKEHIEI AJKAEBNDKFG, [Optional] IKDNCBCEBHI GOHDBGECHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x757D8F0", Offset = "0x757CCF0", VA = "0x18757D8F0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x757C360", Offset = "0x757B760", VA = "0x18757C360")]
		public FDPJOFLKHOD(JEEDOKEHIEI IPPJKGMAIAE, LLLEILNOHAD IJCKFHFIADK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x757C310", Offset = "0x757B710", VA = "0x18757C310", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x757E190", Offset = "0x757D590", VA = "0x18757E190")]
	internal static bool APIEBFBLHDC(float AMGCKABOOPF, float PPCFCAEIJMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x756B8A0", Offset = "0x756ACA0", VA = "0x18756B8A0")]
	internal static float NKEHNGGGMBL(float AMGCKABOOPF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x757E200", Offset = "0x757D600", VA = "0x18757E200")]
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
		[Cpp2IlInjected.Address(RVA = "0x757C020", Offset = "0x757B420", VA = "0x18757C020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event LLLEILNOHAD? DKGAKCAMIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x757C1B0", Offset = "0x757B5B0", VA = "0x18757C1B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x757C110", Offset = "0x757B510", VA = "0x18757C110", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x43C07A0", Offset = "0x43BFBA0", VA = "0x1843C07A0", Slot = "4")]
	public MDLPAKNCEDC<T> OCHIEBOHGDJ([Out] T KBGCCIOIGBD)
	{
		return default(MDLPAKNCEDC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x43C0680", Offset = "0x43BFA80", VA = "0x1843C0680")]
	public void BHDLIGCHPAN(T PJIOMIKBOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x401A4B0", Offset = "0x40198B0", VA = "0x18401A4B0", Slot = "5")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "6")]
	protected virtual void OAKMKNDHCHG(T CICNDJICHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x43C0700", Offset = "0x43BFB00", VA = "0x1843C0700")]
	private T NPPDIJEBOHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x43C0840", Offset = "0x43BFC40", VA = "0x1843C0840")]
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
	[Cpp2IlInjected.Address(RVA = "0x9AB3A0", Offset = "0x9AA7A0", VA = "0x1809AB3A0")]
	internal MDLPAKNCEDC(T KBGCCIOIGBD, FDNBKMNPJID<T> DFPGJPGNKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x4D69710", Offset = "0x4D68B10", VA = "0x184D69710", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x757BE80", Offset = "0x757B280", VA = "0x18757BE80")]
	public static MDLPAKNCEDC<StringBuilder> NPPDIJEBOHO([Out] StringBuilder KBGCCIOIGBD)
	{
		return default(MDLPAKNCEDC<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x757BF20", Offset = "0x757B320", VA = "0x18757BF20", Slot = "6")]
	protected override void OAKMKNDHCHG(StringBuilder CICNDJICHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x757BFE0", Offset = "0x757B3E0", VA = "0x18757BFE0")]
	public CLKMALCFIJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class IJGAGAHGILF : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6F261A0", Offset = "0x6F255A0", VA = "0x186F261A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x16FB170", Offset = "0x16FA570", VA = "0x1816FB170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4B643A0", Offset = "0x4B637A0", VA = "0x184B643A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
		[DebuggerHidden]
		public LJFJOINEIPF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x4426DA0", Offset = "0x44261A0", VA = "0x184426DA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x4B63ED0", Offset = "0x4B632D0", VA = "0x184B63ED0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4B63630", Offset = "0x4B62A30", VA = "0x184B63630")]
		private void ACIHHJJLKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4B636D0", Offset = "0x4B62AD0", VA = "0x184B636D0")]
		private void CHJIKJDKKOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4B64350", Offset = "0x4B63750", VA = "0x184B64350", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x4FBF390", Offset = "0x4FBE790", VA = "0x184FBF390", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool NJEEMOHCODN
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public TValue NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4FBF640", Offset = "0x4FBEA40", VA = "0x184FBF640", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4FBF910", Offset = "0x4FBED10", VA = "0x184FBF910", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public ICollection<TKey> OLFFBNADHCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4FBF690", Offset = "0x4FBEA90", VA = "0x184FBF690", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICollection<TValue> JKLIKDPGFIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x4FBF7B0", Offset = "0x4FBEBB0", VA = "0x184FBF7B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x4FBF2D0", Offset = "0x4FBE6D0", VA = "0x184FBF2D0")]
	public OLBDCLPAILH(PHIFDNOECFI<TKey, TValue> NAHHEEILNGL, [Optional] IDictionary<TKey, TValue>? JMAJJMFNCOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x4FBCB00", Offset = "0x4FBBF00", VA = "0x184FBCB00", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x4FBDBB0", Offset = "0x4FBCFB0", VA = "0x184FBDBB0")]
	public void JGGBNMCDDIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x4FBC790", Offset = "0x4FBBB90", VA = "0x184FBC790", Slot = "9")]
	public void Add(TKey LKMGECEEGEE, TValue KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4FBD950", Offset = "0x4FBCD50", VA = "0x184FBD950")]
	public void HGFBJLAOBNG(TKey LKMGECEEGEE, TValue KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x4FBD6F0", Offset = "0x4FBCAF0", VA = "0x184FBD6F0")]
	public void HAOCEOAKEMA(TKey LKMGECEEGEE, TValue KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x4FBDE70", Offset = "0x4FBD270", VA = "0x184FBDE70")]
	public void KCCPGCIKIFG(TKey LKMGECEEGEE, TValue KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4FBD4A0", Offset = "0x4FBC8A0", VA = "0x184FBD4A0")]
	public void GLACIFMBEPN(TKey LKMGECEEGEE, TValue KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4FBE950", Offset = "0x4FBDD50", VA = "0x184FBE950", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> MBDDOPABDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4FBE9A0", Offset = "0x4FBDDA0", VA = "0x184FBE9A0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> MBDDOPABDGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4FBED00", Offset = "0x4FBE100", VA = "0x184FBED00", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> MBDDOPABDGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4FBCC40", Offset = "0x4FBC040", VA = "0x184FBCC40", Slot = "8")]
	public bool ContainsKey(TKey LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x4FBE310", Offset = "0x4FBD710", VA = "0x184FBE310")]
	public bool LPNICKAODBC(TKey LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x4FBE1F0", Offset = "0x4FBD5F0", VA = "0x184FBE1F0")]
	public bool LIAJBFOMLNA(TKey LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x4FBE770", Offset = "0x4FBDB70", VA = "0x184FBE770", Slot = "10")]
	public bool Remove(TKey LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x4FBF130", Offset = "0x4FBE530", VA = "0x184FBF130", Slot = "11")]
	public bool TryGetValue(TKey LKMGECEEGEE, [Out] TValue KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x4FBCD00", Offset = "0x4FBC100", VA = "0x184FBCD00", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] CJFOOLJEHLK, int BJJLGILDBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x4A0DD00", Offset = "0x4A0D100", VA = "0x184A0DD00", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x4FBD640", Offset = "0x4FBCA40", VA = "0x184FBD640", Slot = "19")]
	[IteratorStateMachine(typeof(OLBDCLPAILH<, >.LJFJOINEIPF))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x4FBE0A0", Offset = "0x4FBD4A0", VA = "0x184FBE0A0", Slot = "21")]
	public bool KKIDAKGCFDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x4FBE3D0", Offset = "0x4FBD7D0", VA = "0x184FBE3D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xACB980", Offset = "0xACAD80", VA = "0x180ACB980")]
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
			[Cpp2IlInjected.Address(RVA = "0xA836D0", Offset = "0xA82AD0", VA = "0x180A836D0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xB39280", Offset = "0xB38680", VA = "0x180B39280")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public int NGPEAGCEMCO
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x98AE60", Offset = "0x98A260", VA = "0x18098AE60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x98A4B0", Offset = "0x9898B0", VA = "0x18098A4B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public DateTimeOffset NBAAFIKECCK
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x10A2730", Offset = "0x10A1B30", VA = "0x1810A2730")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x10A2070", Offset = "0x10A1470", VA = "0x1810A2070")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x4969F70", Offset = "0x4969370", VA = "0x184969F70")]
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
			[Cpp2IlInjected.Address(RVA = "0x16FB170", Offset = "0x16FA570", VA = "0x1816FB170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4616120", Offset = "0x4615520", VA = "0x184616120", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
		[DebuggerHidden]
		public HHDNPMGPILH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x43C42E0", Offset = "0x43C36E0", VA = "0x1843C42E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x4615910", Offset = "0x4614D10", VA = "0x184615910", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x46134D0", Offset = "0x46128D0", VA = "0x1846134D0")]
		private void ACIHHJJLKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x4615E00", Offset = "0x4615200", VA = "0x184615E00", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x95A2B0", Offset = "0x9596B0", VA = "0x18095A2B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA681C0", Offset = "0xA675C0", VA = "0x180A681C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA681D0", Offset = "0xA675D0", VA = "0x180A681D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x463A7A0", Offset = "0x4639BA0", VA = "0x18463A7A0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	internal int OIJEIDCFJHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x43D75B0", Offset = "0x43D69B0", VA = "0x1843D75B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public ICollection<TVal> JKLIKDPGFIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x463A8E0", Offset = "0x4639CE0", VA = "0x18463A8E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	ICollection<TKey> IDictionary<TKey, TVal>.GCKOEKMKIAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4639040", Offset = "0x4638440", VA = "0x184639040", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool NJEEMOHCODN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public TVal NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x463A830", Offset = "0x4639C30", VA = "0x18463A830", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x463A990", Offset = "0x4639D90", VA = "0x18463A990", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x4638750", Offset = "0x4637B50", VA = "0x184638750")]
	private bool OEMGDIJNMJN(int CCAKDDNOMFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x4632920", Offset = "0x4631D20", VA = "0x184632920")]
	private void BNFNMGHOBCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4639C40", Offset = "0x4639040", VA = "0x184639C40")]
	public HNFGOLPBJLN(int CCAKDDNOMFJ, [Optional] KAMLOIPNHBD? FHBIANPBGPB, [Optional] IEqualityComparer<TKey>? OLLCJFOMGIM, [Optional] KGEALBHDJCD? ICBKKFJOOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x4639770", Offset = "0x4638B70", VA = "0x184639770")]
	public HNFGOLPBJLN(TimeSpan OPNOBDGJKJA, [Optional] IEqualityComparer<TKey>? OLLCJFOMGIM, [Optional] KGEALBHDJCD? ICBKKFJOOIE, [Optional] POJBELOMCGC? FPGFCJBNBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x46396F0", Offset = "0x4638AF0", VA = "0x1846396F0")]
	public HNFGOLPBJLN(int CCAKDDNOMFJ, TimeSpan OPNOBDGJKJA, [Optional] IEqualityComparer<TKey>? OLLCJFOMGIM, [Optional] KGEALBHDJCD? ICBKKFJOOIE, [Optional] POJBELOMCGC? FPGFCJBNBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x463A340", Offset = "0x4639740", VA = "0x18463A340")]
	public HNFGOLPBJLN(int CCAKDDNOMFJ, KAMLOIPNHBD? FHBIANPBGPB, TimeSpan OPNOBDGJKJA, [Optional] IEqualityComparer<TKey>? OLLCJFOMGIM, [Optional] KGEALBHDJCD? ICBKKFJOOIE, [Optional] POJBELOMCGC? FPGFCJBNBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x46358D0", Offset = "0x4634CD0", VA = "0x1846358D0", Slot = "21")]
	public bool KKIDAKGCFDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4632250", Offset = "0x4631650", VA = "0x184632250", Slot = "22")]
	public bool AEHHMDNPNKH(int IBMHAIHIDJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x46367A0", Offset = "0x4635BA0", VA = "0x1846367A0")]
	private bool LHNAIMMBIIE(int IBMHAIHIDJJ, IAIFEKOPBMN CEGFAIJENKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4633A80", Offset = "0x4632E80", VA = "0x184633A80")]
	public void ECFLGDLFBIO(TKey LKMGECEEGEE, TVal KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4632740", Offset = "0x4631B40", VA = "0x184632740", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> MBDDOPABDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x46325D0", Offset = "0x46319D0", VA = "0x1846325D0", Slot = "9")]
	public void Add(TKey LKMGECEEGEE, TVal KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x4632F70", Offset = "0x4632370", VA = "0x184632F70", Slot = "8")]
	public bool ContainsKey(TKey LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x4638CC0", Offset = "0x46380C0", VA = "0x184638CC0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> MBDDOPABDGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x46389D0", Offset = "0x4637DD0", VA = "0x1846389D0", Slot = "10")]
	public bool Remove(TKey LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x4638DB0", Offset = "0x46381B0", VA = "0x184638DB0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> MBDDOPABDGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x4635C10", Offset = "0x4635010", VA = "0x184635C10")]
	private bool LFGMPFNBDCL(TKey LKMGECEEGEE, [Out] TVal KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x4638640", Offset = "0x4637A40", VA = "0x184638640")]
	private TVal NPPDIJEBOHO(TKey MHOMJGNFGGL)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x46394F0", Offset = "0x46388F0", VA = "0x1846394F0", Slot = "11")]
	public bool TryGetValue(TKey MHOMJGNFGGL, [Out] TVal KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x4632DF0", Offset = "0x46321F0", VA = "0x184632DF0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x4633040", Offset = "0x4632440", VA = "0x184633040", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] CJFOOLJEHLK, int BJJLGILDBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x4635790", Offset = "0x4634B90", VA = "0x184635790")]
	private void JGAFKEPOLMB(TKey LKMGECEEGEE, TVal DGOEGFOLJJL, IAIFEKOPBMN CEGFAIJENKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x46351E0", Offset = "0x46345E0", VA = "0x1846351E0")]
	private bool IAPJMDPJNEN(JDBAONNDAOK AIJONMGJNLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4637910", Offset = "0x4636D10", VA = "0x184637910")]
	private void LKEHHHFJALP(LinkedListNode<JDBAONNDAOK> IGEPGONCPND, TVal IOCKBOOECEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x46344B0", Offset = "0x46338B0", VA = "0x1846344B0")]
	private void FJAEOODAFCM(TKey LKMGECEEGEE, TVal KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4633E50", Offset = "0x4633250", VA = "0x184633E50")]
	private void FFCCMEJFINM(JDBAONNDAOK AIJONMGJNLE, TVal IOCKBOOECEL, int FGICKOMPDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x4634EF0", Offset = "0x46342F0", VA = "0x184634EF0", Slot = "19")]
	[IteratorStateMachine(typeof(HNFGOLPBJLN<, >.HHDNPMGPILH))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x4639090", Offset = "0x4638490", VA = "0x184639090", Slot = "20")]
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
	[Cpp2IlInjected.Address(RVA = "0x583CDF0", Offset = "0x583C1F0", VA = "0x18583CDF0")]
	public BHMEGLMMBNI(TKey PPGILBEKLCH, Exception DIHKEEPHEOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class JCINOCDFICC : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x67A6F00", Offset = "0x67A6300", VA = "0x1867A6F00")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public IHEKKLHBCBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x4720950", Offset = "0x471FD50", VA = "0x184720950")]
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
		[Cpp2IlInjected.Address(RVA = "0x4AD99B0", Offset = "0x4AD8DB0", VA = "0x184AD99B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x4ADA530", Offset = "0x4AD9930", VA = "0x184ADA530", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4B67EE0", Offset = "0x4B672E0", VA = "0x184B67EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x4B68C20", Offset = "0x4B68020", VA = "0x184B68C20", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4A42AA0", Offset = "0x4A41EA0", VA = "0x184A42AA0")]
	public KDGGAAKPFMI(int ALOJAOINMGK = 0, [Optional] IEqualityComparer<TId>? FNJGAFDGLBB, [Optional] Func<TId, CancellationToken, Task<TResource>>? MKJPDHHACCF, [Optional] Action<TResource>? ODILGOKBKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x4A42230", Offset = "0x4A41630", VA = "0x184A42230")]
	public KFDDALGMHJI<Task<TResource>> EIABKLCIIAG(TId KGHCKLKGJKM, [Optional] Func<TId, CancellationToken, Task<TResource>>? MKJPDHHACCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x4A41820", Offset = "0x4A40C20", VA = "0x184A41820")]
	private void DHGLNKNCHGP(Task<TResource> CBPINBDBDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x4A415B0", Offset = "0x4A409B0", VA = "0x184A415B0")]
	[AsyncStateMachine(typeof(KDGGAAKPFMI<, >.KOHPLOLCAKJ))]
	private Task ACFDHBCDBGM(Task<TResource> CBPINBDBDCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x448A650", Offset = "0x4489A50", VA = "0x18448A650")]
	public void NFGPLPPJJIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x4A416B0", Offset = "0x4A40AB0", VA = "0x184A416B0")]
	public LOCFIGMEMFO<TId, Task<TResource>>.CEPDBEGPIGE BNIMLGJMJBK()
	{
		return default(LOCFIGMEMFO<TId, Task<TResource>>.CEPDBEGPIGE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x4A42A00", Offset = "0x4A41E00", VA = "0x184A42A00", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x4A42A00", Offset = "0x4A41E00", VA = "0x184A42A00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x4A42670", Offset = "0x4A41A70", VA = "0x184A42670")]
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
		[Cpp2IlInjected.Address(RVA = "0xF7C350", Offset = "0xF7B750", VA = "0x180F7C350")]
		public INMNHDPGCPJ(TValue KBGCCIOIGBD, int AMKCELBMEDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x47382B0", Offset = "0x47376B0", VA = "0x1847382B0", Slot = "4")]
		public bool Equals(INMNHDPGCPJ? OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x4738210", Offset = "0x4737610", VA = "0x184738210", Slot = "0")]
		public override bool Equals(object? GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x47384F0", Offset = "0x47378F0", VA = "0x1847384F0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x5A3D000", Offset = "0x5A3C400", VA = "0x185A3D000", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public (TKey Key, TValue Value, int RefCount) FJMLFGNPDDN
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x5A3D5C0", Offset = "0x5A3C9C0", VA = "0x185A3D5C0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5A3D140", Offset = "0x5A3C540", VA = "0x185A3D140")]
		public CEPDBEGPIGE(LOCFIGMEMFO<TKey, TValue> EIEEOCBNIGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x5A3CBB0", Offset = "0x5A3BFB0", VA = "0x185A3CBB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x5A3CC30", Offset = "0x5A3C030", VA = "0x185A3CC30", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x5A3CD50", Offset = "0x5A3C150", VA = "0x185A3CD50", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public EKMEPIGONIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x401AF10", Offset = "0x401A310", VA = "0x18401AF10")]
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
	[Cpp2IlInjected.Address(RVA = "0x4B6E970", Offset = "0x4B6DD70", VA = "0x184B6E970")]
	public LOCFIGMEMFO(int ALOJAOINMGK = 0, [Optional] IEqualityComparer<TKey>? OLLCJFOMGIM, [Optional] Func<TKey, TValue>? LACFGOJOABD, [Optional] Action<TValue>? PDEPNDOHCDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x4B6D4D0", Offset = "0x4B6C8D0", VA = "0x184B6D4D0")]
	public KFDDALGMHJI<TValue> EIABKLCIIAG(TKey LKMGECEEGEE, [Optional] Func<TKey, TValue>? BALLJEKNFFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x4B6D070", Offset = "0x4B6C470", VA = "0x184B6D070")]
	private void BHDLIGCHPAN(TKey LKMGECEEGEE, INMNHDPGCPJ JLCJMJCAGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x4B6E120", Offset = "0x4B6D520", VA = "0x184B6E120")]
	public void NFGPLPPJJIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x4B6D410", Offset = "0x4B6C810", VA = "0x184B6D410")]
	public CEPDBEGPIGE BNIMLGJMJBK()
	{
		return default(CEPDBEGPIGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x4B6E7A0", Offset = "0x4B6DBA0", VA = "0x184B6E7A0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x4B6E7A0", Offset = "0x4B6DBA0", VA = "0x184B6E7A0", Slot = "5")]
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
