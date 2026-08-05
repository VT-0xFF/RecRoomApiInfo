using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Microsoft.CodeAnalysis;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780")]
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
		[Cpp2IlInjected.Address(RVA = "0x5BC7E90", Offset = "0x5BC6A90", VA = "0x185BC7E90")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB37F50", Offset = "0xB36B50", VA = "0x180B37F50")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JGBMIGAMPHP
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5BC48B0", Offset = "0x5BC34B0", VA = "0x185BC48B0")]
	public static bool OJIIFDMGDIB(OBICGBDGMDE DHJDLIMLGHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5BC4530", Offset = "0x5BC3130", VA = "0x185BC4530")]
	private static bool OJIIFDMGDIB(JKLEOMGBONH LOLPIOKBEEP, ref OBICGBDGMDE DHJDLIMLGHK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct JOKCBEKILHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public List<CFFAMHPODII> HEGDCKFONLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public IEnumerable<FAHEAOLDJCE> GDMODFCDEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public FMMDKANBMBD PPLOHLIJPJP;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BOMNPJGJLIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(NIMEMECHGHF GAGLKGONONJ, out Dictionary<int, int> EOPDDFJNMGE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(ALPEFALFPBN BBPFIFGABMD, NMAHIIDNPHL EPNAFFFOOPM);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CKFGDGLCGGC
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<ByteString> GetValidRoomCurrencies();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ByteString> GetValidRoomConsumables();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class OLGBDELOLLG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<Guid, Guid> MBCOOJAHCGI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<Guid, Guid> OHKAMIABJFH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7343F0", Offset = "0x732FF0", VA = "0x1807343F0")]
	public OLGBDELOLLG(Dictionary<Guid, Guid> MBCOOJAHCGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5BC7F20", Offset = "0x5BC6B20", VA = "0x185BC7F20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class IEFDEKBJHNH
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class MDALMJPIIDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public NKBCNJAENAF destinationGraph;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public MDALMJPIIDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5BC7480", Offset = "0x5BC6080", VA = "0x185BC7480")]
		internal bool <InitializeCircuitsV2Remapping>b__0(JCMJNBOEPLB n)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class KKHLECBJKOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int mpif;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public KKHLECBJKOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5BC5370", Offset = "0x5BC3F70", VA = "0x185BC5370")]
		internal void <InitializeCircuitsV2Remapping>b__1(JCMJNBOEPLB n)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly Dictionary<Guid, JKLEOMGBONH> ALAEGCGFBAC;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly Dictionary<Guid, Guid> NHHIBEBGOOE;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly HashSet<FAHEAOLDJCE> DIDNBPAIOJC;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly HashSet<NKBCNJAENAF> IJEOEOEKDAI;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<DGDLIGDFKFM> OKHNFEIIKPP;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5BBFBC0", Offset = "0x5BBE7C0", VA = "0x185BBFBC0")]
	public static HFPCJHCMKPF CDGLBHINHJA(JOKCBEKILHH LKHAIBNLAFE, out PGJHNFICFCG PHCCPHCKGOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5BC0BA0", Offset = "0x5BBF7A0", VA = "0x185BC0BA0")]
	private static void EELKAJBFGHL(HFPCJHCMKPF NKMICFOHMBD, out PGJHNFICFCG PHCCPHCKGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3600", Offset = "0x5BC2200", VA = "0x185BC3600")]
	private static void LICBNFOBJLI(CFFAMHPODII LHINPDDHOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5BC1370", Offset = "0x5BBFF70", VA = "0x185BC1370")]
	private static void GGGHJMHIFBB(HFPCJHCMKPF NKMICFOHMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3C30", Offset = "0x5BC2830", VA = "0x185BC3C30")]
	private static void NNPONCOMOII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3890", Offset = "0x5BC2490", VA = "0x185BC3890")]
	private static void LMIJHEOLBFD(ref JOKCBEKILHH CNCOMGJEKDF, CFFAMHPODII LHINPDDHOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5BC0320", Offset = "0x5BBEF20", VA = "0x185BC0320")]
	public static bool DKALJMJEHDE(HFPCJHCMKPF NKMICFOHMBD, JIILFMEENFK KOIIHKFDBND, out OLGBDELOLLG? JNMPKPJDLPE, out string? CHGFDAMICCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3790", Offset = "0x5BC2390", VA = "0x185BC3790")]
	private static void LMBPLNLPPMO(HFPCJHCMKPF NKMICFOHMBD, ref JIILFMEENFK KOIIHKFDBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5BBFB30", Offset = "0x5BBE730", VA = "0x185BBFB30")]
	private static void BFAMIOHFELP(HFPCJHCMKPF NKMICFOHMBD, ref JIILFMEENFK KOIIHKFDBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5BC0D50", Offset = "0x5BBF950", VA = "0x185BC0D50")]
	private static bool ENOJEHILCNB(HFPCJHCMKPF NKMICFOHMBD, ALPEFALFPBN BBPFIFGABMD, ref JIILFMEENFK KOIIHKFDBND, out string CHGFDAMICCB, out Dictionary<int, int> EOPDDFJNMGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5BC00A0", Offset = "0x5BBECA0", VA = "0x185BC00A0")]
	private static Dictionary<Guid, JKLEOMGBONH> COFNBMEEMLF(HFPCJHCMKPF NKMICFOHMBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5BC0CD0", Offset = "0x5BBF8D0", VA = "0x185BC0CD0")]
	private static void EFFJEJKLMNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5BC2C10", Offset = "0x5BC1810", VA = "0x185BC2C10")]
	private static bool JFMHAHLEHGF(HFPCJHCMKPF NKMICFOHMBD, ref JIILFMEENFK KOIIHKFDBND, out string? CHGFDAMICCB, out MLJEFIGLHFB? AAMGDOAKKLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3BA0", Offset = "0x5BC27A0", VA = "0x185BC3BA0")]
	private static void NEHKMNEGJIM(bool FMPPNHJLKNJ, CFFAMHPODII CKANKMGFDMC, Dictionary<Guid, Guid> BPCNIPOKBFH, MLJEFIGLHFB AADJIMJKCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5BC1CA0", Offset = "0x5BC08A0", VA = "0x185BC1CA0")]
	private static void IDMKPCLGKNJ(bool FMPPNHJLKNJ, CFFAMHPODII CKANKMGFDMC, MLJEFIGLHFB AAMGDOAKKLB, Guid JMDEJLNDJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3D10", Offset = "0x5BC2910", VA = "0x185BC3D10")]
	private static void OGMEADPKJJO(CFFAMHPODII CKANKMGFDMC, Guid PLNBMNDLIME, NEAOKKBJKLL? EJNHDJHGHCP, Dictionary<Guid, JKLEOMGBONH> DIGFKCOBOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3FB0", Offset = "0x5BC2BB0", VA = "0x185BC3FB0")]
	private static void PEJOLIEOEAA(CFFAMHPODII CKANKMGFDMC, Dictionary<Guid, Guid> BPCNIPOKBFH, Dictionary<int, int> IGPOIHNLILH, ALPEFALFPBN HFFEMHANFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5BC1660", Offset = "0x5BC0260", VA = "0x185BC1660")]
	public static void IBOPHCNIEHF(RepeatedField<CFFAMHPODII> KPNMGLLENGA, DMCIAOLEEFH AKPCNIKFLKK, IEnumerable<ByteString> NDLOPFLNGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5BC20D0", Offset = "0x5BC0CD0", VA = "0x185BC20D0")]
	private static void IOABFHMBDNL(RepeatedField<CFFAMHPODII> KPNMGLLENGA, BHNBPPHEEFK KJMDJAHBNGP, CKFGDGLCGGC FFHJODONBMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct JIILFMEENFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public bool FMPPNHJLKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public bool CKNMIDNDGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NEAOKKBJKLL? EJNHDJHGHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NEAOKKBJKLL? HOCBMMEGNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public EHICANDBICP PFMHMPJMMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public CKFGDGLCGGC FFHJODONBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public BOMNPJGJLIJ JJNANGONEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public Guid JMDEJLNDJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public FMMDKANBMBD PPLOHLIJPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public List<CFFAMHPODII> NNLDJLPCHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public Dictionary<string, object> DJLEGBGELMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public CPIKDEPCEEN KKFIOOPKPHI;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct NEAOKKBJKLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Vector3 BBEHPKKOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Quaternion IDIJNBAPGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float CGDLHLIKGDL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Matrix4x4 ICPCOKEIEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5BC7BE0", Offset = "0x5BC67E0", VA = "0x185BC7BE0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static NEAOKKBJKLL NHKOJHMPOGB
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5BC7910", Offset = "0x5BC6510", VA = "0x185BC7910")]
		get
		{
			return default(NEAOKKBJKLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool FEBNHICBEJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5BC7730", Offset = "0x5BC6330", VA = "0x185BC7730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1C1F800", Offset = "0x1C1E400", VA = "0x181C1F800")]
	public NEAOKKBJKLL(Vector3 BBEHPKKOBDE, Quaternion IDIJNBAPGMK, float CGDLHLIKGDL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5BC7D10", Offset = "0x5BC6910", VA = "0x185BC7D10")]
	public NEAOKKBJKLL(AHDPFDAPPHM PBBNJOGHEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5BC7E30", Offset = "0x5BC6A30", VA = "0x185BC7E30")]
	private NEAOKKBJKLL(IBENDNNBHCG JBFKIILCOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5BC7CE0", Offset = "0x5BC68E0", VA = "0x185BC7CE0")]
	public static NEAOKKBJKLL LMCEMOJHBHD(FAHEAOLDJCE EMFPAHOGIJP)
	{
		return default(NEAOKKBJKLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5BC7A90", Offset = "0x5BC6690", VA = "0x185BC7A90")]
	public static NEAOKKBJKLL IPLKEHGDHJM(NEAOKKBJKLL NIGFDFKEKGM, NEAOKKBJKLL HMJFIHDPIBC)
	{
		return default(NEAOKKBJKLL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5BC7A40", Offset = "0x5BC6640", VA = "0x185BC7A40")]
	public static NEAOKKBJKLL GGDPAIJEDCE((Vector3, Quaternion, float) GAGLKGONONJ)
	{
		return default(NEAOKKBJKLL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5BC7940", Offset = "0x5BC6540", VA = "0x185BC7940")]
	public static NEAOKKBJKLL GGDPAIJEDCE(Matrix4x4 IDFIGGNDOHN)
	{
		return default(NEAOKKBJKLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5BC75A0", Offset = "0x5BC61A0", VA = "0x185BC75A0")]
	public NEAOKKBJKLL AKEIJKAGIDB(Matrix4x4 IGPPDIMEFDL)
	{
		return default(NEAOKKBJKLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5BC7740", Offset = "0x5BC6340", VA = "0x185BC7740")]
	[CompilerGenerated]
	internal static NEAOKKBJKLL CCLLNJCMHDE(FAHEAOLDJCE PABNHBKHCNM)
	{
		return default(NEAOKKBJKLL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class JKLCBNIGOOC : LDHEMKKCGLH
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5BC50D0", Offset = "0x5BC3CD0", VA = "0x185BC50D0", Slot = "4")]
	public void PFADELPBGLK(MJKFAPIBEFB EJIOKEDLLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5BC48F0", Offset = "0x5BC34F0", VA = "0x185BC48F0")]
	private void JMJFHBIDGJP(Dictionary<Guid, Guid> MDDNDGEEHIB, KIHHOJAPFAA MKEEFNABAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5BC4E20", Offset = "0x5BC3A20", VA = "0x185BC4E20")]
	private void JMJFHBIDGJP(Dictionary<Guid, Guid> MDDNDGEEHIB, EFICEALGPEE HLPAIOCIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5BC4E80", Offset = "0x5BC3A80", VA = "0x185BC4E80")]
	private void JMJFHBIDGJP(Dictionary<Guid, Guid> MDDNDGEEHIB, NPELJJBMFMA NKKCMIBANEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public JKLCBNIGOOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class PHKIMOMEAIO : LDHEMKKCGLH
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5BC8180", Offset = "0x5BC6D80", VA = "0x185BC8180", Slot = "4")]
	public void PFADELPBGLK(MJKFAPIBEFB EJIOKEDLLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public PHKIMOMEAIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class IJFAPPDJCLD : LDHEMKKCGLH
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5BC4270", Offset = "0x5BC2E70", VA = "0x185BC4270", Slot = "4")]
	public void PFADELPBGLK(MJKFAPIBEFB EJIOKEDLLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public IJFAPPDJCLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class IMJKKDAHOJI : LDHEMKKCGLH
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5BC43E0", Offset = "0x5BC2FE0", VA = "0x185BC43E0", Slot = "4")]
	public void PFADELPBGLK(MJKFAPIBEFB EJIOKEDLLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public IMJKKDAHOJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class ONIJCLAJPCF : LDHEMKKCGLH
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5BC7F70", Offset = "0x5BC6B70", VA = "0x185BC7F70", Slot = "4")]
	public void PFADELPBGLK(MJKFAPIBEFB EJIOKEDLLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public ONIJCLAJPCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class EELICHOMKOI : LDHEMKKCGLH
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5BBF5A0", Offset = "0x5BBE1A0", VA = "0x185BBF5A0", Slot = "4")]
	public void PFADELPBGLK(MJKFAPIBEFB EJIOKEDLLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public EELICHOMKOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class KBEEMBCDADI : LDHEMKKCGLH
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5BC5180", Offset = "0x5BC3D80", VA = "0x185BC5180", Slot = "4")]
	public void PFADELPBGLK(MJKFAPIBEFB EJIOKEDLLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public KBEEMBCDADI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class FAGFKLFAEOG : LDHEMKKCGLH
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5BBF720", Offset = "0x5BBE320", VA = "0x185BBF720", Slot = "4")]
	public void PFADELPBGLK(MJKFAPIBEFB EJIOKEDLLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public FAGFKLFAEOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class HHIAFHNJGLO : LDHEMKKCGLH
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5BBF960", Offset = "0x5BBE560", VA = "0x185BBF960", Slot = "4")]
	public void PFADELPBGLK(MJKFAPIBEFB EJIOKEDLLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public HHIAFHNJGLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class BLMICKKLJMD : LDHEMKKCGLH
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5BBF3D0", Offset = "0x5BBDFD0", VA = "0x185BBF3D0", Slot = "4")]
	public void PFADELPBGLK(MJKFAPIBEFB EJIOKEDLLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public BLMICKKLJMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class GHBFCKJPMOM : LDHEMKKCGLH
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5BBF840", Offset = "0x5BBE440", VA = "0x185BBF840", Slot = "4")]
	public void PFADELPBGLK(MJKFAPIBEFB EJIOKEDLLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public GHBFCKJPMOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class AGKDOFEGADF : LDHEMKKCGLH
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly System.Random MCGLLJEBAKA;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5BBF290", Offset = "0x5BBDE90", VA = "0x185BBF290", Slot = "4")]
	public void PFADELPBGLK(MJKFAPIBEFB EJIOKEDLLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public AGKDOFEGADF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct OBICGBDGMDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public ALPEFALFPBN OLOLCGEOMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public AMBFKELGBKG KHEKHKCOINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Dictionary<int, int> IGPOIHNLILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Dictionary<Guid, Guid> KOBBLHAGPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public CPIKDEPCEEN KKFIOOPKPHI;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface LDHEMKKCGLH
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PFADELPBGLK(MJKFAPIBEFB EJIOKEDLLDC);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface CPIKDEPCEEN
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int BBNKIAGFCJP, out Guid MOONIGLNOKH);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MBHEFNPDEJB
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly LDHEMKKCGLH[] NKBFKNKELCI;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5BC68D0", Offset = "0x5BC54D0", VA = "0x185BC68D0")]
	public static void KJINCIFOBPN(CFFAMHPODII GAGLKGONONJ, Dictionary<Guid, Guid> CEIPMILEDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5BC66E0", Offset = "0x5BC52E0", VA = "0x185BC66E0")]
	public static void FNBIHFAHFGG(CFFAMHPODII? GAGLKGONONJ, MLJEFIGLHFB AADJIMJKCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5BC6AE0", Offset = "0x5BC56E0", VA = "0x185BC6AE0")]
	public static void OJIIFDMGDIB(MJKFAPIBEFB EJIOKEDLLDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct MJKFAPIBEFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public ALPEFALFPBN DAMELJEDLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public CFFAMHPODII CKANKMGFDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Dictionary<int, int> IGPOIHNLILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Dictionary<Guid, Guid> KOBBLHAGPFF;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5BC74D0", Offset = "0x5BC60D0", VA = "0x185BC74D0")]
	public Guid ELCBMCPOCHH(Guid PKLNDGIEPCP)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class LMHLEDALAHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<string> IIKIPLNBHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<long, int> BMGHPNMGDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<Guid> HCNHGEJBKKH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyCollection<string> HAFJKDIFMDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<long, int> EENJDBNNFNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5BC6450", Offset = "0x5BC5050", VA = "0x185BC6450")]
	public static LMHLEDALAHC MHCPFPEAJLH(HNMNGPNPECE CAMLOJNDCJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5BC5390", Offset = "0x5BC3F90", VA = "0x185BC5390")]
	public static LMHLEDALAHC CPAGKLMOCPO(HFPCJHCMKPF KFMJCMGMEED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5BC6300", Offset = "0x5BC4F00", VA = "0x185BC6300")]
	public static LMHLEDALAHC MEKAIMLOBME(IEnumerable<string> IIKIPLNBHFK, IDictionary<long, int> COKAOHPOHFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5BC64C0", Offset = "0x5BC50C0", VA = "0x185BC64C0")]
	private LMHLEDALAHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5BC65C0", Offset = "0x5BC51C0", VA = "0x185BC65C0")]
	private LMHLEDALAHC(IEnumerable<string> IIKIPLNBHFK, IDictionary<long, int> COKAOHPOHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5BC5BB0", Offset = "0x5BC47B0", VA = "0x185BC5BB0")]
	private void JPGBAIBGGFB(HNMNGPNPECE CAMLOJNDCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5BC55D0", Offset = "0x5BC41D0", VA = "0x185BC55D0")]
	private void JPGBAIBGGFB(HFPCJHCMKPF KFMJCMGMEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5BC5790", Offset = "0x5BC4390", VA = "0x185BC5790")]
	private void JPGBAIBGGFB(DMCIAOLEEFH KAHCIEGOGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5BC5D70", Offset = "0x5BC4970", VA = "0x185BC5D70")]
	private void JPGBAIBGGFB(JCMJNBOEPLB PABNHBKHCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5BC5EE0", Offset = "0x5BC4AE0", VA = "0x185BC5EE0")]
	private void JPGBAIBGGFB(CFFAMHPODII CKANKMGFDMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5BC6290", Offset = "0x5BC4E90", VA = "0x185BC6290")]
	private void MEFPILLDHKC(string OLJEDPPEPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5BC5400", Offset = "0x5BC4000", VA = "0x185BC5400")]
	private void CPCNNJFCCJC(CPMOIJAPBAM PPCGHBLHMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5BC54E0", Offset = "0x5BC40E0", VA = "0x185BC54E0")]
	private void CPCNNJFCCJC(APIKEHPNPNA PPCGHBLHMGA)
	{
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
