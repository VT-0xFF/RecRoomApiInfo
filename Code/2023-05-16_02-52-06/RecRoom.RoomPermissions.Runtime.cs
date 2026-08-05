using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x642E2C0", Offset = "0x642D0C0", VA = "0x18642E2C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x75C880", Offset = "0x75B680", VA = "0x18075C880")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA7DB60", Offset = "0xA7C960", VA = "0x180A7DB60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum FLJCBOEBAOK
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum GBAAJEPBLBF
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void KPCBJAOKHIL<TPermission>(TPermission JJAHHIEFMGP);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void BLGDDPGMNNK(ECDFOCMBGHG KAFKHLPGHBP);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HDGPKLEMMFG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FCKOBJJKGJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool ELBBAONOIOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool JAGNHECMIAB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EGJKDBBOHHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool EJEGLDKIJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool ECPJAKEGACM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CHNCKMGOLMI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	FINLLAKGJJJ KKOFCFPEJEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IEnumerable<BOKDCICMMEL> ONKPCJEDDOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event BLGDDPGMNNK BDMCMFEICOI;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<BOKDCICMMEL> BKBJNFFJOPK(bool MCNCIJDHJHL = false);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BOKDCICMMEL HCGNCGNAOMF(ECDFOCMBGHG KAFKHLPGHBP);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool AJICBLLLIJA(ECDFOCMBGHG KAFKHLPGHBP);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<BOKDCICMMEL> EIPOCFGNBNO(ECDFOCMBGHG KAFKHLPGHBP, bool DECPIMICKGF = false);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GOFEJGHBCKN(ECDFOCMBGHG LEHEHBOPPJP, GBHHNOAKMKO HJJHNKMMFHE);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BOKDCICMMEL ALJFPEDMFDD(GBHHNOAKMKO HJJHNKMMFHE);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool GPNJPBPIHGC<T>(GBHHNOAKMKO HJJHNKMMFHE, CLNCHNMHJOB JJAHHIEFMGP, bool OICJFLOHMGK, T OHMLFHCAJEC) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EFELMOJCKJG
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CIDDHLAHOKC(CKGKBFGOMIH FHDHPJOAAEH, CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EFNHKHGOECI(ref CKGKBFGOMIH FHDHPJOAAEH);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OPDGNGBHFPA
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	ECDFOCMBGHG PAACCJIGOEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	OPEMBDFJMKA LJEEDFGMDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	PGKHPCCBDIC IIDHBHELLHP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<IMPEIHAIOLA> ELNECANKLFF;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action PIPPNBBAOOL;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GBHHNOAKMKO KEKKMHKIBAN(ECDFOCMBGHG KAFKHLPGHBP);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<IMPEIHAIOLA> KHAPIPFEGAB(CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task BAMMLLCNCCF(long GJDNMGJBIPD, long EOEOMNAMOHH, IReadOnlyList<JNEOOOGHNOG> PNGBMMFGLPG);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<ECDFOCMBGHG> LCFBPBIHHJF();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class LNHAIIGIDIB
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x642DF20", Offset = "0x642CD20", VA = "0x18642DF20")]
	public static GBHHNOAKMKO FGOCHBKKBJC(this OPDGNGBHFPA DLPEOHNPLJM)
	{
		return default(GBHHNOAKMKO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PLBIFHMMFKG<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string JNFDOJIEKKM
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event global::KPCBJAOKHIL<TPermission> FEGHOLNHHMK;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal static class FBPFHACANEB
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[Flags]
	public enum GKIAECCNDPI
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		AG_EVERYONE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		AG_CREATOR = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		AG_COOWNER = 0x400000,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		AG_HOST = 0x800000,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		AG_MODERATOR = 0x1000000
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Guid FDMGLKLPEMN;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid PFICMNBDLML;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid IIODCCCBBJK;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid CJGKOGPPMIG;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid MGGFIGDKBOH;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly global::NMHPKNCLOGN<GBHHNOAKMKO, Guid> DOAMJLJMAAD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	internal static IEnumerable<GBHHNOAKMKO> AJADIDIPOCF
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6428DA0", Offset = "0x6427BA0", VA = "0x186428DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6429060", Offset = "0x6427E60", VA = "0x186429060")]
	public static GBHHNOAKMKO MEGAGKCGFMN(Guid AOKEOLFIKCH)
	{
		return default(GBHHNOAKMKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6428FB0", Offset = "0x6427DB0", VA = "0x186428FB0")]
	public static Guid KFFGNMPIJPD(GBHHNOAKMKO HJJHNKMMFHE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6428D00", Offset = "0x6427B00", VA = "0x186428D00")]
	public static bool CDABCBEFMLA(GBHHNOAKMKO HJJHNKMMFHE, out Guid AOKEOLFIKCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6428ED0", Offset = "0x6427CD0", VA = "0x186428ED0")]
	public static bool HEJKLFHMIIB(Guid AOKEOLFIKCH, out GBHHNOAKMKO HJJHNKMMFHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6428CD0", Offset = "0x6427AD0", VA = "0x186428CD0")]
	public static GBHHNOAKMKO BHACEADCOHN(GBHHNOAKMKO HJJHNKMMFHE)
	{
		return default(GBHHNOAKMKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6428E20", Offset = "0x6427C20", VA = "0x186428E20")]
	public static GKIAECCNDPI GHNDGMEHMDM(GBHHNOAKMKO NFLCDJLAFJP)
	{
		return default(GKIAECCNDPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6428F70", Offset = "0x6427D70", VA = "0x186428F70")]
	internal static GBHHNOAKMKO IHIFJBEIELD(GKIAECCNDPI GEGGEEFNODI)
	{
		return default(GBHHNOAKMKO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class EHOBJJKBENH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? CCGEMADDHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7612C0", Offset = "0x7600C0", VA = "0x1807612C0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x740F40", Offset = "0x73FD40", VA = "0x180740F40")]
	protected EHOBJJKBENH(object? PHDFKHDKCKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool KFMNCDLPMGL(object? MGFMONLLLPD);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class GCNFEKIBFHJ<T> : EHOBJJKBENH where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private T FKLNJIPOMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> MDBNCNNPFHB;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T KCKILJPPPGI
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x75BA60", Offset = "0x75A860", VA = "0x18075BA60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3C95050", Offset = "0x3C93E50", VA = "0x183C95050", Slot = "4")]
	public override bool KFMNCDLPMGL(object? MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3C94C70", Offset = "0x3C93A70", VA = "0x183C94C70")]
	public bool HDMGMCDHONI(T OONDBCECLHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3C951D0", Offset = "0x3C93FD0", VA = "0x183C951D0")]
	public GCNFEKIBFHJ(T HPJBCMEILDI, IEqualityComparer<T> MDBNCNNPFHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class LEPJAMELGLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<CLNCHNMHJOB, bool> JEBILEBJLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<CLNCHNMHJOB, EHOBJJKBENH> AIMPPFPJECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly JHHKCPAFAPH IGABGEAKGCC;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x642DCC0", Offset = "0x642CAC0", VA = "0x18642DCC0")]
	public LEPJAMELGLJ(JHHKCPAFAPH IGABGEAKGCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x642DB90", Offset = "0x642C990", VA = "0x18642DB90")]
	public bool DDPLMFCDJJJ(CLNCHNMHJOB JJAHHIEFMGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x27BC8D0", Offset = "0x27BB6D0", VA = "0x1827BC8D0")]
	public bool AOJHJJHMIBN<T>(CLNCHNMHJOB JJAHHIEFMGP, bool OICJFLOHMGK, T MGFMONLLLPD) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x27BCC50", Offset = "0x27BBA50", VA = "0x1827BCC50")]
	public (bool, T?) BJLHBEALEMI<T>(CLNCHNMHJOB JJAHHIEFMGP) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x642D840", Offset = "0x642C640", VA = "0x18642D840")]
	public bool AOJHJJHMIBN(CLNCHNMHJOB JJAHHIEFMGP, bool OICJFLOHMGK, object MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x642D920", Offset = "0x642C720", VA = "0x18642D920")]
	public (bool, object) BJLHBEALEMI(CLNCHNMHJOB JJAHHIEFMGP)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x27BCE60", Offset = "0x27BBC60", VA = "0x1827BCE60")]
	private void EAFENFJEJLK<T>(CLNCHNMHJOB JJAHHIEFMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x642DC00", Offset = "0x642CA00", VA = "0x18642DC00")]
	private EHOBJJKBENH LIBDEIPANFO(CLNCHNMHJOB JJAHHIEFMGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x642D9F0", Offset = "0x642C7F0", VA = "0x18642D9F0")]
	public void CDCIKGBBEHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class KHOBEJOABDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string BAPPBPLIODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type EKCPPINEEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly CKMOPOOFJFM MALKDJIGCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly CLNCHNMHJOB BBCGMIHLBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public JLEHIACEHJG PBBLBKHEGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public BIBMCMELNLP JLPFKKOFPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public DBABBACJCDA BPJOBKHMBEH;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x642D190", Offset = "0x642BF90", VA = "0x18642D190")]
	public KHOBEJOABDK(Type LCBPDLMNJMD, string AEHIGCBGBMA, CLNCHNMHJOB JJAHHIEFMGP, JLEHIACEHJG PLFKJNBNIGK, BIBMCMELNLP HPODNGBGOJO, DBABBACJCDA HBDFJJKIFFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x642D150", Offset = "0x642BF50", VA = "0x18642D150")]
	public object FLDDFAJIMJI(object? IDBPJJAKCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x16584A0", Offset = "0x16572A0", VA = "0x1816584A0")]
	public void EAFENFJEJLK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x642D0A0", Offset = "0x642BEA0", VA = "0x18642D0A0")]
	public void EAFENFJEJLK(Type FANFMFGFECN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class NNKNHBLMNLG<T> : KHOBEJOABDK where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string IJPGPNCMGIC(T MGFMONLLLPD);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T JMLPMPEKHON(string? LNNENCCECLF, T HPJBCMEILDI);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class PDKOBNPIKIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public IJPGPNCMGIC serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public JMLPMPEKHON parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public PDKOBNPIKIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1FFAA10", Offset = "0x1FF9810", VA = "0x181FFAA10")]
		internal string <.ctor>b__0(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1FFAB00", Offset = "0x1FF9900", VA = "0x181FFAB00")]
		internal object <.ctor>b__1(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3E3F730", Offset = "0x3E3E530", VA = "0x183E3F730")]
	public NNKNHBLMNLG(CLNCHNMHJOB JJAHHIEFMGP, string AEHIGCBGBMA, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1290", Offset = "0x6F0690")] global::NNKNHBLMNLG<T>.IJPGPNCMGIC PLFKJNBNIGK, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F12F0", Offset = "0x6F06F0")] global::NNKNHBLMNLG<T>.JMLPMPEKHON HPODNGBGOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3E3E720", Offset = "0x3E3D520", VA = "0x183E3E720")]
	private static object? BPPOCFBLMGN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1350", Offset = "0x6F0750")] global::NNKNHBLMNLG<T?>.JMLPMPEKHON? HPODNGBGOJO, string? LNNENCCECLF, object? HPJBCMEILDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3E3F090", Offset = "0x3E3DE90", VA = "0x183E3F090")]
	private static string EPOBOPBJBKM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F13B0", Offset = "0x6F07B0")] global::NNKNHBLMNLG<T>.IJPGPNCMGIC PGJMIKELGME, object? MGFMONLLLPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string JLEHIACEHJG(object? MGFMONLLLPD);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object BIBMCMELNLP(string? LNNENCCECLF, [Optional] object HPJBCMEILDI);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate EHOBJJKBENH DBABBACJCDA();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class JHHKCPAFAPH
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class AONGMNONPFA : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static AONGMNONPFA NHLDGJJELOO;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6421E10", Offset = "0x6420C10", VA = "0x186421E10", Slot = "4")]
		public bool Equals(List<string> NHKCICGBPMI, List<string> PEKPPEFFGIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6421F70", Offset = "0x6420D70", VA = "0x186421F70", Slot = "5")]
		public int GetHashCode(List<string> OJGAEOFIMPK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public AONGMNONPFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class IGJMNALMOIK : global::EDGPKKEMCED<FLJCBOEBAOK>
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x64295F0", Offset = "0x64283F0", VA = "0x1864295F0", Slot = "9")]
		public override string EPOBOPBJBKM(FLJCBOEBAOK KOHCAKAAIGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x64296F0", Offset = "0x64284F0", VA = "0x1864296F0", Slot = "10")]
		protected override bool PMCIELPGLJE(string KOHCAKAAIGA, out FLJCBOEBAOK MGFMONLLLPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x64298E0", Offset = "0x64286E0", VA = "0x1864298E0")]
		public IGJMNALMOIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly MJABPJIPPGD DIDNBLOOGMD;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly IGJMNALMOIK FKNBJMHGFLP;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<KHOBEJOABDK> NEFEENOELHJ;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<CLNCHNMHJOB> LJEIPCDPPIN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<CLNCHNMHJOB, KHOBEJOABDK> OFMAKHIDCNM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x642AB90", Offset = "0x6429990", VA = "0x18642AB90")]
	public JHHKCPAFAPH([Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1410", Offset = "0x6F0810")] IList<KHOBEJOABDK> BEIDJKANLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6429FA0", Offset = "0x6428DA0", VA = "0x186429FA0")]
	public KHOBEJOABDK EBGNIJKAGLB(CLNCHNMHJOB JJAHHIEFMGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface FINLLAKGJJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	BOKDCICMMEL GFDIPEAAPGA
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class EBCAEAKKOMA : FINLLAKGJJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static EBCAEAKKOMA NLJEJCFPLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly JPCNNOFHCJE HDIBEKINOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<JPCNNOFHCJE> GLMGFHINOFH;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public BOKDCICMMEL GFDIPEAAPGA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6428BD0", Offset = "0x64279D0", VA = "0x186428BD0")]
	public EBCAEAKKOMA(JPCNNOFHCJE OAANGAFJGGH, IReadOnlyList<JPCNNOFHCJE> GDMFPMECLIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6428390", Offset = "0x6427190", VA = "0x186428390")]
	private static EBCAEAKKOMA EEADELGMNGC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class MPMCFIAFBIA
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<GBHHNOAKMKO> PPKMMNEGOOH;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x642DF80", Offset = "0x642CD80", VA = "0x18642DF80")]
	public static bool COAHMHEGGAG(this ECDFOCMBGHG FDHCKLIPOGF, GBHHNOAKMKO HJJHNKMMFHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x642E070", Offset = "0x642CE70", VA = "0x18642E070")]
	public static bool PJNFMHAANBN(this ECDFOCMBGHG FDHCKLIPOGF, GBHHNOAKMKO HJJHNKMMFHE, PGKHPCCBDIC DIPFHONDAKO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface OBKIJJFJMON
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool CDNDPFAKDNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool CMHOHKLEEGP
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool GKNGEEJECNC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool EHGHDANEKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool LMGKOMFKBBD
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool AOGNBFLFLCD
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool JJAKFMOFAKC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool JBDFBPGKCNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool EMOCNCCEEDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool GCMEIHPGNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool MBPFFCJLHEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool BHJCMPKHJFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> BLMJABKHEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	FLJCBOEBAOK GJPEHDDIJME
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface BOKDCICMMEL : OBKIJJFJMON, HDGPKLEMMFG, global::PLBIFHMMFKG<CLNCHNMHJOB>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string KFICOCCFGCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	GBHHNOAKMKO OCAGMPACHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) DBLNPDBBLCJ<T>(CLNCHNMHJOB JJAHHIEFMGP) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum CLNCHNMHJOB
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	CAN_EDIT_ROOM_ROLES = 1,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	VOTE_KICK_PERMISSION = 3,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	CAN_INVITE = 4,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CAN_TALK = 6,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CAN_PRINT_PHOTOS = 7,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CAN_START_GAMES = 8,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CAN_SELF_REVIVE = 9,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	AUTO_ASSIGNED_GAME_ROLES = 11,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	CAN_CHANGE_GAME_MODE = 12,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CAN_USE_MAKER_PEN = 13,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CAN_USE_DELETE_ALL_BUTTON = 14,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CAN_SAVE_INVENTIONS = 15,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	DISABLE_MIC_AUTO_MUTE = 16,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CAN_END_GAMES_EARLY = 17,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CAN_USE_SHARE_CAM = 18,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	DEPRECATED_CAN_EDIT_CIRCUITS = 19,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	CAN_SPAWN_INVENTIONS = 20,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	CAN_SPAWN_CONSUMABLES = 21,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CAN_USE_ROOM_RESET_BUTTON = 22,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class JPCNNOFHCJE : BOKDCICMMEL, OBKIJJFJMON, HDGPKLEMMFG, global::PLBIFHMMFKG<CLNCHNMHJOB>
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal static readonly JHHKCPAFAPH ONNFACIKHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal readonly LEPJAMELGLJ GHFLLHMPMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private string? BMJPEHBAIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string? FJIMJIKLPFO;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool CDNDPFAKDNH
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x642CC80", Offset = "0x642BA80", VA = "0x18642CC80", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public FLJCBOEBAOK GJPEHDDIJME
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x642BD90", Offset = "0x642AB90", VA = "0x18642BD90", Slot = "20")]
		get
		{
			return default(FLJCBOEBAOK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool CMHOHKLEEGP
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x642C400", Offset = "0x642B200", VA = "0x18642C400", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool GKNGEEJECNC
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x642CC30", Offset = "0x642BA30", VA = "0x18642CC30", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool EHGHDANEKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x642CDC0", Offset = "0x642BBC0", VA = "0x18642CDC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool LMGKOMFKBBD
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x642CBE0", Offset = "0x642B9E0", VA = "0x18642CBE0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool AOGNBFLFLCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x642CAF0", Offset = "0x642B8F0", VA = "0x18642CAF0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool JJAKFMOFAKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x642CD20", Offset = "0x642BB20", VA = "0x18642CD20", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool JBDFBPGKCNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x642CB90", Offset = "0x642B990", VA = "0x18642CB90", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool EMOCNCCEEDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x642C900", Offset = "0x642B700", VA = "0x18642C900", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<string> BLMJABKHEAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x642C950", Offset = "0x642B750", VA = "0x18642C950", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool DMGDBKFAHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x642CCD0", Offset = "0x642BAD0", VA = "0x18642CCD0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool ADJOJDPGGEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x642CA50", Offset = "0x642B850", VA = "0x18642CA50", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool MCHNHCIGFNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x642CB40", Offset = "0x642B940", VA = "0x18642CB40", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool GCMEIHPGNON
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x642CD70", Offset = "0x642BB70", VA = "0x18642CD70", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool MBPFFCJLHEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x642BF90", Offset = "0x642AD90", VA = "0x18642BF90", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool DGBCFGLHEGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x642BE50", Offset = "0x642AC50", VA = "0x18642BE50", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool BHJCMPKHJFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x642B390", Offset = "0x642A190", VA = "0x18642B390", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool DLHHJKDEIEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x642B2B0", Offset = "0x642A0B0", VA = "0x18642B2B0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool JKEGIDBPDEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x642BF40", Offset = "0x642AD40", VA = "0x18642BF40", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private bool LNBCPHHMAOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x642CCD0", Offset = "0x642BAD0", VA = "0x18642CCD0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private bool EPPCCAPAOIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x642CB40", Offset = "0x642B940", VA = "0x18642CB40", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private bool ENHMHKEGEEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x642BE50", Offset = "0x642AC50", VA = "0x18642BE50", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool MHKANKKMGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x642B2B0", Offset = "0x642A0B0", VA = "0x18642B2B0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool MDJPNGAKIBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x642CA50", Offset = "0x642B850", VA = "0x18642CA50", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private bool GEFCINKPABK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x642BF40", Offset = "0x642AD40", VA = "0x18642BF40", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public GBHHNOAKMKO OCAGMPACHEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x75BA60", Offset = "0x75A860", VA = "0x18075BA60", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(GBHHNOAKMKO);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x77D190", Offset = "0x77BF90", VA = "0x18077D190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string JNFDOJIEKKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x642CAA0", Offset = "0x642B8A0", VA = "0x18642CAA0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x642BE00", Offset = "0x642AC00", VA = "0x18642BE00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string KFICOCCFGCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x642CAA0", Offset = "0x642B8A0", VA = "0x18642CAA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool MDLGHJDHFGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x823C30", Offset = "0x822A30", VA = "0x180823C30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x989B70", Offset = "0x988970", VA = "0x180989B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::KPCBJAOKHIL<CLNCHNMHJOB> FEGHOLNHHMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x642C9B0", Offset = "0x642B7B0", VA = "0x18642C9B0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x642BEA0", Offset = "0x642ACA0", VA = "0x18642BEA0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x642AF00", Offset = "0x6429D00", VA = "0x18642AF00")]
	public HGGMFILLDHK ACLPGJFJIHM(Func<GBHHNOAKMKO, Guid> OPCLDHHMLIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x642B3E0", Offset = "0x642A1E0", VA = "0x18642B3E0")]
	public void CAEIPPFICDP(HGGMFILLDHK HMIMIEOJNNG, Func<Guid, GBHHNOAKMKO> HKKGHJAPJGO, [Optional] GBHHNOAKMKO? LGHKDKGABCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x16465F0", Offset = "0x16453F0", VA = "0x1816465F0", Slot = "6")]
	public (bool, T?) DBLNPDBBLCJ<T>(CLNCHNMHJOB JJAHHIEFMGP) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1646780", Offset = "0x1645580", VA = "0x181646780")]
	public JPCNNOFHCJE EENDCNONELM<T>(CLNCHNMHJOB JJAHHIEFMGP, bool OICJFLOHMGK, T MGFMONLLLPD) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x642D080", Offset = "0x642BE80", VA = "0x18642D080")]
	public JPCNNOFHCJE(GBHHNOAKMKO HJJHNKMMFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x642CFD0", Offset = "0x642BDD0", VA = "0x18642CFD0")]
	public JPCNNOFHCJE(GBHHNOAKMKO HJJHNKMMFHE, [Optional] string? BMJPEHBAIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x642CFF0", Offset = "0x642BDF0", VA = "0x18642CFF0")]
	public JPCNNOFHCJE(JPCNNOFHCJE AINFKIAAIDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x642CE80", Offset = "0x642BC80", VA = "0x18642CE80")]
	internal JPCNNOFHCJE(GBHHNOAKMKO LMAMPJEDINL, [Optional] string? BMJPEHBAIPC, [Optional] JPCNNOFHCJE? AINFKIAAIDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x642C450", Offset = "0x642B250", VA = "0x18642C450")]
	public static CKMOPOOFJFM FGIOBLHJAFH(CLNCHNMHJOB JJAHHIEFMGP)
	{
		return default(CKMOPOOFJFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x642BDE0", Offset = "0x642ABE0", VA = "0x18642BDE0")]
	public void CDCIKGBBEHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x642C0C0", Offset = "0x642AEC0", VA = "0x18642C0C0")]
	internal JPCNNOFHCJE FBJCAOOLMCP(JPCNNOFHCJE LHJBDEADDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x642C4D0", Offset = "0x642B2D0", VA = "0x18642C4D0")]
	internal IReadOnlyCollection<CLNCHNMHJOB> FGNHAFDBLPE(JPCNNOFHCJE AINFKIAAIDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x642BFE0", Offset = "0x642ADE0", VA = "0x18642BFE0")]
	public bool ENKFKKEDKHJ(CLNCHNMHJOB JJAHHIEFMGP, bool OICJFLOHMGK, string JCAHIJPNFGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x642B1B0", Offset = "0x6429FB0", VA = "0x18642B1B0")]
	public (bool, string) ADOIBBHGBDF(CLNCHNMHJOB JJAHHIEFMGP)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x642B110", Offset = "0x6429F10", VA = "0x18642B110")]
	internal void ACPIOANJLLJ(CLNCHNMHJOB JJAHHIEFMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x642B300", Offset = "0x642A100", VA = "0x18642B300")]
	[CompilerGenerated]
	private void AKJFCDGCFFE(CLNCHNMHJOB OMDGFAILKCH, LDONKFFCEMB HHNNBMGIKID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class CNEANPJFBNO : EFELMOJCKJG, CHNCKMGOLMI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class FNBKGNHHCEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public JPCNNOFHCJE newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public FNBKGNHHCEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x64295C0", Offset = "0x64283C0", VA = "0x1864295C0")]
		internal bool <InitializeRolesLists>b__0(JPCNNOFHCJE rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class IOFBJPBMCIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public GBHHNOAKMKO roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public IOFBJPBMCIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6429F90", Offset = "0x6428D90", VA = "0x186429F90")]
		internal bool <UpdateRoleDatas>b__0(GBHHNOAKMKO r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct LEOGGOBMNCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public CNEANPJFBNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public CKGKBFGOMIH roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F19C0", Offset = "0x6F0DC0")]
		private TaskAwaiter<IMPEIHAIOLA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x642D220", Offset = "0x642C020", VA = "0x18642D220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class FCMOLAMDBJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public FCMOLAMDBJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x64293C0", Offset = "0x64281C0", VA = "0x1864293C0")]
		internal void <RunBackwardsCompatibilityMigration>b__0(HGGMFILLDHK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x64294A0", Offset = "0x64282A0", VA = "0x1864294A0")]
		internal void <RunBackwardsCompatibilityMigration>b__1(HGGMFILLDHK r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct PANMADCDJFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CKGKBFGOMIH roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class CNNOHAEKOKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1A20", Offset = "0x6F0E20")]
		public Func<HGGMFILLDHK, LDONKFFCEMB> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public CNNOHAEKOKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6427860", Offset = "0x6426660", VA = "0x186427860")]
		internal void <MigrateLegacyHostSettings>b__1(HGGMFILLDHK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x64278C0", Offset = "0x64266C0", VA = "0x1864278C0")]
		internal void <MigrateLegacyHostSettings>b__2(HGGMFILLDHK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6427920", Offset = "0x6426720", VA = "0x186427920")]
		internal void <MigrateLegacyHostSettings>b__3(HGGMFILLDHK r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class FEOFNNGOEBO<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public CNEANPJFBNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CLNCHNMHJOB rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public GBHHNOAKMKO accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public CKMOPOOFJFM recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public FEOFNNGOEBO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct LMCGILMLACA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public IReadOnlyList<JNEOOOGHNOG> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct DHPGEGOEANK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public OPDGNGBHFPA rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public CKGKBFGOMIH roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1B30", Offset = "0x6F0F30")]
		public IReadOnlyDictionary<GBHHNOAKMKO, JPCNNOFHCJE> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public CAEMJJLHFME debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6427980", Offset = "0x6426780", VA = "0x186427980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly OPDGNGBHFPA DLPEOHNPLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly EBCAEAKKOMA DPCCLDNJKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly CAEMJJLHFME FMNFHIFKELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly Dictionary<int, JPCNNOFHCJE> IMILFGJKMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal readonly Dictionary<GBHHNOAKMKO, JPCNNOFHCJE> CLFOLJBFHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	internal readonly Dictionary<GBHHNOAKMKO, JPCNNOFHCJE> BCJAADOIBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly List<JPCNNOFHCJE> GJHAKMEFAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool BGEKFFEAAOK;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly CLNCHNMHJOB[] HOFJCEGCDMI;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public FINLLAKGJJJ KKOFCFPEJEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<BOKDCICMMEL> ONKPCJEDDOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6422B40", Offset = "0x6421940", VA = "0x186422B40", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event BLGDDPGMNNK BDMCMFEICOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6424360", Offset = "0x6423160", VA = "0x186424360", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6427060", Offset = "0x6425E60", VA = "0x186427060", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6424400", Offset = "0x6423200", VA = "0x186424400")]
	[CFDOMFEMHNO(LLLAACKFLBA.Room, ANAFFCEINAM.None)]
	private static void HGNLLPENNMP(GMLHNNIDAIC LNJPAOGJIFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x64275D0", Offset = "0x64263D0", VA = "0x1864275D0")]
	[UnityEngine.Scripting.Preserve]
	internal CNEANPJFBNO([HDMGOABMPFL(null)] OPDGNGBHFPA KCMBEIBOMMA, [HDMGOABMPFL(null)] EBCAEAKKOMA EPFBFGOONKG, [HDMGOABMPFL(null)] CAEMJJLHFME FMNFHIFKELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6422B90", Offset = "0x6421990", VA = "0x186422B90", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x64235D0", Offset = "0x64223D0", VA = "0x1864235D0")]
	private void GMGIDGLEGNJ(IEnumerable<JPCNNOFHCJE> MFBAMMGHJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6422110", Offset = "0x6420F10", VA = "0x186422110", Slot = "12")]
	public bool AJICBLLLIJA(ECDFOCMBGHG KAFKHLPGHBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x64273F0", Offset = "0x64261F0", VA = "0x1864273F0")]
	private void PIPPNBBAOOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6422CB0", Offset = "0x6421AB0", VA = "0x186422CB0")]
	private void FCOPFNPAIAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x64225B0", Offset = "0x64213B0", VA = "0x1864225B0", Slot = "10")]
	public IReadOnlyList<BOKDCICMMEL> BKBJNFFJOPK(bool MCNCIJDHJHL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6424250", Offset = "0x6423050", VA = "0x186424250", Slot = "11")]
	public BOKDCICMMEL HCGNCGNAOMF(ECDFOCMBGHG KAFKHLPGHBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6422630", Offset = "0x6421430", VA = "0x186422630")]
	private GBHHNOAKMKO BOCELNEBNHC(ECDFOCMBGHG KAFKHLPGHBP)
	{
		return default(GBHHNOAKMKO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6423DC0", Offset = "0x6422BC0", VA = "0x186423DC0", Slot = "14")]
	public bool GOFEJGHBCKN(ECDFOCMBGHG LEHEHBOPPJP, GBHHNOAKMKO HJJHNKMMFHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x64221E0", Offset = "0x6420FE0", VA = "0x1864221E0", Slot = "15")]
	public BOKDCICMMEL ALJFPEDMFDD(GBHHNOAKMKO HJJHNKMMFHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6423210", Offset = "0x6422010", VA = "0x186423210")]
	private static bool GDADNPHJPFK(OCAHMLCKBNC CKBGDHIIADD, GBHHNOAKMKO HJJHNKMMFHE, out HGGMFILLDHK? INKHOILFICH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6425620", Offset = "0x6424420", VA = "0x186425620")]
	private static void HMBLNPAINOB(OCAHMLCKBNC CKBGDHIIADD, Action<HGGMFILLDHK> MPADDDHNGOO, GBHHNOAKMKO DLIFAJNDJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6425420", Offset = "0x6424220", VA = "0x186425420")]
	private static void HMBLNPAINOB(OCAHMLCKBNC CKBGDHIIADD, Action<HGGMFILLDHK> MPADDDHNGOO, Predicate<GBHHNOAKMKO> GOEPMCPHPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6426010", Offset = "0x6424E10", VA = "0x186426010")]
	private void KJJLPLCMGPF(ECDFOCMBGHG KAFKHLPGHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6422A00", Offset = "0x6421800", VA = "0x186422A00", Slot = "4")]
	[AsyncStateMachine(typeof(LEOGGOBMNCJ))]
	public Task CIDDHLAHOKC([CanBeNull] CKGKBFGOMIH FHDHPJOAAEH, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
	public void EFNHKHGOECI(ref CKGKBFGOMIH FHDHPJOAAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6422FA0", Offset = "0x6421DA0", VA = "0x186422FA0")]
	private void GBJHPKNPKNC(OCAHMLCKBNC KOFENJLBHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6423F50", Offset = "0x6422D50", VA = "0x186423F50")]
	internal static string HABMGNMMECH(OPDGNGBHFPA DLPEOHNPLJM, CKGKBFGOMIH FHDHPJOAAEH, IReadOnlyDictionary<GBHHNOAKMKO, JPCNNOFHCJE> CLFOLJBFHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x64245C0", Offset = "0x64233C0", VA = "0x1864245C0")]
	private static void HLPJNIKHEMA(CKGKBFGOMIH FHDHPJOAAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x64226F0", Offset = "0x64214F0", VA = "0x1864226F0")]
	private static void CGDHEHFJCEN(OCAHMLCKBNC PGABKBNMLHF, IReadOnlyDictionary<GBHHNOAKMKO, JPCNNOFHCJE> CLFOLJBFHBB, StringBuilder KGHNNFGMAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6422E40", Offset = "0x6421C40", VA = "0x186422E40")]
	private static bool FJJDHOJACCM(string DPADAELPLHA, out Guid GHODEMFGLBB, out GBHHNOAKMKO HJJHNKMMFHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6426A80", Offset = "0x6425880", VA = "0x186426A80")]
	private static void LKFCNGIIJDL(CKGKBFGOMIH FHDHPJOAAEH, StringBuilder KGHNNFGMAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x22A6F20", Offset = "0x22A5D20", VA = "0x1822A6F20", Slot = "16")]
	public bool GPNJPBPIHGC<T>(GBHHNOAKMKO HJJHNKMMFHE, CLNCHNMHJOB JJAHHIEFMGP, bool OICJFLOHMGK, T OHMLFHCAJEC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6425720", Offset = "0x6424520", VA = "0x186425720")]
	private void JHEDMMHKFFO(GBHHNOAKMKO HJJHNKMMFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6425E90", Offset = "0x6424C90", VA = "0x186425E90")]
	private bool JNNNMMDEDEE(ECDFOCMBGHG KAFKHLPGHBP, GBHHNOAKMKO HJJHNKMMFHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6422290", Offset = "0x6421090", VA = "0x186422290")]
	internal JPCNNOFHCJE BAACPCHBFIB(ECDFOCMBGHG KAFKHLPGHBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6422CA0", Offset = "0x6421AA0", VA = "0x186422CA0", Slot = "13")]
	public IReadOnlyList<BOKDCICMMEL> EIPOCFGNBNO(ECDFOCMBGHG KAFKHLPGHBP, bool DECPIMICKGF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6425C70", Offset = "0x6424A70", VA = "0x186425C70")]
	internal IReadOnlyList<JPCNNOFHCJE> JHHCDFBPDJJ(ECDFOCMBGHG KAFKHLPGHBP, bool DECPIMICKGF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6426340", Offset = "0x6425140", VA = "0x186426340")]
	private void LGNDJPHHAHC(IMPEIHAIOLA PIDMPGAMIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6427100", Offset = "0x6425F00", VA = "0x186427100")]
	private static bool PAOHANFLCOJ(JPCNNOFHCJE GCEMDGEMMGD, IReadOnlyDictionary<GBHHNOAKMKO, JPCNNOFHCJE> CLFOLJBFHBB, out IReadOnlyList<CLNCHNMHJOB> PJCKDLEDHBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6425EB0", Offset = "0x6424CB0", VA = "0x186425EB0")]
	[AsyncStateMachine(typeof(DHPGEGOEANK))]
	private static Task KEIEGDIEJGC(OPDGNGBHFPA DLPEOHNPLJM, CKGKBFGOMIH FHDHPJOAAEH, IReadOnlyDictionary<GBHHNOAKMKO, JPCNNOFHCJE> CLFOLJBFHBB, CAEMJJLHFME FMNFHIFKELP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6426070", Offset = "0x6424E70", VA = "0x186426070")]
	[CompilerGenerated]
	internal static void KLGIIMKPCGJ(Func<HGGMFILLDHK, LDONKFFCEMB> NCJFLEJCDFC, ref PANMADCDJFB P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x64258E0", Offset = "0x64246E0", VA = "0x1864258E0")]
	[CompilerGenerated]
	internal static bool JHFGGMDHNAH(GBHHNOAKMKO HJJHNKMMFHE, CLNCHNMHJOB JJAHHIEFMGP, out JNEOOOGHNOG KFAPDLHAABF, ref LMCGILMLACA P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface LBOEHJADCAA
{
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BNGLDGPBDPL(ECDFOCMBGHG IIEMMBOJBOA, ECDFOCMBGHG BLNJHOIGHDE, IEnumerable<ECDFOCMBGHG> BDLFDKBOFIG, out FLJCBOEBAOK CEDDPGBGKMA, out ONHHAPFLLGH BECPCNGAELF);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum ONHHAPFLLGH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	CantKickEventOrganizer
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class IHIABEIHDFB : LBOEHJADCAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly CHNCKMGOLMI MLKNDOAAEOM;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x740F40", Offset = "0x73FD40", VA = "0x180740F40")]
	[RecRoom.NoEngine.Common.Preserve]
	public IHIABEIHDFB([HDMGOABMPFL(null)] CHNCKMGOLMI HADFNHKHDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6429F40", Offset = "0x6428D40", VA = "0x186429F40")]
	private static KHDKOOBDMFC? PJECOGEDHKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6429920", Offset = "0x6428720", VA = "0x186429920", Slot = "4")]
	public bool BNGLDGPBDPL(ECDFOCMBGHG IIEMMBOJBOA, ECDFOCMBGHG BLNJHOIGHDE, IEnumerable<ECDFOCMBGHG> BDLFDKBOFIG, out FLJCBOEBAOK CEDDPGBGKMA, out ONHHAPFLLGH BECPCNGAELF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6429A30", Offset = "0x6428830", VA = "0x186429A30")]
	internal bool KDEDOKIKLPB(ECDFOCMBGHG IIEMMBOJBOA, ECDFOCMBGHG BLNJHOIGHDE, IEnumerable<ECDFOCMBGHG> BDLFDKBOFIG, PGKHPCCBDIC DIPFHONDAKO, KHDKOOBDMFC? CMBJJONDKBK, out FLJCBOEBAOK CEDDPGBGKMA, out ONHHAPFLLGH BECPCNGAELF)
	{
		return default(bool);
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
