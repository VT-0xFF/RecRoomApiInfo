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
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CEFD30", Offset = "0x5CEEF30", VA = "0x185CEFD30")]
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
		[Cpp2IlInjected.Address(RVA = "0x9116C0", Offset = "0x9108C0", VA = "0x1809116C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PILCLKMPGJP
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFDC0", Offset = "0x5CEEFC0", VA = "0x185CEFDC0")]
	public static bool OEOBMFFELGM(KACCCCGJOIM HIDBCOHGCJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFE00", Offset = "0x5CEF000", VA = "0x185CEFE00")]
	private static bool OEOBMFFELGM(MMMPFILOJAL CHHHJJOHKAH, ref KACCCCGJOIM HIDBCOHGCJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct LKOFMGPOIKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public List<POHCLHIPEBO> AFHMEOLDECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public IEnumerable<MJNAKHNHEBG> NJNKPCMHEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public DOGNPGJNMOD LGHHKHMLGEF;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface PGPGNJBIIPB
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(BEIOIKKEGOL ONIBEFDCPGD, out Dictionary<int, int> KBFFBLJJBFJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(CJHBLOEDPCM CANGNMEKFPB, ENMJKCMCAOI BLFOMFBEFAI);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HLMHMCICHMA
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
public sealed class NJHOJMNKMBL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<Guid, Guid> CJAKCMFDAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<Guid, Guid> EKGOCEIADNM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<Guid, Guid> IEOECGMEIPL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6C76E0", Offset = "0x6C68E0", VA = "0x1806C76E0")]
	public NJHOJMNKMBL(Dictionary<Guid, Guid> CJAKCMFDAAH, Dictionary<Guid, Guid> EKGOCEIADNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEDF0", Offset = "0x5CEDFF0", VA = "0x185CEEDF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class GMMANPIJBNI
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class HBHKIBCOKPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly HashSet<MJNAKHNHEBG> COLLDDGEFAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly HashSet<HKLBAEIIHFE> OKHJLLGHMBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly List<OCEEJGCAHHE> DCHLOJPHCHM;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5CED300", Offset = "0x5CEC500", VA = "0x185CED300")]
		public HBHKIBCOKPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class JBMIEFJCIMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public HKLBAEIIHFE destinationGraph;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public JBMIEFJCIMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE970", Offset = "0x5CEDB70", VA = "0x185CEE970")]
		internal bool <InitializeCircuitsV2Remapping>b__0(HPAHIOIDLBF n)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class MGAMIPLAGDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int mpif;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public MGAMIPLAGDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5CEED10", Offset = "0x5CEDF10", VA = "0x185CEED10")]
		internal void <InitializeCircuitsV2Remapping>b__1(HPAHIOIDLBF n)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC510", Offset = "0x5CEB710", VA = "0x185CEC510")]
	public static HAPKOIDDDJL PAHLILINDDF(LKOFMGPOIKD EGFFIIDPPHB, out DFJKEGMAPPD GLIEKCHAGAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5CEAF40", Offset = "0x5CEA140", VA = "0x185CEAF40")]
	private static void ICEHHAKHOHI(HAPKOIDDDJL EIPGFAKPKCJ, HBHKIBCOKPM GHMPBOLKLJB, out DFJKEGMAPPD GLIEKCHAGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8CA0", Offset = "0x5CE7EA0", VA = "0x185CE8CA0")]
	private static void AKKKABGMOJN(POHCLHIPEBO ACBFPAHPLJH, HBHKIBCOKPM GHMPBOLKLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9940", Offset = "0x5CE8B40", VA = "0x185CE9940")]
	private static void DIHOJPNFKAF(HAPKOIDDDJL EIPGFAKPKCJ, HBHKIBCOKPM GHMPBOLKLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC210", Offset = "0x5CEB410", VA = "0x185CEC210")]
	private static void NGHOAMPEINK(ref LKOFMGPOIKD NBHIHMOBFBF, HBHKIBCOKPM GHMPBOLKLJB, POHCLHIPEBO ACBFPAHPLJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5CECB40", Offset = "0x5CEBD40", VA = "0x185CECB40")]
	public static bool PLGNGJFMALH(HAPKOIDDDJL EIPGFAKPKCJ, BGKJFMHOMAI HFDBHCCECEM, out NJHOJMNKMBL? LLMJPPDKAGC, out string? GNLLAOFLEDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5CEABB0", Offset = "0x5CE9DB0", VA = "0x185CEABB0")]
	private static void HGKFMFPHLIC(HAPKOIDDDJL EIPGFAKPKCJ, ref BGKJFMHOMAI HFDBHCCECEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA4A0", Offset = "0x5CE96A0", VA = "0x185CEA4A0")]
	public static Dictionary<Guid, Guid> FDLMNIAANDB(IEnumerable<POHCLHIPEBO> CCAHLKEAJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC4D0", Offset = "0x5CEB6D0", VA = "0x185CEC4D0")]
	private static void ODHHFOAEOFA(HAPKOIDDDJL EIPGFAKPKCJ, ref BGKJFMHOMAI HFDBHCCECEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9BE0", Offset = "0x5CE8DE0", VA = "0x185CE9BE0")]
	private static bool DOMEMLEHGBD(HAPKOIDDDJL EIPGFAKPKCJ, CJHBLOEDPCM CANGNMEKFPB, ref BGKJFMHOMAI HFDBHCCECEM, out string GNLLAOFLEDB, out Dictionary<int, int> KBFFBLJJBFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5CEACD0", Offset = "0x5CE9ED0", VA = "0x185CEACD0")]
	private static Dictionary<Guid, MMMPFILOJAL> HGOLEAPPHIK(HAPKOIDDDJL EIPGFAKPKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB770", Offset = "0x5CEA970", VA = "0x185CEB770")]
	private static bool MDEBJGJHDAD(HAPKOIDDDJL EIPGFAKPKCJ, ref BGKJFMHOMAI HFDBHCCECEM, out string? GNLLAOFLEDB, out PIMAHCIMDNM? FNPKGOFCAIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CE98B0", Offset = "0x5CE8AB0", VA = "0x185CE98B0")]
	private static void CAHNENKOGAD(bool HKGJMFKFODO, POHCLHIPEBO JNGKMBCEAGB, Dictionary<Guid, Guid> DFEIADKPFJN, PIMAHCIMDNM BJIMBMDDNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA780", Offset = "0x5CE9980", VA = "0x185CEA780")]
	private static void FNJKLNNDAGN(bool HKGJMFKFODO, POHCLHIPEBO JNGKMBCEAGB, PIMAHCIMDNM FNPKGOFCAIM, Guid OECPLADEJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA200", Offset = "0x5CE9400", VA = "0x185CEA200")]
	private static void EAPEKOKBDOO(POHCLHIPEBO JNGKMBCEAGB, Guid OACDBPFIEHK, GILELAKPBBJ? BDMAIHNCEDG, Dictionary<Guid, MMMPFILOJAL> FAMGDHBNOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB680", Offset = "0x5CEA880", VA = "0x185CEB680")]
	private static void LBHPHODLBPM(POHCLHIPEBO JNGKMBCEAGB, Dictionary<Guid, Guid> DFEIADKPFJN, Dictionary<int, int> NGHPCPNJPGP, CJHBLOEDPCM HLOBEAPJNNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB040", Offset = "0x5CEA240", VA = "0x185CEB040")]
	public static void JNACPJCCCKD(RepeatedField<POHCLHIPEBO> CHEABCGFFPB, EJBLLCDLPGF KOMEOHJCLKJ, IEnumerable<ByteString> ILLIIDCCAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8DC0", Offset = "0x5CE7FC0", VA = "0x185CE8DC0")]
	private static void BDOGDEFEBIL(RepeatedField<POHCLHIPEBO> CHEABCGFFPB, GLOHLKENEKF HGHPCCJIHOI, HLMHMCICHMA BEOJGLFOMBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct BGKJFMHOMAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool HKGJMFKFODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public bool KLNLFMDNLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public GILELAKPBBJ? BDMAIHNCEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public GILELAKPBBJ? CCBEKCKMLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public LFDAKMIBOFD JLIIOCEBGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public HLMHMCICHMA BEOJGLFOMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public PGPGNJBIIPB CHMMBCMEPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public Guid OECPLADEJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public DOGNPGJNMOD LGHHKHMLGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public List<POHCLHIPEBO> DCCCKPFIHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public Dictionary<string, object> JOMNDNGHFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public OIKKHJHOGBF LFNDOIJKFHH;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct GILELAKPBBJ
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private const float LHPONOIPOCF = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Vector3 DACBJNCMNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Quaternion MCFIHGJCDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float BDMGGOCELCK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Matrix4x4 CFIOANMHCJG
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5CE8110", Offset = "0x5CE7310", VA = "0x185CE8110")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1261940", Offset = "0x1260B40", VA = "0x181261940")]
	public GILELAKPBBJ(Vector3 DACBJNCMNFL, Quaternion MCFIHGJCDCP, float BDMGGOCELCK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5CE89E0", Offset = "0x5CE7BE0", VA = "0x185CE89E0")]
	public GILELAKPBBJ(ELHFDAKEDAO PJDHNNPAKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8920", Offset = "0x5CE7B20", VA = "0x185CE8920")]
	private GILELAKPBBJ(IFBGNHEEHPK FBANLNAKGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8540", Offset = "0x5CE7740", VA = "0x185CE8540")]
	public static GILELAKPBBJ IBBEOIHDGHF(MJNAKHNHEBG GFIODPJIADB)
	{
		return default(GILELAKPBBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5CE83F0", Offset = "0x5CE75F0", VA = "0x185CE83F0")]
	public static GILELAKPBBJ IADLOMHBOLO(GILELAKPBBJ GPFONCECPBK, GILELAKPBBJ OCGFEGEKAGH)
	{
		return default(GILELAKPBBJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5CE88D0", Offset = "0x5CE7AD0", VA = "0x185CE88D0")]
	public static GILELAKPBBJ LOJIFGBJNLM((Vector3, Quaternion, float) ONIBEFDCPGD)
	{
		return default(GILELAKPBBJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5CE87D0", Offset = "0x5CE79D0", VA = "0x185CE87D0")]
	public static GILELAKPBBJ LOJIFGBJNLM(Matrix4x4 IEFMFEKGPLE)
	{
		return default(GILELAKPBBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8210", Offset = "0x5CE7410", VA = "0x185CE8210")]
	public GILELAKPBBJ CNFADCGFGCD(Matrix4x4 LJLOGOIJMEM)
	{
		return default(GILELAKPBBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5CE83A0", Offset = "0x5CE75A0", VA = "0x185CE83A0")]
	public static GILELAKPBBJ HCJDKCJNJIP(Vector3 DACBJNCMNFL)
	{
		return default(GILELAKPBBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8570", Offset = "0x5CE7770", VA = "0x185CE8570")]
	[CompilerGenerated]
	internal static GILELAKPBBJ JMJCCBDOGJG(MJNAKHNHEBG MCFKDIFOJAH)
	{
		return default(GILELAKPBBJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class EELFMMNEPAK : HODICGCBGEA
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5CE7640", Offset = "0x5CE6840", VA = "0x185CE7640", Slot = "4")]
	public void EPADGILFCCN(HMODEIAOHPB ACAAOPLMGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5CE79A0", Offset = "0x5CE6BA0", VA = "0x185CE79A0")]
	private void IEFLKCLMHNM(Dictionary<Guid, Guid> BPBBJKOHCKB, DBEAAHMNMLN PJNLGGKDJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5CE7940", Offset = "0x5CE6B40", VA = "0x185CE7940")]
	private void IEFLKCLMHNM(Dictionary<Guid, Guid> BPBBJKOHCKB, DCPJIKMPPEC NICIOBDEMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5CE76F0", Offset = "0x5CE68F0", VA = "0x185CE76F0")]
	private void IEFLKCLMHNM(Dictionary<Guid, Guid> BPBBJKOHCKB, AEIAEFEOJAN DCICFCJOKMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public EELFMMNEPAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class NCKBEMAHDBD : HODICGCBGEA
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5CEED30", Offset = "0x5CEDF30", VA = "0x185CEED30", Slot = "4")]
	public void EPADGILFCCN(HMODEIAOHPB ACAAOPLMGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public NCKBEMAHDBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class ANJCGIEDHAC : HODICGCBGEA
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5CE72C0", Offset = "0x5CE64C0", VA = "0x185CE72C0", Slot = "4")]
	public void EPADGILFCCN(HMODEIAOHPB ACAAOPLMGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public ANJCGIEDHAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class HHPPNIMMDCM : HODICGCBGEA
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5CED400", Offset = "0x5CEC600", VA = "0x185CED400", Slot = "4")]
	public void EPADGILFCCN(HMODEIAOHPB ACAAOPLMGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public HHPPNIMMDCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class DLAKCDMIHMF : HODICGCBGEA
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5CE7430", Offset = "0x5CE6630", VA = "0x185CE7430", Slot = "4")]
	public void EPADGILFCCN(HMODEIAOHPB ACAAOPLMGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public DLAKCDMIHMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class JONGABGBPDD : HODICGCBGEA
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE9C0", Offset = "0x5CEDBC0", VA = "0x185CEE9C0", Slot = "4")]
	public void EPADGILFCCN(HMODEIAOHPB ACAAOPLMGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public JONGABGBPDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class GLAPDONFAPB : HODICGCBGEA
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8AB0", Offset = "0x5CE7CB0", VA = "0x185CE8AB0", Slot = "4")]
	public void EPADGILFCCN(HMODEIAOHPB ACAAOPLMGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public GLAPDONFAPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class EIIBKKCLEIB : HODICGCBGEA
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5CE7FF0", Offset = "0x5CE71F0", VA = "0x185CE7FF0", Slot = "4")]
	public void EPADGILFCCN(HMODEIAOHPB ACAAOPLMGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public EIIBKKCLEIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class AMCBPDCMDEF : HODICGCBGEA
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5CE70F0", Offset = "0x5CE62F0", VA = "0x185CE70F0", Slot = "4")]
	public void EPADGILFCCN(HMODEIAOHPB ACAAOPLMGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public AMCBPDCMDEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class LLDMFECELCP : HODICGCBGEA
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEB40", Offset = "0x5CEDD40", VA = "0x185CEEB40", Slot = "4")]
	public void EPADGILFCCN(HMODEIAOHPB ACAAOPLMGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public LLDMFECELCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class EFGPHEKBCOA : HODICGCBGEA
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5CE7ED0", Offset = "0x5CE70D0", VA = "0x185CE7ED0", Slot = "4")]
	public void EPADGILFCCN(HMODEIAOHPB ACAAOPLMGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public EFGPHEKBCOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class NOHFBNJHPKN : HODICGCBGEA
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly System.Random ILACLAAFMFK;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFBF0", Offset = "0x5CEEDF0", VA = "0x185CEFBF0", Slot = "4")]
	public void EPADGILFCCN(HMODEIAOHPB ACAAOPLMGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public NOHFBNJHPKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct KACCCCGJOIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public CJHBLOEDPCM FLPPPNDNNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public AEKAGMOPCFN PGDJDIPPPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Dictionary<int, int> NGHPCPNJPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Dictionary<Guid, Guid> JEEMBJPEMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public OIKKHJHOGBF LFNDOIJKFHH;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface HODICGCBGEA
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EPADGILFCCN(HMODEIAOHPB ACAAOPLMGPC);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class NMOOCNCEIGB
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly HODICGCBGEA[] DPGONEFDBFN;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEE50", Offset = "0x5CEE050", VA = "0x185CEEE50")]
	public static void CCKHPDFEIAI(POHCLHIPEBO ONIBEFDCPGD, Dictionary<Guid, Guid> GFHLCHKMPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF060", Offset = "0x5CEE260", VA = "0x185CEF060")]
	public static void NAJIENPLGPH(POHCLHIPEBO? ONIBEFDCPGD, PIMAHCIMDNM BJIMBMDDNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF250", Offset = "0x5CEE450", VA = "0x185CEF250")]
	public static void OEOBMFFELGM(HMODEIAOHPB ACAAOPLMGPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct HMODEIAOHPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public CJHBLOEDPCM LECKKAGBJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public POHCLHIPEBO JNGKMBCEAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Dictionary<int, int> NGHPCPNJPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Dictionary<Guid, Guid> JEEMBJPEMAK;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE8A0", Offset = "0x5CEDAA0", VA = "0x185CEE8A0")]
	public Guid MELEKIIMAOA(Guid JHHPNHDNIID)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface OIKKHJHOGBF
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int EJBPPPIJHBI, out Guid BEJHBMJBPLA);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class HJMENAOAHNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<string> CPOGOAMDIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<long, int> GKMKFPCIJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<Guid> NIBLMLCDOKM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyCollection<string> IKNKGAJONFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<long, int> KJIEKMOGDBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE210", Offset = "0x5CED410", VA = "0x185CEE210")]
	public static HJMENAOAHNM DDMGJKFBGCG(ALJFOENJMIN GDKBHGNBDKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE610", Offset = "0x5CED810", VA = "0x185CEE610")]
	public static HJMENAOAHNM MBFKPJDALHK(HAPKOIDDDJL FDEGKABDDAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE280", Offset = "0x5CED480", VA = "0x185CEE280")]
	public static HJMENAOAHNM DNMMLAPNDHK(IEnumerable<string> CPOGOAMDIOP, IDictionary<long, int> HMPPBPJINKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE7A0", Offset = "0x5CED9A0", VA = "0x185CEE7A0")]
	private HJMENAOAHNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE680", Offset = "0x5CED880", VA = "0x185CEE680")]
	private HJMENAOAHNM(IEnumerable<string> CPOGOAMDIOP, IDictionary<long, int> HMPPBPJINKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5CED550", Offset = "0x5CEC750", VA = "0x185CED550")]
	private void BCBGHBKCOEB(ALJFOENJMIN GDKBHGNBDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDB30", Offset = "0x5CECD30", VA = "0x185CEDB30")]
	private void BCBGHBKCOEB(HAPKOIDDDJL FDEGKABDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5CED710", Offset = "0x5CEC910", VA = "0x185CED710")]
	private void BCBGHBKCOEB(EJBLLCDLPGF? LBGMPPHBAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDCF0", Offset = "0x5CECEF0", VA = "0x185CEDCF0")]
	private void BCBGHBKCOEB(HPAHIOIDLBF? MCFKDIFOJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDE60", Offset = "0x5CED060", VA = "0x185CEDE60")]
	private void BCBGHBKCOEB(POHCLHIPEBO? JNGKMBCEAGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE3D0", Offset = "0x5CED5D0", VA = "0x185CEE3D0")]
	private void IAKDJDEKHMK(string? IGKMDEJJGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE440", Offset = "0x5CED640", VA = "0x185CEE440")]
	private void JKFNNEBLOEK(LLLKAIJPFMH? MIODBAMHMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE520", Offset = "0x5CED720", VA = "0x185CEE520")]
	private void JKFNNEBLOEK(PMGHNOGKHLB? MIODBAMHMFB)
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
