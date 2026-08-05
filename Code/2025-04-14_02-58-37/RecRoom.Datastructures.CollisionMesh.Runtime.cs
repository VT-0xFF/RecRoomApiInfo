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
public struct FIAIICBGMOF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct FCENLHCICDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int GKDBNFAKKMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int BLIECLBOJIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int EJGJNONELMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int DHFGHPKLEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int LJBHGFNJDCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int DOFFHMOPOLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 EHKFFBMDPGE;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x78C46A0", Offset = "0x78C30A0", VA = "0x1878C46A0")]
		public FCENLHCICDP(int BHBJAHCANCD, int JMJGBEDOJOP, int AKHLAPCKFHA, int FGLIFBJBIJK, int NFJEMPIBOBO, int EMJHEHGECKB, float3 MDIKGGEOGCO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct MFLFBGHIJFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int EMOFMJBIKPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int LHNBMBGNIGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float CABHFJEBLGH;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xC19E60", Offset = "0xC18860", VA = "0x180C19E60")]
		public MFLFBGHIJFN(int GJPBKNDCAIE, int BABJDLEMOHH, float ODNBFFKICHM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct PBOEMEFMIOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int LHNBMBGNIGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int PFCBMGBCJPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int AOFNCGKOCEK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, FCENLHCICDP> APPJEELLEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<MFLFBGHIJFN> IAOGLGOLKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> ECKAPFJLJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<PBOEMEFMIOL> MLPOJOBCBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> CMHEGBDKCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int OAAPCBNBNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int GKHIOBIGHJO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x78C4F30", Offset = "0x78C3930", VA = "0x1878C4F30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x78C7920", Offset = "0x78C6320", VA = "0x1878C7920")]
	public bool LCPGJPLIPLO([In] NativeArray<float3> OMPAFMFBPJK, NativeList<float3> ALPJCIFDBKF, NativeList<int> BNBBEFECELE, Allocator DDBBFOCJEFL, CancellationToken BJEPDCCBCHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x78C51B0", Offset = "0x78C3BB0", VA = "0x1878C51B0")]
	private void ELAEPFFNBKM([In] NativeArray<float3> OMPAFMFBPJK, Allocator DDBBFOCJEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x78C59E0", Offset = "0x78C43E0", VA = "0x1878C59E0")]
	private void IFPIEPCCAJD([In] NativeArray<float3> OMPAFMFBPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x78C7AC0", Offset = "0x78C64C0", VA = "0x1878C7AC0")]
	private void OMFBCHFKKFK([In] NativeArray<float3> OMPAFMFBPJK, [Out] int ODBANGLDICE, [Out] int PDHLNHHGDKI, [Out] int GPBMMOAIGGB, [Out] int KGDKJCCJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x78C53F0", Offset = "0x78C3DF0", VA = "0x1878C53F0")]
	private void HNCKKLCKNBJ([In] NativeArray<float3> OMPAFMFBPJK, Allocator DDBBFOCJEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x78C49F0", Offset = "0x78C33F0", VA = "0x1878C49F0")]
	private void CEHLLABDEFI([In] NativeArray<float3> OMPAFMFBPJK, float3 FJGNBGJJOPK, int CLDMHNFBNFN, FCENLHCICDP CCOHHNBPOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x78C55F0", Offset = "0x78C3FF0", VA = "0x1878C55F0")]
	private void IEGOCILBGMH([In] NativeArray<float3> OMPAFMFBPJK, float3 FJGNBGJJOPK, int EGILGFNBKDD, int GKHIOBIGHJO, FCENLHCICDP CCOHHNBPOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x78C7320", Offset = "0x78C5D20", VA = "0x1878C7320")]
	private void KAGILBKEGIA([In] NativeArray<float3> OMPAFMFBPJK, int LDGFPMGBJED, Allocator DDBBFOCJEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x78C6AD0", Offset = "0x78C54D0", VA = "0x1878C6AD0")]
	private void JHIPOMAGJEA([In] NativeArray<float3> OMPAFMFBPJK, Allocator DDBBFOCJEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x78C6E40", Offset = "0x78C5840", VA = "0x1878C6E40")]
	private void JMDCGINPJAI([In] NativeArray<float3> OMPAFMFBPJK, NativeList<float3> ALPJCIFDBKF, NativeList<int> BNBBEFECELE, Allocator DDBBFOCJEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x78C4ED0", Offset = "0x78C38D0", VA = "0x1878C4ED0")]
	private float DABCCCIPHBP(float3 FJGNBGJJOPK, float3 ICDBCMHNAFB, FCENLHCICDP CCOHHNBPOBE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x78C50A0", Offset = "0x78C3AA0", VA = "0x1878C50A0")]
	private float3 EHKFFBMDPGE(float3 BHBJAHCANCD, float3 JMJGBEDOJOP, float3 AKHLAPCKFHA)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x78C5070", Offset = "0x78C3A70", VA = "0x1878C5070")]
	private static float EEEMEDMGNGK(float3 KEEADJCBJCP, float3 LKKBJAKGIGL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x78C7A60", Offset = "0x78C6460", VA = "0x1878C7A60")]
	private static float3 OLJAGNKIJLL(float3 KEEADJCBJCP, float3 LKKBJAKGIGL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x78C5390", Offset = "0x78C3D90", VA = "0x1878C5390")]
	private bool HJMCHFIKFOJ(float3 KEEADJCBJCP, float3 LKKBJAKGIGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x78C6A00", Offset = "0x78C5400", VA = "0x1878C6A00")]
	private bool JDNJICKBLMF(float3 KEEADJCBJCP, float3 LKKBJAKGIGL, float3 LHJMDMLADDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x78C46E0", Offset = "0x78C30E0", VA = "0x1878C46E0")]
	private bool BMEADFADIHN(float3 KEEADJCBJCP, float3 LKKBJAKGIGL, float3 LHJMDMLADDA, float3 ODNBFFKICHM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct MGIEGKAOFPH : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct HKJIFDGBDPM
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
	private NativeList<float3> NPHNKEBKDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> IFOPLKBAEHG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KPJGFPJBEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x78C80A0", Offset = "0x78C6AA0", VA = "0x1878C80A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int EFBCAMNNDAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x78C8160", Offset = "0x78C6B60", VA = "0x1878C8160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MNPGKBIJONA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x78C8EC0", Offset = "0x78C78C0", VA = "0x1878C8EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public AFKOBIHLFKP IOFCJILJBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x78C80E0", Offset = "0x78C6AE0", VA = "0x1878C80E0")]
		get
		{
			return default(AFKOBIHLFKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x78C9290", Offset = "0x78C7C90", VA = "0x1878C9290")]
	public MGIEGKAOFPH(int OMPODOJBIJB, int MPHEBKPJJLI, Allocator DDBBFOCJEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x78C8F00", Offset = "0x78C7900", VA = "0x1878C8F00")]
	public MGIEGKAOFPH(AFKOBIHLFKP DIOEOAEACHE, Allocator DDBBFOCJEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x78C9350", Offset = "0x78C7D50", VA = "0x1878C9350")]
	public MGIEGKAOFPH(Mesh LKDNKMEFADL, Allocator DDBBFOCJEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x78C8F30", Offset = "0x78C7930", VA = "0x1878C8F30")]
	public MGIEGKAOFPH(MGIEGKAOFPH DFPGGEDGGGN, Allocator DDBBFOCJEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x78C83D0", Offset = "0x78C6DD0", VA = "0x1878C83D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x78C8500", Offset = "0x78C6F00", VA = "0x1878C8500")]
	public void HEHCILJMFIP([In] MGIEGKAOFPH HBNNPNFAEOC, float4x4 FFKIELGPMDB, Transform DFOOOFCKFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x78C8D70", Offset = "0x78C7770", VA = "0x1878C8D70")]
	public void OCKFBFFGEKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x78C8880", Offset = "0x78C7280", VA = "0x1878C8880")]
	public void NMPMNCOPEEO(float FPNKBMPOCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x78C81A0", Offset = "0x78C6BA0", VA = "0x1878C81A0")]
	public MGIEGKAOFPH CBJPIHMGPPC(Allocator DDBBFOCJEFL, CancellationToken BJEPDCCBCHJ)
	{
		return default(MGIEGKAOFPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x78C7F80", Offset = "0x78C6980", VA = "0x1878C7F80")]
	public Mesh AFHLMADFBBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x78C8460", Offset = "0x78C6E60", VA = "0x1878C8460")]
	private unsafe static float3* FDCHHADOKLP(NativeArray<float3> NAKGFAINKPB)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x78C84B0", Offset = "0x78C6EB0", VA = "0x1878C84B0")]
	private unsafe static int* FDCHHADOKLP(NativeArray<int> NAKGFAINKPB)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x78C83A0", Offset = "0x78C6DA0", VA = "0x1878C83A0")]
	[CompilerGenerated]
	internal static void CGKLADANBJC(int BMNEHCOCOCC, int HECNBIHIHBC, HKJIFDGBDPM P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct AFKOBIHLFKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int KPJGFPJBEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int EFBCAMNNDAP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PDFEPCBJGON
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x78C45F0", Offset = "0x78C2FF0", VA = "0x1878C45F0")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x25919B0", Offset = "0x25903B0", VA = "0x1825919B0")]
	public static AFKOBIHLFKP JHHIBKDHNEN(AFKOBIHLFKP KEEADJCBJCP, AFKOBIHLFKP LKKBJAKGIGL)
	{
		return default(AFKOBIHLFKP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x78C45D0", Offset = "0x78C2FD0", VA = "0x1878C45D0")]
	public static AFKOBIHLFKP ILGHPIKFAPN(AFKOBIHLFKP OONAMCJFEAL, int NFLJGFIFAHD)
	{
		return default(AFKOBIHLFKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x78C4530", Offset = "0x78C2F30", VA = "0x1878C4530", Slot = "0")]
	public override bool Equals(object FDMDAENMFKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x78C4580", Offset = "0x78C2F80", VA = "0x1878C4580", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x78C4600", Offset = "0x78C3000", VA = "0x1878C4600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
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
