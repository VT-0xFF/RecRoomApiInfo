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
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E54A40", Offset = "0x5E53E40", VA = "0x185E54A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x92A620", Offset = "0x929A20", VA = "0x18092A620")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NAGHLBGLEML
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E50020", Offset = "0x5E4F420", VA = "0x185E50020")]
	public static bool ANACCFJBOMO(LDCIEFOBGGJ HFEOICDHFOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E50060", Offset = "0x5E4F460", VA = "0x185E50060")]
	private static bool ANACCFJBOMO(CCJNHFAGIGN GPBNHLBGMJP, ref LDCIEFOBGGJ HFEOICDHFOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct PJPPHOJOPAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public List<KEBFAGOAMOE> EALKMEKHLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public IEnumerable<FJPJMDKGLDK> MKBLDEMLFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public MOPNKPCGICN PKOHGCLJKBF;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BFDJCAFBKKO
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(LFMCONFFCED FNIHENPLJHK, out Dictionary<int, int> BIGNKAAIMCH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(FFLDAJKOADL LOJKFCKEAMI, GBBOGMCCLLG EHPBIGBHDMK);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KIPLGGGBJPH
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
public sealed class AIBKMIHLLCP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<Guid, Guid> GHAKNMCFJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<Guid, Guid> ENDFEBIJOJE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<Guid, Guid> DNFKONKIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6E06E0", Offset = "0x6DFAE0", VA = "0x1806E06E0")]
	public AIBKMIHLLCP(Dictionary<Guid, Guid> GHAKNMCFJGG, Dictionary<Guid, Guid> ENDFEBIJOJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E4BE80", Offset = "0x5E4B280", VA = "0x185E4BE80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class NJMILCJNIGI
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class HILPLBJKHHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly HashSet<FJPJMDKGLDK> MFBHIODIMHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly HashSet<EOAHOGCPFLM> ABOBDLKGGGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly List<HFNKOEFNGMB> MAGIJMBJLBL;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5E4D2B0", Offset = "0x5E4C6B0", VA = "0x185E4D2B0")]
		public HILPLBJKHHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class FHELLFPFHDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public EOAHOGCPFLM destinationGraph;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public FHELLFPFHDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5E4C590", Offset = "0x5E4B990", VA = "0x185E4C590")]
		internal bool <InitializeCircuitsV2Remapping>b__0(MEDHHEJJIJH n)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class CHCEHLMGJFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int mpif;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public CHCEHLMGJFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5E4C4A0", Offset = "0x5E4B8A0", VA = "0x185E4C4A0")]
		internal void <InitializeCircuitsV2Remapping>b__1(MEDHHEJJIJH n)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5E52F60", Offset = "0x5E52360", VA = "0x185E52F60")]
	public static PKGAFLCANHJ NGFPDNHHEED(PJPPHOJOPAH HBJNLDOFDFE, out ICLLHKJPOGH IKMCDDHEGNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5E53590", Offset = "0x5E52990", VA = "0x185E53590")]
	private static void NPBCLBEBPCP(PKGAFLCANHJ ENLEHFBJKGP, HILPLBJKHHJ FHBEPMLLKFE, out ICLLHKJPOGH IKMCDDHEGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5E52E40", Offset = "0x5E52240", VA = "0x185E52E40")]
	private static void KJLKBMNFDCD(KEBFAGOAMOE FBBMLMLHHMA, HILPLBJKHHJ FHBEPMLLKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5E503E0", Offset = "0x5E4F7E0", VA = "0x185E503E0")]
	private static void CDPHLJAKFMK(PKGAFLCANHJ ENLEHFBJKGP, HILPLBJKHHJ FHBEPMLLKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E53690", Offset = "0x5E52A90", VA = "0x185E53690")]
	private static void OAHMKHMNAHB(ref PJPPHOJOPAH CMFABIOCLBA, HILPLBJKHHJ FHBEPMLLKFE, KEBFAGOAMOE FBBMLMLHHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5E51190", Offset = "0x5E50590", VA = "0x185E51190")]
	public static bool GMPBNGDMDBI(PKGAFLCANHJ ENLEHFBJKGP, IMIKKDBOIGB AIKNGMIEBCD, out AIBKMIHLLCP? JHCGFOKIPOO, out string? CNMFEBEOFOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5E51070", Offset = "0x5E50470", VA = "0x185E51070")]
	private static void EHIHPLPPODL(PKGAFLCANHJ ENLEHFBJKGP, ref IMIKKDBOIGB AIKNGMIEBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5E50D90", Offset = "0x5E50190", VA = "0x185E50D90")]
	public static Dictionary<Guid, Guid> EEGJGGNCHKG(IEnumerable<KEBFAGOAMOE> AJBAJGPIOJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5E50D50", Offset = "0x5E50150", VA = "0x185E50D50")]
	private static void DOOMDBJHNIM(PKGAFLCANHJ ENLEHFBJKGP, ref IMIKKDBOIGB AIKNGMIEBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E51950", Offset = "0x5E50D50", VA = "0x185E51950")]
	private static bool HFOJEKOIMLG(PKGAFLCANHJ ENLEHFBJKGP, FFLDAJKOADL LOJKFCKEAMI, ref IMIKKDBOIGB AIKNGMIEBCD, out string CNMFEBEOFOM, out Dictionary<int, int> BIGNKAAIMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E53950", Offset = "0x5E52D50", VA = "0x185E53950")]
	private static Dictionary<Guid, CCJNHFAGIGN> OEIFMKKFFML(PKGAFLCANHJ ENLEHFBJKGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E51F70", Offset = "0x5E51370", VA = "0x185E51F70")]
	private static bool HLMOGACINFF(PKGAFLCANHJ ENLEHFBJKGP, ref IMIKKDBOIGB AIKNGMIEBCD, out string? CNMFEBEOFOM, out EMCCAHPHMJD? IEIBPPGNNNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5E50CC0", Offset = "0x5E500C0", VA = "0x185E50CC0")]
	private static void DMCCIIGDBHG(bool DOFFOFFDNNB, KEBFAGOAMOE BPACDKOKENM, Dictionary<Guid, Guid> IOBNLDFANAG, EMCCAHPHMJD GMCBEJJLDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E52A10", Offset = "0x5E51E10", VA = "0x185E52A10")]
	private static void JEMNDGKCPDF(bool DOFFOFFDNNB, KEBFAGOAMOE BPACDKOKENM, EMCCAHPHMJD IEIBPPGNNNM, Guid IFDBDMBGEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E53BC0", Offset = "0x5E52FC0", VA = "0x185E53BC0")]
	private static void OEOPFHDPOCG(KEBFAGOAMOE BPACDKOKENM, Guid LPCEMMGKOFE, GNAJKEAEOBH? MHJCEGFCEMA, Dictionary<Guid, CCJNHFAGIGN> FBCKPENAHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E54950", Offset = "0x5E53D50", VA = "0x185E54950")]
	private static void PNCLLJIDJIN(KEBFAGOAMOE BPACDKOKENM, Dictionary<Guid, Guid> IOBNLDFANAG, Dictionary<int, int> MNLFEPOPHMA, FFLDAJKOADL DEEJFDFDEDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5E50680", Offset = "0x5E4FA80", VA = "0x185E50680")]
	public static void CPENOJIKGLH(RepeatedField<KEBFAGOAMOE> GLBGFHKCALK, LAHFKHFONPG BNLMLMEOGNJ, IEnumerable<ByteString> PJHILLBLMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5E53E60", Offset = "0x5E53260", VA = "0x185E53E60")]
	private static void ONBLIGCCFIC(RepeatedField<KEBFAGOAMOE> GLBGFHKCALK, CFKHFOKFMLK AMNKIAHLNGC, KIPLGGGBJPH NJMKBOFPJEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct IMIKKDBOIGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool DOFFOFFDNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public bool CIFEHBLAIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public GNAJKEAEOBH? MHJCEGFCEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public GNAJKEAEOBH? NKJGOOHGFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public HJEEEKBAMOF CLCLBJGECFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public KIPLGGGBJPH NJMKBOFPJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public BFDJCAFBKKO FECJENECIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public Guid IFDBDMBGEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public MOPNKPCGICN PKOHGCLJKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public List<KEBFAGOAMOE> NMNDIBLAJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public Dictionary<string, object> INMMEANDFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public AKFOKJAAECM JGKCAFFCGIJ;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct GNAJKEAEOBH
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private const float NGOPEPMKAPE = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Vector3 MIFJBHLKJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Quaternion OLBDAPNGDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float NHAEEIBBDJN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Matrix4x4 KENGHHENAAH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5E4CBB0", Offset = "0x5E4BFB0", VA = "0x185E4CBB0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x11C0C90", Offset = "0x11C0090", VA = "0x1811C0C90")]
	public GNAJKEAEOBH(Vector3 MIFJBHLKJIN, Quaternion OLBDAPNGDPL, float NHAEEIBBDJN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CF10", Offset = "0x5E4C310", VA = "0x185E4CF10")]
	public GNAJKEAEOBH(AHGOGHJJAIJ PAPKLIMHOGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CFE0", Offset = "0x5E4C3E0", VA = "0x185E4CFE0")]
	private GNAJKEAEOBH(IHKPFFLCNFP GIFNELFLKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C700", Offset = "0x5E4BB00", VA = "0x185E4C700")]
	public static GNAJKEAEOBH AHOCBIBLIJD(FJPJMDKGLDK MAEILCIEAFL)
	{
		return default(GNAJKEAEOBH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C8C0", Offset = "0x5E4BCC0", VA = "0x185E4C8C0")]
	public static GNAJKEAEOBH DJIIGPGMLBP(GNAJKEAEOBH OKMBLMILFGG, GNAJKEAEOBH HAEADBNPEOD)
	{
		return default(GNAJKEAEOBH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CA60", Offset = "0x5E4BE60", VA = "0x185E4CA60")]
	public static GNAJKEAEOBH HEFILGHKDEM((Vector3, Quaternion, float) FNIHENPLJHK)
	{
		return default(GNAJKEAEOBH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CAB0", Offset = "0x5E4BEB0", VA = "0x185E4CAB0")]
	public static GNAJKEAEOBH HEFILGHKDEM(Matrix4x4 OAMIFMCFPMI)
	{
		return default(GNAJKEAEOBH);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C730", Offset = "0x5E4BB30", VA = "0x185E4C730")]
	public GNAJKEAEOBH BJPJNCNGFOJ(Matrix4x4 PKIKNDCFAFJ)
	{
		return default(GNAJKEAEOBH);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CA10", Offset = "0x5E4BE10", VA = "0x185E4CA10")]
	public static GNAJKEAEOBH GGPDMFLMMBC(Vector3 MIFJBHLKJIN)
	{
		return default(GNAJKEAEOBH);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CCB0", Offset = "0x5E4C0B0", VA = "0x185E4CCB0")]
	[CompilerGenerated]
	internal static GNAJKEAEOBH PMLAIGECCFB(FJPJMDKGLDK BBGMDMKKHON)
	{
		return default(GNAJKEAEOBH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class JMCPFMPNNHG : GJLFJAFDMFA
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F000", Offset = "0x5E4E400", VA = "0x185E4F000", Slot = "4")]
	public void OKFPLMGFEGF(DPPPFALKJHM CBKFHCNHKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E4EAD0", Offset = "0x5E4DED0", VA = "0x185E4EAD0")]
	private void IPAHALBFKHI(Dictionary<Guid, Guid> PNMNMEIDGAC, BENIBEFMJCO CMCDOKAGDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5E4EA70", Offset = "0x5E4DE70", VA = "0x185E4EA70")]
	private void IPAHALBFKHI(Dictionary<Guid, Guid> PNMNMEIDGAC, ODOIMLFABOL EMPCADKGNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E820", Offset = "0x5E4DC20", VA = "0x185E4E820")]
	private void IPAHALBFKHI(Dictionary<Guid, Guid> PNMNMEIDGAC, NKIFAPOLIAA EKNLBBIHGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public JMCPFMPNNHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class CGCOGBDHJGM : GJLFJAFDMFA
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C210", Offset = "0x5E4B610", VA = "0x185E4C210", Slot = "4")]
	public void OKFPLMGFEGF(DPPPFALKJHM CBKFHCNHKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public CGCOGBDHJGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class OJLGAMNEJEP : GJLFJAFDMFA
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5E54C50", Offset = "0x5E54050", VA = "0x185E54C50", Slot = "4")]
	public void OKFPLMGFEGF(DPPPFALKJHM CBKFHCNHKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public OJLGAMNEJEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class PHPCONDCFEC : GJLFJAFDMFA
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5E54DC0", Offset = "0x5E541C0", VA = "0x185E54DC0", Slot = "4")]
	public void OKFPLMGFEGF(DPPPFALKJHM CBKFHCNHKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public PHPCONDCFEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class GOJEIAJELFP : GJLFJAFDMFA
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D0A0", Offset = "0x5E4C4A0", VA = "0x185E4D0A0", Slot = "4")]
	public void OKFPLMGFEGF(DPPPFALKJHM CBKFHCNHKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public GOJEIAJELFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class OIGBJKLEHKP : GJLFJAFDMFA
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5E54AD0", Offset = "0x5E53ED0", VA = "0x185E54AD0", Slot = "4")]
	public void OKFPLMGFEGF(DPPPFALKJHM CBKFHCNHKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public OIGBJKLEHKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class ALHMGPHIAAM : GJLFJAFDMFA
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5E4BEE0", Offset = "0x5E4B2E0", VA = "0x185E4BEE0", Slot = "4")]
	public void OKFPLMGFEGF(DPPPFALKJHM CBKFHCNHKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public ALHMGPHIAAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class FJPLGBLILNP : GJLFJAFDMFA
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C5E0", Offset = "0x5E4B9E0", VA = "0x185E4C5E0", Slot = "4")]
	public void OKFPLMGFEGF(DPPPFALKJHM CBKFHCNHKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public FJPLGBLILNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class CGEGHONHNKM : GJLFJAFDMFA
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C2D0", Offset = "0x5E4B6D0", VA = "0x185E4C2D0", Slot = "4")]
	public void OKFPLMGFEGF(DPPPFALKJHM CBKFHCNHKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public CGEGHONHNKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class LHJDAPCMLDF : GJLFJAFDMFA
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F0B0", Offset = "0x5E4E4B0", VA = "0x185E4F0B0", Slot = "4")]
	public void OKFPLMGFEGF(DPPPFALKJHM CBKFHCNHKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public LHJDAPCMLDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class IABEFFELFDE : GJLFJAFDMFA
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D3B0", Offset = "0x5E4C7B0", VA = "0x185E4D3B0", Slot = "4")]
	public void OKFPLMGFEGF(DPPPFALKJHM CBKFHCNHKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public IABEFFELFDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class AMMAGHAIJOM : GJLFJAFDMFA
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly System.Random LGJPFPONOKK;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C0D0", Offset = "0x5E4B4D0", VA = "0x185E4C0D0", Slot = "4")]
	public void OKFPLMGFEGF(DPPPFALKJHM CBKFHCNHKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public AMMAGHAIJOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct LDCIEFOBGGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public FFLDAJKOADL LFMBJAIIPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public GBJOKJCANCD GGHCFDIGAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Dictionary<int, int> MNLFEPOPHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Dictionary<Guid, Guid> PNHCNPFCJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public AKFOKJAAECM JGKCAFFCGIJ;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface GJLFJAFDMFA
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OKFPLMGFEGF(DPPPFALKJHM CBKFHCNHKMA);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MPHDAJBPNGK
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly GJLFJAFDMFA[] GOCMIELDJOP;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F7D0", Offset = "0x5E4EBD0", VA = "0x185E4F7D0")]
	public static void NNPLPEBIJJC(KEBFAGOAMOE FNIHENPLJHK, Dictionary<Guid, Guid> JILIDMFOCEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F5E0", Offset = "0x5E4E9E0", VA = "0x185E4F5E0")]
	public static void GMPEDHBKPNH(KEBFAGOAMOE? FNIHENPLJHK, EMCCAHPHMJD GMCBEJJLDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F280", Offset = "0x5E4E680", VA = "0x185E4F280")]
	public static void ANACCFJBOMO(DPPPFALKJHM CBKFHCNHKMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct DPPPFALKJHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public FFLDAJKOADL DPPAGOFNBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public KEBFAGOAMOE BPACDKOKENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Dictionary<int, int> MNLFEPOPHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Dictionary<Guid, Guid> PNHCNPFCJFG;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C4C0", Offset = "0x5E4B8C0", VA = "0x185E4C4C0")]
	public Guid BKDLENEGLDA(Guid DBODHDCBMLJ)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface AKFOKJAAECM
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int ILEEEGPIICO, out Guid CKJPIHEGLPC);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class JIFADKFCOLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<string> NGHKHOCDIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<long, int> KDOBPLPKHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<Guid> CCNHCINJDED;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyCollection<string> HAHLOCIBDCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<long, int> BFPILEJDCII
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D700", Offset = "0x5E4CB00", VA = "0x185E4D700")]
	public static JIFADKFCOLL MGFLIMBLGHO(JJGFELHFPKJ AONKGPLDMJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D540", Offset = "0x5E4C940", VA = "0x185E4D540")]
	public static JIFADKFCOLL KIBGPMOELCI(PKGAFLCANHJ PCOAPGPBJAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D5B0", Offset = "0x5E4C9B0", VA = "0x185E4D5B0")]
	public static JIFADKFCOLL KLEFOABCOKN(IEnumerable<string> NGHKHOCDIFH, IDictionary<long, int> HHAKOOEOABH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E720", Offset = "0x5E4DB20", VA = "0x185E4E720")]
	private JIFADKFCOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E600", Offset = "0x5E4DA00", VA = "0x185E4E600")]
	private JIFADKFCOLL(IEnumerable<string> NGHKHOCDIFH, IDictionary<long, int> HHAKOOEOABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5E4DB90", Offset = "0x5E4CF90", VA = "0x185E4DB90")]
	private void NPCDKMKJBDM(JJGFELHFPKJ AONKGPLDMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5E4DD50", Offset = "0x5E4D150", VA = "0x185E4DD50")]
	private void NPCDKMKJBDM(PKGAFLCANHJ PCOAPGPBJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D770", Offset = "0x5E4CB70", VA = "0x185E4D770")]
	private void NPCDKMKJBDM(LAHFKHFONPG? IGJDJDNFANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E2C0", Offset = "0x5E4D6C0", VA = "0x185E4E2C0")]
	private void NPCDKMKJBDM(MEDHHEJJIJH? BBGMDMKKHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5E4DF10", Offset = "0x5E4D310", VA = "0x185E4DF10")]
	private void NPCDKMKJBDM(KEBFAGOAMOE? BPACDKOKENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D4D0", Offset = "0x5E4C8D0", VA = "0x185E4D4D0")]
	private void HMONKDBEGGF(string? CPHMKCNKEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E520", Offset = "0x5E4D920", VA = "0x185E4E520")]
	private void PBCGLAAIHMD(ABGJAKPJOFK? AJAFDCIEAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E430", Offset = "0x5E4D830", VA = "0x185E4E430")]
	private void PBCGLAAIHMD(IMJALGBIMFG? AJAFDCIEAIL)
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
