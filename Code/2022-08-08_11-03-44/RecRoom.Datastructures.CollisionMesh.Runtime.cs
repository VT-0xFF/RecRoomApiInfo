using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct AMMECCFBFMA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct KBPJGDBCIMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int MNLIGFMLAAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int KBFFGPHOHOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int LOHEHEIAMKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int MOPPANJDDIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int KONDKOHECGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int AJBMDDBGMGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 MJPNLMFNCPK;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x58101A0", Offset = "0x580F1A0", VA = "0x1858101A0")]
		public KBPJGDBCIMB(int IABGANOBCHO, int PCOAHABIDFP, int MMFPEOFPGMG, int FPICLFMPPAD, int BOMFIICBNDD, int MIBPGPCGFKN, float3 IFEFNGAGKNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct OCJNOGAMCOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int OECOCJHECPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int CMJFLIHAAPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float CIGEDCELPLO;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1F64620", Offset = "0x1F63620", VA = "0x181F64620")]
		public OCJNOGAMCOD(int BKLFBAMHBAG, int FHGEGKGNIPA, float COCNKFFEBDI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct BCHFFABAPJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int CMJFLIHAAPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int AGGFKPJDMCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int NGNCNPAOFOC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeHashMap<int, KBPJGDBCIMB> AJBCDFLBNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<OCJNOGAMCOD> OHCHIJLEGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeHashMap<int, int> MPMOPPNMEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<BCHFFABAPJP> NDENGIAJAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeHashMap<int, int> OIINNEJOHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int DHFIBFBLANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int IPIJFABODPE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x580D450", Offset = "0x580C450", VA = "0x18580D450", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x580E510", Offset = "0x580D510", VA = "0x18580E510")]
	public bool FOOBPMKJBKL(in NativeArray<float3> EJJLFGKAKPJ, ref NativeList<float3> MDGDPDIFKEJ, ref NativeList<int> BKMGCALIDIC, Allocator LKNIKCJFBFH, CancellationToken JNDOKGNDNMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x580C980", Offset = "0x580B980", VA = "0x18580C980")]
	private void AICHPOAHICB(in NativeArray<float3> EJJLFGKAKPJ, Allocator LKNIKCJFBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x580D540", Offset = "0x580C540", VA = "0x18580D540")]
	private void EDGFOJMGBMN(in NativeArray<float3> EJJLFGKAKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x580E910", Offset = "0x580D910", VA = "0x18580E910")]
	private void HFLJLPKMNAB(in NativeArray<float3> EJJLFGKAKPJ, out int ALMGENDFMNF, out int JEHIOGPNHAI, out int IMPJFGECIMC, out int GGIENPGLOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x580E6C0", Offset = "0x580D6C0", VA = "0x18580E6C0")]
	private void GOPIFDKFIJC(in NativeArray<float3> EJJLFGKAKPJ, Allocator LKNIKCJFBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x580FB00", Offset = "0x580EB00", VA = "0x18580FB00")]
	private void MPAKAEHKFPN(in NativeArray<float3> EJJLFGKAKPJ, float3 EAKNLHDPPEJ, int AOFOMPKIHHJ, KBPJGDBCIMB IDLDBHKIIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x580E0E0", Offset = "0x580D0E0", VA = "0x18580E0E0")]
	private void EMPGIHLPIFP(in NativeArray<float3> EJJLFGKAKPJ, float3 EAKNLHDPPEJ, int DAKPLNBHOHB, int IPIJFABODPE, KBPJGDBCIMB IDLDBHKIIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x580CAE0", Offset = "0x580BAE0", VA = "0x18580CAE0")]
	private void BABLFHHHOBP(in NativeArray<float3> EJJLFGKAKPJ, int FKOKNFHOOLK, Allocator LKNIKCJFBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x580F630", Offset = "0x580E630", VA = "0x18580F630")]
	private void KIONFKBKPDN(in NativeArray<float3> EJJLFGKAKPJ, Allocator LKNIKCJFBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x580D0F0", Offset = "0x580C0F0", VA = "0x18580D0F0")]
	private void DDDNAPIFKCI(in NativeArray<float3> EJJLFGKAKPJ, ref NativeList<float3> MDGDPDIFKEJ, ref NativeList<int> BKMGCALIDIC, Allocator LKNIKCJFBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x580D070", Offset = "0x580C070", VA = "0x18580D070")]
	private float CPHGPNPMMMG(float3 EAKNLHDPPEJ, float3 BEOHGOFMPAH, KBPJGDBCIMB IDLDBHKIIID)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x580F970", Offset = "0x580E970", VA = "0x18580F970")]
	private float3 MJPNLMFNCPK(float3 IABGANOBCHO, float3 PCOAHABIDFP, float3 MMFPEOFPGMG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x56F85A0", Offset = "0x56F75A0", VA = "0x1856F85A0")]
	private static float DPLKJCIECEC(float3 KKHMNCLOHHK, float3 GMPKOOIGMDG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x580E5F0", Offset = "0x580D5F0", VA = "0x18580E5F0")]
	private static float3 GJNLCKCOFMH(float3 KKHMNCLOHHK, float3 GMPKOOIGMDG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x580CFB0", Offset = "0x580BFB0", VA = "0x18580CFB0")]
	private bool BDPEGIONFGJ(float3 KKHMNCLOHHK, float3 GMPKOOIGMDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x580F4F0", Offset = "0x580E4F0", VA = "0x18580F4F0")]
	private bool KCPPKCAPIOH(float3 KKHMNCLOHHK, float3 GMPKOOIGMDG, float3 ADHKGFCOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x580ED50", Offset = "0x580DD50", VA = "0x18580ED50")]
	private bool ICNBNHPLJAO(float3 KKHMNCLOHHK, float3 GMPKOOIGMDG, float3 ADHKGFCOILB, float3 COCNKFFEBDI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct KOKOIEIODGE : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct DJDCJBBABOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public unsafe int* indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int indexCount;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<float3> DPGGOPPIFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> OPIOLHBLMDB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GJDBFLAKPBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5810720", Offset = "0x580F720", VA = "0x185810720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HLFANDPAGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5810760", Offset = "0x580F760", VA = "0x185810760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LNHKEACDENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5810E30", Offset = "0x580FE30", VA = "0x185810E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public BNBNGPCBLKA LDFBJAMIBCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5810210", Offset = "0x580F210", VA = "0x185810210")]
		get
		{
			return default(BNBNGPCBLKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5811490", Offset = "0x5810490", VA = "0x185811490")]
	public KOKOIEIODGE(int IOHDHKEAMHE, int HACGPCFNHFB, Allocator LKNIKCJFBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5811770", Offset = "0x5810770", VA = "0x185811770")]
	public KOKOIEIODGE(BNBNGPCBLKA HJPEKCGNPMC, Allocator LKNIKCJFBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5811310", Offset = "0x5810310", VA = "0x185811310")]
	public KOKOIEIODGE(Mesh OONJFFKJHPD, Allocator LKNIKCJFBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5811540", Offset = "0x5810540", VA = "0x185811540")]
	public KOKOIEIODGE(KOKOIEIODGE JEJGBICCBLN, Allocator LKNIKCJFBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x58105A0", Offset = "0x580F5A0", VA = "0x1858105A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5810E70", Offset = "0x580FE70", VA = "0x185810E70")]
	public void PPCBFHPPBHE(in KOKOIEIODGE LAAFNHPNJCJ, float4x4 HMDIPICBOLD, Transform MLABPENBJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5810C70", Offset = "0x580FC70", VA = "0x185810C70")]
	public void JCCEHACFKIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x58107A0", Offset = "0x580F7A0", VA = "0x1858107A0")]
	public void JADHHHCBEON(float KEOEBHPOCHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5810290", Offset = "0x580F290", VA = "0x185810290")]
	public KOKOIEIODGE CKKAJCODAPE(Allocator LKNIKCJFBFH, CancellationToken JNDOKGNDNMO)
	{
		return default(KOKOIEIODGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5810620", Offset = "0x580F620", VA = "0x185810620")]
	public Mesh FDOOEANONMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x58112C0", Offset = "0x58102C0", VA = "0x1858112C0")]
	private unsafe static float3* PPCFHLIKOFA(NativeArray<float3> DNAEDFOPGEJ)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5811270", Offset = "0x5810270", VA = "0x185811270")]
	private unsafe static int* PPCFHLIKOFA(NativeArray<int> DNAEDFOPGEJ)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x58101E0", Offset = "0x580F1E0", VA = "0x1858101E0")]
	[CompilerGenerated]
	internal static void BLADELBGBOI(int GLPNFKNHHKF, int MNCENPLBLKL, ref DJDCJBBABOG P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct BNBNGPCBLKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int GJDBFLAKPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int HLFANDPAGAH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int OFFJNAHOMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5810100", Offset = "0x580F100", VA = "0x185810100")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x45E4C20", Offset = "0x45E3C20", VA = "0x1845E4C20")]
	public static BNBNGPCBLKA JCNGAANMENI(BNBNGPCBLKA KKHMNCLOHHK, BNBNGPCBLKA GMPKOOIGMDG)
	{
		return default(BNBNGPCBLKA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5810040", Offset = "0x580F040", VA = "0x185810040")]
	public static BNBNGPCBLKA EEMIMEEFKMB(BNBNGPCBLKA BEPNEODPHKP, int DGMBKMBCJJI)
	{
		return default(BNBNGPCBLKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5810060", Offset = "0x580F060", VA = "0x185810060", Slot = "0")]
	public override bool Equals(object IGBJOKPLGMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x58100B0", Offset = "0x580F0B0", VA = "0x1858100B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5810110", Offset = "0x580F110", VA = "0x185810110", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface ACMCOCGDOIG
{
}
namespace Cpp2IlInjected;

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
