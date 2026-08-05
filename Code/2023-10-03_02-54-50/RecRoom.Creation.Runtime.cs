using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
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
		[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5C66F60", Offset = "0x5C65760", VA = "0x185C66F60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78C320", Offset = "0x78AB20", VA = "0x18078C320")]
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
		[Cpp2IlInjected.Address(RVA = "0x78C360", Offset = "0x78AB60", VA = "0x18078C360")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FFFCKEHPBFL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5C62CD0", Offset = "0x5C614D0", VA = "0x185C62CD0")]
	public static bool GIGPBMNCGLP(BADMIOIDIEM IAHEAFOICCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5C62D00", Offset = "0x5C61500", VA = "0x185C62D00")]
	private static bool GIGPBMNCGLP(FEGNGEDDNKI DJKLHFOILGP, BADMIOIDIEM IAHEAFOICCC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct BPALLAKENFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly IMKCCGOFDNG BPKFHANFHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly IEnumerable<EIOKPMDGBOG> DOCLDNCHLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly IReadOnlyList<EIOKPMDGBOG> ECAJPEOPFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly IReadOnlyList<NNBOEPAMAMJ<GDPMMLDNLAH>> JLJGJPKBIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly ByteString PJLMMBKAFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly MJEILKECKHO PMJJHPCNAJJ;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5C626F0", Offset = "0x5C60EF0", VA = "0x185C626F0")]
	public BPALLAKENFO(IMKCCGOFDNG FFDDAINFBPB, IEnumerable<EIOKPMDGBOG> MPNGAKIOPMN, IReadOnlyList<EIOKPMDGBOG> LEIEJHFEGCK, IReadOnlyList<NNBOEPAMAMJ<GDPMMLDNLAH>> IAHDEMGINEC, ByteString AKEOAAEEEII, MJEILKECKHO LONNEKOKDDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface CPEDBPCKKAL
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(NKIMBAACPGK KOIMDAJNDOD, [Out] Dictionary<int, int> JFHOPIPGMMG);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(GLIPOGAFJFJ DOALGFEEIOB, LNOFGIDEFNI LBKMCCAMEOA);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class AGEAPJKMNCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly Guid AKDGFMGMKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<Guid, Guid> NACOELHGKNE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public IReadOnlyDictionary<Guid, Guid> GCELACGNNHK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x765E50", Offset = "0x764650", VA = "0x180765E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x315F130", Offset = "0x315D930", VA = "0x18315F130")]
	private AGEAPJKMNCA([In] Guid KBGJODIEJHN, Dictionary<Guid, Guid> BOBHHCKJLBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5C61FA0", Offset = "0x5C607A0", VA = "0x185C61FA0")]
	public static AGEAPJKMNCA AFNLMLEGIDI(IReadOnlyDictionary<Guid, Guid> LHGAIOOKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5C62170", Offset = "0x5C60970", VA = "0x185C62170")]
	public static AGEAPJKMNCA KFMMMGOEJAK(IEnumerable<KeyValuePair<Guid, Guid>> LHGAIOOKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5C620C0", Offset = "0x5C608C0", VA = "0x185C620C0")]
	private static Dictionary<Guid, Guid> GNHEIOJFKOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5C61FB0", Offset = "0x5C607B0", VA = "0x185C61FB0")]
	public Guid FNCLAMKMMGO([In] Guid ACBJLDAEBBN, bool PEBGPGKLHMM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5C62520", Offset = "0x5C60D20", VA = "0x185C62520")]
	public bool OIGJFDGHPDL([In] Guid LJHGKCLAIHG, [Out] Guid HGNABPLJAOF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KNNGACDBODI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool HAOKFJJANAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GHFHHMFPNJI(ByteString BGGDIKOMABC, AGEAPJKMNCA AMJPEFKNAAF, [In] PKIFHEFFKDB HFGOJEIPGIK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HEJFLECDKBN
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<ByteString> GetValidRoomCurrencies();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ByteString> GetValidRoomConsumables();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class EDHIGPCCCEE
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> OOPDBPDNJEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<Guid, Guid> NOAFBHFGGEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x760A40", Offset = "0x75F240", VA = "0x180760A40")]
	public EDHIGPCCCEE(IReadOnlyDictionary<Guid, Guid> BDEDEIJGAMM, IReadOnlyDictionary<Guid, Guid> DKBFEJJBNIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class AAKKPDMJDCI
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5C60820", Offset = "0x5C5F020", VA = "0x185C60820")]
	public static KMELOHAPEAH GNGAFKGEDFB([In] BPALLAKENFO DIDIJPNCONK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5C60A20", Offset = "0x5C5F220", VA = "0x185C60A20")]
	private static void KEKFPFDEPJA(KMELOHAPEAH BMGMLHENHJC, [In] BPALLAKENFO MPHNKLADMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5C5F530", Offset = "0x5C5DD30", VA = "0x185C5F530")]
	public static bool GMONNACGCII(KMELOHAPEAH BMGMLHENHJC, HDIOMNHDMON PDKNBLJJBGJ, [Out] EDHIGPCCCEE? BOBHHCKJLBM, [Out] string? OBDAEGBLILG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5C5F2A0", Offset = "0x5C5DAA0", VA = "0x185C5F2A0")]
	private static void CLJMIPDGCIL(KMELOHAPEAH BMGMLHENHJC, AGEAPJKMNCA? FAJOCDCHOMD, HDIOMNHDMON PDKNBLJJBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5C5EF50", Offset = "0x5C5D750", VA = "0x185C5EF50")]
	private static void BGPBGCGKJCA(KMELOHAPEAH BMGMLHENHJC, HDIOMNHDMON PDKNBLJJBGJ, IReadOnlyCollection<ByteString>? KLOOIGLJIJL, IReadOnlyCollection<ByteString>? DGKIPALMCBA, IReadOnlyCollection<ByteString>? KGBOMJNMBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5C61310", Offset = "0x5C5FB10", VA = "0x185C61310")]
	private static bool MKCNDCDKEJM(KMELOHAPEAH BMGMLHENHJC, GLIPOGAFJFJ DOALGFEEIOB, HDIOMNHDMON PDKNBLJJBGJ, [Out] string OBDAEGBLILG, [Out] Dictionary<int, int> JFHOPIPGMMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5C5EFC0", Offset = "0x5C5D7C0", VA = "0x185C5EFC0")]
	private static Dictionary<Guid, FEGNGEDDNKI> BKNCHIKPIMA(KMELOHAPEAH BMGMLHENHJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5C60990", Offset = "0x5C5F190", VA = "0x185C60990")]
	private static void HLBFHKDHDBP(bool OCPLIKPJDLN, EIOKPMDGBOG ABFGFJDAMKM, Dictionary<Guid, Guid> IJHNBCLCEGH, AGEAPJKMNCA CDNMHCAEDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5C61080", Offset = "0x5C5F880", VA = "0x185C61080")]
	private static void MANHGKCPJHE(EIOKPMDGBOG ABFGFJDAMKM, Guid COHHIBKOJCE, LCDNEACJCLN? KGFAHDDHHOH, Dictionary<Guid, FEGNGEDDNKI> FNDDCLLNBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5C619B0", Offset = "0x5C601B0", VA = "0x185C619B0")]
	private static void PGCBOPIMJEI(IEnumerable<EIOKPMDGBOG> IOIOCBBBIKF, IReadOnlyCollection<ByteString> KLOOIGLJIJL, IReadOnlyCollection<ByteString> DGKIPALMCBA, IReadOnlyCollection<ByteString> KGBOMJNMBCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct HDIOMNHDMON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public bool OCPLIKPJDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public MJEILKECKHO LONNEKOKDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public LCDNEACJCLN? KGFAHDDHHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public LCDNEACJCLN? ANKEOFNKCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public IMKCCGOFDNG MJKKFDHBIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public HEJFLECDKBN GABCPBDLACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public CPEDBPCKKAL EAKGGJAPNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public KNNGACDBODI OLDIDGOLHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NNBOEPAMAMJ<JIEHCMLPDJC> HBIFCFDKCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EHEPAIINMOL JFFPFEAMMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public List<EIOKPMDGBOG> AIGBLJCGBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Dictionary<string, object> LNALNMPGDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public CJOHGDKLIIN BFPEDGCABLJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool NNBALKJHKLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5C64260", Offset = "0x5C62A60", VA = "0x185C64260")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct LCDNEACJCLN
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private const float LJFOMJFOPFN = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public Vector3 OBAACBLACLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public Quaternion AHLHKGGFBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float CDLIHEJMBGO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Matrix4x4 HICMCNCHFJN
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5C66850", Offset = "0x5C65050", VA = "0x185C66850")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public PKIFHEFFKDB KPOAOAPDGCF
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5C66BE0", Offset = "0x5C653E0", VA = "0x185C66BE0")]
		get
		{
			return default(PKIFHEFFKDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x870C20", Offset = "0x86F420", VA = "0x180870C20")]
	public LCDNEACJCLN(Vector3 OBAACBLACLC, Quaternion AHLHKGGFBGH, float CDLIHEJMBGO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5C66960", Offset = "0x5C65160", VA = "0x185C66960")]
	public static LCDNEACJCLN LFHEOLCIIIO(LCDNEACJCLN KLGMOMIJPLM, LCDNEACJCLN NIKHAKBLMIA)
	{
		return default(LCDNEACJCLN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5C66610", Offset = "0x5C64E10", VA = "0x185C66610")]
	public static LCDNEACJCLN DAOGIJOJDNF((Vector3, Quaternion, float) KOIMDAJNDOD)
	{
		return default(LCDNEACJCLN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5C664B0", Offset = "0x5C64CB0", VA = "0x185C664B0")]
	public static LCDNEACJCLN DAOGIJOJDNF(Matrix4x4 BKACFOMALKH)
	{
		return default(LCDNEACJCLN);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5C66630", Offset = "0x5C64E30", VA = "0x185C66630")]
	public LCDNEACJCLN DNMMOKCIJME(Matrix4x4 KHFCFAPNPDN)
	{
		return default(LCDNEACJCLN);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5C66C20", Offset = "0x5C65420", VA = "0x185C66C20")]
	public static LCDNEACJCLN PBKLJGGCPOF(Vector3 OBAACBLACLC)
	{
		return default(LCDNEACJCLN);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5C66420", Offset = "0x5C64C20", VA = "0x185C66420")]
	public readonly CBKKJLECIDO DAGIIEBDGLM()
	{
		return default(CBKKJLECIDO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class ELLCPMJDPGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5C62C40", Offset = "0x5C61440", VA = "0x185C62C40")]
	public static LCDNEACJCLN PMCKDFPMOAK([In] this CBKKJLECIDO CLEGCKJMIEA)
	{
		return default(LCDNEACJCLN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class JAELGIOPOPB : GHHDAGFFFNN
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5C663A0", Offset = "0x5C64BA0", VA = "0x185C663A0", Slot = "4")]
	public void IOCMBLBIGFL(IHMPABCDLBM HBMNKHANFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5C65AE0", Offset = "0x5C642E0", VA = "0x185C65AE0")]
	private void GHIKIPCAILK(Dictionary<Guid, Guid> AMJCDNFOHPD, DBIKEEGJAPF MJGPHODFKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5C66340", Offset = "0x5C64B40", VA = "0x185C66340")]
	private void GHIKIPCAILK(Dictionary<Guid, Guid> AMJCDNFOHPD, PJKODBCELHN CFGBNAADMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5C660C0", Offset = "0x5C648C0", VA = "0x185C660C0")]
	private void GHIKIPCAILK(Dictionary<Guid, Guid> AMJCDNFOHPD, FMLJFKOHDMN BAGPFAJPEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public JAELGIOPOPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class MKJGDNIFMKB : GHHDAGFFFNN
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5C66EC0", Offset = "0x5C656C0", VA = "0x185C66EC0", Slot = "4")]
	public void IOCMBLBIGFL(IHMPABCDLBM HBMNKHANFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public MKJGDNIFMKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class ALNHGECGBBM : GHHDAGFFFNN
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5C62590", Offset = "0x5C60D90", VA = "0x185C62590", Slot = "4")]
	public void IOCMBLBIGFL(IHMPABCDLBM HBMNKHANFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public ALNHGECGBBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class CBLMIOEAJEN : GHHDAGFFFNN
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5C62770", Offset = "0x5C60F70", VA = "0x185C62770", Slot = "4")]
	public void IOCMBLBIGFL(IHMPABCDLBM HBMNKHANFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public CBLMIOEAJEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class HDDAKKFCFLH : GHHDAGFFFNN
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5C64040", Offset = "0x5C62840", VA = "0x185C64040", Slot = "4")]
	public void IOCMBLBIGFL(IHMPABCDLBM HBMNKHANFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public HDDAKKFCFLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class AEKDBMGLHOC : GHHDAGFFFNN
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5C61E60", Offset = "0x5C60660", VA = "0x185C61E60", Slot = "4")]
	public void IOCMBLBIGFL(IHMPABCDLBM HBMNKHANFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public AEKDBMGLHOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class INFFOCBJDAD : GHHDAGFFFNN
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5C65850", Offset = "0x5C64050", VA = "0x185C65850", Slot = "4")]
	public void IOCMBLBIGFL(IHMPABCDLBM HBMNKHANFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public INFFOCBJDAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class JADJNOPGOAL : GHHDAGFFFNN
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5C659F0", Offset = "0x5C641F0", VA = "0x185C659F0", Slot = "4")]
	public void IOCMBLBIGFL(IHMPABCDLBM HBMNKHANFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public JADJNOPGOAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class CJJKNGAJHPI : GHHDAGFFFNN
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5C628C0", Offset = "0x5C610C0", VA = "0x185C628C0", Slot = "4")]
	public void IOCMBLBIGFL(IHMPABCDLBM HBMNKHANFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public CJJKNGAJHPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class DPJMDLNKICD : GHHDAGFFFNN
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5C62A80", Offset = "0x5C61280", VA = "0x185C62A80", Slot = "4")]
	public void IOCMBLBIGFL(IHMPABCDLBM HBMNKHANFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public DPJMDLNKICD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class LLEBDDLGIEI : GHHDAGFFFNN
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5C66C90", Offset = "0x5C65490", VA = "0x185C66C90", Slot = "4")]
	public void IOCMBLBIGFL(IHMPABCDLBM HBMNKHANFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public LLEBDDLGIEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class MFLMIAHEJKM : GHHDAGFFFNN
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static readonly System.Random NEHBOEKDLGI;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5C66D90", Offset = "0x5C65590", VA = "0x185C66D90", Slot = "4")]
	public void IOCMBLBIGFL(IHMPABCDLBM HBMNKHANFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public MFLMIAHEJKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct BADMIOIDIEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public GLIPOGAFJFJ OJAHFIICKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public IMKJLDLHDOK IIELFMPMPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Dictionary<int, int> PJCOAGODDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Dictionary<Guid, Guid> DGGJFDPLDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public CJOHGDKLIIN BFPEDGCABLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public bool PDKNDBNHLAC;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface GHHDAGFFFNN
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IOCMBLBIGFL(IHMPABCDLBM HBMNKHANFEK);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GPKHEMHADHI
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly GHHDAGFFFNN[] NBDPFPEKKCG;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5C630B0", Offset = "0x5C618B0", VA = "0x185C630B0")]
	public static void AOCNLDBBBEH(EIOKPMDGBOG KOIMDAJNDOD, Dictionary<Guid, Guid> HBCPGIGFMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5C63710", Offset = "0x5C61F10", VA = "0x185C63710")]
	public static void MCDHPAFMKCO(EIOKPMDGBOG? KOIMDAJNDOD, AGEAPJKMNCA CDNMHCAEDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5C63340", Offset = "0x5C61B40", VA = "0x185C63340")]
	public static void GIGPBMNCGLP(IHMPABCDLBM HBMNKHANFEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct IHMPABCDLBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public GLIPOGAFJFJ GPCGOKFPFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public EIOKPMDGBOG ABFGFJDAMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Dictionary<int, int> PJCOAGODDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Dictionary<Guid, Guid> DGGJFDPLDJG;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5C657A0", Offset = "0x5C63FA0", VA = "0x185C657A0")]
	public Guid MLEFLFDOOGJ(Guid ACBJLDAEBBN)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface CJOHGDKLIIN
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int JAKKPKNHHPG, [Out] Guid OEKDNCCNLLC);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class HOAPOLNGCIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly HashSet<string> BNAGFFKBELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<long, int> FCFPILOBNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly HashSet<Guid> LHAAAAMIDPB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyCollection<string> CAEAALPDHFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyDictionary<long, int> MCNCFFDPBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5C65460", Offset = "0x5C63C60", VA = "0x185C65460")]
	public static HOAPOLNGCIK MMMDAKCLKID(NHKJOGGKLGM EKBIDHDINDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5C654D0", Offset = "0x5C63CD0", VA = "0x185C654D0")]
	public static HOAPOLNGCIK OLAKNNENBPD(KMELOHAPEAH KPFJEBAKEOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5C642B0", Offset = "0x5C62AB0", VA = "0x185C642B0")]
	public static HOAPOLNGCIK GGBFIHMHKDD(IEnumerable<string> BNAGFFKBELC, IDictionary<long, int> KJBBMECFILH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5C65680", Offset = "0x5C63E80", VA = "0x185C65680")]
	private HOAPOLNGCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5C65540", Offset = "0x5C63D40", VA = "0x185C65540")]
	private HOAPOLNGCIK(IEnumerable<string> BNAGFFKBELC, IDictionary<long, int> KJBBMECFILH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5C64EA0", Offset = "0x5C636A0", VA = "0x185C64EA0")]
	private void HBAFNHNOGHH(NHKJOGGKLGM EKBIDHDINDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5C650A0", Offset = "0x5C638A0", VA = "0x185C650A0")]
	private void HBAFNHNOGHH(KMELOHAPEAH KPFJEBAKEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5C64610", Offset = "0x5C62E10", VA = "0x185C64610")]
	private void HBAFNHNOGHH(KEKELCOKBLB? KLOAHFNCDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5C644A0", Offset = "0x5C62CA0", VA = "0x185C644A0")]
	private void HBAFNHNOGHH(IMPOBGEBMHB? LBKDEGBJKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5C64AB0", Offset = "0x5C632B0", VA = "0x185C64AB0")]
	private void HBAFNHNOGHH(EIOKPMDGBOG? ABFGFJDAMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5C64430", Offset = "0x5C62C30", VA = "0x185C64430")]
	private void GNCPIKGMPNN(string? NKBIHFHHEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5C65290", Offset = "0x5C63A90", VA = "0x185C65290")]
	private void LOLBGJOLFOA(OGCIKENCAGE? PLJIMBLNHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5C65370", Offset = "0x5C63B70", VA = "0x185C65370")]
	private void LOLBGJOLFOA(HHLDPPCGOJG? PLJIMBLNHAA)
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
