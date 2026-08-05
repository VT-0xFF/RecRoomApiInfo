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
using Unity.Profiling;
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
	public class LogRegistrationIndex : PBLCGONKBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x68A0970", Offset = "0x689EF70", VA = "0x1868A0970", Slot = "4")]
		public override void NECNOABNHFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
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
			[Cpp2IlInjected.Address(RVA = "0x8736F0", Offset = "0x871CF0", VA = "0x1808736F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x68A4580", Offset = "0x68A2B80", VA = "0x1868A4580", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x68A44B0", Offset = "0x68A2AB0", VA = "0x1868A44B0", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x68A4540", Offset = "0x68A2B40", VA = "0x1868A4540")]
		public RecNetCDNAssetReference(RecNetCDNKey IBBDLGCDELM)
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
			[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x868230", Offset = "0x866830", VA = "0x180868230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x868210", Offset = "0x866810", VA = "0x180868210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x868280", Offset = "0x866880", VA = "0x180868280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x68A45C0", Offset = "0x68A2BC0", VA = "0x1868A45C0")]
		public static RecNetCDNKey BHGIDKFMDIF(string MEGFKBILDLA, string MOKHEMMEDBH = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6094260", Offset = "0x6092860", VA = "0x186094260")]
		public void PKPLIJHAEIK(string KGDLCMFHBJM, string JEEDPHFPHKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x68A46C0", Offset = "0x68A2CC0", VA = "0x1868A46C0")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[OBKEFOLKLJN]
public class NFFHEKBADKP : IMIPMOPGJMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> CMPIJOJNBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> EFNABAEBCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> LKLJGAMHIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> MHCBCGDLCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> HJADABHKJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> CCDFOIGAKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> ICJPPBLDLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator AMDDDCHNIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected KIOBLMMIJDE BGMBFJJHBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte HOOKCFDEFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> BFDJNFACGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> LFCPHFJPLFL;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x68A2980", Offset = "0x68A0F80", VA = "0x1868A2980", Slot = "4")]
	public void PAHIHILCCKN(Mesh CKFPIMAMAKM, Matrix4x4 EKEOEEDOIMB, byte[] LOOMBJNKMNA, bool HGLFDEKEPAK = false, MCHDNMDHAEL.INMFOKLKEDE PFNGDMHJOCF = (MCHDNMDHAEL.INMFOKLKEDE)0, int KDDNECEJJCJ = -1, bool FLHCIBEFFDB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x68A26F0", Offset = "0x68A0CF0", VA = "0x1868A26F0", Slot = "5")]
	public void IFFCPHBGFPI(Allocator KOIILCBLJPK, KIOBLMMIJDE NBOPFLHBMDO, byte MKECCECLDLC, [Optional] IList<int> NAIKMFEKNHM, [Optional] IList<int> NDOMDOECFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x68A2730", Offset = "0x68A0D30", VA = "0x1868A2730")]
	private static void ILFLLHCPMMJ(Mesh CKFPIMAMAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x68A2B90", Offset = "0x68A1190", VA = "0x1868A2B90")]
	public NFFHEKBADKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[OBKEFOLKLJN]
public struct MJAFJFFLFLM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public DNHIHLNODBH JEGMBFLIMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int FFKOANCNBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public ADGLHGMPEFE PFODDJJJLFC;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x68A0C40", Offset = "0x689F240", VA = "0x1868A0C40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[OBKEFOLKLJN]
[NativeContainer]
public struct ADGLHGMPEFE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct HBAKIJLCPIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector3 BIMFCFHGNID;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 MHHLIPGJMOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector4 PDEEPPMIHOL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct PKLDDHGAODC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float NINLNDAOBPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float BIMPFFEMCCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float LJCGGBNOFIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float FEKHDNJJPGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte BEAMOJOFLPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte DLCAKIEDAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte AGOOJOMBICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte LPMJCFHGAHE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct JCKNFMACGPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half NINLNDAOBPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half BIMPFFEMCCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half LJCGGBNOFIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half FEKHDNJJPGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte BEAMOJOFLPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte DLCAKIEDAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte AGOOJOMBICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte LPMJCFHGAHE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct DGDKACHOCFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 PHHAMGLLFIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 HMLILMGDBLP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct EKIIHLBAJMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half4 PHHAMGLLFIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 HMLILMGDBLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 HLJKFNMJEHJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct JAPABAEKMNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 PHHAMGLLFIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 HMLILMGDBLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 HLJKFNMJEHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 JIDOFMCGOBD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct PNLNMEINOFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half4 PHHAMGLLFIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 HMLILMGDBLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 HLJKFNMJEHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 JIDOFMCGOBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 KLPGFCJEAHC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct DGMMNAPBDAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float NINLNDAOBPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float BIMPFFEMCCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float LJCGGBNOFIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float FEKHDNJJPGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int BEAMOJOFLPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int DLCAKIEDAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int AGOOJOMBICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int LPMJCFHGAHE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct GEFJGKCPCGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Color PHHAMGLLFIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 HMLILMGDBLP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct EENNFMBOGFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color PHHAMGLLFIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 HMLILMGDBLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 HLJKFNMJEHJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct CIOEEICIFCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color PHHAMGLLFIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 HMLILMGDBLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 HLJKFNMJEHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 JIDOFMCGOBD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct AEDBPMJOFJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color PHHAMGLLFIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 HMLILMGDBLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 HLJKFNMJEHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 JIDOFMCGOBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 KLPGFCJEAHC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool OCBBCIDCCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<HBAKIJLCPIB> DICPJLHANBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<DGDKACHOCFM> LKOAEPPFJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<EKIIHLBAJMJ> DGLGPEGKCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<JAPABAEKMNG> INCJAEKHDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<PNLNMEINOFD> LFOOPCLDEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<JCKNFMACGPB> PBMOLHEFEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<PKLDDHGAODC> BIELBDHPLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<GEFJGKCPCGP> OMALEJLFPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<EENNFMBOGFG> ICKEPNPBLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<CIOEEICIFCH> KHJANAIABIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<AEDBPMJOFJO> DGDMDGEADGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<DGMMNAPBDAN> IPGOEEKAGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> EDHINNGADDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> IDGFFEPELNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> GGLPIPFABPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> FBCPGHJOOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> FGBKGACNLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> NIMCHBMKFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> OCDILKMNPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<BoneWeight> DHLKOFKEEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> FPAICILAIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool FFFODBMOBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool ECPGDMBEKKG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int LEHJJPECCMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x688E2D0", Offset = "0x688C8D0", VA = "0x18688E2D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x688CCD0", Offset = "0x688B2D0", VA = "0x18688CCD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int LHFAMOIFAGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x688E2C0", Offset = "0x688C8C0", VA = "0x18688E2C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x688CCE0", Offset = "0x688B2E0", VA = "0x18688CCE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int IKFNKJFHIID
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x688D370", Offset = "0x688B970", VA = "0x18688D370")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x688CCF0", Offset = "0x688B2F0", VA = "0x18688CCF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int GICGKPHOGII
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x688CD00", Offset = "0x688B300", VA = "0x18688CD00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x688E2E0", Offset = "0x688C8E0", VA = "0x18688E2E0")]
	public ADGLHGMPEFE(int EIKOHLMEALF, int CMOJBMNAPOM, int BAKEFDDNOAI, int DABNCBFOFEA, Allocator KOIILCBLJPK, int MFDMCGEIMDL, DOIGPACLKEN HBFDLEDKGOI, bool FFFODBMOBAB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x688D1A0", Offset = "0x688B7A0", VA = "0x18688D1A0")]
	public void JLIKOCHJIGN(int PDMMEDBMFPP, Vector3 HAHPKMHGFDD, Vector3 NOOFNNECEBO, Vector4 FCNFHCDDANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x688CD70", Offset = "0x688B370", VA = "0x18688CD70")]
	public void HDHBHBBJDBA(int PDMMEDBMFPP, BoneWeight NKJBLBMGPCC, NativeSlice<byte> LOOMBJNKMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x688BF90", Offset = "0x688A590", VA = "0x18688BF90")]
	public Color ACCLLILKDOF(int PDMMEDBMFPP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x688C670", Offset = "0x688AC70", VA = "0x18688C670")]
	public void BPBPPFNAKPL(int PDMMEDBMFPP, Color NAHNDCNFAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x688C2C0", Offset = "0x688A8C0", VA = "0x18688C2C0")]
	public void BKCJKMEEACK(byte LBDJIGNPONF, int PDMMEDBMFPP, Vector2 CHJJADPOMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x688D300", Offset = "0x688B900", VA = "0x18688D300")]
	public void LGHNMHENHME(int PDMMEDBMFPP, int GHMMLEKOEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x688D310", Offset = "0x688B910", VA = "0x18688D310")]
	public bool LLLHNGMNMPC(int LBDJIGNPONF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x688D230", Offset = "0x688B830", VA = "0x18688D230")]
	public void KPIFLOKOPKK(int DAIPCKHIIAP, int GCMGLJCEDLO, int JOCLJBACIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x688CA70", Offset = "0x688B070", VA = "0x18688CA70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x688D380", Offset = "0x688B980", VA = "0x18688D380")]
	public Mesh MFHBNNIPFCD([Optional] string HJAOMJEIKIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[NativeContainer]
[OBKEFOLKLJN]
[DefaultMember("Item")]
public struct DNHIHLNODBH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Mesh.MeshDataArray PGDBLJDCBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<int> IIIADABJMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> MICEEJHJJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<BoneWeight> DHLKOFKEEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<Matrix4x4> NOJDGBMLBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> AKBHPGIMMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<byte> FCJCFCIFEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> LDJELKPBFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> EJDADHFIAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeArray<sbyte> KJOCKNABEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<byte> NENJBOCNOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<bool> FLHCIBEFFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<int> KDDNECEJJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool FFFODBMOBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<int> KDDFKDCJLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool ECPGDMBEKKG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int FDJKPOJEDOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x68915C0", Offset = "0x688FBC0", VA = "0x1868915C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int KPEGOMLMKMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6891400", Offset = "0x688FA00", VA = "0x186891400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int CGGGDMGGJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x68914F0", Offset = "0x688FAF0", VA = "0x1868914F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int MKOCOOKHKPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x68913F0", Offset = "0x688F9F0", VA = "0x1868913F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68915D0", Offset = "0x688FBD0", VA = "0x1868915D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int LEHJJPECCMN
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6891830", Offset = "0x688FE30", VA = "0x186891830")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x68913E0", Offset = "0x688F9E0", VA = "0x1868913E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int GMCHKALJBBH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6891250", Offset = "0x688F850", VA = "0x186891250")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6891230", Offset = "0x688F830", VA = "0x186891230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public KIOBLMMIJDE LKEKCGLJIIP
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x68914E0", Offset = "0x688FAE0", VA = "0x1868914E0")]
		get
		{
			return default(KIOBLMMIJDE);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6891220", Offset = "0x688F820", VA = "0x186891220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte NBDGHIFPNAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6891240", Offset = "0x688F840", VA = "0x186891240")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x68913D0", Offset = "0x688F9D0", VA = "0x1868913D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public AJKJGMJNDAM CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x68915E0", Offset = "0x688FBE0", VA = "0x1868915E0")]
		get
		{
			return default(AJKJGMJNDAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6891840", Offset = "0x688FE40", VA = "0x186891840")]
	public DNHIHLNODBH(IList<Mesh> AMCIGEOJLFJ, IList<Matrix4x4> NKHPOJDCGOL, IList<bool> FLHCIBEFFDB, byte MKECCECLDLC, IList<byte[]> MLJAKDGJAMC, IList<int> HEFBNLOOBDC, IList<bool> CIGHNEMLKKN, IList<int> KDDNECEJJCJ, IList<int> NAIKMFEKNHM, IList<int> BFKLPCJEHGJ, Allocator KOIILCBLJPK, KIOBLMMIJDE NBOPFLHBMDO, bool FFFODBMOBAB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6891410", Offset = "0x688FA10", VA = "0x186891410")]
	public ADGLHGMPEFE GEDHAIANLMA(Allocator KOIILCBLJPK, DOIGPACLKEN HBFDLEDKGOI)
	{
		return default(ADGLHGMPEFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6891260", Offset = "0x688F860", VA = "0x186891260", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[OBKEFOLKLJN]
public class ENHIHKLNPIB : NFFHEKBADKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool DJENHJKAEAN;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly ProfilerMarker BAKNOHGIGKA;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6892A40", Offset = "0x6891040", VA = "0x186892A40")]
	public DNHIHLNODBH EIHNGNLMOEP()
	{
		return default(DNHIHLNODBH);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6892D00", Offset = "0x6891300", VA = "0x186892D00")]
	public ENHIHKLNPIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct AJKJGMJNDAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Mesh.MeshData AELKNIEGPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<BoneWeight> DHLKOFKEEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeSlice<byte> CNALBHAMNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int DMKEDKMAJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Matrix4x4 HNBEHKMEBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public int DNKGJOLJFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<byte> LOOMBJNKMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public bool JEOHGOPBCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int NIHEFKBEENL;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JIADPNPDEID : OFNGPKLAKGC
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class NNGGNJNHKHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly JNJJMPPHJEI MDKJNMBLDMK;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public virtual bool LJIPHBKOJKP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public virtual bool BDKJEGAHLOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public virtual MCHDNMDHAEL.INMFOKLKEDE DNKGJOLJFEL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "6")]
			get
			{
				return default(MCHDNMDHAEL.INMFOKLKEDE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool DMBFCBJGJJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x150F820", Offset = "0x150DE20", VA = "0x18150F820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool GAHPKAJNEMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x68A2E60", Offset = "0x68A1460", VA = "0x1868A2E60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool CHMJDAKHJHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x68A2E40", Offset = "0x68A1440", VA = "0x1868A2E40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x871800", Offset = "0x86FE00", VA = "0x180871800")]
		protected NNGGNJNHKHB(JNJJMPPHJEI OBANIHNJDAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract GJFFIMHAENI IEHJFKHFEAB(int[] IMLHNAOJEGO, List<CDLFAMOJMBM> MHBPHHKGPAO, List<CDLFAMOJMBM> FCGKCDCOKLK);

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract KEFPODDDPLB JMFJIFIKLKB(uint HEPMKAJPNDG, AvatarSkinnedMeshBoneOrderRemapsData FIHBIKBMFCO);
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class POPPLHOCCOM : NNGGNJNHKHB
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class HHCDKKNPCNI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public FNMJFLPICID<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public POPPLHOCCOM <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public HHCDKKNPCNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x68930F0", Offset = "0x68916F0", VA = "0x1868930F0")]
			internal void OKGCKNEDPON(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly AvatarSkinAssetItem.MMJKNIBLPLE MMNPJLBBPDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly AssetReference PKNMKLNHAPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly MCHDNMDHAEL.INMFOKLKEDE NAEGMJODEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly OMIIACJOJFJ? ALLILPEIPFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private readonly Material[] BIOIDHPMKIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private SkinnedMeshRenderer[] JOMJLGAAOMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private AvatarSkinAssetItem KJOPNNHBBPA;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override MCHDNMDHAEL.INMFOKLKEDE DNKGJOLJFEL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x86E900", Offset = "0x86CF00", VA = "0x18086E900", Slot = "6")]
			get
			{
				return default(MCHDNMDHAEL.INMFOKLKEDE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x68A43A0", Offset = "0x68A29A0", VA = "0x1868A43A0")]
		public POPPLHOCCOM(AvatarSkinAssetItem.MMJKNIBLPLE HDLBNIFMMJE, AssetReference AJKKMNJBBAF, Material GDHIAONAPNJ, JNJJMPPHJEI ANOHNNKPBBE, MCHDNMDHAEL.INMFOKLKEDE MDJBILBONKN = (MCHDNMDHAEL.INMFOKLKEDE)0, [Optional] OMIIACJOJFJ? JLJKGBLBCGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x68A4290", Offset = "0x68A2890", VA = "0x1868A4290")]
		public POPPLHOCCOM(AvatarSkinAssetItem.MMJKNIBLPLE HDLBNIFMMJE, AssetReference AJKKMNJBBAF, Material GDHIAONAPNJ, MCHDNMDHAEL.INMFOKLKEDE MDJBILBONKN = (MCHDNMDHAEL.INMFOKLKEDE)0, [Optional] OMIIACJOJFJ? JLJKGBLBCGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x68A3D70", Offset = "0x68A2370", VA = "0x1868A3D70", Slot = "7")]
		public override GJFFIMHAENI IEHJFKHFEAB(int[] IMLHNAOJEGO, List<CDLFAMOJMBM> MHBPHHKGPAO, List<CDLFAMOJMBM> FCGKCDCOKLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x68A3F40", Offset = "0x68A2540", VA = "0x1868A3F40", Slot = "8")]
		public override KEFPODDDPLB JMFJIFIKLKB(uint HEPMKAJPNDG, AvatarSkinnedMeshBoneOrderRemapsData FIHBIKBMFCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x68A4220", Offset = "0x68A2820", VA = "0x1868A4220", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class PBNGJIOBFPF : NNGGNJNHKHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public readonly NEMMBNHIEHO PKOEBJJGIIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private FNMJFLPICID<COPALOMMCJJ> NNLDNMCHJJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public COPALOMMCJJ HODAGFICNPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private FNMJFLPICID<Material[]> EOONINDKCOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public Material[] HOKNNNKJJKP;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool LJIPHBKOJKP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool BDKJEGAHLOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x68A3AB0", Offset = "0x68A20B0", VA = "0x1868A3AB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1D88B50", Offset = "0x1D87150", VA = "0x181D88B50")]
		public PBNGJIOBFPF(JNJJMPPHJEI OBANIHNJDAO, NEMMBNHIEHO MPHPPIDODHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x68A34F0", Offset = "0x68A1AF0", VA = "0x1868A34F0", Slot = "7")]
		public override GJFFIMHAENI IEHJFKHFEAB(int[] IMLHNAOJEGO, List<CDLFAMOJMBM> MHBPHHKGPAO, List<CDLFAMOJMBM> FCGKCDCOKLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x68A3980", Offset = "0x68A1F80", VA = "0x1868A3980", Slot = "8")]
		public override KEFPODDDPLB JMFJIFIKLKB(uint HEPMKAJPNDG, AvatarSkinnedMeshBoneOrderRemapsData FIHBIKBMFCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x68A3B10", Offset = "0x68A2110", VA = "0x1868A3B10")]
		public KEFPODDDPLB MIJFCJCBKBB(GameObject GIGDFDNBHPL, uint HEPMKAJPNDG, bool MICLHANEEPC, bool FFFIEMMPJGL, AvatarSkinnedMeshBoneOrderRemapsData FIHBIKBMFCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x68A30B0", Offset = "0x68A16B0", VA = "0x1868A30B0")]
		public static bool BLFCLBAHFMF(Renderer[] EAKCNEDHLLO, string CKGCMLOPGIL, [Out] Renderer EJOMEBKPJCE, [Out] Renderer PFDEDJBPJEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x68A3D20", Offset = "0x68A2320", VA = "0x1868A3D20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x68A3420", Offset = "0x68A1A20", VA = "0x1868A3420")]
		private (FNMJFLPICID<COPALOMMCJJ>, FNMJFLPICID<Material[]>) HFDPCOJELJG()
		{
			return default((FNMJFLPICID<COPALOMMCJJ>, FNMJFLPICID<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x42F89E0", Offset = "0x42F6FE0", VA = "0x1842F89E0")]
		[CompilerGenerated]
		private void DJCNICOIEON(COPALOMMCJJ IAFCFGOKEAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x868F00", Offset = "0x867500", VA = "0x180868F00")]
		[CompilerGenerated]
		private void GFPFPDMHCIB(Material[] IAFCFGOKEAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class KHOCGPMBJLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public JIADPNPDEID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public EFOPDINOAPF buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public KHOCGPMBJLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x68A0950", Offset = "0x689EF50", VA = "0x1868A0950")]
		internal void OJBOKINMKKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x68A0930", Offset = "0x689EF30", VA = "0x1868A0930")]
		internal void MAMCHEGACAJ(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x68A08A0", Offset = "0x689EEA0", VA = "0x1868A08A0")]
		internal void HJODKGHIJDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x68A0810", Offset = "0x689EE10", VA = "0x1868A0810")]
		internal void CDKPGFOIECI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0")]
		internal GJFFIMHAENI HCCOCFBPPJF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class KBAMJHEGJJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public KHOCGPMBJLE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public KBAMJHEGJJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x68A0700", Offset = "0x689ED00", VA = "0x1868A0700")]
		internal DIJEFABKBHL KPMOJBLFEEC(int lod)
		{
			return default(DIJEFABKBHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class HGJGPCLIEFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public List<EFOPDINOAPF> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public HGJGPCLIEFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6892FC0", Offset = "0x68915C0", VA = "0x186892FC0")]
		internal void DBEHKJAPEON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class HBANNJPDBBF : IEnumerator<FEEHCBLGINO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private FEEHCBLGINO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public JIADPNPDEID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public List<NNGGNJNHKHB> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public List<EFOPDINOAPF> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public Func<int, DIJEFABKBHL> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public HDLACHNIOHL materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private FEEHCBLGINO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x871800", Offset = "0x86FE00", VA = "0x180871800")]
		[DebuggerHidden]
		public HBANNJPDBBF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6892D60", Offset = "0x6891360", VA = "0x186892D60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6892F70", Offset = "0x6891570", VA = "0x186892F70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class FJPBDGHFDJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public JIADPNPDEID <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public FJPBDGHFDJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6892D10", Offset = "0x6891310", VA = "0x186892D10")]
		internal GJFFIMHAENI CJHLOLJODNL(NNGGNJNHKHB p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class NGOKKCFLOOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public KMDKGGBBLAI cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public NGOKKCFLOOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8BEBE0", Offset = "0x8BD1E0", VA = "0x1808BEBE0")]
		internal void KNKGECEDDIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA6A000", Offset = "0xA68600", VA = "0x180A6A000")]
		internal void ADHICDHFBPF(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class BJJMAIFKMLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public JIADPNPDEID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public BJJMAIFKMLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class MDJJFECDPCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public ADGLHGMPEFE defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public DNHIHLNODBH defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public BJJMAIFKMLM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public MDJJFECDPCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x68A0A00", Offset = "0x689F000", VA = "0x1868A0A00")]
		internal void LEDHCOONFHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA65590", Offset = "0xA63B90", VA = "0x180A65590")]
		internal void CHFPCPGBHAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class OEMFFAPCNIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public FGILHNLFPBP legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public CGGGONAKNHE legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public BJJMAIFKMLM CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public OEMFFAPCNIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x68A2E70", Offset = "0x68A1470", VA = "0x1868A2E70")]
		internal void EOJDEDCFKPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA6A600", Offset = "0xA68C00", VA = "0x180A6A600")]
		internal void AMPKHOEILFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class BEJAKBMNGHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public KMDKGGBBLAI cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public NEMMBNHIEHO avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public JIADPNPDEID <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public BEJAKBMNGHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x688ED10", Offset = "0x688D310", VA = "0x18688ED10")]
		internal GJFFIMHAENI BCADGEMMMKM(DGAGGBOGGCB item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x688F0C0", Offset = "0x688D6C0", VA = "0x18688F0C0")]
		internal void EEPDCLKHPOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class KHAACCFDHNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public FNMJFLPICID<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public KHAACCFDHNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x68A07C0", Offset = "0x689EDC0", VA = "0x1868A07C0")]
		internal void HABIGIKJKEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class NMACMICDIJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public JNJJMPPHJEI overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public NMACMICDIJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x68A2DC0", Offset = "0x68A13C0", VA = "0x1868A2DC0")]
		internal bool DLIDDCDPMCP(KeyValuePair<string, NEMMBNHIEHO> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private AvatarConfiguration PLHINAANJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Transform BBKICBJBBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private AssetReference PKNMKLNHAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private GameObject DKGFFFOFBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private GameObject CHKDEECOOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private SkinnedMeshRenderer JLHJIKMFBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private AvatarSkinnedMeshBoneOrderRemapsData HCIGJKFKLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Transform[] MDKABLPOPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Matrix4x4[] OCDKHDJANHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Material OMAFFGJMLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Material KJMFKPEMKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Material CHCKPMBOFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Shader FADHCEKPPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Shader BIKKEKEAMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Animator PMFEOANDFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Renderer[] DAEMCILDEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private MCHDNMDHAEL.INMFOKLKEDE ACJOJGGHFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private AvatarBodyPartShapesManager PLOELAFJOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyDictionary<string, Transform> JDOOLCIODHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private AvatarFaceShapeData.ODBMNMCANNB JOBCJFHBPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private AvatarBodyShapeData.DIBDBGPFPIG MFBFKJDEBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool LOBDPCHKOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool PEHGNBAEMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Color OOEDPKDIFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Color BCILNMMMKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Color MIKLILOFCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Color? NHJKDOEHMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Color? IEBBBFHAMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Color? FLHHFKNLDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Color? ECAAGEIBOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Texture2D PAKHJBOEGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Texture2D ECPAINDNEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[CanBeNull]
	private NEMMBNHIEHO EPPOHIOAMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Texture ABLMFFGEEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Color FINJNPEICFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Dictionary<Renderer, HDLACHNIOHL> JEDPCJHBLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<Renderer, HDLACHNIOHL> PEKBLKMCOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Dictionary<string, List<HMHBLBHODOD>> NCKFOGPLLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Dictionary<string, List<HMHBLBHODOD>> MBDPGGHJHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly List<CDLFAMOJMBM> DGEEJENDDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly List<CDLFAMOJMBM> CEBDBLLIMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly List<CDLFAMOJMBM> LGDKMEOGLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly List<CDLFAMOJMBM> PIINIKPEICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Dictionary<HMHBLBHODOD, Material> GMDGDLALDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Dictionary<HMHBLBHODOD, Material> ADBCCLEIGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private SkinnedMeshRenderer[] DJJBDKEBPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private SkinnedMeshRenderer[] IOAGNHGLLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private SkinnedMeshRenderer[] FPMNJBEKJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private SkinnedMeshRenderer[] IHEFLKPBGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly Dictionary<string, FNMJFLPICID<Texture2D>> MOFFDEHNBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly Dictionary<string, FNMJFLPICID<Texture2D>> GGGBIFCHKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private FitMeshHemisphere CKAPAEBIKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private bool IKFJLKOLKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private CMMPCECIIBE HMOGOKCBKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private bool CMJOCHBEMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private AnchorParamsRestrictions AIMEKPAFCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private bool NKFEGKFOMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Transform APEOIFOPPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Transform PDCCKBELCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool NDMLDGLEAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool EOLIKGBOBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Vector3 MOKILCDBCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private Quaternion IHPJNPCCIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private Vector2 FFCPMBCNCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private FitMeshHemisphere BEMHLBFIIEL;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Material KPOCDNHIAFO;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Material HLCPJMCLNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Dictionary<string, NEMMBNHIEHO> KLHHELBBAGE;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int EGINAEIKLPO;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int IANHHANNCOK;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int POAMHPLFIKB;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int OODNJHMJHCL;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int PMLIMCCCGDH;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int POFBCCPCCIP;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int ONJIFBAIAMK;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int PBCMNCJLPOB;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int AKDHPJEDIKK;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int GEDNJBCNOHG;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int FENKCHJBAKM;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int GPPMFCHJDJH;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int HJLONKFILEJ;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int KKEDJKDBECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly AOBPFOPEJNG OMNHNADMLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly AOBPFOPEJNG BLJKNNKAAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool ONBNDPMLHEH;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static Lazy<DJHGNOAECFN> ACFJDGJKNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private Lazy<BJDFPKLNAPL> DNHBHFCGFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private Lazy<BFIDGDINLAE> DKHMGDEEHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private NMMBPCBEFII NBOJFNFHFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private FOFNLEKOGHD HHPHHOGCHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private List<Action> EINIHCMHNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private MDBAMHHHLND LIONDNPMLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private SkinnedMeshRenderer[] ELJANKDLDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private int NAMLAAFDIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private bool NIBLPGNNHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private int LIOELDFBLBL;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool LINHIADPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6898FB0", Offset = "0x68975B0", VA = "0x186898FB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6894160", Offset = "0x6892760", VA = "0x186894160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool HJGICKBCNPD
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x68934E0", Offset = "0x6891AE0", VA = "0x1868934E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material CMCILFBJMLB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x689A220", Offset = "0x6898820", VA = "0x18689A220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Material GKENIILPNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6895B00", Offset = "0x6894100", VA = "0x186895B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private bool OPNIJPDNPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public PGDJCFPPLAG MIPKHMPPJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8F3C30", Offset = "0x8F2230", VA = "0x1808F3C30", Slot = "21")]
		get
		{
			return default(PGDJCFPPLAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool HCLFBODFIIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6895E60", Offset = "0x6894460", VA = "0x186895E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private static DJHGNOAECFN MFOJJDGIPAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6898AD0", Offset = "0x68970D0", VA = "0x186898AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private BJDFPKLNAPL DGDKFABDFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x689C860", Offset = "0x689AE60", VA = "0x18689C860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private BFIDGDINLAE GFHHNJMBDCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6898800", Offset = "0x6896E00", VA = "0x186898800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private NMMBPCBEFII ICHJIAGMLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6896D10", Offset = "0x6895310", VA = "0x186896D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private FOFNLEKOGHD GDGJBPFNIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6893B60", Offset = "0x6892160", VA = "0x186893B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public AOBPFOPEJNG DNEOENFCDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA631A0", Offset = "0xA617A0", VA = "0x180A631A0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public AOBPFOPEJNG MBCHOFMLIPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x142C2B0", Offset = "0x142A8B0", VA = "0x18142C2B0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public SkinnedMeshRenderer[] KCGCHBALOFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1320EF0", Offset = "0x131F4F0", VA = "0x181320EF0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public Renderer[] GOBGGAKJLNC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x86C840", Offset = "0x86AE40", VA = "0x18086C840", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool HMCLKKAIIGG
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6893700", Offset = "0x6891D00", VA = "0x186893700", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public MCHDNMDHAEL.INMFOKLKEDE FLIHPOBFKFM
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x86C890", Offset = "0x86AE90", VA = "0x18086C890", Slot = "18")]
		get
		{
			return default(MCHDNMDHAEL.INMFOKLKEDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int JJJEGGBJBCC
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6896FA0", Offset = "0x68955A0", VA = "0x186896FA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6893FD0", Offset = "0x68925D0", VA = "0x186893FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool BKILPNDIPLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6896FB0", Offset = "0x68955B0", VA = "0x186896FB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private static bool KFJGDKGABIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6899A00", Offset = "0x6898000", VA = "0x186899A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool EGAMPNMCNML
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6899EB0", Offset = "0x68984B0", VA = "0x186899EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x689FDE0", Offset = "0x689E3E0", VA = "0x18689FDE0")]
	public JIADPNPDEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x689F4B0", Offset = "0x689DAB0", VA = "0x18689F4B0", Slot = "26")]
	public void PNLKNBIHCGI(JMJADIBIOKB BJKJMBNPCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x68998B0", Offset = "0x6897EB0", VA = "0x1868998B0", Slot = "27")]
	public void NAPKFKKJOCC(FKEGMDJCMPK ADJHEAHLJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6893FD0", Offset = "0x68925D0", VA = "0x186893FD0", Slot = "4")]
	public void APJDOKEIAJC(int HEPMKAJPNDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6895420", Offset = "0x6893A20", VA = "0x186895420", Slot = "9")]
	public void ECFBFMCPLGP(CCOGLGACCMN HFBFALFGKKM, Texture2D CNANONHDMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6893F50", Offset = "0x6892550", VA = "0x186893F50", Slot = "10")]
	public void APEPDNIPABD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x68934F0", Offset = "0x6891AF0", VA = "0x1868934F0", Slot = "11")]
	public bool ACGKJHJMOAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6895630", Offset = "0x6893C30", VA = "0x186895630", Slot = "8")]
	public void EDEPFMCBKDH(AGHHJBLOHMO NCDMIAFLOJB, Color? PHHAMGLLFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6896D90", Offset = "0x6895390", VA = "0x186896D90")]
	private void HGPJEBEOEIL(Action KEIHPPBADHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x689C6E0", Offset = "0x689ACE0", VA = "0x18689C6E0", Slot = "5")]
	public void PBABJEDODNJ(NEMMBNHIEHO POACKHCBGIO, Texture AKIJFMGHEHI, Color NJCIKCDDNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6894160", Offset = "0x6892760", VA = "0x186894160", Slot = "6")]
	public void NLHNGKIPEBC(bool CKIOGMEFMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1314810", Offset = "0x1312E10", VA = "0x181314810", Slot = "7")]
	public void MNAOBDNFILF(MDBAMHHHLND FPAICILAIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x689B0C0", Offset = "0x68996C0", VA = "0x18689B0C0", Slot = "14")]
	public EFOPDINOAPF OPCPHEIACPL(FKBGKKEOADF DDLJPCIPGAH, bool NAGOLGHBJCB, int[] BNHEHEELICL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6899590", Offset = "0x6897B90", VA = "0x186899590", Slot = "15")]
	public void MBDDKAFGCJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6898170", Offset = "0x6896770", VA = "0x186898170")]
	private bool JMPJJLEFNLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x86C7F0", Offset = "0x86ADF0", VA = "0x18086C7F0", Slot = "19")]
	public void PNPBKCGKBPP(MCHDNMDHAEL.INMFOKLKEDE JHEJCJCODOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x689A0D0", Offset = "0x68986D0", VA = "0x18689A0D0")]
	private bool NKNHJFCDIDL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x689C8B0", Offset = "0x689AEB0", VA = "0x18689C8B0")]
	private EFOPDINOAPF PJFOJDMAPIH(bool NAGOLGHBJCB, List<NNGGNJNHKHB> BMCCPJPDPKH, int[] BNHEHEELICL, Func<int, DIJEFABKBHL> GGBMDCEOMOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x689C750", Offset = "0x689AD50", VA = "0x18689C750")]
	[IteratorStateMachine(typeof(HBANNJPDBBF))]
	private IEnumerator<FEEHCBLGINO> PCNLDFDCNNL(bool NAGOLGHBJCB, List<NNGGNJNHKHB> BMCCPJPDPKH, int[] BNHEHEELICL, Func<int, DIJEFABKBHL> GGBMDCEOMOJ, HDLACHNIOHL OGCPFNAPOPP, Material NJILJHGPBEI, List<EFOPDINOAPF> GOLDLBIHNGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6899020", Offset = "0x6897620", VA = "0x186899020")]
	private EFOPDINOAPF LGBEADMKGCM(List<NNGGNJNHKHB> BMCCPJPDPKH, int[] BNHEHEELICL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x689CE90", Offset = "0x689B490", VA = "0x18689CE90")]
	private EKNCDBKDOPI PKAOCEMFFPF(List<NNGGNJNHKHB> BMCCPJPDPKH, int HEPMKAJPNDG, bool NAGOLGHBJCB, DIJEFABKBHL ABCPPKFGKJO, bool GMGPCAAEFKN, HDLACHNIOHL OGCPFNAPOPP, Material NJILJHGPBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6898950", Offset = "0x6896F50", VA = "0x186898950", Slot = "22")]
	public void KBGDGIAOHKL(AvatarFaceShape LJMKCCDNJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6898A10", Offset = "0x6897010", VA = "0x186898A10", Slot = "23")]
	public void KDDJMIJIBDI(AvatarBodyShape PACKPMDNMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6897510", Offset = "0x6895B10", VA = "0x186897510", Slot = "25")]
	public void IGDEMOAKKOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6897A60", Offset = "0x6896060", VA = "0x186897A60", Slot = "24")]
	public void JBGAHOAAPAH(bool GKLNIMALOGF, bool BGFJJGCHBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6894760", Offset = "0x6892D60", VA = "0x186894760")]
	private void CEDHIEFNELA(SkinnedMeshRenderer HHLIPFEIBCE, int HEPMKAJPNDG, Mesh CKFPIMAMAKM, List<Material> DCMOHGPMDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6897900", Offset = "0x6895F00", VA = "0x186897900")]
	private static Material IMNKIFCOAKO(Dictionary<HMHBLBHODOD, Material> NDIECEFKOCF, Material NDPJCFHOOPH, BDKODIGLHLM MMFKDODCHJN, KADINOMKCPE IAGCNDDHHNO, JNJJMPPHJEI ANOHNNKPBBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6896900", Offset = "0x6894F00", VA = "0x186896900")]
	private static BDKODIGLHLM GLENBKGIKJP(NNGGNJNHKHB MLILHDGFKBF, int JEBIILPPMNH)
	{
		return default(BDKODIGLHLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6894B40", Offset = "0x6893140", VA = "0x186894B40")]
	private void CPCHHLEJNNB(int IDFKCENAGJL, Material OLKLLNJBJND, NNGGNJNHKHB MLILHDGFKBF, [Out] Texture2D FCHBMBGBKBA, [Out] Vector4 ALHONLEJKCE, [Out] Texture2D JGPIJFEDKNN, [Out] Texture2D BFEHLHIMJCI, [Out] Texture2D HKBPBLEICLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6897C90", Offset = "0x6896290", VA = "0x186897C90")]
	private void JJHEAJNFFAL(int IDFKCENAGJL, Material OLKLLNJBJND, NNGGNJNHKHB MLILHDGFKBF, [Out] Color ALMIKADFEHI, [Out] Color BBIKGHMKJNE, [Out] Color MFFPKIIFIME, [Out] Color AOCDCDMMFJG, [Out] Color CKPNJJBEDHA, [Out] Color AOEJHILHEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x68951C0", Offset = "0x68937C0", VA = "0x1868951C0")]
	private bool DNNFKDNJFAA(Material OLKLLNJBJND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6895170", Offset = "0x6893770", VA = "0x186895170")]
	private static Material DKFPLBOONPK(int IDFKCENAGJL, PBNGJIOBFPF MLILHDGFKBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x689AE70", Offset = "0x6899470", VA = "0x18689AE70")]
	private static KADINOMKCPE OLLKKFPFOBH(NNGGNJNHKHB MLILHDGFKBF, int JEBIILPPMNH)
	{
		return default(KADINOMKCPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6893870", Offset = "0x6891E70", VA = "0x186893870")]
	private static void AIMAILHFJKA(Dictionary<string, List<HMHBLBHODOD>> PPJPBKONHHM, NNGGNJNHKHB OIGOEFKMEAL, Material NDPJCFHOOPH, BDKODIGLHLM NCDMIAFLOJB, KADINOMKCPE HFBFALFGKKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6899360", Offset = "0x6897960", VA = "0x186899360")]
	private static SkinnedMeshRenderer MANOLNLBNPP(Transform FKHMDHOFHGG, Transform PNEJPPIECDL, SkinnedMeshRenderer[] EAKCNEDHLLO, int HEPMKAJPNDG, DIJEFABKBHL ABCPPKFGKJO, bool NAGOLGHBJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x689F810", Offset = "0x689DE10", VA = "0x18689F810")]
	private void POIKMKMOHOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6896BA0", Offset = "0x68951A0", VA = "0x186896BA0")]
	private void HAHGIDDPLAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x689AF60", Offset = "0x6899560", VA = "0x18689AF60")]
	private static void OMAECGNGDHK(Dictionary<HMHBLBHODOD, Material> NDIECEFKOCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6896BB0", Offset = "0x68951B0", VA = "0x186896BB0")]
	private static void HDNFPKAGBAM(Dictionary<Renderer, HDLACHNIOHL> ANBANKNPEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x68948B0", Offset = "0x6892EB0", VA = "0x1868948B0")]
	private void CFFIEBMCIJN(SkinnedMeshRenderer[] EAKCNEDHLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6894F50", Offset = "0x6893550", VA = "0x186894F50")]
	private void DBBIHJFINLD(SkinnedMeshRenderer FMMBKABPPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6896720", Offset = "0x6894D20", VA = "0x186896720")]
	private void GGFODDPBAFA(List<CDLFAMOJMBM> HIFCENMPOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6894FF0", Offset = "0x68935F0", VA = "0x186894FF0")]
	private void DGMOHHEKPMC(Dictionary<string, FNMJFLPICID<Texture2D>> PPJPBKONHHM, bool JLPMMAAKGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x689AA80", Offset = "0x6899080", VA = "0x18689AA80")]
	private void OIAJGDALBFL(Dictionary<string, List<HMHBLBHODOD>> PPJPBKONHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6896260", Offset = "0x6894860", VA = "0x186896260")]
	private void FOFNEJDHIDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6897A70", Offset = "0x6896070", VA = "0x186897A70")]
	private void JBKMJBABOJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x689A530", Offset = "0x6898B30", VA = "0x18689A530")]
	private void OCNOJKNMLOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6895A30", Offset = "0x6894030", VA = "0x186895A30")]
	private void EELCJDDDMBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6895BF0", Offset = "0x68941F0", VA = "0x186895BF0")]
	private void EHHIKBDCNIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x68949D0", Offset = "0x6892FD0", VA = "0x1868949D0")]
	private void CLMFOAODKDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6896AB0", Offset = "0x68950B0", VA = "0x186896AB0")]
	private void GOGOCOMHEIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x689F9E0", Offset = "0x689DFE0", VA = "0x18689F9E0")]
	private void PPEDPDENOLA(bool NHJCLEJGPCA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6899930", Offset = "0x6897F30", VA = "0x186899930")]
	private void NBLCDHMJGLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x689F770", Offset = "0x689DD70", VA = "0x18689F770")]
	private void POGBIJBEPON(bool NHJCLEJGPCA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6893BE0", Offset = "0x68921E0", VA = "0x186893BE0")]
	private void ANDIJMIDNBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6897030", Offset = "0x6895630", VA = "0x186897030")]
	private void IEKJIHCHBOH(Material NJILJHGPBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6899BA0", Offset = "0x68981A0", VA = "0x186899BA0")]
	private void NEHCKOGGCFI(Material NJILJHGPBEI, Color KBAJPAKBJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6899D10", Offset = "0x6898310", VA = "0x186899D10")]
	private void NELFCDLAKCA(Material NJILJHGPBEI, Color EMFAACMMFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x689A3B0", Offset = "0x68989B0", VA = "0x18689A3B0")]
	private void OCHKJGPNBPB(Material NJILJHGPBEI, Color ALMIKADFEHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x68960D0", Offset = "0x68946D0", VA = "0x1868960D0")]
	private void FOFEMKFKIFN(Material NJILJHGPBEI, Texture2D CNANONHDMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6896E10", Offset = "0x6895410", VA = "0x186896E10")]
	private void HIKNNACCBJA(Material NJILJHGPBEI, Texture GPJAIBCAJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x68982B0", Offset = "0x68968B0", VA = "0x1868982B0")]
	private void JNJHKKFNMMB(Action<HDLACHNIOHL> ANEGNLAAIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6895CB0", Offset = "0x68942B0", VA = "0x186895CB0")]
	private void EOBMPBHPKPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x68963C0", Offset = "0x68949C0", VA = "0x1868963C0")]
	private void GGCEHCOGJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6894170", Offset = "0x6892770", VA = "0x186894170")]
	private EFOPDINOAPF CBHOKFIHKGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6898BE0", Offset = "0x68971E0", VA = "0x186898BE0")]
	private void LBHDLPOPOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6898470", Offset = "0x6896A70", VA = "0x186898470")]
	public void JNMAPMOHPBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6898850", Offset = "0x6896E50", VA = "0x186898850")]
	private void JOLBHDLMLNM(Vector3 GJMAELHLBKD, Quaternion FODPGOBPIEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x689AAD0", Offset = "0x68990D0", VA = "0x18689AAD0")]
	private void OKHHOPOGEFA(List<NNGGNJNHKHB> DALPPLPHOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x689EFB0", Offset = "0x689D5B0", VA = "0x18689EFB0")]
	public void PNFNFOLLIPE(CMMPCECIIBE PEDMCNBLFEL, bool CAEPGPAMLME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x689E930", Offset = "0x689CF30", VA = "0x18689E930")]
	public void PNFNFOLLIPE(CMMPCECIIBE PEDMCNBLFEL, AnchorParamsRestrictions HFBCMJDHLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xA50560", Offset = "0xA4EB60", VA = "0x180A50560")]
	private static void HDMMGLKDFGO(FitMeshHemisphere FNGGBMLGENK, Transform NHIMFAKIFDF, CMMPCECIIBE PEDMCNBLFEL, AnchorParamsRestrictions NMAIEPAPPEN, [Out] Vector3 DJCNMBEIKME, [Out] Quaternion CAANIPGJBEP, [Out] CMMPCECIIBE MCILNKPFEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6897740", Offset = "0x6895D40", VA = "0x186897740")]
	public void IMBDEKHBIIL(Vector2 IHGJLPPONAO, Vector3 HHAAIEGMJEP, Vector3 CJPIMOOHIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6893FF0", Offset = "0x68925F0", VA = "0x186893FF0")]
	private void BACFLPIOPLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6896A20", Offset = "0x6895020", VA = "0x186896A20")]
	private void GLGKMBEFDBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6896040", Offset = "0x6894640", VA = "0x186896040")]
	[CompilerGenerated]
	private void FNLHHPPOLBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6896F70", Offset = "0x6895570", VA = "0x186896F70")]
	[CompilerGenerated]
	private void HJBMJFBMEDE(HDLACHNIOHL POLHBDKKHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6899790", Offset = "0x6897D90", VA = "0x186899790")]
	[CompilerGenerated]
	private void MGOJGJJPNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6896B80", Offset = "0x6895180", VA = "0x186896B80")]
	[CompilerGenerated]
	private void GPPEDIBCHCP(HDLACHNIOHL POLHBDKKHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6899820", Offset = "0x6897E20", VA = "0x186899820")]
	[CompilerGenerated]
	private void MNADDJNGIBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6894B20", Offset = "0x6893120", VA = "0x186894B20")]
	[CompilerGenerated]
	private void CNADANFFKPC(HDLACHNIOHL POLHBDKKHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6893670", Offset = "0x6891C70", VA = "0x186893670")]
	[CompilerGenerated]
	private void ADDLNEPDAAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6895C80", Offset = "0x6894280", VA = "0x186895C80")]
	[CompilerGenerated]
	private void EMCBNKBFFKL(HDLACHNIOHL POLHBDKKHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6897C00", Offset = "0x6896200", VA = "0x186897C00")]
	[CompilerGenerated]
	private void JFEIIDCLEAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6898FF0", Offset = "0x68975F0", VA = "0x186898FF0")]
	[CompilerGenerated]
	private void LEGCEHDBFDC(HDLACHNIOHL POLHBDKKHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6895FB0", Offset = "0x68945B0", VA = "0x186895FB0")]
	[CompilerGenerated]
	private void FNENAKOJIJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6899E80", Offset = "0x6898480", VA = "0x186899E80")]
	[CompilerGenerated]
	private void NJKHPDAMHNC(HDLACHNIOHL POLHBDKKHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x68988C0", Offset = "0x6896EC0", VA = "0x1868988C0")]
	[CompilerGenerated]
	private void JPEHDFEBMCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6895E30", Offset = "0x6894430", VA = "0x186895E30")]
	[CompilerGenerated]
	private void FACPKCDMGPN(HDLACHNIOHL POLHBDKKHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x68992E0", Offset = "0x68978E0", VA = "0x1868992E0")]
	[CompilerGenerated]
	private void LLBLGPDMAOL(KeyValuePair<string, FNMJFLPICID<Texture2D>> ILNELDEEBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x689A190", Offset = "0x6898790", VA = "0x18689A190")]
	[CompilerGenerated]
	private void NMAFACENMLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6898FC0", Offset = "0x68975C0", VA = "0x186898FC0")]
	[CompilerGenerated]
	private void LCDIMJNPOBM(HDLACHNIOHL POLHBDKKHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6898B50", Offset = "0x6897150", VA = "0x186898B50")]
	[CompilerGenerated]
	private void KGGMOBJEFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6893F20", Offset = "0x6892520", VA = "0x186893F20")]
	[CompilerGenerated]
	private void APEJFAADADK(HDLACHNIOHL POLHBDKKHAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class CKCAKCNBJPH : JHJJPNCIKAD
{
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int KDPOLOGKGGD;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int BJCLKFKOEKM;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly int DPIDBBBOIBI;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly int KCFEMGCBFPP;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly int DJGLIOLBMBP;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly int JHHDFGGDNGK;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static readonly int FKGLDFNAPKL;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly int PLDHCFPLECL;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static readonly int IFHJJNBHAIN;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly int EGOCOEFGFNM;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly int IIBLCPCGPPP;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly int BIHFPODHJEG;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly int AGLDFIGINJF;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly int OCOPLPDDKNM;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly int PHFCHBCEGBO;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly int AJJDNIHBMBE;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly int OMHFPDGCPFJ;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly int FGHEHDGKBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private Transform PCMPPEMLAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private Transform GPKPOFBIKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private Transform OOFGPNMLBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private Transform HHKODBOBELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private Transform ICGKEBKEAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private Transform LCPEFIBJOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private Transform BMHCEHMODLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private CFFIACCNFJP IPDJBJCIMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private MaterialPropertyBlock FPEAPOFCCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private SkinnedMeshRenderer[] OGDBDEJAKFO;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private MaterialPropertyBlock DABIFJIOIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x688F190", Offset = "0x688D790", VA = "0x18688F190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool BGBBMOLNFII
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6890820", Offset = "0x688EE20", VA = "0x186890820", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6890DD0", Offset = "0x688F3D0", VA = "0x186890DD0", Slot = "7")]
	public void PNLKNBIHCGI(CFFIACCNFJP MJIGPJMJDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x688F100", Offset = "0x688D700", VA = "0x18688F100", Slot = "8")]
	public void CPHGJFPOGPO(FFNFPGAJGIC BEAHJPGOGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x68903F0", Offset = "0x688E9F0", VA = "0x1868903F0", Slot = "5")]
	public void HAAMAEEBIEH(GJJFJKENHOH HPIAPBEKDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x688F130", Offset = "0x688D730", VA = "0x18688F130")]
	private Vector2 DHJFIILONKN(Vector2 NHCIKJLCPBO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x688F2E0", Offset = "0x688D8E0", VA = "0x18688F2E0", Slot = "6")]
	public void GLCOJBFGCGD(LDEGDJGLODL BEAHJPGOGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x68909A0", Offset = "0x688EFA0", VA = "0x1868909A0")]
	private void LGBNGCEOCCD(LDEGDJGLODL BMKKMHDEDPM, GKABBMCDNMG HFEPICMPHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6890CF0", Offset = "0x688F2F0", VA = "0x186890CF0")]
	private void NHGCLHAKAAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x68911C0", Offset = "0x688F7C0", VA = "0x1868911C0")]
	public CKCAKCNBJPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x688F210", Offset = "0x688D810", VA = "0x18688F210")]
	[CompilerGenerated]
	internal static (float, float) EAGPLGKNCIO(float CDAEBDIOOFA)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x688F2A0", Offset = "0x688D8A0", VA = "0x18688F2A0")]
	[CompilerGenerated]
	internal static Vector4 FKDEMFIBONG(Vector2 MCPNOOFMAHG, Vector2 ICLEOPHCOMM)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class HDLACHNIOHL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private MaterialPropertyBlock OIDLCFPBNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public Color? ODNFIKLDBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public Color? KELBKPDPGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public Color? IJCBNBOPCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public Color? FHJOANHLLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public Color BGCDJPAIGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public Color LHGNLDCFIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public Color KAFCIINHKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public Texture2D DHAAIOHLPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public Texture2D AGJFOLHMOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private Dictionary<HMHBLBHODOD, int> BMHCDJEMBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private BDKODIGLHLM[] DGILLOFBBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private KADINOMKCPE[] KCPFFCAEKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public Vector4[] DDMJAMBJLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public Vector4[] NOKHNCFFHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public Vector4[] NAOGBDFOGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public Vector4[] EFFFBICDCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public Vector4[] LDNGPKMEAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public Vector4[] PCKCAPLHDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private List<Texture2D> PLJAKODDHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private Vector4[] GDBJIEPFMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private List<Texture2D> EPBFMCKBFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private float[] GALHKCIAJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private Vector4[] NDDGCGJDIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private float[] PIJGBLBKBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public float[] JBMAGAFOIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private List<Texture2D> EMLHLGMOLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private float[] PAAOBBMDDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private List<Texture2D> IADKHKGMNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private Vector4[] MGOLFDIAOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private float[] HPFAPMLHMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private Vector4[] GNJBFICFAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public float[] GOKKELLFDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	public Texture2DArray GIKOIDBAGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public Texture2DArray JDCJLKILPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public Texture2DArray GJGJDHIEAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public Texture2DArray LMNNCKCFLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private bool BHNKBFGJGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private int DBDJJKFJOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private Vector2? IMAPGIHCPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private TextureFormat DJDOMGNGJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private Vector2? JHJGDKCAOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private TextureFormat CKIDLFMJGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private Vector2? HPCDNMNOCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private TextureFormat MDEEIDIABNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private Vector2? EAFMPIJBJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private TextureFormat FOLIIHLNHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private bool LFHFPMACPBD;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static int EKOHLNHGLKK;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static int PFLCAPKOFIP;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private static int JNNNKFNAHFB;

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static int BEODGLAPLNC;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static int KOHBGABHOKG;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static int ICBFNNNCOBD;

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private static int MBDJKLCEALM;

	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private static int OOCIKKOEEGC;

	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static int OPLGEBNGEHK;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static int NDCKEBEPMPA;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static int JFKIMBHKLCN;

	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private static int IMOLJIFPGBI;

	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private static int COGDCHOIBGJ;

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private static int CGLFPFFIBCB;

	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private static int ADLPPDFKDHF;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private static int HIGFIHAFNJM;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private static int FKOGABAIFFB;

	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private static int ANFDEGABJFJ;

	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private static int ENEKKDPIJJB;

	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private static int PJEBPGDCCPC;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x68AD6A0", Offset = "0x68ABCA0", VA = "0x1868AD6A0")]
	private HDLACHNIOHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x68ADB90", Offset = "0x68AC190", VA = "0x1868ADB90")]
	public HDLACHNIOHL(Color NDNOECEPCNA, Color FGHJHADCAHA, Color FGPBMEPMMCM, Color? LHCNLPCJAPM, Color? MBNENKNLEMA, Color? OPKHCPDKAJF, Texture2D IMNMDGOKCAA, Texture2D BLHPFCNKKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x68AC030", Offset = "0x68AA630", VA = "0x1868AC030")]
	internal int ICJJJJFLHMH(Material FGLLPDMPMEP, BDKODIGLHLM MMFKDODCHJN, KADINOMKCPE IAGCNDDHHNO, JNJJMPPHJEI ANOHNNKPBBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x68ABFA0", Offset = "0x68AA5A0", VA = "0x1868ABFA0")]
	private int ICJJJJFLHMH(HMHBLBHODOD IBBDLGCDELM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x68AB020", Offset = "0x68A9620", VA = "0x1868AB020")]
	internal int AFIOIOHNEKB(Material FGLLPDMPMEP, Color ALMIKADFEHI, Color BBIKGHMKJNE, Color MFFPKIIFIME, Color AOCDCDMMFJG, Color CKPNJJBEDHA, Texture2D MGELJHEKDOE, Vector4 KIINMPGNMHA, Texture2D OMJPEEDNCEC, Vector4 OABHAILGDPN, float AGFBPPFMMHE, float FHINMHMINOC, Texture2D ALBPJMAGOPG, Vector4 EPMAGFACCLK, float LFHJGHLJJOB, Texture2D CJBPCBOOICF, Color AOEJHILHEOI, Vector4 HAFPDDCANBJ, BDKODIGLHLM MMFKDODCHJN, KADINOMKCPE IAGCNDDHHNO, JNJJMPPHJEI ANOHNNKPBBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x68ABBF0", Offset = "0x68AA1F0", VA = "0x1868ABBF0")]
	private void AKOHCCPNFBJ(List<Texture2D> PLJAKODDHLG, [Out] Texture2DArray OCLAOOFOMID, [Out] Texture2DArray OFKHHMEKMAB, [Out] Texture2DArray MINJNBIHBNM, [Out] Texture2DArray GFPMFGPPBEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x68ACE70", Offset = "0x68AB470", VA = "0x1868ACE70")]
	public void OHCJBOILJKL(Shader CMJMLCHAHPD, Renderer PGOGAFFEFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x68AC120", Offset = "0x68AA720", VA = "0x1868AC120")]
	private void NJOCNALOCBA(Shader CMJMLCHAHPD, Renderer PGOGAFFEFPG, int EFPIHFCJIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x68ACFC0", Offset = "0x68AB5C0", VA = "0x1868ACFC0")]
	private Color PFIECHLOIML(Color JBDMFPJLCCL, BDKODIGLHLM NCDMIAFLOJB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x68AD1C0", Offset = "0x68AB7C0", VA = "0x1868AD1C0")]
	private Color PLCGOKBILPJ(Color GFNJCPNBOLD, BDKODIGLHLM NCDMIAFLOJB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x68ABDB0", Offset = "0x68AA3B0", VA = "0x1868ABDB0")]
	private bool DEHPOAIPPGE(Texture2D PMGJMAIHFOM, KADINOMKCPE HFBFALFGKKM, [Out] Texture2D NIMPHLCFLCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x68ABEF0", Offset = "0x68AA4F0", VA = "0x1868ABEF0")]
	private void EHLEABBKMIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x68ABEB0", Offset = "0x68AA4B0", VA = "0x1868ABEB0", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[Obsolete("Use CombinationId instead!")]
		[SerializeField]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private FPLOGOPHJCG? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public NAJCLKBNHFG CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x68A51A0", Offset = "0x68A37A0", VA = "0x1868A51A0")]
			get
			{
				return default(NAJCLKBNHFG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public FPLOGOPHJCG MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x68A51F0", Offset = "0x68A37F0", VA = "0x1868A51F0")]
			get
			{
				return default(FPLOGOPHJCG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x86FA50", Offset = "0x86E050", VA = "0x18086FA50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x86C8D0", Offset = "0x86AED0", VA = "0x18086C8D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x68A4E20", Offset = "0x68A3420", VA = "0x1868A4E20")]
		public Material[] JFMEAFEBNJC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x68A4F10", Offset = "0x68A3510", VA = "0x1868A4F10")]
		public static void JHHEFFKBJPG(AvatarItemMaterial MEJAAJAIPJB, Material OLKLLNJBJND, int IDFKCENAGJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x68A50D0", Offset = "0x68A36D0", VA = "0x1868A50D0")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[OBKEFOLKLJN]
public struct ELEKPLBLJLB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	[ReadOnly]
	public CGGGONAKNHE JEGMBFLIMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	[ReadOnly]
	public int FFKOANCNBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public FGILHNLFPBP PFODDJJJLFC;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x68A8430", Offset = "0x68A6A30", VA = "0x1868A8430", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[OBKEFOLKLJN]
[NativeContainer]
public struct FGILHNLFPBP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NativeArray<Vector3> AGOKMFNHMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public NativeArray<Vector3> GLFJMEKNHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeArray<Vector4> BICNKLEFNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public NativeArray<Vector2> JGNFEDEALCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<Vector2> JIDOFMCGOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeArray<Vector2> KLPGFCJEAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeArray<Vector2> HBDJEIHHBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public NativeArray<Color> EEJDMDOMDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public NativeArray<int> EDHINNGADDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public NativeArray<int> IDGFFEPELNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private NativeArray<int> GGLPIPFABPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private NativeArray<int> FBCPGHJOOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<int> FGBKGACNLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public NativeArray<int> NIMCHBMKFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<int> OCDILKMNPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public NativeArray<BoneWeight> OKLPFANLPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private NativeArray<int> FPAICILAIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private bool ECPGDMBEKKG;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int LEHJJPECCMN
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x68A9D80", Offset = "0x68A8380", VA = "0x1868A9D80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x68A9580", Offset = "0x68A7B80", VA = "0x1868A9580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int LHFAMOIFAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x68A9D70", Offset = "0x68A8370", VA = "0x1868A9D70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x68A9590", Offset = "0x68A7B90", VA = "0x1868A9590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int IKFNKJFHIID
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x68A9A10", Offset = "0x68A8010", VA = "0x1868A9A10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x68A95A0", Offset = "0x68A7BA0", VA = "0x1868A95A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x68A9D90", Offset = "0x68A8390", VA = "0x1868A9D90")]
	public FGILHNLFPBP(int EIKOHLMEALF, int CMOJBMNAPOM, int BAKEFDDNOAI, int DABNCBFOFEA, Allocator KOIILCBLJPK, int MFDMCGEIMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x68A97E0", Offset = "0x68A7DE0", VA = "0x1868A97E0")]
	public void JLIKOCHJIGN(int PDMMEDBMFPP, Vector3 HAHPKMHGFDD, Vector3 NOOFNNECEBO, Vector4 FCNFHCDDANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x68A95B0", Offset = "0x68A7BB0", VA = "0x1868A95B0")]
	public void HDHBHBBJDBA(int PDMMEDBMFPP, BoneWeight NKJBLBMGPCC, NativeSlice<byte> LOOMBJNKMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x68A9340", Offset = "0x68A7940", VA = "0x1868A9340")]
	public Color ACCLLILKDOF(int PDMMEDBMFPP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x68A93B0", Offset = "0x68A79B0", VA = "0x1868A93B0")]
	public void BPBPPFNAKPL(int PDMMEDBMFPP, Color NAHNDCNFAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x68A9360", Offset = "0x68A7960", VA = "0x1868A9360")]
	public void BKCJKMEEACK(byte LBDJIGNPONF, int PDMMEDBMFPP, Vector2 CHJJADPOMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x68A99D0", Offset = "0x68A7FD0", VA = "0x1868A99D0")]
	public void LGHNMHENHME(int PDMMEDBMFPP, int GHMMLEKOEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x68A99E0", Offset = "0x68A7FE0", VA = "0x1868A99E0")]
	public bool LLLHNGMNMPC(int LBDJIGNPONF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x68A9900", Offset = "0x68A7F00", VA = "0x1868A9900")]
	public void KPIFLOKOPKK(int DAIPCKHIIAP, int GCMGLJCEDLO, int JOCLJBACIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x68A9850", Offset = "0x68A7E50", VA = "0x1868A9850")]
	public int[] KECLFGHJFKP(int DAIPCKHIIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x68A9750", Offset = "0x68A7D50", VA = "0x1868A9750")]
	private NativeSlice<int> IDDACJOPOBE(int DAIPCKHIIAP)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x68A93D0", Offset = "0x68A79D0", VA = "0x1868A93D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x68A9A20", Offset = "0x68A8020", VA = "0x1868A9A20")]
	public Mesh MFHBNNIPFCD([Optional] string HJAOMJEIKIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[OBKEFOLKLJN]
[NativeContainer]
[DefaultMember("Item")]
public struct CGGGONAKNHE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeArray<Vector3> AGOKMFNHMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<Vector3> GLFJMEKNHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<Vector4> BICNKLEFNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<Vector2> JGNFEDEALCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<Vector2> JIDOFMCGOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<Vector2> KLPGFCJEAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<Vector2> HBDJEIHHBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<Color> EEJDMDOMDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<int> GMMHFCBAAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public NativeArray<int> CKLFPNJHMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeArray<int> CBGFCCLMAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public NativeArray<int> IKAOEENMCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public NativeArray<bool> FLHCIBEFFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<int> KDDNECEJJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<int> MICEEJHJJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<BoneWeight> DHLKOFKEEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private NativeArray<Matrix4x4> NOJDGBMLBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private NativeArray<int> AKBHPGIMMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private NativeArray<byte> FCJCFCIFEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private NativeArray<int> LDJELKPBFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private NativeArray<int> EJDADHFIAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<sbyte> KJOCKNABEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeArray<byte> NENJBOCNOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private NativeArray<int> KDDFKDCJLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private bool ECPGDMBEKKG;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int FDJKPOJEDOF
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int KPEGOMLMKMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x104D2B0", Offset = "0x104B8B0", VA = "0x18104D2B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int CGGGDMGGJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x68A5B00", Offset = "0x68A4100", VA = "0x1868A5B00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int MKOCOOKHKPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x68A5A10", Offset = "0x68A4010", VA = "0x1868A5A10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x68A5B30", Offset = "0x68A4130", VA = "0x1868A5B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int LEHJJPECCMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x68A6060", Offset = "0x68A4660", VA = "0x1868A6060")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x68A5A00", Offset = "0x68A4000", VA = "0x1868A5A00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int GMCHKALJBBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x68A5780", Offset = "0x68A3D80", VA = "0x1868A5780")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x68A5760", Offset = "0x68A3D60", VA = "0x1868A5760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public KIOBLMMIJDE LKEKCGLJIIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x68A5AF0", Offset = "0x68A40F0", VA = "0x1868A5AF0")]
		get
		{
			return default(KIOBLMMIJDE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x68A5750", Offset = "0x68A3D50", VA = "0x1868A5750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public byte NBDGHIFPNAE
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x68A5770", Offset = "0x68A3D70", VA = "0x1868A5770")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x68A59F0", Offset = "0x68A3FF0", VA = "0x1868A59F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public GOFMBLEDBDI CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x68A5B40", Offset = "0x68A4140", VA = "0x1868A5B40")]
		get
		{
			return default(GOFMBLEDBDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x68A6070", Offset = "0x68A4670", VA = "0x1868A6070")]
	public CGGGONAKNHE(IList<Mesh> AMCIGEOJLFJ, IList<Matrix4x4> NKHPOJDCGOL, IList<bool> FLHCIBEFFDB, byte MKECCECLDLC, IList<byte[]> MLJAKDGJAMC, IList<int> HEFBNLOOBDC, IList<bool> CIGHNEMLKKN, IList<int> KDDNECEJJCJ, IList<int> NAIKMFEKNHM, IList<int> BFKLPCJEHGJ, Allocator KOIILCBLJPK, KIOBLMMIJDE NBOPFLHBMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x68A5A20", Offset = "0x68A4020", VA = "0x1868A5A20")]
	public FGILHNLFPBP GEDHAIANLMA(Allocator KOIILCBLJPK)
	{
		return default(FGILHNLFPBP);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x68A5790", Offset = "0x68A3D90", VA = "0x1868A5790", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[OBKEFOLKLJN]
public class BNJLHADAGMK : NFFHEKBADKP
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x68A52B0", Offset = "0x68A38B0", VA = "0x1868A52B0")]
	public CGGGONAKNHE EIHNGNLMOEP()
	{
		return default(CGGGONAKNHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6892D00", Offset = "0x6891300", VA = "0x186892D00")]
	public BNJLHADAGMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct GOFMBLEDBDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeSlice<Vector3> AGOKMFNHMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeSlice<Vector3> GLFJMEKNHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeSlice<Vector4> BICNKLEFNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeSlice<Vector2> JGNFEDEALCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeSlice<Vector2> JIDOFMCGOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public NativeSlice<Vector2> KLPGFCJEAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public NativeSlice<Vector2> HBDJEIHHBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeSlice<Color> EEJDMDOMDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public NativeSlice<int> JFMFCGCFNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public NativeSlice<int> IKAOEENMCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public NativeSlice<BoneWeight> DHLKOFKEEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public NativeSlice<byte> CNALBHAMNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public int DMKEDKMAJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public Matrix4x4 HNBEHKMEBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public int DNKGJOLJFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public NativeSlice<byte> LOOMBJNKMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public bool JEOHGOPBCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public int NIHEFKBEENL;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal readonly struct HMHBLBHODOD : IEquatable<HMHBLBHODOD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	internal readonly Material JOEAPFOLGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	internal readonly BDKODIGLHLM OLBFDDPENPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	internal readonly KADINOMKCPE NMIBLOKHJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	internal readonly JNJJMPPHJEI KJBLDLEEBEE;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xA699D0", Offset = "0xA67FD0", VA = "0x180A699D0")]
	public HMHBLBHODOD(Material OLKLLNJBJND, BDKODIGLHLM MMFKDODCHJN, KADINOMKCPE IAGCNDDHHNO, JNJJMPPHJEI ANOHNNKPBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x68ADDE0", Offset = "0x68AC3E0", VA = "0x1868ADDE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0xA69720", Offset = "0xA67D20", VA = "0x180A69720", Slot = "4")]
	public bool Equals(HMHBLBHODOD BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x68ADC50", Offset = "0x68AC250", VA = "0x1868ADC50", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x68ADD40", Offset = "0x68AC340", VA = "0x1868ADD40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class NGIEECLIKBB
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class ECONFELLPPF : IEnumerator<FEEHCBLGINO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private FEEHCBLGINO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private FEEHCBLGINO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x871800", Offset = "0x86FE00", VA = "0x180871800")]
		[DebuggerHidden]
		public ECONFELLPPF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA68B00", Offset = "0xA67100", VA = "0x180A68B00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x68A81E0", Offset = "0x68A67E0", VA = "0x1868A81E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
	public static void DAHEDHKKOPH(string DAIJJLLIENA, int HEPMKAJPNDG, long CIADKEHLKCN, long EFFABEHDNMG, long ECBFLCFEMMO, long IOHLKFDCMJF, long EIMDEHMMDPL, long HFOOAJJKIOJ, long HENPKHHONAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x68AE7E0", Offset = "0x68ACDE0", VA = "0x1868AE7E0")]
	public static EKNCDBKDOPI DBDBAAOCNCF(JobHandle GCPLANDGAIE, bool DDBJNIDNNEL, bool OPNIJPDNPGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x68AE930", Offset = "0x68ACF30", VA = "0x1868AE930")]
	[IteratorStateMachine(typeof(ECONFELLPPF))]
	private static IEnumerator<FEEHCBLGINO> PHBJDINEPIL(JobHandle FPDGNDMPHII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class IEBJILIADBE : BFIDGDINLAE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private GHJMNKICAIB LOMOMOCPBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private MBDOHKAHFFA ODFEFMLMCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private IRecRoomQualityConfigProvider LNEKCIAIFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private bool ECPGDMBEKKG;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x68AE010", Offset = "0x68AC610", VA = "0x1868AE010")]
	[ILMJIPMJHLC(IAFNNCJJPGN.GameOnly)]
	private static void AHHABOBNNNI(GLOPJKBGAFG PCIOPLPELBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5BBA750", Offset = "0x5BB8D50", VA = "0x185BBA750")]
	[UnityEngine.Scripting.Preserve]
	public IEBJILIADBE([JAMCDGPOOBO(null)] MBDOHKAHFFA NIIPFKPLAJJ, [JAMCDGPOOBO(null)] GHJMNKICAIB OADEHLIOKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x68AE2B0", Offset = "0x68AC8B0", VA = "0x1868AE2B0")]
	private void KOCNIPKIGDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x68AE110", Offset = "0x68AC710", VA = "0x1868AE110", Slot = "4")]
	public void APEPDNIPABD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x68AE320", Offset = "0x68AC920", VA = "0x1868AE320", Slot = "5")]
	public FNMJFLPICID<Texture2D> PLGKGKBOMBB(DGAGGBOGGCB NMDMIEBOKML, [Optional] MDBAMHHHLND FPAICILAIBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x68AE170", Offset = "0x68AC770", VA = "0x1868AE170")]
	private uint DJMJGILPAMM(DGAGGBOGGCB NMDMIEBOKML, MDBAMHHHLND FPAICILAIBH)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface IMIPMOPGJMN
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PAHIHILCCKN(Mesh CKFPIMAMAKM, Matrix4x4 EKEOEEDOIMB, byte[] LOOMBJNKMNA, bool HGLFDEKEPAK = false, MCHDNMDHAEL.INMFOKLKEDE PFNGDMHJOCF = (MCHDNMDHAEL.INMFOKLKEDE)0, int KDDNECEJJCJ = -1, bool FLHCIBEFFDB = false);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IFFCPHBGFPI(Allocator KOIILCBLJPK, KIOBLMMIJDE NBOPFLHBMDO, byte MKECCECLDLC, [Optional] IList<int> NAIKMFEKNHM, [Optional] IList<int> NDOMDOECFDH);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct COPALOMMCJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly GameObject GIGDFDNBHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private readonly AvatarItemMaterial AJFIKCDONPG;

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0xAED250", Offset = "0xAEB850", VA = "0x180AED250")]
	public COPALOMMCJJ(GameObject GIGDFDNBHPL, AvatarItemMaterial AJFIKCDONPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x68A7FD0", Offset = "0x68A65D0", VA = "0x1868A7FD0")]
	public void MLJKDGGFDJJ(Material OLKLLNJBJND, int IDFKCENAGJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class CMLKLBFFHJL : FAHFNGIGPAM<Task<(GameObject, AvatarItemMaterial)>, COPALOMMCJJ>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct GLJHPJPLPJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x68AAAB0", Offset = "0x68A90B0", VA = "0x1868AAAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x68AAFB0", Offset = "0x68A95B0", VA = "0x1868AAFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private FNMJFLPICID<GameObject> NLEDFCIJCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private FNMJFLPICID<AvatarItemMaterial> HHMNBGFIJHK;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x68A7F40", Offset = "0x68A6540", VA = "0x1868A7F40")]
	private CMLKLBFFHJL(Task<(GameObject, AvatarItemMaterial)> NAFOIMCAMMG, FNMJFLPICID<GameObject> HPBIJDFBGEO, FNMJFLPICID<AvatarItemMaterial> NMMJHKAKCNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x68A78D0", Offset = "0x68A5ED0", VA = "0x1868A78D0")]
	public static CMLKLBFFHJL BBHPEKFPBBP(AssetReference DEDKDEAAAGG, [Optional] AssetReference OEADHAIHIBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x68A7D70", Offset = "0x68A6370", VA = "0x1868A7D70", Slot = "11")]
	protected override COPALOMMCJJ GMJNNBFHLAH(Task<(GameObject, AvatarItemMaterial)> JPIANKHMFMF)
	{
		return default(COPALOMMCJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x68A7CF0", Offset = "0x68A62F0", VA = "0x1868A7CF0", Slot = "12")]
	protected override void BJAMHFCKFPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x68A7E10", Offset = "0x68A6410", VA = "0x1868A7E10")]
	[AsyncStateMachine(typeof(GLJHPJPLPJM))]
	private static Task<(GameObject, AvatarItemMaterial)> MNHHJCPDOLG(Task<GameObject> KKDIAFAPKHC, Task<AvatarItemMaterial> GIFEOFBPLIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class OECMLKHPODC
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class OGDGFFHPLAH : FAHFNGIGPAM<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private FNMJFLPICID<MaterialMapAsset> FPDGNDMPHII;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x68AF2F0", Offset = "0x68AD8F0", VA = "0x1868AF2F0")]
		public OGDGFFHPLAH(FNMJFLPICID<MaterialMapAsset> FPDGNDMPHII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x68AEEB0", Offset = "0x68AD4B0", VA = "0x1868AEEB0", Slot = "11")]
		protected override Material[] GMJNNBFHLAH(Task<MaterialMapAsset> NAFOIMCAMMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x68AEE50", Offset = "0x68AD450", VA = "0x1868AEE50", Slot = "12")]
		protected override void BJAMHFCKFPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private class EJOIBBCIHBP : FAHFNGIGPAM<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private List<FNMJFLPICID<Material>> KMMNMMLCLMO;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x68A83C0", Offset = "0x68A69C0", VA = "0x1868A83C0")]
		public EJOIBBCIHBP(Task<Material[]> NAFOIMCAMMG, List<FNMJFLPICID<Material>> KMMNMMLCLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x68A8370", Offset = "0x68A6970", VA = "0x1868A8370", Slot = "11")]
		protected override Material[] GMJNNBFHLAH(Task<Material[]> JPIANKHMFMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x68A8230", Offset = "0x68A6830", VA = "0x1868A8230", Slot = "12")]
		protected override void BJAMHFCKFPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly PBGLEKOCCEM APPJEAMJBHK;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x68AE9A0", Offset = "0x68ACFA0", VA = "0x1868AE9A0")]
	public static FNMJFLPICID<Material[]> CDOEMGLBAKF(AssetReference[] FHIOCLDMFFF)
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
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[HOJLKKKFAJH(MLFOJBPNDOB.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x68AF3D0", Offset = "0x68AD9D0", VA = "0x1868AF3D0")]
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
		private struct CCKNNABLMDP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public AsyncTaskMethodBuilder<KBGIPCJPJGF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public int eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			private TaskAwaiter<KBGIPCJPJGF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x68A53A0", Offset = "0x68A39A0", VA = "0x1868A53A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x68A56E0", Offset = "0x68A3CE0", VA = "0x1868A56E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private Dictionary<OMIIACJOJFJ, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private Dictionary<OMIIACJOJFJ, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private Dictionary<OMIIACJOJFJ, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private Dictionary<OMIIACJOJFJ, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private readonly Dictionary<OMIIACJOJFJ, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private KBGIPCJPJGF _defaultFaceStyle;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x68AAA80", Offset = "0x68A9080", VA = "0x1868AAA80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x68AA6A0", Offset = "0x68A8CA0", VA = "0x1868AA6A0")]
		public KBGIPCJPJGF NEHOFLEKANJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x68AA6F0", Offset = "0x68A8CF0", VA = "0x1868AA6F0")]
		[AsyncStateMachine(typeof(CCKNNABLMDP))]
		public Task<KBGIPCJPJGF> OEJODHKGHPO(int GIGJBOMFHAG, int EGKPCGFJCCE, int DNDAPABCACI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x68AA480", Offset = "0x68A8A80", VA = "0x1868AA480")]
		public NoseFaceOption JOOPMNLHCDP(int CIONFCOEGJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x68AA520", Offset = "0x68A8B20", VA = "0x1868AA520")]
		public SelectableFaceOption MGHFKECKGBK(FaceFeatureType OAKMGOIOEPE, OMIIACJOJFJ GEGIHMDBOPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x68AA400", Offset = "0x68A8A00", VA = "0x1868AA400")]
		public int HFKNJNKOKOJ(OMIIACJOJFJ GEGIHMDBOPM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x68AA1D0", Offset = "0x68A87D0", VA = "0x1868AA1D0")]
		private void FCMNKBENFHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DD70", Offset = "0x2B8C370", VA = "0x182B8DD70")]
		private void EDAGDMMMPHF<T>(IDictionary<OMIIACJOJFJ, T> CJCKCFPDODL, IReadOnlyList<T> FOKJNLKJBPH) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x68AA940", Offset = "0x68A8F40", VA = "0x1868AA940")]
		public OMIIACJOJFJ PJFCMLLJOLF(FaceFeatureType OAKMGOIOEPE)
		{
			return default(OMIIACJOJFJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x68AA820", Offset = "0x68A8E20", VA = "0x1868AA820")]
		public OMIIACJOJFJ PEOLBPGKPPA(FaceFeatureType OAKMGOIOEPE)
		{
			return default(OMIIACJOJFJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x68AA9F0", Offset = "0x68A8FF0", VA = "0x1868AA9F0")]
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
