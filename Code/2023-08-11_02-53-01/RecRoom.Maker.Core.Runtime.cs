using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
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
		[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EFF3D0", Offset = "0x6EFDBD0", VA = "0x186EFF3D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EEC40", Offset = "0x7ED440", VA = "0x1807EEC40")]
		public NullableAttribute(byte[] P_0)
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

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA14660", Offset = "0xA12E60", VA = "0x180A14660")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2F80", Offset = "0x6E2380")]
public class KLBNBIGEMGI<TData> : FOGCHEDOFJL<ELJFDFAFHJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HMAPNNKKKPJ HKFHFHBGMLC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2281DE0", Offset = "0x22805E0", VA = "0x182281DE0")]
	public KLBNBIGEMGI(Vector3 KCNMKAOIEBP, bool OIPNPCFLPMI, ELJFDFAFHJH<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x207DF10", Offset = "0x207C710", VA = "0x18207DF10", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2FF0", Offset = "0x6E23F0")]
public class GGIAKCBBDLL<TSpawnType, TSpawnInfo> : FHLBHOLPKNI<EDNMKGKFOPD<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3060", Offset = "0x6E2460")]
	private readonly MMBFHNIINLO<TSpawnInfo> HPDOEALAHJH;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x27856D0", Offset = "0x2783ED0", VA = "0x1827856D0")]
	public GGIAKCBBDLL(TSpawnInfo PJEDJKOJFDA, Vector3 PAOMABBDKAH, Quaternion APAHFEOKBOD, float FJJHHNAFAEK, EDNMKGKFOPD<TSpawnType, TSpawnInfo> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2785370", Offset = "0x2783B70", VA = "0x182785370", Slot = "4")]
	public override Task<TSpawnType> LCEFAGCAIBN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct GJPHMGLMNBE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public IEnumerable<TData> ONBPDDGKCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public bool NJJEPKGAAPO;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2081440", Offset = "0x207FC40", VA = "0x182081440")]
	public GJPHMGLMNBE(IEnumerable<TData> MHOONJNCMEO, bool EHDEJFGBHIG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface JACJNBEIJIE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OBAPMKEKDOM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3100", Offset = "0x6E2500")] in IBOCINBELMJ<TData?> BOHNGOGGHHG);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FDCAJAANPAG(in BKDPGJGDMCM NOOKJGIBAIO);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FDCAJAANPAG(in KAKLFJCNECH NOOKJGIBAIO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KCILAOMGFEA();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct COFIJCODLGN<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TNode HGMBFDMLJPP;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2447190", Offset = "0x2445990", VA = "0x182447190")]
	public COFIJCODLGN(TNode HGMBFDMLJPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct MOCNIKKHJCI<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public TNode FPAGGIKCKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public MCBDKJEDECL GANIEEOFLEA;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x23BDA00", Offset = "0x23BC200", VA = "0x1823BDA00")]
	public MOCNIKKHJCI(TNode FPAGGIKCKJN, MCBDKJEDECL GANIEEOFLEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3170", Offset = "0x6E2570")]
public class FDHHGKBEIKE<TData> : FOGCHEDOFJL<HIKKLIAEDAA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E31E0", Offset = "0x6E25E0")]
	private readonly GJPHMGLMNBE<TData> POPDCGAEDDM;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x36796F0", Offset = "0x3677EF0", VA = "0x1836796F0")]
	public FDHHGKBEIKE(List<TData> GFONPGDKJGC, HIKKLIAEDAA<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x208A830", Offset = "0x2089030", VA = "0x18208A830", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PECJKIAANKI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LCEFAGCAIBN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3240", Offset = "0x6E2640")] in LDPDDJEAIOB<TData?> KEKAAPBDKCA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct DNNBFCNNBGC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public IEnumerable<TData> ONBPDDGKCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public HKLBLNKGABG NJNDBMKLJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public HALJELNOGOG NKFPLPJIMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public float FJGMPDOGPED;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x27F0220", Offset = "0x27EEA20", VA = "0x1827F0220")]
	public DNNBFCNNBGC(IEnumerable<TData> GIGBDNNNEMK, HKLBLNKGABG JIINIIPALJJ, HALJELNOGOG KKNFKPKFEJH, float FJGMPDOGPED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal static class MAGMAJHPLMC
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6EFF170", Offset = "0x6EFD970", VA = "0x186EFF170")]
	public static void NCMANJONECK(IEnumerable GAGFOKAJOGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2B63640", Offset = "0x2B61E40", VA = "0x182B63640")]
	public static void NCMANJONECK<T>(T[] DLLMPOAIBGN) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LHNKCNGIGOE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LCEFAGCAIBN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E32F0", Offset = "0x6E26F0")] in GDHNHOOINEF<T?> NBAPFBBEBEG);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct KJGMANOBKOM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public TData[] ONBPDDGKCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public HKLBLNKGABG[] NJNDBMKLJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public HALJELNOGOG[] NKFPLPJIMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float[] FJGMPDOGPED;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2280740", Offset = "0x227EF40", VA = "0x182280740")]
	public KJGMANOBKOM(TData[] GIGBDNNNEMK, HKLBLNKGABG[] JIINIIPALJJ, HALJELNOGOG[] KKNFKPKFEJH, float[] FJGMPDOGPED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FDAKGBMNKPN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool COFKEDALHBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool DFAMFJIFECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool FLJMIFBKELG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BMEMCMCGFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct IINLFFHOGGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Guid BGNDLGIDBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly int AMOEKOMGDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly Vector3 PAOMABBDKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly Quaternion APAHFEOKBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly float MMDOOKNHKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly bool OIPNPCFLPMI;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6EFF100", Offset = "0x6EFD900", VA = "0x186EFF100")]
	public IINLFFHOGGG(Guid BGNDLGIDBBK, int AMOEKOMGDLG, Vector3 PAOMABBDKAH, Quaternion APAHFEOKBOD, float MMDOOKNHKEB, bool OIPNPCFLPMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LEABGAGJMKC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OBAPMKEKDOM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3360", Offset = "0x6E2760")] in OPOBGFJEAJJ<TData?> BOHNGOGGHHG);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FDCAJAANPAG(in MBEPFGIFNCB NOOKJGIBAIO);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KCILAOMGFEA();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct BKDPGJGDMCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly float IJICPBHJJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly Vector3 DJKGEHJHDHA;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4AC11E0", Offset = "0x4ABF9E0", VA = "0x184AC11E0")]
	public BKDPGJGDMCM(float IJICPBHJJLL, Vector3 DJKGEHJHDHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct KAKLFJCNECH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly Vector3 ADBDBMFFEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly float IJICPBHJJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 DJKGEHJHDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly bool OIPNPCFLPMI;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6EFF140", Offset = "0x6EFD940", VA = "0x186EFF140")]
	public KAKLFJCNECH(Vector3 ADBDBMFFEKN, float IJICPBHJJLL, Vector3 DJKGEHJHDHA, bool OIPNPCFLPMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E33D0", Offset = "0x6E27D0")]
public class HIEHAHEJNCC<TData> : FOGCHEDOFJL<MGHFAJFLOGP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly GJDDCEKPABN PGNDJGFMNJK;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x29AF310", Offset = "0x29ADB10", VA = "0x1829AF310")]
	public HIEHAHEJNCC(Vector3 LKNEOPJKMKD, MGHFAJFLOGP<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x207DF10", Offset = "0x207C710", VA = "0x18207DF10", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface KKLPMOKOKCL<TData> where TData : JEDJKFJNLGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LCEFAGCAIBN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3440", Offset = "0x6E2840")] in AMPLLBIPABH<TData> DEOHHDDKJIP);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LCEFAGCAIBN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E34B0", Offset = "0x6E28B0")] in DANDKBHNBNC<TData> DEOHHDDKJIP);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class DDOJGCCKNFK
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public enum BIDGKAEDIKK
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3BE17B0", Offset = "0x3BDFFB0", VA = "0x183BE17B0")]
	public static void DGKOLFEAFNA<T>(T KLLABPMEFNM, BIDGKAEDIKK EIOLDDJPDLH) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3BE1720", Offset = "0x3BDFF20", VA = "0x183BE1720")]
	public static void DGKOLFEAFNA<T>(T KLLABPMEFNM) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3BE1AD0", Offset = "0x3BE02D0", VA = "0x183BE1AD0")]
	public static void OFACJHHBNEC<T>(T KLLABPMEFNM) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3BE1A10", Offset = "0x3BE0210", VA = "0x183BE1A10")]
	public static T LPKBLHIFLLL<T>(BIDGKAEDIKK EIOLDDJPDLH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3BE19A0", Offset = "0x3BE01A0", VA = "0x183BE19A0")]
	public static T LPKBLHIFLLL<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3BE1930", Offset = "0x3BE0130", VA = "0x183BE1930")]
	public static bool FCGJPIPECKP<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3520", Offset = "0x6E2920")]
public class GENONCCNFOA<TData> : FOGCHEDOFJL<HIKKLIAEDAA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x18F9B70", Offset = "0x18F8370", VA = "0x1818F9B70")]
	public GENONCCNFOA(HIKKLIAEDAA<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2780E70", Offset = "0x277F670", VA = "0x182780E70", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface PKJJBMECENN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 HPBBFNNBAFE, Vector3 JJEDPBPHNPK, float BJICICOAOBE, out T CIIODJEKNCO, out Vector3 BIBFLHALDBF, out Collider DAEKDCLDNCE);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 HPBBFNNBAFE, Vector3 JJEDPBPHNPK, float MEDLDNBKGDG, float BJICICOAOBE, T[] GONMLHLMKID, out Vector3 DKPPBJNDPJA, out Collider LFBCMLNIGAA);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 HPBBFNNBAFE, float MEDLDNBKGDG, Vector3 JKJHMBLDADJ, T[] GONMLHLMKID);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class GLAPHAJGGPO<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	protected TReceiver PIJFGKNLICL;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x208A7A0", Offset = "0x2088FA0", VA = "0x18208A7A0")]
	public GLAPHAJGGPO(TReceiver PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute LCEFAGCAIBN();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3590", Offset = "0x6E2990")]
public class APAJIBBMFIC<TData> : FOGCHEDOFJL<PFICFHOCKMK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3600", Offset = "0x6E2A00")]
	private readonly CGOJHAFNGKA<TData> JEMAAKFPBFM;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2709660", Offset = "0x2707E60", VA = "0x182709660")]
	public APAJIBBMFIC(IEnumerable<TData> GIGBDNNNEMK, HKLBLNKGABG JIINIIPALJJ, HALJELNOGOG KKNFKPKFEJH, float FJGMPDOGPED, bool NJJEPKGAAPO, PFICFHOCKMK<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x208A830", Offset = "0x2089030", VA = "0x18208A830", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3660", Offset = "0x6E2A60")]
public class LJIEEDGKFEK<TData> : FOGCHEDOFJL<ELJFDFAFHJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x18F9B70", Offset = "0x18F8370", VA = "0x1818F9B70")]
	public LJIEEDGKFEK(ELJFDFAFHJH<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x20721A0", Offset = "0x20709A0", VA = "0x1820721A0", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E36D0", Offset = "0x6E2AD0")]
