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
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_AvatarRenderingSystems_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : GDJKPKDCEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x81B8CB0", Offset = "0x81B7AB0", VA = "0x1881B8CB0", Slot = "4")]
		public override void FAIIODDINIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
			[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x81BA8B0", Offset = "0x81B96B0", VA = "0x1881BA8B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x81BA840", Offset = "0x81B9640", VA = "0x1881BA840", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x81BA870", Offset = "0x81B9670", VA = "0x1881BA870")]
		public RecNetCDNAssetReference(RecNetCDNKey OPGJHIOADCK)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum DJGGMLOJHEI : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			Bundle,
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Prefab,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			MaterialMap
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string BundleFilename
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAC2580", Offset = "0xAC1380", VA = "0x180AC2580")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAC2300", Offset = "0xAC1100", VA = "0x180AC2300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public DJGGMLOJHEI PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xF4A830", Offset = "0xF49630", VA = "0x180F4A830")]
			[CompilerGenerated]
			get
			{
				return default(DJGGMLOJHEI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x15C3550", Offset = "0x15C2350", VA = "0x1815C3550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x81BA9C0", Offset = "0x81B97C0", VA = "0x1881BA9C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x81BA940", Offset = "0x81B9740", VA = "0x1881BA940")]
		public static RecNetCDNKey CPNMAOJEEGH(string CKICIKIAOKA, DJGGMLOJHEI FHFDOLLKLIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x81BA8F0", Offset = "0x81B96F0", VA = "0x1881BA8F0")]
		public void ACEBENBDPON(string OLEILFDADDK, string HOHPDECNKDA, bool GJHKDMOBNHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CMNOLHHFBOP]
public class DNNOLDECPPB : PENHAKDMPJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<Mesh> NDFANENINPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<byte[]> HMFCHOKAAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<Matrix4x4> GDNAKNJIIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly List<bool> KGELNODONIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly List<long> KFCNJOECAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly List<bool> PKKJDMAJLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected readonly List<int> OMEPLLGCMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected Allocator KEBLPCHPGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected DGLGBOIILAC LNMGIDNPNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected byte IHEEJLHPIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected IList<int> GCFKMNNKPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected IList<int> IMEMDOHJPDN;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x81B7540", Offset = "0x81B6340", VA = "0x1881B7540", Slot = "4")]
	public void JKNALEOPEFP(Mesh PKBJPDPONKJ, Matrix4x4 NEHNKJPBLAB, byte[] EGAPAKLBHHP, bool HIBIAAFBKPN = false, BCIIDHEJBAB.MMBHHGOHKAA JPKJKHCGHGJ = (BCIIDHEJBAB.MMBHHGOHKAA)0L, int DHNEDKNOHGH = -1, bool HGEPLHIBCBG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x81B7AD0", Offset = "0x81B68D0", VA = "0x1881B7AD0", Slot = "5")]
	public void MJEGPPJOLGB(Allocator GIEDOJCOPKP, DGLGBOIILAC ELMOINEPNFB, byte NNEDKNMKPIN, [Optional] IList<int> HGAOJKNHIKD, [Optional] IList<int> FFMBFDIKGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x81B7870", Offset = "0x81B6670", VA = "0x1881B7870")]
	private static void JPLAMOEEMAE(Mesh PKBJPDPONKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x81B7B10", Offset = "0x81B6910", VA = "0x1881B7B10")]
	public DNNOLDECPPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[CMNOLHHFBOP]
public struct DILKIMFOAAC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public PPHMIMDDEBL MMLOLGOHIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public int FOCCBAELIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public BOMNFLDFEIL JKCAJNOJDGE;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x81B5BB0", Offset = "0x81B49B0", VA = "0x1881B5BB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NativeContainer]
[CMNOLHHFBOP]
public struct BOMNFLDFEIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct BPJKMPKFGAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector3 CJOKGJMLHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector3 INIBGDOOLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector4 PKLKGOJFOJC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct CPPLDMBCPDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float DKBAIDCOEOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float GEBPCPPMDMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float LEDCFHEACNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float OMAMCPAGPHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte JKBIELEJNIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public byte JDJBDBGHDLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public byte DLOCDHAHCEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte LCAANNHAFGH;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct BGLOHKHKELM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half DKBAIDCOEOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half GEBPCPPMDMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half LEDCFHEACNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half OMAMCPAGPHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public byte JKBIELEJNIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte JDJBDBGHDLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public byte DLOCDHAHCEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public byte LCAANNHAFGH;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct OJJJCBKLFCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 BGBIPHDMBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 GPFAKLNOCCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half4 GFFGAPCBBOD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct ODMOBOEIFPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half4 BGBIPHDMBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 GPFAKLNOCCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 KMMBLKGLEOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half4 GFFGAPCBBOD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct LJDHPKNLJIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half4 BGBIPHDMBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 GPFAKLNOCCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half2 KMMBLKGLEOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public half2 IIEPCHFNOEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public half4 GFFGAPCBBOD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct BKPGGAKJLIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public half4 BGBIPHDMBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public half2 GPFAKLNOCCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public half2 KMMBLKGLEOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public half2 IIEPCHFNOEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public half2 JGAOEPJKLAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public half4 GFFGAPCBBOD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct DJHLGELJHNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float DKBAIDCOEOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public float GEBPCPPMDMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float LEDCFHEACNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float OMAMCPAGPHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int JKBIELEJNIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int JDJBDBGHDLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int DLOCDHAHCEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int LCAANNHAFGH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct AKBMFFCBPON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color BGBIPHDMBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 GPFAKLNOCCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector4 GFFGAPCBBOD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct BNMDEMFPDJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Color BGBIPHDMBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 GPFAKLNOCCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Vector2 KMMBLKGLEOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector4 GFFGAPCBBOD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct MHNIAHAAMNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Color BGBIPHDMBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Vector2 GPFAKLNOCCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Vector2 KMMBLKGLEOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Vector2 IIEPCHFNOEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Vector4 GFFGAPCBBOD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct IJNFHGBGIGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Color BGBIPHDMBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Vector2 GPFAKLNOCCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Vector2 KMMBLKGLEOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Vector2 IIEPCHFNOEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Vector2 JGAOEPJKLAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Vector4 GFFGAPCBBOD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool CAPLMLJBOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<BPJKMPKFGAC> JIPOCBGOHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<OJJJCBKLFCA> HGOCKOMKENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<ODMOBOEIFPM> OFMBPLLILJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<LJDHPKNLJIP> GHNPIMECCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<BKPGGAKJLIE> BLDKMCDENHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<BGLOHKHKELM> ONGCJLPKPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<CPPLDMBCPDO> PACNCCNGDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<AKBMFFCBPON> FDOLHNAOIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<BNMDEMFPDJA> OPPODGGMIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<MHNIAHAAMNL> CKANKBDCPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<IJNFHGBGIGE> NPJOBNBOJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<DJHLGELJHNI> DAAOBGJELOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> OKPBIIKLGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> IFBLBHPHPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> JFKNCOAMJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> KDHNNNEKNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> OLHJHDEKHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> FHLFEBMLDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<int> AOIDAJMJPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<BoneWeight> HLGAADGFIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> ONHEEOKCMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool PJJAKFAJAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool INELPJMLLHN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int JGKKMPGBDCK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x81B2BA0", Offset = "0x81B19A0", VA = "0x1881B2BA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x81B2BB0", Offset = "0x81B19B0", VA = "0x1881B2BB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int LIMHPDHIPAM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x81B39C0", Offset = "0x81B27C0", VA = "0x1881B39C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x81B2FD0", Offset = "0x81B1DD0", VA = "0x1881B2FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int FMNMGJMFEEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x81B5040", Offset = "0x81B3E40", VA = "0x1881B5040")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x81B34A0", Offset = "0x81B22A0", VA = "0x1881B34A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int EGIFAIAGNGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x81B3F40", Offset = "0x81B2D40", VA = "0x1881B3F40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x81B5050", Offset = "0x81B3E50", VA = "0x1881B5050")]
	public BOMNFLDFEIL(int FGHICNHGHGB, int IJJGCKDBPNA, int LDNDBBFKPNL, int HJCJPJEPPHC, Allocator GIEDOJCOPKP, int NKOMEABIGGK, MKHGGIEOPJJ LKIMPIPGEDJ, bool PJJAKFAJAKH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x81B2FE0", Offset = "0x81B1DE0", VA = "0x1881B2FE0")]
	public void GIDJIJJJNOH(int JJJJBEGKNIN, Vector3 MHBJBKNNPOK, Vector3 DPBDKFEONOK, Vector4 DDCPKPIHIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x81B3580", Offset = "0x81B2380", VA = "0x1881B3580")]
	public void IGCMLKMLBDI(int JJJJBEGKNIN, BoneWeight LNNEPGHGMEL, NativeSlice<byte> EGAPAKLBHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x81B39D0", Offset = "0x81B27D0", VA = "0x1881B39D0")]
	public Color KBDNEKDCIHM(int JJJJBEGKNIN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x81B3070", Offset = "0x81B1E70", VA = "0x1881B3070")]
	public void GOFKBCCDKNA(int JJJJBEGKNIN, Color JMOOEAFLFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x81B4F50", Offset = "0x81B3D50", VA = "0x1881B4F50")]
	public void PEPCKGLHBAO(int JJJJBEGKNIN, Vector3 EEIHHMMODIJ, Vector3 KPJDNKIOKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x81B27F0", Offset = "0x81B15F0", VA = "0x1881B27F0")]
	public void CBIBPGOMHHI(int JJJJBEGKNIN, half4 EEIDJALLCBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x81B3CF0", Offset = "0x81B2AF0", VA = "0x1881B3CF0")]
	public void KLAFOEMLNEA(int JJJJBEGKNIN, Vector3 EEIDJALLCBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x81B2BC0", Offset = "0x81B19C0", VA = "0x1881B2BC0")]
	public void FONDGIKKIPO(byte LGBMOBOFHFN, int JJJJBEGKNIN, Vector2 EEIDJALLCBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x81B39B0", Offset = "0x81B27B0", VA = "0x1881B39B0")]
	public void IICJJEBJJDM(int JJJJBEGKNIN, int DMOBFBGAGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x81B3FB0", Offset = "0x81B2DB0", VA = "0x1881B3FB0")]
	public bool NPBAGFDOMIP(int LGBMOBOFHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x81B34B0", Offset = "0x81B22B0", VA = "0x1881B34B0")]
	public void IELBBJGAHEC(int JFIKOCLBAKH, int IBOFMHFOKKF, int MCJGICKIGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x81B2940", Offset = "0x81B1740", VA = "0x1881B2940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x81B4010", Offset = "0x81B2E10", VA = "0x1881B4010")]
	public Mesh PALJIPCNJPO([Optional] string HOEJBHEEBOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[CMNOLHHFBOP]
[NativeContainer]
public struct PPHMIMDDEBL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Mesh.MeshDataArray OLLNPGJNNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<int> LLAGCIKLGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeArray<int> CODCKMFCALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<BoneWeight> HLGAADGFIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<Matrix4x4> LMPNGBPAFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<long> NHEOEHIGDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<byte> PDINFEBCACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<int> DJODDAAEOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeArray<int> OGKACEFKFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeArray<sbyte> LKKJDOFMGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public NativeArray<byte> ACCFLKAEBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public NativeArray<bool> HGEPLHIBCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeArray<int> DHNEDKNOHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool PJJAKFAJAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeArray<int> CAHHJMNAFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool INELPJMLLHN;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int AEFKEJJDGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x81B9620", Offset = "0x81B8420", VA = "0x1881B9620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int OMMOPPGCEFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x81B9600", Offset = "0x81B8400", VA = "0x1881B9600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int IJAKKCICKEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x81B9510", Offset = "0x81B8310", VA = "0x1881B9510")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int KAJEKFFHPEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x81B94F0", Offset = "0x81B82F0", VA = "0x1881B94F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x81B95F0", Offset = "0x81B83F0", VA = "0x1881B95F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int JGKKMPGBDCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x81B94D0", Offset = "0x81B82D0", VA = "0x1881B94D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x81B94E0", Offset = "0x81B82E0", VA = "0x1881B94E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int FMJGADKGNIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x81B9630", Offset = "0x81B8430", VA = "0x1881B9630")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x81B9260", Offset = "0x81B8060", VA = "0x1881B9260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public DGLGBOIILAC NCFFMECKFEM
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x81B9500", Offset = "0x81B8300", VA = "0x1881B9500")]
		get
		{
			return default(DGLGBOIILAC);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x81B9610", Offset = "0x81B8410", VA = "0x1881B9610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte ECBFPBENFAO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x81B95E0", Offset = "0x81B83E0", VA = "0x1881B95E0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x81B9270", Offset = "0x81B8070", VA = "0x1881B9270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public JMCJDGFEEKP ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x81B9010", Offset = "0x81B7E10", VA = "0x1881B9010")]
		get
		{
			return default(JMCJDGFEEKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x81B9640", Offset = "0x81B8440", VA = "0x1881B9640")]
	public PPHMIMDDEBL(IList<Mesh> KHJBGGHKJFO, IList<Matrix4x4> KNGFDFAJCCL, IList<bool> HGEPLHIBCBG, byte NNEDKNMKPIN, IList<byte[]> LOHLIBFPIEO, IList<long> AOMJGELIION, IList<bool> JMGBCBHPIIO, IList<int> DHNEDKNOHGH, IList<int> HGAOJKNHIKD, IList<int> DEPCGJPGPBC, Allocator GIEDOJCOPKP, DGLGBOIILAC ELMOINEPNFB, bool PJJAKFAJAKH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x81B9400", Offset = "0x81B8200", VA = "0x1881B9400")]
	public BOMNFLDFEIL EFEDEDMAKJO(Allocator GIEDOJCOPKP, MKHGGIEOPJJ LKIMPIPGEDJ)
	{
		return default(BOMNFLDFEIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x81B9280", Offset = "0x81B8080", VA = "0x1881B9280", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[CMNOLHHFBOP]
public class JMPJMBOLCDP : DNNOLDECPPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public bool OMJFCJDFGBP;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static readonly ProfilerMarker MJCPJHNNDCN;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x81B8330", Offset = "0x81B7130", VA = "0x1881B8330")]
	public PPHMIMDDEBL GNGFEIIBNFD()
	{
		return default(PPHMIMDDEBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x81B8630", Offset = "0x81B7430", VA = "0x1881B8630")]
	public JMPJMBOLCDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct JMCJDGFEEKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Mesh.MeshData GPINMBIDJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public NativeSlice<BoneWeight> HLGAADGFIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeSlice<byte> GGNIAMOPOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public int OFDJDIPHFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Matrix4x4 LEBLPNNMLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public long FKGKCGDCIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeSlice<byte> EGAPAKLBHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public bool FBDIBONGICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public int DBHFIBOKMMJ;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BBJFEIJFEIJ : FCEMHMOCEFP
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class GEDFLIJNFEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public bool hideTorsoInFirstPersonBeanMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public BBJFEIJFEIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public MDIEIFNFGHA buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public Action<KeyValuePair<string, HNDICJJKNNH<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public GEDFLIJNFEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x81B8010", Offset = "0x81B6E10", VA = "0x1881B8010")]
		internal bool CILAMLMELNE(GADJBANEMPG item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x81B8250", Offset = "0x81B7050", VA = "0x1881B8250")]
		internal void KLFOEJCMJOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x81B8170", Offset = "0x81B6F70", VA = "0x1881B8170")]
		internal void MGMNIPICAMN(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x81B8250", Offset = "0x81B7050", VA = "0x1881B8250")]
		internal void KODNIAIKOOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x81B8170", Offset = "0x81B6F70", VA = "0x1881B8170")]
		internal void JCFPCPNKMNC(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x81B8080", Offset = "0x81B6E80", VA = "0x1881B8080")]
		internal void ENGGOKOKDKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x81B8050", Offset = "0x81B6E50", VA = "0x1881B8050")]
		internal void CKKKKIDBDND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x81B8190", Offset = "0x81B6F90", VA = "0x1881B8190")]
		internal void JKBECJKPCIL(Dictionary<string, HNDICJJKNNH<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x81B80B0", Offset = "0x81B6EB0", VA = "0x1881B80B0")]
		internal void FHPMBKOHGDL(KeyValuePair<string, HNDICJJKNNH<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		internal BFMPGGMMDDD PKKLLKDNJAH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class IIKCJCKBHAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public GEDFLIJNFEC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public IIKCJCKBHAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x81B8270", Offset = "0x81B7070", VA = "0x1881B8270")]
		internal HGNPGFJCOLF OFLJJKJHONC(int lod)
		{
			return default(HGNPGFJCOLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class BKKCLEFGJCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public AIKJELDGMEB<Dictionary<string, HNDICJJKNNH<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public BKKCLEFGJCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		internal AIKJELDGMEB<Dictionary<string, HNDICJJKNNH<Texture2D>>> CLKGHKDIPNK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class CHFGFMLDDGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public List<MDIEIFNFGHA> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public CHFGFMLDDGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x81B5A80", Offset = "0x81B4880", VA = "0x1881B5A80")]
		internal void ODDECDECCPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class OFINIEBLIOI : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private PHFDFIIIMCE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public BBJFEIJFEIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public List<PBJIPPMPJIL> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public List<MDIEIFNFGHA> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public Func<int, HGNPGFJCOLF> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public JJHEPAMDFNI materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
		[DebuggerHidden]
		public OFINIEBLIOI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x81B8D40", Offset = "0x81B7B40", VA = "0x1881B8D40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x81B8FC0", Offset = "0x81B7DC0", VA = "0x1881B8FC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class AFDBAPLDKNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public OBGJBBNBLIP cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public AFDBAPLDKNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xBE98F0", Offset = "0xBE86F0", VA = "0x180BE98F0")]
		internal void COCAMCPGCPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xE462B0", Offset = "0xE450B0", VA = "0x180E462B0")]
		internal void KINLAPOIGKP(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class HFDEPBFPLMF
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
		public BBJFEIJFEIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public List<(int mat, int part)> avatarItemMaterialPartIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public List<Bounds> avatarPartMeshBounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public HFDEPBFPLMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class LHEGDLFPLGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public BOMNFLDFEIL defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public PPHMIMDDEBL defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public HFDEPBFPLMF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public LHEGDLFPLGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x81B86B0", Offset = "0x81B74B0", VA = "0x1881B86B0")]
		internal void NDMFPHJECAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x81B8640", Offset = "0x81B7440", VA = "0x1881B8640")]
		internal void JMNDLBOBBFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class EADOAFDOIBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public AKEPAJEDMMO legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public JOLEFOKNIHO legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public HFDEPBFPLMF CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public EADOAFDOIBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x81B7D60", Offset = "0x81B6B60", VA = "0x1881B7D60")]
		internal void FNOENDECKFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x81B7FA0", Offset = "0x81B6DA0", VA = "0x1881B7FA0")]
		internal void LHJBECIOMHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class EGHDLMLLCBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public BBJFEIJFEIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public float power;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public Color color;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public EGHDLMLLCBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x81C5230", Offset = "0x81C4030", VA = "0x1881C5230")]
		internal void NGLCJNCNIMD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class IBDJEFMIEID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public PGMODLDJKOM overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public IBDJEFMIEID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x81C5D00", Offset = "0x81C4B00", VA = "0x1881C5D00")]
		internal bool AEJNEBBIMPG(KeyValuePair<string, GADJBANEMPG> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MKAEDPHCCBC AACDCCGLKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly MKAEDPHCCBC KHCAOHFBGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Dictionary<LPJNBIJEEIN, float> NCAMOLMPPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Dictionary<OKKHECCBEHE, float> GEHMCGOFMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Dictionary<NJAIGHPFLPG, float> PPBIMGAAPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyDictionary<string, CFLHAGNENCM> MCFCIIJIJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Dictionary<string, CFLHAGNENCM> HBFJGJKNFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Dictionary<string, CFLHAGNENCM> POJIFEFOLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Dictionary<string, CFLHAGNENCM> OIMKKHJKJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private JDDEJEECIBC NFEAGLADMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private JDDEJEECIBC MKJLAECOJOP;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static float GMHMJMJEFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool? HEKIEDGEAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool? GIKGGCEDBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool? CCICFCABNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool? MHJAJNNGEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private AvatarConfiguration NEIIGEJHJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Transform NIBAFGCPMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private AvatarSkinAssetItem HNLGEBKHDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private AssetReference PHKLJGJOIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private AssetReference MHCIBBCLNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private AssetReference LHANKOMFPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private AssetReference DAGCIKIIPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private GameObject LFDLCBBCHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private GameObject EMNHBHHCHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private GameObject DMGNKIDKDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private SkinnedMeshRenderer KLPFGBHLPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private AvatarSkinnedMeshBoneOrderRemapsData ABMNKIACCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Transform[] BKEOMNDOFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private Matrix4x4[] FHJDOKECPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Material EGDIKBHOOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Material HIKFGDDKNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private Material EGBAHIKPJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private Material GDJIEMHFLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Material FKHIEOMIIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Shader OFOPGMNGPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Shader HIBNIAIBACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Animator EKHAMMMDOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Renderer[] NNEOCHMPAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private BCIIDHEJBAB.MMBHHGOHKAA LFOKPAFOLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private AvatarBodyPartShapesManager ELCAJPBAGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private IReadOnlyDictionary<string, Transform> JOPCOGFPGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private AvatarFaceShapeData.NBPFNGJDNEF DNDBFMNMBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private AvatarBodyShapeData.PGBKJOHIBBG MGGCEEDLLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private PBJKAGHPKMF NMFGKFDOKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private bool HLODPCJFNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x145")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool LBGMOCOCCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Color KLCALGKCFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Color KOOPCICAMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private Color MIDPBKIEBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private Color? HGNDHEKGBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private Color? CDBEBJCGNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Color? PPIOEKPLOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Color? AACOIIHKAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Texture2D IFILGLNKGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Texture2D EJMCLDEMEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[CanBeNull]
	private GADJBANEMPG ALIEJLHPGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Texture FBAHLMPECPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Color HGDNOHPCEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public Dictionary<Renderer, JJHEPAMDFNI> LNEJDFKKLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private Dictionary<Renderer, JJHEPAMDFNI> MDHIBKMMPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private Dictionary<string, List<MBFFLHEIAGD>> EOKIIBBFFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Dictionary<string, List<MBFFLHEIAGD>> FMOMELPFKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly List<JBJKHPALKPK> AHPOKNKDPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly List<JBJKHPALKPK> OKMLHFOCFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly List<JBJKHPALKPK> AFMOHCGPCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly List<JBJKHPALKPK> EMIKMIKILHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private Dictionary<MBFFLHEIAGD, Material> NCOBCEEKOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private Dictionary<MBFFLHEIAGD, Material> FFLGKHFLJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private SkinnedMeshRenderer[] IGJMHNCOLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private SkinnedMeshRenderer[] GJMHOBKIHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private SkinnedMeshRenderer[] PMHOPOAGCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private SkinnedMeshRenderer[] NIPGIPKIGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly Dictionary<string, HNDICJJKNNH<Texture2D>> HEGJECIBFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly Dictionary<string, HNDICJJKNNH<Texture2D>> KIOPAPNFJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private AdditionalHatData ACBNOEKFMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private AdditionalHatData KGCABJHKJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private HairData KOHHEOAKBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private HairData JIENEDJPIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private NODDIPDIFHA ALKGHNDEAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool? LGGJEEIDCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A4")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private PositionAndRotation LCBDLLICGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private Transform DJFAJBEADBN;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private Material LEACGJBFHEF;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private Material CJOMJLFNDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private Dictionary<string, GADJBANEMPG> PMJJLAGELAF;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly int KAOMJNEHAAH;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int JMNPGMBNHJG;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int IJPIDIKGGDA;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly int CDICPDGKELN;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly int MBGJBJJFJMH;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly int HHEEKDJHGIM;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly int FIJJFKMDLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool CDEAIIGIOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private List<Action> BFIFFCHKJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private CJPLKIFIKIH NAMABMOFHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private SkinnedMeshRenderer[] FICGKAKDAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private int IJHMMOKHKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool IADOLEGGHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int CHACFJNLKNH;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MKAEDPHCCBC OHBIFHPBGHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MKAEDPHCCBC ANENIFIKICH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private CEDIOCPLCGJ OOMNLGEDCIK
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x81B0F70", Offset = "0x81AFD70", VA = "0x1881B0F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool GJJADAOONKH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x81A7330", Offset = "0x81A6130", VA = "0x1881A7330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool BEPHHPKMBOP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x81A7CF0", Offset = "0x81A6AF0", VA = "0x1881A7CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool OOMKPIEKHNL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x81AD9B0", Offset = "0x81AC7B0", VA = "0x1881AD9B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool GGGAGGMABPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x81AD3C0", Offset = "0x81AC1C0", VA = "0x1881AD3C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public AvatarConfiguration JLBHAGOLLAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA931D0", Offset = "0xA91FD0", VA = "0x180A931D0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool AKDGCJJPCEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x81AC6C0", Offset = "0x81AB4C0", VA = "0x1881AC6C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x81A76D0", Offset = "0x81A64D0", VA = "0x1881A76D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Material AFJPKFFMBBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x81B0640", Offset = "0x81AF440", VA = "0x1881B0640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Material HCEOGEJHANL
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x81A8170", Offset = "0x81A6F70", VA = "0x1881A8170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool LPDMGNAFELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public JLFDMKNKLIE GJLEPBFGGDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x81B0F20", Offset = "0x81AFD20", VA = "0x1881B0F20", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(JLFDMKNKLIE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x81B0630", Offset = "0x81AF430", VA = "0x1881B0630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Material LOFAKJDIECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xB21D60", Offset = "0xB20B60", VA = "0x180B21D60", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public SkinnedMeshRenderer[] EIAIMBPJKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xBA6D10", Offset = "0xBA5B10", VA = "0x180BA6D10", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Renderer[] JNAMDPAKHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAFA620", Offset = "0xAF9420", VA = "0x180AFA620", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool ODDPEIDBCKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x81A8000", Offset = "0x81A6E00", VA = "0x1881A8000", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public BCIIDHEJBAB.MMBHHGOHKAA PPCMKEOEJJK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xC0C380", Offset = "0xC0B180", VA = "0x180C0C380", Slot = "20")]
		get
		{
			return default(BCIIDHEJBAB.MMBHHGOHKAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int AAECLLJLKCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x81B0F10", Offset = "0x81AFD10", VA = "0x1881B0F10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x81AAC70", Offset = "0x81A9A70", VA = "0x1881AAC70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool LENHBDNDFIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x81AA260", Offset = "0x81A9060", VA = "0x1881AA260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private static bool HAEGMPKNFMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x81B14C0", Offset = "0x81B02C0", VA = "0x1881B14C0", Slot = "15")]
	public MDIEIFNFGHA OMEFPLJCMHL(FMMCEONPFDK IBFNOLFIHLO, bool AFLMGCHBBID, int[] PKGEIKDNGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x81B0F30", Offset = "0x81AFD30", VA = "0x1881B0F30", Slot = "14")]
	public MDIEIFNFGHA NGIBAMGDGFH(FMMCEONPFDK IBFNOLFIHLO, bool AFLMGCHBBID, int[] PKGEIKDNGCD, Func<Dictionary<string, GADJBANEMPG>, (MDIEIFNFGHA, AIKJELDGMEB<Dictionary<string, HNDICJJKNNH<Texture2D>>>)> DMNCLJODANN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x81A4FF0", Offset = "0x81A3DF0", VA = "0x1881A4FF0")]
	public MDIEIFNFGHA ANEKHAANDOM(FMMCEONPFDK IBFNOLFIHLO, bool AFLMGCHBBID, int[] PKGEIKDNGCD, bool PLAANBBGPIA, JDDEJEECIBC PLOOAPBMBFM, [Optional] Func<Dictionary<string, GADJBANEMPG>, (MDIEIFNFGHA, AIKJELDGMEB<Dictionary<string, HNDICJJKNNH<Texture2D>>>)> DMNCLJODANN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x81AA9A0", Offset = "0x81A97A0", VA = "0x1881AA9A0")]
	private bool EGPLLAJOOBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x81AA2E0", Offset = "0x81A90E0", VA = "0x1881AA2E0")]
	private MDIEIFNFGHA EFFOMCMHGIP(bool AFLMGCHBBID, List<PBJIPPMPJIL> KIDNNEPOGEL, int[] PKGEIKDNGCD, Func<int, HGNPGFJCOLF> CNGMDPNEGAA, bool PLAANBBGPIA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x81AC490", Offset = "0x81AB290", VA = "0x1881AC490")]
	[IteratorStateMachine(typeof(OFINIEBLIOI))]
	private IEnumerator<PHFDFIIIMCE> FNIFHEGOOAA(bool AFLMGCHBBID, List<PBJIPPMPJIL> KIDNNEPOGEL, int[] PKGEIKDNGCD, Func<int, HGNPGFJCOLF> CNGMDPNEGAA, JJHEPAMDFNI AKPOPFAGDJI, Material FJFGKPCPLNJ, List<MDIEIFNFGHA> EFFCHBKNNEH, bool FPDPMBMNKIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x81A85E0", Offset = "0x81A73E0", VA = "0x1881A85E0")]
	private void DHODAIGEPKA(List<PBJIPPMPJIL> KIDNNEPOGEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x81AEFA0", Offset = "0x81ADDA0", VA = "0x1881AEFA0")]
	private MDIEIFNFGHA KCKGFEHAMPC(List<PBJIPPMPJIL> KIDNNEPOGEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x81AAC90", Offset = "0x81A9A90", VA = "0x1881AAC90")]
	private GMJHELKMAKL FCDIGHFACNJ(List<PBJIPPMPJIL> KIDNNEPOGEL, int GOLHBMLDEPN, bool AFLMGCHBBID, HGNPGFJCOLF OGEICBNAJLO, bool EACCAKNNDBG, JJHEPAMDFNI AKPOPFAGDJI, Material FJFGKPCPLNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x81AA8C0", Offset = "0x81A96C0", VA = "0x1881AA8C0", Slot = "27")]
	public void EGFDGNCDINH(LPJNBIJEEIN GBKLPMDLCID, float HGMAIPELJHM, bool GDJOLJEIGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x81A6FB0", Offset = "0x81A5DB0", VA = "0x1881A6FB0", Slot = "29")]
	public void BDFJPJOEGGK(OKKHECCBEHE GDMCALFNKFD, float HGMAIPELJHM, bool BDFEAOHHGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x81AA170", Offset = "0x81A8F70", VA = "0x1881AA170", Slot = "30")]
	public void EBPIBFKAJNL(NJAIGHPFLPG FHFKIJJNMJA, float HGMAIPELJHM, bool KKMAFHPNKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x81A8DA0", Offset = "0x81A7BA0", VA = "0x1881A8DA0", Slot = "28")]
	public void DOPDFHODEOB(bool HNIHIGJBKBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x81AE9D0", Offset = "0x81AD7D0", VA = "0x1881AE9D0", Slot = "31")]
	public void JIFPANLDEMP(bool HNIHIGJBKBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x81AFD40", Offset = "0x81AEB40", VA = "0x1881AFD40", Slot = "32")]
	public void LHCCLHLCLJJ(bool HNIHIGJBKBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x81A7090", Offset = "0x81A5E90", VA = "0x1881A7090")]
	private void BDKGJBBBEEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x81B0B60", Offset = "0x81AF960", VA = "0x1881B0B60")]
	private void MMLIPLOOOGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x81B0CB0", Offset = "0x81AFAB0", VA = "0x1881B0CB0")]
	private void NBECFENIDIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x81AD230", Offset = "0x81AC030", VA = "0x1881AD230", Slot = "25")]
	public void HAEEEEDALPI(AvatarFaceShape FKOHDOKFCKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x81A7A30", Offset = "0x81A6830", VA = "0x1881A7A30", Slot = "26")]
	public void CPJDJGIMDJC(AvatarBodyShape PNPBMHOHCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x81AC820", Offset = "0x81AB620", VA = "0x1881AC820", Slot = "33")]
	public void GFHJMJCJEAN(PBJKAGHPKMF BDJEBKAJJPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x81B15F0", Offset = "0x81B03F0", VA = "0x1881B15F0", Slot = "35")]
	public void PGCOFJFAHJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x81AF220", Offset = "0x81AE020", VA = "0x1881AF220", Slot = "41")]
	public void KIFIIIFEKIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x81B0F60", Offset = "0x81AFD60", VA = "0x1881B0F60", Slot = "34")]
	public void NIPKLEOKGEF(bool IIFMFKOHHKK, bool HBGMKIBALAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x81B0940", Offset = "0x81AF740", VA = "0x1881B0940")]
	private void MFOCOJEKEDE(SkinnedMeshRenderer MEGAPLKPLGN, int GOLHBMLDEPN, Mesh PKBJPDPONKJ, List<Material> JMFOHHFJNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x81A7770", Offset = "0x81A6570", VA = "0x1881A7770")]
	private static Material CLJKAFAHALO(Dictionary<MBFFLHEIAGD, Material> FDFJLNOBFID, Material BPPJHOECKCN, GNIJEKPFBKC LDFBMIIMOMB, OAIBKIMFJOG FEMFKDHLAOB, PGMODLDJKOM DPNGCNNOBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x81B1B50", Offset = "0x81B0950", VA = "0x1881B1B50")]
	private static GNIJEKPFBKC POMKBHIEMCL(PBJIPPMPJIL CNNAFMPBGPA, int OBLFEOBLMJO)
	{
		return default(GNIJEKPFBKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x81AC830", Offset = "0x81AB630", VA = "0x1881AC830")]
	private void GGNCDACDFFA(int IDNAPJMNGPO, Material GKIFPALLDIK, PBJIPPMPJIL CNNAFMPBGPA, [Out] Texture2D EPOMGGJGNKB, [Out] Vector4 AAFLGHLLEHO, [Out] Texture2D JHBANDDMFAH, [Out] Texture2D IABMIKELJIO, [Out] Texture2D HNMLBPKKHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x81AEAE0", Offset = "0x81AD8E0", VA = "0x1881AEAE0")]
	private void JPGAMNOBCLM(int IDNAPJMNGPO, Material GKIFPALLDIK, PBJIPPMPJIL CNNAFMPBGPA, [Out] Color GOIKFANCJOE, [Out] Color JDJDHGJABHK, [Out] Color BKANIHANBND, [Out] Color PBIBBJDLFFO, [Out] Color KJIBDFAENCC, [Out] Color ABKEPHAAPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x81AF370", Offset = "0x81AE170", VA = "0x1881AF370")]
	private bool KLJFCAPOFBN(Material GKIFPALLDIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x81A8D50", Offset = "0x81A7B50", VA = "0x1881A8D50")]
	private static Material DOKAEDOIADO(int IDNAPJMNGPO, DHGCFBOFHFJ CNNAFMPBGPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x81ACE30", Offset = "0x81ABC30", VA = "0x1881ACE30")]
	private static OAIBKIMFJOG GMCELDNNIHD(PBJIPPMPJIL CNNAFMPBGPA, int OBLFEOBLMJO)
	{
		return default(OAIBKIMFJOG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x81AE6B0", Offset = "0x81AD4B0", VA = "0x1881AE6B0")]
	private static void JCGPOMAAFAL(Dictionary<string, List<MBFFLHEIAGD>> OKBODOGBGNF, PBJIPPMPJIL PFJIMFGKMBL, Material BPPJHOECKCN, GNIJEKPFBKC FOPEMADPOPM, OAIBKIMFJOG BEIGFDDCGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x81A7DD0", Offset = "0x81A6BD0", VA = "0x1881A7DD0")]
	private static SkinnedMeshRenderer DCFMPLPMHHI(Transform EGNLEDBIPOA, Transform NJLDNNFKBCH, SkinnedMeshRenderer[] IJFDLHFCHJH, int GOLHBMLDEPN, HGNPGFJCOLF OGEICBNAJLO, bool AFLMGCHBBID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x81B1E40", Offset = "0x81B0C40", VA = "0x1881B1E40")]
	public BBJFEIJFEIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x81ADA90", Offset = "0x81AC890", VA = "0x1881ADA90")]
	public void IEHCJBEIMLK([In] JKKGEALMIHG CDFPKCFCBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x81AE950", Offset = "0x81AD750", VA = "0x1881AE950")]
	public void OPKPDOIHOAP([In] DCMBGIPAEDP MOKLKDFMMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x81AAC70", Offset = "0x81A9A70", VA = "0x1881AAC70", Slot = "5")]
	public void EPNGGJCNGCF(int GOLHBMLDEPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x81A7110", Offset = "0x81A5F10", VA = "0x1881A7110", Slot = "10")]
	public void BEPFKEFGBCC(MFCJPIPOGCD BEIGFDDCGJI, Texture2D JDNNGPGPIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660")]
	public static bool NCLLHEINGNF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x81AE540", Offset = "0x81AD340", VA = "0x1881AE540", Slot = "11")]
	public bool IPLKFILODJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x81A4BF0", Offset = "0x81A39F0", VA = "0x1881A4BF0", Slot = "9")]
	public void AHNBALNGMMI(FOJFNEJOLLE FOPEMADPOPM, Color? BGBIPHDMBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x81AA0F0", Offset = "0x81A8EF0", VA = "0x1881AA0F0")]
	private void EBDNJBHIMCC(Action DMNCDJNLKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x81AE440", Offset = "0x81AD240", VA = "0x1881AE440", Slot = "6")]
	public void ILKCECIMGBL(GADJBANEMPG JGINHCPLLLI, Texture BBODGLKHELM, Color JCKOAPPCIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x81A76D0", Offset = "0x81A64D0", VA = "0x1881A76D0", Slot = "7")]
	public void CNCJKHKMGKD(bool FPDPMBMNKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xB21530", Offset = "0xB20330", VA = "0x180B21530", Slot = "8")]
	public void HJBCAAJDOKI(CJPLKIFIKIH ONHEEOKCMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x81A7AF0", Offset = "0x81A68F0", VA = "0x1881A7AF0", Slot = "16")]
	public void DAIKCBHPHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x81A6DD0", Offset = "0x81A5BD0", VA = "0x1881A6DD0", Slot = "36")]
	public void APILOHMGDHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x81A9120", Offset = "0x81A7F20", VA = "0x1881A9120", Slot = "37")]
	public void EADONCONLOC([Optional] NODDIPDIFHA AFCCIGJCPCP, [Optional] bool? EABCIDBKFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x81AF700", Offset = "0x81AE500", VA = "0x1881AF700")]
	private bool KOJCGCFNGAM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x81B1C50", Offset = "0x81B0A50", VA = "0x1881B1C50", Slot = "21")]
	public bool PPDENDGLIFJ(BCIIDHEJBAB.MMBHHGOHKAA COMAGLANBAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x81A74A0", Offset = "0x81A62A0", VA = "0x1881A74A0", Slot = "39")]
	public void BLJJCPEPNGG(float KDOOFOADDJE, Color BGBIPHDMBPB, bool BNEKIFFJLCJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x81B1030", Offset = "0x81AFE30", VA = "0x1881B1030")]
	public void OAPOOJIKBML(float KDOOFOADDJE, Color BGBIPHDMBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x81AF840", Offset = "0x81AE640", VA = "0x1881AF840")]
	private static bool LABABNGLIEJ(Material FJFGKPCPLNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x81B0C20", Offset = "0x81AFA20", VA = "0x1881B0C20", Slot = "40")]
	public void MPFJADHDPPG(ONLPNEDOIEI FFEPMJJOACP, ENMJNJAOGHF JHAHMAMIMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x81B0FE0", Offset = "0x81AFDE0", VA = "0x1881B0FE0")]
	private static bool NOCCJOIJHCM(MBFFLHEIAGD OPGJHIOADCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x81A83C0", Offset = "0x81A71C0", VA = "0x1881A83C0")]
	public void DHCIEHIOHMF(ONLPNEDOIEI JIBOOJPDOOP, ENMJNJAOGHF EKEGMIMLBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x81AF5D0", Offset = "0x81AE3D0", VA = "0x1881AF5D0", Slot = "38")]
	public void KLLMAJGOGLJ(bool KAJGMNGJNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x81ABF40", Offset = "0x81AAD40", VA = "0x1881ABF40")]
	private void FIPJONJMHOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x81AEAD0", Offset = "0x81AD8D0", VA = "0x1881AEAD0")]
	private void JKHHIIDMLFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x81A78D0", Offset = "0x81A66D0", VA = "0x1881A78D0")]
	private static void CLNLGECEDJC(Dictionary<MBFFLHEIAGD, Material> FDFJLNOBFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x81A8260", Offset = "0x81A7060", VA = "0x1881A8260")]
	private static void DFMAHAHOINN(Dictionary<Renderer, JJHEPAMDFNI> AMLBAIHMMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x81AD4A0", Offset = "0x81AC2A0", VA = "0x1881AD4A0")]
	private void HLACJHCDMCA(SkinnedMeshRenderer[] IJFDLHFCHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x81AEA30", Offset = "0x81AD830", VA = "0x1881AEA30")]
	private void JJAADHBAMKF(SkinnedMeshRenderer MKKELNAFDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x81B0D30", Offset = "0x81AFB30", VA = "0x1881B0D30")]
	private void NCDKAOAIMHF(List<JBJKHPALKPK> OAJILKJDKIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x81B19D0", Offset = "0x81B07D0", VA = "0x1881B19D0")]
	private void PLJPDFNFPLM(Dictionary<string, HNDICJJKNNH<Texture2D>> OKBODOGBGNF, bool LIBAIGBDJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x81AC640", Offset = "0x81AB440", VA = "0x1881AC640")]
	private void FOCMMOLHGMH(Dictionary<string, List<MBFFLHEIAGD>> OKBODOGBGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x81AC6D0", Offset = "0x81AB4D0", VA = "0x1881AC6D0")]
	private void GAGMFJDKJNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x81A9F60", Offset = "0x81A8D60", VA = "0x1881A9F60")]
	private void EBCDODALCKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x81ADE80", Offset = "0x81ACC80", VA = "0x1881ADE80")]
	private void ILJAIILPHBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x81B0A90", Offset = "0x81AF890", VA = "0x1881B0A90")]
	private void MKCOKKFMLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x81AFDA0", Offset = "0x81AEBA0", VA = "0x1881AFDA0")]
	private void LIDDKCNGOPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x81A8C00", Offset = "0x81A7A00", VA = "0x1881A8C00")]
	private void DNDOMBHIGKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x81B1520", Offset = "0x81B0320", VA = "0x1881B1520")]
	private void PDLBAAOLHHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x81AD150", Offset = "0x81ABF50", VA = "0x1881AD150")]
	private void HADDFGPNEIC(bool FDOGIFILBAK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x81A7600", Offset = "0x81A6400", VA = "0x1881A7600")]
	private void BMNKJPFLJEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x81B13B0", Offset = "0x81B01B0", VA = "0x1881B13B0")]
	private void OCKLLHFFKNC(bool FDOGIFILBAK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x81A8E00", Offset = "0x81A7C00", VA = "0x1881A8E00")]
	private void DPBNPPBBDII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x81B0150", Offset = "0x81AEF50", VA = "0x1881B0150")]
	private void LLMJLNIGHAB(Material FJFGKPCPLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x81AAB00", Offset = "0x81A9900", VA = "0x1881AAB00")]
	private void ENEPKMDHMDB(Material FJFGKPCPLNJ, Color GOEHOJJKAJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x81ACF10", Offset = "0x81ABD10", VA = "0x1881ACF10")]
	private void GOPAOOCBMBC(Material FJFGKPCPLNJ, Color GOEHOJJKAJG, Color IJONHFAIDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x81AFE30", Offset = "0x81AEC30", VA = "0x1881AFE30")]
	private void LIPDNMJJMOJ(Material FJFGKPCPLNJ, Color GOIKFANCJOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x81ACC40", Offset = "0x81ABA40", VA = "0x1881ACC40")]
	private void GJEGHDFPEGO(Material FJFGKPCPLNJ, Texture2D JDNNGPGPIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x81AFFF0", Offset = "0x81AEDF0", VA = "0x1881AFFF0")]
	private void LJGKBJJEIOA(Material FJFGKPCPLNJ, Texture AIBAFJLALAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x81B07E0", Offset = "0x81AF5E0", VA = "0x1881B07E0")]
	private void MFGKNPCGCHF(Action<JJHEPAMDFNI> MLEHFGJHGME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x81A6E30", Offset = "0x81A5C30", VA = "0x1881A6E30")]
	private void BAJLCAHIHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x81AF920", Offset = "0x81AE720", VA = "0x1881AF920")]
	private void LCCMGCANIBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x81AD5C0", Offset = "0x81AC3C0", VA = "0x1881AD5C0")]
	private void HMLLGLNIDHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x81AC100", Offset = "0x81AAF00", VA = "0x1881AC100")]
	public void FJLLILJBLAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x81AE950", Offset = "0x81AD750", VA = "0x1881AE950", Slot = "4")]
	private void JIFINDFBPKH([In] DCMBGIPAEDP MOKLKDFMMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x81AD2F0", Offset = "0x81AC0F0", VA = "0x1881AD2F0")]
	[CompilerGenerated]
	private BFMPGGMMDDD HAHFPBNNPCH(PBJIPPMPJIL EFDFIDCNFKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x81A7410", Offset = "0x81A6210", VA = "0x1881A7410")]
	[CompilerGenerated]
	private void BGHLNCGNBBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x81AFFC0", Offset = "0x81AEDC0", VA = "0x1881AFFC0")]
	[CompilerGenerated]
	private void LJAGKACMIIO(JJHEPAMDFNI MANEJALKGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x81AE4B0", Offset = "0x81AD2B0", VA = "0x1881AE4B0")]
	[CompilerGenerated]
	private void INAKICLLONC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x81B14F0", Offset = "0x81B02F0", VA = "0x1881B14F0")]
	[CompilerGenerated]
	private void OMJJFKPJHHD(JJHEPAMDFNI MANEJALKGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x81AD330", Offset = "0x81AC130", VA = "0x1881AD330")]
	[CompilerGenerated]
	private void HCMOHHKKNII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x81AD990", Offset = "0x81AC790", VA = "0x1881AD990")]
	[CompilerGenerated]
	private void HOABDJCOEMN(JJHEPAMDFNI MANEJALKGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x81AC5B0", Offset = "0x81AB3B0", VA = "0x1881AC5B0")]
	[CompilerGenerated]
	private void FNKKNENBLEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x81B1490", Offset = "0x81B0290", VA = "0x1881B1490")]
	[CompilerGenerated]
	private void OKLENIPBGBF(JJHEPAMDFNI MANEJALKGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x81AAA70", Offset = "0x81A9870", VA = "0x1881AAA70")]
	[CompilerGenerated]
	private void ENEIHBNJIGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x81AC690", Offset = "0x81AB490", VA = "0x1881AC690")]
	[CompilerGenerated]
	private void FOLACEJFHGL(JJHEPAMDFNI MANEJALKGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x81A76E0", Offset = "0x81A64E0", VA = "0x1881A76E0")]
	[CompilerGenerated]
	private void CECLHOAFJFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x81B0BE0", Offset = "0x81AF9E0", VA = "0x1881B0BE0")]
	[CompilerGenerated]
	private void MNIFCJILNKE(JJHEPAMDFNI MANEJALKGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x81A6D40", Offset = "0x81A5B40", VA = "0x1881A6D40")]
	[CompilerGenerated]
	private void APHJPBIOGEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x81A4BC0", Offset = "0x81A39C0", VA = "0x1881A4BC0")]
	[CompilerGenerated]
	private void ABPAAEKKIME(JJHEPAMDFNI MANEJALKGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x81B1C70", Offset = "0x81B0A70", VA = "0x1881B1C70")]
	[CompilerGenerated]
	private void PPPHHBONBPN(KeyValuePair<string, HNDICJJKNNH<Texture2D>> MFPABLKNCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x81B0C10", Offset = "0x81AFA10", VA = "0x1881B0C10")]
	[CompilerGenerated]
	private void MNNDCGACDJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x81B1000", Offset = "0x81AFE00", VA = "0x1881B1000")]
	[CompilerGenerated]
	private void OAPDMJGEHCB(JJHEPAMDFNI MANEJALKGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x81B1510", Offset = "0x81B0310", VA = "0x1881B1510")]
	[CompilerGenerated]
	private void PBDHOJFAJIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x81AF1F0", Offset = "0x81ADFF0", VA = "0x1881AF1F0")]
	[CompilerGenerated]
	private void KDNEFAMAJIK(JJHEPAMDFNI MANEJALKGLM)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarElbowBendHelperController : MonoBehaviour, NCDFCANDICB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[LAEBPIHCEIF(FBMDOBLPJCI.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[FormerlySerializedAs("MinScaleValues")]
		[SerializeField]
		[Header("Scale")]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[SerializeField]
		[FormerlySerializedAs("MaxScaleValues")]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[Header("Positional Offset")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private Vector3? FEDCDDHDJDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private bool EGKIOHKGOIJ;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x81BE880", Offset = "0x81BD680", VA = "0x1881BE880", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x81BEEA0", Offset = "0x81BDCA0", VA = "0x1881BEEA0", Slot = "4")]
		public void UpdateController(float GCGEIJPOBEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xDADAE0", Offset = "0xDAC8E0", VA = "0x180DADAE0", Slot = "6")]
		public void SetEnabled(bool HGMAIPELJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x81BE960", Offset = "0x81BD760", VA = "0x1881BE960")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x81BF2C0", Offset = "0x81BE0C0", VA = "0x1881BF2C0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AvatarElbowBendTargetController : MonoBehaviour, NCDFCANDICB
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private const float NICCEJPOHCF = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[LAEBPIHCEIF(FBMDOBLPJCI.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private Vector3 ANAELHGODPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private Vector3 FMPFAHBAJEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private bool EGKIOHKGOIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private float PCKIOHGMLGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private float NJEBNPKEDDJ;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x81BF640", Offset = "0x81BE440", VA = "0x1881BF640", Slot = "4")]
		public void UpdateController(float GCGEIJPOBEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x101CDA0", Offset = "0x101BBA0", VA = "0x18101CDA0", Slot = "6")]
		public void SetEnabled(bool HGMAIPELJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x81BF360", Offset = "0x81BE160", VA = "0x1881BF360")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x81C0100", Offset = "0x81BEF00", VA = "0x1881C0100")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class AFEKBAOOHIK : EDFBLEEALAN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private static readonly int LAIIEDDGEIB;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private static readonly int LPDGCGDEILD;

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private static readonly int LENFODNICMI;

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private static readonly int AFPDEIFJMFC;

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private static readonly int PGPEKCFPAEK;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private static readonly int KDHKGBIBBFP;

	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private static readonly int PPLIADDGEAH;

	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private static readonly int PHEHHELOJFM;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private static readonly int ONHMOJLDOFH;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private static readonly int ADIJDOIFHLD;

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private static readonly int LAGMMHIHFAI;

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static readonly int JDKBDGKIIJC;

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private static readonly int KELMHKCBGEI;

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private static readonly int DCMODMJAPGJ;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private static readonly int FEOBBFHFNAN;

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private static readonly int APEFEDIBKOO;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private static readonly int JIJLOFPLLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private Transform PHJHDLHGKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private Transform BKOMMKGAPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private Transform EBMNOGNGALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private Transform KABEHOJCPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private Transform DJCMENDOMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private Transform FOPDIELCMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private GOGGFHKAIAA AKEFFNFBFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private Material JGEDNJNNGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private SkinnedMeshRenderer[] DPHLOIBNICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly List<Material> HBBCJCHCNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private JMADJNPNEMM ADPOOCKBHKD;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public MKAEDPHCCBC DNJFIAEMIPH
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private JMADJNPNEMM BMHCCPIBLAH
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x81BCF00", Offset = "0x81BBD00", VA = "0x1881BCF00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool KOBMDGOKJFM
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x81BAF40", Offset = "0x81B9D40", VA = "0x1881BAF40", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x81BC650", Offset = "0x81BB450", VA = "0x1881BC650")]
	public void IEHCJBEIMLK([In] GOGGFHKAIAA NAODPFHJPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x81BC700", Offset = "0x81BB500", VA = "0x1881BC700")]
	public void IICKFCKKDDP([In] OCJDGMJKNPL COHHIEKGLGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x81BC050", Offset = "0x81BAE50", VA = "0x1881BC050", Slot = "6")]
	public void HGPFBLNDLCI(ECOBKGOJIDF NKEFKMLKIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x81BBFF0", Offset = "0x81BADF0", VA = "0x1881BBFF0")]
	private Vector2 FDIDLLJPMPD(Vector2 AFOEAFHPNJN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x81BB090", Offset = "0x81B9E90", VA = "0x1881BB090")]
	public void CLBJELDOIEI([In] AIOPPJOAMKI COHHIEKGLGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x81BC7A0", Offset = "0x81BB5A0", VA = "0x1881BC7A0")]
	private void JNFPEHLBIAC(EGBJPJADNLI FKDLMHFNOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x81BCB60", Offset = "0x81BB960", VA = "0x1881BCB60")]
	private void KHGAKJMICPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x81BBF80", Offset = "0x81BAD80", VA = "0x1881BBF80")]
	private void FNBIMMECONL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x81BBF80", Offset = "0x81BAD80", VA = "0x1881BBF80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x81BD2A0", Offset = "0x81BC0A0", VA = "0x1881BD2A0")]
	public AFEKBAOOHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x81BC700", Offset = "0x81BB500", VA = "0x1881BC700", Slot = "5")]
	private void JJEILKPNNCM([In] OCJDGMJKNPL COHHIEKGLGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x81BCF80", Offset = "0x81BBD80", VA = "0x1881BCF80", Slot = "7")]
	private void PADEAAACKBP([In] AIOPPJOAMKI COHHIEKGLGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x81BCEF0", Offset = "0x81BBCF0", VA = "0x1881BCEF0")]
	[CompilerGenerated]
	internal static float LHNNAMJKEKH(float HGMAIPELJHM, float GEHBABBAODJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x81BC560", Offset = "0x81BB360", VA = "0x1881BC560")]
	[CompilerGenerated]
	internal static void HLJJICNJKLA(Vector2 ONBPAFAGNCF, Vector2 HJIOGBMHFKN, Vector2 BCMFMCHGEKF, Vector2 OLBFNPPONEB, Vector2 ANDCPDPHMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x81BCF90", Offset = "0x81BBD90", VA = "0x1881BCF90")]
	[CompilerGenerated]
	internal static Vector4 PBNLPEEGCAO(Vector2 FLAPAOJCDCM, Vector2 KBAEKIALOKB)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class AvatarForearmRollController : MonoBehaviour, NCDFCANDICB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private float PCKIOHGMLGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private bool EGKIOHKGOIJ;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x81C0130", Offset = "0x81BEF30", VA = "0x1881C0130", Slot = "4")]
		public void UpdateController(float GCGEIJPOBEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x105E950", Offset = "0x105D750", VA = "0x18105E950", Slot = "6")]
		public void SetEnabled(bool HGMAIPELJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x81C0990", Offset = "0x81BF790", VA = "0x1881C0990")]
		public AvatarForearmRollController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class AvatarHandDisplaySettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class AnimationOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x81C0A30", Offset = "0x81BF830", VA = "0x1881C0A30")]
		public void MHDKBDCHLCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x81C09C0", Offset = "0x81BF7C0", VA = "0x1881C09C0")]
		public int CHNPPBMGONK(int HGJABFBKDDH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class CCPCLKELKAE : LIELHDCBNON
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x81C2D20", Offset = "0x81C1B20", VA = "0x1881C2D20", Slot = "24")]
	public override float ILILPLKHMNI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x81C2D70", Offset = "0x81C1B70", VA = "0x1881C2D70")]
	public CCPCLKELKAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class LIELHDCBNON : ELMDBEFEDJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static int CHIGAKKGCFN;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static int KIKNLKMFDKF;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private static int OKFGJNFABJM;

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static int JAEKMPBJOKI;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static int DFPNOEFIIPB;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static int JAOEEEDGNAN;

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private static int OELGLELNKOD;

	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private static int[] DNJFJJIECNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private DBIIODGJHIP AKEFFNFBFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private BNHOFFIMOIG OBKKHPKOFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private int BPPAKOIMCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private float PBCMAACFLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	protected Animator EKHAMMMDOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	protected AvatarConfiguration FNCPPOFAIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	protected int PAFEFJAALEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int MELLCOMJJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int EJPDJEFFJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private bool PDEGDNNFNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private INJFKIDICAL GBDNKCBPPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private int BMJADMHHBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private float NOELGKBMMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private AvatarHandDisplaySettings IJPLLEBPHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private JLFDMKNKLIE OBGPCKKHHAI;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform KOHCBOLFLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Vector3 JJEJHLHOCFO
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x19846F0", Offset = "0x19834F0", VA = "0x1819846F0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x19847B0", Offset = "0x19835B0", VA = "0x1819847B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Quaternion BNPKJIGCCKF
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xEA1490", Offset = "0xEA0290", VA = "0x180EA1490")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x10A7600", Offset = "0x10A6400", VA = "0x1810A7600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool HPJFPCJMPBM
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x81CE4F0", Offset = "0x81CD2F0", VA = "0x1881CE4F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x81CE930", Offset = "0x81CD730", VA = "0x1881CE930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool PGMPFCFEFPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xB1E570", Offset = "0xB1D370", VA = "0x180B1E570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Vector3 OFBPMEFMHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xAC0B40", Offset = "0xABF940", VA = "0x180AC0B40", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xAC1080", Offset = "0xABFE80", VA = "0x180AC1080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Quaternion NEPOBMNAMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x1284C40", Offset = "0x1283A40", VA = "0x181284C40", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x1715310", Offset = "0x1714110", VA = "0x181715310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public NCBHKEPILOG ENNOKPEBKKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xB4DEA0", Offset = "0xB4CCA0", VA = "0x180B4DEA0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return default(NCBHKEPILOG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xB4D720", Offset = "0xB4C520", VA = "0x180B4D720", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public NCBHKEPILOG KGOKKHGIEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xB4DE90", Offset = "0xB4CC90", VA = "0x180B4DE90", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(NCBHKEPILOG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xB4D540", Offset = "0xB4C340", VA = "0x180B4D540", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float CJFKEJDOPKG
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xC010D0", Offset = "0xBFFED0", VA = "0x180C010D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x10B0B90", Offset = "0x10AF990", VA = "0x1810B0B90", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool BHEJGIKFHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x81CEFD0", Offset = "0x81CDDD0", VA = "0x1881CEFD0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x81CF010", Offset = "0x81CDE10", VA = "0x1881CF010", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool AIJCNDOPGBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x81CEC30", Offset = "0x81CDA30", VA = "0x1881CEC30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool GAMOKOCACIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x81CE5B0", Offset = "0x81CD3B0", VA = "0x1881CE5B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool OHHILPFGLEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x81CEA60", Offset = "0x81CD860", VA = "0x1881CEA60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool KBNFBPICEDP
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x81CEC40", Offset = "0x81CDA40", VA = "0x1881CEC40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x81CEA90", Offset = "0x81CD890", VA = "0x1881CEA90", Slot = "23")]
	public void IEHCJBEIMLK(DBIIODGJHIP NAODPFHJPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x81CE960", Offset = "0x81CD760", VA = "0x1881CE960")]
	public void CBJNOKFPNLA(BNHOFFIMOIG PAKFCFMEHHB, AvatarHandDisplaySettings KOEIEIJLGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x81CE520", Offset = "0x81CD320", VA = "0x1881CE520", Slot = "14")]
	public void AHEMDPGOAFO(bool BNIEEGBIIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x81CE5C0", Offset = "0x81CD3C0", VA = "0x1881CE5C0", Slot = "13")]
	public void BDGPOLJDAEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0xC010D0", Offset = "0xBFFED0", VA = "0x180C010D0", Slot = "24")]
	public virtual float ILILPLKHMNI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x81CEE50", Offset = "0x81CDC50", VA = "0x1881CEE50")]
	private int NFEKIHKPOOH(NCBHKEPILOG NPEHIHDFGBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x81CEC90", Offset = "0x81CDA90", VA = "0x1881CEC90")]
	private void MAIEDCELJDN(int PFJGJDNOFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x81CEFE0", Offset = "0x81CDDE0", VA = "0x1881CEFE0", Slot = "15")]
	public bool OKNJHOBLDIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x81CF000", Offset = "0x81CDE00", VA = "0x1881CF000", Slot = "16")]
	public bool PGKOIKMBEMJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x81CE9B0", Offset = "0x81CD7B0", VA = "0x1881CE9B0")]
	private NCBHKEPILOG DGCLNKGAGFK()
	{
		return default(NCBHKEPILOG);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x1F168A0", Offset = "0x1F156A0", VA = "0x181F168A0", Slot = "17")]
	public void HBFIHEKPJCA(bool BNIEEGBIIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x81CEC50", Offset = "0x81CDA50", VA = "0x1881CEC50", Slot = "12")]
	public void LCOILNIPCJH(int PFJGJDNOFHP, float BIAFMLAMEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x81CEA70", Offset = "0x81CD870", VA = "0x1881CEA70", Slot = "10")]
	public void FHJBPDHEMNK(INJFKIDICAL GKGDEKNIOCH, bool HEPPDGLDFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x81CEA50", Offset = "0x81CD850", VA = "0x1881CEA50", Slot = "11")]
	public void EEPMMMIJEPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x81CEA00", Offset = "0x81CD800", VA = "0x1881CEA00", Slot = "18")]
	public void EDKIIDIEDIP(Transform PJGOIMBEKPK, Vector3 HHEEJOFPFBC, Quaternion OFFHDCPBEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x81CF2B0", Offset = "0x81CE0B0", VA = "0x1881CF2B0")]
	public LIELHDCBNON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class DHGCFBOFHFJ : PBJIPPMPJIL
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class NJLBHJHIADF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public DHGCFBOFHFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public List<JBJKHPALKPK> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public List<JBJKHPALKPK> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public HNDICJJKNNH<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public HNDICJJKNNH<DBJFKBLCELM> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public NJLBHJHIADF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x81CFD00", Offset = "0x81CEB00", VA = "0x1881CFD00")]
		internal BFMPGGMMDDD KHCHABHFMCG(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public GADJBANEMPG EMBBFCENNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public DBJFKBLCELM LEBHAHEJHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private HNDICJJKNNH<DBJFKBLCELM> FKKIKPCNIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private HNDICJJKNNH<Material[]> ENLMMEBECAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public Material[] AMECDNMAFCG;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool AEFNBFHPOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xAC2580", Offset = "0xAC1380", VA = "0x180AC2580")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xAC2300", Offset = "0xAC1100", VA = "0x180AC2300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public BCIIDHEJBAB.MMBHHGOHKAA FEBBNIMBJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		[CompilerGenerated]
		get
		{
			return default(BCIIDHEJBAB.MMBHHGOHKAA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xAA2020", Offset = "0xAA0E20", VA = "0x180AA2020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x81C4F30", Offset = "0x81C3D30", VA = "0x1881C4F30")]
	public DHGCFBOFHFJ(PGMODLDJKOM OKIGJAEMCJK, GADJBANEMPG EFJPIKIIDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x81C3CF0", Offset = "0x81C2AF0", VA = "0x1881C3CF0", Slot = "6")]
	public override BFMPGGMMDDD BKPJOHKGCEC(List<JBJKHPALKPK> COLDFAJDFAF, List<JBJKHPALKPK> BCCFCFNIJJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x81C4730", Offset = "0x81C3530", VA = "0x1881C4730")]
	public BFMPGGMMDDD KDDKAELOELE(List<JBJKHPALKPK> COLDFAJDFAF, List<JBJKHPALKPK> BCCFCFNIJJB, HNDICJJKNNH<Material[]> ENLMMEBECAE, [Optional] HNDICJJKNNH<DBJFKBLCELM> PPPMOPFCJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x81C43A0", Offset = "0x81C31A0", VA = "0x1881C43A0")]
	public (HNDICJJKNNH<Material[]>, HNDICJJKNNH<DBJFKBLCELM>) JBNKBEJMFNP(List<JBJKHPALKPK> COLDFAJDFAF, List<JBJKHPALKPK> BCCFCFNIJJB)
	{
		return default((HNDICJJKNNH<Material[]>, HNDICJJKNNH<DBJFKBLCELM>));
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x81C4A30", Offset = "0x81C3830", VA = "0x1881C4A30", Slot = "7")]
	public override NFFHKHDDAGJ KEEJICIIOIM(uint GOLHBMLDEPN, AvatarSkinnedMeshBoneOrderRemapsData DBIPCOFOJLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x81C4190", Offset = "0x81C2F90", VA = "0x1881C4190")]
	public NFFHKHDDAGJ GBDIDEFFIEB(GameObject LGOOFDMENBN, uint GOLHBMLDEPN, bool ENIHGKEIPPF, bool IFJLJBLAPHB, AvatarSkinnedMeshBoneOrderRemapsData DBIPCOFOJLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x81C4B60", Offset = "0x81C3960", VA = "0x1881C4B60")]
	public static bool MJNMFJGCMNA(Renderer[] IJFDLHFCHJH, string DEENMABNPLE, [Out] Renderer OENDKFBIKIN, [Out] Renderer BHGNPIKAJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x81C4EE0", Offset = "0x81C3CE0", VA = "0x1881C4EE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x81C3C20", Offset = "0x81C2A20", VA = "0x1881C3C20")]
	private (HNDICJJKNNH<DBJFKBLCELM>, HNDICJJKNNH<Material[]>) BFBAMFIOGNH()
	{
		return default((HNDICJJKNNH<DBJFKBLCELM>, HNDICJJKNNH<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x81C4EC0", Offset = "0x81C3CC0", VA = "0x1881C4EC0")]
	[CompilerGenerated]
	private void PGPJIMNHJFC(DBJFKBLCELM MOBFLOHJOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0xA931E0", Offset = "0xA91FE0", VA = "0x180A931E0")]
	[CompilerGenerated]
	private void JCMDNADBJCA(Material[] MOBFLOHJOKJ)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class AvatarKneeBendTargetController : MonoBehaviour, NCDFCANDICB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		[LAEBPIHCEIF(FBMDOBLPJCI.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private Vector3 ANAELHGODPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private Vector3 LKLBEFDGFDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private Vector3 GAHFJOEBAGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private Matrix4x4 KCOIGHMFIGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private bool EGKIOHKGOIJ;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x81C0FC0", Offset = "0x81BFDC0", VA = "0x1881C0FC0", Slot = "4")]
		public void UpdateController(float GCGEIJPOBEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x81C0FB0", Offset = "0x81BFDB0", VA = "0x1881C0FB0", Slot = "6")]
		public void SetEnabled(bool HGMAIPELJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x81C0B50", Offset = "0x81BF950", VA = "0x1881C0B50")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x81C1680", Offset = "0x81C0480", VA = "0x1881C1680")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[CMNOLHHFBOP]
public struct JDBEKCGCCLK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[ReadOnly]
	public JOLEFOKNIHO MMLOLGOHIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[ReadOnly]
	public int FOCCBAELIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public AKEPAJEDMMO JKCAJNOJDGE;

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x81C6240", Offset = "0x81C5040", VA = "0x1881C6240", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[NativeContainer]
[CMNOLHHFBOP]
public struct AKEPAJEDMMO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeArray<Vector3> OLCDGMKBEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public NativeArray<Vector3> CAAODMLAKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeArray<Vector4> OLJEKNPJLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<Vector2> EOBJCAJELBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<Vector2> IIEPCHFNOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeArray<Vector2> JGAOEPJKLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeArray<Vector2> GHIHLOOIOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeArray<Color> DPKJDGHHPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeArray<int> OKPBIIKLGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeArray<int> IFBLBHPHPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private NativeArray<int> JFKNCOAMJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private NativeArray<int> KDHNNNEKNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeArray<int> OLHJHDEKHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeArray<int> FHLFEBMLDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeArray<int> AOIDAJMJPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public NativeArray<BoneWeight> ELBMJKKLDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private NativeArray<int> ONHEEOKCMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private bool INELPJMLLHN;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int JGKKMPGBDCK
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x81BDB60", Offset = "0x81BC960", VA = "0x1881BDB60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x81BDB70", Offset = "0x81BC970", VA = "0x1881BDB70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int LIMHPDHIPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x81BDF00", Offset = "0x81BCD00", VA = "0x1881BDF00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x81BDBD0", Offset = "0x81BC9D0", VA = "0x1881BDBD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int FMNMGJMFEEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x81BE2B0", Offset = "0x81BD0B0", VA = "0x1881BE2B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x81BDC70", Offset = "0x81BCA70", VA = "0x1881BDC70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x81BE2C0", Offset = "0x81BD0C0", VA = "0x1881BE2C0")]
	public AKEPAJEDMMO(int FGHICNHGHGB, int IJJGCKDBPNA, int LDNDBBFKPNL, int HJCJPJEPPHC, Allocator GIEDOJCOPKP, int NKOMEABIGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x81BDBE0", Offset = "0x81BC9E0", VA = "0x1881BDBE0")]
	public void GIDJIJJJNOH(int JJJJBEGKNIN, Vector3 MHBJBKNNPOK, Vector3 DPBDKFEONOK, Vector4 DDCPKPIHIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x81BDD50", Offset = "0x81BCB50", VA = "0x1881BDD50")]
	public void IGCMLKMLBDI(int JJJJBEGKNIN, BoneWeight LNNEPGHGMEL, NativeSlice<byte> EGAPAKLBHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x81BDF10", Offset = "0x81BCD10", VA = "0x1881BDF10")]
	public Color KBDNEKDCIHM(int JJJJBEGKNIN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x81BDC50", Offset = "0x81BCA50", VA = "0x1881BDC50")]
	public void GOFKBCCDKNA(int JJJJBEGKNIN, Color JMOOEAFLFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x81BDB80", Offset = "0x81BC980", VA = "0x1881BDB80")]
	public void FONDGIKKIPO(byte LGBMOBOFHFN, int JJJJBEGKNIN, Vector2 EEIDJALLCBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x81BDEF0", Offset = "0x81BCCF0", VA = "0x1881BDEF0")]
	public void IICJJEBJJDM(int JJJJBEGKNIN, int DMOBFBGAGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x81BDF30", Offset = "0x81BCD30", VA = "0x1881BDF30")]
	public bool NPBAGFDOMIP(int LGBMOBOFHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x81BDC80", Offset = "0x81BCA80", VA = "0x1881BDC80")]
	public void IELBBJGAHEC(int JFIKOCLBAKH, int IBOFMHFOKKF, int MCJGICKIGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x81BD870", Offset = "0x81BC670", VA = "0x1881BD870")]
	public int[] AGPPDNFELFO(int JFIKOCLBAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x81BDAD0", Offset = "0x81BC8D0", VA = "0x1881BDAD0")]
	private NativeSlice<int> ENAOAONMMPM(int JFIKOCLBAKH)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x81BD920", Offset = "0x81BC720", VA = "0x1881BD920", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x81BDF60", Offset = "0x81BCD60", VA = "0x1881BDF60")]
	public Mesh PALJIPCNJPO([Optional] string HOEJBHEEBOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[CMNOLHHFBOP]
[DefaultMember("Item")]
[NativeContainer]
public struct JOLEFOKNIHO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public NativeArray<Vector3> OLCDGMKBEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public NativeArray<Vector3> CAAODMLAKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public NativeArray<Vector4> OLJEKNPJLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public NativeArray<Vector2> EOBJCAJELBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public NativeArray<Vector2> IIEPCHFNOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public NativeArray<Vector2> JGAOEPJKLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public NativeArray<Vector2> GHIHLOOIOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public NativeArray<Color> DPKJDGHHPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public NativeArray<int> GBCJDJDKNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public NativeArray<int> DNDIHNIOBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public NativeArray<int> CMFENJOMBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public NativeArray<int> DBBBJOEIPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public NativeArray<bool> HGEPLHIBCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public NativeArray<int> DHNEDKNOHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public NativeArray<int> CODCKMFCALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeArray<BoneWeight> HLGAADGFIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private NativeArray<Matrix4x4> LMPNGBPAFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private NativeArray<long> NHEOEHIGDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private NativeArray<byte> PDINFEBCACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private NativeArray<int> DJODDAAEOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private NativeArray<int> OGKACEFKFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public NativeArray<sbyte> LKKJDOFMGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public NativeArray<byte> ACCFLKAEBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private NativeArray<int> CAHHJMNAFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private bool INELPJMLLHN;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int AEFKEJJDGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xF5B8C0", Offset = "0xF5A6C0", VA = "0x180F5B8C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int OMMOPPGCEFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xDB0A50", Offset = "0xDAF850", VA = "0x180DB0A50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int IJAKKCICKEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x81CABB0", Offset = "0x81C99B0", VA = "0x1881CABB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int KAJEKFFHPEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x81CAB90", Offset = "0x81C9990", VA = "0x1881CAB90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x81CABF0", Offset = "0x81C99F0", VA = "0x1881CABF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int JGKKMPGBDCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x81CAB70", Offset = "0x81C9970", VA = "0x1881CAB70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x81CAB80", Offset = "0x81C9980", VA = "0x1881CAB80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int FMJGADKGNIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x81CAC10", Offset = "0x81C9A10", VA = "0x1881CAC10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x81CA810", Offset = "0x81C9610", VA = "0x1881CA810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public DGLGBOIILAC NCFFMECKFEM
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x81CABA0", Offset = "0x81C99A0", VA = "0x1881CABA0")]
		get
		{
			return default(DGLGBOIILAC);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x81CAC00", Offset = "0x81C9A00", VA = "0x1881CAC00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public byte ECBFPBENFAO
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x81CABE0", Offset = "0x81C99E0", VA = "0x1881CABE0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x81CA820", Offset = "0x81C9620", VA = "0x1881CA820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public AGLPJGPFFOF ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x81CA2E0", Offset = "0x81C90E0", VA = "0x1881CA2E0")]
		get
		{
			return default(AGLPJGPFFOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x81CAC20", Offset = "0x81C9A20", VA = "0x1881CAC20")]
	public JOLEFOKNIHO(IList<Mesh> KHJBGGHKJFO, IList<Matrix4x4> KNGFDFAJCCL, IList<bool> HGEPLHIBCBG, byte NNEDKNMKPIN, IList<byte[]> LOHLIBFPIEO, IList<long> AOMJGELIION, IList<bool> JMGBCBHPIIO, IList<int> DHNEDKNOHGH, IList<int> HGAOJKNHIKD, IList<int> DEPCGJPGPBC, Allocator GIEDOJCOPKP, DGLGBOIILAC ELMOINEPNFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x81CAAA0", Offset = "0x81C98A0", VA = "0x1881CAAA0")]
	public AKEPAJEDMMO EFEDEDMAKJO(Allocator GIEDOJCOPKP)
	{
		return default(AKEPAJEDMMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x81CA830", Offset = "0x81C9630", VA = "0x1881CA830", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[CMNOLHHFBOP]
public class MMNGAKJBPGB : DNNOLDECPPB
{
	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x81CFC10", Offset = "0x81CEA10", VA = "0x1881CFC10")]
	public JOLEFOKNIHO GNGFEIIBNFD()
	{
		return default(JOLEFOKNIHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x81B8630", Offset = "0x81B7430", VA = "0x1881B8630")]
	public MMNGAKJBPGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct AGLPJGPFFOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public NativeSlice<Vector3> OLCDGMKBEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public NativeSlice<Vector3> CAAODMLAKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public NativeSlice<Vector4> OLJEKNPJLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public NativeSlice<Vector2> EOBJCAJELBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	public NativeSlice<Vector2> IIEPCHFNOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	public NativeSlice<Vector2> JGAOEPJKLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public NativeSlice<Vector2> GHIHLOOIOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public NativeSlice<Color> DPKJDGHHPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public NativeSlice<int> CKCFKOLKFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public NativeSlice<int> DBBBJOEIPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public NativeSlice<BoneWeight> HLGAADGFIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public NativeSlice<byte> GGNIAMOPOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public int OFDJDIPHFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public Matrix4x4 LEBLPNNMLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public long FKGKCGDCIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public NativeSlice<byte> EGAPAKLBHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public bool FBDIBONGICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public int DBHFIBOKMMJ;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal readonly struct MBFFLHEIAGD : IEquatable<MBFFLHEIAGD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	internal readonly Material FJEHDIIFJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	internal readonly GNIJEKPFBKC CPNMCJIGJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	internal readonly OAIBKIMFJOG JOOPGPKBHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	internal readonly PGMODLDJKOM ALGBMMFFJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	internal readonly bool AGDIEDFIKJC;

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x81CF810", Offset = "0x81CE610", VA = "0x1881CF810")]
	public MBFFLHEIAGD(Material GKIFPALLDIK, GNIJEKPFBKC LDFBMIIMOMB, OAIBKIMFJOG FEMFKDHLAOB, PGMODLDJKOM DPNGCNNOBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x81CF570", Offset = "0x81CE370", VA = "0x1881CF570", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x81CF2D0", Offset = "0x81CE0D0", VA = "0x1881CF2D0", Slot = "4")]
	public bool Equals(MBFFLHEIAGD FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x81CF360", Offset = "0x81CE160", VA = "0x1881CF360", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x81CF460", Offset = "0x81CE260", VA = "0x1881CF460", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, GLEHLDHLKFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[Header("Configuration")]
		[SerializeField]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[Header("Configuration")]
		[SerializeField]
		private JLFDMKNKLIE avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		private AssetReference torsoModestyAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		private AssetReference legsModestyAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		private AssetReference torsoValidationAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		private GameObject allBodyMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		[FormerlySerializedAs("BodyMaterial")]
		private Material BodyMaterialSkinGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[SerializeField]
		private Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[SerializeField]
		private Material ModestyAndValidationMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private FCEMHMOCEFP HBJHBEHIBFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private EDFBLEEALAN OIDBKAMLNGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private ELMDBEFEDJJ CPANCJHMHLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private ELMDBEFEDJJ IEMIELGHOKN;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public FCEMHMOCEFP JHJGFMCFHJE
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x81C2660", Offset = "0x81C1460", VA = "0x1881C2660", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public EDFBLEEALAN CHGFBPCCMBK
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x81C26B0", Offset = "0x81C14B0", VA = "0x1881C26B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public ELMDBEFEDJJ EJAMPLFEAKI
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x81C2700", Offset = "0x81C1500", VA = "0x1881C2700", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public ELMDBEFEDJJ FAOMJFLPCPI
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x81C2750", Offset = "0x81C1550", VA = "0x1881C2750", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Transform CGCOEIEGHIM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x81C27A0", Offset = "0x81C15A0", VA = "0x1881C27A0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public JLFDMKNKLIE MMCOGLIKBED
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xAA2200", Offset = "0xAA1000", VA = "0x180AA2200", Slot = "12")]
			get
			{
				return default(JLFDMKNKLIE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x81C1920", Offset = "0x81C0720", VA = "0x1881C1920")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x81C24C0", Offset = "0x81C12C0", VA = "0x1881C24C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x81C2140", Offset = "0x81C0F40", VA = "0x1881C2140", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x81C24C0", Offset = "0x81C12C0", VA = "0x1881C24C0", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x81C1960", Offset = "0x81C0760", VA = "0x1881C1960", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x81C2570", Offset = "0x81C1370", VA = "0x1881C2570")]
		public void UpdatePostIKAnimControllers(float GCGEIJPOBEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x81C1C90", Offset = "0x81C0A90", VA = "0x1881C1C90")]
		private void DGLGBOGBCFK(GameObject ALGAKMGCCLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x81C1D20", Offset = "0x81C0B20", VA = "0x1881C1D20")]
		private FCEMHMOCEFP HBCBLCJHHLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x81C2180", Offset = "0x81C0F80", VA = "0x1881C2180")]
		private EDFBLEEALAN LGMAAOFNMAH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x81C1690", Offset = "0x81C0490", VA = "0x1881C1690")]
		private ELMDBEFEDJJ AALNIKDKCJH(ABAOCJDIGCP AGCFIFCPCDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x81C2650", Offset = "0x81C1450", VA = "0x1881C2650")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class JJHEPAMDFNI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private MaterialPropertyBlock EMMBAGIIEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public Color? PAAFFIJOBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public Color? BHCAEPJJNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public Color? EAGBKKPNFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public Color? HINEAJHKLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public Color HMBCPGNFNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public Color EIIGGOOADIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public Color IMBFIGGJDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public float GCGBDEDOIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public Texture2D OJPGENMELPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public Texture2D DOEAIJDDNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private Dictionary<MBFFLHEIAGD, int> ONKOAOCBJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private GNIJEKPFBKC[] KBHHOGOKHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private OAIBKIMFJOG[] GKLKEFHBEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public Vector4[] ANJLBMHLIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public Vector4[] FICKEMBAOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public Vector4[] EABAFLDIADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public Vector4[] MIAEINIGFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public Vector4[] PPBCLJEAFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public Vector4[] ODPMIAHNIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private List<Texture2D> CGBCCCIBALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private Vector4[] JPPLBCKGGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private List<Texture2D> HFJEMBLJHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private float[] LEBIHFIJBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private Vector4[] LGNPEDHJNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private float[] GCOIEAPELND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public float[] GIOCNIFAKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private List<Texture2D> NDMNPIAFAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private float[] CPNPFNIJNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private List<Texture2D> HCLKJJNBCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private Vector4[] PAMMNJACJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private float[] IJECOMJNPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private Vector4[] CJNCHFGLHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public float[] JFEDCHINNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public Texture2DArray JIADMMKIMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public Texture2DArray KJADBMMMDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public Texture2DArray HOEIJCFIPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public Texture2DArray IEKPMGPOCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private bool FOFMNPFDLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private int DJCMCJMBIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private Vector2? PJPMABJHPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private TextureFormat BMJIHIGAOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private Vector2? OGLEKFOBPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private TextureFormat HGNPCLDMKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private Vector2? OACFJDDGBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private TextureFormat HMDPFBMHBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private Vector2? LFNNMMKBKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private TextureFormat OOLGPKGPPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private bool PJLPIIDDCCN;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	private static int MIJMECPNLIF;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	private static int KOPHGHFCMED;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	private static int OLCEPCAHKOF;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	private static int JEGNJCEAOFC;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private static int MHDFHMOLHEN;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private static int LPFMDKPMPNC;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private static int HDGAHNDNCDF;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	private static int MOJEJDBNPHF;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private static int DGGGLCJGKEC;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	private static int LEEEMICCEOF;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private static int BPEBMNKJNGA;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private static int JCFPFPNJOMB;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	private static int JFMMMCGMGNM;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private static int DEANLCBCILD;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private static int HMNJPCJOJLF;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private static int LJHEENNFDMO;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private static int CNGBPHGCDDN;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private static int IIMPDIIOPNL;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private static int GDNNDKGALKK;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private static int LHHGFNGEJBN;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x81C9DE0", Offset = "0x81C8BE0", VA = "0x1881C9DE0")]
	private JJHEPAMDFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x81C9D20", Offset = "0x81C8B20", VA = "0x1881C9D20")]
	public JJHEPAMDFNI(Color GICOGPHOODF, Color OOHBLOOLOIH, Color IEMHNMOOMFL, Color? NCOLHMCFMFL, Color? CDELEDBGAJI, Color? ODKHAOGIPIP, Texture2D CHPNEMPBBKE, Texture2D AFMHEEBHHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x81C92A0", Offset = "0x81C80A0", VA = "0x1881C92A0")]
	internal int JGHNELGDPLD(Material JOIMGIKOLGG, GNIJEKPFBKC LDFBMIIMOMB, OAIBKIMFJOG FEMFKDHLAOB, PGMODLDJKOM DPNGCNNOBCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x81C9370", Offset = "0x81C8170", VA = "0x1881C9370")]
	private int JGHNELGDPLD(MBFFLHEIAGD OPGJHIOADCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x81C8540", Offset = "0x81C7340", VA = "0x1881C8540")]
	internal int DDFCBBBBDBB(Material JOIMGIKOLGG, Color GOIKFANCJOE, Color JDJDHGJABHK, Color BKANIHANBND, Color PBIBBJDLFFO, Color KJIBDFAENCC, Texture2D NOLKJJANDFA, Vector4 JNGGAJPHGGK, Texture2D BPOPNCINFGJ, Vector4 HOBABBHOCAG, float OMFOOFIBLLO, float ADGLGFBDILJ, Texture2D LIJHJCGMAMH, Vector4 MECAPDGKCBJ, float GEMKIMAPDEN, Texture2D BABBPGHHLPI, Color ABKEPHAAPKB, Vector4 PPHGBKNPNAD, GNIJEKPFBKC LDFBMIIMOMB, OAIBKIMFJOG FEMFKDHLAOB, PGMODLDJKOM DPNGCNNOBCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x81C9810", Offset = "0x81C8610", VA = "0x1881C9810")]
	private void OMEHLPEAHME(List<Texture2D> CGBCCCIBALJ, [Out] Texture2DArray NMDECLHPJDA, [Out] Texture2DArray LNLEDPONLGF, [Out] Texture2DArray EABMPKNNDPD, [Out] Texture2DArray DINCEHLJIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x81C83F0", Offset = "0x81C71F0", VA = "0x1881C83F0")]
	public void CECKGNEFPAB(Shader AGPGJIACCNK, Renderer NNEJGKAIJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x81C7730", Offset = "0x81C6530", VA = "0x1881C7730")]
	private void CDICHCGHEFN(Shader AGPGJIACCNK, Renderer NNEJGKAIJNN, int FHGBOBFOBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x81C9610", Offset = "0x81C8410", VA = "0x1881C9610")]
	private Color NBNBJCDDJDP(Color DNFJHKPCCKJ, GNIJEKPFBKC FOPEMADPOPM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x81C9150", Offset = "0x81C7F50", VA = "0x1881C9150")]
	private Color GIMNPDLMOGM(Color DJHLPJIAOMH, GNIJEKPFBKC FOPEMADPOPM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x81C94B0", Offset = "0x81C82B0", VA = "0x1881C94B0")]
	private bool LDCBFPALAFN(Texture2D MEFMKFIJHBC, OAIBKIMFJOG BEIGFDDCGJI, [Out] Texture2D IKLLDNPNMJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x81C9400", Offset = "0x81C8200", VA = "0x1881C9400")]
	private void KLHBPEKGJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x81C9110", Offset = "0x81C7F10", VA = "0x1881C9110", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class PBJIPPMPJIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public readonly PGMODLDJKOM BICAFJOGBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	protected bool BJOKEPOKMIF;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool AMPKLMPFMMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xB7BC50", Offset = "0xB7AA50", VA = "0x180B7BC50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xB7BBD0", Offset = "0xB7A9D0", VA = "0x180B7BBD0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool ILICFJAGDEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xB7BC30", Offset = "0xB7AA30", VA = "0x180B7BC30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xB7BC40", Offset = "0xB7AA40", VA = "0x180B7BC40")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public virtual BCIIDHEJBAB.MMBHHGOHKAA FKGKCGDCIPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(BCIIDHEJBAB.MMBHHGOHKAA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xE04750", Offset = "0xE03550", VA = "0x180E04750", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool BPNDJINMIGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x1594640", Offset = "0x1593440", VA = "0x181594640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool LGCHGHNAHEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x81CFF40", Offset = "0x81CED40", VA = "0x1881CFF40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool BBEAMAOPFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x81CFF50", Offset = "0x81CED50", VA = "0x1881CFF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool DNEPNFDKKHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x81CFF60", Offset = "0x81CED60", VA = "0x1881CFF60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x81CFF80", Offset = "0x81CED80", VA = "0x1881CFF80")]
	protected PBJIPPMPJIL(PGMODLDJKOM OKIGJAEMCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract BFMPGGMMDDD BKPJOHKGCEC(List<JBJKHPALKPK> COLDFAJDFAF, List<JBJKHPALKPK> BCCFCFNIJJB);

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract NFFHKHDDAGJ KEEJICIIOIM(uint GOLHBMLDEPN, AvatarSkinnedMeshBoneOrderRemapsData DBIPCOFOJLN);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class KGFDOGIBDKK : HEHAFFBCGDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private AvatarSkinAssetItem HNLGEBKHDGL;

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x81CC720", Offset = "0x81CB520", VA = "0x1881CC720")]
	public KGFDOGIBDKK(AvatarSkinAssetItem IHGALNJLFJC, AvatarSkinAssetItem.ONGODKLFOLL MMHIJGEMDKI, PGMODLDJKOM DPNGCNNOBCC, [Optional] NJKDBAMDGPL? EELGNKMNPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x81CC4C0", Offset = "0x81CB2C0", VA = "0x1881CC4C0", Slot = "6")]
	public override BFMPGGMMDDD BKPJOHKGCEC(List<JBJKHPALKPK> COLDFAJDFAF, List<JBJKHPALKPK> BCCFCFNIJJB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class DOEGHLJLPLM
{
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private static readonly int[] PDDBNKFGOMN;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private static readonly int[] NKLDFOMODMG;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static int[] CEOLMDEBGBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x81C5050", Offset = "0x81C3E50", VA = "0x1881C5050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x81C4FA0", Offset = "0x81C3DA0", VA = "0x1881C4FA0")]
	public static int[] CLFKLGPFILM(bool KJMGMGFKMAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x81C50A0", Offset = "0x81C3EA0", VA = "0x1881C50A0")]
	public static int MOMGFCKLDLP(MJNFJJNDMDN GHGBAFEKNEH, bool KJMGMGFKMAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x81C5040", Offset = "0x81C3E40", VA = "0x1881C5040")]
	private static int ECHBNIKDFPN(MJNFJJNDMDN GHGBAFEKNEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x81C5020", Offset = "0x81C3E20", VA = "0x1881C5020")]
	private static int DIGLLABMBII(MJNFJJNDMDN GHGBAFEKNEH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class APJEJBAPPMA
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class BOIMNDBDLOM : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private PHFDFIIIMCE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
		[DebuggerHidden]
		public BOIMNDBDLOM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x15089C0", Offset = "0x15077C0", VA = "0x1815089C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x81C2CD0", Offset = "0x81C1AD0", VA = "0x1881C2CD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
	public static void ELHFOPDHINJ(string FMFDAFLDAAK, int GOLHBMLDEPN, long LHKFFBIHNBB, long GBAAEEKIAAL, long MILKFCDGFDE, long NPAHGAHCCIJ, long OECFDPLLBBE, long FMJBKGOBLIH, long MNCBGCEJBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x81BE790", Offset = "0x81BD590", VA = "0x1881BE790")]
	public static GMJHELKMAKL IFDLCENADML(JobHandle OABLMMFJFOO, bool BIJBLMKMKPH, bool LPDMGNAFELK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x81BE720", Offset = "0x81BD520", VA = "0x1881BE720")]
	[IteratorStateMachine(typeof(BOIMNDBDLOM))]
	private static IEnumerator<PHFDFIIIMCE> BGFOLJKPJHE(JobHandle MJIBDELKIML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class HBEOCHFFIHK
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum AHONDHOEIFE
	{
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		General,
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly int HONMEAEPLEK;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly int MMDKAELNJCD;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly int JFHKEAMCLHL;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly int BNJFDCEGHEB;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly int JGBEMBKEBCJ;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly int CEMCOOCJGGC;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly int CMGOIPLECPP;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly int JLPOFAAEOIL;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly int JIGGMIPLKEP;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly int DPIGEPNGHMI;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly int GJJHLEMONEI;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly int CLNIMCOIEIK;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x81C5390", Offset = "0x81C4190", VA = "0x1881C5390")]
	public static bool JAFJAIDJJBF(Material GKIFPALLDIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x81C52D0", Offset = "0x81C40D0", VA = "0x1881C52D0")]
	public static bool GGLHFBPBDBF(Material GKIFPALLDIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class HEHAFFBCGDI : PBJIPPMPJIL
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class BBAODCJMLHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public HNDICJJKNNH<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public HEHAFFBCGDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public BBAODCJMLHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x81C27C0", Offset = "0x81C15C0", VA = "0x1881C27C0")]
		internal void IPAAHOMABOC(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x81C2B90", Offset = "0x81C1990", VA = "0x1881C2B90")]
		internal void KHCHABHFMCG(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	protected AvatarSkinAssetItem FMDPPIANGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	protected Material[] KELAOJNCFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private readonly AvatarSkinAssetItem.ONGODKLFOLL LAMMEEACAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private readonly AssetReference PHKLJGJOIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private readonly NJKDBAMDGPL? KANBHJICPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private SkinnedMeshRenderer[] DOGOBKBIHKE;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public override BCIIDHEJBAB.MMBHHGOHKAA FKGKCGDCIPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(BCIIDHEJBAB.MMBHHGOHKAA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA98AC0", Offset = "0xA978C0", VA = "0x180A98AC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x81C5AB0", Offset = "0x81C48B0", VA = "0x1881C5AB0")]
	public HEHAFFBCGDI(AvatarSkinAssetItem.ONGODKLFOLL MMHIJGEMDKI, AssetReference INKAANKNIKB, Material JFPAJGDGEEN, PGMODLDJKOM DPNGCNNOBCC, BCIIDHEJBAB.MMBHHGOHKAA LIPKPLOEHEB = (BCIIDHEJBAB.MMBHHGOHKAA)0L, [Optional] NJKDBAMDGPL? EELGNKMNPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x81C5BE0", Offset = "0x81C49E0", VA = "0x1881C5BE0")]
	public HEHAFFBCGDI(AvatarSkinAssetItem.ONGODKLFOLL MMHIJGEMDKI, AssetReference INKAANKNIKB, Material JFPAJGDGEEN, BCIIDHEJBAB.MMBHHGOHKAA LIPKPLOEHEB = (BCIIDHEJBAB.MMBHHGOHKAA)0L, [Optional] NJKDBAMDGPL? EELGNKMNPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x81C5610", Offset = "0x81C4410", VA = "0x1881C5610", Slot = "6")]
	public override BFMPGGMMDDD BKPJOHKGCEC(List<JBJKHPALKPK> COLDFAJDFAF, List<JBJKHPALKPK> BCCFCFNIJJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x81C5830", Offset = "0x81C4630", VA = "0x1881C5830", Slot = "7")]
	public override NFFHKHDDAGJ KEEJICIIOIM(uint GOLHBMLDEPN, AvatarSkinnedMeshBoneOrderRemapsData DBIPCOFOJLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x81C5A40", Offset = "0x81C4840", VA = "0x1881C5A40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x81C57E0", Offset = "0x81C45E0", VA = "0x1881C57E0")]
	protected void EMCONPIPEEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class LEOHGFHGMIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private List<int> FNNFIBILEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private List<IIBPBJHIKOG> APOEMPLJEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	private HashSet<Transform> HPEPMCEICKE;

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x81CE230", Offset = "0x81CD030", VA = "0x1881CE230")]
	public static LEOHGFHGMIB KGEJFLMGCKH(Transform DDCPKPIHIOM, Dictionary<Transform, OutfitType?> AEDNPPBKBBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x81CDF10", Offset = "0x81CCD10", VA = "0x1881CDF10")]
	private void IMDHJFLEIAI(Transform DDCPKPIHIOM, PGMODLDJKOM DPNGCNNOBCC, Dictionary<Transform, OutfitType?> AEDNPPBKBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x81CDD80", Offset = "0x81CCB80", VA = "0x1881CDD80")]
	private void GKBGFFILAIM(Transform DAIMEOEHLCC, PGMODLDJKOM DPNGCNNOBCC, bool BDDCHLGGHGE, OutfitType? KCKDFFFLAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x81CD990", Offset = "0x81CC790", VA = "0x1881CD990")]
	public CPMJAEONBBK DPBDMEACHDJ(HashSet<string> FDBNMADJFHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x81CE3C0", Offset = "0x81CD1C0", VA = "0x1881CE3C0")]
	public LEOHGFHGMIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class CPMJAEONBBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private List<IIBPBJHIKOG> APOEMPLJEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private List<Matrix4x4> OLBLNKKJEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private Transform[] AODJBFFGANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private Matrix4x4[] GMDJGNPINPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private Dictionary<MCGOJNOKDNK, int> BLEBDAOGHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private List<LCMFCNDGGCL> CJFODOKBJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private bool DGEAEHNIKMJ;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x81C2FA0", Offset = "0x81C1DA0", VA = "0x1881C2FA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Transform[] PELIDGPIFPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x81C2DD0", Offset = "0x81C1BD0", VA = "0x1881C2DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Matrix4x4[] DPKCGOKNMJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x81C2F30", Offset = "0x81C1D30", VA = "0x1881C2F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x81C2FE0", Offset = "0x81C1DE0", VA = "0x1881C2FE0")]
	public void GKBGFFILAIM(Transform DAIMEOEHLCC, PGMODLDJKOM DPNGCNNOBCC, OutfitType? KCKDFFFLAGC, bool DEAOFIGHBIN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x81C31D0", Offset = "0x81C1FD0", VA = "0x1881C31D0")]
	private void GKBGFFILAIM(Transform DAIMEOEHLCC, PGMODLDJKOM DPNGCNNOBCC, OutfitType? KCKDFFFLAGC, bool DEAOFIGHBIN, Matrix4x4 IJGLAFNEEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x81C3540", Offset = "0x81C2340", VA = "0x1881C3540")]
	public int IEMDBAAPNDG(MCGOJNOKDNK OPGJHIOADCK, bool JLGCAGHDODA, [Optional] OutfitType? KCKDFFFLAGC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x81C3920", Offset = "0x81C2720", VA = "0x1881C3920")]
	public int NFFEHINLHBK(PGMODLDJKOM DPNGCNNOBCC, [Optional] OutfitType? KCKDFFFLAGC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x81C36F0", Offset = "0x81C24F0", VA = "0x1881C36F0")]
	public void LKPAHPBJGBE(MCGOJNOKDNK OPGJHIOADCK, Matrix4x4 MNKJNBCOHEE, bool JLGCAGHDODA = false, [Optional] OutfitType? KCKDFFFLAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x81C37E0", Offset = "0x81C25E0", VA = "0x1881C37E0")]
	public Matrix4x4 MPAGCPCGHJE(MCGOJNOKDNK OPGJHIOADCK, bool JLGCAGHDODA, [Optional] OutfitType? KCKDFFFLAGC)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x126F550", Offset = "0x126E350", VA = "0x18126F550")]
	public void CKMJNJJEANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x81C3A20", Offset = "0x81C2820", VA = "0x1881C3A20")]
	public CPMJAEONBBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct MCGOJNOKDNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public readonly string AEFEFBCHGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public readonly PGMODLDJKOM ALGBMMFFJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public readonly OutfitType? MMGMPPMPEEK;

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x81CFBD0", Offset = "0x81CE9D0", VA = "0x1881CFBD0")]
	public MCGOJNOKDNK(string EOIFEFNLELB, PGMODLDJKOM DPNGCNNOBCC, [Optional] OutfitType? KCKDFFFLAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x81CFB20", Offset = "0x81CE920", VA = "0x1881CFB20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x81CFA60", Offset = "0x81CE860", VA = "0x1881CFA60")]
	public bool PLPDMPBLIKB(MCGOJNOKDNK FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x81CF950", Offset = "0x81CE750", VA = "0x1881CF950", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x81CF9F0", Offset = "0x81CE7F0", VA = "0x1881CF9F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct LCMFCNDGGCL : IEquatable<LCMFCNDGGCL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public readonly PGMODLDJKOM ALGBMMFFJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public readonly OutfitType? LNLDADEDJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public readonly int PEEAKMKDBFN;

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x81CD980", Offset = "0x81CC780", VA = "0x1881CD980")]
	public LCMFCNDGGCL(PGMODLDJKOM DPNGCNNOBCC, int GGMFNDOBFLI, [Optional] OutfitType? DJNAEDMIPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x81CD8B0", Offset = "0x81CC6B0", VA = "0x1881CD8B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x73A44A0", Offset = "0x73A32A0", VA = "0x1873A44A0")]
	public bool MDGLGGGPAAI(PGMODLDJKOM DPNGCNNOBCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x81CD830", Offset = "0x81CC630", VA = "0x1881CD830")]
	public bool PEOAHFJDEMN(OutfitType? DJNAEDMIPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x81CD790", Offset = "0x81CC590", VA = "0x1881CD790", Slot = "4")]
	public bool Equals(LCMFCNDGGCL FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x81CD6A0", Offset = "0x81CC4A0", VA = "0x1881CD6A0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x81CD7E0", Offset = "0x81CC5E0", VA = "0x1881CD7E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct IIBPBJHIKOG : IEquatable<IIBPBJHIKOG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public readonly Transform MFCPFEFJKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public readonly bool HJFJMFDDHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public readonly PGMODLDJKOM KGGNFNIECGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public readonly OutfitType? MMGMPPMPEEK;

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x81C61F0", Offset = "0x81C4FF0", VA = "0x1881C61F0")]
	public IIBPBJHIKOG(Transform DAIMEOEHLCC, bool BDDCHLGGHGE, PGMODLDJKOM NFFPHBEPDEK, [Optional] OutfitType? JKDLHPOGJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x81C5FE0", Offset = "0x81C4DE0", VA = "0x1881C5FE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x81C5D80", Offset = "0x81C4B80", VA = "0x1881C5D80", Slot = "4")]
	public bool Equals(IIBPBJHIKOG FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x81C5E80", Offset = "0x81C4C80", VA = "0x1881C5E80", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F60", Offset = "0x81C4D60", VA = "0x1881C5F60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[ExecuteInEditMode]
	public class FitMeshHemisphereUpdater : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x81C5270", Offset = "0x81C4070", VA = "0x1881C5270")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface PENHAKDMPJH
{
	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JKNALEOPEFP(Mesh PKBJPDPONKJ, Matrix4x4 NEHNKJPBLAB, byte[] EGAPAKLBHHP, bool HIBIAAFBKPN = false, BCIIDHEJBAB.MMBHHGOHKAA JPKJKHCGHGJ = (BCIIDHEJBAB.MMBHHGOHKAA)0L, int DHNEDKNOHGH = -1, bool HGEPLHIBCBG = false);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MJEGPPJOLGB(Allocator GIEDOJCOPKP, DGLGBOIILAC ELMOINEPNFB, byte NNEDKNMKPIN, [Optional] IList<int> HGAOJKNHIKD, [Optional] IList<int> FFMBFDIKGFH);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct DBJFKBLCELM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public readonly GameObject LGOOFDMENBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private readonly AvatarItemMaterial ADEFABNAGIP;

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0xC55370", Offset = "0xC54170", VA = "0x180C55370")]
	public DBJFKBLCELM(GameObject LGOOFDMENBN, AvatarItemMaterial ADEFABNAGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x81C3B90", Offset = "0x81C2990", VA = "0x1881C3B90")]
	public void EKPKBGMEIIO(Material GKIFPALLDIK, int IDNAPJMNGPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class KPKLMMEFCCH : FNDHNLNJILN<Task<(GameObject, AvatarItemMaterial)>, DBJFKBLCELM>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct JFGAEJPHMPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x81C71C0", Offset = "0x81C5FC0", VA = "0x1881C71C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x81C76C0", Offset = "0x81C64C0", VA = "0x1881C76C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private HNDICJJKNNH<GameObject> CPMLPILFMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private HNDICJJKNNH<AvatarItemMaterial> ECPOAHHFGEL;

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x81CCE90", Offset = "0x81CBC90", VA = "0x1881CCE90")]
	private KPKLMMEFCCH(Task<(GameObject, AvatarItemMaterial)> MGEGHBBNKMN, HNDICJJKNNH<GameObject> IKGBALMIENL, HNDICJJKNNH<AvatarItemMaterial> PHCCFDLEGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x81CCA70", Offset = "0x81CB870", VA = "0x1881CCA70")]
	public static KPKLMMEFCCH INIHOJCCLPM(AssetReference GCLGDECKKBL, [Optional] AssetReference KKBPJIKMAFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x81CC9D0", Offset = "0x81CB7D0", VA = "0x1881CC9D0", Slot = "11")]
	protected override DBJFKBLCELM EKONMNNOOFN(Task<(GameObject, AvatarItemMaterial)> MIIAOOKGJGO)
	{
		return default(DBJFKBLCELM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x81CC950", Offset = "0x81CB750", VA = "0x1881CC950", Slot = "12")]
	protected override void EEMDJEPOHOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x81CC820", Offset = "0x81CB620", VA = "0x1881CC820")]
	[AsyncStateMachine(typeof(JFGAEJPHMPD))]
	private static Task<(GameObject, AvatarItemMaterial)> DFHJHDGPHHB(Task<GameObject> JAKGKDIIEKO, Task<AvatarItemMaterial> NMPCJCGKNOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class AILFDKHHJAI
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class LABBIMBCPID : FNDHNLNJILN<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private HNDICJJKNNH<MaterialMapAsset> MJIBDELKIML;

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x81CD3C0", Offset = "0x81CC1C0", VA = "0x1881CD3C0")]
		public LABBIMBCPID(HNDICJJKNNH<MaterialMapAsset> MJIBDELKIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x81CCF80", Offset = "0x81CBD80", VA = "0x1881CCF80", Slot = "11")]
		protected override Material[] EKONMNNOOFN(Task<MaterialMapAsset> MGEGHBBNKMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x81CCF20", Offset = "0x81CBD20", VA = "0x1881CCF20", Slot = "12")]
		protected override void EEMDJEPOHOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class LBIFHHFLJPD : FNDHNLNJILN<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private List<HNDICJJKNNH<Material>> KELIIEBDMOM;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x81CD630", Offset = "0x81CC430", VA = "0x1881CD630")]
		public LBIFHHFLJPD(Task<Material[]> MGEGHBBNKMN, List<HNDICJJKNNH<Material>> KELIIEBDMOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x81CD5E0", Offset = "0x81CC3E0", VA = "0x1881CD5E0", Slot = "11")]
		protected override Material[] EKONMNNOOFN(Task<Material[]> MIIAOOKGJGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x81CD4A0", Offset = "0x81CC2A0", VA = "0x1881CD4A0", Slot = "12")]
		protected override void EEMDJEPOHOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x81BD3E0", Offset = "0x81BC1E0", VA = "0x1881BD3E0")]
	public static HNDICJJKNNH<Material[]> LDFFBCDOIKF(AssetReference[] INNEFBIKPDI)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[DisallowMultipleComponent]
	public class PlayerAvatarDisplayBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public enum GALOBKDEPGO
		{
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public enum FHJPJKFHCMF
		{
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public enum GGMKHLLHHOL : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			All,
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct ILFLCKOKFIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			public readonly Material FJEHDIIFJLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			public readonly GALOBKDEPGO CPNMCJIGJPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			public readonly FHJPJKFHCMF JOOPGPKBHLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			public readonly PGMODLDJKOM ALGBMMFFJDO;

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x81E48D0", Offset = "0x81E36D0", VA = "0x1881E48D0")]
			public ILFLCKOKFIB(Material GKIFPALLDIK, GALOBKDEPGO LDFBMIIMOMB, FHJPJKFHCMF FEMFKDHLAOB, PGMODLDJKOM DPNGCNNOBCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x81E46B0", Offset = "0x81E34B0", VA = "0x1881E46B0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x81E4630", Offset = "0x81E3430", VA = "0x1881E4630")]
			public bool PLPDMPBLIKB(ILFLCKOKFIB FGAEAFBDBPK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x81E44B0", Offset = "0x81E32B0", VA = "0x1881E44B0", Slot = "0")]
			public override bool Equals(object ALGAKMGCCLO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x81E4590", Offset = "0x81E3390", VA = "0x1881E4590", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		protected class DLHFIAAGHJN : IComparable<DLHFIAAGHJN>, IEquatable<DLHFIAAGHJN>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public int NHDHAPBFDNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			public PlayerAvatarDisplayBase PGDOAEFAHEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public IList<LBLCCGMCKBC> MNKKKIHPNAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public AvatarItemBodyType JIILFCNMONM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public JDDEJEECIBC DFGBALGMAHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			public bool PGKENCDGPHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			public bool DHPNOLPGGHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public int[] PKGEIKDNGCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			public float MNAEAPLJABJ;

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x81E3960", Offset = "0x81E2760", VA = "0x1881E3960", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x81E3810", Offset = "0x81E2610", VA = "0x1881E3810", Slot = "4")]
			public int CompareTo(DLHFIAAGHJN FGAEAFBDBPK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x81E3840", Offset = "0x81E2640", VA = "0x1881E3840", Slot = "5")]
			public bool Equals(DLHFIAAGHJN FGAEAFBDBPK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public DLHFIAAGHJN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		protected abstract class ALGPJLLIOHP
		{
			[Cpp2IlInjected.Token(Token = "0x200005C")]
			public class IOMEKKDNNHF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400037F")]
				public readonly Mesh HHFNFGLOOHB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000380")]
				public readonly Material[] KOAMJOLJAHN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000381")]
				public readonly Transform[] BOBJCILHHHA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000382")]
				public readonly Matrix4x4[] CLFHCEJCOHD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000383")]
				public readonly Transform EFHPHHJOGAO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000384")]
				public readonly bool BGMCBBHOHHK;

				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
				protected IOMEKKDNNHF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x81E4C30", Offset = "0x81E3A30", VA = "0x1881E4C30")]
				public IOMEKKDNNHF(Mesh PKBJPDPONKJ, Material[] GBJHDBGJAFG, bool PMPMNGOPPGM, Transform[] ICNOAEFAAMM, Transform LJFKCANDNJK, Matrix4x4[] LCPKHCIFCGA)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x81E51D0", Offset = "0x81E3FD0", VA = "0x1881E51D0")]
				private IOMEKKDNNHF(SkinnedMeshRenderer MKKELNAFDKN, Material[] FGMEALAJLOJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0x81E50E0", Offset = "0x81E3EE0", VA = "0x1881E50E0")]
				private IOMEKKDNNHF(MeshRenderer KBGCCGJFPHM, Transform LJFKCANDNJK, Material[] FGMEALAJLOJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0x81E4910", Offset = "0x81E3710", VA = "0x1881E4910")]
				public static IOMEKKDNNHF GIGBNDAGNJF(Renderer NNEJGKAIJNN, Material[] FGMEALAJLOJ)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			public readonly PGMODLDJKOM ALGBMMFFJDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			public readonly Transform BICGAPJNPEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			public readonly bool PBLBAHOLHDL;

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual bool AMPKLMPFMMN
			{
				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual bool ILICFJAGDEE
			{
				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual BCIIDHEJBAB.MMBHHGOHKAA FKGKCGDCIPP
			{
				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "6")]
				get
				{
					return default(BCIIDHEJBAB.MMBHHGOHKAA);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public bool FBDIBONGICC
			{
				[Cpp2IlInjected.Token(Token = "0x600030B")]
				[Cpp2IlInjected.Address(RVA = "0x81DF050", Offset = "0x81DDE50", VA = "0x1881DF050")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x81DF060", Offset = "0x81DDE60", VA = "0x1881DF060")]
			protected ALGPJLLIOHP(PGMODLDJKOM DPNGCNNOBCC, Transform EGDFKMCNHHA, bool CKDKPDMCIPI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract BFMPGGMMDDD BKPJOHKGCEC(List<JBJKHPALKPK> COLDFAJDFAF, List<JBJKHPALKPK> BCCFCFNIJJB);

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract IOMEKKDNNHF KEEJICIIOIM(int GOLHBMLDEPN, PlayerHandBones PMJKECGAADN);
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected class HOLBAFMNMNH : ALGPJLLIOHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			protected readonly BodyPartLODs DOGOBKBIHKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			protected readonly Material[] KELAOJNCFDP;

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x81E40E0", Offset = "0x81E2EE0", VA = "0x1881E40E0")]
			public HOLBAFMNMNH(PGMODLDJKOM DPNGCNNOBCC, BodyPartLODs AJJPDJAKJCC, Material JFPAJGDGEEN, [Optional] Transform EGDFKMCNHHA, bool CKDKPDMCIPI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x81E3E20", Offset = "0x81E2C20", VA = "0x1881E3E20", Slot = "7")]
			public override BFMPGGMMDDD BKPJOHKGCEC(List<JBJKHPALKPK> COLDFAJDFAF, List<JBJKHPALKPK> BCCFCFNIJJB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x81E3EB0", Offset = "0x81E2CB0", VA = "0x1881E3EB0", Slot = "8")]
			public override IOMEKKDNNHF KEEJICIIOIM(int GOLHBMLDEPN, PlayerHandBones PMJKECGAADN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x81E4070", Offset = "0x81E2E70", VA = "0x1881E4070", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		protected class OLBOBDPDOFI : ALGPJLLIOHP
		{
			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public override bool AMPKLMPFMMN
			{
				[Cpp2IlInjected.Token(Token = "0x6000318")]
				[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public override bool ILICFJAGDEE
			{
				[Cpp2IlInjected.Token(Token = "0x6000319")]
				[Cpp2IlInjected.Address(RVA = "0x81E76C0", Offset = "0x81E64C0", VA = "0x1881E76C0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public JCFBDDLEJAA NFCNGHAIHAP
			{
				[Cpp2IlInjected.Token(Token = "0x600031A")]
				[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600031B")]
				[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x81E7780", Offset = "0x81E6580", VA = "0x1881E7780")]
			public OLBOBDPDOFI(PGMODLDJKOM DPNGCNNOBCC, Transform EGDFKMCNHHA, JCFBDDLEJAA LNKFGBNCGAD, bool CKDKPDMCIPI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x81E7630", Offset = "0x81E6430", VA = "0x1881E7630", Slot = "7")]
			public override BFMPGGMMDDD BKPJOHKGCEC(List<JBJKHPALKPK> COLDFAJDFAF, List<JBJKHPALKPK> BCCFCFNIJJB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "8")]
			public override IOMEKKDNNHF KEEJICIIOIM(int GOLHBMLDEPN, PlayerHandBones PMJKECGAADN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x81E7710", Offset = "0x81E6510", VA = "0x1881E7710", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public class AOOHGIHOBJL
		{
			[Cpp2IlInjected.Token(Token = "0x2000060")]
			public enum JHCMNEFKFAA
			{
				[Cpp2IlInjected.Token(Token = "0x4000398")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x4000399")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x400039A")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x400039B")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x400039C")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x400039D")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x400039E")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public static readonly int NCOEKMLNODF;

			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public static readonly int AINGLMGEFGP;

			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public static readonly int LOLDDOGOAEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			protected readonly ABAOCJDIGCP AGCFIFCPCDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			protected readonly LOMOMHCANIN LDAEONJKMLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			protected readonly Animator PIDHJDJCIGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			protected readonly Transform ICHKFNNICJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public Vector3 DAGADKFEHOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			protected readonly Transform FCKMGNBNDBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public Vector3 IFKHEFKCBMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			protected bool LHAAJBAGKCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			protected ELMDBEFEDJJ KBLGDPMIBPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			protected bool BGGELKNIACB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected float LMHOAHEHDNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			protected INGLKBMOAOH<NCBHKEPILOG> FGNEPAOIEIK;

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public ELMDBEFEDJJ LGMCDNNKLFM
			{
				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0xA931F0", Offset = "0xA91FF0", VA = "0x180A931F0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000321")]
				[Cpp2IlInjected.Address(RVA = "0xA931A0", Offset = "0xA91FA0", VA = "0x180A931A0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public bool BEIMMDOMPGJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000322")]
				[Cpp2IlInjected.Address(RVA = "0xD63540", Offset = "0xD62340", VA = "0x180D63540")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000323")]
				[Cpp2IlInjected.Address(RVA = "0x81DF280", Offset = "0x81DE080", VA = "0x1881DF280")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public bool JPKKMIAPLPD
			{
				[Cpp2IlInjected.Token(Token = "0x6000324")]
				[Cpp2IlInjected.Address(RVA = "0xA98B80", Offset = "0xA97980", VA = "0x180A98B80")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000325")]
				[Cpp2IlInjected.Address(RVA = "0x81DF110", Offset = "0x81DDF10", VA = "0x1881DF110")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public float FGBAJEIPKIK
			{
				[Cpp2IlInjected.Token(Token = "0x6000326")]
				[Cpp2IlInjected.Address(RVA = "0xE12C90", Offset = "0xE11A90", VA = "0x180E12C90")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000327")]
				[Cpp2IlInjected.Address(RVA = "0x81DF7C0", Offset = "0x81DE5C0", VA = "0x1881DF7C0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public NCBHKEPILOG IIGHLFPPPHJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000328")]
				[Cpp2IlInjected.Address(RVA = "0x81DF240", Offset = "0x81DE040", VA = "0x1881DF240")]
				get
				{
					return default(NCBHKEPILOG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x81DF900", Offset = "0x81DE700", VA = "0x1881DF900")]
			public bool KHKHGOPCFHA(NCBHKEPILOG CCNGFAIMJHF, object OBGCPOCPFIJ, JHCMNEFKFAA JFELCJGHJPG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x81DF440", Offset = "0x81DE240", VA = "0x1881DF440")]
			public bool GCNCALMFLDB(object OBGCPOCPFIJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x81E0330", Offset = "0x81DF130", VA = "0x1881E0330")]
			protected AOOHGIHOBJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x81DFD40", Offset = "0x81DEB40", VA = "0x1881DFD40")]
			public AOOHGIHOBJL(ABAOCJDIGCP AGCFIFCPCDJ, ELMDBEFEDJJ MNDOCOGGJOE, Animator PIDHJDJCIGI, Transform ICHKFNNICJH, Transform FCKMGNBNDBD, Vector3 DAGADKFEHOF, Vector3 IFKHEFKCBMO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x81DFA10", Offset = "0x81DE810", VA = "0x1881DFA10")]
			private void KOCNPGLAHJD(ushort NEDNHOBCOKJ, ushort CCGJKEKAOKJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x81DF350", Offset = "0x81DE150", VA = "0x1881DF350")]
			protected void GAENKNIBLNK(ushort NEDNHOBCOKJ, ushort CCGJKEKAOKJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x81DFBE0", Offset = "0x81DE9E0", VA = "0x1881DFBE0")]
			protected void NIBPBEAIDID(ushort NEDNHOBCOKJ, ushort CCGJKEKAOKJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x81DFAC0", Offset = "0x81DE8C0", VA = "0x1881DFAC0")]
			protected void LGFMCLHHILP(ushort NEDNHOBCOKJ, ushort CCGJKEKAOKJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x81DF590", Offset = "0x81DE390", VA = "0x1881DF590")]
			protected void IHJBABEEEDO(ushort NEDNHOBCOKJ, ushort CCGJKEKAOKJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x81DF1E0", Offset = "0x81DDFE0", VA = "0x1881DF1E0")]
			protected void EIIDFJJJLON(ushort NEDNHOBCOKJ, ushort CCGJKEKAOKJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x81DF0C0", Offset = "0x81DDEC0", VA = "0x1881DF0C0")]
			protected void AEKKPFOLLKK(ushort NEDNHOBCOKJ, ushort CCGJKEKAOKJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x81DF540", Offset = "0x81DE340", VA = "0x1881DF540")]
			protected void IANLPMMHGCE(ushort NEDNHOBCOKJ, ushort CCGJKEKAOKJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x81DF6A0", Offset = "0x81DE4A0", VA = "0x1881DF6A0")]
			protected void INEAOKAMANK(ushort NEDNHOBCOKJ, ushort CCGJKEKAOKJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public class DEDDGBOFFDJ : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			public const int PDGAECEJDDO = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			protected MaterialPropertyBlock EMMBAGIIEBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public Color? PAAFFIJOBLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public Color? EAGBKKPNFLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public Color? HINEAJHKLBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public Color HMBCPGNFNKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public Color EIIGGOOADIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public Color IMBFIGGJDPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			public Texture2D OJPGENMELPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public Texture2D DOEAIJDDNEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			protected Dictionary<ILFLCKOKFIB, int> ONKOAOCBJJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			protected GALOBKDEPGO[] KBHHOGOKHEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			public Vector4[] ANJLBMHLIFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public Vector4[] FICKEMBAOLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public Vector4[] EABAFLDIADJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			public Vector4[] MIAEINIGFOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			public Vector4[] PPBCLJEAFGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			public Vector4[] ODPMIAHNIGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected List<Texture2D> CGBCCCIBALJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected Vector4[] JPPLBCKGGGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			protected List<Texture2D> HFJEMBLJHHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			protected float[] LEBIHFIJBIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			protected Vector4[] LGNPEDHJNFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			protected float[] GCOIEAPELND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public float[] GIOCNIFAKCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			protected List<Texture2D> NDMNPIAFAJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			protected float[] CPNPFNIJNFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			protected List<Texture2D> HCLKJJNBCMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			protected Vector4[] PAMMNJACJFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			protected float[] IJECOMJNPNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			protected Vector4[] CJNCHFGLHKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			public float[] JFEDCHINNPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public Texture2DArray JIADMMKIMPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public Texture2DArray KJADBMMMDFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public Texture2DArray HOEIJCFIPAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public Texture2DArray IEKPMGPOCLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			protected bool FOFMNPFDLPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			protected int DJCMCJMBIEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			protected Vector2? PJPMABJHPOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			protected TextureFormat BMJIHIGAOAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			protected Vector2? OGLEKFOBPGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			protected TextureFormat HGNPCLDMKMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			protected Vector2? OACFJDDGBCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			protected TextureFormat HMDPFBMHBAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			protected Vector2? LFNNMMKBKAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			protected TextureFormat OOLGPKGPPFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			protected bool PJLPIIDDCCN;

			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			protected static int MIJMECPNLIF;

			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			protected static int KOPHGHFCMED;

			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			protected static int OLCEPCAHKOF;

			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			protected static int JEGNJCEAOFC;

			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			protected static int MHDFHMOLHEN;

			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			protected static int LPFMDKPMPNC;

			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			protected static int HDGAHNDNCDF;

			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			protected static int MOJEJDBNPHF;

			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			protected static int DGGGLCJGKEC;

			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			protected static int LEEEMICCEOF;

			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			protected static int BPEBMNKJNGA;

			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			protected static int JCFPFPNJOMB;

			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			protected static int JFMMMCGMGNM;

			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			protected static int DEANLCBCILD;

			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			protected static int HMNJPCJOJLF;

			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			protected static int LJHEENNFDMO;

			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			protected static int CNGBPHGCDDN;

			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			protected static int IIMPDIIOPNL;

			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			protected static int GDNNDKGALKK;

			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			protected static int LHHGFNGEJBN;

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x81E3350", Offset = "0x81E2150", VA = "0x1881E3350")]
			protected DEDDGBOFFDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x81E32C0", Offset = "0x81E20C0", VA = "0x1881E32C0")]
			public DEDDGBOFFDJ(Color GICOGPHOODF, Color OOHBLOOLOIH, Color IEMHNMOOMFL, Color? NCOLHMCFMFL, Color? CDELEDBGAJI, Color? ODKHAOGIPIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x81E2A40", Offset = "0x81E1840", VA = "0x1881E2A40")]
			public int JGHNELGDPLD(Material JOIMGIKOLGG, GALOBKDEPGO LDFBMIIMOMB, FHJPJKFHCMF FEMFKDHLAOB, PGMODLDJKOM DPNGCNNOBCC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x81E29B0", Offset = "0x81E17B0", VA = "0x1881E29B0")]
			public int JGHNELGDPLD(ILFLCKOKFIB OPGJHIOADCK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x81E1C80", Offset = "0x81E0A80", VA = "0x1881E1C80")]
			public int DDFCBBBBDBB(Material JOIMGIKOLGG, Color GOIKFANCJOE, Color JDJDHGJABHK, Color BKANIHANBND, Color PBIBBJDLFFO, Color KJIBDFAENCC, Texture2D NOLKJJANDFA, Vector4 JNGGAJPHGGK, Texture2D BPOPNCINFGJ, Vector4 HOBABBHOCAG, float OMFOOFIBLLO, float ADGLGFBDILJ, Texture2D LIJHJCGMAMH, Vector4 MECAPDGKCBJ, float GEMKIMAPDEN, Texture2D BABBPGHHLPI, float CMLJBEEILMD, Color ABKEPHAAPKB, Vector4 PPHGBKNPNAD, GALOBKDEPGO LDFBMIIMOMB, FHJPJKFHCMF FEMFKDHLAOB, PGMODLDJKOM DPNGCNNOBCC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x81E2DB0", Offset = "0x81E1BB0", VA = "0x1881E2DB0")]
			protected void OMEHLPEAHME([Out] Texture2DArray NMDECLHPJDA, [Out] Texture2DArray LNLEDPONLGF, [Out] Texture2DArray EABMPKNNDPD, [Out] Texture2DArray DINCEHLJIMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x81E1A20", Offset = "0x81E0820", VA = "0x1881E1A20")]
			public void CECKGNEFPAB(PlayerAvatarDisplayBase AJJACHLMMFH, Renderer NNEJGKAIJNN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x81E0F30", Offset = "0x81DFD30", VA = "0x1881E0F30")]
			protected void CDICHCGHEFN(PlayerAvatarDisplayBase AJJACHLMMFH, Renderer NNEJGKAIJNN, int FHGBOBFOBOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x81E2BC0", Offset = "0x81E19C0", VA = "0x1881E2BC0")]
			private Color NBNBJCDDJDP(Color DNFJHKPCCKJ, GALOBKDEPGO FOPEMADPOPM)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x81E0DE0", Offset = "0x81DFBE0", VA = "0x1881E0DE0")]
			private Color BOLELOKFKAO(Color EGGMKOHLPJC, GALOBKDEPGO FOPEMADPOPM)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x81E2B30", Offset = "0x81E1930", VA = "0x1881E2B30")]
			protected void KLHBPEKGJHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x81E2970", Offset = "0x81E1770", VA = "0x1881E2970", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x81EDE20", Offset = "0x81ECC20", VA = "0x1881EDE20")]
			public void BMOJOPMDPDJ(PGMODLDJKOM DPNGCNNOBCC, [Out] Transform MMENCBNBOBJ, [Out] Transform[] ICNOAEFAAMM)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class IKABANJOMMH : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000350")]
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000352")]
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x1010120", Offset = "0x100EF20", VA = "0x181010120")]
			[DebuggerHidden]
			public IKABANJOMMH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x81E41E0", Offset = "0x81E2FE0", VA = "0x1881E41E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x81E4460", Offset = "0x81E3260", VA = "0x1881E4460", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x81E43B0", Offset = "0x81E31B0", VA = "0x1881E43B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x81E43B0", Offset = "0x81E31B0", VA = "0x1881E43B0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class OFHONOFODCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public OFHONOFODCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x81E7550", Offset = "0x81E6350", VA = "0x1881E7550")]
			internal bool PIBNCDLDGHM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class LODIDBKGNDI : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			private PHFDFIIIMCE <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600035A")]
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600035C")]
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
			[DebuggerHidden]
			public LODIDBKGNDI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x81E5FF0", Offset = "0x81E4DF0", VA = "0x1881E5FF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x81E6330", Offset = "0x81E5130", VA = "0x1881E6330", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private struct ODFIGADILMJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public BNICAFPKAPB avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003FD")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x81E7120", Offset = "0x81E5F20", VA = "0x1881E7120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x81E74C0", Offset = "0x81E62C0", VA = "0x1881E74C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class OEBODEFOKNF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FE")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public OEBODEFOKNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x81E7520", Offset = "0x81E6320", VA = "0x1881E7520")]
			internal bool AEJNEBBIMPG(LBLCCGMCKBC selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class CBMEKHNMEEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public Func<AIKJELDGMEB<Dictionary<string, HNDICJJKNNH<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public CBMEKHNMEEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x81E0B30", Offset = "0x81DF930", VA = "0x1881E0B30")]
			internal (MDIEIFNFGHA, AIKJELDGMEB<Dictionary<string, HNDICJJKNNH<Texture2D>>>) AKBFFGOJLMO(Dictionary<string, GADJBANEMPG> avatarItems)
			{
				return default((MDIEIFNFGHA, AIKJELDGMEB<Dictionary<string, HNDICJJKNNH<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x81E0D30", Offset = "0x81DFB30", VA = "0x1881E0D30")]
			internal AIKJELDGMEB<Dictionary<string, HNDICJJKNNH<Texture2D>>> EMGLGOJMOLG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x81E0DA0", Offset = "0x81DFBA0", VA = "0x1881E0DA0")]
			internal void MGLBBJGIHNL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class GODNNFBBIDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public GODNNFBBIDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x81E3AB0", Offset = "0x81E28B0", VA = "0x1881E3AB0")]
			internal bool LHGIPHGPKKA(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private struct JGHFNJNIAKO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000405")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000406")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x81E5510", Offset = "0x81E4310", VA = "0x1881E5510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x81E56E0", Offset = "0x81E44E0", VA = "0x1881E56E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		protected static readonly int JMNPGMBNHJG;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		protected static readonly int IJPIDIKGGDA;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		protected static readonly int CDICPDGKELN;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		protected static readonly int MBGJBJJFJMH;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		protected static readonly int HHEEKDJHGIM;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		protected static readonly int FIJJFKMDLIP;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		protected static readonly int[] CBDIMILGHFF;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		protected static readonly int[] BJBJDJJLCIJ;

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		protected static readonly int[] OFMJIFJGADC;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		protected static readonly int[] NJFODLEPPKH;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		protected static readonly int[] ECGNGJDHAAG;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		protected static readonly int[] HKJKNKOEOJJ;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		protected static List<PlayerAvatarDisplayBase> NDGJLBOGEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		protected NLCKMDLDBJL GAGNAGPMINN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		protected bool IIFMFKOHHKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		protected bool HBGMKIBALAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		protected static readonly int[] HHIIHOJGNIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		protected Dictionary<ILFLCKOKFIB, Material> BMOPPABLHCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		protected Dictionary<ILFLCKOKFIB, Material> OIGOCPCLPEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		[SerializeField]
		public Transform remoteMeshBase;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		protected Material LEACGJBFHEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		protected FCEMHMOCEFP MKPACEIOJKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private ELMDBEFEDJJ CPANCJHMHLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private ELMDBEFEDJJ IEMIELGHOKN;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		protected Material CJOMJLFNDEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		[SerializeField]
		public Transform hemisphereBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		protected FitMeshHemisphere IMHHIKMEELF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		protected bool JLBMENJPOHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		protected NODDIPDIFHA FCEHCNFMEMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		protected bool IPONFHLCNMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		protected AnchorParamsRestrictions GFNFJIBFLIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		protected bool HOFHFDGEBPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		protected Transform IAENKKDHDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		protected bool EEFBCDPMBBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B1")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		protected bool AGODPAJPCLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		protected Vector3 LKCEIPIHCCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected Quaternion HEPDKEDJNHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		protected Vector2 PKIJAJEOMIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected FitMeshHemisphere KGEHOBPOBPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		[SerializeField]
		[LAEBPIHCEIF(FBMDOBLPJCI.SelfAndChildren, false, false, false)]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected Collider[] PNJGDABHNDC;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected Collider[] IMHLKGDEKBB;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected AOOHGIHOBJL[] DNLLBKBMOPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public Dictionary<Renderer, DEDDGBOFFDJ> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		protected Dictionary<Renderer, DEDDGBOFFDJ> ONHFPABODBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		protected LEOHGFHGMIB EEMAGPOPIKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		protected MDIEIFNFGHA AFKHMFNHPHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public MJNFJJNDMDN DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		protected int CHACFJNLKNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		protected (bool isLodForced, int forcedLOD) GOFFAMNCDKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		protected INGLKBMOAOH<LOMOMHCANIN> FGNEPAOIEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		protected bool AJFNLBJDDMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected Dictionary<LBLCCGMCKBC, List<ILFLCKOKFIB>> POPLDKACKEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected Dictionary<LBLCCGMCKBC, List<ILFLCKOKFIB>> MBPLLANEBGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected readonly Dictionary<string, HNDICJJKNNH<Texture2D>> DFGCHMNHBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		protected readonly Dictionary<string, HNDICJJKNNH<Texture2D>> HGJKPFJNDFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		protected bool MOMANLIEIEG;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected static int DJHJHFCFHNJ;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		protected static List<DLHFIAAGHJN> PKBPDBAKBEP;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		protected static List<DLHFIAAGHJN> GDDFFKGKMED;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		protected static GMJHELKMAKL AOBECJCNOKL;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		protected static Func<List<DLHFIAAGHJN>, DLHFIAAGHJN> OMHIALHLIEO;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		protected static bool CODFBBFHEBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		protected Color? JDEFCLDMHHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		protected bool LABKDPEJBCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		protected Color CMPMODPJKBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		protected Color DKMNGNFBDJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		protected Color OKAJEMCJHOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		protected AvatarHairPattern GMCHMGFPMMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		protected JCFBDDLEJAA EKFINPJCANA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		protected Color MGBMLOKEJGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		protected Color JHNIKPMKDML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		protected AvatarHairPattern EAHNDJNCCCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		protected JCFBDDLEJAA GPAKMNMLNGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		protected JCFBDDLEJAA PBNDGEECIOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		protected Color OFLFKEJEKPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private AdditionalFeetData JJEBMEHDCAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		protected LBLCCGMCKBC? KGMCCNDAEDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		protected Texture AOCFBJNGOFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		protected Color BFPMEEAOMBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		protected readonly IList<LBLCCGMCKBC> IEOGAEKADJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		protected readonly IList<LBLCCGMCKBC> CNDPOENNAND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private AvatarItemBodyType NNNOAOHLNIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		[SerializeField]
		protected PBJKAGHPKMF _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D5")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		protected GGMKHLLHHOL ILGMPDAJBFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		protected int[] ADFCDEDMOMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		protected bool OCFGNJGKGHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		protected int[] AHCLKDAMKCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		protected bool OFKAMFJOGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F1")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		protected bool OLIBMKPJANC;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private static readonly BCIIDHEJBAB.MMBHHGOHKAA HEGKKFKGBLJ;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private static readonly BCIIDHEJBAB.MMBHHGOHKAA APOOBFLMIEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F2")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		protected bool KFCMECOKENP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		protected CJPLKIFIKIH NAMABMOFHNP;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string MIJBLHPGANK
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xA98C30", Offset = "0xA97A30", VA = "0x180A98C30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool AKDGCJJPCEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xD5ADA0", Offset = "0xD59BA0", VA = "0x180D5ADA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xD5A210", Offset = "0xD59010", VA = "0x180D5A210")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool DLPPLPOIKLM
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool HFNOCBCJAAD
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x81DDA50", Offset = "0x81DC850", VA = "0x1881DDA50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool NGEODDAJEMD
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool EAECMMGHLHG
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual bool FBJBPCENCOO
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual bool ABENHIOOJCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public FCEMHMOCEFP DPBCJNMFNIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xC0A400", Offset = "0xC09200", VA = "0x180C0A400")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x81DE230", Offset = "0x81DD030", VA = "0x1881DE230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public ELMDBEFEDJJ EJAMPLFEAKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0xC11470", Offset = "0xC10270", VA = "0x180C11470")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x81DE630", Offset = "0x81DD430", VA = "0x1881DE630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public ELMDBEFEDJJ FAOMJFLPCPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0xC1CF50", Offset = "0xC1BD50", VA = "0x180C1CF50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x81DE8F0", Offset = "0x81DD6F0", VA = "0x1881DE8F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		protected Material AFJPKFFMBBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x81D6FF0", Offset = "0x81D5DF0", VA = "0x1881D6FF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		protected Material HCEOGEJHANL
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x81D23B0", Offset = "0x81D11B0", VA = "0x1881D23B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool KGMDMLGEOIL
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x2544FF0", Offset = "0x2543DF0", VA = "0x182544FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public PlayerFacialAnimatorBase EFNBBABMNJH
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0xC1D160", Offset = "0xC1BF60", VA = "0x180C1D160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public AOOHGIHOBJL[] OGFNJCPPOEN
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x81DD5E0", Offset = "0x81DC3E0", VA = "0x1881DD5E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public AOOHGIHOBJL GNJJBLENPNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x81DDC50", Offset = "0x81DCA50", VA = "0x1881DDC50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public AOOHGIHOBJL DEPCLAGPEOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x81DDC80", Offset = "0x81DCA80", VA = "0x1881DDC80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Mesh FJGDEJCCKMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0xBA6AE0", Offset = "0xBA58E0", VA = "0x180BA6AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected LEOHGFHGMIB NDECBGMNMPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x81D7EE0", Offset = "0x81D6CE0", VA = "0x1881D7EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		protected MDIEIFNFGHA GJNNHFMBDMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xC1DC30", Offset = "0xC1CA30", VA = "0x180C1DC30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x81D6560", Offset = "0x81D5360", VA = "0x1881D6560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		protected bool LPDMGNAFELK
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool DAJPLLMOIAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x81DDC40", Offset = "0x81DCA40", VA = "0x1881DDC40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public int AAECLLJLKCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x13ACE50", Offset = "0x13ABC50", VA = "0x1813ACE50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x81DE840", Offset = "0x81DD640", VA = "0x1881DE840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public int FACCHFNHOCN
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x81DE580", Offset = "0x81DD380", VA = "0x1881DE580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected virtual bool NLOAGKIFJON
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected virtual int[] DPBJPFPJHGB
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x81D6600", Offset = "0x81D5400", VA = "0x1881D6600", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		protected bool LENHBDNDFIN
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x81D2A70", Offset = "0x81D1870", VA = "0x1881D2A70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		protected static bool HAEGMPKNFMO
		{
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool GMOPJHFDOMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x81DDCB0", Offset = "0x81DCAB0", VA = "0x1881DDCB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x81DEB00", Offset = "0x81DD900", VA = "0x1881DEB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public IEnumerable<SkinnedMeshRenderer> KDELGEONDJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x81DD460", Offset = "0x81DC260", VA = "0x1881DD460")]
			[IteratorStateMachine(typeof(IKABANJOMMH))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool KOBMDGOKJFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x81DDC30", Offset = "0x81DCA30", VA = "0x1881DDC30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x81D1800", Offset = "0x81D0600", VA = "0x1881D1800")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public JLFDMKNKLIE GJLEPBFGGDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x81DD4E0", Offset = "0x81DC2E0", VA = "0x1881DD4E0")]
			get
			{
				return default(JLFDMKNKLIE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public static bool NHGLCMPOADN
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x81DD980", Offset = "0x81DC780", VA = "0x1881DD980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected static GMJHELKMAKL PMGLEKBIGBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x81CFFB0", Offset = "0x81CEDB0", VA = "0x1881CFFB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x81D76C0", Offset = "0x81D64C0", VA = "0x1881D76C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected Color EAGBKKPNFLB
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x81D0000", Offset = "0x81CEE00", VA = "0x1881D0000")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected Color HINEAJHKLBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x81D2600", Offset = "0x81D1400", VA = "0x1881D2600")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected Texture2D ININPPLPADA
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x81D5160", Offset = "0x81D3F60", VA = "0x1881D5160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Color HMBCPGNFNKE
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x81DD590", Offset = "0x81DC390", VA = "0x1881DD590")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		protected Color EIIGGOOADIE
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x81D00D0", Offset = "0x81CEED0", VA = "0x1881D00D0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public JCFBDDLEJAA MKPDMOLGOIE
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x81DD550", Offset = "0x81DC350", VA = "0x1881DD550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		protected Texture2D JMKNIPPFODL
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x81D5460", Offset = "0x81D4260", VA = "0x1881D5460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public float DLHMKHMFKKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x81DD570", Offset = "0x81DC370", VA = "0x1881DD570")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public float KHBNJIOMDCP
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x81DDA30", Offset = "0x81DC830", VA = "0x1881DDA30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public bool BJODEMGPPOI
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x81DD540", Offset = "0x81DC340", VA = "0x1881DD540")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x81DE000", Offset = "0x81DCE00", VA = "0x1881DE000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action OHBIFHPBGHG
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x81DD1C0", Offset = "0x81DBFC0", VA = "0x1881DD1C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x81DDD60", Offset = "0x81DCB60", VA = "0x1881DDD60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action KALNMBALDBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x81DD120", Offset = "0x81DBF20", VA = "0x1881DD120")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x81DDCC0", Offset = "0x81DCAC0", VA = "0x1881DDCC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action DKBFFBBCAED
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x81DD260", Offset = "0x81DC060", VA = "0x1881DD260")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x81DDE00", Offset = "0x81DCC00", VA = "0x1881DDE00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action OOOOAHKIFDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x81DD300", Offset = "0x81DC100", VA = "0x1881DD300")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x81DDEA0", Offset = "0x81DCCA0", VA = "0x1881DDEA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<ABAOCJDIGCP, NCBHKEPILOG> AMJPDMMKEDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x81DD3A0", Offset = "0x81DC1A0", VA = "0x1881DD3A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x81DDF40", Offset = "0x81DCD40", VA = "0x1881DDF40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x81D99E0", Offset = "0x81D87E0", VA = "0x1881D99E0")]
		public bool SetDeformation(bool IIFMFKOHHKK, bool HBGMKIBALAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x81D1540", Offset = "0x81D0340", VA = "0x1881D1540")]
		protected static Material CLJKAFAHALO(Dictionary<ILFLCKOKFIB, Material> FDFJLNOBFID, Material BPPJHOECKCN, GALOBKDEPGO LDFBMIIMOMB, FHJPJKFHCMF FEMFKDHLAOB, PGMODLDJKOM DPNGCNNOBCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x81D4430", Offset = "0x81D3230", VA = "0x1881D4430")]
		protected void FJENKPALMDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x81D6340", Offset = "0x81D5140", VA = "0x1881D6340")]
		protected bool KBDBICMKLHL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x81D7630", Offset = "0x81D6430", VA = "0x1881D7630")]
		protected void NFACIOEMJEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x81D2970", Offset = "0x81D1770", VA = "0x1881D2970", Slot = "11")]
		protected virtual void EBCDODALCKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x81D7390", Offset = "0x81D6190", VA = "0x1881D7390")]
		public int MeshesAtLODCount(int OOADPHAOOIK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x81D5B60", Offset = "0x81D4960", VA = "0x1881D5B60")]
		protected static void JCGPOMAAFAL(Dictionary<LBLCCGMCKBC, List<ILFLCKOKFIB>> OKBODOGBGNF, ALGPJLLIOHP PFJIMFGKMBL, Material BPPJHOECKCN, GALOBKDEPGO FOPEMADPOPM, FHJPJKFHCMF BEIGFDDCGJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x81D09E0", Offset = "0x81CF7E0", VA = "0x1881D09E0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x81D1130", Offset = "0x81CFF30", VA = "0x1881D1130")]
		protected void CBDAKOMDOBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x81D8270", Offset = "0x81D7070", VA = "0x1881D8270")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "12")]
		protected virtual void AGINBHOLPCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x81D7DA0", Offset = "0x81D6BA0", VA = "0x1881D7DA0")]
		protected static void OAFMGPGDOJL(List<Material> FOOACNCJBEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x81D16A0", Offset = "0x81D04A0", VA = "0x1881D16A0")]
		protected static void CLNLGECEDJC(Dictionary<ILFLCKOKFIB, Material> FDFJLNOBFID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x81D24A0", Offset = "0x81D12A0", VA = "0x1881D24A0")]
		protected static void DFMAHAHOINN(Dictionary<Renderer, DEDDGBOFFDJ> AMLBAIHMMGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x81D5560", Offset = "0x81D4360", VA = "0x1881D5560")]
		protected void HLACJHCDMCA(SkinnedMeshRenderer[] IJFDLHFCHJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x81D5F70", Offset = "0x81D4D70", VA = "0x1881D5F70")]
		protected void JJAADHBAMKF(SkinnedMeshRenderer MKKELNAFDKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x81D6010", Offset = "0x81D4E10", VA = "0x1881D6010")]
		protected void JJAADHBAMKF(MeshRenderer KBGCCGJFPHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x81D7450", Offset = "0x81D6250", VA = "0x1881D7450")]
		protected void NCDKAOAIMHF(List<JBJKHPALKPK> OAJILKJDKIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x81D8A10", Offset = "0x81D7810", VA = "0x1881D8A10")]
		protected void PLJPDFNFPLM(Dictionary<string, HNDICJJKNNH<Texture2D>> OKBODOGBGNF, bool LIBAIGBDJHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x81D6FA0", Offset = "0x81D5DA0", VA = "0x1881D6FA0")]
		protected void MAIMOHPKPBC(Dictionary<LBLCCGMCKBC, List<ILFLCKOKFIB>> OKBODOGBGNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x81D5060", Offset = "0x81D3E60", VA = "0x1881D5060")]
		public float GetHandOpenClosedAxis(ABAOCJDIGCP AGCFIFCPCDJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x81DA2A0", Offset = "0x81D90A0", VA = "0x1881DA2A0")]
		public void SetHandOpenClosedAxis(ABAOCJDIGCP AGCFIFCPCDJ, float KAMNENEIJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x81D50A0", Offset = "0x81D3EA0", VA = "0x1881D50A0")]
		public NCBHKEPILOG GetHandVisualState(ABAOCJDIGCP AGCFIFCPCDJ)
		{
			return default(NCBHKEPILOG);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x81D0120", Offset = "0x81CEF20", VA = "0x1881D0120")]
		public bool AddHandVisualStateToken(ABAOCJDIGCP AGCFIFCPCDJ, NCBHKEPILOG IMLOKJDNHKC, object OBGCPOCPFIJ, AOOHGIHOBJL.JHCMNEFKFAA JFELCJGHJPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x81DBB40", Offset = "0x81DA940", VA = "0x1881DBB40")]
		public void SetWatchHand(ABAOCJDIGCP AGCFIFCPCDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x81DBC00", Offset = "0x81DAA00", VA = "0x1881DBC00")]
		public void SetWatchHands(bool AGGEJNIIFMI, bool AAELHGEDOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x81D9080", Offset = "0x81D7E80", VA = "0x1881D9080")]
		public bool RemoveHandVisualStateToken(ABAOCJDIGCP AGCFIFCPCDJ, object OBGCPOCPFIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x81D5120", Offset = "0x81D3F20", VA = "0x1881D5120")]
		public bool GetThumbsUpActive(ABAOCJDIGCP AGCFIFCPCDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x81DB550", Offset = "0x81DA350", VA = "0x1881DB550")]
		public void SetThumbsUpActive(ABAOCJDIGCP AGCFIFCPCDJ, bool INMJODOJHHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x81D50E0", Offset = "0x81D3EE0", VA = "0x1881D50E0")]
		public bool GetHandshakeActive(ABAOCJDIGCP AGCFIFCPCDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x81DA2F0", Offset = "0x81D90F0", VA = "0x1881DA2F0")]
		public void SetHandshakeActive(ABAOCJDIGCP AGCFIFCPCDJ, bool NDBKJEDOOEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x81D47F0", Offset = "0x81D35F0", VA = "0x1881D47F0")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x81DBA30", Offset = "0x81DA830", VA = "0x1881DBA30")]
		public void SetUseClassicBeanHandScale(bool HGMAIPELJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x81D1EA0", Offset = "0x81D0CA0", VA = "0x1881D1EA0")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x81D3F00", Offset = "0x81D2D00", VA = "0x1881D3F00")]
		private static void EPLLIIHAODC(Scene OKCGKPEIJGC, LoadSceneMode KJLMJGOOKJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x81D4A40", Offset = "0x81D3840", VA = "0x1881D4A40")]
		protected static void GLGHNNJBHJM(PlayerAvatarDisplayBase KDMGAHOFLPG, List<DLHFIAAGHJN> DFFDGBMFLLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x81D8DA0", Offset = "0x81D7BA0", VA = "0x1881D8DA0")]
		public BFMPGGMMDDD Rebuild()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x81D4660", Offset = "0x81D3460", VA = "0x1881D4660")]
		protected BFMPGGMMDDD FOAEOJPHCCD(bool LPJPONAMIIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x81D46C0", Offset = "0x81D34C0", VA = "0x1881D46C0", Slot = "13")]
		protected virtual BFMPGGMMDDD FOAEOJPHCCD(IList<LBLCCGMCKBC> FHKOMEAKKFA, AvatarItemBodyType HNMPLNFBDFG, bool AFLMGCHBBID, bool LFCMOEKCOGN, int[] BDCCMDDEGKI, bool LPJPONAMIIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x81D8510", Offset = "0x81D7310", VA = "0x1881D8510")]
		protected static BFMPGGMMDDD PJAOGOPMGIE(DLHFIAAGHJN NOCIIEBFFAJ, List<DLHFIAAGHJN> DFFDGBMFLLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x81D5E20", Offset = "0x81D4C20", VA = "0x1881D5E20")]
		[IteratorStateMachine(typeof(LODIDBKGNDI))]
		protected static IEnumerator<PHFDFIIIMCE> JDHKNJBAOFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x81D2080", Offset = "0x81D0E80", VA = "0x1881D2080")]
		protected static DLHFIAAGHJN DCCLJHFKNJB(List<DLHFIAAGHJN> DFFDGBMFLLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x81D9AF0", Offset = "0x81D88F0", VA = "0x1881D9AF0")]
		[AsyncStateMachine(typeof(ODFIGADILMJ))]
		public Task SetFaceCustomizationSettings(BNICAFPKAPB HHPKINNPBPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x81DBD60", Offset = "0x81DAB60", VA = "0x1881DBD60")]
		public bool UpdateFaceAndBodyCustomizationSettings(BNICAFPKAPB HHPKINNPBPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x81D5A80", Offset = "0x81D4880", VA = "0x1881D5A80")]
		public void InitializeFaceFeatures(AvatarConfiguration LPDDEHLPANK, JLFDMKNKLIE FMEDCNPIHLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x81DB2A0", Offset = "0x81DA0A0", VA = "0x1881DB2A0")]
		public void SetTeamColors(Color? ODKHAOGIPIP, bool OIOAAPBEHEB, Color EKMMCGAJOJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x155B300", Offset = "0x155A100", VA = "0x18155B300")]
		private static void MMPBHBEEAHN(Material GKIFPALLDIK, Color HGMAIPELJHM, params int[] LCODNJNIDGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x1559EA0", Offset = "0x1558CA0", VA = "0x181559EA0")]
		private static void DFLAKOOIOLJ(Material GKIFPALLDIK, Texture HGMAIPELJHM, params int[] LCODNJNIDGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x81D6D20", Offset = "0x81D5B20", VA = "0x1881D6D20")]
		protected void LLMJLNIGHAB(Material FJFGKPCPLNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x81D2C40", Offset = "0x81D1A40", VA = "0x1881D2C40")]
		protected void ENEPKMDHMDB(Material FJFGKPCPLNJ, Color GOEHOJJKAJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x81D4E40", Offset = "0x81D3C40", VA = "0x1881D4E40")]
		protected void GOPAOOCBMBC(Material FJFGKPCPLNJ, Color GOEHOJJKAJG, Color IJONHFAIDGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x81D5250", Offset = "0x81D4050", VA = "0x1881D5250")]
		protected void HCLIKDEMPED(Material FJFGKPCPLNJ, Texture2D JDNNGPGPIOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x81D6C10", Offset = "0x81D5A10", VA = "0x1881D6C10")]
		protected void LJGKBJJEIOA(Material FJFGKPCPLNJ, Texture AIBAFJLALAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x81D7230", Offset = "0x81D6030", VA = "0x1881D7230")]
		protected void MFGKNPCGCHF(Action<DEDDGBOFFDJ> MLEHFGJHGME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x81D26E0", Offset = "0x81D14E0", VA = "0x1881D26E0")]
		protected void DPBNPPBBDII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x81D0B60", Offset = "0x81CF960", VA = "0x1881D0B60")]
		protected void BAJLCAHIHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x81D66E0", Offset = "0x81D54E0", VA = "0x1881D66E0")]
		protected void LCCMGCANIBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x81D0470", Offset = "0x81CF270", VA = "0x1881D0470")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x81D9440", Offset = "0x81D8240", VA = "0x1881D9440")]
		public void SetBeardPrimaryColor([Optional] Color? KBGHFOOBNDI, bool EHPGKLFAPDN = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x81D9670", Offset = "0x81D8470", VA = "0x1881D9670")]
		public void SetBeardSecondaryColor([Optional] Color? KBGHFOOBNDI, bool EHPGKLFAPDN = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x81D9300", Offset = "0x81D8100", VA = "0x1881D9300")]
		public void SetBeardPattern([Optional] AvatarHairPattern AMAOPHEHBIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x81D3D90", Offset = "0x81D2B90", VA = "0x1881D3D90")]
		private void EPKECOJKIMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x81D2AF0", Offset = "0x81D18F0", VA = "0x1881D2AF0")]
		private bool EFGMFKEFPML()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x81D9E60", Offset = "0x81D8C60", VA = "0x1881D9E60")]
		public void SetHairPrimaryColor([Optional] Color? NPHMCJPPIPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x81DA080", Offset = "0x81D8E80", VA = "0x1881DA080")]
		public void SetHairSecondaryColor([Optional] Color? NPHMCJPPIPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x81D9D30", Offset = "0x81D8B30", VA = "0x1881D9D30")]
		public void SetHairPattern([Optional] AvatarHairPattern AMAOPHEHBIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x81D8F20", Offset = "0x81D7D20", VA = "0x1881D8F20")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x81D1FC0", Offset = "0x81D0DC0", VA = "0x1881D1FC0")]
		private bool DCCKEKJFMLC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x81DB0E0", Offset = "0x81D9EE0", VA = "0x1881DB0E0")]
		public void SetSkinColor(Color GICOGPHOODF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x81DB5A0", Offset = "0x81DA3A0", VA = "0x1881DB5A0")]
		public void SetUgcItemVisualOverrides(LBLCCGMCKBC JGINHCPLLLI, JLFDMKNKLIE FMEDCNPIHLH, Texture AOEDJNBBFDA, Color KDKAJNHANCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x81D1F70", Offset = "0x81D0D70", VA = "0x1881D1F70")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x81D9BF0", Offset = "0x81D89F0", VA = "0x1881D9BF0")]
		public bool SetFaceShape(AvatarFaceShape FKOHDOKFCKP, bool KAOPHNGKGNA = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x81D2BA0", Offset = "0x81D19A0", VA = "0x1881D2BA0")]
		private void EGFDGNCDINH(LPJNBIJEEIN GBKLPMDLCID, float HGMAIPELJHM, bool GDJOLJEIGEH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x81D7F00", Offset = "0x81D6D00", VA = "0x1881D7F00")]
		private void OEOMCDCIKDJ(IBEGMCKBKCO OPBMDIEPLPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x81D0DE0", Offset = "0x81CFBE0", VA = "0x1881D0DE0")]
		private void BDFJPJOEGGK(OKKHECCBEHE GDMCALFNKFD, float HGMAIPELJHM, bool BDFEAOHHGNJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x81D29D0", Offset = "0x81D17D0", VA = "0x1881D29D0")]
		private void EBPIBFKAJNL(NJAIGHPFLPG FHFKIJJNMJA, float HGMAIPELJHM, bool KKMAFHPNKBH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x81D6230", Offset = "0x81D5030", VA = "0x1881D6230")]
		private void JPNIMBKLEHB(CPMJLCAHGCO GGPOBICDJHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x81D4300", Offset = "0x81D3100", VA = "0x1881D4300")]
		private void FHGPKKBAFMJ(DHONLIEMFIB MCLCJFOKOED, float KOFCFOMGPFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x81D98A0", Offset = "0x81D86A0", VA = "0x1881D98A0")]
		public bool SetBodyShape(AvatarBodyShape PNPBMHOHCDD, bool KAOPHNGKGNA = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x81DAF50", Offset = "0x81D9D50", VA = "0x1881DAF50")]
		public bool SetNoseType(PBJKAGHPKMF BDJEBKAJJPL, bool KAOPHNGKGNA = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x81DC440", Offset = "0x81DB240", VA = "0x1881DC440")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x81DAF30", Offset = "0x81D9D30", VA = "0x1881DAF30")]
		public bool SetHideEars(bool AKCJMNIBBJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x81DAF20", Offset = "0x81D9D20", VA = "0x1881DAF20")]
		public bool SetHelmetHair(NLCKMDLDBJL LMMALPEBLOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x81DA340", Offset = "0x81D9140", VA = "0x1881DA340")]
		public void SetHatAnchorParameters(NODDIPDIFHA EBEHMDOBPAD, bool CHIEIHMKFCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x81DB0C0", Offset = "0x81D9EC0", VA = "0x1881DB0C0")]
		public bool SetShowModestyAndValidationGuidelines(bool OJLOBKNAAEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x81DBCD0", Offset = "0x81DAAD0", VA = "0x1881DBCD0")]
		public void SetupDisplayLODs(GGMKHLLHHOL LEHMKKFHANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x81D4C90", Offset = "0x81D3A90", VA = "0x1881D4C90")]
		protected int[] GNOJLOFLKAB(GGMKHLLHHOL LEHMKKFHANN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x81DB030", Offset = "0x81D9E30", VA = "0x1881DB030")]
		public void SetOutfitSelections(IList<LBLCCGMCKBC> FHKOMEAKKFA, AvatarItemBodyType HNMPLNFBDFG, bool LFCMOEKCOGN, bool LPJPONAMIIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x81DB070", Offset = "0x81D9E70", VA = "0x1881DB070")]
		public void SetOutfitSelections(IList<LBLCCGMCKBC> FHKOMEAKKFA, AvatarItemBodyType HNMPLNFBDFG, bool AFLMGCHBBID, bool LFCMOEKCOGN, bool LPJPONAMIIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x81DAFF0", Offset = "0x81D9DF0", VA = "0x1881DAFF0")]
		public BFMPGGMMDDD SetOutfitSelections(IList<LBLCCGMCKBC> FHKOMEAKKFA, AvatarItemBodyType HNMPLNFBDFG, GGMKHLLHHOL LEHMKKFHANN, bool AFLMGCHBBID, bool LFCMOEKCOGN, bool KAOPHNGKGNA = false, bool LPJPONAMIIH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x81D2110", Offset = "0x81D0F10", VA = "0x1881D2110", Slot = "14")]
		protected virtual BFMPGGMMDDD DCNPIHANKAP(IList<LBLCCGMCKBC> FHKOMEAKKFA, AvatarItemBodyType HNMPLNFBDFG, bool AFLMGCHBBID, bool LFCMOEKCOGN, GGMKHLLHHOL LEHMKKFHANN, bool KAOPHNGKGNA, bool LPJPONAMIIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x81D6B10", Offset = "0x81D5910", VA = "0x1881D6B10")]
		protected int[] LHCJBEOJABL(GGMKHLLHHOL LEHMKKFHANN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "15")]
		protected virtual MDIEIFNFGHA PDMJDLLDEJE(AvatarItemBodyType CNLBOIAIBON, Dictionary<string, GADJBANEMPG> PBLEHGOMIHH, Dictionary<string, HNDICJJKNNH<Texture2D>> OIPJBHKEJGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x81D4030", Offset = "0x81D2E30", VA = "0x1881D4030", Slot = "16")]
		protected virtual BFMPGGMMDDD FCHFBLBCLLB(IList<LBLCCGMCKBC> FHKOMEAKKFA, AvatarItemBodyType HNMPLNFBDFG, bool AFLMGCHBBID, bool LFCMOEKCOGN, int[] PKGEIKDNGCD, JDDEJEECIBC NMIJMKCFHKP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x81D7920", Offset = "0x81D6720", VA = "0x1881D7920", Slot = "17")]
		protected virtual GADJBANEMPG NODJHBJBJOH(JCFBDDLEJAA LNKFGBNCGAD, AvatarItemBodyType CNLBOIAIBON, PGMODLDJKOM DPNGCNNOBCC, GADJBANEMPG LJJFMKMGIML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "18")]
		protected virtual GADJBANEMPG HFOGJLGKFOC(AvatarItemBodyType CNLBOIAIBON, PGMODLDJKOM DPNGCNNOBCC, LCPIDECODIM IHDHFEFDGDE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x81D5680", Offset = "0x81D4480", VA = "0x1881D5680")]
		protected void IEACHIIMLLP(FMMCEONPFDK BLNHJHMKEDE, BCIIDHEJBAB.MMBHHGOHKAA JINBFOPIHGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x81D0050", Offset = "0x81CEE50", VA = "0x1881D0050")]
		protected void AMDLGMHBFDH(FMMCEONPFDK BLNHJHMKEDE, BCIIDHEJBAB.MMBHHGOHKAA JINBFOPIHGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xAF9A00", Offset = "0xAF8800", VA = "0x180AF9A00", Slot = "19")]
		protected virtual FMMCEONPFDK HHEOAFGGGJN(FMMCEONPFDK BLNHJHMKEDE, HelmetHairStyle LGKIBOLGADF, bool KBBAPAICPKA, AvatarItemBodyType HNMPLNFBDFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x81D2D60", Offset = "0x81D1B60", VA = "0x1881D2D60")]
		protected FMMCEONPFDK ENGFOIKAHNF(IList<LBLCCGMCKBC> FHKOMEAKKFA, AvatarItemBodyType MGIOHLPNFDA, bool LFCMOEKCOGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x81D1D80", Offset = "0x81D0B80", VA = "0x1881D1D80")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x81D8100", Offset = "0x81D6F00", VA = "0x1881D8100")]
		protected void OHFHOJPAPCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x81D5710", Offset = "0x81D4510", VA = "0x1881D5710")]
		protected void IJMCJLJICKP(Transform ODLFODICBEG, IEnumerable<SkinnedMeshRenderer> NIPOBMNINAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x81D0D20", Offset = "0x81CFB20", VA = "0x1881D0D20")]
		protected BCIIDHEJBAB.MMBHHGOHKAA BDDIOMGHLIP(BCIIDHEJBAB.MMBHHGOHKAA COMAGLANBAB, PGMODLDJKOM OKIGJAEMCJK)
		{
			return default(BCIIDHEJBAB.MMBHHGOHKAA);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x81D5700", Offset = "0x81D4500", VA = "0x1881D5700")]
		protected void IJHKPPMMGNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x1A923C0", Offset = "0x1A911C0", VA = "0x181A923C0")]
		protected void CDCINLOPJLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x81D4550", Offset = "0x81D3350", VA = "0x1881D4550")]
		protected void FNKAOHJNNKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x81D6A40", Offset = "0x81D5840", VA = "0x1881D6A40")]
		[AsyncStateMachine(typeof(JGHFNJNIAKO))]
		protected Task LEJPPDNFDKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x81D8B90", Offset = "0x81D7990", VA = "0x1881D8B90")]
		protected static GALOBKDEPGO POMKBHIEMCL(ALGPJLLIOHP CNNAFMPBGPA, int OBLFEOBLMJO)
		{
			return default(GALOBKDEPGO);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x81D4B40", Offset = "0x81D3940", VA = "0x1881D4B40")]
		protected static FHJPJKFHCMF GMCELDNNIHD(ALGPJLLIOHP CNNAFMPBGPA, int OBLFEOBLMJO)
		{
			return default(FHJPJKFHCMF);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x81D6690", Offset = "0x81D5490", VA = "0x1881D6690")]
		protected Transform LALLPHHOPLE(PGMODLDJKOM DPNGCNNOBCC, OutfitType KCKDFFFLAGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x81D4840", Offset = "0x81D3640", VA = "0x1881D4840")]
		protected void GGNCDACDFFA(int IDNAPJMNGPO, Material GKIFPALLDIK, ALGPJLLIOHP CNNAFMPBGPA, [Out] Texture2D EPOMGGJGNKB, [Out] Vector4 AAFLGHLLEHO, [Out] Texture2D JHBANDDMFAH, [Out] Texture2D IABMIKELJIO, [Out] Texture2D HNMLBPKKHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x81D60E0", Offset = "0x81D4EE0", VA = "0x1881D60E0")]
		protected void JPGAMNOBCLM(int IDNAPJMNGPO, Material GKIFPALLDIK, ALGPJLLIOHP CNNAFMPBGPA, [Out] Color GOIKFANCJOE, [Out] Color JDJDHGJABHK, [Out] Color BKANIHANBND, [Out] Color PBIBBJDLFFO, [Out] Color KJIBDFAENCC, [Out] Color ABKEPHAAPKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x81D8D30", Offset = "0x81D7B30", VA = "0x1881D8D30")]
		protected void PPDOFLGHKKF(Vector3 FEDKKAIHHLC, Quaternion NFKDICNPCDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x81DA8D0", Offset = "0x81D96D0", VA = "0x1881DA8D0")]
		public void SetHatAnchorParameters(NODDIPDIFHA EBEHMDOBPAD, AnchorParamsRestrictions GDCNFODJBIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x81D18A0", Offset = "0x81D06A0", VA = "0x1881D18A0")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere IMHHIKMEELF, Transform IAENKKDHDJM, NODDIPDIFHA EBEHMDOBPAD, AnchorParamsRestrictions GFNFJIBFLIK, [Out] Vector3 JONEPNABAIM, [Out] Quaternion NIALEBCNBKG, [Out] NODDIPDIFHA DNPDLKHIMGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x81D9190", Offset = "0x81D7F90", VA = "0x1881D9190")]
		public void ResetHatAnchor(Vector2 BBFOMHDOMMC, Vector3 ONNFGDICHKJ, Vector3 BFKIALLDNGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xC01ED0", Offset = "0xC00CD0", VA = "0x180C01ED0")]
		public LAFCOIILCEH GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x81D02A0", Offset = "0x81CF0A0", VA = "0x1881D02A0")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x81D03E0", Offset = "0x81CF1E0", VA = "0x1881D03E0")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x81D0210", Offset = "0x81CF010", VA = "0x1881D0210")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x81DBD00", Offset = "0x81DAB00", VA = "0x1881DBD00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x81D0E80", Offset = "0x81CFC80", VA = "0x1881D0E80")]
		protected void BDJKBGFKJEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x81DBAC0", Offset = "0x81DA8C0", VA = "0x1881DBAC0")]
		public void SetWaitForUgcTextureLoads(bool FPDPMBMNKIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x81DB940", Offset = "0x81DA740", VA = "0x1881DB940")]
		public void SetUgcTextureParameters(CJPLKIFIKIH ONHEEOKCMKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x81DCB20", Offset = "0x81DB920", VA = "0x1881DCB20")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x81D1810", Offset = "0x81D0610", VA = "0x1881D1810")]
		[CompilerGenerated]
		private void CPEIJBCBBOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x81D81B0", Offset = "0x81D6FB0", VA = "0x1881D81B0")]
		[CompilerGenerated]
		private void OIMEIBJGFEP(DEDDGBOFFDJ MANEJALKGLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x81D10A0", Offset = "0x81CFEA0", VA = "0x1881D10A0")]
		[CompilerGenerated]
		private void BJPFBCCDIMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x81D7880", Offset = "0x81D6680", VA = "0x1881D7880")]
		[CompilerGenerated]
		private void NOAHNMNNGKG(DEDDGBOFFDJ MANEJALKGLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x81D1010", Offset = "0x81CFE10", VA = "0x1881D1010")]
		[CompilerGenerated]
		private void BJPEHGIJLBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x81D5E80", Offset = "0x81D4C80", VA = "0x1881D5E80")]
		[CompilerGenerated]
		private void JFPDFNGLLHC(DEDDGBOFFDJ MANEJALKGLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x81D2650", Offset = "0x81D1450", VA = "0x1881D2650")]
		[CompilerGenerated]
		private void DMIEFEHKGMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x81D5F20", Offset = "0x81D4D20", VA = "0x1881D5F20")]
		[CompilerGenerated]
		private void JHMJOENBNDD(DEDDGBOFFDJ MANEJALKGLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x81D0F40", Offset = "0x81CFD40", VA = "0x1881D0F40")]
		[CompilerGenerated]
		private void BEIPGILNPKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x81D2920", Offset = "0x81D1720", VA = "0x1881D2920")]
		[CompilerGenerated]
		private void EALLKGNIGAM(DEDDGBOFFDJ MANEJALKGLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x81D81E0", Offset = "0x81D6FE0", VA = "0x1881D81E0")]
		[CompilerGenerated]
		private void OJCILBKHGAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x81D2390", Offset = "0x81D1190", VA = "0x1881D2390")]
		[CompilerGenerated]
		private void DDLGCFBOEKB(DEDDGBOFFDJ MANEJALKGLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x81D1460", Offset = "0x81D0260", VA = "0x1881D1460")]
		[CompilerGenerated]
		internal static bool CCIBPONFOJL(Transform AJGBJIMICMO, IEnumerable<SkinnedMeshRenderer> NDFANENINPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x81D0FD0", Offset = "0x81CFDD0", VA = "0x1881D0FD0")]
		[CompilerGenerated]
		private void BHBAEKOKBEF(DEDDGBOFFDJ MANEJALKGLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x81D5A40", Offset = "0x81D4840", VA = "0x1881D5A40")]
		[CompilerGenerated]
		private void IMNKOLPHGHF(DEDDGBOFFDJ MANEJALKGLM)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, HNBEDMLJAOM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct BDJGBCFCINO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400047F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000480")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000481")]
			public BNICAFPKAPB avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000482")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000483")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x81E03C0", Offset = "0x81DF1C0", VA = "0x1881E03C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x81E0650", Offset = "0x81DF450", VA = "0x1881E0650", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct HACABEJPHNA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000484")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000485")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			public JLFDMKNKLIE avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x81E3B60", Offset = "0x81E2960", VA = "0x1881E3B60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x81E3D40", Offset = "0x81E2B40", VA = "0x1881E3D40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct JDELGEIKBOD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000490")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000491")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000492")]
			public JLFDMKNKLIE avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000493")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x81E5310", Offset = "0x81E4110", VA = "0x1881E5310", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x81E54B0", Offset = "0x81E42B0", VA = "0x1881E54B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct KNBKPBCGDCF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000494")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public BNICAFPKAPB avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x81E5740", Offset = "0x81E4540", VA = "0x1881E5740", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x81E58F0", Offset = "0x81E46F0", VA = "0x1881E58F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct NCEBFLGEOOO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400049C")]
			public JLFDMKNKLIE avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400049D")]
			private TaskAwaiter<GNPHFACIKNJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x81E6AE0", Offset = "0x81E58E0", VA = "0x1881E6AE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x81E6F20", Offset = "0x81E5D20", VA = "0x1881E6F20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct BLKPCJLEBAF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400049E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400049F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A0")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004A1")]
			public bool forceRebuild;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			public JLFDMKNKLIE avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004A3")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x81E06B0", Offset = "0x81DF4B0", VA = "0x1881E06B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x81E0AD0", Offset = "0x81DF8D0", VA = "0x1881E0AD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		protected const float NAKBBEGFPFM = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		protected const int ICEFPLHLCJN = 5;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private static readonly int LAIIEDDGEIB;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private static readonly int LPDGCGDEILD;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		private static readonly int AFPDEIFJMFC;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected static readonly Dictionary<GNPMJJJFECL.OKJONPIPIEB, int> ODLHJNNLGEJ;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> FBBIKJMMFBA;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected static readonly int PCHCAKFGEHM;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected static readonly int MHMPBDLLFFP;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected static readonly int MKLBPMLEPDL;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected static readonly int DLLKFDGKDON;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected static readonly int APEFEDIBKOO;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected static Vector2 CBOMKOBHBMC;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected static Vector2 CGJABFAGDIG;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected static Vector2 BEMMHEBDPIO;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected static Vector2 FELDBOICCHB;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected static Vector2 GCGGMDKFBNO;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected static Vector2 EALMELDHEFC;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected static Vector2 IJLKBBBHNMM;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		protected static Vector2 ECCIHMMPMFH;

		[Cpp2IlInjected.Token(Token = "0x4000438")]
		protected static Vector2 MNPOILIJPJF;

		[Cpp2IlInjected.Token(Token = "0x4000439")]
		protected static Vector2 EFMGDHOCFKC;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected static Vector2 LCNLBKPMPMF;

		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected static Vector2 BICPNFGPPFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		[LAEBPIHCEIF(FBMDOBLPJCI.Self, false, false, false)]
		[SerializeField]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		[Header("Rendering")]
		[SerializeField]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		[SerializeField]
		[Header("Emotes")]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		[SerializeField]
		[Header("Modern Avatar Facial Features")]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		private JLFDMKNKLIE BGMNABFPHCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		private FaceStyleSet GCEKIPBBAAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x4000445")]
		protected const int LKFBMJNOLCC = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		protected int DJGLDMBNPBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected int EHBBELDPGAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		protected int PMCANLMKJIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		protected int IGBKIGHEJIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		protected Vector2 IKOBBJCCCJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		protected float BGAJBNBMKPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		protected float LKNJNDIEKEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		protected float IPAPGPJNNNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		protected Vector2 AJDICNPECDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		protected float IKKOIMMGBBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		protected float CFNAECGKJMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		protected float PDIMHNKDFCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		protected Vector2 EAHOJOOEMKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		protected float GKIOJLAIBLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		protected float BBPALNPJIII;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		protected float NANADFIEAGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		protected Vector2 CPPIIODCBBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		protected float PMJKFPIOKFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		protected float NAIDDLNALJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		protected float PFHCLCIMIKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		protected List<SelectableFaceOption> FNCBFMGPAOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		protected List<SelectableFaceOption> DDOEAFDBCDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		protected List<SelectableFaceOption> HBBOFHBIOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		protected List<SelectableFaceOption> ALHJCPKNNFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		protected Coroutine JLEJHGHMLBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		protected int? OEMMDMNLDNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		protected int MKMODCEHNJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		protected int MEPLLFFLGBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		protected int DLMAPMNABDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		protected int POJHBHEHFFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		protected Sprite PGMFPHKDCNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		protected Sprite MIOLLCDLMBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		protected Sprite BGBJOMDNLLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		protected Sprite JBPPACLOIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		protected bool DNMACMGPHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		protected string NBHPGDFMPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		protected string EGABICLLPMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		protected string EDPKLBLFPAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		protected string IHBJIAILEFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		protected AvatarConfiguration LPDDEHLPANK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		protected GNPHFACIKNJ NFIIGHDEHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private readonly List<Material> HBBCJCHCNKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		protected JMADJNPNEMM DGKEELOHLKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		protected Dictionary<string, int> KEFLCGLLOKP;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public FaceStyleSet KPAAPDANPAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x81EDB70", Offset = "0x81EC970", VA = "0x1881EDB70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public bool GFIKDCHCPJA
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0xB46C70", Offset = "0xB45A70", VA = "0x180B46C70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x270DFC0", Offset = "0x270CDC0", VA = "0x18270DFC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		protected virtual bool OBOPFKAKOKD
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		protected virtual bool DPJNBIJPCHB
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		protected int ICDALCCPPFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x81E89E0", Offset = "0x81E77E0", VA = "0x1881E89E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public Renderer DNFNPAHBFAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool DLKAGANGIKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x2717370", Offset = "0x2716170", VA = "0x182717370")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x270C8A0", Offset = "0x270B6A0", VA = "0x18270C8A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Renderer[] EFIAKOLNDKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public bool FHFHMHBMLGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x81EDBC0", Offset = "0x81EC9C0", VA = "0x1881EDBC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x81EDD80", Offset = "0x81ECB80", VA = "0x1881EDD80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		protected int OCFLCMNOCOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x81E8BF0", Offset = "0x81E79F0", VA = "0x1881E8BF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		protected int LKCODIDNAGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x81E8470", Offset = "0x81E7270", VA = "0x1881E8470")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public float BEAHPGJOFDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x81EDBA0", Offset = "0x81EC9A0", VA = "0x1881EDBA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x81EDD60", Offset = "0x81ECB60", VA = "0x1881EDD60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public EDFBLEEALAN CHGFBPCCMBK
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0xB6C9A0", Offset = "0xB6B7A0", VA = "0x180B6C9A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0xB6A120", Offset = "0xB68F20", VA = "0x180B6A120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public GNPHFACIKNJ CBEFJNBBEDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0xBA6E30", Offset = "0xBA5C30", VA = "0x180BA6E30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x81EDCE0", Offset = "0x81ECAE0", VA = "0x1881EDCE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public NoseFaceOption MNIHMHBBIFG
		{
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0xB896C0", Offset = "0xB884C0", VA = "0x180B896C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0xC03160", Offset = "0xC01F60", VA = "0x180C03160")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		protected JMADJNPNEMM BMHCCPIBLAH
		{
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x81EACC0", Offset = "0x81E9AC0", VA = "0x1881EACC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action NEIBJCCBHDP
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x81EDAC0", Offset = "0x81EC8C0", VA = "0x1881EDAC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x81EDC30", Offset = "0x81ECA30", VA = "0x1881EDC30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x81EA790", Offset = "0x81E9590", VA = "0x1881EA790")]
		public void LocalPlayEmote(GNPMJJJFECL.OKJONPIPIEB PPLPGKPEINL, float PAINEOJNOOI = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x81E9A00", Offset = "0x81E8800", VA = "0x1881E9A00")]
		public bool IsEmotePlaying(GNPMJJJFECL.OKJONPIPIEB PPLPGKPEINL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x81EBAE0", Offset = "0x81EA8E0", VA = "0x1881EBAE0")]
		public void SetIdleHappy(bool OPNEPCPKEDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x81EAA80", Offset = "0x81E9880", VA = "0x1881EAA80")]
		protected void MPDOIGHLOOM(bool AEINFDFOGCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x81E84D0", Offset = "0x81E72D0", VA = "0x1881E84D0")]
		protected void EOIPIJHIPKM(bool JDOJJAPIFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x81EA890", Offset = "0x81E9690", VA = "0x1881EA890")]
		protected void MCOFCDGFKMF(PGMODLDJKOM DPNGCNNOBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x81E8C50", Offset = "0x81E7A50", VA = "0x1881E8C50")]
		protected void HNFILPLOECE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x81EB1B0", Offset = "0x81E9FB0", VA = "0x1881EB1B0")]
		public void PlayExpression(int PCAKGLHHMPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x81E8720", Offset = "0x81E7520", VA = "0x1881E8720")]
		protected void GLOEDEOAAPL(bool JMIFOIBJHIA, bool HDPGCPGLDKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x81E89A0", Offset = "0x81E77A0", VA = "0x1881E89A0")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType IHPPFHNIKKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x81E94F0", Offset = "0x81E82F0", VA = "0x1881E94F0")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration LPDDEHLPANK, JLFDMKNKLIE FMEDCNPIHLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x81EB8B0", Offset = "0x81EA6B0", VA = "0x1881EB8B0")]
		[AsyncStateMachine(typeof(BDJGBCFCINO))]
		public Task SetFaceSettings(BNICAFPKAPB HHPKINNPBPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x81EB780", Offset = "0x81EA580", VA = "0x1881EB780")]
		[AsyncStateMachine(typeof(HACABEJPHNA))]
		public Task SetFaceSettings(int LMOEABNJAHC, int MPMGAIHDAIE, int PIJELAHFAAL, int BCMLCIDHHEI, JLFDMKNKLIE FMEDCNPIHLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x81EBB60", Offset = "0x81EA960", VA = "0x1881EBB60")]
		[AsyncStateMachine(typeof(JDELGEIKBOD))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType IHPPFHNIKKI, int LFNMJOPEBLO, JLFDMKNKLIE FMEDCNPIHLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x81EA900", Offset = "0x81E9700", VA = "0x1881EA900")]
		protected void MOGGPBIBCKK(FaceFeatureType IHPPFHNIKKI, NJKDBAMDGPL BDOCIJPOLPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x81E7C30", Offset = "0x81E6A30", VA = "0x1881E7C30")]
		protected void BIAFEMJNPLN(FaceFeatureType IHPPFHNIKKI, int LFNMJOPEBLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x81E87D0", Offset = "0x81E75D0", VA = "0x1881E87D0")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x81EABD0", Offset = "0x81E99D0", VA = "0x1881EABD0")]
		[AsyncStateMachine(typeof(KNBKPBCGDCF))]
		protected Task NMKMJFAFIMF(BNICAFPKAPB HHPKINNPBPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x81E7930", Offset = "0x81E6730", VA = "0x1881E7930")]
		protected void BFELCEOBAEC(BNICAFPKAPB HHPKINNPBPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x81EA0F0", Offset = "0x81E8EF0", VA = "0x1881EA0F0")]
		protected static void KLJIMIKLJLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x81EAD40", Offset = "0x81E9B40", VA = "0x1881EAD40")]
		private void OFAFCJCLNHK(bool GIKAIJGBEEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x81EA400", Offset = "0x81E9200", VA = "0x1881EA400")]
		protected void LJDDGLIBDPC(FaceFeatureType IHPPFHNIKKI, Vector2 EHGNGBDPBKM, JLFDMKNKLIE FMEDCNPIHLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x81EB1D0", Offset = "0x81E9FD0", VA = "0x1881EB1D0")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType IHPPFHNIKKI, Vector2 GMBOCFIDDEF, JLFDMKNKLIE FMEDCNPIHLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x81E9F70", Offset = "0x81E8D70", VA = "0x1881E9F70")]
		protected void KDFMHONOFDC(FaceFeatureType IHPPFHNIKKI, float LEBBGIACMDC, JLFDMKNKLIE FMEDCNPIHLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x81EA280", Offset = "0x81E9080", VA = "0x1881EA280")]
		protected void KPGMPDJLMFG(FaceFeatureType IHPPFHNIKKI, float GKEKGHNHKDP, JLFDMKNKLIE FMEDCNPIHLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x81EAB00", Offset = "0x81E9900", VA = "0x1881EAB00")]
		protected void NEHOMKAACLP(FaceFeatureType IHPPFHNIKKI, float GEHBABBAODJ, JLFDMKNKLIE FMEDCNPIHLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x81EB560", Offset = "0x81EA360", VA = "0x1881EB560")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType IHPPFHNIKKI, float CDEDPJLLBDI, JLFDMKNKLIE FMEDCNPIHLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x81E8CC0", Offset = "0x81E7AC0", VA = "0x1881E8CC0")]
		[AsyncStateMachine(typeof(NCEBFLGEOOO))]
		protected Task HPJFBCEMBMP(JLFDMKNKLIE FMEDCNPIHLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x81E97F0", Offset = "0x81E85F0", VA = "0x1881E97F0")]
		public void InitializeFaceFeatureStyleSet(JLFDMKNKLIE FMEDCNPIHLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x81E8B10", Offset = "0x81E7910", VA = "0x1881E8B10")]
		protected bool HGCNIAHJOPK(string CEMDAKIFMAH, [Out] int JJJJBEGKNIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x81E77F0", Offset = "0x81E65F0", VA = "0x1881E77F0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x81EBC70", Offset = "0x81EAA70", VA = "0x1881EBC70", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x81EAFA0", Offset = "0x81E9DA0", VA = "0x1881EAFA0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x81ECC60", Offset = "0x81EBA60", VA = "0x1881ECC60")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x81E8370", Offset = "0x81E7170", VA = "0x1881E8370")]
		[AsyncStateMachine(typeof(BLKPCJLEBAF))]
		public Task BuildFaceStyleAsyncIfChanged(JLFDMKNKLIE FMEDCNPIHLH, bool KAOPHNGKGNA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x81EC570", Offset = "0x81EB370", VA = "0x1881EC570")]
		public void UpdateFaceDisplays(bool JKDBOJMHMIM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x81E8DA0", Offset = "0x81E7BA0", VA = "0x1881E8DA0")]
		protected bool IMFJDGPKDFL(bool JKDBOJMHMIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x81EC2D0", Offset = "0x81EB0D0", VA = "0x1881EC2D0")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x81EB9A0", Offset = "0x81EA7A0", VA = "0x1881EB9A0")]
		public void SetFaceSpriteIndices(string BIHLCGANPCO, string MHJABGCJJMC, string NKOMJHGNPCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x81EBC80", Offset = "0x81EAA80", VA = "0x1881EBC80")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x81EC790", Offset = "0x81EB590", VA = "0x1881EC790")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x81EC980", Offset = "0x81EB780", VA = "0x1881EC980")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x81E8630", Offset = "0x81E7430", VA = "0x1881E8630")]
		protected void FGIIBBHOJCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x81E9B20", Offset = "0x81E8920", VA = "0x1881E9B20")]
		private void JIFPANLDEMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x81E9DD0", Offset = "0x81E8BD0", VA = "0x1881E9DD0")]
		private void JIHCJJIAJOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x81ED870", Offset = "0x81EC670", VA = "0x1881ED870")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xAC1030", Offset = "0xABFE30", VA = "0x180AC1030", Slot = "4")]
		private bool DOPDOPHOHMN()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct EGMGPKFKBEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public string LBDOKALIJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public int FBLHFPABBMB;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[ExecuteInEditMode]
	[SelectionBase]
	public class PlayerModernBodyEditorAvatarValidator : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private struct MGBBNNKMIAP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400050A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400050B")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400050C")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400050D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x81E68E0", Offset = "0x81E56E0", VA = "0x1881E68E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0xAE56D0", Offset = "0xAE44D0", VA = "0x180AE56D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private struct LPAHNLACDBM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400050E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400050F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000510")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000511")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x81E6380", Offset = "0x81E5180", VA = "0x1881E6380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x81E6880", Offset = "0x81E5680", VA = "0x1881E6880", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public JLFDMKNKLIE avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public NLCKMDLDBJL useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public NODDIPDIFHA hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public LAFCOIILCEH HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public GameObject torsoModestyPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public GameObject legsModestyPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public GameObject validationPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public bool showModestyAndValidationGuidelines;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public long baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		[LAEBPIHCEIF(FBMDOBLPJCI.Self, false, false, false)]
		[SerializeField]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private GLEHLDHLKFL INAMENIBMDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		[LAEBPIHCEIF(FBMDOBLPJCI.Self, false, false, false)]
		[SerializeField]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private AnimatorOverrideController AIOAKBIOOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> JCACMINLNNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public readonly EGMGPKFKBEA[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public readonly (string, NCBHKEPILOG)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x249")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24A")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		protected bool INELPJMLLHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		protected Guid GDDPKIIHAJM;

		[Cpp2IlInjected.Token(Token = "0x4000500")]
		protected static Guid AKEPAKNBOOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private FCEMHMOCEFP HBJHBEHIBFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private EDFBLEEALAN OIDBKAMLNGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private ELMDBEFEDJJ CPANCJHMHLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private ELMDBEFEDJJ IEMIELGHOKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private AdditionalHatData LEMCMOHNGAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private readonly Dictionary<GameObject, JCFBDDLEJAA> AKJOIKLKOLB;

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public static Func<LCPIDECODIM> CFHPDLFDNHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x81F2F30", Offset = "0x81F1D30", VA = "0x1881F2F30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x81F3570", Offset = "0x81F2370", VA = "0x1881F3570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public bool DCCKEKJFMLC
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x81F3090", Offset = "0x81F1E90", VA = "0x1881F3090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public bool EFGMFKEFPML
		{
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x81F2F80", Offset = "0x81F1D80", VA = "0x1881F2F80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public PlayerAvatarDisplayBase AJJACHLMMFH
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0xC10420", Offset = "0xC0F220", VA = "0x180C10420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		protected static Guid EGKBJMIPPMF
		{
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x81EF190", Offset = "0x81EDF90", VA = "0x1881EF190")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public (GameObject, PGMODLDJKOM)[] OJMOKPLMKNN
		{
			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x81F31A0", Offset = "0x81F1FA0", VA = "0x1881F31A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x81F0C70", Offset = "0x81EFA70", VA = "0x1881F0C70")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x81EF580", Offset = "0x81EE380", VA = "0x1881EF580")]
		private IEnumerable<GameObject> IIIECHHFPBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x81F1190", Offset = "0x81EFF90", VA = "0x1881F1190")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x81F0620", Offset = "0x81EF420", VA = "0x1881F0620")]
		private void MCGBJHBKPEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x153FB40", Offset = "0x153E940", VA = "0x18153FB40")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x81EF9F0", Offset = "0x81EE7F0", VA = "0x1881EF9F0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x81F11A0", Offset = "0x81EFFA0", VA = "0x1881F11A0")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x81F0FB0", Offset = "0x81EFDB0", VA = "0x1881F0FB0")]
		public void ShowPose(AnimationClip FOAELGPIFGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x81F1160", Offset = "0x81EFF60", VA = "0x1881F1160")]
		public void ShowPose(string MCEPNABMJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x81F0DE0", Offset = "0x81EFBE0", VA = "0x1881F0DE0")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x81F0C80", Offset = "0x81EFA80", VA = "0x1881F0C80")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x81F1C70", Offset = "0x81F0A70", VA = "0x1881F1C70")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x81F1AC0", Offset = "0x81F08C0", VA = "0x1881F1AC0")]
		public void UpdateFaceAndBodyShapes(bool KAOPHNGKGNA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x81F2080", Offset = "0x81F0E80", VA = "0x1881F2080")]
		public void UpdateNoseShape(PBJKAGHPKMF BDJEBKAJJPL, bool KAOPHNGKGNA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x81F2050", Offset = "0x81F0E50", VA = "0x1881F2050")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x81F0960", Offset = "0x81EF760", VA = "0x1881F0960", Slot = "4")]
		protected virtual void OPONILEPNKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x81EF280", Offset = "0x81EE080", VA = "0x1881EF280", Slot = "5")]
		protected virtual void FHFKMNHJCOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x81EE090", Offset = "0x81ECE90", VA = "0x1881EE090")]
		public void ApplyHatData(AdditionalHatData PGKDIILHKKK, bool EHICAEMGEEL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x81EDED0", Offset = "0x81ECCD0", VA = "0x1881EDED0")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x81EE3F0", Offset = "0x81ED1F0", VA = "0x1881EE3F0")]
		public void ApplyHatUVOverride(Vector2 CIDLOPFMHLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x81EE310", Offset = "0x81ED110", VA = "0x1881EE310")]
		public void ApplyHatPositionAdjustment(Vector3 IBMJKJMAOHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x81EE380", Offset = "0x81ED180", VA = "0x1881EE380")]
		public void ApplyHatRotationAdjustment(Vector3 FLIEPJPIKGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x81EE7E0", Offset = "0x81ED5E0", VA = "0x1881EE7E0")]
		public LBLCCGMCKBC BuildAvatarItemSelection(GameObject FMEHFHOHHBL, JLFDMKNKLIE CNLBOIAIBON, PGMODLDJKOM ABHPOMDMIKN)
		{
			return default(LBLCCGMCKBC);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x81EE880", Offset = "0x81ED680", VA = "0x1881EE880")]
		public void BuildAvatar(bool KAOPHNGKGNA = false, bool EHICAEMGEEL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x81F1500", Offset = "0x81F0300", VA = "0x1881F1500")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x81EE010", Offset = "0x81ECE10", VA = "0x1881EE010")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x81F1EA0", Offset = "0x81F0CA0", VA = "0x1881F1EA0")]
		public void UpdateHatAnchor(bool EHICAEMGEEL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x81F1BC0", Offset = "0x81F09C0", VA = "0x1881F1BC0")]
		[AsyncStateMachine(typeof(MGBBNNKMIAP))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x81F07E0", Offset = "0x81EF5E0", VA = "0x1881F07E0")]
		[AsyncStateMachine(typeof(LPAHNLACDBM))]
		private Task OKEGCHMPABA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x81EEED0", Offset = "0x81EDCD0", VA = "0x1881EEED0")]
		private void DDCBEJOOHDB(FaceFeatureType BJLOCBNAGBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x81EF4F0", Offset = "0x81EE2F0", VA = "0x1881EF4F0")]
		private void FNEIEDCFEJL(FaceFeatureType BJLOCBNAGBJ, [Out] float NEGOPOONDJN, [Out] float KDBGLOFEHFC, [Out] float KBAEKIALOKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x81F1980", Offset = "0x81F0780", VA = "0x1881F1980")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x81F1D00", Offset = "0x81F0B00", VA = "0x1881F1D00")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x81F00F0", Offset = "0x81EEEF0", VA = "0x1881F00F0")]
		private void JBHKFDJKLGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
		private void LCOBIOJOHIC(JCFBDDLEJAA LNKFGBNCGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
		private void MHPLFDMAHCM(JCFBDDLEJAA LNKFGBNCGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x81EE460", Offset = "0x81ED260", VA = "0x1881EE460")]
		private void BIHCEEJPKDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x81F2100", Offset = "0x81F0F00", VA = "0x1881F2100")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x81F08B0", Offset = "0x81EF6B0", VA = "0x1881F08B0")]
		[CompilerGenerated]
		private LBLCCGMCKBC OLGACONCJAI((GameObject, PGMODLDJKOM) JLDADHMBKKH)
		{
			return default(LBLCCGMCKBC);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		[LAEBPIHCEIF(FBMDOBLPJCI.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct LBLCCGMCKBC
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class HKJPIGCDHJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public HKJPIGCDHJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x81E3DA0", Offset = "0x81E2BA0", VA = "0x1881E3DA0")]
		internal bool HEEFJLJHFBL(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	private JCFBDDLEJAA OPMDEJNOCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	private PGMODLDJKOM PDNOALOJLOI;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public JCFBDDLEJAA NFCNGHAIHAP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public PGMODLDJKOM ALGBMMFFJDO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xEA86B0", Offset = "0xEA74B0", VA = "0x180EA86B0")]
		get
		{
			return default(PGMODLDJKOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public string ONEJLDMHNMF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x81E5950", Offset = "0x81E4750", VA = "0x1881E5950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool AJBGCDMHHCG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x81E5FA0", Offset = "0x81E4DA0", VA = "0x1881E5FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool PLPFOJABBAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x81E5E90", Offset = "0x81E4C90", VA = "0x1881E5E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x1AA7590", Offset = "0x1AA6390", VA = "0x181AA7590")]
	public LBLCCGMCKBC(JCFBDDLEJAA LNKFGBNCGAD, PGMODLDJKOM DPNGCNNOBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x81E5EE0", Offset = "0x81E4CE0", VA = "0x1881E5EE0")]
	public bool OPCGOJLDHNH(OutfitType IBNABCDGACD, PGMODLDJKOM IICLCBDBMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x81E5A40", Offset = "0x81E4840", VA = "0x1881E5A40")]
	public bool DDDFEJOJEDM(OutfitType IBNABCDGACD, PGMODLDJKOM IICLCBDBMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x81E5CA0", Offset = "0x81E4AA0", VA = "0x1881E5CA0")]
	public bool FPFAHAOEEBF(LBLCCGMCKBC NHHFHCNFBNH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class NGABBPHPBDA
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class JCDNEJGIFEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public JCDNEJGIFEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x81E5290", Offset = "0x81E4090", VA = "0x1881E5290")]
		internal bool HEEFJLJHFBL(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	private JCFBDDLEJAA OPMDEJNOCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private IENPMNBMDGB PDNOALOJLOI;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public JCFBDDLEJAA NFCNGHAIHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public IENPMNBMDGB ALGBMMFFJDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xAE1A10", Offset = "0xAE0810", VA = "0x180AE1A10")]
		get
		{
			return default(IENPMNBMDGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Color MDANDEECNMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xE849B0", Offset = "0xE837B0", VA = "0x180E849B0")]
		[CompilerGenerated]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xE84830", Offset = "0xE83630", VA = "0x180E84830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 NFKDICNPCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0xE9B400", Offset = "0xE9A200", VA = "0x180E9B400")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0xE9B540", Offset = "0xE9A340", VA = "0x180E9B540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x81E70B0", Offset = "0x81E5EB0", VA = "0x1881E70B0")]
	public NGABBPHPBDA(JCFBDDLEJAA LNKFGBNCGAD, IENPMNBMDGB DPNGCNNOBCC, Color BGBIPHDMBPB, Vector3 GKEKGHNHKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x81E6F80", Offset = "0x81E5D80", VA = "0x1881E6F80")]
	public bool FPFAHAOEEBF(NGABBPHPBDA NHHFHCNFBNH)
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
