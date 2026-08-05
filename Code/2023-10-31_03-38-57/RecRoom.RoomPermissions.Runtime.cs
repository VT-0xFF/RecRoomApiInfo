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
		[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
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
		[Cpp2IlInjected.Address(RVA = "0x627AFB0", Offset = "0x627A3B0", VA = "0x18627AFB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x787CA0", Offset = "0x7870A0", VA = "0x180787CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x787CE0", Offset = "0x7870E0", VA = "0x180787CE0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum BMKHKMGICNJ
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void JAFONFMCGFO<TPermission>(TPermission ECDOHIOLIOP);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void KDFEHDBKHBL(CBOIFHFJJAA JKFHKEDOHFP);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum NKAPFDABNHE
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IGDEMJINIDK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NOOEGHCFPJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool FFFIBDMOMLI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool JICCHPGEDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CEHHFIDDAML
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool GBANFIKIMAI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HOALNKBEPBL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class NEKIMFLNHAJ
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum EHMOIBPDICJ
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
	public static readonly Guid LKKPIENNNLB;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid LDFJJABJIPG;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid ELCKLEDPPIE;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid GOJJDOMCEJJ;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid IOEPNJKGIKH;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid IHJEJEPMMEE;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly APBMLGKIIHB<MGDDJCDOFPB, Guid> GHLADDJDOMM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<MGDDJCDOFPB> LGDABOAMHBA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x627A880", Offset = "0x6279C80", VA = "0x18627A880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x627AB20", Offset = "0x6279F20", VA = "0x18627AB20")]
	public static MGDDJCDOFPB MDKEPEGBOEM(Guid OGGNLGCIGBJ)
	{
		return default(MGDDJCDOFPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x627ABF0", Offset = "0x6279FF0", VA = "0x18627ABF0")]
	public static Guid NMDCNBEDGKK(MGDDJCDOFPB GCMDDDCBJLF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x627A9B0", Offset = "0x6279DB0", VA = "0x18627A9B0")]
	public static bool HFJLJDIOGLA(MGDDJCDOFPB GCMDDDCBJLF, [Out] Guid OGGNLGCIGBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x627AA40", Offset = "0x6279E40", VA = "0x18627AA40")]
	public static bool HPIPCOKFNKG(Guid OGGNLGCIGBJ, [Out] MGDDJCDOFPB GCMDDDCBJLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x627AAE0", Offset = "0x6279EE0", VA = "0x18627AAE0")]
	public static MGDDJCDOFPB JBAHKIFDJDE(MGDDJCDOFPB GCMDDDCBJLF)
	{
		return default(MGDDJCDOFPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x627A900", Offset = "0x6279D00", VA = "0x18627A900")]
	public static EHMOIBPDICJ ECCBJJFMMEO(MGDDJCDOFPB OAEBGHOENCB)
	{
		return default(EHMOIBPDICJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x627ABB0", Offset = "0x6279FB0", VA = "0x18627ABB0")]
	internal static MGDDJCDOFPB MEJGNBKFJEH(EHMOIBPDICJ OOBLHJDACAC)
	{
		return default(MGDDJCDOFPB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OFMNONILMLH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	KJBJNBLBKKG MLNLANJEPPP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<NBLFFKLJBFE> HAIEJNEOIFL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event KDFEHDBKHBL NLAJKGBPNNN;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<NBLFFKLJBFE> EKCOPBHECAO(bool LMJMNCLMPPD = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NBLFFKLJBFE OGKJDGAGACC(CBOIFHFJJAA JKFHKEDOHFP);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool IDGNKJMMHHH(CBOIFHFJJAA JKFHKEDOHFP);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<NBLFFKLJBFE> DKPMCEFLNPB(CBOIFHFJJAA JKFHKEDOHFP, bool HJKFIJIAPOA = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BDBIHFOHOMP(CBOIFHFJJAA NFANMBJBMKN, MGDDJCDOFPB GCMDDDCBJLF);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NBLFFKLJBFE DDBCLDEOHIM(MGDDJCDOFPB GCMDDDCBJLF);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool EIOLCECCODP<T>(MGDDJCDOFPB GCMDDDCBJLF, KJOOJOPGFNP ECDOHIOLIOP, bool MPOEHKFOOFJ, T GCCIFMALMDL) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LPGMJDLDHKG
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MJMJDHGGKPD(PPLFDHIJECO GBMIBBELHLP, CancellationToken ELGJALILGJE);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OLCCNOLFEHJ(PPLFDHIJECO GBMIBBELHLP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HALKGJCKJMI
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	CBOIFHFJJAA PHBDNODNADP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	NDIKEHHDAHG ABFIEEGBEAN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	MAHFHIJJEDK HJMPIMIKMEE
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<GFDJKKMBLLF> KJOHPICODDM;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action NNPEANPELCN;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MGDDJCDOFPB AGAGMCPHIFE(CBOIFHFJJAA JKFHKEDOHFP);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<GFDJKKMBLLF> CMAKFEIBAJO(CancellationToken ELGJALILGJE);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task GGEIJNJCLBL(long JGANHKDJMFC, long LHJJFKJEMPN, IReadOnlyList<ICINOODLDLB> JANFKONNOHG);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<CBOIFHFJJAA> GOGHBLAFBEC();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class CBANBHFJJOO
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x626E390", Offset = "0x626D790", VA = "0x18626E390")]
	public static MGDDJCDOFPB CIFLDFOFKEG(this HALKGJCKJMI BIJPHKEAEFN)
	{
		return default(MGDDJCDOFPB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HBAGAODCBMC<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string NHLPMJGIGHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event JAFONFMCGFO<TPermission> KFPPKLDIKOF;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class OAPBJOBNIGN
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? ILDFAHDDGMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x75C7A0", Offset = "0x75BBA0", VA = "0x18075C7A0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x763340", Offset = "0x762740", VA = "0x180763340")]
	protected OAPBJOBNIGN(object? FIAKMGEPDFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool HAHEKFLHKAO(object? EOHMJBFGDPD);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class IAPFAKBNNGC<T> : OAPBJOBNIGN where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T HDGGOHHJGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> KHGJGLGLGJN;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T DFNAILAPHHN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7D0020", Offset = "0x7CF420", VA = "0x1807D0020")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x36076D0", Offset = "0x3606AD0", VA = "0x1836076D0", Slot = "4")]
	public override bool HAHEKFLHKAO(object? EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3607CD0", Offset = "0x36070D0", VA = "0x183607CD0")]
	public bool LHMNMNEHNMG(T EAJBJNHOAON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3607F50", Offset = "0x3607350", VA = "0x183607F50")]
	public IAPFAKBNNGC(T DPPAMEJDDPD, IEqualityComparer<T> KHGJGLGLGJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class GDENCCMMNAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<KJOOJOPGFNP, bool> FHKDNLNBKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<KJOOJOPGFNP, OAPBJOBNIGN> HJODNGDENEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly DHCOBCEHLCK DCECAGOFECF;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6279370", Offset = "0x6278770", VA = "0x186279370")]
	public GDENCCMMNAA(DHCOBCEHLCK DCECAGOFECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6279230", Offset = "0x6278630", VA = "0x186279230")]
	public bool MNADHDFGPDK(KJOOJOPGFNP ECDOHIOLIOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x237AED0", Offset = "0x237A2D0", VA = "0x18237AED0")]
	public bool EKILLCLKKPK<T>(KJOOJOPGFNP ECDOHIOLIOP, bool MPOEHKFOOFJ, T EOHMJBFGDPD) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x237AB00", Offset = "0x2379F00", VA = "0x18237AB00")]
	public (bool, T?) CDHHIKANNOD<T>(KJOOJOPGFNP ECDOHIOLIOP) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6278F50", Offset = "0x6278350", VA = "0x186278F50")]
	public bool EKILLCLKKPK(KJOOJOPGFNP ECDOHIOLIOP, bool MPOEHKFOOFJ, object EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6278E80", Offset = "0x6278280", VA = "0x186278E80")]
	public (bool, object) CDHHIKANNOD(KJOOJOPGFNP ECDOHIOLIOP)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x237B3E0", Offset = "0x237A7E0", VA = "0x18237B3E0")]
	private void LHMKKKOBKPE<T>(KJOOJOPGFNP ECDOHIOLIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x62792A0", Offset = "0x62786A0", VA = "0x1862792A0")]
	private OAPBJOBNIGN OCEBKELKCAH(KJOOJOPGFNP ECDOHIOLIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6279030", Offset = "0x6278430", VA = "0x186279030")]
	public void HFIMCFJIJOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class AGGEPACHNAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string CDPBNEAFHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type BNGKADBNOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly BFFDDIKJPHI BODCFAHIMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly KJOOJOPGFNP IGFPCBNFDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public IDOAOLACHMH IEPKJOLJGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public DOPPHFPGODD CBNIKFJBKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public DIMHHLCMNAP BMFKFCFEOGH;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x626E2F0", Offset = "0x626D6F0", VA = "0x18626E2F0")]
	public AGGEPACHNAC(Type ENDJHDAIBMJ, string IDIHANEDCJM, KJOOJOPGFNP ECDOHIOLIOP, IDOAOLACHMH PCIPKOFCEAB, DOPPHFPGODD ELGHOAJGELA, DIMHHLCMNAP FCFBNGJBOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x626E1F0", Offset = "0x626D5F0", VA = "0x18626E1F0")]
	public object EJPFMKHBLMM(object? LJIBJAOOGGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x29D1A90", Offset = "0x29D0E90", VA = "0x1829D1A90")]
	public void LHMKKKOBKPE<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x626E240", Offset = "0x626D640", VA = "0x18626E240")]
	public void LHMKKKOBKPE(Type ACANONFCAEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class IJCDMMGKIJI<T> : AGGEPACHNAC where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string CKLHHICNANM(T EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T CCEEKHOPHPB(string? LFNACJBDLNF, T DPPAMEJDDPD);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class HHIBNOGFAOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public CKLHHICNANM serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public CCEEKHOPHPB parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public HHIBNOGFAOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3541880", Offset = "0x3540C80", VA = "0x183541880")]
		internal string PMAJCPFCLBG(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3541770", Offset = "0x3540B70", VA = "0x183541770")]
		internal object FBGPFDICPDB(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3639DF0", Offset = "0x36391F0", VA = "0x183639DF0")]
	public IJCDMMGKIJI(KJOOJOPGFNP ECDOHIOLIOP, string IDIHANEDCJM, [Optional] CKLHHICNANM? PCIPKOFCEAB, [Optional] CCEEKHOPHPB? ELGHOAJGELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3638D20", Offset = "0x3638120", VA = "0x183638D20")]
	private static object? ONLENKPGCBM(CCEEKHOPHPB? ELGHOAJGELA, string? LFNACJBDLNF, object? DPPAMEJDDPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3639600", Offset = "0x3638A00", VA = "0x183639600")]
	private static string PJNKBIHCNDA(CKLHHICNANM? CEBKNPEMADB, object? EOHMJBFGDPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string IDOAOLACHMH(object? EOHMJBFGDPD);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object DOPPHFPGODD(string? LFNACJBDLNF, [Optional] object DPPAMEJDDPD);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate OAPBJOBNIGN DIMHHLCMNAP();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class DHCOBCEHLCK
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class PLCABBIIKNL : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static PLCABBIIKNL PFONNHJIIHO;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x627B030", Offset = "0x627A430", VA = "0x18627B030", Slot = "4")]
		public bool Equals(List<string> MHJJOHHKIPH, List<string> DFACBIDGKFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x627B180", Offset = "0x627A580", VA = "0x18627B180", Slot = "5")]
		public int GetHashCode(List<string> BAFDGKKJJJD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public PLCABBIIKNL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class JJEGMOHCNIO : MLKGGFJFDEJ<BMKHKMGICNJ>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6279890", Offset = "0x6278C90", VA = "0x186279890", Slot = "9")]
		public override string PJNKBIHCNDA(BMKHKMGICNJ CEPHEIEJHPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x62796B0", Offset = "0x6278AB0", VA = "0x1862796B0", Slot = "10")]
		protected override bool HLOGOCAFJAD(string CEPHEIEJHPL, [Out] BMKHKMGICNJ EOHMJBFGDPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6279980", Offset = "0x6278D80", VA = "0x186279980")]
		public JJEGMOHCNIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly PJJJLNMKPLF GBEHBGEMGIF;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly JJEGMOHCNIO DHNKFPILLNG;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<AGGEPACHNAC> HAAOAIIJFPP;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<KJOOJOPGFNP> IPFONNFLKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<KJOOJOPGFNP, AGGEPACHNAC> ACLOKGPCKDE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6271440", Offset = "0x6270840", VA = "0x186271440")]
	public DHCOBCEHLCK([Optional] IList<AGGEPACHNAC>? KOHANIGBCIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x62705D0", Offset = "0x626F9D0", VA = "0x1862705D0")]
	public AGGEPACHNAC PILODKLKNCH(KJOOJOPGFNP ECDOHIOLIOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface KJBJNBLBKKG
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NBLFFKLJBFE OPIEOFNONCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class GCFAFFAMKPA : KJBJNBLBKKG
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static GCFAFFAMKPA BMEDPFPAJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly CMFHPAPMHBI LIAAFNKFOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<CMFHPAPMHBI> EMLLMBFBJJI;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public NBLFFKLJBFE OPIEOFNONCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6278D70", Offset = "0x6278170", VA = "0x186278D70")]
	public GCFAFFAMKPA(CMFHPAPMHBI PPGFFKCHDJF, IReadOnlyList<CMFHPAPMHBI> IBOJADJAAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6278340", Offset = "0x6277740", VA = "0x186278340")]
	private static GCFAFFAMKPA CNGNCDILAFL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class MKHHMDHDBGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<MGDDJCDOFPB> GLPNDIFLHPO;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x627A570", Offset = "0x6279970", VA = "0x18627A570")]
	public static bool MADEPOPPKIO(this CBOIFHFJJAA EFECFLPGMAM, MGDDJCDOFPB GCMDDDCBJLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x627A650", Offset = "0x6279A50", VA = "0x18627A650")]
	public static bool NBLLJCLMGLJ(this CBOIFHFJJAA EFECFLPGMAM, MGDDJCDOFPB GCMDDDCBJLF, MAHFHIJJEDK BMDBLGIENNC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface MMPECNEGCFC
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool NEJCLIIMDPK
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool EELOPPPODGF
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool GNGAGJLPFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool PJCGNGPNNED
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool LDDNHABGNOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool HHABEEBJCBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool BMLHAPDBFOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool NNMOGBPGHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool NNBOAHHPOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool FMKBCCHGPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool EGAPJKDOJDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool PMEAAOGAOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> GJMAKOMEAPN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	BMKHKMGICNJ DCGLAIBHJKA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface NBLFFKLJBFE : MMPECNEGCFC, IGDEMJINIDK, HBAGAODCBMC<KJOOJOPGFNP>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string DBONOMIBNEE
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	MGDDJCDOFPB MGIJCMMJBME
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) PDHKKHJIJOJ<T>(KJOOJOPGFNP ECDOHIOLIOP) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum KJOOJOPGFNP
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
internal class CMFHPAPMHBI : NBLFFKLJBFE, MMPECNEGCFC, IGDEMJINIDK, HBAGAODCBMC<KJOOJOPGFNP>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal static readonly DHCOBCEHLCK AJNFKHANFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly GDENCCMMNAA JBNBFBGJNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? LJEPKMACKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private string? BDCAIABBLEF;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool DIGBLCJHLEG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x626E440", Offset = "0x626D840", VA = "0x18626E440", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool NBOGICIFLNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x626E680", Offset = "0x626DA80", VA = "0x18626E680", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool ADKHLHBAMNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x626E3F0", Offset = "0x626D7F0", VA = "0x18626E3F0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool GNGGNCGLGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x626FF40", Offset = "0x626F340", VA = "0x18626FF40", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool LGGNJEDDALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x626E490", Offset = "0x626D890", VA = "0x18626E490", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool DGAEIFOCMDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x626EEE0", Offset = "0x626E2E0", VA = "0x18626EEE0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public MGDDJCDOFPB MGIJCMMJBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7D0020", Offset = "0x7CF420", VA = "0x1807D0020", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(MGDDJCDOFPB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x763C70", Offset = "0x763070", VA = "0x180763C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string NHLPMJGIGHC
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x626FDB0", Offset = "0x626F1B0", VA = "0x18626FDB0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x626F900", Offset = "0x626ED00", VA = "0x18626F900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string DBONOMIBNEE
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x626FDB0", Offset = "0x626F1B0", VA = "0x18626FDB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool DBONDKJLGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7CD650", Offset = "0x7CCA50", VA = "0x1807CD650")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7CD300", Offset = "0x7CC700", VA = "0x1807CD300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool NEJCLIIMDPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x626EE70", Offset = "0x626E270", VA = "0x18626EE70", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public BMKHKMGICNJ DCGLAIBHJKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x626E720", Offset = "0x626DB20", VA = "0x18626E720", Slot = "20")]
		get
		{
			return default(BMKHKMGICNJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool EELOPPPODGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x626EC80", Offset = "0x626E080", VA = "0x18626EC80", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool GNGAGJLPFLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x626EF30", Offset = "0x626E330", VA = "0x18626EF30", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool PJCGNGPNNED
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x626E7C0", Offset = "0x626DBC0", VA = "0x18626E7C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool LDDNHABGNOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x626E530", Offset = "0x626D930", VA = "0x18626E530", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool HHABEEBJCBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x626EDD0", Offset = "0x626E1D0", VA = "0x18626EDD0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool BMLHAPDBFOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x626E4E0", Offset = "0x626D8E0", VA = "0x18626E4E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool NNMOGBPGHHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x626E630", Offset = "0x626DA30", VA = "0x18626E630", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool NNBOAHHPOKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6270270", Offset = "0x626F670", VA = "0x186270270", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> GJMAKOMEAPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x626F950", Offset = "0x626ED50", VA = "0x18626F950", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool MPGJPKMHJCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x626E440", Offset = "0x626D840", VA = "0x18626E440", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool KKCKOPCADKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x626E490", Offset = "0x626D890", VA = "0x18626E490", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool ICOHCGMHFML
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x626E680", Offset = "0x626DA80", VA = "0x18626E680", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool FMKBCCHGPPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x626E6D0", Offset = "0x626DAD0", VA = "0x18626E6D0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool EGAPJKDOJDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x62702C0", Offset = "0x626F6C0", VA = "0x1862702C0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool CEFFGEHAPKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x626E3F0", Offset = "0x626D7F0", VA = "0x18626E3F0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool PMEAAOGAOLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x626EE20", Offset = "0x626E220", VA = "0x18626EE20", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool KKLLFDMLOMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x626FF40", Offset = "0x626F340", VA = "0x18626FF40", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool EDENENKEFBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x626EEE0", Offset = "0x626E2E0", VA = "0x18626EEE0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event JAFONFMCGFO<KJOOJOPGFNP> KFPPKLDIKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x626FE00", Offset = "0x626F200", VA = "0x18626FE00", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x626E580", Offset = "0x626D980", VA = "0x18626E580", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x220CE80", Offset = "0x220C280", VA = "0x18220CE80", Slot = "6")]
	public (bool, T?) PDHKKHJIJOJ<T>(KJOOJOPGFNP ECDOHIOLIOP) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x220CE40", Offset = "0x220C240", VA = "0x18220CE40")]
	public CMFHPAPMHBI BNLMPNBCLHJ<T>(KJOOJOPGFNP ECDOHIOLIOP, bool MPOEHKFOOFJ, T EOHMJBFGDPD) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x62703A0", Offset = "0x626F7A0", VA = "0x1862703A0")]
	public CMFHPAPMHBI(MGDDJCDOFPB GCMDDDCBJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x62705B0", Offset = "0x626F9B0", VA = "0x1862705B0")]
	public CMFHPAPMHBI(MGDDJCDOFPB GCMDDDCBJLF, [Optional] string? LJEPKMACKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6270520", Offset = "0x626F920", VA = "0x186270520")]
	public CMFHPAPMHBI(CMFHPAPMHBI CAJIPNEHPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x62703C0", Offset = "0x626F7C0", VA = "0x1862703C0")]
	internal CMFHPAPMHBI(MGDDJCDOFPB FEBFDNGJHHD, [Optional] string? LJEPKMACKDP, [Optional] CMFHPAPMHBI? CAJIPNEHPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x626F9B0", Offset = "0x626EDB0", VA = "0x18626F9B0")]
	public static BFFDDIKJPHI JHBAJOFKPHN(KJOOJOPGFNP ECDOHIOLIOP)
	{
		return default(BFFDDIKJPHI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x626EEC0", Offset = "0x626E2C0", VA = "0x18626EEC0")]
	public void HFIMCFJIJOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x626FA30", Offset = "0x626EE30", VA = "0x18626FA30")]
	internal CMFHPAPMHBI JILBMBBBJLK(CMFHPAPMHBI NOIOEINIKKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x626E810", Offset = "0x626DC10", VA = "0x18626E810")]
	internal IReadOnlyCollection<KJOOJOPGFNP> GFOOEPCPPKC(CMFHPAPMHBI CAJIPNEHPEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6270190", Offset = "0x626F590", VA = "0x186270190")]
	public bool NDJMBBBJMDB(KJOOJOPGFNP ECDOHIOLIOP, bool MPOEHKFOOFJ, string BPHEDGJHEMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x626ECD0", Offset = "0x626E0D0", VA = "0x18626ECD0")]
	public (bool, string) GKJOBHPGOFO(KJOOJOPGFNP ECDOHIOLIOP)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x626E770", Offset = "0x626DB70", VA = "0x18626E770")]
	internal void FBEDIAPMJDA(KJOOJOPGFNP ECDOHIOLIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x626FF90", Offset = "0x626F390", VA = "0x18626FF90")]
	public HOJAICNELBB MNBCFLMIDLJ(Func<MGDDJCDOFPB, Guid> JGAOAOOFOEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x626EF80", Offset = "0x626E380", VA = "0x18626EF80")]
	public void HOJMKMFCKPD(HOJAICNELBB ECMBJJADEBL, Func<Guid, MGDDJCDOFPB> AMADEPFFIBF, [Optional] MGDDJCDOFPB? HIMJEOPKLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x626FEB0", Offset = "0x626F2B0", VA = "0x18626FEB0")]
	[CompilerGenerated]
	private void LGAODDHLCEI(KJOOJOPGFNP FHLFKGAANFF, BCCMACEOLAH IADKDGPHDLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class DJIJDBOEFDC : LPGMJDLDHKG, OFMNONILMLH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class MHEDKJFJFOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public CMFHPAPMHBI newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public MHEDKJFJFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x62799D0", Offset = "0x6278DD0", VA = "0x1862799D0")]
		internal bool KKPEDOJLFOH(CMFHPAPMHBI rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class MCAEGCLPPCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public MGDDJCDOFPB roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public MCAEGCLPPCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x62799C0", Offset = "0x6278DC0", VA = "0x1862799C0")]
		internal bool APBMLIAHGFI(MGDDJCDOFPB r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct FDGNCHBHBLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public DJIJDBOEFDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public PPLFDHIJECO roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<GFDJKKMBLLF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6277420", Offset = "0x6276820", VA = "0x186277420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6277A80", Offset = "0x6276E80", VA = "0x186277A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class ECEIHIFABJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public ECEIHIFABJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6277340", Offset = "0x6276740", VA = "0x186277340")]
		internal void HAHHKPKEDLD(HOJAICNELBB r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6277220", Offset = "0x6276620", VA = "0x186277220")]
		internal void GFHGGJHHJEL(HOJAICNELBB r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct AGIMLOMMECA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public PPLFDHIJECO roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class IIKEAMHEMDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<HOJAICNELBB, BCCMACEOLAH> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public IIKEAMHEMDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6279650", Offset = "0x6278A50", VA = "0x186279650")]
		internal void JIJMOKAFBPH(HOJAICNELBB r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6279680", Offset = "0x6278A80", VA = "0x186279680")]
		internal void OBBGDJCEMFN(HOJAICNELBB r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6279620", Offset = "0x6278A20", VA = "0x186279620")]
		internal void FJCKGCKCOBL(HOJAICNELBB r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class FHKILANOLLK<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public FHKILANOLLK<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private object <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private TaskAwaiter<GFDJKKMBLLF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x2EB49D0", Offset = "0x2EB3DD0", VA = "0x182EB49D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x86F690", Offset = "0x86EA90", VA = "0x18086F690", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public DJIJDBOEFDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public KJOOJOPGFNP rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public MGDDJCDOFPB accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public BFFDDIKJPHI recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public FHKILANOLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x33D9160", Offset = "0x33D8560", VA = "0x1833D9160")]
		[AsyncStateMachine(typeof(FHKILANOLLK<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void INJHPCEKFHE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct PMOMFLILNDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public IReadOnlyList<ICINOODLDLB> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct MJOEEFCDPOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public HALKGJCKJMI rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public PPLFDHIJECO roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public IReadOnlyDictionary<MGDDJCDOFPB, CMFHPAPMHBI> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public MFECNOOLHIK debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6279A00", Offset = "0x6278E00", VA = "0x186279A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x627A510", Offset = "0x6279910", VA = "0x18627A510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly HALKGJCKJMI BIJPHKEAEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly GCFAFFAMKPA JNIDJJHKOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly MFECNOOLHIK BDDIICAMKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, CMFHPAPMHBI> DPAKDICFENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<MGDDJCDOFPB, CMFHPAPMHBI> LJEODKJLPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly Dictionary<MGDDJCDOFPB, CMFHPAPMHBI> KLADECEDLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal readonly List<CMFHPAPMHBI> OAGGGECLLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool IFOIFMNJALG;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly KJOOJOPGFNP[] OEPGPECOKDA;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public KJBJNBLBKKG MLNLANJEPPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<NBLFFKLJBFE> HAIEJNEOIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6272DA0", Offset = "0x62721A0", VA = "0x186272DA0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event KDFEHDBKHBL NLAJKGBPNNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6274810", Offset = "0x6273C10", VA = "0x186274810", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6273210", Offset = "0x6272610", VA = "0x186273210", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6275F50", Offset = "0x6275350", VA = "0x186275F50")]
	[JMHDKPKEECF(POEFLILDONI.Room, OPIGPDFNEON.None)]
	private static void JHBKMICOLHJ(HLDKHDLHDPB CKAJMMKKCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6276F60", Offset = "0x6276360", VA = "0x186276F60")]
	[UnityEngine.Scripting.Preserve]
	internal DJIJDBOEFDC([LOJAGCNCPBJ(null)] HALKGJCKJMI PANAJLBGDIJ, [LOJAGCNCPBJ(null)] GCFAFFAMKPA MNBLGJPNLKA, [LOJAGCNCPBJ(null)] MFECNOOLHIK BDDIICAMKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6273100", Offset = "0x6272500", VA = "0x186273100", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6271790", Offset = "0x6270B90", VA = "0x186271790")]
	private void AGBLOCOPFOB(IEnumerable<CMFHPAPMHBI> OIOEJBNPJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x62754C0", Offset = "0x62748C0", VA = "0x1862754C0", Slot = "12")]
	public bool IDGNKJMMHHH(CBOIFHFJJAA JKFHKEDOHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6276C50", Offset = "0x6276050", VA = "0x186276C50")]
	private void NNPEANPELCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6275CF0", Offset = "0x62750F0", VA = "0x186275CF0")]
	private void JDBGCBMNKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x62732B0", Offset = "0x62726B0", VA = "0x1862732B0", Slot = "10")]
	public IReadOnlyList<NBLFFKLJBFE> EKCOPBHECAO(bool LMJMNCLMPPD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6276C60", Offset = "0x6276060", VA = "0x186276C60", Slot = "11")]
	public NBLFFKLJBFE OGKJDGAGACC(CBOIFHFJJAA JKFHKEDOHFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6276850", Offset = "0x6275C50", VA = "0x186276850")]
	private MGDDJCDOFPB KOGILIFIKNP(CBOIFHFJJAA JKFHKEDOHFP)
	{
		return default(MGDDJCDOFPB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6272350", Offset = "0x6271750", VA = "0x186272350", Slot = "14")]
	public bool BDBIHFOHOMP(CBOIFHFJJAA NFANMBJBMKN, MGDDJCDOFPB GCMDDDCBJLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6272D00", Offset = "0x6272100", VA = "0x186272D00", Slot = "15")]
	public NBLFFKLJBFE DDBCLDEOHIM(MGDDJCDOFPB GCMDDDCBJLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6275590", Offset = "0x6274990", VA = "0x186275590")]
	private static bool IEEBJAKDAIB(ECKIHLJAPFJ FHELLLJOEHE, MGDDJCDOFPB GCMDDDCBJLF, [Out] HOJAICNELBB? IFDDPEAGBII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6273910", Offset = "0x6272D10", VA = "0x186273910")]
	private static void FGACIHCICAN(ECKIHLJAPFJ FHELLLJOEHE, Action<HOJAICNELBB> KFKDKHLKBPJ, MGDDJCDOFPB KABIPMJKEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6273680", Offset = "0x6272A80", VA = "0x186273680")]
	private static void FGACIHCICAN(ECKIHLJAPFJ FHELLLJOEHE, Action<HOJAICNELBB> KFKDKHLKBPJ, Predicate<MGDDJCDOFPB> MHNCNLIFGLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6275EE0", Offset = "0x62752E0", VA = "0x186275EE0")]
	private void JGOFMKDICNP(CBOIFHFJJAA JKFHKEDOHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6276920", Offset = "0x6275D20", VA = "0x186276920", Slot = "4")]
	[AsyncStateMachine(typeof(FDGNCHBHBLP))]
	public Task MJMJDHGGKPD([CanBeNull] PPLFDHIJECO GBMIBBELHLP, CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "5")]
	public void OLCCNOLFEHJ(PPLFDHIJECO GBMIBBELHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6272010", Offset = "0x6271410", VA = "0x186272010")]
	private void AHPNPAIEAGB(ECKIHLJAPFJ AFFFFKHBOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6272DF0", Offset = "0x62721F0", VA = "0x186272DF0")]
	internal static string DEGAOOPAPJE(HALKGJCKJMI BIJPHKEAEFN, PPLFDHIJECO GBMIBBELHLP, IReadOnlyDictionary<MGDDJCDOFPB, CMFHPAPMHBI> LJEODKJLPFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6273A00", Offset = "0x6272E00", VA = "0x186273A00")]
	private static void GOPHBMLHGNP(PPLFDHIJECO GBMIBBELHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x62729B0", Offset = "0x6271DB0", VA = "0x1862729B0")]
	private static void CMHKCNGGDLD(ECKIHLJAPFJ MGGCOIPNIGB, IReadOnlyDictionary<MGDDJCDOFPB, CMFHPAPMHBI> LJEODKJLPFL, StringBuilder GNGFHOLPGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x62753B0", Offset = "0x62747B0", VA = "0x1862753B0")]
	private static bool HOBEEAGAPPF(string KOHMINPPMFF, [Out] Guid MAOLPMBCEJP, [Out] MGDDJCDOFPB GCMDDDCBJLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6276110", Offset = "0x6275510", VA = "0x186276110")]
	private static void KJCGOCIOGOA(PPLFDHIJECO GBMIBBELHLP, StringBuilder GNGFHOLPGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2232F60", Offset = "0x2232360", VA = "0x182232F60", Slot = "16")]
	public bool EIOLCECCODP<T>(MGDDJCDOFPB GCMDDDCBJLF, KJOOJOPGFNP ECDOHIOLIOP, bool MPOEHKFOOFJ, T GCCIFMALMDL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6276A40", Offset = "0x6275E40", VA = "0x186276A40")]
	private void NBCMGHNBOHN(MGDDJCDOFPB GCMDDDCBJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6276D70", Offset = "0x6276170", VA = "0x186276D70")]
	private bool PCHAOMGBBBA(CBOIFHFJJAA JKFHKEDOHFP, MGDDJCDOFPB GCMDDDCBJLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6273330", Offset = "0x6272730", VA = "0x186273330")]
	internal CMFHPAPMHBI ENINCDNPCPG(CBOIFHFJJAA JKFHKEDOHFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x62730F0", Offset = "0x62724F0", VA = "0x1862730F0", Slot = "13")]
	public IReadOnlyList<NBLFFKLJBFE> DKPMCEFLNPB(CBOIFHFJJAA JKFHKEDOHFP, bool HJKFIJIAPOA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6272780", Offset = "0x6271B80", VA = "0x186272780")]
	internal IReadOnlyList<CMFHPAPMHBI> BKMFAPEIMBP(CBOIFHFJJAA JKFHKEDOHFP, bool HJKFIJIAPOA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x62748B0", Offset = "0x6273CB0", VA = "0x1862748B0")]
	private void HEEJDMHHPKN(GFDJKKMBLLF KPKHLEAPHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x62758C0", Offset = "0x6274CC0", VA = "0x1862758C0")]
	private static bool IEGJKNDNPPD(CMFHPAPMHBI BHGDMKFDLMO, IReadOnlyDictionary<MGDDJCDOFPB, CMFHPAPMHBI> LJEODKJLPFL, [Out] IReadOnlyList<KJOOJOPGFNP> FDOGNBOLLPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6275BB0", Offset = "0x6274FB0", VA = "0x186275BB0")]
	[AsyncStateMachine(typeof(MJOEEFCDPOO))]
	private static Task JAMBOGPPJMP(HALKGJCKJMI BIJPHKEAEFN, PPLFDHIJECO GBMIBBELHLP, IReadOnlyDictionary<MGDDJCDOFPB, CMFHPAPMHBI> LJEODKJLPFL, MFECNOOLHIK BDDIICAMKHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x62724E0", Offset = "0x62718E0", VA = "0x1862724E0")]
	[CompilerGenerated]
	internal static void BDKAKHBJCAJ(Func<HOJAICNELBB, BCCMACEOLAH> MKNNPKIFOIK, AGIMLOMMECA P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6275040", Offset = "0x6274440", VA = "0x186275040")]
	[CompilerGenerated]
	internal static bool HGPIPLCBEAO(MGDDJCDOFPB GCMDDDCBJLF, KJOOJOPGFNP ECDOHIOLIOP, [Out] ICINOODLDLB NKCOEKGHEML, PMOMFLILNDJ P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface MKJFMOFGKEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IALNPFMOJBO(CBOIFHFJJAA FJOAPBFNOEL, CBOIFHFJJAA IBLILOEOCAK, IEnumerable<CBOIFHFJJAA> GJLJPKDLLEG, [Out] BMKHKMGICNJ MFLACNECEOJ, [Out] ADPMEINFHIK KOJFADKGFGO);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string MDMPLGMIJHL(ADPMEINFHIK KJJKJLFOFOP);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum ADPMEINFHIK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class FLOMIOMBNBH : MKJFMOFGKEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly OFMNONILMLH HCMIBEKKDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly EADOLCAJFOP EGPPPOGJGHC;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x76B3A0", Offset = "0x76A7A0", VA = "0x18076B3A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public FLOMIOMBNBH([LOJAGCNCPBJ(null)] OFMNONILMLH BCDABAHMDAC, [LOJAGCNCPBJ(null)] EADOLCAJFOP HGIAJGPIJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6278300", Offset = "0x6277700", VA = "0x186278300")]
	private static BFMNLELHFDC? NCHKHIHEOIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6277AE0", Offset = "0x6276EE0", VA = "0x186277AE0", Slot = "4")]
	public bool IALNPFMOJBO(CBOIFHFJJAA FJOAPBFNOEL, CBOIFHFJJAA IBLILOEOCAK, IEnumerable<CBOIFHFJJAA> GJLJPKDLLEG, [Out] BMKHKMGICNJ MFLACNECEOJ, [Out] ADPMEINFHIK KOJFADKGFGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6278200", Offset = "0x6277600", VA = "0x186278200", Slot = "5")]
	public string MDMPLGMIJHL(ADPMEINFHIK KJJKJLFOFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6277BE0", Offset = "0x6276FE0", VA = "0x186277BE0")]
	internal bool LMBJFCAHMJC(CBOIFHFJJAA FJOAPBFNOEL, CBOIFHFJJAA IBLILOEOCAK, IEnumerable<CBOIFHFJJAA> GJLJPKDLLEG, MAHFHIJJEDK BMDBLGIENNC, BFMNLELHFDC? PFHBNGENHDI, [Out] BMKHKMGICNJ MFLACNECEOJ, [Out] ADPMEINFHIK KOJFADKGFGO)
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