public class KGFEKGDAPJI<TData> : FOGCHEDOFJL<BADGMHLIFOD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3740", Offset = "0x6E2B40")]
	private readonly GPBNAHGPGMC<TData> PGNDJGFMNJK;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x227B500", Offset = "0x2279D00", VA = "0x18227B500")]
	public KGFEKGDAPJI(IEnumerable<TData> GIGBDNNNEMK, Vector3 LKNEOPJKMKD, bool NJJEPKGAAPO, BADGMHLIFOD<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x208A830", Offset = "0x2089030", VA = "0x18208A830", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct GPBNAHGPGMC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly IEnumerable<TData> GIGBDNNNEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly Vector3 LKNEOPJKMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly bool NJJEPKGAAPO;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x41E1B20", Offset = "0x41E0320", VA = "0x1841E1B20")]
	public GPBNAHGPGMC(IEnumerable<TData> GIGBDNNNEMK, Vector3 LKNEOPJKMKD, bool NJJEPKGAAPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface BADGMHLIFOD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LCEFAGCAIBN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E37A0", Offset = "0x6E2BA0")] in GPBNAHGPGMC<TData?> PGNDJGFMNJK);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3810", Offset = "0x6E2C10")]
public class MPMBDKKCIPN<TData> : FOGCHEDOFJL<HIKKLIAEDAA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly bool NJJEPKGAAPO;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x23BFEA0", Offset = "0x23BE6A0", VA = "0x1823BFEA0")]
	public MPMBDKKCIPN(bool NJJEPKGAAPO, HIKKLIAEDAA<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x23BFE30", Offset = "0x23BE630", VA = "0x1823BFE30", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface JJMAGKFLHLF<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OBAPMKEKDOM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3880", Offset = "0x6E2C80")] in COFIJCODLGN<TNode?> BOHNGOGGHHG);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KCILAOMGFEA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E38F0", Offset = "0x6E2CF0")] in MOCNIKKHJCI<TNode?> NJJBIDLLBKF);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GDILNKOLHDH();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3960", Offset = "0x6E2D60")]
