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
	public class LogRegistrationIndex : FIPEGIMCDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x80D6EA0", Offset = "0x80D62A0", VA = "0x1880D6EA0", Slot = "4")]
		public override void AAGBOPIEMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x80DA210", Offset = "0x80D9610", VA = "0x1880DA210", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x80DA1A0", Offset = "0x80D95A0", VA = "0x1880DA1A0", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x80DA1D0", Offset = "0x80D95D0", VA = "0x1880DA1D0")]
		public RecNetCDNAssetReference(RecNetCDNKey PEENICAIFOP)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum PGGMEEBIJBE : byte
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
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA9C690", Offset = "0xA9BA90", VA = "0x180A9C690")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA9C410", Offset = "0xA9B810", VA = "0x180A9C410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PGGMEEBIJBE PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xF1B7F0", Offset = "0xF1ABF0", VA = "0x180F1B7F0")]
			[CompilerGenerated]
			get
			{
				return default(PGGMEEBIJBE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x158DBB0", Offset = "0x158CFB0", VA = "0x18158DBB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x80DA320", Offset = "0x80D9720", VA = "0x1880DA320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x80DA2A0", Offset = "0x80D96A0", VA = "0x1880DA2A0")]
		public static RecNetCDNKey DIIFAJALPPO(string FJAFKOFLBBB, PGGMEEBIJBE NOKJJBHLGDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x80DA250", Offset = "0x80D9650", VA = "0x1880DA250")]
		public void BIBIGKPNOFL(string LBKFGCFBIDE, string GONCBGJFGEK, bool AAJDMIGIEGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[EAFHNCFGKJO]
public class GICAECAKNCM : OINPEMKBEHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<Mesh> PBHEENPMGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<byte[]> NDAGODILIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<Matrix4x4> POHCMLHPDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly List<bool> PNHMDDGHLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly List<long> HDHOLNIPCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly List<bool> JDCIEDLHHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected readonly List<int> IJIBHHLMKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected Allocator CCGDJJKPPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected NFFBEAMILGG JOKFOINGCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected byte LGOFJGBOMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected IList<int> ICIIDGJOPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected IList<int> DLEDNIFFFCL;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x80D5990", Offset = "0x80D4D90", VA = "0x1880D5990", Slot = "4")]
	public void HFEDMCKFDCJ(Mesh NIKBNBLEJEO, Matrix4x4 EEPMMDEGOIL, byte[] FACLODLGKNG, bool NLGBGKHAPEH = false, LFDPDKBANDC.JGFNEKKJIOP HCGPMFKLFAI = (LFDPDKBANDC.JGFNEKKJIOP)0L, int PAIDIFCDDEI = -1, bool FPBACDLKLDM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x80D5D50", Offset = "0x80D5150", VA = "0x1880D5D50", Slot = "5")]
	public void IKCDNILAADH(Allocator KCEIEKBPKNP, NFFBEAMILGG DBHGIIJIOEE, byte HLINDEAICCD, [Optional] IList<int> AEJDOFBCFEA, [Optional] IList<int> AOAIAGEGMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x80D5730", Offset = "0x80D4B30", VA = "0x1880D5730")]
	private static void AFKGFLOHNCE(Mesh NIKBNBLEJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x80D5D90", Offset = "0x80D5190", VA = "0x1880D5D90")]
	public GICAECAKNCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[EAFHNCFGKJO]
public struct BLPEEJKAKDO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public FJDCIAMNIGG FIEJCGAIMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public int JILDJBAHNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public POKINHDPFKK ALFDGMCAONI;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x80C4800", Offset = "0x80C3C00", VA = "0x1880C4800", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[EAFHNCFGKJO]
[NativeContainer]
public struct POKINHDPFKK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct HNBFJGGAJKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector3 IADDHHAKJCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector3 KIAHAFCJEPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector4 NJGCOCEOHFP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct GLHIOJBDJLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float DHCEAOOBFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float AOKKHDBLIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float OGFBCAPFLGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float LKIHAABKGBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte GLAACIFKLAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public byte NOFFNBDGAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public byte PIBHNFHJFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte PPLLGGFOPBL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct JLIALHFNHGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half DHCEAOOBFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half AOKKHDBLIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half OGFBCAPFLGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half LKIHAABKGBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public byte GLAACIFKLAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte NOFFNBDGAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public byte PIBHNFHJFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public byte PPLLGGFOPBL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct GLFKNNGGPMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 IFBOGFLAOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 ILJELKHKPGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half4 CPHJLGINBBP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct DJIAJABBKHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half4 IFBOGFLAOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 ILJELKHKPGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 JFPNMJAEGFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half4 CPHJLGINBBP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct CHOFDPCODJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half4 IFBOGFLAOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 ILJELKHKPGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half2 JFPNMJAEGFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public half2 DACPKKOBPFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public half4 CPHJLGINBBP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct CJBDHEHGHKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public half4 IFBOGFLAOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public half2 ILJELKHKPGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public half2 JFPNMJAEGFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public half2 DACPKKOBPFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public half2 BNNPHDFIDOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public half4 CPHJLGINBBP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct ANHJPNBGIJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float DHCEAOOBFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public float AOKKHDBLIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float OGFBCAPFLGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float LKIHAABKGBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int GLAACIFKLAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int NOFFNBDGAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int PIBHNFHJFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int PPLLGGFOPBL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct HDBMINHHBKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color IFBOGFLAOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 ILJELKHKPGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector4 CPHJLGINBBP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct HODEAPPNIEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Color IFBOGFLAOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 ILJELKHKPGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Vector2 JFPNMJAEGFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector4 CPHJLGINBBP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct BCMHLIMDCPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Color IFBOGFLAOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Vector2 ILJELKHKPGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Vector2 JFPNMJAEGFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Vector2 DACPKKOBPFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Vector4 CPHJLGINBBP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct EHBEKCGHKGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Color IFBOGFLAOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Vector2 ILJELKHKPGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Vector2 JFPNMJAEGFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Vector2 DACPKKOBPFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Vector2 BNNPHDFIDOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Vector4 CPHJLGINBBP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool IBHAEPILAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<HNBFJGGAJKL> BFLNPLAGPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<GLFKNNGGPMK> EABMEPALOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<DJIAJABBKHJ> ABDBOGNADCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<CHOFDPCODJG> HOMBMPIMAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<CJBDHEHGHKG> POHPLODAJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<JLIALHFNHGI> FKGEPGJBHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<GLHIOJBDJLC> BBADDBCGNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<HDBMINHHBKJ> CHFDGGJEKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<HODEAPPNIEN> KAINOODKGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<BCMHLIMDCPN> ONBHOPHCCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<EHBEKCGHKGC> GAPAFHHHIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<ANHJPNBGIJA> LBFOHJLCCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> BIIADHNKNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> POMAHLHNAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> GMFAGGFKNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> CEAIGHMHKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> NHCJENGPIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> CPMJGDABEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<int> NBLILMAPKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<BoneWeight> FPELBFGJADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> FGEMBJJOPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool CNJLDENEPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool FCEPOLLEEIA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int PHOMHPCMHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x80D84F0", Offset = "0x80D78F0", VA = "0x1880D84F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x80D8500", Offset = "0x80D7900", VA = "0x1880D8500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int OKAPEBJBECD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x80D6F30", Offset = "0x80D6330", VA = "0x1880D6F30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x80D9700", Offset = "0x80D8B00", VA = "0x1880D9700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DPCJEOAINOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x80D6F40", Offset = "0x80D6340", VA = "0x1880D6F40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x80D9530", Offset = "0x80D8930", VA = "0x1880D9530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int HKBINALLMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x80D85A0", Offset = "0x80D79A0", VA = "0x1880D85A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x80D9770", Offset = "0x80D8B70", VA = "0x1880D9770")]
	public POKINHDPFKK(int GEDMNCMFHME, int OCDMMPIHHKO, int GNLJNMHMGDB, int AIDLAPOIBBA, Allocator KCEIEKBPKNP, int NPIGLOCJFJH, BJFBJNACKNP CMKDCKPLFPA, bool CNJLDENEPAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x80D8510", Offset = "0x80D7910", VA = "0x1880D8510")]
	public void MBGCBOCDKAI(int NOEININIMIL, Vector3 EMOJJIEJAKM, Vector3 FFIGKKPMMAC, Vector4 DBAMLJDDEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x80D7C90", Offset = "0x80D7090", VA = "0x1880D7C90")]
	public void INIBEMGFGDJ(int NOEININIMIL, BoneWeight LKAADODHMPP, NativeSlice<byte> FACLODLGKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x80D74B0", Offset = "0x80D68B0", VA = "0x1880D74B0")]
	public Color BOCMEAALLJH(int NOEININIMIL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x80D80C0", Offset = "0x80D74C0", VA = "0x1880D80C0")]
	public void JDDMKGNIPIG(int NOEININIMIL, Color CHNNNFLKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x80D9540", Offset = "0x80D8940", VA = "0x1880D9540")]
	public void ODMCKFGMHIP(int NOEININIMIL, Vector3 DPIFCOHCFGC, Vector3 ACFOBDEJIJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x80D6F50", Offset = "0x80D6350", VA = "0x1880D6F50")]
	public void ANOIKBGFFAD(int NOEININIMIL, half4 JECEDNFCAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x80D7A40", Offset = "0x80D6E40", VA = "0x1880D7A40")]
	public void EPBBFIOALCG(int NOEININIMIL, Vector3 JECEDNFCAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x80D70A0", Offset = "0x80D64A0", VA = "0x1880D70A0")]
	public void BGCOOLMIABP(byte GMOCENPLJAO, int NOEININIMIL, Vector2 JECEDNFCAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x80D7A30", Offset = "0x80D6E30", VA = "0x1880D7A30")]
	public void EFBMOBNHPJC(int NOEININIMIL, int KMNLHHNFMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x80D9710", Offset = "0x80D8B10", VA = "0x1880D9710")]
	public bool ONDPEHIFIFJ(int GMOCENPLJAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x80D9630", Offset = "0x80D8A30", VA = "0x1880D9630")]
	public void OEBHDGGDFLK(int BEFOADGEAGO, int FDIDNNCIDHK, int COONBEDHJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x80D77D0", Offset = "0x80D6BD0", VA = "0x1880D77D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x80D8610", Offset = "0x80D7A10", VA = "0x1880D8610")]
	public Mesh NJOGLGIOIDJ([Optional] string OODHDKLMIHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[EAFHNCFGKJO]
[NativeContainer]
public struct FJDCIAMNIGG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Mesh.MeshDataArray APONHAMBEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<int> CJKLFHENJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeArray<int> AIBENPPJNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<BoneWeight> FPELBFGJADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<Matrix4x4> MEFPHKNPNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<long> LMKANFIFGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<byte> OKECOHCGJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<int> BPEPJOJKMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeArray<int> NMEHJLLJOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeArray<sbyte> KGIFNFHJOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public NativeArray<byte> HJFDKODGHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public NativeArray<bool> FPBACDLKLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeArray<int> PAIDIFCDDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool CNJLDENEPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeArray<int> BCGNCNLBNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool FCEPOLLEEIA;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int IDEMELHNKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x80D4340", Offset = "0x80D3740", VA = "0x1880D4340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int PDEGINJEKPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x80D4560", Offset = "0x80D3960", VA = "0x1880D4560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int JAJJBNGJHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x80D4390", Offset = "0x80D3790", VA = "0x1880D4390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int BAHEJGCKCNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x80D4360", Offset = "0x80D3760", VA = "0x1880D4360")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x80D4350", Offset = "0x80D3750", VA = "0x1880D4350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int PHOMHPCMHPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x80D4370", Offset = "0x80D3770", VA = "0x1880D4370")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x80D4470", Offset = "0x80D3870", VA = "0x1880D4470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int PKIEJBNGNGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x80D4460", Offset = "0x80D3860", VA = "0x1880D4460")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x80D3F50", Offset = "0x80D3350", VA = "0x1880D3F50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NFFBEAMILGG DLDCBBOEEIN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x80D4570", Offset = "0x80D3970", VA = "0x1880D4570")]
		get
		{
			return default(NFFBEAMILGG);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x80D4550", Offset = "0x80D3950", VA = "0x1880D4550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte JEEIPOGCFPA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x80D4380", Offset = "0x80D3780", VA = "0x1880D4380")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x80D40E0", Offset = "0x80D34E0", VA = "0x1880D40E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public KBFAEAEEIHA FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x80D40F0", Offset = "0x80D34F0", VA = "0x1880D40F0")]
		get
		{
			return default(KBFAEAEEIHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x80D4580", Offset = "0x80D3980", VA = "0x1880D4580")]
	public FJDCIAMNIGG(IList<Mesh> JKLIMNOCDJA, IList<Matrix4x4> HHCBABJEICB, IList<bool> FPBACDLKLDM, byte HLINDEAICCD, IList<byte[]> FEPCEAONAKP, IList<long> FDICPLNDCBN, IList<bool> LPGIKLLLIEC, IList<int> PAIDIFCDDEI, IList<int> AEJDOFBCFEA, IList<int> PHGAEDKMJJH, Allocator KCEIEKBPKNP, NFFBEAMILGG DBHGIIJIOEE, bool CNJLDENEPAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x80D4480", Offset = "0x80D3880", VA = "0x1880D4480")]
	public POKINHDPFKK MGJDNANBBCH(Allocator KCEIEKBPKNP, BJFBJNACKNP CMKDCKPLFPA)
	{
		return default(POKINHDPFKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x80D3F60", Offset = "0x80D3360", VA = "0x1880D3F60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[EAFHNCFGKJO]
public class ICDAIBOGMJO : GICAECAKNCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public bool GLPINCIFEIE;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static readonly ProfilerMarker FGAMGPKCIOB;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x80D5FE0", Offset = "0x80D53E0", VA = "0x1880D5FE0")]
	public FJDCIAMNIGG FKHBAKLNBKM()
	{
		return default(FJDCIAMNIGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x80D62A0", Offset = "0x80D56A0", VA = "0x1880D62A0")]
	public ICDAIBOGMJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct KBFAEAEEIHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Mesh.MeshData KNLIMECLJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public NativeSlice<BoneWeight> FPELBFGJADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeSlice<byte> JFNJNIINMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public int NFACFOOABHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Matrix4x4 DAHIABBNLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public long GCNKPMGHPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeSlice<byte> FACLODLGKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public bool NINFMAEJDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public int BAMDHMKIAGP;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class DDPPAPLKBEM : CNJDPLBKGCC
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class DMIBNPFCFAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public bool hideTorsoInFirstPersonBeanMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public DDPPAPLKBEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public BENMIFMGNEN buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public Action<KeyValuePair<string, JAKNEJKGEIC<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public DMIBNPFCFAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x80D3C80", Offset = "0x80D3080", VA = "0x1880D3C80")]
		internal bool GJJMJJOOALI(CDGCPFKIDBL item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x80D3D80", Offset = "0x80D3180", VA = "0x1880D3D80")]
		internal void MPHKFNBECML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x80D3C30", Offset = "0x80D3030", VA = "0x1880D3C30")]
		internal void PHAGDGLHKDJ(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x80D3D80", Offset = "0x80D3180", VA = "0x1880D3D80")]
		internal void IBNFHBJICDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x80D3C30", Offset = "0x80D3030", VA = "0x1880D3C30")]
		internal void BKOGEFKGLBN(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x80D3C50", Offset = "0x80D3050", VA = "0x1880D3C50")]
		internal void ENOLCOGPILE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x80D3DA0", Offset = "0x80D31A0", VA = "0x1880D3DA0")]
		internal void ODHLIJNMENN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x80D3DD0", Offset = "0x80D31D0", VA = "0x1880D3DD0")]
		internal void PABNPEGIBNO(Dictionary<string, JAKNEJKGEIC<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x80D3CC0", Offset = "0x80D30C0", VA = "0x1880D3CC0")]
		internal void IAEEMNCJKNM(KeyValuePair<string, JAKNEJKGEIC<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		internal IHCAHILICGC JCLHDMMAOPD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class FFAOCCNDODM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public DMIBNPFCFAN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public FFAOCCNDODM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x80D3E90", Offset = "0x80D3290", VA = "0x1880D3E90")]
		internal DOHGLMBEJEJ FEOONPAFKLG(int lod)
		{
			return default(DOHGLMBEJEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class NECGBFNMLIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public FHMCAMOMJOP<Dictionary<string, JAKNEJKGEIC<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public NECGBFNMLIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		internal FHMCAMOMJOP<Dictionary<string, JAKNEJKGEIC<Texture2D>>> AEDDCMAFNBN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class BFMOOJHIGKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public List<BENMIFMGNEN> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public BFMOOJHIGKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x80C46D0", Offset = "0x80C3AD0", VA = "0x1880C46D0")]
		internal void JEIHLPNENKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class ILEMDDLNOGK : IEnumerator<KHJLACPAINM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private KHJLACPAINM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public DDPPAPLKBEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public List<GLHCJMPCBPP> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public List<BENMIFMGNEN> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Func<int, DOHGLMBEJEJ> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public CPAAGOKGAKE materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private KHJLACPAINM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
		[DebuggerHidden]
		public ILEMDDLNOGK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x80D62B0", Offset = "0x80D56B0", VA = "0x1880D62B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x80D6530", Offset = "0x80D5930", VA = "0x1880D6530", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class JLGLNFOICGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public PGICHMGLAEF cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public JLGLNFOICGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xBAFDB0", Offset = "0xBAF1B0", VA = "0x180BAFDB0")]
		internal void FEACLOCBIKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xE0A080", Offset = "0xE09480", VA = "0x180E0A080")]
		internal void PGDPNEDPPBC(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class AKLNOCHKPHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public DDPPAPLKBEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public List<(int mat, int part)> avatarItemMaterialPartIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public List<Bounds> avatarPartMeshBounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public AKLNOCHKPHB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class KCAFIHDNFDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public POKINHDPFKK defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public FJDCIAMNIGG defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public AKLNOCHKPHB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public KCAFIHDNFDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x80D6830", Offset = "0x80D5C30", VA = "0x1880D6830")]
		internal void BHIEHABKODM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x80D6E30", Offset = "0x80D6230", VA = "0x1880D6E30")]
		internal void HFDHMJOPJDJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class IOGIOHBBMPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public NKCHLEKKLDL legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public GJMMOOLGJDB legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public AKLNOCHKPHB CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public IOGIOHBBMPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x80D6580", Offset = "0x80D5980", VA = "0x1880D6580")]
		internal void BFOGPNPMNKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x80D67C0", Offset = "0x80D5BC0", VA = "0x1880D67C0")]
		internal void GIPMIIFJAGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class AOACIBNCLIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public DDPPAPLKBEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public float power;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public Color color;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public AOACIBNCLIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x80DAFC0", Offset = "0x80DA3C0", VA = "0x1880DAFC0")]
		internal void FLIFKBFACJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class AIOPPHEGKMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public KMPAOABCDOI overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public AIOPPHEGKMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x80DA8C0", Offset = "0x80D9CC0", VA = "0x1880DA8C0")]
		internal bool CAHFNKECGMJ(KeyValuePair<string, CDGCPFKIDBL> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly OFFOKCJIMNI JDPNFEHPFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly OFFOKCJIMNI DJLDPEGACON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Dictionary<IKJHOMLMOIB, float> GJJDDJFNJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Dictionary<NGHFELHBJNN, float> HIOKDFDFFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Dictionary<LKLBBBNPHMA, float> CBLCEHDENNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyDictionary<string, HHNHJEBDJCH> GJNDHGPDILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Dictionary<string, HHNHJEBDJCH> IBDOLLFOKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Dictionary<string, HHNHJEBDJCH> DJIFKEAEHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Dictionary<string, HHNHJEBDJCH> KGPBDHEEJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private KPJJMDIMPBJ AGFHEMHMOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private KPJJMDIMPBJ FPOLPDLJNBE;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static float CENDMCDFEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool? ECILPMMEAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool? IGEGMGDAABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool? PBHFFOBIDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool? NBLPCGFKCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private AvatarConfiguration LDDMJBEDJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Transform KNDCBGMELDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private AvatarSkinAssetItem JPJGFBBDIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private AssetReference GOCMAAMMGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private GameObject HENPDBMJFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private GameObject IKGCHKOMLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private GameObject LODBHJCKCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private SkinnedMeshRenderer KKHPDFEMBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private AvatarSkinnedMeshBoneOrderRemapsData BMIJHKNIEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Transform[] BJLHHKKFEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private Matrix4x4[] CEDHBOLICKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private Material NNKJBOJNDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Material DLLBIMHMNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private Material OMAAONMOHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Material DDPOHJBNDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Shader NAMLMMCOHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private Shader NOBNOMPAKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private Animator NMLHHLODJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Renderer[] BEOILLKNLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private LFDPDKBANDC.JGFNEKKJIOP DHPDEDONPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private AvatarBodyPartShapesManager BJOCBIPEDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private IReadOnlyDictionary<string, Transform> PMKJKGIGNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private AvatarFaceShapeData.FJBCNNLGPEG EAFLFOBOCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private AvatarBodyShapeData.PGNDACDGLJG BHFPGFJPNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private BIBEJHBBCLK DLGKPLHCDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private bool GHCIAIHKJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x125")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private bool ACOPBBGJLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Color PJIAJCJLEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Color JLIIHEDBMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Color LKKALLOAFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Color? HNKPHEIDANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Color? KCKGKGAIIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Color? EDAKILCGNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private Color? DIEHDKHPGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private Texture2D FMNJDFHNADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private Texture2D HIDAOHLMNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[CanBeNull]
	private CDGCPFKIDBL LNIKJCGOFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Texture JLCHOPPPINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Color NENPEANNLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public Dictionary<Renderer, CPAAGOKGAKE> ALJMFILBBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Dictionary<Renderer, CPAAGOKGAKE> EGLPHOFGMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Dictionary<string, List<AKNJMIMOAHN>> IKIBMCIPCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Dictionary<string, List<AKNJMIMOAHN>> NCOBCGIHOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly List<BFNEHIJGJBB> OHKDLNHAGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly List<BFNEHIJGJBB> MFMAKPKJCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly List<BFNEHIJGJBB> HOKKHODGFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly List<BFNEHIJGJBB> APLOGKLPPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Dictionary<AKNJMIMOAHN, Material> KMAMEMLJFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Dictionary<AKNJMIMOAHN, Material> OLFDNNJLJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private SkinnedMeshRenderer[] BLMCIBCODPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private SkinnedMeshRenderer[] MKIAMFGIEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private SkinnedMeshRenderer[] ODAAODLPDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private SkinnedMeshRenderer[] LHHMHEBBHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly Dictionary<string, JAKNEJKGEIC<Texture2D>> OAIICAHCFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly Dictionary<string, JAKNEJKGEIC<Texture2D>> KNEBBMGDPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private AdditionalHatData GEIMOOMIHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private AdditionalHatData EFCOMGACKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private HairData ABLOKBDMGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private HairData ELHHOIICHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private CHMLELHGCGH GEOCGPJIABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private bool? MNEPNOHLMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private PositionAndRotation AADOPOMOFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Transform EIGDCGJGJOI;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private Material KPOEPMNONCI;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private Material EFKENEAIINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<string, CDGCPFKIDBL> BAFAFDNIJNM;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static readonly int POOAALMHAIM;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly int BADLNDGMGKK;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly int JENCNHNEANP;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static readonly int BOKKOPGGBBL;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly int FMIKKKFGGAC;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int BJGLFDKDJOD;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int MIAAAABPGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private bool LKICGCCOKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private List<Action> HBLEHACPFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private EGOGGADCJBA BEHIINBLJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private SkinnedMeshRenderer[] JOHGBHLCBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private int LANEFLJDLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private bool GEFGBIMCEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private int LAIDEPEKGMN;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public OFFOKCJIMNI LAMCFCHMEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public OFFOKCJIMNI EEFBANKMNBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private LFMDEIGOMOD HPKDJJIICKF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x80D1520", Offset = "0x80D0920", VA = "0x1880D1520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool PJCGAHFLBGB
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x80CDCC0", Offset = "0x80CD0C0", VA = "0x1880CDCC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool LIDICFNOLGF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x80D27E0", Offset = "0x80D1BE0", VA = "0x1880D27E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool MEJFAMCDADI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x80D02E0", Offset = "0x80CF6E0", VA = "0x1880D02E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool IMKEIBLGPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x80CDBE0", Offset = "0x80CCFE0", VA = "0x1880CDBE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public AvatarConfiguration LOIAMBLPPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA70440", Offset = "0xA6F840", VA = "0x180A70440", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool EIFECICBNOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x135D490", Offset = "0x135C890", VA = "0x18135D490")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x135D9C0", Offset = "0x135CDC0", VA = "0x18135D9C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Material OIOLKKDOOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x80CE350", Offset = "0x80CD750", VA = "0x1880CE350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Material OKNILCCGCJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x80CB500", Offset = "0x80CA900", VA = "0x1880CB500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool BBACAMIMEGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public AGMMOBNOCAG KAKEPKOJFME
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x25786B0", Offset = "0x2577AB0", VA = "0x1825786B0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(AGMMOBNOCAG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x80CE640", Offset = "0x80CDA40", VA = "0x1880CE640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Material GKOEBJKBCDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xAE4BE0", Offset = "0xAE3FE0", VA = "0x180AE4BE0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public SkinnedMeshRenderer[] MAJOPFFCGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xE23600", Offset = "0xE22A00", VA = "0x180E23600", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Renderer[] JHOIDFOFBHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAF1220", Offset = "0xAF0620", VA = "0x180AF1220", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool EBHHGCCHGLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x80CCD70", Offset = "0x80CC170", VA = "0x1880CCD70", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public LFDPDKBANDC.JGFNEKKJIOP HEFDNPKECDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAE4AD0", Offset = "0xAE3ED0", VA = "0x180AE4AD0", Slot = "20")]
		get
		{
			return default(LFDPDKBANDC.JGFNEKKJIOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int GEKLGAICLJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x80CB190", Offset = "0x80CA590", VA = "0x1880CB190")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x80C6320", Offset = "0x80C5720", VA = "0x1880C6320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool BCJBPDCHIOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x80D14A0", Offset = "0x80D08A0", VA = "0x1880D14A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private static bool IACHHOGCGIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x80CBE20", Offset = "0x80CB220", VA = "0x1880CBE20", Slot = "15")]
	public BENMIFMGNEN HLKCLKGOPAD(DGHDGHOFFPP IFJJFJGKCMI, bool BJFPHDBMGLL, int[] AIGCACHBNLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x80D2B50", Offset = "0x80D1F50", VA = "0x1880D2B50", Slot = "14")]
	public BENMIFMGNEN OOANLELAOBL(DGHDGHOFFPP IFJJFJGKCMI, bool BJFPHDBMGLL, int[] AIGCACHBNLA, Func<Dictionary<string, CDGCPFKIDBL>, (BENMIFMGNEN, FHMCAMOMJOP<Dictionary<string, JAKNEJKGEIC<Texture2D>>>)> IJPEBDNAFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x80CE6D0", Offset = "0x80CDAD0", VA = "0x1880CE6D0")]
	public BENMIFMGNEN LOGFFKEECHL(DGHDGHOFFPP IFJJFJGKCMI, bool BJFPHDBMGLL, int[] AIGCACHBNLA, bool BBENCIHFGIL, KPJJMDIMPBJ FBFIDNOPMDM, [Optional] Func<Dictionary<string, CDGCPFKIDBL>, (BENMIFMGNEN, FHMCAMOMJOP<Dictionary<string, JAKNEJKGEIC<Texture2D>>>)> IJPEBDNAFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x80CE040", Offset = "0x80CD440", VA = "0x1880CE040")]
	private bool KMGDDDMCPBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x80D20E0", Offset = "0x80D14E0", VA = "0x1880D20E0")]
	private BENMIFMGNEN NNHIDFGENDI(bool BJFPHDBMGLL, List<GLHCJMPCBPP> AOFKKBPIOLM, int[] AIGCACHBNLA, Func<int, DOHGLMBEJEJ> LADCDLKCIKH, bool BBENCIHFGIL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x80CAE00", Offset = "0x80CA200", VA = "0x1880CAE00")]
	[IteratorStateMachine(typeof(ILEMDDLNOGK))]
	private IEnumerator<KHJLACPAINM> FPOMGNJPGEK(bool BJFPHDBMGLL, List<GLHCJMPCBPP> AOFKKBPIOLM, int[] AIGCACHBNLA, Func<int, DOHGLMBEJEJ> LADCDLKCIKH, CPAAGOKGAKE IPFJJAOFFIK, Material LIIDNHAOGFE, List<BENMIFMGNEN> LNOBDADPNEJ, bool LLLKJNKCIBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x80CD1A0", Offset = "0x80CC5A0", VA = "0x1880CD1A0")]
	private void KBPJFMGJOAO(List<GLHCJMPCBPP> AOFKKBPIOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x80C9E20", Offset = "0x80C9220", VA = "0x1880C9E20")]
	private BENMIFMGNEN EDDADNOHBFM(List<GLHCJMPCBPP> AOFKKBPIOLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x80C80F0", Offset = "0x80C74F0", VA = "0x1880C80F0")]
	private LDBPABGAEKE CMNPBNNADMD(List<GLHCJMPCBPP> AOFKKBPIOLM, int BFGBMBMPPGG, bool BJFPHDBMGLL, DOHGLMBEJEJ DANOPCAPJEB, bool IOEHHBJHLHC, CPAAGOKGAKE IPFJJAOFFIK, Material LIIDNHAOGFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x80D2C20", Offset = "0x80D2020", VA = "0x1880D2C20", Slot = "27")]
	public void PCJHHNKHDNG(IKJHOMLMOIB DFDNJFJKIFC, float CBMEHPPMEEA, bool FHMJMIAPOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x80D2000", Offset = "0x80D1400", VA = "0x1880D2000", Slot = "29")]
	public void NNCKLDDFKIP(NGHFELHBJNN PIEHDBGLBHL, float CBMEHPPMEEA, bool NENBPDCLEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x80C8000", Offset = "0x80C7400", VA = "0x1880C8000", Slot = "30")]
	public void CLGCDKCKBOG(LKLBBBNPHMA MGPAIFKCMHE, float CBMEHPPMEEA, bool BLMKAINOIPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x80C72C0", Offset = "0x80C66C0", VA = "0x1880C72C0", Slot = "28")]
	public void BBPLGDIJFPJ(bool GHNAFDPCMFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x80CD0E0", Offset = "0x80CC4E0", VA = "0x1880CD0E0", Slot = "31")]
	public void JOKBIACNPPB(bool GHNAFDPCMFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x80C93A0", Offset = "0x80C87A0", VA = "0x1880C93A0", Slot = "32")]
	public void DBJFNOABKMD(bool GHNAFDPCMFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x80C7E90", Offset = "0x80C7290", VA = "0x1880C7E90")]
	private void BPJABPIJENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x80C7B30", Offset = "0x80C6F30", VA = "0x1880C7B30")]
	private void BMODKOKLBLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x80C7800", Offset = "0x80C6C00", VA = "0x1880C7800")]
	private void BGFJHDLFJCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x80CB0D0", Offset = "0x80CA4D0", VA = "0x1880CB0D0", Slot = "25")]
	public void GHIIGBJOMOC(AvatarFaceShape PFMDLLEJAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x80C7A70", Offset = "0x80C6E70", VA = "0x1880C7A70", Slot = "26")]
	public void BLLBGFMNICG(AvatarBodyShape DMOJGFNKIPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xB49D60", Offset = "0xB49160", VA = "0x180B49D60", Slot = "33")]
	public void BPLLKCHKFEE(BIBEJHBBCLK HKFNPLIFPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x80C6900", Offset = "0x80C5D00", VA = "0x1880C6900", Slot = "35")]
	public void AINPNIKIFIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x80C7880", Offset = "0x80C6C80", VA = "0x1880C7880", Slot = "41")]
	public void BJILEMDEDAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x80CD140", Offset = "0x80CC540", VA = "0x1880CD140", Slot = "34")]
	public void KAAKGONODMP(bool CIANLJFMBGI, bool NGKJEKGMBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x80CBE50", Offset = "0x80CB250", VA = "0x1880CBE50")]
	private void HLPHLCPLCDA(SkinnedMeshRenderer KKBJPEKANFI, int BFGBMBMPPGG, Mesh NIKBNBLEJEO, List<Material> FIBFPCLCIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x80CDEE0", Offset = "0x80CD2E0", VA = "0x1880CDEE0")]
	private static Material KJHAOPHBIAE(Dictionary<AKNJMIMOAHN, Material> BNGCKMHEMKL, Material FBLHNEEACOC, HOPHAMFEDGF LCKDFGPELPB, PHHJIMPAPKF AFMPOACCGLJ, KMPAOABCDOI FBBAOHEBJDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x80D1920", Offset = "0x80D0D20", VA = "0x1880D1920")]
	private static HOPHAMFEDGF NJAMCCMCOHJ(GLHCJMPCBPP KIPPCMLFNHG, int MNNPIADPAEN)
	{
		return default(HOPHAMFEDGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x80CD7D0", Offset = "0x80CCBD0", VA = "0x1880CD7D0")]
	private void KDHAJNJHLMI(int LGBNJHMFDIE, Material GMFBEMFEGJH, GLHCJMPCBPP KIPPCMLFNHG, [Out] Texture2D IJNGLJNKABE, [Out] Vector4 ACFEHOBHLBO, [Out] Texture2D CKCDOBLPNHE, [Out] Texture2D JFGMGCNKBNC, [Out] Texture2D OFCHNJALGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x80C95D0", Offset = "0x80C89D0", VA = "0x1880C95D0")]
	private void DHMAFPJLDBF(int LGBNJHMFDIE, Material GMFBEMFEGJH, GLHCJMPCBPP KIPPCMLFNHG, [Out] Color JCOIDDADMCN, [Out] Color FPFBFOIJFNO, [Out] Color IPLGMAFIILM, [Out] Color ABKLKFDFLGF, [Out] Color HCKKIIOECHE, [Out] Color OPLMFPGAJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x80CC6B0", Offset = "0x80CBAB0", VA = "0x1880CC6B0")]
	private bool IKIBPGFKCBP(Material GMFBEMFEGJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x80D18B0", Offset = "0x80D0CB0", VA = "0x1880D18B0")]
	private static Material NEJEKAGFDBO(int LGBNJHMFDIE, HCGHDLGGKGG KIPPCMLFNHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x80C7320", Offset = "0x80C6720", VA = "0x1880C7320")]
	private static PHHJIMPAPKF BCFJFKGJFEP(GLHCJMPCBPP KIPPCMLFNHG, int MNNPIADPAEN)
	{
		return default(PHHJIMPAPKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x80CC9A0", Offset = "0x80CBDA0", VA = "0x1880CC9A0")]
	private static void JBEEAKHEGEC(Dictionary<string, List<AKNJMIMOAHN>> FKMIOCNPCCJ, GLHCJMPCBPP EMDAMIKMHBF, Material FBLHNEEACOC, HOPHAMFEDGF AHEDBNJBENB, PHHJIMPAPKF IMCDPIHCLGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x80C75D0", Offset = "0x80C69D0", VA = "0x1880C75D0")]
	private static SkinnedMeshRenderer BFFFCJBDHNN(Transform LENKCFJNOFH, Transform ENOHEPJCKPA, SkinnedMeshRenderer[] DINJJCDOOFK, int BFGBMBMPPGG, DOHGLMBEJEJ DANOPCAPJEB, bool BJFPHDBMGLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x80D3270", Offset = "0x80D2670", VA = "0x1880D3270")]
	public DDPPAPLKBEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x80D2D00", Offset = "0x80D2100", VA = "0x1880D2D00")]
	public void PJOFCLDPLJB([In] HBPHNLGIMKO MMGPKNOCLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x80C7E10", Offset = "0x80C7210", VA = "0x1880C7E10")]
	public void BOLDNADPGLN([In] FCFKKMOBKPH FILLPKCHMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x80C6320", Offset = "0x80C5720", VA = "0x1880C6320", Slot = "5")]
	public void AEAHBNLNCHE(int BFGBMBMPPGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x80CBFA0", Offset = "0x80CB3A0", VA = "0x1880CBFA0", Slot = "10")]
	public void HOGBDFLBJKB(NGOKGPAMFGH IMCDPIHCLGL, Texture2D IOFLDLKHGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690")]
	public static bool MHCBHBGDFGL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x80CAF20", Offset = "0x80CA320", VA = "0x1880CAF20", Slot = "11")]
	public bool GEEFDEGDCBI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x80CA340", Offset = "0x80C9740", VA = "0x1880CA340", Slot = "9")]
	public void FEBHBPCBCFF(JEBPJLFOHBK AHEDBNJBENB, Color? IFBOGFLAOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x80CA070", Offset = "0x80C9470", VA = "0x1880CA070")]
	private void EDOHOLBNDKO(Action PFDCMBLJCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x80D3090", Offset = "0x80D2490", VA = "0x1880D3090", Slot = "6")]
	public void PKNAFMBCKFM(CDGCPFKIDBL KMJNEFBCKCG, Texture IAEAEAEPEPG, Color AONMLKNCKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x135D9C0", Offset = "0x135CDC0", VA = "0x18135D9C0", Slot = "7")]
	public void MHCAECBGHLP(bool LLLKJNKCIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1B95BF0", Offset = "0x1B94FF0", VA = "0x181B95BF0", Slot = "8")]
	public void DMECIIPKNEO(EGOGGADCJBA FGEMBJJOPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x80CCEE0", Offset = "0x80CC2E0", VA = "0x1880CCEE0", Slot = "16")]
	public void JMKKMHLEPLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x80D1210", Offset = "0x80D0610", VA = "0x1880D1210", Slot = "36")]
	public void MDNMMMALGON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x80D03C0", Offset = "0x80CF7C0", VA = "0x1880D03C0", Slot = "37")]
	public void MBLKCPNCFFM([Optional] CHMLELHGCGH MAGHBHCOCFM, [Optional] bool? EDKGHGGBDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x80CDDA0", Offset = "0x80CD1A0", VA = "0x1880CDDA0")]
	private bool KJEFJPACFGC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x80D1900", Offset = "0x80D0D00", VA = "0x1880D1900", Slot = "21")]
	public bool NELENHGNLOA(LFDPDKBANDC.JGFNEKKJIOP EHENGOJIJNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x80D1390", Offset = "0x80D0790", VA = "0x1880D1390", Slot = "39")]
	public void MFMOFEGIMLN(float NOOKPLOHLON, Color IFBOGFLAOGG, bool GJDBEIGBLBC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x80D1A30", Offset = "0x80D0E30", VA = "0x1880D1A30")]
	public void NJFMNOFJBHJ(float NOOKPLOHLON, Color IFBOGFLAOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x80CCC80", Offset = "0x80CC080", VA = "0x1880CCC80")]
	private static bool JEGIEGEGJAP(Material LIIDNHAOGFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x80CAD70", Offset = "0x80CA170", VA = "0x1880CAD70", Slot = "40")]
	public void FLAFNFDOLKI(FIDJIHIFKOK OHBODHECODK, FNEOCLHOLKI JEIHCHMDFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x80C7F10", Offset = "0x80C7310", VA = "0x1880C7F10")]
	private static bool CBJCACGGLJF(AKNJMIMOAHN PEENICAIFOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x80C6E30", Offset = "0x80C6230", VA = "0x1880C6E30")]
	public void AJEHMLOIKLE(FIDJIHIFKOK DHABAAMAECG, FNEOCLHOLKI JLEHIJFEMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x80CE110", Offset = "0x80CD510", VA = "0x1880CE110", Slot = "38")]
	public void KPFGICNBMOG(bool MBHBJCGIHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x80C7400", Offset = "0x80C6800", VA = "0x1880C7400")]
	private void BDNLNDGOGHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x80C72B0", Offset = "0x80C66B0", VA = "0x1880C72B0")]
	private void BBCJONAGNFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x80D1EA0", Offset = "0x80D12A0", VA = "0x1880D1EA0")]
	private static void NKGLANLAKCJ(Dictionary<AKNJMIMOAHN, Material> BNGCKMHEMKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x80D2920", Offset = "0x80D1D20", VA = "0x1880D2920")]
	private static void OMHJOLEGFLI(Dictionary<Renderer, CPAAGOKGAKE> ODJHDMIHECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x80D1270", Offset = "0x80D0670", VA = "0x1880D1270")]
	private void MFDFFADEPFM(SkinnedMeshRenderer[] DINJJCDOOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x80C79D0", Offset = "0x80C6DD0", VA = "0x1880C79D0")]
	private void BLFKKMPPJHP(SkinnedMeshRenderer HIFHHFKLDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x80C9400", Offset = "0x80C8800", VA = "0x1880C9400")]
	private void DCEOLNLLIEO(List<BFNEHIJGJBB> FKFEPKICEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x80CB620", Offset = "0x80CAA20", VA = "0x1880CB620")]
	private void HDNPJOMBPGG(Dictionary<string, JAKNEJKGEIC<Texture2D>> FKMIOCNPCCJ, bool KCFMPCDBKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x80CD150", Offset = "0x80CC550", VA = "0x1880CD150")]
	private void KAJIKEDHEIM(Dictionary<string, List<AKNJMIMOAHN>> FKMIOCNPCCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x80C6CE0", Offset = "0x80C60E0", VA = "0x1880C6CE0")]
	private void AJDFDDAIHMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x80C6190", Offset = "0x80C5590", VA = "0x1880C6190")]
	private void ACNAPFMIBLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x80C6340", Offset = "0x80C5740", VA = "0x1880C6340")]
	private void AFMPEODDNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x80D2A80", Offset = "0x80D1E80", VA = "0x1880D2A80")]
	private void ONPBPHPAHNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x80CE4F0", Offset = "0x80CD8F0", VA = "0x1880CE4F0")]
	private void LFEDEMNFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x80CBCD0", Offset = "0x80CB0D0", VA = "0x1880CBCD0")]
	private void HHPCHLIJNPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x80CE650", Offset = "0x80CDA50", VA = "0x1880CE650")]
	private void LMDDOJMOGJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x80D1DC0", Offset = "0x80D11C0", VA = "0x1880D1DC0")]
	private void NKAPIAKDLFD(bool FBEKAHOBJCP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x80CE2D0", Offset = "0x80CD6D0", VA = "0x1880CE2D0")]
	private void LCGEAAIMHAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x80C7D30", Offset = "0x80C7130", VA = "0x1880C7D30")]
	private void BNGKADOMBHE(bool FBEKAHOBJCP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x80D1590", Offset = "0x80D0990", VA = "0x1880D1590")]
	private void NALIDAMFNBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x80CC1A0", Offset = "0x80CB5A0", VA = "0x1880CC1A0")]
	private void HPFBJAFMDEJ(Material LIIDNHAOGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x80C7BB0", Offset = "0x80C6FB0", VA = "0x1880C7BB0")]
	private void BNDKJDKHCAB(Material LIIDNHAOGFE, Color PADLNNENHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x80C7050", Offset = "0x80C6450", VA = "0x1880C7050")]
	private void AMAMHFBDIHO(Material LIIDNHAOGFE, Color PADLNNENHPL, Color JCPGEKKGHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x80CB360", Offset = "0x80CA760", VA = "0x1880CB360")]
	private void GOJBGDMHKOL(Material LIIDNHAOGFE, Color JCOIDDADMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x80CA150", Offset = "0x80C9550", VA = "0x1880CA150")]
	private void EEMPMLIJMPN(Material LIIDNHAOGFE, Texture2D IOFLDLKHGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x80CB1A0", Offset = "0x80CA5A0", VA = "0x1880CB1A0")]
	private void GMDAGAJDDBA(Material LIIDNHAOGFE, Texture DJPLIJIACPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x80CBB70", Offset = "0x80CAF70", VA = "0x1880CBB70")]
	private void HHHAGDBJKOF(Action<CPAAGOKGAKE> HGMOFNOAGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x80CABF0", Offset = "0x80C9FF0", VA = "0x1880CABF0")]
	private void FHIHLPCKDLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x80CA740", Offset = "0x80C9B40", VA = "0x1880CA740")]
	private void FGFEJANKGGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x80CB7A0", Offset = "0x80CABA0", VA = "0x1880CB7A0")]
	private void HEOJIICGMIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x80C9A90", Offset = "0x80C8E90", VA = "0x1880C9A90")]
	public void EBGMELNOCEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x80C7E10", Offset = "0x80C7210", VA = "0x1880C7E10", Slot = "4")]
	private void JDPOCBFBEEA([In] FCFKKMOBKPH FILLPKCHMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x80C7FC0", Offset = "0x80C73C0", VA = "0x1880C7FC0")]
	[CompilerGenerated]
	private IHCAHILICGC CIFOHCGOBJA(GLHCJMPCBPP AOECCAAAEOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x80CAB60", Offset = "0x80C9F60", VA = "0x1880CAB60")]
	[CompilerGenerated]
	private void FGNADNIMNHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x80CB5F0", Offset = "0x80CA9F0", VA = "0x1880CB5F0")]
	[CompilerGenerated]
	private void HCILBKKAKAE(CPAAGOKGAKE AFODJKLPGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x80C7F30", Offset = "0x80C7330", VA = "0x1880C7F30")]
	[CompilerGenerated]
	private void CEHMEFKBDEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x80CB340", Offset = "0x80CA740", VA = "0x1880CB340")]
	[CompilerGenerated]
	private void GOEDDKNNCON(CPAAGOKGAKE AFODJKLPGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x80CE580", Offset = "0x80CD980", VA = "0x1880CE580")]
	[CompilerGenerated]
	private void LIPLDJHGMDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x80D2B80", Offset = "0x80D1F80", VA = "0x1880D2B80")]
	[CompilerGenerated]
	private void OPENOLAPNFI(CPAAGOKGAKE AFODJKLPGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x80D2750", Offset = "0x80D1B50", VA = "0x1880D2750")]
	[CompilerGenerated]
	private void ODFFJGMKNKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x80D28C0", Offset = "0x80D1CC0", VA = "0x1880D28C0")]
	[CompilerGenerated]
	private void OJKLHOMKMKA(CPAAGOKGAKE AFODJKLPGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x80D26C0", Offset = "0x80D1AC0", VA = "0x1880D26C0")]
	[CompilerGenerated]
	private void OCLALJKPIGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x80CCC50", Offset = "0x80CC050", VA = "0x1880CCC50")]
	[CompilerGenerated]
	private void JBJJDJCGPFC(CPAAGOKGAKE AFODJKLPGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x80CE240", Offset = "0x80CD640", VA = "0x1880CE240")]
	[CompilerGenerated]
	private void LAODOJFBAPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x80CE610", Offset = "0x80CDA10", VA = "0x1880CE610")]
	[CompilerGenerated]
	private void LJEPKOLLKCF(CPAAGOKGAKE AFODJKLPGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x80CC910", Offset = "0x80CBD10", VA = "0x1880CC910")]
	[CompilerGenerated]
	private void ILCFDJMLCHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x80D28F0", Offset = "0x80D1CF0", VA = "0x1880D28F0")]
	[CompilerGenerated]
	private void OKMKAAPCELG(CPAAGOKGAKE AFODJKLPGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x80D2BA0", Offset = "0x80D1FA0", VA = "0x1880D2BA0")]
	[CompilerGenerated]
	private void OPPEMPDHJJI(KeyValuePair<string, JAKNEJKGEIC<Texture2D>> AOJEPEFJCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x80CC6A0", Offset = "0x80CBAA0", VA = "0x1880CC6A0")]
	[CompilerGenerated]
	private void IKHODNNDBNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x80CB0A0", Offset = "0x80CA4A0", VA = "0x1880CB0A0")]
	[CompilerGenerated]
	private void GFBHHNMBCNM(CPAAGOKGAKE AFODJKLPGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x80C72A0", Offset = "0x80C66A0", VA = "0x1880C72A0")]
	[CompilerGenerated]
	private void ANKGFLBHJAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x80CB310", Offset = "0x80CA710", VA = "0x1880CB310")]
	[CompilerGenerated]
	private void GMOJGGNGHLF(CPAAGOKGAKE AFODJKLPGHF)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarElbowBendHelperController : MonoBehaviour, PJBHBAKDOAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		[FormerlySerializedAs("MinScaleValues")]
		[Header("Scale")]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[FormerlySerializedAs("MaxScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[Header("Positional Offset")]
		[SerializeField]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private Vector3? NDCABKBADNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private bool GILDECDMPKA;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x80DBF80", Offset = "0x80DB380", VA = "0x1880DBF80", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x80DC5B0", Offset = "0x80DB9B0", VA = "0x1880DC5B0", Slot = "4")]
		public void UpdateController(float HBFJOJKDNMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xD59740", Offset = "0xD58B40", VA = "0x180D59740", Slot = "6")]
		public void SetEnabled(bool CBMEHPPMEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x80DC060", Offset = "0x80DB460", VA = "0x1880DC060")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x80DC9D0", Offset = "0x80DBDD0", VA = "0x1880DC9D0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AvatarElbowBendTargetController : MonoBehaviour, PJBHBAKDOAN
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private const float EFNMAJLAHCD = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[SerializeField]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private Vector3 EJAAEFGMHFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private Vector3 DHLLAAMGHKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private bool GILDECDMPKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private float EFMDFPMHIJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private float JENOMABKPNH;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x80DCD50", Offset = "0x80DC150", VA = "0x1880DCD50", Slot = "4")]
		public void UpdateController(float HBFJOJKDNMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xFD7F10", Offset = "0xFD7310", VA = "0x180FD7F10", Slot = "6")]
		public void SetEnabled(bool CBMEHPPMEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x80DCA70", Offset = "0x80DBE70", VA = "0x1880DCA70")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x80DD810", Offset = "0x80DCC10", VA = "0x1880DD810")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class GMMJPMBNBJB : JMOFGJBGKPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private static readonly int PNEFMJLBNAJ;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private static readonly int FJHOACILCEO;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static readonly int AAHLAFICHJE;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private static readonly int EOFJJBNHMGO;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private static readonly int KMAFJAEHHJL;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private static readonly int CKGOAGIJALD;

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private static readonly int AFFKEMALNPH;

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private static readonly int GGFOCHDBOMH;

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private static readonly int MEGDNLHDJFI;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private static readonly int EKGGIBPMPKC;

	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private static readonly int MBIOMLNPDNB;

	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private static readonly int PPECFEEIEDA;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private static readonly int BBHKJMAGCKE;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private static readonly int EEOLCMHKBKO;

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private static readonly int EKJFNDDNOOA;

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static readonly int APMENOJOJGI;

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private static readonly int CAEPGOKBAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private Transform ILMBLIHFIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private Transform KHCDLJJCFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private Transform KDJNPLEJEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private Transform HGNPJBFIGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private Transform KHGKADNHCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private Transform CDKDCAJHEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private IOBKJIAIMIK NLNDMJGILNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private Material ELGJNLGOGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private SkinnedMeshRenderer[] FNINABEPIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly List<Material> IKFGHKGGANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private NCCBPEFIFKO DHMAAGFLOPK;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public OFFOKCJIMNI MFEIFINMCGL
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private NCCBPEFIFKO BNNJCPGAGDP
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x80E9260", Offset = "0x80E8660", VA = "0x1880E9260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool OEKNIBMILKH
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x80E81D0", Offset = "0x80E75D0", VA = "0x1880E81D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x80E9820", Offset = "0x80E8C20", VA = "0x1880E9820")]
	public void PJOFCLDPLJB([In] IOBKJIAIMIK NLMAPNKKCIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x80E7D60", Offset = "0x80E7160", VA = "0x1880E7D60")]
	public void KBDBMJPBHHE([In] JOAJBOLBEMK KACAMOGEMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x80E92F0", Offset = "0x80E86F0", VA = "0x1880E92F0", Slot = "6")]
	public void PAIEGKKHPMF(OMOCNCIMDHD JENEIECIGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x80E7D00", Offset = "0x80E7100", VA = "0x1880E7D00")]
	private Vector2 IDGJMGJCDDF(Vector2 BLJPEIALDAA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x80E8320", Offset = "0x80E7720", VA = "0x1880E8320")]
	public void MCFFOAOOFJA([In] BJMJOCJJGEP KACAMOGEMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x80E7E00", Offset = "0x80E7200", VA = "0x1880E7E00")]
	private void KIHDHFLDANA(JJGKAGODKLP DAJDLHGFFDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x80E7900", Offset = "0x80E6D00", VA = "0x1880E7900")]
	private void BKELIIKCOGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x80E7C90", Offset = "0x80E7090", VA = "0x1880E7C90")]
	private void HHKEBBMLNDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x80E7C90", Offset = "0x80E7090", VA = "0x1880E7C90", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x80E9CD0", Offset = "0x80E90D0", VA = "0x1880E9CD0")]
	public GMMJPMBNBJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x80E7D60", Offset = "0x80E7160", VA = "0x1880E7D60", Slot = "5")]
	private void NGFPIADGGPO([In] JOAJBOLBEMK KACAMOGEMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x80E9210", Offset = "0x80E8610", VA = "0x1880E9210", Slot = "7")]
	private void MFPBHOLBMDN([In] BJMJOCJJGEP KACAMOGEMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x80E92E0", Offset = "0x80E86E0", VA = "0x1880E92E0")]
	[CompilerGenerated]
	internal static float OKJAHIDCLMN(float CBMEHPPMEEA, float PCBCGPHLMFJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x80E98D0", Offset = "0x80E8CD0", VA = "0x1880E98D0")]
	[CompilerGenerated]
	internal static void PNOMKDIICPF(Vector2 ALEAEKJGEAE, Vector2 MFFMDLEEDAC, Vector2 MPDDFCCPIOM, Vector2 FELPICHHHLC, Vector2 IDCCLFDFCEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x80E9220", Offset = "0x80E8620", VA = "0x1880E9220")]
	[CompilerGenerated]
	internal static Vector4 NDJNELPJDGB(Vector2 LBCFHLNAPLC, Vector2 MJHAIBCGLLD)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class AvatarForearmRollController : MonoBehaviour, PJBHBAKDOAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private float EFMDFPMHIJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private bool GILDECDMPKA;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x80DD840", Offset = "0x80DCC40", VA = "0x1880DD840", Slot = "4")]
		public void UpdateController(float HBFJOJKDNMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x1022460", Offset = "0x1021860", VA = "0x181022460", Slot = "6")]
		public void SetEnabled(bool CBMEHPPMEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x80DE0B0", Offset = "0x80DD4B0", VA = "0x1880DE0B0")]
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
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x80DE150", Offset = "0x80DD550", VA = "0x1880DE150")]
		public void IPJPKJAMFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x80DE0E0", Offset = "0x80DD4E0", VA = "0x1880DE0E0")]
		public int DBFMDHDIGAO(int NGLOBNNAOKG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class CCIDKAHJCID : JFKBCOEDIJL
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x80E0E60", Offset = "0x80E0260", VA = "0x1880E0E60", Slot = "24")]
	public override float ILCOHEBNIDA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x80E0EB0", Offset = "0x80E02B0", VA = "0x1880E0EB0")]
	public CCIDKAHJCID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class JFKBCOEDIJL : JHCCFFGGMLF
{
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private static int DCMGMAEPOPI;

	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private static int ANHPEKAFALA;

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private static int DFCCKMBPFEK;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private static int FAJPACEDPOB;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static int HPCAKLLGLIK;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static int KANPIDMJAPB;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private static int HNLGPFJBOFN;

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static int[] CGDCCLHNIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private PJCPNEGKKCO NLNDMJGILNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private KIOLDBOCMFK CCBODGJLIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private int EJELFCPBOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private float DCLOKAAABBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	protected Animator NMLHHLODJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	protected AvatarConfiguration BFJABBJBDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	protected int MIABBEMKJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private int COPFDEBJPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private int HGFBMEKMDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private bool HLCAIPDKPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private NEMBFNBHOJF KOPEONAFKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int LFJINPFEJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private float IIAGJEMOOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private AvatarHandDisplaySettings OHMPJDBNJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private AGMMOBNOCAG OHFKCGGNDLB;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform DCMJDCJDNMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Vector3 DLNFHIFPKDI
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1954FF0", Offset = "0x19543F0", VA = "0x181954FF0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1954D00", Offset = "0x1954100", VA = "0x181954D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Quaternion CNKEMHLLOLN
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xE6F720", Offset = "0xE6EB20", VA = "0x180E6F720")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x1060CC0", Offset = "0x10600C0", VA = "0x181060CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool KHFPGAKPDBP
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x80EBF60", Offset = "0x80EB360", VA = "0x1880EBF60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x80EBB40", Offset = "0x80EAF40", VA = "0x1880EBB40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool LDKPNCFODJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xAD90F0", Offset = "0xAD84F0", VA = "0x180AD90F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Vector3 EKGCOJIEEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA9B000", Offset = "0xA9A400", VA = "0x180A9B000", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA9B090", Offset = "0xA9A490", VA = "0x180A9B090")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Quaternion JNCICMAMLNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x1246810", Offset = "0x1245C10", VA = "0x181246810", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x16D2EA0", Offset = "0x16D22A0", VA = "0x1816D2EA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IFJFNEIBCED NINEGEMHLCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xB10760", Offset = "0xB0FB60", VA = "0x180B10760", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return default(IFJFNEIBCED);
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xB10440", Offset = "0xB0F840", VA = "0x180B10440", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public IFJFNEIBCED DEPFDLHKIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xB10750", Offset = "0xB0FB50", VA = "0x180B10750", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(IFJFNEIBCED);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xB10450", Offset = "0xB0F850", VA = "0x180B10450", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float EDHKAHEEJAD
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xBD56A0", Offset = "0xBD4AA0", VA = "0x180BD56A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1073B30", Offset = "0x1072F30", VA = "0x181073B30", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool NGCFMCHLNKD
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x80EBB80", Offset = "0x80EAF80", VA = "0x1880EBB80", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x80EBF00", Offset = "0x80EB300", VA = "0x1880EBF00", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool AMNADHANBDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x80EBB70", Offset = "0x80EAF70", VA = "0x1880EBB70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool DCHBDJLEJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x80EB960", Offset = "0x80EAD60", VA = "0x1880EB960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool HNIFPPGPMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x80EBB10", Offset = "0x80EAF10", VA = "0x1880EBB10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool OMMFOAKCFBI
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x80EB970", Offset = "0x80EAD70", VA = "0x1880EB970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x80EBFF0", Offset = "0x80EB3F0", VA = "0x1880EBFF0", Slot = "23")]
	public void PJOFCLDPLJB(PJCPNEGKKCO NLMAPNKKCIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x80EBF90", Offset = "0x80EB390", VA = "0x1880EBF90")]
	public void NIHIKIEAIIH(KIOLDBOCMFK GBBGGABPHJI, AvatarHandDisplaySettings FKBCJNJEHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x80EB8D0", Offset = "0x80EACD0", VA = "0x1880EB8D0", Slot = "14")]
	public void FGJHLDFADEO(bool MOELHOCKLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x80EBB90", Offset = "0x80EAF90", VA = "0x1880EBB90", Slot = "13")]
	public void JPHDMDHPIII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0xBD56A0", Offset = "0xBD4AA0", VA = "0x180BD56A0", Slot = "24")]
	public virtual float ILCOHEBNIDA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x80EB980", Offset = "0x80EAD80", VA = "0x1880EB980")]
	private int GFAHOCHPOMJ(IFJFNEIBCED HPKLOAFPFED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x80EB650", Offset = "0x80EAA50", VA = "0x1880EB650")]
	private void ANKGPAECGMO(int EFAFCAIAEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x80EB810", Offset = "0x80EAC10", VA = "0x1880EB810", Slot = "15")]
	public bool BCKLIANIKFH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x80EBFE0", Offset = "0x80EB3E0", VA = "0x1880EBFE0", Slot = "16")]
	public bool NNIINNBNHPK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x80EBF10", Offset = "0x80EB310", VA = "0x1880EBF10")]
	private IFJFNEIBCED MNHLGOFKDMG()
	{
		return default(IFJFNEIBCED);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x1ED30C0", Offset = "0x1ED24C0", VA = "0x181ED30C0", Slot = "17")]
	public void HFKOADJEJLK(bool MOELHOCKLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x80EB830", Offset = "0x80EAC30", VA = "0x1880EB830", Slot = "12")]
	public void CBALKONOCOM(int EFAFCAIAEHO, float LKCMADJHOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x80EBB20", Offset = "0x80EAF20", VA = "0x1880EBB20", Slot = "10")]
	public void HJIMICILEIJ(NEMBFNBHOJF JPDKKKJJNLC, bool BAMGENIDGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x80EB870", Offset = "0x80EAC70", VA = "0x1880EB870", Slot = "11")]
	public void EIJDJKCJFLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x80EB880", Offset = "0x80EAC80", VA = "0x1880EB880", Slot = "18")]
	public void ELDAKGKEFJK(Transform JIECBJMGMAC, Vector3 PGMGEEDJNJE, Quaternion GDEKMAMJGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x80EC460", Offset = "0x80EB860", VA = "0x1880EC460")]
	public JFKBCOEDIJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class HCGHDLGGKGG : GLHCJMPCBPP
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class CKLBJOKFMGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public HCGHDLGGKGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public List<BFNEHIJGJBB> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public List<BFNEHIJGJBB> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public JAKNEJKGEIC<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public JAKNEJKGEIC<KJNEMKMFKEL> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public CKLBJOKFMGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x80E0F10", Offset = "0x80E0310", VA = "0x1880E0F10")]
		internal IHCAHILICGC DKBLJPPMMCM(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public CDGCPFKIDBL GGNJOAODPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public KJNEMKMFKEL PBIIMMKPHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private JAKNEJKGEIC<KJNEMKMFKEL> NHPNCOBGFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private JAKNEJKGEIC<Material[]> EABBNNIMLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public Material[] OHMHBHLFHOA;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool IHJFOCNDIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA9C690", Offset = "0xA9BA90", VA = "0x180A9C690")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xA9C410", Offset = "0xA9B810", VA = "0x180A9C410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public LFDPDKBANDC.JGFNEKKJIOP NIPJGCEEHEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return default(LFDPDKBANDC.JGFNEKKJIOP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xA7B820", Offset = "0xA7AC20", VA = "0x180A7B820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x80EB1E0", Offset = "0x80EA5E0", VA = "0x1880EB1E0")]
	public HCGHDLGGKGG(KMPAOABCDOI KDFKOMLMMNN, CDGCPFKIDBL GBPICEEEFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x80EA9F0", Offset = "0x80E9DF0", VA = "0x1880EA9F0", Slot = "6")]
	public override IHCAHILICGC OJFNGCINBDI(List<BFNEHIJGJBB> LGJMKIMJNHG, List<BFNEHIJGJBB> LAJCJDDBONB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x80E9F40", Offset = "0x80E9340", VA = "0x1880E9F40")]
	public IHCAHILICGC MAAGAAAILLH(List<BFNEHIJGJBB> LGJMKIMJNHG, List<BFNEHIJGJBB> LAJCJDDBONB, JAKNEJKGEIC<Material[]> EABBNNIMLND, [Optional] JAKNEJKGEIC<KJNEMKMFKEL> BODMDIAFBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x80EA5E0", Offset = "0x80E99E0", VA = "0x1880EA5E0")]
	public (JAKNEJKGEIC<Material[]>, JAKNEJKGEIC<KJNEMKMFKEL>) NKLKIJPLCPD(List<BFNEHIJGJBB> LGJMKIMJNHG, List<BFNEHIJGJBB> LAJCJDDBONB)
	{
		return default((JAKNEJKGEIC<Material[]>, JAKNEJKGEIC<KJNEMKMFKEL>));
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x80E9E10", Offset = "0x80E9210", VA = "0x1880E9E10", Slot = "7")]
	public override EHGGGJCIAMB LPGMHHDFHEI(uint BFGBMBMPPGG, AvatarSkinnedMeshBoneOrderRemapsData OOBADMGOJOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x80EAEB0", Offset = "0x80EA2B0", VA = "0x1880EAEB0")]
	public EHGGGJCIAMB PEINNHEGHIM(GameObject PJBJIEFCCLG, uint BFGBMBMPPGG, bool DJBBDNICDMP, bool HCIMFGBCGHD, AvatarSkinnedMeshBoneOrderRemapsData OOBADMGOJOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x80EA250", Offset = "0x80E9650", VA = "0x1880EA250")]
	public static bool MLJGHCIHGEB(Renderer[] DINJJCDOOFK, string GIFFCPLODHN, [Out] Renderer IPPNEFJEGLF, [Out] Renderer HOLIAIDIMFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x80EB190", Offset = "0x80EA590", VA = "0x1880EB190", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x80EB0C0", Offset = "0x80EA4C0", VA = "0x1880EB0C0")]
	private (JAKNEJKGEIC<KJNEMKMFKEL>, JAKNEJKGEIC<Material[]>) PHKPIGJFEGL()
	{
		return default((JAKNEJKGEIC<KJNEMKMFKEL>, JAKNEJKGEIC<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x80EA5C0", Offset = "0x80E99C0", VA = "0x1880EA5C0")]
	[CompilerGenerated]
	private void NHGKEFEEHOP(KJNEMKMFKEL HJBCDFKDKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0xA74020", Offset = "0xA73420", VA = "0x180A74020")]
	[CompilerGenerated]
	private void AIPMMDFGOGH(Material[] HJBCDFKDKBA)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class AvatarKneeBendTargetController : MonoBehaviour, PJBHBAKDOAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
		[SerializeField]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private Vector3 EJAAEFGMHFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private Vector3 MAEFDIJPDBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private Vector3 KMCGNNBICOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private Matrix4x4 GAIGHFIBMAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private bool GILDECDMPKA;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x80DE6E0", Offset = "0x80DDAE0", VA = "0x1880DE6E0", Slot = "4")]
		public void UpdateController(float HBFJOJKDNMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x80DE6D0", Offset = "0x80DDAD0", VA = "0x1880DE6D0", Slot = "6")]
		public void SetEnabled(bool CBMEHPPMEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x80DE270", Offset = "0x80DD670", VA = "0x1880DE270")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x80DEDA0", Offset = "0x80DE1A0", VA = "0x1880DEDA0")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[EAFHNCFGKJO]
public struct AOPGFMEBCAL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	[ReadOnly]
	public GJMMOOLGJDB FIEJCGAIMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	[ReadOnly]
	public int JILDJBAHNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public NKCHLEKKLDL ALFDGMCAONI;

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x80DB000", Offset = "0x80DA400", VA = "0x1880DB000", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[EAFHNCFGKJO]
[NativeContainer]
public struct NKCHLEKKLDL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<Vector3> KMEHJPNNNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<Vector3> FPBLMJNFMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<Vector4> BAAJHGLBFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeArray<Vector2> FCHNAMJMMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeArray<Vector2> DACPKKOBPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public NativeArray<Vector2> BNNPHDFIDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeArray<Vector2> FLMMJKJPCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<Color> HIGGHLLLHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<int> BIIADHNKNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeArray<int> POMAHLHNAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private NativeArray<int> GMFAGGFKNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private NativeArray<int> CEAIGHMHKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeArray<int> NHCJENGPIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeArray<int> CPMJGDABEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeArray<int> NBLILMAPKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeArray<BoneWeight> PHGAPHHLIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private NativeArray<int> FGEMBJJOPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private bool FCEPOLLEEIA;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int PHOMHPCMHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x80EE220", Offset = "0x80ED620", VA = "0x1880EE220")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x80EE230", Offset = "0x80ED630", VA = "0x1880EE230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int OKAPEBJBECD
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x80EDCD0", Offset = "0x80ED0D0", VA = "0x1880EDCD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x80EE6E0", Offset = "0x80EDAE0", VA = "0x1880EE6E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int DPCJEOAINOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x80EDCE0", Offset = "0x80ED0E0", VA = "0x1880EDCE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x80EE600", Offset = "0x80EDA00", VA = "0x1880EE600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x80EE720", Offset = "0x80EDB20", VA = "0x1880EE720")]
	public NKCHLEKKLDL(int GEDMNCMFHME, int OCDMMPIHHKO, int GNLJNMHMGDB, int AIDLAPOIBBA, Allocator KCEIEKBPKNP, int NPIGLOCJFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x80EE240", Offset = "0x80ED640", VA = "0x1880EE240")]
	public void MBGCBOCDKAI(int NOEININIMIL, Vector3 EMOJJIEJAKM, Vector3 FFIGKKPMMAC, Vector4 DBAMLJDDEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x80EDFB0", Offset = "0x80ED3B0", VA = "0x1880EDFB0")]
	public void INIBEMGFGDJ(int NOEININIMIL, BoneWeight LKAADODHMPP, NativeSlice<byte> FACLODLGKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x80EDDD0", Offset = "0x80ED1D0", VA = "0x1880EDDD0")]
	public Color BOCMEAALLJH(int NOEININIMIL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x80EE150", Offset = "0x80ED550", VA = "0x1880EE150")]
	public void JDDMKGNIPIG(int NOEININIMIL, Color CHNNNFLKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x80EDCF0", Offset = "0x80ED0F0", VA = "0x1880EDCF0")]
	public void BGCOOLMIABP(byte GMOCENPLJAO, int NOEININIMIL, Vector2 JECEDNFCAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x80EDFA0", Offset = "0x80ED3A0", VA = "0x1880EDFA0")]
	public void EFBMOBNHPJC(int NOEININIMIL, int KMNLHHNFMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x80EE6F0", Offset = "0x80EDAF0", VA = "0x1880EE6F0")]
	public bool ONDPEHIFIFJ(int GMOCENPLJAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x80EE610", Offset = "0x80EDA10", VA = "0x1880EE610")]
	public void OEBHDGGDFLK(int BEFOADGEAGO, int FDIDNNCIDHK, int COONBEDHJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x80EE170", Offset = "0x80ED570", VA = "0x1880EE170")]
	public int[] JJLEKKOKGAG(int BEFOADGEAGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x80EDD40", Offset = "0x80ED140", VA = "0x1880EDD40")]
	private NativeSlice<int> BGMDMNLGKIA(int BEFOADGEAGO)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x80EDDF0", Offset = "0x80ED1F0", VA = "0x1880EDDF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x80EE2B0", Offset = "0x80ED6B0", VA = "0x1880EE2B0")]
	public Mesh NJOGLGIOIDJ([Optional] string OODHDKLMIHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[DefaultMember("Item")]
[EAFHNCFGKJO]
[NativeContainer]
public struct GJMMOOLGJDB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeArray<Vector3> KMEHJPNNNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public NativeArray<Vector3> FPBLMJNFMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public NativeArray<Vector4> BAAJHGLBFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeArray<Vector2> FCHNAMJMMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public NativeArray<Vector2> DACPKKOBPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public NativeArray<Vector2> BNNPHDFIDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public NativeArray<Vector2> FLMMJKJPCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public NativeArray<Color> HIGGHLLLHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public NativeArray<int> PPGCLOFIJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public NativeArray<int> KCOOKLHFAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public NativeArray<int> GPCPOIIDJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public NativeArray<int> ANEKNJJHIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public NativeArray<bool> FPBACDLKLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public NativeArray<int> PAIDIFCDDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public NativeArray<int> AIBENPPJNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public NativeArray<BoneWeight> FPELBFGJADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private NativeArray<Matrix4x4> MEFPHKNPNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private NativeArray<long> LMKANFIFGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private NativeArray<byte> OKECOHCGJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private NativeArray<int> BPEPJOJKMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private NativeArray<int> NMEHJLLJOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public NativeArray<sbyte> KGIFNFHJOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public NativeArray<byte> HJFDKODGHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private NativeArray<int> BCGNCNLBNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private bool FCEPOLLEEIA;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int IDEMELHNKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xEF5D70", Offset = "0xEF5170", VA = "0x180EF5D70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int PDEGINJEKPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xD5C6F0", Offset = "0xD5BAF0", VA = "0x180D5C6F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int JAJJBNGJHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x80E5EE0", Offset = "0x80E52E0", VA = "0x1880E5EE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int BAHEJGCKCNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x80E5EB0", Offset = "0x80E52B0", VA = "0x1880E5EB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x80E5EA0", Offset = "0x80E52A0", VA = "0x1880E5EA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int PHOMHPCMHPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x80E5EC0", Offset = "0x80E52C0", VA = "0x1880E5EC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x80E5F20", Offset = "0x80E5320", VA = "0x1880E5F20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int PKIEJBNGNGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x80E5F10", Offset = "0x80E5310", VA = "0x1880E5F10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x80E56E0", Offset = "0x80E4AE0", VA = "0x1880E56E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public NFFBEAMILGG DLDCBBOEEIN
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x80E6010", Offset = "0x80E5410", VA = "0x1880E6010")]
		get
		{
			return default(NFFBEAMILGG);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x80E6000", Offset = "0x80E5400", VA = "0x1880E6000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public byte JEEIPOGCFPA
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x80E5ED0", Offset = "0x80E52D0", VA = "0x1880E5ED0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x80E5960", Offset = "0x80E4D60", VA = "0x1880E5960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public BFIDKKKFJFH FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x80E5970", Offset = "0x80E4D70", VA = "0x1880E5970")]
		get
		{
			return default(BFIDKKKFJFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x80E6020", Offset = "0x80E5420", VA = "0x1880E6020")]
	public GJMMOOLGJDB(IList<Mesh> JKLIMNOCDJA, IList<Matrix4x4> HHCBABJEICB, IList<bool> FPBACDLKLDM, byte HLINDEAICCD, IList<byte[]> FEPCEAONAKP, IList<long> FDICPLNDCBN, IList<bool> LPGIKLLLIEC, IList<int> PAIDIFCDDEI, IList<int> AEJDOFBCFEA, IList<int> PHGAEDKMJJH, Allocator KCEIEKBPKNP, NFFBEAMILGG DBHGIIJIOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x80E5F30", Offset = "0x80E5330", VA = "0x1880E5F30")]
	public NKCHLEKKLDL MGJDNANBBCH(Allocator KCEIEKBPKNP)
	{
		return default(NKCHLEKKLDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x80E56F0", Offset = "0x80E4AF0", VA = "0x1880E56F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[EAFHNCFGKJO]
public class FGLKGPABPDA : GICAECAKNCM
{
	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x80E4FD0", Offset = "0x80E43D0", VA = "0x1880E4FD0")]
	public GJMMOOLGJDB FKHBAKLNBKM()
	{
		return default(GJMMOOLGJDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x80D62A0", Offset = "0x80D56A0", VA = "0x1880D62A0")]
	public FGLKGPABPDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct BFIDKKKFJFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public NativeSlice<Vector3> KMEHJPNNNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public NativeSlice<Vector3> FPBLMJNFMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public NativeSlice<Vector4> BAAJHGLBFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public NativeSlice<Vector2> FCHNAMJMMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public NativeSlice<Vector2> DACPKKOBPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public NativeSlice<Vector2> BNNPHDFIDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public NativeSlice<Vector2> FLMMJKJPCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public NativeSlice<Color> HIGGHLLLHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	public NativeSlice<int> AALOPAHBCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	public NativeSlice<int> ANEKNJJHIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public NativeSlice<BoneWeight> FPELBFGJADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public NativeSlice<byte> JFNJNIINMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public int NFACFOOABHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public Matrix4x4 DAHIABBNLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public long GCNKPMGHPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public NativeSlice<byte> FACLODLGKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public bool NINFMAEJDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public int BAMDHMKIAGP;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal readonly struct AKNJMIMOAHN : IEquatable<AKNJMIMOAHN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	internal readonly Material NOKPIKBDEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	internal readonly HOPHAMFEDGF EJHAIPFEDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	internal readonly PHHJIMPAPKF NEHMCGCINBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	internal readonly KMPAOABCDOI KCAKJCBNNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	internal readonly bool OGCKPBOEPBO;

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x80DAE80", Offset = "0x80DA280", VA = "0x1880DAE80")]
	public AKNJMIMOAHN(Material GMFBEMFEGJH, HOPHAMFEDGF LCKDFGPELPB, PHHJIMPAPKF AFMPOACCGLJ, KMPAOABCDOI FBBAOHEBJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x80DABE0", Offset = "0x80D9FE0", VA = "0x1880DABE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x80DAA40", Offset = "0x80D9E40", VA = "0x1880DAA40", Slot = "4")]
	public bool Equals(AKNJMIMOAHN LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x80DA940", Offset = "0x80D9D40", VA = "0x1880DA940", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x80DAAD0", Offset = "0x80D9ED0", VA = "0x1880DAAD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, JOEBNIKPFHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[Header("Configuration")]
		[SerializeField]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		[Header("Configuration")]
		private AGMMOBNOCAG avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private GameObject allBodyMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		[FormerlySerializedAs("BodyMaterial")]
		private Material BodyMaterialSkinGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		private Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private CNJDPLBKGCC NOIKBNBAKOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private JMOFGJBGKPC LIIALFFJOHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private JHCCFFGGMLF ACABEPPEDCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private JHCCFFGGMLF HIHHDHGBINA;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public CNJDPLBKGCC GFHEDLGOMCG
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x80DFDC0", Offset = "0x80DF1C0", VA = "0x1880DFDC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public JMOFGJBGKPC BHPNLPMDAGN
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x80DFE10", Offset = "0x80DF210", VA = "0x1880DFE10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public JHCCFFGGMLF PJHJKALHIJB
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x80DFE60", Offset = "0x80DF260", VA = "0x1880DFE60", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public JHCCFFGGMLF KAKAAOGDJJC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x80DFEB0", Offset = "0x80DF2B0", VA = "0x1880DFEB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Transform CJINGHMNOGO
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x80DFF00", Offset = "0x80DF300", VA = "0x1880DFF00", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public AGMMOBNOCAG BFNOIEAFADC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xA7BDA0", Offset = "0xA7B1A0", VA = "0x180A7BDA0", Slot = "12")]
			get
			{
				return default(AGMMOBNOCAG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x80DF150", Offset = "0x80DE550", VA = "0x1880DF150")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x80DF8E0", Offset = "0x80DECE0", VA = "0x1880DF8E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x80DF8A0", Offset = "0x80DECA0", VA = "0x1880DF8A0", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x80DF8E0", Offset = "0x80DECE0", VA = "0x1880DF8E0", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x80DF190", Offset = "0x80DE590", VA = "0x1880DF190", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x80DFCD0", Offset = "0x80DF0D0", VA = "0x1880DFCD0")]
		public void UpdatePostIKAnimControllers(float HBFJOJKDNMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x80DF580", Offset = "0x80DE980", VA = "0x1880DF580")]
		private void EALAEHOPFFC(GameObject DEJGDIIDCDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x80DEDB0", Offset = "0x80DE1B0", VA = "0x1880DEDB0")]
		private CNJDPLBKGCC ACDPKNIMADL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x80DF990", Offset = "0x80DED90", VA = "0x1880DF990")]
		private JMOFGJBGKPC PDNLMMINMJG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x80DF610", Offset = "0x80DEA10", VA = "0x1880DF610")]
		private JHCCFFGGMLF EBBLDNHDCKN(OIFJCNJMBMH AKFDIDELAAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x80DFDB0", Offset = "0x80DF1B0", VA = "0x1880DFDB0")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class CPAAGOKGAKE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private MaterialPropertyBlock HBNMIOCOANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public Color? FKJGNNJIFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public Color? GOOIJGPAPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public Color? CIPMFENDGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public Color? DLDLBLGAMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public Color HEKFJNINGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public Color BBIHFOLKOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public Color GAOLGCIPKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public float HMFDHPOHKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public Texture2D FNFLCFPJDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public Texture2D JCJOEGDDCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private Dictionary<AKNJMIMOAHN, int> FBOGEDHOCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private HOPHAMFEDGF[] KKOAAKBAPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private PHHJIMPAPKF[] LBDAMMBNPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public Vector4[] DECFNPCNNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public Vector4[] ELGINPENFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public Vector4[] HJOFGPGPPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public Vector4[] NPCJIFJPPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public Vector4[] DJDGDINAFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public Vector4[] HONHEFLNPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private List<Texture2D> FEINFMANNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private Vector4[] FDCOBCBAAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private List<Texture2D> IEFKMFGJOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private float[] CKLANJBLNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private Vector4[] DLJIDIFGOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private float[] LFIDHOMJKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public float[] AOLFOKDLLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private List<Texture2D> LPDFGACFIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private float[] NOKMLAFAHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private List<Texture2D> BNAFAOPLDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private Vector4[] PKPICAIMJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private float[] HAGCJMACHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private Vector4[] CLHFOEPAHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public float[] DHCCHBGECHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public Texture2DArray PKGIHMHKGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public Texture2DArray EOOFOLGFAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public Texture2DArray EGHJHLJKOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public Texture2DArray LIDDJLBFHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private bool PHEMMFAEGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private int PFBENPHKCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private Vector2? DPFHBAGEEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private TextureFormat DIJDFHIDGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private Vector2? BACNHJIENAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private TextureFormat GDMLBCKGMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private Vector2? POHDALAENLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private TextureFormat MKNIBFOPOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private Vector2? GKOHEFLAIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private TextureFormat KNDPIJGBNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private bool EGNOAKFAPLF;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private static int EADFHDLFMJM;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static int EBMMGDKFAFK;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private static int BABNHHADOCF;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private static int ABMMDELDFGM;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private static int KDBAGAPJIEH;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private static int OOFEMIDLEFJ;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private static int DILBENKMPJO;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private static int BHNKDMIOBKE;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	private static int PDMEKOBPNLF;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	private static int PDLLIFFMJIC;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	private static int MIHCGNBNBEH;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	private static int KMFLIJIFNMA;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private static int LKLGADNBLMC;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private static int JIPONCPJNBC;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private static int PNPGENPADGH;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	private static int OFAJJKDFGOA;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private static int COLJBEPNIIC;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	private static int IHABAKDFMBD;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private static int GHDEJAODEND;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private static int NGLCFNLIJDL;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x80E3880", Offset = "0x80E2C80", VA = "0x1880E3880")]
	private CPAAGOKGAKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x80E37C0", Offset = "0x80E2BC0", VA = "0x1880E37C0")]
	public CPAAGOKGAKE(Color KDLGBEPEAHI, Color AABFFNIAOCC, Color CMLGGNADMII, Color? AHPEJKHDOBK, Color? CGDAJFBPBJJ, Color? JJFKGGNMMMP, Texture2D PHLCHENNBCO, Texture2D NALAFJDCELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x80E2140", Offset = "0x80E1540", VA = "0x1880E2140")]
	internal int IAIJFEPGKIN(Material MGAKHFECEIL, HOPHAMFEDGF LCKDFGPELPB, PHHJIMPAPKF AFMPOACCGLJ, KMPAOABCDOI FBBAOHEBJDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x80E2210", Offset = "0x80E1610", VA = "0x1880E2210")]
	private int IAIJFEPGKIN(AKNJMIMOAHN PEENICAIFOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x80E2400", Offset = "0x80E1800", VA = "0x1880E2400")]
	internal int IFEACBPFBNF(Material MGAKHFECEIL, Color JCOIDDADMCN, Color FPFBFOIJFNO, Color IPLGMAFIILM, Color ABKLKFDFLGF, Color HCKKIIOECHE, Texture2D OBPNKPDIBPB, Vector4 PMFEJKGDPLH, Texture2D FGHNAKLDBDK, Vector4 NHAAFOKIHIJ, float OILGHDOICAC, float BEBIKOBJACI, Texture2D DKLPHCJIJNA, Vector4 OGPFOOAJNGL, float OIGIPOFCCED, Texture2D NGHKNIBKLIH, Color OPLMFPGAJNK, Vector4 HNIHGGEHMKG, HOPHAMFEDGF LCKDFGPELPB, PHHJIMPAPKF AFMPOACCGLJ, KMPAOABCDOI FBBAOHEBJDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x80E2FD0", Offset = "0x80E23D0", VA = "0x1880E2FD0")]
	private void JHLHLOKFJKG(List<Texture2D> FEINFMANNDB, [Out] Texture2DArray MBPBCAMLFDL, [Out] Texture2DArray EHAECOKINAF, [Out] Texture2DArray FBAPNMIDJOI, [Out] Texture2DArray DICGNLMJHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x80E3190", Offset = "0x80E2590", VA = "0x1880E3190")]
	public void KFGACHCJMFC(Shader KMJPAHJOKPB, Renderer FOGLHINMCEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x80E1400", Offset = "0x80E0800", VA = "0x1880E1400")]
	private void BMHPDJOIANF(Shader KMJPAHJOKPB, Renderer FOGLHINMCEC, int HDHMKOBIAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x80E1200", Offset = "0x80E0600", VA = "0x1880E1200")]
	private Color BBGGNPMEKDI(Color JPPLOFMJGPH, HOPHAMFEDGF AHEDBNJBENB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x80E32E0", Offset = "0x80E26E0", VA = "0x1880E32E0")]
	private Color MHGJAMFBCPJ(Color GACDOPDNCCC, HOPHAMFEDGF AHEDBNJBENB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x80E22A0", Offset = "0x80E16A0", VA = "0x1880E22A0")]
	private bool ICMCIDOFEDA(Texture2D IJIBLGKGOFF, PHHJIMPAPKF IMCDPIHCLGL, [Out] Texture2D DEOFCBPDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x80E1150", Offset = "0x80E0550", VA = "0x1880E1150")]
	private void AECHNKFPPMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x80E2100", Offset = "0x80E1500", VA = "0x1880E2100", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class GLHCJMPCBPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public readonly KMPAOABCDOI MNAFCLGNAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	protected bool KANPBMGFPGD;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool MGNNKBNOFFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xB32030", Offset = "0xB31430", VA = "0x180B32030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xB32040", Offset = "0xB31440", VA = "0x180B32040")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool PKJJKLGBMLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xB32050", Offset = "0xB31450", VA = "0x180B32050")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xB31FD0", Offset = "0xB313D0", VA = "0x180B31FD0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public virtual LFDPDKBANDC.JGFNEKKJIOP GCNKPMGHPCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(LFDPDKBANDC.JGFNEKKJIOP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xDC5670", Offset = "0xDC4A70", VA = "0x180DC5670", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool AEAGBPFLEFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x15552D0", Offset = "0x15546D0", VA = "0x1815552D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool MLIBBLBHAGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x80E7890", Offset = "0x80E6C90", VA = "0x1880E7890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool JKGKBCBHDPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x80E78A0", Offset = "0x80E6CA0", VA = "0x1880E78A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool IPIMOLILDCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x80E78B0", Offset = "0x80E6CB0", VA = "0x1880E78B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x80E78D0", Offset = "0x80E6CD0", VA = "0x1880E78D0")]
	protected GLHCJMPCBPP(KMPAOABCDOI KDFKOMLMMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract IHCAHILICGC OJFNGCINBDI(List<BFNEHIJGJBB> LGJMKIMJNHG, List<BFNEHIJGJBB> LAJCJDDBONB);

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract EHGGGJCIAMB LPGMHHDFHEI(uint BFGBMBMPPGG, AvatarSkinnedMeshBoneOrderRemapsData OOBADMGOJOK);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class PJDLEJEFOHE : NJMJGABCIHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private AvatarSkinAssetItem JPJGFBBDIHB;

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x80EFBE0", Offset = "0x80EEFE0", VA = "0x1880EFBE0")]
	public PJDLEJEFOHE(AvatarSkinAssetItem KADOFCKCHNJ, AvatarSkinAssetItem.GJHHMDCLBPF PDDFDMKKGKO, KMPAOABCDOI FBBAOHEBJDH, [Optional] KDMFEBNOJJL? OILDNKPENJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x80EF970", Offset = "0x80EED70", VA = "0x1880EF970", Slot = "6")]
	public override IHCAHILICGC OJFNGCINBDI(List<BFNEHIJGJBB> LGJMKIMJNHG, List<BFNEHIJGJBB> LAJCJDDBONB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class HFHKFOIHIGO
{
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private static readonly int[] BJNBJFPEHLP;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private static readonly int[] GIDCBFCIACI;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static int[] NBAGAPOBKDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x80EB390", Offset = "0x80EA790", VA = "0x1880EB390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x80EB250", Offset = "0x80EA650", VA = "0x1880EB250")]
	public static int[] DCJMCKEAAIA(bool MAGDBJFJKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x80EB300", Offset = "0x80EA700", VA = "0x1880EB300")]
	public static int GELKOOEKIIE(IEEJIDPBMPL IFNNDGOBPDA, bool MAGDBJFJKAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x80EB3E0", Offset = "0x80EA7E0", VA = "0x1880EB3E0")]
	private static int MLMCFOENOCA(IEEJIDPBMPL IFNNDGOBPDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x80EB2E0", Offset = "0x80EA6E0", VA = "0x1880EB2E0")]
	private static int FOLHIGABLIG(IEEJIDPBMPL IFNNDGOBPDA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class IGIKBBNCFJC
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class KFIOPEBCDEC : IEnumerator<KHJLACPAINM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private KHJLACPAINM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private KHJLACPAINM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
		[DebuggerHidden]
		public KFIOPEBCDEC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x14CB590", Offset = "0x14CA990", VA = "0x1814CB590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x80ED4B0", Offset = "0x80EC8B0", VA = "0x1880ED4B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	public static void JKJBDKBIADG(string CLNGGGMIBPI, int BFGBMBMPPGG, long LHOMILMLDLJ, long OMLJLCBHKDO, long BCNDLIDLLPK, long LAOLMDFGCLB, long GOOONEEHEFA, long NAJHNEJAJGK, long KMJLPPFJNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x80EB4F0", Offset = "0x80EA8F0", VA = "0x1880EB4F0")]
	public static LDBPABGAEKE EEDMPJKHECP(JobHandle DEDMJENGDPM, bool BJNGPOMADJB, bool BBACAMIMEGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x80EB5E0", Offset = "0x80EA9E0", VA = "0x1880EB5E0")]
	[IteratorStateMachine(typeof(KFIOPEBCDEC))]
	private static IEnumerator<KHJLACPAINM> OJJBIAADLKE(JobHandle FELIADFOOJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class BDJADAMMKJG
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum OECDIMJEOCN
	{
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		General,
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly int COPCFONPPLM;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly int PDJFOBJMBMP;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly int GOAIALPBPEJ;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly int AHDBFHCGJHP;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly int NJAFLKONGKO;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly int BLIAOKOMDDO;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly int OEOAJAPNPGP;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly int JPKANMOHOEA;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly int GBLGKFAJEHB;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly int ACAHPJCJOEC;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly int JOJICJIMLBL;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly int LPAEIDOFHAA;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x80DFFE0", Offset = "0x80DF3E0", VA = "0x1880DFFE0")]
	public static bool AIMOLCHJLPD(Material GMFBEMFEGJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x80DFF20", Offset = "0x80DF320", VA = "0x1880DFF20")]
	public static bool AEBJLMKFLHH(Material GMFBEMFEGJH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class NJMJGABCIHG : GLHCJMPCBPP
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class FAFGFIPDBGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public JAKNEJKGEIC<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public NJMJGABCIHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public FAFGFIPDBGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x80E4930", Offset = "0x80E3D30", VA = "0x1880E4930")]
		internal void MDBMEMBBNGL(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x80E47F0", Offset = "0x80E3BF0", VA = "0x1880E47F0")]
		internal void DKBLJPPMMCM(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	protected AvatarSkinAssetItem AFGGFFIPHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	protected Material[] AHOLAOHBBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private readonly AvatarSkinAssetItem.GJHHMDCLBPF FFDHIAGFLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private readonly AssetReference GOCMAAMMGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private readonly KDMFEBNOJJL? DNHFEPIFMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private SkinnedMeshRenderer[] KMEKMNGGAJL;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public override LFDPDKBANDC.JGFNEKKJIOP GCNKPMGHPCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(LFDPDKBANDC.JGFNEKKJIOP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA703A0", Offset = "0xA6F7A0", VA = "0x180A703A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x80EDA80", Offset = "0x80ECE80", VA = "0x1880EDA80")]
	public NJMJGABCIHG(AvatarSkinAssetItem.GJHHMDCLBPF PDDFDMKKGKO, AssetReference MENKODMOEHC, Material AJNCNAGFKIA, KMPAOABCDOI FBBAOHEBJDH, LFDPDKBANDC.JGFNEKKJIOP ODBBJJGELHH = (LFDPDKBANDC.JGFNEKKJIOP)0L, [Optional] KDMFEBNOJJL? OILDNKPENJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x80EDBB0", Offset = "0x80ECFB0", VA = "0x1880EDBB0")]
	public NJMJGABCIHG(AvatarSkinAssetItem.GJHHMDCLBPF PDDFDMKKGKO, AssetReference MENKODMOEHC, Material AJNCNAGFKIA, LFDPDKBANDC.JGFNEKKJIOP ODBBJJGELHH = (LFDPDKBANDC.JGFNEKKJIOP)0L, [Optional] KDMFEBNOJJL? OILDNKPENJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x80ED7F0", Offset = "0x80ECBF0", VA = "0x1880ED7F0", Slot = "6")]
	public override IHCAHILICGC OJFNGCINBDI(List<BFNEHIJGJBB> LGJMKIMJNHG, List<BFNEHIJGJBB> LAJCJDDBONB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x80ED5E0", Offset = "0x80EC9E0", VA = "0x1880ED5E0", Slot = "7")]
	public override EHGGGJCIAMB LPGMHHDFHEI(uint BFGBMBMPPGG, AvatarSkinnedMeshBoneOrderRemapsData OOBADMGOJOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x80EDA10", Offset = "0x80ECE10", VA = "0x1880EDA10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x80ED590", Offset = "0x80EC990", VA = "0x1880ED590")]
	protected void BIIEIMICIHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class KALJHJLPPKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private List<int> KNJIDIMHNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private List<JHIFEAOKCOP> DEELNKPILIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private HashSet<Transform> MDLKJFDEHIK;

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x80EC950", Offset = "0x80EBD50", VA = "0x1880EC950")]
	public static KALJHJLPPKK CKOMJHPLJLP(Transform DBAMLJDDEJL, Dictionary<Transform, OutfitType?> JLKIMPCCIFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x80ECC70", Offset = "0x80EC070", VA = "0x1880ECC70")]
	private void MOKOODPNJJD(Transform DBAMLJDDEJL, KMPAOABCDOI FBBAOHEBJDH, Dictionary<Transform, OutfitType?> JLKIMPCCIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x80ECAE0", Offset = "0x80EBEE0", VA = "0x1880ECAE0")]
	private void FJHEHJLABGG(Transform BFEPODFMALD, KMPAOABCDOI FBBAOHEBJDH, bool BKFDBNGHEHI, OutfitType? COHPPKDJCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x80ECF90", Offset = "0x80EC390", VA = "0x1880ECF90")]
	public OJBBPECCOFK NOEHGCIBFOB(HashSet<string> DCLEPMFPLJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x80ED380", Offset = "0x80EC780", VA = "0x1880ED380")]
	public KALJHJLPPKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class OJBBPECCOFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private List<JHIFEAOKCOP> DEELNKPILIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private List<Matrix4x4> FIBHPIFBIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private Transform[] LLJPDDOEJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private Matrix4x4[] PLGIBHPJCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private Dictionary<FDOAKNFCGLJ, int> GNECAMFEDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private List<BMNIHIAJFEL> FIIJLPFJPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private bool PNCHDBIHDLM;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x80EEB80", Offset = "0x80EDF80", VA = "0x1880EEB80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Transform[] BEDPGMMCOFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x80EF380", Offset = "0x80EE780", VA = "0x1880EF380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Matrix4x4[] ONCKEJEMDAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x80EF4F0", Offset = "0x80EE8F0", VA = "0x1880EF4F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x80EEF30", Offset = "0x80EE330", VA = "0x1880EEF30")]
	public void FJHEHJLABGG(Transform BFEPODFMALD, KMPAOABCDOI FBBAOHEBJDH, OutfitType? COHPPKDJCLA, bool NKJKHGCDGCG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x80EEBC0", Offset = "0x80EDFC0", VA = "0x1880EEBC0")]
	private void FJHEHJLABGG(Transform BFEPODFMALD, KMPAOABCDOI FBBAOHEBJDH, OutfitType? COHPPKDJCLA, bool NKJKHGCDGCG, Matrix4x4 OAILBJGBDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x80EF560", Offset = "0x80EE960", VA = "0x1880EF560")]
	public int MKDJKPEMCNK(FDOAKNFCGLJ PEENICAIFOP, bool GMEGEANJDEG, [Optional] OutfitType? COHPPKDJCLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x80EF280", Offset = "0x80EE680", VA = "0x1880EF280")]
	public int IIDJBLMPHCO(KMPAOABCDOI FBBAOHEBJDH, [Optional] OutfitType? COHPPKDJCLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x80EF710", Offset = "0x80EEB10", VA = "0x1880EF710")]
	public void OELMOABILJA(FDOAKNFCGLJ PEENICAIFOP, Matrix4x4 KEIBDLIMOAP, bool GMEGEANJDEG = false, [Optional] OutfitType? COHPPKDJCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x80EF130", Offset = "0x80EE530", VA = "0x1880EF130")]
	public Matrix4x4 IDGMIPDBJEL(FDOAKNFCGLJ PEENICAIFOP, bool GMEGEANJDEG, [Optional] OutfitType? COHPPKDJCLA)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x11FB0E0", Offset = "0x11FA4E0", VA = "0x1811FB0E0")]
	public void MFFACIGAMCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x80EF800", Offset = "0x80EEC00", VA = "0x1880EF800")]
	public OJBBPECCOFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct FDOAKNFCGLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public readonly string DBBHOJHONNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public readonly KMPAOABCDOI KCAKJCBNNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public readonly OutfitType? BNFLGMKBCKA;

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x80E4F90", Offset = "0x80E4390", VA = "0x1880E4F90")]
	public FDOAKNFCGLJ(string GNBHHOHKOCB, KMPAOABCDOI FBBAOHEBJDH, [Optional] OutfitType? COHPPKDJCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x80E4EE0", Offset = "0x80E42E0", VA = "0x1880E4EE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x80E4E20", Offset = "0x80E4220", VA = "0x1880E4E20")]
	public bool HELOPPPCEGA(FDOAKNFCGLJ LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x80E4D00", Offset = "0x80E4100", VA = "0x1880E4D00", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x80E4DB0", Offset = "0x80E41B0", VA = "0x1880E4DB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct BMNIHIAJFEL : IEquatable<BMNIHIAJFEL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public readonly KMPAOABCDOI KCAKJCBNNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public readonly OutfitType? GCGJLHOECIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public readonly int BCOHFBIDLBJ;

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x80E0560", Offset = "0x80DF960", VA = "0x1880E0560")]
	public BMNIHIAJFEL(KMPAOABCDOI FBBAOHEBJDH, int MDKHFFMOCGM, [Optional] OutfitType? BINPNINKPNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x80E0490", Offset = "0x80DF890", VA = "0x1880E0490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x72AFFE0", Offset = "0x72AF3E0", VA = "0x1872AFFE0")]
	public bool IEBDPIBPEMK(KMPAOABCDOI FBBAOHEBJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x80E0410", Offset = "0x80DF810", VA = "0x1880E0410")]
	public bool HJNLIKBPAGP(OutfitType? BINPNINKPNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x80E0280", Offset = "0x80DF680", VA = "0x1880E0280", Slot = "4")]
	public bool Equals(BMNIHIAJFEL LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x80E02D0", Offset = "0x80DF6D0", VA = "0x1880E02D0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x80E03C0", Offset = "0x80DF7C0", VA = "0x1880E03C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct JHIFEAOKCOP : IEquatable<JHIFEAOKCOP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public readonly Transform CHPFCFCJBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public readonly bool INPJIIPHADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public readonly KMPAOABCDOI CPBCGCLLEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public readonly OutfitType? BNFLGMKBCKA;

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x80EC900", Offset = "0x80EBD00", VA = "0x1880EC900")]
	public JHIFEAOKCOP(Transform BFEPODFMALD, bool BKFDBNGHEHI, KMPAOABCDOI PHBMNLGOPDC, [Optional] OutfitType? FNLPBLANMFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x80EC6E0", Offset = "0x80EBAE0", VA = "0x1880EC6E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x80EC480", Offset = "0x80EB880", VA = "0x1880EC480", Slot = "4")]
	public bool Equals(JHIFEAOKCOP LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x80EC580", Offset = "0x80EB980", VA = "0x1880EC580", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x80EC660", Offset = "0x80EBA60", VA = "0x1880EC660", Slot = "2")]
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
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x80E5670", Offset = "0x80E4A70", VA = "0x1880E5670")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface OINPEMKBEHK
{
	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HFEDMCKFDCJ(Mesh NIKBNBLEJEO, Matrix4x4 EEPMMDEGOIL, byte[] FACLODLGKNG, bool NLGBGKHAPEH = false, LFDPDKBANDC.JGFNEKKJIOP HCGPMFKLFAI = (LFDPDKBANDC.JGFNEKKJIOP)0L, int PAIDIFCDDEI = -1, bool FPBACDLKLDM = false);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IKCDNILAADH(Allocator KCEIEKBPKNP, NFFBEAMILGG DBHGIIJIOEE, byte HLINDEAICCD, [Optional] IList<int> AEJDOFBCFEA, [Optional] IList<int> AOAIAGEGMDB);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct KJNEMKMFKEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public readonly GameObject PJBJIEFCCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private readonly AvatarItemMaterial KOJJNJAEGBL;

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0xBFDA60", Offset = "0xBFCE60", VA = "0x180BFDA60")]
	public KJNEMKMFKEL(GameObject PJBJIEFCCLG, AvatarItemMaterial KOJJNJAEGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x80ED500", Offset = "0x80EC900", VA = "0x1880ED500")]
	public void ABIIBNFJJFJ(Material GMFBEMFEGJH, int LGBNJHMFDIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class CAGABPBEAJH : NJGCDFBADKM<Task<(GameObject, AvatarItemMaterial)>, KJNEMKMFKEL>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct EECECECFIBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x80E3D80", Offset = "0x80E3180", VA = "0x1880E3D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x80E4280", Offset = "0x80E3680", VA = "0x1880E4280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private JAKNEJKGEIC<GameObject> BLEAIKGEEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private JAKNEJKGEIC<AvatarItemMaterial> NNHJLJJJOGE;

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x80E0DD0", Offset = "0x80E01D0", VA = "0x1880E0DD0")]
	private CAGABPBEAJH(Task<(GameObject, AvatarItemMaterial)> KDHFABGBLNO, JAKNEJKGEIC<GameObject> KCBECCNKABB, JAKNEJKGEIC<AvatarItemMaterial> GNOFDNFGDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x80E0770", Offset = "0x80DFB70", VA = "0x1880E0770")]
	public static CAGABPBEAJH CEOONNIFPHP(AssetReference LDPCDPMAMNH, [Optional] AssetReference FIKCHGGAKGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x80E0D30", Offset = "0x80E0130", VA = "0x1880E0D30", Slot = "11")]
	protected override KJNEMKMFKEL LKDKDJPFHFE(Task<(GameObject, AvatarItemMaterial)> INOJAFNMNAO)
	{
		return default(KJNEMKMFKEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x80E0CB0", Offset = "0x80E00B0", VA = "0x1880E0CB0", Slot = "12")]
	protected override void JNGHMJGIFNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x80E0B80", Offset = "0x80DFF80", VA = "0x1880E0B80")]
	[AsyncStateMachine(typeof(EECECECFIBJ))]
	private static Task<(GameObject, AvatarItemMaterial)> GFPKIDIMFHF(Task<GameObject> NMIKMLPGKJB, Task<AvatarItemMaterial> EEALDAIIPML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class EIFLIHKMENJ
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class FMCBDBEMMPK : NJGCDFBADKM<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private JAKNEJKGEIC<MaterialMapAsset> FELIADFOOJH;

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x80E5590", Offset = "0x80E4990", VA = "0x1880E5590")]
		public FMCBDBEMMPK(JAKNEJKGEIC<MaterialMapAsset> FELIADFOOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x80E5120", Offset = "0x80E4520", VA = "0x1880E5120", Slot = "11")]
		protected override Material[] LKDKDJPFHFE(Task<MaterialMapAsset> KDHFABGBLNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x80E50C0", Offset = "0x80E44C0", VA = "0x1880E50C0", Slot = "12")]
		protected override void JNGHMJGIFNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class CAEALAJFBFH : NJGCDFBADKM<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private List<JAKNEJKGEIC<Material>> DHJLFOIFJKG;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x80E0700", Offset = "0x80DFB00", VA = "0x1880E0700")]
		public CAEALAJFBFH(Task<Material[]> KDHFABGBLNO, List<JAKNEJKGEIC<Material>> DHJLFOIFJKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x80E06B0", Offset = "0x80DFAB0", VA = "0x1880E06B0", Slot = "11")]
		protected override Material[] LKDKDJPFHFE(Task<Material[]> INOJAFNMNAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x80E0570", Offset = "0x80DF970", VA = "0x1880E0570", Slot = "12")]
		protected override void JNGHMJGIFNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x80E42F0", Offset = "0x80E36F0", VA = "0x1880E42F0")]
	public static JAKNEJKGEIC<Material[]> GBAOONHIEMG(AssetReference[] BNOODEMJOEL)
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
		public enum DEBFAPMLGFH
		{
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public enum OOHKJCIIAKC
		{
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public enum EGOIAHBGHBI : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			All,
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct PKOMFIDNJAA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			public readonly Material NOKPIKBDEMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			public readonly DEBFAPMLGFH EJHAIPFEDPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			public readonly OOHKJCIIAKC NEHMCGCINBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public readonly KMPAOABCDOI KCAKJCBNNEC;

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x8107130", Offset = "0x8106530", VA = "0x188107130")]
			public PKOMFIDNJAA(Material GMFBEMFEGJH, DEBFAPMLGFH LCKDFGPELPB, OOHKJCIIAKC AFMPOACCGLJ, KMPAOABCDOI FBBAOHEBJDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x8106F00", Offset = "0x8106300", VA = "0x188106F00", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x8106E80", Offset = "0x8106280", VA = "0x188106E80")]
			public bool HELOPPPCEGA(PKOMFIDNJAA LHDOHAKINKP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x8106CF0", Offset = "0x81060F0", VA = "0x188106CF0", Slot = "0")]
			public override bool Equals(object DEJGDIIDCDN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x8106DE0", Offset = "0x81061E0", VA = "0x188106DE0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		protected class MLKPOOOINAJ : IComparable<MLKPOOOINAJ>, IEquatable<MLKPOOOINAJ>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public int GCJPNHJEBNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public PlayerAvatarDisplayBase HFHAJICOHIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			public IList<PNAMCIBEICH> NJNJDHPJOEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public AvatarItemBodyType INGHJMNICMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			public KPJJMDIMPBJ JEIKCNOLHGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			public bool KGPJOJHAPMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			public bool OMPGLIIBGEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			public int[] AIGCACHBNLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			public float GGCGBFNNIDJ;

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x8105840", Offset = "0x8104C40", VA = "0x188105840", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x81056F0", Offset = "0x8104AF0", VA = "0x1881056F0", Slot = "4")]
			public int CompareTo(MLKPOOOINAJ LHDOHAKINKP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x8105720", Offset = "0x8104B20", VA = "0x188105720", Slot = "5")]
			public bool Equals(MLKPOOOINAJ LHDOHAKINKP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public MLKPOOOINAJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		protected abstract class AOOGCGOBLKM
		{
			[Cpp2IlInjected.Token(Token = "0x200005C")]
			public class KHLLGHMMCPN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000376")]
				public readonly Mesh NDHJEMJOCML;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000377")]
				public readonly Material[] EHNCAECLCNN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000378")]
				public readonly Transform[] KNMAJFLNLCC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000379")]
				public readonly Matrix4x4[] ELLEHOAALBF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400037A")]
				public readonly Transform JBHFJGIPNCP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400037B")]
				public readonly bool AIKJOFKMIHJ;

				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
				protected KHLLGHMMCPN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0x8102080", Offset = "0x8101480", VA = "0x188102080")]
				public KHLLGHMMCPN(Mesh NIKBNBLEJEO, Material[] IKOPJAOLIPN, bool FKMPOIGMPCC, Transform[] CAHEAFKKKBK, Transform NJKOFEHLDMK, Matrix4x4[] PGAKGNGAGJD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x8101ED0", Offset = "0x81012D0", VA = "0x188101ED0")]
				private KHLLGHMMCPN(SkinnedMeshRenderer HIFHHFKLDND, Material[] CKKCNIOLPKE)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x8101F90", Offset = "0x8101390", VA = "0x188101F90")]
				private KHLLGHMMCPN(MeshRenderer IAJDDPIBPLF, Transform NJKOFEHLDMK, Material[] CKKCNIOLPKE)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0x8101BA0", Offset = "0x8100FA0", VA = "0x188101BA0")]
				public static KHLLGHMMCPN IPOGPGIIOLD(Renderer FOGLHINMCEC, Material[] CKKCNIOLPKE)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public readonly KMPAOABCDOI KCAKJCBNNEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			public readonly Transform PJIICNODKKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public readonly bool ENEOJCPMIAL;

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual bool MGNNKBNOFFD
			{
				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual bool PKJJKLGBMLI
			{
				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual LFDPDKBANDC.JGFNEKKJIOP GCNKPMGHPCB
			{
				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "6")]
				get
				{
					return default(LFDPDKBANDC.JGFNEKKJIOP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public bool NINFMAEJDMG
			{
				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0x80FF000", Offset = "0x80FE400", VA = "0x1880FF000")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x80FF010", Offset = "0x80FE410", VA = "0x1880FF010")]
			protected AOOGCGOBLKM(KMPAOABCDOI FBBAOHEBJDH, Transform HPJEGHDNBCI, bool GMHKDFCHBIH = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract IHCAHILICGC OJFNGCINBDI(List<BFNEHIJGJBB> LGJMKIMJNHG, List<BFNEHIJGJBB> LAJCJDDBONB);

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract KHLLGHMMCPN LPGMHHDFHEI(int BFGBMBMPPGG, PlayerHandBones LJHGLEEOIBM);
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected class MEGIICEBGDD : AOOGCGOBLKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			protected readonly BodyPartLODs KMEKMNGGAJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			protected readonly Material[] AHOLAOHBBJF;

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x81055E0", Offset = "0x81049E0", VA = "0x1881055E0")]
			public MEGIICEBGDD(KMPAOABCDOI FBBAOHEBJDH, BodyPartLODs JFCACIGOEFO, Material AJNCNAGFKIA, [Optional] Transform HPJEGHDNBCI, bool GMHKDFCHBIH = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x81054E0", Offset = "0x81048E0", VA = "0x1881054E0", Slot = "7")]
			public override IHCAHILICGC OJFNGCINBDI(List<BFNEHIJGJBB> LGJMKIMJNHG, List<BFNEHIJGJBB> LAJCJDDBONB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x8105320", Offset = "0x8104720", VA = "0x188105320", Slot = "8")]
			public override KHLLGHMMCPN LPGMHHDFHEI(int BFGBMBMPPGG, PlayerHandBones LJHGLEEOIBM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x8105570", Offset = "0x8104970", VA = "0x188105570", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		protected class HIFBMCNMECB : AOOGCGOBLKM
		{
			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public override bool MGNNKBNOFFD
			{
				[Cpp2IlInjected.Token(Token = "0x6000317")]
				[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public override bool PKJJKLGBMLI
			{
				[Cpp2IlInjected.Token(Token = "0x6000318")]
				[Cpp2IlInjected.Address(RVA = "0x8100B70", Offset = "0x80FFF70", VA = "0x188100B70", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public OODLPBEANBG CPELFBAECAO
			{
				[Cpp2IlInjected.Token(Token = "0x6000319")]
				[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600031A")]
				[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x8100CC0", Offset = "0x81000C0", VA = "0x188100CC0")]
			public HIFBMCNMECB(KMPAOABCDOI FBBAOHEBJDH, Transform HPJEGHDNBCI, OODLPBEANBG GGADLHDJPJJ, bool GMHKDFCHBIH = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x8100BC0", Offset = "0x80FFFC0", VA = "0x188100BC0", Slot = "7")]
			public override IHCAHILICGC OJFNGCINBDI(List<BFNEHIJGJBB> LGJMKIMJNHG, List<BFNEHIJGJBB> LAJCJDDBONB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "8")]
			public override KHLLGHMMCPN LPGMHHDFHEI(int BFGBMBMPPGG, PlayerHandBones LJHGLEEOIBM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x8100C50", Offset = "0x8100050", VA = "0x188100C50", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public class DDLAKBDOENP
		{
			[Cpp2IlInjected.Token(Token = "0x2000060")]
			public enum LGDMEIIHCDP
			{
				[Cpp2IlInjected.Token(Token = "0x400038F")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x4000390")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x4000391")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x4000392")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x4000393")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x4000394")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x4000395")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x400037F")]
			public static readonly int KPHOGCIFCKL;

			[Cpp2IlInjected.Token(Token = "0x4000380")]
			public static readonly int FPAKNBGIJHK;

			[Cpp2IlInjected.Token(Token = "0x4000381")]
			public static readonly int LIFOKDGAJCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			protected readonly OIFJCNJMBMH AKFDIDELAAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			protected readonly IOINGJAJMHM ELILHDOEDEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			protected readonly Animator LOENEPLEIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			protected readonly Transform JJEGAPFPMMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public Vector3 EHILLJDEHIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			protected readonly Transform JGKPAMIOKFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public Vector3 EPBDAFLANNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			protected bool FFIINBFJOJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			protected JHCCFFGGMLF ICHHBODDAML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			protected bool BOOHNLNIJIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			protected float OEODJMMJGJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			protected PPHOIHPAMHF<IFJFNEIBCED> GJLKNFHDMLH;

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public JHCCFFGGMLF BPNLHKPPHDB
			{
				[Cpp2IlInjected.Token(Token = "0x600031F")]
				[Cpp2IlInjected.Address(RVA = "0xA703D0", Offset = "0xA6F7D0", VA = "0x180A703D0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0xA70390", Offset = "0xA6F790", VA = "0x180A70390")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public bool FKCLGLHIAFK
			{
				[Cpp2IlInjected.Token(Token = "0x6000321")]
				[Cpp2IlInjected.Address(RVA = "0xD24CE0", Offset = "0xD240E0", VA = "0x180D24CE0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000322")]
				[Cpp2IlInjected.Address(RVA = "0x80FF1A0", Offset = "0x80FE5A0", VA = "0x1880FF1A0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public bool FCLJDPJFCOG
			{
				[Cpp2IlInjected.Token(Token = "0x6000323")]
				[Cpp2IlInjected.Address(RVA = "0xA703C0", Offset = "0xA6F7C0", VA = "0x180A703C0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000324")]
				[Cpp2IlInjected.Address(RVA = "0x80FF9D0", Offset = "0x80FEDD0", VA = "0x1880FF9D0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public float LCBNJOBCLAK
			{
				[Cpp2IlInjected.Token(Token = "0x6000325")]
				[Cpp2IlInjected.Address(RVA = "0xDD8DA0", Offset = "0xDD81A0", VA = "0x180DD8DA0")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000326")]
				[Cpp2IlInjected.Address(RVA = "0x80FFB90", Offset = "0x80FEF90", VA = "0x1880FFB90")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public IFJFNEIBCED CPBBDJEILMN
			{
				[Cpp2IlInjected.Token(Token = "0x6000327")]
				[Cpp2IlInjected.Address(RVA = "0x80FF890", Offset = "0x80FEC90", VA = "0x1880FF890")]
				get
				{
					return default(IFJFNEIBCED);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x80FF370", Offset = "0x80FE770", VA = "0x1880FF370")]
			public bool GKHDLCPDGFA(IFJFNEIBCED PMANLCOLFEC, object MONGIMOHLAO, LGDMEIIHCDP ODFIJNEMHKN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x80FF8D0", Offset = "0x80FECD0", VA = "0x1880FF8D0")]
			public bool MFFDNJFKOLE(object MONGIMOHLAO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x80FFE40", Offset = "0x80FF240", VA = "0x1880FFE40")]
			protected DDLAKBDOENP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x80FFED0", Offset = "0x80FF2D0", VA = "0x1880FFED0")]
			public DDLAKBDOENP(OIFJCNJMBMH AKFDIDELAAA, JHCCFFGGMLF DJAEBFDLNEG, Animator LOENEPLEIFP, Transform JJEGAPFPMMG, Transform JGKPAMIOKFE, Vector3 EHILLJDEHIK, Vector3 EPBDAFLANNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x80FF2C0", Offset = "0x80FE6C0", VA = "0x1880FF2C0")]
			private void EKDOKKMALCH(ushort PPCKBBJBCCM, ushort GKPEBBGHNFH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x80FFAA0", Offset = "0x80FEEA0", VA = "0x1880FFAA0")]
			protected void NGMLOEKECDE(ushort PPCKBBJBCCM, ushort GKPEBBGHNFH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x80FFCD0", Offset = "0x80FF0D0", VA = "0x1880FFCD0")]
			protected void PBIFLMDIBLE(ushort PPCKBBJBCCM, ushort GKPEBBGHNFH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x80FF5A0", Offset = "0x80FE9A0", VA = "0x1880FF5A0")]
			protected void HGJFKPIOIKJ(ushort PPCKBBJBCCM, ushort GKPEBBGHNFH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x80FF6D0", Offset = "0x80FEAD0", VA = "0x1880FF6D0")]
			protected void ICGECJNOJGF(ushort PPCKBBJBCCM, ushort GKPEBBGHNFH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x80FF830", Offset = "0x80FEC30", VA = "0x1880FF830")]
			protected void LGCIMNHABKN(ushort PPCKBBJBCCM, ushort GKPEBBGHNFH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x80FF270", Offset = "0x80FE670", VA = "0x1880FF270")]
			protected void BLGOHFOBPLA(ushort PPCKBBJBCCM, ushort GKPEBBGHNFH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x80FF7E0", Offset = "0x80FEBE0", VA = "0x1880FF7E0")]
			protected void JIFKNLNEPFJ(ushort PPCKBBJBCCM, ushort GKPEBBGHNFH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x80FF480", Offset = "0x80FE880", VA = "0x1880FF480")]
			protected void HAGODPJECPN(ushort PPCKBBJBCCM, ushort GKPEBBGHNFH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public class LGPHGIJKOPM : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public const int KACBFEBMJDH = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			protected MaterialPropertyBlock HBNMIOCOANH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public Color? FKJGNNJIFBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			public Color? CIPMFENDGGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			public Color? DLDLBLGAMCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			public Color HEKFJNINGMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public Color BBIHFOLKOMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public Color GAOLGCIPKDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public Texture2D FNFLCFPJDAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			public Texture2D JCJOEGDDCND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			protected Dictionary<PKOMFIDNJAA, int> FBOGEDHOCIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			protected DEBFAPMLGFH[] KKOAAKBAPBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public Vector4[] DECFNPCNNJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public Vector4[] ELGINPENFIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public Vector4[] HJOFGPGPPML;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public Vector4[] NPCJIFJPPKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public Vector4[] DJDGDINAFLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			public Vector4[] HONHEFLNPIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected List<Texture2D> FEINFMANNDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			protected Vector4[] FDCOBCBAAPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			protected List<Texture2D> IEFKMFGJOIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			protected float[] CKLANJBLNJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			protected Vector4[] DLJIDIFGOJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			protected float[] LFIDHOMJKMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			public float[] AOLFOKDLLHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected List<Texture2D> LPDFGACFIGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected float[] NOKMLAFAHOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected List<Texture2D> BNAFAOPLDJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected Vector4[] PKPICAIMJHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			protected float[] HAGCJMACHPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			protected Vector4[] CLHFOEPAHGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			public float[] DHCCHBGECHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public Texture2DArray PKGIHMHKGNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public Texture2DArray EOOFOLGFAGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			public Texture2DArray EGHJHLJKOAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			public Texture2DArray LIDDJLBFHFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			protected bool PHEMMFAEGOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			protected int PFBENPHKCGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			protected Vector2? DPFHBAGEEOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			protected TextureFormat DIJDFHIDGEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			protected Vector2? BACNHJIENAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			protected TextureFormat GDMLBCKGMGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			protected Vector2? POHDALAENLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			protected TextureFormat MKNIBFOPOCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			protected Vector2? GKOHEFLAIBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			protected TextureFormat KNDPIJGBNGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			protected bool EGNOAKFAPLF;

			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			protected static int EADFHDLFMJM;

			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			protected static int EBMMGDKFAFK;

			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			protected static int BABNHHADOCF;

			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			protected static int ABMMDELDFGM;

			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			protected static int KDBAGAPJIEH;

			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			protected static int OOFEMIDLEFJ;

			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			protected static int DILBENKMPJO;

			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			protected static int BHNKDMIOBKE;

			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			protected static int PDMEKOBPNLF;

			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			protected static int PDLLIFFMJIC;

			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			protected static int MIHCGNBNBEH;

			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			protected static int KMFLIJIFNMA;

			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			protected static int LKLGADNBLMC;

			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			protected static int JIPONCPJNBC;

			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			protected static int PNPGENPADGH;

			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			protected static int OFAJJKDFGOA;

			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			protected static int COLJBEPNIIC;

			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			protected static int IHABAKDFMBD;

			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			protected static int GHDEJAODEND;

			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			protected static int NGLCFNLIJDL;

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x8104C20", Offset = "0x8104020", VA = "0x188104C20")]
			protected LGPHGIJKOPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x8104B90", Offset = "0x8103F90", VA = "0x188104B90")]
			public LGPHGIJKOPM(Color KDLGBEPEAHI, Color AABFFNIAOCC, Color CMLGGNADMII, Color? AHPEJKHDOBK, Color? CGDAJFBPBJJ, Color? JJFKGGNMMMP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x81035E0", Offset = "0x81029E0", VA = "0x1881035E0")]
			public int IAIJFEPGKIN(Material MGAKHFECEIL, DEBFAPMLGFH LCKDFGPELPB, OOHKJCIIAKC AFMPOACCGLJ, KMPAOABCDOI FBBAOHEBJDH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x8103550", Offset = "0x8102950", VA = "0x188103550")]
			public int IAIJFEPGKIN(PKOMFIDNJAA PEENICAIFOP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x81036D0", Offset = "0x8102AD0", VA = "0x1881036D0")]
			public int IFEACBPFBNF(Material MGAKHFECEIL, Color JCOIDDADMCN, Color FPFBFOIJFNO, Color IPLGMAFIILM, Color ABKLKFDFLGF, Color HCKKIIOECHE, Texture2D OBPNKPDIBPB, Vector4 PMFEJKGDPLH, Texture2D FGHNAKLDBDK, Vector4 NHAAFOKIHIJ, float OILGHDOICAC, float BEBIKOBJACI, Texture2D DKLPHCJIJNA, Vector4 OGPFOOAJNGL, float OIGIPOFCCED, Texture2D NGHKNIBKLIH, float PFBMGGOIDNA, Color OPLMFPGAJNK, Vector4 HNIHGGEHMKG, DEBFAPMLGFH LCKDFGPELPB, OOHKJCIIAKC AFMPOACCGLJ, KMPAOABCDOI FBBAOHEBJDH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x81043D0", Offset = "0x81037D0", VA = "0x1881043D0")]
			protected void JHLHLOKFJKG([Out] Texture2DArray MBPBCAMLFDL, [Out] Texture2DArray EHAECOKINAF, [Out] Texture2DArray FBAPNMIDJOI, [Out] Texture2DArray DICGNLMJHLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x8104590", Offset = "0x8103990", VA = "0x188104590")]
			public void KFGACHCJMFC(PlayerAvatarDisplayBase JJLPDDMFILA, Renderer FOGLHINMCEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x8102890", Offset = "0x8101C90", VA = "0x188102890")]
			protected void BMHPDJOIANF(PlayerAvatarDisplayBase JJLPDDMFILA, Renderer FOGLHINMCEC, int HDHMKOBIAKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x81026A0", Offset = "0x8101AA0", VA = "0x1881026A0")]
			private Color BBGGNPMEKDI(Color JPPLOFMJGPH, DEBFAPMLGFH AHEDBNJBENB)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x8103400", Offset = "0x8102800", VA = "0x188103400")]
			private Color FEKBMFAFCCB(Color GLKHBDMDPIM, DEBFAPMLGFH AHEDBNJBENB)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x8102610", Offset = "0x8101A10", VA = "0x188102610")]
			protected void AECHNKFPPMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x81033C0", Offset = "0x81027C0", VA = "0x1881033C0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x810DFF0", Offset = "0x810D3F0", VA = "0x18810DFF0")]
			public void HAOKPGEDJHL(KMPAOABCDOI FBBAOHEBJDH, [Out] Transform LDEPDDDHLLO, [Out] Transform[] CAHEAFKKKBK)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class PIGLCHGNMMJ : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600034F")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000351")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xFC9810", Offset = "0xFC8C10", VA = "0x180FC9810")]
			[DebuggerHidden]
			public PIGLCHGNMMJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x81067F0", Offset = "0x8105BF0", VA = "0x1881067F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x8106A70", Offset = "0x8105E70", VA = "0x188106A70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x81069C0", Offset = "0x8105DC0", VA = "0x1881069C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x81069C0", Offset = "0x8105DC0", VA = "0x1881069C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class LAFKJNNBKDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public LAFKJNNBKDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x8102530", Offset = "0x8101930", VA = "0x188102530")]
			internal bool ILDOBJHLEDD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class OOPCKBBHDCI : IEnumerator<KHJLACPAINM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			private KHJLACPAINM <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			private KHJLACPAINM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000359")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600035B")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
			[DebuggerHidden]
			public OOPCKBBHDCI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x81062B0", Offset = "0x81056B0", VA = "0x1881062B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x8106600", Offset = "0x8105A00", VA = "0x188106600", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private struct NNOCMGOFFKA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public PKLMLDNJFKK avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x81059C0", Offset = "0x8104DC0", VA = "0x1881059C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x8105D60", Offset = "0x8105160", VA = "0x188105D60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class NIJINLMNIDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public NIJINLMNIDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x8105990", Offset = "0x8104D90", VA = "0x188105990")]
			internal bool CAHFNKECGMJ(PNAMCIBEICH selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class HIPGEPBOMBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public Func<FHMCAMOMJOP<Dictionary<string, JAKNEJKGEIC<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public HIPGEPBOMBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x8100D30", Offset = "0x8100130", VA = "0x188100D30")]
			internal (BENMIFMGNEN, FHMCAMOMJOP<Dictionary<string, JAKNEJKGEIC<Texture2D>>>) EBDDNIHLDEG(Dictionary<string, CDGCPFKIDBL> avatarItems)
			{
				return default((BENMIFMGNEN, FHMCAMOMJOP<Dictionary<string, JAKNEJKGEIC<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x8100F60", Offset = "0x8100360", VA = "0x188100F60")]
			internal FHMCAMOMJOP<Dictionary<string, JAKNEJKGEIC<Texture2D>>> ONFDKKMDLAN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x8100F20", Offset = "0x8100320", VA = "0x188100F20")]
			internal void NPKBBKIPLLE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class CEEAAELGHFK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public CEEAAELGHFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x80FF0F0", Offset = "0x80FE4F0", VA = "0x1880FF0F0")]
			internal bool IFIJNKCIPEK(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private struct PKJMNINJPGK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003FD")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x8106AC0", Offset = "0x8105EC0", VA = "0x188106AC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x8106C90", Offset = "0x8106090", VA = "0x188106C90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		protected static readonly int BADLNDGMGKK;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		protected static readonly int JENCNHNEANP;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		protected static readonly int BOKKOPGGBBL;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		protected static readonly int FMIKKKFGGAC;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		protected static readonly int BJGLFDKDJOD;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		protected static readonly int MIAAAABPGOD;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		protected static readonly int[] EAIEOMFJPOH;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		protected static readonly int[] IGAOHKJDAJA;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		protected static readonly int[] HJJCCEEEJLD;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		protected static readonly int[] KCIMLIKGOJL;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		protected static readonly int[] GJENOEADMNO;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		protected static readonly int[] MAJEJIIPJKF;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		protected static List<PlayerAvatarDisplayBase> PDCDGNKLHCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		protected ADHECDELIKB OAOOECLEMNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		protected bool CIANLJFMBGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		protected bool NGKJEKGMBFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		protected static readonly int[] GKPCNIPEDAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		protected Dictionary<PKOMFIDNJAA, Material> MMEDGDCNLCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		protected Dictionary<PKOMFIDNJAA, Material> GHEBINDPOCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		[SerializeField]
		public Transform remoteMeshBase;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		protected Material KPOEPMNONCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		protected CNJDPLBKGCC JEBAFAACIMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private JHCCFFGGMLF ACABEPPEDCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private JHCCFFGGMLF HIHHDHGBINA;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		protected Material EFKENEAIINC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		[SerializeField]
		public Transform hemisphereBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		protected FitMeshHemisphere GBIHMAMJGHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		protected bool FELOLDABFBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		protected CHMLELHGCGH ALAMBIGCOHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		protected bool NKCNKHIOJOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		protected AnchorParamsRestrictions EDDGGHDNFDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		protected bool ODPIBPKNHPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		protected Transform JMFPNBKBHHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		protected bool GILBMEBFKNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B1")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		protected bool LFONNONONCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		protected Vector3 EDOJNLPGIMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		protected Quaternion CKHBBMNDJBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		protected Vector2 NJHBOCJPMMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		protected FitMeshHemisphere PPJBEFHKAHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		[BNCHLJBJHLJ(FIPBCJPBODB.SelfAndChildren, false, false, false)]
		[SerializeField]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected Collider[] PFAPEMDEHIN;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		protected Collider[] BPGFDODGCHH;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected DDLAKBDOENP[] FOPDNHMKFGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public Dictionary<Renderer, LGPHGIJKOPM> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected Dictionary<Renderer, LGPHGIJKOPM> FHCPDNOFJPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected KALJHJLPPKK EJDHLMLPDEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected BENMIFMGNEN GHNDKJHIGAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public IEEJIDPBMPL DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected int LAIDEPEKGMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected (bool isLodForced, int forcedLOD) PPICINPBLBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		protected PPHOIHPAMHF<IOINGJAJMHM> GJLKNFHDMLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		protected bool GDDHNLAJPHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		protected Dictionary<PNAMCIBEICH, List<PKOMFIDNJAA>> HOHHNINHALP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		protected Dictionary<PNAMCIBEICH, List<PKOMFIDNJAA>> KOGMMLBJEPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		protected readonly Dictionary<string, JAKNEJKGEIC<Texture2D>> DIKOGKIOCLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		protected readonly Dictionary<string, JAKNEJKGEIC<Texture2D>> FEJHCNOCCCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		protected bool HCLJOODIENE;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		protected static int MGNPPLKDLFI;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected static List<MLKPOOOINAJ> IPCJLICCOMJ;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected static List<MLKPOOOINAJ> OBBFEFOOCGO;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected static LDBPABGAEKE LFBCDBJAHGO;

		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected static Func<List<MLKPOOOINAJ>, MLKPOOOINAJ> EHCEOGAHMMA;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		protected static bool FMCINKBAIOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		protected Color? NPOBACHFEFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		protected bool CDAHIEGPMDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected Color LKBNLPGKBCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		protected Color IMHHOJBHPHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		protected Color HBAODJJGPIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		protected AvatarHairPattern LNHAADCFMPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		protected OODLPBEANBG KGPMCPPIAAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		protected Color CPPDPGGNBGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		protected Color GFEPFNNGJPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		protected AvatarHairPattern MMDNPIMNCNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		protected OODLPBEANBG PGLMANPAHMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		protected OODLPBEANBG HACGBLKLMEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		protected Color PLAGNGHJNGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private AdditionalFeetData KDOFEPNAKBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		protected PNAMCIBEICH? JECOBJNDOGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		protected Texture KHPECOMDCDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		protected Color PFOLEFJHAKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		protected readonly IList<PNAMCIBEICH> DNNNBKPOGLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		protected readonly IList<PNAMCIBEICH> PCCFBOJOFKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private AvatarItemBodyType JEJHKHFABEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		[SerializeField]
		protected BIBEJHBBCLK _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D5")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		protected EGOIAHBGHBI HHNGBALCFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		protected int[] PKGNPHKJKFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		protected bool JKKKBHJNDOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		protected int[] KFHNPFGFDKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		protected bool HFJJCBACBPB;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private static readonly LFDPDKBANDC.JGFNEKKJIOP DCMHIAMNCEG;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private static readonly LFDPDKBANDC.JGFNEKKJIOP FGFKPAONEEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F1")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		protected bool BKFCAGKPDNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		protected EGOGGADCJBA BEHIINBLJAG;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string FFMCLLMGLIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool EIFECICBNOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xD1A4E0", Offset = "0xD198E0", VA = "0x180D1A4E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xD198B0", Offset = "0xD18CB0", VA = "0x180D198B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool JMMPMBIKEAD
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool DDFGBGOJMAM
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x80FD910", Offset = "0x80FCD10", VA = "0x1880FD910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool NLJAINDEMJO
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool BPLLIEHHEIP
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual bool GFBKIGJAMAC
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual bool HHONCOGBIOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public CNJDPLBKGCC CLGNFLFNIBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xBCF390", Offset = "0xBCE790", VA = "0x180BCF390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x80FE0F0", Offset = "0x80FD4F0", VA = "0x1880FE0F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public JHCCFFGGMLF PJHJKALHIJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0xBD0B90", Offset = "0xBCFF90", VA = "0x180BD0B90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x80FE4F0", Offset = "0x80FD8F0", VA = "0x1880FE4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public JHCCFFGGMLF KAKAAOGDJJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0xBE0820", Offset = "0xBDFC20", VA = "0x180BE0820")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x80FE7B0", Offset = "0x80FDBB0", VA = "0x1880FE7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		protected Material OIOLKKDOOLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x80F6C50", Offset = "0x80F6050", VA = "0x1880F6C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		protected Material OKNILCCGCJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x80F4990", Offset = "0x80F3D90", VA = "0x1880F4990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool OCBGINPDGHH
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x24DC3A0", Offset = "0x24DB7A0", VA = "0x1824DC3A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public PlayerFacialAnimatorBase BHNFGJGLIIA
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0xBE0A30", Offset = "0xBDFE30", VA = "0x180BE0A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public DDLAKBDOENP[] EMBFEFENCDO
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x80FD490", Offset = "0x80FC890", VA = "0x1880FD490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public DDLAKBDOENP AFNDGBECIAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x80FDB20", Offset = "0x80FCF20", VA = "0x1880FDB20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public DDLAKBDOENP NEOGKICHAKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x80FDB50", Offset = "0x80FCF50", VA = "0x1880FDB50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Mesh LHOAIMBNHCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0xB69260", Offset = "0xB68660", VA = "0x180B69260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected KALJHJLPPKK LKKPGLPBLAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x80F6A00", Offset = "0x80F5E00", VA = "0x1880F6A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		protected BENMIFMGNEN ABKHIGGGCGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xBE1500", Offset = "0xBE0900", VA = "0x180BE1500")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x80F16F0", Offset = "0x80F0AF0", VA = "0x1880F16F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		protected bool BBACAMIMEGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool LCEGKCLHDMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x80FDB10", Offset = "0x80FCF10", VA = "0x1880FDB10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public int GEKLGAICLJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x135D430", Offset = "0x135C830", VA = "0x18135D430")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x80FE700", Offset = "0x80FDB00", VA = "0x1880FE700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public int FMPHHCNLAOH
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x80FE440", Offset = "0x80FD840", VA = "0x1880FE440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected virtual bool OKCPEPBKEGG
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected virtual int[] KLEIBPCPEIN
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x80F0FC0", Offset = "0x80F03C0", VA = "0x1880F0FC0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		protected bool BCJBPDCHIOF
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x80F73B0", Offset = "0x80F67B0", VA = "0x1880F73B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		protected static bool IACHHOGCGIH
		{
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool NFGFJMOEDMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x80FDB80", Offset = "0x80FCF80", VA = "0x1880FDB80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x80FE9D0", Offset = "0x80FDDD0", VA = "0x1880FE9D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public IEnumerable<SkinnedMeshRenderer> BNEKKBGHHFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x80FD310", Offset = "0x80FC710", VA = "0x1880FD310")]
			[IteratorStateMachine(typeof(PIGLCHGNMMJ))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool OEKNIBMILKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x80FDB00", Offset = "0x80FCF00", VA = "0x1880FDB00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x80F6B80", Offset = "0x80F5F80", VA = "0x1880F6B80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public AGMMOBNOCAG KAKEPKOJFME
		{
			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x80FD390", Offset = "0x80FC790", VA = "0x1880FD390")]
			get
			{
				return default(AGMMOBNOCAG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public static bool MBFODPBBPDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x80FD840", Offset = "0x80FCC40", VA = "0x1880FD840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected static LDBPABGAEKE MPGHCNJFFOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x80F2E90", Offset = "0x80F2290", VA = "0x1880F2E90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x80F33E0", Offset = "0x80F27E0", VA = "0x1880F33E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected Color CIPMFENDGGO
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x80F6480", Offset = "0x80F5880", VA = "0x1880F6480")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected Color DLDLBLGAMCL
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x80F2920", Offset = "0x80F1D20", VA = "0x1880F2920")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected Texture2D DGIKIEIGHPM
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x80F1050", Offset = "0x80F0450", VA = "0x1880F1050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Color HEKFJNINGMA
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x80FD440", Offset = "0x80FC840", VA = "0x1880FD440")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		protected Color BBIHFOLKOMD
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x80F2660", Offset = "0x80F1A60", VA = "0x1880F2660")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public OODLPBEANBG ICEDLPMLKMP
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x80FD400", Offset = "0x80FC800", VA = "0x1880FD400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		protected Texture2D GPCONFHNMCH
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x80F5240", Offset = "0x80F4640", VA = "0x1880F5240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public float BLGBGJLEPHN
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x80FD420", Offset = "0x80FC820", VA = "0x1880FD420")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public float AGCIFLFLPOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x80FD8F0", Offset = "0x80FCCF0", VA = "0x1880FD8F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public bool NMPAJEFAHCO
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x80FD3F0", Offset = "0x80FC7F0", VA = "0x1880FD3F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x80FDED0", Offset = "0x80FD2D0", VA = "0x1880FDED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action LAMCFCHMEPP
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x80FD070", Offset = "0x80FC470", VA = "0x1880FD070")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x80FDC30", Offset = "0x80FD030", VA = "0x1880FDC30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action BKNAPDJEEOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x80FCFD0", Offset = "0x80FC3D0", VA = "0x1880FCFD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x80FDB90", Offset = "0x80FCF90", VA = "0x1880FDB90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action PJGHNKAMPLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x80FD110", Offset = "0x80FC510", VA = "0x1880FD110")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x80FDCD0", Offset = "0x80FD0D0", VA = "0x1880FDCD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action LCBGDMJLJFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x80FD1B0", Offset = "0x80FC5B0", VA = "0x1880FD1B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x80FDD70", Offset = "0x80FD170", VA = "0x1880FDD70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<OIFJCNJMBMH, IFJFNEIBCED> KDNHJJKANCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x80FD250", Offset = "0x80FC650", VA = "0x1880FD250")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x80FDE10", Offset = "0x80FD210", VA = "0x1880FDE10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x80F9850", Offset = "0x80F8C50", VA = "0x1880F9850")]
		public bool SetDeformation(bool CIANLJFMBGI, bool NGKJEKGMBFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x80F6A20", Offset = "0x80F5E20", VA = "0x1880F6A20")]
		protected static Material KJHAOPHBIAE(Dictionary<PKOMFIDNJAA, Material> BNGCKMHEMKL, Material FBLHNEEACOC, DEBFAPMLGFH LCKDFGPELPB, OOHKJCIIAKC AFMPOACCGLJ, KMPAOABCDOI FBBAOHEBJDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x80F2540", Offset = "0x80F1940", VA = "0x1880F2540")]
		protected void EEDPJKMDFMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x80F3030", Offset = "0x80F2430", VA = "0x1880F3030")]
		protected bool GIFMDJIIMPL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x80F4C90", Offset = "0x80F4090", VA = "0x1880F4C90")]
		protected void HFCAPBODFNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x80EFCE0", Offset = "0x80EF0E0", VA = "0x1880EFCE0", Slot = "11")]
		protected virtual void ACNAPFMIBLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x80F7430", Offset = "0x80F6830", VA = "0x1880F7430")]
		public int MeshesAtLODCount(int KPGIJMBOGNG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x80F55E0", Offset = "0x80F49E0", VA = "0x1880F55E0")]
		protected static void JBEEAKHEGEC(Dictionary<PNAMCIBEICH, List<PKOMFIDNJAA>> FKMIOCNPCCJ, AOOGCGOBLKM EMDAMIKMHBF, Material FBLHNEEACOC, DEBFAPMLGFH AHEDBNJBENB, OOHKJCIIAKC IMCDPIHCLGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x80F08D0", Offset = "0x80EFCD0", VA = "0x1880F08D0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x80F0C00", Offset = "0x80F0000", VA = "0x1880F0C00")]
		protected void BFOBPADPDBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x80F8650", Offset = "0x80F7A50", VA = "0x1880F8650")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "12")]
		protected virtual void FKFMAHMPIHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x80F26B0", Offset = "0x80F1AB0", VA = "0x1880F26B0")]
		protected static void EGPBILNPOLM(List<Material> BCHCLKKOFFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x80F8010", Offset = "0x80F7410", VA = "0x1880F8010")]
		protected static void NKGLANLAKCJ(Dictionary<PKOMFIDNJAA, Material> BNGCKMHEMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x80F8470", Offset = "0x80F7870", VA = "0x1880F8470")]
		protected static void OMHJOLEGFLI(Dictionary<Renderer, LGPHGIJKOPM> ODJHDMIHECO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x80F7290", Offset = "0x80F6690", VA = "0x1880F7290")]
		protected void MFDFFADEPFM(SkinnedMeshRenderer[] DINJJCDOOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x80F1140", Offset = "0x80F0540", VA = "0x1880F1140")]
		protected void BLFKKMPPJHP(SkinnedMeshRenderer HIFHHFKLDND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x80F11E0", Offset = "0x80F05E0", VA = "0x1880F11E0")]
		protected void BLFKKMPPJHP(MeshRenderer IAJDDPIBPLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x80F1F60", Offset = "0x80F1360", VA = "0x1880F1F60")]
		protected void DCEOLNLLIEO(List<BFNEHIJGJBB> FKFEPKICEOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x80F4B10", Offset = "0x80F3F10", VA = "0x1880F4B10")]
		protected void HDNPJOMBPGG(Dictionary<string, JAKNEJKGEIC<Texture2D>> FKMIOCNPCCJ, bool KCFMPCDBKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x80F8BE0", Offset = "0x80F7FE0", VA = "0x1880F8BE0")]
		protected void PIFLDLDGAHM(Dictionary<PNAMCIBEICH, List<PKOMFIDNJAA>> FKMIOCNPCCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x80F4890", Offset = "0x80F3C90", VA = "0x1880F4890")]
		public float GetHandOpenClosedAxis(OIFJCNJMBMH AKFDIDELAAA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x80FA0E0", Offset = "0x80F94E0", VA = "0x1880FA0E0")]
		public void SetHandOpenClosedAxis(OIFJCNJMBMH AKFDIDELAAA, float HPGCCJFOEEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x80F48D0", Offset = "0x80F3CD0", VA = "0x1880F48D0")]
		public IFJFNEIBCED GetHandVisualState(OIFJCNJMBMH AKFDIDELAAA)
		{
			return default(IFJFNEIBCED);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x80F0010", Offset = "0x80EF410", VA = "0x1880F0010")]
		public bool AddHandVisualStateToken(OIFJCNJMBMH AKFDIDELAAA, IFJFNEIBCED FKHPIPEDIEL, object MONGIMOHLAO, DDLAKBDOENP.LGDMEIIHCDP ODFIJNEMHKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x80FB950", Offset = "0x80FAD50", VA = "0x1880FB950")]
		public void SetWatchHand(OIFJCNJMBMH AKFDIDELAAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x80FBA10", Offset = "0x80FAE10", VA = "0x1880FBA10")]
		public void SetWatchHands(bool HCLDJKFODGB, bool HPANPGPFGCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x80F8F10", Offset = "0x80F8310", VA = "0x1880F8F10")]
		public bool RemoveHandVisualStateToken(OIFJCNJMBMH AKFDIDELAAA, object MONGIMOHLAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x80F4950", Offset = "0x80F3D50", VA = "0x1880F4950")]
		public bool GetThumbsUpActive(OIFJCNJMBMH AKFDIDELAAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x80FB370", Offset = "0x80FA770", VA = "0x1880FB370")]
		public void SetThumbsUpActive(OIFJCNJMBMH AKFDIDELAAA, bool IAHEKIKMBLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x80F4910", Offset = "0x80F3D10", VA = "0x1880F4910")]
		public bool GetHandshakeActive(OIFJCNJMBMH AKFDIDELAAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x80FA130", Offset = "0x80F9530", VA = "0x1880FA130")]
		public void SetHandshakeActive(OIFJCNJMBMH AKFDIDELAAA, bool AKPNFBADMKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x80F2EE0", Offset = "0x80F22E0", VA = "0x1880F2EE0")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x80FB840", Offset = "0x80FAC40", VA = "0x1880FB840")]
		public void SetUseClassicBeanHandScale(bool CBMEHPPMEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x80F1E40", Offset = "0x80F1240", VA = "0x1880F1E40")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x80F5340", Offset = "0x80F4740", VA = "0x1880F5340")]
		private static void INJHOOOGLOG(Scene CHBELKDGKBD, LoadSceneMode KLNPGHMOELH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x80F5BD0", Offset = "0x80F4FD0", VA = "0x1880F5BD0")]
		protected static void JKLOCABBACE(PlayerAvatarDisplayBase LKJHGFMCJIK, List<MLKPOOOINAJ> AODLOGPGEBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x80F8C30", Offset = "0x80F8030", VA = "0x1880F8C30")]
		public IHCAHILICGC Rebuild()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x80F2260", Offset = "0x80F1660", VA = "0x1880F2260")]
		protected IHCAHILICGC DFGOFNDNAMC(bool GEKGCCAKPEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x80F2130", Offset = "0x80F1530", VA = "0x1880F2130", Slot = "13")]
		protected virtual IHCAHILICGC DFGOFNDNAMC(IList<PNAMCIBEICH> GHAHLHKNCBG, AvatarItemBodyType FIIFEEIDAMD, bool BJFPHDBMGLL, bool IFDPADCJCEL, int[] GJNFENFOHGE, bool GEKGCCAKPEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x80F5CD0", Offset = "0x80F50D0", VA = "0x1880F5CD0")]
		protected static IHCAHILICGC JKNMFAABBLD(MLKPOOOINAJ APCJAAJGCCK, List<MLKPOOOINAJ> AODLOGPGEBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x80F24E0", Offset = "0x80F18E0", VA = "0x1880F24E0")]
		[IteratorStateMachine(typeof(OOPCKBBHDCI))]
		protected static IEnumerator<KHJLACPAINM> DKFBCAEJKIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x80F6230", Offset = "0x80F5630", VA = "0x1880F6230")]
		protected static MLKPOOOINAJ JMAOAPLGBLM(List<MLKPOOOINAJ> AODLOGPGEBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x80F9950", Offset = "0x80F8D50", VA = "0x1880F9950")]
		[AsyncStateMachine(typeof(NNOCMGOFFKA))]
		public Task SetFaceCustomizationSettings(PKLMLDNJFKK GPPGDEEJAMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x80FBB70", Offset = "0x80FAF70", VA = "0x1880FBB70")]
		public bool UpdateFaceAndBodyCustomizationSettings(PKLMLDNJFKK GPPGDEEJAMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x80F5500", Offset = "0x80F4900", VA = "0x1880F5500")]
		public void InitializeFaceFeatures(AvatarConfiguration LBFJECIDKKL, AGMMOBNOCAG OEJHEOJFBIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x80FB0D0", Offset = "0x80FA4D0", VA = "0x1880FB0D0")]
		public void SetTeamColors(Color? JJFKGGNMMMP, bool NKJCBHEFJOE, Color BKJJHBLDIBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x151CD50", Offset = "0x151C150", VA = "0x18151CD50")]
		private static void IKDIHJIDKAO(Material GMFBEMFEGJH, Color CBMEHPPMEEA, params int[] EGPOFHEPNPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x151C4C0", Offset = "0x151B8C0", VA = "0x18151C4C0")]
		private static void HBDDBJIBIKP(Material GMFBEMFEGJH, Texture CBMEHPPMEEA, params int[] EGPOFHEPNPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x80F4EB0", Offset = "0x80F42B0", VA = "0x1880F4EB0")]
		protected void HPFBJAFMDEJ(Material LIIDNHAOGFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x80F13B0", Offset = "0x80F07B0", VA = "0x1880F13B0")]
		protected void BNDKJDKHCAB(Material LIIDNHAOGFE, Color PADLNNENHPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x80EFD40", Offset = "0x80EF140", VA = "0x1880EFD40")]
		protected void AMAMHFBDIHO(Material LIIDNHAOGFE, Color PADLNNENHPL, Color JCPGEKKGHIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x80F8210", Offset = "0x80F7610", VA = "0x1880F8210")]
		protected void OBPABGOAJEF(Material LIIDNHAOGFE, Texture2D IOFLDLKHGCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x80F32D0", Offset = "0x80F26D0", VA = "0x1880F32D0")]
		protected void GMDAGAJDDBA(Material LIIDNHAOGFE, Texture DJPLIJIACPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x80F4D20", Offset = "0x80F4120", VA = "0x1880F4D20")]
		protected void HHHAGDBJKOF(Action<LGPHGIJKOPM> HGMOFNOAGFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x80F74F0", Offset = "0x80F68F0", VA = "0x1880F74F0")]
		protected void NALIDAMFNBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x80F2CD0", Offset = "0x80F20D0", VA = "0x1880F2CD0")]
		protected void FHIHLPCKDLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x80F2970", Offset = "0x80F1D70", VA = "0x1880F2970")]
		protected void FGFEJANKGGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x80F0360", Offset = "0x80EF760", VA = "0x1880F0360")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x80F92D0", Offset = "0x80F86D0", VA = "0x1880F92D0")]
		public void SetBeardPrimaryColor([Optional] Color? HJBOGINJFMM, bool NFNOLLCEDOJ = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x80F94F0", Offset = "0x80F88F0", VA = "0x1880F94F0")]
		public void SetBeardSecondaryColor([Optional] Color? HJBOGINJFMM, bool NFNOLLCEDOJ = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x80F9190", Offset = "0x80F8590", VA = "0x1880F9190")]
		public void SetBeardPattern([Optional] AvatarHairPattern POLGGJPFHMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x80F8A70", Offset = "0x80F7E70", VA = "0x1880F8A70")]
		private void PGALFMBFLPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x80F6EF0", Offset = "0x80F62F0", VA = "0x1880F6EF0")]
		private bool LNKMCAPBNPA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x80F9CC0", Offset = "0x80F90C0", VA = "0x1880F9CC0")]
		public void SetHairPrimaryColor([Optional] Color? KDDELBIKFPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x80F9ED0", Offset = "0x80F92D0", VA = "0x1880F9ED0")]
		public void SetHairSecondaryColor([Optional] Color? KDDELBIKFPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x80F9B90", Offset = "0x80F8F90", VA = "0x1880F9B90")]
		public void SetHairPattern([Optional] AvatarHairPattern POLGGJPFHMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x80F8DB0", Offset = "0x80F81B0", VA = "0x1880F8DB0")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x80F6B90", Offset = "0x80F5F90", VA = "0x1880F6B90")]
		private bool LACJOELBFDM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x80FAF10", Offset = "0x80FA310", VA = "0x1880FAF10")]
		public void SetSkinColor(Color KDLGBEPEAHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x80FB3C0", Offset = "0x80FA7C0", VA = "0x1880FB3C0")]
		public void SetUgcItemVisualOverrides(PNAMCIBEICH KMJNEFBCKCG, AGMMOBNOCAG OEJHEOJFBIN, Texture PJBABFBMKJC, Color FJECCHNNLFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x80F1F10", Offset = "0x80F1310", VA = "0x1880F1F10")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x80F9A50", Offset = "0x80F8E50", VA = "0x1880F9A50")]
		public bool SetFaceShape(AvatarFaceShape PFMDLLEJAKL, bool PFDJNAHLPGL = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x80F8900", Offset = "0x80F7D00", VA = "0x1880F8900")]
		private void PCJHHNKHDNG(IKJHOMLMOIB DFDNJFJKIFC, float CBMEHPPMEEA, bool FHMJMIAPOPP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x80F7E10", Offset = "0x80F7210", VA = "0x1880F7E10")]
		private void NKBMHGJAACH(IFNKCBIOEFJ OGGIGAMAGGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x80F8170", Offset = "0x80F7570", VA = "0x1880F8170")]
		private void NNCKLDDFKIP(NGHFELHBJNN PIEHDBGLBHL, float CBMEHPPMEEA, bool NENBPDCLEAA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x80F1650", Offset = "0x80F0A50", VA = "0x1880F1650")]
		private void CLGCDKCKBOG(LKLBBBNPHMA MGPAIFKCMHE, float CBMEHPPMEEA, bool BLMKAINOIPG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x80F6FA0", Offset = "0x80F63A0", VA = "0x1880F6FA0")]
		private void MAFIJIKCCPN(EGDACPOEAEL NJLNJHHAOKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x80F27F0", Offset = "0x80F1BF0", VA = "0x1880F27F0")]
		private void FEMHCBBGDLH(FFNHHEOHPGA KNMPAMCNCHH, float BDOEFIGAOGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x80F9710", Offset = "0x80F8B10", VA = "0x1880F9710")]
		public bool SetBodyShape(AvatarBodyShape DMOJGFNKIPB, bool PFDJNAHLPGL = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x80FADA0", Offset = "0x80FA1A0", VA = "0x1880FADA0")]
		public bool SetNoseType(BIBEJHBBCLK HKFNPLIFPCH, bool PFDJNAHLPGL = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x80FC260", Offset = "0x80FB660", VA = "0x1880FC260")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x80FAD80", Offset = "0x80FA180", VA = "0x1880FAD80")]
		public bool SetHideEars(bool NFIEBEBICPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x80FAD70", Offset = "0x80FA170", VA = "0x1880FAD70")]
		public bool SetHelmetHair(ADHECDELIKB LLLOMNPCLAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x80FA180", Offset = "0x80F9580", VA = "0x1880FA180")]
		public void SetHatAnchorParameters(CHMLELHGCGH DDAEPEPEPKB, bool MNBGILJPMGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x80FBAE0", Offset = "0x80FAEE0", VA = "0x1880FBAE0")]
		public void SetupDisplayLODs(EGOIAHBGHBI AGBAAIFMFFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x80F62C0", Offset = "0x80F56C0", VA = "0x1880F62C0")]
		protected int[] JNMALBGHELF(EGOIAHBGHBI AGBAAIFMFFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x80FAE90", Offset = "0x80FA290", VA = "0x1880FAE90")]
		public void SetOutfitSelections(IList<PNAMCIBEICH> GHAHLHKNCBG, AvatarItemBodyType FIIFEEIDAMD, bool IFDPADCJCEL, bool GEKGCCAKPEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x80FAE40", Offset = "0x80FA240", VA = "0x1880FAE40")]
		public void SetOutfitSelections(IList<PNAMCIBEICH> GHAHLHKNCBG, AvatarItemBodyType FIIFEEIDAMD, bool BJFPHDBMGLL, bool IFDPADCJCEL, bool GEKGCCAKPEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x80FAED0", Offset = "0x80FA2D0", VA = "0x1880FAED0")]
		public IHCAHILICGC SetOutfitSelections(IList<PNAMCIBEICH> GHAHLHKNCBG, AvatarItemBodyType FIIFEEIDAMD, EGOIAHBGHBI AGBAAIFMFFG, bool BJFPHDBMGLL, bool IFDPADCJCEL, bool PFDJNAHLPGL = false, bool GEKGCCAKPEC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x80F6780", Offset = "0x80F5B80", VA = "0x1880F6780", Slot = "14")]
		protected virtual IHCAHILICGC KFOIPEEFMAM(IList<PNAMCIBEICH> GHAHLHKNCBG, AvatarItemBodyType FIIFEEIDAMD, bool BJFPHDBMGLL, bool IFDPADCJCEL, EGOIAHBGHBI AGBAAIFMFFG, bool PFDJNAHLPGL, bool GEKGCCAKPEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x80F12B0", Offset = "0x80F06B0", VA = "0x1880F12B0")]
		protected int[] BMMFOCPMBJM(EGOIAHBGHBI AGBAAIFMFFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "15")]
		protected virtual BENMIFMGNEN IIJEFBFMMAA(AvatarItemBodyType NBLJOEEFODI, Dictionary<string, CDGCPFKIDBL> DOLOCFCPCFH, Dictionary<string, JAKNEJKGEIC<Texture2D>> FOIALDNHNOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x80F45C0", Offset = "0x80F39C0", VA = "0x1880F45C0", Slot = "16")]
		protected virtual IHCAHILICGC GNLEICABFLA(IList<PNAMCIBEICH> GHAHLHKNCBG, AvatarItemBodyType FIIFEEIDAMD, bool BJFPHDBMGLL, bool IFDPADCJCEL, int[] AIGCACHBNLA, KPJJMDIMPBJ KOHDJEKHEHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x80F7920", Offset = "0x80F6D20", VA = "0x1880F7920", Slot = "17")]
		protected virtual CDGCPFKIDBL NJILLNJPFJD(OODLPBEANBG GGADLHDJPJJ, AvatarItemBodyType NBLJOEEFODI, KMPAOABCDOI FBBAOHEBJDH, CDGCPFKIDBL ILAODPMHPKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "18")]
		protected virtual CDGCPFKIDBL LKAMOAPCOJP(AvatarItemBodyType NBLJOEEFODI, KMPAOABCDOI FBBAOHEBJDH, NCNGPPGCAEP ANBICBPBIDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x80F85D0", Offset = "0x80F79D0", VA = "0x1880F85D0")]
		protected void OOANPIICFMA(DGHDGHOFFPP MNFFANCCMAJ, LFDPDKBANDC.JGFNEKKJIOP DMOKIJLPBMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x80F3250", Offset = "0x80F2650", VA = "0x1880F3250")]
		protected void GJNJDDOMLBP(DGHDGHOFFPP MNFFANCCMAJ, LFDPDKBANDC.JGFNEKKJIOP DMOKIJLPBMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xAD5C60", Offset = "0xAD5060", VA = "0x180AD5C60", Slot = "19")]
		protected virtual DGHDGHOFFPP CJEELLBOKPK(DGHDGHOFFPP MNFFANCCMAJ, HelmetHairStyle AHAOCIJAGJN, bool IEPNFLFDKME, AvatarItemBodyType FIIFEEIDAMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x80F35B0", Offset = "0x80F29B0", VA = "0x1880F35B0")]
		protected DGHDGHOFFPP GNDCCIIFKMA(IList<PNAMCIBEICH> GHAHLHKNCBG, AvatarItemBodyType GEDLLJCJOCO, bool IFDPADCJCEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x80F1D20", Offset = "0x80F1120", VA = "0x1880F1D20")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x80F1790", Offset = "0x80F0B90", VA = "0x1880F1790")]
		protected void CPKENHEOGAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x80F58B0", Offset = "0x80F4CB0", VA = "0x1880F58B0")]
		protected void JBPDPFOJPLJ(Transform OOKGLNKKGJM, IEnumerable<SkinnedMeshRenderer> HIOCMLNDCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x80F7140", Offset = "0x80F6540", VA = "0x1880F7140")]
		protected LFDPDKBANDC.JGFNEKKJIOP MCGMNBECKMF(LFDPDKBANDC.JGFNEKKJIOP EHENGOJIJNN, KMPAOABCDOI KDFKOMLMMNN)
		{
			return default(LFDPDKBANDC.JGFNEKKJIOP);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x80F64D0", Offset = "0x80F58D0", VA = "0x1880F64D0")]
		protected void KCPMIOGFLJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x1A570C0", Offset = "0x1A564C0", VA = "0x181A570C0")]
		protected void BODKHCHBBLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x80F5130", Offset = "0x80F4530", VA = "0x1880F5130")]
		protected void IGKEJMFJLKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x80F89A0", Offset = "0x80F7DA0", VA = "0x1880F89A0")]
		[AsyncStateMachine(typeof(PKJMNINJPGK))]
		protected Task PEKHNMMIJLJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x80F7780", Offset = "0x80F6B80", VA = "0x1880F7780")]
		protected static DEBFAPMLGFH NJAMCCMCOHJ(AOOGCGOBLKM KIPPCMLFNHG, int MNNPIADPAEN)
		{
			return default(DEBFAPMLGFH);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x80F0AB0", Offset = "0x80EFEB0", VA = "0x1880F0AB0")]
		protected static OOHKJCIIAKC BCFJFKGJFEP(AOOGCGOBLKM KIPPCMLFNHG, int MNNPIADPAEN)
		{
			return default(OOHKJCIIAKC);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x80F7730", Offset = "0x80F6B30", VA = "0x1880F7730")]
		protected Transform NDOGHECJIJI(KMPAOABCDOI FBBAOHEBJDH, OutfitType COHPPKDJCLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x80F64E0", Offset = "0x80F58E0", VA = "0x1880F64E0")]
		protected void KDHAJNJHLMI(int LGBNJHMFDIE, Material GMFBEMFEGJH, AOOGCGOBLKM KIPPCMLFNHG, [Out] Texture2D IJNGLJNKABE, [Out] Vector4 ACFEHOBHLBO, [Out] Texture2D CKCDOBLPNHE, [Out] Texture2D JFGMGCNKBNC, [Out] Texture2D OFCHNJALGAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x80F2390", Offset = "0x80F1790", VA = "0x1880F2390")]
		protected void DHMAFPJLDBF(int LGBNJHMFDIE, Material GMFBEMFEGJH, AOOGCGOBLKM KIPPCMLFNHG, [Out] Color JCOIDDADMCN, [Out] Color FPFBFOIJFNO, [Out] Color IPLGMAFIILM, [Out] Color ABKLKFDFLGF, [Out] Color HCKKIIOECHE, [Out] Color OPLMFPGAJNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x80F2F30", Offset = "0x80F2330", VA = "0x1880F2F30")]
		protected void GBCMGIMJDFA(Vector3 BKPAIEKHLGF, Quaternion GGEGPGBJIHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x80FA720", Offset = "0x80F9B20", VA = "0x1880FA720")]
		public void SetHatAnchorParameters(CHMLELHGCGH DDAEPEPEPKB, AnchorParamsRestrictions KIJNPJGMFNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x80F1840", Offset = "0x80F0C40", VA = "0x1880F1840")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere GBIHMAMJGHI, Transform JMFPNBKBHHI, CHMLELHGCGH DDAEPEPEPKB, AnchorParamsRestrictions EDDGGHDNFDN, [Out] Vector3 IPGNGMJBFOL, [Out] Quaternion JJPOMEGMBHP, [Out] CHMLELHGCGH DKMDLFAGDDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x80F9020", Offset = "0x80F8420", VA = "0x1880F9020")]
		public void ResetHatAnchor(Vector2 PPNAPIBMJDC, Vector3 CPNMEOJCCLA, Vector3 IEIKMFFPGJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xBC31E0", Offset = "0xBC25E0", VA = "0x180BC31E0")]
		public OKFOBIOPMDF GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x80F0190", Offset = "0x80EF590", VA = "0x1880F0190")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x80F02D0", Offset = "0x80EF6D0", VA = "0x1880F02D0")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x80F0100", Offset = "0x80EF500", VA = "0x1880F0100")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x80FBB10", Offset = "0x80FAF10", VA = "0x1880FBB10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x80F22C0", Offset = "0x80F16C0", VA = "0x1880F22C0")]
		protected void DHCCIJJPOLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x80FB8D0", Offset = "0x80FACD0", VA = "0x1880FB8D0")]
		public void SetWaitForUgcTextureLoads(bool LLLKJNKCIBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x80FB760", Offset = "0x80FAB60", VA = "0x1880FB760")]
		public void SetUgcTextureParameters(EGOGGADCJBA FGEMBJJOPFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x80FC9C0", Offset = "0x80FBDC0", VA = "0x1880FC9C0")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x80F70B0", Offset = "0x80F64B0", VA = "0x1880F70B0")]
		[CompilerGenerated]
		private void MCGMDAGJHAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x80F4E80", Offset = "0x80F4280", VA = "0x1880F4E80")]
		[CompilerGenerated]
		private void HIAAGJJNLKJ(LGPHGIJKOPM AFODJKLPGHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x80F0F30", Offset = "0x80F0330", VA = "0x1880F0F30")]
		[CompilerGenerated]
		private void BIIFKNAAEPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x80EFF70", Offset = "0x80EF370", VA = "0x1880EFF70")]
		[CompilerGenerated]
		private void APDDFPPLDAE(LGPHGIJKOPM AFODJKLPGHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x80F5470", Offset = "0x80F4870", VA = "0x1880F5470")]
		[CompilerGenerated]
		private void INOKILIAFOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x80F66E0", Offset = "0x80F5AE0", VA = "0x1880F66E0")]
		[CompilerGenerated]
		private void KDIIGCLJOPE(LGPHGIJKOPM AFODJKLPGHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x80F4A80", Offset = "0x80F3E80", VA = "0x1880F4A80")]
		[CompilerGenerated]
		private void HDMAGNLKFIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x80F1600", Offset = "0x80F0A00", VA = "0x1880F1600")]
		[CompilerGenerated]
		private void CLFPOLDMLCI(LGPHGIJKOPM AFODJKLPGHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x80F7200", Offset = "0x80F6600", VA = "0x1880F7200")]
		[CompilerGenerated]
		private void MCLNOJCPLCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x80F14D0", Offset = "0x80F08D0", VA = "0x1880F14D0")]
		[CompilerGenerated]
		private void CCCNODMAFAL(LGPHGIJKOPM AFODJKLPGHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x80F2FA0", Offset = "0x80F23A0", VA = "0x1880F2FA0")]
		[CompilerGenerated]
		private void GBDHAFMAMFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x80F6E90", Offset = "0x80F6290", VA = "0x1880F6E90")]
		[CompilerGenerated]
		private void LJDIAMEPIBB(LGPHGIJKOPM AFODJKLPGHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x80F1520", Offset = "0x80F0920", VA = "0x1880F1520")]
		[CompilerGenerated]
		internal static bool CCIHOJGALJC(Transform IKMFNBBEEBA, IEnumerable<SkinnedMeshRenderer> PBHEENPMGCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x80F8430", Offset = "0x80F7830", VA = "0x1880F8430")]
		[CompilerGenerated]
		private void OCAOFBDMIMH(LGPHGIJKOPM AFODJKLPGHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x80F6EB0", Offset = "0x80F62B0", VA = "0x1880F6EB0")]
		[CompilerGenerated]
		private void LKFJKIDLENL(LGPHGIJKOPM AFODJKLPGHF)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, FBNDMBMKCOM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct OAINCFPINIP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			public PKLMLDNJFKK avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x8105DC0", Offset = "0x81051C0", VA = "0x188105DC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x8106050", Offset = "0x8105450", VA = "0x188106050", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct MBPBCHIKLGE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400047B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400047C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400047D")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400047E")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400047F")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000480")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000481")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000482")]
			public AGMMOBNOCAG avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000483")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x81050E0", Offset = "0x81044E0", VA = "0x1881050E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x81052C0", Offset = "0x81046C0", VA = "0x1881052C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct JDJOCHEMJFP : IAsyncStateMachine
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
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			public AGMMOBNOCAG avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x81019A0", Offset = "0x8100DA0", VA = "0x1881019A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x8101B40", Offset = "0x8100F40", VA = "0x188101B40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct GMOLCIKAAFI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			public PKLMLDNJFKK avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x8100960", Offset = "0x80FFD60", VA = "0x188100960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x8100B10", Offset = "0x80FFF10", VA = "0x188100B10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct GBCHGOOIEEM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000490")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000491")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000492")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000493")]
			public AGMMOBNOCAG avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000494")]
			private TaskAwaiter<HJKDJMCMFJC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x81004C0", Offset = "0x80FF8C0", VA = "0x1881004C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x8100900", Offset = "0x80FFD00", VA = "0x188100900", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct IAOGONOBBDH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			public bool forceRebuild;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			public AGMMOBNOCAG avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x8100FD0", Offset = "0x81003D0", VA = "0x188100FD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x81013F0", Offset = "0x81007F0", VA = "0x1881013F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		protected const float ALALIBKGIGB = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		protected const int NLKJNKEDFMI = 5;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private static readonly int PNEFMJLBNAJ;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private static readonly int FJHOACILCEO;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private static readonly int EOFJJBNHMGO;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		protected static readonly Dictionary<MDHFABODAMJ.EKADEHHDLOB, int> ENMEDKMDGPP;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> NJIFAMJNLLH;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		protected static readonly int MKKDMCGKABM;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		protected static readonly int DFBAHPHIIAM;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		protected static readonly int FDHBJOOECCA;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		protected static readonly int DDDELGPNPBJ;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected static readonly int APMENOJOJGI;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		protected static Vector2 IPNNNEHFGFD;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		protected static Vector2 ENHGJHHIIJI;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected static Vector2 BKJOMHCFMCE;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		protected static Vector2 JMGKGOBNOFI;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected static Vector2 KOIOKDAHILK;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected static Vector2 KOGKCONKHBI;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected static Vector2 CKBIDNLPPIG;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected static Vector2 LDIKNFKIBNJ;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected static Vector2 HBDHHEOOJDH;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected static Vector2 LOPPIFKLJAB;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected static Vector2 JKAPBHBGFEE;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected static Vector2 DMKFGBEJEOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		[SerializeField]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		[Header("Rendering")]
		[SerializeField]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		[Header("Emotes")]
		[SerializeField]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		[SerializeField]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		[Header("Modern Avatar Facial Features")]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private AGMMOBNOCAG PJBIINOOEGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private FaceStyleSet IPICJOEDNKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x400043C")]
		protected const int GIBMFMIPGND = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		protected int GMFMABJEEFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected int OCHJCJOGNNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected int APDDNGEAHLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		protected int JEAKEPMDIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		protected Vector2 IGENDKHBHAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		protected float ICFOAGEJLMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		protected float KNHIOJOMOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		protected float JEEIHHPMNKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		protected Vector2 PACCIEAALDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		protected float AJHFNBGLIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected float GMMKLFFHMHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		protected float NKGADJOGLFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		protected Vector2 DBFNJOPMMJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		protected float CDPDIMOALKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		protected float GEBCIIKEAIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		protected float DFMFMEFPKLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		protected Vector2 DJDEPOJMIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		protected float CBLCOAANLFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		protected float HHDBPMJGFLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		protected float DBOOMAHCMLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		protected List<SelectableFaceOption> HFIOBHOLBDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		protected List<SelectableFaceOption> OHJJKFJGKGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		protected List<SelectableFaceOption> ILKPGDPLEFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		protected List<SelectableFaceOption> DKJIDOIGLFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		protected Coroutine CHBGELJPDDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		protected int? HNDKNOGBLNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		protected int FGEHDOPLJFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		protected int BJBFAFJKMJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		protected int GPIBFIAOAEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		protected int PAFHKIOJDOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		protected Sprite ONAJIJAEMOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		protected Sprite HFECHJBMMNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		protected Sprite OJOPJMIKCKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		protected Sprite DAIANKKLEEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		protected bool EONPHGFMIDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		protected string FFOPMLFAFJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		protected string PHKNMMDJJHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		protected string MEMGPFEKKNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		protected string IELJEJJLCLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		protected AvatarConfiguration LBFJECIDKKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		protected HJKDJMCMFJC OGDAOMHAECC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private readonly List<Material> IKFGHKGGANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		protected NCCBPEFIFKO JKBPEBGAAAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		protected Dictionary<string, int> HGENMBGEAFI;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public FaceStyleSet BICAKLNOKAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x810DD40", Offset = "0x810D140", VA = "0x18810DD40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public bool MDHGNPMONEF
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0xB094D0", Offset = "0xB088D0", VA = "0x180B094D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0xE24500", Offset = "0xE23900", VA = "0x180E24500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		protected virtual bool NNJKKOAPANK
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		protected virtual bool KABMEEGEANG
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		protected int HJFICGOAOCH
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x8108740", Offset = "0x8107B40", VA = "0x188108740")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public Renderer CHEAIMIKEIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool MMIGGMKKHNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x26DAC10", Offset = "0x26DA010", VA = "0x1826DAC10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x26D3860", Offset = "0x26D2C60", VA = "0x1826D3860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Renderer[] APLPDPBEFJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public bool NPHJIDAMPCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x810DD90", Offset = "0x810D190", VA = "0x18810DD90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x810DF50", Offset = "0x810D350", VA = "0x18810DF50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		protected int IGKJFNJCKLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x8107830", Offset = "0x8106C30", VA = "0x188107830")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		protected int IFLGPLGGNNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x8109E30", Offset = "0x8109230", VA = "0x188109E30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public float KJBODGGEBGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x810DD70", Offset = "0x810D170", VA = "0x18810DD70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x810DF30", Offset = "0x810D330", VA = "0x18810DF30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public JMOFGJBGKPC BHPNLPMDAGN
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0xB2F380", Offset = "0xB2E780", VA = "0x180B2F380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0xB2AC70", Offset = "0xB2A070", VA = "0x180B2AC70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public HJKDJMCMFJC FGCDEKNMMNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xB695B0", Offset = "0xB689B0", VA = "0x180B695B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x810DEB0", Offset = "0x810D2B0", VA = "0x18810DEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public NoseFaceOption JFOIPFJHLBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0xB4C180", Offset = "0xB4B580", VA = "0x180B4C180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0xBC4960", Offset = "0xBC3D60", VA = "0x180BC4960")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		protected NCCBPEFIFKO BNNJCPGAGDP
		{
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x810AC00", Offset = "0x810A000", VA = "0x18810AC00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action LJEDHEJNBAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x810DC90", Offset = "0x810D090", VA = "0x18810DC90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x810DE00", Offset = "0x810D200", VA = "0x18810DE00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x810A770", Offset = "0x8109B70", VA = "0x18810A770")]
		public void LocalPlayEmote(MDHFABODAMJ.EKADEHHDLOB APEKDOIGDIF, float GMIGDCOCEAL = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x81099F0", Offset = "0x8108DF0", VA = "0x1881099F0")]
		public bool IsEmotePlaying(MDHFABODAMJ.EKADEHHDLOB APEKDOIGDIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x810BBC0", Offset = "0x810AFC0", VA = "0x18810BBC0")]
		public void SetIdleHappy(bool EOIBGIICMHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x8108B00", Offset = "0x8107F00", VA = "0x188108B00")]
		protected void DDEBFBGKEBI(bool BMHKFPDLEMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x810B040", Offset = "0x810A440", VA = "0x18810B040")]
		protected void PINANAMPDNO(bool OCJDLCJMIGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x810AB90", Offset = "0x8109F90", VA = "0x18810AB90")]
		protected void OAOKGOGLAIB(KMPAOABCDOI FBBAOHEBJDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x8109DC0", Offset = "0x81091C0", VA = "0x188109DC0")]
		protected void KBHPFLMEDAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x810B290", Offset = "0x810A690", VA = "0x18810B290")]
		public void PlayExpression(int EHAKIDENOJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x810A9F0", Offset = "0x8109DF0", VA = "0x18810A9F0")]
		protected void MHPNLMLOEGL(bool KMIOBDIBDOB, bool KEFDCJADNCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x81093A0", Offset = "0x81087A0", VA = "0x1881093A0")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType CBLKAMBLIAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x81094C0", Offset = "0x81088C0", VA = "0x1881094C0")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration LBFJECIDKKL, AGMMOBNOCAG OEJHEOJFBIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x810B860", Offset = "0x810AC60", VA = "0x18810B860")]
		[AsyncStateMachine(typeof(OAINCFPINIP))]
		public Task SetFaceSettings(PKLMLDNJFKK GPPGDEEJAMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x810B950", Offset = "0x810AD50", VA = "0x18810B950")]
		[AsyncStateMachine(typeof(MBPBCHIKLGE))]
		public Task SetFaceSettings(int BJIKLLPMDGB, int JEDKMFLDDPO, int BNDMIHPAMNK, int DCFNFNLALBK, AGMMOBNOCAG OEJHEOJFBIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x810BC40", Offset = "0x810B040", VA = "0x18810BC40")]
		[AsyncStateMachine(typeof(JDJOCHEMJFP))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType CBLKAMBLIAL, int PJCHDKMLDCC, AGMMOBNOCAG OEJHEOJFBIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x810A870", Offset = "0x8109C70", VA = "0x18810A870")]
		protected void MFHHGLBIMOK(FaceFeatureType CBLKAMBLIAL, KDMFEBNOJJL PDMAEDKNMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x8109E90", Offset = "0x8109290", VA = "0x188109E90")]
		protected void KPDCIEAEAPC(FaceFeatureType CBLKAMBLIAL, int PJCHDKMLDCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x81091C0", Offset = "0x81085C0", VA = "0x1881091C0")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x810B1A0", Offset = "0x810A5A0", VA = "0x18810B1A0")]
		[AsyncStateMachine(typeof(GMOLCIKAAFI))]
		protected Task PPBMDGIPAPA(PKLMLDNJFKK GPPGDEEJAMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x8108EC0", Offset = "0x81082C0", VA = "0x188108EC0")]
		protected void GBEFHIMIAMC(PKLMLDNJFKK GPPGDEEJAMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x8108110", Offset = "0x8107510", VA = "0x188108110")]
		protected static void BBPHBOMJMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x8108870", Offset = "0x8107C70", VA = "0x188108870")]
		private void CPOAFHCNJDG(bool DFJNGONEEHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x81083B0", Offset = "0x81077B0", VA = "0x1881083B0")]
		protected void CHNPCGEDCNK(FaceFeatureType CBLKAMBLIAL, Vector2 MABBIFENMIM, AGMMOBNOCAG OEJHEOJFBIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x810B2B0", Offset = "0x810A6B0", VA = "0x18810B2B0")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType CBLKAMBLIAL, Vector2 OBDIJPMMKOF, AGMMOBNOCAG OEJHEOJFBIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x810A5F0", Offset = "0x81099F0", VA = "0x18810A5F0")]
		protected void LNINICBPGEH(FaceFeatureType CBLKAMBLIAL, float DAGPHMPCCAM, AGMMOBNOCAG OEJHEOJFBIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x8108D40", Offset = "0x8108140", VA = "0x188108D40")]
		protected void FBJOFDFPFHK(FaceFeatureType CBLKAMBLIAL, float EMLGDFFEJED, AGMMOBNOCAG OEJHEOJFBIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x8108B80", Offset = "0x8107F80", VA = "0x188108B80")]
		protected void DINEONAPGPJ(FaceFeatureType CBLKAMBLIAL, float PCBCGPHLMFJ, AGMMOBNOCAG OEJHEOJFBIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x810B640", Offset = "0x810AA40", VA = "0x18810B640")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType CBLKAMBLIAL, float GNCLHEAINIG, AGMMOBNOCAG OEJHEOJFBIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x81093E0", Offset = "0x81087E0", VA = "0x1881093E0")]
		[AsyncStateMachine(typeof(GBCHGOOIEEM))]
		protected Task IBPOFEKHMFL(AGMMOBNOCAG OEJHEOJFBIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x81097E0", Offset = "0x8108BE0", VA = "0x1881097E0")]
		public void InitializeFaceFeatureStyleSet(AGMMOBNOCAG OEJHEOJFBIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x810AAB0", Offset = "0x8109EB0", VA = "0x18810AAB0")]
		protected bool MNOEPEOPLJO(string BFMFJKOOLGF, [Out] int NOEININIMIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x8107FD0", Offset = "0x81073D0", VA = "0x188107FD0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x810BD50", Offset = "0x810B150", VA = "0x18810BD50", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x810AE30", Offset = "0x810A230", VA = "0x18810AE30")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x810CD40", Offset = "0x810C140", VA = "0x18810CD40")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x81082B0", Offset = "0x81076B0", VA = "0x1881082B0")]
		[AsyncStateMachine(typeof(IAOGONOBBDH))]
		public Task BuildFaceStyleAsyncIfChanged(AGMMOBNOCAG OEJHEOJFBIN, bool PFDJNAHLPGL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x810C650", Offset = "0x810BA50", VA = "0x18810C650")]
		public void UpdateFaceDisplays(bool JPDEKEPFNAJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x8107890", Offset = "0x8106C90", VA = "0x188107890")]
		protected bool AILKNNBDMMO(bool JPDEKEPFNAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x810C3B0", Offset = "0x810B7B0", VA = "0x18810C3B0")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x810BA80", Offset = "0x810AE80", VA = "0x18810BA80")]
		public void SetFaceSpriteIndices(string HIDEMLJAJJN, string HIIMNIALPIF, string AHJMAAKMMJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x810BD60", Offset = "0x810B160", VA = "0x18810BD60")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x810C870", Offset = "0x810BC70", VA = "0x18810C870")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x810CA60", Offset = "0x810BE60", VA = "0x18810CA60")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x8108C50", Offset = "0x8108050", VA = "0x188108C50")]
		protected void DMFLDBIIAEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x8109B10", Offset = "0x8108F10", VA = "0x188109B10")]
		private void JOKBIACNPPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x810AC80", Offset = "0x810A080", VA = "0x18810AC80")]
		private void OKPBKPFFPIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x810DA30", Offset = "0x810CE30", VA = "0x18810DA30")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xA9B060", Offset = "0xA9A460", VA = "0x180A9B060", Slot = "4")]
		private bool CPFAEMKBANH()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct NDKDIPEIGFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public string GODGCHFEMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public int NGBODNHEHKM;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[SelectionBase]
	[ExecuteInEditMode]
	public class PlayerModernBodyEditorAvatarValidator : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private struct ONBFMJHLIHK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004FD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004FE")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004FF")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000500")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x81060B0", Offset = "0x81054B0", VA = "0x1881060B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0xAC9F20", Offset = "0xAC9320", VA = "0x180AC9F20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private struct JCPEAODJIPP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000501")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000502")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000503")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000504")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x8101450", Offset = "0x8100850", VA = "0x188101450", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x8101940", Offset = "0x8100D40", VA = "0x188101940", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public AGMMOBNOCAG avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public ADHECDELIKB useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public CHMLELHGCGH hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public OKFOBIOPMDF HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public long baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
		[SerializeField]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private JOEBNIKPFHF IJCABILFNBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
		[SerializeField]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private AnimatorOverrideController EJMJFEFFCFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> NOCCLCNKIKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public readonly NDKDIPEIGFB[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public readonly (string, IFJFNEIBCED)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		protected bool FCEPOLLEEIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		protected Guid FFIIOBENOCP;

		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		protected static Guid LLJHCJKAKHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private CNJDPLBKGCC NOIKBNBAKOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private JMOFGJBGKPC LIIALFFJOHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		private JHCCFFGGMLF ACABEPPEDCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		private JHCCFFGGMLF HIHHDHGBINA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private AdditionalHatData GDJMKCBCHKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private readonly Dictionary<GameObject, OODLPBEANBG> JALOFLFDNCN;

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public static Func<NCNGPPGCAEP> HDKIPJMGKCB
		{
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x8113160", Offset = "0x8112560", VA = "0x188113160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x81137A0", Offset = "0x8112BA0", VA = "0x1881137A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public bool LACJOELBFDM
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x81132C0", Offset = "0x81126C0", VA = "0x1881132C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public bool LNKMCAPBNPA
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x81131B0", Offset = "0x81125B0", VA = "0x1881131B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public PlayerAvatarDisplayBase JJLPDDMFILA
		{
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0xBD0B90", Offset = "0xBCFF90", VA = "0x180BD0B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		protected static Guid ACNJHIKHKEC
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x810E0A0", Offset = "0x810D4A0", VA = "0x18810E0A0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public (GameObject, KMPAOABCDOI)[] FCBHBEPJGIH
		{
			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x81133D0", Offset = "0x81127D0", VA = "0x1881133D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x8110E30", Offset = "0x8110230", VA = "0x188110E30")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x810E720", Offset = "0x810DB20", VA = "0x18810E720")]
		private IEnumerable<GameObject> BEJKBJMDJHG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x8111350", Offset = "0x8110750", VA = "0x188111350")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x8110C70", Offset = "0x8110070", VA = "0x188110C70")]
		private void PJFDABCEAFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x14E5210", Offset = "0x14E4610", VA = "0x1814E5210")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x810FBD0", Offset = "0x810EFD0", VA = "0x18810FBD0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x8111360", Offset = "0x8110760", VA = "0x188111360")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x8111170", Offset = "0x8110570", VA = "0x188111170")]
		public void ShowPose(AnimationClip KJOOFEFGGOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x8111320", Offset = "0x8110720", VA = "0x188111320")]
		public void ShowPose(string IFCMKCNCBNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x8110FA0", Offset = "0x81103A0", VA = "0x188110FA0")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x8110E40", Offset = "0x8110240", VA = "0x188110E40")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8111E30", Offset = "0x8111230", VA = "0x188111E30")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x8111C80", Offset = "0x8111080", VA = "0x188111C80")]
		public void UpdateFaceAndBodyShapes(bool PFDJNAHLPGL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x8112240", Offset = "0x8111640", VA = "0x188112240")]
		public void UpdateNoseShape(BIBEJHBBCLK HKFNPLIFPCH, bool PFDJNAHLPGL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x8112210", Offset = "0x8111610", VA = "0x188112210")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x810F600", Offset = "0x810EA00", VA = "0x18810F600", Slot = "4")]
		protected virtual void IHHHANDKABL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x81104E0", Offset = "0x810F8E0", VA = "0x1881104E0", Slot = "5")]
		protected virtual void NDMDKGDDFAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x810E350", Offset = "0x810D750", VA = "0x18810E350")]
		public void ApplyHatData(AdditionalHatData PCJAPACKALF, bool ILOHMJHDMCM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x810E190", Offset = "0x810D590", VA = "0x18810E190")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x810E6B0", Offset = "0x810DAB0", VA = "0x18810E6B0")]
		public void ApplyHatUVOverride(Vector2 BHJMCFJLCLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x810E5D0", Offset = "0x810D9D0", VA = "0x18810E5D0")]
		public void ApplyHatPositionAdjustment(Vector3 ANPBPOAHKPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x810E640", Offset = "0x810DA40", VA = "0x18810E640")]
		public void ApplyHatRotationAdjustment(Vector3 KFJIJMGPEEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x810EBB0", Offset = "0x810DFB0", VA = "0x18810EBB0")]
		public PNAMCIBEICH BuildAvatarItemSelection(GameObject JCHHPKAFJDL, AGMMOBNOCAG NBLJOEEFODI, KMPAOABCDOI JNKOIGEJLAM)
		{
			return default(PNAMCIBEICH);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x810EC50", Offset = "0x810E050", VA = "0x18810EC50")]
		public void BuildAvatar(bool PFDJNAHLPGL = false, bool ILOHMJHDMCM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x81116C0", Offset = "0x8110AC0", VA = "0x1881116C0")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x810E2D0", Offset = "0x810D6D0", VA = "0x18810E2D0")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x8112060", Offset = "0x8111460", VA = "0x188112060")]
		public void UpdateHatAnchor(bool ILOHMJHDMCM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x8111D80", Offset = "0x8111180", VA = "0x188111D80")]
		[AsyncStateMachine(typeof(ONBFMJHLIHK))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x8110410", Offset = "0x810F810", VA = "0x188110410")]
		[AsyncStateMachine(typeof(JCPEAODJIPP))]
		private Task MFJJOAJBMLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x810F900", Offset = "0x810ED00", VA = "0x18810F900")]
		private void IOAHGKPDIMA(FaceFeatureType JEIPMELMMOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x8110380", Offset = "0x810F780", VA = "0x188110380")]
		private void MDDALEBBJIH(FaceFeatureType JEIPMELMMOO, [Out] float FMOJCDNJAFD, [Out] float FEHHOBJKBBH, [Out] float MJHAIBCGLLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x8111B40", Offset = "0x8110F40", VA = "0x188111B40")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x8111EC0", Offset = "0x81112C0", VA = "0x188111EC0")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x8110750", Offset = "0x810FB50", VA = "0x188110750")]
		private void PAGDGKFPMAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		private void KHGCIMIBPNM(OODLPBEANBG GGADLHDJPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		private void AJDCFJHPLKE(OODLPBEANBG GGADLHDJPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x810F280", Offset = "0x810E680", VA = "0x18810F280")]
		private void FFPKALMPDBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x81122D0", Offset = "0x81116D0", VA = "0x1881122D0")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x81102D0", Offset = "0x810F6D0", VA = "0x1881102D0")]
		[CompilerGenerated]
		private PNAMCIBEICH KCJFLNCLPNN((GameObject, KMPAOABCDOI) FLBCGLDJPHG)
		{
			return default(PNAMCIBEICH);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct PNAMCIBEICH
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class AOKKEBBINDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public AOKKEBBINDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF80", Offset = "0x80FE380", VA = "0x1880FEF80")]
		internal bool EDHOGMHNGGL(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	private OODLPBEANBG LIDPCNIMHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private KMPAOABCDOI MFOKGFJLIAE;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public OODLPBEANBG CPELFBAECAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public KMPAOABCDOI KCAKJCBNNEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xE62630", Offset = "0xE61A30", VA = "0x180E62630")]
		get
		{
			return default(KMPAOABCDOI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public string JGFCKBOAGNM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x8107740", Offset = "0x8106B40", VA = "0x188107740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool DFKGJAAKHKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x81076A0", Offset = "0x8106AA0", VA = "0x1881076A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool DHLDDJPAGGM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x81076F0", Offset = "0x8106AF0", VA = "0x1881076F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x1A68C90", Offset = "0x1A68090", VA = "0x181A68C90")]
	public PNAMCIBEICH(OODLPBEANBG GGADLHDJPJJ, KMPAOABCDOI FBBAOHEBJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x81075D0", Offset = "0x81069D0", VA = "0x1881075D0")]
	public bool ILJNPJBFFNH(OutfitType KDFOGAJIJOL, KMPAOABCDOI OMHCJGMCCHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x8107170", Offset = "0x8106570", VA = "0x188107170")]
	public bool DJAJBHHCBBF(OutfitType KDFOGAJIJOL, KMPAOABCDOI OMHCJGMCCHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x81073E0", Offset = "0x81067E0", VA = "0x1881073E0")]
	public bool GCCIDPPDCBN(PNAMCIBEICH INGAIOOGEGK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class OPENDNCDHIC
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class BLCJEHLLLLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public BLCJEHLLLLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x80FF070", Offset = "0x80FE470", VA = "0x1880FF070")]
		internal bool EDHOGMHNGGL(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private OODLPBEANBG LIDPCNIMHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private KDPIDKKOEEB MFOKGFJLIAE;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public OODLPBEANBG CPELFBAECAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public KDPIDKKOEEB KCAKJCBNNEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xAC6D20", Offset = "0xAC6120", VA = "0x180AC6D20")]
		get
		{
			return default(KDPIDKKOEEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Color LEHEPOAPIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xE25C30", Offset = "0xE25030", VA = "0x180E25C30")]
		[CompilerGenerated]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xE25AB0", Offset = "0xE24EB0", VA = "0x180E25AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 GGEGPGBJIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xE5D1F0", Offset = "0xE5C5F0", VA = "0x180E5D1F0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0xE5D330", Offset = "0xE5C730", VA = "0x180E5D330")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x8106780", Offset = "0x8105B80", VA = "0x188106780")]
	public OPENDNCDHIC(OODLPBEANBG GGADLHDJPJJ, KDPIDKKOEEB FBBAOHEBJDH, Color IFBOGFLAOGG, Vector3 EMLGDFFEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x8106650", Offset = "0x8105A50", VA = "0x188106650")]
	public bool GCCIDPPDCBN(OPENDNCDHIC INGAIOOGEGK)
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
