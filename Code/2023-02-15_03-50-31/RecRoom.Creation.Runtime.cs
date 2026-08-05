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
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DCB5B0", Offset = "0x5DCA9B0", VA = "0x185DCB5B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xC60960", Offset = "0xC5FD60", VA = "0x180C60960")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PILCLKMPGJP
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB640", Offset = "0x5DCAA40", VA = "0x185DCB640")]
	public static bool OEOBMFFELGM(KACCCCGJOIM HIDBCOHGCJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB680", Offset = "0x5DCAA80", VA = "0x185DCB680")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x77FBB0", Offset = "0x77EFB0", VA = "0x18077FBB0")]
	public NJHOJMNKMBL(Dictionary<Guid, Guid> CJAKCMFDAAH, Dictionary<Guid, Guid> EKGOCEIADNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA670", Offset = "0x5DC9A70", VA = "0x185DCA670", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DC8B80", Offset = "0x5DC7F80", VA = "0x185DC8B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public JBMIEFJCIMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5DCA1F0", Offset = "0x5DC95F0", VA = "0x185DCA1F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public MGAMIPLAGDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5DCA590", Offset = "0x5DC9990", VA = "0x185DCA590")]
		internal void <InitializeCircuitsV2Remapping>b__1(HPAHIOIDLBF n)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5DC7D90", Offset = "0x5DC7190", VA = "0x185DC7D90")]
	public static HAPKOIDDDJL PAHLILINDDF(LKOFMGPOIKD EGFFIIDPPHB, out DFJKEGMAPPD GLIEKCHAGAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5DC67C0", Offset = "0x5DC5BC0", VA = "0x185DC67C0")]
	private static void ICEHHAKHOHI(HAPKOIDDDJL EIPGFAKPKCJ, HBHKIBCOKPM GHMPBOLKLJB, out DFJKEGMAPPD GLIEKCHAGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4520", Offset = "0x5DC3920", VA = "0x185DC4520")]
	private static void AKKKABGMOJN(POHCLHIPEBO ACBFPAHPLJH, HBHKIBCOKPM GHMPBOLKLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5DC51C0", Offset = "0x5DC45C0", VA = "0x185DC51C0")]
	private static void DIHOJPNFKAF(HAPKOIDDDJL EIPGFAKPKCJ, HBHKIBCOKPM GHMPBOLKLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5DC7A90", Offset = "0x5DC6E90", VA = "0x185DC7A90")]
	private static void NGHOAMPEINK(ref LKOFMGPOIKD NBHIHMOBFBF, HBHKIBCOKPM GHMPBOLKLJB, POHCLHIPEBO ACBFPAHPLJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5DC83C0", Offset = "0x5DC77C0", VA = "0x185DC83C0")]
	public static bool PLGNGJFMALH(HAPKOIDDDJL EIPGFAKPKCJ, BGKJFMHOMAI HFDBHCCECEM, out NJHOJMNKMBL? LLMJPPDKAGC, out string? GNLLAOFLEDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5DC6430", Offset = "0x5DC5830", VA = "0x185DC6430")]
	private static void HGKFMFPHLIC(HAPKOIDDDJL EIPGFAKPKCJ, ref BGKJFMHOMAI HFDBHCCECEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5D20", Offset = "0x5DC5120", VA = "0x185DC5D20")]
	public static Dictionary<Guid, Guid> FDLMNIAANDB(IEnumerable<POHCLHIPEBO> CCAHLKEAJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5DC7D50", Offset = "0x5DC7150", VA = "0x185DC7D50")]
	private static void ODHHFOAEOFA(HAPKOIDDDJL EIPGFAKPKCJ, ref BGKJFMHOMAI HFDBHCCECEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5460", Offset = "0x5DC4860", VA = "0x185DC5460")]
	private static bool DOMEMLEHGBD(HAPKOIDDDJL EIPGFAKPKCJ, CJHBLOEDPCM CANGNMEKFPB, ref BGKJFMHOMAI HFDBHCCECEM, out string GNLLAOFLEDB, out Dictionary<int, int> KBFFBLJJBFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5DC6550", Offset = "0x5DC5950", VA = "0x185DC6550")]
	private static Dictionary<Guid, MMMPFILOJAL> HGOLEAPPHIK(HAPKOIDDDJL EIPGFAKPKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5DC6FF0", Offset = "0x5DC63F0", VA = "0x185DC6FF0")]
	private static bool MDEBJGJHDAD(HAPKOIDDDJL EIPGFAKPKCJ, ref BGKJFMHOMAI HFDBHCCECEM, out string? GNLLAOFLEDB, out PIMAHCIMDNM? FNPKGOFCAIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5130", Offset = "0x5DC4530", VA = "0x185DC5130")]
	private static void CAHNENKOGAD(bool HKGJMFKFODO, POHCLHIPEBO JNGKMBCEAGB, Dictionary<Guid, Guid> DFEIADKPFJN, PIMAHCIMDNM BJIMBMDDNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5DC6000", Offset = "0x5DC5400", VA = "0x185DC6000")]
	private static void FNJKLNNDAGN(bool HKGJMFKFODO, POHCLHIPEBO JNGKMBCEAGB, PIMAHCIMDNM FNPKGOFCAIM, Guid OECPLADEJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5A80", Offset = "0x5DC4E80", VA = "0x185DC5A80")]
	private static void EAPEKOKBDOO(POHCLHIPEBO JNGKMBCEAGB, Guid OACDBPFIEHK, GILELAKPBBJ? BDMAIHNCEDG, Dictionary<Guid, MMMPFILOJAL> FAMGDHBNOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5DC6F00", Offset = "0x5DC6300", VA = "0x185DC6F00")]
	private static void LBHPHODLBPM(POHCLHIPEBO JNGKMBCEAGB, Dictionary<Guid, Guid> DFEIADKPFJN, Dictionary<int, int> NGHPCPNJPGP, CJHBLOEDPCM HLOBEAPJNNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5DC68C0", Offset = "0x5DC5CC0", VA = "0x185DC68C0")]
	public static void JNACPJCCCKD(RepeatedField<POHCLHIPEBO> CHEABCGFFPB, EJBLLCDLPGF KOMEOHJCLKJ, IEnumerable<ByteString> ILLIIDCCAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4640", Offset = "0x5DC3A40", VA = "0x185DC4640")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DC3990", Offset = "0x5DC2D90", VA = "0x185DC3990")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1D5BC30", Offset = "0x1D5B030", VA = "0x181D5BC30")]
	public GILELAKPBBJ(Vector3 DACBJNCMNFL, Quaternion MCFIHGJCDCP, float BDMGGOCELCK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4260", Offset = "0x5DC3660", VA = "0x185DC4260")]
	public GILELAKPBBJ(ELHFDAKEDAO PJDHNNPAKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5DC41A0", Offset = "0x5DC35A0", VA = "0x185DC41A0")]
	private GILELAKPBBJ(IFBGNHEEHPK FBANLNAKGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3DC0", Offset = "0x5DC31C0", VA = "0x185DC3DC0")]
	public static GILELAKPBBJ IBBEOIHDGHF(MJNAKHNHEBG GFIODPJIADB)
	{
		return default(GILELAKPBBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3C70", Offset = "0x5DC3070", VA = "0x185DC3C70")]
	public static GILELAKPBBJ IADLOMHBOLO(GILELAKPBBJ GPFONCECPBK, GILELAKPBBJ OCGFEGEKAGH)
	{
		return default(GILELAKPBBJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4150", Offset = "0x5DC3550", VA = "0x185DC4150")]
	public static GILELAKPBBJ LOJIFGBJNLM((Vector3, Quaternion, float) ONIBEFDCPGD)
	{
		return default(GILELAKPBBJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4050", Offset = "0x5DC3450", VA = "0x185DC4050")]
	public static GILELAKPBBJ LOJIFGBJNLM(Matrix4x4 IEFMFEKGPLE)
	{
		return default(GILELAKPBBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3A90", Offset = "0x5DC2E90", VA = "0x185DC3A90")]
	public GILELAKPBBJ CNFADCGFGCD(Matrix4x4 LJLOGOIJMEM)
	{
		return default(GILELAKPBBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3C20", Offset = "0x5DC3020", VA = "0x185DC3C20")]
	public static GILELAKPBBJ HCJDKCJNJIP(Vector3 DACBJNCMNFL)
	{
		return default(GILELAKPBBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3DF0", Offset = "0x5DC31F0", VA = "0x185DC3DF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DC2EC0", Offset = "0x5DC22C0", VA = "0x185DC2EC0", Slot = "4")]
	public void EPADGILFCCN(HMODEIAOHPB ACAAOPLMGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3220", Offset = "0x5DC2620", VA = "0x185DC3220")]
	private void IEFLKCLMHNM(Dictionary<Guid, Guid> BPBBJKOHCKB, DBEAAHMNMLN PJNLGGKDJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5DC31C0", Offset = "0x5DC25C0", VA = "0x185DC31C0")]
	private void IEFLKCLMHNM(Dictionary<Guid, Guid> BPBBJKOHCKB, DCPJIKMPPEC NICIOBDEMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5DC2F70", Offset = "0x5DC2370", VA = "0x185DC2F70")]
	private void IEFLKCLMHNM(Dictionary<Guid, Guid> BPBBJKOHCKB, AEIAEFEOJAN DCICFCJOKMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public EELFMMNEPAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class NCKBEMAHDBD : HODICGCBGEA
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA5B0", Offset = "0x5DC99B0", VA = "0x185DCA5B0", Slot = "4")]
	public void EPADGILFCCN(HMODEIAOHPB ACAAOPLMGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public NCKBEMAHDBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class ANJCGIEDHAC : HODICGCBGEA
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5DC2B40", Offset = "0x5DC1F40", VA = "0x185DC2B40", Slot = "4")]
	public void EPADGILFCCN(HMODEIAOHPB ACAAOPLMGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public ANJCGIEDHAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class HHPPNIMMDCM : HODICGCBGEA
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8C80", Offset = "0x5DC8080", VA = "0x185DC8C80", Slot = "4")]
	public void EPADGILFCCN(HMODEIAOHPB ACAAOPLMGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public HHPPNIMMDCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class DLAKCDMIHMF : HODICGCBGEA
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5DC2CB0", Offset = "0x5DC20B0", VA = "0x185DC2CB0", Slot = "4")]
	public void EPADGILFCCN(HMODEIAOHPB ACAAOPLMGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public DLAKCDMIHMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class JONGABGBPDD : HODICGCBGEA
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA240", Offset = "0x5DC9640", VA = "0x185DCA240", Slot = "4")]
	public void EPADGILFCCN(HMODEIAOHPB ACAAOPLMGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public JONGABGBPDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class GLAPDONFAPB : HODICGCBGEA
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4330", Offset = "0x5DC3730", VA = "0x185DC4330", Slot = "4")]
	public void EPADGILFCCN(HMODEIAOHPB ACAAOPLMGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public GLAPDONFAPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class EIIBKKCLEIB : HODICGCBGEA
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3870", Offset = "0x5DC2C70", VA = "0x185DC3870", Slot = "4")]
	public void EPADGILFCCN(HMODEIAOHPB ACAAOPLMGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public EIIBKKCLEIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class AMCBPDCMDEF : HODICGCBGEA
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5DC2970", Offset = "0x5DC1D70", VA = "0x185DC2970", Slot = "4")]
	public void EPADGILFCCN(HMODEIAOHPB ACAAOPLMGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public AMCBPDCMDEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class LLDMFECELCP : HODICGCBGEA
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA3C0", Offset = "0x5DC97C0", VA = "0x185DCA3C0", Slot = "4")]
	public void EPADGILFCCN(HMODEIAOHPB ACAAOPLMGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public LLDMFECELCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class EFGPHEKBCOA : HODICGCBGEA
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3750", Offset = "0x5DC2B50", VA = "0x185DC3750", Slot = "4")]
	public void EPADGILFCCN(HMODEIAOHPB ACAAOPLMGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DCB470", Offset = "0x5DCA870", VA = "0x185DCB470", Slot = "4")]
	public void EPADGILFCCN(HMODEIAOHPB ACAAOPLMGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DCA6D0", Offset = "0x5DC9AD0", VA = "0x185DCA6D0")]
	public static void CCKHPDFEIAI(POHCLHIPEBO ONIBEFDCPGD, Dictionary<Guid, Guid> GFHLCHKMPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA8E0", Offset = "0x5DC9CE0", VA = "0x185DCA8E0")]
	public static void NAJIENPLGPH(POHCLHIPEBO? ONIBEFDCPGD, PIMAHCIMDNM BJIMBMDDNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5DCAAD0", Offset = "0x5DC9ED0", VA = "0x185DCAAD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DCA120", Offset = "0x5DC9520", VA = "0x185DCA120")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<long, int> KJIEKMOGDBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9A90", Offset = "0x5DC8E90", VA = "0x185DC9A90")]
	public static HJMENAOAHNM DDMGJKFBGCG(ALJFOENJMIN GDKBHGNBDKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9E90", Offset = "0x5DC9290", VA = "0x185DC9E90")]
	public static HJMENAOAHNM MBFKPJDALHK(HAPKOIDDDJL FDEGKABDDAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9B00", Offset = "0x5DC8F00", VA = "0x185DC9B00")]
	public static HJMENAOAHNM DNMMLAPNDHK(IEnumerable<string> CPOGOAMDIOP, IDictionary<long, int> HMPPBPJINKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA020", Offset = "0x5DC9420", VA = "0x185DCA020")]
	private HJMENAOAHNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9F00", Offset = "0x5DC9300", VA = "0x185DC9F00")]
	private HJMENAOAHNM(IEnumerable<string> CPOGOAMDIOP, IDictionary<long, int> HMPPBPJINKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8DD0", Offset = "0x5DC81D0", VA = "0x185DC8DD0")]
	private void BCBGHBKCOEB(ALJFOENJMIN GDKBHGNBDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5DC93B0", Offset = "0x5DC87B0", VA = "0x185DC93B0")]
	private void BCBGHBKCOEB(HAPKOIDDDJL FDEGKABDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8F90", Offset = "0x5DC8390", VA = "0x185DC8F90")]
	private void BCBGHBKCOEB(EJBLLCDLPGF? LBGMPPHBAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9570", Offset = "0x5DC8970", VA = "0x185DC9570")]
	private void BCBGHBKCOEB(HPAHIOIDLBF? MCFKDIFOJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5DC96E0", Offset = "0x5DC8AE0", VA = "0x185DC96E0")]
	private void BCBGHBKCOEB(POHCLHIPEBO? JNGKMBCEAGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9C50", Offset = "0x5DC9050", VA = "0x185DC9C50")]
	private void IAKDJDEKHMK(string? IGKMDEJJGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9CC0", Offset = "0x5DC90C0", VA = "0x185DC9CC0")]
	private void JKFNNEBLOEK(LLLKAIJPFMH? MIODBAMHMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9DA0", Offset = "0x5DC91A0", VA = "0x185DC9DA0")]
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