public class NDHAKDGONFJ<TNode> : FOGCHEDOFJL<JJMAGKFLHLF<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x18F9B70", Offset = "0x18F8370", VA = "0x1818F9B70")]
	public NDHAKDGONFJ(JJMAGKFLHLF<TNode> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2032260", Offset = "0x2030A60", VA = "0x182032260", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface BFCCGJCMBAK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LCEFAGCAIBN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E39D0", Offset = "0x6E2DD0")] in KJGMANOBKOM<TData?> JEMAAKFPBFM);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class EDHPMJFKBPC
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private struct OCBBPFEDBNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public bool HADPMMPANLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public LIFDIPFHEEA GGIICPPKOIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public LIFDIPFHEEA DAIJONDBMEC;
	}

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static OCBBPFEDBNC EEGDJFFDKHJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static CancellationToken JOINCANAKKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6EFF040", Offset = "0x6EFD840", VA = "0x186EFF040")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal static LIFDIPFHEEA GGIICPPKOIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6EFED20", Offset = "0x6EFD520", VA = "0x186EFED20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6EFECA0", Offset = "0x6EFD4A0", VA = "0x186EFECA0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6EFEE50", Offset = "0x6EFD650", VA = "0x186EFEE50")]
	[NFOBBCLLFPP(GBHJCKJMBFK.Room, BGPNPCEMJLD.None)]
	private static void MDGIANIPLFH(LIFDIPFHEEA CNEDAAEHBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6EFEF00", Offset = "0x6EFD700", VA = "0x186EFEF00")]
	public static void OGPDBFFONOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6EFEE00", Offset = "0x6EFD600", VA = "0x186EFEE00")]
	private static LIFDIPFHEEA JJOKELHAGFN(LIFDIPFHEEA LECGLCGHAHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface OODNLCLBPBI<TData> : AGGMHIMLGAB, HOJOJFDPBNG<TData>, HIKKLIAEDAA<TData>, BJGLFIKIOJB<TData>, FDAKGBMNKPN, PKJJBMECENN<TData>, CHIFKKBCBMC, JBOPDFDEGNE
{
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct LDPDDJEAIOB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly IEnumerable<TData> GIGBDNNNEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly Quaternion LKNEOPJKMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly Vector3? DJKGEHJHDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool DBLLGBCLPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool NJJEPKGAAPO;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x24D6DF0", Offset = "0x24D55F0", VA = "0x1824D6DF0")]
	public LDPDDJEAIOB(IEnumerable<TData> GIGBDNNNEMK, Quaternion LKNEOPJKMKD, Vector3? DJKGEHJHDHA, bool DBLLGBCLPBH, bool NJJEPKGAAPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3A60", Offset = "0x6E2E60")]
public class DKPPOEGHHKL<T> : FOGCHEDOFJL<LHNKCNGIGOE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3AD0", Offset = "0x6E2ED0")]
	private readonly GDHNHOOINEF<T> NBAPFBBEBEG;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2CBD530", Offset = "0x2CBBD30", VA = "0x182CBD530")]
	public DKPPOEGHHKL(T BEELAINJGPH, bool KOFFKNLBDFJ, LHNKCNGIGOE<T> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x208A830", Offset = "0x2089030", VA = "0x18208A830", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct CGOJHAFNGKA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public IEnumerable<TData> ONBPDDGKCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public HKLBLNKGABG NJNDBMKLJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public HALJELNOGOG NKFPLPJIMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float FJGMPDOGPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool NJJEPKGAAPO;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2956E60", Offset = "0x2955660", VA = "0x182956E60")]
	public CGOJHAFNGKA(IEnumerable<TData> GIGBDNNNEMK, HKLBLNKGABG JIINIIPALJJ, HALJELNOGOG KKNFKPKFEJH, float FJGMPDOGPED, bool NJJEPKGAAPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3B30", Offset = "0x6E2F30")]
public class GGMFPKKAJHM<TData> : FOGCHEDOFJL<JACJNBEIJIE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly KAKLFJCNECH PFFBDKNPMAD;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2785A60", Offset = "0x2784260", VA = "0x182785A60")]
	public GGMFPKKAJHM(Vector3 ADBDBMFFEKN, float IJICPBHJJLL, Vector3 DJKGEHJHDHA, bool AJGGAJPADJJ, JACJNBEIJIE<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x27859F0", Offset = "0x27841F0", VA = "0x1827859F0", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct CNMODAPOADO<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T BEELAINJGPH;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x24465E0", Offset = "0x2444DE0", VA = "0x1824465E0")]
	public CNMODAPOADO(T GGJLPJDGFLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3BA0", Offset = "0x6E2FA0")]
public class LBOBBIFBIEJ<TData> : FOGCHEDOFJL<HIKKLIAEDAA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3C10", Offset = "0x6E3010")]
	private readonly GJPHMGLMNBE<TData> POPDCGAEDDM;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x24D1600", Offset = "0x24CFE00", VA = "0x1824D1600")]
	public LBOBBIFBIEJ(List<TData> GFONPGDKJGC, HIKKLIAEDAA<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x24D1540", Offset = "0x24CFD40", VA = "0x1824D1540", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct LIODCDNBPPP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly IEnumerable<TData> ONBPDDGKCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool CHFMONBGHBC;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2071A50", Offset = "0x2070250", VA = "0x182071A50")]
	public LIODCDNBPPP(IEnumerable<TData> GIGBDNNNEMK, bool NJJEPKGAAPO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface JBOPDFDEGNE
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	NJDLJLDNKHA FFPBFICBKBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3CB0", Offset = "0x6E30B0")]
public class GIJMACJPKEK<TData> : FOGCHEDOFJL<HIKKLIAEDAA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3D20", Offset = "0x6E3120")]
	private readonly GJPHMGLMNBE<TData> POPDCGAEDDM;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x207DE70", Offset = "0x207C670", VA = "0x18207DE70")]
	public GIJMACJPKEK(List<TData> GFONPGDKJGC, bool NJJEPKGAAPO, HIKKLIAEDAA<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x207DD10", Offset = "0x207C510", VA = "0x18207DD10", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface HOJOJFDPBNG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T CEPDEAHBHLF, [Optional] FMCIPOPBHDP? FPMLPGBBOFE, bool JDHMLEEBGPD = true);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int JMKNAPEFDDB, IEnumerable<T> PJHFDJHMGDA, bool JDHMLEEBGPD = true);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int JMKNAPEFDDB, IEnumerable<T> PJHFDJHMGDA, FMCIPOPBHDP FPMLPGBBOFE, bool JDHMLEEBGPD = true);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct IBOCINBELMJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly IEnumerable<TData> GIGBDNNNEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly bool NJJEPKGAAPO;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x570DF50", Offset = "0x570C750", VA = "0x18570DF50")]
	public IBOCINBELMJ(IEnumerable<TData> GIGBDNNNEMK, bool NJJEPKGAAPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3D80", Offset = "0x6E3180")]
public class JLLPGMDNBNF<TData> : FHLBHOLPKNI<MKEKCCHEGIB<TData>, DJIHEJCBBPL> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3DF0", Offset = "0x6E31F0")]
	private readonly LIODCDNBPPP<TData> ACPPOLNFLPN;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x27CC540", Offset = "0x27CAD40", VA = "0x1827CC540")]
	public JLLPGMDNBNF(IEnumerable<TData> GIGBDNNNEMK, bool NJJEPKGAAPO, MKEKCCHEGIB<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x27CC420", Offset = "0x27CAC20", VA = "0x1827CC420", Slot = "4")]
	public override Task<DJIHEJCBBPL> LCEFAGCAIBN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3E50", Offset = "0x6E3250")]
public class BLBCEOJBLPE<TData> : FOGCHEDOFJL<ELJFDFAFHJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3EC0", Offset = "0x6E32C0")]
	private readonly DMIBPOCHKCF<TData> HKFHFHBGMLC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x219E960", Offset = "0x219D160", VA = "0x18219E960")]
	public BLBCEOJBLPE(TData BEELAINJGPH, bool NJJEPKGAAPO, ELJFDFAFHJH<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x208A830", Offset = "0x2089030", VA = "0x18208A830", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct DMIBPOCHKCF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly TData BEELAINJGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool NJJEPKGAAPO;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x27ED320", Offset = "0x27EBB20", VA = "0x1827ED320")]
	public DMIBPOCHKCF(TData BEELAINJGPH, bool NJJEPKGAAPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct ILMDOEIOMGH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly IEnumerable<TData> GIGBDNNNEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly bool NJJEPKGAAPO;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x24A7F00", Offset = "0x24A6700", VA = "0x1824A7F00")]
	public ILMDOEIOMGH(IEnumerable<TData> GIGBDNNNEMK, bool NJJEPKGAAPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3F20", Offset = "0x6E3320")]
public class NLGKLLPFEFI<T> : FOGCHEDOFJL<ACONOALLBCI<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x18F9B70", Offset = "0x18F8370", VA = "0x1818F9B70")]
	public NLGKLLPFEFI(ACONOALLBCI<T> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D880", Offset = "0x2E2C080", VA = "0x182E2D880", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3F90", Offset = "0x6E3390")]
public class AOJJKABJLCP<TData> : FOGCHEDOFJL<JACJNBEIJIE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly BKDPGJGDMCM PFFBDKNPMAD;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2709090", Offset = "0x2707890", VA = "0x182709090")]
	public AOJJKABJLCP(float IJICPBHJJLL, Vector3 DJKGEHJHDHA, JACJNBEIJIE<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x207DF10", Offset = "0x207C710", VA = "0x18207DF10", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4000", Offset = "0x6E3400")]
public class FIMOAOFJAOC<TData> : FOGCHEDOFJL<LEABGAGJMKC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x18F9B70", Offset = "0x18F8370", VA = "0x1818F9B70")]
	public FIMOAOFJAOC(LEABGAGJMKC<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2032260", Offset = "0x2030A60", VA = "0x182032260", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4070", Offset = "0x6E3470")]
public class GLDAGFAMHGC<TData> : FOGCHEDOFJL<LEABGAGJMKC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E40E0", Offset = "0x6E34E0")]
	private readonly OPOBGFJEAJJ<TData> KEKAAPBDKCA;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x208A990", Offset = "0x2089190", VA = "0x18208A990")]
	public GLDAGFAMHGC(IEnumerable<TData> GIGBDNNNEMK, bool NJJEPKGAAPO, LEABGAGJMKC<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x208A830", Offset = "0x2089030", VA = "0x18208A830", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4140", Offset = "0x6E3540")]
public class LEFOCJGILBH<TNode> : FOGCHEDOFJL<JJMAGKFLHLF<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E41B0", Offset = "0x6E35B0")]
	private readonly COFIJCODLGN<TNode> BOHNGOGGHHG;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x316A9B0", Offset = "0x31691B0", VA = "0x18316A9B0")]
	public LEFOCJGILBH(TNode NELGEKNCDHJ, JJMAGKFLHLF<TNode> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x208A830", Offset = "0x2089030", VA = "0x18208A830", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4210", Offset = "0x6E3610")]
public class BINFGBLDIEF<TData> : FOGCHEDOFJL<MGHFAJFLOGP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4280", Offset = "0x6E3680")]
	private readonly ILMDOEIOMGH<TData> PGNDJGFMNJK;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x219D320", Offset = "0x219BB20", VA = "0x18219D320")]
	public BINFGBLDIEF(IEnumerable<TData> GIGBDNNNEMK, bool NJJEPKGAAPO, MGHFAJFLOGP<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x208A830", Offset = "0x2089030", VA = "0x18208A830", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct OPOBGFJEAJJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly IEnumerable<TData> GIGBDNNNEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly bool NJJEPKGAAPO;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x50213A0", Offset = "0x501FBA0", VA = "0x1850213A0")]
	public OPOBGFJEAJJ(IEnumerable<TData> GIGBDNNNEMK, bool NJJEPKGAAPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E42E0", Offset = "0x6E36E0")]
public class JHFFFDDJNJP<TNode> : FOGCHEDOFJL<JJMAGKFLHLF<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4350", Offset = "0x6E3750")]
	private readonly MOCNIKKHJCI<TNode> NJJBIDLLBKF;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2C4CF60", Offset = "0x2C4B760", VA = "0x182C4CF60")]
	public JHFFFDDJNJP(TNode FPAGGIKCKJN, MCBDKJEDECL GANIEEOFLEA, JJMAGKFLHLF<TNode> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2C4CEA0", Offset = "0x2C4B6A0", VA = "0x182C4CEA0", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface MKEKCCHEGIB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DJIHEJCBBPL> EBJIDDJBKHG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E43B0", Offset = "0x6E37B0")] in LIODCDNBPPP<TData> POPDCGAEDDM, CancellationToken NNLBJPBEHPF);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface HIKKLIAEDAA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LEGNEGKLCLE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4420", Offset = "0x6E3820")] in GJPHMGLMNBE<TData> POPDCGAEDDM);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNDPPFLNDJP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4490", Offset = "0x6E3890")] in GJPHMGLMNBE<TData> POPDCGAEDDM);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GBPBGFIEGKN(in bool DBBOIDIOHAH);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IEDGHJPHFJC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4500", Offset = "0x6E3900")] in GJPHMGLMNBE<TData> POPDCGAEDDM);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ILNHHIOJAHI();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JJBOIAOBNIM(in TData OFNDNMKLOGC);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct MBEPFGIFNCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly Quaternion LKNEOPJKMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly Vector3? DJKGEHJHDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly bool DBLLGBCLPBH;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x53BD740", Offset = "0x53BBF40", VA = "0x1853BD740")]
	public MBEPFGIFNCB(Quaternion LKNEOPJKMKD, Vector3? DJKGEHJHDHA, bool DBLLGBCLPBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface ELJFDFAFHJH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OBAPMKEKDOM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4570", Offset = "0x6E3970")] in DMIBPOCHKCF<TData?> BOHNGOGGHHG);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FDCAJAANPAG(in HMAPNNKKKPJ NOOKJGIBAIO);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FDCAJAANPAG(in IINLFFHOGGG NOOKJGIBAIO);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KCILAOMGFEA();
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct GJDDCEKPABN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly Vector3 LKNEOPJKMKD;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2D93EF0", Offset = "0x2D926F0", VA = "0x182D93EF0")]
	public GJDDCEKPABN(Vector3 LKNEOPJKMKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E45E0", Offset = "0x6E39E0")]
public class CFPHLIKLCBH<T> : FOGCHEDOFJL<ACONOALLBCI<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4650", Offset = "0x6E3A50")]
	private readonly CNMODAPOADO<T> IALCEFPEHNE;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2954D30", Offset = "0x2953530", VA = "0x182954D30")]
	public CFPHLIKLCBH(T BEELAINJGPH, ACONOALLBCI<T> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x208A830", Offset = "0x2089030", VA = "0x18208A830", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E46B0", Offset = "0x6E3AB0")]
public class CHHJMKEHNFJ<TData> : FOGCHEDOFJL<PECJKIAANKI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4720", Offset = "0x6E3B20")]
	private readonly LDPDDJEAIOB<TData> KEKAAPBDKCA;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2959230", Offset = "0x2957A30", VA = "0x182959230")]
	public CHHJMKEHNFJ(IEnumerable<TData> GIGBDNNNEMK, Quaternion LKNEOPJKMKD, Vector3? DJKGEHJHDHA, bool DBLLGBCLPBH, bool NJJEPKGAAPO, PECJKIAANKI<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x208A830", Offset = "0x2089030", VA = "0x18208A830", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4780", Offset = "0x6E3B80")]
