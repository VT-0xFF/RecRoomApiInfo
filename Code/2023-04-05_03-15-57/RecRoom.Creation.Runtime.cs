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
		[Cpp2IlInjected.Address(RVA = "0x5DF9040", Offset = "0x5DF8040", VA = "0x185DF9040")]
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
		[Cpp2IlInjected.Address(RVA = "0x929620", Offset = "0x928620", VA = "0x180929620")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NAGHLBGLEML
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4620", Offset = "0x5DF3620", VA = "0x185DF4620")]
	public static bool ANACCFJBOMO(LDCIEFOBGGJ HFEOICDHFOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4660", Offset = "0x5DF3660", VA = "0x185DF4660")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6DF6E0", Offset = "0x6DE6E0", VA = "0x1806DF6E0")]
	public AIBKMIHLLCP(Dictionary<Guid, Guid> GHAKNMCFJGG, Dictionary<Guid, Guid> ENDFEBIJOJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0480", Offset = "0x5DEF480", VA = "0x185DF0480", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DF18B0", Offset = "0x5DF08B0", VA = "0x185DF18B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public FHELLFPFHDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5DF0B90", Offset = "0x5DEFB90", VA = "0x185DF0B90")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public CHCEHLMGJFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5DF0AA0", Offset = "0x5DEFAA0", VA = "0x185DF0AA0")]
		internal void <InitializeCircuitsV2Remapping>b__1(MEDHHEJJIJH n)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7560", Offset = "0x5DF6560", VA = "0x185DF7560")]
	public static PKGAFLCANHJ NGFPDNHHEED(PJPPHOJOPAH HBJNLDOFDFE, out ICLLHKJPOGH IKMCDDHEGNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7B90", Offset = "0x5DF6B90", VA = "0x185DF7B90")]
	private static void NPBCLBEBPCP(PKGAFLCANHJ ENLEHFBJKGP, HILPLBJKHHJ FHBEPMLLKFE, out ICLLHKJPOGH IKMCDDHEGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7440", Offset = "0x5DF6440", VA = "0x185DF7440")]
	private static void KJLKBMNFDCD(KEBFAGOAMOE FBBMLMLHHMA, HILPLBJKHHJ FHBEPMLLKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5DF49E0", Offset = "0x5DF39E0", VA = "0x185DF49E0")]
	private static void CDPHLJAKFMK(PKGAFLCANHJ ENLEHFBJKGP, HILPLBJKHHJ FHBEPMLLKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7C90", Offset = "0x5DF6C90", VA = "0x185DF7C90")]
	private static void OAHMKHMNAHB(ref PJPPHOJOPAH CMFABIOCLBA, HILPLBJKHHJ FHBEPMLLKFE, KEBFAGOAMOE FBBMLMLHHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5790", Offset = "0x5DF4790", VA = "0x185DF5790")]
	public static bool GMPBNGDMDBI(PKGAFLCANHJ ENLEHFBJKGP, IMIKKDBOIGB AIKNGMIEBCD, out AIBKMIHLLCP? JHCGFOKIPOO, out string? CNMFEBEOFOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5670", Offset = "0x5DF4670", VA = "0x185DF5670")]
	private static void EHIHPLPPODL(PKGAFLCANHJ ENLEHFBJKGP, ref IMIKKDBOIGB AIKNGMIEBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5390", Offset = "0x5DF4390", VA = "0x185DF5390")]
	public static Dictionary<Guid, Guid> EEGJGGNCHKG(IEnumerable<KEBFAGOAMOE> AJBAJGPIOJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5350", Offset = "0x5DF4350", VA = "0x185DF5350")]
	private static void DOOMDBJHNIM(PKGAFLCANHJ ENLEHFBJKGP, ref IMIKKDBOIGB AIKNGMIEBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5F50", Offset = "0x5DF4F50", VA = "0x185DF5F50")]
	private static bool HFOJEKOIMLG(PKGAFLCANHJ ENLEHFBJKGP, FFLDAJKOADL LOJKFCKEAMI, ref IMIKKDBOIGB AIKNGMIEBCD, out string CNMFEBEOFOM, out Dictionary<int, int> BIGNKAAIMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7F50", Offset = "0x5DF6F50", VA = "0x185DF7F50")]
	private static Dictionary<Guid, CCJNHFAGIGN> OEIFMKKFFML(PKGAFLCANHJ ENLEHFBJKGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6570", Offset = "0x5DF5570", VA = "0x185DF6570")]
	private static bool HLMOGACINFF(PKGAFLCANHJ ENLEHFBJKGP, ref IMIKKDBOIGB AIKNGMIEBCD, out string? CNMFEBEOFOM, out EMCCAHPHMJD? IEIBPPGNNNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF52C0", Offset = "0x5DF42C0", VA = "0x185DF52C0")]
	private static void DMCCIIGDBHG(bool DOFFOFFDNNB, KEBFAGOAMOE BPACDKOKENM, Dictionary<Guid, Guid> IOBNLDFANAG, EMCCAHPHMJD GMCBEJJLDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7010", Offset = "0x5DF6010", VA = "0x185DF7010")]
	private static void JEMNDGKCPDF(bool DOFFOFFDNNB, KEBFAGOAMOE BPACDKOKENM, EMCCAHPHMJD IEIBPPGNNNM, Guid IFDBDMBGEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF81C0", Offset = "0x5DF71C0", VA = "0x185DF81C0")]
	private static void OEOPFHDPOCG(KEBFAGOAMOE BPACDKOKENM, Guid LPCEMMGKOFE, GNAJKEAEOBH? MHJCEGFCEMA, Dictionary<Guid, CCJNHFAGIGN> FBCKPENAHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8F50", Offset = "0x5DF7F50", VA = "0x185DF8F50")]
	private static void PNCLLJIDJIN(KEBFAGOAMOE BPACDKOKENM, Dictionary<Guid, Guid> IOBNLDFANAG, Dictionary<int, int> MNLFEPOPHMA, FFLDAJKOADL DEEJFDFDEDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4C80", Offset = "0x5DF3C80", VA = "0x185DF4C80")]
	public static void CPENOJIKGLH(RepeatedField<KEBFAGOAMOE> GLBGFHKCALK, LAHFKHFONPG BNLMLMEOGNJ, IEnumerable<ByteString> PJHILLBLMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8460", Offset = "0x5DF7460", VA = "0x185DF8460")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DF11B0", Offset = "0x5DF01B0", VA = "0x185DF11B0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x177A1E0", Offset = "0x17791E0", VA = "0x18177A1E0")]
	public GNAJKEAEOBH(Vector3 MIFJBHLKJIN, Quaternion OLBDAPNGDPL, float NHAEEIBBDJN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1510", Offset = "0x5DF0510", VA = "0x185DF1510")]
	public GNAJKEAEOBH(AHGOGHJJAIJ PAPKLIMHOGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5DF15E0", Offset = "0x5DF05E0", VA = "0x185DF15E0")]
	private GNAJKEAEOBH(IHKPFFLCNFP GIFNELFLKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0D00", Offset = "0x5DEFD00", VA = "0x185DF0D00")]
	public static GNAJKEAEOBH AHOCBIBLIJD(FJPJMDKGLDK MAEILCIEAFL)
	{
		return default(GNAJKEAEOBH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0EC0", Offset = "0x5DEFEC0", VA = "0x185DF0EC0")]
	public static GNAJKEAEOBH DJIIGPGMLBP(GNAJKEAEOBH OKMBLMILFGG, GNAJKEAEOBH HAEADBNPEOD)
	{
		return default(GNAJKEAEOBH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1060", Offset = "0x5DF0060", VA = "0x185DF1060")]
	public static GNAJKEAEOBH HEFILGHKDEM((Vector3, Quaternion, float) FNIHENPLJHK)
	{
		return default(GNAJKEAEOBH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF10B0", Offset = "0x5DF00B0", VA = "0x185DF10B0")]
	public static GNAJKEAEOBH HEFILGHKDEM(Matrix4x4 OAMIFMCFPMI)
	{
		return default(GNAJKEAEOBH);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0D30", Offset = "0x5DEFD30", VA = "0x185DF0D30")]
	public GNAJKEAEOBH BJPJNCNGFOJ(Matrix4x4 PKIKNDCFAFJ)
	{
		return default(GNAJKEAEOBH);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1010", Offset = "0x5DF0010", VA = "0x185DF1010")]
	public static GNAJKEAEOBH GGPDMFLMMBC(Vector3 MIFJBHLKJIN)
	{
		return default(GNAJKEAEOBH);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF12B0", Offset = "0x5DF02B0", VA = "0x185DF12B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DF3600", Offset = "0x5DF2600", VA = "0x185DF3600", Slot = "4")]
	public void OKFPLMGFEGF(DPPPFALKJHM CBKFHCNHKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5DF30D0", Offset = "0x5DF20D0", VA = "0x185DF30D0")]
	private void IPAHALBFKHI(Dictionary<Guid, Guid> PNMNMEIDGAC, BENIBEFMJCO CMCDOKAGDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3070", Offset = "0x5DF2070", VA = "0x185DF3070")]
	private void IPAHALBFKHI(Dictionary<Guid, Guid> PNMNMEIDGAC, ODOIMLFABOL EMPCADKGNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2E20", Offset = "0x5DF1E20", VA = "0x185DF2E20")]
	private void IPAHALBFKHI(Dictionary<Guid, Guid> PNMNMEIDGAC, NKIFAPOLIAA EKNLBBIHGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public JMCPFMPNNHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class CGCOGBDHJGM : GJLFJAFDMFA
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0810", Offset = "0x5DEF810", VA = "0x185DF0810", Slot = "4")]
	public void OKFPLMGFEGF(DPPPFALKJHM CBKFHCNHKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public CGCOGBDHJGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class OJLGAMNEJEP : GJLFJAFDMFA
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9250", Offset = "0x5DF8250", VA = "0x185DF9250", Slot = "4")]
	public void OKFPLMGFEGF(DPPPFALKJHM CBKFHCNHKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public OJLGAMNEJEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class PHPCONDCFEC : GJLFJAFDMFA
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5DF93C0", Offset = "0x5DF83C0", VA = "0x185DF93C0", Slot = "4")]
	public void OKFPLMGFEGF(DPPPFALKJHM CBKFHCNHKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public PHPCONDCFEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class GOJEIAJELFP : GJLFJAFDMFA
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF16A0", Offset = "0x5DF06A0", VA = "0x185DF16A0", Slot = "4")]
	public void OKFPLMGFEGF(DPPPFALKJHM CBKFHCNHKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public GOJEIAJELFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class OIGBJKLEHKP : GJLFJAFDMFA
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF90D0", Offset = "0x5DF80D0", VA = "0x185DF90D0", Slot = "4")]
	public void OKFPLMGFEGF(DPPPFALKJHM CBKFHCNHKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public OIGBJKLEHKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class ALHMGPHIAAM : GJLFJAFDMFA
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF04E0", Offset = "0x5DEF4E0", VA = "0x185DF04E0", Slot = "4")]
	public void OKFPLMGFEGF(DPPPFALKJHM CBKFHCNHKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public ALHMGPHIAAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class FJPLGBLILNP : GJLFJAFDMFA
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0BE0", Offset = "0x5DEFBE0", VA = "0x185DF0BE0", Slot = "4")]
	public void OKFPLMGFEGF(DPPPFALKJHM CBKFHCNHKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public FJPLGBLILNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class CGEGHONHNKM : GJLFJAFDMFA
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5DF08D0", Offset = "0x5DEF8D0", VA = "0x185DF08D0", Slot = "4")]
	public void OKFPLMGFEGF(DPPPFALKJHM CBKFHCNHKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public CGEGHONHNKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class LHJDAPCMLDF : GJLFJAFDMFA
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5DF36B0", Offset = "0x5DF26B0", VA = "0x185DF36B0", Slot = "4")]
	public void OKFPLMGFEGF(DPPPFALKJHM CBKFHCNHKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public LHJDAPCMLDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class IABEFFELFDE : GJLFJAFDMFA
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5DF19B0", Offset = "0x5DF09B0", VA = "0x185DF19B0", Slot = "4")]
	public void OKFPLMGFEGF(DPPPFALKJHM CBKFHCNHKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DF06D0", Offset = "0x5DEF6D0", VA = "0x185DF06D0", Slot = "4")]
	public void OKFPLMGFEGF(DPPPFALKJHM CBKFHCNHKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DF3DD0", Offset = "0x5DF2DD0", VA = "0x185DF3DD0")]
	public static void NNPLPEBIJJC(KEBFAGOAMOE FNIHENPLJHK, Dictionary<Guid, Guid> JILIDMFOCEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3BE0", Offset = "0x5DF2BE0", VA = "0x185DF3BE0")]
	public static void GMPEDHBKPNH(KEBFAGOAMOE? FNIHENPLJHK, EMCCAHPHMJD GMCBEJJLDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3880", Offset = "0x5DF2880", VA = "0x185DF3880")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DF0AC0", Offset = "0x5DEFAC0", VA = "0x185DF0AC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<long, int> BFPILEJDCII
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1D00", Offset = "0x5DF0D00", VA = "0x185DF1D00")]
	public static JIFADKFCOLL MGFLIMBLGHO(JJGFELHFPKJ AONKGPLDMJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1B40", Offset = "0x5DF0B40", VA = "0x185DF1B40")]
	public static JIFADKFCOLL KIBGPMOELCI(PKGAFLCANHJ PCOAPGPBJAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1BB0", Offset = "0x5DF0BB0", VA = "0x185DF1BB0")]
	public static JIFADKFCOLL KLEFOABCOKN(IEnumerable<string> NGHKHOCDIFH, IDictionary<long, int> HHAKOOEOABH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2D20", Offset = "0x5DF1D20", VA = "0x185DF2D20")]
	private JIFADKFCOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2C00", Offset = "0x5DF1C00", VA = "0x185DF2C00")]
	private JIFADKFCOLL(IEnumerable<string> NGHKHOCDIFH, IDictionary<long, int> HHAKOOEOABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2190", Offset = "0x5DF1190", VA = "0x185DF2190")]
	private void NPCDKMKJBDM(JJGFELHFPKJ AONKGPLDMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2350", Offset = "0x5DF1350", VA = "0x185DF2350")]
	private void NPCDKMKJBDM(PKGAFLCANHJ PCOAPGPBJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1D70", Offset = "0x5DF0D70", VA = "0x185DF1D70")]
	private void NPCDKMKJBDM(LAHFKHFONPG? IGJDJDNFANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF28C0", Offset = "0x5DF18C0", VA = "0x185DF28C0")]
	private void NPCDKMKJBDM(MEDHHEJJIJH? BBGMDMKKHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2510", Offset = "0x5DF1510", VA = "0x185DF2510")]
	private void NPCDKMKJBDM(KEBFAGOAMOE? BPACDKOKENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1AD0", Offset = "0x5DF0AD0", VA = "0x185DF1AD0")]
	private void HMONKDBEGGF(string? CPHMKCNKEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2B20", Offset = "0x5DF1B20", VA = "0x185DF2B20")]
	private void PBCGLAAIHMD(ABGJAKPJOFK? AJAFDCIEAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2A30", Offset = "0x5DF1A30", VA = "0x185DF2A30")]
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
