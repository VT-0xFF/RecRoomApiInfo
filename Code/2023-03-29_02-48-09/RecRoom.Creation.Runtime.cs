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
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DFDDB0", Offset = "0x5DFCBB0", VA = "0x185DFDDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB9A310", Offset = "0xB99110", VA = "0x180B9A310")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PAKECEOAADK
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5DFDE90", Offset = "0x5DFCC90", VA = "0x185DFDE90")]
	public static bool MAIECNIMEAD(IJFHOKDCEDC EKMGJBKFLIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5DFDED0", Offset = "0x5DFCCD0", VA = "0x185DFDED0")]
	private static bool MAIECNIMEAD(NAEAMKGOPMH PBDMJBPFBLI, ref IJFHOKDCEDC EKMGJBKFLIP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct AGBNFJIHOPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public List<MPMNMMAHEIE> GINCGCNFGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public IEnumerable<JHLJDFGCBGD> MCNGJGENLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public PNFHKAFCGMP BLJIOIKIFKL;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface CGOBAEBHBPC
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(IJKIEHCFOHI PHAPMEHMHAK, out Dictionary<int, int> AOJHKDLBJJO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(BALGNGLNJGD OHECMEJPIJP, KALANOJFLCC MOBGOOJJLIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GAPIJOAAMAF
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
public sealed class ENFMDPBFDFL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<Guid, Guid> APGIPDOPHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<Guid, Guid> BGACAFMHKDN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<Guid, Guid> JHKDFDJPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x87BC00", Offset = "0x87AA00", VA = "0x18087BC00")]
	public ENFMDPBFDFL(Dictionary<Guid, Guid> APGIPDOPHDE, Dictionary<Guid, Guid> BGACAFMHKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6590", Offset = "0x5DF5390", VA = "0x185DF6590", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class GICHMNNEHCF
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class MLBDLIFFOGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly HashSet<JHLJDFGCBGD> KECPPGMJIBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly HashSet<CICFDNNEFAJ> NOGFFGBBHOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly List<PEDOMCINCFL> MDLPPGHMHGK;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5DFD980", Offset = "0x5DFC780", VA = "0x185DFD980")]
		public MLBDLIFFOGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class OAGMCGAMLJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CICFDNNEFAJ destinationGraph;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public OAGMCGAMLJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5DFDE40", Offset = "0x5DFCC40", VA = "0x185DFDE40")]
		internal bool <InitializeCircuitsV2Remapping>b__0(KGOGOFLFCNL n)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class ECMNGAOJDFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int mpif;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public ECMNGAOJDFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5DF6570", Offset = "0x5DF5370", VA = "0x185DF6570")]
		internal void <InitializeCircuitsV2Remapping>b__1(KGOGOFLFCNL n)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF84F0", Offset = "0x5DF72F0", VA = "0x185DF84F0")]
	public static KHHLPJCAEBM EGKOGGGFPCC(AGBNFJIHOPF HMPMNDDKFHI, out PKDMBOHMDOL DBLIBDABNBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5DFADF0", Offset = "0x5DF9BF0", VA = "0x185DFADF0")]
	private static void NFNGKKNHMGD(KHHLPJCAEBM AOAEBJHKJPO, MLBDLIFFOGD KJHDFOKKCMA, out PKDMBOHMDOL DBLIBDABNBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9440", Offset = "0x5DF8240", VA = "0x185DF9440")]
	private static void GFOIJKFKKEM(MPMNMMAHEIE GMONACJDNEC, MLBDLIFFOGD KJHDFOKKCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA720", Offset = "0x5DF9520", VA = "0x185DFA720")]
	private static void JIIKEDHGOPB(KHHLPJCAEBM AOAEBJHKJPO, MLBDLIFFOGD KJHDFOKKCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5DF95A0", Offset = "0x5DF83A0", VA = "0x185DF95A0")]
	private static void HEEEBADBOBM(ref AGBNFJIHOPF NBIDNHAIENE, MLBDLIFFOGD KJHDFOKKCMA, MPMNMMAHEIE GMONACJDNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7710", Offset = "0x5DF6510", VA = "0x185DF7710")]
	public static bool CLPOGPPBOGP(KHHLPJCAEBM AOAEBJHKJPO, NKPMGIPJLEB LCOIMMENLAH, out ENFMDPBFDFL? OBKMAIPPLOL, out string? EDMHEICKIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6B00", Offset = "0x5DF5900", VA = "0x185DF6B00")]
	private static void AAMDFAFOEBO(KHHLPJCAEBM AOAEBJHKJPO, ref NKPMGIPJLEB LCOIMMENLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9160", Offset = "0x5DF7F60", VA = "0x185DF9160")]
	public static Dictionary<Guid, Guid> GCJNPIFNKEL(IEnumerable<MPMNMMAHEIE> GNKFFHDFEJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9560", Offset = "0x5DF8360", VA = "0x185DF9560")]
	private static void GLJHBHFEPIB(KHHLPJCAEBM AOAEBJHKJPO, ref NKPMGIPJLEB LCOIMMENLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7ED0", Offset = "0x5DF6CD0", VA = "0x185DF7ED0")]
	private static bool DOBOPNLJLCC(KHHLPJCAEBM AOAEBJHKJPO, BALGNGLNJGD OHECMEJPIJP, ref NKPMGIPJLEB LCOIMMENLAH, out string EDMHEICKIIC, out Dictionary<int, int> AOJHKDLBJJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAEF0", Offset = "0x5DF9CF0", VA = "0x185DFAEF0")]
	private static Dictionary<Guid, NAEAMKGOPMH> PLKNLNKONOC(KHHLPJCAEBM AOAEBJHKJPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5DF98F0", Offset = "0x5DF86F0", VA = "0x185DF98F0")]
	private static bool IDCIAHBOKKJ(KHHLPJCAEBM AOAEBJHKJPO, ref NKPMGIPJLEB LCOIMMENLAH, out string? EDMHEICKIIC, out FJCCPNDLLPD? DPCAHGPGMHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9860", Offset = "0x5DF8660", VA = "0x185DF9860")]
	private static void HIECALGKLCM(bool HHFELCOPLBC, MPMNMMAHEIE OKKIDIOPHDN, Dictionary<Guid, Guid> BAMHMNMILHO, FJCCPNDLLPD JGAPLJJLNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA9C0", Offset = "0x5DF97C0", VA = "0x185DFA9C0")]
	private static void LDICPBDJCDK(bool HHFELCOPLBC, MPMNMMAHEIE OKKIDIOPHDN, FJCCPNDLLPD DPCAHGPGMHF, Guid IAMADHBKPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA480", Offset = "0x5DF9280", VA = "0x185DFA480")]
	private static void IPKMKCMEDCM(MPMNMMAHEIE OKKIDIOPHDN, Guid MBHPLMBDACJ, BBILNFOCHGP? JMLIHFKNICA, Dictionary<Guid, NAEAMKGOPMH> HKCGCNCJONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA390", Offset = "0x5DF9190", VA = "0x185DFA390")]
	private static void IFHHHPIFNDJ(MPMNMMAHEIE OKKIDIOPHDN, Dictionary<Guid, Guid> BAMHMNMILHO, Dictionary<int, int> NPGBGDPIDKO, BALGNGLNJGD FEAGGMCPKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8B20", Offset = "0x5DF7920", VA = "0x185DF8B20")]
	public static void EPNAFAPEMHA(RepeatedField<MPMNMMAHEIE> ODNADEEOBJA, IGDCLHOHJHD NBIHLNKMHLB, IEnumerable<ByteString> MMLBPKDKOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6C20", Offset = "0x5DF5A20", VA = "0x185DF6C20")]
	private static void BDPPNINNALG(RepeatedField<MPMNMMAHEIE> ODNADEEOBJA, OGNNLBLJALD INMBHCGIKFP, GAPIJOAAMAF ODJDEKKCIFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct NKPMGIPJLEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool HHFELCOPLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public bool JFMMLKHGIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public BBILNFOCHGP? JMLIHFKNICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public BBILNFOCHGP? CEHIBJGLBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public KOMCNLCEHEN FGIBCIIDMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public GAPIJOAAMAF ODJDEKKCIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public CGOBAEBHBPC ODNGEFFBGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public Guid IAMADHBKPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public PNFHKAFCGMP BLJIOIKIFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public List<MPMNMMAHEIE> DMMIJHNFLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public Dictionary<string, object> AMJAHPEJOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public JFOHIAOEPPG IAFMPOMOCKF;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct BBILNFOCHGP
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private const float IDEDNGGIMON = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Vector3 CBAKPHLPCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Quaternion HKMKNOBAIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float CPAOPLMBGGO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Matrix4x4 HCLFLPPMOJF
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5DF5510", Offset = "0x5DF4310", VA = "0x185DF5510")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x18A1730", Offset = "0x18A0530", VA = "0x1818A1730")]
	public BBILNFOCHGP(Vector3 CBAKPHLPCPB, Quaternion HKMKNOBAIAN, float CPAOPLMBGGO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5C10", Offset = "0x5DF4A10", VA = "0x185DF5C10")]
	public BBILNFOCHGP(MLMMEAOFGIH EMGGFJIINLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5B50", Offset = "0x5DF4950", VA = "0x185DF5B50")]
	private BBILNFOCHGP(NNMPBOJPBBF LLINJCIOBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5DF54E0", Offset = "0x5DF42E0", VA = "0x185DF54E0")]
	public static BBILNFOCHGP ECEGNNLHBCD(JHLJDFGCBGD ELOBCEGELNN)
	{
		return default(BBILNFOCHGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5870", Offset = "0x5DF4670", VA = "0x185DF5870")]
	public static BBILNFOCHGP PCFNCAGAJHC(BBILNFOCHGP AABHIBJPKOH, BBILNFOCHGP CLAGFBDKIID)
	{
		return default(BBILNFOCHGP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5440", Offset = "0x5DF4240", VA = "0x185DF5440")]
	public static BBILNFOCHGP CILEDLHNJIF((Vector3, Quaternion, float) PHAPMEHMHAK)
	{
		return default(BBILNFOCHGP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5340", Offset = "0x5DF4140", VA = "0x185DF5340")]
	public static BBILNFOCHGP CILEDLHNJIF(Matrix4x4 CNFLKCJBMLL)
	{
		return default(BBILNFOCHGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF59C0", Offset = "0x5DF47C0", VA = "0x185DF59C0")]
	public BBILNFOCHGP PIBCOEMGCKC(Matrix4x4 GPMKACFJLBP)
	{
		return default(BBILNFOCHGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5490", Offset = "0x5DF4290", VA = "0x185DF5490")]
	public static BBILNFOCHGP DNFFLGPDHKO(Vector3 CBAKPHLPCPB)
	{
		return default(BBILNFOCHGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5610", Offset = "0x5DF4410", VA = "0x185DF5610")]
	[CompilerGenerated]
	internal static BBILNFOCHGP MLIGJPHGBIC(JHLJDFGCBGD CKNHANKHIBG)
	{
		return default(BBILNFOCHGP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class BJDDHOOGJIH : NDBFPJPDEGH
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5DF64C0", Offset = "0x5DF52C0", VA = "0x185DF64C0", Slot = "4")]
	public void GOFHEDFKCBK(IHMMEOJNMLA KHIBLLPHOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5CE0", Offset = "0x5DF4AE0", VA = "0x185DF5CE0")]
	private void EPOHHBMFDKP(Dictionary<Guid, Guid> IBFGIFOKDCJ, GHEKKBPBPPC GGPGGJPFKNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6460", Offset = "0x5DF5260", VA = "0x185DF6460")]
	private void EPOHHBMFDKP(Dictionary<Guid, Guid> IBFGIFOKDCJ, BBPJECNPMLI KFEEMPDGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6210", Offset = "0x5DF5010", VA = "0x185DF6210")]
	private void EPOHHBMFDKP(Dictionary<Guid, Guid> IBFGIFOKDCJ, CNGLEIABEJB PJHNNDDLILK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public BJDDHOOGJIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class HNPIPKLMDFE : NDBFPJPDEGH
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5DFC1B0", Offset = "0x5DFAFB0", VA = "0x185DFC1B0", Slot = "4")]
	public void GOFHEDFKCBK(IHMMEOJNMLA KHIBLLPHOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public HNPIPKLMDFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class HEMBCKKCEII : NDBFPJPDEGH
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB2A0", Offset = "0x5DFA0A0", VA = "0x185DFB2A0", Slot = "4")]
	public void GOFHEDFKCBK(IHMMEOJNMLA KHIBLLPHOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public HEMBCKKCEII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class GEAIOCJPCEN : NDBFPJPDEGH
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5DF69B0", Offset = "0x5DF57B0", VA = "0x185DF69B0", Slot = "4")]
	public void GOFHEDFKCBK(IHMMEOJNMLA KHIBLLPHOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public GEAIOCJPCEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class MMMILAHCNBL : NDBFPJPDEGH
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5DFDA80", Offset = "0x5DFC880", VA = "0x185DFDA80", Slot = "4")]
	public void GOFHEDFKCBK(IHMMEOJNMLA KHIBLLPHOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public MMMILAHCNBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class ANIEGDHHFPL : NDBFPJPDEGH
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF51C0", Offset = "0x5DF3FC0", VA = "0x185DF51C0", Slot = "4")]
	public void GOFHEDFKCBK(IHMMEOJNMLA KHIBLLPHOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public ANIEGDHHFPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class FBMCJPHGBCC : NDBFPJPDEGH
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF65F0", Offset = "0x5DF53F0", VA = "0x185DF65F0", Slot = "4")]
	public void GOFHEDFKCBK(IHMMEOJNMLA KHIBLLPHOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public FBMCJPHGBCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class NMNHPOKDDHE : NDBFPJPDEGH
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5DFDC90", Offset = "0x5DFCA90", VA = "0x185DFDC90", Slot = "4")]
	public void GOFHEDFKCBK(IHMMEOJNMLA KHIBLLPHOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public NMNHPOKDDHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class FCBIONDOOIH : NDBFPJPDEGH
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5DF67E0", Offset = "0x5DF55E0", VA = "0x185DF67E0", Slot = "4")]
	public void GOFHEDFKCBK(IHMMEOJNMLA KHIBLLPHOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public FCBIONDOOIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class IHAHEPMCBDE : NDBFPJPDEGH
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5DFC270", Offset = "0x5DFB070", VA = "0x185DFC270", Slot = "4")]
	public void GOFHEDFKCBK(IHMMEOJNMLA KHIBLLPHOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public IHAHEPMCBDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class MJKEHMLIJHM : NDBFPJPDEGH
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD860", Offset = "0x5DFC660", VA = "0x185DFD860", Slot = "4")]
	public void GOFHEDFKCBK(IHMMEOJNMLA KHIBLLPHOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public MJKEHMLIJHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class HEHKPIKBJOK : NDBFPJPDEGH
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly System.Random PDGMOMAJGHB;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB160", Offset = "0x5DF9F60", VA = "0x185DFB160", Slot = "4")]
	public void GOFHEDFKCBK(IHMMEOJNMLA KHIBLLPHOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public HEHKPIKBJOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct IJFHOKDCEDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public BALGNGLNJGD CPFPNOFCGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NFPCHOIAOIK OFFNLCAKHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Dictionary<int, int> NPGBGDPIDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Dictionary<Guid, Guid> OLAPBPGFKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public JFOHIAOEPPG IAFMPOMOCKF;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface NDBFPJPDEGH
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GOFHEDFKCBK(IHMMEOJNMLA KHIBLLPHOKA);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class HJKHJBOIJEE
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly NDBFPJPDEGH[] OLPICEBDJIO;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB410", Offset = "0x5DFA210", VA = "0x185DFB410")]
	public static void AJOCKOEHCGF(MPMNMMAHEIE PHAPMEHMHAK, Dictionary<Guid, Guid> EKPPDNEODAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB620", Offset = "0x5DFA420", VA = "0x185DFB620")]
	public static void GGCFNLPKNPE(MPMNMMAHEIE? PHAPMEHMHAK, FJCCPNDLLPD JGAPLJJLNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB810", Offset = "0x5DFA610", VA = "0x185DFB810")]
	public static void MAIECNIMEAD(IHMMEOJNMLA KHIBLLPHOKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct IHMMEOJNMLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public BALGNGLNJGD JDGLGNOAKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public MPMNMMAHEIE OKKIDIOPHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Dictionary<int, int> NPGBGDPIDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Dictionary<Guid, Guid> OLAPBPGFKMP;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5DFC440", Offset = "0x5DFB240", VA = "0x185DFC440")]
	public Guid KEBPFNNHBJI(Guid LAJNKLHJFND)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface JFOHIAOEPPG
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int LHEGNCPLNAL, out Guid MDIHGMEDHIH);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class IKDGIMALKEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<string> DFIJLBEOHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<long, int> PDKAEGEOCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<Guid> HJLHNPKBIIL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyCollection<string> CDFOIOGICNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<long, int> BDCIGGIHFGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5DFC510", Offset = "0x5DFB310", VA = "0x185DFC510")]
	public static IKDGIMALKEK ADLHIPDGDLJ(MBMCPLADCOA IMALMBEAIBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5DFC740", Offset = "0x5DFB540", VA = "0x185DFC740")]
	public static IKDGIMALKEK EJCJDCDFAIL(KHHLPJCAEBM BNPFDKFNOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5DFC5F0", Offset = "0x5DFB3F0", VA = "0x185DFC5F0")]
	public static IKDGIMALKEK ANHHMKDGNKC(IEnumerable<string> DFIJLBEOHEH, IDictionary<long, int> MCNKMABIJIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD640", Offset = "0x5DFC440", VA = "0x185DFD640")]
	private IKDGIMALKEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD740", Offset = "0x5DFC540", VA = "0x185DFD740")]
	private IKDGIMALKEK(IEnumerable<string> DFIJLBEOHEH, IDictionary<long, int> MCNKMABIJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5DFC7B0", Offset = "0x5DFB5B0", VA = "0x185DFC7B0")]
	private void OCLANOGBGEJ(MBMCPLADCOA IMALMBEAIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5DFCD20", Offset = "0x5DFBB20", VA = "0x185DFCD20")]
	private void OCLANOGBGEJ(KHHLPJCAEBM BNPFDKFNOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD050", Offset = "0x5DFBE50", VA = "0x185DFD050")]
	private void OCLANOGBGEJ(IGDCLHOHJHD? DCJJENKGKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5DFCEE0", Offset = "0x5DFBCE0", VA = "0x185DFCEE0")]
	private void OCLANOGBGEJ(KGOGOFLFCNL? CKNHANKHIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5DFC970", Offset = "0x5DFB770", VA = "0x185DFC970")]
	private void OCLANOGBGEJ(MPMNMMAHEIE? OKKIDIOPHDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5DFC580", Offset = "0x5DFB380", VA = "0x185DFC580")]
	private void AIEHCENDJEC(string? NDLHJNAOGAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD560", Offset = "0x5DFC360", VA = "0x185DFD560")]
	private void PHJKOOOJMEO(IAALBELCCJP? JFJJEOGCEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD470", Offset = "0x5DFC270", VA = "0x185DFD470")]
	private void PHJKOOOJMEO(JHNHPHHFLEK? JFJJEOGCEIF)
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
