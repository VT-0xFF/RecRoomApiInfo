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
	public class LogRegistrationIndex : IGKFPLMKJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6AA2730", Offset = "0x6AA1330", VA = "0x186AA2730", Slot = "4")]
		public override void PEGPHNFMEDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
			[Cpp2IlInjected.Address(RVA = "0x88C520", Offset = "0x88B120", VA = "0x18088C520", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6AAE890", Offset = "0x6AAD490", VA = "0x186AAE890", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6AAE7B0", Offset = "0x6AAD3B0", VA = "0x186AAE7B0", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6AAE850", Offset = "0x6AAD450", VA = "0x186AAE850")]
		public RecNetCDNAssetReference(RecNetCDNKey NONKDEOLPHL)
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
			[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x888260", Offset = "0x886E60", VA = "0x180888260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x88ABD0", Offset = "0x8897D0", VA = "0x18088ABD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x88ABC0", Offset = "0x8897C0", VA = "0x18088ABC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6AAE8D0", Offset = "0x6AAD4D0", VA = "0x186AAE8D0")]
		public static RecNetCDNKey AECBPFLKKJG(string BIMDKFOEFFP, string PFGAMCECDIG = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x62717E0", Offset = "0x62703E0", VA = "0x1862717E0")]
		public void LOCOKILFMEM(string DNKALPDJPLN, string IGABCIKOEOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6AAE9D0", Offset = "0x6AAD5D0", VA = "0x186AAE9D0")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[CGPAMFEMIJK]
public class MOBJIMEGBKA : KJOCOJLPEIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> GCLAAKOJDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> HPBJGEMNADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> BJNMLABPGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> HGNIGFGNHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> MNLIPNIIOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> HKAJJPFBMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> CLNKGKPHFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator AHGMKBJDPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected HABOPHMGAFA EOEEKHGJNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte LPOKJEEMLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> APCBALAFIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> BCKAIDJLLHF;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6AA2A20", Offset = "0x6AA1620", VA = "0x186AA2A20", Slot = "4")]
	public void DLLLDIJOFCP(Mesh OOKDOLDBLMJ, Matrix4x4 KPFCIJLGBEN, byte[] NKMOBGCBIFM, bool DHJMFNCHEBJ = false, HDFJPOEIMPO.CLDPEDONPKD AKCJEBEEFLL = (HDFJPOEIMPO.CLDPEDONPKD)0, int GBOJMEDGMPN = -1, bool KMJOAFPGMPB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6AA2C30", Offset = "0x6AA1830", VA = "0x186AA2C30", Slot = "5")]
	public void JHINCDBNIEG(Allocator ICLGONBNBJO, HABOPHMGAFA JGEACNBABNO, byte EAFBJALFMMG, [Optional] IList<int> GHDGPMNOIDM, [Optional] IList<int> OJJOOHMIDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6AA27C0", Offset = "0x6AA13C0", VA = "0x186AA27C0")]
	private static void AGKEGCKMCME(Mesh OOKDOLDBLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6AA2C70", Offset = "0x6AA1870", VA = "0x186AA2C70")]
	public MOBJIMEGBKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CGPAMFEMIJK]
public struct AGMPIBDBEON : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public KMKFDHANNEH GPBNFGOPAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int PLPKLDMOJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public DLLACJDHDEM PCNDABOECOJ;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A97C40", Offset = "0x6A96840", VA = "0x186A97C40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[CGPAMFEMIJK]
[NativeContainer]
public struct DLLACJDHDEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct JHAALAEENHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector3 MEMJMOGHIME;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 DJCDKMIHKHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector4 BDBPBPFJEFP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct NCCODCJFNDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float IMHCGKAFLFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float PKNCJEBBBIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float NDBNNOAOJPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float ENLCIFEEICL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte OOANHIHPFGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte HHHMBCIAMKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte HFBINDMPHIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte LHHBNHIHFAE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct EBFLCGHMKAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half IMHCGKAFLFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half PKNCJEBBBIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half NDBNNOAOJPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half ENLCIFEEICL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte OOANHIHPFGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte HHHMBCIAMKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte HFBINDMPHIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte LHHBNHIHFAE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct MEABIGHCAAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 NKKLIFIFGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 AAHDKPNKLJN;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct JOFFMIGDFOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half4 NKKLIFIFGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 AAHDKPNKLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 HEKFKFKELIC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct GCFEMNPHKEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 NKKLIFIFGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 AAHDKPNKLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 HEKFKFKELIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 OBPONDMPBPA;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct DMOJLGMJBCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half4 NKKLIFIFGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 AAHDKPNKLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 HEKFKFKELIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 OBPONDMPBPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 EPKLJNDEIOE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct DCPDOHOFFGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float IMHCGKAFLFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float PKNCJEBBBIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float NDBNNOAOJPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float ENLCIFEEICL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int OOANHIHPFGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int HHHMBCIAMKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int HFBINDMPHIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int LHHBNHIHFAE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct NFLLFKNBBPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Color NKKLIFIFGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 AAHDKPNKLJN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct IDKNJOGICBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color NKKLIFIFGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 AAHDKPNKLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 HEKFKFKELIC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct PEIDMABHLKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color NKKLIFIFGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 AAHDKPNKLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 HEKFKFKELIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 OBPONDMPBPA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct FLDIAHIOKGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color NKKLIFIFGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 AAHDKPNKLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 HEKFKFKELIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 OBPONDMPBPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 EPKLJNDEIOE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool BKHELGGOFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<JHAALAEENHO> POKKIPALAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<MEABIGHCAAF> CGILGFBDBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<JOFFMIGDFOI> AOBFHMKOJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<GCFEMNPHKEK> NMOKICDEMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<DMOJLGMJBCP> MMOFOBLMIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<EBFLCGHMKAM> KEFKGENHJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<NCCODCJFNDI> KJJMEHADNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<NFLLFKNBBPL> MPMCJNBMAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<IDKNJOGICBF> CCKFINGJNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<PEIDMABHLKE> JAOPCHOLFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<FLDIAHIOKGL> IFGGKCCMPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<DCPDOHOFFGD> PJNNIJAOOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> NKPJGNHJMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> FDODKBBOEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> IDMNEPOBIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> ODPBLCOJEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> JDAMKOAFCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> HJMMNFAOHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> EOKJIACNKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<BoneWeight> EBAEAONBKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> HHLMDDDPFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool MJOAKFFCELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool PNICHAHNEGC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int OBOJBPKHHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6A9C1C0", Offset = "0x6A9ADC0", VA = "0x186A9C1C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6A9C7E0", Offset = "0x6A9B3E0", VA = "0x186A9C7E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JIHGOGBLBBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6A9C1B0", Offset = "0x6A9ADB0", VA = "0x186A9C1B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6A9E490", Offset = "0x6A9D090", VA = "0x186A9E490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int BFOLKBLNOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6A9D040", Offset = "0x6A9BC40", VA = "0x186A9D040")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6A9CC30", Offset = "0x6A9B830", VA = "0x186A9CC30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int KHBNENGHBBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6A9C440", Offset = "0x6A9B040", VA = "0x186A9C440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E500", Offset = "0x6A9D100", VA = "0x186A9E500")]
	public DLLACJDHDEM(int MMHKOHFBIEC, int CGNHBAFBAON, int DJLGMFHICPD, int LINHEFPJCIN, Allocator ICLGONBNBJO, int HHJKKKMPAKP, ACEOAANDNJJ DENJKJHCPGI, bool MJOAKFFCELF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A9CBA0", Offset = "0x6A9B7A0", VA = "0x186A9CBA0")]
	public void IJIKMPLDAGM(int MFJLAMOCOBC, Vector3 PPIEANOJMKF, Vector3 BJFIIBACKFL, Vector4 APOGBJPOAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A9D120", Offset = "0x6A9BD20", VA = "0x186A9D120")]
	public void MAMFACPIOGI(int MFJLAMOCOBC, BoneWeight MIECBIMMGFM, NativeSlice<byte> NKMOBGCBIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C4B0", Offset = "0x6A9B0B0", VA = "0x186A9C4B0")]
	public Color HEDPPPEDOKC(int MFJLAMOCOBC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A9CC40", Offset = "0x6A9B840", VA = "0x186A9CC40")]
	public void KFMBNMCILMB(int MFJLAMOCOBC, Color NPAFKDGAFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C7F0", Offset = "0x6A9B3F0", VA = "0x186A9C7F0")]
	public void HMCIFHHFFAC(byte PIHPKFAKGDI, int MFJLAMOCOBC, Vector2 EJPLDDBIHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C430", Offset = "0x6A9B030", VA = "0x186A9C430")]
	public void ECFMBMGIMNN(int MFJLAMOCOBC, int CFEEMFEIJAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E4A0", Offset = "0x6A9D0A0", VA = "0x186A9E4A0")]
	public bool OBIJEBFKNBI(int PIHPKFAKGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A9D050", Offset = "0x6A9BC50", VA = "0x186A9D050")]
	public void LPPKHNKDBFB(int MJLFKJHALEH, int APMEPKJBNGD, int OLBMNABBGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C1D0", Offset = "0x6A9ADD0", VA = "0x186A9C1D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6A9D550", Offset = "0x6A9C150", VA = "0x186A9D550")]
	public Mesh MKMMECHIGIB([Optional] string MGLPPLPDHDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[NativeContainer]
[CGPAMFEMIJK]
[DefaultMember("Item")]
public struct KMKFDHANNEH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Mesh.MeshDataArray NLNPBMDCOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<int> DHNAGMNCEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> AGKLLHPOOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<BoneWeight> EBAEAONBKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<Matrix4x4> DNPNBHNNFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> FPJJCLFODFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<byte> LCPJFBIBPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> AAEFGIIBNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> LECAMJGIDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeArray<sbyte> KOFKOILEEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<byte> PFKNBMGCLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<bool> KMJOAFPGMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<int> GBOJMEDGMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool MJOAKFFCELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<int> IFHCDBDFDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool PNICHAHNEGC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int FABPAHJJAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0830", Offset = "0x6A9F430", VA = "0x186AA0830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int EFJKALADMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6AA09D0", Offset = "0x6A9F5D0", VA = "0x186AA09D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int EFCBBCEHDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0760", Offset = "0x6A9F360", VA = "0x186AA0760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int IFHKGKJPFLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0A10", Offset = "0x6A9F610", VA = "0x186AA0A10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6AA09F0", Offset = "0x6A9F5F0", VA = "0x186AA09F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int OBOJBPKHHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0840", Offset = "0x6A9F440", VA = "0x186AA0840")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0A00", Offset = "0x6A9F600", VA = "0x186AA0A00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int GJILMPBJIOL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6AA09C0", Offset = "0x6A9F5C0", VA = "0x186AA09C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6AA09E0", Offset = "0x6A9F5E0", VA = "0x186AA09E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public HABOPHMGAFA JLIMCKPKMMD
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0A20", Offset = "0x6A9F620", VA = "0x186AA0A20")]
		get
		{
			return default(HABOPHMGAFA);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0B10", Offset = "0x6A9F710", VA = "0x186AA0B10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte ALBBJNNLNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0A30", Offset = "0x6A9F630", VA = "0x186AA0A30")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0500", Offset = "0x6A9F100", VA = "0x186AA0500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public HJEPHDNNPAP CECFGNBJFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0510", Offset = "0x6A9F110", VA = "0x186AA0510")]
		get
		{
			return default(HJEPHDNNPAP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6AA0B20", Offset = "0x6A9F720", VA = "0x186AA0B20")]
	public KMKFDHANNEH(IList<Mesh> EHAODLEOIEE, IList<Matrix4x4> MFOPICIHFCG, IList<bool> KMJOAFPGMPB, byte EAFBJALFMMG, IList<byte[]> LCHEBACOEPH, IList<int> BJMONNBJICP, IList<bool> JEMDHJOKMOL, IList<int> GBOJMEDGMPN, IList<int> GHDGPMNOIDM, IList<int> GCGKNDJGNEF, Allocator ICLGONBNBJO, HABOPHMGAFA JGEACNBABNO, bool MJOAKFFCELF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6AA0A40", Offset = "0x6A9F640", VA = "0x186AA0A40")]
	public DLLACJDHDEM MEFEEKEOECC(Allocator ICLGONBNBJO, ACEOAANDNJJ DENJKJHCPGI)
	{
		return default(DLLACJDHDEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6AA0850", Offset = "0x6A9F450", VA = "0x186AA0850", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[CGPAMFEMIJK]
public class CPHPCBLPOIO : MOBJIMEGBKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool KGJDKHPEIEG;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly ProfilerMarker BCMLLEFKOON;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6A9BEA0", Offset = "0x6A9AAA0", VA = "0x186A9BEA0")]
	public KMKFDHANNEH LMHOLIKMHGB()
	{
		return default(KMKFDHANNEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C1A0", Offset = "0x6A9ADA0", VA = "0x186A9C1A0")]
	public CPHPCBLPOIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct HJEPHDNNPAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Mesh.MeshData MGFEFIEJJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<BoneWeight> EBAEAONBKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeSlice<byte> IEHOKAILDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int BHNLLMGHOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Matrix4x4 OEAEMILAMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public int LLBPBLPPGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<byte> NKMOBGCBIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public bool NBGBCCCPINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int JPKLNMDEEPF;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class AvatarElbowBendHelperController : MonoBehaviour, MHCAJPGHMFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		[GBPOFPPCAAP(KOFDDAAAPEO.Self, false, false, false)]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[FormerlySerializedAs("MinScaleValues")]
		[SerializeField]
		[Header("Scale")]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		[FormerlySerializedAs("MaxScaleValues")]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[SerializeField]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[Header("Positional Offset")]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SerializeField]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private Vector3? DKPKNNFPBIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private bool FPMFIJBGDOD;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6A99720", Offset = "0x6A98320", VA = "0x186A99720", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6A99D40", Offset = "0x6A98940", VA = "0x186A99D40", Slot = "4")]
		public void UpdateController(float EOJDMAMGKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xCB5DF0", Offset = "0xCB49F0", VA = "0x180CB5DF0", Slot = "6")]
		public void SetEnabled(bool CABLCDOIFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6A99800", Offset = "0x6A98400", VA = "0x186A99800")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6A9A200", Offset = "0x6A98E00", VA = "0x186A9A200")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AvatarElbowBendTargetController : MonoBehaviour, MHCAJPGHMFO
	{
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private const float INAJIHGBDJE = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[GBPOFPPCAAP(KOFDDAAAPEO.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private Vector3 OHLIENEFHAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private Vector3 LAIAIDKKLEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private bool FPMFIJBGDOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private float BNNJMIOAMEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private float CHOOFNBBKGC;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6A9A580", Offset = "0x6A99180", VA = "0x186A9A580", Slot = "4")]
		public void UpdateController(float EOJDMAMGKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xB0D400", Offset = "0xB0C000", VA = "0x180B0D400", Slot = "6")]
		public void SetEnabled(bool CABLCDOIFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6A9A2A0", Offset = "0x6A98EA0", VA = "0x186A9A2A0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6A9B040", Offset = "0x6A99C40", VA = "0x186A9B040")]
		public AvatarElbowBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AvatarForearmRollController : MonoBehaviour, MHCAJPGHMFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private float BNNJMIOAMEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private bool FPMFIJBGDOD;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6A9B070", Offset = "0x6A99C70", VA = "0x186A9B070", Slot = "4")]
		public void UpdateController(float EOJDMAMGKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xFA7600", Offset = "0xFA6200", VA = "0x180FA7600", Slot = "6")]
		public void SetEnabled(bool CABLCDOIFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6A9BAF0", Offset = "0x6A9A6F0", VA = "0x186A9BAF0")]
		public AvatarForearmRollController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class PKMJKABHHDM : GGDKLOOMBAO
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private abstract class KNEBIBFCKLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public readonly BCGODMJDFFO KMNONFEOPHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		protected bool OLPOPAKGFMF;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool KKDHJKIPFEB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x935C80", Offset = "0x934880", VA = "0x180935C80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xBA1690", Offset = "0xBA0290", VA = "0x180BA1690")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool EPPNGPBLJHD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xD4B480", Offset = "0xD4A080", VA = "0x180D4B480")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xD4B470", Offset = "0xD4A070", VA = "0x180D4B470")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual HDFJPOEIMPO.CLDPEDONPKD LLBPBLPPGNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x917870", Offset = "0x916470", VA = "0x180917870", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(HDFJPOEIMPO.CLDPEDONPKD);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x916BE0", Offset = "0x9157E0", VA = "0x180916BE0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool BOLEBIMFMBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xA223E0", Offset = "0xA20FE0", VA = "0x180A223E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool OJFHOKAHIFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x16CC3C0", Offset = "0x16CAFC0", VA = "0x1816CC3C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool HMGMGADBOPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x6AA2480", Offset = "0x6AA1080", VA = "0x186AA2480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool DAHAFMEMEKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6AA2460", Offset = "0x6AA1060", VA = "0x186AA2460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6AA2490", Offset = "0x6AA1090", VA = "0x186AA2490")]
		protected KNEBIBFCKLF(BCGODMJDFFO EMBEFPCMDOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract DMMKPEDFDBF KABFMEPIEJC(List<ICGCFKNNIIE> PAIHLLHNDHC, List<ICGCFKNNIIE> EGNMAKCLBAJ);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract CDFOCDBLBEP MKFDDMCECAG(uint LAIJAICKIEF, AvatarSkinnedMeshBoneOrderRemapsData PJODNPEPLIN);
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class KNAIEBCDCGN : KNEBIBFCKLF
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class ADJHHGCOCGK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public MGEGMLPKNPK<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public KNAIEBCDCGN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public Action<string> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public ADJHHGCOCGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x6A97700", Offset = "0x6A96300", VA = "0x186A97700")]
			internal void BNKJFCNFIJJ(GameObject result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x6A97B00", Offset = "0x6A96700", VA = "0x186A97B00")]
			internal void MMAPIHMPJIE(string error)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private readonly AvatarSkinAssetItem.AKLBINDGFJM PPBIIDMLGOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private readonly AssetReference CHOIGMNKDGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly OCAFLGKEFMJ? POACMPCDOHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private readonly Material[] CMNLIGMKNHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private SkinnedMeshRenderer[] FPDOINPPAIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private AvatarSkinAssetItem CFBLKOJALGD;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override HDFJPOEIMPO.CLDPEDONPKD LLBPBLPPGNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x8E9FA0", Offset = "0x8E8BA0", VA = "0x1808E9FA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(HDFJPOEIMPO.CLDPEDONPKD);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x921740", Offset = "0x920340", VA = "0x180921740", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6AA2220", Offset = "0x6AA0E20", VA = "0x186AA2220")]
		public KNAIEBCDCGN(AvatarSkinAssetItem.AKLBINDGFJM HKOOCHBBHLN, AssetReference ILIFCPMOMKA, Material CHHDDIBDPHM, BCGODMJDFFO NOIJPBIAGKF, HDFJPOEIMPO.CLDPEDONPKD MNHCNOIDDHN = (HDFJPOEIMPO.CLDPEDONPKD)0, [Optional] OCAFLGKEFMJ? MJOGIHLEJDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6AA2340", Offset = "0x6AA0F40", VA = "0x186AA2340")]
		public KNAIEBCDCGN(AvatarSkinAssetItem.AKLBINDGFJM HKOOCHBBHLN, AssetReference ILIFCPMOMKA, Material CHHDDIBDPHM, HDFJPOEIMPO.CLDPEDONPKD MNHCNOIDDHN = (HDFJPOEIMPO.CLDPEDONPKD)0, [Optional] OCAFLGKEFMJ? MJOGIHLEJDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6AA1D10", Offset = "0x6AA0910", VA = "0x186AA1D10", Slot = "6")]
		public override DMMKPEDFDBF KABFMEPIEJC(List<ICGCFKNNIIE> PAIHLLHNDHC, List<ICGCFKNNIIE> EGNMAKCLBAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6AA1EE0", Offset = "0x6AA0AE0", VA = "0x186AA1EE0", Slot = "7")]
		public override CDFOCDBLBEP MKFDDMCECAG(uint LAIJAICKIEF, AvatarSkinnedMeshBoneOrderRemapsData PJODNPEPLIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6AA21B0", Offset = "0x6AA0DB0", VA = "0x186AA21B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class JKACIMGFNLP : KNEBIBFCKLF
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class JDBFNBKGFFA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public JKACIMGFNLP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public List<ICGCFKNNIIE> prefabHandles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public List<ICGCFKNNIIE> materialHandles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public MGEGMLPKNPK<Material[]> loadMaterialsHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public MGEGMLPKNPK<IOEDAEIKENP> loadPrefabHandle;

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public JDBFNBKGFFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6A9F060", Offset = "0x6A9DC60", VA = "0x186A9F060")]
			internal DMMKPEDFDBF MMAPIHMPJIE(string error)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public MCOGOHBOKKE CHPADJDDGOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public IOEDAEIKENP OCKFIDPPCKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private MGEGMLPKNPK<IOEDAEIKENP> NEFGLEMABPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private MGEGMLPKNPK<Material[]> EHMGIBEGGII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public Material[] OHIBONMBAOA;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool IMJIKLNBLOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x9157C0", Offset = "0x9143C0", VA = "0x1809157C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xD13460", Offset = "0xD12060", VA = "0x180D13460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public HDFJPOEIMPO.CLDPEDONPKD PLJJODIBFNH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xADFAB0", Offset = "0xADE6B0", VA = "0x180ADFAB0")]
			[CompilerGenerated]
			get
			{
				return default(HDFJPOEIMPO.CLDPEDONPKD);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xD1B3C0", Offset = "0xD19FC0", VA = "0x180D1B3C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0450", Offset = "0x6A9F050", VA = "0x186AA0450")]
		public JKACIMGFNLP(BCGODMJDFFO EMBEFPCMDOD, MCOGOHBOKKE DPADLJLGPKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6A9FC90", Offset = "0x6A9E890", VA = "0x186A9FC90", Slot = "6")]
		public override DMMKPEDFDBF KABFMEPIEJC(List<ICGCFKNNIIE> PAIHLLHNDHC, List<ICGCFKNNIIE> EGNMAKCLBAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0100", Offset = "0x6A9ED00", VA = "0x186AA0100")]
		public DMMKPEDFDBF POJFEPPGGAN(List<ICGCFKNNIIE> PAIHLLHNDHC, List<ICGCFKNNIIE> EGNMAKCLBAJ, MGEGMLPKNPK<Material[]> EHMGIBEGGII, MGEGMLPKNPK<IOEDAEIKENP> CDCHNMLBJHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6A9F2C0", Offset = "0x6A9DEC0", VA = "0x186A9F2C0")]
		public (MGEGMLPKNPK<Material[]>, MGEGMLPKNPK<IOEDAEIKENP>) CGHCPDODIAL(List<ICGCFKNNIIE> PAIHLLHNDHC, List<ICGCFKNNIIE> EGNMAKCLBAJ)
		{
			return default((MGEGMLPKNPK<Material[]>, MGEGMLPKNPK<IOEDAEIKENP>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6A9FFD0", Offset = "0x6A9EBD0", VA = "0x186A9FFD0", Slot = "7")]
		public override CDFOCDBLBEP MKFDDMCECAG(uint LAIJAICKIEF, AvatarSkinnedMeshBoneOrderRemapsData PJODNPEPLIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6A9FA80", Offset = "0x6A9E680", VA = "0x186A9FA80")]
		public CDFOCDBLBEP HHGHGGNFPMO(GameObject IEAGDIIHHEM, uint LAIJAICKIEF, bool MEKGHGGKJPN, bool MHLIGPOFDHH, AvatarSkinnedMeshBoneOrderRemapsData PJODNPEPLIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6A9F720", Offset = "0x6A9E320", VA = "0x186A9F720")]
		public static bool EEKHHCNGPNG(Renderer[] CJIIIMOAALO, string GELMKHHIKPL, [Out] Renderer BKLNPGEHIGM, [Out] Renderer AANDJNLKJPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0400", Offset = "0x6A9F000", VA = "0x186AA0400", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6A9F650", Offset = "0x6A9E250", VA = "0x186A9F650")]
		private (MGEGMLPKNPK<IOEDAEIKENP>, MGEGMLPKNPK<Material[]>) DJFEMBCHBLO()
		{
			return default((MGEGMLPKNPK<IOEDAEIKENP>, MGEGMLPKNPK<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6A9F2A0", Offset = "0x6A9DEA0", VA = "0x186A9F2A0")]
		[CompilerGenerated]
		private void BFEKHGFKMDD(IOEDAEIKENP CMNKPAFMHMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x88C6D0", Offset = "0x88B2D0", VA = "0x18088C6D0")]
		[CompilerGenerated]
		private void IBJCFENFMMG(Material[] CMNKPAFMHMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class LJAONIGADEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public NPOOPLDBDAC avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public PKMJKABHHDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public HHDNLBNGHMC<Dictionary<string, MGEGMLPKNPK<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public LKOMDOLALMB buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public Action<KeyValuePair<string, MGEGMLPKNPK<Texture2D>>> <>9__17;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public LJAONIGADEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6AA2640", Offset = "0x6AA1240", VA = "0x186AA2640")]
		internal bool FPOGBNMGJDC(MCOGOHBOKKE item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6AA26B0", Offset = "0x6AA12B0", VA = "0x186AA26B0")]
		internal void LOPDGAHHIGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6AA2690", Offset = "0x6AA1290", VA = "0x186AA2690")]
		internal void JDMKEPDMEAM(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6AA26D0", Offset = "0x6AA12D0", VA = "0x186AA26D0")]
		internal void LPNKLAEPOGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6AA2700", Offset = "0x6AA1300", VA = "0x186AA2700")]
		internal void PFHHMOHJDMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0")]
		internal HHDNLBNGHMC<Dictionary<string, MGEGMLPKNPK<Texture2D>>> FKFENPGJCCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6AA24C0", Offset = "0x6AA10C0", VA = "0x186AA24C0")]
		internal void DBMIMDLNOHI(Dictionary<string, MGEGMLPKNPK<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6AA2580", Offset = "0x6AA1180", VA = "0x186AA2580")]
		internal void EPFDPBKKNLG(KeyValuePair<string, MGEGMLPKNPK<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x88ABD0", Offset = "0x8897D0", VA = "0x18088ABD0")]
		internal DMMKPEDFDBF CEAFPMAPGGH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OHPCOHCMFHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public LJAONIGADEA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public OHPCOHCMFHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6AA30F0", Offset = "0x6AA1CF0", VA = "0x186AA30F0")]
		internal JAKLJDFJMHL HKKEEPEDGCC(int lod)
		{
			return default(JAKLJDFJMHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class EGPALFNKDDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public List<LKOMDOLALMB> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public EGPALFNKDDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6A9EF30", Offset = "0x6A9DB30", VA = "0x186A9EF30")]
		internal void FKJLNMDCDFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class OBGBOEACHJL : IEnumerator<HGHICIBNEGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private HGHICIBNEGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public PKMJKABHHDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public List<KNEBIBFCKLF> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public List<LKOMDOLALMB> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public Func<int, JAKLJDFJMHL> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public CCGKFDGNEFI materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private HGHICIBNEGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x891CE0", Offset = "0x8908E0", VA = "0x180891CE0")]
		[DebuggerHidden]
		public OBGBOEACHJL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6AA2EA0", Offset = "0x6AA1AA0", VA = "0x186AA2EA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6AA30A0", Offset = "0x6AA1CA0", VA = "0x186AA30A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class MCBBFHPOGFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public AHLOEFIKDDL cancelable;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public MCBBFHPOGFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xB3DAB0", Offset = "0xB3C6B0", VA = "0x180B3DAB0")]
		internal void HCEHKNEMCGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xBCCE10", Offset = "0xBCBA10", VA = "0x180BCCE10")]
		internal void OAHGKMAAGGE(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class BJKALJPMAMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public PKMJKABHHDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public BJKALJPMAMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class CMCPFKINMAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public DLLACJDHDEM defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public KMKFDHANNEH defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public BJKALJPMAMP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public CMCPFKINMAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6A9BB20", Offset = "0x6A9A720", VA = "0x186A9BB20")]
		internal void CONNNAFLMKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xBCBDF0", Offset = "0xBCA9F0", VA = "0x180BCBDF0")]
		internal void MKAFICCNCPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class AHJPDMEHMLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public EPEKNGIBFIO legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public APOKGBONGPG legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public BJKALJPMAMP CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public AHJPDMEHMLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6AAF480", Offset = "0x6AAE080", VA = "0x186AAF480")]
		internal void JFDFBBAPJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xBCCA40", Offset = "0xBCB640", VA = "0x180BCCA40")]
		internal void PFEAJHMNHIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class JBOJAMDKNAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public BCGODMJDFFO overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public JBOJAMDKNAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6ABA400", Offset = "0x6AB9000", VA = "0x186ABA400")]
		internal bool DDFEPDJGNEH(KeyValuePair<string, MCOGOHBOKKE> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private AvatarConfiguration DFMPNPFAJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Transform PKCDJJMLIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private AssetReference CHOIGMNKDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private GameObject CGAGGINEDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private GameObject MJBOFEMMMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private SkinnedMeshRenderer LFAKKHBAECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private AvatarSkinnedMeshBoneOrderRemapsData CKHLPBLNJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Transform[] JNOCBBIGCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Matrix4x4[] JOLMPPALADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Material FBAJOKBAPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private Material KLALEGJBHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private Material NDACJKLJONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Shader AMMDCBNNGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Shader NDOCEGDPEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Animator DMLAOEAHHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Renderer[] AEFDHNEIOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private HDFJPOEIMPO.CLDPEDONPKD PHNGFFLAGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private AvatarBodyPartShapesManager IFLEGPIHDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private IReadOnlyDictionary<string, Transform> PEJBGNFGLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private AvatarFaceShapeData.DAHCNBNLNOG KILJKIOEMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private AvatarBodyShapeData.AIFEAPBJMOI CKLCGLJPAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool ONMAHMEANFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private bool IDGGIJFLALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Color PNPKLODGFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Color HJGCCLJOOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Color IMCEELLMCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Color? HKEJHFLIADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Color? OMHLHDNCHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Color? OAEMEDKJFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Color? JJONHNKOBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private Texture2D NJBIPEAPGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private Texture2D LDIPECCJNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[CanBeNull]
	private MCOGOHBOKKE EFPPHGOHJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Texture DDDBPDAPMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Color OCCOINOEDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public Dictionary<Renderer, CCGKFDGNEFI> BFGKNFJPIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private Dictionary<Renderer, CCGKFDGNEFI> LEJPMCCMDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private Dictionary<string, List<JCBPBEJFNCO>> GGJHGLFGKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private Dictionary<string, List<JCBPBEJFNCO>> DOHMFOEILAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly List<ICGCFKNNIIE> KJHHPDNFGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly List<ICGCFKNNIIE> CHBLGKDKDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly List<ICGCFKNNIIE> HMACEAFOIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly List<ICGCFKNNIIE> JBEPNENPDPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private Dictionary<JCBPBEJFNCO, Material> JKEGBHLJLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private Dictionary<JCBPBEJFNCO, Material> CLDJLFGJGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private SkinnedMeshRenderer[] CLNIOADABAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private SkinnedMeshRenderer[] LNCMNANHGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private SkinnedMeshRenderer[] IDCGJMMMOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private SkinnedMeshRenderer[] DCFEHPDIBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly Dictionary<string, MGEGMLPKNPK<Texture2D>> HFIJHGAOMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly Dictionary<string, MGEGMLPKNPK<Texture2D>> APNNKMPDINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private AdditionalHatData IIKEPDPANDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private AdditionalHatData FHGDGEKEONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private HairData JLLFJGIFJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private HairData FFLHABPMGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private KLLNLHCALDO BOIEEDHBGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private bool? HNELBLCMIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private PositionAndRotation OPHIKJDLAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private Transform JAGCHGDNFDG;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private Material FMIDANDALII;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private Material IKNJKHFDIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private Dictionary<string, MCOGOHBOKKE> JGPADNIGLBE;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly int MGHGCIKOOCO;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly int PHFJOGFGGEJ;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static readonly int JHLKDPOEJGB;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly int PKFFDKAFMMN;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly int IKFDJDCFLEO;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static readonly int MMOKLJOOLBA;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private static readonly int LDALEDFMIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly DBHLBOFDKDO FDKANLLONKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly DBHLBOFDKDO JFFHIOJBOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool EGFFJICJLNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private List<Action> MIGKGBNJGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private EHJFAJIMFLL NMMHIEKOKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private SkinnedMeshRenderer[] MDMFLFBOFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private int IKOILKJGMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private bool BFLBJIPOEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private int BMADLNEAEFJ;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public AvatarConfiguration JDGBAIKJENH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool BCBJDFKMLMA
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xB54350", Offset = "0xB52F50", VA = "0x180B54350")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xB53F30", Offset = "0xB52B30", VA = "0x180B53F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material AHGFBLICMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6AAABE0", Offset = "0x6AA97E0", VA = "0x186AAABE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Material HDKDLHKDKAG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6AA3550", Offset = "0x6AA2150", VA = "0x186AA3550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private bool HJIHNMKEGIN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public CAJNNHABANH ALOKPFIMJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8EA970", Offset = "0x8E9570", VA = "0x1808EA970", Slot = "21")]
		get
		{
			return default(CAJNNHABANH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public DBHLBOFDKDO PEIBMJPKCKI
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xB54960", Offset = "0xB53560", VA = "0x180B54960", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public DBHLBOFDKDO IDLALOBLDGN
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1634AD0", Offset = "0x16336D0", VA = "0x181634AD0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public SkinnedMeshRenderer[] BNFCOLCIDMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x16362D0", Offset = "0x1634ED0", VA = "0x1816362D0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Renderer[] HJEAICENGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x88E980", Offset = "0x88D580", VA = "0x18088E980", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool OIJCCAIKMBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6AA4A10", Offset = "0x6AA3610", VA = "0x186AA4A10", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public HDFJPOEIMPO.CLDPEDONPKD GEKJIPOCLCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x88E9D0", Offset = "0x88D5D0", VA = "0x18088E9D0", Slot = "18")]
		get
		{
			return default(HDFJPOEIMPO.CLDPEDONPKD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int KBPHOELFJBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x18BE510", Offset = "0x18BD110", VA = "0x1818BE510")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6AA91B0", Offset = "0x6AA7DB0", VA = "0x186AA91B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private bool FNOODACNMHB
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6AADDE0", Offset = "0x6AAC9E0", VA = "0x186AADDE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private static bool JPIJHKBLFKB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6AAE1E0", Offset = "0x6AACDE0", VA = "0x186AAE1E0")]
	public PKMJKABHHDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6AAA350", Offset = "0x6AA8F50", VA = "0x186AAA350", Slot = "29")]
	public void KMAKNPIEEHP(LOPJKEANIKI FJNPCNEIMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6AA9A80", Offset = "0x6AA8680", VA = "0x186AA9A80", Slot = "4")]
	public void JICAJABEHFI(NEEDEDOCBFK BJCINDNNCDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6AA91B0", Offset = "0x6AA7DB0", VA = "0x186AA91B0", Slot = "5")]
	public void IKIDMJEEFIB(int LAIJAICKIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6AA84A0", Offset = "0x6AA70A0", VA = "0x186AA84A0", Slot = "10")]
	public void HIJGJCOAMDI(OBACBEJFCEF DEGBFEHLPGA, Texture2D NKCDINKPPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350")]
	public static bool MMHGNOIDDHB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3E10", Offset = "0x6AA2A10", VA = "0x186AA3E10", Slot = "11")]
	public bool CJFPCONJBFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6AA86C0", Offset = "0x6AA72C0", VA = "0x186AA86C0", Slot = "9")]
	public void HKBEOFBOMCA(IHFNNHKDFJC JAFKJJBJJFP, Color? NKKLIFIFGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3F80", Offset = "0x6AA2B80", VA = "0x186AA3F80")]
	private void CNGOFMCOLMP(Action DPJLHNMKPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6AABE90", Offset = "0x6AAAA90", VA = "0x186AABE90", Slot = "6")]
	public void MLACNCLNMOL(MCOGOHBOKKE JCHMKKLIGLN, Texture BKFJLLNIMMJ, Color KFFCGHKLCNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xB53F30", Offset = "0xB52B30", VA = "0x180B53F30", Slot = "7")]
	public void NFIJFKOLADO(bool DPCDCCDMEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xCC11D0", Offset = "0xCBFDD0", VA = "0x180CC11D0", Slot = "8")]
	public void IOEPDPGJIAB(EHJFAJIMFLL HHLMDDDPFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6CA0", Offset = "0x6AA58A0", VA = "0x186AA6CA0", Slot = "14")]
	public LKOMDOLALMB HGIELIGNBOO(NPOOPLDBDAC CCOHEENOMPO, bool LOKEFHBNNOC, int[] BIECHDJLAGL, Func<Dictionary<string, MCOGOHBOKKE>, (LKOMDOLALMB, HHDNLBNGHMC<Dictionary<string, MGEGMLPKNPK<Texture2D>>>)> MHEIIDLOADJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6AAB890", Offset = "0x6AAA490", VA = "0x186AAB890", Slot = "15")]
	public void MABDFPJENGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6AAA2F0", Offset = "0x6AA8EF0", VA = "0x186AAA2F0", Slot = "27")]
	public void KELJCKDMOGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4B90", Offset = "0x6AA3790", VA = "0x186AA4B90", Slot = "28")]
	public void EOPIOHBDIIF([Optional] KLLNLHCALDO BJJPJDOLFGP, [Optional] bool? EDBMFMFLMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6910", Offset = "0x6AA5510", VA = "0x186AA6910")]
	private bool GLEDCPLMNJG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6AAAE50", Offset = "0x6AA9A50", VA = "0x186AAAE50", Slot = "19")]
	public bool LCEINCIEOOJ(HDFJPOEIMPO.CLDPEDONPKD BOEIEOPKABF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6AABF00", Offset = "0x6AAAB00", VA = "0x186AABF00")]
	private bool MLPOMJEBMGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6AA9200", Offset = "0x6AA7E00", VA = "0x186AA9200")]
	private LKOMDOLALMB JCFFHPFLKAB(bool LOKEFHBNNOC, List<KNEBIBFCKLF> DPKGDEBMCMD, int[] BIECHDJLAGL, Func<int, JAKLJDFJMHL> IJFPHBCPDJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6AA9FB0", Offset = "0x6AA8BB0", VA = "0x186AA9FB0")]
	[IteratorStateMachine(typeof(OBGBOEACHJL))]
	private IEnumerator<HGHICIBNEGP> JJDJOCMHAKL(bool LOKEFHBNNOC, List<KNEBIBFCKLF> DPKGDEBMCMD, int[] BIECHDJLAGL, Func<int, JAKLJDFJMHL> IJFPHBCPDJI, CCGKFDGNEFI CIDNBBHKDEP, Material LFCAGJKNFNH, List<LKOMDOLALMB> FJAJMMLOGBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6AAB0D0", Offset = "0x6AA9CD0", VA = "0x186AAB0D0")]
	private void LGFPKBLJCPE(List<KNEBIBFCKLF> DPKGDEBMCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6AACB70", Offset = "0x6AAB770", VA = "0x186AACB70")]
	private LKOMDOLALMB NKMLMGKLHIB(List<KNEBIBFCKLF> DPKGDEBMCMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6AA56F0", Offset = "0x6AA42F0", VA = "0x186AA56F0")]
	private EIIBBDFHPAD FNBFFNMFHGL(List<KNEBIBFCKLF> DPKGDEBMCMD, int LAIJAICKIEF, bool LOKEFHBNNOC, JAKLJDFJMHL HLHOBJEODLD, bool AOBJJFPIDBP, CCGKFDGNEFI CIDNBBHKDEP, Material LFCAGJKNFNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6AAB6F0", Offset = "0x6AAA2F0", VA = "0x186AAB6F0", Slot = "23")]
	public void LKHMKPLAMAG(AvatarFaceShape AOBAPGLIILH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6AAA0F0", Offset = "0x6AA8CF0", VA = "0x186AAA0F0", Slot = "24")]
	public void KBJPNPANDMG(AvatarBodyShape GADFFFNBFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4410", Offset = "0x6AA3010", VA = "0x186AA4410", Slot = "26")]
	public void DCEIFGLLNCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6AA5640", Offset = "0x6AA4240", VA = "0x186AA5640", Slot = "25")]
	public void EPNHEFNGHMM(bool KFNKLLEKGFC, bool BBFKFOEOIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6AAA1B0", Offset = "0x6AA8DB0", VA = "0x186AAA1B0")]
	private void KDADBKCAEGF(SkinnedMeshRenderer LHDDGLLCFMH, int LAIJAICKIEF, Mesh OOKDOLDBLMJ, List<Material> IJFABLAHIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6AA8C00", Offset = "0x6AA7800", VA = "0x186AA8C00")]
	private static Material HOPJMMENHCP(Dictionary<JCBPBEJFNCO, Material> FAHIJCPHIDN, Material OMAJOLGPDDL, PJMBHDJNOOL FJLPKDJMFAO, MFOJKHLIICG BNFBFOOOPHJ, BCGODMJDFFO NOIJPBIAGKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6AA8AC0", Offset = "0x6AA76C0", VA = "0x186AA8AC0")]
	private static PJMBHDJNOOL HLFIBOHOGOA(KNEBIBFCKLF OIPCGKGDBEI, int AHOFCFEMJEN)
	{
		return default(PJMBHDJNOOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6AABFC0", Offset = "0x6AAABC0", VA = "0x186AABFC0")]
	private void MMBLGIFNMFP(int PFCHKADCENO, Material OFCNJEFMNEM, KNEBIBFCKLF OIPCGKGDBEI, [Out] Texture2D GKJEEGGNDPH, [Out] Vector4 PIPJCNIKOKP, [Out] Texture2D POKIAOMDAJE, [Out] Texture2D MCKCEBOPPIN, [Out] Texture2D DCIFDLNICKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6AA9B00", Offset = "0x6AA8700", VA = "0x186AA9B00")]
	private void JJAEADJNNPK(int PFCHKADCENO, Material OFCNJEFMNEM, KNEBIBFCKLF OIPCGKGDBEI, [Out] Color EDPBFFGGELC, [Out] Color IMLKOJLHIJB, [Out] Color BHJLBOAHMJD, [Out] Color FBOBNKOENOM, [Out] Color BAACFFBEFPM, [Out] Color AOAOLJOOIBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6AAAE70", Offset = "0x6AA9A70", VA = "0x186AAAE70")]
	private bool LDGHLIKLPEG(Material OFCNJEFMNEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6AAB840", Offset = "0x6AAA440", VA = "0x186AAB840")]
	private static Material LPOCAIJPCPE(int PFCHKADCENO, JKACIMGFNLP OIPCGKGDBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3D30", Offset = "0x6AA2930", VA = "0x186AA3D30")]
	private static MFOJKHLIICG CIHMJFPIBOJ(KNEBIBFCKLF OIPCGKGDBEI, int AHOFCFEMJEN)
	{
		return default(MFOJKHLIICG);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4160", Offset = "0x6AA2D60", VA = "0x186AA4160")]
	private static void COPGLEAEGOH(Dictionary<string, List<JCBPBEJFNCO>> CANDNHJPNMI, KNEBIBFCKLF NEKCKMHGKJL, Material OMAJOLGPDDL, PJMBHDJNOOL JAFKJJBJJFP, MFOJKHLIICG DEGBFEHLPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6AABAB0", Offset = "0x6AAA6B0", VA = "0x186AABAB0")]
	private static SkinnedMeshRenderer MBICKLBEGFB(Transform IKKGHGOBMPL, Transform IJDABDDACFK, SkinnedMeshRenderer[] CJIIIMOAALO, int LAIJAICKIEF, JAKLJDFJMHL HLHOBJEODLD, bool LOKEFHBNNOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3640", Offset = "0x6AA2240", VA = "0x186AA3640")]
	private void CDBDCNHIIGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6AA68E0", Offset = "0x6AA54E0", VA = "0x186AA68E0")]
	private void FPOMJIOMNOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3800", Offset = "0x6AA2400", VA = "0x186AA3800")]
	private static void CGDCPFMABFN(Dictionary<JCBPBEJFNCO, Material> FAHIJCPHIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4000", Offset = "0x6AA2C00", VA = "0x186AA4000")]
	private static void CNLCMHOMPHN(Dictionary<Renderer, CCGKFDGNEFI> PBMEEEFHIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6AAC6A0", Offset = "0x6AAB2A0", VA = "0x186AAC6A0")]
	private void NHFBICIDGLN(SkinnedMeshRenderer[] CJIIIMOAALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6AA33B0", Offset = "0x6AA1FB0", VA = "0x186AA33B0")]
	private void BCMNDPMFCAO(SkinnedMeshRenderer CJKFIKFIAMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6AA98A0", Offset = "0x6AA84A0", VA = "0x186AA98A0")]
	private void JHNKFELOOKI(List<ICGCFKNNIIE> JMOMMGOADDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3230", Offset = "0x6AA1E30", VA = "0x186AA3230")]
	private void BBNFCFMCEMM(Dictionary<string, MGEGMLPKNPK<Texture2D>> CANDNHJPNMI, bool KHLDBOCKLOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6AABCE0", Offset = "0x6AAA8E0", VA = "0x186AABCE0")]
	private void MBPDPDBEMDO(Dictionary<string, List<JCBPBEJFNCO>> CANDNHJPNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6A50", Offset = "0x6AA5650", VA = "0x186AA6A50")]
	private void GMGCPIKKHAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6AACE50", Offset = "0x6AABA50", VA = "0x186AACE50")]
	private void OCLCFBDOKLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6AAD830", Offset = "0x6AAC430", VA = "0x186AAD830")]
	private void PEEBOGNKKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3450", Offset = "0x6AA2050", VA = "0x186AA3450")]
	private void BJMNELBHCAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6AAC610", Offset = "0x6AAB210", VA = "0x186AAC610")]
	private void NGNEBDJGKMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6AAD360", Offset = "0x6AABF60", VA = "0x186AAD360")]
	private void PCPACGGNPAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6AADE60", Offset = "0x6AACA60", VA = "0x186AADE60")]
	private void PFELBBFEFEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4510", Offset = "0x6AA3110", VA = "0x186AA4510")]
	private void DKCKFEDKCLE(bool LHPEPDIGHHJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6AA97D0", Offset = "0x6AA83D0", VA = "0x186AA97D0")]
	private void JEKFBLLCDDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6AAAD70", Offset = "0x6AA9970", VA = "0x186AAAD70")]
	private void LBMEEABOGMG(bool LHPEPDIGHHJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6AAC7C0", Offset = "0x6AAB3C0", VA = "0x186AAC7C0")]
	private void NHODALIFFFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6AAA700", Offset = "0x6AA9300", VA = "0x186AAA700")]
	private void KNNEDEIGMLJ(Material LFCAGJKNFNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6AADF30", Offset = "0x6AACB30", VA = "0x186AADF30")]
	private void PLGIGAOONOB(Material LFCAGJKNFNH, Color AMNIABHLDPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6AAC3D0", Offset = "0x6AAAFD0", VA = "0x186AAC3D0")]
	private void MODCLCPMCJP(Material LFCAGJKNFNH, Color AMNIABHLDPF, Color LLCKGLMGOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6AAD180", Offset = "0x6AABD80", VA = "0x186AAD180")]
	private void PBKHGHGPNLD(Material LFCAGJKNFNH, Color EDPBFFGGELC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6AAD4B0", Offset = "0x6AAC0B0", VA = "0x186AAD4B0")]
	private void PDDGOCPAFFI(Material LFCAGJKNFNH, Texture2D NKCDINKPPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6AACFE0", Offset = "0x6AABBE0", VA = "0x186AACFE0")]
	private void ODDNICHPKPO(Material LFCAGJKNFNH, Texture NNPBLKDPAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6AABD30", Offset = "0x6AAA930", VA = "0x186AABD30")]
	private void MDNNDDOMAHG(Action<CCGKFDGNEFI> BLEOBPKIPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6AAD6B0", Offset = "0x6AAC2B0", VA = "0x186AAD6B0")]
	private void PDOILCPNIJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6AA8D90", Offset = "0x6AA7990", VA = "0x186AA8D90")]
	private void IFACEMKNMIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3960", Offset = "0x6AA2560", VA = "0x186AA3960")]
	private void CGLMNDCADEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6AA45F0", Offset = "0x6AA31F0", VA = "0x186AA45F0")]
	public void DLMIOFPMIAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6AAD2D0", Offset = "0x6AABED0", VA = "0x186AAD2D0")]
	[CompilerGenerated]
	private void PCGKMLPDKLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6AAA0C0", Offset = "0x6AA8CC0", VA = "0x186AAA0C0")]
	[CompilerGenerated]
	private void JLOAHJACHGA(CCGKFDGNEFI IBGHKNDMEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6AA5660", Offset = "0x6AA4260", VA = "0x186AA5660")]
	[CompilerGenerated]
	private void FJDJFNDAFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6AA68F0", Offset = "0x6AA54F0", VA = "0x186AA68F0")]
	[CompilerGenerated]
	private void GDBKIBJELAF(CCGKFDGNEFI IBGHKNDMEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6AACAE0", Offset = "0x6AAB6E0", VA = "0x186AACAE0")]
	[CompilerGenerated]
	private void NJDEGFJNCDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6AABA90", Offset = "0x6AAA690", VA = "0x186AABA90")]
	[CompilerGenerated]
	private void MBCONPILEAP(CCGKFDGNEFI IBGHKNDMEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6AACDC0", Offset = "0x6AAB9C0", VA = "0x186AACDC0")]
	[CompilerGenerated]
	private void NOAJFJPEOKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6BB0", Offset = "0x6AA57B0", VA = "0x186AA6BB0")]
	[CompilerGenerated]
	private void GPNKMCCGEHC(CCGKFDGNEFI IBGHKNDMEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6AAB7B0", Offset = "0x6AAA3B0", VA = "0x186AAB7B0")]
	[CompilerGenerated]
	private void LNBGNBLHLAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6C70", Offset = "0x6AA5870", VA = "0x186AA6C70")]
	[CompilerGenerated]
	private void HAPFCKOBLIP(CCGKFDGNEFI IBGHKNDMEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4980", Offset = "0x6AA3580", VA = "0x186AA4980")]
	[CompilerGenerated]
	private void DPFCLFPPNMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6AA8D60", Offset = "0x6AA7960", VA = "0x186AA8D60")]
	[CompilerGenerated]
	private void HPJOPEAIHHB(CCGKFDGNEFI IBGHKNDMEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6BE0", Offset = "0x6AA57E0", VA = "0x186AA6BE0")]
	[CompilerGenerated]
	private void HABIJMDGOCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3520", Offset = "0x6AA2120", VA = "0x186AA3520")]
	[CompilerGenerated]
	private void BNNCBGKLPMJ(CCGKFDGNEFI IBGHKNDMEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6AAD140", Offset = "0x6AABD40", VA = "0x186AAD140")]
	[CompilerGenerated]
	private DMMKPEDFDBF OKKJIBCCGJI(KNEBIBFCKLF GAECIBGPFJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6AA31B0", Offset = "0x6AA1DB0", VA = "0x186AA31B0")]
	[CompilerGenerated]
	private void AKDFCLEMHKP(KeyValuePair<string, MGEGMLPKNPK<Texture2D>> IMNOJHDIPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6AA5650", Offset = "0x6AA4250", VA = "0x186AA5650")]
	[CompilerGenerated]
	private void FGOCLMBGEEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6AA8BD0", Offset = "0x6AA77D0", VA = "0x186AA8BD0")]
	[CompilerGenerated]
	private void HMKABMABONP(CCGKFDGNEFI IBGHKNDMEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4B80", Offset = "0x6AA3780", VA = "0x186AA4B80")]
	[CompilerGenerated]
	private void EMHLBNGNNNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6AA91D0", Offset = "0x6AA7DD0", VA = "0x186AA91D0")]
	[CompilerGenerated]
	private void IMOJBHMCCPL(CCGKFDGNEFI IBGHKNDMEOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class NFHONDKJAEA : GGKOGEALPJB
{
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private static readonly int PEMMLCOODPA;

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private static readonly int HMLPDKMCCBF;

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private static readonly int PCKGOPHOGHM;

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private static readonly int LCCBAOADIBF;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private static readonly int OAJGFBONJGP;

	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private static readonly int GNJNIEONPDD;

	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private static readonly int IAHNKAGPEBO;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private static readonly int KOLHPNDHABI;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private static readonly int CMNCCIIEPED;

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private static readonly int NNMLIJCJCFG;

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static readonly int PPDHILFFCCK;

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private static readonly int CPDKBDNHBDE;

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private static readonly int BBCLAPCMNAO;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private static readonly int IOPMAPFBEBM;

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private static readonly int PCHFNDANBKC;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private static readonly int KCMHGAMDENP;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static readonly int MJCOPPLOFLM;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static readonly int GNGNNPODGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private Transform NBPJBCCFNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private Transform KAKCDNKBJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private Transform ELKNGABJGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private Transform FKDFEPMJKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private Transform KILMNEENMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private Transform GNADCHFAJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private Transform OALCIJIMCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private BCCKEDHFHFC BBHHEHPMHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private MaterialPropertyBlock IOPFCJGFBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private SkinnedMeshRenderer[] PFHDDCADLNM;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private MaterialPropertyBlock FNFECJMEDPN
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6ABD770", Offset = "0x6ABC370", VA = "0x186ABD770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool LNEBBFIJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6ABD5F0", Offset = "0x6ABC1F0", VA = "0x186ABD5F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6ABD520", Offset = "0x6ABC120", VA = "0x186ABD520", Slot = "8")]
	public void KMAKNPIEEHP(BCCKEDHFHFC NMFMLCAFPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6ABC140", Offset = "0x6ABAD40", VA = "0x186ABC140", Slot = "5")]
	public void GFAHCBCPPKJ(IJIJJOAHEKP GFOMAJAIDKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6ABD7F0", Offset = "0x6ABC3F0", VA = "0x186ABD7F0", Slot = "6")]
	public void PFHBPCMAEBM(ENAMNFICJJE BEGEGELEOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6ABC250", Offset = "0x6ABAE50", VA = "0x186ABC250")]
	private Vector2 IPAMBNNNNAO(Vector2 DDLIFJHFNAA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6ABC380", Offset = "0x6ABAF80", VA = "0x186ABC380", Slot = "7")]
	public void KLFOGGDIEAM(PBNIDPLGMPH GFOMAJAIDKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6ABBE00", Offset = "0x6ABAA00", VA = "0x186ABBE00")]
	private void EGGBOKBCIDA(PBNIDPLGMPH HBIJONHGOPK, OAECIPABEIA BEKIJEHAAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6ABC170", Offset = "0x6ABAD70", VA = "0x186ABC170")]
	private void IACNIIDFAIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6ABDFF0", Offset = "0x6ABCBF0", VA = "0x186ABDFF0")]
	public NFHONDKJAEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6ABC2B0", Offset = "0x6ABAEB0", VA = "0x186ABC2B0")]
	[CompilerGenerated]
	internal static (float, float) JMOOBIHHCOB(float OFIJEOEBDBD)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6ABC340", Offset = "0x6ABAF40", VA = "0x186ABC340")]
	[CompilerGenerated]
	internal static Vector4 JNDPJDFDOME(Vector2 GKJAMFFKDLE, Vector2 IMPGFCOPLND)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class FNABKOJMJEA : PFIDPFHGBLN
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6AB96D0", Offset = "0x6AB82D0", VA = "0x186AB96D0", Slot = "22")]
	public override float GOHFOFAKBOF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9720", Offset = "0x6AB8320", VA = "0x186AB9720")]
	public FNABKOJMJEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class PFIDPFHGBLN : GBABJKDKLCB
{
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static int HEMMAKOOKOK;

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static int KNKIELLEEMD;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static int HNCEDECPBFO;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static int IEFHFLFDNFN;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static int MEHDPJBDABE;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static int AFHPKECPGMI;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static int ABODBAMODJD;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static int[] BAJGMPDCAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private PAANAJPJBBM BBHHEHPMHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private GKLAGBPIGPE JBIIMGJCPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private int MPHLPCFFECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private float MKNNPICAJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private Animator DMLAOEAHHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	protected bool DNCIMJBCIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	protected AvatarConfiguration MBADDBLIBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private int JIOKHJBFHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private int MMAHDFNNHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private int OOLELJNIPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private bool LCFAFMAKMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private OGEPNFICIOA AEBGIBDPFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private int FIBOPPCFIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private float GMNDCCNJACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private AvatarHandDisplaySettings LEMHJDICLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private CAJNNHABANH CAHEDBBNKGN;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform LFOOLBGKGMM
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x888270", Offset = "0x886E70", VA = "0x180888270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Vector3 MBFKCBKPMPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xFA8970", Offset = "0xFA7570", VA = "0x180FA8970")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xFA86A0", Offset = "0xFA72A0", VA = "0x180FA86A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Quaternion GHMGHMEHOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x105D4B0", Offset = "0x105C0B0", VA = "0x18105D4B0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x105D990", Offset = "0x105C590", VA = "0x18105D990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool EMMNHCPBFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6ABEB80", Offset = "0x6ABD780", VA = "0x186ABEB80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6ABEF30", Offset = "0x6ABDB30", VA = "0x186ABEF30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Vector3 FIIMNPGDAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE9C0", Offset = "0x6ABD5C0", VA = "0x186ABE9C0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6ABF330", Offset = "0x6ABDF30", VA = "0x186ABF330")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Quaternion POBKALIHDOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6ABEBE0", Offset = "0x6ABD7E0", VA = "0x186ABEBE0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6ABEA70", Offset = "0x6ABD670", VA = "0x186ABEA70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public MBPKGLMAGIN FFBCKLPNCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x16DFE40", Offset = "0x16DEA40", VA = "0x1816DFE40", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(MBPKGLMAGIN);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1A1E4E0", Offset = "0x1A1D0E0", VA = "0x181A1E4E0", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public MBPKGLMAGIN DJIKCJLPBJH
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1AEBFA0", Offset = "0x1AEABA0", VA = "0x181AEBFA0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(MBPKGLMAGIN);
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1AEA620", Offset = "0x1AE9220", VA = "0x181AEA620", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public float ECEOPFFBDCL
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xCE3D10", Offset = "0xCE2910", VA = "0x180CE3D10", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x91FA50", Offset = "0x91E650", VA = "0x18091FA50", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool BGKHKFIIGNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6ABEBC0", Offset = "0x6ABD7C0", VA = "0x186ABEBC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool BIBNLHJEEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6ABEFB0", Offset = "0x6ABDBB0", VA = "0x186ABEFB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool CPLPDPMIPLC
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6ABEBD0", Offset = "0x6ABD7D0", VA = "0x186ABEBD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool JMIPMFBLMEF
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x250CB00", Offset = "0x250B700", VA = "0x18250CB00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6ABED70", Offset = "0x6ABD970", VA = "0x186ABED70", Slot = "21")]
	public void KMAKNPIEEHP(PAANAJPJBBM NMFMLCAFPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6ABEAF0", Offset = "0x6ABD6F0", VA = "0x186ABEAF0")]
	public void FKMPPJABNEO(GKLAGBPIGPE OMKEHCNPOBE, AvatarHandDisplaySettings ILNMHLLMEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6ABE9E0", Offset = "0x6ABD5E0", VA = "0x186ABE9E0", Slot = "12")]
	public void CPOAEJEBMBK(bool BFJLCIKEACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6ABEFC0", Offset = "0x6ABDBC0", VA = "0x186ABEFC0", Slot = "11")]
	public void PHMMCJHKLDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0xCE3D10", Offset = "0xCE2910", VA = "0x180CE3D10", Slot = "22")]
	public virtual float GOHFOFAKBOF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6ABEBF0", Offset = "0x6ABD7F0", VA = "0x186ABEBF0")]
	private int KJMJCDJINLM(MBPKGLMAGIN DKLAIGNLIFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6ABE7F0", Offset = "0x6ABD3F0", VA = "0x186ABE7F0")]
	private void BBHALHHFDHB(int MGEANHNLIKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6ABEF10", Offset = "0x6ABDB10", VA = "0x186ABEF10", Slot = "13")]
	public bool LEPAPCFGFLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6ABE9B0", Offset = "0x6ABD5B0", VA = "0x186ABE9B0", Slot = "14")]
	public bool BIBOGMNGNFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6ABEA80", Offset = "0x6ABD680", VA = "0x186ABEA80")]
	private MBPKGLMAGIN DJJJIGMANFK()
	{
		return default(MBPKGLMAGIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0xEA98A0", Offset = "0xEA84A0", VA = "0x180EA98A0", Slot = "15")]
	public void BKBGPCOLONK(bool BFJLCIKEACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6ABEB40", Offset = "0x6ABD740", VA = "0x186ABEB40", Slot = "10")]
	public void GIHCONAGDOF(int MGEANHNLIKI, float KHDAGFLCHCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6ABEAD0", Offset = "0x6ABD6D0", VA = "0x186ABEAD0", Slot = "8")]
	public void FGLEEKBAIOF(OGEPNFICIOA GFCPLDIMNPM, bool ACJNCMDHMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6ABEBB0", Offset = "0x6ABD7B0", VA = "0x186ABEBB0", Slot = "9")]
	public void HPOACKJACJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6ABEF60", Offset = "0x6ABDB60", VA = "0x186ABEF60", Slot = "16")]
	public void OCDODPAHEEL(Transform CDBGCEIGNJC, Vector3 HIAMHGJFEON, Quaternion PJECOBECPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6ABF5E0", Offset = "0x6ABE1E0", VA = "0x186ABF5E0")]
	public PFIDPFHGBLN()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class AvatarHandDisplaySettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public class AnimationOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6AB18A0", Offset = "0x6AB04A0", VA = "0x186AB18A0")]
		public void CIBOHFMOAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6AB19C0", Offset = "0x6AB05C0", VA = "0x186AB19C0")]
		public int DJLGBGHHMNB(int JAFHJCIHEPG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public AvatarHandDisplaySettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class AvatarKneeBendTargetController : MonoBehaviour, MHCAJPGHMFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		[GBPOFPPCAAP(KOFDDAAAPEO.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private Vector3 OHLIENEFHAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private Vector3 AMECGNOCDGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private Vector3 LDAJLJGMCIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private Matrix4x4 LLGMEECEMAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private bool FPMFIJBGDOD;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6AB1EA0", Offset = "0x6AB0AA0", VA = "0x186AB1EA0", Slot = "4")]
		public void UpdateController(float EOJDMAMGKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6AB1E90", Offset = "0x6AB0A90", VA = "0x186AB1E90", Slot = "6")]
		public void SetEnabled(bool CABLCDOIFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6AB1A30", Offset = "0x6AB0630", VA = "0x186AB1A30")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6AB2560", Offset = "0x6AB1160", VA = "0x186AB2560")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[CGPAMFEMIJK]
public struct BAFELBLGFEB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	[ReadOnly]
	public APOKGBONGPG GPBNFGOPAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	[ReadOnly]
	public int PLPKLDMOJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public EPEKNGIBFIO PCNDABOECOJ;

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6AB35B0", Offset = "0x6AB21B0", VA = "0x186AB35B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[NativeContainer]
[CGPAMFEMIJK]
public struct EPEKNGIBFIO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public NativeArray<Vector3> JBDNLNKKEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public NativeArray<Vector3> IAKDOGKHHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public NativeArray<Vector4> OJJIMADMNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public NativeArray<Vector2> OPHOGBEFGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public NativeArray<Vector2> OBPONDMPBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<Vector2> EPKLJNDEIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public NativeArray<Vector2> BJCHLJHIJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<Color> JKALEKKLPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public NativeArray<int> NKPJGNHJMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public NativeArray<int> FDODKBBOEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private NativeArray<int> IDMNEPOBIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private NativeArray<int> ODPBLCOJEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<int> JDAMKOAFCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<int> HJMMNFAOHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<int> EOKJIACNKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<BoneWeight> OMIBEAFNPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private NativeArray<int> HHLMDDDPFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private bool PNICHAHNEGC;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int OBOJBPKHHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6AB8830", Offset = "0x6AB7430", VA = "0x186AB8830")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x6AB8A20", Offset = "0x6AB7620", VA = "0x186AB8A20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int JIHGOGBLBBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6AB8820", Offset = "0x6AB7420", VA = "0x186AB8820")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6AB9230", Offset = "0x6AB7E30", VA = "0x186AB9230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int BFOLKBLNOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6AB8BD0", Offset = "0x6AB77D0", VA = "0x186AB8BD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6AB8BA0", Offset = "0x6AB77A0", VA = "0x186AB8BA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9270", Offset = "0x6AB7E70", VA = "0x186AB9270")]
	public EPEKNGIBFIO(int MMHKOHFBIEC, int CGNHBAFBAON, int DJLGMFHICPD, int LINHEFPJCIN, Allocator ICLGONBNBJO, int HHJKKKMPAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8B30", Offset = "0x6AB7730", VA = "0x186AB8B30")]
	public void IJIKMPLDAGM(int MFJLAMOCOBC, Vector3 PPIEANOJMKF, Vector3 BJFIIBACKFL, Vector4 APOGBJPOAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8CB0", Offset = "0x6AB78B0", VA = "0x186AB8CB0")]
	public void MAMFACPIOGI(int MFJLAMOCOBC, BoneWeight MIECBIMMGFM, NativeSlice<byte> NKMOBGCBIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8A00", Offset = "0x6AB7600", VA = "0x186AB8A00")]
	public Color HEDPPPEDOKC(int MFJLAMOCOBC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8BB0", Offset = "0x6AB77B0", VA = "0x186AB8BB0")]
	public void KFMBNMCILMB(int MFJLAMOCOBC, Color NPAFKDGAFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8A30", Offset = "0x6AB7630", VA = "0x186AB8A30")]
	public void HMCIFHHFFAC(byte PIHPKFAKGDI, int MFJLAMOCOBC, Vector2 EJPLDDBIHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6AB89F0", Offset = "0x6AB75F0", VA = "0x186AB89F0")]
	public void ECFMBMGIMNN(int MFJLAMOCOBC, int CFEEMFEIJAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9240", Offset = "0x6AB7E40", VA = "0x186AB9240")]
	public bool OBIJEBFKNBI(int PIHPKFAKGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8BE0", Offset = "0x6AB77E0", VA = "0x186AB8BE0")]
	public void LPPKHNKDBFB(int MJLFKJHALEH, int APMEPKJBNGD, int OLBMNABBGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8A80", Offset = "0x6AB7680", VA = "0x186AB8A80")]
	public int[] IFMPFHHLEFM(int MJLFKJHALEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8E50", Offset = "0x6AB7A50", VA = "0x186AB8E50")]
	private NativeSlice<int> MAOOADNDAFI(int MJLFKJHALEH)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8840", Offset = "0x6AB7440", VA = "0x186AB8840", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8EE0", Offset = "0x6AB7AE0", VA = "0x186AB8EE0")]
	public Mesh MKMMECHIGIB([Optional] string MGLPPLPDHDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[CGPAMFEMIJK]
[NativeContainer]
[DefaultMember("Item")]
public struct APOKGBONGPG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<Vector3> JBDNLNKKEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<Vector3> IAKDOGKHHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public NativeArray<Vector4> OJJIMADMNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeArray<Vector2> OPHOGBEFGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public NativeArray<Vector2> OBPONDMPBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public NativeArray<Vector2> EPKLJNDEIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<Vector2> BJCHLJHIJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<Color> JKALEKKLPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<int> BJNKIBDDIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeArray<int> MNMJJPBHDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeArray<int> LGDEBADNKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public NativeArray<int> JOHLMPOAICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeArray<bool> KMJOAFPGMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<int> GBOJMEDGMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<int> AGKLLHPOOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeArray<BoneWeight> EBAEAONBKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private NativeArray<Matrix4x4> DNPNBHNNFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private NativeArray<int> FPJJCLFODFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private NativeArray<byte> LCPJFBIBPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private NativeArray<int> AAEFGIIBNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private NativeArray<int> LECAMJGIDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeArray<sbyte> KOFKOILEEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeArray<byte> PFKNBMGCLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private NativeArray<int> IFHCDBDFDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private bool PNICHAHNEGC;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int FABPAHJJAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2161EC0", Offset = "0x2160AC0", VA = "0x182161EC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int EFJKALADMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x114BFD0", Offset = "0x114ABD0", VA = "0x18114BFD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int EFCBBCEHDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x6AAFC30", Offset = "0x6AAE830", VA = "0x186AAFC30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int IFHKGKJPFLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x6AAFF10", Offset = "0x6AAEB10", VA = "0x186AAFF10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6AAFEF0", Offset = "0x6AAEAF0", VA = "0x186AAFEF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int OBOJBPKHHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6AAFC60", Offset = "0x6AAE860", VA = "0x186AAFC60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6AAFF00", Offset = "0x6AAEB00", VA = "0x186AAFF00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int GJILMPBJIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6AAFED0", Offset = "0x6AAEAD0", VA = "0x186AAFED0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6AAFEE0", Offset = "0x6AAEAE0", VA = "0x186AAFEE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public HABOPHMGAFA JLIMCKPKMMD
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6AAFF20", Offset = "0x6AAEB20", VA = "0x186AAFF20")]
		get
		{
			return default(HABOPHMGAFA);
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6AB0010", Offset = "0x6AAEC10", VA = "0x186AB0010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public byte ALBBJNNLNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6AAFF30", Offset = "0x6AAEB30", VA = "0x186AAFF30")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6AAF700", Offset = "0x6AAE300", VA = "0x186AAF700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public IFGOKCGIICD CECFGNBJFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6AAF710", Offset = "0x6AAE310", VA = "0x186AAF710")]
		get
		{
			return default(IFGOKCGIICD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0020", Offset = "0x6AAEC20", VA = "0x186AB0020")]
	public APOKGBONGPG(IList<Mesh> EHAODLEOIEE, IList<Matrix4x4> MFOPICIHFCG, IList<bool> KMJOAFPGMPB, byte EAFBJALFMMG, IList<byte[]> LCHEBACOEPH, IList<int> BJMONNBJICP, IList<bool> JEMDHJOKMOL, IList<int> GBOJMEDGMPN, IList<int> GHDGPMNOIDM, IList<int> GCGKNDJGNEF, Allocator ICLGONBNBJO, HABOPHMGAFA JGEACNBABNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6AAFF40", Offset = "0x6AAEB40", VA = "0x186AAFF40")]
	public EPEKNGIBFIO MEFEEKEOECC(Allocator ICLGONBNBJO)
	{
		return default(EPEKNGIBFIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6AAFC70", Offset = "0x6AAE870", VA = "0x186AAFC70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[CGPAMFEMIJK]
public class LPEJOFCEPNE : MOBJIMEGBKA
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6ABAE50", Offset = "0x6AB9A50", VA = "0x186ABAE50")]
	public APOKGBONGPG LMHOLIKMHGB()
	{
		return default(APOKGBONGPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C1A0", Offset = "0x6A9ADA0", VA = "0x186A9C1A0")]
	public LPEJOFCEPNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct IFGOKCGIICD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeSlice<Vector3> JBDNLNKKEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public NativeSlice<Vector3> IAKDOGKHHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public NativeSlice<Vector4> OJJIMADMNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public NativeSlice<Vector2> OPHOGBEFGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public NativeSlice<Vector2> OBPONDMPBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public NativeSlice<Vector2> EPKLJNDEIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public NativeSlice<Vector2> BJCHLJHIJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public NativeSlice<Color> JKALEKKLPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public NativeSlice<int> OMOELAOCBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public NativeSlice<int> JOHLMPOAICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public NativeSlice<BoneWeight> EBAEAONBKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public NativeSlice<byte> IEHOKAILDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public int BHNLLMGHOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public Matrix4x4 OEAEMILAMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public int LLBPBLPPGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public NativeSlice<byte> NKMOBGCBIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public bool NBGBCCCPINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public int JPKLNMDEEPF;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal readonly struct JCBPBEJFNCO : IEquatable<JCBPBEJFNCO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	internal readonly Material CLNADELPCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	internal readonly PJMBHDJNOOL NFECHNDPDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	internal readonly MFOJKHLIICG DMMHFNEEPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	internal readonly BCGODMJDFFO FCGPGKINHAE;

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA8A0", Offset = "0x6AB94A0", VA = "0x186ABA8A0")]
	public JCBPBEJFNCO(Material OFCNJEFMNEM, PJMBHDJNOOL FJLPKDJMFAO, MFOJKHLIICG BNFBFOOOPHJ, BCGODMJDFFO NOIJPBIAGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA680", Offset = "0x6AB9280", VA = "0x186ABA680", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA480", Offset = "0x6AB9080", VA = "0x186ABA480", Slot = "4")]
	public bool Equals(JCBPBEJFNCO FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA500", Offset = "0x6AB9100", VA = "0x186ABA500", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA5E0", Offset = "0x6AB91E0", VA = "0x186ABA5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, HLGIGNKBIOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		[Header("Configuration")]
		[SerializeField]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		[Header("Configuration")]
		[SerializeField]
		private CAJNNHABANH avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[SerializeField]
		private AssetReference avatarSkinAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		private Transform HeadTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private GGDKLOOMBAO FOGBOGOIMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private GGKOGEALPJB LLKFKLJPMBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private GBABJKDKLCB MJEJDGNNKKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private GBABJKDKLCB CPEJHKENLJB;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public GGDKLOOMBAO JGOLMPLGOMH
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x6AB3450", Offset = "0x6AB2050", VA = "0x186AB3450", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public GGKOGEALPJB EJGFHGDGPDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x6AB34A0", Offset = "0x6AB20A0", VA = "0x186AB34A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public GBABJKDKLCB GFHFMLENLJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x6AB34F0", Offset = "0x6AB20F0", VA = "0x186AB34F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public GBABJKDKLCB PAGLHKAONJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x6AB3540", Offset = "0x6AB2140", VA = "0x186AB3540", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Transform OMCLIGNHNHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x6AB3590", Offset = "0x6AB2190", VA = "0x186AB3590", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public CAJNNHABANH AJOKNLHADPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x893E00", Offset = "0x892A00", VA = "0x180893E00", Slot = "12")]
			get
			{
				return default(CAJNNHABANH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6AB2570", Offset = "0x6AB1170", VA = "0x186AB2570")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6AB32F0", Offset = "0x6AB1EF0", VA = "0x186AB32F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6AB2BC0", Offset = "0x6AB17C0", VA = "0x186AB2BC0", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6AB32F0", Offset = "0x6AB1EF0", VA = "0x186AB32F0", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6AB2600", Offset = "0x6AB1200", VA = "0x186AB2600", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3360", Offset = "0x6AB1F60", VA = "0x186AB3360")]
		public void UpdatePostIKAnimControllers(float EOJDMAMGKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3260", Offset = "0x6AB1E60", VA = "0x186AB3260")]
		private void LAFEEFPCDAE(GameObject PLAMADMDGIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6AB2F50", Offset = "0x6AB1B50", VA = "0x186AB2F50")]
		private GGDKLOOMBAO JOJJMJAMCAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6AB2C50", Offset = "0x6AB1850", VA = "0x186AB2C50")]
		private GGKOGEALPJB JHJOLGINLJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6AB2930", Offset = "0x6AB1530", VA = "0x186AB2930")]
		private GBABJKDKLCB HMOFEJALKGK(KOEIKGEMDHH HFFIHMCMHMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3440", Offset = "0x6AB2040", VA = "0x186AB3440")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class CCGKFDGNEFI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private MaterialPropertyBlock JMBDIKBEEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	public Color? BOKOBEGKHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	public Color? BMOOKOILDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	public Color? APPDPNHCDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	public Color? KCBABLELOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	public Color PEOGGOJHGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	public Color NOBEEKNJHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	public Color INLNKLEOKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	public Texture2D NNGILDENGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	public Texture2D OKMJBAKGABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private Dictionary<JCBPBEJFNCO, int> DNCFDDANHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private PJMBHDJNOOL[] ELFHMPENPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private MFOJKHLIICG[] MEFJHLFGONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public Vector4[] EGCMJPELKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public Vector4[] OKPHFIJJAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public Vector4[] PIEBGMNFIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public Vector4[] OPAONKHIKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public Vector4[] FAMAJLFAAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public Vector4[] EILNJJKBGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private List<Texture2D> OKEBICBONIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private Vector4[] BFKLNHMICNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private List<Texture2D> LIHDPAJMEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private float[] EBGCPLJGLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private Vector4[] GPNPFGPAGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private float[] PEJCJCPOHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public float[] PHODOGPHCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private List<Texture2D> PBBDPLDAKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private float[] KCEECDOMAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private List<Texture2D> FLJHKLNAJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private Vector4[] PHNMFNNDJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private float[] EIFHLMLACBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private Vector4[] MPCBGJDHEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public float[] CCONCEGNEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public Texture2DArray EBNMPNHHIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public Texture2DArray MONLBIDNPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public Texture2DArray IBKNKGBIEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public Texture2DArray ANHHMENBIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private bool MAMMABALPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private int CCDAFDBCNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private Vector2? DFBDDLPJBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private TextureFormat MMGBFDEPKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private Vector2? OBKPIEABFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private TextureFormat BPJFNJDAIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private Vector2? HKCDFGFCDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private TextureFormat OEPELGPOLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private Vector2? OIMPNIENGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private TextureFormat CNIFFKAOKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private bool IMLFLKFFANH;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private static int KFNECGMEGHP;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static int BPJABAHIDEA;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private static int HFAFNHHJDMN;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static int DJNANMEBPPO;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static int JGOCBOBGPJC;

	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private static int HEJAGNIIACB;

	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private static int NNLKCCNLDAG;

	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private static int ANJMHMFCLAL;

	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private static int ILFPLOEKBDD;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static int KALKKDJOHKB;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static int EJFNIECCJCM;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static int LHELDHEIGNN;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static int AEOFDKOAKDF;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static int FLHFEKCLFHO;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static int MEHANBPFGLH;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static int DNHLGHDDFCD;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static int BFDFLFBIMGB;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static int NBGFBGCDECE;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static int GNGDGIFPCGG;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static int FCBDILNIHLP;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6AB6B20", Offset = "0x6AB5720", VA = "0x186AB6B20")]
	private CCGKFDGNEFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7010", Offset = "0x6AB5C10", VA = "0x186AB7010")]
	public CCGKFDGNEFI(Color FGODHLCKOKF, Color KAOHPAKJAIM, Color FFIDNAJJBKL, Color? AGGNFEALDKK, Color? MIFAKEDHACL, Color? MJKPLJLKONC, Texture2D MHAABMADIIM, Texture2D KMKEAJAKKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6AB6300", Offset = "0x6AB4F00", VA = "0x186AB6300")]
	internal int NJEHBEEFOJC(Material HDPMKAKFGBH, PJMBHDJNOOL FJLPKDJMFAO, MFOJKHLIICG BNFBFOOOPHJ, BCGODMJDFFO NOIJPBIAGKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6AB63F0", Offset = "0x6AB4FF0", VA = "0x186AB63F0")]
	private int NJEHBEEFOJC(JCBPBEJFNCO NONKDEOLPHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4510", Offset = "0x6AB3110", VA = "0x186AB4510")]
	internal int AEJBGPEFEFC(Material HDPMKAKFGBH, Color EDPBFFGGELC, Color IMLKOJLHIJB, Color BHJLBOAHMJD, Color FBOBNKOENOM, Color BAACFFBEFPM, Texture2D LJLMEFBIOGI, Vector4 FOMPLBEFJKI, Texture2D LDGBIIJAKGD, Vector4 HCKEENIHOJI, float BKHFHHAOKLB, float JLGBKPNHKOD, Texture2D OKMAGMPMNHH, Vector4 GBCLONFMPKI, float FIOOPFNHBOC, Texture2D IJPGIJBELKH, Color AOAOLJOOIBF, Vector4 EOCBIKDAPAE, PJMBHDJNOOL FJLPKDJMFAO, MFOJKHLIICG BNFBFOOOPHJ, BCGODMJDFFO NOIJPBIAGKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5320", Offset = "0x6AB3F20", VA = "0x186AB5320")]
	private void IBGIKDMLBKB(List<Texture2D> OKEBICBONIM, [Out] Texture2DArray BCAKBOJFCIK, [Out] Texture2DArray LBJBOOPJJAI, [Out] Texture2DArray GOMLCHPCGGK, [Out] Texture2DArray FKEAADOFCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6AB6680", Offset = "0x6AB5280", VA = "0x186AB6680")]
	public void OKFKKBCIMPF(Shader KODMBDAGABO, Renderer HKFOEGKIJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6AB54E0", Offset = "0x6AB40E0", VA = "0x186AB54E0")]
	private void JHHIOHPJCLI(Shader KODMBDAGABO, Renderer HKFOEGKIJPH, int LLCDNIGMMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6AB6480", Offset = "0x6AB5080", VA = "0x186AB6480")]
	private Color NNOFFLLMODC(Color FFJOBGBLBCO, PJMBHDJNOOL JAFKJJBJJFP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6AB50E0", Offset = "0x6AB3CE0", VA = "0x186AB50E0")]
	private Color AKGCGPMPJLJ(Color NEPPCNMBGMJ, PJMBHDJNOOL JAFKJJBJJFP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6AB61A0", Offset = "0x6AB4DA0", VA = "0x186AB61A0")]
	private bool LOPBAFGFHPO(Texture2D PAEPIGLKLMB, MFOJKHLIICG DEGBFEHLPGA, [Out] Texture2D CLGMKMNPFHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5270", Offset = "0x6AB3E70", VA = "0x186AB5270")]
	private void HECODHECNAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5230", Offset = "0x6AB3E30", VA = "0x186AB5230", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class DJMNMNKFJNK
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static readonly int[] LGFIKDCFEMD;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private static readonly int[] ECDMKMBKGJB;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public static int[] IOODBLIOBBF
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6AB78C0", Offset = "0x6AB64C0", VA = "0x186AB78C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7930", Offset = "0x6AB6530", VA = "0x186AB7930")]
	public static int[] OFKNCDFIMGE(bool MPGECBHCFHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7830", Offset = "0x6AB6430", VA = "0x186AB7830")]
	public static int JCGILFAJHPG(PFKPGFLKLMF BNOJCIFANMJ, bool MPGECBHCFHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7820", Offset = "0x6AB6420", VA = "0x186AB7820")]
	private static int CKPKPIEPAEP(PFKPGFLKLMF BNOJCIFANMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7910", Offset = "0x6AB6510", VA = "0x186AB7910")]
	private static int LGKBKCINCMB(PFKPGFLKLMF BNOJCIFANMJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class MHDHPIDCMOE
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class CJMIOGHEHJH : IEnumerator<HGHICIBNEGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private HGHICIBNEGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		private HGHICIBNEGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x891CE0", Offset = "0x8908E0", VA = "0x180891CE0")]
		[DebuggerHidden]
		public CJMIOGHEHJH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xBCB500", Offset = "0xBCA100", VA = "0x180BCB500", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6AB70D0", Offset = "0x6AB5CD0", VA = "0x186AB70D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
	public static void DPKFJBMBANL(string MJDOIIBKEKN, int LAIJAICKIEF, long BLKOOMCPFJF, long OBDALCFAJEA, long GCKAACMEIHF, long EPGHMNJDMJH, long LOBMBNHPHBD, long FACIAJGHBBC, long OAJHPDHAABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6ABB1F0", Offset = "0x6AB9DF0", VA = "0x186ABB1F0")]
	public static EIIBBDFHPAD AEFEMEDFJCH(JobHandle LEEFKNAIOLM, bool APBCIKJMDFO, bool HJIHNMKEGIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6ABB2E0", Offset = "0x6AB9EE0", VA = "0x186ABB2E0")]
	[IteratorStateMachine(typeof(CJMIOGHEHJH))]
	private static IEnumerator<HGHICIBNEGP> EDGHBKMKONK(JobHandle JBFBMCPGKHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class GPJNMEHLPHI
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum IOEPLMDNLOK
	{
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		General,
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly int FONBOLKHMBL;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly int ADFMJEDIKAO;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly int JPFHJACEFBK;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public static readonly int NBBFCHOHCAB;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public static readonly int GCJGDDDGJEL;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public static readonly int PLOOLBCLLJB;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public static readonly int BCBIMODFLKE;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public static readonly int LEKNNJMBDPN;

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9780", Offset = "0x6AB8380", VA = "0x186AB9780")]
	public static bool IIALPLCFBHK(Material OFCNJEFMNEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6AB97F0", Offset = "0x6AB83F0", VA = "0x186AB97F0")]
	public static bool NNJJEALNEMH(Material OFCNJEFMNEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class NCFKGGBBAGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	private List<int> KGGGLKKAIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	private List<HDIJHBGCEHJ> AIGOIALJJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	private HashSet<Transform> PKBAGNCMLFP;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6ABBB30", Offset = "0x6ABA730", VA = "0x186ABBB30")]
	public static NCFKGGBBAGH MMBAGNAAKPG(Transform APOGBJPOAAH, Dictionary<Transform, OutfitType?> LLGAPGKOIND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6ABB350", Offset = "0x6AB9F50", VA = "0x186ABB350")]
	private void IAMEIPEBGHC(Transform APOGBJPOAAH, BCGODMJDFFO NOIJPBIAGKF, Dictionary<Transform, OutfitType?> LLGAPGKOIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6ABB610", Offset = "0x6ABA210", VA = "0x186ABB610")]
	private void IBEGAADNEDP(Transform NPOGHJKFAJL, BCGODMJDFFO NOIJPBIAGKF, bool EAPDNEKDEDO, OutfitType? FOLCNFDNCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6ABB740", Offset = "0x6ABA340", VA = "0x186ABB740")]
	public DLNKDIDHJCM MDOMDHDAFIA(HashSet<string> GHFBDMPACBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6ABBCD0", Offset = "0x6ABA8D0", VA = "0x186ABBCD0")]
	public NCFKGGBBAGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class DLNKDIDHJCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private List<HDIJHBGCEHJ> AIGOIALJJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private List<Matrix4x4> HCFOLHGCMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private Transform[] EDCJKGLHPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	private Matrix4x4[] JHEANGHJBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private Dictionary<MEMGKJGJDGD, int> BPJGIEJLNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	private List<AEMOAKPHOMA> OMNPAOPENDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private bool AKAOICIOEIP;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public int DNBGNCFCKIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7C80", Offset = "0x6AB6880", VA = "0x186AB7C80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public Transform[] OLABCEIJEBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7AB0", Offset = "0x6AB66B0", VA = "0x186AB7AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Matrix4x4[] CNENCEDDBDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7C10", Offset = "0x6AB6810", VA = "0x186AB7C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7FE0", Offset = "0x6AB6BE0", VA = "0x186AB7FE0")]
	public void IBEGAADNEDP(Transform NPOGHJKFAJL, BCGODMJDFFO NOIJPBIAGKF, OutfitType? FOLCNFDNCAE, bool FKCBOPCLKGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7CC0", Offset = "0x6AB68C0", VA = "0x186AB7CC0")]
	private void IBEGAADNEDP(Transform NPOGHJKFAJL, BCGODMJDFFO NOIJPBIAGKF, OutfitType? FOLCNFDNCAE, bool FKCBOPCLKGC, Matrix4x4 MIONNIBCOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6AB83C0", Offset = "0x6AB6FC0", VA = "0x186AB83C0")]
	public int LKBFGAAHNIP(MEMGKJGJDGD NONKDEOLPHL, bool KLGPGGMOLPH, [Optional] OutfitType? FOLCNFDNCAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6AB82C0", Offset = "0x6AB6EC0", VA = "0x186AB82C0")]
	public int KEIHDCPKCPG(BCGODMJDFFO NOIJPBIAGKF, [Optional] OutfitType? FOLCNFDNCAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6AB81D0", Offset = "0x6AB6DD0", VA = "0x186AB81D0")]
	public void IJJAOBOGMIB(MEMGKJGJDGD NONKDEOLPHL, Matrix4x4 ABKKEJBBOLK, bool KLGPGGMOLPH = false, [Optional] OutfitType? FOLCNFDNCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8570", Offset = "0x6AB7170", VA = "0x186AB8570")]
	public Matrix4x4 PDJEPFKBOHH(MEMGKJGJDGD NONKDEOLPHL, bool KLGPGGMOLPH, [Optional] OutfitType? FOLCNFDNCAE)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0xCA8410", Offset = "0xCA7010", VA = "0x180CA8410")]
	public void DFLKNOJPHJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x6AB86B0", Offset = "0x6AB72B0", VA = "0x186AB86B0")]
	public DLNKDIDHJCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct MEMGKJGJDGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public readonly string MAKGFMLHOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public readonly BCGODMJDFFO FCGPGKINHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public readonly OutfitType? FKJIENLEKEB;

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x6ABB1B0", Offset = "0x6AB9DB0", VA = "0x186ABB1B0")]
	public MEMGKJGJDGD(string COGFFGKCNFP, BCGODMJDFFO NOIJPBIAGKF, [Optional] OutfitType? FOLCNFDNCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x6ABB100", Offset = "0x6AB9D00", VA = "0x186ABB100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x6ABB040", Offset = "0x6AB9C40", VA = "0x186ABB040")]
	public bool HELLGNHACPM(MEMGKJGJDGD FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6ABAF40", Offset = "0x6AB9B40", VA = "0x186ABAF40", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6ABAFE0", Offset = "0x6AB9BE0", VA = "0x186ABAFE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct AEMOAKPHOMA : IEquatable<AEMOAKPHOMA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public readonly BCGODMJDFFO FCGPGKINHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public readonly OutfitType? JEGHFDGKPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public readonly int DPLCOGCKPNM;

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF470", Offset = "0x6AAE070", VA = "0x186AAF470")]
	public AEMOAKPHOMA(BCGODMJDFFO NOIJPBIAGKF, int EBGEBELFKKE, [Optional] OutfitType? EDCEFCPMOFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF3B0", Offset = "0x6AADFB0", VA = "0x186AAF3B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x182BE10", Offset = "0x182AA10", VA = "0x18182BE10")]
	public bool DCJIGGDKFGH(BCGODMJDFFO NOIJPBIAGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF1A0", Offset = "0x6AADDA0", VA = "0x186AAF1A0")]
	public bool BHENJMAHFFE(OutfitType? EDCEFCPMOFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF220", Offset = "0x6AADE20", VA = "0x186AAF220", Slot = "4")]
	public bool Equals(AEMOAKPHOMA FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF270", Offset = "0x6AADE70", VA = "0x186AAF270", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF360", Offset = "0x6AADF60", VA = "0x186AAF360", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct HDIJHBGCEHJ : IEquatable<HDIJHBGCEHJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public readonly Transform EKEDHPNGKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public readonly bool GCEIOFHOBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public readonly BCGODMJDFFO MKPJFJNHHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public readonly OutfitType? FKJIENLEKEB;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9E80", Offset = "0x6AB8A80", VA = "0x186AB9E80")]
	public HDIJHBGCEHJ(Transform NPOGHJKFAJL, bool EAPDNEKDEDO, BCGODMJDFFO ENNFAGIDNMJ, [Optional] OutfitType? IJELGEJAFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9C70", Offset = "0x6AB8870", VA = "0x186AB9C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9A20", Offset = "0x6AB8620", VA = "0x186AB9A20", Slot = "4")]
	public bool Equals(HDIJHBGCEHJ FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9B20", Offset = "0x6AB8720", VA = "0x186AB9B20", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9C00", Offset = "0x6AB8800", VA = "0x186AB9C00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface KJOCOJLPEIO
{
	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DLLLDIJOFCP(Mesh OOKDOLDBLMJ, Matrix4x4 KPFCIJLGBEN, byte[] NKMOBGCBIFM, bool DHJMFNCHEBJ = false, HDFJPOEIMPO.CLDPEDONPKD AKCJEBEEFLL = (HDFJPOEIMPO.CLDPEDONPKD)0, int GBOJMEDGMPN = -1, bool KMJOAFPGMPB = false);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHINCDBNIEG(Allocator ICLGONBNBJO, HABOPHMGAFA JGEACNBABNO, byte EAFBJALFMMG, [Optional] IList<int> GHDGPMNOIDM, [Optional] IList<int> OJJOOHMIDAI);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct IOEDAEIKENP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public readonly GameObject IEAGDIIHHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private readonly AvatarItemMaterial PIIEJEHEGPM;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0xC7E130", Offset = "0xC7CD30", VA = "0x180C7E130")]
	public IOEDAEIKENP(GameObject IEAGDIIHHEM, AvatarItemMaterial PIIEJEHEGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA370", Offset = "0x6AB8F70", VA = "0x186ABA370")]
	public void BFNPLONLHLK(Material OFCNJEFMNEM, int PFCHKADCENO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class CMFBGFAHJCL : HMNPGEFNICB<Task<(GameObject, AvatarItemMaterial)>, IOEDAEIKENP>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct LIJJHFCPKAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6ABA8E0", Offset = "0x6AB94E0", VA = "0x186ABA8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6ABADE0", Offset = "0x6AB99E0", VA = "0x186ABADE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private MGEGMLPKNPK<GameObject> DEPNIEJDIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private MGEGMLPKNPK<AvatarItemMaterial> IIMDGLKBENL;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7790", Offset = "0x6AB6390", VA = "0x186AB7790")]
	private CMFBGFAHJCL(Task<(GameObject, AvatarItemMaterial)> NEEKHCPCAAC, MGEGMLPKNPK<GameObject> DAEOHLJEICM, MGEGMLPKNPK<AvatarItemMaterial> IDHOFDKOIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6AB71A0", Offset = "0x6AB5DA0", VA = "0x186AB71A0")]
	public static CMFBGFAHJCL ELGDCMPCLII(AssetReference DEALELKOHMD, [Optional] AssetReference KCELFLNAKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6AB75C0", Offset = "0x6AB61C0", VA = "0x186AB75C0", Slot = "11")]
	protected override IOEDAEIKENP EOPCAPHLOIN(Task<(GameObject, AvatarItemMaterial)> BMOOBLAOMLB)
	{
		return default(IOEDAEIKENP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7120", Offset = "0x6AB5D20", VA = "0x186AB7120", Slot = "12")]
	protected override void EBFIFEDLDIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7660", Offset = "0x6AB6260", VA = "0x186AB7660")]
	[AsyncStateMachine(typeof(LIJJHFCPKAF))]
	private static Task<(GameObject, AvatarItemMaterial)> MPKNBLPAKCN(Task<GameObject> CHPGGJKACMD, Task<AvatarItemMaterial> JOMGMCPGEDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class IKJLDKGIMJP
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class NJAMAHGNJOP : HMNPGEFNICB<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private MGEGMLPKNPK<MaterialMapAsset> JBFBMCPGKHE;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE510", Offset = "0x6ABD110", VA = "0x186ABE510")]
		public NJAMAHGNJOP(MGEGMLPKNPK<MaterialMapAsset> JBFBMCPGKHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE0F0", Offset = "0x6ABCCF0", VA = "0x186ABE0F0", Slot = "11")]
		protected override Material[] EOPCAPHLOIN(Task<MaterialMapAsset> NEEKHCPCAAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE090", Offset = "0x6ABCC90", VA = "0x186ABE090", Slot = "12")]
		protected override void EBFIFEDLDIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class PACLACLFIMN : HMNPGEFNICB<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private List<MGEGMLPKNPK<Material>> BKJFMIDIDBM;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE780", Offset = "0x6ABD380", VA = "0x186ABE780")]
		public PACLACLFIMN(Task<Material[]> NEEKHCPCAAC, List<MGEGMLPKNPK<Material>> BKJFMIDIDBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE730", Offset = "0x6ABD330", VA = "0x186ABE730", Slot = "11")]
		protected override Material[] EOPCAPHLOIN(Task<Material[]> BMOOBLAOMLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE5F0", Offset = "0x6ABD1F0", VA = "0x186ABE5F0", Slot = "12")]
		protected override void EBFIFEDLDIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private static readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9EC0", Offset = "0x6AB8AC0", VA = "0x186AB9EC0")]
	public static MGEGMLPKNPK<Material[]> MAKJJJOFCGP(AssetReference[] MLFNGOEFEIE)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[DisallowMultipleComponent]
	public class PlayerAvatarDisplayBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public enum IDOFKBBIPLO
		{
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x4000316")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public enum PJCNGFBNLLE
		{
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000319")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x400031A")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x400031B")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public enum MONPPOOEEPJ : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400031D")]
			All,
			[Cpp2IlInjected.Token(Token = "0x400031E")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public struct KNPEEANFEBD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			public readonly Material CLNADELPCLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			public readonly IDOFKBBIPLO NFECHNDPDMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000322")]
			public readonly PJCNGFBNLLE DMMHFNEEPJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public readonly BCGODMJDFFO FCGPGKINHAE;

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x6ABA8A0", Offset = "0x6AB94A0", VA = "0x186ABA8A0")]
			public KNPEEANFEBD(Material OFCNJEFMNEM, IDOFKBBIPLO FJLPKDJMFAO, PJCNGFBNLLE BNFBFOOOPHJ, BCGODMJDFFO NOIJPBIAGKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x6AD33F0", Offset = "0x6AD1FF0", VA = "0x186AD33F0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x6ABA480", Offset = "0x6AB9080", VA = "0x186ABA480")]
			public bool HELLGNHACPM(KNPEEANFEBD FDOEIPBMJJM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x6AD3270", Offset = "0x6AD1E70", VA = "0x186AD3270", Slot = "0")]
			public override bool Equals(object PLAMADMDGIO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x6AD3350", Offset = "0x6AD1F50", VA = "0x186AD3350", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		protected struct HFOBGOKDOJB : IComparable<HFOBGOKDOJB>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public int LOKHLLECNPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public PlayerAvatarDisplayBase GCHBDOEJPND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public IList<ECCEHBBGHLP> KODPAHOKOEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public AvatarItemBodyType ALJNCINOFJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			public bool OFOLLBCELJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			public int[] BIECHDJLAGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			public float FEGEFLLGLNN;

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x6AD2FD0", Offset = "0x6AD1BD0", VA = "0x186AD2FD0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x6AD2FB0", Offset = "0x6AD1BB0", VA = "0x186AD2FB0", Slot = "4")]
			public int CompareTo(HFOBGOKDOJB FDOEIPBMJJM)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		protected abstract class IABFAPJBOCJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000057")]
			public class MNJFHOBCOPN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400032E")]
				public readonly Mesh NHOPBGNMJJK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400032F")]
				public readonly Material[] PLBPEIEHHPA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000330")]
				public readonly Transform[] IDDIIDILEDG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000331")]
				public readonly Matrix4x4[] PFGBMHOCNGH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000332")]
				public readonly Transform LINEEPKEFMJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000333")]
				public readonly bool KHKMFHHHIML;

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
				protected MNJFHOBCOPN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x6AD3AF0", Offset = "0x6AD26F0", VA = "0x186AD3AF0")]
				public MNJFHOBCOPN(Mesh OOKDOLDBLMJ, Material[] ACAGKNPDHBA, bool POJHIPDHPNF, Transform[] IOMCJDOMECE, Transform NAPGPBGLNOG, Matrix4x4[] KAAIHNKJICK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BE")]
				[Cpp2IlInjected.Address(RVA = "0x6AD4090", Offset = "0x6AD2C90", VA = "0x186AD4090")]
				private MNJFHOBCOPN(SkinnedMeshRenderer CJKFIKFIAMM, Material[] OMIMDKJHAKM)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0x6AD3FA0", Offset = "0x6AD2BA0", VA = "0x186AD3FA0")]
				private MNJFHOBCOPN(MeshRenderer HFOIEIBKMDO, Transform NAPGPBGLNOG, Material[] OMIMDKJHAKM)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C0")]
				[Cpp2IlInjected.Address(RVA = "0x6AD37D0", Offset = "0x6AD23D0", VA = "0x186AD37D0")]
				public static MNJFHOBCOPN DMINAPPOGGC(Renderer HKFOEGKIJPH, Material[] OMIMDKJHAKM)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			public readonly BCGODMJDFFO FCGPGKINHAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			public readonly Transform INCJNHLMGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			public readonly bool PPLGMNOODBK;

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public virtual bool KKDHJKIPFEB
			{
				[Cpp2IlInjected.Token(Token = "0x60002B5")]
				[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public virtual bool EPPNGPBLJHD
			{
				[Cpp2IlInjected.Token(Token = "0x60002B6")]
				[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public virtual HDFJPOEIMPO.CLDPEDONPKD LLBPBLPPGNJ
			{
				[Cpp2IlInjected.Token(Token = "0x60002B7")]
				[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "6")]
				get
				{
					return default(HDFJPOEIMPO.CLDPEDONPKD);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public bool NBGBCCCPINH
			{
				[Cpp2IlInjected.Token(Token = "0x60002B8")]
				[Cpp2IlInjected.Address(RVA = "0x6AD3120", Offset = "0x6AD1D20", VA = "0x186AD3120")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x6AD3130", Offset = "0x6AD1D30", VA = "0x186AD3130")]
			protected IABFAPJBOCJ(BCGODMJDFFO NOIJPBIAGKF, Transform PPIEPPCPLHH, bool CBEMNBCLJHN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract DMMKPEDFDBF KABFMEPIEJC(List<ICGCFKNNIIE> PAIHLLHNDHC, List<ICGCFKNNIIE> EGNMAKCLBAJ);

			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract MNJFHOBCOPN MKFDDMCECAG(int LAIJAICKIEF, PlayerHandBones MFLBABLOALL);
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		protected class GFMMAOIBBIP : IABFAPJBOCJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			protected readonly BodyPartLODs FPDOINPPAIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			protected readonly Material[] CMNLIGMKNHC;

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x6AD2740", Offset = "0x6AD1340", VA = "0x186AD2740")]
			public GFMMAOIBBIP(BCGODMJDFFO NOIJPBIAGKF, BodyPartLODs GABBELEKGFH, Material CHHDDIBDPHM, [Optional] Transform PPIEPPCPLHH, bool CBEMNBCLJHN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x6AD2480", Offset = "0x6AD1080", VA = "0x186AD2480", Slot = "7")]
			public override DMMKPEDFDBF KABFMEPIEJC(List<ICGCFKNNIIE> PAIHLLHNDHC, List<ICGCFKNNIIE> EGNMAKCLBAJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x6AD2510", Offset = "0x6AD1110", VA = "0x186AD2510", Slot = "8")]
			public override MNJFHOBCOPN MKFDDMCECAG(int LAIJAICKIEF, PlayerHandBones MFLBABLOALL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x6AD26D0", Offset = "0x6AD12D0", VA = "0x186AD26D0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		protected class MEFJIHHFENE : IABFAPJBOCJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public override bool KKDHJKIPFEB
			{
				[Cpp2IlInjected.Token(Token = "0x60002C5")]
				[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public override bool EPPNGPBLJHD
			{
				[Cpp2IlInjected.Token(Token = "0x60002C6")]
				[Cpp2IlInjected.Address(RVA = "0x6AD36A0", Offset = "0x6AD22A0", VA = "0x186AD36A0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public LAELCEHABJN CPOJDNOPOEB
			{
				[Cpp2IlInjected.Token(Token = "0x60002C7")]
				[Cpp2IlInjected.Address(RVA = "0x88ABD0", Offset = "0x8897D0", VA = "0x18088ABD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60002C8")]
				[Cpp2IlInjected.Address(RVA = "0x88ABC0", Offset = "0x8897C0", VA = "0x18088ABC0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x6AD3760", Offset = "0x6AD2360", VA = "0x186AD3760")]
			public MEFJIHHFENE(BCGODMJDFFO NOIJPBIAGKF, Transform PPIEPPCPLHH, LAELCEHABJN MAMENCEBGLO, bool CBEMNBCLJHN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x6AD3610", Offset = "0x6AD2210", VA = "0x186AD3610", Slot = "7")]
			public override DMMKPEDFDBF KABFMEPIEJC(List<ICGCFKNNIIE> PAIHLLHNDHC, List<ICGCFKNNIIE> EGNMAKCLBAJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "8")]
			public override MNJFHOBCOPN MKFDDMCECAG(int LAIJAICKIEF, PlayerHandBones MFLBABLOALL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x6AD36F0", Offset = "0x6AD22F0", VA = "0x186AD36F0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public class CNNAHKGELBI
		{
			[Cpp2IlInjected.Token(Token = "0x200005B")]
			public enum CBNCAMMICHP
			{
				[Cpp2IlInjected.Token(Token = "0x4000347")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x4000348")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x4000349")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x400034A")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x400034B")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x400034C")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x400034D")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public static readonly int BFLECGHHFOI;

			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public static readonly int NHFJPLEBEGC;

			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public static readonly int OEDCHBFGKGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			protected readonly KOEIKGEMDHH HFFIHMCMHMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			protected readonly JIGCNLFGOML PCOBLCNFGHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			protected readonly Animator DOFMOKPAFJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			protected readonly Transform LOBDKDBAKGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			protected readonly Vector3 OCACLPGEBIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			protected readonly Transform PKPLPGOGJGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			protected readonly Vector3 LLGJEAMADOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			protected bool MKEIKOAOKDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			protected GBABJKDKLCB OOFIGMFFGKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			protected bool MPIKOHBHKDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			protected float AHFCECDCCAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			protected OPNFBDLFKNK<MBPKGLMAGIN> NDBHGBJJLJE;

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public GBABJKDKLCB NHHADCKDFHF
			{
				[Cpp2IlInjected.Token(Token = "0x60002CD")]
				[Cpp2IlInjected.Address(RVA = "0x88C530", Offset = "0x88B130", VA = "0x18088C530")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60002CE")]
				[Cpp2IlInjected.Address(RVA = "0x88C6F0", Offset = "0x88B2F0", VA = "0x18088C6F0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public bool NCABDKFHNIO
			{
				[Cpp2IlInjected.Token(Token = "0x60002CF")]
				[Cpp2IlInjected.Address(RVA = "0x10605F0", Offset = "0x105F1F0", VA = "0x1810605F0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60002D0")]
				[Cpp2IlInjected.Address(RVA = "0x6AD0870", Offset = "0x6ACF470", VA = "0x186AD0870")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public bool CKEKHCOFHHH
			{
				[Cpp2IlInjected.Token(Token = "0x60002D1")]
				[Cpp2IlInjected.Address(RVA = "0x88C4F0", Offset = "0x88B0F0", VA = "0x18088C4F0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60002D2")]
				[Cpp2IlInjected.Address(RVA = "0x6AD03F0", Offset = "0x6ACEFF0", VA = "0x186AD03F0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public float BHIAOAKIAKH
			{
				[Cpp2IlInjected.Token(Token = "0x60002D3")]
				[Cpp2IlInjected.Address(RVA = "0xA629C0", Offset = "0xA615C0", VA = "0x180A629C0")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60002D4")]
				[Cpp2IlInjected.Address(RVA = "0x6AD02B0", Offset = "0x6ACEEB0", VA = "0x186AD02B0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public MBPKGLMAGIN LPBOLBKEGFC
			{
				[Cpp2IlInjected.Token(Token = "0x60002D5")]
				[Cpp2IlInjected.Address(RVA = "0x6AD0510", Offset = "0x6ACF110", VA = "0x186AD0510")]
				get
				{
					return default(MBPKGLMAGIN);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x6AD0C70", Offset = "0x6ACF870", VA = "0x186AD0C70")]
			public bool PJCFDKPEGOA(MBPKGLMAGIN CEODAJPEPBP, object DGGGDIFONNG, CBNCAMMICHP LLJMNDBPFJI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x6AD0550", Offset = "0x6ACF150", VA = "0x186AD0550")]
			public bool IOHGBJFECME(object DGGGDIFONNG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x6AD0E20", Offset = "0x6ACFA20", VA = "0x186AD0E20")]
			protected CNNAHKGELBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x6AD0EB0", Offset = "0x6ACFAB0", VA = "0x186AD0EB0")]
			public CNNAHKGELBI(KOEIKGEMDHH HFFIHMCMHMM, GBABJKDKLCB GJMEOOOAFBA, Animator DOFMOKPAFJE, Transform LOBDKDBAKGL, Transform PKPLPGOGJGI, Vector3 OCACLPGEBIM, Vector3 LLGJEAMADOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x6AD0650", Offset = "0x6ACF250", VA = "0x186AD0650")]
			private void IPGDIMGNFDF(ushort GHGNPLBNABF, ushort NLKJFAMKONG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x6AD0940", Offset = "0x6ACF540", VA = "0x186AD0940")]
			protected void MONOPJKINKP(ushort GHGNPLBNABF, ushort NLKJFAMKONG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x6AD01A0", Offset = "0x6ACEDA0", VA = "0x186AD01A0")]
			protected void AFDDBHLIOPD(ushort GHGNPLBNABF, ushort NLKJFAMKONG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x6AD0B50", Offset = "0x6ACF750", VA = "0x186AD0B50")]
			protected void NOJPLIANHCN(ushort GHGNPLBNABF, ushort NLKJFAMKONG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x6AD0760", Offset = "0x6ACF360", VA = "0x186AD0760")]
			protected void KPACNENOLPG(ushort GHGNPLBNABF, ushort NLKJFAMKONG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x6AD0700", Offset = "0x6ACF300", VA = "0x186AD0700")]
			protected void KFBLLJGGANL(ushort GHGNPLBNABF, ushort NLKJFAMKONG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x6AD0260", Offset = "0x6ACEE60", VA = "0x186AD0260")]
			protected void BIOCNHEHLFH(ushort GHGNPLBNABF, ushort NLKJFAMKONG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x6AD04C0", Offset = "0x6ACF0C0", VA = "0x186AD04C0")]
			protected void FDLICKGPAJL(ushort GHGNPLBNABF, ushort NLKJFAMKONG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x6AD0A30", Offset = "0x6ACF630", VA = "0x186AD0A30")]
			protected void NEBELFOOBBP(ushort GHGNPLBNABF, ushort NLKJFAMKONG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public class BNNOFCODNLO : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public const int BFHFPMPKMGG = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			protected MaterialPropertyBlock JMBDIKBEEPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			public Color? BOKOBEGKHGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			public Color? APPDPNHCDBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			public Color? KCBABLELOFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			public Color PEOGGOJHGLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public Color NOBEEKNJHAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public Color INLNKLEOKNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public Texture2D NNGILDENGHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			public Texture2D OKMJBAKGABG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			protected Dictionary<KNPEEANFEBD, int> DNCFDDANHIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			protected IDOFKBBIPLO[] ELFHMPENPIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public Vector4[] EGCMJPELKJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public Vector4[] OKPHFIJJAAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public Vector4[] PIEBGMNFIFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public Vector4[] OPAONKHIKAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			public Vector4[] FAMAJLFAAKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			public Vector4[] EILNJJKBGBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			protected List<Texture2D> OKEBICBONIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			protected Vector4[] BFKLNHMICNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			protected List<Texture2D> LIHDPAJMEAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			protected float[] EBGCPLJGLPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			protected Vector4[] GPNPFGPAGNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			protected float[] PEJCJCPOHLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			public float[] PHODOGPHCDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			protected List<Texture2D> PBBDPLDAKCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			protected float[] KCEECDOMAOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			protected List<Texture2D> FLJHKLNAJFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			protected Vector4[] PHNMFNNDJFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			protected float[] EIFHLMLACBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			protected Vector4[] MPCBGJDHEEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public float[] CCONCEGNEKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			public Texture2DArray EBNMPNHHIAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			public Texture2DArray MONLBIDNPPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			public Texture2DArray IBKNKGBIEKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			public Texture2DArray ANHHMENBIBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			protected bool MAMMABALPAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			protected int CCDAFDBCNGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			protected Vector2? DFBDDLPJBFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			protected TextureFormat MMGBFDEPKHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			protected Vector2? OBKPIEABFGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			protected TextureFormat BPJFNJDAIKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			protected Vector2? HKCDFGFCDAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			protected TextureFormat OEPELGPOLGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			protected Vector2? OIMPNIENGOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			protected TextureFormat CNIFFKAOKAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			protected bool IMLFLKFFANH;

			[Cpp2IlInjected.Token(Token = "0x400037D")]
			protected static int KFNECGMEGHP;

			[Cpp2IlInjected.Token(Token = "0x400037E")]
			protected static int BPJABAHIDEA;

			[Cpp2IlInjected.Token(Token = "0x400037F")]
			protected static int HFAFNHHJDMN;

			[Cpp2IlInjected.Token(Token = "0x4000380")]
			protected static int DJNANMEBPPO;

			[Cpp2IlInjected.Token(Token = "0x4000381")]
			protected static int JGOCBOBGPJC;

			[Cpp2IlInjected.Token(Token = "0x4000382")]
			protected static int HEJAGNIIACB;

			[Cpp2IlInjected.Token(Token = "0x4000383")]
			protected static int NNLKCCNLDAG;

			[Cpp2IlInjected.Token(Token = "0x4000384")]
			protected static int ANJMHMFCLAL;

			[Cpp2IlInjected.Token(Token = "0x4000385")]
			protected static int ILFPLOEKBDD;

			[Cpp2IlInjected.Token(Token = "0x4000386")]
			protected static int KALKKDJOHKB;

			[Cpp2IlInjected.Token(Token = "0x4000387")]
			protected static int EJFNIECCJCM;

			[Cpp2IlInjected.Token(Token = "0x4000388")]
			protected static int LHELDHEIGNN;

			[Cpp2IlInjected.Token(Token = "0x4000389")]
			protected static int AEOFDKOAKDF;

			[Cpp2IlInjected.Token(Token = "0x400038A")]
			protected static int FLHFEKCLFHO;

			[Cpp2IlInjected.Token(Token = "0x400038B")]
			protected static int MEHANBPFGLH;

			[Cpp2IlInjected.Token(Token = "0x400038C")]
			protected static int DNHLGHDDFCD;

			[Cpp2IlInjected.Token(Token = "0x400038D")]
			protected static int BFDFLFBIMGB;

			[Cpp2IlInjected.Token(Token = "0x400038E")]
			protected static int NBGFBGCDECE;

			[Cpp2IlInjected.Token(Token = "0x400038F")]
			protected static int GNGDGIFPCGG;

			[Cpp2IlInjected.Token(Token = "0x4000390")]
			protected static int FCBDILNIHLP;

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x6ACFC50", Offset = "0x6ACE850", VA = "0x186ACFC50")]
			protected BNNOFCODNLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x6AD0110", Offset = "0x6ACED10", VA = "0x186AD0110")]
			public BNNOFCODNLO(Color FGODHLCKOKF, Color KAOHPAKJAIM, Color FFIDNAJJBKL, Color? AGGNFEALDKK, Color? MIFAKEDHACL, Color? MJKPLJLKONC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x6ACF1E0", Offset = "0x6ACDDE0", VA = "0x186ACF1E0")]
			public int NJEHBEEFOJC(Material HDPMKAKFGBH, IDOFKBBIPLO FJLPKDJMFAO, PJCNGFBNLLE BNFBFOOOPHJ, BCGODMJDFFO NOIJPBIAGKF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x6ACF2D0", Offset = "0x6ACDED0", VA = "0x186ACF2D0")]
			public int NJEHBEEFOJC(KNPEEANFEBD NONKDEOLPHL)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x6ACD770", Offset = "0x6ACC370", VA = "0x186ACD770")]
			public int AEJBGPEFEFC(Material HDPMKAKFGBH, Color EDPBFFGGELC, Color IMLKOJLHIJB, Color BHJLBOAHMJD, Color FBOBNKOENOM, Color BAACFFBEFPM, Texture2D LJLMEFBIOGI, Vector4 FOMPLBEFJKI, Texture2D LDGBIIJAKGD, Vector4 HCKEENIHOJI, float BKHFHHAOKLB, float JLGBKPNHKOD, Texture2D OKMAGMPMNHH, Vector4 GBCLONFMPKI, float FIOOPFNHBOC, Texture2D IJPGIJBELKH, float ODMKIFFLEKO, Color AOAOLJOOIBF, Vector4 EOCBIKDAPAE, IDOFKBBIPLO FJLPKDJMFAO, PJCNGFBNLLE BNFBFOOOPHJ, BCGODMJDFFO NOIJPBIAGKF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x6ACE530", Offset = "0x6ACD130", VA = "0x186ACE530")]
			protected void IBGIKDMLBKB([Out] Texture2DArray BCAKBOJFCIK, [Out] Texture2DArray LBJBOOPJJAI, [Out] Texture2DArray GOMLCHPCGGK, [Out] Texture2DArray FKEAADOFCEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x6ACF550", Offset = "0x6ACE150", VA = "0x186ACF550")]
			public void OKFKKBCIMPF(PlayerAvatarDisplayBase JDKMEBPPDID, Renderer HKFOEGKIJPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x6ACE6F0", Offset = "0x6ACD2F0", VA = "0x186ACE6F0")]
			protected void JHHIOHPJCLI(PlayerAvatarDisplayBase JDKMEBPPDID, Renderer HKFOEGKIJPH, int LLCDNIGMMAF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x6ACF360", Offset = "0x6ACDF60", VA = "0x186ACF360")]
			private Color NNOFFLLMODC(Color FFJOBGBLBCO, IDOFKBBIPLO JAFKJJBJJFP)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x6ACF7B0", Offset = "0x6ACE3B0", VA = "0x186ACF7B0")]
			private Color PKCHOMHFLAI(Color LAGLBBGBFLB, IDOFKBBIPLO JAFKJJBJJFP)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x6ACE4A0", Offset = "0x6ACD0A0", VA = "0x186ACE4A0")]
			protected void HECODHECNAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x6ACE460", Offset = "0x6ACD060", VA = "0x186ACE460", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x6ADADC0", Offset = "0x6AD99C0", VA = "0x186ADADC0")]
			public void BBCMAKLBHPE(BCGODMJDFFO NOIJPBIAGKF, [Out] Transform AHFIDHNOIFE, [Out] Transform[] IOMCJDOMECE)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		[CompilerGenerated]
		private sealed class PGJDJILFGKE : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002FF")]
				[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x8E1390", Offset = "0x8DFF90", VA = "0x1808E1390")]
			[DebuggerHidden]
			public PGJDJILFGKE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x6AD4E60", Offset = "0x6AD3A60", VA = "0x186AD4E60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x6AD50E0", Offset = "0x6AD3CE0", VA = "0x186AD50E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x6AD5030", Offset = "0x6AD3C30", VA = "0x186AD5030", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x6AD5030", Offset = "0x6AD3C30", VA = "0x186AD5030", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class PIPNCDAILOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public PIPNCDAILOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x6AD5360", Offset = "0x6AD3F60", VA = "0x186AD5360")]
			internal bool PLJDNICJCNC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000062")]
		[CompilerGenerated]
		private sealed class NPLDJHPAHBB : IEnumerator<HGHICIBNEGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			private HGHICIBNEGP <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			private HGHICIBNEGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x891CE0", Offset = "0x8908E0", VA = "0x180891CE0")]
			[DebuggerHidden]
			public NPLDJHPAHBB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x6AD4150", Offset = "0x6AD2D50", VA = "0x186AD4150", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x6AD43E0", Offset = "0x6AD2FE0", VA = "0x186AD43E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		[CompilerGenerated]
		private struct HEOEBIFHBBP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			public LOGMJPPPGNI avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x6AD28C0", Offset = "0x6AD14C0", VA = "0x186AD28C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x6AD2F50", Offset = "0x6AD1B50", VA = "0x186AD2F50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class JCPIEAJHBIF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public JCPIEAJHBIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x6AD3190", Offset = "0x6AD1D90", VA = "0x186AD3190")]
			internal bool DDFEPDJGNEH(ECCEHBBGHLP selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class DOCHFDGCOGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			public Func<HHDNLBNGHMC<Dictionary<string, MGEGMLPKNPK<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public DOCHFDGCOGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x6AD16D0", Offset = "0x6AD02D0", VA = "0x186AD16D0")]
			internal (LKOMDOLALMB, HHDNLBNGHMC<Dictionary<string, MGEGMLPKNPK<Texture2D>>>) ECLEOFDOCIE(Dictionary<string, MCOGOHBOKKE> avatarItems)
			{
				return default((LKOMDOLALMB, HHDNLBNGHMC<Dictionary<string, MGEGMLPKNPK<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x6AD18D0", Offset = "0x6AD04D0", VA = "0x186AD18D0")]
			internal HHDNLBNGHMC<Dictionary<string, MGEGMLPKNPK<Texture2D>>> ENMOHDLKFKP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x6AD1940", Offset = "0x6AD0540", VA = "0x186AD1940")]
			internal void KIMPDBNALAO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class JLKGKILDKGK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public JLKGKILDKGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x6AD31C0", Offset = "0x6AD1DC0", VA = "0x186AD31C0")]
			internal bool NNPKBMPBODC(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private struct PIIEHFGAMLC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x6AD5130", Offset = "0x6AD3D30", VA = "0x186AD5130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x6AD5300", Offset = "0x6AD3F00", VA = "0x186AD5300", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000294")]
		protected static readonly int PHFJOGFGGEJ;

		[Cpp2IlInjected.Token(Token = "0x4000295")]
		protected static readonly int JHLKDPOEJGB;

		[Cpp2IlInjected.Token(Token = "0x4000296")]
		protected static readonly int PKFFDKAFMMN;

		[Cpp2IlInjected.Token(Token = "0x4000297")]
		protected static readonly int IKFDJDCFLEO;

		[Cpp2IlInjected.Token(Token = "0x4000298")]
		protected static readonly int MMOKLJOOLBA;

		[Cpp2IlInjected.Token(Token = "0x4000299")]
		protected static readonly int LDALEDFMIAM;

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		protected static readonly int[] OAJJACEAEOA;

		[Cpp2IlInjected.Token(Token = "0x400029B")]
		protected static readonly int[] AEOKBDAMBAK;

		[Cpp2IlInjected.Token(Token = "0x400029C")]
		protected static readonly int[] IBPJAPGPDIA;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		protected static readonly int[] BJAHFFBCJOC;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		protected static readonly int[] EPMCIOOEJCC;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		protected static readonly int[] LMGHECAKMCB;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		protected static List<PlayerAvatarDisplayBase> OFDNLMBDBBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		protected DMLKGCCJOHI OCKNGANNPIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		protected bool KFNKLLEKGFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		protected bool BBFKFOEOIGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		protected static readonly int[] AOEFFLCBLGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		protected Dictionary<KNPEEANFEBD, Material> JGINBFCMBDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		protected Dictionary<KNPEEANFEBD, Material> POKECECBIDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		[SerializeField]
		public Transform remoteMeshBase;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		protected Material FMIDANDALII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		protected GGDKLOOMBAO BOMHHNPAFEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private GBABJKDKLCB MJEJDGNNKKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private GBABJKDKLCB CPEJHKENLJB;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		protected Material IKNJKHFDIEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		protected FitMeshHemisphere OMFJEHEFDGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		protected bool FMNCPLLAKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		protected KLLNLHCALDO BIHBEMKOFNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		protected bool CLCAMDBCGIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		protected AnchorParamsRestrictions MIJBBDFKOGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		protected bool EEJIBGALCBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		protected Transform NBOHLJJFKPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		protected bool IEAMHEGGKIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x191")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		protected bool IBDKBJCFMHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		protected Vector3 BIMJGNKHKOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		protected Quaternion PGONACLEIEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		protected Vector2 ABBABCAPDFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		protected FitMeshHemisphere HGBFEKMGMKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		[SerializeField]
		[GBPOFPPCAAP(KOFDDAAAPEO.SelfAndChildren, false, false, false)]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		protected Collider[] DDDMCJFNPKF;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		protected Collider[] JOPDENEIKDB;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		protected CNNAHKGELBI[] LLABFKJHNOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public Dictionary<Renderer, BNNOFCODNLO> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		protected Dictionary<Renderer, BNNOFCODNLO> FHPPDHLNACK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		protected NCFKGGBBAGH EKKAAILHDBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		protected LKOMDOLALMB HCJOPHDMGIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public PFKPGFLKLMF DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		protected int BMADLNEAEFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		protected OPNFBDLFKNK<JIGCNLFGOML> NDBHGBJJLJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		protected bool GJCKDJOMAIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		protected Dictionary<ECCEHBBGHLP, List<KNPEEANFEBD>> KAAJLAKECKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		protected Dictionary<ECCEHBBGHLP, List<KNPEEANFEBD>> IDFCEAKKEAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		protected readonly Dictionary<string, MGEGMLPKNPK<Texture2D>> JGHMMELOEJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		protected readonly Dictionary<string, MGEGMLPKNPK<Texture2D>> DBDIPFLNKLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		protected bool POKIONPCAEG;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		protected static int DDOPPMDAPNI;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		protected static List<HFOBGOKDOJB> FGNDMLOCBDD;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		protected static EIIBBDFHPAD IMKNDJEDEJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		protected Color? HOMBGCOFGFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2BC")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		protected bool GJPAOKKALBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		protected Color OHIGNIJGCEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		protected Color? FOBMHAAIHKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected Color? ECPDEKLFHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected AvatarHairPattern BADNGDGJKFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		protected LAELCEHABJN IBJBAGLJLKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		protected Color IIJPLCHNIMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		protected Color CACJDGNGFON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		protected AvatarHairPattern GDDKDEAACFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		protected LAELCEHABJN INGAMIHHJFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		protected LAELCEHABJN HDNDLONEPBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		protected Color LMMKKIFMCDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private AdditionalFeetData GCNNCCMPLGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		protected ECCEHBBGHLP? CEIAHFNCHCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		protected Texture FEKDLMHDOFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		protected Color CFPJJADHBKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		protected readonly IList<ECCEHBBGHLP> EJLCEPILIFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		protected readonly IList<ECCEHBBGHLP> JADHEGHNDCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private AvatarItemBodyType NILLLAKJJMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B1")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		protected MONPPOOEEPJ MKDEAFCFINA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		protected int[] MHLHNIDHOND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		protected bool NKCEEDIIOOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		protected int[] GHGPDDIHOCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		protected bool MCJLEPCAEKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		protected EHJFAJIMFLL NMMHIEKOKDN;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string GGGDOJAOEIC
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x888260", Offset = "0x886E60", VA = "0x180888260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public bool BCBJDFKMLMA
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x908600", Offset = "0x907200", VA = "0x180908600")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x908610", Offset = "0x907210", VA = "0x180908610")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool DJHNJAJGBHM
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool HCFEEPBMEGO
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x6ACBE10", Offset = "0x6ACAA10", VA = "0x186ACBE10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual bool CEPEEFIAHBB
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual bool NMGILEFBANN
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual bool NEFKJKIHEKP
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public GGDKLOOMBAO MNCNPCHJEAM
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x93F360", Offset = "0x93DF60", VA = "0x18093F360")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x6ACC3F0", Offset = "0x6ACAFF0", VA = "0x186ACC3F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public GBABJKDKLCB GFHFMLENLJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0xA62A70", Offset = "0xA61670", VA = "0x180A62A70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x6ACC740", Offset = "0x6ACB340", VA = "0x186ACC740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public GBABJKDKLCB PAGLHKAONJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0xCCD420", Offset = "0xCCC020", VA = "0x180CCD420")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x6ACC9F0", Offset = "0x6ACB5F0", VA = "0x186ACC9F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected Material AHGFBLICMOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x6AC53C0", Offset = "0x6AC3FC0", VA = "0x186AC53C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected Material HDKDLHKDKAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x6AC04F0", Offset = "0x6ABF0F0", VA = "0x186AC04F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool PMAIHMHAHMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x14FF560", Offset = "0x14FE160", VA = "0x1814FF560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public PlayerFacialAnimatorBase MKCOHKELCIH
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0xCCEA70", Offset = "0xCCD670", VA = "0x180CCEA70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public CNNAHKGELBI[] KANHECOMJJC
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x6ACB9E0", Offset = "0x6ACA5E0", VA = "0x186ACB9E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public CNNAHKGELBI KEGKCDMCGIM
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x6ACC000", Offset = "0x6ACAC00", VA = "0x186ACC000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public CNNAHKGELBI IJBFHLLJHNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x6ACC030", Offset = "0x6ACAC30", VA = "0x186ACC030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public Mesh GCPNHPCBMMM
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xD40A30", Offset = "0xD3F630", VA = "0x180D40A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected NCFKGGBBAGH IDFHFFCAFKD
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x6ABF750", Offset = "0x6ABE350", VA = "0x186ABF750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected LKOMDOLALMB KOGPMKKLGJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x1634AD0", Offset = "0x16336D0", VA = "0x181634AD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x6AC24C0", Offset = "0x6AC10C0", VA = "0x186AC24C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected bool HJIHNMKEGIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public bool DHPFMCGNBFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x6ACBFF0", Offset = "0x6ACABF0", VA = "0x186ACBFF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public int KBPHOELFJBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x18BE550", Offset = "0x18BD150", VA = "0x1818BE550")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x6ACC950", Offset = "0x6ACB550", VA = "0x186ACC950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		protected virtual bool NMLFMGHPELP
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		protected virtual int[] LLMBEJDKPAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x6AC0B20", Offset = "0x6ABF720", VA = "0x186AC0B20", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		protected bool FNOODACNMHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x6AC7B20", Offset = "0x6AC6720", VA = "0x186AC7B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		protected static bool JPIJHKBLFKB
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool IMDOODIKBLN
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0xB53730", Offset = "0xB52330", VA = "0x180B53730")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x6ACCC00", Offset = "0x6ACB800", VA = "0x186ACCC00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public IEnumerable<SkinnedMeshRenderer> EHBBCLDCKJC
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x6ACB8C0", Offset = "0x6ACA4C0", VA = "0x186ACB8C0")]
			[IteratorStateMachine(typeof(PGJDJILFGKE))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool LNEBBFIJLFI
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xB544B0", Offset = "0xB530B0", VA = "0x180B544B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0xB54F20", Offset = "0xB53B20", VA = "0x180B54F20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public CAJNNHABANH ALOKPFIMJHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x6ACB940", Offset = "0x6ACA540", VA = "0x186ACB940")]
			get
			{
				return default(CAJNNHABANH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public static bool NHCHBLAMLBA
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x6ACBD80", Offset = "0x6ACA980", VA = "0x186ACBD80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected static EIIBBDFHPAD DLBNKPNECFD
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x6AC6530", Offset = "0x6AC5130", VA = "0x186AC6530")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x6AC5760", Offset = "0x6AC4360", VA = "0x186AC5760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected Color? APPDPNHCDBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x6AC3430", Offset = "0x6AC2030", VA = "0x186AC3430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		protected Color? KCBABLELOFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x6AC6CC0", Offset = "0x6AC58C0", VA = "0x186AC6CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		protected Texture2D LOCBALMPNOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x6AC4EA0", Offset = "0x6AC3AA0", VA = "0x186AC4EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		protected Color PEOGGOJHGLL
		{
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x6AC4E50", Offset = "0x6AC3A50", VA = "0x186AC4E50")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected Color NOBEEKNJHAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x6AC16C0", Offset = "0x6AC02C0", VA = "0x186AC16C0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public LAELCEHABJN NJHMNMAPKBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x6ACB9A0", Offset = "0x6ACA5A0", VA = "0x186ACB9A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected Texture2D KBKKJKJBPMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x6AC20C0", Offset = "0x6AC0CC0", VA = "0x186AC20C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public float DOOBKMPGLHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x6ACB9C0", Offset = "0x6ACA5C0", VA = "0x186ACB9C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public float MFMOHDAMKLF
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x6ACBDF0", Offset = "0x6ACA9F0", VA = "0x186ACBDF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool AEFGNMKDDPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0xCCD190", Offset = "0xCCBD90", VA = "0x180CCD190")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x6ACC1C0", Offset = "0x6ACADC0", VA = "0x186ACC1C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action PEIBMJPKCKI
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x6ACB760", Offset = "0x6ACA360", VA = "0x186ACB760")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x6ACC060", Offset = "0x6ACAC60", VA = "0x186ACC060")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<KOEIKGEMDHH, MBPKGLMAGIN> HMBMLINMLEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x6ACB800", Offset = "0x6ACA400", VA = "0x186ACB800")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x6ACC100", Offset = "0x6ACAD00", VA = "0x186ACC100")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6AC88A0", Offset = "0x6AC74A0", VA = "0x186AC88A0")]
		public bool SetDeformation(bool KFNKLLEKGFC, bool BBFKFOEOIGL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2F70", Offset = "0x6AC1B70", VA = "0x186AC2F70")]
		protected static Material HOPJMMENHCP(Dictionary<KNPEEANFEBD, Material> FAHIJCPHIDN, Material OMAJOLGPDDL, IDOFKBBIPLO FJLPKDJMFAO, PJCNGFBNLLE BNFBFOOOPHJ, BCGODMJDFFO NOIJPBIAGKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x6AC35B0", Offset = "0x6AC21B0", VA = "0x186AC35B0")]
		protected void JGEFLMLAEJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6AC25F0", Offset = "0x6AC11F0", VA = "0x186AC25F0")]
		protected bool FNHHNDHAILB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6AC4F90", Offset = "0x6AC3B90", VA = "0x186AC4F90")]
		protected void KJPGOMDLFLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6E30", Offset = "0x6AC5A30", VA = "0x186AC6E30", Slot = "10")]
		protected virtual void OCLCFBDOKLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6430", Offset = "0x6AC5030", VA = "0x186AC6430")]
		public int MeshesAtLODCount(int JLNABNBIGAN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6AC0D10", Offset = "0x6ABF910", VA = "0x186AC0D10")]
		protected static void COPGLEAEGOH(Dictionary<ECCEHBBGHLP, List<KNPEEANFEBD>> CANDNHJPNMI, IABFAPJBOCJ NEKCKMHGKJL, Material OMAJOLGPDDL, IDOFKBBIPLO JAFKJJBJJFP, PJCNGFBNLLE DEGBFEHLPGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6AC0030", Offset = "0x6ABEC30", VA = "0x186AC0030")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6960", Offset = "0x6AC5560", VA = "0x186AC6960")]
		protected void NIELMADBFPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6AC74E0", Offset = "0x6AC60E0", VA = "0x186AC74E0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "11")]
		protected virtual void CIBNDNPBCLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7030", Offset = "0x6AC5C30", VA = "0x186AC7030")]
		protected static void OHMEFIAPEKB(List<Material> NOEPMNPKOIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6AC0670", Offset = "0x6ABF270", VA = "0x186AC0670")]
		protected static void CGDCPFMABFN(Dictionary<KNPEEANFEBD, Material> FAHIJCPHIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x6AC0BB0", Offset = "0x6ABF7B0", VA = "0x186AC0BB0")]
		protected static void CNLCMHOMPHN(Dictionary<Renderer, BNNOFCODNLO> PBMEEEFHIAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6580", Offset = "0x6AC5180", VA = "0x186AC6580")]
		protected void NHFBICIDGLN(SkinnedMeshRenderer[] CJIIIMOAALO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6AC02C0", Offset = "0x6ABEEC0", VA = "0x186AC02C0")]
		protected void BCMNDPMFCAO(SkinnedMeshRenderer CJKFIKFIAMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6AC0360", Offset = "0x6ABEF60", VA = "0x186AC0360")]
		protected void BCMNDPMFCAO(MeshRenderer HFOIEIBKMDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3790", Offset = "0x6AC2390", VA = "0x186AC3790")]
		protected void JHNKFELOOKI(List<ICGCFKNNIIE> JMOMMGOADDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x6AC0140", Offset = "0x6ABED40", VA = "0x186AC0140")]
		protected void BBNFCFMCEMM(Dictionary<string, MGEGMLPKNPK<Texture2D>> CANDNHJPNMI, bool KHLDBOCKLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2B00", Offset = "0x6AC1700", VA = "0x186AC2B00")]
		protected void HGGCOHFNEID(Dictionary<ECCEHBBGHLP, List<KNPEEANFEBD>> CANDNHJPNMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2A00", Offset = "0x6AC1600", VA = "0x186AC2A00")]
		public float GetHandOpenClosedAxis(KOEIKGEMDHH HFFIHMCMHMM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9160", Offset = "0x6AC7D60", VA = "0x186AC9160")]
		public void SetHandOpenClosedAxis(KOEIKGEMDHH HFFIHMCMHMM, float DPAGEMDIAJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2A40", Offset = "0x6AC1640", VA = "0x186AC2A40")]
		public MBPKGLMAGIN GetHandVisualState(KOEIKGEMDHH HFFIHMCMHMM)
		{
			return default(MBPKGLMAGIN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x6ABF770", Offset = "0x6ABE370", VA = "0x186ABF770")]
		public bool AddHandVisualStateToken(KOEIKGEMDHH HFFIHMCMHMM, MBPKGLMAGIN JKGJHKBCHHI, object DGGGDIFONNG, CNNAHKGELBI.CBNCAMMICHP LLJMNDBPFJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6ACA860", Offset = "0x6AC9460", VA = "0x186ACA860")]
		public void SetWatchHand(KOEIKGEMDHH HFFIHMCMHMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7F80", Offset = "0x6AC6B80", VA = "0x186AC7F80")]
		public bool RemoveHandVisualStateToken(KOEIKGEMDHH HFFIHMCMHMM, object DGGGDIFONNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2AC0", Offset = "0x6AC16C0", VA = "0x186AC2AC0")]
		public bool GetThumbsUpActive(KOEIKGEMDHH HFFIHMCMHMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6ACA310", Offset = "0x6AC8F10", VA = "0x186ACA310")]
		public void SetThumbsUpActive(KOEIKGEMDHH HFFIHMCMHMM, bool DNHGNIGNGMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2A80", Offset = "0x6AC1680", VA = "0x186AC2A80")]
		public bool GetHandshakeActive(KOEIKGEMDHH HFFIHMCMHMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6AC91B0", Offset = "0x6AC7DB0", VA = "0x186AC91B0")]
		public void SetHandshakeActive(KOEIKGEMDHH HFFIHMCMHMM, bool IIDNHLGIEMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2810", Offset = "0x6AC1410", VA = "0x186AC2810")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x6AC15E0", Offset = "0x6AC01E0", VA = "0x186AC15E0")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x6AC72E0", Offset = "0x6AC5EE0", VA = "0x186AC72E0")]
		protected static void OOBEMEGCCNP(PlayerAvatarDisplayBase FNHKGLMFBJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7CC0", Offset = "0x6AC68C0", VA = "0x186AC7CC0")]
		public void Rebuild()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7290", Offset = "0x6AC5E90", VA = "0x186AC7290")]
		protected void OLOGKPIOOHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7170", Offset = "0x6AC5D70", VA = "0x186AC7170", Slot = "12")]
		protected virtual DMMKPEDFDBF OLOGKPIOOHC(IList<ECCEHBBGHLP> BIIHLMGBMIO, AvatarItemBodyType DMHKGOPCHBP, bool LOKEFHBNNOC, int[] CKPJNCPMEHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x6AC1710", Offset = "0x6AC0310", VA = "0x186AC1710")]
		protected static DMMKPEDFDBF DGLHMENAFKH(HFOBGOKDOJB HAJBPLJHDPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x6AC5020", Offset = "0x6AC3C20", VA = "0x186AC5020")]
		[IteratorStateMachine(typeof(NPLDJHPAHBB))]
		protected static IEnumerator<HGHICIBNEGP> KKFIIPHHANL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x6AC36D0", Offset = "0x6AC22D0", VA = "0x186AC36D0")]
		protected static HFOBGOKDOJB JGPJNNJODAL(List<HFOBGOKDOJB> OIJEIBNHOCD)
		{
			return default(HFOBGOKDOJB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x6AC89B0", Offset = "0x6AC75B0", VA = "0x186AC89B0")]
		[AsyncStateMachine(typeof(HEOEBIFHBBP))]
		public Task SetFaceCustomizationSettings(LOGMJPPPGNI CKCGPKIPOPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x6AC34D0", Offset = "0x6AC20D0", VA = "0x186AC34D0")]
		public void InitializeFaceFeatures(AvatarConfiguration GFGAGDKNLPB, CAJNNHABANH HFBIBPKGGBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x6ACA060", Offset = "0x6AC8C60", VA = "0x186ACA060")]
		public void SetTeamColors(Color? MJKPLJLKONC, bool IPKKNOGPILI, Color BLDBMHJAEDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xC36420", Offset = "0xC35020", VA = "0x180C36420")]
		private static void JNFPFPOFFNB(Material OFCNJEFMNEM, Color CABLCDOIFFL, params int[] NOINEBKNMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xC38200", Offset = "0xC36E00", VA = "0x180C38200")]
		private static void OINJCFMGFNL(Material OFCNJEFMNEM, Texture CABLCDOIFFL, params int[] NOINEBKNMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x6AC5080", Offset = "0x6AC3C80", VA = "0x186AC5080")]
		protected void KNNEDEIGMLJ(Material LFCAGJKNFNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7BA0", Offset = "0x6AC67A0", VA = "0x186AC7BA0")]
		protected void PLGIGAOONOB(Material LFCAGJKNFNH, Color AMNIABHLDPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6210", Offset = "0x6AC4E10", VA = "0x186AC6210")]
		protected void MODCLCPMCJP(Material LFCAGJKNFNH, Color AMNIABHLDPF, Color LLCKGLMGOBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7910", Offset = "0x6AC6510", VA = "0x186AC7910")]
		protected void PEMAADLNJAE(Material LFCAGJKNFNH, Texture2D NKCDINKPPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6E90", Offset = "0x6AC5A90", VA = "0x186AC6E90")]
		protected void ODDNICHPKPO(Material LFCAGJKNFNH, Texture NNPBLKDPAMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x6AC5E10", Offset = "0x6AC4A10", VA = "0x186AC5E10")]
		protected void MDNNDDOMAHG(Action<BNNOFCODNLO> BLEOBPKIPOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x6AC66A0", Offset = "0x6AC52A0", VA = "0x186AC66A0")]
		protected void NHODALIFFFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7750", Offset = "0x6AC6350", VA = "0x186AC7750")]
		protected void PDOILCPNIJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x6AC30D0", Offset = "0x6AC1CD0", VA = "0x186AC30D0")]
		protected void IFACEMKNMIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x6ABFAC0", Offset = "0x6ABE6C0", VA = "0x186ABFAC0")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x6AC8340", Offset = "0x6AC6F40", VA = "0x186AC8340")]
		public void SetBeardPrimaryColor([Optional] Color? KLGJNBHOLJF, bool HEEHCNHBAIL = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6AC8550", Offset = "0x6AC7150", VA = "0x186AC8550")]
		public void SetBeardSecondaryColor([Optional] Color? KLGJNBHOLJF, bool HEEHCNHBAIL = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x6AC8200", Offset = "0x6AC6E00", VA = "0x186AC8200")]
		public void SetBeardPattern([Optional] AvatarHairPattern MNKEOGPCIBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6AC1EB0", Offset = "0x6AC0AB0", VA = "0x186AC1EB0")]
		private void EIECILOAOGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x6AC56B0", Offset = "0x6AC42B0", VA = "0x186AC56B0")]
		private bool LFEGAGKEIBH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6AC8D20", Offset = "0x6AC7920", VA = "0x186AC8D20")]
		public void SetHairPrimaryColor([Optional] Color? JGAOKLOGPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x6AC8F40", Offset = "0x6AC7B40", VA = "0x186AC8F40")]
		public void SetHairSecondaryColor([Optional] Color? JGAOKLOGPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6AC8BF0", Offset = "0x6AC77F0", VA = "0x186AC8BF0")]
		public void SetHairPattern([Optional] AvatarHairPattern MNKEOGPCIBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7E20", Offset = "0x6AC6A20", VA = "0x186AC7E20")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x6AC5300", Offset = "0x6AC3F00", VA = "0x186AC5300")]
		private bool KPBBJKFJKJE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9EA0", Offset = "0x6AC8AA0", VA = "0x186AC9EA0")]
		public void SetSkinColor(Color FGODHLCKOKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6ACA360", Offset = "0x6AC8F60", VA = "0x186ACA360")]
		public void SetUgcItemVisualOverrides(ECCEHBBGHLP JCHMKKLIGLN, CAJNNHABANH HFBIBPKGGBP, Texture ABLFIOHIIDD, Color MMCJEFIOPON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6AC1670", Offset = "0x6AC0270", VA = "0x186AC1670")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6AC8AB0", Offset = "0x6AC76B0", VA = "0x186AC8AB0")]
		public bool SetFaceShape(AvatarFaceShape AOBAPGLIILH, bool PGAIPAODKNE = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6AC8760", Offset = "0x6AC7360", VA = "0x186AC8760")]
		public bool SetBodyShape(AvatarBodyShape GADFFFNBFBM, bool PGAIPAODKNE = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6ACA9B0", Offset = "0x6AC95B0", VA = "0x186ACA9B0")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9DF0", Offset = "0x6AC89F0", VA = "0x186AC9DF0")]
		public bool SetHideEars(bool DDHCICCHDEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9DE0", Offset = "0x6AC89E0", VA = "0x186AC9DE0")]
		public bool SetHelmetHair(DMLKGCCJOHI JMMMBHDFEKO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9850", Offset = "0x6AC8450", VA = "0x186AC9850")]
		public void SetHatAnchorParameters(KLLNLHCALDO ICEFKBNIDMA, bool KHJAGIHGHME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6ACA920", Offset = "0x6AC9520", VA = "0x186ACA920")]
		public void SetupDisplayLODs(MONPPOOEEPJ COBCMDNCOPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6AC1D00", Offset = "0x6AC0900", VA = "0x186AC1D00")]
		protected int[] EGADFKOBCOF(MONPPOOEEPJ COBCMDNCOPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9E10", Offset = "0x6AC8A10", VA = "0x186AC9E10")]
		public void SetOutfitSelections(IList<ECCEHBBGHLP> BIIHLMGBMIO, AvatarItemBodyType DMHKGOPCHBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9E40", Offset = "0x6AC8A40", VA = "0x186AC9E40")]
		public void SetOutfitSelections(IList<ECCEHBBGHLP> BIIHLMGBMIO, AvatarItemBodyType DMHKGOPCHBP, bool LOKEFHBNNOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9E70", Offset = "0x6AC8A70", VA = "0x186AC9E70")]
		public DMMKPEDFDBF SetOutfitSelections(IList<ECCEHBBGHLP> BIIHLMGBMIO, AvatarItemBodyType DMHKGOPCHBP, MONPPOOEEPJ COBCMDNCOPL, bool LOKEFHBNNOC, bool PGAIPAODKNE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2CF0", Offset = "0x6AC18F0", VA = "0x186AC2CF0")]
		private DMMKPEDFDBF HNJOGOEOIFM(IList<ECCEHBBGHLP> BIIHLMGBMIO, AvatarItemBodyType DMHKGOPCHBP, bool LOKEFHBNNOC, MONPPOOEEPJ COBCMDNCOPL, bool PGAIPAODKNE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6AC28F0", Offset = "0x6AC14F0", VA = "0x186AC28F0")]
		protected int[] GKPGOCCMGKO(MONPPOOEEPJ COBCMDNCOPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "13")]
		protected virtual LKOMDOLALMB MOMCCPCLIKM(AvatarItemBodyType GAHDPPDCPDD, Dictionary<string, MCOGOHBOKKE> NIMKPHLEIBO, Dictionary<string, MGEGMLPKNPK<Texture2D>> NICPFIEMJOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6AC22A0", Offset = "0x6AC0EA0", VA = "0x186AC22A0", Slot = "14")]
		protected virtual DMMKPEDFDBF FHHKDDIINNE(IList<ECCEHBBGHLP> BIIHLMGBMIO, AvatarItemBodyType DMHKGOPCHBP, bool LOKEFHBNNOC, int[] BIECHDJLAGL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6AC5920", Offset = "0x6AC4520", VA = "0x186AC5920", Slot = "15")]
		protected virtual MCOGOHBOKKE MCHMHDHFEJL(LAELCEHABJN MAMENCEBGLO, AvatarItemBodyType GAHDPPDCPDD, BCGODMJDFFO NOIJPBIAGKF, MCOGOHBOKKE JLNICHAMLCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "16")]
		protected virtual MCOGOHBOKKE DNGDINEKLEN(AvatarItemBodyType GAHDPPDCPDD, BCGODMJDFFO NOIJPBIAGKF, CHHFAOKLMGC PIAKONPJLMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6AC0AA0", Offset = "0x6ABF6A0", VA = "0x186AC0AA0")]
		protected void CLCFEEECGEJ(NPOOPLDBDAC FBJCKJAPAIH, HDFJPOEIMPO.CLDPEDONPKD ICADPJBMLMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6AC0470", Offset = "0x6ABF070", VA = "0x186AC0470")]
		protected void CBDDALAIPHE(NPOOPLDBDAC FBJCKJAPAIH, HDFJPOEIMPO.CLDPEDONPKD ICADPJBMLMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xC3EBC0", Offset = "0xC3D7C0", VA = "0x180C3EBC0", Slot = "17")]
		protected virtual NPOOPLDBDAC EAPPDIPHBOD(NPOOPLDBDAC FBJCKJAPAIH, HelmetHairStyle FGPPNNGOEKN, bool AFPDHOBNLDF, AvatarItemBodyType DMHKGOPCHBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3B10", Offset = "0x6AC2710", VA = "0x186AC3B10")]
		protected NPOOPLDBDAC JJDMFPOFOOG(IList<ECCEHBBGHLP> BIIHLMGBMIO, AvatarItemBodyType OCCAKLGJADD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6AC14C0", Offset = "0x6AC00C0", VA = "0x186AC14C0")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6AC5600", Offset = "0x6AC4200", VA = "0x186AC5600")]
		protected void KPOPGIEMBND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6AC4B20", Offset = "0x6AC3720", VA = "0x186AC4B20")]
		protected void JNPPCEAGAAC(Transform HOPONHGKBJH, IEnumerable<SkinnedMeshRenderer> FAJFHPODLFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6D60", Offset = "0x6AC5960", VA = "0x186AC6D60")]
		protected HDFJPOEIMPO.CLDPEDONPKD OAJHCMNMLND(HDFJPOEIMPO.CLDPEDONPKD BOEIEOPKABF, BCGODMJDFFO EMBEFPCMDOD)
		{
			return default(HDFJPOEIMPO.CLDPEDONPKD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6AC29F0", Offset = "0x6AC15F0", VA = "0x186AC29F0")]
		protected void GNBGJKONGKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xB8E540", Offset = "0xB8D140", VA = "0x180B8E540")]
		protected void GEGMJNBMDMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6AC0990", Offset = "0x6ABF590", VA = "0x186AC0990")]
		protected void CIKCJBDFCOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x6AC1BA0", Offset = "0x6AC07A0", VA = "0x186AC1BA0")]
		[AsyncStateMachine(typeof(PIIEHFGAMLC))]
		protected Task DPLGFPOLCPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2B50", Offset = "0x6AC1750", VA = "0x186AC2B50")]
		protected static IDOFKBBIPLO HLFIBOHOGOA(IABFAPJBOCJ OIPCGKGDBEI, int AHOFCFEMJEN)
		{
			return default(IDOFKBBIPLO);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6AC0840", Offset = "0x6ABF440", VA = "0x186AC0840")]
		protected static PJCNGFBNLLE CIHMJFPIBOJ(IABFAPJBOCJ OIPCGKGDBEI, int AHOFCFEMJEN)
		{
			return default(PJCNGFBNLLE);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6AC64F0", Offset = "0x6AC50F0", VA = "0x186AC64F0")]
		protected Transform NCAHJCBJHHM(BCGODMJDFFO NOIJPBIAGKF, OutfitType FOLCNFDNCAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6010", Offset = "0x6AC4C10", VA = "0x186AC6010")]
		protected void MMBLGIFNMFP(int PFCHKADCENO, Material OFCNJEFMNEM, IABFAPJBOCJ OIPCGKGDBEI, [Out] Texture2D GKJEEGGNDPH, [Out] Vector4 PIPJCNIKOKP, [Out] Texture2D POKIAOMDAJE, [Out] Texture2D MCKCEBOPPIN, [Out] Texture2D DCIFDLNICKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6AC39C0", Offset = "0x6AC25C0", VA = "0x186AC39C0")]
		protected void JJAEADJNNPK(int PFCHKADCENO, Material OFCNJEFMNEM, IABFAPJBOCJ OIPCGKGDBEI, [Out] Color EDPBFFGGELC, [Out] Color IMLKOJLHIJB, [Out] Color BHJLBOAHMJD, [Out] Color FBOBNKOENOM, [Out] Color BAACFFBEFPM, [Out] Color AOAOLJOOIBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6AC07D0", Offset = "0x6ABF3D0", VA = "0x186AC07D0")]
		protected void CGDHDEHPGJP(Vector3 FIKECJKJAAD, Quaternion EDMDHCBPBPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9200", Offset = "0x6AC7E00", VA = "0x186AC9200")]
		public void SetHatAnchorParameters(KLLNLHCALDO ICEFKBNIDMA, AnchorParamsRestrictions HKDPFJJGPDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x6AC0FE0", Offset = "0x6ABFBE0", VA = "0x186AC0FE0")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere OMFJEHEFDGL, Transform NBOHLJJFKPI, KLLNLHCALDO ICEFKBNIDMA, AnchorParamsRestrictions MIJBBDFKOGC, [Out] Vector3 APNDNNBECGB, [Out] Quaternion NDNBHPBJOKJ, [Out] KLLNLHCALDO IJIFPLNLAGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x6AC8090", Offset = "0x6AC6C90", VA = "0x186AC8090")]
		public void ResetHatAnchor(Vector2 HFHHAJJKNKD, Vector3 FOHGIAEFOKJ, Vector3 JIEAKCOOOOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xA62780", Offset = "0xA61380", VA = "0x180A62780")]
		public KOJPDNMMOFJ GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x6ABF8F0", Offset = "0x6ABE4F0", VA = "0x186ABF8F0")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x6ABFA30", Offset = "0x6ABE630", VA = "0x186ABFA30")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x6ABF860", Offset = "0x6ABE460", VA = "0x186ABF860")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6ACA950", Offset = "0x6AC9550", VA = "0x186ACA950", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x6ABF600", Offset = "0x6ABE200", VA = "0x186ABF600")]
		protected void ACJBMHADFMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6ACA7E0", Offset = "0x6AC93E0", VA = "0x186ACA7E0")]
		public void SetWaitForUgcTextureLoads(bool DPCDCCDMEHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x6ACA6F0", Offset = "0x6AC92F0", VA = "0x186ACA6F0")]
		public void SetUgcTextureParameters(EHJFAJIMFLL HHLMDDDPFNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x6ACB170", Offset = "0x6AC9D70", VA = "0x186ACB170")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6FA0", Offset = "0x6AC5BA0", VA = "0x186AC6FA0")]
		[CompilerGenerated]
		private void OHIEDJKGJEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7720", Offset = "0x6AC6320", VA = "0x186AC7720")]
		[CompilerGenerated]
		private void PCKPHCFNLHD(BNNOFCODNLO IBGHKNDMEOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2860", Offset = "0x6AC1460", VA = "0x186AC2860")]
		[CompilerGenerated]
		private void GDLICGKBOAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2020", Offset = "0x6AC0C20", VA = "0x186AC2020")]
		[CompilerGenerated]
		private void EJBIACEKBAC(BNNOFCODNLO IBGHKNDMEOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x6AC1C70", Offset = "0x6AC0870", VA = "0x186AC1C70")]
		[CompilerGenerated]
		private void EBODBPKFHGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6AC5F70", Offset = "0x6AC4B70", VA = "0x186AC5F70")]
		[CompilerGenerated]
		private void MMAAPFBIIAH(BNNOFCODNLO IBGHKNDMEOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x6AC05E0", Offset = "0x6ABF1E0", VA = "0x186AC05E0")]
		[CompilerGenerated]
		private void CBOCHJFINMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x6ABF6C0", Offset = "0x6ABE2C0", VA = "0x186ABF6C0")]
		[CompilerGenerated]
		private void AGNKLFPDCPB(BNNOFCODNLO IBGHKNDMEOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2560", Offset = "0x6AC1160", VA = "0x186AC2560")]
		[CompilerGenerated]
		private void FMAGMODLICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3970", Offset = "0x6AC2570", VA = "0x186AC3970")]
		[CompilerGenerated]
		private void JIANOFOFHCE(BNNOFCODNLO IBGHKNDMEOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7450", Offset = "0x6AC6050", VA = "0x186AC7450")]
		[CompilerGenerated]
		private void OPHAGCAKOOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6CA0", Offset = "0x6AC58A0", VA = "0x186AC6CA0")]
		[CompilerGenerated]
		private void NIKFBKIFIGJ(BNNOFCODNLO IBGHKNDMEOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6AC21C0", Offset = "0x6AC0DC0", VA = "0x186AC21C0")]
		[CompilerGenerated]
		internal static bool EPLAAOAFPMD(Transform AAMAOPHIJOM, IEnumerable<SkinnedMeshRenderer> GCLAAKOJDKO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6AC0430", Offset = "0x6ABF030", VA = "0x186AC0430")]
		[CompilerGenerated]
		private void BJPGDBJIFGL(BNNOFCODNLO IBGHKNDMEOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x6ABF710", Offset = "0x6ABE310", VA = "0x186ABF710")]
		[CompilerGenerated]
		private void AMIDIODJEBB(BNNOFCODNLO IBGHKNDMEOP)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, PJNLDGODMKB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private struct OCNDOAKGPCK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			public LOGMJPPPGNI avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x6AD4970", Offset = "0x6AD3570", VA = "0x186AD4970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x6AD4C00", Offset = "0x6AD3800", VA = "0x186AD4C00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private struct CPMPBPFPLAG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000430")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000431")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public CAJNNHABANH avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x6AD14A0", Offset = "0x6AD00A0", VA = "0x186AD14A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x6AD1670", Offset = "0x6AD0270", VA = "0x186AD1670", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private struct PCFNKFNIKFH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public CAJNNHABANH avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x6AD4C60", Offset = "0x6AD3860", VA = "0x186AD4C60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x6AD4E00", Offset = "0x6AD3A00", VA = "0x186AD4E00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private struct FHAIHIAIGDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public LOGMJPPPGNI avatarData;
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private struct BMFFGFAJBGP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			public LOGMJPPPGNI avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x6ACD030", Offset = "0x6ACBC30", VA = "0x186ACD030", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x6ACD710", Offset = "0x6ACC310", VA = "0x186ACD710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct FMFOHECMODH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public CAJNNHABANH avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			private TaskAwaiter<FHBHPBPNMDC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x6AD2020", Offset = "0x6AD0C20", VA = "0x186AD2020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x6AD2420", Offset = "0x6AD1020", VA = "0x186AD2420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct NPNIKEKONNF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public CAJNNHABANH avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x6AD4430", Offset = "0x6AD3030", VA = "0x186AD4430", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x6AD4910", Offset = "0x6AD3510", VA = "0x186AD4910", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		protected const float AIEHHLDKPCO = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		protected const int EJNKKGONOFH = 5;

		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		protected static readonly Dictionary<GLFIAOJIINM.PDFEAIHGAJJ, int> OMDJHDBFAHN;

		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> KHLMKJKFKCB;

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		protected static readonly int PEMMLCOODPA;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		protected static readonly int PEEJKLKNNMH;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		protected static readonly int GNJNIEONPDD;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		protected static readonly int PMOAMHGAJEH;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		protected static readonly int CPDKBDNHBDE;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		protected static readonly int GOCLPCPMLHB;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		protected static readonly int MJCOPPLOFLM;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		protected static readonly int GNGNNPODGED;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		protected static Vector2 BCNHJMNKMGG;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		protected static Vector2 PCCPNMLDLCC;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		protected static Vector2 ICMGINJHNMM;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		protected static Vector2 DCHBCHAELIM;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		protected static Vector2 CCOAABJFDJA;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		protected static Vector2 GAHPJEHKGHE;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		protected static Vector2 GCMCJOGFGMN;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		protected static Vector2 LMHCELJLADK;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		protected static Vector2 KHFEJDIFBJJ;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		protected static Vector2 FDANEFFJOEG;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		protected static Vector2 JJKOABCDBGE;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		protected static Vector2 DOFCDAIHKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		[SerializeField]
		[GBPOFPPCAAP(KOFDDAAAPEO.Self, false, false, false)]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		[Header("Rendering")]
		[SerializeField]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		[SerializeField]
		[Header("Emotes")]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		[SerializeField]
		[Header("Modern Avatar Facial Features")]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private CAJNNHABANH PEBKENJOKEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private FaceStyleSet PPOJIFHMBFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		protected const int BADEINEBKFP = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		protected int CHHPOFINMNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		protected int HIMOBBACPFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		protected int PBGAPIMLFPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		protected int IINCAFNHDGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		protected Vector2 NEJJJKNDIFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		protected float CABEJLKKFOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		protected Vector2 FICIJJKICJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		protected float EPJEOENNPJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		protected Vector2 NFDNBJEPHAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		protected float LPBLNECBHHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		protected Vector2 GACDKDCBKLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		protected float DFJIHJCKELD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		protected List<SelectableFaceOption> EAHNMFOJECL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		protected List<SelectableFaceOption> CJEKLMBIEEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		protected List<SelectableFaceOption> LHDHDNHALBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		protected List<SelectableFaceOption> GEDLEPFKPKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		protected Coroutine LGEOLHDLEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		protected int? HMONBLDDFGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		protected int IGFJIBFEGPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		protected int DOGOMPEGJME;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		protected int IHMCCKNDNCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		protected int LNDAGNBDEBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		protected int KIPGNHELPIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		protected int DEMFBIANDKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		protected Sprite MNFOCNJODMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		protected Sprite LEMEMDJMELN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		protected Sprite IPMCJJAPNAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		protected Sprite JEJDEELJFAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		protected bool NMIIGLHFPND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		protected string FJNLOGBGCHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		protected string HHAPJHBHGML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		protected string PKDKBHKPHAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected string NJIKDLFHKMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		protected AvatarConfiguration GFGAGDKNLPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		protected FHBHPBPNMDC PILOPCKJCNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		protected MaterialPropertyBlock AIMOKEKOICP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected Dictionary<string, int> MJMPEMMEEEE;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public FaceStyleSet ENAKEIDDCBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x6ADAB20", Offset = "0x6AD9720", VA = "0x186ADAB20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public bool LEOLOCPNFLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0xE20AB0", Offset = "0xE1F6B0", VA = "0x180E20AB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0xE1ECC0", Offset = "0xE1D8C0", VA = "0x180E1ECC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		protected virtual bool FNNBDECAJMP
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		protected virtual bool LCIPCHLHEOM
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		protected int FAPDNEEKDDI
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x6AD64D0", Offset = "0x6AD50D0", VA = "0x186AD64D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public Renderer KLCIIJDOFFL
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x88ABD0", Offset = "0x8897D0", VA = "0x18088ABD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public bool BCFDHMBGCDK
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0xE20C20", Offset = "0xE1F820", VA = "0x180E20C20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xE20F10", Offset = "0xE1FB10", VA = "0x180E20F10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public Renderer[] CNLPGNINAEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x88C720", Offset = "0x88B320", VA = "0x18088C720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public bool EOBDPMOBDLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x6ADAB60", Offset = "0x6AD9760", VA = "0x186ADAB60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x6ADAD20", Offset = "0x6AD9920", VA = "0x186ADAD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		protected int KCODOHAHBKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x6AD6730", Offset = "0x6AD5330", VA = "0x186AD6730")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		protected int IBDBHGNMAHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x6AD7C00", Offset = "0x6AD6800", VA = "0x186AD7C00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public float PLNDEPMHJLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x6ADAB40", Offset = "0x6AD9740", VA = "0x186ADAB40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x6ADAD00", Offset = "0x6AD9900", VA = "0x186ADAD00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public GGKOGEALPJB EJGFHGDGPDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x960F90", Offset = "0x95FB90", VA = "0x180960F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0xD449E0", Offset = "0xD435E0", VA = "0x180D449E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public FHBHPBPNMDC LKBIBOHPELF
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0xD449A0", Offset = "0xD435A0", VA = "0x180D449A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x6ADAC80", Offset = "0x6AD9880", VA = "0x186ADAC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public NoseFaceOption JHEJNEEGKDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0xBAB2E0", Offset = "0xBA9EE0", VA = "0x180BAB2E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0xD44AA0", Offset = "0xD436A0", VA = "0x180D44AA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		protected MaterialPropertyBlock FNFECJMEDPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x6AD8230", Offset = "0x6AD6E30", VA = "0x186AD8230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action KAIHPPKCJLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x6ADAA70", Offset = "0x6AD9670", VA = "0x186ADAA70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x6ADABD0", Offset = "0x6AD97D0", VA = "0x186ADABD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7CD0", Offset = "0x6AD68D0", VA = "0x186AD7CD0")]
		public void LocalPlayEmote(GLFIAOJIINM.PDFEAIHGAJJ DLHEBFLILFM, float MEKAINEFPND = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7AF0", Offset = "0x6AD66F0", VA = "0x186AD7AF0")]
		public bool IsEmotePlaying(GLFIAOJIINM.PDFEAIHGAJJ DLHEBFLILFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8C00", Offset = "0x6AD7800", VA = "0x186AD8C00")]
		public void SetIdleHappy(bool DJLJBBMNADP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6600", Offset = "0x6AD5200", VA = "0x186AD6600")]
		protected void FBEPCJHBENL(bool CAPINKJDPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8050", Offset = "0x6AD6C50", VA = "0x186AD8050")]
		protected void OLPIFHKCHIG(bool IILLMCMCELD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7EB0", Offset = "0x6AD6AB0", VA = "0x186AD7EB0")]
		protected void NFGDKGKPFBA(BCGODMJDFFO NOIJPBIAGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7C60", Offset = "0x6AD6860", VA = "0x186AD7C60")]
		protected void KGKHKIEHANM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8430", Offset = "0x6AD7030", VA = "0x186AD8430")]
		public void PlayExpression(int LJBJEPNFGFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6680", Offset = "0x6AD5280", VA = "0x186AD6680")]
		protected void GEPCEJDGCNL(bool FCLLIJFABAE, bool NBDCOCFOFHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6960", Offset = "0x6AD5560", VA = "0x186AD6960")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType BOCNMNBFMDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7630", Offset = "0x6AD6230", VA = "0x186AD7630")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration GFGAGDKNLPB, CAJNNHABANH HFBIBPKGGBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x6AD89E0", Offset = "0x6AD75E0", VA = "0x186AD89E0")]
		[AsyncStateMachine(typeof(OCNDOAKGPCK))]
		public Task SetFaceSettings(LOGMJPPPGNI CKCGPKIPOPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8AD0", Offset = "0x6AD76D0", VA = "0x186AD8AD0")]
		[AsyncStateMachine(typeof(CPMPBPFPLAG))]
		public Task SetFaceSettings(int IAODIGEHMGJ, int GEBGJNAPLGH, int KPOACHLKAEN, int FFLGPJKNHOF, CAJNNHABANH HFBIBPKGGBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8C80", Offset = "0x6AD7880", VA = "0x186AD8C80")]
		[AsyncStateMachine(typeof(PCFNKFNIKFH))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType BOCNMNBFMDO, int KANILGNLKOM, CAJNNHABANH HFBIBPKGGBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x6AD61D0", Offset = "0x6AD4DD0", VA = "0x186AD61D0")]
		protected void CLBKAEMNFCK(FaceFeatureType BOCNMNBFMDO, OCAFLGKEFMJ HAANOCJKGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x6AD58F0", Offset = "0x6AD44F0", VA = "0x186AD58F0")]
		protected void BJPFCIAJMBB(FaceFeatureType BOCNMNBFMDO, int KANILGNLKOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6790", Offset = "0x6AD5390", VA = "0x186AD6790")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x6AD69A0", Offset = "0x6AD55A0", VA = "0x186AD69A0")]
		[AsyncStateMachine(typeof(BMFFGFAJBGP))]
		protected Task HAFCIPPMNEP(LOGMJPPPGNI CKCGPKIPOPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6340", Offset = "0x6AD4F40", VA = "0x186AD6340")]
		protected static void EIGBHFIECCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x6AD73D0", Offset = "0x6AD5FD0", VA = "0x186AD73D0")]
		private void IHPGPNAFEGK(bool GLBBOIPNKMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5440", Offset = "0x6AD4040", VA = "0x186AD5440")]
		protected void ANOICBEEGHC(FaceFeatureType BOCNMNBFMDO, Vector2 JINJJMHMJDB, CAJNNHABANH HFBIBPKGGBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8450", Offset = "0x6AD7050", VA = "0x186AD8450")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType BOCNMNBFMDO, Vector2 LOMJDNLEJMN, CAJNNHABANH HFBIBPKGGBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x6AD82B0", Offset = "0x6AD6EB0", VA = "0x186AD82B0")]
		protected void PLHHEKHJNMK(FaceFeatureType BOCNMNBFMDO, float PCECEDCIAJJ, CAJNNHABANH HFBIBPKGGBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6AD87C0", Offset = "0x6AD73C0", VA = "0x186AD87C0")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType BOCNMNBFMDO, float KLOCMHNDOOE, CAJNNHABANH HFBIBPKGGBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6A90", Offset = "0x6AD5690", VA = "0x186AD6A90")]
		[AsyncStateMachine(typeof(FMFOHECMODH))]
		protected Task HPJANMCBOMH(CAJNNHABANH HFBIBPKGGBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x6AD78E0", Offset = "0x6AD64E0", VA = "0x186AD78E0")]
		public void InitializeFaceFeatureStyleSet(CAJNNHABANH HFBIBPKGGBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x6AD60F0", Offset = "0x6AD4CF0", VA = "0x186AD60F0")]
		protected bool CGALFFAMBIF(string MIMLJJIOMLJ, [Out] int MFJLAMOCOBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x6AD57B0", Offset = "0x6AD43B0", VA = "0x186AD57B0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xE7A020", Offset = "0xE78C20", VA = "0x180E7A020", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x6AD81B0", Offset = "0x6AD6DB0", VA = "0x186AD81B0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9C60", Offset = "0x6AD8860", VA = "0x186AD9C60")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6000", Offset = "0x6AD4C00", VA = "0x186AD6000")]
		[AsyncStateMachine(typeof(NPNIKEKONNF))]
		public Task BuildFaceStyleAsyncIfChanged(CAJNNHABANH HFBIBPKGGBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9570", Offset = "0x6AD8170", VA = "0x186AD9570")]
		public void UpdateFaceDisplays(bool KGLLODMOCLL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6B70", Offset = "0x6AD5770", VA = "0x186AD6B70")]
		protected bool IDBEIJLLNHN(bool KGLLODMOCLL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9290", Offset = "0x6AD7E90", VA = "0x186AD9290")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8D90", Offset = "0x6AD7990", VA = "0x186AD8D90")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x6AD97A0", Offset = "0x6AD83A0", VA = "0x186AD97A0")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9990", Offset = "0x6AD8590", VA = "0x186AD9990")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7DC0", Offset = "0x6AD69C0", VA = "0x186AD7DC0")]
		protected void MJHPNMDIKNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA870", Offset = "0x6AD9470", VA = "0x186ADA870")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x8B57E0", Offset = "0x8B43E0", VA = "0x1808B57E0", Slot = "4")]
		private bool OHGACKONIMH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7F20", Offset = "0x6AD6B20", VA = "0x186AD7F20")]
		[CompilerGenerated]
		internal static EBEALDMKIMI OHJFHMMHGLN(FaceFeatureType BOCNMNBFMDO, FHAIHIAIGDH P_1)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct DCNPNIKMPJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public string IHBMAHBKJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public int HJABBJLNKKC;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[ExecuteInEditMode]
	public class PlayerModernBodyEditorAvatarValidator : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public CAJNNHABANH avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public DMLKGCCJOHI useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public KLLNLHCALDO hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public KOJPDNMMOFJ HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public HDFJPOEIMPO.CLDPEDONPKD baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		[GBPOFPPCAAP(KOFDDAAAPEO.Self, false, false, false)]
		[SerializeField]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private HLGIGNKBIOE MHEHIGFMCJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		[SerializeField]
		[GBPOFPPCAAP(KOFDDAAAPEO.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public readonly DCNPNIKMPJF[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public readonly (string, MBPKGLMAGIN)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		protected bool PNICHAHNEGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		protected Guid ONDJPOAJOJC;

		[Cpp2IlInjected.Token(Token = "0x400049E")]
		protected static Guid BEKOCGNJEIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private GGDKLOOMBAO FOGBOGOIMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private GGKOGEALPJB LLKFKLJPMBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private GBABJKDKLCB MJEJDGNNKKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private GBABJKDKLCB CPEJHKENLJB;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public static Func<CHHFAOKLMGC> JBBGGFCNEGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x6ADCDC0", Offset = "0x6ADB9C0", VA = "0x186ADCDC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x6ADD130", Offset = "0x6ADBD30", VA = "0x186ADD130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public bool KPBBJKFJKJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x6ADCFA0", Offset = "0x6ADBBA0", VA = "0x186ADCFA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public bool LFEGAGKEIBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x6ADCE10", Offset = "0x6ADBA10", VA = "0x186ADCE10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public PlayerAvatarDisplayBase JDKMEBPPDID
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0xCCEE20", Offset = "0xCCDA20", VA = "0x180CCEE20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		protected static Guid AKAPAFBLPNO
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x6ADB9C0", Offset = "0x6ADA5C0", VA = "0x186ADB9C0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB8F0", Offset = "0x6ADA4F0", VA = "0x186ADB8F0")]
		private void LDBNNHNCJCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0xBE41B0", Offset = "0xBE2DB0", VA = "0x180BE41B0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB180", Offset = "0x6AD9D80", VA = "0x186ADB180")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x6ADBB50", Offset = "0x6ADA750", VA = "0x186ADBB50")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6ADBB20", Offset = "0x6ADA720", VA = "0x186ADBB20")]
		public void ShowPose(string GBEMPCLBMKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x6ADBAB0", Offset = "0x6ADA6B0", VA = "0x186ADBAB0")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x6ADBE90", Offset = "0x6ADAA90", VA = "0x186ADBE90")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x6ADBD90", Offset = "0x6ADA990", VA = "0x186ADBD90")]
		public void UpdateFaceAndBodyShapes(bool PGAIPAODKNE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x6ADBF40", Offset = "0x6ADAB40", VA = "0x186ADBF40")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x6ADAE70", Offset = "0x6AD9A70", VA = "0x186ADAE70", Slot = "4")]
		protected virtual void DFMEJEBELNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB740", Offset = "0x6ADA340", VA = "0x186ADB740", Slot = "5")]
		protected virtual void KLGFALMHLMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x6ADBFC0", Offset = "0x6ADABC0", VA = "0x186ADBFC0")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		[SerializeField]
		[GBPOFPPCAAP(KOFDDAAAPEO.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x88A130", Offset = "0x888D30", VA = "0x18088A130")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct ECCEHBBGHLP
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class HDLPFEACAED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public HDLPFEACAED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2840", Offset = "0x6AD1440", VA = "0x186AD2840")]
		internal bool JIFAIJPNJPE(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	private LAELCEHABJN JIKDHJDELFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	private BCGODMJDFFO GHAMBKBHNNB;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public LAELCEHABJN CPOJDNOPOEB
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public BCGODMJDFFO FCGPGKINHAE
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x2161EC0", Offset = "0x2160AC0", VA = "0x182161EC0")]
		get
		{
			return default(BCGODMJDFFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public string KDMDJKONIOI
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6AD1E70", Offset = "0x6AD0A70", VA = "0x186AD1E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public bool OPLJEAEHIGO
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x6AD1E20", Offset = "0x6AD0A20", VA = "0x186AD1E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool FOBFGNMOOFD
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x6AD1DD0", Offset = "0x6AD09D0", VA = "0x186AD1DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x1DB8550", Offset = "0x1DB7150", VA = "0x181DB8550")]
	public ECCEHBBGHLP(LAELCEHABJN MAMENCEBGLO, BCGODMJDFFO NOIJPBIAGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1F60", Offset = "0x6AD0B60", VA = "0x186AD1F60")]
	public bool NCFMGOGOEGK(OutfitType OLGCDBGGHND, BCGODMJDFFO AKHINIOGHMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1980", Offset = "0x6AD0580", VA = "0x186AD1980")]
	public bool AMGMEFHPLGB(OutfitType OLGCDBGGHND, BCGODMJDFFO AKHINIOGHMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1BE0", Offset = "0x6AD07E0", VA = "0x186AD1BE0")]
	public bool BHLMFCBBBOI(ECCEHBBGHLP HPOIIEOMEHC)
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
