using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.AssetIds;
using RecRoom.Avatars;
using RecRoom.Core.Studio;
using RecRoom.Logging.Attributes;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_AvatarRenderingSystems_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : NNEIMJEPGMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x629D170", Offset = "0x629C370", VA = "0x18629D170", Slot = "4")]
		public override void FLGJIGKCNJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class RecNetCDNAssetReference : AssetReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private RecNetCDNKey key;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override object RuntimeKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7CE8A0", Offset = "0x7CDAA0", VA = "0x1807CE8A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x62AB2C0", Offset = "0x62AA4C0", VA = "0x1862AB2C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x62AB1F0", Offset = "0x62AA3F0", VA = "0x1862AB1F0", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x62AB280", Offset = "0x62AA480", VA = "0x1862AB280")]
		public RecNetCDNAssetReference(RecNetCDNKey MNOIAMGNLNL)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string bundleUrl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string itemPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public List<RecNetCDNKey> Dependencies;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7CAF90", Offset = "0x7CA190", VA = "0x1807CAF90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7CB520", Offset = "0x7CA720", VA = "0x1807CB520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4F0", Offset = "0x7CA6F0", VA = "0x1807CB4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x62AB300", Offset = "0x62AA500", VA = "0x1862AB300")]
		public static RecNetCDNKey GPEKLLPKBFP(string FPJMIIGPBBL, string BBAANMPEIFH = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5ADAE70", Offset = "0x5ADA070", VA = "0x185ADAE70")]
		public void FJCACKGICHB(string DHHLMPAHLKD, string ICJNJPHEBHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x62AB390", Offset = "0x62AA590", VA = "0x1862AB390")]
		public RecNetCDNKey LFHFKCBEKFB(string NFBMNBJKPCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x62AB440", Offset = "0x62AA640", VA = "0x1862AB440")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[DLFNECBFFJA]
public class IPOLJMJAAMC : POCHFFLPIAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> JOKPAPIOFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> JDJNGGICKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> HMHLBJADDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> PIHKDJICBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> PHBFMCJMJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> FNCJIPHDGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> BENJABNKIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator GJHEHJNJCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected EJDHPAFPNLO MGLGENAPOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte DKMKCLCGELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> LLHHDFIHFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> JDLBCAGADOK;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x629C3A0", Offset = "0x629B5A0", VA = "0x18629C3A0", Slot = "4")]
	public void NGHFOPKNKOI(Mesh COKNMDIBDNP, Matrix4x4 HJFMGBIMNLI, byte[] HNBEHHPGGBL, bool DEIICDLKIKO = false, GKPJGAOJHHB.JGJMGEIKMEE ICPHBADFHIG = (GKPJGAOJHHB.JGJMGEIKMEE)0, int HCMBBGLGDON = -1, bool IEAELJEFLEK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x629C360", Offset = "0x629B560", VA = "0x18629C360", Slot = "5")]
	public void IBAGCOMAOHB(Allocator LGNDPBNMKMP, EJDHPAFPNLO LJGGELGNOGO, byte NLNFKDNDKLN, [Optional] IList<int> FONOKJEOLLF, [Optional] IList<int> FLPFBGGDDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x629C230", Offset = "0x629B430", VA = "0x18629C230")]
	private static void BOGKAJGDOKD(Mesh COKNMDIBDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x629C860", Offset = "0x629BA60", VA = "0x18629C860")]
	public IPOLJMJAAMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DLFNECBFFJA]
public struct DEJGMOGPGME : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public OFCENFMNMGH OKDLNDMNBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int MPJAOEIDNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public AMBHIKOGFMK PKLCGKPCNPB;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6296670", Offset = "0x6295870", VA = "0x186296670", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DLFNECBFFJA]
[NativeContainer]
public struct AMBHIKOGFMK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct JNDLNPEGCCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector3 ANAKNBOHHOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 BGIIKDPIDDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector4 MBNLKPDJGPN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct JDLPDOANCNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float DFPLAFELCNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float AKEDAKPOAMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float KFKEHPMOEFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float CDMJECHFIIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte DBKJPEKGGFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte CAJFHMIIEKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte DEIPCBHOMIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte DMIDOPJPJHP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct KNNLOFGADGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half DFPLAFELCNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half AKEDAKPOAMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half KFKEHPMOEFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half CDMJECHFIIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte DBKJPEKGGFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte CAJFHMIIEKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte DEIPCBHOMIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte DMIDOPJPJHP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct MEPIOIKMBGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 LHAAJEOMGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 NBBFMIAFLBK;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct FIEHGODIAGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half4 LHAAJEOMGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 NBBFMIAFLBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 OKDKHCKHLBC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct PNEFEHIBBAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 LHAAJEOMGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 NBBFMIAFLBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 OKDKHCKHLBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 KLKCHFGMCKE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct JOJJBLMCIEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half4 LHAAJEOMGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 NBBFMIAFLBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 OKDKHCKHLBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 KLKCHFGMCKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 HFNGLJFFGCK;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct ENNBDALNION
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float DFPLAFELCNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float AKEDAKPOAMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float KFKEHPMOEFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float CDMJECHFIIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int DBKJPEKGGFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int CAJFHMIIEKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int DEIPCBHOMIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int DMIDOPJPJHP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct DPBGICKENJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Color LHAAJEOMGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 NBBFMIAFLBK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct DEAAGIKJBGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color LHAAJEOMGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 NBBFMIAFLBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 OKDKHCKHLBC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct GCAPBEOAIFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color LHAAJEOMGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 NBBFMIAFLBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 OKDKHCKHLBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 KLKCHFGMCKE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct DEDKDPBBNEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color LHAAJEOMGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 NBBFMIAFLBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 OKDKHCKHLBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 KLKCHFGMCKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 HFNGLJFFGCK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool CAAHDHDHONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<JNDLNPEGCCB> CMJJGLGAMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<MEPIOIKMBGO> FOOCMOHFFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<FIEHGODIAGN> ENFMEJKHJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<PNEFEHIBBAN> LBMMLDBHFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<JOJJBLMCIEJ> LAAJJCCAPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<KNNLOFGADGE> KEBEAKDBPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<JDLPDOANCNA> PHOOPEADLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<DPBGICKENJC> KADOINBECLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<DEAAGIKJBGL> MBEIILPJPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<GCAPBEOAIFJ> ABLFLIFIKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<DEDKDPBBNEG> IFGPOGHIGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<ENNBDALNION> NECCJNNOFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> LAAFBNKFILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> POLCLNMBOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> COGOFOEABKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> BOFJPDFDGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> CEKEBOOMGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> OBIIOHGCBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> MLHADJBCHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<BoneWeight> PPAFOLDJBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> EOHMOLAFOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool INBDJAAIAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool DBMJCBEFOMJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int KNMCPBOPKCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6293960", Offset = "0x6292B60", VA = "0x186293960")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x62955D0", Offset = "0x62947D0", VA = "0x1862955D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int LCHPMKBLNJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6295680", Offset = "0x6294880", VA = "0x186295680")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6295670", Offset = "0x6294870", VA = "0x186295670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int MEPFKOEGADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6293D90", Offset = "0x6292F90", VA = "0x186293D90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6295690", Offset = "0x6294890", VA = "0x186295690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int CAKDHPJLKNG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6293D20", Offset = "0x6292F20", VA = "0x186293D20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6295B10", Offset = "0x6294D10", VA = "0x186295B10")]
	public AMBHIKOGFMK(int FBKFLMAEHFI, int KJBOEEMJNBI, int DMDBDDOMMIB, int IKAHMBEANOD, Allocator LGNDPBNMKMP, int DHJPNBHCBBB, FLLLLMALOJC FKDPKNIELHO, bool INBDJAAIAIO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x62955E0", Offset = "0x62947E0", VA = "0x1862955E0")]
	public void HDIKCJFCFKB(int PMNHOLIPOMJ, Vector3 HCFEJGBILDB, Vector3 AMAGNFDOAPP, Vector4 GIHFGGLMPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6294330", Offset = "0x6293530", VA = "0x186294330")]
	public void EJNNHCFPCIG(int PMNHOLIPOMJ, BoneWeight DHGHKDPEHCO, NativeSlice<byte> HNBEHHPGGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6294000", Offset = "0x6293200", VA = "0x186294000")]
	public Color EBDMCLFAFHP(int PMNHOLIPOMJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6295710", Offset = "0x6294910", VA = "0x186295710")]
	public void PJADKGBIBFN(int PMNHOLIPOMJ, Color HHHFIGOCAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6293970", Offset = "0x6292B70", VA = "0x186293970")]
	public void BOEPPCCPLDE(byte DFAIPKLPNIB, int PMNHOLIPOMJ, Vector2 PLCOMDBOPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x62956A0", Offset = "0x62948A0", VA = "0x1862956A0")]
	public void LJJHKHBJLCP(int PMNHOLIPOMJ, int DAFJNNBBDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x62956B0", Offset = "0x62948B0", VA = "0x1862956B0")]
	public bool MPNPIIHHKGO(int DFAIPKLPNIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6293890", Offset = "0x6292A90", VA = "0x186293890")]
	public void AHDLBLPEGNP(int DAJMIEKDOHC, int CFPEDCFCDGK, int MKCBFIBLIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6293DA0", Offset = "0x6292FA0", VA = "0x186293DA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6294760", Offset = "0x6293960", VA = "0x186294760")]
	public Mesh EOFOBPDCCGK([Optional] string MAEINOOIDGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
[DLFNECBFFJA]
[NativeContainer]
public struct OFCENFMNMGH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Mesh.MeshDataArray KJIJMHLEBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<int> IBFHEIGGMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> LOOHFMJECBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<BoneWeight> PPAFOLDJBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<Matrix4x4> NOHBDNLCLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> GGPENLLODHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<byte> ADFCIHAKDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> PIGLOJAKDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> HBPHHPDFPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeArray<sbyte> GDINFPLMPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<byte> CBLJCNCHHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<bool> IEAELJEFLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<int> HCMBBGLGDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool INBDJAAIAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<int> CHBODEMFCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool DBMJCBEFOMJ;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int EJGEOKNPOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x62A9990", Offset = "0x62A8B90", VA = "0x1862A9990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int DNNDEDEANNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x62A99E0", Offset = "0x62A8BE0", VA = "0x1862A99E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int KLPPFLKKDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x62A9DB0", Offset = "0x62A8FB0", VA = "0x1862A9DB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int NCOBJPMBLNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x62A9E90", Offset = "0x62A9090", VA = "0x1862A9E90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x62A99B0", Offset = "0x62A8BB0", VA = "0x1862A99B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int KNMCPBOPKCD
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x62A9980", Offset = "0x62A8B80", VA = "0x1862A9980")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x62A9E80", Offset = "0x62A9080", VA = "0x1862A9E80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int ICAIIKCDMIE
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x62A99C0", Offset = "0x62A8BC0", VA = "0x1862A99C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x62A99A0", Offset = "0x62A8BA0", VA = "0x1862A99A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public EJDHPAFPNLO MDKOMOLNHLP
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x62A99D0", Offset = "0x62A8BD0", VA = "0x1862A99D0")]
		get
		{
			return default(EJDHPAFPNLO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x62A9F80", Offset = "0x62A9180", VA = "0x1862A9F80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte OOPEADBKAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x62A9EA0", Offset = "0x62A90A0", VA = "0x1862A9EA0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x62A9F90", Offset = "0x62A9190", VA = "0x1862A9F90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public HGCNGPEJLOI FOFBNHMHKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x62A9B60", Offset = "0x62A8D60", VA = "0x1862A9B60")]
		get
		{
			return default(HGCNGPEJLOI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x62A9FA0", Offset = "0x62A91A0", VA = "0x1862A9FA0")]
	public OFCENFMNMGH(IList<Mesh> JMHBFOAJIKM, IList<Matrix4x4> OFEGKANHFKO, IList<bool> IEAELJEFLEK, byte NLNFKDNDKLN, IList<byte[]> BMKJNFFKBMD, IList<int> FADBDEHNMBK, IList<bool> JGMLGIDAJMM, IList<int> HCMBBGLGDON, IList<int> FONOKJEOLLF, IList<int> AJFHLEJPMDK, Allocator LGNDPBNMKMP, EJDHPAFPNLO LJGGELGNOGO, bool INBDJAAIAIO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x62A9EB0", Offset = "0x62A90B0", VA = "0x1862A9EB0")]
	public AMBHIKOGFMK KDHKBGEPHBE(Allocator LGNDPBNMKMP, FLLLLMALOJC FKDPKNIELHO)
	{
		return default(AMBHIKOGFMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x62A99F0", Offset = "0x62A8BF0", VA = "0x1862A99F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DLFNECBFFJA]
public class DNKLNCKEGEH : IPOLJMJAAMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool NDJJGDOONON;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x62981E0", Offset = "0x62973E0", VA = "0x1862981E0")]
	public OFCENFMNMGH FJJBKKMPANK()
	{
		return default(OFCENFMNMGH);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6298300", Offset = "0x6297500", VA = "0x186298300")]
	public DNKLNCKEGEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct HGCNGPEJLOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Mesh.MeshData EINFENEAIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeSlice<BoneWeight> PPAFOLDJBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<byte> JGHNHIDJELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public int OGABMLIINBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Matrix4x4 PPLFFMOCNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public int FLHONCDCHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeSlice<byte> HNBEHHPGGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public bool ONGGJFEIJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public int AFCAJAMMNPP;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NDNBNJFMEBH : LEDFPFHJFMG
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class LCOGKFFHHMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public readonly HPNPAHEDPFN HNEMLGPLOOC;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual bool JPFPKPHFNNA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public virtual bool OGMKEPMOFDB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual GKPJGAOJHHB.JGJMGEIKMEE FLHONCDCHJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "6")]
			get
			{
				return default(GKPJGAOJHHB.JGJMGEIKMEE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool IMACEBPOFFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x1408000", Offset = "0x1407200", VA = "0x181408000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool IFHAHIJMHFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x629D140", Offset = "0x629C340", VA = "0x18629D140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool HLHDNNIFCMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x629D150", Offset = "0x629C350", VA = "0x18629D150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
		protected LCOGKFFHHMM(HPNPAHEDPFN OJPPOOIKPOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract BNCJCHBDCBI KNNBPINKLOM(int[] LIFLJLIODPO, List<PADMHIBMAFN> IMGOJCNEEPF, List<PADMHIBMAFN> CIFKDBCEGMK);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract BHLNBGHIAOC MKJNKCFOHED(uint IMEBMAMHMJD);
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class EJODJJGIDGB : LCOGKFFHHMM
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class FCBHGINKJJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public AECHCDNEFCI<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public EJODJJGIDGB <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public FCBHGINKJJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x6299C00", Offset = "0x6298E00", VA = "0x186299C00")]
			internal void CMPILHGOFEH(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly AvatarSkinAssetItem.NANJNMDFLHG EONFAKIHPPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly AssetReference IGCGODNOBHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly GKPJGAOJHHB.JGJMGEIKMEE BOJMJGDKMKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly PLPCONDGDMD? GPEDDHFPGMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly Material[] ODHOIAFAFDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private SkinnedMeshRenderer[] GAKBGDHBOFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private AvatarSkinAssetItem NGHFPODPADH;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override GKPJGAOJHHB.JGJMGEIKMEE FLHONCDCHJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7CDFF0", Offset = "0x7CD1F0", VA = "0x1807CDFF0", Slot = "6")]
			get
			{
				return default(GKPJGAOJHHB.JGJMGEIKMEE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6299AF0", Offset = "0x6298CF0", VA = "0x186299AF0")]
		public EJODJJGIDGB(AvatarSkinAssetItem.NANJNMDFLHG BEKFGIIFIDO, AssetReference FHEOGGIFABF, Material HKKBBCIMKPP, HPNPAHEDPFN DEAEIDKDJNJ, GKPJGAOJHHB.JGJMGEIKMEE OGDCKADDBND = (GKPJGAOJHHB.JGJMGEIKMEE)0, [Optional] PLPCONDGDMD? GNDKNGFJCHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x62999E0", Offset = "0x6298BE0", VA = "0x1862999E0")]
		public EJODJJGIDGB(AvatarSkinAssetItem.NANJNMDFLHG BEKFGIIFIDO, AssetReference FHEOGGIFABF, Material HKKBBCIMKPP, GKPJGAOJHHB.JGJMGEIKMEE OGDCKADDBND = (GKPJGAOJHHB.JGJMGEIKMEE)0, [Optional] PLPCONDGDMD? GNDKNGFJCHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6299480", Offset = "0x6298680", VA = "0x186299480", Slot = "7")]
		public override BNCJCHBDCBI KNNBPINKLOM(int[] LIFLJLIODPO, List<PADMHIBMAFN> IMGOJCNEEPF, List<PADMHIBMAFN> CIFKDBCEGMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x62996A0", Offset = "0x62988A0", VA = "0x1862996A0", Slot = "8")]
		public override BHLNBGHIAOC MKJNKCFOHED(uint IMEBMAMHMJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6299970", Offset = "0x6298B70", VA = "0x186299970", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class EHILIFDHMCB : LCOGKFFHHMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly MHNAHBJPPJF ADNFOMEOAGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private AECHCDNEFCI<FNOMCFFLEDL> FBIEKMFBNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public FNOMCFFLEDL HMGKKPPEIJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private AECHCDNEFCI<Material>[] NGKALDMNJHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public List<Material> LOACLAOHMEJ;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool JPFPKPHFNNA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool OGMKEPMOFDB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x62985B0", Offset = "0x62977B0", VA = "0x1862985B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1C4F7F0", Offset = "0x1C4E9F0", VA = "0x181C4F7F0")]
		public EHILIFDHMCB(HPNPAHEDPFN OJPPOOIKPOO, MHNAHBJPPJF KPDPLIJBIHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6298610", Offset = "0x6297810", VA = "0x186298610", Slot = "7")]
		public override BNCJCHBDCBI KNNBPINKLOM(int[] LIFLJLIODPO, List<PADMHIBMAFN> IMGOJCNEEPF, List<PADMHIBMAFN> CIFKDBCEGMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6298D10", Offset = "0x6297F10", VA = "0x186298D10", Slot = "8")]
		public override BHLNBGHIAOC MKJNKCFOHED(uint IMEBMAMHMJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6298A70", Offset = "0x6297C70", VA = "0x186298A70")]
		public BHLNBGHIAOC KONCANNFKLN(GameObject BICAHMDPKNC, uint IMEBMAMHMJD, bool INKOGANCLBL, bool HKDJGBCNMJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6299040", Offset = "0x6298240", VA = "0x186299040")]
		public static bool OKEFNGKLCMA(Renderer[] DJKDPPKGCMN, string KOKHJKHKMKG, [Out] Renderer GHEGPFOCNML, [Out] Renderer GLOCOELAGFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x62993B0", Offset = "0x62985B0", VA = "0x1862993B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6298E40", Offset = "0x6298040", VA = "0x186298E40")]
		private (AECHCDNEFCI<FNOMCFFLEDL>, AECHCDNEFCI<Material>[]) OKCPKIIOOND()
		{
			return default((AECHCDNEFCI<FNOMCFFLEDL>, AECHCDNEFCI<Material>[]));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6298430", Offset = "0x6297630", VA = "0x186298430")]
		private AECHCDNEFCI<Material>[] DNMNAIAFGCP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3F7A330", Offset = "0x3F79530", VA = "0x183F7A330")]
		[CompilerGenerated]
		private void IBGLEICIKBM(FNOMCFFLEDL JBENFHJBMMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6298310", Offset = "0x6297510", VA = "0x186298310")]
		[CompilerGenerated]
		private void DBKBLPKGKBM(AECHCDNEFCI<Material> PDNNIAAMFKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6298C60", Offset = "0x6297E60", VA = "0x186298C60")]
		[CompilerGenerated]
		private void MHAHOFGOGBN(Material JBENFHJBMMN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class KOGNEOBCLHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public NDNBNJFMEBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public GJCJPABGAJD buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public KOGNEOBCLHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x629CFE0", Offset = "0x629C1E0", VA = "0x18629CFE0")]
		internal void FIFIHPEEPFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x629D090", Offset = "0x629C290", VA = "0x18629D090")]
		internal void KEGJJJPGIFN(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x629D000", Offset = "0x629C200", VA = "0x18629D000")]
		internal void HCGDKEDHAMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x629D0B0", Offset = "0x629C2B0", VA = "0x18629D0B0")]
		internal void MIEBHHOGMOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
		internal BNCJCHBDCBI NEBCFCPJPEC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DJMKEHOEGFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public KOGNEOBCLHF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public DJMKEHOEGFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6298120", Offset = "0x6297320", VA = "0x186298120")]
		internal MOOFBJMMJKA CJIACNCHDCF(int lod)
		{
			return default(MOOFBJMMJKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class BICJLDDDAOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public List<GJCJPABGAJD> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public BICJLDDDAOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6296540", Offset = "0x6295740", VA = "0x186296540")]
		internal void EPGDJOPGFPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class JBNAIHFGHGP : IEnumerator<AEBIBAEBDOJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private AEBIBAEBDOJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public NDNBNJFMEBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<LCOGKFFHHMM> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public List<GJCJPABGAJD> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public Func<int, MOOFBJMMJKA> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public DJGLANJNFBG materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private AEBIBAEBDOJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
		[DebuggerHidden]
		public JBNAIHFGHGP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x629CA90", Offset = "0x629BC90", VA = "0x18629CA90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x629CCA0", Offset = "0x629BEA0", VA = "0x18629CCA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class MFCKPIAKMFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public NDNBNJFMEBH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public MFCKPIAKMFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x629D200", Offset = "0x629C400", VA = "0x18629D200")]
		internal BNCJCHBDCBI FJCEJOJHBGM(LCOGKFFHHMM p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class IIPLLNIIBFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public PFDKFIADJPC cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public IIPLLNIIBFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8BBAE0", Offset = "0x8BACE0", VA = "0x1808BBAE0")]
		internal void KAHLILOBDFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x95DD00", Offset = "0x95CF00", VA = "0x18095DD00")]
		internal void LJFFDJGLEPC(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class PBFLIMMHFIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public NDNBNJFMEBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public PBFLIMMHFIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class JLPMDIBKEMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public AMBHIKOGFMK defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public OFCENFMNMGH defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public PBFLIMMHFIC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public JLPMDIBKEMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x629CDB0", Offset = "0x629BFB0", VA = "0x18629CDB0")]
		internal void LKGMDHNMFED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x629CD40", Offset = "0x629BF40", VA = "0x18629CD40")]
		internal void FAADDGCAOJA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class IOOANKCJOPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public ACCIIDBGCEL legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public FAJDHNMKDLH legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public PBFLIMMHFIC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public IOOANKCJOPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x629C000", Offset = "0x629B200", VA = "0x18629C000")]
		internal void JDBOJBDOHEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x629BF90", Offset = "0x629B190", VA = "0x18629BF90")]
		internal void EKKKLLFOKAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class OEOIHKGBMNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public PFDKFIADJPC cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public MHNAHBJPPJF avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public NDNBNJFMEBH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public OEOIHKGBMNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x62A9680", Offset = "0x62A8880", VA = "0x1862A9680")]
		internal BNCJCHBDCBI PMIHJKMFHPM(KHGKIALOKCP item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x62A9640", Offset = "0x62A8840", VA = "0x1862A9640")]
		internal void INCBDOPLNDB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class JKDGAJGMKED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public AECHCDNEFCI<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public JKDGAJGMKED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x629CCF0", Offset = "0x629BEF0", VA = "0x18629CCF0")]
		internal void OBNECLNFFAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class EIBMHHBOFOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public HPNPAHEDPFN overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public EIBMHHBOFOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6299400", Offset = "0x6298600", VA = "0x186299400")]
		internal bool MNFAIJALDHC(KeyValuePair<string, MHNAHBJPPJF> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private AvatarConfiguration MOMNJLJEDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Transform IACHFEPEPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private AssetReference IGCGODNOBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private GameObject FEMDKNIACLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private GameObject BPHOCNAMHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private SkinnedMeshRenderer FALPDFGAONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private Transform[] MCLONNDFDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private Matrix4x4[] BALJNLBFIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Material MLBOFGBEHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Material IFOENIJENCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Material EFNIEBGAHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Shader CDKMKHIFEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Shader JFDJLHKIMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Animator DKGFEHOCDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Renderer[] FNMOONCBOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private GKPJGAOJHHB.JGJMGEIKMEE HNIOMANBGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Color PFPEABGLDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Color IDAOFLECELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Color DHIDGLNGPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Color? HLKCGPKLMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Color? DDOIGAAIGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Color? NHMJCEHNPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Color? BCCDHALEMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Texture2D PFDEIKICJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Texture2D OGGJCJBJKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[CanBeNull]
	private MHNAHBJPPJF BJBEBEOKDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Texture KJEEDIADKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Color MOAHJAPMAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public Dictionary<Renderer, DJGLANJNFBG> PAJAFGBLMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Dictionary<Renderer, DJGLANJNFBG> EMHJNOMJGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Dictionary<string, List<LNOBLOJKIFI>> JGCPEBCDLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Dictionary<string, List<LNOBLOJKIFI>> MLCBGHOEMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly List<PADMHIBMAFN> IKPLBLMLOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly List<PADMHIBMAFN> CGDJGAPILMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly List<PADMHIBMAFN> INOGDEEEJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly List<PADMHIBMAFN> IEEIDEHPOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Dictionary<LNOBLOJKIFI, Material> FCGHGHLMHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<LNOBLOJKIFI, Material> CDGHIGHDKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private SkinnedMeshRenderer[] AOEIGIDHJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private SkinnedMeshRenderer[] LHGCNGCMPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private SkinnedMeshRenderer[] JIEENPLOIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private SkinnedMeshRenderer[] LDFDCIIOMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly Dictionary<string, AECHCDNEFCI<Texture2D>> EEGENKAGLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly Dictionary<string, AECHCDNEFCI<Texture2D>> BFOJMFNJAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private FitMeshHemisphere INPNDMNFNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private bool HGPAMNFGLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private MINLICNIIAF LOJBLAIHNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool OHBNNMGNIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private AnchorParamsRestrictions OKEDJOEILHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private bool KABPBMKICLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Transform OHEOAHLJJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Transform LPOPCDOIHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private bool BHDDJOLHAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x201")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private bool NICHHGANAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private Vector3 ONGKJOEJKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Quaternion KPMDKENIFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Vector2 PDADMFOABML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private FitMeshHemisphere DLEOMBOIDEA;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Material CKKELLFOMBE;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Material EMIANHFKNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Dictionary<string, MHNAHBJPPJF> PDJBKKPIHFB;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int APJFALKGAEE;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int LODNPKAAMBF;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int CEGLJCDNAOH;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int LMBAMFIOGIM;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int BKGADIAHMJA;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int LOKPGCCAPIG;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int PNHGIMALNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly OJHEJHCKNBB PELOLGCDNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly OJHEJHCKNBB AGPDHNCADLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private bool OOBHAEPFMCE;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static Lazy<FFBJAHFPKAB> OHFKIICMCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private Lazy<OEIHLIPBHMB> EPIIJEDDGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private Lazy<NCOHBPPDDGO> JGDOEMEICDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private List<Action> HONCAGJFNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private CLPKOMANLAG PJCPKIADKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private SkinnedMeshRenderer[] MOFAEGOFIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private int BPOJIHKFGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool KPCMOBHABHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int LGKBANJJJFK;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool GFPHHDHEKIE
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x62A1270", Offset = "0x62A0470", VA = "0x1862A1270")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x629DE30", Offset = "0x629D030", VA = "0x18629DE30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool OHIAPJDGJNN
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x62A6800", Offset = "0x62A5A00", VA = "0x1862A6800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material DEGDGOLHECH
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x62A5920", Offset = "0x62A4B20", VA = "0x1862A5920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Material MENLHKGKIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x62A5D70", Offset = "0x62A4F70", VA = "0x1862A5D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private bool BFMGHIDELBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private static FFBJAHFPKAB OPMAJKJJJLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x62A1A80", Offset = "0x62A0C80", VA = "0x1862A1A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private OEIHLIPBHMB PPOAPOPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x62A2330", Offset = "0x62A1530", VA = "0x1862A2330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private NCOHBPPDDGO HCLLEEMKBGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x629D820", Offset = "0x629CA20", VA = "0x18629D820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public OJHEJHCKNBB ABFDOICDJAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x13055E0", Offset = "0x13047E0", VA = "0x1813055E0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public OJHEJHCKNBB BGMCIFMAMIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1075FD0", Offset = "0x10751D0", VA = "0x181075FD0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public SkinnedMeshRenderer[] COGHCENHJPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA43BF0", Offset = "0xA42DF0", VA = "0x180A43BF0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Renderer[] GAJOCBACHGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7D2400", Offset = "0x7D1600", VA = "0x1807D2400", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool FOMMOCMOMFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x62A63F0", Offset = "0x62A55F0", VA = "0x1862A63F0", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public GKPJGAOJHHB.JGJMGEIKMEE MHHGCJDGIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xF53F30", Offset = "0xF53130", VA = "0x180F53F30", Slot = "18")]
		get
		{
			return default(GKPJGAOJHHB.JGJMGEIKMEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int KBLDHBOGFOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x15CE000", Offset = "0x15CD200", VA = "0x1815CE000")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x629DE10", Offset = "0x629D010", VA = "0x18629DE10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private bool BFGGJLEGKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x62A1A00", Offset = "0x62A0C00", VA = "0x1862A1A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private static bool EJLNEHODMGD
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x629DED0", Offset = "0x629D0D0", VA = "0x18629DED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x62A8D20", Offset = "0x62A7F20", VA = "0x1862A8D20")]
	public NDNBNJFMEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x629E750", Offset = "0x629D950", VA = "0x18629E750", Slot = "21")]
	public void CNOOLEDIEBH(FGHFJOIPDFD NMGAPACOPPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x62A3600", Offset = "0x62A2800", VA = "0x1862A3600", Slot = "22")]
	public void LNLOLDGKLJC(PFAODCKNIFO EHFNMFNOLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x629DE10", Offset = "0x629D010", VA = "0x18629DE10", Slot = "4")]
	public void NOKILNIDLEP(int IMEBMAMHMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x62A2380", Offset = "0x62A1580", VA = "0x1862A2380", Slot = "9")]
	public void JEDHBPNGKKM(KPHNAIJOACJ EOMDHFMJDMM, Texture2D LDDEKCHDPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x62A01B0", Offset = "0x629F3B0", VA = "0x1862A01B0", Slot = "10")]
	public void ELIDIDOLBNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x62A0030", Offset = "0x629F230", VA = "0x1862A0030", Slot = "11")]
	public bool ELELEPGIKCI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x62A1280", Offset = "0x62A0480", VA = "0x1862A1280", Slot = "8")]
	public void GGAPGKDHCJH(PLGNOHLNEIL MOODMMABAMN, Color? LHAAJEOMGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x629D870", Offset = "0x629CA70", VA = "0x18629D870")]
	private void AHPDKPLOMCK(Action IILEDENFICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x62A2660", Offset = "0x62A1860", VA = "0x1862A2660", Slot = "5")]
	public void JKKEKKLOAAC(MHNAHBJPPJF GCMGBFHCJBI, Texture JALPEOGDKDB, Color PCMAHLAMBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x629DE30", Offset = "0x629D030", VA = "0x18629DE30", Slot = "6")]
	public void BHAPOCJIKPJ(bool MLOJLKGBBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2189E70", Offset = "0x2189070", VA = "0x182189E70", Slot = "7")]
	public void OIPDINGPAOB(CLPKOMANLAG EOHMOLAFOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x62A7340", Offset = "0x62A6540", VA = "0x1862A7340", Slot = "14")]
	public GJCJPABGAJD PKKJILMNNIB(FEIOKEPKPAA HJPDAJPNDEM, bool ADHJNCFMENN, int[] COELPBINCJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x62A3A30", Offset = "0x62A2C30", VA = "0x1862A3A30", Slot = "15")]
	public void MANENJEHFPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x629FBF0", Offset = "0x629EDF0", VA = "0x18629FBF0")]
	private bool DMALNLKPIGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xF54460", Offset = "0xF53660", VA = "0x180F54460", Slot = "19")]
	public void EIADPCACLKO(GKPJGAOJHHB.JGJMGEIKMEE DLFMHKAEGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x62A1B90", Offset = "0x62A0D90", VA = "0x1862A1B90")]
	private bool HGDHGLOOLON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x629D250", Offset = "0x629C450", VA = "0x18629D250")]
	private GJCJPABGAJD AAOIJOMCBJL(bool ADHJNCFMENN, List<LCOGKFFHHMM> NFMNLHAEILE, int[] COELPBINCJL, Func<int, MOOFBJMMJKA> BCKPJKIIFHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x629FF20", Offset = "0x629F120", VA = "0x18629FF20")]
	[IteratorStateMachine(typeof(JBNAIHFGHGP))]
	private IEnumerator<AEBIBAEBDOJ> EJJNAHHMGDI(bool ADHJNCFMENN, List<LCOGKFFHHMM> NFMNLHAEILE, int[] COELPBINCJL, Func<int, MOOFBJMMJKA> BCKPJKIIFHB, DJGLANJNFBG AGGGFPJAIPK, Material CCGMDNGDKNJ, List<GJCJPABGAJD> GODJAAAIIGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x62A5AB0", Offset = "0x62A4CB0", VA = "0x1862A5AB0")]
	private GJCJPABGAJD NCAFIBENFOI(List<LCOGKFFHHMM> NFMNLHAEILE, int[] COELPBINCJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x62A3EE0", Offset = "0x62A30E0", VA = "0x1862A3EE0")]
	private MGBJAGNHOEE MOAOGODCIKE(List<LCOGKFFHHMM> NFMNLHAEILE, int IMEBMAMHMJD, bool ADHJNCFMENN, MOOFBJMMJKA HEJPMNEGHKB, bool JDCPLDDGHKN, DJGLANJNFBG AGGGFPJAIPK, Material CCGMDNGDKNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x62A17E0", Offset = "0x62A09E0", VA = "0x1862A17E0")]
	private void GNAAJMJDBIF(SkinnedMeshRenderer KPCJCKPIBFL, Mesh COKNMDIBDNP, List<Material> BAFIOKBPJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x629DCB0", Offset = "0x629CEB0", VA = "0x18629DCB0")]
	private static Material BEDEHPIKBOB(Dictionary<LNOBLOJKIFI, Material> EKEJJAGPLJN, Material KGOFBLFGKFP, HBKIBICCOCC PNDFOBOIMFP, BDOCIDDJPJJ KHDNLMAIGPB, HPNPAHEDPFN DEAEIDKDJNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x62A2FF0", Offset = "0x62A21F0", VA = "0x1862A2FF0")]
	private static HBKIBICCOCC KNDGGAAFLAO(LCOGKFFHHMM JPKJEFDLCCE, int FCLAJPHMKIL)
	{
		return default(HBKIBICCOCC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x62A0230", Offset = "0x629F430", VA = "0x1862A0230")]
	private void ENOPEBBIJHG(int GGPGONDEEFA, Material OOHAKCENEJE, LCOGKFFHHMM JPKJEFDLCCE, [Out] Texture2D MNFCKAHONNK, [Out] Vector4 DCDDNJEAMDC, [Out] Texture2D BNGLDOJMIMI, [Out] Texture2D FGGIMMPMDMO, [Out] Texture2D DHIGIFPBDIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x62A2930", Offset = "0x62A1B30", VA = "0x1862A2930")]
	private void KGCHHOJMOEC(int GGPGONDEEFA, Material OOHAKCENEJE, LCOGKFFHHMM JPKJEFDLCCE, [Out] Color FFGAEBLCHMP, [Out] Color NHDPGNILPKJ, [Out] Color BGKHMILIFFE, [Out] Color HECINJIDFOB, [Out] Color PGCHIMMFOJF, [Out] Color PNDPAFFPLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x62A26D0", Offset = "0x62A18D0", VA = "0x1862A26D0")]
	private bool KEIPGJFBCIO(Material OOHAKCENEJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x62A8960", Offset = "0x62A7B60", VA = "0x1862A8960")]
	private static Material PKMGBLBIEIJ(int GGPGONDEEFA, EHILIFDHMCB JPKJEFDLCCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x62A6940", Offset = "0x62A5B40", VA = "0x1862A6940")]
	private static BDOCIDDJPJJ OMNLNGKJOGN(LCOGKFFHHMM JPKJEFDLCCE, int FCLAJPHMKIL)
	{
		return default(BDOCIDDJPJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x62A0FA0", Offset = "0x62A01A0", VA = "0x1862A0FA0")]
	private static void GADDMOHGAEJ(Dictionary<string, List<LNOBLOJKIFI>> DAEGLAIOHBK, LCOGKFFHHMM JBMECIEODDG, Material KGOFBLFGKFP, HBKIBICCOCC MOODMMABAMN, BDOCIDDJPJJ EOMDHFMJDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x62A65D0", Offset = "0x62A57D0", VA = "0x1862A65D0")]
	private static SkinnedMeshRenderer ODHJMOCPIME(Transform HIPFCLKFMCL, Transform MJOMMGPEDJG, SkinnedMeshRenderer[] DJKDPPKGCMN, int IMEBMAMHMJD, MOOFBJMMJKA HEJPMNEGHKB, bool ADHJNCFMENN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x62A6220", Offset = "0x62A5420", VA = "0x1862A6220")]
	private void OBLGKALMLMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x62A2320", Offset = "0x62A1520", VA = "0x1862A2320")]
	private void IMJBCNEAGEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x629E5F0", Offset = "0x629D7F0", VA = "0x18629E5F0")]
	private static void CKLEBCJKBOK(Dictionary<LNOBLOJKIFI, Material> EKEJJAGPLJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x62A1680", Offset = "0x62A0880", VA = "0x1862A1680")]
	private static void GMKJOGCBPPH(Dictionary<Renderer, DJGLANJNFBG> ILPHIMONLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x62A1DC0", Offset = "0x62A0FC0", VA = "0x1862A1DC0")]
	private void HOLHMMIANOB(SkinnedMeshRenderer[] DJKDPPKGCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x62A20F0", Offset = "0x62A12F0", VA = "0x1862A20F0")]
	private void IEIAOCPKMGG(SkinnedMeshRenderer LDJHLGLAKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x62A0DD0", Offset = "0x629FFD0", VA = "0x1862A0DD0")]
	private void FNPACKAFPBL(List<PADMHIBMAFN> DHFICBFANGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x62A1EE0", Offset = "0x62A10E0", VA = "0x1862A1EE0")]
	private void IBJBCGLAFJP(Dictionary<string, AECHCDNEFCI<Texture2D>> DAEGLAIOHBK, bool OPIPEMADGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x629FE80", Offset = "0x629F080", VA = "0x18629FE80")]
	private void DOODOIPBHCD(Dictionary<string, List<LNOBLOJKIFI>> DAEGLAIOHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x62A0670", Offset = "0x629F870", VA = "0x1862A0670")]
	private void EPDEBKOBLJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x62A3C30", Offset = "0x62A2E30", VA = "0x1862A3C30")]
	private void MLNIHHJDOPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x629EAA0", Offset = "0x629DCA0", VA = "0x18629EAA0")]
	private void DDAHKCLGPBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x62A1900", Offset = "0x62A0B00", VA = "0x1862A1900")]
	private void GOGGNLFLIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x62A2290", Offset = "0x62A1490", VA = "0x1862A2290")]
	private void IKBBMKCGKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x629FD30", Offset = "0x629EF30", VA = "0x18629FD30")]
	private void DNEHPMJHNML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x629FB70", Offset = "0x629ED70", VA = "0x18629FB70")]
	private void DGGELPHEAPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x62A6810", Offset = "0x62A5A10", VA = "0x1862A6810")]
	private void OICAFJBHAAP(bool KMGICNMNPFN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x62A2190", Offset = "0x62A1390", VA = "0x1862A2190")]
	private void IGIAFBGDANI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x62A7020", Offset = "0x62A6220", VA = "0x1862A7020")]
	private void PBPDFJLDLJD(bool KMGICNMNPFN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x629D970", Offset = "0x629CB70", VA = "0x18629D970")]
	private void ALEJMCIAHEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x629E070", Offset = "0x629D270", VA = "0x18629E070")]
	private void CBJIHLGLKHD(Material CCGMDNGDKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x62A2570", Offset = "0x62A1770", VA = "0x1862A2570")]
	private void JJCCDOMMIBM(Material CCGMDNGDKNJ, Color NHDPGNILPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x62A89E0", Offset = "0x62A7BE0", VA = "0x1862A89E0")]
	private void PMMIPINOCCJ(Material CCGMDNGDKNJ, Color BGKHMILIFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x62A0950", Offset = "0x629FB50", VA = "0x1862A0950")]
	private void FJEKAILJECB(Material CCGMDNGDKNJ, Color FFGAEBLCHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x62A0860", Offset = "0x629FA60", VA = "0x1862A0860")]
	private void FHLBAKAKPLP(Material CCGMDNGDKNJ, Texture2D LDDEKCHDPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x62A3DC0", Offset = "0x62A2FC0", VA = "0x1862A3DC0")]
	private void MMJGBPAGOMK(Material CCGMDNGDKNJ, Texture FPBBHAFAGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x62A7150", Offset = "0x62A6350", VA = "0x1862A7150")]
	private void PCKACOFBJLP(Action<DJGLANJNFBG> LOELFAGHLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x629E3E0", Offset = "0x629D5E0", VA = "0x18629E3E0")]
	private void CFNGIANBDLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x62A5E90", Offset = "0x62A5090", VA = "0x1862A5E90")]
	private void NMFBINOCJOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x62A6A30", Offset = "0x62A5C30", VA = "0x1862A6A30")]
	private GJCJPABGAJD ONMOFGHOONJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x62A3680", Offset = "0x62A2880", VA = "0x1862A3680")]
	private void LPPBOGLHAFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x62A0A40", Offset = "0x629FC40", VA = "0x1862A0A40")]
	public void FNMELKJOOBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x62A6560", Offset = "0x62A5760", VA = "0x1862A6560")]
	private void OCKJNLOOBJH(Vector3 HFHFPGFAPOG, Quaternion HFLDDHFJBPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x62A3110", Offset = "0x62A2310", VA = "0x1862A3110")]
	private void KODJLOOMLGH(List<LCOGKFFHHMM> MMPBMFLIFIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x629F670", Offset = "0x629E870", VA = "0x18629F670")]
	public void DGCHKGAIDOC(MINLICNIIAF FKNGCEGPKLJ, bool LDHDHELJJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x629EFF0", Offset = "0x629E1F0", VA = "0x18629EFF0")]
	public void DGCHKGAIDOC(MINLICNIIAF FKNGCEGPKLJ, AnchorParamsRestrictions JCBOHEOACOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x93C850", Offset = "0x93BA50", VA = "0x18093C850")]
	private static void PBAJIELIJFG(FitMeshHemisphere IMGGCFHKCCG, Transform DGJHKAFPJDM, MINLICNIIAF FKNGCEGPKLJ, AnchorParamsRestrictions BIDIHLMCJII, [Out] Vector3 HNNAMHMDPNC, [Out] Quaternion LNJHJGHHPKI, [Out] MINLICNIIAF OFJOKKLGNLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x62A2E30", Offset = "0x62A2030", VA = "0x1862A2E30")]
	public void KHEMOBGMDAA(Vector2 IMDGDOPAHDF, Vector3 LADAIMHPAJD, Vector3 ONEKHKKFNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x62A1C50", Offset = "0x62A0E50", VA = "0x1862A1C50")]
	private void HHDOAOBEJOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x629E560", Offset = "0x629D760", VA = "0x18629E560")]
	private void CJIPLJBMJHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x62A2060", Offset = "0x62A1260", VA = "0x1862A2060")]
	[CompilerGenerated]
	private void ICGKFJABHJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x62A19D0", Offset = "0x62A0BD0", VA = "0x1862A19D0")]
	[CompilerGenerated]
	private void GPHPKKFMJLL(DJGLANJNFBG ALFCKPKGCDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x62A07D0", Offset = "0x629F9D0", VA = "0x1862A07D0")]
	[CompilerGenerated]
	private void FCFDNNJNLLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x629D950", Offset = "0x629CB50", VA = "0x18629D950")]
	[CompilerGenerated]
	private void AIFAMLLNGAI(DJGLANJNFBG ALFCKPKGCDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x62A70C0", Offset = "0x62A62C0", VA = "0x1862A70C0")]
	[CompilerGenerated]
	private void PCHGKDGDMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x629FF00", Offset = "0x629F100", VA = "0x18629FF00")]
	[CompilerGenerated]
	private void EBCLJKPFHKK(DJGLANJNFBG ALFCKPKGCDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x62A34B0", Offset = "0x62A26B0", VA = "0x1862A34B0")]
	[CompilerGenerated]
	private void LDIJKDJDHAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x629FED0", Offset = "0x629F0D0", VA = "0x18629FED0")]
	[CompilerGenerated]
	private void DPCLNEMCCAD(DJGLANJNFBG ALFCKPKGCDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x62A3570", Offset = "0x62A2770", VA = "0x1862A3570")]
	[CompilerGenerated]
	private void LKNHENLOHDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x62A3EB0", Offset = "0x62A30B0", VA = "0x1862A3EB0")]
	[CompilerGenerated]
	private void MNKOBBCKCEK(DJGLANJNFBG ALFCKPKGCDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x62A1B00", Offset = "0x62A0D00", VA = "0x1862A1B00")]
	[CompilerGenerated]
	private void HEHOHFGMJII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x62A3540", Offset = "0x62A2740", VA = "0x1862A3540")]
	[CompilerGenerated]
	private void LKNGOFHJOKE(DJGLANJNFBG ALFCKPKGCDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x629DE40", Offset = "0x629D040", VA = "0x18629DE40")]
	[CompilerGenerated]
	private void BLDAKAKNGIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x62A61F0", Offset = "0x62A53F0", VA = "0x1862A61F0")]
	[CompilerGenerated]
	private void NMPGIHMNKJC(DJGLANJNFBG ALFCKPKGCDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x62A2210", Offset = "0x62A1410", VA = "0x1862A2210")]
	[CompilerGenerated]
	private void IIPGAKFPPIM(KeyValuePair<string, AECHCDNEFCI<Texture2D>> NBBKDMLOFNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x629EA10", Offset = "0x629DC10", VA = "0x18629EA10")]
	[CompilerGenerated]
	private void CPPJGPJJCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x62A7310", Offset = "0x62A6510", VA = "0x1862A7310")]
	[CompilerGenerated]
	private void PFDAGCNENCA(DJGLANJNFBG ALFCKPKGCDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x62A68B0", Offset = "0x62A5AB0", VA = "0x1862A68B0")]
	[CompilerGenerated]
	private void OIJGGFLJJJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x62A5E60", Offset = "0x62A5060", VA = "0x1862A5E60")]
	[CompilerGenerated]
	private void NJDNBECCCMK(DJGLANJNFBG ALFCKPKGCDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class IEFMEENNGEA : CPMGGIIMFCP
{
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly int GKJCPPMFOAD;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly int LEECMIOOICC;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly int EPCJDOOPGFB;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private static readonly int OAGLDBHPMID;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static readonly int BCBCLICJFPJ;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly int HMPJCKOBFAK;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly int AIOAGHOKIPJ;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly int LFEFBOLAAJM;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly int GLKKHCPDDFL;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly int KCDPIOPGPEL;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly int JLCOCGAPPFH;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int FOCLLFHODIF;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int DOFFPCGBHPA;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly int KBGPBHIBOKH;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly int KIBGLGGPMGI;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int PHJGBOANKNM;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int ECIGDBEEGPJ;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int OJDLMOJPLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private Transform NJPFMLGFFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private Transform IPPJABNIFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private Transform DNCKPBHJIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private Transform EFLHAOPJPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private Transform OIKGNHEOOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private Transform LLBNHECCANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private Transform EAPLHECOECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private POABKCDCHCA ENLNLAFJKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private MaterialPropertyBlock DPOBBDAKHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private SkinnedMeshRenderer[] IBPNNLHEFJE;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private MaterialPropertyBlock OFLCOEGDHPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x629BAF0", Offset = "0x629ACF0", VA = "0x18629BAF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x629A030", Offset = "0x6299230", VA = "0x18629A030", Slot = "6")]
	public void CNOOLEDIEBH(POABKCDCHCA FJJEFDJGBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x629BAC0", Offset = "0x629ACC0", VA = "0x18629BAC0", Slot = "7")]
	public void NHNOONFPAAL(ILIABBNEMKB DGEJIBAIKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x629B5B0", Offset = "0x629A7B0", VA = "0x18629B5B0", Slot = "4")]
	public void KFKCCJAAHIP(BECMCNIPBEM GGMELBMINGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x629A440", Offset = "0x6299640", VA = "0x18629A440")]
	private Vector2 GAJMBLPEEEI(Vector2 NGDINFPJIJH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x629A4A0", Offset = "0x62996A0", VA = "0x18629A4A0", Slot = "5")]
	public void JLNBEFAPIDM(KAIBKFCKHGP DGEJIBAIKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x629A0F0", Offset = "0x62992F0", VA = "0x18629A0F0")]
	private void DPBLDOHOCML(KAIBKFCKHGP LGKJKMGOKGB, BJNLIBNCJDL CNKGFKHMGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x629B9E0", Offset = "0x629ABE0", VA = "0x18629B9E0")]
	private void NFFGGHNAOBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x629BF30", Offset = "0x629B130", VA = "0x18629BF30")]
	public IEFMEENNGEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x629BB70", Offset = "0x629AD70", VA = "0x18629BB70")]
	[CompilerGenerated]
	internal static (float, float) OJFDCEEPCCA(float EFNMNAALOMG)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6299FF0", Offset = "0x62991F0", VA = "0x186299FF0")]
	[CompilerGenerated]
	internal static Vector4 ALIFFLCNIJD(Vector2 CAOOPLKANIG, Vector2 MGKBJKPBCFA)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class DJGLANJNFBG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private MaterialPropertyBlock EFLKHNIJOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public Color? GBKOJDBPEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public Color? EAKIBDCJHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public Color? CCHADKNEOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public Color? IOFPEEDLMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public Color JPNECKGIGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public Color KABCIABOKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public Color INDIPJKIHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public Texture2D KADDKHADMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public Texture2D GGNJEPHNNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private Dictionary<LNOBLOJKIFI, int> MBKBKJAKEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private HBKIBICCOCC[] DFEBCLHLHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private BDOCIDDJPJJ[] AHDIIFIFEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public Vector4[] CBODKJEKGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public Vector4[] AOJKAAJPBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public Vector4[] CLJMCMNJLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public Vector4[] DMGAGKCCBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public Vector4[] JIFDNKMHOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public Vector4[] NMANFJKFINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private List<Texture2D> OMKHMODIJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private Vector4[] OLDHBCKNBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private List<Texture2D> APFBCKCOJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private float[] NMEOHKIDEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private Vector4[] BFEPIFIHMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private float[] PCHJBCNEBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public float[] JGFOJDDBDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private List<Texture2D> LMCBDIKOHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private float[] DHNNEKGICMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private List<Texture2D> CHGCLCCFEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private Vector4[] GFAIJJNBIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private float[] NLLECOJHJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private Vector4[] MOKEBHDOLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public float[] OKKNHDMKDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public Texture2DArray GALPHADMECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public Texture2DArray DLPANCGKGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public Texture2DArray DHDJKIJODFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public Texture2DArray BLOILAHKOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private bool DPLOGDKLEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int BMLMFLCDDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private Vector2? DOLBABPAIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private TextureFormat BHGDGIMPFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private Vector2? EEFMNGLBPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private TextureFormat NEKLLCJCFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private Vector2? CAALNLNDHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private TextureFormat NAPJFGKJMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private Vector2? GAGDLMMEFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private TextureFormat JFGFIBLOLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private bool NHFBHKGIGAE;

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static int PGNCFJMGALJ;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static int FFIJNMBLJKD;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static int MLEAMLCBBEI;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static int BAHJELJEFEP;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static int BABCOGFDBGF;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static int ELEHNHIONKH;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static int ECLBIFIIALH;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static int DGLNPFLBCEM;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static int BLNKOAFIJOD;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static int LIMMKMEMEJE;

	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private static int GLEAGBAJLDD;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private static int DFKJIIBCAKC;

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private static int ILFKHJFGHAA;

	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private static int EBEOHDHKLKI;

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private static int CIJKJICLHAF;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private static int LNACAACKBIC;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static int LOBEFPJAHHO;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static int GNECAMGPIKO;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private static int DBPPAGEANBM;

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static int MEEPPGAAMLO;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x62B0F90", Offset = "0x62B0190", VA = "0x1862B0F90")]
	private DJGLANJNFBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x62B0ED0", Offset = "0x62B00D0", VA = "0x1862B0ED0")]
	public DJGLANJNFBG(Color HBKECKPJJNH, Color JAPINAKEHJK, Color GHKJBBGHKOD, Color? JCGCAMLCNFN, Color? DDKFPLHGECJ, Color? PIIGHPIEKCJ, Texture2D LDEBFAKGMPC, Texture2D KCKFOBLBNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x62B0390", Offset = "0x62AF590", VA = "0x1862B0390")]
	internal int FEIMGDPLFCM(Material EHNGLDNJKDL, HBKIBICCOCC PNDFOBOIMFP, BDOCIDDJPJJ KHDNLMAIGPB, HPNPAHEDPFN DEAEIDKDJNJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x62B0300", Offset = "0x62AF500", VA = "0x1862B0300")]
	private int FEIMGDPLFCM(LNOBLOJKIFI MNOIAMGNLNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x62AF6F0", Offset = "0x62AE8F0", VA = "0x1862AF6F0")]
	internal int BHKFMMEDNGG(Material EHNGLDNJKDL, Color FFGAEBLCHMP, Color NHDPGNILPKJ, Color BGKHMILIFFE, Color HECINJIDFOB, Color PGCHIMMFOJF, Texture2D FDOHEOEJHGF, Vector4 FLIPAPNFNFO, Texture2D LPNDEEOKBAH, Vector4 CGIHJDKCGOL, float ABONGFDJIOD, float GBIDPPODIEE, Texture2D JKDCCFPMFGL, Vector4 JJBHNPFKCMH, float PFCJFFEMELI, Texture2D HHNOJGBHANF, Color PNDPAFFPLOI, Vector4 HGFBCJOPIKF, HBKIBICCOCC PNDFOBOIMFP, BDOCIDDJPJJ KHDNLMAIGPB, HPNPAHEDPFN DEAEIDKDJNJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x62B05D0", Offset = "0x62AF7D0", VA = "0x1862B05D0")]
	private void HBBEMPOEIGD(List<Texture2D> OMKHMODIJBN, [Out] Texture2DArray GDMFKFPPLOF, [Out] Texture2DArray FPFNFCHHIMB, [Out] Texture2DArray FCIHNBGBEME, [Out] Texture2DArray CBHJACJCDAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x62B0480", Offset = "0x62AF680", VA = "0x1862B0480")]
	public void FMDKPGEHKAJ(Shader NNPJJLAINGO, Renderer MNDOIBEKKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x62AE9A0", Offset = "0x62ADBA0", VA = "0x1862AE9A0")]
	private void AHCAFOOIPNN(Shader NNPJJLAINGO, Renderer MNDOIBEKKNI, int NCDMBFKDLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x62B0940", Offset = "0x62AFB40", VA = "0x1862B0940")]
	private Color ODBLNBDJHPH(Color JAAEIAOPAEI, HBKIBICCOCC MOODMMABAMN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x62AE850", Offset = "0x62ADA50", VA = "0x1862AE850")]
	private Color ADEABOHOENO(Color CHDFLMCEDII, HBKIBICCOCC MOODMMABAMN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x62B0790", Offset = "0x62AF990", VA = "0x1862B0790")]
	private bool KKAELKPNLKD(Texture2D PCLHFAJKOJA, BDOCIDDJPJJ EOMDHFMJDMM, [Out] Texture2D JMJLOKHCMPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x62B0890", Offset = "0x62AFA90", VA = "0x1862B0890")]
	private void MGFPBGLJJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x62B02C0", Offset = "0x62AF4C0", VA = "0x1862B02C0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		[Obsolete("Use CombinationId instead!")]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private FKCJCHOPJOM? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public IBBLFMEEAFP CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x62ADD10", Offset = "0x62ACF10", VA = "0x1862ADD10")]
			get
			{
				return default(IBBLFMEEAFP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public FKCJCHOPJOM MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x62ADD60", Offset = "0x62ACF60", VA = "0x1862ADD60")]
			get
			{
				return default(FKCJCHOPJOM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7CE890", Offset = "0x7CDA90", VA = "0x1807CE890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7D23A0", Offset = "0x7D15A0", VA = "0x1807D23A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x62ADB50", Offset = "0x62ACD50", VA = "0x1862ADB50")]
		public Material[] NKPLNBNIHKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x62AD990", Offset = "0x62ACB90", VA = "0x1862AD990")]
		public static void CJPPMGPLNOO(AvatarItemMaterial EKOMCOJAGJO, Material OOHAKCENEJE, int GGPGONDEEFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x62ADC40", Offset = "0x62ACE40", VA = "0x1862ADC40")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[DLFNECBFFJA]
public struct APCGIJHBEAE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	[ReadOnly]
	public FAJDHNMKDLH OKDLNDMNBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	[ReadOnly]
	public int MPJAOEIDNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public ACCIIDBGCEL PKLCGKPCNPB;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x62ACA80", Offset = "0x62ABC80", VA = "0x1862ACA80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[NativeContainer]
[DLFNECBFFJA]
public struct ACCIIDBGCEL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public NativeArray<Vector3> CDHIMFBCNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public NativeArray<Vector3> BACMHADEMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public NativeArray<Vector4> KENFHEBDBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public NativeArray<Vector2> JOPLEJGKCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public NativeArray<Vector2> KLKCHFGMCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public NativeArray<Vector2> HFNGLJFFGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public NativeArray<Vector2> ENFHGLLEAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public NativeArray<Color> CJHEFAHJJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public NativeArray<int> LAAFBNKFILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public NativeArray<int> POLCLNMBOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private NativeArray<int> COGOFOEABKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private NativeArray<int> BOFJPDFDGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public NativeArray<int> CEKEBOOMGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public NativeArray<int> OBIIOHGCBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeArray<int> MLHADJBCHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<BoneWeight> GBBIPBIDNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private NativeArray<int> EOHMOLAFOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private bool DBMJCBEFOMJ;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int KNMCPBOPKCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x62ABCC0", Offset = "0x62AAEC0", VA = "0x1862ABCC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x62AC3F0", Offset = "0x62AB5F0", VA = "0x1862AC3F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int LCHPMKBLNJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x62AC480", Offset = "0x62AB680", VA = "0x1862AC480")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x62AC470", Offset = "0x62AB670", VA = "0x1862AC470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int MEPFKOEGADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x62ABD20", Offset = "0x62AAF20", VA = "0x1862ABD20")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x62AC490", Offset = "0x62AB690", VA = "0x1862AC490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x62AC640", Offset = "0x62AB840", VA = "0x1862AC640")]
	public ACCIIDBGCEL(int FBKFLMAEHFI, int KJBOEEMJNBI, int DMDBDDOMMIB, int IKAHMBEANOD, Allocator LGNDPBNMKMP, int DHJPNBHCBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x62AC400", Offset = "0x62AB600", VA = "0x1862AC400")]
	public void HDIKCJFCFKB(int PMNHOLIPOMJ, Vector3 HCFEJGBILDB, Vector3 AMAGNFDOAPP, Vector4 GIHFGGLMPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x62ABF00", Offset = "0x62AB100", VA = "0x1862ABF00")]
	public void EJNNHCFPCIG(int PMNHOLIPOMJ, BoneWeight DHGHKDPEHCO, NativeSlice<byte> HNBEHHPGGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x62ABEE0", Offset = "0x62AB0E0", VA = "0x1862ABEE0")]
	public Color EBDMCLFAFHP(int PMNHOLIPOMJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x62AC620", Offset = "0x62AB820", VA = "0x1862AC620")]
	public void PJADKGBIBFN(int PMNHOLIPOMJ, Color HHHFIGOCAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x62ABCD0", Offset = "0x62AAED0", VA = "0x1862ABCD0")]
	public void BOEPPCCPLDE(byte DFAIPKLPNIB, int PMNHOLIPOMJ, Vector2 PLCOMDBOPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x62AC4A0", Offset = "0x62AB6A0", VA = "0x1862AC4A0")]
	public void LJJHKHBJLCP(int PMNHOLIPOMJ, int DAFJNNBBDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x62AC4B0", Offset = "0x62AB6B0", VA = "0x1862AC4B0")]
	public bool MPNPIIHHKGO(int DFAIPKLPNIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x62ABBF0", Offset = "0x62AADF0", VA = "0x1862ABBF0")]
	public void AHDLBLPEGNP(int DAJMIEKDOHC, int CFPEDCFCDGK, int MKCBFIBLIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x62AC4E0", Offset = "0x62AB6E0", VA = "0x1862AC4E0")]
	public int[] OAPKEEMMHJN(int DAJMIEKDOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x62AC590", Offset = "0x62AB790", VA = "0x1862AC590")]
	private NativeSlice<int> ODPCEBDKEJE(int DAJMIEKDOHC)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x62ABD30", Offset = "0x62AAF30", VA = "0x1862ABD30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x62AC0A0", Offset = "0x62AB2A0", VA = "0x1862AC0A0")]
	public Mesh EOFOBPDCCGK([Optional] string MAEINOOIDGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[NativeContainer]
[DefaultMember("Item")]
[DLFNECBFFJA]
public struct FAJDHNMKDLH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeArray<Vector3> CDHIMFBCNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public NativeArray<Vector3> BACMHADEMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<Vector4> KENFHEBDBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeArray<Vector2> JOPLEJGKCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeArray<Vector2> KLKCHFGMCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public NativeArray<Vector2> HFNGLJFFGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public NativeArray<Vector2> ENFHGLLEAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public NativeArray<Color> CJHEFAHJJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public NativeArray<int> CDKPKPOBNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public NativeArray<int> GDCIDMNMMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<int> DKBEJGPHDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public NativeArray<int> MNCAHPCPPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<bool> IEAELJEFLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public NativeArray<int> HCMBBGLGDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public NativeArray<int> LOOHFMJECBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeArray<BoneWeight> PPAFOLDJBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private NativeArray<Matrix4x4> NOHBDNLCLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private NativeArray<int> GGPENLLODHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private NativeArray<byte> ADFCIHAKDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private NativeArray<int> PIGLOJAKDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private NativeArray<int> HBPHHPDFPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<sbyte> GDINFPLMPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<byte> CBLJCNCHHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private NativeArray<int> CHBODEMFCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private bool DBMJCBEFOMJ;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int EJGEOKNPOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1EDFEE0", Offset = "0x1EDF0E0", VA = "0x181EDFEE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int DNNDEDEANNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xF53F30", Offset = "0xF53130", VA = "0x180F53F30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int KLPPFLKKDEK
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x62B1C50", Offset = "0x62B0E50", VA = "0x1862B1C50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int NCOBJPMBLNF
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x62B1C90", Offset = "0x62B0E90", VA = "0x1862B1C90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x62B14A0", Offset = "0x62B06A0", VA = "0x1862B14A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int KNMCPBOPKCD
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x62B1480", Offset = "0x62B0680", VA = "0x1862B1480")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x62B1C80", Offset = "0x62B0E80", VA = "0x1862B1C80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int ICAIIKCDMIE
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x62B14B0", Offset = "0x62B06B0", VA = "0x1862B14B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x62B1490", Offset = "0x62B0690", VA = "0x1862B1490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public EJDHPAFPNLO MDKOMOLNHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x62B14C0", Offset = "0x62B06C0", VA = "0x1862B14C0")]
		get
		{
			return default(EJDHPAFPNLO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x62B1D80", Offset = "0x62B0F80", VA = "0x1862B1D80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public byte OOPEADBKAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x62B1CA0", Offset = "0x62B0EA0", VA = "0x1862B1CA0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x62B1D90", Offset = "0x62B0F90", VA = "0x1862B1D90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public MCBNAIDPOPJ FOFBNHMHKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x62B1730", Offset = "0x62B0930", VA = "0x1862B1730")]
		get
		{
			return default(MCBNAIDPOPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x62B1DA0", Offset = "0x62B0FA0", VA = "0x1862B1DA0")]
	public FAJDHNMKDLH(IList<Mesh> JMHBFOAJIKM, IList<Matrix4x4> OFEGKANHFKO, IList<bool> IEAELJEFLEK, byte NLNFKDNDKLN, IList<byte[]> BMKJNFFKBMD, IList<int> FADBDEHNMBK, IList<bool> JGMLGIDAJMM, IList<int> HCMBBGLGDON, IList<int> FONOKJEOLLF, IList<int> AJFHLEJPMDK, Allocator LGNDPBNMKMP, EJDHPAFPNLO LJGGELGNOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x62B1CB0", Offset = "0x62B0EB0", VA = "0x1862B1CB0")]
	public ACCIIDBGCEL KDHKBGEPHBE(Allocator LGNDPBNMKMP)
	{
		return default(ACCIIDBGCEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x62B14D0", Offset = "0x62B06D0", VA = "0x1862B14D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DLFNECBFFJA]
public class FEPFENOAPIK : IPOLJMJAAMC
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x62B3680", Offset = "0x62B2880", VA = "0x1862B3680")]
	public FAJDHNMKDLH FJJBKKMPANK()
	{
		return default(FAJDHNMKDLH);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6298300", Offset = "0x6297500", VA = "0x186298300")]
	public FEPFENOAPIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct MCBNAIDPOPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public NativeSlice<Vector3> CDHIMFBCNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public NativeSlice<Vector3> BACMHADEMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeSlice<Vector4> KENFHEBDBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeSlice<Vector2> JOPLEJGKCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeSlice<Vector2> KLKCHFGMCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeSlice<Vector2> HFNGLJFFGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeSlice<Vector2> ENFHGLLEAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public NativeSlice<Color> CJHEFAHJJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeSlice<int> GNMFHLJKFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeSlice<int> MNCAHPCPPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeSlice<BoneWeight> PPAFOLDJBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeSlice<byte> JGHNHIDJELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public int OGABMLIINBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public Matrix4x4 PPLFFMOCNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public int FLHONCDCHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeSlice<byte> HNBEHHPGGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public bool ONGGJFEIJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int AFCAJAMMNPP;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal readonly struct LNOBLOJKIFI : IEquatable<LNOBLOJKIFI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	internal readonly Material COFJHALALNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	internal readonly HBKIBICCOCC KALIGJILONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	internal readonly BDOCIDDJPJJ EFDBCNFPIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	internal readonly HPNPAHEDPFN EHHJOEMCFAD;

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x958520", Offset = "0x957720", VA = "0x180958520")]
	public LNOBLOJKIFI(Material OOHAKCENEJE, HBKIBICCOCC PNDFOBOIMFP, BDOCIDDJPJJ KHDNLMAIGPB, HPNPAHEDPFN DEAEIDKDJNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x62B55E0", Offset = "0x62B47E0", VA = "0x1862B55E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x958270", Offset = "0x957470", VA = "0x180958270", Slot = "4")]
	public bool Equals(LNOBLOJKIFI JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x62B5450", Offset = "0x62B4650", VA = "0x1862B5450", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x62B5540", Offset = "0x62B4740", VA = "0x1862B5540", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class JMLEPPNDLIF
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class JMODHNOACEJ : IEnumerator<AEBIBAEBDOJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private AEBIBAEBDOJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private AEBIBAEBDOJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
		[DebuggerHidden]
		public JMODHNOACEJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x95F120", Offset = "0x95E320", VA = "0x18095F120", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x62B4490", Offset = "0x62B3690", VA = "0x1862B4490", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
	public static void BJLMOIJCFFI(string IFAFPBGLEJO, int IMEBMAMHMJD, long CBAGCBLPANG, long HJGLGGPBMGJ, long EEKDNJILDKL, long BALOLEPMDGN, long HGBIKLIAOBJ, long LODEGEOCJNA, long DKIINHIHHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x62B42D0", Offset = "0x62B34D0", VA = "0x1862B42D0")]
	public static MGBJAGNHOEE HNEMNGGDHHE(JobHandle LCJDAMOCFOO, bool EGIGFGLJNHC, bool BFMGHIDELBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x62B4420", Offset = "0x62B3620", VA = "0x1862B4420")]
	[IteratorStateMachine(typeof(JMODHNOACEJ))]
	private static IEnumerator<AEBIBAEBDOJ> KHFLHNGDOKO(JobHandle DHPHAFDDMEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class MPGNILAPOHP : NCOHBPPDDGO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private CMLPKLLOMEI BJIOPAPDJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private MGEMFBMNKAJ DBPLOBFOLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private IRecRoomQualityConfigProvider HCLIELBDMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private bool DBMJCBEFOMJ;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x62B5EE0", Offset = "0x62B50E0", VA = "0x1862B5EE0")]
	[JIMPHGEJKMA(CLDBMEKPFFP.GameOnly)]
	private static void OKAINDBHHOL(EHGDBDLIOFB IFAAMIKFIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x56044E0", Offset = "0x56036E0", VA = "0x1856044E0")]
	[UnityEngine.Scripting.Preserve]
	public MPGNILAPOHP([KFHLAIGNCCH(null)] MGEMFBMNKAJ BLOCHGBLLBG, [KFHLAIGNCCH(null)] CMLPKLLOMEI BDAMMJHONDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x62B5E70", Offset = "0x62B5070", VA = "0x1862B5E70")]
	private void IAHFJEHDDIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x62B5E10", Offset = "0x62B5010", VA = "0x1862B5E10", Slot = "4")]
	public void ELIDIDOLBNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x62B5950", Offset = "0x62B4B50", VA = "0x1862B5950", Slot = "5")]
	public AECHCDNEFCI<Texture2D> CLOEFNCLHBP(KHGKIALOKCP BDBFKMDGOII, [Optional] CLPKOMANLAG EOHMOLAFOBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x62B5810", Offset = "0x62B4A10", VA = "0x1862B5810")]
	private uint BHGPACLCGEJ(KHGKIALOKCP BDBFKMDGOII, CLPKOMANLAG EOHMOLAFOBC)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface POCHFFLPIAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGHFOPKNKOI(Mesh COKNMDIBDNP, Matrix4x4 HJFMGBIMNLI, byte[] HNBEHHPGGBL, bool DEIICDLKIKO = false, GKPJGAOJHHB.JGJMGEIKMEE ICPHBADFHIG = (GKPJGAOJHHB.JGJMGEIKMEE)0, int HCMBBGLGDON = -1, bool IEAELJEFLEK = false);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IBAGCOMAOHB(Allocator LGNDPBNMKMP, EJDHPAFPNLO LJGGELGNOGO, byte NLNFKDNDKLN, [Optional] IList<int> FONOKJEOLLF, [Optional] IList<int> FLPFBGGDDKC);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct FNOMCFFLEDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly GameObject BICAHMDPKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private readonly AvatarItemMaterial LJDHOGNHLCM;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x9FB690", Offset = "0x9FA890", VA = "0x1809FB690")]
	public FNOMCFFLEDL(GameObject BICAHMDPKNC, AvatarItemMaterial LJDHOGNHLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x62B3770", Offset = "0x62B2970", VA = "0x1862B3770")]
	public void CPEEILOCEGM(Material OOHAKCENEJE, int GGPGONDEEFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class NLOOJFGGCDI : BKKJNNHIJLF<Task<(GameObject, AvatarItemMaterial)>, FNOMCFFLEDL>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct BCHNGGAFDHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x62ADE20", Offset = "0x62AD020", VA = "0x1862ADE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x62AE320", Offset = "0x62AD520", VA = "0x1862AE320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private AECHCDNEFCI<GameObject> ACAALPCNHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private AECHCDNEFCI<AvatarItemMaterial> JDOIELBKGAH;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x62B6630", Offset = "0x62B5830", VA = "0x1862B6630")]
	private NLOOJFGGCDI(Task<(GameObject, AvatarItemMaterial)> IKEBALIIPCC, AECHCDNEFCI<GameObject> KPLNLPGHLFL, AECHCDNEFCI<AvatarItemMaterial> GJANNDPJCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x62B5FD0", Offset = "0x62B51D0", VA = "0x1862B5FD0")]
	public static NLOOJFGGCDI ADOMMGOMPJC(AssetReference PCNFFNBBCEC, [Optional] AssetReference EGDKDCPEDEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x62B6590", Offset = "0x62B5790", VA = "0x1862B6590", Slot = "11")]
	protected override FNOMCFFLEDL PGALNOAKNOM(Task<(GameObject, AvatarItemMaterial)> PEBEKNPNJIF)
	{
		return default(FNOMCFFLEDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x62B63E0", Offset = "0x62B55E0", VA = "0x1862B63E0", Slot = "12")]
	protected override void DKANOOPFGPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x62B6460", Offset = "0x62B5660", VA = "0x1862B6460")]
	[AsyncStateMachine(typeof(BCHNGGAFDHK))]
	private static Task<(GameObject, AvatarItemMaterial)> JFHCGGKHHIO(Task<GameObject> GJEBPICAFKB, Task<AvatarItemMaterial> GPFDEDNDLFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class LAJJDMJAIBO : BKKJNNHIJLF<Task<(Material, MaterialMapAsset)>, Material>
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class JIOGJJKEKCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public Material mat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public MaterialEntry entry;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public JIOGJJKEKCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x62B4260", Offset = "0x62B3460", VA = "0x1862B4260")]
		internal object AKCPIEBIBFO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class CDBOONBABKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public string shaderNameToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public JIOGJJKEKCB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public CDBOONBABKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x62AE390", Offset = "0x62AD590", VA = "0x1862AE390")]
		internal object BNAFHNHOMCP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x62AE5F0", Offset = "0x62AD7F0", VA = "0x1862AE5F0")]
		internal object FMHFPBODKLJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct PAKILICHEOP<T1, T2> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public AsyncTaskMethodBuilder<(T1, T2)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private T1 <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private TaskAwaiter<T1> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private TaskAwaiter<T2> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x439FB10", Offset = "0x439ED10", VA = "0x18439FB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x43A0190", Offset = "0x439F390", VA = "0x1843A0190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly LBOEGNBEJHN AMPJEKFBOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private AECHCDNEFCI<Material> HEOOIDHFBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private AECHCDNEFCI<MaterialMapAsset> EICDNKPCFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private bool JHCPIKAFJAA;

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x62B4540", Offset = "0x62B3740", VA = "0x1862B4540")]
	public static LAJJDMJAIBO FCODNPPLJPM(AssetReference DNNODDGBMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x62B4780", Offset = "0x62B3980", VA = "0x1862B4780")]
	private static AECHCDNEFCI<MaterialMapAsset> HIINBHGBDGN(AssetReference DNNODDGBMAF, [Out] bool JHCPIKAFJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x62B5010", Offset = "0x62B4210", VA = "0x1862B5010")]
	private LAJJDMJAIBO(Task<(Material, MaterialMapAsset)> IKEBALIIPCC, AECHCDNEFCI<Material> HEOOIDHFBAM, AECHCDNEFCI<MaterialMapAsset> NKBLPIBBOAF, bool JHCPIKAFJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x62B4DA0", Offset = "0x62B3FA0", VA = "0x1862B4DA0", Slot = "11")]
	protected override Material PGALNOAKNOM(Task<(Material, MaterialMapAsset)> PEBEKNPNJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x62B49D0", Offset = "0x62B3BD0", VA = "0x1862B49D0")]
	private void HNIEJOHKCBK(Material LFDBOGKPJGC, MaterialMapAsset DAEGLAIOHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x62B44E0", Offset = "0x62B36E0", VA = "0x1862B44E0", Slot = "12")]
	protected override void DKANOOPFGPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2A2D0A0", Offset = "0x2A2C2A0", VA = "0x182A2D0A0")]
	[AsyncStateMachine(typeof(PAKILICHEOP<, >))]
	private static Task<(T1, T2)> IONFHCOLHCP<T1, T2>(Task<T1> JKKLECIKJKL, Task<T2> HOMEOBLLEEI)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[EOOIALGHMHP(LIEGAMPPNDC.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x62B66C0", Offset = "0x62B58C0", VA = "0x1862B66C0")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct LCBLCHCHPLC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			public AsyncTaskMethodBuilder<CBIMLGEJDAN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public int eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			private TaskAwaiter<CBIMLGEJDAN> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x62B50A0", Offset = "0x62B42A0", VA = "0x1862B50A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x62B53E0", Offset = "0x62B45E0", VA = "0x1862B53E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private Dictionary<PLPCONDGDMD, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private Dictionary<PLPCONDGDMD, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private Dictionary<PLPCONDGDMD, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private Dictionary<PLPCONDGDMD, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private readonly Dictionary<PLPCONDGDMD, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private CBIMLGEJDAN _defaultFaceStyle;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x62B4230", Offset = "0x62B3430", VA = "0x1862B4230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x62B3C20", Offset = "0x62B2E20", VA = "0x1862B3C20")]
		public CBIMLGEJDAN EJMGFBHIPPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x62B3E40", Offset = "0x62B3040", VA = "0x1862B3E40")]
		[AsyncStateMachine(typeof(LCBLCHCHPLC))]
		public Task<CBIMLGEJDAN> MDHAJCJAGDF(int EHBLAGLCDDD, int CDPBAAOHLIE, int AMMKHHABEOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x62B3DA0", Offset = "0x62B2FA0", VA = "0x1862B3DA0")]
		public NoseFaceOption JGIHOMDAPMK(int FGDMADCMKLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x62B3AA0", Offset = "0x62B2CA0", VA = "0x1862B3AA0")]
		public SelectableFaceOption CFFMOPJGGAM(FaceFeatureType MJGEJCKDLFG, PLPCONDGDMD HNKJFIHFPLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x62B3C70", Offset = "0x62B2E70", VA = "0x1862B3C70")]
		public int FEHFOMFBMBA(PLPCONDGDMD HNKJFIHFPLK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x62B3F70", Offset = "0x62B3170", VA = "0x1862B3F70")]
		private void MJMBOMFHPHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2967780", Offset = "0x2966980", VA = "0x182967780")]
		private void MCFHPMCLGLI<T>(IDictionary<PLPCONDGDMD, T> FAEHLNLHLOA, IReadOnlyList<T> GDMMCKBOPBM) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x62B3CF0", Offset = "0x62B2EF0", VA = "0x1862B3CF0")]
		public PLPCONDGDMD INPDNNFPBCM(FaceFeatureType MJGEJCKDLFG)
		{
			return default(PLPCONDGDMD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x62B3980", Offset = "0x62B2B80", VA = "0x1862B3980")]
		public PLPCONDGDMD BHCGNHGCDJF(FaceFeatureType MJGEJCKDLFG)
		{
			return default(PLPCONDGDMD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x62B41A0", Offset = "0x62B33A0", VA = "0x1862B41A0")]
		public FaceStyleSet()
		{
		}
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
