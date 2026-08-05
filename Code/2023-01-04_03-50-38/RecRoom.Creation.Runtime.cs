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
		[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B35CB0", Offset = "0x5B350B0", VA = "0x185B35CB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x813880", Offset = "0x812C80", VA = "0x180813880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ICNKFBKDEEH
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5B35560", Offset = "0x5B34960", VA = "0x185B35560")]
	public static bool IKEDAJANFLG(CLLIKNMAPAG NCGDAIPGNGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5B355A0", Offset = "0x5B349A0", VA = "0x185B355A0")]
	private static bool IKEDAJANFLG(EEOJBMEJEKI CLIHPHOPMDP, ref CLLIKNMAPAG NCGDAIPGNGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct GKHDPLOIBDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public List<NBMCGLEDJNH> GDJDPHJEHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public IEnumerable<LEEJJOBICJL> FOGOGLCBLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public DOCNPNBOPDL MBGJIGHJDGH;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BEDPBJJEHFE
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(AJDOCGLDKDL PNMIIEJFOON, out Dictionary<int, int> PDHDHAHDDOD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(CHICPPMIFLO OFMPADJMGGK, PLAIJJLCNOB PKEDEMNCKEO);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CJJIMKDPJJO
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
public sealed class OHAEBGHCLPI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<Guid, Guid> NLIOMJPDOIM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<Guid, Guid> NBBEJGPMNLC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x678F40", Offset = "0x678340", VA = "0x180678F40")]
	public OHAEBGHCLPI(Dictionary<Guid, Guid> NLIOMJPDOIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5B35E60", Offset = "0x5B35260", VA = "0x185B35E60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class EBKCLODEMFM
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class IINKKCEDHAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public DDDGBODGAND destinationGraph;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public IINKKCEDHAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5B35920", Offset = "0x5B34D20", VA = "0x185B35920")]
		internal bool <InitializeCircuitsV2Remapping>b__0(LLOIDPCHDBE n)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class PCMMFDANEEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int mpif;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public PCMMFDANEEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5B35EB0", Offset = "0x5B352B0", VA = "0x185B35EB0")]
		internal void <InitializeCircuitsV2Remapping>b__1(LLOIDPCHDBE n)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly Dictionary<Guid, EEOJBMEJEKI> DFIPAAGAALD;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly Dictionary<Guid, Guid> LDJDGFDCOKJ;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly HashSet<LEEJJOBICJL> HIOHJICCCND;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly HashSet<DDDGBODGAND> MOEGMLGKIDG;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<HFADJKOFDOB> NGOLBGNBKHA;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5B33560", Offset = "0x5B32960", VA = "0x185B33560")]
	public static MLMDNBOHEEP OBJGLMODKPD(GKHDPLOIBDL AGDECCECIGG, out PLBMBJFPJMC LEOKMBOCGGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5B31100", Offset = "0x5B30500", VA = "0x185B31100")]
	private static void CIIFFMLJBJL(MLMDNBOHEEP AJBEEGFIHFN, out PLBMBJFPJMC LEOKMBOCGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5B2F5C0", Offset = "0x5B2E9C0", VA = "0x185B2F5C0")]
	private static void ACAIDNNLPLC(NBMCGLEDJNH BMKJMDOGBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5B33010", Offset = "0x5B32410", VA = "0x185B33010")]
	private static void MIEHKNDKKIK(MLMDNBOHEEP AJBEEGFIHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5B33300", Offset = "0x5B32700", VA = "0x185B33300")]
	private static void MJLGCGEDOII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5B30B50", Offset = "0x5B2FF50", VA = "0x185B30B50")]
	private static void CELNMEJILJI(ref GKHDPLOIBDL IGDHGAOKLOI, NBMCGLEDJNH BMKJMDOGBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5B312C0", Offset = "0x5B306C0", VA = "0x185B312C0")]
	public static bool IGGJLLFHJNO(MLMDNBOHEEP AJBEEGFIHFN, LPDGOKAHPBI PHHGNLNPPEC, out OHAEBGHCLPI? GICFDDDHBKP, out string? CIMKHIELLCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5B333E0", Offset = "0x5B327E0", VA = "0x185B333E0")]
	private static void MLMLNLJOIOO(MLMDNBOHEEP AJBEEGFIHFN, ref LPDGOKAHPBI PHHGNLNPPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5B31230", Offset = "0x5B30630", VA = "0x185B31230")]
	private static void IEIDHBHLONH(MLMDNBOHEEP AJBEEGFIHFN, ref LPDGOKAHPBI PHHGNLNPPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5B31B40", Offset = "0x5B30F40", VA = "0x185B31B40")]
	private static bool KILKCIBAEEB(MLMDNBOHEEP AJBEEGFIHFN, CHICPPMIFLO OFMPADJMGGK, ref LPDGOKAHPBI PHHGNLNPPEC, out string CIMKHIELLCI, out Dictionary<int, int> PDHDHAHDDOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5B2F750", Offset = "0x5B2EB50", VA = "0x185B2F750")]
	private static Dictionary<Guid, EEOJBMEJEKI> AKINGNANDBO(MLMDNBOHEEP AJBEEGFIHFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5B334E0", Offset = "0x5B328E0", VA = "0x185B334E0")]
	private static void MONAFJDINNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5B321F0", Offset = "0x5B315F0", VA = "0x185B321F0")]
	private static bool KOEJOFAGOGG(MLMDNBOHEEP AJBEEGFIHFN, ref LPDGOKAHPBI PHHGNLNPPEC, out string? CIMKHIELLCI, out NEHDLFDDJLC? JELLKPPCGED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5B32160", Offset = "0x5B31560", VA = "0x185B32160")]
	private static void KKKJLMIIAJM(bool OFOLPJFEMGJ, NBMCGLEDJNH FAPFPPANPDB, Dictionary<Guid, Guid> HBDINCMBHJN, NEHDLFDDJLC PLEHLJKBJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5B32BE0", Offset = "0x5B31FE0", VA = "0x185B32BE0")]
	private static void MGDIBGOEPML(bool OFOLPJFEMGJ, NBMCGLEDJNH FAPFPPANPDB, NEHDLFDDJLC JELLKPPCGED, Guid DLOABAHGKHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5B30E60", Offset = "0x5B30260", VA = "0x185B30E60")]
	private static void CFJLDLJAHBJ(NBMCGLEDJNH FAPFPPANPDB, Guid NKJELFCHAOK, EJACIOBLLCG? OOPLEDKCCHH, Dictionary<Guid, EEOJBMEJEKI> IMDDDHGHNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5B33A40", Offset = "0x5B32E40", VA = "0x185B33A40")]
	private static void PCACEDMOBPA(NBMCGLEDJNH FAPFPPANPDB, Dictionary<Guid, Guid> HBDINCMBHJN, Dictionary<int, int> MKCMNGFJJDA, CHICPPMIFLO MMMMAKODBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5B2F9D0", Offset = "0x5B2EDD0", VA = "0x185B2F9D0")]
	public static void ALBHINDMINO(RepeatedField<NBMCGLEDJNH> LFFFPGAMMIH, EFCCEPLILPI DCFCHDHMJKP, IEnumerable<ByteString> HHHIKONNHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5B30010", Offset = "0x5B2F410", VA = "0x185B30010")]
	private static void BGNOMEPMHDP(RepeatedField<NBMCGLEDJNH> LFFFPGAMMIH, CMMIIDNBEFF CNDKLJKGIHG, CJJIMKDPJJO IOLPCECAPDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct LPDGOKAHPBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public bool OFOLPJFEMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public bool ENMKLDNFDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public EJACIOBLLCG? OOPLEDKCCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public EJACIOBLLCG? IJMBIAHMIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public BMMIMHDLBBK JCKOMOHMKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public CJJIMKDPJJO IOLPCECAPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public BEDPBJJEHFE NEBBNNFIFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public Guid DLOABAHGKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public DOCNPNBOPDL MBGJIGHJDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public List<NBMCGLEDJNH> ANMDOIHFPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public Dictionary<string, object> GMIDGDDAMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public JOOEBLJFKGP NMOOHKJMPGH;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct EJACIOBLLCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Vector3 EFKMIDDCAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Quaternion IAPKIBMDFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float IAIJBOFPOEB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Matrix4x4 PKLIGEPBBGC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5B33E60", Offset = "0x5B33260", VA = "0x185B33E60")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static EJACIOBLLCG MKMJEPKCNPB
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5B33F90", Offset = "0x5B33390", VA = "0x185B33F90")]
		get
		{
			return default(EJACIOBLLCG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool BIGDGLECCFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5B33E50", Offset = "0x5B33250", VA = "0x185B33E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x154F220", Offset = "0x154E620", VA = "0x18154F220")]
	public EJACIOBLLCG(Vector3 EFKMIDDCAKM, Quaternion IAPKIBMDFEP, float IAIJBOFPOEB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5B34470", Offset = "0x5B33870", VA = "0x185B34470")]
	public EJACIOBLLCG(GINONKABOPB DOMIFOOICKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5B34590", Offset = "0x5B33990", VA = "0x185B34590")]
	private EJACIOBLLCG(OPKKLPIMEOH MDDJAIGOACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5B33F60", Offset = "0x5B33360", VA = "0x185B33F60")]
	public static EJACIOBLLCG DIGJKNHHKHP(LEEJJOBICJL BIKOIHCOCMG)
	{
		return default(EJACIOBLLCG);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5B33D00", Offset = "0x5B33100", VA = "0x185B33D00")]
	public static EJACIOBLLCG BBBGCKEODMH(EJACIOBLLCG JFCNGAACNEO, EJACIOBLLCG JFPMHGJCICD)
	{
		return default(EJACIOBLLCG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5B34250", Offset = "0x5B33650", VA = "0x185B34250")]
	public static EJACIOBLLCG GFKKOGBEPBN((Vector3, Quaternion, float) PNMIIEJFOON)
	{
		return default(EJACIOBLLCG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5B34150", Offset = "0x5B33550", VA = "0x185B34150")]
	public static EJACIOBLLCG GFKKOGBEPBN(Matrix4x4 NAICELDAIFK)
	{
		return default(EJACIOBLLCG);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5B33FC0", Offset = "0x5B333C0", VA = "0x185B33FC0")]
	public EJACIOBLLCG GFHKCIMFPGK(Matrix4x4 KFAGMEKKLDA)
	{
		return default(EJACIOBLLCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5B342A0", Offset = "0x5B336A0", VA = "0x185B342A0")]
	[CompilerGenerated]
	internal static EJACIOBLLCG OJGPAOLPMKH(LEEJJOBICJL EJMIEPKLJDN)
	{
		return default(EJACIOBLLCG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class GDIDGDCDNMM : DHPKLMLBNPE
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5B34770", Offset = "0x5B33B70", VA = "0x185B34770", Slot = "4")]
	public void CLNGCELHEKF(IJLPEPHINPD DELNNMNLIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5B34880", Offset = "0x5B33C80", VA = "0x185B34880")]
	private void GAKJNFFBDOG(Dictionary<Guid, Guid> GOIIIAJMCGG, ABGFJIJEKOP JOAAELFBMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5B34820", Offset = "0x5B33C20", VA = "0x185B34820")]
	private void GAKJNFFBDOG(Dictionary<Guid, Guid> GOIIIAJMCGG, JKJHADFHINB EBDBFDEMCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5B34DB0", Offset = "0x5B341B0", VA = "0x185B34DB0")]
	private void GAKJNFFBDOG(Dictionary<Guid, Guid> GOIIIAJMCGG, FCJDBDGLKDJ FPDLDEGBKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public GDIDGDCDNMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class HHGLLDFLGNA : DHPKLMLBNPE
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5B35330", Offset = "0x5B34730", VA = "0x185B35330", Slot = "4")]
	public void CLNGCELHEKF(IJLPEPHINPD DELNNMNLIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public HHGLLDFLGNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class HNOBCPIDNJB : DHPKLMLBNPE
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5B353F0", Offset = "0x5B347F0", VA = "0x185B353F0", Slot = "4")]
	public void CLNGCELHEKF(IJLPEPHINPD DELNNMNLIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public HNOBCPIDNJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class JIGIINLLBLE : DHPKLMLBNPE
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5B35B60", Offset = "0x5B34F60", VA = "0x185B35B60", Slot = "4")]
	public void CLNGCELHEKF(IJLPEPHINPD DELNNMNLIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public JIGIINLLBLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class PKOGHBOFCPJ : DHPKLMLBNPE
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5B35ED0", Offset = "0x5B352D0", VA = "0x185B35ED0", Slot = "4")]
	public void CLNGCELHEKF(IJLPEPHINPD DELNNMNLIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public PKOGHBOFCPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class ELADNCKCEII : DHPKLMLBNPE
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5B345F0", Offset = "0x5B339F0", VA = "0x185B345F0", Slot = "4")]
	public void CLNGCELHEKF(IJLPEPHINPD DELNNMNLIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public ELADNCKCEII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class GOKLDGBCDPD : DHPKLMLBNPE
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5B35000", Offset = "0x5B34400", VA = "0x185B35000", Slot = "4")]
	public void CLNGCELHEKF(IJLPEPHINPD DELNNMNLIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public GOKLDGBCDPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class OEPAGNOINNL : DHPKLMLBNPE
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5B35D40", Offset = "0x5B35140", VA = "0x185B35D40", Slot = "4")]
	public void CLNGCELHEKF(IJLPEPHINPD DELNNMNLIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public OEPAGNOINNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class CILPOKLDPBG : DHPKLMLBNPE
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5B2DED0", Offset = "0x5B2D2D0", VA = "0x185B2DED0", Slot = "4")]
	public void CLNGCELHEKF(IJLPEPHINPD DELNNMNLIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public CILPOKLDPBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class EABEKBCAEOA : DHPKLMLBNPE
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5B2F3F0", Offset = "0x5B2E7F0", VA = "0x185B2F3F0", Slot = "4")]
	public void CLNGCELHEKF(IJLPEPHINPD DELNNMNLIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public EABEKBCAEOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class JGJPOPHNMOA : DHPKLMLBNPE
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5B35A40", Offset = "0x5B34E40", VA = "0x185B35A40", Slot = "4")]
	public void CLNGCELHEKF(IJLPEPHINPD DELNNMNLIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public JGJPOPHNMOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class HDPMGGCGGNP : DHPKLMLBNPE
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly System.Random EMFDGMHDKED;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5B351F0", Offset = "0x5B345F0", VA = "0x185B351F0", Slot = "4")]
	public void CLNGCELHEKF(IJLPEPHINPD DELNNMNLIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public HDPMGGCGGNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct CLLIKNMAPAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public CHICPPMIFLO FMCKDMNHLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public JCNCNCJHBCH HCCKJOCPJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Dictionary<int, int> MKCMNGFJJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Dictionary<Guid, Guid> PDLBFGEPLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public JOOEBLJFKGP NMOOHKJMPGH;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface DHPKLMLBNPE
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CLNGCELHEKF(IJLPEPHINPD DELNNMNLIIE);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface JOOEBLJFKGP
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int LPDNMLLDLCB, out Guid JPBMCHLDDIA);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BKIFIDHPIEK
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly DHPKLMLBNPE[] EPCEJNBOKPH;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5B2D130", Offset = "0x5B2C530", VA = "0x185B2D130")]
	public static void HMELNOIAIHE(NBMCGLEDJNH PNMIIEJFOON, Dictionary<Guid, Guid> NOPDGLNEMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5B2D6A0", Offset = "0x5B2CAA0", VA = "0x185B2D6A0")]
	public static void OPKICMICHFL(NBMCGLEDJNH? PNMIIEJFOON, NEHDLFDDJLC PLEHLJKBJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5B2D340", Offset = "0x5B2C740", VA = "0x185B2D340")]
	public static void IKEDAJANFLG(IJLPEPHINPD DELNNMNLIIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct IJLPEPHINPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public CHICPPMIFLO GEJBIOBDENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NBMCGLEDJNH FAPFPPANPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Dictionary<int, int> MKCMNGFJJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Dictionary<Guid, Guid> PDLBFGEPLLO;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5B35970", Offset = "0x5B34D70", VA = "0x185B35970")]
	public Guid AJMNBBECGJN(Guid NOCBJPFIBOM)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class CNAEEODIDMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<string> LLHDAMFKKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<long, int> HGPCGCJJAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<Guid> KLILDEMGPPG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyCollection<string> MEBHKDPHLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<long, int> PPKJLNEFOFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5B2E0A0", Offset = "0x5B2D4A0", VA = "0x185B2E0A0")]
	public static CNAEEODIDMM BPEIKOEJGHH(BLKLDFBMGPO EFAPNGJIOOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5B2F010", Offset = "0x5B2E410", VA = "0x185B2F010")]
	public static CNAEEODIDMM PEOOAJIBNEN(MLMDNBOHEEP LCADHJENDOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5B2F080", Offset = "0x5B2E480", VA = "0x185B2F080")]
	public static CNAEEODIDMM PGJMCINHFBJ(IEnumerable<string> LLHDAMFKKJH, IDictionary<long, int> EFJHNADJKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5B2F2F0", Offset = "0x5B2E6F0", VA = "0x185B2F2F0")]
	private CNAEEODIDMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5B2F1D0", Offset = "0x5B2E5D0", VA = "0x185B2F1D0")]
	private CNAEEODIDMM(IEnumerable<string> LLHDAMFKKJH, IDictionary<long, int> EFJHNADJKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5B2EE50", Offset = "0x5B2E250", VA = "0x185B2EE50")]
	private void HNGNANDFIHE(BLKLDFBMGPO EFAPNGJIOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5B2E8E0", Offset = "0x5B2DCE0", VA = "0x185B2E8E0")]
	private void HNGNANDFIHE(MLMDNBOHEEP LCADHJENDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5B2E350", Offset = "0x5B2D750", VA = "0x185B2E350")]
	private void HNGNANDFIHE(EFCCEPLILPI NMIIAOIKHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5B2E770", Offset = "0x5B2DB70", VA = "0x185B2E770")]
	private void HNGNANDFIHE(LLOIDPCHDBE EJMIEPKLJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5B2EAA0", Offset = "0x5B2DEA0", VA = "0x185B2EAA0")]
	private void HNGNANDFIHE(NBMCGLEDJNH FAPFPPANPDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5B2E110", Offset = "0x5B2D510", VA = "0x185B2E110")]
	private void DMDENHGOBAA(string FKJKJCMJMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5B2E270", Offset = "0x5B2D670", VA = "0x185B2E270")]
	private void GNNFDFCMDKG(OCGMJFDMKBJ OHNDHBOABEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5B2E180", Offset = "0x5B2D580", VA = "0x185B2E180")]
	private void GNNFDFCMDKG(AFOIIMBNCNA OHNDHBOABEF)
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
