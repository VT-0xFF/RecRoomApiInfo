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
	public class LogRegistrationIndex : PDIMPOELJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x60A1170", Offset = "0x60A0370", VA = "0x1860A1170", Slot = "4")]
		public override void FPMBLPAHIMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BE1A0", Offset = "0x7BD3A0", VA = "0x1807BE1A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x60A2750", Offset = "0x60A1950", VA = "0x1860A2750", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x60A2680", Offset = "0x60A1880", VA = "0x1860A2680", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x60A2710", Offset = "0x60A1910", VA = "0x1860A2710")]
		public RecNetCDNAssetReference(RecNetCDNKey GOBGGNLGONA)
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
			[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7B84D0", Offset = "0x7B76D0", VA = "0x1807B84D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7B6010", Offset = "0x7B5210", VA = "0x1807B6010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7BC9A0", Offset = "0x7BBBA0", VA = "0x1807BC9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x60A2790", Offset = "0x60A1990", VA = "0x1860A2790")]
		public static RecNetCDNKey FMMOKMGGOFE(string PNPKPEOFAPC, string OBDDBPMFAPD = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x58D75F0", Offset = "0x58D67F0", VA = "0x1858D75F0")]
		public void MBFIMLHMMEM(string GJNLGLHDEJJ, string LNOOCJJIMOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x60A2820", Offset = "0x60A1A20", VA = "0x1860A2820")]
		public RecNetCDNKey ICOPALFFJCE(string NJKPJIHMHKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x60A28D0", Offset = "0x60A1AD0", VA = "0x1860A28D0")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[PJKEGBNMNOG]
public class LBINCIGDOIA : IFIONJNFGEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> PDAOOEOGHBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> KIFGOLLDLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> GOJHFONNHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> BMFBMIDBLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> DGJKDHIKMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> IOEMHMAMAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> DINOBMPPFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator HAJNEPANBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected MKGMNCBPOEP MHKNPBOFMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte KCKIJPGNCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> KNADCHFKDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> FPEKBAGEHHP;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x609EB40", Offset = "0x609DD40", VA = "0x18609EB40", Slot = "4")]
	public void OJCBJDHMBMB(Mesh PGNOHIOKGKO, Matrix4x4 PFGNNCAGNIH, byte[] EDDLPNHNAJK, bool HHGHHMOEKDG = false, JHJCKMOKKIL.JDLFGAOPFIH NHJFGKEFEDI = (JHJCKMOKKIL.JDLFGAOPFIH)0, int GGKEOKACKKJ = -1, bool DEICFKLFMGP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x609E9D0", Offset = "0x609DBD0", VA = "0x18609E9D0", Slot = "5")]
	public void BPMGJCEGHAC(Allocator ILEAEEDKNCF, MKGMNCBPOEP DEKCPCOPHCP, byte CMEHKENFPEG, [Optional] IList<int> NGOCKNHIEHL, [Optional] IList<int> PKCFGIKAFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x609EA10", Offset = "0x609DC10", VA = "0x18609EA10")]
	private static void IILHPAHMANK(Mesh PGNOHIOKGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x609F000", Offset = "0x609E200", VA = "0x18609F000")]
	public LBINCIGDOIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[PJKEGBNMNOG]
public struct FMMJKHACPPH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public ACBNIDEJHCI EGDEIKLHFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int DCLMGDOHMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public GOIBIKGPNMC BKECJHELENO;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x608D760", Offset = "0x608C960", VA = "0x18608D760", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[PJKEGBNMNOG]
[NativeContainer]
public struct GOIBIKGPNMC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct CNMHAMBNELA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector3 OIJIPBLDNPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 IAAOFHLOLIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector4 JNJKKJAIGBM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct GGJPNGEJIOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float HFCBABKMDLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float GEHDEIFDIFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float NCOJECNEAMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float LAJAELNHMNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte FOHHNMJDKOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte CAGDCFOIOOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte PHFOECPFKPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte DEEIGBMFJBA;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct JFGPKNACNGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half HFCBABKMDLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half GEHDEIFDIFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half NCOJECNEAMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half LAJAELNHMNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte FOHHNMJDKOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte CAGDCFOIOOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte PHFOECPFKPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte DEEIGBMFJBA;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct NNFKPGBKAFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 NHDAKDKKMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 INFMIOHBGGC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct HECMFPBDCJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half4 NHDAKDKKMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 INFMIOHBGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 BFHODEMGKFJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct COJGHCDPKGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 NHDAKDKKMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 INFMIOHBGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 BFHODEMGKFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 AAEDJOOKGJH;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct GMNEFOGPFHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half4 NHDAKDKKMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 INFMIOHBGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 BFHODEMGKFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 AAEDJOOKGJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 BJEPBCANNPE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct OMDFFHMJIFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float HFCBABKMDLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float GEHDEIFDIFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float NCOJECNEAMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float LAJAELNHMNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int FOHHNMJDKOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int CAGDCFOIOOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int PHFOECPFKPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int DEEIGBMFJBA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct NGEKHLFJOKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Color NHDAKDKKMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 INFMIOHBGGC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct FIANEPMGHHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color NHDAKDKKMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 INFMIOHBGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 BFHODEMGKFJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct IHFFABNOAOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color NHDAKDKKMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 INFMIOHBGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 BFHODEMGKFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 AAEDJOOKGJH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct JDJNBIKBNIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color NHDAKDKKMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 INFMIOHBGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 BFHODEMGKFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 AAEDJOOKGJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 BJEPBCANNPE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool BFAKDFBKFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<CNMHAMBNELA> GAHPBKHEMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<NNFKPGBKAFM> GLGGAEGFKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<HECMFPBDCJE> MCGDGCJJJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<COJGHCDPKGM> CBMFIKBNABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<GMNEFOGPFHD> FJOBBIFEJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<JFGPKNACNGO> JJGOHBLEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<GGJPNGEJIOJ> OIOPOOEJDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<NGEKHLFJOKF> MKJEGACDJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<FIANEPMGHHM> IFONOBJNFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<IHFFABNOAOH> AMFOHLHDHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<JDJNBIKBNIF> CBBPCIJIIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<OMDFFHMJIFA> FEFFLCKDCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> FGKAIIANFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> LBMHGFDNFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> NLDLCKLCGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> IIJIHIDCBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> HAJADIIJIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> HBEPPHFJLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> OAOPPFPMAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<BoneWeight> CMDBOGAHALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> HELLICJGLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool CCIADKPDMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool CMAGAPGCJGF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DELPPFEEMLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6091310", Offset = "0x6090510", VA = "0x186091310")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x608F730", Offset = "0x608E930", VA = "0x18608F730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int GHKCOLBMEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x608F2F0", Offset = "0x608E4F0", VA = "0x18608F2F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6090490", Offset = "0x608F690", VA = "0x186090490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int ABJGBHFMHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6091320", Offset = "0x6090520", VA = "0x186091320")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6090480", Offset = "0x608F680", VA = "0x186090480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int IKCHMHACNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x60913C0", Offset = "0x60905C0", VA = "0x1860913C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6091510", Offset = "0x6090710", VA = "0x186091510")]
	public GOIBIKGPNMC(int HDKNFOBLGHM, int GGCPFDGBHPE, int CINCJFABGGI, int EKLGOFDACHM, Allocator ILEAEEDKNCF, int DICNNKMLDPB, IEEKFFBHBPA ACGNKBIFDHA, bool CCIADKPDMPE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6091330", Offset = "0x6090530", VA = "0x186091330")]
	public void MBKBPEGMEII(int HMFNCGHECPG, Vector3 IFBNMJJOJMJ, Vector3 MJNCNGDNKAB, Vector4 MOAGOANMCEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x608F300", Offset = "0x608E500", VA = "0x18608F300")]
	public void AFKDCPNLOEJ(int HMFNCGHECPG, BoneWeight JADDFAIGMKK, NativeSlice<byte> EDDLPNHNAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x608F740", Offset = "0x608E940", VA = "0x18608F740")]
	public Color CCBPJIDGLKG(int HMFNCGHECPG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6090080", Offset = "0x608F280", VA = "0x186090080")]
	public void EINCEAMIDJH(int HMFNCGHECPG, Color MOAAELBABJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x608FA70", Offset = "0x608EC70", VA = "0x18608FA70")]
	public void CFDOPLGCFOB(byte KCIHAABCANA, int HMFNCGHECPG, Vector2 EGCBKGMHAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6091500", Offset = "0x6090700", VA = "0x186091500")]
	public void OKGFJNCIELP(int HMFNCGHECPG, int ALOGNOJFJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x608F290", Offset = "0x608E490", VA = "0x18608F290")]
	public bool AAPKIOBOMOL(int KCIHAABCANA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6091430", Offset = "0x6090630", VA = "0x186091430")]
	public void NPGDJFDMOPN(int LGKAHANLLCD, int BJPGLMJPACN, int HHOELNLHIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x608FE20", Offset = "0x608F020", VA = "0x18608FE20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x60904A0", Offset = "0x608F6A0", VA = "0x1860904A0")]
	public Mesh INABOLBPEEJ([Optional] string NJAAPLJCOHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
[PJKEGBNMNOG]
[NativeContainer]
public struct ACBNIDEJHCI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Mesh.MeshDataArray FHIGFPBCMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<int> FGEHAKAGLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> HFOHBBFKIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<BoneWeight> CMDBOGAHALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<Matrix4x4> JFODEHBFNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> AHBHJEPAPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<byte> FAHJDDGHDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> JICDJCGNLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> GDLDOCHNCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeArray<sbyte> NINOFPGFOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<byte> GNDKMCAOOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<bool> DEICFKLFMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<int> GGKEOKACKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool CCIADKPDMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<int> DEGLAKCLJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool CMAGAPGCJGF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int EIEIECFEAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x608B3C0", Offset = "0x608A5C0", VA = "0x18608B3C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int BDCFCKIEAFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x608AEC0", Offset = "0x608A0C0", VA = "0x18608AEC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int HICEPCIICNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x608B400", Offset = "0x608A600", VA = "0x18608B400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int MCINKFPOMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x608AED0", Offset = "0x608A0D0", VA = "0x18608AED0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x608B3F0", Offset = "0x608A5F0", VA = "0x18608B3F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int DELPPFEEMLC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x608B3D0", Offset = "0x608A5D0", VA = "0x18608B3D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x608AEB0", Offset = "0x608A0B0", VA = "0x18608AEB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int BBOHBFGCPPP
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x608B3A0", Offset = "0x608A5A0", VA = "0x18608B3A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x608B3B0", Offset = "0x608A5B0", VA = "0x18608B3B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public MKGMNCBPOEP HOEOGIIEOHB
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x608B140", Offset = "0x608A340", VA = "0x18608B140")]
		get
		{
			return default(MKGMNCBPOEP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x608B3E0", Offset = "0x608A5E0", VA = "0x18608B3E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte JHLMKBLDHFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x608AEF0", Offset = "0x608A0F0", VA = "0x18608AEF0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x608AEE0", Offset = "0x608A0E0", VA = "0x18608AEE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NOJOIACKIDL HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x608B150", Offset = "0x608A350", VA = "0x18608B150")]
		get
		{
			return default(NOJOIACKIDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x608B4D0", Offset = "0x608A6D0", VA = "0x18608B4D0")]
	public ACBNIDEJHCI(IList<Mesh> HLGNPGKNFFF, IList<Matrix4x4> LIFMHAFCEKM, IList<bool> DEICFKLFMGP, byte CMEHKENFPEG, IList<byte[]> NCAAHONPNPC, IList<int> BEFPKIGJLDA, IList<bool> FBCPLHFEAOL, IList<int> GGKEOKACKKJ, IList<int> NGOCKNHIEHL, IList<int> EENODAHPBCA, Allocator ILEAEEDKNCF, MKGMNCBPOEP DEKCPCOPHCP, bool CCIADKPDMPE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x608B070", Offset = "0x608A270", VA = "0x18608B070")]
	public GOIBIKGPNMC EEABEHGJFLA(Allocator ILEAEEDKNCF, IEEKFFBHBPA ACGNKBIFDHA)
	{
		return default(GOIBIKGPNMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x608AF00", Offset = "0x608A100", VA = "0x18608AF00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[PJKEGBNMNOG]
public class CMBGIIKLPCN : LBINCIGDOIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool BHMFNHPPMNJ;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x608C900", Offset = "0x608BB00", VA = "0x18608C900")]
	public ACBNIDEJHCI IALGFDFONBH()
	{
		return default(ACBNIDEJHCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x608CA20", Offset = "0x608BC20", VA = "0x18608CA20")]
	public CMBGIIKLPCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct NOJOIACKIDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Mesh.MeshData GDEPJGCMHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeSlice<BoneWeight> CMDBOGAHALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<byte> CONENGKNOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public int BMGFHHEIEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Matrix4x4 DCLBJBKIONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public int FBFBGKFDGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeSlice<byte> EDDLPNHNAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public bool EHIDBPDMCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public int DKICHPEEBOC;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class HCEFILIJBHC : IJFEPFDLJEB
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class HHPIPHPPHGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public readonly BKAHNFPJFDO CDAKOIINLKI;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual bool EGGMOLDFDPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public virtual bool CNOCMNPFKEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual JHJCKMOKKIL.JDLFGAOPFIH FBFBGKFDGKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "6")]
			get
			{
				return default(JHJCKMOKKIL.JDLFGAOPFIH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool FIBNJOLGCMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x1362560", Offset = "0x1361760", VA = "0x181362560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool POAMJMAMEJL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x609E1D0", Offset = "0x609D3D0", VA = "0x18609E1D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool MJKKDBEHEAP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x609E1E0", Offset = "0x609D3E0", VA = "0x18609E1E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7B7470", Offset = "0x7B6670", VA = "0x1807B7470")]
		protected HHPIPHPPHGD(BKAHNFPJFDO IHBCJFAIMMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract OFPHFCMJPLJ AIONAMPHNGC(int[] FKJMCINKGEF, List<JOOIKNJLOAP> CCDKMBJMIDD, List<JOOIKNJLOAP> FNBNJDHLJBG);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract KLHIEDGONPE JNCAHJKHOCK(uint DKNFDKCGOLD);
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class JGIOGKHLLNP : HHPIPHPPHGD
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class CMPFFELOJEE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public IKCNFNMPLNN<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public JGIOGKHLLNP <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public CMPFFELOJEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x608CA30", Offset = "0x608BC30", VA = "0x18608CA30")]
			internal void NKANLOFCCFE(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly AvatarSkinAssetItem.PDOMDOLMNBG AEFPPIHBCNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly AssetReference BAPNJNBEHBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly JHJCKMOKKIL.JDLFGAOPFIH IALLPHFILFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly LDNHAIONBAK? GKJPGCPHCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly Material[] EGDKGFCMACI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private SkinnedMeshRenderer[] PNJKKOMLJFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private AvatarSkinAssetItem PBNHCKCKGAH;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override JHJCKMOKKIL.JDLFGAOPFIH FBFBGKFDGKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7B9980", Offset = "0x7B8B80", VA = "0x1807B9980", Slot = "6")]
			get
			{
				return default(JHJCKMOKKIL.JDLFGAOPFIH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x609E760", Offset = "0x609D960", VA = "0x18609E760")]
		public JGIOGKHLLNP(AvatarSkinAssetItem.PDOMDOLMNBG AKOIFOAKICP, AssetReference HMMOMILLADJ, Material EKMFDOGMKON, BKAHNFPJFDO IHALIDJJKLH, JHJCKMOKKIL.JDLFGAOPFIH AOCCBHMDOHH = (JHJCKMOKKIL.JDLFGAOPFIH)0, [Optional] LDNHAIONBAK? JHPNHFGENCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x609E870", Offset = "0x609DA70", VA = "0x18609E870")]
		public JGIOGKHLLNP(AvatarSkinAssetItem.PDOMDOLMNBG AKOIFOAKICP, AssetReference HMMOMILLADJ, Material EKMFDOGMKON, JHJCKMOKKIL.JDLFGAOPFIH AOCCBHMDOHH = (JHJCKMOKKIL.JDLFGAOPFIH)0, [Optional] LDNHAIONBAK? JHPNHFGENCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x609E200", Offset = "0x609D400", VA = "0x18609E200", Slot = "7")]
		public override OFPHFCMJPLJ AIONAMPHNGC(int[] FKJMCINKGEF, List<JOOIKNJLOAP> CCDKMBJMIDD, List<JOOIKNJLOAP> FNBNJDHLJBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x609E420", Offset = "0x609D620", VA = "0x18609E420", Slot = "8")]
		public override KLHIEDGONPE JNCAHJKHOCK(uint DKNFDKCGOLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x609E6F0", Offset = "0x609D8F0", VA = "0x18609E6F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class NEFELFHPKHK : HHPIPHPPHGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly DFLONJANIBI DAIDCONKEFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private IKCNFNMPLNN<AIGHBMAONEB> KLNJALOPGHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public AIGHBMAONEB IPFCPEHKEGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private IKCNFNMPLNN<Material>[] LMNIMJLPFIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public List<Material> EJKDOIEIOIJ;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool EGGMOLDFDPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool CNOCMNPFKEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x60A1660", Offset = "0x60A0860", VA = "0x1860A1660", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1B72DD0", Offset = "0x1B71FD0", VA = "0x181B72DD0")]
		public NEFELFHPKHK(BKAHNFPJFDO IHBCJFAIMMA, DFLONJANIBI BKBOCELKGMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x60A1200", Offset = "0x60A0400", VA = "0x1860A1200", Slot = "7")]
		public override OFPHFCMJPLJ AIONAMPHNGC(int[] FKJMCINKGEF, List<JOOIKNJLOAP> CCDKMBJMIDD, List<JOOIKNJLOAP> FNBNJDHLJBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x60A1C20", Offset = "0x60A0E20", VA = "0x1860A1C20", Slot = "8")]
		public override KLHIEDGONPE JNCAHJKHOCK(uint DKNFDKCGOLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x60A20B0", Offset = "0x60A12B0", VA = "0x1860A20B0")]
		public KLHIEDGONPE PDOADLICJDK(GameObject CEFHHCEGCPL, uint DKNFDKCGOLD, bool DLHNGMDOEAJ, bool DJOFDPDHOCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x60A18C0", Offset = "0x60A0AC0", VA = "0x1860A18C0")]
		public static bool EBGLBGDKGFN(Renderer[] HHPLDFEJBDG, string KLCNNEPPFFF, [Out] Renderer EBDPJIPJDLK, [Out] Renderer EEEALIHKLHH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x60A22A0", Offset = "0x60A14A0", VA = "0x1860A22A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x60A16C0", Offset = "0x60A08C0", VA = "0x1860A16C0")]
		private (IKCNFNMPLNN<AIGHBMAONEB>, IKCNFNMPLNN<Material>[]) EAOKBPKINJE()
		{
			return default((IKCNFNMPLNN<AIGHBMAONEB>, IKCNFNMPLNN<Material>[]));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x60A1D50", Offset = "0x60A0F50", VA = "0x1860A1D50")]
		private IKCNFNMPLNN<Material>[] MFFEELKHPEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3D98B80", Offset = "0x3D97D80", VA = "0x183D98B80")]
		[CompilerGenerated]
		private void MBJBGOKJLDJ(AIGHBMAONEB HCIDHCBMOPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x60A1F80", Offset = "0x60A1180", VA = "0x1860A1F80")]
		[CompilerGenerated]
		private void OJEAAJADGJO(IKCNFNMPLNN<Material> LFGOHDHKODC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x60A1ED0", Offset = "0x60A10D0", VA = "0x1860A1ED0")]
		[CompilerGenerated]
		private void NCHKEPFGBIH(Material HCIDHCBMOPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class BKKGAKEBHBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public HCEFILIJBHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public GJKGGCLGKLL buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public BKKGAKEBHBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x608C750", Offset = "0x608B950", VA = "0x18608C750")]
		internal void FJBKBMPLKIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x608C800", Offset = "0x608BA00", VA = "0x18608C800")]
		internal void HHHMCIFFAEK(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x608C820", Offset = "0x608BA20", VA = "0x18608C820")]
		internal void OIGBDKIOKFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x608C770", Offset = "0x608B970", VA = "0x18608C770")]
		internal void FPBOLDCCCBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
		internal OFPHFCMJPLJ MNLKMJEPBKJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DPPCJOPDGJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public BKKGAKEBHBI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public DPPCJOPDGJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x608D0C0", Offset = "0x608C2C0", VA = "0x18608D0C0")]
		internal NLFHNLDHPIK NLEOAPDEGHG(int lod)
		{
			return default(NLFHNLDHPIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class NJPDOHFIHDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public List<GJKGGCLGKLL> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public NJPDOHFIHDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x60A22F0", Offset = "0x60A14F0", VA = "0x1860A22F0")]
		internal void OPKBKMFIHFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class PNOACCOKAOE : IEnumerator<JGIJKBAPGME>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private JGIJKBAPGME <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public HCEFILIJBHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<HHPIPHPPHGD> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public List<GJKGGCLGKLL> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public Func<int, NLFHNLDHPIK> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public FGEPINKCBOD materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private JGIJKBAPGME System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7B7470", Offset = "0x7B6670", VA = "0x1807B7470")]
		[DebuggerHidden]
		public PNOACCOKAOE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x60A2420", Offset = "0x60A1620", VA = "0x1860A2420", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x60A2630", Offset = "0x60A1830", VA = "0x1860A2630", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class CABPOCBIKFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public HCEFILIJBHC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public CABPOCBIKFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x608C8B0", Offset = "0x608BAB0", VA = "0x18608C8B0")]
		internal OFPHFCMJPLJ IFBEOPONGGN(HHPIPHPPHGD p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OMEPJFIIDBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public CEHKNHEODJC cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public OMEPJFIIDBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x845CE0", Offset = "0x844EE0", VA = "0x180845CE0")]
		internal void OMCOJFCMJNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8D03C0", Offset = "0x8CF5C0", VA = "0x1808D03C0")]
		internal void KBHEODFAHJB(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class DCABAEJJKDE
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
		public HCEFILIJBHC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public DCABAEJJKDE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class EIPLHMLIKHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public GOIBIKGPNMC defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public ACBNIDEJHCI defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public DCABAEJJKDE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public EIPLHMLIKHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x608D1F0", Offset = "0x608C3F0", VA = "0x18608D1F0")]
		internal void FFNBIJJBOAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x608D180", Offset = "0x608C380", VA = "0x18608D180")]
		internal void DCLAFDIIGCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class COEPEODDOAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public AKEPPDLGLKA legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public JGOLNAPDOFF legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public DCABAEJJKDE CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public COEPEODDOAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x608CE20", Offset = "0x608C020", VA = "0x18608CE20")]
		internal void BFEFIMOLJFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x608D050", Offset = "0x608C250", VA = "0x18608D050")]
		internal void LBPJEBBJMIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class FCBFPACGHMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public CEHKNHEODJC cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public DFLONJANIBI avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public HCEFILIJBHC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public FCBFPACGHMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x608D460", Offset = "0x608C660", VA = "0x18608D460")]
		internal OFPHFCMJPLJ JLPFAKFCDNP(IGIDDLBKHDO item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x608D420", Offset = "0x608C620", VA = "0x18608D420")]
		internal void HBELLJMADFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class KKKIMANAGKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public IKCNFNMPLNN<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public KKKIMANAGKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x609E980", Offset = "0x609DB80", VA = "0x18609E980")]
		internal void HELKMOFCHFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class GEPMEGODALK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public BKAHNFPJFDO overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public GEPMEGODALK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x608F210", Offset = "0x608E410", VA = "0x18608F210")]
		internal bool ICKKLBPAEFK(KeyValuePair<string, DFLONJANIBI> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private AvatarConfiguration BGCLOLEEFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Transform HGNACJIBCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private AssetReference BAPNJNBEHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private GameObject OPNAMBPPANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private GameObject KAPDMHACANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private SkinnedMeshRenderer CPPOALCIFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private Transform[] AMCBCLKKHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private Matrix4x4[] IDBJGKBKMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Material LMCCCMGPAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Material NPILNKHFEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Material PGALEDGGKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Shader FMGHNLLOFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Shader AHJIPLNJLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Animator KPOCLDBJFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Renderer[] KNOFCOGHAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private JHJCKMOKKIL.JDLFGAOPFIH DHNOBNNFAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Color GDOPDCKAJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Color JMBLCGLBBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Color HENLGJFIBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Color? CIKHDNPANNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Color? COLOCGABCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Color? JOGDEMHKBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Color? GGGMHLEGNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Texture2D NPOBOINEACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Texture2D PGFOEHBDAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[CanBeNull]
	private DFLONJANIBI HEADFHAJPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Texture NDFMCIIHAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Color NPHIBNJKOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public Dictionary<Renderer, FGEPINKCBOD> MKKLEJPOJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Dictionary<Renderer, FGEPINKCBOD> GLMGAPOODOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Dictionary<string, List<GLINILPMODE>> GODHOEMNFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Dictionary<string, List<GLINILPMODE>> KAJCBOEEMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly List<JOOIKNJLOAP> BMGDJDIELGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly List<JOOIKNJLOAP> EAHOHDAMJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly List<JOOIKNJLOAP> FOKHGCGGHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly List<JOOIKNJLOAP> AICDKHEBNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Dictionary<GLINILPMODE, Material> OIBBEDOIBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<GLINILPMODE, Material> INEAJKIEJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private SkinnedMeshRenderer[] POJJACBDOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private SkinnedMeshRenderer[] EJPNDLEOHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private SkinnedMeshRenderer[] GGHHIPNHOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private SkinnedMeshRenderer[] HEOJIBBFDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly Dictionary<string, IKCNFNMPLNN<Texture2D>> OMBHLDKPJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly Dictionary<string, IKCNFNMPLNN<Texture2D>> FELDJJFDFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private FitMeshHemisphere GBGIKCCCMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private bool PDEIIINJNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private BONMPAHMNCG IFMOPAEIMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool OJNIIACECMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private AnchorParamsRestrictions NHCBJIJJGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private bool GNLOLGJEOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Transform PEFJCGMKIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Transform GFKKKNOMOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private bool NCFJPPPDFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x201")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private bool OJIJFHKELOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private Vector3 ANLELHEEDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Quaternion ONHHEOABMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Vector2 MILCGEELHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private FitMeshHemisphere CKFCBPLCCCK;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Material AOLPKJCDAOG;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Material LJJICOOKLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Dictionary<string, DFLONJANIBI> EIDDIBLCGPD;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int ILJMHMCEKGI;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int PIIOCEBCGMC;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int BDGMPPLKJBJ;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int JFLAGGGCMIL;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int AGLKOCAMLBJ;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int NCMKEDICOCO;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int BKMLJDNINJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly AGKHEGBIBIG MEFLJDFFONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly AGKHEGBIBIG KPLCFIKBBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private bool PBEKMLBJMED;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static Lazy<COFOAKELILD> HGBEIFKKOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private Lazy<EPNMAEKOFED> HGECJGGPJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private Lazy<GAJDIDMKDHM> NEKHFJMFAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private List<Action> JEAGJDLPMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private FDEEEEBPKBB JKDAIKDIGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private SkinnedMeshRenderer[] ONKDHIAPGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private int BLDFNNHIFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool OLIHNMAMMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int NEGMMJPMMAC;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool IKJPPODIHBL
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x609B0E0", Offset = "0x609A2E0", VA = "0x18609B0E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6095780", Offset = "0x6094980", VA = "0x186095780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool EHFCEDLKJFE
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x609CC00", Offset = "0x609BE00", VA = "0x18609CC00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material NGJBPBAMDIL
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6098270", Offset = "0x6097470", VA = "0x186098270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Material KDKIGKKJPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6097190", Offset = "0x6096390", VA = "0x186097190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private bool EFDBNMLMBAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private static COFOAKELILD CFGHIMEJAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6091FC0", Offset = "0x60911C0", VA = "0x186091FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private EPNMAEKOFED PBNEBEDEMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6095FE0", Offset = "0x60951E0", VA = "0x186095FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private GAJDIDMKDHM KFEAOHFMLFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6091F40", Offset = "0x6091140", VA = "0x186091F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public AGKHEGBIBIG FFKOCOKCFCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9BAAC0", Offset = "0x9B9CC0", VA = "0x1809BAAC0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public AGKHEGBIBIG HBAFAGKHIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9BA240", Offset = "0x9B9440", VA = "0x1809BA240", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public SkinnedMeshRenderer[] OHFFGHMPBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x125BE90", Offset = "0x125B090", VA = "0x18125BE90", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Renderer[] MMBEHGGNNBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7C0FB0", Offset = "0x7C01B0", VA = "0x1807C0FB0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool GLIMIALOHID
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6098960", Offset = "0x6097B60", VA = "0x186098960", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public JHJCKMOKKIL.JDLFGAOPFIH CFEAFBKIHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xEB46B0", Offset = "0xEB38B0", VA = "0x180EB46B0", Slot = "18")]
		get
		{
			return default(JHJCKMOKKIL.JDLFGAOPFIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int IICPJKBAJMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x852330", Offset = "0x851530", VA = "0x180852330")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6093440", Offset = "0x6092640", VA = "0x186093440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private bool MPFDNGOBOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x609D2E0", Offset = "0x609C4E0", VA = "0x18609D2E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private static bool PFLNCMHBGAG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6099250", Offset = "0x6098450", VA = "0x186099250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x609D8E0", Offset = "0x609CAE0", VA = "0x18609D8E0")]
	public HCEFILIJBHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x60953C0", Offset = "0x60945C0", VA = "0x1860953C0", Slot = "21")]
	public void GEJAFFIMNGM(AGMEINJJBEA GEFEOADCJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x609B420", Offset = "0x609A620", VA = "0x18609B420", Slot = "22")]
	public void OMAGFCIJMBF(PKAHLJKMCJJ JEMGMLCFHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6093440", Offset = "0x6092640", VA = "0x186093440", Slot = "4")]
	public void ILHBOABLDHO(int DKNFDKCGOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6099060", Offset = "0x6098260", VA = "0x186099060", Slot = "9")]
	public void NEAFPMKLHGE(AIBHHEMNOJP LHMDOGCBFFL, Texture2D AFMCPMEGELI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6093650", Offset = "0x6092850", VA = "0x186093650", Slot = "10")]
	public void CCGBMLFJJKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x609D170", Offset = "0x609C370", VA = "0x18609D170", Slot = "11")]
	public bool PKLGKLCFJJI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x609CC10", Offset = "0x609BE10", VA = "0x18609CC10", Slot = "8")]
	public void PHDGBCGLLAI(KOLNPDEHNMN BFMACMPMLPD, Color? NHDAKDKKMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x609B0F0", Offset = "0x609A2F0", VA = "0x18609B0F0")]
	private void OFGMDIEPEAN(Action IKEIHNJIGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x60936D0", Offset = "0x60928D0", VA = "0x1860936D0", Slot = "5")]
	public void CGINBJGFJKM(DFLONJANIBI HICKFPKFJBH, Texture MNAPJOALOLH, Color FMLIPCLLMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6095780", Offset = "0x6094980", VA = "0x186095780", Slot = "6")]
	public void GLFAGKCAIOL(bool FHDNAFBIMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x9B27B0", Offset = "0x9B19B0", VA = "0x1809B27B0", Slot = "7")]
	public void KAMAJKKNOOI(FDEEEEBPKBB HELLICJGLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x609B650", Offset = "0x609A850", VA = "0x18609B650", Slot = "14")]
	public GJKGGCLGKLL PCDDHEKOCKB(KEHFDAKLHGP EAFDAEOGHNK, bool INHLFDOHAGG, int[] MNGONCILPOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6092400", Offset = "0x6091600", VA = "0x186092400", Slot = "15")]
	public void BBCOKHNJDAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6097AA0", Offset = "0x6096CA0", VA = "0x186097AA0")]
	private bool KHHFODFMEIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xEB44A0", Offset = "0xEB36A0", VA = "0x180EB44A0", Slot = "19")]
	public void EOBNAJBCFGA(JHJCKMOKKIL.JDLFGAOPFIH OJDEEPCPGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6097650", Offset = "0x6096850", VA = "0x186097650")]
	private bool JEKCFHMCIMH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6092E70", Offset = "0x6092070", VA = "0x186092E70")]
	private GJKGGCLGKLL BJPDIACEHIK(bool INHLFDOHAGG, List<HHPIPHPPHGD> DCPJIAOEPKC, int[] MNGONCILPOG, Func<int, NLFHNLDHPIK> ECNDNONGNNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6098520", Offset = "0x6097720", VA = "0x186098520")]
	[IteratorStateMachine(typeof(PNOACCOKAOE))]
	private IEnumerator<JGIJKBAPGME> LJLFPDMDHKH(bool INHLFDOHAGG, List<HHPIPHPPHGD> DCPJIAOEPKC, int[] MNGONCILPOG, Func<int, NLFHNLDHPIK> ECNDNONGNNJ, FGEPINKCBOD HHIAICICPKE, Material BCNAILKKOBI, List<GJKGGCLGKLL> OGAGIJHFLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6095D20", Offset = "0x6094F20", VA = "0x186095D20")]
	private GJKGGCLGKLL HEGKLLKHFJP(List<HHPIPHPPHGD> DCPJIAOEPKC, int[] MNGONCILPOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6099440", Offset = "0x6098640", VA = "0x186099440")]
	private HDONKFMMCKJ NGIFFNFPFBH(List<HHPIPHPPHGD> DCPJIAOEPKC, int DKNFDKCGOLD, bool INHLFDOHAGG, NLFHNLDHPIK AGBFFDLLICJ, bool MHNFHLPFMCD, FGEPINKCBOD HHIAICICPKE, Material BCNAILKKOBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x609B4A0", Offset = "0x609A6A0", VA = "0x18609B4A0")]
	private void ONFCJIDDJJK(SkinnedMeshRenderer CGNBNGILAEI, Mesh PGNOHIOKGKO, List<Material> BNOINJGPFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x609D010", Offset = "0x609C210", VA = "0x18609D010")]
	private static Material PHNNJBLFGND(Dictionary<GLINILPMODE, Material> OGBBFOOKKIN, Material BBDDJIDOJLE, LCOJHOLPOJB ODEFHMLHEMA, BDOCOBBFHFE HNGJGBNGCII, BKAHNFPJFDO IHALIDJJKLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6097CC0", Offset = "0x6096EC0", VA = "0x186097CC0")]
	private static LCOJHOLPOJB KJJHLFPDPOP(HHPIPHPPHGD CDNGGJOBECP, int AGAMOCHCHBE)
	{
		return default(LCOJHOLPOJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6094AE0", Offset = "0x6093CE0", VA = "0x186094AE0")]
	private void FMAJJEEJPJB(int CODKAKNBBMF, Material PEGNOKKFPLO, HHPIPHPPHGD CDNGGJOBECP, [Out] Texture2D OJPNOCEGEDN, [Out] Vector4 DBOOKELEFEN, [Out] Texture2D DFOGDPGPMJB, [Out] Texture2D MBMAKECDAEH, [Out] Texture2D PPEKFLAKLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6095820", Offset = "0x6094A20", VA = "0x186095820")]
	private void HCICFFMKJGP(int CODKAKNBBMF, Material PEGNOKKFPLO, HHPIPHPPHGD CDNGGJOBECP, [Out] Color DLLDKNALJID, [Out] Color DPEECIGHFMO, [Out] Color BMCFMJJIDFC, [Out] Color ILEACOHALKB, [Out] Color AMAAMILNPOF, [Out] Color JCBMNBHOAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6093D00", Offset = "0x6092F00", VA = "0x186093D00")]
	private bool COJDIDHAPHH(Material PEGNOKKFPLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6097440", Offset = "0x6096640", VA = "0x186097440")]
	private static Material ILDNKLKCGCA(int CODKAKNBBMF, NEFELFHPKHK CDNGGJOBECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x609B330", Offset = "0x609A530", VA = "0x18609B330")]
	private static BDOCOBBFHFE OJDDKDGJNJM(HHPIPHPPHGD CDNGGJOBECP, int AGAMOCHCHBE)
	{
		return default(BDOCOBBFHFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x609D360", Offset = "0x609C560", VA = "0x18609D360")]
	private static void PPFIMOPKFHP(Dictionary<string, List<GLINILPMODE>> MMIHEHFLHMB, HHPIPHPPHGD JCNHMEPJJHA, Material BBDDJIDOJLE, LCOJHOLPOJB BFMACMPMLPD, BDOCOBBFHFE LHMDOGCBFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x609AE80", Offset = "0x609A080", VA = "0x18609AE80")]
	private static SkinnedMeshRenderer OAMFPMOINEO(Transform MLMLECMMNPO, Transform DLLJJFNPGPI, SkinnedMeshRenderer[] HHPLDFEJBDG, int DKNFDKCGOLD, NLFHNLDHPIK AGBFFDLLICJ, bool INHLFDOHAGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x60921F0", Offset = "0x60913F0", VA = "0x1860921F0")]
	private void BBCEICMEKHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6097A90", Offset = "0x6096C90", VA = "0x186097A90")]
	private void KDPGNCDEDJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x609B1D0", Offset = "0x609A3D0", VA = "0x18609B1D0")]
	private static void OFHIOJNPGOB(Dictionary<GLINILPMODE, Material> OGBBFOOKKIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6098AD0", Offset = "0x6097CD0", VA = "0x186098AD0")]
	private static void MHLKJCJIMMC(Dictionary<Renderer, FGEPINKCBOD> ENOMGIMNHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6098400", Offset = "0x6097600", VA = "0x186098400")]
	private void LHBAEFHLABD(SkinnedMeshRenderer[] HHPLDFEJBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6093740", Offset = "0x6092940", VA = "0x186093740")]
	private void CHMNGGGAGAA(SkinnedMeshRenderer KEDLALENHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6093F60", Offset = "0x6093160", VA = "0x186093F60")]
	private void DGJJGNOHPAI(List<JOOIKNJLOAP> DGAAKAGOIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x60977A0", Offset = "0x60969A0", VA = "0x1860977A0")]
	private void JKPICAINNEH(Dictionary<string, IKCNFNMPLNN<Texture2D>> MMIHEHFLHMB, bool AHGJFIPFBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x60993F0", Offset = "0x60985F0", VA = "0x1860993F0")]
	private void NGGNODEHFGC(Dictionary<string, List<GLINILPMODE>> MMIHEHFLHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6094170", Offset = "0x6093370", VA = "0x186094170")]
	private void EBJNMCPPGFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6098650", Offset = "0x6097850", VA = "0x186098650")]
	private void LPAGMOBEMFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6094360", Offset = "0x6093560", VA = "0x186094360")]
	private void EFMHKGDGIPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x60956B0", Offset = "0x60948B0", VA = "0x1860956B0")]
	private void GKMNANAPGEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6092600", Offset = "0x6091800", VA = "0x186092600")]
	private void BBOIKCIKCJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x60987E0", Offset = "0x60979E0", VA = "0x1860987E0")]
	private void MAPPDGIBBEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6094FE0", Offset = "0x60941E0", VA = "0x186094FE0")]
	private void GAMALMGHPLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x60975B0", Offset = "0x60967B0", VA = "0x1860975B0")]
	private void JDMMCBDGAFN(bool FPLDFFKPKHH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x60935D0", Offset = "0x60927D0", VA = "0x1860935D0")]
	private void CBEKANLKBDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6098FC0", Offset = "0x60981C0", VA = "0x186098FC0")]
	private void NANBBGHFKLC(bool FPLDFFKPKHH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6092800", Offset = "0x6091A00", VA = "0x186092800")]
	private void BGIGAKMIDBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6095060", Offset = "0x6094260", VA = "0x186095060")]
	private void GEGFDCJKELF(Material BCNAILKKOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6097920", Offset = "0x6096B20", VA = "0x186097920")]
	private void JLOGDCMELPJ(Material BCNAILKKOBI, Color DPEECIGHFMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6092690", Offset = "0x6091890", VA = "0x186092690")]
	private void BEGOJNDEAGO(Material BCNAILKKOBI, Color BMCFMJJIDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x60974C0", Offset = "0x60966C0", VA = "0x1860974C0")]
	private void JBBDGBILFJD(Material BCNAILKKOBI, Color DLLDKNALJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6098190", Offset = "0x6097390", VA = "0x186098190")]
	private void LEFAFKDPICO(Material BCNAILKKOBI, Texture2D AFMCPMEGELI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6097BE0", Offset = "0x6096DE0", VA = "0x186097BE0")]
	private void KIHPGCHALMB(Material BCNAILKKOBI, Texture LFGHLJFDDCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6092030", Offset = "0x6091230", VA = "0x186092030")]
	private void BAFIFFGLPMB(Action<FGEPINKCBOD> DOMOPOFCMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6094960", Offset = "0x6093B60", VA = "0x186094960")]
	private void FIAFMPNPIFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x60939A0", Offset = "0x6092BA0", VA = "0x1860939A0")]
	private void CNFLEHPHAJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6096BA0", Offset = "0x6095DA0", VA = "0x186096BA0")]
	private GJKGGCLGKLL HIPHKNGNDBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6097DE0", Offset = "0x6096FE0", VA = "0x186097DE0")]
	private void KPCJNABKMAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6098C30", Offset = "0x6097E30", VA = "0x186098C30")]
	public void MPMMAGNPDIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6097280", Offset = "0x6096480", VA = "0x186097280")]
	private void HKLLCGMNAFP(Vector3 MFDMLPFPBCO, Quaternion HMKNDOIICKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6092B40", Offset = "0x6091D40", VA = "0x186092B40")]
	private void BJFKEKMCEHP(List<HHPIPHPPHGD> MHJJMJKNJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x60966B0", Offset = "0x60958B0", VA = "0x1860966B0")]
	public void HHKGIJBCEOL(BONMPAHMNCG OMHHBDJNINE, bool INAEOCNFEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6096030", Offset = "0x6095230", VA = "0x186096030")]
	public void HHKGIJBCEOL(BONMPAHMNCG OMHHBDJNINE, AnchorParamsRestrictions INMMGGEIPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8B18A0", Offset = "0x8B0AA0", VA = "0x1808B18A0")]
	private static void BJDHINACHNH(FitMeshHemisphere BLCDBHEJLMO, Transform DKFNIEHCIAD, BONMPAHMNCG OMHHBDJNINE, AnchorParamsRestrictions CLNLLMGEKFK, [Out] Vector3 CMGCCDJMKGB, [Out] Quaternion MGHFLNIAHPI, [Out] BONMPAHMNCG GDCDGAHDAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x60937E0", Offset = "0x60929E0", VA = "0x1860937E0")]
	public void CJMBFMMLEKB(Vector2 JMNKLKAFLHB, Vector3 DGDAPHOILDA, Vector3 DENIFAFBDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6093460", Offset = "0x6092660", VA = "0x186093460")]
	private void CAEFDJKLJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6092780", Offset = "0x6091980", VA = "0x186092780")]
	private void BFIJEDKADGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6095790", Offset = "0x6094990", VA = "0x186095790")]
	[CompilerGenerated]
	private void GOOFBGECBIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6091F90", Offset = "0x6091190", VA = "0x186091F90")]
	[CompilerGenerated]
	private void AEGODBELMAJ(FGEPINKCBOD IACKGJCPIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x609D620", Offset = "0x609C820", VA = "0x18609D620")]
	[CompilerGenerated]
	private void PPMAJLNBCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6098630", Offset = "0x6097830", VA = "0x186098630")]
	[CompilerGenerated]
	private void LKODCPJMLCD(FGEPINKCBOD IACKGJCPIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6094F50", Offset = "0x6094150", VA = "0x186094F50")]
	[CompilerGenerated]
	private void FPCOMKDELBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6094940", Offset = "0x6093B40", VA = "0x186094940")]
	[CompilerGenerated]
	private void FGBAFIMHDAK(FGEPINKCBOD IACKGJCPIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x60972F0", Offset = "0x60964F0", VA = "0x1860972F0")]
	[CompilerGenerated]
	private void HNNLNKEAKHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6098930", Offset = "0x6097B30", VA = "0x186098930")]
	[CompilerGenerated]
	private void MBBNDBFNKPM(FGEPINKCBOD IACKGJCPIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6097380", Offset = "0x6096580", VA = "0x186097380")]
	[CompilerGenerated]
	private void IAPOGMCFOJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x609B0B0", Offset = "0x609A2B0", VA = "0x18609B0B0")]
	[CompilerGenerated]
	private void OBCDDOIKKHB(FGEPINKCBOD IACKGJCPIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x609B5C0", Offset = "0x609A7C0", VA = "0x18609B5C0")]
	[CompilerGenerated]
	private void ONHLDCPAEIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6097410", Offset = "0x6096610", VA = "0x186097410")]
	[CompilerGenerated]
	private void IFDJLNGIJPE(FGEPINKCBOD IACKGJCPIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x60948B0", Offset = "0x6093AB0", VA = "0x1860948B0")]
	[CompilerGenerated]
	private void EJCJPPEIGHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6095680", Offset = "0x6094880", VA = "0x186095680")]
	[CompilerGenerated]
	private void GINKDMDEAHG(FGEPINKCBOD IACKGJCPIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6097A10", Offset = "0x6096C10", VA = "0x186097A10")]
	[CompilerGenerated]
	private void KDAGPNHHKIN(KeyValuePair<string, IKCNFNMPLNN<Texture2D>> JMPHEPIPJAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6097710", Offset = "0x6096910", VA = "0x186097710")]
	[CompilerGenerated]
	private void JIMBJCNNKFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6094140", Offset = "0x6093340", VA = "0x186094140")]
	[CompilerGenerated]
	private void DOKMFPNDNFC(FGEPINKCBOD IACKGJCPIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x60942D0", Offset = "0x60934D0", VA = "0x1860942D0")]
	[CompilerGenerated]
	private void EBKFBEAGDON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6094F20", Offset = "0x6094120", VA = "0x186094F20")]
	[CompilerGenerated]
	private void FNAEMJBICPN(FGEPINKCBOD IACKGJCPIOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class LIKLDOOMCKF : HFDBPGFHIMN
{
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly int KGNLEAOJPJK;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly int HBKPMLGCGCJ;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly int IFDBBMNKCCP;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private static readonly int NOOJKFGKFPE;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static readonly int DACPDIGNCHD;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly int CDMACEKOOJN;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly int FLBPIBJPMON;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly int EJADCPPOCAA;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly int JIMJNFJHBEO;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly int CPKFONBJALB;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly int IHPAALHHMKA;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int AOHJDKJODAK;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int NMOBMFAJJHJ;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly int DKEMIDKAGFG;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly int DGPPGKFAPEA;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int KOAIILLFGAG;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int PHPHCGJGIAP;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int GJBIIDCLNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private Transform LIKFDIHLPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private Transform JDNCLPHIEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private Transform IAHNGHCDEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private Transform HGBOJKCIJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private Transform FGGKPMOLPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private Transform KEJDJLLAEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private Transform GHMODEIDHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private BLMPBINFFNA BCDCIGPLGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private MaterialPropertyBlock FAMNJBHHLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private SkinnedMeshRenderer[] NGEODBJJKAM;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private MaterialPropertyBlock DKGGOHFGLNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x60A08A0", Offset = "0x609FAA0", VA = "0x1860A08A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x609F6A0", Offset = "0x609E8A0", VA = "0x18609F6A0", Slot = "6")]
	public void GEJAFFIMNGM(BLMPBINFFNA KGGOEHJMBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x609F760", Offset = "0x609E960", VA = "0x18609F760", Slot = "7")]
	public void HCGONJIMNEC(GOJNOAGJEDK NMMDDNBHBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x60A0A00", Offset = "0x609FC00", VA = "0x1860A0A00", Slot = "4")]
	public void OMGAEEIEIBN(OOEDLNLPEFH BPFANGGEJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x609F640", Offset = "0x609E840", VA = "0x18609F640")]
	private Vector2 FICBPCDJKEB(Vector2 GLBPBBCENEC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x609F790", Offset = "0x609E990", VA = "0x18609F790", Slot = "5")]
	public void IFBEEJLIAAC(FAHKNHJMFDN NMMDDNBHBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x609F300", Offset = "0x609E500", VA = "0x18609F300")]
	private void FEEIGGPAIEH(FAHKNHJMFDN DANLNDJNOOH, BNMJAJFCHDM IOJNAMLLAMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x60A0920", Offset = "0x609FB20", VA = "0x1860A0920")]
	private void KPHMLABDNJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x60A1110", Offset = "0x60A0310", VA = "0x1860A1110")]
	public LIKLDOOMCKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x609F230", Offset = "0x609E430", VA = "0x18609F230")]
	[CompilerGenerated]
	internal static (float, float) DCPIDDFCKDH(float DJGOJOMJNNF)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x609F2C0", Offset = "0x609E4C0", VA = "0x18609F2C0")]
	[CompilerGenerated]
	internal static Vector4 EILEEGMOKEN(Vector2 DHMMMGDKPCG, Vector2 EKCHLHLGOBO)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class FGEPINKCBOD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private MaterialPropertyBlock PPKKFJGHMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public Color? OFNMDAFJPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public Color? PPBIMOMGPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public Color? JOILEJOFOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public Color? EJFDFNKOEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public Color NFAKKAIOLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public Color ELPFJIELODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public Color NAINLCOJNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public Texture2D GFDOLDNGBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public Texture2D BIPNDMFMPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private Dictionary<GLINILPMODE, int> IKNJAEJEMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private LCOJHOLPOJB[] IAJJNDNFDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private BDOCOBBFHFE[] OIGFDCPLBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public Vector4[] LDINCDMLKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public Vector4[] ELJIGHCJDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public Vector4[] GFMOCMMNNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public Vector4[] DIPBMAIDLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public Vector4[] AOFCIJGLABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public Vector4[] HOHHGKENBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private List<Texture2D> PFAGCIIOHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private Vector4[] KGFHIFMBALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private List<Texture2D> PKKPADOBLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private float[] JKOEGFPNJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private Vector4[] MGOCJGHIOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private float[] HFEHFOFPIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public float[] NPKNJGOKBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private List<Texture2D> KFDOBALJOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private float[] APMHAINCBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private List<Texture2D> NMGMPAAPJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private Vector4[] OHDGKDEMCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private float[] IOOHNNHHKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private Vector4[] DBMIJMPBEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public float[] JCFPABGPPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public Texture2DArray HFLGFCKPPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public Texture2DArray MELBIKGKHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public Texture2DArray EFNOBILANIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public Texture2DArray KOOACKEFJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private bool HCDBKIBDOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int HMMABIOBNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private Vector2? AEKFKGDKLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private TextureFormat LAPFFIOANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private Vector2? OFJAENAHILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private TextureFormat ONLOOBCNAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private Vector2? AFCJBKNAPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private TextureFormat PHKCLGGAKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private Vector2? EKCPADPJJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private TextureFormat GHDHOMBEAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private bool HBNMNOFGLDE;

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static int NNNFBLOBKOP;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static int HLPHCGEBNPB;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static int EDFGBMILIOD;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static int JMNHCFBOJAN;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static int DNOEEBKLBPP;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static int LOLGMIOGNDA;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static int EGAECOMGPNN;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static int OOKFIDNJINC;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static int JIEGDOCCDMF;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static int NCLMNDIIEFB;

	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private static int NGNCKCMIMLA;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private static int PAJBAHBJJAF;

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private static int KOIFPFAFEEM;

	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private static int GOCAMMEBOIE;

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private static int KLCNKOAJKNI;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private static int JILPENFEBAL;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static int EBANPHJLIJB;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static int GMPBOMGPFEP;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private static int LMNGONPIPAM;

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static int OFCKAEFAJNI;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x60A9610", Offset = "0x60A8810", VA = "0x1860A9610")]
	private FGEPINKCBOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x60A9B00", Offset = "0x60A8D00", VA = "0x1860A9B00")]
	public FGEPINKCBOD(Color NLFCLKCGIML, Color HDBAMCHOPPH, Color FPLEKBHNLHM, Color? NBFLJBGOJBG, Color? PBMIAEFIJCH, Color? BBELMEJEEPK, Texture2D FAEDGBMGNKI, Texture2D ENGJLJNBPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x60A80B0", Offset = "0x60A72B0", VA = "0x1860A80B0")]
	internal int EBAAFABHCBN(Material DECLJBEFNAD, LCOJHOLPOJB ODEFHMLHEMA, BDOCOBBFHFE HNGJGBNGCII, BKAHNFPJFDO IHALIDJJKLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x60A8020", Offset = "0x60A7220", VA = "0x1860A8020")]
	private int EBAAFABHCBN(GLINILPMODE GOBGGNLGONA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x60A7360", Offset = "0x60A6560", VA = "0x1860A7360")]
	internal int CAMDHEHHJIA(Material DECLJBEFNAD, Color DLLDKNALJID, Color DPEECIGHFMO, Color BMCFMJJIDFC, Color ILEACOHALKB, Color AMAAMILNPOF, Texture2D JKNEFJAJNHA, Vector4 DHBBFLDIBDG, Texture2D FHFNIDIJAKD, Vector4 DPKBIBOKAPB, float IPCFBBJNKCC, float JAJMKEIJCNI, Texture2D JONHNNEJNIE, Vector4 EADPNJFLFMC, float LOPNHHPFOIN, Texture2D NCBBGKCBOEL, Color JCBMNBHOAOO, Vector4 LFNJIGAKKAC, LCOJHOLPOJB ODEFHMLHEMA, BDOCOBBFHFE HNGJGBNGCII, BKAHNFPJFDO IHALIDJJKLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x60A83F0", Offset = "0x60A75F0", VA = "0x1860A83F0")]
	private void LPKEDHMMBOA(List<Texture2D> PFAGCIIOHNA, [Out] Texture2DArray INHALFAJMKA, [Out] Texture2DArray GOEGNEAGFCM, [Out] Texture2DArray CBOMPODEKOG, [Out] Texture2DArray KCCBFBAEBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x60A82A0", Offset = "0x60A74A0", VA = "0x1860A82A0")]
	public void GECKGHNHMIG(Shader MEHHIENIKJE, Renderer CPHKADKGBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x60A85B0", Offset = "0x60A77B0", VA = "0x1860A85B0")]
	private void OPFKJNAMICD(Shader MEHHIENIKJE, Renderer CPHKADKGBCP, int HCNLEKBGLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x60A7160", Offset = "0x60A6360", VA = "0x1860A7160")]
	private Color BHJMAGHDGFJ(Color HNBOPDFHKEN, LCOJHOLPOJB BFMACMPMLPD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x60A7010", Offset = "0x60A6210", VA = "0x1860A7010")]
	private Color AJIFBMGDNGO(Color MINDGOIONFF, LCOJHOLPOJB BFMACMPMLPD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x60A81A0", Offset = "0x60A73A0", VA = "0x1860A81A0")]
	private bool EPCFBHHPGMO(Texture2D AOAJBHDINDI, BDOCOBBFHFE LHMDOGCBFFL, [Out] Texture2D IIDKNHCHLAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x60A7F30", Offset = "0x60A7130", VA = "0x1860A7F30")]
	private void DNHDIOHPJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x60A7FE0", Offset = "0x60A71E0", VA = "0x1860A7FE0", Slot = "4")]
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
		private PMMOMIOFJDG? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public HNNJKOJEHLP CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x60A4B40", Offset = "0x60A3D40", VA = "0x1860A4B40")]
			get
			{
				return default(HNNJKOJEHLP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public PMMOMIOFJDG MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x60A4B90", Offset = "0x60A3D90", VA = "0x1860A4B90")]
			get
			{
				return default(PMMOMIOFJDG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7B8CC0", Offset = "0x7B7EC0", VA = "0x1807B8CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7C10A0", Offset = "0x7C02A0", VA = "0x1807C10A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x60A49A0", Offset = "0x60A3BA0", VA = "0x1860A49A0")]
		public Material[] NBDMIMKGHGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x60A47E0", Offset = "0x60A39E0", VA = "0x1860A47E0")]
		public static void GDMJONLBCDM(AvatarItemMaterial LMKOCONPPKA, Material PEGNOKKFPLO, int CODKAKNBBMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x60A4A80", Offset = "0x60A3C80", VA = "0x1860A4A80")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[PJKEGBNMNOG]
public struct BPDOJNHFJNE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	[ReadOnly]
	public JGOLNAPDOFF EGDEIKLHFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	[ReadOnly]
	public int DCLMGDOHMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public AKEPPDLGLKA BKECJHELENO;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x60A4C50", Offset = "0x60A3E50", VA = "0x1860A4C50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[NativeContainer]
[PJKEGBNMNOG]
public struct AKEPPDLGLKA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public NativeArray<Vector3> ECJJNHLGDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public NativeArray<Vector3> CNBJMFKBOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public NativeArray<Vector4> FLEAMMBNHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public NativeArray<Vector2> LLAIBEIHBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public NativeArray<Vector2> AAEDJOOKGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public NativeArray<Vector2> BJEPBCANNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public NativeArray<Vector2> IONFOGOELPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public NativeArray<Color> AJONDOLJEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public NativeArray<int> FGKAIIANFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public NativeArray<int> LBMHGFDNFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private NativeArray<int> NLDLCKLCGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private NativeArray<int> IIJIHIDCBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public NativeArray<int> HAJADIIJIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public NativeArray<int> HBEPPHFJLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeArray<int> OAOPPFPMAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<BoneWeight> CMLHHMHJLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private NativeArray<int> HELLICJGLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private bool CMAGAPGCJGF;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int DELPPFEEMLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x60A40F0", Offset = "0x60A32F0", VA = "0x1860A40F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x60A3B30", Offset = "0x60A2D30", VA = "0x1860A3B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int GHKCOLBMEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x60A3980", Offset = "0x60A2B80", VA = "0x1860A3980")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x60A3D90", Offset = "0x60A2F90", VA = "0x1860A3D90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int ABJGBHFMHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x60A4100", Offset = "0x60A3300", VA = "0x1860A4100")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x60A3D80", Offset = "0x60A2F80", VA = "0x1860A3D80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x60A43A0", Offset = "0x60A35A0", VA = "0x1860A43A0")]
	public AKEPPDLGLKA(int HDKNFOBLGHM, int GGCPFDGBHPE, int CINCJFABGGI, int EKLGOFDACHM, Allocator ILEAEEDKNCF, int DICNNKMLDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x60A41C0", Offset = "0x60A33C0", VA = "0x1860A41C0")]
	public void MBKBPEGMEII(int HMFNCGHECPG, Vector3 IFBNMJJOJMJ, Vector3 MJNCNGDNKAB, Vector4 MOAGOANMCEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x60A3990", Offset = "0x60A2B90", VA = "0x1860A3990")]
	public void AFKDCPNLOEJ(int HMFNCGHECPG, BoneWeight JADDFAIGMKK, NativeSlice<byte> EDDLPNHNAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x60A3B40", Offset = "0x60A2D40", VA = "0x1860A3B40")]
	public Color CCBPJIDGLKG(int HMFNCGHECPG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x60A3D60", Offset = "0x60A2F60", VA = "0x1860A3D60")]
	public void EINCEAMIDJH(int HMFNCGHECPG, Color MOAAELBABJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x60A3B60", Offset = "0x60A2D60", VA = "0x1860A3B60")]
	public void CFDOPLGCFOB(byte KCIHAABCANA, int HMFNCGHECPG, Vector2 EGCBKGMHAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x60A4300", Offset = "0x60A3500", VA = "0x1860A4300")]
	public void OKGFJNCIELP(int HMFNCGHECPG, int ALOGNOJFJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x60A3950", Offset = "0x60A2B50", VA = "0x1860A3950")]
	public bool AAPKIOBOMOL(int KCIHAABCANA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x60A4230", Offset = "0x60A3430", VA = "0x1860A4230")]
	public void NPGDJFDMOPN(int LGKAHANLLCD, int BJPGLMJPACN, int HHOELNLHIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x60A4110", Offset = "0x60A3310", VA = "0x1860A4110")]
	public int[] JMMOCCKIFFG(int LGKAHANLLCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x60A4310", Offset = "0x60A3510", VA = "0x1860A4310")]
	private NativeSlice<int> PGMCHEJPCEG(int LGKAHANLLCD)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x60A3BB0", Offset = "0x60A2DB0", VA = "0x1860A3BB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x60A3DA0", Offset = "0x60A2FA0", VA = "0x1860A3DA0")]
	public Mesh INABOLBPEEJ([Optional] string NJAAPLJCOHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[NativeContainer]
[DefaultMember("Item")]
[PJKEGBNMNOG]
public struct JGOLNAPDOFF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeArray<Vector3> ECJJNHLGDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public NativeArray<Vector3> CNBJMFKBOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<Vector4> FLEAMMBNHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeArray<Vector2> LLAIBEIHBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeArray<Vector2> AAEDJOOKGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public NativeArray<Vector2> BJEPBCANNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public NativeArray<Vector2> IONFOGOELPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public NativeArray<Color> AJONDOLJEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public NativeArray<int> DIKIOBCFLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public NativeArray<int> JBKAMNBMOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<int> INEMEPMFHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public NativeArray<int> POPMGDMDMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<bool> DEICFKLFMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public NativeArray<int> GGKEOKACKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public NativeArray<int> HFOHBBFKIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeArray<BoneWeight> CMDBOGAHALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private NativeArray<Matrix4x4> JFODEHBFNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private NativeArray<int> AHBHJEPAPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private NativeArray<byte> FAHJDDGHDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private NativeArray<int> JICDJCGNLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private NativeArray<int> GDLDOCHNCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<sbyte> NINOFPGFOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<byte> GNDKMCAOOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private NativeArray<int> DEGLAKCLJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private bool CMAGAPGCJGF;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int EIEIECFEAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int BDCFCKIEAFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xEB46B0", Offset = "0xEB38B0", VA = "0x180EB46B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int HICEPCIICNI
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x60AB790", Offset = "0x60AA990", VA = "0x1860AB790")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int MCINKFPOMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x60AAEB0", Offset = "0x60AA0B0", VA = "0x1860AAEB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x60AB780", Offset = "0x60AA980", VA = "0x1860AB780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int DELPPFEEMLC
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x60AB760", Offset = "0x60AA960", VA = "0x1860AB760")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x60AAEA0", Offset = "0x60AA0A0", VA = "0x1860AAEA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int BBOHBFGCPPP
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x60AB740", Offset = "0x60AA940", VA = "0x1860AB740")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x60AB750", Offset = "0x60AA950", VA = "0x1860AB750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public MKGMNCBPOEP HOEOGIIEOHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x60AB210", Offset = "0x60AA410", VA = "0x1860AB210")]
		get
		{
			return default(MKGMNCBPOEP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x60AB770", Offset = "0x60AA970", VA = "0x1860AB770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public byte JHLMKBLDHFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x60AAED0", Offset = "0x60AA0D0", VA = "0x1860AAED0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x60AAEC0", Offset = "0x60AA0C0", VA = "0x1860AAEC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DAHBLHEFHNH HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x60AB220", Offset = "0x60AA420", VA = "0x1860AB220")]
		get
		{
			return default(DAHBLHEFHNH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x60AB7C0", Offset = "0x60AA9C0", VA = "0x1860AB7C0")]
	public JGOLNAPDOFF(IList<Mesh> HLGNPGKNFFF, IList<Matrix4x4> LIFMHAFCEKM, IList<bool> DEICFKLFMGP, byte CMEHKENFPEG, IList<byte[]> NCAAHONPNPC, IList<int> BEFPKIGJLDA, IList<bool> FBCPLHFEAOL, IList<int> GGKEOKACKKJ, IList<int> NGOCKNHIEHL, IList<int> EENODAHPBCA, Allocator ILEAEEDKNCF, MKGMNCBPOEP DEKCPCOPHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x60AB140", Offset = "0x60AA340", VA = "0x1860AB140")]
	public AKEPPDLGLKA EEABEHGJFLA(Allocator ILEAEEDKNCF)
	{
		return default(AKEPPDLGLKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x60AAEE0", Offset = "0x60AA0E0", VA = "0x1860AAEE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[PJKEGBNMNOG]
public class HJMODJBOPAP : LBINCIGDOIA
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x60AADB0", Offset = "0x60A9FB0", VA = "0x1860AADB0")]
	public JGOLNAPDOFF IALGFDFONBH()
	{
		return default(JGOLNAPDOFF);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x608CA20", Offset = "0x608BC20", VA = "0x18608CA20")]
	public HJMODJBOPAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct DAHBLHEFHNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public NativeSlice<Vector3> ECJJNHLGDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public NativeSlice<Vector3> CNBJMFKBOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeSlice<Vector4> FLEAMMBNHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeSlice<Vector2> LLAIBEIHBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeSlice<Vector2> AAEDJOOKGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeSlice<Vector2> BJEPBCANNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeSlice<Vector2> IONFOGOELPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public NativeSlice<Color> AJONDOLJEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeSlice<int> LBOEPLJJHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeSlice<int> POPMGDMDMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeSlice<BoneWeight> CMDBOGAHALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeSlice<byte> CONENGKNOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public int BMGFHHEIEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public Matrix4x4 DCLBJBKIONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public int FBFBGKFDGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeSlice<byte> EDDLPNHNAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public bool EHIDBPDMCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int DKICHPEEBOC;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal readonly struct GLINILPMODE : IEquatable<GLINILPMODE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	internal readonly Material OHGAACDKLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	internal readonly LCOJHOLPOJB MJMEHKLKNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	internal readonly BDOCOBBFHFE DBMNOCBPLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	internal readonly BKAHNFPJFDO GJLIEPKKOAN;

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x8D1710", Offset = "0x8D0910", VA = "0x1808D1710")]
	public GLINILPMODE(Material PEGNOKKFPLO, LCOJHOLPOJB ODEFHMLHEMA, BDOCOBBFHFE HNGJGBNGCII, BKAHNFPJFDO IHALIDJJKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x60AAB90", Offset = "0x60A9D90", VA = "0x1860AAB90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x8D12F0", Offset = "0x8D04F0", VA = "0x1808D12F0", Slot = "4")]
	public bool Equals(GLINILPMODE NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x60AAA10", Offset = "0x60A9C10", VA = "0x1860AAA10", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x60AAAF0", Offset = "0x60A9CF0", VA = "0x1860AAAF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class OPEDOKHAEBE
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class CKBMIGBNMOB : IEnumerator<JGIJKBAPGME>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private JGIJKBAPGME <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private JGIJKBAPGME System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7B7470", Offset = "0x7B6670", VA = "0x1807B7470")]
		[DebuggerHidden]
		public CKBMIGBNMOB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8D2BF0", Offset = "0x8D1DF0", VA = "0x1808D2BF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x60A5B60", Offset = "0x60A4D60", VA = "0x1860A5B60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
	public static void LJJFHHEGHIK(string JNIKIHKLGAD, int DKNFDKCGOLD, long MBELFGDLMOA, long EGANFDDMHGF, long IHHOEFKGLBF, long GMBJBNEIENF, long ADHDNBPNGGA, long HNPDPCPLCNN, long AGFEAPLKDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x60AD8B0", Offset = "0x60ACAB0", VA = "0x1860AD8B0")]
	public static HDONKFMMCKJ GCIPNFAHAFH(JobHandle MHMABLOIKGH, bool MEDABKCOKCF, bool EFDBNMLMBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x60ADA00", Offset = "0x60ACC00", VA = "0x1860ADA00")]
	[IteratorStateMachine(typeof(CKBMIGBNMOB))]
	private static IEnumerator<JGIJKBAPGME> GMAELJJBGLJ(JobHandle EIKDEMMADOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class NMMGBHKHPAE : GAJDIDMKDHM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private PJGLFMMBPJM BCEBDJLEAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private FGFCIBBLGMC GKAGGKELFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private IRecRoomQualityConfigProvider BDOCIPNPMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private bool CMAGAPGCJGF;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x60AD610", Offset = "0x60AC810", VA = "0x1860AD610")]
	[KEFCCLBEAOJ(CMEECPGEPNF.GameOnly)]
	private static void FNBGPOLFIGO(LEHDPNIFNIH BFOBHJGOFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x541F260", Offset = "0x541E460", VA = "0x18541F260")]
	[UnityEngine.Scripting.Preserve]
	public NMMGBHKHPAE([GAGPBLHNPNO(null)] FGFCIBBLGMC LJFMKIIOAOL, [GAGPBLHNPNO(null)] PJGLFMMBPJM AGJAEDMPJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x60AD710", Offset = "0x60AC910", VA = "0x1860AD710")]
	private void HNKDHBCFCBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x60AD5B0", Offset = "0x60AC7B0", VA = "0x1860AD5B0", Slot = "4")]
	public void CCGBMLFJJKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x60AD100", Offset = "0x60AC300", VA = "0x1860AD100", Slot = "5")]
	public IKCNFNMPLNN<Texture2D> BDDGBOMMKAC(IGIDDLBKHDO GAEMEDNCFOK, [Optional] FDEEEEBPKBB HELLICJGLED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x60AD780", Offset = "0x60AC980", VA = "0x1860AD780")]
	private uint OODOKCAJLLC(IGIDDLBKHDO GAEMEDNCFOK, FDEEEEBPKBB HELLICJGLED)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface IFIONJNFGEO
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OJCBJDHMBMB(Mesh PGNOHIOKGKO, Matrix4x4 PFGNNCAGNIH, byte[] EDDLPNHNAJK, bool HHGHHMOEKDG = false, JHJCKMOKKIL.JDLFGAOPFIH NHJFGKEFEDI = (JHJCKMOKKIL.JDLFGAOPFIH)0, int GGKEOKACKKJ = -1, bool DEICFKLFMGP = false);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BPMGJCEGHAC(Allocator ILEAEEDKNCF, MKGMNCBPOEP DEKCPCOPHCP, byte CMEHKENFPEG, [Optional] IList<int> NGOCKNHIEHL, [Optional] IList<int> PKCFGIKAFFD);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct AIGHBMAONEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly GameObject CEFHHCEGCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private readonly AvatarItemMaterial LOPIMJOIKDA;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x947190", Offset = "0x946390", VA = "0x180947190")]
	public AIGHBMAONEB(GameObject CEFHHCEGCPL, AvatarItemMaterial LOPIMJOIKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x60A3740", Offset = "0x60A2940", VA = "0x1860A3740")]
	public void GOJPDPGLMHK(Material PEGNOKKFPLO, int CODKAKNBBMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class AHLINDIOMEG : HCOGJJELLOG<Task<(GameObject, AvatarItemMaterial)>, AIGHBMAONEB>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct FNANFOFDLDA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x60A9BC0", Offset = "0x60A8DC0", VA = "0x1860A9BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x60AA0C0", Offset = "0x60A92C0", VA = "0x1860AA0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private IKCNFNMPLNN<GameObject> OIPAGEMENAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private IKCNFNMPLNN<AvatarItemMaterial> DCMHJIOEOHH;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x60A36B0", Offset = "0x60A28B0", VA = "0x1860A36B0")]
	private AHLINDIOMEG(Task<(GameObject, AvatarItemMaterial)> OCAKELEHPCL, IKCNFNMPLNN<GameObject> BMBJBOIGOBM, IKCNFNMPLNN<AvatarItemMaterial> KINIPJPELLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x60A32A0", Offset = "0x60A24A0", VA = "0x1860A32A0")]
	public static AHLINDIOMEG LAFNMEJJDLL(AssetReference IGALNCJIDGH, [Optional] AssetReference NEONLMIFIIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x60A3050", Offset = "0x60A2250", VA = "0x1860A3050", Slot = "11")]
	protected override AIGHBMAONEB GJIKPBACMGO(Task<(GameObject, AvatarItemMaterial)> ICLINGFAPBK)
	{
		return default(AIGHBMAONEB);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x60A3220", Offset = "0x60A2420", VA = "0x1860A3220", Slot = "12")]
	protected override void IOMPALJAJPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x60A30F0", Offset = "0x60A22F0", VA = "0x1860A30F0")]
	[AsyncStateMachine(typeof(FNANFOFDLDA))]
	private static Task<(GameObject, AvatarItemMaterial)> GNLCIEBDNCI(Task<GameObject> OHBEOMKGDKJ, Task<AvatarItemMaterial> OCMMCJFELGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class EEPNFGLIEHH : HCOGJJELLOG<Task<(Material, MaterialMapAsset)>, Material>
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class CLNHHKDNCJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public Material mat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public MaterialEntry entry;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public CLNHHKDNCJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x60A5BB0", Offset = "0x60A4DB0", VA = "0x1860A5BB0")]
		internal object GGAEOKKKKLD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class DPEGECMEBEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public string shaderNameToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public CLNHHKDNCJL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public DPEGECMEBEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x60A6220", Offset = "0x60A5420", VA = "0x1860A6220")]
		internal object JFJAIHIDMCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x60A5FD0", Offset = "0x60A51D0", VA = "0x1860A5FD0")]
		internal object CEHAKFFFAMA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct KHAHEFPKLPK<T1, T2> : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x3C92B70", Offset = "0x3C91D70", VA = "0x183C92B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3C931E0", Offset = "0x3C923E0", VA = "0x183C931E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly JJNHGMIGPBK OMJOPGOBIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private IKCNFNMPLNN<Material> NBNJNMOFHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private IKCNFNMPLNN<MaterialMapAsset> CKLPGBFHBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private bool NPEKBPCCEAA;

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x60A6CC0", Offset = "0x60A5EC0", VA = "0x1860A6CC0")]
	public static EEPNFGLIEHH NJMNMBLDPGL(AssetReference LKICAPBLHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x60A66B0", Offset = "0x60A58B0", VA = "0x1860A66B0")]
	private static IKCNFNMPLNN<MaterialMapAsset> JKIKNFJPFHL(AssetReference LKICAPBLHJM, [Out] bool NPEKBPCCEAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x60A6F80", Offset = "0x60A6180", VA = "0x1860A6F80")]
	private EEPNFGLIEHH(Task<(Material, MaterialMapAsset)> OCAKELEHPCL, IKCNFNMPLNN<Material> NBNJNMOFHEI, IKCNFNMPLNN<MaterialMapAsset> JMJBJFGBEDE, bool NPEKBPCCEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x60A6470", Offset = "0x60A5670", VA = "0x1860A6470", Slot = "11")]
	protected override Material GJIKPBACMGO(Task<(Material, MaterialMapAsset)> ICLINGFAPBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x60A68F0", Offset = "0x60A5AF0", VA = "0x1860A68F0")]
	private void NCKNCLGGLEM(Material ODOPCMMDNBA, MaterialMapAsset MMIHEHFLHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x60A6650", Offset = "0x60A5850", VA = "0x1860A6650", Slot = "12")]
	protected override void IOMPALJAJPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x277A130", Offset = "0x2779330", VA = "0x18277A130")]
	[AsyncStateMachine(typeof(KHAHEFPKLPK<, >))]
	private static Task<(T1, T2)> ANFAHIGAAME<T1, T2>(Task<T1> FGPLCIAAMLF, Task<T2> NOENFMBMIHI)
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
		[MGMFHFICAPM(OILHINDHMGI.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x60ADA70", Offset = "0x60ACC70", VA = "0x1860ADA70")]
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
		private struct DKAAMKLODKK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			public AsyncTaskMethodBuilder<CKFIBOLKANF> <>t__builder;

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
			private TaskAwaiter<CKFIBOLKANF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x60A5C20", Offset = "0x60A4E20", VA = "0x1860A5C20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x60A5F60", Offset = "0x60A5160", VA = "0x1860A5F60", Slot = "5")]
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
		private Dictionary<LDNHAIONBAK, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private Dictionary<LDNHAIONBAK, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private Dictionary<LDNHAIONBAK, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private Dictionary<LDNHAIONBAK, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private readonly Dictionary<LDNHAIONBAK, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private CKFIBOLKANF _defaultFaceStyle;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x60AA9E0", Offset = "0x60A9BE0", VA = "0x1860AA9E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x60AA6E0", Offset = "0x60A98E0", VA = "0x1860AA6E0")]
		public CKFIBOLKANF JFELLICGCMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x60AA5B0", Offset = "0x60A97B0", VA = "0x1860AA5B0")]
		[AsyncStateMachine(typeof(DKAAMKLODKK))]
		public Task<CKFIBOLKANF> IDOCAEOIIEM(int EINPCNMMKGA, int ANHHKLJOHFC, int EEBGOBFKICL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x60AA8B0", Offset = "0x60A9AB0", VA = "0x1860AA8B0")]
		public NoseFaceOption OKKNHOEFAMH(int IDOCDFMPLCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x60AA730", Offset = "0x60A9930", VA = "0x1860AA730")]
		public SelectableFaceOption MJHFPDBALGM(FaceFeatureType KEEAPPBIDMI, LDNHAIONBAK CIKCPMPOCIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x60AA130", Offset = "0x60A9330", VA = "0x1860AA130")]
		public int AKGLBMCAEMK(LDNHAIONBAK CIKCPMPOCIH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x60AA1B0", Offset = "0x60A93B0", VA = "0x1860AA1B0")]
		private void BNJBFDAHGBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x28D3100", Offset = "0x28D2300", VA = "0x1828D3100")]
		private void LOMGICCKKAG<T>(IDictionary<LDNHAIONBAK, T> FOGKLDABGBI, IReadOnlyList<T> GNEAJNBBAAD) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x60AA3E0", Offset = "0x60A95E0", VA = "0x1860AA3E0")]
		public LDNHAIONBAK CNNEJIEIDIH(FaceFeatureType KEEAPPBIDMI)
		{
			return default(LDNHAIONBAK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x60AA490", Offset = "0x60A9690", VA = "0x1860AA490")]
		public LDNHAIONBAK HEIEFIFLNLH(FaceFeatureType KEEAPPBIDMI)
		{
			return default(LDNHAIONBAK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x60AA950", Offset = "0x60A9B50", VA = "0x1860AA950")]
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
