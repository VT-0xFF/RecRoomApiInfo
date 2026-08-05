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
	public class LogRegistrationIndex : MBMEJMGLEPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x67563F0", Offset = "0x6754DF0", VA = "0x1867563F0", Slot = "4")]
		public override void PMAGAGNLFOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x84FE00", Offset = "0x84E800", VA = "0x18084FE00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6768180", Offset = "0x6766B80", VA = "0x186768180", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x67680B0", Offset = "0x6766AB0", VA = "0x1867680B0", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6768140", Offset = "0x6766B40", VA = "0x186768140")]
		public RecNetCDNAssetReference(RecNetCDNKey LDDEKIBHION)
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
			[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x850E40", Offset = "0x84F840", VA = "0x180850E40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x84EC50", Offset = "0x84D650", VA = "0x18084EC50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x850E30", Offset = "0x84F830", VA = "0x180850E30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x67681C0", Offset = "0x6766BC0", VA = "0x1867681C0")]
		public static RecNetCDNKey KOLNEHMHGNO(string LMJDNBEAMFG, string MGNNJGKGGGH = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F65B60", Offset = "0x5F64560", VA = "0x185F65B60")]
		public void FGOCHMJGFMD(string LOKHFLAFAIL, string JAJGGBFDMEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x67682C0", Offset = "0x6766CC0", VA = "0x1867682C0")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[FABAIOIDLJO]
public class JMLHCOLOCOM : JPALEDBOMGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> PFPHKOIEGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> LAILKDODPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> ODFEDJCMCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> DJJCLKHHKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> KDEDEGPLDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> DFPBFHLCBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> DHEHJBDGEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator OONJGEFPCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected IMNGDKEFCMP COBLNCNNEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte HFJGBFKDGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> KCGHONBJOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> IBGMADPIBND;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6755AF0", Offset = "0x67544F0", VA = "0x186755AF0", Slot = "4")]
	public void GLFKJNOAFCH(Mesh KJFFCELEION, Matrix4x4 DCGDHJGPNMF, byte[] EPBDOKLLLKF, bool CLIOGHCCIEA = false, BFJEAAGLFCO.DNAKBNCOFJG NMKGEOLFBCH = (BFJEAAGLFCO.DNAKBNCOFJG)0, int DHCKDNLNDLE = -1, bool DCAIJJJJFPG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6755AB0", Offset = "0x67544B0", VA = "0x186755AB0", Slot = "5")]
	public void ANLLACKAJJN(Allocator BPMIGAHMDHE, IMNGDKEFCMP FBIHBEAKGKG, byte NGPJMODJHPE, [Optional] IList<int> MPCKJPKENNI, [Optional] IList<int> DMKNLMBAEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6755E00", Offset = "0x6754800", VA = "0x186755E00")]
	private static void PECDNJFLBHJ(Mesh KJFFCELEION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6755F30", Offset = "0x6754930", VA = "0x186755F30")]
	public JMLHCOLOCOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[FABAIOIDLJO]
public struct GLNFJOCCKBO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public CMKGGCDAMMO FLLEAEPLLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int OJFHEDGOIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public NOIAGHKCOIO NIJBPOEEAAF;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x67536C0", Offset = "0x67520C0", VA = "0x1867536C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[FABAIOIDLJO]
[NativeContainer]
public struct NOIAGHKCOIO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct CLJPCLPGCFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector3 DLMIBMLNOKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 GKJCNLBHEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector4 GMLKGNBBAOM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct KMMOELPPOMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float BKPDBCKOPLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float MFFEGKENGBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float DLHLGJCHGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float CGFLJKKCLOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte AGAPLODFPPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte GHPDPNHLJIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte MIHOMOKOHPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte ILNKNPACMGC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct OELDADFGLFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half BKPDBCKOPLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half MFFEGKENGBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half DLHLGJCHGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half CGFLJKKCLOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte AGAPLODFPPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte GHPDPNHLJIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte MIHOMOKOHPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte ILNKNPACMGC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct JKFOAHHLHIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 COGPPELINPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 AOKPEMOACMI;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct HCAGNDIFPKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half4 COGPPELINPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 AOKPEMOACMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 OMKIDMJOIPN;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct DPCJMFODIGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 COGPPELINPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 AOKPEMOACMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 OMKIDMJOIPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 CGJMFDDNPJK;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct AKLENLOBBDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half4 COGPPELINPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 AOKPEMOACMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 OMKIDMJOIPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 CGJMFDDNPJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 LAFNPKHFKID;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct OEIEHFDOFGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float BKPDBCKOPLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float MFFEGKENGBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float DLHLGJCHGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float CGFLJKKCLOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int AGAPLODFPPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int GHPDPNHLJIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int MIHOMOKOHPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int ILNKNPACMGC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct BCAKCIPLHJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Color COGPPELINPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 AOKPEMOACMI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct MPJLLJGFOHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color COGPPELINPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 AOKPEMOACMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 OMKIDMJOIPN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct JMHKOLHBDEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color COGPPELINPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 AOKPEMOACMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 OMKIDMJOIPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 CGJMFDDNPJK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct DPCCDOHNNGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color COGPPELINPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 AOKPEMOACMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 OMKIDMJOIPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 CGJMFDDNPJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 LAFNPKHFKID;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool DANNDOHOIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<CLJPCLPGCFL> BGPAALHBJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<JKFOAHHLHIJ> DOCJAALDBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<HCAGNDIFPKD> MODOFKPAFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<DPCJMFODIGK> IKICEOPGFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<AKLENLOBBDL> IDOFAIKCHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<OELDADFGLFE> JOOLGNNLEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<KMMOELPPOMG> EDFFDJDLLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<BCAKCIPLHJO> JAFMKHPMELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<MPJLLJGFOHO> CADKGOBMHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<JMHKOLHBDEE> LPJDHHNGEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<DPCCDOHNNGI> KIDIAJEMIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<OEIEHFDOFGO> PKAIMFAILLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> JPEIIPODMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> IDBHCDFLNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> KFCFODACCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> EKHKKJLICGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> NCNEADCHEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> KPMFBPEFDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> GEOOMIDIIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<BoneWeight> PGDNNCAEKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> FFNDHFNNMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool BOIAKHHAPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool EPOFGFEHKFH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int LBNLPHLAGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x67586C0", Offset = "0x67570C0", VA = "0x1867586C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x67586D0", Offset = "0x67570D0", VA = "0x1867586D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int PGCPNGCJKHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x675A580", Offset = "0x6758F80", VA = "0x18675A580")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x675A620", Offset = "0x6759020", VA = "0x18675A620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int LEODKHCBHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x675A630", Offset = "0x6759030", VA = "0x18675A630")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x675A570", Offset = "0x6758F70", VA = "0x18675A570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int DMMLFIOMJPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x675A640", Offset = "0x6759040", VA = "0x18675A640")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x675A9E0", Offset = "0x67593E0", VA = "0x18675A9E0")]
	public NOIAGHKCOIO(int LFKJLBCMMGH, int JLGFIAJPKKE, int KBAGHKAEMHI, int AGPKBHKENCE, Allocator BPMIGAHMDHE, int DGKFHEKIMIA, KCPECHAIDDP BBECBGPNOFL, bool BOIAKHHAPJN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x675A590", Offset = "0x6758F90", VA = "0x18675A590")]
	public void JNNDBIHLLLO(int ILOCEPPJPDO, Vector3 CGDFPKFKHGF, Vector3 LLBFGGBOIAC, Vector4 FOCADABILLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x675A0E0", Offset = "0x6758AE0", VA = "0x18675A0E0")]
	public void HNPBKOKOPDI(int ILOCEPPJPDO, BoneWeight HKFAGMDCAHJ, NativeSlice<byte> EPBDOKLLLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x675A6B0", Offset = "0x67590B0", VA = "0x18675A6B0")]
	public Color OMMAKDDEMKN(int ILOCEPPJPDO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6758A10", Offset = "0x6757410", VA = "0x186758A10")]
	public void EBGHAAOIECL(int ILOCEPPJPDO, Color PEJELGOBPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6759D30", Offset = "0x6758730", VA = "0x186759D30")]
	public void HIDMCLOLLHP(byte EPMMHCBMHIG, int ILOCEPPJPDO, Vector2 LPEONEDLICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x67586B0", Offset = "0x67570B0", VA = "0x1867586B0")]
	public void BCPMCDHHFBB(int ILOCEPPJPDO, int PAOOOAMOCGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x675A510", Offset = "0x6758F10", VA = "0x18675A510")]
	public bool HOCNKLKHJNC(int EPMMHCBMHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x67586E0", Offset = "0x67570E0", VA = "0x1867586E0")]
	public void CMACHINCGIL(int ADFHAOENDMG, int LJEHDHLGGJA, int NDKEFFPEPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x67587B0", Offset = "0x67571B0", VA = "0x1867587B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6758E10", Offset = "0x6757810", VA = "0x186758E10")]
	public Mesh HEJHBFBIEPB([Optional] string LFEFABOMEAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[NativeContainer]
[FABAIOIDLJO]
[DefaultMember("Item")]
public struct CMKGGCDAMMO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Mesh.MeshDataArray FGBJIKBGKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<int> AAKADEBKAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> JOHJFEMCHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<BoneWeight> PGDNNCAEKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<Matrix4x4> BOFLBKDLKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> LAOLPGMLHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<byte> PBMHLKFKBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> NEFEFPEKBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> IBBNGBICMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeArray<sbyte> NJJMEGIALID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<byte> LPPCJENIHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<bool> DCAIJJJJFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<int> DHCKDNLNDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool BOIAKHHAPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<int> NDDGKOFJKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool EPOFGFEHKFH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int LOJGDLJIPDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x67510C0", Offset = "0x674FAC0", VA = "0x1867510C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int EBOBNIJOFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x67510A0", Offset = "0x674FAA0", VA = "0x1867510A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int BLDGDKCAFAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x67510D0", Offset = "0x674FAD0", VA = "0x1867510D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int IHFODCMFOMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6751070", Offset = "0x674FA70", VA = "0x186751070")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6750BA0", Offset = "0x674F5A0", VA = "0x186750BA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int LBNLPHLAGHN
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6750BB0", Offset = "0x674F5B0", VA = "0x186750BB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6750BC0", Offset = "0x674F5C0", VA = "0x186750BC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int CLKHANIAMOM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x67510B0", Offset = "0x674FAB0", VA = "0x1867510B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6750E10", Offset = "0x674F810", VA = "0x186750E10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IMNGDKEFCMP AMOBOFOJPOP
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6750B90", Offset = "0x674F590", VA = "0x186750B90")]
		get
		{
			return default(IMNGDKEFCMP);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6751090", Offset = "0x674FA90", VA = "0x186751090")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte NANADAPOJMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6751080", Offset = "0x674FA80", VA = "0x186751080")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x67511A0", Offset = "0x674FBA0", VA = "0x1867511A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public AMDADMIKPIA PBAJKHBLIBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6750E20", Offset = "0x674F820", VA = "0x186750E20")]
		get
		{
			return default(AMDADMIKPIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x67511B0", Offset = "0x674FBB0", VA = "0x1867511B0")]
	public CMKGGCDAMMO(IList<Mesh> JOBNDMKACOK, IList<Matrix4x4> MJFECONCLGF, IList<bool> DCAIJJJJFPG, byte NGPJMODJHPE, IList<byte[]> IBIFAADLBHH, IList<int> IEMILNGHNFO, IList<bool> MKKLNCLMLFG, IList<int> DHCKDNLNDLE, IList<int> MPCKJPKENNI, IList<int> EAKMKIMCDGH, Allocator BPMIGAHMDHE, IMNGDKEFCMP FBIHBEAKGKG, bool BOIAKHHAPJN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6750BD0", Offset = "0x674F5D0", VA = "0x186750BD0")]
	public NOIAGHKCOIO DJFHFKEOPBB(Allocator BPMIGAHMDHE, KCPECHAIDDP BBECBGPNOFL)
	{
		return default(NOIAGHKCOIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6750CA0", Offset = "0x674F6A0", VA = "0x186750CA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[FABAIOIDLJO]
public class MBJGNGBNJKM : JMLHCOLOCOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool BPJKOLHJEHF;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6756480", Offset = "0x6754E80", VA = "0x186756480")]
	public CMKGGCDAMMO GOFPHALMMGO()
	{
		return default(CMKGGCDAMMO);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x67565A0", Offset = "0x6754FA0", VA = "0x1867565A0")]
	public MBJGNGBNJKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct AMDADMIKPIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Mesh.MeshData MNNBOHJMAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeSlice<BoneWeight> PGDNNCAEKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<byte> JNBLLKOHBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public int KEIFIDMMGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Matrix4x4 IFNOKIACFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public int GNPEOCIFCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeSlice<byte> EPBDOKLLLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public bool IMICJFJCFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public int KKCCGPJCKPD;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PAPIJKGPMIJ : BIJPKIHDHNF
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class IBHEFPIBJJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public readonly INEMDIPNFNK FMPEAKBHOFD;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public virtual bool GEFDJMCACGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public virtual bool OHLLEOCPFPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public virtual BFJEAAGLFCO.DNAKBNCOFJG GNPEOCIFCBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "6")]
			get
			{
				return default(BFJEAAGLFCO.DNAKBNCOFJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool NELJMHHGCFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x14C6610", Offset = "0x14C5010", VA = "0x1814C6610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool OGLIOOBBHAG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x67557C0", Offset = "0x67541C0", VA = "0x1867557C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool ADJMMOKHFPE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x67557A0", Offset = "0x67541A0", VA = "0x1867557A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x852730", Offset = "0x851130", VA = "0x180852730")]
		protected IBHEFPIBJJM(INEMDIPNFNK CFEEFIHKPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract BIIHIAPDGKK MJHMDMJHJDI(int[] OLAIIOPGECO, List<GKEFEFBOJBB> HHLGNNMNOPN, List<GKEFEFBOJBB> PJLOIKAFBDF);

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract HMPGADGOOKG AIMBGFOGCPE(uint IADKDCBBENH, AvatarSkinnedMeshBoneOrderRemapsData ADEAIGOJDGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class BDMFLHGAPJK : IBHEFPIBJJM
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class HANMOJNAKID
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public AMHDMMJJKND<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public BDMFLHGAPJK <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public HANMOJNAKID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x67553B0", Offset = "0x6753DB0", VA = "0x1867553B0")]
			internal void ABGLNPCHMHC(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly AvatarSkinAssetItem.NJLFBEGMKJC FFOJAGEFNOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly AssetReference PIFACPDDHIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly BFJEAAGLFCO.DNAKBNCOFJG DLFBEAGLMFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly ENFHCMKIOHI? ENKOEMOHNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly Material[] OMPNMMMIJAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private SkinnedMeshRenderer[] CEJILHOBONK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private AvatarSkinAssetItem LNDHKMDMLKD;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override BFJEAAGLFCO.DNAKBNCOFJG GNPEOCIFCBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8566A0", Offset = "0x8550A0", VA = "0x1808566A0", Slot = "6")]
			get
			{
				return default(BFJEAAGLFCO.DNAKBNCOFJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6750A80", Offset = "0x674F480", VA = "0x186750A80")]
		public BDMFLHGAPJK(AvatarSkinAssetItem.NJLFBEGMKJC FAAJIONIPLO, AssetReference DOFDMMIIPCN, Material KGGMKMBMEJA, INEMDIPNFNK JBINPCPMLJG, BFJEAAGLFCO.DNAKBNCOFJG BJHOEDNBCLK = (BFJEAAGLFCO.DNAKBNCOFJG)0, [Optional] ENFHCMKIOHI? KKMAKFHMKDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6750970", Offset = "0x674F370", VA = "0x186750970")]
		public BDMFLHGAPJK(AvatarSkinAssetItem.NJLFBEGMKJC FAAJIONIPLO, AssetReference DOFDMMIIPCN, Material KGGMKMBMEJA, BFJEAAGLFCO.DNAKBNCOFJG BJHOEDNBCLK = (BFJEAAGLFCO.DNAKBNCOFJG)0, [Optional] ENFHCMKIOHI? KKMAKFHMKDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6750730", Offset = "0x674F130", VA = "0x186750730", Slot = "7")]
		public override BIIHIAPDGKK MJHMDMJHJDI(int[] OLAIIOPGECO, List<GKEFEFBOJBB> HHLGNNMNOPN, List<GKEFEFBOJBB> PJLOIKAFBDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6750450", Offset = "0x674EE50", VA = "0x186750450", Slot = "8")]
		public override HMPGADGOOKG AIMBGFOGCPE(uint IADKDCBBENH, AvatarSkinnedMeshBoneOrderRemapsData ADEAIGOJDGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6750900", Offset = "0x674F300", VA = "0x186750900", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class DNOMEDBBMHM : IBHEFPIBJJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public readonly OBJBFOFBDMJ EJFFBOCDEJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private AMHDMMJJKND<OEKCNLOCNKN> DELGBMIBKFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public OEKCNLOCNKN ECAMAKPCGNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private AMHDMMJJKND<Material[]> JHEHBHNMDLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public List<Material> PKHFFKOPJJP;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool GEFDJMCACGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool OHLLEOCPFPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6752590", Offset = "0x6750F90", VA = "0x186752590", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1D12EB0", Offset = "0x1D118B0", VA = "0x181D12EB0")]
		public DNOMEDBBMHM(INEMDIPNFNK CFEEFIHKPCN, OBJBFOFBDMJ LOCOLALLKOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x67527E0", Offset = "0x67511E0", VA = "0x1867527E0", Slot = "7")]
		public override BIIHIAPDGKK MJHMDMJHJDI(int[] OLAIIOPGECO, List<GKEFEFBOJBB> HHLGNNMNOPN, List<GKEFEFBOJBB> PJLOIKAFBDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6752400", Offset = "0x6750E00", VA = "0x186752400", Slot = "8")]
		public override HMPGADGOOKG AIMBGFOGCPE(uint IADKDCBBENH, AvatarSkinnedMeshBoneOrderRemapsData ADEAIGOJDGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x67525F0", Offset = "0x6750FF0", VA = "0x1867525F0")]
		public HMPGADGOOKG KPPJDFDKEOK(GameObject JMGCEOHHNKC, uint IADKDCBBENH, bool KNNMPFCGJML, bool NLOBEPNKEHM, AvatarSkinnedMeshBoneOrderRemapsData ADEAIGOJDGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6752D90", Offset = "0x6751790", VA = "0x186752D90")]
		public static bool OGNLPMKCDNB(Renderer[] OFNIJNKNEGI, string HLDAJNIAIPG, [Out] Renderer KLKEFGKFADO, [Out] Renderer HPNNMEFAEMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6753100", Offset = "0x6751B00", VA = "0x186753100", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6752CC0", Offset = "0x67516C0", VA = "0x186752CC0")]
		private (AMHDMMJJKND<OEKCNLOCNKN>, AMHDMMJJKND<Material[]>) NMIKFHBLNDO()
		{
			return default((AMHDMMJJKND<OEKCNLOCNKN>, AMHDMMJJKND<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x42AD280", Offset = "0x42ABC80", VA = "0x1842AD280")]
		[CompilerGenerated]
		private void AEIOEKPNGNN(OEKCNLOCNKN EBPHIJANMPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6752530", Offset = "0x6750F30", VA = "0x186752530")]
		[CompilerGenerated]
		private void ECNHMLOOKIP(Material[] EBPHIJANMPN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class NACGPCECEIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public PAPIJKGPMIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public BBADIINDDOJ buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public NACGPCECEIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x67566F0", Offset = "0x67550F0", VA = "0x1867566F0")]
		internal void MCJLHAHLPAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6756640", Offset = "0x6755040", VA = "0x186756640")]
		internal void JOEAELNNLKB(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6756660", Offset = "0x6755060", VA = "0x186756660")]
		internal void LOKMKGBOJGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x67565B0", Offset = "0x6754FB0", VA = "0x1867565B0")]
		internal void IPBOMIBFPMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
		internal BIIHIAPDGKK DKCDOKEJGFC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class ANLOALHDHEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public NACGPCECEIN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public ANLOALHDHEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6750390", Offset = "0x674ED90", VA = "0x186750390")]
		internal MKKGGNPGIFD BKNIKHOOKCG(int lod)
		{
			return default(MKKGGNPGIFD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class EENJHKJHKFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public List<BBADIINDDOJ> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public EENJHKJHKFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x67531A0", Offset = "0x6751BA0", VA = "0x1867531A0")]
		internal void NFJGECDICMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class JMCBDJPOCKM : IEnumerator<IHLELHJPJMK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private IHLELHJPJMK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public PAPIJKGPMIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public List<IBHEFPIBJJM> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public List<BBADIINDDOJ> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Func<int, MKKGGNPGIFD> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public JFLLHCFDPFN materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private IHLELHJPJMK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x852730", Offset = "0x851130", VA = "0x180852730")]
		[DebuggerHidden]
		public JMCBDJPOCKM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6755850", Offset = "0x6754250", VA = "0x186755850", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6755A60", Offset = "0x6754460", VA = "0x186755A60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class EAIJHGGAJKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public PAPIJKGPMIJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public EAIJHGGAJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6753150", Offset = "0x6751B50", VA = "0x186753150")]
		internal BIIHIAPDGKK FJGFOHJFEHM(IBHEFPIBJJM p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class AGFEFFAKHKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public AOOCMHLLLPD cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public AGFEFFAKHKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x96EE50", Offset = "0x96D850", VA = "0x18096EE50")]
		internal void NICOKMDDEPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA24140", Offset = "0xA22B40", VA = "0x180A24140")]
		internal void ANAGOIAINNP(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class FKEMFIKHGEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public PAPIJKGPMIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public FKEMFIKHGEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class LHNBCKPFLPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public NOIAGHKCOIO defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public CMKGGCDAMMO defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public FKEMFIKHGEC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public LHNBCKPFLPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x67561B0", Offset = "0x6754BB0", VA = "0x1867561B0")]
		internal void LIDNGJGHFFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA26160", Offset = "0xA24B60", VA = "0x180A26160")]
		internal void FDDAMADKPMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class GPNJPPPGFHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public KHAIKFDEKCO legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public KKJMJLHHBHD legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public FKEMFIKHGEC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public GPNJPPPGFHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6755170", Offset = "0x6753B70", VA = "0x186755170")]
		internal void ELGCCPDCPMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA2D930", Offset = "0xA2C330", VA = "0x180A2D930")]
		internal void HJFKENBGJCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class FNMGHGEDPKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public AOOCMHLLLPD cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public OBJBFOFBDMJ avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public PAPIJKGPMIJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public FNMGHGEDPKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6753310", Offset = "0x6751D10", VA = "0x186753310")]
		internal BIIHIAPDGKK MAIPKJIKINM(EBEIPBGALFP item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x67532D0", Offset = "0x6751CD0", VA = "0x1867532D0")]
		internal void EAHHOKBLBPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class LGAEINMKMLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public AMHDMMJJKND<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public LGAEINMKMLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6756160", Offset = "0x6754B60", VA = "0x186756160")]
		internal void BBGBACNFCHE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class IFLBAHMHKNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public INEMDIPNFNK overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public IFLBAHMHKNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x67557D0", Offset = "0x67541D0", VA = "0x1867557D0")]
		internal bool OCIDICFCIHC(KeyValuePair<string, OBJBFOFBDMJ> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private AvatarConfiguration MKFLKHGMGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Transform JAGOIKAOOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private AssetReference PIFACPDDHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private GameObject LCOKCPKDKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private GameObject OBHKHBJGANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private SkinnedMeshRenderer COEDLDHHJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private AvatarSkinnedMeshBoneOrderRemapsData OBIKPFAJBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private Transform[] EFIEEBCHIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Matrix4x4[] KJENMAAGMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Material CPICHDNFDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Material HNAOANKLAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Material BEFPJABNMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Shader AFMJFPDNEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Shader AJMLJANNLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Animator OHMKNCBLLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Renderer[] DALOCOOKKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private BFJEAAGLFCO.DNAKBNCOFJG FIFHBHDGNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private AvatarBodyPartShapesManager CBNOIMLALCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private IReadOnlyDictionary<string, Transform> BFMDCJHIIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private AvatarFaceShapeData.GDEJDPFCHLE OPEGHAINDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private AvatarBodyShapeData.KNNKGENOCJD EENLHGEEJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool NLPEJPGEDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool PFDIGJOMHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Color MJEHOEDFFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Color ECEAAFBGMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Color PNDOGGJCBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Color? OKFNLFONJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Color? FFDBLFPEEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Color? MBCJJCNLOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Color? KDCLKCGBFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Texture2D ELBMFMHEDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Texture2D BCPCHMCHGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[CanBeNull]
	private OBJBFOFBDMJ BLLLFGCLOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Texture CEACAHDNLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Color CLOAPIAICOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Dictionary<Renderer, JFLLHCFDPFN> IKLNGEDBKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Dictionary<Renderer, JFLLHCFDPFN> KALPAHLFBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<string, List<FLEKBPBNDPD>> ECGPCGEOJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Dictionary<string, List<FLEKBPBNDPD>> NPLNJNFFGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly List<GKEFEFBOJBB> DOCGPDCHLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly List<GKEFEFBOJBB> IHMDFOFLOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly List<GKEFEFBOJBB> BOIJPAFJJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly List<GKEFEFBOJBB> FLNLCJAKHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private Dictionary<FLEKBPBNDPD, Material> BICKDCGOEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Dictionary<FLEKBPBNDPD, Material> NIFCOKNMJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private SkinnedMeshRenderer[] LDHFCLBMAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private SkinnedMeshRenderer[] JMDDPFDFOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private SkinnedMeshRenderer[] ABLGCDJIALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private SkinnedMeshRenderer[] NEMHJOELNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly Dictionary<string, AMHDMMJJKND<Texture2D>> JOGCNFHDGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly Dictionary<string, AMHDMMJJKND<Texture2D>> PKLMCNDLMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private FitMeshHemisphere BDLIPNPJKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private bool KLANHEEGHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private IFEDJPPADLJ MDFBOLPPGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool FFOLEGEJGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private AnchorParamsRestrictions NKPHEKEJDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private bool OIFDNHHKGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Transform NKMOOIHPHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Transform OCDEMCIEPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private bool KCIIPNNCGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool MNHDGBJPHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Vector3 EOKLOLFCMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Quaternion OHKHEOLCGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private Vector2 MLCAGLFPDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private FitMeshHemisphere HCBBBMIMBBP;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private Material HJEKKIIGLOH;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Material ICHOBKDKFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Dictionary<string, OBJBFOFBDMJ> FOMCCPJFEEO;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int FHJFJAFJCFJ;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int GIDKEIDANNJ;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int COMHFCFIPML;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int IFKJCIFABAH;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int OLJGJABPFLF;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int LNNAIECJNDD;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int DNFOMIOODNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly MNIMPDIHNFL CNLALPKBMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly MNIMPDIHNFL NBPIKMHONBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool MGONDIEAGGC;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static Lazy<CDGIPBDNDHL> OMDCNLLGDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private Lazy<MNNCMDJENGI> PBJJBKBLCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private Lazy<GMNHEEAIECH> DJOOJMCJPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private BACKHJNLNPC JBKJEJEMOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private KIIIEFGAAIL JMKGEPOJPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private List<Action> MFHJFNCLMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NGNMNMDGIGH DAMIDIJGCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private SkinnedMeshRenderer[] PPOOBFLKHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int PHPOOKPDKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool OMKKAHPENEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private int NCLAGLFHDDI;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool IDGBLKINFJL
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x67646E0", Offset = "0x67630E0", VA = "0x1867646E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6764FD0", Offset = "0x67639D0", VA = "0x186764FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool HBALDHCOPAL
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xE1E810", Offset = "0xE1D210", VA = "0x180E1E810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material GLOCCHKEIJA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6760850", Offset = "0x675F250", VA = "0x186760850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Material BKHFHEAAPLF
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6760760", Offset = "0x675F160", VA = "0x186760760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private bool GBDFIMEKMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public BOPNNGIGHPK DEFAIEMDABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8B8450", Offset = "0x8B6E50", VA = "0x1808B8450", Slot = "21")]
		get
		{
			return default(BOPNNGIGHPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool PGACICIEOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6766050", Offset = "0x6764A50", VA = "0x186766050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private static CDGIPBDNDHL IMGPIAJMBBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x675FDB0", Offset = "0x675E7B0", VA = "0x18675FDB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private MNNCMDJENGI KNFHFJNLIOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x675FD60", Offset = "0x675E760", VA = "0x18675FD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private GMNHEEAIECH HFCIKDNOIAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6766B30", Offset = "0x6765530", VA = "0x186766B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private BACKHJNLNPC ENPFHCCDEDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x67617A0", Offset = "0x67601A0", VA = "0x1867617A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private KIIIEFGAAIL JPNPGJAAJOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x67646F0", Offset = "0x67630F0", VA = "0x1867646F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public MNIMPDIHNFL OACOEPNJKOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA03CE0", Offset = "0xA026E0", VA = "0x180A03CE0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public MNIMPDIHNFL GGFBHAKGHDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x13C1DC0", Offset = "0x13C07C0", VA = "0x1813C1DC0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public SkinnedMeshRenderer[] CJFBGGOMAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAEEF30", Offset = "0xAED930", VA = "0x180AEEF30", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public Renderer[] HAMKDFOIBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x855180", Offset = "0x853B80", VA = "0x180855180", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool ACNGEOEAOLG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x675B410", Offset = "0x6759E10", VA = "0x18675B410", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public BFJEAAGLFCO.DNAKBNCOFJG NPDONCIJIAO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8550C0", Offset = "0x853AC0", VA = "0x1808550C0", Slot = "18")]
		get
		{
			return default(BFJEAAGLFCO.DNAKBNCOFJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int HDMCPCHIOCK
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6766B80", Offset = "0x6765580", VA = "0x186766B80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x675DC90", Offset = "0x675C690", VA = "0x18675DC90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool KFILDLNEELE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x67606E0", Offset = "0x675F0E0", VA = "0x1867606E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private static bool BAPMOJBPOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6760ED0", Offset = "0x675F8D0", VA = "0x186760ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool IKDAHONFGKE
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x675ED40", Offset = "0x675D740", VA = "0x18675ED40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6767790", Offset = "0x6766190", VA = "0x186767790")]
	public PAPIJKGPMIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x675E0B0", Offset = "0x675CAB0", VA = "0x18675E0B0", Slot = "26")]
	public void CCPNKNOIBEC(FMONJEAPHMB MECENPOOPDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x675FE30", Offset = "0x675E830", VA = "0x18675FE30", Slot = "27")]
	public void GFPMMKHMEDG(GEOMLACBKFM HBAJAEEPGLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x675DC90", Offset = "0x675C690", VA = "0x18675DC90", Slot = "4")]
	public void MKAHBFMEGDE(int IADKDCBBENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6761070", Offset = "0x675FA70", VA = "0x186761070", Slot = "9")]
	public void IMAJOIJBKLA(EHPBBFOJBKA FBPIGMGAAAB, Texture2D POMOCFBBJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x675D5F0", Offset = "0x675BFF0", VA = "0x18675D5F0", Slot = "10")]
	public void BAOOPOBLIKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x67668A0", Offset = "0x67652A0", VA = "0x1867668A0", Slot = "11")]
	public bool OKEOPCODCKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x675DCB0", Offset = "0x675C6B0", VA = "0x18675DCB0", Slot = "8")]
	public void CCKHBCCKFEH(PPDDIBMPJFC CDPMEKDDKJH, Color? COGPPELINPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6765E50", Offset = "0x6764850", VA = "0x186765E50")]
	private void NIOPANNDPGH(Action PAEAMEGICCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x675E4D0", Offset = "0x675CED0", VA = "0x18675E4D0", Slot = "5")]
	public void CJEELLEGEBM(OBJBFOFBDMJ CPOHKDHHJOF, Texture MEICFAJKIHD, Color KOMBHBCDFIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6764FD0", Offset = "0x67639D0", VA = "0x186764FD0", Slot = "6")]
	public void MGEJIKIJBDP(bool HGPBEKNCDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x12C4880", Offset = "0x12C3280", VA = "0x1812C4880", Slot = "7")]
	public void EENMEBBMLKH(NGNMNMDGIGH FFNDHFNNMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6763030", Offset = "0x6761A30", VA = "0x186763030", Slot = "14")]
	public BBADIINDDOJ LBENEFKCBDF(PFICEOBELNB MKPOBGOFJJD, bool DDECKCIFCCD, int[] KEPBODBBFKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6761280", Offset = "0x675FC80", VA = "0x186761280", Slot = "15")]
	public void IMHCGHCDCEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6764800", Offset = "0x6763200", VA = "0x186764800")]
	private bool LJGNOEJIELD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8551C0", Offset = "0x853BC0", VA = "0x1808551C0", Slot = "19")]
	public void JJFFEBFKJIM(BFJEAAGLFCO.DNAKBNCOFJG OPDMJEACBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x675D530", Offset = "0x675BF30", VA = "0x18675D530")]
	private bool AOOLGNBBMOE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x675FFA0", Offset = "0x675E9A0", VA = "0x18675FFA0")]
	private BBADIINDDOJ GKDLKJGPGIM(bool DDECKCIFCCD, List<IBHEFPIBJJM> BKFOIIEIENE, int[] KEPBODBBFKF, Func<int, MKKGGNPGIFD> LPJHBNOBGEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6761820", Offset = "0x6760220", VA = "0x186761820")]
	[IteratorStateMachine(typeof(JMCBDJPOCKM))]
	private IEnumerator<IHLELHJPJMK> JLIFLKHGCJJ(bool DDECKCIFCCD, List<IBHEFPIBJJM> BKFOIIEIENE, int[] KEPBODBBFKF, Func<int, MKKGGNPGIFD> LPJHBNOBGEP, JFLLHCFDPFN OKIGHIODGFN, Material JMEENPEBGHA, List<BBADIINDDOJ> CGAKLNFKALG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x675D7C0", Offset = "0x675C1C0", VA = "0x18675D7C0")]
	private BBADIINDDOJ BCNDAOLCILL(List<IBHEFPIBJJM> BKFOIIEIENE, int[] KEPBODBBFKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x675BB00", Offset = "0x675A500", VA = "0x18675BB00")]
	private JLKEMPIKEGF AOHODFANHAJ(List<IBHEFPIBJJM> BKFOIIEIENE, int IADKDCBBENH, bool DDECKCIFCCD, MKKGGNPGIFD NDBFPELDACP, bool KCMOBGFLMAP, JFLLHCFDPFN OKIGHIODGFN, Material JMEENPEBGHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6765D90", Offset = "0x6764790", VA = "0x186765D90", Slot = "22")]
	public void NFEPAADKLNM(AvatarFaceShape POGPDBLPEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x67615F0", Offset = "0x675FFF0", VA = "0x1867615F0", Slot = "23")]
	public void JDCFFAGLGBH(AvatarBodyShape HLALPKAKJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6764DB0", Offset = "0x67637B0", VA = "0x186764DB0", Slot = "25")]
	public void MBCGFPOBGEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x675B790", Offset = "0x675A190", VA = "0x18675B790", Slot = "24")]
	public void AMHAAKOBJIC(bool GINMDILBKLJ, bool DLCGFFFGFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6760D80", Offset = "0x675F780", VA = "0x186760D80")]
	private void IFNJEJGGGBD(SkinnedMeshRenderer PBNOEHGHFHI, int IADKDCBBENH, Mesh KJFFCELEION, List<Material> GIIJMJFFIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6762D20", Offset = "0x6761720", VA = "0x186762D20")]
	private static Material KLEGKNFENEN(Dictionary<FLEKBPBNDPD, Material> BIPHAJLHLPP, Material DAFCBCEILCN, DKHEMOFFMBB NNDHMDANBPI, EFBPHIIBPIG ILCAHNCEFMG, INEMDIPNFNK JBINPCPMLJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x67614D0", Offset = "0x675FED0", VA = "0x1867614D0")]
	private static DKHEMOFFMBB JDBLBMHMEFJ(IBHEFPIBJJM FIIOJBCLAPE, int MOACKPLNBNO)
	{
		return default(DKHEMOFFMBB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6764940", Offset = "0x6763340", VA = "0x186764940")]
	private void LJHOGGBFIEG(int NGAGHMJMBKH, Material OKNIOBAOHHE, IBHEFPIBJJM FIIOJBCLAPE, [Out] Texture2D BNACHIIFLGF, [Out] Vector4 IEGIAKAEPNG, [Out] Texture2D EHCNNNGAIOO, [Out] Texture2D FOPPOKKCPJP, [Out] Texture2D EOCFMAJFPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6766C20", Offset = "0x6765620", VA = "0x186766C20")]
	private void PHEDGLOKDCL(int NGAGHMJMBKH, Material OKNIOBAOHHE, IBHEFPIBJJM FIIOJBCLAPE, [Out] Color GOBIGGAIFNF, [Out] Color CAAFFCEBEFN, [Out] Color FJPADDPOJPC, [Out] Color AFMEEEDFHJJ, [Out] Color FFHPMKDAALK, [Out] Color LDIKPPICDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x67664D0", Offset = "0x6764ED0", VA = "0x1867664D0")]
	private bool OCDFPEAMMDK(Material OKNIOBAOHHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x675DA80", Offset = "0x675C480", VA = "0x18675DA80")]
	private static Material BEBAFJFGCND(int NGAGHMJMBKH, DNOMEDBBMHM FIIOJBCLAPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x675FC70", Offset = "0x675E670", VA = "0x18675FC70")]
	private static EFBPHIIBPIG GALKALEBLCH(IBHEFPIBJJM FIIOJBCLAPE, int MOACKPLNBNO)
	{
		return default(EFBPHIIBPIG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x675E540", Offset = "0x675CF40", VA = "0x18675E540")]
	private static void CJFIGNHAKEG(Dictionary<string, List<FLEKBPBNDPD>> KMADMHLPGOE, IBHEFPIBJJM MCPHNJIAFBE, Material DAFCBCEILCN, DKHEMOFFMBB CDPMEKDDKJH, EFBPHIIBPIG FBPIGMGAAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x675EB10", Offset = "0x675D510", VA = "0x18675EB10")]
	private static SkinnedMeshRenderer EFEEBHENACE(Transform DBJDDHDBPPJ, Transform JFLIKCGHJAK, SkinnedMeshRenderer[] OFNIJNKNEGI, int IADKDCBBENH, MKKGGNPGIFD NDBFPELDACP, bool DDECKCIFCCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x675F9D0", Offset = "0x675E3D0", VA = "0x18675F9D0")]
	private void FIHLONPMPGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6764FC0", Offset = "0x67639C0", VA = "0x186764FC0")]
	private void MBHKAJNMCBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x675E370", Offset = "0x675CD70", VA = "0x18675E370")]
	private static void CEDPPKJBLKO(Dictionary<FLEKBPBNDPD, Material> BIPHAJLHLPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6761BD0", Offset = "0x67605D0", VA = "0x186761BD0")]
	private static void KCDOHCJPFCA(Dictionary<Renderer, JFLLHCFDPFN> JIEPNKHICKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6762F10", Offset = "0x6761910", VA = "0x186762F10")]
	private void LALLGFGPAJL(SkinnedMeshRenderer[] OFNIJNKNEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6765530", Offset = "0x6763F30", VA = "0x186765530")]
	private void MJKDPBMDJNI(SkinnedMeshRenderer GEBGAKKKJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6761930", Offset = "0x6760330", VA = "0x186761930")]
	private void KAFOBLIJAAI(List<GKEFEFBOJBB> POFONPEGKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6765ED0", Offset = "0x67648D0", VA = "0x186765ED0")]
	private void NMECGAIHINL(Dictionary<string, AMHDMMJJKND<Texture2D>> KMADMHLPGOE, bool AFIGCMMKHPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6765660", Offset = "0x6764060", VA = "0x186765660")]
	private void MNOGPEENJLK(Dictionary<string, List<FLEKBPBNDPD>> KMADMHLPGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x675DB30", Offset = "0x675C530", VA = "0x18675DB30")]
	private void BNMJHNHKLIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x675F840", Offset = "0x675E240", VA = "0x18675F840")]
	private void FDKCILEMNLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6764FE0", Offset = "0x67639E0", VA = "0x186764FE0")]
	private void MIAKHHMEFGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x675E830", Offset = "0x675D230", VA = "0x18675E830")]
	private void CNICCOOPJJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x675E900", Offset = "0x675D300", VA = "0x18675E900")]
	private void DILJLMNIKJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x675D670", Offset = "0x675C070", VA = "0x18675D670")]
	private void BCEEHNJEGDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6761B00", Offset = "0x6760500", VA = "0x186761B00")]
	private void KBKJDFACOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6766800", Offset = "0x6765200", VA = "0x186766800")]
	private void OEAPCBPAEHM(bool JPKCFKKINBA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6766730", Offset = "0x6765130", VA = "0x186766730")]
	private void OCDIKKFMDLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x67616B0", Offset = "0x67600B0", VA = "0x1867616B0")]
	private void JENCMECIAGL(bool JPKCFKKINBA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6766190", Offset = "0x6764B90", VA = "0x186766190")]
	private void OBOABGIENJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x675F4D0", Offset = "0x675DED0", VA = "0x18675F4D0")]
	private void FCIBJPDKBML(Material JMEENPEBGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x675FEB0", Offset = "0x675E8B0", VA = "0x18675FEB0")]
	private void GIFMDMJKPPL(Material JMEENPEBGHA, Color CAAFFCEBEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x675EA20", Offset = "0x675D420", VA = "0x18675EA20")]
	private void EBCIAPFKKCN(Material JMEENPEBGHA, Color FJPADDPOJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x675B6A0", Offset = "0x675A0A0", VA = "0x18675B6A0")]
	private void ALFHBCPKHIG(Material JMEENPEBGHA, Color GOBIGGAIFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6765CA0", Offset = "0x67646A0", VA = "0x186765CA0")]
	private void NCBKLCPJBGF(Material JMEENPEBGHA, Texture2D POMOCFBBJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6761D30", Offset = "0x6760730", VA = "0x186761D30")]
	private void KCNHNFCJAEA(Material JMEENPEBGHA, Texture DGMPKNNLOKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x67629A0", Offset = "0x67613A0", VA = "0x1867629A0")]
	private void KGGBHJLBOLP(Action<JFLLHCFDPFN> OKEEBGAFAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x675F320", Offset = "0x675DD20", VA = "0x18675F320")]
	private void ENHHMMFNFPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x675B7A0", Offset = "0x675A1A0", VA = "0x18675B7A0")]
	private void ANDOGAEKFLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x67656B0", Offset = "0x67640B0", VA = "0x1867656B0")]
	private BBADIINDDOJ NBFHDJMOEAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x675EF50", Offset = "0x675D950", VA = "0x18675EF50")]
	private void EMCJNGBNFKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x67671B0", Offset = "0x6765BB0", VA = "0x1867671B0")]
	public void PNHBMCHLHDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x675FC00", Offset = "0x675E600", VA = "0x18675FC00")]
	private void FLDNAFBKHKG(Vector3 IOJOFKPMLAD, Quaternion JIIABDGOIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x67609E0", Offset = "0x675F3E0", VA = "0x1867609E0")]
	private void IFEFDNLLLMC(List<IBHEFPIBJJM> GFCHPMGHOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6761E20", Offset = "0x6760820", VA = "0x186761E20")]
	public void KFDKBJDOPFF(IFEDJPPADLJ KBDEGMCFMGD, bool DLEIOBJJFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6762320", Offset = "0x6760D20", VA = "0x186762320")]
	public void KFDKBJDOPFF(IFEDJPPADLJ KBDEGMCFMGD, AnchorParamsRestrictions MDICCMBFDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x9F0BD0", Offset = "0x9EF5D0", VA = "0x1809F0BD0")]
	private static void FNDMODJAEBL(FitMeshHemisphere PGFCDAEIEBL, Transform POEKDJBLMCG, IFEDJPPADLJ KBDEGMCFMGD, AnchorParamsRestrictions AKPKOHJKALN, [Out] Vector3 KHAKKIFNDKN, [Out] Quaternion IMKGMPHEJPJ, [Out] IFEDJPPADLJ JKMODPPLHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6762B60", Offset = "0x6761560", VA = "0x186762B60")]
	public void KGNGOKHEGPF(Vector2 HIEEMFPJKOL, Vector3 NIBKOJACNJI, Vector3 LNKFNOHIKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6760570", Offset = "0x675EF70", VA = "0x186760570")]
	private void GKHOHFGALMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6767120", Offset = "0x6765B20", VA = "0x186767120")]
	private void PKDANIAIIOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6766A20", Offset = "0x6765420", VA = "0x186766A20")]
	[CompilerGenerated]
	private void OKPHADPOGOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6761480", Offset = "0x675FE80", VA = "0x186761480")]
	[CompilerGenerated]
	private void IPGBKEKDHCI(JFLLHCFDPFN OKLEEIFDHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x67655D0", Offset = "0x6763FD0", VA = "0x1867655D0")]
	[CompilerGenerated]
	private void MKJACKBINNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x67614B0", Offset = "0x675FEB0", VA = "0x1867614B0")]
	[CompilerGenerated]
	private void JBKHPCOCMOO(JFLLHCFDPFN OKLEEIFDHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6764650", Offset = "0x6763050", VA = "0x186764650")]
	[CompilerGenerated]
	private void LDBDCLJEDPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6761750", Offset = "0x6760150", VA = "0x186761750")]
	[CompilerGenerated]
	private void JIDAFOMEMJH(JFLLHCFDPFN OKLEEIFDHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6762E80", Offset = "0x6761880", VA = "0x186762E80")]
	[CompilerGenerated]
	private void KNFCKEEJIMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6764D80", Offset = "0x6763780", VA = "0x186764D80")]
	[CompilerGenerated]
	private void LJNDLLFLLPL(JFLLHCFDPFN OKLEEIFDHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x675B580", Offset = "0x6759F80", VA = "0x18675B580")]
	[CompilerGenerated]
	private void AGHEAKCPMGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x675FBD0", Offset = "0x675E5D0", VA = "0x18675FBD0")]
	[CompilerGenerated]
	private void FKBMNGOBNGL(JFLLHCFDPFN OKLEEIFDHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6764770", Offset = "0x6763170", VA = "0x186764770")]
	[CompilerGenerated]
	private void LHFEBBIJIAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x675F4A0", Offset = "0x675DEA0", VA = "0x18675F4A0")]
	[CompilerGenerated]
	private void ENJHACNFOFN(JFLLHCFDPFN OKLEEIFDHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6766B90", Offset = "0x6765590", VA = "0x186766B90")]
	[CompilerGenerated]
	private void PDELBEHJIIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x675DB00", Offset = "0x675C500", VA = "0x18675DB00")]
	[CompilerGenerated]
	private void BHHHBJOJGMN(JFLLHCFDPFN OKLEEIFDHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6766AB0", Offset = "0x67654B0", VA = "0x186766AB0")]
	[CompilerGenerated]
	private void OOMDKKOPFMC(KeyValuePair<string, AMHDMMJJKND<Texture2D>> OJHHAMBPONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x675B610", Offset = "0x675A010", VA = "0x18675B610")]
	[CompilerGenerated]
	private void AGICCMNGKCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6761770", Offset = "0x6760170", VA = "0x186761770")]
	[CompilerGenerated]
	private void JJJKKNJLEID(JFLLHCFDPFN OKLEEIFDHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x675E990", Offset = "0x675D390", VA = "0x18675E990")]
	[CompilerGenerated]
	private void DKFLMFFMEMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x675FBA0", Offset = "0x675E5A0", VA = "0x18675FBA0")]
	[CompilerGenerated]
	private void FIJCAKOFGMH(JFLLHCFDPFN OKLEEIFDHHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class NHPHFHMMPOC : FMHFBABHINA
{
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly int KFEIDDIFJCB;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly int CHHOJPNAHGO;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly int ANAPFABCIKK;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int AFMNCOMKGDC;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int DNBLKGLDGOC;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly int KJAJKGLBPOD;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly int GEMKKAGLILP;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int FHGOGJNIIIJ;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int JCFMEIFAOOI;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int IHPHEIIKOEB;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly int BEIEBJBOAKJ;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly int DPGNICFDNDI;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly int JKPCLBJADHC;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly int OKBLEBCCANE;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static readonly int PKOEBFLPHHI;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly int ODJJPDIHGHM;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static readonly int LGOEODFHHAM;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly int KDKPIKIIMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private Transform NKOPMFMHNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Transform GCOCLHPMHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private Transform LMMPEMDLBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private Transform LKGNLJACMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private Transform DBJLIGHLLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private Transform PGNNGDCOCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private Transform BLPCAOHFEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private LKMCODCLMGM PLADOJNKFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private MaterialPropertyBlock MPOKMBGIMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private SkinnedMeshRenderer[] LCNOPHPDNAP;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private MaterialPropertyBlock LGDBPNDCHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6756CD0", Offset = "0x67556D0", VA = "0x186756CD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6756A60", Offset = "0x6755460", VA = "0x186756A60", Slot = "6")]
	public void CCPNKNOIBEC(LKMCODCLMGM JJDDNLEFAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x67582F0", Offset = "0x6756CF0", VA = "0x1867582F0", Slot = "7")]
	public void PNHHOBPCMFF(EGBJIADLBKF NKEPOGKPILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6757E60", Offset = "0x6756860", VA = "0x186757E60", Slot = "4")]
	public void OHACIJPNMMH(CLNDJONOGLP CCLIBNNKMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6758290", Offset = "0x6756C90", VA = "0x186758290")]
	private Vector2 PNCLOMMMKJN(Vector2 GKJCJOGBGHM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6756D50", Offset = "0x6755750", VA = "0x186756D50", Slot = "5")]
	public void NJMKENKJJMM(HANBPEILFJA NKEPOGKPILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6756710", Offset = "0x6755110", VA = "0x186756710")]
	private void AMHPOEKIPJG(HANBPEILFJA JACAOCLIAII, KMDCEFIPDEL AONICLFBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6756B60", Offset = "0x6755560", VA = "0x186756B60")]
	private void EKLNNENFIMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6758650", Offset = "0x6757050", VA = "0x186758650")]
	public NHPHFHMMPOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6756C40", Offset = "0x6755640", VA = "0x186756C40")]
	[CompilerGenerated]
	internal static (float, float) JLNIPDADDKA(float OHBIOFBNLPF)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6756B20", Offset = "0x6755520", VA = "0x186756B20")]
	[CompilerGenerated]
	internal static Vector4 DOMBLKAKKEP(Vector2 GLNEOPDBMFP, Vector2 GIFACOBMIEN)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class JFLLHCFDPFN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private MaterialPropertyBlock FJBLGJNIIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public Color? LKOFHGABBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public Color? HNAOAMMHHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public Color? PLJDGOJHDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public Color? APODGICPDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public Color PFMPLPKNLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public Color ICHLMGMEMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public Color CCFNLMFBKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public Texture2D BEFMPMPEBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public Texture2D DHNBADDJADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private Dictionary<FLEKBPBNDPD, int> PCIGOGHCKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private DKHEMOFFMBB[] MMLOKECEIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private EFBPHIIBPIG[] EMEDGACFGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public Vector4[] HBKAIPGIANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public Vector4[] EGCIGJKKJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public Vector4[] MAEGANLKHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public Vector4[] DIPBPIHHHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public Vector4[] JCIBGEHONFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public Vector4[] JENOGBKFNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private List<Texture2D> NCDJNHLKDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private Vector4[] CFKPFHPDDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private List<Texture2D> IFIDPHMNGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private float[] JILKNMEPFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private Vector4[] MLPDABEKDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private float[] OLGNJFJBCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public float[] EMICAEDFPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private List<Texture2D> JANPEECKCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private float[] DJKLDIFFKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private List<Texture2D> OBEAJCAHNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private Vector4[] IJCMKKODIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private float[] HHHELCDHDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private Vector4[] PCMFLMNDFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public float[] OBCOKMKFAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public Texture2DArray PDCLEAPPDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public Texture2DArray KBEIHJCOGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public Texture2DArray DKLLEELNDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public Texture2DArray NNJEADCJGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private bool NNCENBCOPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private int BCMBFAFNBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private Vector2? DEDIAEHGDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private TextureFormat DIBICIOMNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private Vector2? INIDEOBEPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private TextureFormat IHHLEHJAGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private Vector2? LDBHLPNHCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private TextureFormat PAKJHLGHEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private Vector2? DEEMJGFAMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private TextureFormat JBMHICAEAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private bool HEPHGBKCGHN;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static int NFBNMPPJAMN;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static int OHBMHIOLNEJ;

	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private static int CKNPONPDJOE;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private static int DFNPODGJOKA;

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private static int JBPFLMCCKNI;

	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private static int DOFJFAPJGOM;

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private static int HBPEPPAEENG;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private static int HPPHENPCIAD;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static int PMLIKAMDGFM;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static int GPMIAPOFCGA;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private static int HGAMNIIIEKM;

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static int CJHCDCDADKJ;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static int FMNOBGKPALJ;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static int PDEJFCGLPFD;

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private static int KHNOCINCEGH;

	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private static int KAABOCBELDI;

	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static int HBMOAFFCIMK;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static int GBIKKKIIEMA;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static int PHHFNHFJHNN;

	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private static int IMDPHBPDODF;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x676F0C0", Offset = "0x676DAC0", VA = "0x18676F0C0")]
	private JFLLHCFDPFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x676F000", Offset = "0x676DA00", VA = "0x18676F000")]
	public JFLLHCFDPFN(Color LLPCAOJNNPP, Color BPBJJGEAMOL, Color BBIOGAKCAPP, Color? AIELEJJOHKM, Color? ALAEEIDADHG, Color? NHPACPLJPDP, Texture2D NMLJKBIAMHE, Texture2D GNDDGHDFEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x676DFB0", Offset = "0x676C9B0", VA = "0x18676DFB0")]
	internal int KMBMNHHAFMH(Material FOKFAHPDMFA, DKHEMOFFMBB NNDHMDANBPI, EFBPHIIBPIG ILCAHNCEFMG, INEMDIPNFNK JBINPCPMLJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x676DF20", Offset = "0x676C920", VA = "0x18676DF20")]
	private int KMBMNHHAFMH(FLEKBPBNDPD LDDEKIBHION)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x676E0A0", Offset = "0x676CAA0", VA = "0x18676E0A0")]
	internal int MCBIFKFGJJB(Material FOKFAHPDMFA, Color GOBIGGAIFNF, Color CAAFFCEBEFN, Color FJPADDPOJPC, Color AFMEEEDFHJJ, Color FFHPMKDAALK, Texture2D DBNAHAFKGKL, Vector4 OKDBDFHGIPE, Texture2D NDMFKAMBGKF, Vector4 DKMHBOJBODH, float NEGKLLLIIHB, float GAGPJLGHKKG, Texture2D MEHCIOLJGMD, Vector4 DBHGAGEOJDE, float OACIHJLMJDK, Texture2D CPIBNFDKIIA, Color LDIKPPICDHC, Vector4 MKLLGFPJGAM, DKHEMOFFMBB NNDHMDANBPI, EFBPHIIBPIG ILCAHNCEFMG, INEMDIPNFNK JBINPCPMLJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x676DA60", Offset = "0x676C460", VA = "0x18676DA60")]
	private void GJHGBDOHMAJ(List<Texture2D> NCDJNHLKDDI, [Out] Texture2DArray NMAGIIPAIOO, [Out] Texture2DArray FKAJFHCPDAN, [Out] Texture2DArray POLALENPKIH, [Out] Texture2DArray LBACBIHHCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x676DDD0", Offset = "0x676C7D0", VA = "0x18676DDD0")]
	public void JOPEHACDEIG(Shader DOIJCDODJGG, Renderer EBCGCCILOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x676CAD0", Offset = "0x676B4D0", VA = "0x18676CAD0")]
	private void CFPAPNEFBEB(Shader DOIJCDODJGG, Renderer EBCGCCILOJN, int HDNGAAKAHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x676D860", Offset = "0x676C260", VA = "0x18676D860")]
	private Color FEFCOIDOCKK(Color IDEGFANNLND, DKHEMOFFMBB CDPMEKDDKJH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x676C980", Offset = "0x676B380", VA = "0x18676C980")]
	private Color ANNLBOHLEIG(Color CKIOPKGIAOJ, DKHEMOFFMBB CDPMEKDDKJH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x676DCD0", Offset = "0x676C6D0", VA = "0x18676DCD0")]
	private bool IIJFLKBBIPA(Texture2D CMCFMAKDBID, EFBPHIIBPIG FBPIGMGAAAB, [Out] Texture2D MENEHHAHEOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x676DC20", Offset = "0x676C620", VA = "0x18676DC20")]
	private void IBAMDMMFKDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x676D820", Offset = "0x676C220", VA = "0x18676D820", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[Obsolete("Use CombinationId instead!")]
		[SerializeField]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private ODBFAAJEAMN? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public OMEPBNMDOOI CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x6769240", Offset = "0x6767C40", VA = "0x186769240")]
			get
			{
				return default(OMEPBNMDOOI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ODBFAAJEAMN MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x6769290", Offset = "0x6767C90", VA = "0x186769290")]
			get
			{
				return default(ODBFAAJEAMN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x84FE40", Offset = "0x84E840", VA = "0x18084FE40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8550A0", Offset = "0x853AA0", VA = "0x1808550A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6769080", Offset = "0x6767A80", VA = "0x186769080")]
		public Material[] JNKDKEOEEHD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6768EC0", Offset = "0x67678C0", VA = "0x186768EC0")]
		public static void FLFODACELHA(AvatarItemMaterial NGGKBJAKBJL, Material OKNIOBAOHHE, int NGAGHMJMBKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6769170", Offset = "0x6767B70", VA = "0x186769170")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[FABAIOIDLJO]
public struct HJFLDJMFNEM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	[ReadOnly]
	public KKJMJLHHBHD FLLEAEPLLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	[ReadOnly]
	public int OJFHEDGOIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public KHAIKFDEKCO NIJBPOEEAAF;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x676B0D0", Offset = "0x6769AD0", VA = "0x18676B0D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[FABAIOIDLJO]
[NativeContainer]
public struct KHAIKFDEKCO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public NativeArray<Vector3> DJBMMIMBFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public NativeArray<Vector3> LFGGFECHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public NativeArray<Vector4> EEOAIIBHAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public NativeArray<Vector2> NBECJEMBAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public NativeArray<Vector2> CGJMFDDNPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public NativeArray<Vector2> LAFNPKHFKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeArray<Vector2> LLGJIMMCKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<Color> JEILKDGBDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NativeArray<int> JPEIIPODMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public NativeArray<int> IDBHCDFLNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private NativeArray<int> KFCFODACCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private NativeArray<int> EKHKKJLICGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<int> NCNEADCHEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeArray<int> KPMFBPEFDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeArray<int> GEOOMIDIIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public NativeArray<BoneWeight> FBPFKGFCGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private NativeArray<int> FFNDHFNNMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private bool EPOFGFEHKFH;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int LBNLPHLAGHN
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x676F6C0", Offset = "0x676E0C0", VA = "0x18676F6C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x676F6D0", Offset = "0x676E0D0", VA = "0x18676F6D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int PGCPNGCJKHF
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x676FF00", Offset = "0x676E900", VA = "0x18676FF00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x676FF80", Offset = "0x676E980", VA = "0x18676FF80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int LEODKHCBHJM
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x676FF90", Offset = "0x676E990", VA = "0x18676FF90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x676FEF0", Offset = "0x676E8F0", VA = "0x18676FEF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6770050", Offset = "0x676EA50", VA = "0x186770050")]
	public KHAIKFDEKCO(int LFKJLBCMMGH, int JLGFIAJPKKE, int KBAGHKAEMHI, int AGPKBHKENCE, Allocator BPMIGAHMDHE, int DGKFHEKIMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x676FF10", Offset = "0x676E910", VA = "0x18676FF10")]
	public void JNNDBIHLLLO(int ILOCEPPJPDO, Vector3 CGDFPKFKHGF, Vector3 LLBFGGBOIAC, Vector4 FOCADABILLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x676FD20", Offset = "0x676E720", VA = "0x18676FD20")]
	public void HNPBKOKOPDI(int ILOCEPPJPDO, BoneWeight HKFAGMDCAHJ, NativeSlice<byte> EPBDOKLLLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6770030", Offset = "0x676EA30", VA = "0x186770030")]
	public Color OMMAKDDEMKN(int ILOCEPPJPDO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x676F960", Offset = "0x676E360", VA = "0x18676F960")]
	public void EBGHAAOIECL(int ILOCEPPJPDO, Color PEJELGOBPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x676FCD0", Offset = "0x676E6D0", VA = "0x18676FCD0")]
	public void HIDMCLOLLHP(byte EPMMHCBMHIG, int ILOCEPPJPDO, Vector2 LPEONEDLICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x676F6B0", Offset = "0x676E0B0", VA = "0x18676F6B0")]
	public void BCPMCDHHFBB(int ILOCEPPJPDO, int PAOOOAMOCGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x676FEC0", Offset = "0x676E8C0", VA = "0x18676FEC0")]
	public bool HOCNKLKHJNC(int EPMMHCBMHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x676F6E0", Offset = "0x676E0E0", VA = "0x18676F6E0")]
	public void CMACHINCGIL(int ADFHAOENDMG, int LJEHDHLGGJA, int NDKEFFPEPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x676F600", Offset = "0x676E000", VA = "0x18676F600")]
	public int[] BCGLGBCPAKD(int ADFHAOENDMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x676FFA0", Offset = "0x676E9A0", VA = "0x18676FFA0")]
	private NativeSlice<int> NFNCCINGHMG(int ADFHAOENDMG)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x676F7B0", Offset = "0x676E1B0", VA = "0x18676F7B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x676F980", Offset = "0x676E380", VA = "0x18676F980")]
	public Mesh HEJHBFBIEPB([Optional] string LFEFABOMEAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[FABAIOIDLJO]
[NativeContainer]
[DefaultMember("Item")]
public struct KKJMJLHHBHD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public NativeArray<Vector3> DJBMMIMBFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public NativeArray<Vector3> LFGGFECHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<Vector4> EEOAIIBHAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public NativeArray<Vector2> NBECJEMBAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<Vector2> CGJMFDDNPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public NativeArray<Vector2> LAFNPKHFKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public NativeArray<Vector2> LLGJIMMCKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeArray<Color> JEILKDGBDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeArray<int> BNBBDNAKJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<int> CDOGKGNOMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<int> HOGEIMFPCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<int> HICADAFGOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<bool> DCAIJJJJFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<int> DHCKDNLNDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<int> JOHJFEMCHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<BoneWeight> PGDNNCAEKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private NativeArray<Matrix4x4> BOFLBKDLKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private NativeArray<int> LAOLPGMLHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private NativeArray<byte> PBMHLKFKBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private NativeArray<int> NEFEFPEKBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private NativeArray<int> IBBNGBICMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<sbyte> NJJMEGIALID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<byte> LPPCJENIHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private NativeArray<int> NDDGKOFJKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private bool EPOFGFEHKFH;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int LOJGDLJIPDF
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x1FCDFC0", Offset = "0x1FCC9C0", VA = "0x181FCDFC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int EBOBNIJOFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1006490", Offset = "0x1004E90", VA = "0x181006490")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int BLDGDKCAFAM
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6770D70", Offset = "0x676F770", VA = "0x186770D70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int IHFODCMFOMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6770D30", Offset = "0x676F730", VA = "0x186770D30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x67704A0", Offset = "0x676EEA0", VA = "0x1867704A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int LBNLPHLAGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x67704B0", Offset = "0x676EEB0", VA = "0x1867704B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x67704C0", Offset = "0x676EEC0", VA = "0x1867704C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int CLKHANIAMOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6770D60", Offset = "0x676F760", VA = "0x186770D60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6770800", Offset = "0x676F200", VA = "0x186770800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public IMNGDKEFCMP AMOBOFOJPOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6770490", Offset = "0x676EE90", VA = "0x186770490")]
		get
		{
			return default(IMNGDKEFCMP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6770D50", Offset = "0x676F750", VA = "0x186770D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public byte NANADAPOJMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6770D40", Offset = "0x676F740", VA = "0x186770D40")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6770DA0", Offset = "0x676F7A0", VA = "0x186770DA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public NPHKLBBKFGB PBAJKHBLIBN
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6770810", Offset = "0x676F210", VA = "0x186770810")]
		get
		{
			return default(NPHKLBBKFGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6770DB0", Offset = "0x676F7B0", VA = "0x186770DB0")]
	public KKJMJLHHBHD(IList<Mesh> JOBNDMKACOK, IList<Matrix4x4> MJFECONCLGF, IList<bool> DCAIJJJJFPG, byte NGPJMODJHPE, IList<byte[]> IBIFAADLBHH, IList<int> IEMILNGHNFO, IList<bool> MKKLNCLMLFG, IList<int> DHCKDNLNDLE, IList<int> MPCKJPKENNI, IList<int> EAKMKIMCDGH, Allocator BPMIGAHMDHE, IMNGDKEFCMP FBIHBEAKGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x67704D0", Offset = "0x676EED0", VA = "0x1867704D0")]
	public KHAIKFDEKCO DJFHFKEOPBB(Allocator BPMIGAHMDHE)
	{
		return default(KHAIKFDEKCO);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x67705A0", Offset = "0x676EFA0", VA = "0x1867705A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[FABAIOIDLJO]
public class IMNOPELDIPN : JMLHCOLOCOM
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x676C890", Offset = "0x676B290", VA = "0x18676C890")]
	public KKJMJLHHBHD GOFPHALMMGO()
	{
		return default(KKJMJLHHBHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x67565A0", Offset = "0x6754FA0", VA = "0x1867565A0")]
	public IMNOPELDIPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct NPHKLBBKFGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeSlice<Vector3> DJBMMIMBFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeSlice<Vector3> LFGGFECHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeSlice<Vector4> EEOAIIBHAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeSlice<Vector2> NBECJEMBAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeSlice<Vector2> CGJMFDDNPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeSlice<Vector2> LAFNPKHFKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeSlice<Vector2> LLGJIMMCKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeSlice<Color> JEILKDGBDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeSlice<int> OPEIBEGPCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeSlice<int> HICADAFGOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeSlice<BoneWeight> PGDNNCAEKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeSlice<byte> JNBLLKOHBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public int KEIFIDMMGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public Matrix4x4 IFNOKIACFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public int GNPEOCIFCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeSlice<byte> EPBDOKLLLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public bool IMICJFJCFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public int KKCCGPJCKPD;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal readonly struct FLEKBPBNDPD : IEquatable<FLEKBPBNDPD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	internal readonly Material ELGPMOBIFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	internal readonly DKHEMOFFMBB GOONEIPILAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	internal readonly EFBPHIIBPIG EAJMHGJPHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	internal readonly INEMDIPNFNK GOHJBMJPODH;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0xA29C80", Offset = "0xA28680", VA = "0x180A29C80")]
	public FLEKBPBNDPD(Material OKNIOBAOHHE, DKHEMOFFMBB NNDHMDANBPI, EFBPHIIBPIG ILCAHNCEFMG, INEMDIPNFNK JBINPCPMLJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x676A050", Offset = "0x6768A50", VA = "0x18676A050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xA299D0", Offset = "0xA283D0", VA = "0x180A299D0", Slot = "4")]
	public bool Equals(FLEKBPBNDPD HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6769EC0", Offset = "0x67688C0", VA = "0x186769EC0", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6769FB0", Offset = "0x67689B0", VA = "0x186769FB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class IEECPEONOMD
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class KEJLICACLJK : IEnumerator<IHLELHJPJMK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private IHLELHJPJMK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		private IHLELHJPJMK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x852730", Offset = "0x851130", VA = "0x180852730")]
		[DebuggerHidden]
		public KEJLICACLJK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA2DF40", Offset = "0xA2C940", VA = "0x180A2DF40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x676F5B0", Offset = "0x676DFB0", VA = "0x18676F5B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
	public static void DKHMEOAOEKP(string OBDGAAHPMCD, int IADKDCBBENH, long OKFGGJABNHE, long MOAENEDIBLM, long PFMEBEFMLJN, long IBJMBNDLOGP, long OHHEJEFAKMC, long AFJBDFJPNCF, long CFKFEJKCJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x676C740", Offset = "0x676B140", VA = "0x18676C740")]
	public static JLKEMPIKEGF CNDIAIDBFLK(JobHandle BIAKLEOLBBD, bool BNNDBEIAEEH, bool GBDFIMEKMJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x676C6D0", Offset = "0x676B0D0", VA = "0x18676C6D0")]
	[IteratorStateMachine(typeof(KEJLICACLJK))]
	private static IEnumerator<IHLELHJPJMK> ANBNJMPAPOJ(JobHandle AHCMMMOBCPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class BILOFPDEJDB : GMNHEEAIECH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private DKMELBKELOG GJAHKPHEFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private HPAOHKJMGHJ NOOLBMLGCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private IRecRoomQualityConfigProvider FMGDHGKIDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private bool EPOFGFEHKFH;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6769A20", Offset = "0x6768420", VA = "0x186769A20")]
	[MHFEIEAPENL(CMFCLNIIIKO.GameOnly)]
	private static void HMIEDEJHNLC(GPECMKAJNMD FOPICBKBDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5A964D0", Offset = "0x5A94ED0", VA = "0x185A964D0")]
	[UnityEngine.Scripting.Preserve]
	public BILOFPDEJDB([OHLKLPAILPF(null)] HPAOHKJMGHJ GFADAHOCGKH, [OHLKLPAILPF(null)] DKMELBKELOG JEMDKLGCGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x67693B0", Offset = "0x6767DB0", VA = "0x1867693B0")]
	private void CJFLIFIINII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6769350", Offset = "0x6767D50", VA = "0x186769350", Slot = "4")]
	public void BAOOPOBLIKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6769420", Offset = "0x6767E20", VA = "0x186769420", Slot = "5")]
	public AMHDMMJJKND<Texture2D> GENIHMJEPBD(EBEIPBGALFP LHCLCMHLLAI, [Optional] NGNMNMDGIGH FFNDHFNNMLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x67698E0", Offset = "0x67682E0", VA = "0x1867698E0")]
	private uint GNHPPDCDJGD(EBEIPBGALFP LHCLCMHLLAI, NGNMNMDGIGH FFNDHFNNMLH)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface JPALEDBOMGC
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GLFKJNOAFCH(Mesh KJFFCELEION, Matrix4x4 DCGDHJGPNMF, byte[] EPBDOKLLLKF, bool CLIOGHCCIEA = false, BFJEAAGLFCO.DNAKBNCOFJG NMKGEOLFBCH = (BFJEAAGLFCO.DNAKBNCOFJG)0, int DHCKDNLNDLE = -1, bool DCAIJJJJFPG = false);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ANLLACKAJJN(Allocator BPMIGAHMDHE, IMNGDKEFCMP FBIHBEAKGKG, byte NGPJMODJHPE, [Optional] IList<int> MPCKJPKENNI, [Optional] IList<int> DMKNLMBAEAH);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct OEKCNLOCNKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public readonly GameObject JMGCEOHHNKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private readonly AvatarItemMaterial GGIBGOFHKOO;

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0xAA6F80", Offset = "0xAA5980", VA = "0x180AA6F80")]
	public OEKCNLOCNKN(GameObject JMGCEOHHNKC, AvatarItemMaterial GGIBGOFHKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6772D30", Offset = "0x6771730", VA = "0x186772D30")]
	public void LOFAGOFHODA(Material OKNIOBAOHHE, int NGAGHMJMBKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class HMGBIHPEIMN : ANPIOJKBJMC<Task<(GameObject, AvatarItemMaterial)>, OEKCNLOCNKN>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct FPFJKMBIILC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x676A280", Offset = "0x6768C80", VA = "0x18676A280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x676A780", Offset = "0x6769180", VA = "0x18676A780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private AMHDMMJJKND<GameObject> MCKPOMOPNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private AMHDMMJJKND<AvatarItemMaterial> BOODGHAPOKH;

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x676C640", Offset = "0x676B040", VA = "0x18676C640")]
	private HMGBIHPEIMN(Task<(GameObject, AvatarItemMaterial)> JCINMAJOONI, AMHDMMJJKND<GameObject> FAAHLJKADCP, AMHDMMJJKND<AvatarItemMaterial> BDJLCBNHDLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x676BFE0", Offset = "0x676A9E0", VA = "0x18676BFE0")]
	public static HMGBIHPEIMN CBNOJCEAKCL(AssetReference OFFGOLLNDHM, [Optional] AssetReference BOBFMABIAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x676C3F0", Offset = "0x676ADF0", VA = "0x18676C3F0", Slot = "11")]
	protected override OEKCNLOCNKN JEFCGHPKEMH(Task<(GameObject, AvatarItemMaterial)> CNHNLIMLNBJ)
	{
		return default(OEKCNLOCNKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x676C5C0", Offset = "0x676AFC0", VA = "0x18676C5C0", Slot = "12")]
	protected override void OLNEJMGCPEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x676C490", Offset = "0x676AE90", VA = "0x18676C490")]
	[AsyncStateMachine(typeof(FPFJKMBIILC))]
	private static Task<(GameObject, AvatarItemMaterial)> OCLAPANJECH(Task<GameObject> NOLGGLFNKJF, Task<AvatarItemMaterial> PMNJKJBJJLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class APEKNOFELDN
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class PKCMOKCAFOM : ANPIOJKBJMC<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class LHPPBGCHCGC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public MaterialEntry entry;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public string shaderNameToFind;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public LHPPBGCHCGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x67728E0", Offset = "0x67712E0", VA = "0x1867728E0")]
			internal object FOOHECLMHAJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x6772690", Offset = "0x6771090", VA = "0x186772690")]
			internal object DNJMJBJHOBA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private AMHDMMJJKND<MaterialMapAsset> AHCMMMOBCPP;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6773360", Offset = "0x6771D60", VA = "0x186773360")]
		public PKCMOKCAFOM(AMHDMMJJKND<MaterialMapAsset> AHCMMMOBCPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6773210", Offset = "0x6771C10", VA = "0x186773210", Slot = "11")]
		protected override Material[] JEFCGHPKEMH(Task<MaterialMapAsset> JCINMAJOONI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6773300", Offset = "0x6771D00", VA = "0x186773300", Slot = "12")]
		protected override void OLNEJMGCPEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6772F40", Offset = "0x6771940", VA = "0x186772F40")]
		private Material IKADLANHEGM(MaterialEntry LFJOILFDLCD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private class MFEIDAEMBMN : ANPIOJKBJMC<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private List<AMHDMMJJKND<Material>> PAMHLPPBCHD;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6772CC0", Offset = "0x67716C0", VA = "0x186772CC0")]
		public MFEIDAEMBMN(Task<Material[]> JCINMAJOONI, List<AMHDMMJJKND<Material>> PAMHLPPBCHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6772B30", Offset = "0x6771530", VA = "0x186772B30", Slot = "11")]
		protected override Material[] JEFCGHPKEMH(Task<Material[]> CNHNLIMLNBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6772B80", Offset = "0x6771580", VA = "0x186772B80", Slot = "12")]
		protected override void OLNEJMGCPEH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private static readonly LGKLDLNGEGN DHOGKNDCDMM;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6768A20", Offset = "0x6767420", VA = "0x186768A20")]
	public static AMHDMMJJKND<Material[]> CIOLAMJCPOK(AssetReference[] CAPIBDLBBPK)
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
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[GBAJCKFHNAK(MJDOLBEDPIO.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6773440", Offset = "0x6771E40", VA = "0x186773440")]
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
		private struct EAGGFHNJKGN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public AsyncTaskMethodBuilder<OEMMBNJFFOI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public int eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			private TaskAwaiter<OEMMBNJFFOI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x6769B10", Offset = "0x6768510", VA = "0x186769B10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x6769E50", Offset = "0x6768850", VA = "0x186769E50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private Dictionary<ENFHCMKIOHI, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private Dictionary<ENFHCMKIOHI, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private Dictionary<ENFHCMKIOHI, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private Dictionary<ENFHCMKIOHI, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private readonly Dictionary<ENFHCMKIOHI, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private OEMMBNJFFOI _defaultFaceStyle;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x676B0A0", Offset = "0x6769AA0", VA = "0x18676B0A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x676ABD0", Offset = "0x67695D0", VA = "0x18676ABD0")]
		public OEMMBNJFFOI GBCMFKDOEBG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x676A7F0", Offset = "0x67691F0", VA = "0x18676A7F0")]
		[AsyncStateMachine(typeof(EAGGFHNJKGN))]
		public Task<OEMMBNJFFOI> ACKICOMOOLP(int KDGCGNBLPDE, int EKNBNOJMNHL, int NCLMKKPFNIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x676AC20", Offset = "0x6769620", VA = "0x18676AC20")]
		public NoseFaceOption JBPGOPPHFJB(int IBIBEBHJJPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x676AA50", Offset = "0x6769450", VA = "0x18676AA50")]
		public SelectableFaceOption EGLJIPCFLGB(FaceFeatureType MMNNNGBLLJC, ENFHCMKIOHI NGMHPEEGOJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x676A920", Offset = "0x6769320", VA = "0x18676A920")]
		public int ADOELHKOCIM(ENFHCMKIOHI NGMHPEEGOJK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x676ADE0", Offset = "0x67697E0", VA = "0x18676ADE0")]
		private void PBLJMFJPPCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2B16340", Offset = "0x2B14D40", VA = "0x182B16340")]
		private void EECEIIPDIKL<T>(IDictionary<ENFHCMKIOHI, T> NLHDNBOLFGK, IReadOnlyList<T> LOGNIPHCPFP) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x676A9A0", Offset = "0x67693A0", VA = "0x18676A9A0")]
		public ENFHCMKIOHI DLOILKBMGHO(FaceFeatureType MMNNNGBLLJC)
		{
			return default(ENFHCMKIOHI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x676ACC0", Offset = "0x67696C0", VA = "0x18676ACC0")]
		public ENFHCMKIOHI KHOBPJKIFKD(FaceFeatureType MMNNNGBLLJC)
		{
			return default(ENFHCMKIOHI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x676B010", Offset = "0x6769A10", VA = "0x18676B010")]
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
