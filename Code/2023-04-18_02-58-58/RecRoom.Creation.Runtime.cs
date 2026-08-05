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
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D66680", Offset = "0x5D65880", VA = "0x185D66680")]
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
		[Cpp2IlInjected.Address(RVA = "0x701910", Offset = "0x700B10", VA = "0x180701910")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CADJNHPOJDB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5D5DD90", Offset = "0x5D5CF90", VA = "0x185D5DD90")]
	public static bool EJJFOLOLABP(NGMHLFPONKN IKNBIFLGNLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D5DDD0", Offset = "0x5D5CFD0", VA = "0x185D5DDD0")]
	private static bool EJJFOLOLABP(LJEJHGJFNNO KFECLMFEPBA, ref NGMHLFPONKN IKNBIFLGNLO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct CJJOBNGMBOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public List<OELBDAKHAFC> DLAEALAIMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public IEnumerable<EKIIIJIOBCC> FBDEOBLEJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public LEPCMENIFGP PFJFCKNPALH;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NGBABCGHAAA
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(MJFHAAEBBJF PCPEJHIMHJJ, out Dictionary<int, int> DOPIHIJLOLC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(FBLAHKFEHNM LPHOOGCBMKE, NDMKJLIFAHM JKIOMNICANF);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GLJHIMBOIAI
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
public sealed class JLLFDOEDIEA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<Guid, Guid> JCHKBHFLFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<Guid, Guid> NJKDJOKCAEJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<Guid, Guid> CODPEIDNIBI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7086F0", Offset = "0x7078F0", VA = "0x1807086F0")]
	public JLLFDOEDIEA(Dictionary<Guid, Guid> JCHKBHFLFAD, Dictionary<Guid, Guid> NJKDJOKCAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D60060", Offset = "0x5D5F260", VA = "0x185D60060", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class MHDCNGJKFGE
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class KEIMOBIBAMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly HashSet<EKIIIJIOBCC> MBGEDCMIMJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly HashSet<MIEKHIHLDEK> BHIPIFOCFPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly List<BNOPDNILAFA> POAIDIMNCCJ;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5D61410", Offset = "0x5D60610", VA = "0x185D61410")]
		public KEIMOBIBAMI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class KOAIFFPJJMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public MIEKHIHLDEK destinationGraph;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public KOAIFFPJJMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5D61510", Offset = "0x5D60710", VA = "0x185D61510")]
		internal bool <InitializeCircuitsV2Remapping>b__0(JHHIIKFFNKM n)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class LBIFIDKBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int mpif;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public LBIFIDKBFPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5D61560", Offset = "0x5D60760", VA = "0x185D61560")]
		internal void <InitializeCircuitsV2Remapping>b__1(JHHIIKFFNKM n)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5D65970", Offset = "0x5D64B70", VA = "0x185D65970")]
	public static GAMIBKOFAAE LCOPHJILDPB(CJJOBNGMBOD LDNLOOAFDFB, out PKAEKEMHEJH AFNONIDHKJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D660D0", Offset = "0x5D652D0", VA = "0x185D660D0")]
	private static void OBFNFNCNFJD(GAMIBKOFAAE KDOHOHMMADB, KEIMOBIBAMI KBKIKGGACDE, out PKAEKEMHEJH AFNONIDHKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5D62FD0", Offset = "0x5D621D0", VA = "0x185D62FD0")]
	private static void CGHJMJOIEEK(OELBDAKHAFC KLHLCCMDIGO, KEIMOBIBAMI KBKIKGGACDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D661D0", Offset = "0x5D653D0", VA = "0x185D661D0")]
	private static void PDGBJPAOLHG(GAMIBKOFAAE KDOHOHMMADB, KEIMOBIBAMI KBKIKGGACDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D653D0", Offset = "0x5D645D0", VA = "0x185D653D0")]
	private static void JFEINIDEFAF(ref CJJOBNGMBOD EMNOJKANKMF, KEIMOBIBAMI KBKIKGGACDE, OELBDAKHAFC KLHLCCMDIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D63B40", Offset = "0x5D62D40", VA = "0x185D63B40")]
	public static bool EKKMNDJKIJH(GAMIBKOFAAE KDOHOHMMADB, PACFGGGDHIJ EKMNHHPJPHC, out JLLFDOEDIEA? FBNKHMEAJKK, out string? NLJOHEKGNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D64300", Offset = "0x5D63500", VA = "0x185D64300")]
	private static void FAECGJMPPKO(GAMIBKOFAAE KDOHOHMMADB, ref PACFGGGDHIJ EKMNHHPJPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5D65690", Offset = "0x5D64890", VA = "0x185D65690")]
	public static Dictionary<Guid, Guid> JGHBMFKDFCJ(IEnumerable<OELBDAKHAFC> EJPGIJEBFHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5D65FA0", Offset = "0x5D651A0", VA = "0x185D65FA0")]
	private static void LPGGPKAKBBC(GAMIBKOFAAE KDOHOHMMADB, ref PACFGGGDHIJ EKMNHHPJPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5D630F0", Offset = "0x5D622F0", VA = "0x185D630F0")]
	private static bool CHJJKGMJBLN(GAMIBKOFAAE KDOHOHMMADB, FBLAHKFEHNM LPHOOGCBMKE, ref PACFGGGDHIJ EKMNHHPJPHC, out string NLJOHEKGNDH, out Dictionary<int, int> DOPIHIJLOLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5D646C0", Offset = "0x5D638C0", VA = "0x185D646C0")]
	private static Dictionary<Guid, LJEJHGJFNNO> IJGFBHMCNOM(GAMIBKOFAAE KDOHOHMMADB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D64930", Offset = "0x5D63B30", VA = "0x185D64930")]
	private static bool IKFLCAKNIMI(GAMIBKOFAAE KDOHOHMMADB, ref PACFGGGDHIJ EKMNHHPJPHC, out string? NLJOHEKGNDH, out JNCJEOMBGGA? PPBEINIAAJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5D62900", Offset = "0x5D61B00", VA = "0x185D62900")]
	private static void BDPPHBJEKBE(bool KGNBOIDJCLL, OELBDAKHAFC FCJBDJOMIHI, Dictionary<Guid, Guid> EMEPBFKFHGJ, JNCJEOMBGGA NILMKHJFOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5D63710", Offset = "0x5D62910", VA = "0x185D63710")]
	private static void DOPBMMJFLGF(bool KGNBOIDJCLL, OELBDAKHAFC FCJBDJOMIHI, JNCJEOMBGGA PPBEINIAAJD, Guid OLNCKNNJIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D64420", Offset = "0x5D63620", VA = "0x185D64420")]
	private static void IEOGGEFNBKO(OELBDAKHAFC FCJBDJOMIHI, Guid AIDOKPAKFPF, JFOADMEPNEL? JCAGIGMLOED, Dictionary<Guid, LJEJHGJFNNO> OEFOABMHOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5D65FE0", Offset = "0x5D651E0", VA = "0x185D65FE0")]
	private static void MJKNELOGLMM(OELBDAKHAFC FCJBDJOMIHI, Dictionary<Guid, Guid> EMEPBFKFHGJ, Dictionary<int, int> NLNOONGLGBB, FBLAHKFEHNM FBLMDCJAEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D62990", Offset = "0x5D61B90", VA = "0x185D62990")]
	public static void CFLACFIIBOA(RepeatedField<OELBDAKHAFC> AJDFPFGECMK, FIFEEBEPCAP BJAFAEFDGAE, IEnumerable<ByteString> DDGMDMPKOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5D61E10", Offset = "0x5D61010", VA = "0x185D61E10")]
	private static void AFLGNEFDNAH(RepeatedField<OELBDAKHAFC> AJDFPFGECMK, IMPBENOHLHA HKLLNODPHCJ, GLJHIMBOIAI DHIEJMGHAPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct PACFGGGDHIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool KGNBOIDJCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public bool PGJCEMBIKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public JFOADMEPNEL? JCAGIGMLOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public JFOADMEPNEL? MPFLBNKIOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public IHIGKPLCENK LJLBGKJBPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public GLJHIMBOIAI DHIEJMGHAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NGBABCGHAAA NKDFIAOKIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public Guid OLNCKNNJIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public LEPCMENIFGP PFJFCKNPALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public List<OELBDAKHAFC> FJINHFNOCIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public Dictionary<string, object> PJHHIDJMLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public KKFALCDBDNA MPKOPAEDMDI;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct JFOADMEPNEL
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private const float OIHNCOEAAPG = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Vector3 INLGLHIPOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Quaternion HEGBBJCMANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float JDFDFBKKBPO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Matrix4x4 CFGLMHNMBII
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5D5FA50", Offset = "0x5D5EC50", VA = "0x185D5FA50")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xD94330", Offset = "0xD93530", VA = "0x180D94330")]
	public JFOADMEPNEL(Vector3 INLGLHIPOMC, Quaternion HEGBBJCMANH, float JDFDFBKKBPO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D5FE00", Offset = "0x5D5F000", VA = "0x185D5FE00")]
	public JFOADMEPNEL(LIELPGHDMBP NNKHBBALLOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D5FED0", Offset = "0x5D5F0D0", VA = "0x185D5FED0")]
	private JFOADMEPNEL(EGCHDEINBLO EHKKIPFJKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D5FA20", Offset = "0x5D5EC20", VA = "0x185D5FA20")]
	public static JFOADMEPNEL IMGMFMNMMAH(EKIIIJIOBCC OFHHMJHBKMD)
	{
		return default(JFOADMEPNEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D5F780", Offset = "0x5D5E980", VA = "0x185D5F780")]
	public static JFOADMEPNEL CFAGDEOFNII(JFOADMEPNEL HHFDFFDPCGO, JFOADMEPNEL FMPGLLKLHPF)
	{
		return default(JFOADMEPNEL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5D5F8D0", Offset = "0x5D5EAD0", VA = "0x185D5F8D0")]
	public static JFOADMEPNEL GJGPFJHFLAE((Vector3, Quaternion, float) PCPEJHIMHJJ)
	{
		return default(JFOADMEPNEL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5D5F920", Offset = "0x5D5EB20", VA = "0x185D5F920")]
	public static JFOADMEPNEL GJGPFJHFLAE(Matrix4x4 IEANDANGBEO)
	{
		return default(JFOADMEPNEL);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5D5F5F0", Offset = "0x5D5E7F0", VA = "0x185D5F5F0")]
	public JFOADMEPNEL BBMJPBDLEBF(Matrix4x4 FGNGGLFNLIP)
	{
		return default(JFOADMEPNEL);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5D5FB50", Offset = "0x5D5ED50", VA = "0x185D5FB50")]
	public static JFOADMEPNEL MDFHLANAFKL(Vector3 INLGLHIPOMC)
	{
		return default(JFOADMEPNEL);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5D5FBA0", Offset = "0x5D5EDA0", VA = "0x185D5FBA0")]
	[CompilerGenerated]
	internal static JFOADMEPNEL MNBNPONNAIB(EKIIIJIOBCC KNBPIEINLIG)
	{
		return default(JFOADMEPNEL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class LOHMAPIOCOK : KKIIGJDIFOK
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5D61D60", Offset = "0x5D60F60", VA = "0x185D61D60", Slot = "4")]
	public void NONPMMJIKON(JGMACLEIPDI AGJBNNJCOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5D615E0", Offset = "0x5D607E0", VA = "0x185D615E0")]
	private void CHBIABEPJBN(Dictionary<Guid, Guid> PAFCBELKMAG, IMFIBJPNBHM IJPJHBPHBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5D61580", Offset = "0x5D60780", VA = "0x185D61580")]
	private void CHBIABEPJBN(Dictionary<Guid, Guid> PAFCBELKMAG, BBMJAJNMODG PGMKAJPJDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5D61B10", Offset = "0x5D60D10", VA = "0x185D61B10")]
	private void CHBIABEPJBN(Dictionary<Guid, Guid> PAFCBELKMAG, JCEGBNFAJGC JKCEKOKPPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public LOHMAPIOCOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class PIHGEAMILOP : KKIIGJDIFOK
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5D668E0", Offset = "0x5D65AE0", VA = "0x185D668E0", Slot = "4")]
	public void NONPMMJIKON(JGMACLEIPDI AGJBNNJCOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public PIHGEAMILOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class BJPFONGDPEH : KKIIGJDIFOK
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5D5DC20", Offset = "0x5D5CE20", VA = "0x185D5DC20", Slot = "4")]
	public void NONPMMJIKON(JGMACLEIPDI AGJBNNJCOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public BJPFONGDPEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class IHAJIDNKJPP : KKIIGJDIFOK
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5D5F4A0", Offset = "0x5D5E6A0", VA = "0x185D5F4A0", Slot = "4")]
	public void NONPMMJIKON(JGMACLEIPDI AGJBNNJCOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public IHAJIDNKJPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class MPMGBEIFCGG : KKIIGJDIFOK
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5D66470", Offset = "0x5D65670", VA = "0x185D66470", Slot = "4")]
	public void NONPMMJIKON(JGMACLEIPDI AGJBNNJCOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public MPMGBEIFCGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class EKBDINJIOAD : KKIIGJDIFOK
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5D5E270", Offset = "0x5D5D470", VA = "0x185D5E270", Slot = "4")]
	public void NONPMMJIKON(JGMACLEIPDI AGJBNNJCOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public EKBDINJIOAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class GAPOKLMIFPO : KKIIGJDIFOK
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5D5E3F0", Offset = "0x5D5D5F0", VA = "0x185D5E3F0", Slot = "4")]
	public void NONPMMJIKON(JGMACLEIPDI AGJBNNJCOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public GAPOKLMIFPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class EHJAAODOICJ : KKIIGJDIFOK
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5D5E150", Offset = "0x5D5D350", VA = "0x185D5E150", Slot = "4")]
	public void NONPMMJIKON(JGMACLEIPDI AGJBNNJCOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public EHJAAODOICJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class PBFCFOCNCIO : KKIIGJDIFOK
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5D66710", Offset = "0x5D65910", VA = "0x185D66710", Slot = "4")]
	public void NONPMMJIKON(JGMACLEIPDI AGJBNNJCOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public PBFCFOCNCIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class AMHKPGNDKKO : KKIIGJDIFOK
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5D5D910", Offset = "0x5D5CB10", VA = "0x185D5D910", Slot = "4")]
	public void NONPMMJIKON(JGMACLEIPDI AGJBNNJCOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public AMHKPGNDKKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class HGPNNFDLLLH : KKIIGJDIFOK
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5D5E5E0", Offset = "0x5D5D7E0", VA = "0x185D5E5E0", Slot = "4")]
	public void NONPMMJIKON(JGMACLEIPDI AGJBNNJCOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public HGPNNFDLLLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class BFKEFDABIAI : KKIIGJDIFOK
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly System.Random KLBOKLMHMMB;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5D5DAE0", Offset = "0x5D5CCE0", VA = "0x185D5DAE0", Slot = "4")]
	public void NONPMMJIKON(JGMACLEIPDI AGJBNNJCOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public BFKEFDABIAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct NGMHLFPONKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public FBLAHKFEHNM EOGFAFNNICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public PBPIAFHAOOI GPELNGFDCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Dictionary<int, int> NLNOONGLGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Dictionary<Guid, Guid> FANBGOENJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public KKFALCDBDNA MPKOPAEDMDI;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface KKIIGJDIFOK
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NONPMMJIKON(JGMACLEIPDI AGJBNNJCOOE);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IDLPAGGPPHE
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly KKIIGJDIFOK[] PAIINDIIGAH;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5D5EC50", Offset = "0x5D5DE50", VA = "0x185D5EC50")]
	public static void NMDGPDDFLGI(OELBDAKHAFC PCPEJHIMHJJ, Dictionary<Guid, Guid> NEFOKMACGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5D5E700", Offset = "0x5D5D900", VA = "0x185D5E700")]
	public static void BHHCMPDPMOL(OELBDAKHAFC? PCPEJHIMHJJ, JNCJEOMBGGA NILMKHJFOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5D5E8F0", Offset = "0x5D5DAF0", VA = "0x185D5E8F0")]
	public static void EJJFOLOLABP(JGMACLEIPDI AGJBNNJCOOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct JGMACLEIPDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public FBLAHKFEHNM LJFNCCMLIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public OELBDAKHAFC FCJBDJOMIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Dictionary<int, int> NLNOONGLGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Dictionary<Guid, Guid> FANBGOENJNL;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5D5FF90", Offset = "0x5D5F190", VA = "0x185D5FF90")]
	public Guid NLHFCCHGMLG(Guid JMIFIJDBMNM)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface KKFALCDBDNA
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int CONBHIDACJO, out Guid KDDBKHKBKKK);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class KADDOPFPEKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<string> OONOLGBNOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<long, int> OAACANNJCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<Guid> AABNMIDNFEL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyCollection<string> HPNKOOAPIBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<long, int> ECIJFAIMAEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5D60F50", Offset = "0x5D60150", VA = "0x185D60F50")]
	public static KADDOPFPEKJ CHAOEDKBBEC(KHMOHFAFGBI KGMPBFBAMCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5D60FC0", Offset = "0x5D601C0", VA = "0x185D60FC0")]
	public static KADDOPFPEKJ IBGFEBBIKIF(GAMIBKOFAAE GALPHDPIFCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5D61030", Offset = "0x5D60230", VA = "0x185D61030")]
	public static KADDOPFPEKJ IHOOCCFOMHD(IEnumerable<string> OONOLGBNOJC, IDictionary<long, int> GOCFMNBLFLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5D611F0", Offset = "0x5D603F0", VA = "0x185D611F0")]
	private KADDOPFPEKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5D612F0", Offset = "0x5D604F0", VA = "0x185D612F0")]
	private KADDOPFPEKJ(IEnumerable<string> OONOLGBNOJC, IDictionary<long, int> GOCFMNBLFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D60470", Offset = "0x5D5F670", VA = "0x185D60470")]
	private void ANKEEHMDBOL(KHMOHFAFGBI KGMPBFBAMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5D607A0", Offset = "0x5D5F9A0", VA = "0x185D607A0")]
	private void ANKEEHMDBOL(GAMIBKOFAAE GALPHDPIFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D60960", Offset = "0x5D5FB60", VA = "0x185D60960")]
	private void ANKEEHMDBOL(FIFEEBEPCAP? KPDGHDGLMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5D60630", Offset = "0x5D5F830", VA = "0x185D60630")]
	private void ANKEEHMDBOL(JHHIIKFFNKM? KNBPIEINLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5D600C0", Offset = "0x5D5F2C0", VA = "0x185D600C0")]
	private void ANKEEHMDBOL(OELBDAKHAFC? FCJBDJOMIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5D61180", Offset = "0x5D60380", VA = "0x185D61180")]
	private void JPLFMOBCELB(string? NPKOMACBEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5D60E70", Offset = "0x5D60070", VA = "0x185D60E70")]
	private void BBBHPKEDGHM(HNBLIPMOKNH? FHBALNEFKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5D60D80", Offset = "0x5D5FF80", VA = "0x185D60D80")]
	private void BBBHPKEDGHM(JCGJDAOMHCI? FHBALNEFKEN)
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
