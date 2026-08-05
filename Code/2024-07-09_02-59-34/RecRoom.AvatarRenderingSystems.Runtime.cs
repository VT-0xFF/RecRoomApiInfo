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
	public class LogRegistrationIndex : NNAGAKKCAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x686ABE0", Offset = "0x68697E0", VA = "0x18686ABE0", Slot = "4")]
		public override void NGMFPPEDCJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
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
			[Cpp2IlInjected.Address(RVA = "0x86A490", Offset = "0x869090", VA = "0x18086A490", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x686EA90", Offset = "0x686D690", VA = "0x18686EA90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x686E9C0", Offset = "0x686D5C0", VA = "0x18686E9C0", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x686EA50", Offset = "0x686D650", VA = "0x18686EA50")]
		public RecNetCDNAssetReference(RecNetCDNKey NCMHANGAILD)
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
			[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x867D20", Offset = "0x866920", VA = "0x180867D20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x86A480", Offset = "0x869080", VA = "0x18086A480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x869EF0", Offset = "0x868AF0", VA = "0x180869EF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x686EAD0", Offset = "0x686D6D0", VA = "0x18686EAD0")]
		public static RecNetCDNKey BLNLEHBKBHJ(string EGMBPMLAEBK, string CKPFBKOGNII = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x606AD00", Offset = "0x6069900", VA = "0x18606AD00")]
		public void BNDNMELCPIN(string PNKBOBGBADJ, string FJHEHEDBGNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x686EBD0", Offset = "0x686D7D0", VA = "0x18686EBD0")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[OCDDNNLBGPA]
public class JCIJPAICILB : JBNDMPNBJBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> OBHPGNDJJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> BHOADMHIPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> BBAJKEJOAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> FEBFBDGOMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> IFHINPHHINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> BEBJIPOCCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> FNAFBLJEBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator MJJADOBKKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected BCFDHOGGIOK JGJBCPKPAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte CPOEIJLOBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> OHIHFHAEAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> LGGLFEEEDGP;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6869490", Offset = "0x6868090", VA = "0x186869490", Slot = "4")]
	public void BOBHMHJADND(Mesh KBGHMNKGJFA, Matrix4x4 APOGEMAKHMG, byte[] CLJLPPMJDLE, bool GBHKNPDJMOP = false, BOODGANOLPN.PIPFNOJLPFF OJFNDBFACOO = (BOODGANOLPN.PIPFNOJLPFF)0, int PCPFFBLPLON = -1, bool DJIGPLIEIBG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6869450", Offset = "0x6868050", VA = "0x186869450", Slot = "5")]
	public void ALFCKOALGMI(Allocator MJBDBDLLDBK, BCFDHOGGIOK EKLLLNGKKGL, byte GKLPFGCACKH, [Optional] IList<int> JCODHMKNBEE, [Optional] IList<int> PMLCMFGAPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x68696A0", Offset = "0x68682A0", VA = "0x1868696A0")]
	private static void IKJLOALNPCI(Mesh KBGHMNKGJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x68698F0", Offset = "0x68684F0", VA = "0x1868698F0")]
	public JCIJPAICILB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[OCDDNNLBGPA]
public struct MLFMKNINMPH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public BHNIEFHCJGA HIGEFPMMMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int JKNIAIBFPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public EFBJLPOCAOO DKLHDMOAAEB;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x686AC70", Offset = "0x6869870", VA = "0x18686AC70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[OCDDNNLBGPA]
[NativeContainer]
public struct EFBJLPOCAOO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct LMNHEAJJGPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector3 OBAHAJIIJPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 BCLJLGDCOIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector4 EOHCNGJBAGC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct IPKHEEAFAFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float APGOAIDNAEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float NGBGNLHAHKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float GLDPGIPELBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float PODHJCMANPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte MIKCPHJFPNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte FGOOBBFCPAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte GBDMPANIEHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte PKMOEDKHAFM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct FPMAEIIHEJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half APGOAIDNAEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half NGBGNLHAHKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half GLDPGIPELBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half PODHJCMANPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte MIKCPHJFPNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte FGOOBBFCPAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte GBDMPANIEHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte PKMOEDKHAFM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct KEDNLGBLHAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 NMMFNOOBBFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 IBJNGCDDNKI;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct EDLAIJCLLPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half4 NMMFNOOBBFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 IBJNGCDDNKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 KEDOFFOCCIK;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct HKBNBHCBGHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 NMMFNOOBBFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 IBJNGCDDNKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 KEDOFFOCCIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 PDHLLHNPOBK;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct KGNFLBBBIDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half4 NMMFNOOBBFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 IBJNGCDDNKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 KEDOFFOCCIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 PDHLLHNPOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 AGAKHOIPOPE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct PNDILAAKHLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float APGOAIDNAEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float NGBGNLHAHKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float GLDPGIPELBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float PODHJCMANPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int MIKCPHJFPNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int FGOOBBFCPAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int GBDMPANIEHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int PKMOEDKHAFM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct BOJKKKAKNAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Color NMMFNOOBBFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 IBJNGCDDNKI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct AGKLBCFPNLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color NMMFNOOBBFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 IBJNGCDDNKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 KEDOFFOCCIK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct LKNHHIEEBEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color NMMFNOOBBFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 IBJNGCDDNKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 KEDOFFOCCIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 PDHLLHNPOBK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct MJJALHOCAAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color NMMFNOOBBFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 IBJNGCDDNKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 KEDOFFOCCIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 PDHLLHNPOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 AGAKHOIPOPE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool DPJAEFALKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<LMNHEAJJGPC> FIMBIEDIHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<KEDNLGBLHAA> EHOOOIBPCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<EDLAIJCLLPO> KICHELKOBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<HKBNBHCBGHK> BLFLALKPFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<KGNFLBBBIDP> JOMFOGDFACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<FPMAEIIHEJB> ODGBJFMMLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<IPKHEEAFAFN> NHHGOJEBBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<BOJKKKAKNAK> PMNGLINEABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<AGKLBCFPNLN> LDOKGHNNJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<LKNHHIEEBEE> MDPOKGIILKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<MJJALHOCAAG> OAPEOPMLGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<PNDILAAKHLI> GGBLNANDHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> ALFCAMAIEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> MKLEDEAIENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> MGNKIMMOOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> KNGPIAJAECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> CPEDGFNBAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> NDPPAGEGJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> NJMFHPMAAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<BoneWeight> LKLMNEJOEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> AINJPEDDNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool KFBJEOMEFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool FPMMPGFCOPB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PGADCMHLKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6858FA0", Offset = "0x6857BA0", VA = "0x186858FA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6858F90", Offset = "0x6857B90", VA = "0x186858F90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int CCDLFHOBDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6859850", Offset = "0x6858450", VA = "0x186859850")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x68593B0", Offset = "0x6857FB0", VA = "0x1868593B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int LCOMCAIHALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x68587F0", Offset = "0x68573F0", VA = "0x1868587F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6858800", Offset = "0x6857400", VA = "0x186858800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int JLEAMFCHECN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6858780", Offset = "0x6857380", VA = "0x186858780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x685AAD0", Offset = "0x68596D0", VA = "0x18685AAD0")]
	public EFBJLPOCAOO(int LDPGALMNCFE, int BGOKPIDMEJA, int MNCPCNFEJMB, int ECLHDOPKHED, Allocator MJBDBDLLDBK, int LPEDLJIANKO, NHDBGLLKJNJ ENFFLEIGCNJ, bool KFBJEOMEFIB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6858810", Offset = "0x6857410", VA = "0x186858810")]
	public void DJFIPIIBLCM(int BAEBMIBABAE, Vector3 CCBJGKKCAKF, Vector3 CGDAJMLMKLA, Vector4 GLMCDBEDNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6858B60", Offset = "0x6857760", VA = "0x186858B60")]
	public void GGIKJCAABIF(int BAEBMIBABAE, BoneWeight FNMIAGKEDBH, NativeSlice<byte> CLJLPPMJDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6859860", Offset = "0x6858460", VA = "0x186859860")]
	public Color OOIBGMPCFIF(int BAEBMIBABAE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6858FB0", Offset = "0x6857BB0", VA = "0x186858FB0")]
	public void IOAAMAJMELL(int BAEBMIBABAE, Color KOBLLIODAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6859490", Offset = "0x6858090", VA = "0x186859490")]
	public void MGMKACNBAOO(byte KFOMLPEBLAB, int BAEBMIBABAE, Vector2 EBJDEKKFJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6859840", Offset = "0x6858440", VA = "0x186859840")]
	public void MNPGIPPBGNH(int BAEBMIBABAE, int HBLPMEMGDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6858B00", Offset = "0x6857700", VA = "0x186858B00")]
	public bool FCKEGOBCONI(int KFOMLPEBLAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x68593C0", Offset = "0x6857FC0", VA = "0x1868593C0")]
	public void KCACCEEPJFJ(int HNLJLAKLLJM, int JEHLDDEOFLK, int AEGGIAICNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x68588A0", Offset = "0x68574A0", VA = "0x1868588A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6859B90", Offset = "0x6858790", VA = "0x186859B90")]
	public Mesh PEBLJENJNIO([Optional] string DDKCGCNONDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[NativeContainer]
[OCDDNNLBGPA]
[DefaultMember("Item")]
public struct BHNIEFHCJGA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Mesh.MeshDataArray KIHGGPBCJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<int> MNBPIKMFCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> FMCGOENGLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<BoneWeight> LKLMNEJOEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<Matrix4x4> FCMALBJFMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> PINMONKLOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<byte> HKOCGIJACKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> HODKOAMLDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> CPOPLPLJINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeArray<sbyte> MLNBNEOGJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<byte> DACBMLIDFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<bool> DJIGPLIEIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<int> PCPFFBLPLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool KFBJEOMEFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<int> BCNPCJJHCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool FPMMPGFCOPB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int MNHFKALKPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6857470", Offset = "0x6856070", VA = "0x186857470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int HJGLCGEOIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6856E70", Offset = "0x6855A70", VA = "0x186856E70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int ALCNGGIDDFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6857010", Offset = "0x6855C10", VA = "0x186857010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int GBCPHHECCCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6857450", Offset = "0x6856050", VA = "0x186857450")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6856FF0", Offset = "0x6855BF0", VA = "0x186856FF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int PGADCMHLKNL
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6857360", Offset = "0x6855F60", VA = "0x186857360")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6857350", Offset = "0x6855F50", VA = "0x186857350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int PIBEAHEKCMK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6857370", Offset = "0x6855F70", VA = "0x186857370")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x68570E0", Offset = "0x6855CE0", VA = "0x1868570E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public BCFDHOGGIOK EIBKFCEOEAA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x68570F0", Offset = "0x6855CF0", VA = "0x1868570F0")]
		get
		{
			return default(BCFDHOGGIOK);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6857460", Offset = "0x6856060", VA = "0x186857460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte MDKNKJFOIBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6856E60", Offset = "0x6855A60", VA = "0x186856E60")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6857000", Offset = "0x6855C00", VA = "0x186857000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public OIEHOCFAFKN PJODKJCBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6857100", Offset = "0x6855D00", VA = "0x186857100")]
		get
		{
			return default(OIEHOCFAFKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6857480", Offset = "0x6856080", VA = "0x186857480")]
	public BHNIEFHCJGA(IList<Mesh> KIFOBDKAMNO, IList<Matrix4x4> MGLNNMCOKMI, IList<bool> DJIGPLIEIBG, byte GKLPFGCACKH, IList<byte[]> PHAOHNPEBDH, IList<int> DFMBOPBONEB, IList<bool> FDHLBEGKBHK, IList<int> PCPFFBLPLON, IList<int> JCODHMKNBEE, IList<int> IBECBEKGACI, Allocator MJBDBDLLDBK, BCFDHOGGIOK EKLLLNGKKGL, bool KFBJEOMEFIB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6857380", Offset = "0x6855F80", VA = "0x186857380")]
	public EFBJLPOCAOO JJLHNJDJDNO(Allocator MJBDBDLLDBK, NHDBGLLKJNJ ENFFLEIGCNJ)
	{
		return default(EFBJLPOCAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6856E80", Offset = "0x6855A80", VA = "0x186856E80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[OCDDNNLBGPA]
public class INNPJKLOCJN : JCIJPAICILB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool KBKIBJNPMGJ;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly ProfilerMarker BMMOBGAFEBN;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6868A40", Offset = "0x6867640", VA = "0x186868A40")]
	public BHNIEFHCJGA PHFFLBBAOOP()
	{
		return default(BHNIEFHCJGA);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6868D00", Offset = "0x6867900", VA = "0x186868D00")]
	public INNPJKLOCJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct OIEHOCFAFKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Mesh.MeshData AOKAIKEILJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<BoneWeight> LKLMNEJOEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeSlice<byte> FPNIIEMLDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int MLBHDCPKICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Matrix4x4 LFGKJMJFNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public int NMDNNHDBMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<byte> CLJLPPMJDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public bool OJDIJCGAMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int OABAENADDGN;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class HCCILOKOMGM : JGMGICCJDMN
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class IEGJOGPGDAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly OJAMEGDJJME PJENCKCCGIO;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public virtual bool LENKJEBMKKG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public virtual bool GMDIMAIAKNG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public virtual BOODGANOLPN.PIPFNOJLPFF NMDNNHDBMHM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "6")]
			get
			{
				return default(BOODGANOLPN.PIPFNOJLPFF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool MAIDIHGDJID
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x14D8A20", Offset = "0x14D7620", VA = "0x1814D8A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool KCHHHGNMINP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x68687F0", Offset = "0x68673F0", VA = "0x1868687F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool EGOFGGCOFNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x68687D0", Offset = "0x68673D0", VA = "0x1868687D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x865A80", Offset = "0x864680", VA = "0x180865A80")]
		protected IEGJOGPGDAA(OJAMEGDJJME LHBAGGAFJPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract HNHMCBNIKDD LIPDEOCPCNB(int[] OIBFBBINCAL, List<IMGIKIEFFPI> HDHLLECFFLB, List<IMGIKIEFFPI> LBOICDDMJDF);

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract CBDCMCDFPPJ MDOOFIEKILC(uint CIFJEOHPONH, AvatarSkinnedMeshBoneOrderRemapsData MIAGPBGLDJL);
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class JAODAPJILHH : IEGJOGPGDAA
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class GHLILCJEDOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public MOKKMPAFINF<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public JAODAPJILHH <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public GHLILCJEDOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x685B740", Offset = "0x685A340", VA = "0x18685B740")]
			internal void NOMLJBPDEAF(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly AvatarSkinAssetItem.FABEOJLDMLD PPMNNBHOMJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly AssetReference KKHOCNLBDEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly BOODGANOLPN.PIPFNOJLPFF LBJNHMGGHAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly APOLGJPCPMJ? LLLEMIFOHHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly Material[] KHPCHHAFBCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private SkinnedMeshRenderer[] PNGAPLCFMIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private AvatarSkinAssetItem GKAKNHMDHBE;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override BOODGANOLPN.PIPFNOJLPFF NMDNNHDBMHM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x867CE0", Offset = "0x8668E0", VA = "0x180867CE0", Slot = "6")]
			get
			{
				return default(BOODGANOLPN.PIPFNOJLPFF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6869340", Offset = "0x6867F40", VA = "0x186869340")]
		public JAODAPJILHH(AvatarSkinAssetItem.FABEOJLDMLD LKNFCEBJBDF, AssetReference EIDBMJAOIPM, Material OPGOOFJNIOO, OJAMEGDJJME JLBPDFLBANG, BOODGANOLPN.PIPFNOJLPFF GKNODBIHPEC = (BOODGANOLPN.PIPFNOJLPFF)0, [Optional] APOLGJPCPMJ? HEOIAEMMLPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6869230", Offset = "0x6867E30", VA = "0x186869230")]
		public JAODAPJILHH(AvatarSkinAssetItem.FABEOJLDMLD LKNFCEBJBDF, AssetReference EIDBMJAOIPM, Material OPGOOFJNIOO, BOODGANOLPN.PIPFNOJLPFF GKNODBIHPEC = (BOODGANOLPN.PIPFNOJLPFF)0, [Optional] APOLGJPCPMJ? HEOIAEMMLPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6868D10", Offset = "0x6867910", VA = "0x186868D10", Slot = "7")]
		public override HNHMCBNIKDD LIPDEOCPCNB(int[] OIBFBBINCAL, List<IMGIKIEFFPI> HDHLLECFFLB, List<IMGIKIEFFPI> LBOICDDMJDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6868EE0", Offset = "0x6867AE0", VA = "0x186868EE0", Slot = "8")]
		public override CBDCMCDFPPJ MDOOFIEKILC(uint CIFJEOHPONH, AvatarSkinnedMeshBoneOrderRemapsData MIAGPBGLDJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x68691C0", Offset = "0x6867DC0", VA = "0x1868691C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class JPGDGHJEOAJ : IEGJOGPGDAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public readonly EHPAMEPBGJJ BIOIEALOEDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private MOKKMPAFINF<EPBJBFNIFAB> CHBOJMNKJMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public EPBJBFNIFAB KHPIAPOPHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private MOKKMPAFINF<Material[]> BKIHPLJGGMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public List<Material> MFFODHNLNEG;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool LENKJEBMKKG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool GMDIMAIAKNG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6869EA0", Offset = "0x6868AA0", VA = "0x186869EA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1D54F60", Offset = "0x1D53B60", VA = "0x181D54F60")]
		public JPGDGHJEOAJ(OJAMEGDJJME LHBAGGAFJPN, EHPAMEPBGJJ IIPFFBNMODB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6869F00", Offset = "0x6868B00", VA = "0x186869F00", Slot = "7")]
		public override HNHMCBNIKDD LIPDEOCPCNB(int[] OIBFBBINCAL, List<IMGIKIEFFPI> HDHLLECFFLB, List<IMGIKIEFFPI> LBOICDDMJDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x686A3E0", Offset = "0x6868FE0", VA = "0x18686A3E0", Slot = "8")]
		public override CBDCMCDFPPJ MDOOFIEKILC(uint CIFJEOHPONH, AvatarSkinnedMeshBoneOrderRemapsData MIAGPBGLDJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6869CB0", Offset = "0x68688B0", VA = "0x186869CB0")]
		public CBDCMCDFPPJ CKPEDGBHKOA(GameObject CBNEPGPAALH, uint CIFJEOHPONH, bool HLOANFLBDJK, bool POEFDENMJNF, AvatarSkinnedMeshBoneOrderRemapsData MIAGPBGLDJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x686A510", Offset = "0x6869110", VA = "0x18686A510")]
		public static bool PCAPKCPCDCB(Renderer[] POIBJHOEJNA, string CALEGCDKPGF, [Out] Renderer OJIJGDHGCEE, [Out] Renderer MMIHBDAAAHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x686A8E0", Offset = "0x68694E0", VA = "0x18686A8E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6869BE0", Offset = "0x68687E0", VA = "0x186869BE0")]
		private (MOKKMPAFINF<EPBJBFNIFAB>, MOKKMPAFINF<Material[]>) AAONMALAGEH()
		{
			return default((MOKKMPAFINF<EPBJBFNIFAB>, MOKKMPAFINF<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x429DF40", Offset = "0x429CB40", VA = "0x18429DF40")]
		[CompilerGenerated]
		private void DDLPGIAOGKD(EPBJBFNIFAB KKIOBLFFGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x686A880", Offset = "0x6869480", VA = "0x18686A880")]
		[CompilerGenerated]
		private void PLINKNELAHM(Material[] KKIOBLFFGJH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class CFAFKIHAMDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public HCCILOKOMGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public OECOIGMFBKH buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public CFAFKIHAMDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6858620", Offset = "0x6857220", VA = "0x186858620")]
		internal void EPIKAGMINEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x68586D0", Offset = "0x68572D0", VA = "0x1868586D0")]
		internal void HEFBPOKPAFK(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x68586F0", Offset = "0x68572F0", VA = "0x1868586F0")]
		internal void MECKNLGPJOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6858640", Offset = "0x6857240", VA = "0x186858640")]
		internal void FNJCBJNAPIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990")]
		internal HNHMCBNIKDD JMODIBANEFB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class JPDJHOFFHEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public CFAFKIHAMDN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public JPDJHOFFHEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6869B20", Offset = "0x6868720", VA = "0x186869B20")]
		internal ODEJNCJNCBO NKDCGOKPFFD(int lod)
		{
			return default(ODEJNCJNCBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class NJKBJHCJGKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public List<OECOIGMFBKH> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public NJKBJHCJGKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x686C720", Offset = "0x686B320", VA = "0x18686C720")]
		internal void FJJMNOCLNLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class LKELEBCOOAL : IEnumerator<ELFHCGFNHNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private ELFHCGFNHNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public HCCILOKOMGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public List<IEGJOGPGDAA> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public List<OECOIGMFBKH> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public Func<int, ODEJNCJNCBO> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public DMMMBLJIFII materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private ELFHCGFNHNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x865A80", Offset = "0x864680", VA = "0x180865A80")]
		[DebuggerHidden]
		public LKELEBCOOAL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x686A980", Offset = "0x6869580", VA = "0x18686A980", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x686AB90", Offset = "0x6869790", VA = "0x18686AB90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class LAGPFAILHFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public HCCILOKOMGM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public LAGPFAILHFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x686A930", Offset = "0x6869530", VA = "0x18686A930")]
		internal HNHMCBNIKDD PPEDJMDEIGP(IEGJOGPGDAA p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class PLCCEKAEDNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public PNPDNAMOFGM cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public PLCCEKAEDNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8C3BF0", Offset = "0x8C27F0", VA = "0x1808C3BF0")]
		internal void KPKPGOFNCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA49F90", Offset = "0xA48B90", VA = "0x180A49F90")]
		internal void APBLMPDPHBF(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class BEPEAIFGPIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public HCCILOKOMGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public BEPEAIFGPIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class IFIPOLIPKJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public EFBJLPOCAOO defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public BHNIEFHCJGA defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public BEPEAIFGPIE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public IFIPOLIPKJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6868800", Offset = "0x6867400", VA = "0x186868800")]
		internal void IGIPEDDGCJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA40710", Offset = "0xA3F310", VA = "0x180A40710")]
		internal void LDMOAMEEJNJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class EJHFJEIHHBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public MGPBPBPOLGO legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public KGIKDPECAHO legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public BEPEAIFGPIE CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public EJHFJEIHHBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x685B500", Offset = "0x685A100", VA = "0x18685B500")]
		internal void BMABPAHECDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA41C00", Offset = "0xA40800", VA = "0x180A41C00")]
		internal void CBODPADNBIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class BBOMAPJFBEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public PNPDNAMOFGM cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public EHPAMEPBGJJ avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public HCCILOKOMGM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public BBOMAPJFBEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6856A70", Offset = "0x6855670", VA = "0x186856A70")]
		internal HNHMCBNIKDD JFHAHDEAJJM(FLOGLGKMBGA item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6856E20", Offset = "0x6855A20", VA = "0x186856E20")]
		internal void MFDNILPCAFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class ODJIAEINOOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public MOKKMPAFINF<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public ODJIAEINOOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x686C850", Offset = "0x686B450", VA = "0x18686C850")]
		internal void DIOBJBACIDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class APGOGOCGECF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public OJAMEGDJJME overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public APGOGOCGECF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x68569F0", Offset = "0x68555F0", VA = "0x1868569F0")]
		internal bool ICFMNGGAMMO(KeyValuePair<string, EHPAMEPBGJJ> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private AvatarConfiguration EHFBBGPGGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Transform OGHKAOLGELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private AssetReference KKHOCNLBDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private GameObject LMEBHFPBDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private GameObject EMFAKECJOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private SkinnedMeshRenderer AHIPHPOLNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private AvatarSkinnedMeshBoneOrderRemapsData GKLDINKMDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Transform[] ANHDJGHLGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Matrix4x4[] NBDGAGMOAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Material NBGHLOEIFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Material CJFOKHAIEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Material IMAFNGIKIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Shader FEDKALPJECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Shader GHJHCAIHIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Animator JJKGAEIJLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Renderer[] HDONFKAFLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private BOODGANOLPN.PIPFNOJLPFF HBKONFBMHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private AvatarBodyPartShapesManager PNFCJLGCDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyDictionary<string, Transform> LGDCEHKKLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private AvatarFaceShapeData.BAAECINCAMN NIGBKPHFGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private AvatarBodyShapeData.NNKKEGOIPCM GJAHLKMHMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool BPFPMFFPBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool KGPCFGDDJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Color GICALKMEHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Color JGMOONFDLKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Color FIHMDMKMICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Color? ODLECEIICIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Color? NMJPONAKOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Color? AFMJAJGEICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Color? GOCGFKFKBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Texture2D IBONCIGFJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Texture2D EJFPAPOPCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[CanBeNull]
	private EHPAMEPBGJJ FCNDCKDEMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Texture GEEDHLFBJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Color GCNLMKHEKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Dictionary<Renderer, DMMMBLJIFII> FLALEOCAKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<Renderer, DMMMBLJIFII> DMBFBEAAOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Dictionary<string, List<FPNLIAEBDCL>> AHBNEBDOPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Dictionary<string, List<FPNLIAEBDCL>> JDAKLMMACLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly List<IMGIKIEFFPI> EKJPCDFMLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly List<IMGIKIEFFPI> BEFDNKMENCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly List<IMGIKIEFFPI> NMALLLEJKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly List<IMGIKIEFFPI> LKOIPGEPJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Dictionary<FPNLIAEBDCL, Material> JOACDLDEJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Dictionary<FPNLIAEBDCL, Material> LEKKPGKBGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private SkinnedMeshRenderer[] FGMAJHFLBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private SkinnedMeshRenderer[] LAGHOKFIHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private SkinnedMeshRenderer[] DLGDJOABIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private SkinnedMeshRenderer[] FNOBGDLNGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly Dictionary<string, MOKKMPAFINF<Texture2D>> PHBDADOLEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly Dictionary<string, MOKKMPAFINF<Texture2D>> IKCPGPMBGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private FitMeshHemisphere JEJMAGDACLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private bool DGAINIFGHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private IBJDFNNFBEJ ADBHMCCNHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private bool NFICDEIFBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private AnchorParamsRestrictions NAGMMAFCGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private bool HJPIEKGLCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Transform GKKFAPMDILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Transform FAACPJMMKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool CKFEMOHKLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool CCDBJOHODIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Vector3 FOLBIMKOABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private Quaternion IMHOEBPJHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private Vector2 JBFFOFMCFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private FitMeshHemisphere FFDNPEKALOJ;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Material NDPKALLNPGG;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Material NCPOPOBDAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Dictionary<string, EHPAMEPBGJJ> AFAHBCKFBNK;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int ALCBHKJOELA;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int NBLGCNCLCGG;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int IOFNHEECGPP;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int NGGDMBFLOCM;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int IFJPBHPOLBD;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int DEFEPLBCBPB;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int IPMNNPGJKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly MMAIJBDFGNK NMEMOPIPFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly MMAIJBDFGNK CHBGGNNBOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool LHMKJNIGIGC;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static Lazy<OHCDAFPPAJP> HCMDNBKNCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private Lazy<JPMKKLGBMKE> MFHMMNJLLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private Lazy<OKDLEKLKOPO> DJCJPNDHGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private HFDCGAIKGJC KEMDPLCMBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private DBNFAKLLPMO LECHFJMMMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private List<Action> MDCDJEDFNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private ODBOJFPOMFF NDBFHDPGEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private SkinnedMeshRenderer[] NCBIHHDGGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private int OBGLCGLDOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool PFFLOPLLFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private int MPHJEDHGMEH;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool OFAHGGGKAPI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x191F110", Offset = "0x191DD10", VA = "0x18191F110")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1912AA0", Offset = "0x19116A0", VA = "0x181912AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool NDMFDENLLLI
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6861230", Offset = "0x685FE30", VA = "0x186861230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material KMOBCHDLKHM
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6863450", Offset = "0x6862050", VA = "0x186863450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Material GEIIKFNACPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6866E80", Offset = "0x6865A80", VA = "0x186866E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private bool LBKJADCFIOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public KLACEAHOGOL KPFNAHBLOKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8DCE40", Offset = "0x8DBA40", VA = "0x1808DCE40", Slot = "21")]
		get
		{
			return default(KLACEAHOGOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool HPNGICKBDHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6861070", Offset = "0x685FC70", VA = "0x186861070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private static OHCDAFPPAJP GJDMIAOEPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6860C70", Offset = "0x685F870", VA = "0x186860C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private JPMKKLGBMKE APLNBLEBLBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6865890", Offset = "0x6864490", VA = "0x186865890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private OKDLEKLKOPO JBAKIECGLCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6862BA0", Offset = "0x68617A0", VA = "0x186862BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private HFDCGAIKGJC FMEPHEIENDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x68666D0", Offset = "0x68652D0", VA = "0x1868666D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private DBNFAKLLPMO IECNMJNIJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6864490", Offset = "0x6863090", VA = "0x186864490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public MMAIJBDFGNK BFPOBIKKPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA20100", Offset = "0xA1ED00", VA = "0x180A20100", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public MMAIJBDFGNK MKHFPDLMAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x13EB460", Offset = "0x13EA060", VA = "0x1813EB460", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public SkinnedMeshRenderer[] JMLJHGIFLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x12F2D50", Offset = "0x12F1950", VA = "0x1812F2D50", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public Renderer[] HABAHKDDFCG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x872460", Offset = "0x871060", VA = "0x180872460", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool BPDPAKIKNOO
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x68604F0", Offset = "0x685F0F0", VA = "0x1868604F0", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public BOODGANOLPN.PIPFNOJLPFF HBFBHKLCLKA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8724C0", Offset = "0x8710C0", VA = "0x1808724C0", Slot = "18")]
		get
		{
			return default(BOODGANOLPN.PIPFNOJLPFF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int AOGMJALHJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1920390", Offset = "0x191EF90", VA = "0x181920390")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6860B60", Offset = "0x685F760", VA = "0x186860B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool IJDGEOBNPHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x68652E0", Offset = "0x6863EE0", VA = "0x1868652E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private static bool OMGMMGILPKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6865EA0", Offset = "0x6864AA0", VA = "0x186865EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool OEHCPLGNIDI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6862660", Offset = "0x6861260", VA = "0x186862660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6867EB0", Offset = "0x6866AB0", VA = "0x186867EB0")]
	public HCCILOKOMGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6866130", Offset = "0x6864D30", VA = "0x186866130", Slot = "26")]
	public void NJFEGHENHFC(FJKADEHHJBJ FILGCJCOKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x685CFF0", Offset = "0x685BBF0", VA = "0x18685CFF0", Slot = "27")]
	public void BIAKPBOEPKJ(AENDMGEHOHH LPDEJCFPENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6860B60", Offset = "0x685F760", VA = "0x186860B60", Slot = "4")]
	public void EPHEAIDLFEN(int CIFJEOHPONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6860660", Offset = "0x685F260", VA = "0x186860660", Slot = "9")]
	public void DEHLDIFJBAL(NGFGNJCKILF OALDOPNGMIK, Texture2D CCJNIFOFHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x68654D0", Offset = "0x68640D0", VA = "0x1868654D0", Slot = "10")]
	public void MEHLAANIHAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x685C380", Offset = "0x685AF80", VA = "0x18685C380", Slot = "11")]
	public bool APHEIHNDKBL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6862260", Offset = "0x6860E60", VA = "0x186862260", Slot = "8")]
	public void GCNJNLPCJBB(JCPNHHNPFAF PICIAHJBEIH, Color? NMMFNOOBBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x68611B0", Offset = "0x685FDB0", VA = "0x1868611B0")]
	private void FJMMODGFCIO(Action AMHCDJLKPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x685BB30", Offset = "0x685A730", VA = "0x18685BB30", Slot = "5")]
	public void ACPMPEGKLNF(EHPAMEPBGJJ LDBCHJLGAGI, Texture CNJEMONMKHD, Color HGPJHAHEMII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1912AA0", Offset = "0x19116A0", VA = "0x181912AA0", Slot = "6")]
	public void NEGOHHDGFHM(bool OPBFNDHKGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x12E8690", Offset = "0x12E7290", VA = "0x1812E8690", Slot = "7")]
	public void JMHEOCGIDIC(ODBOJFPOMFF AINJPEDDNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x685D070", Offset = "0x685BC70", VA = "0x18685D070", Slot = "14")]
	public OECOIGMFBKH BJDJLOCNFIJ(KAHKKJAPKID OAIMNHHKCOD, bool LADJBHAECBD, int[] DGFFLPKIFJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6866B70", Offset = "0x6865770", VA = "0x186866B70", Slot = "15")]
	public void OLIEFEFFPFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6864240", Offset = "0x6862E40", VA = "0x186864240")]
	private bool JMMMPINCKOA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x872400", Offset = "0x871000", VA = "0x180872400", Slot = "19")]
	public void KGADNIPEEJH(BOODGANOLPN.PIPFNOJLPFF GICBNHGCAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6864CC0", Offset = "0x68638C0", VA = "0x186864CC0")]
	private bool KOCOKHLCAKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6864660", Offset = "0x6863260", VA = "0x186864660")]
	private OECOIGMFBKH KKNMGIJCNOD(bool LADJBHAECBD, List<IEGJOGPGDAA> GJLAEGOCMHN, int[] DGFFLPKIFJD, Func<int, ODEJNCJNCBO> NOBMCOCOOAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6866D70", Offset = "0x6865970", VA = "0x186866D70")]
	[IteratorStateMachine(typeof(LKELEBCOOAL))]
	private IEnumerator<ELFHCGFNHNJ> OLIKHILFJCO(bool LADJBHAECBD, List<IEGJOGPGDAA> GJLAEGOCMHN, int[] DGFFLPKIFJD, Func<int, ODEJNCJNCBO> NOBMCOCOOAP, DMMMBLJIFII DOAOJONBPPP, Material DDEEHMGIIIN, List<OECOIGMFBKH> APKGBEEFANI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x685BD10", Offset = "0x685A910", VA = "0x18685BD10")]
	private OECOIGMFBKH AKNILHBBCEG(List<IEGJOGPGDAA> GJLAEGOCMHN, int[] DGFFLPKIFJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x685EAB0", Offset = "0x685D6B0", VA = "0x18685EAB0")]
	private NHMNIEJFONC CJAHEHGPPHB(List<IEGJOGPGDAA> GJLAEGOCMHN, int CIFJEOHPONH, bool LADJBHAECBD, ODEJNCJNCBO IJAMBPIAAJO, bool PEAEHAKGOGC, DMMMBLJIFII DOAOJONBPPP, Material DDEEHMGIIIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6862940", Offset = "0x6861540", VA = "0x186862940", Slot = "22")]
	public void GKJBFBMHLKF(AvatarFaceShape FHCAKICOLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6864180", Offset = "0x6862D80", VA = "0x186864180", Slot = "23")]
	public void JMDHOBJKMFD(AvatarBodyShape KLJNMPLDCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6863800", Offset = "0x6862400", VA = "0x186863800", Slot = "25")]
	public void JAHDCBIFLCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x685C370", Offset = "0x685AF70", VA = "0x18685C370", Slot = "24")]
	public void AOLKDIJEJJO(bool PACCBGHBOML, bool PKEJLCBBIKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6864510", Offset = "0x6863110", VA = "0x186864510")]
	private void KKHCCHLADBE(SkinnedMeshRenderer BBOENBCGDKN, int CIFJEOHPONH, Mesh KBGHMNKGJFA, List<Material> HGFDLADAEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x68663F0", Offset = "0x6864FF0", VA = "0x1868663F0")]
	private static Material NKCGGGLOCON(Dictionary<FPNLIAEBDCL, Material> BLIHKAJHHEK, Material LFKNMOANIDD, GBFDNICJDAH EHLKKOEKFJI, ABBPKICGFLF NLLDHJMJDDI, OJAMEGDJJME JLBPDFLBANG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6860F50", Offset = "0x685FB50", VA = "0x186860F50")]
	private static GBFDNICJDAH FFEAHKGIEMC(IEGJOGPGDAA LEKBIJJCBMH, int LBJGMMMGAAL)
	{
		return default(GBFDNICJDAH);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6864DB0", Offset = "0x68639B0", VA = "0x186864DB0")]
	private void LEMGLDMGALM(int OMELKODLOJG, Material DMGEDCGOKIM, IEGJOGPGDAA LEKBIJJCBMH, [Out] Texture2D DPBBBOFOIOE, [Out] Vector4 CEPGMOJFLGI, [Out] Texture2D LCAKIADHCIH, [Out] Texture2D PPFFOHHLPAA, [Out] Texture2D CGCGBAHCNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x685C500", Offset = "0x685B100", VA = "0x18685C500")]
	private void BDFOMGGPFCK(int OMELKODLOJG, Material DMGEDCGOKIM, IEGJOGPGDAA LEKBIJJCBMH, [Out] Color NCCFGNINIMA, [Out] Color OOAENAAKPPH, [Out] Color LGMIGOHIGEH, [Out] Color ADLEHEDFMGG, [Out] Color IFHLOEPCKMG, [Out] Color IBGEHGOCNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6867840", Offset = "0x6866440", VA = "0x186867840")]
	private bool PONNOKHCHMP(Material DMGEDCGOKIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6864410", Offset = "0x6863010", VA = "0x186864410")]
	private static Material KDCIHNAABCH(int OMELKODLOJG, JPGDGHJEOAJ LEKBIJJCBMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x68612E0", Offset = "0x685FEE0", VA = "0x1868612E0")]
	private static ABBPKICGFLF FOICBBJGBDC(IEGJOGPGDAA LEKBIJJCBMH, int LBJGMMMGAAL)
	{
		return default(ABBPKICGFLF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6863160", Offset = "0x6861D60", VA = "0x186863160")]
	private static void IAHJCMEKFCP(Dictionary<string, List<FPNLIAEBDCL>> NMKIFNPGKAH, IEGJOGPGDAA DHHHIKGMFLN, Material LFKNMOANIDD, GBFDNICJDAH PICIAHJBEIH, ABBPKICGFLF OALDOPNGMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6860930", Offset = "0x685F530", VA = "0x186860930")]
	private static SkinnedMeshRenderer DKFHICOLLMO(Transform OEEEODMPDKD, Transform CGJPKBCANCK, SkinnedMeshRenderer[] POIBJHOEJNA, int CIFJEOHPONH, ODEJNCJNCBO IJAMBPIAAJO, bool LADJBHAECBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x68635E0", Offset = "0x68621E0", VA = "0x1868635E0")]
	private void IKHPCJPIOBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6863D80", Offset = "0x6862980", VA = "0x186863D80")]
	private void JJCNMPHDCEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x68676E0", Offset = "0x68662E0", VA = "0x1868676E0")]
	private static void PJAIOKCBBBL(Dictionary<FPNLIAEBDCL, Material> BLIHKAJHHEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6863AC0", Offset = "0x68626C0", VA = "0x186863AC0")]
	private static void JICMIEODLGO(Dictionary<Renderer, DMMMBLJIFII> IOBGPFJIOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6862A00", Offset = "0x6861600", VA = "0x186862A00")]
	private void GNMJNOIPJNE(SkinnedMeshRenderer[] POIBJHOEJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x68674C0", Offset = "0x68660C0", VA = "0x1868674C0")]
	private void PBLBIDMDGLO(SkinnedMeshRenderer HNFOIDEICFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6860D80", Offset = "0x685F980", VA = "0x186860D80")]
	private void FDEPFDJNLAI(List<IMGIKIEFFPI> IDFNBOKLCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x68613D0", Offset = "0x685FFD0", VA = "0x1868613D0")]
	private void GADPDMIPNAD(Dictionary<string, MOKKMPAFINF<Texture2D>> NMKIFNPGKAH, bool NCDOFIAIOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x68637B0", Offset = "0x68623B0", VA = "0x1868637B0")]
	private void IMEGNMOBNFM(Dictionary<string, List<FPNLIAEBDCL>> NMKIFNPGKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6863C20", Offset = "0x6862820", VA = "0x186863C20")]
	private void JIKCJKKPGOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x68620D0", Offset = "0x6860CD0", VA = "0x1868620D0")]
	private void GCGMGMDHJKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6866F70", Offset = "0x6865B70", VA = "0x186866F70")]
	private void PBENHEHBFGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6862870", Offset = "0x6861470", VA = "0x186862870")]
	private void GHIEKAAGBKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6863D90", Offset = "0x6862990", VA = "0x186863D90")]
	private void JKMDLBAGBOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x685BBA0", Offset = "0x685A7A0", VA = "0x18685BBA0")]
	private void AEENAMLHGFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6865400", Offset = "0x6864000", VA = "0x186865400")]
	private void MEALFDFKBEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6863A20", Offset = "0x6862620", VA = "0x186863A20")]
	private void JGJNEOHFCCL(bool AIDLEDILLIK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6865AD0", Offset = "0x68646D0", VA = "0x186865AD0")]
	private void MLMADJMFGGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6861240", Offset = "0x685FE40", VA = "0x186861240")]
	private void FMHCGAFCHNB(bool AIDLEDILLIK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6865550", Offset = "0x6864150", VA = "0x186865550")]
	private void MFHNFDMGFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6862DF0", Offset = "0x68619F0", VA = "0x186862DF0")]
	private void HPECJGPNIKO(Material DDEEHMGIIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x68665E0", Offset = "0x68651E0", VA = "0x1868665E0")]
	private void ODHJLCLHNHE(Material DDEEHMGIIIN, Color OOAENAAKPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6866040", Offset = "0x6864C40", VA = "0x186866040")]
	private void NJDDDHHMAIJ(Material DDEEHMGIIIN, Color LGMIGOHIGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x68675F0", Offset = "0x68661F0", VA = "0x1868675F0")]
	private void PIMPMCPIIKG(Material DDEEHMGIIIN, Color NCCFGNINIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6865C30", Offset = "0x6864830", VA = "0x186865C30")]
	private void MOJCGHNKLHK(Material DDEEHMGIIIN, Texture2D CCJNIFOFHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6860B80", Offset = "0x685F780", VA = "0x186860B80")]
	private void EKOIJNMBNBE(Material DDEEHMGIIIN, Texture LMIPKNFKKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x68658E0", Offset = "0x68644E0", VA = "0x1868658E0")]
	private void MKANHBMBHBG(Action<DMMMBLJIFII> KCHBMPKDPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6865D20", Offset = "0x6864920", VA = "0x186865D20")]
	private void NCMJNJDMPOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6863E20", Offset = "0x6862A20", VA = "0x186863E20")]
	private void JLGKOODKBNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x685CA00", Offset = "0x685B600", VA = "0x18685CA00")]
	private OECOIGMFBKH BEDIJINIIDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x68667A0", Offset = "0x68653A0", VA = "0x1868667A0")]
	private void OKOMOLLJMPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x685E690", Offset = "0x685D290", VA = "0x18685E690")]
	public void BJODDHIBKHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6865390", Offset = "0x6863F90", VA = "0x186865390")]
	private void MBMJMAMIFAE(Vector3 MMKDAECKHPD, Quaternion BHKKDEGOAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x685BFD0", Offset = "0x685ABD0", VA = "0x18685BFD0")]
	private void ANBOHCGLDFN(List<IEGJOGPGDAA> NFHINMIADBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6861550", Offset = "0x6860150", VA = "0x186861550")]
	public void GBEPNPJAPOM(IBJDFNNFBEJ JCJHPKFKKEE, bool DKLJFCEOAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6861A50", Offset = "0x6860650", VA = "0x186861A50")]
	public void GBEPNPJAPOM(IBJDFNNFBEJ JCJHPKFKKEE, AnchorParamsRestrictions KJFHELHLONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xA0AE80", Offset = "0xA09A80", VA = "0x180A0AE80")]
	private static void BEOOOFFCGGM(FitMeshHemisphere JBGMPJIMGHP, Transform HKLLLIFJEMH, IBJDFNNFBEJ JCJHPKFKKEE, AnchorParamsRestrictions INEBGHDIHOM, [Out] Vector3 PNBKCIFAGHL, [Out] Quaternion DIBEOMGKEFO, [Out] IBJDFNNFBEJ CPCLJAHIOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6867AA0", Offset = "0x68666A0", VA = "0x186867AA0")]
	public void PPFOBHMGCFB(Vector2 KGNKDHFGCEN, Vector3 EKIPMKFBEEE, Vector3 PGHBEDDAPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6862BF0", Offset = "0x68617F0", VA = "0x186862BF0")]
	private void HHODKBICAHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6860CF0", Offset = "0x685F8F0", VA = "0x186860CF0")]
	private void ENMNDPPLNFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6867560", Offset = "0x6866160", VA = "0x186867560")]
	[CompilerGenerated]
	private void PGKEJMHNLDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6864D80", Offset = "0x6863980", VA = "0x186864D80")]
	[CompilerGenerated]
	private void LDOJHCHCLIP(DMMMBLJIFII PLJANKCMGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6864380", Offset = "0x6862F80", VA = "0x186864380")]
	[CompilerGenerated]
	private void KDACFMHFODA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x685BCF0", Offset = "0x685A8F0", VA = "0x18685BCF0")]
	[CompilerGenerated]
	private void AFPMLNJOLHO(DMMMBLJIFII PLJANKCMGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x68651F0", Offset = "0x6863DF0", VA = "0x1868651F0")]
	[CompilerGenerated]
	private void LGPCIPPEAPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6866780", Offset = "0x6865380", VA = "0x186866780")]
	[CompilerGenerated]
	private void OKKGGCCAPKN(DMMMBLJIFII PLJANKCMGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6862D60", Offset = "0x6861960", VA = "0x186862D60")]
	[CompilerGenerated]
	private void HMGCCOBIJPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6865360", Offset = "0x6863F60", VA = "0x186865360")]
	[CompilerGenerated]
	private void MANLKFLOBOD(DMMMBLJIFII PLJANKCMGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x685EA20", Offset = "0x685D620", VA = "0x18685EA20")]
	[CompilerGenerated]
	private void CFJJGOIPMJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6860870", Offset = "0x685F470", VA = "0x186860870")]
	[CompilerGenerated]
	private void DIJJLHODCOL(DMMMBLJIFII PLJANKCMGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6866550", Offset = "0x6865150", VA = "0x186866550")]
	[CompilerGenerated]
	private void NOGODEJOKDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6865280", Offset = "0x6863E80", VA = "0x186865280")]
	[CompilerGenerated]
	private void LIAGBCODGKO(DMMMBLJIFII PLJANKCMGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x68608A0", Offset = "0x685F4A0", VA = "0x1868608A0")]
	[CompilerGenerated]
	private void DINAJKKJCMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x68652B0", Offset = "0x6863EB0", VA = "0x1868652B0")]
	[CompilerGenerated]
	private void LKKJCJEEADE(DMMMBLJIFII PLJANKCMGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6862B20", Offset = "0x6861720", VA = "0x186862B20")]
	[CompilerGenerated]
	private void HAHHFBBDCLC(KeyValuePair<string, MOKKMPAFINF<Texture2D>> KALEMCMHEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6865BA0", Offset = "0x68647A0", VA = "0x186865BA0")]
	[CompilerGenerated]
	private void MNCIDHAEMOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6865AA0", Offset = "0x68646A0", VA = "0x186865AA0")]
	[CompilerGenerated]
	private void MKDGOJALOCC(DMMMBLJIFII PLJANKCMGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6864C30", Offset = "0x6863830", VA = "0x186864C30")]
	[CompilerGenerated]
	private void KNBKPJGFICE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6866750", Offset = "0x6865350", VA = "0x186866750")]
	[CompilerGenerated]
	private void OHFHFKPCPMI(DMMMBLJIFII PLJANKCMGOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class PDBJCCFFMBI : JEDFGLFPNJF
{
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly int PKAHHIGLALA;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly int ACDJMCDPFAL;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int CLOGIAEGNLN;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int ACNMPFEBIGB;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly int AKIKLIOLFOD;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly int OCNALKIANFA;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int JFMAKMCKJIN;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int ECPKAPLMOMM;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int FKJOICNDDEP;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly int CAJKDGJIHEJ;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly int AEFOJKJOILG;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly int LGBEDFHGIPB;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly int BIPIFNBGHFB;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static readonly int NPEFEIOMDNE;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly int KCENBKONMLM;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static readonly int ABBMDDKCCGK;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly int EPABANLOAKD;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly int JBKCAFHJHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Transform JAFFNAEFEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private Transform GICNINHKGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private Transform KMLEEEDFJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private Transform EHOPCDANNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private Transform GKHLJNDEGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private Transform PBIGLEBBAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private Transform ODNKKJACDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private BCKLOGLNNHM GLHHGIKMGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private MaterialPropertyBlock OECKDKALCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private SkinnedMeshRenderer[] KNFDICFMHCM;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private MaterialPropertyBlock NELAADIKKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x686CBF0", Offset = "0x686B7F0", VA = "0x18686CBF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool FIIEBMHFBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x686CCE0", Offset = "0x686B8E0", VA = "0x18686CCE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x686E570", Offset = "0x686D170", VA = "0x18686E570", Slot = "7")]
	public void NJFEGHENHFC(BCKLOGLNNHM DBFEODNANIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x686CC70", Offset = "0x686B870", VA = "0x18686CC70", Slot = "8")]
	public void CBGLCPLBDJN(IMEOOPLDHNE KIDBNMFPDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x686E140", Offset = "0x686CD40", VA = "0x18686E140", Slot = "5")]
	public void LIOHOENCHHI(NCJCNOMJPHJ PHJNLCLNHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x686E000", Offset = "0x686CC00", VA = "0x18686E000")]
	private Vector2 KAKIKHILODB(Vector2 CELEIFNEKKH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x686CE60", Offset = "0x686BA60", VA = "0x18686CE60", Slot = "6")]
	public void JLILEPPKFNE(PICBPEHMOKB KIDBNMFPDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x686C8A0", Offset = "0x686B4A0", VA = "0x18686C8A0")]
	private void ACJNGHPKONF(PICBPEHMOKB KPOPKBONALA, HGELFFJEGPF PKLEIMOLLCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x686E060", Offset = "0x686CC60", VA = "0x18686E060")]
	private void KIBLKMFEFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x686E960", Offset = "0x686D560", VA = "0x18686E960")]
	public PDBJCCFFMBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x686DF70", Offset = "0x686CB70", VA = "0x18686DF70")]
	[CompilerGenerated]
	internal static (float, float) JOCFOIIPNPM(float FEBFBHDEMCO)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x686CCA0", Offset = "0x686B8A0", VA = "0x18686CCA0")]
	[CompilerGenerated]
	internal static Vector4 FBJCHGNCBFF(Vector2 DCDKACDAEIJ, Vector2 DANMJNNJDHD)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class DMMMBLJIFII : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private MaterialPropertyBlock JACJECMMJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public Color? IDPNBAAKFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public Color? FCAINOPJHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public Color? BPHMKKJCIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public Color? LPJMCGMCPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public Color LKKEMPEGEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public Color JJBGBNBMHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public Color ECLHEONNFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public Texture2D CPNEDIILHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public Texture2D CPELPIHEOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private Dictionary<FPNLIAEBDCL, int> PHJGOMGKOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private GBFDNICJDAH[] GDOLIODNJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private ABBPKICGFLF[] DPLDDNOHEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public Vector4[] EFBCMPNLEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public Vector4[] BEIHOLNAJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public Vector4[] PKLPJCONPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public Vector4[] EHHDINKOLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public Vector4[] OINMLDABLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public Vector4[] BKMENHMDNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private List<Texture2D> BELBKENGFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private Vector4[] MDLFNFOFBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private List<Texture2D> LJDDHPJFDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private float[] HBEDHKKNGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private Vector4[] NBGCHHPLCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private float[] HOPAFDABFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public float[] JLELHNHBKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private List<Texture2D> NHNIGNIDAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private float[] DDAFGOECJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private List<Texture2D> ACJOGMGBJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private Vector4[] LDHNPANIHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private float[] GBJHBCECEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private Vector4[] HIBAHGANJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public float[] ELEEJEDHLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public Texture2DArray GHDHHOKDJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public Texture2DArray NJIAHLNEDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public Texture2DArray MGHMAGHCAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public Texture2DArray OHABMEKIMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private bool JKNJDKMPAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private int OONFGFABLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private Vector2? BGNCNLHLHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private TextureFormat LGOPPNNPINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private Vector2? EADKAPAALAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private TextureFormat FHCFCLOMMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private Vector2? OJDFOIMANOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private TextureFormat EKALOCACKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private Vector2? FJIIINGLMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private TextureFormat CGCFAONIMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private bool KFHJMPBIANF;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static int EMJNLOPDCAO;

	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private static int EHKDOBIDJMG;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private static int GBGOGHGDLFD;

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private static int EKBHDNLDHNB;

	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private static int KIKHMOBIOHB;

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private static int HBGIDGGNDNE;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private static int GFDCEEIECHI;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static int JGFNPGMOELM;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static int MOMDOHHMOFJ;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private static int GFIDGAIIODM;

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static int POFFGDOGKNH;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static int MLDDGFBKGLC;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static int ONINNNCNNJA;

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private static int ODDJKMKNNFD;

	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private static int NIIFBFALCND;

	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static int MIBFBJHOCOE;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static int KBMEHBONNNF;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static int AMKHPJDPHLJ;

	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private static int LNLEIGPNIGH;

	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private static int JHKKHEJCHNI;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6872A30", Offset = "0x6871630", VA = "0x186872A30")]
	private DMMMBLJIFII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6872F20", Offset = "0x6871B20", VA = "0x186872F20")]
	public DMMMBLJIFII(Color MMKKOHMBLFH, Color PECDGOIELHF, Color BEIFHIOJNOJ, Color? LPKMENEIOGI, Color? CLNKCJJJAJP, Color? EBJBAABCKJP, Texture2D MHBNAHFLIIG, Texture2D KGLHDIFJBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x68725B0", Offset = "0x68711B0", VA = "0x1868725B0")]
	internal int OOPDIJEMAAO(Material CPGEIKJPAPO, GBFDNICJDAH EHLKKOEKFJI, ABBPKICGFLF NLLDHJMJDDI, OJAMEGDJJME JLBPDFLBANG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6872520", Offset = "0x6871120", VA = "0x186872520")]
	private int OOPDIJEMAAO(FPNLIAEBDCL NCMHANGAILD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x68703B0", Offset = "0x686EFB0", VA = "0x1868703B0")]
	internal int AGOADIHHFMA(Material CPGEIKJPAPO, Color NCCFGNINIMA, Color OOAENAAKPPH, Color LGMIGOHIGEH, Color ADLEHEDFMGG, Color IFHLOEPCKMG, Texture2D FGFFPKHAEAI, Vector4 ELLPIDEJGIH, Texture2D PJGEDIKNONG, Vector4 KPOCHABAEDJ, float MNCNLJPFJIA, float NHFMLLNHGBM, Texture2D GKEDAIHKNNL, Vector4 LEPAGDKJHCC, float LHEEBBOGGBK, Texture2D LLPPNJJLKON, Color IBGEHGOCNFH, Vector4 INPFGOEEOOB, GBFDNICJDAH EHLKKOEKFJI, ABBPKICGFLF NLLDHJMJDDI, OJAMEGDJJME JLBPDFLBANG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6871510", Offset = "0x6870110", VA = "0x186871510")]
	private void KKAAGLJGAGJ(List<Texture2D> BELBKENGFHE, [Out] Texture2DArray MNMAMFDNIBB, [Out] Texture2DArray CHHJOEKMBEF, [Out] Texture2DArray MELCNLDKEKF, [Out] Texture2DArray LCLPCKKPOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x68711C0", Offset = "0x686FDC0", VA = "0x1868711C0")]
	public void GCAIHOMMANA(Shader IKCPLBIALBD, Renderer PFFACGHHFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x68717D0", Offset = "0x68703D0", VA = "0x1868717D0")]
	private void NEIJEKHGHEP(Shader IKCPLBIALBD, Renderer PFFACGHHFOH, int PDEPKDDFEOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6870FC0", Offset = "0x686FBC0", VA = "0x186870FC0")]
	private Color EPHJGBKONBJ(Color MBBNHPKKPCL, GBFDNICJDAH PICIAHJBEIH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6871310", Offset = "0x686FF10", VA = "0x186871310")]
	private Color HJKMBFOGCDO(Color IFAPKGAEABL, GBFDNICJDAH PICIAHJBEIH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x68716D0", Offset = "0x68702D0", VA = "0x1868716D0")]
	private bool MCGHEPFEDFP(Texture2D DJGELCHDFIO, ABBPKICGFLF OALDOPNGMIK, [Out] Texture2D EHPNMCHIBOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6871460", Offset = "0x6870060", VA = "0x186871460")]
	private void IIEJPONEHFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6870F80", Offset = "0x686FB80", VA = "0x186870F80", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[Obsolete("Use CombinationId instead!")]
		[SerializeField]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private IHENJGOPBKG? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public PJILGJPEDNH CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x686FDA0", Offset = "0x686E9A0", VA = "0x18686FDA0")]
			get
			{
				return default(PJILGJPEDNH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public IHENJGOPBKG MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x686FDF0", Offset = "0x686E9F0", VA = "0x18686FDF0")]
			get
			{
				return default(IHENJGOPBKG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x86DF40", Offset = "0x86CB40", VA = "0x18086DF40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x872470", Offset = "0x871070", VA = "0x180872470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x686FA20", Offset = "0x686E620", VA = "0x18686FA20")]
		public Material[] AEOCENBKLAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x686FB10", Offset = "0x686E710", VA = "0x18686FB10")]
		public static void HJJKOJBKGIE(AvatarItemMaterial NCFMGEOABBL, Material DMGEDCGOKIM, int OMELKODLOJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x686FCD0", Offset = "0x686E8D0", VA = "0x18686FCD0")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[OCDDNNLBGPA]
public struct GINHBGGMKBB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	[ReadOnly]
	public KGIKDPECAHO HIGEFPMMMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	[ReadOnly]
	public int JKNIAIBFPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public MGPBPBPOLGO DKLHDMOAAEB;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6873E90", Offset = "0x6872A90", VA = "0x186873E90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[OCDDNNLBGPA]
[NativeContainer]
public struct MGPBPBPOLGO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public NativeArray<Vector3> GHPNJCOMOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public NativeArray<Vector3> DLDPCHMBJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public NativeArray<Vector4> JGOLKFPHFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public NativeArray<Vector2> PMMMPFGEHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public NativeArray<Vector2> PDHLLHNPOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeArray<Vector2> AGAKHOIPOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<Vector2> BKOAEEAPOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NativeArray<Color> DIILCJHFJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public NativeArray<int> ALFCAMAIEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeArray<int> MKLEDEAIENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private NativeArray<int> MGNKIMMOOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private NativeArray<int> KNGPIAJAECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeArray<int> CPEDGFNBAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeArray<int> NDPPAGEGJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public NativeArray<int> NJMFHPMAAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public NativeArray<BoneWeight> CBJPNKMLBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private NativeArray<int> AINJPEDDNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private bool FPMMPGFCOPB;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int PGADCMHLKNL
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6877DA0", Offset = "0x68769A0", VA = "0x186877DA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6877D90", Offset = "0x6876990", VA = "0x186877D90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int CCDLFHOBDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6877F10", Offset = "0x6876B10", VA = "0x186877F10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6877DD0", Offset = "0x68769D0", VA = "0x186877DD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int LCOMCAIHALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6877840", Offset = "0x6876440", VA = "0x186877840")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6877850", Offset = "0x6876450", VA = "0x186877850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6878290", Offset = "0x6876E90", VA = "0x186878290")]
	public MGPBPBPOLGO(int LDPGALMNCFE, int BGOKPIDMEJA, int MNCPCNFEJMB, int ECLHDOPKHED, Allocator MJBDBDLLDBK, int LPEDLJIANKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6877910", Offset = "0x6876510", VA = "0x186877910")]
	public void DJFIPIIBLCM(int BAEBMIBABAE, Vector3 CCBJGKKCAKF, Vector3 CGDAJMLMKLA, Vector4 GLMCDBEDNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6877BF0", Offset = "0x68767F0", VA = "0x186877BF0")]
	public void GGIKJCAABIF(int BAEBMIBABAE, BoneWeight FNMIAGKEDBH, NativeSlice<byte> CLJLPPMJDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6877F20", Offset = "0x6876B20", VA = "0x186877F20")]
	public Color OOIBGMPCFIF(int BAEBMIBABAE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6877DB0", Offset = "0x68769B0", VA = "0x186877DB0")]
	public void IOAAMAJMELL(int BAEBMIBABAE, Color KOBLLIODAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6877EB0", Offset = "0x6876AB0", VA = "0x186877EB0")]
	public void MGMKACNBAOO(byte KFOMLPEBLAB, int BAEBMIBABAE, Vector2 EBJDEKKFJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6877F00", Offset = "0x6876B00", VA = "0x186877F00")]
	public void MNPGIPPBGNH(int BAEBMIBABAE, int HBLPMEMGDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6877BC0", Offset = "0x68767C0", VA = "0x186877BC0")]
	public bool FCKEGOBCONI(int KFOMLPEBLAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6877DE0", Offset = "0x68769E0", VA = "0x186877DE0")]
	public void KCACCEEPJFJ(int HNLJLAKLLJM, int JEHLDDEOFLK, int AEGGIAICNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6877860", Offset = "0x6876460", VA = "0x186877860")]
	public int[] CKDMFKCGLGK(int HNLJLAKLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6877980", Offset = "0x6876580", VA = "0x186877980")]
	private NativeSlice<int> DMCBDECDHDM(int HNLJLAKLLJM)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6877A10", Offset = "0x6876610", VA = "0x186877A10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6877F40", Offset = "0x6876B40", VA = "0x186877F40")]
	public Mesh PEBLJENJNIO([Optional] string DDKCGCNONDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[OCDDNNLBGPA]
[NativeContainer]
[DefaultMember("Item")]
public struct KGIKDPECAHO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public NativeArray<Vector3> GHPNJCOMOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<Vector3> DLDPCHMBJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public NativeArray<Vector4> JGOLKFPHFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<Vector2> PMMMPFGEHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public NativeArray<Vector2> PDHLLHNPOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public NativeArray<Vector2> AGAKHOIPOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeArray<Vector2> BKOAEEAPOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeArray<Color> DIILCJHFJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<int> HAJNIOIOCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<int> CHMJEBGEJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<int> OLOEOKMKDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<int> OJFBOEEBBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<bool> DJIGPLIEIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<int> PCPFFBLPLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<int> FMCGOENGLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<BoneWeight> LKLMNEJOEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private NativeArray<Matrix4x4> FCMALBJFMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private NativeArray<int> PINMONKLOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private NativeArray<byte> HKOCGIJACKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private NativeArray<int> HODKOAMLDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private NativeArray<int> CPOPLPLJINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<sbyte> MLNBNEOGJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<byte> DACBMLIDFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private NativeArray<int> BCNPCJJHCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private bool FPMMPGFCOPB;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int MNHFKALKPPD
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x1FFE370", Offset = "0x1FFCF70", VA = "0x181FFE370")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int HJGLCGEOIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x1023870", Offset = "0x1022470", VA = "0x181023870")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int ALCNGGIDDFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x68754E0", Offset = "0x68740E0", VA = "0x1868754E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int GBCPHHECCCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6875B50", Offset = "0x6874750", VA = "0x186875B50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x68754C0", Offset = "0x68740C0", VA = "0x1868754C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int PGADCMHLKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6875A60", Offset = "0x6874660", VA = "0x186875A60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6875A50", Offset = "0x6874650", VA = "0x186875A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int PIBEAHEKCMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6875A70", Offset = "0x6874670", VA = "0x186875A70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6875510", Offset = "0x6874110", VA = "0x186875510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public BCFDHOGGIOK EIBKFCEOEAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6875520", Offset = "0x6874120", VA = "0x186875520")]
		get
		{
			return default(BCFDHOGGIOK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6875B60", Offset = "0x6874760", VA = "0x186875B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public byte MDKNKJFOIBP
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6875250", Offset = "0x6873E50", VA = "0x186875250")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x68754D0", Offset = "0x68740D0", VA = "0x1868754D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public MHKBNADNPDB PJODKJCBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6874130", VA = "0x186875530")]
		get
		{
			return default(MHKBNADNPDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6875B70", Offset = "0x6874770", VA = "0x186875B70")]
	public KGIKDPECAHO(IList<Mesh> KIFOBDKAMNO, IList<Matrix4x4> MGLNNMCOKMI, IList<bool> DJIGPLIEIBG, byte GKLPFGCACKH, IList<byte[]> PHAOHNPEBDH, IList<int> DFMBOPBONEB, IList<bool> FDHLBEGKBHK, IList<int> PCPFFBLPLON, IList<int> JCODHMKNBEE, IList<int> IBECBEKGACI, Allocator MJBDBDLLDBK, BCFDHOGGIOK EKLLLNGKKGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6875A80", Offset = "0x6874680", VA = "0x186875A80")]
	public MGPBPBPOLGO JJLHNJDJDNO(Allocator MJBDBDLLDBK)
	{
		return default(MGPBPBPOLGO);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6875260", Offset = "0x6873E60", VA = "0x186875260", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[OCDDNNLBGPA]
public class HOCAPKHKLBP : JCIJPAICILB
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6874DA0", Offset = "0x68739A0", VA = "0x186874DA0")]
	public KGIKDPECAHO PHFFLBBAOOP()
	{
		return default(KGIKDPECAHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6868D00", Offset = "0x6867900", VA = "0x186868D00")]
	public HOCAPKHKLBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct MHKBNADNPDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeSlice<Vector3> GHPNJCOMOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeSlice<Vector3> DLDPCHMBJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeSlice<Vector4> JGOLKFPHFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeSlice<Vector2> PMMMPFGEHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeSlice<Vector2> PDHLLHNPOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeSlice<Vector2> AGAKHOIPOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeSlice<Vector2> BKOAEEAPOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeSlice<Color> DIILCJHFJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeSlice<int> DHEHFAAEHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeSlice<int> OJFBOEEBBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeSlice<BoneWeight> LKLMNEJOEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeSlice<byte> FPNIIEMLDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public int MLBHDCPKICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public Matrix4x4 LFGKJMJFNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public int NMDNNHDBMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public NativeSlice<byte> CLJLPPMJDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public bool OJDIJCGAMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public int OABAENADDGN;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal readonly struct FPNLIAEBDCL : IEquatable<FPNLIAEBDCL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	internal readonly Material HGAKPOFCKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	internal readonly GBFDNICJDAH KILEFBCAFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	internal readonly ABBPKICGFLF NFCABAFPFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	internal readonly OJAMEGDJJME LEIHDFJDNHA;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xA401B0", Offset = "0xA3EDB0", VA = "0x180A401B0")]
	public FPNLIAEBDCL(Material DMGEDCGOKIM, GBFDNICJDAH EHLKKOEKFJI, ABBPKICGFLF NLLDHJMJDDI, OJAMEGDJJME JLBPDFLBANG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6873380", Offset = "0x6871F80", VA = "0x186873380", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0xA3FD70", Offset = "0xA3E970", VA = "0x180A3FD70", Slot = "4")]
	public bool Equals(FPNLIAEBDCL HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x68731F0", Offset = "0x6871DF0", VA = "0x1868731F0", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x68732E0", Offset = "0x6871EE0", VA = "0x1868732E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class IOBELBMLEHA
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class KMAKKMDHJOA : IEnumerator<ELFHCGFNHNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private ELFHCGFNHNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private ELFHCGFNHNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x865A80", Offset = "0x864680", VA = "0x180865A80")]
		[DebuggerHidden]
		public KMAKKMDHJOA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA41580", Offset = "0xA40180", VA = "0x180A41580", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6877350", Offset = "0x6875F50", VA = "0x186877350", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
	public static void CCAMFKMFPIP(string CABAGOHBNFK, int CIFJEOHPONH, long PEAJCAFNGLM, long KHMEJFFPGHI, long IMDDMHNDHJM, long GNAPMOEAPFM, long DJCJIDGHDHJ, long INCPIHCNKFG, long LJPEINMBKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6875100", Offset = "0x6873D00", VA = "0x186875100")]
	public static NHMNIEJFONC OJDOLKLBMKH(JobHandle NPELGGDOKEO, bool LJCBLDKFEOB, bool LBKJADCFIOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6875090", Offset = "0x6873C90", VA = "0x186875090")]
	[IteratorStateMachine(typeof(KMAKKMDHJOA))]
	private static IEnumerator<ELFHCGFNHNJ> LAAAMFONOHC(JobHandle MJBLPCEDGPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class MOCHNENBEBA : OKDLEKLKOPO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private GAFJMLOFMFH IHJGKCMJDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private PCBAILHPIKK GABCPAIAOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private IRecRoomQualityConfigProvider DNGKGDGEPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private bool FPMMPGFCOPB;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6879100", Offset = "0x6877D00", VA = "0x186879100")]
	[DHOHFCLMOGD(IDHBAGABJJA.GameOnly)]
	private static void EIIOALHJGEO(IMEOEBHKJNP MLGAMJFBMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5B8E6C0", Offset = "0x5B8D2C0", VA = "0x185B8E6C0")]
	[UnityEngine.Scripting.Preserve]
	public MOCHNENBEBA([POJODGKFIMO(null)] PCBAILHPIKK JGKBCMNPKNI, [POJODGKFIMO(null)] GAFJMLOFMFH BILEHJPDNAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x68791F0", Offset = "0x6877DF0", VA = "0x1868791F0")]
	private void LABPOHCEHOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6879260", Offset = "0x6877E60", VA = "0x186879260", Slot = "4")]
	public void MEHLAANIHAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6878C40", Offset = "0x6877840", VA = "0x186878C40", Slot = "5")]
	public MOKKMPAFINF<Texture2D> AEMBMCCOJBO(FLOGLGKMBGA EPNGNADLHIK, [Optional] ODBOJFPOMFF AINJPEDDNEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x68792C0", Offset = "0x6877EC0", VA = "0x1868792C0")]
	private uint NLDCCGNCAMN(FLOGLGKMBGA EPNGNADLHIK, ODBOJFPOMFF AINJPEDDNEM)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface JBNDMPNBJBN
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BOBHMHJADND(Mesh KBGHMNKGJFA, Matrix4x4 APOGEMAKHMG, byte[] CLJLPPMJDLE, bool GBHKNPDJMOP = false, BOODGANOLPN.PIPFNOJLPFF OJFNDBFACOO = (BOODGANOLPN.PIPFNOJLPFF)0, int PCPFFBLPLON = -1, bool DJIGPLIEIBG = false);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALFCKOALGMI(Allocator MJBDBDLLDBK, BCFDHOGGIOK EKLLLNGKKGL, byte GKLPFGCACKH, [Optional] IList<int> JCODHMKNBEE, [Optional] IList<int> PMLCMFGAPDK);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct EPBJBFNIFAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public readonly GameObject CBNEPGPAALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private readonly AvatarItemMaterial ELEKPBLJDJB;

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0xAC5C80", Offset = "0xAC4880", VA = "0x180AC5C80")]
	public EPBJBFNIFAB(GameObject CBNEPGPAALH, AvatarItemMaterial ELEKPBLJDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6872FE0", Offset = "0x6871BE0", VA = "0x186872FE0")]
	public void LPOGKBFAEHO(Material DMGEDCGOKIM, int OMELKODLOJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class AFNIIPMCBFN : KMNBJOHJECJ<Task<(GameObject, AvatarItemMaterial)>, EPBJBFNIFAB>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct MLGADFFNHGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x68786D0", Offset = "0x68772D0", VA = "0x1868786D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6878BD0", Offset = "0x68777D0", VA = "0x186878BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private MOKKMPAFINF<GameObject> PCKJFHJCCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private MOKKMPAFINF<AvatarItemMaterial> KJLOPGJPPAN;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x686F990", Offset = "0x686E590", VA = "0x18686F990")]
	private AFNIIPMCBFN(Task<(GameObject, AvatarItemMaterial)> LJPOAIPEHGB, MOKKMPAFINF<GameObject> PCJDONCFPDK, MOKKMPAFINF<AvatarItemMaterial> ONPFJNOBPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x686F580", Offset = "0x686E180", VA = "0x18686F580")]
	public static AFNIIPMCBFN NCPDNLLGMJA(AssetReference MFGEIEPCFPO, [Optional] AssetReference NDFINDIMLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x686F330", Offset = "0x686DF30", VA = "0x18686F330", Slot = "11")]
	protected override EPBJBFNIFAB BJPJEBFHILK(Task<(GameObject, AvatarItemMaterial)> PIPGNAIFLGO)
	{
		return default(EPBJBFNIFAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x686F3D0", Offset = "0x686DFD0", VA = "0x18686F3D0", Slot = "12")]
	protected override void COKLMBDGFJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x686F450", Offset = "0x686E050", VA = "0x18686F450")]
	[AsyncStateMachine(typeof(MLGADFFNHGH))]
	private static Task<(GameObject, AvatarItemMaterial)> GFFGOEGGAIH(Task<GameObject> ICDDEBPDLPA, Task<AvatarItemMaterial> KJFFNOJMCCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class LPGEHGOPNEE
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class CKNOJLDFOBA : KMNBJOHJECJ<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class PIHPKAEEEEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public MaterialEntry entry;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			public string shaderNameToFind;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public PIHPKAEEEEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x68797B0", Offset = "0x68783B0", VA = "0x1868797B0")]
			internal object EKBFNPKLKBG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x6879A00", Offset = "0x6878600", VA = "0x186879A00")]
			internal object OAJLAMBMLAI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private MOKKMPAFINF<MaterialMapAsset> MJBLPCEDGPJ;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x68702D0", Offset = "0x686EED0", VA = "0x1868702D0")]
		public CKNOJLDFOBA(MOKKMPAFINF<MaterialMapAsset> MJBLPCEDGPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x686FEB0", Offset = "0x686EAB0", VA = "0x18686FEB0", Slot = "11")]
		protected override Material[] BJPJEBFHILK(Task<MaterialMapAsset> LJPOAIPEHGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x686FFA0", Offset = "0x686EBA0", VA = "0x18686FFA0", Slot = "12")]
		protected override void COKLMBDGFJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6870000", Offset = "0x686EC00", VA = "0x186870000")]
		private Material MHOOOEPBOMP(MaterialEntry NGIGIBHNOJE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private class ICIONEOIBIF : KMNBJOHJECJ<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private List<MOKKMPAFINF<Material>> OGFCEDKDAFA;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6875020", Offset = "0x6873C20", VA = "0x186875020")]
		public ICIONEOIBIF(Task<Material[]> LJPOAIPEHGB, List<MOKKMPAFINF<Material>> OGFCEDKDAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6874E90", Offset = "0x6873A90", VA = "0x186874E90", Slot = "11")]
		protected override Material[] BJPJEBFHILK(Task<Material[]> PIPGNAIFLGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6874EE0", Offset = "0x6873AE0", VA = "0x186874EE0", Slot = "12")]
		protected override void COKLMBDGFJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private static readonly EEGEMFOKJOP IGMINGONOGN;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x68773A0", Offset = "0x6875FA0", VA = "0x1868773A0")]
	public static MOKKMPAFINF<Material[]> IGCECLDBCMF(AssetReference[] CNBNECFLFHK)
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
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[KJNKIIMENHL(OBLJNCJJPID.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6879C50", Offset = "0x6878850", VA = "0x186879C50")]
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
		private struct NBJHNGOBALO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public AsyncTaskMethodBuilder<GACKPBEBADM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			public int eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			private TaskAwaiter<GACKPBEBADM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x6879400", Offset = "0x6878000", VA = "0x186879400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x6879740", Offset = "0x6878340", VA = "0x186879740", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private Dictionary<APOLGJPCPMJ, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private Dictionary<APOLGJPCPMJ, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private Dictionary<APOLGJPCPMJ, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private Dictionary<APOLGJPCPMJ, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private readonly Dictionary<APOLGJPCPMJ, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private GACKPBEBADM _defaultFaceStyle;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x6873E60", Offset = "0x6872A60", VA = "0x186873E60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6873900", Offset = "0x6872500", VA = "0x186873900")]
		public GACKPBEBADM HHJGJOMLAOB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6873CA0", Offset = "0x68728A0", VA = "0x186873CA0")]
		[AsyncStateMachine(typeof(NBJHNGOBALO))]
		public Task<GACKPBEBADM> PFCFBEGHDAP(int KKCCPMFJMHN, int LIKBBCIFHCB, int CAOIAOOCNJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x68735B0", Offset = "0x68721B0", VA = "0x1868735B0")]
		public NoseFaceOption EGIPEFBBHCO(int NJPKBJFEHFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6873B20", Offset = "0x6872720", VA = "0x186873B20")]
		public SelectableFaceOption LAMINKLMCDA(FaceFeatureType LKOKPNNCBEM, APOLGJPCPMJ PGPHOGAGGMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6873880", Offset = "0x6872480", VA = "0x186873880")]
		public int FFOGFJGEKCB(APOLGJPCPMJ PGPHOGAGGMM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6873650", Offset = "0x6872250", VA = "0x186873650")]
		private void FEEDKAPCAKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2B1EA30", Offset = "0x2B1D630", VA = "0x182B1EA30")]
		private void LKOIDLDHEHL<T>(IDictionary<APOLGJPCPMJ, T> CNAIHKDCKLB, IReadOnlyList<T> IFNNLHFEOKA) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6873A70", Offset = "0x6872670", VA = "0x186873A70")]
		public APOLGJPCPMJ JPNGNLNNJOO(FaceFeatureType LKOKPNNCBEM)
		{
			return default(APOLGJPCPMJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6873950", Offset = "0x6872550", VA = "0x186873950")]
		public APOLGJPCPMJ IICJBJEDNKC(FaceFeatureType LKOKPNNCBEM)
		{
			return default(APOLGJPCPMJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6873DD0", Offset = "0x68729D0", VA = "0x186873DD0")]
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