public class GFKNPOGPHBP<TData> : FOGCHEDOFJL<JACJNBEIJIE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x18F9B70", Offset = "0x18F8370", VA = "0x1818F9B70")]
	public GFKNPOGPHBP(JACJNBEIJIE<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x20721A0", Offset = "0x20709A0", VA = "0x1820721A0", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E47F0", Offset = "0x6E3BF0")]
public class GIOPHABMMPN<TData> : FOGCHEDOFJL<LEABGAGJMKC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly MBEPFGIFNCB KEKAAPBDKCA;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x207DF80", Offset = "0x207C780", VA = "0x18207DF80")]
	public GIOPHABMMPN(Quaternion LKNEOPJKMKD, Vector3? DJKGEHJHDHA, bool DBLLGBCLPBH, LEABGAGJMKC<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x207DF10", Offset = "0x207C710", VA = "0x18207DF10", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4860", Offset = "0x6E3C60")]
public class BBPMBHHPNFN<TData> : FOGCHEDOFJL<BFCCGJCMBAK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E48D0", Offset = "0x6E3CD0")]
	private readonly KJGMANOBKOM<TData> JEMAAKFPBFM;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2184540", Offset = "0x2182D40", VA = "0x182184540")]
	public BBPMBHHPNFN(TData[] GIGBDNNNEMK, HKLBLNKGABG[] JIINIIPALJJ, HALJELNOGOG[] KKNFKPKFEJH, float[] FJGMPDOGPED, BFCCGJCMBAK<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2184480", Offset = "0x2182C80", VA = "0x182184480", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4930", Offset = "0x6E3D30")]
