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
	public class LogRegistrationIndex : CCAGPMFGEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x774B070", Offset = "0x7749A70", VA = "0x18774B070", Slot = "4")]
		public override void BLLBFFICICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
			[Cpp2IlInjected.Address(RVA = "0x9B22C0", Offset = "0x9B0CC0", VA = "0x1809B22C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x774FF80", Offset = "0x774E980", VA = "0x18774FF80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x774FF10", Offset = "0x774E910", VA = "0x18774FF10", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x774FF40", Offset = "0x774E940", VA = "0x18774FF40")]
		public RecNetCDNAssetReference(RecNetCDNKey NJBPFCDJFGD)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum HNJHGICFOEK : byte
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
			[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9AEDA0", Offset = "0x9AD7A0", VA = "0x1809AEDA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFB0", Offset = "0x9AD9B0", VA = "0x1809AEFB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9B0460", Offset = "0x9AEE60", VA = "0x1809B0460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9AED50", Offset = "0x9AD750", VA = "0x1809AED50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9B6FD0", Offset = "0x9B59D0", VA = "0x1809B6FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9DAF20", Offset = "0x9D9920", VA = "0x1809DAF20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9DAD40", Offset = "0x9D9740", VA = "0x1809DAD40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public HNJHGICFOEK PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD31520", Offset = "0xD2FF20", VA = "0x180D31520")]
			[CompilerGenerated]
			get
			{
				return default(HNJHGICFOEK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x1237AF0", Offset = "0x12364F0", VA = "0x181237AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7750090", Offset = "0x774EA90", VA = "0x187750090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7750010", Offset = "0x774EA10", VA = "0x187750010")]
		public static RecNetCDNKey OOHJBFAJDPB(string HONALGIFLKK, HNJHGICFOEK GCOHLPNCFGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x774FFC0", Offset = "0x774E9C0", VA = "0x18774FFC0")]
		public void IJOEFFEPAKP(string MELOIPAHDCM, string ALFFJDGFOGF, bool PDFJDAEFNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[OHBOADDCADD]
public class DFDNHDDPFFG : HBGJPACIFOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<Mesh> KOMOGGDNGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<byte[]> KMKAJMFBEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<Matrix4x4> LCIKDFLAADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly List<bool> BKBBJFIOBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly List<long> IKOGLDLHEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly List<bool> AOHEEPFDPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected readonly List<int> OHOBOGEPBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected Allocator KHKACMAKILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected LMGHJFPJPAJ OOLOLIDIPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected byte LDLIPACNIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected IList<int> CAHGIDOGAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected IList<int> LLHKAJDKMOK;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x774A9B0", Offset = "0x77493B0", VA = "0x18774A9B0", Slot = "4")]
	public void LOJKLLMGNLN(Mesh LKDNKMEFADL, Matrix4x4 JEMEHHMGNBE, byte[] HALIJNAGNHI, bool JNIDCDELJLG = false, FHMIHNFONJP.FMPAHPDMJAC AADHBKKKMKJ = (FHMIHNFONJP.FMPAHPDMJAC)0L, int FMCKNBDDNFN = -1, bool AHODBJHIBDD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x774A970", Offset = "0x7749370", VA = "0x18774A970", Slot = "5")]
	public void IJPNLAFJGGJ(Allocator DDBBFOCJEFL, LMGHJFPJPAJ JCKNAPLAPNN, byte AAAHABGAGMO, [Optional] IList<int> LFPENPEBMLH, [Optional] IList<int> NECNHAGMOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x774A710", Offset = "0x7749110", VA = "0x18774A710")]
	private static void DLECFGCDMMD(Mesh LKDNKMEFADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x774AC30", Offset = "0x7749630", VA = "0x18774AC30")]
	public DFDNHDDPFFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[OHBOADDCADD]
public struct COPMHHKDCLN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public PLMHPFKDBNB PKCGJAJFPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public int OGLEALGIJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public OJEFOLKFAMC GLAFBECLAKK;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x773BDA0", Offset = "0x773A7A0", VA = "0x18773BDA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NativeContainer]
[OHBOADDCADD]
public struct OJEFOLKFAMC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct HFDOHOKKKLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector3 IGPBADICPIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector3 MDIKGGEOGCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector4 FGINBKCNIHH;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct OBGLOCCAAOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float CIIBOAIMLCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float ECAJFIGBPCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float GBMGCKHIBPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float MGAGFLEGENE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte GEGGALDIJOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public byte NJOOJAMHGJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public byte IMIDINMHGPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte OPPCPICBKBD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct BPCAJJJHMMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half CIIBOAIMLCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half ECAJFIGBPCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half GBMGCKHIBPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half MGAGFLEGENE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public byte GEGGALDIJOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte NJOOJAMHGJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public byte IMIDINMHGPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public byte OPPCPICBKBD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct BFPAIFLLLEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 IFFOAMBAJEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 EOAIKIAKNNI;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct PHGFIMNFCHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half4 IFFOAMBAJEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 EOAIKIAKNNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 OAGALDIBIOD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct CIIFIKDFMKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half4 IFFOAMBAJEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 EOAIKIAKNNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 OAGALDIBIOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 AOLKGHCKBKL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct DOOLODKJPGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half4 IFFOAMBAJEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public half2 EOAIKIAKNNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public half2 OAGALDIBIOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public half2 AOLKGHCKBKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public half2 CMIKEBGJDPI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct JBDNHNFCJFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float CIIBOAIMLCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float ECAJFIGBPCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float GBMGCKHIBPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float MGAGFLEGENE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int GEGGALDIJOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int NJOOJAMHGJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int IMIDINMHGPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int OPPCPICBKBD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct BMOHPJNCIBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color IFFOAMBAJEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 EOAIKIAKNNI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct DIHCJABDECF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Color IFFOAMBAJEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 EOAIKIAKNNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Vector2 OAGALDIBIOD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct KDAKNHOJLPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Color IFFOAMBAJEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 EOAIKIAKNNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 OAGALDIBIOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 AOLKGHCKBKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct ADIFNMOLGFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Color IFFOAMBAJEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector2 EOAIKIAKNNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Vector2 OAGALDIBIOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Vector2 AOLKGHCKBKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Vector2 CMIKEBGJDPI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool KBKDHIACFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<HFDOHOKKKLH> KMKMIKHNIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<BFPAIFLLLEB> CIOFBJFEHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<PHGFIMNFCHF> DHLHCHPNEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<CIIFIKDFMKH> FIJHGDEJCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<DOOLODKJPGK> EDJDIBGMNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<BPCAJJJHMMH> OBMNKEFLMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<OBGLOCCAAOI> OKINICDABKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<BMOHPJNCIBO> NPIDOLECNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<DIHCJABDECF> KDKNCFCOIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<KDAKNHOJLPA> BACMDBIHJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<ADIFNMOLGFG> PNJMFONHJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<JBDNHNFCJFI> CKMMKDFMIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> GDANPJGACBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> OLGMKEMJBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> PNCCJPPAIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> GIPLNEOODJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> MGKGEMOENNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> PNPEDABCDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<int> NNCKLPFDDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<BoneWeight> DLNDNLOIKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> KHABEFHMCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool HLBDEIIOFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool ALAMEHOPMFM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int IPKNBOJALGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x774CAC0", Offset = "0x774B4C0", VA = "0x18774CAC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x774CAD0", Offset = "0x774B4D0", VA = "0x18774CAD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int LOKMDKMKLHO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x774CAE0", Offset = "0x774B4E0", VA = "0x18774CAE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x774CAF0", Offset = "0x774B4F0", VA = "0x18774CAF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int ACJIGNELFKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x774CB10", Offset = "0x774B510", VA = "0x18774CB10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x774CB00", Offset = "0x774B500", VA = "0x18774CB00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int FKCCCKHEENI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x774CB30", Offset = "0x774B530", VA = "0x18774CB30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x774D710", Offset = "0x774C110", VA = "0x18774D710")]
	public OJEFOLKFAMC(int EIHICPEDIAL, int BBIBEHNNOGH, int GGIBKGDIJPF, int OGKICHCIEKN, Allocator DDBBFOCJEFL, int HGOAOEEODCK, ONIDONDPOJA KMEKIBHKFEM, bool HLBDEIIOFEG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x774D680", Offset = "0x774C080", VA = "0x18774D680")]
	public void PIGOKANBOJB(int DOAKEFBOPIA, Vector3 LFDANFLODKB, Vector3 NFLJGFIFAHD, Vector4 PPOLMDFNGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x774B3C0", Offset = "0x7749DC0", VA = "0x18774B3C0")]
	public void AFCDJGOADPN(int DOAKEFBOPIA, BoneWeight IFJMNJIINLD, NativeSlice<byte> HALIJNAGNHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x774CBA0", Offset = "0x774B5A0", VA = "0x18774CBA0")]
	public Color MGIIPNCJIPO(int DOAKEFBOPIA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x774CED0", Offset = "0x774B8D0", VA = "0x18774CED0")]
	public void MIKNOMIAFGC(int DOAKEFBOPIA, Color LHJMDMLADDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x774D2D0", Offset = "0x774BCD0", VA = "0x18774D2D0")]
	public void NGAFBNMAAPG(byte NAJPDPHLODA, int DOAKEFBOPIA, Vector2 FCHAPFLKCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x774CB20", Offset = "0x774B520", VA = "0x18774CB20")]
	public void JBMHAJJJJNP(int DOAKEFBOPIA, int DLGFNDPIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x774C800", Offset = "0x774B200", VA = "0x18774C800")]
	public bool CHPKILPFAPE(int NAJPDPHLODA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x774C730", Offset = "0x774B130", VA = "0x18774C730")]
	public void CDAOKHPOFGM(int MLFGGCMOGCL, int LMGBAALNFHC, int ENHEICOLGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x774C860", Offset = "0x774B260", VA = "0x18774C860", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x774B7F0", Offset = "0x774A1F0", VA = "0x18774B7F0")]
	public Mesh AFHLMADFBBB([Optional] string ADKIMBOPCIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[OHBOADDCADD]
[NativeContainer]
public struct PLMHPFKDBNB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Mesh.MeshDataArray OALCEJIDEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeArray<int> FGDADPAKBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeArray<int> DMEOJEOFLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeArray<BoneWeight> DLNDNLOIKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeArray<Matrix4x4> ODOGADIAOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeArray<long> LLOFGFEPHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeArray<byte> CJMNLKEPEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<int> JBADDGHAFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<int> DLGELMHAAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<sbyte> HHNFBKNDNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeArray<byte> MFIDPIHHFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<bool> AHODBJHIBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<int> FMCKNBDDNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool HLBDEIIOFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<int> KOKKFMJAOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private bool ALAMEHOPMFM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int ABFAOKEAJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x774E820", Offset = "0x774D220", VA = "0x18774E820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int IEALDPHKAFO
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x774ED10", Offset = "0x774D710", VA = "0x18774ED10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int FEADEMIGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x774E720", Offset = "0x774D120", VA = "0x18774E720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int HCODBOKFLEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x774E9C0", Offset = "0x774D3C0", VA = "0x18774E9C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x774EC30", Offset = "0x774D630", VA = "0x18774EC30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int IPKNBOJALGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x774E9B0", Offset = "0x774D3B0", VA = "0x18774E9B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x774E9D0", Offset = "0x774D3D0", VA = "0x18774E9D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int LDIOJFCFKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x774E810", Offset = "0x774D210", VA = "0x18774E810")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x774ED30", Offset = "0x774D730", VA = "0x18774ED30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public LMGHJFPJPAJ KGIEGAJFGKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x774ED40", Offset = "0x774D740", VA = "0x18774ED40")]
		get
		{
			return default(LMGHJFPJPAJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x774E7F0", Offset = "0x774D1F0", VA = "0x18774E7F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte BEILELEFOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x774E800", Offset = "0x774D200", VA = "0x18774E800")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x774ED20", Offset = "0x774D720", VA = "0x18774ED20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public AIAKIKFCJCM NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x774E9E0", Offset = "0x774D3E0", VA = "0x18774E9E0")]
		get
		{
			return default(AIAKIKFCJCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x774ED50", Offset = "0x774D750", VA = "0x18774ED50")]
	public PLMHPFKDBNB(IList<Mesh> INENCIHLAGB, IList<Matrix4x4> AJAHAMLOLLA, IList<bool> AHODBJHIBDD, byte AAAHABGAGMO, IList<byte[]> KAALNOFKLEM, IList<long> JCCOJIFIIOB, IList<bool> PBMDJIJDBEN, IList<int> FMCKNBDDNFN, IList<int> LFPENPEBMLH, IList<int> HBHMGIKGFPL, Allocator DDBBFOCJEFL, LMGHJFPJPAJ JCKNAPLAPNN, bool HLBDEIIOFEG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x774EC40", Offset = "0x774D640", VA = "0x18774EC40")]
	public OJEFOLKFAMC IGJINPEDIBB(Allocator DDBBFOCJEFL, ONIDONDPOJA KMEKIBHKFEM)
	{
		return default(OJEFOLKFAMC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x774E830", Offset = "0x774D230", VA = "0x18774E830", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[OHBOADDCADD]
public class PJACFLANLAN : DFDNHDDPFFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public bool BDEOGFDAGND;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly ProfilerMarker GIJIIHDAEDH;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x774E410", Offset = "0x774CE10", VA = "0x18774E410")]
	public PLMHPFKDBNB CLAKNHFJMMK()
	{
		return default(PLMHPFKDBNB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x774E710", Offset = "0x774D110", VA = "0x18774E710")]
	public PJACFLANLAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct AIAKIKFCJCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Mesh.MeshData NCMEJGOPCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<BoneWeight> DLNDNLOIKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NativeSlice<byte> KGAFGBACCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int GIDNDAJPHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Matrix4x4 POBMCAIDDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public long EJLKAFFCONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeSlice<byte> HALIJNAGNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public bool FAOMIICMJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public int LBLHOJOKDEL;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class CPCDHCNGPGN : OLDJDAKOFEE
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class AAGMPMEDNKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public LMGGFBLOMFG avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public CPCDHCNGPGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public FDJPMDOFNPO buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Action<KeyValuePair<string, PHLGPCMBMIF<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public AAGMPMEDNKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x773A1C0", Offset = "0x7738BC0", VA = "0x18773A1C0")]
		internal bool MHDDFHOEDKF(ICGBLNBLOIJ item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x773A170", Offset = "0x7738B70", VA = "0x18773A170")]
		internal void JDCMABEDCPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7739FA0", Offset = "0x77389A0", VA = "0x187739FA0")]
		internal void ADHCMLDPCDD(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x773A170", Offset = "0x7738B70", VA = "0x18773A170")]
		internal void KICGLJJPEPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7739FA0", Offset = "0x77389A0", VA = "0x187739FA0")]
		internal void NEMAPCKCGHG(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x773A080", Offset = "0x7738A80", VA = "0x18773A080")]
		internal void DCINDILCFMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x773A190", Offset = "0x7738B90", VA = "0x18773A190")]
		internal void KFNMMEMLCCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x773A0B0", Offset = "0x7738AB0", VA = "0x18773A0B0")]
		internal void FKAHMFBAFEC(Dictionary<string, PHLGPCMBMIF<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7739FC0", Offset = "0x77389C0", VA = "0x187739FC0")]
		internal void BHLICFDCOME(KeyValuePair<string, PHLGPCMBMIF<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560")]
		internal JCIOFMEGJFK AMEFGAEMDDJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class LAENBGNLCFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public AAGMPMEDNKH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public LAENBGNLCFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x774AFB0", Offset = "0x77499B0", VA = "0x18774AFB0")]
		internal LHABFABOONF OLLAHJAHOGB(int lod)
		{
			return default(LHABFABOONF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class GDGCKEFGKFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public ECHAPNAJEJF<Dictionary<string, PHLGPCMBMIF<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public GDGCKEFGKFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		internal ECHAPNAJEJF<Dictionary<string, PHLGPCMBMIF<Texture2D>>> FJIEOGBHPEK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KBCDICBCHLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public List<FDJPMDOFNPO> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public KBCDICBCHLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x774AE80", Offset = "0x7749880", VA = "0x18774AE80")]
		internal void NGOCOHOGFLH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class PHMKMPHIEAH : IEnumerator<HKMFJDMPEMN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private HKMFJDMPEMN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public CPCDHCNGPGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public List<FONLGKLNJEI> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public List<FDJPMDOFNPO> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public Func<int, LHABFABOONF> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public BOKOODFHICH materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private HKMFJDMPEMN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
		[DebuggerHidden]
		public PHMKMPHIEAH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x774E140", Offset = "0x774CB40", VA = "0x18774E140", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x774E3C0", Offset = "0x774CDC0", VA = "0x18774E3C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class KLBJMBENCMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public NBKNOOMPOOB cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public KLBJMBENCMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA19930", Offset = "0xA18330", VA = "0x180A19930")]
		internal void LBLEIBKIFMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xC63BA0", Offset = "0xC625A0", VA = "0x180C63BA0")]
		internal void LEJGIGNOEEF(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class OMGJIPEKFBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public CPCDHCNGPGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public OMGJIPEKFBD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class CKAAJINNMHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public OJEFOLKFAMC defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public PLMHPFKDBNB defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public OMGJIPEKFBD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public CKAAJINNMHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x773BB60", Offset = "0x773A560", VA = "0x18773BB60")]
		internal void PDKIHIMLBDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x119ED30", Offset = "0x119D730", VA = "0x18119ED30")]
		internal void LCPIENDDBMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class NCNCIHCMKAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public PIONPNHKFIN legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public KLAHBOONFAK legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public OMGJIPEKFBD CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public NCNCIHCMKAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x774B100", Offset = "0x7749B00", VA = "0x18774B100")]
		internal void NBLADBPHHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x119F3B0", Offset = "0x119DDB0", VA = "0x18119F3B0")]
		internal void MNNJGAHHHEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class NMAIICGOGFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public NMDLGPPCNIO overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public NMAIICGOGFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x774B340", Offset = "0x7749D40", VA = "0x18774B340")]
		internal bool PBEFIGCDFAO(KeyValuePair<string, ICGBLNBLOIJ> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly COOFKGJALFM DBCBCCBEJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly COOFKGJALFM HNEIJOBJAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Dictionary<KBKDIFLNMMM, float> CAELJLOILME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<FOGOJOFLBFP, float> NNEMBHIOKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<NGIFDFOJOFE, float> HMGBOHGIIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private IReadOnlyDictionary<string, EIGKFPFNMGA> PFLMJBLEKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Dictionary<string, EIGKFPFNMGA> LDEACHJBBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Dictionary<string, EIGKFPFNMGA> NAOMDJDCNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Dictionary<string, EIGKFPFNMGA> IMAAAFKFHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private EKGANCFHNJH IODICDLPNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private EKGANCFHNJH MMLEGNKNMAE;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static float MKFODLCNNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool? KPICCDNLBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool? OONELFANPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool? PIGBDAHLLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool? EFCFMKIABGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private AvatarConfiguration POLFPBHJING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Transform ILJJLDCFBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private AvatarSkinAssetItem OOFELOIGOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private AssetReference BGOCNMOINAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private GameObject PEKNFFFNNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private GameObject GILGPBBKHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private SkinnedMeshRenderer OIBLPDKBOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private AvatarSkinnedMeshBoneOrderRemapsData AOFHHAEAGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Transform[] GAOJCHACMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Matrix4x4[] FILKCFDFFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Material GLIIEKMJKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Material ONHJJJHJAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Material DDMKAIDBOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Shader AFLFNMDIOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Shader CKEMHEEDDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Animator MGGBFMOLPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Renderer[] FHHCMJCPLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private FHMIHNFONJP.FMPAHPDMJAC AHCBPJIBLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private AvatarBodyPartShapesManager GDBEIPGDENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private IReadOnlyDictionary<string, Transform> LPBENHAJBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private AvatarFaceShapeData.IHEGCPCHNCA CMEJINALLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private AvatarBodyShapeData.LAJBOACPEHE GCIJECEHFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private FPNKNMOGAJG LMCGGNNGBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private bool HPEPLGJDMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x115")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool OILOLHFGDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private Color NGJEHIOENLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Color FOMLDPJIFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Color OEKCHCOLGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Color? PACLJOMFGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Color? IBIDPCJBBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Color? CPEKLBLBLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private Color? ADEKMAGIDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private Texture2D LLGMIHNAPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Texture2D LLJFDIBCLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[CanBeNull]
	private ICGBLNBLOIJ OHAJAIHNFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Texture FAEODPDJBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Color OJMPBDMBLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public Dictionary<Renderer, BOKOODFHICH> CANPECKKIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Dictionary<Renderer, BOKOODFHICH> PJCNMLIILPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Dictionary<string, List<JKEEFDFHBLC>> FAHCDBLKFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Dictionary<string, List<JKEEFDFHBLC>> IDKJHJMDEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly List<ICABHIKAJNJ> EHIEKJLMOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly List<ICABHIKAJNJ> ENBHKLHIJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly List<ICABHIKAJNJ> GKDAOJKEGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly List<ICABHIKAJNJ> FKNHGPOCJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Dictionary<JKEEFDFHBLC, Material> NKGMIPKLJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Dictionary<JKEEFDFHBLC, Material> DCKLFGNELIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private SkinnedMeshRenderer[] LMDJEEFDDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private SkinnedMeshRenderer[] ADHBDMBOOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private SkinnedMeshRenderer[] JHOGLMBHOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private SkinnedMeshRenderer[] KMLHFPNPFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<string, PHLGPCMBMIF<Texture2D>> NMEPCOODAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Dictionary<string, PHLGPCMBMIF<Texture2D>> DGJCGPHNEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private AdditionalHatData CMHDBGMLJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private AdditionalHatData JMLKEHEJICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private HairData NJMMGLNIKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private HairData MNFKKLCHFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private CMIMFAFIAGN FFBDANPBLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool? IHMFEODMKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private PositionAndRotation APPNJEMLFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private Transform BMMEKJDOJEF;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private Material MPGJCPEIMMD;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private Material MKOHLIFPNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Dictionary<string, ICGBLNBLOIJ> EAFODDDAICJ;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int CKKKIJCPPLA;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int DBFBMMEDIJL;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int FPDJNPKBIIH;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int DLJGOALBLPD;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int KGHHCAOEBCD;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int ILOBLPIGCCE;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int NFEOLCJFDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool CLLMKKCJHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<Action> LGGICHEAJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private GPMNGIKAHJN DDBNPCHENKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private SkinnedMeshRenderer[] IPHFFJFHOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private int GNBMIPKGLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool GKBDJKMIDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private int FCFAJJKJOPF;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public COOFKGJALFM BEKMECJBCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public COOFKGJALFM OOPEJLOLJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private BGNEBPNKOAE FAKMMFCIMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x77449E0", Offset = "0x77433E0", VA = "0x1877449E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool DDICOHMHBGN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7747620", Offset = "0x7746020", VA = "0x187747620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool DGEPFMIKHKA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x773F6B0", Offset = "0x773E0B0", VA = "0x18773F6B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool AKNNBNABNFN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7742390", Offset = "0x7740D90", VA = "0x187742390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool ADIODGLBMFP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7748FC0", Offset = "0x77479C0", VA = "0x187748FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public AvatarConfiguration FIIPGFGPDMG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4C0", Offset = "0x9AAEC0", VA = "0x1809AC4C0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool DNNCPOBOFIE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x129B7F0", Offset = "0x129A1F0", VA = "0x18129B7F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x24B20D0", Offset = "0x24B0AD0", VA = "0x1824B20D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Material PGKIBICODJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7744A50", Offset = "0x7743450", VA = "0x187744A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Material OFPIHBKJIBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x77465A0", Offset = "0x7744FA0", VA = "0x1877465A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool CPIJCBPAHJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public PLCLOJBLHOK JANPBHGBNLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x110D280", Offset = "0x110BC80", VA = "0x18110D280", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(PLCLOJBLHOK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x110DFD0", Offset = "0x110C9D0", VA = "0x18110DFD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Material GCLGMHMGEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xC5B5F0", Offset = "0xC59FF0", VA = "0x180C5B5F0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public SkinnedMeshRenderer[] JNPJKMAFJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x17D4DE0", Offset = "0x17D37E0", VA = "0x1817D4DE0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Renderer[] HAAPJNJOBOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA2B280", Offset = "0xA29C80", VA = "0x180A2B280", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool NCGAMJKFCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7744BF0", Offset = "0x77435F0", VA = "0x187744BF0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public FHMIHNFONJP.FMPAHPDMJAC PKBMBHJAANO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA24510", Offset = "0xA22F10", VA = "0x180A24510", Slot = "20")]
		get
		{
			return default(FHMIHNFONJP.FMPAHPDMJAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int FONLCDEMPPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x110D590", Offset = "0x110BF90", VA = "0x18110D590")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7742580", Offset = "0x7740F80", VA = "0x187742580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool BIHPBKHGOGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7745700", Offset = "0x7744100", VA = "0x187745700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private static bool HIAMLLKDPEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7746F20", Offset = "0x7745920", VA = "0x187746F20", Slot = "15")]
	public FDJPMDOFNPO LKMCDNLALMJ(LMGGFBLOMFG FODBMIGDMKE, bool LFMGMLOCDHH, int[] FFOPBFIPNAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x77457E0", Offset = "0x77441E0", VA = "0x1877457E0", Slot = "14")]
	public FDJPMDOFNPO JAKOBBBMHGM(LMGGFBLOMFG FODBMIGDMKE, bool LFMGMLOCDHH, int[] FFOPBFIPNAP, Func<Dictionary<string, ICGBLNBLOIJ>, (FDJPMDOFNPO, ECHAPNAJEJF<Dictionary<string, PHLGPCMBMIF<Texture2D>>>)> JGMFCPNDLLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x773F7C0", Offset = "0x773E1C0", VA = "0x18773F7C0")]
	public FDJPMDOFNPO CKMBICIPIJF(LMGGFBLOMFG FODBMIGDMKE, bool LFMGMLOCDHH, int[] FFOPBFIPNAP, bool FNOFBCJMOHN, EKGANCFHNJH FOICAPHOGEB, [Optional] Func<Dictionary<string, ICGBLNBLOIJ>, (FDJPMDOFNPO, ECHAPNAJEJF<Dictionary<string, PHLGPCMBMIF<Texture2D>>>)> JGMFCPNDLLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7745BF0", Offset = "0x77445F0", VA = "0x187745BF0")]
	private bool JMPNKBJPBKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x77491C0", Offset = "0x7747BC0", VA = "0x1877491C0")]
	private FDJPMDOFNPO PGFHAKGGAHJ(bool LFMGMLOCDHH, List<FONLGKLNJEI> PHGAIDDKLKE, int[] FFOPBFIPNAP, Func<int, LHABFABOONF> ENAPEEPNFLM, bool FNOFBCJMOHN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x77490A0", Offset = "0x7747AA0", VA = "0x1877490A0")]
	[IteratorStateMachine(typeof(PHMKMPHIEAH))]
	private IEnumerator<HKMFJDMPEMN> PFPDELPOEJD(bool LFMGMLOCDHH, List<FONLGKLNJEI> PHGAIDDKLKE, int[] FFOPBFIPNAP, Func<int, LHABFABOONF> ENAPEEPNFLM, BOKOODFHICH PFAFNLKCBNL, Material OBFGNDIHBNF, List<FDJPMDOFNPO> LIMPIDFIGLN, bool DOLDGPPPFKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7741880", Offset = "0x7740280", VA = "0x187741880")]
	private void DFLPLLEGCDD(List<FONLGKLNJEI> PHGAIDDKLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7748CF0", Offset = "0x77476F0", VA = "0x187748CF0")]
	private FDJPMDOFNPO OKFMFGEMEKC(List<FONLGKLNJEI> PHGAIDDKLKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x77428F0", Offset = "0x77412F0", VA = "0x1877428F0")]
	private NBLJJLKPDOF FCKHHAIIJFJ(List<FONLGKLNJEI> PHGAIDDKLKE, int BJJGMOJDONE, bool LFMGMLOCDHH, LHABFABOONF HKKKDLOOHLD, bool JBPGKOLDCPE, BOKOODFHICH PFAFNLKCBNL, Material OBFGNDIHBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7748B60", Offset = "0x7747560", VA = "0x187748B60", Slot = "27")]
	public void OIJMJBHLIFG(KBKDIFLNMMM LEHMDACBMCK, float PPJFMHBDGNA, bool JLFKEIOAGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x773DE30", Offset = "0x773C830", VA = "0x18773DE30", Slot = "29")]
	public void ANAPMKPEEPB(FOGOJOFLBFP LJLIALCOCGI, float PPJFMHBDGNA, bool NBFJGGOBNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7745530", Offset = "0x7743F30", VA = "0x187745530", Slot = "30")]
	public void IFEHECPIOJJ(NGIFDFOJOFE BBFEFDKOKCN, float PPJFMHBDGNA, bool GGHMJKGLKNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7745780", Offset = "0x7744180", VA = "0x187745780", Slot = "28")]
	public void IOJKDOCEAPK(bool JJKPEFBHBDO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7748A60", Offset = "0x7747460", VA = "0x187748A60", Slot = "31")]
	public void OEEBJPPLKMC(bool JJKPEFBHBDO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7746F60", Offset = "0x7745960", VA = "0x187746F60", Slot = "32")]
	public void MAOLEOHNPAH(bool JJKPEFBHBDO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7745680", Offset = "0x7744080", VA = "0x187745680")]
	private void INOIBDNDHFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7745600", Offset = "0x7744000", VA = "0x187745600")]
	private void IKIPIJPICMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7749BA0", Offset = "0x77485A0", VA = "0x187749BA0")]
	private void PMEPNLIADLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7742170", Offset = "0x7740B70", VA = "0x187742170", Slot = "25")]
	public void DKKAEOOJFJL(AvatarFaceShape GHNBOHNFBAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7744170", Offset = "0x7742B70", VA = "0x187744170", Slot = "26")]
	public void FMHDJJHHKMI(AvatarBodyShape PIBDMDPHCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x223DAB0", Offset = "0x223C4B0", VA = "0x18223DAB0", Slot = "33")]
	public void LLGFJFCMCOA(FPNKNMOGAJG JJLPPEFFCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7745810", Offset = "0x7744210", VA = "0x187745810", Slot = "35")]
	public void JMHLBOOEDOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7745CC0", Offset = "0x77446C0", VA = "0x187745CC0", Slot = "38")]
	public void JNNGPDPLOGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x77449D0", Offset = "0x77433D0", VA = "0x1877449D0", Slot = "34")]
	public void GIOAPDCGPNF(bool BLHKFLFJBMB, bool IOFIJDJGADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x773D8C0", Offset = "0x773C2C0", VA = "0x18773D8C0")]
	private void AMGHOPGBNEL(SkinnedMeshRenderer JEAGMCNNJJO, int BJJGMOJDONE, Mesh LKDNKMEFADL, List<Material> HOMEDHFEHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x773F550", Offset = "0x773DF50", VA = "0x18773F550")]
	private static Material CIGNLIEJHDH(Dictionary<JKEEFDFHBLC, Material> OCNBHCELGPD, Material IDFAOELBBLN, POBPEMENNMH EIODOGDANNJ, DFOGOECIEPI OBIKIOKNPMF, NMDLGPPCNIO NLOPOEHCFJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7744F40", Offset = "0x7743940", VA = "0x187744F40")]
	private static POBPEMENNMH HKGIKDHKEEJ(FONLGKLNJEI OGOGAMLKAGJ, int FIODFDPEOKO)
	{
		return default(POBPEMENNMH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x77483A0", Offset = "0x7746DA0", VA = "0x1877483A0")]
	private void ODIOPKDLHND(int HLLMOPBLAAD, Material GMIALIBEKEC, FONLGKLNJEI OGOGAMLKAGJ, [Out] Texture2D MLDFFCCCGBE, [Out] Vector4 GNPDMNPEPGL, [Out] Texture2D DPLCGMBLHMC, [Out] Texture2D ENCACOADLNA, [Out] Texture2D EAJIFNONCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7746690", Offset = "0x7745090", VA = "0x187746690")]
	private void LHMCOEIOEGK(int HLLMOPBLAAD, Material GMIALIBEKEC, FONLGKLNJEI OGOGAMLKAGJ, [Out] Color DANMIMGGCOC, [Out] Color PJOIBBACFCG, [Out] Color NDLPOBOJFAG, [Out] Color ENMCPLIKEOK, [Out] Color IFNKCLJFIPM, [Out] Color MMDFJKMNKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7741F10", Offset = "0x7740910", VA = "0x187741F10")]
	private bool DIBOIMOBAON(Material GMIALIBEKEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7744D60", Offset = "0x7743760", VA = "0x187744D60")]
	private static Material HBPJLICGMBD(int HLLMOPBLAAD, HDFAFPDANLL OGOGAMLKAGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x77417A0", Offset = "0x77401A0", VA = "0x1877417A0")]
	private static DFOGOECIEPI CPJAIDBOFDP(FONLGKLNJEI OGOGAMLKAGJ, int FIODFDPEOKO)
	{
		return default(DFOGOECIEPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x77487B0", Offset = "0x77471B0", VA = "0x1877487B0")]
	private static void ODJFEANHIBI(Dictionary<string, List<JKEEFDFHBLC>> NCNKGDJFDBF, FONLGKLNJEI NKFLMJBAGEN, Material IDFAOELBBLN, POBPEMENNMH GEGIJCNGLAA, DFOGOECIEPI PGJDIMIGJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7746FC0", Offset = "0x77459C0", VA = "0x187746FC0")]
	private static SkinnedMeshRenderer MDKPDOBACJB(Transform JDNEBEPHGLP, Transform IHKMLBPACMI, SkinnedMeshRenderer[] AKMDCBHNBHH, int BJJGMOJDONE, LHABFABOONF HKKKDLOOHLD, bool LFMGMLOCDHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7749D70", Offset = "0x7748770", VA = "0x187749D70")]
	public CPCDHCNGPGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x77425A0", Offset = "0x7740FA0", VA = "0x1877425A0")]
	public void ELAEPFFNBKM([In] JPPBKFJIJGH MALNOIAJNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7748F40", Offset = "0x7747940", VA = "0x187748F40")]
	public void OPJAALLODOJ([In] HAMGFJNHHNM EKDOFEOJLHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7742580", Offset = "0x7740F80", VA = "0x187742580", Slot = "5")]
	public void NPIHAFNKGIE(int BJJGMOJDONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7747230", Offset = "0x7745C30", VA = "0x187747230", Slot = "10")]
	public void MHGMGCCOPHG(DNCNOGCFLJF PGJDIMIGJMO, Texture2D IACCMECBPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410")]
	public static bool DOBEHOJONJL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7747700", Offset = "0x7746100", VA = "0x187747700", Slot = "11")]
	public bool MKNDBHALMLJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x77497A0", Offset = "0x77481A0", VA = "0x1877497A0", Slot = "9")]
	public void PKBGPHLGAGA(CMHGCJDKOOB GEGIJCNGLAA, Color? IFFOAMBAJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7744230", Offset = "0x7742C30", VA = "0x187744230")]
	private void GBBMPFOKJGN(Action JDGNFCHIMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7741EA0", Offset = "0x77408A0", VA = "0x187741EA0", Slot = "6")]
	public void DGGHKPHEHJE(ICGBLNBLOIJ FELGMPGPHGP, Texture JLIHHMHJLMB, Color NMDFMHPBJJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x24B20D0", Offset = "0x24B0AD0", VA = "0x1824B20D0", Slot = "7")]
	public void OLHDCNPBDAJ(bool DOLDGPPPFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x125D770", Offset = "0x125C170", VA = "0x18125D770", Slot = "8")]
	public void IIGCGDLEMIP(GPMNGIKAHJN KHABEFHMCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7745E00", Offset = "0x7744800", VA = "0x187745E00", Slot = "16")]
	public void KAGLOJOODCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x77475C0", Offset = "0x7745FC0", VA = "0x1877475C0", Slot = "36")]
	public void MIGKBOENDFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x773DF10", Offset = "0x773C910", VA = "0x18773DF10", Slot = "37")]
	public void AOIEAHEHGIJ([Optional] CMIMFAFIAGN KIJNHAIKGOL, [Optional] bool? LMHBOKIEHIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x77479F0", Offset = "0x77463F0", VA = "0x1877479F0")]
	private bool MNBKPMLJGDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7742560", Offset = "0x7740F60", VA = "0x187742560", Slot = "21")]
	public bool ECIFMMAHPGD(FHMIHNFONJP.FMPAHPDMJAC OHPLBKJHEPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7743A00", Offset = "0x7742400", VA = "0x187743A00")]
	private void FFEODLPAACD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7746F50", Offset = "0x7745950", VA = "0x187746F50")]
	private void LOIDGOHFCJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7741640", Offset = "0x7740040", VA = "0x187741640")]
	private static void CPBPMOFHPBB(Dictionary<JKEEFDFHBLC, Material> OCNBHCELGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x77442B0", Offset = "0x7742CB0", VA = "0x1877442B0")]
	private static void GBIDOHJNFIA(Dictionary<Renderer, BOKOODFHICH> KAICMNHDEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7746000", Offset = "0x7744A00", VA = "0x187746000")]
	private void KDJLLGHHODK(SkinnedMeshRenderer[] AKMDCBHNBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7741590", Offset = "0x773FF90", VA = "0x187741590")]
	private void CNCCLMHAMDJ(SkinnedMeshRenderer FHDLHCKNOOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7746270", Offset = "0x7744C70", VA = "0x187746270")]
	private void KMDKOEKBLCK(List<ICABHIKAJNJ> LIJOKFNJPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7747870", Offset = "0x7746270", VA = "0x187747870")]
	private void MNBCEOIOKJI(Dictionary<string, PHLGPCMBMIF<Texture2D>> NCNKGDJFDBF, bool PGEKEBEGJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7743BF0", Offset = "0x77425F0", VA = "0x187743BF0")]
	private void FHDLCNGPFFD(Dictionary<string, List<JKEEFDFHBLC>> NCNKGDJFDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x77451D0", Offset = "0x7743BD0", VA = "0x1877451D0")]
	private void HOGNDJGNNBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7745040", Offset = "0x7743A40", VA = "0x187745040")]
	private void HNPGHOIMJAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7744410", Offset = "0x7742E10", VA = "0x187744410")]
	private void GFNHFDGPLJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7742470", Offset = "0x7740E70", VA = "0x187742470")]
	private void DOCDPKHAGAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7748310", Offset = "0x7746D10", VA = "0x187748310")]
	private void OBGJIPAHMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7746120", Offset = "0x7744B20", VA = "0x187746120")]
	private void KLGIGNCECOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x773F480", Offset = "0x773DE80", VA = "0x18773F480")]
	private void CHAPAAHDKCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x773ED50", Offset = "0x773D750", VA = "0x18773ED50")]
	private void BDNNOHKALIJ(bool EKBLFLHHJEF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7746440", Offset = "0x7744E40", VA = "0x187746440")]
	private void LDNLGLCLFEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x773F3A0", Offset = "0x773DDA0", VA = "0x18773F3A0")]
	private void CFLECICFKEC(bool EKBLFLHHJEF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x773EE60", Offset = "0x773D860", VA = "0x18773EE60")]
	private void BGDCMDOMLIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7747DA0", Offset = "0x77467A0", VA = "0x187747DA0")]
	private void NFNOONNCFFC(Material OBFGNDIHBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7747450", Offset = "0x7745E50", VA = "0x187747450")]
	private void MIAJNMPBLCK(Material OBFGNDIHBNF, Color GFCBFFCJPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7747B60", Offset = "0x7746560", VA = "0x187747B60")]
	private void NFGIPKAOECB(Material OBFGNDIHBNF, Color GFCBFFCJPNC, Color AOALAKHGGGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7744DB0", Offset = "0x77437B0", VA = "0x187744DB0")]
	private void HDIKNGMPOJF(Material OBFGNDIHBNF, Color DANMIMGGCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x773F1B0", Offset = "0x773DBB0", VA = "0x18773F1B0")]
	private void CCKGIIFNGIE(Material OBFGNDIHBNF, Texture2D IACCMECBPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7741430", Offset = "0x773FE30", VA = "0x187741430")]
	private void CLMKOLJPBNO(Material OBFGNDIHBNF, Texture EFBLHFAOAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7742230", Offset = "0x7740C30", VA = "0x187742230")]
	private void DKNKFAECOHN(Action<BOKOODFHICH> NADIFBOCOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7745320", Offset = "0x7743D20", VA = "0x187745320")]
	private void HOLPJJBENFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x773DA10", Offset = "0x773C410", VA = "0x18773DA10")]
	private void AMOPCCPHIID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7746B50", Offset = "0x7745550", VA = "0x187746B50")]
	private void LJENNLEGNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7743D60", Offset = "0x7742760", VA = "0x187743D60")]
	public void FLFBOGKJJOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7748F40", Offset = "0x7747940", VA = "0x187748F40", Slot = "4")]
	private void PDIMJCLGENG([In] HAMGFJNHHNM EKDOFEOJLHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x77471F0", Offset = "0x7745BF0", VA = "0x1877471F0")]
	[CompilerGenerated]
	private JCIOFMEGJFK MGEBAJENMAH(FONLGKLNJEI GJPBKNDCAIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7743C40", Offset = "0x7742640", VA = "0x187743C40")]
	[CompilerGenerated]
	private void FHGKNCLGBOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7747B30", Offset = "0x7746530", VA = "0x187747B30")]
	[CompilerGenerated]
	private void NBGJOGOIIJN(BOKOODFHICH IDPJAHFFCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x77454A0", Offset = "0x7743EA0", VA = "0x1877454A0")]
	[CompilerGenerated]
	private void ICICPKPHFNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7748CD0", Offset = "0x77476D0", VA = "0x187748CD0")]
	[CompilerGenerated]
	private void OKELHBAFGDM(BOKOODFHICH IDPJAHFFCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7748280", Offset = "0x7746C80", VA = "0x187748280")]
	[CompilerGenerated]
	private void NMEHPNFBJCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7742540", Offset = "0x7740F40", VA = "0x187742540")]
	[CompilerGenerated]
	private void EBDOGAIHDAL(BOKOODFHICH IDPJAHFFCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7748C40", Offset = "0x7747640", VA = "0x187748C40")]
	[CompilerGenerated]
	private void OKBKNKPPBMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7743BC0", Offset = "0x77425C0", VA = "0x187743BC0")]
	[CompilerGenerated]
	private void FFHGDPKNCHK(BOKOODFHICH IDPJAHFFCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7746510", Offset = "0x7744F10", VA = "0x187746510")]
	[CompilerGenerated]
	private void LEDHBECDILJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x773EE30", Offset = "0x773D830", VA = "0x18773EE30")]
	[CompilerGenerated]
	private void BFEMAIEAEAG(BOKOODFHICH IDPJAHFFCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7748AD0", Offset = "0x77474D0", VA = "0x187748AD0")]
	[CompilerGenerated]
	private void OIDHIBOAHBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x773F790", Offset = "0x773E190", VA = "0x18773F790")]
	[CompilerGenerated]
	private void CKKGBMIFIFK(BOKOODFHICH IDPJAHFFCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7743CD0", Offset = "0x77426D0", VA = "0x187743CD0")]
	[CompilerGenerated]
	private void FHNMCPCFPFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x773D890", Offset = "0x773C290", VA = "0x18773D890")]
	[CompilerGenerated]
	private void ALDFCDFMIHE(BOKOODFHICH IDPJAHFFCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x77440F0", Offset = "0x7742AF0", VA = "0x1877440F0")]
	[CompilerGenerated]
	private void FMEMPKEFCJH(KeyValuePair<string, PHLGPCMBMIF<Texture2D>> LDBOMNNPKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7741630", Offset = "0x7740030", VA = "0x187741630")]
	[CompilerGenerated]
	private void COLNNDAAFAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x773F180", Offset = "0x773DB80", VA = "0x18773F180")]
	[CompilerGenerated]
	private void CAEFGJPKMED(BOKOODFHICH IDPJAHFFCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7748AC0", Offset = "0x77474C0", VA = "0x187748AC0")]
	[CompilerGenerated]
	private void OICAODALNBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x773D860", Offset = "0x773C260", VA = "0x18773D860")]
	[CompilerGenerated]
	private void AABKFGBPLEF(BOKOODFHICH IDPJAHFFCGA)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AvatarElbowBendHelperController : MonoBehaviour, GEEPOBBKDEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[JNJDEHPMCEK(PLKNMOLBJIE.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[Header("Scale")]
		[FormerlySerializedAs("MinScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		[FormerlySerializedAs("MaxScaleValues")]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[Header("Positional Offset")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private Vector3? AAFCMOJEGAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private bool GJFBNKHCMHI;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x773A210", Offset = "0x7738C10", VA = "0x18773A210", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x773A830", Offset = "0x7739230", VA = "0x18773A830", Slot = "4")]
		public void UpdateController(float GFOGDPEAFLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xBB40A0", Offset = "0xBB2AA0", VA = "0x180BB40A0", Slot = "6")]
		public void SetEnabled(bool PPJFMHBDGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x773A2F0", Offset = "0x7738CF0", VA = "0x18773A2F0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x773ACF0", Offset = "0x77396F0", VA = "0x18773ACF0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarElbowBendTargetController : MonoBehaviour, GEEPOBBKDEI
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private const float NAFIHMHDNLA = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[SerializeField]
		[JNJDEHPMCEK(PLKNMOLBJIE.Self, false, false, false)]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private Vector3 CKGECDAADNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private Vector3 MCNBPBDIHMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private bool GJFBNKHCMHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private float BPEIIILELPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private float CBMMBGKMCMB;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x773B070", Offset = "0x7739A70", VA = "0x18773B070", Slot = "4")]
		public void UpdateController(float GFOGDPEAFLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xEA02A0", Offset = "0xE9ECA0", VA = "0x180EA02A0", Slot = "6")]
		public void SetEnabled(bool PPJFMHBDGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x773AD90", Offset = "0x7739790", VA = "0x18773AD90")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x773BB30", Offset = "0x773A530", VA = "0x18773BB30")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GHDBNHIGCGP : IDADBLCKEOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly int CJLHBICBDIH;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly int OEEGCFHLAPD;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly int FMDBJBOJCLM;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly int PMPAOFODEHI;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly int OIHKFEOKJJM;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly int NAOIKMILACG;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly int BOMJLEMPENO;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly int AKJJNAHPKKJ;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly int EFMMAPHJMMP;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly int IBMGDJCJBHD;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly int DNGFGOODBGB;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly int NGCFJEGDLOH;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly int JJIGGCHAOPN;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly int LFEOCJEIMNN;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly int LIGHCBMDJAC;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private static readonly int GDHKBLDCMCJ;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private static readonly int NMGFOKBEELA;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static readonly int JJOHNDDFFMO;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private static readonly int KKFICIPPNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private Transform PGDOOIJACNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private Transform BDCJDNCMAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private Transform FMLJCJPGPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Transform LPNPBOALMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private Transform GABCJCAECLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private Transform PIBNPFGHDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private Transform EKECLHMAPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private MJDLDEACAML NJKONJOLPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private Material NECFMLODCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private SkinnedMeshRenderer[] DJHMDPJOLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly List<Material> EMGIOICMGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private FANJLCLCCCH DFFMOONPNDM;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public COOFKGJALFM PONCDDDPCIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private FANJLCLCCCH MPGEIBMNJOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x775ABB0", Offset = "0x77595B0", VA = "0x18775ABB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool BHLAOEGENBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7758E00", Offset = "0x7757800", VA = "0x187758E00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7759410", Offset = "0x7757E10", VA = "0x187759410")]
	public void ELAEPFFNBKM([In] MJDLDEACAML CCJDJNCCDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x77594F0", Offset = "0x7757EF0", VA = "0x1877594F0")]
	public void JFFKJBCKEBI([In] AFAAGAFKHLG MHAGAPCCBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7759620", Offset = "0x7758020", VA = "0x187759620", Slot = "6")]
	public void MDHEEBHEOFK(JDFIEGHCCFO CAKMKEGKEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x77593B0", Offset = "0x7757DB0", VA = "0x1877593B0")]
	private Vector2 EHOEFINMPKJ(Vector2 PKKDFGCPCPO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7759AE0", Offset = "0x77584E0", VA = "0x187759AE0")]
	public void NACIJOJPLFL([In] HCNFHCELBCE MHAGAPCCBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7758FF0", Offset = "0x77579F0", VA = "0x187758FF0")]
	private void ECOKAFOBCEO(HCFDIBNKBOO BOKBPCMHGIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x775AC30", Offset = "0x7759630", VA = "0x18775AC30")]
	private void ONJFCJNHKHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7758F80", Offset = "0x7757980", VA = "0x187758F80")]
	private void MIPPPPKOIGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7758F80", Offset = "0x7757980", VA = "0x187758F80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x775B2E0", Offset = "0x7759CE0", VA = "0x18775B2E0")]
	public GHDBNHIGCGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x77594F0", Offset = "0x7757EF0", VA = "0x1877594F0", Slot = "5")]
	private void ILCJMKDMHMC([In] AFAAGAFKHLG MHAGAPCCBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x77594E0", Offset = "0x7757EE0", VA = "0x1877594E0", Slot = "7")]
	private void IKGMPCKFAFJ([In] HCNFHCELBCE MHAGAPCCBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x775ABA0", Offset = "0x77595A0", VA = "0x18775ABA0")]
	[CompilerGenerated]
	internal static float OHFDOFALOBK(float PPJFMHBDGNA, float ALGCMLLEGBF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x775AA70", Offset = "0x7759470", VA = "0x18775AA70")]
	[CompilerGenerated]
	internal static void NFNPDAKAKLI(Vector2 EHPGHOFFHFD, Vector2 KPNDNHLMPDH, Vector2 PICLDLMFMMM, Vector2 ODPANEHCOAE, Vector2 AIHFEHEPHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7759590", Offset = "0x7757F90", VA = "0x187759590")]
	[CompilerGenerated]
	internal static (float, float) KPCFCDBKFOF(float LIHFHNPNNIE)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x775AB60", Offset = "0x7759560", VA = "0x18775AB60")]
	[CompilerGenerated]
	internal static Vector4 OBLHINECAOJ(Vector2 KKIJMCHODGC, Vector2 GFDDEGDNEEN)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class AvatarForearmRollController : MonoBehaviour, GEEPOBBKDEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private float BPEIIILELPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool GJFBNKHCMHI;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x77508B0", Offset = "0x774F2B0", VA = "0x1877508B0", Slot = "4")]
		public void UpdateController(float GFOGDPEAFLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x15BA530", Offset = "0x15B8F30", VA = "0x1815BA530", Slot = "6")]
		public void SetEnabled(bool PPJFMHBDGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7751110", Offset = "0x774FB10", VA = "0x187751110")]
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
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x77511B0", Offset = "0x774FBB0", VA = "0x1877511B0")]
		public void JCFABLNPBJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7751140", Offset = "0x774FB40", VA = "0x187751140")]
		public int FPHGIFIEJEI(int LJLIPHDDKJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class MOGLLAJNJHN : HBPJPFMBOKO
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7762550", Offset = "0x7760F50", VA = "0x187762550", Slot = "22")]
	public override float ENNLFBMNKIL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x77625A0", Offset = "0x7760FA0", VA = "0x1877625A0")]
	public MOGLLAJNJHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class HBPJPFMBOKO : ELDIGJNJHMI
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static int MDFOEGBFPAA;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static int EJJIDBINNGI;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static int MGENELBKDJJ;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static int LECOJHDPEJD;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static int OJEMDIDAMIJ;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static int NLNCBIFKOEM;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static int ANHAGINDAAP;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static int[] BALJGOLEIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private OGFLPDLEEDH NJKONJOLPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private IPCABAELMBB CCBBEKIKDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private int POGMLFJKBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private float LEJGFOMIHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	protected Animator MGGBFMOLPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	protected bool HNFKKIDGANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	protected AvatarConfiguration ABFBMBAJEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	protected int HGDBNCFDNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private int EMPAPJOPBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private int LLLHDLFAOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private bool IDAKCCEPCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private GEPMEECPPCE PLLEJELFEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private int GBFKJGDIPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private float EJGJOENGMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private AvatarHandDisplaySettings PAPEGJBANOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private PLCLOJBLHOK DENLLLMNFEF;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform CGNOMNNMEHH
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDA0", Offset = "0x9AD7A0", VA = "0x1809AEDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Vector3 DJAHBJICELI
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x15CDFE0", Offset = "0x15CC9E0", VA = "0x1815CDFE0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x15CE010", Offset = "0x15CCA10", VA = "0x1815CE010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Quaternion IJAGEMACMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xCA40D0", Offset = "0xCA2AD0", VA = "0x180CA40D0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xE99090", Offset = "0xE97A90", VA = "0x180E99090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool HPCKHJBEBDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x775BCE0", Offset = "0x775A6E0", VA = "0x18775BCE0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x775C300", Offset = "0x775AD00", VA = "0x18775C300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Vector3 PNKIKMOOJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x775C330", Offset = "0x775AD30", VA = "0x18775C330", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x775C3E0", Offset = "0x775ADE0", VA = "0x18775C3E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Quaternion FGONLFAOBJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x775C400", Offset = "0x775AE00", VA = "0x18775C400", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x775BF70", Offset = "0x775A970", VA = "0x18775BF70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public GOLGFCHBNKP PICJGHLPAKB
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xB122D0", Offset = "0xB10CD0", VA = "0x180B122D0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(GOLGFCHBNKP);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xB11880", Offset = "0xB10280", VA = "0x180B11880", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public GOLGFCHBNKP HHLGCGFELJD
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2388210", Offset = "0x2386C10", VA = "0x182388210", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(GOLGFCHBNKP);
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2387150", Offset = "0x2385B50", VA = "0x182387150", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float JLGMKJMHCEK
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x13CBD50", Offset = "0x13CA750", VA = "0x1813CBD50", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xE8D350", Offset = "0xE8BD50", VA = "0x180E8D350", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool AHEBKBPGGGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x775BCD0", Offset = "0x775A6D0", VA = "0x18775BCD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool DGIOGICLFIE
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x775BF60", Offset = "0x775A960", VA = "0x18775BF60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool KPJEENKCJJI
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x775C430", Offset = "0x775AE30", VA = "0x18775C430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool LGDILIMAOBC
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x775BCC0", Offset = "0x775A6C0", VA = "0x18775BCC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x775BD10", Offset = "0x775A710", VA = "0x18775BD10", Slot = "21")]
	public void ELAEPFFNBKM(OGFLPDLEEDH CCJDJNCCDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x775BF10", Offset = "0x775A910", VA = "0x18775BF10")]
	public void GMKIOPFCDOK(IPCABAELMBB CGABNLLGCIP, AvatarHandDisplaySettings DMPGLFJEEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x775B8F0", Offset = "0x775A2F0", VA = "0x18775B8F0", Slot = "12")]
	public void AHHOLECNAFM(bool AMLCJKDLNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x775BF90", Offset = "0x775A990", VA = "0x18775BF90", Slot = "11")]
	public void JEBILMLIPFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x13CBD50", Offset = "0x13CA750", VA = "0x1813CBD50", Slot = "22")]
	public virtual float ENNLFBMNKIL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x775BB40", Offset = "0x775A540", VA = "0x18775BB40")]
	private int BELEKKGPPOB(GOLGFCHBNKP BBCMBGAAODC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x775B980", Offset = "0x775A380", VA = "0x18775B980")]
	private void AKFAECDOCLF(int AFINNJLNDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x775C410", Offset = "0x775AE10", VA = "0x18775C410", Slot = "13")]
	public bool LIGCEHOKDCF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x775BEB0", Offset = "0x775A8B0", VA = "0x18775BEB0", Slot = "14")]
	public bool FHLLNGEDEEJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x775C350", Offset = "0x775AD50", VA = "0x18775C350")]
	private GOLGFCHBNKP KNBKGPGCPCM()
	{
		return default(GOLGFCHBNKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1CAC980", Offset = "0x1CAB380", VA = "0x181CAC980", Slot = "15")]
	public void MNHKMLDIHJB(bool AMLCJKDLNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x775C3A0", Offset = "0x775ADA0", VA = "0x18775C3A0", Slot = "10")]
	public void KPEJIGDCIIP(int AFINNJLNDHN, float PEOIBFLIGAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x775C440", Offset = "0x775AE40", VA = "0x18775C440", Slot = "8")]
	public void OMKLNOEFLFH(GEPMEECPPCE JCFJJCIGDKC, bool BAPBHDNFAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x775BF80", Offset = "0x775A980", VA = "0x18775BF80", Slot = "9")]
	public void JBMNELHKFCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x775BEC0", Offset = "0x775A8C0", VA = "0x18775BEC0", Slot = "16")]
	public void GFPLIBBFGJF(Transform HGBJMKAPAJA, Vector3 EAOIIGNJLGA, Quaternion BCLOIDMOMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x775C6F0", Offset = "0x775B0F0", VA = "0x18775C6F0")]
	public HBPJPFMBOKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class HDFAFPDANLL : FONLGKLNJEI
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class GIJMOENLGCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public HDFAFPDANLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public List<ICABHIKAJNJ> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public List<ICABHIKAJNJ> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public PHLGPCMBMIF<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public PHLGPCMBMIF<CHMBLPDHFAK> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public GIJMOENLGCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x775B420", Offset = "0x7759E20", VA = "0x18775B420")]
		internal JCIOFMEGJFK DJGLAEABDAK(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public ICGBLNBLOIJ NJCBAEFDHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public CHMBLPDHFAK MHPHHHHKIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private PHLGPCMBMIF<CHMBLPDHFAK> PEGKMAPNMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private PHLGPCMBMIF<Material[]> MOHKJCKAHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public Material[] BALLJAHMNHK;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool IOEAEBOLEOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9DAF20", Offset = "0x9D9920", VA = "0x1809DAF20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD40", Offset = "0x9D9740", VA = "0x1809DAD40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public FHMIHNFONJP.FMPAHPDMJAC OECHJPBMCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9AF000", Offset = "0x9ADA00", VA = "0x1809AF000")]
		[CompilerGenerated]
		get
		{
			return default(FHMIHNFONJP.FMPAHPDMJAC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9B6A80", Offset = "0x9B5480", VA = "0x1809B6A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x775DA00", Offset = "0x775C400", VA = "0x18775DA00")]
	public HDFAFPDANLL(NMDLGPPCNIO KLGHBAMAODA, ICGBLNBLOIJ KMDGPPOMPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x775CC20", Offset = "0x775B620", VA = "0x18775CC20", Slot = "6")]
	public override JCIOFMEGJFK IBBMKCDOLNJ(List<ICABHIKAJNJ> MNFKLMAEDHJ, List<ICABHIKAJNJ> KNJPKOAFJIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x775C920", Offset = "0x775B320", VA = "0x18775C920")]
	public JCIOFMEGJFK CACMAMFNIBM(List<ICABHIKAJNJ> MNFKLMAEDHJ, List<ICABHIKAJNJ> KNJPKOAFJIL, PHLGPCMBMIF<Material[]> MOHKJCKAHEI, [Optional] PHLGPCMBMIF<CHMBLPDHFAK> PHJDEEFGGAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x775D2E0", Offset = "0x775BCE0", VA = "0x18775D2E0")]
	public (PHLGPCMBMIF<Material[]>, PHLGPCMBMIF<CHMBLPDHFAK>) MGPOEKPODNN(List<ICABHIKAJNJ> MNFKLMAEDHJ, List<ICABHIKAJNJ> KNJPKOAFJIL)
	{
		return default((PHLGPCMBMIF<Material[]>, PHLGPCMBMIF<CHMBLPDHFAK>));
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x775D0E0", Offset = "0x775BAE0", VA = "0x18775D0E0", Slot = "7")]
	public override GOJIDCIIFON JIJJGPOJLNM(uint BJJGMOJDONE, AvatarSkinnedMeshBoneOrderRemapsData FGMFJJBHDOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x775C710", Offset = "0x775B110", VA = "0x18775C710")]
	public GOJIDCIIFON AIJFCCICDJN(GameObject CBOCLEDGHEF, uint BJJGMOJDONE, bool IIIEECCAJHD, bool NFCDOAFBGCO, AvatarSkinnedMeshBoneOrderRemapsData FGMFJJBHDOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x775D650", Offset = "0x775C050", VA = "0x18775D650")]
	public static bool OCAPKBHLMIJ(Renderer[] AKMDCBHNBHH, string BNELPCABPBC, [Out] Renderer OBGAFIEPKJC, [Out] Renderer ICBHGKNLNPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x775D9B0", Offset = "0x775C3B0", VA = "0x18775D9B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x775D210", Offset = "0x775BC10", VA = "0x18775D210")]
	private (PHLGPCMBMIF<CHMBLPDHFAK>, PHLGPCMBMIF<Material[]>) LDAOHCPBAPA()
	{
		return default((PHLGPCMBMIF<CHMBLPDHFAK>, PHLGPCMBMIF<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x775D0C0", Offset = "0x775BAC0", VA = "0x18775D0C0")]
	[CompilerGenerated]
	private void IIPBEFICEDE(CHMBLPDHFAK FFBEKAFHIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x9AC4E0", Offset = "0x9AAEE0", VA = "0x1809AC4E0")]
	[CompilerGenerated]
	private void HMBLHGFPJEL(Material[] FFBEKAFHIDB)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class AvatarKneeBendTargetController : MonoBehaviour, GEEPOBBKDEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		[JNJDEHPMCEK(PLKNMOLBJIE.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private Vector3 CKGECDAADNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private Vector3 ADAOJDPABBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private Vector3 HAPDMOKOLNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private Matrix4x4 BEBJOFAANBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private bool GJFBNKHCMHI;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7751740", Offset = "0x7750140", VA = "0x187751740", Slot = "4")]
		public void UpdateController(float GFOGDPEAFLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7751730", Offset = "0x7750130", VA = "0x187751730", Slot = "6")]
		public void SetEnabled(bool PPJFMHBDGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x77512D0", Offset = "0x774FCD0", VA = "0x1877512D0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7751E00", Offset = "0x7750800", VA = "0x187751E00")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[OHBOADDCADD]
public struct FHAEIEJKNFI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	[ReadOnly]
	public KLAHBOONFAK PKCGJAJFPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	[ReadOnly]
	public int OGLEALGIJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public PIONPNHKFIN GLAFBECLAKK;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7757DB0", Offset = "0x77567B0", VA = "0x187757DB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[NativeContainer]
[OHBOADDCADD]
public struct PIONPNHKFIN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<Vector3> ALPJCIFDBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<Vector3> JOJAFJKKHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<Vector4> JMHJBGHAPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<Vector2> ODMHGEIGCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<Vector2> AOLKGHCKBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<Vector2> CMIKEBGJDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<Vector2> EPCALHFACHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<Color> GMCBGEMKJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public NativeArray<int> GDANPJGACBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeArray<int> OLGMKEMJBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private NativeArray<int> PNCCJPPAIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private NativeArray<int> GIPLNEOODJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<int> MGKGEMOENNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<int> PNPEDABCDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<int> NNCKLPFDDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeArray<BoneWeight> DOKPMKFIOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private NativeArray<int> KHABEFHMCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private bool ALAMEHOPMFM;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int IPKNBOJALGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7763310", Offset = "0x7761D10", VA = "0x187763310")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7763320", Offset = "0x7761D20", VA = "0x187763320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int LOKMDKMKLHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7763330", Offset = "0x7761D30", VA = "0x187763330")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7763340", Offset = "0x7761D40", VA = "0x187763340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int ACJIGNELFKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7763360", Offset = "0x7761D60", VA = "0x187763360")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7763350", Offset = "0x7761D50", VA = "0x187763350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x77635C0", Offset = "0x7761FC0", VA = "0x1877635C0")]
	public PIONPNHKFIN(int EIHICPEDIAL, int BBIBEHNNOGH, int GGIBKGDIJPF, int OGKICHCIEKN, Allocator DDBBFOCJEFL, int HGOAOEEODCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7763550", Offset = "0x7761F50", VA = "0x187763550")]
	public void PIGOKANBOJB(int DOAKEFBOPIA, Vector3 LFDANFLODKB, Vector3 NFLJGFIFAHD, Vector4 PPOLMDFNGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7762B70", Offset = "0x7761570", VA = "0x187762B70")]
	public void AFCDJGOADPN(int DOAKEFBOPIA, BoneWeight IFJMNJIINLD, NativeSlice<byte> HALIJNAGNHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7763380", Offset = "0x7761D80", VA = "0x187763380")]
	public Color MGIIPNCJIPO(int DOAKEFBOPIA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x77633A0", Offset = "0x7761DA0", VA = "0x1877633A0")]
	public void MIKNOMIAFGC(int DOAKEFBOPIA, Color LHJMDMLADDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x77633C0", Offset = "0x7761DC0", VA = "0x1877633C0")]
	public void NGAFBNMAAPG(byte NAJPDPHLODA, int DOAKEFBOPIA, Vector2 FCHAPFLKCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7763370", Offset = "0x7761D70", VA = "0x187763370")]
	public void JBMHAJJJJNP(int DOAKEFBOPIA, int DLGFNDPIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7763130", Offset = "0x7761B30", VA = "0x187763130")]
	public bool CHPKILPFAPE(int NAJPDPHLODA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7763060", Offset = "0x7761A60", VA = "0x187763060")]
	public void CDAOKHPOFGM(int MLFGGCMOGCL, int LMGBAALNFHC, int ENHEICOLGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7763410", Offset = "0x7761E10", VA = "0x187763410")]
	public int[] NNMOCGJFGIC(int MLFGGCMOGCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x77634C0", Offset = "0x7761EC0", VA = "0x1877634C0")]
	private NativeSlice<int> PIEAKFKPMCP(int MLFGGCMOGCL)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7763160", Offset = "0x7761B60", VA = "0x187763160", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7762D10", Offset = "0x7761710", VA = "0x187762D10")]
	public Mesh AFHLMADFBBB([Optional] string ADKIMBOPCIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[OHBOADDCADD]
[DefaultMember("Item")]
[NativeContainer]
public struct KLAHBOONFAK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeArray<Vector3> ALPJCIFDBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<Vector3> JOJAFJKKHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<Vector4> JMHJBGHAPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeArray<Vector2> ODMHGEIGCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeArray<Vector2> AOLKGHCKBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeArray<Vector2> CMIKEBGJDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeArray<Vector2> EPCALHFACHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeArray<Color> GMCBGEMKJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeArray<int> BFMPAIFELOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeArray<int> AMINLKEIFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeArray<int> FOPHBJCAFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeArray<int> JNKMJMBMBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeArray<bool> AHODBJHIBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public NativeArray<int> FMCKNBDDNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public NativeArray<int> DMEOJEOFLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeArray<BoneWeight> DLNDNLOIKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private NativeArray<Matrix4x4> ODOGADIAOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private NativeArray<long> LLOFGFEPHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private NativeArray<byte> CJMNLKEPEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private NativeArray<int> JBADDGHAFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private NativeArray<int> DLGELMHAAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public NativeArray<sbyte> HHNFBKNDNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public NativeArray<byte> MFIDPIHHFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private NativeArray<int> KOKKFMJAOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private bool ALAMEHOPMFM;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int ABFAOKEAJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xD409B0", Offset = "0xD3F3B0", VA = "0x180D409B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int IEALDPHKAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xBB6D50", Offset = "0xBB5750", VA = "0x180BB6D50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int FEADEMIGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x775FA70", Offset = "0x775E470", VA = "0x18775FA70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int HCODBOKFLEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x775FD50", Offset = "0x775E750", VA = "0x18775FD50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x77602A0", Offset = "0x775ECA0", VA = "0x1877602A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int IPKNBOJALGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x775FD40", Offset = "0x775E740", VA = "0x18775FD40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x775FD60", Offset = "0x775E760", VA = "0x18775FD60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int LDIOJFCFKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x775FAC0", Offset = "0x775E4C0", VA = "0x18775FAC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7760390", Offset = "0x775ED90", VA = "0x187760390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public LMGHJFPJPAJ KGIEGAJFGKO
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x77603A0", Offset = "0x775EDA0", VA = "0x1877603A0")]
		get
		{
			return default(LMGHJFPJPAJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x775FAA0", Offset = "0x775E4A0", VA = "0x18775FAA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public byte BEILELEFOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x775FAB0", Offset = "0x775E4B0", VA = "0x18775FAB0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7760380", Offset = "0x775ED80", VA = "0x187760380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public KAAKGDNDKHP NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x775FD70", Offset = "0x775E770", VA = "0x18775FD70")]
		get
		{
			return default(KAAKGDNDKHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x77603B0", Offset = "0x775EDB0", VA = "0x1877603B0")]
	public KLAHBOONFAK(IList<Mesh> INENCIHLAGB, IList<Matrix4x4> AJAHAMLOLLA, IList<bool> AHODBJHIBDD, byte AAAHABGAGMO, IList<byte[]> KAALNOFKLEM, IList<long> JCCOJIFIIOB, IList<bool> PBMDJIJDBEN, IList<int> FMCKNBDDNFN, IList<int> LFPENPEBMLH, IList<int> HBHMGIKGFPL, Allocator DDBBFOCJEFL, LMGHJFPJPAJ JCKNAPLAPNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x77602B0", Offset = "0x775ECB0", VA = "0x1877602B0")]
	public PIONPNHKFIN IGJINPEDIBB(Allocator DDBBFOCJEFL)
	{
		return default(PIONPNHKFIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x775FAD0", Offset = "0x775E4D0", VA = "0x18775FAD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[OHBOADDCADD]
public class PJHIGIBAKFL : DFDNHDDPFFG
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7763A20", Offset = "0x7762420", VA = "0x187763A20")]
	public KLAHBOONFAK CLAKNHFJMMK()
	{
		return default(KLAHBOONFAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x774E710", Offset = "0x774D110", VA = "0x18774E710")]
	public PJHIGIBAKFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct KAAKGDNDKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public NativeSlice<Vector3> ALPJCIFDBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public NativeSlice<Vector3> JOJAFJKKHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public NativeSlice<Vector4> JMHJBGHAPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public NativeSlice<Vector2> ODMHGEIGCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeSlice<Vector2> AOLKGHCKBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public NativeSlice<Vector2> CMIKEBGJDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public NativeSlice<Vector2> EPCALHFACHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public NativeSlice<Color> GMCBGEMKJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public NativeSlice<int> HPHEJMHDHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public NativeSlice<int> JNKMJMBMBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public NativeSlice<BoneWeight> DLNDNLOIKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public NativeSlice<byte> KGAFGBACCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public int GIDNDAJPHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public Matrix4x4 POBMCAIDDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public long EJLKAFFCONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public NativeSlice<byte> HALIJNAGNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public bool FAOMIICMJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public int LBLHOJOKDEL;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal readonly struct JKEEFDFHBLC : IEquatable<JKEEFDFHBLC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	internal readonly Material LFCKJDCIBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	internal readonly POBPEMENNMH LBFGBCLLFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	internal readonly DFOGOECIEPI CKGNMBKLEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	internal readonly NMDLGPPCNIO GMMNKBFENHM;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x775F280", Offset = "0x775DC80", VA = "0x18775F280")]
	public JKEEFDFHBLC(Material GMIALIBEKEC, POBPEMENNMH EIODOGDANNJ, DFOGOECIEPI OBIKIOKNPMF, NMDLGPPCNIO NLOPOEHCFJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x775F060", Offset = "0x775DA60", VA = "0x18775F060", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x775EF40", Offset = "0x775D940", VA = "0x18775EF40", Slot = "4")]
	public bool Equals(JKEEFDFHBLC OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x775EE60", Offset = "0x775D860", VA = "0x18775EE60", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x775EFC0", Offset = "0x775D9C0", VA = "0x18775EFC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, NCFMNGEGECJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		[Header("Configuration")]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		[Header("Configuration")]
		private PLCLOJBLHOK avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[FormerlySerializedAs("avatarSkinAsset")]
		[SerializeField]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private OLDJDAKOFEE BIJJENIMIPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private IDADBLCKEOP GGIBKCDEIIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private ELDIGJNJHMI OEBFHNOIKLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private ELDIGJNJHMI LGEOGJPNFGF;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public OLDJDAKOFEE FJFJBOKECIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x7752E20", Offset = "0x7751820", VA = "0x187752E20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public IDADBLCKEOP HIDGGAJOIEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x7752E70", Offset = "0x7751870", VA = "0x187752E70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public ELDIGJNJHMI DOHIECAGEIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x7752EC0", Offset = "0x77518C0", VA = "0x187752EC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public ELDIGJNJHMI LEJOLFHHHMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x7752F10", Offset = "0x7751910", VA = "0x187752F10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Transform MKEKFONHJPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x7752F60", Offset = "0x7751960", VA = "0x187752F60", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public PLCLOJBLHOK MANDPMOPPKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x9B6FC0", Offset = "0x9B59C0", VA = "0x1809B6FC0", Slot = "12")]
			get
			{
				return default(PLCLOJBLHOK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7751E10", Offset = "0x7750810", VA = "0x187751E10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7752C80", Offset = "0x7751680", VA = "0x187752C80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7752990", Offset = "0x7751390", VA = "0x187752990", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7752C80", Offset = "0x7751680", VA = "0x187752C80", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7751F10", Offset = "0x7750910", VA = "0x187751F10", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7752D30", Offset = "0x7751730", VA = "0x187752D30")]
		public void UpdatePostIKAnimControllers(float GFOGDPEAFLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7751E80", Offset = "0x7750880", VA = "0x187751E80")]
		private void BIFOMLNFPEM(GameObject OIIGDBLKEDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x77525E0", Offset = "0x7750FE0", VA = "0x1877525E0")]
		private OLDJDAKOFEE HNCIANDLLDD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7752240", Offset = "0x7750C40", VA = "0x187752240")]
		private IDADBLCKEOP FIIOIMHGILI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x77529F0", Offset = "0x77513F0", VA = "0x1877529F0")]
		private ELDIGJNJHMI JKNGEJHCMGN(DFHKPAHKMFL IFCFCLBHODN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7752E10", Offset = "0x7751810", VA = "0x187752E10")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class BOKOODFHICH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private MaterialPropertyBlock LGJBODKHKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public Color? KPBANBMLMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public Color? AOKLGDOEJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public Color? HOLFCOCMLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public Color? DPFBBJIPDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public Color NHILAFBNIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public Color JLBKGPHJLNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public Color DNPGCHPIOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public Texture2D HMJGAKDEKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public Texture2D OFOKJFFDKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private Dictionary<JKEEFDFHBLC, int> POAHLHCPJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private POBPEMENNMH[] GHDGJAKBNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private DFOGOECIEPI[] FCFPKEPOIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public Vector4[] BPDOHJGHJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public Vector4[] NHIJEILEMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public Vector4[] NFBCGALLMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public Vector4[] OEKNMLFGHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public Vector4[] NDLFABGBBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public Vector4[] IJLLFHDIKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private List<Texture2D> CLBJNBOBNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private Vector4[] JBOMOLAEIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private List<Texture2D> GJJACBHFPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private float[] FMKJBLFAKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private Vector4[] OAFOOFCMEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private float[] KJOJLDNNJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public float[] NKMHNILLJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private List<Texture2D> EOHMPMIGGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private float[] BBNMGGLFLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private List<Texture2D> JKMIFOIFOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private Vector4[] AMADEGNDJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private float[] FLMIEPHELCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private Vector4[] DGINEFFNJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public float[] NJKJNDKICCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public Texture2DArray IKALGAHNHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public Texture2DArray JMOGMKODEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public Texture2DArray NGEFOGKHBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public Texture2DArray PAIKMBMFFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private bool ADEKCNBPFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private int ACPMOHDLBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private Vector2? AGOJMCDCCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private TextureFormat EEOKFNJECDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private Vector2? ENGIPICBLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private TextureFormat JINIDLJAFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private Vector2? HONNEEJEBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private TextureFormat LAHHKNLHAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private Vector2? DILIBCDGNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private TextureFormat NELMLKKDKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private bool AGGPBOPKIOC;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static int IOKHMBEEJHC;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static int NHHPPCLBELK;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static int DNKPFHOFFAJ;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static int IIGLNDCPHCF;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static int FKPLIIILMAK;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static int HLJOIAMIKFM;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static int ABLBDPLKDHN;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static int HDCLIFBNOML;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static int ENJKBNGAFEC;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private static int BCCBOPLEFJI;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private static int AGAEBKJGKNF;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static int PNOLHABEMNH;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private static int PDLMHGHOOPJ;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static int LHLHLFHHHDB;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private static int HADDNLBOICA;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private static int JDDLDMLFJEB;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static int EIBPOBIFPOM;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private static int GBMHAHJFFPK;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private static int INCBIDLPOLE;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private static int DELCHKAFMFF;

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7755CC0", Offset = "0x77546C0", VA = "0x187755CC0")]
	private BOKOODFHICH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7755C00", Offset = "0x7754600", VA = "0x187755C00")]
	public BOKOODFHICH(Color INECGFNAKKB, Color HOHPMOMKCFL, Color COELODINAIF, Color? MOKIBBGMDAC, Color? BLPJELFNNHB, Color? MKHKKLDLMGC, Texture2D PIKNMJHNHIH, Texture2D ONKNHPJBLEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7754610", Offset = "0x7753010", VA = "0x187754610")]
	internal int JJABJJGIJPD(Material FFOEDNBLELF, POBPEMENNMH EIODOGDANNJ, DFOGOECIEPI OBIKIOKNPMF, NMDLGPPCNIO NLOPOEHCFJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7754700", Offset = "0x7753100", VA = "0x187754700")]
	private int JJABJJGIJPD(JKEEFDFHBLC NJBPFCDJFGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x77548E0", Offset = "0x77532E0", VA = "0x1877548E0")]
	internal int MMBMNBKDMPK(Material FFOEDNBLELF, Color DANMIMGGCOC, Color PJOIBBACFCG, Color NDLPOBOJFAG, Color ENMCPLIKEOK, Color IFNKCLJFIPM, Texture2D AHJMHCDCCAM, Vector4 PKMLCIILNDF, Texture2D DALFMDCOELB, Vector4 IDODGEBHMLN, float BLFFNLHKCKF, float GGBLCEKBKMI, Texture2D DOJODJMANBG, Vector4 KNOJMLCPDMD, float EBBMPIFGBAF, Texture2D GKNFFLBLBJH, Color MMDFJKMNKBC, Vector4 JILMLNIGEPJ, POBPEMENNMH EIODOGDANNJ, DFOGOECIEPI OBIKIOKNPMF, NMDLGPPCNIO NLOPOEHCFJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7753790", Offset = "0x7752190", VA = "0x187753790")]
	private void EPEIOPHIDPL(List<Texture2D> CLBJNBOBNKI, [Out] Texture2DArray BFENIDGPEEH, [Out] Texture2DArray MPHJHEKNGOC, [Out] Texture2DArray DANOCKPGPGC, [Out] Texture2DArray LPKEGIODEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7754790", Offset = "0x7753190", VA = "0x187754790")]
	public void KBLOAEKHELH(Shader OCIKACJEPLJ, Renderer IBNNGOPMLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7753950", Offset = "0x7752350", VA = "0x187753950")]
	private void GGDMOIKJFCE(Shader OCIKACJEPLJ, Renderer IBNNGOPMLGG, int ADDOLNLCFHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7755560", Offset = "0x7753F60", VA = "0x187755560")]
	private Color OKLEOMHEMPH(Color BPALMKGEFKK, POBPEMENNMH GEGIJCNGLAA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7755760", Offset = "0x7754160", VA = "0x187755760")]
	private Color OLGIANBEAIH(Color FHFFFIDJNLO, POBPEMENNMH GEGIJCNGLAA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x77535F0", Offset = "0x7751FF0", VA = "0x1877535F0")]
	private bool AKMPGJFPLDC(Texture2D OECIEAGNLHI, DFOGOECIEPI PGJDIMIGJMO, [Out] Texture2D MMPNNJDGHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x77554B0", Offset = "0x7753EB0", VA = "0x1877554B0")]
	private void NHLDJEFPCAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x7753750", Offset = "0x7752150", VA = "0x187753750", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class FONLGKLNJEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public readonly NMDLGPPCNIO BMJKPMPGFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	protected bool FAEGJKCDEDF;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool DCDFNCAHJAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xBFFB90", Offset = "0xBFE590", VA = "0x180BFFB90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xBFF920", Offset = "0xBFE320", VA = "0x180BFF920")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool MOONOKCLPKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xBFFCE0", Offset = "0xBFE6E0", VA = "0x180BFFCE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xC00780", Offset = "0xBFF180", VA = "0x180C00780")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public virtual FHMIHNFONJP.FMPAHPDMJAC EJLKAFFCONJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(FHMIHNFONJP.FMPAHPDMJAC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xC01020", Offset = "0xBFFA20", VA = "0x180C01020", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool HMHBEGIJANA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x120A7C0", Offset = "0x12091C0", VA = "0x18120A7C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool GMKIJBEBEMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7758D40", Offset = "0x7757740", VA = "0x187758D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool OJMDPOKHOKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7758D30", Offset = "0x7757730", VA = "0x187758D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool LEKIPCPIEFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7758D50", Offset = "0x7757750", VA = "0x187758D50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x7758D70", Offset = "0x7757770", VA = "0x187758D70")]
	protected FONLGKLNJEI(NMDLGPPCNIO KLGHBAMAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract JCIOFMEGJFK IBBMKCDOLNJ(List<ICABHIKAJNJ> MNFKLMAEDHJ, List<ICABHIKAJNJ> KNJPKOAFJIL);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract GOJIDCIIFON JIJJGPOJLNM(uint BJJGMOJDONE, AvatarSkinnedMeshBoneOrderRemapsData FGMFJJBHDOP);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class MIIPBFIONCK : ENIJHGGPJFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	private AvatarSkinAssetItem OOFELOIGOOD;

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x7762190", Offset = "0x7760B90", VA = "0x187762190")]
	public MIIPBFIONCK(AvatarSkinAssetItem ICLAJNENGAH, AvatarSkinAssetItem.AECPPNFFACM LOFKIPAGLGH, NMDLGPPCNIO NLOPOEHCFJO, [Optional] FLDKPNGONNC? MEEJIKCCOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x7761F30", Offset = "0x7760930", VA = "0x187761F30", Slot = "6")]
	public override JCIOFMEGJFK IBBMKCDOLNJ(List<ICABHIKAJNJ> MNFKLMAEDHJ, List<ICABHIKAJNJ> KNJPKOAFJIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class HAELIJPJEPL
{
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	private static readonly int[] DHLBIHMHIAG;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private static readonly int[] AKJOCJICBHK;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static int[] FLGHLMGKEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x775B7A0", Offset = "0x775A1A0", VA = "0x18775B7A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x775B680", Offset = "0x775A080", VA = "0x18775B680")]
	public static int[] BLGDIDMOMGM(bool OAMMGGKMONH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x775B710", Offset = "0x775A110", VA = "0x18775B710")]
	public static int FGMIPBNALEC(HNIGDDENMGF MAMCMPMGPMM, bool OAMMGGKMONH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x775B700", Offset = "0x775A100", VA = "0x18775B700")]
	private static int CCFCDGACJLM(HNIGDDENMGF MAMCMPMGPMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x775B660", Offset = "0x775A060", VA = "0x18775B660")]
	private static int BBLJGPINLPP(HNIGDDENMGF MAMCMPMGPMM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class BIEBBOACGCB
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class JOLNHJHGHCB : IEnumerator<HKMFJDMPEMN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private HKMFJDMPEMN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		private HKMFJDMPEMN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
		[DebuggerHidden]
		public JOLNHJHGHCB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x119A340", Offset = "0x1198D40", VA = "0x18119A340", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x775F4C0", Offset = "0x775DEC0", VA = "0x18775F4C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
	public static void CCOPIAJDMKC(string ICHIIHCEGJD, int BJJGMOJDONE, long ODBACFPIMMJ, long DCHDALCHOPN, long DBJKPHDAKNN, long LPELFFPFFIK, long LMDNALMIOAK, long PKFHAKBHDOB, long JIDFGLPGMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x7753500", Offset = "0x7751F00", VA = "0x187753500")]
	public static NBLJJLKPDOF OLKMJHJKHGK(JobHandle EBHNKKMGOFO, bool CPCKDNMLLML, bool CPIJCBPAHJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7753490", Offset = "0x7751E90", VA = "0x187753490")]
	[IteratorStateMachine(typeof(JOLNHJHGHCB))]
	private static IEnumerator<HKMFJDMPEMN> DDGMJFCMMED(JobHandle ENNBIIMEOCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class AGNGAOALGKB
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum KJHLGDEIDPI
	{
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		General,
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly int KAKIFBEGKAL;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly int DIAOLIPIKBP;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly int DODDBCFJPDG;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly int AJJKMLLKHJF;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly int BIIMFGCHNHD;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly int ENOHLCPODFN;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly int CHEEKINJNJG;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly int ALCMGPPJKDC;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x77506D0", Offset = "0x774F0D0", VA = "0x1877506D0")]
	public static bool JFKEDJEHOCF(Material GMIALIBEKEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7750610", Offset = "0x774F010", VA = "0x187750610")]
	public static bool FELBLOAMBPH(Material GMIALIBEKEC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class ENIJHGGPJFO : FONLGKLNJEI
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class BGLDEODFHHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public PHLGPCMBMIF<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public ENIJHGGPJFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public BGLDEODFHHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x77530C0", Offset = "0x7751AC0", VA = "0x1877530C0")]
		internal void IGEPBJLICOE(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7752F80", Offset = "0x7751980", VA = "0x187752F80")]
		internal void DJGLAEABDAK(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	protected AvatarSkinAssetItem NMNEEDJIPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	protected Material[] KFKIJGNAGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private readonly AvatarSkinAssetItem.AECPPNFFACM PBGCOIDFHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private readonly AssetReference BGOCNMOINAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private readonly FLDKPNGONNC? KEGHHMEENMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private SkinnedMeshRenderer[] BPLJGADFOLD;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public override FHMIHNFONJP.FMPAHPDMJAC EJLKAFFCONJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x9AED50", Offset = "0x9AD750", VA = "0x1809AED50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(FHMIHNFONJP.FMPAHPDMJAC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDC0", Offset = "0x9AD7C0", VA = "0x1809AEDC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7756DD0", Offset = "0x77557D0", VA = "0x187756DD0")]
	public ENIJHGGPJFO(AvatarSkinAssetItem.AECPPNFFACM LOFKIPAGLGH, AssetReference KMABOBFPHEC, Material BLIDDNLCGOC, NMDLGPPCNIO NLOPOEHCFJO, FHMIHNFONJP.FMPAHPDMJAC DDLGOADPPGO = (FHMIHNFONJP.FMPAHPDMJAC)0L, [Optional] FLDKPNGONNC? MEEJIKCCOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x7756F00", Offset = "0x7755900", VA = "0x187756F00")]
	public ENIJHGGPJFO(AvatarSkinAssetItem.AECPPNFFACM LOFKIPAGLGH, AssetReference KMABOBFPHEC, Material BLIDDNLCGOC, FHMIHNFONJP.FMPAHPDMJAC DDLGOADPPGO = (FHMIHNFONJP.FMPAHPDMJAC)0L, [Optional] FLDKPNGONNC? MEEJIKCCOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7756980", Offset = "0x7755380", VA = "0x187756980", Slot = "6")]
	public override JCIOFMEGJFK IBBMKCDOLNJ(List<ICABHIKAJNJ> MNFKLMAEDHJ, List<ICABHIKAJNJ> KNJPKOAFJIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7756B50", Offset = "0x7755550", VA = "0x187756B50", Slot = "7")]
	public override GOJIDCIIFON JIJJGPOJLNM(uint BJJGMOJDONE, AvatarSkinnedMeshBoneOrderRemapsData FGMFJJBHDOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7756D60", Offset = "0x7755760", VA = "0x187756D60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7756930", Offset = "0x7755330", VA = "0x187756930")]
	protected void EBAIJMMLADJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class HFOMGDHKMEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private List<int> MHJDCODMMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private List<IODKBENFBOJ> MJBHMOELMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private HashSet<Transform> KPIKIDOGFBA;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x775DE60", Offset = "0x775C860", VA = "0x18775DE60")]
	public static HFOMGDHKMEF LJBOFPCGAOH(Transform PPOLMDFNGFC, Dictionary<Transform, OutfitType?> BIDBEBIIFBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x775E120", Offset = "0x775CB20", VA = "0x18775E120")]
	private void OHFHCOLDIKA(Transform PPOLMDFNGFC, NMDLGPPCNIO NLOPOEHCFJO, Dictionary<Transform, OutfitType?> BIDBEBIIFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x775DFF0", Offset = "0x775C9F0", VA = "0x18775DFF0")]
	private void OEOMDLNKHLD(Transform PEEPIEOKJGC, NMDLGPPCNIO NLOPOEHCFJO, bool OAKPJAMHDKJ, OutfitType? EPLOECKHAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x775DA70", Offset = "0x775C470", VA = "0x18775DA70")]
	public FBNNEMFBHAF FCABLNCHBFB(HashSet<string> LJOEGKCEPLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x775E3E0", Offset = "0x775CDE0", VA = "0x18775E3E0")]
	public HFOMGDHKMEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class FBNNEMFBHAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private List<IODKBENFBOJ> MJBHMOELMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private List<Matrix4x4> NDMNHNKDJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private Transform[] MCMIMKPMIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private Matrix4x4[] IJBIBFLCABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private Dictionary<MKPIKJMDMDB, int> BINPFOKIJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private List<KNFMMIGAPOD> FFLIKKIBEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private bool OPNBHBJBKDA;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int NIAGHPMMKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7757090", Offset = "0x7755A90", VA = "0x187757090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Transform[] IMFIPDGJAIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7757310", Offset = "0x7755D10", VA = "0x187757310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Matrix4x4[] HBNKAOBLNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7757020", Offset = "0x7755A20", VA = "0x187757020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7757470", Offset = "0x7755E70", VA = "0x187757470")]
	public void OEOMDLNKHLD(Transform PEEPIEOKJGC, NMDLGPPCNIO NLOPOEHCFJO, OutfitType? EPLOECKHAMG, bool BBBACBOMIFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7757660", Offset = "0x7756060", VA = "0x187757660")]
	private void OEOMDLNKHLD(Transform PEEPIEOKJGC, NMDLGPPCNIO NLOPOEHCFJO, OutfitType? EPLOECKHAMG, bool BBBACBOMIFB, Matrix4x4 MIOHOJPHDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7757A90", Offset = "0x7756490", VA = "0x187757A90")]
	public int PMDHGJLLCBL(MKPIKJMDMDB NJBPFCDJFGD, bool LKAHBEABLEP, [Optional] OutfitType? EPLOECKHAMG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x77570D0", Offset = "0x7755AD0", VA = "0x1877570D0")]
	public int GPIDEDEPALL(NMDLGPPCNIO NLOPOEHCFJO, [Optional] OutfitType? EPLOECKHAMG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x77579A0", Offset = "0x77563A0", VA = "0x1877579A0")]
	public void PCMNLJGKJCE(MKPIKJMDMDB NJBPFCDJFGD, Matrix4x4 FPLDLGEHPAN, bool LKAHBEABLEP = false, [Optional] OutfitType? EPLOECKHAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x77571D0", Offset = "0x7755BD0", VA = "0x1877571D0")]
	public Matrix4x4 MPGNCFDOBHP(MKPIKJMDMDB NJBPFCDJFGD, bool LKAHBEABLEP, [Optional] OutfitType? EPLOECKHAMG)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x1245A70", Offset = "0x1244470", VA = "0x181245A70")]
	public void CAABHMGPPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7757C40", Offset = "0x7756640", VA = "0x187757C40")]
	public FBNNEMFBHAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct MKPIKJMDMDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public readonly string CLIGABADLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public readonly NMDLGPPCNIO GMMNKBFENHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public readonly OutfitType? FLALAILNLIN;

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7762510", Offset = "0x7760F10", VA = "0x187762510")]
	public MKPIKJMDMDB(string CDCEKALPGPG, NMDLGPPCNIO NLOPOEHCFJO, [Optional] OutfitType? EPLOECKHAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7762460", Offset = "0x7760E60", VA = "0x187762460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x77623A0", Offset = "0x7760DA0", VA = "0x1877623A0")]
	public bool HCIIELMKAJD(MKPIKJMDMDB OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7762290", Offset = "0x7760C90", VA = "0x187762290", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7762330", Offset = "0x7760D30", VA = "0x187762330", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct KNFMMIGAPOD : IEquatable<KNFMMIGAPOD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public readonly NMDLGPPCNIO GMMNKBFENHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public readonly OutfitType? DMHFCGHGODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public readonly int DLKHJGPDJDN;

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7761F20", Offset = "0x7760920", VA = "0x187761F20")]
	public KNFMMIGAPOD(NMDLGPPCNIO NLOPOEHCFJO, int LLJCILFCFPD, [Optional] OutfitType? OHDEHIJLBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7761E50", Offset = "0x7760850", VA = "0x187761E50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x69F9C60", Offset = "0x69F8660", VA = "0x1869F9C60")]
	public bool EOBMAECPAOG(NMDLGPPCNIO NLOPOEHCFJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7761DD0", Offset = "0x77607D0", VA = "0x187761DD0")]
	public bool LNIIKLFMDNJ(OutfitType? OHDEHIJLBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7761D30", Offset = "0x7760730", VA = "0x187761D30", Slot = "4")]
	public bool Equals(KNFMMIGAPOD OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7761C40", Offset = "0x7760640", VA = "0x187761C40", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7761D80", Offset = "0x7760780", VA = "0x187761D80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct IODKBENFBOJ : IEquatable<IODKBENFBOJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public readonly Transform KHEMIFMGHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public readonly bool OBJBAFOGBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public readonly NMDLGPPCNIO MANALHJCBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public readonly OutfitType? FLALAILNLIN;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x775EE10", Offset = "0x775D810", VA = "0x18775EE10")]
	public IODKBENFBOJ(Transform PEEPIEOKJGC, bool OAKPJAMHDKJ, NMDLGPPCNIO LGIGACFENHA, [Optional] OutfitType? DHIGCDGPHLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x775EC00", Offset = "0x775D600", VA = "0x18775EC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x775EA80", Offset = "0x775D480", VA = "0x18775EA80", Slot = "4")]
	public bool Equals(IODKBENFBOJ OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x775E9A0", Offset = "0x775D3A0", VA = "0x18775E9A0", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x775EB80", Offset = "0x775D580", VA = "0x18775EB80", Slot = "2")]
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
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7758DA0", Offset = "0x77577A0", VA = "0x187758DA0")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x9AE050", Offset = "0x9ACA50", VA = "0x1809AE050")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface HBGJPACIFOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LOJKLLMGNLN(Mesh LKDNKMEFADL, Matrix4x4 JEMEHHMGNBE, byte[] HALIJNAGNHI, bool JNIDCDELJLG = false, FHMIHNFONJP.FMPAHPDMJAC AADHBKKKMKJ = (FHMIHNFONJP.FMPAHPDMJAC)0L, int FMCKNBDDNFN = -1, bool AHODBJHIBDD = false);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IJPNLAFJGGJ(Allocator DDBBFOCJEFL, LMGHJFPJPAJ JCKNAPLAPNN, byte AAAHABGAGMO, [Optional] IList<int> LFPENPEBMLH, [Optional] IList<int> NECNHAGMOCP);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct CHMBLPDHFAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public readonly GameObject CBOCLEDGHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private readonly AvatarItemMaterial CJNFGFJEGFF;

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0xA487F0", Offset = "0xA471F0", VA = "0x180A487F0")]
	public CHMBLPDHFAK(GameObject CBOCLEDGHEF, AvatarItemMaterial CJNFGFJEGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x77561B0", Offset = "0x7754BB0", VA = "0x1877561B0")]
	public void EMFGHIAOKHM(Material GMIALIBEKEC, int HLLMOPBLAAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class EDKGMICJEOC : OPDJODEMNPF<Task<(GameObject, AvatarItemMaterial)>, CHMBLPDHFAK>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct PDOAAOBNAPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7762600", Offset = "0x7761000", VA = "0x187762600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7762B00", Offset = "0x7761500", VA = "0x187762B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private PHLGPCMBMIF<GameObject> CMOMMMIGDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	private PHLGPCMBMIF<AvatarItemMaterial> JGJOLJGHHEB;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x77568A0", Offset = "0x77552A0", VA = "0x1877568A0")]
	private EDKGMICJEOC(Task<(GameObject, AvatarItemMaterial)> GLCABFFLNII, PHLGPCMBMIF<GameObject> MADHAFEDKAC, PHLGPCMBMIF<AvatarItemMaterial> GLGHIAOPMKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7756370", Offset = "0x7754D70", VA = "0x187756370")]
	public static EDKGMICJEOC IDEDHGEBOCJ(AssetReference BFHJDMJNIKF, [Optional] AssetReference FFGOHNCEHHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x7756800", Offset = "0x7755200", VA = "0x187756800", Slot = "11")]
	protected override CHMBLPDHFAK PNGGPEMMAKK(Task<(GameObject, AvatarItemMaterial)> OGGJOOOAAOE)
	{
		return default(CHMBLPDHFAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x7756780", Offset = "0x7755180", VA = "0x187756780", Slot = "12")]
	protected override void INJOKLOEEKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7756240", Offset = "0x7754C40", VA = "0x187756240")]
	[AsyncStateMachine(typeof(PDOAAOBNAPA))]
	private static Task<(GameObject, AvatarItemMaterial)> GJNMEBGGAHB(Task<GameObject> EFNEMGKJHPB, Task<AvatarItemMaterial> HLIAJMFALOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class IHMIPGKLNCD
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class KIMOIPDBINL : OPDJODEMNPF<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private PHLGPCMBMIF<MaterialMapAsset> ENNBIIMEOCP;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x775F990", Offset = "0x775E390", VA = "0x18775F990")]
		public KIMOIPDBINL(PHLGPCMBMIF<MaterialMapAsset> ENNBIIMEOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x775F570", Offset = "0x775DF70", VA = "0x18775F570", Slot = "11")]
		protected override Material[] PNGGPEMMAKK(Task<MaterialMapAsset> GLCABFFLNII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x775F510", Offset = "0x775DF10", VA = "0x18775F510", Slot = "12")]
		protected override void INJOKLOEEKC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class JOLAEMOEDLO : OPDJODEMNPF<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private List<PHLGPCMBMIF<Material>> MECHNCGCANG;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x775F450", Offset = "0x775DE50", VA = "0x18775F450")]
		public JOLAEMOEDLO(Task<Material[]> GLCABFFLNII, List<PHLGPCMBMIF<Material>> MECHNCGCANG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x775F400", Offset = "0x775DE00", VA = "0x18775F400", Slot = "11")]
		protected override Material[] PNGGPEMMAKK(Task<Material[]> OGGJOOOAAOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x775F2C0", Offset = "0x775DCC0", VA = "0x18775F2C0", Slot = "12")]
		protected override void INJOKLOEEKC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x775E510", Offset = "0x775CF10", VA = "0x18775E510")]
	public static PHLGPCMBMIF<Material[]> NGBABOHFKPH(AssetReference[] MGIENPMDDPO)
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
		public enum JKDPFOLJKDD
		{
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public enum JIEPKLGIGDD
		{
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public enum FPMMJLLOIPI : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			All,
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public struct HPMCKEDIPON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			public readonly Material LFCKJDCIBED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			public readonly JKDPFOLJKDD LBFGBCLLFKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			public readonly JIEPKLGIGDD CKGNMBKLEOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public readonly NMDLGPPCNIO GMMNKBFENHM;

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x775F280", Offset = "0x775DC80", VA = "0x18775F280")]
			public HPMCKEDIPON(Material GMIALIBEKEC, JKDPFOLJKDD EIODOGDANNJ, JIEPKLGIGDD OBIKIOKNPMF, NMDLGPPCNIO NLOPOEHCFJO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x7775070", Offset = "0x7773A70", VA = "0x187775070", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x775EF40", Offset = "0x775D940", VA = "0x18775EF40")]
			public bool HCIIELMKAJD(HPMCKEDIPON OLKLGHOAKNE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x7774EF0", Offset = "0x77738F0", VA = "0x187774EF0", Slot = "0")]
			public override bool Equals(object OIIGDBLKEDN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x7774FD0", Offset = "0x77739D0", VA = "0x187774FD0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		protected struct IGFBFOIHPKI : IComparable<IGFBFOIHPKI>, IEquatable<IGFBFOIHPKI>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public int JLAKDJGJIMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public PlayerAvatarDisplayBase CENGCFKJIFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			public IList<DCNPOBHCDAG> JIEMMOEOBNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			public AvatarItemBodyType LIJEADIHKGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			public EKGANCFHNJH ECDJEDCMKLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public bool HLJLJIIEAEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public int[] FFOPBFIPNAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public float JEJIBJPMBDP;

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x7775F70", Offset = "0x7774970", VA = "0x187775F70", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x7775E10", Offset = "0x7774810", VA = "0x187775E10", Slot = "4")]
			public int CompareTo(IGFBFOIHPKI OLKLGHOAKNE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x7775E30", Offset = "0x7774830", VA = "0x187775E30", Slot = "5")]
			public bool Equals(IGFBFOIHPKI OLKLGHOAKNE)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		protected abstract class DMHBHCPFKMM
		{
			[Cpp2IlInjected.Token(Token = "0x200005B")]
			public class IBNGJFNACGK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000360")]
				public readonly Mesh FDHBCIJJGGD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000361")]
				public readonly Material[] NNEHDKAADBA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000362")]
				public readonly Transform[] HMHPMBAIHLH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000363")]
				public readonly Matrix4x4[] JHHAKFHDDJM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000364")]
				public readonly Transform EACEAINGCHD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000365")]
				public readonly bool MLKCKKLPOCI;

				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
				protected IBNGJFNACGK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x77757B0", Offset = "0x77741B0", VA = "0x1877757B0")]
				public IBNGJFNACGK(Mesh LKDNKMEFADL, Material[] IDBOJBMKCPN, bool LAGOJFMOIIM, Transform[] JOOOFLHEIHP, Transform HFEJPACMJLA, Matrix4x4[] DPPGGKDBAOF)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x7775D50", Offset = "0x7774750", VA = "0x187775D50")]
				private IBNGJFNACGK(SkinnedMeshRenderer FHDLHCKNOOK, Material[] LCMIPEIHKPN)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FF")]
				[Cpp2IlInjected.Address(RVA = "0x7775C60", Offset = "0x7774660", VA = "0x187775C60")]
				private IBNGJFNACGK(MeshRenderer OAGBKEGGGEI, Transform HFEJPACMJLA, Material[] LCMIPEIHKPN)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000300")]
				[Cpp2IlInjected.Address(RVA = "0x7775490", Offset = "0x7773E90", VA = "0x187775490")]
				public static IBNGJFNACGK AGJPKKEEOAB(Renderer IBNNGOPMLGG, Material[] LCMIPEIHKPN)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public readonly NMDLGPPCNIO GMMNKBFENHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			public readonly Transform DONHMGNHGLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			public readonly bool OIKADFFCLAL;

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public virtual bool DCDFNCAHJAM
			{
				[Cpp2IlInjected.Token(Token = "0x60002F5")]
				[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public virtual bool MOONOKCLPKO
			{
				[Cpp2IlInjected.Token(Token = "0x60002F6")]
				[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public virtual FHMIHNFONJP.FMPAHPDMJAC EJLKAFFCONJ
			{
				[Cpp2IlInjected.Token(Token = "0x60002F7")]
				[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "6")]
				get
				{
					return default(FHMIHNFONJP.FMPAHPDMJAC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public bool FAOMIICMJFK
			{
				[Cpp2IlInjected.Token(Token = "0x60002F8")]
				[Cpp2IlInjected.Address(RVA = "0x7774A70", Offset = "0x7773470", VA = "0x187774A70")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x7774A80", Offset = "0x7773480", VA = "0x187774A80")]
			protected DMHBHCPFKMM(NMDLGPPCNIO NLOPOEHCFJO, Transform HAIAKLIMPBC, bool FCFPMCNLHFM = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract JCIOFMEGJFK IBBMKCDOLNJ(List<ICABHIKAJNJ> MNFKLMAEDHJ, List<ICABHIKAJNJ> KNJPKOAFJIL);

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract IBNGJFNACGK JIJJGPOJLNM(int BJJGMOJDONE, PlayerHandBones LKMLABAEHAG);
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		protected class CNKJHCELLMG : DMHBHCPFKMM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			protected readonly BodyPartLODs BPLJGADFOLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			protected readonly Material[] KFKIJGNAGNO;

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x7774030", Offset = "0x7772A30", VA = "0x187774030")]
			public CNKJHCELLMG(NMDLGPPCNIO NLOPOEHCFJO, BodyPartLODs JEOOPBNGAAN, Material BLIDDNLCGOC, [Optional] Transform HAIAKLIMPBC, bool FCFPMCNLHFM = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x7773D70", Offset = "0x7772770", VA = "0x187773D70", Slot = "7")]
			public override JCIOFMEGJFK IBBMKCDOLNJ(List<ICABHIKAJNJ> MNFKLMAEDHJ, List<ICABHIKAJNJ> KNJPKOAFJIL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x7773E00", Offset = "0x7772800", VA = "0x187773E00", Slot = "8")]
			public override IBNGJFNACGK JIJJGPOJLNM(int BJJGMOJDONE, PlayerHandBones LKMLABAEHAG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x7773FC0", Offset = "0x77729C0", VA = "0x187773FC0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected class CPJHLLACEEM : DMHBHCPFKMM
		{
			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public override bool DCDFNCAHJAM
			{
				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public override bool MOONOKCLPKO
			{
				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0x77741C0", Offset = "0x7772BC0", VA = "0x1877741C0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public CFMJKIIMPGC MKLAHADMPAA
			{
				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0x9AED50", Offset = "0x9AD750", VA = "0x1809AED50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x9B6FD0", Offset = "0x9B59D0", VA = "0x1809B6FD0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x7774280", Offset = "0x7772C80", VA = "0x187774280")]
			public CPJHLLACEEM(NMDLGPPCNIO NLOPOEHCFJO, Transform HAIAKLIMPBC, CFMJKIIMPGC LHECNOAGAEF, bool FCFPMCNLHFM = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x7774130", Offset = "0x7772B30", VA = "0x187774130", Slot = "7")]
			public override JCIOFMEGJFK IBBMKCDOLNJ(List<ICABHIKAJNJ> MNFKLMAEDHJ, List<ICABHIKAJNJ> KNJPKOAFJIL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "8")]
			public override IBNGJFNACGK JIJJGPOJLNM(int BJJGMOJDONE, PlayerHandBones LKMLABAEHAG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x7774210", Offset = "0x7772C10", VA = "0x187774210", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public class BBEFHFAGAFC
		{
			[Cpp2IlInjected.Token(Token = "0x200005F")]
			public enum OKOMBNPIOBE
			{
				[Cpp2IlInjected.Token(Token = "0x4000379")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x400037A")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x400037B")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x400037C")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x400037D")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x400037E")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x400037F")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public static readonly int KDILMHCFLII;

			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public static readonly int PEELJNFBDEG;

			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public static readonly int FLFABIBNFKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			protected readonly DFHKPAHKMFL IFCFCLBHODN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			protected readonly OFKPFFCELOF JBHGPKNDIIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			protected readonly Animator EFFBGMIGEKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			protected readonly Transform LFBLKLHCMNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			protected readonly Vector3 FKAMHPCCGIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			protected readonly Transform LMJMPIDHHOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			protected readonly Vector3 AEGHLGIBIFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			protected bool FGBJHKOEHCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			protected ELDIGJNJHMI JBAJEFAFEAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			protected bool APEFNPJCCCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			protected float GDHLOCBDBFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			protected JCIFFMNMFIG<GOLGFCHBNKP> AOKFMOIHMIM;

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public ELDIGJNJHMI MBJEPGCMGCN
			{
				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0x9AC530", Offset = "0x9AAF30", VA = "0x1809AC530")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0x9AC520", Offset = "0x9AAF20", VA = "0x1809AC520")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public bool MAKNMHNLKFM
			{
				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0xB66450", Offset = "0xB64E50", VA = "0x180B66450")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x7772D10", Offset = "0x7771710", VA = "0x187772D10")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public bool IBBCGHJBACA
			{
				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x9B21A0", Offset = "0x9B0BA0", VA = "0x1809B21A0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0x7772FE0", Offset = "0x77719E0", VA = "0x187772FE0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public float EFCPODHNBAA
			{
				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0xBFFBA0", Offset = "0xBFE5A0", VA = "0x180BFFBA0")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000314")]
				[Cpp2IlInjected.Address(RVA = "0x7772620", Offset = "0x7771020", VA = "0x187772620")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public GOLGFCHBNKP FGDNIFGIFNG
			{
				[Cpp2IlInjected.Token(Token = "0x6000315")]
				[Cpp2IlInjected.Address(RVA = "0x7772940", Offset = "0x7771340", VA = "0x187772940")]
				get
				{
					return default(GOLGFCHBNKP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x7772DE0", Offset = "0x77717E0", VA = "0x187772DE0")]
			public bool MPBOKAGOEND(GOLGFCHBNKP IBJJCDNEPPH, object GNAAILLDOKI, OKOMBNPIOBE KLEICHAFCLM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x7772B00", Offset = "0x7771500", VA = "0x187772B00")]
			public bool HGKOLOJDIDL(object GNAAILLDOKI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x7773840", Offset = "0x7772240", VA = "0x187773840")]
			protected BBEFHFAGAFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x7773250", Offset = "0x7771C50", VA = "0x187773250")]
			public BBEFHFAGAFC(DFHKPAHKMFL IFCFCLBHODN, ELDIGJNJHMI IMGIKMGEEHA, Animator EFFBGMIGEKO, Transform LFBLKLHCMNI, Transform LMJMPIDHHOA, Vector3 FKAMHPCCGIE, Vector3 AEGHLGIBIFD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x7773100", Offset = "0x7771B00", VA = "0x187773100")]
			private void PGHHLHLPOKN(ushort AFFHCHJALJC, ushort BPCFBHEODDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x7772EF0", Offset = "0x77718F0", VA = "0x187772EF0")]
			protected void OEFCFHEBJPB(ushort AFFHCHJALJC, ushort BPCFBHEODDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x7772880", Offset = "0x7771280", VA = "0x187772880")]
			protected void FIOEEBOBEIO(ushort AFFHCHJALJC, ushort BPCFBHEODDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x77729E0", Offset = "0x77713E0", VA = "0x1877729E0")]
			protected void HAEOHLOKEMA(ushort AFFHCHJALJC, ushort BPCFBHEODDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x7772C00", Offset = "0x7771600", VA = "0x187772C00")]
			protected void JKIEEDNBMAM(ushort AFFHCHJALJC, ushort BPCFBHEODDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x7772980", Offset = "0x7771380", VA = "0x187772980")]
			protected void GDKMOFAJIBD(ushort AFFHCHJALJC, ushort BPCFBHEODDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x77730B0", Offset = "0x7771AB0", VA = "0x1877730B0")]
			protected void PDJDPNOKNEH(ushort AFFHCHJALJC, ushort BPCFBHEODDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x77725D0", Offset = "0x7770FD0", VA = "0x1877725D0")]
			protected void CFNMNCMLILC(ushort AFFHCHJALJC, ushort BPCFBHEODDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x7772760", Offset = "0x7771160", VA = "0x187772760")]
			protected void FGNMCCDIPFP(ushort AFFHCHJALJC, ushort BPCFBHEODDN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public class JAJDLNFJJLF : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			public const int OCGDFNINBBA = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			protected MaterialPropertyBlock LGJBODKHKOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			public Color? KPBANBMLMKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			public Color? HOLFCOCMLOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public Color? DPFBBJIPDLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public Color NHILAFBNIDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public Color JLBKGPHJLNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			public Color DNPGCHPIOMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public Texture2D HMJGAKDEKON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public Texture2D OFOKJFFDKEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			protected Dictionary<HPMCKEDIPON, int> POAHLHCPJDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			protected JKDPFOLJKDD[] GHDGJAKBNGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			public Vector4[] BPDOHJGHJFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public Vector4[] NHIJEILEMMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public Vector4[] NFBCGALLMDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public Vector4[] OEKNMLFGHNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			public Vector4[] NDLFABGBBMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public Vector4[] IJLLFHDIKHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			protected List<Texture2D> CLBJNBOBNKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			protected Vector4[] JBOMOLAEIHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			protected List<Texture2D> GJJACBHFPDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected float[] FMKJBLFAKEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			protected Vector4[] OAFOOFCMEBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			protected float[] KJOJLDNNJCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public float[] NKMHNILLJPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			protected List<Texture2D> EOHMPMIGGDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			protected float[] BBNMGGLFLNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			protected List<Texture2D> JKMIFOIFOIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			protected Vector4[] AMADEGNDJGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			protected float[] FLMIEPHELCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			protected Vector4[] DGINEFFNJKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			public float[] NJKJNDKICCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public Texture2DArray IKALGAHNHCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public Texture2DArray JMOGMKODEHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public Texture2DArray NGEFOGKHBMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public Texture2DArray PAIKMBMFFPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			protected bool ADEKCNBPFMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			protected int ACPMOHDLBEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected Vector2? AGOJMCDCCLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected TextureFormat EEOKFNJECDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected Vector2? ENGIPICBLCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			protected TextureFormat JINIDLJAFNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			protected Vector2? HONNEEJEBFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			protected TextureFormat LAHHKNLHAKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			protected Vector2? DILIBCDGNOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			protected TextureFormat NELMLKKDKIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected bool AGGPBOPKIOC;

			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected static int IOKHMBEEJHC;

			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected static int NHHPPCLBELK;

			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected static int DNKPFHOFFAJ;

			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected static int IIGLNDCPHCF;

			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			protected static int FKPLIIILMAK;

			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			protected static int HLJOIAMIKFM;

			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			protected static int ABLBDPLKDHN;

			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			protected static int HDCLIFBNOML;

			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			protected static int ENJKBNGAFEC;

			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			protected static int BCCBOPLEFJI;

			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			protected static int AGAEBKJGKNF;

			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			protected static int PNOLHABEMNH;

			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			protected static int PDLMHGHOOPJ;

			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			protected static int LHLHLFHHHDB;

			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			protected static int HADDNLBOICA;

			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			protected static int JDDLDMLFJEB;

			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			protected static int EIBPOBIFPOM;

			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			protected static int GBMHAHJFFPK;

			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			protected static int INCBIDLPOLE;

			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			protected static int DELCHKAFMFF;

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x7778C80", Offset = "0x7777680", VA = "0x187778C80")]
			protected JAJDLNFJJLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x7778BF0", Offset = "0x77775F0", VA = "0x187778BF0")]
			public JAJDLNFJJLF(Color INECGFNAKKB, Color HOHPMOMKCFL, Color COELODINAIF, Color? MOKIBBGMDAC, Color? BLPJELFNNHB, Color? MKHKKLDLMGC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x7777490", Offset = "0x7775E90", VA = "0x187777490")]
			public int JJABJJGIJPD(Material FFOEDNBLELF, JKDPFOLJKDD EIODOGDANNJ, JIEPKLGIGDD OBIKIOKNPMF, NMDLGPPCNIO NLOPOEHCFJO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x7777400", Offset = "0x7775E00", VA = "0x187777400")]
			public int JJABJJGIJPD(HPMCKEDIPON NJBPFCDJFGD)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x77777E0", Offset = "0x77761E0", VA = "0x1877777E0")]
			public int MMBMNBKDMPK(Material FFOEDNBLELF, Color DANMIMGGCOC, Color PJOIBBACFCG, Color NDLPOBOJFAG, Color ENMCPLIKEOK, Color IFNKCLJFIPM, Texture2D AHJMHCDCCAM, Vector4 PKMLCIILNDF, Texture2D DALFMDCOELB, Vector4 IDODGEBHMLN, float BLFFNLHKCKF, float GGBLCEKBKMI, Texture2D DOJODJMANBG, Vector4 KNOJMLCPDMD, float EBBMPIFGBAF, Texture2D GKNFFLBLBJH, float LAPOIPCDILJ, Color MMDFJKMNKBC, Vector4 JILMLNIGEPJ, JKDPFOLJKDD EIODOGDANNJ, JIEPKLGIGDD OBIKIOKNPMF, NMDLGPPCNIO NLOPOEHCFJO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x7776750", Offset = "0x7775150", VA = "0x187776750")]
			protected void EPEIOPHIDPL([Out] Texture2DArray BFENIDGPEEH, [Out] Texture2DArray MPHJHEKNGOC, [Out] Texture2DArray DANOCKPGPGC, [Out] Texture2DArray LPKEGIODEIM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x7777580", Offset = "0x7775F80", VA = "0x187777580")]
			public void KBLOAEKHELH(PlayerAvatarDisplayBase LMLCFNKIMND, Renderer IBNNGOPMLGG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x7776910", Offset = "0x7775310", VA = "0x187776910")]
			protected void GGDMOIKJFCE(PlayerAvatarDisplayBase LMLCFNKIMND, Renderer IBNNGOPMLGG, int ADDOLNLCFHC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x77786B0", Offset = "0x77770B0", VA = "0x1877786B0")]
			private Color OKLEOMHEMPH(Color BPALMKGEFKK, JKDPFOLJKDD GEGIJCNGLAA)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x7778560", Offset = "0x7776F60", VA = "0x187778560")]
			private Color NKHENJBCGIO(Color MMGGJAAGJHK, JKDPFOLJKDD GEGIJCNGLAA)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x77784D0", Offset = "0x7776ED0", VA = "0x1877784D0")]
			protected void NHLDJEFPCAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x7776710", Offset = "0x7775110", VA = "0x187776710", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x77814B0", Offset = "0x777FEB0", VA = "0x1877814B0")]
			public void CIKODNEDHOF(NMDLGPPCNIO NLOPOEHCFJO, [Out] Transform MHHKOMDGDID, [Out] Transform[] JOOOFLHEIHP)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class MCOGAAGBBIM : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600033D")]
				[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600033F")]
				[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0xE17BE0", Offset = "0xE165E0", VA = "0x180E17BE0")]
			[DebuggerHidden]
			public MCOGAAGBBIM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x7779C00", Offset = "0x7778600", VA = "0x187779C00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x7779E80", Offset = "0x7778880", VA = "0x187779E80", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x7779DD0", Offset = "0x77787D0", VA = "0x187779DD0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x7779DD0", Offset = "0x77787D0", VA = "0x187779DD0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class DJHNDCLGKNF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public DJHNDCLGKNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x7774990", Offset = "0x7773390", VA = "0x187774990")]
			internal bool CLLKJACFKEL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class IIDCJDADADG : IEnumerator<HKMFJDMPEMN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			private HKMFJDMPEMN <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			private HKMFJDMPEMN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000347")]
				[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000349")]
				[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
			[DebuggerHidden]
			public IIDCJDADADG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x77760C0", Offset = "0x7774AC0", VA = "0x1877760C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x7776490", Offset = "0x7774E90", VA = "0x187776490", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private struct NJLELIDDPNB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			public BKNOFPPIEOM avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x777A4B0", Offset = "0x7778EB0", VA = "0x18777A4B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x777ACD0", Offset = "0x77796D0", VA = "0x18777ACD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class ODBLFHKDNDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public ODBLFHKDNDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x777B020", Offset = "0x7779A20", VA = "0x18777B020")]
			internal bool PBEFIGCDFAO(DCNPOBHCDAG selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class JKPBAMINGON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public Func<ECHAPNAJEJF<Dictionary<string, PHLGPCMBMIF<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public JKPBAMINGON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x7779740", Offset = "0x7778140", VA = "0x187779740")]
			internal (FDJPMDOFNPO, ECHAPNAJEJF<Dictionary<string, PHLGPCMBMIF<Texture2D>>>) IOEOKFLEANA(Dictionary<string, ICGBLNBLOIJ> avatarItems)
			{
				return default((FDJPMDOFNPO, ECHAPNAJEJF<Dictionary<string, PHLGPCMBMIF<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x77796D0", Offset = "0x77780D0", VA = "0x1877796D0")]
			internal ECHAPNAJEJF<Dictionary<string, PHLGPCMBMIF<Texture2D>>> IJKEEMGCGDG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x7779690", Offset = "0x7778090", VA = "0x187779690")]
			internal void ABHPEAHBAPF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class MFABACAIBFH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public MFABACAIBFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x7779ED0", Offset = "0x77788D0", VA = "0x187779ED0")]
			internal bool AEPAONBLNJN(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private struct IKLDGCPLANF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x77764E0", Offset = "0x7774EE0", VA = "0x1877764E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x77766B0", Offset = "0x77750B0", VA = "0x1877766B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		protected static readonly int DBFBMMEDIJL;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		protected static readonly int FPDJNPKBIIH;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		protected static readonly int DLJGOALBLPD;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		protected static readonly int KGHHCAOEBCD;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		protected static readonly int ILOBLPIGCCE;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		protected static readonly int NFEOLCJFDEG;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		protected static readonly int[] CDCIAENANEC;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		protected static readonly int[] DEDEHIHCIOK;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		protected static readonly int[] MIFFFLGDLML;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		protected static readonly int[] MKIGBBLAICF;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		protected static readonly int[] LJGPIDKKBAG;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		protected static readonly int[] BABFCNEGGNH;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		protected static List<PlayerAvatarDisplayBase> HKCJCFOOKCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		protected DBGJIPOCKFK GCINBGPHAJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		protected bool BLHKFLFJBMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		protected bool IOFIJDJGADA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		protected static readonly int[] IFOKHMIBEAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		protected Dictionary<HPMCKEDIPON, Material> KHICLGINEIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		protected Dictionary<HPMCKEDIPON, Material> DLHOCLPLDBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		[SerializeField]
		public Transform remoteMeshBase;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		protected Material MPGJCPEIMMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		protected OLDJDAKOFEE GDCMHMNPFGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private ELDIGJNJHMI OEBFHNOIKLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private ELDIGJNJHMI LGEOGJPNFGF;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		protected Material MKOHLIFPNJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		[SerializeField]
		public Transform hemisphereBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		protected FitMeshHemisphere BAEAOGOGNEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		protected bool OCPJNAAAHGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		protected CMIMFAFIAGN PDIJGCKNHOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		protected bool OHJBALLLGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		protected AnchorParamsRestrictions NFHAFNCPEFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		protected bool CHIHAMAFBCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		protected Transform GPOBONMAPOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		protected bool ICGBJMBONNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B1")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected bool BHFGMNCPCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected Vector3 FEMPPELBGHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		protected Quaternion IGIFLDEKKJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		protected Vector2 DNAIGNDAJHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		protected FitMeshHemisphere BKHPAAGCOKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		[JNJDEHPMCEK(PLKNMOLBJIE.SelfAndChildren, false, false, false)]
		[SerializeField]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		protected Collider[] LJLDMBPBCLN;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		protected Collider[] IBBNJDFEAAC;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		protected BBEFHFAGAFC[] OKEMBGFFNNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public Dictionary<Renderer, JAJDLNFJJLF> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		protected Dictionary<Renderer, JAJDLNFJJLF> HDMEJKODEHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		protected HFOMGDHKMEF BEECFJPLEJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		protected FDJPMDOFNPO AFFLDIAMDEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public HNIGDDENMGF DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		protected int FCFAJJKJOPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		protected (bool isLodForced, int forcedLOD) MGBINIAGGEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		protected JCIFFMNMFIG<OFKPFFCELOF> AOKFMOIHMIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected bool AAJBKNPEMGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected Dictionary<DCNPOBHCDAG, List<HPMCKEDIPON>> MJLLBNKDJBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		protected Dictionary<DCNPOBHCDAG, List<HPMCKEDIPON>> BBNPNNNOLCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		protected readonly Dictionary<string, PHLGPCMBMIF<Texture2D>> EIPOEHHLOBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected readonly Dictionary<string, PHLGPCMBMIF<Texture2D>> BLBDEADOKHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected bool IMOEGFJHDJF;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		protected static int PIMCDIFIFDI;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected static List<IGFBFOIHPKI> LFMOKNAEMMM;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected static List<IGFBFOIHPKI> NMCHEJEAABG;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected static NBLJJLKPDOF NOJJPFEDKJB;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected static bool FNPJPOLKAHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected Color? GDAMIDCPBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected bool KBGKGMAKLMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected Color AMJLIFCJOAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected Color HMEOIOIIJGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected Color EBNGFIBDCLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		protected AvatarHairPattern KBPNLKFOGFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		protected CFMJKIIMPGC JOPPBJAGHMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		protected Color KLHBFDKFHKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		protected Color BHANAIJHIAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		protected AvatarHairPattern HEEODJOKAEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		protected CFMJKIIMPGC MMOEDALKIJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		protected CFMJKIIMPGC CLJJPEIDFIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		protected Color GJOHMKFINOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private AdditionalFeetData MFGDLMEGGFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		protected DCNPOBHCDAG? JODHAAMPLCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected Texture IJCDCDHHBJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected Color HKPCLMLEFBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected readonly IList<DCNPOBHCDAG> MCLJOBMMHDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected readonly IList<DCNPOBHCDAG> HAAKCLJNLPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private AvatarItemBodyType HHGIGMDDGNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		[SerializeField]
		protected FPNKNMOGAJG _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D5")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		protected FPMMJLLOIPI CECIDIPLELA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		protected int[] DLGAAKGFFBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		protected bool GGOHBADBMPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		protected int[] DIBIJIDCGMK;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private static readonly FHMIHNFONJP.FMPAHPDMJAC JBODAHIBDEE;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private static readonly FHMIHNFONJP.FMPAHPDMJAC CNNPKDHFGAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		protected bool ENJLABHOKIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		protected GPMNGIKAHJN DDBNPCHENKP;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string ABAPGIIBLNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x9AF000", Offset = "0x9ADA00", VA = "0x1809AF000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x9AEDB0", Offset = "0x9AD7B0", VA = "0x1809AEDB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool DNNCPOBOFIE
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0xB915D0", Offset = "0xB8FFD0", VA = "0x180B915D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0xB909D0", Offset = "0xB8F3D0", VA = "0x180B909D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool GLHBPCLIAHB
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool ICPCBMFNIDE
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x7770FF0", Offset = "0x776F9F0", VA = "0x187770FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool DCKIIHMOMIC
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public virtual bool JHKADNMBDIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool AEECDDGMDMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public OLDJDAKOFEE ODGJKOKPKEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xA38FF0", Offset = "0xA379F0", VA = "0x180A38FF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x77717A0", Offset = "0x77701A0", VA = "0x1877717A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public ELDIGJNJHMI DOHIECAGEIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xA3AFC0", Offset = "0xA399C0", VA = "0x180A3AFC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x7771BA0", Offset = "0x77705A0", VA = "0x187771BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public ELDIGJNJHMI LEJOLFHHHMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xA4DD10", Offset = "0xA4C710", VA = "0x180A4DD10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x7771E70", Offset = "0x7770870", VA = "0x187771E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		protected Material PGKIBICODJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x7767940", Offset = "0x7766340", VA = "0x187767940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		protected Material OFPIHBKJIBN
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x776A690", Offset = "0x7769090", VA = "0x18776A690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool JMCIMILNLFL
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x20CAB00", Offset = "0x20C9500", VA = "0x1820CAB00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public PlayerFacialAnimatorBase MNJJALAFIED
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xA4DF20", Offset = "0xA4C920", VA = "0x180A4DF20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public BBEFHFAGAFC[] PLPGNBBJJMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x7770BC0", Offset = "0x776F5C0", VA = "0x187770BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public BBEFHFAGAFC NKPMFBIAKDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x77711E0", Offset = "0x776FBE0", VA = "0x1877711E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public BBEFHFAGAFC GEDHGKINGBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x7771210", Offset = "0x776FC10", VA = "0x187771210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public Mesh BJJJJHINPMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xA4E720", Offset = "0xA4D120", VA = "0x180A4E720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		protected HFOMGDHKMEF IMDGNAOAECF
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x776C310", Offset = "0x776AD10", VA = "0x18776C310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		protected FDJPMDOFNPO NIAPIBBPBFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0xA4EAB0", Offset = "0xA4D4B0", VA = "0x180A4EAB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x776C5D0", Offset = "0x776AFD0", VA = "0x18776C5D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected bool CPIJCBPAHJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public bool EPEOLBOFEEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x77711D0", Offset = "0x776FBD0", VA = "0x1877711D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public int FONLCDEMPPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x110DF90", Offset = "0x110C990", VA = "0x18110DF90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x7771DB0", Offset = "0x77707B0", VA = "0x187771DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public int CCKCNMPLIHH
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x7771AF0", Offset = "0x77704F0", VA = "0x187771AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		protected virtual bool JKCFGFHOLIA
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected virtual int[] KGDJJAJHIKE
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x776A8D0", Offset = "0x77692D0", VA = "0x18776A8D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected bool BIHPBKHGOGK
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x7769EB0", Offset = "0x77688B0", VA = "0x187769EB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected static bool HIAMLLKDPEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool ECGHEHDANBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x110C1A0", Offset = "0x110ABA0", VA = "0x18110C1A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x7772080", Offset = "0x7770A80", VA = "0x187772080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public IEnumerable<SkinnedMeshRenderer> APFPAOCOGCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x7770AA0", Offset = "0x776F4A0", VA = "0x187770AA0")]
			[IteratorStateMachine(typeof(MCOGAAGBBIM))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool BHLAOEGENBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x110DD40", Offset = "0x110C740", VA = "0x18110DD40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x110DD30", Offset = "0x110C730", VA = "0x18110DD30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public PLCLOJBLHOK JANPBHGBNLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x7770B20", Offset = "0x776F520", VA = "0x187770B20")]
			get
			{
				return default(PLCLOJBLHOK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public static bool EKAGDINALAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x7770F60", Offset = "0x776F960", VA = "0x187770F60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		protected static NBLJJLKPDOF LAFJKAKALEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x776AE60", Offset = "0x7769860", VA = "0x18776AE60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x77652E0", Offset = "0x7763CE0", VA = "0x1877652E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		protected Color HOLFCOCMLOM
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x776C8B0", Offset = "0x776B2B0", VA = "0x18776C8B0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		protected Color DPFBBJIPDLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x776A640", Offset = "0x7769040", VA = "0x18776A640")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected Texture2D JNNBOMOCNOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x7767370", Offset = "0x7765D70", VA = "0x187767370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected Color NHILAFBNIDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x776ACF0", Offset = "0x77696F0", VA = "0x18776ACF0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected Color JLBKGPHJLNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x776B7C0", Offset = "0x776A1C0", VA = "0x18776B7C0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public CFMJKIIMPGC IOPOHCJOKEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x7770B80", Offset = "0x776F580", VA = "0x187770B80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		protected Texture2D GHGPFMHOMPN
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x776B220", Offset = "0x7769C20", VA = "0x18776B220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public float JJGMMMJDKHB
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x7770BA0", Offset = "0x776F5A0", VA = "0x187770BA0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public float EGNPCKNKJAC
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x7770FD0", Offset = "0x776F9D0", VA = "0x187770FD0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public bool JKHBIDNOMID
		{
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x126AE10", Offset = "0x1269810", VA = "0x18126AE10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x7771580", Offset = "0x776FF80", VA = "0x187771580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action BEKMECJBCLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x7770800", Offset = "0x776F200", VA = "0x187770800")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x77712E0", Offset = "0x776FCE0", VA = "0x1877712E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action GLNCLCFHMJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x7770760", Offset = "0x776F160", VA = "0x187770760")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x7771240", Offset = "0x776FC40", VA = "0x187771240")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action KBPPIPHNFOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x77708A0", Offset = "0x776F2A0", VA = "0x1877708A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x7771380", Offset = "0x776FD80", VA = "0x187771380")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action OFIKIDINLIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x7770940", Offset = "0x776F340", VA = "0x187770940")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x7771420", Offset = "0x776FE20", VA = "0x187771420")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<DFHKPAHKMFL, GOLGFCHBNKP> GCPIOGFNKOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x77709E0", Offset = "0x776F3E0", VA = "0x1877709E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x77714C0", Offset = "0x776FEC0", VA = "0x1877714C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x776D690", Offset = "0x776C090", VA = "0x18776D690")]
		public bool SetDeformation(bool BLHKFLFJBMB, bool IOFIJDJGADA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7765890", Offset = "0x7764290", VA = "0x187765890")]
		protected static Material CIGNLIEJHDH(Dictionary<HPMCKEDIPON, Material> OCNBHCELGPD, Material IDFAOELBBLN, JKDPFOLJKDD EIODOGDANNJ, JIEPKLGIGDD OBIKIOKNPMF, NMDLGPPCNIO NLOPOEHCFJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x776B910", Offset = "0x776A310", VA = "0x18776B910")]
		protected void OAPGMIFACJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7768C80", Offset = "0x7767680", VA = "0x187768C80")]
		protected bool IINAHNNNHLD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x77659F0", Offset = "0x77643F0", VA = "0x1877659F0")]
		protected void CKNPAHEMCDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x77681B0", Offset = "0x7766BB0", VA = "0x1877681B0", Slot = "10")]
		protected virtual void HNPGHOIMJAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x776B160", Offset = "0x7769B60", VA = "0x18776B160")]
		public int MeshesAtLODCount(int HHMFLIKNNGJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x776BC30", Offset = "0x776A630", VA = "0x18776BC30")]
		protected static void ODJFEANHIBI(Dictionary<DCNPOBHCDAG, List<HPMCKEDIPON>> NCNKGDJFDBF, DMHBHCPFKMM NKFLMJBAGEN, Material IDFAOELBBLN, JKDPFOLJKDD GEGIJCNGLAA, JIEPKLGIGDD PGJDIMIGJMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7764E10", Offset = "0x7763810", VA = "0x187764E10")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7768420", Offset = "0x7766E20", VA = "0x187768420")]
		protected void HPOEIKCLEGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x776C330", Offset = "0x776AD30", VA = "0x18776C330")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "11")]
		protected virtual void LJANLOIECDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x776A960", Offset = "0x7769360", VA = "0x18776A960")]
		protected static void LLCLCCCKLFO(List<Material> HKDJLPFBDNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7765D00", Offset = "0x7764700", VA = "0x187765D00")]
		protected static void CPBPMOFHPBB(Dictionary<HPMCKEDIPON, Material> OCNBHCELGPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x77676E0", Offset = "0x77660E0", VA = "0x1877676E0")]
		protected static void GBIDOHJNFIA(Dictionary<Renderer, JAJDLNFJJLF> KAICMNHDEID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x776A290", Offset = "0x7768C90", VA = "0x18776A290")]
		protected void KDJLLGHHODK(SkinnedMeshRenderer[] AKMDCBHNBHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7765B90", Offset = "0x7764590", VA = "0x187765B90")]
		protected void CNCCLMHAMDJ(SkinnedMeshRenderer FHDLHCKNOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7765C30", Offset = "0x7764630", VA = "0x187765C30")]
		protected void CNCCLMHAMDJ(MeshRenderer OAGBKEGGGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x776A3B0", Offset = "0x7768DB0", VA = "0x18776A3B0")]
		protected void KMDKOEKBLCK(List<ICABHIKAJNJ> LIJOKFNJPCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x776AFE0", Offset = "0x77699E0", VA = "0x18776AFE0")]
		protected void MNBCEOIOKJI(Dictionary<string, PHLGPCMBMIF<Texture2D>> NCNKGDJFDBF, bool PGEKEBEGJNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7767460", Offset = "0x7765E60", VA = "0x187767460")]
		protected void FIFLBECHPNK(Dictionary<DCNPOBHCDAG, List<HPMCKEDIPON>> NCNKGDJFDBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7767D80", Offset = "0x7766780", VA = "0x187767D80")]
		public float GetHandOpenClosedAxis(DFHKPAHKMFL IFCFCLBHODN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x776DF20", Offset = "0x776C920", VA = "0x18776DF20")]
		public void SetHandOpenClosedAxis(DFHKPAHKMFL IFCFCLBHODN, float EALMINOLEBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7767DC0", Offset = "0x77667C0", VA = "0x187767DC0")]
		public GOLGFCHBNKP GetHandVisualState(DFHKPAHKMFL IFCFCLBHODN)
		{
			return default(GOLGFCHBNKP);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7764550", Offset = "0x7762F50", VA = "0x187764550")]
		public bool AddHandVisualStateToken(DFHKPAHKMFL IFCFCLBHODN, GOLGFCHBNKP LHOKCLCAEBJ, object GNAAILLDOKI, BBEFHFAGAFC.OKOMBNPIOBE KLEICHAFCLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x776F6F0", Offset = "0x776E0F0", VA = "0x18776F6F0")]
		public void SetWatchHand(DFHKPAHKMFL IFCFCLBHODN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x776F7B0", Offset = "0x776E1B0", VA = "0x18776F7B0")]
		public void SetWatchHands(bool KBECBPBMMLG, bool DEAIFPGNHEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x776CD50", Offset = "0x776B750", VA = "0x18776CD50")]
		public bool RemoveHandVisualStateToken(DFHKPAHKMFL IFCFCLBHODN, object GNAAILLDOKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7767E40", Offset = "0x7766840", VA = "0x187767E40")]
		public bool GetThumbsUpActive(DFHKPAHKMFL IFCFCLBHODN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x776F1A0", Offset = "0x776DBA0", VA = "0x18776F1A0")]
		public void SetThumbsUpActive(DFHKPAHKMFL IFCFCLBHODN, bool LOGCLOMFMLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7767E00", Offset = "0x7766800", VA = "0x187767E00")]
		public bool GetHandshakeActive(DFHKPAHKMFL IFCFCLBHODN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x776DF70", Offset = "0x776C970", VA = "0x18776DF70")]
		public void SetHandshakeActive(DFHKPAHKMFL IFCFCLBHODN, bool CCMLHHCHENF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7767690", Offset = "0x7766090", VA = "0x187767690")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x77665B0", Offset = "0x7764FB0", VA = "0x1877665B0")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x776AEB0", Offset = "0x77698B0", VA = "0x18776AEB0")]
		private static void MLBLEKLOPCH(Scene FHMFNFPPKKJ, LoadSceneMode NDELDEDNMOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x77674B0", Offset = "0x7765EB0", VA = "0x1877674B0")]
		protected static void FLILKAHGBOK(PlayerAvatarDisplayBase DCOIFLKLNEI, List<IGFBFOIHPKI> AMJIMCKJLMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x776CA70", Offset = "0x776B470", VA = "0x18776CA70")]
		public void Rebuild(bool KBLJMAJIJJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x77666D0", Offset = "0x77650D0", VA = "0x1877666D0")]
		protected void DHAONMAMGNO(bool KBLJMAJIJJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7766720", Offset = "0x7765120", VA = "0x187766720", Slot = "12")]
		protected virtual JCIOFMEGJFK DHAONMAMGNO(IList<DCNPOBHCDAG> CMCLOKKHPIP, AvatarItemBodyType KBPJOEAODKA, bool LFMGMLOCDHH, int[] POEDFLGLPKI, bool KBLJMAJIJJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7766860", Offset = "0x7765260", VA = "0x187766860")]
		protected static JCIOFMEGJFK DIBHJMPLKIM(IGFBFOIHPKI MCPIKNADBGM, List<IGFBFOIHPKI> AMJIMCKJLMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7765830", Offset = "0x7764230", VA = "0x187765830")]
		[IteratorStateMachine(typeof(IIDCJDADADG))]
		protected static IEnumerator<HKMFJDMPEMN> CBONCNPPBDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7767EA0", Offset = "0x77668A0", VA = "0x187767EA0")]
		protected static IGFBFOIHPKI HHCFPIHDIBL(List<IGFBFOIHPKI> AMJIMCKJLMK)
		{
			return default(IGFBFOIHPKI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x776D790", Offset = "0x776C190", VA = "0x18776D790")]
		[AsyncStateMachine(typeof(NJLELIDDPNB))]
		public Task SetFaceCustomizationSettings(BKNOFPPIEOM NHBLKJOHPMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7769FB0", Offset = "0x77689B0", VA = "0x187769FB0")]
		public void InitializeFaceFeatures(AvatarConfiguration EJFKKICKNHL, PLCLOJBLHOK IMLEEPAJBLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x776EF00", Offset = "0x776D900", VA = "0x18776EF00")]
		public void SetTeamColors(Color? MKHKKLDLMGC, bool LOINIBEPCEO, Color FGNMHNLHFGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x11D0CC0", Offset = "0x11CF6C0", VA = "0x1811D0CC0")]
		private static void NEGPACMAFOH(Material GMIALIBEKEC, Color PPJFMHBDGNA, params int[] PDGAMLOHAHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x11D0D60", Offset = "0x11CF760", VA = "0x1811D0D60")]
		private static void OMLNEMALJOD(Material GMIALIBEKEC, Texture PPJFMHBDGNA, params int[] PDGAMLOHAHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x776B540", Offset = "0x7769F40", VA = "0x18776B540")]
		protected void NFNOONNCFFC(Material OBFGNDIHBNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x776AD40", Offset = "0x7769740", VA = "0x18776AD40")]
		protected void MIAJNMPBLCK(Material OBFGNDIHBNF, Color GFCBFFCJPNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x776B320", Offset = "0x7769D20", VA = "0x18776B320")]
		protected void NFGIPKAOECB(Material OBFGNDIHBNF, Color GFCBFFCJPNC, Color AOALAKHGGGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x776C100", Offset = "0x776AB00", VA = "0x18776C100")]
		protected void OMEDDBJMAGM(Material OBFGNDIHBNF, Texture2D IACCMECBPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7765A80", Offset = "0x7764480", VA = "0x187765A80")]
		protected void CLMKOLJPBNO(Material OBFGNDIHBNF, Texture EFBLHFAOAPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7766EB0", Offset = "0x77658B0", VA = "0x187766EB0")]
		protected void DKNKFAECOHN(Action<JAJDLNFJJLF> NADIFBOCOGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x77654A0", Offset = "0x7763EA0", VA = "0x1877654A0")]
		protected void BGDCMDOMLIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7768210", Offset = "0x7766C10", VA = "0x187768210")]
		protected void HOLPJJBENFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7763BA0", Offset = "0x77625A0", VA = "0x187763BA0")]
		protected void AMOPCCPHIID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x77648A0", Offset = "0x77632A0", VA = "0x1877648A0")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x776D110", Offset = "0x776BB10", VA = "0x18776D110")]
		public void SetBeardPrimaryColor([Optional] Color? AMIIDGOEFFM, bool OJEAFOJIMDD = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x776D330", Offset = "0x776BD30", VA = "0x18776D330")]
		public void SetBeardSecondaryColor([Optional] Color? AMIIDGOEFFM, bool OJEAFOJIMDD = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x776CFD0", Offset = "0x776B9D0", VA = "0x18776CFD0")]
		public void SetBeardPattern([Optional] AvatarHairPattern FDIMKCLMBOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x776C740", Offset = "0x776B140", VA = "0x18776C740")]
		private void PGHBFDODJDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7765780", Offset = "0x7764180", VA = "0x187765780")]
		private bool CANKPFNEKOP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x776DB00", Offset = "0x776C500", VA = "0x18776DB00")]
		public void SetHairPrimaryColor([Optional] Color? IMGMFJPHDNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x776DD10", Offset = "0x776C710", VA = "0x18776DD10")]
		public void SetHairSecondaryColor([Optional] Color? IMGMFJPHDNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x776D9D0", Offset = "0x776C3D0", VA = "0x18776D9D0")]
		public void SetHairPattern([Optional] AvatarHairPattern FDIMKCLMBOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x776CBF0", Offset = "0x776B5F0", VA = "0x18776CBF0")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7767880", Offset = "0x7766280", VA = "0x187767880")]
		private bool GDOKACJNEFC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x776ED40", Offset = "0x776D740", VA = "0x18776ED40")]
		public void SetSkinColor(Color INECGFNAKKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x776F1F0", Offset = "0x776DBF0", VA = "0x18776F1F0")]
		public void SetUgcItemVisualOverrides(DCNPOBHCDAG FELGMPGPHGP, PLCLOJBLHOK IMLEEPAJBLH, Texture IAGIFEKHKMK, Color EIGLILGIKNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7766680", Offset = "0x7765080", VA = "0x187766680")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x776D890", Offset = "0x776C290", VA = "0x18776D890")]
		public bool SetFaceShape(AvatarFaceShape GHNBOHNFBAD, bool DLIHBBBBNGA = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x776C060", Offset = "0x776AA60", VA = "0x18776C060")]
		private void OIJMJBHLIFG(KBKDIFLNMMM LEHMDACBMCK, float PPJFMHBDGNA, bool JLFKEIOAGEJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7767B80", Offset = "0x7766580", VA = "0x187767B80")]
		private void GPGJHEMPHFF(EHALJNDDGPF CDMCELEPKIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7763F00", Offset = "0x7762900", VA = "0x187763F00")]
		private void ANAPMKPEEPB(FOGOJOFLBFP LJLIALCOCGI, float PPJFMHBDGNA, bool NBFJGGOBNAO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x77688C0", Offset = "0x77672C0", VA = "0x1877688C0")]
		private void IFEHECPIOJJ(NGIFDFOJOFE BBFEFDKOKCN, float PPJFMHBDGNA, bool GGHMJKGLKNB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x776A180", Offset = "0x7768B80", VA = "0x18776A180")]
		private void JKMPHDCNJDL(NGBBNHANMLM KCJEPMNCCJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x776B810", Offset = "0x776A210", VA = "0x18776B810")]
		private void NMHLFOAAGDK(FHPDKGDAIDC BAKLNIJKKNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x776D550", Offset = "0x776BF50", VA = "0x18776D550")]
		public bool SetBodyShape(AvatarBodyShape PIBDMDPHCEE, bool DLIHBBBBNGA = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x776EBD0", Offset = "0x776D5D0", VA = "0x18776EBD0")]
		public bool SetNoseType(FPNKNMOGAJG JJLPPEFFCLP, bool DLIHBBBBNGA = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x776F910", Offset = "0x776E310", VA = "0x18776F910")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x776EBB0", Offset = "0x776D5B0", VA = "0x18776EBB0")]
		public bool SetHideEars(bool MBHFMAKMJAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x776EBA0", Offset = "0x776D5A0", VA = "0x18776EBA0")]
		public bool SetHelmetHair(DBGJIPOCKFK MDADOCNOAJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x776DFC0", Offset = "0x776C9C0", VA = "0x18776DFC0")]
		public void SetHatAnchorParameters(CMIMFAFIAGN KAPDPOFAILO, bool CDNMGELEOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x776F880", Offset = "0x776E280", VA = "0x18776F880")]
		public void SetupDisplayLODs(FPMMJLLOIPI EDMBPGGOFBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7765020", Offset = "0x7763A20", VA = "0x187765020")]
		protected int[] BBFAGBHBGOG(FPMMJLLOIPI EDMBPGGOFBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x776ED00", Offset = "0x776D700", VA = "0x18776ED00")]
		public void SetOutfitSelections(IList<DCNPOBHCDAG> CMCLOKKHPIP, AvatarItemBodyType KBPJOEAODKA, bool KBLJMAJIJJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x776ECC0", Offset = "0x776D6C0", VA = "0x18776ECC0")]
		public void SetOutfitSelections(IList<DCNPOBHCDAG> CMCLOKKHPIP, AvatarItemBodyType KBPJOEAODKA, bool LFMGMLOCDHH, bool KBLJMAJIJJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x776EC70", Offset = "0x776D670", VA = "0x18776EC70")]
		public JCIOFMEGJFK SetOutfitSelections(IList<DCNPOBHCDAG> CMCLOKKHPIP, AvatarItemBodyType KBPJOEAODKA, FPMMJLLOIPI EDMBPGGOFBP, bool LFMGMLOCDHH, bool DLIHBBBBNGA = false, bool KBLJMAJIJJH = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x776AAA0", Offset = "0x77694A0", VA = "0x18776AAA0", Slot = "13")]
		protected virtual JCIOFMEGJFK MBDHOMGNMMC(IList<DCNPOBHCDAG> CMCLOKKHPIP, AvatarItemBodyType KBPJOEAODKA, bool LFMGMLOCDHH, FPMMJLLOIPI EDMBPGGOFBP, bool DLIHBBBBNGA, bool KBLJMAJIJJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x776BF60", Offset = "0x776A960", VA = "0x18776BF60")]
		protected int[] OFBEDEGBDJG(FPMMJLLOIPI EDMBPGGOFBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "14")]
		protected virtual FDJPMDOFNPO POMBDJMHHAN(AvatarItemBodyType JJHAMINNBAP, Dictionary<string, ICGBLNBLOIJ> HAEDEAILAJE, Dictionary<string, PHLGPCMBMIF<Texture2D>> FFBKKDDGINJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x77670A0", Offset = "0x7765AA0", VA = "0x1877670A0", Slot = "15")]
		protected virtual JCIOFMEGJFK ECHAGDIICAM(IList<DCNPOBHCDAG> CMCLOKKHPIP, AvatarItemBodyType KBPJOEAODKA, bool LFMGMLOCDHH, int[] FFOPBFIPNAP, EKGANCFHNJH DEPPIJDIFCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7764060", Offset = "0x7762A60", VA = "0x187764060", Slot = "16")]
		protected virtual ICGBLNBLOIJ APPENBNELEC(CFMJKIIMPGC LHECNOAGAEF, AvatarItemBodyType JJHAMINNBAP, NMDLGPPCNIO NLOPOEHCFJO, ICGBLNBLOIJ MHHAEKNANKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "17")]
		protected virtual ICGBLNBLOIJ DFOFONDFFPH(AvatarItemBodyType JJHAMINNBAP, NMDLGPPCNIO NLOPOEHCFJO, HAPJNADPHGJ OADJGMBHLBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7769F30", Offset = "0x7768930", VA = "0x187769F30")]
		protected void IONCKAGIKIG(LMGGFBLOMFG APGJCCALEPJ, FHMIHNFONJP.FMPAHPDMJAC NKFNCHOBFMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x776C9E0", Offset = "0x776B3E0", VA = "0x18776C9E0")]
		protected void PKPPHFGKJJP(LMGGFBLOMFG APGJCCALEPJ, FHMIHNFONJP.FMPAHPDMJAC NKFNCHOBFMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xA2E020", Offset = "0xA2CA20", VA = "0x180A2E020", Slot = "18")]
		protected virtual LMGGFBLOMFG HKCBDPLBPLL(LMGGFBLOMFG APGJCCALEPJ, HelmetHairStyle MOJLBDNAAKK, bool BJCOLKGNIEA, AvatarItemBodyType KBPJOEAODKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7768EA0", Offset = "0x77678A0", VA = "0x187768EA0")]
		protected LMGGFBLOMFG ILAKJKHKICM(IList<DCNPOBHCDAG> CMCLOKKHPIP, AvatarItemBodyType KJEEDGKGGIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7766490", Offset = "0x7764E90", VA = "0x187766490")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7768100", Offset = "0x7766B00", VA = "0x187768100")]
		protected void HKOIPNGPFFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x7768960", Offset = "0x7767360", VA = "0x187768960")]
		protected void IHFBHHJAAHK(Transform INLNBFKKPEN, IEnumerable<SkinnedMeshRenderer> PNKNNBECFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x776A580", Offset = "0x7768F80", VA = "0x18776A580")]
		protected FHMIHNFONJP.FMPAHPDMJAC LBOONDLCKJA(FHMIHNFONJP.FMPAHPDMJAC OHPLBKJHEPN, NMDLGPPCNIO KLGHBAMAODA)
		{
			return default(FHMIHNFONJP.FMPAHPDMJAC);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x776CA60", Offset = "0x776B460", VA = "0x18776CA60")]
		protected void PNCEJNDGJFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x1136460", Offset = "0x1134E60", VA = "0x181136460")]
		protected void PFNHPODIBMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x77651D0", Offset = "0x7763BD0", VA = "0x1877651D0")]
		protected void BBIFDCPBHIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x77675C0", Offset = "0x7765FC0", VA = "0x1877675C0")]
		[AsyncStateMachine(typeof(IKLDGCPLANF))]
		protected Task FPIBAAIOGIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7767F60", Offset = "0x7766960", VA = "0x187767F60")]
		protected static JKDPFOLJKDD HKGIKDHKEEJ(DMHBHCPFKMM OGOGAMLKAGJ, int FIODFDPEOKO)
		{
			return default(JKDPFOLJKDD);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7765E60", Offset = "0x7764860", VA = "0x187765E60")]
		protected static JIEPKLGIGDD CPJAIDBOFDP(DMHBHCPFKMM OGOGAMLKAGJ, int FIODFDPEOKO)
		{
			return default(JIEPKLGIGDD);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x776BF10", Offset = "0x776A910", VA = "0x18776BF10")]
		protected Transform OEGJMIIECDP(NMDLGPPCNIO NLOPOEHCFJO, OutfitType EPLOECKHAMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x776BA30", Offset = "0x776A430", VA = "0x18776BA30")]
		protected void ODIOPKDLHND(int HLLMOPBLAAD, Material GMIALIBEKEC, DMHBHCPFKMM OGOGAMLKAGJ, [Out] Texture2D MLDFFCCCGBE, [Out] Vector4 GNPDMNPEPGL, [Out] Texture2D DPLCGMBLHMC, [Out] Texture2D ENCACOADLNA, [Out] Texture2D EAJIFNONCPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x776A780", Offset = "0x7769180", VA = "0x18776A780")]
		protected void LHMCOEIOEGK(int HLLMOPBLAAD, Material GMIALIBEKEC, DMHBHCPFKMM OGOGAMLKAGJ, [Out] Color DANMIMGGCOC, [Out] Color PJOIBBACFCG, [Out] Color NDLPOBOJFAG, [Out] Color ENMCPLIKEOK, [Out] Color IFNKCLJFIPM, [Out] Color MMDFJKMNKBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x776A070", Offset = "0x7768A70", VA = "0x18776A070")]
		protected void JEOKMPLJKND(Vector3 NHAANPHMDOL, Quaternion JHFELMOKPLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x776E550", Offset = "0x776CF50", VA = "0x18776E550")]
		public void SetHatAnchorParameters(CMIMFAFIAGN KAPDPOFAILO, AnchorParamsRestrictions JEKCLHIPEKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7765FB0", Offset = "0x77649B0", VA = "0x187765FB0")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere BAEAOGOGNEH, Transform GPOBONMAPOK, CMIMFAFIAGN KAPDPOFAILO, AnchorParamsRestrictions NFHAFNCPEFC, [Out] Vector3 GHOLIOPECPJ, [Out] Quaternion BOFAHJJKKBL, [Out] CMIMFAFIAGN LLBJOPEHJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x776CE60", Offset = "0x776B860", VA = "0x18776CE60")]
		public void ResetHatAnchor(Vector2 PCAOBMBIKJE, Vector3 BPBGFIJMCOD, Vector3 HFMGFDPLEDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xA29BE0", Offset = "0xA285E0", VA = "0x180A29BE0")]
		public DNNONBHLEHK GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x77646D0", Offset = "0x77630D0", VA = "0x1877646D0")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7764810", Offset = "0x7763210", VA = "0x187764810")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7764640", Offset = "0x7763040", VA = "0x187764640")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x776F8B0", Offset = "0x776E2B0", VA = "0x18776F8B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7763FA0", Offset = "0x77629A0", VA = "0x187763FA0")]
		protected void APAJLJCDADP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x776F670", Offset = "0x776E070", VA = "0x18776F670")]
		public void SetWaitForUgcTextureLoads(bool DOLDGPPPFKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x776F580", Offset = "0x776DF80", VA = "0x18776F580")]
		public void SetUgcTextureParameters(GPMNGIKAHJN KHABEFHMCBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7770160", Offset = "0x776EB60", VA = "0x187770160")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7763B10", Offset = "0x7762510", VA = "0x187763B10")]
		[CompilerGenerated]
		private void AMONENPLKFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x7766E80", Offset = "0x7765880", VA = "0x187766E80")]
		[CompilerGenerated]
		private void DJKDDLIBNNK(JAJDLNFJJLF IDPJAHFFCGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7768750", Offset = "0x7767150", VA = "0x187768750")]
		[CompilerGenerated]
		private void ICIIPKFJLOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x77656E0", Offset = "0x77640E0", VA = "0x1877656E0")]
		[CompilerGenerated]
		private void BPFNGPOKPLL(JAJDLNFJJLF IDPJAHFFCGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x77687E0", Offset = "0x77671E0", VA = "0x1877687E0")]
		[CompilerGenerated]
		private void IDEJGNHBJDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x776A0E0", Offset = "0x7768AE0", VA = "0x18776A0E0")]
		[CompilerGenerated]
		private void JFAMFILIKPG(JAJDLNFJJLF IDPJAHFFCGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x776C6B0", Offset = "0x776B0B0", VA = "0x18776C6B0")]
		[CompilerGenerated]
		private void PFOGDHDNNKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7768870", Offset = "0x7767270", VA = "0x187768870")]
		[CompilerGenerated]
		private void IDIOFHLOAOA(JAJDLNFJJLF IDPJAHFFCGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7767010", Offset = "0x7765A10", VA = "0x187767010")]
		[CompilerGenerated]
		private void DNHPAFHKOKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x77683D0", Offset = "0x7766DD0", VA = "0x1877683D0")]
		[CompilerGenerated]
		private void HPHOAADNNIN(JAJDLNFJJLF IDPJAHFFCGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7764F90", Offset = "0x7763990", VA = "0x187764F90")]
		[CompilerGenerated]
		private void BAAFGJMKPJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7767E80", Offset = "0x7766880", VA = "0x187767E80")]
		[CompilerGenerated]
		private void HEHIMFOEMKO(JAJDLNFJJLF IDPJAHFFCGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x776C900", Offset = "0x776B300", VA = "0x18776C900")]
		[CompilerGenerated]
		internal static bool PHFLCEGMEAK(Transform DJHJALMJCAI, IEnumerable<SkinnedMeshRenderer> KOMOGGDNGAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7767840", Offset = "0x7766240", VA = "0x187767840")]
		[CompilerGenerated]
		private void GCDLENHAEIB(JAJDLNFJJLF IDPJAHFFCGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x776C670", Offset = "0x776B070", VA = "0x18776C670")]
		[CompilerGenerated]
		private void PDDDJBMMEBH(JAJDLNFJJLF IDPJAHFFCGA)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, BEPIEELIFLK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private struct OBFGJCBIMIB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public BKNOFPPIEOM avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x777AD30", Offset = "0x7779730", VA = "0x18777AD30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x777AFC0", Offset = "0x77799C0", VA = "0x18777AFC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct LCFKNPAHPCC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			public PLCLOJBLHOK avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x77799C0", Offset = "0x77783C0", VA = "0x1877799C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x7779BA0", Offset = "0x77785A0", VA = "0x187779BA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct IABIJBIPONM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000471")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000472")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000473")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000474")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			public PLCLOJBLHOK avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x7775290", Offset = "0x7773C90", VA = "0x187775290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x7775430", Offset = "0x7773E30", VA = "0x187775430", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct EPKEOEBBFHB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			public BKNOFPPIEOM avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400047B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x7774CE0", Offset = "0x77736E0", VA = "0x187774CE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x7774E90", Offset = "0x7773890", VA = "0x187774E90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct BCHPJOPPMEP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400047C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400047D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400047E")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400047F")]
			public PLCLOJBLHOK avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000480")]
			private TaskAwaiter<PBHMNPMKLEK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x77738D0", Offset = "0x77722D0", VA = "0x1877738D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x7773D10", Offset = "0x7772710", VA = "0x187773D10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct MKHALGFMGCP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000481")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000482")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000483")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000484")]
			public bool forceRebuild;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000485")]
			public PLCLOJBLHOK avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x7779F80", Offset = "0x7778980", VA = "0x187779F80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x777A450", Offset = "0x7778E50", VA = "0x18777A450", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		protected const float JNBHLPOGCJM = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		protected const int AABEBBKBCJJ = 5;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		protected static readonly Dictionary<KKFBIHIEIPA.LIPEPNOCILI, int> IAKPLGODMLN;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> FHJDEBBGHEO;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		protected static readonly int CJLHBICBDIH;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		protected static readonly int PEIMIKHDAOG;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		protected static readonly int NAOIKMILACG;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		protected static readonly int FKJLBHDLDPG;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		protected static readonly int NGCFJEGDLOH;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		protected static readonly int ENDEEPOMHOI;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		protected static readonly int NMGFOKBEELA;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		protected static readonly int JJOHNDDFFMO;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		protected static Vector2 BOODKOIGMMJ;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		protected static Vector2 JFFHKOIHBJO;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		protected static Vector2 HOEJODDJJGO;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		protected static Vector2 BHDKJOLJFJB;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		protected static Vector2 LJJCHGFLBBP;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected static Vector2 AOPOHEMBLFP;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected static Vector2 PLIEINILNJJ;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected static Vector2 DANAIFKCGKC;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		protected static Vector2 BFOHMMIGNCO;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected static Vector2 LGDIMBDDBHA;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		protected static Vector2 HFMKLFLOMDI;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		protected static Vector2 BCAGBLGIILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		[JNJDEHPMCEK(PLKNMOLBJIE.Self, false, false, false)]
		[SerializeField]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		[SerializeField]
		[Header("Rendering")]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		[Header("Emotes")]
		[SerializeField]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		[SerializeField]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		[Header("Modern Avatar Facial Features")]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private PLCLOJBLHOK ICPJNCFMBAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private FaceStyleSet POFOJLGPBMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected const int EGIOGALAJBK = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		protected int GFCLAFKCGPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		protected int LOJMAGDJKIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected int DPNJJNKFBLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		protected int LPFAJDJOBNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected Vector2 JBALBMMOFBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected float JFCJAKOCMIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected float BEKONAJPIFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected float CDCPHJCPDBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected Vector2 MMPLANNJKBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected float CGGBMFLJKPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected float PIHMGJDCMAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected float EMKCFNJAMHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected Vector2 OJBMKMFCGHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected float DEJIEFJAFHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected float DGIECNKIPGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected float MIEJOJAIMDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		protected Vector2 BALKFHPPEMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		protected float EGNILPKDGLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		protected float ECHBNHIKNFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected float GIJHIFCGEMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected List<SelectableFaceOption> GFKEFINOAEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		protected List<SelectableFaceOption> HIIGMBJGACC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		protected List<SelectableFaceOption> MKMPDFGDKNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected List<SelectableFaceOption> ABHNFHEPHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected Coroutine OKLCCCIJEEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		protected int? GBGAEIMLKAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		protected int BIDLKJOGBBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		protected int HGJJBAPHJNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		protected int LAKINFLALFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		protected int FIKCGKIIDEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		protected int JBKPFJPJBFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		protected int MGIOMDAEHCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected Sprite ADAANFHBEFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		protected Sprite DLGNNOIMKMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		protected Sprite KNLHOCGECEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		protected Sprite GNBBJDGMODB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		protected bool DFIOOJIPAFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		protected string PKMLLIBGKHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		protected string KOCAFBEJOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		protected string DNJICGBBCAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		protected string MKBEHAEJCKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		protected AvatarConfiguration EJFKKICKNHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		protected PBHMNPMKLEK NEOKGKFCFKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private readonly List<Material> EMGIOICMGNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		protected FANJLCLCCCH JMNGALMBPMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		protected Dictionary<string, int> PFHLPPEHMML;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public FaceStyleSet NJCGKEJAAPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x77811F0", Offset = "0x777FBF0", VA = "0x1877811F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public bool NDDOGAFPPEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0xA6BC20", Offset = "0xA6A620", VA = "0x180A6BC20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x2515510", Offset = "0x2513F10", VA = "0x182515510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		protected virtual bool MDHJNHPOCPG
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		protected virtual bool DIOPPCFJPBF
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		protected int FCGMNFBCDIC
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x777B4D0", Offset = "0x7779ED0", VA = "0x18777B4D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Renderer AELEGGPHKJA
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x9AED50", Offset = "0x9AD750", VA = "0x1809AED50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool BKEPMOPCLKP
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0xA6E460", Offset = "0xA6CE60", VA = "0x180A6E460")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x77814A0", Offset = "0x777FEA0", VA = "0x1877814A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public Renderer[] BMBMFFDLAFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x9AF000", Offset = "0x9ADA00", VA = "0x1809AF000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public bool OGKFGIFDHFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x7781240", Offset = "0x777FC40", VA = "0x187781240")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x7781400", Offset = "0x777FE00", VA = "0x187781400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		protected int CPKLMEEHAMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x777E1D0", Offset = "0x777CBD0", VA = "0x18777E1D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		protected int DFNNHCFKHGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x777E8F0", Offset = "0x777D2F0", VA = "0x18777E8F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public float BBEDJHHEBAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x7781220", Offset = "0x777FC20", VA = "0x187781220")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x77813E0", Offset = "0x777FDE0", VA = "0x1877813E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public IDADBLCKEOP HIDGGAJOIEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0xA42FA0", Offset = "0xA419A0", VA = "0x180A42FA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xA535B0", Offset = "0xA51FB0", VA = "0x180A535B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public PBHMNPMKLEK IJIMKNBABBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0xA4DF30", Offset = "0xA4C930", VA = "0x180A4DF30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x7781360", Offset = "0x777FD60", VA = "0x187781360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public NoseFaceOption GKMBHODDKHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0xA36460", Offset = "0xA34E60", VA = "0x180A36460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0xAD13D0", Offset = "0xACFDD0", VA = "0x180AD13D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		protected FANJLCLCCCH MPGEIBMNJOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x777E4E0", Offset = "0x777CEE0", VA = "0x18777E4E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action CGONBCDDCMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x7781140", Offset = "0x777FB40", VA = "0x187781140")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x77812B0", Offset = "0x777FCB0", VA = "0x1877812B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x777DF10", Offset = "0x777C910", VA = "0x18777DF10")]
		public void LocalPlayEmote(KKFBIHIEIPA.LIPEPNOCILI FLPLIDKAOOF, float AKJAGOOLFIC = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x777D1C0", Offset = "0x777BBC0", VA = "0x18777D1C0")]
		public bool IsEmotePlaying(KKFBIHIEIPA.LIPEPNOCILI FLPLIDKAOOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x777F140", Offset = "0x777DB40", VA = "0x18777F140")]
		public void SetIdleHappy(bool NGLAHAKHGGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x777B190", Offset = "0x7779B90", VA = "0x18777B190")]
		protected void BIDFONDIABJ(bool APPKOFEOBFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x777E070", Offset = "0x777CA70", VA = "0x18777E070")]
		protected void NHFEEIKDFKC(bool PALKCPJMHIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x777E000", Offset = "0x777CA00", VA = "0x18777E000")]
		protected void MEJKJILPEGI(NMDLGPPCNIO NLOPOEHCFJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x777C890", Offset = "0x777B290", VA = "0x18777C890")]
		protected void FDBCPHFKHPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x777E950", Offset = "0x777D350", VA = "0x18777E950")]
		public void PlayExpression(int LEIBMBIKCOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x777C900", Offset = "0x777B300", VA = "0x18777C900")]
		protected void FLECBDAIHIC(bool NEMEBHBMJEN, bool NFHHIBHMMOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x777CB80", Offset = "0x777B580", VA = "0x18777CB80")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType DNDEIPMBIKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x777CCB0", Offset = "0x777B6B0", VA = "0x18777CCB0")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration EJFKKICKNHL, PLCLOJBLHOK IMLEEPAJBLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x777F050", Offset = "0x777DA50", VA = "0x18777F050")]
		[AsyncStateMachine(typeof(OBFGJCBIMIB))]
		public Task SetFaceSettings(BKNOFPPIEOM NHBLKJOHPMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x777EF20", Offset = "0x777D920", VA = "0x18777EF20")]
		[AsyncStateMachine(typeof(LCFKNPAHPCC))]
		public Task SetFaceSettings(int EGJECNKKPAD, int IAMOGINCOAM, int OFOPIKBCLDK, int DGJFDDGNOHB, PLCLOJBLHOK IMLEEPAJBLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x777F1C0", Offset = "0x777DBC0", VA = "0x18777F1C0")]
		[AsyncStateMachine(typeof(IABIJBIPONM))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType DNDEIPMBIKI, int CNGFPFDDBCC, PLCLOJBLHOK IMLEEPAJBLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x777E560", Offset = "0x777CF60", VA = "0x18777E560")]
		protected void ONMPPDNPBKB(FaceFeatureType DNDEIPMBIKI, FLDKPNGONNC NLDCKDBKJNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x777B600", Offset = "0x777A000", VA = "0x18777B600")]
		protected void EEMGFGOBODB(FaceFeatureType DNDEIPMBIKI, int CNGFPFDDBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x777C9B0", Offset = "0x777B3B0", VA = "0x18777C9B0")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x777CBC0", Offset = "0x777B5C0", VA = "0x18777CBC0")]
		[AsyncStateMachine(typeof(EPKEOEBBFHB))]
		protected Task IOOAJJACOHL(BKNOFPPIEOM NHBLKJOHPMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x777C590", Offset = "0x777AF90", VA = "0x18777C590")]
		protected void FADEGJACOIP(BKNOFPPIEOM NHBLKJOHPMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x777DD80", Offset = "0x777C780", VA = "0x18777DD80")]
		protected static void LGGFMKCOMJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x777D2D0", Offset = "0x777BCD0", VA = "0x18777D2D0")]
		private void JEEEHEMEBHB(bool DACLDHJJKFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x777D9F0", Offset = "0x777C3F0", VA = "0x18777D9F0")]
		protected void LCDKPGHLCFF(FaceFeatureType DNDEIPMBIKI, Vector2 APEAKJLPDIC, PLCLOJBLHOK IMLEEPAJBLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x777E970", Offset = "0x777D370", VA = "0x18777E970")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType DNDEIPMBIKI, Vector2 PMMGKFNOAPK, PLCLOJBLHOK IMLEEPAJBLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x777D6B0", Offset = "0x777C0B0", VA = "0x18777D6B0")]
		protected void JPDGGEAGJED(FaceFeatureType DNDEIPMBIKI, float OHNCEDHMBEG, PLCLOJBLHOK IMLEEPAJBLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x777D530", Offset = "0x777BF30", VA = "0x18777D530")]
		protected void JKGIMHALJMO(FaceFeatureType DNDEIPMBIKI, float KONJHPLFEME, PLCLOJBLHOK IMLEEPAJBLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x777B400", Offset = "0x7779E00", VA = "0x18777B400")]
		protected void CDEDJCFJLKG(FaceFeatureType DNDEIPMBIKI, float ALGCMLLEGBF, PLCLOJBLHOK IMLEEPAJBLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x777ED00", Offset = "0x777D700", VA = "0x18777ED00")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType DNDEIPMBIKI, float NMBFPHLICIC, PLCLOJBLHOK IMLEEPAJBLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x777D910", Offset = "0x777C310", VA = "0x18777D910")]
		[AsyncStateMachine(typeof(BCHPJOPPMEP))]
		protected Task LACODNMODMJ(PLCLOJBLHOK IMLEEPAJBLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x777CFB0", Offset = "0x777B9B0", VA = "0x18777CFB0")]
		public void InitializeFaceFeatureStyleSet(PLCLOJBLHOK IMLEEPAJBLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x777D830", Offset = "0x777C230", VA = "0x18777D830")]
		protected bool KEKOCNMEJJB(string KOLDHMIHOIE, [Out] int DOAKEFBOPIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x777B050", Offset = "0x7779A50", VA = "0x18777B050")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x155DEF0", Offset = "0x155C8F0", VA = "0x18155DEF0", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x777E6E0", Offset = "0x777D0E0", VA = "0x18777E6E0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x77802E0", Offset = "0x777ECE0", VA = "0x1877802E0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x777B300", Offset = "0x7779D00", VA = "0x18777B300")]
		[AsyncStateMachine(typeof(MKHALGFMGCP))]
		public Task BuildFaceStyleAsyncIfChanged(PLCLOJBLHOK IMLEEPAJBLH, bool DLIHBBBBNGA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x777FC00", Offset = "0x777E600", VA = "0x18777FC00")]
		public void UpdateFaceDisplays(bool MHFHIGONFGE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x777BD40", Offset = "0x777A740", VA = "0x18777BD40")]
		protected bool EFAGGHOHALG(bool MHFHIGONFGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x777F920", Offset = "0x777E320", VA = "0x18777F920")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x777F2D0", Offset = "0x777DCD0", VA = "0x18777F2D0")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x777FE10", Offset = "0x777E810", VA = "0x18777FE10")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7780000", Offset = "0x777EA00", VA = "0x187780000")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x777B210", Offset = "0x7779C10", VA = "0x18777B210")]
		protected void BMMENEMEPKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x777E230", Offset = "0x777CC30", VA = "0x18777E230")]
		private void OEEBJPPLKMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7780EF0", Offset = "0x777F8F0", VA = "0x187780EF0")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x9DAAE0", Offset = "0x9D94E0", VA = "0x1809DAAE0", Slot = "4")]
		private bool PGJKCKIKBII()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct FFABGGHMDAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public string HFKDIDMKBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public int FIGDAIADJGM;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[SelectionBase]
	[ExecuteInEditMode]
	public class PlayerModernBodyEditorAvatarValidator : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private struct DMJIACKCPAH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004EA")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004EB")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004EC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x7774AE0", Offset = "0x77734E0", VA = "0x187774AE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x9F9A10", Offset = "0x9F8410", VA = "0x1809F9A10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private struct JHABAKCDKJA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004ED")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004EE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x7779140", Offset = "0x7777B40", VA = "0x187779140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x7779630", Offset = "0x7778030", VA = "0x187779630", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public PLCLOJBLHOK avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public DBGJIPOCKFK useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public CMIMFAFIAGN hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public DNNONBHLEHK HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public long baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		[SerializeField]
		[JNJDEHPMCEK(PLKNMOLBJIE.Self, false, false, false)]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private NCFMNGEGECJ OKLAALBAENO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		[SerializeField]
		[JNJDEHPMCEK(PLKNMOLBJIE.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private AnimatorOverrideController JGECOKHEIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> NLLCFINFIOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public readonly FFABGGHMDAE[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public readonly (string, GOLGFCHBNKP)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		protected bool ALAMEHOPMFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		protected Guid MFNPKIGIFFM;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		protected static Guid DHHALPBDNBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private OLDJDAKOFEE BIJJENIMIPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private IDADBLCKEOP GGIBKCDEIIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private ELDIGJNJHMI OEBFHNOIKLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private ELDIGJNJHMI LGEOGJPNFGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private AdditionalHatData KAADJDIOFAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private readonly Dictionary<GameObject, CFMJKIIMPGC> MAMELEMFJBE;

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public static Func<HAPJNADPHGJ> OHDDEDGLGMI
		{
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x7786440", Offset = "0x7784E40", VA = "0x187786440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x7786A80", Offset = "0x7785480", VA = "0x187786A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool GDOKACJNEFC
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x77865A0", Offset = "0x7784FA0", VA = "0x1877865A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool CANKPFNEKOP
		{
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x7786490", Offset = "0x7784E90", VA = "0x187786490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public PlayerAvatarDisplayBase LMLCFNKIMND
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0xA3AFC0", Offset = "0xA399C0", VA = "0x180A3AFC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		protected static Guid MLICCKFAKFI
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x7783BA0", Offset = "0x77825A0", VA = "0x187783BA0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public (GameObject, NMDLGPPCNIO)[] FDFKIIIMBAB
		{
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x77866B0", Offset = "0x77850B0", VA = "0x1877866B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x77841C0", Offset = "0x7782BC0", VA = "0x1877841C0")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x7783730", Offset = "0x7782130", VA = "0x187783730")]
		private IEnumerable<GameObject> OEMKPLCDAGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x77846B0", Offset = "0x77830B0", VA = "0x1877846B0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x7783390", Offset = "0x7781D90", VA = "0x187783390")]
		private void LOBANNMJEFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x11B58F0", Offset = "0x11B42F0", VA = "0x1811B58F0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x77825F0", Offset = "0x7780FF0", VA = "0x1877825F0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x77846C0", Offset = "0x77830C0", VA = "0x1877846C0")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x77844B0", Offset = "0x7782EB0", VA = "0x1877844B0")]
		public void ShowPose(AnimationClip MJNNDJHADIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x7784680", Offset = "0x7783080", VA = "0x187784680")]
		public void ShowPose(string IAEMKMNOKHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7784310", Offset = "0x7782D10", VA = "0x187784310")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x77841D0", Offset = "0x7782BD0", VA = "0x1877841D0")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7785190", Offset = "0x7783B90", VA = "0x187785190")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7784FE0", Offset = "0x77839E0", VA = "0x187784FE0")]
		public void UpdateFaceAndBodyShapes(bool DLIHBBBBNGA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x7785590", Offset = "0x7783F90", VA = "0x187785590")]
		public void UpdateNoseShape(FPNKNMOGAJG JJLPPEFFCLP, bool DLIHBBBBNGA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x7785560", Offset = "0x7783F60", VA = "0x187785560")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7782230", Offset = "0x7780C30", VA = "0x187782230", Slot = "4")]
		protected virtual void ECEAPEDHIDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7782CF0", Offset = "0x77816F0", VA = "0x187782CF0", Slot = "5")]
		protected virtual void JDKDDBGABII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x77817B0", Offset = "0x77801B0", VA = "0x1877817B0")]
		public void ApplyHatData(AdditionalHatData OAGEPLALJDB, bool GBAFHGIAGLJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x77815F0", Offset = "0x777FFF0", VA = "0x1877815F0")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7781B10", Offset = "0x7780510", VA = "0x187781B10")]
		public void ApplyHatUVOverride(Vector2 KPMIKMCCDHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7781A30", Offset = "0x7780430", VA = "0x187781A30")]
		public void ApplyHatPositionAdjustment(Vector3 PBMPAGONAEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7781AA0", Offset = "0x77804A0", VA = "0x187781AA0")]
		public void ApplyHatRotationAdjustment(Vector3 PFKCKEKGPOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x7781B80", Offset = "0x7780580", VA = "0x187781B80")]
		public DCNPOBHCDAG BuildAvatarItemSelection(GameObject NLAFELOBOJO, PLCLOJBLHOK JJHAMINNBAP, NMDLGPPCNIO CPKHDNICNAL)
		{
			return default(DCNPOBHCDAG);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7781C20", Offset = "0x7780620", VA = "0x187781C20")]
		public void BuildAvatar(bool DLIHBBBBNGA = false, bool GBAFHGIAGLJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7784A20", Offset = "0x7783420", VA = "0x187784A20")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x7781730", Offset = "0x7780130", VA = "0x187781730")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x77853B0", Offset = "0x7783DB0", VA = "0x1877853B0")]
		public void UpdateHatAnchor(bool GBAFHGIAGLJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x77850E0", Offset = "0x7783AE0", VA = "0x1877850E0")]
		[AsyncStateMachine(typeof(DMJIACKCPAH))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x77832C0", Offset = "0x7781CC0", VA = "0x1877832C0")]
		[AsyncStateMachine(typeof(JHABAKCDKJA))]
		private Task KNGIOLELKJA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x7783470", Offset = "0x7781E70", VA = "0x187783470")]
		private void MJGJEFJAICP(FaceFeatureType PIMBKPEKOPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7781560", Offset = "0x777FF60", VA = "0x187781560")]
		private void AOHKPPJCMJJ(FaceFeatureType PIMBKPEKOPK, [Out] float FBIGCOPGCGC, [Out] float PGBCDNONNEG, [Out] float GFDDEGDNEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7784EA0", Offset = "0x77838A0", VA = "0x187784EA0")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7785240", Offset = "0x7783C40", VA = "0x187785240")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x7783C90", Offset = "0x7782690", VA = "0x187783C90")]
		private void PCKMDBOIICO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
		private void MHLIJMNJCJG(CFMJKIIMPGC LHECNOAGAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
		private void HBDLNLDHNGD(CFMJKIIMPGC LHECNOAGAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x7782F60", Offset = "0x7781960", VA = "0x187782F60")]
		private void JIIJBLMLNON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7785610", Offset = "0x7784010", VA = "0x187785610")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x7782540", Offset = "0x7780F40", VA = "0x187782540")]
		[CompilerGenerated]
		private DCNPOBHCDAG FAJJEACPJFD((GameObject, NMDLGPPCNIO) CHOBKIAOCDK)
		{
			return default(DCNPOBHCDAG);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		[SerializeField]
		[JNJDEHPMCEK(PLKNMOLBJIE.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x9AE050", Offset = "0x9ACA50", VA = "0x1809AE050")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct DCNPOBHCDAG
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class JPDANOMCLOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public JPDANOMCLOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x7779940", Offset = "0x7778340", VA = "0x187779940")]
		internal bool PKFIBKDKEML(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	private CFMJKIIMPGC PLHKHGFMDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private NMDLGPPCNIO FGELECMPJJG;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public CFMJKIIMPGC MKLAHADMPAA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public NMDLGPPCNIO GMMNKBFENHM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA40", Offset = "0xC9A440", VA = "0x180C9BA40")]
		get
		{
			return default(NMDLGPPCNIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public string LDLNJPFGEGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x7774610", Offset = "0x7773010", VA = "0x187774610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool DHPCDCHKMAP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x77748F0", Offset = "0x77732F0", VA = "0x1877748F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool DOLMOLMHMNH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7774940", Offset = "0x7773340", VA = "0x187774940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x16D9FD0", Offset = "0x16D89D0", VA = "0x1816D9FD0")]
	public DCNPOBHCDAG(CFMJKIIMPGC LHECNOAGAEF, NMDLGPPCNIO NLOPOEHCFJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x77742F0", Offset = "0x7772CF0", VA = "0x1877742F0")]
	public bool BEFNPLKGKKA(OutfitType BBCOOFGAEHN, NMDLGPPCNIO DAIDELGOLOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x77743B0", Offset = "0x7772DB0", VA = "0x1877743B0")]
	public bool EAKANENNOOB(OutfitType BBCOOFGAEHN, NMDLGPPCNIO DAIDELGOLOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x7774700", Offset = "0x7773100", VA = "0x187774700")]
	public bool EMKJPOHCDAA(DCNPOBHCDAG JCOFCHINGOL)
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
