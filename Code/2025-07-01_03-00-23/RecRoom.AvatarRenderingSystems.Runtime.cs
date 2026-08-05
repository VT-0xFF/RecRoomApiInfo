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
	public class LogRegistrationIndex : CFJIINPOLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6AE0", Offset = "0x7DE50E0", VA = "0x187DE6AE0", Slot = "4")]
		public override void CCHHFLKMKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
			[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7DE71E0", Offset = "0x7DE57E0", VA = "0x187DE71E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DE7170", Offset = "0x7DE5770", VA = "0x187DE7170", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7DE71A0", Offset = "0x7DE57A0", VA = "0x187DE71A0")]
		public RecNetCDNAssetReference(RecNetCDNKey BLIBAMJKLIA)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum DAANMPAKIKD : byte
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
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA73440", Offset = "0xA71A40", VA = "0x180A73440")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA73260", Offset = "0xA71860", VA = "0x180A73260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public DAANMPAKIKD PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xE83260", Offset = "0xE81860", VA = "0x180E83260")]
			[CompilerGenerated]
			get
			{
				return default(DAANMPAKIKD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x149D1F0", Offset = "0x149B7F0", VA = "0x18149D1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7DE72F0", Offset = "0x7DE58F0", VA = "0x187DE72F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7DE7270", Offset = "0x7DE5870", VA = "0x187DE7270")]
		public static RecNetCDNKey GKCEDGJOHIL(string LMFHAJJEEIA, DAANMPAKIKD AHODAICGFIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7DE7220", Offset = "0x7DE5820", VA = "0x187DE7220")]
		public void CBLONDDNPNL(string CLCOFNJCJFB, string GOFLPLJKKOO, bool HNAMDNOAOJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HIAEMPMDAHB]
public class CJPLPEOHODM : ODCEOPCNFJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<Mesh> MLLLBKCFJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<byte[]> HFPCLDPHLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<Matrix4x4> MDIHLJDDNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly List<bool> FCGKIADLJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly List<long> OLLCPLNFKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly List<bool> MAINKNOCLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected readonly List<int> ANNBPBOMBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected Allocator MHHKEHHKHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected DBKKBPDPDDG JFEJPINNENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected byte KLJGBKAGPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected IList<int> OIEFJLPMDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected IList<int> HJILMPLNOBD;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5290", Offset = "0x7DD3890", VA = "0x187DD5290", Slot = "4")]
	public void IFODEOFHJDD(Mesh IDMOPPBKAAO, Matrix4x4 JBMNNBAGILM, byte[] JCEJGEIDOLJ, bool MIOJLNCIGOJ = false, OBJIGDJGKHB.MAHMKAHBAAB LFAFPBBBNFF = (OBJIGDJGKHB.MAHMKAHBAAB)0L, int KAIAGOOEGHC = -1, bool BIPJPIFPAGD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5250", Offset = "0x7DD3850", VA = "0x187DD5250", Slot = "5")]
	public void FBOMCPAFPOD(Allocator HOHBLCPFIEJ, DBKKBPDPDDG KOIHPOECKLP, byte GHFDMOIKCAP, [Optional] IList<int> EEBINPNGNPM, [Optional] IList<int> MPCBKHJFDGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7DD55C0", Offset = "0x7DD3BC0", VA = "0x187DD55C0")]
	private static void LHJBDGEBICL(Mesh IDMOPPBKAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5820", Offset = "0x7DD3E20", VA = "0x187DD5820")]
	public CJPLPEOHODM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[HIAEMPMDAHB]
public struct JJOABJPBFBM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public FMEKEOBBCPC JBFDDMGIGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public int FCNAAMJIPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public CBKILJMMAFI AKPENHFLCAK;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7DE4D50", Offset = "0x7DE3350", VA = "0x187DE4D50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[HIAEMPMDAHB]
[NativeContainer]
public struct CBKILJMMAFI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct NKKOMOKKEIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector3 DJAGCBKIGBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector3 IFDADDNBHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector4 FABHMFNHHAA;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct DMMLHGJBMGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float EAEKMCIDICF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float IBEJHFIFBEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float OLAPJBJPIKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float BOFJGHAMEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte IABCDANEAAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public byte IONCHOHDBMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public byte IACPCHHMKJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte KPLHHBILJKF;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct DNPAAHKCFFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half EAEKMCIDICF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half IBEJHFIFBEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half OLAPJBJPIKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half BOFJGHAMEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public byte IABCDANEAAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte IONCHOHDBMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public byte IACPCHHMKJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public byte KPLHHBILJKF;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct LKHLGHNOLKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 HFIMNHFKOFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 JDLMPMLOECI;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct FLJAJGCLLJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half4 HFIMNHFKOFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 JDLMPMLOECI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 DBACOHELOBO;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct HKEONJCIDDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half4 HFIMNHFKOFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 JDLMPMLOECI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 DBACOHELOBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 CPIKBLCKDPG;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct JHNKBDFCMJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half4 HFIMNHFKOFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public half2 JDLMPMLOECI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public half2 DBACOHELOBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public half2 CPIKBLCKDPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public half2 MMEOMLFJHAO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct JGLLEMEPBEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float EAEKMCIDICF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float IBEJHFIFBEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float OLAPJBJPIKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float BOFJGHAMEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int IABCDANEAAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int IONCHOHDBMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int IACPCHHMKJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int KPLHHBILJKF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct LGIDKDJCPMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color HFIMNHFKOFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 JDLMPMLOECI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct MDBEIDGNBOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Color HFIMNHFKOFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 JDLMPMLOECI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Vector2 DBACOHELOBO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct AMGDOIPFLCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Color HFIMNHFKOFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 JDLMPMLOECI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 DBACOHELOBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 CPIKBLCKDPG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct OPDNCOJAIIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Color HFIMNHFKOFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector2 JDLMPMLOECI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Vector2 DBACOHELOBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Vector2 CPIKBLCKDPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Vector2 MMEOMLFJHAO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool FBHJHLJMBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<NKKOMOKKEIH> FDOLAKOPPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<LKHLGHNOLKG> NPFDAFJBIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<FLJAJGCLLJF> LBFKNFMMIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<HKEONJCIDDH> PALAABHOBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<JHNKBDFCMJG> CNGDPPMAAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<DNPAAHKCFFP> CFHAOPIBOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<DMMLHGJBMGH> KPMPOJLGKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<LGIDKDJCPMI> EJDBHFHKBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<MDBEIDGNBOP> JMCCDEPBHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<AMGDOIPFLCI> MPHPAKJFKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<OPDNCOJAIIA> NFMOJFKOFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<JGLLEMEPBEI> NKDMLAOKCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> HJGCOFLHDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> JPCHEOGJMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> MJFHIPINCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> MEBMHBOMFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> DHKNFENLGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> OHFKMHMHPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<int> AIHJOJMNKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<BoneWeight> LKFAHJBECAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> MJNKOFMOBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool OAEEOAAEEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool FBIHAAGDJHM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int OOBGHEGAHOL
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7DD2850", Offset = "0x7DD0E50", VA = "0x187DD2850")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7DD3AB0", Offset = "0x7DD20B0", VA = "0x187DD3AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int PDIPGLKLALB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7DD3AC0", Offset = "0x7DD20C0", VA = "0x187DD3AC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7DD25E0", Offset = "0x7DD0BE0", VA = "0x187DD25E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int AHBICFCOBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7DD25D0", Offset = "0x7DD0BD0", VA = "0x187DD25D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7DD3FE0", Offset = "0x7DD25E0", VA = "0x187DD3FE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int FMPAJKJCJAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7DD3B60", Offset = "0x7DD2160", VA = "0x187DD3B60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4820", Offset = "0x7DD2E20", VA = "0x187DD4820")]
	public CBKILJMMAFI(int GCDMNDHKDOP, int JCPGDIJDFBG, int PDPFMONBLLB, int PLOBGDAIJBP, Allocator HOHBLCPFIEJ, int AMHGPLBOJIG, GKELMIEKFBK LPMKPDCJEDM, bool OAEEOAAEEJL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7DD3AD0", Offset = "0x7DD20D0", VA = "0x187DD3AD0")]
	public void NGBPMAKMLCI(int KHMHPNKMLMD, Vector3 JIJNMCDLDDE, Vector3 LFBNNGIKBPK, Vector4 MMMCFFENLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4320", Offset = "0x7DD2920", VA = "0x187DD4320")]
	public void PGDMCFIJIPH(int KHMHPNKMLMD, BoneWeight BMMHGKLFGIJ, NativeSlice<byte> JCEJGEIDOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7DD3FF0", Offset = "0x7DD25F0", VA = "0x187DD3FF0")]
	public Color PDBGGJHLDLP(int KHMHPNKMLMD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7DD3BD0", Offset = "0x7DD21D0", VA = "0x187DD3BD0")]
	public void OAAEHJMNHKO(int KHMHPNKMLMD, Color HJGAGGHDFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7DD3700", Offset = "0x7DD1D00", VA = "0x187DD3700")]
	public void GKNKDDGLJIM(byte GCMGKDPLJIA, int KHMHPNKMLMD, Vector2 BHMKKJJPDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7DD3FD0", Offset = "0x7DD25D0", VA = "0x187DD3FD0")]
	public void OFEMFKLCDBO(int KHMHPNKMLMD, int LCILPJDNKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7DD2570", Offset = "0x7DD0B70", VA = "0x187DD2570")]
	public bool AFKGHDHPCKD(int GCMGKDPLJIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4750", Offset = "0x7DD2D50", VA = "0x187DD4750")]
	public void PKMOILCCJLM(int HHPNHBHGKHG, int MOBKDJHFHDL, int PHABMFMJBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD25F0", Offset = "0x7DD0BF0", VA = "0x187DD25F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD2860", Offset = "0x7DD0E60", VA = "0x187DD2860")]
	public Mesh FLIPONBNLBB([Optional] string OLHFNNEBAIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[NativeContainer]
[HIAEMPMDAHB]
public struct FMEKEOBBCPC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Mesh.MeshDataArray FFFEEELEDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeArray<int> HGFKACEGCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeArray<int> AMNMJDNKLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeArray<BoneWeight> LKFAHJBECAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeArray<Matrix4x4> NHCAHDOGLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeArray<long> ENALLKELHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeArray<byte> CGCBIBONNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<int> OKBKEAFLNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<int> HFMOEKIAPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<sbyte> MPAKKCJFMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeArray<byte> PBHFBEGHMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<bool> BIPJPIFPAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<int> KAIAGOOEGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool OAEEOAAEEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<int> OPBMLJMGKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private bool FBIHAAGDJHM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int AMMKGGIAOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7DE36E0", Offset = "0x7DE1CE0", VA = "0x187DE36E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int BJFHCJDHOCP
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7DE37F0", Offset = "0x7DE1DF0", VA = "0x187DE37F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int BJOPEHFBBPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3800", Offset = "0x7DE1E00", VA = "0x187DE3800")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int PCEEFBNNBOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3B70", Offset = "0x7DE2170", VA = "0x187DE3B70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3550", Offset = "0x7DE1B50", VA = "0x187DE3550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int OOBGHEGAHOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3710", Offset = "0x7DE1D10", VA = "0x187DE3710")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7DE38E0", Offset = "0x7DE1EE0", VA = "0x187DE38E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int JIPFBOKLHNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3B40", Offset = "0x7DE2140", VA = "0x187DE3B40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3700", Offset = "0x7DE1D00", VA = "0x187DE3700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public DBKKBPDPDDG KFFCNGIKOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3B60", Offset = "0x7DE2160", VA = "0x187DE3B60")]
		get
		{
			return default(DBKKBPDPDDG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3B50", Offset = "0x7DE2150", VA = "0x187DE3B50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte JAKCJLCFGLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7DE36F0", Offset = "0x7DE1CF0", VA = "0x187DE36F0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7DE38D0", Offset = "0x7DE1ED0", VA = "0x187DE38D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public OMHKIDEHLIL FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7DE38F0", Offset = "0x7DE1EF0", VA = "0x187DE38F0")]
		get
		{
			return default(OMHKIDEHLIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7DE3B80", Offset = "0x7DE2180", VA = "0x187DE3B80")]
	public FMEKEOBBCPC(IList<Mesh> NPGOLOCEDCC, IList<Matrix4x4> BEOEBBGEKBB, IList<bool> BIPJPIFPAGD, byte GHFDMOIKCAP, IList<byte[]> DCLABJMPAMJ, IList<long> IPFDLAKJDMN, IList<bool> NDBFOJCAEJB, IList<int> KAIAGOOEGHC, IList<int> EEBINPNGNPM, IList<int> EGIDICLLCPE, Allocator HOHBLCPFIEJ, DBKKBPDPDDG KOIHPOECKLP, bool OAEEOAAEEJL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7DE3720", Offset = "0x7DE1D20", VA = "0x187DE3720")]
	public CBKILJMMAFI GLPEPGGCPCC(Allocator HOHBLCPFIEJ, GKELMIEKFBK LPMKPDCJEDM)
	{
		return default(CBKILJMMAFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7DE3560", Offset = "0x7DE1B60", VA = "0x187DE3560", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[HIAEMPMDAHB]
public class KDCJIMDGBKC : CJPLPEOHODM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public bool OLEAGPJEFCL;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly ProfilerMarker GNGHBNGFOMG;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6810", Offset = "0x7DE4E10", VA = "0x187DE6810")]
	public FMEKEOBBCPC NKHFPDAJBEB()
	{
		return default(FMEKEOBBCPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6AD0", Offset = "0x7DE50D0", VA = "0x187DE6AD0")]
	public KDCJIMDGBKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct OMHKIDEHLIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Mesh.MeshData OKEEKFKPKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<BoneWeight> LKFAHJBECAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NativeSlice<byte> DLEEAPMCILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int LJCBDJFGFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Matrix4x4 HCOKNJBDEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public long JBKIGDJGCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeSlice<byte> JCEJGEIDOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public bool BCKBALNJFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public int GNNFOHKNPBJ;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class EHBLLFIPHCP : ABICHDKCLFP
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class FKBABAPAOPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public bool hideTorsoInFirstPersonBeanMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public EHBLLFIPHCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public BKFKILCGELM buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Action<KeyValuePair<string, MODONOMENDG<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public FKBABAPAOPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7DE32F0", Offset = "0x7DE18F0", VA = "0x187DE32F0")]
		internal bool CHOPBGIFMHD(JOHGPLIHENP item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3420", Offset = "0x7DE1A20", VA = "0x187DE3420")]
		internal void LMLENJPGDGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3440", Offset = "0x7DE1A40", VA = "0x187DE3440")]
		internal void GCGAJOEPLAI(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3420", Offset = "0x7DE1A20", VA = "0x187DE3420")]
		internal void FLANADNKGJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3440", Offset = "0x7DE1A40", VA = "0x187DE3440")]
		internal void JFMGLIKMIHE(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3330", Offset = "0x7DE1930", VA = "0x187DE3330")]
		internal void DKEKMFAKLLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3460", Offset = "0x7DE1A60", VA = "0x187DE3460")]
		internal void HOBDHEEAHIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3490", Offset = "0x7DE1A90", VA = "0x187DE3490")]
		internal void JCHNLDKFOKO(Dictionary<string, MODONOMENDG<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3360", Offset = "0x7DE1960", VA = "0x187DE3360")]
		internal void EALBOKKFGEO(KeyValuePair<string, MODONOMENDG<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		internal NCBJFOCOMOJ GLODDCFEMCG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class NKMJNOPBFAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public FKBABAPAOPM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public NKMJNOPBFAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6FF0", Offset = "0x7DE55F0", VA = "0x187DE6FF0")]
		internal APDECCCPNEL PKPEIAHGNGO(int lod)
		{
			return default(APDECCCPNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class GINMFLBJLCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public EHBLMFNEKIG<Dictionary<string, MODONOMENDG<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public GINMFLBJLCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		internal EHBLMFNEKIG<Dictionary<string, MODONOMENDG<Texture2D>>> DMAGJGBNJKE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class BEOEDFJHOOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<BKFKILCGELM> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public BEOEDFJHOOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7DD2440", Offset = "0x7DD0A40", VA = "0x187DD2440")]
		internal void AAHBCBCAPPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class DNCGKDHBELI : IEnumerator<HPILNDONOCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private HPILNDONOCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public EHBLLFIPHCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public List<BOJECDBBNGM> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public List<BKFKILCGELM> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public Func<int, APDECCCPNEL> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public HABJFJJJEMI materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private HPILNDONOCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
		[DebuggerHidden]
		public DNCGKDHBELI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5A70", Offset = "0x7DD4070", VA = "0x187DD5A70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5CF0", Offset = "0x7DD42F0", VA = "0x187DD5CF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class JGGNNEFEAMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public NILILCPOKMK cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public JGGNNEFEAMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xB37D20", Offset = "0xB36320", VA = "0x180B37D20")]
		internal void NBFGHDADCJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xDBE840", Offset = "0xDBCE40", VA = "0x180DBE840")]
		internal void HHOKIECABFA(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MCMBJOMNFPC
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
		public EHBLLFIPHCP <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public MCMBJOMNFPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class MCOPECEONOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public CBKILJMMAFI defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public FMEKEOBBCPC defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public MCMBJOMNFPC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public MCOPECEONOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6B70", Offset = "0x7DE5170", VA = "0x187DE6B70")]
		internal void JMLFLKDACEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x13FF600", Offset = "0x13FDC00", VA = "0x1813FF600")]
		internal void ECEHCAKAJKB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class MLPLHADDJHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public MBLOHONIDFP legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public FOOIFNEFHIA legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public MCMBJOMNFPC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public MLPLHADDJHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6DB0", Offset = "0x7DE53B0", VA = "0x187DE6DB0")]
		internal void EAOMFLDBNKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x1402E90", Offset = "0x1401490", VA = "0x181402E90")]
		internal void AFGMAONAAGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OLLDAFEPOPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public EHBLLFIPHCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public float power;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public Color color;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public OLLDAFEPOPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7DE7130", Offset = "0x7DE5730", VA = "0x187DE7130")]
		internal void BGJHFDJJPDG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class OFFFHEOKGBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public JBDCJHGBANL overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public OFFFHEOKGBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7DE70B0", Offset = "0x7DE56B0", VA = "0x187DE70B0")]
		internal bool FLPKGKHGEKI(KeyValuePair<string, JOHGPLIHENP> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly LGEBFGGIOJB IDMFIAECEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly LGEBFGGIOJB APDPIPIMPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Dictionary<BDCHMIEGBGF, float> MIHMGECHJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<CLEOPONOOKA, float> IKGJNOHLEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<DCJBFDFOONI, float> NEKIFNKIIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private IReadOnlyDictionary<string, NIHMJHENINA> JMIEDKCBAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Dictionary<string, NIHMJHENINA> AIABGNGNGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Dictionary<string, NIHMJHENINA> ALENFKLFPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Dictionary<string, NIHMJHENINA> GFKDKDHHEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private CEKFBKJJEMI HAENGPAMPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private CEKFBKJJEMI MOLOICCMCPB;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static float GGFKMPCLNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool? MJOFMCKIPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool? PPHNMCMJLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool? CHBMEAFDBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool? LAJPNHNNGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private AvatarConfiguration JPIHBEEHOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Transform FKMIPGNCHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private AvatarSkinAssetItem FJCPIMKJHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private AssetReference NCBPPKDNKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private GameObject GDGKHNLOENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private GameObject EFDIONPAMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private SkinnedMeshRenderer MOHHOEAGOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private AvatarSkinnedMeshBoneOrderRemapsData CEKFNNBKEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Transform[] OLKCNMEFOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Matrix4x4[] JLNNNIDKLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Material JDCAJAEAALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Material EEJKFDMOHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Material ADEDHFNMMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Material CBHONGOJJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Shader BCDOAELMKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Shader NFHDMPMDNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Animator ALFKKKFHJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Renderer[] LGIIDFMJEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private OBJIGDJGKHB.MAHMKAHBAAB GJIPEAHBENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private AvatarBodyPartShapesManager GNGIEKLNCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private IReadOnlyDictionary<string, Transform> MFOBCAGCDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private AvatarFaceShapeData.DLJBAPLFPPD JLHCIKNIGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private AvatarBodyShapeData.PFEKAGKIGOB BBFBMFFNBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private DPMPLKEDIBP MKDEAIEEKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool DKHDPOBABIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11D")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool AJLCAMLDCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Color BMCEFFFBBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Color KKHFAAFNEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Color AGGDGIJELNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Color? APDNDBEDGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Color? GGECEMJBNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private Color? MIEKEADGPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private Color? HCIJFOKHHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Texture2D BIBMOIFEFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Texture2D JNHBIJNNMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[CanBeNull]
	private JOHGPLIHENP IKKJLPPJBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Texture ECIFCMHFBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Color JCNENLADPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public Dictionary<Renderer, HABJFJJJEMI> GDJEGEIPNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Dictionary<Renderer, HABJFJJJEMI> EBLMGAFHLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Dictionary<string, List<NHLPJGDAGJN>> OKFJFCJBJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private Dictionary<string, List<NHLPJGDAGJN>> NDPKENBEKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly List<DKAHIDLCKHM> NJJBKLNCJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly List<DKAHIDLCKHM> BHDELGBMBEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly List<DKAHIDLCKHM> AAIAMMNPNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly List<DKAHIDLCKHM> GLNGGLEDDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Dictionary<NHLPJGDAGJN, Material> CNHJEGPAHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Dictionary<NHLPJGDAGJN, Material> EIMDDCGEHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private SkinnedMeshRenderer[] FOEODAPKBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private SkinnedMeshRenderer[] LHEPDBEPFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private SkinnedMeshRenderer[] ODMEOAMKMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private SkinnedMeshRenderer[] FDIAHFNOKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Dictionary<string, MODONOMENDG<Texture2D>> IJLGOEENMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Dictionary<string, MODONOMENDG<Texture2D>> CJDOEFNALNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private AdditionalHatData AMOEHIFFJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private AdditionalHatData JEDLHJHLAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private HairData HKFPGLNADOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private HairData PNDAIAJBMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private AFNDLFBCDPE KFCADNABPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool? DEPBFDBLMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private PositionAndRotation JGLBMHOHGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private Transform BEAHOLDCEHO;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private Material OPNAKJLFHKF;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Material PMOLELNEJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private Dictionary<string, JOHGPLIHENP> BGHIBJNDKPC;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int DIMDOIGLNIE;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int EKAJLFDJPNC;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int FLLBDAANNLD;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int GLDFMLFJCOE;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int LGBOGHEFGEI;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int BAFLONGDDAO;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly int POPDHDMHIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool GCHGBMAINOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private List<Action> FLOLKMEBOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private FDMHDGANLHD KCGCAKGDEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private SkinnedMeshRenderer[] BBIPGBIKJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private int LGIIPACGKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private bool MGFIPKKJMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private int IHGBFECCOCK;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public LGEBFGGIOJB CFJOAGIPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public LGEBFGGIOJB EKJHFPKCENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private MFFKJDDAJBP HINKJLIAKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7DDEA40", Offset = "0x7DDD040", VA = "0x187DDEA40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool PEDPNALJDIF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7DDF630", Offset = "0x7DDDC30", VA = "0x187DDF630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool FJIEJMNCMIK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7DD7420", Offset = "0x7DD5A20", VA = "0x187DD7420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool MAAHAGCIFCG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7DD7340", Offset = "0x7DD5940", VA = "0x187DD7340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool ODPMKIJIONJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7DDF550", Offset = "0x7DDDB50", VA = "0x187DDF550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public AvatarConfiguration FONOMDDMIJB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA449A0", Offset = "0xA42FA0", VA = "0x180A449A0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool HFDNHOBLHBC
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x12B4B80", Offset = "0x12B3180", VA = "0x1812B4B80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x12B3720", Offset = "0x12B1D20", VA = "0x1812B3720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Material KCPKDLACODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7DD8FC0", Offset = "0x7DD75C0", VA = "0x187DD8FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Material NLCNIGAFCHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7DD6C10", Offset = "0x7DD5210", VA = "0x187DD6C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool KPMAPIHLPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public IJIIPECBIPC EDLPPLCPCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2450790", Offset = "0x244ED90", VA = "0x182450790", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(IJIIPECBIPC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7DDFBE0", Offset = "0x7DDE1E0", VA = "0x187DDFBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Material LICGJBPKNLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xAD80D0", Offset = "0xAD66D0", VA = "0x180AD80D0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public SkinnedMeshRenderer[] JJBGGAOHFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1AABB90", Offset = "0x1AAA190", VA = "0x181AABB90", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Renderer[] NCIMHJCAEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xB66EA0", Offset = "0xB654A0", VA = "0x180B66EA0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool DDIKBBGAPJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7DE1FD0", Offset = "0x7DE05D0", VA = "0x187DE1FD0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public OBJIGDJGKHB.MAHMKAHBAAB HLHGIKAHLMH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xAD3200", Offset = "0xAD1800", VA = "0x180AD3200", Slot = "20")]
		get
		{
			return default(OBJIGDJGKHB.MAHMKAHBAAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int BLHODIIHDGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x279CC30", Offset = "0x279B230", VA = "0x18279CC30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7DD6600", Offset = "0x7DD4C00", VA = "0x187DD6600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool NGCGIFLFMED
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7DD7590", Offset = "0x7DD5B90", VA = "0x187DD7590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private static bool IAGPGLDKGFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9920", Offset = "0x7DD7F20", VA = "0x187DD9920", Slot = "15")]
	public BKFKILCGELM EIJEBFICBLD(KDCJJONJJHK KHACHKALEMH, bool MGGHJGOKFMF, int[] HIJOCDINLEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0810", Offset = "0x7DDEE10", VA = "0x187DE0810", Slot = "14")]
	public BKFKILCGELM OCGIOMGIGFD(KDCJJONJJHK KHACHKALEMH, bool MGGHJGOKFMF, int[] HIJOCDINLEF, Func<Dictionary<string, JOHGPLIHENP>, (BKFKILCGELM, EHBLMFNEKIG<Dictionary<string, MODONOMENDG<Texture2D>>>)> HHBPPMABAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA230", Offset = "0x7DD8830", VA = "0x187DDA230")]
	public BKFKILCGELM GCNFPKOAKEO(KDCJJONJJHK KHACHKALEMH, bool MGGHJGOKFMF, int[] HIJOCDINLEF, bool FCDFNBFELCL, CEKFBKJJEMI OKLJAKHOKDI, [Optional] Func<Dictionary<string, JOHGPLIHENP>, (BKFKILCGELM, EHBLMFNEKIG<Dictionary<string, MODONOMENDG<Texture2D>>>)> HHBPPMABAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF340", Offset = "0x7DDD940", VA = "0x187DDF340")]
	private bool KLLPCOGDNJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2140", Offset = "0x7DE0740", VA = "0x187DE2140")]
	private BKFKILCGELM PEOLCDODCPC(bool MGGHJGOKFMF, List<BOJECDBBNGM> OAHEADDKHHC, int[] HIJOCDINLEF, Func<int, APDECCCPNEL> PFOJLFCANIK, bool FCDFNBFELCL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6AF0", Offset = "0x7DD50F0", VA = "0x187DD6AF0")]
	[IteratorStateMachine(typeof(DNCGKDHBELI))]
	private IEnumerator<HPILNDONOCO> BLOLAPOELBP(bool MGGHJGOKFMF, List<BOJECDBBNGM> OAHEADDKHHC, int[] HIJOCDINLEF, Func<int, APDECCCPNEL> PFOJLFCANIK, HABJFJJJEMI BPAKNPHJGIO, Material FILGAIHBEFK, List<BKFKILCGELM> MBMFMDHPEIB, bool EBHJKNPENKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7DDED10", Offset = "0x7DDD310", VA = "0x187DDED10")]
	private void KLFLOGNGKJJ(List<BOJECDBBNGM> OAHEADDKHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5D40", Offset = "0x7DD4340", VA = "0x187DD5D40")]
	private BKFKILCGELM ABOMNBDGHGO(List<BOJECDBBNGM> OAHEADDKHHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7610", Offset = "0x7DD5C10", VA = "0x187DD7610")]
	private LLKKGNCPLNM CMMDFJLEMDP(List<BOJECDBBNGM> OAHEADDKHHC, int CLFLCICHDCN, bool MGGHJGOKFMF, APDECCCPNEL GMLCBPDDIOI, bool OLPFBODMFPD, HABJFJJJEMI BPAKNPHJGIO, Material FILGAIHBEFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF410", Offset = "0x7DDDA10", VA = "0x187DDF410", Slot = "27")]
	public void KMNEEFJJCJM(BDCHMIEGBGF JCIAGLECGJA, float KKGBKLFKCPO, bool JMDEDLJFKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF710", Offset = "0x7DDDD10", VA = "0x187DDF710", Slot = "29")]
	public void LFGFGFJJLNA(CLEOPONOOKA DJOHDEMNDBC, float KKGBKLFKCPO, bool BEHGKJMGHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1D00", Offset = "0x7DE0300", VA = "0x187DE1D00", Slot = "30")]
	public void PBIJNINFFJA(DCJBFDFOONI KIOLKIGBEHD, float KKGBKLFKCPO, bool BOLEONAFPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7DDECB0", Offset = "0x7DDD2B0", VA = "0x187DDECB0", Slot = "28")]
	public void KLEAELHDONC(bool FEOFJDMAHDD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDC30", Offset = "0x7DDC230", VA = "0x187DDDC30", Slot = "31")]
	public void IGNFKJIDLFO(bool FEOFJDMAHDD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6620", Offset = "0x7DD4C20", VA = "0x187DD6620", Slot = "32")]
	public void BGNJMPGINEB(bool FEOFJDMAHDD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF7F0", Offset = "0x7DDDDF0", VA = "0x187DDF7F0")]
	private void MBLNOIGNLAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8730", Offset = "0x7DD6D30", VA = "0x187DD8730")]
	private void CNCGJKPFFKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7DDBFA0", Offset = "0x7DDA5A0", VA = "0x187DDBFA0")]
	private void GGNNGCGGFML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1DF0", Offset = "0x7DE03F0", VA = "0x187DE1DF0", Slot = "25")]
	public void PCNKGPHJCEI(AvatarFaceShape LMJFELHIOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDC90", Offset = "0x7DDC290", VA = "0x187DDDC90", Slot = "26")]
	public void IHEDDDCGONO(AvatarBodyShape KBFKDDGJJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xB66180", Offset = "0xB64780", VA = "0x180B66180", Slot = "33")]
	public void FECAGMNGJKI(DPMPLKEDIBP BGOEFPILPLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCE10", Offset = "0x7DDB410", VA = "0x187DDCE10", Slot = "35")]
	public void HEJGLNCLIMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6680", Offset = "0x7DD4C80", VA = "0x187DD6680", Slot = "39")]
	public void BIJPLAODLFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD2B0", Offset = "0x7DDB8B0", VA = "0x187DDD2B0", Slot = "34")]
	public void HFONMNFJGFE(bool FFFLHHEAJCM, bool HAHKAOFCDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8E70", Offset = "0x7DD7470", VA = "0x187DD8E70")]
	private void EAJHFHHDFCK(SkinnedMeshRenderer CIOGKNPNNEB, int CLFLCICHDCN, Mesh IDMOPPBKAAO, List<Material> FIJHBPPGFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC020", Offset = "0x7DDA620", VA = "0x187DDC020")]
	private static Material GHAKIHJHIEB(Dictionary<NHLPJGDAGJN, Material> LFHGHHIGDEC, Material FAHPLAEEHAB, EHODEPIMANJ EHCDFLEKBJA, LDFPCHPPLJB CDIPADLEMDC, JBDCJHGBANL HJLDIJBMLBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD8F0", Offset = "0x7DDBEF0", VA = "0x187DDD8F0")]
	private static EHODEPIMANJ IDJKKOBELHF(BOJECDBBNGM OICNFPFBDHD, int LABAPBFICLN)
	{
		return default(EHODEPIMANJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6D00", Offset = "0x7DD5300", VA = "0x187DD6D00")]
	private void CEBNLMIMBAO(int CLFIBGFKFKD, Material KKIOJDIOKCM, BOJECDBBNGM OICNFPFBDHD, [Out] Texture2D OHCGLHGPLMM, [Out] Vector4 LBJMIBJDKJA, [Out] Texture2D FEKIIECDGHL, [Out] Texture2D FPJLOHKCIMG, [Out] Texture2D JLMCGDCDEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE580", Offset = "0x7DDCB80", VA = "0x187DDE580")]
	private void JCEHKBHILHC(int CLFIBGFKFKD, Material KKIOJDIOKCM, BOJECDBBNGM OICNFPFBDHD, [Out] Color FOMOELHFPBG, [Out] Color INNHEMAMHEM, [Out] Color AEEOAGNMNHG, [Out] Color EEBEFNFHMBG, [Out] Color AKFDBDMHAII, [Out] Color JOBNAMBEOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD2D0", Offset = "0x7DDB8D0", VA = "0x187DDD2D0")]
	private bool HKNCNJLBKFB(Material KKIOJDIOKCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9C50", Offset = "0x7DD8250", VA = "0x187DD9C50")]
	private static Material ENMKCGANNBB(int CLFIBGFKFKD, FBOFCJGNGFH OICNFPFBDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE4A0", Offset = "0x7DDCAA0", VA = "0x187DDE4A0")]
	private static LDFPCHPPLJB JCACOFAHAPB(BOJECDBBNGM OICNFPFBDHD, int LABAPBFICLN)
	{
		return default(LDFPCHPPLJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7DE03E0", Offset = "0x7DDE9E0", VA = "0x187DE03E0")]
	private static void NGIECGAGFAB(Dictionary<string, List<NHLPJGDAGJN>> DIJLOLAHCLM, BOJECDBBNGM MGHDCBNOPBP, Material FAHPLAEEHAB, EHODEPIMANJ BHICLEPCKCK, LDFPCHPPLJB LOHOACKBKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDA00", Offset = "0x7DDC000", VA = "0x187DDDA00")]
	private static SkinnedMeshRenderer IELOIOPEHHO(Transform JMGDDJFKNIG, Transform JJGLLDDDKPD, SkinnedMeshRenderer[] CJNAOODGNBK, int CLFLCICHDCN, APDECCCPNEL GMLCBPDDIOI, bool MGGHJGOKFMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2930", Offset = "0x7DE0F30", VA = "0x187DE2930")]
	public EHBLLFIPHCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9E20", Offset = "0x7DD8420", VA = "0x187DD9E20")]
	public void FLMOPKJJIJF([In] EBNINIGDDFH INOBNFPIJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0690", Offset = "0x7DDEC90", VA = "0x187DE0690")]
	public void PLMFPGAFJKI([In] BMMHCLOGFAD GMNLDKLDLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6600", Offset = "0x7DD4C00", VA = "0x187DD6600", Slot = "5")]
	public void PHEFHJHIAAP(int CLFLCICHDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD6D0", Offset = "0x7DDBCD0", VA = "0x187DDD6D0", Slot = "10")]
	public void IBBGDJODDOG(JMNMAJLPMHN LOHOACKBKIA, Texture2D OEJKMPDBJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0")]
	public static bool NLFFANFGHLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF870", Offset = "0x7DDDE70", VA = "0x187DDF870", Slot = "11")]
	public bool MEFHOPGGLCJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDEE0", Offset = "0x7DDC4E0", VA = "0x187DDDEE0", Slot = "9")]
	public void IMFGGCLPHDH(ENDDOLENCJB BHICLEPCKCK, Color? HFIMNHFKOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC1F0", Offset = "0x7DDA7F0", VA = "0x187DDC1F0")]
	private void GKBDNBCDFLP(Action KOPPIELLCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC180", Offset = "0x7DDA780", VA = "0x187DDC180", Slot = "6")]
	public void GJFIJADHJKN(JOHGPLIHENP OHALMEPMLNH, Texture DOEKNIGALHK, Color IPBCHCEOFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x12B3720", Offset = "0x12B1D20", VA = "0x1812B3720", Slot = "7")]
	public void HJGFAFADBBI(bool EBHJKNPENKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1DF6150", Offset = "0x1DF4750", VA = "0x181DF6150", Slot = "8")]
	public void FELKPEJJPDD(FDMHDGANLHD MJNKOFMOBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7110", Offset = "0x7DD5710", VA = "0x187DD7110", Slot = "16")]
	public void CHJGCNBDBML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE440", Offset = "0x7DDCA40", VA = "0x187DDE440", Slot = "36")]
	public void JAGLKIGHONK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0E80", Offset = "0x7DDF480", VA = "0x187DE0E80", Slot = "37")]
	public void OLECNFDMDDK([Optional] AFNDLFBCDPE OLIBKDAKDPC, [Optional] bool? AMGDHCLCFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCCB0", Offset = "0x7DDB2B0", VA = "0x187DDCCB0")]
	private bool HCHOIILNCGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9E00", Offset = "0x7DD8400", VA = "0x187DD9E00", Slot = "21")]
	public bool FGBGPDBNCAL(OBJIGDJGKHB.MAHMKAHBAAB JFAPFNOJHKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9CA0", Offset = "0x7DD82A0", VA = "0x187DD9CA0", Slot = "38")]
	public void FBNLIPOALEG(float MHFFJBOEMEA, Color HFIMNHFKOFL, bool BLPMPIBJKLP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC920", Offset = "0x7DDAF20", VA = "0x187DDC920")]
	public void GPMLIDOGGHI(float MHFFJBOEMEA, Color HFIMNHFKOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0D90", Offset = "0x7DDF390", VA = "0x187DE0D90")]
	private static bool OHBIINPKDOF(Material FILGAIHBEFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFE50", Offset = "0x7DDE450", VA = "0x187DDFE50")]
	private void NAPCIIDNLBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD2C0", Offset = "0x7DDB8C0", VA = "0x187DDD2C0")]
	private void HHGEKJJLFED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC3F0", Offset = "0x7DDA9F0", VA = "0x187DDC3F0")]
	private static void GMHKBIGEPNP(Dictionary<NHLPJGDAGJN, Material> LFHGHHIGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5F90", Offset = "0x7DD4590", VA = "0x187DD5F90")]
	private static void AFFBHLOBAPL(Dictionary<Renderer, HABJFJJJEMI> BDAGPKPNGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1EB0", Offset = "0x7DE04B0", VA = "0x187DE1EB0")]
	private void PDHEDKHKLCO(SkinnedMeshRenderer[] CJNAOODGNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA190", Offset = "0x7DD8790", VA = "0x187DDA190")]
	private void FOAGMPJDKJG(SkinnedMeshRenderer EKNCBKALFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8CA0", Offset = "0x7DD72A0", VA = "0x187DD8CA0")]
	private void DPMDAGPPACJ(List<DKAHIDLCKHM> CNJDGLEKAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9AD0", Offset = "0x7DD80D0", VA = "0x187DD9AD0")]
	private void EMDHAABBHAN(Dictionary<string, MODONOMENDG<Texture2D>> DIJLOLAHCLM, bool KPKGGGLDHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0D40", Offset = "0x7DDF340", VA = "0x187DE0D40")]
	private void OGEMPIBHILC(Dictionary<string, List<NHLPJGDAGJN>> DIJLOLAHCLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7DDBE50", Offset = "0x7DDA450", VA = "0x187DDBE50")]
	private void GEFMINILFJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFCC0", Offset = "0x7DDE2C0", VA = "0x187DDFCC0")]
	private void MOGHJEOJNNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9360", Offset = "0x7DD7960", VA = "0x187DD9360")]
	private void EGHGGOMIBIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFBF0", Offset = "0x7DDE1F0", VA = "0x187DDFBF0")]
	private void MNNBCEPPBCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD1F0", Offset = "0x7DDB7F0", VA = "0x187DDD1F0")]
	private void HFDBLJMODNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9210", Offset = "0x7DD7810", VA = "0x187DD9210")]
	private void EGFFDAIOANC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDD50", Offset = "0x7DDC350", VA = "0x187DDDD50")]
	private void IHEENHDMAGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE2E0", Offset = "0x7DDC8E0", VA = "0x187DDE2E0")]
	private void IPGFLPCMIKG(bool ADKDDHMNODD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7DD87B0", Offset = "0x7DD6DB0", VA = "0x187DD87B0")]
	private void DAGEOFPKAGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6520", Offset = "0x7DD4B20", VA = "0x187DD6520")]
	private void AOOHACGFCLO(bool ADKDDHMNODD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7DD67D0", Offset = "0x7DD4DD0", VA = "0x187DD67D0")]
	private void BJBHFPADEFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0840", Offset = "0x7DDEE40", VA = "0x187DE0840")]
	private void ODCFJELLCPO(Material FILGAIHBEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC270", Offset = "0x7DDA870", VA = "0x187DDC270")]
	private void GKNABBKMLFB(Material FILGAIHBEFK, Color DIACNJNGPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0020", Offset = "0x7DDE620", VA = "0x187DE0020")]
	private void NBCJOKCFAIJ(Material FILGAIHBEFK, Color DIACNJNGPBD, Color GDCIGGFCPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD530", Offset = "0x7DDBB30", VA = "0x187DDD530")]
	private void HNFKBABENGK(Material FILGAIHBEFK, Color FOMOELHFPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF9F0", Offset = "0x7DDDFF0", VA = "0x187DDF9F0")]
	private void MEKBLDAALNK(Material FILGAIHBEFK, Texture2D OEJKMPDBJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0270", Offset = "0x7DDE870", VA = "0x187DE0270")]
	private void NEDGMAPJDBG(Material FILGAIHBEFK, Texture AEPHLGLHJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7DDEAB0", Offset = "0x7DDD0B0", VA = "0x187DDEAB0")]
	private void JDOIECODMNM(Action<HABJFJJJEMI> AGAPPBAFHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9950", Offset = "0x7DD7F50", VA = "0x187DD9950")]
	private void EIPNHKLIOBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8880", Offset = "0x7DD6E80", VA = "0x187DD8880")]
	private void DEDDLOLLAFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC550", Offset = "0x7DDAB50", VA = "0x187DDC550")]
	private void GPLOEGOOIMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7DD60F0", Offset = "0x7DD46F0", VA = "0x187DD60F0")]
	public void AFGLDHKGBMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0690", Offset = "0x7DDEC90", VA = "0x187DE0690", Slot = "4")]
	private void NJBKALJGDIC([In] BMMHCLOGFAD GMNLDKLDLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7DE07D0", Offset = "0x7DDEDD0", VA = "0x187DE07D0")]
	[CompilerGenerated]
	private NCBJFOCOMOJ OCAACCCPKMB(BOJECDBBNGM CMGKLEEINPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6490", Offset = "0x7DD4A90", VA = "0x187DD6490")]
	[CompilerGenerated]
	private void AJLBEFLLIEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF520", Offset = "0x7DDDB20", VA = "0x187DDF520")]
	[CompilerGenerated]
	private void KPEHPNDBODE(HABJFJJJEMI CONFGJKBMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0710", Offset = "0x7DDED10", VA = "0x187DE0710")]
	[CompilerGenerated]
	private void NPJHAMMDJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7DD91F0", Offset = "0x7DD77F0", VA = "0x187DD91F0")]
	[CompilerGenerated]
	private void EDMGGOGMLPB(HABJFJJJEMI CONFGJKBMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2730", Offset = "0x7DE0D30", VA = "0x187DE2730")]
	[CompilerGenerated]
	private void PICCBEIOJPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCDF0", Offset = "0x7DDB3F0", VA = "0x187DDCDF0")]
	[CompilerGenerated]
	private void HDDDAAPOGFO(HABJFJJJEMI CONFGJKBMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9160", Offset = "0x7DD7760", VA = "0x187DD9160")]
	[CompilerGenerated]
	private void ECNAMNAIHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF4F0", Offset = "0x7DDDAF0", VA = "0x187DDF4F0")]
	[CompilerGenerated]
	private void KMOPKPCIDAO(HABJFJJJEMI CONFGJKBMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDE50", Offset = "0x7DDC450", VA = "0x187DDDE50")]
	[CompilerGenerated]
	private void IKJDFILOIGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1CD0", Offset = "0x7DE02D0", VA = "0x187DE1CD0")]
	[CompilerGenerated]
	private void OPPKLKAGCKC(HABJFJJJEMI CONFGJKBMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7DDEC10", Offset = "0x7DDD210", VA = "0x187DDEC10")]
	[CompilerGenerated]
	private void KIILCLGNCNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7DE07A0", Offset = "0x7DDEDA0", VA = "0x187DE07A0")]
	[CompilerGenerated]
	private void OANDDJFNGBL(HABJFJJJEMI CONFGJKBMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7500", Offset = "0x7DD5B00", VA = "0x187DD7500")]
	[CompilerGenerated]
	private void CJCLIAAMEMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD280", Offset = "0x7DDB880", VA = "0x187DDD280")]
	[CompilerGenerated]
	private void HFILKHKOHEP(HABJFJJJEMI CONFGJKBMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE3C0", Offset = "0x7DDC9C0", VA = "0x187DDE3C0")]
	[CompilerGenerated]
	private void IPMDOJMCKLN(KeyValuePair<string, MODONOMENDG<Texture2D>> MNOLBPAADFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6480", Offset = "0x7DD4A80", VA = "0x187DD6480")]
	[CompilerGenerated]
	private void AJKBGBKNHOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7310", Offset = "0x7DD5910", VA = "0x187DD7310")]
	[CompilerGenerated]
	private void CHJGKHKOIIM(HABJFJJJEMI CONFGJKBMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7DDECA0", Offset = "0x7DDD2A0", VA = "0x187DDECA0")]
	[CompilerGenerated]
	private void KKNIDBANNPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDE20", Offset = "0x7DDC420", VA = "0x187DDDE20")]
	[CompilerGenerated]
	private void IJEPCAFANHA(HABJFJJJEMI CONFGJKBMMJ)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarElbowBendHelperController : MonoBehaviour, IFLOKEAOLMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[DOIDGFGIDBO(CNNBEEFOMHL.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[FormerlySerializedAs("MinScaleValues")]
		[Header("Scale")]
		[SerializeField]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[FormerlySerializedAs("MaxScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[SerializeField]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[Header("Positional Offset")]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private Vector3? FLCEGEKJICC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private bool PNENIPPLNGI;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7DD0AE0", Offset = "0x7DCF0E0", VA = "0x187DD0AE0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7DD1110", Offset = "0x7DCF710", VA = "0x187DD1110", Slot = "4")]
		public void UpdateController(float OGJBAEEMPIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xD009E0", Offset = "0xCFEFE0", VA = "0x180D009E0", Slot = "6")]
		public void SetEnabled(bool KKGBKLFKCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7DD0BC0", Offset = "0x7DCF1C0", VA = "0x187DD0BC0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7DD15D0", Offset = "0x7DCFBD0", VA = "0x187DD15D0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AvatarElbowBendTargetController : MonoBehaviour, IFLOKEAOLMB
	{
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private const float IFJKGEAPKHK = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		[DOIDGFGIDBO(CNNBEEFOMHL.Self, false, false, false)]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private Vector3 HCHLGLPONLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private Vector3 AFDEPKPKHNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private bool PNENIPPLNGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private float KDALHNEENNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private float MFHBBCBCBHL;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7DD1950", Offset = "0x7DCFF50", VA = "0x187DD1950", Slot = "4")]
		public void UpdateController(float OGJBAEEMPIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xF43C10", Offset = "0xF42210", VA = "0x180F43C10", Slot = "6")]
		public void SetEnabled(bool KKGBKLFKCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7DD1670", Offset = "0x7DCFC70", VA = "0x187DD1670")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7DD2410", Offset = "0x7DD0A10", VA = "0x187DD2410")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class ALNCFKMOOBP : JMNHGNDLFHB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly int CPKKBMMKIDE;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly int HNLKJFPPHLI;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly int DEKAFACPMKK;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly int MMHPNBJNBLA;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly int APPECGFMKBO;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly int GADANMJAEIJ;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly int NAEBKIMACFC;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly int NJJONLCILCA;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly int DLNCIPHCFNI;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly int MBMPDJMAEDH;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly int BAOHAJILGMO;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private static readonly int BDGFLLOCIMC;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private static readonly int BFFAPACHLHC;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static readonly int BOGJDMEMPEC;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private static readonly int BEEHAKJEJCC;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private static readonly int GENKJODNAML;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private static readonly int JABMIOPHNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private Transform OJGPIAACBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Transform DLGKHJPHPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private Transform CGOBKOKECCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private Transform OGLABDJPHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private Transform GJHIFKILPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private Transform LPMPDDADPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private AFHCOGOCJNL KDLKDOLEPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private Material OANCJBNOIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private SkinnedMeshRenderer[] GCGNAMAGFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly List<Material> DIIGBFEKKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private DACCLJEKOLE LKOBCCIOFKM;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public LGEBFGGIOJB KHEHFFDJPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private DACCLJEKOLE GBHFKJFGCNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7DE7890", Offset = "0x7DE5E90", VA = "0x187DE7890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool ICKKICKDNIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7DE9270", Offset = "0x7DE7870", VA = "0x187DE9270", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8960", Offset = "0x7DE6F60", VA = "0x187DE8960")]
	public void FLMOPKJJIJF([In] AFHCOGOCJNL EKNFCMOKPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7910", Offset = "0x7DE5F10", VA = "0x187DE7910")]
	public void PJFFEPABHLE([In] LKLHDENFLHO EDDFGMDJIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7DE9420", Offset = "0x7DE7A20", VA = "0x187DE9420", Slot = "6")]
	public void OPFFONALHGI(CMOKHEACDEH JCKNDJDOBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7DE93C0", Offset = "0x7DE79C0", VA = "0x187DE93C0")]
	private Vector2 NCAAPANAKJG(Vector2 DADHFNMFIEC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7DE79B0", Offset = "0x7DE5FB0", VA = "0x187DE79B0")]
	public void DPPOADIPFMC([In] FLGCACFOBIL EDDFGMDJIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8E90", Offset = "0x7DE7490", VA = "0x187DE8E90")]
	private void KDIIGBKMGPE(ODJBHJPDGFO LCCFLICKKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8B00", Offset = "0x7DE7100", VA = "0x187DE8B00")]
	private void JFACEBCBIIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7DE88A0", Offset = "0x7DE6EA0", VA = "0x187DE88A0")]
	private void KOOLLEMHFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7DE88A0", Offset = "0x7DE6EA0", VA = "0x187DE88A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7DE9C60", Offset = "0x7DE8260", VA = "0x187DE9C60")]
	public ALNCFKMOOBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7910", Offset = "0x7DE5F10", VA = "0x187DE7910", Slot = "5")]
	private void DNPKDIFBIHP([In] LKLHDENFLHO EDDFGMDJIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7DE9260", Offset = "0x7DE7860", VA = "0x187DE9260", Slot = "7")]
	private void LFBMNKPLIHC([In] FLGCACFOBIL EDDFGMDJIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8950", Offset = "0x7DE6F50", VA = "0x187DE8950")]
	[CompilerGenerated]
	internal static float FLIFCEILPCJ(float KKGBKLFKCPO, float PHCIEMFACFG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8A10", Offset = "0x7DE7010", VA = "0x187DE8A10")]
	[CompilerGenerated]
	internal static void FPFNIGJJMOO(Vector2 KMCDOJDOLDC, Vector2 MJPGKJBFNNN, Vector2 GPNBMIDFKMK, Vector2 LPAMMAPPJAO, Vector2 CMGDLKAFPEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8910", Offset = "0x7DE6F10", VA = "0x187DE8910")]
	[CompilerGenerated]
	internal static Vector4 EIFHDLLGMCE(Vector2 NHLFNDFGAHK, Vector2 HKINPNLCPPL)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class AvatarForearmRollController : MonoBehaviour, IFLOKEAOLMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private float KDALHNEENNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private bool PNENIPPLNGI;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7DE9DA0", Offset = "0x7DE83A0", VA = "0x187DE9DA0", Slot = "4")]
		public void UpdateController(float OGJBAEEMPIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2131D30", Offset = "0x2130330", VA = "0x182131D30", Slot = "6")]
		public void SetEnabled(bool KKGBKLFKCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA610", Offset = "0x7DE8C10", VA = "0x187DEA610")]
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
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000171")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA6B0", Offset = "0x7DE8CB0", VA = "0x187DEA6B0")]
		public void PNLBMDNIIGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA640", Offset = "0x7DE8C40", VA = "0x187DEA640")]
		public int BECBCKFDDDC(int DAODMDNLCCF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class ILAJJMPAFDF : GAJHANJFNBF
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7DF5930", Offset = "0x7DF3F30", VA = "0x187DF5930", Slot = "24")]
	public override float MPNMKKIDPKA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7DF5980", Offset = "0x7DF3F80", VA = "0x187DF5980")]
	public ILAJJMPAFDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class GAJHANJFNBF : BNINFAJBEOF
{
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static int APHIANHPDKG;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static int JBLCDIDNPPP;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static int FMLMDIPCKNC;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static int MJFDJJHAOOK;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static int GMMNBHOEAGP;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static int IGLGHLELKNO;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static int HIAMGNHLAIO;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static int[] OEJPHHCEKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private DJPNGJPMFOM KDLKDOLEPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private GNJJOLDCMOF ADCHAGGJIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private int IJLBHHBJDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private float AOPOLKJIPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	protected Animator ALFKKKFHJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	protected AvatarConfiguration PHNCMICKIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	protected int FPKKPPMIBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private int KHGAKBBFLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private int OEFJJOILJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private bool GIFEJAHJOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private DDMDOBOHAOA EHOPJLGJEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private int BJAKNHKMLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private float PLALHHFNBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private AvatarHandDisplaySettings DGFCAAOOJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private IJIIPECBIPC HPIMFDJMKEA;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform KOPFJDDGBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Vector3 AEFOAGAFMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x1848F30", Offset = "0x1847530", VA = "0x181848F30")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1848F50", Offset = "0x1847550", VA = "0x181848F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Quaternion JKAFFBAJPCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xDF43E0", Offset = "0xDF29E0", VA = "0x180DF43E0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xFBA9C0", Offset = "0xFB8FC0", VA = "0x180FBA9C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool BJKHNAPEBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7DF09A0", Offset = "0x7DEEFA0", VA = "0x187DF09A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7DF08F0", Offset = "0x7DEEEF0", VA = "0x187DF08F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool JBCMMICKBBN
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xAB5400", Offset = "0xAB3A00", VA = "0x180AB5400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Vector3 LOHLBPJCOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA71EE0", Offset = "0xA704E0", VA = "0x180A71EE0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xA71F00", Offset = "0xA70500", VA = "0x180A71F00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Quaternion FCDNMGEBHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x118A7F0", Offset = "0x1188DF0", VA = "0x18118A7F0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x15EF0D0", Offset = "0x15ED6D0", VA = "0x1815EF0D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public OBAGOEPBKCD MOIDELJMINE
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xB70E40", Offset = "0xB6F440", VA = "0x180B70E40", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return default(OBAGOEPBKCD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xB70C40", Offset = "0xB6F240", VA = "0x180B70C40", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public OBAGOEPBKCD ADCKGOFMNFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x11B0D40", Offset = "0x11AF340", VA = "0x1811B0D40", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(OBAGOEPBKCD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2462DB0", Offset = "0x24613B0", VA = "0x182462DB0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float OEDEELIIBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xB66E80", Offset = "0xB65480", VA = "0x180B66E80", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xFCF2B0", Offset = "0xFCD8B0", VA = "0x180FCF2B0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool EDEOHEJMGKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7DF0EF0", Offset = "0x7DEF4F0", VA = "0x187DF0EF0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7DF0990", Offset = "0x7DEEF90", VA = "0x187DF0990", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool BMEIJOJJMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7DF1390", Offset = "0x7DEF990", VA = "0x187DF1390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool PJKOOOACIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7DF1380", Offset = "0x7DEF980", VA = "0x187DF1380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool BKFGKCNEHKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7DF0930", Offset = "0x7DEEF30", VA = "0x187DF0930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool JCHEKFHBHOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7DF0920", Offset = "0x7DEEF20", VA = "0x187DF0920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7DF09D0", Offset = "0x7DEEFD0", VA = "0x187DF09D0", Slot = "23")]
	public void FLMOPKJJIJF(DJPNGJPMFOM EKNFCMOKPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0940", Offset = "0x7DEEF40", VA = "0x187DF0940")]
	public void CDKNBKGNHEF(GNJJOLDCMOF GKOGONKFHFC, AvatarHandDisplaySettings IKFHIBIOKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0860", Offset = "0x7DEEE60", VA = "0x187DF0860", Slot = "14")]
	public void ANPBBNPGIIF(bool IKCKHHEBILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1010", Offset = "0x7DEF610", VA = "0x187DF1010", Slot = "13")]
	public void LBCIFBGOHEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0xB66E80", Offset = "0xB65480", VA = "0x180B66E80", Slot = "24")]
	public virtual float MPNMKKIDPKA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0B80", Offset = "0x7DEF180", VA = "0x187DF0B80")]
	private int GAGFEEFPLMJ(OBAGOEPBKCD OLOIBJCPMPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0D30", Offset = "0x7DEF330", VA = "0x187DF0D30")]
	private void HMHINFNFEPN(int LGDOAAABPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0D10", Offset = "0x7DEF310", VA = "0x187DF0D10", Slot = "15")]
	public bool HANGHLEMHCE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0FE0", Offset = "0x7DEF5E0", VA = "0x187DF0FE0", Slot = "16")]
	public bool JKJCDBOPJGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0F00", Offset = "0x7DEF500", VA = "0x187DF0F00")]
	private OBAGOEPBKCD ICDCKLFHFKO()
	{
		return default(OBAGOEPBKCD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x1DC1FB0", Offset = "0x1DC05B0", VA = "0x181DC1FB0", Slot = "17")]
	public void HPKELELCPHO(bool IKCKHHEBILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0FA0", Offset = "0x7DEF5A0", VA = "0x187DF0FA0", Slot = "12")]
	public void JAADDECNMJA(int LGDOAAABPOD, float GGIFOIOGOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0FF0", Offset = "0x7DEF5F0", VA = "0x187DF0FF0", Slot = "10")]
	public void KBPJKOPEKDF(DDMDOBOHAOA DCPJOMEJHIO, bool FHAKDPIOOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0B70", Offset = "0x7DEF170", VA = "0x187DF0B70", Slot = "11")]
	public void FNEIFDCCINC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0F50", Offset = "0x7DEF550", VA = "0x187DF0F50", Slot = "18")]
	public void IPIKALIHFLH(Transform NBIJLPJHNNE, Vector3 JPMEFMMMMAC, Quaternion BPCEPNDEDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1670", Offset = "0x7DEFC70", VA = "0x187DF1670")]
	public GAJHANJFNBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class FBOFCJGNGFH : BOJECDBBNGM
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class BJOHAJLGEGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public FBOFCJGNGFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public List<DKAHIDLCKHM> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public List<DKAHIDLCKHM> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public MODONOMENDG<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public MODONOMENDG<EJIABBDOJCK> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public BJOHAJLGEGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC750", Offset = "0x7DEAD50", VA = "0x187DEC750")]
		internal NCBJFOCOMOJ FHEEDDGDEDC(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public JOHGPLIHENP DJFBFIAMOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public EJIABBDOJCK EEACFIKNKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private MODONOMENDG<EJIABBDOJCK> GMONNKPNLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private MODONOMENDG<Material[]> MJOPNKGOIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public Material[] DMNNMNFJKAL;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool BJHEHHLHMCP
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xA73440", Offset = "0xA71A40", VA = "0x180A73440")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xA73260", Offset = "0xA71860", VA = "0x180A73260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public OBJIGDJGKHB.MAHMKAHBAAB PKFKNCNONFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
		[CompilerGenerated]
		get
		{
			return default(OBJIGDJGKHB.MAHMKAHBAAB);
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xA47BD0", Offset = "0xA461D0", VA = "0x180A47BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7DEE5A0", Offset = "0x7DECBA0", VA = "0x187DEE5A0")]
	public FBOFCJGNGFH(JBDCJHGBANL LHKGOGNNICI, JOHGPLIHENP DFFMDMPECGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7DEDFD0", Offset = "0x7DEC5D0", VA = "0x187DEDFD0", Slot = "6")]
	public override NCBJFOCOMOJ OOHDFIHLHOM(List<DKAHIDLCKHM> LKGPFFLJKIF, List<DKAHIDLCKHM> OFGAEIENHKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7DED750", Offset = "0x7DEBD50", VA = "0x187DED750")]
	public NCBJFOCOMOJ DJNLKOJEEBF(List<DKAHIDLCKHM> LKGPFFLJKIF, List<DKAHIDLCKHM> OFGAEIENHKG, MODONOMENDG<Material[]> MJOPNKGOIIC, [Optional] MODONOMENDG<EJIABBDOJCK> NBMCHDGDOLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7DED3E0", Offset = "0x7DEB9E0", VA = "0x187DED3E0")]
	public (MODONOMENDG<Material[]>, MODONOMENDG<EJIABBDOJCK>) DEAGDFPALHA(List<DKAHIDLCKHM> LKGPFFLJKIF, List<DKAHIDLCKHM> OFGAEIENHKG)
	{
		return default((MODONOMENDG<Material[]>, MODONOMENDG<EJIABBDOJCK>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7DED290", Offset = "0x7DEB890", VA = "0x187DED290", Slot = "7")]
	public override GNEAGMMCABM ABMGHOAEOEM(uint CLFLCICHDCN, AvatarSkinnedMeshBoneOrderRemapsData NGMGNEPPOOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7DEDDC0", Offset = "0x7DEC3C0", VA = "0x187DEDDC0")]
	public GNEAGMMCABM LNJMJIKHIMN(GameObject LFOPPMFINLB, uint CLFLCICHDCN, bool FDPKOMBEBDB, bool MHJHAEMPHOG, AvatarSkinnedMeshBoneOrderRemapsData NGMGNEPPOOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7DEDA50", Offset = "0x7DEC050", VA = "0x187DEDA50")]
	public static bool GECHPAEEJML(Renderer[] CJNAOODGNBK, string FAHHBOCOFCP, [Out] Renderer FOHALBHFLEA, [Out] Renderer GDMBPMMCBPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7DEE550", Offset = "0x7DECB50", VA = "0x187DEE550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7DEE480", Offset = "0x7DECA80", VA = "0x187DEE480")]
	private (MODONOMENDG<EJIABBDOJCK>, MODONOMENDG<Material[]>) PMFBJMPOJJK()
	{
		return default((MODONOMENDG<EJIABBDOJCK>, MODONOMENDG<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7DED3C0", Offset = "0x7DEB9C0", VA = "0x187DED3C0")]
	[CompilerGenerated]
	private void BHMNAHDPPIO(EJIABBDOJCK HPCDHGHHCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xA44950", Offset = "0xA42F50", VA = "0x180A44950")]
	[CompilerGenerated]
	private void FDCJDPCPELG(Material[] HPCDHGHHCOO)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class AvatarKneeBendTargetController : MonoBehaviour, IFLOKEAOLMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		[DOIDGFGIDBO(CNNBEEFOMHL.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private Vector3 HCHLGLPONLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private Vector3 PBEOMJHKJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private Vector3 ENAGDGLCEND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private Matrix4x4 LDFPNCKLABN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private bool PNENIPPLNGI;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7DEAC40", Offset = "0x7DE9240", VA = "0x187DEAC40", Slot = "4")]
		public void UpdateController(float OGJBAEEMPIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7DEAC30", Offset = "0x7DE9230", VA = "0x187DEAC30", Slot = "6")]
		public void SetEnabled(bool KKGBKLFKCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA7D0", Offset = "0x7DE8DD0", VA = "0x187DEA7D0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7DEB300", Offset = "0x7DE9900", VA = "0x187DEB300")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[HIAEMPMDAHB]
public struct HOKDHMDJEJN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	[ReadOnly]
	public FOOIFNEFHIA JBFDDMGIGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	[ReadOnly]
	public int FCNAAMJIPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public MBLOHONIDFP AKPENHFLCAK;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7DF42B0", Offset = "0x7DF28B0", VA = "0x187DF42B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[NativeContainer]
[HIAEMPMDAHB]
public struct MBLOHONIDFP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<Vector3> IHAGMKCDMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<Vector3> NJFMDNHHIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<Vector4> DIGJAIJPCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<Vector2> LHPEOCKBJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<Vector2> CPIKBLCKDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<Vector2> MMEOMLFJHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<Vector2> MENFNBPAFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public NativeArray<Color> FMNNDEBGEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeArray<int> HJGCOFLHDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public NativeArray<int> JPCHEOGJMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private NativeArray<int> MJFHIPINCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private NativeArray<int> MEBMHBOMFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<int> DHKNFENLGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<int> OHFKMHMHPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeArray<int> AIHJOJMNKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeArray<BoneWeight> ANBIHIEPAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private NativeArray<int> MJNKOFMOBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private bool FBIHAAGDJHM;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int OOBGHEGAHOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7DF7B50", Offset = "0x7DF6150", VA = "0x187DF7B50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7DF7F00", Offset = "0x7DF6500", VA = "0x187DF7F00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int PDIPGLKLALB
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7DF7FC0", Offset = "0x7DF65C0", VA = "0x187DF7FC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7DF7990", Offset = "0x7DF5F90", VA = "0x187DF7990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int AHBICFCOBFO
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7DF7980", Offset = "0x7DF5F80", VA = "0x187DF7980")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7DF8070", Offset = "0x7DF6670", VA = "0x187DF8070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7DF83A0", Offset = "0x7DF69A0", VA = "0x187DF83A0")]
	public MBLOHONIDFP(int GCDMNDHKDOP, int JCPGDIJDFBG, int PDPFMONBLLB, int PLOBGDAIJBP, Allocator HOHBLCPFIEJ, int AMHGPLBOJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7DF7FD0", Offset = "0x7DF65D0", VA = "0x187DF7FD0")]
	public void NGBPMAKMLCI(int KHMHPNKMLMD, Vector3 JIJNMCDLDDE, Vector3 LFBNNGIKBPK, Vector4 MMMCFFENLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7DF8130", Offset = "0x7DF6730", VA = "0x187DF8130")]
	public void PGDMCFIJIPH(int KHMHPNKMLMD, BoneWeight BMMHGKLFGIJ, NativeSlice<byte> JCEJGEIDOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7DF8110", Offset = "0x7DF6710", VA = "0x187DF8110")]
	public Color PDBGGJHLDLP(int KHMHPNKMLMD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7DF8040", Offset = "0x7DF6640", VA = "0x187DF8040")]
	public void OAAEHJMNHKO(int KHMHPNKMLMD, Color HJGAGGHDFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7DF7EB0", Offset = "0x7DF64B0", VA = "0x187DF7EB0")]
	public void GKNKDDGLJIM(byte GCMGKDPLJIA, int KHMHPNKMLMD, Vector2 BHMKKJJPDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7DF8060", Offset = "0x7DF6660", VA = "0x187DF8060")]
	public void OFEMFKLCDBO(int KHMHPNKMLMD, int LCILPJDNKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7DF7950", Offset = "0x7DF5F50", VA = "0x187DF7950")]
	public bool AFKGHDHPCKD(int GCMGKDPLJIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7DF82D0", Offset = "0x7DF68D0", VA = "0x187DF82D0")]
	public void PKMOILCCJLM(int HHPNHBHGKHG, int MOBKDJHFHDL, int PHABMFMJBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7DF7F10", Offset = "0x7DF6510", VA = "0x187DF7F10")]
	public int[] JEJIPJOOHNK(int HHPNHBHGKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7DF8080", Offset = "0x7DF6680", VA = "0x187DF8080")]
	private NativeSlice<int> OOHOMIEBEBK(int HHPNHBHGKHG)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7DF79A0", Offset = "0x7DF5FA0", VA = "0x187DF79A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7DF7B60", Offset = "0x7DF6160", VA = "0x187DF7B60")]
	public Mesh FLIPONBNLBB([Optional] string OLHFNNEBAIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[HIAEMPMDAHB]
[DefaultMember("Item")]
[NativeContainer]
public struct FOOIFNEFHIA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<Vector3> IHAGMKCDMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<Vector3> NJFMDNHHIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeArray<Vector4> DIGJAIJPCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeArray<Vector2> LHPEOCKBJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeArray<Vector2> CPIKBLCKDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeArray<Vector2> MMEOMLFJHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeArray<Vector2> MENFNBPAFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeArray<Color> FMNNDEBGEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeArray<int> GGNELPAALCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeArray<int> CONEJDECELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeArray<int> FKDDKPFBFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeArray<int> DMCBIAPPFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public NativeArray<bool> BIPJPIFPAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public NativeArray<int> KAIAGOOEGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeArray<int> AMNMJDNKLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public NativeArray<BoneWeight> LKFAHJBECAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private NativeArray<Matrix4x4> NHCAHDOGLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private NativeArray<long> ENALLKELHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private NativeArray<byte> CGCBIBONNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private NativeArray<int> OKBKEAFLNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private NativeArray<int> HFMOEKIAPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public NativeArray<sbyte> MPAKKCJFMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public NativeArray<byte> PBHFBEGHMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private NativeArray<int> OPBMLJMGKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private bool FBIHAAGDJHM;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int AMMKGGIAOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xE79D00", Offset = "0xE78300", VA = "0x180E79D00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int BJFHCJDHOCP
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xD036C0", Offset = "0xD01CC0", VA = "0x180D036C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int BJOPEHFBBPG
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7DEE990", Offset = "0x7DECF90", VA = "0x187DEE990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int PCEEFBNNBOD
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7DEEF40", Offset = "0x7DED540", VA = "0x187DEEF40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7DEE610", Offset = "0x7DECC10", VA = "0x187DEE610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int OOBGHEGAHOL
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7DEE8B0", Offset = "0x7DECEB0", VA = "0x187DEE8B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7DEE9D0", Offset = "0x7DECFD0", VA = "0x187DEE9D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int JIPFBOKLHNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7DEEF10", Offset = "0x7DED510", VA = "0x187DEEF10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7DEE8A0", Offset = "0x7DECEA0", VA = "0x187DEE8A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public DBKKBPDPDDG KFFCNGIKOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7DEEF30", Offset = "0x7DED530", VA = "0x187DEEF30")]
		get
		{
			return default(DBKKBPDPDDG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7DEEF20", Offset = "0x7DED520", VA = "0x187DEEF20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public byte JAKCJLCFGLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7DEE890", Offset = "0x7DECE90", VA = "0x187DEE890")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7DEE9C0", Offset = "0x7DECFC0", VA = "0x187DEE9C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public ONCFOLAKPOJ FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7DEE9E0", Offset = "0x7DECFE0", VA = "0x187DEE9E0")]
		get
		{
			return default(ONCFOLAKPOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7DEEF50", Offset = "0x7DED550", VA = "0x187DEEF50")]
	public FOOIFNEFHIA(IList<Mesh> NPGOLOCEDCC, IList<Matrix4x4> BEOEBBGEKBB, IList<bool> BIPJPIFPAGD, byte GHFDMOIKCAP, IList<byte[]> DCLABJMPAMJ, IList<long> IPFDLAKJDMN, IList<bool> NDBFOJCAEJB, IList<int> KAIAGOOEGHC, IList<int> EEBINPNGNPM, IList<int> EGIDICLLCPE, Allocator HOHBLCPFIEJ, DBKKBPDPDDG KOIHPOECKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7DEE8C0", Offset = "0x7DECEC0", VA = "0x187DEE8C0")]
	public MBLOHONIDFP GLPEPGGCPCC(Allocator HOHBLCPFIEJ)
	{
		return default(MBLOHONIDFP);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7DEE620", Offset = "0x7DECC20", VA = "0x187DEE620", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[HIAEMPMDAHB]
public class KNBKIBNDLKJ : CJPLPEOHODM
{
	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x7DF59E0", Offset = "0x7DF3FE0", VA = "0x187DF59E0")]
	public FOOIFNEFHIA NKHFPDAJBEB()
	{
		return default(FOOIFNEFHIA);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6AD0", Offset = "0x7DE50D0", VA = "0x187DE6AD0")]
	public KNBKIBNDLKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct ONCFOLAKPOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public NativeSlice<Vector3> IHAGMKCDMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public NativeSlice<Vector3> NJFMDNHHIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public NativeSlice<Vector4> DIGJAIJPCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeSlice<Vector2> LHPEOCKBJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public NativeSlice<Vector2> CPIKBLCKDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public NativeSlice<Vector2> MMEOMLFJHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public NativeSlice<Vector2> MENFNBPAFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public NativeSlice<Color> FMNNDEBGEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public NativeSlice<int> HKGAFFOIAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public NativeSlice<int> DMCBIAPPFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public NativeSlice<BoneWeight> LKFAHJBECAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public NativeSlice<byte> DLEEAPMCILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public int LJCBDJFGFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public Matrix4x4 HCOKNJBDEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public long JBKIGDJGCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public NativeSlice<byte> JCEJGEIDOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public bool BCKBALNJFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public int GNNFOHKNPBJ;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal readonly struct NHLPJGDAGJN : IEquatable<NHLPJGDAGJN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	internal readonly Material PFNPFBIHOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	internal readonly EHODEPIMANJ EOMABGCGKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	internal readonly LDFPCHPPLJB DLICJLGMPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	internal readonly JBDCJHGBANL PCKBLLJANJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	internal readonly bool FDCKHABIMGN;

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x7DFA440", Offset = "0x7DF8A40", VA = "0x187DFA440")]
	public NHLPJGDAGJN(Material KKIOJDIOKCM, EHODEPIMANJ EHCDFLEKBJA, LDFPCHPPLJB CDIPADLEMDC, JBDCJHGBANL HJLDIJBMLBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x7DFA1A0", Offset = "0x7DF87A0", VA = "0x187DFA1A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9F00", Offset = "0x7DF8500", VA = "0x187DF9F00", Slot = "4")]
	public bool Equals(NHLPJGDAGJN HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9F90", Offset = "0x7DF8590", VA = "0x187DF9F90", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7DFA090", Offset = "0x7DF8690", VA = "0x187DFA090", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, OJNOLKOEFML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		[Header("Configuration")]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[Header("Configuration")]
		[SerializeField]
		private IJIIPECBIPC avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[FormerlySerializedAs("avatarSkinAsset")]
		[SerializeField]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[FormerlySerializedAs("BodyMaterial")]
		[SerializeField]
		private Material BodyMaterialSkinGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private ABICHDKCLFP JPGPIPKOANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private JMNHGNDLFHB MIBLFDMHLFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private BNINFAJBEOF JDMOBBJOJBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private BNINFAJBEOF PIDNDMDHDKL;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public ABICHDKCLFP GBBLMKIKCON
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x7DEC280", Offset = "0x7DEA880", VA = "0x187DEC280", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public JMNHGNDLFHB IFCCJECNCOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x7DEC2D0", Offset = "0x7DEA8D0", VA = "0x187DEC2D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public BNINFAJBEOF MLGHPNPGFNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x7DEC320", Offset = "0x7DEA920", VA = "0x187DEC320", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public BNINFAJBEOF OIPLBKOGFHD
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x7DEC370", Offset = "0x7DEA970", VA = "0x187DEC370", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Transform AGENGIMAKOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x7DEC3C0", Offset = "0x7DEA9C0", VA = "0x187DEC3C0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public IJIIPECBIPC FLBKDBJALPN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xA47FE0", Offset = "0xA465E0", VA = "0x180A47FE0", Slot = "12")]
			get
			{
				return default(IJIIPECBIPC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7DEB310", Offset = "0x7DE9910", VA = "0x187DEB310")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7DEBE50", Offset = "0x7DEA450", VA = "0x187DEBE50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7DEBA80", Offset = "0x7DEA080", VA = "0x187DEBA80", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7DEBE50", Offset = "0x7DEA450", VA = "0x187DEBE50", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7DEB6C0", Offset = "0x7DE9CC0", VA = "0x187DEB6C0", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC190", Offset = "0x7DEA790", VA = "0x187DEC190")]
		public void UpdatePostIKAnimControllers(float OGJBAEEMPIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7DEB9F0", Offset = "0x7DE9FF0", VA = "0x187DEB9F0")]
		private void ELKFMBIHMMD(GameObject ODCICEDDLMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7DEBAE0", Offset = "0x7DEA0E0", VA = "0x187DEBAE0")]
		private ABICHDKCLFP MHINGCNMDNE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7DEB380", Offset = "0x7DE9980", VA = "0x187DEB380")]
		private JMNHGNDLFHB CKGPGAAKHEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7DEBF00", Offset = "0x7DEA500", VA = "0x187DEBF00")]
		private BNINFAJBEOF PJIGAKCBIPL(KDJOKHKGLOC DMPIGNNFCJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC270", Offset = "0x7DEA870", VA = "0x187DEC270")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class HABJFJJJEMI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private MaterialPropertyBlock BGBCLJMEKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public Color? JDLMGNIPBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public Color? EGHBDFMFEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public Color? OMHAMIMHAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public Color? MGNEIEEBJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public Color HIMCCCJOMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public Color PONPCLJJKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public Color FKFJLPMMJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public float HHHDMCDFGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public Texture2D BHOJCLBHPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public Texture2D EDOHOLLIDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private Dictionary<NHLPJGDAGJN, int> PEKKOAHHCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private EHODEPIMANJ[] EBBIMHLOMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private LDFPCHPPLJB[] DNCGFDADPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public Vector4[] DIKJJJHCNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public Vector4[] GAPINNJBCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public Vector4[] KGNLBFGHOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public Vector4[] ONLODGCFGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public Vector4[] KEOMFJEEMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public Vector4[] INDLNEMICEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private List<Texture2D> KABMILJDFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private Vector4[] DGOFLAJAHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private List<Texture2D> LNADPEDLCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private float[] BINDJDOBPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private Vector4[] PCPGGPAJNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private float[] NNAOFCKLGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public float[] IPOEOKOPANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private List<Texture2D> MLFHMMHHABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private float[] OCPHOKFJGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private List<Texture2D> LNCJJJNDPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private Vector4[] GAAPHIBOFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private float[] KKLAJGAJFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private Vector4[] DJKODDAIDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public float[] OGKGNGDFKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public Texture2DArray ODOOCCJANIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public Texture2DArray LBCINCDPGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public Texture2DArray LEDNIEIPNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public Texture2DArray AHNCICLPFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private bool BEFCDFFLEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private int ICFFGLHDFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private Vector2? DCMNCIDFIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private TextureFormat ELIGNCNJBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private Vector2? NONCMOLGNIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private TextureFormat GBNMMHJNCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private Vector2? FMGFONIFIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private TextureFormat EOLIJEJNFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private Vector2? NILGGPNBNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private TextureFormat FMAPOABOGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private bool IPJFEJDAGIO;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static int DEOAHOLNILO;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static int AOJDCHBEECE;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static int HPKANEDEJME;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static int GKCLMPIFKMG;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static int HFANNOAFCNM;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static int HGOHNAMMHDP;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private static int CIFEIMOJNFL;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private static int PMPECOLNBMP;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static int HGJAAFKNHBL;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private static int LNBMAMKBLHG;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static int MDIEIJKAGLL;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private static int KPFFMLKHBNP;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private static int FHBJKABPBLN;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static int LCJJOEBHHMG;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private static int KOLGDGMBEHA;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private static int FMIOHPKGHKM;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private static int OGKBPKBDJMG;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private static int INOEBBIJLMJ;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private static int EFNFFHPPLFB;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private static int MBONLMFEIJK;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7DF3CF0", Offset = "0x7DF22F0", VA = "0x187DF3CF0")]
	private HABJFJJJEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7DF41F0", Offset = "0x7DF27F0", VA = "0x187DF41F0")]
	public HABJFJJJEMI(Color FIJDMNMPGHM, Color KFIDCOLNOCB, Color FPBMICLIMJB, Color? OKLIJLKFIMJ, Color? JLFPMKLELHK, Color? FCANCBHBMJB, Texture2D NFLBKLKDFHB, Texture2D HEDHPJOECNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7DF19D0", Offset = "0x7DEFFD0", VA = "0x187DF19D0")]
	internal int FMJDBMMPMIK(Material HIGLCLFFAAN, EHODEPIMANJ EHCDFLEKBJA, LDFPCHPPLJB CDIPADLEMDC, JBDCJHGBANL HJLDIJBMLBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1940", Offset = "0x7DEFF40", VA = "0x187DF1940")]
	private int FMJDBMMPMIK(NHLPJGDAGJN BLIBAMJKLIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7DF2D90", Offset = "0x7DF1390", VA = "0x187DF2D90")]
	internal int OEPPMDMHGLE(Material HIGLCLFFAAN, Color FOMOELHFPBG, Color INNHEMAMHEM, Color AEEOAGNMNHG, Color EEBEFNFHMBG, Color AKFDBDMHAII, Texture2D DIKCMEHHEKP, Vector4 BBFBBKIAMIA, Texture2D OOPOMEJJMJO, Vector4 PFOAAGGGNDA, float HFJPCEKDMDE, float JOEAMPOJEJP, Texture2D AEBKNABMGBJ, Vector4 OEMGMCKPHMD, float OADEIELBGEE, Texture2D EEIHPANJGIA, Color JOBNAMBEOML, Vector4 JKDPCGJEBDG, EHODEPIMANJ EHCDFLEKBJA, LDFPCHPPLJB CDIPADLEMDC, JBDCJHGBANL HJLDIJBMLBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1740", Offset = "0x7DEFD40", VA = "0x187DF1740")]
	private void DGFPBBCBDCE(List<Texture2D> KABMILJDFGH, [Out] Texture2DArray KLLKEJGJIIG, [Out] Texture2DArray OLCJENDDFKA, [Out] Texture2DArray CAHLILIHEKB, [Out] Texture2DArray NEHDFOEFANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x7DF2C40", Offset = "0x7DF1240", VA = "0x187DF2C40")]
	public void NGNLNDGEOEH(Shader KBJHFFKBJLM, Renderer ILMDPGBOCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1F50", Offset = "0x7DF0550", VA = "0x187DF1F50")]
	private void JPAFLFFIKGP(Shader KBJHFFKBJLM, Renderer ILMDPGBOCFL, int MDOGGIKNFMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1C00", Offset = "0x7DF0200", VA = "0x187DF1C00")]
	private Color HBGJHIINAOK(Color EJJKPDIEADP, EHODEPIMANJ BHICLEPCKCK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1E00", Offset = "0x7DF0400", VA = "0x187DF1E00")]
	private Color HGGFCDJPFME(Color CBMENHPIIGN, EHODEPIMANJ BHICLEPCKCK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1AA0", Offset = "0x7DF00A0", VA = "0x187DF1AA0")]
	private bool GMDCDCEAOBG(Texture2D LAFHCKIPHLM, LDFPCHPPLJB LOHOACKBKIA, [Out] Texture2D EKAHKKLDJEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1690", Offset = "0x7DEFC90", VA = "0x187DF1690")]
	private void AFCPHOGLNNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1900", Offset = "0x7DEFF00", VA = "0x187DF1900", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class BOJECDBBNGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public readonly JBDCJHGBANL IPGKNAOFNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	protected bool OFOCENKJFKF;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool LKLJMJFCLLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xAC2F90", Offset = "0xAC1590", VA = "0x180AC2F90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xAC2F80", Offset = "0xAC1580", VA = "0x180AC2F80")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool POCDMBIOOHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xAC2F70", Offset = "0xAC1570", VA = "0x180AC2F70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xAC2FB0", Offset = "0xAC15B0", VA = "0x180AC2FB0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public virtual OBJIGDJGKHB.MAHMKAHBAAB JBKIGDJGCJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(OBJIGDJGKHB.MAHMKAHBAAB);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xD23850", Offset = "0xD21E50", VA = "0x180D23850", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool ENFDPNKLGGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x146ED60", Offset = "0x146D360", VA = "0x18146ED60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool DLNOMGBPOKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7DECF20", Offset = "0x7DEB520", VA = "0x187DECF20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool LLAIPDNINBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7DECF10", Offset = "0x7DEB510", VA = "0x187DECF10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool MAFJJKMCAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7DECEF0", Offset = "0x7DEB4F0", VA = "0x187DECEF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7DECF30", Offset = "0x7DEB530", VA = "0x187DECF30")]
	protected BOJECDBBNGM(JBDCJHGBANL LHKGOGNNICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract NCBJFOCOMOJ OOHDFIHLHOM(List<DKAHIDLCKHM> LKGPFFLJKIF, List<DKAHIDLCKHM> OFGAEIENHKG);

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract GNEAGMMCABM ABMGHOAEOEM(uint CLFLCICHDCN, AvatarSkinnedMeshBoneOrderRemapsData NGMGNEPPOOI);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class BGIKFPCPOGM : PFPAPIECGKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private AvatarSkinAssetItem FJCPIMKJHON;

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x7DEC650", Offset = "0x7DEAC50", VA = "0x187DEC650")]
	public BGIKFPCPOGM(AvatarSkinAssetItem PMKCOCALAOC, AvatarSkinAssetItem.FAGHPFPFAPN FJDBIHBAIML, JBDCJHGBANL HJLDIJBMLBP, [Optional] HBMNJKGCEPD? LOELLMGNKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x7DEC3E0", Offset = "0x7DEA9E0", VA = "0x187DEC3E0", Slot = "6")]
	public override NCBJFOCOMOJ OOHDFIHLHOM(List<DKAHIDLCKHM> LKGPFFLJKIF, List<DKAHIDLCKHM> OFGAEIENHKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class DFAKGHFLLCP
{
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private static readonly int[] BKBHJGMJKHL;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	private static readonly int[] AGNCBJJGGGO;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static int[] IIGIJMJBBCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7DECF60", Offset = "0x7DEB560", VA = "0x187DECF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7DECFB0", Offset = "0x7DEB5B0", VA = "0x187DECFB0")]
	public static int[] FHBNGGJKBLB(bool LNPDMAAOEHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7DED060", Offset = "0x7DEB660", VA = "0x187DED060")]
	public static int IDNEODOHOAG(LNDADOOHAMM FDJJEPCAIGP, bool LNPDMAAOEHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7DED0F0", Offset = "0x7DEB6F0", VA = "0x187DED0F0")]
	private static int IFGKAMGKECN(LNDADOOHAMM FDJJEPCAIGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7DED040", Offset = "0x7DEB640", VA = "0x187DED040")]
	private static int FHLMFMBJHBO(LNDADOOHAMM FDJJEPCAIGP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class LMICBAHJOAG
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class BOHCFOIKMKM : IEnumerator<HPILNDONOCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private HPILNDONOCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private HPILNDONOCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
		[DebuggerHidden]
		public BOHCFOIKMKM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x13E20F0", Offset = "0x13E06F0", VA = "0x1813E20F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7DECEA0", Offset = "0x7DEB4A0", VA = "0x187DECEA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
	public static void PMPGBPIJIME(string HLIPPIOIAJK, int CLFLCICHDCN, long OGGFMLANOKE, long NBCMLOMFFMK, long BCDMACHPEKE, long HNAEDAOFMOJ, long ABLEPDFDKAC, long OOAPIJLFJBB, long GBMDGEMGOKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7DF73A0", Offset = "0x7DF59A0", VA = "0x187DF73A0")]
	public static LLKKGNCPLNM EDJCPGONEAM(JobHandle CAGGDCBKFMO, bool CELILJFINHE, bool KPMAPIHLPNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7DF7330", Offset = "0x7DF5930", VA = "0x187DF7330")]
	[IteratorStateMachine(typeof(BOHCFOIKMKM))]
	private static IEnumerator<HPILNDONOCO> AGKDNNOMABM(JobHandle MNCGAKBHIPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class NFICOKDIAGC
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum MOCMMFEKJIE
	{
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		General,
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly int LLODMCLIEED;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly int GPPDPMBIAHH;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly int ILCNNCPHIBJ;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly int JHDKDLMAHJD;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly int BNBCEOBLKKB;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly int AJABFAMFLFK;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly int MJLABPLPMKE;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly int OPJOLBLLAGC;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly int NJINGGELJBB;

	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public static readonly int EFIJKBKLGBK;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly int ADBJKEMODGO;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly int JDMINMEGFJD;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9BA0", Offset = "0x7DF81A0", VA = "0x187DF9BA0")]
	public static bool KEDGDPOBDEA(Material KKIOJDIOKCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9C10", Offset = "0x7DF8210", VA = "0x187DF9C10")]
	public static bool OGFGHKENPNE(Material KKIOJDIOKCM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class PFPAPIECGKF : BOJECDBBNGM
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class BKPEIBMCGMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public MODONOMENDG<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public PFPAPIECGKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public BKPEIBMCGMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC990", Offset = "0x7DEAF90", VA = "0x187DEC990")]
		internal void ECIOHMFCBPJ(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7DECD60", Offset = "0x7DEB360", VA = "0x187DECD60")]
		internal void FHEEDDGDEDC(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	protected AvatarSkinAssetItem BHABIKNPGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	protected Material[] IICLIPKOMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private readonly AvatarSkinAssetItem.FAGHPFPFAPN MMMDDJLHPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private readonly AssetReference NCBPPKDNKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private readonly HBMNJKGCEPD? OJCEGIDDPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private SkinnedMeshRenderer[] KGENLIKADIB;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public override OBJIGDJGKHB.MAHMKAHBAAB JBKIGDJGCJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(OBJIGDJGKHB.MAHMKAHBAAB);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xA50EB0", Offset = "0xA4F4B0", VA = "0x180A50EB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7DFAA20", Offset = "0x7DF9020", VA = "0x187DFAA20")]
	public PFPAPIECGKF(AvatarSkinAssetItem.FAGHPFPFAPN FJDBIHBAIML, AssetReference EKHOOLMDMGO, Material MDPLHDBFKKF, JBDCJHGBANL HJLDIJBMLBP, OBJIGDJGKHB.MAHMKAHBAAB NMNIIEGLENM = (OBJIGDJGKHB.MAHMKAHBAAB)0L, [Optional] HBMNJKGCEPD? LOELLMGNKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7DFAB50", Offset = "0x7DF9150", VA = "0x187DFAB50")]
	public PFPAPIECGKF(AvatarSkinAssetItem.FAGHPFPFAPN FJDBIHBAIML, AssetReference EKHOOLMDMGO, Material MDPLHDBFKKF, OBJIGDJGKHB.MAHMKAHBAAB NMNIIEGLENM = (OBJIGDJGKHB.MAHMKAHBAAB)0L, [Optional] HBMNJKGCEPD? LOELLMGNKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7DFA790", Offset = "0x7DF8D90", VA = "0x187DFA790", Slot = "6")]
	public override NCBJFOCOMOJ OOHDFIHLHOM(List<DKAHIDLCKHM> LKGPFFLJKIF, List<DKAHIDLCKHM> OFGAEIENHKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7DFA580", Offset = "0x7DF8B80", VA = "0x187DFA580", Slot = "7")]
	public override GNEAGMMCABM ABMGHOAEOEM(uint CLFLCICHDCN, AvatarSkinnedMeshBoneOrderRemapsData NGMGNEPPOOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7DFA9B0", Offset = "0x7DF8FB0", VA = "0x187DFA9B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7DFA960", Offset = "0x7DF8F60", VA = "0x187DFA960")]
	protected void PKAEIFNHHIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class KPANOABCFDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private List<int> MPHOFJEFHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private List<LMNKGJLIDKD> NLECKCBOIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private HashSet<Transform> GOHKBFEAKGN;

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7DF5EC0", Offset = "0x7DF44C0", VA = "0x187DF5EC0")]
	public static KPANOABCFDC CNOIAKEFDMC(Transform MMMCFFENLAH, Dictionary<Transform, OutfitType?> GHJJLILEHGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7DF6050", Offset = "0x7DF4650", VA = "0x187DF6050")]
	private void FPBLMLJEAMD(Transform MMMCFFENLAH, JBDCJHGBANL HJLDIJBMLBP, Dictionary<Transform, OutfitType?> GHJJLILEHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7DF6370", Offset = "0x7DF4970", VA = "0x187DF6370")]
	private void LENPOAJHILH(Transform BBGDKDCBDON, JBDCJHGBANL HJLDIJBMLBP, bool PPOCAMOHLBM, OutfitType? HPCEECOHNKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7DF5AD0", Offset = "0x7DF40D0", VA = "0x187DF5AD0")]
	public MHCEKNJPIPF BGHKPFDHMAK(HashSet<string> MCAFMKCBMJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7DF6500", Offset = "0x7DF4B00", VA = "0x187DF6500")]
	public KPANOABCFDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class MHCEKNJPIPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private List<LMNKGJLIDKD> NLECKCBOIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private List<Matrix4x4> DGLMFFPJNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private Transform[] FPIKIICBJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private Matrix4x4[] BEAFAFNIPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private Dictionary<PKABNEOFJEH, int> OEHFBLCGBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private List<LFHGMFOOJJO> JBBPCIGJKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private bool OKJGGEJNJOE;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int DFHEGHDHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x7DF89B0", Offset = "0x7DF6FB0", VA = "0x187DF89B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Transform[] PDCLCNPEOCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x7DF8A60", Offset = "0x7DF7060", VA = "0x187DF8A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Matrix4x4[] NNANEEPKJIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x7DF89F0", Offset = "0x7DF6FF0", VA = "0x187DF89F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9130", Offset = "0x7DF7730", VA = "0x187DF9130")]
	public void LENPOAJHILH(Transform BBGDKDCBDON, JBDCJHGBANL HJLDIJBMLBP, OutfitType? HPCEECOHNKJ, bool EMDIBKOGFLG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7DF8DC0", Offset = "0x7DF73C0", VA = "0x187DF8DC0")]
	private void LENPOAJHILH(Transform BBGDKDCBDON, JBDCJHGBANL HJLDIJBMLBP, OutfitType? HPCEECOHNKJ, bool EMDIBKOGFLG, Matrix4x4 EPOHIDPFPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7DF8800", Offset = "0x7DF6E00", VA = "0x187DF8800")]
	public int CKONBNLKLLC(PKABNEOFJEH BLIBAMJKLIA, bool CGFHINMBDCO, [Optional] OutfitType? HPCEECOHNKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7DF8BD0", Offset = "0x7DF71D0", VA = "0x187DF8BD0")]
	public int ICALPCPPDII(JBDCJHGBANL HJLDIJBMLBP, [Optional] OutfitType? HPCEECOHNKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7DF8CD0", Offset = "0x7DF72D0", VA = "0x187DF8CD0")]
	public void JDNELJNNMLN(PKABNEOFJEH BLIBAMJKLIA, Matrix4x4 OGKELNPJHOM, bool CGFHINMBDCO = false, [Optional] OutfitType? HPCEECOHNKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9330", Offset = "0x7DF7930", VA = "0x187DF9330")]
	public Matrix4x4 MCOKODKDDKC(PKABNEOFJEH BLIBAMJKLIA, bool CGFHINMBDCO, [Optional] OutfitType? HPCEECOHNKJ)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x14ED580", Offset = "0x14EBB80", VA = "0x1814ED580")]
	public void AKGFDPBGBMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9480", Offset = "0x7DF7A80", VA = "0x187DF9480")]
	public MHCEKNJPIPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct PKABNEOFJEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public readonly string DNDGGKPPNIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public readonly JBDCJHGBANL PCKBLLJANJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public readonly OutfitType? IMLCOBAPEBC;

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7DFAEF0", Offset = "0x7DF94F0", VA = "0x187DFAEF0")]
	public PKABNEOFJEH(string LNGMNNMFDII, JBDCJHGBANL HJLDIJBMLBP, [Optional] OutfitType? HPCEECOHNKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7DFAE40", Offset = "0x7DF9440", VA = "0x187DFAE40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7DFAD10", Offset = "0x7DF9310", VA = "0x187DFAD10")]
	public bool GLEOHFCONOB(PKABNEOFJEH HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7DFAC70", Offset = "0x7DF9270", VA = "0x187DFAC70", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7DFADD0", Offset = "0x7DF93D0", VA = "0x187DFADD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct LFHGMFOOJJO : IEquatable<LFHGMFOOJJO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public readonly JBDCJHGBANL PCKBLLJANJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public readonly OutfitType? EGHNJMOKAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public readonly int GJMEPPCFOBM;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7DF7320", Offset = "0x7DF5920", VA = "0x187DF7320")]
	public LFHGMFOOJJO(JBDCJHGBANL HJLDIJBMLBP, int GCEAIILIICM, [Optional] OutfitType? FAECJNDIOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7DF7250", Offset = "0x7DF5850", VA = "0x187DF7250", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7001C50", Offset = "0x7000250", VA = "0x187001C50")]
	public bool EDMPMAHEONJ(JBDCJHGBANL HJLDIJBMLBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7DF71D0", Offset = "0x7DF57D0", VA = "0x187DF71D0")]
	public bool JGCOOLFDKMC(OutfitType? FAECJNDIOBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7DF7130", Offset = "0x7DF5730", VA = "0x187DF7130", Slot = "4")]
	public bool Equals(LFHGMFOOJJO HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7DF7040", Offset = "0x7DF5640", VA = "0x187DF7040", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7DF7180", Offset = "0x7DF5780", VA = "0x187DF7180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct LMNKGJLIDKD : IEquatable<LMNKGJLIDKD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public readonly Transform HCNBMJPANKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public readonly bool NEHDMFEKJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public readonly JBDCJHGBANL OLBLIKLLINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public readonly OutfitType? IMLCOBAPEBC;

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7DF7900", Offset = "0x7DF5F00", VA = "0x187DF7900")]
	public LMNKGJLIDKD(Transform BBGDKDCBDON, bool PPOCAMOHLBM, JBDCJHGBANL KPPJFKDJPCO, [Optional] OutfitType? HHIGDKHMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7DF76F0", Offset = "0x7DF5CF0", VA = "0x187DF76F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7DF7490", Offset = "0x7DF5A90", VA = "0x187DF7490", Slot = "4")]
	public bool Equals(LMNKGJLIDKD HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7DF7590", Offset = "0x7DF5B90", VA = "0x187DF7590", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7DF7670", Offset = "0x7DF5C70", VA = "0x187DF7670", Slot = "2")]
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
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7DF07F0", Offset = "0x7DEEDF0", VA = "0x187DF07F0")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xA469E0", Offset = "0xA44FE0", VA = "0x180A469E0")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface ODCEOPCNFJE
{
	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IFODEOFHJDD(Mesh IDMOPPBKAAO, Matrix4x4 JBMNNBAGILM, byte[] JCEJGEIDOLJ, bool MIOJLNCIGOJ = false, OBJIGDJGKHB.MAHMKAHBAAB LFAFPBBBNFF = (OBJIGDJGKHB.MAHMKAHBAAB)0L, int KAIAGOOEGHC = -1, bool BIPJPIFPAGD = false);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FBOMCPAFPOD(Allocator HOHBLCPFIEJ, DBKKBPDPDDG KOIHPOECKLP, byte GHFDMOIKCAP, [Optional] IList<int> EEBINPNGNPM, [Optional] IList<int> MPCBKHJFDGC);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct EJIABBDOJCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public readonly GameObject LFOPPMFINLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	private readonly AvatarItemMaterial FONAMPOGIIA;

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xB8E8F0", Offset = "0xB8CEF0", VA = "0x180B8E8F0")]
	public EJIABBDOJCK(GameObject LFOPPMFINLB, AvatarItemMaterial FONAMPOGIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7DED200", Offset = "0x7DEB800", VA = "0x187DED200")]
	public void EMIJBADDEOF(Material KKIOJDIOKCM, int CLFIBGFKFKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class IJPDNHPLLIP : JLCFMPFODIO<Task<(GameObject, AvatarItemMaterial)>, EJIABBDOJCK>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct LEFHBKFPIBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x7DF6AD0", Offset = "0x7DF50D0", VA = "0x187DF6AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7DF6FD0", Offset = "0x7DF55D0", VA = "0x187DF6FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	private MODONOMENDG<GameObject> DNDFHEOEPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	private MODONOMENDG<AvatarItemMaterial> BAJFPPLKCNK;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7DF58A0", Offset = "0x7DF3EA0", VA = "0x187DF58A0")]
	private IJPDNHPLLIP(Task<(GameObject, AvatarItemMaterial)> NPLKHMALANM, MODONOMENDG<GameObject> CFJEPMNNLKL, MODONOMENDG<AvatarItemMaterial> HPOHOBDOMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7DF5480", Offset = "0x7DF3A80", VA = "0x187DF5480")]
	public static IJPDNHPLLIP MMBKOMPANAO(AssetReference ILABEHDFGDA, [Optional] AssetReference EJBILHFDION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7DF5230", Offset = "0x7DF3830", VA = "0x187DF5230", Slot = "11")]
	protected override EJIABBDOJCK CJAKMKBGKOP(Task<(GameObject, AvatarItemMaterial)> PPPKJJELICO)
	{
		return default(EJIABBDOJCK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7DF5400", Offset = "0x7DF3A00", VA = "0x187DF5400", Slot = "12")]
	protected override void LGNABDJFKGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x7DF52D0", Offset = "0x7DF38D0", VA = "0x187DF52D0")]
	[AsyncStateMachine(typeof(LEFHBKFPIBD))]
	private static Task<(GameObject, AvatarItemMaterial)> IENFGIOFCNL(Task<GameObject> JCHGIANEOFP, Task<AvatarItemMaterial> MJDOIAGAEHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class LCAOELIINNC
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class MIHHMMHIDOH : JLCFMPFODIO<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private MODONOMENDG<MaterialMapAsset> MNCGAKBHIPL;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9AC0", Offset = "0x7DF80C0", VA = "0x187DF9AC0")]
		public MIHHMMHIDOH(MODONOMENDG<MaterialMapAsset> MNCGAKBHIPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7DF95F0", Offset = "0x7DF7BF0", VA = "0x187DF95F0", Slot = "11")]
		protected override Material[] CJAKMKBGKOP(Task<MaterialMapAsset> NPLKHMALANM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9A60", Offset = "0x7DF8060", VA = "0x187DF9A60", Slot = "12")]
		protected override void LGNABDJFKGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class PPMBEFKJFGM : JLCFMPFODIO<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private List<MODONOMENDG<Material>> HKOOIOCCCHM;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7DFB0C0", Offset = "0x7DF96C0", VA = "0x187DFB0C0")]
		public PPMBEFKJFGM(Task<Material[]> NPLKHMALANM, List<MODONOMENDG<Material>> HKOOIOCCCHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAF30", Offset = "0x7DF9530", VA = "0x187DFAF30", Slot = "11")]
		protected override Material[] CJAKMKBGKOP(Task<Material[]> PPPKJJELICO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAF80", Offset = "0x7DF9580", VA = "0x187DFAF80", Slot = "12")]
		protected override void LGNABDJFKGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7DF6630", Offset = "0x7DF4C30", VA = "0x187DF6630")]
	public static MODONOMENDG<Material[]> KKBGCHPEJLP(AssetReference[] FBMIFOEOIPA)
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
		public enum IKAOODBAOGC
		{
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public enum NCOEHDJHOEB
		{
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public enum MGODOFHFFMM : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			All,
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct BACOKJPNJOE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public readonly Material PFNPFBIHOKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public readonly IKAOODBAOGC EOMABGCGKIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public readonly NCOEHDJHOEB DLICJLGMPEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public readonly JBDCJHGBANL PCKBLLJANJG;

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x7E0AD50", Offset = "0x7E09350", VA = "0x187E0AD50")]
			public BACOKJPNJOE(Material KKIOJDIOKCM, IKAOODBAOGC EHCDFLEKBJA, NCOEHDJHOEB CDIPADLEMDC, JBDCJHGBANL HJLDIJBMLBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x7E0AB30", Offset = "0x7E09130", VA = "0x187E0AB30", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x7E0AA10", Offset = "0x7E09010", VA = "0x187E0AA10")]
			public bool GLEOHFCONOB(BACOKJPNJOE HOPHFOOKMCC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x7E0A930", Offset = "0x7E08F30", VA = "0x187E0A930", Slot = "0")]
			public override bool Equals(object ODCICEDDLMB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x7E0AA90", Offset = "0x7E09090", VA = "0x187E0AA90", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		protected class MJCELCOKCIA : IComparable<MJCELCOKCIA>, IEquatable<MJCELCOKCIA>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			public int BBGLBEPBOOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			public PlayerAvatarDisplayBase GNDOFJNNOIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			public IList<GENNLBMNKLP> HEONCMICHMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			public AvatarItemBodyType PFGFJMBDOOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public CEKFBKJJEMI LMMAFHODFKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public bool GDCNIHADCND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public bool FCMEHGEPMAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			public int[] HIJOCDINLEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			public float PCEHILJIKLE;

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x7E11D80", Offset = "0x7E10380", VA = "0x187E11D80", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x7E11C30", Offset = "0x7E10230", VA = "0x187E11C30", Slot = "4")]
			public int CompareTo(MJCELCOKCIA HOPHFOOKMCC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x7E11C60", Offset = "0x7E10260", VA = "0x187E11C60", Slot = "5")]
			public bool Equals(MJCELCOKCIA HOPHFOOKMCC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public MJCELCOKCIA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		protected abstract class BFGDKBOPPNG
		{
			[Cpp2IlInjected.Token(Token = "0x200005C")]
			public class IIPOMNINHDG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400036A")]
				public readonly Mesh KHKOCHJIOML;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public readonly Material[] LLKFKOLCMDI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400036C")]
				public readonly Transform[] GGIJJACFPFO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400036D")]
				public readonly Matrix4x4[] LBDHJMHEGOL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400036E")]
				public readonly Transform BDLPEGAHIHF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400036F")]
				public readonly bool LAODFHAAOBJ;

				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
				protected IIPOMNINHDG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x7E0FC10", Offset = "0x7E0E210", VA = "0x187E0FC10")]
				public IIPOMNINHDG(Mesh IDMOPPBKAAO, Material[] CLOOAJPKHLI, bool HPHOAOFDEKI, Transform[] OCLGKPPKKKB, Transform IOPBFFNNGIK, Matrix4x4[] KGJPCGCACNG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0x7E100C0", Offset = "0x7E0E6C0", VA = "0x187E100C0")]
				private IIPOMNINHDG(SkinnedMeshRenderer EKNCBKALFCA, Material[] MMAEMLJCBBC)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0x7E0FB20", Offset = "0x7E0E120", VA = "0x187E0FB20")]
				private IIPOMNINHDG(MeshRenderer JAOLACJBPJJ, Transform IOPBFFNNGIK, Material[] MMAEMLJCBBC)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030B")]
				[Cpp2IlInjected.Address(RVA = "0x7E0F7F0", Offset = "0x7E0DDF0", VA = "0x187E0F7F0")]
				public static IIPOMNINHDG DOELCHBICLF(Renderer ILMDPGBOCFL, Material[] MMAEMLJCBBC)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			public readonly JBDCJHGBANL PCKBLLJANJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			public readonly Transform APKBPLKGALB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public readonly bool ONCEIODMMGG;

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual bool LKLJMJFCLLB
			{
				[Cpp2IlInjected.Token(Token = "0x6000300")]
				[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual bool POCDMBIOOHH
			{
				[Cpp2IlInjected.Token(Token = "0x6000301")]
				[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual OBJIGDJGKHB.MAHMKAHBAAB JBKIGDJGCJD
			{
				[Cpp2IlInjected.Token(Token = "0x6000302")]
				[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "6")]
				get
				{
					return default(OBJIGDJGKHB.MAHMKAHBAAB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public bool BCKBALNJFPF
			{
				[Cpp2IlInjected.Token(Token = "0x6000303")]
				[Cpp2IlInjected.Address(RVA = "0x7E0AD90", Offset = "0x7E09390", VA = "0x187E0AD90")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x7E0ADA0", Offset = "0x7E093A0", VA = "0x187E0ADA0")]
			protected BFGDKBOPPNG(JBDCJHGBANL HJLDIJBMLBP, Transform NJLNDKLJMMF, bool FBMGNMMMFIP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract NCBJFOCOMOJ OOHDFIHLHOM(List<DKAHIDLCKHM> LKGPFFLJKIF, List<DKAHIDLCKHM> OFGAEIENHKG);

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract IIPOMNINHDG ABMGHOAEOEM(int CLFLCICHDCN, PlayerHandBones GGLNPGNPCEM);
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected class ADCMDOBAEMC : BFGDKBOPPNG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			protected readonly BodyPartLODs KGENLIKADIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			protected readonly Material[] IICLIPKOMBE;

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x7E0A630", Offset = "0x7E08C30", VA = "0x187E0A630")]
			public ADCMDOBAEMC(JBDCJHGBANL HJLDIJBMLBP, BodyPartLODs PJBGEBKLMKL, Material MDPLHDBFKKF, [Optional] Transform NJLNDKLJMMF, bool FBMGNMMMFIP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x7E0A530", Offset = "0x7E08B30", VA = "0x187E0A530", Slot = "7")]
			public override NCBJFOCOMOJ OOHDFIHLHOM(List<DKAHIDLCKHM> LKGPFFLJKIF, List<DKAHIDLCKHM> OFGAEIENHKG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x7E0A370", Offset = "0x7E08970", VA = "0x187E0A370", Slot = "8")]
			public override IIPOMNINHDG ABMGHOAEOEM(int CLFLCICHDCN, PlayerHandBones GGLNPGNPCEM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x7E0A5C0", Offset = "0x7E08BC0", VA = "0x187E0A5C0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		protected class KKMHLAPLAKC : BFGDKBOPPNG
		{
			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public override bool LKLJMJFCLLB
			{
				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public override bool POCDMBIOOHH
			{
				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x7E119F0", Offset = "0x7E0FFF0", VA = "0x187E119F0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public ALNFLEBPLME CHIPINHDKNA
			{
				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x7E11B40", Offset = "0x7E10140", VA = "0x187E11B40")]
			public KKMHLAPLAKC(JBDCJHGBANL HJLDIJBMLBP, Transform NJLNDKLJMMF, ALNFLEBPLME DKCGFDJNJOO, bool FBMGNMMMFIP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x7E11A40", Offset = "0x7E10040", VA = "0x187E11A40", Slot = "7")]
			public override NCBJFOCOMOJ OOHDFIHLHOM(List<DKAHIDLCKHM> LKGPFFLJKIF, List<DKAHIDLCKHM> OFGAEIENHKG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "8")]
			public override IIPOMNINHDG ABMGHOAEOEM(int CLFLCICHDCN, PlayerHandBones GGLNPGNPCEM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x7E11AD0", Offset = "0x7E100D0", VA = "0x187E11AD0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public class BNFJIKPADKJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000060")]
			public enum EEJLPGBFIGG
			{
				[Cpp2IlInjected.Token(Token = "0x4000383")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x4000384")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x4000385")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x4000386")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x4000387")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x4000388")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x4000389")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public static readonly int LAHEPDCNKBP;

			[Cpp2IlInjected.Token(Token = "0x4000374")]
			public static readonly int COEELOJCINH;

			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public static readonly int MBNCOMIDOOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			protected readonly KDJOKHKGLOC DMPIGNNFCJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			protected readonly MCCEFIPINHJ HGKCKNJJEMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			protected readonly Animator BILEAABOBJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			protected readonly Transform ELMJKINDBIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public Vector3 CINDOEPEMEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			protected readonly Transform OHJKLBOLBNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			public Vector3 HCPIHNLNPHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			protected bool PPINPFFBABO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			protected BNINFAJBEOF FACJIAMHPJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			protected bool OCDDHFGOANH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			protected float MBPBJBEDOKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			protected MBHNGAIONMF<OBAGOEPBKCD> CDMJOFGPLCD;

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public BNINFAJBEOF ENAINLICLBA
			{
				[Cpp2IlInjected.Token(Token = "0x6000318")]
				[Cpp2IlInjected.Address(RVA = "0xA44970", Offset = "0xA42F70", VA = "0x180A44970")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000319")]
				[Cpp2IlInjected.Address(RVA = "0xA449B0", Offset = "0xA42FB0", VA = "0x180A449B0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public bool LNFKECLNLII
			{
				[Cpp2IlInjected.Token(Token = "0x600031A")]
				[Cpp2IlInjected.Address(RVA = "0xCBDA20", Offset = "0xCBC020", VA = "0x180CBDA20")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600031B")]
				[Cpp2IlInjected.Address(RVA = "0x7E0DC80", Offset = "0x7E0C280", VA = "0x187E0DC80")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public bool FICFHMBDAMF
			{
				[Cpp2IlInjected.Token(Token = "0x600031C")]
				[Cpp2IlInjected.Address(RVA = "0xA50DF0", Offset = "0xA4F3F0", VA = "0x180A50DF0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x7E0E280", Offset = "0x7E0C880", VA = "0x187E0E280")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public float LIKJMKKLDEF
			{
				[Cpp2IlInjected.Token(Token = "0x600031E")]
				[Cpp2IlInjected.Address(RVA = "0xD384E0", Offset = "0xD36AE0", VA = "0x180D384E0")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600031F")]
				[Cpp2IlInjected.Address(RVA = "0x7E0DD50", Offset = "0x7E0C350", VA = "0x187E0DD50")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public OBAGOEPBKCD ALMAINLLNGP
			{
				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0x7E0DFC0", Offset = "0x7E0C5C0", VA = "0x187E0DFC0")]
				get
				{
					return default(OBAGOEPBKCD);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x7E0E000", Offset = "0x7E0C600", VA = "0x187E0E000")]
			public bool HIBNNIOHJLG(OBAGOEPBKCD ACBJLKJPPOO, object DKFMAIJGPFL, EEJLPGBFIGG FKHLDNNBKMB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x7E0D8C0", Offset = "0x7E0BEC0", VA = "0x187E0D8C0")]
			public bool AOOPIOMBOCO(object DKFMAIJGPFL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x7E0E560", Offset = "0x7E0CB60", VA = "0x187E0E560")]
			protected BNFJIKPADKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x7E0E5F0", Offset = "0x7E0CBF0", VA = "0x187E0E5F0")]
			public BNFJIKPADKJ(KDJOKHKGLOC DMPIGNNFCJP, BNINFAJBEOF CONGFPOPBMC, Animator BILEAABOBJC, Transform ELMJKINDBIJ, Transform OHJKLBOLBNJ, Vector3 CINDOEPEMEG, Vector3 HCPIHNLNPHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x7E0DBD0", Offset = "0x7E0C1D0", VA = "0x187E0DBD0")]
			private void FFIMEFLGGOH(ushort BFFCDFMAKHM, ushort DKMKBFAAACM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x7E0D9C0", Offset = "0x7E0BFC0", VA = "0x187E0D9C0")]
			protected void BJMEHDOPPKG(ushort BFFCDFMAKHM, ushort DKMKBFAAACM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x7E0E110", Offset = "0x7E0C710", VA = "0x187E0E110")]
			protected void JBPNFNGKJIG(ushort BFFCDFMAKHM, ushort DKMKBFAAACM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x7E0DE90", Offset = "0x7E0C490", VA = "0x187E0DE90")]
			protected void HDFGKDMOAPL(ushort BFFCDFMAKHM, ushort DKMKBFAAACM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x7E0E3A0", Offset = "0x7E0C9A0", VA = "0x187E0E3A0")]
			protected void OAPNGNEEOII(ushort BFFCDFMAKHM, ushort DKMKBFAAACM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x7E0E1D0", Offset = "0x7E0C7D0", VA = "0x187E0E1D0")]
			protected void JLJHLJKDGJP(ushort BFFCDFMAKHM, ushort DKMKBFAAACM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x7E0E230", Offset = "0x7E0C830", VA = "0x187E0E230")]
			protected void KIHACNNEJKE(ushort BFFCDFMAKHM, ushort DKMKBFAAACM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x7E0E350", Offset = "0x7E0C950", VA = "0x187E0E350")]
			protected void NNKNDDLCEIC(ushort BFFCDFMAKHM, ushort DKMKBFAAACM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x7E0DAB0", Offset = "0x7E0C0B0", VA = "0x187E0DAB0")]
			protected void BLFJHMIIKHL(ushort BFFCDFMAKHM, ushort DKMKBFAAACM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public class BHPOPANNDJM : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public const int LBLEAGMOEEM = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			protected MaterialPropertyBlock BGBCLJMEKBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			public Color? JDLMGNIPBJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public Color? OMHAMIMHAAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public Color? MGNEIEEBJPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public Color HIMCCCJOMIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			public Color PONPCLJJKGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public Color FKFJLPMMJHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			public Texture2D BHOJCLBHPJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			public Texture2D EDOHOLLIDDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			protected Dictionary<BACOKJPNJOE, int> PEKKOAHHCKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected IKAOODBAOGC[] EBBIMHLOMOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public Vector4[] DIKJJJHCNMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			public Vector4[] GAPINNJBCHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public Vector4[] KGNLBFGHOIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			public Vector4[] ONLODGCFGLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			public Vector4[] KEOMFJEEMLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			public Vector4[] INDLNEMICEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			protected List<Texture2D> KABMILJDFGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			protected Vector4[] DGOFLAJAHHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			protected List<Texture2D> LNADPEDLCHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			protected float[] BINDJDOBPFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			protected Vector4[] PCPGGPAJNML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			protected float[] NNAOFCKLGHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public float[] IPOEOKOPANE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			protected List<Texture2D> MLFHMMHHABF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			protected float[] OCPHOKFJGJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			protected List<Texture2D> LNCJJJNDPPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected Vector4[] GAAPHIBOFDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected float[] KKLAJGAJFFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected Vector4[] DJKODDAIDEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			public float[] OGKGNGDFKNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			public Texture2DArray ODOOCCJANIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			public Texture2DArray LBCINCDPGNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public Texture2DArray LEDNIEIPNFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public Texture2DArray AHNCICLPFEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected bool BEFCDFFLEMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected int ICFFGLHDFIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected Vector2? DCMNCIDFIKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected TextureFormat ELIGNCNJBIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected Vector2? NONCMOLGNIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			protected TextureFormat GBNMMHJNCCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			protected Vector2? FMGFONIFIEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			protected TextureFormat EOLIJEJNFKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			protected Vector2? NILGGPNBNJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			protected TextureFormat FMAPOABOGKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			protected bool IPJFEJDAGIO;

			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			protected static int DEOAHOLNILO;

			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			protected static int AOJDCHBEECE;

			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			protected static int HPKANEDEJME;

			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			protected static int GKCLMPIFKMG;

			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			protected static int HFANNOAFCNM;

			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			protected static int HGOHNAMMHDP;

			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			protected static int CIFEIMOJNFL;

			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			protected static int PMPECOLNBMP;

			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			protected static int HGJAAFKNHBL;

			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			protected static int LNBMAMKBLHG;

			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			protected static int MDIEIJKAGLL;

			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			protected static int KPFFMLKHBNP;

			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			protected static int FHBJKABPBLN;

			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			protected static int LCJJOEBHHMG;

			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			protected static int KOLGDGMBEHA;

			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			protected static int FMIOHPKGHKM;

			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			protected static int OGKBPKBDJMG;

			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			protected static int INOEBBIJLMJ;

			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			protected static int EFNFFHPPLFB;

			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			protected static int MBONLMFEIJK;

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x7E0D400", Offset = "0x7E0BA00", VA = "0x187E0D400")]
			protected BHPOPANNDJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x7E0D370", Offset = "0x7E0B970", VA = "0x187E0D370")]
			public BHPOPANNDJM(Color FIJDMNMPGHM, Color KFIDCOLNOCB, Color FPBMICLIMJB, Color? OKLIJLKFIMJ, Color? JLFPMKLELHK, Color? FCANCBHBMJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x7E0B270", Offset = "0x7E09870", VA = "0x187E0B270")]
			public int FMJDBMMPMIK(Material HIGLCLFFAAN, IKAOODBAOGC EHCDFLEKBJA, NCOEHDJHOEB CDIPADLEMDC, JBDCJHGBANL HJLDIJBMLBP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x7E0B1E0", Offset = "0x7E097E0", VA = "0x187E0B1E0")]
			public int FMJDBMMPMIK(BACOKJPNJOE BLIBAMJKLIA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x7E0C2E0", Offset = "0x7E0A8E0", VA = "0x187E0C2E0")]
			public int OEPPMDMHGLE(Material HIGLCLFFAAN, Color FOMOELHFPBG, Color INNHEMAMHEM, Color AEEOAGNMNHG, Color EEBEFNFHMBG, Color AKFDBDMHAII, Texture2D DIKCMEHHEKP, Vector4 BBFBBKIAMIA, Texture2D OOPOMEJJMJO, Vector4 PFOAAGGGNDA, float HFJPCEKDMDE, float JOEAMPOJEJP, Texture2D AEBKNABMGBJ, Vector4 OEMGMCKPHMD, float OADEIELBGEE, Texture2D EEIHPANJGIA, float FHJEKEEOENM, Color JOBNAMBEOML, Vector4 JKDPCGJEBDG, IKAOODBAOGC EHCDFLEKBJA, NCOEHDJHOEB CDIPADLEMDC, JBDCJHGBANL HJLDIJBMLBP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x7E0AFE0", Offset = "0x7E095E0", VA = "0x187E0AFE0")]
			protected void DGFPBBCBDCE([Out] Texture2DArray KLLKEJGJIIG, [Out] Texture2DArray OLCJENDDFKA, [Out] Texture2DArray CAHLILIHEKB, [Out] Texture2DArray NEHDFOEFANL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x7E0C070", Offset = "0x7E0A670", VA = "0x187E0C070")]
			public void NGNLNDGEOEH(PlayerAvatarDisplayBase GCDJJNCONCH, Renderer ILMDPGBOCFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x7E0B550", Offset = "0x7E09B50", VA = "0x187E0B550")]
			protected void JPAFLFFIKGP(PlayerAvatarDisplayBase GCDJJNCONCH, Renderer ILMDPGBOCFL, int MDOGGIKNFMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x7E0B360", Offset = "0x7E09960", VA = "0x187E0B360")]
			private Color HBGJHIINAOK(Color EJJKPDIEADP, IKAOODBAOGC BHICLEPCKCK)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x7E0AE90", Offset = "0x7E09490", VA = "0x187E0AE90")]
			private Color DEEJBIJILGI(Color EEEOKFPABFL, IKAOODBAOGC BHICLEPCKCK)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x7E0AE00", Offset = "0x7E09400", VA = "0x187E0AE00")]
			protected void AFCPHOGLNNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x7E0B1A0", Offset = "0x7E097A0", VA = "0x187E0B1A0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x7E19190", Offset = "0x7E17790", VA = "0x187E19190")]
			public void MGDFKICAMAI(JBDCJHGBANL HJLDIJBMLBP, [Out] Transform CMAFOEIBEKN, [Out] Transform[] OCLGKPPKKKB)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class JKOLFCIBNNK : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600034A")]
				[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0xF4E730", Offset = "0xF4CD30", VA = "0x180F4E730")]
			[DebuggerHidden]
			public JKOLFCIBNNK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x7E10BC0", Offset = "0x7E0F1C0", VA = "0x187E10BC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x7E10E40", Offset = "0x7E0F440", VA = "0x187E10E40", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x7E10D90", Offset = "0x7E0F390", VA = "0x187E10D90", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x7E10D90", Offset = "0x7E0F390", VA = "0x187E10D90", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class POAEFEJHLEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public POAEFEJHLEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x7E12600", Offset = "0x7E10C00", VA = "0x187E12600")]
			internal bool OIMHKJKJKMK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class JCAKOAOMGHL : IEnumerator<HPILNDONOCO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			private HPILNDONOCO <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			private HPILNDONOCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000352")]
				[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000354")]
				[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
			[DebuggerHidden]
			public JCAKOAOMGHL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x7E10180", Offset = "0x7E0E780", VA = "0x187E10180", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x7E104D0", Offset = "0x7E0EAD0", VA = "0x187E104D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private struct JPJMHILFJBJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			public JMOEBMFNCHJ avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x7E110A0", Offset = "0x7E0F6A0", VA = "0x187E110A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x7E11440", Offset = "0x7E0FA40", VA = "0x187E11440", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class GMNOAMONPEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public GMNOAMONPEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x7E0F710", Offset = "0x7E0DD10", VA = "0x187E0F710")]
			internal bool FLPKGKHGEKI(GENNLBMNKLP selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class ODPEEMJIIEB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public Func<EHBLMFNEKIG<Dictionary<string, MODONOMENDG<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public ODPEEMJIIEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x7E12390", Offset = "0x7E10990", VA = "0x187E12390")]
			internal (BKFKILCGELM, EHBLMFNEKIG<Dictionary<string, MODONOMENDG<Texture2D>>>) IBOFOHEHLMK(Dictionary<string, JOHGPLIHENP> avatarItems)
			{
				return default((BKFKILCGELM, EHBLMFNEKIG<Dictionary<string, MODONOMENDG<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x7E12590", Offset = "0x7E10B90", VA = "0x187E12590")]
			internal EHBLMFNEKIG<Dictionary<string, MODONOMENDG<Texture2D>>> ILGDDCKIMCJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x7E12350", Offset = "0x7E10950", VA = "0x187E12350")]
			internal void HACGPJFLHFN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class HGDIEAEBHLC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public HGDIEAEBHLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x7E0F740", Offset = "0x7E0DD40", VA = "0x187E0F740")]
			internal bool EPBKLPFHCII(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private struct GFCIPCHEFNF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x7E0F4E0", Offset = "0x7E0DAE0", VA = "0x187E0F4E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x7E0F6B0", Offset = "0x7E0DCB0", VA = "0x187E0F6B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		protected static readonly int EKAJLFDJPNC;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		protected static readonly int FLLBDAANNLD;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		protected static readonly int GLDFMLFJCOE;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		protected static readonly int LGBOGHEFGEI;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		protected static readonly int BAFLONGDDAO;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		protected static readonly int POPDHDMHIPD;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		protected static readonly int[] EIAOMFIGFNC;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		protected static readonly int[] DPGGOAOPNAF;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		protected static readonly int[] ONMFEJDNKFB;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		protected static readonly int[] BNNAFMBLMIM;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		protected static readonly int[] GKJEAGIDAAP;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		protected static readonly int[] HENFHOFBFPJ;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		protected static List<PlayerAvatarDisplayBase> DJFGABBIMAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		protected JNNECLPJAPF CHINFEAPHNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		protected bool FFFLHHEAJCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		protected bool HAHKAOFCDDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		protected static readonly int[] HEEHFGALKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		protected Dictionary<BACOKJPNJOE, Material> CNBNCAMOBHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		protected Dictionary<BACOKJPNJOE, Material> BNCFBEKPAFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		[SerializeField]
		public Transform remoteMeshBase;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		protected Material OPNAKJLFHKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		protected ABICHDKCLFP NIMKIDOFEHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private BNINFAJBEOF JDMOBBJOJBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private BNINFAJBEOF PIDNDMDHDKL;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		protected Material PMOLELNEJME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		[SerializeField]
		public Transform hemisphereBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		protected FitMeshHemisphere DGOLDKIFDPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected bool ABFLOGHOHCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected AFNDLFBCDPE LJJFKOFOCBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		protected bool PCCBIIFLHIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		protected AnchorParamsRestrictions DFBBHKFIKAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		protected bool NEDGDEELIAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		protected Transform KPAANBNONBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		protected bool IILNBNDPMGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B1")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		protected bool NOEHBPIEMKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		protected Vector3 PJGDIHLFNMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		protected Quaternion LPJEPNLKNEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		protected Vector2 GJFCGNLPJMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		protected FitMeshHemisphere KJCHGIBBGFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		[SerializeField]
		[DOIDGFGIDBO(CNNBEEFOMHL.SelfAndChildren, false, false, false)]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		protected Collider[] PBHPPALPEHD;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		protected Collider[] DMIIKJICCDD;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		protected BNFJIKPADKJ[] MNFFJPMLICC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public Dictionary<Renderer, BHPOPANNDJM> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected Dictionary<Renderer, BHPOPANNDJM> PNPAIBCHMFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		protected KPANOABCFDC GFDPHFECION;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected BKFKILCGELM MMALGLLOMKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public LNDADOOHAMM DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		protected int IHGBFECCOCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected (bool isLodForced, int forcedLOD) OCMLIIBJBJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected MBHNGAIONMF<MCCEFIPINHJ> CDMJOFGPLCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected bool HLHCEDMAENE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected Dictionary<GENNLBMNKLP, List<BACOKJPNJOE>> NDFHCKPNAKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected Dictionary<GENNLBMNKLP, List<BACOKJPNJOE>> AGGBNHBDMHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected readonly Dictionary<string, MODONOMENDG<Texture2D>> GNAAIHKMDAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected readonly Dictionary<string, MODONOMENDG<Texture2D>> OIODOJPLLCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected bool JCDMPJDEPEN;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected static int KAJNJPLOJPC;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected static List<MJCELCOKCIA> MCKKGFEGFPE;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected static List<MJCELCOKCIA> ADGFCHBKFBI;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		protected static LLKKGNCPLNM PAGEHLCOONM;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		protected static Func<List<MJCELCOKCIA>, MJCELCOKCIA> KIAHFHILIEH;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		protected static bool OOKCLGOCNLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		protected Color? MDNKBGJPKNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		protected bool EHLEGLIPEAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		protected Color MGEMOJNMKAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		protected Color HMMGLHFNNEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		protected Color KCNNFDGJLBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		protected AvatarHairPattern FLAILCGGCPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		protected ALNFLEBPLME PHOKDLANPKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected Color LKFHBCAJFAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected Color KKEHBPHHONA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected AvatarHairPattern FFDJKFCJBCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected ALNFLEBPLME ABFKNCFGGLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		protected ALNFLEBPLME LJLDJBLCMKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		protected Color FABBANAEMMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private AdditionalFeetData MABBIPMMFNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected GENNLBMNKLP? MOIJLBENBJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		protected Texture MHDIJIBCKOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		protected Color IHICGLBOGIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		protected readonly IList<GENNLBMNKLP> MFAINKKJIGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		protected readonly IList<GENNLBMNKLP> CBCEMFBEEGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private AvatarItemBodyType FNEFNGFCPNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		[SerializeField]
		protected DPMPLKEDIBP _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D5")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		protected MGODOFHFFMM PCGBDDPGDKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		protected int[] CEMCPFEFJLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		protected bool BJMNAGCOCNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		protected int[] FFOINOPJNPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		protected bool DNNMCPDFLAJ;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private static readonly OBJIGDJGKHB.MAHMKAHBAAB BOHCNACBHLA;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private static readonly OBJIGDJGKHB.MAHMKAHBAAB BIODNJIAOEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F1")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		protected bool MBNICIBBJJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		protected FDMHDGANLHD KCGCAKGDEID;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string FMHMEKKDMNE
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0xA50E00", Offset = "0xA4F400", VA = "0x180A50E00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool HFDNHOBLHBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0xCB76A0", Offset = "0xCB5CA0", VA = "0x180CB76A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xCB6DE0", Offset = "0xCB53E0", VA = "0x180CB6DE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool GBCHIKLGPFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool BMEIMFAEKFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x7E08D10", Offset = "0x7E07310", VA = "0x187E08D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool KONNHODDHDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool FMFGKHHMBBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual bool FOAAELJBPCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual bool NHBJBFFBCBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public ABICHDKCLFP CMKKHJNEBBI
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xB5C6A0", Offset = "0xB5ACA0", VA = "0x180B5C6A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x7E094E0", Offset = "0x7E07AE0", VA = "0x187E094E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public BNINFAJBEOF MLGHPNPGFNA
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xB5E6D0", Offset = "0xB5CCD0", VA = "0x180B5E6D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x7E098E0", Offset = "0x7E07EE0", VA = "0x187E098E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public BNINFAJBEOF OIPLBKOGFHD
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xB72A80", Offset = "0xB71080", VA = "0x180B72A80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x7E09BB0", Offset = "0x7E081B0", VA = "0x187E09BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		protected Material KCPKDLACODP
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD800", Offset = "0x7DFBE00", VA = "0x187DFD800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		protected Material NLCNIGAFCHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x7DFC770", Offset = "0x7DFAD70", VA = "0x187DFC770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool PDHLLJACINA
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x12B2EB0", Offset = "0x12B14B0", VA = "0x1812B2EB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public PlayerFacialAnimatorBase PDNJIMAJLEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0xB72C80", Offset = "0xB71280", VA = "0x180B72C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public BNFJIKPADKJ[] OEOLPONHFKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x7E08890", Offset = "0x7E06E90", VA = "0x187E08890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public BNFJIKPADKJ ACDOKOGNDKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x7E08F10", Offset = "0x7E07510", VA = "0x187E08F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public BNFJIKPADKJ FHEAEPGOPDH
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x7E08F50", Offset = "0x7E07550", VA = "0x187E08F50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Mesh BBLKKLBIOPD
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xB733D0", Offset = "0xB719D0", VA = "0x180B733D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected KPANOABCFDC BCDDDACKJIG
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x7DFC750", Offset = "0x7DFAD50", VA = "0x187DFC750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		protected BKFKILCGELM MGOKHMOJFLC
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0xB73760", Offset = "0xB71D60", VA = "0x180B73760")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x7E03460", Offset = "0x7E01A60", VA = "0x187E03460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		protected bool KPMAPIHLPNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool MBNECNHODKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x7E08F00", Offset = "0x7E07500", VA = "0x187E08F00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public int BLHODIIHDGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x7E08F40", Offset = "0x7E07540", VA = "0x187E08F40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x7E09AF0", Offset = "0x7E080F0", VA = "0x187E09AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public int KEFIEOBHGFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x7E09830", Offset = "0x7E07E30", VA = "0x187E09830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected virtual bool KDNJLDAFBJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected virtual int[] OKPGNPLIJNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x7E03F80", Offset = "0x7E02580", VA = "0x187E03F80", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		protected bool NGCGIFLFMED
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x7DFCA60", Offset = "0x7DFB060", VA = "0x187DFCA60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		protected static bool IAGPGLDKGFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool AAMFILGANPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x12B3030", Offset = "0x12B1630", VA = "0x1812B3030")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x7E09DC0", Offset = "0x7E083C0", VA = "0x187E09DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public IEnumerable<SkinnedMeshRenderer> OIGJBKLIDJG
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x7E08710", Offset = "0x7E06D10", VA = "0x187E08710")]
			[IteratorStateMachine(typeof(JKOLFCIBNNK))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool ICKKICKDNIH
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x12B4B60", Offset = "0x12B3160", VA = "0x1812B4B60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x12B4A50", Offset = "0x12B3050", VA = "0x1812B4A50")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public IJIIPECBIPC EDLPPLCPCPC
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x7E08790", Offset = "0x7E06D90", VA = "0x187E08790")]
			get
			{
				return default(IJIIPECBIPC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public static bool LCMPLHBBCLL
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x7E08C40", Offset = "0x7E07240", VA = "0x187E08C40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected static LLKKGNCPLNM CDKIPODCIMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x7E03DC0", Offset = "0x7E023C0", VA = "0x187E03DC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x7E01530", Offset = "0x7DFFB30", VA = "0x187E01530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected Color OMHAMIMHAAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x7E01D00", Offset = "0x7E00300", VA = "0x187E01D00")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected Color MGNEIEEBJPK
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x7E00070", Offset = "0x7DFE670", VA = "0x187E00070")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected Texture2D PAKDGEDANGB
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x7E01DF0", Offset = "0x7E003F0", VA = "0x187E01DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Color HIMCCCJOMIA
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x7E08840", Offset = "0x7E06E40", VA = "0x187E08840")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		protected Color PONPCLJJKGB
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x7E02100", Offset = "0x7E00700", VA = "0x187E02100")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public ALNFLEBPLME OHNPEOIKEFF
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x7E08800", Offset = "0x7E06E00", VA = "0x187E08800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		protected Texture2D DINAIHIHAGO
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x7E000C0", Offset = "0x7DFE6C0", VA = "0x187E000C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public float EFIJPOGAHKC
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x7E08820", Offset = "0x7E06E20", VA = "0x187E08820")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public float NJABPCNIKHH
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x7E08CF0", Offset = "0x7E072F0", VA = "0x187E08CF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public bool KPPEOEPGODH
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x7E087F0", Offset = "0x7E06DF0", VA = "0x187E087F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x7E092C0", Offset = "0x7E078C0", VA = "0x187E092C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action CFJOAGIPKKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x7E08470", Offset = "0x7E06A70", VA = "0x187E08470")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x7E09020", Offset = "0x7E07620", VA = "0x187E09020")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action DIDECFPHAOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x7E083D0", Offset = "0x7E069D0", VA = "0x187E083D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x7E08F80", Offset = "0x7E07580", VA = "0x187E08F80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action NHJFMMOPHKE
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x7E08510", Offset = "0x7E06B10", VA = "0x187E08510")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x7E090C0", Offset = "0x7E076C0", VA = "0x187E090C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action GNPNNEFPDBI
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x7E085B0", Offset = "0x7E06BB0", VA = "0x187E085B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x7E09160", Offset = "0x7E07760", VA = "0x187E09160")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<KDJOKHKGLOC, OBAGOEPBKCD> LGPCNKHPPBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x7E08650", Offset = "0x7E06C50", VA = "0x187E08650")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x7E09200", Offset = "0x7E07800", VA = "0x187E09200")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7E04C40", Offset = "0x7E03240", VA = "0x187E04C40")]
		public bool SetDeformation(bool FFFLHHEAJCM, bool HAHKAOFCDDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7DFFB00", Offset = "0x7DFE100", VA = "0x187DFFB00")]
		protected static Material GHAKIHJHIEB(Dictionary<BACOKJPNJOE, Material> LFHGHHIGDEC, Material FAHPLAEEHAB, IKAOODBAOGC EHCDFLEKBJA, NCOEHDJHOEB CDIPADLEMDC, JBDCJHGBANL HJLDIJBMLBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE590", Offset = "0x7DFCB90", VA = "0x187DFE590")]
		protected void FGHEIBECBIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7E01EE0", Offset = "0x7E004E0", VA = "0x187E01EE0")]
		protected bool MBCOFDBGAKJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE500", Offset = "0x7DFCB00", VA = "0x187DFE500")]
		protected void FEABBEFAKHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x7E025F0", Offset = "0x7E00BF0", VA = "0x187E025F0", Slot = "11")]
		protected virtual void MOGHJEOJNNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7E02810", Offset = "0x7E00E10", VA = "0x187E02810")]
		public int MeshesAtLODCount(int LLJPGDKJGCL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7E02D20", Offset = "0x7E01320", VA = "0x187E02D20")]
		protected static void NGIECGAGFAB(Dictionary<GENNLBMNKLP, List<BACOKJPNJOE>> DIJLOLAHCLM, BFGDKBOPPNG MGHDCBNOPBP, Material FAHPLAEEHAB, IKAOODBAOGC BHICLEPCKCK, NCOEHDJHOEB LOHOACKBKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7DFBD90", Offset = "0x7DFA390", VA = "0x187DFBD90")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7E01930", Offset = "0x7DFFF30", VA = "0x187E01930")]
		protected void KMDKCLPCLIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7E03730", Offset = "0x7E01D30", VA = "0x187E03730")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "12")]
		protected virtual void PIKENHAFEHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7E023D0", Offset = "0x7E009D0", VA = "0x187E023D0")]
		protected static void MKAEAMPLBPK(List<Material> IOJKPAOJJHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7DFFD80", Offset = "0x7DFE380", VA = "0x187DFFD80")]
		protected static void GMHKBIGEPNP(Dictionary<BACOKJPNJOE, Material> LFHGHHIGDEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7DFB370", Offset = "0x7DF9970", VA = "0x187DFB370")]
		protected static void AFFBHLOBAPL(Dictionary<Renderer, BHPOPANNDJM> BDAGPKPNGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7E03CA0", Offset = "0x7E022A0", VA = "0x187E03CA0")]
		protected void PDHEDKHKLCO(SkinnedMeshRenderer[] CJNAOODGNBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE6B0", Offset = "0x7DFCCB0", VA = "0x187DFE6B0")]
		protected void FOAGMPJDKJG(SkinnedMeshRenderer EKNCBKALFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE750", Offset = "0x7DFCD50", VA = "0x187DFE750")]
		protected void FOAGMPJDKJG(MeshRenderer JAOLACJBPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD630", Offset = "0x7DFBC30", VA = "0x187DFD630")]
		protected void DPMDAGPPACJ(List<DKAHIDLCKHM> CNJDGLEKAPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE330", Offset = "0x7DFC930", VA = "0x187DFE330")]
		protected void EMDHAABBHAN(Dictionary<string, MODONOMENDG<Texture2D>> DIJLOLAHCLM, bool KPKGGGLDHMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x7E00870", Offset = "0x7DFEE70", VA = "0x187E00870")]
		protected void IFADHGEJJKB(Dictionary<GENNLBMNKLP, List<BACOKJPNJOE>> DIJLOLAHCLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7DFFF70", Offset = "0x7DFE570", VA = "0x187DFFF70")]
		public float GetHandOpenClosedAxis(KDJOKHKGLOC DMPIGNNFCJP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7E054D0", Offset = "0x7E03AD0", VA = "0x187E054D0")]
		public void SetHandOpenClosedAxis(KDJOKHKGLOC DMPIGNNFCJP, float LLFKNOLFNHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7DFFFB0", Offset = "0x7DFE5B0", VA = "0x187DFFFB0")]
		public OBAGOEPBKCD GetHandVisualState(KDJOKHKGLOC DMPIGNNFCJP)
		{
			return default(OBAGOEPBKCD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7DFB4D0", Offset = "0x7DF9AD0", VA = "0x187DFB4D0")]
		public bool AddHandVisualStateToken(KDJOKHKGLOC DMPIGNNFCJP, OBAGOEPBKCD BLFHCMJFJBK, object DKFMAIJGPFL, BNFJIKPADKJ.EEJLPGBFIGG FKHLDNNBKMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7E06D50", Offset = "0x7E05350", VA = "0x187E06D50")]
		public void SetWatchHand(KDJOKHKGLOC DMPIGNNFCJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x7E06E10", Offset = "0x7E05410", VA = "0x187E06E10")]
		public void SetWatchHands(bool JLKOACEEEEH, bool LLGMBJMBFEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7E04300", Offset = "0x7E02900", VA = "0x187E04300")]
		public bool RemoveHandVisualStateToken(KDJOKHKGLOC DMPIGNNFCJP, object DKFMAIJGPFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7E00030", Offset = "0x7DFE630", VA = "0x187E00030")]
		public bool GetThumbsUpActive(KDJOKHKGLOC DMPIGNNFCJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7E06760", Offset = "0x7E04D60", VA = "0x187E06760")]
		public void SetThumbsUpActive(KDJOKHKGLOC DMPIGNNFCJP, bool LCNPGDOFAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7DFFFF0", Offset = "0x7DFE5F0", VA = "0x187DFFFF0")]
		public bool GetHandshakeActive(KDJOKHKGLOC DMPIGNNFCJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7E05520", Offset = "0x7E03B20", VA = "0x187E05520")]
		public void SetHandshakeActive(KDJOKHKGLOC DMPIGNNFCJP, bool GNCIOPANICI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7DFFA20", Offset = "0x7DFE020", VA = "0x187DFFA20")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7E06C40", Offset = "0x7E05240", VA = "0x187E06C40")]
		public void SetUseClassicBeanHandScale(bool KKGBKLFKCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD130", Offset = "0x7DFB730", VA = "0x187DFD130")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7E026E0", Offset = "0x7E00CE0", VA = "0x187E026E0")]
		private static void MOJAHIPBOHK(Scene EOECEDBNACA, LoadSceneMode HMNPOEHONDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7E035D0", Offset = "0x7E01BD0", VA = "0x187E035D0")]
		protected static void OOHEOLKLAPK(PlayerAvatarDisplayBase FNOJJAOGEDK, List<MJCELCOKCIA> AKLNCODJBDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7E04010", Offset = "0x7E02610", VA = "0x187E04010")]
		public NCBJFOCOMOJ Rebuild(bool APNCLCAEBCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7E017A0", Offset = "0x7DFFDA0", VA = "0x187E017A0")]
		protected NCBJFOCOMOJ KKEEBIAIBAJ(bool APNCLCAEBCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7E01800", Offset = "0x7DFFE00", VA = "0x187E01800", Slot = "13")]
		protected virtual NCBJFOCOMOJ KKEEBIAIBAJ(IList<GENNLBMNKLP> OIABCOHDLMJ, AvatarItemBodyType CCPENNBMFEI, bool MGGHJGOKFMF, bool PHPODKDGOCP, int[] GHBAAEFKLCI, bool APNCLCAEBCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7DFDB50", Offset = "0x7DFC150", VA = "0x187DFDB50")]
		protected static NCBJFOCOMOJ EIMBMJCHMNO(MJCELCOKCIA JJIOAPIIJEK, List<MJCELCOKCIA> AKLNCODJBDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7E036D0", Offset = "0x7E01CD0", VA = "0x187E036D0")]
		[IteratorStateMachine(typeof(JCAKOAOMGHL))]
		protected static IEnumerator<HPILNDONOCO> OPEGNMJOJKP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7E02650", Offset = "0x7E00C50", VA = "0x187E02650")]
		protected static MJCELCOKCIA MOHEBBPBHCH(List<MJCELCOKCIA> AKLNCODJBDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7E04D40", Offset = "0x7E03340", VA = "0x187E04D40")]
		[AsyncStateMachine(typeof(JPJMHILFJBJ))]
		public Task SetFaceCustomizationSettings(JMOEBMFNCHJ NHMMIOKPODG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7E06F70", Offset = "0x7E05570", VA = "0x187E06F70")]
		public bool UpdateFaceAndBodyCustomizationSettings(JMOEBMFNCHJ NHMMIOKPODG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7E00950", Offset = "0x7DFEF50", VA = "0x187E00950")]
		public void InitializeFaceFeatures(AvatarConfiguration HFBJCMFCKNC, IJIIPECBIPC ELBKFGNIPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7E064C0", Offset = "0x7E04AC0", VA = "0x187E064C0")]
		public void SetTeamColors(Color? FCANCBHBMJB, bool NMFJDKNFPBI, Color HJHBKOHINPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x1436E70", Offset = "0x1435470", VA = "0x181436E70")]
		private static void FBGCAFKPBEL(Material KKIOJDIOKCM, Color KKGBKLFKCPO, params int[] JCMOEEHIHPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x1436CD0", Offset = "0x14352D0", VA = "0x181436CD0")]
		private static void DDLBBNMAPBH(Material KKIOJDIOKCM, Texture KKGBKLFKCPO, params int[] JCMOEEHIHPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7E031E0", Offset = "0x7E017E0", VA = "0x187E031E0")]
		protected void ODCFJELLCPO(Material FILGAIHBEFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x7DFFC60", Offset = "0x7DFE260", VA = "0x187DFFC60")]
		protected void GKNABBKMLFB(Material FILGAIHBEFK, Color DIACNJNGPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7E028D0", Offset = "0x7E00ED0", VA = "0x187E028D0")]
		protected void NBCJOKCFAIJ(Material FILGAIHBEFK, Color DIACNJNGPBD, Color GDCIGGFCPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x7E039E0", Offset = "0x7E01FE0", VA = "0x187E039E0")]
		protected void PABJMJCBBLD(Material FILGAIHBEFK, Texture2D OEJKMPDBJDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7E02C10", Offset = "0x7E01210", VA = "0x187E02C10")]
		protected void NEDGMAPJDBG(Material FILGAIHBEFK, Texture AEPHLGLHJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7E011C0", Offset = "0x7DFF7C0", VA = "0x187E011C0")]
		protected void JDOIECODMNM(Action<BHPOPANNDJM> AGAPPBAFHFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7DFC3A0", Offset = "0x7DFA9A0", VA = "0x187DFC3A0")]
		protected void BJBHFPADEFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE060", Offset = "0x7DFC660", VA = "0x187DFE060")]
		protected void EIPNHKLIOBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD250", Offset = "0x7DFB850", VA = "0x187DFD250")]
		protected void DEDDLOLLAFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7DFB820", Offset = "0x7DF9E20", VA = "0x187DFB820")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7E046C0", Offset = "0x7E02CC0", VA = "0x187E046C0")]
		public void SetBeardPrimaryColor([Optional] Color? FOJNDMNKLJC, bool EJICDOEOLHA = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7E048E0", Offset = "0x7E02EE0", VA = "0x187E048E0")]
		public void SetBeardSecondaryColor([Optional] Color? FOJNDMNKLJC, bool EJICDOEOLHA = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7E04580", Offset = "0x7E02B80", VA = "0x187E04580")]
		public void SetBeardPattern([Optional] AvatarHairPattern FCDGDDAHJJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7E03E10", Offset = "0x7E02410", VA = "0x187E03E10")]
		private void PIFPGBMLAFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7DFC1F0", Offset = "0x7DFA7F0", VA = "0x187DFC1F0")]
		private bool BHPNDBPGDOE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7E050B0", Offset = "0x7E036B0", VA = "0x187E050B0")]
		public void SetHairPrimaryColor([Optional] Color? EBKNCBHCOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7E052C0", Offset = "0x7E038C0", VA = "0x187E052C0")]
		public void SetHairSecondaryColor([Optional] Color? EBKNCBHCOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7E04F80", Offset = "0x7E03580", VA = "0x187E04F80")]
		public void SetHairPattern([Optional] AvatarHairPattern FCDGDDAHJJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7E041A0", Offset = "0x7E027A0", VA = "0x187E041A0")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7DFC690", Offset = "0x7DFAC90", VA = "0x187DFC690")]
		private bool BNBDKLHJBNB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7E06300", Offset = "0x7E04900", VA = "0x187E06300")]
		public void SetSkinColor(Color FIJDMNMPGHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7E067B0", Offset = "0x7E04DB0", VA = "0x187E067B0")]
		public void SetUgcItemVisualOverrides(GENNLBMNKLP OHALMEPMLNH, IJIIPECBIPC ELBKFGNIPML, Texture KBCJPKIOBAO, Color MEAJNLNOFDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD200", Offset = "0x7DFB800", VA = "0x187DFD200")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7E04E40", Offset = "0x7E03440", VA = "0x187E04E40")]
		public bool SetFaceShape(AvatarFaceShape LMJFELHIOCB, bool IBAOAFPBHDE = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7E01C60", Offset = "0x7E00260", VA = "0x187E01C60")]
		private void KMNEEFJJCJM(BDCHMIEGBGF JCIAGLECGJA, float KKGBKLFKCPO, bool JMDEDLJFKOJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x7DFB130", Offset = "0x7DF9730", VA = "0x187DFB130")]
		private void AAJIPAJLLGL(GMHCDNLIIED BPFFKBPIPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x7E01D50", Offset = "0x7E00350", VA = "0x187E01D50")]
		private void LFGFGFJJLNA(CLEOPONOOKA DJOHDEMNDBC, float KKGBKLFKCPO, bool BEHGKJMGHHC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7E03C00", Offset = "0x7E02200", VA = "0x187E03C00")]
		private void PBIJNINFFJA(DCJBFDFOONI KIOLKIGBEHD, float KKGBKLFKCPO, bool BOLEONAFPNI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7E02B00", Offset = "0x7E01100", VA = "0x187E02B00")]
		private void NBDHICBFEHM(EGEPKJBCJID LJPHFCPONFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x7E030B0", Offset = "0x7E016B0", VA = "0x187E030B0")]
		private void OBKFHHJHGHL(MELHMCFIOFD IPEKPIDHCDN, float ENHMINKDBLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7E04B00", Offset = "0x7E03100", VA = "0x187E04B00")]
		public bool SetBodyShape(AvatarBodyShape KBFKDDGJJNN, bool IBAOAFPBHDE = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7E06190", Offset = "0x7E04790", VA = "0x187E06190")]
		public bool SetNoseType(DPMPLKEDIBP BGOEFPILPLF, bool IBAOAFPBHDE = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7E07660", Offset = "0x7E05C60", VA = "0x187E07660")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x7E06170", Offset = "0x7E04770", VA = "0x187E06170")]
		public bool SetHideEars(bool HDGDGCPHDJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7E06160", Offset = "0x7E04760", VA = "0x187E06160")]
		public bool SetHelmetHair(JNNECLPJAPF PFBIAIKAHLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7E05BC0", Offset = "0x7E041C0", VA = "0x187E05BC0")]
		public void SetHatAnchorParameters(AFNDLFBCDPE HHADFMIKLIE, bool NMMBAPDJFNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7E06EE0", Offset = "0x7E054E0", VA = "0x187E06EE0")]
		public void SetupDisplayLODs(MGODOFHFFMM IJOCIHPFMJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF860", Offset = "0x7DFDE60", VA = "0x187DFF860")]
		protected int[] FPNFGBFNGAI(MGODOFHFFMM IJOCIHPFMJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7E06230", Offset = "0x7E04830", VA = "0x187E06230")]
		public void SetOutfitSelections(IList<GENNLBMNKLP> OIABCOHDLMJ, AvatarItemBodyType CCPENNBMFEI, bool PHPODKDGOCP, bool APNCLCAEBCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7E062B0", Offset = "0x7E048B0", VA = "0x187E062B0")]
		public void SetOutfitSelections(IList<GENNLBMNKLP> OIABCOHDLMJ, AvatarItemBodyType CCPENNBMFEI, bool MGGHJGOKFMF, bool PHPODKDGOCP, bool APNCLCAEBCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7E06270", Offset = "0x7E04870", VA = "0x187E06270")]
		public NCBJFOCOMOJ SetOutfitSelections(IList<GENNLBMNKLP> OIABCOHDLMJ, AvatarItemBodyType CCPENNBMFEI, MGODOFHFFMM IJOCIHPFMJF, bool MGGHJGOKFMF, bool PHPODKDGOCP, bool IBAOAFPBHDE = false, bool APNCLCAEBCJ = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7E02150", Offset = "0x7E00750", VA = "0x187E02150", Slot = "14")]
		protected virtual NCBJFOCOMOJ MHEBCGFMPFE(IList<GENNLBMNKLP> OIABCOHDLMJ, AvatarItemBodyType CCPENNBMFEI, bool MGGHJGOKFMF, bool PHPODKDGOCP, MGODOFHFFMM IJOCIHPFMJF, bool IBAOAFPBHDE, bool APNCLCAEBCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7DFC2A0", Offset = "0x7DFA8A0", VA = "0x187DFC2A0")]
		protected int[] BICFKPJPHCE(MGODOFHFFMM IJOCIHPFMJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "15")]
		protected virtual BKFKILCGELM FEPGFIJNEDD(AvatarItemBodyType NOOAINIFEDO, Dictionary<string, JOHGPLIHENP> DLBHNLPGGHM, Dictionary<string, MODONOMENDG<Texture2D>> LFMLHGPEFKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x7DFBF20", Offset = "0x7DFA520", VA = "0x187DFBF20", Slot = "16")]
		protected virtual NCBJFOCOMOJ BGEMBECPEIC(IList<GENNLBMNKLP> OIABCOHDLMJ, AvatarItemBodyType CCPENNBMFEI, bool MGGHJGOKFMF, bool PHPODKDGOCP, int[] HIJOCDINLEF, CEKFBKJJEMI JMKCBPNNICD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x7E00A30", Offset = "0x7DFF030", VA = "0x187E00A30", Slot = "17")]
		protected virtual JOHGPLIHENP JADPDCMOOBB(ALNFLEBPLME DKCGFDJNJOO, AvatarItemBodyType NOOAINIFEDO, JBDCJHGBANL HJLDIJBMLBP, JOHGPLIHENP HMKNMFCHPOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "18")]
		protected virtual JOHGPLIHENP ABDGHOMMAOK(AvatarItemBodyType NOOAINIFEDO, JBDCJHGBANL HJLDIJBMLBP, POEALGEEJHE ILIOCACLGDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7DFDA40", Offset = "0x7DFC040", VA = "0x187DFDA40")]
		protected void EHFFDDNCNLF(KDCJJONJJHK EODHGMDABGG, OBJIGDJGKHB.MAHMKAHBAAB HAJKJBNHANM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7E00600", Offset = "0x7DFEC00", VA = "0x187E00600")]
		protected void HPFKMPHOENL(KDCJJONJJHK EODHGMDABGG, OBJIGDJGKHB.MAHMKAHBAAB HAJKJBNHANM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xAC6580", Offset = "0xAC4B80", VA = "0x180AC6580", Slot = "19")]
		protected virtual KDCJJONJJHK PJJMNPOCGFP(KDCJJONJJHK EODHGMDABGG, HelmetHairStyle BBBIKPGMIFM, bool ADDKGDFICPB, AvatarItemBodyType CCPENNBMFEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE820", Offset = "0x7DFCE20", VA = "0x187DFE820")]
		protected KDCJJONJJHK FOJBLIHJLCO(IList<GENNLBMNKLP> OIABCOHDLMJ, AvatarItemBodyType DDGILCNKENC, bool PHPODKDGOCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD010", Offset = "0x7DFB610", VA = "0x187DFD010")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7DFC5E0", Offset = "0x7DFABE0", VA = "0x187DFC5E0")]
		protected void BMONKFGAECF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7E001C0", Offset = "0x7DFE7C0", VA = "0x187E001C0")]
		protected void HGKHPIJLBOP(Transform MBLPLPLEKPC, IEnumerable<SkinnedMeshRenderer> PMMEEECNDJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7E02530", Offset = "0x7E00B30", VA = "0x187E02530")]
		protected OBJIGDJGKHB.MAHMKAHBAAB MMIKEBLINCF(OBJIGDJGKHB.MAHMKAHBAAB JFAPFNOJHKP, JBDCJHGBANL LHKGOGNNICI)
		{
			return default(OBJIGDJGKHB.MAHMKAHBAAB);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD5B0", Offset = "0x7DFBBB0", VA = "0x187DFD5B0")]
		protected void DPCCEDKPCAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x1971350", Offset = "0x196F950", VA = "0x181971350")]
		protected void GIBAECKEPMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE220", Offset = "0x7DFC820", VA = "0x187DFE220")]
		protected void EKBJPHCMKAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7E00530", Offset = "0x7DFEB30", VA = "0x187E00530")]
		[AsyncStateMachine(typeof(GFCIPCHEFNF))]
		protected Task HLOLEOPMELG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x7E006D0", Offset = "0x7DFECD0", VA = "0x187E006D0")]
		protected static IKAOODBAOGC IDJKKOBELHF(BFGDKBOPPNG OICNFPFBDHD, int LABAPBFICLN)
		{
			return default(IKAOODBAOGC);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7E00F20", Offset = "0x7DFF520", VA = "0x187E00F20")]
		protected static NCOEHDJHOEB JCACOFAHAPB(BFGDKBOPPNG OICNFPFBDHD, int LABAPBFICLN)
		{
			return default(NCOEHDJHOEB);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7DFCAE0", Offset = "0x7DFB0E0", VA = "0x187DFCAE0")]
		protected Transform CKMBCCHCJCC(JBDCJHGBANL HJLDIJBMLBP, OutfitType HPCEECOHNKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7DFC860", Offset = "0x7DFAE60", VA = "0x187DFC860")]
		protected void CEBNLMIMBAO(int CLFIBGFKFKD, Material KKIOJDIOKCM, BFGDKBOPPNG OICNFPFBDHD, [Out] Texture2D OHCGLHGPLMM, [Out] Vector4 LBJMIBJDKJA, [Out] Texture2D FEKIIECDGHL, [Out] Texture2D FPJLOHKCIMG, [Out] Texture2D JLMCGDCDEGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x7E01070", Offset = "0x7DFF670", VA = "0x187E01070")]
		protected void JCEHKBHILHC(int CLFIBGFKFKD, Material KKIOJDIOKCM, BFGDKBOPPNG OICNFPFBDHD, [Out] Color FOMOELHFPBG, [Out] Color INNHEMAMHEM, [Out] Color AEEOAGNMNHG, [Out] Color EEBEFNFHMBG, [Out] Color AKFDBDMHAII, [Out] Color JOBNAMBEOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD5C0", Offset = "0x7DFBBC0", VA = "0x187DFD5C0")]
		protected void DPCGJCEIAHD(Vector3 DGHMAMNELGC, Quaternion GBHJDFCFFNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7E05570", Offset = "0x7E03B70", VA = "0x187E05570")]
		public void SetHatAnchorParameters(AFNDLFBCDPE HHADFMIKLIE, AnchorParamsRestrictions KHPEKJKIMOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7DFCB30", Offset = "0x7DFB130", VA = "0x187DFCB30")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere DGOLDKIFDPA, Transform KPAANBNONBD, AFNDLFBCDPE HHADFMIKLIE, AnchorParamsRestrictions DFBBHKFIKAE, [Out] Vector3 GCBLNLANCOF, [Out] Quaternion EFCAEMFMOII, [Out] AFNDLFBCDPE KCBHBHIGEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x7E04410", Offset = "0x7E02A10", VA = "0x187E04410")]
		public void ResetHatAnchor(Vector2 GPDCLCCMCLF, Vector3 POKKMJBONPM, Vector3 APHPLOKDPNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xB5DFB0", Offset = "0xB5C5B0", VA = "0x180B5DFB0")]
		public GNDAKGCEFLH GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x7DFB650", Offset = "0x7DF9C50", VA = "0x187DFB650")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7DFB790", Offset = "0x7DF9D90", VA = "0x187DFB790")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x7DFB5C0", Offset = "0x7DF9BC0", VA = "0x187DFB5C0")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7E06F10", Offset = "0x7E05510", VA = "0x187E06F10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7E03500", Offset = "0x7E01B00", VA = "0x187E03500")]
		protected void OKNCGJBFBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7E06CD0", Offset = "0x7E052D0", VA = "0x187E06CD0")]
		public void SetWaitForUgcTextureLoads(bool EBHJKNPENKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7E06B50", Offset = "0x7E05150", VA = "0x187E06B50")]
		public void SetUgcTextureParameters(FDMHDGANLHD MJNKOFMOBDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7E07DC0", Offset = "0x7E063C0", VA = "0x187E07DC0")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7E008C0", Offset = "0x7DFEEC0", VA = "0x187E008C0")]
		[CompilerGenerated]
		private void IFJBKOOBNAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7E02FF0", Offset = "0x7E015F0", VA = "0x187E02FF0")]
		[CompilerGenerated]
		private void NMBCEFFDCEP(BHPOPANNDJM CONFGJKBMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x7E03020", Offset = "0x7E01620", VA = "0x187E03020")]
		[CompilerGenerated]
		private void NMLIMBBELFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7E01700", Offset = "0x7DFFD00", VA = "0x187E01700")]
		[CompilerGenerated]
		private void KHIKHPLBEAP(BHPOPANNDJM CONFGJKBMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7DFFA70", Offset = "0x7DFE070", VA = "0x187DFFA70")]
		[CompilerGenerated]
		private void GDMCGEMPCLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7E01320", Offset = "0x7DFF920", VA = "0x187E01320")]
		[CompilerGenerated]
		private void JIGBPGHIBAK(BHPOPANNDJM CONFGJKBMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7DFFEE0", Offset = "0x7DFE4E0", VA = "0x187DFFEE0")]
		[CompilerGenerated]
		private void GOJDIGNNJED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7E00680", Offset = "0x7DFEC80", VA = "0x187E00680")]
		[CompilerGenerated]
		private void IALNDDJFJCO(BHPOPANNDJM CONFGJKBMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7E014A0", Offset = "0x7DFFAA0", VA = "0x187E014A0")]
		[CompilerGenerated]
		private void KCDHBANALJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE4B0", Offset = "0x7DFCAB0", VA = "0x187DFE4B0")]
		[CompilerGenerated]
		private void FBDMDBPDLIB(BHPOPANNDJM CONFGJKBMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7DFDAC0", Offset = "0x7DFC0C0", VA = "0x187DFDAC0")]
		[CompilerGenerated]
		private void EICLMIJPGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7E02510", Offset = "0x7E00B10", VA = "0x187E02510")]
		[CompilerGenerated]
		private void MKEOGEEMMKN(BHPOPANNDJM CONFGJKBMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7E013C0", Offset = "0x7DFF9C0", VA = "0x187E013C0")]
		[CompilerGenerated]
		internal static bool JPMDEHMKPKM(Transform AOGHCPKAEKH, IEnumerable<SkinnedMeshRenderer> MLLLBKCFJFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x7E004F0", Offset = "0x7DFEAF0", VA = "0x187E004F0")]
		[CompilerGenerated]
		private void HKFBOHJIGHH(BHPOPANNDJM CONFGJKBMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x7DFB330", Offset = "0x7DF9930", VA = "0x187DFB330")]
		[CompilerGenerated]
		private void AEDJGODKHDJ(BHPOPANNDJM CONFGJKBMMJ)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, ODGGGLKDEEB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct POBMKGOMPBM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			public JMOEBMFNCHJ avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x7E126E0", Offset = "0x7E10CE0", VA = "0x187E126E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x7E12970", Offset = "0x7E10F70", VA = "0x187E12970", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct CAEAIDFPOFM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000471")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000472")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000473")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000474")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			public IJIIPECBIPC avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x7E0EBE0", Offset = "0x7E0D1E0", VA = "0x187E0EBE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x7E0EDC0", Offset = "0x7E0D3C0", VA = "0x187E0EDC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct JGKCIJFICHL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400047B")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400047C")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400047D")]
			public IJIIPECBIPC avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400047E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x7E10520", Offset = "0x7E0EB20", VA = "0x187E10520", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x7E106C0", Offset = "0x7E0ECC0", VA = "0x187E106C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct JNPFKADIDIG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400047F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000480")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000481")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000482")]
			public JMOEBMFNCHJ avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000483")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x7E10E90", Offset = "0x7E0F490", VA = "0x187E10E90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x7E11040", Offset = "0x7E0F640", VA = "0x187E11040", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct JJKLELFGGMK : IAsyncStateMachine
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
			public IJIIPECBIPC avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			private TaskAwaiter<IIKDKMFICBI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x7E10720", Offset = "0x7E0ED20", VA = "0x187E10720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x7E10B60", Offset = "0x7E0F160", VA = "0x187E10B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct OBLNECMICAE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			public bool forceRebuild;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			public IJIIPECBIPC avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x7E11ED0", Offset = "0x7E104D0", VA = "0x187E11ED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x7E122F0", Offset = "0x7E108F0", VA = "0x187E122F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		protected const float OLIOLHEFMME = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		protected const int JIHCAEBNPPH = 5;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private static readonly int CPKKBMMKIDE;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private static readonly int HNLKJFPPHLI;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private static readonly int MMHPNBJNBLA;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		protected static readonly Dictionary<MAMDNKPIJPB.IKMGNJGHJPP, int> KECBDLBFAJL;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> KDHFPEOGJBI;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected static readonly int OHFIKBPKMDK;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected static readonly int POGIGAFCDJH;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected static readonly int KNJIMIBNIHH;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		protected static readonly int PJOIELPMLNC;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected static readonly int GENKJODNAML;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		protected static Vector2 NFIODLBIOMI;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		protected static Vector2 CFBAFHOOAEA;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		protected static Vector2 LJBBNINEHAE;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		protected static Vector2 EIGOMEGIIEB;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		protected static Vector2 CONHBFMGBNG;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		protected static Vector2 NLHKDFIGGJJ;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		protected static Vector2 BCPILGBNOLC;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		protected static Vector2 HDONGEIMDPM;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		protected static Vector2 PMJEGCBBFAP;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		protected static Vector2 CDJEHGIBOFP;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		protected static Vector2 EMIJDOAJCEN;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected static Vector2 PHBDOPEIOBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		[DOIDGFGIDBO(CNNBEEFOMHL.Self, false, false, false)]
		[SerializeField]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		[SerializeField]
		[Header("Rendering")]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		[Header("Emotes")]
		[SerializeField]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		[SerializeField]
		[Header("Modern Avatar Facial Features")]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private IJIIPECBIPC NIFFNLJJNAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private FaceStyleSet KOGLBGEFPBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected const int GDOGNILODDE = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected int EHKFHOJELJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected int KMGPHLMFGHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected int PMKMMJJJGAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected int LNKHBIBMDAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected Vector2 LDMMLBLDEOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected float DCNCLFMGBDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		protected float OKMEIDJJGPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		protected float MCDCCJJKHNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		protected Vector2 HEBEMPBCEOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected float CCDGLFADOOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected float KLHLFNFGJEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		protected float LMOOBMCMFIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		protected Vector2 BKKFAPDPAOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected float JPLGHDCJEEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected float MLEONOGJOOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		protected float NIHCNGMHMPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		protected Vector2 JCBDIABHKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		protected float EMLGNOAABNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		protected float BEIOFDBFFIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		protected float KPFKLIIEMAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		protected List<SelectableFaceOption> NKNBDPELDHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		protected List<SelectableFaceOption> KCBBALKMFFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected List<SelectableFaceOption> GOIOLIBNEEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		protected List<SelectableFaceOption> IKPBIOFIHGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		protected Coroutine GHBCFFLLFEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		protected int? OANCPPIEGAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		protected int MFDNDECMDBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		protected int MJBHKKLPKNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		protected int BEMHIFODAGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		protected int FIJLDHIPNFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		protected Sprite HOFPLNIMELG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		protected Sprite PFJDBAANDND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		protected Sprite EJGKGHBJIIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		protected Sprite ELLFELDIGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		protected bool EMLEPHIIOBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		protected string NOKHIHDCCDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		protected string KKICBEJCKFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		protected string FJMHGGPIJFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		protected string KCKGAANPJOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		protected AvatarConfiguration HFBJCMFCKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		protected IIKDKMFICBI IIEOPMODKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private readonly List<Material> DIIGBFEKKGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		protected DACCLJEKOLE BDFFGEKLELB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		protected Dictionary<string, int> EMKPKOHBGHO;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public FaceStyleSet COKMMJOOMLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x7E18EE0", Offset = "0x7E174E0", VA = "0x187E18EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public bool OJHFDJNPBGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x24D7C10", Offset = "0x24D6210", VA = "0x1824D7C10", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x25AE720", Offset = "0x25ACD20", VA = "0x1825AE720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		protected virtual bool DCPGGMECFCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		protected virtual bool OBBGNCPAGDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		protected int OKHMCALMJPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x7E15990", Offset = "0x7E13F90", VA = "0x187E15990")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public Renderer IKGLPDFLDCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool GEPPMACPCFH
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x25B76B0", Offset = "0x25B5CB0", VA = "0x1825B76B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x25AEB80", Offset = "0x25AD180", VA = "0x1825AEB80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Renderer[] AFBBKNOKJIH
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public bool FHEBAMMFNAE
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x7E18F30", Offset = "0x7E17530", VA = "0x187E18F30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x7E190F0", Offset = "0x7E176F0", VA = "0x187E190F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		protected int AOBAOCGGAJB
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x7E130B0", Offset = "0x7E116B0", VA = "0x187E130B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		protected int AHLBMNBBEEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x7E14B20", Offset = "0x7E13120", VA = "0x187E14B20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public float HOJIBKMLIBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x7E18F10", Offset = "0x7E17510", VA = "0x187E18F10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x7E190D0", Offset = "0x7E176D0", VA = "0x187E190D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public JMNHGNDLFHB IFCCJECNCOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0xB73B50", Offset = "0xB72150", VA = "0x180B73B50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0xBA2510", Offset = "0xBA0B10", VA = "0x180BA2510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public IIKDKMFICBI DDFEEEDFDMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0xAFA010", Offset = "0xAF8610", VA = "0x180AFA010")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x7E19050", Offset = "0x7E17650", VA = "0x187E19050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public NoseFaceOption LHKBIJMFCBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0xAD32A0", Offset = "0xAD18A0", VA = "0x180AD32A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0xB58B40", Offset = "0xB57140", VA = "0x180B58B40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		protected DACCLJEKOLE GBHFKJFGCNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x7E12D30", Offset = "0x7E11330", VA = "0x187E12D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action PLNHNLMDDNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x7E18E30", Offset = "0x7E17430", VA = "0x187E18E30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x7E18FA0", Offset = "0x7E175A0", VA = "0x187E18FA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x7E153A0", Offset = "0x7E139A0", VA = "0x187E153A0")]
		public void LocalPlayEmote(MAMDNKPIJPB.IKMGNJGHJPP MEKNAMEECAC, float IIFJEHFHNBP = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7E14A00", Offset = "0x7E13000", VA = "0x187E14A00")]
		public bool IsEmotePlaying(MAMDNKPIJPB.IKMGNJGHJPP MEKNAMEECAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x7E16D50", Offset = "0x7E15350", VA = "0x187E16D50")]
		public void SetIdleHappy(bool AGFMNIOFJGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7E12EB0", Offset = "0x7E114B0", VA = "0x187E12EB0")]
		protected void CEMBGBEOAAA(bool BPAMOLAMOHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x7E129D0", Offset = "0x7E10FD0", VA = "0x187E129D0")]
		protected void ACAFIIOMGOO(bool OKKKACFCNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x7E15620", Offset = "0x7E13C20", VA = "0x187E15620")]
		protected void ODPLFFDDHOG(JBDCJHGBANL HJLDIJBMLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x7E13110", Offset = "0x7E11710", VA = "0x187E13110")]
		protected void DGJOFHLJFLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x7E16420", Offset = "0x7E14A20", VA = "0x187E16420")]
		public void PlayExpression(int OLNKMFBCGJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x7E12C70", Offset = "0x7E11270", VA = "0x187E12C70")]
		protected void BCKJDKHMFBB(bool NKJPLOBFHIO, bool BEGMJMAEEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x7E13890", Offset = "0x7E11E90", VA = "0x187E13890")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType NHCLAGGAHNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7E144D0", Offset = "0x7E12AD0", VA = "0x187E144D0")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration HFBJCMFCKNC, IJIIPECBIPC ELBKFGNIPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x7E16B20", Offset = "0x7E15120", VA = "0x187E16B20")]
		[AsyncStateMachine(typeof(POBMKGOMPBM))]
		public Task SetFaceSettings(JMOEBMFNCHJ NHMMIOKPODG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x7E169F0", Offset = "0x7E14FF0", VA = "0x187E169F0")]
		[AsyncStateMachine(typeof(CAEAIDFPOFM))]
		public Task SetFaceSettings(int OOPNFPBINGL, int JBHAPOMAAID, int KPCLJJGBACI, int EDDGMGKPBNL, IJIIPECBIPC ELBKFGNIPML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x7E16DD0", Offset = "0x7E153D0", VA = "0x187E16DD0")]
		[AsyncStateMachine(typeof(JGKCIJFICHL))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType NHCLAGGAHNF, int CKJBEACBDDH, IJIIPECBIPC ELBKFGNIPML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x7E12F30", Offset = "0x7E11530", VA = "0x187E12F30")]
		protected void CGGHIPJBBJI(FaceFeatureType NHCLAGGAHNF, HBMNJKGCEPD HENODJLOKKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x7E14B80", Offset = "0x7E13180", VA = "0x187E14B80")]
		protected void KLKKKNMLFIL(FaceFeatureType NHCLAGGAHNF, int CKJBEACBDDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x7E136B0", Offset = "0x7E11CB0", VA = "0x187E136B0")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x7E135C0", Offset = "0x7E11BC0", VA = "0x187E135C0")]
		[AsyncStateMachine(typeof(JNPFKADIDIG))]
		protected Task GGCIGKAIJOJ(JMOEBMFNCHJ NHMMIOKPODG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7E15690", Offset = "0x7E13C90", VA = "0x187E15690")]
		protected void OLECPDKKCOE(JMOEBMFNCHJ NHMMIOKPODG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7E138D0", Offset = "0x7E11ED0", VA = "0x187E138D0")]
		protected static void HDINFBLFLFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7E13180", Offset = "0x7E11780", VA = "0x187E13180")]
		private void EMNEJKPFNPP(bool FCOPGBJBJGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x7E14050", Offset = "0x7E12650", VA = "0x187E14050")]
		protected void INEIGPOEHJD(FaceFeatureType NHCLAGGAHNF, Vector2 CNCEFCLMGKJ, IJIIPECBIPC ELBKFGNIPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7E16440", Offset = "0x7E14A40", VA = "0x187E16440")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType NHCLAGGAHNF, Vector2 FPLOIAINKFB, IJIIPECBIPC ELBKFGNIPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7E13A70", Offset = "0x7E12070", VA = "0x187E13A70")]
		protected void HJGJOOIBEOH(FaceFeatureType NHCLAGGAHNF, float MBBFEPDGCJC, IJIIPECBIPC ELBKFGNIPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7E154A0", Offset = "0x7E13AA0", VA = "0x187E154A0")]
		protected void NPBIDKBCLJI(FaceFeatureType NHCLAGGAHNF, float CFFPEJBOBIA, IJIIPECBIPC ELBKFGNIPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x7E13BF0", Offset = "0x7E121F0", VA = "0x187E13BF0")]
		protected void HPLGENOLBDF(FaceFeatureType NHCLAGGAHNF, float PHCIEMFACFG, IJIIPECBIPC ELBKFGNIPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7E167D0", Offset = "0x7E14DD0", VA = "0x187E167D0")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType NHCLAGGAHNF, float DLDNMENIOOI, IJIIPECBIPC ELBKFGNIPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x7E152C0", Offset = "0x7E138C0", VA = "0x187E152C0")]
		[AsyncStateMachine(typeof(JJKLELFGGMK))]
		protected Task LHKMEAHOPIB(IJIIPECBIPC ELBKFGNIPML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7E147F0", Offset = "0x7E12DF0", VA = "0x187E147F0")]
		public void InitializeFaceFeatureStyleSet(IJIIPECBIPC ELBKFGNIPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7E13CC0", Offset = "0x7E122C0", VA = "0x187E13CC0")]
		protected bool IGGEMGKAMBN(string PKOHGEFBKAP, [Out] int KHMHPNKMLMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x7E12B30", Offset = "0x7E11130", VA = "0x187E12B30")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7E16EE0", Offset = "0x7E154E0", VA = "0x187E16EE0", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7E15AC0", Offset = "0x7E140C0", VA = "0x187E15AC0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x7E17EE0", Offset = "0x7E164E0", VA = "0x187E17EE0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x7E12DB0", Offset = "0x7E113B0", VA = "0x187E12DB0")]
		[AsyncStateMachine(typeof(OBLNECMICAE))]
		public Task BuildFaceStyleAsyncIfChanged(IJIIPECBIPC ELBKFGNIPML, bool IBAOAFPBHDE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7E177F0", Offset = "0x7E15DF0", VA = "0x187E177F0")]
		public void UpdateFaceDisplays(bool CLNADMOEMJH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7E15CD0", Offset = "0x7E142D0", VA = "0x187E15CD0")]
		protected bool PJFELPHJEFI(bool CLNADMOEMJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7E17550", Offset = "0x7E15B50", VA = "0x187E17550")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7E16C10", Offset = "0x7E15210", VA = "0x187E16C10")]
		public void SetFaceSpriteIndices(string BELIJAJEDFH, string PKFBKKHFEFE, string KJFBOFDIKFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x7E16EF0", Offset = "0x7E154F0", VA = "0x187E16EF0")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x7E17A10", Offset = "0x7E16010", VA = "0x187E17A10")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7E17C00", Offset = "0x7E16200", VA = "0x187E17C00")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x7E143E0", Offset = "0x7E129E0", VA = "0x187E143E0")]
		protected void INODDJLMCGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x7E13DA0", Offset = "0x7E123A0", VA = "0x187E13DA0")]
		private void IGNFKJIDLFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x7E13410", Offset = "0x7E11A10", VA = "0x187E13410")]
		private void EONLJHAHCCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x7E18BD0", Offset = "0x7E171D0", VA = "0x187E18BD0")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xA71DD0", Offset = "0xA703D0", VA = "0x180A71DD0", Slot = "4")]
		private bool HIIIPJGJLMB()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct IHBFIJCIMPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public string GKIMNFGPLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public int NJJOPPIMCLB;
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
		private struct AIIHCNIMPPD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004F2")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F3")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x7E0A730", Offset = "0x7E08D30", VA = "0x187E0A730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0xAA6DB0", Offset = "0xAA53B0", VA = "0x180AA6DB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private struct KIANNBLFCGB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F7")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x7E114A0", Offset = "0x7E0FAA0", VA = "0x187E114A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x7E11990", Offset = "0x7E0FF90", VA = "0x187E11990", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public IJIIPECBIPC avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public JNNECLPJAPF useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public AFNDLFBCDPE hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public GNDAKGCEFLH HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public long baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		[DOIDGFGIDBO(CNNBEEFOMHL.Self, false, false, false)]
		[SerializeField]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private OJNOLKOEFML JJNCNKGEKNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		[DOIDGFGIDBO(CNNBEEFOMHL.Self, false, false, false)]
		[SerializeField]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private AnimatorOverrideController PCGGDCKOHAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> BMDJECHAFAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public readonly IHBFIJCIMPI[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public readonly (string, OBAGOEPBKCD)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		protected bool FBIHAAGDJHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		protected Guid LIMNHHBNFMI;

		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		protected static Guid HAPGBGIEFEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private ABICHDKCLFP JPGPIPKOANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private JMNHGNDLFHB MIBLFDMHLFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private BNINFAJBEOF JDMOBBJOJBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private BNINFAJBEOF PIDNDMDHDKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private AdditionalHatData GAKLDIKGJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private readonly Dictionary<GameObject, ALNFLEBPLME> JPOHMNIIENF;

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public static Func<POEALGEEJHE> LBFHKBELFAO
		{
			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x7E1E1A0", Offset = "0x7E1C7A0", VA = "0x187E1E1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x7E1E7E0", Offset = "0x7E1CDE0", VA = "0x187E1E7E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public bool BNBDKLHJBNB
		{
			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x7E1E300", Offset = "0x7E1C900", VA = "0x187E1E300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public bool BHPNDBPGDOE
		{
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x7E1E1F0", Offset = "0x7E1C7F0", VA = "0x187E1E1F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public PlayerAvatarDisplayBase GCDJJNCONCH
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0xB5E6D0", Offset = "0xB5CCD0", VA = "0x180B5E6D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		protected static Guid EEFHNNOBPJL
		{
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x7E1AF90", Offset = "0x7E19590", VA = "0x187E1AF90")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public (GameObject, JBDCJHGBANL)[] GEKPAGEFAKE
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x7E1E410", Offset = "0x7E1CA10", VA = "0x187E1E410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BEE0", Offset = "0x7E1A4E0", VA = "0x187E1BEE0")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7E1A350", Offset = "0x7E18950", VA = "0x187E1A350")]
		private IEnumerable<GameObject> IJJMMDBAPLC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7E1C3B0", Offset = "0x7E1A9B0", VA = "0x187E1C3B0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7E1A270", Offset = "0x7E18870", VA = "0x187E1A270")]
		private void ICLANNGABNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x141A370", Offset = "0x1418970", VA = "0x18141A370")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x7E1A7C0", Offset = "0x7E18DC0", VA = "0x187E1A7C0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7E1C3C0", Offset = "0x7E1A9C0", VA = "0x187E1C3C0")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7E1C1D0", Offset = "0x7E1A7D0", VA = "0x187E1C1D0")]
		public void ShowPose(AnimationClip PKKLEMAAFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7E1C380", Offset = "0x7E1A980", VA = "0x187E1C380")]
		public void ShowPose(string HPIGBJPGODL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x7E1C030", Offset = "0x7E1A630", VA = "0x187E1C030")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BEF0", Offset = "0x7E1A4F0", VA = "0x187E1BEF0")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7E1CE90", Offset = "0x7E1B490", VA = "0x187E1CE90")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7E1CCE0", Offset = "0x7E1B2E0", VA = "0x187E1CCE0")]
		public void UpdateFaceAndBodyShapes(bool IBAOAFPBHDE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D290", Offset = "0x7E1B890", VA = "0x187E1D290")]
		public void UpdateNoseShape(DPMPLKEDIBP BGOEFPILPLF, bool IBAOAFPBHDE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D260", Offset = "0x7E1B860", VA = "0x187E1D260")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7E19EB0", Offset = "0x7E184B0", VA = "0x187E19EB0", Slot = "4")]
		protected virtual void FPEAOCFBFNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x7E1B880", Offset = "0x7E19E80", VA = "0x187E1B880", Slot = "5")]
		protected virtual void NFJBJEBKALI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x7E19400", Offset = "0x7E17A00", VA = "0x187E19400")]
		public void ApplyHatData(AdditionalHatData ELIILKENGCN, bool GCBEPMOFEOF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7E19240", Offset = "0x7E17840", VA = "0x187E19240")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7E19760", Offset = "0x7E17D60", VA = "0x187E19760")]
		public void ApplyHatUVOverride(Vector2 JFCHOMJIBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7E19680", Offset = "0x7E17C80", VA = "0x187E19680")]
		public void ApplyHatPositionAdjustment(Vector3 EFJFKDHHFMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x7E196F0", Offset = "0x7E17CF0", VA = "0x187E196F0")]
		public void ApplyHatRotationAdjustment(Vector3 FMMBGBFNOPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x7E197D0", Offset = "0x7E17DD0", VA = "0x187E197D0")]
		public GENNLBMNKLP BuildAvatarItemSelection(GameObject MMGLJKOEKKG, IJIIPECBIPC NOOAINIFEDO, JBDCJHGBANL HNHFGEPMHEL)
		{
			return default(GENNLBMNKLP);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x7E19870", Offset = "0x7E17E70", VA = "0x187E19870")]
		public void BuildAvatar(bool IBAOAFPBHDE = false, bool GCBEPMOFEOF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7E1C720", Offset = "0x7E1AD20", VA = "0x187E1C720")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x7E19380", Offset = "0x7E17980", VA = "0x187E19380")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D0B0", Offset = "0x7E1B6B0", VA = "0x187E1D0B0")]
		public void UpdateHatAnchor(bool GCBEPMOFEOF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x7E1CDE0", Offset = "0x7E1B3E0", VA = "0x187E1CDE0")]
		[AsyncStateMachine(typeof(AIIHCNIMPPD))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x7E1AEC0", Offset = "0x7E194C0", VA = "0x187E1AEC0")]
		[AsyncStateMachine(typeof(KIANNBLFCGB))]
		private Task JBAFJBGFAHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7E1B5B0", Offset = "0x7E19BB0", VA = "0x187E1B5B0")]
		private void MLABMOKMLAM(FaceFeatureType DEDCIKNHKNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BE50", Offset = "0x7E1A450", VA = "0x187E1BE50")]
		private void ODGHBDKFBNC(FaceFeatureType DEDCIKNHKNM, [Out] float DPDBJAKFGGI, [Out] float AOKCAMELKFL, [Out] float HKINPNLCPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x7E1CBA0", Offset = "0x7E1B1A0", VA = "0x187E1CBA0")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x7E1CF40", Offset = "0x7E1B540", VA = "0x187E1CF40")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x7E1B080", Offset = "0x7E19680", VA = "0x187E1B080")]
		private void MJGCMCBJCKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		private void LOEKIFIJCIN(ALNFLEBPLME DKCGFDJNJOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		private void LMEBEIEACPI(ALNFLEBPLME DKCGFDJNJOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BAF0", Offset = "0x7E1A0F0", VA = "0x187E1BAF0")]
		private void OANNCDINLBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D320", Offset = "0x7E1B920", VA = "0x187E1D320")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7E1A1C0", Offset = "0x7E187C0", VA = "0x187E1A1C0")]
		[CompilerGenerated]
		private GENNLBMNKLP HFMNNFHJBFG((GameObject, JBDCJHGBANL) LBMEANJAJJF)
		{
			return default(GENNLBMNKLP);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		[DOIDGFGIDBO(CNNBEEFOMHL.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xA469E0", Offset = "0xA44FE0", VA = "0x180A469E0")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct GENNLBMNKLP
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class LGDMAOIFJFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public LGDMAOIFJFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x7E11BB0", Offset = "0x7E101B0", VA = "0x187E11BB0")]
		internal bool LIDJCFJPEDE(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private ALNFLEBPLME MILGAMOJEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private JBDCJHGBANL KDKMGDIJOAA;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public ALNFLEBPLME CHIPINHDKNA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public JBDCJHGBANL PCKBLLJANJG
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A30", Offset = "0xDE7030", VA = "0x180DE8A30")]
		get
		{
			return default(JBDCJHGBANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public string FKMEBFFPAOD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x7E0F0E0", Offset = "0x7E0D6E0", VA = "0x187E0F0E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool COMOEMBDBBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x7E0F090", Offset = "0x7E0D690", VA = "0x187E0F090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool KMDDAPBPCNC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7E0F1D0", Offset = "0x7E0D7D0", VA = "0x187E0F1D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x1983E90", Offset = "0x1982490", VA = "0x181983E90")]
	public GENNLBMNKLP(ALNFLEBPLME DKCGFDJNJOO, JBDCJHGBANL HJLDIJBMLBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x7E0F220", Offset = "0x7E0D820", VA = "0x187E0F220")]
	public bool OOGKMCIDGLE(OutfitType PCDIGEIBOGP, JBDCJHGBANL CCCFFADMHHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x7E0EE20", Offset = "0x7E0D420", VA = "0x187E0EE20")]
	public bool AAEMPGGPFLA(OutfitType PCDIGEIBOGP, JBDCJHGBANL CCCFFADMHHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x7E0F2F0", Offset = "0x7E0D8F0", VA = "0x187E0F2F0")]
	public bool PPFBKGPHNHB(GENNLBMNKLP AOCDIGMONDN)
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
