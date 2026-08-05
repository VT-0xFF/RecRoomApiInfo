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
		[Cpp2IlInjected.Address(RVA = "0x87C5D0", Offset = "0x87B7D0", VA = "0x18087C5D0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7003F90", Offset = "0x7003190", VA = "0x187003F90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87D8D0", Offset = "0x87CAD0", VA = "0x18087D8D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87D910", Offset = "0x87CB10", VA = "0x18087D910")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum KFDAAEJHOIK
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void HLNFNJJFOMP<TPermission>(TPermission LBBAFDBAMHN);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void INPMAEPPHGA(LCMANADAOPN DAFEONGKMPP);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum BABHADNFDPB
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CKBOGDIPEOM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MIOKKOGDLBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool IPGEMEJENNL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool FBHJJOAMCHP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool OBKJHJLBJPL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool LOLCGJNODJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool DALEFEHFMKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class KLEBLDJJFIN
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum FMHJACPMAMD
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		AG_EVERYONE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		AG_CREATOR = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		AG_COOWNER = 0x400000,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		AG_HOST = 0x800000,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		AG_MODERATOR = 0x1000000
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Guid JNHGMKHCGPK;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid IDOEPLHGDHK;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid LAGEGKJDPHK;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid DKBIDGBJLKL;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid DMGEGGDJMGH;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid OAPALIOADBF;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly NOGDILHKBGL<JLMLCKPCLMI, Guid> MGPDOAGFGCD;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<JLMLCKPCLMI> ANGHBECLCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7000670", Offset = "0x6FFF870", VA = "0x187000670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x70008B0", Offset = "0x6FFFAB0", VA = "0x1870008B0")]
	public static JLMLCKPCLMI MHIDNKLLJNC(Guid BMIGIGGJPJD)
	{
		return default(JLMLCKPCLMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x70005D0", Offset = "0x6FFF7D0", VA = "0x1870005D0")]
	public static Guid ANFFBIKDBOI(JLMLCKPCLMI LEGCEEOPFPG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7000820", Offset = "0x6FFFA20", VA = "0x187000820")]
	public static bool KPFDKOGBIHA(JLMLCKPCLMI LEGCEEOPFPG, [Out] Guid BMIGIGGJPJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7000940", Offset = "0x6FFFB40", VA = "0x187000940")]
	public static bool OFBHMMBCKEL(Guid BMIGIGGJPJD, [Out] JLMLCKPCLMI LEGCEEOPFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x70006F0", Offset = "0x6FFF8F0", VA = "0x1870006F0")]
	public static JLMLCKPCLMI EJKPJLADPCP(JLMLCKPCLMI LEGCEEOPFPG)
	{
		return default(JLMLCKPCLMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7000770", Offset = "0x6FFF970", VA = "0x187000770")]
	public static FMHJACPMAMD IAAHOLIBKDL(JLMLCKPCLMI IANHMHBJIPJ)
	{
		return default(FMHJACPMAMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7000730", Offset = "0x6FFF930", VA = "0x187000730")]
	internal static JLMLCKPCLMI FFDKOPLHOEJ(FMHJACPMAMD ANPGKIMELDM)
	{
		return default(JLMLCKPCLMI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BJBNLDKHHPB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	EDLLFKDNJBB PNOGICHHCGL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<NBPJEAJBCGD> ABINJGGHCKA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event INPMAEPPHGA NCJCPJBLHOK;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<NBPJEAJBCGD> EJJGGDIFICJ(bool GFCGMJBJFKK = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NBPJEAJBCGD IKCEHOLDNBN(LCMANADAOPN DAFEONGKMPP);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CAFNFEKLJIE(LCMANADAOPN DAFEONGKMPP);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<NBPJEAJBCGD> GABHENNJBDC(LCMANADAOPN DAFEONGKMPP, bool MFGOAJAJMPD = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GAKMFOGBHOH(LCMANADAOPN ADKHALPCMBJ, JLMLCKPCLMI LEGCEEOPFPG);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NBPJEAJBCGD FJEPDLIEFFH(JLMLCKPCLMI LEGCEEOPFPG);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool GFKEOAHHLDM<T>(JLMLCKPCLMI LEGCEEOPFPG, NNJKJAPPKKB LBBAFDBAMHN, bool GPAACDKKHMD, T BGLHKLFFJEP, [Optional] Action FCNHMPPCFLC) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string ABEJGAALGCK(NNJKJAPPKKB LBBAFDBAMHN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MMIMHPEHMOP
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CEEOMKDIIFG(CKJAAMAMPKA FCMADEBOIJK, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ABMLPHBIJBM(CKJAAMAMPKA FCMADEBOIJK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IJFOLJGNHMF
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	LCMANADAOPN BNIDNLLDGDI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	MDBDBMHCDOA BDKFDNIDKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	FLKIEPIEFEG NMFKMAELONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<PFFOGOPOBIO> BPOEENOMIDF;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action IHJPIEOPCGF;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JLMLCKPCLMI CNKEKFFKAKP(LCMANADAOPN DAFEONGKMPP);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<PFFOGOPOBIO> PLDMFMNCLGK(CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task ONJJMBIEHEO(long DIMOGDCMBFM, IReadOnlyList<KJDDJKLEEEG> BPCOACGGLLJ);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task JCLDDJHCDLN(long DIMOGDCMBFM, long KJMNNDODHCP, IReadOnlyList<KJDDJKLEEEG> BPCOACGGLLJ);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<LCMANADAOPN> KKOEFMBJEIN();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GGGBJJKBECG
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x70001A0", Offset = "0x6FFF3A0", VA = "0x1870001A0")]
	public static JLMLCKPCLMI CPJLIFNABGK(this IJFOLJGNHMF MMCNPBHLGKE)
	{
		return default(JLMLCKPCLMI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KOHKCMDJBJH<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string ILPLAFGNLKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event HLNFNJJFOMP<TPermission> MPHILHBILDJ;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class EPJDEOLLKJI
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? BLLMBFEAAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x852300", VA = "0x180853100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8530F0", Offset = "0x8522F0", VA = "0x1808530F0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x8523E0", VA = "0x1808531E0")]
	protected EPJDEOLLKJI(object? MODBAODNOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool HEOMLDPCKGB(object? JMDCGOKJIDA);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class JJKAEJKBKPN<T> : EPJDEOLLKJI where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T IMEKDGPKKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> BPPCHPJNELP;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T JNHPIMBJPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x920B50", Offset = "0x91FD50", VA = "0x180920B50")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x40B9360", Offset = "0x40B8560", VA = "0x1840B9360", Slot = "4")]
	public override bool HEOMLDPCKGB(object? JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x40B8F30", Offset = "0x40B8130", VA = "0x1840B8F30")]
	public bool DKMKFFDIAFH(T GOANLDEALHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x40B98D0", Offset = "0x40B8AD0", VA = "0x1840B98D0")]
	public JJKAEJKBKPN(T LIAHLPBCKNO, IEqualityComparer<T> BPPCHPJNELP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class AEDJPCMBMAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<NNJKJAPPKKB, bool> PMKOACKLCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<NNJKJAPPKKB, EPJDEOLLKJI> JKOFNNBHNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly DBIDKPEKFNO EHMIOADHOMD;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7200", Offset = "0x6FF6400", VA = "0x186FF7200")]
	public AEDJPCMBMAC(DBIDKPEKFNO EHMIOADHOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6FF70B0", Offset = "0x6FF62B0", VA = "0x186FF70B0")]
	public bool OLBGPBEHFHO(NNJKJAPPKKB LBBAFDBAMHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x31DBFE0", Offset = "0x31DB1E0", VA = "0x1831DBFE0")]
	public bool POBBBOFIELN<T>(NNJKJAPPKKB LBBAFDBAMHN, bool GPAACDKKHMD, T JMDCGOKJIDA) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x31DBAE0", Offset = "0x31DACE0", VA = "0x1831DBAE0")]
	public (bool, T?) INEOFLHFOBI<T>(NNJKJAPPKKB LBBAFDBAMHN) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7120", Offset = "0x6FF6320", VA = "0x186FF7120")]
	public bool POBBBOFIELN(NNJKJAPPKKB LBBAFDBAMHN, bool GPAACDKKHMD, object JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6FE0", Offset = "0x6FF61E0", VA = "0x186FF6FE0")]
	public (bool, object) INEOFLHFOBI(NNJKJAPPKKB LBBAFDBAMHN)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x31DBF80", Offset = "0x31DB180", VA = "0x1831DBF80")]
	private void LHIFPKKHIDL<T>(NNJKJAPPKKB LBBAFDBAMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6F10", Offset = "0x6FF6110", VA = "0x186FF6F10")]
	private EPJDEOLLKJI ILLFKKNNFCB(NNJKJAPPKKB LBBAFDBAMHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6D20", Offset = "0x6FF5F20", VA = "0x186FF6D20")]
	public void BNMBEIANNDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class FFFMGAGOJHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string BKMLLKACEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type CEOCGCEOOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly OECEMKHIMNF IAAAKKMDCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly NNJKJAPPKKB GPAEJNNJFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ALIJFCGLCDJ MIJJFAHLFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public OLANPCGBGOF HMNKJLIAJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public KOOJGMGEDNL OGGOKALENCA;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7000100", Offset = "0x6FFF300", VA = "0x187000100")]
	public FFFMGAGOJHE(Type OBANPAAALLK, string HNFJBCFMDLN, NNJKJAPPKKB LBBAFDBAMHN, ALIJFCGLCDJ AKGCBEJLIPG, OLANPCGBGOF FKCHLNPGHHA, KOOJGMGEDNL DFCHOMLFPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7000000", Offset = "0x6FFF200", VA = "0x187000000")]
	public object AJHMPHHMGPJ(object? OKGBBGMIACH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2B1EF60", Offset = "0x2B1E160", VA = "0x182B1EF60")]
	public void LHIFPKKHIDL<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7000050", Offset = "0x6FFF250", VA = "0x187000050")]
	public void LHIFPKKHIDL(Type NEFMPOGCBJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class IJCFNHHDHEA<T> : FFFMGAGOJHE where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string CLEFPDHLLIN(T JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T BGOFIFPJNLB(string? POHDNIDPMOG, T LIAHLPBCKNO);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class EGLJKPBOOMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public CLEFPDHLLIN serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public BGOFIFPJNLB parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public EGLJKPBOOMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x37F37B0", Offset = "0x37F29B0", VA = "0x1837F37B0")]
		internal string GJADKLJHKOE(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x37F37F0", Offset = "0x37F29F0", VA = "0x1837F37F0")]
		internal object MELGEIOFEDA(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3E79370", Offset = "0x3E78570", VA = "0x183E79370")]
	public IJCFNHHDHEA(NNJKJAPPKKB LBBAFDBAMHN, string HNFJBCFMDLN, [Optional] CLEFPDHLLIN? AKGCBEJLIPG, [Optional] BGOFIFPJNLB? FKCHLNPGHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3E78200", Offset = "0x3E77400", VA = "0x183E78200")]
	private static object? DGBBAPGEGII(BGOFIFPJNLB? FKCHLNPGHHA, string? POHDNIDPMOG, object? LIAHLPBCKNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3E78A70", Offset = "0x3E77C70", VA = "0x183E78A70")]
	private static string OPCGAJMHMBL(CLEFPDHLLIN? IEFGOCBLBOC, object? JMDCGOKJIDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string ALIJFCGLCDJ(object? JMDCGOKJIDA);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object OLANPCGBGOF(string? POHDNIDPMOG, [Optional] object LIAHLPBCKNO);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate EPJDEOLLKJI KOOJGMGEDNL();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class DBIDKPEKFNO
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class LANMLIDHDDL : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static LANMLIDHDDL MJFJCBEEADM;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7000D00", Offset = "0x6FFFF00", VA = "0x187000D00", Slot = "4")]
		public bool Equals(List<string> IPBJLCONKPC, List<string> FACAKAOOAJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7000E50", Offset = "0x7000050", VA = "0x187000E50", Slot = "5")]
		public int GetHashCode(List<string> MEAFIMADMKA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public LANMLIDHDDL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class JDAMGDBGLJH : EKNAHBLPAGA<KFDAAEJHOIK>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7000470", Offset = "0x6FFF670", VA = "0x187000470", Slot = "9")]
		public override string OPCGAJMHMBL(KFDAAEJHOIK PMPNIONIFNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7000290", Offset = "0x6FFF490", VA = "0x187000290", Slot = "10")]
		protected override bool JBCDMHLEPOM(string PMPNIONIFNI, [Out] KFDAAEJHOIK JMDCGOKJIDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7000560", Offset = "0x6FFF760", VA = "0x187000560")]
		public JDAMGDBGLJH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly MBJPPCADNOA LLKNFELAHBO;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly JDAMGDBGLJH MPLMPNIJNHA;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<FFFMGAGOJHE> DDHJBNEOEBN;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<NNJKJAPPKKB> FJPECBKFCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x852300", VA = "0x180853100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<NNJKJAPPKKB, FFFMGAGOJHE> EKGNNKNNGDH
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF460", Offset = "0x6FFE660", VA = "0x186FFF460")]
	public DBIDKPEKFNO([Optional] IList<FFFMGAGOJHE>? MPKCJGEJJAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6FFDF40", Offset = "0x6FFD140", VA = "0x186FFDF40")]
	public FFFMGAGOJHE NAKMCJFFKDM(NNJKJAPPKKB LBBAFDBAMHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface EDLLFKDNJBB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NBPJEAJBCGD PEMHFCGBLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class CKIMJEEOBJE : EDLLFKDNJBB
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static CKIMJEEOBJE PINHEAJLKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly MMJFOLNBHJK IGKMDGBAPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<MMJFOLNBHJK> HCAOAAJONAP;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public NBPJEAJBCGD PEMHFCGBLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x852300", VA = "0x180853100", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6FFDE20", Offset = "0x6FFD020", VA = "0x186FFDE20")]
	public CKIMJEEOBJE(MMJFOLNBHJK CMNMFKNLBMI, IReadOnlyList<MMJFOLNBHJK> LOIGBPCAOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6FFCFD0", Offset = "0x6FFC1D0", VA = "0x186FFCFD0")]
	private static CKIMJEEOBJE COPCNDNMDIA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class ACFPCADCBJA
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<JLMLCKPCLMI> IHFNNLPJPBK;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6A90", Offset = "0x6FF5C90", VA = "0x186FF6A90")]
	public static bool LEMKCFBDNIO(this LCMANADAOPN GFABMNOLKLL, JLMLCKPCLMI LEGCEEOPFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6A10", Offset = "0x6FF5C10", VA = "0x186FF6A10")]
	public static bool GFMHKIJFIGA(this LCMANADAOPN GFABMNOLKLL, JLMLCKPCLMI LEGCEEOPFPG, FLKIEPIEFEG MGNEMJNJPBC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface DILJHPIDAIO
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool DIIHALFMMCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool GGJHOPIAGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool BBPINHFIJFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool PPELCJBLLFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool OCMIOJOGEEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MKHOPJPMMFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool LLBGJCPFFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool ACIHDGNIAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool GMOFHMIIHKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool NNGPAMOGGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool NGDOANLFAHA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool JAOJGKKCGNK
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> GFDLBKLFJLK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	KFDAAEJHOIK DDNEENPIBMM
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface NBPJEAJBCGD : DILJHPIDAIO, CKBOGDIPEOM, KOHKCMDJBJH<NNJKJAPPKKB>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string DFBKHJHKMIP
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	JLMLCKPCLMI AKCNEADCMAD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) IOGAACKGDCN<T>(NNJKJAPPKKB LBBAFDBAMHN) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum NNJKJAPPKKB
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	CAN_EDIT_ROOM_ROLES = 1,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	VOTE_KICK_PERMISSION = 3,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CAN_INVITE = 4,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CAN_TALK = 6,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CAN_PRINT_PHOTOS = 7,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CAN_START_GAMES = 8,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	CAN_SELF_REVIVE = 9,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	AUTO_ASSIGNED_GAME_ROLES = 11,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CAN_CHANGE_GAME_MODE = 12,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CAN_USE_MAKER_PEN = 13,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CAN_USE_DELETE_ALL_BUTTON = 14,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CAN_SAVE_INVENTIONS = 15,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	DISABLE_MIC_AUTO_MUTE = 16,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CAN_END_GAMES_EARLY = 17,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	CAN_USE_SHARE_CAM = 18,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	DEPRECATED_CAN_EDIT_CIRCUITS = 19,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	CAN_SPAWN_INVENTIONS = 20,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CAN_SPAWN_CONSUMABLES = 21,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CAN_USE_ROOM_RESET_BUTTON = 22,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	AUTO_ASSIGNED_PLAYER_TAGS = 24,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	CAN_USE_RRS = 25,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	ROOM_LEVEL_THRESHOLD = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	CAN_SAVE_ROOM = 1001,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CAN_PUBLISH_ROOM = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CAN_CLONE_ROOM = 1003,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CAN_RESTORE_ROOM = 1004,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CAN_EDIT_MAIN_ROOM_SETTINGS = 1006,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CAN_EDIT_ROOM_ECON_SETTINGS = 1007,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	CAN_CREATE_SUBROOMS = 1008,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CAN_NAME_SUBROOMS = 1009,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	CAN_CLONE_SUBROOMS = 1010,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CAN_MOVE_SUBROOMS = 1011,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	CAN_DELETE_SUBROOMS = 1012,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	CAN_EDIT_SUBROOM_SETTINGS = 1013,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CAN_RESET_CLOUD_VARIABLES = 1014,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	CAN_DELETE_CLOUD_VARIABLES = 1015,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	CAN_EDIT_ROOM_PROGRESSION = 1016,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	CAN_REMOVE_ROOM_BANS = 1017,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	CAN_ADD_ROOM_BANS = 1018
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class MMJFOLNBHJK : NBPJEAJBCGD, DILJHPIDAIO, CKBOGDIPEOM, KOHKCMDJBJH<NNJKJAPPKKB>
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal static readonly DBIDKPEKFNO BIJLJOANKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal readonly AEDJPCMBMAC DGBNPMLDHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? ENJCEPBNKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string? BKFFILJLGHH;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool OMJFCAOBPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x70039D0", Offset = "0x7002BD0", VA = "0x1870039D0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool CCKKLPPPGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7002870", Offset = "0x7001A70", VA = "0x187002870", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool EAGJIFBMJLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7002E00", Offset = "0x7002000", VA = "0x187002E00", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool BDGMNLNOBNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7003980", Offset = "0x7002B80", VA = "0x187003980", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool GBNBFICLPMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7002DB0", Offset = "0x7001FB0", VA = "0x187002DB0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool ACMBFIIHJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7002B40", Offset = "0x7001D40", VA = "0x187002B40", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public JLMLCKPCLMI AKCNEADCMAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x920B50", Offset = "0x91FD50", VA = "0x180920B50", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(JLMLCKPCLMI);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x854CE0", Offset = "0x853EE0", VA = "0x180854CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string ILPLAFGNLKN
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7002E50", Offset = "0x7002050", VA = "0x187002E50", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7001DB0", Offset = "0x7000FB0", VA = "0x187001DB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string DFBKHJHKMIP
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7002E50", Offset = "0x7002050", VA = "0x187002E50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool MOHHIMLABLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9E24F0", Offset = "0x9E16F0", VA = "0x1809E24F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9E19F0", Offset = "0x9E0BF0", VA = "0x1809E19F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool DIIHALFMMCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7003460", Offset = "0x7002660", VA = "0x187003460", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public KFDAAEJHOIK DDNEENPIBMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7002780", Offset = "0x7001980", VA = "0x187002780", Slot = "20")]
		get
		{
			return default(KFDAAEJHOIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool GGJHOPIAGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7003C80", Offset = "0x7002E80", VA = "0x187003C80", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool BBPINHFIJFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7002EA0", Offset = "0x70020A0", VA = "0x187002EA0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool PPELCJBLLFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7003B00", Offset = "0x7002D00", VA = "0x187003B00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool OCMIOJOGEEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7003BE0", Offset = "0x7002DE0", VA = "0x187003BE0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool MKHOPJPMMFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7003410", Offset = "0x7002610", VA = "0x187003410", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool LLBGJCPFFEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x70034B0", Offset = "0x70026B0", VA = "0x1870034B0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool ACIHDGNIAMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7003500", Offset = "0x7002700", VA = "0x187003500", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool GMOFHMIIHKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7002820", Offset = "0x7001A20", VA = "0x187002820", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> GFDLBKLFJLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x70028C0", Offset = "0x7001AC0", VA = "0x1870028C0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool AKKGKCJAOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x70039D0", Offset = "0x7002BD0", VA = "0x1870039D0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool EIBKCDDINHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7002DB0", Offset = "0x7001FB0", VA = "0x187002DB0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool BINLENMIKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7002870", Offset = "0x7001A70", VA = "0x187002870", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool NNGPAMOGGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7002D60", Offset = "0x7001F60", VA = "0x187002D60", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool NGDOANLFAHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x70027D0", Offset = "0x70019D0", VA = "0x1870027D0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool AAHKHPCBNDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7002E00", Offset = "0x7002000", VA = "0x187002E00", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool JAOJGKKCGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7003C30", Offset = "0x7002E30", VA = "0x187003C30", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool GHPFOEIDLFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7003980", Offset = "0x7002B80", VA = "0x187003980", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool JNMHDOJGKIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7002B40", Offset = "0x7001D40", VA = "0x187002B40", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event HLNFNJJFOMP<NNJKJAPPKKB> MPHILHBILDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7003550", Offset = "0x7002750", VA = "0x187003550", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7002EF0", Offset = "0x70020F0", VA = "0x187002EF0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2C3FB30", Offset = "0x2C3ED30", VA = "0x182C3FB30", Slot = "6")]
	public (bool, T?) IOGAACKGDCN<T>(NNJKJAPPKKB LBBAFDBAMHN) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2C3FAD0", Offset = "0x2C3ECD0", VA = "0x182C3FAD0")]
	public MMJFOLNBHJK ABKDLJBBNLF<T>(NNJKJAPPKKB LBBAFDBAMHN, bool GPAACDKKHMD, T JMDCGOKJIDA) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7003EE0", Offset = "0x70030E0", VA = "0x187003EE0")]
	public MMJFOLNBHJK(JLMLCKPCLMI LEGCEEOPFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7003D60", Offset = "0x7002F60", VA = "0x187003D60")]
	public MMJFOLNBHJK(JLMLCKPCLMI LEGCEEOPFPG, [Optional] string? ENJCEPBNKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7003F00", Offset = "0x7003100", VA = "0x187003F00")]
	public MMJFOLNBHJK(MMJFOLNBHJK BAANMENLIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7003D80", Offset = "0x7002F80", VA = "0x187003D80")]
	internal MMJFOLNBHJK(JLMLCKPCLMI BDKDIKEADOB, [Optional] string? ENJCEPBNKEP, [Optional] MMJFOLNBHJK? BAANMENLIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7002B90", Offset = "0x7001D90", VA = "0x187002B90")]
	public static OECEMKHIMNF EDDKIFCFKHC(NNJKJAPPKKB LBBAFDBAMHN)
	{
		return default(OECEMKHIMNF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7002B20", Offset = "0x7001D20", VA = "0x187002B20")]
	public void BNMBEIANNDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7003600", Offset = "0x7002800", VA = "0x187003600")]
	internal MMJFOLNBHJK MINGFKCBMBL(MMJFOLNBHJK PPALKBLAIBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7002FA0", Offset = "0x70021A0", VA = "0x187002FA0")]
	internal IReadOnlyCollection<NNJKJAPPKKB> JGFBHDIGANM(MMJFOLNBHJK BAANMENLIKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7003A20", Offset = "0x7002C20", VA = "0x187003A20")]
	public bool MNIALEGHGDJ(NNJKJAPPKKB LBBAFDBAMHN, bool GPAACDKKHMD, string NKMDGJHDJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7002C10", Offset = "0x7001E10", VA = "0x187002C10")]
	public (bool, string) FLICPDKKJBG(NNJKJAPPKKB LBBAFDBAMHN)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7002D10", Offset = "0x7001F10", VA = "0x187002D10")]
	internal void FNCHLEGMJDK(NNJKJAPPKKB LBBAFDBAMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7002920", Offset = "0x7001B20", VA = "0x187002920")]
	public MCBAIIFBGIA BNBHIEMPECA(Func<JLMLCKPCLMI, Guid> IDEOHNPNNFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7001E00", Offset = "0x7001000", VA = "0x187001E00")]
	public void ANDOCNFIHMK(MCBAIIFBGIA HHNIDJIMOBE, Func<Guid, JLMLCKPCLMI> PHDBLGDMGJO, [Optional] JLMLCKPCLMI? MJCDCBAGLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7003B50", Offset = "0x7002D50", VA = "0x187003B50")]
	[CompilerGenerated]
	private void OHNPFNFDFJI(NNJKJAPPKKB KLEIKJLFJPA, PKKEFCMBKBD FCIIBMDEFGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class BLEEBOEIFKN : MMIMHPEHMOP, BJBNLDKHHPB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class KLCKBCNEBEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public MMJFOLNBHJK newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public KLCKBCNEBEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x70005A0", Offset = "0x6FFF7A0", VA = "0x1870005A0")]
		internal bool ONCBHNIOGLH(MMJFOLNBHJK rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class DBBDCKGHJGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public JLMLCKPCLMI roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public DBBDCKGHJGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6FFDF30", Offset = "0x6FFD130", VA = "0x186FFDF30")]
		internal bool NGNLKMCNENC(JLMLCKPCLMI r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct PJEIDNEIDDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public BLEEBOEIFKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CKJAAMAMPKA roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<PFFOGOPOBIO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7004010", Offset = "0x7003210", VA = "0x187004010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7004680", Offset = "0x7003880", VA = "0x187004680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class LPELJMJMLCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public LPELJMJMLCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7001BB0", Offset = "0x7000DB0", VA = "0x187001BB0")]
		internal void CAEMPGFFIGK(MCBAIIFBGIA r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7001C90", Offset = "0x7000E90", VA = "0x187001C90")]
		internal void EPPPGLAHCOI(MCBAIIFBGIA r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct OIFLBINNLCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public CKJAAMAMPKA roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class HBHDNDLNLAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Func<MCBAIIFBGIA, PKKEFCMBKBD> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public HBHDNDLNLAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7000200", Offset = "0x6FFF400", VA = "0x187000200")]
		internal void IPCAGIAHPBI(MCBAIIFBGIA r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7000230", Offset = "0x6FFF430", VA = "0x187000230")]
		internal void KMAHAOFFAKC(MCBAIIFBGIA r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7000260", Offset = "0x6FFF460", VA = "0x187000260")]
		internal void KPDDKOPIFFB(MCBAIIFBGIA r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class IBICDOJKBMI<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public IBICDOJKBMI<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private TaskAwaiter<PFFOGOPOBIO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x357A800", Offset = "0x3579A00", VA = "0x18357A800", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x9EC1C0", Offset = "0x9EB3C0", VA = "0x1809EC1C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public NNJKJAPPKKB rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public JLMLCKPCLMI accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public OECEMKHIMNF recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public BLEEBOEIFKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public IBICDOJKBMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3E2F330", Offset = "0x3E2E530", VA = "0x183E2F330")]
		[AsyncStateMachine(typeof(IBICDOJKBMI<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void NNJGHKPPDLO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct FOMHKFLDNEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public IReadOnlyList<KJDDJKLEEEG> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct LDMIIPLEECO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public IJFOLJGNHMF rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CKJAAMAMPKA roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public IReadOnlyDictionary<JLMLCKPCLMI, MMJFOLNBHJK> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public DJDPNNJEBNN debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7001040", Offset = "0x7000240", VA = "0x187001040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7001B50", Offset = "0x7000D50", VA = "0x187001B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly IJFOLJGNHMF MMCNPBHLGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly CKIMJEEOBJE LIPOPBBILIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly DJDPNNJEBNN LNBHAPEOGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<int, MMJFOLNBHJK> AMDLIJKIKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<JLMLCKPCLMI, MMJFOLNBHJK> KMJBMJFJKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly Dictionary<JLMLCKPCLMI, MMJFOLNBHJK> KIKJOKJBNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	internal readonly List<MMJFOLNBHJK> KKLEFMDJDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private bool GCLJOOHCGHJ;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly NNJKJAPPKKB[] MECJEJMDKBI;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public EDLLFKDNJBB PNOGICHHCGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<NBPJEAJBCGD> ABINJGGHCKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6FFC900", Offset = "0x6FFBB00", VA = "0x186FFC900", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event INPMAEPPHGA NCJCPJBLHOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8610", Offset = "0x6FF7810", VA = "0x186FF8610", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6FF9C50", Offset = "0x6FF8E50", VA = "0x186FF9C50", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6FF86B0", Offset = "0x6FF78B0", VA = "0x186FF86B0")]
	[GDGALFJPCGE(JAFPILLCEJB.Room, JMIPDAHBNNG.None)]
	private static void ECBJKBNABGH(INCIOHANCNE LDLMDJOAIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6FFCD10", Offset = "0x6FFBF10", VA = "0x186FFCD10")]
	[UnityEngine.Scripting.Preserve]
	internal BLEEBOEIFKN([OMAPKKAGFIL(null)] IJFOLJGNHMF HKFJOLJDDID, [OMAPKKAGFIL(null)] CKIMJEEOBJE CFNAIDOIMGH, [OMAPKKAGFIL(null)] DJDPNNJEBNN LNBHAPEOGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8500", Offset = "0x6FF7700", VA = "0x186FF8500", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9230", Offset = "0x6FF8430", VA = "0x186FF9230")]
	private void FPGLGCGPPLF(IEnumerable<MMJFOLNBHJK> AENBCCPKPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7A00", Offset = "0x6FF6C00", VA = "0x186FF7A00", Slot = "12")]
	public bool CAFNFEKLJIE(LCMANADAOPN DAFEONGKMPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAE90", Offset = "0x6FFA090", VA = "0x186FFAE90")]
	private void IHJPIEOPCGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6FFC950", Offset = "0x6FFBB50", VA = "0x186FFC950")]
	private void OHNLDHNNMIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8980", Offset = "0x6FF7B80", VA = "0x186FF8980", Slot = "10")]
	public IReadOnlyList<NBPJEAJBCGD> EJJGGDIFICJ(bool GFCGMJBJFKK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAEA0", Offset = "0x6FFA0A0", VA = "0x186FFAEA0", Slot = "11")]
	public NBPJEAJBCGD IKCEHOLDNBN(LCMANADAOPN DAFEONGKMPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8A00", Offset = "0x6FF7C00", VA = "0x186FF8A00")]
	private JLMLCKPCLMI ELMEJNDAGBH(LCMANADAOPN DAFEONGKMPP)
	{
		return default(JLMLCKPCLMI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9AC0", Offset = "0x6FF8CC0", VA = "0x186FF9AC0", Slot = "14")]
	public bool GAKMFOGBHOH(LCMANADAOPN ADKHALPCMBJ, JLMLCKPCLMI LEGCEEOPFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9190", Offset = "0x6FF8390", VA = "0x186FF9190", Slot = "15")]
	public NBPJEAJBCGD FJEPDLIEFFH(JLMLCKPCLMI LEGCEEOPFPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6FFBE40", Offset = "0x6FFB040", VA = "0x186FFBE40")]
	private static bool MCBNENPLMAO(LAHCFEDGJLH GPBDODNIBNL, JLMLCKPCLMI LEGCEEOPFPG, [Out] MCBAIIFBGIA? ECHNKHNFKGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8D60", Offset = "0x6FF7F60", VA = "0x186FF8D60")]
	private static void EMACEPGCNMC(LAHCFEDGJLH GPBDODNIBNL, Action<MCBAIIFBGIA> ELMLEDKBKOH, JLMLCKPCLMI ABAAKDKHIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8AD0", Offset = "0x6FF7CD0", VA = "0x186FF8AD0")]
	private static void EMACEPGCNMC(LAHCFEDGJLH GPBDODNIBNL, Action<MCBAIIFBGIA> ELMLEDKBKOH, Predicate<JLMLCKPCLMI> PDOAMMENCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8350", Offset = "0x6FF7550", VA = "0x186FF8350")]
	private void CNEPHAADCMP(LCMANADAOPN DAFEONGKMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8210", Offset = "0x6FF7410", VA = "0x186FF8210", Slot = "4")]
	[AsyncStateMachine(typeof(PJEIDNEIDDI))]
	public Task CEEOMKDIIFG([CanBeNull] CKJAAMAMPKA FCMADEBOIJK, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "5")]
	public void ABMLPHBIJBM(CKJAAMAMPKA FCMADEBOIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8E50", Offset = "0x6FF8050", VA = "0x186FF8E50")]
	private void FGNACMKPNNA(LAHCFEDGJLH MPDCPFCIIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6FFBB30", Offset = "0x6FFAD30", VA = "0x186FFBB30")]
	internal static string MAODFIEHDMP(IJFOLJGNHMF MMCNPBHLGKE, CKJAAMAMPKA FCMADEBOIJK, IReadOnlyDictionary<JLMLCKPCLMI, MMJFOLNBHJK> KMJBMJFJKDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6FFA060", Offset = "0x6FF9260", VA = "0x186FFA060")]
	private static void GPNILADJFPE(CKJAAMAMPKA FCMADEBOIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB7E0", Offset = "0x6FFA9E0", VA = "0x186FFB7E0")]
	private static void KEDLBGIMJHO(LAHCFEDGJLH APIPFNBMKIB, IReadOnlyDictionary<JLMLCKPCLMI, MMJFOLNBHJK> KMJBMJFJKDE, StringBuilder ABNJKDPEJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8870", Offset = "0x6FF7A70", VA = "0x186FF8870")]
	private static bool EIBKJGEKIGD(string ILEAALKOEBD, [Out] Guid DDPEHPGGDBN, [Out] JLMLCKPCLMI LEGCEEOPFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7AD0", Offset = "0x6FF6CD0", VA = "0x186FF7AD0")]
	private static void CDFLDFBMKKO(CKJAAMAMPKA FCMADEBOIJK, StringBuilder ABNJKDPEJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x28DA620", Offset = "0x28D9820", VA = "0x1828DA620", Slot = "16")]
	public bool GFKEOAHHLDM<T>(JLMLCKPCLMI LEGCEEOPFPG, NNJKJAPPKKB LBBAFDBAMHN, bool GPAACDKKHMD, T BGLHKLFFJEP, [Optional] Action FCNHMPPCFLC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6FF74B0", Offset = "0x6FF66B0", VA = "0x186FF74B0", Slot = "17")]
	public string ABEJGAALGCK(NNJKJAPPKKB LBBAFDBAMHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB290", Offset = "0x6FFA490", VA = "0x186FFB290")]
	private void JALBMMAIHOB(JLMLCKPCLMI LEGCEEOPFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8330", Offset = "0x6FF7530", VA = "0x186FF8330")]
	private bool CHLKNDBAMMB(LCMANADAOPN DAFEONGKMPP, JLMLCKPCLMI LEGCEEOPFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB4A0", Offset = "0x6FFA6A0", VA = "0x186FFB4A0")]
	internal MMJFOLNBHJK JEJHBEJBHDI(LCMANADAOPN DAFEONGKMPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9AB0", Offset = "0x6FF8CB0", VA = "0x186FF9AB0", Slot = "13")]
	public IReadOnlyList<NBPJEAJBCGD> GABHENNJBDC(LCMANADAOPN DAFEONGKMPP, bool MFGOAJAJMPD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6FF77D0", Offset = "0x6FF69D0", VA = "0x186FF77D0")]
	internal IReadOnlyList<MMJFOLNBHJK> AOAMHJGAHHK(LCMANADAOPN DAFEONGKMPP, bool MFGOAJAJMPD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6FFC170", Offset = "0x6FFB370", VA = "0x186FFC170")]
	private void MKLKLEKHPJD(PFFOGOPOBIO BDMEBIJJBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAFB0", Offset = "0x6FFA1B0", VA = "0x186FFAFB0")]
	private static bool ILEJMILBPGC(MMJFOLNBHJK LBBOONJILLL, IReadOnlyDictionary<JLMLCKPCLMI, MMJFOLNBHJK> KMJBMJFJKDE, [Out] IReadOnlyList<NNJKJAPPKKB> FHIJONPJBBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6FF83C0", Offset = "0x6FF75C0", VA = "0x186FF83C0")]
	[AsyncStateMachine(typeof(LDMIIPLEECO))]
	private static Task DKEFJJKAMCB(IJFOLJGNHMF MMCNPBHLGKE, CKJAAMAMPKA FCMADEBOIJK, IReadOnlyDictionary<JLMLCKPCLMI, MMJFOLNBHJK> KMJBMJFJKDE, DJDPNNJEBNN LNBHAPEOGDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7530", Offset = "0x6FF6730", VA = "0x186FF7530")]
	[CompilerGenerated]
	internal static void ACOLHKINFHN(Func<MCBAIIFBGIA, PKKEFCMBKBD> MOFANEOJHJJ, OIFLBINNLCJ P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9CF0", Offset = "0x6FF8EF0", VA = "0x186FF9CF0")]
	[CompilerGenerated]
	internal static bool GPLMEKHPOPM(JLMLCKPCLMI LEGCEEOPFPG, NNJKJAPPKKB LBBAFDBAMHN, [Out] KJDDJKLEEEG DEGMFPIFMCP, FOMHKFLDNEC P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface EGAKHOOOEGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BPCCMHDHJPE(LCMANADAOPN ANJMNLDAJPB, LCMANADAOPN KLDFODBCABD, IEnumerable<LCMANADAOPN> OMMKHMKEFEM, [Out] KFDAAEJHOIK NGCPBNHFHMM, [Out] IJNKNPGLGJP PJKEANDFMHI);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string HMFHHGJHKOH(IJNKNPGLGJP EBKJEDMNOIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum IJNKNPGLGJP : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class EKJPACEDNHG : EGAKHOOOEGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly BJBNLDKHHPB KPDJEDJHCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly PLNHHCCDECD DGHDIDAANKL;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x85F050", Offset = "0x85E250", VA = "0x18085F050")]
	[RecRoom.NoEngine.Common.Preserve]
	public EKJPACEDNHG([OMAPKKAGFIL(null)] BJBNLDKHHPB EMFCBJGGHJE, [OMAPKKAGFIL(null)] PLNHHCCDECD OBMAELFEHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6FFFFC0", Offset = "0x6FFF1C0", VA = "0x186FFFFC0")]
	private static FKMOANNDEEK? NDGIPCGECBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF7B0", Offset = "0x6FFE9B0", VA = "0x186FFF7B0", Slot = "4")]
	public bool BPCCMHDHJPE(LCMANADAOPN ANJMNLDAJPB, LCMANADAOPN KLDFODBCABD, IEnumerable<LCMANADAOPN> OMMKHMKEFEM, [Out] KFDAAEJHOIK NGCPBNHFHMM, [Out] IJNKNPGLGJP PJKEANDFMHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6FFFEC0", Offset = "0x6FFF0C0", VA = "0x186FFFEC0", Slot = "5")]
	public string HMFHHGJHKOH(IJNKNPGLGJP EBKJEDMNOIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF8B0", Offset = "0x6FFEAB0", VA = "0x186FFF8B0")]
	internal bool CAAMKEFBKLD(LCMANADAOPN ANJMNLDAJPB, LCMANADAOPN KLDFODBCABD, IEnumerable<LCMANADAOPN> OMMKHMKEFEM, FLKIEPIEFEG MGNEMJNJPBC, FKMOANNDEEK? GKJIJIDECHF, [Out] KFDAAEJHOIK NGCPBNHFHMM, [Out] IJNKNPGLGJP PJKEANDFMHI)
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
