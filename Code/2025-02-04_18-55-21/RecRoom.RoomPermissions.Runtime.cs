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
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A32880", Offset = "0x7A31680", VA = "0x187A32880")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x920390", Offset = "0x91F190", VA = "0x180920390")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9203D0", Offset = "0x91F1D0", VA = "0x1809203D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum EIKOAAHFIKH
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
namespace _AssemblyRegistry.RecRoom_RoomPermissions_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7A359A0", Offset = "0x7A347A0", VA = "0x187A359A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2408FF0", Offset = "0x2407DF0", VA = "0x182408FF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void FAJEDMNGBHD<TPermission>(TPermission LJDAGFFBNPJ);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void ECLILGFHBGA(NJGJGBGCLGP CJJBIEHOBCD);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum GHJNHJLLLDK
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DFFNAPHOOJH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FBLFOAJOLBI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool EOKMLMFMMFD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool CLEJKOGKKFG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HBEMCAJBHHA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool LJJOFIGPDLE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool DBHIDPIOILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class GIHHMACLGFK
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum FLJAECEHCIP
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
	public static readonly Guid OPLEGJBABOL;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid MPFOCOAKLEO;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid FIDPPKLAGGA;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid GNLPNNNBHBM;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid KOKEIANGPBB;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid GGAFDKNJEJK;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly IAGPDCKIHOL<BKBFPOLBAFH, Guid> BONOMCCKJFF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<BKBFPOLBAFH> DALLJJJGOIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7A2F0A0", Offset = "0x7A2DEA0", VA = "0x187A2F0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7A2F120", Offset = "0x7A2DF20", VA = "0x187A2F120")]
	public static BKBFPOLBAFH GAABMNKHJLH(Guid OGOMDMBFOMG)
	{
		return default(BKBFPOLBAFH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7A2F1F0", Offset = "0x7A2DFF0", VA = "0x187A2F1F0")]
	public static Guid GOBKPDCLPIH(BKBFPOLBAFH JAPMOBILBFO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7A2F290", Offset = "0x7A2E090", VA = "0x187A2F290")]
	public static bool HIFHMBNNHIP(BKBFPOLBAFH JAPMOBILBFO, [Out] Guid OGOMDMBFOMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7A2F360", Offset = "0x7A2E160", VA = "0x187A2F360")]
	public static bool KFABADPDNLB(Guid OGOMDMBFOMG, [Out] BKBFPOLBAFH JAPMOBILBFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7A2F1B0", Offset = "0x7A2DFB0", VA = "0x187A2F1B0")]
	public static BKBFPOLBAFH GGCPDKHMFFD(BKBFPOLBAFH JAPMOBILBFO)
	{
		return default(BKBFPOLBAFH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7A2F400", Offset = "0x7A2E200", VA = "0x187A2F400")]
	public static FLJAECEHCIP PHLHIFODCAB(BKBFPOLBAFH MHBHDKAFIPJ)
	{
		return default(FLJAECEHCIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7A2F320", Offset = "0x7A2E120", VA = "0x187A2F320")]
	internal static BKBFPOLBAFH ICKBLHPPLLB(FLJAECEHCIP MGBNPIBLLJO)
	{
		return default(BKBFPOLBAFH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HEMBOGIJNDP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	MFEJENPAGHK ONKONLPPLBO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<CLIEEENPCHG> KIFGJAEDDFO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event ECLILGFHBGA OPKDOGHICNI;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<CLIEEENPCHG> NGMMCAECDBN(bool GMJPKNIGNBO = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CLIEEENPCHG FOFMLBBNACF(NJGJGBGCLGP CJJBIEHOBCD);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PEBOJOKFONI(NJGJGBGCLGP CJJBIEHOBCD);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<CLIEEENPCHG> FCGCJIGNGDH(NJGJGBGCLGP CJJBIEHOBCD, bool CMJLEFPNMBC = false);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BPANPFEGBPG(NJGJGBGCLGP AHCNHHIAPAF, BKBFPOLBAFH JAPMOBILBFO);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CLIEEENPCHG MBNIOGLAKKF(BKBFPOLBAFH JAPMOBILBFO);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool PCEKHMJDCEC<T>(BKBFPOLBAFH JAPMOBILBFO, AKAGJKELAIJ LJDAGFFBNPJ, bool NMBDNKPKIBM, T BFLKHJBBCJI, [Optional] Action GEKPEIGPLNJ) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string LJACICBLADC(AKAGJKELAIJ LJDAGFFBNPJ);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ALFEPLJKFOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CODPAJBIPKM(PPNKBAMJHHC BGIEPHNJHFK, CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GBFDEMJAOBF(PPNKBAMJHHC BGIEPHNJHFK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AIDHKACIJHB
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	NJGJGBGCLGP ODOCIEIBPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	NCNEODEEIGF EJMMCAKMIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	DGCCNGNLMNC GPMOJLHFLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<GGKBCOPJEOE> DBFPNDGIMJP;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action PBEOILKMFBA;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BKBFPOLBAFH FBALPBCAHDG(NJGJGBGCLGP CJJBIEHOBCD);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<GGKBCOPJEOE> IIBFJLENIMK(CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task GMCPMBILGOD(long OGMIFIGJENM, IReadOnlyList<PDOBJFPEMLA> PGPONNNPKLL);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task BDKLPLJHICO(long OGMIFIGJENM, long FIAEJOGALJF, IReadOnlyList<PDOBJFPEMLA> PGPONNNPKLL);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<NJGJGBGCLGP> MGLEEFPCAGE();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MAJBNFAHGIG
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7A31060", Offset = "0x7A2FE60", VA = "0x187A31060")]
	public static BKBFPOLBAFH OJFNCCFICCL(this AIDHKACIJHB PMGOGCCFPLO)
	{
		return default(BKBFPOLBAFH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LLPIPLODJHM<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string MALPCKIJNAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event FAJEDMNGBHD<TPermission> GMNBIECGHDD;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class NPILJHMMGCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? HKLPKFLPOFD;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? MOFKDAANNPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7A32590", Offset = "0x7A31390", VA = "0x187A32590")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7A32670", Offset = "0x7A31470", VA = "0x187A32670")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7A32770", Offset = "0x7A31570", VA = "0x187A32770")]
	protected NPILJHMMGCA(object? ADJNDDOGLML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool PJAJBBHLOCC(object? IPHILEOFJLB);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class PBDLDFMMDKD<T> : NPILJHMMGCA where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> LKDCBGBNMHJ;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T HKHKCHJEPKB
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4F02550", Offset = "0x4F01350", VA = "0x184F02550")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4F02D20", Offset = "0x4F01B20", VA = "0x184F02D20", Slot = "4")]
	public override bool PJAJBBHLOCC(object? IPHILEOFJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4F031A0", Offset = "0x4F01FA0", VA = "0x184F031A0")]
	public bool PLAMCPPPLKP(T HINMFCPFGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4F03420", Offset = "0x4F02220", VA = "0x184F03420")]
	public PBDLDFMMDKD(T KBHDDKCAINE, IEqualityComparer<T> LKDCBGBNMHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class DPKEMLDPABC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<AKAGJKELAIJ, bool> OEMCMKIBJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<AKAGJKELAIJ, NPILJHMMGCA> ONHIOHCPGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly LIEABIBIBPK OMFOGFMOHCH;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7A2E4F0", Offset = "0x7A2D2F0", VA = "0x187A2E4F0")]
	public DPKEMLDPABC(LIEABIBIBPK OMFOGFMOHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7A2E1C0", Offset = "0x7A2CFC0", VA = "0x187A2E1C0")]
	public bool EAKBPBCMAJD(AKAGJKELAIJ LJDAGFFBNPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3149500", Offset = "0x3148300", VA = "0x183149500")]
	public bool PNMOBAODLOK<T>(AKAGJKELAIJ LJDAGFFBNPJ, bool NMBDNKPKIBM, T IPHILEOFJLB) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3149000", Offset = "0x3147E00", VA = "0x183149000")]
	public (bool, T?) DDFDBBBEJLM<T>(AKAGJKELAIJ LJDAGFFBNPJ) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7A2E410", Offset = "0x7A2D210", VA = "0x187A2E410")]
	public bool PNMOBAODLOK(AKAGJKELAIJ LJDAGFFBNPJ, bool NMBDNKPKIBM, object IPHILEOFJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7A2E020", Offset = "0x7A2CE20", VA = "0x187A2E020")]
	public (bool, object) DDFDBBBEJLM(AKAGJKELAIJ LJDAGFFBNPJ)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x31494A0", Offset = "0x31482A0", VA = "0x1831494A0")]
	private void GDPDPCCPDJB<T>(AKAGJKELAIJ LJDAGFFBNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7A2DF50", Offset = "0x7A2CD50", VA = "0x187A2DF50")]
	private NPILJHMMGCA CLPIJFKPPLE(AKAGJKELAIJ LJDAGFFBNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7A2E230", Offset = "0x7A2D030", VA = "0x187A2E230")]
	public void ODNCJENOPAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class ECMPJODCKKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string CKOJFIPAENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type FJCFHBANLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly FAIIOCADPCI AFANPHMGBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly AKAGJKELAIJ ENGENBAIAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public OAEDANCJIOD GIOMAMIDILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public GJDHJCDIIBN AAIIGMJPEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public JCHIGNKCICJ DMGAJPOCOAD;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7A2E890", Offset = "0x7A2D690", VA = "0x187A2E890")]
	public ECMPJODCKKM(Type FOCFFDKBOLL, string GCKAADIMNCI, AKAGJKELAIJ LJDAGFFBNPJ, OAEDANCJIOD CEKPHKCKKCI, GJDHJCDIIBN JOIHCKNHKHI, JCHIGNKCICJ FJOLIIKJPBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7A2E790", Offset = "0x7A2D590", VA = "0x187A2E790")]
	public object GCCCKMAODBE(object? LHMPMCLNOPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3161AC0", Offset = "0x31608C0", VA = "0x183161AC0")]
	public void GDPDPCCPDJB<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7A2E7E0", Offset = "0x7A2D5E0", VA = "0x187A2E7E0")]
	public void GDPDPCCPDJB(Type AKPDAMEECMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class MINBGDJBJMD<T> : ECMPJODCKKM where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string GEGDDCBCNOD(T IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T HLAKPAINDFN(string? IODOAHIGNPL, T KBHDDKCAINE);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class KJOPPBMFLGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public GEGDDCBCNOD serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HLAKPAINDFN parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public KJOPPBMFLGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x49C5480", Offset = "0x49C4280", VA = "0x1849C5480")]
		internal string HKOLEGPFFOA(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x49C5270", Offset = "0x49C4070", VA = "0x1849C5270")]
		internal object HBOGFEDCIHD(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4C9E560", Offset = "0x4C9D360", VA = "0x184C9E560")]
	public MINBGDJBJMD(AKAGJKELAIJ LJDAGFFBNPJ, string GCKAADIMNCI, [Optional] GEGDDCBCNOD? CEKPHKCKKCI, [Optional] HLAKPAINDFN? JOIHCKNHKHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4C9CDB0", Offset = "0x4C9BBB0", VA = "0x184C9CDB0")]
	private static object? FEIAPADJKML(HLAKPAINDFN? JOIHCKNHKHI, string? IODOAHIGNPL, object? KBHDDKCAINE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4C9D980", Offset = "0x4C9C780", VA = "0x184C9D980")]
	private static string NPIKEPIONAB(GEGDDCBCNOD? PBOMOIMDCOO, object? IPHILEOFJLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string OAEDANCJIOD(object? IPHILEOFJLB);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object GJDHJCDIIBN(string? IODOAHIGNPL, [Optional] object KBHDDKCAINE);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate NPILJHMMGCA JCHIGNKCICJ();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class LIEABIBIBPK
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class MNBGCIIAOKD : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static MNBGCIIAOKD GGJCMHODIEM;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7A313D0", Offset = "0x7A301D0", VA = "0x187A313D0", Slot = "4")]
		public bool Equals(List<string> LBONEMFCDEA, List<string> IOKFBHNPJAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7A31520", Offset = "0x7A30320", VA = "0x187A31520", Slot = "5")]
		public int GetHashCode(List<string> JOOHPPHJKMI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public MNBGCIIAOKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class MOPHHAAHJIB : PEJABIGEGBL<EIKOAAHFIKH>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7A32460", Offset = "0x7A31260", VA = "0x187A32460", Slot = "9")]
		public override string NPIKEPIONAB(EIKOAAHFIKH HEILFBEALON)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7A32290", Offset = "0x7A31090", VA = "0x187A32290", Slot = "10")]
		protected override bool MENLHFHJKLB(string HEILFBEALON, [Out] EIKOAAHFIKH IPHILEOFJLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7A32550", Offset = "0x7A31350", VA = "0x187A32550")]
		public MOPHHAAHJIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly NPKOABGIOMH EJHDHIADKDN;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly MOPHHAAHJIB NLLPOJMHKIH;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<ECMPJODCKKM> PKCGBMKHPGM;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<AKAGJKELAIJ> GJJALBOEGHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<AKAGJKELAIJ, ECMPJODCKKM> FILDNMPKMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7A30D10", Offset = "0x7A2FB10", VA = "0x187A30D10")]
	public LIEABIBIBPK([Optional] IList<ECMPJODCKKM>? JLNOADBNEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7A2F7D0", Offset = "0x7A2E5D0", VA = "0x187A2F7D0")]
	public ECMPJODCKKM FNNNPKAJGCB(AKAGJKELAIJ LJDAGFFBNPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface MFEJENPAGHK
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	CLIEEENPCHG ADFOMNIIPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class CNFAPIBALEM : MFEJENPAGHK
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static CNFAPIBALEM LJAHIJPJDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly PBBNNNOGEEF KDCENKOFBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<PBBNNNOGEEF> FHHPDJGLHLB;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public CLIEEENPCHG ADFOMNIIPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7A28140", Offset = "0x7A26F40", VA = "0x187A28140")]
	public CNFAPIBALEM(PBBNNNOGEEF BOCCHANPFID, IReadOnlyList<PBBNNNOGEEF> DKCDEJEGLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7A272A0", Offset = "0x7A260A0", VA = "0x187A272A0")]
	private static CNFAPIBALEM NECFFKOKBLC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class MMEFEDKKKIA
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<BKBFPOLBAFH> BGPIBNJAEEO;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7A31140", Offset = "0x7A2FF40", VA = "0x187A31140")]
	public static bool NOJPOGHLKLF(this NJGJGBGCLGP ANICBEHNGEM, BKBFPOLBAFH JAPMOBILBFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7A310C0", Offset = "0x7A2FEC0", VA = "0x187A310C0")]
	public static bool KNKOKKHFGIP(this NJGJGBGCLGP ANICBEHNGEM, BKBFPOLBAFH JAPMOBILBFO, DGCCNGNLMNC NINGHLHEEFJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface MKKEBLNPMIG
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool JFBKJGNHGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool NEHEOMHIKLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool CFEHJIAPLGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool IIJPAGHGKIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool HNFEBPOMKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool ANOANBFAEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool BHLHMEMAKFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool BCEPDJFGMAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool ACDOFPPCEBA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool MFBCBMGHJFN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool KJLBALJLEED
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool BCHIGKOKFKH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> DICKIDKGLOE
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	EIKOAAHFIKH MLHIBJHBBHD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface CLIEEENPCHG : MKKEBLNPMIG, DFFNAPHOOJH, LLPIPLODJHM<AKAGJKELAIJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string IILJOAPBDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	BKBFPOLBAFH IIJAAMIJPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) JPLCMALELAO<T>(AKAGJKELAIJ LJDAGFFBNPJ) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum AKAGJKELAIJ
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
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	AUTO_ASSIGNED_PLAYER_TAGS = 24,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	CAN_USE_RRS = 25,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	ROOM_LEVEL_THRESHOLD = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	CAN_SAVE_ROOM = 1001,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	CAN_PUBLISH_ROOM = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CAN_CLONE_ROOM = 1003,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CAN_RESTORE_ROOM = 1004,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CAN_EDIT_MAIN_ROOM_SETTINGS = 1006,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CAN_EDIT_ROOM_ECON_SETTINGS = 1007,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CAN_CREATE_SUBROOMS = 1008,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	CAN_NAME_SUBROOMS = 1009,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CAN_CLONE_SUBROOMS = 1010,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	CAN_MOVE_SUBROOMS = 1011,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CAN_DELETE_SUBROOMS = 1012,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	CAN_EDIT_SUBROOM_SETTINGS = 1013,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	CAN_RESET_CLOUD_VARIABLES = 1014,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CAN_DELETE_CLOUD_VARIABLES = 1015,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	CAN_EDIT_ROOM_PROGRESSION = 1016,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	CAN_REMOVE_ROOM_BANS = 1017,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	CAN_ADD_ROOM_BANS = 1018
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class PBBNNNOGEEF : CLIEEENPCHG, MKKEBLNPMIG, DFFNAPHOOJH, LLPIPLODJHM<AKAGJKELAIJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly LIEABIBIBPK ADLMIOLMPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal readonly DPKEMLDPABC FDBMGIIDIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private string? OJPGPACIBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? BILKODIDECM;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool NBJJEFAMOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7A339C0", Offset = "0x7A327C0", VA = "0x187A339C0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool FAINBLMADIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7A33190", Offset = "0x7A31F90", VA = "0x187A33190", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool NGKCLNDOJEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7A32C10", Offset = "0x7A31A10", VA = "0x187A32C10", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool AMEIIAGHPDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7A32B20", Offset = "0x7A31920", VA = "0x187A32B20", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool ODICAHAOHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7A32950", Offset = "0x7A31750", VA = "0x187A32950", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool OAKBADPAAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7A33000", Offset = "0x7A31E00", VA = "0x187A33000", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public BKBFPOLBAFH IIJAAMIJPCC
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xBE0400", Offset = "0xBDF200", VA = "0x180BE0400", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(BKBFPOLBAFH);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8FE800", Offset = "0x8FD600", VA = "0x1808FE800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string MALPCKIJNAL
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7A329A0", Offset = "0x7A317A0", VA = "0x187A329A0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7A329F0", Offset = "0x7A317F0", VA = "0x187A329F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string IILJOAPBDFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7A329A0", Offset = "0x7A317A0", VA = "0x187A329A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool OMMEHDKMLBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xC2CA50", Offset = "0xC2B850", VA = "0x180C2CA50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xC2CA70", Offset = "0xC2B870", VA = "0x180C2CA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool JFBKJGNHGGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7A33140", Offset = "0x7A31F40", VA = "0x187A33140", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public EIKOAAHFIKH MLHIBJHBBHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7A33970", Offset = "0x7A32770", VA = "0x187A33970", Slot = "20")]
		get
		{
			return default(EIKOAAHFIKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool NEHEOMHIKLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7A32900", Offset = "0x7A31700", VA = "0x187A32900", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool CFEHJIAPLGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7A330A0", Offset = "0x7A31EA0", VA = "0x187A330A0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool IIJPAGHGKIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7A34550", Offset = "0x7A33350", VA = "0x187A34550", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool HNFEBPOMKPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7A346B0", Offset = "0x7A334B0", VA = "0x187A346B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool ANOANBFAEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7A33050", Offset = "0x7A31E50", VA = "0x187A33050", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool BHLHMEMAKFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7A343E0", Offset = "0x7A331E0", VA = "0x187A343E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool BCEPDJFGMAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7A335C0", Offset = "0x7A323C0", VA = "0x187A335C0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool ACDOFPPCEBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7A33920", Offset = "0x7A32720", VA = "0x187A33920", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> DICKIDKGLOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7A33810", Offset = "0x7A32610", VA = "0x187A33810", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool HEPODBJBHFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7A339C0", Offset = "0x7A327C0", VA = "0x187A339C0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool HGMPKBGNIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7A32950", Offset = "0x7A31750", VA = "0x187A32950", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool POKOOPMJFOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7A33190", Offset = "0x7A31F90", VA = "0x187A33190", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool MFBCBMGHJFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7A34390", Offset = "0x7A33190", VA = "0x187A34390", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool KJLBALJLEED
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7A330F0", Offset = "0x7A31EF0", VA = "0x187A330F0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool GCFKBIFBFIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7A32C10", Offset = "0x7A31A10", VA = "0x187A32C10", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool BCHIGKOKFKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7A32BC0", Offset = "0x7A319C0", VA = "0x187A32BC0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool GJMDJGPJLGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7A32B20", Offset = "0x7A31920", VA = "0x187A32B20", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool CLKBBIDJDKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7A33000", Offset = "0x7A31E00", VA = "0x187A33000", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event FAJEDMNGBHD<AKAGJKELAIJ> GMNBIECGHDD
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7A32F50", Offset = "0x7A31D50", VA = "0x187A32F50", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7A33870", Offset = "0x7A32670", VA = "0x187A33870", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x349B0E0", Offset = "0x3499EE0", VA = "0x18349B0E0", Slot = "6")]
	public (bool, T?) JPLCMALELAO<T>(AKAGJKELAIJ LJDAGFFBNPJ) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x349B080", Offset = "0x3499E80", VA = "0x18349B080")]
	public PBBNNNOGEEF CDIFGNLHMKE<T>(AKAGJKELAIJ LJDAGFFBNPJ, bool NMBDNKPKIBM, T IPHILEOFJLB) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7A348F0", Offset = "0x7A336F0", VA = "0x187A348F0")]
	public PBBNNNOGEEF(BKBFPOLBAFH JAPMOBILBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7A349A0", Offset = "0x7A337A0", VA = "0x187A349A0")]
	public PBBNNNOGEEF(BKBFPOLBAFH JAPMOBILBFO, [Optional] string? OJPGPACIBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7A34910", Offset = "0x7A33710", VA = "0x187A34910")]
	public PBBNNNOGEEF(PBBNNNOGEEF PHEDFCIDEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7A34790", Offset = "0x7A33590", VA = "0x187A34790")]
	internal PBBNNNOGEEF(BKBFPOLBAFH OFFJDLIDGEM, [Optional] string? OJPGPACIBHE, [Optional] PBBNNNOGEEF? PHEDFCIDEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7A345A0", Offset = "0x7A333A0", VA = "0x187A345A0")]
	public static FAIIOCADPCI OIOHACLKCMH(AKAGJKELAIJ LJDAGFFBNPJ)
	{
		return default(FAIIOCADPCI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7A34530", Offset = "0x7A33330", VA = "0x187A34530")]
	public void ODNCJENOPAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7A32C60", Offset = "0x7A31A60", VA = "0x187A32C60")]
	internal PBBNNNOGEEF EPPEOJIFBIK(PBBNNNOGEEF ALLKHPKKFEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7A331E0", Offset = "0x7A31FE0", VA = "0x187A331E0")]
	internal IReadOnlyCollection<AKAGJKELAIJ> HNEOLFGNEMG(PBBNNNOGEEF PHEDFCIDEHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7A32A40", Offset = "0x7A31840", VA = "0x187A32A40")]
	public bool CALJDFNFJGC(AKAGJKELAIJ LJDAGFFBNPJ, bool NMBDNKPKIBM, string INFNJMGGGPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7A34430", Offset = "0x7A33230", VA = "0x187A34430")]
	public (bool, string) ODKOENJHCBE(AKAGJKELAIJ LJDAGFFBNPJ)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7A32B70", Offset = "0x7A31970", VA = "0x187A32B70")]
	internal void DCPPMLABDEN(AKAGJKELAIJ LJDAGFFBNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7A33610", Offset = "0x7A32410", VA = "0x187A33610")]
	public JKMMCFJFDOM IOKBNINLMCO(Func<BKBFPOLBAFH, Guid> HBJENJAMPDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7A33A10", Offset = "0x7A32810", VA = "0x187A33A10")]
	public void NLALMNJEJKM(JKMMCFJFDOM AOCEHLFJIPJ, Func<Guid, BKBFPOLBAFH> JBFGFDHGCEJ, [Optional] BKBFPOLBAFH? KCDMANDBMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7A34620", Offset = "0x7A33420", VA = "0x187A34620")]
	[CompilerGenerated]
	private void OPJOCOBCMOL(AKAGJKELAIJ LACPGKLDIGD, DEFICAKNLPJ LGLEECKFKBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class DKLCDBKHLGG : ALFEPLJKFOJ, HEMBOGIJNDP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class AEINDEKEOBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public PBBNNNOGEEF newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public AEINDEKEOBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7A27270", Offset = "0x7A26070", VA = "0x187A27270")]
		internal bool GAPMJCDELDD(PBBNNNOGEEF rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class EJNHGPDEPGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public BKBFPOLBAFH roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public EJNHGPDEPGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7A2E930", Offset = "0x7A2D730", VA = "0x187A2E930")]
		internal bool AOFHADKPGKF(BKBFPOLBAFH r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct FCEFMKFEAHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public DKLCDBKHLGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public PPNKBAMJHHC roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<GGKBCOPJEOE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7A2E940", Offset = "0x7A2D740", VA = "0x187A2E940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7A2EFB0", Offset = "0x7A2DDB0", VA = "0x187A2EFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class DMBJENIOPPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public DMBJENIOPPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7A2DD50", Offset = "0x7A2CB50", VA = "0x187A2DD50")]
		internal void EEOLGKPEMBN(JKMMCFJFDOM r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7A2DE30", Offset = "0x7A2CC30", VA = "0x187A2DE30")]
		internal void MFNHPPIPEPH(JKMMCFJFDOM r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct BGNDOAJHBCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public PPNKBAMJHHC roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class FGBDDLDEJEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Func<JKMMCFJFDOM, DEFICAKNLPJ> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public FGBDDLDEJEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7A2F010", Offset = "0x7A2DE10", VA = "0x187A2F010")]
		internal void CCEGCOHCIPD(JKMMCFJFDOM r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7A2F040", Offset = "0x7A2DE40", VA = "0x187A2F040")]
		internal void EPECPAEJBDH(JKMMCFJFDOM r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7A2F070", Offset = "0x7A2DE70", VA = "0x187A2F070")]
		internal void MICBDDEOGII(JKMMCFJFDOM r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class CHAKNJGBFOG<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public CHAKNJGBFOG<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter<GGKBCOPJEOE> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x3C5CB90", Offset = "0x3C5B990", VA = "0x183C5CB90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AKAGJKELAIJ rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public BKBFPOLBAFH accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public FAIIOCADPCI recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public DKLCDBKHLGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public CHAKNJGBFOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x595CC80", Offset = "0x595BA80", VA = "0x18595CC80")]
		[AsyncStateMachine(typeof(CHAKNJGBFOG<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void OIHDPFNGLLB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct GDBCFHCPMIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public IReadOnlyList<PDOBJFPEMLA> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct MNEMDICMJOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AIDHKACIJHB rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public PPNKBAMJHHC roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public IReadOnlyDictionary<BKBFPOLBAFH, PBBNNNOGEEF> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public LADPBGMMBAL debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7A31710", Offset = "0x7A30510", VA = "0x187A31710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7A32230", Offset = "0x7A31030", VA = "0x187A32230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly AIDHKACIJHB PMGOGCCFPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly CNFAPIBALEM BAPKIPDENBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly LADPBGMMBAL GLBCCMFAHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Dictionary<int, PBBNNNOGEEF> MIJHGHPINNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	internal readonly Dictionary<BKBFPOLBAFH, PBBNNNOGEEF> PDMNALNLJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<BKBFPOLBAFH, PBBNNNOGEEF> KINIAPEOEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly List<PBBNNNOGEEF> GMJPCBGPMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private bool MJFKMABLJMO;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly AKAGJKELAIJ[] HFJKCIGICIG;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public MFEJENPAGHK ONKONLPPLBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<CLIEEENPCHG> KIFGJAEDDFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7A29540", Offset = "0x7A28340", VA = "0x187A29540", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event ECLILGFHBGA OPKDOGHICNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7A28E30", Offset = "0x7A27C30", VA = "0x187A28E30", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7A2A260", Offset = "0x7A29060", VA = "0x187A2A260", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7A2D4D0", Offset = "0x7A2C2D0", VA = "0x187A2D4D0")]
	[FOLINPJCBJN.OMHALDBFHHH]
	internal static void PIKBCINMJOC(IEPIHLKICIO JMPMFBCPFJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7A2DA90", Offset = "0x7A2C890", VA = "0x187A2DA90")]
	[UnityEngine.Scripting.Preserve]
	internal DKLCDBKHLGG([MHFJPMCEEAM(null)] AIDHKACIJHB KFMOHHLNBGJ, [MHFJPMCEEAM(null)] CNFAPIBALEM APPODADEFAO, [MHFJPMCEEAM(null)] LADPBGMMBAL GLBCCMFAHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7A299A0", Offset = "0x7A287A0", VA = "0x187A299A0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7A28250", Offset = "0x7A27050", VA = "0x187A28250")]
	private void AKIGGDJJCFF(IEnumerable<PBBNNNOGEEF> KDFGPONOEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7A2D400", Offset = "0x7A2C200", VA = "0x187A2D400", Slot = "12")]
	public bool PEBOJOKFONI(NJGJGBGCLGP CJJBIEHOBCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7A2CC50", Offset = "0x7A2BA50", VA = "0x187A2CC50")]
	private void PBEOILKMFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7A2B900", Offset = "0x7A2A700", VA = "0x187A2B900")]
	private void MPEBIBAJFFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7A2BD80", Offset = "0x7A2AB80", VA = "0x187A2BD80", Slot = "10")]
	public IReadOnlyList<CLIEEENPCHG> NGMMCAECDBN(bool GMJPKNIGNBO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7A29E40", Offset = "0x7A28C40", VA = "0x187A29E40", Slot = "11")]
	public CLIEEENPCHG FOFMLBBNACF(NJGJGBGCLGP CJJBIEHOBCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A500", Offset = "0x7A29300", VA = "0x187A2A500")]
	private BKBFPOLBAFH HLLDCAKDCLN(NJGJGBGCLGP CJJBIEHOBCD)
	{
		return default(BKBFPOLBAFH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7A28F40", Offset = "0x7A27D40", VA = "0x187A28F40", Slot = "14")]
	public bool BPANPFEGBPG(NJGJGBGCLGP AHCNHHIAPAF, BKBFPOLBAFH JAPMOBILBFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7A2B860", Offset = "0x7A2A660", VA = "0x187A2B860", Slot = "15")]
	public CLIEEENPCHG MBNIOGLAKKF(BKBFPOLBAFH JAPMOBILBFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7A2B530", Offset = "0x7A2A330", VA = "0x187A2B530")]
	private static bool LLAFHIIKHBH(AHBIEDFFEPN MAKJKELMFDM, BKBFPOLBAFH JAPMOBILBFO, [Out] JKMMCFJFDOM? PODBEJCJBAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7A28D40", Offset = "0x7A27B40", VA = "0x187A28D40")]
	private static void AKOFFCKKAHO(AHBIEDFFEPN MAKJKELMFDM, Action<JKMMCFJFDOM> CNILMBOHEMP, BKBFPOLBAFH EGNIADJDMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7A28AB0", Offset = "0x7A278B0", VA = "0x187A28AB0")]
	private static void AKOFFCKKAHO(AHBIEDFFEPN MAKJKELMFDM, Action<JKMMCFJFDOM> CNILMBOHEMP, Predicate<BKBFPOLBAFH> MJBEENFOBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7A28ED0", Offset = "0x7A27CD0", VA = "0x187A28ED0")]
	private void BLHEKMLLNFH(NJGJGBGCLGP CJJBIEHOBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7A29590", Offset = "0x7A28390", VA = "0x187A29590", Slot = "4")]
	[AsyncStateMachine(typeof(FCEFMKFEAHC))]
	public Task CODPAJBIPKM([CanBeNull] PPNKBAMJHHC BGIEPHNJHFK, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
	public void GBFDEMJAOBF(PPNKBAMJHHC BGIEPHNJHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7A2B170", Offset = "0x7A29F70", VA = "0x187A2B170")]
	private void KPPOKIBOEFD(AHBIEDFFEPN KHDOKMOIEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7A29F50", Offset = "0x7A28D50", VA = "0x187A29F50")]
	internal static string FPLGDPHANMC(AIDHKACIJHB PMGOGCCFPLO, PPNKBAMJHHC BGIEPHNJHFK, IReadOnlyDictionary<BKBFPOLBAFH, PBBNNNOGEEF> PDMNALNLJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7A2BE20", Offset = "0x7A2AC20", VA = "0x187A2BE20")]
	private static void OBGKJOMPPCA(PPNKBAMJHHC BGIEPHNJHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A5D0", Offset = "0x7A293D0", VA = "0x187A2A5D0")]
	private static void IFJIPLFPANA(AHBIEDFFEPN KLIFMNCGPCN, IReadOnlyDictionary<BKBFPOLBAFH, PBBNNNOGEEF> PDMNALNLJFE, StringBuilder GAGBDLBCCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A920", Offset = "0x7A29720", VA = "0x187A2A920")]
	private static bool JPAPIKBAOEF(string DCOLAJLCMPO, [Out] Guid NENBPFIMFEO, [Out] BKBFPOLBAFH JAPMOBILBFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7A2AA30", Offset = "0x7A29830", VA = "0x187A2AA30")]
	private static void KAOKACEHFFE(PPNKBAMJHHC BGIEPHNJHFK, StringBuilder GAGBDLBCCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3145230", Offset = "0x3144030", VA = "0x183145230", Slot = "16")]
	public bool PCEKHMJDCEC<T>(BKBFPOLBAFH JAPMOBILBFO, AKAGJKELAIJ LJDAGFFBNPJ, bool NMBDNKPKIBM, T BFLKHJBBCJI, [Optional] Action GEKPEIGPLNJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7A2B4B0", Offset = "0x7A2A2B0", VA = "0x187A2B4B0", Slot = "17")]
	public string LJACICBLADC(AKAGJKELAIJ LJDAGFFBNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A300", Offset = "0x7A29100", VA = "0x187A2A300")]
	private void GFAAHELKJAA(BKBFPOLBAFH JAPMOBILBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7A2BE00", Offset = "0x7A2AC00", VA = "0x187A2BE00")]
	private bool NLNLDLAOILE(NJGJGBGCLGP CJJBIEHOBCD, BKBFPOLBAFH JAPMOBILBFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7A29210", Offset = "0x7A28010", VA = "0x187A29210")]
	internal PBBNNNOGEEF CEGMHEHKBIF(NJGJGBGCLGP CJJBIEHOBCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7A29E30", Offset = "0x7A28C30", VA = "0x187A29E30", Slot = "13")]
	public IReadOnlyList<CLIEEENPCHG> FCGCJIGNGDH(NJGJGBGCLGP CJJBIEHOBCD, bool CMJLEFPNMBC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7A2D690", Offset = "0x7A2C490", VA = "0x187A2D690")]
	internal IReadOnlyList<PBBNNNOGEEF> PIPGGHCEPPA(NJGJGBGCLGP CJJBIEHOBCD, bool CMJLEFPNMBC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7A2CC60", Offset = "0x7A2BA60", VA = "0x187A2CC60")]
	private void PBNOPOAOMFO(GGKBCOPJEOE AEICPNFACPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7A296B0", Offset = "0x7A284B0", VA = "0x187A296B0")]
	private static bool DFELPCDPLFN(PBBNNNOGEEF ICONFAAKHJK, IReadOnlyDictionary<BKBFPOLBAFH, PBBNNNOGEEF> PDMNALNLJFE, [Out] IReadOnlyList<AKAGJKELAIJ> AJEFLFIDEFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7A290D0", Offset = "0x7A27ED0", VA = "0x187A290D0")]
	[AsyncStateMachine(typeof(MNEMDICMJOF))]
	private static Task CAAKGADADGC(AIDHKACIJHB PMGOGCCFPLO, PPNKBAMJHHC BGIEPHNJHFK, IReadOnlyDictionary<BKBFPOLBAFH, PBBNNNOGEEF> PDMNALNLJFE, LADPBGMMBAL GLBCCMFAHHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7A2BAE0", Offset = "0x7A2A8E0", VA = "0x187A2BAE0")]
	[CompilerGenerated]
	internal static void NEOCIELNIEM(Func<JKMMCFJFDOM, DEFICAKNLPJ> PBAEFPNOFLH, BGNDOAJHBCJ P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7A29AB0", Offset = "0x7A288B0", VA = "0x187A29AB0")]
	[CompilerGenerated]
	internal static bool EKIMNBBDICC(BKBFPOLBAFH JAPMOBILBFO, AKAGJKELAIJ LJDAGFFBNPJ, [Out] PDOBJFPEMLA LNMAOOJADED, GDBCFHCPMIB P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface MLDGJBBMMOD
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BHLDDOMBIMH(NJGJGBGCLGP MBOOBGGDJFM, NJGJGBGCLGP CFGPLKPAAII, IEnumerable<NJGJGBGCLGP> FKJFFHIICIF, [Out] EIKOAAHFIKH LLJOMMGKLPF, [Out] HKGDDDNHPIJ CBBCACJFLNG);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string EGMGIAOGHPD(HKGDDDNHPIJ FJHHKMBPNLG);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum HKGDDDNHPIJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal class PBOBNADKCIC : MLDGJBBMMOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly HEMBOGIJNDP NLKLIPKECJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly KHBEEJKDPGO NMPDMNLKILK;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x904660", Offset = "0x903460", VA = "0x180904660")]
	[RecRoom.NoEngine.Common.Preserve]
	public PBOBNADKCIC([MHFJPMCEEAM(null)] HEMBOGIJNDP LMMDFELKLHD, [MHFJPMCEEAM(null)] KHBEEJKDPGO BNIDNOFNGIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7A349C0", Offset = "0x7A337C0", VA = "0x187A349C0")]
	private static INMJDEGAJHE? BDAIFEKFELK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7A34A00", Offset = "0x7A33800", VA = "0x187A34A00", Slot = "4")]
	public bool BHLDDOMBIMH(NJGJGBGCLGP MBOOBGGDJFM, NJGJGBGCLGP CFGPLKPAAII, IEnumerable<NJGJGBGCLGP> FKJFFHIICIF, [Out] EIKOAAHFIKH LLJOMMGKLPF, [Out] HKGDDDNHPIJ CBBCACJFLNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7A34B00", Offset = "0x7A33900", VA = "0x187A34B00", Slot = "5")]
	public string EGMGIAOGHPD(HKGDDDNHPIJ FJHHKMBPNLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7A34C00", Offset = "0x7A33A00", VA = "0x187A34C00")]
	internal bool LKFFOPMDDEF(NJGJGBGCLGP MBOOBGGDJFM, NJGJGBGCLGP CFGPLKPAAII, IEnumerable<NJGJGBGCLGP> FKJFFHIICIF, DGCCNGNLMNC NINGHLHEEFJ, INMJDEGAJHE? BBAHJHHPJKO, [Out] EIKOAAHFIKH LLJOMMGKLPF, [Out] HKGDDDNHPIJ CBBCACJFLNG)
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
