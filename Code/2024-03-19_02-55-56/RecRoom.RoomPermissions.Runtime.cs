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
		[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
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
		[Cpp2IlInjected.Address(RVA = "0x67E8E60", Offset = "0x67E7E60", VA = "0x1867E8E60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E62B0", Offset = "0x7E52B0", VA = "0x1807E62B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E62F0", Offset = "0x7E52F0", VA = "0x1807E62F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum KJIBADFBHJF
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void DJNOAFGDEMH<TPermission>(TPermission POCAHPPHAEE);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void IGACNGKAAGM(IDMICLLCMKN JAPHEDILMIF);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum FJKCCKGOOKD
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EICEHFLBLCO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BHEOHCHAOOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool KDNNHJAKMFE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool OHCLDNDLNPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CKDLDAOFLCN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool GBNONAEKALG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MPBKGFOFOIO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class KAFHHIMAGIJ
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum NEBOPPCMNCD
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
	public static readonly Guid NFCGKFMBMPI;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid PAMCDMKEEHG;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid OOCKGGEAAHC;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid HIMMEGEPEDK;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid NLHBGHKIBJL;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid MAODGDBCFOE;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly HJGPAECFMAI<NAIBPKJALIN, Guid> GLMDKHILCPG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<NAIBPKJALIN> NJAJCABACCC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x67E28B0", Offset = "0x67E18B0", VA = "0x1867E28B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x67E2A10", Offset = "0x67E1A10", VA = "0x1867E2A10")]
	public static NAIBPKJALIN JBOCDKAPOHI(Guid IECJFMHCKJI)
	{
		return default(NAIBPKJALIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x67E2BE0", Offset = "0x67E1BE0", VA = "0x1867E2BE0")]
	public static Guid PFDKMAAIJDI(NAIBPKJALIN BHLBNOJEAPK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x67E2B50", Offset = "0x67E1B50", VA = "0x1867E2B50")]
	public static bool MMIKMEGAJGF(NAIBPKJALIN BHLBNOJEAPK, [Out] Guid IECJFMHCKJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x67E2930", Offset = "0x67E1930", VA = "0x1867E2930")]
	public static bool ECEHMELPEKN(Guid IECJFMHCKJI, [Out] NAIBPKJALIN BHLBNOJEAPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x67E2870", Offset = "0x67E1870", VA = "0x1867E2870")]
	public static NAIBPKJALIN BLJAAIJLEKA(NAIBPKJALIN BHLBNOJEAPK)
	{
		return default(NAIBPKJALIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x67E2AA0", Offset = "0x67E1AA0", VA = "0x1867E2AA0")]
	public static NEBOPPCMNCD LFMOJOPKIDM(NAIBPKJALIN KCHKCJPBAKL)
	{
		return default(NEBOPPCMNCD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x67E29D0", Offset = "0x67E19D0", VA = "0x1867E29D0")]
	internal static NAIBPKJALIN IHLBPACNEBC(NEBOPPCMNCD NIHCFKKGPCJ)
	{
		return default(NAIBPKJALIN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KKFOKNAMILI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	GOMIIAPFFFJ CLKONPKEALD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<FMNPKCHFFBM> GGMOMLAKAOG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event IGACNGKAAGM NKFKHKILOJD;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<FMNPKCHFFBM> HMGHMMCHINC(bool ONDLFANIMON = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FMNPKCHFFBM JCBADJFJMGD(IDMICLLCMKN JAPHEDILMIF);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LIMALANANCM(IDMICLLCMKN JAPHEDILMIF);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<FMNPKCHFFBM> IPFICCJBLHK(IDMICLLCMKN JAPHEDILMIF, bool AJEDGNKIAEB = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool IICLPHDAJOE(IDMICLLCMKN CBDHFKDPKHP, NAIBPKJALIN BHLBNOJEAPK);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FMNPKCHFFBM FIHGHLMAIHK(NAIBPKJALIN BHLBNOJEAPK);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool DDOKOPMMNLP<T>(NAIBPKJALIN BHLBNOJEAPK, DOBDIFABPNA POCAHPPHAEE, bool CBFKMLEHELC, T OMFIAODHHCI, [Optional] Action NDPDMBAAHDB) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OGJNPDODFEE
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LILAKNHJFLH(GBMJEMECJOI PCNPJGFONNP, CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MFAGOLIIMLH(GBMJEMECJOI PCNPJGFONNP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LHLIONIHIDG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	IDMICLLCMKN MANEOCFHCMI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	ICNKHIIJEIP BMKCGCPEPEE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	HHOALKJJLEH CLDIFHIIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<LNJINCIGKMC> GIJIENJIMLB;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action NANIPCFFPGC;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NAIBPKJALIN CBIOMFBPNJP(IDMICLLCMKN JAPHEDILMIF);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<LNJINCIGKMC> GDBIIONEPDI(CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task DINFEOKNCBH(long INFPDCJCIBN, long CNPHGBDAJDM, IReadOnlyList<BAHDPCDNAEL> NCEEHCIBGDB);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<IDMICLLCMKN> AAHAHFOAAON();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LALMNOHCGKG
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x67E32B0", Offset = "0x67E22B0", VA = "0x1867E32B0")]
	public static NAIBPKJALIN DHNJLNDJGOJ(this LHLIONIHIDG KLEKPBFBGEE)
	{
		return default(NAIBPKJALIN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EPBDIDNCNBP<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string DOGCKNBPLKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event DJNOAFGDEMH<TPermission> HLBBGHFBKLC;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class GDFCHDDAFMG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? KKDBPNLBELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7BC250", Offset = "0x7BB250", VA = "0x1807BC250")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	protected GDFCHDDAFMG(object? KAKIOBKMHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool PCFAENMLAHJ(object? CFJDHAGGAJO);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class AFOHKKDFJCG<T> : GDFCHDDAFMG where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T HCFMMLEKKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> IKJKCDAEEGG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T ADACBBLDADO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x835210", Offset = "0x834210", VA = "0x180835210")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x37A0AC0", Offset = "0x379FAC0", VA = "0x1837A0AC0", Slot = "4")]
	public override bool PCFAENMLAHJ(object? CFJDHAGGAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x37A06B0", Offset = "0x379F6B0", VA = "0x1837A06B0")]
	public bool ECLIBCHDBGF(T CCBJFLPFAFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x37A0E60", Offset = "0x379FE60", VA = "0x1837A0E60")]
	public AFOHKKDFJCG(T BKJBKPCHJIH, IEqualityComparer<T> IKJKCDAEEGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class ELLKNAAOADK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<DOBDIFABPNA, bool> MBNPGCNBOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<DOBDIFABPNA, GDFCHDDAFMG> OAGBGHJIPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly AMKPLGOEIIA EOIKFGLCHFK;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x67E0990", Offset = "0x67DF990", VA = "0x1867E0990")]
	public ELLKNAAOADK(AMKPLGOEIIA EOIKFGLCHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x67E0840", Offset = "0x67DF840", VA = "0x1867E0840")]
	public bool FBGCHAKADPP(DOBDIFABPNA POCAHPPHAEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2672090", Offset = "0x2671090", VA = "0x182672090")]
	public bool PJOPGKFJMHE<T>(DOBDIFABPNA POCAHPPHAEE, bool CBFKMLEHELC, T CFJDHAGGAJO) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2671CC0", Offset = "0x2670CC0", VA = "0x182671CC0")]
	public (bool, T?) DNFDMPNPPDE<T>(DOBDIFABPNA POCAHPPHAEE) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x67E08B0", Offset = "0x67DF8B0", VA = "0x1867E08B0")]
	public bool PJOPGKFJMHE(DOBDIFABPNA POCAHPPHAEE, bool CBFKMLEHELC, object CFJDHAGGAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x67E0570", Offset = "0x67DF570", VA = "0x1867E0570")]
	public (bool, object) DNFDMPNPPDE(DOBDIFABPNA POCAHPPHAEE)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2671C80", Offset = "0x2670C80", VA = "0x182671C80")]
	private void BAMKIGCLEHJ<T>(DOBDIFABPNA POCAHPPHAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x67E04A0", Offset = "0x67DF4A0", VA = "0x1867E04A0")]
	private GDFCHDDAFMG AKCMJKHPJGA(DOBDIFABPNA POCAHPPHAEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x67E0640", Offset = "0x67DF640", VA = "0x1867E0640")]
	public void ECMBFOOANAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class DBKKJDEFDNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string JMOGNGDMLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type LAOMKNHICLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly OKPLLBLPLHF EEEBDGODNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly DOBDIFABPNA NDMHAJKGBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public GDEPEMNJKCK JOBEPPABNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public OLNHOMDMBND NFIHPFDIODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public FKLMJCCDOPI LFBPGFMGDJC;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x67DF8C0", Offset = "0x67DE8C0", VA = "0x1867DF8C0")]
	public DBKKJDEFDNH(Type BOAOBNNOLMM, string BOIAODNFBGN, DOBDIFABPNA POCAHPPHAEE, GDEPEMNJKCK HMDENKAONNF, OLNHOMDMBND GJJPPFHJEPA, FKLMJCCDOPI LMKEFMJIFMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x67DF870", Offset = "0x67DE870", VA = "0x1867DF870")]
	public object BBCGMPJOPDM(object? PJNBIAFGNNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2634A90", Offset = "0x2633A90", VA = "0x182634A90")]
	public void BAMKIGCLEHJ<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x67DF7C0", Offset = "0x67DE7C0", VA = "0x1867DF7C0")]
	public void BAMKIGCLEHJ(Type KIKEIDFADLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class BBPJPDPMGDG<T> : DBKKJDEFDNH where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string FOJFEMKCGCI(T CFJDHAGGAJO);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T GEACKDPCOAN(string? JBFMNNMPION, T BKJBKPCHJIH);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class DFJLCAFPKHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public FOJFEMKCGCI serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public GEACKDPCOAN parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public DFJLCAFPKHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x50BF470", Offset = "0x50BE470", VA = "0x1850BF470")]
		internal string GJOCKLAPALG(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x50BF4A0", Offset = "0x50BE4A0", VA = "0x1850BF4A0")]
		internal object JMKOIDICABC(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x478F3C0", Offset = "0x478E3C0", VA = "0x18478F3C0")]
	public BBPJPDPMGDG(DOBDIFABPNA POCAHPPHAEE, string BOIAODNFBGN, [Optional] FOJFEMKCGCI? HMDENKAONNF, [Optional] GEACKDPCOAN? GJJPPFHJEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x478E2C0", Offset = "0x478D2C0", VA = "0x18478E2C0")]
	private static object? MPIEPNPHGIA(GEACKDPCOAN? GJJPPFHJEPA, string? JBFMNNMPION, object? BKJBKPCHJIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x478EDD0", Offset = "0x478DDD0", VA = "0x18478EDD0")]
	private static string PAKOMNGHIKD(FOJFEMKCGCI? BAAEKODAMPA, object? CFJDHAGGAJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string GDEPEMNJKCK(object? CFJDHAGGAJO);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object OLNHOMDMBND(string? JBFMNNMPION, [Optional] object BKJBKPCHJIH);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate GDFCHDDAFMG FKLMJCCDOPI();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class AMKPLGOEIIA
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class HJBJKIHJECF : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static HJBJKIHJECF GDAKEGIGEFB;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x67E0F60", Offset = "0x67DFF60", VA = "0x1867E0F60", Slot = "4")]
		public bool Equals(List<string> GDALFMOOMGE, List<string> CPFDGDKGJBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x67E10B0", Offset = "0x67E00B0", VA = "0x1867E10B0", Slot = "5")]
		public int GetHashCode(List<string> FGOCJODIEMI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public HJBJKIHJECF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class HEJFDFIAFGK : OBJOEGHGFEF<KJIBADFBHJF>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x67E0E30", Offset = "0x67DFE30", VA = "0x1867E0E30", Slot = "9")]
		public override string PAKOMNGHIKD(KJIBADFBHJF IIBDJBFNFJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x67E0C50", Offset = "0x67DFC50", VA = "0x1867E0C50", Slot = "10")]
		protected override bool HPFFHHOOAMF(string IIBDJBFNFJM, [Out] KJIBADFBHJF CFJDHAGGAJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x67E0F20", Offset = "0x67DFF20", VA = "0x1867E0F20")]
		public HEJFDFIAFGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly OCDCBCHCLHI FFDAEPNFMFL;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly HEJFDFIAFGK BNMAECMDOEB;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<DBKKJDEFDNH> LAJAFHIBIED;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<DOBDIFABPNA> DBDLGOAJLKK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<DOBDIFABPNA, DBKKJDEFDNH> ILKFHHAFKCM
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x67DCBC0", Offset = "0x67DBBC0", VA = "0x1867DCBC0")]
	public AMKPLGOEIIA([Optional] IList<DBKKJDEFDNH>? FIAOJOFDJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x67DBD50", Offset = "0x67DAD50", VA = "0x1867DBD50")]
	public DBKKJDEFDNH AAEBFGBIGPE(DOBDIFABPNA POCAHPPHAEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface GOMIIAPFFFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	FMNPKCHFFBM LBJFOHCMABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class DDPPHIJGMHA : GOMIIAPFFFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static DDPPHIJGMHA HLIDKALDFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly AOCCGIPHCFD DMGIDFMEBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<AOCCGIPHCFD> BNEJLAIPPLH;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public FMNPKCHFFBM LBJFOHCMABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x67E0390", Offset = "0x67DF390", VA = "0x1867E0390")]
	public DDPPHIJGMHA(AOCCGIPHCFD PDPNHDOAEHM, IReadOnlyList<AOCCGIPHCFD> MMGNOIEHEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x67DF960", Offset = "0x67DE960", VA = "0x1867DF960")]
	private static DDPPHIJGMHA OLPOKNMBNOD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class KLHDJLGNDNB
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<NAIBPKJALIN> PAPCCKGLMLC;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x67E2FA0", Offset = "0x67E1FA0", VA = "0x1867E2FA0")]
	public static bool GKAKLBFBFAG(this IDMICLLCMKN KOIELLGDMII, NAIBPKJALIN BHLBNOJEAPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x67E3080", Offset = "0x67E2080", VA = "0x1867E3080")]
	public static bool IBBHIBNNJHJ(this IDMICLLCMKN KOIELLGDMII, NAIBPKJALIN BHLBNOJEAPK, HHOALKJJLEH LNPOGOAAENH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface EOFCBFFPMGB
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool CEKHJFIODGD
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool HKCDIBHACNI
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool DCCJFFPFHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool APAALHGKDCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool GKEGJBGLIOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool CGPHFDLEJKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool JBOANLHECPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool DEABEEJKGFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool BFBHIPHJFCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool ECLLBCECDGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool KGHIMNMBCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool BFIGOFDDIBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> MCECCGBHOGM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	KJIBADFBHJF FFAPFIIPCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FMNPKCHFFBM : EOFCBFFPMGB, EICEHFLBLCO, EPBDIDNCNBP<DOBDIFABPNA>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string BOFMHHDOPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	NAIBPKJALIN OJBEBBBMPMP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) AGDJCAEENLC<T>(DOBDIFABPNA POCAHPPHAEE) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum DOBDIFABPNA
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
internal class AOCCGIPHCFD : FMNPKCHFFBM, EOFCBFFPMGB, EICEHFLBLCO, EPBDIDNCNBP<DOBDIFABPNA>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal static readonly AMKPLGOEIIA GKIKNHEPKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly ELLKNAAOADK DKPEBDAMMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? IIDLJPKHGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private string? CLJAABKHMAP;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool JLMJNPFHKNL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x67DD610", Offset = "0x67DC610", VA = "0x1867DD610", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool NMPGEILBDCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x67DD3D0", Offset = "0x67DC3D0", VA = "0x1867DD3D0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool DIDKKHIBEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x67DE8E0", Offset = "0x67DD8E0", VA = "0x1867DE8E0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool DGGHKKDLLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x67DDA40", Offset = "0x67DCA40", VA = "0x1867DDA40", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool LIJADHDPDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x67DE890", Offset = "0x67DD890", VA = "0x1867DE890", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool MHAGLNHJKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x67DCF10", Offset = "0x67DBF10", VA = "0x1867DCF10", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public NAIBPKJALIN OJBEBBBMPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x835210", Offset = "0x834210", VA = "0x180835210", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(NAIBPKJALIN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7BFAC0", Offset = "0x7BEAC0", VA = "0x1807BFAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string DOGCKNBPLKH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x67DEA60", Offset = "0x67DDA60", VA = "0x1867DEA60", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x67DE840", Offset = "0x67DD840", VA = "0x1867DE840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string BOFMHHDOPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x67DEA60", Offset = "0x67DDA60", VA = "0x1867DEA60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool BPCBDGFELDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x879B30", Offset = "0x878B30", VA = "0x180879B30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x878D70", Offset = "0x877D70", VA = "0x180878D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool CEKHJFIODGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x67DE5F0", Offset = "0x67DD5F0", VA = "0x1867DE5F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public KJIBADFBHJF FFAPFIIPCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x67DE930", Offset = "0x67DD930", VA = "0x1867DE930", Slot = "20")]
		get
		{
			return default(KJIBADFBHJF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HKCDIBHACNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x67DDAE0", Offset = "0x67DCAE0", VA = "0x1867DDAE0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool DCCJFFPFHEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x67DE5A0", Offset = "0x67DD5A0", VA = "0x1867DE5A0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool APAALHGKDCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x67DD960", Offset = "0x67DC960", VA = "0x1867DD960", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool GKEGJBGLIOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x67DD420", Offset = "0x67DC420", VA = "0x1867DD420", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool CGPHFDLEJKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x67DD5C0", Offset = "0x67DC5C0", VA = "0x1867DD5C0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool JBOANLHECPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x67DD4D0", Offset = "0x67DC4D0", VA = "0x1867DD4D0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool DEABEEJKGFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x67DDA90", Offset = "0x67DCA90", VA = "0x1867DDA90", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool BFBHIPHJFCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x67DD520", Offset = "0x67DC520", VA = "0x1867DD520", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> MCECCGBHOGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x67DD470", Offset = "0x67DC470", VA = "0x1867DD470", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool PDCOHIFCKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x67DD610", Offset = "0x67DC610", VA = "0x1867DD610", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool HAHILOKOBEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x67DE890", Offset = "0x67DD890", VA = "0x1867DE890", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool AIHAKEOJDHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x67DD3D0", Offset = "0x67DC3D0", VA = "0x1867DD3D0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool ECLLBCECDGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x67DDB30", Offset = "0x67DCB30", VA = "0x1867DDB30", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool KGHIMNMBCCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x67DE500", Offset = "0x67DD500", VA = "0x1867DE500", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool NBAMJCLKIHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x67DE8E0", Offset = "0x67DD8E0", VA = "0x1867DE8E0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool BFIGOFDDIBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x67DE550", Offset = "0x67DD550", VA = "0x1867DE550", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool IAPEBIKKHJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x67DDA40", Offset = "0x67DCA40", VA = "0x1867DDA40", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool KOEOHDKFDBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x67DCF10", Offset = "0x67DBF10", VA = "0x1867DCF10", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event DJNOAFGDEMH<DOBDIFABPNA> HLBBGHFBKLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x67DD680", Offset = "0x67DC680", VA = "0x1867DD680", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x67DD730", Offset = "0x67DC730", VA = "0x1867DD730", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2D89950", Offset = "0x2D88950", VA = "0x182D89950", Slot = "6")]
	public (bool, T?) AGDJCAEENLC<T>(DOBDIFABPNA POCAHPPHAEE) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2D89AE0", Offset = "0x2D88AE0", VA = "0x182D89AE0")]
	public AOCCGIPHCFD ELNIBDDGJMN<T>(DOBDIFABPNA POCAHPPHAEE, bool CBFKMLEHELC, T CFJDHAGGAJO) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x67DF040", Offset = "0x67DE040", VA = "0x1867DF040")]
	public AOCCGIPHCFD(NAIBPKJALIN BHLBNOJEAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x67DEEC0", Offset = "0x67DDEC0", VA = "0x1867DEEC0")]
	public AOCCGIPHCFD(NAIBPKJALIN BHLBNOJEAPK, [Optional] string? IIDLJPKHGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x67DF060", Offset = "0x67DE060", VA = "0x1867DF060")]
	public AOCCGIPHCFD(AOCCGIPHCFD INMPLBBKILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x67DEEE0", Offset = "0x67DDEE0", VA = "0x1867DEEE0")]
	internal AOCCGIPHCFD(NAIBPKJALIN EIMAJGBDLOK, [Optional] string? IIDLJPKHGGN, [Optional] AOCCGIPHCFD? INMPLBBKILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x67DD7E0", Offset = "0x67DC7E0", VA = "0x1867DD7E0")]
	public static OKPLLBLPLHF EHJKHCBCMEB(DOBDIFABPNA POCAHPPHAEE)
	{
		return default(OKPLLBLPLHF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x67DD660", Offset = "0x67DC660", VA = "0x1867DD660")]
	public void ECMBFOOANAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x67DEAB0", Offset = "0x67DDAB0", VA = "0x1867DEAB0")]
	internal AOCCGIPHCFD PPDFIDPLHCI(AOCCGIPHCFD OEDOPPFMAAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x67DCF60", Offset = "0x67DBF60", VA = "0x1867DCF60")]
	internal IReadOnlyCollection<DOBDIFABPNA> BIOIGMPKCPM(AOCCGIPHCFD INMPLBBKILN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x67DE980", Offset = "0x67DD980", VA = "0x1867DE980")]
	public bool PHEAMCIHPML(DOBDIFABPNA POCAHPPHAEE, bool CBFKMLEHELC, string IPGKDOCHBFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x67DD860", Offset = "0x67DC860", VA = "0x1867DD860")]
	public (bool, string) FDCKNDGHANP(DOBDIFABPNA POCAHPPHAEE)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x67DD570", Offset = "0x67DC570", VA = "0x1867DD570")]
	internal void COMIODGFKJH(DOBDIFABPNA POCAHPPHAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x67DE640", Offset = "0x67DD640", VA = "0x1867DE640")]
	public GBIIBBDHFJG LGJHBFCAMOL(Func<NAIBPKJALIN, Guid> HNDIFEANANI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x67DDB80", Offset = "0x67DCB80", VA = "0x1867DDB80")]
	public void JGMOHEJJGMK(GBIIBBDHFJG NNHOACOKEFM, Func<Guid, NAIBPKJALIN> FJHANEKJJED, [Optional] NAIBPKJALIN? JENHIBGJILA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x67DD9B0", Offset = "0x67DC9B0", VA = "0x1867DD9B0")]
	[CompilerGenerated]
	private void FMEBBJKHEJM(DOBDIFABPNA DHNMODKBAOJ, BNLOHKANAJB ACHEBBKNAMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class MHCELPGBHLF : OGJNPDODFEE, KKFOKNAMILI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class AHJPICNCIGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AOCCGIPHCFD newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public AHJPICNCIGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x67DBD20", Offset = "0x67DAD20", VA = "0x1867DBD20")]
		internal bool CPFIINHEJEA(AOCCGIPHCFD rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class GNOPPLGLPFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public NAIBPKJALIN roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public GNOPPLGLPFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x67E0C40", Offset = "0x67DFC40", VA = "0x1867E0C40")]
		internal bool KKDEGGKEHJB(NAIBPKJALIN r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct BPGEMKEPNGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public MHCELPGBHLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public GBMJEMECJOI roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<LNJINCIGKMC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x67DF0F0", Offset = "0x67DE0F0", VA = "0x1867DF0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x67DF760", Offset = "0x67DE760", VA = "0x1867DF760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class ILDEFOKJDOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public ILDEFOKJDOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x67E1B00", Offset = "0x67E0B00", VA = "0x1867E1B00")]
		internal void CIKAANDNLNF(GBIIBBDHFJG r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x67E1BE0", Offset = "0x67E0BE0", VA = "0x1867E1BE0")]
		internal void DKJEJIIGLMH(GBIIBBDHFJG r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct PPHDNGJEIIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public GBMJEMECJOI roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class MDOJKNEOAJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<GBIIBBDHFJG, BNLOHKANAJB> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public MDOJKNEOAJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x67E3310", Offset = "0x67E2310", VA = "0x1867E3310")]
		internal void JDAOLCHDKKP(GBIIBBDHFJG r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x67E3370", Offset = "0x67E2370", VA = "0x1867E3370")]
		internal void NFICMECFLHD(GBIIBBDHFJG r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x67E3340", Offset = "0x67E2340", VA = "0x1867E3340")]
		internal void LFLAGOOAKFM(GBIIBBDHFJG r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class FDMJPBCELJF<T> where T : notnull
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
			public FDMJPBCELJF<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private TaskAwaiter<LNJINCIGKMC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x30FEDD0", Offset = "0x30FDDD0", VA = "0x1830FEDD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x892030", Offset = "0x891030", VA = "0x180892030", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public MHCELPGBHLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public DOBDIFABPNA rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public NAIBPKJALIN accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public OKPLLBLPLHF recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public FDMJPBCELJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3668EE0", Offset = "0x3667EE0", VA = "0x183668EE0")]
		[AsyncStateMachine(typeof(FDMJPBCELJF<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void BIBAHAFHNDK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct EPMPIOCLKBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public IReadOnlyList<BAHDPCDNAEL> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct JEMPDPAIOFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public LHLIONIHIDG rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public GBMJEMECJOI roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public IReadOnlyDictionary<NAIBPKJALIN, AOCCGIPHCFD> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public HFDHFBJEHPL debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x67E1D00", Offset = "0x67E0D00", VA = "0x1867E1D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x67E2810", Offset = "0x67E1810", VA = "0x1867E2810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly LHLIONIHIDG KLEKPBFBGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly DDPPHIJGMHA DFLKJKBKEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly HFDHFBJEHPL DENLOBHKPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, AOCCGIPHCFD> HNNCPMJGNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<NAIBPKJALIN, AOCCGIPHCFD> ANAFBJLAFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly Dictionary<NAIBPKJALIN, AOCCGIPHCFD> OKBBCDMNIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal readonly List<AOCCGIPHCFD> PHBDCLLBOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool BHGLLNPKLLM;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly DOBDIFABPNA[] OMLLHNDIFJM;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public GOMIIAPFFFJ CLKONPKEALD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<FMNPKCHFFBM> GGMOMLAKAOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x67E5AD0", Offset = "0x67E4AD0", VA = "0x1867E5AD0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event IGACNGKAAGM NKFKHKILOJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x67E47B0", Offset = "0x67E37B0", VA = "0x1867E47B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x67E5B20", Offset = "0x67E4B20", VA = "0x1867E5B20", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x67E7A80", Offset = "0x67E6A80", VA = "0x1867E7A80")]
	[KEBGMDILACL(LNECJMDANHH.Room, JMIJNHPDBML.None)]
	private static void LMNEJCNFFGB(ONGJLMJLNJA COPEDPCEBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x67E8BA0", Offset = "0x67E7BA0", VA = "0x1867E8BA0")]
	[UnityEngine.Scripting.Preserve]
	internal MHCELPGBHLF([CJCLEPGLAOP(null)] LHLIONIHIDG JGAOGHPIJDF, [CJCLEPGLAOP(null)] DDPPHIJGMHA LKFOAFIMDGN, [CJCLEPGLAOP(null)] HFDHFBJEHPL DENLOBHKPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x67E51E0", Offset = "0x67E41E0", VA = "0x1867E51E0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x67E4960", Offset = "0x67E3960", VA = "0x1867E4960")]
	private void DNHFJMCDFDO(IEnumerable<AOCCGIPHCFD> LNNANLCKNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x67E79B0", Offset = "0x67E69B0", VA = "0x1867E79B0", Slot = "12")]
	public bool LIMALANANCM(IDMICLLCMKN JAPHEDILMIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x67E7C40", Offset = "0x67E6C40", VA = "0x1867E7C40")]
	private void NANIPCFFPGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x67E7000", Offset = "0x67E6000", VA = "0x1867E7000")]
	private void LBJHPEMIKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x67E5ED0", Offset = "0x67E4ED0", VA = "0x1867E5ED0", Slot = "10")]
	public IReadOnlyList<FMNPKCHFFBM> HMGHMMCHINC(bool ONDLFANIMON = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x67E6EF0", Offset = "0x67E5EF0", VA = "0x1867E6EF0", Slot = "11")]
	public FMNPKCHFFBM JCBADJFJMGD(IDMICLLCMKN JAPHEDILMIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x67E66E0", Offset = "0x67E56E0", VA = "0x1867E66E0")]
	private NAIBPKJALIN IBLNLFLLAPL(IDMICLLCMKN JAPHEDILMIF)
	{
		return default(NAIBPKJALIN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x67E6B00", Offset = "0x67E5B00", VA = "0x1867E6B00", Slot = "14")]
	public bool IICLPHDAJOE(IDMICLLCMKN CBDHFKDPKHP, NAIBPKJALIN BHLBNOJEAPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x67E5570", Offset = "0x67E4570", VA = "0x1867E5570", Slot = "15")]
	public FMNPKCHFFBM FIHGHLMAIHK(NAIBPKJALIN BHLBNOJEAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x67E71F0", Offset = "0x67E61F0", VA = "0x1867E71F0")]
	private static bool LHEOKIHKJDB(KFCHHAGMJFC MFMGCMIGLDB, NAIBPKJALIN BHLBNOJEAPK, [Out] GBIIBBDHFJG? KJGPEDFMOME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x67E5750", Offset = "0x67E4750", VA = "0x1867E5750")]
	private static void GJNKHPPJLJA(KFCHHAGMJFC MFMGCMIGLDB, Action<GBIIBBDHFJG> GHOMPPPHNKH, NAIBPKJALIN GEDPBJOPDDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x67E5840", Offset = "0x67E4840", VA = "0x1867E5840")]
	private static void GJNKHPPJLJA(KFCHHAGMJFC MFMGCMIGLDB, Action<GBIIBBDHFJG> GHOMPPPHNKH, Predicate<NAIBPKJALIN> MCBEJKIMBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x67E52F0", Offset = "0x67E42F0", VA = "0x1867E52F0")]
	private void EDEFHDDDGDK(IDMICLLCMKN JAPHEDILMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x67E7890", Offset = "0x67E6890", VA = "0x1867E7890", Slot = "4")]
	[AsyncStateMachine(typeof(BPGEMKEPNGC))]
	public Task LILAKNHJFLH([CanBeNull] GBMJEMECJOI PCNPJGFONNP, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
	public void MFAGOLIIMLH(GBMJEMECJOI PCNPJGFONNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x67E41D0", Offset = "0x67E31D0", VA = "0x1867E41D0")]
	private void CBCHJCBLHMA(KFCHHAGMJFC MJFGCOJNIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x67E5BC0", Offset = "0x67E4BC0", VA = "0x1867E5BC0")]
	internal static string HKNOINMCLJJ(LHLIONIHIDG KLEKPBFBGEE, GBMJEMECJOI PCNPJGFONNP, IReadOnlyDictionary<NAIBPKJALIN, AOCCGIPHCFD> ANAFBJLAFGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x67E33A0", Offset = "0x67E23A0", VA = "0x1867E33A0")]
	private static void ABONFEAFLJC(GBMJEMECJOI PCNPJGFONNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x67E7C50", Offset = "0x67E6C50", VA = "0x1867E7C50")]
	private static void NLMJMLOMCLH(KFCHHAGMJFC EIAEIEFOEDC, IReadOnlyDictionary<NAIBPKJALIN, AOCCGIPHCFD> ANAFBJLAFGJ, StringBuilder BFFDBOIEANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x67E4850", Offset = "0x67E3850", VA = "0x1867E4850")]
	private static bool DAAFMGLGBHK(string AOLKOENLIOM, [Out] Guid EGNHIJNJGHK, [Out] NAIBPKJALIN BHLBNOJEAPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x67E7FA0", Offset = "0x67E6FA0", VA = "0x1867E7FA0")]
	private static void PDEAJNPNFJF(GBMJEMECJOI PCNPJGFONNP, StringBuilder BFFDBOIEANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x287DD80", Offset = "0x287CD80", VA = "0x18287DD80", Slot = "16")]
	public bool DDOKOPMMNLP<T>(NAIBPKJALIN BHLBNOJEAPK, DOBDIFABPNA POCAHPPHAEE, bool CBFKMLEHELC, T OMFIAODHHCI, [Optional] Action NDPDMBAAHDB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x67E5360", Offset = "0x67E4360", VA = "0x1867E5360")]
	private void FHAHHGFOILJ(NAIBPKJALIN BHLBNOJEAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x67E6EC0", Offset = "0x67E5EC0", VA = "0x1867E6EC0")]
	private bool IOBPJHFIBLI(IDMICLLCMKN JAPHEDILMIF, NAIBPKJALIN BHLBNOJEAPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x67E67B0", Offset = "0x67E57B0", VA = "0x1867E67B0")]
	internal AOCCGIPHCFD IEFKNPDNIJN(IDMICLLCMKN JAPHEDILMIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x67E6EE0", Offset = "0x67E5EE0", VA = "0x1867E6EE0", Slot = "13")]
	public IReadOnlyList<FMNPKCHFFBM> IPFICCJBLHK(IDMICLLCMKN JAPHEDILMIF, bool AJEDGNKIAEB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x67E6C90", Offset = "0x67E5C90", VA = "0x1867E6C90")]
	internal IReadOnlyList<AOCCGIPHCFD> IJGMCNMGINJ(IDMICLLCMKN JAPHEDILMIF, bool AJEDGNKIAEB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x67E5F50", Offset = "0x67E4F50", VA = "0x1867E5F50")]
	private void IBJNFNMLKCC(LNJINCIGKMC OPHNAJIKOKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x67E86E0", Offset = "0x67E76E0", VA = "0x1867E86E0")]
	private static bool PNENOHPJMGN(AOCCGIPHCFD JNFEIMEPIID, IReadOnlyDictionary<NAIBPKJALIN, AOCCGIPHCFD> ANAFBJLAFGJ, [Out] IReadOnlyList<DOBDIFABPNA> HOBPCOFKPEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x67E5610", Offset = "0x67E4610", VA = "0x1867E5610")]
	[AsyncStateMachine(typeof(JEMPDPAIOFN))]
	private static Task GHHPGDILDFA(LHLIONIHIDG KLEKPBFBGEE, GBMJEMECJOI PCNPJGFONNP, IReadOnlyDictionary<NAIBPKJALIN, AOCCGIPHCFD> ANAFBJLAFGJ, HFDHFBJEHPL DENLOBHKPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x67E4510", Offset = "0x67E3510", VA = "0x1867E4510")]
	[CompilerGenerated]
	internal static void CBCMNAGJCEH(Func<GBIIBBDHFJG, BNLOHKANAJB> NMPINDDAFDH, PPHDNGJEIIF P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x67E7520", Offset = "0x67E6520", VA = "0x1867E7520")]
	[CompilerGenerated]
	internal static bool LIFAMOPIEAF(NAIBPKJALIN BHLBNOJEAPK, DOBDIFABPNA POCAHPPHAEE, [Out] BAHDPCDNAEL BGKJFLHBIDM, EPMPIOCLKBP P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface KEIGIIGECPG
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LJMFAILIDBD(IDMICLLCMKN BEFPOEPDLPB, IDMICLLCMKN PLBDGCKOBOO, IEnumerable<IDMICLLCMKN> FICNJICGOGM, [Out] KJIBADFBHJF MBIHGBONCEH, [Out] BKIDKFODOLG NCCPDDAEOOL);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string PFJJAPOOFLG(BKIDKFODOLG AEMDDOAICEM);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum BKIDKFODOLG : byte
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
internal class IIFOOJKEHKF : KEIGIIGECPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly KKFOKNAMILI FNABABJBODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly KNLAIMPHGGC HCIDHKDABOM;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7C8740", Offset = "0x7C7740", VA = "0x1807C8740")]
	[RecRoom.NoEngine.Common.Preserve]
	public IIFOOJKEHKF([CJCLEPGLAOP(null)] KKFOKNAMILI DCMOCDLOIIM, [CJCLEPGLAOP(null)] KNLAIMPHGGC BBIPKKCBEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x67E12A0", Offset = "0x67E02A0", VA = "0x1867E12A0")]
	private static GAJLHAIGEPG? EFHJEJFKJMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x67E1900", Offset = "0x67E0900", VA = "0x1867E1900", Slot = "4")]
	public bool LJMFAILIDBD(IDMICLLCMKN BEFPOEPDLPB, IDMICLLCMKN PLBDGCKOBOO, IEnumerable<IDMICLLCMKN> FICNJICGOGM, [Out] KJIBADFBHJF MBIHGBONCEH, [Out] BKIDKFODOLG NCCPDDAEOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x67E1A00", Offset = "0x67E0A00", VA = "0x1867E1A00", Slot = "5")]
	public string PFJJAPOOFLG(BKIDKFODOLG AEMDDOAICEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x67E12E0", Offset = "0x67E02E0", VA = "0x1867E12E0")]
	internal bool IKELGIGPLIH(IDMICLLCMKN BEFPOEPDLPB, IDMICLLCMKN PLBDGCKOBOO, IEnumerable<IDMICLLCMKN> FICNJICGOGM, HHOALKJJLEH LNPOGOAAENH, GAJLHAIGEPG? JGIMBNIBMJA, [Out] KJIBADFBHJF MBIHGBONCEH, [Out] BKIDKFODOLG NCCPDDAEOOL)
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
