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
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D02EC0", Offset = "0x5D018C0", VA = "0x185D02EC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x90B660", Offset = "0x90A060", VA = "0x18090B660")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AGJJAIMNGOM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5CFAEF0", Offset = "0x5CF98F0", VA = "0x185CFAEF0")]
	public static bool OMFFPJCKLOB(OFKBOPOKNBK AAMMKEOABJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5CFAB70", Offset = "0x5CF9570", VA = "0x185CFAB70")]
	private static bool OMFFPJCKLOB(ECFNNHBBONE GOADIACIEED, ref OFKBOPOKNBK AAMMKEOABJI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct CCEAFEHDGKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public List<AOGDKFHKIOB> GBHFBBGFGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public IEnumerable<AEECCIKBHNN> KCENOKOINOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public JOILGBHBGGK JHNPPHEBDNI;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KDMOGCADHEH
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(BBNBEHFLGEN NIPBPKPBPPP, out Dictionary<int, int> AHCDHPJKDAK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(GMCHMPCDOOP NMHLAABNACN, FHEPFOPDMBN LKCPBAPANNN);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface MHPECEBPCDA
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
public sealed class JIDJFPCEMEG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<Guid, Guid> AOKNDJCBOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<Guid, Guid> MBHCIGLCBNN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<Guid, Guid> KCJJFBAEFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6C16E0", Offset = "0x6C00E0", VA = "0x1806C16E0")]
	public JIDJFPCEMEG(Dictionary<Guid, Guid> AOKNDJCBOEP, Dictionary<Guid, Guid> MBHCIGLCBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D02A50", Offset = "0x5D01450", VA = "0x185D02A50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class DLGKAHIPGNF
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class LHMCCGDBEIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly HashSet<AEECCIKBHNN> NIAMLKCEHOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly HashSet<GNPBFPJLIFO> CCFAAFNGBMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly List<HAKOPFKFELN> FOBPIHIKACA;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5D02AB0", Offset = "0x5D014B0", VA = "0x185D02AB0")]
		public LHMCCGDBEIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class BIGPMLEGJNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public GNPBFPJLIFO destinationGraph;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public BIGPMLEGJNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5CFC750", Offset = "0x5CFB150", VA = "0x185CFC750")]
		internal bool <InitializeCircuitsV2Remapping>b__0(ANJLMEIFBPP n)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class INPHOHDNGKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int mpif;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public INPHOHDNGKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5D02A30", Offset = "0x5D01430", VA = "0x185D02A30")]
		internal void <InitializeCircuitsV2Remapping>b__1(ANJLMEIFBPP n)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5D01D30", Offset = "0x5D00730", VA = "0x185D01D30")]
	public static NBBPINOPKLK OCCPJOJKPGB(CCEAFEHDGKL FCJLDJEMLMG, out LFCGCIIAOKP PDKGMFJDACH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D01870", Offset = "0x5D00270", VA = "0x185D01870")]
	private static void NKGDIPLLFMJ(NBBPINOPKLK HCDIJOAAFHL, LHMCCGDBEIP INDMHIHFIFE, out LFCGCIIAOKP PDKGMFJDACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5D01970", Offset = "0x5D00370", VA = "0x185D01970")]
	private static void NKMJMDBJMOI(AOGDKFHKIOB PGJOFPGCNFO, LHMCCGDBEIP INDMHIHFIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE3D0", Offset = "0x5CFCDD0", VA = "0x185CFE3D0")]
	private static void EHCGAIGMHLF(NBBPINOPKLK HCDIJOAAFHL, LHMCCGDBEIP INDMHIHFIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D00DB0", Offset = "0x5CFF7B0", VA = "0x185D00DB0")]
	private static void LEMMIBILKIG(ref CCEAFEHDGKL BCDPHKIBHNK, LHMCCGDBEIP INDMHIHFIFE, AOGDKFHKIOB PGJOFPGCNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D01070", Offset = "0x5CFFA70", VA = "0x185D01070")]
	public static bool LLMHMDKOEII(NBBPINOPKLK HCDIJOAAFHL, JKBFHPHDHIF AAEODKBPNIF, out JIDJFPCEMEG? HECPADGLFHI, out string? IMHLNJJFNDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE2B0", Offset = "0x5CFCCB0", VA = "0x185CFE2B0")]
	private static void DFPFPHHFKCA(NBBPINOPKLK HCDIJOAAFHL, ref JKBFHPHDHIF AAEODKBPNIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF780", Offset = "0x5CFE180", VA = "0x185CFF780")]
	public static Dictionary<Guid, Guid> IAKKNDONIOO(IEnumerable<AOGDKFHKIOB> EPLKCGLLNNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5D01830", Offset = "0x5D00230", VA = "0x185D01830")]
	private static void NILBEGODBLE(NBBPINOPKLK HCDIJOAAFHL, ref JKBFHPHDHIF AAEODKBPNIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF160", Offset = "0x5CFDB60", VA = "0x185CFF160")]
	private static bool FMLMOMIBGDL(NBBPINOPKLK HCDIJOAAFHL, GMCHMPCDOOP NMHLAABNACN, ref JKBFHPHDHIF AAEODKBPNIF, out string IMHLNJJFNDD, out Dictionary<int, int> AHCDHPJKDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5D000A0", Offset = "0x5CFEAA0", VA = "0x185D000A0")]
	private static Dictionary<Guid, ECFNNHBBONE> KNDJOMGOLJL(NBBPINOPKLK HCDIJOAAFHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D00310", Offset = "0x5CFED10", VA = "0x185D00310")]
	private static bool LCEBMGHCHNC(NBBPINOPKLK HCDIJOAAFHL, ref JKBFHPHDHIF AAEODKBPNIF, out string? IMHLNJJFNDD, out JNOCGEHCKBI? MIPNPALJHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDDF0", Offset = "0x5CFC7F0", VA = "0x185CFDDF0")]
	private static void CHAPHGPACKI(bool ECCJNGOKONP, AOGDKFHKIOB GDCPPPKHAKB, Dictionary<Guid, Guid> CKKOEOJPMMO, JNOCGEHCKBI IELODPICJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDE80", Offset = "0x5CFC880", VA = "0x185CFDE80")]
	private static void CPKENKCECBG(bool ECCJNGOKONP, AOGDKFHKIOB GDCPPPKHAKB, JNOCGEHCKBI MIPNPALJHFN, Guid JPLEMBLFNMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D01A90", Offset = "0x5D00490", VA = "0x185D01A90")]
	private static void NPGANKDEGFA(AOGDKFHKIOB GDCPPPKHAKB, Guid JONJKHCILAO, PIDGNIMDAKO? MEAKKHBCBOJ, Dictionary<Guid, ECFNNHBBONE> FNCDMHECACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDD00", Offset = "0x5CFC700", VA = "0x185CFDD00")]
	private static void ANHDBEHFOPB(AOGDKFHKIOB GDCPPPKHAKB, Dictionary<Guid, Guid> CKKOEOJPMMO, Dictionary<int, int> PAJKPBJJIIB, GMCHMPCDOOP FCLNMKCKMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5CFFA60", Offset = "0x5CFE460", VA = "0x185CFFA60")]
	public static void IJKCBGNEMEO(RepeatedField<AOGDKFHKIOB> JAPGCGEOKMP, LOJAAHDBCNF FIBBDFPKLDG, IEnumerable<ByteString> PDLJBDJMNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE670", Offset = "0x5CFD070", VA = "0x185CFE670")]
	private static void FBKNKCDDDLB(RepeatedField<AOGDKFHKIOB> JAPGCGEOKMP, PGADFGLCKBB LHBNGIMIDHK, MHPECEBPCDA AENHIAKCEJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct JKBFHPHDHIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool ECCJNGOKONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public bool PLDFHNJKGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public PIDGNIMDAKO? MEAKKHBCBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public PIDGNIMDAKO? KIEIGOBAMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public MNOJOICKPLP CMBCAAEINFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public MHPECEBPCDA AENHIAKCEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public KDMOGCADHEH AOCFLAIEHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public Guid JPLEMBLFNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public JOILGBHBGGK JHNPPHEBDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public List<AOGDKFHKIOB> EKJDEILIHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public Dictionary<string, object> MPPNICBKGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public GLCFNFAOKOD HBGOGJIAEAL;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct PIDGNIMDAKO
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private const float DOOILNHCJMC = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Vector3 OAALNDIAAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Quaternion HOOCPOKGFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float HKGHFAPJIOG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Matrix4x4 FALHLFFJENA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5D03660", Offset = "0x5D02060", VA = "0x185D03660")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x12D02B0", Offset = "0x12CECB0", VA = "0x1812D02B0")]
	public PIDGNIMDAKO(Vector3 OAALNDIAAOB, Quaternion HOOCPOKGFMC, float HKGHFAPJIOG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D03760", Offset = "0x5D02160", VA = "0x185D03760")]
	public PIDGNIMDAKO(APINOGCIAPK HIAJEILGIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D03830", Offset = "0x5D02230", VA = "0x185D03830")]
	private PIDGNIMDAKO(FPPDJECAHPL CHMCOEODPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D034A0", Offset = "0x5D01EA0", VA = "0x185D034A0")]
	public static PIDGNIMDAKO GJCFMIHGNNK(AEECCIKBHNN CFFHBHIOLOH)
	{
		return default(PIDGNIMDAKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D02F50", Offset = "0x5D01950", VA = "0x185D02F50")]
	public static PIDGNIMDAKO BCGIPLFDOGB(PIDGNIMDAKO ELGBIOMPEHN, PIDGNIMDAKO CHDLLHPMGEM)
	{
		return default(PIDGNIMDAKO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5D03350", Offset = "0x5D01D50", VA = "0x185D03350")]
	public static PIDGNIMDAKO EGMKMIPNLBF((Vector3, Quaternion, float) NIPBPKPBPPP)
	{
		return default(PIDGNIMDAKO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5D033A0", Offset = "0x5D01DA0", VA = "0x185D033A0")]
	public static PIDGNIMDAKO EGMKMIPNLBF(Matrix4x4 JFONFHJDEEO)
	{
		return default(PIDGNIMDAKO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5D034D0", Offset = "0x5D01ED0", VA = "0x185D034D0")]
	public PIDGNIMDAKO GMKNKJEKCGE(Matrix4x4 CLHKPCIOCGF)
	{
		return default(PIDGNIMDAKO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5D030A0", Offset = "0x5D01AA0", VA = "0x185D030A0")]
	public static PIDGNIMDAKO BDKOHEAGPLO(Vector3 OAALNDIAAOB)
	{
		return default(PIDGNIMDAKO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5D030F0", Offset = "0x5D01AF0", VA = "0x185D030F0")]
	[CompilerGenerated]
	internal static PIDGNIMDAKO DGGOLGDHKNE(AEECCIKBHNN MMAGBLNBOEG)
	{
		return default(PIDGNIMDAKO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class BIBNMNEHGMP : HLNMDMCMLPB
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC6A0", Offset = "0x5CFB0A0", VA = "0x185CFC6A0", Slot = "4")]
	public void OCJNMDJFIEB(NAIILLHDKJG CEDKCIJAMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5CFBF20", Offset = "0x5CFA920", VA = "0x185CFBF20")]
	private void MAONKPMHIBC(Dictionary<Guid, Guid> CEDNDPKACKH, AKGGBIICEFI BAADGNJCCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5CFBEC0", Offset = "0x5CFA8C0", VA = "0x185CFBEC0")]
	private void MAONKPMHIBC(Dictionary<Guid, Guid> CEDNDPKACKH, INKMOKNGBEK DDEGJGOFONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC450", Offset = "0x5CFAE50", VA = "0x185CFC450")]
	private void MAONKPMHIBC(Dictionary<Guid, Guid> CEDNDPKACKH, KABHKJMJAMP ANLEOAPONLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public BIBNMNEHGMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class EGLAKFECOBH : HLNMDMCMLPB
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5D02360", Offset = "0x5D00D60", VA = "0x185D02360", Slot = "4")]
	public void OCJNMDJFIEB(NAIILLHDKJG CEDKCIJAMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public EGLAKFECOBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class GHIHFGPMHGM : HLNMDMCMLPB
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5D025F0", Offset = "0x5D00FF0", VA = "0x185D025F0", Slot = "4")]
	public void OCJNMDJFIEB(NAIILLHDKJG CEDKCIJAMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public GHIHFGPMHGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class GPGDNEEPJNO : HLNMDMCMLPB
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5D028E0", Offset = "0x5D012E0", VA = "0x185D028E0", Slot = "4")]
	public void OCJNMDJFIEB(NAIILLHDKJG CEDKCIJAMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public GPGDNEEPJNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class DDDPPAPNIJM : HLNMDMCMLPB
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC7A0", Offset = "0x5CFB1A0", VA = "0x185CFC7A0", Slot = "4")]
	public void OCJNMDJFIEB(NAIILLHDKJG CEDKCIJAMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public DDDPPAPNIJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class GPFFHGEKPIL : HLNMDMCMLPB
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5D02760", Offset = "0x5D01160", VA = "0x185D02760", Slot = "4")]
	public void OCJNMDJFIEB(NAIILLHDKJG CEDKCIJAMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public GPFFHGEKPIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class BGNIHEMCHMF : HLNMDMCMLPB
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5CFBCD0", Offset = "0x5CFA6D0", VA = "0x185CFBCD0", Slot = "4")]
	public void OCJNMDJFIEB(NAIILLHDKJG CEDKCIJAMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public BGNIHEMCHMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class LJEIHLGMOFG : HLNMDMCMLPB
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5D02BB0", Offset = "0x5D015B0", VA = "0x185D02BB0", Slot = "4")]
	public void OCJNMDJFIEB(NAIILLHDKJG CEDKCIJAMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public LJEIHLGMOFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class GGPGPDOAPEL : HLNMDMCMLPB
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5D02420", Offset = "0x5D00E20", VA = "0x185D02420", Slot = "4")]
	public void OCJNMDJFIEB(NAIILLHDKJG CEDKCIJAMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public GGPGPDOAPEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class PKAAHNKIPOE : HLNMDMCMLPB
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5D038F0", Offset = "0x5D022F0", VA = "0x185D038F0", Slot = "4")]
	public void OCJNMDJFIEB(NAIILLHDKJG CEDKCIJAMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public PKAAHNKIPOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class LJKOPDPJCNB : HLNMDMCMLPB
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5D02CD0", Offset = "0x5D016D0", VA = "0x185D02CD0", Slot = "4")]
	public void OCJNMDJFIEB(NAIILLHDKJG CEDKCIJAMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public LJKOPDPJCNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class AFGAEFOMEAD : HLNMDMCMLPB
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly System.Random MKMDICDEECC;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5CFAA30", Offset = "0x5CF9430", VA = "0x185CFAA30", Slot = "4")]
	public void OCJNMDJFIEB(NAIILLHDKJG CEDKCIJAMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public AFGAEFOMEAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct OFKBOPOKNBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public GMCHMPCDOOP FMHBAJCDDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public GJKMJOMCFOL OBKPCFJOMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Dictionary<int, int> PAJKPBJJIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Dictionary<Guid, Guid> MIAPCBGKBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public GLCFNFAOKOD HBGOGJIAEAL;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface HLNMDMCMLPB
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCJNMDJFIEB(NAIILLHDKJG CEDKCIJAMLL);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BADCNDGCGDN
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly HLNMDMCMLPB[] CKBLFPNGKLB;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5CFAF30", Offset = "0x5CF9930", VA = "0x185CFAF30")]
	public static void EPGGLKADBBB(AOGDKFHKIOB NIPBPKPBPPP, Dictionary<Guid, Guid> ELCOPNCEOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5CFB140", Offset = "0x5CF9B40", VA = "0x185CFB140")]
	public static void KFKHKPDHJLN(AOGDKFHKIOB? NIPBPKPBPPP, JNOCGEHCKBI IELODPICJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5CFB330", Offset = "0x5CF9D30", VA = "0x185CFB330")]
	public static void OMFFPJCKLOB(NAIILLHDKJG CEDKCIJAMLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct NAIILLHDKJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public GMCHMPCDOOP FIJOABBJGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public AOGDKFHKIOB GDCPPPKHAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Dictionary<int, int> PAJKPBJJIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Dictionary<Guid, Guid> MIAPCBGKBGD;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5D02DF0", Offset = "0x5D017F0", VA = "0x185D02DF0")]
	public Guid PKOCEAIJBAA(Guid CKAFGMOJCKA)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface GLCFNFAOKOD
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int FBLKIJLAAFL, out Guid OKMCPDOLCNG);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class DJONLHOLBOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<string> MIBLKNJPBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<long, int> JPCNDCDHMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<Guid> EBEGEEFHNMM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyCollection<string> MLPIKHALCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<long, int> LGHDCHEOIIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5CFCA20", Offset = "0x5CFB420", VA = "0x185CFCA20")]
	public static DJONLHOLBOA GOAILFMBCLJ(NNPMFHIGJPA FGCBFOCODMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC9B0", Offset = "0x5CFB3B0", VA = "0x185CFC9B0")]
	public static DJONLHOLBOA GJDCKIPDKAD(NBBPINOPKLK GKCOMFANAGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5CFCC60", Offset = "0x5CFB660", VA = "0x185CFCC60")]
	public static DJONLHOLBOA NOAECJAMOMB(IEnumerable<string> MIBLKNJPBBH, IDictionary<long, int> KGDCOAHPIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDC00", Offset = "0x5CFC600", VA = "0x185CFDC00")]
	private DJONLHOLBOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDAE0", Offset = "0x5CFC4E0", VA = "0x185CFDAE0")]
	private DJONLHOLBOA(IEnumerable<string> MIBLKNJPBBH, IDictionary<long, int> KGDCOAHPIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5CFD240", Offset = "0x5CFBC40", VA = "0x185CFD240")]
	private void PONBNDGDEDL(NNPMFHIGJPA FGCBFOCODMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5CFD920", Offset = "0x5CFC320", VA = "0x185CFD920")]
	private void PONBNDGDEDL(NBBPINOPKLK GKCOMFANAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5CFCE20", Offset = "0x5CFB820", VA = "0x185CFCE20")]
	private void PONBNDGDEDL(LOJAAHDBCNF? OFMDHDILEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5CFD7B0", Offset = "0x5CFC1B0", VA = "0x185CFD7B0")]
	private void PONBNDGDEDL(ANJLMEIFBPP? MMAGBLNBOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5CFD400", Offset = "0x5CFBE00", VA = "0x185CFD400")]
	private void PONBNDGDEDL(AOGDKFHKIOB? GDCPPPKHAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5CFCDB0", Offset = "0x5CFB7B0", VA = "0x185CFCDB0")]
	private void OEEKLFNJPAE(string? PANFCKCMCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5CFCB80", Offset = "0x5CFB580", VA = "0x185CFCB80")]
	private void IGOCJDABFAN(EJBGBEKDBLL? IAOGBLDJOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5CFCA90", Offset = "0x5CFB490", VA = "0x185CFCA90")]
	private void IGOCJDABFAN(FGGMDFBHKLD? IAOGBLDJOFN)
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
