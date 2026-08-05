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
using RecRoom.Attributes;
using RecRoom.Avatars;
using RecRoom.Avatars.Data.Shared;
using RecRoom.Avatars.Face;
using RecRoom.Core.Studio;
using RecRoom.Logging.Attributes;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_AvatarRenderingSystems_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : FOFAFNFGNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x707DA50", Offset = "0x707CC50", VA = "0x18707DA50", Slot = "4")]
		public override void JMFBCAGPLCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
			[Cpp2IlInjected.Address(RVA = "0x8FD8F0", Offset = "0x8FCAF0", VA = "0x1808FD8F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7080B80", Offset = "0x707FD80", VA = "0x187080B80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7080AA0", Offset = "0x707FCA0", VA = "0x187080AA0", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7080B40", Offset = "0x707FD40", VA = "0x187080B40")]
		public RecNetCDNAssetReference(RecNetCDNKey OFPBICPHALF)
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
			[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8F5490", Offset = "0x8F4690", VA = "0x1808F5490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8F85D0", Offset = "0x8F77D0", VA = "0x1808F85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8F85C0", Offset = "0x8F77C0", VA = "0x1808F85C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7080BC0", Offset = "0x707FDC0", VA = "0x187080BC0")]
		public static RecNetCDNKey COPKKEGBGII(string LIHPCFGNCHJ, string HFIIEEINBAL = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6827920", Offset = "0x6826B20", VA = "0x186827920")]
		public void GPIFOEAKHNA(string BLMKABKGCMI, string IBBAMBJMMGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7080CC0", Offset = "0x707FEC0", VA = "0x187080CC0")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[KHFOLODBECL]
public class DLOIEMENJIO : NKNNPHKCMFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> DNNMLDFDALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> HEGGPCLJHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> LPBABOFHIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> PEOOBHMDNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> INNABKPIODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> DLHBAPJBBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> ACAENMGNPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator LDMILENMPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected COLMEPMMNCE PPDIMFMCDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte IOGLKLLHEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> JPONCANGBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> OHIEGDJBLNP;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7077C40", Offset = "0x7076E40", VA = "0x187077C40", Slot = "4")]
	public void KOOCCCMKEPE(Mesh NNPLONBDKAB, Matrix4x4 MNFGEOLNMJL, byte[] PHPIBOALCEJ, bool GDOCGOAKHDP = false, LJLGCMOEKHG.AMEKCHAHPFE LELKOOJMGPA = (LJLGCMOEKHG.AMEKCHAHPFE)0, int LCDOBPCHHDL = -1, bool ANAJPMBMBOM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x70779A0", Offset = "0x7076BA0", VA = "0x1870779A0", Slot = "5")]
	public void GHKBHIGCKCP(Allocator NNHCNMKJHLF, COLMEPMMNCE LMIMJAKOIJA, byte NFOOJFKLJBN, [Optional] IList<int> OGOILJBJGHM, [Optional] IList<int> ICIBNIDDFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x70779E0", Offset = "0x7076BE0", VA = "0x1870779E0")]
	private static void IILKKGNINMM(Mesh NNPLONBDKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7077E50", Offset = "0x7077050", VA = "0x187077E50")]
	public DLOIEMENJIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[KHFOLODBECL]
public struct JIKCMAPIPEO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public DNCKNLPFEBA NJAFHKJCPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int AHCJLKMLEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public MGGIOBOCMIF DNKBGIIMPGN;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7079840", Offset = "0x7078A40", VA = "0x187079840", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[KHFOLODBECL]
[NativeContainer]
public struct MGGIOBOCMIF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct MCJJOOJJOLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector3 FIKNBOEBHEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 LAOLFCMCDHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector4 HBNFPIEAGBH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct JHEGAPMFFMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float JHKIIKKDFLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float CCCKFKJLJCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float NMPKOCOCFCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float COEACLPLHJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte OOGODOIHKAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte KHMJHIGMBNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte OCJMMBDONGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte NPEHDAKLMMG;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct MOGOLLLNFGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half JHKIIKKDFLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half CCCKFKJLJCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half NMPKOCOCFCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half COEACLPLHJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte OOGODOIHKAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte KHMJHIGMBNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte OCJMMBDONGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte NPEHDAKLMMG;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct MGLFBKJNGPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 HCHFCFNLIAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 CLCKHCPMICH;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct OOIPKIDAFNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half4 HCHFCFNLIAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 CLCKHCPMICH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 AGMABCGDCFH;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct FEOPKJHHBFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 HCHFCFNLIAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 CLCKHCPMICH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 AGMABCGDCFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 EBDFOCCGFFM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct HKLNDPJDGEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half4 HCHFCFNLIAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 CLCKHCPMICH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 AGMABCGDCFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 EBDFOCCGFFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 JCOJFGBICKB;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct BPDPLJOJFIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float JHKIIKKDFLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float CCCKFKJLJCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float NMPKOCOCFCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float COEACLPLHJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int OOGODOIHKAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int KHMJHIGMBNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int OCJMMBDONGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int NPEHDAKLMMG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct PILOICNGPAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Color HCHFCFNLIAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 CLCKHCPMICH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct JPNJLGNPDOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color HCHFCFNLIAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 CLCKHCPMICH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 AGMABCGDCFH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct FNHPMPBLBDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color HCHFCFNLIAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 CLCKHCPMICH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 AGMABCGDCFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 EBDFOCCGFFM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct HJCGGLHOJND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color HCHFCFNLIAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 CLCKHCPMICH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 AGMABCGDCFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 EBDFOCCGFFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 JCOJFGBICKB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool LDBNAOOPIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<MCJJOOJJOLD> HACNEOBMEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<MGLFBKJNGPP> CJOAJIKKHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<OOIPKIDAFNB> JHGBGAAALPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<FEOPKJHHBFG> KNOCFNMBHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<HKLNDPJDGEC> HGMJFGBJILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<MOGOLLLNFGD> LNPMPKELFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<JHEGAPMFFMN> LOPLJNBCNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<PILOICNGPAC> IFIBNCNJJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<JPNJLGNPDOK> BCAKAOLMDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<FNHPMPBLBDN> HMFNPBFPEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<HJCGGLHOJND> OMAJNEKGPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<BPDPLJOJFIJ> NGKAONGOFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> GGKANJNAGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> DKGOILDKIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> KPEONALPPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> ADNPIGEDCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> JJOIAGADBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> IOALLPKJAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> KDJGFONDEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<BoneWeight> AGEDEOABNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> HLJPDMABNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool NLNPMKGKADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool HMFIONFEFOF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int OLCFDBOGJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x707F9F0", Offset = "0x707EBF0", VA = "0x18707F9F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x707F9D0", Offset = "0x707EBD0", VA = "0x18707F9D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HEGKKEDJJKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x707F100", Offset = "0x707E300", VA = "0x18707F100")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x707F1E0", Offset = "0x707E3E0", VA = "0x18707F1E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int MHLPGKGAJLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x707F9C0", Offset = "0x707EBC0", VA = "0x18707F9C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x707F9E0", Offset = "0x707EBE0", VA = "0x18707F9E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int GOHPINILHDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x707DAF0", Offset = "0x707CCF0", VA = "0x18707DAF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x707FE30", Offset = "0x707F030", VA = "0x18707FE30")]
	public MGGIOBOCMIF(int PBMFCMDIPBL, int BMAPFBDMOHE, int JJNNDPFCJLF, int PAHHHDGPCKL, Allocator NNHCNMKJHLF, int BEOIPFEKJOK, DKLPOJKPLHK KBIDLDHCNAI, bool NLNPMKGKADJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x707F580", Offset = "0x707E780", VA = "0x18707F580")]
	public void KKLHDKBHJAF(int CPLNODNGKGB, Vector3 PBNOOPEKDOL, Vector3 FOENIOOLJIF, Vector4 EBJDGDIMGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x707FA00", Offset = "0x707EC00", VA = "0x18707FA00")]
	public void PMPEDFKMHNP(int CPLNODNGKGB, BoneWeight NLCMNONPPCA, NativeSlice<byte> PHPIBOALCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x707F250", Offset = "0x707E450", VA = "0x18707F250")]
	public Color KAMPJACBDNN(int CPLNODNGKGB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x707ED00", Offset = "0x707DF00", VA = "0x18707ED00")]
	public void EGLFPHDEKBK(int CPLNODNGKGB, Color FDEJAKKFLHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x707F610", Offset = "0x707E810", VA = "0x18707F610")]
	public void NHEBPIBNIKM(byte FPHBEJNEAGJ, int CPLNODNGKGB, Vector2 NBEEEOFHJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x707DAE0", Offset = "0x707CCE0", VA = "0x18707DAE0")]
	public void ALINGIHNMNK(int CPLNODNGKGB, int KNPEFKLBIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x707F1F0", Offset = "0x707E3F0", VA = "0x18707F1F0")]
	public bool JNNFIAHEHID(int FPHBEJNEAGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x707F110", Offset = "0x707E310", VA = "0x18707F110")]
	public void HOGLGCHCMPI(int IHINCCLMOND, int KLICPJBJAIA, int BJJBELCKPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x707DB60", Offset = "0x707CD60", VA = "0x18707DB60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x707DDC0", Offset = "0x707CFC0", VA = "0x18707DDC0")]
	public Mesh EFAHIMABHMG([Optional] string OEKPLKDEJFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
[KHFOLODBECL]
[NativeContainer]
public struct DNCKNLPFEBA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Mesh.MeshDataArray IPDFIIJIKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<int> CPFDKGCKJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> PFIMIJAHHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<BoneWeight> AGEDEOABNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<Matrix4x4> BCLBHJLNLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> GBIDEEOGMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<byte> EGGIKIDKBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> BFCLFKNOFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> AOBPDOCNCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeArray<sbyte> MBEFBPLEBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<byte> FDLONPFCHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<bool> ANAJPMBMBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<int> LCDOBPCHHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool NLNPMKGKADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<int> JCCLMMBNDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool HMFIONFEFOF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int FJHPBEJHOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x70782D0", Offset = "0x70774D0", VA = "0x1870782D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int CBJBAGLEFBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7078660", Offset = "0x7077860", VA = "0x187078660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int OJACJLLDCJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7078080", Offset = "0x7077280", VA = "0x187078080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int MGLGEOOHNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x70782C0", Offset = "0x70774C0", VA = "0x1870782C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x70782E0", Offset = "0x70774E0", VA = "0x1870782E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int OLCFDBOGJPN
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7078680", Offset = "0x7077880", VA = "0x187078680")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7078670", Offset = "0x7077870", VA = "0x187078670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int MFOBOJNGEKM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7078650", Offset = "0x7077850", VA = "0x187078650")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x70782F0", Offset = "0x70774F0", VA = "0x1870782F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public COLMEPMMNCE NCGNJLHFLMO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7078640", Offset = "0x7077840", VA = "0x187078640")]
		get
		{
			return default(COLMEPMMNCE);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7078690", Offset = "0x7077890", VA = "0x187078690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte GJJCKHOPKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7078550", Offset = "0x7077750", VA = "0x187078550")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7078560", Offset = "0x7077760", VA = "0x187078560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public BIAODIIIGGC FJMFIOCLMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7078300", Offset = "0x7077500", VA = "0x187078300")]
		get
		{
			return default(BIAODIIIGGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x70786A0", Offset = "0x70778A0", VA = "0x1870786A0")]
	public DNCKNLPFEBA(IList<Mesh> MGMFJLCJFKF, IList<Matrix4x4> KIEFHALJOPJ, IList<bool> ANAJPMBMBOM, byte NFOOJFKLJBN, IList<byte[]> LGOFLLKPLGA, IList<int> OJGAMKJIJHE, IList<bool> KCMEGOBBDED, IList<int> LCDOBPCHHDL, IList<int> OGOILJBJGHM, IList<int> OKMHPKOFKLO, Allocator NNHCNMKJHLF, COLMEPMMNCE LMIMJAKOIJA, bool NLNPMKGKADJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7078570", Offset = "0x7077770", VA = "0x187078570")]
	public MGGIOBOCMIF LADLPKBFEND(Allocator NNHCNMKJHLF, DKLPOJKPLHK KBIDLDHCNAI)
	{
		return default(MGGIOBOCMIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7078150", Offset = "0x7077350", VA = "0x187078150", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[KHFOLODBECL]
public class CFBEPLINGBH : DLOIEMENJIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool NMKEBLLPOPK;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly ProfilerMarker CKKILLAIHFA;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x706B4F0", Offset = "0x706A6F0", VA = "0x18706B4F0")]
	public DNCKNLPFEBA EPJNBLAHHLH()
	{
		return default(DNCKNLPFEBA);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x706B7B0", Offset = "0x706A9B0", VA = "0x18706B7B0")]
	public CFBEPLINGBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct BIAODIIIGGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Mesh.MeshData JCAEFKOPEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<BoneWeight> AGEDEOABNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeSlice<byte> LLKIPMGJJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int MADCDHDBBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Matrix4x4 BAEMCNCGPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public int IPKPHEAMKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<byte> PHPIBOALCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public bool JMFBCEDBFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int MHPKGCOLPKP;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CHJEEJMPODN : NMHKDIBMOMB
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class LEGNPHNFFPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public FIEOFIFGBDG avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public CHJEEJMPODN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public FMIMELHPEBJ buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public Action<KeyValuePair<string, PDBMJMIDPNE<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public LEGNPHNFFPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x707B590", Offset = "0x707A790", VA = "0x18707B590")]
		internal bool PAAPDOEIBLP(JOEMMHDGFBD item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x707B460", Offset = "0x707A660", VA = "0x18707B460")]
		internal void NEHBDPDDNOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x707B480", Offset = "0x707A680", VA = "0x18707B480")]
		internal void KMPGLIFEOGK(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x707B460", Offset = "0x707A660", VA = "0x18707B460")]
		internal void IBLAHDHKIDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x707B480", Offset = "0x707A680", VA = "0x18707B480")]
		internal void MJIDGEIOONA(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x707B560", Offset = "0x707A760", VA = "0x18707B560")]
		internal void MLJACNLIPJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x707B5E0", Offset = "0x707A7E0", VA = "0x18707B5E0")]
		internal void PCBFNJNCMKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x707B610", Offset = "0x707A810", VA = "0x18707B610")]
		internal void PMDOCOABJGP(Dictionary<string, PDBMJMIDPNE<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x707B4A0", Offset = "0x707A6A0", VA = "0x18707B4A0")]
		internal void LHKGAFOIGIP(KeyValuePair<string, PDBMJMIDPNE<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0")]
		internal JABNAOPJDOK EIEPOJBFKAA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class KBMDBMIOLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public LEGNPHNFFPN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public KBMDBMIOLLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x707B320", Offset = "0x707A520", VA = "0x18707B320")]
		internal EKGOHKDJGOB GFLAEJIOAJP(int lod)
		{
			return default(EKGOHKDJGOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class KPEKDFMNBPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public OABBPFFKNOC<Dictionary<string, PDBMJMIDPNE<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public KPEKDFMNBPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
		internal OABBPFFKNOC<Dictionary<string, PDBMJMIDPNE<Texture2D>>> BPJNJMGFFPO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class DIBONENEHDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public List<FMIMELHPEBJ> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public DIBONENEHDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7077870", Offset = "0x7076A70", VA = "0x187077870")]
		internal void EEOMKJPONPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class CENPNMOEHFH : IEnumerator<IOBGCLDPPJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private IOBGCLDPPJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public CHJEEJMPODN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public List<FEGCLFEFMBJ> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public List<FMIMELHPEBJ> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Func<int, EKGOHKDJGOB> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public KAIPFDNNBPO materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private IOBGCLDPPJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
		[DebuggerHidden]
		public CENPNMOEHFH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x706B220", Offset = "0x706A420", VA = "0x18706B220", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x706B4A0", Offset = "0x706A6A0", VA = "0x18706B4A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class GHFCHHKICAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public PKEMMIALFGC cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public GHFCHHKICAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA84B70", Offset = "0xA83D70", VA = "0x180A84B70")]
		internal void DOGHADBJIPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xB8F500", Offset = "0xB8E700", VA = "0x180B8F500")]
		internal void NCGLJNPPFBP(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class KCFIGPLELOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public CHJEEJMPODN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public KCFIGPLELOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class PAEJLLONDKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public MGGIOBOCMIF defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public DNCKNLPFEBA defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public KCFIGPLELOC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public PAEJLLONDKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7080860", Offset = "0x707FA60", VA = "0x187080860")]
		internal void MPCCBHOBGAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1059AE0", Offset = "0x1058CE0", VA = "0x181059AE0")]
		internal void HELDNOBBLFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class DACILBHNGEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public OHGFFPGCILE legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public BBDHCJBILDB legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public KCFIGPLELOC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public DACILBHNGEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7077630", Offset = "0x7076830", VA = "0x187077630")]
		internal void GDLDDIDOFNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1055CE0", Offset = "0x1054EE0", VA = "0x181055CE0")]
		internal void IJNHNMOPKED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class KGMOACJPNBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public IEPCDHHNEOA overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public KGMOACJPNBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x707B3E0", Offset = "0x707A5E0", VA = "0x18707B3E0")]
		internal bool CGKJGNGKPKP(KeyValuePair<string, JOEMMHDGFBD> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly AEJLNDNFINA PNFBFLEPOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly AEJLNDNFINA COFHLHEAJKF;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static float IMLCHBJKBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private AvatarConfiguration PDANHCFIMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private Transform DDCLGMFOGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private AvatarSkinAssetItem OPMGIBAMIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private AssetReference DNKPNBLABLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private GameObject NANEGKAJPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private GameObject EFEHGKFGPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private SkinnedMeshRenderer AHPKGOIIIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private AvatarSkinnedMeshBoneOrderRemapsData LCFHDPMEFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Transform[] GJBONGGMLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Matrix4x4[] HPBNFDHOHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Material DKEAILMDLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Material OFMLFNAHPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Material JCGGCCIPDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Shader KAAEFLEDAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Shader GBJHFDHNDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Animator ADGAHKNBCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Renderer[] JAFGMADDPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private LJLGCMOEKHG.AMEKCHAHPFE FDBOOGLMHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private AvatarBodyPartShapesManager GNOMCDNHIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private IReadOnlyDictionary<string, Transform> HFPHGMFLFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private AvatarFaceShapeData.HCLGAINEBOC GDMOKAHBDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private AvatarBodyShapeData.AMOILEEGANN BOFJJHKLLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool JFOCBBMLOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool DGNNMCIJGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Color KLNODKELILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Color OIMDGCMECNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Color FAIDNOGOELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Color? JCJNHNPKHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Color? EAHANJCBLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Color? PJJJLDAJPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Color? ELLJCHMLLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Texture2D LHAGBBLGCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Texture2D MLDJLLPFEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[CanBeNull]
	private JOEMMHDGFBD JIKIPLKPKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Texture BJHIJKDAEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Color PHCNEMAPALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public Dictionary<Renderer, KAIPFDNNBPO> ALGBELFKMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private Dictionary<Renderer, KAIPFDNNBPO> KDABNFGPFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Dictionary<string, List<PHJLNIBFOFL>> PEECENCDEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private Dictionary<string, List<PHJLNIBFOFL>> MBPEHFICHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly List<ACEDPKMPOHF> BOCPLJAOFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly List<ACEDPKMPOHF> NNJDNBJAEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly List<ACEDPKMPOHF> OFOAOGBBBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly List<ACEDPKMPOHF> OEKCBFHNHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Dictionary<PHJLNIBFOFL, Material> PEDNOMKIIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Dictionary<PHJLNIBFOFL, Material> CPEAHFKKHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private SkinnedMeshRenderer[] NMCGFDPLNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private SkinnedMeshRenderer[] CEHADPAOJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private SkinnedMeshRenderer[] JGHNFEANJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private SkinnedMeshRenderer[] NAOKGHBEHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly Dictionary<string, PDBMJMIDPNE<Texture2D>> JMCLCJCIPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Dictionary<string, PDBMJMIDPNE<Texture2D>> HECFJCNPNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private OGGLBJKMHFF GPGOAKCMIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private OGGLBJKMHFF KAGJFOBHHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private AdditionalHatData GPNMJAMIHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private AdditionalHatData GOKGKIINBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private HairData PBJIDNBDOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private HairData BPLJFPJMCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private APGOBKHECLL DDLFMGEDNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool? IOLGHAGHIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private PositionAndRotation AFNBLMCJBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private Transform FCCBPAIOFKF;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Material DKGBOBCKLAL;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Material FNIAENBLEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Dictionary<string, JOEMMHDGFBD> DOPCOENEOFP;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int CPHKGAANLBB;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int IGCOOOEMNDA;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int JKEEOFJGBHG;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int MHMPDNAPMBG;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int BAIAGNDBEIO;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int DAPPGAABOFP;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int NLMGJOBIHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private bool JCIBJOKJAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private List<Action> IDPKMHODFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private AHOOBEAGJBG BLPPCDOKKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private SkinnedMeshRenderer[] MAGKGIAPEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int FIDIJDDNFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool FKPOJPKDBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private int MMBPHBCOMKB;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public AEJLNDNFINA HJJDAOAMFBN
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public AEJLNDNFINA JMABLEAICCP
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public AvatarConfiguration DMDDNICMBOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool FKJNCFGJAIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7070F20", Offset = "0x7070120", VA = "0x187070F20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x706B7C0", Offset = "0x706A9C0", VA = "0x18706B7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private Material IMNHPNLHDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x706DBC0", Offset = "0x706CDC0", VA = "0x18706DBC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private Material EMIEHNGJAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x706C0B0", Offset = "0x706B2B0", VA = "0x18706C0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool KFKDPBBLHMC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public HCLDEAEBCAG LAIMAGFGHHF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA8A350", Offset = "0xA89550", VA = "0x180A8A350", Slot = "23")]
		get
		{
			return default(HCLDEAEBCAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Material ABEBLAOMGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8F9230", Offset = "0x8F8430", VA = "0x1808F9230", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public SkinnedMeshRenderer[] MMNPLKNFKDE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1B9FA10", Offset = "0x1B9EC10", VA = "0x181B9FA10", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Renderer[] GAJJBIIKJMN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xB79F30", Offset = "0xB79130", VA = "0x180B79F30", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool LOLOKIPKGLN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x706E5D0", Offset = "0x706D7D0", VA = "0x18706E5D0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public LJLGCMOEKHG.AMEKCHAHPFE NBNMDLOPPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8FA3D0", Offset = "0x8F95D0", VA = "0x1808FA3D0", Slot = "20")]
		get
		{
			return default(LJLGCMOEKHG.AMEKCHAHPFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int BGLFOPNBGJH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1FEDFA0", Offset = "0x1FED1A0", VA = "0x181FEDFA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7070F00", Offset = "0x7070100", VA = "0x187070F00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private bool LECIIONCGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x706D910", Offset = "0x706CB10", VA = "0x18706D910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private static bool FONBCJJCGID
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x706D8E0", Offset = "0x706CAE0", VA = "0x18706D8E0", Slot = "15")]
	public FMIMELHPEBJ DGPOMLMHOEC(FIEOFIFGBDG AJNLMGMBFLA, bool KPDOMLMNACN, int[] OOPMJOFGEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x706B7D0", Offset = "0x706A9D0", VA = "0x18706B7D0", Slot = "14")]
	public FMIMELHPEBJ ABJBGLAOFCC(FIEOFIFGBDG AJNLMGMBFLA, bool KPDOMLMNACN, int[] OOPMJOFGEBD, Func<Dictionary<string, JOEMMHDGFBD>, (FMIMELHPEBJ, OABBPFFKNOC<Dictionary<string, PDBMJMIDPNE<Texture2D>>>)> KOAAJJKIPCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7072280", Offset = "0x7071480", VA = "0x187072280")]
	public FMIMELHPEBJ MLMNAMPFFKO(FIEOFIFGBDG AJNLMGMBFLA, bool KPDOMLMNACN, int[] OOPMJOFGEBD, bool MBPOHPNCEBH, OGGLBJKMHFF JICMLIIPDJA, [Optional] Func<Dictionary<string, JOEMMHDGFBD>, (FMIMELHPEBJ, OABBPFFKNOC<Dictionary<string, PDBMJMIDPNE<Texture2D>>>)> KOAAJJKIPCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x706BF40", Offset = "0x706B140", VA = "0x18706BF40")]
	private bool AIPGOKCOIOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7073F20", Offset = "0x7073120", VA = "0x187073F20")]
	private FMIMELHPEBJ MMMMADOPCMP(bool KPDOMLMNACN, List<FEGCLFEFMBJ> PHKGELHGIIN, int[] OOPMJOFGEBD, Func<int, EKGOHKDJGOB> DHIJONKHMFB, bool MBPOHPNCEBH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x706C930", Offset = "0x706BB30", VA = "0x18706C930")]
	[IteratorStateMachine(typeof(CENPNMOEHFH))]
	private IEnumerator<IOBGCLDPPJE> BKJHONLHIIG(bool KPDOMLMNACN, List<FEGCLFEFMBJ> PHKGELHGIIN, int[] OOPMJOFGEBD, Func<int, EKGOHKDJGOB> DHIJONKHMFB, KAIPFDNNBPO PIGDDIHIIBP, Material LINOANFJMJJ, List<FMIMELHPEBJ> HNKIDOHPDEL, bool DEINJLMMFJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7074CA0", Offset = "0x7073EA0", VA = "0x187074CA0")]
	private void OAEEHPMAFGA(List<FEGCLFEFMBJ> PHKGELHGIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x706C300", Offset = "0x706B500", VA = "0x18706C300")]
	private FMIMELHPEBJ BCPLPKBLCHK(List<FEGCLFEFMBJ> PHKGELHGIIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x706FA60", Offset = "0x706EC60", VA = "0x18706FA60")]
	private GFDHFLBBFKF IGCFNIPFIKL(List<FEGCLFEFMBJ> PHKGELHGIIN, int MPDJGCJPOLI, bool KPDOMLMNACN, EKGOHKDJGOB DDNEALBALGE, bool BIDDGONAICE, KAIPFDNNBPO PIGDDIHIIBP, Material LINOANFJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7071100", Offset = "0x7070300", VA = "0x187071100", Slot = "25")]
	public void KOEHPBDGAFJ(AvatarFaceShape CHGONPMGOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x70752D0", Offset = "0x70744D0", VA = "0x1870752D0", Slot = "26")]
	public void OCNKLDMBLDH(AvatarBodyShape EMGCKCODKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7076030", Offset = "0x7075230", VA = "0x187076030", Slot = "28")]
	public void PJMMOOLMBEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x706CEB0", Offset = "0x706C0B0", VA = "0x18706CEB0", Slot = "27")]
	public void CACCDNEJMPO(bool NKECAHDILHL, bool HHJEIOEAIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x706CF10", Offset = "0x706C110", VA = "0x18706CF10")]
	private void CILPCFGJAII(SkinnedMeshRenderer EGDHDOJGAJA, int MPDJGCJPOLI, Mesh NNPLONBDKAB, List<Material> HCKDHHHOLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x706D4B0", Offset = "0x706C6B0", VA = "0x18706D4B0")]
	private static Material DAIKOAOFAFF(Dictionary<PHJLNIBFOFL, Material> JDONFHJOCLP, Material JGGNIKJBDOL, IGJDKHOAHLJ JDFGBMEBLBG, OPICNNMDPNH HLAEBPPMKNO, IEPCDHHNEOA EFKLNALJCMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7071450", Offset = "0x7070650", VA = "0x187071450")]
	private static IGJDKHOAHLJ MDIJNPLFPKM(FEGCLFEFMBJ HCEEEBCLMJG, int OLFJJLJBFFO)
	{
		return default(IGJDKHOAHLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7075AD0", Offset = "0x7074CD0", VA = "0x187075AD0")]
	private void ONKAENJGMGE(int LMAPNAOMGHO, Material HGJFBFIMOOD, FEGCLFEFMBJ HCEEEBCLMJG, [Out] Texture2D FFKEICNFOJL, [Out] Vector4 MLMFAEIPNFE, [Out] Texture2D BLLGOBDBDAI, [Out] Texture2D PDDMDBNBLFJ, [Out] Texture2D NNHBDIIKPMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x706DDE0", Offset = "0x706CFE0", VA = "0x18706DDE0")]
	private void FALMPLAILOI(int LMAPNAOMGHO, Material HGJFBFIMOOD, FEGCLFEFMBJ HCEEEBCLMJG, [Out] Color HAHDIMOMHDM, [Out] Color INPGEEFCIGN, [Out] Color JOFFOJDMKPM, [Out] Color NCKLIGNHLEI, [Out] Color JLEFCANKBGF, [Out] Color JDOJAHDBEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x706D120", Offset = "0x706C320", VA = "0x18706D120")]
	private bool CLOFPAEJIKH(Material HGJFBFIMOOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x706CEC0", Offset = "0x706C0C0", VA = "0x18706CEC0")]
	private static Material CHFGPIDIALF(int LMAPNAOMGHO, JDALIFDCLHD HCEEEBCLMJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x706D800", Offset = "0x706CA00", VA = "0x18706D800")]
	private static OPICNNMDPNH DGIPEIHGNGC(FEGCLFEFMBJ HCEEEBCLMJG, int OLFJJLJBFFO)
	{
		return default(OPICNNMDPNH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x706CBF0", Offset = "0x706BDF0", VA = "0x18706CBF0")]
	private static void BPIAOIAALKE(Dictionary<string, List<PHJLNIBFOFL>> FICGKNGGGJP, FEGCLFEFMBJ PIHCLJNDGBL, Material JGGNIKJBDOL, IGJDKHOAHLJ LKKCGJELLIG, OPICNNMDPNH CDLJPEHJDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7074A70", Offset = "0x7073C70", VA = "0x187074A70")]
	private static SkinnedMeshRenderer NOGHOLFCFDH(Transform DAFIEOHONMG, Transform KIKNKJDPNJH, SkinnedMeshRenderer[] BCBINIMBMLF, int MPDJGCJPOLI, EKGOHKDJGOB DDNEALBALGE, bool KPDOMLMNACN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x70770A0", Offset = "0x70762A0", VA = "0x1870770A0")]
	public CHJEEJMPODN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x706E740", Offset = "0x706D940", VA = "0x18706E740")]
	public void GGPOBANFNOP([In] KPDINCJBPMI KCLBKKJKMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x706DD60", Offset = "0x706CF60", VA = "0x18706DD60")]
	public void EOJIPHAFGMB([In] FMKELNDKJIC ONHFHGMGOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7070F00", Offset = "0x7070100", VA = "0x187070F00", Slot = "5")]
	public void JBGCAIOKOOE(int MPDJGCJPOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x70711C0", Offset = "0x70703C0", VA = "0x1870711C0", Slot = "10")]
	public void LCNLHNBNLHG(IEEDDENAPDI CDLJPEHJDIB, Texture2D AANEOIBPLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330")]
	public static bool NLLAGGNOLKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7075950", Offset = "0x7074B50", VA = "0x187075950", Slot = "11")]
	public bool OLLNLIFGHMC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x70754E0", Offset = "0x70746E0", VA = "0x1870754E0", Slot = "9")]
	public void ODKFIKLPJFB(JIGNMKLEPID LKKCGJELLIG, Color? HCHFCFNLIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7072200", Offset = "0x7071400", VA = "0x187072200")]
	private void MKJCCOFBOEK(Action KFMAJENMEDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x706D990", Offset = "0x706CB90", VA = "0x18706D990", Slot = "6")]
	public void DJKEJOJDMHJ(JOEMMHDGFBD MEEDDNNMHAF, Texture LNMCLOFMOOL, Color HNKHFADFHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x706B7C0", Offset = "0x706A9C0", VA = "0x18706B7C0", Slot = "7")]
	public void ABIGBDNLPMI(bool DEINJLMMFJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1BB73D0", Offset = "0x1BB65D0", VA = "0x181BB73D0", Slot = "8")]
	public void CNHOIFCDKCM(AHOOBEAGJBG HLJPDMABNJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x706EBD0", Offset = "0x706DDD0", VA = "0x18706EBD0", Slot = "16")]
	public void GNKJJOMBHGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7076130", Offset = "0x7075330", VA = "0x187076130", Slot = "29")]
	public void PLPPBBFPBJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7076190", Offset = "0x7075390", VA = "0x187076190", Slot = "30")]
	public void PMAOHAOKLCF([Optional] APGOBKHECLL MNBEDLICCLG, [Optional] bool? LBNBMAIOKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7070DC0", Offset = "0x706FFC0", VA = "0x187070DC0")]
	private bool IMKDENCIGPK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x706DA30", Offset = "0x706CC30", VA = "0x18706DA30", Slot = "21")]
	public bool EGOMPLAFALH(LJLGCMOEKHG.AMEKCHAHPFE BDKIJJMMAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x706E400", Offset = "0x706D600", VA = "0x18706E400")]
	private void GDGKIDJJDMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7070FD0", Offset = "0x70701D0", VA = "0x187070FD0")]
	private void KAIKCAHAJFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x706C1A0", Offset = "0x706B3A0", VA = "0x18706C1A0")]
	private static void BCOGCLFGALN(Dictionary<PHJLNIBFOFL, Material> JDONFHJOCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x706F900", Offset = "0x706EB00", VA = "0x18706F900")]
	private static void IFBAKBIBDHK(Dictionary<Renderer, KAIPFDNNBPO> GANIGEAGPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7070FE0", Offset = "0x70701E0", VA = "0x187070FE0")]
	private void KDADOCHGNHP(SkinnedMeshRenderer[] BCBINIMBMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x706D410", Offset = "0x706C610", VA = "0x18706D410")]
	private void CPPGHDIMKLM(SkinnedMeshRenderer NDIOBNOFBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x706C760", Offset = "0x706B960", VA = "0x18706C760")]
	private void BHGGOIKHBHH(List<ACEDPKMPOHF> IGEDBGGLODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7072080", Offset = "0x7071280", VA = "0x187072080")]
	private void MIGEIKIDMDP(Dictionary<string, PDBMJMIDPNE<Texture2D>> FICGKNGGGJP, bool GOAJGOHCOJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7075900", Offset = "0x7074B00", VA = "0x187075900")]
	private void OJJCONDEIKP(Dictionary<string, List<PHJLNIBFOFL>> FICGKNGGGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7075390", Offset = "0x7074590", VA = "0x187075390")]
	private void ODEFFKLLPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x706EA40", Offset = "0x706DC40", VA = "0x18706EA40")]
	private void GLOCGOOFOMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x706B800", Offset = "0x706AA00", VA = "0x18706B800")]
	private void ADCCLILCOKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x706E330", Offset = "0x706D530", VA = "0x18706E330")]
	private void FHNMFNJOAFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7070D30", Offset = "0x706FF30", VA = "0x187070D30")]
	private void IMJGABACMDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7074920", Offset = "0x7073B20", VA = "0x187074920")]
	private void MONCNNMKBIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7070C60", Offset = "0x706FE60", VA = "0x187070C60")]
	private void IKOCIIHKCNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x706BDD0", Offset = "0x706AFD0", VA = "0x18706BDD0")]
	private void AFGLIDJGLKO(bool IMJIIHEAJOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x706D050", Offset = "0x706C250", VA = "0x18706D050")]
	private void CKJEJBBCGGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7075F50", Offset = "0x7075150", VA = "0x187075F50")]
	private void PFMHKIHLDGH(bool IMJIIHEAJOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x706F4F0", Offset = "0x706E6F0", VA = "0x18706F4F0")]
	private void HLDOFEDHGKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7071930", Offset = "0x7070B30", VA = "0x187071930")]
	private void MFMMCFJLFIM(Material LINOANFJMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x706EDF0", Offset = "0x706DFF0", VA = "0x18706EDF0")]
	private void HEAFHPOPEHG(Material LINOANFJMJJ, Color IDFOLNEBADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7071E30", Offset = "0x7071030", VA = "0x187071E30")]
	private void MHPGAHKIOIC(Material LINOANFJMJJ, Color IDFOLNEBADM, Color BKGDPHCCGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x706CA50", Offset = "0x706BC50", VA = "0x18706CA50")]
	private void BMJHKLBLIEH(Material LINOANFJMJJ, Color HAHDIMOMHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x706D610", Offset = "0x706C810", VA = "0x18706D610")]
	private void DEMPKMIBCCE(Material LINOANFJMJJ, Texture2D AANEOIBPLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x706DA50", Offset = "0x706CC50", VA = "0x18706DA50")]
	private void EHBMJOHPMFG(Material LINOANFJMJJ, Texture PBAOKMMFLEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x706F390", Offset = "0x706E590", VA = "0x18706F390")]
	private void HFKFEKHKKJA(Action<KAIPFDNNBPO> OOFOCDMJHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x706C550", Offset = "0x706B750", VA = "0x18706C550")]
	private void BEJENLMGLNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7074500", Offset = "0x7073700", VA = "0x187074500")]
	private void MOECHEBLCHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7071560", Offset = "0x7070760", VA = "0x187071560")]
	private void MFLIMNIDAFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x706EF70", Offset = "0x706E170", VA = "0x18706EF70")]
	public void HEEAAMPBIBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x706DD60", Offset = "0x706CF60", VA = "0x18706DD60", Slot = "4")]
	private void JENMBBHPEOG([In] FMKELNDKJIC ONHFHGMGOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7075EE0", Offset = "0x70750E0", VA = "0x187075EE0")]
	[CompilerGenerated]
	private JABNAOPJDOK OPFDMFMHKNG(FEGCLFEFMBJ GBPBPMJPBKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x706F300", Offset = "0x706E500", VA = "0x18706F300")]
	[CompilerGenerated]
	private void HEICEKBBPAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x706F810", Offset = "0x706EA10", VA = "0x18706F810")]
	[CompilerGenerated]
	private void HPHDMIDHLIC(KAIPFDNNBPO ELJPGJDFDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x706E2A0", Offset = "0x706D4A0", VA = "0x18706E2A0")]
	[CompilerGenerated]
	private void FCBEDCCMNBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x706EDD0", Offset = "0x706DFD0", VA = "0x18706EDD0")]
	[CompilerGenerated]
	private void HBEECJMNBPK(KAIPFDNNBPO ELJPGJDFDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x706D380", Offset = "0x706C580", VA = "0x18706D380")]
	[CompilerGenerated]
	private void CPHAGEEAGEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x70758E0", Offset = "0x7074AE0", VA = "0x1870758E0")]
	[CompilerGenerated]
	private void OFMAJMHIGPH(KAIPFDNNBPO ELJPGJDFDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x706BEB0", Offset = "0x706B0B0", VA = "0x18706BEB0")]
	[CompilerGenerated]
	private void AIPGBMACOJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x706C000", Offset = "0x706B200", VA = "0x18706C000")]
	[CompilerGenerated]
	private void AKADGAINKPO(KAIPFDNNBPO ELJPGJDFDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x706F840", Offset = "0x706EA40", VA = "0x18706F840")]
	[CompilerGenerated]
	private void IBJDKINMJHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7075F20", Offset = "0x7075120", VA = "0x187075F20")]
	[CompilerGenerated]
	private void PBLNLLAHGOM(KAIPFDNNBPO ELJPGJDFDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7070F40", Offset = "0x7070140", VA = "0x187070F40")]
	[CompilerGenerated]
	private void JOOFNCPIGEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7071410", Offset = "0x7070610", VA = "0x187071410")]
	[CompilerGenerated]
	private void LILDIOIKILJ(KAIPFDNNBPO ELJPGJDFDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x706C6D0", Offset = "0x706B8D0", VA = "0x18706C6D0")]
	[CompilerGenerated]
	private void BFGBIKPDJLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x706F8D0", Offset = "0x706EAD0", VA = "0x18706F8D0")]
	[CompilerGenerated]
	private void IDFICNABLCB(KAIPFDNNBPO ELJPGJDFDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x706C030", Offset = "0x706B230", VA = "0x18706C030")]
	[CompilerGenerated]
	private void BAHNKKKEIBG(KeyValuePair<string, PDBMJMIDPNE<Texture2D>> LPECGLGCPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7070F30", Offset = "0x7070130", VA = "0x187070F30")]
	[CompilerGenerated]
	private void JLODKKDPBDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x70713E0", Offset = "0x70705E0", VA = "0x1870713E0")]
	[CompilerGenerated]
	private void LDKECEPMPIM(KAIPFDNNBPO ELJPGJDFDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7071440", Offset = "0x7070640", VA = "0x187071440")]
	[CompilerGenerated]
	private void LNBEACCJFKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x706DA00", Offset = "0x706CC00", VA = "0x18706DA00")]
	[CompilerGenerated]
	private void ECBNBPDFAJC(KAIPFDNNBPO ELJPGJDFDLA)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class AvatarElbowBendHelperController : MonoBehaviour, IJPCFPJKLKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[SerializeField]
		[PJAPKCLJNLP(FFILGMALDDB.Self, false, false, false)]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[Header("Scale")]
		[SerializeField]
		[FormerlySerializedAs("MinScaleValues")]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[FormerlySerializedAs("MaxScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[Header("Positional Offset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[SerializeField]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private Vector3? PBDLNKAOPPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private bool ADNHPGHGDPE;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x70698C0", Offset = "0x7068AC0", VA = "0x1870698C0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7069EF0", Offset = "0x70690F0", VA = "0x187069EF0", Slot = "4")]
		public void UpdateController(float NIMHBLEHMBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xAC4CF0", Offset = "0xAC3EF0", VA = "0x180AC4CF0", Slot = "6")]
		public void SetEnabled(bool OMEFCJCOLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x70699A0", Offset = "0x7068BA0", VA = "0x1870699A0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x706A3B0", Offset = "0x70695B0", VA = "0x18706A3B0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AvatarElbowBendTargetController : MonoBehaviour, IJPCFPJKLKA
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private const float FGDMIIBBIJC = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[SerializeField]
		[PJAPKCLJNLP(FFILGMALDDB.Self, false, false, false)]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private Vector3 LMBNOFCOJLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private Vector3 PDPJIPMAGNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private bool ADNHPGHGDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private float OBHOIHGPKIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private float CEMKINPIPAA;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x706A730", Offset = "0x7069930", VA = "0x18706A730", Slot = "4")]
		public void UpdateController(float NIMHBLEHMBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xF91320", Offset = "0xF90520", VA = "0x180F91320", Slot = "6")]
		public void SetEnabled(bool OMEFCJCOLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x706A450", Offset = "0x7069650", VA = "0x18706A450")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x706B1F0", Offset = "0x706A3F0", VA = "0x18706B1F0")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LJLAFOEIIPL : GJBMEOPCGOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly int AEKDMNIFCJC;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly int GFKKJEFBOBJ;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int AHEHHNFNEFJ;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int KNOJADLPEME;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly int BEAEOILLCOA;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly int PFLAGHCJMDK;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int AEPAFDFJDGP;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int NEBKLOHFNFP;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int ELAEBBLHHBC;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly int FCHMFDOECEI;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly int BDFAEJDJBCP;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly int JMMBADDOJFC;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly int FDAFNOFJBBM;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static readonly int LCFCKIDDHIP;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly int JCJOCDIFAEK;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static readonly int NJJCHOPJOIH;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly int MFPGGKAEFFF;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly int GODFELFAHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Transform OOAEAPJNBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private Transform BFNNLCIBDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private Transform DCPMNCDGDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private Transform AOJALLCKPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private Transform AFJKMCDFAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private Transform EPHNGOLFGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private Transform DOHEOLEPJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private EGPCDCLIJAK OIENPBDDPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private Material IEBOBBGJLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private SkinnedMeshRenderer[] MIBBLIMHCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly List<Material> NFCJKFBBHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private KJPHPPOOEAA AGGHPEKOOMB;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private KJPHPPOOEAA FJHABMKAGNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x707C350", Offset = "0x707B550", VA = "0x18707C350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool EHPNJBGMJGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x707BBF0", Offset = "0x707ADF0", VA = "0x18707BBF0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x707C280", Offset = "0x707B480", VA = "0x18707C280")]
	public void GGPOBANFNOP([In] EGPCDCLIJAK FCEBHLLGGAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x707C1D0", Offset = "0x707B3D0", VA = "0x18707C1D0")]
	public void IDJLPPEDOPL([In] NALMJJJBNAH GDMAJLLKNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x707B710", Offset = "0x707A910", VA = "0x18707B710", Slot = "6")]
	public void AIAEOBMBOOH(KICLPGFCEDO NJEMLJAGIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x707C100", Offset = "0x707B300", VA = "0x18707C100")]
	private Vector2 DMNDCKOOJJK(Vector2 KMMBCMBGBAG)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x707C3D0", Offset = "0x707B5D0", VA = "0x18707C3D0")]
	public void KPHLNOJLGNF([In] PEAILDKIJMD GDMAJLLKNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x707D310", Offset = "0x707C510", VA = "0x18707D310")]
	private void PMMBKNBOLDE(CGBFLDCBBDG EDKJBKMLCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x707BD70", Offset = "0x707AF70", VA = "0x18707BD70")]
	private void DAFCKHMLELO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x707C160", Offset = "0x707B360", VA = "0x18707C160")]
	private void LPNEGIGGPEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x707C160", Offset = "0x707B360", VA = "0x18707C160", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x707D990", Offset = "0x707CB90", VA = "0x18707D990")]
	public LJLAFOEIIPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x707C1D0", Offset = "0x707B3D0", VA = "0x18707C1D0", Slot = "5")]
	private void EJMNMKBMEPM([In] NALMJJJBNAH GDMAJLLKNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x707C270", Offset = "0x707B470", VA = "0x18707C270", Slot = "7")]
	private void FFLEGPHICKB([In] PEAILDKIJMD GDMAJLLKNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x707D280", Offset = "0x707C480", VA = "0x18707D280")]
	[CompilerGenerated]
	internal static (float, float) MGAOMFHEPGP(float ABOFPMCDKFP)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x707B6D0", Offset = "0x707A8D0", VA = "0x18707B6D0")]
	[CompilerGenerated]
	internal static Vector4 ABKPAPKCJAK(Vector2 FCKJMOMOHAE, Vector2 KGBNKPFPEFM)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AvatarForearmRollController : MonoBehaviour, IJPCFPJKLKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private float OBHOIHGPKIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private bool ADNHPGHGDPE;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7082070", Offset = "0x7081270", VA = "0x187082070", Slot = "4")]
		public void UpdateController(float NIMHBLEHMBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x143B5A0", Offset = "0x143A7A0", VA = "0x18143B5A0", Slot = "6")]
		public void SetEnabled(bool OMEFCJCOLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7082B00", Offset = "0x7081D00", VA = "0x187082B00")]
		public AvatarForearmRollController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class AvatarHandDisplaySettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public class AnimationOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7082BA0", Offset = "0x7081DA0", VA = "0x187082BA0")]
		public void MDPAGNEJHAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7082B30", Offset = "0x7081D30", VA = "0x187082B30")]
		public int GDFOCOCPLGA(int HOOFJLPANFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class KMCLCBCHDNC : CMBCNNFGIEC
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7090030", Offset = "0x708F230", VA = "0x187090030", Slot = "22")]
	public override float MEAJEODBMBC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7090080", Offset = "0x708F280", VA = "0x187090080")]
	public KMCLCBCHDNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class CMBCNNFGIEC : GNMICAIAGAB
{
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private static int OBAAIDDDCBC;

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static int ELEOHMBAJHE;

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private static int FFLCHOMPKHD;

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private static int PLKMEJDKAEM;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private static int OCCGJLDCBOD;

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private static int JIDDDCOBCHP;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private static int DOJEOIJOMJM;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static int[] KDDMCLOODEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private IMLPMHAKPLF OIENPBDDPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private CLOFNGFCPLE KNKCMGOCHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private int GBHOMFFGCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private float NEOCFHLPPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	protected Animator ADGAHKNBCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	protected bool BLIPOKLEMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	protected AvatarConfiguration JDFFIOPJKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	protected int CJIEBLKDKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private int GJBOGMFJGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private int KNCHLNHLFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private bool HMKIEPHHOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private HGOIIEMKHGN AJLJELDGKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private int AIHDCBEPONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private float LJADPNHELIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private AvatarHandDisplaySettings NMMKIMEGCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private HCLDEAEBCAG JLFBLPKBGEO;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Transform KNIPDPOLBGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8F54A0", Offset = "0x8F46A0", VA = "0x1808F54A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Vector3 CKFIGCNCCBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1431080", Offset = "0x1430280", VA = "0x181431080")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x14311F0", Offset = "0x14303F0", VA = "0x1814311F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Quaternion NJPJGHHLLCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xBBA390", Offset = "0xBB9590", VA = "0x180BBA390")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x14ED970", Offset = "0x14ECB70", VA = "0x1814ED970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool LPHLGKPDGCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x70870F0", Offset = "0x70862F0", VA = "0x1870870F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7087070", Offset = "0x7086270", VA = "0x187087070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Vector3 KKJDGHAHNKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7087000", Offset = "0x7086200", VA = "0x187087000", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x70870B0", Offset = "0x70862B0", VA = "0x1870870B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Quaternion FEEGJOFACIC
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2979610", Offset = "0x2978810", VA = "0x182979610", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x29798A0", Offset = "0x2978AA0", VA = "0x1829798A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public FOPKOLANAGM ANCLEKJLCIF
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xA3A300", Offset = "0xA39500", VA = "0x180A3A300", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(FOPKOLANAGM);
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA39990", Offset = "0xA38B90", VA = "0x180A39990", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public FOPKOLANAGM HOEGGAPLEIE
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2183A00", Offset = "0x2182C00", VA = "0x182183A00", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(FOPKOLANAGM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x21824B0", Offset = "0x21816B0", VA = "0x1821824B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public float EFNPBFKJFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x128AFC0", Offset = "0x128A1C0", VA = "0x18128AFC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xD6E5B0", Offset = "0xD6D7B0", VA = "0x180D6E5B0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool NALLOIAICPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7087350", Offset = "0x7086550", VA = "0x187087350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool LMMFDECAEMM
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x70878F0", Offset = "0x7086AF0", VA = "0x1870878F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool JEMADLAMBBE
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x70873A0", Offset = "0x70865A0", VA = "0x1870873A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool INBKDKMMFLH
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x70870A0", Offset = "0x70862A0", VA = "0x1870870A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x70871B0", Offset = "0x70863B0", VA = "0x1870871B0", Slot = "21")]
	public void GGPOBANFNOP(IMLPMHAKPLF FCEBHLLGGAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7086FB0", Offset = "0x70861B0", VA = "0x187086FB0")]
	public void AFFPNNMLGBK(CLOFNGFCPLE NGECGPFBHBM, AvatarHandDisplaySettings MAHNKJFCIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7087120", Offset = "0x7086320", VA = "0x187087120", Slot = "12")]
	public void GEIOLNDIHOI(bool FOFAGPDFKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7087540", Offset = "0x7086740", VA = "0x187087540", Slot = "11")]
	public void MDOJIJEFCJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x128AFC0", Offset = "0x128A1C0", VA = "0x18128AFC0", Slot = "22")]
	public virtual float MEAJEODBMBC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x70873B0", Offset = "0x70865B0", VA = "0x1870873B0")]
	private int MDIKBFIMFHF(FOPKOLANAGM JCPIOJDOOIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7087900", Offset = "0x7086B00", VA = "0x187087900")]
	private void MLLHMEIPOLM(int IDMNFOCKKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7087370", Offset = "0x7086570", VA = "0x187087370", Slot = "13")]
	public bool JKAJHINJDFH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7087390", Offset = "0x7086590", VA = "0x187087390", Slot = "14")]
	public bool JMILJGKHGIG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7087AC0", Offset = "0x7086CC0", VA = "0x187087AC0")]
	private FOPKOLANAGM NLLMEGAJLJH()
	{
		return default(FOPKOLANAGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x1B1F0D0", Offset = "0x1B1E2D0", VA = "0x181B1F0D0", Slot = "15")]
	public void OPCLDAELLEP(bool FOFAGPDFKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x70878B0", Offset = "0x7086AB0", VA = "0x1870878B0", Slot = "10")]
	public void MEBDHEAEJDA(int IDMNFOCKKHG, float ABPLIDCNIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x70870D0", Offset = "0x70862D0", VA = "0x1870870D0", Slot = "8")]
	public void ELNBBLDKCPI(HGOIIEMKHGN ONNLPKDFGPA, bool CICEJGGDGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7087360", Offset = "0x7086560", VA = "0x187087360", Slot = "9")]
	public void JADNDGFDNBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7087020", Offset = "0x7086220", VA = "0x187087020", Slot = "16")]
	public void AKCEKDKCMHE(Transform DBEHKFODEEL, Vector3 MCDAIILGGGD, Quaternion GEHEGEPOJAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7087DE0", Offset = "0x7086FE0", VA = "0x187087DE0")]
	public CMBCNNFGIEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class JDALIFDCLHD : FEGCLFEFMBJ
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class AJMHPHPNJPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public JDALIFDCLHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public List<ACEDPKMPOHF> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public List<ACEDPKMPOHF> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public PDBMJMIDPNE<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public PDBMJMIDPNE<EFLMECJLFOH> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public AJMHPHPNJPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7081290", Offset = "0x7080490", VA = "0x187081290")]
		internal JABNAOPJDOK FHLJPACMBAJ(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public JOEMMHDGFBD POKMHMFIEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public EFLMECJLFOH HHGJFLFPFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private PDBMJMIDPNE<EFLMECJLFOH> KHCPEOKJINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private PDBMJMIDPNE<Material[]> DKHBBKHNGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public Material[] MNOIMJLEMON;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool NCKBFMHMBBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xC897D0", Offset = "0xC889D0", VA = "0x180C897D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xC896C0", Offset = "0xC888C0", VA = "0x180C896C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public LJLGCMOEKHG.AMEKCHAHPFE NPBPLBGNMIM
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xB29E30", Offset = "0xB29030", VA = "0x180B29E30")]
		[CompilerGenerated]
		get
		{
			return default(LJLGCMOEKHG.AMEKCHAHPFE);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x119C4D0", Offset = "0x119B6D0", VA = "0x18119C4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x708D390", Offset = "0x708C590", VA = "0x18708D390")]
	public JDALIFDCLHD(IEPCDHHNEOA PHMAKKFMMCE, JOEMMHDGFBD GKNMOHDEDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x708C1F0", Offset = "0x708B3F0", VA = "0x18708C1F0", Slot = "6")]
	public override JABNAOPJDOK AEMHOBCALCP(List<ACEDPKMPOHF> JFMAEDKIGKN, List<ACEDPKMPOHF> CIEELAMJJPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x708C540", Offset = "0x708B740", VA = "0x18708C540")]
	public JABNAOPJDOK BFEFLKKLGEO(List<ACEDPKMPOHF> JFMAEDKIGKN, List<ACEDPKMPOHF> CIEELAMJJPD, PDBMJMIDPNE<Material[]> DKHBBKHNGNK, PDBMJMIDPNE<EFLMECJLFOH> OMALKOFCFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x708C860", Offset = "0x708BA60", VA = "0x18708C860")]
	public (PDBMJMIDPNE<Material[]>, PDBMJMIDPNE<EFLMECJLFOH>) EPELDGKCBHO(List<ACEDPKMPOHF> JFMAEDKIGKN, List<ACEDPKMPOHF> CIEELAMJJPD)
	{
		return default((PDBMJMIDPNE<Material[]>, PDBMJMIDPNE<EFLMECJLFOH>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x708CEA0", Offset = "0x708C0A0", VA = "0x18708CEA0", Slot = "7")]
	public override NABHEBDLNNE KCHNBCPNKCP(uint MPDJGCJPOLI, AvatarSkinnedMeshBoneOrderRemapsData AIPLCPJFOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x708CBD0", Offset = "0x708BDD0", VA = "0x18708CBD0")]
	public NABHEBDLNNE GFGIBONIAHL(GameObject MGMCBFEJDFD, uint MPDJGCJPOLI, bool NBFMJBODPII, bool EFOHOMFCMGA, AvatarSkinnedMeshBoneOrderRemapsData AIPLCPJFOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x708CFD0", Offset = "0x708C1D0", VA = "0x18708CFD0")]
	public static bool PJGKOBKFEMF(Renderer[] BCBINIMBMLF, string EDKHFJKMHBN, [Out] Renderer CBIIFHDPMKA, [Out] Renderer IDBONMIADHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x708D340", Offset = "0x708C540", VA = "0x18708D340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x708CDE0", Offset = "0x708BFE0", VA = "0x18708CDE0")]
	private (PDBMJMIDPNE<EFLMECJLFOH>, PDBMJMIDPNE<Material[]>) HPGNPBEMFBE()
	{
		return default((PDBMJMIDPNE<EFLMECJLFOH>, PDBMJMIDPNE<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x708C840", Offset = "0x708BA40", VA = "0x18708C840")]
	[CompilerGenerated]
	private void CJDECEPIBAF(EFLMECJLFOH NJFLHCEDIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x8F21B0", Offset = "0x8F13B0", VA = "0x1808F21B0")]
	[CompilerGenerated]
	private void APPPEFKANDF(Material[] NJFLHCEDIDN)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class AvatarKneeBendTargetController : MonoBehaviour, IJPCFPJKLKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[SerializeField]
		[PJAPKCLJNLP(FFILGMALDDB.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private Vector3 LMBNOFCOJLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private Vector3 JGEABCJMHBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private Vector3 NPIHDEPNJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private Matrix4x4 APBNPJHHHHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private bool ADNHPGHGDPE;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7083130", Offset = "0x7082330", VA = "0x187083130", Slot = "4")]
		public void UpdateController(float NIMHBLEHMBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7083120", Offset = "0x7082320", VA = "0x187083120", Slot = "6")]
		public void SetEnabled(bool OMEFCJCOLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7082CC0", Offset = "0x7081EC0", VA = "0x187082CC0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x70837F0", Offset = "0x70829F0", VA = "0x1870837F0")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[KHFOLODBECL]
public struct GIMLOMGALAH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	[ReadOnly]
	public BBDHCJBILDB NJAFHKJCPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	[ReadOnly]
	public int AHCJLKMLEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public OHGFFPGCILE DNKBGIIMPGN;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7089AB0", Offset = "0x7088CB0", VA = "0x187089AB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[KHFOLODBECL]
[NativeContainer]
public struct OHGFFPGCILE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<Vector3> LKCAPANOMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NativeArray<Vector3> BBMNGBJOKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public NativeArray<Vector4> MLEFIFAKEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeArray<Vector2> HFKFBLDGLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public NativeArray<Vector2> EBDFOCCGFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<Vector2> JCOJFGBICKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeArray<Vector2> HIFFEKHDBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeArray<Color> HFIBMLLEMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public NativeArray<int> GGKANJNAGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public NativeArray<int> DKGOILDKIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private NativeArray<int> KPEONALPPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private NativeArray<int> ADNPIGEDCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public NativeArray<int> JJOIAGADBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<int> IOALLPKJAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public NativeArray<int> KDJGFONDEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<BoneWeight> IINCJHOPFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private NativeArray<int> HLJPDMABNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private bool HMFIONFEFOF;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int OLCFDBOGJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7091640", Offset = "0x7090840", VA = "0x187091640")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7091620", Offset = "0x7090820", VA = "0x187091620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int HEGKKEDJJKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7091410", Offset = "0x7090610", VA = "0x187091410")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x70914F0", Offset = "0x70906F0", VA = "0x1870914F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int MHLPGKGAJLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7091610", Offset = "0x7090810", VA = "0x187091610")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7091630", Offset = "0x7090830", VA = "0x187091630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x70917F0", Offset = "0x70909F0", VA = "0x1870917F0")]
	public OHGFFPGCILE(int PBMFCMDIPBL, int BMAPFBDMOHE, int JJNNDPFCJLF, int PAHHHDGPCKL, Allocator NNHCNMKJHLF, int BEOIPFEKJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7091550", Offset = "0x7090750", VA = "0x187091550")]
	public void KKLHDKBHJAF(int CPLNODNGKGB, Vector3 PBNOOPEKDOL, Vector3 FOENIOOLJIF, Vector4 EBJDGDIMGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7091650", Offset = "0x7090850", VA = "0x187091650")]
	public void PMPEDFKMHNP(int CPLNODNGKGB, BoneWeight NLCMNONPPCA, NativeSlice<byte> PHPIBOALCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7091530", Offset = "0x7090730", VA = "0x187091530")]
	public Color KAMPJACBDNN(int CPLNODNGKGB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7091340", Offset = "0x7090540", VA = "0x187091340")]
	public void EGLFPHDEKBK(int CPLNODNGKGB, Color FDEJAKKFLHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x70915C0", Offset = "0x70907C0", VA = "0x1870915C0")]
	public void NHEBPIBNIKM(byte FPHBEJNEAGJ, int CPLNODNGKGB, Vector2 NBEEEOFHJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7090DA0", Offset = "0x708FFA0", VA = "0x187090DA0")]
	public void ALINGIHNMNK(int CPLNODNGKGB, int KNPEFKLBIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7091500", Offset = "0x7090700", VA = "0x187091500")]
	public bool JNNFIAHEHID(int FPHBEJNEAGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7091420", Offset = "0x7090620", VA = "0x187091420")]
	public void HOGLGCHCMPI(int IHINCCLMOND, int KLICPJBJAIA, int BJJBELCKPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7091360", Offset = "0x7090560", VA = "0x187091360")]
	public int[] ELGMBGEJBKO(int IHINCCLMOND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7090DB0", Offset = "0x708FFB0", VA = "0x187090DB0")]
	private NativeSlice<int> DGHNBIHMJKH(int IHINCCLMOND)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7090E40", Offset = "0x7090040", VA = "0x187090E40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7090FF0", Offset = "0x70901F0", VA = "0x187090FF0")]
	public Mesh EFAHIMABHMG([Optional] string OEKPLKDEJFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[NativeContainer]
[DefaultMember("Item")]
[KHFOLODBECL]
public struct BBDHCJBILDB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeArray<Vector3> LKCAPANOMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeArray<Vector3> BBMNGBJOKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<Vector4> MLEFIFAKEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<Vector2> HFKFBLDGLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<Vector2> EBDFOCCGFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<Vector2> JCOJFGBICKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<Vector2> HIFFEKHDBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<Color> HFIBMLLEMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<int> CNHBJPAJCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<int> DALHPNDMAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public NativeArray<int> BAFGBDEOABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeArray<int> BDOGLFJOEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public NativeArray<bool> ANAJPMBMBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public NativeArray<int> LCDOBPCHHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<int> PFIMIJAHHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<BoneWeight> AGEDEOABNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private NativeArray<Matrix4x4> BCLBHJLNLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private NativeArray<int> GBIDEEOGMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private NativeArray<byte> EGGIKIDKBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private NativeArray<int> BFCLFKNOFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private NativeArray<int> AOBPDOCNCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<sbyte> MBEFBPLEBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<byte> FDLONPFCHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private NativeArray<int> JCCLMMBNDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private bool HMFIONFEFOF;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int FJHPBEJHOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2516260", Offset = "0x2515460", VA = "0x182516260")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int CBJBAGLEFBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xAC7780", Offset = "0xAC6980", VA = "0x180AC7780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int OJACJLLDCJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7084950", Offset = "0x7083B50", VA = "0x187084950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int MGLGEOOHNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7084BE0", Offset = "0x7083DE0", VA = "0x187084BE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7084BF0", Offset = "0x7083DF0", VA = "0x187084BF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int OLCFDBOGJPN
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7085250", Offset = "0x7084450", VA = "0x187085250")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7085240", Offset = "0x7084440", VA = "0x187085240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int MFOBOJNGEKM
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7085230", Offset = "0x7084430", VA = "0x187085230")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7084C00", Offset = "0x7083E00", VA = "0x187084C00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public COLMEPMMNCE NCGNJLHFLMO
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7085220", Offset = "0x7084420", VA = "0x187085220")]
		get
		{
			return default(COLMEPMMNCE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7085260", Offset = "0x7084460", VA = "0x187085260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public byte GJJCKHOPKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7085130", Offset = "0x7084330", VA = "0x187085130")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7085140", Offset = "0x7084340", VA = "0x187085140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public CBMAHFNDELP FJMFIOCLMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7084C10", Offset = "0x7083E10", VA = "0x187084C10")]
		get
		{
			return default(CBMAHFNDELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7085270", Offset = "0x7084470", VA = "0x187085270")]
	public BBDHCJBILDB(IList<Mesh> MGMFJLCJFKF, IList<Matrix4x4> KIEFHALJOPJ, IList<bool> ANAJPMBMBOM, byte NFOOJFKLJBN, IList<byte[]> LGOFLLKPLGA, IList<int> OJGAMKJIJHE, IList<bool> KCMEGOBBDED, IList<int> LCDOBPCHHDL, IList<int> OGOILJBJGHM, IList<int> OKMHPKOFKLO, Allocator NNHCNMKJHLF, COLMEPMMNCE LMIMJAKOIJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7085150", Offset = "0x7084350", VA = "0x187085150")]
	public OHGFFPGCILE LADLPKBFEND(Allocator NNHCNMKJHLF)
	{
		return default(OHGFFPGCILE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7084980", Offset = "0x7083B80", VA = "0x187084980", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[KHFOLODBECL]
public class ALPLPIGJPGH : DLOIEMENJIO
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7081F80", Offset = "0x7081180", VA = "0x187081F80")]
	public BBDHCJBILDB EPJNBLAHHLH()
	{
		return default(BBDHCJBILDB);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x706B7B0", Offset = "0x706A9B0", VA = "0x18706B7B0")]
	public ALPLPIGJPGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct CBMAHFNDELP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeSlice<Vector3> LKCAPANOMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeSlice<Vector3> BBMNGBJOKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeSlice<Vector4> MLEFIFAKEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeSlice<Vector2> HFKFBLDGLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeSlice<Vector2> EBDFOCCGFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeSlice<Vector2> JCOJFGBICKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public NativeSlice<Vector2> HIFFEKHDBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public NativeSlice<Color> HFIBMLLEMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeSlice<int> GKPMNBCIBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public NativeSlice<int> BDOGLFJOEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public NativeSlice<BoneWeight> AGEDEOABNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public NativeSlice<byte> LLKIPMGJJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public int MADCDHDBBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public Matrix4x4 BAEMCNCGPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public int IPKPHEAMKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public NativeSlice<byte> PHPIBOALCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public bool JMFBCEDBFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public int MHPKGCOLPKP;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal readonly struct PHJLNIBFOFL : IEquatable<PHJLNIBFOFL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	internal readonly Material JFIBOJKBAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	internal readonly IGJDKHOAHLJ FCKANNJPAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	internal readonly OPICNNMDPNH AIFJJKLINKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	internal readonly IEPCDHHNEOA CHLOFLBFPFJ;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7092320", Offset = "0x7091520", VA = "0x187092320")]
	public PHJLNIBFOFL(Material HGJFBFIMOOD, IGJDKHOAHLJ JDFGBMEBLBG, OPICNNMDPNH HLAEBPPMKNO, IEPCDHHNEOA EFKLNALJCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7092100", Offset = "0x7091300", VA = "0x187092100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7091FE0", Offset = "0x70911E0", VA = "0x187091FE0", Slot = "4")]
	public bool Equals(PHJLNIBFOFL JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7091F00", Offset = "0x7091100", VA = "0x187091F00", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7092060", Offset = "0x7091260", VA = "0x187092060", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, KAIPBCMMBGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		[Header("Configuration")]
		[SerializeField]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		[SerializeField]
		[Header("Configuration")]
		private HCLDEAEBCAG avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private Transform HeadTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private NMHKDIBMOMB LHAFMFFBNNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private GJBMEOPCGOD NDPBCFNJMMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private GNMICAIAGAB BMMDIMPJKCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private GNMICAIAGAB APJOHHDOMAA;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public NMHKDIBMOMB IBBFKMKEJBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x7084620", Offset = "0x7083820", VA = "0x187084620", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public GJBMEOPCGOD NLGFBNIBHNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x7084670", Offset = "0x7083870", VA = "0x187084670", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public GNMICAIAGAB MGLKMEPCKND
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x7084890", Offset = "0x7083A90", VA = "0x187084890", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public GNMICAIAGAB EJEPJAMKBFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x70848E0", Offset = "0x7083AE0", VA = "0x1870848E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public Transform KMFNFBJKPCL
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x7084930", Offset = "0x7083B30", VA = "0x187084930", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public HCLDEAEBCAG ILJHJDAPGHI
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x8FD6F0", Offset = "0x8FC8F0", VA = "0x1808FD6F0", Slot = "12")]
			get
			{
				return default(HCLDEAEBCAG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7083800", Offset = "0x7082A00", VA = "0x187083800")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7084480", Offset = "0x7083680", VA = "0x187084480")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7084390", Offset = "0x7083590", VA = "0x187084390", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7084480", Offset = "0x7083680", VA = "0x187084480", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7083870", Offset = "0x7082A70", VA = "0x187083870", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7084530", Offset = "0x7083730", VA = "0x187084530")]
		public void UpdatePostIKAnimControllers(float NIMHBLEHMBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x70843F0", Offset = "0x70835F0", VA = "0x1870843F0")]
		private void MNILAAECDCN(GameObject LCACGJDNDHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7084020", Offset = "0x7083220", VA = "0x187084020")]
		private NMHKDIBMOMB INDGJDIFAOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7083BA0", Offset = "0x7082DA0", VA = "0x187083BA0")]
		private GJBMEOPCGOD IHPNDAJDNLB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7083D90", Offset = "0x7082F90", VA = "0x187083D90")]
		private GNMICAIAGAB IIEDPGIELCN(IDCPFOBPGID PNEKCCKLKHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7084610", Offset = "0x7083810", VA = "0x187084610")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class KAIPFDNNBPO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private MaterialPropertyBlock GHGBIINMNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	public Color? IPCEJLJNKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	public Color? ACMCMEHKKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	public Color? JPHACFLBAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	public Color? IFAOPBKGCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	public Color MNPBOAHCBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	public Color PIFFADBDPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	public Color NCFJLDFNIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	public Texture2D HOJBHFBKKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	public Texture2D JIDECIDHNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private Dictionary<PHJLNIBFOFL, int> ANBIFCFMHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private IGJDKHOAHLJ[] NKCGIGFACIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private OPICNNMDPNH[] BJPEAFCILKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	public Vector4[] MJCLCBNMPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	public Vector4[] EEIDHFGFINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	public Vector4[] NJPNOKKEDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	public Vector4[] FEIOBHBDDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public Vector4[] NEEANACKNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public Vector4[] PFNPEPEJEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private List<Texture2D> KKAHMJKHLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private Vector4[] GAJAAHKKONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private List<Texture2D> OHPANCCOJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private float[] LBFANAIODPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private Vector4[] PCBILDBOKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private float[] GDFOKOAKHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public float[] EABGGHAHLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private List<Texture2D> FMJJIABHPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private float[] HEGJAGJJKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private List<Texture2D> EKCOJPJFKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private Vector4[] HBGGBLAILGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private float[] HEKMEAEMAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private Vector4[] ALLKAFPHBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public float[] IFBIIMMNMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public Texture2DArray PPDAEPDJINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public Texture2DArray MBOBJBKNENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public Texture2DArray DFBJEHHPKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public Texture2DArray PIKKLICOJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private bool PMGBPMPIGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private int HCHJMLFJPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private Vector2? HEEHOHJEHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private TextureFormat HKJDKBLHCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private Vector2? PJADHPEBJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private TextureFormat IHLHFKGLJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private Vector2? ILHHGDHANFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private TextureFormat BAMNHNBKLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private Vector2? JOJBNBAOIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private TextureFormat DMOPEABFDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private bool CLAMDNBMMAC;

	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private static int AIDFPJNJALC;

	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private static int OGKBKMNLGMG;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static int AOOIPFIJNGP;

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static int DECGHPAOAOK;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static int HEDKOLHDFGE;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static int NBNNJIHHILH;

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private static int BBIBOHDHPNN;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private static int AGAJCFDIAGO;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static int OFIIIIJEKBG;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private static int JNAOBLAGHLG;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static int NKFKHDDBLGC;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static int AIOOHHAEBBE;

	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private static int LHAOJHKKLIC;

	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private static int BBBONLKOOIB;

	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private static int PJKHPFOPJFA;

	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private static int GBGMKAICECG;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static int ABOMOPEJHOO;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static int DCGEIJPKOCI;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static int ACPEEGMEHJD;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static int GEOCMKMNAHD;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x708FA80", Offset = "0x708EC80", VA = "0x18708FA80")]
	private KAIPFDNNBPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x708FF70", Offset = "0x708F170", VA = "0x18708FF70")]
	public KAIPFDNNBPO(Color KBIOGIKOPCG, Color JLJPCPGADHJ, Color HEHMFCCCADB, Color? NLCIJGPOMOJ, Color? LAOJOMBNECF, Color? MKCPLPKDFIK, Texture2D HMDDJCHKPIE, Texture2D MCMJNPICCBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x708F600", Offset = "0x708E800", VA = "0x18708F600")]
	internal int OEBGBKFIBGJ(Material LNMGIPPDFCH, IGJDKHOAHLJ JDFGBMEBLBG, OPICNNMDPNH HLAEBPPMKNO, IEPCDHHNEOA EFKLNALJCMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x708F570", Offset = "0x708E770", VA = "0x18708F570")]
	private int OEBGBKFIBGJ(PHJLNIBFOFL OFPBICPHALF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x708D4B0", Offset = "0x708C6B0", VA = "0x18708D4B0")]
	internal int BKOIICBECHB(Material LNMGIPPDFCH, Color HAHDIMOMHDM, Color INPGEEFCIGN, Color JOFFOJDMKPM, Color NCKLIGNHLEI, Color JLEFCANKBGF, Texture2D NDNFMBAIIIE, Vector4 IGGJNINKAGH, Texture2D EAMCDCEJLKN, Vector4 FNLBFEGADFH, float ICAOFCPBHDP, float OOCHNACNGBF, Texture2D ENMJEBMEJNC, Vector4 CILLGMFBFLL, float NHJKNBFAIJI, Texture2D EABAACGKMGN, Color JDOJAHDBEAG, Vector4 MMDEMCAEDIK, IGJDKHOAHLJ JDFGBMEBLBG, OPICNNMDPNH HLAEBPPMKNO, IEPCDHHNEOA EFKLNALJCMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x708F060", Offset = "0x708E260", VA = "0x18708F060")]
	private void ELPNAKDKLNN(List<Texture2D> KKAHMJKHLNP, [Out] Texture2DArray CDPACJJICPM, [Out] Texture2DArray GILCKBNJBJD, [Out] Texture2DArray FDMFCNEAPMH, [Out] Texture2DArray NAGOMMPDLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x708F420", Offset = "0x708E620", VA = "0x18708F420")]
	public void NIHMJCPBLCF(Shader INFDNDNEHHK, Renderer DELKJLDIJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x708E220", Offset = "0x708D420", VA = "0x18708E220")]
	private void EAMLNNMAGFA(Shader INFDNDNEHHK, Renderer DELKJLDIJIB, int JHIMEGKJMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x708F220", Offset = "0x708E420", VA = "0x18708F220")]
	private Color JLLJHLDKDEE(Color MICCJOLCJCG, IGJDKHOAHLJ LKKCGJELLIG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x708EF10", Offset = "0x708E110", VA = "0x18708EF10")]
	private Color ECLLLOAKHHH(Color OJAHBJINBOH, IGJDKHOAHLJ LKKCGJELLIG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x708E080", Offset = "0x708D280", VA = "0x18708E080")]
	private bool CHBJGKFMFPO(Texture2D JHNOAGGDJNO, OPICNNMDPNH CDLJPEHJDIB, [Out] Texture2D LBJPHCMHLOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x708D400", Offset = "0x708C600", VA = "0x18708D400")]
	private void AMECKFNGKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x708E1E0", Offset = "0x708D3E0", VA = "0x18708E1E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class FEGCLFEFMBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public readonly IEPCDHHNEOA GPNANDBELMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	protected bool LPPLPEPLPHL;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool EBNCPIJAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xB24780", Offset = "0xB23980", VA = "0x180B24780")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xB24BA0", Offset = "0xB23DA0", VA = "0x180B24BA0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool KMIHLGGPPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xB24E20", Offset = "0xB24020", VA = "0x180B24E20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xB24E10", Offset = "0xB24010", VA = "0x180B24E10")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public virtual LJLGCMOEKHG.AMEKCHAHPFE IPKPHEAMKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA3D4D0", Offset = "0xA3C6D0", VA = "0x180A3D4D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(LJLGCMOEKHG.AMEKCHAHPFE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xB32D40", Offset = "0xB31F40", VA = "0x180B32D40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool LKLIKDCBMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xADD730", Offset = "0xADC930", VA = "0x180ADD730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool IOKMMFHIADJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1D60F80", Offset = "0x1D60180", VA = "0x181D60F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool OIHJGAFEGEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x70897E0", Offset = "0x70889E0", VA = "0x1870897E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool CHPNOOJAMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x70897F0", Offset = "0x70889F0", VA = "0x1870897F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7089810", Offset = "0x7088A10", VA = "0x187089810")]
	protected FEGCLFEFMBJ(IEPCDHHNEOA PHMAKKFMMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract JABNAOPJDOK AEMHOBCALCP(List<ACEDPKMPOHF> JFMAEDKIGKN, List<ACEDPKMPOHF> CIEELAMJJPD);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract NABHEBDLNNE KCHNBCPNKCP(uint MPDJGCJPOLI, AvatarSkinnedMeshBoneOrderRemapsData AIPLCPJFOHL);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class GLLCFMOLLLM : EECAMBFLNGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private AvatarSkinAssetItem OPMGIBAMIJI;

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x708AC90", Offset = "0x7089E90", VA = "0x18708AC90")]
	public GLLCFMOLLLM(AvatarSkinAssetItem NCJCAIDGAGO, AvatarSkinAssetItem.HAGEHOINAJF AKGFJKOPKLG, IEPCDHHNEOA EFKLNALJCMF, [Optional] IFNONIKJIIN? KAIDKCOBJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x708AA10", Offset = "0x7089C10", VA = "0x18708AA10", Slot = "6")]
	public override JABNAOPJDOK AEMHOBCALCP(List<ACEDPKMPOHF> JFMAEDKIGKN, List<ACEDPKMPOHF> CIEELAMJJPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class EFIHJMFEPFB
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static readonly int[] LIJADPCOHAG;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static readonly int[] OMLJMNAIEHG;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public static int[] DJNFAGJHABP
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7088710", Offset = "0x7087910", VA = "0x187088710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7088820", Offset = "0x7087A20", VA = "0x187088820")]
	public static int[] PIFDDJCKPDM(bool NKPKJEEKIJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7088790", Offset = "0x7087990", VA = "0x187088790")]
	public static int JICAMMLJGPE(MICCOKKHGKO OOCEJLJKICN, bool NKPKJEEKIJE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7088760", Offset = "0x7087960", VA = "0x187088760")]
	private static int CAJDPPLCJBG(MICCOKKHGKO OOCEJLJKICN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7088770", Offset = "0x7087970", VA = "0x187088770")]
	private static int HNMAJMJGNGI(MICCOKKHGKO OOCEJLJKICN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class EAONKNKCHEJ
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class LENKJCPJLGD : IEnumerator<IOBGCLDPPJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private IOBGCLDPPJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		private IOBGCLDPPJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
		[DebuggerHidden]
		public LENKJCPJLGD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x1058820", Offset = "0x1057A20", VA = "0x181058820", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7090660", Offset = "0x708F860", VA = "0x187090660", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
	public static void HCHALMGOOEN(string BEHEHKFONGA, int MPDJGCJPOLI, long IGAODLEMLHD, long NOBGMGCHLCJ, long MBODJDBGCGJ, long BLLNOHDELDP, long BOFLEBMEINB, long CKIEKDIEEFF, long NPPOOKIOHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7087E70", Offset = "0x7087070", VA = "0x187087E70")]
	public static GFDHFLBBFKF LKEOLIEOKDB(JobHandle DKILGJCPNPG, bool NJMAAEIONLB, bool KFKDPBBLHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7087E00", Offset = "0x7087000", VA = "0x187087E00")]
	[IteratorStateMachine(typeof(LENKJCPJLGD))]
	private static IEnumerator<IOBGCLDPPJE> FOHJCPIOFML(JobHandle AINDMPLBNFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class HIKDHODMHHJ
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum GMBDCIHGOAN
	{
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		General,
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly int HBMHELEJLLC;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly int GCKLMOCDBCL;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly int MOLCBNNOHCI;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly int NPGLDCPIPIF;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public static readonly int MCDFAOJGBNK;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public static readonly int EKNMNOCKHHL;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public static readonly int LNPICHGNKPK;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public static readonly int NMLCDKOKDHK;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x708B6A0", Offset = "0x708A8A0", VA = "0x18708B6A0")]
	public static bool PMNDCLCJKON(Material HGJFBFIMOOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x708B5E0", Offset = "0x708A7E0", VA = "0x18708B5E0")]
	public static bool EHACLLDOILC(Material HGJFBFIMOOD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class EECAMBFLNGD : FEGCLFEFMBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class BHKEMFMPJGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public PDBMJMIDPNE<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public EECAMBFLNGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public BHKEMFMPJGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7086BC0", Offset = "0x7085DC0", VA = "0x187086BC0")]
		internal void MPFFEDJPLEO(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7086A80", Offset = "0x7085C80", VA = "0x187086A80")]
		internal void FHLJPACMBAJ(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	protected AvatarSkinAssetItem BDEGKNPFBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	protected Material[] NNEPLDPGKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	private readonly AvatarSkinAssetItem.HAGEHOINAJF IGGMNBKDILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private readonly AssetReference DNKPNBLABLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private readonly IFNONIKJIIN? LAJIIGJLBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private SkinnedMeshRenderer[] JOFJFGDBOGG;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override LJLGCMOEKHG.AMEKCHAHPFE IPKPHEAMKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA960C0", Offset = "0xA952C0", VA = "0x180A960C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(LJLGCMOEKHG.AMEKCHAHPFE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xB25E10", Offset = "0xB25010", VA = "0x180B25E10", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x70884D0", Offset = "0x70876D0", VA = "0x1870884D0")]
	public EECAMBFLNGD(AvatarSkinAssetItem.HAGEHOINAJF AKGFJKOPKLG, AssetReference DNNFMDPGEAD, Material DMEGNLNHDEI, IEPCDHHNEOA EFKLNALJCMF, LJLGCMOEKHG.AMEKCHAHPFE JGMICABELHA = (LJLGCMOEKHG.AMEKCHAHPFE)0, [Optional] IFNONIKJIIN? KAIDKCOBJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x70885F0", Offset = "0x70877F0", VA = "0x1870885F0")]
	public EECAMBFLNGD(AvatarSkinAssetItem.HAGEHOINAJF AKGFJKOPKLG, AssetReference DNNFMDPGEAD, Material DMEGNLNHDEI, LJLGCMOEKHG.AMEKCHAHPFE JGMICABELHA = (LJLGCMOEKHG.AMEKCHAHPFE)0, [Optional] IFNONIKJIIN? KAIDKCOBJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x7087F60", Offset = "0x7087160", VA = "0x187087F60", Slot = "6")]
	public override JABNAOPJDOK AEMHOBCALCP(List<ACEDPKMPOHF> JFMAEDKIGKN, List<ACEDPKMPOHF> CIEELAMJJPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7088190", Offset = "0x7087390", VA = "0x187088190", Slot = "7")]
	public override NABHEBDLNNE KCHNBCPNKCP(uint MPDJGCJPOLI, AvatarSkinnedMeshBoneOrderRemapsData AIPLCPJFOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x7088460", Offset = "0x7087660", VA = "0x187088460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x7088130", Offset = "0x7087330", VA = "0x187088130")]
	protected void EFMBIBGLAPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class AJMMPDICEBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private List<int> NNEBPNKCPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private List<HJHJPLPNFDM> LNNBCJKMICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	private HashSet<Transform> JANGCJMFNOH;

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x7081CB0", Offset = "0x7080EB0", VA = "0x187081CB0")]
	public static AJMMPDICEBG NPOMJCIJJGN(Transform EBJDGDIMGBD, Dictionary<Transform, OutfitType?> MBFGPGLELEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x70814D0", Offset = "0x70806D0", VA = "0x1870814D0")]
	private void EBMCIAFHAAI(Transform EBJDGDIMGBD, IEPCDHHNEOA EFKLNALJCMF, Dictionary<Transform, OutfitType?> MBFGPGLELEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7081B80", Offset = "0x7080D80", VA = "0x187081B80")]
	private void NMDKPJFJDHP(Transform DJNFEPPONBN, IEPCDHHNEOA EFKLNALJCMF, bool IALMFLAPOPC, OutfitType? JLMKKDGCFEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x7081790", Offset = "0x7080990", VA = "0x187081790")]
	public FDFGBIFFEPO HFEFNPDGFBM(HashSet<string> LPGDMHDHGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x7081E50", Offset = "0x7081050", VA = "0x187081E50")]
	public AJMMPDICEBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class FDFGBIFFEPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private List<HJHJPLPNFDM> LNNBCJKMICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private List<Matrix4x4> DFOGGFHCNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private Transform[] EIDFHBIFACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private Matrix4x4[] BADBOEBIGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private Dictionary<PEKOCLBPGKJ, int> GDAKNOJNANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private List<HBPHGLLCLKL> DLFINCGCLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private bool CDEECDHFBLP;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int BIMHEMDFFPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7089110", Offset = "0x7088310", VA = "0x187089110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Transform[] OMICMGAPCPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7088E30", Offset = "0x7088030", VA = "0x187088E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public Matrix4x4[] HHLFBJBHGKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x70890A0", Offset = "0x70882A0", VA = "0x1870890A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7089470", Offset = "0x7088670", VA = "0x187089470")]
	public void NMDKPJFJDHP(Transform DJNFEPPONBN, IEPCDHHNEOA EFKLNALJCMF, OutfitType? JLMKKDGCFEI, bool LLLOPCENCMK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7089150", Offset = "0x7088350", VA = "0x187089150")]
	private void NMDKPJFJDHP(Transform DJNFEPPONBN, IEPCDHHNEOA EFKLNALJCMF, OutfitType? JLMKKDGCFEI, bool LLLOPCENCMK, Matrix4x4 NJJPOLFFLMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7088A40", Offset = "0x7087C40", VA = "0x187088A40")]
	public int CBBBBIMJENA(PEKOCLBPGKJ OFPBICPHALF, bool BBMCEAMDOGB, [Optional] OutfitType? JLMKKDGCFEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7088FA0", Offset = "0x70881A0", VA = "0x187088FA0")]
	public int JIBAKKOGMHJ(IEPCDHHNEOA EFKLNALJCMF, [Optional] OutfitType? JLMKKDGCFEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7088D40", Offset = "0x7087F40", VA = "0x187088D40")]
	public void GLHHKKCBFHE(PEKOCLBPGKJ OFPBICPHALF, Matrix4x4 BHOBJABMFGO, bool BBMCEAMDOGB = false, [Optional] OutfitType? JLMKKDGCFEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7088BF0", Offset = "0x7087DF0", VA = "0x187088BF0")]
	public Matrix4x4 DGEMPPLJKBD(PEKOCLBPGKJ OFPBICPHALF, bool BBMCEAMDOGB, [Optional] OutfitType? JLMKKDGCFEI)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0xB35AF0", Offset = "0xB34CF0", VA = "0x180B35AF0")]
	public void HEJJFFKPHAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7089670", Offset = "0x7088870", VA = "0x187089670")]
	public FDFGBIFFEPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct PEKOCLBPGKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public readonly string GENEJHELIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public readonly IEPCDHHNEOA CHLOFLBFPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public readonly OutfitType? CHJEBNBMNKO;

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7091EC0", Offset = "0x70910C0", VA = "0x187091EC0")]
	public PEKOCLBPGKJ(string OJGJBMBMAND, IEPCDHHNEOA EFKLNALJCMF, [Optional] OutfitType? JLMKKDGCFEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x7091E10", Offset = "0x7091010", VA = "0x187091E10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7091CF0", Offset = "0x7090EF0", VA = "0x187091CF0")]
	public bool GJGFPDJPFKG(PEKOCLBPGKJ JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7091C50", Offset = "0x7090E50", VA = "0x187091C50", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7091DB0", Offset = "0x7090FB0", VA = "0x187091DB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct HBPHGLLCLKL : IEquatable<HBPHGLLCLKL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public readonly IEPCDHHNEOA CHLOFLBFPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public readonly OutfitType? FLEIHMOJODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public readonly int AGBHFODMOIN;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x708B5D0", Offset = "0x708A7D0", VA = "0x18708B5D0")]
	public HBPHGLLCLKL(IEPCDHHNEOA EFKLNALJCMF, int DJELMCFAPFE, [Optional] OutfitType? NMODIBBNLME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x708B510", Offset = "0x708A710", VA = "0x18708B510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x1EAF350", Offset = "0x1EAE550", VA = "0x181EAF350")]
	public bool NJDEBBOPIDG(IEPCDHHNEOA EFKLNALJCMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x708B490", Offset = "0x708A690", VA = "0x18708B490")]
	public bool HEMBEOGPIGJ(OutfitType? NMODIBBNLME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x708B3F0", Offset = "0x708A5F0", VA = "0x18708B3F0", Slot = "4")]
	public bool Equals(HBPHGLLCLKL JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x708B300", Offset = "0x708A500", VA = "0x18708B300", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x708B440", Offset = "0x708A640", VA = "0x18708B440", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct HJHJPLPNFDM : IEquatable<HJHJPLPNFDM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public readonly Transform CKODILNENNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public readonly bool CDMBNDCAGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public readonly IEPCDHHNEOA KFNKCNOJNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public readonly OutfitType? CHJEBNBMNKO;

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x708BCF0", Offset = "0x708AEF0", VA = "0x18708BCF0")]
	public HJHJPLPNFDM(Transform DJNFEPPONBN, bool IALMFLAPOPC, IEPCDHHNEOA IPOLINHFBND, [Optional] OutfitType? GHCEPKILKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x708BAE0", Offset = "0x708ACE0", VA = "0x18708BAE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x708B970", Offset = "0x708AB70", VA = "0x18708B970", Slot = "4")]
	public bool Equals(HJHJPLPNFDM JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x708B890", Offset = "0x708AA90", VA = "0x18708B890", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x708BA70", Offset = "0x708AC70", VA = "0x18708BA70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[ExecuteInEditMode]
	public class FitMeshHemisphereUpdater : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7089A40", Offset = "0x7088C40", VA = "0x187089A40")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface NKNNPHKCMFH
{
	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KOOCCCMKEPE(Mesh NNPLONBDKAB, Matrix4x4 MNFGEOLNMJL, byte[] PHPIBOALCEJ, bool GDOCGOAKHDP = false, LJLGCMOEKHG.AMEKCHAHPFE LELKOOJMGPA = (LJLGCMOEKHG.AMEKCHAHPFE)0, int LCDOBPCHHDL = -1, bool ANAJPMBMBOM = false);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GHKBHIGCKCP(Allocator NNHCNMKJHLF, COLMEPMMNCE LMIMJAKOIJA, byte NFOOJFKLJBN, [Optional] IList<int> OGOILJBJGHM, [Optional] IList<int> ICIBNIDDFKA);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public readonly struct EFLMECJLFOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public readonly GameObject MGMCBFEJDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private readonly AvatarItemMaterial HDMDHGCIFFD;

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x982390", Offset = "0x981590", VA = "0x180982390")]
	public EFLMECJLFOH(GameObject MGMCBFEJDFD, AvatarItemMaterial HDMDHGCIFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x70889B0", Offset = "0x7087BB0", VA = "0x1870889B0")]
	public void HIELHJECAEJ(Material HGJFBFIMOOD, int LMAPNAOMGHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class NCLBDFLGLJG : MIPACLKIBMJ<Task<(GameObject, AvatarItemMaterial)>, EFLMECJLFOH>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct GNBKFGCJMPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x708AD90", Offset = "0x7089F90", VA = "0x18708AD90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x708B290", Offset = "0x708A490", VA = "0x18708B290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private PDBMJMIDPNE<GameObject> ACEFDCJMLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private PDBMJMIDPNE<AvatarItemMaterial> EEMJCCCDBAF;

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7090D10", Offset = "0x708FF10", VA = "0x187090D10")]
	private NCLBDFLGLJG(Task<(GameObject, AvatarItemMaterial)> JPPEAAIELKB, PDBMJMIDPNE<GameObject> EPMCCLPIALK, PDBMJMIDPNE<AvatarItemMaterial> OCFDACCIPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7090900", Offset = "0x708FB00", VA = "0x187090900")]
	public static NCLBDFLGLJG LHPCDDMHIBB(AssetReference ODPCBCPAPJM, [Optional] AssetReference NBDCOKDCDBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x70906B0", Offset = "0x708F8B0", VA = "0x1870906B0", Slot = "11")]
	protected override EFLMECJLFOH BECGBOBPKIP(Task<(GameObject, AvatarItemMaterial)> GPJKMKGIEBN)
	{
		return default(EFLMECJLFOH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7090750", Offset = "0x708F950", VA = "0x187090750", Slot = "12")]
	protected override void DBEDJLLOLAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x70907D0", Offset = "0x708F9D0", VA = "0x1870907D0")]
	[AsyncStateMachine(typeof(GNBKFGCJMPM))]
	private static Task<(GameObject, AvatarItemMaterial)> FAHBGDFCDPF(Task<GameObject> EEDAKKFJHBF, Task<AvatarItemMaterial> CHGCKBEAHGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class JCJEGCLAHKJ
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class KPKACKBPMJP : MIPACLKIBMJ<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private PDBMJMIDPNE<MaterialMapAsset> AINDMPLBNFF;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x7090580", Offset = "0x708F780", VA = "0x187090580")]
		public KPKACKBPMJP(PDBMJMIDPNE<MaterialMapAsset> AINDMPLBNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x70900E0", Offset = "0x708F2E0", VA = "0x1870900E0", Slot = "11")]
		protected override Material[] BECGBOBPKIP(Task<MaterialMapAsset> JPPEAAIELKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x7090520", Offset = "0x708F720", VA = "0x187090520", Slot = "12")]
		protected override void DBEDJLLOLAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class FLCLLBNNNJK : MIPACLKIBMJ<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private List<PDBMJMIDPNE<Material>> MDDOOEMKCOM;

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x70899D0", Offset = "0x7088BD0", VA = "0x1870899D0")]
		public FLCLLBNNNJK(Task<Material[]> JPPEAAIELKB, List<PDBMJMIDPNE<Material>> MDDOOEMKCOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7089840", Offset = "0x7088A40", VA = "0x187089840", Slot = "11")]
		protected override Material[] BECGBOBPKIP(Task<Material[]> GPJKMKGIEBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7089890", Offset = "0x7088A90", VA = "0x187089890", Slot = "12")]
		protected override void DBEDJLLOLAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x708BD30", Offset = "0x708AF30", VA = "0x18708BD30")]
	public static PDBMJMIDPNE<Material[]> PIAHPOEMAOB(AssetReference[] PALIOKOPACL)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[DisallowMultipleComponent]
	public class PlayerAvatarDisplayBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public enum PBIMPLNFGGJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public enum ALBLKCKJHBN
		{
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public enum MPFOPKNJPKI : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			All,
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public struct DKMMHNODMEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public readonly Material JFIBOJKBAAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public readonly PBIMPLNFGGJ FCKANNJPAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public readonly ALBLKCKJHBN AIFJJKLINKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public readonly IEPCDHHNEOA CHLOFLBFPFJ;

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x7092320", Offset = "0x7091520", VA = "0x187092320")]
			public DKMMHNODMEA(Material HGJFBFIMOOD, PBIMPLNFGGJ JDFGBMEBLBG, ALBLKCKJHBN HLAEBPPMKNO, IEPCDHHNEOA EFKLNALJCMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x70A0CE0", Offset = "0x709FEE0", VA = "0x1870A0CE0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x7091FE0", Offset = "0x70911E0", VA = "0x187091FE0")]
			public bool GJGFPDJPFKG(DKMMHNODMEA JAINJPLCLDO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x70A0B60", Offset = "0x709FD60", VA = "0x1870A0B60", Slot = "0")]
			public override bool Equals(object LCACGJDNDHA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x70A0C40", Offset = "0x709FE40", VA = "0x1870A0C40", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		protected struct OKGDPFJOJDH : IComparable<OKGDPFJOJDH>, IEquatable<OKGDPFJOJDH>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public int HLIGGBABMOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			public PlayerAvatarDisplayBase OEJBHPKDIJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			public IList<KHDMLNGENAP> BEMNCDHNMPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public AvatarItemBodyType NBMGPKGHCBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public OGGLBJKMHFF FCMDPNNKLFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public bool AGJICBBEJAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public int[] OOPMJOFGEBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			public float JIAAJMHFFBM;

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x70A85E0", Offset = "0x70A77E0", VA = "0x1870A85E0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x70A8480", Offset = "0x70A7680", VA = "0x1870A8480", Slot = "4")]
			public int CompareTo(OKGDPFJOJDH JAINJPLCLDO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x70A84A0", Offset = "0x70A76A0", VA = "0x1870A84A0", Slot = "5")]
			public bool Equals(OKGDPFJOJDH JAINJPLCLDO)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		protected abstract class DEIICMBCECK
		{
			[Cpp2IlInjected.Token(Token = "0x200005A")]
			public class NEPHOEKGHDF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000346")]
				public readonly Mesh NFLDINCDCLL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000347")]
				public readonly Material[] FGNPJBKHNGD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000348")]
				public readonly Transform[] IKKGADFLNGC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000349")]
				public readonly Matrix4x4[] FBHFAIFHHGH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400034A")]
				public readonly Transform DEFDGCBIFMN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400034B")]
				public readonly bool FHJIEOPJBBN;

				[Cpp2IlInjected.Token(Token = "0x60002D0")]
				[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
				protected NEPHOEKGHDF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D1")]
				[Cpp2IlInjected.Address(RVA = "0x70A7970", Offset = "0x70A6B70", VA = "0x1870A7970")]
				public NEPHOEKGHDF(Mesh NNPLONBDKAB, Material[] MJBNMBMDNLF, bool BBPADOBKKPB, Transform[] OKAIFFGINHE, Transform JNBOOACOMEJ, Matrix4x4[] DALBJCMFONL)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D2")]
				[Cpp2IlInjected.Address(RVA = "0x70A7E20", Offset = "0x70A7020", VA = "0x1870A7E20")]
				private NEPHOEKGHDF(SkinnedMeshRenderer NDIOBNOFBPK, Material[] BGKFIGHGBFD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D3")]
				[Cpp2IlInjected.Address(RVA = "0x70A7EE0", Offset = "0x70A70E0", VA = "0x1870A7EE0")]
				private NEPHOEKGHDF(MeshRenderer ELMNJDJIJNG, Transform JNBOOACOMEJ, Material[] BGKFIGHGBFD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D4")]
				[Cpp2IlInjected.Address(RVA = "0x70A7640", Offset = "0x70A6840", VA = "0x1870A7640")]
				public static NEPHOEKGHDF AMAGPHNPJCJ(Renderer DELKJLDIJIB, Material[] BGKFIGHGBFD)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			public readonly IEPCDHHNEOA CHLOFLBFPFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			public readonly Transform MMADKKFEJGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public readonly bool AHMCEPBDKHC;

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public virtual bool EBNCPIJAJPI
			{
				[Cpp2IlInjected.Token(Token = "0x60002C9")]
				[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public virtual bool KMIHLGGPPLP
			{
				[Cpp2IlInjected.Token(Token = "0x60002CA")]
				[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public virtual LJLGCMOEKHG.AMEKCHAHPFE IPKPHEAMKOJ
			{
				[Cpp2IlInjected.Token(Token = "0x60002CB")]
				[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "6")]
				get
				{
					return default(LJLGCMOEKHG.AMEKCHAHPFE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public bool JMFBCEDBFIN
			{
				[Cpp2IlInjected.Token(Token = "0x60002CC")]
				[Cpp2IlInjected.Address(RVA = "0x70A0A70", Offset = "0x709FC70", VA = "0x1870A0A70")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x70A0A80", Offset = "0x709FC80", VA = "0x1870A0A80")]
			protected DEIICMBCECK(IEPCDHHNEOA EFKLNALJCMF, Transform HHJPLOMDPIB, bool NFFEAANKEIN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract JABNAOPJDOK AEMHOBCALCP(List<ACEDPKMPOHF> JFMAEDKIGKN, List<ACEDPKMPOHF> CIEELAMJJPD);

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract NEPHOEKGHDF KCHNBCPNKCP(int MPDJGCJPOLI, PlayerHandBones HEINBHACNJC);
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		protected class IHBPFLKMOIK : DEIICMBCECK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			protected readonly BodyPartLODs JOFJFGDBOGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			protected readonly Material[] NNEPLDPGKKJ;

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x70A2D10", Offset = "0x70A1F10", VA = "0x1870A2D10")]
			public IHBPFLKMOIK(IEPCDHHNEOA EFKLNALJCMF, BodyPartLODs AGJICNKMNHH, Material DMEGNLNHDEI, [Optional] Transform HHJPLOMDPIB, bool NFFEAANKEIN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x70A2A50", Offset = "0x70A1C50", VA = "0x1870A2A50", Slot = "7")]
			public override JABNAOPJDOK AEMHOBCALCP(List<ACEDPKMPOHF> JFMAEDKIGKN, List<ACEDPKMPOHF> CIEELAMJJPD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x70A2AE0", Offset = "0x70A1CE0", VA = "0x1870A2AE0", Slot = "8")]
			public override NEPHOEKGHDF KCHNBCPNKCP(int MPDJGCJPOLI, PlayerHandBones HEINBHACNJC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x70A2CA0", Offset = "0x70A1EA0", VA = "0x1870A2CA0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		protected class NPFKMGHCJPC : DEIICMBCECK
		{
			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public override bool EBNCPIJAJPI
			{
				[Cpp2IlInjected.Token(Token = "0x60002D9")]
				[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public override bool KMIHLGGPPLP
			{
				[Cpp2IlInjected.Token(Token = "0x60002DA")]
				[Cpp2IlInjected.Address(RVA = "0x70A8350", Offset = "0x70A7550", VA = "0x1870A8350", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public CADFEFPNNFM KPMGNGANLMN
			{
				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0x8F85D0", Offset = "0x8F77D0", VA = "0x1808F85D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60002DC")]
				[Cpp2IlInjected.Address(RVA = "0x8F85C0", Offset = "0x8F77C0", VA = "0x1808F85C0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x70A8410", Offset = "0x70A7610", VA = "0x1870A8410")]
			public NPFKMGHCJPC(IEPCDHHNEOA EFKLNALJCMF, Transform HHJPLOMDPIB, CADFEFPNNFM OGAAINFFODO, bool NFFEAANKEIN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x70A82C0", Offset = "0x70A74C0", VA = "0x1870A82C0", Slot = "7")]
			public override JABNAOPJDOK AEMHOBCALCP(List<ACEDPKMPOHF> JFMAEDKIGKN, List<ACEDPKMPOHF> CIEELAMJJPD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "8")]
			public override NEPHOEKGHDF KCHNBCPNKCP(int MPDJGCJPOLI, PlayerHandBones HEINBHACNJC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x70A83A0", Offset = "0x70A75A0", VA = "0x1870A83A0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public class GDCNNLBAEAL
		{
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			public enum IDJFENCAFOM
			{
				[Cpp2IlInjected.Token(Token = "0x400035F")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x4000360")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x4000361")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x4000362")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x4000363")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x4000364")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x4000365")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public static readonly int KJJAALONOIH;

			[Cpp2IlInjected.Token(Token = "0x4000350")]
			public static readonly int HJPJIAAAPMD;

			[Cpp2IlInjected.Token(Token = "0x4000351")]
			public static readonly int HKPCDMKCFGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			protected readonly IDCPFOBPGID PNEKCCKLKHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			protected readonly OGDOLKOFLFD BCBGEIINECI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			protected readonly Animator FGKFDBDNBLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			protected readonly Transform DFKCEALFKFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			protected readonly Vector3 LJAJGCDNGKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			protected readonly Transform OHPEOJHPKMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			protected readonly Vector3 PIIPNKKBFAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			protected bool JLFMBEPNPHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			protected GNMICAIAGAB KLGHPJGBMMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			protected bool AIJCBFEOPHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			protected float DIGAHKGBKBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			protected JLLOEEHENEE<FOPKOLANAGM> KNMHDCNEGMA;

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public GNMICAIAGAB HHEMHNINAIF
			{
				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0x8F2220", Offset = "0x8F1420", VA = "0x1808F2220")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0x8F2200", Offset = "0x8F1400", VA = "0x1808F2200")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public bool ELKHFMOGCIO
			{
				[Cpp2IlInjected.Token(Token = "0x60002E3")]
				[Cpp2IlInjected.Address(RVA = "0xA8D1A0", Offset = "0xA8C3A0", VA = "0x180A8D1A0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60002E4")]
				[Cpp2IlInjected.Address(RVA = "0x70A2010", Offset = "0x70A1210", VA = "0x1870A2010")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public bool GAOPGJNDJNG
			{
				[Cpp2IlInjected.Token(Token = "0x60002E5")]
				[Cpp2IlInjected.Address(RVA = "0x901960", Offset = "0x900B60", VA = "0x180901960")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60002E6")]
				[Cpp2IlInjected.Address(RVA = "0x70A1AD0", Offset = "0x70A0CD0", VA = "0x1870A1AD0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public float MMAIGNJLPLP
			{
				[Cpp2IlInjected.Token(Token = "0x60002E7")]
				[Cpp2IlInjected.Address(RVA = "0xB24E30", Offset = "0xB24030", VA = "0x180B24E30")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60002E8")]
				[Cpp2IlInjected.Address(RVA = "0x70A1DB0", Offset = "0x70A0FB0", VA = "0x1870A1DB0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public FOPKOLANAGM ABKDNJPAJDK
			{
				[Cpp2IlInjected.Token(Token = "0x60002E9")]
				[Cpp2IlInjected.Address(RVA = "0x70A1A90", Offset = "0x70A0C90", VA = "0x1870A1A90")]
				get
				{
					return default(FOPKOLANAGM);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x70A2210", Offset = "0x70A1410", VA = "0x1870A2210")]
			public bool PPMHMIOOEMA(FOPKOLANAGM MMCFKHLBHEN, object BCOHKLCJCPM, IDJFENCAFOM ENGJFBPJMAC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x70A1BA0", Offset = "0x70A0DA0", VA = "0x1870A1BA0")]
			public bool JLOHHPCDKLB(object BCOHKLCJCPM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x70A23D0", Offset = "0x70A15D0", VA = "0x1870A23D0")]
			protected GDCNNLBAEAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x70A2460", Offset = "0x70A1660", VA = "0x1870A2460")]
			public GDCNNLBAEAL(IDCPFOBPGID PNEKCCKLKHD, GNMICAIAGAB BMECJHKIIHA, Animator FGKFDBDNBLH, Transform DFKCEALFKFD, Transform OHPEOJHPKMK, Vector3 LJAJGCDNGKH, Vector3 PIIPNKKBFAN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x70A1CA0", Offset = "0x70A0EA0", VA = "0x1870A1CA0")]
			private void KFFALNCNGEP(ushort ODBBOLBBKHF, ushort ACPPGIELCDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x70A1730", Offset = "0x70A0930", VA = "0x1870A1730")]
			protected void ANPGBNKHAPJ(ushort ODBBOLBBKHF, ushort ACPPGIELCDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x70A1820", Offset = "0x70A0A20", VA = "0x1870A1820")]
			protected void BBILGCPMKGN(ushort ODBBOLBBKHF, ushort ACPPGIELCDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x70A20E0", Offset = "0x70A12E0", VA = "0x1870A20E0")]
			protected void PLEDEIDNANA(ushort ODBBOLBBKHF, ushort ACPPGIELCDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x70A1930", Offset = "0x70A0B30", VA = "0x1870A1930")]
			protected void DMKJPFDLGIM(ushort ODBBOLBBKHF, ushort ACPPGIELCDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x70A1D50", Offset = "0x70A0F50", VA = "0x1870A1D50")]
			protected void KGEFLNGOHPO(ushort ODBBOLBBKHF, ushort ACPPGIELCDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x70A1A40", Offset = "0x70A0C40", VA = "0x1870A1A40")]
			protected void GMKJMKALBCN(ushort ODBBOLBBKHF, ushort ACPPGIELCDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x70A18E0", Offset = "0x70A0AE0", VA = "0x1870A18E0")]
			protected void BGHNFOJJPBI(ushort ODBBOLBBKHF, ushort ACPPGIELCDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x70A1EF0", Offset = "0x70A10F0", VA = "0x1870A1EF0")]
			protected void NAAILNNMNEL(ushort ODBBOLBBKHF, ushort ACPPGIELCDO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public class MEHEIMELKAK : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			public const int GDMLIBNIFPA = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			protected MaterialPropertyBlock GHGBIINMNJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			public Color? IPCEJLJNKDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public Color? JPHACFLBAAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public Color? IFAOPBKGCCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public Color MNPBOAHCBEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			public Color PIFFADBDPNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public Color NCFJLDFNIMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			public Texture2D HOJBHFBKKGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			public Texture2D JIDECIDHNFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			protected Dictionary<DKMMHNODMEA, int> ANBIFCFMHAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			protected PBIMPLNFGGJ[] NKCGIGFACIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			public Vector4[] MJCLCBNMPEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public Vector4[] EEIDHFGFINE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			public Vector4[] NJPNOKKEDJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public Vector4[] FEIOBHBDDAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public Vector4[] NEEANACKNLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public Vector4[] PFNPEPEJEDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			protected List<Texture2D> KKAHMJKHLNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			protected Vector4[] GAJAAHKKONK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			protected List<Texture2D> OHPANCCOJAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			protected float[] LBFANAIODPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			protected Vector4[] PCBILDBOKFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			protected float[] GDFOKOAKHHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			public float[] EABGGHAHLCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			protected List<Texture2D> FMJJIABHPKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			protected float[] HEGJAGJJKHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			protected List<Texture2D> EKCOJPJFKJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			protected Vector4[] HBGGBLAILGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			protected float[] HEKMEAEMAHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			protected Vector4[] ALLKAFPHBGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public float[] IFBIIMMNMLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public Texture2DArray PPDAEPDJINH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			public Texture2DArray MBOBJBKNENC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public Texture2DArray DFBJEHHPKNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public Texture2DArray PIKKLICOJJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			protected bool PMGBPMPIGKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			protected int HCHJMLFJPKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			protected Vector2? HEEHOHJEHKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			protected TextureFormat HKJDKBLHCKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			protected Vector2? PJADHPEBJEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			protected TextureFormat IHLHFKGLJHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			protected Vector2? ILHHGDHANFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			protected TextureFormat BAMNHNBKLAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			protected Vector2? JOJBNBAOIEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			protected TextureFormat DMOPEABFDID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			protected bool CLAMDNBMMAC;

			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected static int AIDFPJNJALC;

			[Cpp2IlInjected.Token(Token = "0x4000396")]
			protected static int OGKBKMNLGMG;

			[Cpp2IlInjected.Token(Token = "0x4000397")]
			protected static int AOOIPFIJNGP;

			[Cpp2IlInjected.Token(Token = "0x4000398")]
			protected static int DECGHPAOAOK;

			[Cpp2IlInjected.Token(Token = "0x4000399")]
			protected static int HEDKOLHDFGE;

			[Cpp2IlInjected.Token(Token = "0x400039A")]
			protected static int NBNNJIHHILH;

			[Cpp2IlInjected.Token(Token = "0x400039B")]
			protected static int BBIBOHDHPNN;

			[Cpp2IlInjected.Token(Token = "0x400039C")]
			protected static int AGAJCFDIAGO;

			[Cpp2IlInjected.Token(Token = "0x400039D")]
			protected static int OFIIIIJEKBG;

			[Cpp2IlInjected.Token(Token = "0x400039E")]
			protected static int JNAOBLAGHLG;

			[Cpp2IlInjected.Token(Token = "0x400039F")]
			protected static int NKFKHDDBLGC;

			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			protected static int AIOOHHAEBBE;

			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			protected static int LHAOJHKKLIC;

			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			protected static int BBBONLKOOIB;

			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			protected static int PJKHPFOPJFA;

			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			protected static int GBGMKAICECG;

			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			protected static int ABOMOPEJHOO;

			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected static int DCGEIJPKOCI;

			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected static int ACPEEGMEHJD;

			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected static int GEOCMKMNAHD;

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x70A60E0", Offset = "0x70A52E0", VA = "0x1870A60E0")]
			protected MEHEIMELKAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x70A6050", Offset = "0x70A5250", VA = "0x1870A6050")]
			public MEHEIMELKAK(Color KBIOGIKOPCG, Color JLJPCPGADHJ, Color HEHMFCCCADB, Color? NLCIJGPOMOJ, Color? LAOJOMBNECF, Color? MKCPLPKDFIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x70A5B40", Offset = "0x70A4D40", VA = "0x1870A5B40")]
			public int OEBGBKFIBGJ(Material LNMGIPPDFCH, PBIMPLNFGGJ JDFGBMEBLBG, ALBLKCKJHBN HLAEBPPMKNO, IEPCDHHNEOA EFKLNALJCMF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x70A5C30", Offset = "0x70A4E30", VA = "0x1870A5C30")]
			public int OEBGBKFIBGJ(DKMMHNODMEA OFPBICPHALF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x70A3CC0", Offset = "0x70A2EC0", VA = "0x1870A3CC0")]
			public int BKOIICBECHB(Material LNMGIPPDFCH, Color HAHDIMOMHDM, Color INPGEEFCIGN, Color JOFFOJDMKPM, Color NCKLIGNHLEI, Color JLEFCANKBGF, Texture2D NDNFMBAIIIE, Vector4 IGGJNINKAGH, Texture2D EAMCDCEJLKN, Vector4 FNLBFEGADFH, float ICAOFCPBHDP, float OOCHNACNGBF, Texture2D ENMJEBMEJNC, Vector4 CILLGMFBFLL, float NHJKNBFAIJI, Texture2D EABAACGKMGN, float KOPOLPAGCLG, Color JDOJAHDBEAG, Vector4 MMDEMCAEDIK, PBIMPLNFGGJ JDFGBMEBLBG, ALBLKCKJHBN HLAEBPPMKNO, IEPCDHHNEOA EFKLNALJCMF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x70A5520", Offset = "0x70A4720", VA = "0x1870A5520")]
			protected void ELPNAKDKLNN([Out] Texture2DArray CDPACJJICPM, [Out] Texture2DArray GILCKBNJBJD, [Out] Texture2DArray FDMFCNEAPMH, [Out] Texture2DArray NAGOMMPDLEP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x70A58D0", Offset = "0x70A4AD0", VA = "0x1870A58D0")]
			public void NIHMJCPBLCF(PlayerAvatarDisplayBase DECPOPDCEKK, Renderer DELKJLDIJIB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x70A4A00", Offset = "0x70A3C00", VA = "0x1870A4A00")]
			protected void EAMLNNMAGFA(PlayerAvatarDisplayBase DECPOPDCEKK, Renderer DELKJLDIJIB, int JHIMEGKJMMA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x70A56E0", Offset = "0x70A48E0", VA = "0x1870A56E0")]
			private Color JLLJHLDKDEE(Color MICCJOLCJCG, PBIMPLNFGGJ LKKCGJELLIG)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x70A3AE0", Offset = "0x70A2CE0", VA = "0x1870A3AE0")]
			private Color ABDLDDDJLJB(Color HOPLCMDPMCB, PBIMPLNFGGJ LKKCGJELLIG)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x70A3C30", Offset = "0x70A2E30", VA = "0x1870A3C30")]
			protected void AMECKFNGKPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x70A49C0", Offset = "0x70A3BC0", VA = "0x1870A49C0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x70AE980", Offset = "0x70ADB80", VA = "0x1870AE980")]
			public void OJFGKMCEEMO(IEPCDHHNEOA EFKLNALJCMF, [Out] Transform DONMCNODAED, [Out] Transform[] OKAIFFGINHE)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000063")]
		[CompilerGenerated]
		private sealed class BBPEPJOCKMN : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0xC45340", Offset = "0xC44540", VA = "0x180C45340")]
			[DebuggerHidden]
			public BBPEPJOCKMN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x70A0240", Offset = "0x709F440", VA = "0x1870A0240", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x70A04C0", Offset = "0x709F6C0", VA = "0x1870A04C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x70A0410", Offset = "0x709F610", VA = "0x1870A0410", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x70A0410", Offset = "0x709F610", VA = "0x1870A0410", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class CNCJPJDKKOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public CNCJPJDKKOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x70A0990", Offset = "0x709FB90", VA = "0x1870A0990")]
			internal bool KMPFEBFGIOF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class IPCJHNJFCHO : IEnumerator<IOBGCLDPPJE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			private IOBGCLDPPJE <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			private IOBGCLDPPJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600031B")]
				[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
			[DebuggerHidden]
			public IPCJHNJFCHO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x70A2E10", Offset = "0x70A2010", VA = "0x1870A2E10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x70A31F0", Offset = "0x70A23F0", VA = "0x1870A31F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private struct NEDIFBHOKCB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public FBHKJALFDHL avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x70A6F20", Offset = "0x70A6120", VA = "0x1870A6F20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x70A75E0", Offset = "0x70A67E0", VA = "0x1870A75E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class DNNLNHABMGL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public DNNLNHABMGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x70A1420", Offset = "0x70A0620", VA = "0x1870A1420")]
			internal bool CGKJGNGKPKP(KHDMLNGENAP selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class OPIPOGINLDJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			public Func<OABBPFFKNOC<Dictionary<string, PDBMJMIDPNE<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public OPIPOGINLDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x70A87E0", Offset = "0x70A79E0", VA = "0x1870A87E0")]
			internal (FMIMELHPEBJ, OABBPFFKNOC<Dictionary<string, PDBMJMIDPNE<Texture2D>>>) GFBEKKKJFGP(Dictionary<string, JOEMMHDGFBD> avatarItems)
			{
				return default((FMIMELHPEBJ, OABBPFFKNOC<Dictionary<string, PDBMJMIDPNE<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x70A8730", Offset = "0x70A7930", VA = "0x1870A8730")]
			internal OABBPFFKNOC<Dictionary<string, PDBMJMIDPNE<Texture2D>>> ALHBPIFCJBF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x70A87A0", Offset = "0x70A79A0", VA = "0x1870A87A0")]
			internal void DNHLIBGNMNG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class FJJJCNNPGAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public FJJJCNNPGAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x70A1450", Offset = "0x70A0650", VA = "0x1870A1450")]
			internal bool IGAOMLMPEDO(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private struct MGBONLMIKIG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x70A65A0", Offset = "0x70A57A0", VA = "0x1870A65A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x70A6770", Offset = "0x70A5970", VA = "0x1870A6770", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		protected static readonly int IGCOOOEMNDA;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		protected static readonly int JKEEOFJGBHG;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		protected static readonly int MHMPDNAPMBG;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		protected static readonly int BAIAGNDBEIO;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		protected static readonly int DAPPGAABOFP;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		protected static readonly int NLMGJOBIHLJ;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		protected static readonly int[] GNDKGJLHLNI;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		protected static readonly int[] CJMAJMAKCJG;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		protected static readonly int[] KAHMAFPCJME;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		protected static readonly int[] MMGPCCPIMBK;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		protected static readonly int[] EIHNJMFMMCK;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		protected static readonly int[] JDGLDKPCPHB;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		protected static List<PlayerAvatarDisplayBase> LOKMFIKAKHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		protected LHLBFAAIMNN KBENPOKAHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		protected bool NKECAHDILHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		protected bool HHJEIOEAIGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		protected static readonly int[] IFDNEDLGIIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		protected Dictionary<DKMMHNODMEA, Material> LFABFCMJKHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		protected Dictionary<DKMMHNODMEA, Material> NDDBDMNONHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		[SerializeField]
		public Transform remoteMeshBase;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		protected Material DKGBOBCKLAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		protected NMHKDIBMOMB NPCKLMBMOHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private GNMICAIAGAB BMMDIMPJKCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private GNMICAIAGAB APJOHHDOMAA;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		protected Material FNIAENBLEOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		[SerializeField]
		public Transform hemisphereBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		protected FitMeshHemisphere CIGIFOPKOFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		protected bool MAMDHFPMJPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		protected APGOBKHECLL MNDLMAHMEPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		protected bool DOILFPAEHJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		protected AnchorParamsRestrictions BIHBEFIJMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		protected bool MFEILPPKJII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		protected Transform PGGDKIAJGPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		protected bool JGLDCPNOHEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x199")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		protected bool JJJABCLMJJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		protected Vector3 BPKEONBDIPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		protected Quaternion ANLLKACFMLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		protected Vector2 FIDPEOHHHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		protected FitMeshHemisphere MIMFNOKPFOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		[SerializeField]
		[PJAPKCLJNLP(FFILGMALDDB.SelfAndChildren, false, false, false)]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		protected Collider[] ELANAGMAKAO;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		protected Collider[] PIBKEAKKAFJ;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		protected GDCNNLBAEAL[] EJMPGOIAOFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public Dictionary<Renderer, MEHEIMELKAK> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected Dictionary<Renderer, MEHEIMELKAK> JALHMGCDLLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected AJMMPDICEBG ANNBJCACGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		protected FMIMELHPEBJ NPDEAJJAHMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public MICCOKKHGKO DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		protected int MMBPHBCOMKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		protected JLLOEEHENEE<OGDOLKOFLFD> KNMHDCNEGMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		protected bool MPHADNCDBFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		protected Dictionary<KHDMLNGENAP, List<DKMMHNODMEA>> CBKCMEBEJJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		protected Dictionary<KHDMLNGENAP, List<DKMMHNODMEA>> DPABHMHCFMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		protected readonly Dictionary<string, PDBMJMIDPNE<Texture2D>> MCCHMLHBHCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		protected readonly Dictionary<string, PDBMJMIDPNE<Texture2D>> OOLKMKDODJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		protected bool DBEIHNAOAJE;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		protected static int FBEOHBEFPME;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		protected static List<OKGDPFJOJDH> OCDPKDJAOMM;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		protected static List<OKGDPFJOJDH> LJOHJCJMBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		protected static GFDHFLBBFKF LIHPONMLJFE;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		protected static bool PNFJEFGCEOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		protected Color? JDAFAGONMAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		protected bool HCFKOGEBEIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		protected Color HNLAIAFKOOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		protected Color HKKNEAOGDNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		protected Color PEKEMPFENCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		protected AvatarHairPattern NGOBDJAGDNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		protected CADFEFPNNFM EKKGOCIKDCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		protected Color DHJLFCEOHPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		protected Color MMOMGHLHKEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		protected AvatarHairPattern CINHOEOMEHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected CADFEFPNNFM EPEKHOJKNCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		protected CADFEFPNNFM LDHFKICECND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected Color FNMFGDBJDFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private AdditionalFeetData IMKAPHFAELA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		protected KHDMLNGENAP? LBBAFJDFNCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected Texture GLGJFAOMLJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected Color AIAIGJBJKFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected readonly IList<KHDMLNGENAP> MGKCNFPPDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		protected readonly IList<KHDMLNGENAP> MKGCINIGNJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private AvatarItemBodyType DJBGMINBDAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B1")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected MPFOPKNJPKI BEBIFBHAMIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected int[] FIGMFKDDPOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected bool AIGGJEMMILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected int[] AHEJFFFAHFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected bool ILKEBOJKJDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		protected AHOOBEAGJBG BLPPCDOKKPH;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string HKBIKFBOKNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x8F5490", Offset = "0x8F4690", VA = "0x1808F5490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public bool FKJNCFGJAIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0xABD7A0", Offset = "0xABC9A0", VA = "0x180ABD7A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xB35480", Offset = "0xB34680", VA = "0x180B35480")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool HBPCCECPBAK
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool BEOPOBGHHIG
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x709EEA0", Offset = "0x709E0A0", VA = "0x18709EEA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual bool IHEIBBLIMOB
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual bool BPEFAFLOHCO
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual bool KJDBJHLACHA
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public NMHKDIBMOMB HHDBNCMIBPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x963E00", Offset = "0x963000", VA = "0x180963E00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x709F480", Offset = "0x709E680", VA = "0x18709F480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public GNMICAIAGAB MGLKMEPCKND
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x997930", Offset = "0x996B30", VA = "0x180997930")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x709F7D0", Offset = "0x709E9D0", VA = "0x18709F7D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public GNMICAIAGAB EJEPJAMKBFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x966400", Offset = "0x965600", VA = "0x180966400")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x709FA80", Offset = "0x709EC80", VA = "0x18709FA80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected Material IMNHPNLHDEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x7095730", Offset = "0x7094930", VA = "0x187095730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		protected Material EMIEHNGJAML
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x70930F0", Offset = "0x70922F0", VA = "0x1870930F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool KHFCFGDPDLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x993820", Offset = "0x992A20", VA = "0x180993820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public PlayerFacialAnimatorBase JHPLNNAEIMH
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x994E70", Offset = "0x994070", VA = "0x180994E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public GDCNNLBAEAL[] BLONOLMGGPB
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x709EA60", Offset = "0x709DC60", VA = "0x18709EA60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public GDCNNLBAEAL FABMNIDHGBF
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x709F0A0", Offset = "0x709E2A0", VA = "0x18709F0A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public GDCNNLBAEAL NNBNLFPGPCH
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x709F0D0", Offset = "0x709E2D0", VA = "0x18709F0D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public Mesh BLIBJIMPBHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0xC70BA0", Offset = "0xC6FDA0", VA = "0x180C70BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected AJMMPDICEBG PJCOCNAICPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x7097C70", Offset = "0x7096E70", VA = "0x187097C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected FMIMELHPEBJ AOHDFEJEAEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0xC70BC0", Offset = "0xC6FDC0", VA = "0x180C70BC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x70983B0", Offset = "0x70975B0", VA = "0x1870983B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected bool KFKDPBBLHMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool BHBLMFBIOMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x709F090", Offset = "0x709E290", VA = "0x18709F090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public int BGLFOPNBGJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x1F52050", Offset = "0x1F51250", VA = "0x181F52050")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x709F9E0", Offset = "0x709EBE0", VA = "0x18709F9E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		protected virtual bool EPECILIFHOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		protected virtual int[] BNDIMBFOIOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x709AAD0", Offset = "0x7099CD0", VA = "0x18709AAD0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		protected bool LECIIONCGCP
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x7094DF0", Offset = "0x7093FF0", VA = "0x187094DF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		protected static bool FONBCJJCGID
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool FDGMGDNIBDN
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xFED220", Offset = "0xFEC420", VA = "0x180FED220")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x709FC90", Offset = "0x709EE90", VA = "0x18709FC90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public IEnumerable<SkinnedMeshRenderer> EEPCIOMEDKB
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x709E930", Offset = "0x709DB30", VA = "0x18709E930")]
			[IteratorStateMachine(typeof(BBPEPJOCKMN))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public bool EHPNJBGMJGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0xFED730", Offset = "0xFEC930", VA = "0x180FED730")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0xFED240", Offset = "0xFEC440", VA = "0x180FED240")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public HCLDEAEBCAG LAIMAGFGHHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x709E9B0", Offset = "0x709DBB0", VA = "0x18709E9B0")]
			get
			{
				return default(HCLDEAEBCAG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public static bool JNDCOMDLEBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x709EE10", Offset = "0x709E010", VA = "0x18709EE10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected static GFDHFLBBFKF JBEPAODLCKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x7096120", Offset = "0x7095320", VA = "0x187096120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x7098F40", Offset = "0x7098140", VA = "0x187098F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		protected Color JPHACFLBAAE
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x70989C0", Offset = "0x7097BC0", VA = "0x1870989C0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		protected Color IFAOPBKGCCG
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x7095520", Offset = "0x7094720", VA = "0x187095520")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		protected Texture2D JKKOEDJBKAN
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x7098580", Offset = "0x7097780", VA = "0x187098580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected Color MNPBOAHCBEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x70972D0", Offset = "0x70964D0", VA = "0x1870972D0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected Color PIFFADBDPNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x709A400", Offset = "0x7099600", VA = "0x18709A400")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public CADFEFPNNFM GDOPIFMHGGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x709EA20", Offset = "0x709DC20", VA = "0x18709EA20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected Texture2D PCHCHLLOFJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x7098820", Offset = "0x7097A20", VA = "0x187098820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public float OBPOKHJAKLK
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x709EA40", Offset = "0x709DC40", VA = "0x18709EA40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public float IPICHLBGHLM
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x709EE80", Offset = "0x709E080", VA = "0x18709EE80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool CONNCOADMIF
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x709EA10", Offset = "0x709DC10", VA = "0x18709EA10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x709F260", Offset = "0x709E460", VA = "0x18709F260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action HJJDAOAMFBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x709E7D0", Offset = "0x709D9D0", VA = "0x18709E7D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x709F100", Offset = "0x709E300", VA = "0x18709F100")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<IDCPFOBPGID, FOPKOLANAGM> PEHBKJBKGAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x709E870", Offset = "0x709DA70", VA = "0x18709E870")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x709F1A0", Offset = "0x709E3A0", VA = "0x18709F1A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x709B780", Offset = "0x709A980", VA = "0x18709B780")]
		public bool SetDeformation(bool NKECAHDILHL, bool HHJEIOEAIGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7094A20", Offset = "0x7093C20", VA = "0x187094A20")]
		protected static Material DAIKOAOFAFF(Dictionary<DKMMHNODMEA, Material> JDONFHJOCLP, Material JGGNIKJBDOL, PBIMPLNFGGJ JDFGBMEBLBG, ALBLKCKJHBN HLAEBPPMKNO, IEPCDHHNEOA EFKLNALJCMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x709A9B0", Offset = "0x7099BB0", VA = "0x18709A9B0")]
		protected void PHGHILEAKNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x70979D0", Offset = "0x7096BD0", VA = "0x1870979D0")]
		protected bool HLIBAPLMFJE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7094B80", Offset = "0x7093D80", VA = "0x187094B80")]
		protected void DCDOKKJAFAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7097320", Offset = "0x7096520", VA = "0x187097320", Slot = "10")]
		protected virtual void GLOCGOOFOMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7099E20", Offset = "0x7099020", VA = "0x187099E20")]
		public int MeshesAtLODCount(int BPIKFBPENJK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x7093E40", Offset = "0x7093040", VA = "0x187093E40")]
		protected static void BPIAOIAALKE(Dictionary<KHDMLNGENAP, List<DKMMHNODMEA>> FICGKNGGGJP, DEIICMBCECK PIHCLJNDGBL, Material JGGNIKJBDOL, PBIMPLNFGGJ LKKCGJELLIG, ALBLKCKJHBN CDLJPEHJDIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7092FD0", Offset = "0x70921D0", VA = "0x187092FD0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x7095C40", Offset = "0x7094E40", VA = "0x187095C40")]
		protected void EMKOIILGNBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x709A720", Offset = "0x7099920", VA = "0x18709A720")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "11")]
		protected virtual void FMEMIFOLHBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7098A10", Offset = "0x7097C10", VA = "0x187098A10")]
		protected static void LCMHCBOIPKG(List<Material> KOLHPDGBHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x70931E0", Offset = "0x70923E0", VA = "0x1870931E0")]
		protected static void BCOGCLFGALN(Dictionary<DKMMHNODMEA, Material> JDONFHJOCLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x7098180", Offset = "0x7097380", VA = "0x187098180")]
		protected static void IFBAKBIBDHK(Dictionary<Renderer, MEHEIMELKAK> GANIGEAGPJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7098670", Offset = "0x7097870", VA = "0x187098670")]
		protected void KDADOCHGNHP(SkinnedMeshRenderer[] BCBINIMBMLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7094260", Offset = "0x7093460", VA = "0x187094260")]
		protected void CPPGHDIMKLM(SkinnedMeshRenderer NDIOBNOFBPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7094190", Offset = "0x7093390", VA = "0x187094190")]
		protected void CPPGHDIMKLM(MeshRenderer ELMNJDJIJNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7093690", Offset = "0x7092890", VA = "0x187093690")]
		protected void BHGGOIKHBHH(List<ACEDPKMPOHF> IGEDBGGLODA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x70997A0", Offset = "0x70989A0", VA = "0x1870997A0")]
		protected void MIGEIKIDMDP(Dictionary<string, PDBMJMIDPNE<Texture2D>> FICGKNGGGJP, bool GOAJGOHCOJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x709A960", Offset = "0x7099B60", VA = "0x18709A960")]
		protected void PEJBGOOAMFG(Dictionary<KHDMLNGENAP, List<DKMMHNODMEA>> FICGKNGGGJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x7097400", Offset = "0x7096600", VA = "0x187097400")]
		public float GetHandOpenClosedAxis(IDCPFOBPGID PNEKCCKLKHD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x709C010", Offset = "0x709B210", VA = "0x18709C010")]
		public void SetHandOpenClosedAxis(IDCPFOBPGID PNEKCCKLKHD, float HKBBGHLOKGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x7097440", Offset = "0x7096640", VA = "0x187097440")]
		public FOPKOLANAGM GetHandVisualState(IDCPFOBPGID PNEKCCKLKHD)
		{
			return default(FOPKOLANAGM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7092710", Offset = "0x7091910", VA = "0x187092710")]
		public bool AddHandVisualStateToken(IDCPFOBPGID PNEKCCKLKHD, FOPKOLANAGM HEDNFLMPGFH, object BCOHKLCJCPM, GDCNNLBAEAL.IDJFENCAFOM ENGJFBPJMAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x709D720", Offset = "0x709C920", VA = "0x18709D720")]
		public void SetWatchHand(IDCPFOBPGID PNEKCCKLKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x709D7E0", Offset = "0x709C9E0", VA = "0x18709D7E0")]
		public void SetWatchHands(bool FHMKFIOLEBO, bool FAKPBGHGELI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x709AE40", Offset = "0x709A040", VA = "0x18709AE40")]
		public bool RemoveHandVisualStateToken(IDCPFOBPGID PNEKCCKLKHD, object BCOHKLCJCPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x70974C0", Offset = "0x70966C0", VA = "0x1870974C0")]
		public bool GetThumbsUpActive(IDCPFOBPGID PNEKCCKLKHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x709D1D0", Offset = "0x709C3D0", VA = "0x18709D1D0")]
		public void SetThumbsUpActive(IDCPFOBPGID PNEKCCKLKHD, bool MPOEIACHDEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x7097480", Offset = "0x7096680", VA = "0x187097480")]
		public bool GetHandshakeActive(IDCPFOBPGID PNEKCCKLKHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x709C060", Offset = "0x709B260", VA = "0x18709C060")]
		public void SetHandshakeActive(IDCPFOBPGID PNEKCCKLKHD, bool JAPGMMOPLNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x7097280", Offset = "0x7096480", VA = "0x187097280")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x7094900", Offset = "0x7093B00", VA = "0x187094900")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x709A1E0", Offset = "0x70993E0", VA = "0x18709A1E0")]
		protected static void NPGDKPBMFPG(PlayerAvatarDisplayBase NPDDKKFNKCJ, List<OKGDPFJOJDH> BFFPBHHGLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x709AB60", Offset = "0x7099D60", VA = "0x18709AB60")]
		public void Rebuild(bool FMOJIIJBEMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x7099920", Offset = "0x7098B20", VA = "0x187099920")]
		protected void MMICHNNHBFG(bool FMOJIIJBEMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x7099970", Offset = "0x7098B70", VA = "0x187099970", Slot = "12")]
		protected virtual JABNAOPJDOK MMICHNNHBFG(IList<KHDMLNGENAP> CPNKBKFAJEI, AvatarItemBodyType MABPOEJMPHA, bool KPDOMLMNACN, int[] GIECCHPGPON, bool FMOJIIJBEMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x7094E70", Offset = "0x7094070", VA = "0x187094E70")]
		protected static JABNAOPJDOK EAGJKMFMKNO(OKGDPFJOJDH DHOBIEIAKFA, List<OKGDPFJOJDH> BFFPBHHGLKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7098B90", Offset = "0x7097D90", VA = "0x187098B90")]
		[IteratorStateMachine(typeof(IPCJHNJFCHO))]
		protected static IEnumerator<IOBGCLDPPJE> LEANPLKLMHM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7096170", Offset = "0x7095370", VA = "0x187096170")]
		protected static OKGDPFJOJDH FMGNPFCKJNA(List<OKGDPFJOJDH> BFFPBHHGLKM)
		{
			return default(OKGDPFJOJDH);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x709B880", Offset = "0x709AA80", VA = "0x18709B880")]
		[AsyncStateMachine(typeof(NEDIFBHOKCB))]
		public Task SetFaceCustomizationSettings(FBHKJALFDHL NAHENMKCODH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7098450", Offset = "0x7097650", VA = "0x187098450")]
		public void InitializeFaceFeatures(AvatarConfiguration MIOEGDGMKKO, HCLDEAEBCAG EPMDONLDAKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x709CF30", Offset = "0x709C130", VA = "0x18709CF30")]
		public void SetTeamColors(Color? MKCPLPKDFIK, bool MLPPADPAPON, Color CJIJNOIAEDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x10A6ED0", Offset = "0x10A60D0", VA = "0x1810A6ED0")]
		private static void OLJPFDKAOBE(Material HGJFBFIMOOD, Color OMEFCJCOLII, params int[] NPAFKNGGCIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x10A54A0", Offset = "0x10A46A0", VA = "0x1810A54A0")]
		private static void AOHBLPLNNNO(Material HGJFBFIMOOD, Texture OMEFCJCOLII, params int[] NPAFKNGGCIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x70992B0", Offset = "0x70984B0", VA = "0x1870992B0")]
		protected void MFMMCFJLFIM(Material LINOANFJMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7097500", Offset = "0x7096700", VA = "0x187097500")]
		protected void HEAFHPOPEHG(Material LINOANFJMJJ, Color IDFOLNEBADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7099530", Offset = "0x7098730", VA = "0x187099530")]
		protected void MHPGAHKIOIC(Material LINOANFJMJJ, Color IDFOLNEBADM, Color BKGDPHCCGKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x70924F0", Offset = "0x70916F0", VA = "0x1870924F0")]
		protected void ALEJGMDBOON(Material LINOANFJMJJ, Texture2D AANEOIBPLCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7095570", Offset = "0x7094770", VA = "0x187095570")]
		protected void EHBMJOHPMFG(Material LINOANFJMJJ, Texture PBAOKMMFLEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7097620", Offset = "0x7096820", VA = "0x187097620")]
		protected void HFKFEKHKKJA(Action<MEHEIMELKAK> OOFOCDMJHDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7097780", Offset = "0x7096980", VA = "0x187097780")]
		protected void HLDOFEDHGKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7093340", Offset = "0x7092540", VA = "0x187093340")]
		protected void BEJENLMGLNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7099AC0", Offset = "0x7098CC0", VA = "0x187099AC0")]
		protected void MOECHEBLCHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7092A60", Offset = "0x7091C60", VA = "0x187092A60")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x709B200", Offset = "0x709A400", VA = "0x18709B200")]
		public void SetBeardPrimaryColor([Optional] Color? DAFFLBIMKHC, bool MOEGCOLJDOL = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x709B420", Offset = "0x709A620", VA = "0x18709B420")]
		public void SetBeardSecondaryColor([Optional] Color? DAFFLBIMKHC, bool MOEGCOLJDOL = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x709B0C0", Offset = "0x709A2C0", VA = "0x18709B0C0")]
		public void SetBeardPattern([Optional] AvatarHairPattern BOLLCAEHKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7095970", Offset = "0x7094B70", VA = "0x187095970")]
		private void EKBJGGIABIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7095680", Offset = "0x7094880", VA = "0x187095680")]
		private bool EHFGLLEBLMB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x709BBF0", Offset = "0x709ADF0", VA = "0x18709BBF0")]
		public void SetHairPrimaryColor([Optional] Color? KMFCHLKLPON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x709BE00", Offset = "0x709B000", VA = "0x18709BE00")]
		public void SetHairSecondaryColor([Optional] Color? KMFCHLKLPON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x709BAC0", Offset = "0x709ACC0", VA = "0x18709BAC0")]
		public void SetHairPattern([Optional] AvatarHairPattern BOLLCAEHKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x709ACE0", Offset = "0x7099EE0", VA = "0x18709ACE0")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7093500", Offset = "0x7092700", VA = "0x187093500")]
		private bool BEPPGGLICLH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x709CD70", Offset = "0x709BF70", VA = "0x18709CD70")]
		public void SetSkinColor(Color KBIOGIKOPCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x709D220", Offset = "0x709C420", VA = "0x18709D220")]
		public void SetUgcItemVisualOverrides(KHDMLNGENAP MEEDDNNMHAF, HCLDEAEBCAG EPMDONLDAKD, Texture BAHHCJFMOMH, Color FMCHHDGAONC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x70949D0", Offset = "0x7093BD0", VA = "0x1870949D0")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x709B980", Offset = "0x709AB80", VA = "0x18709B980")]
		public bool SetFaceShape(AvatarFaceShape CHGONPMGOCE, bool JOEIIMINHIH = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x709B640", Offset = "0x709A840", VA = "0x18709B640")]
		public bool SetBodyShape(AvatarBodyShape EMGCKCODKBK, bool JOEIIMINHIH = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x709D940", Offset = "0x709CB40", VA = "0x18709D940")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x709CCB0", Offset = "0x709BEB0", VA = "0x18709CCB0")]
		public bool SetHideEars(bool HMKPDGJEMBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x709CCA0", Offset = "0x709BEA0", VA = "0x18709CCA0")]
		public bool SetHelmetHair(LHLBFAAIMNN DCCCDFLJIBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x709C0B0", Offset = "0x709B2B0", VA = "0x18709C0B0")]
		public void SetHatAnchorParameters(APGOBKHECLL GABCIKPOKMA, bool BAGFKLKOKMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x709D8B0", Offset = "0x709CAB0", VA = "0x18709D8B0")]
		public void SetupDisplayLODs(MPFOPKNJPKI IJAOJLGHDNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7099EE0", Offset = "0x70990E0", VA = "0x187099EE0")]
		protected int[] NBBPHDMCHCP(MPFOPKNJPKI IJAOJLGHDNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x709CD10", Offset = "0x709BF10", VA = "0x18709CD10")]
		public void SetOutfitSelections(IList<KHDMLNGENAP> CPNKBKFAJEI, AvatarItemBodyType MABPOEJMPHA, bool FMOJIIJBEMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x709CD40", Offset = "0x709BF40", VA = "0x18709CD40")]
		public void SetOutfitSelections(IList<KHDMLNGENAP> CPNKBKFAJEI, AvatarItemBodyType MABPOEJMPHA, bool KPDOMLMNACN, bool FMOJIIJBEMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x709CCD0", Offset = "0x709BED0", VA = "0x18709CCD0")]
		public JABNAOPJDOK SetOutfitSelections(IList<KHDMLNGENAP> CPNKBKFAJEI, AvatarItemBodyType MABPOEJMPHA, MPFOPKNJPKI IJAOJLGHDNJ, bool KPDOMLMNACN, bool JOEIIMINHIH = false, bool FMOJIIJBEMF = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7098C10", Offset = "0x7097E10", VA = "0x187098C10")]
		private JABNAOPJDOK LIKFOHNCKKO(IList<KHDMLNGENAP> CPNKBKFAJEI, AvatarItemBodyType MABPOEJMPHA, bool KPDOMLMNACN, MPFOPKNJPKI IJAOJLGHDNJ, bool JOEIIMINHIH, bool FMOJIIJBEMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x70923F0", Offset = "0x70915F0", VA = "0x1870923F0")]
		protected int[] ADNHBNNDOJE(MPFOPKNJPKI IJAOJLGHDNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "13")]
		protected virtual FMIMELHPEBJ LLCOMAOIBEI(AvatarItemBodyType BMNGGJOPDFI, Dictionary<string, JOEMMHDGFBD> GHNFIKJLFAJ, Dictionary<string, PDBMJMIDPNE<Texture2D>> PNGAPDMGOMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7093B80", Offset = "0x7092D80", VA = "0x187093B80", Slot = "14")]
		protected virtual JABNAOPJDOK BMLDINBJLHI(IList<KHDMLNGENAP> CPNKBKFAJEI, AvatarItemBodyType MABPOEJMPHA, bool KPDOMLMNACN, int[] OOPMJOFGEBD, OGGLBJKMHFF JFIFBHMJIGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7097C90", Offset = "0x7096E90", VA = "0x187097C90", Slot = "15")]
		protected virtual JOEMMHDGFBD IDENCIPEMAF(CADFEFPNNFM OGAAINFFODO, AvatarItemBodyType BMNGGJOPDFI, IEPCDHHNEOA EFKLNALJCMF, JOEMMHDGFBD KJONHAJOJKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "16")]
		protected virtual JOEMMHDGFBD MDOHJBEPGDD(AvatarItemBodyType BMNGGJOPDFI, IEPCDHHNEOA EFKLNALJCMF, JOKPOGKIBGB DNIPNOKEENP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7097380", Offset = "0x7096580", VA = "0x187097380")]
		protected void GMDFMNEBJIG(FIEOFIFGBDG PEJOALMLKMM, LJLGCMOEKHG.AMEKCHAHPFE GEKHGNKFLNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x7097BF0", Offset = "0x7096DF0", VA = "0x187097BF0")]
		protected void HMDNLBMPDDK(FIEOFIFGBDG PEJOALMLKMM, LJLGCMOEKHG.AMEKCHAHPFE GEKHGNKFLNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xC9DDE0", Offset = "0xC9CFE0", VA = "0x180C9DDE0", Slot = "17")]
		protected virtual FIEOFIFGBDG JMJPCOIBBKD(FIEOFIFGBDG PEJOALMLKMM, HelmetHairStyle ELONBKNKDEG, bool EHAJDEEMLPG, AvatarItemBodyType MABPOEJMPHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7096230", Offset = "0x7095430", VA = "0x187096230")]
		protected FIEOFIFGBDG FOCGGIONPIN(IList<KHDMLNGENAP> CPNKBKFAJEI, AvatarItemBodyType MMIJBNIIENL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x70947E0", Offset = "0x70939E0", VA = "0x1870947E0")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x709A130", Offset = "0x7099330", VA = "0x18709A130")]
		protected void NLEAJNFIGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7093860", Offset = "0x7092A60", VA = "0x187093860")]
		protected void BJJDIFPLGBF(Transform PIEJAMPGHLK, IEnumerable<SkinnedMeshRenderer> CFAFMDICPIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x70982E0", Offset = "0x70974E0", VA = "0x1870982E0")]
		protected LJLGCMOEKHG.AMEKCHAHPFE IFFAJNFLFAH(LJLGCMOEKHG.AMEKCHAHPFE BDKIJJMMAPC, IEPCDHHNEOA PHMAKKFMMCE)
		{
			return default(LJLGCMOEKHG.AMEKCHAHPFE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x70979C0", Offset = "0x7096BC0", VA = "0x1870979C0")]
		protected void HLGNDMFNFIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x101B8C0", Offset = "0x101AAC0", VA = "0x18101B8C0")]
		protected void NPACKIOODOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x709A2F0", Offset = "0x70994F0", VA = "0x18709A2F0")]
		protected void OAAFMLEHILD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x70935C0", Offset = "0x70927C0", VA = "0x1870935C0")]
		[AsyncStateMachine(typeof(MGBONLMIKIG))]
		protected Task BGIEIJDOCBL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7099110", Offset = "0x7098310", VA = "0x187099110")]
		protected static PBIMPLNFGGJ MDIJNPLFPKM(DEIICMBCECK HCEEEBCLMJG, int OLFJJLJBFFO)
		{
			return default(PBIMPLNFGGJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7094C10", Offset = "0x7093E10", VA = "0x187094C10")]
		protected static ALBLKCKJHBN DGIPEIHGNGC(DEIICMBCECK HCEEEBCLMJG, int OLFJJLJBFFO)
		{
			return default(ALBLKCKJHBN);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7097240", Offset = "0x7096440", VA = "0x187097240")]
		protected Transform FPGAKDFAHMD(IEPCDHHNEOA EFKLNALJCMF, OutfitType JLMKKDGCFEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x709A520", Offset = "0x7099720", VA = "0x18709A520")]
		protected void ONKAENJGMGE(int LMAPNAOMGHO, Material HGJFBFIMOOD, DEIICMBCECK HCEEEBCLMJG, [Out] Texture2D FFKEICNFOJL, [Out] Vector4 MLMFAEIPNFE, [Out] Texture2D BLLGOBDBDAI, [Out] Texture2D PDDMDBNBLFJ, [Out] Texture2D NNHBDIIKPMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7095F80", Offset = "0x7095180", VA = "0x187095F80")]
		protected void FALMPLAILOI(int LMAPNAOMGHO, Material HGJFBFIMOOD, DEIICMBCECK HCEEEBCLMJG, [Out] Color HAHDIMOMHDM, [Out] Color INPGEEFCIGN, [Out] Color JOFFOJDMKPM, [Out] Color NCKLIGNHLEI, [Out] Color JLEFCANKBGF, [Out] Color JDOJAHDBEAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7094120", Offset = "0x7093320", VA = "0x187094120")]
		protected void CLFFEJOKGEB(Vector3 FJKLEJNIMLK, Quaternion KONNNOOBJFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x709C650", Offset = "0x709B850", VA = "0x18709C650")]
		public void SetHatAnchorParameters(APGOBKHECLL GABCIKPOKMA, AnchorParamsRestrictions CDAAFPKEEDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7094300", Offset = "0x7093500", VA = "0x187094300")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere CIGIFOPKOFA, Transform PGGDKIAJGPO, APGOBKHECLL GABCIKPOKMA, AnchorParamsRestrictions BIHBEFIJMOM, [Out] Vector3 ONLMFNGKLOH, [Out] Quaternion IBAINNMCHCO, [Out] APGOBKHECLL NCMDKNKOJFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x709AF50", Offset = "0x709A150", VA = "0x18709AF50")]
		public void ResetHatAnchor(Vector2 BKJEKCGGDNA, Vector3 IAFFDLONLJF, Vector3 ELFEKCNNJNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x95A960", Offset = "0x959B60", VA = "0x18095A960")]
		public CHPMJKCNFKD GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7092890", Offset = "0x7091A90", VA = "0x187092890")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x70929D0", Offset = "0x7091BD0", VA = "0x1870929D0")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7092800", Offset = "0x7091A00", VA = "0x187092800")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x709D8E0", Offset = "0x709CAE0", VA = "0x18709D8E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7095AE0", Offset = "0x7094CE0", VA = "0x187095AE0")]
		protected void EKPHIBJPMJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x709D6A0", Offset = "0x709C8A0", VA = "0x18709D6A0")]
		public void SetWaitForUgcTextureLoads(bool DEINJLMMFJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x709D5C0", Offset = "0x709C7C0", VA = "0x18709D5C0")]
		public void SetUgcTextureParameters(AHOOBEAGJBG HLJPDMABNJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x709E1D0", Offset = "0x709D3D0", VA = "0x18709E1D0")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x7092360", Offset = "0x7091560", VA = "0x187092360")]
		[CompilerGenerated]
		private void ABOGALEMOLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x709A4F0", Offset = "0x70996F0", VA = "0x18709A4F0")]
		[CompilerGenerated]
		private void OKALDHIGLMJ(MEHEIMELKAK ELJPGJDFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7098790", Offset = "0x7097990", VA = "0x187098790")]
		[CompilerGenerated]
		private void KGCCGMOHNEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x709A450", Offset = "0x7099650", VA = "0x18709A450")]
		[CompilerGenerated]
		private void OICDMOMBCNE(MEHEIMELKAK ELJPGJDFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x709A0A0", Offset = "0x70992A0", VA = "0x18709A0A0")]
		[CompilerGenerated]
		private void NIAHJEMKIJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7098920", Offset = "0x7097B20", VA = "0x187098920")]
		[CompilerGenerated]
		private void KMEGECFBDAK(MEHEIMELKAK ELJPGJDFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7094D60", Offset = "0x7093F60", VA = "0x187094D60")]
		[CompilerGenerated]
		private void DHOMEFELDLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x70960D0", Offset = "0x70952D0", VA = "0x1870960D0")]
		[CompilerGenerated]
		private void FHOEPMAENLF(MEHEIMELKAK ELJPGJDFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7095490", Offset = "0x7094690", VA = "0x187095490")]
		[CompilerGenerated]
		private void EBDLLAGLMCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7098530", Offset = "0x7097730", VA = "0x187098530")]
		[CompilerGenerated]
		private void KBFGNBINHIG(MEHEIMELKAK ELJPGJDFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7095BB0", Offset = "0x7094DB0", VA = "0x187095BB0")]
		[CompilerGenerated]
		private void EMDJMHHLJBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7098BF0", Offset = "0x7097DF0", VA = "0x187098BF0")]
		[CompilerGenerated]
		private void LGDFADLOHOB(MEHEIMELKAK ELJPGJDFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7098E60", Offset = "0x7098060", VA = "0x187098E60")]
		[CompilerGenerated]
		internal static bool LMDODLFLDIK(Transform BAHHKIBMFLB, IEnumerable<SkinnedMeshRenderer> DNNMLDFDALA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7099760", Offset = "0x7098960", VA = "0x187099760")]
		[CompilerGenerated]
		private void MIBGMCOPBOE(MEHEIMELKAK ELJPGJDFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7098B50", Offset = "0x7097D50", VA = "0x187098B50")]
		[CompilerGenerated]
		private void LDKLMCFLLPN(MEHEIMELKAK ELJPGJDFDLA)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, ONOIHDMEOKA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private struct NNJCGCPDCOH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public FBHKJALFDHL avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x70A7FD0", Offset = "0x70A71D0", VA = "0x1870A7FD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x70A8260", Offset = "0x70A7460", VA = "0x1870A8260", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private struct FOBNAOPOMEE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			public HCLDEAEBCAG avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x70A1500", Offset = "0x70A0700", VA = "0x1870A1500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x70A16D0", Offset = "0x70A08D0", VA = "0x1870A16D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct JMAPKNMCCMH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			public HCLDEAEBCAG avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x70A3240", Offset = "0x70A2440", VA = "0x1870A3240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x70A33E0", Offset = "0x70A25E0", VA = "0x1870A33E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct AIKAAHPNCAG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			public FBHKJALFDHL avatarData;
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct MHAGIENLPEE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000456")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000457")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			public FBHKJALFDHL avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000459")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x70A67D0", Offset = "0x70A59D0", VA = "0x1870A67D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x70A6EC0", Offset = "0x70A60C0", VA = "0x1870A6EC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct CDFNECJJFAI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045E")]
			public HCLDEAEBCAG avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045F")]
			private TaskAwaiter<FLJGGKJGKMO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x70A0510", Offset = "0x709F710", VA = "0x1870A0510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x70A0930", Offset = "0x709FB30", VA = "0x1870A0930", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct DLMLOGIPFFD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public HCLDEAEBCAG avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x70A0F00", Offset = "0x70A0100", VA = "0x1870A0F00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x70A13C0", Offset = "0x70A05C0", VA = "0x1870A13C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		protected const float EGHNPDGLPPM = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		protected const int GLIFNCLIHFB = 5;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		protected static readonly Dictionary<ICKLLJAMGLG.DDFKMHJCEFL, int> NGOEFOAALNF;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> CCGGPIKIDDK;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		protected static readonly int AEKDMNIFCJC;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		protected static readonly int IACBKONGEPJ;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		protected static readonly int PFLAGHCJMDK;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		protected static readonly int DNGKGBCMOCI;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		protected static readonly int JMMBADDOJFC;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		protected static readonly int IHPGABJNAEF;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		protected static readonly int MFPGGKAEFFF;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		protected static readonly int GODFELFAHHL;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		protected static Vector2 OCDNCAANILN;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		protected static Vector2 EIGONFKCOOE;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		protected static Vector2 KIEEFLMFNIF;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		protected static Vector2 DEAEFAGMMKI;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		protected static Vector2 DBICLCFDHJP;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		protected static Vector2 MMIABCBMNLA;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		protected static Vector2 MFAAOGKJNOH;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		protected static Vector2 KPKMCIHBMMH;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		protected static Vector2 POBPCCENENI;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		protected static Vector2 PCNLKNBFFFG;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		protected static Vector2 JLODKLNNDNH;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		protected static Vector2 IPKMMPJEEFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		[SerializeField]
		[PJAPKCLJNLP(FFILGMALDDB.Self, false, false, false)]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		[Header("Rendering")]
		[SerializeField]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		[Header("Emotes")]
		[SerializeField]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		[Header("Modern Avatar Facial Features")]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		[SerializeField]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private HCLDEAEBCAG MMNECAOCOMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private FaceStyleSet CLFGAJALJNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		protected const int GLKKEEAKAHO = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		protected int OOHMNKMGDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		protected int OGPFKKNFMEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		protected int PNBDBIMLCCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		protected int LMBJCEGCFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		protected Vector2 KNNNKNAOPII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		protected float NOIMFKHLKCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		protected Vector2 CMNKGAOPCOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		protected float ILLPMAINECA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		protected Vector2 BMNIIFKIFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected float OOEHJPJLEJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected Vector2 HJCGICGCCEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected float OIHNDFGMJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		protected List<SelectableFaceOption> AIODEKCAGID;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected List<SelectableFaceOption> CEOGEACGCFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		protected List<SelectableFaceOption> IKGGAEJNGEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		protected List<SelectableFaceOption> HNGEBDKBHDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		protected Coroutine NNPIPMIPEIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		protected int? BOIBEEKMFLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		protected int NEOMIHPBNHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		protected int OLHLALHENNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		protected int JGMNDGCPIEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		protected int CHEKLPKJJEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		protected int PBCOHBACBJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		protected int NBOEABFJBKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		protected Sprite DBHNCDOCJAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected Sprite IPKPMFIBHPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		protected Sprite MMNIAFPOKBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		protected Sprite HJKONJKJHJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected bool ALNAIOMOBHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected string IHLFOMIFBKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected string LENPAEGKIDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected string JKGHIBKMCEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected string KBIGAIGCHMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected AvatarConfiguration MIOEGDGMKKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected FLJGGKJGKMO KOMGKHCNNEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		private readonly List<Material> NFCJKFBBHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected KJPHPPOOEAA OMFOAIJCEJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected Dictionary<string, int> PLACFDOAIAB;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public FaceStyleSet OGNEDNKINPI
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x70AE6E0", Offset = "0x70AD8E0", VA = "0x1870AE6E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public bool AJJHDKJICFH
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x95DCD0", Offset = "0x95CED0", VA = "0x18095DCD0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x965B40", Offset = "0x964D40", VA = "0x180965B40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		protected virtual bool DAEPKOPNCIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		protected virtual bool ABNKGLOBJMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		protected int BGIEOOCEGKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x70A8EF0", Offset = "0x70A80F0", VA = "0x1870A8EF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public Renderer KEANIGCGGMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x8F85D0", Offset = "0x8F77D0", VA = "0x1808F85D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public bool JIDPLFDJHCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x12A63E0", Offset = "0x12A55E0", VA = "0x1812A63E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x12A66D0", Offset = "0x12A58D0", VA = "0x1812A66D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public Renderer[] MGBNFBHKJGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x8FB0E0", Offset = "0x8FA2E0", VA = "0x1808FB0E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public bool JLCCACPBICE
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x70AE720", Offset = "0x70AD920", VA = "0x1870AE720")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x70AE8E0", Offset = "0x70ADAE0", VA = "0x1870AE8E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		protected int LLNIDHPIBFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x70ABA00", Offset = "0x70AAC00", VA = "0x1870ABA00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		protected int LONPHIJBMNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x70A8E90", Offset = "0x70A8090", VA = "0x1870A8E90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public float GDIGDPOAFKO
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x70AE700", Offset = "0x70AD900", VA = "0x1870AE700")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x70AE8C0", Offset = "0x70ADAC0", VA = "0x1870AE8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public GJBMEOPCGOD NLGFBNIBHNG
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x960CF0", Offset = "0x95FEF0", VA = "0x180960CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0xAB9A30", Offset = "0xAB8C30", VA = "0x180AB9A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public FLJGGKJGKMO OCGAAOFKPBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x966410", Offset = "0x965610", VA = "0x180966410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x70AE840", Offset = "0x70ADA40", VA = "0x1870AE840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public NoseFaceOption JBPPLCKBHII
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x987160", Offset = "0x986360", VA = "0x180987160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0xAB9A10", Offset = "0xAB8C10", VA = "0x180AB9A10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		protected KJPHPPOOEAA FJHABMKAGNL
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x70AA0F0", Offset = "0x70A92F0", VA = "0x1870AA0F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action ENFJNJJLMMA
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x70AE630", Offset = "0x70AD830", VA = "0x1870AE630")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x70AE790", Offset = "0x70AD990", VA = "0x1870AE790")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x70AB6C0", Offset = "0x70AA8C0", VA = "0x1870AB6C0")]
		public void LocalPlayEmote(ICKLLJAMGLG.DDFKMHJCEFL AMNCLIBJKOG, float GCIGAANPGFH = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x70AA650", Offset = "0x70A9850", VA = "0x1870AA650")]
		public bool IsEmotePlaying(ICKLLJAMGLG.DDFKMHJCEFL AMNCLIBJKOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x70AC690", Offset = "0x70AB890", VA = "0x1870AC690")]
		public void SetIdleHappy(bool PNIGFJBJKGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x70AAB80", Offset = "0x70A9D80", VA = "0x1870AAB80")]
		protected void JIBKOBLENGO(bool ECAPEADFBGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x70AA770", Offset = "0x70A9970", VA = "0x1870AA770")]
		protected void JDDIDCEBOHC(bool CGFPDDLOOLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x70AB990", Offset = "0x70AAB90", VA = "0x1870AB990")]
		protected void NDFEDNPBCHH(IEPCDHHNEOA EFKLNALJCMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x70AA080", Offset = "0x70A9280", VA = "0x1870AA080")]
		protected void IJAKBBODKPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x70ABEC0", Offset = "0x70AB0C0", VA = "0x1870ABEC0")]
		public void PlayExpression(int EFKDEBAMPON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x70A92F0", Offset = "0x70A84F0", VA = "0x1870A92F0")]
		protected void GJEDCLDGHHP(bool GHCCMDBBCKL, bool JFFPAIKGPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x70AA040", Offset = "0x70A9240", VA = "0x1870AA040")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType ALGPPMEMIGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x70AA170", Offset = "0x70A9370", VA = "0x1870AA170")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration MIOEGDGMKKO, HCLDEAEBCAG EPMDONLDAKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x70AC5A0", Offset = "0x70AB7A0", VA = "0x1870AC5A0")]
		[AsyncStateMachine(typeof(NNJCGCPDCOH))]
		public Task SetFaceSettings(FBHKJALFDHL NAHENMKCODH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x70AC470", Offset = "0x70AB670", VA = "0x1870AC470")]
		[AsyncStateMachine(typeof(FOBNAOPOMEE))]
		public Task SetFaceSettings(int HJCKPCOGLJB, int HLEFPKIJDKH, int BAGNKAGDONL, int GPFBPJAKCAO, HCLDEAEBCAG EPMDONLDAKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x70AC710", Offset = "0x70AB910", VA = "0x1870AC710")]
		[AsyncStateMachine(typeof(JMAPKNMCCMH))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType ALGPPMEMIGB, int OGHOFGFHBDB, HCLDEAEBCAG EPMDONLDAKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x70ABD50", Offset = "0x70AAF50", VA = "0x1870ABD50")]
		protected void PDOFJNJALLI(FaceFeatureType ALGPPMEMIGB, IFNONIKJIIN LBPFDJCFOGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x70A93B0", Offset = "0x70A85B0", VA = "0x1870A93B0")]
		protected void GJEFDBNHKAA(FaceFeatureType ALGPPMEMIGB, int OGHOFGFHBDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x70A9E60", Offset = "0x70A9060", VA = "0x1870A9E60")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x70AAD80", Offset = "0x70A9F80", VA = "0x1870AAD80")]
		[AsyncStateMachine(typeof(MHAGIENLPEE))]
		protected Task LBCPCGMJPHM(FBHKJALFDHL NAHENMKCODH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x70A9150", Offset = "0x70A8350", VA = "0x1870A9150")]
		protected static void FBCKANMBGNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x70A8C00", Offset = "0x70A7E00", VA = "0x1870A8C00")]
		private void CBGDAIOOFGE(bool JDJNKMGJBNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x70A9AF0", Offset = "0x70A8CF0", VA = "0x1870A9AF0")]
		protected void GKMCLOJLKGE(FaceFeatureType ALGPPMEMIGB, Vector2 FOODDIGJOOD, HCLDEAEBCAG EPMDONLDAKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x70ABEE0", Offset = "0x70AB0E0", VA = "0x1870ABEE0")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType ALGPPMEMIGB, Vector2 OJJMPKKCDBG, HCLDEAEBCAG EPMDONLDAKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x70AAC00", Offset = "0x70A9E00", VA = "0x1870AAC00")]
		protected void JPGLFELBMKB(FaceFeatureType ALGPPMEMIGB, float JAMGJHKONOE, HCLDEAEBCAG EPMDONLDAKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x70AC250", Offset = "0x70AB450", VA = "0x1870AC250")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType ALGPPMEMIGB, float OGHNHPHDGGI, HCLDEAEBCAG EPMDONLDAKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x70AB8B0", Offset = "0x70AAAB0", VA = "0x1870AB8B0")]
		[AsyncStateMachine(typeof(CDFNECJJFAI))]
		protected Task MGJJJIHAFBO(HCLDEAEBCAG EPMDONLDAKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x70AA440", Offset = "0x70A9640", VA = "0x1870AA440")]
		public void InitializeFaceFeatureStyleSet(HCLDEAEBCAG EPMDONLDAKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x70ABC70", Offset = "0x70AAE70", VA = "0x1870ABC70")]
		protected bool PDKJONDNKJG(string OBCJHKJMAHD, [Out] int CPLNODNGKGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x70A89D0", Offset = "0x70A7BD0", VA = "0x1870A89D0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x1307FD0", Offset = "0x13071D0", VA = "0x181307FD0", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x70ABA60", Offset = "0x70AAC60", VA = "0x1870ABA60")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x70AD6E0", Offset = "0x70AC8E0", VA = "0x1870AD6E0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x70A8B10", Offset = "0x70A7D10", VA = "0x1870A8B10")]
		[AsyncStateMachine(typeof(DLMLOGIPFFD))]
		public Task BuildFaceStyleAsyncIfChanged(HCLDEAEBCAG EPMDONLDAKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x70AD010", Offset = "0x70AC210", VA = "0x1870AD010")]
		public void UpdateFaceDisplays(bool MAMGCLJIPLD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x70AAE70", Offset = "0x70AA070", VA = "0x1870AAE70")]
		protected bool LPIFHPOJBPL(bool MAMGCLJIPLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x70ACD30", Offset = "0x70ABF30", VA = "0x1870ACD30")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x70AC820", Offset = "0x70ABA20", VA = "0x1870AC820")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x70AD220", Offset = "0x70AC420", VA = "0x1870AD220")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x70AD410", Offset = "0x70AC610", VA = "0x1870AD410")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x70AB7C0", Offset = "0x70AA9C0", VA = "0x1870AB7C0")]
		protected void MAPPLODJCOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x70AA8D0", Offset = "0x70A9AD0", VA = "0x1870AA8D0")]
		private void JHAKEJIPPIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x70AE3D0", Offset = "0x70AD5D0", VA = "0x1870AE3D0")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x920810", Offset = "0x91FA10", VA = "0x180920810", Slot = "4")]
		private bool LCNMGJMBHCF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x70A9020", Offset = "0x70A8220", VA = "0x1870A9020")]
		[CompilerGenerated]
		internal static JHNKMHNJONE EPPDKPFPNCF(FaceFeatureType ALGPPMEMIGB, AIKAAHPNCAG P_1)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct LFEHJDIMCNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public string PCMLNMEPCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public int JFJOAOHHOGF;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[SelectionBase]
	[ExecuteInEditMode]
	public class PlayerModernBodyEditorAvatarValidator : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public HCLDEAEBCAG avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public LHLBFAAIMNN useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public APGOBKHECLL hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public CHPMJKCNFKD HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public LJLGCMOEKHG.AMEKCHAHPFE baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		[SerializeField]
		[PJAPKCLJNLP(FFILGMALDDB.Self, false, false, false)]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		private KAIPBCMMBGK AKNDIJGCEGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		[SerializeField]
		[PJAPKCLJNLP(FFILGMALDDB.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private AnimatorOverrideController IFGMFDCNPIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> LHNLKPHIDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public readonly LFEHJDIMCNE[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public readonly (string, FOPKOLANAGM)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		protected bool HMFIONFEFOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		protected Guid BMOCGGINILN;

		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		protected static Guid KCLGINELDAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private NMHKDIBMOMB LHAFMFFBNNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private GJBMEOPCGOD NDPBCFNJMMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private GNMICAIAGAB BMMDIMPJKCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private GNMICAIAGAB APJOHHDOMAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private AdditionalHatData ILKCINHHHGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private readonly Dictionary<GameObject, CADFEFPNNFM> HKBOOLAJNKG;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public static Func<JOKPOGKIBGB> FOENDGLPIIH
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x70B2AE0", Offset = "0x70B1CE0", VA = "0x1870B2AE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x70B3140", Offset = "0x70B2340", VA = "0x1870B3140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public bool BEPPGGLICLH
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x70B2C40", Offset = "0x70B1E40", VA = "0x1870B2C40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool EHFGLLEBLMB
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x70B2B30", Offset = "0x70B1D30", VA = "0x1870B2B30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public PlayerAvatarDisplayBase DECPOPDCEKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x960D50", Offset = "0x95FF50", VA = "0x180960D50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		protected static Guid JCIBGFABLGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x70B0CA0", Offset = "0x70AFEA0", VA = "0x1870B0CA0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public (GameObject, IEPCDHHNEOA)[] CCFMNGOGGHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x70B2D50", Offset = "0x70B1F50", VA = "0x1870B2D50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x70AF800", Offset = "0x70AEA00", VA = "0x1870AF800")]
		private IEnumerable<GameObject> FEMPDIABFMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x70B14E0", Offset = "0x70B06E0", VA = "0x1870B14E0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x70AFC70", Offset = "0x70AEE70", VA = "0x1870AFC70")]
		private void FIBCNNBGPAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x106EA40", Offset = "0x106DC40", VA = "0x18106EA40")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x70B0330", Offset = "0x70AF530", VA = "0x1870B0330")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x70B14F0", Offset = "0x70B06F0", VA = "0x1870B14F0")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x70B12E0", Offset = "0x70B04E0", VA = "0x1870B12E0")]
		public void ShowPose(AnimationClip MCNFAKJPPIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x70B14B0", Offset = "0x70B06B0", VA = "0x1870B14B0")]
		public void ShowPose(string MFIEBMGHOFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x70B1260", Offset = "0x70B0460", VA = "0x1870B1260")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x70B1090", Offset = "0x70B0290", VA = "0x1870B1090")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x70B1950", Offset = "0x70B0B50", VA = "0x1870B1950")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x70B1850", Offset = "0x70B0A50", VA = "0x1870B1850")]
		public void UpdateFaceAndBodyShapes(bool JOEIIMINHIH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x70B1BB0", Offset = "0x70B0DB0", VA = "0x1870B1BB0")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x70B0D90", Offset = "0x70AFF90", VA = "0x1870B0D90", Slot = "4")]
		protected virtual void MGIKDONLCGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x70B0A30", Offset = "0x70AFC30", VA = "0x1870B0A30", Slot = "5")]
		protected virtual void KMMAGCEMGNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x70AEBF0", Offset = "0x70ADDF0", VA = "0x1870AEBF0")]
		public void ApplyHatData(AdditionalHatData BNBCJKANFOM, bool KODLPEKPKFJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x70AEA30", Offset = "0x70ADC30", VA = "0x1870AEA30")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x70AEF50", Offset = "0x70AE150", VA = "0x1870AEF50")]
		public void ApplyHatUVOverride(Vector2 MEEGPDLGMCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x70AEE70", Offset = "0x70AE070", VA = "0x1870AEE70")]
		public void ApplyHatPositionAdjustment(Vector3 CCPDOFMFGFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x70AEEE0", Offset = "0x70AE0E0", VA = "0x1870AEEE0")]
		public void ApplyHatRotationAdjustment(Vector3 POFDKIJEAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x70AEFD0", Offset = "0x70AE1D0", VA = "0x1870AEFD0")]
		public KHDMLNGENAP BuildAvatarItemSelection(GameObject CEEFADGLJMK, HCLDEAEBCAG BMNGGJOPDFI, IEPCDHHNEOA OPHDJMPDDFN)
		{
			return default(KHDMLNGENAP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x70AF070", Offset = "0x70AE270", VA = "0x1870AF070")]
		public void BuildAvatar(bool JOEIIMINHIH = false, bool KODLPEKPKFJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x70AEB70", Offset = "0x70ADD70", VA = "0x1870AEB70")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x70B1A00", Offset = "0x70B0C00", VA = "0x1870B1A00")]
		public void UpdateHatAnchor(bool KODLPEKPKFJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x70AFE00", Offset = "0x70AF000", VA = "0x1870AFE00")]
		private void GPOFFENDGNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
		private void HNLMBDDDHHJ(CADFEFPNNFM OGAAINFFODO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
		private void GHNEGAEELAJ(CADFEFPNNFM OGAAINFFODO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x70AEFC0", Offset = "0x70AE1C0", VA = "0x1870AEFC0")]
		private void BLABDLEJBPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x70B1C40", Offset = "0x70B0E40", VA = "0x1870B1C40")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x70AFD50", Offset = "0x70AEF50", VA = "0x1870AFD50")]
		[CompilerGenerated]
		private KHDMLNGENAP FKFKLFEIAOA((GameObject, IEPCDHHNEOA) DJLOMCAJAEP)
		{
			return default(KHDMLNGENAP);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		[SerializeField]
		[PJAPKCLJNLP(FFILGMALDDB.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct KHDMLNGENAP
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class DIDONGOEFOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public DIDONGOEFOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x70A0AE0", Offset = "0x709FCE0", VA = "0x1870A0AE0")]
		internal bool GIDLHBBHFHA(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private CADFEFPNNFM ENPLMIMAFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private IEPCDHHNEOA IKEDKBNOCJH;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public CADFEFPNNFM KPMGNGANLMN
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public IEPCDHHNEOA CHLOFLBFPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x2516260", Offset = "0x2515460", VA = "0x182516260")]
		get
		{
			return default(IEPCDHHNEOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public string DGGCAOPIPHO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x70A38E0", Offset = "0x70A2AE0", VA = "0x1870A38E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool BGOAGMOMMON
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x70A3630", Offset = "0x70A2830", VA = "0x1870A3630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool ANDKAJLADEI
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x70A3A90", Offset = "0x70A2C90", VA = "0x1870A3A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0xABEF70", Offset = "0xABE170", VA = "0x180ABEF70")]
	public KHDMLNGENAP(CADFEFPNNFM OGAAINFFODO, IEPCDHHNEOA EFKLNALJCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x70A39D0", Offset = "0x70A2BD0", VA = "0x1870A39D0")]
	public bool KFODHNNOMGB(OutfitType FKEBPAFHBCP, IEPCDHHNEOA KAHBLCLHHFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x70A3680", Offset = "0x70A2880", VA = "0x1870A3680")]
	public bool EILHIIEBDJL(OutfitType FKEBPAFHBCP, IEPCDHHNEOA KAHBLCLHHFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x70A3440", Offset = "0x70A2640", VA = "0x1870A3440")]
	public bool AOJNPBJKAEK(KHDMLNGENAP IMJPHJGKAIE)
	{
		return default(bool);
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
