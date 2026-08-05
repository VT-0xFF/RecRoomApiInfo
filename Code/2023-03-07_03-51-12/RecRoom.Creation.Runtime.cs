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
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5EC4AA0", Offset = "0x5EC3EA0", VA = "0x185EC4AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xFCBE90", Offset = "0xFCB290", VA = "0x180FCBE90")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FCAPOHELIHM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1CE0", Offset = "0x5EC10E0", VA = "0x185EC1CE0")]
	public static bool NFDHPKGOBPD(JLBIPNOPGLG JPHEJNDKFED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1960", Offset = "0x5EC0D60", VA = "0x185EC1960")]
	private static bool NFDHPKGOBPD(GBBGOGPEHHL GEAFCDFAEKF, ref JLBIPNOPGLG JPHEJNDKFED)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct BJCHBGIFKFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public List<GNAMCHKIIOD> DPCAAECLMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public IEnumerable<KEKJBJJNDCN> AEDKAEKDPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public LBNEFPAOOEG IFFOGMONKEC;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BDHBFGDAOBA
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(EHHDDAOBJNI MPEBBGJJODN, out Dictionary<int, int> POBEELIOIBJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(KGPBGDOCNHG KCOGPKEAOGH, NOIDEPBJCPM BGLPFILOKPP);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GGFADILLAFD
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
public sealed class OBBOBNCMCEE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<Guid, Guid> LIDNCFFHLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<Guid, Guid> JJLPDPJOAEA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<Guid, Guid> LLNGPHANLGH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x77E010", Offset = "0x77D410", VA = "0x18077E010")]
	public OBBOBNCMCEE(Dictionary<Guid, Guid> LIDNCFFHLPK, Dictionary<Guid, Guid> JJLPDPJOAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC4B30", Offset = "0x5EC3F30", VA = "0x185EC4B30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class EOICBKEDOLN
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class KLOOGMOGFPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly HashSet<KEKJBJJNDCN> KCLEOFACNNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly HashSet<HILIJJNKDBF> NBDLPHLJABK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly List<JDPIECFPAKB> DJHNCBOBCMC;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5EC3ED0", Offset = "0x5EC32D0", VA = "0x185EC3ED0")]
		public KLOOGMOGFPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class CAFNPPPABFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public HILIJJNKDBF destinationGraph;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public CAFNPPPABFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5EBD120", Offset = "0x5EBC520", VA = "0x185EBD120")]
		internal bool <InitializeCircuitsV2Remapping>b__0(FGFKNNAOODI n)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class DHPJKGEHKHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int mpif;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public DHPJKGEHKHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5EBD170", Offset = "0x5EBC570", VA = "0x185EBD170")]
		internal void <InitializeCircuitsV2Remapping>b__1(FGFKNNAOODI n)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0260", Offset = "0x5EBF660", VA = "0x185EC0260")]
	public static AILLEBLLAIC JMHGEOMOJAD(BJCHBGIFKFK JJBMHAOLIIB, out PGJDIHIDEDH CAIJNEDMIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0890", Offset = "0x5EBFC90", VA = "0x185EC0890")]
	private static void KILMEDHOCPI(AILLEBLLAIC DDDFJFGELLI, KLOOGMOGFPI OPAONHCAKMI, out PGJDIHIDEDH CAIJNEDMIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF490", Offset = "0x5EBE890", VA = "0x185EBF490")]
	private static void EOLPFJLMOFL(GNAMCHKIIOD CAJCHKIGDNA, KLOOGMOGFPI OPAONHCAKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0990", Offset = "0x5EBFD90", VA = "0x185EC0990")]
	private static void KIPHOMKOHAM(AILLEBLLAIC DDDFJFGELLI, KLOOGMOGFPI OPAONHCAKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5EBDDA0", Offset = "0x5EBD1A0", VA = "0x185EBDDA0")]
	private static void ALJMFILLFGD(ref BJCHBGIFKFK NOKPGHCGAOL, KLOOGMOGFPI OPAONHCAKMI, GNAMCHKIIOD CAJCHKIGDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF5B0", Offset = "0x5EBE9B0", VA = "0x185EBF5B0")]
	public static bool HAMLINJCHKA(AILLEBLLAIC DDDFJFGELLI, KAIDODHAOMC OILGDPNJMPJ, out OBBOBNCMCEE? LPALIOHBCCD, out string? MCGMECECHJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5EBFD70", Offset = "0x5EBF170", VA = "0x185EBFD70")]
	private static void IAFPKEEOKAD(AILLEBLLAIC DDDFJFGELLI, ref KAIDODHAOMC OILGDPNJMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5EBFF80", Offset = "0x5EBF380", VA = "0x185EBFF80")]
	public static Dictionary<Guid, Guid> JFHPPBHBJHL(IEnumerable<GNAMCHKIIOD> OHCLACGDOLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1920", Offset = "0x5EC0D20", VA = "0x185EC1920")]
	private static void PIPNNHOHINJ(AILLEBLLAIC DDDFJFGELLI, ref KAIDODHAOMC OILGDPNJMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0CC0", Offset = "0x5EC00C0", VA = "0x185EC0CC0")]
	private static bool LEFPBLCCBPN(AILLEBLLAIC DDDFJFGELLI, KGPBGDOCNHG KCOGPKEAOGH, ref KAIDODHAOMC OILGDPNJMPJ, out string MCGMECECHJK, out Dictionary<int, int> POBEELIOIBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5EBE060", Offset = "0x5EBD460", VA = "0x185EBE060")]
	private static Dictionary<Guid, GBBGOGPEHHL> AMCAKDBPPGE(AILLEBLLAIC DDDFJFGELLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD300", Offset = "0x5EBC700", VA = "0x185EBD300")]
	private static bool AFNOEEEENAE(AILLEBLLAIC DDDFJFGELLI, ref KAIDODHAOMC OILGDPNJMPJ, out string? MCGMECECHJK, out LPMAMEAOANG? OCNLIHALGEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0C30", Offset = "0x5EC0030", VA = "0x185EC0C30")]
	private static void LCJAJGKIJAE(bool NHCGOOAIBNA, GNAMCHKIIOD FCEBLLIOAFD, Dictionary<Guid, Guid> NCOEBPMKLNK, LPMAMEAOANG LHMJMMCMGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF060", Offset = "0x5EBE460", VA = "0x185EBF060")]
	private static void DKGOJLGGCMC(bool NHCGOOAIBNA, GNAMCHKIIOD FCEBLLIOAFD, LPMAMEAOANG OCNLIHALGEF, Guid LPBMJIIFALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5EBE2D0", Offset = "0x5EBD6D0", VA = "0x185EBE2D0")]
	private static void BHODDPFNCIL(GNAMCHKIIOD FCEBLLIOAFD, Guid CEPMBHGJAFC, HPHICACFKBD? AFCGLCPLLEA, Dictionary<Guid, GBBGOGPEHHL> PLALCLJLNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5EBFE90", Offset = "0x5EBF290", VA = "0x185EBFE90")]
	private static void ICNIGCALILJ(GNAMCHKIIOD FCEBLLIOAFD, Dictionary<Guid, Guid> NCOEBPMKLNK, Dictionary<int, int> MAEBHDMNIIG, KGPBGDOCNHG JLKPNOCAEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC12E0", Offset = "0x5EC06E0", VA = "0x185EC12E0")]
	public static void MLEAGGOJBCG(RepeatedField<GNAMCHKIIOD> MAGFMFDPLLK, OFDCGEHNHLK FNNKMDOCGOG, IEnumerable<ByteString> EKJAGPFLOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5EBE570", Offset = "0x5EBD970", VA = "0x185EBE570")]
	private static void BJLDPEBEJDL(RepeatedField<GNAMCHKIIOD> MAGFMFDPLLK, PFLFDKAPPIL HNHDGIDGPGB, GGFADILLAFD PHMIGPAJBBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct KAIDODHAOMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool NHCGOOAIBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public bool PAOMPJFCLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public HPHICACFKBD? AFCGLCPLLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public HPHICACFKBD? OFJLCFEHLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public FCPPACOGGJF ONIIICHEOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public GGFADILLAFD PHMIGPAJBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public BDHBFGDAOBA MOLGBOFOKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public Guid LPBMJIIFALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public LBNEFPAOOEG IFFOGMONKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public List<GNAMCHKIIOD> KEELJKAFALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public Dictionary<string, object> POKIPOOCJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public FKOPNBAMHPF LFIHAOLIHJL;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct HPHICACFKBD
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private const float IBBFGEEPNBF = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Vector3 KGJPEGOHADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Quaternion GCFIGFMOIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float AIBLENCNPFJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Matrix4x4 GKOOIGJDBEK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5EC3490", Offset = "0x5EC2890", VA = "0x185EC3490")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1DA3940", Offset = "0x1DA2D40", VA = "0x181DA3940")]
	public HPHICACFKBD(Vector3 KGJPEGOHADA, Quaternion GCFIGFMOIAL, float AIBLENCNPFJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5EC3A40", Offset = "0x5EC2E40", VA = "0x185EC3A40")]
	public HPHICACFKBD(ENLNGJKIKCL LKLONBPEMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5EC3980", Offset = "0x5EC2D80", VA = "0x185EC3980")]
	private HPHICACFKBD(JIKDMCLAKIO DPIDMPHMAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5EC3460", Offset = "0x5EC2860", VA = "0x185EC3460")]
	public static HPHICACFKBD KFNFGDMNGIA(KEKJBJJNDCN DMMJLCLFJGK)
	{
		return default(HPHICACFKBD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5EC32C0", Offset = "0x5EC26C0", VA = "0x185EC32C0")]
	public static HPHICACFKBD BIEHAODKPCP(HPHICACFKBD CNDFBGEJOLI, HPHICACFKBD NCALJJJJDDM)
	{
		return default(HPHICACFKBD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC3270", Offset = "0x5EC2670", VA = "0x185EC3270")]
	public static HPHICACFKBD ABLJGBEPCFM((Vector3, Quaternion, float) MPEBBGJJODN)
	{
		return default(HPHICACFKBD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC3170", Offset = "0x5EC2570", VA = "0x185EC3170")]
	public static HPHICACFKBD ABLJGBEPCFM(Matrix4x4 LBHBFKEBLLM)
	{
		return default(HPHICACFKBD);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC37F0", Offset = "0x5EC2BF0", VA = "0x185EC37F0")]
	public HPHICACFKBD NMJBCJADNOF(Matrix4x4 GCKJJOINBCJ)
	{
		return default(HPHICACFKBD);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC3410", Offset = "0x5EC2810", VA = "0x185EC3410")]
	public static HPHICACFKBD JAGEFHFOLBD(Vector3 KGJPEGOHADA)
	{
		return default(HPHICACFKBD);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC3590", Offset = "0x5EC2990", VA = "0x185EC3590")]
	[CompilerGenerated]
	internal static HPHICACFKBD NEPMMCBMAPA(KEKJBJJNDCN HLJLMLNJBJM)
	{
		return default(HPHICACFKBD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class KNFMGGOADLO : PAKKCHFHLCN
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5EC47B0", Offset = "0x5EC3BB0", VA = "0x185EC47B0", Slot = "4")]
	public void MBPNBJLJBJC(HCKNMOMOEHJ LMCDPNHDNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5EC4280", Offset = "0x5EC3680", VA = "0x185EC4280")]
	private void EGPGHBGLOCE(Dictionary<Guid, Guid> LKKEGKFHFHP, KENEDIFHILE AKJOGAPDELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5EC3FD0", Offset = "0x5EC33D0", VA = "0x185EC3FD0")]
	private void EGPGHBGLOCE(Dictionary<Guid, Guid> LKKEGKFHFHP, BPPEAJMBLHC FJMHKIFAJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5EC4030", Offset = "0x5EC3430", VA = "0x185EC4030")]
	private void EGPGHBGLOCE(Dictionary<Guid, Guid> LKKEGKFHFHP, CHBEAMDLNJI LOKHENMCMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public KNFMGGOADLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class FHELEEADJIG : PAKKCHFHLCN
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1F30", Offset = "0x5EC1330", VA = "0x185EC1F30", Slot = "4")]
	public void MBPNBJLJBJC(HCKNMOMOEHJ LMCDPNHDNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public FHELEEADJIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class ELEOPOCAJIC : PAKKCHFHLCN
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD190", Offset = "0x5EBC590", VA = "0x185EBD190", Slot = "4")]
	public void MBPNBJLJBJC(HCKNMOMOEHJ LMCDPNHDNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public ELEOPOCAJIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class ACAJKMJHDPO : PAKKCHFHLCN
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5EBBB00", Offset = "0x5EBAF00", VA = "0x185EBBB00", Slot = "4")]
	public void MBPNBJLJBJC(HCKNMOMOEHJ LMCDPNHDNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public ACAJKMJHDPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class FEENEDMHBCA : PAKKCHFHLCN
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1D20", Offset = "0x5EC1120", VA = "0x185EC1D20", Slot = "4")]
	public void MBPNBJLJBJC(HCKNMOMOEHJ LMCDPNHDNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public FEENEDMHBCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class AJCKIGADHHD : PAKKCHFHLCN
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5EBCFA0", Offset = "0x5EBC3A0", VA = "0x185EBCFA0", Slot = "4")]
	public void MBPNBJLJBJC(HCKNMOMOEHJ LMCDPNHDNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public AJCKIGADHHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class IKGAOOCGPAI : PAKKCHFHLCN
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC3B10", Offset = "0x5EC2F10", VA = "0x185EC3B10", Slot = "4")]
	public void MBPNBJLJBJC(HCKNMOMOEHJ LMCDPNHDNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public IKGAOOCGPAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class LNHEDMIAFEF : PAKKCHFHLCN
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5EC4860", Offset = "0x5EC3C60", VA = "0x185EC4860", Slot = "4")]
	public void MBPNBJLJBJC(HCKNMOMOEHJ LMCDPNHDNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public LNHEDMIAFEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class JCPIMIEOLGN : PAKKCHFHLCN
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5EC3D00", Offset = "0x5EC3100", VA = "0x185EC3D00", Slot = "4")]
	public void MBPNBJLJBJC(HCKNMOMOEHJ LMCDPNHDNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public JCPIMIEOLGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class HKIIACGHDIL : PAKKCHFHLCN
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5EC2E60", Offset = "0x5EC2260", VA = "0x185EC2E60", Slot = "4")]
	public void MBPNBJLJBJC(HCKNMOMOEHJ LMCDPNHDNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public HKIIACGHDIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class NMGLFIPDKLF : PAKKCHFHLCN
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5EC4980", Offset = "0x5EC3D80", VA = "0x185EC4980", Slot = "4")]
	public void MBPNBJLJBJC(HCKNMOMOEHJ LMCDPNHDNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public NMGLFIPDKLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class HLNADEOGHPC : PAKKCHFHLCN
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly System.Random KENGCPAIGMI;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5EC3030", Offset = "0x5EC2430", VA = "0x185EC3030", Slot = "4")]
	public void MBPNBJLJBJC(HCKNMOMOEHJ LMCDPNHDNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public HLNADEOGHPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct JLBIPNOPGLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public KGPBGDOCNHG IIMAMIPIKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public AODOPJDMGJK BPLEAHAMFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Dictionary<int, int> MAEBHDMNIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Dictionary<Guid, Guid> JAFHELFHJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public FKOPNBAMHPF LFIHAOLIHJL;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface PAKKCHFHLCN
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MBPNBJLJBJC(HCKNMOMOEHJ LMCDPNHDNAP);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GGHIAGBPJHI
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly PAKKCHFHLCN[] PEIMCNNEDNK;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC21E0", Offset = "0x5EC15E0", VA = "0x185EC21E0")]
	public static void JNKPKPCOCAK(GNAMCHKIIOD MPEBBGJJODN, Dictionary<Guid, Guid> JFEPBMJNECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1FF0", Offset = "0x5EC13F0", VA = "0x185EC1FF0")]
	public static void AGEGOAGKNPE(GNAMCHKIIOD? MPEBBGJJODN, LPMAMEAOANG LHMJMMCMGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC23F0", Offset = "0x5EC17F0", VA = "0x185EC23F0")]
	public static void NFDHPKGOBPD(HCKNMOMOEHJ LMCDPNHDNAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct HCKNMOMOEHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public KGPBGDOCNHG GLJAIOKDKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public GNAMCHKIIOD FCEBLLIOAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Dictionary<int, int> MAEBHDMNIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Dictionary<Guid, Guid> JAFHELFHJPC;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5EC2D90", Offset = "0x5EC2190", VA = "0x185EC2D90")]
	public Guid AIGGKBAHPBN(Guid CFOLAEKFCNI)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface FKOPNBAMHPF
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int JCBOMJDCPGG, out Guid OGPHLBOJMFH);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class AFELMKLPMOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<string> JFFNKMDKHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<long, int> OFFJBIGNLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<Guid> PGABKAOAAKP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyCollection<string> JLCNFBENJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<long, int> DNGALLOMADI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5EBCCA0", Offset = "0x5EBC0A0", VA = "0x185EBCCA0")]
	public static AFELMKLPMOP ILOJLGBGBNB(LNPAGJDMHMD FOGLEECNIFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5EBCD10", Offset = "0x5EBC110", VA = "0x185EBCD10")]
	public static AFELMKLPMOP IOBJBBDOEKL(AILLEBLLAIC CGBAOOEFBMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC980", Offset = "0x5EBBD80", VA = "0x185EBC980")]
	public static AFELMKLPMOP DMFMDOFBHKJ(IEnumerable<string> JFFNKMDKHKG, IDictionary<long, int> HFKIAMBFIOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5EBCD80", Offset = "0x5EBC180", VA = "0x185EBCD80")]
	private AFELMKLPMOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5EBCE80", Offset = "0x5EBC280", VA = "0x185EBCE80")]
	private AFELMKLPMOP(IEnumerable<string> JFFNKMDKHKG, IDictionary<long, int> HFKIAMBFIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC3A0", Offset = "0x5EBB7A0", VA = "0x185EBC3A0")]
	private void BMMCIBLCMDN(LNPAGJDMHMD FOGLEECNIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5EBBCC0", Offset = "0x5EBB0C0", VA = "0x185EBBCC0")]
	private void BMMCIBLCMDN(AILLEBLLAIC CGBAOOEFBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC560", Offset = "0x5EBB960", VA = "0x185EBC560")]
	private void BMMCIBLCMDN(OFDCGEHNHLK? ALLJDBGIIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5EBBE80", Offset = "0x5EBB280", VA = "0x185EBBE80")]
	private void BMMCIBLCMDN(FGFKNNAOODI? HLJLMLNJBJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5EBBFF0", Offset = "0x5EBB3F0", VA = "0x185EBBFF0")]
	private void BMMCIBLCMDN(GNAMCHKIIOD? FCEBLLIOAFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5EBBC50", Offset = "0x5EBB050", VA = "0x185EBBC50")]
	private void AJAMDBPOLMH(string? LDLMJFKPJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5EBCBC0", Offset = "0x5EBBFC0", VA = "0x185EBCBC0")]
	private void IIDNHPHNMDM(IAEICJFMBGJ? JNLIGBMCAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5EBCAD0", Offset = "0x5EBBED0", VA = "0x185EBCAD0")]
	private void IIDNHPHNMDM(DKGODCCIDMH? JNLIGBMCAPJ)
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
