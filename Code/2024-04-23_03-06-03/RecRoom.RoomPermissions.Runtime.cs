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
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x693F8B0", Offset = "0x693E8B0", VA = "0x18693F8B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EB340", Offset = "0x7EA340", VA = "0x1807EB340")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EB380", Offset = "0x7EA380", VA = "0x1807EB380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum JMAACBCOPOD
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void POAELIFCCEB<TPermission>(TPermission FJPAFJCIINB);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void HMPPAFMDICN(JGGIBKMOPKC HDKCFFEMGLH);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum NOKNGOMFNIO
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JLAOJMEGFGF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ENJNNACKNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool NGLFMJHGPNA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool AIIIALPEFFI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool ECHMEOPBDMC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool KKJHFOBFAAC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LAPCBNCGACL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class PBEANKBEIHO
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum CLDOEPPAICC
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
	public static readonly Guid JAIDKEJDHBA;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid DDMFKBCEOEF;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid GNOKLAFDNIH;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid JEAEIEPJPJD;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid GOMGGAOGFHP;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid OMLOBPEBIHG;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly LGAMCOELBAN<NELCPGOGILD, Guid> FNEFBNELNLL;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<NELCPGOGILD> NIFCBLNGNFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6940E80", Offset = "0x693FE80", VA = "0x186940E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6940CD0", Offset = "0x693FCD0", VA = "0x186940CD0")]
	public static NELCPGOGILD FBHKHMLLAOL(Guid KAABLCGOLKG)
	{
		return default(NELCPGOGILD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6940D60", Offset = "0x693FD60", VA = "0x186940D60")]
	public static Guid FKNPHPFOHCL(NELCPGOGILD HIFBNJAGINJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6940AF0", Offset = "0x693FAF0", VA = "0x186940AF0")]
	public static bool CLANOJFIEFL(NELCPGOGILD HIFBNJAGINJ, [Out] Guid KAABLCGOLKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6940B80", Offset = "0x693FB80", VA = "0x186940B80")]
	public static bool CLFMIHCOMDD(Guid KAABLCGOLKG, [Out] NELCPGOGILD HIFBNJAGINJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6940E40", Offset = "0x693FE40", VA = "0x186940E40")]
	public static NELCPGOGILD JOOENPMKAKI(NELCPGOGILD HIFBNJAGINJ)
	{
		return default(NELCPGOGILD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6940C20", Offset = "0x693FC20", VA = "0x186940C20")]
	public static CLDOEPPAICC EDMFKHJNFGI(NELCPGOGILD JEEKAKOOAJF)
	{
		return default(CLDOEPPAICC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6940E00", Offset = "0x693FE00", VA = "0x186940E00")]
	internal static NELCPGOGILD JFKFJAMLPJC(CLDOEPPAICC BKHPCDJNEFB)
	{
		return default(NELCPGOGILD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IIHDOFCLKGK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	GMEPNNMABDG CFBJLLIOKHG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<BENBMJMFNOC> DHGOIAJCOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event HMPPAFMDICN HGOFLOGNAMF;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<BENBMJMFNOC> HJOLHNFBAPG(bool KMHCMMGNIEP = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BENBMJMFNOC HELAJDCBDJI(JGGIBKMOPKC HDKCFFEMGLH);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool IGBGODBNKGB(JGGIBKMOPKC HDKCFFEMGLH);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<BENBMJMFNOC> AFDMIOFIHOB(JGGIBKMOPKC HDKCFFEMGLH, bool PEBPHJDNFIG = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EPPCEFEDFKC(JGGIBKMOPKC CPFCPFIHEOI, NELCPGOGILD HIFBNJAGINJ);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BENBMJMFNOC HLILMNBMAIP(NELCPGOGILD HIFBNJAGINJ);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool PINKHHFDDKG<T>(NELCPGOGILD HIFBNJAGINJ, FJLGHOIDJJK FJPAFJCIINB, bool OFGBPDOLLGA, T OFDFAAHEGDG, [Optional] Action PLIHDNMDIPL) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BOLHLDCCDCE
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DDFELBOAIBE(OJAAFLOIAIF LAOLHNNNLCH, CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KLAJCMCPFGC(OJAAFLOIAIF LAOLHNNNLCH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EBMBHLEPNFL
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JGGIBKMOPKC MHKJELAFFJB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	BPINABCIEKB KHMPOBFCGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	KPBKEDCLNDD DBPOJKPMICE
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<PDKKEJHHNEK> MMCGMEAPPOK;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action FAOJABAGMBN;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NELCPGOGILD IICJAJBLDKD(JGGIBKMOPKC HDKCFFEMGLH);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<PDKKEJHHNEK> HPHGJEMILKB(CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task AAHIEFEBCHA(long CFLPHBNCGDP, long AKANBGAJAAH, IReadOnlyList<NCBDGMAFDPI> BGODCKDOMLN);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<JGGIBKMOPKC> GDBBIGINNJF();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KIEBPOLPMBL
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6936060", Offset = "0x6935060", VA = "0x186936060")]
	public static NELCPGOGILD KIHMEFALFLO(this EBMBHLEPNFL BOMMLOHOOPM)
	{
		return default(NELCPGOGILD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EIFBJDBCAGA<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string MOKNJFDENON
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event POAELIFCCEB<TPermission> EMCBGJEJNBD;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class DMPNGLHGNEJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? BOBEFKIJAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7C35D0", Offset = "0x7C25D0", VA = "0x1807C35D0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C50", Offset = "0x7C8C50", VA = "0x1807C9C50")]
	protected DMPNGLHGNEJ(object? ACDGNBLOLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool EJJEMJLLJPL(object? LDGMLLMKHLF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class FKGOGLCJOHM<T> : DMPNGLHGNEJ where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T FEHNIEIFIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> IGLIHABJIFK;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T DMDNAKDAMMG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x82BFE0", Offset = "0x82AFE0", VA = "0x18082BFE0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x38A3EC0", Offset = "0x38A2EC0", VA = "0x1838A3EC0", Slot = "4")]
	public override bool EJJEMJLLJPL(object? LDGMLLMKHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x38A3B90", Offset = "0x38A2B90", VA = "0x1838A3B90")]
	public bool DKEDJJAGFLO(T PEPFGNAKHIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x38A43E0", Offset = "0x38A33E0", VA = "0x1838A43E0")]
	public FKGOGLCJOHM(T HIFDPDGCHMN, IEqualityComparer<T> IGLIHABJIFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class MDKEAGPMDAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<FJLGHOIDJJK, bool> LHFFNKAEBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<FJLGHOIDJJK, DMPNGLHGNEJ> DHIJGOKFOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly OGEPJCGFFLK JDMNHABMDMJ;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x693F0C0", Offset = "0x693E0C0", VA = "0x18693F0C0")]
	public MDKEAGPMDAL(OGEPJCGFFLK JDMNHABMDMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x693F050", Offset = "0x693E050", VA = "0x18693F050")]
	public bool NNBCNCIKPDK(FJLGHOIDJJK FJPAFJCIINB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2975760", Offset = "0x2974760", VA = "0x182975760")]
	public bool GPHBOJEIPLL<T>(FJLGHOIDJJK FJPAFJCIINB, bool OFGBPDOLLGA, T LDGMLLMKHLF) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2975C40", Offset = "0x2974C40", VA = "0x182975C40")]
	public (bool, T?) HFAHEIPHLDO<T>(FJLGHOIDJJK FJPAFJCIINB) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x693ECA0", Offset = "0x693DCA0", VA = "0x18693ECA0")]
	public bool GPHBOJEIPLL(FJLGHOIDJJK FJPAFJCIINB, bool OFGBPDOLLGA, object LDGMLLMKHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x693ED80", Offset = "0x693DD80", VA = "0x18693ED80")]
	public (bool, object) HFAHEIPHLDO(FJLGHOIDJJK FJPAFJCIINB)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2975720", Offset = "0x2974720", VA = "0x182975720")]
	private void DIDIJAGMHOA<T>(FJLGHOIDJJK FJPAFJCIINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x693EBD0", Offset = "0x693DBD0", VA = "0x18693EBD0")]
	private DMPNGLHGNEJ AHDGPPPEOGE(FJLGHOIDJJK FJPAFJCIINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x693EE50", Offset = "0x693DE50", VA = "0x18693EE50")]
	public void NKHDFLNIIBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class COOHHNGCCDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string POHNNMMDIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type DNFELKPLHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly MEOCCFGDPIA EAKGAHIKMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly FJLGHOIDJJK NNDGPPGOHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public LOLIMCFNAEK GCOBIHBHFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public ODCLLLJIKBL JGEGHDGACIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public LJINCFDJABK HIBEDBMKAJM;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6934BF0", Offset = "0x6933BF0", VA = "0x186934BF0")]
	public COOHHNGCCDO(Type KAICLMKMAAI, string AHBFDHGIPFP, FJLGHOIDJJK FJPAFJCIINB, LOLIMCFNAEK NMACIPJJPCA, ODCLLLJIKBL PLEMOCCLLDG, LJINCFDJABK GFKFKGDFIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6934BA0", Offset = "0x6933BA0", VA = "0x186934BA0")]
	public object HEMINCMAICN(object? JNHFAFOIKEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x271EE60", Offset = "0x271DE60", VA = "0x18271EE60")]
	public void DIDIJAGMHOA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6934AF0", Offset = "0x6933AF0", VA = "0x186934AF0")]
	public void DIDIJAGMHOA(Type BFNNMOJHHOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class CNLHKALBDPN<T> : COOHHNGCCDO where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string FDONJAJFLKP(T LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T KILJPFGDEBL(string? HAKBLKNGNFD, T HIFDPDGCHMN);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class DDENBJDPCAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public FDONJAJFLKP serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public KILJPFGDEBL parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public DDENBJDPCAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x51E6630", Offset = "0x51E5630", VA = "0x1851E6630")]
		internal string EECIPEGFNGI(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x51E6660", Offset = "0x51E5660", VA = "0x1851E6660")]
		internal object OEPHNIMKKHP(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x503E4A0", Offset = "0x503D4A0", VA = "0x18503E4A0")]
	public CNLHKALBDPN(FJLGHOIDJJK FJPAFJCIINB, string AHBFDHGIPFP, [Optional] FDONJAJFLKP? NMACIPJJPCA, [Optional] KILJPFGDEBL? PLEMOCCLLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x503DE80", Offset = "0x503CE80", VA = "0x18503DE80")]
	private static object? OMCMMHECHCJ(KILJPFGDEBL? PLEMOCCLLDG, string? HAKBLKNGNFD, object? HIFDPDGCHMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x503D8E0", Offset = "0x503C8E0", VA = "0x18503D8E0")]
	private static string AFIENNPCBKD(FDONJAJFLKP? NHJILAJFBOA, object? LDGMLLMKHLF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string LOLIMCFNAEK(object? LDGMLLMKHLF);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object ODCLLLJIKBL(string? HAKBLKNGNFD, [Optional] object HIFDPDGCHMN);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate DMPNGLHGNEJ LJINCFDJABK();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class OGEPJCGFFLK
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class PIFMBPOAEGN : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static PIFMBPOAEGN AFPJCELPLKK;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x69412B0", Offset = "0x69402B0", VA = "0x1869412B0", Slot = "4")]
		public bool Equals(List<string> DLGLHFDHDLB, List<string> ANLBKHHFCFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6941400", Offset = "0x6940400", VA = "0x186941400", Slot = "5")]
		public int GetHashCode(List<string> KDEEPMDJGFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public PIFMBPOAEGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class LNIIPEDCKBH : FDOOBJFJCIL<JMAACBCOPOD>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x693DD70", Offset = "0x693CD70", VA = "0x18693DD70", Slot = "9")]
		public override string AFIENNPCBKD(JMAACBCOPOD BJGIJFLPNGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x693DE60", Offset = "0x693CE60", VA = "0x18693DE60", Slot = "10")]
		protected override bool HJPKINNPPMK(string BJGIJFLPNGG, [Out] JMAACBCOPOD LDGMLLMKHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x693E040", Offset = "0x693D040", VA = "0x18693E040")]
		public LNIIPEDCKBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly EEJCPAFAIEA MEFANBMECOJ;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly LNIIPEDCKBH ACMPMOAOOIL;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<COOHHNGCCDO> MGJACOOBKDJ;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<FJLGHOIDJJK> HDMKJAJEOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<FJLGHOIDJJK, COOHHNGCCDO> OIAHPEFNKAP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x69407A0", Offset = "0x693F7A0", VA = "0x1869407A0")]
	public OGEPJCGFFLK([Optional] IList<COOHHNGCCDO>? PPMECLLIDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x693F930", Offset = "0x693E930", VA = "0x18693F930")]
	public COOHHNGCCDO NPFOIFHEEGK(FJLGHOIDJJK FJPAFJCIINB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface GMEPNNMABDG
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	BENBMJMFNOC LEPBMBMCLKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class LOPIPLJBGPC : GMEPNNMABDG
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static LOPIPLJBGPC IABAOGCLCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly KMAGCMCADBI JJAHAOJNNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<KMAGCMCADBI> DIPELECDEFO;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public BENBMJMFNOC LEPBMBMCLKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x693EAB0", Offset = "0x693DAB0", VA = "0x18693EAB0")]
	public LOPIPLJBGPC(KMAGCMCADBI PNHJALJGECO, IReadOnlyList<KMAGCMCADBI> PGCMGAMHAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x693E080", Offset = "0x693D080", VA = "0x18693E080")]
	private static LOPIPLJBGPC HPOBBFIMFKF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class MENJKAFDJBA
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<NELCPGOGILD> KCDHJCGDNMB;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x693F3F0", Offset = "0x693E3F0", VA = "0x18693F3F0")]
	public static bool LEFBOMNNNLM(this JGGIBKMOPKC KFFKBJPPNBI, NELCPGOGILD HIFBNJAGINJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x693F370", Offset = "0x693E370", VA = "0x18693F370")]
	public static bool BEKNCMPJGAG(this JGGIBKMOPKC KFFKBJPPNBI, NELCPGOGILD HIFBNJAGINJ, KPBKEDCLNDD KDBBBMAICAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface GOPLDPEEPOE
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool PHJCOJJJPLL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool BODHCGOIDIB
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool IGFGFNBMLNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool KJNGCEPEGJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool CHCNCHBBIJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool FKJOELOFFKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool LFLEFKLJJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool HGKAOEPHKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool JGEKJEINLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool NEJGIOCAIEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool HGOOBNMAHHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool GDPMKGDNIJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> HELBLBNBLNK
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	JMAACBCOPOD MIJBKNAOEPM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface BENBMJMFNOC : GOPLDPEEPOE, JLAOJMEGFGF, EIFBJDBCAGA<FJLGHOIDJJK>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string LIKKILNAHJG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	NELCPGOGILD LHNOMLJHMHK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) ONLLGEBHNBE<T>(FJLGHOIDJJK FJPAFJCIINB) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum FJLGHOIDJJK
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
	AUTO_ASSIGNED_PLAYER_TAGS = 24
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class KMAGCMCADBI : BENBMJMFNOC, GOPLDPEEPOE, JLAOJMEGFGF, EIFBJDBCAGA<FJLGHOIDJJK>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal static readonly OGEPJCGFFLK HOJCJHCNGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly MDKEAGPMDAL HHMNLLICABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? BOLAKMILPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private string? LFDFNBODNCC;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool EFDENPFFMGE
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x693C400", Offset = "0x693B400", VA = "0x18693C400", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool MLBFFGCINBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x693C140", Offset = "0x693B140", VA = "0x18693C140", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool DKFCDEGMDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x693C3B0", Offset = "0x693B3B0", VA = "0x18693C3B0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool AMJMBFBJHNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x693C190", Offset = "0x693B190", VA = "0x18693C190", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool KPEDCNDBCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x693C4A0", Offset = "0x693B4A0", VA = "0x18693C4A0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool BNGEDICMDLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x693C360", Offset = "0x693B360", VA = "0x18693C360", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public NELCPGOGILD LHNOMLJHMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x82BFE0", Offset = "0x82AFE0", VA = "0x18082BFE0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(NELCPGOGILD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7C35C0", Offset = "0x7C25C0", VA = "0x1807C35C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string MOKNJFDENON
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x693C0A0", Offset = "0x693B0A0", VA = "0x18693C0A0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x693CB00", Offset = "0x693BB00", VA = "0x18693CB00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string LIKKILNAHJG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x693C0A0", Offset = "0x693B0A0", VA = "0x18693C0A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool LINADONPJJE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x87D310", Offset = "0x87C310", VA = "0x18087D310")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x87C550", Offset = "0x87B550", VA = "0x18087C550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool PHJCOJJJPLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x693D720", Offset = "0x693C720", VA = "0x18693D720", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public JMAACBCOPOD MIJBKNAOEPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x693C230", Offset = "0x693B230", VA = "0x18693C230", Slot = "20")]
		get
		{
			return default(JMAACBCOPOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool BODHCGOIDIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x693CA00", Offset = "0x693BA00", VA = "0x18693CA00", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool IGFGFNBMLNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x693C0F0", Offset = "0x693B0F0", VA = "0x18693C0F0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool KJNGCEPEGJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x693C4F0", Offset = "0x693B4F0", VA = "0x18693C4F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool CHCNCHBBIJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x693D6D0", Offset = "0x693C6D0", VA = "0x18693D6D0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool FKJOELOFFKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x693C540", Offset = "0x693B540", VA = "0x18693C540", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool LFLEFKLJJAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x693D830", Offset = "0x693C830", VA = "0x18693D830", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool HGKAOEPHKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x693C050", Offset = "0x693B050", VA = "0x18693C050", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool JGEKJEINLBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x693D7C0", Offset = "0x693C7C0", VA = "0x18693D7C0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> HELBLBNBLNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x693DA00", Offset = "0x693CA00", VA = "0x18693DA00", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool CENMCIMJNIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x693C400", Offset = "0x693B400", VA = "0x18693C400", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool MHJICJEHCDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x693C4A0", Offset = "0x693B4A0", VA = "0x18693C4A0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool BDIEDFPOOHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x693C140", Offset = "0x693B140", VA = "0x18693C140", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool NEJGIOCAIEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x693C1E0", Offset = "0x693B1E0", VA = "0x18693C1E0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool HGOOBNMAHHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x693D770", Offset = "0x693C770", VA = "0x18693D770", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool PBMHDECDBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x693C3B0", Offset = "0x693B3B0", VA = "0x18693C3B0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool GDPMKGDNIJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x693C450", Offset = "0x693B450", VA = "0x18693C450", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool MPPCPBKEJCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x693C190", Offset = "0x693B190", VA = "0x18693C190", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool OAIAPEJNJKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x693C360", Offset = "0x693B360", VA = "0x18693C360", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event POAELIFCCEB<FJLGHOIDJJK> EMCBGJEJNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x693CA50", Offset = "0x693BA50", VA = "0x18693CA50", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x693BFA0", Offset = "0x693AFA0", VA = "0x18693BFA0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2954560", Offset = "0x2953560", VA = "0x182954560", Slot = "6")]
	public (bool, T?) ONLLGEBHNBE<T>(FJLGHOIDJJK FJPAFJCIINB) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2954520", Offset = "0x2953520", VA = "0x182954520")]
	public KMAGCMCADBI EKHDANGAHDB<T>(FJLGHOIDJJK FJPAFJCIINB, bool OFGBPDOLLGA, T LDGMLLMKHLF) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x693DD50", Offset = "0x693CD50", VA = "0x18693DD50")]
	public KMAGCMCADBI(NELCPGOGILD HIFBNJAGINJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x693DCA0", Offset = "0x693CCA0", VA = "0x18693DCA0")]
	public KMAGCMCADBI(NELCPGOGILD HIFBNJAGINJ, [Optional] string? BOLAKMILPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x693DCC0", Offset = "0x693CCC0", VA = "0x18693DCC0")]
	public KMAGCMCADBI(KMAGCMCADBI HIHFJLEDNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x693DB40", Offset = "0x693CB40", VA = "0x18693DB40")]
	internal KMAGCMCADBI(NELCPGOGILD DIIMMMGLFBI, [Optional] string? BOLAKMILPAK, [Optional] KMAGCMCADBI? HIHFJLEDNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x693D880", Offset = "0x693C880", VA = "0x18693D880")]
	public static MEOCCFGDPIA NPEKMEJNMGP(FJLGHOIDJJK FJPAFJCIINB)
	{
		return default(MEOCCFGDPIA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x693D810", Offset = "0x693C810", VA = "0x18693D810")]
	public void NKHDFLNIIBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x693BC20", Offset = "0x693AC20", VA = "0x18693BC20")]
	internal KMAGCMCADBI AKHEPDIMMAB(KMAGCMCADBI JCGGBKLKEND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x693C590", Offset = "0x693B590", VA = "0x18693C590")]
	internal IReadOnlyCollection<FJLGHOIDJJK> FIOFIJAFHNC(KMAGCMCADBI HIHFJLEDNGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x693C280", Offset = "0x693B280", VA = "0x18693C280")]
	public bool DGFJDCMOABJ(FJLGHOIDJJK FJPAFJCIINB, bool OFGBPDOLLGA, string OBLNFJEJDLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x693D900", Offset = "0x693C900", VA = "0x18693D900")]
	public (bool, string) PCMOGIBIGOK(FJLGHOIDJJK FJPAFJCIINB)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x693DA60", Offset = "0x693CA60", VA = "0x18693DA60")]
	internal void PMFEEKMMOLG(FJLGHOIDJJK FJPAFJCIINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x693CB50", Offset = "0x693BB50", VA = "0x18693CB50")]
	public JGFGDLDIAAF HPNKHFHLBHH(Func<NELCPGOGILD, Guid> FEHKMAHNNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x693CD50", Offset = "0x693BD50", VA = "0x18693CD50")]
	public void LDOKPMAIFBE(JGFGDLDIAAF JKCCHPIKIFD, Func<Guid, NELCPGOGILD> DGBPNMGGCIP, [Optional] NELCPGOGILD? DHJPHIDIGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x693BB90", Offset = "0x693AB90", VA = "0x18693BB90")]
	[CompilerGenerated]
	private void AKEEMPDKBDO(FJLGHOIDJJK OCBBGEAMPMB, EGCNLHIBFDO INFFBEBNBAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class KLDACONHKII : BOLHLDCCDCE, IIHDOFCLKGK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class NIPBLCKEBDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public KMAGCMCADBI newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public NIPBLCKEBDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x693F880", Offset = "0x693E880", VA = "0x18693F880")]
		internal bool PFNEDGCLJGO(KMAGCMCADBI rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class MAGAJGBPCIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public NELCPGOGILD roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public MAGAJGBPCIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x693EBC0", Offset = "0x693DBC0", VA = "0x18693EBC0")]
		internal bool JNBALELILOE(NELCPGOGILD r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct PNFFBILCMLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public KLDACONHKII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public OJAAFLOIAIF roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<PDKKEJHHNEK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x69415F0", Offset = "0x69405F0", VA = "0x1869415F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6941C60", Offset = "0x6940C60", VA = "0x186941C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class NIKLGBGINAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public NIKLGBGINAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x693F7A0", Offset = "0x693E7A0", VA = "0x18693F7A0")]
		internal void LBNPHMKEPEA(JGFGDLDIAAF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x693F680", Offset = "0x693E680", VA = "0x18693F680")]
		internal void AKGAIJKLACC(JGFGDLDIAAF r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct BJILEHNMACN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public OJAAFLOIAIF roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class PEIGOODLHML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<JGFGDLDIAAF, EGCNLHIBFDO> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public PEIGOODLHML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6941220", Offset = "0x6940220", VA = "0x186941220")]
		internal void FLHJHHNDBDG(JGFGDLDIAAF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6941250", Offset = "0x6940250", VA = "0x186941250")]
		internal void FLIJJKDPBMN(JGFGDLDIAAF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6941280", Offset = "0x6940280", VA = "0x186941280")]
		internal void HKJJOFHFCHH(JGFGDLDIAAF r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class JOAPNCBICEO<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public JOAPNCBICEO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private TaskAwaiter<PDKKEJHHNEK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x328DE30", Offset = "0x328CE30", VA = "0x18328DE30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8A9220", Offset = "0x8A8220", VA = "0x1808A9220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public KLDACONHKII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public FJLGHOIDJJK rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public NELCPGOGILD accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public MEOCCFGDPIA recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public JOAPNCBICEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3D184E0", Offset = "0x3D174E0", VA = "0x183D184E0")]
		[AsyncStateMachine(typeof(JOAPNCBICEO<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void KOFMLIBPKIA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct PMDHEAAPPEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public IReadOnlyList<NCBDGMAFDPI> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct DJDPPHKNIDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public EBMBHLEPNFL rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public OJAAFLOIAIF roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public IReadOnlyDictionary<NELCPGOGILD, KMAGCMCADBI> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public HLAOJMHANAK debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6934C90", Offset = "0x6933C90", VA = "0x186934C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x69357A0", Offset = "0x69347A0", VA = "0x1869357A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly EBMBHLEPNFL BOMMLOHOOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly LOPIPLJBGPC AIODCFMNHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly HLAOJMHANAK DMEMKBHHFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, KMAGCMCADBI> EAKKNAKCBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<NELCPGOGILD, KMAGCMCADBI> PENKCGJIMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly Dictionary<NELCPGOGILD, KMAGCMCADBI> EGPEMPCFHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal readonly List<KMAGCMCADBI> AJECIKDPOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool KCBMLBPJAIH;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly FJLGHOIDJJK[] NGFBKECIJBO;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public GMEPNNMABDG CFBJLLIOKHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<BENBMJMFNOC> DHGOIAJCOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6939520", Offset = "0x6938520", VA = "0x186939520", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event HMPPAFMDICN HGOFLOGNAMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6939570", Offset = "0x6938570", VA = "0x186939570", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x693A2C0", Offset = "0x69392C0", VA = "0x18693A2C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6938090", Offset = "0x6937090", VA = "0x186938090")]
	[ILJDPBHFAFI(ENLFMENACGP.Room, DIDBPCEENMM.None)]
	private static void ELBLKAPGOPK(OIEDECFCIPC LDKHFAGODPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x693B8D0", Offset = "0x693A8D0", VA = "0x18693B8D0")]
	[UnityEngine.Scripting.Preserve]
	internal KLDACONHKII([POILJEECDED(null)] EBMBHLEPNFL NNNCKGCLKIE, [POILJEECDED(null)] LOPIPLJBGPC HNCHPBLNKMO, [POILJEECDED(null)] HLAOJMHANAK DMEMKBHHFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6937F80", Offset = "0x6936F80", VA = "0x186937F80", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6936D90", Offset = "0x6935D90", VA = "0x186936D90")]
	private void BFGDIEEHGJO(IEnumerable<KMAGCMCADBI> NGNHBHNNEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6939450", Offset = "0x6938450", VA = "0x186939450", Slot = "12")]
	public bool IGBGODBNKGB(JGGIBKMOPKC HDKCFFEMGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x69383E0", Offset = "0x69373E0", VA = "0x1869383E0")]
	private void FAOJABAGMBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6937610", Offset = "0x6936610", VA = "0x186937610")]
	private void BJBJINLCIPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6939330", Offset = "0x6938330", VA = "0x186939330", Slot = "10")]
	public IReadOnlyList<BENBMJMFNOC> HJOLHNFBAPG(bool KMHCMMGNIEP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6939220", Offset = "0x6938220", VA = "0x186939220", Slot = "11")]
	public BENBMJMFNOC HELAJDCBDJI(JGGIBKMOPKC HDKCFFEMGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6939ED0", Offset = "0x6938ED0", VA = "0x186939ED0")]
	private NELCPGOGILD KKOKMPJHJNI(JGGIBKMOPKC HDKCFFEMGLH)
	{
		return default(NELCPGOGILD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6938250", Offset = "0x6937250", VA = "0x186938250", Slot = "14")]
	public bool EPPCEFEDFKC(JGGIBKMOPKC CPFCPFIHEOI, NELCPGOGILD HIFBNJAGINJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x69393B0", Offset = "0x69383B0", VA = "0x1869393B0", Slot = "15")]
	public BENBMJMFNOC HLILMNBMAIP(NELCPGOGILD HIFBNJAGINJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x69379B0", Offset = "0x69369B0", VA = "0x1869379B0")]
	private static bool DIBNOOMBIPL(NJDGNJKPBEL FGEJFIIMIPD, NELCPGOGILD HIFBNJAGINJ, [Out] JGFGDLDIAAF? ICJOJNADJLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x693AC30", Offset = "0x6939C30", VA = "0x18693AC30")]
	private static void OOPDBCGJEIE(NJDGNJKPBEL FGEJFIIMIPD, Action<JGFGDLDIAAF> CHNBFKKGAGE, NELCPGOGILD KGEFKHLCPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x693AD20", Offset = "0x6939D20", VA = "0x18693AD20")]
	private static void OOPDBCGJEIE(NJDGNJKPBEL FGEJFIIMIPD, Action<JGFGDLDIAAF> CHNBFKKGAGE, Predicate<NELCPGOGILD> JGHLOELBMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6937820", Offset = "0x6936820", VA = "0x186937820")]
	private void DCJMELGBLFL(JGGIBKMOPKC HDKCFFEMGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6937890", Offset = "0x6936890", VA = "0x186937890", Slot = "4")]
	[AsyncStateMachine(typeof(PNFFBILCMLN))]
	public Task DDFELBOAIBE([CanBeNull] OJAAFLOIAIF LAOLHNNNLCH, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
	public void KLAJCMCPFGC(OJAAFLOIAIF LAOLHNNNLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6939B90", Offset = "0x6938B90", VA = "0x186939B90")]
	private void JMBOBDFKPMK(NJDGNJKPBEL CIOKCCILEKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6936A80", Offset = "0x6935A80", VA = "0x186936A80")]
	internal static string BDHKKADKPCK(EBMBHLEPNFL BOMMLOHOOPM, OJAAFLOIAIF LAOLHNNNLCH, IReadOnlyDictionary<NELCPGOGILD, KMAGCMCADBI> PENKCGJIMMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x69383F0", Offset = "0x69373F0", VA = "0x1869383F0")]
	private static void HBKJCBEJMCC(OJAAFLOIAIF LAOLHNNNLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6939840", Offset = "0x6938840", VA = "0x186939840")]
	private static void JJODFKCHNMG(NJDGNJKPBEL IEGICPEBBEE, IReadOnlyDictionary<NELCPGOGILD, KMAGCMCADBI> PENKCGJIMMJ, StringBuilder DICFIELABLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x693A1B0", Offset = "0x69391B0", VA = "0x18693A1B0")]
	private static bool MACFCKFJDGN(string CIEMINNMOOI, [Out] Guid GHIODLACGDK, [Out] NELCPGOGILD HIFBNJAGINJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x693AFB0", Offset = "0x6939FB0", VA = "0x18693AFB0")]
	private static void PIPNDJDIDGB(OJAAFLOIAIF LAOLHNNNLCH, StringBuilder DICFIELABLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2953590", Offset = "0x2952590", VA = "0x182953590", Slot = "16")]
	public bool PINKHHFDDKG<T>(NELCPGOGILD HIFBNJAGINJ, FJLGHOIDJJK FJPAFJCIINB, bool OFGBPDOLLGA, T OFDFAAHEGDG, [Optional] Action PLIHDNMDIPL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6939FA0", Offset = "0x6938FA0", VA = "0x186939FA0")]
	private void LKIHDJALPMC(NELCPGOGILD HIFBNJAGINJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6937800", Offset = "0x6936800", VA = "0x186937800")]
	private bool CHAAIPHIGHA(JGGIBKMOPKC HDKCFFEMGLH, NELCPGOGILD HIFBNJAGINJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x69363C0", Offset = "0x69353C0", VA = "0x1869363C0")]
	internal KMAGCMCADBI AMCKBFPGNPH(JGGIBKMOPKC HDKCFFEMGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x69363B0", Offset = "0x69353B0", VA = "0x1869363B0", Slot = "13")]
	public IReadOnlyList<BENBMJMFNOC> AFDMIOFIHOB(JGGIBKMOPKC HDKCFFEMGLH, bool PEBPHJDNFIG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6939610", Offset = "0x6938610", VA = "0x186939610")]
	internal IReadOnlyList<KMAGCMCADBI> JJIFIFKGGJC(JGGIBKMOPKC HDKCFFEMGLH, bool PEBPHJDNFIG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x693A360", Offset = "0x6939360", VA = "0x18693A360")]
	private void NLFPCCPPBCF(PDKKEJHHNEK FJFLGPGHDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x69360C0", Offset = "0x69350C0", VA = "0x1869360C0")]
	private static bool AAFMBCBNDOJ(KMAGCMCADBI KGIKNIILGIF, IReadOnlyDictionary<NELCPGOGILD, KMAGCMCADBI> PENKCGJIMMJ, [Out] IReadOnlyList<FJLGHOIDJJK> KNAPFKDNMAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x693AAF0", Offset = "0x6939AF0", VA = "0x18693AAF0")]
	[AsyncStateMachine(typeof(DJDPPHKNIDN))]
	private static Task OMPMOEPELKO(EBMBHLEPNFL BOMMLOHOOPM, OJAAFLOIAIF LAOLHNNNLCH, IReadOnlyDictionary<NELCPGOGILD, KMAGCMCADBI> PENKCGJIMMJ, HLAOJMHANAK DMEMKBHHFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6937CE0", Offset = "0x6936CE0", VA = "0x186937CE0")]
	[CompilerGenerated]
	internal static void DMPKJAMLCAB(Func<JGFGDLDIAAF, EGCNLHIBFDO> CGFHJECLMCA, BJILEHNMACN P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6936710", Offset = "0x6935710", VA = "0x186936710")]
	[CompilerGenerated]
	internal static bool BDHBBLKIHPM(NELCPGOGILD HIFBNJAGINJ, FJLGHOIDJJK FJPAFJCIINB, [Out] NCBDGMAFDPI MKJBANOMJGM, PMDHEAAPPEH P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface JPOOEOFNPPE
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JECEPBJFFII(JGGIBKMOPKC LKMEGEOOMIE, JGGIBKMOPKC PMPILDGMKHA, IEnumerable<JGGIBKMOPKC> MADIPMEFNBC, [Out] JMAACBCOPOD OBBBMJBMNPL, [Out] EHACFKEHNFG BDGPBLOCPCH);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string GGJEBKAJNMN(EHACFKEHNFG AOBGNFNMPLA);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum EHACFKEHNFG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class IIENHLMFPDJ : JPOOEOFNPPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly IIHDOFCLKGK EBECMFGNMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly MDGDBCEKJJO KMOBEKHGIAH;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA10", Offset = "0x7CDA10", VA = "0x1807CEA10")]
	[RecRoom.NoEngine.Common.Preserve]
	public IIENHLMFPDJ([POILJEECDED(null)] IIHDOFCLKGK JDLDDDKNLPC, [POILJEECDED(null)] MDGDBCEKJJO FHEKCNMIBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6935800", Offset = "0x6934800", VA = "0x186935800")]
	private static KIPLEFCNIEB? EODHIGKEFFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6935940", Offset = "0x6934940", VA = "0x186935940", Slot = "4")]
	public bool JECEPBJFFII(JGGIBKMOPKC LKMEGEOOMIE, JGGIBKMOPKC PMPILDGMKHA, IEnumerable<JGGIBKMOPKC> MADIPMEFNBC, [Out] JMAACBCOPOD OBBBMJBMNPL, [Out] EHACFKEHNFG BDGPBLOCPCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6935840", Offset = "0x6934840", VA = "0x186935840", Slot = "5")]
	public string GGJEBKAJNMN(EHACFKEHNFG AOBGNFNMPLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6935A40", Offset = "0x6934A40", VA = "0x186935A40")]
	internal bool OGPNOCHFNBK(JGGIBKMOPKC LKMEGEOOMIE, JGGIBKMOPKC PMPILDGMKHA, IEnumerable<JGGIBKMOPKC> MADIPMEFNBC, KPBKEDCLNDD KDBBBMAICAI, KIPLEFCNIEB? KFMNLEOANOP, [Out] JMAACBCOPOD OBBBMJBMNPL, [Out] EHACFKEHNFG BDGPBLOCPCH)
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
