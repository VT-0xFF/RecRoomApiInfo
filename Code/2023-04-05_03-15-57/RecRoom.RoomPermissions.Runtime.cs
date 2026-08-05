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
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x605C950", Offset = "0x605B950", VA = "0x18605C950")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FA6F0", Offset = "0x6F96F0", VA = "0x1806FA6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x929620", Offset = "0x928620", VA = "0x180929620")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum ABAIICINMAE
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum DHMIFMEHHDP
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void LNACEAALJOG<TPermission>(TPermission EIHABHNMPBN);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void GBMOIMIBNPE(HHHLLJHNCOK NDNGLDPCIOO);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FDLAGGGJMLG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MJCIMFBLOAD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool PPLECAIHMLI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool POAIMICLCMA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EONGECKEMMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool OLAFLLJFCIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool OCBAPCDJGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HLPNKBFBHCD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	MMLPLICBFIK PCADAGCMMLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IEnumerable<EIGIDBOBJAC> EGEFHNCGKCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event GBMOIMIBNPE DOAJMOJDPIF;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<EIGIDBOBJAC> CKIDFIMAGHJ(bool AJHGLAOKNLN = false);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EIGIDBOBJAC GGODCFMGGJE(HHHLLJHNCOK NDNGLDPCIOO);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FLMMHMKOKJA(HHHLLJHNCOK NDNGLDPCIOO);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<EIGIDBOBJAC> PLACNEOJJFB(HHHLLJHNCOK NDNGLDPCIOO, bool IPLHHFFNJGI = false);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NNCCANFPBPG(HHHLLJHNCOK NCDLBCPLNFM, JJBOGHIAHHF MPOAJHDCHHB);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EIGIDBOBJAC OIBKKAGGECH(JJBOGHIAHHF MPOAJHDCHHB);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool MCLBFDFIDOA<T>(JJBOGHIAHHF MPOAJHDCHHB, FEDLJEDCIIK EIHABHNMPBN, bool FHINJFLHHGF, T OGEFBAJDPAC) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface INALEGNHJCA
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ODDMDIHDGGI(JJGFELHFPKJ AONKGPLDMJF, CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DAEBOHJAKJB(ref JJGFELHFPKJ AONKGPLDMJF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GJLMGNINFJL
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	HHHLLJHNCOK NFIBBCBDIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	NHEFBAEFBAC CCKGOPHEAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	BDNDOPILCAE LNJBKJPHNAH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<LAMMDNMNDLA> JHDPNGEHEJP;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action FPHMLKGLBNE;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JJBOGHIAHHF JPJNDNBOGCD(HHHLLJHNCOK NDNGLDPCIOO);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<LAMMDNMNDLA> IEHADOFGJMD(CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task GENMINHPHMG(long BAOKNFPKMNE, long OJIIEAKAHEB, IReadOnlyList<BOCLPCAAMOI> GNFOINODOCG);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<HHHLLJHNCOK> LGCPBGBBKLE();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class LHDAAOPMKGC
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x605C8F0", Offset = "0x605B8F0", VA = "0x18605C8F0")]
	public static JJBOGHIAHHF BGDPGHNBOAA(this GJLMGNINFJL EMDBHOFJDCG)
	{
		return default(JJBOGHIAHHF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DHKEDBDOEMG<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string DGPHCLPLIDP
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event global::LNACEAALJOG<TPermission> JBLEPAOGFCD;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal static class OMBFLOOEKEH
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[Flags]
	public enum OODJIHHLGHP
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
	public static readonly Guid KNPEDPMNNDF;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid GIFGGALBBPI;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid BPHOAFNCMCG;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid HEPJCMLGALB;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid EBIILAPPIME;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly global::HAIKLLMLFID<JJBOGHIAHHF, Guid> KMGLACEDHIM;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	internal static IEnumerable<JJBOGHIAHHF> JLKGMNMAOOI
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x605DCE0", Offset = "0x605CCE0", VA = "0x18605DCE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x605DA90", Offset = "0x605CA90", VA = "0x18605DA90")]
	public static JJBOGHIAHHF ELGKMENJAEA(Guid DBODHDCBMLJ)
	{
		return default(JJBOGHIAHHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x605DC00", Offset = "0x605CC00", VA = "0x18605DC00")]
	public static Guid NDHNLMCFKMN(JJBOGHIAHHF MPOAJHDCHHB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x605D940", Offset = "0x605C940", VA = "0x18605D940")]
	public static bool ACGFIFCFKFI(JJBOGHIAHHF MPOAJHDCHHB, out Guid DBODHDCBMLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x605DB60", Offset = "0x605CB60", VA = "0x18605DB60")]
	public static bool MJEJLKBHGJL(Guid DBODHDCBMLJ, out JJBOGHIAHHF MPOAJHDCHHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x605DCB0", Offset = "0x605CCB0", VA = "0x18605DCB0")]
	public static JJBOGHIAHHF OGBLJJABNMG(JJBOGHIAHHF MPOAJHDCHHB)
	{
		return default(JJBOGHIAHHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x605D9E0", Offset = "0x605C9E0", VA = "0x18605D9E0")]
	public static OODJIHHLGHP BOJKKOBEEMI(JJBOGHIAHHF KCGHAKDCJEK)
	{
		return default(OODJIHHLGHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x605DB20", Offset = "0x605CB20", VA = "0x18605DB20")]
	internal static JJBOGHIAHHF EMEBDBIPNDK(OODJIHHLGHP GLKHFDPPNOI)
	{
		return default(JJBOGHIAHHF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class CECEPPKPHKJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? KBFAGCFIMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6FF130", Offset = "0x6FE130", VA = "0x1806FF130")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6DFF40", Offset = "0x6DEF40", VA = "0x1806DFF40")]
	protected CECEPPKPHKJ(object? PFFEAADBEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool NJAFIFNAEFP(object? KPPLMEOMNGF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class MOKHINFCPBM<T> : CECEPPKPHKJ where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private T CDGCECJFFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> DFFHCMEFKNA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T KMEGGOIFMKC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6F98D0", Offset = "0x6F88D0", VA = "0x1806F98D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x356B270", Offset = "0x356A270", VA = "0x18356B270", Slot = "4")]
	public override bool NJAFIFNAEFP(object? KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x356AE90", Offset = "0x3569E90", VA = "0x18356AE90")]
	public bool ADFJCMFCKBP(T AIOKFGLMALL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x356B520", Offset = "0x356A520", VA = "0x18356B520")]
	public MOKHINFCPBM(T PNIJKHBHNEL, IEqualityComparer<T> DFFHCMEFKNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class GMMLGDGIOOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<FEDLJEDCIIK, bool> BINPFIPGHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<FEDLJEDCIIK, CECEPPKPHKJ> IFFGMLHINHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly OGEHMPNFHDH NHDMBLDEJDD;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x605B8D0", Offset = "0x605A8D0", VA = "0x18605B8D0")]
	public GMMLGDGIOOB(OGEHMPNFHDH NHDMBLDEJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x605B5E0", Offset = "0x605A5E0", VA = "0x18605B5E0")]
	public bool FLPJCBCIFMB(FEDLJEDCIIK EIHABHNMPBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2327EE0", Offset = "0x2326EE0", VA = "0x182327EE0")]
	public bool JJLPHBAKNEB<T>(FEDLJEDCIIK EIHABHNMPBN, bool FHINJFLHHGF, T KPPLMEOMNGF) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x23279D0", Offset = "0x23269D0", VA = "0x1823279D0")]
	public (bool, T?) DAGBMMFHHBM<T>(FEDLJEDCIIK EIHABHNMPBN) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x605B650", Offset = "0x605A650", VA = "0x18605B650")]
	public bool JJLPHBAKNEB(FEDLJEDCIIK EIHABHNMPBN, bool FHINJFLHHGF, object KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x605B450", Offset = "0x605A450", VA = "0x18605B450")]
	public (bool, object) DAGBMMFHHBM(FEDLJEDCIIK EIHABHNMPBN)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2328060", Offset = "0x2327060", VA = "0x182328060")]
	private void LGFJOPONIED<T>(FEDLJEDCIIK EIHABHNMPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x605B520", Offset = "0x605A520", VA = "0x18605B520")]
	private CECEPPKPHKJ EOCKHCIFDKD(FEDLJEDCIIK EIHABHNMPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x605B730", Offset = "0x605A730", VA = "0x18605B730")]
	public void JPPAHPLGGMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class OOGAPGKHNFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string ACGAIIDMAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type GMMJFAJNKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly FIFAHLKDHDH OBCCHAOJLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly FEDLJEDCIIK MIBHOLGHOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public EDJONGOFAHM JMBGHLOBIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public FEJODFDOKGP JABAMJMEBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public EBKDKJPHAAD LBHNBNJKLFD;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x605E120", Offset = "0x605D120", VA = "0x18605E120")]
	public OOGAPGKHNFJ(Type JOBGFMCAIKL, string PHCCHJMBOBH, FEDLJEDCIIK EIHABHNMPBN, EDJONGOFAHM LNBEBAODJAK, FEJODFDOKGP GPJJPMALOME, EBKDKJPHAAD DDBCHFCMBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x605E0E0", Offset = "0x605D0E0", VA = "0x18605E0E0")]
	public object OLJIOGPNLLE(object? JHMCLPBFJBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x248B910", Offset = "0x248A910", VA = "0x18248B910")]
	public void LGFJOPONIED<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x605E030", Offset = "0x605D030", VA = "0x18605E030")]
	public void LGFJOPONIED(Type BLNDEIGBCPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class HLABMMLGIIH<T> : OOGAPGKHNFJ where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string HOCGFIPFFFG(T KPPLMEOMNGF);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T FFGBHFNJHKI(string? MDNEEIBIMEM, T PNIJKHBHNEL);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class AJMDAKDCMIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public HOCGFIPFFFG serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public FFGBHFNJHKI parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
		public AJMDAKDCMIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x24E87E0", Offset = "0x24E77E0", VA = "0x1824E87E0")]
		internal string <.ctor>b__0(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x24E88D0", Offset = "0x24E78D0", VA = "0x1824E88D0")]
		internal object <.ctor>b__1(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x33660F0", Offset = "0x33650F0", VA = "0x1833660F0")]
	public HLABMMLGIIH(FEDLJEDCIIK EIHABHNMPBN, string PHCCHJMBOBH, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6924B0", Offset = "0x6918B0")] global::HLABMMLGIIH<T>.HOCGFIPFFFG LNBEBAODJAK, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x692510", Offset = "0x691910")] global::HLABMMLGIIH<T>.FFGBHFNJHKI GPJJPMALOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3365670", Offset = "0x3364670", VA = "0x183365670")]
	private static object? EOLLHEJPBAN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x692570", Offset = "0x691970")] global::HLABMMLGIIH<T?>.FFGBHFNJHKI? GPJJPMALOME, string? MDNEEIBIMEM, object? PNIJKHBHNEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3365000", Offset = "0x3364000", VA = "0x183365000")]
	private static string CJKIIDNIDDE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6925D0", Offset = "0x6919D0")] global::HLABMMLGIIH<T>.HOCGFIPFFFG OFGMNAKIJFL, object? KPPLMEOMNGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string EDJONGOFAHM(object? KPPLMEOMNGF);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object FEJODFDOKGP(string? MDNEEIBIMEM, [Optional] object PNIJKHBHNEL);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate CECEPPKPHKJ EBKDKJPHAAD();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class OGEHMPNFHDH
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class KFKJLGFBJGG : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static KFKJLGFBJGG FDNKALDKIIB;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x605C5F0", Offset = "0x605B5F0", VA = "0x18605C5F0", Slot = "4")]
		public bool Equals(List<string> PMEDGJGANML, List<string> NIPKEFBPNPH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x605C750", Offset = "0x605B750", VA = "0x18605C750", Slot = "5")]
		public int GetHashCode(List<string> AELIHOPICED)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public KFKJLGFBJGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class EFGAODPBHOE : global::JKDOHAJKGJA<ABAIICINMAE>
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x60599B0", Offset = "0x60589B0", VA = "0x1860599B0", Slot = "9")]
		public override string CJKIIDNIDDE(ABAIICINMAE EDIBLNLAAHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6059AB0", Offset = "0x6058AB0", VA = "0x186059AB0", Slot = "10")]
		protected override bool NHAGNNJAFIM(string EDIBLNLAAHO, out ABAIICINMAE KPPLMEOMNGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6059CA0", Offset = "0x6058CA0", VA = "0x186059CA0")]
		public EFGAODPBHOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly GLDMBJOJPAD HEONFOCFEHH;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly EFGAODPBHOE MFGEIHGBLIF;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<OOGAPGKHNFJ> NAHDHMGFCKB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<FEDLJEDCIIK> AKOJDNKJHLA
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<FEDLJEDCIIK, OOGAPGKHNFJ> FDPCJHMBEGC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x605D5D0", Offset = "0x605C5D0", VA = "0x18605D5D0")]
	public OGEHMPNFHDH([Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x692630", Offset = "0x691A30")] IList<OOGAPGKHNFJ> HOJDKKPOFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x605C9E0", Offset = "0x605B9E0", VA = "0x18605C9E0")]
	public OOGAPGKHNFJ DLKOCKPCLAM(FEDLJEDCIIK EIHABHNMPBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MMLPLICBFIK
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	EIGIDBOBJAC IOJPFIKGBND
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class FLCLOBCKKKH : MMLPLICBFIK
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static FLCLOBCKKKH IFAFMEPOHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly APKPMFBFKDA HBPNANHHHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<APKPMFBFKDA> AFHGBNMOOBA;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public EIGIDBOBJAC IOJPFIKGBND
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x605B350", Offset = "0x605A350", VA = "0x18605B350")]
	public FLCLOBCKKKH(APKPMFBFKDA NEECDLEPFAP, IReadOnlyList<APKPMFBFKDA> JACHFDCLIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x605AB10", Offset = "0x6059B10", VA = "0x18605AB10")]
	private static FLCLOBCKKKH LJBJJCJOCJJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class GNAHKGIGMLK
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<JJBOGHIAHHF> ILMLOGOBGDO;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x605BB30", Offset = "0x605AB30", VA = "0x18605BB30")]
	public static bool AMJCADJFAIA(this HHHLLJHNCOK KPIHFPIPCFP, JJBOGHIAHHF MPOAJHDCHHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x605BC20", Offset = "0x605AC20", VA = "0x18605BC20")]
	public static bool LEHFOFDEOJP(this HHHLLJHNCOK KPIHFPIPCFP, JJBOGHIAHHF MPOAJHDCHHB, BDNDOPILCAE AMGBHNPAODF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface LFJCHGGILGN
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool FPFEDJAGJBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool CBKIICPHOOH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool CKHJAFOMHPE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool LCJDDIJPOIP
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool HOHAJKDIOFM
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool NAEIOHPEOHC
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool GEOAKEMEBEE
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool MLOGMBAHHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool KMKFGNLGMIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool AAKFNMLHEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool NLBEHDDNEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool ILODIABEOLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> BNPGFJBKAEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ABAIICINMAE KCCBICMCAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface EIGIDBOBJAC : LFJCHGGILGN, FDLAGGGJMLG, global::DHKEDBDOEMG<FEDLJEDCIIK>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string HKLMIJOFNBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	JJBOGHIAHHF MABFELIKMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) ADMKIIBHLBF<T>(FEDLJEDCIIK EIHABHNMPBN) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum FEDLJEDCIIK
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
internal class APKPMFBFKDA : EIGIDBOBJAC, LFJCHGGILGN, FDLAGGGJMLG, global::DHKEDBDOEMG<FEDLJEDCIIK>
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal static readonly OGEHMPNFHDH CPFBCLLDLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal readonly GMMLGDGIOOB PIDGHPLIBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private string? PEHDPDPPFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string? GCCOLFFIJHJ;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool FPFEDJAGJBM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x60522D0", Offset = "0x60512D0", VA = "0x1860522D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public ABAIICINMAE KCCBICMCAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6053240", Offset = "0x6052240", VA = "0x186053240", Slot = "20")]
		get
		{
			return default(ABAIICINMAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool CBKIICPHOOH
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6053100", Offset = "0x6052100", VA = "0x186053100", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool CKHJAFOMHPE
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6052110", Offset = "0x6051110", VA = "0x186052110", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool LCJDDIJPOIP
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6051BA0", Offset = "0x6050BA0", VA = "0x186051BA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool HOHAJKDIOFM
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x60532E0", Offset = "0x60522E0", VA = "0x1860532E0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool NAEIOHPEOHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6051B00", Offset = "0x6050B00", VA = "0x186051B00", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool GEOAKEMEBEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6052230", Offset = "0x6051230", VA = "0x186052230", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool MLOGMBAHHHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6052570", Offset = "0x6051570", VA = "0x186052570", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool KMKFGNLGMIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x60531A0", Offset = "0x60521A0", VA = "0x1860531A0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<string> BNPGFJBKAEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x60524A0", Offset = "0x60514A0", VA = "0x1860524A0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool OLFAFMPGFHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x60520C0", Offset = "0x60510C0", VA = "0x1860520C0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HMCIDNLJLDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6052280", Offset = "0x6051280", VA = "0x186052280", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool DIJKFOFENNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6051A60", Offset = "0x6050A60", VA = "0x186051A60", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool AAKFNMLHEOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6051AB0", Offset = "0x6050AB0", VA = "0x186051AB0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool NLBEHDDNEKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6052500", Offset = "0x6051500", VA = "0x186052500", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool NDNNNCFICKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6053290", Offset = "0x6052290", VA = "0x186053290", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool ILODIABEOLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6052160", Offset = "0x6051160", VA = "0x186052160", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool JOAHNJEPEFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6051B50", Offset = "0x6050B50", VA = "0x186051B50", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool HJGJCGBIOKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6053150", Offset = "0x6052150", VA = "0x186053150", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private bool PDDPPPAPMMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x60520C0", Offset = "0x60510C0", VA = "0x1860520C0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private bool DJBCEKIANAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6051A60", Offset = "0x6050A60", VA = "0x186051A60", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private bool EPBCOJMEMIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6053290", Offset = "0x6052290", VA = "0x186053290", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool GJFJBAOLGBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6051B50", Offset = "0x6050B50", VA = "0x186051B50", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool LKMCFFLMPMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6052280", Offset = "0x6051280", VA = "0x186052280", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private bool FHMCBNFPMEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6053150", Offset = "0x6052150", VA = "0x186053150", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public JJBOGHIAHHF MABFELIKMNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F98D0", Offset = "0x6F88D0", VA = "0x1806F98D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(JJBOGHIAHHF);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x71B000", Offset = "0x71A000", VA = "0x18071B000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string DGPHCLPLIDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x60531F0", Offset = "0x60521F0", VA = "0x1860531F0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6053710", Offset = "0x6052710", VA = "0x186053710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string HKLMIJOFNBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x60531F0", Offset = "0x60521F0", VA = "0x1860531F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool LKOOCCJNKDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7AA560", Offset = "0x7A9560", VA = "0x1807AA560")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x940400", Offset = "0x93F400", VA = "0x180940400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::LNACEAALJOG<FEDLJEDCIIK> JBLEPAOGFCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6052400", Offset = "0x6051400", VA = "0x186052400", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6053330", Offset = "0x6052330", VA = "0x186053330", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6051850", Offset = "0x6050850", VA = "0x186051850")]
	public HAPNDAPHNLO ACFOPKFACGN(Func<JJBOGHIAHHF, Guid> FCPHLAPIFEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x60526C0", Offset = "0x60516C0", VA = "0x1860526C0")]
	public void KGLJMPELIGJ(HAPNDAPHNLO ACPAJKJBIEN, Func<Guid, JJBOGHIAHHF> EGLGMFKFFMN, [Optional] JJBOGHIAHHF? GIGJMPKPCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x37C95E0", Offset = "0x37C85E0", VA = "0x1837C95E0", Slot = "6")]
	public (bool, T?) ADMKIIBHLBF<T>(FEDLJEDCIIK EIHABHNMPBN) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x37C9770", Offset = "0x37C8770", VA = "0x1837C9770")]
	public APKPMFBFKDA BLMHHJAAPML<T>(FEDLJEDCIIK EIHABHNMPBN, bool FHINJFLHHGF, T KPPLMEOMNGF) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x60539D0", Offset = "0x60529D0", VA = "0x1860539D0")]
	public APKPMFBFKDA(JJBOGHIAHHF MPOAJHDCHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6053920", Offset = "0x6052920", VA = "0x186053920")]
	public APKPMFBFKDA(JJBOGHIAHHF MPOAJHDCHHB, [Optional] string? PEHDPDPPFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6053940", Offset = "0x6052940", VA = "0x186053940")]
	public APKPMFBFKDA(APKPMFBFKDA PBPLAEMNFNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x60537D0", Offset = "0x60527D0", VA = "0x1860537D0")]
	internal APKPMFBFKDA(JJBOGHIAHHF CHOINEOJPPO, [Optional] string? PEHDPDPPFGC, [Optional] APKPMFBFKDA? PBPLAEMNFNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x60521B0", Offset = "0x60511B0", VA = "0x1860521B0")]
	public static FIFAHLKDHDH FLHNJILGIMA(FEDLJEDCIIK EIHABHNMPBN)
	{
		return default(FIFAHLKDHDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6052550", Offset = "0x6051550", VA = "0x186052550")]
	public void JPPAHPLGGMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x60533D0", Offset = "0x60523D0", VA = "0x1860533D0")]
	internal APKPMFBFKDA PJDIOOODAHG(APKPMFBFKDA MILNOPOJFHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6051C90", Offset = "0x6050C90", VA = "0x186051C90")]
	internal IReadOnlyCollection<FEDLJEDCIIK> EBGLHADENDP(APKPMFBFKDA PBPLAEMNFNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6052320", Offset = "0x6051320", VA = "0x186052320")]
	public bool GIJIKGDFJJH(FEDLJEDCIIK EIHABHNMPBN, bool FHINJFLHHGF, string NPFFGEKMDIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x60525C0", Offset = "0x60515C0", VA = "0x1860525C0")]
	public (bool, string) KDPIHOLGFEE(FEDLJEDCIIK EIHABHNMPBN)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6051BF0", Offset = "0x6050BF0", VA = "0x186051BF0")]
	internal void EBAFDPJDKIL(FEDLJEDCIIK EIHABHNMPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6053070", Offset = "0x6052070", VA = "0x186053070")]
	[CompilerGenerated]
	private void LFFCDIGLFAI(FEDLJEDCIIK LMDBPKDOLPG, DJOJKMKIIMB MFNFBDDPFKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class COGCBBLGCMF : INALEGNHJCA, HLPNKBFBHCD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class HGGILFIKJFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public APKPMFBFKDA newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public HGGILFIKJFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x605BF90", Offset = "0x605AF90", VA = "0x18605BF90")]
		internal bool <InitializeRolesLists>b__0(APKPMFBFKDA rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class HIKHHDPFCIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public JJBOGHIAHHF roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public HIKHHDPFCIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x605BFC0", Offset = "0x605AFC0", VA = "0x18605BFC0")]
		internal bool <UpdateRoleDatas>b__0(JJBOGHIAHHF r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct IKOGPDLIMNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public COGCBBLGCMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public JJGFELHFPKJ roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x692BE0", Offset = "0x691FE0")]
		private TaskAwaiter<LAMMDNMNDLA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x605BFD0", Offset = "0x605AFD0", VA = "0x18605BFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6E7320", Offset = "0x6E6320", VA = "0x1806E7320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class DJEDNEGHDNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public DJEDNEGHDNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x60597B0", Offset = "0x60587B0", VA = "0x1860597B0")]
		internal void <RunBackwardsCompatibilityMigration>b__0(HAPNDAPHNLO r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6059890", Offset = "0x6058890", VA = "0x186059890")]
		internal void <RunBackwardsCompatibilityMigration>b__1(HAPNDAPHNLO r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct KGKAICBJEDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public JJGFELHFPKJ roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class HABJIHKGIAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x692C40", Offset = "0x692040")]
		public Func<HAPNDAPHNLO, DJOJKMKIIMB> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public HABJIHKGIAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x605BE70", Offset = "0x605AE70", VA = "0x18605BE70")]
		internal void <MigrateLegacyHostSettings>b__1(HAPNDAPHNLO r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x605BED0", Offset = "0x605AED0", VA = "0x18605BED0")]
		internal void <MigrateLegacyHostSettings>b__2(HAPNDAPHNLO r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x605BF30", Offset = "0x605AF30", VA = "0x18605BF30")]
		internal void <MigrateLegacyHostSettings>b__3(HAPNDAPHNLO r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class NAHKLEAJGEO<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public COGCBBLGCMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public FEDLJEDCIIK rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public JJBOGHIAHHF accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public FIFAHLKDHDH recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
		public NAHKLEAJGEO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct HMEBNFKKIGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public IReadOnlyList<BOCLPCAAMOI> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct FIJJCNOLIFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public GJLMGNINFJL rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public JJGFELHFPKJ roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x692D50", Offset = "0x692150")]
		public IReadOnlyDictionary<JJBOGHIAHHF, APKPMFBFKDA> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public JIENPLKFJBP debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x605A100", Offset = "0x6059100", VA = "0x18605A100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6E7320", Offset = "0x6E6320", VA = "0x1806E7320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly GJLMGNINFJL EMDBHOFJDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly FLCLOBCKKKH EFMHLAFEMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly JIENPLKFJBP LJOCFDIHGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly Dictionary<int, APKPMFBFKDA> HKDOBPHJEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal readonly Dictionary<JJBOGHIAHHF, APKPMFBFKDA> BCHELNHJABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	internal readonly Dictionary<JJBOGHIAHHF, APKPMFBFKDA> CJLCOBAKCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly List<APKPMFBFKDA> BFEIBJKBDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool PPNKDGLHKEB;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly FEDLJEDCIIK[] LDGIPKLMGIJ;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public MMLPLICBFIK PCADAGCMMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<EIGIDBOBJAC> EGEFHNCGKCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x60546A0", Offset = "0x60536A0", VA = "0x1860546A0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event GBMOIMIBNPE DOAJMOJDPIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x60584F0", Offset = "0x60574F0", VA = "0x1860584F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6056D90", Offset = "0x6055D90", VA = "0x186056D90", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6054060", Offset = "0x6053060", VA = "0x186054060")]
	[JDLBAGCFHIO(KHPALILEHND.Room, MEDANDNEHIF.None)]
	private static void BIFJHPEDGNI(DDFGGHLLPGI AFNEOPLHKCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6059520", Offset = "0x6058520", VA = "0x186059520")]
	[UnityEngine.Scripting.Preserve]
	internal COGCBBLGCMF([KCHLPHCLLFB(null)] GJLMGNINFJL GAIDIAKGALN, [KCHLPHCLLFB(null)] FLCLOBCKKKH JKAEKLMNJPA, [KCHLPHCLLFB(null)] JIENPLKFJBP LJOCFDIHGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6054590", Offset = "0x6053590", VA = "0x186054590", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x60574E0", Offset = "0x60564E0", VA = "0x1860574E0")]
	private void JNMNIFIJCJB(IEnumerable<APKPMFBFKDA> IJJPHDCGCOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6054A00", Offset = "0x6053A00", VA = "0x186054A00", Slot = "12")]
	public bool FLMMHMKOKJA(HHHLLJHNCOK NDNGLDPCIOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6054AD0", Offset = "0x6053AD0", VA = "0x186054AD0")]
	private void FPHMLKGLBNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6054220", Offset = "0x6053220", VA = "0x186054220")]
	private void CDJHDBAEEGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x60543B0", Offset = "0x60533B0", VA = "0x1860543B0", Slot = "10")]
	public IReadOnlyList<EIGIDBOBJAC> CKIDFIMAGHJ(bool AJHGLAOKNLN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6055340", Offset = "0x6054340", VA = "0x186055340", Slot = "11")]
	public EIGIDBOBJAC GGODCFMGGJE(HHHLLJHNCOK NDNGLDPCIOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6054AE0", Offset = "0x6053AE0", VA = "0x186054AE0")]
	private JJBOGHIAHHF GABPMCMOFMO(HHHLLJHNCOK NDNGLDPCIOO)
	{
		return default(JJBOGHIAHHF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6058800", Offset = "0x6057800", VA = "0x186058800", Slot = "14")]
	public bool NNCCANFPBPG(HHHLLJHNCOK NCDLBCPLNFM, JJBOGHIAHHF MPOAJHDCHHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6058AF0", Offset = "0x6057AF0", VA = "0x186058AF0", Slot = "15")]
	public EIGIDBOBJAC OIBKKAGGECH(JJBOGHIAHHF MPOAJHDCHHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6057E30", Offset = "0x6056E30", VA = "0x186057E30")]
	private static bool LCLPFCBDLPO(NILKMOENNBB MKKEMBMPMJA, JJBOGHIAHHF MPOAJHDCHHB, out HAPNDAPHNLO? PGNECNDDEDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6056780", Offset = "0x6055780", VA = "0x186056780")]
	private static void GOEJFCGIDIM(NILKMOENNBB MKKEMBMPMJA, Action<HAPNDAPHNLO> LDHKBJPFNAK, JJBOGHIAHHF BKPDGJHDGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6056580", Offset = "0x6055580", VA = "0x186056580")]
	private static void GOEJFCGIDIM(NILKMOENNBB MKKEMBMPMJA, Action<HAPNDAPHNLO> LDHKBJPFNAK, Predicate<JJBOGHIAHHF> PEFAFGEKCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6058BB0", Offset = "0x6057BB0", VA = "0x186058BB0")]
	private void PNLBECIGMIJ(HHHLLJHNCOK NDNGLDPCIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6058990", Offset = "0x6057990", VA = "0x186058990", Slot = "4")]
	[AsyncStateMachine(typeof(IKOGPDLIMNO))]
	public Task ODDMDIHDGGI([CanBeNull] JJGFELHFPKJ AONKGPLDMJF, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
	public void DAEBOHJAKJB(ref JJGFELHFPKJ AONKGPLDMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6058590", Offset = "0x6057590", VA = "0x186058590")]
	private void NICAHJDINOI(NILKMOENNBB BEEIGJBDALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x60581F0", Offset = "0x60571F0", VA = "0x1860581F0")]
	internal static string LGODGCGBDFB(GJLMGNINFJL EMDBHOFJDCG, JJGFELHFPKJ AONKGPLDMJF, IReadOnlyDictionary<JJBOGHIAHHF, APKPMFBFKDA> BCHELNHJABF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6055720", Offset = "0x6054720", VA = "0x186055720")]
	private static void GIDHJMDGEJP(JJGFELHFPKJ AONKGPLDMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x60546F0", Offset = "0x60536F0", VA = "0x1860546F0")]
	private static void FAFJOBNKAPG(NILKMOENNBB LBFBONPIEFN, IReadOnlyDictionary<JJBOGHIAHHF, APKPMFBFKDA> BCHELNHJABF, StringBuilder EGLEOHFELFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6057CD0", Offset = "0x6056CD0", VA = "0x186057CD0")]
	private static bool KCIGJFONIPL(string EAGIBFMLMCB, out Guid DCPBAFEBJGH, out JJBOGHIAHHF MPOAJHDCHHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6054D60", Offset = "0x6053D60", VA = "0x186054D60")]
	private static void GBGLBBMMMAO(JJGFELHFPKJ AONKGPLDMJF, StringBuilder EGLEOHFELFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2842590", Offset = "0x2841590", VA = "0x182842590", Slot = "16")]
	public bool MCLBFDFIDOA<T>(JJBOGHIAHHF MPOAJHDCHHB, FEDLJEDCIIK EIHABHNMPBN, bool FHINJFLHHGF, T OGEFBAJDPAC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6054BA0", Offset = "0x6053BA0", VA = "0x186054BA0")]
	private void GADOFAFMEOF(JJBOGHIAHHF MPOAJHDCHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6058AD0", Offset = "0x6057AD0", VA = "0x186058AD0")]
	private bool OFPEJEAKLCG(HHHLLJHNCOK NDNGLDPCIOO, JJBOGHIAHHF MPOAJHDCHHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6056E30", Offset = "0x6055E30", VA = "0x186056E30")]
	internal APKPMFBFKDA JDBOPFCOBEJ(HHHLLJHNCOK NDNGLDPCIOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6058BA0", Offset = "0x6057BA0", VA = "0x186058BA0", Slot = "13")]
	public IReadOnlyList<EIGIDBOBJAC> PLACNEOJJFB(HHHLLJHNCOK NDNGLDPCIOO, bool IPLHHFFNJGI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6056B70", Offset = "0x6055B70", VA = "0x186056B70")]
	internal IReadOnlyList<APKPMFBFKDA> IHFBEIIJMFI(HHHLLJHNCOK NDNGLDPCIOO, bool IPLHHFFNJGI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6058C10", Offset = "0x6057C10", VA = "0x186058C10")]
	private void POGIFOFMLPC(LAMMDNMNDLA FHFNAAGDGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6056880", Offset = "0x6055880", VA = "0x186056880")]
	private static bool HCDCDHJGOIM(APKPMFBFKDA KDLKMKMLKBA, IReadOnlyDictionary<JJBOGHIAHHF, APKPMFBFKDA> BCHELNHJABF, out IReadOnlyList<FEDLJEDCIIK> LDHOHMLEHLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6054430", Offset = "0x6053430", VA = "0x186054430")]
	[AsyncStateMachine(typeof(FIJJCNOLIFD))]
	private static Task DCDFGDHDBCP(GJLMGNINFJL EMDBHOFJDCG, JJGFELHFPKJ AONKGPLDMJF, IReadOnlyDictionary<JJBOGHIAHHF, APKPMFBFKDA> BCHELNHJABF, JIENPLKFJBP LJOCFDIHGLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6055450", Offset = "0x6054450", VA = "0x186055450")]
	[CompilerGenerated]
	internal static void GHOLHEPPMON(Func<HAPNDAPHNLO, DJOJKMKIIMB> FPEKOCPDFBH, ref KGKAICBJEDB P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6057150", Offset = "0x6056150", VA = "0x186057150")]
	[CompilerGenerated]
	internal static bool JFLLFNLCCIF(JJBOGHIAHHF MPOAJHDCHHB, FEDLJEDCIIK EIHABHNMPBN, out BOCLPCAAMOI JIDOIAPOAIO, ref HMEBNFKKIGA P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface COOGHMOIHBB
{
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GKJABNNNKPP(HHHLLJHNCOK CDDKFAHNNFG, HHHLLJHNCOK CCJMPIMGLPK, IEnumerable<HHHLLJHNCOK> JDACMMAGACO, out ABAIICINMAE HDEEDKEAIBA, out JEPMBNHGGMJ JCNJLCOGGJA);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum JEPMBNHGGMJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	CantKickEventOrganizer
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class BCONCNOEOMO : COOGHMOIHBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly HLPNKBFBHCD HOMEODBOMEA;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6DFF40", Offset = "0x6DEF40", VA = "0x1806DFF40")]
	[RecRoom.NoEngine.Common.Preserve]
	public BCONCNOEOMO([KCHLPHCLLFB(null)] HLPNKBFBHCD KDCMHIFFEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6054010", Offset = "0x6053010", VA = "0x186054010")]
	private static IFBOHPHODNG? HHENPBHOJHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x60539F0", Offset = "0x60529F0", VA = "0x1860539F0", Slot = "4")]
	public bool GKJABNNNKPP(HHHLLJHNCOK CDDKFAHNNFG, HHHLLJHNCOK CCJMPIMGLPK, IEnumerable<HHHLLJHNCOK> JDACMMAGACO, out ABAIICINMAE HDEEDKEAIBA, out JEPMBNHGGMJ JCNJLCOGGJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6053B00", Offset = "0x6052B00", VA = "0x186053B00")]
	internal bool GPLFGCAIJGI(HHHLLJHNCOK CDDKFAHNNFG, HHHLLJHNCOK CCJMPIMGLPK, IEnumerable<HHHLLJHNCOK> JDACMMAGACO, BDNDOPILCAE AMGBHNPAODF, IFBOHPHODNG? FANLEHDHGKJ, out ABAIICINMAE HDEEDKEAIBA, out JEPMBNHGGMJ JCNJLCOGGJA)
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
