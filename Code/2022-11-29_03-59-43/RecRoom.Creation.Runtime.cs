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
		[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B30FB0", Offset = "0x5B2FBB0", VA = "0x185B30FB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x812880", Offset = "0x811480", VA = "0x180812880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DGJDAOCCGJM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5B2F070", Offset = "0x5B2DC70", VA = "0x185B2F070")]
	public static bool BAJFMCBDJOE(KDCHGMPHEDI LAHHBALAAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5B2ECF0", Offset = "0x5B2D8F0", VA = "0x185B2ECF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x677F40", Offset = "0x676B40", VA = "0x180677F40")]
	public HPBCGCGCNFG(Dictionary<Guid, Guid> PFELEENFJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5B30950", Offset = "0x5B2F550", VA = "0x185B30950", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public KBMGEGHMFCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5B30AF0", Offset = "0x5B2F6F0", VA = "0x185B30AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public OGJEOPCPBEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5B31230", Offset = "0x5B2FE30", VA = "0x185B31230")]
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
	[Cpp2IlInjected.Address(RVA = "0x5B33820", Offset = "0x5B32420", VA = "0x185B33820")]
	public static GDHABDKIEPI HJPBIOOBEIM(MPGHGBNIKBA PPEOOCLEFHH, out NAGGOLHKOFC EHGGDIHDDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5B32900", Offset = "0x5B31500", VA = "0x185B32900")]
	private static void DLCGNODFCIN(GDHABDKIEPI HBHJDBLLCNA, out NAGGOLHKOFC EHGGDIHDDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5B35630", Offset = "0x5B34230", VA = "0x185B35630")]
	private static void PECNOPICEPF(IOMALNHJNIN CKBPBBLEPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5B35260", Offset = "0x5B33E60", VA = "0x185B35260")]
	private static void ONILCMPAPAK(GDHABDKIEPI HBHJDBLLCNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5B35550", Offset = "0x5B34150", VA = "0x185B35550")]
	private static void OPFMHCNENOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5B33DF0", Offset = "0x5B329F0", VA = "0x185B33DF0")]
	private static void KEDHKFJPMGG(ref MPGHGBNIKBA EDHOPHEMPEG, IOMALNHJNIN CKBPBBLEPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5B31250", Offset = "0x5B2FE50", VA = "0x185B31250")]
	public static bool ADBLOGDKMKK(GDHABDKIEPI HBHJDBLLCNA, AMLHKENPOOM POPNCNDDDHE, out HPBCGCGCNFG? ELEOOJOOOOE, out string? OMKDGOMBDIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5B33720", Offset = "0x5B32320", VA = "0x185B33720")]
	private static void HCFPCEKIKCF(GDHABDKIEPI HBHJDBLLCNA, ref AMLHKENPOOM POPNCNDDDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5B323B0", Offset = "0x5B30FB0", VA = "0x185B323B0")]
	private static void BAPHNBGFELN(GDHABDKIEPI HBHJDBLLCNA, ref AMLHKENPOOM POPNCNDDDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5B34C40", Offset = "0x5B33840", VA = "0x185B34C40")]
	private static bool NFBOIJOJCPJ(GDHABDKIEPI HBHJDBLLCNA, MIDGADGEHKB JDFOADDEDJH, ref AMLHKENPOOM POPNCNDDDHE, out string OMKDGOMBDIM, out Dictionary<int, int> CGCDKODCJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5B334A0", Offset = "0x5B320A0", VA = "0x185B334A0")]
	private static Dictionary<Guid, FJKFCNMMCGM> FOGLMGLDAPK(GDHABDKIEPI HBHJDBLLCNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5B33420", Offset = "0x5B32020", VA = "0x185B33420")]
	private static void FAKLMDLFLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5B32A30", Offset = "0x5B31630", VA = "0x185B32A30")]
	private static bool EMNDPJNECHJ(GDHABDKIEPI HBHJDBLLCNA, ref AMLHKENPOOM POPNCNDDDHE, out string? OMKDGOMBDIM, out KOPOMDKMEPE? CDBOIMLHINL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5B32870", Offset = "0x5B31470", VA = "0x185B32870")]
	private static void BILFELMNPIB(bool NCPANJEFEAO, IOMALNHJNIN JNKHFBAHKDD, Dictionary<Guid, Guid> AIMDNHFDIFM, KOPOMDKMEPE FPAICCDAGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5B32440", Offset = "0x5B31040", VA = "0x185B32440")]
	private static void BEIMMLMMLJF(bool NCPANJEFEAO, IOMALNHJNIN JNKHFBAHKDD, KOPOMDKMEPE CDBOIMLHINL, Guid CEDADLPHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5B31AD0", Offset = "0x5B306D0", VA = "0x185B31AD0")]
	private static void ALNOPMJIAID(IOMALNHJNIN JNKHFBAHKDD, Guid LGLFIOOGNBK, CGMNIONPKCM? JMHNBLNOCNP, Dictionary<Guid, FJKFCNMMCGM> DJIAOAEEDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5B33D00", Offset = "0x5B32900", VA = "0x185B33D00")]
	private static void JHFPDJEFJAB(IOMALNHJNIN JNKHFBAHKDD, Dictionary<Guid, Guid> AIMDNHFDIFM, Dictionary<int, int> JAMNEMJKJMM, MIDGADGEHKB BEEACFNHGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5B31D70", Offset = "0x5B30970", VA = "0x185B31D70")]
	public static void APKCAABDCOO(RepeatedField<IOMALNHJNIN> EGOAAIBNHOF, NPHPPBNGGPO OPHHKDCHKOD, IEnumerable<ByteString> BDFJPGMDHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5B34100", Offset = "0x5B32D00", VA = "0x185B34100")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B2DFD0", Offset = "0x5B2CBD0", VA = "0x185B2DFD0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static CGMNIONPKCM IHBPCONIFJA
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5B2E0D0", Offset = "0x5B2CCD0", VA = "0x185B2E0D0")]
		get
		{
			return default(CGMNIONPKCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool FEEOKLBEJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5B2D990", Offset = "0x5B2C590", VA = "0x185B2D990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x14338E0", Offset = "0x14324E0", VA = "0x1814338E0")]
	public CGMNIONPKCM(Vector3 DKGAADMNOOM, Quaternion MPLPNDNEAPK, float OLIFDPKHJEC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5B2E160", Offset = "0x5B2CD60", VA = "0x185B2E160")]
	public CGMNIONPKCM(FKDMNMHIPDD NKJDGEMJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5B2E100", Offset = "0x5B2CD00", VA = "0x185B2E100")]
	private CGMNIONPKCM(PHJPDGLHJOB ADHHMNEMEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5B2D9A0", Offset = "0x5B2C5A0", VA = "0x185B2D9A0")]
	public static CGMNIONPKCM EGCMHGAOFKA(NAKBKBNHOJA NCDJEOADDGN)
	{
		return default(CGMNIONPKCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5B2DBA0", Offset = "0x5B2C7A0", VA = "0x185B2DBA0")]
	public static CGMNIONPKCM FOINCCODCHN(CGMNIONPKCM GEOFAMNLJNK, CGMNIONPKCM DCGPNPLAHJN)
	{
		return default(CGMNIONPKCM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5B2DE80", Offset = "0x5B2CA80", VA = "0x185B2DE80")]
	public static CGMNIONPKCM KPOCFOKDNEC((Vector3, Quaternion, float) JLFCOOGLPMP)
	{
		return default(CGMNIONPKCM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5B2DED0", Offset = "0x5B2CAD0", VA = "0x185B2DED0")]
	public static CGMNIONPKCM KPOCFOKDNEC(Matrix4x4 CILJFPGFCGB)
	{
		return default(CGMNIONPKCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5B2DCF0", Offset = "0x5B2C8F0", VA = "0x185B2DCF0")]
	public CGMNIONPKCM GJIMHEMKKGJ(Matrix4x4 KAMDPLLJPAH)
	{
		return default(CGMNIONPKCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5B2D9D0", Offset = "0x5B2C5D0", VA = "0x185B2D9D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5B2E340", Offset = "0x5B2CF40", VA = "0x185B2E340", Slot = "4")]
	public void GNIKIHCOJDM(PGIHPGMJIBC EBPICBHIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5B2E3F0", Offset = "0x5B2CFF0", VA = "0x185B2E3F0")]
	private void JMPDCCHCLKH(Dictionary<Guid, Guid> KHLGMDKEEIE, FNPEPAAPKPF FOBGKHBPJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5B2E920", Offset = "0x5B2D520", VA = "0x185B2E920")]
	private void JMPDCCHCLKH(Dictionary<Guid, Guid> KHLGMDKEEIE, CDPKODPCCJO GLEKDCELHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5B2E980", Offset = "0x5B2D580", VA = "0x185B2E980")]
	private void JMPDCCHCLKH(Dictionary<Guid, Guid> KHLGMDKEEIE, LPELGDNLOCK DBAPFFFDBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public CKICBBDBKGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class CHCDBAFCKAF : CPEKFIMFIOK
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5B2E280", Offset = "0x5B2CE80", VA = "0x185B2E280", Slot = "4")]
	public void GNIKIHCOJDM(PGIHPGMJIBC EBPICBHIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public CHCDBAFCKAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class GPDCIOBOLOO : CPEKFIMFIOK
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5B307E0", Offset = "0x5B2F3E0", VA = "0x185B307E0", Slot = "4")]
	public void GNIKIHCOJDM(PGIHPGMJIBC EBPICBHIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public GPDCIOBOLOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class JLHINEDAJNM : CPEKFIMFIOK
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5B309A0", Offset = "0x5B2F5A0", VA = "0x185B309A0", Slot = "4")]
	public void GNIKIHCOJDM(PGIHPGMJIBC EBPICBHIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public JLHINEDAJNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class GHLFIONOKOH : CPEKFIMFIOK
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5B30400", Offset = "0x5B2F000", VA = "0x185B30400", Slot = "4")]
	public void GNIKIHCOJDM(PGIHPGMJIBC EBPICBHIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public GHLFIONOKOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class KEBEPBAHDJH : CPEKFIMFIOK
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5B30B40", Offset = "0x5B2F740", VA = "0x185B30B40", Slot = "4")]
	public void GNIKIHCOJDM(PGIHPGMJIBC EBPICBHIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public KEBEPBAHDJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class OBHAPIPBCFJ : CPEKFIMFIOK
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5B31040", Offset = "0x5B2FC40", VA = "0x185B31040", Slot = "4")]
	public void GNIKIHCOJDM(PGIHPGMJIBC EBPICBHIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public OBHAPIPBCFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class KGNKMBENKAM : CPEKFIMFIOK
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5B30CC0", Offset = "0x5B2F8C0", VA = "0x185B30CC0", Slot = "4")]
	public void GNIKIHCOJDM(PGIHPGMJIBC EBPICBHIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public KGNKMBENKAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class GICKDEPBPFC : CPEKFIMFIOK
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5B30610", Offset = "0x5B2F210", VA = "0x185B30610", Slot = "4")]
	public void GNIKIHCOJDM(PGIHPGMJIBC EBPICBHIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public GICKDEPBPFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class NKNOJIPDPGP : CPEKFIMFIOK
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5B30DE0", Offset = "0x5B2F9E0", VA = "0x185B30DE0", Slot = "4")]
	public void GNIKIHCOJDM(PGIHPGMJIBC EBPICBHIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public NKNOJIPDPGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class CMLFIENGHIM : CPEKFIMFIOK
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5B2EBD0", Offset = "0x5B2D7D0", VA = "0x185B2EBD0", Slot = "4")]
	public void GNIKIHCOJDM(PGIHPGMJIBC EBPICBHIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x5B2D850", Offset = "0x5B2C450", VA = "0x185B2D850", Slot = "4")]
	public void GNIKIHCOJDM(PGIHPGMJIBC EBPICBHIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x5B2CE10", Offset = "0x5B2BA10", VA = "0x185B2CE10")]
	public static void LAHDMEOOOJI(IOMALNHJNIN JLFCOOGLPMP, Dictionary<Guid, Guid> HEKNGPHBFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5B2D020", Offset = "0x5B2BC20", VA = "0x185B2D020")]
	public static void MJMDDNDHAGG(IOMALNHJNIN? JLFCOOGLPMP, KOPOMDKMEPE FPAICCDAGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5B2CAB0", Offset = "0x5B2B6B0", VA = "0x185B2CAB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5B35990", Offset = "0x5B34590", VA = "0x185B35990")]
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
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<long, int> GMOCIFLCEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5B2FFB0", Offset = "0x5B2EBB0", VA = "0x185B2FFB0")]
	public static FICOJGDGHKG GGMDLNPDCLC(IFHIAHJKMIE CGNEHNOPJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5B2F0B0", Offset = "0x5B2DCB0", VA = "0x185B2F0B0")]
	public static FICOJGDGHKG AADDJLMMDNC(GDHABDKIEPI FFMODCDFCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5B30020", Offset = "0x5B2EC20", VA = "0x185B30020")]
	public static FICOJGDGHKG HJCHIPNAMFF(IEnumerable<string> MDACLBKPEBM, IDictionary<long, int> NIBECMCJKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5B301E0", Offset = "0x5B2EDE0", VA = "0x185B301E0")]
	private FICOJGDGHKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5B302E0", Offset = "0x5B2EEE0", VA = "0x185B302E0")]
	private FICOJGDGHKG(IEnumerable<string> MDACLBKPEBM, IDictionary<long, int> NIBECMCJKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5B2F2E0", Offset = "0x5B2DEE0", VA = "0x185B2F2E0")]
	private void DECADLLLIPL(IFHIAHJKMIE CGNEHNOPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5B2F120", Offset = "0x5B2DD20", VA = "0x185B2F120")]
	private void DECADLLLIPL(GDHABDKIEPI FFMODCDFCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5B2F850", Offset = "0x5B2E450", VA = "0x185B2F850")]
	private void DECADLLLIPL(NPHPPBNGGPO MHPJOFNEKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5B2FC70", Offset = "0x5B2E870", VA = "0x185B2FC70")]
	private void DECADLLLIPL(MBPFHFFEFPD BAIMHJNEKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5B2F4A0", Offset = "0x5B2E0A0", VA = "0x185B2F4A0")]
	private void DECADLLLIPL(IOMALNHJNIN JNKHFBAHKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5B30170", Offset = "0x5B2ED70", VA = "0x185B30170")]
	private void PJMJHMGFKLO(string GINGNMFKHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5B2FED0", Offset = "0x5B2EAD0", VA = "0x185B2FED0")]
	private void DFHHFJMAHCG(FJKMANHHFOD EIBOGEAHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5B2FDE0", Offset = "0x5B2E9E0", VA = "0x185B2FDE0")]
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
