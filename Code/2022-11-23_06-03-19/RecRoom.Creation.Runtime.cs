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
		[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070")]
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
		[Cpp2IlInjected.Address(RVA = "0x5A00FC0", Offset = "0x59FFDC0", VA = "0x185A00FC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA48B60", Offset = "0xA47960", VA = "0x180A48B60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DGJDAOCCGJM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x59FF080", Offset = "0x59FDE80", VA = "0x1859FF080")]
	public static bool BAJFMCBDJOE(KDCHGMPHEDI LAHHBALAAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x59FED00", Offset = "0x59FDB00", VA = "0x1859FED00")]
	private static bool BAJFMCBDJOE(FJKFCNMMCGM CJPPBPILFFF, ref KDCHGMPHEDI LAHHBALAAPN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct MPGHGBNIKBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public List<IOMALNHJNIN> JNDCNDDEFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public IEnumerable<NAKBKBNHOJA> DHNLHOOPJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public MDLJJEGFOLJ PJFEHCHEAKD;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HJEGLBKLFKB
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(GHDGLGAOCJD JLFCOOGLPMP, out Dictionary<int, int> CGCDKODCJIE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(MIDGADGEHKB JDFOADDEDJH, ABLCHCAFHMK MPDGBAJOJOA);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BCEEDICJPMN
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
public sealed class HPBCGCGCNFG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<Guid, Guid> PFELEENFJHI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<Guid, Guid> JJMNLMDNDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6EED00", Offset = "0x6EDB00", VA = "0x1806EED00")]
	public HPBCGCGCNFG(Dictionary<Guid, Guid> PFELEENFJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5A00960", Offset = "0x59FF760", VA = "0x185A00960", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class PAHBDIOHFJP
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KBMGEGHMFCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public JJGPGICLKLI destinationGraph;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public KBMGEGHMFCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5A00B00", Offset = "0x59FF900", VA = "0x185A00B00")]
		internal bool <InitializeCircuitsV2Remapping>b__0(MBPFHFFEFPD n)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class OGJEOPCPBEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int mpif;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public OGJEOPCPBEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5A01240", Offset = "0x5A00040", VA = "0x185A01240")]
		internal void <InitializeCircuitsV2Remapping>b__1(MBPFHFFEFPD n)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly Dictionary<Guid, FJKFCNMMCGM> PKBCFBELCDG;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly Dictionary<Guid, Guid> HAFJJAIKNPP;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly HashSet<NAKBKBNHOJA> HJJALDOMAEP;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly HashSet<JJGPGICLKLI> IJJDIFLJJOI;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<BPFCGMNEOBI> IPCEGKBJIGG;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5A03830", Offset = "0x5A02630", VA = "0x185A03830")]
	public static GDHABDKIEPI HJPBIOOBEIM(MPGHGBNIKBA PPEOOCLEFHH, out NAGGOLHKOFC EHGGDIHDDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5A02910", Offset = "0x5A01710", VA = "0x185A02910")]
	private static void DLCGNODFCIN(GDHABDKIEPI HBHJDBLLCNA, out NAGGOLHKOFC EHGGDIHDDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5A05640", Offset = "0x5A04440", VA = "0x185A05640")]
	private static void PECNOPICEPF(IOMALNHJNIN CKBPBBLEPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5A05270", Offset = "0x5A04070", VA = "0x185A05270")]
	private static void ONILCMPAPAK(GDHABDKIEPI HBHJDBLLCNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5A05560", Offset = "0x5A04360", VA = "0x185A05560")]
	private static void OPFMHCNENOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5A03E00", Offset = "0x5A02C00", VA = "0x185A03E00")]
	private static void KEDHKFJPMGG(ref MPGHGBNIKBA EDHOPHEMPEG, IOMALNHJNIN CKBPBBLEPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5A01260", Offset = "0x5A00060", VA = "0x185A01260")]
	public static bool ADBLOGDKMKK(GDHABDKIEPI HBHJDBLLCNA, AMLHKENPOOM POPNCNDDDHE, out HPBCGCGCNFG? ELEOOJOOOOE, out string? OMKDGOMBDIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5A03730", Offset = "0x5A02530", VA = "0x185A03730")]
	private static void HCFPCEKIKCF(GDHABDKIEPI HBHJDBLLCNA, ref AMLHKENPOOM POPNCNDDDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5A023C0", Offset = "0x5A011C0", VA = "0x185A023C0")]
	private static void BAPHNBGFELN(GDHABDKIEPI HBHJDBLLCNA, ref AMLHKENPOOM POPNCNDDDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5A04C50", Offset = "0x5A03A50", VA = "0x185A04C50")]
	private static bool NFBOIJOJCPJ(GDHABDKIEPI HBHJDBLLCNA, MIDGADGEHKB JDFOADDEDJH, ref AMLHKENPOOM POPNCNDDDHE, out string OMKDGOMBDIM, out Dictionary<int, int> CGCDKODCJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5A034B0", Offset = "0x5A022B0", VA = "0x185A034B0")]
	private static Dictionary<Guid, FJKFCNMMCGM> FOGLMGLDAPK(GDHABDKIEPI HBHJDBLLCNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5A03430", Offset = "0x5A02230", VA = "0x185A03430")]
	private static void FAKLMDLFLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5A02A40", Offset = "0x5A01840", VA = "0x185A02A40")]
	private static bool EMNDPJNECHJ(GDHABDKIEPI HBHJDBLLCNA, ref AMLHKENPOOM POPNCNDDDHE, out string? OMKDGOMBDIM, out KOPOMDKMEPE? CDBOIMLHINL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5A02880", Offset = "0x5A01680", VA = "0x185A02880")]
	private static void BILFELMNPIB(bool NCPANJEFEAO, IOMALNHJNIN JNKHFBAHKDD, Dictionary<Guid, Guid> AIMDNHFDIFM, KOPOMDKMEPE FPAICCDAGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5A02450", Offset = "0x5A01250", VA = "0x185A02450")]
	private static void BEIMMLMMLJF(bool NCPANJEFEAO, IOMALNHJNIN JNKHFBAHKDD, KOPOMDKMEPE CDBOIMLHINL, Guid CEDADLPHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5A01AE0", Offset = "0x5A008E0", VA = "0x185A01AE0")]
	private static void ALNOPMJIAID(IOMALNHJNIN JNKHFBAHKDD, Guid LGLFIOOGNBK, CGMNIONPKCM? JMHNBLNOCNP, Dictionary<Guid, FJKFCNMMCGM> DJIAOAEEDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5A03D10", Offset = "0x5A02B10", VA = "0x185A03D10")]
	private static void JHFPDJEFJAB(IOMALNHJNIN JNKHFBAHKDD, Dictionary<Guid, Guid> AIMDNHFDIFM, Dictionary<int, int> JAMNEMJKJMM, MIDGADGEHKB BEEACFNHGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5A01D80", Offset = "0x5A00B80", VA = "0x185A01D80")]
	public static void APKCAABDCOO(RepeatedField<IOMALNHJNIN> EGOAAIBNHOF, NPHPPBNGGPO OPHHKDCHKOD, IEnumerable<ByteString> BDFJPGMDHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5A04110", Offset = "0x5A02F10", VA = "0x185A04110")]
	private static void LJPFFBBGJAC(RepeatedField<IOMALNHJNIN> EGOAAIBNHOF, DPHDKLDAFFF LKJHKADLNAD, BCEEDICJPMN DKHLCDKALLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct AMLHKENPOOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public bool NCPANJEFEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public bool NLAGGNKNFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public CGMNIONPKCM? JMHNBLNOCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public CGMNIONPKCM? FLHKCNOLHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public KKHADDJKCKG IBDHGNOMHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public BCEEDICJPMN DKHLCDKALLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public HJEGLBKLFKB ENNHPABNJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public Guid CEDADLPHFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public MDLJJEGFOLJ PJFEHCHEAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public List<IOMALNHJNIN> IJIBOECBPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public Dictionary<string, object> NPIOFADKPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ABEENDLMLHM FMNNEGCHAOO;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct CGMNIONPKCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Vector3 DKGAADMNOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Quaternion MPLPNDNEAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float OLIFDPKHJEC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Matrix4x4 FOAJFGFBCHN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x59FDFE0", Offset = "0x59FCDE0", VA = "0x1859FDFE0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static CGMNIONPKCM IHBPCONIFJA
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x59FE0E0", Offset = "0x59FCEE0", VA = "0x1859FE0E0")]
		get
		{
			return default(CGMNIONPKCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool FEEOKLBEJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x59FD9A0", Offset = "0x59FC7A0", VA = "0x1859FD9A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1B2BCC0", Offset = "0x1B2AAC0", VA = "0x181B2BCC0")]
	public CGMNIONPKCM(Vector3 DKGAADMNOOM, Quaternion MPLPNDNEAPK, float OLIFDPKHJEC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x59FE170", Offset = "0x59FCF70", VA = "0x1859FE170")]
	public CGMNIONPKCM(FKDMNMHIPDD NKJDGEMJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x59FE110", Offset = "0x59FCF10", VA = "0x1859FE110")]
	private CGMNIONPKCM(PHJPDGLHJOB ADHHMNEMEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x59FD9B0", Offset = "0x59FC7B0", VA = "0x1859FD9B0")]
	public static CGMNIONPKCM EGCMHGAOFKA(NAKBKBNHOJA NCDJEOADDGN)
	{
		return default(CGMNIONPKCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x59FDBB0", Offset = "0x59FC9B0", VA = "0x1859FDBB0")]
	public static CGMNIONPKCM FOINCCODCHN(CGMNIONPKCM GEOFAMNLJNK, CGMNIONPKCM DCGPNPLAHJN)
	{
		return default(CGMNIONPKCM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x59FDE90", Offset = "0x59FCC90", VA = "0x1859FDE90")]
	public static CGMNIONPKCM KPOCFOKDNEC((Vector3, Quaternion, float) JLFCOOGLPMP)
	{
		return default(CGMNIONPKCM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x59FDEE0", Offset = "0x59FCCE0", VA = "0x1859FDEE0")]
	public static CGMNIONPKCM KPOCFOKDNEC(Matrix4x4 CILJFPGFCGB)
	{
		return default(CGMNIONPKCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x59FDD00", Offset = "0x59FCB00", VA = "0x1859FDD00")]
	public CGMNIONPKCM GJIMHEMKKGJ(Matrix4x4 KAMDPLLJPAH)
	{
		return default(CGMNIONPKCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x59FD9E0", Offset = "0x59FC7E0", VA = "0x1859FD9E0")]
	[CompilerGenerated]
	internal static CGMNIONPKCM FALDOMLEKDE(NAKBKBNHOJA BAIMHJNEKGI)
	{
		return default(CGMNIONPKCM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class CKICBBDBKGF : CPEKFIMFIOK
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x59FE350", Offset = "0x59FD150", VA = "0x1859FE350", Slot = "4")]
	public void GNIKIHCOJDM(PGIHPGMJIBC EBPICBHIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x59FE400", Offset = "0x59FD200", VA = "0x1859FE400")]
	private void JMPDCCHCLKH(Dictionary<Guid, Guid> KHLGMDKEEIE, FNPEPAAPKPF FOBGKHBPJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x59FE930", Offset = "0x59FD730", VA = "0x1859FE930")]
	private void JMPDCCHCLKH(Dictionary<Guid, Guid> KHLGMDKEEIE, CDPKODPCCJO GLEKDCELHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x59FE990", Offset = "0x59FD790", VA = "0x1859FE990")]
	private void JMPDCCHCLKH(Dictionary<Guid, Guid> KHLGMDKEEIE, LPELGDNLOCK DBAPFFFDBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public CKICBBDBKGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class CHCDBAFCKAF : CPEKFIMFIOK
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x59FE290", Offset = "0x59FD090", VA = "0x1859FE290", Slot = "4")]
	public void GNIKIHCOJDM(PGIHPGMJIBC EBPICBHIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public CHCDBAFCKAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class GPDCIOBOLOO : CPEKFIMFIOK
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5A007F0", Offset = "0x59FF5F0", VA = "0x185A007F0", Slot = "4")]
	public void GNIKIHCOJDM(PGIHPGMJIBC EBPICBHIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public GPDCIOBOLOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class JLHINEDAJNM : CPEKFIMFIOK
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5A009B0", Offset = "0x59FF7B0", VA = "0x185A009B0", Slot = "4")]
	public void GNIKIHCOJDM(PGIHPGMJIBC EBPICBHIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public JLHINEDAJNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class GHLFIONOKOH : CPEKFIMFIOK
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5A00410", Offset = "0x59FF210", VA = "0x185A00410", Slot = "4")]
	public void GNIKIHCOJDM(PGIHPGMJIBC EBPICBHIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public GHLFIONOKOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class KEBEPBAHDJH : CPEKFIMFIOK
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5A00B50", Offset = "0x59FF950", VA = "0x185A00B50", Slot = "4")]
	public void GNIKIHCOJDM(PGIHPGMJIBC EBPICBHIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public KEBEPBAHDJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class OBHAPIPBCFJ : CPEKFIMFIOK
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5A01050", Offset = "0x59FFE50", VA = "0x185A01050", Slot = "4")]
	public void GNIKIHCOJDM(PGIHPGMJIBC EBPICBHIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public OBHAPIPBCFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class KGNKMBENKAM : CPEKFIMFIOK
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5A00CD0", Offset = "0x59FFAD0", VA = "0x185A00CD0", Slot = "4")]
	public void GNIKIHCOJDM(PGIHPGMJIBC EBPICBHIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public KGNKMBENKAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class GICKDEPBPFC : CPEKFIMFIOK
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5A00620", Offset = "0x59FF420", VA = "0x185A00620", Slot = "4")]
	public void GNIKIHCOJDM(PGIHPGMJIBC EBPICBHIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public GICKDEPBPFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class NKNOJIPDPGP : CPEKFIMFIOK
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5A00DF0", Offset = "0x59FFBF0", VA = "0x185A00DF0", Slot = "4")]
	public void GNIKIHCOJDM(PGIHPGMJIBC EBPICBHIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public NKNOJIPDPGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class CMLFIENGHIM : CPEKFIMFIOK
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x59FEBE0", Offset = "0x59FD9E0", VA = "0x1859FEBE0", Slot = "4")]
	public void GNIKIHCOJDM(PGIHPGMJIBC EBPICBHIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public CMLFIENGHIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class CFGOOLILAOP : CPEKFIMFIOK
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly System.Random FLJNDFHBIBL;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x59FD860", Offset = "0x59FC660", VA = "0x1859FD860", Slot = "4")]
	public void GNIKIHCOJDM(PGIHPGMJIBC EBPICBHIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public CFGOOLILAOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct KDCHGMPHEDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public MIDGADGEHKB OPAPEIICLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public CDINKOJOOPL KCNOPJLGCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Dictionary<int, int> JAMNEMJKJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Dictionary<Guid, Guid> NJHINMIAKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ABEENDLMLHM FMNNEGCHAOO;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface CPEKFIMFIOK
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNIKIHCOJDM(PGIHPGMJIBC EBPICBHIPME);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface ABEENDLMLHM
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int KPEMIPENJMJ, out Guid LKPNNHMOODO);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class AIIMHEFJBJO
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly CPEKFIMFIOK[] OCCOILOCEBN;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x59FCE20", Offset = "0x59FBC20", VA = "0x1859FCE20")]
	public static void LAHDMEOOOJI(IOMALNHJNIN JLFCOOGLPMP, Dictionary<Guid, Guid> HEKNGPHBFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x59FD030", Offset = "0x59FBE30", VA = "0x1859FD030")]
	public static void MJMDDNDHAGG(IOMALNHJNIN? JLFCOOGLPMP, KOPOMDKMEPE FPAICCDAGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x59FCAC0", Offset = "0x59FB8C0", VA = "0x1859FCAC0")]
	public static void BAJFMCBDJOE(PGIHPGMJIBC EBPICBHIPME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct PGIHPGMJIBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public MIDGADGEHKB OBFHGJIPMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public IOMALNHJNIN JNKHFBAHKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Dictionary<int, int> JAMNEMJKJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Dictionary<Guid, Guid> NJHINMIAKMP;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5A059A0", Offset = "0x5A047A0", VA = "0x185A059A0")]
	public Guid LDCBENGMCNM(Guid LNKDDEDGKJH)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class FICOJGDGHKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<string> MDACLBKPEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<long, int> CMNLDIKJPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<Guid> MMJOADPFPGL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyCollection<string> CIGOBIPKPKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<long, int> GMOCIFLCEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x59FFFC0", Offset = "0x59FEDC0", VA = "0x1859FFFC0")]
	public static FICOJGDGHKG GGMDLNPDCLC(IFHIAHJKMIE CGNEHNOPJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x59FF0C0", Offset = "0x59FDEC0", VA = "0x1859FF0C0")]
	public static FICOJGDGHKG AADDJLMMDNC(GDHABDKIEPI FFMODCDFCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5A00030", Offset = "0x59FEE30", VA = "0x185A00030")]
	public static FICOJGDGHKG HJCHIPNAMFF(IEnumerable<string> MDACLBKPEBM, IDictionary<long, int> NIBECMCJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5A001F0", Offset = "0x59FEFF0", VA = "0x185A001F0")]
	private FICOJGDGHKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5A002F0", Offset = "0x59FF0F0", VA = "0x185A002F0")]
	private FICOJGDGHKG(IEnumerable<string> MDACLBKPEBM, IDictionary<long, int> NIBECMCJKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x59FF2F0", Offset = "0x59FE0F0", VA = "0x1859FF2F0")]
	private void DECADLLLIPL(IFHIAHJKMIE CGNEHNOPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x59FF130", Offset = "0x59FDF30", VA = "0x1859FF130")]
	private void DECADLLLIPL(GDHABDKIEPI FFMODCDFCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x59FF860", Offset = "0x59FE660", VA = "0x1859FF860")]
	private void DECADLLLIPL(NPHPPBNGGPO MHPJOFNEKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x59FFC80", Offset = "0x59FEA80", VA = "0x1859FFC80")]
	private void DECADLLLIPL(MBPFHFFEFPD BAIMHJNEKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x59FF4B0", Offset = "0x59FE2B0", VA = "0x1859FF4B0")]
	private void DECADLLLIPL(IOMALNHJNIN JNKHFBAHKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5A00180", Offset = "0x59FEF80", VA = "0x185A00180")]
	private void PJMJHMGFKLO(string GINGNMFKHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x59FFEE0", Offset = "0x59FECE0", VA = "0x1859FFEE0")]
	private void DFHHFJMAHCG(FJKMANHHFOD EIBOGEAHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x59FFDF0", Offset = "0x59FEBF0", VA = "0x1859FFDF0")]
	private void DFHHFJMAHCG(GKOIEJHEIDJ EIBOGEAHMLA)
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