public class GGAFKDNMKLO<TData> : FOGCHEDOFJL<KKLPMOKOKCL<TData>> where TData : notnull, JEDJKFJNLGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E49A0", Offset = "0x6E3DA0")]
	private readonly DANDKBHNBNC<TData> DEOHHDDKJIP;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x27826D0", Offset = "0x2780ED0", VA = "0x1827826D0")]
	public GGAFKDNMKLO(List<TData> GIGBDNNNEMK, List<bool> IMOFCMIGICB, KKLPMOKOKCL<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x207DD10", Offset = "0x207C510", VA = "0x18207DD10", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4A00", Offset = "0x6E3E00")]
public class IGELPEHMFJE<TData> : FOGCHEDOFJL<MGHFAJFLOGP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x18F9B70", Offset = "0x18F8370", VA = "0x1818F9B70")]
	public IGELPEHMFJE(MGHFAJFLOGP<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2032260", Offset = "0x2030A60", VA = "0x182032260", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct HMAPNNKKKPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly Vector3 KCNMKAOIEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly bool OIPNPCFLPMI;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6EFF0E0", Offset = "0x6EFD8E0", VA = "0x186EFF0E0")]
	public HMAPNNKKKPJ(Vector3 KCNMKAOIEBP, bool OIPNPCFLPMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct GDHNHOOINEF<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T BEELAINJGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly bool NNANFGILFLJ;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2777E80", Offset = "0x2776680", VA = "0x182777E80")]
	public GDHNHOOINEF(T GGJLPJDGFLK, bool KOFFKNLBDFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface NBFLOHKOJMC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FDCAJAANPAG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4A70", Offset = "0x6E3E70")] in DNNBFCNNBGC<TData?> JEMAAKFPBFM);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KCILAOMGFEA();
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4AE0", Offset = "0x6E3EE0")]
public class MPJBPGGLLIC<TData> : FOGCHEDOFJL<NBFLOHKOJMC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4B50", Offset = "0x6E3F50")]
	private readonly DNNBFCNNBGC<TData> JEMAAKFPBFM;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x23BFD50", Offset = "0x23BE550", VA = "0x1823BFD50")]
	public MPJBPGGLLIC(IEnumerable<TData> GIGBDNNNEMK, HKLBLNKGABG JIINIIPALJJ, HALJELNOGOG KKNFKPKFEJH, float FJGMPDOGPED, NBFLOHKOJMC<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2184480", Offset = "0x2182C80", VA = "0x182184480", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface EDNMKGKFOPD<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> ELJLDEAIMOA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4BB0", Offset = "0x6E3FB0")] in MMBFHNIINLO<TSpawnInfo> BIDFDAOLOPO, CancellationToken NNLBJPBEHPF);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct MMBFHNIINLO<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TSpawnInfo LBNLPIDMHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public Vector3 PAOMABBDKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public Quaternion APAHFEOKBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float FJJHHNAFAEK;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xE12920", Offset = "0xE11120", VA = "0x180E12920")]
	public MMBFHNIINLO(TSpawnInfo LBNLPIDMHKK, Vector3 PAOMABBDKAH, Quaternion APAHFEOKBOD, float FJJHHNAFAEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface JEDJKFJNLGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool HCHDNBHNEAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4C20", Offset = "0x6E4020")]
public class NHPNFFGOJOI<TData> : FOGCHEDOFJL<ELJFDFAFHJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly IINLFFHOGGG HKFHFHBGMLC;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4C2B250", Offset = "0x4C29A50", VA = "0x184C2B250")]
	public NHPNFFGOJOI(Guid BGNDLGIDBBK, int AMOEKOMGDLG, Vector3 PAOMABBDKAH, Quaternion APAHFEOKBOD, float MMDOOKNHKEB, bool OIPNPCFLPMI, ELJFDFAFHJH<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x27859F0", Offset = "0x27841F0", VA = "0x1827859F0", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4C90", Offset = "0x6E4090")]
