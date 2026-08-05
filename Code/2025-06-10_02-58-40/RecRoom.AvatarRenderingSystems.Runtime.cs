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
	public class LogRegistrationIndex : LALFEIIPPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7A97440", Offset = "0x7A96640", VA = "0x187A97440", Slot = "4")]
		public override void ELDCOJNOKAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
			[Cpp2IlInjected.Address(RVA = "0xA00F70", Offset = "0xA00170", VA = "0x180A00F70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7A978D0", Offset = "0x7A96AD0", VA = "0x187A978D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7A97860", Offset = "0x7A96A60", VA = "0x187A97860", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7A97890", Offset = "0x7A96A90", VA = "0x187A97890")]
		public RecNetCDNAssetReference(RecNetCDNKey MHDODBCCAJB)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum CEOOKOKNIGC : byte
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
			[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA00FA0", Offset = "0xA001A0", VA = "0x180A00FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA00F60", Offset = "0xA00160", VA = "0x180A00F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA01190", Offset = "0xA00390", VA = "0x180A01190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA00F90", Offset = "0xA00190", VA = "0x180A00F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA00D60", Offset = "0x9FFF60", VA = "0x180A00D60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA2F4A0", Offset = "0xA2E6A0", VA = "0x180A2F4A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA2F2C0", Offset = "0xA2E4C0", VA = "0x180A2F2C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public CEOOKOKNIGC PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xE1ACE0", Offset = "0xE19EE0", VA = "0x180E1ACE0")]
			[CompilerGenerated]
			get
			{
				return default(CEOOKOKNIGC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x13F8BB0", Offset = "0x13F7DB0", VA = "0x1813F8BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7A979E0", Offset = "0x7A96BE0", VA = "0x187A979E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7A97960", Offset = "0x7A96B60", VA = "0x187A97960")]
		public static RecNetCDNKey OEAINNNCJEM(string JOPIKMKIMLK, CEOOKOKNIGC HKLKNLKEAFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7A97910", Offset = "0x7A96B10", VA = "0x187A97910")]
		public void FOIEKDODCNK(string BOPICMAEOEP, string BNPHOCLLMDF, bool PDPGMDFJBLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CBAABKHKLJM]
public class FBPMONDCGGJ : JBNPEDILNFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<Mesh> MDILMOPBMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<byte[]> GJABBLJHPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<Matrix4x4> POGDBIBKMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly List<bool> AJDLAOOAMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly List<long> MPEEIAHIDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly List<bool> EADPPFHIOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected readonly List<int> AIDOGEHIAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected Allocator CCEOLDNPFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected NOBGMFFFENK KMGFAEFHDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected byte PPKLKCIBMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected IList<int> KJOFNDMBDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected IList<int> PEDMCGMMHKN;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7A86690", Offset = "0x7A85890", VA = "0x187A86690", Slot = "4")]
	public void POMOILGGHLC(Mesh CGGHHEJPJND, Matrix4x4 DCNPLECGNLB, byte[] DNMMKBFJLCI, bool FHBMOEKGMOE = false, OFCOHJLOKGA.PFHBFKIKAIN OJAHOPJGGLB = (OFCOHJLOKGA.PFHBFKIKAIN)0L, int CFHJKDFGINB = -1, bool CCMGIFBKPGO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7A86650", Offset = "0x7A85850", VA = "0x187A86650", Slot = "5")]
	public void CIKHGBKCNMK(Allocator DPAKHKILCMF, NOBGMFFFENK APBDIBODOHL, byte ANCHJFMGJJF, [Optional] IList<int> NFFPHFHDDIM, [Optional] IList<int> GMKKKMDDGNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7A863F0", Offset = "0x7A855F0", VA = "0x187A863F0")]
	private static void AMLOOBINJGJ(Mesh CGGHHEJPJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7A86A50", Offset = "0x7A85C50", VA = "0x187A86A50")]
	public FBPMONDCGGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[CBAABKHKLJM]
public struct EAAAEJNHDGK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public CGMIJCENLND AAOPDFFNCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public int MGMKIDCFOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public FIBGMAIPNPE CBEDGMEINNN;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7A84930", Offset = "0x7A83B30", VA = "0x187A84930", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[CBAABKHKLJM]
[NativeContainer]
public struct FIBGMAIPNPE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct OODIICHJIOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector3 JDAOFPICHGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector3 BNGNHOGLPHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector4 HGJENMIPHNG;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct OLDNCFBFLIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float EIDPMHAHAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float LPLFDEHLDEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float OLAMNJIIHIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float CBLCEGADMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte EPGIAEBNJLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public byte JJPNLEDIIIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public byte CJNKDONEGHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte OAKEKADHFMN;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct MKFDJOHDEHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half EIDPMHAHAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half LPLFDEHLDEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half OLAMNJIIHIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half CBLCEGADMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public byte EPGIAEBNJLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte JJPNLEDIIIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public byte CJNKDONEGHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public byte OAKEKADHFMN;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct JBBMOJDCHJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 NEMIFEKMDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 PPDHBFGNFCG;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct OAMEABPJBED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half4 NEMIFEKMDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 PPDHBFGNFCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 LHDNCILCIGL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct LDHOKBLDIHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half4 NEMIFEKMDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 PPDHBFGNFCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 LHDNCILCIGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 HGNEJNADCKF;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct LLIBBLGKCHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half4 NEMIFEKMDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public half2 PPDHBFGNFCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public half2 LHDNCILCIGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public half2 HGNEJNADCKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public half2 ADDODKILEJA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct HLACCKNHHII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float EIDPMHAHAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float LPLFDEHLDEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float OLAMNJIIHIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float CBLCEGADMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int EPGIAEBNJLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int JJPNLEDIIIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int CJNKDONEGHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int OAKEKADHFMN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct IJHEACHJBJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color NEMIFEKMDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 PPDHBFGNFCG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct MLEIHMNIGMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Color NEMIFEKMDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 PPDHBFGNFCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Vector2 LHDNCILCIGL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct KMNBOFKIFOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Color NEMIFEKMDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 PPDHBFGNFCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 LHDNCILCIGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 HGNEJNADCKF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct GMICLNBGJPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Color NEMIFEKMDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector2 PPDHBFGNFCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Vector2 LHDNCILCIGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Vector2 HGNEJNADCKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Vector2 ADDODKILEJA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool BDBONODKBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<OODIICHJIOK> MDOAPELANHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<JBBMOJDCHJN> DKPFIBDAAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<OAMEABPJBED> PDKCEPOONOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<LDHOKBLDIHO> LEHOCGFGMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<LLIBBLGKCHA> OAGMOBOPOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<MKFDJOHDEHI> NLKHFGEHKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<OLDNCFBFLIA> FCANPFBCKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<IJHEACHJBJP> FPLFFFEFNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<MLEIHMNIGMD> DBHCFAFOCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<KMNBOFKIFOH> BHPEGHNDKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<GMICLNBGJPD> CNPKJAPDNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<HLACCKNHHII> EKIKKGPAJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> PBNCLLEDHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> GFPFOIABOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> ACBBHPKCJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> DKMDAFJCAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> MCCANHPBFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> MLDJAFHKDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<int> IEKEDNBLGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<BoneWeight> BFPMJMDMEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> AJLJPILGNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool BFPADCOOCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool APNNLDCNEPI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int ALJOAPKCHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7A87E20", Offset = "0x7A87020", VA = "0x187A87E20")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7A87EB0", Offset = "0x7A870B0", VA = "0x187A87EB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int FIOMBAKCIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7A883B0", Offset = "0x7A875B0", VA = "0x187A883B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7A883A0", Offset = "0x7A875A0", VA = "0x187A883A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DJJGALIBLCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7A87F90", Offset = "0x7A87190", VA = "0x187A87F90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7A87EA0", Offset = "0x7A870A0", VA = "0x187A87EA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int LIEBBDCNLBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7A87E30", Offset = "0x7A87030", VA = "0x187A87E30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7A88F30", Offset = "0x7A88130", VA = "0x187A88F30")]
	public FIBGMAIPNPE(int GMJFFMENNPK, int AGGIEGFAOGI, int OIGGPEIKDKI, int HLMACCDDOJK, Allocator DPAKHKILCMF, int CHEBOLPODBG, EPJHOILJHCG CEMJFBPNDEH, bool BFPADCOOCEP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7A86CB0", Offset = "0x7A85EB0", VA = "0x187A86CB0")]
	public void AEMFEKFIMNG(int CMDFFDAPDIB, Vector3 JIKDBGFICJD, Vector3 KAMENFELAAB, Vector4 DACBPJEFOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7A883C0", Offset = "0x7A875C0", VA = "0x187A883C0")]
	public void NOGKDMGBPMA(int CMDFFDAPDIB, BoneWeight DHGFFDKKCHO, NativeSlice<byte> DNMMKBFJLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7A88BA0", Offset = "0x7A87DA0", VA = "0x187A88BA0")]
	public Color OINDDAFILCN(int CMDFFDAPDIB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7A87FA0", Offset = "0x7A871A0", VA = "0x187A87FA0")]
	public void LODEAJCJEJC(int CMDFFDAPDIB, Color NAGHCPKAEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7A887F0", Offset = "0x7A879F0", VA = "0x187A887F0")]
	public void OHFLNCLFBFI(byte IAILLMBJKGG, int CMDFFDAPDIB, Vector2 FCLFCHBNAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7A86CA0", Offset = "0x7A85EA0", VA = "0x187A86CA0")]
	public void ADDKIODCHGK(int CMDFFDAPDIB, int MDDOIPFDKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7A88ED0", Offset = "0x7A880D0", VA = "0x187A88ED0")]
	public bool PHNGJFPBAKO(int IAILLMBJKGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7A87EC0", Offset = "0x7A870C0", VA = "0x187A87EC0")]
	public void KFMAPECGKMB(int KIPJPILHJPL, int GJBFKFHLHKP, int CLBDAFJFHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7A86D40", Offset = "0x7A85F40", VA = "0x187A86D40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7A86FA0", Offset = "0x7A861A0", VA = "0x187A86FA0")]
	public Mesh GBJHLGAENMH([Optional] string KFEPLOPCKJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[NativeContainer]
[CBAABKHKLJM]
public struct CGMIJCENLND : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Mesh.MeshDataArray HAEGGHAJFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeArray<int> LFOAIHLHBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeArray<int> JDHLKINDLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeArray<BoneWeight> BFPMJMDMEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeArray<Matrix4x4> BKNJKAJLCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeArray<long> FCALLNMJNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeArray<byte> FEAAKNAGELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<int> PMAHPFHMMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<int> ONCDGNPAELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<sbyte> MOBMDHLEDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeArray<byte> BOOAPNHHIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<bool> CCMGIFBKPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<int> CFHJKDFGINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool BFPADCOOCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<int> NFPGPBMMJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private bool APNNLDCNEPI;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int KLAOPDHCOAK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7A83390", Offset = "0x7A82590", VA = "0x187A83390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int AINBIIOINFB
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7A83110", Offset = "0x7A82310", VA = "0x187A83110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int BMAALGMJNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7A833F0", Offset = "0x7A825F0", VA = "0x187A833F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int CIEHFLIEOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7A833A0", Offset = "0x7A825A0", VA = "0x187A833A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7A83120", Offset = "0x7A82320", VA = "0x187A83120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int ALJOAPKCHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7A833C0", Offset = "0x7A825C0", VA = "0x187A833C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7A833E0", Offset = "0x7A825E0", VA = "0x187A833E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int HFEMJEMBNBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7A833B0", Offset = "0x7A825B0", VA = "0x187A833B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7A83380", Offset = "0x7A82580", VA = "0x187A83380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NOBGMFFFENK IOBJEGKGPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7A83100", Offset = "0x7A82300", VA = "0x187A83100")]
		get
		{
			return default(NOBGMFFFENK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7A833D0", Offset = "0x7A825D0", VA = "0x187A833D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte HCHAMDEEEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7A83710", Offset = "0x7A82910", VA = "0x187A83710")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7A83720", Offset = "0x7A82920", VA = "0x187A83720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public EHECNMMECAK HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7A834C0", Offset = "0x7A826C0", VA = "0x187A834C0")]
		get
		{
			return default(EHECNMMECAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7A83730", Offset = "0x7A82930", VA = "0x187A83730")]
	public CGMIJCENLND(IList<Mesh> BGHCNANOBFN, IList<Matrix4x4> LAIGFCBJPGI, IList<bool> CCMGIFBKPGO, byte ANCHJFMGJJF, IList<byte[]> MGMOGPCHCKE, IList<long> NNNGKELPGJN, IList<bool> NBHJMAJIOAC, IList<int> CFHJKDFGINB, IList<int> NFFPHFHDDIM, IList<int> GOPHADMIFOE, Allocator DPAKHKILCMF, NOBGMFFFENK APBDIBODOHL, bool BFPADCOOCEP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7A832B0", Offset = "0x7A824B0", VA = "0x187A832B0")]
	public FIBGMAIPNPE EEGLGPLLDKG(Allocator DPAKHKILCMF, EPJHOILJHCG CEMJFBPNDEH)
	{
		return default(FIBGMAIPNPE);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7A83130", Offset = "0x7A82330", VA = "0x187A83130", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[CBAABKHKLJM]
public class PNKBDHGHODH : FBPMONDCGGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public bool IPKIFPFMHCL;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly ProfilerMarker JGPEBIJJIOL;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7A97550", Offset = "0x7A96750", VA = "0x187A97550")]
	public CGMIJCENLND GMPJKNPBJNP()
	{
		return default(CGMIJCENLND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7A97850", Offset = "0x7A96A50", VA = "0x187A97850")]
	public PNKBDHGHODH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct EHECNMMECAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Mesh.MeshData OAAGHLAMHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<BoneWeight> BFPMJMDMEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NativeSlice<byte> LDJDIAAKEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int OMFFNAHLJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Matrix4x4 BPMKOFLDDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public long BHMNEOJLJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeSlice<byte> DNMMKBFJLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public bool NHMANCHKECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public int JAEAOIMLFOO;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class HHHEDDCEHLP : KONLHIGFPIP
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class FKEBNAHNKFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public FNKGLCNJMMP avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public HHHEDDCEHLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public ABAHHGGDFBO buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Action<KeyValuePair<string, HLHLINEFKHE<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public FKEBNAHNKFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7A89B50", Offset = "0x7A88D50", VA = "0x187A89B50")]
		internal bool NBJEPCJBDFG(PNMBCADMOBD item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7A89B30", Offset = "0x7A88D30", VA = "0x187A89B30")]
		internal void MHOAKDEFNIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7A89B10", Offset = "0x7A88D10", VA = "0x187A89B10")]
		internal void MAKIINNPFAI(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7A89B30", Offset = "0x7A88D30", VA = "0x187A89B30")]
		internal void LDDLCOLCAOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7A89B10", Offset = "0x7A88D10", VA = "0x187A89B10")]
		internal void HLHOIPEECNJ(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7A89BA0", Offset = "0x7A88DA0", VA = "0x187A89BA0")]
		internal void NDEBJGOABID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7A89960", Offset = "0x7A88B60", VA = "0x187A89960")]
		internal void DOIFADFHKOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7A89A50", Offset = "0x7A88C50", VA = "0x187A89A50")]
		internal void HHKBHEDBFBC(Dictionary<string, HLHLINEFKHE<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7A89990", Offset = "0x7A88B90", VA = "0x187A89990")]
		internal void EGFLLBIGICL(KeyValuePair<string, HLHLINEFKHE<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0")]
		internal IFBEDABPFIF FGLCBGNHKOP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class BGHKHMAAFGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public FKEBNAHNKFJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public BGHKHMAAFGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7A83040", Offset = "0x7A82240", VA = "0x187A83040")]
		internal OKMAOIFMFDD JBJOFDGCCGL(int lod)
		{
			return default(OKMAOIFMFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class HOJOLPIPOHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public GFHJFJDJPFP<Dictionary<string, HLHLINEFKHE<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public HOJOLPIPOHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		internal GFHJFJDJPFP<Dictionary<string, HLHLINEFKHE<Texture2D>>> PEGMBNPKHGI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class APOMJECFMFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<ABAHHGGDFBO> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public APOMJECFMFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7A815C0", Offset = "0x7A807C0", VA = "0x187A815C0")]
		internal void CAMFMMHACKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class HKPLNAFCGOO : IEnumerator<NOFGPJFCPHG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private NOFGPJFCPHG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public HHHEDDCEHLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public List<EKBIOEBPKMG> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public List<ABAHHGGDFBO> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public Func<int, OKMAOIFMFDD> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public LFPOKDNGEGI materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private NOFGPJFCPHG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
		[DebuggerHidden]
		public HKPLNAFCGOO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7A96F30", Offset = "0x7A96130", VA = "0x187A96F30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7A971B0", Offset = "0x7A963B0", VA = "0x187A971B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class MMOADKIJJMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public BLOOIBLLBLO cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public MMOADKIJJMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xAEF820", Offset = "0xAEEA20", VA = "0x180AEF820")]
		internal void EIONFCBAPIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xD5B0C0", Offset = "0xD5A2C0", VA = "0x180D5B0C0")]
		internal void MGBBNFMLCKO(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class PAKAHDCNOLB
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
		public HHHEDDCEHLP <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public PAKAHDCNOLB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class JPBPDMKODAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public FIBGMAIPNPE defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public CGMIJCENLND defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public PAKAHDCNOLB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public JPBPDMKODAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7A97200", Offset = "0x7A96400", VA = "0x187A97200")]
		internal void OOAGOBKBCCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x1359970", Offset = "0x1358B70", VA = "0x181359970")]
		internal void HIOJHOMPFIA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class ABOPEJNPPAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public MENPPNAFOJB legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public HJAKFIHDEKG legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public PAKAHDCNOLB CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public ABOPEJNPPAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7A81380", Offset = "0x7A80580", VA = "0x187A81380")]
		internal void OGGAEANPLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x1369BA0", Offset = "0x1368DA0", VA = "0x181369BA0")]
		internal void AHHOFMKDIDE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OGFGOHEBCOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public IMAHPAJHFNK overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public OGFGOHEBCOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7A974D0", Offset = "0x7A966D0", VA = "0x187A974D0")]
		internal bool CJFFGAGBNEB(KeyValuePair<string, PNMBCADMOBD> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly EPHHEFDKGKL HGIHOMMKMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly EPHHEFDKGKL HPJFOEAIAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Dictionary<KGACCJNCEGJ, float> BIFLFDGMGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<FFNJLAPEAAH, float> CNKOGGNBHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<NHLAOOPBHOL, float> OBLJJLFOJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private IReadOnlyDictionary<string, BEFIILAILEC> LKOMJENBJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Dictionary<string, BEFIILAILEC> COBILCGNFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Dictionary<string, BEFIILAILEC> PFIHCILMINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Dictionary<string, BEFIILAILEC> FKGJONMBCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private CJGBLKOPNIO BCFHJCCJGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private CJGBLKOPNIO KFFGPNBKIPH;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static float FCDCNMJEPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool? OAANAJCBOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool? DBCEJEKACHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool? HIILLPIOMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool? NIJLIDBJPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private AvatarConfiguration PJEFOPFCEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Transform NOFHHPODCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private AvatarSkinAssetItem ANPJDGAMNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private AssetReference JMBEEDMBIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private GameObject FMNBMNDGGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private GameObject FGPFNLGKFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private SkinnedMeshRenderer KGGHMBAKGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private AvatarSkinnedMeshBoneOrderRemapsData KLLEGGAPGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Transform[] MOBHDOBILNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Matrix4x4[] LLPPHMBJJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Material EKKILLEJMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Material GLJOLNEOOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Material COOPBKKLOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Material FABCEFNGJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Shader KNICOLMCHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Shader OHKDODJAMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Animator AOMAHMLOFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Renderer[] CKBJDHDBALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private OFCOHJLOKGA.PFHBFKIKAIN NBMNDAGLIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private AvatarBodyPartShapesManager PNKECOINCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private IReadOnlyDictionary<string, Transform> JFNAILIBJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private AvatarFaceShapeData.ENMCEHJCIJG DFKAEDBGGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private AvatarBodyShapeData.INCJCHAHECF HKBBBHCDJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private BDJFFDNIHPO JFLBIGDDLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool BBCMEFDEGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11D")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool IJMFPCMGGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Color LLBNBEOGLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Color DHFPBFKJMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Color PJFLDOGEAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Color? BDHEMDHDDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Color? BOFJABBKMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private Color? LLCOIIPFOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private Color? FNHBMLCLINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Texture2D EJANELMMGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Texture2D FIAOPCMLBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[CanBeNull]
	private PNMBCADMOBD PMKCFHCNNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Texture AFLBHFJMOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Color MNEDAFAFHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public Dictionary<Renderer, LFPOKDNGEGI> POCFGBMADBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Dictionary<Renderer, LFPOKDNGEGI> KIKFGBAGIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Dictionary<string, List<LOPOPBAACAE>> JABLJAPLCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private Dictionary<string, List<LOPOPBAACAE>> PPGNLFLIHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly List<LCHNAMIBFHG> DBPNANLCJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly List<LCHNAMIBFHG> CKLPGCDPCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly List<LCHNAMIBFHG> PKGHBKGFIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly List<LCHNAMIBFHG> PGKHEEFLNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Dictionary<LOPOPBAACAE, Material> DOBMBBBJPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Dictionary<LOPOPBAACAE, Material> PLGJEIEDJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private SkinnedMeshRenderer[] JJOHAFHDGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private SkinnedMeshRenderer[] CELNPFHPIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private SkinnedMeshRenderer[] BMAJDMPNMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private SkinnedMeshRenderer[] EGEADMNCFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Dictionary<string, HLHLINEFKHE<Texture2D>> LBGFOFKCECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Dictionary<string, HLHLINEFKHE<Texture2D>> JHFLCPBMADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private AdditionalHatData MAFKBODEHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private AdditionalHatData AOLGAECKNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private HairData MFKLJHKDEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private HairData PKMGPLKKNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private BCHLBCJFNPL CLCMODAPKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool? CJHNDOAFKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private PositionAndRotation OGCDHIFDKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private Transform BDFBGBJMPML;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private Material CIIGCAMJCDJ;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Material PAMPAOFEFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private Dictionary<string, PNMBCADMOBD> DGHBOKCFBHD;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int NJICEPJPLGG;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int OAPKLNAHDAA;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int BFBIOGCMNHK;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int FDBEHLAHMCL;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int MMIPBIHFILL;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int DDOGHDBNNCP;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly int OHNOCBDFBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool NNGGCLPHGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private List<Action> DIENMGHHCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private BOPLBKOIMNN LPPMJHGKMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private SkinnedMeshRenderer[] DKJONLGBLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private int FJGLFOMDGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private bool BBHACFOMBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private int GHGGPEOCBFE;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public EPHHEFDKGKL PHKOIPEGNLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public EPHHEFDKGKL NDEJCADFKFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private IIOGDLIHHEO GKOIAJLIOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7A95C10", Offset = "0x7A94E10", VA = "0x187A95C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool BBLMJHAAKID
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7A923F0", Offset = "0x7A915F0", VA = "0x187A923F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool PMCKEEACLEK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7A940B0", Offset = "0x7A932B0", VA = "0x187A940B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool GJDNCOGCGND
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7A8DED0", Offset = "0x7A8D0D0", VA = "0x187A8DED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool PJKMOJAHOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7A94720", Offset = "0x7A93920", VA = "0x187A94720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public AvatarConfiguration IAOLBMPLGIO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA00370", Offset = "0x9FF570", VA = "0x180A00370", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool APHNCIJJOGN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7A90260", Offset = "0x7A8F460", VA = "0x187A90260")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7A925B0", Offset = "0x7A917B0", VA = "0x187A925B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Material CNEKGLAIIJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CA90", Offset = "0x7A8BC90", VA = "0x187A8CA90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Material KBFLKLOKPAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7A90C00", Offset = "0x7A8FE00", VA = "0x187A90C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool GBFJNBINHDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public HIEAKOJGBND JKDIFCDGINC
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2373790", Offset = "0x2372990", VA = "0x182373790", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(HIEAKOJGBND);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7A8ACB0", Offset = "0x7A89EB0", VA = "0x187A8ACB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Material LGFCKIBHAHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA90A30", Offset = "0xA8FC30", VA = "0x180A90A30", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public SkinnedMeshRenderer[] JJFDGPMHMPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x19F4B80", Offset = "0x19F3D80", VA = "0x1819F4B80", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Renderer[] EOIBOEPJCPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xB17C70", Offset = "0xB16E70", VA = "0x180B17C70", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool KBJOGPKOJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7A956C0", Offset = "0x7A948C0", VA = "0x187A956C0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public OFCOHJLOKGA.PFHBFKIKAIN JKIBGPBECNM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA89C20", Offset = "0xA88E20", VA = "0x180A89C20", Slot = "20")]
		get
		{
			return default(OFCOHJLOKGA.PFHBFKIKAIN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int FJIENIKJNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x121B5A0", Offset = "0x121A7A0", VA = "0x18121B5A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7A900D0", Offset = "0x7A8F2D0", VA = "0x187A900D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool GOFMKIGLDMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7A90B80", Offset = "0x7A8FD80", VA = "0x187A90B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private static bool IDGLLAIJABL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7A960F0", Offset = "0x7A952F0", VA = "0x187A960F0", Slot = "15")]
	public ABAHHGGDFBO PLBDGIFEOAD(FNKGLCNJMMP AADNIMCCGHH, bool KPBGNFHBGEF, int[] OMLNPHJACGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7A95910", Offset = "0x7A94B10", VA = "0x187A95910", Slot = "14")]
	public ABAHHGGDFBO OLGJOGHAEGN(FNKGLCNJMMP AADNIMCCGHH, bool KPBGNFHBGEF, int[] OMLNPHJACGI, Func<Dictionary<string, PNMBCADMOBD>, (ABAHHGGDFBO, GFHJFJDJPFP<Dictionary<string, HLHLINEFKHE<Texture2D>>>)> CBMKHBLIFLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7A8E1E0", Offset = "0x7A8D3E0", VA = "0x187A8E1E0")]
	public ABAHHGGDFBO ECCNJMKHHDF(FNKGLCNJMMP AADNIMCCGHH, bool KPBGNFHBGEF, int[] OMLNPHJACGI, bool BKODEJPMOID, CJGBLKOPNIO CPGADMJIHAH, [Optional] Func<Dictionary<string, PNMBCADMOBD>, (ABAHHGGDFBO, GFHJFJDJPFP<Dictionary<string, HLHLINEFKHE<Texture2D>>>)> CBMKHBLIFLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7A94C20", Offset = "0x7A93E20", VA = "0x187A94C20")]
	private bool NCONLJCPCBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7A91C60", Offset = "0x7A90E60", VA = "0x187A91C60")]
	private ABAHHGGDFBO IDDOCOKDIME(bool KPBGNFHBGEF, List<EKBIOEBPKMG> HDLBCNGIKKE, int[] OMLNPHJACGI, Func<int, OKMAOIFMFDD> ABNCFANPADI, bool BKODEJPMOID = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7A90A60", Offset = "0x7A8FC60", VA = "0x187A90A60")]
	[IteratorStateMachine(typeof(HKPLNAFCGOO))]
	private IEnumerator<NOFGPJFCPHG> GGFMBIBKCMN(bool KPBGNFHBGEF, List<EKBIOEBPKMG> HDLBCNGIKKE, int[] OMLNPHJACGI, Func<int, OKMAOIFMFDD> ABNCFANPADI, LFPOKDNGEGI FDBGOGINECP, Material ILLMPLHNFFF, List<ABAHHGGDFBO> JEHJCABOHEG, bool EHEHMOJDJMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7A93440", Offset = "0x7A92640", VA = "0x187A93440")]
	private void LHHOFFHCOKH(List<EKBIOEBPKMG> HDLBCNGIKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7A952D0", Offset = "0x7A944D0", VA = "0x187A952D0")]
	private ABAHHGGDFBO NLIMNDLIPAA(List<EKBIOEBPKMG> HDLBCNGIKKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7A8CC30", Offset = "0x7A8BE30", VA = "0x187A8CC30")]
	private AFABIGEDGFJ DFPPDEFFPKD(List<EKBIOEBPKMG> HDLBCNGIKKE, int AEABCPDILIB, bool KPBGNFHBGEF, OKMAOIFMFDD BMDFOPHBMNP, bool CHJHCLFDMKI, LFPOKDNGEGI FDBGOGINECP, Material ILLMPLHNFFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7A95830", Offset = "0x7A94A30", VA = "0x187A95830", Slot = "27")]
	public void OJBJMEAMGLN(KGACCJNCEGJ GHAHJIAABMF, float KJIOHKMJAPE, bool CEDCAMKNBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7A96120", Offset = "0x7A95320", VA = "0x187A96120", Slot = "29")]
	public void PLEPBFCFLLD(FFNJLAPEAAH HLPNHJOANIK, float KJIOHKMJAPE, bool GLCMJMLHLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7A92C80", Offset = "0x7A91E80", VA = "0x187A92C80", Slot = "30")]
	public void JGBMPODEHFN(NHLAOOPBHOL NMKKJBELNLF, float KJIOHKMJAPE, bool KHEDMEHLNLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7A92880", Offset = "0x7A91A80", VA = "0x187A92880", Slot = "28")]
	public void IPALHFKIPKP(bool EOIKCNEEDGA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7A8FE70", Offset = "0x7A8F070", VA = "0x187A8FE70", Slot = "31")]
	public void EDPNIPIAPGJ(bool EOIKCNEEDGA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7A927A0", Offset = "0x7A919A0", VA = "0x187A927A0", Slot = "32")]
	public void ILGEPPGBDDA(bool EOIKCNEEDGA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7A94030", Offset = "0x7A93230", VA = "0x187A94030")]
	private void LOKGCJPCMJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7A91A90", Offset = "0x7A90C90", VA = "0x187A91A90")]
	private void HLDHLDJPDAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7A94D90", Offset = "0x7A93F90", VA = "0x187A94D90")]
	private void NGLJFDMLAKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7A90CF0", Offset = "0x7A8FEF0", VA = "0x187A90CF0", Slot = "25")]
	public void GIOANOCMBPC(AvatarFaceShape NEAIGBOFLLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7A89C00", Offset = "0x7A88E00", VA = "0x187A89C00", Slot = "26")]
	public void ABJLIDNIDLD(AvatarBodyShape NBHBLOFAGDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xB16F20", Offset = "0xB16120", VA = "0x180B16F20", Slot = "33")]
	public void DALMCDANEBG(BDJFFDNIHPO CHPDFJOFFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7A94EF0", Offset = "0x7A940F0", VA = "0x187A94EF0", Slot = "35")]
	public void NKFDJJEAHEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7A96200", Offset = "0x7A95400", VA = "0x187A96200", Slot = "39")]
	public void PLIEBMKPLIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7A8CA80", Offset = "0x7A8BC80", VA = "0x187A8CA80", Slot = "34")]
	public void CPBDCHEKGGJ(bool BHPLJHDNKEK, bool KOPMEOMCANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7A91B10", Offset = "0x7A90D10", VA = "0x187A91B10")]
	private void HOGGHGHIIED(SkinnedMeshRenderer BMJPCOAIKEC, int AEABCPDILIB, Mesh CGGHHEJPJND, List<Material> CCLFAEDKHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7A91820", Offset = "0x7A90A20", VA = "0x187A91820")]
	private static Material HDGHGCGFKOB(Dictionary<LOPOPBAACAE, Material> JLFNPKMGHJJ, Material FMIIFBCPDFC, DAOBKDMIGNE FOKAHLNIEMH, FKFIKCFFCEO EBFFCEPFLBJ, IMAHPAJHFNK IJFIDCOKOEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7A8DD40", Offset = "0x7A8CF40", VA = "0x187A8DD40")]
	private static DAOBKDMIGNE DHJCHBPEHKA(EKBIOEBPKMG HFCGEIPNKJB, int MDGNJPMMNIF)
	{
		return default(DAOBKDMIGNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7A8B580", Offset = "0x7A8A780", VA = "0x187A8B580")]
	private void BPLJAHFEEDD(int MHMJFLDMNFM, Material ADKDGJDNNAD, EKBIOEBPKMG HFCGEIPNKJB, [Out] Texture2D PLCBIDGIMLL, [Out] Vector4 CJMMAKEMNBN, [Out] Texture2D MLOEKCPILFC, [Out] Texture2D CCIBLEILBHE, [Out] Texture2D FHHLJKDEEKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7A8B040", Offset = "0x7A8A240", VA = "0x187A8B040")]
	private void BNAADIOHHMF(int MHMJFLDMNFM, Material ADKDGJDNNAD, EKBIOEBPKMG HFCGEIPNKJB, [Out] Color OOAACLAMGKN, [Out] Color IAGDMFKAEKM, [Out] Color DGPIDCHBFIL, [Out] Color BLGNDOHMHGF, [Out] Color EOMHOBIIELH, [Out] Color ABKNPJOBOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7A94800", Offset = "0x7A93A00", VA = "0x187A94800")]
	private bool MHBJAJKGHKL(Material ADKDGJDNNAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7A95C80", Offset = "0x7A94E80", VA = "0x187A95C80")]
	private static Material PDLJFLHLHPL(int MHMJFLDMNFM, DEGLECBDCKK HFCGEIPNKJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7A96350", Offset = "0x7A95550", VA = "0x187A96350")]
	private static FKFIKCFFCEO PLJFPILMIEB(EKBIOEBPKMG HFCGEIPNKJB, int MDGNJPMMNIF)
	{
		return default(FKFIKCFFCEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7A95940", Offset = "0x7A94B40", VA = "0x187A95940")]
	private static void ONLPEIBFEJN(Dictionary<string, List<LOPOPBAACAE>> ABMKJAEMGBO, EKBIOEBPKMG DNFFJPLECHG, Material FMIIFBCPDFC, DAOBKDMIGNE DBDFKFEEDLP, FKFIKCFFCEO LBHPCBIADNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7A8DFB0", Offset = "0x7A8D1B0", VA = "0x187A8DFB0")]
	private static SkinnedMeshRenderer DPKHFHDDAKJ(Transform CDIJNBKJPBK, Transform JIDCCEIDIHF, SkinnedMeshRenderer[] NMHABIBPCAP, int AEABCPDILIB, OKMAOIFMFDD BMDFOPHBMNP, bool KPBGNFHBGEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7A96580", Offset = "0x7A95780", VA = "0x187A96580")]
	public HHHEDDCEHLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7A89D20", Offset = "0x7A88F20", VA = "0x187A89D20")]
	public void AFLILFPIJAH([In] DJKPMFCPPPN JPGHBKIFILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7A91980", Offset = "0x7A90B80", VA = "0x187A91980")]
	public void NHBKNEGAGFE([In] CDCNBGOLNIK NDMGCCGDIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7A900D0", Offset = "0x7A8F2D0", VA = "0x187A900D0", Slot = "5")]
	public void EPLAEOFHCFF(int AEABCPDILIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7A8FED0", Offset = "0x7A8F0D0", VA = "0x187A8FED0", Slot = "10")]
	public void EODBBEFBNLE(FENAFGNFMMH LBHPCBIADNN, Texture2D NANHFKKMKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570")]
	public static bool KNGKNOCFHNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7A900F0", Offset = "0x7A8F2F0", VA = "0x187A900F0", Slot = "11")]
	public bool EPOHJGPOHDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7A93AA0", Offset = "0x7A92CA0", VA = "0x187A93AA0", Slot = "9")]
	public void LINPJBKGDNE(GBPFKAICOIN DBDFKFEEDLP, Color? NEMIFEKMDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7A924D0", Offset = "0x7A916D0", VA = "0x187A924D0")]
	private void IGKEAKABALD(Action HKKAJOLOGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7A94CF0", Offset = "0x7A93EF0", VA = "0x187A94CF0", Slot = "6")]
	public void NDFHONBMPHC(PNMBCADMOBD NFABKHIKACP, Texture BJNLCCOJPGB, Color ANGGEBMNOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7A925B0", Offset = "0x7A917B0", VA = "0x187A925B0", Slot = "7")]
	public void IJFACHOHHOO(bool EHEHMOJDJMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D296B0", Offset = "0x1D288B0", VA = "0x181D296B0", Slot = "8")]
	public void IMIGPCKCNND(BOPLBKOIMNN AJLJPILGNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7A8AA20", Offset = "0x7A89C20", VA = "0x187A8AA20", Slot = "16")]
	public void AJLHFJKFAIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7A89CC0", Offset = "0x7A88EC0", VA = "0x187A89CC0", Slot = "36")]
	public void ABMJMEINPAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7A8BAF0", Offset = "0x7A8ACF0", VA = "0x187A8BAF0", Slot = "37")]
	public void CCOLOEHCFND([Optional] BCHLBCJFNPL KFGJHKKPMNP, [Optional] bool? PNMEILKOIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7A92D70", Offset = "0x7A91F70", VA = "0x187A92D70")]
	private bool JNACJAONPOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7A93EA0", Offset = "0x7A930A0", VA = "0x187A93EA0", Slot = "21")]
	public bool LIONKMPEFEI(OFCOHJLOKGA.PFHBFKIKAIN MMNCICHGLOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7A928E0", Offset = "0x7A91AE0", VA = "0x187A928E0", Slot = "38")]
	public void JAAKKNMHJPO(float PONNOGKMBDD, Color NEMIFEKMDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7A8AF30", Offset = "0x7A8A130", VA = "0x187A8AF30")]
	private static bool BHICCFAHCKC(Material ILLMPLHNFFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7A92EB0", Offset = "0x7A920B0", VA = "0x187A92EB0")]
	private void KAOCJEFGCLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7A93400", Offset = "0x7A92600", VA = "0x187A93400")]
	private void LBGKMKDPKBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7A90DB0", Offset = "0x7A8FFB0", VA = "0x187A90DB0")]
	private static void GJOKIDFDDNB(Dictionary<LOPOPBAACAE, Material> JLFNPKMGHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7A941A0", Offset = "0x7A933A0", VA = "0x187A941A0")]
	private static void MDFAPIGKCPI(Dictionary<Renderer, LFPOKDNGEGI> IHNJNLPDLNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7A92240", Offset = "0x7A91440", VA = "0x187A92240")]
	private void IDIMDADBGEB(SkinnedMeshRenderer[] NMHABIBPCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7A90760", Offset = "0x7A8F960", VA = "0x187A90760")]
	private void FOMBJAJPCDG(SkinnedMeshRenderer DNCAJBICKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7A925C0", Offset = "0x7A917C0", VA = "0x187A925C0")]
	private void ILEHBHHHADN(List<LCHNAMIBFHG> GFDBOJJNEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7A90270", Offset = "0x7A8F470", VA = "0x187A90270")]
	private void FFENHILALJE(Dictionary<string, HLHLINEFKHE<Texture2D>> ABMKJAEMGBO, bool DPDNGKGLEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7A94E10", Offset = "0x7A94010", VA = "0x187A94E10")]
	private void NJOJPIFJGJH(Dictionary<string, List<LOPOPBAACAE>> ABMKJAEMGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7A90610", Offset = "0x7A8F810", VA = "0x187A90610")]
	private void FNJFELHKEDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7A95520", Offset = "0x7A94720", VA = "0x187A95520")]
	private void NOBAJCHEAKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7A8A090", Offset = "0x7A89290", VA = "0x187A8A090")]
	private void AFMNMGIJEOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7A95CD0", Offset = "0x7A94ED0", VA = "0x187A95CD0")]
	private void PDPAHNEIEHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7A94E60", Offset = "0x7A94060", VA = "0x187A94E60")]
	private void NKEEKCBKMMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7A8C930", Offset = "0x7A8BB30", VA = "0x187A8C930")]
	private void CGHCOAPBCDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7A8AEB0", Offset = "0x7A8A0B0", VA = "0x187A8AEB0")]
	private void BGNHINOOHMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7A90800", Offset = "0x7A8FA00", VA = "0x187A90800")]
	private void FPCMJALFMDH(bool HLIGHKHHHKL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7A92800", Offset = "0x7A91A00", VA = "0x187A92800")]
	private void INJMICALPCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7A94B40", Offset = "0x7A93D40", VA = "0x187A94B40")]
	private void MPEFLLHLPJI(bool HLIGHKHHHKL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7A95DA0", Offset = "0x7A94FA0", VA = "0x187A95DA0")]
	private void PFLNMABLEBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7A91150", Offset = "0x7A90350", VA = "0x187A91150")]
	private void HAFHDLOBOBC(Material ILLMPLHNFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7A93EC0", Offset = "0x7A930C0", VA = "0x187A93EC0")]
	private void LOHPMEKFJNI(Material ILLMPLHNFFF, Color NKNGBDFNEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7A90F10", Offset = "0x7A90110", VA = "0x187A90F10")]
	private void GKAPNNPCEIK(Material ILLMPLHNFFF, Color NKNGBDFNEBI, Color FPHJIBHLLML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7A90480", Offset = "0x7A8F680", VA = "0x187A90480")]
	private void FLKBGNCHAIL(Material ILLMPLHNFFF, Color OOAACLAMGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7A91630", Offset = "0x7A90830", VA = "0x187A91630")]
	private void HCKLHPBBKAL(Material ILLMPLHNFFF, Texture2D NANHFKKMKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7A8ACC0", Offset = "0x7A89EC0", VA = "0x187A8ACC0")]
	private void AMKHNGMJHIO(Material ILLMPLHNFFF, Texture DOOOEHKMAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7A8B990", Offset = "0x7A8AB90", VA = "0x187A8B990")]
	private void CBEFAAAFPCM(Action<LFPOKDNGEGI> HGHFFKHECAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7A908E0", Offset = "0x7A8FAE0", VA = "0x187A908E0")]
	private void GFNHGIOOIIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7A94300", Offset = "0x7A93500", VA = "0x187A94300")]
	private void MDJPFAFCHKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7A8A650", Offset = "0x7A89850", VA = "0x187A8A650")]
	private void AGOPFNIBJIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7A93070", Offset = "0x7A92270", VA = "0x187A93070")]
	public void KJDPBGHEDFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7A91980", Offset = "0x7A90B80", VA = "0x187A91980", Slot = "4")]
	private void HDMDLFNPHJB([In] CDCNBGOLNIK NDMGCCGDIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7A93A60", Offset = "0x7A92C60", VA = "0x187A93A60")]
	[CompilerGenerated]
	private IFBEDABPFIF LIEBGEDGDKM(EKBIOEBPKMG AGIIBANJIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7A91A00", Offset = "0x7A90C00", VA = "0x187A91A00")]
	[CompilerGenerated]
	private void HGADCNCDAEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7A960C0", Offset = "0x7A952C0", VA = "0x187A960C0")]
	[CompilerGenerated]
	private void PGDGBLKJOAL(LFPOKDNGEGI DOBJPBPKAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7A94AB0", Offset = "0x7A93CB0", VA = "0x187A94AB0")]
	[CompilerGenerated]
	private void MJOKDFIDHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7A94A90", Offset = "0x7A93C90", VA = "0x187A94A90")]
	[CompilerGenerated]
	private void MIGPNDOJPMH(LFPOKDNGEGI DOBJPBPKAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7A8AC20", Offset = "0x7A89E20", VA = "0x187A8AC20")]
	[CompilerGenerated]
	private void AKIPCELDMMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7A92C60", Offset = "0x7A91E60", VA = "0x187A92C60")]
	[CompilerGenerated]
	private void JCDPPCDNBJK(LFPOKDNGEGI DOBJPBPKAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7A903F0", Offset = "0x7A8F5F0", VA = "0x187A903F0")]
	[CompilerGenerated]
	private void FGCGDAHAACL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7A8B010", Offset = "0x7A8A210", VA = "0x187A8B010")]
	[CompilerGenerated]
	private void BKGIIIPNEGA(LFPOKDNGEGI DOBJPBPKAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7A8DE40", Offset = "0x7A8D040", VA = "0x187A8DE40")]
	[CompilerGenerated]
	private void DHJJOBCCKPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7A94A60", Offset = "0x7A93C60", VA = "0x187A94A60")]
	[CompilerGenerated]
	private void MIGEJMKHDOH(LFPOKDNGEGI DOBJPBPKAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7A92360", Offset = "0x7A91560", VA = "0x187A92360")]
	[CompilerGenerated]
	private void IEEFPOLNNPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7A94D60", Offset = "0x7A93F60", VA = "0x187A94D60")]
	[CompilerGenerated]
	private void NEFHDMMNLGM(LFPOKDNGEGI DOBJPBPKAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7A8AE20", Offset = "0x7A8A020", VA = "0x187A8AE20")]
	[CompilerGenerated]
	private void BCPMJKACALG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7A95BE0", Offset = "0x7A94DE0", VA = "0x187A95BE0")]
	[CompilerGenerated]
	private void ONPKMNBMIMN(LFPOKDNGEGI DOBJPBPKAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7A8B500", Offset = "0x7A8A700", VA = "0x187A8B500")]
	[CompilerGenerated]
	private void BPJMHNMEBJN(KeyValuePair<string, HLHLINEFKHE<Texture2D>> MEENFPJJIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7A94190", Offset = "0x7A93390", VA = "0x187A94190")]
	[CompilerGenerated]
	private void MAAIKPFPOMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7A93410", Offset = "0x7A92610", VA = "0x187A93410")]
	[CompilerGenerated]
	private void LDOMEBAIEHG(LFPOKDNGEGI DOBJPBPKAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7A956B0", Offset = "0x7A948B0", VA = "0x187A956B0")]
	[CompilerGenerated]
	private void NOFEIBHLIGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7A89BD0", Offset = "0x7A88DD0", VA = "0x187A89BD0")]
	[CompilerGenerated]
	private void AAJKEBKHBLB(LFPOKDNGEGI DOBJPBPKAEF)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AvatarElbowBendHelperController : MonoBehaviour, IHEOBAFNGIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[GBCGIPBAICF(CFJMFGLCHFI.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		[Header("Scale")]
		[FormerlySerializedAs("MinScaleValues")]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[SerializeField]
		[FormerlySerializedAs("MaxScaleValues")]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[Header("Positional Offset")]
		[SerializeField]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[SerializeField]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private Vector3? FEGNONFHCBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private bool GONLFMKEDNJ;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7A816F0", Offset = "0x7A808F0", VA = "0x187A816F0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7A81D10", Offset = "0x7A80F10", VA = "0x187A81D10", Slot = "4")]
		public void UpdateController(float IDFEGEHLHMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xCAD1E0", Offset = "0xCAC3E0", VA = "0x180CAD1E0", Slot = "6")]
		public void SetEnabled(bool KJIOHKMJAPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7A817D0", Offset = "0x7A809D0", VA = "0x187A817D0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7A821D0", Offset = "0x7A813D0", VA = "0x187A821D0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarElbowBendTargetController : MonoBehaviour, IHEOBAFNGIE
	{
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private const float PANMHOGJLCC = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[GBCGIPBAICF(CFJMFGLCHFI.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private Vector3 BBIPOAIKJDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private Vector3 JBKEDPJKMJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private bool GONLFMKEDNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private float KKFJAFKALMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private float LEALOMHOBII;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7A82550", Offset = "0x7A81750", VA = "0x187A82550", Slot = "4")]
		public void UpdateController(float IDFEGEHLHMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xEE30D0", Offset = "0xEE22D0", VA = "0x180EE30D0", Slot = "6")]
		public void SetEnabled(bool KJIOHKMJAPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7A82270", Offset = "0x7A81470", VA = "0x187A82270")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7A83010", Offset = "0x7A82210", VA = "0x187A83010")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class MEHBOADMAFE : FHHGLMCDKMP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly int NCHBMPJFAPO;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly int CAFCFMEFOII;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly int JFGEHFGFFLI;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly int OHFNFBIKFOE;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly int OHFHGNNEIKF;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly int NONCDPAAFKN;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly int DPGJDAAMKDL;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly int GDCPHACELEJ;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly int PCNODIAPMCK;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly int DBHBLJGGMIN;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly int JFIFMAAHMFJ;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly int LEDBGDLDNEI;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly int HNJPAOJMMDD;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly int ABCDGGHEDBI;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private static readonly int BMAJOBMNKOG;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private static readonly int DBMPANDDGDL;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static readonly int EJCHGGIKBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private Transform IOCEJAHFMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private Transform MDKLCIIODGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private Transform OMNKJCAAGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private Transform IDFFFPANJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Transform LAMDJMPIDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private Transform NPDHPPPONBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private MEDIGFACOAP ENPNGFLEGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private Material MNPKNFPNAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private SkinnedMeshRenderer[] MAJINKLEKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private readonly List<Material> CKMIOJBGHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private KCINHAKCDKJ EAENKMPBKFA;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public EPHHEFDKGKL HFDJCMNPMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private KCINHAKCDKJ NECGLJHNAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7AA8550", Offset = "0x7AA7750", VA = "0x187AA8550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool CFMEGCKFFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7AA8670", Offset = "0x7AA7870", VA = "0x187AA8670", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7AA70C0", Offset = "0x7AA62C0", VA = "0x187AA70C0")]
	public void AFLILFPIJAH([In] MEDIGFACOAP MAMIMJLJFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7AA85D0", Offset = "0x7AA77D0", VA = "0x187AA85D0")]
	public void IMKKOMIEJPB([In] ADLDHGFBDOG HDDLIPCPJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7AA87D0", Offset = "0x7AA79D0", VA = "0x187AA87D0", Slot = "6")]
	public void JGPFFLJIODK(KFMCNMACHEH DADJAGHLKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7AA8CE0", Offset = "0x7AA7EE0", VA = "0x187AA8CE0")]
	private Vector2 KBIDLCMNONJ(Vector2 NNDJHMBLLBE)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7AA7170", Offset = "0x7AA6370", VA = "0x187AA7170")]
	public void CGMGBFIELHN([In] LDNPDDIOLGB HDDLIPCPJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7AA6D00", Offset = "0x7AA5F00", VA = "0x187AA6D00")]
	private void AEELLJKHJIM(BMGNKMBPAKO ONHIFPDBHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7AA8060", Offset = "0x7AA7260", VA = "0x187AA8060")]
	private void CLMGIENHLLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7AA83F0", Offset = "0x7AA75F0", VA = "0x187AA83F0")]
	private void FALJDGBCDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7AA83F0", Offset = "0x7AA75F0", VA = "0x187AA83F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7AA9060", Offset = "0x7AA8260", VA = "0x187AA9060")]
	public MEHBOADMAFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7AA85D0", Offset = "0x7AA77D0", VA = "0x187AA85D0", Slot = "5")]
	private void OPJDLJCODLL([In] ADLDHGFBDOG HDDLIPCPJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7AA87C0", Offset = "0x7AA79C0", VA = "0x187AA87C0", Slot = "7")]
	private void JBJAMLDFIDO([In] LDNPDDIOLGB HDDLIPCPJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7AA8D40", Offset = "0x7AA7F40", VA = "0x187AA8D40")]
	[CompilerGenerated]
	internal static float KIOFFNPAJKH(float KJIOHKMJAPE, float IOJIHHMHOEO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7AA8460", Offset = "0x7AA7660", VA = "0x187AA8460")]
	[CompilerGenerated]
	internal static void EBECDPOJNLA(Vector2 NOCFMOGCNOO, Vector2 DOBKCEGCGIH, Vector2 GCFCAGDGDIN, Vector2 FHHDCGHGHIP, Vector2 AFOBMPBBEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7AA8D50", Offset = "0x7AA7F50", VA = "0x187AA8D50")]
	[CompilerGenerated]
	internal static Vector4 OAPGMCJIKOO(Vector2 FICCENLPJEL, Vector2 GPOEDAABNAL)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class AvatarForearmRollController : MonoBehaviour, IHEOBAFNGIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private float KKFJAFKALMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private bool GONLFMKEDNJ;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7A98990", Offset = "0x7A97B90", VA = "0x187A98990", Slot = "4")]
		public void UpdateController(float IDFEGEHLHMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x1793E30", Offset = "0x1793030", VA = "0x181793E30", Slot = "6")]
		public void SetEnabled(bool KJIOHKMJAPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7A991F0", Offset = "0x7A983F0", VA = "0x187A991F0")]
		public AvatarForearmRollController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class AvatarHandDisplaySettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public class AnimationOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7A99290", Offset = "0x7A98490", VA = "0x187A99290")]
		public void IJDFNMPLFGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7A99220", Offset = "0x7A98420", VA = "0x187A99220")]
		public int GPCFAKPMFEH(int OKEKDCMGALN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class NACKAPHCKGC : JCAFGHEKOLH
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7AAA1B0", Offset = "0x7AA93B0", VA = "0x187AAA1B0", Slot = "24")]
	public override float KEHEAGOHNJD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7AAA200", Offset = "0x7AA9400", VA = "0x187AAA200")]
	public NACKAPHCKGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class JCAFGHEKOLH : JGDIKKCCKEJ
{
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private static int EGEGCFFOEEK;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static int CPJLGHNAEFA;

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static int FNCICCBDMOE;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static int HCNFIMHBOFG;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static int DLEDDAIAMHM;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static int FPBHCDHDEAP;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static int OOBEMPHEICJ;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static int[] ONCFFLAOADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private DNIBDPLMJAL ENPNGFLEGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private ANOCDPICPPL EKNHENPLHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private int OGLKOFAOJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private float MCLNNEEKJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	protected Animator AOMAHMLOFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	protected AvatarConfiguration IEDFAEHLHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	protected int BJEOHEANLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private int IEDIGNFDBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private int FDNNLMDFFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private bool DLLHGDDHBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private KDFDOLIJIHM MNCMPCNDBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private int DAHBDGCDCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private float LFELNIEFPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private AvatarHandDisplaySettings GKMEEIDKCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private HIEAKOJGBND AKGJJBHGBNO;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform POBPLOFCMAD
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA00FA0", Offset = "0xA001A0", VA = "0x180A00FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Vector3 APIFBAKMMEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x178EB60", Offset = "0x178DD60", VA = "0x18178EB60")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x178EC10", Offset = "0x178DE10", VA = "0x18178EC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Quaternion NPEDBALIMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xD9E5A0", Offset = "0xD9D7A0", VA = "0x180D9E5A0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xF64270", Offset = "0xF63470", VA = "0x180F64270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool GNAKMDLLGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7AA2F30", Offset = "0x7AA2130", VA = "0x187AA2F30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7AA2C10", Offset = "0x7AA1E10", VA = "0x187AA2C10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool MMIHOENJAEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA6BEC0", Offset = "0xA6B0C0", VA = "0x180A6BEC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Vector3 HCJOJMPOJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA2F0B0", Offset = "0xA2E2B0", VA = "0x180A2F0B0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA2DFC0", Offset = "0xA2D1C0", VA = "0x180A2DFC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Quaternion BMKCJOKDABP
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x1105610", Offset = "0x1104810", VA = "0x181105610", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1540F40", Offset = "0x1540140", VA = "0x181540F40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public CIGCOHPAJFE BJHPGOEEDJH
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xB1E390", Offset = "0xB1D590", VA = "0x180B1E390", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return default(CIGCOHPAJFE);
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xB1E2C0", Offset = "0xB1D4C0", VA = "0x180B1E2C0", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public CIGCOHPAJFE LMBIDCLFKCN
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x1109190", Offset = "0x1108390", VA = "0x181109190", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(CIGCOHPAJFE);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x2384FC0", Offset = "0x23841C0", VA = "0x182384FC0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float FMDIFJNEGII
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xB17C50", Offset = "0xB16E50", VA = "0x180B17C50", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xF51C80", Offset = "0xF50E80", VA = "0x180F51C80", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool MBNGCPHCKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7AA2A30", Offset = "0x7AA1C30", VA = "0x187AA2A30", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7AA2A20", Offset = "0x7AA1C20", VA = "0x187AA2A20", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool DHEHHHBCKAA
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7AA2C00", Offset = "0x7AA1E00", VA = "0x187AA2C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool NPKJICEBJHG
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7AA2640", Offset = "0x7AA1840", VA = "0x187AA2640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool HOJDCEHIPJI
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7AA2F60", Offset = "0x7AA2160", VA = "0x187AA2F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool IIIHCFLJJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7AA2650", Offset = "0x7AA1850", VA = "0x187AA2650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2450", Offset = "0x7AA1650", VA = "0x187AA2450", Slot = "23")]
	public void AFLILFPIJAH(DNIBDPLMJAL MAMIMJLJFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7AA25F0", Offset = "0x7AA17F0", VA = "0x187AA25F0")]
	public void AIHONKHFMBH(ANOCDPICPPL PIBMLFMGFKJ, AvatarHandDisplaySettings JMMIIAOFEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2E10", Offset = "0x7AA2010", VA = "0x187AA2E10", Slot = "14")]
	public void LAGMAAAEOJJ(bool PGEJJMOHEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7AA26B0", Offset = "0x7AA18B0", VA = "0x187AA26B0", Slot = "13")]
	public void CMNKIHGNLLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0xB17C50", Offset = "0xB16E50", VA = "0x180B17C50", Slot = "24")]
	public virtual float KEHEAGOHNJD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2C90", Offset = "0x7AA1E90", VA = "0x187AA2C90")]
	private int KMLFONBCMBK(CIGCOHPAJFE DIHLNNHKGLP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2A40", Offset = "0x7AA1C40", VA = "0x187AA2A40")]
	private void GDMGDNMOHAM(int ACLNMHBIKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2EA0", Offset = "0x7AA20A0", VA = "0x187AA2EA0", Slot = "15")]
	public bool LKHGEFMOHLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2F00", Offset = "0x7AA2100", VA = "0x187AA2F00", Slot = "16")]
	public bool OBCFOEIPDBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2C40", Offset = "0x7AA1E40", VA = "0x187AA2C40")]
	private CIGCOHPAJFE JMAMHJINHCI()
	{
		return default(CIGCOHPAJFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x1CF7530", Offset = "0x1CF6730", VA = "0x181CF7530", Slot = "17")]
	public void IGODJPCPFFH(bool PGEJJMOHEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2EC0", Offset = "0x7AA20C0", VA = "0x187AA2EC0", Slot = "12")]
	public void NKBBJDMOCIM(int ACLNMHBIKII, float LDNJDCJGGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2F10", Offset = "0x7AA2110", VA = "0x187AA2F10", Slot = "10")]
	public void OKILNHOEPON(KDFDOLIJIHM CKCKEFFHJAP, bool GOGLCIFAFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2F70", Offset = "0x7AA2170", VA = "0x187AA2F70", Slot = "11")]
	public void PHBDJMPMCHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2660", Offset = "0x7AA1860", VA = "0x187AA2660", Slot = "18")]
	public void CDNFGMGJGLL(Transform FLKKOCNDECC, Vector3 BLJIKHPALFC, Quaternion JAGOBBCFJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7AA3210", Offset = "0x7AA2410", VA = "0x187AA3210")]
	public JCAFGHEKOLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class DEGLECBDCKK : EKBIOEBPKMG
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class JBBFEOMACDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public DEGLECBDCKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public List<LCHNAMIBFHG> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public List<LCHNAMIBFHG> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public HLHLINEFKHE<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public HLHLINEFKHE<PPLMLPIINOB> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public JBBFEOMACDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7AA2210", Offset = "0x7AA1410", VA = "0x187AA2210")]
		internal IFBEDABPFIF KEALGDIHHJO(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public PNMBCADMOBD MGGEGDPNMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public PPLMLPIINOB JHFENKIENMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private HLHLINEFKHE<PPLMLPIINOB> IJNOJEGGDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private HLHLINEFKHE<Material[]> NGNJKGIBGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public Material[] HKFJHINKPCM;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool CLHFDAAIHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xA2F4A0", Offset = "0xA2E6A0", VA = "0x180A2F4A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA2F2C0", Offset = "0xA2E4C0", VA = "0x180A2F2C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public OFCOHJLOKGA.PFHBFKIKAIN KNABGKPLJNE
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xA00F50", Offset = "0xA00150", VA = "0x180A00F50")]
		[CompilerGenerated]
		get
		{
			return default(OFCOHJLOKGA.PFHBFKIKAIN);
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xA00F80", Offset = "0xA00180", VA = "0x180A00F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7A9C7A0", Offset = "0x7A9B9A0", VA = "0x187A9C7A0")]
	public DEGLECBDCKK(IMAHPAJHFNK KIDBDHFMJJA, PNMBCADMOBD GHFPLCMOBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7A9C2A0", Offset = "0x7A9B4A0", VA = "0x187A9C2A0", Slot = "6")]
	public override IFBEDABPFIF OLLFFNEOLND(List<LCHNAMIBFHG> BGPBFPEAKHH, List<LCHNAMIBFHG> IINIJBMBLCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7A9BE60", Offset = "0x7A9B060", VA = "0x187A9BE60")]
	public IFBEDABPFIF JPIPJPDCLAJ(List<LCHNAMIBFHG> BGPBFPEAKHH, List<LCHNAMIBFHG> IINIJBMBLCE, HLHLINEFKHE<Material[]> NGNJKGIBGBN, [Optional] HLHLINEFKHE<PPLMLPIINOB> FCADBABCNIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B4B0", Offset = "0x7A9A6B0", VA = "0x187A9B4B0")]
	public (HLHLINEFKHE<Material[]>, HLHLINEFKHE<PPLMLPIINOB>) EBLKPKHHJMN(List<LCHNAMIBFHG> BGPBFPEAKHH, List<LCHNAMIBFHG> IINIJBMBLCE)
	{
		return default((HLHLINEFKHE<Material[]>, HLHLINEFKHE<PPLMLPIINOB>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7A9C170", Offset = "0x7A9B370", VA = "0x187A9C170", Slot = "7")]
	public override MKIOKEPFHHE KJHGIBKPHAF(uint AEABCPDILIB, AvatarSkinnedMeshBoneOrderRemapsData FNHOHKIABGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B8D0", Offset = "0x7A9AAD0", VA = "0x187A9B8D0")]
	public MKIOKEPFHHE EGHFOFEHJHG(GameObject JBKMCCLLPLO, uint AEABCPDILIB, bool FEMOPMOLPDJ, bool DBJNEEIEICF, AvatarSkinnedMeshBoneOrderRemapsData FNHOHKIABGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7A9BB00", Offset = "0x7A9AD00", VA = "0x187A9BB00")]
	public static bool HCJIEELAPHE(Renderer[] NMHABIBPCAP, string JMINILLDPKJ, [Out] Renderer AFIECEIPCFM, [Out] Renderer GMICECNDDHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7A9C750", Offset = "0x7A9B950", VA = "0x187A9C750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B3E0", Offset = "0x7A9A5E0", VA = "0x187A9B3E0")]
	private (HLHLINEFKHE<PPLMLPIINOB>, HLHLINEFKHE<Material[]>) DBNBFJCKAGL()
	{
		return default((HLHLINEFKHE<PPLMLPIINOB>, HLHLINEFKHE<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7A9BAE0", Offset = "0x7A9ACE0", VA = "0x187A9BAE0")]
	[CompilerGenerated]
	private void FPJIFOPJLMP(PPLMLPIINOB ACALKMLJJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0xA003A0", Offset = "0x9FF5A0", VA = "0x180A003A0")]
	[CompilerGenerated]
	private void NIKNPIDOOLA(Material[] ACALKMLJJOL)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class AvatarKneeBendTargetController : MonoBehaviour, IHEOBAFNGIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[GBCGIPBAICF(CFJMFGLCHFI.Self, false, false, false)]
		[SerializeField]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private Vector3 BBIPOAIKJDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private Vector3 ODIEOEGJHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private Vector3 CCOMCOIJLCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private Matrix4x4 AEJGAJLICNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private bool GONLFMKEDNJ;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7A99820", Offset = "0x7A98A20", VA = "0x187A99820", Slot = "4")]
		public void UpdateController(float IDFEGEHLHMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7A99810", Offset = "0x7A98A10", VA = "0x187A99810", Slot = "6")]
		public void SetEnabled(bool KJIOHKMJAPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7A993B0", Offset = "0x7A985B0", VA = "0x187A993B0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7A99EE0", Offset = "0x7A990E0", VA = "0x187A99EE0")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[CBAABKHKLJM]
public struct GAPJGHCNMEH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	[ReadOnly]
	public HJAKFIHDEKG AAOPDFFNCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	[ReadOnly]
	public int MGMKIDCFOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public MENPPNAFOJB CBEDGMEINNN;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7A9E380", Offset = "0x7A9D580", VA = "0x187A9E380", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[CBAABKHKLJM]
[NativeContainer]
public struct MENPPNAFOJB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeArray<Vector3> HOMECLNDGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeArray<Vector3> OFFILAFEDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<Vector4> DJAKFEGKIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<Vector2> AIHKCDLHJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<Vector2> HGNEJNADCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<Vector2> ADDODKILEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<Vector2> GMKLOKMAOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<Color> GKNPBKILJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<int> PBNCLLEDHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<int> GFPFOIABOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private NativeArray<int> ACBBHPKCJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private NativeArray<int> DKMDAFJCAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public NativeArray<int> MCCANHPBFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public NativeArray<int> MLDJAFHKDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<int> IEKEDNBLGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<BoneWeight> HPDEDBGIIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private NativeArray<int> AJLJPILGNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private bool APNNLDCNEPI;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int ALJOAPKCHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7AA9720", Offset = "0x7AA8920", VA = "0x187AA9720")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7AA97D0", Offset = "0x7AA89D0", VA = "0x187AA97D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int FIOMBAKCIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7AA99A0", Offset = "0x7AA8BA0", VA = "0x187AA99A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7AA9990", Offset = "0x7AA8B90", VA = "0x187AA9990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int DJJGALIBLCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7AA98B0", Offset = "0x7AA8AB0", VA = "0x187AA98B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7AA9730", Offset = "0x7AA8930", VA = "0x187AA9730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7AA9BF0", Offset = "0x7AA8DF0", VA = "0x187AA9BF0")]
	public MENPPNAFOJB(int GMJFFMENNPK, int AGGIEGFAOGI, int OIGGPEIKDKI, int HLMACCDDOJK, Allocator DPAKHKILCMF, int CHEBOLPODBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7AA91B0", Offset = "0x7AA83B0", VA = "0x187AA91B0")]
	public void AEMFEKFIMNG(int CMDFFDAPDIB, Vector3 JIKDBGFICJD, Vector3 KAMENFELAAB, Vector4 DACBPJEFOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7AA99B0", Offset = "0x7AA8BB0", VA = "0x187AA99B0")]
	public void NOGKDMGBPMA(int CMDFFDAPDIB, BoneWeight DHGFFDKKCHO, NativeSlice<byte> DNMMKBFJLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7AA9BA0", Offset = "0x7AA8DA0", VA = "0x187AA9BA0")]
	public Color OINDDAFILCN(int CMDFFDAPDIB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7AA9970", Offset = "0x7AA8B70", VA = "0x187AA9970")]
	public void LODEAJCJEJC(int CMDFFDAPDIB, Color NAGHCPKAEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7AA9B50", Offset = "0x7AA8D50", VA = "0x187AA9B50")]
	public void OHFLNCLFBFI(byte IAILLMBJKGG, int CMDFFDAPDIB, Vector2 FCLFCHBNAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7AA91A0", Offset = "0x7AA83A0", VA = "0x187AA91A0")]
	public void ADDKIODCHGK(int CMDFFDAPDIB, int MDDOIPFDKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7AA9BC0", Offset = "0x7AA8DC0", VA = "0x187AA9BC0")]
	public bool PHNGJFPBAKO(int IAILLMBJKGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7AA97E0", Offset = "0x7AA89E0", VA = "0x187AA97E0")]
	public void KFMAPECGKMB(int KIPJPILHJPL, int GJBFKFHLHKP, int CLBDAFJFHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7AA98C0", Offset = "0x7AA8AC0", VA = "0x187AA98C0")]
	public int[] LEPMKGCJILC(int KIPJPILHJPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7AA9740", Offset = "0x7AA8940", VA = "0x187AA9740")]
	private NativeSlice<int> IFCNLNKOFJE(int KIPJPILHJPL)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7AA9220", Offset = "0x7AA8420", VA = "0x187AA9220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7AA93D0", Offset = "0x7AA85D0", VA = "0x187AA93D0")]
	public Mesh GBJHLGAENMH([Optional] string KFEPLOPCKJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[NativeContainer]
[DefaultMember("Item")]
[CBAABKHKLJM]
public struct HJAKFIHDEKG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeArray<Vector3> HOMECLNDGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public NativeArray<Vector3> OFFILAFEDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeArray<Vector4> DJAKFEGKIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<Vector2> AIHKCDLHJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<Vector2> HGNEJNADCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeArray<Vector2> ADDODKILEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeArray<Vector2> GMKLOKMAOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeArray<Color> GKNPBKILJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeArray<int> CEDLCDMCPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeArray<int> HOCGIIPPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeArray<int> ECIAACMBKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeArray<int> FKCINHBCIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeArray<bool> CCMGIFBKPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeArray<int> CFHJKDFGINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeArray<int> JDHLKINDLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public NativeArray<BoneWeight> BFPMJMDMEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private NativeArray<Matrix4x4> BKNJKAJLCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private NativeArray<long> FCALLNMJNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private NativeArray<byte> FEAAKNAGELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private NativeArray<int> PMAHPFHMMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private NativeArray<int> ONCDGNPAELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public NativeArray<sbyte> MOBMDHLEDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public NativeArray<byte> BOOAPNHHIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private NativeArray<int> NFPGPBMMJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private bool APNNLDCNEPI;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int KLAOPDHCOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xE16590", Offset = "0xE15790", VA = "0x180E16590")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int AINBIIOINFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xCAFF80", Offset = "0xCAF180", VA = "0x180CAFF80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int BMAALGMJNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7A9FCF0", Offset = "0x7A9EEF0", VA = "0x187A9FCF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int CIEHFLIEOIC
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7A9FCA0", Offset = "0x7A9EEA0", VA = "0x187A9FCA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7A9F940", Offset = "0x7A9EB40", VA = "0x187A9F940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int ALJOAPKCHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7A9FCC0", Offset = "0x7A9EEC0", VA = "0x187A9FCC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7A9FCE0", Offset = "0x7A9EEE0", VA = "0x187A9FCE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int HFEMJEMBNBL
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7A9FCB0", Offset = "0x7A9EEB0", VA = "0x187A9FCB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7A9FC90", Offset = "0x7A9EE90", VA = "0x187A9FC90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public NOBGMFFFENK IOBJEGKGPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7A9F930", Offset = "0x7A9EB30", VA = "0x187A9F930")]
		get
		{
			return default(NOBGMFFFENK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7A9FCD0", Offset = "0x7A9EED0", VA = "0x187A9FCD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public byte HCHAMDEEEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7AA0250", Offset = "0x7A9F450", VA = "0x187AA0250")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7AA0260", Offset = "0x7A9F460", VA = "0x187AA0260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public ODIEDEAJDCA HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7A9FD20", Offset = "0x7A9EF20", VA = "0x187A9FD20")]
		get
		{
			return default(ODIEDEAJDCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7AA0270", Offset = "0x7A9F470", VA = "0x187AA0270")]
	public HJAKFIHDEKG(IList<Mesh> BGHCNANOBFN, IList<Matrix4x4> LAIGFCBJPGI, IList<bool> CCMGIFBKPGO, byte ANCHJFMGJJF, IList<byte[]> MGMOGPCHCKE, IList<long> NNNGKELPGJN, IList<bool> NBHJMAJIOAC, IList<int> CFHJKDFGINB, IList<int> NFFPHFHDDIM, IList<int> GOPHADMIFOE, Allocator DPAKHKILCMF, NOBGMFFFENK APBDIBODOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7A9FBC0", Offset = "0x7A9EDC0", VA = "0x187A9FBC0")]
	public MENPPNAFOJB EEGLGPLLDKG(Allocator DPAKHKILCMF)
	{
		return default(MENPPNAFOJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7A9F950", Offset = "0x7A9EB50", VA = "0x187A9F950", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[CBAABKHKLJM]
public class LCPHCOOFCOC : FBPMONDCGGJ
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7AA3710", Offset = "0x7AA2910", VA = "0x187AA3710")]
	public HJAKFIHDEKG GMPJKNPBJNP()
	{
		return default(HJAKFIHDEKG);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7A97850", Offset = "0x7A96A50", VA = "0x187A97850")]
	public LCPHCOOFCOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct ODIEDEAJDCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public NativeSlice<Vector3> HOMECLNDGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public NativeSlice<Vector3> OFFILAFEDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public NativeSlice<Vector4> DJAKFEGKIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public NativeSlice<Vector2> AIHKCDLHJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public NativeSlice<Vector2> HGNEJNADCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public NativeSlice<Vector2> ADDODKILEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeSlice<Vector2> GMKLOKMAOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public NativeSlice<Color> GKNPBKILJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public NativeSlice<int> BPFEMOIGPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public NativeSlice<int> FKCINHBCIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public NativeSlice<BoneWeight> BFPMJMDMEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public NativeSlice<byte> LDJDIAAKEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public int OMFFNAHLJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public Matrix4x4 BPMKOFLDDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public long BHMNEOJLJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public NativeSlice<byte> DNMMKBFJLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public bool NHMANCHKECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public int JAEAOIMLFOO;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal readonly struct LOPOPBAACAE : IEquatable<LOPOPBAACAE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	internal readonly Material MLKDHMPMIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	internal readonly DAOBKDMIGNE LCILJDNBDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	internal readonly FKFIKCFFCEO HCCCALNAAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	internal readonly IMAHPAJHFNK CGDJICCKAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	internal readonly bool MNOGNJKLEIN;

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7AA68F0", Offset = "0x7AA5AF0", VA = "0x187AA68F0")]
	public LOPOPBAACAE(Material ADKDGJDNNAD, DAOBKDMIGNE FOKAHLNIEMH, FKFIKCFFCEO EBFFCEPFLBJ, IMAHPAJHFNK IJFIDCOKOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x7AA6650", Offset = "0x7AA5850", VA = "0x187AA6650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x7AA63B0", Offset = "0x7AA55B0", VA = "0x187AA63B0", Slot = "4")]
	public bool Equals(LOPOPBAACAE CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x7AA6440", Offset = "0x7AA5640", VA = "0x187AA6440", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x7AA6540", Offset = "0x7AA5740", VA = "0x187AA6540", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, MLAFNJOHGFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[SerializeField]
		[Header("Configuration")]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		[Header("Configuration")]
		private HIEAKOJGBND avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[FormerlySerializedAs("BodyMaterial")]
		[SerializeField]
		private Material BodyMaterialSkinGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private KONLHIGFPIP OFAOPNAMGAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private FHHGLMCDKMP MJEDBCOHFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private JGDIKKCCKEJ NOOECKKAIKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private JGDIKKCCKEJ MCHKFGJOIAC;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public KONLHIGFPIP KHNPKDEMIBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x7A9AF20", Offset = "0x7A9A120", VA = "0x187A9AF20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public FHHGLMCDKMP OCLDIJKBLLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x7A9AF70", Offset = "0x7A9A170", VA = "0x187A9AF70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public JGDIKKCCKEJ DJJEFJOLIHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x7A9AFC0", Offset = "0x7A9A1C0", VA = "0x187A9AFC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public JGDIKKCCKEJ ILHIHBIPNHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x7A9B010", Offset = "0x7A9A210", VA = "0x187A9B010", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Transform LPFNJEDHPDB
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x7A9B060", Offset = "0x7A9A260", VA = "0x187A9B060", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public HIEAKOJGBND ELDNOACLEBN
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xA00BB0", Offset = "0x9FFDB0", VA = "0x180A00BB0", Slot = "12")]
			get
			{
				return default(HIEAKOJGBND);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7A99EF0", Offset = "0x7A990F0", VA = "0x187A99EF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7A9AD80", Offset = "0x7A99F80", VA = "0x187A9AD80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7A9A720", Offset = "0x7A99920", VA = "0x187A9A720", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7A9AD80", Offset = "0x7A99F80", VA = "0x187A9AD80", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7A99F60", Offset = "0x7A99160", VA = "0x187A99F60", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7A9AE30", Offset = "0x7A9A030", VA = "0x187A9AE30")]
		public void UpdatePostIKAnimControllers(float IDFEGEHLHMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7A9A350", Offset = "0x7A99550", VA = "0x187A9A350")]
		private void DPBHCBIKCGG(GameObject KFMNDOMPAMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7A9A780", Offset = "0x7A99980", VA = "0x187A9A780")]
		private KONLHIGFPIP KEMABECNIEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7A9A3E0", Offset = "0x7A995E0", VA = "0x187A9A3E0")]
		private FHHGLMCDKMP FHJCLAFJHDH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7A9AAF0", Offset = "0x7A99CF0", VA = "0x187A9AAF0")]
		private JGDIKKCCKEJ NNJGINLCGOC(LOPBLGBJOCJ HGFILEJONAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7A9AF10", Offset = "0x7A9A110", VA = "0x187A9AF10")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class LFPOKDNGEGI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private MaterialPropertyBlock HIKNCHLLPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public Color? KEALDPKKGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public Color? AGBMDLHBFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public Color? DMAELKGLJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public Color? LEMEEKBFAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public Color OJNBGOCKKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public Color PLJGNDIDJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public Color NBJIIPDINBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public float LGFFGFBLGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public Texture2D KJFEENGAMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public Texture2D NHDCDNEEOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private Dictionary<LOPOPBAACAE, int> BJLGOJMOHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private DAOBKDMIGNE[] JDDPCNDHMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private FKFIKCFFCEO[] NMIGMDECHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public Vector4[] BJEJOGOJNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public Vector4[] NFBFKNMGELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public Vector4[] LDIEGKAIMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public Vector4[] HGIJPHMDMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public Vector4[] KLDNDLFICDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public Vector4[] DOGGEJPHKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private List<Texture2D> CCMMEHPIPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private Vector4[] ILFABGPMJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private List<Texture2D> KFCILNODIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private float[] ALJDBKGCCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private Vector4[] POGAFMKBENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private float[] IDOPNHMDFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public float[] PAAPEENELGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private List<Texture2D> NGPDEBODPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private float[] DAOKFIJENFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private List<Texture2D> JFDEIFKIPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private Vector4[] IINHFKILEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private float[] MELPLLDNPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private Vector4[] EMDKELCMGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public float[] KNJAMCDNOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public Texture2DArray MDBHMDHEPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public Texture2DArray LKHEALHOKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public Texture2DArray MMDGOEJIHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public Texture2DArray CIEKPFDGNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private bool LCBBMLEPPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private int DDBHIOPNOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private Vector2? OOIIAOPHCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private TextureFormat MJHABIPGEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private Vector2? BLMLPKBOKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private TextureFormat OFGIABEKNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private Vector2? LOGOHCLBMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private TextureFormat FJAJHLHAPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private Vector2? MBFLMMIDJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private TextureFormat EJBBJJEPKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private bool OLFOBLPNEEI;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static int PDFACAMOEFC;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static int AGGNBGGILJA;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static int AMBHEEJPFAD;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static int CCKFANOBCJH;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static int PIFLKEHBMME;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static int POCDLHDHOHB;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static int KNHHFALODOC;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static int FJNCHBBEPGB;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static int GFFHCFBKNMD;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private static int BLMALGOGEDB;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private static int MHFNGIDCFDK;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static int JCKCEJAEMEN;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private static int DHODHHCHNLD;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static int IAIJAONNPEN;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private static int FAOJFBMMMJM;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private static int NDAFONDDDFJ;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static int FBFGBEFPFHB;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private static int CKHDBPFIABE;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private static int HIPDNJBCODD;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private static int GAFOAJKCCHP;

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5EB0", Offset = "0x7AA50B0", VA = "0x187AA5EB0")]
	private LFPOKDNGEGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5DF0", Offset = "0x7AA4FF0", VA = "0x187AA5DF0")]
	public LFPOKDNGEGI(Color FJBBDCIGNIM, Color IFBPHDAFOJK, Color BPHECAPGKOO, Color? OEHKLAGCKAN, Color? GKLKNBLIFFJ, Color? GEOAJLAOKBM, Texture2D HHFFEMDNMPG, Texture2D JOJLEHAJDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5940", Offset = "0x7AA4B40", VA = "0x187AA5940")]
	internal int NPMAKKCAJKL(Material DOIIOKCOKGP, DAOBKDMIGNE FOKAHLNIEMH, FKFIKCFFCEO EBFFCEPFLBJ, IMAHPAJHFNK IJFIDCOKOEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5A10", Offset = "0x7AA4C10", VA = "0x187AA5A10")]
	private int NPMAKKCAJKL(LOPOPBAACAE MHDODBCCAJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7AA4D70", Offset = "0x7AA3F70", VA = "0x187AA4D70")]
	internal int MECGLAFJCPA(Material DOIIOKCOKGP, Color OOAACLAMGKN, Color IAGDMFKAEKM, Color DGPIDCHBFIL, Color BLGNDOHMHGF, Color EOMHOBIIELH, Texture2D DAHLNEHLDKE, Vector4 GALGCGLIEHG, Texture2D NANFHAMOAOC, Vector4 LFAIMCEPOLN, float JIPHGKCGIPI, float DFHMGPBBMGK, Texture2D IBPOLANBDAK, Vector4 KCFICFEGMDC, float EBKLAACLBDB, Texture2D EMIIPLJBHCK, Color ABKNPJOBOFP, Vector4 CPNDNBNGIBB, DAOBKDMIGNE FOKAHLNIEMH, FKFIKCFFCEO EBFFCEPFLBJ, IMAHPAJHFNK IJFIDCOKOEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7AA4570", Offset = "0x7AA3770", VA = "0x187AA4570")]
	private void DELMONAKBCK(List<Texture2D> CCMMEHPIPID, [Out] Texture2DArray COFOOPOFACG, [Out] Texture2DArray IHMOMKFFHJD, [Out] Texture2DArray GIFHICLAOOH, [Out] Texture2DArray OBJJMIOFPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7AA4A20", Offset = "0x7AA3C20", VA = "0x187AA4A20")]
	public void GNDMEPLBNEP(Shader EBBLNHCCNFF, Renderer HLIOBIEFOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7AA3800", Offset = "0x7AA2A00", VA = "0x187AA3800")]
	private void ALCGEFMEGCM(Shader EBBLNHCCNFF, Renderer HLIOBIEFOPB, int KLGMOKNJKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x7AA4B70", Offset = "0x7AA3D70", VA = "0x187AA4B70")]
	private Color IMOHPNAIFEL(Color ODPAECLFGIC, DAOBKDMIGNE DBDFKFEEDLP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x7AA4730", Offset = "0x7AA3930", VA = "0x187AA4730")]
	private Color DENGDPLPGLO(Color MNPHPEPJIDC, DAOBKDMIGNE DBDFKFEEDLP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x7AA48C0", Offset = "0x7AA3AC0", VA = "0x187AA48C0")]
	private bool EJNNPHCFHIM(Texture2D MDKPJMOIANH, FKFIKCFFCEO LBHPCBIADNN, [Out] Texture2D HMKGDNAKIBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x7AA44C0", Offset = "0x7AA36C0", VA = "0x187AA44C0")]
	private void BHPDIAJAGFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x7AA4880", Offset = "0x7AA3A80", VA = "0x187AA4880", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class EKBIOEBPKMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public readonly IMAHPAJHFNK NEOILNNFFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	protected bool ALAKCPMAECN;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool HDOOCFAGDPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA75190", Offset = "0xA74390", VA = "0x180A75190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA75210", Offset = "0xA74410", VA = "0x180A75210")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool BEOMBLLGCJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA751A0", Offset = "0xA743A0", VA = "0x180A751A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xA75180", Offset = "0xA74380", VA = "0x180A75180")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public virtual OFCOHJLOKGA.PFHBFKIKAIN BHMNEOJLJJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(OFCOHJLOKGA.PFHBFKIKAIN);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xCB84B0", Offset = "0xCB76B0", VA = "0x180CB84B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool JDDHGFHBJDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x129EEE0", Offset = "0x129E0E0", VA = "0x18129EEE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool HMCMHPKCLIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7A9DAB0", Offset = "0x7A9CCB0", VA = "0x187A9DAB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool FEEAFJOCHGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7A9DAE0", Offset = "0x7A9CCE0", VA = "0x187A9DAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool NMKKNHIBNFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7A9DAC0", Offset = "0x7A9CCC0", VA = "0x187A9DAC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x7A9DAF0", Offset = "0x7A9CCF0", VA = "0x187A9DAF0")]
	protected EKBIOEBPKMG(IMAHPAJHFNK KIDBDHFMJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract IFBEDABPFIF OLLFFNEOLND(List<LCHNAMIBFHG> BGPBFPEAKHH, List<LCHNAMIBFHG> IINIJBMBLCE);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract MKIOKEPFHHE KJHGIBKPHAF(uint AEABCPDILIB, AvatarSkinnedMeshBoneOrderRemapsData FNHOHKIABGO);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class BPPAILKHAGJ : DLKICJPCGHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	private AvatarSkinAssetItem ANPJDGAMNME;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B2E0", Offset = "0x7A9A4E0", VA = "0x187A9B2E0")]
	public BPPAILKHAGJ(AvatarSkinAssetItem AICKEOKLFOE, AvatarSkinAssetItem.APKPGHLCIOG FOIIMMKNLBB, IMAHPAJHFNK IJFIDCOKOEA, [Optional] JCDBDFLIABB? LNCHCFJFOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B080", Offset = "0x7A9A280", VA = "0x187A9B080", Slot = "6")]
	public override IFBEDABPFIF OLLFFNEOLND(List<LCHNAMIBFHG> BGPBFPEAKHH, List<LCHNAMIBFHG> IINIJBMBLCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class FCPFLALPNMD
{
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	private static readonly int[] BMHODDEOLFN;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private static readonly int[] DGBGBFDMLBP;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static int[] OJCGCLELJMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7A9DC60", Offset = "0x7A9CE60", VA = "0x187A9DC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x7A9DBE0", Offset = "0x7A9CDE0", VA = "0x187A9DBE0")]
	public static int[] OBLMGAOAKHB(bool FPDMNCGIOPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x7A9DB50", Offset = "0x7A9CD50", VA = "0x187A9DB50")]
	public static int NMDPILEMCNE(DLGGNNMFNFI HPDPJOKPENC, bool FPDMNCGIOPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x7A9DB20", Offset = "0x7A9CD20", VA = "0x187A9DB20")]
	private static int BLHAHOGIEOD(DLGGNNMFNFI HPDPJOKPENC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7A9DB30", Offset = "0x7A9CD30", VA = "0x187A9DB30")]
	private static int FCDICACFPFI(DLGGNNMFNFI HPDPJOKPENC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class MLECJMHGNJP
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class OKMCFKMLJAD : IEnumerator<NOFGPJFCPHG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private NOFGPJFCPHG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private NOFGPJFCPHG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
		[DebuggerHidden]
		public OKMCFKMLJAD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x1359C20", Offset = "0x1358E20", VA = "0x181359C20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x7AAA260", Offset = "0x7AA9460", VA = "0x187AAA260", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
	public static void BJNFOKDEBLD(string APBCLGNDGBE, int AEABCPDILIB, long OGIAEFFIBMB, long LMDILFJAKAB, long KIAOOEEECOA, long MPBMLGPGJCG, long NHLMCEEPBDE, long GKKMAPPFFCG, long ADEPJMEHOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7AAA0C0", Offset = "0x7AA92C0", VA = "0x187AAA0C0")]
	public static AFABIGEDGFJ PLCCHFDGFPJ(JobHandle CPBLAICBOAG, bool EBNMGPJFFMN, bool GBFJNBINHDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7AAA050", Offset = "0x7AA9250", VA = "0x187AAA050")]
	[IteratorStateMachine(typeof(OKMCFKMLJAD))]
	private static IEnumerator<NOFGPJFCPHG> BIINEHBAOJE(JobHandle BIFBBDMNGPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class GPPPAOFNNAM
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum BJDCMGKCIJG
	{
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		General,
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly int ANKKLFCDFCF;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly int HIFKNNGNHJB;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly int HMDHJDEIKFP;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly int OLENDBPLKAK;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly int GIOEMLDBPMK;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly int OLNIJKAOGDP;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly int OMLOEINIAEB;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly int BMMICLFDIOI;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly int FNOHIBHMLCM;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly int FNGDKHNHBEP;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly int EBCCDCPILJK;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly int BLCHEJBFLBH;

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x7A9F300", Offset = "0x7A9E500", VA = "0x187A9F300")]
	public static bool HPKLAOPENBN(Material ADKDGJDNNAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7A9F370", Offset = "0x7A9E570", VA = "0x187A9F370")]
	public static bool OICELOBHMDA(Material ADKDGJDNNAD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class DLKICJPCGHI : EKBIOEBPKMG
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class PLGMOCCGFBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public HLHLINEFKHE<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public DLKICJPCGHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public PLGMOCCGFBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7AAB270", Offset = "0x7AAA470", VA = "0x187AAB270")]
		internal void JOOCCMHDOOC(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7AAB640", Offset = "0x7AAA840", VA = "0x187AAB640")]
		internal void KEALGDIHHJO(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	protected AvatarSkinAssetItem DLHFOMHAKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	protected Material[] DDMKDNKIFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private readonly AvatarSkinAssetItem.APKPGHLCIOG MBKMFMMMAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private readonly AssetReference JMBEEDMBIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private readonly JCDBDFLIABB? GEOIANDKCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private SkinnedMeshRenderer[] OMDNIFBBGNJ;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public override OFCOHJLOKGA.PFHBFKIKAIN BHMNEOJLJJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA00F90", Offset = "0xA00190", VA = "0x180A00F90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(OFCOHJLOKGA.PFHBFKIKAIN);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA0D670", Offset = "0xA0C870", VA = "0x180A0D670", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7A9CE20", Offset = "0x7A9C020", VA = "0x187A9CE20")]
	public DLKICJPCGHI(AvatarSkinAssetItem.APKPGHLCIOG FOIIMMKNLBB, AssetReference HGMJGEDOLIN, Material BNBAIIJEFNK, IMAHPAJHFNK IJFIDCOKOEA, OFCOHJLOKGA.PFHBFKIKAIN CJEBHCPHHCI = (OFCOHJLOKGA.PFHBFKIKAIN)0L, [Optional] JCDBDFLIABB? LNCHCFJFOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7A9CD00", Offset = "0x7A9BF00", VA = "0x187A9CD00")]
	public DLKICJPCGHI(AvatarSkinAssetItem.APKPGHLCIOG FOIIMMKNLBB, AssetReference HGMJGEDOLIN, Material BNBAIIJEFNK, OFCOHJLOKGA.PFHBFKIKAIN CJEBHCPHHCI = (OFCOHJLOKGA.PFHBFKIKAIN)0L, [Optional] JCDBDFLIABB? LNCHCFJFOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x7A9CA70", Offset = "0x7A9BC70", VA = "0x187A9CA70", Slot = "6")]
	public override IFBEDABPFIF OLLFFNEOLND(List<LCHNAMIBFHG> BGPBFPEAKHH, List<LCHNAMIBFHG> IINIJBMBLCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7A9C860", Offset = "0x7A9BA60", VA = "0x187A9C860", Slot = "7")]
	public override MKIOKEPFHHE KJHGIBKPHAF(uint AEABCPDILIB, AvatarSkinnedMeshBoneOrderRemapsData FNHOHKIABGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7A9CC90", Offset = "0x7A9BE90", VA = "0x187A9CC90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7A9C810", Offset = "0x7A9BA10", VA = "0x187A9C810")]
	protected void FFNJFKECPLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class EEEBGEKGGJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private List<int> MGPEKNONPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private List<AAPDIGMNOAD> BAKPIILIKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private HashSet<Transform> PAAMJKFAKBP;

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7A9CF50", Offset = "0x7A9C150", VA = "0x187A9CF50")]
	public static EEEBGEKGGJE EBHMKICJBBE(Transform DACBPJEFOKJ, Dictionary<Transform, OutfitType?> PPIFKPHOAEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7A9D0E0", Offset = "0x7A9C2E0", VA = "0x187A9D0E0")]
	private void KDKPIFFDJDH(Transform DACBPJEFOKJ, IMAHPAJHFNK IJFIDCOKOEA, Dictionary<Transform, OutfitType?> PPIFKPHOAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7A9D400", Offset = "0x7A9C600", VA = "0x187A9D400")]
	private void NPGJAMONFFC(Transform CBOICIEDOGK, IMAHPAJHFNK IJFIDCOKOEA, bool ALMGPNOEDIO, OutfitType? EKDGILGJAFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7A9D590", Offset = "0x7A9C790", VA = "0x187A9D590")]
	public PFJKGMFPAMK ODBMBKABEND(HashSet<string> LANBLAIFBPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7A9D980", Offset = "0x7A9CB80", VA = "0x187A9D980")]
	public EEEBGEKGGJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class PFJKGMFPAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private List<AAPDIGMNOAD> BAKPIILIKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private List<Matrix4x4> NHNBBAMHHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private Transform[] FNJEOLMOPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private Matrix4x4[] MCAKCJBMFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private Dictionary<MEGHLNIHLLE, int> DNHLKMOGIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private List<HBLOFHDBMME> CDBJFDAOMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private bool LMHDIKBLCLI;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int OGMGMMMEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7AAA420", Offset = "0x7AA9620", VA = "0x187AAA420")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Transform[] LPMIEOAHGDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7AAA5A0", Offset = "0x7AA97A0", VA = "0x187AAA5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Matrix4x4[] JKLGBJBNCCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x7AAA3B0", Offset = "0x7AA95B0", VA = "0x187AAA3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7AAAB60", Offset = "0x7AA9D60", VA = "0x187AAAB60")]
	public void NPGJAMONFFC(Transform CBOICIEDOGK, IMAHPAJHFNK IJFIDCOKOEA, OutfitType? EKDGILGJAFN, bool GJLPHBIFDBM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7AAA7F0", Offset = "0x7AA99F0", VA = "0x187AAA7F0")]
	private void NPGJAMONFFC(Transform CBOICIEDOGK, IMAHPAJHFNK IJFIDCOKOEA, OutfitType? EKDGILGJAFN, bool GJLPHBIFDBM, Matrix4x4 DMKBLBGBKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7AAAD50", Offset = "0x7AA9F50", VA = "0x187AAAD50")]
	public int ONGGAEHGAKE(MEGHLNIHLLE MHDODBCCAJB, bool ONFOJHAGIGH, [Optional] OutfitType? EKDGILGJAFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7AAA2B0", Offset = "0x7AA94B0", VA = "0x187AAA2B0")]
	public int CBNAANMDGDM(IMAHPAJHFNK IJFIDCOKOEA, [Optional] OutfitType? EKDGILGJAFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7AAA700", Offset = "0x7AA9900", VA = "0x187AAA700")]
	public void KNEIHNOJCCG(MEGHLNIHLLE MHDODBCCAJB, Matrix4x4 CFNGLHJCGNJ, bool ONFOJHAGIGH = false, [Optional] OutfitType? EKDGILGJAFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7AAA460", Offset = "0x7AA9660", VA = "0x187AAA460")]
	public Matrix4x4 GHHKKHCFPMF(MEGHLNIHLLE MHDODBCCAJB, bool ONFOJHAGIGH, [Optional] OutfitType? EKDGILGJAFN)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x142E730", Offset = "0x142D930", VA = "0x18142E730")]
	public void AEAKHPMODKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7AAAF00", Offset = "0x7AAA100", VA = "0x187AAAF00")]
	public PFJKGMFPAMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct MEGHLNIHLLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public readonly string HPDJFACBNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public readonly IMAHPAJHFNK CGDJICCKAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public readonly OutfitType? GKHMONLEFCD;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7AA6CC0", Offset = "0x7AA5EC0", VA = "0x187AA6CC0")]
	public MEGHLNIHLLE(string DGOMKLEAAMO, IMAHPAJHFNK IJFIDCOKOEA, [Optional] OutfitType? EKDGILGJAFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7AA6C10", Offset = "0x7AA5E10", VA = "0x187AA6C10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7AA6B50", Offset = "0x7AA5D50", VA = "0x187AA6B50")]
	public bool JBCCCOHNJLL(MEGHLNIHLLE CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7AA6A30", Offset = "0x7AA5C30", VA = "0x187AA6A30", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7AA6AE0", Offset = "0x7AA5CE0", VA = "0x187AA6AE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct HBLOFHDBMME : IEquatable<HBLOFHDBMME>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public readonly IMAHPAJHFNK CGDJICCKAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public readonly OutfitType? FAHECJMILCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public readonly int ENFMGIICNML;

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7A9F920", Offset = "0x7A9EB20", VA = "0x187A9F920")]
	public HBLOFHDBMME(IMAHPAJHFNK IJFIDCOKOEA, int EGJBJIGOEGN, [Optional] OutfitType? JMDHEBKPLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7A9F850", Offset = "0x7A9EA50", VA = "0x187A9F850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6CCFC60", Offset = "0x6CCEE60", VA = "0x186CCFC60")]
	public bool IMCOOIFMKIA(IMAHPAJHFNK IJFIDCOKOEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7A9F640", Offset = "0x7A9E840", VA = "0x187A9F640")]
	public bool CDGDDBCADFK(OutfitType? JMDHEBKPLDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7A9F6C0", Offset = "0x7A9E8C0", VA = "0x187A9F6C0", Slot = "4")]
	public bool Equals(HBLOFHDBMME CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7A9F710", Offset = "0x7A9E910", VA = "0x187A9F710", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7A9F800", Offset = "0x7A9EA00", VA = "0x187A9F800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct AAPDIGMNOAD : IEquatable<AAPDIGMNOAD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public readonly Transform BLNGDOPBMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public readonly bool NOLBFBOCKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public readonly IMAHPAJHFNK NCHDFENOABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public readonly OutfitType? GKHMONLEFCD;

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7A983E0", Offset = "0x7A975E0", VA = "0x187A983E0")]
	public AAPDIGMNOAD(Transform CBOICIEDOGK, bool ALMGPNOEDIO, IMAHPAJHFNK ODPKEDPOHDG, [Optional] OutfitType? DDNFFIIOMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7A981C0", Offset = "0x7A973C0", VA = "0x187A981C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7A97F60", Offset = "0x7A97160", VA = "0x187A97F60", Slot = "4")]
	public bool Equals(AAPDIGMNOAD CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7A98060", Offset = "0x7A97260", VA = "0x187A98060", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7A98140", Offset = "0x7A97340", VA = "0x187A98140", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[ExecuteInEditMode]
	public class FitMeshHemisphereUpdater : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x7A9E320", Offset = "0x7A9D520", VA = "0x187A9E320")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface JBNPEDILNFE
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void POMOILGGHLC(Mesh CGGHHEJPJND, Matrix4x4 DCNPLECGNLB, byte[] DNMMKBFJLCI, bool FHBMOEKGMOE = false, OFCOHJLOKGA.PFHBFKIKAIN OJAHOPJGGLB = (OFCOHJLOKGA.PFHBFKIKAIN)0L, int CFHJKDFGINB = -1, bool CCMGIFBKPGO = false);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CIKHGBKCNMK(Allocator DPAKHKILCMF, NOBGMFFFENK APBDIBODOHL, byte ANCHJFMGJJF, [Optional] IList<int> NFFPHFHDDIM, [Optional] IList<int> GMKKKMDDGNB);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct PPLMLPIINOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public readonly GameObject JBKMCCLLPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	private readonly AvatarItemMaterial JJLPDNLCFLA;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xB268B0", Offset = "0xB25AB0", VA = "0x180B268B0")]
	public PPLMLPIINOB(GameObject JBKMCCLLPLO, AvatarItemMaterial JJLPDNLCFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x7AAB780", Offset = "0x7AAA980", VA = "0x187AAB780")]
	public void PJPKKKNCNII(Material ADKDGJDNNAD, int MHMJFLDMNFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class IFNFGHMFHAE : EDMAKCFKKAM<Task<(GameObject, AvatarItemMaterial)>, PPLMLPIINOB>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct FIPDAOILMDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7A9DDB0", Offset = "0x7A9CFB0", VA = "0x187A9DDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x7A9E2B0", Offset = "0x7A9D4B0", VA = "0x187A9E2B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	private HLHLINEFKHE<GameObject> CHOJGOPLNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private HLHLINEFKHE<AvatarItemMaterial> AFOBJGILMNI;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2180", Offset = "0x7AA1380", VA = "0x187AA2180")]
	private IFNFGHMFHAE(Task<(GameObject, AvatarItemMaterial)> MKOPIIJMBLM, HLHLINEFKHE<GameObject> ILOOJHEOBFG, HLHLINEFKHE<AvatarItemMaterial> DIOIIKFDCFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x7AA1B10", Offset = "0x7AA0D10", VA = "0x187AA1B10")]
	public static IFNFGHMFHAE DBJJOAFKEPP(AssetReference KDHCGMMJMIE, [Optional] AssetReference JKEIKBCAAED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2060", Offset = "0x7AA1260", VA = "0x187AA2060", Slot = "11")]
	protected override PPLMLPIINOB ILKIJPCJEON(Task<(GameObject, AvatarItemMaterial)> HLNGIDCBKFL)
	{
		return default(PPLMLPIINOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2100", Offset = "0x7AA1300", VA = "0x187AA2100", Slot = "12")]
	protected override void OLLLHCCMGKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7AA1F30", Offset = "0x7AA1130", VA = "0x187AA1F30")]
	[AsyncStateMachine(typeof(FIPDAOILMDB))]
	private static Task<(GameObject, AvatarItemMaterial)> GLJMBECMEJC(Task<GameObject> HCFLBLGDLEL, Task<AvatarItemMaterial> ECKLPENPMJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class KNHGNNPPBJJ
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class ACDFNMIMCNP : EDMAKCFKKAM<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private HLHLINEFKHE<MaterialMapAsset> BIFBBDMNGPL;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7A988B0", Offset = "0x7A97AB0", VA = "0x187A988B0")]
		public ACDFNMIMCNP(HLHLINEFKHE<MaterialMapAsset> BIFBBDMNGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x7A98430", Offset = "0x7A97630", VA = "0x187A98430", Slot = "11")]
		protected override Material[] ILKIJPCJEON(Task<MaterialMapAsset> MKOPIIJMBLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7A98850", Offset = "0x7A97A50", VA = "0x187A98850", Slot = "12")]
		protected override void OLLLHCCMGKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class PILPABCMLJD : EDMAKCFKKAM<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private List<HLHLINEFKHE<Material>> ILJPGEOGGKI;

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x7AAB200", Offset = "0x7AAA400", VA = "0x187AAB200")]
		public PILPABCMLJD(Task<Material[]> MKOPIIJMBLM, List<HLHLINEFKHE<Material>> ILJPGEOGGKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x7AAB070", Offset = "0x7AAA270", VA = "0x187AAB070", Slot = "11")]
		protected override Material[] ILKIJPCJEON(Task<Material[]> HLNGIDCBKFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7AAB0C0", Offset = "0x7AAA2C0", VA = "0x187AAB0C0", Slot = "12")]
		protected override void OLLLHCCMGKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x7AA3230", Offset = "0x7AA2430", VA = "0x187AA3230")]
	public static HLHLINEFKHE<Material[]> OFEEKJGOLEI(AssetReference[] BEECILNNGKJ)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[DisallowMultipleComponent]
	public class PlayerAvatarDisplayBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public enum DAOCHEFLGPC
		{
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public enum ODDDMHELDCK
		{
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public enum PONEJIJAIEB : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			All,
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public struct HMOHBGHPGFH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			public readonly Material MLKDHMPMIKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			public readonly DAOCHEFLGPC LCILJDNBDPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public readonly ODDDMHELDCK HCCCALNAAGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public readonly IMAHPAJHFNK CGDJICCKAML;

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x7ABE890", Offset = "0x7ABDA90", VA = "0x187ABE890")]
			public HMOHBGHPGFH(Material ADKDGJDNNAD, DAOCHEFLGPC FOKAHLNIEMH, ODDDMHELDCK EBFFCEPFLBJ, IMAHPAJHFNK IJFIDCOKOEA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x7ABE660", Offset = "0x7ABD860", VA = "0x187ABE660", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x7ABE5E0", Offset = "0x7ABD7E0", VA = "0x187ABE5E0")]
			public bool JBCCCOHNJLL(HMOHBGHPGFH CMOCFNBHPLJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x7ABE450", Offset = "0x7ABD650", VA = "0x187ABE450", Slot = "0")]
			public override bool Equals(object KFMNDOMPAMC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x7ABE540", Offset = "0x7ABD740", VA = "0x187ABE540", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		protected class EPAMDCLFPEM : IComparable<EPAMDCLFPEM>, IEquatable<EPAMDCLFPEM>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public int LECKJJMKJIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public PlayerAvatarDisplayBase AHCNILBBCDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			public IList<OALMANNFHKO> INCALNDKGGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			public AvatarItemBodyType PJMJBININPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			public CJGBLKOPNIO CFKKEICDAOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			public bool JIDFLIJAFCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public bool MHFBGCHPICP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public int[] OMLNPHJACGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public float OBFEBJHFBGN;

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x7ABDED0", Offset = "0x7ABD0D0", VA = "0x187ABDED0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x7ABDD80", Offset = "0x7ABCF80", VA = "0x187ABDD80", Slot = "4")]
			public int CompareTo(EPAMDCLFPEM CMOCFNBHPLJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x7ABDDB0", Offset = "0x7ABCFB0", VA = "0x187ABDDB0", Slot = "5")]
			public bool Equals(EPAMDCLFPEM CMOCFNBHPLJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public EPAMDCLFPEM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		protected abstract class BEDPJPABBGA
		{
			[Cpp2IlInjected.Token(Token = "0x200005B")]
			public class LCPECIFPHJB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000368")]
				public readonly Mesh PEICEPCLCCK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000369")]
				public readonly Material[] GDPKDKFCEIB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400036A")]
				public readonly Transform[] HOCPEJAGJCF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public readonly Matrix4x4[] CMIDFNDMNJA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400036C")]
				public readonly Transform ANPKLMIIMIC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400036D")]
				public readonly bool NKDHHAHBCDJ;

				[Cpp2IlInjected.Token(Token = "0x6000304")]
				[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
				protected LCPECIFPHJB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0x7AC0DC0", Offset = "0x7ABFFC0", VA = "0x187AC0DC0")]
				public LCPECIFPHJB(Mesh CGGHHEJPJND, Material[] MKDOGLGJBJO, bool BBICJHMPACF, Transform[] NEHDPDMMIDH, Transform ODLFGDDIFDP, Matrix4x4[] JLPGCFKFKHL)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0x7AC1270", Offset = "0x7AC0470", VA = "0x187AC1270")]
				private LCPECIFPHJB(SkinnedMeshRenderer DNCAJBICKKF, Material[] OBKMIKGLFEF)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0x7AC0CD0", Offset = "0x7ABFED0", VA = "0x187AC0CD0")]
				private LCPECIFPHJB(MeshRenderer IMGLNPHBCNC, Transform ODLFGDDIFDP, Material[] OBKMIKGLFEF)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x7AC09B0", Offset = "0x7ABFBB0", VA = "0x187AC09B0")]
				public static LCPECIFPHJB ENKMPBHMOPL(Renderer HLIOBIEFOPB, Material[] OBKMIKGLFEF)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			public readonly IMAHPAJHFNK CGDJICCKAML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			public readonly Transform LANCFJIDGGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			public readonly bool DGCFHFOFIAB;

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public virtual bool HDOOCFAGDPB
			{
				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual bool BEOMBLLGCJK
			{
				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual OFCOHJLOKGA.PFHBFKIKAIN BHMNEOJLJJG
			{
				[Cpp2IlInjected.Token(Token = "0x60002FF")]
				[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "6")]
				get
				{
					return default(OFCOHJLOKGA.PFHBFKIKAIN);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public bool NHMANCHKECK
			{
				[Cpp2IlInjected.Token(Token = "0x6000300")]
				[Cpp2IlInjected.Address(RVA = "0x7ABAFF0", Offset = "0x7ABA1F0", VA = "0x187ABAFF0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x7ABB000", Offset = "0x7ABA200", VA = "0x187ABB000")]
			protected BEDPJPABBGA(IMAHPAJHFNK IJFIDCOKOEA, Transform MGHKIOAIMBJ, bool OIPDGGEKNGN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract IFBEDABPFIF OLLFFNEOLND(List<LCHNAMIBFHG> BGPBFPEAKHH, List<LCHNAMIBFHG> IINIJBMBLCE);

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract LCPECIFPHJB KJHGIBKPHAF(int AEABCPDILIB, PlayerHandBones OKGMBFMALHB);
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		protected class KMEIBHAEHIA : BEDPJPABBGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			protected readonly BodyPartLODs OMDNIFBBGNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			protected readonly Material[] DDMKDNKIFDK;

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x7AC08A0", Offset = "0x7ABFAA0", VA = "0x187AC08A0")]
			public KMEIBHAEHIA(IMAHPAJHFNK IJFIDCOKOEA, BodyPartLODs EGFGNEHMDHK, Material BNBAIIJEFNK, [Optional] Transform MGHKIOAIMBJ, bool OIPDGGEKNGN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x7AC07A0", Offset = "0x7ABF9A0", VA = "0x187AC07A0", Slot = "7")]
			public override IFBEDABPFIF OLLFFNEOLND(List<LCHNAMIBFHG> BGPBFPEAKHH, List<LCHNAMIBFHG> IINIJBMBLCE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x7AC05E0", Offset = "0x7ABF7E0", VA = "0x187AC05E0", Slot = "8")]
			public override LCPECIFPHJB KJHGIBKPHAF(int AEABCPDILIB, PlayerHandBones OKGMBFMALHB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x7AC0830", Offset = "0x7ABFA30", VA = "0x187AC0830", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected class OFDCGGCNKDK : BEDPJPABBGA
		{
			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public override bool HDOOCFAGDPB
			{
				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public override bool BEOMBLLGCJK
			{
				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0x7AC2E00", Offset = "0x7AC2000", VA = "0x187AC2E00", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public ENJNFKLCFEL IDMKPNPAPCA
			{
				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0xA00F90", Offset = "0xA00190", VA = "0x180A00F90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0xA00D60", Offset = "0x9FFF60", VA = "0x180A00D60")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x7AC2F50", Offset = "0x7AC2150", VA = "0x187AC2F50")]
			public OFDCGGCNKDK(IMAHPAJHFNK IJFIDCOKOEA, Transform MGHKIOAIMBJ, ENJNFKLCFEL DLBGMBBCKAG, bool OIPDGGEKNGN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x7AC2E50", Offset = "0x7AC2050", VA = "0x187AC2E50", Slot = "7")]
			public override IFBEDABPFIF OLLFFNEOLND(List<LCHNAMIBFHG> BGPBFPEAKHH, List<LCHNAMIBFHG> IINIJBMBLCE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "8")]
			public override LCPECIFPHJB KJHGIBKPHAF(int AEABCPDILIB, PlayerHandBones OKGMBFMALHB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x7AC2EE0", Offset = "0x7AC20E0", VA = "0x187AC2EE0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public class IGEKHCEKFLI
		{
			[Cpp2IlInjected.Token(Token = "0x200005F")]
			public enum DNCNBKFHFDO
			{
				[Cpp2IlInjected.Token(Token = "0x4000381")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x4000382")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x4000383")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x4000384")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x4000385")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x4000386")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x4000387")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x4000371")]
			public static readonly int AGPJCJHHLLL;

			[Cpp2IlInjected.Token(Token = "0x4000372")]
			public static readonly int FFKMOLNDPKL;

			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public static readonly int KPGBFKDJCGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			protected readonly LOPBLGBJOCJ HGFILEJONAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			protected readonly MHIIEDDJGIL BEOPEFCLFPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			protected readonly Animator JMFKPOMLHBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			protected readonly Transform KNHNMLKIAHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			public Vector3 BCCJAHKMJHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			protected readonly Transform HKKNBCGGENL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public Vector3 ANNOJBPEGKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			protected bool KKOEHKNENKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			protected JGDIKKCCKEJ MILKCIOAPBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			protected bool EEBPMAIONOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			protected float ABMDOMDJELK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			protected CIBEOOPMHLB<CIGCOHPAJFE> OEBMKJNFHAO;

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public JGDIKKCCKEJ KGOPBNJIMGH
			{
				[Cpp2IlInjected.Token(Token = "0x6000315")]
				[Cpp2IlInjected.Address(RVA = "0xA00350", Offset = "0x9FF550", VA = "0x180A00350")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000316")]
				[Cpp2IlInjected.Address(RVA = "0xA003D0", Offset = "0x9FF5D0", VA = "0x180A003D0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public bool BLOLNDGBFFN
			{
				[Cpp2IlInjected.Token(Token = "0x6000317")]
				[Cpp2IlInjected.Address(RVA = "0xC6A590", Offset = "0xC69790", VA = "0x180C6A590")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000318")]
				[Cpp2IlInjected.Address(RVA = "0x7ABF880", Offset = "0x7ABEA80", VA = "0x187ABF880")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public bool DABAIFGDGPP
			{
				[Cpp2IlInjected.Token(Token = "0x6000319")]
				[Cpp2IlInjected.Address(RVA = "0xA0FD10", Offset = "0xA0EF10", VA = "0x180A0FD10")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600031A")]
				[Cpp2IlInjected.Address(RVA = "0x7ABF2D0", Offset = "0x7ABE4D0", VA = "0x187ABF2D0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public float MCKABGHEDFO
			{
				[Cpp2IlInjected.Token(Token = "0x600031B")]
				[Cpp2IlInjected.Address(RVA = "0xCECA70", Offset = "0xCEBC70", VA = "0x180CECA70")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600031C")]
				[Cpp2IlInjected.Address(RVA = "0x7ABEE30", Offset = "0x7ABE030", VA = "0x187ABEE30")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public CIGCOHPAJFE NLLEDCBKHDH
			{
				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x7ABF4C0", Offset = "0x7ABE6C0", VA = "0x187ABF4C0")]
				get
				{
					return default(CIGCOHPAJFE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x7ABF660", Offset = "0x7ABE860", VA = "0x187ABF660")]
			public bool LDGCAHEIIBB(CIGCOHPAJFE HPKELKBJOMB, object CCLFNPCGNED, DNCNBKFHFDO JKPJMPOAKPP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x7ABF500", Offset = "0x7ABE700", VA = "0x187ABF500")]
			public bool JMCABFOPKDL(object CCLFNPCGNED)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x7ABFFE0", Offset = "0x7ABF1E0", VA = "0x187ABFFE0")]
			protected IGEKHCEKFLI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x7ABF9F0", Offset = "0x7ABEBF0", VA = "0x187ABF9F0")]
			public IGEKHCEKFLI(LOPBLGBJOCJ HGFILEJONAL, JGDIKKCCKEJ MGAEGJMNIDC, Animator JMFKPOMLHBE, Transform KNHNMLKIAHI, Transform HKKNBCGGENL, Vector3 BCCJAHKMJHF, Vector3 ANNOJBPEGKJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x7ABF220", Offset = "0x7ABE420", VA = "0x187ABF220")]
			private void FKMLAJOIKMO(ushort CLKJFGHPCGI, ushort MOPEDMAOPED)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x7ABEFC0", Offset = "0x7ABE1C0", VA = "0x187ABEFC0")]
			protected void DPBMBLAHMIG(ushort CLKJFGHPCGI, ushort MOPEDMAOPED)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x7ABED70", Offset = "0x7ABDF70", VA = "0x187ABED70")]
			protected void AGPCEKNCBFK(ushort CLKJFGHPCGI, ushort MOPEDMAOPED)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x7ABF0B0", Offset = "0x7ABE2B0", VA = "0x187ABF0B0")]
			protected void EDHAFGDBLHG(ushort CLKJFGHPCGI, ushort MOPEDMAOPED)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x7ABF770", Offset = "0x7ABE970", VA = "0x187ABF770")]
			protected void ODCJACOHBLG(ushort CLKJFGHPCGI, ushort MOPEDMAOPED)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x7ABF600", Offset = "0x7ABE800", VA = "0x187ABF600")]
			protected void KCEEOBOJLNK(ushort CLKJFGHPCGI, ushort MOPEDMAOPED)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x7ABF1D0", Offset = "0x7ABE3D0", VA = "0x187ABF1D0")]
			protected void FFKPNLAFDAE(ushort CLKJFGHPCGI, ushort MOPEDMAOPED)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x7ABEF70", Offset = "0x7ABE170", VA = "0x187ABEF70")]
			protected void CPBMMOOLMBF(ushort CLKJFGHPCGI, ushort MOPEDMAOPED)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x7ABF3A0", Offset = "0x7ABE5A0", VA = "0x187ABF3A0")]
			protected void HGELNBAACBL(ushort CLKJFGHPCGI, ushort MOPEDMAOPED)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public class CCBJLAOFPGH : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public const int MBCKIALFBDG = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			protected MaterialPropertyBlock HIKNCHLLPAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public Color? KEALDPKKGME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			public Color? DMAELKGLJDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			public Color? LEMEEKBFAEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public Color OJNBGOCKKCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public Color PLJGNDIDJLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public Color NBJIIPDINBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			public Texture2D KJFEENGAMOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public Texture2D NHDCDNEEOLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			protected Dictionary<HMOHBGHPGFH, int> BJLGOJMOHMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			protected DAOCHEFLGPC[] JDDPCNDHMLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			public Vector4[] BJEJOGOJNFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			public Vector4[] NFBFKNMGELJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public Vector4[] LDIEGKAIMGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			public Vector4[] HGIJPHMDMLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public Vector4[] KLDNDLFICDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			public Vector4[] DOGGEJPHKAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			protected List<Texture2D> CCMMEHPIPID;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			protected Vector4[] ILFABGPMJOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			protected List<Texture2D> KFCILNODIFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			protected float[] ALJDBKGCCBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			protected Vector4[] POGAFMKBENB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			protected float[] IDOPNHMDFIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public float[] PAAPEENELGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			protected List<Texture2D> NGPDEBODPMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			protected float[] DAOKFIJENFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			protected List<Texture2D> JFDEIFKIPBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			protected Vector4[] IINHFKILEJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			protected float[] MELPLLDNPLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected Vector4[] EMDKELCMGPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			public float[] KNJAMCDNOLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public Texture2DArray MDBHMDHEPPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			public Texture2DArray LKHEALHOKFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			public Texture2DArray MMDGOEJIHNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			public Texture2DArray CIEKPFDGNMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			protected bool LCBBMLEPPGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			protected int DDBHIOPNOIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected Vector2? OOIIAOPHCKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected TextureFormat MJHABIPGEBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected Vector2? BLMLPKBOKJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected TextureFormat OFGIABEKNFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected Vector2? LOGOHCLBMCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			protected TextureFormat FJAJHLHAPJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			protected Vector2? MBFLMMIDJGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			protected TextureFormat EJBBJJEPKPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			protected bool OLFOBLPNEEI;

			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			protected static int PDFACAMOEFC;

			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			protected static int AGGNBGGILJA;

			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			protected static int AMBHEEJPFAD;

			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			protected static int CCKFANOBCJH;

			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			protected static int PIFLKEHBMME;

			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			protected static int POCDLHDHOHB;

			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			protected static int KNHHFALODOC;

			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			protected static int FJNCHBBEPGB;

			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			protected static int GFFHCFBKNMD;

			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			protected static int BLMALGOGEDB;

			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			protected static int MHFNGIDCFDK;

			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			protected static int JCKCEJAEMEN;

			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			protected static int DHODHHCHNLD;

			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			protected static int IAIJAONNPEN;

			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			protected static int FAOJFBMMMJM;

			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			protected static int NDAFONDDDFJ;

			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			protected static int FBFGBEFPFHB;

			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			protected static int CKHDBPFIABE;

			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			protected static int HIPDNJBCODD;

			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			protected static int GAFOAJKCCHP;

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x7ABD830", Offset = "0x7ABCA30", VA = "0x187ABD830")]
			protected CCBJLAOFPGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x7ABDCF0", Offset = "0x7ABCEF0", VA = "0x187ABDCF0")]
			public CCBJLAOFPGH(Color FJBBDCIGNIM, Color IFBPHDAFOJK, Color BPHECAPGKOO, Color? OEHKLAGCKAN, Color? GKLKNBLIFFJ, Color? GEOAJLAOKBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x7ABD360", Offset = "0x7ABC560", VA = "0x187ABD360")]
			public int NPMAKKCAJKL(Material DOIIOKCOKGP, DAOCHEFLGPC FOKAHLNIEMH, ODDDMHELDCK EBFFCEPFLBJ, IMAHPAJHFNK IJFIDCOKOEA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x7ABD450", Offset = "0x7ABC650", VA = "0x187ABD450")]
			public int NPMAKKCAJKL(HMOHBGHPGFH MHDODBCCAJB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x7ABC670", Offset = "0x7ABB870", VA = "0x187ABC670")]
			public int MECGLAFJCPA(Material DOIIOKCOKGP, Color OOAACLAMGKN, Color IAGDMFKAEKM, Color DGPIDCHBFIL, Color BLGNDOHMHGF, Color EOMHOBIIELH, Texture2D DAHLNEHLDKE, Vector4 GALGCGLIEHG, Texture2D NANFHAMOAOC, Vector4 LFAIMCEPOLN, float JIPHGKCGIPI, float DFHMGPBBMGK, Texture2D IBPOLANBDAK, Vector4 KCFICFEGMDC, float EBKLAACLBDB, Texture2D EMIIPLJBHCK, float IMIJGOAPEHH, Color ABKNPJOBOFP, Vector4 CPNDNBNGIBB, DAOCHEFLGPC FOKAHLNIEMH, ODDDMHELDCK EBFFCEPFLBJ, IMAHPAJHFNK IJFIDCOKOEA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x7ABBED0", Offset = "0x7ABB0D0", VA = "0x187ABBED0")]
			protected void DELMONAKBCK([Out] Texture2DArray COFOOPOFACG, [Out] Texture2DArray IHMOMKFFHJD, [Out] Texture2DArray GIFHICLAOOH, [Out] Texture2DArray OBJJMIOFPCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x7ABC0D0", Offset = "0x7ABB2D0", VA = "0x187ABC0D0")]
			public void GNDMEPLBNEP(PlayerAvatarDisplayBase LHMJJAACHGE, Renderer HLIOBIEFOPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x7ABB350", Offset = "0x7ABA550", VA = "0x187ABB350")]
			protected void ALCGEFMEGCM(PlayerAvatarDisplayBase LHMJJAACHGE, Renderer HLIOBIEFOPB, int KLGMOKNJKJF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x7ABC330", Offset = "0x7ABB530", VA = "0x187ABC330")]
			private Color IMOHPNAIFEL(Color ODPAECLFGIC, DAOCHEFLGPC DBDFKFEEDLP)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x7ABC520", Offset = "0x7ABB720", VA = "0x187ABC520")]
			private Color KIMOADNNFCN(Color IKMBGKJMHCL, DAOCHEFLGPC DBDFKFEEDLP)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x7ABBE40", Offset = "0x7ABB040", VA = "0x187ABBE40")]
			protected void BHPDIAJAGFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x7ABC090", Offset = "0x7ABB290", VA = "0x187ABC090", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x7AC9610", Offset = "0x7AC8810", VA = "0x187AC9610")]
			public void HIJLFFILDMN(IMAHPAJHFNK IJFIDCOKOEA, [Out] Transform OLEJNEHCCLF, [Out] Transform[] NEHDPDMMIDH)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class NJCEAFMMHGB : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000345")]
				[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000347")]
				[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0xED9970", Offset = "0xED8B70", VA = "0x180ED9970")]
			[DebuggerHidden]
			public NJCEAFMMHGB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x7AC1E90", Offset = "0x7AC1090", VA = "0x187AC1E90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x7AC2110", Offset = "0x7AC1310", VA = "0x187AC2110", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x7AC2060", Offset = "0x7AC1260", VA = "0x187AC2060", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x7AC2060", Offset = "0x7AC1260", VA = "0x187AC2060", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class ANMFOCHDNGD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public ANMFOCHDNGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x7ABAF10", Offset = "0x7ABA110", VA = "0x187ABAF10")]
			internal bool FKOMDIDHPDE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class NLKLLOGCAMH : IEnumerator<NOFGPJFCPHG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			private NOFGPJFCPHG <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			private NOFGPJFCPHG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600034F")]
				[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000351")]
				[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
			[DebuggerHidden]
			public NLKLLOGCAMH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x7AC2160", Offset = "0x7AC1360", VA = "0x187AC2160", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x7AC24A0", Offset = "0x7AC16A0", VA = "0x187AC24A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private struct LJNMLMCNGNP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			public MLFDDOBOAFD avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x7AC1330", Offset = "0x7AC0530", VA = "0x187AC1330", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x7AC16D0", Offset = "0x7AC08D0", VA = "0x187AC16D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class ODLPIIIAEJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public ODLPIIIAEJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x7AC2DD0", Offset = "0x7AC1FD0", VA = "0x187AC2DD0")]
			internal bool CJFFGAGBNEB(OALMANNFHKO selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class IKANDCKBELI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public Func<GFHJFJDJPFP<Dictionary<string, HLHLINEFKHE<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public IKANDCKBELI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x7AC0070", Offset = "0x7ABF270", VA = "0x187AC0070")]
			internal (ABAHHGGDFBO, GFHJFJDJPFP<Dictionary<string, HLHLINEFKHE<Texture2D>>>) DLKFGAGPFIO(Dictionary<string, PNMBCADMOBD> avatarItems)
			{
				return default((ABAHHGGDFBO, GFHJFJDJPFP<Dictionary<string, HLHLINEFKHE<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x7AC02B0", Offset = "0x7ABF4B0", VA = "0x187AC02B0")]
			internal GFHJFJDJPFP<Dictionary<string, HLHLINEFKHE<Texture2D>>> PHEDMDAKDCL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x7AC0270", Offset = "0x7ABF470", VA = "0x187AC0270")]
			internal void KJGLDABKHGF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class KHCMGGCHECI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public KHCMGGCHECI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x7AC0530", Offset = "0x7ABF730", VA = "0x187AC0530")]
			internal bool FDJNNAKHEEN(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private struct HLJHFLIMPPF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x7ABE220", Offset = "0x7ABD420", VA = "0x187ABE220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x7ABE3F0", Offset = "0x7ABD5F0", VA = "0x187ABE3F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		protected static readonly int OAPKLNAHDAA;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		protected static readonly int BFBIOGCMNHK;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		protected static readonly int FDBEHLAHMCL;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		protected static readonly int MMIPBIHFILL;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		protected static readonly int DDOGHDBNNCP;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		protected static readonly int OHNOCBDFBLD;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		protected static readonly int[] IHCKEBLAJDK;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		protected static readonly int[] KDAHKDADAKK;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		protected static readonly int[] OEFKONKPOJK;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		protected static readonly int[] EOFLGLJLCFM;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		protected static readonly int[] ELECCPHNKEP;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		protected static readonly int[] AAKLBIJBMIC;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		protected static List<PlayerAvatarDisplayBase> EAHGAFIKIDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		protected DDKMPEMLOPH BMBLNBNPKOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		protected bool BHPLJHDNKEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		protected bool KOPMEOMCANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		protected static readonly int[] BKDLIFKAJEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private KFLIBLCDICB GJPOHIHLHEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		protected Dictionary<HMOHBGHPGFH, Material> BJBFIFPDLBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		protected Dictionary<HMOHBGHPGFH, Material> PCPCMPHIEFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		[SerializeField]
		public Transform remoteMeshBase;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		protected Material CIIGCAMJCDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		protected KONLHIGFPIP EHEIJGAJEGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private JGDIKKCCKEJ NOOECKKAIKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private JGDIKKCCKEJ MCHKFGJOIAC;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		protected Material PAMPAOFEFFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		[SerializeField]
		public Transform hemisphereBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		protected FitMeshHemisphere PBACKOPNEGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		protected bool LEOHPPDAHIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		protected BCHLBCJFNPL EDMINDCIDKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected bool CLLLKLCHHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected AnchorParamsRestrictions IPBKGGDOFFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		protected bool BNIDMLEDAAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		protected Transform OALAENNALCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		protected bool DCCCAHKOKKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B9")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		protected bool FADCHHEGEOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		protected Vector3 KFLJDFJHCDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		protected Quaternion GDHDJBPJGPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		protected Vector2 NFAHLNENFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		protected FitMeshHemisphere GAPMMHBLLBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		[SerializeField]
		[GBCGIPBAICF(CFJMFGLCHFI.SelfAndChildren, false, false, false)]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		protected Collider[] PHFPGMGOIPD;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		protected Collider[] FFDEMFFBDMF;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		protected IGEKHCEKFLI[] KKBIHEJJCCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public Dictionary<Renderer, CCBJLAOFPGH> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		protected Dictionary<Renderer, CCBJLAOFPGH> MKJGALLNABB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		protected EEEBGEKGGJE AALNOEABMHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected ABAHHGGDFBO FCMFLLELJDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public DLGGNNMFNFI DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected int GHGGPEOCBFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		protected (bool isLodForced, int forcedLOD) PGDODCOGPIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		protected CIBEOOPMHLB<MHIIEDDJGIL> OEBMKJNFHAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected bool EOGOPPDMGJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected Dictionary<OALMANNFHKO, List<HMOHBGHPGFH>> HKKOOBCNKCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		protected Dictionary<OALMANNFHKO, List<HMOHBGHPGFH>> EHKLFPNJHIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected readonly Dictionary<string, HLHLINEFKHE<Texture2D>> HMJJLIPBINL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected readonly Dictionary<string, HLHLINEFKHE<Texture2D>> LJNACCPOPNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected bool KEBNJEPMNBG;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected static int BCPEOMHHMAL;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected static List<EPAMDCLFPEM> NOEKDOCGGBH;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected static List<EPAMDCLFPEM> HPAIMHGMMFJ;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected static AFABIGEDGFJ OFLCKACNOLL;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected static Func<List<EPAMDCLFPEM>, EPAMDCLFPEM> MCBCIKCFMDE;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		protected static bool EKOKMMHIJFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		protected Color? OMCFFOHCAHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2EC")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		protected bool FBMHJOAKNNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		protected Color FHCJGFDFEGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		protected Color PNCJAKAAJIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		protected Color LCNPHMJKAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		protected AvatarHairPattern AKCMKKBOKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		protected ENJNFKLCFEL CPHOFCLBKGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		protected Color PFGHFLNNCMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		protected Color JPOKCLKBFJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected AvatarHairPattern KDNLFKEJIND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected ENJNFKLCFEL ALMHLIBJEMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected ENJNFKLCFEL FDMINEHAHAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected Color KLMHLPNIEOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private AdditionalFeetData PBHHBAJFBCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		protected OALMANNFHKO? IMIBKOEMCEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		protected Texture AINABEOBDBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected Color FBHKNMOOCAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		protected readonly IList<OALMANNFHKO> OIHKNEBNGBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		protected readonly IList<OALMANNFHKO> OHLENOKGEDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private AvatarItemBodyType IDHOILPFGLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		[SerializeField]
		protected BDJFFDNIHPO _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3DC")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3DD")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		protected PONEJIJAIEB EBAODALGOML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		protected int[] BNKBLKLBLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		protected bool EHNNNBBBLNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		protected int[] PCFOCBLMCLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		protected bool IGPJOPOAMIP;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private static readonly OFCOHJLOKGA.PFHBFKIKAIN NHFLAEEHMKF;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private static readonly OFCOHJLOKGA.PFHBFKIKAIN HDPGKFJFKJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F9")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		protected bool JDAHJALFPFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		protected BOPLBKOIMNN LPPMJHGKMAA;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string FIPAENNLJID
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0xA00F50", Offset = "0xA00150", VA = "0x180A00F50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xA0D3E0", Offset = "0xA0C5E0", VA = "0x180A0D3E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool APHNCIJJOGN
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0xC656A0", Offset = "0xC648A0", VA = "0x180C656A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0xC64C90", Offset = "0xC63E90", VA = "0x180C64C90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool LLOKHICAHLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool KGPKFMHFKAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x7AB93F0", Offset = "0x7AB85F0", VA = "0x187AB93F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool HNOCBPCDPBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool BNKMKJBJCOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual bool BKFIKKMFEFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public KONLHIGFPIP DANBHDDELJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xB067F0", Offset = "0xB059F0", VA = "0x180B067F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x7AB9BE0", Offset = "0x7AB8DE0", VA = "0x187AB9BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public JGDIKKCCKEJ DJJEFJOLIHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xB20000", Offset = "0xB1F200", VA = "0x180B20000")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x7AB9FE0", Offset = "0x7AB91E0", VA = "0x187AB9FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public JGDIKKCCKEJ ILHIHBIPNHN
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xB14690", Offset = "0xB13890", VA = "0x180B14690")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x7ABA2B0", Offset = "0x7AB94B0", VA = "0x187ABA2B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		protected Material CNEKGLAIIJK
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x7AAD880", Offset = "0x7AACA80", VA = "0x187AAD880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		protected Material KBFLKLOKPAF
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x7AAF8E0", Offset = "0x7AAEAE0", VA = "0x187AAF8E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool HGAAEPLOGKH
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xB0A240", Offset = "0xB09440", VA = "0x180B0A240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public PlayerFacialAnimatorBase JFCLJGDHAHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xA89D50", Offset = "0xA88F50", VA = "0x180A89D50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public IGEKHCEKFLI[] IMMOKLCIIKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x7AB8F80", Offset = "0x7AB8180", VA = "0x187AB8F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public IGEKHCEKFLI IBMHJHLPMDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x7AB95F0", Offset = "0x7AB87F0", VA = "0x187AB95F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public IGEKHCEKFLI KHNEOLFJPLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x7AB9630", Offset = "0x7AB8830", VA = "0x187AB9630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Mesh MMKPEJBBEMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0xB20FE0", Offset = "0xB201E0", VA = "0x180B20FE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected EEEBGEKGGJE HFEGHJKPKGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x7AB1A10", Offset = "0x7AB0C10", VA = "0x187AB1A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected ABAHHGGDFBO GPBOAEKJNGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0xB20D00", Offset = "0xB1FF00", VA = "0x180B20D00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x7AAD5C0", Offset = "0x7AAC7C0", VA = "0x187AAD5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		protected bool GBFJNBINHDN
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public bool KONICDABCMM
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x7AB95E0", Offset = "0x7AB87E0", VA = "0x187AB95E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public int FJIENIKJNHB
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x7AB9620", Offset = "0x7AB8820", VA = "0x187AB9620")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x7ABA1F0", Offset = "0x7AB93F0", VA = "0x187ABA1F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public int OANPCFJACBF
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x7AB9F30", Offset = "0x7AB9130", VA = "0x187AB9F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected virtual bool MCNCPJDIJDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected virtual int[] HMAODKJNEHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x7AAEF60", Offset = "0x7AAE160", VA = "0x187AAEF60", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected bool GOFMKIGLDMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x7AAF7E0", Offset = "0x7AAE9E0", VA = "0x187AAF7E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		protected static bool IDGLLAIJABL
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool BMCAJFPBCAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x7AB9660", Offset = "0x7AB8860", VA = "0x187AB9660")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x7ABA4C0", Offset = "0x7AB96C0", VA = "0x187ABA4C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public IEnumerable<SkinnedMeshRenderer> NNNHDMDCGEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x7AB8E50", Offset = "0x7AB8050", VA = "0x187AB8E50")]
			[IteratorStateMachine(typeof(NJCEAFMMHGB))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public bool CFMEGCKFFEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x7AB95D0", Offset = "0x7AB87D0", VA = "0x187AB95D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x7AB0FE0", Offset = "0x7AB01E0", VA = "0x187AB0FE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public HIEAKOJGBND JKDIFCDGINC
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x7AB8ED0", Offset = "0x7AB80D0", VA = "0x187AB8ED0")]
			get
			{
				return default(HIEAKOJGBND);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public static bool JIBMPCHPOKG
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x7AB9320", Offset = "0x7AB8520", VA = "0x187AB9320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		protected static AFABIGEDGFJ NCIMOMDPCDF
		{
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x7AAEF10", Offset = "0x7AAE110", VA = "0x187AAEF10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x7AB3680", Offset = "0x7AB2880", VA = "0x187AB3680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected Color DMAELKGLJDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x7AB1010", Offset = "0x7AB0210", VA = "0x187AB1010")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected Color LEMEEKBFAEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x7AB3370", Offset = "0x7AB2570", VA = "0x187AB3370")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected Texture2D HGNGALIDGPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x7AB1460", Offset = "0x7AB0660", VA = "0x187AB1460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected Color OJNBGOCKKCO
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x7AB0360", Offset = "0x7AAF560", VA = "0x187AB0360")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		protected Color PLJGNDIDJLL
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x7AB1A30", Offset = "0x7AB0C30", VA = "0x187AB1A30")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public ENJNFKLCFEL JAGDDGLEEPG
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x7AB8F40", Offset = "0x7AB8140", VA = "0x187AB8F40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		protected Texture2D PEDFELPGCFL
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x7AAC2B0", Offset = "0x7AAB4B0", VA = "0x187AAC2B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public float HGEDHMDHCJP
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x7AB8F60", Offset = "0x7AB8160", VA = "0x187AB8F60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public float JFONOHMBIED
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x7AB93D0", Offset = "0x7AB85D0", VA = "0x187AB93D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public bool KMICKKGIACM
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x7AB8F30", Offset = "0x7AB8130", VA = "0x187AB8F30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x7AB99B0", Offset = "0x7AB8BB0", VA = "0x187AB99B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action PHKOIPEGNLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x7AB8BB0", Offset = "0x7AB7DB0", VA = "0x187AB8BB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x7AB9710", Offset = "0x7AB8910", VA = "0x187AB9710")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action PMIAOKCGIEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x7AB8B10", Offset = "0x7AB7D10", VA = "0x187AB8B10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x7AB9670", Offset = "0x7AB8870", VA = "0x187AB9670")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action CGECLEEICNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x7AB8C50", Offset = "0x7AB7E50", VA = "0x187AB8C50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x7AB97B0", Offset = "0x7AB89B0", VA = "0x187AB97B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action FOIADDDONPA
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x7AB8CF0", Offset = "0x7AB7EF0", VA = "0x187AB8CF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x7AB9850", Offset = "0x7AB8A50", VA = "0x187AB9850")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<LOPBLGBJOCJ, CIGCOHPAJFE> IKDCLBGAJID
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x7AB8D90", Offset = "0x7AB7F90", VA = "0x187AB8D90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x7AB98F0", Offset = "0x7AB8AF0", VA = "0x187AB98F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7AB5350", Offset = "0x7AB4550", VA = "0x187AB5350")]
		public bool SetDeformation(bool BHPLJHDNKEK, bool KOPMEOMCANO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x7AB0200", Offset = "0x7AAF400", VA = "0x187AB0200")]
		protected static Material HDGHGCGFKOB(Dictionary<HMOHBGHPGFH, Material> JLFNPKMGHJJ, Material FMIIFBCPDFC, DAOCHEFLGPC FOKAHLNIEMH, ODDDMHELDCK EBFFCEPFLBJ, IMAHPAJHFNK IJFIDCOKOEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7AB0E00", Offset = "0x7AB0000", VA = "0x187AB0E00")]
		protected void JGKDGDPMOLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7AAD660", Offset = "0x7AAC860", VA = "0x187AAD660")]
		protected bool CIAMEHKOLLH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1A80", Offset = "0x7AB0C80", VA = "0x187AB1A80")]
		protected void MFBKCNICLKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2EF0", Offset = "0x7AB20F0", VA = "0x187AB2EF0", Slot = "10")]
		protected virtual void NOBAJCHEAKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1C20", Offset = "0x7AB0E20", VA = "0x187AB1C20")]
		public int MeshesAtLODCount(int PBPMKAHJNBC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7AB33C0", Offset = "0x7AB25C0", VA = "0x187AB33C0")]
		protected static void ONLPEIBFEJN(Dictionary<OALMANNFHKO, List<HMOHBGHPGFH>> ABMKJAEMGBO, BEDPJPABBGA DNFFJPLECHG, Material FMIIFBCPDFC, DAOCHEFLGPC DBDFKFEEDLP, ODDDMHELDCK LBHPCBIADNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x7AACC70", Offset = "0x7AABE70", VA = "0x187AACC70")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7AAEB40", Offset = "0x7AADD40", VA = "0x187AAEB40")]
		protected void EIJBJDKHPFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7AB39D0", Offset = "0x7AB2BD0", VA = "0x187AB39D0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "11")]
		protected virtual void HGNMNKNNFCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7AB7660", Offset = "0x7AB6860", VA = "0x187AB7660")]
		public void StartAvatarEffect(KFLIBLCDICB ILBANLMHCAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7AAB810", Offset = "0x7AAAA10", VA = "0x187AAB810")]
		protected static void AALPPLEDCPD(List<Material> ABPFCHFOOIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7AAF9D0", Offset = "0x7AAEBD0", VA = "0x187AAF9D0")]
		protected static void GJOKIDFDDNB(Dictionary<HMOHBGHPGFH, Material> JLFNPKMGHJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1550", Offset = "0x7AB0750", VA = "0x187AB1550")]
		protected static void MDFAPIGKCPI(Dictionary<Renderer, CCBJLAOFPGH> IHNJNLPDLNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7AB06A0", Offset = "0x7AAF8A0", VA = "0x187AB06A0")]
		protected void IDIMDADBGEB(SkinnedMeshRenderer[] NMHABIBPCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7AAF430", Offset = "0x7AAE630", VA = "0x187AAF430")]
		protected void FOMBJAJPCDG(SkinnedMeshRenderer DNCAJBICKKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7AAF360", Offset = "0x7AAE560", VA = "0x187AAF360")]
		protected void FOMBJAJPCDG(MeshRenderer IMGLNPHBCNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7AB09C0", Offset = "0x7AAFBC0", VA = "0x187AB09C0")]
		protected void ILEHBHHHADN(List<LCHNAMIBFHG> GFDBOJJNEPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7AAEFF0", Offset = "0x7AAE1F0", VA = "0x187AAEFF0")]
		protected void FFENHILALJE(Dictionary<string, HLHLINEFKHE<Texture2D>> ABMKJAEMGBO, bool DPDNGKGLEEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x7AACFA0", Offset = "0x7AAC1A0", VA = "0x187AACFA0")]
		protected void BIAJLEPACOI(Dictionary<OALMANNFHKO, List<HMOHBGHPGFH>> ABMKJAEMGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7AAFE80", Offset = "0x7AAF080", VA = "0x187AAFE80")]
		public float GetHandOpenClosedAxis(LOPBLGBJOCJ HGFILEJONAL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7AB5C10", Offset = "0x7AB4E10", VA = "0x187AB5C10")]
		public void SetHandOpenClosedAxis(LOPBLGBJOCJ HGFILEJONAL, float MFPHJLJGEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x7AAFEC0", Offset = "0x7AAF0C0", VA = "0x187AAFEC0")]
		public CIGCOHPAJFE GetHandVisualState(LOPBLGBJOCJ HGFILEJONAL)
		{
			return default(CIGCOHPAJFE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC3B0", Offset = "0x7AAB5B0", VA = "0x187AAC3B0")]
		public bool AddHandVisualStateToken(LOPBLGBJOCJ HGFILEJONAL, CIGCOHPAJFE BHPJKOLIFGB, object CCLFNPCGNED, IGEKHCEKFLI.DNCNBKFHFDO JKPJMPOAKPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7AB74A0", Offset = "0x7AB66A0", VA = "0x187AB74A0")]
		public void SetWatchHand(LOPBLGBJOCJ HGFILEJONAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x7AB7560", Offset = "0x7AB6760", VA = "0x187AB7560")]
		public void SetWatchHands(bool IPFDCEDCPLB, bool KJOHFCIDFFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7AB49F0", Offset = "0x7AB3BF0", VA = "0x187AB49F0")]
		public bool RemoveHandVisualStateToken(LOPBLGBJOCJ HGFILEJONAL, object CCLFNPCGNED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7AAFF40", Offset = "0x7AAF140", VA = "0x187AAFF40")]
		public bool GetThumbsUpActive(LOPBLGBJOCJ HGFILEJONAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x7AB6EB0", Offset = "0x7AB60B0", VA = "0x187AB6EB0")]
		public void SetThumbsUpActive(LOPBLGBJOCJ HGFILEJONAL, bool COBHFDICKGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7AAFF00", Offset = "0x7AAF100", VA = "0x187AAFF00")]
		public bool GetHandshakeActive(LOPBLGBJOCJ HGFILEJONAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7AB5C60", Offset = "0x7AB4E60", VA = "0x187AB5C60")]
		public void SetHandshakeActive(LOPBLGBJOCJ HGFILEJONAL, bool PKAMLHHKKGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7AAF4D0", Offset = "0x7AAE6D0", VA = "0x187AAF4D0")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7AB7390", Offset = "0x7AB6590", VA = "0x187AB7390")]
		public void SetUseClassicBeanHandScale(bool KJIOHKMJAPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7AAE0C0", Offset = "0x7AAD2C0", VA = "0x187AAE0C0")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7AB45D0", Offset = "0x7AB37D0", VA = "0x187AB45D0")]
		private static void POJKAJAJCJP(Scene FFNEFMEEJGM, LoadSceneMode CPNALAHLBCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7AAF520", Offset = "0x7AAE720", VA = "0x187AAF520")]
		protected static void GFINCPHBNMF(PlayerAvatarDisplayBase JAOJJLPPEFC, List<EPAMDCLFPEM> EBANOECANED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7AB4700", Offset = "0x7AB3900", VA = "0x187AB4700")]
		public IFBEDABPFIF Rebuild(bool OEDAICNDENJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3970", Offset = "0x7AB2B70", VA = "0x187AB3970")]
		protected IFBEDABPFIF OOPACPNOLEE(bool OEDAICNDENJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3840", Offset = "0x7AB2A40", VA = "0x187AB3840", Slot = "12")]
		protected virtual IFBEDABPFIF OOPACPNOLEE(IList<OALMANNFHKO> CIHDIIAELAH, AvatarItemBodyType OJEBIGAJECD, bool KPBGNFHBGEF, bool MJHPDALHIOK, int[] OMMFMMGIJGA, bool OEDAICNDENJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7AABD60", Offset = "0x7AAAF60", VA = "0x187AABD60")]
		protected static IFBEDABPFIF ANLFPPMJEHP(EPAMDCLFPEM PIKJPDGJKFA, List<EPAMDCLFPEM> EBANOECANED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3FC0", Offset = "0x7AB31C0", VA = "0x187AB3FC0")]
		[IteratorStateMachine(typeof(NLKLLOGCAMH))]
		protected static IEnumerator<NOFGPJFCPHG> PIPPNOCNCBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7AB4540", Offset = "0x7AB3740", VA = "0x187AB4540")]
		protected static EPAMDCLFPEM PLPHLNMHGPF(List<EPAMDCLFPEM> EBANOECANED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7AB5460", Offset = "0x7AB4660", VA = "0x187AB5460")]
		[AsyncStateMachine(typeof(LJNMLMCNGNP))]
		public Task SetFaceCustomizationSettings(MLFDDOBOAFD NMNBELDFILE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7AB7750", Offset = "0x7AB6950", VA = "0x187AB7750")]
		public bool UpdateFaceAndBodyCustomizationSettings(MLFDDOBOAFD NMNBELDFILE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7AB0BA0", Offset = "0x7AAFDA0", VA = "0x187AB0BA0")]
		public void InitializeFaceFeatures(AvatarConfiguration BJGFMCPJJIG, HIEAKOJGBND LNEJDOLFDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7AB6C00", Offset = "0x7AB5E00", VA = "0x187AB6C00")]
		public void SetTeamColors(Color? GEOAJLAOKBM, bool AMCGDKJKLOH, Color GBBJLMCBOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x138E5D0", Offset = "0x138D7D0", VA = "0x18138E5D0")]
		private static void GALKKLEKDPA(Material ADKDGJDNNAD, Color KJIOHKMJAPE, params int[] FINHHENDEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x138E530", Offset = "0x138D730", VA = "0x18138E530")]
		private static void FKEKCDCJCPJ(Material ADKDGJDNNAD, Texture KJIOHKMJAPE, params int[] FINHHENDEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7AAFF80", Offset = "0x7AAF180", VA = "0x187AAFF80")]
		protected void HAFHDLOBOBC(Material ILLMPLHNFFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1340", Offset = "0x7AB0540", VA = "0x187AB1340")]
		protected void LOHPMEKFJNI(Material ILLMPLHNFFF, Color NKNGBDFNEBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7AAFB30", Offset = "0x7AAED30", VA = "0x187AAFB30")]
		protected void GKAPNNPCEIK(Material ILLMPLHNFFF, Color NKNGBDFNEBI, Color FPHJIBHLLML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1130", Offset = "0x7AB0330", VA = "0x187AB1130")]
		protected void LHOLNAKGLJB(Material ILLMPLHNFFF, Texture2D NANHFKKMKAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x7AABA50", Offset = "0x7AAAC50", VA = "0x187AABA50")]
		protected void AMKHNGMJHIO(Material ILLMPLHNFFF, Texture DOOOEHKMAPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7AAD460", Offset = "0x7AAC660", VA = "0x187AAD460")]
		protected void CBEFAAAFPCM(Action<CCBJLAOFPGH> HGHFFKHECAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3CA0", Offset = "0x7AB2EA0", VA = "0x187AB3CA0")]
		protected void PFLNMABLEBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7AAF620", Offset = "0x7AAE820", VA = "0x187AAF620")]
		protected void GFNHGIOOIIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7AB16B0", Offset = "0x7AB08B0", VA = "0x187AB16B0")]
		protected void MDJPFAFCHKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC700", Offset = "0x7AAB900", VA = "0x187AAC700")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7AB4DB0", Offset = "0x7AB3FB0", VA = "0x187AB4DB0")]
		public void SetBeardPrimaryColor([Optional] Color? FCECHHMDJBI, bool HALLHCCLLPJ = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x7AB4FE0", Offset = "0x7AB41E0", VA = "0x187AB4FE0")]
		public void SetBeardSecondaryColor([Optional] Color? FCECHHMDJBI, bool HALLHCCLLPJ = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7AB4C70", Offset = "0x7AB3E70", VA = "0x187AB4C70")]
		public void SetBeardPattern([Optional] AvatarHairPattern MBELMIKBGGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7AAE380", Offset = "0x7AAD580", VA = "0x187AAE380")]
		private void DJFNPAIDFHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1D80", Offset = "0x7AB0F80", VA = "0x187AB1D80")]
		private bool NCALFCNKABI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7AB57D0", Offset = "0x7AB49D0", VA = "0x187AB57D0")]
		public void SetHairPrimaryColor([Optional] Color? KFIIPNIECPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7AB59F0", Offset = "0x7AB4BF0", VA = "0x187AB59F0")]
		public void SetHairSecondaryColor([Optional] Color? KFIIPNIECPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7AB56A0", Offset = "0x7AB48A0", VA = "0x187AB56A0")]
		public void SetHairPattern([Optional] AvatarHairPattern MBELMIKBGGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7AB4890", Offset = "0x7AB3A90", VA = "0x187AB4890")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7AB0F20", Offset = "0x7AB0120", VA = "0x187AB0F20")]
		private bool JMFAEKNADAF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7AB6A40", Offset = "0x7AB5C40", VA = "0x187AB6A40")]
		public void SetSkinColor(Color FJBBDCIGNIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7AB6F00", Offset = "0x7AB6100", VA = "0x187AB6F00")]
		public void SetUgcItemVisualOverrides(OALMANNFHKO NFABKHIKACP, HIEAKOJGBND LNEJDOLFDHE, Texture PDPLEDFJPCI, Color BPCBBJEABPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7AAE190", Offset = "0x7AAD390", VA = "0x187AAE190")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7AB5560", Offset = "0x7AB4760", VA = "0x187AB5560")]
		public bool SetFaceShape(AvatarFaceShape NEAIGBOFLLF, bool DCFIEIBGBID = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2F50", Offset = "0x7AB2150", VA = "0x187AB2F50")]
		private void OJBJMEAMGLN(KGACCJNCEGJ GHAHJIAABMF, float KJIOHKMJAPE, bool CEDCAMKNBED = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7AABB60", Offset = "0x7AAAD60", VA = "0x187AABB60")]
		private void ANHBICNJBGB(OFBJJAHHMJH PFFNLECNGBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7AB4350", Offset = "0x7AB3550", VA = "0x187AB4350")]
		private void PLEPBFCFLLD(FFNJLAPEAAH HLPNHJOANIK, float KJIOHKMJAPE, bool GLCMJMLHLIJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7AB0D60", Offset = "0x7AAFF60", VA = "0x187AB0D60")]
		private void JGBMPODEHFN(NHLAOOPBHOL NMKKJBELNLF, float KJIOHKMJAPE, bool KHEDMEHLNLJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1B10", Offset = "0x7AB0D10", VA = "0x187AB1B10")]
		private void MFOEFBGMGBM(MAMICGLFCPI EMMHBKIBAPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x7AAFD50", Offset = "0x7AAEF50", VA = "0x187AAFD50")]
		private void GOIDNDIFNHD(CMJANKCMOHN IKLCIGECINK, float EOFCODAKHLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7AB5210", Offset = "0x7AB4410", VA = "0x187AB5210")]
		public bool SetBodyShape(AvatarBodyShape NBHBLOFAGDA, bool DCFIEIBGBID = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7AB68D0", Offset = "0x7AB5AD0", VA = "0x187AB68D0")]
		public bool SetNoseType(BDJFFDNIHPO CHPDFJOFFPE, bool DCFIEIBGBID = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x7AB7E30", Offset = "0x7AB7030", VA = "0x187AB7E30")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7AB68B0", Offset = "0x7AB5AB0", VA = "0x187AB68B0")]
		public bool SetHideEars(bool JCHGJLDJOKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7AB68A0", Offset = "0x7AB5AA0", VA = "0x187AB68A0")]
		public bool SetHelmetHair(DDKMPEMLOPH FGNEJDAICAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7AB5CB0", Offset = "0x7AB4EB0", VA = "0x187AB5CB0")]
		public void SetHatAnchorParameters(BCHLBCJFNPL OFNELKDCBFN, bool PFGGKEDJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x7AB7630", Offset = "0x7AB6830", VA = "0x187AB7630")]
		public void SetupDisplayLODs(PONEJIJAIEB CBPGLEFIKFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7AB0810", Offset = "0x7AAFA10", VA = "0x187AB0810")]
		protected int[] IIICDFMMLNA(PONEJIJAIEB CBPGLEFIKFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7AB6970", Offset = "0x7AB5B70", VA = "0x187AB6970")]
		public void SetOutfitSelections(IList<OALMANNFHKO> CIHDIIAELAH, AvatarItemBodyType OJEBIGAJECD, bool MJHPDALHIOK, bool OEDAICNDENJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7AB69F0", Offset = "0x7AB5BF0", VA = "0x187AB69F0")]
		public void SetOutfitSelections(IList<OALMANNFHKO> CIHDIIAELAH, AvatarItemBodyType OJEBIGAJECD, bool KPBGNFHBGEF, bool MJHPDALHIOK, bool OEDAICNDENJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7AB69B0", Offset = "0x7AB5BB0", VA = "0x187AB69B0")]
		public IFBEDABPFIF SetOutfitSelections(IList<OALMANNFHKO> CIHDIIAELAH, AvatarItemBodyType OJEBIGAJECD, PONEJIJAIEB CBPGLEFIKFI, bool KPBGNFHBGEF, bool MJHPDALHIOK, bool DCFIEIBGBID = false, bool OEDAICNDENJ = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7AB0420", Offset = "0x7AAF620", VA = "0x187AB0420", Slot = "13")]
		protected virtual IFBEDABPFIF IBOEJIDFAIP(IList<OALMANNFHKO> CIHDIIAELAH, AvatarItemBodyType OJEBIGAJECD, bool KPBGNFHBGEF, bool MJHPDALHIOK, PONEJIJAIEB CBPGLEFIKFI, bool DCFIEIBGBID, bool OEDAICNDENJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7AAB950", Offset = "0x7AAAB50", VA = "0x187AAB950")]
		protected int[] AJOOJEEFOIG(PONEJIJAIEB CBPGLEFIKFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "14")]
		protected virtual ABAHHGGDFBO BEHNJCHLCJK(AvatarItemBodyType LHNAOOFCGOL, Dictionary<string, PNMBCADMOBD> DNKKJAOEJGE, Dictionary<string, HLHLINEFKHE<Texture2D>> AACEHDGKPHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7AB30A0", Offset = "0x7AB22A0", VA = "0x187AB30A0", Slot = "15")]
		protected virtual IFBEDABPFIF OMGILLJOKNA(IList<OALMANNFHKO> CIHDIIAELAH, AvatarItemBodyType OJEBIGAJECD, bool KPBGNFHBGEF, bool MJHPDALHIOK, int[] OMLNPHJACGI, CJGBLKOPNIO HJHNBDDLJNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7AAE530", Offset = "0x7AAD730", VA = "0x187AAE530", Slot = "16")]
		protected virtual PNMBCADMOBD DNFFJFEJAFH(ENJNFKLCFEL DLBGMBBCKAG, AvatarItemBodyType LHNAOOFCGOL, IMAHPAJHFNK IJFIDCOKOEA, PNMBCADMOBD IBGIDAFBDPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "17")]
		protected virtual PNMBCADMOBD LIGPIKFMOPA(AvatarItemBodyType LHNAOOFCGOL, IMAHPAJHFNK IJFIDCOKOEA, CDJOBBECAIH KOHBDHDNGIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2FF0", Offset = "0x7AB21F0", VA = "0x187AB2FF0")]
		protected void OJNNACNOCHG(FNKGLCNJMMP CMFOHFKLPML, OFCOHJLOKGA.PFHBFKIKAIN KMALHFPGDEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x7AAF860", Offset = "0x7AAEA60", VA = "0x187AAF860")]
		protected void GICKGMBMKDG(FNKGLCNJMMP CMFOHFKLPML, OFCOHJLOKGA.PFHBFKIKAIN KMALHFPGDEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xA7D9B0", Offset = "0xA7CBB0", VA = "0x180A7D9B0", Slot = "18")]
		protected virtual FNKGLCNJMMP HMKKOBIPLJE(FNKGLCNJMMP CMFOHFKLPML, HelmetHairStyle BMILOLLPLCF, bool EPEILGHNPKG, AvatarItemBodyType OJEBIGAJECD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1EF0", Offset = "0x7AB10F0", VA = "0x187AB1EF0")]
		protected FNKGLCNJMMP NIPDGCJIELL(IList<OALMANNFHKO> CIHDIIAELAH, AvatarItemBodyType EPEAIKPMLDA, bool MJHPDALHIOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7AADFA0", Offset = "0x7AAD1A0", VA = "0x187AADFA0")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7AACE50", Offset = "0x7AAC050", VA = "0x187AACE50")]
		protected void BBLHPOKLHAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7AB4020", Offset = "0x7AB3220", VA = "0x187AB4020")]
		protected void PKMJAONMOOK(Transform EGBMMNFPCON, IEnumerable<SkinnedMeshRenderer> FMBOMGOKPBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1E30", Offset = "0x7AB1030", VA = "0x187AB1E30")]
		protected OFCOHJLOKGA.PFHBFKIKAIN NELIPKIMMIK(OFCOHJLOKGA.PFHBFKIKAIN MMNCICHGLOO, IMAHPAJHFNK KIDBDHFMJJA)
		{
			return default(OFCOHJLOKGA.PFHBFKIKAIN);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7AAEF00", Offset = "0x7AAE100", VA = "0x187AAEF00")]
		protected void EOLLDHNIDII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x1308260", Offset = "0x1307460", VA = "0x181308260")]
		protected void NGLMICLBEBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7AAF250", Offset = "0x7AAE450", VA = "0x187AAF250")]
		protected void FMIGGHKJNEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1060", Offset = "0x7AB0260", VA = "0x187AB1060")]
		[AsyncStateMachine(typeof(HLJHFLIMPPF))]
		protected Task LHKPBCBHHEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7AAE1E0", Offset = "0x7AAD3E0", VA = "0x187AAE1E0")]
		protected static DAOCHEFLGPC DHJCHBPEHKA(BEDPJPABBGA HFCGEIPNKJB, int MDGNJPMMNIF)
		{
			return default(DAOCHEFLGPC);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7AB43F0", Offset = "0x7AB35F0", VA = "0x187AB43F0")]
		protected static ODDDMHELDCK PLJFPILMIEB(BEDPJPABBGA HFCGEIPNKJB, int MDGNJPMMNIF)
		{
			return default(ODDDMHELDCK);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7AB07C0", Offset = "0x7AAF9C0", VA = "0x187AB07C0")]
		protected Transform IHGGNLDNKOH(IMAHPAJHFNK IJFIDCOKOEA, OutfitType EKDGILGJAFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x7AAD260", Offset = "0x7AAC460", VA = "0x187AAD260")]
		protected void BPLJAHFEEDD(int MHMJFLDMNFM, Material ADKDGJDNNAD, BEDPJPABBGA HFCGEIPNKJB, [Out] Texture2D PLCBIDGIMLL, [Out] Vector4 CJMMAKEMNBN, [Out] Texture2D MLOEKCPILFC, [Out] Texture2D CCIBLEILBHE, [Out] Texture2D FHHLJKDEEKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7AAD080", Offset = "0x7AAC280", VA = "0x187AAD080")]
		protected void BNAADIOHHMF(int MHMJFLDMNFM, Material ADKDGJDNNAD, BEDPJPABBGA HFCGEIPNKJB, [Out] Color OOAACLAMGKN, [Out] Color IAGDMFKAEKM, [Out] Color DGPIDCHBFIL, [Out] Color BLGNDOHMHGF, [Out] Color EOMHOBIIELH, [Out] Color ABKNPJOBOFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7AB03B0", Offset = "0x7AAF5B0", VA = "0x187AB03B0")]
		protected void HHKACBIABCO(Vector3 MILMNOPOIGD, Quaternion DDKKAJIGLLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7AB6250", Offset = "0x7AB5450", VA = "0x187AB6250")]
		public void SetHatAnchorParameters(BCHLBCJFNPL OFNELKDCBFN, AnchorParamsRestrictions ADPOGOLHNHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x7AADAC0", Offset = "0x7AACCC0", VA = "0x187AADAC0")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere PBACKOPNEGH, Transform OALAENNALCI, BCHLBCJFNPL OFNELKDCBFN, AnchorParamsRestrictions IPBKGGDOFFE, [Out] Vector3 JCHDHELBFIA, [Out] Quaternion FODPIPCFDKK, [Out] BCHLBCJFNPL HMHJBDCOPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x7AB4B00", Offset = "0x7AB3D00", VA = "0x187AB4B00")]
		public void ResetHatAnchor(Vector2 NFFJPFMHPFB, Vector3 IPHPPCCFNIA, Vector3 JCCDMMGBJOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA7F4C0", Offset = "0xA7E6C0", VA = "0x180A7F4C0")]
		public NDCHJCJEAND GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC530", Offset = "0x7AAB730", VA = "0x187AAC530")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC670", Offset = "0x7AAB870", VA = "0x187AAC670")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC4A0", Offset = "0x7AAB6A0", VA = "0x187AAC4A0")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x7AB76F0", Offset = "0x7AB68F0", VA = "0x187AB76F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7AAE9B0", Offset = "0x7AADBB0", VA = "0x187AAE9B0")]
		protected void EDDJPKFKGHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7AB7420", Offset = "0x7AB6620", VA = "0x187AB7420")]
		public void SetWaitForUgcTextureLoads(bool EHEHMOJDJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7AB72A0", Offset = "0x7AB64A0", VA = "0x187AB72A0")]
		public void SetUgcTextureParameters(BOPLBKOIMNN AJLJPILGNIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7AB8510", Offset = "0x7AB7710", VA = "0x187AB8510")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7AAEE70", Offset = "0x7AAE070", VA = "0x187AAEE70")]
		[CompilerGenerated]
		private void EKGJLCCBDBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3070", Offset = "0x7AB2270", VA = "0x187AB3070")]
		[CompilerGenerated]
		private void OKPBIBIHGJO(CCBJLAOFPGH DOBJPBPKAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7AAD1D0", Offset = "0x7AAC3D0", VA = "0x187AAD1D0")]
		[CompilerGenerated]
		private void BPFENKFKNLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7AACF00", Offset = "0x7AAC100", VA = "0x187AACF00")]
		[CompilerGenerated]
		private void BFBHGGAPOGO(CCBJLAOFPGH DOBJPBPKAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7AAF1C0", Offset = "0x7AAE3C0", VA = "0x187AAF1C0")]
		[CompilerGenerated]
		private void FKMOCCAFHNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1CE0", Offset = "0x7AB0EE0", VA = "0x187AB1CE0")]
		[CompilerGenerated]
		private void NADGBFAPGHH(CCBJLAOFPGH DOBJPBPKAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7AACFF0", Offset = "0x7AAC1F0", VA = "0x187AACFF0")]
		[CompilerGenerated]
		private void BMBBCCIJLNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7AAF170", Offset = "0x7AAE370", VA = "0x187AAF170")]
		[CompilerGenerated]
		private void FFMNPAJBMMF(CCBJLAOFPGH DOBJPBPKAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3F30", Offset = "0x7AB3130", VA = "0x187AB3F30")]
		[CompilerGenerated]
		private void PIOABBJCKEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3EE0", Offset = "0x7AB30E0", VA = "0x187AB3EE0")]
		[CompilerGenerated]
		private void PGNAAJEPMPJ(CCBJLAOFPGH DOBJPBPKAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7AAEA70", Offset = "0x7AADC70", VA = "0x187AAEA70")]
		[CompilerGenerated]
		private void EDGBBGJAJMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7AB0FF0", Offset = "0x7AB01F0", VA = "0x187AB0FF0")]
		[CompilerGenerated]
		private void JNBLOOBLEIG(CCBJLAOFPGH DOBJPBPKAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7AB0C80", Offset = "0x7AAFE80", VA = "0x187AB0C80")]
		[CompilerGenerated]
		internal static bool JDGGMBMJGCG(Transform NONLJOCJPGN, IEnumerable<SkinnedMeshRenderer> MDILMOPBMAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7AAE4F0", Offset = "0x7AAD6F0", VA = "0x187AAE4F0")]
		[CompilerGenerated]
		private void DLJMCPGOAOP(CCBJLAOFPGH DOBJPBPKAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7AAEB00", Offset = "0x7AADD00", VA = "0x187AAEB00")]
		[CompilerGenerated]
		private void EGDLADPGGOG(CCBJLAOFPGH DOBJPBPKAEF)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, DJNFGEJICJL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private struct BHAKAAMELAI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public MLFDDOBOAFD avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x7ABB060", Offset = "0x7ABA260", VA = "0x187ABB060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x7ABB2F0", Offset = "0x7ABA4F0", VA = "0x187ABB2F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct NPEOGIGLAPB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000471")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000472")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000473")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000474")]
			public HIEAKOJGBND avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x7AC24F0", Offset = "0x7AC16F0", VA = "0x187AC24F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x7AC26D0", Offset = "0x7AC18D0", VA = "0x187AC26D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct MHENEOFNMIO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400047B")]
			public HIEAKOJGBND avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400047C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x7AC1C90", Offset = "0x7AC0E90", VA = "0x187AC1C90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x7AC1E30", Offset = "0x7AC1030", VA = "0x187AC1E30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct JCBNHLLMKOM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400047D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400047E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400047F")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000480")]
			public MLFDDOBOAFD avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000481")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x7AC0320", Offset = "0x7ABF520", VA = "0x187AC0320", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x7AC04D0", Offset = "0x7ABF6D0", VA = "0x187AC04D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct HPBBDBDMFAF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000482")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000483")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000484")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000485")]
			public HIEAKOJGBND avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			private TaskAwaiter<PLGLJKMOHFC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x7ABE8D0", Offset = "0x7ABDAD0", VA = "0x187ABE8D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x7ABED10", Offset = "0x7ABDF10", VA = "0x187ABED10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct ABJPLAOMCBN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			public bool forceRebuild;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			public HIEAKOJGBND avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x7ABAA10", Offset = "0x7AB9C10", VA = "0x187ABAA10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x7ABAE30", Offset = "0x7ABA030", VA = "0x187ABAE30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		protected const float PMEFOMOBIID = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		protected const int OLLELMLHNGM = 5;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private static readonly int NCHBMPJFAPO;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private static readonly int CAFCFMEFOII;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private static readonly int OHFNFBIKFOE;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		protected static readonly Dictionary<CIEJDEEJIBC.FPGPOOPLGGN, int> GCOJJCIGDLD;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> KDNNODMNGDO;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		protected static readonly int KKEPHCDHELJ;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		protected static readonly int GBBNLADIHHI;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected static readonly int CAFCOAPAGNI;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected static readonly int EDGPANBBEIC;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected static readonly int DBMPANDDGDL;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		protected static Vector2 NKGEBJJNPII;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected static Vector2 LAMMBKBAJHP;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		protected static Vector2 GEPJMEIOBPK;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		protected static Vector2 JHLMPPKNHLM;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		protected static Vector2 JNAEGNDDPDF;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		protected static Vector2 HGMNMHMMAGP;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		protected static Vector2 BPJMNGCADOP;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		protected static Vector2 KJIKLNMCGMC;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		protected static Vector2 JEIBIECEHPD;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		protected static Vector2 OCGNCHKCCJB;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		protected static Vector2 HBHFLIHKCNJ;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		protected static Vector2 MBLBGCBHCJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		[GBCGIPBAICF(CFJMFGLCHFI.Self, false, false, false)]
		[SerializeField]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		[Header("Rendering")]
		[SerializeField]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		[SerializeField]
		[Header("Emotes")]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		[SerializeField]
		[Header("Modern Avatar Facial Features")]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private HIEAKOJGBND DOANKOPDGHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private FaceStyleSet COIJPJIDHNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected const int NJAIEPIFPIG = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected int MICOHOGLKKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected int CJJECDANGOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected int IFJOGDEDONF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected int GGOBGPKJHAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected Vector2 JMEGDOHOKDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected float IIHOJACNBHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected float LNHOFGLMENA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected float LODEHCPCPMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		protected Vector2 NLOCHKDLKPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		protected float NAHOLOPGGJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		protected float IECHHOHBCLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected float HIDNHJLNHAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected Vector2 MPNIHFLLNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		protected float LOMHMPAFNBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		protected float LACADGOIOHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected float HOLOMIBGLMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected Vector2 FNOMFNIHKIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		protected float CBDAEFBDNHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		protected float HAKJJJONFLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		protected float KIKFDDHLDNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		protected List<SelectableFaceOption> MJEOMEAMDOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		protected List<SelectableFaceOption> PAHGODBAGCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		protected List<SelectableFaceOption> COALGOAOGHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		protected List<SelectableFaceOption> GAMLNOKIOIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected Coroutine HDEJILCNIFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		protected int? JOGHIOJIDNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		protected int PJIPONPGMMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		protected int DOOKGGGBHMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		protected int LFPNLDKKPJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		protected int PBJHJOFHDOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		protected Sprite FPLGMKDMOJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		protected Sprite IPKHEOJLAEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		protected Sprite AGCAPGLILIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		protected Sprite PBIEKDGKHEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		protected bool AAAIHEALKIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		protected string ECCJCNGOMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		protected string NBOEOODLMBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		protected string CBKGPGELKCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		protected string DKNNEPDLHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		protected AvatarConfiguration BJGFMCPJJIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		protected PLGLJKMOHFC CAHLCDFLAFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private readonly List<Material> CKMIOJBGHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		protected KCINHAKCDKJ FJCEBPFAIHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		protected Dictionary<string, int> PFMDMIGLJAI;

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public FaceStyleSet JGJCMACJDGE
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x7AC9360", Offset = "0x7AC8560", VA = "0x187AC9360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public bool GNLOCEOGNGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x23FABA0", Offset = "0x23F9DA0", VA = "0x1823FABA0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x24D5610", Offset = "0x24D4810", VA = "0x1824D5610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		protected virtual bool LMHBPOFLEEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		protected virtual bool MJHNIDEBLGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		protected int PIADMJAPNFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x7AC3620", Offset = "0x7AC2820", VA = "0x187AC3620")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public Renderer FJAFKFEJJIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0xA00F90", Offset = "0xA00190", VA = "0x180A00F90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public bool IDDMHOHLBAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x219ED30", Offset = "0x219DF30", VA = "0x18219ED30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x24D6790", Offset = "0x24D5990", VA = "0x1824D6790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Renderer[] FPLFFMJAIPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xA00F50", Offset = "0xA00150", VA = "0x180A00F50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public bool ENGGAPOMHGG
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x7AC93B0", Offset = "0x7AC85B0", VA = "0x187AC93B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x7AC9570", Offset = "0x7AC8770", VA = "0x187AC9570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		protected int FDJOLDGFMAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x7AC32C0", Offset = "0x7AC24C0", VA = "0x187AC32C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		protected int EDIAMOCMHNC
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x7AC3260", Offset = "0x7AC2460", VA = "0x187AC3260")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public float DMLOHOKJHAG
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x7AC9390", Offset = "0x7AC8590", VA = "0x187AC9390")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x7AC9550", Offset = "0x7AC8750", VA = "0x187AC9550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public FHHGLMCDKMP OCLDIJKBLLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0xB210E0", Offset = "0xB202E0", VA = "0x180B210E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0xB51900", Offset = "0xB50B00", VA = "0x180B51900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public PLGLJKMOHFC NPKKHCLGIMD
		{
			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0xB20950", Offset = "0xB1FB50", VA = "0x180B20950")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x7AC94D0", Offset = "0x7AC86D0", VA = "0x187AC94D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public NoseFaceOption OEEFHEINBOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0xA89CC0", Offset = "0xA88EC0", VA = "0x180A89CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0xB0D340", Offset = "0xB0C540", VA = "0x180B0D340")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		protected KCINHAKCDKJ NECGLJHNAMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x7AC4F40", Offset = "0x7AC4140", VA = "0x187AC4F40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action ANLFBJPJDOC
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x7AC92B0", Offset = "0x7AC84B0", VA = "0x187AC92B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x7AC9420", Offset = "0x7AC8620", VA = "0x187AC9420")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x7AC5FD0", Offset = "0x7AC51D0", VA = "0x187AC5FD0")]
		public void LocalPlayEmote(CIEJDEEJIBC.FPGPOOPLGGN POLOEIGGIEP, float APBNBNKECFE = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x7AC54D0", Offset = "0x7AC46D0", VA = "0x187AC54D0")]
		public bool IsEmotePlaying(CIEJDEEJIBC.FPGPOOPLGGN POLOEIGGIEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x7AC72D0", Offset = "0x7AC64D0", VA = "0x187AC72D0")]
		public void SetIdleHappy(bool AEMBGOGONHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x7AC55F0", Offset = "0x7AC47F0", VA = "0x187AC55F0")]
		protected void JJHOFLEEFJM(bool KHAGBHEEPIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7AC2FC0", Offset = "0x7AC21C0", VA = "0x187AC2FC0")]
		protected void AELLMFCBMMD(bool EADNEGINMKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x7AC63F0", Offset = "0x7AC55F0", VA = "0x187AC63F0")]
		protected void OJPCOCIFHMD(IMAHPAJHFNK IJFIDCOKOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3420", Offset = "0x7AC2620", VA = "0x187AC3420")]
		protected void CDKGCKMDHMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x7AC69A0", Offset = "0x7AC5BA0", VA = "0x187AC69A0")]
		public void PlayExpression(int DNHBKPBFMKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x7AC5E40", Offset = "0x7AC5040", VA = "0x187AC5E40")]
		protected void LNDMHOALEOE(bool GJHDNMFAMCB, bool KIOMBAOMALC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4F00", Offset = "0x7AC4100", VA = "0x187AC4F00")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType JHBLIJPACNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4FC0", Offset = "0x7AC41C0", VA = "0x187AC4FC0")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration BJGFMCPJJIG, HIEAKOJGBND LNEJDOLFDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x7AC70A0", Offset = "0x7AC62A0", VA = "0x187AC70A0")]
		[AsyncStateMachine(typeof(BHAKAAMELAI))]
		public Task SetFaceSettings(MLFDDOBOAFD NMNBELDFILE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6F70", Offset = "0x7AC6170", VA = "0x187AC6F70")]
		[AsyncStateMachine(typeof(NPEOGIGLAPB))]
		public Task SetFaceSettings(int FIHJKOFGGNC, int ABKGPMFMAKA, int MHFGCLNIIKG, int JIHCFDHDEML, HIEAKOJGBND LNEJDOLFDHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7AC7350", Offset = "0x7AC6550", VA = "0x187AC7350")]
		[AsyncStateMachine(typeof(MHENEOFNMIO))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType JHBLIJPACNF, int INPFENHAHNO, HIEAKOJGBND LNEJDOLFDHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x7AC5CC0", Offset = "0x7AC4EC0", VA = "0x187AC5CC0")]
		protected void LLMFAOGGOJK(FaceFeatureType JHBLIJPACNF, JCDBDFLIABB EKMELOOFAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4150", Offset = "0x7AC3350", VA = "0x187AC4150")]
		protected void GAAPPNCMPBF(FaceFeatureType JHBLIJPACNF, int INPFENHAHNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4D30", Offset = "0x7AC3F30", VA = "0x187AC4D30")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x7AC48B0", Offset = "0x7AC3AB0", VA = "0x187AC48B0")]
		[AsyncStateMachine(typeof(JCBNHLLMKOM))]
		protected Task GHNBGDGELAI(MLFDDOBOAFD NMNBELDFILE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x7AC5760", Offset = "0x7AC4960", VA = "0x187AC5760")]
		protected void KBLGBNOHJHH(MLFDDOBOAFD NMNBELDFILE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3490", Offset = "0x7AC2690", VA = "0x187AC3490")]
		protected static void CFFCPCMMCKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6740", Offset = "0x7AC5940", VA = "0x187AC6740")]
		private void PJGNLDFLJLK(bool IAKAPCKIADB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7AC49A0", Offset = "0x7AC3BA0", VA = "0x187AC49A0")]
		protected void GLDDNDPOGCC(FaceFeatureType JHBLIJPACNF, Vector2 AIIIMPELBKA, HIEAKOJGBND LNEJDOLFDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7AC69C0", Offset = "0x7AC5BC0", VA = "0x187AC69C0")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType JHBLIJPACNF, Vector2 CDDGPCPPKGI, HIEAKOJGBND LNEJDOLFDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7AC60D0", Offset = "0x7AC52D0", VA = "0x187AC60D0")]
		protected void MKBDGNOLCAM(FaceFeatureType JHBLIJPACNF, float ILMGNKKCLHA, HIEAKOJGBND LNEJDOLFDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x7AC5B40", Offset = "0x7AC4D40", VA = "0x187AC5B40")]
		protected void LIGJCDFIBPP(FaceFeatureType JHBLIJPACNF, float NDOBKEDDJAJ, HIEAKOJGBND LNEJDOLFDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6670", Offset = "0x7AC5870", VA = "0x187AC6670")]
		protected void PCDCBGDOGDL(FaceFeatureType JHBLIJPACNF, float IOJIHHMHOEO, HIEAKOJGBND LNEJDOLFDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6D50", Offset = "0x7AC5F50", VA = "0x187AC6D50")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType JHBLIJPACNF, float EELOJHEFGNG, HIEAKOJGBND LNEJDOLFDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7AC5EF0", Offset = "0x7AC50F0", VA = "0x187AC5EF0")]
		[AsyncStateMachine(typeof(HPBBDBDMFAF))]
		protected Task LPPDONNCLFP(HIEAKOJGBND LNEJDOLFDHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x7AC52C0", Offset = "0x7AC44C0", VA = "0x187AC52C0")]
		public void InitializeFaceFeatureStyleSet(HIEAKOJGBND LNEJDOLFDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x7AC5A60", Offset = "0x7AC4C60", VA = "0x187AC5A60")]
		protected bool KMOEPODPPON(string MDGFIIOEFFO, [Out] int CMDFFDAPDIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3120", Offset = "0x7AC2320", VA = "0x187AC3120")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7AC7460", Offset = "0x7AC6660", VA = "0x187AC7460", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6460", Offset = "0x7AC5660", VA = "0x187AC6460")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x7AC8450", Offset = "0x7AC7650", VA = "0x187AC8450")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3320", Offset = "0x7AC2520", VA = "0x187AC3320")]
		[AsyncStateMachine(typeof(ABJPLAOMCBN))]
		public Task BuildFaceStyleAsyncIfChanged(HIEAKOJGBND LNEJDOLFDHE, bool DCFIEIBGBID = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7AC7D60", Offset = "0x7AC6F60", VA = "0x187AC7D60")]
		public void UpdateFaceDisplays(bool LAIINEILOBA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3A00", Offset = "0x7AC2C00", VA = "0x187AC3A00")]
		protected bool EMPCHECPHBK(bool LAIINEILOBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x7AC7AC0", Offset = "0x7AC6CC0", VA = "0x187AC7AC0")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7AC7190", Offset = "0x7AC6390", VA = "0x187AC7190")]
		public void SetFaceSpriteIndices(string MIAKDFPOOBO, string FNJFDANLMOP, string EGGIAEHCHIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7AC7470", Offset = "0x7AC6670", VA = "0x187AC7470")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7AC7F80", Offset = "0x7AC7180", VA = "0x187AC7F80")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7AC8170", Offset = "0x7AC7370", VA = "0x187AC8170")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x7AC5670", Offset = "0x7AC4870", VA = "0x187AC5670")]
		protected void JOCBNAIGDLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3750", Offset = "0x7AC2950", VA = "0x187AC3750")]
		private void EDPNIPIAPGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6250", Offset = "0x7AC5450", VA = "0x187AC6250")]
		private void MODKPMAENKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x7AC9060", Offset = "0x7AC8260", VA = "0x187AC9060")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xA2DEE0", Offset = "0xA2D0E0", VA = "0x180A2DEE0", Slot = "4")]
		private bool DEFMALGKJBC()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct EMJKBFDOJGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public string KGCJIDMKOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public int HHPKMABLCHL;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[ExecuteInEditMode]
	[SelectionBase]
	public class PlayerModernBodyEditorAvatarValidator : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private struct FECBIBFKNMH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x7ABE020", Offset = "0x7ABD220", VA = "0x187ABE020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0xA508E0", Offset = "0xA4FAE0", VA = "0x180A508E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private struct LNBBDDJJCED : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x7AC1730", Offset = "0x7AC0930", VA = "0x187AC1730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x7AC1C30", Offset = "0x7AC0E30", VA = "0x187AC1C30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public HIEAKOJGBND avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public DDKMPEMLOPH useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public BCHLBCJFNPL hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public NDCHJCJEAND HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public long baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		[GBCGIPBAICF(CFJMFGLCHFI.Self, false, false, false)]
		[SerializeField]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private MLAFNJOHGFA ADHBECFEJNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		[SerializeField]
		[GBCGIPBAICF(CFJMFGLCHFI.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private AnimatorOverrideController GEBCHNENNHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> ABHNMONPAHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public readonly EMJKBFDOJGC[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public readonly (string, CIGCOHPAJFE)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		protected bool APNNLDCNEPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		protected Guid BNABDHONENP;

		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		protected static Guid ENLAPAFMDBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private KONLHIGFPIP OFAOPNAMGAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private FHHGLMCDKMP MJEDBCOHFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private JGDIKKCCKEJ NOOECKKAIKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private JGDIKKCCKEJ MCHKFGJOIAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private AdditionalHatData POFEEJILGEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private readonly Dictionary<GameObject, ENJNFKLCFEL> EDKMLBJOJBI;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public static Func<CDJOBBECAIH> DFGILGPPDAH
		{
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x7ACE5D0", Offset = "0x7ACD7D0", VA = "0x187ACE5D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x7ACEC10", Offset = "0x7ACDE10", VA = "0x187ACEC10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool JMFAEKNADAF
		{
			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x7ACE730", Offset = "0x7ACD930", VA = "0x187ACE730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public bool NCALFCNKABI
		{
			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x7ACE620", Offset = "0x7ACD820", VA = "0x187ACE620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public PlayerAvatarDisplayBase LHMJJAACHGE
		{
			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0xB067F0", Offset = "0xB059F0", VA = "0x180B067F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		protected static Guid IBBMOAMJGAG
		{
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x7ACB0D0", Offset = "0x7ACA2D0", VA = "0x187ACB0D0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public (GameObject, IMAHPAJHFNK)[] MOMCCOFEGPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x7ACE840", Offset = "0x7ACDA40", VA = "0x187ACE840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x7ACC350", Offset = "0x7ACB550", VA = "0x187ACC350")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7AC9CA0", Offset = "0x7AC8EA0", VA = "0x187AC9CA0")]
		private IEnumerable<GameObject> ALJOJEKFOBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7ACC820", Offset = "0x7ACBA20", VA = "0x187ACC820")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x7ACAD80", Offset = "0x7AC9F80", VA = "0x187ACAD80")]
		private void CLKLNADAOOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x1370A00", Offset = "0x136FC00", VA = "0x181370A00")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7ACB510", Offset = "0x7ACA710", VA = "0x187ACB510")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7ACC830", Offset = "0x7ACBA30", VA = "0x187ACC830")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x7ACC640", Offset = "0x7ACB840", VA = "0x187ACC640")]
		public void ShowPose(AnimationClip KAJHPHBOHBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x7ACC7F0", Offset = "0x7ACB9F0", VA = "0x187ACC7F0")]
		public void ShowPose(string HGHPKLFLCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7ACC4A0", Offset = "0x7ACB6A0", VA = "0x187ACC4A0")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7ACC360", Offset = "0x7ACB560", VA = "0x187ACC360")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD300", Offset = "0x7ACC500", VA = "0x187ACD300")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD150", Offset = "0x7ACC350", VA = "0x187ACD150")]
		public void UpdateFaceAndBodyShapes(bool DCFIEIBGBID = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD700", Offset = "0x7ACC900", VA = "0x187ACD700")]
		public void UpdateNoseShape(BDJFFDNIHPO CHPDFJOFFPE, bool DCFIEIBGBID = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD6D0", Offset = "0x7ACC8D0", VA = "0x187ACD6D0")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7ACBCE0", Offset = "0x7ACAEE0", VA = "0x187ACBCE0", Slot = "4")]
		protected virtual void LMELMFNFGJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x7ACAE60", Offset = "0x7ACA060", VA = "0x187ACAE60", Slot = "5")]
		protected virtual void ENEBGAHLKEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7ACA2F0", Offset = "0x7AC94F0", VA = "0x187ACA2F0")]
		public void ApplyHatData(AdditionalHatData KNMELAOANIL, bool LKPOFKECGDD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7ACA130", Offset = "0x7AC9330", VA = "0x187ACA130")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x7ACA650", Offset = "0x7AC9850", VA = "0x187ACA650")]
		public void ApplyHatUVOverride(Vector2 LAEOKNDCKCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x7ACA570", Offset = "0x7AC9770", VA = "0x187ACA570")]
		public void ApplyHatPositionAdjustment(Vector3 OBKLBMHOADE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7ACA5E0", Offset = "0x7AC97E0", VA = "0x187ACA5E0")]
		public void ApplyHatRotationAdjustment(Vector3 BBLCFIPGABN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7ACA6C0", Offset = "0x7AC98C0", VA = "0x187ACA6C0")]
		public OALMANNFHKO BuildAvatarItemSelection(GameObject BGPAAGKJDNA, HIEAKOJGBND LHNAOOFCGOL, IMAHPAJHFNK HHAIGBDCFAE)
		{
			return default(OALMANNFHKO);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x7ACA760", Offset = "0x7AC9960", VA = "0x187ACA760")]
		public void BuildAvatar(bool DCFIEIBGBID = false, bool LKPOFKECGDD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x7ACCB90", Offset = "0x7ACBD90", VA = "0x187ACCB90")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x7ACA270", Offset = "0x7AC9470", VA = "0x187ACA270")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD520", Offset = "0x7ACC720", VA = "0x187ACD520")]
		public void UpdateHatAnchor(bool LKPOFKECGDD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD250", Offset = "0x7ACC450", VA = "0x187ACD250")]
		[AsyncStateMachine(typeof(FECBIBFKNMH))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x7ACBC10", Offset = "0x7ACAE10", VA = "0x187ACBC10")]
		[AsyncStateMachine(typeof(LNBBDDJJCED))]
		private Task JLJNFFGFDFP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x7ACB1C0", Offset = "0x7ACA3C0", VA = "0x187ACB1C0")]
		private void ICGABAAELME(FaceFeatureType OLOLHIJOODJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x7ACB480", Offset = "0x7ACA680", VA = "0x187ACB480")]
		private void IIINIALCPOB(FaceFeatureType OLOLHIJOODJ, [Out] float DAAOLJMFOLJ, [Out] float JBMAMKIHCIE, [Out] float GPOEDAABNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD010", Offset = "0x7ACC210", VA = "0x187ACD010")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD3B0", Offset = "0x7ACC5B0", VA = "0x187ACD3B0")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7AC96C0", Offset = "0x7AC88C0", VA = "0x187AC96C0")]
		private void AGFAFPBDOCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		private void OICLCPGONIK(ENJNFKLCFEL DLBGMBBCKAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		private void AAOJIPIOHJH(ENJNFKLCFEL DLBGMBBCKAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x7ACBFF0", Offset = "0x7ACB1F0", VA = "0x187ACBFF0")]
		private void PAEMEFEHPBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD780", Offset = "0x7ACC980", VA = "0x187ACD780")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7AC9BF0", Offset = "0x7AC8DF0", VA = "0x187AC9BF0")]
		[CompilerGenerated]
		private OALMANNFHKO AGGOMAHLLDJ((GameObject, IMAHPAJHFNK) JINNGLPMNOD)
		{
			return default(OALMANNFHKO);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		[GBCGIPBAICF(CFJMFGLCHFI.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct OALMANNFHKO
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class ABOPOGFMGFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public ABOPOGFMGFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x7ABAE90", Offset = "0x7ABA090", VA = "0x187ABAE90")]
		internal bool PDKEJGIFGFA(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private ENJNFKLCFEL IOCIEIJPCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private IMAHPAJHFNK PJEHGGNBPDF;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public ENJNFKLCFEL IDMKPNPAPCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public IMAHPAJHFNK CGDJICCKAML
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xD919C0", Offset = "0xD90BC0", VA = "0x180D919C0")]
		get
		{
			return default(IMAHPAJHFNK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public string KEFHBBEHCNF
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x7AC2730", Offset = "0x7AC1930", VA = "0x187AC2730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool BINLMGFOOPP
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x7AC2A80", Offset = "0x7AC1C80", VA = "0x187AC2A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool OGPKNGMFAGM
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x7AC2B90", Offset = "0x7AC1D90", VA = "0x187AC2B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x18CDBA0", Offset = "0x18CCDA0", VA = "0x1818CDBA0")]
	public OALMANNFHKO(ENJNFKLCFEL DLBGMBBCKAG, IMAHPAJHFNK IJFIDCOKOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x7AC2AD0", Offset = "0x7AC1CD0", VA = "0x187AC2AD0")]
	public bool LBNANAFDGIH(OutfitType FJDDBBMMMKG, IMAHPAJHFNK CCPIKAIGOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x7AC2820", Offset = "0x7AC1A20", VA = "0x187AC2820")]
	public bool EMLOPJLCHPM(OutfitType FJDDBBMMMKG, IMAHPAJHFNK CCPIKAIGOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x7AC2BE0", Offset = "0x7AC1DE0", VA = "0x187AC2BE0")]
	public bool PKIHEGGNAIC(OALMANNFHKO GCIJABNPHLI)
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
