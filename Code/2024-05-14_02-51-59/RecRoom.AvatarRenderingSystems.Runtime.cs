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
	public class LogRegistrationIndex : DEDNPPDJFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x61E0EE0", Offset = "0x61DF8E0", VA = "0x1861E0EE0", Slot = "4")]
		public override void JIGIEBIDGIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C5AB0", Offset = "0x7C44B0", VA = "0x1807C5AB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x61ED4A0", Offset = "0x61EBEA0", VA = "0x1861ED4A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x61ED3D0", Offset = "0x61EBDD0", VA = "0x1861ED3D0", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x61ED460", Offset = "0x61EBE60", VA = "0x1861ED460")]
		public RecNetCDNAssetReference(RecNetCDNKey KLDFLAABJKH)
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
			[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7C4AB0", Offset = "0x7C34B0", VA = "0x1807C4AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7C5AA0", Offset = "0x7C44A0", VA = "0x1807C5AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7C58F0", Offset = "0x7C42F0", VA = "0x1807C58F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x61ED590", Offset = "0x61EBF90", VA = "0x1861ED590")]
		public static RecNetCDNKey MKGEBBBAHGD(string HFNMAFNJBCE, string PFCIHJGJBHD = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5A16F30", Offset = "0x5A15930", VA = "0x185A16F30")]
		public void DNGPPEDCNFA(string APBNLDOEBAI, string NKHBKFIGNJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x61ED4E0", Offset = "0x61EBEE0", VA = "0x1861ED4E0")]
		public RecNetCDNKey GEIPHIPNFIH(string NDMMFOPMNHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x61ED620", Offset = "0x61EC020", VA = "0x1861ED620")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[JFFHACELPPM]
public class HFAMMPPAAPN : MAFMCHDBCLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> FKMJJJHCNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> PCLLGHHDFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> PAPFGNHENDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> KHOBDBGOKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> PDEELNPDKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> MDPMPJLEAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> DLPFDHLANAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator OAJPPNMGPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected JBJFMNNMMIG MBPPDLPENJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte KPDGCAPKPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> IBHMOPBEOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> IICIHNDLAAH;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x61DBAA0", Offset = "0x61DA4A0", VA = "0x1861DBAA0", Slot = "4")]
	public void OMIJIBCAKIO(Mesh LPABBIBOFCJ, Matrix4x4 JJNDLPCNBCJ, byte[] NJADLNBPEFE, bool IKCBGIHHBND = false, FHDAOFFBFNF.GIDFDMGKMNF KBCPHDAJKIP = (FHDAOFFBFNF.GIDFDMGKMNF)0, int GFFNLOOLLOM = -1, bool DIMALDNLEGH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x61DBA60", Offset = "0x61DA460", VA = "0x1861DBA60", Slot = "5")]
	public void MOGKHFFAMAN(Allocator IMPJLMNPHBC, JBJFMNNMMIG JLOPPOHIFCG, byte NPONMGLIMAN, [Optional] IList<int> EHLGJMHIEEH, [Optional] IList<int> NDEDPPLIMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x61DB930", Offset = "0x61DA330", VA = "0x1861DB930")]
	private static void FAAADJEIBEP(Mesh LPABBIBOFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x61DBF60", Offset = "0x61DA960", VA = "0x1861DBF60")]
	public HFAMMPPAAPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[JFFHACELPPM]
public struct ICBJEJDBLLF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public CGBGPLGIMEB DAAIBIINNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int DMJGLAOIAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public JIBLBDJOJGI LFAACGPNMLH;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x61DC430", Offset = "0x61DAE30", VA = "0x1861DC430", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[JFFHACELPPM]
[NativeContainer]
public struct JIBLBDJOJGI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct ACKODBCNPBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector3 AGJAJFHJMDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 AMMBIDJOPFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector4 FDDEPLNPPCK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct NGBKLFECAMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float ABIJLHALCBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float HMNEGBHLODE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float OFOOGEKKCNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float LJBIIICKNIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte KFMKGBJGGGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte HGNKAKFFHNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte EJBAEEJNABE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte AGMAKDFEDGK;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct PIKCJKAMAGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half ABIJLHALCBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half HMNEGBHLODE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half OFOOGEKKCNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half LJBIIICKNIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte KFMKGBJGGGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte HGNKAKFFHNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte EJBAEEJNABE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte AGMAKDFEDGK;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct GPLFDMELPAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 GLALCIBBONF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 OCCPPMFGOJH;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct MHKODKDLPKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half4 GLALCIBBONF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 OCCPPMFGOJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 PKIMIABEOON;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct CDNDMDKBCED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 GLALCIBBONF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 OCCPPMFGOJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 PKIMIABEOON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 CDNFIJCJJGM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct LKAKELPCDAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half4 GLALCIBBONF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 OCCPPMFGOJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 PKIMIABEOON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 CDNFIJCJJGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 EPFFOPJDDMJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct LMIMJPKNPEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float ABIJLHALCBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float HMNEGBHLODE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float OFOOGEKKCNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float LJBIIICKNIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int KFMKGBJGGGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int HGNKAKFFHNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int EJBAEEJNABE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int AGMAKDFEDGK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct PNMENNKPAGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Color GLALCIBBONF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 OCCPPMFGOJH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct DLLMLOCGOOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color GLALCIBBONF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 OCCPPMFGOJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 PKIMIABEOON;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct NEAIJDHKPFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color GLALCIBBONF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 OCCPPMFGOJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 PKIMIABEOON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 CDNFIJCJJGM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct ILHAMMNGJOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color GLALCIBBONF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 OCCPPMFGOJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 PKIMIABEOON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 CDNFIJCJJGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 EPFFOPJDDMJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool BKGHLGOFGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<ACKODBCNPBF> FMGGHCIGMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<GPLFDMELPAA> DNCBDEKHOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<MHKODKDLPKO> MMGKLEGPHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<CDNDMDKBCED> PODJKBKKHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<LKAKELPCDAO> GCGBLMIKFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<PIKCJKAMAGN> GOGCEAGAEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<NGBKLFECAMK> ILKKKMEJKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<PNMENNKPAGP> AGOGHPCEPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<DLLMLOCGOOJ> DIMBGLAPDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<NEAIJDHKPFN> MPMPGDBAMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<ILHAMMNGJOG> LMDPLHLKOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<LMIMJPKNPEF> DPINHGNHABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> IICGEECIAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> MPLICPKJKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> FMJPGAAJMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> FOKLGMEAHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> GIBMFPPKFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> IEGIHEEFODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> MEPEANGMOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<BoneWeight> PEDPLCNBJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> BJIJPHEEEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool BMMJNDLHDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool BELHBDKBHED;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int APBPGAMKNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x61DFFC0", Offset = "0x61DE9C0", VA = "0x1861DFFC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x61DE170", Offset = "0x61DCB70", VA = "0x1861DE170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int NJJKPAOCIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x61E03E0", Offset = "0x61DEDE0", VA = "0x1861E03E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x61DE780", Offset = "0x61DD180", VA = "0x1861DE780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int PHPNANJKNFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x61DEBC0", Offset = "0x61DD5C0", VA = "0x1861DEBC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x61DFFD0", Offset = "0x61DE9D0", VA = "0x1861DFFD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int KAILPFIINPA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x61DFF50", Offset = "0x61DE950", VA = "0x1861DFF50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x61E03F0", Offset = "0x61DEDF0", VA = "0x1861E03F0")]
	public JIBLBDJOJGI(int HHBGPDLCPGL, int NOHHJOLJFAG, int BGIMMLEFDFB, int MJIOAOLMJAI, Allocator IMPJLMNPHBC, int GAGMCAEGOFB, JKONLLCCCDI KCIFGMKCNFK, bool BMMJNDLHDNB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x61DEF80", Offset = "0x61DD980", VA = "0x1861DEF80")]
	public void LKKPIGJKMGD(int ABBNIPHGMGH, Vector3 DIAGEGELNFD, Vector3 ANGOLELPPJD, Vector4 BIKAIHEBIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x61DE790", Offset = "0x61DD190", VA = "0x1861DE790")]
	public void IOJCIEGBIOM(int ABBNIPHGMGH, BoneWeight ABKCNLALFNA, NativeSlice<byte> NJADLNBPEFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x61DE3E0", Offset = "0x61DCDE0", VA = "0x1861DE3E0")]
	public Color HKHAPJAFAEI(int ABBNIPHGMGH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x61DFFE0", Offset = "0x61DE9E0", VA = "0x1861DFFE0")]
	public void POPEGMHDDAA(int ABBNIPHGMGH, Color KMFGKGNHDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x61DEBD0", Offset = "0x61DD5D0", VA = "0x1861DEBD0")]
	public void KIACFPGLIPI(byte AHCAPMINPKN, int ABBNIPHGMGH, Vector2 EMDEAKLLBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x61DE770", Offset = "0x61DD170", VA = "0x1861DE770")]
	public void IBLMKCMCJOM(int ABBNIPHGMGH, int FLNPDIIPDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x61DE710", Offset = "0x61DD110", VA = "0x1861DE710")]
	public bool HNJPMHGODCC(int AHCAPMINPKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x61DFE80", Offset = "0x61DE880", VA = "0x1861DFE80")]
	public void MHMPFMNEOAN(int CCHLNEGDPEH, int KNFIDNLGJFO, int JEKCEPEEELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x61DE180", Offset = "0x61DCB80", VA = "0x1861DE180", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x61DF010", Offset = "0x61DDA10", VA = "0x1861DF010")]
	public Mesh MEDINNLHHMI([Optional] string EBBPHLGMKIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
[JFFHACELPPM]
[NativeContainer]
public struct CGBGPLGIMEB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Mesh.MeshDataArray DLEDNLIFOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<int> DENNIDCCKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> GOFBENNOCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<BoneWeight> PEDPLCNBJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<Matrix4x4> EMDMMMEECBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> BHNFAAONJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<byte> GBCCPALDBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> NBKMNEOGDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> GJOKEFBOAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeArray<sbyte> BIDHJJMNPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<byte> HGDIIFBLPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<bool> DIMALDNLEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<int> GFFNLOOLLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool BMMJNDLHDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<int> MIFKNJBAFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool BELHBDKBHED;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int DKMGIKNBABG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x61D5E70", Offset = "0x61D4870", VA = "0x1861D5E70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int FIJEHNOIOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x61D6410", Offset = "0x61D4E10", VA = "0x1861D6410")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int OBILAJNFLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x61D6340", Offset = "0x61D4D40", VA = "0x1861D6340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DAGFPNMENGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x61D6010", Offset = "0x61D4A10", VA = "0x1861D6010")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x61D6470", Offset = "0x61D4E70", VA = "0x1861D6470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int APBPGAMKNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x61D6460", Offset = "0x61D4E60", VA = "0x1861D6460")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x61D5E80", Offset = "0x61D4880", VA = "0x1861D5E80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int AEPNGMDMFLC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x61D6420", Offset = "0x61D4E20", VA = "0x1861D6420")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x61D6450", Offset = "0x61D4E50", VA = "0x1861D6450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public JBJFMNNMMIG KJKBHOFPLPO
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x61D6430", Offset = "0x61D4E30", VA = "0x1861D6430")]
		get
		{
			return default(JBJFMNNMMIG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x61D6440", Offset = "0x61D4E40", VA = "0x1861D6440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte PLMNJHMFFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x61D6000", Offset = "0x61D4A00", VA = "0x1861D6000")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x61D6480", Offset = "0x61D4E80", VA = "0x1861D6480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public KNJHOKPILGH MIEEOIIACLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x61D60F0", Offset = "0x61D4AF0", VA = "0x1861D60F0")]
		get
		{
			return default(KNJHOKPILGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x61D6490", Offset = "0x61D4E90", VA = "0x1861D6490")]
	public CGBGPLGIMEB(IList<Mesh> JCNOGFNDEND, IList<Matrix4x4> CAFBHKKILNA, IList<bool> DIMALDNLEGH, byte NPONMGLIMAN, IList<byte[]> IIONCMFIPIF, IList<int> OEMGGDKONLC, IList<bool> NNEEFOJAAGP, IList<int> GFFNLOOLLOM, IList<int> EHLGJMHIEEH, IList<int> NIIBLANMDOG, Allocator IMPJLMNPHBC, JBJFMNNMMIG JLOPPOHIFCG, bool BMMJNDLHDNB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x61D6020", Offset = "0x61D4A20", VA = "0x1861D6020")]
	public JIBLBDJOJGI HBAHALJNNAH(Allocator IMPJLMNPHBC, JKONLLCCCDI KCIFGMKCNFK)
	{
		return default(JIBLBDJOJGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x61D5E90", Offset = "0x61D4890", VA = "0x1861D5E90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[JFFHACELPPM]
public class BPPEIJIHJFN : HFAMMPPAAPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool OCBLGBECALM;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x61D5D40", Offset = "0x61D4740", VA = "0x1861D5D40")]
	public CGBGPLGIMEB DNNOEGMKCHL()
	{
		return default(CGBGPLGIMEB);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x61D5E60", Offset = "0x61D4860", VA = "0x1861D5E60")]
	public BPPEIJIHJFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct KNJHOKPILGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Mesh.MeshData NBLIOLCLFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeSlice<BoneWeight> PEDPLCNBJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<byte> EDMJKLHDLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public int NKCGMDDAEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Matrix4x4 EHGJKOOBLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public int MHIIBAHPPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeSlice<byte> NJADLNBPEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public bool DHLJMLPAAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public int HLOENLPEHBG;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NMLDIONDNCM : GOJDIMLAHCA
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class JFGMHBONICN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public readonly DCDDAAOOBKB MLKGAFEAIMB;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual bool EDEIGNILNPG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public virtual bool KBDCIEKMMOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual FHDAOFFBFNF.GIDFDMGKMNF MHIIBAHPPPN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "6")]
			get
			{
				return default(FHDAOFFBFNF.GIDFDMGKMNF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool ALABDCFLKFG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x137C580", Offset = "0x137AF80", VA = "0x18137C580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool IGJLJBCEMHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x61DE160", Offset = "0x61DCB60", VA = "0x1861DE160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool NHBPDCKPCMK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x61DE140", Offset = "0x61DCB40", VA = "0x1861DE140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7C2410", Offset = "0x7C0E10", VA = "0x1807C2410")]
		protected JFGMHBONICN(DCDDAAOOBKB BIFCDCHDNPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract DBBHNMNBJNG HAOOOPOIMGM(int[] LHLDJBGBLPN, List<KKILGLJEJLC> OPOJGGANJOD, List<KKILGLJEJLC> BCDCNKFJJBO);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract IFDHMACKPAI LPBEKIBNBCB(uint NLNFAEHMBKG);
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class GFBONCPOAJL : JFGMHBONICN
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class DEKEANAMMAP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public NGGDDPJIFIN<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public GFBONCPOAJL <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public DEKEANAMMAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x61D7750", Offset = "0x61D6150", VA = "0x1861D7750")]
			internal void JMGKBMOEHFF(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly AvatarSkinAssetItem.DPENGBLCOHG PMHCOFFICJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly AssetReference CMIELHKNFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly FHDAOFFBFNF.GIDFDMGKMNF KMPEDOJMKAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly FMIFMPDKCJC? JBIHPHIJLKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly Material[] KGIADJFCELB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private SkinnedMeshRenderer[] EAFMKDIKMEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private AvatarSkinAssetItem IIAMOHLGPGM;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override FHDAOFFBFNF.GIDFDMGKMNF MHIIBAHPPPN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7C87B0", Offset = "0x7C71B0", VA = "0x1807C87B0", Slot = "6")]
			get
			{
				return default(FHDAOFFBFNF.GIDFDMGKMNF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x61DA5F0", Offset = "0x61D8FF0", VA = "0x1861DA5F0")]
		public GFBONCPOAJL(AvatarSkinAssetItem.DPENGBLCOHG GPIDGOCKONB, AssetReference DMGFCHELKMB, Material FIGHPDLHNIH, DCDDAAOOBKB OENALIHIKIL, FHDAOFFBFNF.GIDFDMGKMNF GJGHEJNGDCL = (FHDAOFFBFNF.GIDFDMGKMNF)0, [Optional] FMIFMPDKCJC? LNGIFCBDLED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x61DA4E0", Offset = "0x61D8EE0", VA = "0x1861DA4E0")]
		public GFBONCPOAJL(AvatarSkinAssetItem.DPENGBLCOHG GPIDGOCKONB, AssetReference DMGFCHELKMB, Material FIGHPDLHNIH, FHDAOFFBFNF.GIDFDMGKMNF GJGHEJNGDCL = (FHDAOFFBFNF.GIDFDMGKMNF)0, [Optional] FMIFMPDKCJC? LNGIFCBDLED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x61D9F80", Offset = "0x61D8980", VA = "0x1861D9F80", Slot = "7")]
		public override DBBHNMNBJNG HAOOOPOIMGM(int[] LHLDJBGBLPN, List<KKILGLJEJLC> OPOJGGANJOD, List<KKILGLJEJLC> BCDCNKFJJBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x61DA1A0", Offset = "0x61D8BA0", VA = "0x1861DA1A0", Slot = "8")]
		public override IFDHMACKPAI LPBEKIBNBCB(uint NLNFAEHMBKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x61DA470", Offset = "0x61D8E70", VA = "0x1861DA470", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class HCCDBJCBGJB : JFGMHBONICN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly CODGFMFKADE DLBEPMAPDPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private NGGDDPJIFIN<EEICMIGKAFG> OKBEIJEMNNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public EEICMIGKAFG OBLPFLCINME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private NGGDDPJIFIN<Material>[] PILPDEBEODN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public List<Material> MMCGLDAJIAD;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool EDEIGNILNPG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7DD630", Offset = "0x7DC030", VA = "0x1807DD630", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool KBDCIEKMMOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x61DB4A0", Offset = "0x61D9EA0", VA = "0x1861DB4A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1B9DC40", Offset = "0x1B9C640", VA = "0x181B9DC40")]
		public HCCDBJCBGJB(DCDDAAOOBKB BIFCDCHDNPM, CODGFMFKADE CJPFKIJAJKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x61DACD0", Offset = "0x61D96D0", VA = "0x1861DACD0", Slot = "7")]
		public override DBBHNMNBJNG HAOOOPOIMGM(int[] LHLDJBGBLPN, List<KKILGLJEJLC> OPOJGGANJOD, List<KKILGLJEJLC> BCDCNKFJJBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x61DB500", Offset = "0x61D9F00", VA = "0x1861DB500", Slot = "8")]
		public override IFDHMACKPAI LPBEKIBNBCB(uint NLNFAEHMBKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x61DAA30", Offset = "0x61D9430", VA = "0x1861DAA30")]
		public IFDHMACKPAI DMDENOHKANF(GameObject JECFLCILPCJ, uint NLNFAEHMBKG, bool LJECOMKCEJC, bool KCDPFBMAPLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x61DB130", Offset = "0x61D9B30", VA = "0x1861DB130")]
		public static bool HMIHFEODMEF(Renderer[] OJJJINOJOGJ, string IAGDFFFKDCM, [Out] Renderer FJOJGFCOIDB, [Out] Renderer GNCHAABONCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x61DB8E0", Offset = "0x61DA2E0", VA = "0x1861DB8E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x61DA830", Offset = "0x61D9230", VA = "0x1861DA830")]
		private (NGGDDPJIFIN<EEICMIGKAFG>, NGGDDPJIFIN<Material>[]) DACEKBKBJCF()
		{
			return default((NGGDDPJIFIN<EEICMIGKAFG>, NGGDDPJIFIN<Material>[]));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x61DB630", Offset = "0x61DA030", VA = "0x1861DB630")]
		private NGGDDPJIFIN<Material>[] PBAOCCEIHML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3E5DCB0", Offset = "0x3E5C6B0", VA = "0x183E5DCB0")]
		[CompilerGenerated]
		private void NAICJFBIGHM(EEICMIGKAFG LKBGEIGOHEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x61DB7B0", Offset = "0x61DA1B0", VA = "0x1861DB7B0")]
		[CompilerGenerated]
		private void PJFLHINPENJ(NGGDDPJIFIN<Material> DNBPAMGMKEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x61DAC20", Offset = "0x61D9620", VA = "0x1861DAC20")]
		[CompilerGenerated]
		private void ELOLGKDDGFB(Material LKBGEIGOHEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class FAPJALPABKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public NMLDIONDNCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public GCGMANBCNNC buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public FAPJALPABKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x61D7B60", Offset = "0x61D6560", VA = "0x1861D7B60")]
		internal void BPEEKDAJAGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x61D7B40", Offset = "0x61D6540", VA = "0x1861D7B40")]
		internal void AOKBFGHFNDJ(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x61D7C10", Offset = "0x61D6610", VA = "0x1861D7C10")]
		internal void NJACAHAJHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x61D7B80", Offset = "0x61D6580", VA = "0x1861D7B80")]
		internal void FHDNPCNDCAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
		internal DBBHNMNBJNG DFPHPEJIAPF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class KGIGFOMMKED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public FAPJALPABKK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public KGIGFOMMKED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x61E0E20", Offset = "0x61DF820", VA = "0x1861E0E20")]
		internal NAPAIIIFNCE AEECIGBCKBE(int lod)
		{
			return default(NAPAIIIFNCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class GPJEBIHGHJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public List<GCGMANBCNNC> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public GPJEBIHGHJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x61DA700", Offset = "0x61D9100", VA = "0x1861DA700")]
		internal void GKHKCBMAPGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class IIHIMAKLDJN : IEnumerator<LKAEALCJOPF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private LKAEALCJOPF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public NMLDIONDNCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<JFGMHBONICN> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public List<GCGMANBCNNC> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public Func<int, NAPAIIIFNCE> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public JAENNKPBIKN materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private LKAEALCJOPF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7C2410", Offset = "0x7C0E10", VA = "0x1807C2410")]
		[DebuggerHidden]
		public IIHIMAKLDJN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x61DDEE0", Offset = "0x61DC8E0", VA = "0x1861DDEE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x61DE0F0", Offset = "0x61DCAF0", VA = "0x1861DE0F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class APEALAKNKLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public NMLDIONDNCM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public APEALAKNKLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x61D59D0", Offset = "0x61D43D0", VA = "0x1861D59D0")]
		internal DBBHNMNBJNG GJHNMMGNNEI(JFGMHBONICN p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class AGEHNCAFMEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public FBCHNMOBKGG cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public AGEHNCAFMEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x84C980", Offset = "0x84B380", VA = "0x18084C980")]
		internal void HJMEBOPDGPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8DF670", Offset = "0x8DE070", VA = "0x1808DF670")]
		internal void JCPFBCCAOAL(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class NEFLJJNFHAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public NMLDIONDNCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public NEFLJJNFHAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class BKGHEAKIOHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public JIBLBDJOJGI defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public CGBGPLGIMEB defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public NEFLJJNFHAB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public BKGHEAKIOHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x61D5A90", Offset = "0x61D4490", VA = "0x1861D5A90")]
		internal void EONJAILFBBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x61D5A20", Offset = "0x61D4420", VA = "0x1861D5A20")]
		internal void CGPGAFOPLMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class HODDCAEHPMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public GDNFLNKMMKL legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public LJBAMJHJPJK legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public NEFLJJNFHAB CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public HODDCAEHPMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x61DC190", Offset = "0x61DAB90", VA = "0x1861DC190")]
		internal void GODKNHBBJNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x61DC3C0", Offset = "0x61DADC0", VA = "0x1861DC3C0")]
		internal void IECGJKFJNDB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class GECHPMPFHIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public FBCHNMOBKGG cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public CODGFMFKADE avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public NMLDIONDNCM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public GECHPMPFHIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x61D9C80", Offset = "0x61D8680", VA = "0x1861D9C80")]
		internal DBBHNMNBJNG LEHIAAFCAKD(CBAJEIFIAPH item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x61D9C40", Offset = "0x61D8640", VA = "0x1861D9C40")]
		internal void GLIKLDOIMPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class COKKAMEPGPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public NGGDDPJIFIN<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public COKKAMEPGPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x61D7700", Offset = "0x61D6100", VA = "0x1861D7700")]
		internal void PEPGACHFFGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class BMJPEIMPAGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public DCDDAAOOBKB overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public BMJPEIMPAGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x61D5CC0", Offset = "0x61D46C0", VA = "0x1861D5CC0")]
		internal bool ELDPNDKPNED(KeyValuePair<string, CODGFMFKADE> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private AvatarConfiguration NHMKEAPLJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Transform JGHEGBDKPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private AssetReference CMIELHKNFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private GameObject NHFAFKEHBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private GameObject PDMFKINNFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private SkinnedMeshRenderer JHAPJBLPGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private Transform[] DHGCDNMNCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private Matrix4x4[] OBMJMAPCLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Material DFHEGGFMPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Material KOIIJPACGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Material FIEIEKFOLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Shader LHHINPNHFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Shader IFHCIJMFPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Animator MDIHFLDBDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Renderer[] BLPONBDMJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private FHDAOFFBFNF.GIDFDMGKMNF LLKJHEFDMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Color PBDOCKMKHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Color FNDJGOPIKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Color NKCBCMJJKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Color? AOBHMMPLDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Color? LGINPOIPNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Color? FPLBPEHKLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Color? JBFIENHDHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Texture2D EBOBFGCEBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Texture2D MLIKEGILMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[CanBeNull]
	private CODGFMFKADE GHOBGOMAJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Texture CAPAFNEAAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Color IGBBOEHMKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public Dictionary<Renderer, JAENNKPBIKN> KNJKLJOIEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Dictionary<Renderer, JAENNKPBIKN> CMIIEGGNKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Dictionary<string, List<DPBOMABMKMK>> COCAGIEKODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Dictionary<string, List<DPBOMABMKMK>> JJDMGEMCILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly List<KKILGLJEJLC> GLAPJGMLHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly List<KKILGLJEJLC> GNNODADOHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly List<KKILGLJEJLC> FGHKBNJHNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly List<KKILGLJEJLC> GNCMPIKBCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Dictionary<DPBOMABMKMK, Material> IBOOBCJPNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<DPBOMABMKMK, Material> BFBHJHJLFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private SkinnedMeshRenderer[] HMPAOJHNLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private SkinnedMeshRenderer[] NHKINAIPILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private SkinnedMeshRenderer[] MAFEDBHHLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private SkinnedMeshRenderer[] PPKEPIMLKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly Dictionary<string, NGGDDPJIFIN<Texture2D>> EAHIEKDHKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly Dictionary<string, NGGDDPJIFIN<Texture2D>> JHAPLOBAFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private FitMeshHemisphere PICIHFADKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private bool GDGPJCOCOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private BFLEOALKIFK KNEOCOCJGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool ACKDNNOEOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private AnchorParamsRestrictions ICGLPJKKEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private bool GCDCACJKCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Transform AIEOMKLOEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Transform EDMHJPFBIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private bool EGJOPOADBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x201")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private bool JOMOKLBKLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private Vector3 AFINEMMLOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Quaternion LBOKOIBDNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Vector2 BPJMEEJMBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private FitMeshHemisphere FJEEMDFEOGH;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Material JHNDCMIEBCC;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Material EKADBOGKIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Dictionary<string, CODGFMFKADE> KEMCIAJHFEA;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int OCODHPKNONP;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int FAAMMFMAHIP;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int PKEAFPNEKNM;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int LLJHCPDMOAH;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int KPKHOBJNIIK;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int IHGFBGMEMAB;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int GKJGJLNCAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly KMHDPFOFGLH LHEGGEAHMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly KMHDPFOFGLH EOPMKJJBDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private bool PDBKDGCPEGD;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static Lazy<OBDBJEGPDPJ> GDAFGOLKEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private Lazy<ILBLANANDAP> BEIPOHIGPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private Lazy<BOPJNHIFHEI> BEFHBKFHKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private List<Action> DGGCOPACEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private FOCDFAJHPPN FADNHOLGNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private SkinnedMeshRenderer[] LNHMPHCMBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private int MEFJLIBKHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool AMFCBKJEIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int EKBCFFMMDCK;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool MCABFNDEPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x61E2DE0", Offset = "0x61E17E0", VA = "0x1861E2DE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x61E7CA0", Offset = "0x61E66A0", VA = "0x1861E7CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool EMOBJCEPGDN
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x61E36C0", Offset = "0x61E20C0", VA = "0x1861E36C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material OPHCHJDKMAC
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x61E4D90", Offset = "0x61E3790", VA = "0x1861E4D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Material ODOKPKAPLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x61E1320", Offset = "0x61DFD20", VA = "0x1861E1320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private bool LAKNPMFDBPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7DD630", Offset = "0x7DC030", VA = "0x1807DD630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private static OBDBJEGPDPJ IHNPOAEFLAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x61E45D0", Offset = "0x61E2FD0", VA = "0x1861E45D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private ILBLANANDAP CLEHBHIFNDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x61EAA30", Offset = "0x61E9430", VA = "0x1861EAA30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private BOPJNHIFHEI PEDNMBLFDOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x61E4470", Offset = "0x61E2E70", VA = "0x1861E4470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public KMHDPFOFGLH EKOONINMMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9C5BF0", Offset = "0x9C45F0", VA = "0x1809C5BF0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public KMHDPFOFGLH OPNAJPGDJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9C5310", Offset = "0x9C3D10", VA = "0x1809C5310", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public SkinnedMeshRenderer[] KGCLFJGLNBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x127ADB0", Offset = "0x12797B0", VA = "0x18127ADB0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Renderer[] AAPOAMHPHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7CF950", Offset = "0x7CE350", VA = "0x1807CF950", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool PHNNEHGHIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x61E9C30", Offset = "0x61E8630", VA = "0x1861E9C30", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public FHDAOFFBFNF.GIDFDMGKMNF GMAHGNELCFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xECA330", Offset = "0xEC8D30", VA = "0x180ECA330", Slot = "18")]
		get
		{
			return default(FHDAOFFBFNF.GIDFDMGKMNF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int GGCOLOJFJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x20F36E0", Offset = "0x20F20E0", VA = "0x1820F36E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x61E2A10", Offset = "0x61E1410", VA = "0x1861E2A10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private bool IKCLDFFFBMM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x61E5360", Offset = "0x61E3D60", VA = "0x1861E5360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private static bool DJEIKNINEBI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x61EAF00", Offset = "0x61E9900", VA = "0x1861EAF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x61ECAB0", Offset = "0x61EB4B0", VA = "0x1861ECAB0")]
	public NMLDIONDNCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x61E9760", Offset = "0x61E8160", VA = "0x1861E9760", Slot = "21")]
	public void MPOMBMILLLK(JMFJNMCGOPI CPNLJJBHDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x61E7E80", Offset = "0x61E6880", VA = "0x1861E7E80", Slot = "22")]
	public void JKJBCFDBKGC(MBNCAEBANBB DEOPMBLOLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x61E2A10", Offset = "0x61E1410", VA = "0x1861E2A10", Slot = "4")]
	public void CEMAPAEKHFL(int NLNFAEHMBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x61E2820", Offset = "0x61E1220", VA = "0x1861E2820", Slot = "9")]
	public void CEDIHCHBMGF(KCNPANCMBKL NKBIMIGMNOH, Texture2D MGNEEDDHFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x61EAA80", Offset = "0x61E9480", VA = "0x1861EAA80", Slot = "10")]
	public void PEHKJKLBFBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x61E8FF0", Offset = "0x61E79F0", VA = "0x1861E8FF0", Slot = "11")]
	public bool MADJABEFDFN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x61EAB00", Offset = "0x61E9500", VA = "0x1861EAB00", Slot = "8")]
	public void PGMJGNKEICA(MPHEOLFMMEG PKIBDNGBJII, Color? GLALCIBBONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x61E4390", Offset = "0x61E2D90", VA = "0x1861E4390")]
	private void FLGIPLKJDLG(Action OMDOALHFDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x61E4650", Offset = "0x61E3050", VA = "0x1861E4650", Slot = "5")]
	public void GJMKKBJOEDG(CODGFMFKADE FLLDAPGAKBA, Texture OKNCKBAFEJP, Color BBKBGHJHCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x61E7CA0", Offset = "0x61E66A0", VA = "0x1861E7CA0", Slot = "6")]
	public void JDHJCBEEHGP(bool GHLGHGFKCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x9B9920", Offset = "0x9B8320", VA = "0x1809B9920", Slot = "7")]
	public void OMNACBIIBKH(FOCDFAJHPPN BJIJPHEEEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x61EB190", Offset = "0x61E9B90", VA = "0x1861EB190", Slot = "14")]
	public GCGMANBCNNC PKNADDGOJGH(GMJEBCANNBA FLKHDGKMCEE, bool PMBFINDABLL, int[] PNALGGIOALB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x61E9DA0", Offset = "0x61E87A0", VA = "0x1861E9DA0", Slot = "15")]
	public void NHFMBKBOCAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x61EA0D0", Offset = "0x61E8AD0", VA = "0x1861EA0D0")]
	private bool OHFJHFFOFMK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xECA350", Offset = "0xEC8D50", VA = "0x180ECA350", Slot = "19")]
	public void NIAPPMKOCHF(FHDAOFFBFNF.GIDFDMGKMNF EOCHCOLDNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x61E7DC0", Offset = "0x61E67C0", VA = "0x1861E7DC0")]
	private bool JHNFAKKEJGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x61EA210", Offset = "0x61E8C10", VA = "0x1861EA210")]
	private GCGMANBCNNC OLDILAMEJFK(bool PMBFINDABLL, List<JFGMHBONICN> DFACJLHCJFC, int[] PNALGGIOALB, Func<int, NAPAIIIFNCE> LICLALFOIGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x61E2BB0", Offset = "0x61E15B0", VA = "0x1861E2BB0")]
	[IteratorStateMachine(typeof(IIHIMAKLDJN))]
	private IEnumerator<LKAEALCJOPF> DBCENDOOPPK(bool PMBFINDABLL, List<JFGMHBONICN> DFACJLHCJFC, int[] PNALGGIOALB, Func<int, NAPAIIIFNCE> LICLALFOIGG, JAENNKPBIKN JHGGHECBJLI, Material MGPKIFBFDKC, List<GCGMANBCNNC> KBFJHEMMKID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x61E94A0", Offset = "0x61E7EA0", VA = "0x1861E94A0")]
	private GCGMANBCNNC MMCCHKLMLMC(List<JFGMHBONICN> DFACJLHCJFC, int[] PNALGGIOALB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x61E58D0", Offset = "0x61E42D0", VA = "0x1861E58D0")]
	private GLCHHLNPLCE IOEJBDAJCPC(List<JFGMHBONICN> DFACJLHCJFC, int NLNFAEHMBKG, bool PMBFINDABLL, NAPAIIIFNCE MLNMEAKGKNK, bool KHBIONFJFMJ, JAENNKPBIKN JHGGHECBJLI, Material MGPKIFBFDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x61E2CC0", Offset = "0x61E16C0", VA = "0x1861E2CC0")]
	private void DCFHCGPCKLH(SkinnedMeshRenderer DKKIOJNMPDB, Mesh LPABBIBOFCJ, List<Material> FNNLPMMIDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x61E7F90", Offset = "0x61E6990", VA = "0x1861E7F90")]
	private static Material JOKHCCJMCLJ(Dictionary<DPBOMABMKMK, Material> NFOPNPFOGAL, Material OPGEFNEJBGJ, BCEBCMAJFOB PFJBNDALOAM, LCLAAFBEILO IEJEJBPPCHC, DCDDAAOOBKB OENALIHIKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x61E8E50", Offset = "0x61E7850", VA = "0x1861E8E50")]
	private static BCEBCMAJFOB LHLNOGHJPAH(JFGMHBONICN EKBBIMKDDLO, int ILCKDHNLNHP)
	{
		return default(BCEBCMAJFOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x61E4F20", Offset = "0x61E3920", VA = "0x1861E4F20")]
	private void IKGGDELLMPG(int CCCJMKLPKIN, Material FEIOCBKHAFO, JFGMHBONICN EKBBIMKDDLO, [Out] Texture2D GICOGDNJPOG, [Out] Vector4 JNCDPIKHJGD, [Out] Texture2D IGODEHJPOIN, [Out] Texture2D FHOIKPDNPJP, [Out] Texture2D PAJNJIOFAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x61E80F0", Offset = "0x61E6AF0", VA = "0x1861E80F0")]
	private void KDFOCFDPCLA(int CCCJMKLPKIN, Material FEIOCBKHAFO, JFGMHBONICN EKBBIMKDDLO, [Out] Color OCGEEAKKBAC, [Out] Color CGDLFNMGMPH, [Out] Color BMGANOGGPFO, [Out] Color OPNOPCGGBEL, [Out] Color EALLNJMDJAD, [Out] Color DOBFAABDDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x61E9170", Offset = "0x61E7B70", VA = "0x1861E9170")]
	private bool MCHPAOIIJPD(Material FEIOCBKHAFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x61E44C0", Offset = "0x61E2EC0", VA = "0x1861E44C0")]
	private static Material GDMHFMFJLJL(int CCCJMKLPKIN, HCCDBJCBGJB EKBBIMKDDLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x61E87B0", Offset = "0x61E71B0", VA = "0x1861E87B0")]
	private static LCLAAFBEILO KIEHIFPNHDL(JFGMHBONICN EKBBIMKDDLO, int ILCKDHNLNHP)
	{
		return default(LCLAAFBEILO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x61E3250", Offset = "0x61E1C50", VA = "0x1861E3250")]
	private static void DJMKBLDEFHN(Dictionary<string, List<DPBOMABMKMK>> BFHKNAPPOBH, JFGMHBONICN OLJCKNCJAJE, Material OPGEFNEJBGJ, BCEBCMAJFOB PKIBDNGBJII, LCLAAFBEILO NKBIMIGMNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x61EA7E0", Offset = "0x61E91E0", VA = "0x1861EA7E0")]
	private static SkinnedMeshRenderer OPOONLIGHCG(Transform KMLJPBLMPMO, Transform PDPCKLKOMHO, SkinnedMeshRenderer[] OJJJINOJOGJ, int NLNFAEHMBKG, NAPAIIIFNCE MLNMEAKGKNK, bool PMBFINDABLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x61E2DF0", Offset = "0x61E17F0", VA = "0x1861E2DF0")]
	private void DGBBOJAJPNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x61E8C90", Offset = "0x61E7690", VA = "0x1861E8C90")]
	private void KPEPDAIEGIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x61E4C00", Offset = "0x61E3600", VA = "0x1861E4C00")]
	private static void HPMAAIJGOPE(Dictionary<DPBOMABMKMK, Material> NFOPNPFOGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x61E79B0", Offset = "0x61E63B0", VA = "0x1861E79B0")]
	private static void JCIAFJCFNOG(Dictionary<Renderer, JAENNKPBIKN> FBMAEFBIODP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x61E8D30", Offset = "0x61E7730", VA = "0x1861E8D30")]
	private void LHACMOHMOJO(SkinnedMeshRenderer[] OJJJINOJOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x61E7320", Offset = "0x61E5D20", VA = "0x1861E7320")]
	private void IPEIPFLIONL(SkinnedMeshRenderer PCKLLLIOFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x61E9A50", Offset = "0x61E8450", VA = "0x1861E9A50")]
	private void NGEHEAJFDBL(List<KKILGLJEJLC> MCNBJEOMMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x61E53E0", Offset = "0x61E3DE0", VA = "0x1861E53E0")]
	private void ILGMMCDGGLM(Dictionary<string, NGGDDPJIFIN<Texture2D>> BFHKNAPPOBH, bool MHEOLHKCADF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x61E14A0", Offset = "0x61DFEA0", VA = "0x1861E14A0")]
	private void AEFGEDKANCI(Dictionary<string, List<DPBOMABMKMK>> BFHKNAPPOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x61E1F50", Offset = "0x61E0950", VA = "0x1861E1F50")]
	private void BDLINFNNDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x61E7B10", Offset = "0x61E6510", VA = "0x1861E7B10")]
	private void JCMCHPDMCLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x61E1660", Offset = "0x61E0060", VA = "0x1861E1660")]
	private void AHBMBBHALOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x61E93D0", Offset = "0x61E7DD0", VA = "0x1861E93D0")]
	private void MDFLFKBOJFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x61E26A0", Offset = "0x61E10A0", VA = "0x1861E26A0")]
	private void BNBNDDBIMFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x61E3010", Offset = "0x61E1A10", VA = "0x1861E3010")]
	private void DHLDGJINEHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x61E3700", Offset = "0x61E2100", VA = "0x1861E3700")]
	private void EPNEPHBMPOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x61E9FA0", Offset = "0x61E89A0", VA = "0x1861E9FA0")]
	private void NIFKDEPNEEL(bool DJPACICKEGN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x61E8F70", Offset = "0x61E7970", VA = "0x1861E8F70")]
	private void LKNJANPGOGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x61E7CB0", Offset = "0x61E66B0", VA = "0x1861E7CB0")]
	private void JDJKFJPJPGH(bool DJPACICKEGN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x61E2360", Offset = "0x61E0D60", VA = "0x1861E2360")]
	private void BILHPLFLFLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x61E5560", Offset = "0x61E3F60", VA = "0x1861E5560")]
	private void IMCPENEDIJM(Material MGPKIFBFDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x61E20B0", Offset = "0x61E0AB0", VA = "0x1861E20B0")]
	private void BFGLNCJGOCF(Material MGPKIFBFDKC, Color CGDLFNMGMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x61E4AE0", Offset = "0x61E34E0", VA = "0x1861E4AE0")]
	private void HMKFBOOFFLO(Material MGPKIFBFDKC, Color BMGANOGGPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x61EB0A0", Offset = "0x61E9AA0", VA = "0x1861EB0A0")]
	private void PIFCIBNIKOP(Material MGPKIFBFDKC, Color OCGEEAKKBAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x61E3520", Offset = "0x61E1F20", VA = "0x1861E3520")]
	private void DLJCLAGOABM(Material MGPKIFBFDKC, Texture2D MGNEEDDHFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x61E3160", Offset = "0x61E1B60", VA = "0x1861E3160")]
	private void DIMOBLEOFOO(Material MGPKIFBFDKC, Texture GOHDBHIGGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x61E85F0", Offset = "0x61E6FF0", VA = "0x1861E85F0")]
	private void KFHIJILILDJ(Action<JAENNKPBIKN> HHOINHNHAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x61E2A30", Offset = "0x61E1430", VA = "0x1861E2A30")]
	private void CKMELHGBGBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x61E88A0", Offset = "0x61E72A0", VA = "0x1861E88A0")]
	private void KIENDHGDNAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x61E73C0", Offset = "0x61E5DC0", VA = "0x1861E73C0")]
	private GCGMANBCNNC JBNCLIFCADL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x61E0F70", Offset = "0x61DF970", VA = "0x1861E0F70")]
	private void AADLJDNEBFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x61E46C0", Offset = "0x61E30C0", VA = "0x1861E46C0")]
	public void HFIENCPBLPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x61E7D50", Offset = "0x61E6750", VA = "0x1861E7D50")]
	private void JGLCJJNEFNM(Vector3 LDHIOGOHNGO, Quaternion BPHIJKBMKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x61E1BB0", Offset = "0x61E05B0", VA = "0x1861E1BB0")]
	private void AHHNGLAALFI(List<JFGMHBONICN> BNOPDFFPEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x61E3E90", Offset = "0x61E2890", VA = "0x1861E3E90")]
	public void FJINHCMAFOJ(BFLEOALKIFK CPCGAADFLON, bool KPKMGLBDAHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x61E3810", Offset = "0x61E2210", VA = "0x1861E3810")]
	public void FJINHCMAFOJ(BFLEOALKIFK CPCGAADFLON, AnchorParamsRestrictions EFFEOMBCJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8C0D50", Offset = "0x8BF750", VA = "0x1808C0D50")]
	private static void DGIEAAGIEFK(FitMeshHemisphere ANGGECLHLIB, Transform KCFELPAKAKF, BFLEOALKIFK CPCGAADFLON, AnchorParamsRestrictions MFKDOMPHMCE, [Out] Vector3 AFOLKIAHJCP, [Out] Quaternion JEMAGIAEKCI, [Out] BFLEOALKIFK FBEHANCCNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x61E21A0", Offset = "0x61E0BA0", VA = "0x1861E21A0")]
	public void BHOFENINNLH(Vector2 OKLFBIEGBLD, Vector3 GDEMJGPDNEF, Vector3 PPOKIILIAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x61E14F0", Offset = "0x61DFEF0", VA = "0x1861E14F0")]
	private void AGBMJNOOPHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x61E4540", Offset = "0x61E2F40", VA = "0x1861E4540")]
	private void GHMLEDOMBCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x61E7F00", Offset = "0x61E6900", VA = "0x1861E7F00")]
	[CompilerGenerated]
	private void JLGLOCMDLEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x61E9A20", Offset = "0x61E8420", VA = "0x1861E9A20")]
	[CompilerGenerated]
	private void NDJMONBLJFH(JAENNKPBIKN IAAHPBAFEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x61E3630", Offset = "0x61E2030", VA = "0x1861E3630")]
	[CompilerGenerated]
	private void EEONNGCAICJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x61EAA10", Offset = "0x61E9410", VA = "0x1861EAA10")]
	[CompilerGenerated]
	private void PAEEINOLJNO(JAENNKPBIKN IAAHPBAFEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x61E1410", Offset = "0x61DFE10", VA = "0x1861E1410")]
	[CompilerGenerated]
	private void ABHKJMIJLOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x61E3610", Offset = "0x61E2010", VA = "0x1861E3610")]
	[CompilerGenerated]
	private void DMBJPPIHIPD(JAENNKPBIKN IAAHPBAFEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x61EA040", Offset = "0x61E8A40", VA = "0x1861EA040")]
	[CompilerGenerated]
	private void OGHKPIINIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x61E4D60", Offset = "0x61E3760", VA = "0x1861E4D60")]
	[CompilerGenerated]
	private void IBEGBICDBPO(JAENNKPBIKN IAAHPBAFEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x61E8C00", Offset = "0x61E7600", VA = "0x1861E8C00")]
	[CompilerGenerated]
	private void KLOGBEMHKML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x61E36D0", Offset = "0x61E20D0", VA = "0x1861E36D0")]
	[CompilerGenerated]
	private void EOJENLKMOBK(JAENNKPBIKN IAAHPBAFEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x61E3780", Offset = "0x61E2180", VA = "0x1861E3780")]
	[CompilerGenerated]
	private void FJADKHIDDBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x61E27F0", Offset = "0x61E11F0", VA = "0x1861E27F0")]
	[CompilerGenerated]
	private void BPNDHCGGCBH(JAENNKPBIKN IAAHPBAFEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x61E4A50", Offset = "0x61E3450", VA = "0x1861E4A50")]
	[CompilerGenerated]
	private void HHLOBOHNEJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x61EC830", Offset = "0x61EB230", VA = "0x1861EC830")]
	[CompilerGenerated]
	private void PMKMAGFGMHA(JAENNKPBIKN IAAHPBAFEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x61EC7B0", Offset = "0x61EB1B0", VA = "0x1861EC7B0")]
	[CompilerGenerated]
	private void PLHAFJMHKPA(KeyValuePair<string, NGGDDPJIFIN<Texture2D>> LOGHPKNKBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x61E8CA0", Offset = "0x61E76A0", VA = "0x1861E8CA0")]
	[CompilerGenerated]
	private void LFGFAONOCHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x61E4BD0", Offset = "0x61E35D0", VA = "0x1861E4BD0")]
	[CompilerGenerated]
	private void HOPPAMKHPGP(JAENNKPBIKN IAAHPBAFEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x61E2730", Offset = "0x61E1130", VA = "0x1861E2730")]
	[CompilerGenerated]
	private void BOAEECIBPFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x61E27C0", Offset = "0x61E11C0", VA = "0x1861E27C0")]
	[CompilerGenerated]
	private void BOOHEJPMLBM(JAENNKPBIKN IAAHPBAFEHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class GDCACBLAAKC : DGANKBFPJAD
{
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly int LIBANLNDFOL;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly int IMEBFJLEJBM;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly int JLODNBHLIAE;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private static readonly int BLFFEFOBFNF;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static readonly int AIPKMFFCFMG;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly int IDMJJMOEFCA;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly int PLOBKIABLCD;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly int MENMELFODKM;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly int KGGMCDHMMMF;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly int JKKDKOIADHC;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly int ICLLDFAAFPK;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int MAHNMDPBCOO;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int JBKFKJAAIEA;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly int CMLLJLALLIH;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly int HKHMENENBND;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int CEMLLFIAFPC;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int CGBOENENGIB;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int JHMBPHGFJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private Transform PAJJKHIKHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private Transform KDBOLKKJLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private Transform DMDMLHBINOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private Transform HNHFAACBKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private Transform MGOALEHGAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private Transform FEFGKJMJLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private Transform EOLHOEKHHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private HEHLGEJLBPF LBADENLFEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private MaterialPropertyBlock EFONOKINLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private SkinnedMeshRenderer[] DDCHFMANJEP;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private MaterialPropertyBlock IDOCLNOEBEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x61D8240", Offset = "0x61D6C40", VA = "0x1861D8240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x61D8350", Offset = "0x61D6D50", VA = "0x1861D8350", Slot = "6")]
	public void MPOMBMILLLK(HEHLGEJLBPF CHGFLBOHAEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x61D7D00", Offset = "0x61D6700", VA = "0x1861D7D00", Slot = "7")]
	public void DEMEOEKOIIN(FKNAEFHCDDH EMFGGEIGNKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x61D7E10", Offset = "0x61D6810", VA = "0x1861D7E10", Slot = "4")]
	public void JGMLALLCHBD(OBEEACAADBG AIEKOHICFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x61D7CA0", Offset = "0x61D66A0", VA = "0x1861D7CA0")]
	private Vector2 BIGLDPKGMMK(Vector2 MLNKFNOMCIA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x61D8450", Offset = "0x61D6E50", VA = "0x1861D8450", Slot = "5")]
	public void NOEHOICGJHK(LPMABDDJJDG EMFGGEIGNKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x61D9560", Offset = "0x61D7F60", VA = "0x1861D9560")]
	private void PLHNKHNGNDA(LPMABDDJJDG FDPBIMBMECD, GIMEAAOKOMK GHLNOEAPPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x61D7D30", Offset = "0x61D6730", VA = "0x1861D7D30")]
	private void HDKNDMMFBOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x61D9BE0", Offset = "0x61D85E0", VA = "0x1861D9BE0")]
	public GDCACBLAAKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x61D82C0", Offset = "0x61D6CC0", VA = "0x1861D82C0")]
	[CompilerGenerated]
	internal static (float, float) JMLKGEPMOIP(float ICHAHLFDAKJ)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x61D8410", Offset = "0x61D6E10", VA = "0x1861D8410")]
	[CompilerGenerated]
	internal static Vector4 NGFDLKEEIMN(Vector2 DGOJEOCFHHN, Vector2 LFNFJOFKAIK)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class JAENNKPBIKN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private MaterialPropertyBlock OANMMMONGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public Color? KGDKFCMAHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public Color? IJEDDMDLHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public Color? AJAMCKFEHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public Color? FNOKCDHICOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public Color NDDLAAFHKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public Color FBCJHAACKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public Color ANCBCGIKBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public Texture2D PGICEMKLFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public Texture2D ADMJDHHNIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private Dictionary<DPBOMABMKMK, int> MOFMKEAHBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private BCEBCMAJFOB[] KHDEJKLLEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private LCLAAFBEILO[] ENNKDFDMEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public Vector4[] LBEAKHNFBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public Vector4[] MEBOKCGKHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public Vector4[] JDIDMGOKMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public Vector4[] HDIBFFOMEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public Vector4[] LNAJPMDELME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public Vector4[] KDOHDGBJLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private List<Texture2D> GPHELLDLOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private Vector4[] PIEFIHJJHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private List<Texture2D> FJLLGIBOFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private float[] AADIHBGLKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private Vector4[] LAMJHGGKJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private float[] EGINFNHPNIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public float[] ACBMILNJDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private List<Texture2D> NOPCDADOGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private float[] COFKOPFAABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private List<Texture2D> BNGAAMCHMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private Vector4[] IEMNALBFBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private float[] CHNHONDADBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private Vector4[] ELEIGFCIGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public float[] FAMEPPLNNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public Texture2DArray OPJDFKJECIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public Texture2DArray MIHGPONAIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public Texture2DArray BGEIBIFDCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public Texture2DArray OFJLGLCFHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private bool LAOICJICIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int BABJCLHBKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private Vector2? GNFMKLMELLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private TextureFormat IMLPCJICNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private Vector2? ONLBOGAJAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private TextureFormat OEAHIMKMBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private Vector2? FMKJEFJDCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private TextureFormat GJJPHCBFEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private Vector2? FHODDNFGNBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private TextureFormat ODJPLDAGGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private bool OGOJAHMCHNJ;

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static int AKEECJEHPDA;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static int IGMGLOIEIHG;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static int GDLAMKJDJKN;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static int NNALCFPAAGE;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static int PPLAMOAHJOO;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static int DCNKLPDHMBJ;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static int FHHHGIKMIAL;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static int MALDKEPOKLP;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static int IJPGDKNAIGP;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static int KGJEEICDHHL;

	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private static int EAOBHCCKLII;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private static int CNBAJGKPIAD;

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private static int NIAKMDBGKBF;

	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private static int PCPCPGBIFLH;

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private static int ADKMLKBKKLK;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private static int BGLIMPNCOBD;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static int IDMAICNCMDB;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static int GNMPNDLOIPB;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private static int HMOFIGKPCIN;

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static int MNDCCHKNBPG;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x61F59A0", Offset = "0x61F43A0", VA = "0x1861F59A0")]
	private JAENNKPBIKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x61F58E0", Offset = "0x61F42E0", VA = "0x1861F58E0")]
	public JAENNKPBIKN(Color MCBFLGOOEGK, Color HMKGPLPMLAD, Color HIBJLDKNPHB, Color? JDCBFNFLLFB, Color? MJLHEBCPDKF, Color? OOCJFLCAKFC, Texture2D GAFDOKJCNPA, Texture2D HOAGIEDJFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x61F33B0", Offset = "0x61F1DB0", VA = "0x1861F33B0")]
	internal int ANHLCMOPHFL(Material KJPHPBBFKDP, BCEBCMAJFOB PFJBNDALOAM, LCLAAFBEILO IEJEJBPPCHC, DCDDAAOOBKB OENALIHIKIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x61F34A0", Offset = "0x61F1EA0", VA = "0x1861F34A0")]
	private int ANHLCMOPHFL(DPBOMABMKMK KLDFLAABJKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x61F42C0", Offset = "0x61F2CC0", VA = "0x1861F42C0")]
	internal int EDECMJMDFGL(Material KJPHPBBFKDP, Color OCGEEAKKBAC, Color CGDLFNMGMPH, Color BMGANOGGPFO, Color OPNOPCGGBEL, Color EALLNJMDJAD, Texture2D ABGGEHEMEDN, Vector4 AEAAGPCKCON, Texture2D EBPNELKICOM, Vector4 FOHAOGOHCND, float GMJOHCJMKBH, float OPFAINKLNKN, Texture2D CFMGJNJBNGI, Vector4 AMJPOOEAIMC, float CAFACDJPAEN, Texture2D BPOOHHMABAE, Color DOBFAABDDND, Vector4 FHPFPHOEPIC, BCEBCMAJFOB PFJBNDALOAM, LCLAAFBEILO IEJEJBPPCHC, DCDDAAOOBKB OENALIHIKIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x61F5390", Offset = "0x61F3D90", VA = "0x1861F5390")]
	private void NBPMMEKHECN(List<Texture2D> GPHELLDLOAG, [Out] Texture2DArray ECMKCIACOAI, [Out] Texture2DArray NHILENDAOJP, [Out] Texture2DArray AMJJJJNMMBH, [Out] Texture2DArray GEJPENGNMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x61F3260", Offset = "0x61F1C60", VA = "0x1861F3260")]
	public void AGDBANFNCJC(Shader JBGEAJDKNAC, Renderer LDIKCIPDAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x61F3530", Offset = "0x61F1F30", VA = "0x1861F3530")]
	private void DLPCIAIFEFG(Shader JBGEAJDKNAC, Renderer LDIKCIPDAKN, int FBMJKMGELIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x61F50E0", Offset = "0x61F3AE0", VA = "0x1861F50E0")]
	private Color LPDCEMMCJNG(Color AIFLCGKAJGL, BCEBCMAJFOB PKIBDNGBJII)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x61F4F90", Offset = "0x61F3990", VA = "0x1861F4F90")]
	private Color JHOLODJMAIK(Color IHEMDDPMNKC, BCEBCMAJFOB PKIBDNGBJII)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x61F4E90", Offset = "0x61F3890", VA = "0x1861F4E90")]
	private bool GOMOIJHHBCJ(Texture2D JPODJJONIFB, LCLAAFBEILO NKBIMIGMNOH, [Out] Texture2D MOIBKKJOEAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x61F52E0", Offset = "0x61F3CE0", VA = "0x1861F52E0")]
	private void MMKBGEJMPDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x61F4280", Offset = "0x61F2C80", VA = "0x1861F4280", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		[Obsolete("Use CombinationId instead!")]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private OAMGKCPJLHC? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public KHIGNFPBAIG CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x61EE6B0", Offset = "0x61ED0B0", VA = "0x1861EE6B0")]
			get
			{
				return default(KHIGNFPBAIG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public OAMGKCPJLHC MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x61EE700", Offset = "0x61ED100", VA = "0x1861EE700")]
			get
			{
				return default(OAMGKCPJLHC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7C68D0", Offset = "0x7C52D0", VA = "0x1807C68D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7CF990", Offset = "0x7CE390", VA = "0x1807CF990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x61EE500", Offset = "0x61ECF00", VA = "0x1861EE500")]
		public Material[] ODFEFLPJFHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x61EE340", Offset = "0x61ECD40", VA = "0x1861EE340")]
		public static void DIAENFOIACF(AvatarItemMaterial BDLGIGMIOAB, Material FEIOCBKHAFO, int CCCJMKLPKIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x61EE5E0", Offset = "0x61ECFE0", VA = "0x1861EE5E0")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[JFFHACELPPM]
public struct DACIEAJPNEB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	[ReadOnly]
	public LJBAMJHJPJK DAAIBIINNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	[ReadOnly]
	public int DMJGLAOIAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public GDNFLNKMMKL LFAACGPNMLH;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x61EEC60", Offset = "0x61ED660", VA = "0x1861EEC60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[NativeContainer]
[JFFHACELPPM]
public struct GDNFLNKMMKL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public NativeArray<Vector3> GMMGMGFPBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public NativeArray<Vector3> GAPFMLEFPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public NativeArray<Vector4> KNFFNHCMIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public NativeArray<Vector2> LOGPMEGCBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public NativeArray<Vector2> CDNFIJCJJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public NativeArray<Vector2> EPFFOPJDDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public NativeArray<Vector2> BIHHKLIMKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public NativeArray<Color> NGOHBEHKAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public NativeArray<int> IICGEECIAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public NativeArray<int> MPLICPKJKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private NativeArray<int> FMJPGAAJMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private NativeArray<int> FOKLGMEAHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public NativeArray<int> GIBMFPPKFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public NativeArray<int> IEGIHEEFODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeArray<int> MEPEANGMOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<BoneWeight> LIIBOFHLHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private NativeArray<int> BJIJPHEEEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private bool BELHBDKBHED;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int APBPGAMKNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x61F1AD0", Offset = "0x61F04D0", VA = "0x1861F1AD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x61F1180", Offset = "0x61EFB80", VA = "0x1861F1180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int NJJKPAOCIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x61F1B10", Offset = "0x61F0510", VA = "0x1861F1B10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x61F13A0", Offset = "0x61EFDA0", VA = "0x1861F13A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int PHPNANJKNFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x61F1550", Offset = "0x61EFF50", VA = "0x1861F1550")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x61F1AE0", Offset = "0x61F04E0", VA = "0x1861F1AE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x61F1B20", Offset = "0x61F0520", VA = "0x1861F1B20")]
	public GDNFLNKMMKL(int HHBGPDLCPGL, int NOHHJOLJFAG, int BGIMMLEFDFB, int MJIOAOLMJAI, Allocator IMPJLMNPHBC, int GAGMCAEGOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x61F15B0", Offset = "0x61EFFB0", VA = "0x1861F15B0")]
	public void LKKPIGJKMGD(int ABBNIPHGMGH, Vector3 DIAGEGELNFD, Vector3 ANGOLELPPJD, Vector4 BIKAIHEBIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x61F13B0", Offset = "0x61EFDB0", VA = "0x1861F13B0")]
	public void IOJCIEGBIOM(int ABBNIPHGMGH, BoneWeight ABKCNLALFNA, NativeSlice<byte> NJADLNBPEFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x61F1340", Offset = "0x61EFD40", VA = "0x1861F1340")]
	public Color HKHAPJAFAEI(int ABBNIPHGMGH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x61F1AF0", Offset = "0x61F04F0", VA = "0x1861F1AF0")]
	public void POPEGMHDDAA(int ABBNIPHGMGH, Color KMFGKGNHDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x61F1560", Offset = "0x61EFF60", VA = "0x1861F1560")]
	public void KIACFPGLIPI(byte AHCAPMINPKN, int ABBNIPHGMGH, Vector2 EMDEAKLLBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x61F1390", Offset = "0x61EFD90", VA = "0x1861F1390")]
	public void IBLMKCMCJOM(int ABBNIPHGMGH, int FLNPDIIPDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x61F1360", Offset = "0x61EFD60", VA = "0x1861F1360")]
	public bool HNJPMHGODCC(int AHCAPMINPKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x61F1970", Offset = "0x61F0370", VA = "0x1861F1970")]
	public void MHMPFMNEOAN(int CCHLNEGDPEH, int KNFIDNLGJFO, int JEKCEPEEELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x61F10D0", Offset = "0x61EFAD0", VA = "0x1861F10D0")]
	public int[] CACJDIJODCO(int CCHLNEGDPEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x61F1A40", Offset = "0x61F0440", VA = "0x1861F1A40")]
	private NativeSlice<int> OGGOEFJJFCG(int CCHLNEGDPEH)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x61F1190", Offset = "0x61EFB90", VA = "0x1861F1190", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x61F1620", Offset = "0x61F0020", VA = "0x1861F1620")]
	public Mesh MEDINNLHHMI([Optional] string EBBPHLGMKIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[NativeContainer]
[DefaultMember("Item")]
[JFFHACELPPM]
public struct LJBAMJHJPJK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeArray<Vector3> GMMGMGFPBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public NativeArray<Vector3> GAPFMLEFPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<Vector4> KNFFNHCMIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeArray<Vector2> LOGPMEGCBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeArray<Vector2> CDNFIJCJJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public NativeArray<Vector2> EPFFOPJDDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public NativeArray<Vector2> BIHHKLIMKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public NativeArray<Color> NGOHBEHKAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public NativeArray<int> LMMFLEBNNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public NativeArray<int> ODNHKOAKIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<int> NLNCAIFBPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public NativeArray<int> AELEJLJAAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<bool> DIMALDNLEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public NativeArray<int> GFFNLOOLLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public NativeArray<int> GOFBENNOCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeArray<BoneWeight> PEDPLCNBJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private NativeArray<Matrix4x4> EMDMMMEECBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private NativeArray<int> BHNFAAONJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private NativeArray<byte> GBCCPALDBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private NativeArray<int> NBKMNEOGDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private NativeArray<int> GJOKEFBOAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<sbyte> BIDHJJMNPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<byte> HGDIIFBLPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private NativeArray<int> MIFKNJBAFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private bool BELHBDKBHED;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int DKMGIKNBABG
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int FIJEHNOIOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xECA330", Offset = "0xEC8D30", VA = "0x180ECA330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int OBILAJNFLHA
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x61F6710", Offset = "0x61F5110", VA = "0x1861F6710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int DAGFPNMENGL
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x61F6110", Offset = "0x61F4B10", VA = "0x1861F6110")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x61F6790", Offset = "0x61F5190", VA = "0x1861F6790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int APBPGAMKNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x61F6780", Offset = "0x61F5180", VA = "0x1861F6780")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x61F5E90", Offset = "0x61F4890", VA = "0x1861F5E90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int AEPNGMDMFLC
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x61F6740", Offset = "0x61F5140", VA = "0x1861F6740")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x61F6770", Offset = "0x61F5170", VA = "0x1861F6770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public JBJFMNNMMIG KJKBHOFPLPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x61F6750", Offset = "0x61F5150", VA = "0x1861F6750")]
		get
		{
			return default(JBJFMNNMMIG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x61F6760", Offset = "0x61F5160", VA = "0x1861F6760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public byte PLMNJHMFFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x61F6100", Offset = "0x61F4B00", VA = "0x1861F6100")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x61F67A0", Offset = "0x61F51A0", VA = "0x1861F67A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public ECIDEFJIDKB MIEEOIIACLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x61F61F0", Offset = "0x61F4BF0", VA = "0x1861F61F0")]
		get
		{
			return default(ECIDEFJIDKB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x61F67B0", Offset = "0x61F51B0", VA = "0x1861F67B0")]
	public LJBAMJHJPJK(IList<Mesh> JCNOGFNDEND, IList<Matrix4x4> CAFBHKKILNA, IList<bool> DIMALDNLEGH, byte NPONMGLIMAN, IList<byte[]> IIONCMFIPIF, IList<int> OEMGGDKONLC, IList<bool> NNEEFOJAAGP, IList<int> GFFNLOOLLOM, IList<int> EHLGJMHIEEH, IList<int> NIIBLANMDOG, Allocator IMPJLMNPHBC, JBJFMNNMMIG JLOPPOHIFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x61F6120", Offset = "0x61F4B20", VA = "0x1861F6120")]
	public GDNFLNKMMKL HBAHALJNNAH(Allocator IMPJLMNPHBC)
	{
		return default(GDNFLNKMMKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x61F5EA0", Offset = "0x61F48A0", VA = "0x1861F5EA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[JFFHACELPPM]
public class DPKAHNHBIFJ : HFAMMPPAAPN
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x61EFF10", Offset = "0x61EE910", VA = "0x1861EFF10")]
	public LJBAMJHJPJK DNNOEGMKCHL()
	{
		return default(LJBAMJHJPJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x61D5E60", Offset = "0x61D4860", VA = "0x1861D5E60")]
	public DPKAHNHBIFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct ECIDEFJIDKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public NativeSlice<Vector3> GMMGMGFPBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public NativeSlice<Vector3> GAPFMLEFPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeSlice<Vector4> KNFFNHCMIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeSlice<Vector2> LOGPMEGCBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeSlice<Vector2> CDNFIJCJJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeSlice<Vector2> EPFFOPJDDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeSlice<Vector2> BIHHKLIMKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public NativeSlice<Color> NGOHBEHKAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeSlice<int> AJMAAPDFGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeSlice<int> AELEJLJAAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeSlice<BoneWeight> PEDPLCNBJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeSlice<byte> EDMJKLHDLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public int NKCGMDDAEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public Matrix4x4 EHGJKOOBLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public int MHIIBAHPPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeSlice<byte> NJADLNBPEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public bool DHLJMLPAAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int HLOENLPEHBG;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal readonly struct DPBOMABMKMK : IEquatable<DPBOMABMKMK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	internal readonly Material JFAIEMENCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	internal readonly BCEBCMAJFOB MCMJIMAGGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	internal readonly LCLAAFBEILO BHBGKHEGOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	internal readonly DCDDAAOOBKB ADNEMGJDKLL;

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x8D9410", Offset = "0x8D7E10", VA = "0x1808D9410")]
	public DPBOMABMKMK(Material FEIOCBKHAFO, BCEBCMAJFOB PFJBNDALOAM, LCLAAFBEILO IEJEJBPPCHC, DCDDAAOOBKB OENALIHIKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x61EFCF0", Offset = "0x61EE6F0", VA = "0x1861EFCF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x8D9170", Offset = "0x8D7B70", VA = "0x1808D9170", Slot = "4")]
	public bool Equals(DPBOMABMKMK HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x61EFB70", Offset = "0x61EE570", VA = "0x1861EFB70", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x61EFC50", Offset = "0x61EE650", VA = "0x1861EFC50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class FCAOGCPJOPO
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class HMJMGLGPCBB : IEnumerator<LKAEALCJOPF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private LKAEALCJOPF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private LKAEALCJOPF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7C2410", Offset = "0x7C0E10", VA = "0x1807C2410")]
		[DebuggerHidden]
		public HMJMGLGPCBB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8DF690", Offset = "0x8DE090", VA = "0x1808DF690", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x61F3210", Offset = "0x61F1C10", VA = "0x1861F3210", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
	public static void PAKLBIOAMAH(string MCGNHGLIJDN, int NLNFAEHMBKG, long BCPGLELOCBH, long NLGKCHGAKBN, long OLKKMOFPJPJ, long GDNGEGGKFNM, long NFMCJOLPGMG, long NOOPHGFJPDP, long HENGMKHECHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x61F0280", Offset = "0x61EEC80", VA = "0x1861F0280")]
	public static GLCHHLNPLCE ONBENBPCJIL(JobHandle HHEENGKABPG, bool IJNEADOBLNH, bool LAKNPMFDBPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x61F0210", Offset = "0x61EEC10", VA = "0x1861F0210")]
	[IteratorStateMachine(typeof(HMJMGLGPCBB))]
	private static IEnumerator<LKAEALCJOPF> KNJLGDANCLH(JobHandle MEGCFGBDKPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class NBPMEPPHGEH : BOPJNHIFHEI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private KFNMADHNKCJ DKKBJFCAAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private OJCLDCNBJII NIIDBLCEIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private IRecRoomQualityConfigProvider KNPGBLJCAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private bool BELHBDKBHED;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x61F8730", Offset = "0x61F7130", VA = "0x1861F8730")]
	[JCOMPLNHMEG(AOHDMBIABEL.GameOnly)]
	private static void PCICJDLANGM(ICKBMMGCCPN NFHEIBLLDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5549270", Offset = "0x5547C70", VA = "0x185549270")]
	[UnityEngine.Scripting.Preserve]
	public NBPMEPPHGEH([JDJLHBHAJCP(null)] OJCLDCNBJII KAOKMPMIOGF, [JDJLHBHAJCP(null)] KFNMADHNKCJ HKHIGMJAGNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x61F86C0", Offset = "0x61F70C0", VA = "0x1861F86C0")]
	private void OPKGBMNGEFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x61F8830", Offset = "0x61F7230", VA = "0x1861F8830", Slot = "4")]
	public void PEHKJKLBFBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x61F8200", Offset = "0x61F6C00", VA = "0x1861F8200", Slot = "5")]
	public NGGDDPJIFIN<Texture2D> OKGKAHJKAFJ(CBAJEIFIAPH PMDGAGNFJOE, [Optional] FOCDFAJHPPN BJIJPHEEEMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x61F80C0", Offset = "0x61F6AC0", VA = "0x1861F80C0")]
	private uint HIBJEBBGJIL(CBAJEIFIAPH PMDGAGNFJOE, FOCDFAJHPPN BJIJPHEEEMG)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface MAFMCHDBCLE
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OMIJIBCAKIO(Mesh LPABBIBOFCJ, Matrix4x4 JJNDLPCNBCJ, byte[] NJADLNBPEFE, bool IKCBGIHHBND = false, FHDAOFFBFNF.GIDFDMGKMNF KBCPHDAJKIP = (FHDAOFFBFNF.GIDFDMGKMNF)0, int GFFNLOOLLOM = -1, bool DIMALDNLEGH = false);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MOGKHFFAMAN(Allocator IMPJLMNPHBC, JBJFMNNMMIG JLOPPOHIFCG, byte NPONMGLIMAN, [Optional] IList<int> EHLGJMHIEEH, [Optional] IList<int> NDEDPPLIMIA);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct EEICMIGKAFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly GameObject JECFLCILPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private readonly AvatarItemMaterial FGDIDHOILPN;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x95C330", Offset = "0x95AD30", VA = "0x18095C330")]
	public EEICMIGKAFG(GameObject JECFLCILPCJ, AvatarItemMaterial FGDIDHOILPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x61F0000", Offset = "0x61EEA00", VA = "0x1861F0000")]
	public void AIOILBGPOLK(Material FEIOCBKHAFO, int CCCJMKLPKIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class HLCLGIOBICB : NPKMBFFFIFA<Task<(GameObject, AvatarItemMaterial)>, EEICMIGKAFG>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct AOFOHHIKIIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x61EDDD0", Offset = "0x61EC7D0", VA = "0x1861EDDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x61EE2D0", Offset = "0x61ECCD0", VA = "0x1861EE2D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private NGGDDPJIFIN<GameObject> HCDFBJEJIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private NGGDDPJIFIN<AvatarItemMaterial> ANJDICCLEBL;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x61F3180", Offset = "0x61F1B80", VA = "0x1861F3180")]
	private HLCLGIOBICB(Task<(GameObject, AvatarItemMaterial)> KPCFMNKKKMJ, NGGDDPJIFIN<GameObject> KIGAPDCEPAA, NGGDDPJIFIN<AvatarItemMaterial> KIHMKGIIFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x61F2C40", Offset = "0x61F1640", VA = "0x1861F2C40")]
	public static HLCLGIOBICB HGOBECNKDLP(AssetReference MIHJGIAEDFC, [Optional] AssetReference LBAOFCMEJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x61F2B20", Offset = "0x61F1520", VA = "0x1861F2B20", Slot = "11")]
	protected override EEICMIGKAFG CDGDFAGEMJP(Task<(GameObject, AvatarItemMaterial)> HKKKEIOEHAC)
	{
		return default(EEICMIGKAFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x61F2BC0", Offset = "0x61F15C0", VA = "0x1861F2BC0", Slot = "12")]
	protected override void CEHCKDJCNPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x61F3050", Offset = "0x61F1A50", VA = "0x1861F3050")]
	[AsyncStateMachine(typeof(AOFOHHIKIIJ))]
	private static Task<(GameObject, AvatarItemMaterial)> PIIDABHGPAI(Task<GameObject> CHGLHHDEIPA, Task<AvatarItemMaterial> BPBFIFFNODK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class HFOJIAJKNID : NPKMBFFFIFA<Task<(Material, MaterialMapAsset)>, Material>
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class FCLGPAFPAGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public Material mat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public MaterialEntry entry;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public FCLGPAFPAGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x61F03D0", Offset = "0x61EEDD0", VA = "0x1861F03D0")]
		internal object NKCKMPOPJIG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class CFGIPBMFKAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public string shaderNameToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public FCLGPAFPAGM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public CFGIPBMFKAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x61EE7C0", Offset = "0x61ED1C0", VA = "0x1861EE7C0")]
		internal object FANPKHNLELL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x61EEA10", Offset = "0x61ED410", VA = "0x1861EEA10")]
		internal object IGKPEMHIMCI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct OLNFOLLAEMC<T1, T2> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public AsyncTaskMethodBuilder<(T1, T2)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private T1 <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private TaskAwaiter<T1> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private TaskAwaiter<T2> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x421AE40", Offset = "0x4219840", VA = "0x18421AE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x421B4B0", Offset = "0x4219EB0", VA = "0x18421B4B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly LBNENDFDEJK EMEAPIGMNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private NGGDDPJIFIN<Material> EAGANJGPELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private NGGDDPJIFIN<MaterialMapAsset> JLHGADLGDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private bool ABMIPCOGGII;

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x61F27C0", Offset = "0x61F11C0", VA = "0x1861F27C0")]
	public static HFOJIAJKNID KLEEPKEKLPP(AssetReference COOFDHOPAGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x61F2570", Offset = "0x61F0F70", VA = "0x1861F2570")]
	private static NGGDDPJIFIN<MaterialMapAsset> CLOFKBJHMKH(AssetReference COOFDHOPAGL, [Out] bool ABMIPCOGGII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x61F2A90", Offset = "0x61F1490", VA = "0x1861F2A90")]
	private HFOJIAJKNID(Task<(Material, MaterialMapAsset)> KPCFMNKKKMJ, NGGDDPJIFIN<Material> EAGANJGPELA, NGGDDPJIFIN<MaterialMapAsset> APBHNFDLOJN, bool ABMIPCOGGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x61F1F60", Offset = "0x61F0960", VA = "0x1861F1F60", Slot = "11")]
	protected override Material CDGDFAGEMJP(Task<(Material, MaterialMapAsset)> HKKKEIOEHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x61F21A0", Offset = "0x61F0BA0", VA = "0x1861F21A0")]
	private void CIDNDPCNLBH(Material DPMDGFHGJDJ, MaterialMapAsset BFHKNAPPOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x61F2140", Offset = "0x61F0B40", VA = "0x1861F2140", Slot = "12")]
	protected override void CEHCKDJCNPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x296A420", Offset = "0x2968E20", VA = "0x18296A420")]
	[AsyncStateMachine(typeof(OLNFOLLAEMC<, >))]
	private static Task<(T1, T2)> JIFIKFFHJKD<T1, T2>(Task<T1> JHJKBHEENED, Task<T2> DMALIFMIMPA)
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
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[JBAFOAIPPLI(PHOLEAOCMFP.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x61F8890", Offset = "0x61F7290", VA = "0x1861F8890")]
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
		private struct FFFHGCMMBHN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			public AsyncTaskMethodBuilder<CBBDDFPEFMJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public int eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			private TaskAwaiter<CBBDDFPEFMJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x61F0440", Offset = "0x61EEE40", VA = "0x1861F0440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x61F0780", Offset = "0x61EF180", VA = "0x1861F0780", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private Dictionary<FMIFMPDKCJC, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private Dictionary<FMIFMPDKCJC, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private Dictionary<FMIFMPDKCJC, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private Dictionary<FMIFMPDKCJC, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private readonly Dictionary<FMIFMPDKCJC, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private CBBDDFPEFMJ _defaultFaceStyle;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x61F10A0", Offset = "0x61EFAA0", VA = "0x1861F10A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x61F0FC0", Offset = "0x61EF9C0", VA = "0x1861F0FC0")]
		public CBBDDFPEFMJ NCAMFNDBFID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x61F0E90", Offset = "0x61EF890", VA = "0x1861F0E90")]
		[AsyncStateMachine(typeof(FFFHGCMMBHN))]
		public Task<CBBDDFPEFMJ> NBIFHNFECKN(int LBPPFIEJPEA, int NPHAMPIHGDD, int GJLLFCAIPCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x61F0920", Offset = "0x61EF320", VA = "0x1861F0920")]
		public NoseFaceOption FOKDJOHNANE(int CFCGAHOCMDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x61F09C0", Offset = "0x61EF3C0", VA = "0x1861F09C0")]
		public SelectableFaceOption JBLDKICPDBH(FaceFeatureType BHLNJGBFGEM, FMIFMPDKCJC IGMBPAGFJHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x61F08A0", Offset = "0x61EF2A0", VA = "0x1861F08A0")]
		public int EAJCADKOMKM(FMIFMPDKCJC IGMBPAGFJHL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x61F0C60", Offset = "0x61EF660", VA = "0x1861F0C60")]
		private void MFGGHLGHHLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2945BD0", Offset = "0x29445D0", VA = "0x182945BD0")]
		private void GPPNABAOGGM<T>(IDictionary<FMIFMPDKCJC, T> CGFGKINIJBO, IReadOnlyList<T> AHMGLPFKINM) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x61F07F0", Offset = "0x61EF1F0", VA = "0x1861F07F0")]
		public FMIFMPDKCJC AEAPCJJOGGG(FaceFeatureType BHLNJGBFGEM)
		{
			return default(FMIFMPDKCJC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x61F0B40", Offset = "0x61EF540", VA = "0x1861F0B40")]
		public FMIFMPDKCJC MEHGJFPJJJC(FaceFeatureType BHLNJGBFGEM)
		{
			return default(FMIFMPDKCJC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x61F1010", Offset = "0x61EFA10", VA = "0x1861F1010")]
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