public class MDDNKELBNPE<TData> : FOGCHEDOFJL<KKLPMOKOKCL<TData>> where TData : notnull, JEDJKFJNLGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4D00", Offset = "0x6E4100")]
	private readonly AMPLLBIPABH<TData> DEOHHDDKJIP;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x210FA10", Offset = "0x210E210", VA = "0x18210FA10")]
	public MDDNKELBNPE(List<TData> GIGBDNNNEMK, bool JOBEOHEHBFI, KKLPMOKOKCL<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x208A830", Offset = "0x2089030", VA = "0x18208A830", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4D60", Offset = "0x6E4160")]
public class LCPBHMJILHM<TData> : FOGCHEDOFJL<HIKKLIAEDAA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly TData OFNDNMKLOGC;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x24D50B0", Offset = "0x24D38B0", VA = "0x1824D50B0")]
	public LCPBHMJILHM(TData OFNDNMKLOGC, HIKKLIAEDAA<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x24D4F50", Offset = "0x24D3750", VA = "0x1824D4F50", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4DD0", Offset = "0x6E41D0")]
public abstract class FOGCHEDOFJL<TReceiver> : GLAPHAJGGPO<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x18F9B70", Offset = "0x18F8370", VA = "0x1818F9B70")]
	public FOGCHEDOFJL(TReceiver PIJFGKNLICL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface AGGMHIMLGAB
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Bounds EOJLPECHBEM
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Transform BHFPPNAIJPD
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Bounds BNFBNFFLOEL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform NLNBDNAPDDL
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Vector3 NNDMNJPFJDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool CLIIOLFHLPI = true, int BFLCDACILPJ = 0);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool ABFIPLFDEID, object AMCDGOPKAOE);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct AMPLLBIPABH<TData> where TData : notnull, JEDJKFJNLGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public IEnumerable<TData> ONBPDDGKCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public bool JOBEOHEHBFI;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2701210", Offset = "0x26FFA10", VA = "0x182701210")]
	public AMPLLBIPABH(IEnumerable<TData> MHOONJNCMEO, bool LLMOOLFNHME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct DANDKBHNBNC<TData> where TData : notnull, JEDJKFJNLGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public List<TData> ONBPDDGKCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public List<bool> IMOFCMIGICB;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2402410", Offset = "0x2400C10", VA = "0x182402410")]
	public DANDKBHNBNC(List<TData> MHOONJNCMEO, List<bool> NMEKPEAOGNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface BJGLFIKIOJB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool IFGGLIDLIBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int DJMANHBAKCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	IEnumerable<TData> HNNANEMEOBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData AMBKJGJJFNP);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData AMBKJGJJFNP);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface CHIFKKBCBMC
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface MGHFAJFLOGP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OBAPMKEKDOM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4E40", Offset = "0x6E4240")] in ILMDOEIOMGH<TData?> GDHECIODNLH);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FDCAJAANPAG(in GJDDCEKPABN NOOKJGIBAIO);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KCILAOMGFEA();
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4EB0", Offset = "0x6E42B0")]
public class HHHALNKOFIN<TData> : FOGCHEDOFJL<NBFLOHKOJMC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x18F9B70", Offset = "0x18F8370", VA = "0x1818F9B70")]
	public HHHALNKOFIN(NBFLOHKOJMC<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x29AA620", Offset = "0x29A8E20", VA = "0x1829AA620", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface CJBEFEMILKG : JEDJKFJNLGJ
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4F20", Offset = "0x6E4320")]
public abstract class FHLBHOLPKNI<TReceiver, TFromTask> : GLAPHAJGGPO<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x18F9B70", Offset = "0x18F8370", VA = "0x1818F9B70")]
	public FHLBHOLPKNI(TReceiver PIJFGKNLICL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface ACONOALLBCI<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OBAPMKEKDOM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4F90", Offset = "0x6E4390")] in CNMODAPOADO<T?> IALCEFPEHNE);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KCILAOMGFEA();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E5000", Offset = "0x6E4400")]
public class EEPAEBHNDJJ<TData> : FOGCHEDOFJL<JACJNBEIJIE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E5070", Offset = "0x6E4470")]
	private readonly IBOCINBELMJ<TData> PFFBDKNPMAD;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2DAFAC0", Offset = "0x2DAE2C0", VA = "0x182DAFAC0")]
	public EEPAEBHNDJJ(IEnumerable<TData> GIGBDNNNEMK, bool NJJEPKGAAPO, JACJNBEIJIE<TData> PIJFGKNLICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x208A830", Offset = "0x2089030", VA = "0x18208A830", Slot = "4")]
	public override bool LCEFAGCAIBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface PFICFHOCKMK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LCEFAGCAIBN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E50D0", Offset = "0x6E44D0")] in CGOJHAFNGKA<TData?> JEMAAKFPBFM);
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
