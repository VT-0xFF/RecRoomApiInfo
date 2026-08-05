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
using RecRoom.Avatars.Data.Shared;
using RecRoom.Core.Studio;
using RecRoom.DataLayer.Attributes;
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
	public class LogRegistrationIndex : ADNHPIGEHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6BCF330", Offset = "0x6BCE730", VA = "0x186BCF330", Slot = "4")]
		public override void CIGOIKFLIDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_AvatarRenderingSystems_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : KNLEODIDJOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6BD5920", Offset = "0x6BD4D20", VA = "0x186BD5920", Slot = "8")]
		public override void LFFFLDDGBMJ(GFPLBLFDLJF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x63F5FE0", Offset = "0x63F53E0", VA = "0x1863F5FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNAssetReference : AssetReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private RecNetCDNKey key;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override object RuntimeKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8A0F80", Offset = "0x8A0380", VA = "0x1808A0F80", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6BD5030", Offset = "0x6BD4430", VA = "0x186BD5030", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6BD4F50", Offset = "0x6BD4350", VA = "0x186BD4F50", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6BD4FF0", Offset = "0x6BD43F0", VA = "0x186BD4FF0")]
		public RecNetCDNAssetReference(RecNetCDNKey PBFBBOFLBNL)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
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
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x89CED0", Offset = "0x89C2D0", VA = "0x18089CED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x89EF10", Offset = "0x89E310", VA = "0x18089EF10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x89EF00", Offset = "0x89E300", VA = "0x18089EF00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6BD5070", Offset = "0x6BD4470", VA = "0x186BD5070")]
		public static RecNetCDNKey JNOPEMLNNND(string JJMKOEJBIKF, string ELCDFEOOKPL = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x63B5950", Offset = "0x63B4D50", VA = "0x1863B5950")]
		public void DFLMECABBIC(string CMOLKFNEPOJ, string KOJHIJJELLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6BD5170", Offset = "0x6BD4570", VA = "0x186BD5170")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[MMCIGIHMOCH]
public class ECEFGBJJGMN : FHLLNHIGCJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> LHNMHJLLIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> LIDPELLPEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> MBMFJKLGBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> JAAEHDJOFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> JOGIAOLDGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> BCIDCFKIJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> EAOPJJDOLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator DFOPNILBMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected DNCEGEOKKGI EFGAEFEAAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte JCPACFNBJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> LFEKHNBKLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> LIMPNINOALO;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6BCCBE0", Offset = "0x6BCBFE0", VA = "0x186BCCBE0", Slot = "4")]
	public void BOEEECNBGLP(Mesh OHLMFEKEKFF, Matrix4x4 FOCGEGABAAO, byte[] OBGHHALHAII, bool KALIPOHFMAN = false, MNFPGDBOOJI.NOHJIBHJCAM MLLDOIFDHDG = (MNFPGDBOOJI.NOHJIBHJCAM)0, int GJGMCILPJFD = -1, bool JNGFKAEGDLK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6BCCDF0", Offset = "0x6BCC1F0", VA = "0x186BCCDF0", Slot = "5")]
	public void JFMHMGFBLGI(Allocator DBCOPEDFGJL, DNCEGEOKKGI GMDCOELEBEB, byte HEDIDNDAPOF, [Optional] IList<int> HBFLPPHKPHM, [Optional] IList<int> PPBGFDPMGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6BCCE30", Offset = "0x6BCC230", VA = "0x186BCCE30")]
	private static void LIAPIDKODKD(Mesh OHLMFEKEKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6BCD090", Offset = "0x6BCC490", VA = "0x186BCD090")]
	public ECEFGBJJGMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[MMCIGIHMOCH]
public struct AFNNHNHBNNK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public LPLIGFJOCPA JHMPFGMBEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int FHGKJDIICFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public PMJFANDLCPB HPBCJBOHENE;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6BBD4B0", Offset = "0x6BBC8B0", VA = "0x186BBD4B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NativeContainer]
[MMCIGIHMOCH]
public struct PMJFANDLCPB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct IFDDOCIJPFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector3 GCPBFDKDGJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 HAGCLANLPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector4 DDAAOLNLDGA;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct KGKKDLCNGCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float KAOIDHAJONL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float JJOPBOPEGBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float MADFGDFOGIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float MJNNKNEALOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte EEDPGJJLCPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte NPJEACHDPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte PJCIIOPIMGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte DEFDKNGABDK;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct ICLFIIJFFGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half KAOIDHAJONL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half JJOPBOPEGBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half MADFGDFOGIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half MJNNKNEALOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte EEDPGJJLCPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte NPJEACHDPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte PJCIIOPIMGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte DEFDKNGABDK;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct LIDOACPFBOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 FKCCOIADMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 AKALMIIHBNP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct JEOELGBACGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half4 FKCCOIADMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 AKALMIIHBNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 FBEMDEFHINL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct MANLFIKBNEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 FKCCOIADMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 AKALMIIHBNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 FBEMDEFHINL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 FAHOJPJHHKK;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct IIDOBECBOEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half4 FKCCOIADMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 AKALMIIHBNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 FBEMDEFHINL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 FAHOJPJHHKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 MIHMJENGEOH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct DJGECIPOPAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float KAOIDHAJONL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float JJOPBOPEGBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float MADFGDFOGIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float MJNNKNEALOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int EEDPGJJLCPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int NPJEACHDPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int PJCIIOPIMGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int DEFDKNGABDK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct IMDCPANICJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Color FKCCOIADMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 AKALMIIHBNP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct FKJCKIJGNIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color FKCCOIADMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 AKALMIIHBNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 FBEMDEFHINL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct DAKKPCBOIGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color FKCCOIADMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 AKALMIIHBNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 FBEMDEFHINL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 FAHOJPJHHKK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct JHBNFDHPGED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color FKCCOIADMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 AKALMIIHBNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 FBEMDEFHINL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 FAHOJPJHHKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 MIHMJENGEOH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool KPDPOILHMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<IFDDOCIJPFK> MLHCGDPINMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<LIDOACPFBOM> DNEBDGHHDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<JEOELGBACGD> PHEILNHJCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<MANLFIKBNEA> CBNEMANAJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<IIDOBECBOEG> EEPNGDFDHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<ICLFIIJFFGG> OMLAOBJELFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<KGKKDLCNGCP> GEHENKCHABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<IMDCPANICJO> LODEFAFKDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<FKJCKIJGNIG> KIANNBMGKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<DAKKPCBOIGE> KOFJMMLNDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<JHBNFDHPGED> IPDEEADDOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<DJGECIPOPAM> KLOLNBLIGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> CJHFEHPFNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> POJMDKFICPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> MDFDLDAPGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> BJKAGFFBINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> LMLENBOAKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> EDLNDLNMIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> INEKFBLHCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<BoneWeight> OKDDBCKHOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> FFHLFAMMNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool HCJPHIAALGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool PNPNEDHJMEB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int OAHKMBHGHJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6BD3940", Offset = "0x6BD2D40", VA = "0x186BD3940")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6BD38D0", Offset = "0x6BD2CD0", VA = "0x186BD38D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KIELJGMCDFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6BD25C0", Offset = "0x6BD19C0", VA = "0x186BD25C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6BD2840", Offset = "0x6BD1C40", VA = "0x186BD2840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int NFBIMIPDHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6BD44B0", Offset = "0x6BD38B0", VA = "0x186BD44B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6BD2830", Offset = "0x6BD1C30", VA = "0x186BD2830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int OKNOJNKELJF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6BD3790", Offset = "0x6BD2B90", VA = "0x186BD3790")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6BD44D0", Offset = "0x6BD38D0", VA = "0x186BD44D0")]
	public PMJFANDLCPB(int KGMOHKBNKPK, int BLADNIFIOBF, int OGNMLEEFENF, int BOIOBNOHLHL, Allocator DBCOPEDFGJL, int DCHNKFCNOFG, OIIMIGOJKBD BCDMFCAGEGD, bool HCJPHIAALGH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6BD2530", Offset = "0x6BD1930", VA = "0x186BD2530")]
	public void BCDDDHFEHLF(int OBFJPFHENMC, Vector3 FCBPGONDPJI, Vector3 KNIHHDMJHNC, Vector4 BNBMPMKBBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6BD3950", Offset = "0x6BD2D50", VA = "0x186BD3950")]
	public void KJMNIDJBFFO(int OBFJPFHENMC, BoneWeight HHHLKMNLGBB, NativeSlice<byte> OBGHHALHAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6BD3D80", Offset = "0x6BD3180", VA = "0x186BD3D80")]
	public Color KMGOKHMFKPK(int OBFJPFHENMC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6BD40B0", Offset = "0x6BD34B0", VA = "0x186BD40B0")]
	public void MFELIBOMADK(int OBFJPFHENMC, Color JPCJICGNBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6BD2180", Offset = "0x6BD1580", VA = "0x186BD2180")]
	public void AIDCMDANKEO(byte BBDECHIHNFC, int OBFJPFHENMC, Vector2 CGDBFDNICEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6BD44C0", Offset = "0x6BD38C0", VA = "0x186BD44C0")]
	public void OPCHIBPJJDE(int OBFJPFHENMC, int FPKIGOLKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6BD38E0", Offset = "0x6BD2CE0", VA = "0x186BD38E0")]
	public bool KEHOCCPNHJP(int BBDECHIHNFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6BD3800", Offset = "0x6BD2C00", VA = "0x186BD3800")]
	public void JDPMEKHFLIM(int OANDIIGFFCD, int HHOJFKLGPBP, int LGPCCHEOHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6BD25D0", Offset = "0x6BD19D0", VA = "0x186BD25D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6BD2850", Offset = "0x6BD1C50", VA = "0x186BD2850")]
	public Mesh IGOEGJKNKJJ([Optional] string KDPPOLLJBNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[NativeContainer]
[MMCIGIHMOCH]
[DefaultMember("Item")]
public struct LPLIGFJOCPA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Mesh.MeshDataArray KCPCGGIKHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<int> INJFOCOAGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> PIJMBDFEBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<BoneWeight> OKDDBCKHOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<Matrix4x4> FPPOIILCGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> JEBEICDIPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<byte> HMNGDPHAGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> MDHLJECJIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> EOODKJHNPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeArray<sbyte> LKDNHKCEBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<byte> EGEHOLKCJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<bool> JNGFKAEGDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<int> GJGMCILPJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool HCJPHIAALGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<int> NCLFFHHHDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool PNPNEDHJMEB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int ODLDBKAELAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6BCDEF0", Offset = "0x6BCD2F0", VA = "0x186BCDEF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int AGHOKGEFMKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6BCDC40", Offset = "0x6BCD040", VA = "0x186BCDC40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int FBOIDKGNGCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6BCDDC0", Offset = "0x6BCD1C0", VA = "0x186BCDDC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int OBIHFOIONPB
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6BCDEB0", Offset = "0x6BCD2B0", VA = "0x186BCDEB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6BCDEC0", Offset = "0x6BCD2C0", VA = "0x186BCDEC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int OAHKMBHGHJL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6BCDEE0", Offset = "0x6BCD2E0", VA = "0x186BCDEE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6BCDED0", Offset = "0x6BCD2D0", VA = "0x186BCDED0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int KPNGJOLGGIO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6BCE150", Offset = "0x6BCD550", VA = "0x186BCE150")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6BCDB50", Offset = "0x6BCCF50", VA = "0x186BCDB50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DNCEGEOKKGI LMBLDEKPAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6BCDC30", Offset = "0x6BCD030", VA = "0x186BCDC30")]
		get
		{
			return default(DNCEGEOKKGI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6BCE160", Offset = "0x6BCD560", VA = "0x186BCE160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte OLBBFHHOBNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6BCDEA0", Offset = "0x6BCD2A0", VA = "0x186BCDEA0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6BCDE90", Offset = "0x6BCD290", VA = "0x186BCDE90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public PNKLECOAFAC LGNCPMFFKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6BCDF00", Offset = "0x6BCD300", VA = "0x186BCDF00")]
		get
		{
			return default(PNKLECOAFAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6BCE170", Offset = "0x6BCD570", VA = "0x186BCE170")]
	public LPLIGFJOCPA(IList<Mesh> NECEDJFHFEK, IList<Matrix4x4> BGOBCPOFODE, IList<bool> JNGFKAEGDLK, byte HEDIDNDAPOF, IList<byte[]> NHGNNEOIJBP, IList<int> IFBHNNGKDGF, IList<bool> IGAPEDONAIP, IList<int> GJGMCILPJFD, IList<int> HBFLPPHKPHM, IList<int> LPOJEPFNNPL, Allocator DBCOPEDFGJL, DNCEGEOKKGI GMDCOELEBEB, bool HCJPHIAALGH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6BCDB60", Offset = "0x6BCCF60", VA = "0x186BCDB60")]
	public PMJFANDLCPB BBPDJGADMEF(Allocator DBCOPEDFGJL, OIIMIGOJKBD BCDMFCAGEGD)
	{
		return default(PMJFANDLCPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6BCDC50", Offset = "0x6BCD050", VA = "0x186BCDC50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[MMCIGIHMOCH]
public class KLNICMBKHLJ : ECEFGBJJGMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool NCDDKCIJPJE;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly ProfilerMarker AMIIJIIOLHP;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6BCD880", Offset = "0x6BCCC80", VA = "0x186BCD880")]
	public LPLIGFJOCPA NHAOIDGFGBL()
	{
		return default(LPLIGFJOCPA);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6BCDB40", Offset = "0x6BCCF40", VA = "0x186BCDB40")]
	public KLNICMBKHLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct PNKLECOAFAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Mesh.MeshData MGPMOLOMJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<BoneWeight> OKDDBCKHOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeSlice<byte> JOJLPMJPAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int CDMAJAPECCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Matrix4x4 NDLACNHJLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public int BPBFMLPLGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<byte> OBGHHALHAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public bool CBNFDGDJFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int NAMPFJCFLPA;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class DIFLFOKANNP : KAMMBOOGGLL
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private abstract class ABFACNNBJIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public readonly MHMNKAMKDLO GLKADMAEFKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		protected bool IMOGANMDJBH;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual bool HFMGGJBMBAM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public virtual bool KNLAPNGHGEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public virtual MNFPGDBOOJI.NOHJIBHJCAM BPBFMLPLGOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "6")]
			get
			{
				return default(MNFPGDBOOJI.NOHJIBHJCAM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool MLOBNIBEHKH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xC50840", Offset = "0xC4FC40", VA = "0x180C50840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool JNHMPEPMGEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x194FF40", Offset = "0x194F340", VA = "0x18194FF40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool HNGHHEJFEHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x6BBD4A0", Offset = "0x6BBC8A0", VA = "0x186BBD4A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool ELEKLDDDLIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6BBD480", Offset = "0x6BBC880", VA = "0x186BBD480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
		protected ABFACNNBJIF(MHMNKAMKDLO HNGFCFOKONC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract NNKCIMLKELB IKHMJDOOKKE(int[] PLLCMBDDAND, List<HGIIABNNGMK> BGMLAIEIJAP, List<HGIIABNNGMK> OELDKLIKKAN);

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract OMBGJBPAMCG CKHCNOHKINL(uint BGHMMFOMOHD, AvatarSkinnedMeshBoneOrderRemapsData LJDJAJAOGCB);
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class OLNHLLGGJIH : ABFACNNBJIF
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class CPHAOMIKIMP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public OELCFEONCJD<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public OLNHLLGGJIH <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public CPHAOMIKIMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6BC0110", Offset = "0x6BBF510", VA = "0x186BC0110")]
			internal void BDJBKJHHELH(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly AvatarSkinAssetItem.CMADPIBHGEL FOBIKFGICNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly AssetReference JLOHHDLABPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly MNFPGDBOOJI.NOHJIBHJCAM LPIJPFFGMJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly JHKPFMPLNBA? OIDEAKOIDGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly Material[] MDNLBKLHDCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private SkinnedMeshRenderer[] GBMEFFMAHEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private AvatarSkinAssetItem NGJFAKJAAKN;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override MNFPGDBOOJI.NOHJIBHJCAM BPBFMLPLGOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8A6040", Offset = "0x8A5440", VA = "0x1808A6040", Slot = "6")]
			get
			{
				return default(MNFPGDBOOJI.NOHJIBHJCAM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6BCFD30", Offset = "0x6BCF130", VA = "0x186BCFD30")]
		public OLNHLLGGJIH(AvatarSkinAssetItem.CMADPIBHGEL OHFBLJMIPDP, AssetReference CNKBIDEMJNL, Material NPJDOCHEMCI, MHMNKAMKDLO OJEPPEBDDDD, MNFPGDBOOJI.NOHJIBHJCAM MGMKPNFAGME = (MNFPGDBOOJI.NOHJIBHJCAM)0, [Optional] JHKPFMPLNBA? LKFBCJMFBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6BCFC20", Offset = "0x6BCF020", VA = "0x186BCFC20")]
		public OLNHLLGGJIH(AvatarSkinAssetItem.CMADPIBHGEL OHFBLJMIPDP, AssetReference CNKBIDEMJNL, Material NPJDOCHEMCI, MNFPGDBOOJI.NOHJIBHJCAM MGMKPNFAGME = (MNFPGDBOOJI.NOHJIBHJCAM)0, [Optional] JHKPFMPLNBA? LKFBCJMFBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6BCF9E0", Offset = "0x6BCEDE0", VA = "0x186BCF9E0", Slot = "7")]
		public override NNKCIMLKELB IKHMJDOOKKE(int[] PLLCMBDDAND, List<HGIIABNNGMK> BGMLAIEIJAP, List<HGIIABNNGMK> OELDKLIKKAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6BCF710", Offset = "0x6BCEB10", VA = "0x186BCF710", Slot = "8")]
		public override OMBGJBPAMCG CKHCNOHKINL(uint BGHMMFOMOHD, AvatarSkinnedMeshBoneOrderRemapsData LJDJAJAOGCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6BCFBB0", Offset = "0x6BCEFB0", VA = "0x186BCFBB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class ANALHEEEMFA : ABFACNNBJIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public readonly ONEODDJDANP NOKIHBGMCHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private OELCFEONCJD<FGDMKOGOBGP> MMBHPFPKGAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public FGDMKOGOBGP KGOPJHINCKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private OELCFEONCJD<Material[]> MDHCHACONCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public Material[] OLPOOKHDHBH;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool HFMGGJBMBAM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool KNLAPNGHGEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6BBFAD0", Offset = "0x6BBEED0", VA = "0x186BBFAD0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6BBFC40", Offset = "0x6BBF040", VA = "0x186BBFC40")]
		public ANALHEEEMFA(MHMNKAMKDLO HNGFCFOKONC, ONEODDJDANP LKKBBDEIAPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6BBF640", Offset = "0x6BBEA40", VA = "0x186BBF640", Slot = "7")]
		public override NNKCIMLKELB IKHMJDOOKKE(int[] PLLCMBDDAND, List<HGIIABNNGMK> BGMLAIEIJAP, List<HGIIABNNGMK> OELDKLIKKAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6BBEF90", Offset = "0x6BBE390", VA = "0x186BBEF90", Slot = "8")]
		public override OMBGJBPAMCG CKHCNOHKINL(uint BGHMMFOMOHD, AvatarSkinnedMeshBoneOrderRemapsData LJDJAJAOGCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6BBF0C0", Offset = "0x6BBE4C0", VA = "0x186BBF0C0")]
		public OMBGJBPAMCG CMEHJNIHOIN(GameObject ODHEAGEMJLJ, uint BGHMMFOMOHD, bool CBOKLDOLFEE, bool NKLBBMHGFML, AvatarSkinnedMeshBoneOrderRemapsData LJDJAJAOGCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6BBF2D0", Offset = "0x6BBE6D0", VA = "0x186BBF2D0")]
		public static bool DEJPOOIEJPM(Renderer[] EGNNPICMBPJ, string EBLLDBIAFDD, [Out] Renderer CDPCFJCFGKK, [Out] Renderer DAILCKEHHBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6BBFBF0", Offset = "0x6BBEFF0", VA = "0x186BBFBF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6BBFB30", Offset = "0x6BBEF30", VA = "0x186BBFB30")]
		private (OELCFEONCJD<FGDMKOGOBGP>, OELCFEONCJD<Material[]>) OKGDCPNBELB()
		{
			return default((OELCFEONCJD<FGDMKOGOBGP>, OELCFEONCJD<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x468CC70", Offset = "0x468C070", VA = "0x18468CC70")]
		[CompilerGenerated]
		private void EKDOMFNILEM(FGDMKOGOBGP HCMJFDLGOJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8A1350", Offset = "0x8A0750", VA = "0x1808A1350")]
		[CompilerGenerated]
		private void MOOLHMNLMLI(Material[] HCMJFDLGOJF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DOFJEKANPHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public EJKIPOGADKM avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public DIFLFOKANNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public HBMBDNJPECN buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public DOFJEKANPHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6BCCB50", Offset = "0x6BCBF50", VA = "0x186BCCB50")]
		internal bool EDJJMPOMJKE(ONEODDJDANP item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6BCCBA0", Offset = "0x6BCBFA0", VA = "0x186BCCBA0")]
		internal void FLKCEBLCADH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6BCCBC0", Offset = "0x6BCBFC0", VA = "0x186BCCBC0")]
		internal void HJOOBANHFOL(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6BCCA30", Offset = "0x6BCBE30", VA = "0x186BCCA30")]
		internal void CCCBKJINNPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6BCCAC0", Offset = "0x6BCBEC0", VA = "0x186BCCAC0")]
		internal void CJAEJFCMNOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40")]
		internal NNKCIMLKELB CHPPHPJHOIO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class NIHNDINOBBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public DOFJEKANPHO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public NIHNDINOBBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6BCF650", Offset = "0x6BCEA50", VA = "0x186BCF650")]
		internal LMKDMIGPMEB AJKNKMFDGNF(int lod)
		{
			return default(LMKDMIGPMEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class IONILKNLGAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public List<HBMBDNJPECN> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public IONILKNLGAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6BCD500", Offset = "0x6BCC900", VA = "0x186BCD500")]
		internal void LFCAJCGCCNM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class KIFHPHEMNFK : IEnumerator<MLEAAPMIINP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private MLEAAPMIINP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public DIFLFOKANNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public List<ABFACNNBJIF> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public List<HBMBDNJPECN> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public Func<int, LMKDMIGPMEB> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public JCFPLGKEOON materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private MLEAAPMIINP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
		[DebuggerHidden]
		public KIFHPHEMNFK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6BCD630", Offset = "0x6BCCA30", VA = "0x186BCD630", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6BCD830", Offset = "0x6BCCC30", VA = "0x186BCD830", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class PPLOJNNMBMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public DIFLFOKANNP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public PPLOJNNMBMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6BD4F00", Offset = "0x6BD4300", VA = "0x186BD4F00")]
		internal NNKCIMLKELB JGICPDIGHPK(ABFACNNBJIF p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class JIMKGODGDHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public GNCKKKLDHED cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public JIMKGODGDHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xCC08E0", Offset = "0xCBFCE0", VA = "0x180CC08E0")]
		internal void CGOIOJFAKGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xD56D00", Offset = "0xD56100", VA = "0x180D56D00")]
		internal void FIMNJJNECBP(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class EHKENJDJICI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public DIFLFOKANNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public EHKENJDJICI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class NAMJAAIPOHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public PMJFANDLCPB defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public LPLIGFJOCPA defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public EHKENJDJICI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public NAMJAAIPOHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6BCF410", Offset = "0x6BCE810", VA = "0x186BCF410")]
		internal void EPHPOCNKMPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xD580B0", Offset = "0xD574B0", VA = "0x180D580B0")]
		internal void CJFKDHENKBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class EOGIMMGBCNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public FKFBALGMCLN legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public BIGHHIDHAEA legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public EHKENJDJICI CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public EOGIMMGBCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6BCD2C0", Offset = "0x6BCC6C0", VA = "0x186BCD2C0")]
		internal void KCCBJGLEDHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xD566C0", Offset = "0xD55AC0", VA = "0x180D566C0")]
		internal void IADMCNIIIPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class BADPIABMGNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public KeyValuePair<string, ONEODDJDANP> entry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public GNCKKKLDHED cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public ONEODDJDANP avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public DIFLFOKANNP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public BADPIABMGNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6BBFCE0", Offset = "0x6BBF0E0", VA = "0x186BBFCE0")]
		internal NNKCIMLKELB FBFOAIOEMDP(BHLBEAHKJIJ item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6BBFCA0", Offset = "0x6BBF0A0", VA = "0x186BBFCA0")]
		internal void DKMAJHGABOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class MMHFFNOBNKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public OELCFEONCJD<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public MMHFFNOBNKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6BCF3C0", Offset = "0x6BCE7C0", VA = "0x186BCF3C0")]
		internal void PCLMMHNOOLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class OMJJJKAEDKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public MHMNKAMKDLO overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public OMJJJKAEDKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6BCFE40", Offset = "0x6BCF240", VA = "0x186BCFE40")]
		internal bool KPHFFNECMPL(KeyValuePair<string, ONEODDJDANP> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private AvatarConfiguration CAGEGPDFPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Transform MJCEMNDGFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private AssetReference JLOHHDLABPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private GameObject GPHFDCJFMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private GameObject LMJCFIJNCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private SkinnedMeshRenderer AFNKLNAADIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private AvatarSkinnedMeshBoneOrderRemapsData LHEIODHKLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Transform[] ECOOJPHDNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Matrix4x4[] GEPKIMJJDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Material EJCFBJOKGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Material HLCMEKMNBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Material MPJPHBAPMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Shader EFIGDNHHHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Shader ONDOPAONNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Animator JLFELBPOOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Renderer[] PELBHKHIBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private MNFPGDBOOJI.NOHJIBHJCAM HCFFDCADEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private AvatarBodyPartShapesManager MHLKHAKBHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyDictionary<string, Transform> LBOPOBLKPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private AvatarFaceShapeData.ELJLKEMBDFB MAHLLIFDCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private AvatarBodyShapeData.GCDLCBKFEGM BKEGNPKEJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool CIEGELADMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool JBJHOAJNOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Color ICLJDNJIKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Color FBJFNOJJHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Color GFCADBPDFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Color? APPINEHDKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Color? GCPFFCMDHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Color? FMOPEHAOBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Color? MPLLJANLHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Texture2D KIOPJKBCLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Texture2D FDDELGNOMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[CanBeNull]
	private ONEODDJDANP AAMHHOBLMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Texture PPHMBILJEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Color KMDJELCCBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Dictionary<Renderer, JCFPLGKEOON> JDKNGBOEFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<Renderer, JCFPLGKEOON> KKECEJKPMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Dictionary<string, List<AIBIBHKIIHC>> JKJLODAAOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Dictionary<string, List<AIBIBHKIIHC>> NHFCKMMEEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly List<HGIIABNNGMK> PLNGJNGAFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly List<HGIIABNNGMK> FJLNFNBKMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly List<HGIIABNNGMK> ILHCGPLMCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly List<HGIIABNNGMK> OIKALGGHLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Dictionary<AIBIBHKIIHC, Material> OEGOCNDGAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Dictionary<AIBIBHKIIHC, Material> PDIBCNKMAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private SkinnedMeshRenderer[] NANOBNOBKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private SkinnedMeshRenderer[] MINDFJCOKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private SkinnedMeshRenderer[] DPIHOMJKBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private SkinnedMeshRenderer[] CPPNDKFIAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly Dictionary<string, OELCFEONCJD<Texture2D>> IBNKHOOFNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly Dictionary<string, OELCFEONCJD<Texture2D>> ODLMBNAJGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private AdditionalHatData NIALILMBBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private AdditionalHatData FOGNMNOOJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private HairData LEGHBFINOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private HairData JBJLOCPFCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private CHCOONHOENK PDAEDOHJOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private bool? CMMIGLIECHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private PositionAndRotation PNEPPJNKGAC;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Material OGMECLHKEHJ;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Material ACLPMILGDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Dictionary<string, ONEODDJDANP> AOJHDFOFODB;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int ALAAFGLCAJI;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int LPGEFJNKMOI;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int NOAAFOJOKLL;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int KLGBJCBOJPK;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int DDKNMKIKNHA;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int IFMBGOIGHBN;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int BHJPGNOONEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly BDDIJCFMLKF KJFDIMDEGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly BDDIJCFMLKF CNPMEJONNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool PKKMLALBOGA;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static Lazy<FGJGNMDINBC> HNFMBHKBLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private Lazy<COCMLFLDKGG> LJMFNKADBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private Lazy<ABPIOEHIKHL> PFNPPNHLHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private CIEGHNKGOGI LOOKPNABHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private List<Action> NCKNNMGIADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private LBGKLHCNPEM MOEMOKNBNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private SkinnedMeshRenderer[] MLEFFOKNHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int MABCDMCFIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool CBOEHAOGNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int PGIBIBCMPPN;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static bool EGKFLJOLEPH;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool FDHMLKPLHBC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xCD68A0", Offset = "0xCD5CA0", VA = "0x180CD68A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xCD57D0", Offset = "0xCD4BD0", VA = "0x180CD57D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Material PALGGNOCOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6BC8E70", Offset = "0x6BC8270", VA = "0x186BC8E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material PLFEHAOOCNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6BC0920", Offset = "0x6BBFD20", VA = "0x186BC0920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private bool JJOOCGKNBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public JNJINABLMLP EIDKILKAHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x91EFB0", Offset = "0x91E3B0", VA = "0x18091EFB0", Slot = "21")]
		get
		{
			return default(JNJINABLMLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private static FGJGNMDINBC CINKBOJJCID
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6BC0F60", Offset = "0x6BC0360", VA = "0x186BC0F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private COCMLFLDKGG HLPCHCPDHNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6BC1390", Offset = "0x6BC0790", VA = "0x186BC1390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private ABPIOEHIKHL FCFODIILDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6BC5240", Offset = "0x6BC4640", VA = "0x186BC5240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private CIEGHNKGOGI NAIJPEOODAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6BC1700", Offset = "0x6BC0B00", VA = "0x186BC1700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public BDDIJCFMLKF DKDHLPDKKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x96CFB0", Offset = "0x96C3B0", VA = "0x18096CFB0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public BDDIJCFMLKF PFHDCEAGDLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x96CF80", Offset = "0x96C380", VA = "0x18096CF80", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public SkinnedMeshRenderer[] IFCOGECIFMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1B49630", Offset = "0x1B48A30", VA = "0x181B49630", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Renderer[] BLMBBBPAEPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x89FC70", Offset = "0x89F070", VA = "0x18089FC70", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool DIEEHJBAJEI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6BC88A0", Offset = "0x6BC7CA0", VA = "0x186BC88A0", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public PositionAndRotation CCNKCKJFLGF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6BC9A40", Offset = "0x6BC8E40", VA = "0x186BC9A40", Slot = "27")]
		get
		{
			return default(PositionAndRotation);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public MNFPGDBOOJI.NOHJIBHJCAM PMOGIPINGPK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x89FC10", Offset = "0x89F010", VA = "0x18089FC10", Slot = "18")]
		get
		{
			return default(MNFPGDBOOJI.NOHJIBHJCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int KAKLJHJGPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1B53900", Offset = "0x1B52D00", VA = "0x181B53900")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6BC8460", Offset = "0x6BC7860", VA = "0x186BC8460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool OIFHICFMLCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6BCB9C0", Offset = "0x6BCADC0", VA = "0x186BCB9C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private static bool JKJBNGOIADP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6BC3F10", Offset = "0x6BC3310", VA = "0x186BC3F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6BCC260", Offset = "0x6BCB660", VA = "0x186BCC260")]
	public DIFLFOKANNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6BCA7D0", Offset = "0x6BC9BD0", VA = "0x186BCA7D0", Slot = "28")]
	public void NOCOEJHJFAP(ECJBMJNFEEH KKFINALJKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6BC5E60", Offset = "0x6BC5260", VA = "0x186BC5E60", Slot = "29")]
	public void HPPLPACIMHC(IKHNPNACIIH ADFKEIDOLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6BC8460", Offset = "0x6BC7860", VA = "0x186BC8460", Slot = "4")]
	public void JIGBJAEGALO(int BGHMMFOMOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6BC8240", Offset = "0x6BC7640", VA = "0x186BC8240", Slot = "9")]
	public void JHFMEPBHMMB(NJONFDAHBOA HCKEINFHKFJ, Texture2D LGMOHAIKHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6BC1CD0", Offset = "0x6BC10D0", VA = "0x186BC1CD0", Slot = "10")]
	public void DIKKODHKLHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6BCA580", Offset = "0x6BC9980", VA = "0x186BCA580", Slot = "11")]
	public bool NNGEPCOMKKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6BCA080", Offset = "0x6BC9480", VA = "0x186BCA080", Slot = "8")]
	public void NJNHHHAKPIM(NMBPBMHFMLK IGNMGNOKJMA, Color? FKCCOIADMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6BC9260", Offset = "0x6BC8660", VA = "0x186BC9260")]
	private void LANKIGKGMPL(Action FLEJJPNFPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6BC9C80", Offset = "0x6BC9080", VA = "0x186BC9C80", Slot = "5")]
	public void NBHPPCDOPPP(ONEODDJDANP DIKMEPPPJIE, Texture DGNLJBJFOGA, Color HOIAKDFDNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xCD57D0", Offset = "0xCD4BD0", VA = "0x180CD57D0", Slot = "6")]
	public void HBPJDNLEEHI(bool FBFACENJADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1A9CB60", Offset = "0x1A9BF60", VA = "0x181A9CB60", Slot = "7")]
	public void GHMLMENIPAB(LBGKLHCNPEM FFHLFAMMNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6BC28A0", Offset = "0x6BC1CA0", VA = "0x186BC28A0", Slot = "14")]
	public HBMBDNJPECN FHKCBIIPDMH(EJKIPOGADKM HNPKCBPPNEK, bool OGAAILLMAID, int[] KONAINIFLMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6BC8540", Offset = "0x6BC7940", VA = "0x186BC8540", Slot = "15")]
	public void JJHBPEBHDLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6BC4650", Offset = "0x6BC3A50", VA = "0x186BC4650", Slot = "26")]
	public void GCKBEHGNFLF([Optional] CHCOONHOENK BMNEOCMGPNI, [Optional] bool? MIALENKABIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6BC9B40", Offset = "0x6BC8F40", VA = "0x186BC9B40")]
	private bool MLEEPENLLEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6BC0F40", Offset = "0x6BC0340", VA = "0x186BC0F40", Slot = "19")]
	public bool BENLFMADFHM(MNFPGDBOOJI.NOHJIBHJCAM EECNGDJHAJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6550", Offset = "0x6BC5950", VA = "0x186BC6550")]
	private bool JBHINDPIKBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6BC5F70", Offset = "0x6BC5370", VA = "0x186BC5F70")]
	private HBMBDNJPECN ILOKOFBHIEG(bool OGAAILLMAID, List<ABFACNNBJIF> DMIJPGLIAND, int[] KONAINIFLMI, Func<int, LMKDMIGPMEB> IAACLKHIAIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6BC1D50", Offset = "0x6BC1150", VA = "0x186BC1D50")]
	[IteratorStateMachine(typeof(KIFHPHEMNFK))]
	private IEnumerator<MLEAAPMIINP> DOMBENDAIDC(bool OGAAILLMAID, List<ABFACNNBJIF> DMIJPGLIAND, int[] KONAINIFLMI, Func<int, LMKDMIGPMEB> IAACLKHIAIG, JCFPLGKEOON PDHCCIEDMIH, Material BNMMEECFDFJ, List<HBMBDNJPECN> AKBJNCIFBNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB700", Offset = "0x6BCAB00", VA = "0x186BCB700")]
	private HBMBDNJPECN OKAMLFAEHEJ(List<ABFACNNBJIF> DMIJPGLIAND, int[] KONAINIFLMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6610", Offset = "0x6BC5A10", VA = "0x186BC6610")]
	private IDFKLKAPHIN JCDPFAGNHPM(List<ABFACNNBJIF> DMIJPGLIAND, int BGHMMFOMOHD, bool OGAAILLMAID, LMKDMIGPMEB BOJMNCJMGLC, bool GPFNKMNLCAO, JCFPLGKEOON PDHCCIEDMIH, Material BNMMEECFDFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6BC8480", Offset = "0x6BC7880", VA = "0x186BC8480", Slot = "22")]
	public void JJBHEEINFNE(AvatarFaceShape KDBNHAEKKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6BCBB20", Offset = "0x6BCAF20", VA = "0x186BCBB20", Slot = "23")]
	public void POHNKHDCEFF(AvatarBodyShape AEOKPLDGOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6BCA480", Offset = "0x6BC9880", VA = "0x186BCA480", Slot = "25")]
	public void NLJOAJOKGAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6BC07F0", Offset = "0x6BBFBF0", VA = "0x186BC07F0", Slot = "24")]
	public void ALMHACODPMI(bool ICPHOEHCHJL, bool KFKJBPJDDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB5C0", Offset = "0x6BCA9C0", VA = "0x186BCB5C0")]
	private void OJKJMIMCJDD(SkinnedMeshRenderer OAHGCCAEMAD, int BGHMMFOMOHD, Mesh OHLMFEKEKFF, List<Material> KHHPCBAHCFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6BC9F20", Offset = "0x6BC9320", VA = "0x186BC9F20")]
	private static Material NGLAPEDAMIP(Dictionary<AIBIBHKIIHC, Material> IHOEOACDBHH, Material PGFBCNNAGIH, BPEFDHODIOC MAEMEMKCLML, MGHIAONMBJN MIAONAHLMOL, MHMNKAMKDLO OJEPPEBDDDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6BC0800", Offset = "0x6BBFC00", VA = "0x186BC0800")]
	private static BPEFDHODIOC AMFMEFBLNHM(ABFACNNBJIF GJMOKOHBNBI, int AIJCBDPPEPL)
	{
		return default(BPEFDHODIOC);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6BCBBE0", Offset = "0x6BCAFE0", VA = "0x186BCBBE0")]
	private void PPOODDGDFDJ(int OHMEIOBLAPA, Material JAEJMKKLMIE, ABFACNNBJIF GJMOKOHBNBI, [Out] Texture2D HMOKJCKLJOB, [Out] Vector4 LPNGBMAJEAO, [Out] Texture2D DJJPEECEEEB, [Out] Texture2D BKHDDCCBDBE, [Out] Texture2D HICLEHEFKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6BCAB20", Offset = "0x6BC9F20", VA = "0x186BCAB20")]
	private void OAILKJLLDON(int OHMEIOBLAPA, Material JAEJMKKLMIE, ABFACNNBJIF GJMOKOHBNBI, [Out] Color IDKEBOPMKOG, [Out] Color IKGOJEEGOKG, [Out] Color IEDKPDOCHAM, [Out] Color NGNPAFGDBPD, [Out] Color GLCEDFFHFIC, [Out] Color FAKIDLLINHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB030", Offset = "0x6BCA430", VA = "0x186BCB030")]
	private bool ODMHDPMGGCB(Material JAEJMKKLMIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6BCBA40", Offset = "0x6BCAE40", VA = "0x186BCBA40")]
	private static Material OMCFAFFDPHC(int OHMEIOBLAPA, ANALHEEEMFA GJMOKOHBNBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6BC5D60", Offset = "0x6BC5160", VA = "0x186BC5D60")]
	private static MGHIAONMBJN HPMBKFLIAPH(ABFACNNBJIF GJMOKOHBNBI, int AIJCBDPPEPL)
	{
		return default(MGHIAONMBJN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6BC4210", Offset = "0x6BC3610", VA = "0x186BC4210")]
	private static void GCCMEPINDPA(Dictionary<string, List<AIBIBHKIIHC>> CCLLBFABNDI, ABFACNNBJIF IEEGJOEFJHE, Material PGFBCNNAGIH, BPEFDHODIOC IGNMGNOKJMA, MGHIAONMBJN HCKEINFHKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6BC9CF0", Offset = "0x6BC90F0", VA = "0x186BC9CF0")]
	private static SkinnedMeshRenderer NCFCLDCMBLG(Transform COPEMICOCEK, Transform EKOBICNICKE, SkinnedMeshRenderer[] EGNNPICMBPJ, int BGHMMFOMOHD, LMKDMIGPMEB BOJMNCJMGLC, bool OGAAILLMAID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6BC0A10", Offset = "0x6BBFE10", VA = "0x186BC0A10")]
	private void BAMGDFIJLAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6BC1540", Offset = "0x6BC0940", VA = "0x186BC1540")]
	private void CEIDLOBBBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6BC0FE0", Offset = "0x6BC03E0", VA = "0x186BC0FE0")]
	private static void BMIPEEENKDI(Dictionary<AIBIBHKIIHC, Material> IHOEOACDBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6BC40B0", Offset = "0x6BC34B0", VA = "0x186BC40B0")]
	private static void GBKBEPNNFFH(Dictionary<Renderer, JCFPLGKEOON> HDNEFALCHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6BC1140", Offset = "0x6BC0540", VA = "0x186BC1140")]
	private void BMJIPPIBOHO(SkinnedMeshRenderer[] EGNNPICMBPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6BC51A0", Offset = "0x6BC45A0", VA = "0x186BC51A0")]
	private void HAOHDDONFCE(SkinnedMeshRenderer HOJDDBIPPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6BC9090", Offset = "0x6BC8490", VA = "0x186BC9090")]
	private void LAFNPIPBLBA(List<HGIIABNNGMK> BAHPKIFFCIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6BC2230", Offset = "0x6BC1630", VA = "0x186BC2230")]
	private void EEHEJCMAPEJ(Dictionary<string, OELCFEONCJD<Texture2D>> CCLLBFABNDI, bool IJNCIHIPGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB320", Offset = "0x6BCA720", VA = "0x186BCB320")]
	private void OFHHMGEKFJG(Dictionary<string, List<AIBIBHKIIHC>> CCLLBFABNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6BC92E0", Offset = "0x6BC86E0", VA = "0x186BC92E0")]
	private void LHMEKFFKDDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6BC5BD0", Offset = "0x6BC4FD0", VA = "0x186BC5BD0")]
	private void HKNELFPCBMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6BC5290", Offset = "0x6BC4690", VA = "0x186BC5290")]
	private void HHHELPBKJNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6BCA700", Offset = "0x6BC9B00", VA = "0x186BCA700")]
	private void NNHAJPHGIOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB370", Offset = "0x6BCA770", VA = "0x186BCB370")]
	private void OIMGFAANNOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6BC4500", Offset = "0x6BC3900", VA = "0x186BC4500")]
	private void GCFACLGLBFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6BC9A70", Offset = "0x6BC8E70", VA = "0x186BC9A70")]
	private void MIBPNENKBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6BC8800", Offset = "0x6BC7C00", VA = "0x186BC8800")]
	private void JOILECJHNBG(bool CECBKOCCFBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6BC8A40", Offset = "0x6BC7E40", VA = "0x186BC8A40")]
	private void KCNODOCFKKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6BC1260", Offset = "0x6BC0660", VA = "0x186BC1260")]
	private void BMNFMEECODI(bool CECBKOCCFBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6BC8B50", Offset = "0x6BC7F50", VA = "0x186BC8B50")]
	private void KOCNAFMJMEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6BC17D0", Offset = "0x6BC0BD0", VA = "0x186BC17D0")]
	private void DHODGMDOEOK(Material BNMMEECFDFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6BC1550", Offset = "0x6BC0950", VA = "0x186BC1550")]
	private void CGEEIKNDGGN(Material BNMMEECFDFJ, Color PEKPJDGNOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6BC2650", Offset = "0x6BC1A50", VA = "0x186BC2650")]
	private void FFMCEOKJGIB(Material BNMMEECFDFJ, Color PEKPJDGNOCG, Color ENKEDKMAEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6BC13E0", Offset = "0x6BC07E0", VA = "0x186BC13E0")]
	private void BPKAEBEPJCO(Material BNMMEECFDFJ, Color IDKEBOPMKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6BC23B0", Offset = "0x6BC17B0", VA = "0x186BC23B0")]
	private void EKICPHODIMG(Material BNMMEECFDFJ, Texture2D LGMOHAIKHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6BC0500", Offset = "0x6BBF900", VA = "0x186BC0500")]
	private void AAEHDNAFACC(Material BNMMEECFDFJ, Texture EMMIDEMAHLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB400", Offset = "0x6BCA800", VA = "0x186BCB400")]
	private void OJANNOGPLKE(Action<JCFPLGKEOON> PABEGCKGABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6BC0670", Offset = "0x6BBFA70", VA = "0x186BC0670")]
	private void AEBBGCPONDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6BC0BE0", Offset = "0x6BBFFE0", VA = "0x186BC0BE0")]
	private void BCMFHMLLJKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6BC9470", Offset = "0x6BC8870", VA = "0x186BC9470")]
	private HBMBDNJPECN MFINEGJMBEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6BC1E60", Offset = "0x6BC1260", VA = "0x186BC1E60")]
	private void EBFLNDJPFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6BC5840", Offset = "0x6BC4C40", VA = "0x186BC5840")]
	public void HIPFFEECDMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6BCAA90", Offset = "0x6BC9E90", VA = "0x186BCAA90")]
	[CompilerGenerated]
	private void NOEAEHOKOIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6BC16D0", Offset = "0x6BC0AD0", VA = "0x186BC16D0")]
	[CompilerGenerated]
	private void CLHFCGIKBKF(JCFPLGKEOON HMICCADPECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6BC5EE0", Offset = "0x6BC52E0", VA = "0x186BC5EE0")]
	[CompilerGenerated]
	private void IEBDICLBFOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6BC8B30", Offset = "0x6BC7F30", VA = "0x186BC8B30")]
	[CompilerGenerated]
	private void KHCJLNDIKMA(JCFPLGKEOON HMICCADPECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6BC9000", Offset = "0x6BC8400", VA = "0x186BC9000")]
	[CompilerGenerated]
	private void LABMHAFLPGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6BC8B10", Offset = "0x6BC7F10", VA = "0x186BC8B10")]
	[CompilerGenerated]
	private void KEPPFANAACH(JCFPLGKEOON HMICCADPECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6BC25C0", Offset = "0x6BC19C0", VA = "0x186BC25C0")]
	[CompilerGenerated]
	private void EKIGMALGEEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6BC8740", Offset = "0x6BC7B40", VA = "0x186BC8740")]
	[CompilerGenerated]
	private void JLLNCKKMEGD(JCFPLGKEOON HMICCADPECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6BC5110", Offset = "0x6BC4510", VA = "0x186BC5110")]
	[CompilerGenerated]
	private void GJCNCFHENJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6BC8190", Offset = "0x6BC7590", VA = "0x186BC8190")]
	[CompilerGenerated]
	private void JCIBGLGCOAD(JCFPLGKEOON HMICCADPECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB290", Offset = "0x6BCA690", VA = "0x186BCB290")]
	[CompilerGenerated]
	private void OFHGOHNDHIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6BC9440", Offset = "0x6BC8840", VA = "0x186BC9440")]
	[CompilerGenerated]
	private void LJFDPFKPPHE(JCFPLGKEOON HMICCADPECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6BC8770", Offset = "0x6BC7B70", VA = "0x186BC8770")]
	[CompilerGenerated]
	private void JODEHMOFLKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB000", Offset = "0x6BCA400", VA = "0x186BCB000")]
	[CompilerGenerated]
	private void ODFMKJAGCCI(JCFPLGKEOON HMICCADPECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6BC81C0", Offset = "0x6BC75C0", VA = "0x186BC81C0")]
	[CompilerGenerated]
	private void JGHDLPJKHIB(KeyValuePair<string, OELCFEONCJD<Texture2D>> AIFHIMEOACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6BC1300", Offset = "0x6BC0700", VA = "0x186BC1300")]
	[CompilerGenerated]
	private void BNAIEDAJBPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6BC17A0", Offset = "0x6BC0BA0", VA = "0x186BC17A0")]
	[CompilerGenerated]
	private void DEOOBBOPKPJ(JCFPLGKEOON HMICCADPECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6BCBA90", Offset = "0x6BCAE90", VA = "0x186BCBA90")]
	[CompilerGenerated]
	private void PLFHMBIJFKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6BC8A10", Offset = "0x6BC7E10", VA = "0x186BC8A10")]
	[CompilerGenerated]
	private void KAMFPDLCEMP(JCFPLGKEOON HMICCADPECI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class OOCOLAKEFPA : HEJPJIGBCCH
{
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static readonly int PPPFOLLLGHG;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly int ANAEFILNKAF;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly int HIGEHKFFGFF;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly int EOHKGIDMKJP;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly int AHIJGAGJGFH;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly int AHDDILGOAHD;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly int HEAIGJFEAMG;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int JAGMIIINBND;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int GPJIKLMPHFK;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly int DIPBBKEODLE;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly int IMABLONKDNK;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int BJCJLENJKMG;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int AHPHOKFPODP;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int DLGOIJMIIAC;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly int JOEHFFCNEEM;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly int DCMDDBEKFPL;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly int GHOKIBNKKKC;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly int AKJMIKPKJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private Transform GDAMIJMHJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private Transform CJFANFGEJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private Transform MMBJJJGHEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private Transform DBHJFIKHKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private Transform HDKKMFICLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Transform NKAKLFECOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private Transform ECBKEIEOLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private ABGBEHEKHPG FECGBLLKGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private MaterialPropertyBlock CIAGLLBDKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private SkinnedMeshRenderer[] ENDILOIEDMN;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private MaterialPropertyBlock GAMBNEOCBHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6BD1A20", Offset = "0x6BD0E20", VA = "0x186BD1A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool PEHHLBMDPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6BCFEF0", Offset = "0x6BCF2F0", VA = "0x186BCFEF0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6BD18C0", Offset = "0x6BD0CC0", VA = "0x186BD18C0", Slot = "7")]
	public void NOCOEJHJFAP(ABGBEHEKHPG HLOLIKEMNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6BCFEC0", Offset = "0x6BCF2C0", VA = "0x186BCFEC0", Slot = "8")]
	public void AIMLCIHHMMB(EBJCKNKIANB DKKELNACEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6BD0190", Offset = "0x6BCF590", VA = "0x186BD0190", Slot = "5")]
	public void GOGKGHLBEFB(CMCANEOHPCH MDLMPAPEAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6BD06B0", Offset = "0x6BCFAB0", VA = "0x186BD06B0")]
	private Vector2 IDOKDENBOJJ(Vector2 CPGMJAFBLEN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6BD0710", Offset = "0x6BCFB10", VA = "0x186BD0710", Slot = "6")]
	public void LLIABFMJPHA(INCADHMPMML DKKELNACEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6BD1AA0", Offset = "0x6BD0EA0", VA = "0x186BD1AA0")]
	private void PFDDIDFKEGA(INCADHMPMML OEAHIJFKNEO, OJIAOCLLLPE GOFADHCFIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6BD0070", Offset = "0x6BCF470", VA = "0x186BD0070")]
	private void BEPLDPNMOPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6BD2120", Offset = "0x6BD1520", VA = "0x186BD2120")]
	public OOCOLAKEFPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6BD1990", Offset = "0x6BD0D90", VA = "0x186BD1990")]
	[CompilerGenerated]
	internal static (float, float) ONAKMFOPJPC(float LJEDMAOJABE)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6BD0150", Offset = "0x6BCF550", VA = "0x186BD0150")]
	[CompilerGenerated]
	internal static Vector4 FMPJNKKFGGG(Vector2 OGKCMCMHLOD, Vector2 EAEIAKHGPAC)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		[Obsolete("Use CombinationId instead!")]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private PFOMBIPKCAJ? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public HLKLPNJACJF CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x6BD63E0", Offset = "0x6BD57E0", VA = "0x186BD63E0")]
			get
			{
				return default(HLKLPNJACJF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public PFOMBIPKCAJ MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x6BD6410", Offset = "0x6BD5810", VA = "0x186BD6410")]
			get
			{
				return default(PFOMBIPKCAJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x89D950", Offset = "0x89CD50", VA = "0x18089D950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x89D960", Offset = "0x89CD60", VA = "0x18089D960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6BD6040", Offset = "0x6BD5440", VA = "0x186BD6040")]
		public Material[] NCNKNDONNHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6BD6120", Offset = "0x6BD5520", VA = "0x186BD6120")]
		public static void NKCLLNFNCEN(AvatarItemMaterial MJOBLGNIFPD, Material JAEJMKKLMIE, int OHMEIOBLAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6BD5E90", Offset = "0x6BD5290", VA = "0x186BD5E90")]
		private static bool HDLAPLCDLND(AvatarItemMaterial MJOBLGNIFPD, int OHMEIOBLAPA, [Out] Material OKPKNAMBAEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6BD6310", Offset = "0x6BD5710", VA = "0x186BD6310")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[MMCIGIHMOCH]
public struct OKAEPEOEKPK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	[ReadOnly]
	public BIGHHIDHAEA JHMPFGMBEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	[ReadOnly]
	public int FHGKJDIICFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public FKFBALGMCLN HPBCJBOHENE;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6BDF670", Offset = "0x6BDEA70", VA = "0x186BDF670", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[NativeContainer]
[MMCIGIHMOCH]
public struct FKFBALGMCLN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public NativeArray<Vector3> HOAPCFLIAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public NativeArray<Vector3> FCGBNFHNIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public NativeArray<Vector4> HKJGHHHAKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public NativeArray<Vector2> PIIEKKHPDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public NativeArray<Vector2> FAHOJPJHHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public NativeArray<Vector2> MIHMJENGEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public NativeArray<Vector2> IBICIJCAEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public NativeArray<Color> KMMHEPMEEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public NativeArray<int> CJHFEHPFNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public NativeArray<int> POJMDKFICPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private NativeArray<int> MDFDLDAPGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private NativeArray<int> BJKAGFFBINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public NativeArray<int> LMLENBOAKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public NativeArray<int> EDLNDLNMIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public NativeArray<int> INEKFBLHCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public NativeArray<BoneWeight> EAGHDDPOFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private NativeArray<int> FFHLFAMMNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private bool PNPNEDHJMEB;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int OAHKMBHGHJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6BD9760", Offset = "0x6BD8B60", VA = "0x186BD9760")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6BD9720", Offset = "0x6BD8B20", VA = "0x186BD9720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int KIELJGMCDFG
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6BD9090", Offset = "0x6BD8490", VA = "0x186BD9090")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6BD9260", Offset = "0x6BD8660", VA = "0x186BD9260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int NFBIMIPDHFL
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6BD9950", Offset = "0x6BD8D50", VA = "0x186BD9950")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6BD9250", Offset = "0x6BD8650", VA = "0x186BD9250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9A20", Offset = "0x6BD8E20", VA = "0x186BD9A20")]
	public FKFBALGMCLN(int KGMOHKBNKPK, int BLADNIFIOBF, int OGNMLEEFENF, int BOIOBNOHLHL, Allocator DBCOPEDFGJL, int DCHNKFCNOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9020", Offset = "0x6BD8420", VA = "0x186BD9020")]
	public void BCDDDHFEHLF(int OBFJPFHENMC, Vector3 FCBPGONDPJI, Vector3 KNIHHDMJHNC, Vector4 BNBMPMKBBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9770", Offset = "0x6BD8B70", VA = "0x186BD9770")]
	public void KJMNIDJBFFO(int OBFJPFHENMC, BoneWeight HHHLKMNLGBB, NativeSlice<byte> OBGHHALHAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9910", Offset = "0x6BD8D10", VA = "0x186BD9910")]
	public Color KMGOKHMFKPK(int OBFJPFHENMC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9930", Offset = "0x6BD8D30", VA = "0x186BD9930")]
	public void MFELIBOMADK(int OBFJPFHENMC, Color JPCJICGNBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6BD8FD0", Offset = "0x6BD83D0", VA = "0x186BD8FD0")]
	public void AIDCMDANKEO(byte BBDECHIHNFC, int OBFJPFHENMC, Vector2 CGDBFDNICEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9960", Offset = "0x6BD8D60", VA = "0x186BD9960")]
	public void OPCHIBPJJDE(int OBFJPFHENMC, int FPKIGOLKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9730", Offset = "0x6BD8B30", VA = "0x186BD9730")]
	public bool KEHOCCPNHJP(int BBDECHIHNFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9650", Offset = "0x6BD8A50", VA = "0x186BD9650")]
	public void JDPMEKHFLIM(int OANDIIGFFCD, int HHOJFKLGPBP, int LGPCCHEOHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9970", Offset = "0x6BD8D70", VA = "0x186BD9970")]
	public int[] PLEGMLEBOKC(int OANDIIGFFCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9270", Offset = "0x6BD8670", VA = "0x186BD9270")]
	private NativeSlice<int> IGCHJLGAEFF(int OANDIIGFFCD)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6BD90A0", Offset = "0x6BD84A0", VA = "0x186BD90A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9300", Offset = "0x6BD8700", VA = "0x186BD9300")]
	public Mesh IGOEGJKNKJJ([Optional] string KDPPOLLJBNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
[MMCIGIHMOCH]
[NativeContainer]
public struct BIGHHIDHAEA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public NativeArray<Vector3> HOAPCFLIAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public NativeArray<Vector3> FCGBNFHNIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public NativeArray<Vector4> HKJGHHHAKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public NativeArray<Vector2> PIIEKKHPDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public NativeArray<Vector2> FAHOJPJHHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public NativeArray<Vector2> MIHMJENGEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public NativeArray<Vector2> IBICIJCAEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public NativeArray<Color> KMMHEPMEEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public NativeArray<int> KJDEMECKOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public NativeArray<int> EFBNBNHAMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public NativeArray<int> HIMLAAPFNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public NativeArray<int> OGLKGCLCMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public NativeArray<bool> JNGFKAEGDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public NativeArray<int> GJGMCILPJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public NativeArray<int> PIJMBDFEBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public NativeArray<BoneWeight> OKDDBCKHOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private NativeArray<Matrix4x4> FPPOIILCGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private NativeArray<int> JEBEICDIPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private NativeArray<byte> HMNGDPHAGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private NativeArray<int> MDHLJECJIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private NativeArray<int> EOODKJHNPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public NativeArray<sbyte> LKDNHKCEBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public NativeArray<byte> EGEHOLKCJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeArray<int> NCLFFHHHDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private bool PNPNEDHJMEB;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int ODLDBKAELAL
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2273940", Offset = "0x2272D40", VA = "0x182273940")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int AGHOKGEFMKA
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x135B770", Offset = "0x135AB70", VA = "0x18135B770")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int FBOIDKGNGCE
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6BD6820", Offset = "0x6BD5C20", VA = "0x186BD6820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int OBIHFOIONPB
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6BD6870", Offset = "0x6BD5C70", VA = "0x186BD6870")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6BD6880", Offset = "0x6BD5C80", VA = "0x186BD6880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int OAHKMBHGHJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6BD68A0", Offset = "0x6BD5CA0", VA = "0x186BD68A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6BD6890", Offset = "0x6BD5C90", VA = "0x186BD6890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int KPNGJOLGGIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6BD6DD0", Offset = "0x6BD61D0", VA = "0x186BD6DD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6BD64D0", Offset = "0x6BD58D0", VA = "0x186BD64D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public DNCEGEOKKGI LMBLDEKPAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6BD65B0", Offset = "0x6BD59B0", VA = "0x186BD65B0")]
		get
		{
			return default(DNCEGEOKKGI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6BD6DE0", Offset = "0x6BD61E0", VA = "0x186BD6DE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public byte OLBBFHHOBNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6BD6860", Offset = "0x6BD5C60", VA = "0x186BD6860")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6BD6850", Offset = "0x6BD5C50", VA = "0x186BD6850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public PECOEEMNDJM LGNCPMFFKIH
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6BD68B0", Offset = "0x6BD5CB0", VA = "0x186BD68B0")]
		get
		{
			return default(PECOEEMNDJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6DF0", Offset = "0x6BD61F0", VA = "0x186BD6DF0")]
	public BIGHHIDHAEA(IList<Mesh> NECEDJFHFEK, IList<Matrix4x4> BGOBCPOFODE, IList<bool> JNGFKAEGDLK, byte HEDIDNDAPOF, IList<byte[]> NHGNNEOIJBP, IList<int> IFBHNNGKDGF, IList<bool> IGAPEDONAIP, IList<int> GJGMCILPJFD, IList<int> HBFLPPHKPHM, IList<int> LPOJEPFNNPL, Allocator DBCOPEDFGJL, DNCEGEOKKGI GMDCOELEBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6BD64E0", Offset = "0x6BD58E0", VA = "0x186BD64E0")]
	public FKFBALGMCLN BBPDJGADMEF(Allocator DBCOPEDFGJL)
	{
		return default(FKFBALGMCLN);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6BD65C0", Offset = "0x6BD59C0", VA = "0x186BD65C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[MMCIGIHMOCH]
public class KLMPJKOEHHH : ECEFGBJJGMN
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE3B0", Offset = "0x6BDD7B0", VA = "0x186BDE3B0")]
	public BIGHHIDHAEA NHAOIDGFGBL()
	{
		return default(BIGHHIDHAEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6BCDB40", Offset = "0x6BCCF40", VA = "0x186BCDB40")]
	public KLMPJKOEHHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct PECOEEMNDJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public NativeSlice<Vector3> HOAPCFLIAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public NativeSlice<Vector3> FCGBNFHNIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public NativeSlice<Vector4> HKJGHHHAKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public NativeSlice<Vector2> PIIEKKHPDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public NativeSlice<Vector2> FAHOJPJHHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public NativeSlice<Vector2> MIHMJENGEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public NativeSlice<Vector2> IBICIJCAEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public NativeSlice<Color> KMMHEPMEEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public NativeSlice<int> EFELADBCFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public NativeSlice<int> OGLKGCLCMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public NativeSlice<BoneWeight> OKDDBCKHOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public NativeSlice<byte> JOJLPMJPAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public int CDMAJAPECCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public Matrix4x4 NDLACNHJLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public int BPBFMLPLGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public NativeSlice<byte> OBGHHALHAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public bool CBNFDGDJFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public int NAMPFJCFLPA;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal readonly struct AIBIBHKIIHC : IEquatable<AIBIBHKIIHC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	internal readonly Material NOGBAHLMMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	internal readonly BPEFDHODIOC BGJBCJMJDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	internal readonly MGHIAONMBJN ACPLOHGAAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	internal readonly MHMNKAMKDLO FMOFKPOGMED;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0xD52490", Offset = "0xD51890", VA = "0x180D52490")]
	public AIBIBHKIIHC(Material JAEJMKKLMIE, BPEFDHODIOC MAEMEMKCLML, MGHIAONMBJN MIAONAHLMOL, MHMNKAMKDLO OJEPPEBDDDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6BD5C70", Offset = "0x6BD5070", VA = "0x186BD5C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0xD52150", Offset = "0xD51550", VA = "0x180D52150", Slot = "4")]
	public bool Equals(AIBIBHKIIHC OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6BD5AF0", Offset = "0x6BD4EF0", VA = "0x186BD5AF0", Slot = "0")]
	public override bool Equals(object FAKGLFFOLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6BD5BD0", Offset = "0x6BD4FD0", VA = "0x186BD5BD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class JCFPLGKEOON : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private MaterialPropertyBlock MAPHDDDCKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public Color? PLDLHCHAMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public Color? EPEJPDIMBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public Color? HLECDHJMIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public Color? AFNDPOHOCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public Color JMECENNFCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public Color EADPKJDLBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public Color NDGJHLJDNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public Texture2D IPHIEJCBPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public Texture2D AOPHEMEBMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private Dictionary<AIBIBHKIIHC, int> LDNEEGOGGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private BPEFDHODIOC[] AAJNGAANBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private MGHIAONMBJN[] BPHNFIDMLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public Vector4[] MELPGDMJOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public Vector4[] BEMHHOCHKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public Vector4[] HBDGENEOBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public Vector4[] JGECLPKJPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public Vector4[] IODNIDFDMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public Vector4[] LPICKBNBALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private List<Texture2D> FFKDNIHHGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private Vector4[] IOIPADIMELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private List<Texture2D> AMHNEFJGNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private float[] IGNGANFCFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private Vector4[] DMOAKBMPFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private float[] GBFMBGJOLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public float[] FCDIKJIIJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private List<Texture2D> LKIJDOJEHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private float[] JDPGKLBJAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private List<Texture2D> ACAMLFLCCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private Vector4[] PGJCFMNCDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private float[] IEKCBELDCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private Vector4[] NNEACGKGBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public float[] LLPKLDJPFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public Texture2DArray EAAFFEAHNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public Texture2DArray EHAFBPLHAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public Texture2DArray CCPLAEJONFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public Texture2DArray JKCBNDDLIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private bool JMOMEMOECCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private int PNIDOACGMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private Vector2? DBGIMBDGACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private TextureFormat PMMNOPDDMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private Vector2? MDOPGBPKKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private TextureFormat FJBJICKNFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private Vector2? HKGCNFCAIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private TextureFormat HHMNHJHFCGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private Vector2? HLFPCJODNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private TextureFormat JEBPODDDBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private bool MPIODIOKEMH;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static int PJBBAOIKKFP;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static int HDMKPLDEGGM;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static int LPELPKCEGOG;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static int LJPMMBOMBBF;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static int DDPKJKOKDMB;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static int NEAIIBNPKGD;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static int LBCGHAAOHGL;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static int IOEHEPDLLHI;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static int OHMMCPNJCOD;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static int JKDAAJLCEIC;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static int GHNABKLLABF;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static int JNIIIGDCBJD;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static int PFHGEHJLJMI;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static int NDIEPCJEKGB;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static int CKGCPBEJGBN;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static int GLDIHOCOOHM;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static int ELDJHJEPHOA;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static int GKMPGBMEBAF;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static int FGOPOPDJEOA;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static int JPIOOEILNEF;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6BDDE00", Offset = "0x6BDD200", VA = "0x186BDDE00")]
	private JCFPLGKEOON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE2F0", Offset = "0x6BDD6F0", VA = "0x186BDE2F0")]
	public JCFPLGKEOON(Color IEHJPCGPFKF, Color GMPOGNFLLIN, Color OCDNGLIKHEI, Color? KODOPCBNDHM, Color? FIECIOHDBAK, Color? IDNCHEBLEAF, Texture2D GCIKNMFDOBL, Texture2D DMPFKKCEPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6BDCBA0", Offset = "0x6BDBFA0", VA = "0x186BDCBA0")]
	internal int JLAPEEDKLOF(Material FGCAIKJNAKB, BPEFDHODIOC MAEMEMKCLML, MGHIAONMBJN MIAONAHLMOL, MHMNKAMKDLO OJEPPEBDDDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6BDCB10", Offset = "0x6BDBF10", VA = "0x186BDCB10")]
	private int JLAPEEDKLOF(AIBIBHKIIHC PBFBBOFLBNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6BDBC30", Offset = "0x6BDB030", VA = "0x186BDBC30")]
	internal int EFOGCIDHBFM(Material FGCAIKJNAKB, Color IDKEBOPMKOG, Color IKGOJEEGOKG, Color IEDKPDOCHAM, Color NGNPAFGDBPD, Color GLCEDFFHFIC, Texture2D OJBEKLAOIDG, Vector4 JNELKBOPGJN, Texture2D LGEGNIONHAC, Vector4 HONAIOJFOHO, float PDJPALGEIKP, float BHOJMIMDIDM, Texture2D NOPHFALLCGE, Vector4 JLLBHEOGNIG, float POIFADKAIBN, Texture2D PLHIJDEAAMG, Color FAKIDLLINHL, Vector4 ODLODMGHGBP, BPEFDHODIOC MAEMEMKCLML, MGHIAONMBJN MIAONAHLMOL, MHMNKAMKDLO OJEPPEBDDDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6BDC800", Offset = "0x6BDBC00", VA = "0x186BDC800")]
	private void IHPNHFLBJAH(List<Texture2D> FFKDNIHHGJJ, [Out] Texture2DArray FHHDGADCPIL, [Out] Texture2DArray OEFOEIFLCEJ, [Out] Texture2DArray HGCPOFGAPDE, [Out] Texture2DArray EFKEJBCGMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6BDCC90", Offset = "0x6BDC090", VA = "0x186BDCC90")]
	public void KAHJPFDMLEL(Shader FLDPPFKOMPM, Renderer CJAGOGFODOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6BDCDE0", Offset = "0x6BDC1E0", VA = "0x186BDCDE0")]
	private void LCNGOIECJKL(Shader FLDPPFKOMPM, Renderer CJAGOGFODOI, int OKNAKFLJPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6BDB940", Offset = "0x6BDAD40", VA = "0x186BDB940")]
	private Color CFHJIOEDMMF(Color GFJPBJEALLO, BPEFDHODIOC IGNMGNOKJMA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6BDC9C0", Offset = "0x6BDBDC0", VA = "0x186BDC9C0")]
	private Color JACFFKNILNL(Color FHDIABBNIID, BPEFDHODIOC IGNMGNOKJMA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6BDB840", Offset = "0x6BDAC40", VA = "0x186BDB840")]
	private bool BNPLKJBFHGL(Texture2D IANIBLEFEIF, MGHIAONMBJN HCKEINFHKFJ, [Out] Texture2D LICBAICCDKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6BDBB40", Offset = "0x6BDAF40", VA = "0x186BDBB40")]
	private void DIPDJOCOHOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6BDBBF0", Offset = "0x6BDAFF0", VA = "0x186BDBBF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class MIIGPPPMLDA
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class ILLAECDGKEJ : IEnumerator<MLEAAPMIINP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private MLEAAPMIINP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private MLEAAPMIINP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
		[DebuggerHidden]
		public ILLAECDGKEJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xD58C20", Offset = "0xD58020", VA = "0x180D58C20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6BDB7F0", Offset = "0x6BDABF0", VA = "0x186BDB7F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
	public static void FFJBBPDOKNK(string HDCHKIOFILD, int BGHMMFOMOHD, long KAJCFJCCAHF, long FGLPANBHDHO, long EAGAHHFLCIK, long KDJEDMAKHGJ, long MNEEJEIDGKC, long HIGCGMBBGIP, long MCOMPMANKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6BDEC10", Offset = "0x6BDE010", VA = "0x186BDEC10")]
	public static IDFKLKAPHIN MFBMBPIHGGN(JobHandle HIDOBODCAMI, bool EMHKFIOMCOI, bool JJOOCGKNBIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6BDEBA0", Offset = "0x6BDDFA0", VA = "0x186BDEBA0")]
	[IteratorStateMachine(typeof(ILLAECDGKEJ))]
	private static IEnumerator<MLEAAPMIINP> BHDNKPJACKI(JobHandle DOBBMOLDHPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class IAPNPBAKOBN
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public enum LNGJJGLMBAL
	{
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		General,
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public static readonly int CLGKJJEFMOH;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public static readonly int FDKCDEEGNMO;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public static readonly int LBEJFLAHDIL;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public static readonly int JGLLKEOECGP;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public static readonly int IADJDLJFCAN;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public static readonly int NJOMFNEGDMK;

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public static readonly int DLAMDLKJAMN;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public static readonly int PCNFDCLMGME;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6BDADE0", Offset = "0x6BDA1E0", VA = "0x186BDADE0")]
	public static bool OOAKEGCHMHP(Material JAEJMKKLMIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6BDAD20", Offset = "0x6BDA120", VA = "0x186BDAD20")]
	public static bool BDFAAKCCKAF(Material JAEJMKKLMIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class IJKDCOOJFFG : ABPIOEHIKHL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private NCGAHALDHDM JPEGLBBMBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private EPFGLFCPJOI GDCPILEIDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private IRecRoomQualityConfigProvider AMLFBPHOFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private bool PNPNEDHJMEB;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6BDB5C0", Offset = "0x6BDA9C0", VA = "0x186BDB5C0")]
	[GOEIKLHOLGG.KCHBNNLNADK.IBDMBHIFIDC]
	internal static void NFLBKLEFKFJ(MCLDCOGKKML HOCJPKACMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2CF0", Offset = "0x5ED20F0", VA = "0x185ED2CF0")]
	[UnityEngine.Scripting.Preserve]
	public IJKDCOOJFFG([NDMEANGLJKD(null)] EPFGLFCPJOI OGOGNDFHAJA, [NDMEANGLJKD(null)] NCGAHALDHDM CMHGKLMNDAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6BDB530", Offset = "0x6BDA930", VA = "0x186BDB530")]
	private void NFBJNPJIGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6BDAFD0", Offset = "0x6BDA3D0", VA = "0x186BDAFD0", Slot = "4")]
	public void DIKKODHKLHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6BDB050", Offset = "0x6BDA450", VA = "0x186BDB050", Slot = "5")]
	public OELCFEONCJD<Texture2D> DKFJAIBEPAO(BHLBEAHKJIJ CPEJOEBBGCD, [Optional] LBGKLHCNPEM FFHLFAMMNGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6BDB6B0", Offset = "0x6BDAAB0", VA = "0x186BDB6B0")]
	private uint OGEMJNDGIEG(BHLBEAHKJIJ CPEJOEBBGCD, LBGKLHCNPEM FFHLFAMMNGJ)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface FHLLNHIGCJA
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BOEEECNBGLP(Mesh OHLMFEKEKFF, Matrix4x4 FOCGEGABAAO, byte[] OBGHHALHAII, bool KALIPOHFMAN = false, MNFPGDBOOJI.NOHJIBHJCAM MLLDOIFDHDG = (MNFPGDBOOJI.NOHJIBHJCAM)0, int GJGMCILPJFD = -1, bool JNGFKAEGDLK = false);

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFMHMGFBLGI(Allocator DBCOPEDFGJL, DNCEGEOKKGI GMDCOELEBEB, byte HEDIDNDAPOF, [Optional] IList<int> HBFLPPHKPHM, [Optional] IList<int> PPBGFDPMGLH);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct FGDMKOGOBGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public readonly GameObject ODHEAGEMJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private readonly AvatarItemMaterial LIAIBGFPMPA;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0xDEC7B0", Offset = "0xDEBBB0", VA = "0x180DEC7B0")]
	public FGDMKOGOBGP(GameObject ODHEAGEMJLJ, AvatarItemMaterial LIAIBGFPMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6BD8B90", Offset = "0x6BD7F90", VA = "0x186BD8B90")]
	public void EGLBCHGOLMJ(Material JAEJMKKLMIE, int OHMEIOBLAPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class LGPFMGBANNB : AJLKNCPNHGO<Task<(GameObject, AvatarItemMaterial)>, FGDMKOGOBGP>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct BOEIKGNBKAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6BD8620", Offset = "0x6BD7A20", VA = "0x186BD8620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6BD8B20", Offset = "0x6BD7F20", VA = "0x186BD8B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private OELCFEONCJD<GameObject> GCFCNAKGGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private OELCFEONCJD<AvatarItemMaterial> MHFPGOOCPHE;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6BDEB10", Offset = "0x6BDDF10", VA = "0x186BDEB10")]
	private LGPFMGBANNB(Task<(GameObject, AvatarItemMaterial)> FFKGFPJNCFN, OELCFEONCJD<GameObject> IPNABEGAIAG, OELCFEONCJD<AvatarItemMaterial> FLICDFOMMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE4A0", Offset = "0x6BDD8A0", VA = "0x186BDE4A0")]
	public static LGPFMGBANNB ANJEPJLHJHG(AssetReference IBNGOINJLDB, [Optional] AssetReference ANHOICOCJPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6BDEA70", Offset = "0x6BDDE70", VA = "0x186BDEA70", Slot = "11")]
	protected override FGDMKOGOBGP IOBIGFFEGDF(Task<(GameObject, AvatarItemMaterial)> NOEMICFDOIB)
	{
		return default(FGDMKOGOBGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE8C0", Offset = "0x6BDDCC0", VA = "0x186BDE8C0", Slot = "12")]
	protected override void CNDJNKPFHMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE940", Offset = "0x6BDDD40", VA = "0x186BDE940")]
	[AsyncStateMachine(typeof(BOEIKGNBKAN))]
	private static Task<(GameObject, AvatarItemMaterial)> FKBGPIOIBMP(Task<GameObject> FCDLNNNEGGL, Task<AvatarItemMaterial> NJEDHCGOBIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class NMLKDFMCHFH
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private class HCNHMIHPPKF : AJLKNCPNHGO<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private OELCFEONCJD<MaterialMapAsset> DOBBMOLDHPN;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6BDAC40", Offset = "0x6BDA040", VA = "0x186BDAC40")]
		public HCNHMIHPPKF(OELCFEONCJD<MaterialMapAsset> DOBBMOLDHPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6BDA800", Offset = "0x6BD9C00", VA = "0x186BDA800", Slot = "11")]
		protected override Material[] IOBIGFFEGDF(Task<MaterialMapAsset> FFKGFPJNCFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6BDA7A0", Offset = "0x6BD9BA0", VA = "0x186BDA7A0", Slot = "12")]
		protected override void CNDJNKPFHMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class FJJMMAOCNGK : AJLKNCPNHGO<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private List<OELCFEONCJD<Material>> DPKJKDBALEE;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6BD8F60", Offset = "0x6BD8360", VA = "0x186BD8F60")]
		public FJJMMAOCNGK(Task<Material[]> FFKGFPJNCFN, List<OELCFEONCJD<Material>> DPKJKDBALEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6BD8F10", Offset = "0x6BD8310", VA = "0x186BD8F10", Slot = "11")]
		protected override Material[] IOBIGFFEGDF(Task<Material[]> NOEMICFDOIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6BD8DD0", Offset = "0x6BD81D0", VA = "0x186BD8DD0", Slot = "12")]
		protected override void CNDJNKPFHMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly LDGDBHIGNCI OLIMOPFMMIB;

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6BDF1B0", Offset = "0x6BDE5B0", VA = "0x186BDF1B0")]
	public static OELCFEONCJD<Material[]> DNINJMJOCLD(AssetReference[] EILJOJHLFKJ)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[PCIEPDMGHOH(AHBKOCJDDCB.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6BE05D0", Offset = "0x6BDF9D0", VA = "0x186BE05D0")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct NDEJMOBJGGF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public AsyncTaskMethodBuilder<CLOMDNLAMDK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public int? eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			private TaskAwaiter<CLOMDNLAMDK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x6BDED60", Offset = "0x6BDE160", VA = "0x186BDED60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x6BDF140", Offset = "0x6BDE540", VA = "0x186BDF140", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private Dictionary<JHKPFMPLNBA, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private Dictionary<JHKPFMPLNBA, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private Dictionary<JHKPFMPLNBA, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private Dictionary<JHKPFMPLNBA, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private readonly Dictionary<JHKPFMPLNBA, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private CLOMDNLAMDK _defaultFaceStyleLegacyBean;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private CLOMDNLAMDK _defaultFaceStyleModernBody;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x6BDA770", Offset = "0x6BD9B70", VA = "0x186BDA770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6BD9FB0", Offset = "0x6BD93B0", VA = "0x186BD9FB0")]
		public CLOMDNLAMDK GEECNFCGCGI(JNJINABLMLP FPADOKOMPIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6BDA5B0", Offset = "0x6BD99B0", VA = "0x186BDA5B0")]
		[AsyncStateMachine(typeof(NDEJMOBJGGF))]
		public Task<CLOMDNLAMDK> MNCENONBCAM(int? KJLHBMNHCEK, int LJFLBNPPGCJ, int MBKPMLGBLLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6BDA510", Offset = "0x6BD9910", VA = "0x186BDA510")]
		public NoseFaceOption KKMFINMILEE(int CMKGEPFCKLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6BDA160", Offset = "0x6BD9560", VA = "0x186BDA160")]
		public SelectableFaceOption HPBLPNMPEAD(FaceFeatureType GLGNKKIHJGD, JHKPFMPLNBA NHACOOJMNNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6BD9E80", Offset = "0x6BD9280", VA = "0x186BD9E80")]
		public int FOFKEKNLHOI(JHKPFMPLNBA NHACOOJMNNA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6BDA2E0", Offset = "0x6BD96E0", VA = "0x186BDA2E0")]
		private void IOEPKPGNGDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2EA30C0", Offset = "0x2EA24C0", VA = "0x182EA30C0")]
		private void PMHJGHKPDNL<T>(IDictionary<JHKPFMPLNBA, T> GCAOPEJPLMF, IReadOnlyList<T> EBAJJLACLED) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6BD9F00", Offset = "0x6BD9300", VA = "0x186BD9F00")]
		public JHKPFMPLNBA GDNBADPDDML(FaceFeatureType GLGNKKIHJGD)
		{
			return default(JHKPFMPLNBA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6BDA040", Offset = "0x6BD9440", VA = "0x186BDA040")]
		public JHKPFMPLNBA HBDGBNIEMCI(FaceFeatureType GLGNKKIHJGD)
		{
			return default(JHKPFMPLNBA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6BDA6E0", Offset = "0x6BD9AE0", VA = "0x186BDA6E0")]
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
